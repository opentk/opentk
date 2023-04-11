using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Platform.Native.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.SDL.SDL;

namespace OpenTK.Platform.Native.SDL
{
    public class SDLWindowComponent : IWindowComponent
    {
        internal static readonly Dictionary<uint, SDLWindow> WindowDict = new Dictionary<uint, SDLWindow>();

        public string Name => nameof(SDLWindowComponent);

        public PalComponents Provides => PalComponents.Window;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Window)
            {
                throw new PalException(this, "SDLWindowComponent can only initialize the Window component.");
            }

            // Load SDLLib
            int result = SDL_Init(SDL_INIT.SDL_INIT_VIDEO | SDL_INIT.SDL_INIT_EVENTS);

            if (result < 0)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL Error: {error}");
            }
        }

        public bool CanSetIcon => throw new NotImplementedException();

        public bool CanGetDisplay => throw new NotImplementedException();

        public bool CanSetCursor => throw new NotImplementedException();

        public bool CanCaptureCursor => throw new NotImplementedException();

        public IReadOnlyList<PlatformEventType> SupportedEvents => throw new NotImplementedException();

        public IReadOnlyList<WindowStyle> SupportedStyles => throw new NotImplementedException();

        public IReadOnlyList<WindowMode> SupportedModes => throw new NotImplementedException();

        public unsafe void ProcessEvents(bool waitForEvents = false)
        {
            SDLEvent @event;
            int result = SDL_PollEvent(&@event);

            if (result == 1)
            {
                Console.WriteLine($"SDL event type: {@event.Type}");

                if (@event.Type == SDL_EventType.SDL_WINDOWEVENT)
                {
                    SDL_WindowEvent windowEvent = @event.Window;

                    Console.WriteLine($"  Window event ID: {windowEvent.@event}");

                    if (windowEvent.@event == SDL_WindowEventID.SDL_WINDOWEVENT_CLOSE)
                    {
                        SDLWindow sdlWindow = WindowDict[windowEvent.windowID];

                        EventQueue.Raise(sdlWindow, PlatformEventType.Close, new CloseEventArgs(sdlWindow));
                    }
                }
                else if (@event.Type == SDL_EventType.SDL_MOUSEBUTTONDOWN)
                {
                    SDL_MouseButtonEvent buttonEvent = @event.MouseButton;

                    SDLWindow sdlWindow = WindowDict[buttonEvent.windowID];

                    MouseButton button = buttonEvent.button switch
                    {
                        SDL_BUTTON.SDL_BUTTON_LEFT => MouseButton.Button1,
                        SDL_BUTTON.SDL_BUTTON_MIDDLE => MouseButton.Button3,
                        SDL_BUTTON.SDL_BUTTON_RIGHT => MouseButton.Button2,
                        SDL_BUTTON.SDL_BUTTON_X1 => MouseButton.Button4,
                        SDL_BUTTON.SDL_BUTTON_X2 => MouseButton.Button5,

                        // FIXME: Maybe don't throw an error here...
                        _ => throw new PalException(this, $"Got unknown mouse button: {buttonEvent.which}"),
                    };

                    EventQueue.Raise(sdlWindow, PlatformEventType.MouseDown, new MouseButtonDownEventArgs(sdlWindow, button));
                }
            }
        }

        public WindowHandle Create(GraphicsApiHints hints)
        {
            OpenGLGraphicsApiHints openglHints = (OpenGLGraphicsApiHints)hints;

            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_CONTEXT_MAJOR_VERSION, openglHints.Version.Major);
            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_CONTEXT_MINOR_VERSION, openglHints.Version.Minor);

            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_DOUBLEBUFFER, openglHints.DoubleBuffer ? 1 : 0);

            SDL_GLprofile profile = 0;
            switch (openglHints.Profile)
            {
                case OpenGLProfile.None:
                    profile = 0;
                    break;
                case OpenGLProfile.Core:
                    profile = SDL_GLprofile.SDL_GL_CONTEXT_PROFILE_CORE;
                    break;
                case OpenGLProfile.Compatibility:
                    profile = SDL_GLprofile.SDL_GL_CONTEXT_PROFILE_COMPATIBILITY;
                    break;
                default:
                    break;
            }
            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_CONTEXT_FLAGS, (int)profile);

            SDL_GLcontextFlag flags = 0;
            if (openglHints.DebugFlag) flags |= SDL_GLcontextFlag.SDL_GL_CONTEXT_DEBUG_FLAG;
            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_CONTEXT_FLAGS, (int)flags);

            SDL_WindowPtr window = SDL_CreateWindow("", SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED, 600, 400, SDL_WindowFlags.SDL_WINDOW_OPENGL | SDL_WindowFlags.SDL_WINDOW_RESIZABLE);

            uint id = SDL_GetWindowID(window);

            SDLWindow sdlWindow = new SDLWindow(window, id);

            WindowDict.Add(id, sdlWindow);

            return sdlWindow;
        }

        public void Destroy(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            WindowDict.Remove(window.WindowID);

            SDL_DestroyWindow(window.Window);

            window.Destroyed = true;
        }

        public bool IsWindowDestroyed(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            return window.Destroyed;
        }

        public string GetTitle(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            return SDL_GetWindowTitle(window.Window);
        }

        public void SetTitle(WindowHandle handle, string title)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_SetWindowTitle(window.Window, title);
        }

        public IconHandle GetIcon(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public void SetIcon(WindowHandle handle, IconHandle icon)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public void GetPosition(WindowHandle handle, out int x, out int y)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_GetWindowPosition(window.Window, out x, out y);
        }

        public void SetPosition(WindowHandle handle, int x, int y)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_SetWindowPosition(window.Window, x, y);
        }

        public void GetSize(WindowHandle handle, out int width, out int height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_GetWindowSize(window.Window, out width, out height);
        }

        public void SetSize(WindowHandle handle, int width, int height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_SetWindowSize(window.Window, width, height);
        }

        public void GetClientPosition(WindowHandle handle, out int x, out int y)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public void SetClientPosition(WindowHandle handle, int x, int y)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public void GetClientSize(WindowHandle handle, out int width, out int height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public void SetClientSize(WindowHandle handle, int width, int height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public void GetMaxClientSize(WindowHandle handle, out int? width, out int? height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            int w, h;

            // FIXME: Is this client area or windowEvent??

            SDL_GetWindowMaximumSize(window.Window, out w, out h);

            width = w != 0 ? w : null;
            height = h != 0 ? h : null;
        }

        public void SetMaxClientSize(WindowHandle handle, int? width, int? height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            // FIXME: Is this client area or windowEvent??

            SDL_SetWindowMaximumSize(window.Window, width ?? 0, height ?? 0);
        }

        public void GetMinClientSize(WindowHandle handle, out int? width, out int? height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            int w, h;

            SDL_GetWindowMinimumSize(window.Window, out w, out h);

            width = w != 0 ? w : null;
            height = h != 0 ? h : null;
        }

        public void SetMinClientSize(WindowHandle handle, int? width, int? height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_SetWindowMinimumSize(window.Window, width ?? 0, height ?? 0);
        }

        public DisplayHandle GetDisplay(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public WindowMode GetMode(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            // FIXME:

            throw new NotImplementedException();
        }

        public void SetMode(WindowHandle handle, WindowMode mode)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            switch (mode)
            {
                case WindowMode.Hidden:
                    SDL_HideWindow(window.Window);
                    break;
                case WindowMode.Minimized:
                    SDL_MinimizeWindow(window.Window);
                    break;
                case WindowMode.Normal:
                    SDL_ShowWindow(window.Window);
                    SDL_RestoreWindow(window.Window);
                    break;
                case WindowMode.Maximized:
                    SDL_MaximizeWindow(window.Window);
                    break;
                case WindowMode.WindowedFullscreen:
                    throw new NotImplementedException();
                case WindowMode.ExclusiveFullscreen:
                    throw new NotImplementedException();
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, typeof(WindowMode));
            }
        }

        public WindowStyle GetBorderStyle(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public void SetBorderStyle(WindowHandle handle, WindowStyle style)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public void SetAlwaysOnTop(WindowHandle handle, bool floating)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_SetWindowAlwaysOnTop(window.Window, floating ? 1 : 0);
        }

        public bool IsAlwaysOnTop(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_WindowFlags flags = SDL_GetWindowFlags(window.Window);

            return flags.HasFlag(SDL_WindowFlags.SDL_WINDOW_ALWAYS_ON_TOP);
        }

        public void SetHitTestCallback(WindowHandle handle, HitTest? test)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public void SetCursor(WindowHandle handle, CursorHandle? cursor)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public CursorCaptureMode GetCursorCaptureMode(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public void SetCursorCaptureMode(WindowHandle handle, CursorCaptureMode mode)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            throw new NotImplementedException();
        }

        public void FocusWindow(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_RaiseWindow(window.Window);
        }

        public void RequestAttention(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_FlashWindow(window.Window, SDL_FlashOperation.SDL_FLASH_UNTIL_FOCUSED);
        }

        public void ScreenToClient(WindowHandle handle, int x, int y, out int clientX, out int clientY)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            // FIXME: How to do this??

            throw new NotImplementedException();
        }

        public void ClientToScreen(WindowHandle handle, int clientX, int clientY, out int x, out int y)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            // FIXME: How to do this??

            throw new NotImplementedException();
        }

        public void SwapBuffers(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_GL_SwapWindow(window.Window);
        }
    }
}
