using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.GraphicsLibraryFramework;

namespace OpenToolkit.Windowing.Desktop
{
    public unsafe class GLFWGraphicsContext : IGraphicsContext
    {
        private readonly Window* _windowPtr;

        public GLFWGraphicsContext(Window* windowPtr)
        {
            _windowPtr = windowPtr;
        }

        /// <inheritdoc />
        public bool IsCurrent => GLFW.GetCurrentContext() == _windowPtr;

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
