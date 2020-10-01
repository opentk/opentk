using System;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    ///     Provides methods for querying available functions in a GLFW context.
    /// </summary>
    public class GLFWBindingsContext : IBindingsContext
    {
        /// <summary>
        ///     Retrieves an unmanaged function pointer to the specified function on the specified bindings context.
        /// </summary>
        /// <param name="procName">An ASCII-encoded string that defines the name of the function.</param>
        /// <returns>
        ///     A <see cref="System.IntPtr" /> that contains the address of procName or IntPtr.Zero,
        ///     if the function is not supported by the drivers.
        /// </returns>
        /// <remarks>
        ///     Note: some drivers are known to return non-zero values for unsupported functions.
        ///     Typical values include 1 and 2 - inheritors are advised to check for and ignore these
        ///     values.
        /// </remarks>
        public IntPtr GetProcAddress(string procName) => GLFW.GetProcAddress(procName);
    }
}
