
namespace MicroRabbit.Transfer.Domain.Interfaces
{
    using MicroRabbit.Transfer.Domain.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Account interface module
    /// </summary>
    public interface ITransferRepository
    {
        /// <summary>
        /// Gets the accounts.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TransferLog> GetTransferLogs();

        /// <summary>
        /// Adds the specified transfer log.
        /// </summary>
        /// <param name="transferLog">The transfer log.</param>
        void Add(TransferLog transferLog);
    }
}
