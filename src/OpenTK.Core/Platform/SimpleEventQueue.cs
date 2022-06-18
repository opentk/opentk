using System;
using System.Collections.Generic;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// A simple implementation of the event queue object.
    /// </summary>
    /// <typeparam name="TType">Enumeration of event types.</typeparam>
    /// <typeparam name="TArguments">Event type parameter.</typeparam>
    [Obsolete("Event Queue instances are no longer a part of the PAL API.")]
    public class SimpleEventQueue<TType, TArguments> : IEventQueue<TType, TArguments> where TType : Enum
    {
        private readonly Queue<Event> _events = new Queue<Event>();

        /// <summary>
        /// Add an event to the queue.
        /// </summary>
        /// <param name="sender">Object sending the event.</param>
        /// <param name="type">Event type being sent.</param>
        /// <param name="arguments">Arguments associated with the event.</param>
        public void Send(object sender, TType type, TArguments arguments)
        {
            _events.Enqueue(new Event(sender, type, arguments));
        }

        private readonly struct Event
        {
            public readonly object Sender;
            public readonly TType Type;
            public readonly TArguments Arguments;

            public Event(object sender, TType type, TArguments arguments)
            {
                Sender = sender;
                Type = type;
                Arguments = arguments;
            }
        }

        /// <inheritdoc />
        public event QueueEventHandler<TType, TArguments> EventRaised;

        /// <inheritdoc />
        public void ProcessEvents()
        {
            while (_events.TryDequeue(out Event sentEvent))
            {
                EventRaised?.Invoke(sentEvent.Sender, sentEvent.Type, sentEvent.Arguments);
            }
        }

        /// <inheritdoc />
        public void IgnoreEvents()
        {
            _events.Clear();
        }

        /// <inheritdoc />
        public void DefaultEventHandler(object sender, TType type, TArguments arguments)
        {
        }
    }
}
