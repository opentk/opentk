#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
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
        bool disposed;
        // Indicates that this context was created through external means, e.g. Tao.Sdl or GLWidget#.
        // In this case, We'll assume that the external program will manage the lifetime of this
        // context - we'll not destroy it manually.
        readonly bool IsExternal;
        bool check_errors = true;

        static bool share_contexts = true;
        static bool direct_rendering = true;
        readonly static object SyncRoot = new object();        
        // Maps OS-specific context handles to GraphicsContext weak references.
        readonly static Dictionary<ContextHandle, WeakReference> available_contexts = new Dictionary<ContextHandle, WeakReference>();

        #endregion

        #region --- Constructors ---

        // Necessary to allow creation of dummy GraphicsContexts (see CreateDummyContext static method).
        GraphicsContext(ContextHandle handle)
        {
            implementation = new OpenTK.Platform.Dummy.DummyGLContext(handle);

            lock (SyncRoot)
            {
                AddContext(this);
            }
        }
        
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
            lock (SyncRoot)
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
                    Debug.Print("GraphicsContextFlags: {0}", flags);
                    Debug.Print("Requested version: {0}.{1}", major, minor);

                    IGraphicsContext shareContext = shareContext = FindSharedContext();
                    
                    // Todo: Add a DummyFactory implementing IPlatformFactory.
                    if (designMode)
                    {
                        implementation = new Platform.Dummy.DummyGLContext();
                    }
                    else
                    {
                        IPlatformFactory factory = null;
                        switch ((flags & GraphicsContextFlags.Embedded) == GraphicsContextFlags.Embedded)
                        {
                            case false: factory = Factory.Default; break;
                            case true: factory = Factory.Embedded; break;
                        }

                        // Note: this approach does not allow us to mix native and EGL contexts in the same process.
                        // This should not be a problem, as this use-case is not interesting for regular applications.
                        // Note 2: some platforms may not support a direct way of getting the current context
                        // (this happens e.g. with DummyGLContext). In that case, we use a slow fallback which
                        // iterates through all known contexts and checks if any is current (check GetCurrentContext
                        // declaration).
                        if (GetCurrentContext == null)
                        {
                            GetCurrentContext = factory.CreateGetCurrentGraphicsContext();
                        }

                        implementation = factory.CreateGLContext(mode, window, shareContext, direct_rendering, major, minor, flags);
                    }

                    AddContext(this);
                }
                finally
                {
                    Debug.Unindent();
                }
            }
        }

        /// <summary>
        /// Constructs a new GraphicsContext from a pre-existing context created outside of OpenTK.
        /// </summary>
        /// <param name="handle">The handle of the existing context. This must be a valid, unique handle that is not known to OpenTK.</param>
        /// <param name="window">The window this context is bound to. This must be a valid window obtained through Utilities.CreateWindowInfo.</param>
        /// <exception cref="GraphicsContextException">Occurs if handle is identical to a context already registered with OpenTK.</exception>
        public GraphicsContext(ContextHandle handle, IWindowInfo window)
            : this(handle, window, null, 1, 0, GraphicsContextFlags.Default)
        { }

        /// <summary>
        /// Constructs a new GraphicsContext from a pre-existing context created outside of OpenTK.
        /// </summary>
        /// <param name="handle">The handle of the existing context. This must be a valid, unique handle that is not known to OpenTK.</param>
        /// <param name="window">The window this context is bound to. This must be a valid window obtained through Utilities.CreateWindowInfo.</param>
        /// <param name="shareContext">A different context that shares resources with this instance, if any.
        /// Pass null if the context is not shared or if this is the first GraphicsContext instruct you construct.</param>
        /// <param name="major">The major version of the context (e.g. "2" for "2.1").</param>
        /// <param name="minor">The minor version of the context (e.g. "1" for "2.1").</param>
        /// <param name="flags">A bitwise combination of <see cref="GraphicsContextFlags"/> that describe this context.</param>
        /// <exception cref="GraphicsContextException">Occurs if handle is identical to a context already registered with OpenTK.</exception>
        public GraphicsContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, int major, int minor, GraphicsContextFlags flags)
        {
            lock (SyncRoot)
            {
                IsExternal = true;

                if (handle == ContextHandle.Zero)
                {
                    implementation = new OpenTK.Platform.Dummy.DummyGLContext(handle);
                }
                else if (available_contexts.ContainsKey(handle))
                {
                    throw new GraphicsContextException("Context already exists.");
                }
                else
                {
                    switch ((flags & GraphicsContextFlags.Embedded) == GraphicsContextFlags.Embedded)
                    {
                        case false: implementation = Factory.Default.CreateGLContext(handle, window, shareContext, direct_rendering, major, minor, flags); break;
                        case true: implementation = Factory.Embedded.CreateGLContext(handle, window, shareContext, direct_rendering, major, minor, flags); break;
                    }
                }

                AddContext(this);
                (this as IGraphicsContextInternal).LoadAll();
            }
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Returns a <see cref="System.String"/> representing this instance.
        /// </summary>
        /// <returns>A <see cref="System.String"/>  that contains a string representation of this instance.</returns>
        public override string ToString()
        {
            return (this as IGraphicsContextInternal).Context.ToString();
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A System.Int32 with the hash code of this instance.</returns>
        public override int GetHashCode()
        {
            return (this as IGraphicsContextInternal).Context.GetHashCode();
        }

        /// <summary>
        /// Compares two instances.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        /// <returns>True, if obj is equal to this instance; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            return (obj is GraphicsContext) &&
                (this as IGraphicsContextInternal).Context == (obj as IGraphicsContextInternal).Context;
        }

        #endregion

        #region Private Members

        static void AddContext(IGraphicsContextInternal context)
        {
            ContextHandle ctx = context.Context;
            if (!available_contexts.ContainsKey(ctx))
            {
                available_contexts.Add(ctx, new WeakReference(context));
            }
            else
            {
                Debug.Print("A GraphicsContext with handle {0} already exists.", ctx);
                Debug.Print("Did you forget to call Dispose()?");
                available_contexts[ctx] = new WeakReference(context);
            }
        }

        static void RemoveContext(IGraphicsContextInternal context)
        {
            ContextHandle ctx = context.Context;
            if (available_contexts.ContainsKey(ctx))
            {
                available_contexts.Remove(ctx);
            }
            else
            {
                Debug.Print("Tried to remove non-existent GraphicsContext handle {0}. Call Dispose() to avoid this error.", ctx);
            }
        }

        static IGraphicsContext FindSharedContext()
        {
            if (GraphicsContext.ShareContexts)
            {
                // A small hack to create a shared context with the first available context.
                foreach (WeakReference r in GraphicsContext.available_contexts.Values)
                {
                    // Fix for bug 1874: if a GraphicsContext gets finalized
                    // (but not disposed), it won't be removed from available_contexts
                    // making this return null even if another valid context exists.
                    // The workaround is to simply ignore null targets.
                    IGraphicsContext target = r.Target as IGraphicsContext;
                    if (target != null)
                        return target;
                }
            }
            return null;
        }

        #endregion

        #region --- Static Members ---

        #region public static GraphicsContext CreateDummyContext()

        /// <summary>
        /// Creates a dummy GraphicsContext to allow OpenTK to work with contexts created by external libraries.
        /// </summary>
        /// <returns>A new, dummy GraphicsContext instance.</returns>
        /// <remarks>
        /// <para>Instances created by this method will not be functional. Instance methods will have no effect.</para>
        /// <para>This method requires that a context is current on the calling thread.</para>
        /// </remarks>
        public static GraphicsContext CreateDummyContext()
        {
            ContextHandle handle = GetCurrentContext();
            if (handle == ContextHandle.Zero)
                throw new InvalidOperationException("No GraphicsContext is current on the calling thread.");

            return CreateDummyContext(handle);
        }

        /// <summary>
        /// Creates a dummy GraphicsContext to allow OpenTK to work with contexts created by external libraries.
        /// </summary>
        /// <param name="handle">The handle of a context.</param>
        /// <returns>A new, dummy GraphicsContext instance.</returns>
        /// <remarks>
        /// <para>Instances created by this method will not be functional. Instance methods will have no effect.</para>
        /// </remarks>
        public static GraphicsContext CreateDummyContext(ContextHandle handle)
        {
            if (handle == ContextHandle.Zero)
                throw new ArgumentOutOfRangeException("handle");

            return new GraphicsContext(handle);
        }

        #endregion

        #region public static void Assert()

        /// <summary>
        /// Checks if a GraphicsContext exists in the calling thread and throws a GraphicsContextMissingException if it doesn't.
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
        /// <remarks>
        /// Note: this property will not function correctly when both desktop and EGL contexts are
        /// available in the same process. This scenario is very unlikely to appear in practice.
        /// </remarks>
        public static IGraphicsContext CurrentContext
        {
            get
            {
                lock (SyncRoot)
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
        /// Swaps buffers on a context. This presents the rendered scene to the user.
        /// </summary>
        public void SwapBuffers()
        {
            implementation.SwapBuffers();
        }

        /// <summary>
        /// Makes the GraphicsContext the current rendering target.
        /// </summary>
        /// <param name="window">A valid <see cref="OpenTK.Platform.IWindowInfo" /> structure.</param>
        /// <remarks>
        /// You can use this method to bind the GraphicsContext to a different window than the one it was created from.
        /// </remarks>
        public void MakeCurrent(IWindowInfo window)
        {
            implementation.MakeCurrent(window);
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this instance is current in the calling thread.
        /// </summary>
        public bool IsCurrent
        {
            get { return implementation.IsCurrent; }
        }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this instance has been disposed.
        /// It is an error to access any instance methods if this property returns true.
        /// </summary>
        public bool IsDisposed
        {
            get { return disposed && implementation.IsDisposed; }
            private set { disposed = value; }
        }

        /// <summary>
        /// [obsolete] Use SwapInterval property instead.
        /// Gets or sets a value indicating whether VSync is enabled. When VSync is
        /// enabled, <see cref="SwapBuffers()"/> calls will be synced to the refresh
        /// rate of the <see cref="DisplayDevice"/> that contains improving visual
        /// quality and reducing CPU usage. However, systems that cannot maintain
        /// the requested rendering rate will suffer from large jumps in performance.
        /// This can be counteracted by increasing the <see cref="SwapInterval"/>
        /// value.
        /// </summary>
        [Obsolete("Use SwapInterval property instead.")]
        public bool VSync
        {
            get { return implementation.VSync; }
            set { implementation.VSync = value;  }
        }

        /// <summary>
        /// Gets or sets a positive integer in the range [1, n), indicating the number of
        /// <see cref="DisplayDevice"/> refreshes between consecutive
        /// <see cref="SwapBuffers()"/> calls. The maximum value for n is
        /// implementation-dependent. The default value is 1.
        /// This value will only affect instances where <see cref="VSync"/> is enabled.
        /// Invalid values will be clamped to the valid range.
        /// </summary>
        public int SwapInterval
        {
            get { return implementation.SwapInterval; }
            set { implementation.SwapInterval = value; }
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

        /// <summary>
        /// Loads all OpenGL entry points.
        /// </summary>
        /// <exception cref="OpenTK.Graphics.GraphicsContextException">
        /// Occurs when this instance is not current on the calling thread.
        /// </exception>
        public void LoadAll()
        {
            if (GraphicsContext.CurrentContext != this)
                throw new GraphicsContextException();

            implementation.LoadAll();
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
        /// Retrieves the implementation-defined address of an OpenGL function.
        /// </summary>
        /// <param name="function">The name of the OpenGL function (e.g. "glGetString")</param>
        /// <returns>
        /// A pointer to the specified function or an invalid pointer if the function is not
        /// available in the current OpenGL context. The return value and calling convention
        /// depends on the underlying platform.
        /// </returns>
        IntPtr IGraphicsContextInternal.GetAddress(string function)
        {
            return (implementation as IGraphicsContextInternal).GetAddress(function);
        }

        /// <summary>
        /// Retrieves the implementation-defined address of an OpenGL function.
        /// </summary>
        /// <param name="function">
        /// A pointer to a null-terminated buffer
        /// containing the name of the OpenGL function.
        /// </param>
        /// <returns>
        /// A pointer to the specified function or an invalid pointer if the function is not
        /// available in the current OpenGL context. The return value and calling convention
        /// depends on the underlying platform.
        /// </returns>
        IntPtr IGraphicsContextInternal.GetAddress(IntPtr function)
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
            if (!IsDisposed)
            {
                lock (SyncRoot)
                {
                    RemoveContext(this);
                }

                // Note: we cannot dispose the implementation
                // from a different thread. See wglDeleteContext.
                // This is also known to crash GLX implementations.
                if (manual && !IsExternal)
                {
                    Debug.Print("Disposing context {0}.", (this as IGraphicsContextInternal).Context.ToString());
                    if (implementation != null)
                        implementation.Dispose();
                }
                else
                {
                    Debug.WriteLine("GraphicsContext leaked, did you forget to call Dispose()?");
                }
                IsDisposed = true;
            }
        }

        ~GraphicsContext()
        {
            Dispose(false);
        }

        #endregion
    }
}
