using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using System;

namespace LocalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindowSettings gwSettings = new GameWindowSettings()
            {
            };

            NativeWindowSettings nwSettings = new NativeWindowSettings()
            {
                API = ContextAPI.OpenGL,
                APIVersion = new Version(3, 3),
                AutoLoadBindings = true,
                Flags = ContextFlags.Debug | ContextFlags.ForwardCompatible,
                IsEventDriven = false,
                Profile = ContextProfile.Core,
                Size = (800, 600),
                StartFocused = true,
                StartVisible = true,
                Title = "Local OpenTK Test",
                WindowBorder = WindowBorder.Resizable,
                WindowState = WindowState.Normal,
            };

            using (GameWindow window = new GameWindow(gwSettings, nwSettings))
            {
                window.Run();
            }
        }
    }
}
