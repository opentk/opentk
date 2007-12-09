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
    public class GLContext : IGLContext
    {
        IGLContext implementation;  // The actual render context implementation for the underlying platform.
        List<IDisposable> dispose_queue = new List<IDisposable>();
        
        static SortedList<long, WeakReference> available_contexts =
            new SortedList<long, WeakReference>();   // Contains all available OpenGL contexts.

        delegate IntPtr GetCurrentContextDelegate();
        static GetCurrentContextDelegate StaticGetCurrentContext;

        #region public GLContext(DisplayMode mode, IWindowInfo window)

        /// <summary>
        /// Constructs a new GLContext with the specified DisplayMode, and bound to the specified IWindowInfo.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="window"></param>
        public GLContext(DisplayMode mode, IWindowInfo window)
        {
            if (available_contexts.Count == 0)
                available_contexts.Add(0, new WeakReference(null));

            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Unix:
                case (PlatformID)128:
                    implementation = new OpenTK.Platform.X11.X11GLContext(mode, window);
                    break;

                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    implementation = new OpenTK.Platform.Windows.WinGLContext(mode, window);
                    break;

                default:
                    throw new PlatformNotSupportedException("Your platform is not supported currently. Please, refer to http://opentk.sourceforge.net for more information.");
            }
        }

        #endregion

        #region public static IGLContext CurrentContext

        public static GLContext CurrentContext
        {
            get { return (GLContext)available_contexts[StaticGetCurrentContext().ToInt64()].Target; }
        }

        #endregion

        #region --- IGLContext Members ---

        /// <summary>
        /// Gets a handle to the OpenGL rendering context.
        /// </summary>
        public IntPtr Context
        {
            get { return implementation.Context; }
        }

        /// <summary>
        /// Gets the IWindowInfo describing the window associated with this context.
        /// </summary>
        public IWindowInfo Info
        {
            get { return implementation.Info; }
        }

        /// <summary>
        /// Gets the DisplayMode of the context.
        /// </summary>
        public DisplayMode Mode
        {
            get { return implementation.Mode; }
        }

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
        /// specified IGLContext.
        /// </summary>
        /// <param name="direct">Set to true for direct rendering or false otherwise.</param>
        /// <param name="source">The source IGLContext to share state from.</param>.
        /// <seealso cref="CreateContext(bool)"/>
        public void CreateContext(bool direct, IGLContext source)
        {
            implementation.CreateContext(direct, source);

            available_contexts.Add(Context.ToInt64(), new WeakReference(this));
            if (StaticGetCurrentContext == null)
                StaticGetCurrentContext = implementation.GetCurrentContext;
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
        }

        /// <summary>
        /// Gets a System.IntPtr containing the handle to the OpenGL context which is current in the
        /// calling thread, or IntPtr.Zero if no OpenGL context is current.
        /// </summary>
        /// <returns>A System.IntPtr that holds the handle to the current OpenGL context.</returns>
        public IntPtr GetCurrentContext()
        {
            return implementation.GetCurrentContext();
        }

        /// <summary>
        /// Raised when a Context is destroyed.
        /// </summary>
        public event DestroyEvent<IGLContext> Destroy
        {
            add { implementation.Destroy += value; }
            remove { implementation.Destroy -= value; }
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
        public IntPtr GetAddress(string function)
        {
            return implementation.GetAddress(function);
        }

        /// <summary>
        /// Returns the display modes supported by the current opengl context.
        /// </summary>
        /// <returns>An IEnumerable containing all supported display modes.</returns>
        public IEnumerable<DisplayMode> GetDisplayModes()
        {
            return implementation.GetDisplayModes();
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
        /// Registers an OpenGL resource for disposal.
        /// </summary>
        /// <param name="resource">The OpenGL resource to dispose.</param>
        public void RegisterForDisposal(IDisposable resource)
        {
            GC.KeepAlive(resource);
            dispose_queue.Add(resource);
        }

        /// <summary>
        /// Disposes all registered OpenGL resources.
        /// </summary>
        public void DisposeResources()
        {
            foreach (IDisposable resource in dispose_queue)
            {
                resource.Dispose();
            }
            dispose_queue.Clear();
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Disposes of the GLContext.
        /// </summary>
        public void Dispose()
        {
            available_contexts.Remove(Context.ToInt64());
            implementation.Dispose();
        }

        #endregion
    }
}
