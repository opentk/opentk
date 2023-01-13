using OpenTK.Core.Platform;
using OpenTK.Core.Platform.Interfaces;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native.X11;
using System;
using System.Diagnostics;

namespace OpenTK.Platform.Tests
{
    internal class SimpleWindow
    {
        static IWindowComponent windowComp;
        static IOpenGLComponent glComp;
        static ICursorComponent cursorComp;
        static IMouseComponent mouseComp;
        static IShellComponent shellComp;

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

            if (OperatingSystem.IsWindows())
                cursorComp = new Native.Windows.CursorComponent();
            else if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
                cursorComp = new Native.X11.X11CursorComponent();
            else throw new Exception("OS not supported yet!");

            if (OperatingSystem.IsWindows())
                mouseComp = new Native.Windows.MouseComponent();
            else if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
                mouseComp = new Native.X11.X11MouseComponent();
            else throw new Exception("OS not supported yet!");

            if (OperatingSystem.IsWindows())
                shellComp = new Native.Windows.ShellComponent();
            else if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
                shellComp = new Native.X11.X11ShellComponent();
            else throw new Exception("OS not supported yet!");

            var logger = new ConsoleLogger();
            windowComp.Logger = logger;
            glComp.Logger = logger;

            windowComp.Initialize(PalComponents.Window);

            glComp.Initialize(PalComponents.OpenGL);

            cursorComp.Initialize(PalComponents.MouseCursor);

            shellComp.Initialize(PalComponents.Shell);

            if (shellComp.GetBatteryInfo(out BatteryInfo info) == BatteryStatus.HasSystemBattery)
            {
                Console.WriteLine(info);
            }

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

            Console.WriteLine($"Is always on top: {windowComp.IsAlwaysOnTop(window)}");

            {
                windowComp.GetMinClientSize(window, out int? minWidth, out int? minHeight);
                Console.WriteLine($"Window min size: ({minWidth}, {minHeight})");
            }

            Stopwatch watch = Stopwatch.StartNew();

            SystemCursorType cursor = SystemCursorType.Default;
            CursorHandle cursorHandle = cursorComp.Create();

            windowComp.SetCursor(window, cursorHandle);

            cursorHandle = cursorComp.Create();
            byte[] image = new byte[16 * 16 * 3];
            byte[] mask = new byte[16 * 16 * 1];
            for (int ccx = 0; ccx < 16; ccx++)
            {
                for (int ccy = 0; ccy < 16; ccy++)
                {
                    int index = (ccy * 16 + ccx) * 3;

                    image[index + 0] = (byte)(ccx * 16);
                    image[index + 1] = (byte)(ccx * 16);
                    image[index + 2] = (byte)(ccx * 16);

                    mask[(ccy * 16 + ccx)] = (byte)((ccy % 2 == 0) ? 1 : 0);
                }
            }
            //cursorComp.SetHotspot(cursorHandle, 8, 8);
            cursorComp.Load(cursorHandle, 16, 16, image, mask);
            windowComp.SetCursor(window, cursorHandle);

            while (windowComp.IsWindowDestroyed(window) == false)
            {
                windowComp.ProcessEvents();

                if (windowComp.IsWindowDestroyed(window))
                    break;

                if (watch.ElapsedMilliseconds > 3000)
                {
                    //windowComp.FocusWindow(window);
                    //windowComp.RequestAttention(window);

                    watch.Restart();

                    //cursorComp.Load(cursorHandle, cursor);
                    //windowComp.SetCursor(window, cursorHandle);

                    cursor++;
                    if (cursor > SystemCursorType.ArrowUp)
                        cursor = SystemCursorType.Default;
                }

                mouseComp.GetPosition(null, out int x, out int y);
                windowComp.SetTitle(window,  $"Mouse: ({x}, {y})");
                
                GL.ClearColor(Color4.Coral);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                windowComp.SwapBuffers(window);
            }
        }

        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            //Console.WriteLine(type);

            if (args is CloseEventArgs close)
            {
                windowComp.Destroy(close.Window);
            }
            else if (args is MouseButtonDownEventArgs buttonDown)
            {
                Console.WriteLine($"Mouse button: {buttonDown.Button}");
            }
            else if (args is ScrollEventArgs scroll)
            {
                Console.WriteLine($"Scroll: {scroll.Delta}, Distance: {scroll.Distance}");
            }
            else if (args is MouseMoveEventArgs move)
            {
                windowComp.SetTitle((WindowHandle)handle, $"Mouse: {move.Position}");
            }
            else if (args is FocusEventArgs focus)
            {
                if (focus.GotFocus)
                {
                    Console.WriteLine("Got focus!");
                }
                else
                {
                    Console.WriteLine("Lost focus!");
                }
            }
            else if (args is WindowModeChangeEventArgs windowModeChange)
            {
                Console.WriteLine($"Window mode: {windowModeChange.NewMode}");
            }
        }
    }
}
