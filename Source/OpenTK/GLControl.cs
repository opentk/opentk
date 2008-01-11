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
        DisplayMode display_mode;

        #region --- Constructor ---

        /// <summary>
        /// Constructs a new GLControl.
        /// </summary>
        public GLControl()
            : this(null)
        {
        }

        /// <summary>
        /// Constructs a new GLControl with the specified DisplayMode.
        /// </summary>
        /// <param name="mode"></param>
        public GLControl(DisplayMode mode)
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            DoubleBuffered = false;

            this.display_mode = mode;

            this.CreateControl();
        }

        #endregion

        #region --- Context Setup ---

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.CreateContext();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            this.DestroyContext();
        }

        #endregion

        #region --- Public Properties ---

        #region public bool IsIdle

        /// <summary>
        /// Gets a value indicating whether the current thread contains pending system messages.
        /// </summary>
        [Browsable(false)]
        public bool IsIdle
        {
            get { return idle.IsIdle; }
        }

        #endregion

        #region public IGLContext Context

        /// <summary>
        /// Gets an interface to the underlying GLContext used by this GLControl.
        /// </summary>
        [Browsable(false)]
        public IGLContext Context
        {
            get { return context; }
            private set { context = value; }
        }

        #endregion

        #region public float AspectRatio

        /// <summary>
        /// Gets the aspect ratio of this GLControl.
        /// </summary>
        [Description("The aspect ratio of the client area of this GLControl.")]
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
        [Description("Indicates whether GLControl updates are synced to the monitor's refresh.")]
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

        #region public DisplayMode Mode

        // TODO: Remove for 0.3.15

        /// <summary>
        /// Gets the DisplayMode of the GLContext attached to this GLControl.
        /// </summary>
        /// <remarks>
        /// You cannot change the DisplayMode of an existing GLContext.
        /// </remarks>
        public DisplayMode Mode
        {
            get { return (Context as IGLContextInternal).Mode; }
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

        #region public void CreateContext()
        
        /// <summary>
        /// Creates a GLContext and attaches it to this GLControl.
        /// </summary>
        public void CreateContext()
        {
            if (display_mode == null)
                display_mode = new DisplayMode();
            WindowInfo info = new WindowInfo(this);
            
            if (!this.DesignMode)
            {
                // Mono's implementation of Windows.Forms on X11 does not allow the context to
                // have a different colordepth from the parent. To combat this, we do not set a
                // specific depth for the DisplayMode - we let the driver select one instead.
                display_mode.Color = new ColorMode(0);
                context = new GLContext(display_mode, info);
                context.CreateContext(true, null);
                idle = new PlatformIdle(info);
            }
            else
            {
                context = new DummyGLContext(display_mode);
                idle = new DummyPlatformIdle();
            }
        }

        #endregion

        #region public void DestroyContext()

        /// <summary>
        /// Destroys the GLContext attached to this GLControl.
        /// </summary>
        /// <exception cref="NullReferenceException">Occurs when no GLContext is attached.</exception>
        public void DestroyContext()
        {
            Context.Dispose();
            Context = null;
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
        //IntPtr handle;

        public WinPlatformIdle(WindowInfo info)
        {
            //handle = info.Handle;
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

        public X11PlatformIdle(WindowInfo info)
        {
            display = ((OpenTK.Platform.X11.WindowInfo)info).Display;
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

        public PlatformIdle(WindowInfo info)
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
