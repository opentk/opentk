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
using OpenTK.OpenGL;
using OpenTK.Input;

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

        private DisplayMode mode = new DisplayMode();
        private IInputDriver driver;

        //private bool fullscreen;
        private bool disposed;
        private bool isExiting;
        private bool exists;
        private WindowInfo window = new WindowInfo();
        private int top, bottom, left, right;

        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        /// <summary>
        /// For use in PeekMessage.
        /// </summary>
        private MSG myGoodMsg = new MSG();

        /// <summary>
        /// For use in WndProc only.
        /// </summary>
        private int width = 0, height = 0;

        private int left_border, right_border, top_border, bottom_border;

        #endregion

        #region --- Contructors ---

        /// <summary>
        /// Constructs a new WinGLNative class. Call CreateWindow to create the
        /// actual render window.
        /// </summary>
        public WinGLNative()
        {
            Debug.Print("Native window driver: {0}", this.ToString());
        }

        #endregion

        #region protected override void WndProc(ref Message m)

        /// <summary>
        /// Processes incoming WM_* messages.
        /// </summary>
        /// <param name="m">Reference to the incoming Windows Message.</param>
        protected override void WndProc(ref Message m)
        {
            switch ((WindowMessage)m.Msg)
            {
                case WindowMessage.WINDOWPOSCHANGED:
                    // Get window size
                    width = Marshal.ReadInt32(m.LParam, (int)Marshal.OffsetOf(typeof(WindowPosition), "cx"));
                    height = Marshal.ReadInt32(m.LParam, (int)Marshal.OffsetOf(typeof(WindowPosition), "cy"));
                    width -= (left_border + right_border);
                    height -= (top_border + bottom_border);
                    //if (resizeEventArgs.Width != width || resizeEventArgs.Height != height)
                    if (this.mode.Width != width || this.mode.Height != height)
                    {
                        mode.Width = width;
                        mode.Height = height;
                        // If the size has changed, raise the ResizeEvent.
                        //resizeEventArgs.Width = width;
                        //resizeEventArgs.Height = height;
                        //this.OnResize(resizeEventArgs);
                        // The message was processed.
                        return;
                    }
                    // If the message was not a resize notification, send it to the default WndProc.
                    break;

                case WindowMessage.CREATE:
                    // Set the window width and height:
                    this.mode.Width = Marshal.ReadInt32(m.LParam, (int)Marshal.OffsetOf(typeof(CreateStruct), "cx"));
                    this.mode.Height = Marshal.ReadInt32(m.LParam, (int)Marshal.OffsetOf(typeof(CreateStruct), "cy"));
                    this.mode.Width -= (left_border + right_border);
                    this.mode.Height -= (top_border + bottom_border);

                    // Raise the Create event
                    this.OnCreate(EventArgs.Empty);
                    return;

                case WindowMessage.CLOSE:
                    //this.DestroyWindow();
                    this.OnDestroy(EventArgs.Empty);
                    return;

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

        #region public bool Quit

        public bool IsExiting
        {
            get { return isExiting; }
        }

        #endregion

        #region public bool Fullscreen

        public bool Fullscreen
        {
            get
            {
                return false;
                //throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
                //fullscreen = false;
            }
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
                Functions.GetWindowText(window.Handle, title, title.Capacity);
                return title.ToString();
            }
            set
            {
#if DEBUG
                bool ret = Functions.SetWindowText(window.Handle, value);
                if (ret)
                    Debug.Print("Window {0} title changed to {1}.", window.Handle, value);
                else
                    Debug.Print("Window {0} title failed to change to {1}.", window.Handle, value);
#else
                Functions.SetWindowText(window.Handle, value);
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
                //Functions.GetW
                return true;
            }
            set
            {
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

        #region public void CreateWindow(DisplayMode mode, GLContext context)

        public void CreateWindow(DisplayMode windowMode, GLContext context)
        {
            Debug.Print("Creating native window with mode: {0}", windowMode.ToString());
            Debug.Indent();

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
            rect.bottom = windowMode.Height;
            rect.right = windowMode.Width;
            Functions.AdjustWindowRect(ref rect, WindowStyle.OverlappedWindow, false);

            // Not used
            Top = 0;
            Left = 0;
            Right = windowMode.Width;
            Bottom = windowMode.Height;
            // --------

            top_border = -rect.top;
            left_border = -rect.left;
            bottom_border = rect.bottom - windowMode.Height;
            right_border = rect.right - windowMode.Width;

            cp.Width = rect.right - rect.left;
            cp.Height = rect.bottom - rect.top;
            cp.Caption = "OpenTK Game Window";

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

            Debug.Unindent();
        }

        #endregion

        #region OnCreate

        public event CreateEvent Create;

        public void OnCreate(EventArgs e)
        {
            this.window.Handle = this.Handle;
            this.window.Parent = null;
            //this.window = new WindowInfo(this);

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
            Functions.PostMessage(this.Handle, WindowMessage.DESTROY, IntPtr.Zero, IntPtr.Zero);
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

        #endregion

        #region --- IResizable Members ---

        #region public int Width

        public int Width
        {
            get
            {
                return mode.Width;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region public int Height

        public int Height
        {
            get
            {
                return mode.Height;
            }
            set
            {
                throw new NotImplementedException();
                //WinApi.PostMessage(
                //    this.Handle,
                //    WinApi.Constants.WM_WINDOWPOSCHANGING,

                //mode.Height = value;
            }
        }

        #endregion

        #region public void OnResize

        public event ResizeEvent Resize;

        public void OnResize(ResizeEventArgs e)
        {
            mode.Width = e.Width;
            mode.Height = e.Height;
            if (this.Resize != null)
                this.Resize(this, e);
        }

        #endregion

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
