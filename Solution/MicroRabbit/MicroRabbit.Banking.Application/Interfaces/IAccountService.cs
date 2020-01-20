
namespace MicroRabbit.Banking.Application.Interfaces
{
    using MicroRabbit.Banking.Application.Models;
    using MicroRabbit.Banking.Domain.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Account Service interface
    /// </summary>
    public interface IAccountService
    {
        /// <summary>
        /// Gets the accounts.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Account> GetAccounts();

        /// <summary>
        /// Transfers the specified account transfer.
        /// </summary>
        /// <param name="accountTransfer">The account transfer.</param>
        void Transfer(AccountTransfer accountTransfer);
    }
}
