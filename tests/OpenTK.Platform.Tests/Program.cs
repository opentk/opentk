using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native.X11;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Tests
{
    internal class SimpleWindow
    {
        static IWindowComponent windowComp;
        static IOpenGLComponent glComp;
        static ICursorComponent cursorComp;
        static IMouseComponent mouseComp;
        static IShellComponent shellComp;
        static IKeyboardComponent keyboardComp;

        static IDisplayComponent displayComp;

        static WindowHandle Window;

        static CursorHandle cursorHandle;

        static readonly Color4<Rgba> LightModeColor = Color4.Whitesmoke;
        static readonly Color4<Rgba> DarkModeColor = new Color4<Rgba>(37/255.0f, 37 / 255.0f, 38 / 255.0f, 1);

        static readonly Color4<Rgba> ContrastLightModeColor = new Color4<Rgba>(237 / 255.0f, 81 / 255.0f, 81 / 255.0f, 1);
        static readonly Color4<Rgba> ContrastDarkModeColor = new Color4<Rgba>(148 / 255.0f, 10 / 255.0f, 10 / 255.0f, 1);

        static Color4<Rgba> BackgroundColor = LightModeColor;

        static void Main()
        {
            EventQueue.EventRaised += EventQueue_EventRaised;

            windowComp = Native.PlatformComponents.CreateWindowComponent();
            glComp = Native.PlatformComponents.CreateOpenGLComponent();
            cursorComp = Native.PlatformComponents.CreateCursorComponent();
            mouseComp = Native.PlatformComponents.CreateMouseComponent();
            shellComp = Native.PlatformComponents.CreateShellComponent();
            displayComp = Native.PlatformComponents.CreateDisplayComponent();
            keyboardComp = Native.PlatformComponents.CreateKeyboardComponent();

            var logger = new ConsoleLogger();
            logger.Filter = 0;
            windowComp.Logger = logger;
            glComp.Logger = logger;
            cursorComp.Logger = logger;
            mouseComp.Logger = logger;
            shellComp.Logger = logger;
            displayComp.Logger = logger;
            keyboardComp.Logger = logger;

            windowComp.Initialize(PalComponents.Window);
            glComp.Initialize(PalComponents.OpenGL);
            cursorComp.Initialize(PalComponents.MouseCursor);
            mouseComp.Initialize(PalComponents.MiceInput);
            shellComp.Initialize(PalComponents.Shell);
            displayComp.Initialize(PalComponents.Display);
            keyboardComp.Initialize(PalComponents.KeyboardInput);

            Console.WriteLine($"Scancode to Key:");
            foreach (var scancode in Enum.GetValues<Scancode>())
            {
                Key key = keyboardComp.GetKeyFromScancode(scancode);
                //if (key != Key.Unknown) continue;
                Console.WriteLine($"{scancode} -> {key}");
            }
            Console.WriteLine();
            Console.WriteLine($"Key to Scancode:");
            foreach (var key in Enum.GetValues<Key>())
            {
                Scancode scancode = keyboardComp.GetScancodeFromKey(key);
                //if (scancode != Scancode.Unknown) continue;
                Console.WriteLine($"{key} -> {scancode}");
            }

            if (shellComp.GetBatteryInfo(out BatteryInfo info) == BatteryStatus.HasSystemBattery)
            {
                Console.WriteLine(info);
            }

            Window = windowComp.Create(new OpenGLGraphicsApiHints() { Version = new Version(3, 3) });
            OpenGLContextHandle context = glComp.CreateFromWindow(Window);
            if (glComp.SetCurrentContext(context) == false)
            {
                Console.WriteLine("Could not set context!");
            }
            GLLoader.LoadBindings(glComp.GetBindingsContext(context));

            glComp.SetSwapInterval(1);
            int swap = glComp.GetSwapInterval();

            windowComp.SetPosition(Window, 100, 100);
            windowComp.SetSize(Window, 400, 400);
            windowComp.SetMinClientSize(Window, 300, 300);
            windowComp.SetMaxClientSize(Window, 500, 500);
            windowComp.SetMode(Window, WindowMode.Normal);
            //windowComp.SetAlwaysOnTop(window, true);

            //Console.WriteLine($"Preferred theme: {shellComp.GetPreferredTheme()}");

            Console.WriteLine($"Number of screens: {displayComp.GetDisplayCount()}");

            Console.WriteLine($"Is always on top: {windowComp.IsAlwaysOnTop(Window)}");



            {
                windowComp.GetMinClientSize(Window, out int? minWidth, out int? minHeight);
                Console.WriteLine($"Window min size: ({minWidth}, {minHeight})");
            }

            Stopwatch watch = Stopwatch.StartNew();

            SystemCursorType cursor = SystemCursorType.Default;
            cursorHandle = cursorComp.Create();

            windowComp.SetCursor(Window, cursorHandle);

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
            windowComp.SetCursor(Window, cursorHandle);

            while (windowComp.IsWindowDestroyed(Window) == false)
            {
                windowComp.ProcessEvents();

                if (windowComp.IsWindowDestroyed(Window))
                    break;

                if (watch.ElapsedMilliseconds > 3000)
                {
                    //windowComp.FocusWindow(window);
                    windowComp.RequestAttention(Window);

                    windowComp.SetMode(Window, WindowMode.Normal);

                    watch.Restart();

                    //cursorComp.Load(cursorHandle, cursor);
                    //windowComp.SetCursor(window, cursorHandle);

                    cursor++;
                    if (cursor > SystemCursorType.ArrowUp)
                        cursor = SystemCursorType.Default;
                }
                
                //mouseComp.GetPosition(null, out int x, out int y);
                //windowComp.SetTitle(window,  $"Mouse: ({x}, {y})");
                
                GL.ClearColor(BackgroundColor);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                windowComp.SwapBuffers(Window);
            }
        }

        static CursorCaptureMode captureMode = CursorCaptureMode.Normal;
        static WindowMode windowMode = WindowMode.Normal;

        static Vector2 lastPos;

        static bool fixedBorder = false;
        static bool client = false;

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
                else if (buttonDown.Button == MouseButton.Button2)
                {
                    windowComp.GetMaxClientSize(Window, out int? bMaxWidth, out int? bMaxHeight);
                    windowComp.GetMinClientSize(Window, out int? bMinWidth, out int? bMinHeight);

                    if (fixedBorder)
                    {
                        windowComp.SetBorderStyle(Window, WindowStyle.ResizableBorder);
                    }
                    else
                    {
                        windowComp.SetBorderStyle(Window, WindowStyle.FixedBorder);
                    }

                    fixedBorder = !fixedBorder;

                    windowComp.GetMaxClientSize(Window, out int? aMaxWidth, out int? aMaxHeight);
                    windowComp.GetMinClientSize(Window, out int? aMinWidth, out int? aMinHeight);

                    System.Console.WriteLine($"Before: Min: ({bMinWidth}, {bMinHeight}), Max: ({bMaxWidth}, {bMaxHeight})");
                    System.Console.WriteLine($"After: Min: ({aMinWidth}, {aMinHeight}), Max: ({aMaxWidth}, {aMaxHeight})");
                }
                else if (buttonDown.Button == MouseButton.Button1)
                {
                    mouseComp.GetPosition(null, out int x, out int y);

                    //windowComp.SetMode(Window, WindowMode.Hidden);
                    if (client)
                    {
                        windowComp.SetClientSize(Window, 400, 400);
                    }
                    else
                    {
                        windowComp.SetSize(Window, 400, 400);
                    }

                    windowComp.GetSize(Window, out int wx, out int wy);
                    windowComp.GetClientSize(Window, out int cx, out int cy);
                    System.Console.WriteLine($"Size: ({wx}, {wy}), Client size: ({cx}, {cy}), Set client size: {client}");

                    client = !client;

                    //keyboardComp.BeginIme(Window);
                    //keyboardComp.SetImeRectangle(Window, x, y, 0, 0);
                }
            }
            else if (args is ScrollEventArgs scroll)
            {
                Console.WriteLine($"Scroll: {scroll.Delta}, Distance: {scroll.Distance}");
            }
            else if (args is MouseMoveEventArgs move)
            {
                windowComp.SetTitle((WindowHandle)handle, $"Mouse: {move.Position}");

                //Console.WriteLine($"Delta: {move.Position - lastPos}");

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
            else if (args is ThemeChangeEventArgs themeChange)
            {
                ThemeInfo newTheme = themeChange.NewTheme;
                switch (newTheme.Theme)
                {
                    case AppTheme.Light:
                        BackgroundColor = newTheme.HighContrast ? ContrastLightModeColor : LightModeColor;
                        (shellComp as Native.Windows.ShellComponent)?.SetImmersiveDarkMode(Window, false);
                        break;
                    case AppTheme.Dark:
                        BackgroundColor = newTheme.HighContrast ? ContrastDarkModeColor : DarkModeColor;
                        (shellComp as Native.Windows.ShellComponent)?.SetImmersiveDarkMode(Window, true);
                        break;
                    case AppTheme.NoPreference:
                    default:
                        break;
                }
            }
            else if (args is PowerStateChangeEventArgs powerStateChange)
            {
                if (powerStateChange.GoingToSleep)
                {
                    Console.WriteLine("Entering sleep!");
                }
                else
                {
                    Console.WriteLine("Awoken from sleep!");
                }
            }
        }
    }
}
