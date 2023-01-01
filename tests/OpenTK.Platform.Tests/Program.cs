using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using System;
using System.Diagnostics;

namespace OpenTK.Platform.Tests
{
    internal class SimpleWindow
    {
        static IWindowComponent windowComp;
        static IOpenGLComponent glComp;

        static void Main()
        {
            EventQueue.EventRaised += EventQueue_EventRaised;

            if (OperatingSystem.IsWindows())
                windowComp = new Native.Windows.WindowComponent();
            else if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
                windowComp = new Native.X11.X11WindowComponent();
            else throw new Exception("OS not supported yet!");

            if (OperatingSystem.IsWindows())
                glComp = new Native.Windows.OpenGLComponent();
            else if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
                glComp = new Native.X11.X11OpenGLComponent();
            else throw new Exception("OS not supported yet!");

            var logger = new ConsoleLogger();
            windowComp.Logger = logger;
            glComp.Logger = logger;

            windowComp.Initialize(PalComponents.Window);

            glComp.Initialize(PalComponents.OpenGL);

            WindowHandle window = windowComp.Create(new OpenGLGraphicsApiHints() { Version = new Version(3, 3) });
            OpenGLContextHandle context = glComp.CreateFromWindow(window);
            glComp.SetCurrentContext(context);
            GLLoader.LoadBindings(glComp.GetBindingsContext(context));

            glComp.SetSwapInterval(1);
            int swap = glComp.GetSwapInterval();

            windowComp.SetPosition(window, 100, 100);
            windowComp.SetSize(window, 400, 400);
            windowComp.SetMinClientSize(window, 300, 300);
            windowComp.SetMaxClientSize(window, 500, 500);
            windowComp.SetMode(window, WindowMode.Normal);
            windowComp.SetAlwaysOnTop(window, true);

            windowComp.IsAlwaysOnTop(window);

            {
                windowComp.GetMinClientSize(window, out int? minWidth, out int? minHeight);
                Console.WriteLine($"Window min size: ({minWidth}, {minHeight})");
            }

            var watch = Stopwatch.StartNew();

            while (windowComp.IsWindowDestroyed(window) == false)
            {
                windowComp.ProcessEvents();

                if (watch.ElapsedMilliseconds > 1000)
                {
                    //windowComp.FocusWindow(window);
                    windowComp.RequestAttention(window);

                    watch.Restart();
                }
                
                GL.ClearColor(Color4.Coral);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                windowComp.SwapBuffers(window);
            }
        }

        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            Console.WriteLine(type);

            if (args is CloseEventArgs close)
            {
                windowComp.Destroy(close.Window);
            }
        }
    }
}
