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

#endregion

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Drives GameWindow on Windows.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    sealed class WinGLNative : NativeWindow, INativeGLWindow, IDisposable
    {
        #region --- Fields ---

        private WinGLContext glContext;
        private DisplayMode mode = new DisplayMode();

        private bool fullscreen = false;
        private bool disposed;
        private bool isExiting;
        private bool exists;
        private WindowInfo window;

        /// <summary>
        /// For use in WndProc only.
        /// </summary>
        private int width, height;

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
            switch (m.Msg)
            {
                case API.Constants.WM_WINDOWPOSCHANGED:
                    // Get window size
                    width = Marshal.ReadInt32(m.LParam, (int)Marshal.OffsetOf(typeof(API.WindowPosition), "cx"));
                    height = Marshal.ReadInt32(m.LParam, (int)Marshal.OffsetOf(typeof(API.WindowPosition), "cy"));
                    //if (resizeEventArgs.Width != width || resizeEventArgs.Height != height)
                    if (mode.Width != width || mode.Height != height)
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

                case API.Constants.WM_CREATE:
                    // Set the window width and height:
                    mode.Width = Marshal.ReadInt32(m.LParam, (int)Marshal.OffsetOf(typeof(API.CreateStruct), "cx"));
                    mode.Height = Marshal.ReadInt32(m.LParam, (int)Marshal.OffsetOf(typeof(API.CreateStruct), "cy"));

                    // Raise the Create event
                    this.OnCreate(EventArgs.Empty);
                    return;

                case API.Constants.WM_CLOSE:
                    this.DestroyWindow();
                    return;

                case API.Constants.WM_DESTROY:
                    this.OnDestroy(EventArgs.Empty);
                    break;

                case API.Constants.WM_QUIT:
                    isExiting = true;
                    //Debug.WriteLine("Application quit.");
                    return;
            }

            DefWndProc(ref m);
        }

        #endregion

        #region --- INativeGLWindow Members ---

        #region public void ProcessEvents()

        private int ret;
        System.Windows.Forms.Message msg;
        public void ProcessEvents()
        {
            while (!IsIdle)
            {
                ret = API.GetMessage(out msg, Handle, 0, 0);
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
                return !API.PeekMessage(out msg, this.Handle, 0, 0, 0);
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

        public void CreateWindow(DisplayMode mode)
        {
            Debug.Print("Creating native window with mode: {0}", mode.ToString());
            Debug.Indent();

            CreateParams cp = new CreateParams();
            cp.ClassStyle =
                (int)API.WindowClassStyle.OwnDC |
                (int)API.WindowClassStyle.VRedraw |
                (int)API.WindowClassStyle.HRedraw | (int)API.WindowClassStyle.Ime;
            cp.Style =
                (int)API.WindowStyle.Visible |
                (int)API.WindowStyle.ClipChildren |
                (int)API.WindowStyle.ClipSiblings |
                (int)API.WindowStyle.OverlappedWindow;
            cp.Width = mode.Width;
            cp.Height = mode.Height;
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

            glContext = new WinGLContext(
                this.Handle,
                new DisplayMode(
                    width, height,
                    new ColorDepth(32),
                    16, 0, 0, 2,
                    fullscreen,
                    false,
                    false,
                    0.0f
                )
            );

            glContext.CreateContext();

            OpenTK.OpenGL.GL.LoadAll();

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
            API.PostMessage(this.Handle, API.Constants.WM_DESTROY, IntPtr.Zero, IntPtr.Zero);
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
                exists = false;
            }
            API.PostQuitMessage(0);
        }

        public event DestroyEvent Destroy;

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);

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
                    base.DestroyHandle();
                }
                disposed = true;
            }
        }

        ~WinGLNative()
        {
            Dispose(false);
        }

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
                //WinApi.PostMessage(
                //    this.Handle,
                //    WinApi.Constants.WM_WINDOWPOSCHANGING,

                //mode.Width = value;
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
