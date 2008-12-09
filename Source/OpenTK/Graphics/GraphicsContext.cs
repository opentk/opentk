#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using OpenTK.Platform;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Represents and provides methods to manipulate an OpenGL render context.
    /// </summary>
    public sealed class GraphicsContext : IGraphicsContext, IGraphicsContextInternal
    {
        IGraphicsContext implementation;  // The actual render context implementation for the underlying platform.
        List<IDisposable> dispose_queue = new List<IDisposable>();
        bool disposed;
        // Indicates that this context was created through external means, e.g. Tao.Sdl or GLWidget#.
        // In this case, We'll assume that the external program will manage the lifetime of this
        // context - we'll not destroy it manually.
        bool is_external;

        static bool share_contexts = true;
        static bool direct_rendering = true;
        static object context_lock = new object();        
        // Maps OS-specific context handles to GraphicsContext weak references.
        static Dictionary<ContextHandle, WeakReference> available_contexts = new Dictionary<ContextHandle, WeakReference>();

        #region public GraphicsContext(GraphicsMode format, IWindowInfo window)

        /// <summary>
        /// Constructs a new GraphicsContext with the specified format, and attaches it to the specified window.
        /// </summary>
        /// <param name="format">The OpenTK.Graphics.GraphicsMode of the GraphicsContext.</param>
        /// <param name="window">The OpenTK.Platform.IWindowInfo to attach the GraphicsContext to.</param>
        public GraphicsContext(GraphicsMode mode, IWindowInfo window)
        {
            bool designMode = false;
            if (mode == null && window == null)
                designMode = true;
            else if (mode == null) throw new ArgumentNullException("mode", "Must be a valid GraphicsMode.");
            else if (window == null) throw new ArgumentNullException("window", "Must point to a valid window.");

            Debug.Print("Creating GraphicsContext.");
            try
            {
                Debug.Indent();
                Debug.Print("GraphicsMode: {0}", mode);
                Debug.Print("IWindowInfo: {0}", window);

                IGraphicsContext shareContext = null;
                if (GraphicsContext.ShareContexts)
                {
                    lock (context_lock)
                    {
                        // A small hack to create a shared context with the first available context.
                        foreach (WeakReference r in GraphicsContext.available_contexts.Values)
                        {
                            shareContext = (IGraphicsContext)r.Target;
                            break;
                        }
                    }
                }

                if (designMode)
                    implementation = new Platform.Dummy.DummyGLContext(mode);
                else if (Configuration.RunningOnWindows)
                    implementation = new Platform.Windows.WinGLContext(mode, window, shareContext);
                else if (Configuration.RunningOnX11)
                    implementation = new Platform.X11.X11GLContext(mode, window, shareContext, DirectRendering);
                else
                    throw new PlatformNotSupportedException("Please, refer to http://www.opentk.com for more information.");

                lock (context_lock)
                {
                    available_contexts.Add((this as IGraphicsContextInternal).Context, new WeakReference(this));
                }
                //(implementation as IGraphicsContextInternal).LoadAll();
            }
            finally
            {
                Debug.Unindent();
            }
        }

        #endregion

        #region private GraphicsContext()

        private GraphicsContext()
        { }

        #endregion

        /// <summary>
        /// Attempts to create a GraphicsContext object from an existing OpenGL context.
        /// </summary>
        /// <param name="window">The window this context is bound to.</param>
        /// <returns>A new GraphicsContext object, describing the current OpenGL context.</returns>
        /// <remarks>
        /// <para>Use this function to interoperate with OpenGL contexts created outside of OpenTK.</para>
        /// <para>The new GraphicsContext is added to the list of available OpenTK contexts.
        /// Make sure to call the Dispose() method once this context is destroyed.</para>
        /// <para>You may not call this method more than once on the same context. Doing so will throw an exception.</para>
        /// </remarks>
        public static GraphicsContext CreateFromCurrentThread(IWindowInfo window)
        {
            Debug.Print("Creating context from current thread.");

            GraphicsContext context = new GraphicsContext();
            context.is_external = true;
            if (Configuration.RunningOnWindows)
                context.implementation = new OpenTK.Platform.Windows.WinGLContext(window);
            else if (Configuration.RunningOnX11)
                context.implementation = new OpenTK.Platform.X11.X11GLContext(window);
            else
                throw new PlatformNotSupportedException("Please, refer to http://www.opentk.com for more information.");

            lock (context_lock)
            {
                available_contexts.Add((context as IGraphicsContextInternal).Context, new WeakReference(context));
            }

            return context;
        }

        #region void ContextDestroyed(IGraphicsContext context, EventArgs e)

        /// <summary>
        /// Handles the Destroy event.
        /// </summary>
        /// <param name="context">The OpenTK.Platform.IGraphicsContext that was destroyed.</param>
        /// <param name="e">Not used.</param>
        void ContextDestroyed(IGraphicsContext context, EventArgs e)
        {
            this.Destroy -= ContextDestroyed;
            //available_contexts.Remove(((IGraphicsContextInternal)this).Context);
        }

        #endregion

        #region --- Public Members ---

        #region public static IGraphicsContext CurrentContext

        internal delegate ContextHandle GetCurrentContextDelegate();
        internal static GetCurrentContextDelegate GetCurrentContext;

        /// <summary>
        /// Gets or sets the current GraphicsContext in the calling thread.
        /// </summary>
        public static GraphicsContext CurrentContext
        {
            get
            {
                lock (context_lock)
                {
                    if (available_contexts.Count > 0)
                    {
                        ContextHandle handle = GetCurrentContext();
                        if (handle.Handle != IntPtr.Zero)
                            return (GraphicsContext)available_contexts[handle].Target;
                    }
                    return null;
                }
            }
            //set
            //{
            //    if (value != null)
            //        value.MakeCurrent();
            //    else if (CurrentContext != null)
            //        CurrentContext.IsCurrent = false;
            //}
        }

        #endregion

        #region public static bool ShareContexts

        /// <summary>Gets or sets a System.Boolean, indicating whether GraphicsContext resources are shared</summary>
        /// <remarks>
        /// <para>If ShareContexts is true, new GLContexts will share resources. If this value is
        /// false, new GLContexts will not share resources.</para>
        /// <para>Changing this value will not affect already created GLContexts.</para>
        /// </remarks>
        public static bool ShareContexts { get { return share_contexts; } set { share_contexts = value; } }

        #endregion

        #region public static bool DirectRendering

        /// <summary>Gets or sets a System.Boolean, indicating whether GraphicsContexts will perform direct rendering.</summary>
        /// <remarks>
        /// <para>
        /// If DirectRendering is true, new contexts will be constructed with direct rendering capabilities, if possible.
        /// If DirectRendering is false, new contexts will be constructed with indirect rendering capabilities.
        /// </para>
        /// <para>This property does not affect existing GraphicsContexts, unless they are recreated.</para>
        /// <para>
        /// This property is ignored on Operating Systems without support for indirect rendering, like Windows and OS X.
        /// </para>
        /// </remarks>
        public static bool DirectRendering
        {
            get { return direct_rendering; }
            set { direct_rendering = value; }
        }

        #endregion

        #region public static AvailableDisplayFormats


        #endregion

        #region public static void Assert()

        /// <summary>
        /// Checks if a GraphicsContext exists in the calling thread and throws a GraphicsContextException if it doesn't.
        /// </summary>
        public static void Assert()
        {
            if (GraphicsContext.CurrentContext == null)
                throw new GraphicsContextException();
        }

        #endregion

        #endregion

        #region --- IGraphicsContext Members ---

        /// <summary>
        /// Creates an OpenGL context with the specified direct/indirect rendering mode and sharing state with the
        /// specified IGraphicsContext.
        /// </summary>
        /// <param name="direct">Set to true for direct rendering or false otherwise.</param>
        /// <param name="source">The source IGraphicsContext to share state from.</param>.
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
        void CreateContext(bool direct, IGraphicsContext source)
        {
            this.Destroy += ContextDestroyed;

            lock (context_lock)
            {
                available_contexts.Add((this as IGraphicsContextInternal).Context, new WeakReference(this));
            }

            //OpenTK.Graphics.OpenGL.GL.Clear(OpenTK.Graphics.OpenGL.ClearBufferMask.ColorBufferBit);
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
        /// Makes the GraphicsContext the current rendering target.
        /// </summary>
        /// <param name="info">A System.Platform.IWindowInfo structure for the window this context is bound to.</param>
        /// <remarks>
        /// You can use this method to bind the GraphicsContext to a different window than the one it was created from.
        /// </remarks>
        public void MakeCurrent(IWindowInfo info)
        {
            implementation.MakeCurrent(info);
        }

        /// <summary>
        /// Gets a System.Boolean indicating whether this Context is current in the calling thread.
        /// </summary>
        public bool IsCurrent
        {
            get { return implementation.IsCurrent; }
            //set { implementation.IsCurrent = value; }
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

        #region --- IGraphicsContextInternal Members ---

        #region void LoadAll()

        void IGraphicsContextInternal.LoadAll()
        {
            (implementation as IGraphicsContextInternal).LoadAll();
        }

        #endregion

        /// <internal />
        /// <summary>Gets a handle to the OpenGL rendering context.</summary>
        ContextHandle IGraphicsContextInternal.Context
        {
            get { return ((IGraphicsContextInternal)implementation).Context; }
        }

        /*
        /// <summary>
        /// Gets the IWindowInfo describing the window associated with this context.
        /// </summary>
        IWindowInfo IGraphicsContextInternal.Info
        {
            get { return (implementation as IGraphicsContextInternal).Info; }
            //internal set { (implementation as IGLContextInternal).Info = value; }
        }
        */

        /// <summary>
        /// Gets the DisplayMode of the context.
        /// </summary>
        GraphicsMode IGraphicsContextInternal.GraphicsMode
        {
            get { return (implementation as IGraphicsContextInternal).GraphicsMode; }
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
        void IGraphicsContextInternal.RegisterForDisposal(IDisposable resource)
        {
            GC.KeepAlive(resource);
            dispose_queue.Add(resource);
        }

        /// <summary>
        /// Disposes all registered OpenGL resources.
        /// </summary>
        void IGraphicsContextInternal.DisposeResources()
        {
            foreach (IDisposable resource in dispose_queue)
                resource.Dispose();

            dispose_queue.Clear();
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
        IntPtr IGraphicsContextInternal.GetAddress(string function)
        {
            return (implementation as IGraphicsContextInternal).GetAddress(function);
        }

        #endregion

        #region --- IDisposable Members ---

        /// <summary>
        /// Disposes of the GraphicsContext.
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
                Debug.WriteLine("Disposing context {0}.", (this as IGraphicsContextInternal).Context.ToString());
                lock (context_lock)
                {
                    available_contexts.Remove((this as IGraphicsContextInternal).Context);
                }

                if (manual && !is_external)
                {
                    if (implementation != null)
                        implementation.Dispose();
                }
                disposed = true;
            }
        }

        //~GraphicsContext()
        //{
        //    this.Dispose(false);
        //}

        #endregion
    }

    #region public class GraphicsException : Exception

    /// <summary>Represents errors related to Graphics operations.</summary>
    public class GraphicsException : Exception
    {
        /// <summary>Constructs a new GraphicsException.</summary>
        public GraphicsException() : base() { }
        /// <summary>Constructs a new GraphicsException with the specified excpetion message.</summary>
        /// <param name="message"></param>
        public GraphicsException(string message) : base(message) { }
    }

    #endregion
}
