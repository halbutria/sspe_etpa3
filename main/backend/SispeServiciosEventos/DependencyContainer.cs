using Microsoft.Extensions.DependencyInjection;
using SispeServiciosEventos.Queue.v1;
using System.Diagnostics.CodeAnalysis;
using Xphera.Library.Common.Entities.Interfaces.Events;
using Xphera.Library.Common.QueueServices;
using Xphera.Library.Common.QueueServices.Model;

namespace SispeServiciosEventos
{
    /// <summary>
    ///   <see cref="DependencyContainer" />
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class DependencyContainer
    {
        /// <summary>
        /// Adds the event identity manager services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection AddXpSispeCiudadanoEventsServices(this IServiceCollection services,
            Action<QueueOptions> queueOptions)
        {
            services.AddScoped<IDomainEventHandler<SendQueueEvent>, SendQueueEventHandler>();
            services.AddAzureQueueServices(queueOptions);
            return services;
        }
    }
}
