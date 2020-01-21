
namespace MicroRabbit.Transfer.Data.Context
{
    using MicroRabbit.Transfer.Domain.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Transfer Database Context class
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class TransferDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankingDbContext" /> class.
        /// </summary>
        /// <param name="options">The options for this context.</param>
        public TransferDbContext(DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        /// Gets or sets the transfer logs.
        /// </summary>
        /// <value>
        /// The transfer logs.
        /// </value>
        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
