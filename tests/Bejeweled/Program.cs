using OpenTK.Core.Platform;
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

namespace Bejeweled
{
    internal class Program
    {
        private static ILogger Logger;

        internal static WindowHandle Window;
        internal static OpenGLContextHandle Context;

        internal static Bejeweled Bejeweled;

        public readonly static GLDebugProc DebugProcCallback = Window_DebugProc;

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

#if RELEASE
#else
            Logger = new DebugLogger();
#endif
            Logger = new DebugFileLogger("Bejeweled_debug.log");

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
            Toolkit.Display.GetWorkArea(mainDisplay, out Box2i area);
            int minWorkDimention = Math.Max(400, (int)(Math.Min(area.Height, area.Width) * 0.9f));

            Window = Toolkit.Window.Create(openglSettings);
            Toolkit.Window.SetTitle(Window, $"Bejeweled");
            Toolkit.Window.SetSize(Window, minWorkDimention, minWorkDimention);
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
                (Toolkit.Window as OpenTK.Platform.Native.macOS.MacOSWindowComponent)?.SetDockIcon(Window, icon);
            }

            CursorHandle cursor;
            if (Toolkit.Cursor is OpenTK.Platform.Native.Windows.CursorComponent win32Cursor)
            {
                cursor = win32Cursor.CreateFromCurResorce("gold_orb_pointer");
            }
            else
            {
                // FIXME: On mac we can animate this cursor by loading all of the GIF frames and putting them in an animated cursor...
                StbImageSharp.ImageResult result = StbImageSharp.ImageResult.FromStream(File.Open("./Assets/Cursor/Gold Orb_pointer.gif", FileMode.Open), StbImageSharp.ColorComponents.RedGreenBlueAlpha);
                cursor = Toolkit.Cursor.Create(result.Width, result.Height, result.Data, 0, 0);
            }
            Toolkit.Window.SetCursor(Window, cursor);

            Toolkit.Window.SetMode(Window, WindowMode.Normal);

            //ApplicationWindow bejeweled = new ApplicationWindow(handle);
            Context = Toolkit.OpenGL.CreateFromWindow(Window);
            Toolkit.OpenGL.SetCurrentContext(Context);
            Toolkit.OpenGL.SetSwapInterval(1);
            GLLoader.LoadBindings(Toolkit.OpenGL.GetBindingsContext(Context));
            Bejeweled = new Bejeweled();
            Bejeweled.Initialize(Window, Context, false, Logger);

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

        private static void Window_DebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr messagePtr, IntPtr userParam)
        {
            string message = Marshal.PtrToStringAnsi(messagePtr, length);

            bool showMessage = true;

            switch (source)
            {
                case DebugSource.DebugSourceApplication:
                    showMessage = false;
                    break;
                case DebugSource.DontCare:
                case DebugSource.DebugSourceApi:
                case DebugSource.DebugSourceWindowSystem:
                case DebugSource.DebugSourceShaderCompiler:
                case DebugSource.DebugSourceThirdParty:
                case DebugSource.DebugSourceOther:
                default:
                    showMessage = true;
                    break;
            }

            if (showMessage)
            {
                switch (severity)
                {
                    case DebugSeverity.DontCare:
                        Logger?.LogInfo($"[DontCare] [{source}] {message}");
                        break;
                    case DebugSeverity.DebugSeverityNotification:
                        //Logger?.LogDebug($"[{source}] {message}");
                        break;
                    case DebugSeverity.DebugSeverityHigh:
                        Logger?.LogError($"[{source}] {message}");
                        break;
                    case DebugSeverity.DebugSeverityMedium:
                        Logger?.LogWarning($"[{source}] {message}");
                        break;
                    case DebugSeverity.DebugSeverityLow:
                        Logger?.LogInfo($"[{source}] {message}");
                        break;
                    default:
                        Logger?.LogInfo($"[default] [{source}] {message}");
                        break;
                }
            }
        }
    }
}
