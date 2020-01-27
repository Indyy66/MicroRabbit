
namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    using MicroRabbit.Domain.Core.Bus;
    using MicroRabbit.Transfer.Domain.Events;
    using MicroRabbit.Transfer.Domain.Interfaces;
    using MicroRabbit.Transfer.Domain.Models;
    using System.Threading.Tasks;

    /// <summary>
    /// Transfer Event Handler class
    /// </summary>
    /// <seealso cref="MicroRabbit.Domain.Core.Bus.IEventHandler{MicroRabbit.Transfer.Domain.Events.TransferCreatedEvent}" />
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferEventHandler"/> class.
        /// </summary>
        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        /// <summary>
        /// Handles the specified event.
        /// </summary>
        /// <param name="event">The event.</param>
        /// <returns></returns>
        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount
            });
            
            return Task.CompletedTask;
        }
    }
}
