using System;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Interface for drivers which provide the PAL OpenGL Component.
    /// </summary>
    public interface IOpenGLComponent : IPalComponent
    {
        /// <summary>
        /// True if the component driver has the capability to share display lists between OpenGL contexts.
        /// </summary>
        bool CanShareContexts { get; }

        /// <summary>
        /// True if the component driver can create a context from windows.
        /// </summary>
        bool CanCreateFromWindow { get; }

        /// <summary>
        /// True if the component driver can create a context from surfaces.
        /// </summary>
        bool CanCreateFromSurface { get; }

        /// <summary>
        /// Create and OpenGL context for a surface.
        /// </summary>
        /// <returns>An OpenGL context handle.</returns>
        OpenGLContextHandle CreateFromSurface(/* TODO: determine arguments. */);

        /// <summary>
        /// Create an OpenGL context for a window.
        /// </summary>
        /// <returns>An OpenGL context handle.</returns>
        OpenGLContextHandle CreateFromWindow(/* TODO: determine arguments. */);

        /// <summary>
        /// Destroy an OpenGL context.
        /// </summary>
        /// <param name="handle">Handle to the OpenGL context to destroy.</param>
        /// <exception cref="ArgumentNullException">OpenGL context handle is null.</exception>
        void DestroyContext(OpenGLContextHandle handle);

        /// <summary>
        /// Get the current OpenGL context for this thread.
        /// </summary>
        /// <returns>Handle to the current OpenGL context, null if none are current.</returns>
        OpenGLContextHandle GetCurrentContext();

        /// <summary>
        /// Get the procedure address for an OpenGL command.
        /// </summary>
        /// <param name="handle">Handle to an OpenGL context.</param>
        /// <param name="procedureName">Name of the OpenGL command.</param>
        /// <returns>The procedure address to the OpenGL command.</returns>
        /// <exception cref="ArgumentNullException">OpenGL context handle or procedure name is null.</exception>
        IntPtr GetProcedureAddress(OpenGLContextHandle handle, string procedureName);

        /// <summary>
        /// Get the context which newly created contexts will share display lists with.
        /// </summary>
        /// <returns>The OpenGL context handle, or null if unset.</returns>
        /// <remarks>The return value of this method is thread static.</remarks>
        OpenGLContextHandle GetSharedContext();

        /// <summary>
        /// Retrieves a list of supported OpenGL extensions.
        /// </summary>
        /// <param name="handle">Handle to an OpenGL context.</param>
        /// <returns>A list of supported OpenGL extensions.</returns>
        /// <exception cref="ArgumentNullException">OpenGL context handle is null.</exception>
        string[] GetSupportedExtensions(OpenGLContextHandle handle);

        /// <summary>
        /// Gets the context which the given context shares display lists with.
        /// </summary>
        /// <param name="handle">Handle to the OpenGL context.</param>
        /// <returns>Handle to the OpenGL context the given context shares display lists with.</returns>
        OpenGLContextHandle GetSharedContext(OpenGLContextHandle handle);

        /// <summary>
        /// Query if an OpenGL extension is supported.
        /// </summary>
        /// <param name="handle">Handle to an OpenGL context.</param>
        /// <param name="name">Name of the extension to query.</param>
        /// <returns>True if the extension is supported.</returns>
        /// <exception cref="ArgumentNullException">OpenGL context handle or extension name is null.</exception>
        bool IsExtensionSupported(OpenGLContextHandle handle, string name);

        /// <summary>
        /// Set the current OpenGL context for this thread.
        /// </summary>
        /// <param name="handle">Handle to the OpenGL context to make current, or null to make none current.</param>
        /// <returns>True when the OpenGL context is successfully made current.</returns>
        bool SetCurrentContext(OpenGLContextHandle handle);

        /// <summary>
        /// Set a context to share display lists with newly created OpenGL contexts.
        /// </summary>
        /// <param name="handle">Handle to an OpenGL context or null.</param>
        /// <remarks>
        /// When set, contexts created from calls to <see cref="CreateFromWindow"/> and
        /// <see cref="CreateFromSurface"/> will share display lists with the given context
        /// until unset.
        /// The shared OpenGL context value must be thread static within the driver.
        /// </remarks>
        void SetSharedContext(OpenGLContextHandle handle);
    }
}
