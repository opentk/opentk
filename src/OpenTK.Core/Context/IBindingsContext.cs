using System;

namespace OpenTK
{
    /// <summary>
    /// Provides methods for querying available functions in a bindings context.
    /// </summary>
    /// <remarks>
    /// If you wish to use OpenTK OpenGL bindings in a custom environment see
    /// the example for a tutorial on its usage.
    /// </remarks>
    /// <example>
    /// In order to use this interface, you need to figure out how to load OpenGL
    /// function pointers in your custom environment. For example, if you are
    /// providing a custom window using SDL, you would use the C function
    /// <c>SDL_GL_GetProcAddress</c> to implement this interface.
    ///
    /// <code>
    /// using System;
    /// using System.Runtime.InteropServices;
    /// using OpenTK;
    /// using OpenTK.Graphics.OpenGL4;
    ///
    /// public class MySDLBindingsContext : IBindingsContext
    /// {
    ///     public IntPtr GetProcAddress(string procName)
    ///     {
    ///         [DllImport("SDL2")]
    ///         extern static IntPtr SDL_GL_GetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procName);
    ///
    ///         return SDL_GL_GetProcAddress(procName);
    ///     }
    /// }
    ///
    /// /// ...
    ///
    /// // In order to load the bindings, call the following function with this
    /// // new class you implemented.
    /// GL.LoadBindings(new MySDLBindingsContext());
    /// </code>
    ///
    /// Do note that every OpenTK.Graphics.XXX namespace has its own pointer table.
    /// If you have mixed and matched the namespaces used in your project, you might
    /// run into exceptions telling you that the bindings are not loaded.
    /// </example>
    public interface IBindingsContext
    {
        /// <summary>
        /// Retrieves an unmanaged function pointer to the specified function on the specified bindings context.
        /// </summary>
        /// <param name="procName">An ASCII-encoded string that defines the name of the function.</param>
        /// <returns>
        /// A <see cref="System.IntPtr"/> that contains the address of procName or IntPtr.Zero,
        /// if the function is not supported by the drivers.
        /// </returns>
        /// <remarks>
        /// Note: some drivers are known to return non-zero values for unsupported functions.
        /// Typical values include 1 and 2 - inheritors are advised to check for and ignore these
        /// values.
        /// </remarks>
        IntPtr GetProcAddress(string procName);
    }
}
