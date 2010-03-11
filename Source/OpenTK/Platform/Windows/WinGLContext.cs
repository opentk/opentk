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

using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

#endregion

namespace OpenTK.Platform.Windows
{
    /// \internal
    /// <summary>
    /// Provides methods to create and control an opengl context on the Windows platform.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class WinGLContext : DesktopGraphicsContext
    {
        static object SyncRoot = new object();

        static IntPtr opengl32Handle;
        static bool wgl_loaded;
        const string opengl32Name = "OPENGL32.DLL";

        bool vsync_supported;

        #region --- Contructors ---

        static WinGLContext()
        {
            lock (SyncRoot)
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
        }

        public WinGLContext(GraphicsMode format, WinWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
        {
            // There are many ways this code can break when accessed by multiple threads. The biggest offender is
            // the sharedContext stuff, which will only become valid *after* this constructor returns.
            // The easiest solution is to serialize all context construction - hence the big lock, below.
            lock (SyncRoot)
            {
                if (window == null)
                    throw new ArgumentNullException("window", "Must point to a valid window.");
                if (window.WindowHandle == IntPtr.Zero)
                    throw new ArgumentException("window", "Must be a valid window.");

                Mode = format;

                Debug.Print("OpenGL will be bound to handle: {0}", window.WindowHandle);
                Debug.Write("Setting pixel format... ");
                this.SetGraphicsModePFD(format, (WinWindowInfo)window);

                if (!wgl_loaded)
                {
                    // We need to create a temp context in order to load wgl extensions (e.g. for multisampling or GL3).
                    // We cannot rely on OpenTK.Platform.Wgl until we create the context and call Wgl.LoadAll().
                    Debug.Print("Creating temporary context for wgl extensions.");

                    ContextHandle temp_context = new ContextHandle(Wgl.Imports.CreateContext(window.DeviceContext));
                    Wgl.Imports.MakeCurrent(window.DeviceContext, temp_context.Handle);
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
#warning "This is not entirely correct: Embedded is not a valid flag! We need to add a GetARBContextFlags(GraphicsContextFlags) method."
                            attributes.Add((int)flags);
                        }
                        // According to the docs, " <attribList> specifies a list of attributes for the context.
                        // The list consists of a sequence of <name,value> pairs terminated by the
                        // value 0. [...]"
                        // Is this a single 0, or a <0, 0> pair? (Defensive coding: add two zeroes just in case).
                        attributes.Add(0);
                        attributes.Add(0);

                        Handle = new ContextHandle(
                            Wgl.Arb.CreateContextAttribs(
                                window.DeviceContext,
                                sharedContext != null ? (sharedContext as IGraphicsContextInternal).Context.Handle : IntPtr.Zero,
                                attributes.ToArray()));
                        if (Handle == ContextHandle.Zero)
                            Debug.Print("failed. (Error: {0})", Marshal.GetLastWin32Error());
                        else
                            Debug.Print("success!");
                    }
                    catch (EntryPointNotFoundException e) { Debug.Print(e.ToString()); }
                    catch (NullReferenceException e) { Debug.Print(e.ToString()); }
                }

                if (Handle == ContextHandle.Zero)
                {
                    // Failed to create GL3-level context, fall back to GL2.
                    Debug.Write("Falling back to GL2... ");
                    Handle = new ContextHandle(Wgl.Imports.CreateContext(window.DeviceContext));
                    if (Handle == ContextHandle.Zero)
                        Handle = new ContextHandle(Wgl.Imports.CreateContext(window.DeviceContext));
                    if (Handle == ContextHandle.Zero)
                        throw new GraphicsContextException(
                            String.Format("Context creation failed. Wgl.CreateContext() error: {0}.",
                                Marshal.GetLastWin32Error()));
                }

                Debug.WriteLine(String.Format("success! (id: {0})", Handle));

                if (sharedContext != null)
                {
                    Debug.Print("Sharing state with context {0}", sharedContext.ToString());
                    Wgl.Imports.ShareLists((sharedContext as IGraphicsContextInternal).Context.Handle, Handle.Handle);
                }
            }
        }

        public WinGLContext(ContextHandle handle, WinWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
        {
            if (handle == ContextHandle.Zero)
                throw new ArgumentException("handle");
            if (window == null)
                throw new ArgumentNullException("window");

            Handle = handle;
        }

        #endregion

        #region --- IGraphicsContext Members ---

        #region SwapBuffers

        public override void SwapBuffers()
        {
            if (!Functions.SwapBuffers(Wgl.GetCurrentDC()))
                throw new GraphicsContextException(String.Format(
                    "Failed to swap buffers for context {0} current. Error: {1}", this, Marshal.GetLastWin32Error()));
        }

        #endregion

        #region MakeCurrent

        public override void MakeCurrent(IWindowInfo window)
        {
            bool success;

            if (window != null)
            {
                if (((WinWindowInfo)window).WindowHandle == IntPtr.Zero)
                    throw new ArgumentException("window", "Must point to a valid window.");

                success = Wgl.Imports.MakeCurrent(((WinWindowInfo)window).DeviceContext, Handle.Handle);
            }
            else
                success = Wgl.Imports.MakeCurrent(IntPtr.Zero, IntPtr.Zero);

            if (!success)
                throw new GraphicsContextException(String.Format(
                    "Failed to make context {0} current. Error: {1}", this, Marshal.GetLastWin32Error()));

        }
        #endregion

        #region IsCurrent

        public override bool IsCurrent
        {
            get { return Wgl.GetCurrentContext() == Handle.Handle; }
        }

        #endregion

        #region public bool VSync

        /// <summary>
        /// Gets or sets a System.Boolean indicating whether SwapBuffer calls are synced to the screen refresh rate.
        /// </summary>
        public override bool VSync
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

        #endregion

        #region --- IGLContextInternal Members ---

        #region void LoadAll()

        public override void LoadAll()
        {
            Wgl.LoadAll();
            vsync_supported = Wgl.Arb.SupportsExtension(this, "WGL_EXT_swap_control") &&
                Wgl.Load("wglGetSwapIntervalEXT") && Wgl.Load("wglSwapIntervalEXT");

            base.LoadAll();
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

        #region GetAddress

        public override IntPtr GetAddress(string function_string)
        {
            return Wgl.Imports.GetProcAddress(function_string);
        }

        #endregion

        #endregion

        #region --- Private Methods ---

        #region void SetGraphicsModePFD(GraphicsMode format, WinWindowInfo window)

        void SetGraphicsModePFD(GraphicsMode mode, WinWindowInfo window)
        {
            if (!mode.Index.HasValue)
                throw new GraphicsModeException("Invalid or unsupported GraphicsMode.");

            if (window == null) throw new ArgumentNullException("window", "Must point to a valid window.");

            PixelFormatDescriptor pfd = new PixelFormatDescriptor();
            Functions.DescribePixelFormat(window.DeviceContext, (int)mode.Index.Value,
                API.PixelFormatDescriptorSize, ref pfd);
            Debug.WriteLine(mode.Index.ToString());
            if (!Functions.SetPixelFormat(window.DeviceContext, (int)mode.Index.Value, ref pfd))
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
                return Wgl.GetCurrentDC();
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

        public override void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool calledManually)
        {
            if (!IsDisposed)
            {
                if (calledManually)
                {
                    DestroyContext();
                }
                else
                {
                    Debug.Print("[Warning] OpenGL context {0} leaked. Did you forget to call IGraphicsContext.Dispose()?",
                        Handle.Handle);
                }
                IsDisposed = true;
            }
        }

        ~WinGLContext()
        {
            Dispose(false);
        }

        #region private void DestroyContext()

        private void DestroyContext()
        {
            if (Handle != ContextHandle.Zero)
            {
                try
                {
                    // This will fail if the user calls Dispose() on thread X when the context is current on thread Y.
                    if (!Wgl.Imports.DeleteContext(Handle.Handle))
                        Debug.Print("Failed to destroy OpenGL context {0}. Error: {1}",
                            Handle.ToString(), Marshal.GetLastWin32Error());
                }
                catch (AccessViolationException e)
                {
                    Debug.WriteLine("An access violation occured while destroying the OpenGL context. Please report at http://www.opentk.com.");
                    Debug.Indent();
                    Debug.Print("Marshal.GetLastWin32Error(): {0}", Marshal.GetLastWin32Error().ToString());
                    Debug.WriteLine(e.ToString());
                    Debug.Unindent();
                }
                Handle = ContextHandle.Zero;
            }
        }

        #endregion

        #endregion
    }
}
