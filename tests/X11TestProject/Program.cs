using System;
using OpenTK;
using OpenTK.Platform;
using OpenTK.Graphics;
using OpenTK.Platform.Native;
using OpenTK.Graphics.OpenGL;

namespace X11TestProject
{
    public class Program
    {
        static IWindowComponent windowComp;
        static IOpenGLComponent glComp;
        static IDisplayComponent dispComp;

        static WindowHandle window;
        static OpenGLContextHandle context;

        public static void Main()
        {
            //MultiThreadExample.MultiThreadMain();
            //return;

            EventQueue.EventRaised += EventQueue_EventRaised;

            windowComp = PlatformComponents.CreateWindowComponent();
            glComp = PlatformComponents.CreateOpenGLComponent();
            dispComp = PlatformComponents.CreateDisplayComponent();

            ToolkitOptions options = new ToolkitOptions();
            windowComp.Initialize(options);
            glComp.Initialize(options);
            dispComp.Initialize(options);

            window = windowComp.Create(new OpenGLGraphicsApiHints());
            context = glComp.CreateFromWindow(window);
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

                GL.Enable(EnableCap.ScissorTest);
                GL.Scissor(0, 0, 100, 100);
                GL.ClearColor(1, 1, 0, 1);
                GL.Clear(ClearBufferMask.ColorBufferBit);
                GL.Disable(EnableCap.ScissorTest);

                glComp.SwapBuffers(context);

                windowComp.GetSize(window, out int w, out int h);
                windowComp.SetTitle(window, $"私はまだ日本語を話すことができません [{width},{height};{w},{h};frame={++frames}]");
                // layer.GetClientPosition(window, out int x, out int y);
                // Console.WriteLine("({0}, {1}) @ ({2}, {3})", width, height, x, y);

                windowComp.ProcessEvents(false);
            }
        }

        public static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            if (args is KeyDownEventArgs keyDown)
            {
                if (keyDown.Key == Key.F)
                {
                    if (windowComp.GetFullscreenDisplay(window, out _))
                    {
                        windowComp.SetMode(window, WindowMode.Normal);
                        System.Console.WriteLine("Normal");
                    }
                    else
                    {
                        windowComp.SetFullscreenDisplay(window, null);
                        System.Console.WriteLine("Fullscreen");
                    }
                }
            }
            else if (args is MouseButtonDownEventArgs buttonDown)
            {
                if (buttonDown.Button == MouseButton.Button1)
                {
                    if (windowComp.GetFullscreenDisplay(window, out _))
                    {
                        windowComp.SetMode(window, WindowMode.Normal);
                        System.Console.WriteLine("Normal");
                    }
                    else
                    {
                        windowComp.SetFullscreenDisplay(window, null);
                        System.Console.WriteLine("Windowed Fullscreen");
                    }
                }
                else if (buttonDown.Button == MouseButton.Button2)
                {
                    if (windowComp.GetFullscreenDisplay(window, out _))
                    {
                        windowComp.SetMode(window, WindowMode.Normal);
                        System.Console.WriteLine("Normal");
                    }
                    else
                    {
                        var disp = windowComp.GetDisplay(window);
                        var mode = new VideoMode(2560, 1440, 144, 24);
                        windowComp.SetFullscreenDisplay(window, disp, mode);
                        System.Console.WriteLine("Exlusive Fullscreen");
                    }
                }
                else if (buttonDown.Button == MouseButton.Button3)
                {
                    windowComp.Destroy(window);
                }
            }
        }
    }
}
