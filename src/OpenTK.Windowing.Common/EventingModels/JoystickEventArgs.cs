//
// JoystickEventArgs.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Windowing.Common;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for the <see cref="IWindowEvents.JoystickConnected"/> event.
    /// </summary>
    public class JoystickEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JoystickEventArgs"/> class.
        /// </summary>
        public JoystickEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoystickEventArgs"/> class.
        /// </summary>
        /// <param name="joystickId">The Id of the joystick which triggered this event.</param>
        /// <param name="isConnected">
        /// A value indicating whether the joystick which triggered this event was connected.
        /// </param>
        public JoystickEventArgs(int joystickId, bool isConnected)
        {
            JoystickId = joystickId;
            IsConnected = isConnected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoystickEventArgs"/> class.
        /// </summary>
        /// <param name="other">The <see cref="JoystickEventArgs" /> instance to clone.</param>
        public JoystickEventArgs(JoystickEventArgs other)
        {
            JoystickId = other.JoystickId;
            IsConnected = other.IsConnected;
        }

        /// <summary>
        /// Gets the Id of the joystick which triggered this event.
        /// </summary>
        public int JoystickId { get; }

        /// <summary>
        /// Gets a value indicating whether the joystick which triggered this event was connected.
        /// </summary>
        public bool IsConnected { get; }
    }
}
