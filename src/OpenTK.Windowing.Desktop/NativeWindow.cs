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
using OpenToolkit.GraphicsLibraryFramework;
using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.Common.Input;
using OpenToolkit.Windowing.EventingModels;

namespace OpenToolkit.Windowing.Desktop
{
    public class NativeWindow : INativeWindow
    {
        private static GLFW Glfw => GLFWProvider.GLFW;
        private readonly unsafe Window* _windowPtr;

        public string ClipboardString
        {
            get
            {
                unsafe
                {
                    return Glfw.GetClipboardString(_windowPtr);
                }
            }

            set
            {
                unsafe
                {
                    Glfw.SetClipboardString(_windowPtr, value);
                }
            }
        }

        private string _title;

        public string Title
        {
            get => _title;
            set
            {
                unsafe
                {
                    _title = value;
                    Glfw.SetWindowTitle(_windowPtr, value);
                }

                OnTitleChanged(this, new TitleChangedEventArgs(value));
            }
        }

        public unsafe bool Focused
        {
            get => Glfw.GetWindowAttrib(_windowPtr, (int)WindowHint.Focused) != 0;
            set
            {
                if (value)
                {
                    Glfw.FocusWindow(_windowPtr);
                }
            }
        }

        public bool Visible
        {
            get
            {
                unsafe { return Glfw.GetWindowAttrib(_windowPtr, (int)WindowHint.Visible) != 0; }
            }
            set
            {
                if (value)
                {
                    unsafe { Glfw.ShowWindow(_windowPtr); }
                }
                else
                {
                    unsafe { Glfw.HideWindow(_windowPtr); }
                }
                OnVisibleChanged(this, EventArgs.Empty);
            }
        }

        public bool Exists
        {
            get { unsafe { return _windowPtr != null && !Glfw.WindowShouldClose(_windowPtr); } }
        }

        public IWindowInfo WindowInfo => throw new NotImplementedException("IWindowInfo is obsolete because platforms are going away, though we could create better borders around GLFW and define 'GLFWWindowInfo : IWindowInfo' but I think it's a case of YAGNI");

        public WindowState WindowState
        {
            get
            {
                unsafe
                {
                    if (Glfw.GetWindowAttrib(_windowPtr, (int)WindowHint.Iconified) == 1)
                    {
                        return WindowState.Minimized;
                    }
                    
                    if (Glfw.GetWindowMonitor(_windowPtr) != null)
                    {
                        return WindowState.Fullscreen;
                    }
                    
                    var monitor = Glfw.GetPrimaryMonitor();
                    var mode = Glfw.GetVideoMode(monitor);
                        
                    Glfw.GetWindowSize(_windowPtr, out var windowWidth, out var windowHeight);

                    if (mode->width == windowWidth && mode->height == windowHeight)
                    {
                        return WindowState.Maximized;
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
                            Glfw.RestoreWindow(_windowPtr);
                            break;
                        case WindowState.Minimized:
                            Glfw.IconifyWindow(_windowPtr);
                            break;
                        case WindowState.Maximized:
                            Glfw.MaximizeWindow(_windowPtr);
                            break;
                        case WindowState.Fullscreen:
                            var monitor = Glfw.GetPrimaryMonitor();
                            var mode = Glfw.GetVideoMode(monitor);
                            Glfw.SetWindowMonitor(_windowPtr, monitor, 0, 0, mode->width, mode->height, mode->refreshRate);
                            break;
                    }
                }

                OnWindowStateChanged(this, EventArgs.Empty);
            }
        }

        public WindowBorder WindowBorder
        {
            get
            {
                unsafe
                {
                    if (Glfw.GetWindowAttrib(_windowPtr, (int)WindowHint.Decorated) == 0)
                    {
                        return WindowBorder.Hidden;
                    }
                    else if (Glfw.GetWindowAttrib(_windowPtr, (int)WindowHint.Resizable) == 0)
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
                    Glfw.SetWindowSize(_windowPtr, value.Width, value.Height);
                    Glfw.SetWindowPos(_windowPtr, value.X, value.Y);
                }
            }
        }

        public Point Location
        {
            get
            {
                int x, y;
                unsafe { Glfw.GetWindowPos(_windowPtr, out x, out y); }
                return new Point(x, y);
            }
            set { unsafe { Glfw.SetWindowPos(_windowPtr, value.X, value.Y); } }
        }

        public Size Size
        {
            get
            {
                int width, height;
                unsafe { Glfw.GetWindowSize(_windowPtr, out width, out height); }
                return new Size(width, height);
            }
            set { unsafe { Glfw.SetWindowSize(_windowPtr, value.Width, value.Height); } }
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
                unsafe { Glfw.GetFramebufferSize(_windowPtr, out width, out height); }
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
                    var inputMode = Glfw.GetInputMode(_windowPtr, InputMode.Cursor);
                    return inputMode != InputModeValue.CursorHidden
                           && inputMode != InputModeValue.CursorDisabled;
                }
            }
            set
            {
                _cursorHidden = !value;
                unsafe
                {
                    Glfw.SetInputMode(_windowPtr, InputMode.Cursor,
                        value ? InputModeValue.CursorNormal : InputModeValue.CursorHidden);
                }
            }
        }

        public unsafe bool CursorGrabbed
        {
            get => Glfw.GetInputMode(_windowPtr, InputMode.Cursor) == InputModeValue.CursorDisabled;
            set
            {
                if (value)
                {
                    Glfw.SetInputMode(_windowPtr, InputMode.Cursor, InputModeValue.CursorDisabled);
                }
                else if (_cursorHidden)
                {
                    Glfw.SetInputMode(_windowPtr, InputMode.Cursor, InputModeValue.CursorHidden);
                }
                else
                {
                    Glfw.SetInputMode(_windowPtr, InputMode.Cursor, InputModeValue.CursorNormal);
                }
            }
        }


        public NativeWindow(int width = 640, int height = 480, string title = "", bool windowedFullscreen = false)
        {
            _title = title;

            unsafe
            {
                var monitor = Glfw.GetPrimaryMonitor();
                if (windowedFullscreen)
                {
                    var modePtr = Glfw.GetVideoMode(monitor);
                    Glfw.WindowHint(WindowHint.RedBits, modePtr->redBits);
                    Glfw.WindowHint(WindowHint.GreenBits, modePtr->greenBits);
                    Glfw.WindowHint(WindowHint.BlueBits, modePtr->blueBits);
                    Glfw.WindowHint(WindowHint.RefreshRate, modePtr->refreshRate);
                    _windowPtr = Glfw.CreateWindow(modePtr->width, modePtr->height, title, monitor, null);
                }
                else
                {
                    _windowPtr = Glfw.CreateWindow(width, height, title, null, null);
                }

                RegisterWindowCallbacks();
            }
        }

        private void RegisterWindowCallbacks()
        {
            unsafe
            {
                Glfw.SetWindowPosCallback(_windowPtr, (window, x, y) => OnMove(this, new WindowPositionEventArgs(x, y)));
                
                Glfw.SetWindowSizeCallback(_windowPtr, (width, height) => OnResize(this, new ResizeEventArgs(width, height)));
                
                Glfw.SetWindowCloseCallback(_windowPtr, (window) => OnClosing(this, new CancelEventArgs()));
                
                Glfw.SetWindowIconifyCallback(_windowPtr, (window, iconified) => OnIconChanged(this, new IconifyEventArgs(iconified)));
                
                Glfw.SetWindowFocusCallback(_windowPtr, (window, focused) => OnFocusedChanged(this, new FocusedChangedEventArgs(focused)));
                
                Glfw.SetCharCallback(_windowPtr, (window, codepoint) => OnKeyPress(this, new KeyPressEventArgs((char)codepoint)));
                
                Glfw.SetKeyCallback(_windowPtr, (window, key, scancode, action, mods) =>
                {
                    var args = new KeyboardKeyEventArgs();
                    
                    args.Key = (Key)key;
                    args.IsRepeat = action == InputAction.Repeat;
                    
                    //TODO: Need to find a good way to set the mods,
                    //The class as-is is coupled to the keyboard state in a really weird way.
                    //args.Modifiers = (KeyModifiers)mods;
                    
                    if (action == InputAction.Release)
                    {
                        OnKeyUp(this, args);
                    }
                    else
                    {
                        OnKeyDown(this, args);
                    }
                });
                
                Glfw.SetCursorEnterCallback(_windowPtr, (window, entered) =>
                {
                    if (entered)
                    {
                        OnMouseEnter(this, EventArgs.Empty);
                    }
                    else
                    {
                        OnMouseLeave(this, EventArgs.Empty);
                    }
                });
                
                Glfw.SetMouseButtonCallback(_windowPtr, (window, button, action, mods) =>
                {
                    if (action == InputAction.Press)
                    {
                        OnMouseDown(this, new MouseButtonEventArgs());
                    }
                    else if (action == InputAction.Release)
                    {
                        OnMouseUp(this, new MouseButtonEventArgs());
                    }

                });
                Glfw.SetCursorPosCallback(_windowPtr, (window, xpos, ypos) => OnMouseMove(this, new MouseMoveEventArgs()));
                Glfw.SetScrollCallback(_windowPtr, (window, xOffset, yOffset) => OnMouseWheel(this, new MouseWheelEventArgs()));
                Glfw.SetDropCallback(_windowPtr, (window, count, paths) => OnFileDrop(this, new FileDropEventArgs()));

                //TODO: Events from GLFW the 'legacy' NativeWindow didnt have events for.
                Glfw.SetCharModsCallback(_windowPtr, (window, codepoint, mods) => throw new NotImplementedException());
                Glfw.SetJoystickCallback((joy, eventCode) => throw new NotImplementedException());
                Glfw.SetMonitorCallback((monitor, eventCode) => throw new NotImplementedException());
            }
        }

        public virtual void Close()
        {
            unsafe
            {
                Glfw.SetWindowShouldClose(_windowPtr);
                OnClosed(this, EventArgs.Empty);
            }
        }

        public void MakeCurrent()
        {
            unsafe
            {
                Glfw.MakeContextCurrent(_windowPtr);
            }
        }

        //TODO: This doesnt account for the scenario of an event-based application in which we would use `glfw.WaitEvents()` that waits for input to keep CPU usage minimal
        public virtual void ProcessEvents()
        {
            Glfw.PollEvents();
        }

        public Point PointToClient(Point point)
        {
            throw new NotImplementedException();
        }

        public Point PointToScreen(Point point)
        {
            throw new NotImplementedException();
        }

        #region Event Handlers
        public event EventHandler<WindowPositionEventArgs> Move;
        public event EventHandler<ResizeEventArgs> Resize;
        public event EventHandler<CancelEventArgs> Closing;
        public event EventHandler<EventArgs> Closed;
        public event EventHandler<EventArgs> Disposed;
        public event EventHandler<IconifyEventArgs> IconChanged;
        public event EventHandler<TitleChangedEventArgs> TitleChanged;
        public event EventHandler<EventArgs> VisibleChanged;
        public event EventHandler<FocusedChangedEventArgs> FocusedChanged;
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

        #region Events

        protected virtual void OnMove(object sender, WindowPositionEventArgs e)
        {
            Move?.Invoke(sender, e);
        }

        protected virtual void OnResize(object sender, ResizeEventArgs e)
        {
            Resize?.Invoke(sender, e);
        }
        
        protected virtual void OnClosing(object sender, CancelEventArgs e)
        {
            Closing?.Invoke(sender, e);
        }
        
        protected virtual void OnClosed(object sender, EventArgs e)
        {
            Closed?.Invoke(sender, e);
        }
        
        protected virtual void OnDisposed(object sender, EventArgs e)
        {
            Disposed?.Invoke(sender, e);
        }
        
        protected virtual void OnIconChanged(object sender, IconifyEventArgs e)
        {
            IconChanged?.Invoke(sender, e);
        }
        
        protected virtual void OnTitleChanged(object sender, TitleChangedEventArgs e)
        {
            TitleChanged?.Invoke(sender, e);
        }
        
        protected virtual void OnVisibleChanged(object sender, EventArgs e)
        {
            VisibleChanged?.Invoke(sender, e);
        }
        
        protected virtual void OnFocusedChanged(object sender, FocusedChangedEventArgs e)
        {
            FocusedChanged?.Invoke(sender, e);
        }
        
        protected virtual void OnWindowBorderChanged(object sender, EventArgs e)
        {
            WindowBorderChanged?.Invoke(sender, e);
        }
        
        protected virtual void OnWindowStateChanged(object sender, EventArgs e)
        {
            WindowStateChanged?.Invoke(sender, e);
        }
        
        protected virtual void OnKeyDown(object sender, KeyboardKeyEventArgs e)
        {
            KeyDown?.Invoke(sender, e);
        }
        
        protected virtual void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress?.Invoke(sender, e);
        }
        
        protected virtual void OnKeyUp(object sender, KeyboardKeyEventArgs e)
        {
            KeyUp?.Invoke(sender, e);
        }
        
        protected virtual void OnMouseLeave(object sender, EventArgs e)
        {
            MouseLeave?.Invoke(sender, e);
        }
        
        protected virtual void OnMouseEnter(object sender, EventArgs e)
        {
            MouseEnter?.Invoke(sender, e);
        }
        
        protected virtual void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MouseDown?.Invoke(sender, e);
        }
        
        protected virtual void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            MouseUp?.Invoke(sender, e);
        }
        
        protected virtual void OnMouseMove(object sender, MouseMoveEventArgs e)
        {
            MouseMove?.Invoke(sender, e);
        }
        
        protected virtual void OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
            MouseWheel?.Invoke(sender, e);
        }
        
        protected virtual void OnFileDrop(object sender, FileDropEventArgs e)
        {
            FileDrop?.Invoke(sender, e);
        }
        #endregion

        #region IDisposable Support
        private bool _disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                return;
            }
            
            if (disposing)
            {
            
            }

            // Free unmanaged resources
            unsafe
            {
                if (_windowPtr != null)
                {
                    Glfw.DestroyWindow(_windowPtr);
                    Closed?.Invoke(this, EventArgs.Empty);
                }
            }

            _disposedValue = true;
            Disposed?.Invoke(this, EventArgs.Empty);
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
