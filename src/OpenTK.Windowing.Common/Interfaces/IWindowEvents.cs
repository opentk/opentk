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
using OpenToolkit.Windowing.EventingModels;

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
        event EventHandler<EventArgs> Move;
        void OnMove(object sender, EventArgs e);

        /// <summary>
        /// Occurs whenever the window is resized.
        /// </summary>
        event EventHandler<EventArgs> Resize;
        void OnResize(object sender, EventArgs e);

        /// <summary>
        /// Occurs when the window is about to close.
        /// </summary>
        event EventHandler<CancelEventArgs> Closing;
        void OnClosing(object sender, EventArgs e);

        /// <summary>
        /// Occurs after the window has closed.
        /// </summary>
        event EventHandler<EventArgs> Closed;
        void OnClosed(object sender, EventArgs e);

        /// <summary>
        /// Occurs when the window is disposed.
        /// </summary>
        event EventHandler<EventArgs> Disposed;
        void OnDisposed(object sender, EventArgs e);

        /// <summary>
        /// Occurs when the <see cref="Icon" /> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> IconChanged;
        void OnIconChanged(object sender, EventArgs e);

        /// <summary>
        /// Occurs when the <see cref="INativeWindow.Title" /> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> TitleChanged;
        void OnTitleChanged(object sender, EventArgs e);

        /// <summary>
        /// Occurs when the <see cref="INativeWindow.Visible" /> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> VisibleChanged;
        void OnVisibleChanged(object sender, EventArgs e);

        /// <summary>
        /// Occurs when the <see cref="INativeWindow.Focused" /> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> FocusedChanged;
        void OnFocusChanged(object sender, EventArgs e);

        /// <summary>
        /// Occurs when the <see cref="WindowBorder" /> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> WindowBorderChanged;
        void OnWindowBorderChanged(object sender, EventArgs e);

        /// <summary>
        /// Occurs when the <see cref="WindowState" /> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> WindowStateChanged;
        void OnWindowStateChanged(object sender, EventArgs e);

        /// <summary>
        /// Occurs whenever a keyboard key is pressed.
        /// </summary>
        event EventHandler<KeyboardKeyEventArgs> KeyDown;
        void OnKeyDown(object sender, EventArgs e);

        /// <summary>
        /// Occurs whenever a character is typed.
        /// </summary>
        event EventHandler<KeyPressEventArgs> KeyPress;
        void OnKeyPress(object sender, EventArgs e);

        /// <summary>
        /// Occurs whenever a keyboard key is released.
        /// </summary>
        event EventHandler<KeyboardKeyEventArgs> KeyUp;
        void OnKeyUp(object sender, EventArgs e);

        /// <summary>
        /// Occurs whenever the mouse cursor leaves the window <see cref="Bounds" />.
        /// </summary>
        event EventHandler<EventArgs> MouseLeave;
        void OnMouseLeave(object sender, EventArgs e);

        /// <summary>
        /// Occurs whenever the mouse cursor enters the window <see cref="Bounds" />.
        /// </summary>
        event EventHandler<EventArgs> MouseEnter;
        void OnMouseEnter(object sender, EventArgs e);

        /// <summary>
        /// Occurs whenever a <see cref="Input.MouseButton" /> is clicked.
        /// </summary>
        event EventHandler<MouseButtonEventArgs> MouseDown;
        void OnMouseDown(object sender, EventArgs e);

        /// <summary>
        /// Occurs whenever a <see cref="Input.MouseButton" /> is released.
        /// </summary>
        event EventHandler<MouseButtonEventArgs> MouseUp;
        void OnMouseUp(object sender, EventArgs e);

        /// <summary>
        /// Occurs whenever the mouse cursor is moved;
        /// </summary>
        event EventHandler<MouseMoveEventArgs> MouseMove;
        void OnMouseMove(object sender, EventArgs e);

        /// <summary>
        /// Occurs whenever a mouse wheel is moved;
        /// </summary>
        event EventHandler<MouseWheelEventArgs> MouseWheel;
        void OnMouseWheel(object sender, EventArgs e);

        //event EventHandler<MouseEventArgs> MouseClick;
        //event EventHandler<MouseEventArgs> MouseDoubleClick;

        /// <summary>
        /// Occurs whenever file dropped on window.
        /// </summary>
        event EventHandler<FileDropEventArgs> FileDrop;
        void OnFileDrop(object sender, EventArgs e);
    }
}
