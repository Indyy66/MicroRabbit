
namespace MicroRabbit.Banking.Application.Services
{
    using System.Collections.Generic;
    using MicroRabbit.Banking.Application.Interfaces;
    using MicroRabbit.Banking.Domain.Interfaces;
    using MicroRabbit.Banking.Domain.Models;

    /// <summary>
    /// Account Service class 
    /// </summary>
    /// <seealso cref="MicroRabbit.Banking.Application.Interfaces.IAccountService" />
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountService" /> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public AccountService(IAccountRepository repository)
        {
            this._repository = repository;
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
    }
}
