using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGLES2;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.ANGLE;

namespace ANGLETestProject
{
    internal class Program
    {
        static IWindowComponent WindowComp;
        static IOpenGLComponent OpenGLComp;

        static void Main(string[] args)
        {
            EventQueue.EventRaised += EventQueue_EventRaised;

            WindowComp = PlatformComponents.CreateWindowComponent();
            OpenGLComp = new ANGLEOpenGLComponent();

            ToolkitOptions options = new ToolkitOptions() { Logger = new ConsoleLogger() };

            WindowComp.Logger = options.Logger;
            OpenGLComp.Logger = options.Logger;

            WindowComp.Initialize(options);
            OpenGLComp.Initialize(options);

            var window = WindowComp.Create(new OpenGLGraphicsApiHints() { Version = new Version(3, 1) });
            WindowComp.SetSize(window, (800, 600));
            WindowComp.SetMode(window, WindowMode.Normal);
            WindowComp.SetTitle(window, "ANGLE Window");

            var context = OpenGLComp.CreateFromWindow(window);
            OpenGLComp.SetCurrentContext(context);
            GLLoader.LoadBindings(OpenGLComp.GetBindingsContext(context));

            WindowComp.SetTitle(window, $"ANGLE Window - {GL.GetString(StringName.Version)}");

            while (true)
            {
                WindowComp.ProcessEvents(false);

                if (WindowComp.IsWindowDestroyed(window))
                {
                    break;
                }

                GL.ClearColor(Color4.Coral);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                OpenGLComp.SwapBuffers(context);
            }
        }

        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            if (args is CloseEventArgs close)
            {
                WindowComp.Destroy(close.Window);
            }
        }
    }
}
