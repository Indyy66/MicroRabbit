
namespace MicroRabbit.Banking.Application.Interfaces
{
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
    }
}
