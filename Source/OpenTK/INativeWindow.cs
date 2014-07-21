#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using OpenTK.Platform;

namespace OpenTK
{
    /// <summary>
    /// Defines the interface for a native window. 
    /// </summary>
    public interface INativeWindow : IDisposable
    {
        /// <summary>
        /// Gets or sets the <see cref="System.Drawing.Icon"/> of the window.
        /// </summary>
        Icon Icon { get; set; }

        /// <summary>
        /// Gets or sets the title of the window.
        /// </summary>
        string Title { get; set; }
        
        /// <summary>
        /// Gets a System.Boolean that indicates whether this window has input focus.
        /// </summary>
        bool Focused { get; }
        
        /// <summary>
        /// Gets or sets a System.Boolean that indicates whether the window is visible.
        /// </summary>
        bool Visible { get; set; }
        
        /// <summary>
        /// Gets a System.Boolean that indicates whether the window has been created and has not been destroyed.
        /// </summary>
        bool Exists { get; }
        
        /// <summary>
        /// Gets the <see cref="OpenTK.Platform.IWindowInfo"/> for this window.
        /// </summary>
        IWindowInfo WindowInfo { get; }
        
        /// <summary>
        /// Gets or sets the <see cref="OpenTK.WindowState"/> for this window.
        /// </summary>
        WindowState WindowState { get; set; }
        
        /// <summary>
        /// Gets or sets the <see cref="OpenTK.WindowBorder"/> for this window.
        /// </summary>
        WindowBorder WindowBorder { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Rectangle"/> structure the contains the external bounds of this window, in screen coordinates.
        /// External bounds include the title bar, borders and drawing area of the window.
        /// </summary>
        Rectangle Bounds { get; set; }
        
        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Point"/> structure that contains the location of this window on the desktop.
        /// </summary>
        Point Location { get; set; }
        
        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Size"/> structure that contains the external size of this window.
        /// </summary>
        Size Size { get; set; }
        
        /// <summary>
        /// Gets or sets the horizontal location of this window on the desktop.
        /// </summary>
        int X { get; set; }
        
        /// <summary>
        /// Gets or sets the vertical location of this window on the desktop.
        /// </summary>
        int Y { get; set; }
        
        /// <summary>
        /// Gets or sets the external width of this window.
        /// </summary>
        int Width { get; set; }
        
        /// <summary>
        /// Gets or sets the external height of this window.
        /// </summary>
        int Height { get; set; }
        
        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Rectangle"/> structure that contains the internal bounds of this window, in client coordinates.
        /// The internal bounds include the drawing area of the window, but exclude the titlebar and window borders.
        /// </summary>
        Rectangle ClientRectangle { get; set; }
        
        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Size"/> structure that contains the internal size this window.
        /// </summary>
        Size ClientSize { get; set; }

        /// <summary>
        /// This property is deprecated and should not be used.
        /// </summary>
        [Obsolete("Use OpenTK.Input.Mouse/Keyboard/Joystick/GamePad instead.")]
        OpenTK.Input.IInputDriver InputDriver { get; }

        /// <summary>
        /// Gets or sets the <see cref="OpenTK.MouseCursor"/> for this window.
        /// </summary>
        /// <value>The cursor.</value>
        MouseCursor Cursor { get; set; }

        /// <summary>
        /// Gets or sets a value, indicating whether the mouse cursor is visible.
        /// </summary>
        bool CursorVisible { get; set; }

//        /// <summary>
//        /// Gets or sets a value, indicating whether the mouse cursor is confined inside the window size.
//        /// </summary>
//        bool CursorGrabbed { get; set; }

        /// <summary>
        /// Closes this window.
        /// </summary>
        void Close();
        
        /// <summary>
        /// Processes pending window events.
        /// </summary>
        void ProcessEvents();
        
        /// <summary>
        /// Transforms the specified point from screen to client coordinates. 
        /// </summary>
        /// <param name="point">
        /// A <see cref="System.Drawing.Point"/> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to client coordinates.
        /// </returns>
        Point PointToClient(Point point);
        
        /// <summary>
        /// Transforms the specified point from client to screen coordinates. 
        /// </summary>
        /// <param name="point">
        /// A <see cref="System.Drawing.Point"/> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to screen coordinates.
        /// </returns>
        Point PointToScreen(Point point);

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
        /// Occurs when the <see cref="Icon"/> property of the window changes. 
        /// </summary>
        event EventHandler<EventArgs> IconChanged;

        /// <summary>
        /// Occurs when the <see cref="Title"/> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> TitleChanged;

        /// <summary>
        /// Occurs when the <see cref="Visible"/> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> VisibleChanged;

        /// <summary>
        /// Occurs when the <see cref="Focused"/> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> FocusedChanged;

        /// <summary>
        /// Occurs when the <see cref="WindowBorder"/> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> WindowBorderChanged;

        /// <summary>
        /// Occurs when the <see cref="WindowState"/> property of the window changes.
        /// </summary>
        event EventHandler<EventArgs> WindowStateChanged;

        /// <summary>
        /// Occurs whenever a keybord key is pressed.
        /// </summary>
        event EventHandler<OpenTK.Input.KeyboardKeyEventArgs> KeyDown;

        /// <summary>
        /// Occurs whenever a character is typed.
        /// </summary>
        event EventHandler<KeyPressEventArgs> KeyPress;
        
        /// <summary>
        /// Occurs whenever a keyboard key is released.
        /// </summary>
        event EventHandler<OpenTK.Input.KeyboardKeyEventArgs> KeyUp;

        /// <summary>
        /// Occurs whenever the mouse cursor leaves the window <see cref="Bounds"/>.
        /// </summary>
        event EventHandler<EventArgs> MouseLeave;

        /// <summary>
        /// Occurs whenever the mouse cursor enters the window <see cref="Bounds"/>.
        /// </summary>
        event EventHandler<EventArgs> MouseEnter;

        /// <summary>
        /// Occurs whenever a <see cref="OpenTK.Input.MouseButton"/> is clicked.
        /// </summary>
        event EventHandler<Input.MouseButtonEventArgs> MouseDown;

        /// <summary>
        /// Occurs whenever a <see cref="OpenTK.Input.MouseButton"/> is released.
        /// </summary>
        event EventHandler<Input.MouseButtonEventArgs> MouseUp;

        /// <summary>
        /// Occurs whenever the mouse cursor is moved;
        /// </summary>
        event EventHandler<Input.MouseMoveEventArgs> MouseMove;

        /// <summary>
        /// Occurs whenever a mouse wheel is moved;
        /// </summary>
        event EventHandler<Input.MouseWheelEventArgs> MouseWheel;

        //event EventHandler<MouseEventArgs> MouseClick;
        //event EventHandler<MouseEventArgs> MouseDoubleClick;

        //event EventHandler<DragEventArgs> DragDrop;
        //event EventHandler<DragEventArgs> DragEnter;
        //event EventHandler<DragEventArgs> DragOver;
        //event EventHandler<EventArgs> DragLeave;
    }
}
