using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Numerics;

namespace OpenTK.Backends.Tests
{
    internal class Program
    {
        public static ILogger Logger = new ModularLogger() { new ConsoleLogger() };

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

        public static WindowHandle Window;
        static OpenGLContextHandle OpenGLContext;

        static ImGuiController ImGuiController;
        static InputData InputData = new InputData();

        static ImGuiMouseCursor prevCursor;

        static readonly MainTabContainer MainTabContainer = new MainTabContainer()
        {
            new OverviewView(),
            new WindowComponentView(),
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
                        case PalComponents.Window:      WindowComp = (IWindowComponent)driver; break;
                        case PalComponents.OpenGL:      OpenGLComp = (IOpenGLComponent)driver; break;
                        case PalComponents.WindowIcon:  IconComponent = (IIconComponent)driver; break;
                        case PalComponents.MouseCursor: CursorComp = (ICursorComponent)driver; break;
                        case PalComponents.Display:     DisplayComponent = (IDisplayComponent)driver; break;
                        case PalComponents.MiceInput:   MouseComponent = (IMouseComponent)driver; break;
                        case PalComponents.KeyboardInput: KeyboardComponent = (IKeyboardComponent)driver; break;
                        case PalComponents.Clipboard:   ClipboardComponent = (IClipboardComponent)driver; break;
                        case PalComponents.Shell:       ShellComponent = (IShellComponent)driver; break;
                        case PalComponents.Joystick:    JoystickComponent = (IJoystickComponent)driver; break;
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

            GLLoader.LoadBindings(OpenGLComp.GetBindingsContext(OpenGLContext));

            WindowComp.SetTitle(Window, "OpenTK PAL Test Application");
            WindowComp.SetClientSize(Window, 800, 600);
            WindowComp.SetMode(Window, WindowMode.Normal);

            GL.Viewport(0, 0, 800, 600);

            WindowComp.GetClientSize(Window, out int width, out int height);
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
                            WindowComp.SetCursor(Window, cursor);
                        }
                        prevCursor = imguiCursor;
                    }
                }

                ImGuiController.Update(InputData, dt);

                MainTabContainer.Paint();

                Render();
            }
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
                //ImGuiController.MouseScroll(scroll.Delta);
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
    }
}
