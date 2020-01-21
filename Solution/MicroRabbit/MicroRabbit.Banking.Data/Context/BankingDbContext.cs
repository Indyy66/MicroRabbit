
namespace MicroRabbit.Banking.Data.Context
{
    using MicroRabbit.Banking.Domain.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Banking Database Context class
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class BankingDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankingDbContext"/> class.
        /// </summary>
        /// <param name="options">The options for this context.</param>
        public BankingDbContext(DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        /// Gets or sets the accounts.
        /// </summary>
        /// <value>
        /// The accounts.
        /// </value>
        public DbSet<Account> Accounts { get; set; }
    }
}
