using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.ANGLE;
using OpenTK.Platform.Native.macOS;
using StbImageSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

        public class ApplicationWindow
        {
            public WindowHandle Window;
            public OpenGLContextHandle? Context;
            public ITestApp? Application;

            public ApplicationWindow(WindowHandle window)
            {
                Window = window;
            }
        }

        public static List<ApplicationWindow> ApplicationWindows = new List<ApplicationWindow>();

        public static WindowHandle Window;
        public static OpenGLContextHandle WindowContext;

        static ImGuiController ImGuiController;
        static InputData InputData = new InputData();

        static ImGuiMouseCursor prevCursor;

        static bool IsProcessingEvents = false;

        static float CurrentImGuiScale = 1;

        static readonly MainTabContainer MainTabContainer = new MainTabContainer()
        {
            new OverviewView(),
            new WindowComponentView(),
            new OpenGLComponentView(),
            new DisplayComponentView(),
            new MouseComponentView(),
            new KeyboardComponentView(),
            new CursorComponentView(),
            new IconComponentView(),
            new ClipboardComponentView(),
            new ShellComponentView(),
            new CoordinateSpacesView(),
        };

        static void Main(string[] args)
        {
            EventQueue.EventRaised += EventQueue_EventRaised;

            BackendsConfig.Logger = Logger;

            BackendsConfig.Singleton.PreferSDL2 = false;
            BackendsConfig.Singleton.PreferANGLE = false;

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
            };

            if (BackendsConfig.Singleton.PreferANGLE)
            {
                hints.Version = new Version(3, 1);
                hints.Profile = OpenGLProfile.None;
            }

            Window = WindowComp.Create(hints);
            WindowContext = OpenGLComp.CreateFromWindow(Window);
            OpenGLComp.SetCurrentContext(WindowContext);
            GLLoader.LoadBindings(OpenGLComp.GetBindingsContext(WindowContext));

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

            WindowComp.SetTitle(Window, "OpenTK PAL Test Application");
            WindowComp.SetClientSize(Window, 800, 600);
            WindowComp.SetMode(Window, WindowMode.Normal);

            WindowComp.SetMinClientSize(Window, 700, null);
            WindowComp.SetMaxClientSize(Window, 900, null);

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
                        (WindowComp as MacOSWindowComponent)?.SetDockIcon(Window, handle);

                        // FIXME: Should we destroy the icon?
                        IconComponent?.Destroy(handle);
                    }
                }
            }
            catch
            { }

            // FIXME: Here we want to get the pixel size of the backbuffer.
            WindowComp.GetClientSize(Window, out int width, out int height);
            (WindowComp as MacOSWindowComponent)?.GetFramebufferSize(Window, out width, out height);
            GL.Viewport(0, 0, width, height);

            bool useGLES = OpenGLComp is ANGLEOpenGLComponent;
            ImGuiController = new ImGuiController(width, height, useGLES);

            float fontSize = 13f;
            try
            {
                // FIXME: For now we can't load this font on macos??
                if (DisplayComponent != null)
                {
                    DisplayHandle handle = WindowComp.GetDisplay(Window);
                    DisplayComponent.GetDisplayScale(handle, out float scaleX, out float scaleY);
                    DisplayComponent.Close(handle);

                    // FIXME: Should we only scale on Y? or something else?
                    float scale = MathF.Max(scaleX, scaleY);
                    if (scale != 1)
                    {
                        // Update font size with scale.
                        fontSize = fontSize * scale;

                        ImFontConfig config = new ImFontConfig();
                        config.FontDataOwnedByAtlas = 1;
                        config.OversampleH = 3;
                        config.OversampleV = 3;
                        config.PixelSnapH = 1;
                        config.GlyphMaxAdvanceX = float.PositiveInfinity;
                        config.RasterizerMultiply = 1;
                        config.EllipsisChar = 0xFFFF;
                        unsafe
                        {
                            
                            ImFontConfigPtr configPtr = new ImFontConfigPtr(&config);
                            ImGui.GetIO().Fonts.AddFontFromFileTTF("Resources/ProggyVector/ProggyVectorDotted.ttf", float.Floor(fontSize), configPtr);
                            ImGui.GetStyle().ScaleAllSizes(scale);
                            CurrentImGuiScale = scale;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogWarning($"Could not get scale factor, or loading the font file failed:\n{e}");
            }

            // Load japanese font.
            {
                // If we haven't loaded any fonts, load the default so we can merge with it.
                if (ImGui.GetIO().Fonts.Fonts.Size == 0)
                {
                    ImGui.GetIO().Fonts.AddFontDefault();
                }

                ImFontConfig config = new ImFontConfig();
                config.FontDataOwnedByAtlas = 1;
                config.OversampleH = 2;
                config.OversampleV = 2;
                config.PixelSnapH = 1;
                config.GlyphMaxAdvanceX = float.PositiveInfinity;
                config.RasterizerMultiply = 1;

                config.MergeMode = 1;
                unsafe
                {
                    ImFontConfigPtr configPtr = new ImFontConfigPtr(&config);
                    var io = ImGui.GetIO();
                    io.Fonts.AddFontFromFileTTF("Resources/NotoSans/NotoSansJP-Regular.ttf", float.Floor(fontSize) + 3, configPtr, io.Fonts.GetGlyphRangesJapanese());
                    // FIXME: When should we call this?
                    io.Fonts.Build();
                }
            }
            
            ImGuiController.RecreateFontDeviceTexture();

            // Set the imgui platform handle so we can use it in the IME data callback.
            {
                ImGuiViewportPtr viewport = ImGui.GetMainViewport();
                GCHandle gchandle = GCHandle.Alloc(Window);
                viewport.PlatformHandleRaw = (nint)gchandle;
            }
            // Make it so ImGui can set IME rect.
            ImGui.GetIO().SetPlatformImeDataFn = Marshal.GetFunctionPointerForDelegate(ImGui_SetPlatformImeDataInst);

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
                IsProcessingEvents = true;
                WindowComp.ProcessEvents();
                IsProcessingEvents = false;

                if (WindowComp.IsWindowDestroyed(Window))
                {
                    break;
                }

                Update(dt);

                OpenGLComp.SetCurrentContext(WindowContext);
                Render();

                foreach (var applicationWindow in ApplicationWindows)
                {
                    if (applicationWindow.Context == null)
                        continue;
                    if (applicationWindow.Application == null)
                        continue;

                    OpenGLComp.SetCurrentContext(applicationWindow.Context);

                    // FIXME: Send delta time?
                    applicationWindow.Application.Render();

                    OpenGLComp.SetCurrentContext(WindowContext);
                }
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


            MainTabContainer.Paint(dt);

            //ImGui.ShowMetricsWindow();
            //ImGui.ShowDemoWindow();
        }

        static void Render()
        {
            GL.ClearColor(Color4.Coral);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);

            ImGuiController.Render();

            OpenGLComp.SwapBuffers(WindowContext);
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
                    Console.WriteLine($"Closing window: '{WindowComp.GetTitle(close2.Window)}'");

                    // If this is one of our other windows we want to gracefully close it before we delete the window.
                    int index = ApplicationWindows.FindIndex(appWindow => appWindow.Window == close2.Window);
                    ApplicationWindow appWindow = ApplicationWindows[index];
                    if (appWindow != null)
                    {
                        if (appWindow.Context != null)
                        {
                            if (appWindow.Application != null)
                            {
                                // FIXME: Make there only be one place where we actually deinit applications.
                                OpenGLComp.SetCurrentContext(appWindow.Context);
                                appWindow.Application?.Deinitialize();
                                OpenGLComp.SetCurrentContext(WindowContext);
                            }

                            OpenGLComp.DestroyContext(appWindow.Context);
                        }
                        
                        ApplicationWindows.RemoveAt(index);
                    }
                    
                    WindowComp.Destroy(close2.Window);
                    return;
                }
                else
                {
                    // If this is a window event for an application window, send the event to that window.
                    int index = ApplicationWindows.FindIndex(appWindow => appWindow.Window == windowEvent.Window);
                    if (index != -1)
                    {
                        ApplicationWindows[index].Application?.HandleEvent(windowEvent);
                    }
                }
            }

            if (args is CloseEventArgs close)
            {
                Console.WriteLine("Closing main window!");
                WindowComp.Destroy(close.Window);
            }
            else if (args is FocusEventArgs focus)
            {
                string title = WindowComp.GetTitle(focus.Window);
                if (focus.GotFocus)
                {
                    Logger.LogInfo($"Window '{title}' ({focus.Window}) got focus.");
                }
                else
                {
                    Logger.LogInfo($"Window '{title}' ({focus.Window}) lost focus.");
                }
            }
            else if (args is KeyDownEventArgs keyDown)
            {
                ImGuiKey ikey = ToImgui(keyDown.Key);

                ImGui.GetIO().AddKeyEvent(ikey, true);

                // FIXME: Track modifiers!

                InputData.KeysPressed[(int)keyDown.Key] = true;

                Logger.LogDebug($"Key Down: {keyDown.Key}, Scancode: {keyDown.Scancode}, Modifiers: {keyDown.Modifiers}, Repeat: {keyDown.IsRepeat}");
            }
            else if (args is KeyUpEventArgs keyUp)
            {
                ImGuiKey ikey = ToImgui(keyUp.Key);

                ImGui.GetIO().AddKeyEvent(ikey, false);

                InputData.KeysPressed[(int)keyUp.Key] = false;

                Logger.LogDebug($"Key Up: {keyUp.Key}, Scancode: {keyUp.Scancode}, Modifiers: {keyUp.Modifiers}");
            }
            else if (args is TextInputEventArgs textInput)
            {
                ImGui.GetIO().AddInputCharactersUTF8(textInput.Text);
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
                    Vector2i newSize = resize.NewSize;
                    var newSize2 = newSize;
                    // FIXME: Framebuffer size on macos?
                    (WindowComp as MacOSWindowComponent)?.GetFramebufferSize(resize.Window, out newSize.X, out newSize.Y);

                    GL.Viewport(0, 0, newSize.X, newSize.Y);
                    ImGuiController?.WindowResized(newSize.X, newSize.Y);

                    // We can get here as a respose to interations made while
                    // we are in the middle of updating and rendering ImGui.
                    // So we need to check so that we are in ordinary event processing.
                    if (ImGuiController != null && IsProcessingEvents)
                    {
                        Update(0f);
                        OpenGLComp.SetCurrentContext(WindowContext);
                        Render();
                    }
                }
            }
            else if (args is WindowMoveEventArgs move)
            {
                if (move.Window == Window)
                {
                    //Logger.LogDebug($"Window moved: Window pos: {move.WindowPosition}, client pos {move.ClientAreaPosition}");
                }
            }
            else if (args is WindowModeChangeEventArgs modeChange)
            {
                Logger.LogInfo($"New window mode: {modeChange.NewMode}");
            } 
            else if (args is ClipboardUpdateEventArgs clipboardUpdate)
            {
                Logger.LogInfo($"Clipboard contents changed. New format: {clipboardUpdate.NewFormat}.");
            }
            else if (args is FileDropEventArgs fileDrop)
            {
                Logger.LogInfo($"Dropped files:\n\t{string.Join("\n\t", fileDrop.FilePaths)}");
            }
            else if (args is WindowDpiChangeEventArgs dpiChange)
            {
                try
                {
                    if (DisplayComponent != null)
                    {
                        // FIXME: Should we only scale on Y? or something else?
                        float scale = MathF.Max(dpiChange.ScaleX, dpiChange.ScaleY);
                        if (scale != 1)
                        {
                            ImFontConfig config = new ImFontConfig();
                            config.FontDataOwnedByAtlas = 1;
                            config.OversampleH = 3;
                            config.OversampleV = 3;
                            config.PixelSnapH = 1;
                            config.GlyphMaxAdvanceX = float.PositiveInfinity;
                            config.RasterizerMultiply = 1;
                            config.EllipsisChar = 0xFFFF;
                            unsafe
                            {
                                ImFontConfigPtr configPtr = new ImFontConfigPtr(&config);
                                ImGui.GetIO().Fonts.AddFontFromFileTTF("Resources\\ProggyVector\\ProggyVectorDotted.ttf", float.Floor(13 * scale), configPtr);

                                // FIXME: This is not perfect and does introduce some visual artifacts
                                // if the window dpi changes multiple times.
                                // We could make a copy of the unscaled style and scale that. (https://github.com/ocornut/imgui/issues/5452)
                                // Thought that would mean we have to update both styles if we want to change some styling.
                                ImGui.GetStyle().ScaleAllSizes(1 / CurrentImGuiScale);
                                ImGui.GetStyle().ScaleAllSizes(scale);
                                CurrentImGuiScale = scale;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Logger.LogWarning($"Could not get scale factor, or loading the font file failed:\n{e}");
                }

                ImGuiController.RecreateFontDeviceTexture();
            }
            else if (args is DisplayConnectionChangedEventArgs displayChanged)
            {
                ((DisplayComponentView?)MainTabContainer[typeof(DisplayComponentView)])?.HandleConnectionChange(displayChanged);
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

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void ImGui_SetPlaformImeDataFn(ImGuiViewportPtr viewport, ImGuiPlatformImeDataPtr data);
        private static ImGui_SetPlaformImeDataFn ImGui_SetPlatformImeDataInst = ImGui_SetPlatformImeData;
        private static void ImGui_SetPlatformImeData(ImGuiViewportPtr viewport, ImGuiPlatformImeDataPtr data)
        {
            if (data.WantVisible)
            {
                if (KeyboardComponent != null)
                {
                    try
                    {
                        GCHandle handle = GCHandle.FromIntPtr(viewport.PlatformHandleRaw);
                        WindowHandle window = (WindowHandle)handle.Target!;

                        int x = (int)data.InputPos.X;
                        int y = (int)data.InputPos.Y;
                        int w = 1; // FIXME: What do we actually want to pass here?
                        int h = (int)data.InputLineHeight;

                        KeyboardComponent.SetImeRectangle(window, x, y, w, h);
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}
