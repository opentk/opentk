#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace OpenTK.Platform.X11
{
    sealed class X11GLControl : IGLControl
    {
        WindowInfo info = new WindowInfo();
        //DisplayMode mode;
        private Type xplatui;
        X11GLContext glContext;

        private bool disposed;
        private bool fullscreen;

        #region --- Contructors ---

        #region public X11GLControl(UserControl c)

        public X11GLControl(UserControl c)
        {
            Debug.WriteLine("Creating opengl control (X11GLControl driver)");
            Debug.Indent();

            Utilities.ThrowOnX11Error = true;

            if (c == null/* || c.TopLevelControl == null*/)
            {
                throw new ArgumentException("UserControl c may not be null.");
            }

            c.HandleCreated += new EventHandler(c_HandleCreated);
            c.HandleDestroyed += new EventHandler(c_HandleDestroyed);

            xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
            if (xplatui == null)
                throw new ApplicationException("Could not get System.Windows.Forms.XplatUIX11 through reflection. Unsupported platform or Mono runtime version, aborting.");
    
            info.Display = (IntPtr)xplatui.GetField("DisplayHandle",
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
            info.RootWindow = (IntPtr)xplatui.GetField("RootWindow",
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
            info.Screen = (int)xplatui.GetField("ScreenNo",
                System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
            Debug.Print("Data read from System.Windows.Forms.XplatUIX11: {0}", info.ToString());

            //this.mode = mode;
            glContext = new X11GLContext(null, info);
            //glContext.PrepareContext(info);
            
            info.VisualInfo = glContext.VisualInfo;

            Debug.Print("Setting XplatUIX11.CustomVisual");
            xplatui.GetField("CustomVisual", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic)
                .SetValue(null, info.VisualInfo.visual);

            Debug.Print("Setting XplatUIX11.CustomColormap");
            xplatui.GetField("CustomColormap", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic)
                .SetValue(null, API.CreateColormap(info.Display, info.RootWindow, info.VisualInfo.visual, 0));

            Debug.Unindent();
        }

        #endregion

        #region void c_HandleCreated(object sender, EventArgs e)

        void c_HandleCreated(object sender, EventArgs e)
        {
            UserControl c = (sender as UserControl);
            Debug.Print("GLControl handle created, creating X11GLContext.");
            Debug.Indent();

            try
            {
                glContext.Handle = info.Handle = (sender as UserControl).Handle;
                glContext.CreateContext(null, true);
                glContext.MakeCurrent();
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

        #endregion

        #region void c_HandleDestroyed(object sender, EventArgs e)

        void c_HandleDestroyed(object sender, EventArgs e)
        {
            Debug.Print("X11GLControl handle destroyed, disposing X11GLContext.");
            glContext.Dispose();
        }

        #endregion

        #region private IntPtr FindColormap()

        /// <summary>
        /// Finds a colormap suitable for use with the GLControl.
        /// </summary>
        /// <returns>A pointer to the colormap</returns>
        /// <remarks>
        /// If the visual of the GLControl matches the default visual, the function returns
        /// the default colormap (i.e. the colormap of the root window). Otherwise, it creates
        /// a new, private colormap.
        /// </remarks>
        private IntPtr FindColormap()
        {
            if (info.VisualInfo.visual == Functions.XDefaultVisual(info.Display, info.Screen))
            {
                return Functions.XDefaultColormap(info.Display, info.Screen);
            }

            return API.CreateColormap(info.Display, info.RootWindow, glContext.VisualInfo.visual, 0/*AllocNone*/);
        }

        #endregion

        #endregion

        #region --- IGLControl Members ---

        public event CreateEvent Create;

        private void OnCreate(object sender, EventArgs e)
        {
            if (this.Create != null)
                this.Create(sender, e);
        }

        #region public bool IsIdle

        public bool IsIdle
        {
            get
            {
                return API.Pending(info.Display) == 0;
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
                //throw new Exception("The method or operation is not implemented.");
                fullscreen = false;
            }
        }

        #endregion

        #region public IGLContext Context

        public IGLContext Context
        {
            get
            {
                return glContext;
            }
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manuallyCalled)
        {
            if (!disposed)
            {
                // Clean unmanaged resources:
                // Nothing

                if (manuallyCalled)
                {
                    // Clean managed resources, too
                    glContext.Dispose();
                }
            }
            disposed = true;
        }

        ~X11GLControl()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
