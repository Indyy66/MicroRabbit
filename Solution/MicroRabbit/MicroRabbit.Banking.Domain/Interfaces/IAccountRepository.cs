
namespace MicroRabbit.Banking.Domain.Interfaces
{
    using MicroRabbit.Banking.Domain.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Account interface module
    /// </summary>
    public interface IAccountRepository
    {
        /// <summary>
        /// Gets the accounts.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Account> GetAccounts();
    }
}
