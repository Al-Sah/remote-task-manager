using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using TaskManager.Core;

namespace TaskManager.Services
{
    public class ConnectionService : GrpcConnectionManager.GrpcConnectionManagerBase
    {
        private readonly ILogger<ConnectionService> _logger;

        public ConnectionService(ILogger<ConnectionService> logger)
        {
            _logger = logger;
        }

        private bool _runnable;
        private int _time = 1000;
        private Thread _processesGetter;


        private async void ThreadStart(IAsyncStreamWriter<ReplyMsg> responseStream)
        {
            while (_runnable)
            {
                var replyMsg = new ReplyMsg();
                replyMsg.ProcessesList.AddRange(Process.GetProcesses().Select(ProcessInformationConstructor.FromProcess)
                    .ToList());
                await responseStream.WriteAsync(replyMsg);
                Thread.Sleep(_time);
            }
        }

        public override Task<KillResponse> Kill(KillRequest request, ServerCallContext context)
        {
            var response = new KillResponse();
            foreach (var pid in request.ProcessId)
            {
                try
                {
                    Process.GetProcessById(pid).Kill();
                    response.Results.Add(new ProcessStatus {Id = pid, Status = "Ok"});
                }
                catch (Exception e)
                {
                    response.Results.Add(new ProcessStatus {Id = pid, Status = e.Message});
                }
            }

            return Task.FromResult(response);
        }

        public override Task<StartResponse> Start(StartRequest request, ServerCallContext context)
        {
            var response = new StartResponse();
            foreach (var startupInformation in request.StartupRequests)
            {
                try
                {
                    var process = new Process();
                    process.StartInfo.FileName = startupInformation.Name;
                    process.StartInfo.Arguments = startupInformation.Arguments;
                    if (!process.Start())
                    {
                        response.Results.Add(new ProcessStatus
                        {
                            Id = startupInformation.RequestId,
                            Status = "Failed to start"
                        });
                        continue;
                    }

                    process.PriorityClass =
                        Enum.TryParse(startupInformation.Priority, true, out ProcessPriorityClass res)
                            ? res
                            : ProcessPriorityClass.Normal;
                    if (startupInformation.Affinity != 0)
                    {
                        process.ProcessorAffinity = new IntPtr(startupInformation.Affinity);
                    }

                    response.Results.Add(new ProcessStatus {Id = startupInformation.RequestId, Status = "Ok"});
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                    response.Results.Add(new ProcessStatus {Id = startupInformation.RequestId, Status = e.Message});
                }
            }

            return Task.FromResult(response);
        }

        public override async Task Get(
            IAsyncStreamReader<RequestMgs> requestStream,
            IServerStreamWriter<ReplyMsg> responseStream,
            ServerCallContext context)
        {
            var httpContext = context.GetHttpContext();
            _logger.LogInformation($"Connection id: {httpContext.Connection.Id}");

            var readTask = Task.Run(async () =>
            {
                await foreach (var message in requestStream.ReadAllAsync())
                {
                    switch (message.Message)
                    {
                        case "Start":
                            _runnable = true;
                            _processesGetter = new Thread(() => ThreadStart(responseStream));
                            _processesGetter.Start();
                            break;
                        case "End":
                            _runnable = false;
                            if (_processesGetter is {IsAlive: true})
                            {
                                _processesGetter.Join();
                            }

                            break;
                        default:
                            _time = int.Parse(message.Message);
                            break;
                    }
                }
            });
            await readTask;
        }
    }
}