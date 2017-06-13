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
    [ToolboxItem(true)]
    public class GLWidget: DrawingArea
    {

        #region Static attrs.

        static int _GraphicsContextCount;
        static bool _SharedContextInitialized = false;

        #endregion

        #region Attributes

        IGraphicsContext _GraphicsContext;
        IWindowInfo _WindowInfo;
        GraphicsContextFlags _GraphicsContextFlags;
        bool _Initialized = false;

        #endregion

        #region Properties

        /// <summary>Use a single buffer versus a double buffer.</summary>
        [Browsable(true)]
        public bool SingleBuffer { get; set; }

        /// <summary>Color Buffer Bits-Per-Pixel</summary>
        public int ColorBPP { get; set; }

        /// <summary>Accumulation Buffer Bits-Per-Pixel</summary>
        public int AccumulatorBPP { get; set; }

        /// <summary>Depth Buffer Bits-Per-Pixel</summary>
        public int DepthBPP { get; set; }

        /// <summary>Stencil Buffer Bits-Per-Pixel</summary>
        public int StencilBPP { get; set; }

        /// <summary>Number of samples</summary>
        public int Samples { get; set; }

        /// <summary>Indicates if steropic renderering is enabled</summary>
        public bool Stereo { get; set; }

        /// <summary>The major version of OpenGL to use.</summary>
        public int GlVersionMajor { get; set; }

        /// <summary>The minor version of OpenGL to use.</summary>
        public int GlVersionMinor { get; set; }

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

        /// <summary>Constructs a new GLWidget.</summary>
        public GLWidget()
            : this(GraphicsMode.Default)
        {
        }

        /// <summary>Constructs a new GLWidget using a given GraphicsMode</summary>
        public GLWidget(GraphicsMode graphicsMode)
            : this(graphicsMode, 1, 0, GraphicsContextFlags.Default)
        {
        }

        /// <summary>Constructs a new GLWidget</summary>
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

        ~GLWidget()
        {
            Dispose(false);
        }

#if GTK3
        public override void Destroy() {
#else
        public override void Dispose()
        {
#endif
            GC.SuppressFinalize(this);
            Dispose(true);
#if GTK3
            base.Destroy();
#else
            base.Dispose();
#endif
        }

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

        // Called when the first GraphicsContext is created in the case of GraphicsContext.ShareContexts == True;
        public static event EventHandler GraphicsContextInitialized;

        static void OnGraphicsContextInitialized()
        {
            if (GraphicsContextInitialized != null)
                GraphicsContextInitialized(null, EventArgs.Empty);
        }

        // Called when the first GraphicsContext is being destroyed in the case of GraphicsContext.ShareContexts == True;
        public static event EventHandler GraphicsContextShuttingDown;

        static void OnGraphicsContextShuttingDown()
        {
            if (GraphicsContextShuttingDown != null)
                GraphicsContextShuttingDown(null, EventArgs.Empty);
        }

        // Called when this GLWidget has a valid GraphicsContext
        public event EventHandler Initialized;

        protected virtual void OnInitialized()
        {
            if (Initialized != null)
                Initialized(this, EventArgs.Empty);
        }

        // Called when this GLWidget needs to render a frame
        public event EventHandler RenderFrame;

        protected virtual void OnRenderFrame()
        {
            if (RenderFrame != null)
                RenderFrame(this, EventArgs.Empty);
        }

        // Called when this GLWidget is being Disposed
        public event EventHandler ShuttingDown;

        protected virtual void OnShuttingDown()
        {
            if (ShuttingDown != null)
                ShuttingDown(this, EventArgs.Empty);
        }

        #endregion

        // Called when a widget is realized. (window handles and such are valid)
        // protected override void OnRealized() { base.OnRealized(); }

        // Called when the widget needs to be (fully or partially) redrawn.
#if GTK3
        protected override bool OnDrawn(Cairo.Context cr)
#else
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

        // Called on Resize
        protected override bool OnConfigureEvent(Gdk.EventConfigure evnt)
        {
            bool result = base.OnConfigureEvent(evnt);

            if (_GraphicsContext != null)
                _GraphicsContext.Update(_WindowInfo);

            return result;
        }

        void Initialize()
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