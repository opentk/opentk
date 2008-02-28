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
using OpenTK.Graphics;

namespace OpenTK
{
    /// <summary>
    /// Defines a UserControl with OpenGL rendering capabilities.
    /// </summary>
    public partial class GLControl : UserControl
    {
        IGraphicsContext context;
        GraphicsMode format;
        IGLControlHelper helper;

        #region --- Constructor ---

        /// <summary>
        /// Constructs a new GLControl.
        /// </summary>
        public GLControl()
            : this(GraphicsMode.Default)
        { }

        /// <summary>
        /// Constructs a new GLControl with the specified DisplayMode.
        /// </summary>
        /// <param name="mode"></param>
        public GLControl(DisplayMode mode)
            : this(mode.ToGraphicsMode())
        { }

        public GLControl(GraphicsMode format)
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            DoubleBuffered = false;

            this.format = format;

            this.CreateControl();
        }

        #endregion

        #region --- Protected Methods ---

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (Configuration.RunningOnWindows)
                helper = new Platform.Windows.WinGLControlHelper(this);
            else if (Configuration.RunningOnX11)
                throw new NotImplementedException();
            //helper = new Platform.X11.X11GLControlHelper(this);
            else if (Configuration.RunningOnOSX)
                throw new NotImplementedException();
            this.CreateContext();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            this.DestroyContext();
        }

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
        /// Creates a GraphicsContext and attaches it to this GLControl.
        /// </summary>
        public void CreateContext()
        {
            if (context != null)
                throw new InvalidOperationException("GLControl already contains an OpenGL context.");
            if (format == null)
                format = GraphicsMode.Default;

            if (!this.DesignMode)
            {
                // Note: Mono's implementation of Windows.Forms on X11 does not allow the context to
                // have a different colordepth from the parent window.
                context = new GraphicsContext(format, helper.WindowInfo);
            }
            else
                context = new DummyGLContext(format);
        }

        #endregion

        #region public void DestroyContext()

        /// <summary>
        /// Destroys the GraphicsContext attached to this GLControl.
        /// </summary>
        /// <exception cref="NullReferenceException">Occurs when no GraphicsContext is attached.</exception>
        public void DestroyContext()
        {
            Context.Dispose();
            Context = null;
        }

        #endregion

        #region public bool IsIdle

        /// <summary>
        /// Gets a value indicating whether the current thread contains pending system messages.
        /// </summary>
        [Browsable(false)]
        public bool IsIdle
        {
            get { return helper.IsIdle; }
        }

        #endregion

        #region public IGraphicsContext Context

        /// <summary>
        /// Gets an interface to the underlying GraphicsContext used by this GLControl.
        /// </summary>
        [Browsable(false)]
        public IGraphicsContext Context
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

        #region public GraphicsMode GraphicsMode

        /// <summary>
        /// Gets the GraphicsMode of the GraphicsContext attached to this GLControl.
        /// </summary>
        /// <remarks>
        /// To change the GraphicsMode, you must destroy and recreate the GLControl.
        /// </remarks>
        public GraphicsMode GraphicsMode
        {
            get { return (Context as IGLContextInternal).GraphicsMode; }
        }

        #endregion

        #endregion
    }

    #region internal interface IPlatformIdle
#if false
    internal interface IPlatformIdle
    {
        bool IsIdle { get; }
    }

    internal class X11PlatformIdle : IPlatformIdle
    {
        object get_lock = new object();
        IntPtr display;

        public X11PlatformIdle(WindowInfo info)
        {
            display = new OpenTK.Platform.X11.WindowInfo(info).Display;//((OpenTK.Platform.X11.WindowInfo)info).Display;
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
#endif

    #endregion

    #region internal interface IGLControlHelper

    internal interface IGLControlHelper
    {
        IWindowInfo WindowInfo { get; }
        bool IsIdle { get; }
    }

    #endregion
}
