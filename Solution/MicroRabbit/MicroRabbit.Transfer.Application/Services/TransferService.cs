
namespace MicroRabbit.Transfer.Application.Services
{
    using MicroRabbit.Domain.Core.Bus;
    using MicroRabbit.Transfer.Application.Interfaces;
    using MicroRabbit.Transfer.Domain.Interfaces;
    using MicroRabbit.Transfer.Domain.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Transfer Logs Service class 
    /// </summary>
    /// <seealso cref="MicroRabbit.Banking.Application.Interfaces.IAccountService" />
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _repository;
        private readonly IEventBus _bus;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferService" /> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="bus">The bus.</param>
        public TransferService(ITransferRepository repository, IEventBus bus)
        {
            this._repository = repository;
            this._bus = bus;
        }


        /// <summary>
        /// Gets the Ttansfer logs.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _repository.GetTransferLogs();
        }
    }
}
