//
// GameWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.ComponentModel;
using System.Drawing;
using OpenToolkit.Windowing.EventingModels;
using OpenToolkit.Windowing.GraphicsLibraryFramework;
using OpenToolkit.Windowing.Input;
using OpenToolkit.Windowing.Interfaces;

namespace OpenToolkit.Windowing
{
    public class NativeWindow : INativeWindow
    {
        private static GLFW glfw => GLFWProvider.GLFW;
        private readonly unsafe Window* windowPtr = null;

        private string _title;

        public string Title
        {
            get => _title;
            set
            {
                unsafe
                {
                    _title = value;
                    glfw.SetWindowTitle(windowPtr, value);
                }
            }
        }

        public unsafe bool Focused
        {
            get => glfw.GetWindowAttrib(windowPtr, (int)WindowHint.Focused) != 0;
            set
            {
                if (value)
                {
                    glfw.FocusWindow(windowPtr);
                }
            }
        }

        public bool Visible
        {
            get
            {
                unsafe { return glfw.GetWindowAttrib(windowPtr, (int)WindowHint.Visible) != 0; }
            }
            set
            {
                if (value)
                {
                    unsafe { glfw.ShowWindow(windowPtr); }
                }
                else
                {
                    unsafe { glfw.HideWindow(windowPtr); }
                }
            }
        }

        // TODO: Probably not a complete check, this isn't a strong enough guarantee that the window is initialized, has been created and not destroyed (or being destroyed)
        public bool Exists
        {
            get { unsafe { return windowPtr != null; } }
        }

        public IWindowInfo WindowInfo => throw new NotImplementedException("IWindowInfo is obsolete because platforms are going away, though we could create better borders around GLFW and define 'GLFWWindowInfo : IWindowInfo' but I think it's a case of YAGNI");

        public WindowState WindowState
        {
            get
            {
                unsafe
                {
                    if (glfw.GetWindowAttrib(windowPtr, (int)WindowHint.Iconified) == 1)
                    {
                        return WindowState.Minimized;
                    }
                    else if (glfw.GetWindowMonitor(windowPtr) != null)
                    {
                        return WindowState.Fullscreen;
                    }
                    else
                    {
                        var monitor = glfw.GetPrimaryMonitor();
                        var mode = glfw.GetVideoMode(monitor);

                        int windowWidth, windowHeight;
                        glfw.GetWindowSize(windowPtr, out windowWidth, out windowHeight);

                        if (mode->width == windowWidth && mode->height == windowHeight)
                        {
                            return WindowState.Maximized;
                        }
                    }
                    return WindowState.Normal;
                }
            }
            set
            {
                switch (value)
                {
                    case WindowState.Normal:
                        unsafe { glfw.RestoreWindow(windowPtr); }
                        break;
                    case WindowState.Minimized:
                        unsafe { glfw.IconifyWindow(windowPtr); }
                        break;
                    case WindowState.Maximized:
                        unsafe { glfw.MaximizeWindow(windowPtr); }
                        break;
                    case WindowState.Fullscreen:
                        unsafe
                        {
                            var monitor = glfw.GetPrimaryMonitor();
                            var mode = glfw.GetVideoMode(monitor);
                            glfw.SetWindowMonitor(windowPtr, monitor, 0, 0, mode->width, mode->height, mode->refreshRate);
                        }
                        break;
                }
            }
        }

        public WindowBorder WindowBorder
        {
            get
            {
                unsafe
                {
                    if (glfw.GetWindowAttrib(windowPtr, (int)WindowHint.Decorated) == 0)
                    {
                        return WindowBorder.Hidden;
                    }
                    else if (glfw.GetWindowAttrib(windowPtr, (int)WindowHint.Resizable) == 0)
                    {
                        return WindowBorder.Fixed;
                    }

                    return WindowBorder.Resizable;
                }
            }
            set
            {
                throw new NotImplementedException("Requires recreating the window with different window hints https://www.glfw.org/docs/latest/window_guide.html#window_attribs");
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
                unsafe
                {
                    glfw.SetWindowSize(windowPtr, value.Width, value.Height);
                    glfw.SetWindowPos(windowPtr, value.X, value.Y);
                }
            }
        }
        public Point Location
        {
            get
            {
                int x, y;
                unsafe { glfw.GetWindowPos(windowPtr, out x, out y); }
                return new Point(x, y);
            }
            set { unsafe { glfw.SetWindowPos(windowPtr, value.X, value.Y); } }
        }
        public Size Size
        {
            get
            {
                int width, height;
                unsafe { glfw.GetWindowSize(windowPtr, out width, out height); }
                return new Size(width, height);
            }
            set { unsafe { glfw.SetWindowSize(windowPtr, value.Width, value.Height); } }
        }
        public int X
        {
            get { return Location.X; }
            set { Location = new Point(value, Location.Y); }
        }
        public int Y
        {
            get { return Location.Y; }
            set { Location = new Point(Location.X, value); }
        }
        public int Width
        {
            get { return Size.Width; }
            set { Size = new Size(value, Size.Height); }
        }
        public int Height
        {
            get { return Size.Height; }
            set { Size = new Size(Size.Width, value); }
        }
        public Rectangle ClientRectangle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Size ClientSize
        {
            get
            {
                int width, height;
                unsafe { glfw.GetFramebufferSize(windowPtr, out width, out height); }
                return new Size(width, height);
            }
            set => throw new NotImplementedException();
        }

        public MouseCursor Cursor
        {
            get
            {
                throw new NotImplementedException();

            }
            set => throw new NotImplementedException();
        }

        private bool _cursorHidden;
        public bool CursorVisible
        {
            get
            {
                unsafe
                {
                    return glfw.GetInputMode(windowPtr, InputMode.Cursor) == InputModeValue.CursorHidden
                           || glfw.GetInputMode(windowPtr, InputMode.Cursor) ==
                           InputModeValue.CursorDisabled;
                }
            }
            set
            {
                _cursorHidden = value;
                unsafe
                {
                    if (value)
                    {
                        glfw.SetInputMode(windowPtr, InputMode.Cursor, InputModeValue.CursorHidden);
                    }
                    else
                    {
                        glfw.SetInputMode(windowPtr, InputMode.Cursor, InputModeValue.CursorNormal);
                    }
                }
            }
        }

        public bool CursorGrabbed
        {
            get { unsafe { return glfw.GetInputMode(windowPtr, InputMode.Cursor) == InputModeValue.CursorDisabled; } }
            set
            {
                unsafe
                {
                    if (value)
                    {
                        glfw.SetInputMode(windowPtr, InputMode.Cursor, InputModeValue.CursorDisabled);
                    }
                    else if (_cursorHidden)
                    {
                        glfw.SetInputMode(windowPtr, InputMode.Cursor, InputModeValue.CursorHidden);
                    }
                    else
                    {
                        glfw.SetInputMode(windowPtr, InputMode.Cursor, InputModeValue.CursorNormal);
                    }
                }
            }
        }


        public NativeWindow(int width = 640, int height = 480, string title = "", bool windowedFullscreen = false)
        {
            _title = title;

            unsafe
            {
                var monitor = glfw.GetPrimaryMonitor();
                if (windowedFullscreen)
                {
                    var modePtr = glfw.GetVideoMode(monitor);
                    glfw.WindowHint(WindowHint.RedBits, modePtr->redBits);
                    glfw.WindowHint(WindowHint.GreenBits, modePtr->greenBits);
                    glfw.WindowHint(WindowHint.BlueBits, modePtr->blueBits);
                    glfw.WindowHint(WindowHint.RefreshRate, modePtr->refreshRate);
                    windowPtr = glfw.CreateWindow(modePtr->width, modePtr->height, title, monitor, null);
                }
                else
                {
                    windowPtr = glfw.CreateWindow(width, height, title, null, null);
                }
            }
        }

        public Point PointToClient(Point point)
        {
            throw new NotImplementedException();
        }

        public Point PointToScreen(Point point)
        {
            throw new NotImplementedException();
        }

        #region Events
        public event EventHandler<EventArgs> Move;
        public event EventHandler<EventArgs> Resize;
        public event EventHandler<CancelEventArgs> Closing;
        public event EventHandler<EventArgs> Closed;
        public event EventHandler<EventArgs> Disposed;
        public event EventHandler<EventArgs> IconChanged;
        public event EventHandler<EventArgs> TitleChanged;
        public event EventHandler<EventArgs> VisibleChanged;
        public event EventHandler<EventArgs> FocusedChanged;
        public event EventHandler<EventArgs> WindowBorderChanged;
        public event EventHandler<EventArgs> WindowStateChanged;
        public event EventHandler<KeyboardKeyEventArgs> KeyDown;
        public event EventHandler<KeyPressEventArgs> KeyPress;
        public event EventHandler<KeyboardKeyEventArgs> KeyUp;
        public event EventHandler<EventArgs> MouseLeave;
        public event EventHandler<EventArgs> MouseEnter;
        public event EventHandler<MouseButtonEventArgs> MouseDown;
        public event EventHandler<MouseButtonEventArgs> MouseUp;
        public event EventHandler<MouseMoveEventArgs> MouseMove;
        public event EventHandler<MouseWheelEventArgs> MouseWheel;
        public event EventHandler<FileDropEventArgs> FileDrop;
        public event EventHandler<EventArgs> Load;
        public event EventHandler<EventArgs> Unload;
        public event EventHandler<FrameEventArgs> UpdateFrame;
        public event EventHandler<FrameEventArgs> RenderFrame;
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Free managed resources
                }

                // Free unmanaged resources
                unsafe
                {
                    if (windowPtr != null)
                    {
                        glfw.DestroyWindow(windowPtr);
                    }
                }
                glfw.Terminate();

                disposedValue = true;
            }
        }

        ~NativeWindow()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
