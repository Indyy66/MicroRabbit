
namespace MicroRabbit.Domain.Core.Commands
{
    using MicroRabbit.Domain.Core.Events;
    using System;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Message" />
    public abstract class Command : Message
    {
        /// <summary>
        /// Gets or sets the time stamp.
        /// </summary>
        /// <value>
        /// The time stamp.
        /// </value>
        public DateTime TimeStamp { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Command"/> class.
        /// </summary>
        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
