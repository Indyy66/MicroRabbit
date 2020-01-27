
namespace MicroRabbit.Transfer.Domain.Models
{
    /// <summary>
    /// Account model class
    /// </summary>
    public class TransferLog
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }


        /// <summary>
        /// Gets or sets from account.
        /// </summary>
        /// <value>
        /// From account.
        /// </value>
        public int FromAccount { get; set; }

        /// <summary>
        /// Converts to account.
        /// </summary>
        /// <value>
        /// To account.
        /// </value>
        public int ToAccount { get; set; }

        /// <summary>
        /// Gets or sets the transfer account.
        /// </summary>
        /// <value>
        /// The transfer account.
        /// </value>
        public decimal TransferAmount { get; set; }

    }
}
