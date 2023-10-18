using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using OpenTK.Core.Platform.Enums;
using OpenTK.Core.Platform.Handles;

#nullable  enable

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// An event handler delegate for platform events.
    /// </summary>
    /// <param name="handle">Handle creating the event, if available.</param>
    /// <param name="type">Event type.</param>
    /// <param name="args">Information associated with the event, if any.</param>
    public delegate void PlatformEventHandler(PalHandle? handle, PlatformEventType type, EventArgs args);

    /// <summary>
    /// Event queue for interacting with platform events.
    /// </summary>
    public class EventQueue : IDisposable
    {
        /// <summary>
        /// Contains the events captured for this queue instance.
        /// </summary>
        private readonly ConcurrentQueue<EventInstance> _events = new ConcurrentQueue<EventInstance>();

        /// <summary>
        /// Indicates which handle the queue is filtered for.
        /// </summary>
        public PalHandle? FilteredHandle { get; }

        /// <summary>
        /// The number of events currently in queue.
        /// </summary>
        public int InQueue => _events.Count;

        private EventQueue(PalHandle? handle)
        {
            FilteredHandle = handle;
        }

        /// <summary>
        /// Invoked when a queued event is dispatched.
        /// </summary>
        public event PlatformEventHandler? EventDispatched;

        private void OnEventDispatched(in EventInstance instance)
        {
            EventDispatched?.Invoke(instance.Handle, instance.Type, instance.Args);
        }

        /// <summary>
        /// Dispatch one event from the queue, if available.
        /// </summary>
        public void DispatchOne()
        {
            if (_events.TryDequeue(out EventInstance instance))
            {
                OnEventDispatched(instance);
            }
        }

        /// <summary>
        /// Dispatch all the events from the queue.
        /// </summary>
        public void DispatchEvents()
        {
            while (_events.TryDequeue(out EventInstance instance))
            {
                OnEventDispatched(instance);
            }
        }

        private bool _isDisposed;

        private void Dispose(bool isDisposing)
        {
            if (_isDisposed)
            {
                return;
            }

            _isDisposed = true;

            if (isDisposing)
            {
                // FIXME: Potential deadlock ahead???
                lock (_queueLockObj)
                {
                    _queues.Remove(this);
                }

                GC.SuppressFinalize(this);
            }
        }

        /// <inheritdoc />
        public void Dispose() => Dispose(true);

        // FIXME: ugly mutex, couldn't find a concurrent queue that fit my needs.
        private static object _queueLockObj = new object();
        private static List<EventQueue> _queues = new List<EventQueue>();

        /// <summary>
        /// Invoke when an event is raised.
        /// </summary>
        /// <remarks>
        /// This event handler is potentially called across threads. If thread safety is required,
        /// or you would like to control when events are dispatched, use <see cref="Subscribe(PalHandle)"/> instead.
        /// </remarks>
        public static event PlatformEventHandler? EventRaised;

        private static void OnEventRaised(in EventInstance instance)
        {
            EventRaised?.Invoke(instance.Handle, instance.Type, instance.Args);
        }

        /// <summary>
        /// Subscribe to an instance of the event queue.
        /// </summary>
        /// <param name="handle">Filter received events to the given handle.</param>
        /// <returns>The queue instance.</returns>
        public static EventQueue Subscribe(PalHandle? handle = null)
        {
            EventQueue queue = new EventQueue(handle);

            lock (_queueLockObj)
            {
                _queues.Add(queue);
            }

            return queue;
        }

        /// <summary>
        /// Raise an event.
        /// </summary>
        /// <param name="handle">Handle generating the event.</param>
        /// <param name="type">Type of the event.</param>
        /// <param name="args">Arguments associated with the event.</param>
        public static void Raise(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            EventInstance instance = new EventInstance(handle, type, args);

            lock (_queueLockObj)
            {
                foreach (EventQueue queue in _queues)
                {
                    if (queue.FilteredHandle == handle || queue.FilteredHandle is null)
                    {
                        queue._events.Enqueue(instance);
                    }
                }
            }

            OnEventRaised(instance);
        }

        private struct EventInstance
        {
            public PalHandle? Handle { get; }

            public PlatformEventType Type { get; }

            public EventArgs Args { get; }

            public EventInstance(PalHandle? handle, PlatformEventType type, EventArgs args)
            {
                Handle = handle;
                Type = type;
                Args = args;
            }
        }
    }
}
