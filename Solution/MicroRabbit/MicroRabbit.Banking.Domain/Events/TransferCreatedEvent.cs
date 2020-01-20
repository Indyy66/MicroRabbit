
namespace MicroRabbit.Banking.Domain.Events
{
    using MicroRabbit.Domain.Core.Events;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class TransferCreatedEvent : Event
    {
        /// <summary>
        /// Gets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        public int From { get; private set; }

        /// <summary>
        /// Gets to.
        /// </summary>
        /// <value>
        /// To.
        /// </value>
        public int To { get; private set; }

        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public decimal Amount { get; private set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCreatedEvent"/> class.
        /// </summary>
        public TransferCreatedEvent(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }

}
