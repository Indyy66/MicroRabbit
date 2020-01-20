﻿
namespace MicroRabbit.Infra.IoC
{
    using MediatR;
    using MicroRabbit.Banking.Application.Interfaces;
    using MicroRabbit.Banking.Application.Services;
    using MicroRabbit.Banking.Data.Context;
    using MicroRabbit.Banking.Data.Repository;
    using MicroRabbit.Banking.Domain.CommandHandlers;
    using MicroRabbit.Banking.Domain.Commands;
    using MicroRabbit.Banking.Domain.Interfaces;
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


            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Application Services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
