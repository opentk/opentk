using OpenTK.Core.Platform;
using OpenTK.Platform.Native;

namespace OpenTK.Platform.Tests
{
    internal class SimpleWindow
    {
        static void Main(string[] args)
        {
            EventQueue.EventRaised += EventQueue_EventRaised;

            IWindowComponent windowComp;
            if (OperatingSystem.IsWindows())
                windowComp = new Native.Windows.WindowComponent();
            else if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
                windowComp = new Native.X11.X11WindowComponent();
            else throw new Exception("OS not supported yet!");

            IOpenGLComponent glComp;
            if (OperatingSystem.IsWindows())
                glComp = new Native.Windows.OpenGLComponent();
            else if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
                glComp = new Native.X11.X11OpenGLComponent();
            else throw new Exception("OS not supported yet!");

            windowComp.Initialize(PalComponents.Window);

            glComp.Initialize(PalComponents.OpenGL);

            WindowHandle window = windowComp.Create(new OpenGLGraphicsApiHints() { Version = new Version(3, 3) });
            //OpenGLContextHandle context = glComp.CreateFromWindow(window);
            //glComp.SetCurrentContext(context);

            windowComp.SetSize(window, 800, 600);
            windowComp.SetMode(window, WindowMode.Normal);

            while (windowComp.IsWindowDestroyed(window) == false)
            {
                windowComp.ProcessEvents();

                windowComp.SwapBuffers(window);
            }
        }

        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            Console.WriteLine(type);
        }
    }
}
