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
#if ANDROID || IPHONE || MINIMAL
using OpenTK.Minimal;
#else
using System.Drawing.Imaging;
#endif
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Input;
using System.Text;

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
        bool must_destroy;
        bool disposed;
        WindowState window_state = WindowState.Normal;
        WindowState previous_window_state = WindowState.Normal;
        WindowBorder window_border = WindowBorder.Resizable;
        Icon icon;
        string window_title;

        readonly IInputDriver input_driver = new Sdl2InputDriver();

        readonly EventFilter EventFilterDelegate_GCUnsafe = FilterEvents;
        readonly IntPtr EventFilterDelegate;

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
                flags |= WindowFlags.OPENGL;
                flags |= WindowFlags.RESIZABLE;
                flags |= WindowFlags.HIDDEN;
                flags |= WindowFlags.ALLOW_HIGHDPI;

                if ((flags & WindowFlags.FULLSCREEN_DESKTOP) != 0 ||
                    (flags & WindowFlags.FULLSCREEN) != 0)
                    window_state = WindowState.Fullscreen;

                IntPtr handle;
                lock (SDL.Sync)
                {
                    EventFilterDelegate = Marshal.GetFunctionPointerForDelegate(EventFilterDelegate_GCUnsafe);
                    handle = SDL.CreateWindow(title, bounds.Left + x, bounds.Top + y, width, height, flags);
                    SDL.AddEventWatch(EventFilterDelegate, handle);
                    SDL.PumpEvents();
                }
                window = new Sdl2WindowInfo(handle, null);
                window_id = SDL.GetWindowID(handle);
                windows.Add(window_id, this);
                window_title = title;

                exists = true;
            }
        }

        #region Private Members

        static WindowFlags TranslateFlags(GameWindowFlags flags)
        {
            switch (flags)
            {
                case GameWindowFlags.Fullscreen:
                    return WindowFlags.FULLSCREEN_DESKTOP;
                
                default:
                    return WindowFlags.Default;
            }
        }

        static Key TranslateKey(Scancode scan)
        {
            Key result = Key.Unknown;
            if (map.ContainsKey(scan))
            {
                result = map[scan];
            }
            return result;
        }

        static Key TranslateKey(Keycode key)
        {
            Scancode scan = SDL.GetScancodeFromKey(key);
            return TranslateKey(scan);
        }

        unsafe static int FilterEvents(IntPtr user_data, IntPtr e)
        {
            bool processed = false;

            try
            {
                Sdl2NativeWindow window = null;
                Event ev = *(Event*)e;

                switch (ev.Type)
                {
                    case EventType.WINDOWEVENT:
                        if (windows.TryGetValue(ev.Window.WindowID, out window))
                        {
                            ProcessWindowEvent(window, ev.Window);
                            processed = true;
                        }
                        break;

                    case EventType.TEXTINPUT:
                        if (windows.TryGetValue(ev.Text.WindowID, out window))
                        {
                            ProcessTextInputEvent(window, ev.Text);
                            processed = true;
                        }
                        break;

                    case EventType.KEYDOWN:
                    case EventType.KEYUP:
                        if (windows.TryGetValue(ev.Key.WindowID, out window))
                        {
                            ProcessKeyEvent(window, ev);
                            processed = true;
                        }
                        break;

                    case EventType.MOUSEBUTTONDOWN:
                    case EventType.MOUSEBUTTONUP:
                        if (windows.TryGetValue(ev.Button.WindowID, out window))
                        {
                            ProcessButtonEvent(window, ev);
                            processed = true;
                        }
                        break;

                    case EventType.MOUSEMOTION:
                        if (windows.TryGetValue(ev.Motion.WindowID, out window))
                        {
                            ProcessMotionEvent(window, ev);
                            processed = true;
                        }
                        break;

                    case EventType.MOUSEWHEEL:
                        if (windows.TryGetValue(ev.Wheel.WindowID, out window))
                        {
                            ProcessWheelEvent(window, ev);
                            processed = true;
                        }
                        break;

                    case EventType.QUIT:
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

        static void ProcessButtonEvent(Sdl2NativeWindow window, Event ev)
        {
            bool button_pressed = ev.Button.State == State.Pressed;

            // We need MouseUp events to be reported even if they occur
            // outside the window. SetWindowGrab ensures we get them.
            if (window.CursorVisible)
            {
                SDL.SetWindowGrab(window.window.Handle,
                    button_pressed ? true : false);
            }
        }

        static void ProcessKeyEvent(Sdl2NativeWindow window, Event ev)
        {
            bool key_pressed = ev.Key.State == State.Pressed;
            var key = ev.Key.Keysym;
            var args = new KeyboardKeyEventArgs() 
            { 
                Key = TranslateKey(key.Scancode),
                ScanCode = (uint)key.Scancode
            };
            if (key_pressed)
                window.KeyDown(window, args);
            else
                window.KeyUp(window, args);
            //window.keyboard.SetKey(TranslateKey(key.scancode), (uint)key.scancode, key_pressed);
        }

        static unsafe void ProcessTextInputEvent(Sdl2NativeWindow window, TextInputEvent ev)
        {
            var keyPress = window.KeyPress;
            if (keyPress != null)
            {
                var length = 0;
                byte* pText = ev.Text;
                while (*pText != 0)
                {
                    length++;
                    pText++;
                }
                using (var stream = new System.IO.UnmanagedMemoryStream(ev.Text, length))
                using (var reader = new System.IO.StreamReader(stream, Encoding.UTF8))
                {
                    var text = reader.ReadToEnd();
                    foreach (var c in text)
                    {
                        keyPress(window, new KeyPressEventArgs(c));
                    }
                }
            }
        }

        static void ProcessMotionEvent(Sdl2NativeWindow window, Event ev)
        {
            float scale = window.ClientSize.Width / (float)window.Size.Width;
            //window.mouse.Position = new Point(
            //    (int)(ev.motion.x * scale), (int)(ev.motion.y * scale));
        }

        static void ProcessWheelEvent(Sdl2NativeWindow window, Event ev)
        {
            //window.mouse.Wheel += ev.wheel.y;
        }

        static void ProcessWindowEvent(Sdl2NativeWindow window, WindowEvent e)
        {
            switch (e.Event)
            {
                case WindowEventID.CLOSE:
                    var close_args = new System.ComponentModel.CancelEventArgs();
                    window.Closing(window, close_args);
                    if (!close_args.Cancel)
                    {
                        window.Closed(window, EventArgs.Empty);
                        window.must_destroy = true;
                    }
                    break;

                case WindowEventID.ENTER:
                    window.MouseEnter(window, EventArgs.Empty);
                    break;

                case WindowEventID.LEAVE:
                    window.MouseLeave(window, EventArgs.Empty);
                    break;

                case WindowEventID.EXPOSED:
                    // do nothing
                    break;

                case WindowEventID.FOCUS_GAINED:
                    window.is_focused = true;
                    window.FocusedChanged(window, EventArgs.Empty);
                    break;

                case WindowEventID.FOCUS_LOST:
                    window.is_focused = false;
                    window.FocusedChanged(window, EventArgs.Empty);
                    break;

                case WindowEventID.HIDDEN:
                    window.is_visible = false;
                    window.VisibleChanged(window, EventArgs.Empty);
                    break;

                case WindowEventID.SHOWN:
                    window.is_visible = true;
                    window.VisibleChanged(window, EventArgs.Empty);
                    break;

                case WindowEventID.MAXIMIZED:
                    window.previous_window_state = window.window_state;
                    window.window_state = OpenTK.WindowState.Maximized;
                    window.WindowStateChanged(window, EventArgs.Empty);
                    break;

                case WindowEventID.MINIMIZED:
                    window.previous_window_state = window.window_state;
                    window.window_state = OpenTK.WindowState.Minimized;
                    window.WindowStateChanged(window, EventArgs.Empty);
                    break;

                case WindowEventID.RESTORED:
                    window.window_state = window.previous_window_state;
                    window.WindowStateChanged(window, EventArgs.Empty);
                    break;

                case WindowEventID.MOVED:
                    window.Move(window, EventArgs.Empty);
                    break;

                case WindowEventID.RESIZED:
                case WindowEventID.SIZE_CHANGED:
                    window.Resize(window, EventArgs.Empty);
                    break;

                default:
                    Debug.Print("SDL2 unhandled event: {0}", e.Type);
                    break;
            }
        }

        void DestroyWindow()
        {
            exists = false;

            if (window.Handle != IntPtr.Zero)
            {
                CursorVisible = true;
                lock (SDL.Sync)
                {
                    SDL.DelEventWatch(EventFilterDelegate, window.Handle);
                    if (windows.ContainsKey(window_id))
                    {
                        windows.Remove(window_id);
                    }
                    SDL.DestroyWindow(window.Handle);
                }
            }

            window_id = 0;
            window.Handle = IntPtr.Zero;
        }

        void GrabCursor(bool grab)
        {
            SDL.ShowCursor(!grab);
            SDL.SetWindowGrab(window.Handle, grab);
            SDL.SetRelativeMouseMode(grab);
        }

        // Hack to force WindowState events to be pumped
        void HideShowWindowHack()
        {
            SDL.HideWindow(window.Handle);
            ProcessEvents();
            SDL.ShowWindow(window.Handle);
            ProcessEvents();
        }

        // Revert to WindowState.Normal if necessary
        void RestoreWindow()
        {
            WindowState state = WindowState;

            switch (state)
            {
                case WindowState.Fullscreen:
                    SDL.SetWindowFullscreen(window.Handle, 0);
                    break;

                case WindowState.Maximized:
                    SDL.RestoreWindow(window.Handle);
                    HideShowWindowHack();
                    break;

                case WindowState.Minimized:
                    SDL.RestoreWindow(window.Handle);
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
                if (Exists && !must_destroy)
                {
                    Debug.Print("SDL2 closing window {0}", window.Handle);

                    Event e = new Event();
                    e.Type = EventType.WINDOWEVENT;
                    e.Window.Event = WindowEventID.CLOSE;
                    e.Window.WindowID = window_id;
                    lock (SDL.Sync)
                    {
                        SDL.PushEvent(ref e);
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
                    SDL.PumpEvents();
                    if (must_destroy)
                    {
                        DestroyWindow();
                    }
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

                                IntPtr surface = SDL.CreateRGBSurfaceFrom(
                                    data.Scan0, data.Width, data.Height, 32, data.Stride,
                                    0x00ff0000u, 0x0000ff00u, 0x000000ffu, 0xff000000u);

                                // Update the window icon
                                SDL.SetWindowIcon(window.Handle, surface);

                                // Free the SDL surface as it is no longer needed
                                SDL.FreeSurface(surface);
                                bmp.UnlockBits(data);
                            }

                        }
                        else
                        {
                            // Clear the window icon
                            SDL.SetWindowIcon(window.Handle, IntPtr.Zero);
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
                        return SDL.GetWindowTitle(window.Handle);
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
                        SDL.SetWindowTitle(window.Handle, value);
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
                            SDL.ShowWindow(window.Handle);
                        else
                            SDL.HideWindow(window.Handle);
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
                                    if (SDL.SetWindowFullscreen(window.Handle, (uint)WindowFlags.FULLSCREEN_DESKTOP) < 0)
                                    {
                                        if (SDL.SetWindowFullscreen(window.Handle, (uint)WindowFlags.FULLSCREEN) < 0)
                                        {
                                            Debug.Print("SDL2 failed to enter fullscreen mode: {0}", SDL.GetError());
                                        }
                                    }
                                    SDL.RaiseWindow(window.Handle);
                                    // There is no "fullscreen" message in the event loop
                                    // so we have to mark that ourselves
                                    window_state = WindowState.Fullscreen;
                                    break;

                                case WindowState.Maximized:
                                    RestoreWindow();
                                    SDL.MaximizeWindow(window.Handle);
                                    HideShowWindowHack();
                                    break;

                                case WindowState.Minimized:
                                    SDL.MinimizeWindow(window.Handle);
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
                                    SDL.SetWindowBordered(window.Handle, true);
                                    window_border = WindowBorder.Resizable;
                                    break;

                                case WindowBorder.Hidden:
                                    SDL.SetWindowBordered(window.Handle, false);
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
                        SDL.GetWindowPosition(window.Handle, out x, out y);
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
                        SDL.SetWindowPosition(window.Handle, value.X, value.Y);
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
                        SDL.GetWindowSize(window.Handle, out w, out h);
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
                        SDL.SetWindowSize(window.Handle, value.Width, value.Height);
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
                return ClientSize.Width;
            }
            set
            {
                ClientSize = new Size(value, Height);
            }
        }

        public int Height
        {
            get
            {
                return ClientSize.Height;
            }
            set
            {
                ClientSize = new Size(Width, value);
            }
        }

        public Rectangle ClientRectangle
        {
            get
            {
                return new Rectangle(new Point(), ClientSize);
            }
            set
            {
                ClientSize = value.Size;
            }
        }

        public Size ClientSize
        {
            get
            {
                int w, h;
                if (SDL.Version.Number > 2000)
                {
                    // SDL > 2.0.0 supports SDL_GL_GetDrawableSize for
                    // hidpi windows.
                    SDL.GL.GetDrawableSize(window.Handle, out w, out h);
                }
                else
                {
                    SDL.GetWindowSize(window.Handle, out w, out h);
                }
                return new Size(w, h);
            }
            set
            {
                float scale = Size.Width / (float)ClientSize.Width;
                Size = new Size((int)(value.Width * scale), (int)(value.Height * scale));
            }
        }

        public IInputDriver InputDriver
        {
            get
            {
                return input_driver;
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
            InputDriver.Poll();
        }

        #endregion

        #region IJoystickDriver Members

        public IList<JoystickDevice> Joysticks
        {
            get
            {
                return InputDriver.Joysticks;
            }
        }

        #endregion

        #region IMouseDriver Members

        public IList<MouseDevice> Mouse
        {
            get
            {
                return InputDriver.Mouse;
            }
        }

        #endregion

        #region IKeyboardDriver Members

        public IList<KeyboardDevice> Keyboard
        {
            get
            {
                return InputDriver.Keyboard;
            }
        }

        #endregion

        #region IDisposable implementation

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                lock (sync)
                {
                    if (manual)
                    {
                        Debug.Print("Disposing {0}", GetType());
                        InputDriver.Dispose();
                        if (Exists)
                        {
                            DestroyWindow();
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Sdl2NativeWindow leaked, did you forget to call Dispose()?");
                        if (Exists)
                        {
                            // If the main loop is still running, send a close message.
                            // This will raise the Closing/Closed events and then destroy
                            // the window.
                            // Todo: it is probably not safe to raise events once the
                            // finalizer has run. Review this.
                            Close();
                        }
                    }
                    disposed = true;
                }
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

