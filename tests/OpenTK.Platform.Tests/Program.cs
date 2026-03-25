using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.X11;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace OpenTK.Platform.Tests
{
    internal class SimpleWindow
    {
        static WindowHandle Window;

        static CursorHandle cursorHandle;

        static readonly Color4<Rgba> LightModeColor = Color4.Whitesmoke;
        static readonly Color4<Rgba> DarkModeColor = new Color4<Rgba>(37/255.0f, 37 / 255.0f, 38 / 255.0f, 1);

        static readonly Color4<Rgba> ContrastLightModeColor = new Color4<Rgba>(237 / 255.0f, 81 / 255.0f, 81 / 255.0f, 1);
        static readonly Color4<Rgba> ContrastDarkModeColor = new Color4<Rgba>(148 / 255.0f, 10 / 255.0f, 10 / 255.0f, 1);

        static Color4<Rgba> BackgroundColor = LightModeColor;

        class CompositeLogger : ILogger
        {
            public LogLevel Filter { get; set; }

            public List<ILogger> Loggers = new List<ILogger>();

            void ILogger.LogInternal(string str, LogLevel level, string filePath, int lineNumber, string member)
            {
                foreach (var logger in Loggers)
                {
                    logger.Log(str, level, filePath, lineNumber, member);
                }
            }

            void ILogger.Flush()
            {
                // FIXME: Handle if one of the loggers throws an error.
                foreach (var logger in Loggers)
                {
                    logger.Flush();
                }
            }
        }

        class DebugThing : TraceListener
        {
            readonly TextWriter Writer = new StreamWriter(new FileStream("./log.log", FileMode.Create));

            public override void Write(string? message)
            {
                Writer.Write(message);
                Writer.Flush();
            }

            public override void WriteLine(string? message)
            {
                Writer.WriteLine(message);
                Writer.Flush();
            }
        }

        static void Main()
        {
            EventQueue.EventRaised += EventQueue_EventRaised;

            Toolkit.Init(new ToolkitOptions() { ApplicationName = "OpenTK.Platform.Tests", Logger = new ConsoleLogger(), FeatureFlags = ToolkitFlags.EnableOpenGL });

            /*
            keyboardComp.Logger.LogDebug($"Available keyboard layouts: {string.Join(", ", keyboardComp.GetAvailableKeyboardLayouts())}");
            keyboardComp.Logger.LogDebug($"Current keyboard layout: {keyboardComp.GetActiveKeyboardLayout()}");

            Console.WriteLine($"Scancode to Key:");
            keyboardComp.Logger.LogDebug($"Scancode to Key:");
            foreach (var scancode in Enum.GetValues<Scancode>())
            {
                Key key = keyboardComp.GetKeyFromScancode(scancode);
                //if (key != Key.Unknown) continue;
                Console.WriteLine($"{scancode} -> {key}");
                keyboardComp.Logger.LogDebug($"{scancode} -> {key}");
            }
            Console.WriteLine();
            Console.WriteLine($"Key to Scancode:");
            keyboardComp.Logger.LogDebug($"");
            keyboardComp.Logger.LogDebug($"Key to Scancode:");
            foreach (var key in Enum.GetValues<Key>())
            {
                Scancode scancode = keyboardComp.GetScancodeFromKey(key);
                //if (scancode != Scancode.Unknown) continue;
                Console.WriteLine($"{key} -> {scancode}");
                keyboardComp.Logger.LogDebug($"{scancode} -> {key}");
            }
            */

            if (Toolkit.Shell.GetBatteryInfo(out BatteryInfo info) == BatteryStatus.HasSystemBattery)
            {
                Console.WriteLine(info);
            }

            Window = Toolkit.Window.Create(new OpenGLGraphicsApiHints() { Version = new Version(3, 3) });
            OpenGLContextHandle context = Toolkit.OpenGL.CreateFromWindow(Window);
            if (Toolkit.OpenGL.SetCurrentContext(context) == false)
            {
                Console.WriteLine("Could not set context!");
            }
            GLLoader.LoadBindings(Toolkit.OpenGL.GetBindingsContext(context));

            Toolkit.OpenGL.SetSwapInterval(1);
            int swap = Toolkit.OpenGL.GetSwapInterval();

            Toolkit.Window.SetPosition(Window, (100, 100));
            Toolkit.Window.SetSize(Window, (400, 400));
            Toolkit.Window.SetMinClientSize(Window, 300, 300);
            Toolkit.Window.SetMaxClientSize(Window, 500, 500);
            Toolkit.Window.SetMode(Window, WindowMode.Normal);
            //Toolkit.Window.SetAlwaysOnTop(window, true);

            //Console.WriteLine($"Preferred theme: {Toolkit.Shell.GetPreferredTheme()}");

            Console.WriteLine($"Number of screens: {Toolkit.Display.GetDisplayCount()}");

            {
                var primary = Toolkit.Display.OpenPrimary();
                string name = Toolkit.Display.GetName(primary);
                float refreshRate = Toolkit.Display.GetRefreshRate(primary);
                Vector2i virtualPosition = Toolkit.Display.GetVirtualPosition(primary);
                Vector2i resolution = Toolkit.Display.GetResolution(primary);
                Box2i workArea = Toolkit.Display.GetWorkArea(primary);
                VideoMode videoMode = Toolkit.Display.GetVideoMode(primary);
                VideoMode[] modes = Toolkit.Display.GetSupportedVideoModes(primary);

                Console.WriteLine($"Primary display: {name}");
                Console.WriteLine($"Refresh rate: {refreshRate}Hz");
                Console.WriteLine($"Position: ({virtualPosition.X},{virtualPosition.Y})");
                Console.WriteLine($"Resolution: {resolution.X}x{resolution.Y}");
                Console.WriteLine($"Work area: {workArea.Location} {workArea.Size}");
                Console.WriteLine($"Video mode: {videoMode}");
                Console.WriteLine($"Supported video modes:");
                foreach (var mode in modes)
                {
                    Console.WriteLine($"  {mode}");
                }
            }

            Console.WriteLine($"Is always on top: {Toolkit.Window.IsAlwaysOnTop(Window)}");



            {
                Toolkit.Window.GetMinClientSize(Window, out int? minWidth, out int? minHeight);
                Console.WriteLine($"Window min size: ({minWidth}, {minHeight})");
            }

            Stopwatch watch = Stopwatch.StartNew();

            SystemCursorType cursor = SystemCursorType.Default;
            cursorHandle = Toolkit.Cursor.Create(cursor);

            //Toolkit.Cursor.GetSize(cursorHandle, out int cWidth, out int cHeight);
            //Console.WriteLine($"Default cursor size: {cWidth}, {cHeight}");

            Toolkit.Window.SetCursor(Window, cursorHandle);

            byte[] image = new byte[16 * 16 * 3];
            image = new byte[16 * 16 * 4];
            byte[] mask = new byte[16 * 16 * 1];
            for (int ccx = 0; ccx < 16; ccx++)
            {
                for (int ccy = 0; ccy < 16; ccy++)
                {
                    //int index = (ccy * 16 + ccx) * 3;

                    //image[index + 0] = (byte)(ccx * 16);
                    //image[index + 1] = (byte)(ccx * 16);
                    //image[index + 2] = (byte)(ccx * 16);

                    int index = (ccy * 16 + ccx) * 4;
                    
                    image[index + 0] = (byte)(ccx * 16);
                    image[index + 1] = (byte)(ccx * 16);
                    image[index + 2] = (byte)(ccx * 16);
                    image[index + 3] = (byte)((ccy % 2 == 0) ? 255 : 0);

                    //mask[(ccy * 16 + ccx)] = (byte)((ccy % 2 == 0) ? 1 : 0);
                }
            }
            cursorHandle = Toolkit.Cursor.Create(16, 16, image, 8, 8);
            Toolkit.Cursor.GetSize(cursorHandle, out int cWidth, out int cHeight);
            Console.WriteLine($"Custom cursor size: {cWidth}, {cHeight}");
            //Toolkit.Cursor.SetHotspot(cursorHandle, 7, 7);
            Toolkit.Window.SetCursor(Window, cursorHandle);

            //var icon = Toolkit.Icon.Create(16, 16, image);
            //Toolkit.Window.SetIcon(Window, icon);
            GenerateAndSetWindowIcon(Window);

            while (Toolkit.Window.IsWindowDestroyed(Window) == false)
            {
                Toolkit.Window.ProcessEvents(false);

                if (Toolkit.Window.IsWindowDestroyed(Window))
                    break;

                if (windowMode != WindowMode.Hidden)
                {
                    watch.Restart();
                }

                if (watch.ElapsedMilliseconds > 3000 && windowMode == WindowMode.Hidden)
                {
                    //Toolkit.Window.FocusWindow(window);
                    Toolkit.Window.RequestAttention(Window);

                    Toolkit.Window.SetMode(Window, WindowMode.Normal);

                    watch.Restart();

                    //Toolkit.Cursor.Load(cursorHandle, cursor);
                    //Toolkit.Window.SetCursor(window, cursorHandle);

                    cursor++;
                    if (cursor > SystemCursorType.ArrowUp)
                        cursor = SystemCursorType.Default;
                }
                
                //mouseComp.GetPosition(null, out int x, out int y);
                //Toolkit.Window.SetTitle(window,  $"Mouse: ({x}, {y})");
                
                GL.ClearColor(BackgroundColor);
                GL.Clear(ClearBufferMask.ColorBufferBit);

                Toolkit.OpenGL.SwapBuffers(context);
            }
        }

        static void GenerateAndSetWindowIcon(WindowHandle handle)
        {
            byte[] image16 = new byte[16 * 16 * 4];
            for (int ccx = 0; ccx < 16; ccx++)
            {
                for (int ccy = 0; ccy < 16; ccy++)
                {
                    int index = (ccy * 16 + ccx) * 4;
                    
                    image16[index + 0] = (byte)(ccx * 16);
                    image16[index + 1] = (byte)(ccx * 16);
                    image16[index + 2] = (byte)(ccy * 16);
                    image16[index + 3] = (byte)((ccy % 2 == 0) ? 255 : 0);
                }
            }

            byte[] image128 = new byte[128 * 128 * 4];
            for (int ccx = 0; ccx < 128; ccx++)
            {
                for (int ccy = 0; ccy < 128; ccy++)
                {
                    int index = (ccy * 128 + ccx) * 4;
                    
                    image128[index + 0] = (byte)((ccx / 128f) * 255);
                    image128[index + 1] = (byte)((ccx / 128f) * 255);
                    image128[index + 2] = (byte)((ccy / 128f) * 255);
                    image128[index + 3] = (byte)((ccy % 4 == 0) ? 255 : 0);
                }
            }

            if (OperatingSystem.IsWindows())
            {
                IconHandle icon = Toolkit.Icon.Create(16, 16, image16);
                Toolkit.Window.SetIcon(handle, icon);
            }
            else if (OperatingSystem.IsLinux())
            {
                X11IconComponent.IconImage[] images = new X11IconComponent.IconImage[]
                {
                    new X11IconComponent.IconImage()
                    {
                        Width = 128,
                        Height = 128,
                        Data = image128,
                    },
                    new X11IconComponent.IconImage()
                    {
                        Width = 16,
                        Height = 16,
                        Data = image16,
                    },
                };

                IconHandle icon = (Toolkit.Icon as X11IconComponent)?.Create(128, 128, images) ?? throw new Exception("Could not create icon.");
                Toolkit.Window.SetIcon(handle, icon);
            }
        }

        static CursorCaptureMode captureMode = CursorCaptureMode.Normal;
        static WindowMode windowMode = WindowMode.Normal;

        static Vector2 lastPos;

        static bool client = false;

        static WindowBorderStyle borderStyle = WindowBorderStyle.ResizableBorder;

        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            //Console.WriteLine(type);

            if (args is CloseEventArgs close)
            {
                Toolkit.Window.Destroy(close.Window);
            }
            else if (args is MouseButtonDownEventArgs buttonDown)
            {
                Console.WriteLine($"Mouse button: {buttonDown.Button}");

                if (buttonDown.Button == MouseButton.Button3)
                {
                    //captureMode++;
                    //captureMode = (CursorCaptureMode)((int)captureMode % 3);
                    //Toolkit.Window.CaptureCursor((WindowHandle)handle, captured);
                    //Toolkit.Window.SetCursorCaptureMode((WindowHandle)handle, captureMode);

                    windowMode++;
                    windowMode = (WindowMode)((int)windowMode % 6);
                    Toolkit.Window.SetMode(Window, windowMode);
                    Console.WriteLine($"Set window mode to: {windowMode}");
                    Thread.Sleep(100);
                    Console.WriteLine($" GetMode: {Toolkit.Window.GetMode(Window)}");

                    //Toolkit.Window.SetMode((WindowHandle)handle, WindowMode.ExclusiveFullscreen);
                }
                else if (buttonDown.Button == MouseButton.Button2)
                {
                    Toolkit.Window.GetMaxClientSize(Window, out int? bMaxWidth, out int? bMaxHeight);
                    Toolkit.Window.GetMinClientSize(Window, out int? bMinWidth, out int? bMinHeight);

                    borderStyle++;
                    borderStyle = (WindowBorderStyle)((int)borderStyle % 4);

                    Toolkit.Window.SetBorderStyle(Window, borderStyle);
                    Console.WriteLine($"Set border style to: {borderStyle}, GetBorderStyle: {Toolkit.Window.GetBorderStyle(Window)}");

                    Toolkit.Window.GetMaxClientSize(Window, out int? aMaxWidth, out int? aMaxHeight);
                    Toolkit.Window.GetMinClientSize(Window, out int? aMinWidth, out int? aMinHeight);

                    Console.WriteLine($"Before: Min: ({bMinWidth}, {bMinHeight}), Max: ({bMaxWidth}, {bMaxHeight})");
                    Console.WriteLine($"After: Min: ({aMinWidth}, {aMinHeight}), Max: ({aMaxWidth}, {aMaxHeight})");
                }
                else if (buttonDown.Button == MouseButton.Button1)
                {
                    /*
                    mouseComp.GetPosition(out int x, out int y);

                    //Toolkit.Window.SetMode(Window, WindowMode.Hidden);
                    if (client)
                    {
                        Toolkit.Window.SetClientSize(Window, 400, 400);
                    }
                    else
                    {
                        Toolkit.Window.SetSize(Window, 400, 400);
                    }

                    Toolkit.Window.GetSize(Window, out int wx, out int wy);
                    Toolkit.Window.GetClientSize(Window, out int cx, out int cy);
                    System.Console.WriteLine($"Size: ({wx}, {wy}), Client size: ({cx}, {cy}), Set client size: {client}");

                    client = !client;
                    */

                    ClipboardFormat format = Toolkit.Clipboard.GetClipboardFormat();
                    Console.WriteLine($"Clipboard format: {format}");

                    if (format == ClipboardFormat.Files)
                    {
                        var files = Toolkit.Clipboard.GetClipboardFiles();
                        System.Console.WriteLine("Copied files: ");
                        for (int i = 0; i < files?.Count; i++)
                        {
                            System.Console.WriteLine($"  {files[i]}");
                        }
                    }

                    //string? clip = Toolkit.Clipboard.GetClipboardText();
                    //Console.WriteLine($"Clipboard text: {clip.Length.ToString() ?? "null"}");

                    //keyboardComp.BeginIme(Window);
                    //keyboardComp.SetImeRectangle(Window, x, y, 0, 0);
                }
            }
            else if (args is MouseButtonUpEventArgs buttonUp)
            {
                Console.WriteLine($"Mouse button up: {buttonUp.Button}");
            }
            else if (args is WindowResizeEventArgs resize)
            {
                Console.WriteLine($"Resize! {resize.NewSize.X} {resize.NewSize.Y}");

                GL.Viewport(0, 0, resize.NewSize.X, resize.NewSize.Y);
            }
            else if (args is ScrollEventArgs scroll)
            {
                Console.WriteLine($"Scroll: {scroll.Delta}, Distance: {scroll.Distance}");
            }
            else if (args is MouseMoveEventArgs move)
            {
                Toolkit.Window.SetTitle(move.Window, $"Mouse: {move.ClientPosition}");

                //Console.WriteLine($"Delta: {move.Position - lastPos}");

                lastPos = move.ClientPosition;
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
                        (Toolkit.Shell as Native.Windows.ShellComponent)?.SetImmersiveDarkMode(Window, false);
                        break;
                    case AppTheme.Dark:
                        BackgroundColor = newTheme.HighContrast ? ContrastDarkModeColor : DarkModeColor;
                        (Toolkit.Shell as Native.Windows.ShellComponent)?.SetImmersiveDarkMode(Window, true);
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
            else if (args is InputLanguageChangedEventArgs inputLanguageChange)
            {
                Console.WriteLine($"New keyboard layout: {inputLanguageChange.InputLanguage.LayoutName}");
                Console.WriteLine($"New input language: {inputLanguageChange.InputLanguage.Culture.ThreeLetterISOLanguageName}");
            }
        }
    }
}
