
namespace MicroRabbit.Domain.Core.Bus
{
    using MicroRabbit.Domain.Core.Events;
    using System.Threading.Tasks;


    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEvent">The type of the event.</typeparam>
    /// <seealso cref="MicroRabbit.Domain.Core.Bus.IEventHandler" />
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event
    {
        /// <summary>
        /// Handles the specified event.
        /// </summary>
        /// <param name="event">The event.</param>
        /// <returns></returns>
        Task Handle(TEvent @event);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MicroRabbit.Domain.Core.Bus.IEventHandler" />
    public interface IEventHandler
    {

    }
}
