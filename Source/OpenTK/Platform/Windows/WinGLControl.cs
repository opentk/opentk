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
using System.Diagnostics;

#endregion

namespace OpenTK.Platform.Windows
{
    sealed class WinGLControl : OpenTK.Platform.IGLControl
    {
        private WinGLContext glContext;
        private bool fullscreen;
        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();
        private DisplayMode mode;

        private bool disposed;
        private Message msg;        // Used only by the IsIdle event.

        #region --- Constructors ---

        public WinGLControl(UserControl c, DisplayMode mode)
        {
            this.mode = mode;
            
            c.HandleCreated += new EventHandler(c_HandleCreated);
            c.HandleDestroyed += new EventHandler(c_HandleDestroyed);

            glContext = new WinGLContext(mode);

            // Create the actual context
            c.Visible = true;
            //c.CreateControl();
            glContext.MakeCurrent();
        }

        void c_HandleCreated(object sender, EventArgs e)
        {
            Debug.Print("GLControl handle created, creating WinGLContext.");
            Debug.Indent();

            try
            {
                glContext.PrepareContext((sender as Control).Handle);
                glContext.CreateContext();
            }
            catch (ApplicationException expt)
            {
                Debug.Print(expt.ToString());
                throw;
            }
            finally
            {
                Debug.Unindent();
            }
        }

        void c_HandleDestroyed(object sender, EventArgs e)
        {
            glContext.Dispose();
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
