using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace TaskManager.Services
{
    public class ConnectionService : ConnectionManager.ConnectionManagerBase
    {
        private readonly ILogger<ConnectionService> _logger;

        public ConnectionService(ILogger<ConnectionService> logger)
        {
            _logger = logger;
        }

        public List<string> Connections { get; }

        public override async Task Run(
            IAsyncStreamReader<RequestMgs> requestStream,
            IServerStreamWriter<ReplyMsg> responseStream,
            ServerCallContext context)
        {
            var httpContext = context.GetHttpContext();
            Connections.Add(httpContext.Connection.Id);

            _logger.LogInformation($"Connection id: {httpContext.Connection.Id}");

            var prevNotes = new List<RequestMgs>();
            while (await requestStream.MoveNext())
            {
                var note = requestStream.Current;
                prevNotes.Add(note);
                foreach (var prevNote in prevNotes)
                {
                    await responseStream.WriteAsync(new ReplyMsg {Message = prevNote.Message});
                }
            }
        }
    }
}