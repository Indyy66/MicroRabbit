
namespace MicroRabbit.Transfer.Data.Repository
{
    using MicroRabbit.Transfer.Data.Context;
    using MicroRabbit.Transfer.Domain.Interfaces;
    using MicroRabbit.Transfer.Domain.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Transfer Logs Repository class
    /// </summary>
    /// <seealso cref="MicroRabbit.Banking.Domain.Interfaces.IAccountRepository" />
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRepository" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public TransferRepository(TransferDbContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Gets the transfer logs.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _context.TransferLogs;
        }
    }
}
