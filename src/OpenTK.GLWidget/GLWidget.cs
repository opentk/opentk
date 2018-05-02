using System;
using System.ComponentModel;
using System.Threading;
using Cairo;
using Gdk;
using Gtk;
using OpenTK.Core;
using OpenTK.Graphics;

namespace OpenTK
{
    /// <summary>
    /// The <see cref="GLWidget" /> is a GTK widget for which an OpenGL context can be used to draw arbitrary graphics.
    /// </summary>
    [ToolboxItem(true)]
    public class GLWidget : GLArea
    {
        private static int _GraphicsContextCount;
        private static bool _SharedContextInitialized;

        private IGraphicsContext _GraphicsContext;
        private bool _Initialized;

        /// <summary>
        /// The previous frame time reported by GTK.
        /// </summary>
        private double? _PreviousFrameTime;

        /// <summary>
        /// Initializes a new instance of the <see cref="GLWidget" /> class.
        /// </summary>
        public GLWidget()
            : this(GraphicsMode.Default)
        {
        }

        /// <summary>
        /// Constructs a new GLWidget using a given GraphicsMode
        /// </summary>
        public GLWidget(GraphicsMode graphicsMode)
            : this(graphicsMode, 1, 0, GraphicsContextFlags.Default)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLWidget" /> class.
        /// </summary>
        /// <param name="graphicsMode">The <see cref="GraphicsMode" /> which the widget should be constructed with.</param>
        /// <param name="glVersionMajor">The major OpenGL version to attempt to initialize.</param>
        /// <param name="glVersionMinor">The minor OpenGL version to attempt to initialize.</param>
        /// <param name="contextFlags">
        /// Any flags which should be used during initialization of the <see cref="GraphicsContext" />.
        /// </param>
        public GLWidget(GraphicsMode graphicsMode, int glVersionMajor, int glVersionMinor,
            GraphicsContextFlags contextFlags)
        {
            ContextFlags = contextFlags;

            AddTickCallback(UpdateFrameTime);
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
        /// Gets the time taken to render the last frame (in seconds).
        /// </summary>
        public double DeltaTime { get; private set; }

        /// <summary>
        /// The set <see cref="ContextFlags" /> for this widget.
        /// </summary>
        public GraphicsContextFlags ContextFlags { get; }

        /// <summary>
        /// Updates the time delta with a new value from the last frame.
        /// </summary>
        /// <param name="widget">The sending widget.</param>
        /// <param name="frameClock">The relevant frame clock.</param>
        /// <returns>true if the callback should be called again; otherwise, false.</returns>
        private bool UpdateFrameTime(Widget widget, FrameClock frameClock)
        {
            var frameTimeµSeconds = frameClock.FrameTime;

            if (!_PreviousFrameTime.HasValue)
            {
                _PreviousFrameTime = frameTimeµSeconds;

                return true;
            }

            var frameTimeSeconds = (frameTimeµSeconds - _PreviousFrameTime) / 10e6;

            DeltaTime = (float)frameTimeSeconds;
            _PreviousFrameTime = frameTimeµSeconds;

            return true;
        }


        /// <inheritdoc />
        protected override GLContext OnCreateContext()
        {
            var gdkGLContext = Window.CreateGlContext();

            GetRequiredVersion(out var major, out var minor);
            gdkGLContext.SetRequiredVersion(major, minor);

            gdkGLContext.DebugEnabled = ContextFlags.HasFlag(GraphicsContextFlags.Debug);
            gdkGLContext.ForwardCompatible = ContextFlags.HasFlag(GraphicsContextFlags.ForwardCompatible);

            gdkGLContext.Realize();
            return gdkGLContext;
        }

        /// <summary>
        /// Destructs this object.
        /// </summary>
        ~GLWidget()
        {
            Dispose(false);
        }

        /// <summary>
        /// Destroys this <see cref="Widget" />, disposing it and destroying it in the context of GTK.
        /// </summary>
        public override void Destroy()
        {
            GC.SuppressFinalize(this);
            Dispose(true);

            base.Destroy();
        }

        /// <summary>
        /// Disposes the current object, releasing any native resources it was using.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                MakeCurrent();
                OnShuttingDown();
                if (GraphicsContext.ShareContexts && Interlocked.Decrement(ref _GraphicsContextCount) == 0)
                {
                    OnGraphicsContextShuttingDown();
                    _SharedContextInitialized = false;
                }

                _GraphicsContext.Dispose();
            }
        }

        /// <summary>
        /// Called when the first <see cref="GraphicsContext" /> is created in the case where
        /// GraphicsContext.ShareContexts == true;
        /// </summary>
        public static event EventHandler GraphicsContextInitialized;

        /// <summary>
        /// Invokes the <see cref="GraphicsContextInitialized" /> event.
        /// </summary>
        private static void OnGraphicsContextInitialized()
        {
            if (GraphicsContextInitialized != null)
            {
                GraphicsContextInitialized(null, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Called when the first <see cref="GraphicsContext" /> is being destroyed in the case where
        /// GraphicsContext.ShareContext == true;
        /// </summary>
        public static event EventHandler GraphicsContextShuttingDown;

        /// <summary>
        /// Invokes the <see cref="GraphicsContextShuttingDown" /> event.
        /// </summary>
        private static void OnGraphicsContextShuttingDown()
        {
            if (GraphicsContextShuttingDown != null)
            {
                GraphicsContextShuttingDown(null, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Called when this <see cref="GLWidget" /> has finished initializing and has a valid
        ///  <see cref="GraphicsContext" />.
        /// </summary>
        public event EventHandler Initialized;

        /// <summary>
        /// Invokes the <see cref="Initialized" /> event.
        /// </summary>
        protected virtual void OnInitialized()
        {
            if (Initialized != null)
            {
                Initialized(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Called when this <see cref="GLWidget" /> is being disposed.
        /// </summary>
        public event EventHandler ShuttingDown;

        /// <summary>
        /// Invokes the <see cref="ShuttingDown" /> event.
        /// </summary>
        protected virtual void OnShuttingDown()
        {
            if (ShuttingDown != null)
            {
                ShuttingDown(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Called when the widget needs to be (fully or partially) redrawn.
        /// </summary>
        /// <param name="cr"></param>
        /// <returns></returns>
        protected override bool OnDrawn(Context cr)
        {
            if (!_Initialized)
            {
                Initialize();
            }

            var result = base.OnDrawn(cr);
            return result;
        }

        /// <summary>
        /// Initializes the <see cref="GLWidget" /> with its given values and creates a <see cref="GraphicsContext" />.
        /// </summary>
        private void Initialize()
        {
            _Initialized = true;

            // Make the GDK GL context current
            MakeCurrent();

            // Create a dummy context that will grab the GdkGLContext that is current on the thread
            _GraphicsContext = new GraphicsContext(ContextHandle.Zero, null);

            if (ContextFlags.HasFlag(GraphicsContextFlags.Debug))
            {
                _GraphicsContext.ErrorChecking = true;
            }

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
