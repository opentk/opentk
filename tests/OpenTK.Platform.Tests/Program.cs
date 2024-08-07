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
        static IWindowComponent windowComp;
        static IOpenGLComponent glComp;
        static ICursorComponent cursorComp;
        static IMouseComponent mouseComp;
        static IShellComponent shellComp;
        static IIconComponent iconComp;
        static IClipboardComponent clipComp;
        //static IKeyboardComponent keyboardComp;

        static IDisplayComponent displayComp;

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

            //Native.PlatformComponents.PreferSDL2 = true;
            windowComp = PlatformComponents.CreateWindowComponent();
            glComp = PlatformComponents.CreateOpenGLComponent();
            cursorComp = PlatformComponents.CreateCursorComponent();
            mouseComp = PlatformComponents.CreateMouseComponent();
            shellComp = PlatformComponents.CreateShellComponent();
            displayComp = PlatformComponents.CreateDisplayComponent();
            iconComp = PlatformComponents.CreateIconComponent();
            clipComp = PlatformComponents.CreateClipboardComponent();
            //keyboardComp = Native.PlatformComponents.CreateKeyboardComponent();

            ToolkitOptions options = new ToolkitOptions() { Logger = new ConsoleLogger() };

            windowComp.Logger = options.Logger;
            glComp.Logger = options.Logger;
            cursorComp.Logger = options.Logger;
            mouseComp.Logger = options.Logger;
            shellComp.Logger = options.Logger;
            displayComp.Logger = options.Logger;
            iconComp.Logger = options.Logger;
            clipComp.Logger = options.Logger;
            //keyboardComp.Logger = logger;

            windowComp.Initialize(options);
            glComp.Initialize(options);
            cursorComp.Initialize(options);
            mouseComp.Initialize(options);
            shellComp.Initialize(options);
            displayComp.Initialize(options);
            iconComp.Initialize(options);
            clipComp.Initialize(options);
            //keyboardComp.Initialize(PalComponents.KeyboardInput);

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

            {
                var primary = displayComp.OpenPrimary();
                string name = displayComp.GetName(primary);
                displayComp.GetRefreshRate(primary, out float refreshRate);
                displayComp.GetVirtualPosition(primary, out int x, out int y);
                displayComp.GetResolution(primary, out int width, out int height);
                displayComp.GetWorkArea(primary, out Box2i workArea);
                displayComp.GetVideoMode(primary, out VideoMode videoMode);
                VideoMode[] modes = displayComp.GetSupportedVideoModes(primary);

                Console.WriteLine($"Primary display: {name}");
                Console.WriteLine($"Refresh rate: {refreshRate}Hz");
                Console.WriteLine($"Position: ({x},{y})");
                Console.WriteLine($"Resolution: {width}x{height}");
                Console.WriteLine($"Work area: {workArea.Location} {workArea.Size}");
                Console.WriteLine($"Video mode: {videoMode}");
                Console.WriteLine($"Supported video modes:");
                foreach (var mode in modes)
                {
                    Console.WriteLine($"  {mode}");
                }
            }

            Console.WriteLine($"Is always on top: {windowComp.IsAlwaysOnTop(Window)}");



            {
                windowComp.GetMinClientSize(Window, out int? minWidth, out int? minHeight);
                Console.WriteLine($"Window min size: ({minWidth}, {minHeight})");
            }

            Stopwatch watch = Stopwatch.StartNew();

            SystemCursorType cursor = SystemCursorType.Default;
            cursorHandle = cursorComp.Create(cursor);

            //cursorComp.GetSize(cursorHandle, out int cWidth, out int cHeight);
            //Console.WriteLine($"Default cursor size: {cWidth}, {cHeight}");

            windowComp.SetCursor(Window, cursorHandle);

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
            cursorHandle = cursorComp.Create(16, 16, image, 8, 8);
            cursorComp.GetSize(cursorHandle, out int cWidth, out int cHeight);
            Console.WriteLine($"Custom cursor size: {cWidth}, {cHeight}");
            //cursorComp.SetHotspot(cursorHandle, 7, 7);
            windowComp.SetCursor(Window, cursorHandle);

            //var icon = iconComp.Create(16, 16, image);
            //windowComp.SetIcon(Window, icon);
            GenerateAndSetWindowIcon(Window);

            while (windowComp.IsWindowDestroyed(Window) == false)
            {
                windowComp.ProcessEvents(false);

                if (windowComp.IsWindowDestroyed(Window))
                    break;

                if (windowMode != WindowMode.Hidden)
                {
                    watch.Restart();
                }

                if (watch.ElapsedMilliseconds > 3000 && windowMode == WindowMode.Hidden)
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

                glComp.SwapBuffers(context);
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
                IconHandle icon = iconComp.Create(16, 16, image16);
                windowComp.SetIcon(handle, icon);
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

                IconHandle icon = (iconComp as X11IconComponent)?.Create(128, 128, images) ?? throw new Exception("Could not create icon.");
                windowComp.SetIcon(handle, icon);
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
                windowComp.Destroy(close.Window);
            }
            else if (args is MouseButtonDownEventArgs buttonDown)
            {
                Console.WriteLine($"Mouse button: {buttonDown.Button}");

                if (buttonDown.Button == MouseButton.Button3)
                {
                    //captureMode++;
                    //captureMode = (CursorCaptureMode)((int)captureMode % 3);
                    //windowComp.CaptureCursor((WindowHandle)handle, captured);
                    //windowComp.SetCursorCaptureMode((WindowHandle)handle, captureMode);

                    windowMode++;
                    windowMode = (WindowMode)((int)windowMode % 6);
                    windowComp.SetMode(Window, windowMode);
                    Console.WriteLine($"Set window mode to: {windowMode}");
                    Thread.Sleep(100);
                    Console.WriteLine($" GetMode: {windowComp.GetMode(Window)}");

                    //windowComp.SetMode((WindowHandle)handle, WindowMode.ExclusiveFullscreen);
                }
                else if (buttonDown.Button == MouseButton.Button2)
                {
                    windowComp.GetMaxClientSize(Window, out int? bMaxWidth, out int? bMaxHeight);
                    windowComp.GetMinClientSize(Window, out int? bMinWidth, out int? bMinHeight);

                    borderStyle++;
                    borderStyle = (WindowBorderStyle)((int)borderStyle % 4);

                    windowComp.SetBorderStyle(Window, borderStyle);
                    Console.WriteLine($"Set border style to: {borderStyle}, GetBorderStyle: {windowComp.GetBorderStyle(Window)}");

                    windowComp.GetMaxClientSize(Window, out int? aMaxWidth, out int? aMaxHeight);
                    windowComp.GetMinClientSize(Window, out int? aMinWidth, out int? aMinHeight);

                    Console.WriteLine($"Before: Min: ({bMinWidth}, {bMinHeight}), Max: ({bMaxWidth}, {bMaxHeight})");
                    Console.WriteLine($"After: Min: ({aMinWidth}, {aMinHeight}), Max: ({aMaxWidth}, {aMaxHeight})");
                }
                else if (buttonDown.Button == MouseButton.Button1)
                {
                    /*
                    mouseComp.GetPosition(out int x, out int y);

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
                    */

                    ClipboardFormat format = clipComp.GetClipboardFormat();
                    Console.WriteLine($"Clipboard format: {format}");

                    if (format == ClipboardFormat.Files)
                    {
                        var files = clipComp.GetClipboardFiles();
                        System.Console.WriteLine("Copied files: ");
                        for (int i = 0; i < files.Count; i++)
                        {
                            System.Console.WriteLine($"  {files[i]}");
                        }
                    }

                    //string? clip = clipComp.GetClipboardText();
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
            else if (args is InputLanguageChangedEventArgs inputLanguageChange)
            {
                Console.WriteLine($"New keyboard layout: {inputLanguageChange.KeyboardLayout}");
                Console.WriteLine($"New input language: {inputLanguageChange.InputLanguage}, {inputLanguageChange.InputLanguageDisplayName}");
            }
        }
    }
}
