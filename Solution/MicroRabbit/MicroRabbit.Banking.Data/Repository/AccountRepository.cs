
namespace MicroRabbit.Banking.Data.Repository
{
    using MicroRabbit.Banking.Data.Context;
    using MicroRabbit.Banking.Domain.Interfaces;
    using MicroRabbit.Banking.Domain.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Accounts Repository class
    /// </summary>
    /// <seealso cref="MicroRabbit.Banking.Domain.Interfaces.IAccountRepository" />
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AccountRepository(BankingDbContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Gets the accounts.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}
