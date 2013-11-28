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

using OpenTK.Platform;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Provides methods for creating and interacting with an OpenGL context.
    /// </summary>
    public interface IGraphicsContext : IDisposable
    {
        /// <summary>Swaps buffers, presenting the rendered scene to the user.</summary>
        void SwapBuffers();

        /// <summary>Makes the GraphicsContext current in the calling thread.</summary>
        /// <param name="window">An OpenTK.Platform.IWindowInfo structure that points to a valid window.</param>
        /// <remarks>
        /// <para>OpenGL commands in one thread, affect the GraphicsContext which is current in that thread.</para>
        /// <para>It is an error to issue an OpenGL command in a thread without a current GraphicsContext.</para>
        /// </remarks>
        void MakeCurrent(IWindowInfo window);

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this instance is current in the calling thread.
        /// </summary>
        bool IsCurrent { get; }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> indicating whether this instance has been disposed.
        /// It is an error to access any instance methods if this property returns true.
        /// </summary>
        bool IsDisposed { get; }

        /// <summary>
        /// Gets or sets a value indicating whether VSync is enabled. When VSync is
        /// enabled, <see cref="SwapBuffers()"/> calls will be synced to the refresh
        /// rate of the <see cref="DisplayDevice"/> that contains improving visual
        /// quality and reducing CPU usage. However, systems that cannot maintain
        /// the requested rendering rate will suffer from large jumps in performance.
        /// This can be counteracted by increasing the <see cref="SwapInterval"/>
        /// value.
        /// </summary>
        [Obsolete("Use SwapInterval property instead.")]
        bool VSync { get; set; }

        /// <summary>
        /// Gets or sets a positive integer in the range [1, n), indicating the number of
        /// <see cref="DisplayDevice"/> refreshes between consecutive
        /// <see cref="SwapBuffers()"/> calls. The maximum value for n is
        /// implementation-dependent. The default value is 1.
        /// This value will only affect instances where <see cref="VSync"/> is enabled.
        /// Invalid values will be clamped to the valid range.
        /// </summary>
        int SwapInterval { get; set; }

        /// <summary>
        /// Updates the graphics context.  This must be called when the region the graphics context
        /// is drawn to is resized.
        /// </summary>
        /// <param name="window"></param>
        void Update(IWindowInfo window);

        /// <summary>Gets the GraphicsMode of this instance.</summary>
        GraphicsMode GraphicsMode { get; }

        /// <summary>
        /// Gets or sets a System.Boolean, indicating whether automatic error checking should be performed.
        /// </summary>
        /// <remarks>
        /// <para>It is an error to enable error checking inside a Begin()-End() region.</para>
        /// <para>This method only affects the debug version of OpenTK.dll.</para>
        /// </remarks>
        bool ErrorChecking { get; set; }

        /// <summary>
        /// Loads all OpenGL entry points. Requires this instance to be current on the calling thread.
        /// </summary>
        void LoadAll();
    }

    // Functions for internal use by OpenTK.
    // TODO: RegisterForDisposal/DisposeResources for 0.3.15 (GC & OpenGL)
    // TODO: Remove or move GetDisplayModes to another class.
    /// <summary>
    /// Provides methods to create new GraphicsContexts. Should only be used for extending OpenTK.
    /// </summary>
    public interface IGraphicsContextInternal
    {
        /// <summary>
        /// Gets the internal implementation of the current instance.
        /// </summary>
        IGraphicsContext Implementation { get; }

        /// <summary>
        /// Loads all OpenGL entry points. Requires this instance to be current on the calling thread.
        /// </summary>
        void LoadAll();

        /// <summary>
        /// Gets a handle to the OpenGL rendering context.
        /// </summary>
        ContextHandle Context { get; }

        /// <summary>
        /// Retrieves the implementation-defined address of an OpenGL function.
        /// </summary>
        /// <param name="function">The name of the OpenGL function (e.g. "glGetString")</param>
        /// <returns>
        /// A pointer to the specified function or an invalid pointer if the function is not
        /// available in the current OpenGL context. The return value and calling convention
        /// depends on the underlying platform.
        /// </returns>
        IntPtr GetAddress(string function);

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
        /// <remarks><seealso cref="GetAddress(string)"/></remarks>
        IntPtr GetAddress(IntPtr function);
    }
}
