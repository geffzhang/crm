using System.Threading.Tasks;
using CRM.Shared.EventBus;
using CRM.IntegrationEvents;

namespace CRM.Communication.IntegrationHandlers
{
    public class ContactCreatedEventHandler : IIntegrationEventHandler<ContactCreatedEvent>
    {
        public async Task Handle(ContactCreatedEvent @event)
        {
            await Task.Delay(10);
            await Task.FromResult(0);
        }
    }
}
