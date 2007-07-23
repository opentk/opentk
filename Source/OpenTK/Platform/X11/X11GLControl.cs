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
        X11WindowInfo info = new X11WindowInfo();
        private Type xplatui;
        X11GLContext glContext;

        private bool quit;

        private bool disposed;

        #region --- Contructors ---

        public X11GLControl(UserControl c, int width, int height, bool fullscreen)
        {
            Trace.WriteLine("Creating opengl control (X11GLControl driver)");
            Trace.Indent();

            c.ParentChanged += new EventHandler(c_ParentChanged);
            if (c.ParentForm != null)
                throw new Exception("I was stupid!");

            if (c == null/* || c.TopLevelControl == null*/)
            {
                throw new Exception("Attempted to bind to non-existent control.");
            }

            info.Window = c.Handle;
            Trace.WriteLine(
                String.Format(
                    "Binding to control: {0}",
                    String.IsNullOrEmpty(c.Name) ? c.Text : c.Name
                )
            );

            xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
            Trace.WriteLine("Acquired System.Windows.Forms.XplatUIX11 type.");

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

                Trace.WriteLine(
                    String.Format(
                        "Screen: {0}, Display: {1}, Root Window: {2}, Control: {3}",
                        info.Screen,
                        info.Display,
                        info.RootWindow,
                        info.Window
                    )
                );

                glContext = new X11GLContext(info, new DisplayMode(
                    width, height, new ColorDepth(24), 16, 0, 0, 2, false, false, false, 0.0f)
                );
                glContext.CreateVisual();

                xplatui.GetField(
                    "CustomVisual",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).SetValue(
                        null,
                        glContext.XVisual
                    );

                xplatui.GetField(
                    "CustomColormap",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).SetValue(
                        null,
                        glContext.XColormap
                    );

                glContext.CreateContext(null, true);
            }
        }

        void c_ParentChanged(object sender, EventArgs e)
        {
            UserControl c = sender as UserControl;
            Trace.WriteLine(
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

            Trace.WriteLine(String.Format("Mapping window to top level: {0}", info.TopLevelWindow));
            API.MapRaised(info.Display, info.TopLevelWindow);
            Trace.Unindent();
        }

        #endregion

        #region --- IGLControl Members ---

        public event CreateEvent Create;

        private void OnCreate(object sender, EventArgs e)
        {
            if (this.Create != null)
                this.Create(sender, e);
        }

        #region public bool Quit

        public bool Quit
        {
            get { return quit; }
            set
            {
                throw new NotImplementedException();
                quit = value;
            }
        }

        #endregion

        public bool IsIdle
        {
            get
            {
                return API.Pending(info.Display) == 0;
            }
        }

        public bool Fullscreen
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public OpenTK.Platform.IGLContext Context
        {
            get
            {
                return glContext;
            }
        }

        public void ProcessEvents()
        {
            throw new Exception("The method or operation is not implemented.");
        }

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
