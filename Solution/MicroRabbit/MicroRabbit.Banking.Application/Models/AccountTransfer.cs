
namespace MicroRabbit.Banking.Application.Models
{
    /// <summary>
    /// Account Transfer service Dto class
    /// </summary>
    public class AccountTransfer
    {
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
        /// Gets or sets the transfer amount.
        /// </summary>
        /// <value>
        /// The transfer amount.
        /// </value>
        public decimal TransferAmount { get; set; }
    }
}
