
namespace MicroRabbit.Infra.IoC
{
    using MicroRabbit.Domain.Core.Bus;
    using MicroRabbit.Infra.Bus;
    using Microsoft.Extensions.DependencyInjection;


    /// <summary>
    /// IoC Dependency injection management class
    /// </summary>
    public class DependencyContainer
    {
        /// <summary>
        /// Registers the services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
