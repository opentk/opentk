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
        private readonly Window* _windowPtr;

        /// <inheritdoc />
        public IntPtr WindowPtr => (IntPtr)_windowPtr;

        /// <summary>
        /// Initializes a new instance of the <see cref="GLFWGraphicsContext"/> class, a GLFW managed opengl context.
        /// </summary>
        /// <param name="windowPtr">The window pointer that is associated with the context.</param>
        public GLFWGraphicsContext(Window* windowPtr)
        {
            _windowPtr = windowPtr;
        }

        /// <inheritdoc />
        public bool IsCurrent => GLFW.GetCurrentContext() == _windowPtr;

        private int _swapInterval;

        /// <inheritdoc/>
        public int SwapInterval
        {
            get => _swapInterval;
            set
            {
                GLFW.SwapInterval(value);
                _swapInterval = value;
            }
        }

        /// <inheritdoc />
        public void SwapBuffers()
        {
            GLFW.SwapBuffers(_windowPtr);
        }

        /// <inheritdoc />
        public void MakeCurrent()
        {
            GLFW.MakeContextCurrent(_windowPtr);
        }

        /// <inheritdoc />
        public void MakeNoneCurrent()
        {
            GLFW.MakeContextCurrent(null);
        }
    }
}
