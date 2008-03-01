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
        IntPtr context;
        X11WindowInfo window;
        IntPtr visual;
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

        internal X11GLContext(GraphicsMode mode, IWindowInfo info, IGraphicsContext shared, bool directRendering)
        {
            //if (mode == null) mode = GraphicsMode.Default;
            if (info == null) throw new ArgumentNullException("info", "Should point to a valid window.");

            window = (X11WindowInfo)info;
            window.VisualInfo = SelectVisual(mode);

            Debug.Print("Chose visual: {0}", window.VisualInfo);
            
            CreateContext(shared, directRendering);
        }

        #endregion

        #region --- Private Methods ---

        #region XVisualInfo SelectVisual(GraphicsMode mode)

        XVisualInfo SelectVisual(GraphicsMode mode)
        {
            List<int> visualAttributes = new List<int>();

            // TODO: Improve modesetting code.
            if (mode == null || mode.ColorDepth.BitsPerPixel == 0)
            {
                // Define the bare essentials - needed for compatibility with Mono's System.Windows.Forms
                Debug.Print("Mono/X11 compatibility mode.");

                visualAttributes.Add((int)GLXAttribute.RGBA);
                //visualAttributes.Add((int)GLXAttribute.RED_SIZE);
                //visualAttributes.Add((int)1);
                //visualAttributes.Add((int)GLXAttribute.GREEN_SIZE);
                //visualAttributes.Add((int)1);
                //visualAttributes.Add((int)GLXAttribute.BLUE_SIZE);
                //visualAttributes.Add((int)1);
                visualAttributes.Add((int)GLXAttribute.DEPTH_SIZE);
                visualAttributes.Add((int)1);
            }
            else
            {
                visualAttributes.Add((int)GLXAttribute.RGBA);
                visualAttributes.Add((int)GLXAttribute.RED_SIZE);
                visualAttributes.Add((int)mode.ColorDepth.Red);
                visualAttributes.Add((int)GLXAttribute.GREEN_SIZE);
                visualAttributes.Add((int)mode.ColorDepth.Green);
                visualAttributes.Add((int)GLXAttribute.BLUE_SIZE);
                visualAttributes.Add((int)mode.ColorDepth.Blue);
                visualAttributes.Add((int)GLXAttribute.ALPHA_SIZE);
                visualAttributes.Add((int)mode.ColorDepth.Alpha);
                visualAttributes.Add((int)GLXAttribute.DEPTH_SIZE);
                visualAttributes.Add((int)mode.Depth);
            }

            if (mode.Buffers > 1)
                visualAttributes.Add((int)GLXAttribute.DOUBLEBUFFER);
            if (mode.Stencil > 1)
            {
                visualAttributes.Add((int)GLXAttribute.STENCIL_SIZE);
                visualAttributes.Add(mode.Stencil);
            }
            if (mode.AccumulatorFormat.BitsPerPixel > 0)
            {
                visualAttributes.Add((int)GLXAttribute.ACCUM_ALPHA_SIZE);
                visualAttributes.Add(mode.AccumulatorFormat.Alpha);
                visualAttributes.Add((int)GLXAttribute.ACCUM_BLUE_SIZE);
                visualAttributes.Add(mode.AccumulatorFormat.Blue);
                visualAttributes.Add((int)GLXAttribute.ACCUM_GREEN_SIZE);
                visualAttributes.Add(mode.AccumulatorFormat.Green);
                visualAttributes.Add((int)GLXAttribute.ACCUM_RED_SIZE);
                visualAttributes.Add(mode.AccumulatorFormat.Red);
            }
            if (mode.Stereo)
                visualAttributes.Add((int)GLXAttribute.STEREO);

            visualAttributes.Add((int)0);

            visual = Glx.ChooseVisual(window.Display, window.Screen, visualAttributes.ToArray());

            if (visual == IntPtr.Zero)
                throw new GraphicsContextException(String.Format("Failed to set requested mode: {0}.", mode.ToString()));

            return (XVisualInfo)Marshal.PtrToStructure(visual, typeof(XVisualInfo));
        }

        #endregion

        #region void CreateContext(IGraphicsContext shareContext, bool direct)

        void CreateContext(IGraphicsContext shareContext, bool direct)
        {
            try
            {
                ContextHandle shareHandle = shareContext != null ? (shareContext as IGraphicsContextInternal).Context : (ContextHandle)IntPtr.Zero;

                Debug.Write("Creating OpenGL context: ");
                Debug.Write(direct ? "direct, " : "indirect, ");
                Debug.Write(shareHandle.Handle == IntPtr.Zero ? "not shared... " :
                    String.Format("shared with ({0})... ", shareHandle));

                // Try to call Glx.CreateContext with the specified parameters.
                context = Glx.CreateContext(window.Display, visual, shareHandle.Handle, direct);

                // Context creation succeeded, return.
                if (context != IntPtr.Zero)
                {
                    Debug.Print("done! (id: {0})", context);

                    //this.MakeCurrent();
                    return;
                }
                // Context creation failed. Retry with a non-shared context with the
                // direct/indirect rendering mode flipped.
                Debug.Print("failed.");
                Debug.Write(String.Format("Creating OpenGL context: {0}, not shared... ", !direct ? "direct" : "indirect"));
                context = Glx.CreateContext(window.Display, visual, IntPtr.Zero, !direct);
                if (context != IntPtr.Zero)
                {
                    Debug.Print("done! (id: {0})", context);

                    //this.MakeCurrent();
                    return;
                }

                Debug.Print("failed.");
                throw new GraphicsModeException("Failed to create OpenGL context. Glx.CreateContext call returned 0.");
            }
            finally
            {
                Debug.Unindent();
            }
        }

        #endregion

        bool SupportsExtension(string e)
        {
            string extensions = Glx.QueryExtensionsString(window.Display, window.Screen);
            return !String.IsNullOrEmpty(extensions) && extensions.Contains(e);
        }

        #endregion

        #region --- IGraphicsContext Members ---

        #region public void SwapBuffers()

        public void SwapBuffers()
        {
            Glx.SwapBuffers(window.Display, window.Handle);
        }

        #endregion

        #region public void MakeCurrent()

        bool result;
        public void MakeCurrent()
        {
            Debug.Write(String.Format("Making context {0} current on thread {1} (Display: {2}, Screen: {3}, Window: {4})... ",
                    context, System.Threading.Thread.CurrentThread.ManagedThreadId, window.Display, window.Screen, window.Handle));

            if (window.Display != IntPtr.Zero && window.Handle != IntPtr.Zero && context != IntPtr.Zero)
            {
                result = Glx.MakeCurrent(window.Display, window.Handle, context);
                
                if (!result)
                {
                    Debug.WriteLine("failed.");
                    // probably need to recreate context here.
                    //throw new ApplicationException(String.Format("Failed to make context {0} current on thread {1}.",
                    //    context, System.Threading.Thread.CurrentThread.ManagedThreadId));
                }
                else
                {
                    Debug.WriteLine("done!");
                }
            }
        }

        #endregion

        #region public bool IsCurrent

        public bool IsCurrent
        {
            get { return Glx.GetCurrentContext() == this.context; }
            set
            {
                if (value)
                    Glx.MakeCurrent(window.Display, window.Handle, context);
                else
                    Glx.MakeCurrent(window.Handle, IntPtr.Zero, IntPtr.Zero);
            }
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

        public IEnumerable<DisplayMode> GetDisplayModes()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region --- IGLContextInternal Members ---

        #region void LoadAll()

        void IGraphicsContextInternal.LoadAll()
        {
            GL.LoadAll();
            Glu.LoadAll();
            Glx.LoadAll();
            vsync_supported = this.SupportsExtension("SGI_swap_control") && this.GetAddress("glXSwapControlSGI") != IntPtr.Zero;
        }

        #endregion

        #region public DisplayMode Mode

        GraphicsMode IGraphicsContextInternal.GraphicsMode
        {
            get { return null; }
        }

        #endregion

        #region IntPtr IGLContextInternal.Context

        ContextHandle IGraphicsContextInternal.Context
        {
            get { return context; }
            /*private set { context = value; }*/
        }

        #endregion

        #region IWindowInfo IGLContextInternal.Info

        IWindowInfo IGraphicsContextInternal.Info { get { return window; } }

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
                Glx.MakeCurrent(window.Display, IntPtr.Zero, IntPtr.Zero);
                Glx.DestroyContext(window.Display, context);
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
    }
}
