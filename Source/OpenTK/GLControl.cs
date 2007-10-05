#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using OpenTK.Platform;

namespace OpenTK
{
    /// <summary>
    /// Defines a UserControl with OpenGL rendering capabilities.
    /// </summary>
    public partial class GLControl : UserControl
    {
        IGLContext context;
        IPlatformIdle idle;

        #region --- Constructor ---

        public GLControl()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        #endregion

        #region --- Context Setup ---

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // For maximum compatibility we do not set a specific depth for the DisplayMode.
            // The driver is free to find the best match.
            WindowInfo info = new WindowInfo(this);
            if (!this.DesignMode)
            {
                context = new GLContext(new DisplayMode(), info);
                context.CreateContext();
                idle = new PlatformIdle(info);
            }
            else
            {
                context = new DummyGLContext();
                idle = new DummyPlatformIdle();
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);

            context.Dispose();
        }

        #endregion

        #region --- Public Properties ---

        #region public bool IsIdle

        /// <summary>
        /// Gets a value indicating whether the current thread contains pending system messages.
        /// </summary>
        public bool IsIdle
        {
            get { return idle.IsIdle; }
        }

        #endregion

        #region public IGLContext Context

        /// <summary>
        /// Gets an interface to the underlying GLContext used by this GLControl.
        /// </summary>
        public IGLContext Context
        {
            get { return context; }
        }

        #endregion

        #region public float AspectRatio

        /// <summary>
        /// Gets the aspect ratio of this GLControl.
        /// </summary>
        public float AspectRatio
        {
            get
            {
                return this.ClientSize.Width / (float)this.ClientSize.Height;
            }
        }

        #endregion

        #region public bool VSync

        /// <summary>
        /// Gets or sets a value indicating whether vsync is active for this GLControl.
        /// </summary>
        public bool VSync
        {
            get
            {
                if (Context != null)
                    return Context.VSync;
                return false;
            }
            set
            {
                if (Context != null)
                    Context.VSync = value;
            }
        }

        #endregion

        #endregion

        #region --- Public Methods ---

        #region public void SwapBuffers()

        /// <summary>
        /// Swaps the front and back buffers, presenting the rendered scene to the screen.
        /// </summary>
        public void SwapBuffers()
        {
            Context.SwapBuffers();
        }

        #endregion

        #region public void MakeCurrent()

        /// <summary>
        /// Makes the underlying this GLControl current in the calling thread.
        /// All OpenGL commands issued are hereafter interpreted by this GLControl.
        /// </summary>
        public void MakeCurrent()
        {
            Context.MakeCurrent();
        }

        #endregion

        #endregion
    }

    #region internal interface IPlatformIdle

    internal interface IPlatformIdle
    {
        bool IsIdle { get; }
    }

    internal class WinPlatformIdle : IPlatformIdle
    {
        OpenTK.Platform.Windows.MSG msg = new OpenTK.Platform.Windows.MSG();
        object get_lock = new object();
        IntPtr handle;

        public WinPlatformIdle(IWindowInfo info)
        {
            handle = info.Handle;
        }

        #region IPlatformIdle Members

        public bool IsIdle
        {
            get 
            {
                lock (get_lock)
                {
                    return !OpenTK.Platform.Windows.Functions.PeekMessage(ref msg, IntPtr.Zero, 0, 0, 0);
                }
            }
        }

        #endregion
    }

    internal class X11PlatformIdle : IPlatformIdle
    {
        object get_lock = new object();
        IntPtr display;

        public X11PlatformIdle(IWindowInfo info)
        {
            display = (info as OpenTK.Platform.X11.WindowInfo).Display;
        }

        #region IPlatformIdle Members

        public bool IsIdle
        {
            get
            {
                lock (get_lock)
                {
                    return OpenTK.Platform.X11.Functions.XPending(display) == 0;
                }
            }
        }

        #endregion
    }

    internal class PlatformIdle : IPlatformIdle
    {
        IPlatformIdle implementation;

        public PlatformIdle(IWindowInfo info)
        {
            switch (System.Environment.OSVersion.Platform)
            {
                case PlatformID.Unix:
                case (PlatformID)128:
                    implementation = new X11PlatformIdle(info);
                    break;

                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    implementation = new WinPlatformIdle(info);
                    break;

                default:
                    throw new PlatformNotSupportedException();
            }
        }

        #region IPlatformIdle Members

        public bool IsIdle
        {
            get { return implementation.IsIdle; }
        }

        #endregion
    }

    internal class DummyPlatformIdle : IPlatformIdle
    {
        #region IPlatformIdle Members

        public bool IsIdle
        {
            get { return false; }
        }

        #endregion
    }

    #endregion
}
