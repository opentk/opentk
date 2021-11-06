using System;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// An event handler delegate for event queues.
    /// </summary>
    /// <typeparam name="TType">Type which enumerates types of events which may be sent.</typeparam>
    /// <typeparam name="TArguments">Type for event arguments.</typeparam>
    /// <param name="sender">The object sending the event.</param>
    /// <param name="type">The type of event sent.</param>
    /// <param name="arguments">Arguments associated with event.</param>
    public delegate void QueueEventHandler<TType, TArguments>(object sender, TType type, TArguments arguments) where TType : Enum;

    /// <summary>
    /// An empty enum for use with <see cref="QueueEventHandler{TType,TArguments}"/> and <see cref="IEventQueue{Ttype,TArguments}"/>.
    /// </summary>
    public enum NullEnum
    {
    }

    /// <summary>
    /// An interface for native event queues.
    /// </summary>
    /// <typeparam name="TType">Enumeration of possible event types.</typeparam>
    /// <typeparam name="TArguments">The event argument type, conventionally inherits <see cref="EventArgs"/>.</typeparam>
    public interface IEventQueue<TType, TArguments> where TType : Enum
    {
        /// <summary>
        /// Event raised when there is a event raised in the queue.
        /// </summary>
        event QueueEventHandler<TType, TArguments> EventRaised;

        /// <summary>
        /// Process the events in the queue, invoking <see cref="EventRaised"/>.
        /// </summary>
        void ProcessEvents();

        /// <summary>
        /// Ignore events in the queue.
        /// </summary>
        void IgnoreEvents();

        /// <summary>
        /// A default event handler, which may be empty.
        /// </summary>
        /// <param name="sender">Object sending event.</param>
        /// <param name="type">Type of event being sent.</param>
        /// <param name="arguments">Arguments associated with event.</param>
        void DefaultEventHandler(object sender, TType type, TArguments arguments);
    }
}
