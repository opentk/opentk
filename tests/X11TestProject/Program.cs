using System;
using OpenTK;
using OpenTK.Platform;
using OpenTK.Graphics;
using OpenTK.Platform.Native;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

namespace X11TestProject
{
    public class Program
    {
        static WindowHandle window;
        static OpenGLContextHandle context;

        public static void Main()
        {
            Toolkit.Init(new ToolkitOptions() { FeatureFlags = ToolkitFlags.EnableOpenGL });

            Toolkit.Event.EventRaised += EventQueue_EventRaised;


            window = Toolkit.Window.Create(new OpenGLGraphicsApiHints());
            context = Toolkit.OpenGL.CreateFromWindow(window);
            Toolkit.OpenGL.SetCurrentContext(context);

            Toolkit.Window.SetClientSize(window, (800, 600));
            Toolkit.Window.SetMode(window, WindowMode.Normal);

            GLLoader.LoadBindings(Toolkit.OpenGL.GetBindingsContext(context));

            // DisplayHandle handle = layer.CreatePrimary();

            Toolkit.Event.EventRaised += (args) =>
            {
                if (args is CloseEventArgs close)
                {
                    Console.WriteLine("close!");
                    Toolkit.Window.Destroy(window);
                }
            };

            int frames = 0;
            while (Toolkit.Window.IsWindowDestroyed(window) == false)
            {
                Toolkit.Window.GetFramebufferSize(window, out Vector2i fbSize);

                GL.Viewport(0, 0, fbSize.X, fbSize.Y);
                GL.ClearColor(1, 0, 1, 1);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                GL.Enable(EnableCap.ScissorTest);
                GL.Scissor(0, 0, 100, 100);
                GL.ClearColor(1, 1, 0, 1);
                GL.Clear(ClearBufferMask.ColorBufferBit);
                GL.Disable(EnableCap.ScissorTest);

                Toolkit.OpenGL.SwapBuffers(context);

                Toolkit.Window.GetSize(window, out Vector2i size);
                Toolkit.Window.SetTitle(window, $"私はまだ日本語を話すことができません [{fbSize.X},{fbSize.Y};{size.X},{size.Y};frame={++frames}]");
                // layer.GetClientPosition(window, out int x, out int y);
                // Console.WriteLine("({0}, {1}) @ ({2}, {3})", width, height, x, y);

                Toolkit.Window.ProcessEvents(false);
            }
        }

        public static void EventQueue_EventRaised(EventArgs args)
        {
            if (args is KeyDownEventArgs keyDown)
            {
                if (keyDown.Key == Key.F)
                {
                    if (Toolkit.Window.GetFullscreenDisplay(window, out _))
                    {
                        Toolkit.Window.SetMode(window, WindowMode.Normal);
                        Console.WriteLine("Normal");
                    }
                    else
                    {
                        Toolkit.Window.SetFullscreenDisplay(window, null);
                        Console.WriteLine("Fullscreen");
                    }
                }
            }
            else if (args is MouseButtonDownEventArgs buttonDown)
            {
                if (buttonDown.Button == MouseButton.Button1)
                {
                    if (Toolkit.Window.GetFullscreenDisplay(window, out _))
                    {
                        Toolkit.Window.SetMode(window, WindowMode.Normal);
                        Console.WriteLine("Normal");
                    }
                    else
                    {
                        Toolkit.Window.SetFullscreenDisplay(window, null);
                        Console.WriteLine("Windowed Fullscreen");
                    }
                }
                else if (buttonDown.Button == MouseButton.Button2)
                {
                    if (Toolkit.Window.GetFullscreenDisplay(window, out _))
                    {
                        Toolkit.Window.SetMode(window, WindowMode.Normal);
                        Console.WriteLine("Normal");
                    }
                    else
                    {
                        var disp = Toolkit.Window.GetDisplay(window);
                        var mode = new VideoMode(2560, 1440, 144, 24);
                        Toolkit.Window.SetFullscreenDisplay(window, disp, mode);
                        Console.WriteLine("Exlusive Fullscreen");
                    }
                }
                else if (buttonDown.Button == MouseButton.Button3)
                {
                    Toolkit.Window.Destroy(window);
                }
            }
        }
    }
}
