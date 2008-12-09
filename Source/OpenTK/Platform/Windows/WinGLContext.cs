#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * Contributions from Erik Ylvisaker
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;

#endregion

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Provides methods to create and control an opengl context on the Windows platform.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class WinGLContext : IGraphicsContext, IGraphicsContextInternal//, IGLContextCreationHack
    {
        //IntPtr deviceContext;
        WinWindowInfo currentWindow;
        ContextHandle renderContext;
        static IntPtr opengl32Handle;
        const string opengl32Name = "OPENGL32.DLL";
        //WinWindowInfo windowInfo = new WinWindowInfo();

        GraphicsMode format;
        //DisplayMode mode = null;
        bool vsync_supported;

        bool disposed;

        #region --- Contructors ---

        static WinGLContext()
        {
            // Set the GetCurrentContext implementation.
            // TODO: Does this belong here?
            if (GraphicsContext.GetCurrentContext == null)
                GraphicsContext.GetCurrentContext = WinGLContext.GetCurrentContext;

            // Dynamically load the OpenGL32.dll in order to use the extension loading capabilities of Wgl.
            if (opengl32Handle == IntPtr.Zero)
            {
                opengl32Handle = Functions.LoadLibrary(opengl32Name);
                if (opengl32Handle == IntPtr.Zero)
                    throw new ApplicationException(String.Format("LoadLibrary(\"{0}\") call failed with code {1}",
                                                                 opengl32Name, Marshal.GetLastWin32Error()));
                Debug.WriteLine(String.Format("Loaded opengl32.dll: {0}", opengl32Handle));
            }
        }

        public WinGLContext(GraphicsMode format, IWindowInfo window, IGraphicsContext sharedContext)
        {
            if (window == null) throw new ArgumentNullException("window", "Must point to a valid window.");

            currentWindow = (WinWindowInfo)window;
            if (currentWindow.WindowHandle == IntPtr.Zero) throw new ArgumentException("window", "Must be a valid window.");

            this.format = format;

            Debug.Print("OpenGL will be bound to handle: {0}", currentWindow.WindowHandle);

            Debug.Write("Setting pixel format... ");
            this.SetGraphicsModePFD(format, (WinWindowInfo)window);

            // Do not rely on OpenTK.Platform.Windows.Wgl - the context is not ready yet,
            // and Wgl extensions will fail to load.
            Debug.Write("Creating render context... ");
            renderContext = new ContextHandle(Wgl.Imports.CreateContext(currentWindow.DeviceContext));
            if (renderContext == ContextHandle.Zero)
                renderContext = new ContextHandle(Wgl.Imports.CreateContext(currentWindow.DeviceContext));
            if (renderContext == ContextHandle.Zero)
                throw new GraphicsContextException(String.Format("Context creation failed. Wgl.CreateContext() error: {0}.",
                                                                 Marshal.GetLastWin32Error()));

            Debug.WriteLine(String.Format("done! (id: {0})", renderContext));

            if (sharedContext != null)
            {
                Debug.Print("Sharing state with context {0}", sharedContext.ToString());
                Wgl.Imports.ShareLists((sharedContext as IGraphicsContextInternal).Context.Handle, renderContext.Handle);
            }
        }

        public WinGLContext(IWindowInfo window)
        {
            if (window == null) throw new ArgumentNullException("window");

            renderContext = new ContextHandle(Wgl.GetCurrentContext());
            if (renderContext == ContextHandle.Zero)
                throw new InvalidOperationException("No OpenGL context is current in the calling thread.");

            currentWindow = (WinWindowInfo)window;
        }

        #endregion

        #region --- IGraphicsContext Members ---

        #region public void CreateContext()

        public void CreateContext()
        {
            throw new NotSupportedException();
            //this.CreateContext(true, null);
        }

        #endregion

        #region public void CreateContext(bool direct)

        public void CreateContext(bool direct)
        {
            throw new NotSupportedException();
            //this.CreateContext(direct, null);
        }

        #endregion

        #region public void CreateContext(bool direct, IGraphicsContext source)

        public void CreateContext(bool direct, IGraphicsContext source)
        {
            throw new NotSupportedException();
        }

        #endregion

        #region public void SwapBuffers()

        public void SwapBuffers()
        {

            Functions.SwapBuffers(currentWindow.DeviceContext);
        }

        #endregion

        #region public void MakeCurrent(IWindowInfo window)

        public void MakeCurrent(IWindowInfo window)
        {
            bool success;

            if (window != null)
            {
                if (((WinWindowInfo)window).WindowHandle == IntPtr.Zero)
                    throw new ArgumentException("window", "Must point to a valid window.");
                
                currentWindow = (WinWindowInfo)window;
                success = Wgl.Imports.MakeCurrent(((WinWindowInfo)window).DeviceContext, this.renderContext.Handle);
            }
            else
                success = Wgl.Imports.MakeCurrent(IntPtr.Zero, IntPtr.Zero);

            if (!success)
                throw new GraphicsContextException(String.Format(
                    "Failed to make context {0} current. Error: {1}", this, Marshal.GetLastWin32Error()));

        }

	    #endregion

        #region public bool IsCurrent

        public bool IsCurrent
        {
            get { return Wgl.GetCurrentContext() == this.renderContext.Handle; }
            /*
            set
            {
                if (value)
                    Wgl.MakeCurrent(this.deviceContext, this.renderContext);
                else
                    Wgl.MakeCurrent(IntPtr.Zero, IntPtr.Zero);
            }
            */

        }

        #endregion

        #region public bool VSync

        /// <summary>
        /// Gets or sets a System.Boolean indicating whether SwapBuffer calls are synced to the screen refresh rate.
        /// </summary>
        public bool VSync
        {
            get
            {
                return vsync_supported && Wgl.Ext.GetSwapInterval() != 0;
            }
            set
            {
                if (vsync_supported)
                    Wgl.Ext.SwapInterval(value ? 1 : 0);
            }
        }

        #endregion

        public event DestroyEvent<IGraphicsContext> Destroy;

        #endregion

        #region --- IGLContextInternal Members ---

        #region void LoadAll()

        void IGraphicsContextInternal.LoadAll()
        {
            Wgl.LoadAll();
            GL.LoadAll();
            Glu.LoadAll();

            vsync_supported = Wgl.Arb.SupportsExtension(this, "WGL_EXT_swap_control") &&
                Wgl.Load("wglGetSwapIntervalEXT") && Wgl.Load("wglSwapIntervalEXT");
        }

        #endregion

        #region ContextHandle IGLContextInternal.Context

        ContextHandle IGraphicsContextInternal.Context
        {
            get { return renderContext; }
        }

        #endregion

        #region IWindowInfo IGLContextInternal.Info
        /*
        IWindowInfo IGraphicsContextInternal.Info
        {
            get { return (IWindowInfo)windowInfo; }
        }
        */
        #endregion

        #region GraphicsMode IGLContextInternal.GraphicsMode

        GraphicsMode IGraphicsContextInternal.GraphicsMode
        {
            get { return format; }
        }

        #endregion

        #region public IntPtr GetAddress(string function_string)

        public IntPtr GetAddress(string function_string)
        {
            return Wgl.Imports.GetProcAddress(function_string);
        }

        #endregion

        #region void IGLContextInternal.RegisterForDisposal(IDisposable resource)

        void IGraphicsContextInternal.RegisterForDisposal(IDisposable resource)
        {
            throw new NotSupportedException("Use OpenTK.GraphicsContext instead.");
        }

        #endregion

        #region void IGLContextInternal.DisposeResources()

        void IGraphicsContextInternal.DisposeResources()
        {
            throw new NotSupportedException("Use OpenTK.GraphicsContext instead.");
        }

        #endregion

        #endregion

        #region --- Private Methods ---

        #region void SetGraphicsModePFD(GraphicsMode format, WinWindowInfo window)

        void SetGraphicsModePFD(GraphicsMode mode, WinWindowInfo window)
        {
            if (mode.Index == IntPtr.Zero) throw new ArgumentException(
                "mode", "The Index (pixel format) of the GraphicsMode is not set.");
            if (window == null) throw new ArgumentNullException("window", "Must point to a valid window.");

            PixelFormatDescriptor pfd = new PixelFormatDescriptor();
            Functions.DescribePixelFormat(window.DeviceContext, (int)mode.Index,
                API.PixelFormatDescriptorSize, ref pfd);
            Debug.WriteLine(mode.Index.ToString());
            if (!Functions.SetPixelFormat(window.DeviceContext, (int)mode.Index, ref pfd))
                throw new GraphicsContextException(String.Format(
                    "Requested GraphicsMode not available. SetPixelFormat error: {0}", Marshal.GetLastWin32Error()));
        }
        #endregion

        #region void SetGraphicsModeARB(GraphicsMode format, IWindowInfo window)

        void SetGraphicsModeARB(GraphicsMode format, IWindowInfo window)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion

        #region --- Internal Methods ---

        #region internal IntPtr DeviceContext

        internal IntPtr DeviceContext
        {
            get
            {
                if (currentWindow != null)
                    return currentWindow.DeviceContext;
                return IntPtr.Zero;
            }
        }


        #endregion

        #region static ContextHandle GetCurrentContext()

        static ContextHandle GetCurrentContext()
        {
            return new ContextHandle(Wgl.GetCurrentContext());
        }

        #endregion

        #endregion

        #region --- Overrides ---

        /// <summary>Returns a System.String describing this OpenGL context.</summary>
        /// <returns>A System.String describing this OpenGL context.</returns>
        public override string ToString()
        {
            return (this as IGraphicsContextInternal).Context.ToString();
        }

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool calledManually)
        {
            if (!disposed)
            {
                DestroyContext();

                if (calledManually)
                {
                    // Safe to clean managed resources
                }
                disposed = true;
            }
        }

        ~WinGLContext()
        {
            Dispose(false);
        }

        #region private void DestroyContext()

        private void DestroyContext()
        {
            if (Destroy != null)
                Destroy(this, EventArgs.Empty);

            if (renderContext != ContextHandle.Zero)
            {
                try
                {
                    if (!Wgl.Imports.MakeCurrent(IntPtr.Zero, IntPtr.Zero))
                        Debug.Print("Failed to make OpenGL context {0} non current. Error: {1}",
                            renderContext.ToString(), Marshal.GetLastWin32Error());

                    if (!Wgl.Imports.DeleteContext(renderContext.Handle))
                        Debug.Print("Failed to destroy OpenGL context {0}. Error: {1}",
                            renderContext.ToString(), Marshal.GetLastWin32Error());
                }
                catch (AccessViolationException e)
                {
                    Debug.WriteLine("An access violation occured while destroying the OpenGL context. Please report at http://www.opentk.com.");
                    Debug.Indent();
                    Debug.Print("Marshal.GetLastWin32Error(): {0}", Marshal.GetLastWin32Error().ToString());
                    Debug.WriteLine(e.ToString());
                    Debug.Unindent();
                }
                renderContext = ContextHandle.Zero;
            }

            //if (deviceContext != IntPtr.Zero)
            //{
            //    if (!Functions.ReleaseDC(this.windowInfo.Handle, deviceContext))
            //    {
            //        //throw new ApplicationException("Could not release device context. Error: " + Marshal.GetLastWin32Error());
            //        //Debug.Print("Could not destroy the device context. Error: {0}", Marshal.GetLastWin32Error());
            //    }
            //}

            /*
            if (opengl32Handle != IntPtr.Zero)
            {
                if (!Functions.FreeLibrary(opengl32Handle))
                {
                    //throw new ApplicationException("FreeLibray call failed ('opengl32.dll'), Error: " + Marshal.GetLastWin32Error());
                    //Debug.Print("Could not release {0}. Error: {1}", opengl32Name, Marshal.GetLastWin32Error());
                }
                opengl32Handle = IntPtr.Zero;
            }
            */
        }

        #endregion

        #endregion
    }
}
