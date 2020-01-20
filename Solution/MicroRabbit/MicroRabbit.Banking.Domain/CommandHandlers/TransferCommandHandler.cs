
namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    using MediatR;
    using MicroRabbit.Banking.Domain.Commands;
    using MicroRabbit.Banking.Domain.Events;
    using MicroRabbit.Domain.Core.Bus;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Transfer Command Handler class
    /// </summary>
    /// <seealso cref="MediatR.IRequestHandler{MicroRabbit.Banking.Domain.Commands.CreateTransferCommand, System.Boolean}" />
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCommandHandler"/> class.
        /// </summary>
        /// <param name="bus">The bus.</param>
        public TransferCommandHandler(IEventBus bus)
        {
            this._bus = bus;
        }

        /// <summary>
        /// Handles the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
            return Task.FromResult(true);
        }
    }
}
