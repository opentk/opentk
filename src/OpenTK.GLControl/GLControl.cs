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

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

using OpenTK.Platform;
using OpenTK.Graphics;

namespace OpenTK
{
    /// <summary>
    /// OpenGL-aware WinForms control.
    /// The WinForms designer will always call the default constructor.
    /// Inherit from this class and call one of its specialized constructors
    /// to enable antialiasing or custom <see cref="GraphicsMode"/>s.
    /// </summary>
    public partial class GLControl : UserControl
    {
        private IGraphicsContext _context;
        private IGLControl _implementation;
        private readonly GraphicsMode _format;
        private readonly int _major;
        private readonly int _minor;
        private readonly GraphicsContextFlags _flags;
        private bool? _initialVsyncValue;

        // Indicates that OnResize was called before OnHandleCreated.
        // To avoid issues with missing OpenGL contexts, we suppress
        // the premature Resize event and raise it as soon as the handle
        // is ready.
        private bool _resizeEventSuppressed;

        // Indicates whether the control is in design mode. Due to issues
        // with the DesignMode property and nested controls,we need to
        // evaluate this in the constructor.
        private readonly bool _designMode;

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GLControl()
            : this(GraphicsMode.Default)
        { }

        /// <summary>
        /// Constructs a new instance with the specified GraphicsMode.
        /// </summary>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the control.</param>
        public GLControl(GraphicsMode mode)
            : this(mode, 1, 0, GraphicsContextFlags.Default)
        { }

        /// <summary>
        /// Constructs a new instance with the specified GraphicsMode.
        /// </summary>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the control.</param>
        /// <param name="major">The major version for the OpenGL GraphicsContext.</param>
        /// <param name="minor">The minor version for the OpenGL GraphicsContext.</param>
        /// <param name="flags">The GraphicsContextFlags for the OpenGL GraphicsContext.</param>
        public GLControl(GraphicsMode mode, int major, int minor, GraphicsContextFlags flags)
        {
            if (mode == null)
            {
                throw new ArgumentNullException(nameof(mode));
            }

            // SDL does not currently support embedding
            // on external windows. If Open.Toolkit is not yet
            // initialized, we'll try to request a native backend
            // that supports embedding.
            // Most people are using GLControl through the
            // WinForms designer in Visual Studio. This approach
            // works perfectly in that case.
            Toolkit.Init(new ToolkitOptions
            {
                Backend = PlatformBackend.PreferNative
            });

            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            DoubleBuffered = false;

            _format = mode;
            _major = major;
            _minor = minor;
            _flags = flags;

            // Note: the DesignMode property may be incorrect when nesting controls.
            // We use LicenseManager.UsageMode as a workaround (this only works in
            // the constructor).
            _designMode =
                DesignMode ||
                LicenseManager.UsageMode == LicenseUsageMode.Designtime;

            InitializeComponent();
        }

        /// <summary>
        /// Gets a value indicating whether [failed to create OpenGL context].
        /// So that the application stays running and is able to recover.
        /// </summary>
        /// <value>
        /// <c>true</c> if [failed create context]; otherwise, <c>false</c>.
        /// </value>
        public bool HasValidContext { get; private set; }

        private IGLControl Implementation
        {
            get
            {
                ValidateState();

                return _implementation;
            }
        }

        [Conditional("DEBUG")]
        private void ValidateContext(string message)
        {
            if (!Context.IsCurrent)
            {
                Debug.Print("[GLControl] Attempted to access {0} on a non-current context. Results undefined.", message);
            }
        }

        private void ValidateState()
        {
            if (IsDisposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }

            if (!IsHandleCreated)
            {
                CreateControl();
            }

            if (_implementation == null || _context == null || _context.IsDisposed)
            {
                RecreateHandle();
            }
        }

        /// <summary>
        /// Gets the <c>CreateParams</c> instance for this <c>GLControl</c>
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_VREDRAW = 0x1;
                const int CS_HREDRAW = 0x2;
                const int CS_OWNDC = 0x20;

                var cp = base.CreateParams;
                if (Configuration.RunningOnWindows)
                {
                    // Setup necessary class style for OpenGL on windows
                    cp.ClassStyle |= CS_VREDRAW | CS_HREDRAW | CS_OWNDC;
                }
                return cp;
            }
        }

        /// <summary>Raises the HandleCreated event.</summary>
        /// <param name="e">Not used.</param>
        protected override void OnHandleCreated(EventArgs e)
        {
            if (!(_implementation is DummyGLControl))
            { // No need to recreate our DummyGLControl
                _context?.Dispose();
                _implementation?.WindowInfo.Dispose();

                if (_designMode)
                {
                    _implementation = new DummyGLControl();
                    _context = _implementation.CreateContext(_major, _minor, _flags);
                    HasValidContext = false;
                }
                else
                {
                    try
                    {
                        _implementation = new GLControlFactory().CreateGLControl(_format, this);
                        _context = _implementation.CreateContext(_major, _minor, _flags);
                        HasValidContext = true;
                    }
                    catch (GraphicsModeException)
                    {
                        _implementation = new DummyGLControl();
                        _context = _implementation.CreateContext(_major, _minor, _flags);
                        HasValidContext = false;
                    }
                }

                MakeCurrent();

                if (HasValidContext)
                {
                    ((IGraphicsContextInternal)_context).LoadAll();
                }

                // Deferred setting of vsync mode. See VSync property for more information.
                if (_initialVsyncValue.HasValue)
                {
                    _context.SwapInterval = _initialVsyncValue.Value ? 1 : 0;
                    _initialVsyncValue = null;
                }
            }

            base.OnHandleCreated(e);

            if (_resizeEventSuppressed)
            {
                OnResize(EventArgs.Empty);
                _resizeEventSuppressed = false;
            }
        }

        /// <summary>Raises the HandleDestroyed event.</summary>
        /// <param name="e">Not used.</param>
        protected override void OnHandleDestroyed(EventArgs e)
        {
            // Ensure that context is still alive when passing to events
            // => This allows to perform cleanup operations in OnHandleDestroyed handlers
            base.OnHandleDestroyed(e);

            if (_implementation is DummyGLControl)
            {
                // No need to destroy our DummyGLControl
                return;
            }

            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }

            if (_implementation != null)
            {
                _implementation.WindowInfo.Dispose();
                _implementation = null;
            }
        }

        /// <summary>
        /// Raises the System.Windows.Forms.Control.Paint event.
        /// </summary>
        /// <param name="e">A System.Windows.Forms.PaintEventArgs that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            ValidateState();

            if (_designMode)
            {
                e.Graphics.Clear(BackColor);
            }

            base.OnPaint(e);
        }

        /// <summary>
        /// Raises the Resize event.
        /// Note: this method may be called before the OpenGL context is ready.
        /// Check that IsHandleCreated is true before using any OpenGL methods.
        /// </summary>
        /// <param name="e">A System.EventArgs that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {
            // Do not raise OnResize event before the handle and context are created.
            if (!IsHandleCreated)
            {
                _resizeEventSuppressed = true;
                return;
            }

            if (Configuration.RunningOnMacOS)
            {
                DelayUpdate delay = PerformContextUpdate;
                BeginInvoke(delay); //Need the native window to resize first otherwise our control will be in the wrong place.
            }
            else
            {
                _context?.Update(Implementation.WindowInfo);
            }

            base.OnResize(e);
        }

        /// <summary>
        /// Needed to delay the invoke on OS X. Also needed because OpenTK is .NET 2, otherwise I'd use an inline Action.
        /// </summary>
        public delegate void DelayUpdate();

        /// <summary>
        /// Execute the delayed context update
        /// </summary>
        public void PerformContextUpdate()
        {
            _context?.Update(Implementation.WindowInfo);
        }

        /// <summary>
        /// Raises the ParentChanged event.
        /// </summary>
        /// <param name="e">A System.EventArgs that contains the event data.</param>
        protected override void OnParentChanged(EventArgs e)
        {
            _context?.Update(Implementation.WindowInfo);

            base.OnParentChanged(e);
        }

        /// <summary>
        /// Swaps the front and back buffers, presenting the rendered scene to the screen.
        /// This method will have no effect on a single-buffered <c>GraphicsMode</c>.
        /// </summary>
        public void SwapBuffers()
        {
            ValidateState();
            Context.SwapBuffers();
        }

        /// <summary>
        /// <para>
        /// Makes <see cref="GLControl.Context"/> current in the calling thread.
        /// All OpenGL commands issued are hereafter interpreted by this context.
        /// </para>
        /// <para>
        /// When using multiple <c>GLControl</c>s, calling <c>MakeCurrent</c> on
        /// one control will make all other controls non-current in the calling thread.
        /// </para>
        /// <seealso cref="Context"/>
        /// <para>
        /// A <c>GLControl</c> can only be current in one thread at a time.
        /// To make a control non-current, call <c>GLControl.Context.MakeCurrent(null)</c>.
        /// </para>
        /// </summary>
        public void MakeCurrent()
        {
            ValidateState();
            Context.MakeCurrent(Implementation.WindowInfo);
        }

        /// <summary>
        /// Gets a value indicating whether the current thread contains pending system messages.
        /// </summary>
        [Browsable(false)]
        public bool IsIdle
        {
            get
            {
                ValidateState();
                return Implementation.IsIdle;
            }
        }

        /// <summary>
        /// Gets the <c>IGraphicsContext</c> instance that is associated with the <c>GLControl</c>.
        /// The associated <c>IGraphicsContext</c> is updated whenever the <c>GLControl</c>
        /// handle is created or recreated.
        /// When using multiple <c>GLControl</c>s, ensure that <c>Context</c>
        /// is current before performing any OpenGL operations.
        /// <seealso cref="MakeCurrent"/>
        /// </summary>
        [Browsable(false)]
        public IGraphicsContext Context
        {
            get
            {
                ValidateState();
                return _context;
            }
        }

        /// <summary>
        /// Gets the aspect ratio of this GLControl.
        /// </summary>
        [Description("The aspect ratio of the client area of this GLControl.")]
        public float AspectRatio
        {
            get
            {
                ValidateState();
                return ClientSize.Width / (float)ClientSize.Height;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether vsync is active for this <c>GLControl</c>.
        /// When using multiple <c>GLControl</c>s, ensure that <see cref="Context"/>
        /// is current before accessing this property.
        /// <seealso cref="Context"/>
        /// <seealso cref="MakeCurrent"/>
        /// </summary>
        [Description("Indicates whether GLControl updates are synced to the monitor's refresh rate.")]
        public bool VSync
        {
            get
            {
                if (!IsHandleCreated)
                {
                    return !_initialVsyncValue.HasValue || _initialVsyncValue.Value;
                }

                ValidateState();
                ValidateContext(@"VSync");

                return Context.SwapInterval != 0;
            }
            set
            {
                // The winforms designer sets this to false by default which forces control creation.
                // However, events are typically connected after the VSync = false assignment, which
                // can lead to "event xyz is not fired" issues.
                // Work around this issue by deferring VSync mode setting to the HandleCreated event.
                if (!IsHandleCreated)
                {
                    _initialVsyncValue = value;
                    return;
                }

                ValidateState();
                ValidateContext(@"VSync");
                Context.SwapInterval = value ? 1 : 0;
            }
        }

        /// <summary>
        /// Gets the <c>GraphicsMode</c> of the <c>IGraphicsContext</c> associated with
        /// this <c>GLControl</c>. If you wish to change <c>GraphicsMode</c>, you must
        /// destroy and recreate the <c>GLControl</c>.
        /// </summary>
        public GraphicsMode GraphicsMode
        {
            get
            {
                ValidateState();
                return Context.GraphicsMode;
            }
        }

        /// <summary>
        /// Gets the <see cref="OpenTK.Platform.IWindowInfo"/> for this instance.
        /// </summary>
        public IWindowInfo WindowInfo => _implementation.WindowInfo;
    }
}
