// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Diagnostics;
using OpenTK.Graphics;

namespace OpenTK.Platform.Egl
{
    abstract class EglContext : EmbeddedGraphicsContext
    {
        #region Fields

        protected readonly RenderableFlags Renderable;
        protected EglWindowInfo WindowInfo;

        IntPtr HandleAsEGLContext { get { return Handle.Handle; } set { Handle = new ContextHandle(value); } }
        int swap_interval = 1; // Default interval is defined as 1 in EGL.

        #endregion

        #region Constructors

        public EglContext(GraphicsMode mode, EglWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
        {
            if (mode == null)
                throw new ArgumentNullException("mode");
            if (window == null)
                throw new ArgumentNullException("window");

            EglContext shared = (EglContext)sharedContext;

            WindowInfo = window;

            // Select an EGLConfig that matches the desired mode. We cannot use the 'mode'
            // parameter directly, since it may have originated on a different system (e.g. GLX)
            // and it may not support the desired renderer.

            Renderable = RenderableFlags.GL;
            if ((flags & GraphicsContextFlags.Embedded) != 0)
            {
                switch (major)
                {
                    case 3:
                        Renderable = RenderableFlags.ES3;
                        break;
                    case 2:
                        Renderable = RenderableFlags.ES2;
                        break;
                    default:
                        Renderable = RenderableFlags.ES;
                        break;
                }
            }

            RenderApi api = (Renderable & RenderableFlags.GL) != 0 ? RenderApi.GL : RenderApi.ES;
            Debug.Print("[EGL] Binding {0} rendering API.", api);
            if (!Egl.BindAPI(api))
            {
                Debug.Print("[EGL] Failed to bind rendering API. Error: {0}", Egl.GetError());
            }

            Mode = new EglGraphicsMode().SelectGraphicsMode(window,
                mode.ColorFormat, mode.Depth, mode.Stencil, mode.Samples,
                mode.AccumulatorFormat, mode.Buffers, mode.Stereo,
                Renderable);
            if (!Mode.Index.HasValue)
                throw new GraphicsModeException("Invalid or unsupported GraphicsMode.");
            IntPtr config = Mode.Index.Value;

            if (window.Surface == IntPtr.Zero)
                window.CreateWindowSurface(config);

            int[] attrib_list = new int[] { Egl.CONTEXT_CLIENT_VERSION, major, Egl.NONE };
            HandleAsEGLContext = Egl.CreateContext(window.Display, config, shared != null ? shared.HandleAsEGLContext : IntPtr.Zero, attrib_list);

            MakeCurrent(window);
        }

        public EglContext(ContextHandle handle, EglWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
        {
            if (handle == ContextHandle.Zero)
                throw new ArgumentException("handle");
            if (window == null)
                throw new ArgumentNullException("window");

            Handle = handle;
        }

        #endregion

        #region IGraphicsContext Members

        public override void SwapBuffers()
        {
            Egl.SwapBuffers(WindowInfo.Display, WindowInfo.Surface);
        }

        public override void MakeCurrent(IWindowInfo window)
        {
            // Ignore 'window', unless it actually is an EGL window. In other words,
            // trying to make the EglContext current on a non-EGL window will do,
            // nothing (the EglContext will remain current on the previous EGL window
            // or the window it was constructed on (which may not be EGL)).
            if (window is EglWindowInfo)
                WindowInfo = (EglWindowInfo)window;
            Egl.MakeCurrent(WindowInfo.Display, WindowInfo.Surface, WindowInfo.Surface, HandleAsEGLContext);
        }

        public override bool IsCurrent
        {
            get { return Egl.GetCurrentContext() == HandleAsEGLContext; }
        }

        public override int SwapInterval
        {
            get
            {
                // Egl.GetSwapInterval does not exist, so store and return the current interval.
                // The default interval is defined as 1 (true).
                return swap_interval;
            }
            set
            {
                if (value < 0)
                {
                    // EGL does not offer EXT_swap_control_tear yet
                    value = 1;
                }

                if (Egl.SwapInterval(WindowInfo.Display, value))
                    swap_interval = value;
                else
                    Debug.Print("[Warning] Egl.SwapInterval({0}, {1}) failed. Error: {2}",
                        WindowInfo.Display, value, Egl.GetError());
            }
        }

        #endregion

        #region IGraphicsContextInternal Members

        public override IntPtr GetAddress(IntPtr function)
        {
            // Try loading a static export from ES1 or ES2
            IntPtr address = GetStaticAddress(function, Renderable);

            // If a static export is not available, try retrieving an extension
            // function pointer with eglGetProcAddress
            if (address == IntPtr.Zero)
            {
                address = Egl.GetProcAddress(function);
            }

            return address;
        }

        #endregion

        #region Abstract Members

        protected abstract IntPtr GetStaticAddress(IntPtr function, RenderableFlags renderable);

        #endregion

        #region IDisposable Members

        // Todo: cross-reference the specs. What should happen if the context is destroyed from a different
        // thread?
        protected override void Dispose(bool manual)
        {
            if (!IsDisposed)
            {
                if (manual)
                {
                    Egl.MakeCurrent(WindowInfo.Display, WindowInfo.Surface, WindowInfo.Surface, IntPtr.Zero);
                    Egl.DestroyContext(WindowInfo.Display, HandleAsEGLContext);
                }
                IsDisposed = true;
            }
        }

        #endregion
    }
}
