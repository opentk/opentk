using System;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    /// OpenGL context implemented using GLFW.
    /// </summary>
    public unsafe class GLFWGraphicsContext : IGLFWGraphicsContext
    {
        /// <inheritdoc />
        public Window* WindowPtr { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLFWGraphicsContext"/> class, a GLFW managed opengl context.
        /// </summary>
        /// <param name="windowPtr">The window pointer that is associated with the context.</param>
        public GLFWGraphicsContext(Window* windowPtr)
        {
            WindowPtr = windowPtr;
        }

        /// <inheritdoc />
        public bool IsCurrent => GLFW.GetCurrentContext() == WindowPtr;

        /// <inheritdoc />
        public void SwapBuffers()
        {
            GLFW.SwapBuffers(WindowPtr);
        }

        /// <inheritdoc />
        public void MakeCurrent()
        {
            GLFW.MakeContextCurrent(WindowPtr);
        }

        /// <inheritdoc />
        public void MakeNoneCurrent()
        {
            GLFW.MakeContextCurrent(null);
        }
    }
}
