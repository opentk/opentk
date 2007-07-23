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
using OpenTK.Input;

#endregion

namespace OpenTK.Platform.Windows
{
    sealed class WinGLNative : NativeWindow, OpenTK.Platform.INativeWindow, IDisposable
    {
        private WinGLContext glContext;
        private DisplayMode mode = new DisplayMode();
        
        private bool disposed;

        #region --- Contructors ---

        /// <summary>
        /// Constructs a new WinGLNative window, using safe defaults for the DisplayMode.
        /// </summary>
        public WinGLNative()
        {
            mode = new DisplayMode();
            mode.Width = 640;
            mode.Height = 480;

            this.CreateWindow(mode);
        }

        #endregion

        #region private void CreateWindow()

        private void CreateWindow(DisplayMode mode)
        {

            CreateParams cp = new CreateParams();
            cp.ClassStyle =
                (int)API.WindowClassStyle.OwnDC |
                (int)API.WindowClassStyle.VRedraw |
                (int)API.WindowClassStyle.HRedraw;
            cp.Style =
                (int)API.WindowStyle.Visible |
                (int)API.WindowStyle.ClipChildren |
                (int)API.WindowStyle.ClipSiblings |
                (int)API.WindowStyle.OverlappedWindow;
            cp.Width = mode.Width;
            cp.Height = mode.Height;
            cp.Caption = "OpenTK Game Window";
            base.CreateHandle(cp);

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
        }

        /*
        private void CreateWindow()
        {
            WinApi.WindowClass wc = new WinApi.WindowClass();
            wc.style =
                WinApi.WindowClassStyle.HRedraw |
                WinApi.WindowClassStyle.VRedraw |
                WinApi.WindowClassStyle.OwnDC;
            wc.WindowProcedure = new WinApi.WindowProcedureEventHandler(WndProc);
            wc.Instance = instance;
            //wc.ClassName = Marshal.StringToHGlobalAuto(className);
            wc.ClassName = className;

            classAtom = WinApi.RegisterClass(wc);

            if (classAtom == 0)
            {
                throw new Exception("Could not register class, error: " + Marshal.GetLastWin32Error());
            }
            
            // Change for fullscreen!
            handle = WinApi.CreateWindowEx(
                WinApi.ExtendedWindowStyle.ApplicationWindow |
                WinApi.ExtendedWindowStyle.OverlappedWindow |
                WinApi.ExtendedWindowStyle.Topmost,
                className,
                //Marshal.StringToHGlobalAuto("OpenTK Game Window"),
                "OpenTK Game Window",
                WinApi.WindowStyle.OverlappedWindow |
                WinApi.WindowStyle.ClipChildren |
                WinApi.WindowStyle.ClipSiblings,
                0, 0,
                640, 480,
                IntPtr.Zero,
                IntPtr.Zero,
                instance,
                IntPtr.Zero
            );

            if (handle == IntPtr.Zero)
            {
                throw new Exception("Could not create window, error: " + Marshal.GetLastWin32Error());
            }
        }
        */
        #endregion

        #region protected override void WndProc(ref Message m)

        /// <summary>
        /// For use in WndProc only.
        /// </summary>
        private int width, height;

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

                    // Raise the resize event:
                    //resizeEventArgs.Width = width;
                    //resizeEventArgs.Height = height;
                    //this.OnResize(resizeEventArgs);
                    return;

                case API.Constants.WM_KEYDOWN:
                case API.Constants.WM_KEYUP:
                    if (this.ProcessKey(ref m))
                        return;
                    else
                        break;
                
                case API.Constants.WM_CLOSE:
                    API.PostQuitMessage(0);
                    return;

                case API.Constants.WM_QUIT:
                    quit = true;
                    break;
            }

 	        base.WndProc(ref m);
        }

        private bool ProcessKey(ref Message m)
        {
            switch ((int)m.WParam)
            {
                case API.Constants.VK_ESCAPE:
                    Key.Escape = (m.Msg == API.Constants.WM_KEYDOWN) ? true : false;
                    return true;
            }

            return false;
        }

        #endregion

        #region --- IGLWindow Members ---

        #region public void ProcessEvents()

        private System.Windows.Forms.Message msg;
        public void ProcessEvents()
        {
            while (API.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0))
            {
                API.GetMessage(out msg, IntPtr.Zero, 0, 0);
                WndProc(ref msg);
            }
        }

        #endregion

        #region public event CreateEvent Create;

        public event CreateEvent Create;

        private void OnCreate(EventArgs e)
        {
            if (this.Create != null)
            {
                this.Create(this, e);
            }
        }

        #endregion

        #region public bool Quit

        private bool quit;
        public bool Quit
        {
            get { return quit; }
            set
            {
                if (value)
                {
                    API.PostQuitMessage(0);
                    //quit = true;
                }
            }
        }

        #endregion

        #region public IGLContext Context

        public IGLContext Context
        {
            get { return glContext; }
        }

        #endregion

        #region public bool Fullscreen

        bool fullscreen;
        public bool Fullscreen
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region public bool IsIdle

        public bool IsIdle
        {
            get
            {
                return !API.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
            }
        }

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
