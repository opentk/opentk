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
        WinWindowInfo currentWindow;
        ContextHandle renderContext;
        static IntPtr opengl32Handle;
        static bool wgl_loaded;
        const string opengl32Name = "OPENGL32.DLL";
        //WinWindowInfo windowInfo = new WinWindowInfo();

        GraphicsMode format;
        //DisplayMode mode = null;
        bool vsync_supported;

        bool disposed;

        #region --- Contructors ---

        static WinGLContext()
        {
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

        public WinGLContext(GraphicsMode format, IWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
        {
            if (window == null)
                throw new ArgumentNullException("window", "Must point to a valid window.");
            currentWindow = (WinWindowInfo)window;
            if (currentWindow.WindowHandle == IntPtr.Zero)
                throw new ArgumentException("window", "Must be a valid window.");

            this.format = format;

            Debug.Print("OpenGL will be bound to handle: {0}", currentWindow.WindowHandle);
            Debug.Write("Setting pixel format... ");
            this.SetGraphicsModePFD(format, (WinWindowInfo)window);

            if (!wgl_loaded)
            {
                // We need to create a temp context in order to load wgl extensions (e.g. for multisampling or GL3).
                // We cannot rely on OpenTK.Platform.Wgl until we create the context and call Wgl.LoadAll().
                Debug.Print("Creating temporary context for wgl extensions.");

                ContextHandle temp_context = new ContextHandle(Wgl.Imports.CreateContext(currentWindow.DeviceContext));
                Wgl.Imports.MakeCurrent(currentWindow.DeviceContext, temp_context.Handle);
                Wgl.LoadAll();
                Wgl.MakeCurrent(IntPtr.Zero, IntPtr.Zero);
                Wgl.DeleteContext(temp_context.Handle);
                wgl_loaded = true;
            }

            if (Wgl.Delegates.wglCreateContextAttribsARB != null)
            {
                try
                {
                    Debug.Write("Using WGL_ARB_create_context... ");

                    List<int> attributes = new List<int>();
                    attributes.Add((int)ArbCreateContext.MajorVersion);
                    attributes.Add(major);
                    attributes.Add((int)ArbCreateContext.MinorVersion);
                    attributes.Add(minor);
                    if (flags != 0)
                    {
                        attributes.Add((int)ArbCreateContext.Flags);
                        attributes.Add((int)flags);
                    }
                    attributes.Add(0);

                    renderContext = new ContextHandle(
                        Wgl.Arb.CreateContextAttribs(
                            currentWindow.DeviceContext,
                            sharedContext != null ? (sharedContext as IGraphicsContextInternal).Context.Handle : IntPtr.Zero,
                            attributes.ToArray()));
                    if (renderContext == ContextHandle.Zero)
                        Debug.Print("failed. (Error: {0})", Marshal.GetLastWin32Error());
                    else
                        Debug.Print("success!");
                }
                catch (EntryPointNotFoundException e) { Debug.Print(e.ToString()); }
                catch (NullReferenceException e) { Debug.Print(e.ToString()); }
            }

            if (renderContext == ContextHandle.Zero)
            {
                // Failed to create GL3-level context, fall back to GL2.
                Debug.Write("Falling back to GL2... ");
                renderContext = new ContextHandle(Wgl.Imports.CreateContext(currentWindow.DeviceContext));
                if (renderContext == ContextHandle.Zero)
                    renderContext = new ContextHandle(Wgl.Imports.CreateContext(currentWindow.DeviceContext));
                if (renderContext == ContextHandle.Zero)
                    throw new GraphicsContextException(
                        String.Format("Context creation failed. Wgl.CreateContext() error: {0}.",
                            Marshal.GetLastWin32Error()));
            }
             
            Debug.WriteLine(String.Format("success! (id: {0})", renderContext));

            if (sharedContext != null)
            {
                Debug.Print("Sharing state with context {0}", sharedContext.ToString());
                Wgl.Imports.ShareLists((sharedContext as IGraphicsContextInternal).Context.Handle, renderContext.Handle);
            }
        }

        #endregion

        #region --- IGraphicsContext Members ---

        #region public void SwapBuffers()

        public void SwapBuffers()
        {
            if (!Functions.SwapBuffers(currentWindow.DeviceContext))
                throw new GraphicsContextException(String.Format(
                    "Failed to swap buffers for context {0} current. Error: {1}", this, Marshal.GetLastWin32Error()));
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

        #region public void Update
        public void Update(IWindowInfo window)
        {
        }
        #endregion

        #region GraphicsMode IGLContext.GraphicsMode

        GraphicsMode IGraphicsContext.GraphicsMode
        {
            get { return format; }
        }

        #endregion

        public bool ErrorChecking
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public event DestroyEvent<IGraphicsContext> Destroy;

        #endregion

        #region --- IGLContextInternal Members ---

        #region Implementation

        IGraphicsContext IGraphicsContextInternal.Implementation
        {
            get { return this; }
        }

        #endregion

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
                if (calledManually)
                {
                    DestroyContext();
                }
                else
                {
                    Debug.Print("[Warning] OpenGL context {0} leaked. Did you forget to call IGraphicsContext.Dispose()?", renderContext.Handle);
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
                    // This will fail if the user calls Dispose() on thread X when the context is current on thread Y.
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
        }

        #endregion

        #endregion
    }
}
