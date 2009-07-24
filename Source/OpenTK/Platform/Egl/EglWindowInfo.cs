using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace OpenTK.Platform.Egl
{
    // Holds information about an EGL window.
    class EglWindowInfo : IWindowInfo
    {
        #region Fields

        IntPtr handle;
        EGLDisplay display;
        EGLSurface surface;
        bool disposed;

        #endregion

        #region Constructiors

        public EglWindowInfo(IntPtr handle, EGLDisplay display, EGLSurface surface)
        {
            Handle = handle;
            Display = display;
            Surface = surface;
        }

        #endregion

        #region Public Members

        public IntPtr Handle { get { return handle; } private set { handle = value; } }

        public EGLDisplay Display { get { return display; } private set { display = value; } }

        public EGLSurface Surface { get { return surface; } private set { surface = value; } }

        public void CreateWindowSurface(EGLConfig config)
        {
            Surface = Egl.CreateWindowSurface(Display, config, Handle, null);
        }

        //public void CreatePixmapSurface(EGLConfig config)
        //{
        //    Surface = Egl.CreatePixmapSurface(Display, config, Handle, null);
        //}

        //public void CreatePbufferSurface(EGLConfig config)
        //{
        //    Surface = Egl.CreatePbufferSurface(Display, config, null);
        //}

        public void DestroySurface()
        {
            if (Surface.Handle != EGLSurface.None.Handle)
                if (!Egl.DestroySurface(Display, Surface))
                    Debug.Print("[Warning] Failed to destroy {0}:{1}.", Surface.GetType().Name, Surface);
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    DestroySurface();
                }
                else
                {
                    Debug.Print("[Warning] Failed to destroy {0}:{1}.", this.GetType().Name, Handle);
                }
            }
        }

        ~EglWindowInfo()
        {
            Dispose(false);
        }

        #endregion
    }
}
