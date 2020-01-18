
namespace MicroRabbit.Domain.Core.Events
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Event abstract class
    /// </summary>
    public abstract class Event
    {
        /// <summary>
        /// Gets or sets the time stamp.
        /// </summary>
        /// <value>
        /// The time stamp.
        /// </value>
        public DateTime TimeStamp { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        public Event()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
