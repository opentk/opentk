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
    /// <summary>
    /// Provides methods to create and control an opengl context on X11.
    /// </summary>
    public sealed class X11GLContext : OpenTK.Platform.IGLContext
    {
        private IntPtr x11context;

        private DisplayMode mode;// = new DisplayMode();
        internal WindowInfo windowInfo;
        private VisualInfo visualInfo;

        //private IntPtr desktopResolution = IntPtr.Zero;

        //private int depthBits;
        //private int stencilBits;

        // These have to be used by the X11GLControl.
        internal IntPtr visual;
        internal IntPtr colormap;

        private bool disposed;

        #region --- Public Constructor ---

        internal X11GLContext()
        {
            this.windowInfo = new WindowInfo();
            this.mode = new DisplayMode();
        }

        internal X11GLContext(WindowInfo window, DisplayMode mode)
        {
            this.windowInfo = new WindowInfo(window);
            this.mode = mode;
        }

        #endregion

        #region --- IGLContext Members ---

        #region public void SwapBuffers()

        public void SwapBuffers()
        {
            Glx.SwapBuffers(windowInfo.Display, windowInfo.Handle);
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
                    windowInfo.Handle
                )
            );
            bool result = Glx.MakeCurrent(windowInfo.Display, windowInfo.Handle, x11context);

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
            Debug.WriteLine("Creating opengl context.");
            Debug.Indent();

            IntPtr shareHandle = shareContext != null ? shareContext.Handle : IntPtr.Zero;
            Debug.WriteLine(
                shareHandle == IntPtr.Zero ?
                "Context is not shared." :
                String.Format("Context is shared with context: {0}", shareHandle)
            );
            Debug.WriteLine(
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
            if (x11context != IntPtr.Zero)
            {
                Debug.WriteLine(String.Format("New opengl context created. (id: {0})", x11context));
                Debug.Unindent();
            }
            else
            {
                throw new ApplicationException("Could not create opengl context.");
            }
        }

        #endregion

        #region public void CreateVisual()

        internal VisualInfo CreateVisual()
        {
            Debug.WriteLine("Creating visual.");
            Debug.Indent();
/*
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
*/

            Debug.Print("Requesting DisplayMode: {0}. ", mode.ToString());
            // Hack; Temp workaround for invalid depth of 24
            if (mode.DepthBits == 24)
            {
                mode.DepthBits = 16;
                Debug.WriteLine("Temporary workaround applied: depth changed to 16.");
            }
            
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
            //visualAttributes.Add((int)mode.DepthBits);
            visualAttributes.Add(1);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.DOUBLEBUFFER);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.NONE);

            visual = Glx.ChooseVisual(windowInfo.Display, windowInfo.Screen, visualAttributes.ToArray());
            if (visual == IntPtr.Zero)
            {
                throw new ApplicationException("Requested mode not available.");
            }
            windowInfo.VisualInfo = (VisualInfo)Marshal.PtrToStructure(visual, typeof(VisualInfo));
            Debug.Print("Got visual: {0}", windowInfo.VisualInfo.ToString());

            Debug.Unindent();

            return windowInfo.VisualInfo;
        }

        #endregion

        internal IntPtr XVisual
        {
            get { return this.visual; }
        }

        internal VisualInfo XVisualInfo
        {
            get { return windowInfo.VisualInfo; }
        }

        internal IntPtr XColormap
        {
            get { return colormap; }
        }

        internal IntPtr Handle
        {
            get { return this.x11context; }
        }
    }
}
