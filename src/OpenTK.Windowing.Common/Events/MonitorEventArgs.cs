//
// MonitorEventArgs.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.Common
{
    /// <summary>
    ///     Defines the event data for the <see cref="INativeWindow.MonitorConnected" /> event.
    /// </summary>
    public readonly struct MonitorEventArgs // TODO: merge with JoystickEventArgs?
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MonitorEventArgs" /> struct.
        /// </summary>
        /// <param name="monitor">The <see cref="Monitor" /> which triggered the event.</param>
        /// <param name="isConnected">Whether the <see cref="Monitor" /> is connected.</param>
        public MonitorEventArgs(Monitor monitor, bool isConnected)
        {
            Monitor = monitor;
            IsConnected = isConnected;
        }

        /// <summary>
        ///     Gets the <see cref="Monitor" /> which triggered the event.
        /// </summary>
        public Monitor Monitor { get; }

        /// <summary>
        ///     Gets a value indicating whether the <see cref="Monitor" /> that triggered this event is connected or not.
        /// </summary>
        public bool IsConnected { get; }
    }
}
