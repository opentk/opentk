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

using System;
using System.Collections.Generic;
using System.Diagnostics;
#if !MINIMAL
using System.Drawing;
#endif
#if ANDROID || IPHONE || MINIMAL
using OpenTK.Minimal;
#else
using System.Drawing.Imaging;
#endif
using System.Runtime.InteropServices;
using OpenTK.Input;
using System.Text;

namespace OpenTK.Platform.SDL2
{
    internal class Sdl2NativeWindow : NativeWindowBase
    {
        private readonly object sync = new object();

        private Sdl2WindowInfo window;
        private uint window_id;
        private bool is_visible;
        private bool is_focused;
        private bool is_cursor_grabbed = false;
        private bool is_cursor_visible = true;
        private bool exists;
        private bool must_destroy;
        private bool disposed;
        private volatile bool is_in_closing_event;
        private WindowState window_state = WindowState.Normal;
        private WindowState previous_window_state = WindowState.Normal;
        private WindowBorder window_border = WindowBorder.Resizable;
        private Icon icon;
        private MouseCursor cursor = MouseCursor.Default;
        private IntPtr sdl_cursor = IntPtr.Zero;

        // Used in KeyPress event to decode SDL UTF8 text strings
        // to .Net UTF16 strings
        private char[] DecodeTextBuffer = new char[32];

        private static readonly Dictionary<uint, Sdl2NativeWindow> windows =
            new Dictionary<uint, Sdl2NativeWindow>();

        public Sdl2NativeWindow(int x, int y, int width, int height,
            string title, GameWindowFlags options, DisplayDevice device)
        {
            lock (sync)
            {
                SDL.DisableScreenSaver();

                var bounds = device.Bounds;
                var flags = TranslateFlags(options);
                flags |= WindowFlags.OPENGL;
                flags |= WindowFlags.HIDDEN;
                if (Toolkit.Options.EnableHighResolution)
                {
                    flags |= WindowFlags.ALLOW_HIGHDPI;
                }

                if ((flags & WindowFlags.FULLSCREEN_DESKTOP) != 0 ||
                    (flags & WindowFlags.FULLSCREEN) != 0)
                {
                    window_state = WindowState.Fullscreen;
                }

                if ((flags & WindowFlags.RESIZABLE) == 0)
                {
                    window_border = WindowBorder.Fixed;
                }

                IntPtr handle;
                lock (SDL.Sync)
                {
                    handle = SDL.CreateWindow(title, bounds.Left + x, bounds.Top + y, width, height, flags);
                    exists = true;
                }
                ProcessEvents();
                window = new Sdl2WindowInfo(handle, null);
                window_id = SDL.GetWindowID(handle);
                windows.Add(window_id, this);
            }
        }

        private static WindowFlags TranslateFlags(GameWindowFlags flags)
        {
            WindowFlags windowFlags = WindowFlags.Default;

            if ((flags & GameWindowFlags.Fullscreen) != 0)
            {
                if (Sdl2Factory.UseFullscreenDesktop)
                {
                    windowFlags |= WindowFlags.FULLSCREEN_DESKTOP;
                }
                else
                {
                    windowFlags |= WindowFlags.FULLSCREEN;
                }
            }

            if ((flags & GameWindowFlags.FixedWindow) == 0)
            {
                windowFlags |= WindowFlags.RESIZABLE;
            }

            return windowFlags;
        }

        private static Key TranslateKey(Scancode scan)
        {
            return Sdl2KeyMap.GetKey(scan);
        }

        private static Key TranslateKey(Keycode key)
        {
            Scancode scan = SDL.GetScancodeFromKey(key);
            return TranslateKey(scan);
        }

        private int ProcessEvent(ref Event ev)
        {
            bool processed = false;


            Sdl2NativeWindow window = null;

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
                        ProcessMouseButtonEvent(window, ev.Button);
                        processed = true;
                    }
                    break;

                case EventType.MOUSEMOTION:
                    if (windows.TryGetValue(ev.Motion.WindowID, out window))
                    {
                        ProcessMouseMotionEvent(window, ev.Motion);
                        processed = true;
                    }
                    break;

                case EventType.MOUSEWHEEL:
                    if (windows.TryGetValue(ev.Wheel.WindowID, out window))
                    {
                        ProcessMouseWheelEvent(window, ev.Wheel);
                        processed = true;
                    }
                    break;

                case EventType.DROPFILE:
                    if (windows.TryGetValue(ev.Drop.WindowID, out window))
                    {
                        ProcessDropEvent(window, ev.Drop);
                        SDL.Free(ev.Drop.File);
                        processed = true;
                    }
                    break;

                case EventType.QUIT:
                    Debug.WriteLine("Sdl2 application quit");
                    break;
            }

            return processed ? 0 : 1;
        }

        private static void ProcessMouseButtonEvent(Sdl2NativeWindow window, MouseButtonEvent ev)
        {
            bool button_pressed = ev.State == State.Pressed;

            // We need MouseUp events to be reported even if they occur
            // outside the window. SetWindowGrab ensures we get them.
            if (!window.is_cursor_grabbed)
            {
                SDL.SetWindowGrab(window.window.Handle,
                    button_pressed ? true : false);
            }

            MouseButton button = Sdl2Mouse.TranslateButton(ev.Button);
            if (button_pressed)
            {
                window.OnMouseDown(button);
            }
            else
            {
                window.OnMouseUp(button);
            }
        }

        private static void ProcessKeyEvent(Sdl2NativeWindow window, Event ev)
        {
            bool key_pressed = ev.Key.State == State.Pressed;
            Key key = TranslateKey(ev.Key.Keysym.Scancode);
            if (key_pressed)
            {
                window.OnKeyDown(key, ev.Key.Repeat > 0);
            }
            else
            {
                window.OnKeyUp(key);
            }
        }

        private static unsafe void ProcessTextInputEvent(Sdl2NativeWindow window, TextInputEvent ev)
        {
            // Calculate the length of the typed text string
            int length;
            for (length = 0; length < TextInputEvent.TextSize && ev.Text[length] != '\0'; length++)
            {
                ;
            }

            // Make sure we have enough space to decode this string
            int decoded_length = Encoding.UTF8.GetCharCount(ev.Text, length);
            if (window.DecodeTextBuffer.Length < decoded_length)
            {
                Array.Resize(
                    ref window.DecodeTextBuffer,
                    2 * Math.Max(decoded_length, window.DecodeTextBuffer.Length));
            }

            // Decode the string from UTF8 to .Net UTF16
            fixed (char* pBuffer = window.DecodeTextBuffer)
            {
                decoded_length = System.Text.Encoding.UTF8.GetChars(
                    ev.Text,
                    length,
                    pBuffer,
                    window.DecodeTextBuffer.Length);
            }

            for (int i = 0; i < decoded_length; i++)
            {
                window.OnKeyPress(window.DecodeTextBuffer[i]);
            }
        }

        private static void ProcessMouseMotionEvent(Sdl2NativeWindow window, MouseMotionEvent ev)
        {
            float scale = window.ClientSize.Width / (float)window.Size.Width;
            window.OnMouseMove(
                (int)Math.Round(ev.X * scale),
                (int)Math.Round(ev.Y * scale));
            Sdl2Mouse.Scale = scale;
        }

        private static void ProcessMouseWheelEvent(Sdl2NativeWindow window, MouseWheelEvent ev)
        {
            window.OnMouseWheel(ev.X, ev.Y);
        }

        private static unsafe void ProcessDropEvent(Sdl2NativeWindow window, DropEvent ev)
        {
            string dropString = Marshal.PtrToStringAuto(ev.File);
            window.OnFileDrop(dropString);
        }

        private static void ProcessWindowEvent(Sdl2NativeWindow window, WindowEvent e)
        {
            switch (e.Event)
            {
                case WindowEventID.CLOSE:
                    var close_args = new System.ComponentModel.CancelEventArgs();
                    try
                    {
                        window.is_in_closing_event = true;
                        window.OnClosing(close_args);
                    }
                    finally
                    {
                        window.is_in_closing_event = false;
                    }

                    if (!close_args.Cancel)
                    {
                        window.OnClosed(EventArgs.Empty);
                        window.must_destroy = true;
                    }
                    break;

                case WindowEventID.ENTER:
                    window.OnMouseEnter(EventArgs.Empty);
                    break;

                case WindowEventID.LEAVE:
                    window.OnMouseLeave(EventArgs.Empty);
                    break;

                case WindowEventID.EXPOSED:
                    // do nothing
                    break;

                case WindowEventID.FOCUS_GAINED:
                    window.is_focused = true;
                    window.OnFocusedChanged(EventArgs.Empty);
                    break;

                case WindowEventID.FOCUS_LOST:
                    window.is_focused = false;
                    window.OnFocusedChanged(EventArgs.Empty);
                    break;

                case WindowEventID.HIDDEN:
                    window.is_visible = false;
                    window.OnVisibleChanged(EventArgs.Empty);
                    break;

                case WindowEventID.SHOWN:
                    window.is_visible = true;
                    window.OnVisibleChanged(EventArgs.Empty);
                    break;

                case WindowEventID.MAXIMIZED:
                    window.window_state = WindowState.Maximized;
                    window.OnWindowStateChanged(EventArgs.Empty);
                    break;

                case WindowEventID.MINIMIZED:
                    window.previous_window_state = window.window_state;
                    window.window_state = WindowState.Minimized;
                    window.OnWindowStateChanged(EventArgs.Empty);
                    break;

                case WindowEventID.RESTORED:
                    window.window_state = window.previous_window_state;
                    window.OnWindowStateChanged(EventArgs.Empty);
                    break;

                case WindowEventID.MOVED:
                    window.OnMove(EventArgs.Empty);
                    break;

                case WindowEventID.RESIZED:
                case WindowEventID.SIZE_CHANGED:
                    window.OnResize(EventArgs.Empty);
                    break;

                default:
                    Debug.Print("SDL2 unhandled event: {0}", e.Type);
                    break;
            }
        }

        private void DestroyWindow()
        {
            exists = false;

            if (window.Handle != IntPtr.Zero)
            {
                CursorVisible = true;
                lock (SDL.Sync)
                {
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

        private void SetCursorGrab(bool shouldGrab)
        {
            SDL.SetWindowGrab(window.Handle, shouldGrab);
        }

        private void SetCursorVisible(bool shouldVisible)
        {
            SDL.ShowCursor(shouldVisible);
        }

        // Hack to force WindowState events to be pumped
        private void HideShowWindowHack()
        {
            SDL.HideWindow(window.Handle);
            ProcessEvents();
            SDL.ShowWindow(window.Handle);
            ProcessEvents();
        }

        // Revert to WindowState.Normal if necessary
        private void RestoreWindow()
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

        public override MouseCursor Cursor
        {
            get
            {
                return cursor;
            }
            set
            {
                lock (sync)
                {
                    if (cursor != value)
                    {
                        // Free the previous cursor,
                        // if one has been set.
                        if (sdl_cursor != IntPtr.Zero)
                        {
                            SDL.FreeCursor(sdl_cursor);
                            sdl_cursor = IntPtr.Zero;
                        }

                        // Set the new cursor
                        if (value == MouseCursor.Default)
                        {
                            // Reset to default cursor
                            SDL.SetCursor(SDL.GetDefaultCursor());
                            cursor = value;
                        }
                        else
                        {
                            // Create and set a new cursor using
                            // the rgba values supplied by the user
                            unsafe
                            {
                                fixed (byte* pixels = value.Data)
                                {
                                    IntPtr cursor_surface =
                                        SDL.CreateRGBSurfaceFrom(
                                            new IntPtr(pixels),
                                            value.Width,
                                            value.Height,
                                            32,
                                            value.Width * 4,
                                            0x00ff0000,
                                            0x0000ff00,
                                            0x000000ff,
                                            0xff000000);

                                    if (cursor_surface == IntPtr.Zero)
                                    {
                                        Debug.Print("[SDL2] Failed to create cursor surface. Error: {0}",
                                            SDL.GetError());
                                        return;
                                    }

                                    sdl_cursor = SDL.CreateColorCursor(cursor_surface, value.X, value.Y);
                                    if (sdl_cursor == IntPtr.Zero)
                                    {
                                        Debug.Print("[SDL2] Failed to create cursor. Error: {0}",
                                            SDL.GetError());
                                        return;
                                    }

                                    if (sdl_cursor != IntPtr.Zero)
                                    {
                                        SDL.SetCursor(sdl_cursor);
                                        cursor = value;
                                    }

                                    if (cursor_surface != IntPtr.Zero)
                                    {
                                        SDL.FreeSurface(cursor_surface);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public override void Close()
        {
            lock (sync)
            {
                if (Exists && !must_destroy && !is_in_closing_event)
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

        public override void ProcessEvents()
        {
            base.ProcessEvents();
            lock (sync)
            {
                if (Exists)
                {
                    SDL.PumpEvents();
                    Event e;
                    while (SDL.PollEvent(out e) > 0)
                    {
                        ProcessEvent(ref e);
                    }

                    if (must_destroy)
                    {
                        DestroyWindow();
                    }
                }
            }
        }

        public override Point PointToClient(Point point)
        {
            var client = Location;
            return new Point(point.X - client.X, point.Y - client.Y);
        }

        public override Point PointToScreen(Point point)
        {
            var client = Location;
            return new Point(point.X + client.X, point.Y + client.Y);
        }

        public override Icon Icon
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
                        OnIconChanged(EventArgs.Empty);
                    }
                }
            }
        }

        public override string Title
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
                    }
                }
            }
        }

        public override bool Focused
        {
            get
            {
                return is_focused;
            }
        }

        public override bool Visible
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
                        {
                            SDL.ShowWindow(window.Handle);
                        }
                        else
                        {
                            SDL.HideWindow(window.Handle);
                        }
                    }
                }
            }
        }

        public override bool Exists
        {
            get
            {
                return exists;
            }
        }

        public override IWindowInfo WindowInfo
        {
            get
            {
                return window;
            }
        }

        public override WindowState WindowState
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
                                    bool success = Sdl2Factory.UseFullscreenDesktop ?
                                        SDL.SetWindowFullscreen(window.Handle, (uint)WindowFlags.FULLSCREEN_DESKTOP) < 0 :
                                        SDL.SetWindowFullscreen(window.Handle, (uint)WindowFlags.FULLSCREEN) < 0;

                                    if (!success)
                                    {
                                            Debug.Print("SDL2 failed to enter fullscreen mode: {0}", SDL.GetError());
                                    }

                                    SDL.RaiseWindow(window.Handle);
                                    // There is no "fullscreen" message in the event loop
                                    // so we have to mark that ourselves
                                    window_state = WindowState.Fullscreen;
                                    break;

                                case WindowState.Maximized:
                                    RestoreWindow();
                                    SDL.MaximizeWindow(window.Handle);
                                    window_state = WindowState.Maximized;
                                    break;

                                case WindowState.Minimized:
                                    SDL.MinimizeWindow(window.Handle);
                                    window_state = WindowState.Minimized;
                                    break;

                                case WindowState.Normal:
                                    RestoreWindow();
                                    break;
                            }

                            if (!CursorVisible)
                            {
                                SetCursorGrab(true);
                            }
                        }
                    }
                }
            }
        }

        public override WindowBorder WindowBorder
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
                        OnWindowBorderChanged(EventArgs.Empty);
                    }
                }
            }
        }

        public override Rectangle Bounds
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

        public override Point Location
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

        public override Size Size
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

        public override Size ClientSize
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

        public override bool CursorGrabbed
        {
            get
            {
                return is_cursor_grabbed;
            }
            set
            {
                lock (sync)
                {
                    if (!Exists || value == is_cursor_grabbed)
                    {
                        return;
                    }
                    SetCursorGrab(value);
                    is_cursor_grabbed = value;
                }
            }
        }

        public override bool CursorVisible
        {
            get
            {
                return is_cursor_visible;
            }
            set
            {
                lock (sync)
                {
                    if (!Exists || value == is_cursor_visible)
                    {
                        return;
                    }
                    SetCursorVisible(value);
                    is_cursor_visible = value;
                }
            }
        }

        protected override void Dispose(bool manual)
        {
            if (!disposed)
            {
                lock (sync)
                {
                    if (manual)
                    {
                        Debug.Print("Disposing {0}", GetType());

                        if (Exists)
                        {
                            DestroyWindow();
                        }

                        if (sdl_cursor != IntPtr.Zero)
                        {
                            SDL.FreeCursor(sdl_cursor);
                            sdl_cursor = IntPtr.Zero;
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
    }
}

