
namespace MicroRabbit.Transfer.Application.Interfaces
{
    using MicroRabbit.Transfer.Domain.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Account Service interface
    /// </summary>
    public interface ITransferService
    {
        /// <summary>
        /// Gets the accounts.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
