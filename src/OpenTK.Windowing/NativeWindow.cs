//
// NativeWindow.cs
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

                TitleChanged?.Invoke(this, EventArgs.Empty);
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
                VisibleChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool Exists
        {
            get { unsafe { return windowPtr != null && !glfw.WindowShouldClose(windowPtr); } }
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
                }
                return WindowState.Normal;
            }
            set
            {
                unsafe
                {
                    switch (value)
                    {
                        case WindowState.Normal:
                            glfw.RestoreWindow(windowPtr);
                            break;
                        case WindowState.Minimized:
                            glfw.IconifyWindow(windowPtr);
                            break;
                        case WindowState.Maximized:
                            glfw.MaximizeWindow(windowPtr);
                            break;
                        case WindowState.Fullscreen:
                            var monitor = glfw.GetPrimaryMonitor();
                            var mode = glfw.GetVideoMode(monitor);
                            glfw.SetWindowMonitor(windowPtr, monitor, 0, 0, mode->width, mode->height, mode->refreshRate);
                            break;
                    }
                }

                WindowStateChanged?.Invoke(this, EventArgs.Empty);
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
            
            //If GLFW 3.3 is supported by the time OpenTK 4.0 is ready, this will be implemented,
            //but we want to avoid making features that depend on development versions of libraries.
            set => throw new NotImplementedException("Cannot be implemented in GLFW 3.2.");
        }

        public Rectangle Bounds
        {
            get => new Rectangle(Location, Size);
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
            get => Location.X;
            set => Location = new Point(value, Location.Y);
        }

        public int Y
        {
            get => Location.Y;
            set => Location = new Point(Location.X, value);
        }

        public int Width
        {
            get => Size.Width;
            set => Size = new Size(value, Size.Height);
        }

        public int Height
        {
            get => Size.Height;
            set => Size = new Size(Size.Width, value);
        }

        public Rectangle ClientRectangle
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

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
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        private bool _cursorHidden;
        public bool CursorVisible
        {
            get
            {
                unsafe
                {
                    return glfw.GetInputMode(windowPtr, InputMode.Cursor) != InputModeValue.CursorHidden
                           && glfw.GetInputMode(windowPtr, InputMode.Cursor) != InputModeValue.CursorDisabled;
                }
            }
            set
            {
                _cursorHidden = !value;
                unsafe
                {
                    if (value)
                    {
                        glfw.SetInputMode(windowPtr, InputMode.Cursor, InputModeValue.CursorNormal);
                    }
                    else
                    {
                        glfw.SetInputMode(windowPtr, InputMode.Cursor, InputModeValue.CursorHidden);
                    }
                }
            }
        }

        public unsafe bool CursorGrabbed
        {
            get => glfw.GetInputMode(windowPtr, InputMode.Cursor) == InputModeValue.CursorDisabled;
            set
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

                RegisterWindowCallbacks();
            }
        }

        private void RegisterWindowCallbacks()
        {
            unsafe
            {
                glfw.SetWindowPosCallback(windowPtr, (window, x, y) => Move?.Invoke(this, EventArgs.Empty));
                glfw.SetWindowSizeCallback(windowPtr, (width, height) => Resize?.Invoke(this, EventArgs.Empty));
                glfw.SetWindowCloseCallback(windowPtr, (window) => Closing?.Invoke(this, new CancelEventArgs()));
                glfw.SetWindowIconifyCallback(windowPtr, (window, iconified) => IconChanged?.Invoke(this, EventArgs.Empty));
                glfw.SetWindowFocusCallback(windowPtr, (window, focused) => FocusedChanged?.Invoke(this, EventArgs.Empty));
                glfw.SetCharCallback(windowPtr, (window, codepoint) => KeyPress?.Invoke(this, new KeyPressEventArgs((char)codepoint)));
                glfw.SetKeyCallback(windowPtr, (window, key, scancode, action, mods) =>
                {
                    if (action == InputAction.Press)
                    {
                        KeyDown?.Invoke(this, new KeyboardKeyEventArgs());
                    }
                    else if (action == InputAction.Release)
                    {
                        KeyUp?.Invoke(this, new KeyboardKeyEventArgs());
                    }
                });
                glfw.SetCursorEnterCallback(windowPtr, (window, entered) =>
                {
                    if (entered)
                    {
                        MouseEnter?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MouseLeave?.Invoke(this, EventArgs.Empty);
                    }
                });
                glfw.SetMouseButtonCallback(windowPtr, (window, button, action, mods) =>
                {
                    if (action == InputAction.Press)
                    {
                        MouseDown?.Invoke(this, new MouseButtonEventArgs());
                    }
                    else if (action == InputAction.Release)
                    {
                        MouseUp?.Invoke(this, new MouseButtonEventArgs());
                    }

                });
                glfw.SetCursorPosCallback(windowPtr, (window, xpos, ypos) => MouseMove?.Invoke(this, new MouseMoveEventArgs()));
                glfw.SetScrollCallback(windowPtr, (window, xOffset, yOffset) => MouseWheel?.Invoke(this, new MouseWheelEventArgs()));
                glfw.SetDropCallback(windowPtr, (window, count, paths) => FileDrop?.Invoke(this, new FileDropEventArgs()));

                //TODO: Events from GLFW the 'legacy' NativeWindow didnt have events for.
                glfw.SetCharModsCallback(windowPtr, (window, codepoint, mods) => throw new NotImplementedException());
                glfw.SetJoystickCallback((joy, eventCode) => throw new NotImplementedException());
                glfw.SetMonitorCallback((monitor, eventCode) => throw new NotImplementedException());
            }
        }

        public virtual void Close()
        {
            unsafe
            {
                glfw.SetWindowShouldClose(windowPtr);
                Closed?.Invoke(this, EventArgs.Empty);
            }
        }

        public void MakeCurrent()
        {
            unsafe
            {
                glfw.MakeContextCurrent(windowPtr);
            }
        }

        //TODO: This doesnt account for the scenario of an event-based application in which we would use `glfw.WaitEvents()` that waits for input to keep CPU usage minimal
        public virtual void ProcessEvents()
        {
            glfw.PollEvents();
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
                        Closed?.Invoke(this, EventArgs.Empty);
                    }
                }

                disposedValue = true;
                Disposed?.Invoke(this, EventArgs.Empty);
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
