using System;

namespace OpenToolkit.Windowing.GraphicsLibraryFramework
{
    public static class GLFWProvider
    {
        private static GLFW glfw = null;
        public static GLFW GLFW
        {
            get
            {
                if (glfw == null)
                {
                    glfw = GLFW.GetAPI();
                    glfw.Init();
                    glfw.SetErrorCallback(GLFW.errorCallback);
                }
                return glfw;
            }
        }

        public static void Unload()
        {
            glfw.Terminate();
            glfw = null;
        }
    }
}