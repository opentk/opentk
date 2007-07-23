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
    public interface IGLContext : IDisposable
    {
        /// <summary>
        /// Swaps buffers on a context.  This presents the rendered scene to the user.
        /// </summary>
        void SwapBuffers();

        /// <summary>
        /// Makes this context the current rendering target.
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
        /// <returns>An array containing all supported display modes.</returns>
        IEnumerable<DisplayMode> GetDisplayModes();
    }
}
