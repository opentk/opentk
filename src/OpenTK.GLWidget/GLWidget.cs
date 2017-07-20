using System;
using System.Threading;
using System.ComponentModel;

using OpenTK.Graphics;
using OpenTK.Platform;

using Gtk;
using OpenTK.OSX;
using OpenTK.Win;
using OpenTK.X11;

namespace OpenTK
{
    /// <summary>
    /// The <see cref="GLWidget"/> is a GTK widget for which an OpenGL context can be used to draw arbitrary graphics.
    /// </summary>
    [ToolboxItem(true)]
    public class GLWidget: DrawingArea
    {

        private static int _GraphicsContextCount;
        private static bool _SharedContextInitialized = false;

        private IGraphicsContext _GraphicsContext;
        private IWindowInfo _WindowInfo;
        private bool _Initialized = false;

        /// <summary>
        /// Use a single buffer versus a double buffer.
        /// </summary>
        [Browsable(true)]
        public bool SingleBuffer { get; set; }

        /// <summary>
        /// Color Buffer Bits-Per-Pixel
        /// </summary>
        public int ColorBPP { get; set; }

        /// <summary>
        /// Accumulation Buffer Bits-Per-Pixel
        /// </summary>
        public int AccumulatorBPP { get; set; }

        /// <summary>
        /// Depth Buffer Bits-Per-Pixel
        /// </summary>
        public int DepthBPP { get; set; }

        /// <summary>
        /// Stencil Buffer Bits-Per-Pixel
        /// </summary>
        public int StencilBPP { get; set; }

        /// <summary>
        /// Number of samples
        /// </summary>
        public int Samples { get; set; }

        /// <summary>
        /// Indicates if steropic renderering is enabled
        /// </summary>
        public bool Stereo { get; set; }

        /// <summary>
        /// The major version of OpenGL to use.
        /// </summary>
        public int GlVersionMajor { get; set; }

        /// <summary>
        /// The minor version of OpenGL to use.
        /// </summary>
        public int GlVersionMinor { get; set; }

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

            SingleBuffer = graphicsMode.Buffers == 1;
            ColorBPP = graphicsMode.ColorFormat.BitsPerPixel;
            AccumulatorBPP = graphicsMode.AccumulatorFormat.BitsPerPixel;
            DepthBPP = graphicsMode.Depth;
            StencilBPP = graphicsMode.Stencil;
            Samples = graphicsMode.Samples;
            Stereo = graphicsMode.Stereo;

            GlVersionMajor = glVersionMajor;
            GlVersionMinor = glVersionMinor;
            GraphicsContextFlags = graphicsContextFlags;
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
        /// Called when this <see cref="GLWidget"/> needs to render a frame.
        /// </summary>
        public event EventHandler RenderFrame;

        /// <summary>
        /// Invokes the <see cref="RenderFrame"/> event.
        /// </summary>
        protected virtual void OnRenderFrame()
        {
            if (RenderFrame != null)
            {
                RenderFrame(this, EventArgs.Empty);
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
            else
            {
                _GraphicsContext.MakeCurrent(_WindowInfo);
            }

#if GTK3
            var result = base.OnDrawn(cr);
#else
            bool result = base.OnExposeEvent(evnt);
#endif

            OnRenderFrame();

#if !GTK3
            evnt.Window.Display.Sync(); // Add Sync call to fix resize rendering problem (Jay L. T. Cornwall) - How does this affect VSync?
#endif

            _GraphicsContext.SwapBuffers();

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

            // If this looks uninitialized...  initialize.
            if (ColorBPP == 0)
            {
                ColorBPP = 32;

                if (DepthBPP == 0)
                {
                    DepthBPP = 16;
                }
            }

            ColorFormat colorBufferColorFormat = new ColorFormat(ColorBPP);

            ColorFormat accumulationColorFormat = new ColorFormat(AccumulatorBPP);

            int buffers = 2;
            if (SingleBuffer)
            {
                buffers--;
            }

            GraphicsMode graphicsMode = new GraphicsMode(colorBufferColorFormat, DepthBPP, StencilBPP, Samples, accumulationColorFormat, buffers, Stereo);

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
                _WindowInfo = XWindowInfoInitializer.Initialize(graphicsMode, this.Display.Handle, this.Screen.Number, widgetWindowHandle, this.Screen.RootWindow.Handle);
            }

            // GraphicsContext
            _GraphicsContext = new GraphicsContext(graphicsMode, _WindowInfo, GlVersionMajor, GlVersionMinor, GraphicsContextFlags);
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
