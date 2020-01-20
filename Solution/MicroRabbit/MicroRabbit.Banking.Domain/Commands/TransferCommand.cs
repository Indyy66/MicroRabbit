
namespace MicroRabbit.Banking.Domain.Commands
{
    using MicroRabbit.Domain.Core.Commands;

    /// <summary>
    /// Abstract Transfer Command class
    /// </summary>
    /// <seealso cref="MicroRabbit.Domain.Core.Commands.Command" />
    public abstract class TransferCommand : Command
    {
        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        public int From { get; protected set; }

        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>
        /// To.
        /// </value>
        public int To { get; protected set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public decimal Amount { get; protected set; }

    }
}
