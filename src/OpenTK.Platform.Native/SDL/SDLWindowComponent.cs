using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using static OpenTK.Platform.Native.SDL.SDL;

namespace OpenTK.Platform.Native.SDL
{
    public class SDLWindowComponent : IWindowComponent
    {
        internal static readonly Dictionary<uint, SDLWindow> WindowDict = new Dictionary<uint, SDLWindow>();

        /// <inheritdoc/>
        public string Name => nameof(SDLWindowComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Window;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Window)
            {
                throw new PalException(this, "SDLWindowComponent can only initialize the Window component.");
            }

            // Load SDLLib
            int result = SDL_Init(SDL_INIT.SDL_INIT_VIDEO | SDL_INIT.SDL_INIT_EVENTS | SDL_INIT.SDL_INIT_JOYSTICK | SDL_INIT.SDL_INIT_GAMECONTROLLER);

            if (result < 0)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL Error: {error}");
            }
        }

        /// <inheritdoc/>
        public bool CanSetIcon => true;

        /// <inheritdoc/>
        public bool CanGetDisplay => true;

        /// <inheritdoc/>
        public bool CanSetCursor => true;

        /// <inheritdoc/>
        public bool CanCaptureCursor => true;

        /// <inheritdoc/>
        public IReadOnlyList<PlatformEventType> SupportedEvents => throw new NotImplementedException();

        /// <inheritdoc/>
        public IReadOnlyList<WindowBorderStyle> SupportedStyles => throw new NotImplementedException();

        /// <inheritdoc/>
        public IReadOnlyList<WindowMode> SupportedModes => throw new NotImplementedException();

        // Used to store a list of files being dropped into the window.
        // SDL gives us the list as a sequence of events so we need to use this list
        // to aggregate the items
        // - Noggin_bops 2023-04-16
        private readonly List<string> drops = new List<string>();

        /// <inheritdoc/>
        public unsafe void ProcessEvents(bool waitForEvents = false)
        {
            SDLEvent @event;
            while (SDL_PollEvent(&@event) != 0)
            {
                switch (@event.Type)
                {
                    case SDL_EventType.SDL_QUIT:
                        // FIXME: Do we need to do anything here?
                        break;
                    case SDL_EventType.SDL_DISPLAYEVENT:
                        {
                            SDL_DisplayEvent displayEvent = @event.DisplayEvent;

                            switch (displayEvent.@event)
                            {
                                case SDL_DisplayEventID.SDL_DISPLAYEVENT_ORIENTATION:
                                    // FIXME: Add this event!
                                    break;
                                case SDL_DisplayEventID.SDL_DISPLAYEVENT_CONNECTED:
                                    {
                                        // FIXME: Don't create a new object here!! Get the object from the SDLDisplayComponent instead!
                                        SDLDisplay display = new SDLDisplay((int)displayEvent.display);
                                        EventQueue.Raise(display, PlatformEventType.DisplayConnectionChanged, new DisplayConnectionChangedEventArgs(display, false));
                                        break;
                                    }
                                case SDL_DisplayEventID.SDL_DISPLAYEVENT_DISCONNECTED:
                                    {
                                        // FIXME: Don't create a new object here!! Get the object from the SDLDisplayComponent instead!
                                        SDLDisplay display = new SDLDisplay((int)displayEvent.display);
                                        EventQueue.Raise(display, PlatformEventType.DisplayConnectionChanged, new DisplayConnectionChangedEventArgs(display, true));
                                        break;
                                    }
                                case SDL_DisplayEventID.SDL_DISPLAYEVENT_MOVED:
                                    // FIXME: Add this event to PAL2!
                                    break;
                                default:
                                    throw new InvalidEnumArgumentException(nameof(SDL_DisplayEvent.@event), (int)displayEvent.@event, typeof(SDL_DisplayEventID));
                            }
                            break;
                        }
                    case SDL_EventType.SDL_WINDOWEVENT:
                        {
                            SDL_WindowEvent windowEvent = @event.Window;
                            if (WindowDict.TryGetValue(windowEvent.windowID, out SDLWindow? sdlWindow) == false)
                            {
                                // If this event is to a window we don't have in our dictionary we ignore it.
                                Logger?.LogDebug($"{@event.Type} {windowEvent.@event} Unknown window {windowEvent.windowID}");
                                break;
                            }

                            switch (windowEvent.@event)
                            {
                                case SDL_WindowEventID.SDL_WINDOWEVENT_SHOWN:
                                    {
                                        Debug.Assert(GetMode(sdlWindow) == WindowMode.Normal);
                                        EventQueue.Raise(sdlWindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(sdlWindow, WindowMode.Normal));
                                    }
                                    break;
                                case SDL_WindowEventID.SDL_WINDOWEVENT_HIDDEN:
                                    {
                                        EventQueue.Raise(sdlWindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(sdlWindow, WindowMode.Hidden));

                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_EXPOSED:
                                    break;
                                case SDL_WindowEventID.SDL_WINDOWEVENT_MOVED:
                                    {
                                        Vector2i newPosition = new Vector2i(windowEvent.data1, windowEvent.data2);

                                        // FIXME: Client area position!
                                        EventQueue.Raise(sdlWindow, PlatformEventType.WindowMove, new WindowMoveEventArgs(sdlWindow, newPosition, default));

                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_RESIZED:
                                    {
                                        Vector2i newSize = new Vector2i(windowEvent.data1, windowEvent.data2);

                                        // FIXME: Client area position!
                                        EventQueue.Raise(sdlWindow, PlatformEventType.WindowResize, new WindowResizeEventArgs(sdlWindow, newSize));

                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_MINIMIZED:
                                    {
                                        EventQueue.Raise(sdlWindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(sdlWindow, WindowMode.Minimized));
                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_MAXIMIZED:
                                    {
                                        EventQueue.Raise(sdlWindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(sdlWindow, WindowMode.Maximized));
                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_RESTORED:
                                    {
                                        EventQueue.Raise(sdlWindow, PlatformEventType.WindowModeChange, new WindowModeChangeEventArgs(sdlWindow, WindowMode.Normal));
                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_ENTER:
                                    {
                                        EventQueue.Raise(sdlWindow, PlatformEventType.MouseEnter, new MouseEnterEventArgs(sdlWindow, true));
                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_LEAVE:
                                    {
                                        EventQueue.Raise(sdlWindow, PlatformEventType.MouseEnter, new MouseEnterEventArgs(sdlWindow, false));
                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_FOCUS_GAINED:
                                    {
                                        EventQueue.Raise(sdlWindow, PlatformEventType.Focus, new FocusEventArgs(sdlWindow, true));
                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_FOCUS_LOST:
                                    {
                                        EventQueue.Raise(sdlWindow, PlatformEventType.Focus, new FocusEventArgs(sdlWindow, false));
                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_CLOSE:
                                    {
                                        EventQueue.Raise(sdlWindow, PlatformEventType.Close, new CloseEventArgs(sdlWindow));

                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_TAKE_FOCUS:
                                    {
                                        // FIXME: Might be an interesting event to expose
                                        // See https://github.com/libsdl-org/SDL/commit/dc532c70e8086030b67794c62bc41922c3d5386c
                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_HIT_TEST:
                                    {
                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_ICCPROF_CHANGED:
                                    {
                                        // TODO: This would be great event to add to the PAL2 api.
                                        break;
                                    }
                                case SDL_WindowEventID.SDL_WINDOWEVENT_DISPLAY_CHANGED:
                                    {
                                        // FIXME: Expose an event like this.
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case SDL_EventType.SDL_MOUSEMOTION:
                        {
                            SDL_MouseMotionEvent mouseMotion = @event.MouseMotion;
                            SDLWindow sdlWindow = WindowDict[mouseMotion.windowID];

                            EventQueue.Raise(sdlWindow, PlatformEventType.MouseMove, new MouseMoveEventArgs(sdlWindow, new Vector2(mouseMotion.x, mouseMotion.y)));

                            break;
                        }
                    case SDL_EventType.SDL_MOUSEBUTTONDOWN:
                    case SDL_EventType.SDL_MOUSEBUTTONUP:
                        {
                            SDL_MouseButtonEvent buttonEvent = @event.MouseButton;

                            // FIXME! What window do we send this to?
                            // or do we send the event without a window?
                            if (buttonEvent.windowID == 0)
                            {
                                Logger?.LogWarning($"Received {@event.Type} with windowID = 0! This event will not be sent to any window.");
                                break;
                            }

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

                            KeyModifier modifiers = SDLKeyboardComponent.FromSDL(SDL_GetModState());

                            if (buttonEvent.type == SDL_EventType.SDL_MOUSEBUTTONDOWN)
                            {
                                EventQueue.Raise(sdlWindow, PlatformEventType.MouseDown, new MouseButtonDownEventArgs(sdlWindow, button, modifiers));
                            }
                            else
                            {
                                EventQueue.Raise(sdlWindow, PlatformEventType.MouseUp, new MouseButtonUpEventArgs(sdlWindow, button, modifiers));
                            }

                            break;
                        }
                    case SDL_EventType.SDL_MOUSEWHEEL:
                        {
                            SDL_MouseWheelEvent mouseWheel = @event.MouseWheel;
                            SDLWindow sdlWindow = WindowDict[mouseWheel.windowID];

                            // FIXME: Account for SDL_MouseWheelEvent.direction
                            // we could also not abstract this and provide both scroll and mose wheel values in the event.

                            // FIXME: What are the different directions??
                            Vector2 scroll = new Vector2(mouseWheel.x, mouseWheel.y);
                            // FIXME: I don't think this is distance! We want to precisely determine what should be put in the distance field.
                            Vector2 distance = new Vector2(mouseWheel.preciseX, mouseWheel.preciseY);

                            // FIXME: should we use the precise values instead?
                            SDLMouseComponent.RegisterMouseWheelDelta(scroll);
                            EventQueue.Raise(sdlWindow, PlatformEventType.Scroll, new ScrollEventArgs(sdlWindow, scroll, distance));

                            break;
                        }
                    case SDL_EventType.SDL_CLIPBOARDUPDATE:
                        {
                            //SDLWindow sdlWindow = WindowDict[@event.windowID];
                            ClipboardFormat newFormat;
                            if (SDL_HasClipboardText() == 1) newFormat = ClipboardFormat.Text;
                            else newFormat = ClipboardFormat.None;

                            EventQueue.Raise(null, PlatformEventType.ClipboardUpdate, new ClipboardUpdateEventArgs(newFormat));

                            break;
                        }
                    case SDL_EventType.SDL_DROPBEGIN:
                    case SDL_EventType.SDL_DROPCOMPLETE:
                    case SDL_EventType.SDL_DROPFILE:
                        {
                            SDL_DropEvent dropEvent = @event.DropEvent;

                            if (@event.Type == SDL_EventType.SDL_DROPBEGIN)
                            {
                                drops.Clear();
                            }
                            else if (@event.Type == SDL_EventType.SDL_DROPFILE)
                            {
                                drops.Add(Marshal.PtrToStringUTF8((IntPtr)dropEvent.file)!);
                                SDL_free(dropEvent.file);
                            }
                            else if (@event.Type == SDL_EventType.SDL_DROPCOMPLETE)
                            {
                                SDLWindow sdlWindow = WindowDict[dropEvent.windowID];

                                // FIXME: Should we use SDL_GetMouseState here instead and calculate the global position?
                                // The documentation says SDL_GetGlobalMouseState might be slower than SDL_GetMouseState.
                                SDL_GetGlobalMouseState(out int mouseX, out int mouseY);

                                EventQueue.Raise(sdlWindow, PlatformEventType.FileDrop, new FileDropEventArgs(sdlWindow, drops.ToList(), new Vector2i(mouseX, mouseY)));
                            }
                            break;
                        }
                    case SDL_EventType.SDL_TEXTINPUT:
                        {
                            SDL_TextInputEvent textInputEvent = @event.TextInputEvent;
                            SDLWindow sdlWindow = WindowDict[textInputEvent.windowID];

                            // The entire buffer is not used so we find the end of the data
                            // and only convert that to a string.
                            ReadOnlySpan<byte> span = new ReadOnlySpan<byte>(textInputEvent.text, SDL_TextInputEvent.SDL_TEXTINPUTEVENT_TEXT_SIZE);
                            int last = span.IndexOf((byte)0);
                            span = span.Slice(0, last);
                            
                            string input = Encoding.UTF8.GetString(span);

                            EventQueue.Raise(sdlWindow, PlatformEventType.TextInput, new TextInputEventArgs(sdlWindow, input));

                            break;
                        }
                    case SDL_EventType.SDL_TEXTEDITING:
                        {
                            SDL_TextEditingEvent textEditingEvent = @event.TextEditingEvent;
                            if (WindowDict.TryGetValue(textEditingEvent.windowID, out SDLWindow? sdlWindow) == false)
                            {
                                // If this event is to a window we don't have in our dictionary we ignore it.
                                Logger?.LogDebug($"{@event.Type} Unknown window {textEditingEvent.windowID}");
                                break;
                            }

                            // The entire buffer is not used so we find the end of the data
                            // and only convert that to a string.
                            ReadOnlySpan<byte> span = new ReadOnlySpan<byte>(textEditingEvent.text, SDL_TextEditingEvent.SDL_TEXTEDITINGEVENT_TEXT_SIZE);
                            int last = span.IndexOf((byte)0);
                            span = span.Slice(0, last);

                            string candidate = Encoding.UTF8.GetString(span);

                            EventQueue.Raise(sdlWindow, PlatformEventType.TextEditing, new TextEditingEventArgs(sdlWindow, candidate, textEditingEvent.start, textEditingEvent.length));

                            break;
                        }
                    case SDL_EventType.SDL_KEYMAPCHANGED:
                        {
                            // FIXME: How should we deal with not having the proper information here?
                            EventQueue.Raise(null, PlatformEventType.InputLanguageChanged, new InputLanguageChangedEventArgs(null, null, null, null));

                            break;
                        }
                    case SDL_EventType.SDL_KEYDOWN:
                    case SDL_EventType.SDL_KEYUP:
                        {
                            SDL_KeyboardEvent keyboardEvent = @event.KeyboardEvent;

                            if (keyboardEvent.windowID == 0)
                            {
                                Logger?.LogWarning($"{keyboardEvent.type} with no window. Can't raise this event! Key: {keyboardEvent.keysym.sym}, Scancode: {keyboardEvent.keysym.scancode}.");
                                break;
                            }

                            SDLWindow sdlWindow = WindowDict[keyboardEvent.windowID];

                            Key key = SDLKeyboardComponent.FromSDL(keyboardEvent.keysym.sym, Logger);
                            Scancode scancode = SDLKeyboardComponent.FromSDL(keyboardEvent.keysym.scancode, Logger);

                            KeyModifier modifiers = SDLKeyboardComponent.FromSDL(SDL_GetModState());

                            bool repeat = keyboardEvent.repeat > 0;

                            if (keyboardEvent.type == SDL_EventType.SDL_KEYDOWN)
                            {
                                EventQueue.Raise(sdlWindow, PlatformEventType.KeyDown, new KeyDownEventArgs(sdlWindow, key, scancode, repeat, modifiers));
                            }
                            else if (keyboardEvent.type == SDL_EventType.SDL_KEYUP)
                            {
                                EventQueue.Raise(sdlWindow, PlatformEventType.KeyUp, new KeyUpEventArgs(sdlWindow, key, scancode, modifiers));
                            }

                            break;
                        }
                    case SDL_EventType.SDL_CONTROLLERDEVICEADDED:
                    case SDL_EventType.SDL_CONTROLLERDEVICEREMOVED:
                        {
                            SDL_ControllerDeviceEvent controllerDeviceEvent = @event.ControllerDeviceEvent;

                            // FIXME: Add joystick added/removed events!

                            break;
                        }
                    default:
                        Console.WriteLine($"SDL event type: {@event.Type}");
                        break;
                }
            }
        }

        /// <inheritdoc/>
        public WindowHandle Create(GraphicsApiHints hints)
        {
            OpenGLGraphicsApiHints settings = (OpenGLGraphicsApiHints)hints;

            // SDL requires these attributes to be set before creating the window.
            // SDL doesn't tell us when these attributes will be read so we don't know
            // which attributes are read during SDL_CreateWindow or SDL_GL_CreateContext.
            // This could cause issues on different platforms where:
            //
            // window1 = SDL_CreateWindow(setting1)
            // window2 = SDL_CreateWindow(setting2)
            // context1 = SDL_GL_CreateContext(window1)
            // context2 = SDL_GL_CreateContext(window2)
            //
            // will cause context1 and 2 to have different settings on different platforms.
            // On windows this will work as expected as the (most) settings are read when creating the context,
            // but on X11 and Cocoa context1 and 2 will have the settings from setting2.
            // Context sharing for example is only "read" during SDL_GL_CreateContext for windows, macos, and linux.
            // The solution is to set all of the attributes when creating the window,
            // but then also re-set the attributes before creating the OpenGL context.
            // - 2023-06-29 Noggin_bops

            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_CONTEXT_MAJOR_VERSION, settings.Version.Major);
            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_CONTEXT_MINOR_VERSION, settings.Version.Minor);

            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_DOUBLEBUFFER, settings.DoubleBuffer ? 1 : 0);

            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_RED_SIZE, settings.RedColorBits);
            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_GREEN_SIZE, settings.GreenColorBits);
            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_BLUE_SIZE, settings.BlueColorBits);
            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_ALPHA_SIZE, settings.AlphaColorBits);

            byte depthBits;
            switch (settings.DepthBits)
            {
                case ContextDepthBits.Depth24: depthBits = 24; break;
                case ContextDepthBits.Depth32: depthBits = 32; break;
                default: throw new InvalidEnumArgumentException(nameof(settings.DepthBits), (int)settings.DepthBits, settings.DepthBits.GetType());
            }

            byte stencilBits;
            switch (settings.StencilBits)
            {
                case ContextStencilBits.Stencil1: stencilBits = 1; break;
                case ContextStencilBits.Stencil8: stencilBits = 8; break;
                default: throw new InvalidEnumArgumentException(nameof(settings.StencilBits), (int)settings.StencilBits, settings.StencilBits.GetType());
            }

            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_DEPTH_SIZE, depthBits);
            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_STENCIL_SIZE, stencilBits);

            if (settings.Multisamples > 0)
            {
                SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_MULTISAMPLEBUFFERS, 1);
                SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_MULTISAMPLESAMPLES, settings.Multisamples);
            }

            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_FRAMEBUFFER_SRGB_CAPABLE, settings.sRGBFramebuffer ? 1 : 0);

            SDL_GLContext prevContext = SDL_GL_GetCurrentContext();
            SDL_WindowPtr prevWindow = SDL_GL_GetCurrentWindow();
            if (settings.SharedContext != null)
            {
                SDLOpenGLContext sharedContext = settings.SharedContext.As<SDLOpenGLContext>(this);

                SDL_GL_MakeCurrent(sharedContext.Window.Window, sharedContext.Context);
                SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_SHARE_WITH_CURRENT_CONTEXT, 1);
            }

            SDL_GLprofile profile;
            switch (settings.Profile)
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
                    throw new InvalidEnumArgumentException(nameof(settings.Profile), (int)settings.Profile, typeof(OpenGLProfile));
            }
            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_CONTEXT_FLAGS, (int)profile);

            SDL_GLcontextFlag flags = 0;
            if (settings.DebugFlag) flags |= SDL_GLcontextFlag.SDL_GL_CONTEXT_DEBUG_FLAG;
            if (settings.ForwardCompatibleFlag) flags |= SDL_GLcontextFlag.SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG;
            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_CONTEXT_FLAGS, (int)flags);

            SDL_WindowPtr window = SDL_CreateWindow("", SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED, 0, 0, SDL_WindowFlags.SDL_WINDOW_OPENGL | SDL_WindowFlags.SDL_WINDOW_RESIZABLE | SDL_WindowFlags.SDL_WINDOW_HIDDEN);

            SDL_GL_SetAttribute(SDL_GLattr.SDL_GL_SHARE_WITH_CURRENT_CONTEXT, 0);
            if (prevContext != SDL_GLContext.Null)
            {
                SDL_GL_MakeCurrent(prevWindow, prevContext);
            }

            uint id = SDL_GetWindowID(window);

            SDLWindow sdlWindow = new SDLWindow(window, id, settings);

            WindowDict.Add(id, sdlWindow);

            return sdlWindow;
        }

        /// <inheritdoc/>
        public void Destroy(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            WindowDict.Remove(window.WindowID);

            SDL_DestroyWindow(window.Window);

            window.Destroyed = true;
        }

        /// <inheritdoc/>
        public bool IsWindowDestroyed(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            return window.Destroyed;
        }

        /// <inheritdoc/>
        public unsafe string GetTitle(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            byte* title = SDL_GetWindowTitle(window.Window);
            return Marshal.PtrToStringUTF8((IntPtr)title)!;
        }

        /// <inheritdoc/>
        public void SetTitle(WindowHandle handle, string title)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_SetWindowTitle(window.Window, title);
        }

        /// <inheritdoc/>
        public IconHandle? GetIcon(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            return window.Icon;
        }

        /// <inheritdoc/>
        public unsafe void SetIcon(WindowHandle handle, IconHandle icon)
        {
            SDLWindow window = handle.As<SDLWindow>(this);
            SDLIcon sdlIcon = icon.As<SDLIcon>(this);

            window.Icon = sdlIcon;
            SDL_SetWindowIcon(window.Window, sdlIcon.Surface);
        }

        /// <inheritdoc/>
        public void GetPosition(WindowHandle handle, out int x, out int y)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            // Get the client position and compensate using the border size.
            SDL_GetWindowPosition(window.Window, out int clientX, out int clientY);
            SDL_GetWindowBordersSize(window.Window, out int top, out int left, out _, out _);

            x = clientX - left;
            y = clientY - top;
        }

        /// <inheritdoc/>
        public void SetPosition(WindowHandle handle, int x, int y)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_GetWindowBordersSize(window.Window, out int top, out int left, out _, out _);

            // SDL_SetWindowPosition sets the client position of the window,
            // so we query the insets of the window to compensate.
            SDL_SetWindowPosition(window.Window, x + left, y + top);
        }

        /// <inheritdoc/>
        public void GetSize(WindowHandle handle, out int width, out int height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            // Get the client size and compensate using the border size.
            SDL_GetWindowSize(window.Window, out int clientWidth, out int clientHeight);
            SDL_GetWindowBordersSize(window.Window, out int top, out int left, out int bottom, out int right);

            width = clientWidth + left + right;
            height = clientHeight + top + bottom;
        }

        /// <inheritdoc/>
        public void SetSize(WindowHandle handle, int width, int height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_GetWindowBordersSize(window.Window, out int top, out int left, out int bottom, out int right);

            int clientWidth = Math.Max(width - left - right, 0);
            int clientHeight = Math.Max(height - top - bottom, 0);

            SDL_SetWindowSize(window.Window, clientWidth, clientHeight);
        }

        /// <inheritdoc/>
        public void GetBounds(WindowHandle handle, out int x, out int y, out int width, out int height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_GetWindowPosition(window.Window, out int clientX, out int clientY);
            SDL_GetWindowSize(window.Window, out int clientWidth, out int clientHeight);
            SDL_GetWindowBordersSize(window.Window, out int top, out int left, out int bottom, out int right);

            x = clientX - left;
            y = clientY - top;
            width = clientWidth + left + right;
            height = clientHeight + top + bottom;
        }

        /// <inheritdoc/>
        public void SetBounds(WindowHandle handle, int x, int y, int width, int height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_GetWindowBordersSize(window.Window, out int top, out int left, out int bottom, out int right);

            int clientX = x + left;
            int clientY = y + top;
            int clientWidth = Math.Max(width - left - right, 0);
            int clientHeight = Math.Max(height - top - bottom, 0);

            SDL_SetWindowPosition(window.Window, clientX, clientY);
            SDL_SetWindowSize(window.Window, clientWidth, clientHeight);
        }

        /// <inheritdoc/>
        public void GetClientPosition(WindowHandle handle, out int x, out int y)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_GetWindowPosition(window.Window, out x, out y);
        }

        /// <inheritdoc/>
        public void SetClientPosition(WindowHandle handle, int x, int y)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_SetWindowPosition(window.Window, x, y);
        }

        /// <inheritdoc/>
        public void GetClientSize(WindowHandle handle, out int width, out int height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_GL_GetDrawableSize(window.Window, out width, out height);
        }

        /// <inheritdoc/>
        public void SetClientSize(WindowHandle handle, int width, int height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_SetWindowSize(window.Window, width, height);
        }

        /// <inheritdoc/>
        public void GetClientBounds(WindowHandle handle, out int x, out int y, out int width, out int height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_GetWindowPosition(window.Window, out x, out y);
            SDL_GetWindowSize(window.Window, out width, out height);
        }

        /// <inheritdoc/>
        public void SetClientBounds(WindowHandle handle, int x, int y, int width, int height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_SetWindowPosition(window.Window, x, y);
            SDL_SetWindowSize(window.Window, width, height);
        }

        /// <inheritdoc/>
        public void GetMaxClientSize(WindowHandle handle, out int? width, out int? height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            int w, h;

            // FIXME: Is this client area or windowEvent??

            SDL_GetWindowMaximumSize(window.Window, out w, out h);

            width = w != 0 ? w : null;
            height = h != 0 ? h : null;
        }

        /// <inheritdoc/>
        public void SetMaxClientSize(WindowHandle handle, int? width, int? height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            // FIXME: Is this client area or windowEvent??

            SDL_SetWindowMaximumSize(window.Window, width ?? 0, height ?? 0);
        }

        /// <inheritdoc/>
        public void GetMinClientSize(WindowHandle handle, out int? width, out int? height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            int w, h;

            SDL_GetWindowMinimumSize(window.Window, out w, out h);

            width = w != 0 ? w : null;
            height = h != 0 ? h : null;
        }

        /// <inheritdoc/>
        public void SetMinClientSize(WindowHandle handle, int? width, int? height)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_SetWindowMinimumSize(window.Window, width ?? 0, height ?? 0);
        }

        /// <inheritdoc/>
        public DisplayHandle GetDisplay(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            int index = SDL_GetWindowDisplayIndex(window.Window);

            // FIXME: We should probably call SDLDisplayComponent.Create or something like that...
            return new SDLDisplay(index);
        }

        /// <inheritdoc/>
        public WindowMode GetMode(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_WindowFlags flags = SDL_GetWindowFlags(window.Window);

            if (flags.HasFlag(SDL_WindowFlags.SDL_WINDOW_HIDDEN))
            {
                return WindowMode.Hidden;
            }
            else if (flags.HasFlag(SDL_WindowFlags.SDL_WINDOW_MAXIMIZED))
            {
                return WindowMode.Maximized;
            }
            else if (flags.HasFlag(SDL_WindowFlags.SDL_WINDOW_MINIMIZED))
            {
                return WindowMode.Minimized;
            }
            // We need to check this before SDL_WINDOW_FULLSCREEN because SDL_WINDOW_FULLSCREEN_DESKTOP contains that flag.
            else if (flags.HasFlag(SDL_WindowFlags.SDL_WINDOW_FULLSCREEN_DESKTOP))
            {
                return WindowMode.WindowedFullscreen;
            }
            else if (flags.HasFlag(SDL_WindowFlags.SDL_WINDOW_FULLSCREEN))
            {
                return WindowMode.ExclusiveFullscreen;
            }
            else
            {
                return WindowMode.Normal;
            }
        }

        /// <inheritdoc/>
        public void SetMode(WindowHandle handle, WindowMode mode)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            if ((SDL_GetWindowFlags(window.Window) & SDL_WindowFlags.SDL_WINDOW_FULLSCREEN) != 0 &&
                (mode != WindowMode.WindowedFullscreen || mode != WindowMode.ExclusiveFullscreen))
            {
                // We are going out of fullscreen.
                SDL_SetWindowFullscreen(window.Window, 0);
            }

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
                    SetFullscreenDisplay(window, null);
                    break;
                case WindowMode.ExclusiveFullscreen:
                    {
                        // FIXME: Can we create the current video mode in a better way?
                        int result = SDL_GetCurrentDisplayMode(SDL_GetWindowDisplayIndex(window.Window), out SDL_DisplayMode displayMode);
                        if (result != 0)
                        {
                            string error = SDL_GetError();
                            throw new PalException(this, $"SDL could not get current display mode: {error}");
                        }
                        VideoMode videoMode = new VideoMode(displayMode.w, displayMode.h, displayMode.refresh_rate, (int)SDL_BITSPERPIXEL(displayMode.format));
                        SetFullscreenDisplay(window, GetDisplay(window), videoMode);
                        break;
                    }
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, typeof(WindowMode));
            }
        }

        /// <inheritdoc/>
        public void SetFullscreenDisplay(WindowHandle window, DisplayHandle? display)
        {
            SDLWindow sdlWindow = window.As<SDLWindow>(this);

            SDLDisplay sdlDisplay;
            if (display != null)
            {
                sdlDisplay = display.As<SDLDisplay>(this);

                // We need to move the window to the correct display before making it fullscreen.

                int result = SDL_GetDisplayBounds(sdlDisplay.Index, out SDL_Rect rect);
                if (result == 0) SDL_SetWindowPosition(sdlWindow.Window, rect.x, rect.y);
                else Logger?.LogWarning("Could not get display bounds when making window fullscreen. This may cause the window to get fullscreened on the wrong display.");
                
                result = SDL_SetWindowFullscreen(sdlWindow.Window, SDL_FullscreenMode.SDL_WINDOW_FULLSCREEN_DESKTOP);
                if (result != 0)
                {
                    string error = SDL_GetError();
                    throw new PalException(this, $"SDL could not make the window fullscreen: {error}");
                }
            }
            else
            {
                // We want to go fullscreen on the current display, so we just do that.
                int result = SDL_SetWindowFullscreen(sdlWindow.Window, SDL_FullscreenMode.SDL_WINDOW_FULLSCREEN_DESKTOP);
                if (result != 0)
                {
                    string error = SDL_GetError();
                    throw new PalException(this, $"SDL could not make the window fullscreen: {error}");
                }
            }
        }

        /// <inheritdoc/>
        public void SetFullscreenDisplay(WindowHandle window, DisplayHandle display, VideoMode videoMode)
        {
            SDLWindow sdlWindow = window.As<SDLWindow>(this);
            SDLDisplay sdlDisplay = display.As<SDLDisplay>(this);

            int result = SDL_GetDisplayBounds(sdlDisplay.Index, out SDL_Rect rect);
            if (result == 0) SDL_SetWindowPosition(sdlWindow.Window, rect.x, rect.y);
            else Logger?.LogWarning("Could not get display bounds when making window fullscreen. This may cause the window to get fullscreened on the wrong display.");

            result = SDL_SetWindowFullscreen(sdlWindow.Window, SDL_FullscreenMode.SDL_WINDOW_FULLSCREEN);
            if (result != 0)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL could not make the window fullscreen: {error}");
            }

            // FIXME: Go from BitsPerPixel to SDL display mode format enums, how should we do it?
            // For now we just pick a few arbitrary formats for some color depths in the hope that they are fine.
            // - 2023-06-24 Noggin_Bops
            SDL_DisplayMode mode;
            mode.w = videoMode.Width;
            mode.h = videoMode.Height;
            // FIXME: How do we cast the refresh rate to an int?
            mode.refresh_rate = (int)videoMode.RefreshRate;
            mode.format = videoMode.BitsPerPixel switch
            {
                32 => SDL_PixelFormatEnum.SDL_PIXELFORMAT_RGBA8888,
                24 => SDL_PixelFormatEnum.SDL_PIXELFORMAT_RGB888,
                16 => SDL_PixelFormatEnum.SDL_PIXELFORMAT_RGB565,
                8 => SDL_PixelFormatEnum.SDL_PIXELFORMAT_RGB332,
                _ => 0,
            };
            if (mode.format == 0)
            {
                Logger?.LogWarning($"We only support bit depths of 32, 24, 16, and 8 when running on SDL.");
                mode.format = SDL_PixelFormatEnum.SDL_PIXELFORMAT_RGBA8888;
            }
            unsafe { mode.driverdata = null; }
            result = SDL_SetWindowDisplayMode(sdlWindow.Window, mode);
            if (result != 0)
            {
                string error = SDL_GetError();
                throw new PalException(this, $"SDL could not set the display mode: {error}");
            }
        }

        /// <inheritdoc/>
        public bool GetFullscreenDisplay(WindowHandle window, [NotNullWhen(true)] out DisplayHandle? display)
        {
            SDLWindow sdlWindow = window.As<SDLWindow>(this);
            SDL_WindowFlags flags = SDL_GetWindowFlags(sdlWindow.Window);
            if ((flags & SDL_WindowFlags.SDL_WINDOW_FULLSCREEN) != 0)
            {
                display = GetDisplay(window);
                return true;
            }
            else
            {
                display = null;
                return false;
            }
        }

        /// <inheritdoc/>
        public WindowBorderStyle GetBorderStyle(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_WindowFlags flags = SDL_GetWindowFlags(window.Window);

            bool hasBorder = flags.HasFlag(SDL_WindowFlags.SDL_WINDOW_BORDERLESS) == false;
            bool resizable = flags.HasFlag(SDL_WindowFlags.SDL_WINDOW_RESIZABLE);

            if (hasBorder && resizable)
            {
                return WindowBorderStyle.ResizableBorder;
            }
            else if (hasBorder && resizable == false)
            {
                return WindowBorderStyle.FixedBorder;
            }
            else if (hasBorder == false)
            {
                return WindowBorderStyle.Borderless;
            }

            // FIXME: Toolbox windows.
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetBorderStyle(WindowHandle handle, WindowBorderStyle style)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            switch (style)
            {
                case WindowBorderStyle.Borderless:
                    SDL_SetWindowBordered(window.Window, 0);
                    // FIXME: Maybe this borderless should not be resizable?
                    SDL_SetWindowResizable(window.Window, 1);
                    break;
                case WindowBorderStyle.FixedBorder:
                    SDL_SetWindowBordered(window.Window, 1);
                    SDL_SetWindowResizable(window.Window, 0);
                    break;
                case WindowBorderStyle.ResizableBorder:
                    SDL_SetWindowBordered(window.Window, 1);
                    SDL_SetWindowResizable(window.Window, 1);
                    break;
                case WindowBorderStyle.ToolBox:
                    throw new NotImplementedException();
                default:
                    throw new InvalidEnumArgumentException(nameof(style), (int)style, typeof(WindowBorderStyle));
            }
        }

        /// <inheritdoc/>
        public void SetAlwaysOnTop(WindowHandle handle, bool floating)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_SetWindowAlwaysOnTop(window.Window, floating ? 1 : 0);
        }

        /// <inheritdoc/>
        public bool IsAlwaysOnTop(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_WindowFlags flags = SDL_GetWindowFlags(window.Window);

            return flags.HasFlag(SDL_WindowFlags.SDL_WINDOW_ALWAYS_ON_TOP);
        }

        /// <inheritdoc/>
        public void SetHitTestCallback(WindowHandle handle, HitTest? test)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            window.HitTest = test;
            if (test == null)
            {
                SDL_SetWindowHitTest(window.Window, null, IntPtr.Zero);
            }
            else
            {
                SDL_SetWindowHitTest(window.Window, SDL_HitTest, IntPtr.Zero);
            }
            
            static SDL_HitTestResult SDL_HitTest(SDL_WindowPtr win, in SDL_Point pt, IntPtr data)
            {
                SDLWindow window = WindowDict[SDL_GetWindowID(win)];

                if (window.HitTest != null)
                {
                    HitType result = window.HitTest(window, new Vector2(pt.x, pt.y));
                    return result switch
                    {
                        HitType.Default => throw new NotSupportedException("SDL2 doesn't support HitType.Default. Consider removing the hit test callback to get default behaviour."),
                        HitType.Normal => SDL_HitTestResult.SDL_HITTEST_NORMAL,
                        HitType.Draggable => SDL_HitTestResult.SDL_HITTEST_DRAGGABLE,
                        HitType.ResizeTopLeft => SDL_HitTestResult.SDL_HITTEST_RESIZE_TOPLEFT,
                        HitType.ResizeTop => SDL_HitTestResult.SDL_HITTEST_RESIZE_TOP,
                        HitType.ResizeTopRight => SDL_HitTestResult.SDL_HITTEST_RESIZE_TOPRIGHT,
                        HitType.ResizeRight => SDL_HitTestResult.SDL_HITTEST_RESIZE_RIGHT,
                        HitType.ResizeBottomRight => SDL_HitTestResult.SDL_HITTEST_RESIZE_BOTTOMRIGHT,
                        HitType.ResizeBottom => SDL_HitTestResult.SDL_HITTEST_RESIZE_BOTTOM,
                        HitType.ResizeBottomLeft => SDL_HitTestResult.SDL_HITTEST_RESIZE_BOTTOMLEFT,
                        HitType.ResizeLeft => SDL_HitTestResult.SDL_HITTEST_RESIZE_LEFT,
                        _ => throw new InvalidEnumArgumentException("return", (int)result, typeof(HitType)),
                    };
                }
                else
                {
                    throw new InvalidOperationException("The window hit-test has been removed.");
                }
            }
        }

        /// <inheritdoc/>
        public void SetCursor(WindowHandle handle, CursorHandle? cursor)
        {
            SDLWindow window = handle.As<SDLWindow>(this);
            SDLCursor? sdlCursor = cursor?.As<SDLCursor>(this);

            if (sdlCursor == null)
            {
                SDL_ShowCursor(0 /* SDL_DISABLE */);
            }
            else
            {
                SDL_ShowCursor(1 /* SDL_ENABLE */);

                // FIXME: SDL handles the cursor as a global thing, while
                // we handle it per window. Is this something we want to change?
                //   - Do we gain anything by making the cursor per window?
                //     Aren't you always going to check the position of the cursor and set the
                //     cursor when needed? Leaving a window with a particular cursor isn't a win.
                // or do we have to work around this for the SDL backend?
                SDL_SetCursor(sdlCursor.Cursor);
            }
        }

        /// <inheritdoc/>
        public CursorCaptureMode GetCursorCaptureMode(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            bool grabbed = SDL_GetWindowGrab(window.Window) == 1;

            // FIXME: CursorCaptureMode.Locked!

            if (grabbed)
            {
                return CursorCaptureMode.Confined;
            }
            else
            {
                return CursorCaptureMode.Normal;
            }

            throw new NotImplementedException("CursorCaptureMode.Locked");
        }

        /// <inheritdoc/>
        public void SetCursorCaptureMode(WindowHandle handle, CursorCaptureMode mode)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            switch (mode)
            {
                case CursorCaptureMode.Normal:
                    SDL_SetWindowGrab(window.Window, 0);
                    break;
                case CursorCaptureMode.Confined:
                    SDL_SetWindowGrab(window.Window, 1);
                    break;
                case CursorCaptureMode.Locked:
                    // FIXME: Use SDL_SetRelativeMouseMode in some way...
                    throw new NotImplementedException("CursorCaptureMode.Locked");
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, typeof(CursorCaptureMode));
            }
        }

        /// <inheritdoc/>
        public void FocusWindow(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_RaiseWindow(window.Window);
        }

        /// <inheritdoc/>
        public void RequestAttention(WindowHandle handle)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_FlashWindow(window.Window, SDL_FlashOperation.SDL_FLASH_UNTIL_FOCUSED);
        }

        /// <inheritdoc/>
        public void ScreenToClient(WindowHandle handle, int x, int y, out int clientX, out int clientY)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            // FIXME: How to do this??

            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void ClientToScreen(WindowHandle handle, int clientX, int clientY, out int x, out int y)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            // FIXME: How to do this??

            throw new NotImplementedException();
        }
    }
}
