//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
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
using System.Diagnostics;
using OpenToolkit.Core;
using OpenToolkit.Graphics;

namespace OpenToolkit.Platform.Egl
{
    internal abstract class EglContext : EmbeddedGraphicsContext
    {
        protected readonly RenderableFlags Renderable;
        private int swap_interval = 1; // Default interval is defined as 1 in EGL.
        internal EglWindowInfo WindowInfo;

        public EglContext(GraphicsMode mode, EglWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
        {
            if (mode == null)
            {
                throw new ArgumentNullException(nameof(mode));
            }

            if (window == null)
            {
                throw new ArgumentNullException(nameof(window));
            }

            var shared = GetSharedEglContext(sharedContext);

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

            var api = (Renderable & RenderableFlags.GL) != 0 ? RenderApi.GL : RenderApi.ES;
            Debug.Print("[EGL] Binding {0} rendering API.", api);
            if (!Egl.BindAPI(api))
            {
                Debug.Print("[EGL] Failed to bind rendering API. Error: {0}", Egl.GetError());
            }

            var offscreen = (flags & GraphicsContextFlags.Offscreen) != 0;

            var surfaceType = offscreen
                ? SurfaceType.PBUFFER_BIT
                : SurfaceType.WINDOW_BIT;

            Mode = new EglGraphicsMode().SelectGraphicsMode(surfaceType,
                window.Display, mode.ColorFormat, mode.Depth, mode.Stencil,
                mode.Samples, mode.AccumulatorFormat, mode.Buffers, mode.Stereo,
                Renderable);

            if (!Mode.Index.HasValue)
            {
                throw new GraphicsModeException("Invalid or unsupported GraphicsMode.");
            }

            var config = Mode.Index.Value;

            if (window.Surface == IntPtr.Zero)
            {
                if (!offscreen)
                {
                    window.CreateWindowSurface(config);
                }
                else
                {
                    window.CreatePbufferSurface(config);
                }
            }

            int[] attribList = { Egl.CONTEXT_CLIENT_VERSION, major, Egl.NONE };
            var shareContext = shared?.HandleAsEGLContext ?? IntPtr.Zero;
            HandleAsEGLContext = Egl.CreateContext(window.Display, config, shareContext, attribList);

            GraphicsContextFlags = flags;
        }

        public EglContext(ContextHandle handle, EglWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
        {
            if (handle == ContextHandle.Zero)
            {
                throw new ArgumentException("handle");
            }

            if (window == null)
            {
                throw new ArgumentNullException(nameof(window));
            }

            Handle = handle;
        }

        internal GraphicsContextFlags GraphicsContextFlags { get; set; }

        internal IntPtr HandleAsEGLContext
        {
            get => Handle.Handle;
            set => Handle = new ContextHandle(value);
        }

        public override bool IsCurrent => Egl.GetCurrentContext() == HandleAsEGLContext;

        public override int SwapInterval
        {
            get => swap_interval;
            set
            {
                if (value < 0)
                {
                    // EGL does not offer EXT_swap_control_tear yet
                    value = 1;
                }

                if (Egl.SwapInterval(WindowInfo.Display, value))
                {
                    swap_interval = value;
                }
                else
                {
                    Debug.Print("[Warning] Egl.SwapInterval({0}, {1}) failed. Error: {2}",
                        WindowInfo.Display, value, Egl.GetError());
                }
            }
        }

        public override void SwapBuffers()
        {
            if (!Egl.SwapBuffers(WindowInfo.Display, WindowInfo.Surface))
            {
                throw new GraphicsContextException(
                    $"Failed to swap buffers for context {Handle} current. Error: {Egl.GetError()}");
            }
        }

        public override void MakeCurrent(IWindowInfo window)
        {
            // Ignore 'window', unless it actually is an EGL window. In other words,
            // trying to make the EglContext current on a non-EGL window will do,
            // nothing (the EglContext will remain current on the previous EGL window
            // or the window it was constructed on (which may not be EGL)).
            if (window != null)
            {
                if (window is EglWindowInfo)
                {
                    WindowInfo = (EglWindowInfo)window;
                }
#if !ANDROID
                else if (window is IAngleWindowInfoInternal)
                {
                    WindowInfo = ((IAngleWindowInfoInternal)window).EglWindowInfo;
                }
#endif

                if (!Egl.MakeCurrent(WindowInfo.Display, WindowInfo.Surface, WindowInfo.Surface, HandleAsEGLContext))
                {
                    throw new GraphicsContextException(
                        $"Failed to make context {Handle} current. Error: {Egl.GetError()}");
                }
            }
            else
            {
                Egl.MakeCurrent(WindowInfo.Display, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
            }
        }

        public override void Update(IWindowInfo window)
        {
            MakeCurrent(window);
            // ANGLE updates the width and height of the back buffer surfaces in the WaitClient function.
            // So without this calling this function, the surface won't match the size of the window after it
            // was resized.
            // https://bugs.chromium.org/p/angleproject/issues/detail?id=1438
            if (!Egl.WaitClient())
            {
                Debug.Print("[Warning] Egl.WaitClient() failed. Error: {0}", Egl.GetError());
            }
        }

        public override IntPtr GetAddress(IntPtr function)
        {
            // Try loading a static export from ES2
            var address = GetStaticAddress(function, Renderable);

            // If a static export is not available, try retrieving an extension
            // function pointer with eglGetProcAddress
            if (address == IntPtr.Zero)
            {
                address = Egl.GetProcAddress(function);
            }

            return address;
        }

        protected abstract IntPtr GetStaticAddress(IntPtr function, RenderableFlags renderable);

        // Todo: cross-reference the specs. What should happen if the context is destroyed from a different
        // thread?
        protected override void Dispose(bool manual)
        {
            if (!IsDisposed)
            {
                if (manual)
                {
                    if (IsCurrent)
                    {
                        Egl.MakeCurrent(WindowInfo.Display, WindowInfo.Surface, WindowInfo.Surface, IntPtr.Zero);
                    }

                    Egl.DestroyContext(WindowInfo.Display, HandleAsEGLContext);
                }

                IsDisposed = true;
            }
        }

        private EglContext GetSharedEglContext(IGraphicsContext sharedContext)
        {
            if (sharedContext == null)
            {
                return null;
            }

            var internalContext = sharedContext as IGraphicsContextInternal;
            if (internalContext != null)
            {
                return (EglContext)internalContext.Implementation;
            }

            return (EglContext)sharedContext;
        }
    }
}