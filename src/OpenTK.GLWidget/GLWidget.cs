using System;
using System.Threading;
using System.ComponentModel;
using Gdk;
using OpenTK.Graphics;
using OpenTK.Platform;

using Gtk;
using OpenTK.OSX;
using OpenTK.Platform.X11;
using OpenTK.Win;
using OpenTK.X11;

namespace OpenTK
{
    /// <summary>
    /// The <see cref="GLWidget"/> is a GTK widget for which an OpenGL context can be used to draw arbitrary graphics.
    /// </summary>
    [CLSCompliant(false)]
    [ToolboxItem(true)]
    public class GLWidget: GLArea
    {

        private static int _GraphicsContextCount;
        private static bool _SharedContextInitialized = false;

        private IGraphicsContext _GraphicsContext;
        private IWindowInfo _WindowInfo;
        private bool _Initialized = false;

        /// <summary>
        /// The set <see cref="GraphicsContextFlags"/> for this widget.
        /// </summary>
        public GraphicsContextFlags GraphicsContextFlags { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLWidget"/> class.
        /// </summary>
        public GLWidget()
            : this(GraphicsMode.Default)
        {
        }

        /// <summary>Constructs a new GLWidget using a given GraphicsMode</summary>
        public GLWidget(GraphicsMode graphicsMode)
            : this(graphicsMode, 1, 0, GraphicsContextFlags.Default)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLWidget"/> class.
        /// </summary>
        /// <param name="graphicsMode">The <see cref="GraphicsMode"/> which the widget should be constructed with.</param>
        /// <param name="glVersionMajor">The major OpenGL version to attempt to initialize.</param>
        /// <param name="glVersionMinor">The minor OpenGL version to attempt to initialize.</param>
        /// <param name="graphicsContextFlags">
        /// Any flags which should be used during initialization of the <see cref="GraphicsContext"/>.
        /// </param>
        public GLWidget(GraphicsMode graphicsMode, int glVersionMajor, int glVersionMinor, GraphicsContextFlags graphicsContextFlags)
        {
            this.DoubleBuffered = false;

            GraphicsContextFlags = graphicsContextFlags;

            SetRequiredVersion(glVersionMajor, glVersionMinor);

            if (graphicsMode.Depth > 0)
            {
                HasDepthBuffer = true;
            }

            if (graphicsMode.Stencil > 0)
            {
                HasStencilBuffer = true;
            }

            if (graphicsMode.ColorFormat.Alpha > 0)
            {
                HasAlpha = true;
            }
        }

        /// <summary>
        /// Destructs this object.
        /// </summary>
        ~GLWidget()
        {
            Dispose(false);
        }

        /// <summary>
        /// Destroys this <see cref="Widget"/>, disposing it and destroying it in the context of GTK.
        /// </summary>
        public override void Destroy()
        {
            GC.SuppressFinalize(this);
            Dispose(true);

            base.Destroy();
        }

#if !GTK3
        /// <summary>
        /// Disposes the current object, releasing any native resources it was using.
        /// </summary>
        /// <param name="disposing"></param>
        public override void Dispose()
        {
            GC.SuppressFinalize(this);
            Dispose(true);

            base.Dispose();
        }
#endif

#if GTK3
        /// <summary>
        /// Disposes the current object, releasing any native resources it was using.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
#else
        /// <summary>
        /// Disposes the current object, releasing any native resources it was using.
        /// </summary>
        /// <param name="disposing"></param>
        public virtual void Dispose(bool disposing)
        {
#endif
            if (disposing)
            {
                _GraphicsContext.MakeCurrent(_WindowInfo);
                OnShuttingDown();
                if (GraphicsContext.ShareContexts && (Interlocked.Decrement(ref _GraphicsContextCount) == 0))
                {
                    OnGraphicsContextShuttingDown();
                    _SharedContextInitialized = false;
                }
                _GraphicsContext.Dispose();
            }
        }

        /// <summary>
        /// Called when the first <see cref="GraphicsContext"/> is created in the case where
        /// GraphicsContext.ShareContexts == true;
        /// </summary>
        public static event EventHandler GraphicsContextInitialized;

        /// <summary>
        /// Invokes the <see cref="GraphicsContextInitialized"/> event.
        /// </summary>
        private static void OnGraphicsContextInitialized()
        {
            if (GraphicsContextInitialized != null)
            {
                GraphicsContextInitialized(null, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Called when the first <see cref="GraphicsContext"/> is being destroyed in the case where
        /// GraphicsContext.ShareContext == true;
        /// </summary>
        public static event EventHandler GraphicsContextShuttingDown;

        /// <summary>
        /// Invokes the <see cref="GraphicsContextShuttingDown"/> event.
        /// </summary>
        private static void OnGraphicsContextShuttingDown()
        {
            if (GraphicsContextShuttingDown != null)
            {
                GraphicsContextShuttingDown(null, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Called when this <see cref="GLWidget"/> has finished initializing and has a valid
        /// <see cref="GraphicsContext"/>.
        /// </summary>
        public event EventHandler Initialized;

        /// <summary>
        /// Invokes the <see cref="Initialized"/> event.
        /// </summary>
        protected virtual void OnInitialized()
        {
            if (Initialized != null)
            {
                Initialized(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Called when this <see cref="GLWidget"/> is being disposed.
        /// </summary>
        public event EventHandler ShuttingDown;

        /// <summary>
        /// Invokes the <see cref="ShuttingDown"/> event.
        /// </summary>
        protected virtual void OnShuttingDown()
        {
            if (ShuttingDown != null)
            {
                ShuttingDown(this, EventArgs.Empty);
            }
        }

#if GTK3
        /// <summary>
        /// Called when the widget needs to be (fully or partially) redrawn.
        /// </summary>
        /// <param name="cr"></param>
        /// <returns></returns>
        protected override bool OnDrawn(Cairo.Context cr)
#else
        /// <summary>
        /// Called when the widget is exposed.
        /// </summary>
        /// <param name="cr"></param>
        /// <returns></returns>
        protected override bool OnExposeEvent(Gdk.EventExpose evnt)
#endif
        {
            if (!_Initialized)
            {
                Initialize();
            }
#if GTK3
            var result = base.OnDrawn(cr);
#else
            bool result = base.OnExposeEvent(evnt);
#endif
#if !GTK3
            evnt.Window.Display.Sync(); // Add Sync call to fix resize rendering problem (Jay L. T. Cornwall) - How does this affect VSync?
#endif
            return result;
        }

        /// <summary>
        /// Called whenever the widget is resized.
        /// </summary>
        /// <param name="evnt"></param>
        /// <returns></returns>
        protected override bool OnConfigureEvent(Gdk.EventConfigure evnt)
        {
            bool result = base.OnConfigureEvent(evnt);

            if (_GraphicsContext != null)
            {
                _GraphicsContext.Update(_WindowInfo);
            }

            return result;
        }

        /// <summary>
        /// Initializes the <see cref="GLWidget"/> with its given values and creates a <see cref="GraphicsContext"/>.
        /// </summary>
        private void Initialize()
        {
            _Initialized = true;

            if (Configuration.RunningOnWindows)
            {
                Console.WriteLine("OpenTK running on windows");
            }
            else if (Configuration.RunningOnMacOS)
            {
                Console.WriteLine("OpenTK running on OSX");
            }
            else
            {
                Console.WriteLine("OpenTK running on X11");
            }

#if GTK3
            IntPtr widgetWindowHandle = this.Window.Handle;
#else
            IntPtr widgetWindowHandle = this.GdkWindow.Handle;
#endif

            // IWindowInfo
            if (Configuration.RunningOnWindows)
            {
                _WindowInfo = WinWindowsInfoInitializer.Initialize(widgetWindowHandle);
            }
            else if (Configuration.RunningOnMacOS)
            {
                _WindowInfo = OSXWindowInfoInitializer.Initialize(widgetWindowHandle);
            }
            else
            {
                _WindowInfo = XWindowInfoInitializer.Initialize(this.Display.Handle, this.Screen.Number, widgetWindowHandle, this.Screen.RootWindow.Handle);
            }

            // Make the GDK GL context current
            Context.MakeCurrent();

            // Create an OpenTK graphics context using the GdkGLContext as a foreign context
            // Since the GDK context is already created and has been made current, we can retrieve its handle.
            var gdkContextHandle = Factory.Default.CreateGetCurrentGraphicsContext()();

            GetRequiredVersion(out int glVersionMajor, out int glVersionMinor);
            _GraphicsContext = new GraphicsContext(gdkContextHandle, _WindowInfo, null, glVersionMajor, glVersionMinor, GraphicsContextFlags);
            _GraphicsContext.MakeCurrent(_WindowInfo);

            if (GraphicsContext.ShareContexts)
            {
                Interlocked.Increment(ref _GraphicsContextCount);

                if (!_SharedContextInitialized)
                {
                    _SharedContextInitialized = true;
                    ((IGraphicsContextInternal)_GraphicsContext).LoadAll();
                    OnGraphicsContextInitialized();
                }
            }
            else
            {
                ((IGraphicsContextInternal)_GraphicsContext).LoadAll();
                OnGraphicsContextInitialized();
            }

            OnInitialized();
        }
    }
}
