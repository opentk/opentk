using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2NativeWindow : INativeWindow, IInputDriver
    {
        Sdl2WindowInfo window;
        bool is_visible;
        bool is_focused;
        bool is_cursor_visible = true;
        bool exists;
        bool disposed;
        Icon icon;

        KeyboardDevice keyboard = new KeyboardDevice();
        MouseDevice mouse = new MouseDevice();
        IList<KeyboardDevice> keyboards = new List<KeyboardDevice>(1);
        IList<MouseDevice> mice = new List<MouseDevice>(1);

        static Sdl2KeyMap map = new Sdl2KeyMap();

        public Sdl2NativeWindow(int x, int y, int width, int height,
            string title, GameWindowFlags options, DisplayDevice device)
        {
            var bounds = device.Bounds;
            var flags = TranslateFlags(options);
            flags |= SDL.SDL_WindowFlags.SDL_WINDOW_OPENGL;
            flags |= SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE;
            IntPtr handle = SDL.SDL_CreateWindow(title, bounds.Left + x, bounds.Top + y, width, height, flags);
            window = new Sdl2WindowInfo(handle, null);

            keyboard.Description = "Standard Windows keyboard";
            keyboard.NumberOfFunctionKeys = 12;
            keyboard.NumberOfKeys = 101;
            keyboard.NumberOfLeds = 3;

            mouse.Description = "Standard Windows mouse";
            mouse.NumberOfButtons = 3;
            mouse.NumberOfWheels = 1;

            keyboards.Add(keyboard);
            mice.Add(mouse);

            exists = true;
        }

        #region Private Members

        static SDL.SDL_WindowFlags TranslateFlags(GameWindowFlags flags)
        {
            switch (flags)
            {
                case GameWindowFlags.Fullscreen:
                    return SDL.SDL_WindowFlags.SDL_WINDOW_FULLSCREEN_DESKTOP;
                
                default:
                    return (SDL.SDL_WindowFlags)0;
            }
        }

        static Key TranslateKey(SDL.SDL_Keycode key)
        {
            Key result = Key.Unknown;
            if (map.ContainsKey(key))
            {
                result = map[key];
            }
            return result;
        }

        void ProcessWindowEvent(SDL.SDL_WindowEvent e)
        {
            switch (e.windowEvent)
            {
                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_CLOSE:
                    Closed(this, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_ENTER:
                    MouseEnter(this, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_LEAVE:
                    MouseLeave(this, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_EXPOSED:
                    // do nothing
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_FOCUS_GAINED:
                    is_focused = true;
                    FocusedChanged(this, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_FOCUS_LOST:
                    is_focused = false;
                    FocusedChanged(this, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_HIDDEN:
                    is_visible = false;
                    VisibleChanged(this, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_SHOWN:
                    is_visible = true;
                    VisibleChanged(this, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_MAXIMIZED:
                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_MINIMIZED:
                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_RESTORED:
                    WindowStateChanged(this, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_MOVED:
                    Move(this, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_RESIZED:
                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_SIZE_CHANGED:
                    Resize(this, EventArgs.Empty);
                    break;

                default:
                    Debug.Print("SDL2 unhandled event: {0}", e.type);
                    break;
            }
        }

        void DestroyWindow()
        {
            exists = false;
            SDL.SDL_DestroyWindow(window.Handle);
            window.Handle = IntPtr.Zero;
        }

        #endregion

        #region INativeWindow Members

        public event EventHandler<EventArgs> Move = delegate { };
        public event EventHandler<EventArgs> Resize = delegate { };
        public event EventHandler<System.ComponentModel.CancelEventArgs> Closing = delegate { };
        public event EventHandler<EventArgs> Closed = delegate { };
        public event EventHandler<EventArgs> Disposed = delegate { };
        public event EventHandler<EventArgs> IconChanged = delegate { };
        public event EventHandler<EventArgs> TitleChanged = delegate { };
        public event EventHandler<EventArgs> VisibleChanged = delegate { };
        public event EventHandler<EventArgs> FocusedChanged = delegate { };
        public event EventHandler<EventArgs> WindowBorderChanged = delegate { };
        public event EventHandler<EventArgs> WindowStateChanged = delegate { };
        public event EventHandler<KeyboardKeyEventArgs> KeyDown = delegate { };
        public event EventHandler<KeyPressEventArgs> KeyPress = delegate { };
        public event EventHandler<KeyboardKeyEventArgs> KeyUp = delegate { }; 
        public event EventHandler<EventArgs> MouseEnter = delegate { };
        public event EventHandler<EventArgs> MouseLeave = delegate { };

        public void Close()
        {
            if (Exists)
            {
                Debug.Print("SDL2 destroying window {0}", window.Handle);
                SDL.SDL_Event e = new SDL.SDL_Event();
                e.type = SDL.SDL_EventType.SDL_QUIT;
                SDL.SDL_PushEvent(ref e);
                SDL.SDL_PumpEvents();
            }
        }

        public void ProcessEvents()
        {
            SDL.SDL_Event e;
            while (SDL.SDL_PollEvent(out e) != 0)
            {
                switch (e.type)
                {
                    case SDL.SDL_EventType.SDL_KEYDOWN:
                    case SDL.SDL_EventType.SDL_KEYUP:
                        bool key_pressed = e.key.state == SDL.SDL_PRESSED;
                        var key = e.key.keysym;
                        keyboard.SetKey(TranslateKey(key.sym), (uint)key.scancode, key_pressed);
                        break;

                    case SDL.SDL_EventType.SDL_MOUSEBUTTONDOWN:
                    case SDL.SDL_EventType.SDL_MOUSEBUTTONUP:
                        bool button_pressed = e.button.state == SDL.SDL_PRESSED;
                        switch (e.button.button)
                        {
                            case (byte)SDL.SDL_BUTTON_LEFT:
                                mouse[MouseButton.Left] = button_pressed;
                                break;
                            
                            case (byte)SDL.SDL_BUTTON_MIDDLE:
                                mouse[MouseButton.Middle] = button_pressed;
                                break;
                            
                            case (byte)SDL.SDL_BUTTON_RIGHT:
                                mouse[MouseButton.Right] = button_pressed;
                                break;

                            case (byte)SDL.SDL_BUTTON_X1:
                                mouse[MouseButton.Button1] = button_pressed;
                                break;
                                
                            case (byte)SDL.SDL_BUTTON_X2:
                                mouse[MouseButton.Button2] = button_pressed;
                                break;
                        }
                        break;

                    case SDL.SDL_EventType.SDL_MOUSEMOTION:
                        if (CursorVisible)
                        {
                            mouse.Position = new Point(e.motion.x, e.motion.y);
                        }
                        else
                        {
                            mouse.Position = new Point(mouse.X + e.motion.x, mouse.Y + e.motion.y);
                        }
                        break;

                    case SDL.SDL_EventType.SDL_MOUSEWHEEL:
                        mouse.Wheel += e.wheel.y;
                        break;

                    case SDL.SDL_EventType.SDL_QUIT:
                        var close_args = new System.ComponentModel.CancelEventArgs();
                        Closing(this, close_args);
                        if (!close_args.Cancel)
                        {
                            DestroyWindow();
                        }
                        break;

                    case SDL.SDL_EventType.SDL_WINDOWEVENT:
                        ProcessWindowEvent(e.window);
                        break;
                }
            }
        }

        public Point PointToClient(Point point)
        {
            var origin = DisplayDevice.Default.Bounds.Location;
            var client = Location;
            return new Point(point.X + client.X - origin.X, point.Y + client.Y - origin.Y);
        }

        public Point PointToScreen(Point point)
        {
            var origin = DisplayDevice.Default.Bounds.Location;
            var client = Location;
            return new Point(point.X + origin.X - client.X, point.Y + origin.Y - client.Y);
        }

        public Icon Icon
        {
            get
            {
                return icon;
            }
            set
            {
                IntPtr surface = IntPtr.Zero;
                if (value != null)
                {
                    using (Bitmap bmp = value.ToBitmap())
                    {
                        var data = bmp.LockBits(
                            new Rectangle(0, 0, value.Width, value.Height),
                            ImageLockMode.ReadWrite,
                            PixelFormat.Format32bppArgb);

                        surface = SDL.SDL_CreateRGBSurfaceFrom(
                            data.Scan0, data.Width, data.Height, 32, data.Height,
                            0x0000ff00u, 0x00ff0000u, 0xff000000u, 0x000000ffu);

                        bmp.UnlockBits(data);
                    }
                }
                SDL.SDL_SetWindowIcon(window.Handle, surface);
                icon = value;
                IconChanged(this, EventArgs.Empty);
            }
        }

        public string Title
        {
            get
            {
                return SDL.SDL_GetWindowTitle(window.Handle);
            }
            set
            {
                SDL.SDL_SetWindowTitle(window.Handle, value);
            }
        }

        public bool Focused
        {
            get
            {
                return is_focused;
            }
        }

        public bool Visible
        {
            get
            {
                return is_visible;
            }
            set
            {
                if (value)
                    SDL.SDL_ShowWindow(window.Handle);
                else
                    SDL.SDL_HideWindow(window.Handle);
            }
        }

        public bool Exists
        {
            get
            {
                return exists;
            }
        }

        public IWindowInfo WindowInfo
        {
            get
            {
                return window;
            }
        }

        public WindowState WindowState
        {
            get
            {
                var flags = (SDL.SDL_WindowFlags)SDL.SDL_GetWindowFlags(window.Handle);
                switch (flags)
                {
                    case SDL.SDL_WindowFlags.SDL_WINDOW_FULLSCREEN:
                    case SDL.SDL_WindowFlags.SDL_WINDOW_FULLSCREEN_DESKTOP:
                        return WindowState.Fullscreen;

                    case SDL.SDL_WindowFlags.SDL_WINDOW_MAXIMIZED:
                        return WindowState.Maximized;

                    case SDL.SDL_WindowFlags.SDL_WINDOW_MINIMIZED:
                        return WindowState.Minimized;

                    default:
                        return WindowState.Normal;
                }
            }
            set
            {
                switch (value)
                {
                    case WindowState.Fullscreen:
                        if (SDL.SDL_SetWindowFullscreen(window.Handle, (uint)SDL.SDL_WindowFlags.SDL_WINDOW_FULLSCREEN_DESKTOP) < 0)
                        {
                            if (SDL.SDL_SetWindowFullscreen(window.Handle, (uint)SDL.SDL_WindowFlags.SDL_WINDOW_FULLSCREEN) < 0)
                            {
                                Debug.Print("SDL2 failed to enter fullscreen mode: {0}", SDL.SDL_GetError());
                            }
                        }
                        break;

                    case WindowState.Maximized:
                        SDL.SDL_MaximizeWindow(window.Handle);
                        break;

                    case WindowState.Minimized:
                        SDL.SDL_MinimizeWindow(window.Handle);
                        break;

                    case WindowState.Normal:
                        SDL.SDL_RestoreWindow(window.Handle);
                        break;
                }
            }
        }

        public WindowBorder WindowBorder
        {
            get
            {
                var flags = (SDL.SDL_WindowFlags)SDL.SDL_GetWindowFlags(window.Handle);
                switch (flags)
                {
                    case SDL.SDL_WindowFlags.SDL_WINDOW_BORDERLESS:
                        return WindowBorder.Hidden;

                    case SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE:
                        return WindowBorder.Resizable;

                    default:
                        return WindowBorder.Fixed;
                }
            }
            set
            {
                switch (value)
                {
                    case WindowBorder.Resizable:
                        SDL.SDL_SetWindowBordered(window.Handle, SDL.SDL_bool.SDL_TRUE);
                        break;

                    case WindowBorder.Hidden:
                        SDL.SDL_SetWindowBordered(window.Handle, SDL.SDL_bool.SDL_TRUE);
                        break;

                    case WindowBorder.Fixed:
                        Trace.WriteLine("SDL2 cannot change to fixed-size windows at runtime.");
                        break;
                }
            }
        }

        public Rectangle Bounds
        {
            get
            {
                return new Rectangle(Location, Size);
            }
            set
            {
                Size = value.Size;
                Location = value.Location;
            }
        }

        public Point Location
        {
            get
            {
                int x, y;
                SDL.SDL_GetWindowPosition(window.Handle, out x, out y);
                return new Point(x, y);
            }
            set
            {
                SDL.SDL_SetWindowPosition(window.Handle, value.X, value.Y);
            }
        }

        public Size Size
        {
            get
            {
                int w, h;
                SDL.SDL_GetWindowSize(window.Handle, out w, out h);
                return new Size(w, h);
            }
            set
            {
                SDL.SDL_SetWindowSize(window.Handle, value.Width, value.Height);
            }
        }

        public int X
        {
            get
            {
                return Location.X;
            }
            set
            {
                Location = new Point(value, Y);
            }
        }

        public int Y
        {
            get
            {
                return Location.Y;
            }
            set
            {
                Location = new Point(X, value);
            }
        }

        public int Width
        {
            get
            {
                return Size.Width;
            }
            set
            {
                Size = new Size(value, Height);
            }
        }

        public int Height
        {
            get
            {
                return Size.Height;
            }
            set
            {
                Size = new Size(Width, value);
            }
        }

        public Rectangle ClientRectangle
        {
            get
            {
                // Todo: SDL2 does not have any APIs to get
                // the border size or the bounds of the window
                // (everything is defined in terms of the client
                // area)
                return Bounds;
            }
            set
            {
                Bounds = value;
            }
        }

        public Size ClientSize
        {
            get
            {
                return Size;
            }
            set
            {
                Size = value;
            }
        }

        public IInputDriver InputDriver
        {
            get
            {
                return this;
            }
        }

        public bool CursorVisible
        {
            get
            {
                return is_cursor_visible;
            }
            set
            {
                SDL.SDL_ShowCursor(value ? 1 : 0);
                is_cursor_visible = value;
            }
        }

        #endregion

        #region IInputDriver Members

        public void Poll()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IJoystickDriver Members

        public IList<JoystickDevice> Joysticks
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region IMouseDriver Members

        public IList<MouseDevice> Mouse
        {
            get
            {
                return mice;
            }
        }

        #endregion

        #region IKeyboardDriver Members

        public IList<KeyboardDevice> Keyboard
        {
            get
            {
                return keyboards;
            }
        }

        #endregion

        #region IDisposable implementation

        void Dispose(bool manual)
        {
            if (manual)
            {
                if (!disposed)
                {
                    if (Exists)
                    {
                        DestroyWindow();
                    }
                }
                else
                {
                    Debug.Print("[Warning] INativeWindow leaked ({0}). Did you forget to call INativeWindow.Dispose()?", this);
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Sdl2NativeWindow()
        {
            Dispose(true);
        }

        #endregion
    }
}

