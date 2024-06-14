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

            OpenGLGraphicsApiHints openglSettings = new OpenGLGraphicsApiHints()
            {
                DoubleBuffer = true,
                Version = new Version(4, 1),
                Profile = OpenGLProfile.Core,
                ForwardCompatibleFlag = true,
                //Multisamples = 4,
                //sRGBFramebuffer = true,
                DebugFlag = true,
            };

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
            }

            CursorHandle cursor;
            if (Toolkit.Cursor is OpenTK.Platform.Native.Windows.CursorComponent win32Cursor)
            {
                cursor = win32Cursor.CreateFromCurResorce("gold_orb_pointer");
            }
            else
            {
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

                Toolkit.Window.ProcessEvents();
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
