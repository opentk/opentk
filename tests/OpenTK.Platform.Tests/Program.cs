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

        static CursorHandle cursorHandle;

        static void Main()
        {
            EventQueue.EventRaised += EventQueue_EventRaised;

            windowComp = Native.PlatformComponents.CreateWindowComponent();
            glComp = Native.PlatformComponents.CreateOpenGLComponent();
            cursorComp = Native.PlatformComponents.CreateCursorComponent();
            mouseComp = Native.PlatformComponents.CreateMouseComponent();
            shellComp = Native.PlatformComponents.CreateShellComponent();

            var logger = new ConsoleLogger();
            windowComp.Logger = logger;
            glComp.Logger = logger;
            cursorComp.Logger = logger;
            mouseComp.Logger = logger;
            shellComp.Logger = logger;

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
            cursorHandle = cursorComp.Create();

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
            //cursorComp.SetHotspot(cursorHandle, 7, 7);
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
                //windowComp.SetTitle(window,  $"Mouse: ({x}, {y})");
                
                GL.ClearColor(Color4.Coral);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                windowComp.SwapBuffers(window);
            }
        }

        static CursorCaptureMode captureMode = CursorCaptureMode.Normal;

        static Vector2 lastPos;

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

                if (buttonDown.Button == MouseButton.Button3)
                {
                    captureMode++;
                    captureMode = (CursorCaptureMode)((int)captureMode % 3);
                    //windowComp.CaptureCursor((WindowHandle)handle, captured);
                    windowComp.SetCursorCaptureMode((WindowHandle)handle, captureMode);
                }
            }
            else if (args is ScrollEventArgs scroll)
            {
                Console.WriteLine($"Scroll: {scroll.Delta}, Distance: {scroll.Distance}");
            }
            else if (args is MouseMoveEventArgs move)
            {
                windowComp.SetTitle((WindowHandle)handle, $"Mouse: {move.Position}");

                Console.WriteLine($"Delta: {move.Position - lastPos}");

                lastPos = move.Position;
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
