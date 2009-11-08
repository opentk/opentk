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

using OpenTK.Graphics;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Provides methods to create and control an opengl context on the X11 platform.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class X11GLContext : DesktopGraphicsContext
    {
        #region Fields

        // We assume that we cannot move a GL context to a different display connection.
        // For this reason, we'll "lock" onto the display of the window used in the context
        // constructor and we'll throw an exception if the user ever tries to make the context
        // current on window originating from a different display.
        IntPtr display;
        X11WindowInfo currentWindow;
        bool vsync_supported;
        int vsync_interval;
        bool glx_loaded;

        #endregion

        #region --- Constructors ---

        public X11GLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shared, bool direct,
            int major, int minor, GraphicsContextFlags flags)
        {
            if (mode == null)
                throw new ArgumentNullException("mode");
            if (window == null)
                throw new ArgumentNullException("window");

            Mode = mode;

            // Do not move this lower, as almost everything requires the Display
            // property to be correctly set.
            Display = ((X11WindowInfo)window).Display;
            
            currentWindow = (X11WindowInfo)window;
            currentWindow.VisualInfo = SelectVisual(mode, currentWindow);
            
            ContextHandle shareHandle = shared != null ?
                (shared as IGraphicsContextInternal).Context : (ContextHandle)IntPtr.Zero;
            
            Debug.Write("Creating X11GLContext context: ");
            Debug.Write(direct ? "direct, " : "indirect, ");
            Debug.WriteLine(shareHandle.Handle == IntPtr.Zero ? "not shared... " :
                String.Format("shared with ({0})... ", shareHandle));
            
            if (!glx_loaded)
            {
                Debug.WriteLine("Creating temporary context to load GLX extensions.");
                
                // Create a temporary context to obtain the necessary function pointers.
                XVisualInfo visual = currentWindow.VisualInfo;
                IntPtr ctx = Glx.CreateContext(Display, ref visual, IntPtr.Zero, true);
                if (ctx == IntPtr.Zero)
                    ctx = Glx.CreateContext(Display, ref visual, IntPtr.Zero, false);
                
                if (ctx != IntPtr.Zero)
                {
                    new Glx().LoadEntryPoints();
                    Glx.MakeCurrent(Display, IntPtr.Zero, IntPtr.Zero);
                    //Glx.DestroyContext(Display, ctx);
                    glx_loaded = true;
                }
            }
            
            // Try using the new context creation method. If it fails, fall back to the old one.
            // For each of these methods, we try two times to create a context:
            // one with the "direct" flag intact, the other with the flag inversed.
            // HACK: It seems that Catalyst 9.1 - 9.4 on Linux have problems with contexts created through
            // GLX_ARB_create_context, including hideous input lag, no vsync and other. Use legacy context
            // creation if the user doesn't request a 3.0+ context.
            if ((major * 10 + minor >= 30) && Glx.Delegates.glXCreateContextAttribsARB != null)
            {
                Debug.Write("Using GLX_ARB_create_context... ");
                
                unsafe
                {
                    // We need the FB config for the current GraphicsMode.
                    int count;
                    IntPtr* fbconfigs = Glx.ChooseFBConfig(Display, currentWindow.Screen,
                        new int[] {
                        (int)GLXAttribute.VISUAL_ID,
                        (int)mode.Index,
                        0
                    }, out count);
                    
                    if (count > 0)
                    {
                        List<int> attributes = new List<int>();
                        attributes.Add((int)ArbCreateContext.MajorVersion);
                        attributes.Add(major);
                        attributes.Add((int)ArbCreateContext.MinorVersion);
                        attributes.Add(minor);
                        if (flags != 0)
                        {
#warning "This is not entirely correct: Embedded is not a valid flag! We need to add a GetARBContextFlags(GraphicsContextFlags) method."
                            attributes.Add((int)ArbCreateContext.Flags);
                            attributes.Add((int)flags);
                        }
                        // According to the docs, " <attribList> specifies a list of attributes for the context.
                        // The list consists of a sequence of <name,value> pairs terminated by the
                        // value 0. [...]"
                        // Is this a single 0, or a <0, 0> pair? (Defensive coding: add two zeroes just in case).
                        attributes.Add(0);
                        attributes.Add(0);
                        
                        Handle = new ContextHandle(Glx.Arb.CreateContextAttribs(Display, *fbconfigs,
                                shareHandle.Handle, direct, attributes.ToArray()));
                        
                        if (Handle == ContextHandle.Zero)
                        {
                            Debug.Write(String.Format("failed. Trying direct: {0}... ", !direct));
                            Handle = new ContextHandle(Glx.Arb.CreateContextAttribs(Display, *fbconfigs,
                                    shareHandle.Handle, !direct, attributes.ToArray()));
                        }
                        
                        if (Handle == ContextHandle.Zero)
                            Debug.WriteLine("failed.");
                        else
                            Debug.WriteLine("success!");
                        
                        using (new XLock(Display))
                        {
                            Functions.XFree((IntPtr)fbconfigs);
                        }
                    }
                }
            }
            
            if (Handle == ContextHandle.Zero)
            {
                Debug.Write("Using legacy context creation... ");
                
                XVisualInfo info = currentWindow.VisualInfo;
                // Cannot pass a Property by reference.
                Handle = new ContextHandle(Glx.CreateContext(Display, ref info, shareHandle.Handle, direct));
                
                if (Handle == ContextHandle.Zero)
                {
                    Debug.WriteLine(String.Format("failed. Trying direct: {0}... ", !direct));
                    Handle = new ContextHandle(Glx.CreateContext(Display, ref info, IntPtr.Zero, !direct));
                }
            }
            
            if (Handle != ContextHandle.Zero)
                Debug.Print("Context created (id: {0}).", Handle);
            else
                throw new GraphicsContextException("Failed to create OpenGL context. Glx.CreateContext call returned 0.");
            
            if (!Glx.IsDirect(Display, Handle.Handle))
                Debug.Print("Warning: Context is not direct.");
        }

        public X11GLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shared, bool direct,
            int major, int minor, GraphicsContextFlags flags)
        {
            if (handle == ContextHandle.Zero)
                throw new ArgumentException("handle");
            if (window == null)
                throw new ArgumentNullException("window");

            Handle = handle;
            currentWindow = (X11WindowInfo)window;
            Display = currentWindow.Display;
        }

        #endregion

        #region --- Private Methods ---

        IntPtr Display
        {
            get { return display; }
            set
            {
                if (value == IntPtr.Zero)
                    throw new ArgumentOutOfRangeException();
                if (display != IntPtr.Zero)
                    throw new InvalidOperationException("The display connection may not be changed after being set.");
                display = value;
            }
        }

        #region XVisualInfo SelectVisual(GraphicsMode mode, X11WindowInfo currentWindow)

        XVisualInfo SelectVisual(GraphicsMode mode, X11WindowInfo currentWindow)
        {
            XVisualInfo info = new XVisualInfo();
            info.VisualID = (IntPtr)mode.Index;
            info.Screen = currentWindow.Screen;
            int items;
            
            lock (API.Lock)
            {
                IntPtr vs = Functions.XGetVisualInfo(Display, XVisualInfoMask.ID | XVisualInfoMask.Screen, ref info, out items);
                if (items == 0)
                    throw new GraphicsModeException(String.Format("Invalid GraphicsMode specified ({0}).", mode));

                info = (XVisualInfo)Marshal.PtrToStructure(vs, typeof(XVisualInfo));
                Functions.XFree(vs);
            }

            return info;
        }

        #endregion

        bool SupportsExtension(X11WindowInfo window, string e)
        {
            if (window == null)
                throw new ArgumentNullException("window");
            if (e == null)
                throw new ArgumentNullException("e");
            if (window.Display != Display)
                throw new InvalidOperationException();

            string extensions = Glx.QueryExtensionsString(Display, window.Screen);
            return !String.IsNullOrEmpty(extensions) && extensions.Contains(e);
        }

        #endregion

        #region --- IGraphicsContext Members ---

        #region SwapBuffers()

        public override void SwapBuffers()
        {
            if (Display == IntPtr.Zero || currentWindow.WindowHandle == IntPtr.Zero)
                throw new InvalidOperationException(
                    String.Format("Window is invalid. Display ({0}), Handle ({1}).", Display, currentWindow.WindowHandle));
            Glx.SwapBuffers(Display, currentWindow.WindowHandle);
        }

        #endregion

        #region MakeCurrent

        public override void MakeCurrent(IWindowInfo window)
        {
            if (window == currentWindow && IsCurrent)
                return;

            if (window != null && ((X11WindowInfo)window).Display != Display)
                throw new InvalidOperationException("MakeCurrent() may only be called on windows originating from the same display that spawned this GL context.");

            if (window == null)
            {
                Glx.MakeCurrent(Display, IntPtr.Zero, IntPtr.Zero);
            }
            else
            {
                X11WindowInfo w = (X11WindowInfo)window;
                bool result;

                Debug.Write(String.Format("Making context {0} current on thread {1} (Display: {2}, Screen: {3}, Window: {4})... ",
                        Handle, System.Threading.Thread.CurrentThread.ManagedThreadId, Display, w.Screen, w.WindowHandle));

                if (Display == IntPtr.Zero || w.WindowHandle == IntPtr.Zero || Handle == ContextHandle.Zero)
                    throw new InvalidOperationException("Invalid display, window or context.");

                result = Glx.MakeCurrent(Display, w.WindowHandle, Handle);

                if (!result)
                    throw new GraphicsContextException("Failed to make context current.");
                else
                    Debug.WriteLine("done!");
            }

            currentWindow = (X11WindowInfo)window;
        }

        #endregion

        #region IsCurrent

        public override bool IsCurrent
        {
            get { return Glx.GetCurrentContext() == Handle.Handle; }
        }

        #endregion

        #region VSync

        public override bool VSync
        {
            get
            {
                return vsync_supported && vsync_interval != 0;
            }
            set
            {
                if (vsync_supported)
                {
                    ErrorCode error_code = Glx.Sgi.SwapInterval(value ? 1 : 0);
                    if (error_code != X11.ErrorCode.NO_ERROR)
                        Debug.Print("VSync = {0} failed, error code: {1}.", value, error_code);
                    vsync_interval = value ? 1 : 0;
                }
            }
        }

        #endregion

        #region GetAddress

        public override IntPtr GetAddress(string function)
        {
            return Glx.GetProcAddress(function);
        }

        #endregion

        #endregion

        #region --- IGLContextInternal Members ---

        #region LoadAll

        public override void LoadAll()
        {
            new Glx().LoadEntryPoints();
            vsync_supported = this.GetAddress("glXSwapIntervalSGI") != IntPtr.Zero;
            Debug.Print("Context supports vsync: {0}.", vsync_supported);

            base.LoadAll();
        }

        #endregion

        #region IWindowInfo IGLContextInternal.Info

        //IWindowInfo IGraphicsContextInternal.Info { get { return window; } }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public override void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manuallyCalled)
        {
            if (!IsDisposed)
            {
                if (manuallyCalled)
                {
                    IntPtr display = Display;
                    if (IsCurrent)
                        MakeCurrent(null);

                    Glx.DestroyContext(display, Handle);
                }
                else
                {
                    Debug.Print("[Warning] {0} leaked.", this.GetType().Name);
                }
                IsDisposed = true;
            }
        }

        ~X11GLContext()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
