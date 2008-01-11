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
    internal sealed class X11GLContext : IGLContext, IGLContextCreationHack
    {
        private IntPtr context;
        private DisplayMode mode;
        private WindowInfo windowInfo;
        private IntPtr visual;

        private bool disposed;

        #region --- Constructors ---

        /// <summary>
        /// Constructs a new X11GLContext object.
        /// </summary>
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

        #region --- IGLContext Members ---

        #region public IntPtr Context

        public IntPtr Context
        {
            get { return context; }
            private set { context = value; }
        }

        #endregion

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

        #region public IWindowInfo Info

        public IWindowInfo Info { get { return windowInfo; } }

        #endregion

        public void CreateContext()
        {
            this.CreateContext(true, null);
        }

        public void CreateContext(bool direct)
        {
            this.CreateContext(direct, null);
        }

        #region public void CreateContext(bool direct, IGLContext shareContext)

        public void CreateContext(bool direct, IGLContext shareContext)
        {
            try
            {
                Debug.WriteLine("Creating opengl context.");
                Debug.Indent();

                IntPtr shareHandle = shareContext != null ? (shareContext as X11GLContext).Context: IntPtr.Zero;

                Debug.Write(direct ? "Context is direct, " : "Context is indirect, ");
                Debug.WriteLine(shareHandle == IntPtr.Zero ? "not shared." :
                    String.Format("shared with ({0}).", shareHandle));

                // Try to call Glx.CreateContext with the specified parameters.
                context = Glx.CreateContext(windowInfo.Display, visual, shareHandle, direct);

                // Context creation succeeded, return.
                if (context != IntPtr.Zero)
                {
                    Debug.Print("New opengl context created. (id: {0})", context);

                    this.MakeCurrent(); 
                    GL.LoadAll();
                    Glu.LoadAll();
                    
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

                    return;
                }
                    
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

        public bool IsCurrent
        {
            //return GetCurrentContext() == context;
            get { throw new NotImplementedException(); }
        }

        public IntPtr GetCurrentContext()
        {
            //return Glx.GetCurrentContext();
            throw new NotImplementedException();
        }

        public event DestroyEvent<IGLContext> Destroy;

        #region public IntPtr GetAddress(string function)

        public IntPtr GetAddress(string function)
        {
            return Glx.GetProcAddress(function);
        }

        #endregion

        public void RegisterForDisposal(IDisposable resource)
        {
            throw new NotImplementedException("Use the general GLContext class instead.");
        }

        public void DisposeResources()
        {
            throw new NotImplementedException("Use the general GLContext class instead.");
        }

        public IEnumerable<DisplayMode> GetDisplayModes()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public bool VSync
        {
            get
            {
                return false;
            }
            set
            {

            }
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
