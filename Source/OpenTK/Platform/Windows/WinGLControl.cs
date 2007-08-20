#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * Contributions from Erik Ylvisaker
 * See license.txt for license info
 */
#endregion

#region --- Using directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

#endregion

namespace OpenTK.Platform.Windows
{
    sealed class WinGLControl : OpenTK.Platform.IGLControl
    {
        private WinGLContext glContext;
        private bool fullscreen;
        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        private bool disposed;
        private Message msg;        // Used only by the IsIdle event.

        #region --- Constructors ---

        public WinGLControl(Control c, DisplayMode mode)
        {
            glContext = new WinGLContext(c.Handle, mode);

            glContext.CreateContext();
        }

        [Obsolete("Use WinGLControl(Control c, DisplayMode mode) instead")]
        public WinGLControl(Control c, int width, int height, bool fullscreen)
        {
            glContext = new WinGLContext(
                c.Handle,
                new DisplayMode(
                    width, height,
                    new ColorDepth(32),
                    16, 0, 0, 2,
                    fullscreen,
                    false,
                    false,
                    0.0f
                )
            );

            glContext.CreateContext();

            glContext.MakeCurrent();
            OpenTK.OpenGL.GL.LoadAll();
        }

        #endregion

        #region --- IGLControl membmers ---

        #region public bool IsIdle

        public bool IsIdle
        {
            get
            {
                return !API.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
            }
        }

        #endregion

        #region public bool Fullscreen

        public bool Fullscreen
        {
            get
            {
                return fullscreen;
            }
            set
            {
                fullscreen = false;
                //throw new NotImplementedException();
            }
        }

        #endregion

        #region public IGLContext Context

        public IGLContext Context
        {
            get { return glContext; }
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);

        }

        private void Dispose(bool calledManually)
        {
            if (!disposed)
            {
                // Clean unmanaged resources here:

                if (calledManually)
                {
                    // Safe to clean managed resources
                    glContext.Dispose();
                }
                disposed = true;
            }
        }

        ~WinGLControl()
        {
            Dispose(false);
        }

        #endregion
    }
}
