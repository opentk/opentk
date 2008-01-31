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
    /// Provides methods to create and control an opengl context on the X11 platform.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class X11GLContext : IGraphicsContext, IGLContextInternal, IGLContextCreationHack
    {
         IntPtr context;
         DisplayMode mode;
         WindowInfo windowInfo = new WindowInfo();
         IntPtr visual;
         bool vsync_supported;
         int vsync_interval;

         bool disposed;

        #region --- Constructors ---

         static X11GLContext()
         {
             // Set the GetCurrentContext implementation.
             if (GLContext.GetCurrentContext == null)
                 GLContext.GetCurrentContext = X11GLContext.GetCurrentContext;
         }

        /// <private />
        /// <summary>Constructs a new X11GLContext object.</summary>
        public X11GLContext() { }

        #endregion

        #region --- IGLContextCreationHack Members ---

        #region bool IGLContextCreationHack.SelectDisplayMode(DisplayMode mode, IWindowInfo info)

        /// <summary>
        /// HACK! This function will be removed in 0.3.15
        /// Checks if the specified OpenTK.Platform.DisplayMode is available, and selects it if it is.
        /// </summary>
        /// <param name="mode">The OpenTK.Platform.DisplayMode to select.</param>
        /// <param name="info">The OpenTK.Platform.IWindowInfo that describes the display to use. Note: a window handle is not necessary for this function!</param>
        /// <returns>True if the DisplayMode is available, false otherwise.</returns>
        bool IGLContextCreationHack.SelectDisplayMode(DisplayMode mode, IWindowInfo info)
        {
            List<int> visualAttributes = new List<int>();

            // TODO: Improve modesetting code.
            if (mode == null || mode.Color.BitsPerPixel == 0)
            {
                // Define the bare essentials - needed for compatibility with Mono's System.Windows.Forms
                Debug.Print("Preparing visual for System.Windows.Forms (compatibility mode)");
            
                visualAttributes.Add((int)Glx.Enums.GLXAttribute.RGBA);
                /*visualAttributes.Add((int)Glx.Enums.GLXAttribute.RED_SIZE);
                visualAttributes.Add((int)1);
                visualAttributes.Add((int)Glx.Enums.GLXAttribute.GREEN_SIZE);
                visualAttributes.Add((int)1);
                visualAttributes.Add((int)Glx.Enums.GLXAttribute.BLUE_SIZE);
                visualAttributes.Add((int)1);*/
                visualAttributes.Add((int)Glx.Enums.GLXAttribute.DEPTH_SIZE);
                visualAttributes.Add((int)1);
                visualAttributes.Add((int)Glx.Enums.GLXAttribute.DOUBLEBUFFER);
                visualAttributes.Add((int)0);
            }
            else
            {
                Debug.Print("Preparing visual for DisplayMode: {0}", mode.ToString());

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
                visualAttributes.Add((int)mode.DepthBits);
                visualAttributes.Add((int)Glx.Enums.GLXAttribute.DOUBLEBUFFER);
                visualAttributes.Add((int)0);
            }

            windowInfo.CopyInfoFrom(info);
            visual = Glx.ChooseVisual(windowInfo.Display, windowInfo.Screen, visualAttributes.ToArray());
            if (visual == IntPtr.Zero)
                return false;
            else
            {
                windowInfo.VisualInfo = (XVisualInfo)Marshal.PtrToStructure(visual,
                                                                            typeof(XVisualInfo));
                Debug.Print("Chose visual {0}", windowInfo.VisualInfo.ToString());
            }
            return true;
        }

        #endregion

        void IGLContextCreationHack.SetWindowHandle(IntPtr handle)
        {
            this.windowInfo.Handle = handle;
        }

        #endregion

        #region --- IGraphicsContext Members ---

        #region public DisplayMode Mode

        public DisplayMode Mode
        {
            get { return mode; }
            private set
            {
                if (context == IntPtr.Zero)
                    mode = value;
                else
                    Debug.Print("Cannot change DisplayMode of an existing context.");
            }
        }

        #endregion

        #region public void CreateContext()

        public void CreateContext()
        {
            this.CreateContext(true, null);
        }

        #endregion

        #region public void CreateContext(bool direct)

        public void CreateContext(bool direct)
        {
            this.CreateContext(direct, null);
        }

        #endregion

        #region public void CreateContext(bool direct, IGraphicsContext shareContext)

        public void CreateContext(bool direct, IGraphicsContext shareContext)
        {
            try
            {
                Debug.WriteLine("Creating opengl context.");
                Debug.Indent();

                ContextHandle shareHandle = shareContext != null ? (shareContext as IGLContextInternal).Context : (ContextHandle)IntPtr.Zero;

                Debug.Write(direct ? "Context is direct, " : "Context is indirect, ");
                Debug.WriteLine(shareHandle.Handle == IntPtr.Zero ? "not shared." :
                    String.Format("shared with ({0}).", shareHandle));

                // Try to call Glx.CreateContext with the specified parameters.
                context = Glx.CreateContext(windowInfo.Display, visual, shareHandle.Handle, direct);

                // Context creation succeeded, return.
                if (context != IntPtr.Zero)
                {
                    Debug.Print("New opengl context created. (id: {0})", context);

                    this.MakeCurrent(); 
                    GL.LoadAll();
                    Glu.LoadAll();
                    Glx.LoadAll();

                    return;
                }
                // Context creation failed. Retry with a non-shared context with the
                // direct/indirect rendering mode flipped.
                Debug.Print("Cotnext creation failed, retrying with a non-shared, {0} context.",
                    !direct ? "direct" : "indirect");
                context = Glx.CreateContext(windowInfo.Display, visual, IntPtr.Zero, !direct);
                if (context != IntPtr.Zero)
                {
                    Debug.Print("New opengl context created. (id: {0})", context);
                    
                    this.MakeCurrent(); 
                    GL.LoadAll();
                    Glu.LoadAll();
                    Glx.LoadAll();

                    return;
                }

                vsync_supported = Glx.SupportsExtension("glxSwapControlSGI");

                throw new ApplicationException("Glx.CreateContext call failed (returned 0).");
            }
            finally
            {
                Debug.Unindent();
            }
        }

        #endregion

        #region public void SwapBuffers()

        public void SwapBuffers()
        {
            Glx.SwapBuffers(windowInfo.Display, windowInfo.Handle);
        }

        #endregion

        #region public void MakeCurrent()

        bool result;
        public void MakeCurrent()
        {
            Debug.Write(String.Format("Making context {0} current on thread {1} (Display: {2}, Screen: {3}, Window: {4})... ",
                    context, System.Threading.Thread.CurrentThread.ManagedThreadId, windowInfo.Display, windowInfo.Screen, windowInfo.Handle));

            if (windowInfo.Display != IntPtr.Zero && windowInfo.Handle != IntPtr.Zero && context != IntPtr.Zero)
            {
                result = Glx.MakeCurrent(windowInfo.Display, windowInfo.Handle, context);
                
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
                    Glx.MakeCurrent(windowInfo.Display, windowInfo.Handle, context);
                else
                    Glx.MakeCurrent(windowInfo.Handle, IntPtr.Zero, IntPtr.Zero);
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
            throw new NotSupportedException("Use OpenTK.GLContext instead.");
        }

        public void DisposeResources()
        {
            throw new NotSupportedException("Use OpenTK.GLContext instead.");
        }

        public IEnumerable<DisplayMode> GetDisplayModes()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region --- IGLContextInternal Members ---

        #region IntPtr IGLContextInternal.Context

        ContextHandle IGLContextInternal.Context
        {
            get { return context; }
            /*private set { context = value; }*/
        }

        #endregion

        #region IWindowInfo IGLContextInternal.Info

        IWindowInfo IGLContextInternal.Info { get { return windowInfo; } }

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
                Glx.MakeCurrent(windowInfo.Display, IntPtr.Zero, IntPtr.Zero);
                Glx.DestroyContext(windowInfo.Display, context);
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
