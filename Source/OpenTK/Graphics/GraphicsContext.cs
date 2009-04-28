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
        #region --- Fields ---

        IGraphicsContext implementation;  // The actual render context implementation for the underlying platform.
        List<IDisposable> dispose_queue = new List<IDisposable>();
        bool disposed;
        // Indicates that this context was created through external means, e.g. Tao.Sdl or GLWidget#.
        // In this case, We'll assume that the external program will manage the lifetime of this
        // context - we'll not destroy it manually.
        //bool is_external;
        bool check_errors = true;

        static bool share_contexts = true;
        static bool direct_rendering = true;
        readonly static object context_lock = new object();        
        // Maps OS-specific context handles to GraphicsContext weak references.
        readonly static Dictionary<ContextHandle, WeakReference> available_contexts = new Dictionary<ContextHandle, WeakReference>();

        #endregion

        #region --- Constructors ---

        // Necessary to allow creation of dummy GraphicsContexts (see CreateDummyContext static method).
        GraphicsContext() { }

        /// <summary>
        /// Constructs a new GraphicsContext with the specified GraphicsMode and attaches it to the specified window.
        /// </summary>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the GraphicsContext.</param>
        /// <param name="window">The OpenTK.Platform.IWindowInfo to attach the GraphicsContext to.</param>
        public GraphicsContext(GraphicsMode mode, IWindowInfo window)
            : this(mode, window, 1, 0, GraphicsContextFlags.Default)
        { }

        /// <summary>
        /// Constructs a new GraphicsContext with the specified GraphicsMode, version and flags,  and attaches it to the specified window.
        /// </summary>
        /// <param name="mode">The OpenTK.Graphics.GraphicsMode of the GraphicsContext.</param>
        /// <param name="window">The OpenTK.Platform.IWindowInfo to attach the GraphicsContext to.</param>
        /// <param name="major">The major version of the new GraphicsContext.</param>
        /// <param name="minor">The minor version of the new GraphicsContext.</param>
        /// <param name="flags">The GraphicsContextFlags for the GraphicsContext.</param>
        /// <remarks>
        /// Different hardware supports different flags, major and minor versions. Invalid parameters will be silently ignored.
        /// </remarks>
        public GraphicsContext(GraphicsMode mode, IWindowInfo window, int major, int minor, GraphicsContextFlags flags)
        {
            bool designMode = false;
            if (mode == null && window == null)
                designMode = true;
            else if (mode == null) throw new ArgumentNullException("mode", "Must be a valid GraphicsMode.");
            else if (window == null) throw new ArgumentNullException("window", "Must point to a valid window.");

            // Silently ignore invalid major and minor versions.
            if (major <= 0)
                major = 1;
            if (minor < 0)
                minor = 0;

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

                // Todo: Add a DummyFactory implementing IPlatformFactory.
                if (designMode)
                    implementation = new Platform.Dummy.DummyGLContext(mode);
                else
                    implementation = Factory.CreateGLContext(mode, window, shareContext, DirectRendering, major, minor, flags);

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

        #region --- Static Members ---

        #region public static GraphicsContext CreateDummyContext()

        /// <summary>
        /// Creates a dummy GraphicsContext to allow OpenTK to work with contexts created by external libraries.
        /// </summary>
        /// <returns>A new, dummy GraphicsContext instance.</returns>
        /// <remarks>
        /// <para>Instances created by this methodwill not be functional. Instance methods will have no effect.</para>
        /// </remarks>
        public static GraphicsContext CreateDummyContext()
        {
            GraphicsContext context = new GraphicsContext();
            context.implementation = new OpenTK.Platform.Dummy.DummyGLContext(GraphicsMode.Default);

            lock (context_lock)
            {
                available_contexts.Add((context as IGraphicsContextInternal).Context, new WeakReference(context));
            }

            return context;
        }

        #endregion

        #region public static void Assert()

        /// <summary>
        /// Checks if a GraphicsContext exists in the calling thread and throws a GraphicsContextException if it doesn't.
        /// </summary>
        /// <exception cref="GraphicsContextMissingException">Generated when no GraphicsContext is current in the calling thread.</exception>
        public static void Assert()
        {
            if (GraphicsContext.CurrentContext == null)
                throw new GraphicsContextMissingException();
        }

        #endregion

        #region public static IGraphicsContext CurrentContext

        internal delegate ContextHandle GetCurrentContextDelegate();
        internal static GetCurrentContextDelegate GetCurrentContext;

        /// <summary>
        /// Gets the GraphicsContext that is current in the calling thread.
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

        #endregion

        #region --- Internal Members ---

        bool inside_begin_region;
        List<ErrorCode> error_list = new List<ErrorCode>();

        // Indicates that we entered a GL.Begin() - GL.End() region.
        [Conditional("DEBUG")]
        internal void EnterBeginRegion()
        {
            inside_begin_region = true;
        }

        // Indicates that we left a GL.Begin() - GL.End() region.
        [Conditional("DEBUG")]
        internal void ExitBeginRegion()
        {
            inside_begin_region = false;
        }

        // Retrieve all OpenGL errors to clear the error list.
        // See http://www.opengl.org/documentation/specs/man_pages/hardcopy/GL/html/gl/geterror.html
        [Conditional("DEBUG")]
        internal void ResetErrors()
        {
            if (check_errors && !inside_begin_region)
            {
                while (GL.GetError() != ErrorCode.NoError)
                { }
            }
        }

        // Retrieve all OpenGL errors and throw an exception if anything other than NoError is returned.
        [Conditional("DEBUG")]
        internal void CheckErrors()
        {
            if (check_errors && !inside_begin_region)
            {
                error_list.Clear();
                ErrorCode error;
                do
                {
                    error = GL.GetError();
                    error_list.Add(error);
                } while (error != ErrorCode.NoError);

                if (error_list.Count != 1)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (ErrorCode e in error_list)
                    {
                        if (e != ErrorCode.NoError)
                        {
                            sb.Append(e.ToString());
                            sb.Append(", ");
                        }
                        else
                            break;
                    }
                    sb.Remove(sb.Length - 2, 2); // Remove the last comma

                    throw new OpenGLErrorException(sb.ToString());
                }
            }
        }

        #endregion

        #region --- Private Members ---

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

        #endregion

        #region --- IGraphicsContext Members ---

        /// <summary>
        /// Gets or sets a System.Boolean, indicating whether automatic error checking should be performed.
        /// Influences the debug version of OpenTK.dll, only.
        /// </summary>
        /// <remarks>Automatic error checking will clear the OpenGL error state. Set CheckErrors to false if you use
        /// the OpenGL error state in your code flow (e.g. for checking supported texture formats).</remarks>
        public bool ErrorChecking
        {
            get { return check_errors; }
            set { check_errors = value; }
        }
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

        /// <summary>
        /// Updates the graphics context.  This must be called when the render target
        /// is resized for proper behavior on Mac OS X.
        /// </summary>
        /// <param name="window"></param>
        public void Update(IWindowInfo window)
        {
            implementation.Update(window);
        }
        
        #endregion

        #region --- IGraphicsContextInternal Members ---

        /// <summary>
        /// Gets the platform-specific implementation of this IGraphicsContext.
        /// </summary>
        IGraphicsContext IGraphicsContextInternal.Implementation
        {
            get { return implementation; }
        }

        /// <summary>
        /// Loads all OpenGL extensions.
        /// </summary>
        void IGraphicsContextInternal.LoadAll()
        {
            (implementation as IGraphicsContextInternal).LoadAll();
        }

        /// <summary>
        /// Gets a handle to the OpenGL rendering context.
        /// </summary>
        ContextHandle IGraphicsContextInternal.Context
        {
            get { return ((IGraphicsContextInternal)implementation).Context; }
        }

        /// <summary>
        /// Gets the GraphicsMode of the context.
        /// </summary>
        public GraphicsMode GraphicsMode
        {
            get { return (implementation as IGraphicsContext).GraphicsMode; }
        }

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

                if (manual)
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

    #region class GraphicsErrorException : GraphicsException

    // This is private by design. These exceptions are only thrown in debug builds of
    // OpenTK and the user should *not* handle them.
    // If some specific OpenGL error is generated by design, the user should
    // turn off automatic error checking for that portion of the code, using
    // 'GraphicsContext.ErrorChecking = false'.
    class OpenGLErrorException : GraphicsException
    {
        public OpenGLErrorException(string message) : base(message) { }
    }

    #endregion
}
