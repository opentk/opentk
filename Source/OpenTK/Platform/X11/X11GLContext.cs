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

using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Provides methods to create and control an opengl context on the X11 platform.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class X11GLContext : IGraphicsContext, IGraphicsContextInternal
    {
        ContextHandle context;
        //X11WindowInfo window;
        X11WindowInfo currentWindow;
        //IntPtr visual;
        bool vsync_supported;
        int vsync_interval;

        bool disposed;

        #region --- Constructors ---

        static X11GLContext()
        {
            // Set the GetCurrentContext implementation.
            if (GraphicsContext.GetCurrentContext == null)
                GraphicsContext.GetCurrentContext = X11GLContext.GetCurrentContext;
        }

        public X11GLContext(GraphicsMode mode, IWindowInfo info, IGraphicsContext shared, bool directRendering)
        {
            //if (mode == null) mode = GraphicsMode.Default;
            if (info == null) throw new ArgumentNullException("info", "Should point to a valid window.");

            currentWindow = (X11WindowInfo)info;
            currentWindow.VisualInfo = SelectVisual(mode, currentWindow);

            Debug.Print("Chose visual: {0}", currentWindow.VisualInfo);

            CreateContext(shared, directRendering, currentWindow);
        }

        public X11GLContext(IWindowInfo window)
        {
            if (window == null) throw new ArgumentNullException("window");

            //renderContext = Glx.GetCurrentContext();
            //if (renderContext == IntPtr.Zero)
            //    throw new InvalidOperationException("No OpenGL context is current in the calling thread.");

            //currentWindow = window;
        }

        #endregion

        #region --- Private Methods ---

        #region XVisualInfo SelectVisual(GraphicsMode mode, X11WindowInfo currentWindow)

        XVisualInfo SelectVisual(GraphicsMode mode, X11WindowInfo currentWindow)
        {
            XVisualInfo info = new XVisualInfo();
            info.visualid = (IntPtr)mode.Index;
            info.screen = currentWindow.Screen;
            int items;
            
            lock (API.Lock)
            {
                IntPtr vs = Functions.XGetVisualInfo(currentWindow.Display, XVisualInfoMask.ID | XVisualInfoMask.Screen, ref info, out items);
                if (items == 0)
                    throw new GraphicsModeException(String.Format("Invalid GraphicsMode specified ({0}).", mode));

                info = (XVisualInfo)Marshal.PtrToStructure(vs, typeof(XVisualInfo));
                Functions.XFree(vs);
            }

            return info;
        }

        #endregion

        #region void CreateContext(IGraphicsContext shareContext, bool direct)

        void CreateContext(IGraphicsContext shareContext, bool direct, X11WindowInfo window)
        {
            try
            {
                ContextHandle shareHandle = shareContext != null ? (shareContext as IGraphicsContextInternal).Context :
                                                                   (ContextHandle)IntPtr.Zero;

                Debug.Write("Creating OpenGL context: ");
                Debug.Write(direct ? "direct, " : "indirect, ");
                Debug.Write(shareHandle.Handle == IntPtr.Zero ? "not shared... " :
                    String.Format("shared with ({0})... ", shareHandle));

                lock (API.Lock)
                {
                    XVisualInfo info = window.VisualInfo;   // Cannot pass a Property by reference.
                    context = new ContextHandle(Glx.CreateContext(window.Display, ref info, shareHandle.Handle, direct));

                    // Context creation succeeded, return.
                    if (context != ContextHandle.Zero)
                    {
                        Debug.Print("done! (id: {0})", context);
                        return;
                    }

                    // Context creation failed. Retry with a non-shared context with the direct/indirect bit flipped.
                    Debug.Print("failed.");
                    Debug.Write(String.Format("Creating OpenGL context: {0}, not shared... ", !direct ? "direct" : "indirect"));
                    context = new ContextHandle(Glx.CreateContext(window.Display, ref info, IntPtr.Zero, !direct));
                    if (context != ContextHandle.Zero)
                    {
                        Debug.Print("done! (id: {0})", context);
                        return;
                    }
                }

                Debug.Print("failed.");
                throw new GraphicsModeException("Failed to create OpenGL context. Glx.CreateContext call returned 0.");
            }
            finally
            {
                //Debug.Unindent();
            }
        }

        #endregion

        bool SupportsExtension(X11WindowInfo window, string e)
        {
            string extensions = Glx.QueryExtensionsString(window.Display, window.Screen);
            return !String.IsNullOrEmpty(extensions) && extensions.Contains(e);
        }

        #endregion

        #region --- IGraphicsContext Members ---

        #region public void SwapBuffers()

        public void SwapBuffers()
        {
            //if (window == null) throw new ArgumentNullException("window", "Must point to a valid window.");
            //X11WindowInfo w = (X11WindowInfo)window;
            if (currentWindow.Display == IntPtr.Zero || currentWindow.WindowHandle == IntPtr.Zero)
                throw new InvalidOperationException(
                    String.Format("Window is invalid. Display ({0}), Handle ({1}).", currentWindow.Display, currentWindow.WindowHandle));
            Glx.SwapBuffers(currentWindow.Display, currentWindow.WindowHandle);
        }

        #endregion

        #region public void MakeCurrent(IWindowInfo window)

        public void MakeCurrent(IWindowInfo window)
        {
            X11WindowInfo w = (X11WindowInfo)window;
            bool result;

            Debug.Write(String.Format("Making context {0} current on thread {1} (Display: {2}, Screen: {3}, Window: {4})... ",
                    context, System.Threading.Thread.CurrentThread.ManagedThreadId, w.Display, w.Screen, w.WindowHandle));

            if (w.Display == IntPtr.Zero || w.WindowHandle == IntPtr.Zero || context == ContextHandle.Zero)
                throw new InvalidOperationException("Invalid display, window or context.");

            result = Glx.MakeCurrent(w.Display, w.WindowHandle, context);

            if (!result)
                throw new GraphicsContextException("Failed to make context current.");
            else
                Debug.WriteLine("done!");
        }

        #endregion

        #region public bool IsCurrent

        public bool IsCurrent
        {
            get { return Glx.GetCurrentContext() == this.context.Handle; }
            //set
            //{
            //    if (value)
            //        Glx.MakeCurrent(window.Display, window.Handle, context);
            //    else
            //        Glx.MakeCurrent(window.Handle, IntPtr.Zero, IntPtr.Zero);
            //}
        }

        #endregion

        #region public bool VSync

        public bool VSync
        {
            get
            {
                return vsync_supported && vsync_interval > 0;
            }
            set
            {
                if (vsync_supported)
                {
                    int error_code = Glx.Sgi.SwapInterval(value ? 1 : 0);
                    if (error_code != 0)
                        throw new GraphicsException(String.Format("Could not set vsync, error code: {0}", error_code));
                    vsync_interval = value ? 1 : 0;
                }
            }
        }

        #endregion

        public event DestroyEvent<IGraphicsContext> Destroy;

        #region public IntPtr GetAddress(string function)

        public IntPtr GetAddress(string function)
        {
            return Glx.GetProcAddress(function);
        }

        #endregion

        public void RegisterForDisposal(IDisposable resource)
        {
            throw new NotSupportedException("Use OpenTK.GraphicsContext instead.");
        }

        public void DisposeResources()
        {
            throw new NotSupportedException("Use OpenTK.GraphicsContext instead.");
        }

        #endregion

        #region --- IGLContextInternal Members ---

        #region void LoadAll()

        void IGraphicsContextInternal.LoadAll()
        {
            GL.LoadAll();
            Glu.LoadAll();
            Glx.LoadAll();
            vsync_supported = this.SupportsExtension(currentWindow, "SGI_swap_control") &&
                              this.GetAddress("glXSwapControlSGI") != IntPtr.Zero;
        }

        #endregion

        #region public DisplayMode Mode

        GraphicsMode IGraphicsContextInternal.GraphicsMode
        {
            get { return null; }
        }

        #endregion

        #region ContextHandle IGLContextInternal.Context

        ContextHandle IGraphicsContextInternal.Context
        {
            get { return context; }
            /*private set { context = value; }*/
        }

        #endregion

        #region IWindowInfo IGLContextInternal.Info

        //IWindowInfo IGraphicsContextInternal.Info { get { return window; } }

        #endregion

        #endregion

        #region --- Methods ---

        void OnDestroy()
        {
            if (Destroy != null)
                Destroy(this, EventArgs.Empty);
        }

        #region static ContextHandle GetCurrentContext()

        static ContextHandle GetCurrentContext()
        {
            return (ContextHandle)Glx.GetCurrentContext();
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
                try
                {
                    Functions.XLockDisplay(currentWindow.Display);
                    Glx.MakeCurrent(currentWindow.Display, IntPtr.Zero, IntPtr.Zero);
                    Glx.DestroyContext(currentWindow.Display, context);
                    //Functions.XFree(visual);
                }
                finally
                {
                    Functions.XUnlockDisplay(currentWindow.Display);               
                }

                if (manuallyCalled)
                {
                }
            }
            disposed = true;
        }

        ~X11GLContext()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
