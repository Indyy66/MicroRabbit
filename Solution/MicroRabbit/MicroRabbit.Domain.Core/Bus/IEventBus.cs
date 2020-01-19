
namespace MicroRabbit.Domain.Core.Bus
{
    using MicroRabbit.Domain.Core.Commands;
    using MicroRabbit.Domain.Core.Events;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public interface IEventBus
    {
        /// <summary>
        /// Sends the command.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Command">The command.</param>
        /// <returns></returns>
        Task SendCommand<T>(T Command) where T : Command;

        /// <summary>
        /// Publishes the specified event.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="event">The event.</param>
        void Publish<T>(T @event) where T : Event;

        /// <summary>
        /// Subsscribes this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TH">The type of the h.</typeparam>
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
