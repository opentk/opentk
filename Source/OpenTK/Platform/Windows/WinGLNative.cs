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

#endregion

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Drives GameWindow on Windows.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    sealed class WinGLNative : NativeWindow, INativeGLWindow
    {
        #region --- Fields ---

        private WinGLContext glContext;
        private DisplayMode mode = new DisplayMode();

        private bool fullscreen;
        private bool disposed;
        private bool isExiting;
        private bool exists;
        private WindowInfo window;
        private int top, bottom, left, right;

        /// <summary>
        /// For use in PeekMessage. System.Windows.Forms.Message causes deadlock there.
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
                        // If the size has changed, raise the ResizeEvent.
                        resizeEventArgs.Width = width;
                        resizeEventArgs.Height = height;
                        this.OnResize(resizeEventArgs);
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
                    this.DestroyWindow();
                    return;

                case WindowMessage.DESTROY:
                    this.OnDestroy(EventArgs.Empty);
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
                ret = API.GetMessage(ref msg, Handle, 0, 0);
                if (ret == -1)
                {
                    throw new ApplicationException(String.Format(
                        "An error happened while processing the message queue. Windows error: {0}",
                        Marshal.GetLastWin32Error()));
                }
                API.DispatchMessage(ref msg);
                //WndProc(ref msg);
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

        #region public IGLContext Context

        public IGLContext Context
        {
            get { return glContext; }
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
                fullscreen = false;
                throw new NotImplementedException();
            }
        }

        #endregion

        #region public bool IsIdle

        public bool IsIdle
        {
            get
            {
                //return !API.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
                return !API.PeekMessage(ref myGoodMsg, this.Handle, 0, 0, 0);
                //return API.GetQueueStatus(API.QueueStatusFlags.ALLEVENTS) == 0;
            }
        }

        #endregion

        #region public IWindowInfo WindowInfo

        public IWindowInfo WindowInfo
        {
            get { return window; }
        }

        #endregion

        #region private void CreateWindow(DisplayMode mode)

        public void CreateWindow(DisplayMode windowMode)
        {
            Debug.Print("Creating native window with mode: {0}", mode.ToString());
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
            API.AdjustWindowRect(ref rect, WindowStyle.OverlappedWindow, false);

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

            if (this.Handle != IntPtr.Zero && glContext != null)
            {
                Debug.WriteLine("Window creation was succesful.");
                exists = true;
            }
            else
            {
                throw new ApplicationException(String.Format(
                    "Could not create native window and/or context. Handle: {0}, Context {1}",
                    this.Handle, this.Context.ToString()));
            }

            Debug.Unindent();
        }

        #endregion

        #region OnCreate

        public event CreateEvent Create;

        public void OnCreate(EventArgs e)
        {
            window = new WindowInfo();
            window.Handle = this.Handle;
            window.Parent = null;

            Debug.Print("Window created: {0}", window);

            try
            {
                glContext = new WinGLContext(this.mode);
                glContext.PrepareContext(this.Handle);
                glContext.CreateContext();
                //glContext.MakeCurrent();
                GL.LoadAll();
                Glu.LoadAll();
            }
            catch (ApplicationException expt)
            {
                Debug.Print("Could not create opengl context, error: {0}", expt.ToString());
                throw;
            }

            if (this.Create != null)
            {
                this.Create(this, e);
            }
        }

        #endregion

        #region private void DestroyWindow()

        /// <summary>
        /// Starts the teardown sequence for the current window.
        /// </summary>
        public void DestroyWindow()
        {
            Debug.Print("Destroying window: {0}", window.ToString());
            API.PostMessage(this.Handle, WindowMessage.DESTROY, IntPtr.Zero, IntPtr.Zero);
        }

        #endregion

        #region OnDestroy

        public void OnDestroy(EventArgs e)
        {
            if (this.Destroy != null)
            {
                this.Destroy(this, e);
            }
            
            if (this.Handle != IntPtr.Zero)
            {
                Debug.Print("Window handle {0} destroyed.", this.Handle);
                //this.DestroyHandle(); // Destroyed automatically by DefWndProc
                //this.Dispose();
                exists = false;
            }
            //API.PostQuitMessage(0);
        }

        public event DestroyEvent Destroy;

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

        #region public event ResizeEvent Resize
        public event ResizeEvent Resize;
        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();
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
                    glContext.Dispose();
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
