using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using StbImageSharp;
using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;

namespace OpenTK.Backends.Tests
{
    internal class Program
    {
        public static ILogger Logger = new ModularLogger() { new ConsoleLogger() };

        public readonly static GLDebugProc DebugProcCallback = Window_DebugProc;

        public static IWindowComponent WindowComp;
        public static IOpenGLComponent OpenGLComp;
        public static IIconComponent? IconComponent;
        public static ICursorComponent? CursorComp;
        public static IDisplayComponent? DisplayComponent;
        public static IMouseComponent? MouseComponent;
        public static IKeyboardComponent? KeyboardComponent;
        public static IClipboardComponent? ClipboardComponent;
        public static IShellComponent? ShellComponent;
        public static IJoystickComponent? JoystickComponent;

        public static WindowManager WindowManager { get; private set; }

        public static WindowHandle Window;
        static OpenGLContextHandle OpenGLContext;

        static ImGuiController ImGuiController;
        static InputData InputData = new InputData();

        static ImGuiMouseCursor prevCursor;

        static readonly MainTabContainer MainTabContainer = new MainTabContainer()
        {
            new OverviewView(),
            new WindowComponentView(),
            new OpenGLComponentView(),
            new DisplayComponentView(),
            new CursorComponentView(),
            new IconComponentView(),
            new ClipboardComponentView(),
            new ShellComponentView(),
        };

        static void Main(string[] args)
        {
            EventQueue.EventRaised += EventQueue_EventRaised;

            BackendsConfig.Logger = Logger;

            BackendsConfig.Singleton.PreferSDL2 = false;

            foreach (PalComponents component in Enum.GetValues<PalComponents>())
            {
                try
                {
                    IPalComponent? driver = BackendsConfig.GetBackend(component);
                    if (driver != null)
                    {
                        switch (component)
                        {
                        case PalComponents.Window:        WindowComp =         (IWindowComponent)   driver; break;
                        case PalComponents.OpenGL:        OpenGLComp =         (IOpenGLComponent)   driver; break;
                        case PalComponents.WindowIcon:    IconComponent =      (IIconComponent)     driver; break;
                        case PalComponents.MouseCursor:   CursorComp =         (ICursorComponent)   driver; break;
                        case PalComponents.Display:       DisplayComponent =   (IDisplayComponent)  driver; break;
                        case PalComponents.MiceInput:     MouseComponent =     (IMouseComponent)    driver; break;
                        case PalComponents.KeyboardInput: KeyboardComponent =  (IKeyboardComponent) driver; break;
                        case PalComponents.Clipboard:     ClipboardComponent = (IClipboardComponent)driver; break;
                        case PalComponents.Shell:         ShellComponent =     (IShellComponent)    driver; break;
                        case PalComponents.Joystick:      JoystickComponent =  (IJoystickComponent) driver; break;
                        }
                        driver.Logger = Logger;
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogError($"Could not initialize component {component}: {ex}\n{ex.StackTrace}");
                }
            }

            WindowComp.Initialize(PalComponents.Window);
            OpenGLComp.Initialize(PalComponents.OpenGL);
            CursorComp?.Initialize(PalComponents.MouseCursor);
            IconComponent?.Initialize(PalComponents.WindowIcon);
            DisplayComponent?.Initialize(PalComponents.Display);
            MouseComponent?.Initialize(PalComponents.MiceInput);
            KeyboardComponent?.Initialize(PalComponents.KeyboardInput);
            ClipboardComponent?.Initialize(PalComponents.Clipboard);
            ShellComponent?.Initialize(PalComponents.Shell);
            JoystickComponent?.Initialize(PalComponents.Joystick);

            OpenGLGraphicsApiHints hints = new OpenGLGraphicsApiHints()
            {
                Version = new Version(4, 1),
                Profile = OpenGLProfile.Core,
                ForwardCompatibleFlag = true,
                DebugFlag = true,

                DoubleBuffer = true,
            };

            Window = WindowComp.Create(hints);
            OpenGLContext = OpenGLComp.CreateFromWindow(Window);
            OpenGLComp.SetCurrentContext(OpenGLContext);
            GLLoader.LoadBindings(OpenGLComp.GetBindingsContext(OpenGLContext));

            static bool IsExtensionSupported(string name)
            {
                int n = GL.GetInteger(GetPName.NumExtensions);
                for (int i = 0; i < n; i++)
                {
                    string extension = GL.GetStringi(StringName.Extensions, (uint)i)!;
                    if (extension == name) return true;
                }

                return false;
            }

            int major = GL.GetInteger(GetPName.MajorVersion);
            int minor = GL.GetInteger(GetPName.MinorVersion);
            bool KHRDebugAvailable = (major == 4 && minor >= 3) || IsExtensionSupported("KHR_debug") || IsExtensionSupported("GL_KHR_debug");

            if (KHRDebugAvailable)
            {
                GL.DebugMessageCallback(DebugProcCallback, IntPtr.Zero);
                GL.Enable(EnableCap.DebugOutput);
                GL.Enable(EnableCap.DebugOutputSynchronous);
            }

            WindowManager = new WindowManager(WindowComp, OpenGLComp, Window, OpenGLContext);

            WindowComp.SetTitle(Window, "OpenTK PAL Test Application");
            WindowComp.SetClientSize(Window, 800, 600);
            WindowComp.SetMode(Window, WindowMode.Normal);

            try
            {
                if (WindowComp.CanSetIcon)
                {
                    IconHandle? handle;
                    if (OperatingSystem.IsWindows())
                    {
                        // Here are three ways to load .ico file on windows, in increasing complexity.
                        // First, just load the .ico as a file.
                        handle = (IconComponent as Platform.Native.Windows.IconComponent)?.CreateFromIcoFile("Resources/opentk_logo_small.ico");
                        // Second, use a resx file and load that. This will result in a ico with a single resolution instead of adaptive.
                        handle = (IconComponent as Platform.Native.Windows.IconComponent)?.CreateFromIcoResource(Icons.opentk_logo_small_ico);
                        // Last, create a .rc file, add an icon to that resource file, add a target to your csproj to compile the .rc file
                        // use <Win32Resource> to include the resulting .res file in the exe.
                        handle = (IconComponent as Platform.Native.Windows.IconComponent)?.CreateFromIcoResource("OPENTK_ICO");
                    }
                    else
                    {
                        ImageResult icon = ImageResult.FromMemory(Icons.opentk_logo_small_png, ColorComponents.RedGreenBlueAlpha);
                        handle = IconComponent?.Create(icon.Width, icon.Height, icon.Data);
                    }

                    if (handle != null)
                    {
                        WindowComp.SetIcon(Window, handle);

                        // FIXME: Should we destroy the icon?
                        IconComponent?.Destroy(handle);
                    }
                }
            } catch
            {

            }

            // FIXME: Here we want to get the pixel size of the backbuffer.
            WindowComp.GetClientSize(Window, out int width, out int height);
            GL.Viewport(0, 0, width, height);

            //ImGuiController = new ImGuiController(width, height);
            // FIXME:
            ImGuiController = new ImGuiController(width, height);

            if (CursorComp != null && CursorComp.CanLoadSystemCursors)
            {
                CursorHandle defaultCursor = CursorComp.Create(SystemCursorType.Default);
                WindowComp.SetCursor(Window, defaultCursor);

                ImGui.GetIO().BackendFlags |= ImGuiBackendFlags.HasMouseCursors;
            }

            MainTabContainer.Initialize();

            Stopwatch watch = Stopwatch.StartNew();

            while (true)
            {
                float dt = (float)watch.Elapsed.TotalSeconds;
                watch.Restart();

                // FIXME: Wait for events?
                WindowComp.ProcessEvents();

                if (WindowComp.IsWindowDestroyed(Window))
                {
                    break;
                }

                Update(dt);

                OpenGLComp.SetCurrentContext(OpenGLContext);
                Render();

                WindowManager.RenderChildWindows();
            }
        }

        static void Update(float dt)
        {
            if (CursorComp != null && CursorComp.CanLoadSystemCursors)
            {
                ImGuiConfigFlags flags = ImGui.GetIO().ConfigFlags;
                if ((flags & ImGuiConfigFlags.NoMouseCursorChange) == 0)
                {
                    var imguiCursor = ImGui.GetMouseCursor();
                    if (imguiCursor != prevCursor)
                    {
                        CursorHandle? cursor;
                        switch (imguiCursor)
                        {
                            case ImGuiMouseCursor.None:
                                cursor = null;
                                break;
                            case ImGuiMouseCursor.Arrow:
                                cursor = CursorComp.Create(SystemCursorType.Default);
                                break;
                            case ImGuiMouseCursor.TextInput:
                                cursor = CursorComp.Create(SystemCursorType.TextBeam);
                                break;
                            case ImGuiMouseCursor.ResizeAll:
                                cursor = CursorComp.Create(SystemCursorType.ArrowFourway);
                                break;
                            case ImGuiMouseCursor.ResizeNS:
                                cursor = CursorComp.Create(SystemCursorType.ArrowNS);
                                break;
                            case ImGuiMouseCursor.ResizeEW:
                                cursor = CursorComp.Create(SystemCursorType.ArrowEW);
                                break;
                            case ImGuiMouseCursor.ResizeNESW:
                                cursor = CursorComp.Create(SystemCursorType.ArrowNESW);
                                break;
                            case ImGuiMouseCursor.ResizeNWSE:
                                cursor = CursorComp.Create(SystemCursorType.ArrowNWSE);
                                break;
                            case ImGuiMouseCursor.Hand:
                                cursor = CursorComp.Create(SystemCursorType.Hand);
                                break;
                            case ImGuiMouseCursor.NotAllowed:
                                cursor = CursorComp.Create(SystemCursorType.Forbidden);
                                break;
                            default:
                                cursor = null;
                                break;
                        }
                        // FIXME: We are leaking the previous cursor.
                        // Or should the window contain it's own copy?
                        WindowComp.SetCursor(Window, cursor);
                    }
                    prevCursor = imguiCursor;
                }
            }

            ImGuiController.Update(InputData, dt);

            MainTabContainer.Paint();

            //ImGui.ShowDemoWindow();
        }

        static void Render()
        {
            GL.ClearColor(Color4.Coral);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);

            ImGuiController.Render();

            WindowComp.SwapBuffers(Window);
        }

        static ImGuiKey ToImgui(Key key)
        {
            // FIXME: Rest of the keycodes.
            switch (key)
            {
                case Key.Return: return ImGuiKey.Enter;
                case Key.Escape: return ImGuiKey.Escape;
                case Key.Tab: return ImGuiKey.Tab;
                case Key.Backspace: return ImGuiKey.Backspace;

                case Key.PageUp: return ImGuiKey.PageUp;
                case Key.PageDown: return ImGuiKey.PageDown;

                case Key.LeftArrow: return ImGuiKey.LeftArrow;
                case Key.RightArrow: return ImGuiKey.RightArrow;
                case Key.UpArrow: return ImGuiKey.UpArrow;
                case Key.DownArrow: return ImGuiKey.DownArrow;

                case Key.LeftShift: return ImGuiKey.LeftShift;
                case Key.RightShift: return ImGuiKey.RightShift;

                case Key.LeftControl: return ImGuiKey.LeftCtrl;
                case Key.RightControl: return ImGuiKey.RightCtrl;

                case Key.LeftAlt: return ImGuiKey.LeftAlt;
                case Key.RightAlt: return ImGuiKey.RightAlt;

                case Key.LeftGUI: return ImGuiKey.LeftSuper;
                case Key.RightGUI: return ImGuiKey.RightSuper;

                default: return ImGuiKey.None;
            }
        }

        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            if (args is WindowEventArgs windowEvent && windowEvent.Window != Window)
            {
                if (args is CloseEventArgs close2)
                {
                    WindowManager.RemoveWindow(close2.Window);
                    WindowComp.Destroy(close2.Window);
                }
                return;
            }

            if (args is CloseEventArgs close)
            {
                WindowComp.Destroy(close.Window);
            }
            else if (args is KeyDownEventArgs keyDown)
            {
                ImGuiKey ikey = ToImgui(keyDown.Key);

                ImGui.GetIO().AddKeyEvent(ikey, true);

                // FIXME: Track modifiers!

                InputData.KeysPressed[(int)keyDown.Key] = true;
            }
            else if (args is KeyUpEventArgs keyUp)
            {
                ImGuiKey ikey = ToImgui(keyUp.Key);

                ImGui.GetIO().AddKeyEvent(ikey, false);

                InputData.KeysPressed[(int)keyUp.Key] = false;
            }
            else if (args is TextInputEventArgs textInput)
            {
                foreach(char c in textInput.Text)
                {
                    ImGui.GetIO().AddInputCharacterUTF16(c);
                }
            }
            else if (args is MouseMoveEventArgs mouseMove)
            {
                ImGui.GetIO().AddMousePosEvent(mouseMove.Position.X, mouseMove.Position.Y);
            }
            else if (args is ScrollEventArgs scroll)
            {
                ImGui.GetIO().AddMouseWheelEvent(scroll.Delta.X, scroll.Delta.Y);
            }
            else if (args is MouseButtonDownEventArgs mouseDown)
            {
                int button = ((int)mouseDown.Button);
                ImGui.GetIO().AddMouseButtonEvent(button, true);
            }
            else if (args is MouseButtonUpEventArgs mouseUp)
            {
                int button = ((int)mouseUp.Button);
                ImGui.GetIO().AddMouseButtonEvent(button, false);
            }
            else if (args is WindowResizeEventArgs resize)
            {
                if (resize.Window == Window)
                {
                    GL.Viewport(0, 0, resize.NewSize.X, resize.NewSize.Y);
                    ImGuiController?.WindowResized(resize.NewSize.X, resize.NewSize.Y);

                    if (ImGuiController != null)
                    {
                        Update(0f);
                        OpenGLComp.SetCurrentContext(OpenGLContext);
                        Render();
                    }
                }
            }
        }

        internal static IPalComponent? GetComponent(PalComponents component)
        {
            switch (component)
            {
                case PalComponents.Window: return WindowComp;
                case PalComponents.OpenGL: return OpenGLComp;
                case PalComponents.MouseCursor: return CursorComp;
                case PalComponents.WindowIcon: return IconComponent;
                case PalComponents.Display: return DisplayComponent;
                case PalComponents.MiceInput: return MouseComponent;
                case PalComponents.KeyboardInput: return KeyboardComponent;
                case PalComponents.Clipboard: return ClipboardComponent;
                case PalComponents.Shell: return ShellComponent;
                case PalComponents.Joystick: return JoystickComponent;

                default: return null;
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
