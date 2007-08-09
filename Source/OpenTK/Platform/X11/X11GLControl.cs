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
        private Type xplatui;
        X11GLContext glContext;

        private bool quit;
        private bool disposed;
        private bool fullscreen;

        #region --- Contructors ---

        [Obsolete("Use X11GLControl(UserControl c, DisplayMode mode) instead.")]
        public X11GLControl(UserControl c, int width, int height, bool fullscreen)
            : this(c, new DisplayMode(width, height, new ColorDepth(32), 16,
                   0, 0, 2, false, false, false, 0.0f)) { }
        
        public X11GLControl(UserControl c, DisplayMode mode)
        {
            Debug.WriteLine("Creating opengl control (X11GLControl driver)");
            Debug.Indent();

            if (c == null/* || c.TopLevelControl == null*/)
            {
                throw new ArgumentException("UserControl c may not be null.");
            }

            c.ParentChanged += new EventHandler(c_ParentChanged);
            if (c.ParentForm != null)
            {
                throw new ApplicationException("Internal OpenTK error, please report at http://opentk.sourceforge.net");
            }

            info.Handle = c.Handle;
            Debug.Print("Binding to control: {0}", String.IsNullOrEmpty(c.Name) ? c.Text : c.Name);

            xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
            Debug.Write("System.Windows.Forms.XplatUIX11: ");

            if (xplatui != null)
            {
                info.Display = (IntPtr)xplatui.GetField("DisplayHandle",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);

                info.RootWindow = (IntPtr)xplatui.GetField("RootWindow",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);

                info.Screen = (int)xplatui.GetField("ScreenNo",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);

                Debug.Print(
                    "Screen: {0}, Display: {1}, Root Window: {2}, Handle: {3}",
                    info.Screen, info.Display, info.RootWindow, info.Handle);

                glContext = new X11GLContext(info, mode);
                
                info.VisualInfo = glContext.CreateVisual();

                xplatui.GetField(
                    "CustomVisual",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).SetValue(
                        null,
                        //glContext.XVisual
                        info.VisualInfo.visual
                    );

                xplatui.GetField(
                    "CustomColormap",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).SetValue(
                        null,
                        API.CreateColormap(info.Display, info.RootWindow, info.VisualInfo.visual, 0/*AllocNone*/)
                        //glContext.colormap
                    );

                glContext.CreateContext(null, true);
            }
        }

        void c_ParentChanged(object sender, EventArgs e)
        {
            UserControl c = sender as UserControl;
            Debug.WriteLine(
                String.Format(
                    "TopLevel control is {0}",
                    c.TopLevelControl != null ? c.TopLevelControl.ToString() : "not available"
                )
            );

            if (c.TopLevelControl == null)
            {
                info.TopLevelWindow = c.Handle;
                throw new Exception("GLControl does not have a parent.");
            }
            else
            {
                info.TopLevelWindow = c.TopLevelControl.Handle;
            }

            Debug.WriteLine(String.Format("Mapping window to top level: {0}", info.TopLevelWindow));
            API.MapRaised(info.Display, info.TopLevelWindow);
            Debug.Unindent();
        }

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
