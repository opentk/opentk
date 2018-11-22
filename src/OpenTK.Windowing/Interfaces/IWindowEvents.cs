//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using OpenToolkit.Windowing.EventingModels;
using System;
using System.ComponentModel;

namespace OpenToolkit.Windowing.Interfaces
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

        /// <summary>
        /// Occurs whenever the window is resized.
        /// </summary>
        event EventHandler<EventArgs> Resize;

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
        /// Occurs when the <see cref="Icon" /> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> IconChanged;

        /// <summary>
        /// Occurs when the <see cref="Title" /> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> TitleChanged;

        /// <summary>
        /// Occurs when the <see cref="Visible" /> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> VisibleChanged;

        /// <summary>
        /// Occurs when the <see cref="Focused" /> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> FocusedChanged;

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
        /// Occurs whenever a character is typed.
        /// </summary>
        event EventHandler<KeyPressEventArgs> KeyPress;

        /// <summary>
        /// Occurs whenever a keyboard key is released.
        /// </summary>
        event EventHandler<KeyboardKeyEventArgs> KeyUp;

        /// <summary>
        /// Occurs whenever the mouse cursor leaves the window <see cref="Bounds" />.
        /// </summary>
        event EventHandler<EventArgs> MouseLeave;

        /// <summary>
        /// Occurs whenever the mouse cursor enters the window <see cref="Bounds" />.
        /// </summary>
        event EventHandler<EventArgs> MouseEnter;

        /// <summary>
        /// Occurs whenever a <see cref="OpenTK.Input.MouseButton" /> is clicked.
        /// </summary>
        event EventHandler<MouseButtonEventArgs> MouseDown;

        /// <summary>
        /// Occurs whenever a <see cref="OpenTK.Input.MouseButton" /> is released.
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

        //event EventHandler<MouseEventArgs> MouseClick;
        //event EventHandler<MouseEventArgs> MouseDoubleClick;

        /// <summary>
        /// Occurs whenever file dropped on window.
        /// </summary>
        event EventHandler<FileDropEventArgs> FileDrop;

        /// <summary>
        /// Occurs before the window is displayed for the first time.
        /// </summary>
        event EventHandler<EventArgs> Load;

        /// <summary>
        /// Occurs before the window is destroyed.
        /// </summary>
        event EventHandler<EventArgs> Unload;

        /// <summary>
        /// Occurs when it is time to update a frame.
        /// </summary>
        event EventHandler<FrameEventArgs> UpdateFrame;

        /// <summary>
        /// Occurs when it is time to render a frame.
        /// </summary>
        event EventHandler<FrameEventArgs> RenderFrame;
    }
}
