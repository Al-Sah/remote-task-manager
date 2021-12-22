using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;
using TaskManager;
using Action = TaskManager.Action;

// grpc enum

namespace ControlPanel.Core
{
    public class ConnectionManager : IDisposable
    {
        private GrpcConnectionManager.GrpcConnectionManagerClient? _client;
        private Thread? _grpcRunner;


        public delegate void NewItem(string message);

        public event NewItem? NewDataReceived;
        public event NewItem? NewNotificationRecived;
        public event NewItem? ExceptionCaught;

        private bool _run;

        public void SetupConnection(GrpcChannel grpcChannel) =>
            _client = new GrpcConnectionManager.GrpcConnectionManagerClient(grpcChannel);

        public void ShutDownConnection() => _run = false;

        public void RunClient()
        {
            _grpcRunner = new Thread(() =>
            {
                try
                {
                    if (_client is null)
                    {
                        throw new NullReferenceException();
                    }

                    if (_run)
                    {
                        return;
                    }

                    _run = true;

                    var task = Task.Run(async () => await _runClient());
                    task.Wait();
                }
                catch (Exception exception)
                {
                    _run = false;
                    Debug.WriteLine($"Exception caught: {exception}");
                }
            });
            _grpcRunner.Start();
        }

        public bool IsRunning() => _run;


        private async Task _runClient()
        {
            using var call = _client!.Run();

            var responseReaderTask = Task.Run(async () =>
            {
                await foreach (var message in call.ResponseStream.ReadAllAsync())
                {
                    if (message != null)
                    {
                        NewDataReceived?.Invoke(message.Message);
                    }
                }
            });

            while (_run)
            {
                Thread.Sleep(1500);
                await call.RequestStream.WriteAsync(new RequestMgs {Message = string.Empty, Action = Action.Get});
            }

            await call.RequestStream.CompleteAsync();
            await responseReaderTask;
        }

        public void Dispose()
        {
            if (_grpcRunner is {IsAlive: true})
            {
                _run = false;
                try
                {
                    _grpcRunner.Join();
                }
                catch
                {
                    // ignored
                }
            }
        }
    }
}