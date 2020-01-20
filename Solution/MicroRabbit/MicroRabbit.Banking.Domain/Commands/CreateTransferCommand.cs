
namespace MicroRabbit.Banking.Domain.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Derived Create Transfer Command class
    /// </summary>
    /// <seealso cref="MicroRabbit.Banking.Domain.Commands.TransferCommand" />
    public class CreateTransferCommand : TransferCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransferCommand"/> class.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <param name="amount">The amount.</param>
        public CreateTransferCommand(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
