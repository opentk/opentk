using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Platform.Native;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using OpenTK.Mathematics;
using System.Text;
using Hardware.Info;
using OpenTK.Platform.Native.macOS;
using BejeweledStandalone;
using System.Threading.Tasks;

namespace Bejeweled
{
    internal class Program
    {
        internal static ILogger Logger;

#if !LIBRARY

        internal static WindowHandle Window;
        internal static OpenGLContextHandle Context;

        internal static Bejeweled Bejeweled;

        static void Main(string[] args)
        {
            if (OperatingSystem.IsMacOS())
            {
                MacOSShellComponent.NSLog($"Hello log! cwd: {Directory.GetCurrentDirectory()}");
                if (AppDomain.CurrentDomain.SetupInformation.ApplicationBase != null)
                {
                    Directory.SetCurrentDirectory(AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
                    MacOSShellComponent.NSLog($"Setting cwd to: {Directory.GetCurrentDirectory()}");
                }
                else
                {
                    MacOSShellComponent.NSLog($"Could not get the application bundle location. Relative paths will not work.");
                }
            }

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

#if RELEASE
#else
            Logger = new DebugLogger();
#endif
            Logger = new DebugFileLogger("Bejeweled_debug.log");

            //Directory.SetCurrentDirectory(Path.GetDirectoryName(typeof(Program).Assembly.Location)!);

            Logger.LogInfo($"Current path: {Directory.GetCurrentDirectory()}");

            EventQueue.EventRaised += EventQueue_EventRaised;

            ToolkitOptions options = new ToolkitOptions()
            {
                ApplicationName = "Bejeweled",
                Logger = Logger,
            };
            Toolkit.Init(options);

            // FIXME: API for more specifically enumerating available
            // OpenGL context settings.
            OpenGLGraphicsApiHints openglSettings = new OpenGLGraphicsApiHints()
            {
                DoubleBuffer = true,
                Version = new Version(4, 1),
                Profile = OpenGLProfile.Core,
                ForwardCompatibleFlag = true,
                RedColorBits = 8,
                GreenColorBits = 8,
                BlueColorBits = 8,
                Multisamples = 4,
                sRGBFramebuffer = true,
                DebugFlag = true,
                DepthBits = ContextDepthBits.Depth16,
                StencilBits = ContextStencilBits.None,
                Selector = static (options, requested, logger) => {
                    for (int i = 0; i < options.Count; i++)
                    {
                        logger?.LogInfo(options[i].ToString());
                    }

                    return ContextValues.DefaultValuesSelector(options, requested, logger);
                },
                UseSelectorOnMacOS = false,
            };

            // For now we can use Hardware.Info to debug printout the hardware config
            // which is both good for debug and allows us to do some tweaking for
            // specific hardware.
            HardwareInfo info = new HardwareInfo();
            info.RefreshOperatingSystem();
            Logger.LogInfo($"OS Name: {info.OperatingSystem.Name}, Version: {info.OperatingSystem.VersionString}");
            info.RefreshCPUList(false);
            foreach (CPU cpu in info.CpuList)
            {
                StringBuilder cpuInfo = new StringBuilder();
                cpuInfo.AppendLine("CPU Info:");
                cpuInfo.AppendLine($"Name: {cpu.Name}");
                cpuInfo.AppendLine($"Manufacturer: {cpu.Manufacturer}");
                cpuInfo.AppendLine($"Caption: {cpu.Caption}");
                cpuInfo.AppendLine($"Description: {cpu.Description}");
                cpuInfo.AppendLine($"Physical cores: {cpu.NumberOfCores}");
                cpuInfo.AppendLine($"Logical cores: {cpu.NumberOfLogicalProcessors}");
                cpuInfo.AppendLine($"Socket: {cpu.SocketDesignation}");
                cpuInfo.AppendLine($"Max clock speed: {cpu.MaxClockSpeed}MHz");
                cpuInfo.AppendLine($"L1d cache size: {cpu.L1DataCacheSize}");
                cpuInfo.AppendLine($"L1i cache size: {cpu.L1InstructionCacheSize}");
                cpuInfo.AppendLine($"L2 cache size: {cpu.L2CacheSize}");
                cpuInfo.AppendLine($"L3 cache size: {cpu.L3CacheSize}");

                Logger.LogInfo(cpuInfo.ToString());
            }
            info.RefreshVideoControllerList();
            foreach (VideoController gpu in info.VideoControllerList)
            {
                StringBuilder gpuInfo = new StringBuilder();
                gpuInfo.AppendLine("GPU Info:");
                gpuInfo.AppendLine($"Name: {gpu.Name}");
                gpuInfo.AppendLine($"Manufacturer: {gpu.Manufacturer}");
                gpuInfo.AppendLine($"Caption: {gpu.Caption}");
                gpuInfo.AppendLine($"Description: {gpu.Description}");
                gpuInfo.AppendLine($"Driver version: {gpu.DriverVersion}");
                gpuInfo.AppendLine($"Video processor: {gpu.VideoProcessor}");
                gpuInfo.AppendLine($"VRAM: {gpu.AdapterRAM}");

                Logger.LogInfo(gpuInfo.ToString());

                // Specific case for MacBook Air 2018 that struggles with MSAA on.
                if (OperatingSystem.IsMacOS() && gpu.Name == "Intel UHD Graphics 617")
                {
                    openglSettings.Multisamples = 0;
                }

                // Crank the MSAA up for GPUs that can handle it.
                if (gpu.Name.Contains("GTX 1070") || gpu.Name.Contains("RTX"))
                {
                    openglSettings.Multisamples = 16;
                }
            }

            DisplayHandle mainDisplay = Toolkit.Display.OpenPrimary();
            Box2i workArea = Toolkit.Display.GetWorkArea(mainDisplay);
            int minWorkDimention = Math.Max(400, (int)(Math.Min(workArea.Height, workArea.Width) * 0.9f));

            Window = Toolkit.Window.Create(openglSettings);
            Toolkit.Window.SetTitle(Window, $"Bejeweled");
            Toolkit.Window.SetClientBounds(Window, (workArea.Width - minWorkDimention) / 2, (workArea.Height - minWorkDimention) / 2, minWorkDimention, minWorkDimention);
            (Toolkit.Shell as OpenTK.Platform.Native.Windows.ShellComponent)?.SetImmersiveDarkMode(Window, true);
            Toolkit.Window.SetBorderStyle(Window, WindowBorderStyle.FixedBorder);

            if (OperatingSystem.IsWindows())
            {
                // We don't set the icon as we use "icons.res" to automatically set the icon for us.
            }
            else
            {
                StbImageSharp.ImageResult result = StbImageSharp.ImageResult.FromStream(File.Open("./Assets/Icon/ruby_icon.png", FileMode.Open), StbImageSharp.ColorComponents.RedGreenBlueAlpha);
                IconHandle icon = Toolkit.Icon.Create(result.Width, result.Height, result.Data);
                Toolkit.Window.SetIcon(Window, icon);

                // For macOS we set the dock icon as that is the closest thing to a window icon.
                (Toolkit.Window as OpenTK.Platform.Native.macOS.MacOSShellComponent)?.SetDockIcon(icon);
            }

            CursorHandle cursor;
            if (Toolkit.Cursor is OpenTK.Platform.Native.Windows.CursorComponent win32Cursor)
            {
                cursor = win32Cursor.CreateFromCurResorce("gold_orb_pointer");
            }
            else if (Toolkit.Cursor is OpenTK.Platform.Native.macOS.MacOSCursorComponent macOSCursor)
            {
                MacOSCursorComponent.Frame[] frames = new MacOSCursorComponent.Frame[15];
                for (int i = 0; i < 5; i++)
                {
                    // FIXME: Should we support per frame delays?
                    using Stream fileStream = File.Open($"./Assets/Cursor/Frames/Gold Orb_pointer frame_{i}.png", FileMode.Open);
                    StbImageSharp.ImageResult result = StbImageSharp.ImageResult.FromStream(fileStream, StbImageSharp.ColorComponents.RedGreenBlueAlpha);

                    frames[i].Image = result.Data;
                    frames[i].ResX = result.Width;
                    frames[i].ResY = result.Height;
                    frames[i].Width = result.Width;
                    frames[i].Height = result.Height;
                    frames[i].HotspotX = 0;
                    frames[i].HotspotY = 0;
                }
                // FIXME: This is a small hack to make the animation better while
                // we don't have per frame delays.
                for (int i = 5; i < frames.Length; i++)
                {
                    frames[i] = frames[0];
                }
                cursor = macOSCursor.Create(frames, 0.1f);
            }
            else
            {
                // FIXME: On mac we can animate this cursor by loading all of the GIF frames and putting them in an animated cursor...
                StbImageSharp.ImageResult result = StbImageSharp.ImageResult.FromStream(File.Open("./Assets/Cursor/Gold Orb_pointer.gif", FileMode.Open), StbImageSharp.ColorComponents.RedGreenBlueAlpha);
                cursor = Toolkit.Cursor.Create(result.Width, result.Height, result.Data, 0, 0);
            }
            Toolkit.Window.SetCursor(Window, cursor);

            Context = Toolkit.OpenGL.CreateFromWindow(Window);
            // FIXME: Document if CreateFromWindow should make the context current or not!
            Toolkit.OpenGL.SetCurrentContext(null);
            GLLoader.LoadBindings(Toolkit.OpenGL.GetBindingsContext(Context));
            Task loadTask = Task.Run(() => {
                Toolkit.OpenGL.SetCurrentContext(Context);
                Toolkit.OpenGL.SetSwapInterval(1);
                Bejeweled = new Bejeweled();
                Bejeweled.Initialize(Window, Context, false, Logger);
                Toolkit.OpenGL.SetCurrentContext(null);
            });

            SplashWindow.DisplaySplashWindow(0.4f, loadTask, 0.6f);

            while(loadTask.IsCompleted == false)
            {
                Toolkit.Window.ProcessEvents(false);
            }
            loadTask.Wait();
            Toolkit.OpenGL.SetCurrentContext(Context);

            Bejeweled.TransitionToGame();

            Toolkit.Window.SetMode(Window, WindowMode.Normal);
            Toolkit.Window.FocusWindow(Window);
            
            Stopwatch watch = Stopwatch.StartNew();
            while (true)
            {
                float dt = (float)watch.Elapsed.TotalSeconds;
                watch.Restart();

                Toolkit.Window.ProcessEvents(false);
                if (Toolkit.Window.IsWindowDestroyed(Window))
                {
                    break;
                }

                Bejeweled.Update(dt);
                Bejeweled.Render();
            }

            Bejeweled.Deinitialize();
            Logger.Flush();
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // On macOS when running as a bundle we don't have stdout or stderr, we also
            // don't have a reliable cwd so we can't really write to a file as we might not be
            // able to create the file (if our cwd is e.g. /). The built-in macOS crash
            // reporter can't read C# stackframes so we get no debug information from that on pure C# exception crashes.
            // So we use NSLog here to give us a way to actually get any kind of diagnostics.
            // - Noggin_bops 2024-09-04
            if (OperatingSystem.IsMacOS())
            {
                MacOSShellComponent.NSLog($"Uncaught exception:\n{e.ExceptionObject}");
            }

            Logger.LogError($"Uncaught exception:\n{e.ExceptionObject}");
            Logger.Flush();
        }

        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            // Close the window when the users closes the window.
            if (args is CloseEventArgs close)
            {
                Toolkit.Window.Destroy(close.Window);
            }
        }
#endif
    }
}
