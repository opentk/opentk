//
// IWindowEvent.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.ComponentModel;
using OpenToolkit.Windowing.Common;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the interface for a GameWindow.
    /// </summary>
    public interface IWindowEvents
    {
        /// <summary>
        /// Occurs whenever the window is moved.
        /// </summary>
        event Action<WindowPositionEventArgs> Move;

        /// <summary>
        /// Occurs whenever the window is resized.
        /// </summary>
        event Action<ResizeEventArgs> Resize;

        /// <summary>
        /// Occurs whenever the window is refreshed.
        /// </summary>
        event Action Refresh;

        /// <summary>
        /// Occurs when the window is about to close.
        /// </summary>
        event Action<CancelEventArgs> Closing;

        /// <summary>
        /// Occurs after the window has closed.
        /// </summary>
        event Action Closed;

        /// <summary>
        /// Occurs when the window is minimized.
        /// </summary>
        event Action<MinimizedEventArgs> Minimized;

        /// <summary>
        /// Occurs when a joystick is connected or disconnected.
        /// </summary>
        event Action<JoystickEventArgs> JoystickConnected;

        /// <summary>
        /// Occurs when the <see cref="INativeWindowProperties.IsFocused" /> property of the window changes.
        /// </summary>
        event Action<FocusedChangedEventArgs> FocusedChanged;

        /// <summary>
        /// Occurs whenever a keyboard key is pressed.
        /// </summary>
        event Action<KeyboardKeyEventArgs> KeyDown;

        /// <summary>
        /// Occurs whenever a Unicode code point is typed.
        /// </summary>
        event Action<TextInputEventArgs> TextInput;

        /// <summary>
        /// Occurs whenever a keyboard key is released.
        /// </summary>
        event Action<KeyboardKeyEventArgs> KeyUp;

        /// <summary>
        /// Occurs when a <see cref="Monitor"/> is connected or disconnected.
        /// </summary>
        event Action<MonitorEventArgs> MonitorConnected;

        /// <summary>
        /// Occurs whenever the mouse cursor leaves the window <see cref="INativeWindowProperties.Bounds" />.
        /// </summary>
        event Action MouseLeave;

        /// <summary>
        /// Occurs whenever the mouse cursor enters the window <see cref="INativeWindowProperties.Bounds" />.
        /// </summary>
        event Action MouseEnter;

        /// <summary>
        /// Occurs whenever a <see cref="Input.MouseButton" /> is clicked.
        /// </summary>
        event Action<MouseButtonEventArgs> MouseDown;

        /// <summary>
        /// Occurs whenever a <see cref="Input.MouseButton" /> is released.
        /// </summary>
        event Action<MouseButtonEventArgs> MouseUp;

        /// <summary>
        /// Occurs whenever the mouse cursor is moved;
        /// </summary>
        event Action<MouseMoveEventArgs> MouseMove;

        /// <summary>
        /// Occurs whenever a mouse wheel is moved;
        /// </summary>
        event Action<MouseWheelEventArgs> MouseWheel;

        /// <summary>
        /// Occurs whenever file dropped on window.
        /// </summary>
        event Action<FileDropEventArgs> FileDrop;
    }
}
