#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    /// <summary>
    /// Provides methods for creating and interacting with an OpenGL context.
    /// </summary>
    public interface IGLContext : IDisposable
    {
        /// <summary>
        /// Gets a handle to the OpenGL rendering context.
        /// </summary>
        IntPtr Context { get; }

        /// <summary>
        /// Gets the IWindowInfo describing the window associated with this context.
        /// </summary>
        IWindowInfo Info { get; }

        /// <summary>
        /// Gets the DisplayMode of the context.
        /// </summary>
        DisplayMode Mode { get; }

        /// <summary>
        /// Creates an OpenGL context.
        /// </summary>
        void CreateContext();

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
        void CreateContext(bool direct);

        /// <summary>
        /// Creates an OpenGL context with the specified direct/indirect rendering mode and sharing state with the
        /// specified IGLContext.
        /// </summary>
        /// <param name="direct">Set to true for direct rendering or false otherwise.</param>
        /// <param name="source">The source IGLContext to share state from.</param>.
        /// <seealso cref="CreateContext(bool)"/>
        void CreateContext(bool direct, IGLContext source);

        /// <summary>
        /// Swaps buffers, presenting the rendered scene to the user.
        /// </summary>
        void SwapBuffers();

        /// <summary>
        /// Makes the Context current in the calling thread, i.e. future OpenGL commands will affect this Context.
        /// </summary>
        void MakeCurrent();

        /// <summary>
        /// Gets the address of an OpenGL extension function.
        /// </summary>
        /// <param name="function">The name of the OpenGL function (e.g. "glGetString")</param>
        /// <returns>
        /// A pointer to the specified function or IntPtr.Zero if the function isn't
        /// available in the current opengl context.
        /// </returns>
        /// <see cref="Marshal.GetDelegateForFunctionPointer"/>
        IntPtr GetAddress(string function);

        /// <summary>
        /// Returns the display modes supported by the current opengl context.
        /// </summary>
        /// <returns>An IEnumerable containing all supported display modes.</returns>
        IEnumerable<DisplayMode> GetDisplayModes();

        /// <summary>
        /// Gets or sets a value indicating whether VSyncing is enabled.
        /// </summary>
        bool VSync { get; set; }
    }
}
