using System;

namespace OpenToolkit.GraphicsLibraryFramework
{
    public static class GLFWProvider
    {
        public static Lazy<GLFW> GLFW { get; internal set; } = new Lazy<GLFW>(() =>
        {
            var glfw = GraphicsLibraryFramework.GLFW.GetAPI();
            glfw.Init();
            glfw.SetErrorCallback(GraphicsLibraryFramework.GLFW.errorCallback);
            return glfw;
        });

        public static void Unload()
        {
            GLFW.Value.Terminate();
            GLFW = new Lazy<GLFW>(() =>
            {
                var glfw = GraphicsLibraryFramework.GLFW.GetAPI();
                glfw.Init();
                glfw.SetErrorCallback(GraphicsLibraryFramework.GLFW.errorCallback);
                return glfw;
            });
        }
    }
}