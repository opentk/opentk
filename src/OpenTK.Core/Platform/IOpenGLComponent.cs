using System;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Interface for drivers which provide the PAL OpenGL Component.
    /// </summary>
    public interface IOpenGLComponent
    {
        /// <summary>
        /// Create an OpenGL context for a window.
        /// </summary>
        /// <returns>An OpenGL context handle.</returns>
        OpenGLContextHandle CreateFromWindow(/* TODO: determine arguments. */);

        /// <summary>
        /// Create and OpenGL context for a surface.
        /// </summary>
        /// <returns>An OpenGL context handle.</returns>
        OpenGLContextHandle CreateFromSurface(/* TODO: determine arguments. */);

        /// <summary>
        /// Destroy an OpenGL context.
        /// </summary>
        /// <param name="handle">Handle to the OpenGL context to destroy.</param>
        /// <exception cref="ArgumentNullException">OpenGL context handle is null.</exception>
        void DestroyContext(OpenGLContextHandle handle);

        /// <summary>
        /// Get the procedure address for an OpenGL command.
        /// </summary>
        /// <param name="handle">Handle to an OpenGL context.</param>
        /// <param name="procedureName">Name of the OpenGL command.</param>
        /// <returns>The procedure address to the OpenGL command.</returns>
        /// <exception cref="ArgumentNullException">OpenGL context handle or procedure name is null.</exception>
        IntPtr GetProcedureAddress(OpenGLContextHandle handle, string procedureName);

        /// <summary>
        /// Retrieves a list of supported OpenGL extensions.
        /// </summary>
        /// <param name="handle">Handle to an OpenGL context.</param>
        /// <returns>A list of supported OpenGL extensions.</returns>
        /// <exception cref="ArgumentNullException">OpenGL context handle is null.</exception>
        string[] GetSupportedExtensions(OpenGLContextHandle handle);

        /// <summary>
        /// Get the current OpenGL context for this thread.
        /// </summary>
        /// <returns>Handle to the current OpenGL context, null if none are current.</returns>
        OpenGLContextHandle GetCurrentContext();

        /// <summary>
        /// Query if an OpenGL extension is supported.
        /// </summary>
        /// <param name="handle">Handle to an OpenGL context.</param>
        /// <param name="name">Name of the extension to query.</param>
        /// <returns>True if the extension is supported.</returns>
        /// <exception cref="System.ArgumentNullException">OpenGL context handle or extension name is null.</exception>
        bool IsExtensionSupported(OpenGLContextHandle handle, string name);

        /// <summary>
        /// Set the current OpenGL context for this thread.
        /// </summary>
        /// <param name="handle">Handle to the OpenGL context to make current, or null to make none current.</param>
        /// <returns>True when the OpenGL context is successfully made current.</returns>
        bool SetCurrentContext(OpenGLContextHandle handle);
    }
}
