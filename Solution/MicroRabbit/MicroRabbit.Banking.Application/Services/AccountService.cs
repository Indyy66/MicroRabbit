
namespace MicroRabbit.Banking.Application.Services
{
    using System.Collections.Generic;
    using MicroRabbit.Banking.Application.Interfaces;
    using MicroRabbit.Banking.Application.Models;
    using MicroRabbit.Banking.Domain.Commands;
    using MicroRabbit.Banking.Domain.Interfaces;
    using MicroRabbit.Banking.Domain.Models;
    using MicroRabbit.Domain.Core.Bus;

    /// <summary>
    /// Account Service class 
    /// </summary>
    /// <seealso cref="MicroRabbit.Banking.Application.Interfaces.IAccountService" />
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;
        private readonly IEventBus _bus;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountService" /> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public AccountService(IAccountRepository repository, IEventBus bus)
        {
            this._repository = repository;
            this._bus = bus;
        }

        /// <summary>
        /// Gets the accounts.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<Account> GetAccounts()
        {
            return _repository.GetAccounts();
        }

        /// <summary>
        /// Transfers the specified account transfer.
        /// </summary>
        /// <param name="accountTransfer">The account transfer.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                    accountTransfer.FromAccount,
                    accountTransfer.ToAccount,
                    accountTransfer.TransferAmount
                );
            _bus.SendCommand(createTransferCommand);
        }
    }
}
