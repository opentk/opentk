using System;
using OpenTK;
using OpenTK.Core.Platform;
using OpenTK.Graphics;
using OpenTK.Platform.Native;
using OpenTK.Graphics.OpenGL;

namespace X11TestProject
{
    public class Program
    {
        public static void Main()
        {
            MultiThreadExample.MultiThreadMain();
            return;

            IWindowComponent windowComp = PlatformComponents.CreateWindowComponent();
            IOpenGLComponent glComp = PlatformComponents.CreateOpenGLComponent();
            IDisplayComponent dispComp = PlatformComponents.CreateDisplayComponent();

            windowComp.Initialize(PalComponents.Window);
            glComp.Initialize(PalComponents.OpenGL);
            dispComp.Initialize(PalComponents.Display);

            WindowHandle window = windowComp.Create(new OpenGLGraphicsApiHints());
            OpenGLContextHandle context = glComp.CreateFromWindow(window);
            glComp.SetCurrentContext(context);

            windowComp.SetClientSize(window, 800, 600);
            windowComp.SetMode(window, WindowMode.Normal);

            GLLoader.LoadBindings(glComp.GetBindingsContext(context));

            // DisplayHandle handle = layer.CreatePrimary();

            EventQueue.EventRaised += (handle, type, args) =>
            {
                if (args is CloseEventArgs close)
                {
                    Console.WriteLine("close!");
                    windowComp.Destroy(window);
                }
            };

            int frames = 0;
            while (windowComp.IsWindowDestroyed(window) == false)
            {
                windowComp.GetClientSize(window, out int width, out int height);

                GL.Viewport(0, 0, width, height);
                GL.ClearColor(1, 0, 1, 1);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                windowComp.SwapBuffers(window);

                windowComp.GetSize(window, out int w, out int h);
                windowComp.SetTitle(window, $"私はまだ日本語を話すことができません [{width},{height};{w},{h};frame={++frames}]");
                // layer.GetClientPosition(window, out int x, out int y);
                // Console.WriteLine("({0}, {1}) @ ({2}, {3})", width, height, x, y);

                windowComp.ProcessEvents();
            }
        }
    }
}
