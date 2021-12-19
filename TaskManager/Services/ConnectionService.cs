using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using TaskManager.Core;

namespace TaskManager.Services
{
    public class ConnectionService : ConnectionManager.ConnectionManagerBase
    {
        private readonly ILogger<ConnectionService> _logger;

        public ConnectionService(ILogger<ConnectionService> logger)
        {
            _logger = logger;
        }

        public override async Task Run(
            IAsyncStreamReader<RequestMgs> requestStream,
            IServerStreamWriter<ReplyMsg> responseStream,
            ServerCallContext context)
        {
            var httpContext = context.GetHttpContext();
            _logger.LogInformation($"Connection id: {httpContext.Connection.Id}");

            while (await requestStream.MoveNext())
            {
                switch (requestStream.Current.Action)
                {
                    case Action.Get:
                    {
                        await responseStream.WriteAsync(new ReplyMsg
                        {
                            Message = JsonConvert.SerializeObject(Process.GetProcesses()
                                .Select(process => (ProcessInfoBase) new ProcessInfo(process)).ToList()),
                            ReplayType = ReplayType.Data
                        });
                        break;
                    }
                    case Action.Kill:
                        break;
                    case Action.Modify:
                        break;
                    case Action.Start:
                        break;
                }
            }
        }
    }
}