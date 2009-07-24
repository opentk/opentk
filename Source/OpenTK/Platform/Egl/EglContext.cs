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

namespace OpenTK.Platform.Egl
{
    class EglContext : IGraphicsContext
    {
        #region Fields

        EglWindowInfo window;
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

            Egl.Initialize(window.Display, out major, out minor);

            EGLConfig config = new EGLConfig(mode.Index);

            if (window.Surface.Handle == EGLSurface.None.Handle)
                window.CreateWindowSurface(config);

            context = Egl.CreateContext(window.Display, config, shared.context, null);
            MakeCurrent(window);
        }

        #endregion

        #region IGraphicsContext Members

        public void SwapBuffers()
        {
            Egl.SwapBuffers(window.Display, window.Surface);
        }

        public void MakeCurrent(IWindowInfo window)
        {
            EglWindowInfo egl = (EglWindowInfo)window;
            Egl.MakeCurrent(egl.Display, egl.Surface, egl.Surface, context);
            this.window = egl;
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
                if (Egl.SwapInterval(window.Display, value ? 1 : 0))
                    vsync = value;
                else
                    Debug.Print("[Warning] Egl.SwapInterval({0}, {1}) failed.", window.Display, value);
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
                    Egl.MakeCurrent(window.Display, window.Surface, window.Surface, EGLContext.None);
                    Egl.DestroyContext(window.Display, context);
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
    }
}
