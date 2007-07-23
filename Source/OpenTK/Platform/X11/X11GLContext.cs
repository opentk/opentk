#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

using OpenTK.OpenGL;

namespace OpenTK.Platform.X11
{
    public class X11GLContext : OpenTK.Platform.IGLContext
    {
        private IntPtr x11context;
        private IntPtr display;
        private int screenNo;

        private DisplayMode mode;// = new DisplayMode();
        internal X11WindowInfo windowInfo = new X11WindowInfo();
        private VisualInfo visualInfo;

        //private IntPtr desktopResolution = IntPtr.Zero;

        //private int depthBits;
        //private int stencilBits;

        // These have to be used by the X11GLControl.
        internal IntPtr visual;
        internal IntPtr colormap;

        private bool disposed;

        #region --- Public Constructor ---

        private X11GLContext()
        {
            this.mode = new DisplayMode();
        }

        public X11GLContext(IWindowInfo info, DisplayMode mode)
        {
            X11WindowInfo xInfo = info as X11WindowInfo;            
            this.windowInfo.Window = xInfo.Window;
            this.windowInfo.RootWindow = xInfo.RootWindow;
            this.windowInfo.TopLevelWindow = xInfo.TopLevelWindow;
            this.windowInfo.Display = xInfo.Display;
            this.windowInfo.Screen = xInfo.Screen;
            
            this.mode = mode;
        }

        public X11GLContext(
            IntPtr handle,
            IntPtr display,
            IntPtr rootWindow,
            int screenNo,
            IntPtr handleToTopLevelControl,
            ColorDepth color,
            ColorDepth accum,
            int depthBits,
            int stencilBits,
            int auxBits,
            bool stereo,
            bool doublebuffer
        )
        {
            Trace.WriteLine("Creating opengl context (X11GLContext driver)");
            Trace.Indent();

            this.display = display;
            this.screenNo = screenNo;
            //this.depthBits = depthBits;
            //this.stencilBits = stencilBits;

            this.CreateVisual();
        }

        #endregion

        #region --- IGLContext Members ---

        #region public void SwapBuffers()

        public void SwapBuffers()
        {
            Glx.SwapBuffers(windowInfo.Display, windowInfo.Window);
        }

        #endregion

        #region public void MakeCurrent()

        public void MakeCurrent()
        {
            Debug.Write(
                String.Format(
                    "Making context {0} current on thread {1} (display: {2}, window: {3})... ",
                    x11context,
                    System.Threading.Thread.CurrentThread.ManagedThreadId,
                    windowInfo.Display,
                    windowInfo.Window
                )
            );
            bool result = Glx.MakeCurrent(windowInfo.Display, windowInfo.Window, x11context);

            if (!result)
            {
                Debug.WriteLine(String.Format("Failed to make context {0} current.", x11context));
                // probably need to recreate context here.
                throw new Exception(String.Format("Failed to make context {0} current.", x11context));
            }
            else
            {
                Debug.WriteLine("done!");
            }
        }

        #endregion

        public bool IsCurrent()
        {
            throw new NotImplementedException();
        }

        #region public IntPtr GetAddress(string function)

        public IntPtr GetAddress(string function)
        {
            return Glx.GetProcAddress(function);
        }

        #endregion

        public IEnumerable<DisplayMode> GetDisplayModes()
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
                Glx.DestroyContext(windowInfo.Display, x11context);
                API.Free(visual);

                if (manuallyCalled)
                {
                    // Safe to clean managed resources, too
                }
            }
            disposed = true;
        }

        ~X11GLContext()
        {
            this.Dispose(false);
        }

        #endregion

        #region public void CreateContext(X11GLContext shareContext, bool direct)

        public void CreateContext(X11GLContext shareContext, bool direct)
        {
            Trace.WriteLine("Creating opengl context.");
            Trace.Indent();

            IntPtr shareHandle = shareContext != null ? shareContext.Handle : IntPtr.Zero;
            Trace.WriteLine(
                shareHandle == IntPtr.Zero ?
                "Context is not shared." :
                String.Format("Context is shared with context: {0}", shareHandle)
            );
            Trace.WriteLine(
                direct ?
                "Context is direct." :
                "Context is indirect."
            );
            x11context = Glx.CreateContext(
                windowInfo.Display,
                visual,
                shareHandle,
                direct
            );
            Trace.WriteLine(String.Format("New opengl context created. (id: {0})", x11context));
            Trace.Unindent();

            //MakeCurrent();
        }

        #endregion

        #region public void CreateVisual()

        public void CreateVisual()
        {
            Trace.WriteLine("Creating visual.");
            Trace.Indent();

            ColorDepth color = new ColorDepth(24);
            int depthBits = 16;

            // Create the Visual
            List<int> visualAttributes = new List<int>();
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.RGBA);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.RED_SIZE);
            visualAttributes.Add((int)color.Red);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.GREEN_SIZE);
            visualAttributes.Add((int)color.Green);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.BLUE_SIZE);
            visualAttributes.Add((int)color.Blue);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.ALPHA_SIZE);
            visualAttributes.Add((int)color.Alpha);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.DEPTH_SIZE);
            visualAttributes.Add((int)depthBits);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.DOUBLEBUFFER);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.NONE);
            
            /*
            List<int> visualAttributes = new List<int>();
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.RGBA);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.RED_SIZE);
            visualAttributes.Add((int)mode.Color.Red);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.GREEN_SIZE);
            visualAttributes.Add((int)mode.Color.Green);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.BLUE_SIZE);
            visualAttributes.Add((int)mode.Color.Blue);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.ALPHA_SIZE);
            visualAttributes.Add((int)mode.Color.Alpha);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.DEPTH_SIZE);
            visualAttributes.Add((int)depthBits);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.DOUBLEBUFFER);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.NONE);
            */
            Trace.Write(
                String.Format(
                    "Requesting visual: {0} ({1}{2}{3}{4})... ",
                    mode.ToString(),
                    mode.Color.Red,
                    mode.Color.Green,
                    mode.Color.Blue,
                    mode.Color.Alpha
                )
            );

            visual = Glx.ChooseVisual(windowInfo.Display, windowInfo.Screen, visualAttributes.ToArray());
            if (visual == IntPtr.Zero)
            {
                throw new Exception("Requested visual not available.");
            }
            visualInfo = (VisualInfo)Marshal.PtrToStructure(visual, typeof(VisualInfo));

            Trace.WriteLine(String.Format("done! (id: {0})", x11context));
            Trace.Unindent();
        }

        #endregion

        public IntPtr XVisual
        {
            get { return this.visual; }
        }

        public VisualInfo XVisualInfo
        {
            get { return this.visualInfo; }
        }

        public IntPtr XColormap
        {
            get { return colormap; }
        }

        public IntPtr Handle
        {
            get { return this.x11context; }
        }
/*
        public IntPtr ContainingWindow
        {
            get { return windowInfo.Window; }
            internal set { windowInfo.Window = value; }
        }
*/
    }
}
