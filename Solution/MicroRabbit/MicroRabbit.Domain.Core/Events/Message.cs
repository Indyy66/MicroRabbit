
namespace MicroRabbit.Domain.Core.Events
{
    using MediatR;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MediatR.IRequest{System.Boolean}" />
    public abstract class Message : IRequest<bool>
    {
        /// <summary>
        /// Gets or sets the type of the message.
        /// </summary>
        /// <value>
        /// The type of the message.
        /// </value>
        public string MessageType { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
