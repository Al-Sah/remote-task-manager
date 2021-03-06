using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;
using TaskManager;

namespace ControlPanel.Core
{
    public class ConnectionManager : IDisposable, IForbiddenProcessesManager
    {
        private GrpcConnectionManager.GrpcConnectionManagerClient? _client;
        private Thread? _mainCallHandler;
        private GrpcChannel? _grpcChannel;
        private AsyncDuplexStreamingCall<RequestMgs, ReplyMsg>? _mainCall;


        public delegate void NewData(List<ProcessInformation> processes);

        public delegate void NewException(string message);

        public event NewData? NewDataReceived;
        public event NewException? ExceptionCaught;


        public bool SetupNewConnection(ServerInfo serverInfo)
        {
            var task = Task.Run(async () => await EndMainCall());
            task.Wait();

            var httpHandler = new HttpClientHandler();
            // Return `true` to allow certificates that are untrusted/invalid
            httpHandler.ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            _grpcChannel = GrpcChannel.ForAddress($"https://{serverInfo.Address}:{serverInfo.Port}",
                new GrpcChannelOptions {HttpHandler = httpHandler});

            _client = new GrpcConnectionManager.GrpcConnectionManagerClient(_grpcChannel);
            return _client != null;
        }

        public void StartMainCall()
        {
            if (_client == null)
            {
                return;
            }

            _mainCallHandler = new Thread(() =>
            {
                try
                {
                    if (_client is null)
                    {
                        throw new NullReferenceException();
                    }

                    var task = Task.Run(async () => await MainCallHandler());
                    task.Wait();
                }
                catch (Exception exception)
                {
                    ExceptionCaught?.Invoke(exception.Message);
                    Debug.WriteLine($"Exception caught: {exception}");
                }
            });
            _mainCallHandler.Start();
        }


        private async Task EndMainCall()
        {
            if (_mainCall != null)
            {
                await _mainCall.RequestStream.WriteAsync(new RequestMgs {Message = "End"});
                await _mainCall.RequestStream.CompleteAsync();
            }
        }

        // handler for the bidirectional grpc call
        private async Task MainCallHandler()
        {
            _mainCall = _client!.Get();

            var responseReaderTask = Task.Run(async () =>
            {
                await foreach (var message in _mainCall.ResponseStream.ReadAllAsync())
                {
                    if (message != null)
                    {
                        NewDataReceived?.Invoke(message.ProcessesList.ToList());
                    }
                    else
                    {
                        Debug.WriteLine($"{DateTime.Now} Income message is null");
                    }
                }
            });

            await _mainCall.RequestStream.WriteAsync(new RequestMgs {Message = "Start"});
            // wait until calling EndMainCall
            await responseReaderTask;
        }

        public void Dispose()
        {
            ShutDownConnection();
            if (_mainCallHandler is not {IsAlive: true})
            {
                return;
            }

            try
            {
                _mainCallHandler.Join();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        public void ShutDownConnection()
        {
            var task = Task.Run(async () => await EndMainCall());
            task.Wait();
        }

        private bool ChanReady()
        {
            return true;
            //TODO not working
            //return _grpcChannel?.State == ConnectivityState.Ready;
        }

        private bool BadChannel()
        {
            return !ChanReady();
            // TODO not working
            //return _grpcChannel?.State == ConnectivityState.Ready;
        }

        public List<ProcessStatus> DeleteProcesses(IEnumerable<int> processesIds)
        {
            if (_client == null || BadChannel())
            {
                throw new NoConnectionException();
            }

            var request = new KillRequest();
            request.ProcessId.AddRange(processesIds);
            return _client.Kill(request).Results.ToList();
        }

        public List<ProcessStatus> StartNewProcesses(IEnumerable<StartupInformation> processes)
        {
            if (_client == null || BadChannel())
            {
                throw new NoConnectionException();
            }

            var request = new StartRequest();
            request.StartupRequests.AddRange(processes);
            return _client.Start(request).Results.ToList();
        }

        public List<ProcessStatus> ModifyProcesses(IEnumerable<Modification> processes)
        {
            if (_client == null || BadChannel())
            {
                throw new NoConnectionException();
            }

            var request = new ModifyRequest();
            request.Modifications.AddRange(processes);
            return _client.Modify(request).Results.ToList();
        }

        public string ManageForbidden(string name, IForbiddenProcessesManager.ForbidAction action)
        {
            if (_client == null || BadChannel())
            {
                throw new NoConnectionException();
            }

            var request = new ForbidRequest
            {
                Message = name
            };
            return action == IForbiddenProcessesManager.ForbidAction.Add
                ? _client.AddForbidden(request).Message
                : _client.RemoveForbidden(request).Message;
        }


        public List<string> GetForbidden()
        {
            if (_client == null || BadChannel())
            {
                throw new NoConnectionException();
            }

            return _client.GetForbiddenNames(new ForbidRequest()).Names.ToList();
        }
    }
}