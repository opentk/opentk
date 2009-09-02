using System;
using System.ComponentModel;
using System.Drawing;
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

        private bool disposed;

        private readonly INativeWindow implementation;

        #endregion

        #region --- Contructors ---

        #region NativeWindow()

        /// <summary>Constructs a new NativeWindow with default attributes without enabling events.</summary>
        public NativeWindow()
            : this(640, 480, "OpenTK Native Window", GameWindowFlags.Default, GraphicsMode.Default, DisplayDevice.Default, false) { }

        #endregion

        #region

        /// <summary>Constructs a new NativeWindow with default attributes.</summary>
        /// <param name="enableEvents">Indicates to enable event processing as part of the NativeWindow construction.</param>
        public NativeWindow(bool enableEvents)
            : this(640, 480, "OpenTK Native Window", GameWindowFlags.Default, GraphicsMode.Default, DisplayDevice.Default, enableEvents) { }

        #endregion

        // TODO: Remaining constructors.

        #region NativeWindow(int width, int height, string title, GameWindowFlags options, GraphicsMode mode, DisplayDevice device)

        /// <summary>Constructs a new centered NativeWindow with the specified attributes without enabling events.</summary>
        /// <param name="width">The width of the NativeWindow in pixels.</param>
        /// <param name="height">The height of the NativeWindow in pixels.</param>
        /// <param name="title">The title of the NativeWindow.</param>
        /// <param name="options">GameWindow options specifying window appearance and behavior.</param>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the NativeWindow.</param>
        /// <param name="device">The OpenTK.Graphics.DisplayDevice to construct the NativeWindow in.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If width or height is less than 1.</exception>
        /// <exception cref="System.ArgumentNullException">If mode or device is null.</exception>
        public NativeWindow(int width, int height, string title, GameWindowFlags options, GraphicsMode mode, DisplayDevice device)
            : this(width, height, title, options, mode, device, false) { }

        #endregion

        #region NativeWindow(int width, int height, string title, GameWindowFlags options, GraphicsMode mode, DisplayDevice device, bool enableEvents)

        /// <summary>Constructs a new centered NativeWindow with the specified attributes.</summary>
        /// <param name="width">The width of the NativeWindow in pixels.</param>
        /// <param name="height">The height of the NativeWindow in pixels.</param>
        /// <param name="title">The title of the NativeWindow.</param>
        /// <param name="options">GameWindow options specifying window appearance and behavior.</param>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the NativeWindow.</param>
        /// <param name="device">The OpenTK.Graphics.DisplayDevice to construct the NativeWindow in.</param>
        /// <param name="enableEvents">Indicates to enable event processing as part of the NativeWindow construction.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If width or height is less than 1.</exception>
        /// <exception cref="System.ArgumentNullException">If mode or device is null.</exception>
        public NativeWindow(int width, int height, string title, GameWindowFlags options, GraphicsMode mode, DisplayDevice device, bool enableEvents)
            : this(device.Bounds.Left + (device.Bounds.Width - width) / 2,
                   device.Bounds.Top + (device.Bounds.Height - height) / 2,
                   width, height, title, options, mode, device, enableEvents) { }

        #endregion

        #region NativeWindow0(int x, int y, int width, int height, string title, GameWindowFlags options, GraphicsMode mode, DisplayDevice device)

        /// <summary>Constructs a new NativeWindow with the specified attributes without enabling events.</summary>
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
            : this(x, y, width, height, title, options, mode, device, false) { }

        #endregion

        #region NativeWindow0(int x, int y, int width, int height, string title, GameWindowFlags options, GraphicsMode mode, DisplayDevice device, bool enableEvents)

        /// <summary>Constructs a new NativeWindow with the specified attributes.</summary>
        /// <param name="x">Horizontal screen space coordinate of the NativeWindow's origin.</param>
        /// <param name="y">Vertical screen space coordinate of the NativeWindow's origin.</param>
        /// <param name="width">The width of the NativeWindow in pixels.</param>
        /// <param name="height">The height of the NativeWindow in pixels.</param>
        /// <param name="title">The title of the NativeWindow.</param>
        /// <param name="options">GameWindow options specifying window appearance and behavior.</param>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the NativeWindow.</param>
        /// <param name="device">The OpenTK.Graphics.DisplayDevice to construct the NativeWindow in.</param>
        /// <param name="enableEvents">Indicates to enable event processing as part of the NativeWindow construction.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If width or height is less than 1.</exception>
        /// <exception cref="System.ArgumentNullException">If mode or device is null.</exception>
        public NativeWindow(int x, int y, int width, int height, string title, GameWindowFlags options, GraphicsMode mode, DisplayDevice device, bool enableEvents)
        {
            // TODO: Should a constraint be added for the position?
            if (width < 1)
                throw new ArgumentOutOfRangeException("width", "Must be greater than zero.");
            if (height < 1)
                throw new ArgumentOutOfRangeException("height", "Must be greater than zero.");
            if (mode == null)
                throw new ArgumentNullException("mode");
            if (device == null)
                throw new ArgumentNullException("device");

            implementation = Factory.Default.CreateNativeWindow(x, y, width, height, title, mode, options, device);

            if ((options & GameWindowFlags.Fullscreen) != 0)
            {
                device.ChangeResolution(width, height, mode.ColorFormat.BitsPerPixel, 0);
                WindowState = WindowState.Fullscreen;
            }

            if (enableEvents) EnableEvents();
        }

        #endregion

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
        public System.Drawing.Point PointToClient(System.Drawing.Point point)
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
        public System.Drawing.Point PointToScreen(System.Drawing.Point point)
        {
            // Here we use the fact that PointToClient just translates the point, and PointToScreen
            // should perform the inverse operation.
            System.Drawing.Point trans = PointToClient(System.Drawing.Point.Empty);
            point.X -= trans.X;
            point.Y -= trans.Y;
            return point;
        }

        #endregion

        #region ProcessEvents

        /// <summary>
        /// Processes operating system events until the NativeWindow becomes idle.
        /// </summary>
        public void ProcessEvents()
        {
            EnsureUndisposed();
            implementation.ProcessEvents();
        }

        #endregion

        #endregion

        #region Properties

        #region Bounds

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Rectangle"/> structure that contains the external bounds of this window, in screen coordinates.
        /// External bounds include the title bar, borders and drawing area of the window.
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
        /// Gets or sets a <see cref="System.Drawing.Rectangle"/> structure that contains the internal bounds of this window, in client coordinates.
        /// The internal bounds include the drawing area of the window, but exclude the titlebar and window borders.
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
        /// Gets or sets a <see cref="System.Drawing.Size"/> structure that contains the internal size this window.
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

        #region Exists

        /// <summary>
        /// Gets a value indicating whether a render window exists.
        /// </summary>
        public bool Exists
        {
            get
            {
                return disposed ? false : implementation.Exists; // TODO: Should disposed be ignored instead?
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
        /// Gets or sets the external height of this window.
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
        /// Gets or sets the external width of this window.
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
        public WindowState WindowState
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
        /// Gets or sets the horizontal location of this window on the desktop.
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
        /// Gets or sets the vertical location of this window on the desktop.
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

        #endregion

        #region Events

        /// <summary>
        /// Occurs after the window has closed.
        /// </summary>
        public event EventHandler<EventArgs> Closed;

        /// <summary>
        /// Occurs when the window is about to close.
        /// </summary>
        public event EventHandler<CancelEventArgs> Closing;

        /// <summary>
        /// Occurs when the window is disposed.
        /// </summary>
        public event EventHandler<EventArgs> Disposed;

        /// <summary>
        /// Occurs when the <see cref="Focused"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> FocusedChanged;

        /// <summary>
        /// Occurs whenever a character is typed.
        /// </summary>
        public event EventHandler<KeyPressEventArgs> KeyPress;

        /// <summary>
        /// Occurs whenever the window is moved.
        /// </summary>
        public event EventHandler<EventArgs> Move;

        /// <summary>
        /// Occurs whenever the window is resized.
        /// </summary>
        public event EventHandler<EventArgs> Resize;

        /// <summary>
        /// Occurs when the <see cref="Title"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> TitleChanged;

        /// <summary>
        /// Occurs when the <see cref="Visible"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> VisibleChanged;

        /// <summary>
        /// Occurs when the <see cref="WindowBorder"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> WindowBorderChanged;

        /// <summary>
        /// Occurs when the <see cref="WindowState"/> property of the window changes.
        /// </summary>
        public event EventHandler<EventArgs> WindowStateChanged;

        #endregion

        #endregion

        #region --- IDisposable Members ---

        #region Dispose

        /// <summary>
        /// Releases all non-managed resources belonging to this NativeWindow.
        /// </summary>
        public void Dispose()
        {
            if (!disposed)
            {
                implementation.Dispose();
                GC.SuppressFinalize(this);

                disposed = true;
            }
        }

        #endregion

        #endregion

        #region --- Protected Members ---

        #region Methods

        #region DisableEvents

        /// <summary>
        /// Disables the propagation of OS events.
        /// </summary>
        protected void DisableEvents()
        {
            EnsureUndisposed();
            implementation.Closed -= OnClosedInternal;
            implementation.Closing -= OnClosingInternal;
            implementation.Disposed -= OnDisposedInternal;
            implementation.FocusedChanged -= OnFocusedChangedInternal;
            implementation.KeyPress -= OnKeyPressInternal;
            implementation.Move -= OnMoveInternal;
            implementation.Resize -= OnResizeInternal;
            implementation.TitleChanged -= OnTitleChangedInternal;
            implementation.VisibleChanged -= OnVisibleChangedInternal;
            implementation.WindowBorderChanged -= OnWindowBorderChangedInternal;
            implementation.WindowStateChanged -= OnWindowStateChangedInternal;
        }

        #endregion

        #region EnableEvents

        /// <summary>
        /// Enables the propagation of OS events.
        /// </summary>
        protected void EnableEvents()
        {
            EnsureUndisposed();
            implementation.Closed += OnClosedInternal;
            implementation.Closing += OnClosingInternal;
            implementation.Disposed += OnDisposedInternal;
            implementation.FocusedChanged += OnFocusedChangedInternal;
            implementation.KeyPress += OnKeyPressInternal;
            implementation.Move += OnMoveInternal;
            implementation.Resize += OnResizeInternal;
            implementation.TitleChanged += OnTitleChangedInternal;
            implementation.VisibleChanged += OnVisibleChangedInternal;
            implementation.WindowBorderChanged += OnWindowBorderChangedInternal;
            implementation.WindowStateChanged += OnWindowStateChangedInternal;
        }

        #endregion

        #region EnsureUndisposed

        /// <summary>
        /// Ensures that this NativeWindow has not been disposed.
        /// </summary>
        /// <exception cref="System.ObjectDisposedException">
        /// If this NativeWindow has been disposed.
        /// </exception>
        protected void EnsureUndisposed()
        {
            if (disposed) throw new ObjectDisposedException(GetType().Name);
        }

        #endregion

        #region IsDisposed

        protected bool IsDisposed() //TODO: Could be a property but with a different name than the variable because of the event. Alternatively the disposed variable could be renamed too.
        {
            return disposed;
        }

        #endregion

        #region OnClosed

        /// <summary>
        /// Called when the NativeWindow has closed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnClosed(EventArgs e) { }

        #endregion

        #region OnClosing

        /// <summary>
        /// Called when the NativeWindow is about to close.
        /// </summary>
        /// <param name="e">
        /// The <see cref="System.ComponentModel.CancelEventArgs" /> for this event.
        /// Set e.Cancel to true in order to stop the NativeWindow from closing.</param>
        protected virtual void OnClosing(CancelEventArgs e) { }

        #endregion

        #region OnMove

        /// <summary>
        /// Called when the NativeWindow is moved.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnMove(EventArgs e) { }

        #endregion

        #region OnResize

        /// <summary>
        /// Called when the NativeWindow is resized.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnResize(EventArgs e) { }

        #endregion

        #region OnWindowBorderChanged

        /// <summary>
        /// Called when the WindowBorder of this NativeWindow has changed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnWindowBorderChanged(EventArgs e) { }

        #endregion

        #region OnWindowStateChanged

        /// <summary>
        /// Called when the WindowState of this NativeWindow has changed.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected virtual void OnWindowStateChanged(EventArgs e) { }

        #endregion

        #endregion

        #endregion

        #region --- Private Members ---

        #region OnClosedInternal

        private void OnClosedInternal(object sender, EventArgs e)
        {
            OnClosed(e);

            if (Closed != null) Closed(this, e);
        }

        #endregion

        #region OnClosingInternal

        private void OnClosingInternal(object sender, CancelEventArgs e)
        {
            OnClosing(e);

            if (Closing != null) Closing(this, e);

            //if (!e.Cancel) Close();
        }

        #endregion

        #region OnDisposedInternal

        private void OnDisposedInternal(object sender, EventArgs e)
        {
            // TODO: OnDisposed?
            if (Disposed != null) Disposed(this, e);
        }

        #endregion

        #region OnFocusedChangedInternal

        private void OnFocusedChangedInternal(object sender, EventArgs e)
        {
            // TODO: OnFocusedChanged?
            if (FocusedChanged != null) FocusedChanged(this, e);
        }

        #endregion

        #region OnKeyPressInternal

        private void OnKeyPressInternal(object sender, KeyPressEventArgs e)
        {
            // TODO: OnKeyPress?
            if (KeyPress != null) KeyPress(this, e);
        }

        #endregion

        #region OnMoveInternal

        private void OnMoveInternal(object sender, EventArgs e)
        {
            EnsureUndisposed();

            //if (!this.Exists || this.IsExiting) return; // TODO: See EnableEvents and DisableEvents.

            OnMove(e);

            if (Move != null) Move(this, e);
        }

        #endregion

        #region OnResizeInternal

        private void OnResizeInternal(object sender, EventArgs e)
        {
            EnsureUndisposed();

            //if (!this.Exists || this.IsExiting) return; // TODO: See EnableEvents and DisableEvents.

            OnResize(e);

            if (Resize != null) Resize(this, e);
        }

        #endregion

        #region OnTitleChangedInternal

        private void OnTitleChangedInternal(object sender, EventArgs e)
        {
            // TODO: OnTitleChanged?
            if (TitleChanged != null) TitleChanged(this, e);
        }

        #endregion

        #region OnVisibleChangedInternal

        private void OnVisibleChangedInternal(object sender, EventArgs e)
        {
            // TODO: OnVisibleChanged?
            if (VisibleChanged != null) VisibleChanged(this, e);
        }

        #endregion

        #region OnWindowBorderChangedInternal

        private void OnWindowBorderChangedInternal(object sender, EventArgs e)
        {
            OnWindowBorderChanged(e);

            if (WindowBorderChanged != null) WindowBorderChanged(this, e); // TODO: This was closed with EventArgs.Empty. Special reason?
        }

        #endregion

        #region OnWindowStateChangedInternal

        private void OnWindowStateChangedInternal(object sender, EventArgs e)
        {
            OnWindowStateChanged(e);

            if (WindowStateChanged != null) WindowStateChanged(this, e);
        }

        #endregion

        #endregion
    }

}
