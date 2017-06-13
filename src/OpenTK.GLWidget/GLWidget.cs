#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

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

        #region Static attrs.

        private static int _GraphicsContextCount;
        private static bool _SharedContextInitialized;

        #endregion

        #region Attributes

        private IGraphicsContext _GraphicsContext;
        private IWindowInfo _WindowInfo;
        private GraphicsContextFlags _GraphicsContextFlags;
        private bool _Initialized;

        #endregion

        #region Properties

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
        public GraphicsContextFlags GraphicsContextFlags
        {
            get
            {
                return _GraphicsContextFlags;
            }
            set
            {
                _GraphicsContextFlags = value;
            }
        }

        #endregion

        #region Construction/Destruction

        /// <summary>
        /// Initializes a new instance of the <see cref="GLWidget"/> class.
        /// </summary>
        public GLWidget()
            : this(GraphicsMode.Default)
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
        public GLWidget(GraphicsMode graphicsMode, int glVersionMajor = 1, int glVersionMinor = 0, GraphicsContextFlags graphicsContextFlags = GraphicsContextFlags.Default)
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

#if GTK3
        /// <summary>
        /// Destroys this <see cref="Widget"/>, disposing it and destroying it in the context of GTK.
        /// </summary>
        public override void Destroy()
#else
        /// <summary>
        /// Disposes the current object, releasing any native resources it was using.
        /// </summary>
        /// <param name="disposing"></param>
        public override void Dispose()
#endif
        {
            GC.SuppressFinalize(this);
            Dispose(true);
#if GTK3
            base.Destroy();
#else
            base.Dispose();
#endif
        }

        /// <summary>
        /// Disposes the current object, releasing any native resources it was using.
        /// </summary>
        /// <param name="disposing"></param>
        public virtual void Dispose(bool disposing)
        {
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

        #endregion

        #region New Events

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
                GraphicsContextInitialized(null, EventArgs.Empty);
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
                GraphicsContextShuttingDown(null, EventArgs.Empty);
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
                Initialized(this, EventArgs.Empty);
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
                RenderFrame(this, EventArgs.Empty);
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
                ShuttingDown(this, EventArgs.Empty);
        }

        #endregion

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
                Initialize();
            else
                _GraphicsContext.MakeCurrent(_WindowInfo);

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
                _GraphicsContext.Update(_WindowInfo);

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
                    DepthBPP = 16;
            }

            ColorFormat colorBufferColorFormat = new ColorFormat(ColorBPP);

            ColorFormat accumulationColorFormat = new ColorFormat(AccumulatorBPP);

            int buffers = 2;
            if (SingleBuffer)
                buffers--;

            GraphicsMode graphicsMode = new GraphicsMode(colorBufferColorFormat, DepthBPP, StencilBPP, Samples, accumulationColorFormat, buffers, Stereo);

            if (Configuration.RunningOnWindows)
                Console.WriteLine("OpenTK running on windows");
            else if (Configuration.RunningOnMacOS)
                Console.WriteLine("OpenTK running on OSX");
            else
                Console.WriteLine("OpenTK running on X11");

            // IWindowInfo
            if (Configuration.RunningOnWindows)
                _WindowInfo = WinWindowsInfoInitializer.Initialize(this.Window.Handle);
            else if (Configuration.RunningOnMacOS)
                _WindowInfo = OSXWindowInfoInitializer.Initialize(this.Window.Handle);
            else
                _WindowInfo = XWindowInfoInitializer.Initialize(graphicsMode, this.Display.Handle, this.Screen.Number, this.Window.Handle, this.RootWindow.Handle);

            // GraphicsContext
            _GraphicsContext = new GraphicsContext(graphicsMode, _WindowInfo, GlVersionMajor, GlVersionMinor, _GraphicsContextFlags);
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