using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGLES2;
using OpenTK.Mathematics;
using System.Diagnostics;
using OpenTK.Platform.Native.ANGLE;

namespace ANGLETestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventQueue.EventRaised += EventQueue_EventRaised;

            Toolkit.Init(new ToolkitOptions() { ApplicationName = "ANGLE Test", Logger = new ConsoleLogger(), FeatureFlags = ToolkitFlags.EnableOpenGL | ToolkitFlags.PreferANGLE });

            Debug.Assert(Toolkit.OpenGL.GetType() == typeof(ANGLEOpenGLComponent));
            
            var window = Toolkit.Window.Create(new OpenGLGraphicsApiHints() { Version = new Version(3, 1) });
            Toolkit.Window.SetSize(window, (800, 600));
            Toolkit.Window.SetMode(window, WindowMode.Normal);
            Toolkit.Window.SetTitle(window, "ANGLE Window");

            var context = Toolkit.OpenGL.CreateFromWindow(window);
            Toolkit.OpenGL.SetCurrentContext(context);
            GLLoader.LoadBindings(Toolkit.OpenGL.GetBindingsContext(context));

            Toolkit.Window.SetTitle(window, $"ANGLE Window - {GL.GetString(StringName.Version)}");

            while (true)
            {
                Toolkit.Window.ProcessEvents(false);

                if (Toolkit.Window.IsWindowDestroyed(window))
                {
                    break;
                }

                GL.ClearColor(Color4.Coral);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                Toolkit.OpenGL.SwapBuffers(context);
            }
        }

        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            if (args is CloseEventArgs close)
            {
                Toolkit.Window.Destroy(close.Window);
            }
        }
    }
}
