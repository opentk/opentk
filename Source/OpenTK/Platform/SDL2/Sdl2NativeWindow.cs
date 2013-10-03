#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2NativeWindow : INativeWindow, IInputDriver
    {
        readonly object sync = new object();

        Sdl2WindowInfo window;
        uint window_id;
        bool is_visible;
        bool is_focused;
        bool is_cursor_visible = true;
        bool exists;
        bool disposed;
        WindowState window_state = WindowState.Normal;
        WindowState previous_window_state = WindowState.Normal;
        WindowBorder window_border = WindowBorder.Resizable;
        Icon icon;
        string window_title;

        KeyboardDevice keyboard = new KeyboardDevice();
        MouseDevice mouse = new MouseDevice();
        IList<KeyboardDevice> keyboards = new List<KeyboardDevice>(1);
        IList<MouseDevice> mice = new List<MouseDevice>(1);

        readonly SDL.SDL_EventFilter EventFilterDelegate = FilterEvents;

        static readonly Dictionary<uint, Sdl2NativeWindow> windows =
            new Dictionary<uint, Sdl2NativeWindow>();

        static readonly Sdl2KeyMap map = new Sdl2KeyMap();

        public Sdl2NativeWindow(int x, int y, int width, int height,
            string title, GameWindowFlags options, DisplayDevice device)
        {
            lock (sync)
            {
                var bounds = device.Bounds;
                var flags = TranslateFlags(options);
                flags |= SDL.SDL_WindowFlags.SDL_WINDOW_OPENGL;
                flags |= SDL.SDL_WindowFlags.SDL_WINDOW_RESIZABLE;
                flags |= SDL.SDL_WindowFlags.SDL_WINDOW_HIDDEN;

                if ((flags & SDL.SDL_WindowFlags.SDL_WINDOW_FULLSCREEN_DESKTOP) != 0 ||
                    (flags & SDL.SDL_WindowFlags.SDL_WINDOW_FULLSCREEN) != 0)
                    window_state = WindowState.Fullscreen;

                IntPtr handle;
                lock (SDL.Sync)
                {
                    handle = SDL.SDL_CreateWindow(title, bounds.Left + x, bounds.Top + y, width, height, flags);
                    SDL.SDL_AddEventWatch(EventFilterDelegate, handle);
                    SDL.SDL_PumpEvents();
                }
                window = new Sdl2WindowInfo(handle, null);
                window_id = SDL.SDL_GetWindowID(handle);
                windows.Add(window_id, this);
                window_title = title;

                keyboard.Description = "Standard keyboard";
                keyboard.NumberOfFunctionKeys = 12;
                keyboard.NumberOfKeys = 101;
                keyboard.NumberOfLeds = 3;

                mouse.Description = "Standard mouse";
                mouse.NumberOfButtons = 3;
                mouse.NumberOfWheels = 1;

                keyboards.Add(keyboard);
                mice.Add(mouse);

                exists = true;
            }
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

        static Key TranslateKey(SDL.SDL_Scancode scan)
        {
            Key result = Key.Unknown;
            if (map.ContainsKey(scan))
            {
                result = map[scan];
            }
            return result;
        }

        static Key TranslateKey(SDL.SDL_Keycode key)
        {
            SDL.SDL_Scancode scan = SDL.SDL_GetScancodeFromKey(key);
            return TranslateKey(scan);
        }

        unsafe static int FilterEvents(IntPtr user_data, IntPtr e)
        {
            bool processed = false;

            try
            {
                Sdl2NativeWindow window = null;
                SDL.SDL_Event ev = *(SDL.SDL_Event*)e;

                switch (ev.type)
                {
                    case SDL.SDL_EventType.SDL_WINDOWEVENT:
                        if (windows.TryGetValue(ev.window.windowID, out window))
                        {
                            ProcessWindowEvent(window, ev.window);
                            processed = true;
                        }
                        break;

                    case SDL.SDL_EventType.SDL_KEYDOWN:
                    case SDL.SDL_EventType.SDL_KEYUP:
                        if (windows.TryGetValue(ev.key.windowID, out window))
                        {
                            ProcessKeyEvent(window, ev);
                            processed = true;
                        }
                        break;

                    case SDL.SDL_EventType.SDL_MOUSEBUTTONDOWN:
                    case SDL.SDL_EventType.SDL_MOUSEBUTTONUP:
                        if (windows.TryGetValue(ev.button.windowID, out window))
                        {
                            ProcessButtonEvent(window, ev);
                            processed = true;
                        }
                        break;

                    case SDL.SDL_EventType.SDL_MOUSEMOTION:
                        if (windows.TryGetValue(ev.motion.windowID, out window))
                        {
                            ProcessMotionEvent(window, ev);
                            processed = true;
                        }
                        break;

                    case SDL.SDL_EventType.SDL_MOUSEWHEEL:
                        if (windows.TryGetValue(ev.wheel.windowID, out window))
                        {
                            ProcessWheelEvent(window, ev);
                            processed = true;
                        }
                        break;

                    case SDL.SDL_EventType.SDL_QUIT:
                        Debug.WriteLine("Sdl2 application quit");
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }

            return processed ? 0 : 1;
        }

        static void ProcessButtonEvent(Sdl2NativeWindow window, SDL.SDL_Event ev)
        {
            bool button_pressed = ev.button.state == SDL.SDL_PRESSED;

            // We need MouseUp events to be reported even if they occur
            // outside the window. SetWindowGrab ensures we get them.
            if (window.CursorVisible)
            {
                SDL.SDL_SetWindowGrab(window.window.Handle,
                    button_pressed ? SDL.SDL_bool.SDL_TRUE : SDL.SDL_bool.SDL_FALSE);
            }

            switch (ev.button.button)
            {
                case (byte)SDL.SDL_BUTTON_LEFT:
                    window.mouse[MouseButton.Left] = button_pressed;
                    break;

                case (byte)SDL.SDL_BUTTON_MIDDLE:
                    window.mouse[MouseButton.Middle] = button_pressed;
                    break;
                
                case (byte)SDL.SDL_BUTTON_RIGHT:
                    window.mouse[MouseButton.Right] = button_pressed;
                    break;
                
                case (byte)SDL.SDL_BUTTON_X1:
                    window.mouse[MouseButton.Button1] = button_pressed;
                    break;
                
                case (byte)SDL.SDL_BUTTON_X2:
                    window.mouse[MouseButton.Button2] = button_pressed;
                    break;
            }
        }

        static void ProcessKeyEvent(Sdl2NativeWindow window, SDL.SDL_Event ev)
        {
            bool key_pressed = ev.key.state == SDL.SDL_PRESSED;
            var key = ev.key.keysym;
            window.keyboard.SetKey(TranslateKey(key.scancode), (uint)key.scancode, key_pressed);
        }

        static void ProcessMotionEvent(Sdl2NativeWindow window, SDL.SDL_Event ev)
        {
                window.mouse.Position = new Point(ev.motion.x, ev.motion.y);
        }

        static void ProcessWheelEvent(Sdl2NativeWindow window, SDL.SDL_Event ev)
        {
            window.mouse.Wheel += ev.wheel.y;
        }

        static void ProcessWindowEvent(Sdl2NativeWindow window, SDL.SDL_WindowEvent e)
        {
            switch (e.windowEvent)
            {
                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_CLOSE:
                    var close_args = new System.ComponentModel.CancelEventArgs();
                    window.Closing(window, close_args);
                    if (!close_args.Cancel)
                    {
                        window.Closed(window, EventArgs.Empty);
                        //window.DestroyWindow();
                    }
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_ENTER:
                    window.MouseEnter(window, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_LEAVE:
                    window.MouseLeave(window, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_EXPOSED:
                    // do nothing
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_FOCUS_GAINED:
                    window.is_focused = true;
                    window.FocusedChanged(window, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_FOCUS_LOST:
                    window.is_focused = false;
                    window.FocusedChanged(window, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_HIDDEN:
                    window.is_visible = false;
                    window.VisibleChanged(window, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_SHOWN:
                    window.is_visible = true;
                    window.VisibleChanged(window, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_MAXIMIZED:
                    window.previous_window_state = window.window_state;
                    window.window_state = OpenTK.WindowState.Maximized;
                    window.WindowStateChanged(window, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_MINIMIZED:
                    window.previous_window_state = window.window_state;
                    window.window_state = OpenTK.WindowState.Minimized;
                    window.WindowStateChanged(window, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_RESTORED:
                    window.window_state = window.previous_window_state;
                    window.WindowStateChanged(window, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_MOVED:
                    window.Move(window, EventArgs.Empty);
                    break;

                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_RESIZED:
                case SDL.SDL_WindowEventID.SDL_WINDOWEVENT_SIZE_CHANGED:
                    window.Resize(window, EventArgs.Empty);
                    break;

                default:
                    Debug.Print("SDL2 unhandled event: {0}", e.type);
                    break;
            }
        }

        void DestroyWindow()
        {
            exists = false;

            if (window.Handle != IntPtr.Zero)
            {
                lock (SDL.Sync)
                {
                    SDL.SDL_DelEventWatch(EventFilterDelegate, window.Handle);
                    if (windows.ContainsKey(window_id))
                    {
                        windows.Remove(window_id);
                    }
                    SDL.SDL_DestroyWindow(window.Handle);
                }
            }

            window_id = 0;
            window.Handle = IntPtr.Zero;
        }

        void GrabCursor(bool grab)
        {
            SDL.SDL_ShowCursor(grab ? 0 : 1);
            SDL.SDL_SetWindowGrab(window.Handle,
                grab ? SDL.SDL_bool.SDL_TRUE : SDL.SDL_bool.SDL_FALSE);
            SDL.SDL_SetRelativeMouseMode(
                grab ? SDL.SDL_bool.SDL_TRUE : SDL.SDL_bool.SDL_FALSE);
        }

        // Hack to force WindowState events to be pumped
        void HideShowWindowHack()
        {
            SDL.SDL_HideWindow(window.Handle);
            ProcessEvents();
            SDL.SDL_ShowWindow(window.Handle);
            ProcessEvents();
        }

        // Revert to WindowState.Normal if necessary
        void RestoreWindow()
        {
            WindowState state = WindowState;

            switch (state)
            {
                case WindowState.Fullscreen:
                    SDL.SDL_SetWindowFullscreen(window.Handle, 0);
                    break;

                case WindowState.Maximized:
                    SDL.SDL_RestoreWindow(window.Handle);
                    HideShowWindowHack();
                    break;

                case WindowState.Minimized:
                    SDL.SDL_RestoreWindow(window.Handle);
                    break;
            }

            ProcessEvents();

            window_state = WindowState.Normal;
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
            lock (sync)
            {
                if (Exists)
                {
                    Debug.Print("SDL2 destroying window {0}", window.Handle);

                    SDL.SDL_Event e = new SDL.SDL_Event();
                    e.type = SDL.SDL_EventType.SDL_WINDOWEVENT;
                    e.window.windowEvent = SDL.SDL_WindowEventID.SDL_WINDOWEVENT_CLOSE;
                    e.window.windowID = window_id;
                    lock (SDL.Sync)
                    {
                        SDL.SDL_PushEvent(ref e);
                    }
                }
            }
        }

        public void ProcessEvents()
        {
            lock (sync)
            {
                if (Exists)
                {
                    SDL.SDL_PumpEvents();
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
                lock (sync)
                {
                    if (Exists)
                    {
                        // Set the new icon, if any, or clear the current
                        // icon if null
                        if (value != null)
                        {
                            using (Bitmap bmp = value.ToBitmap())
                            {
                                // Decode the icon into a SDL surface
                                var data = bmp.LockBits(
                                    new Rectangle(0, 0, value.Width, value.Height),
                                    ImageLockMode.ReadWrite,
                                    PixelFormat.Format32bppArgb);

                                IntPtr surface = SDL.SDL_CreateRGBSurfaceFrom(
                                    data.Scan0, data.Width, data.Height, 32, data.Stride,
                                    0x00ff0000u, 0x0000ff00u, 0x000000ffu, 0xff000000u);

                                // Update the window icon
                                SDL.SDL_SetWindowIcon(window.Handle, surface);

                                // Free the SDL surface as it is no longer needed
                                SDL.SDL_FreeSurface(surface);
                                bmp.UnlockBits(data);
                            }

                        }
                        else
                        {
                            // Clear the window icon
                            SDL.SDL_SetWindowIcon(window.Handle, IntPtr.Zero);
                        }

                        icon = value;
                        IconChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        public string Title
        {
            get
            {
                lock (sync)
                {
                    if (Exists)
                    {
                        return SDL.SDL_GetWindowTitle(window.Handle);
                    }
                    return String.Empty;
                }
            }
            set
            {
                lock (sync)
                {
                    if (Exists)
                    {
                        SDL.SDL_SetWindowTitle(window.Handle, value);
                        window_title = value;
                    }
                }
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
                lock (sync)
                {
                    if (Exists)
                    {
                        if (value)
                            SDL.SDL_ShowWindow(window.Handle);
                        else
                            SDL.SDL_HideWindow(window.Handle);
                    }
                }
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
                return window_state;
            }
            set
            {
                lock (sync)
                {
                    if (Exists)
                    {
                        if (WindowState != value)
                        {
                            // Set the new WindowState
                            switch (value)
                            {
                                case WindowState.Fullscreen:
                                    RestoreWindow();
                                    if (SDL.SDL_SetWindowFullscreen(window.Handle, (uint)SDL.SDL_WindowFlags.SDL_WINDOW_FULLSCREEN_DESKTOP) < 0)
                                    {
                                        if (SDL.SDL_SetWindowFullscreen(window.Handle, (uint)SDL.SDL_WindowFlags.SDL_WINDOW_FULLSCREEN) < 0)
                                        {
                                            Debug.Print("SDL2 failed to enter fullscreen mode: {0}", SDL.SDL_GetError());
                                        }
                                    }
                                    SDL.SDL_RaiseWindow(window.Handle);
                                    // There is no "fullscreen" message in the event loop
                                    // so we have to mark that ourselves
                                    window_state = WindowState.Fullscreen;
                                    break;

                                case WindowState.Maximized:
                                    RestoreWindow();
                                    SDL.SDL_MaximizeWindow(window.Handle);
                                    HideShowWindowHack();
                                    break;

                                case WindowState.Minimized:
                                    SDL.SDL_MinimizeWindow(window.Handle);
                                    break;

                                case WindowState.Normal:
                                    RestoreWindow();
                                    break;
                            }

                            if (!CursorVisible)
                                GrabCursor(true);
                        }
                    }
                }
            }
        }

        public WindowBorder WindowBorder
        {
            get
            {
                return window_border;
            }
            set
            {
                if (WindowBorder != value)
                {
                    lock (sync)
                    {
                        if (Exists)
                        {

                            switch (value)
                            {
                                case WindowBorder.Resizable:
                                    SDL.SDL_SetWindowBordered(window.Handle, SDL.SDL_bool.SDL_TRUE);
                                    window_border = WindowBorder.Resizable;
                                    break;

                                case WindowBorder.Hidden:
                                    SDL.SDL_SetWindowBordered(window.Handle, SDL.SDL_bool.SDL_FALSE);
                                    window_border = WindowBorder.Hidden;
                                    break;

                                case WindowBorder.Fixed:
                                    Debug.WriteLine("SDL2 cannot change to fixed-size windows at runtime.");
                                    break;
                            }
                        }
                    }

                    if (Exists)
                    {
                        WindowBorderChanged(this, EventArgs.Empty);
                    }
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
                lock (sync)
                {
                    if (Exists)
                    {
                        int x, y;
                        SDL.SDL_GetWindowPosition(window.Handle, out x, out y);
                        return new Point(x, y);
                    }
                    return new Point();
                }
            }
            set
            {
                lock (sync)
                {
                    if (Exists)
                    {
                        SDL.SDL_SetWindowPosition(window.Handle, value.X, value.Y);
                    }
                }
            }
        }

        public Size Size
        {
            get
            {
                lock (sync)
                {
                    if (Exists)
                    {
                        int w, h;
                        SDL.SDL_GetWindowSize(window.Handle, out w, out h);
                        return new Size(w, h);
                    }
                    return new Size();
                }
            }
            set
            {
                lock (sync)
                {
                    if (Exists)
                    {
                        SDL.SDL_SetWindowSize(window.Handle, value.Width, value.Height);
                    }
                }
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
                lock (sync)
                {
                    if (Exists)
                    {
                        GrabCursor(!value);
                        is_cursor_visible = value;
                    }
                }
            }
        }

        #endregion

        #region IInputDriver Members

        public void Poll()
        {
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
            if (!disposed)
            {
                if (manual)
                {
                    Debug.Print("Disposing {0}", GetType());
                    lock (sync)
                    {
                        if (Exists)
                        {
                            DestroyWindow();
                        }
                    }
                }
                else
                {
                    Debug.WriteLine("Sdl2NativeWindow leaked, did you forget to call Dispose()?");
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

