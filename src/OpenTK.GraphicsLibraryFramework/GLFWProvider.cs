using System;

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Singleton providing easy GLFW implementation access.
    /// </summary>
    public static class GLFWProvider
    {
        /// <summary>
        /// Gets a GLFW interface implementation lazily.
        /// </summary>
        public static Lazy<GLFW> GLFW { get; internal set; } = new Lazy<GLFW>(() =>
        {
            var glfw = GraphicsLibraryFramework.GLFW.GetAPI();
            glfw.Init();
            glfw.SetErrorCallback(GraphicsLibraryFramework.GLFW.ErrorCallback);
            return glfw;
        });

        /// <summary>
        /// Unloads the loaded <see cref="GLFW"/> interface implementation.
        /// </summary>
        public static void Unload()
        {
            GLFW.Value.Terminate();
            GLFW = new Lazy<GLFW>(() =>
            {
                var glfw = GraphicsLibraryFramework.GLFW.GetAPI();
                glfw.Init();
                glfw.SetErrorCallback(GraphicsLibraryFramework.GLFW.ErrorCallback);
                return glfw;
            });
        }
    }
}
