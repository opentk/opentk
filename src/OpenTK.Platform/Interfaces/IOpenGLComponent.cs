using System;
using System.Runtime.CompilerServices;

#nullable enable

namespace OpenTK.Platform
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
        /// True if the component driver can create a context from windows using <see cref="CreateFromWindow(WindowHandle)"/>.
        /// </summary>
        /// <seealso cref="CreateFromWindow(WindowHandle)"/>
        bool CanCreateFromWindow { get; }

        /// <summary>
        /// True if the component driver can create a context from surfaces using <see cref="CreateFromSurface"/>.
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
        /// <param name="handle">The window for which the OpenGL context should be created.</param>
        /// <returns>An OpenGL context handle.</returns>
        // FIXME: Rename to CreateContextFromWindow?
        // Or just make CreateContext overloaded with both WindowHandle and SurfaceHandle?
        OpenGLContextHandle CreateFromWindow(WindowHandle handle);

        /// <summary>
        /// Destroy an OpenGL context.
        /// </summary>
        /// <param name="handle">Handle to the OpenGL context to destroy.</param>
        /// <exception cref="ArgumentNullException">OpenGL context handle is null.</exception>
        void DestroyContext(OpenGLContextHandle handle);

        /// <summary>
        /// Gets a <see cref="IBindingsContext"/> from an <see cref="OpenGLContextHandle"/>.
        /// </summary>
        /// <param name="handle">The handle to get a bindings context for.</param>
        /// <returns>The created bindings context.</returns>
        IBindingsContext GetBindingsContext(OpenGLContextHandle handle);

        /// <summary>
        /// Get the procedure address for an OpenGL command.
        /// </summary>
        /// <param name="handle">Handle to an OpenGL context.</param>
        /// <param name="procedureName">Name of the OpenGL command.</param>
        /// <returns>The procedure address to the OpenGL command.</returns>
        /// <exception cref="ArgumentNullException">OpenGL context handle or procedure name is null.</exception>
        IntPtr GetProcedureAddress(OpenGLContextHandle handle, string procedureName);

        /// <summary>
        /// Get the current OpenGL context for this thread.
        /// </summary>
        /// <returns>Handle to the current OpenGL context, null if none are current.</returns>
        OpenGLContextHandle? GetCurrentContext();

        /// <summary>
        /// Set the current OpenGL context for this thread.
        /// </summary>
        /// <param name="handle">Handle to the OpenGL context to make current, or null to make none current.</param>
        /// <returns>True when the OpenGL context is successfully made current.</returns>
        // FIXME: Rename to MakeCurrent, like all other apis do
        bool SetCurrentContext(OpenGLContextHandle? handle);

        /// <summary>
        /// Gets the context which the given context shares display lists with.
        /// </summary>
        /// <param name="handle">Handle to the OpenGL context.</param>
        /// <returns>Handle to the OpenGL context the given context shares display lists with.</returns>
        OpenGLContextHandle? GetSharedContext(OpenGLContextHandle handle);

        /// <summary>
        /// Sets the swap interval of the current OpenGL context.
        /// </summary>
        /// <param name="interval">The new swap interval.</param>
        // FIXME: Better documentation.
        void SetSwapInterval(int interval);

        /// <summary>
        /// Gets the swap interval of the current OpenGL context.
        /// </summary>
        /// <returns>The current swap interval.</returns>
        // FIXME: Better documentation.
        int GetSwapInterval();

        /// <summary>
        /// Swaps the buffer of the specified context.
        /// </summary>
        /// <param name="handle">Handle to the context.</param>
        void SwapBuffers(OpenGLContextHandle handle);
    }
}
