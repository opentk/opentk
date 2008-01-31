#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Platform;

namespace OpenTK
{
    /// <summary>
    /// Represents and provides methods to manipulate an OpenGL render context.
    /// </summary>
    public sealed class GLContext : IGraphicsContext, IGLContextInternal, IGLContextCreationHack
    {
        IGraphicsContext implementation;  // The actual render context implementation for the underlying platform.
        List<IDisposable> dispose_queue = new List<IDisposable>();
        bool disposed;

        static bool share_contexts = true;
        static object context_lock = new object();        
        static Dictionary<ContextHandle, WeakReference> available_contexts =
            new Dictionary<ContextHandle, WeakReference>();   // Contains all available OpenGL contexts.

        #region public GLContext(DisplayMode mode, IWindowInfo window)

        /// <summary>
        /// Constructs a new GLContext with the specified DisplayMode, and bound to the specified IWindowInfo.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="window"></param>
        public GLContext(DisplayMode mode, IWindowInfo window)
        {
            //if (available_contexts.Count == 0)
            //    available_contexts.Add(IntPtr.Zero, new WeakReference(null));

            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Unix:
                case (PlatformID)128:
                    implementation = new OpenTK.Platform.X11.X11GLContext();
                    break;

                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    implementation = new OpenTK.Platform.Windows.WinGLContext();
                    break;

                default:
                    throw new PlatformNotSupportedException("Your platform is not supported currently. Please, refer to http://www.opentk.com for more information.");
            }

            (this as IGLContextCreationHack).SetWindowHandle(window.Handle);
            (this as IGLContextCreationHack).SelectDisplayMode(mode, window);
            if (GLContext.ShareContexts)
            {
                lock (context_lock)
                {
                    // A small hack to create a shared context with the first available context.
                    foreach (WeakReference r in GLContext.available_contexts.Values)
                    {
                        this.CreateContext(true, (GLContext)r.Target);
                        return;
                    }
                }
            }
            // Only reached if a shared context was not created above, or if this is the first
            // context ever constructed.
            this.CreateContext(true, null);
        }

        #endregion

        #region void ContextDestroyed(IGraphicsContext context, EventArgs e)

        /// <summary>
        /// Handles the Destroy event.
        /// </summary>
        /// <param name="context">The OpenTK.Platform.IGraphicsContext that was destroyed.</param>
        /// <param name="e">Not used.</param>
        void ContextDestroyed(IGraphicsContext context, EventArgs e)
        {
            this.Destroy -= ContextDestroyed;
            available_contexts.Remove(((IGLContextInternal)this).Context);
        }

        #endregion

        #region --- Public Members ---

        #region public static IGraphicsContext CurrentContext

        internal delegate ContextHandle GetCurrentContextDelegate();
        internal static GetCurrentContextDelegate GetCurrentContext;

        /// <summary>
        /// Gets or sets the current GraphicsContext in the calling thread.
        /// </summary>
        public static GLContext CurrentContext
        {
            get
            {
                if (available_contexts.Count > 0)
                    return (GLContext)available_contexts[GetCurrentContext()].Target;
                //return (GLContext)available_contexts[((IGLContextInternal)available_contexts[IntPtr.Zero].Target).GetCurrentContext()].Target;
                return null;
                //return (GLContext)available_contexts[StaticGetCurrentContext().ToInt64()].Target;
            }
            set
            {
                if (value != null)
                    value.MakeCurrent();
                else if (CurrentContext != null)
                    CurrentContext.IsCurrent = false;
            }
        }

        #endregion

        #region public static bool ShareContexts

        /// <summary>Gets or sets a System.Boolean, indicating whether GLContexts are shared</summary>
        /// <remarks>
        /// <para>If ShareContexts is true, new GLContexts will share resources. If this value is
        /// false, new GLContexts will not share resources.</para>
        /// <para>Changing this value will not affect already created GLContexts.</para>
        /// </remarks>
        public static bool ShareContexts { get { return share_contexts; } set { share_contexts = value; } }

        #endregion

        #region public static AvailableDisplayFormats


        #endregion

        #endregion

        #region --- IGraphicsContext Members ---

        /// <summary>
        /// Creates an OpenGL context.
        /// </summary>
        public void CreateContext()
        {
            CreateContext(true, null);
        }

        /// <summary>
        /// Creates an OpenGL context with a direct or indirect rendering mode. This parameter is ignored
        /// on Windows platforms (direct mode only).
        /// </summary>
        /// <param name="direct">Set to true for direct rendering or false otherwise.</param>
        /// <remarks>
        /// <para>
        /// Direct rendering is the default rendering mode for OpenTK, since it can provide higher performance
        /// in some circumastances.
        /// </para>
        /// <para>
        /// The 'direct' parameter is a hint, and will ignored if the specified mode is not supported (e.g. setting
        /// indirect rendering on Windows platforms).
        /// </para>
        /// </remarks>
        public void CreateContext(bool direct)
        {
            CreateContext(direct, null);
        }

        /// <summary>
        /// Creates an OpenGL context with the specified direct/indirect rendering mode and sharing state with the
        /// specified IGraphicsContext.
        /// </summary>
        /// <param name="direct">Set to true for direct rendering or false otherwise.</param>
        /// <param name="source">The source IGraphicsContext to share state from.</param>.
        /// <seealso cref="CreateContext(bool)"/>
        public void CreateContext(bool direct, IGraphicsContext source)
        {
            implementation.CreateContext(direct, source);
            this.Destroy += ContextDestroyed;

            available_contexts.Add((this as IGLContextInternal).Context, new WeakReference(this));
            //if (StaticGetCurrentContext == null)
            //    StaticGetCurrentContext = implementation.GetCurrentContext;
        }

        /// <summary>
        /// Swaps buffers on a context. This presents the rendered scene to the user.
        /// </summary>
        public void SwapBuffers()
        {
            implementation.SwapBuffers();
        }

        /// <summary>
        /// Makes this context the current rendering target.
        /// </summary>
        public void MakeCurrent()
        {
            implementation.MakeCurrent();
        }

        /// <summary>
        /// Gets a System.Boolean indicating whether this Context is current in the calling thread.
        /// </summary>
        public bool IsCurrent
        {
            get { return implementation.IsCurrent; }
            set { implementation.IsCurrent = value; }
        }

        /// <summary>
        /// Raised when a Context is destroyed.
        /// </summary>
        public event DestroyEvent<IGraphicsContext> Destroy
        {
            add { implementation.Destroy += value; }
            remove { implementation.Destroy -= value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether VSync is enabled.
        /// </summary>
        public bool VSync
        {
            get { return implementation.VSync; }
            set { implementation.VSync = value;  }
        }

        #endregion

        #region --- IGLContextInternal Members ---

        /// <summary>
        /// Gets a handle to the OpenGL rendering context.
        /// </summary>
        ContextHandle IGLContextInternal.Context
        {
            get { return ((IGLContextInternal)implementation).Context; }
        }

        /// <summary>
        /// Gets the IWindowInfo describing the window associated with this context.
        /// </summary>
        IWindowInfo IGLContextInternal.Info
        {
            get { return (implementation as IGLContextInternal).Info; }
            //internal set { (implementation as IGLContextInternal).Info = value; }
        }

        /// <summary>
        /// Gets the DisplayMode of the context.
        /// </summary>
        DisplayMode IGLContextInternal.Mode
        {
            get { return (implementation as IGLContextInternal).Mode; }
        }

        ///// <summary>
        ///// Gets a System.IntPtr containing the handle to the OpenGL context which is current in the
        ///// calling thread, or IntPtr.Zero if no OpenGL context is current.
        ///// </summary>
        ///// <returns>A System.IntPtr that holds the handle to the current OpenGL context.</returns>
        //ContextHandle IGLContextInternal.GetCurrentContext()
        //{
        //    return (implementation as IGLContextInternal).GetCurrentContext();
        //}

        /// <summary>
        /// Registers an OpenGL resource for disposal.
        /// </summary>
        /// <param name="resource">The OpenGL resource to dispose.</param>
        void IGLContextInternal.RegisterForDisposal(IDisposable resource)
        {
            GC.KeepAlive(resource);
            dispose_queue.Add(resource);
        }

        /// <summary>
        /// Disposes all registered OpenGL resources.
        /// </summary>
        void IGLContextInternal.DisposeResources()
        {
            foreach (IDisposable resource in dispose_queue)
                resource.Dispose();

            dispose_queue.Clear();
        }

        /// <summary>
        /// Returns the display modes supported by the current opengl context.
        /// </summary>
        /// <returns>An IEnumerable containing all supported display modes.</returns>
        IEnumerable<DisplayMode> IGLContextInternal.GetDisplayModes()
        {
            return (implementation as IGLContextInternal).GetDisplayModes();
        }

        /// <summary>
        /// Gets the address of an OpenGL extension function.
        /// </summary>
        /// <param name="function">The name of the OpenGL function (e.g. "glGetString")</param>
        /// <returns>
        /// A pointer to the specified function or IntPtr.Zero if the function isn't
        /// available in the current opengl context.
        /// </returns>
        /// <see cref="Marshal.GetDelegateForFunctionPointer"/>
        IntPtr IGLContextInternal.GetAddress(string function)
        {
            return (implementation as IGLContextInternal).GetAddress(function);
        }

        #endregion

        #region --- IGLContextCreationHack Members ---

        bool IGLContextCreationHack.SelectDisplayMode(DisplayMode mode, IWindowInfo info)
        {
            return (implementation as IGLContextCreationHack).SelectDisplayMode(mode, info);
        }

        void IGLContextCreationHack.SetWindowHandle(IntPtr handle)
        {
            (implementation as IGLContextCreationHack).SetWindowHandle(handle);
        }

        #endregion

        #region --- IDisposable Members ---

        /// <summary>
        /// Disposes of the GLContext.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                // TODO: Check if this is safe
                //if (manual)
                {
                    implementation.Dispose();
                }
                disposed = true;
            }
        }

        ~GLContext()
        {
            this.Dispose(false);
        }

        #endregion
    }

    /// <summary>Represents errors related to Graphics operations.</summary>
    public class GraphicsException : Exception
    {
        public GraphicsException() : base() { }
        public GraphicsException(string message) : base(message) { }
    }
}