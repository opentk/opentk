#region License
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
#endregion

using System;

using OpenTK.Graphics;
using System.Diagnostics;
using OpenTK.Platform.Windows;

namespace OpenTK.Platform.Egl
{
    class EglContext : IGraphicsContext, IGraphicsContextInternal
    {
        #region Fields

        EglWindowInfo WindowInfo;
        EGLContext context;
        GraphicsMode mode;
        bool vsync = true;   // Default vsync value is defined as 1 (true) in EGL.
        bool disposed = false;

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

            int dummy_major, dummy_minor;
            if (!Egl.Initialize(window.Display, out dummy_major, out dummy_minor))
                throw new GraphicsContextException(String.Format("Failed to initialize EGL, error {0}.", Egl.GetError()));

            WindowInfo = window;

            mode = new EglGraphicsMode().SelectGraphicsMode(mode.ColorFormat, mode.Depth, mode.Stencil, mode.Samples, mode.AccumulatorFormat, mode.Buffers, mode.Stereo);
            if (!mode.Index.HasValue)
                throw new GraphicsModeException("Invalid or unsupported GraphicsMode.");
            EGLConfig config = new EGLConfig(mode.Index.Value);

            if (window.Surface.Handle == EGLSurface.None.Handle)
                window.CreateWindowSurface(config);

            int[] attrib_list = new int[] { Egl.CONTEXT_CLIENT_VERSION, major, Egl.NONE };
            context = Egl.CreateContext(window.Display, config, shared != null ? shared.context : EGLContext.None, attrib_list);

            MakeCurrent(window);
        }

        #endregion

        #region IGraphicsContext Members

        public void SwapBuffers()
        {
            Egl.SwapBuffers(WindowInfo.Display, WindowInfo.Surface);
        }

        public void MakeCurrent(IWindowInfo window)
        {
            // Ignore 'window', unless it actually is an EGL window. In other words,
            // trying to make the EglContext current on a non-EGL window will do,
            // nothing (the EglContext will remain current on the previous EGL window
            // or the window it was constructed on (which may not be EGL)).
            if (window is EglWindowInfo)
                WindowInfo = (EglWindowInfo)window;
            Egl.MakeCurrent(WindowInfo.Display, WindowInfo.Surface, WindowInfo.Surface, context);
        }

        public bool IsCurrent
        {
            get { return Egl.GetCurrentContext().Handle == context.Handle; }
        }

        public event DestroyEvent<IGraphicsContext> Destroy;

        public bool VSync
        {
            get
            {
                // Egl.GetSwapInterval does not exist, so store and return the current interval.
                // The default interval is defined as 1 (true).
                return vsync;
            }
            set
            {
                if (Egl.SwapInterval(WindowInfo.Display, value ? 1 : 0))
                    vsync = value;
                else
                    Debug.Print("[Warning] Egl.SwapInterval({0}, {1}) failed.", WindowInfo.Display, value);
            }
        }

        public void Update(IWindowInfo window)
        {
            // Do nothing.
        }

        public GraphicsMode GraphicsMode
        {
            get { return mode; }
        }

        // Todo: implement this!
        public bool ErrorChecking
        {
            get
            {
                return false;
            }
            set
            {
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Todo: cross-reference the specs. What should happen if the context is destroyed from a different
        // thread?
        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    Egl.MakeCurrent(WindowInfo.Display, WindowInfo.Surface, WindowInfo.Surface, EGLContext.None);
                    Egl.DestroyContext(WindowInfo.Display, context);
                }
                else
                {
                    Debug.Print("[Warning] {0}:{1} was not disposed.", this.GetType().Name, context.Handle);
                }
                disposed = true;
            }
        }

        ~EglContext()
        {
            Dispose(false);
        }

        #endregion

        #region IGraphicsContextInternal Members

        public IGraphicsContext Implementation
        {
            get { return this; }
        }

        public void LoadAll()
        {
            // Todo: enable those
            //OpenTK.Graphics.ES10.ES.LoadAll();
            OpenTK.Graphics.ES11.GL.LoadAll();
            //OpenTK.Graphics.ES20.ES.LoadAll();
        }

        public ContextHandle Context
        {
            get { return new ContextHandle(context.Handle.Value); }
        }

        public void RegisterForDisposal(IDisposable resource)
        {
            throw new NotImplementedException();
        }

        public void DisposeResources()
        {
            throw new NotImplementedException();
        }

        public IntPtr GetAddress(string function)
        {
            return Egl.GetProcAddress(function);
        }

        #endregion
    }
}
