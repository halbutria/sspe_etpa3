using Xphera.Library.Common.Entities.Interfaces.Events;
using Xphera.Library.Common.QueueServices.Interface;

namespace SispeServiciosEventos.Queue.v1
{
    internal class SendQueueEventHandler : IDomainEventHandler<SendQueueEvent>
    {
        /// <summary>
        /// The mail service
        /// </summary>
        readonly IAzureServiceBus AzureServiceBus;

        public SendQueueEventHandler(IAzureServiceBus azureServiceBus)
        {
            AzureServiceBus = azureServiceBus;
        }


        /// <summary>
        /// Handles the specified event type instance.
        /// </summary>
        /// <param name="eventTypeInstance">The event type instance.</param>
        /// <returns></returns>
        public async ValueTask Handle(SendQueueEvent eventTypeInstance)
        {
            await AzureServiceBus.SendMessageAsync(eventTypeInstance);
        }
    }
}
