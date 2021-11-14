using System;
using System.Reflection;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK.Windowing.Desktop
{
    public class BackgroundContext
    {
        private readonly unsafe Window* _window;

        private static readonly GLFWCallbacks.ErrorCallback ErrorCallback =
            (errorCode, description) => throw new GLFWException(description, errorCode);

        public BackgroundContext(Version apiVersion, ContextAPI api, ContextProfile profile)
        {
            GLFW.Init();
            GLFW.SetErrorCallback(ErrorCallback);

            switch (api)
            {
                case ContextAPI.NoAPI:
                    GLFW.WindowHint(WindowHintClientApi.ClientApi, ClientApi.NoApi);
                    break;

                case ContextAPI.OpenGLES:
                    GLFW.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGlEsApi);
                    break;

                case ContextAPI.OpenGL:
                    GLFW.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGlApi);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            GLFW.WindowHint(WindowHintInt.ContextVersionMajor, apiVersion.Major);
            GLFW.WindowHint(WindowHintInt.ContextVersionMinor, apiVersion.Minor);
            GLFW.WindowHint(WindowHintBool.Visible, false);
            GLFW.WindowHint(WindowHintInt.Samples, 2);

            switch (profile)
            {
                case ContextProfile.Any:
                    GLFW.WindowHint(WindowHintOpenGlProfile.OpenGlProfile, OpenGlProfile.Any);
                    break;
                case ContextProfile.Compatability:
                    GLFW.WindowHint(WindowHintOpenGlProfile.OpenGlProfile, OpenGlProfile.Compat);
                    break;
                case ContextProfile.Core:
                    GLFW.WindowHint(WindowHintOpenGlProfile.OpenGlProfile, OpenGlProfile.Core);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            GLFWGraphicsContext context;
            unsafe
            {
                this._window = GLFW.CreateWindow(10, 10, string.Empty, null, (Window*)IntPtr.Zero);
                context = new GLFWGraphicsContext(this._window);
            }
            context.MakeCurrent();
            InitializeGlBindings();
        }

        public void Dispose()
        {
            unsafe
            {
                GLFW.DestroyWindow(this._window);
            }
        }

        private static void InitializeGlBindings()
        {
            var assembly = Assembly.Load("OpenTK.Graphics");
            var provider = new GLFWBindingsContext();

            void LoadBindings(string typeNamespace)
            {
                var type = assembly.GetType($"OpenTK.Graphics.{typeNamespace}.GL");
                if (type == null)
                {
                    return;
                }

                var load = type.GetMethod("LoadBindings");
                load.Invoke(null, new object[] { provider });
            }

            LoadBindings("ES11");
            LoadBindings("ES20");
            LoadBindings("ES30");
            LoadBindings("OpenGL");
            LoadBindings("OpenGL4");
        }
    }
}
