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
        event EventHandler<WindowPositionEventArgs> Move;

        /// <summary>
        /// Occurs whenever the window is resized.
        /// </summary>
        event EventHandler<ResizeEventArgs> Resize;

        /// <summary>
        /// Occurs whenever the window is refreshed.
        /// </summary>
        event EventHandler<EventArgs> Refresh;

        /// <summary>
        /// Occurs when the window is about to close.
        /// </summary>
        event EventHandler<CancelEventArgs> Closing;

        /// <summary>
        /// Occurs after the window has closed.
        /// </summary>
        event EventHandler<EventArgs> Closed;

        /// <summary>
        /// Occurs when the window is disposed.
        /// </summary>
        event EventHandler<EventArgs> Disposed;

        /// <summary>
        /// Occurs when the window is minimized.
        /// </summary>
        event EventHandler<MinimizedEventArgs> Minimized;

        /// <summary>
        /// Occurs when the icon of the window changes.
        /// </summary>
        event EventHandler<EventArgs> IconChanged;

        /// <summary>
        /// Occurs when a joystick is connected or disconnected.
        /// </summary>
        event EventHandler<JoystickEventArgs> JoystickConnected;

        /// <summary>
        /// Occurs when the <see cref="INativeWindowProperties.Title" /> property of the window changes.
        /// </summary>
        event EventHandler<TitleChangedEventArgs> TitleChanged;

        /// <summary>
        /// Occurs when the <see cref="INativeWindowProperties.IsVisible" /> property of the window changes.
        /// </summary>
        event EventHandler<VisibilityChangedEventArgs> VisibleChanged;

        /// <summary>
        /// Occurs when the <see cref="INativeWindowProperties.IsFocused" /> property of the window changes.
        /// </summary>
        event EventHandler<FocusedChangedEventArgs> FocusedChanged;

        /// <summary>
        /// Occurs when the <see cref="WindowBorder" /> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> WindowBorderChanged;

        /// <summary>
        /// Occurs when the <see cref="WindowState" /> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> WindowStateChanged;

        /// <summary>
        /// Occurs whenever a keyboard key is pressed.
        /// </summary>
        event EventHandler<KeyboardKeyEventArgs> KeyDown;

        /// <summary>
        /// Occurs whenever a Unicode code point is typed.
        /// </summary>
        event EventHandler<TextInputEventArgs> TextInput;

        /// <summary>
        /// Occurs whenever a keyboard key is released.
        /// </summary>
        event EventHandler<KeyboardKeyEventArgs> KeyUp;

        /// <summary>
        /// Occurs when a <see cref="Monitor"/> is connected or disconnected.
        /// </summary>
        event EventHandler<MonitorEventArgs> MonitorConnected;

        /// <summary>
        /// Occurs whenever the mouse cursor leaves the window <see cref="INativeWindowProperties.Bounds" />.
        /// </summary>
        event EventHandler<EventArgs> MouseLeave;

        /// <summary>
        /// Occurs whenever the mouse cursor enters the window <see cref="INativeWindowProperties.Bounds" />.
        /// </summary>
        event EventHandler<EventArgs> MouseEnter;

        /// <summary>
        /// Occurs whenever a <see cref="Input.MouseButton" /> is clicked.
        /// </summary>
        event EventHandler<MouseButtonEventArgs> MouseDown;

        /// <summary>
        /// Occurs whenever a <see cref="Input.MouseButton" /> is released.
        /// </summary>
        event EventHandler<MouseButtonEventArgs> MouseUp;

        /// <summary>
        /// Occurs whenever the mouse cursor is moved;
        /// </summary>
        event EventHandler<MouseMoveEventArgs> MouseMove;

        /// <summary>
        /// Occurs whenever a mouse wheel is moved;
        /// </summary>
        event EventHandler<MouseWheelEventArgs> MouseWheel;

        // event EventHandler<MouseEventArgs> MouseClick;
        // event EventHandler<MouseEventArgs> MouseDoubleClick;

        /// <summary>
        /// Occurs whenever file dropped on window.
        /// </summary>
        event EventHandler<FileDropEventArgs> FileDrop;
    }
}
