#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Graphics;
using System.Drawing;

#endregion

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Drives GameWindow on Windows.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class WinGLNative : System.Windows.Forms.NativeWindow, INativeGLWindow
    {
        #region --- Fields ---

        private IInputDriver driver;

        private bool visible = true;
        private bool disposed;
        private bool isExiting;
        private bool exists;
        private WinWindowInfo window;
        private WindowBorder windowBorder = WindowBorder.Resizable, previous_window_border;
        private WindowState windowState = WindowState.Normal;

        private int top, bottom, left, right;
        //private int width = 0, height = 0;
        private Rectangle previous_client_area;

        private Point position = new Point();
        private Rectangle client_rectangle = new Rectangle();
        private Size window_size = new Size();
        //private Rectangle borders = new Rectangle();

        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        /// <summary>
        /// For use in PeekMessage.
        /// </summary>
        private MSG myGoodMsg = new MSG();

        private int left_border, right_border, top_border, bottom_border;

        #endregion

        #region --- Contructors ---

        /// <internal />
        /// <summary>
        /// Constructs a new WinGLNative class. Call CreateWindow to create the
        /// actual render window.
        /// </summary>
        internal WinGLNative()
        {
            Debug.Print("Native window driver: {0}", this.ToString());
        }

        #endregion

        #region --- Protected Members ---

        #region protected override void WndProc(ref Message m)

        /// <summary>
        /// Processes incoming WM_* messages.
        /// </summary>
        /// <param name="m">Reference to the incoming Windows Message.</param>
        protected override void WndProc(ref Message m)
        {
            switch ((WindowMessage)m.Msg)
            {
                case WindowMessage.ACTIVATE:
                    break;

                case WindowMessage.WINDOWPOSCHANGED:
                    WindowPosition pos = (WindowPosition)Marshal.PtrToStructure(m.LParam, typeof(WindowPosition));
                    position.X = pos.x;
                    position.Y = pos.y;

                    window_size.Width = pos.cx;
                    window_size.Height = pos.cy;

                    Functions.GetClientRect(Handle, out client_rectangle);

                    break;

                case WindowMessage.STYLECHANGED:
                    WindowStyle style = (WindowStyle)(long)Functions.GetWindowLong(Handle, GetWindowLongOffsets.STYLE);
                    if ((style & WindowStyle.Popup) != 0)
                        windowBorder = WindowBorder.Hidden;
                    else if ((style & WindowStyle.ThickFrame) != 0)
                        windowBorder = WindowBorder.Resizable;
                    else if ((style & ~(WindowStyle.ThickFrame | WindowStyle.MaximizeBox)) != 0)
                        windowBorder = WindowBorder.Fixed;
                    break;

                case WindowMessage.SIZE:
                    long state = m.WParam.ToInt64();
                    switch (state)
                    {
                        case 0: windowState = WindowState.Normal; break;
                        case 1: windowState = WindowState.Minimized; break;
                        case 2:
                            windowState = WindowBorder == WindowBorder.Hidden ? WindowState.Fullscreen : WindowState.Maximized;
                            break;
                    }
                    break;

                //case WindowMessage.MOUSELEAVE:
                //    Cursor.Current = Cursors.Default;
                //    break;

                //case WindowMessage.MOUSE_ENTER:
                //    Cursor.Current = Cursors.Default;
                //    break;

                case WindowMessage.CREATE:
                    // Set the window width and height:
                    pos = (WindowPosition)Marshal.PtrToStructure(m.LParam, typeof(WindowPosition));
                    position.X = pos.x;
                    position.Y = pos.y;

                    window_size.Width = pos.cx;
                    window_size.Height = pos.cy;

                    // Raise the Create event
                    this.OnCreate(EventArgs.Empty);
                    return;

                case WindowMessage.CLOSE:
                    //this.DestroyWindow();
                    this.OnDestroy(EventArgs.Empty);
                    return;
                    //break;

                case WindowMessage.DESTROY:
                    //this.OnDestroy(EventArgs.Empty);
                    exists = false;
                    isExiting = true;
                    break;

                case WindowMessage.QUIT:
                    isExiting = true;
                    //this.Dispose();
                    //Debug.WriteLine("Application quit.");
                    return;
            }

            //DefWndProc(ref m);
            base.WndProc(ref m);
        }

        #endregion

        #endregion

        #region --- INativeGLWindow Members ---

        #region public void ProcessEvents()

        private int ret;
        MSG msg;
        public void ProcessEvents()
        {
            while (!IsIdle)
            {
                ret = Functions.GetMessage(ref msg, Handle, 0, 0);
                if (ret == -1)
                {
                    throw new ApplicationException(String.Format(
                        "An error happened while processing the message queue. Windows error: {0}",
                        Marshal.GetLastWin32Error()));
                }
                Functions.DispatchMessage(ref msg);
                //WndProc(ref msg);
            }
        }

        #endregion

        #region public IInputDriver InputDriver

        public IInputDriver InputDriver
        {
            get
            {
                return driver;
            }
        }

        #endregion

        #region public bool Exists

        /// <summary>
        /// Returns true if a render window/context exists.
        /// </summary>
        public bool Exists
        {
            get { return exists; }
        }

        #endregion

        #region public bool IsExiting

        public bool IsExiting
        {
            get { return isExiting; }
        }

        #endregion

        #region public bool IsIdle

        public bool IsIdle
        {
            get
            {
                //return !API.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
                return !Functions.PeekMessage(ref myGoodMsg, this.Handle, 0, 0, 0);
                //return API.GetQueueStatus(API.QueueStatusFlags.ALLEVENTS) == 0;
            }
        }

        #endregion

        #region public string Text

        public string Title
        {
            get
            {
                StringBuilder title = new StringBuilder(256);
                Functions.GetWindowText(window.WindowHandle, title, title.Capacity);
                return title.ToString();
            }
            set
            {
#if DEBUG
                bool ret = Functions.SetWindowText(window.WindowHandle, value);
                if (ret)
                    Debug.Print("Window {0} title changed to {1}.", window.WindowHandle, value);
                else
                    Debug.Print("Window {0} title failed to change to {1}.", window.WindowHandle, value);
#else
                Functions.SetWindowText(window.WindowHandle, value);
#endif
            }
        }

        #endregion

        #region public bool Visible

        /// <summary>
        /// TODO
        /// </summary>
        public bool Visible
        {
            get
            {
                return visible;
            }
            set
            {
                if (value && !Visible)
                {
                    Functions.ShowWindow(Handle, ShowWindowCommand.SHOWNORMAL);
                    visible = true;
                }
                else if (!value && Visible)
                {
                    Functions.ShowWindow(Handle, ShowWindowCommand.HIDE);
                    visible = false;
                }
            }
        }

        #endregion

        #region public IWindowInfo WindowInfo

        public IWindowInfo WindowInfo
        {
            get { return window; }
            //private set { window = value as WindowInfo; }
        }

        #endregion

        #region public void CreateWindow(int width, int height, GraphicsMode mode, out IGraphicsContext context)

        public void CreateWindow(int width, int height, GraphicsMode mode, out IGraphicsContext context)
        {
            Debug.Print("Creating native window.");
            Debug.Indent();
            //Debug.Print("GraphicsMode: {0}", format.ToString());

            CreateParams cp = new CreateParams();
            cp.ClassStyle =
                (int)WindowClassStyle.OwnDC |
                (int)WindowClassStyle.VRedraw |
                (int)WindowClassStyle.HRedraw |
                (int)WindowClassStyle.Ime;
            cp.Style =
                (int)WindowStyle.Visible |
                (int)WindowStyle.ClipChildren |
                (int)WindowStyle.ClipSiblings |
                (int)WindowStyle.OverlappedWindow;

            Rectangle rect = new Rectangle();
            rect.top = rect.left = 0;
            rect.bottom = height;
            rect.right = width;
            Functions.AdjustWindowRect(ref rect, WindowStyle.OverlappedWindow, false);

            // Not used
            Top = 0;
            Left = 0;
            Right = width;
            Bottom = height;
            // --------

            top_border = -rect.top;
            left_border = -rect.left;
            bottom_border = rect.bottom - height;
            right_border = rect.right - width;

            //cp.Width = rect.right - rect.left;
            //cp.Height = rect.bottom - rect.top;
            //cp.Caption = "OpenTK Game Window";

            // Keep in mind that some construction code runs in WM_CREATE,
            // which is raised CreateHandle()
            CreateHandle(cp);

            if (this.Handle != IntPtr.Zero)
            {
                Debug.WriteLine("Window creation succesful.");
                //context.Info = new OpenTK.Platform.WindowInfo(this);
                //context.CreateContext();
                //Debug.WriteLine("Context creation successful.");
                exists = true;
            }
            else throw new ApplicationException(String.Format(
                    "Could not create native window and/or context. Handle: {0}",
                    this.Handle));

            Functions.SetWindowPos(this.Handle, WindowPlacementOptions.TOP, Left, Top, rect.right - rect.left,
                                   rect.bottom - rect.top, SetWindowPosFlags.SHOWWINDOW);

            context = new GraphicsContext(mode, window);

            Cursor.Current = Cursors.Default;

            Debug.Unindent();
        }

        #endregion

        #region OnCreate

        public event CreateEvent Create;

        public void OnCreate(EventArgs e)
        {
            this.window = new WinWindowInfo(Handle, null);

            //driver = new WinRawInput(this.window);    // Disabled until the mouse issues are resolved.
            driver = new WMInput(this.window);

            Debug.Print("Window created: {0}", window);

            if (this.Create != null)
                this.Create(this, e);
        }

        #endregion

        #region private void DestroyWindow()

        /// <summary>
        /// Starts the teardown sequence for the current window.
        /// </summary>
        public void DestroyWindow()
        {
            Debug.Print("Destroying window: {0}", window.ToString());
            //Functions.PostMessage(this.Handle, WindowMessage.DESTROY, IntPtr.Zero, IntPtr.Zero);
            Functions.DestroyWindow(this.Handle);
        }

        #endregion

        #region OnDestroy

        public void OnDestroy(EventArgs e)
        {
            Debug.Print("Destroy event fired from window: {0}", window.ToString());
            if (this.Destroy != null)
                this.Destroy(this, e);
            /*
            if (this.Handle != IntPtr.Zero)
            {
                Debug.Print("Window handle {0} destroyed.", this.Handle);
                //this.DestroyHandle(); // Destroyed automatically by DefWndProc
                //this.Dispose();
                exists = false;
            }
            */
            //API.PostQuitMessage(0);
        }

        public event DestroyEvent Destroy;

        #endregion

        #region PointToClient

        public void PointToClient(ref System.Drawing.Point p)
        {
            if (!Functions.ScreenToClient(this.Handle, ref p))
                throw new InvalidOperationException(String.Format(
                    "Could not convert point {0} from client to screen coordinates. Windows error: {1}",
                    p.ToString(), Marshal.GetLastWin32Error()));
        }

        #endregion

        #region PointToScreen

        public void PointToScreen(ref System.Drawing.Point p)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region public WindowState WindowState

        public WindowState WindowState
        {
            get
            {
                return windowState;   
            }
            set
            {
                if (WindowState == value)
                    return;

                IntPtr style = Functions.GetWindowLong(Handle, GetWindowLongOffsets.STYLE);
                ShowWindowCommand command = (ShowWindowCommand)0;
                SetWindowPosFlags flags = SetWindowPosFlags.NOREPOSITION;
                int new_width = 0, new_height = 0;

                switch (value)
                {
                    case WindowState.Normal:
                        command = ShowWindowCommand.RESTORE;
                        flags |= SetWindowPosFlags.SHOWWINDOW | SetWindowPosFlags.FRAMECHANGED;

                        if (WindowState == WindowState.Fullscreen || WindowState == WindowState.Maximized)
                            WindowBorder = previous_window_border;

                        new_width = previous_client_area.Width;
                        new_height = previous_client_area.Height;
                        break;

                    case WindowState.Minimized:
                        command = ShowWindowCommand.SHOWMINIMIZED;
                        flags |= SetWindowPosFlags.NOSIZE;
                        break;

                    case WindowState.Maximized:
                    case WindowState.Fullscreen:
                        if (WindowState == WindowState.Normal || WindowState == WindowState.Minimized)
                        {
                            // Get the normal size of the window, so we can set it when reverting from fullscreen/maximized to normal.
                            previous_client_area = new Rectangle(window_size.Width, window_size.Height);
                            previous_window_border = WindowBorder;
                        }

                        command = ShowWindowCommand.SHOWMAXIMIZED;
                        flags |= SetWindowPosFlags.SHOWWINDOW | SetWindowPosFlags.DRAWFRAME | SetWindowPosFlags.NOSIZE;

                        if (value == WindowState.Fullscreen)
                            this.WindowBorder = WindowBorder.Hidden;
                        else
                            this.WindowBorder = previous_window_border;

                        break;
                }

                Functions.ShowWindow(Handle, command);
                Functions.SetWindowPos(Handle, WindowPlacementOptions.TOP, 0, 0, new_width, new_height, flags);

                //windowState = value;
            }
        }

        #endregion

        #region public WindowBorder WindowBorder
        
        public WindowBorder WindowBorder
        {
            get
            {
                return windowBorder;
            }
            set
            {
                if (windowBorder == value)
                    return;

                WindowStyle style = WindowStyle.ClipChildren | WindowStyle.ClipSiblings;

                switch (value)
                {
                    case WindowBorder.Resizable:
                        style |= WindowStyle.OverlappedWindow;
                        break;

                    case WindowBorder.Fixed:
                        style |= WindowStyle.OverlappedWindow & ~(WindowStyle.ThickFrame | WindowStyle.MaximizeBox |
                                                                  WindowStyle.SizeBox);
                        break;

                    case WindowBorder.Hidden:
                        style |= WindowStyle.Popup;
                        break;
                }

                Functions.SetWindowLong(Handle, GetWindowLongOffsets.STYLE, (IntPtr)(int)style);
                Functions.SetWindowPos(Handle, WindowPlacementOptions.TOP, 0, 0, 0, 0, SetWindowPosFlags.NOMOVE |
                    SetWindowPosFlags.NOSIZE | SetWindowPosFlags.FRAMECHANGED | SetWindowPosFlags.SHOWWINDOW);

                //windowBorder = value;
            }
        }

        #endregion

        #endregion

        #region --- IResizable Members ---

        #region public int Width

        /// <summary>Gets a System.Int32 containing the Width of this GameWindow.</summary>
        public int Width
        {
            get
            {
                return client_rectangle.Width;
            }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Window width must be higher than zero.");
                //if (WindowState == WindowState.Fullscreen || WindowState == WindowState.Maximized)
                //    throw new InvalidOperationException("Cannot resize a fullscreen or maximized window.");
                Functions.SetWindowPos(Handle, WindowPlacementOptions.TOP, 0, 0, value, Height, SetWindowPosFlags.NOMOVE);
            }
        }

        #endregion

        #region public int Height

        /// <summary>Gets a System.Int32 containing the Heights of this GameWindow.</summary>
        public int Height
        {
            get
            {
                return client_rectangle.Height;
            }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Window height must be higher than zero.");
                Functions.SetWindowPos(Handle, WindowPlacementOptions.TOP, 0, 0, Width, value, SetWindowPosFlags.NOMOVE);
            }
        }

        #endregion

        #region public void OnResize

        public event ResizeEvent Resize;

        public void OnResize(ResizeEventArgs e)
        {
            if (Resize != null)
                Resize(this, e);

            throw new NotImplementedException("Use GameWindow.OnResize instead.");
            //this.width = e.Width;
            //this.height = e.Height;
            //if (this.Resize != null)
            //    this.Resize(this, e);
        }

        #endregion

        #region Top, Bottom, Left and Right

        public int Top
        {
            get { return top; }
            private set { top = value; }
        }

        public int Bottom
        {
            get { return bottom; }
            private set { bottom = value; }
        }

        public int Left
        {
            get { return left; }
            private set { left = value; }
        }

        public int Right
        {
            get { return right; }
            private set { right = value; }
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            this.Dispose(true);
            //GC.SuppressFinalize(this);
        }

        private void Dispose(bool calledManually)
        {
            if (!disposed)
            {
                // Clean unmanaged resources here:

                if (calledManually)
                {
                    // Safe to clean managed resources
                    //base.DestroyHandle();
                }
                disposed = true;
            }
        }
        /*
        ~WinGLNative()
        {
            Dispose(false);
        }
        */
        #endregion
    }

    #region class WindowHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid

    /*
    class WindowHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        protected override bool ReleaseHandle()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override bool IsInvalid
        {
            get
            {
                return base.IsInvalid;
            }
        }
    }
    */

    #endregion
}
