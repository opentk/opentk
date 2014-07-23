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
        static readonly object LoadLock = new object();

        IntPtr device_context;
        bool vsync_supported;
        bool vsync_tear_supported;

        readonly WinGraphicsMode ModeSelector;

        // We need to create a temp context in order to load
        // wgl extensions (e.g. for multisampling or GL3).
        // We cannot rely on any WGL extensions before
        // we load them with the temporary context.
        class TemporaryContext : IDisposable
        {
            public ContextHandle Context;

            public TemporaryContext(INativeWindow native)
            {
                Debug.WriteLine("[WGL] Creating temporary context to load extensions");

                if (native == null)
                    throw new ArgumentNullException();

                // Create temporary context and load WGL entry points
                // First, set a compatible pixel format to the device context
                // of the temp window
                WinWindowInfo window = native.WindowInfo as WinWindowInfo;
                WinGraphicsMode selector = new WinGraphicsMode(window.DeviceContext);
                WinGLContext.SetGraphicsModePFD(selector, GraphicsMode.Default, window);

                bool success = false;

                // Then, construct a temporary context and load all wgl extensions
                Context = new ContextHandle(Wgl.CreateContext(window.DeviceContext));
                if (Context != ContextHandle.Zero)
                {
                    // Make the context current.
                    // Note: on some video cards and on some virtual machines, wglMakeCurrent
                    // may fail with an errorcode of 6 (INVALID_HANDLE). The suggested workaround
                    // is to call wglMakeCurrent in a loop until it succeeds.
                    // See https://www.opengl.org/discussion_boards/showthread.php/171058-nVidia-wglMakeCurrent()-multiple-threads
                    // Sigh...
                    for (int retry = 0; retry < 5 && !success; retry++)
                    {
                        success = Wgl.MakeCurrent(window.DeviceContext, Context.Handle);
                        if (!success)
                        {
                            Debug.Print("wglMakeCurrent failed with error: {0}. Retrying", Marshal.GetLastWin32Error());
                            System.Threading.Thread.Sleep(10);
                        }
                    }
                }
                else
                {
                    Debug.Print("[WGL] CreateContext failed with error: {0}", Marshal.GetLastWin32Error());
                }

                if (!success)
                {
                    Debug.WriteLine("[WGL] Failed to create temporary context");
                }
            }

            public void Dispose()
            {
                if (Context != ContextHandle.Zero)
                {
                    Wgl.MakeCurrent(IntPtr.Zero, IntPtr.Zero);
                    Wgl.DeleteContext(Context.Handle);
                }
            }
        }

        #region --- Contructors ---

        public WinGLContext(GraphicsMode format, WinWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
        {
            // There are many ways this code can break when accessed by multiple threads. The biggest offender is
            // the sharedContext stuff, which will only become valid *after* this constructor returns.
            // The easiest solution is to serialize all context construction - hence the big lock, below.
            lock (LoadLock)
            {
                if (window == null)
                    throw new ArgumentNullException("window", "Must point to a valid window.");
                if (window.Handle == IntPtr.Zero)
                    throw new ArgumentException("window", "Must be a valid window.");

                IntPtr current_context = Wgl.GetCurrentContext();
                INativeWindow temp_window = null;
                TemporaryContext temp_context = null;
                try
                {
                    if (current_context == IntPtr.Zero)
                    {
                        // Create temporary context to load WGL extensions
                        temp_window = new NativeWindow();
                        temp_context = new TemporaryContext(temp_window);
                        current_context = Wgl.GetCurrentContext();
                        if (current_context != IntPtr.Zero && current_context == temp_context.Context.Handle)
                        {
                            new Wgl().LoadEntryPoints();
                        }
                    }

                    Debug.Print("OpenGL will be bound to window:{0} on thread:{1}", window.Handle,
                        System.Threading.Thread.CurrentThread.ManagedThreadId);

                    ModeSelector = new WinGraphicsMode(window.DeviceContext);
                    Mode = SetGraphicsModePFD(ModeSelector, format, (WinWindowInfo)window);

                    if (Wgl.SupportsFunction("wglCreateContextAttribsARB"))
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
                                attributes.Add((int)ArbCreateContext.ContextFlags);
                                attributes.Add((int)GetARBContextFlags(flags));
                                attributes.Add((int)ArbCreateContext.ProfileMask);
                                attributes.Add((int)GetARBContextProfile(flags));
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
                        }
                        catch (Exception e) { Debug.Print(e.ToString()); }
                    }

                    if (Handle == ContextHandle.Zero)
                    {
                        // Failed to create GL3-level context, fall back to GL2.
                        Debug.Write("Falling back to GL2... ");
                        Handle = new ContextHandle(Wgl.CreateContext(window.DeviceContext));
                        if (Handle == ContextHandle.Zero)
                            Handle = new ContextHandle(Wgl.CreateContext(window.DeviceContext));
                        if (Handle == ContextHandle.Zero)
                            throw new GraphicsContextException(
                                String.Format("Context creation failed. Wgl.CreateContext() error: {0}.",
                                    Marshal.GetLastWin32Error()));
                    }

                    Debug.WriteLine(String.Format("success! (id: {0})", Handle));
                }
                finally
                {
                    if (temp_context != null)
                    {
                        temp_context.Dispose();
                        temp_context = null;
                    }
                    if (temp_window != null)
                    {
                        temp_window.Dispose();
                        temp_window = null;
                    }
                }
            }

            // Todo: is this comment still true?
            // On intel drivers, wgl entry points appear to change
            // when creating multiple contexts. As a workaround,
            // we reload Wgl entry points every time we create a
            // new context - this solves the issue without any apparent
            // side-effects (i.e. the old contexts can still be handled
            // using the new entry points.)
            // Sigh...
            MakeCurrent(window);
            new Wgl().LoadEntryPoints();

            if (sharedContext != null)
            {
                Marshal.GetLastWin32Error();
                Debug.Write(String.Format("Sharing state with context {0}: ", sharedContext));
                bool result = Wgl.ShareLists((sharedContext as IGraphicsContextInternal).Context.Handle, Handle.Handle);
                Debug.WriteLine(result ? "success!" : "failed with win32 error " + Marshal.GetLastWin32Error());
            }
        }

        static ArbCreateContext GetARBContextFlags(GraphicsContextFlags flags)
        {
            ArbCreateContext result = 0;
            result |= (flags & GraphicsContextFlags.ForwardCompatible) != 0 ?
                ArbCreateContext.CoreProfileBit : ArbCreateContext.CompatibilityProfileBit;
            return result;
        }

        static ArbCreateContext GetARBContextProfile(GraphicsContextFlags flags)
        {
            ArbCreateContext result = 0;
            result |= (flags & GraphicsContextFlags.Debug) != 0 ? ArbCreateContext.DebugBit : 0;
            return result;
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

        #region IGraphicsContext Members

        #region SwapBuffers

        public override void SwapBuffers()
        {
            if (!Functions.SwapBuffers(DeviceContext))
                throw new GraphicsContextException(String.Format(
                    "Failed to swap buffers for context {0} current. Error: {1}", this, Marshal.GetLastWin32Error()));
        }

        #endregion

        #region MakeCurrent

        public override void MakeCurrent(IWindowInfo window)
        {
            lock (LoadLock)
            {
                bool success;

                WinWindowInfo wnd = window as WinWindowInfo;
                if (wnd != null)
                {
                    if (wnd.Handle == IntPtr.Zero)
                        throw new ArgumentException("window", "Must point to a valid window.");

                    success = Wgl.MakeCurrent(wnd.DeviceContext, Handle.Handle);
                    device_context = wnd.DeviceContext;
                }
                else
                {
                    success = Wgl.MakeCurrent(IntPtr.Zero, IntPtr.Zero);
                    device_context = IntPtr.Zero;
                }

                if (!success)
                {
                    throw new GraphicsContextException(String.Format(
                        "Failed to make context {0} current. Error: {1}", this, Marshal.GetLastWin32Error()));
                }
            }
        }

        #endregion

        #region IsCurrent

        public override bool IsCurrent
        {
            get { return Wgl.GetCurrentContext() == Handle.Handle; }
        }

        #endregion

        #region SwapInterval

        public override int SwapInterval
        {
            get
            {
                lock (LoadLock)
                {
                    if (vsync_supported)
                        return Wgl.Ext.GetSwapInterval();
                    else
                        return 0;
                }
            }
            set
            {
                lock (LoadLock)
                {
                    if (vsync_supported)
                    {
                        if (value < 0 && !vsync_tear_supported)
                        {
                            value = 1;
                        }
                        if (!Wgl.Ext.SwapInterval(value))
                        {
                            Debug.Print("wglSwapIntervalEXT call failed.");
                        }
                    }
                }
            }
        }

        #endregion

        #region void LoadAll()

        public override void LoadAll()
        {
            lock (LoadLock)
            {
                new Wgl().LoadEntryPoints();
                vsync_supported =
                    Wgl.SupportsExtension(DeviceContext, "WGL_EXT_swap_control") &&
                    Wgl.SupportsFunction("wglGetSwapIntervalEXT") &&
                    Wgl.SupportsFunction("wglSwapIntervalEXT");
                vsync_tear_supported =
                    Wgl.SupportsExtension(DeviceContext, "WGL_EXT_swap_control_tear");
            }

            base.LoadAll();
        }

        #endregion

        #endregion

        #region IGLContextInternal Members

        #region IWindowInfo IGLContextInternal.Info
        /*
        IWindowInfo IGraphicsContextInternal.Info
        {
            get { return (IWindowInfo)windowInfo; }
        }
        */
        #endregion

        #region GetAddress

        public override IntPtr GetAddress(IntPtr function_string)
        {
            IntPtr address = Wgl.GetProcAddress(function_string);
            if (!IsValid(address))
            {
                address = Functions.GetProcAddress(WinFactory.OpenGLHandle, function_string);
            }
            return address;
        }

        static bool IsValid(IntPtr address)
        {
            // See https://www.opengl.org/wiki/Load_OpenGL_Functions
            long a = address.ToInt64();
            bool is_valid = (a < -1) || (a > 3);
            return is_valid;
        }

        #endregion

        #endregion

        #region Internal Methods

        #region SetGraphicsModePFD

        // Note: there is no relevant ARB function.
        internal static GraphicsMode SetGraphicsModePFD(WinGraphicsMode mode_selector,
            GraphicsMode mode, WinWindowInfo window)
        {
            Debug.Write("Setting pixel format... ");
            if (window == null)
                throw new ArgumentNullException("window", "Must point to a valid window.");

            if (!mode.Index.HasValue)
            {
                mode = mode_selector.SelectGraphicsMode(
                    mode.ColorFormat, mode.Depth, mode.Stencil,
                    mode.Samples, mode.AccumulatorFormat,
                    mode.Buffers, mode.Stereo);
            }

            PixelFormatDescriptor pfd = new PixelFormatDescriptor();
            Functions.DescribePixelFormat(
                window.DeviceContext, (int)mode.Index.Value,
                API.PixelFormatDescriptorSize, ref pfd);

            Debug.WriteLine(mode.Index.ToString());

            if (!Functions.SetPixelFormat(window.DeviceContext, (int)mode.Index.Value, ref pfd))
            {
                throw new GraphicsContextException(String.Format(
                    "Requested GraphicsMode not available. SetPixelFormat error: {0}",
                    Marshal.GetLastWin32Error()));
            }

            return mode;
        }

        #endregion

        #region internal IntPtr DeviceContext

        internal IntPtr DeviceContext
        {
            get
            {
                return device_context;
            }
        }

        #endregion

        #endregion

        #region Overrides

        /// <summary>Returns a System.String describing this OpenGL context.</summary>
        /// <returns>A System.String describing this OpenGL context.</returns>
        public override string ToString()
        {
            return (this as IGraphicsContextInternal).Context.ToString();
        }

        #endregion

        #region IDisposable Members

        protected override void Dispose(bool calledManually)
        {
            if (!IsDisposed)
            {
                if (calledManually)
                {
                    DestroyContext();
                }
                IsDisposed = true;
            }
        }

        #region private void DestroyContext()

        private void DestroyContext()
        {
            if (Handle != ContextHandle.Zero)
            {
                try
                {
                    // This will fail if the user calls Dispose() on thread X when the context is current on thread Y.
                    if (!Wgl.DeleteContext(Handle.Handle))
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
