using System.Threading;
using System.Threading.Tasks;
using CRM.Protobuf.Contacts.V1;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CRM.Contact.Queries.Handlers
{
    public class PingHandler : IRequestHandler<PingQuery, PongReply>
    {
        private readonly ILogger<PingHandler> _logger;

        public PingHandler(ILogger<PingHandler> logger)
        {
            _logger = logger;
        }

        public Task<PongReply> Handle(PingQuery request, CancellationToken cancellationToken)
        {

            _logger.LogInformation("Ping handler happens ...");
            return Task.FromResult(new PongReply
            {
                Message = "Pong"
            });
        }
    }
}
