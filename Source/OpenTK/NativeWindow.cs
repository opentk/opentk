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
using System.ComponentModel;
#if !MINIMAL
using System.Drawing;
#endif
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.Platform;

namespace OpenTK
{

    /// <summary>
    /// Instances of this class implement the <see cref="OpenTK.INativeWindow"/> interface on the current platform.
    /// </summary>
    public class NativeWindow : INativeWindow
    {
        #region --- Fields ---

        private readonly GameWindowFlags options;

        private readonly DisplayDevice device;

        private readonly INativeWindow implementation;

        private bool disposed, events;
        private bool cursor_visible = true;
        private bool previous_cursor_visible = true;

        #endregion

        #region --- Contructors ---

        /// <summary>Constructs a new NativeWindow with default attributes without enabling events.</summary>
        public NativeWindow()
            : this(640, 480, "OpenTK Native Window", GameWindowFlags.Default, GraphicsMode.Default, DisplayDevice.Default) { }

        // TODO: Remaining constructors.

        /// <summary>Constructs a new centered NativeWindow with the specified attributes.</summary>
        /// <param name="width">The width of the NativeWindow in pixels.</param>
        /// <param name="height">The height of the NativeWindow in pixels.</param>
        /// <param name="title">The title of the NativeWindow.</param>
        /// <param name="options">GameWindow options specifying window appearance and behavior.</param>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the NativeWindow.</param>
        /// <param name="device">The OpenTK.Graphics.DisplayDevice to construct the NativeWindow in.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If width or height is less than 1.</exception>
        /// <exception cref="System.ArgumentNullException">If mode or device is null.</exception>
        public NativeWindow(int width, int height, string title, GameWindowFlags options, GraphicsMode mode, DisplayDevice device)
            : this(device != null ? device.Bounds.Left + (device.Bounds.Width - width) / 2 : 0,
                   device != null ? device.Bounds.Top + (device.Bounds.Height - height) / 2 : 0,
                   width, height, title, options, mode, device) { }

        /// <summary>Constructs a new NativeWindow with the specified attributes.</summary>
        /// <param name="x">Horizontal screen space coordinate of the NativeWindow's origin.</param>
        /// <param name="y">Vertical screen space coordinate of the NativeWindow's origin.</param>
        /// <param name="width">The width of the NativeWindow in pixels.</param>
        /// <param name="height">The height of the NativeWindow in pixels.</param>
        /// <param name="title">The title of the NativeWindow.</param>
        /// <param name="options">GameWindow options specifying window appearance and behavior.</param>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the NativeWindow.</param>
        /// <param name="device">The OpenTK.Graphics.DisplayDevice to construct the NativeWindow in.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If width or height is less than 1.</exception>
        /// <exception cref="System.ArgumentNullException">If mode or device is null.</exception>
        public NativeWindow(int x, int y, int width, int height, string title, GameWindowFlags options, GraphicsMode mode, DisplayDevice device)
        {
            // TODO: Should a constraint be added for the position?
            if (width < 1)
                throw new ArgumentOutOfRangeException("width", "Must be greater than zero.");
            if (height < 1)
                throw new ArgumentOutOfRangeException("height", "Must be greater than zero.");
            if (mode == null)
                throw new ArgumentNullException("mode");

            this.options = options;
            this.device = device;

            IPlatformFactory factory = Factory.Default;
            implementation = factory.CreateNativeWindow(x, y, width, height, title, mode, options, this.device);
            factory.RegisterResource(this);

            if ((options & GameWindowFlags.Fullscreen) != 0)
            {
                if (this.device != null)
                {
                    this.device.ChangeResolution(width, height, mode.ColorFormat.BitsPerPixel, 0);
                }
                WindowState = WindowState.Fullscreen;
            }

            if ((options & GameWindowFlags.FixedWindow) != 0)
            {
                WindowBorder = WindowBorder.Fixed;
            }
        }

        #endregion

        #region --- INativeWindow Members ---

        #region Methods

        #region Close

        /// <summary>
        /// Closes the NativeWindow.
        /// </summary>
        public void Close()
        {
            EnsureUndisposed();
            implementation.Close();
        }

        #endregion

        #region PointToClient

        /// <summary>
        /// Transforms the specified point from screen to client coordinates. 
        /// </summary>
        /// <param name="point">
        /// A <see cref="System.Drawing.Point"/> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to client coordinates.
        /// </returns>
        public Point PointToClient(Point point)
        {
            return implementation.PointToClient(point);
        }

        #endregion

        #region PointToScreen

        /// <summary>
        /// Transforms the specified point from client to screen coordinates.
        /// </summary>
        /// <param name="point">
        /// A <see cref="System.Drawing.Point"/> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to screen coordinates.
        /// </returns>
        public Point PointToScreen(Point point)
        {
            return implementation.PointToScreen(point);
        }

        #endregion

        #region ProcessEvents

        /// <summary>
        /// Processes operating system events until the NativeWindow becomes idle.
        /// </summary>
        public void ProcessEvents()
        {
            ProcessEvents(false);
        }

        #endregion

        #endregion

        #region Properties

        #region Bounds

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Rectangle"/> structure
        /// that specifies the external bounds of this window, in screen coordinates.
        /// The coordinates are specified in device-independent points and
        /// include the title bar, borders and drawing area of the window.
        /// </summary>
        public Rectangle Bounds
        {
            get
            {
                EnsureUndisposed();
                return implementation.Bounds;
            }
            set
            {
                EnsureUndisposed();
                implementation.Bounds = value;
            }
        }

        #endregion

        #region ClientRectangle

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Rectangle"/> structure
        /// that defines the bounds of the OpenGL surface, in window coordinates.
        /// The coordinates are specified in device-dependent pixels.
        /// </summary>
        public Rectangle ClientRectangle
        {
            get
            {
                EnsureUndisposed();
                return implementation.ClientRectangle;
            }
            set
            {
                EnsureUndisposed();
                implementation.ClientRectangle = value;
            }
        }

        #endregion

        #region ClientSize

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Size"/> structure
        /// that defines the size of the OpenGL surface in window coordinates.
        /// The coordinates are specified in device-dependent pixels.
        /// </summary>
        public Size ClientSize
        {
            get
            {
                EnsureUndisposed();
                return implementation.ClientSize;
            }
            set
            {
                EnsureUndisposed();
                implementation.ClientSize = value;
            }
        }

        #endregion

        #region Cursor

        /// <summary>
        /// Gets or sets the <see cref="OpenTK.MouseCursor"/> for this window.
        /// </summary>
        public MouseCursor Cursor
        {
            get
            {
                EnsureUndisposed();
                return implementation.Cursor;
            }
            set
            {
                EnsureUndisposed();
                if (value == null)
                {
                    value = MouseCursor.Empty;
                }
                implementation.Cursor = value;
            }
        }

        #endregion

        #region Exists

        /// <summary>
        /// Gets a value indicating whether a render window exists.
        /// </summary>
        public bool Exists
        {
            get
            {
                return IsDisposed ? false : implementation.Exists; // TODO: Should disposed be ignored instead?
            }
        }

        #endregion

        #region Focused

        /// <summary>
        /// Gets a System.Boolean that indicates whether this NativeWindow has input focus.
        /// </summary>
        public bool Focused
        {
            get
            {
                EnsureUndisposed();
                return implementation.Focused;
            }
        }

        #endregion

        #region Height

        /// <summary>
        /// Gets or sets the height of the OpenGL surface in window coordinates.
        /// The coordinates are specified in device-dependent pixels.
        /// </summary>
        public int Height
        {
            get
            {
                EnsureUndisposed();
                return implementation.Height;
            }
            set
            {
                EnsureUndisposed();
                implementation.Height = value;
            }
        }

        #endregion

        #region Icon

        /// <summary>
        /// Gets or sets the System.Drawing.Icon for this GameWindow.
        /// </summary>
        public Icon Icon
        {
            get
            {
                EnsureUndisposed();
                return implementation.Icon;
            }
            set
            {
                EnsureUndisposed();
                implementation.Icon = value;
            }
        }

        #endregion

        #region InputDriver

        /// <summary>
        /// This property is deprecated.
        /// </summary>
        [Obsolete]
        public IInputDriver InputDriver
        {
            get
            {
                EnsureUndisposed();
                return implementation.InputDriver;
            }
        }

        #endregion

        #region Location

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Point"/> structure that contains the location of this window on the desktop.
        /// </summary>
        public Point Location
        {
            get
            {
                EnsureUndisposed();
                return implementation.Location;
            }
            set
            {
                EnsureUndisposed();
                implementation.Location = value;
            }
        }

        #endregion

        #region Size

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Size"/> structure that contains the external size of this window.
        /// </summary>
        public Size Size
        {
            get
            {
                EnsureUndisposed();
                return implementation.Size;
            }
            set
            {
                EnsureUndisposed();
                implementation.Size = value;
            }
        }

        #endregion

        #region Title

        /// <summary>
        /// Gets or sets the NativeWindow title.
        /// </summary>
        public string Title
        {
            get
            {
                EnsureUndisposed();
                return implementation.Title;
            }
            set
            {
                EnsureUndisposed();
                implementation.Title = value;
            }
        }

        #endregion

        #region Visible

        /// <summary>
        /// Gets or sets a System.Boolean that indicates whether this NativeWindow is visible.
        /// </summary>
        public bool Visible
        {
            get
            {
                EnsureUndisposed();
                return implementation.Visible;
            }
            set
            {
                EnsureUndisposed();
                implementation.Visible = value;
            }
        }

        #endregion

        #region Width

        /// <summary>
        /// Gets or sets the height of the OpenGL surface in window coordinates.
        /// The coordinates are specified in device-dependent pixels.
        /// </summary>
        public int Width
        {
            get
            {
                EnsureUndisposed();
                return implementation.Width;
            }
            set
            {
                EnsureUndisposed();
                implementation.Width = value;
            }
        }

        #endregion

        #region WindowBorder

        /// <summary>
        /// Gets or states the border of the NativeWindow.
        /// </summary>
        public WindowBorder WindowBorder
        {
            get
            {
                return implementation.WindowBorder;
            }
            set
            {
                implementation.WindowBorder = value;
            }
        }

        #endregion

        #region WindowInfo

        /// <summary>
        /// Gets the <see cref="OpenTK.Platform.IWindowInfo"/> of this window.
        /// </summary>
        public IWindowInfo WindowInfo
        {
            get
            {
                EnsureUndisposed();
                return implementation.WindowInfo;
            }
        }

        #endregion

        #region WindowState

        /// <summary>
        /// Gets or states the state of the NativeWindow.
        /// </summary>
        public virtual WindowState WindowState
        {
            get
            {
                return implementation.WindowState;
            }
            set
            {
                implementation.WindowState = value;
            }
        }

        #endregion

        #region X

        /// <summary>
        /// Gets or sets the horizontal location of this window in screen coordinates.
        /// The coordinates are specified in device-independent points.
        /// </summary>
        public int X
        {
            get
            {
                EnsureUndisposed();
                return implementation.X;
            }
            set
            {
                EnsureUndisposed();
                implementation.X = value;
            }
        }

        #endregion

        #region Y

        /// <summary>
        /// Gets or sets the vertical location of this window in screen coordinates.
        /// The coordinates are specified in device-independent points.
        /// </summary>
        public int Y
        {
            get
            {
                EnsureUndisposed();
                return implementation.Y;
            }
            set
            {
                EnsureUndisposed();
                implementation.Y = value;
            }
        }

        #endregion

        #region CursorVisible

        /// <summary>
        /// Gets or sets a value indicating whether the mouse cursor is visible.
        /// </summary>
        public bool CursorVisible
        {
            get { return cursor_visible; }
            set
            {
                cursor_visible = value;
                implementation.CursorVisible = value;
            }
        }

        #endregion

        #endregion

        #region Events

        /// <summary>
        /// Occurs after the window has closed.
        /// </summary>
        public event EventHandler<EventArgs> Closed = delegate { };

        /// <summary>
        /// Occurs when the window is about to close.
        /// </summary>
        public event EventHandler<CancelEventArgs> Closing = delegate { };

        /// <summary>
        /// Occurs when the window is disposed.
        /// </summary>
        public event EventHandler<EventArgs> Disposed = delegate { };

        /// <summary>
        /// Occurs when the <see cref="Focused"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> FocusedChanged = delegate { };

        /// <summary>
        /// Occurs when the <see cref="Icon"/> property of the window changes. 
        /// </summary>
        public event EventHandler<EventArgs> IconChanged = delegate { };

        /// <summary>
        /// Occurs whenever a keybord key is pressed.
        /// </summary>
        public event EventHandler<OpenTK.Input.KeyboardKeyEventArgs> KeyDown = delegate { };

        /// <summary>
        /// Occurs whenever a character is typed.
        /// </summary>
        public event EventHandler<KeyPressEventArgs> KeyPress = delegate { };

        /// <summary>
        /// Occurs whenever a keyboard key is released.
        /// </summary>
        public event EventHandler<OpenTK.Input.KeyboardKeyEventArgs> KeyUp = delegate { };

        /// <summary>
        /// Occurs whenever the window is moved.
        /// </summary>
        public event EventHandler<EventArgs> Move = delegate { };

        /// <summary>
        /// Occurs whenever the mouse cursor enters the window <see cref="Bounds"/>.
        /// </summary>
        public event EventHandler<EventArgs> MouseEnter = delegate { };
        
        /// <summary>
        /// Occurs whenever the mouse cursor leaves the window <see cref="Bounds"/>.
        /// </summary>
        public event EventHandler<EventArgs> MouseLeave = delegate { };

        /// <summary>
        /// Occurs whenever the window is resized.
        /// </summary>
        public event EventHandler<EventArgs> Resize = delegate { };

        /// <summary>
        /// Occurs when the <see cref="Title"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> TitleChanged = delegate { };

        /// <summary>
        /// Occurs when the <see cref="Visible"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> VisibleChanged = delegate { };

        /// <summary>
        /// Occurs when the <see cref="WindowBorder"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> WindowBorderChanged = delegate { };

        /// <summary>
        /// Occurs when the <see cref="WindowState"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> WindowStateChanged = delegate { };

        /// <summary>
        /// Occurs when a <see cref="MouseButton"/> is pressed.
        /// </summary>
        public event EventHandler<MouseButtonEventArgs> MouseDown = delegate { };

        /// <summary>
        /// Occurs when a <see cref="MouseButton"/> is released.
        /// </summary>
        public event EventHandler<MouseButtonEventArgs> MouseUp = delegate { };

        /// <summary>
        /// Occurs whenever the mouse is moved.
        /// </summary>
        public event EventHandler<MouseMoveEventArgs> MouseMove = delegate { };

        /// <summary>
        /// Occurs whenever a mouse wheel is moved;
        /// </summary>
        public event EventHandler<MouseWheelEventArgs> MouseWheel = delegate { };

        #endregion

        #endregion

        #region --- IDisposable Members ---

        #region Dispose

        /// <summary>
        /// Releases all non-managed resources belonging to this NativeWindow.
        /// </summary>
        public virtual void Dispose()
        {
            if (!IsDisposed)
            {
                if ((options & GameWindowFlags.Fullscreen) != 0)
                {
                    if (device != null)
                    {
                        device.RestoreResolution();
                    }
                }
                implementation.Dispose();
                GC.SuppressFinalize(this);

                IsDisposed = true;
            }
        }

        #endregion

        #endregion

        #region --- Protected Members ---

        #region Methods

        #region EnsureUndisposed

        /// <summary>
        /// Ensures that this NativeWindow has not been disposed.
        /// </summary>
        /// <exception cref="System.ObjectDisposedException">
        /// If this NativeWindow has been disposed.
        /// </exception>
        protected void EnsureUndisposed()
        {
            if (IsDisposed) throw new ObjectDisposedException(GetType().Name);
        }

        #endregion

        #region IsDisposed

        /// <summary>
        /// Gets or sets a <see cref="System.Boolean"/>, which indicates whether
        /// this instance has been disposed.
        /// </summary>
        protected bool IsDisposed
        {
            get { return disposed; }
            set { disposed = value; }
        }

        #endregion

        #region OnClosed

        /// <summary>
        /// Called when the NativeWindow has closed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnClosed(EventArgs e)
        {
            Closed(this, e);
        }

        #endregion

        #region OnClosing

        /// <summary>
        /// Called when the NativeWindow is about to close.
        /// </summary>
        /// <param name="e">
        /// The <see cref="System.ComponentModel.CancelEventArgs" /> for this event.
        /// Set e.Cancel to true in order to stop the NativeWindow from closing.</param>
        protected virtual void OnClosing(CancelEventArgs e)
        {
            Closing(this, e);
        }

        #endregion

        #region OnDisposed

        /// <summary>
        /// Called when the NativeWindow is disposed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnDisposed(EventArgs e)
        {
            Disposed(this, e);
        }

        #endregion

        #region OnFocusedChanged

        /// <summary>
        /// Called when the <see cref="OpenTK.INativeWindow.Focused"/> property of the NativeWindow has changed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnFocusedChanged(EventArgs e)
        {
            if (!Focused)
            {
                // Release cursor when losing focus, to ensure
                // IDEs continue working as expected.
                previous_cursor_visible = CursorVisible;
                CursorVisible = true;
            }
            else if (!previous_cursor_visible)
            {
                // Make cursor invisible when focus is regained
                // if cursor was invisible on previous focus loss.
                previous_cursor_visible = true;
                CursorVisible = false;
            }
            FocusedChanged(this, e);
        }

        #endregion

        #region OnIconChanged

        /// <summary>
        /// Called when the <see cref="OpenTK.INativeWindow.Icon"/> property of the NativeWindow has changed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnIconChanged(EventArgs e)
        {
            IconChanged(this, e);
        }

        #endregion

        #region OnKeyDown

        /// <summary>
        /// Occurs whenever a keybord key is pressed.
        /// </summary>
        protected virtual void OnKeyDown(KeyboardKeyEventArgs e)
        {
            KeyDown(this, e);
        }

        #endregion

        #region OnKeyPress

        /// <summary>
        /// Called when a character is typed.
        /// </summary>
        /// <param name="e">The <see cref="OpenTK.KeyPressEventArgs"/> for this event.</param>
        protected virtual void OnKeyPress(KeyPressEventArgs e)
        {
            KeyPress(this, e);
        }

        #endregion

        #region OnKeyUp

        /// <summary>
        /// Called when a keybord key is released.
        /// </summary>
        /// <param name="e">The <see cref="OpenTK.Input.KeyboardKeyEventArgs"/> for this event.</param>
        protected virtual void OnKeyUp(KeyboardKeyEventArgs e)
        {
            KeyUp(this, e);
        }

        #endregion

        #region OnMove

        /// <summary>
        /// Called when the NativeWindow is moved.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnMove(EventArgs e)
        {
            Move(this, e);
        }

        #endregion

        #region OnMouseEnter

        /// <summary>
        /// Called whenever the mouse cursor reenters the window <see cref="Bounds"/>.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnMouseEnter(EventArgs e)
        {
            MouseEnter(this, e);
        }

        #endregion

        #region OnMouseLeave

        /// <summary>
        /// Called whenever the mouse cursor leaves the window <see cref="Bounds"/>.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnMouseLeave(EventArgs e)
        {
            MouseLeave(this, e);
        }

        #endregion

        /// <summary>
        /// Raises the <see cref="MouseDown"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="MouseButtonEventArgs"/> instance carrying mouse state information.
        /// The information carried by this instance is only valid within this method body.
        /// </param>
        protected virtual void OnMouseDown(MouseButtonEventArgs e)
        {
            MouseDown(this, e);
        }

        /// <summary>
        /// Raises the <see cref="MouseUp"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="MouseButtonEventArgs"/> instance carrying mouse state information.
        /// The information carried by this instance is only valid within this method body.
        /// </param>
        protected virtual void OnMouseUp(MouseButtonEventArgs e)
        {
            MouseUp(this, e);
        }

        /// <summary>
        /// Raises the <see cref="MouseMove"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="MouseMoveEventArgs"/> instance carrying mouse state information.
        /// The information carried by this instance is only valid within this method body.
        /// </param>
        protected virtual void OnMouseMove(MouseMoveEventArgs e)
        {
            MouseMove(this, e);
        }

        /// <summary>
        /// Raises the <see cref="MouseWheel"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="MouseWheelEventArgs"/> instance carrying mouse state information.
        /// The information carried by this instance is only valid within this method body.
        /// </param>
        protected virtual void OnMouseWheel(MouseWheelEventArgs e)
        {
            MouseWheel(this, e);
        }

        #region OnResize

        /// <summary>
        /// Called when the NativeWindow is resized.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnResize(EventArgs e)
        {
            Resize(this, e);
        }

        #endregion

        #region OnTitleChanged

        /// <summary>
        /// Called when the <see cref="OpenTK.INativeWindow.Title"/> property of the NativeWindow has changed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnTitleChanged(EventArgs e)
        {
            TitleChanged(this, e);
        }

        #endregion

        #region OnVisibleChanged

        /// <summary>
        /// Called when the <see cref="OpenTK.INativeWindow.Visible"/> property of the NativeWindow has changed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnVisibleChanged(EventArgs e)
        {
            VisibleChanged(this, e);
        }

        #endregion

        #region OnWindowBorderChanged

        /// <summary>
        /// Called when the WindowBorder of this NativeWindow has changed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnWindowBorderChanged(EventArgs e)
        {
            WindowBorderChanged(this, e);
        }

        #endregion

        #region OnWindowStateChanged

        /// <summary>
        /// Called when the WindowState of this NativeWindow has changed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnWindowStateChanged(EventArgs e)
        {
            WindowStateChanged(this, e);
        }

        #endregion

        #region ProcessEvents

        /// <summary>
        /// Processes operating system events until the NativeWindow becomes idle.
        /// </summary>
        /// <param name="retainEvents">If true, the state of underlying system event propagation will be preserved, otherwise event propagation will be enabled if it has not been already.</param>
        protected void ProcessEvents(bool retainEvents)
        {
            EnsureUndisposed();
            if (!retainEvents && !events) Events = true;
            implementation.ProcessEvents();
        }

        #endregion

        #endregion

        #endregion

        #region --- Private Members ---

        #region Methods

        #region OnClosedInternal

        private void OnClosedInternal(object sender, EventArgs e)
        {
            OnClosed(e);
            Events = false;
        }

        #endregion

        #region OnClosingInternal

        private void OnClosingInternal(object sender, CancelEventArgs e) { OnClosing(e); }

        #endregion

        #region OnDisposedInternal

        private void OnDisposedInternal(object sender, EventArgs e) { OnDisposed(e); }

        #endregion

        #region OnFocusedChangedInternal

        private void OnFocusedChangedInternal(object sender, EventArgs e) { OnFocusedChanged(e); }

        #endregion

        #region OnIconChangedInternal

        private void OnIconChangedInternal(object sender, EventArgs e) { OnIconChanged(e); }

        #endregion

        #region OnKeyDownInternal

        private void OnKeyDownInternal(object sender, KeyboardKeyEventArgs e) { OnKeyDown(e); }

        #endregion

        #region OnKeyPressInternal

        private void OnKeyPressInternal(object sender, KeyPressEventArgs e) { OnKeyPress(e); }

        #endregion

        #region OnKeyUpInternal

        private void OnKeyUpInternal(object sender, KeyboardKeyEventArgs e) { OnKeyUp(e); }

        #endregion

        #region OnMouseEnterInternal

        private void OnMouseEnterInternal(object sender, EventArgs e) { OnMouseEnter(e); }

        #endregion

        #region OnMouseLeaveInternal

        private void OnMouseLeaveInternal(object sender, EventArgs e) { OnMouseLeave(e); }

        #endregion

        private void OnMouseDownInternal(object sender, MouseButtonEventArgs e) { OnMouseDown(e); }
        private void OnMouseUpInternal(object sender, MouseButtonEventArgs e) { OnMouseUp(e); }
        private void OnMouseMoveInternal(object sender, MouseMoveEventArgs e) { OnMouseMove(e); }
        private void OnMouseWheelInternal(object sender, MouseWheelEventArgs e) { OnMouseWheel(e); }

        #region OnMoveInternal

        private void OnMoveInternal(object sender, EventArgs e) { OnMove(e); }

        #endregion

        #region OnResizeInternal

        private void OnResizeInternal(object sender, EventArgs e) { OnResize(e); }

        #endregion

        #region OnTitleChangedInternal

        private void OnTitleChangedInternal(object sender, EventArgs e) { OnTitleChanged(e); }

        #endregion

        #region OnVisibleChangedInternal

        private void OnVisibleChangedInternal(object sender, EventArgs e) { OnVisibleChanged(e); }

        #endregion

        #region OnWindowBorderChangedInternal

        private void OnWindowBorderChangedInternal(object sender, EventArgs e) { OnWindowBorderChanged(e); }

        #endregion

        #region OnWindowStateChangedInternal

        private void OnWindowStateChangedInternal(object sender, EventArgs e) { OnWindowStateChanged(e); }

        #endregion

        #endregion

        #region Properties

        #region Events

        private bool Events
        {
            set
            {
                if (value)
                {
                    if (events)
                    {
                        throw new InvalidOperationException("Event propagation is already enabled.");
                    }
                    implementation.Closed += OnClosedInternal;
                    implementation.Closing += OnClosingInternal;
                    implementation.Disposed += OnDisposedInternal;
                    implementation.FocusedChanged += OnFocusedChangedInternal;
                    implementation.IconChanged += OnIconChangedInternal;
                    implementation.KeyDown += OnKeyDownInternal;
                    implementation.KeyPress += OnKeyPressInternal;
                    implementation.KeyUp += OnKeyUpInternal;
                    implementation.MouseEnter += OnMouseEnterInternal;
                    implementation.MouseLeave += OnMouseLeaveInternal;
                    implementation.MouseDown += OnMouseDownInternal;
                    implementation.MouseUp += OnMouseUpInternal;
                    implementation.MouseMove += OnMouseMoveInternal;
                    implementation.MouseWheel += OnMouseWheelInternal;
                    implementation.Move += OnMoveInternal;
                    implementation.Resize += OnResizeInternal;
                    implementation.TitleChanged += OnTitleChangedInternal;
                    implementation.VisibleChanged += OnVisibleChangedInternal;
                    implementation.WindowBorderChanged += OnWindowBorderChangedInternal;
                    implementation.WindowStateChanged += OnWindowStateChangedInternal;
                    events = true;
                }
                else if (events)
                {
                    implementation.Closed -= OnClosedInternal;
                    implementation.Closing -= OnClosingInternal;
                    implementation.Disposed -= OnDisposedInternal;
                    implementation.FocusedChanged -= OnFocusedChangedInternal;
                    implementation.IconChanged -= OnIconChangedInternal;
                    implementation.KeyDown -= OnKeyDownInternal;
                    implementation.KeyPress -= OnKeyPressInternal;
                    implementation.KeyUp -= OnKeyUpInternal;
                    implementation.MouseEnter -= OnMouseEnterInternal;
                    implementation.MouseLeave -= OnMouseLeaveInternal;
                    implementation.MouseDown -= OnMouseDownInternal;
                    implementation.MouseUp -= OnMouseUpInternal;
                    implementation.MouseMove -= OnMouseMoveInternal;
                    implementation.MouseWheel -= OnMouseWheelInternal;
                    implementation.Move -= OnMoveInternal;
                    implementation.Resize -= OnResizeInternal;
                    implementation.TitleChanged -= OnTitleChangedInternal;
                    implementation.VisibleChanged -= OnVisibleChangedInternal;
                    implementation.WindowBorderChanged -= OnWindowBorderChangedInternal;
                    implementation.WindowStateChanged -= OnWindowStateChangedInternal;
                    events = false;
                }
                else
                {
                    throw new InvalidOperationException("Event propagation is already disabled.");
                }
            }
        }

        #endregion

        #endregion

        #endregion
    }

}
