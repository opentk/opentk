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
using System.Threading;
using OpenToolkit.GraphicsLibraryFramework;
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.Common.Input;
using OpenToolkit.Windowing.EventingModels;
using Monitor = OpenToolkit.Windowing.Common.Monitor;

namespace OpenToolkit.Windowing.Desktop
{
    public class NativeWindow : INativeWindow
    {
        protected static GLFW Glfw => GLFWProvider.GLFW.Value;
        protected readonly unsafe Window* _windowPtr;
        
        /// <summary>
        /// The X position of the mouse on the last update. Used to calculate the mouse delta.
        /// </summary>
        protected double lastMousePositionX;
        
        /// <summary>
        /// The Y position of the mouse on the last update. Used to calculate the mouse delta.
        /// </summary>
        protected double lastMousePositionY;

        /// <summary>
        /// The current number of windows open. If this is zero when a window closes, GLFW will be terminated.
        /// </summary>
        protected static int _numberOfUsers;
        
        protected static Mutex _mutex;
        
        public bool IsEventDriven { get; set; }

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
                    Glfw.SetWindowTitle(_windowPtr, value);
                }
            }
        }

        public unsafe Monitor CurrentMonitor
        {
            get
            {
                var _monitor = (IntPtr)Glfw.GetWindowMonitor(_windowPtr);
                
                return new Monitor(_monitor);
            }
            set
            {
                var _monitor = (GraphicsLibraryFramework.Monitor*)value.Ptr;
                var mode = Glfw.GetVideoMode(_monitor);
                Glfw.SetWindowMonitor(_windowPtr, _monitor, (int)_location.X, (int)_location.Y,
                    (int)_size.X, (int)_size.Y, mode->refreshRate);
            }
        }

        private bool _isFocused;
        
        public bool Focused
        {
            get => _isFocused;
            set
            {
                if (value)
                {
                    unsafe { Glfw.FocusWindow(_windowPtr); }
                }
            }
        }

        private bool _isVisible;

        public bool Visible
        {
            get => _isVisible;
            set
            {
                unsafe
                {
                    if (value)
                    {
                        Glfw.ShowWindow(_windowPtr);
                    }
                    else
                    {
                        Glfw.HideWindow(_windowPtr);
                    }
                }
            }
        }

        public bool Exists
        {
            get
            {
                unsafe
                {
                    return _windowPtr != null && !Glfw.WindowShouldClose(_windowPtr);
                }
            }
        }
        
        public WindowState WindowState
        {
            get
            {
                unsafe
                {
                    if (Glfw.GetWindowAttrib(_windowPtr, WindowAttribute.Iconified) == 1)
                    {
                        return WindowState.Minimized;
                    }

                    if (Glfw.GetWindowMonitor(_windowPtr) != null)
                    {
                        return WindowState.Fullscreen;
                    }

                    var mode = Glfw.GetVideoMode((GraphicsLibraryFramework.Monitor*)CurrentMonitor.Ptr);

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
                            var _monitor = (GraphicsLibraryFramework.Monitor*)CurrentMonitor.Ptr;
                            var mode = Glfw.GetVideoMode(_monitor);
                            Glfw.SetWindowMonitor(_windowPtr, _monitor, 0, 0, mode->width, mode->height,
                                mode->refreshRate);
                            break;
                    }
                }
            }
        }

        private WindowBorder _windowBorder;

        public WindowBorder WindowBorder
        {
            get => _windowBorder;
            
            set
            {
                unsafe
                {
                    Glfw.GetVersion(out var major, out var minor, out _);
                    
                    //It isn't possible to implement this in versions of GLFW older than 3.3,
                    //as SetWindowAttrib didn't exist before then.
                    if (major == 3 && minor < 3)
                        throw new NotSupportedException("Cannot be implemented in GLFW 3.2.");
                    
                    switch (value)
                    {
                        case WindowBorder.Hidden:
                            Glfw.SetWindowAttrib(_windowPtr, WindowAttribute.Decorated, 0);
                            break;
                    
                        case WindowBorder.Resizable:
                            Glfw.SetWindowAttrib(_windowPtr, WindowAttribute.Resizable, 1);
                            break;
                    
                        case WindowBorder.Fixed:
                            Glfw.SetWindowAttrib(_windowPtr, WindowAttribute.Resizable, 0);
                            break;
                    }
                }

                _windowBorder = value;
            }
        }

        public Box2 Bounds
        {
            get => Box2.FromDimensions(Location, Size);
            set
            {
                unsafe
                {
                    Glfw.SetWindowSize(_windowPtr, (int)value.Width, (int)value.Height);
                    Glfw.SetWindowPos(_windowPtr, (int)value.Left, (int)value.Top);
                }
            }
        }

        private Vector2 _location;

        public Vector2 Location
        {
            get => _location;
            set
            {
                unsafe { Glfw.SetWindowPos(_windowPtr, (int)value.X, (int)value.Y); }
            }
        }

        private Vector2 _size;

        public Vector2 Size
        {
            get => _size;
            set
            {
                unsafe { Glfw.SetWindowSize(_windowPtr, (int)value.X, (int)value.Y); }
            }
        }

        public int X
        {
            get => (int)Location.X;
            set
            {
                _location.X = value;

                unsafe
                {
                    Glfw.SetWindowPos(_windowPtr, value, (int)_location.Y);
                }
            }
        }

        public int Y
        {
            get => (int)Location.Y;
            set
            {
                _location.Y = value;

                unsafe
                {
                    Glfw.SetWindowPos(_windowPtr, (int)_location.X, value);
                }
            }
        }

        public int Width
        {
            get => (int)Size.X;
            set
            {
                _size.X = value;
                
                unsafe
                {
                    Glfw.SetWindowSize(_windowPtr, value, (int)_size.Y);
                }
            }
        }

        public int Height
        {
            get => (int)Size.Y;
            set
            {
                _size.Y = value;
                
                unsafe
                {
                    Glfw.SetWindowSize(_windowPtr, (int)_size.Y, value);
                }
            }
        }

        public Box2 ClientRectangle
        {
            get => Box2.FromDimensions(Location, Size);
            
            set
            {
                Location = new Vector2(value.Right, value.Top);
                Size = new Vector2(value.Width, value.Height);
            }
        }

        public Vector2 ClientSize { get; }

        public MouseCursor Cursor
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        
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
                unsafe
                {
                    Glfw.SetInputMode(_windowPtr, InputMode.Cursor,
                        value ? InputModeValue.CursorNormal : InputModeValue.CursorHidden);
                }
            }
        }

        public bool CursorGrabbed
        {
            get
            {
                unsafe
                {
                    return Glfw.GetInputMode(_windowPtr, InputMode.Cursor) == InputModeValue.CursorDisabled;
                }
            }
            
            set
            {
                unsafe
                {
                    if (value)
                    {
                        Glfw.SetInputMode(_windowPtr, InputMode.Cursor, InputModeValue.CursorDisabled);
                    }
                    else if (CursorVisible)
                    {
                        Glfw.SetInputMode(_windowPtr, InputMode.Cursor, InputModeValue.CursorNormal);
                    }
                    else
                    {
                        Glfw.SetInputMode(_windowPtr, InputMode.Cursor, InputModeValue.CursorHidden);
                    }
                }
            }
        }

        public NativeWindow(INativeWindowProperties settings)
        {
            _title = settings.Title;
            
            _mutex = new Mutex();

            unsafe
            {
                switch (settings.WindowBorder)
                {
                    case WindowBorder.Hidden:
                        Glfw.WindowHint(WindowHint.Decorated, 0);
                        break;
                    
                    case WindowBorder.Resizable:
                        Glfw.WindowHint(WindowHint.Resizable, 1);
                        break;
                    
                    case WindowBorder.Fixed:
                        Glfw.WindowHint(WindowHint.Resizable, 0);
                        break;
                }

                _windowBorder = settings.WindowBorder;
                
                if (settings.WindowState == WindowState.Fullscreen)
                {
                    var _monitor = (GraphicsLibraryFramework.Monitor*)settings.CurrentMonitor.Ptr;
                    var modePtr = Glfw.GetVideoMode(_monitor);
                    Glfw.WindowHint(WindowHint.RedBits, modePtr->redBits);
                    Glfw.WindowHint(WindowHint.GreenBits, modePtr->greenBits);
                    Glfw.WindowHint(WindowHint.BlueBits, modePtr->blueBits);
                    Glfw.WindowHint(WindowHint.RefreshRate, modePtr->refreshRate);
                    _windowPtr = Glfw.CreateWindow(modePtr->width, modePtr->height,
                        _title, _monitor, null);
                }
                else
                {
                    _windowPtr = Glfw.CreateWindow(settings.Width, settings.Height, _title, null, null);
                }

                RegisterWindowCallbacks();
                
                Focused = settings.Focused;
                Visible = settings.Visible;
                WindowState = settings.WindowState;

                IsEventDriven = settings.IsEventDriven;
                
                if (settings.X > -1)
                {
                    X = settings.X;
                }

                if (settings.Y > -1)
                {
                    Y = settings.Y;
                }
                
                Glfw.GetFramebufferSize(_windowPtr, out var width, out var height);
                ClientSize = new Vector2(width, height);
            }

            _mutex.WaitOne();

            _numberOfUsers += 1;
            
            _mutex.ReleaseMutex();
        }

        private void RegisterWindowCallbacks()
        {
            unsafe
            {
                Glfw.SetWindowPosCallback(_windowPtr, (window, x, y) => OnMove(this, new WindowPositionEventArgs(x, y)));
                
                Glfw.SetWindowSizeCallback(_windowPtr, (width, height) => OnResize(this, new ResizeEventArgs(width, height)));
                
                Glfw.SetWindowCloseCallback(_windowPtr, window => OnClosing(this, new CancelEventArgs()));
                
                Glfw.SetWindowIconifyCallback(_windowPtr, (window, iconified) => OnIconChanged(this, new IconifyEventArgs(iconified)));
                
                Glfw.SetWindowFocusCallback(_windowPtr, (window, focused) => OnFocusedChanged(this, new FocusedChangedEventArgs(focused)));
                
                Glfw.SetCharCallback(_windowPtr, (window, codepoint) => OnKeyPress(this, new KeyPressEventArgs((char)codepoint)));
                
                Glfw.SetKeyCallback(_windowPtr, (window, key, scancode, action, mods) =>
                {
                    var args = new KeyboardKeyEventArgs {Key = (Key)key, IsRepeat = action == GraphicsLibraryFramework.InputAction.Repeat};


                    //TODO: Need to find a good way to set the mods,
                    //The class as-is is coupled to the keyboard state in a really weird way.
                    //args.Modifiers = (KeyModifiers)mods;
                    
                    if (action == GraphicsLibraryFramework.InputAction.Release)
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
                    var args = new MouseButtonEventArgs {Button = (MouseButton)button,
                        Action = (Common.InputAction)action,
                        Modifiers = (KeyModifiers)mods};

                    if (action == GraphicsLibraryFramework.InputAction.Release)
                    {
                        OnMouseUp(this, args);
                    }
                    else
                    {
                        OnMouseDown(this, args);
                    }
                });
                
                Glfw.SetCursorPosCallback(_windowPtr, (window, xpos, ypos) =>
                {
                    var deltaX = lastMousePositionX - xpos;
                    var deltaY = lastMousePositionY - ypos;
                    
                    OnMouseMove(this, new MouseMoveEventArgs(xpos, ypos, deltaX, deltaY));

                    lastMousePositionX = xpos;
                    lastMousePositionY = ypos;
                });
                
                Glfw.SetScrollCallback(_windowPtr, (window, xOffset, yOffset) => OnMouseWheel(this, new MouseWheelEventArgs()));
                
                Glfw.SetDropCallback(_windowPtr, (window, count, paths) =>
                {
                    unsafe
                    {
                        var pathsStrings = (char**)paths;

                        var arrayOfPaths = new string[count];

                        for (var i = 0; i < count; i++)
                        {
                            if (pathsStrings != null)
                                arrayOfPaths[i] = new string(pathsStrings[i]);
                        }
                        
                        OnFileDrop(this, new FileDropEventArgs(arrayOfPaths));
                    }
                });

                
                Glfw.SetCharModsCallback(_windowPtr, (window, codepoint, mods) =>
                {
                    OnKeyboardCharMod(this, new KeyboardCharModEventArgs(codepoint, (KeyModifiers)mods));
                });
                
                Glfw.SetJoystickCallback((joy, eventCode) =>
                {
                    OnJoystickConnected(this, new JoystickEventArgs(joy, eventCode == JoystickState.Connected));
                });
                
                Glfw.SetMonitorCallback((monitor, eventCode) =>
                {
                    OnMonitorConnected(this, new MonitorEventArgs(monitor, eventCode == MonitorState.Connected));
                });
            }
        }

        public virtual void Close()
        {
            unsafe
            {
                Glfw.SetWindowShouldClose(_windowPtr, 1);
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
        
        public virtual void ProcessEvents()
        {
            if (IsEventDriven)
            {
                Glfw.WaitEvents();
            }
            else 
            {
                Glfw.PollEvents();
            }
        }

        public Vector2 PointToClient(Vector2 point)
        {
            return point - Location;
        }

        public Vector2 PointToScreen(Vector2 point)
        {
            return point + Location;
        }

        #region Event Handlers
        public event EventHandler<WindowPositionEventArgs> Move;
        public event EventHandler<ResizeEventArgs> Resize;
        public event EventHandler<CancelEventArgs> Closing;
        public event EventHandler<EventArgs> Closed;
        public event EventHandler<EventArgs> Disposed;
        public event EventHandler<IconifyEventArgs> IconChanged;
        public event EventHandler<JoystickEventArgs> JoystickConnected;
        public event EventHandler<TitleChangedEventArgs> TitleChanged;
        public event EventHandler<VisibilityChangedEventArgs> VisibleChanged;
        public event EventHandler<FocusedChangedEventArgs> FocusedChanged;
        public event EventHandler<EventArgs> WindowBorderChanged;
        public event EventHandler<EventArgs> WindowStateChanged;
        public event EventHandler<KeyboardKeyEventArgs> KeyDown;
        public event EventHandler<KeyPressEventArgs> KeyPress;
        public event EventHandler<KeyboardCharModEventArgs> KeyboardCharMod;
        public event EventHandler<KeyboardKeyEventArgs> KeyUp;
        public event EventHandler<MonitorEventArgs> MonitorConnected;
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

            _location.X = e.X;
            _location.Y = e.Y;
        }

        protected virtual void OnResize(object sender, ResizeEventArgs e)
        {
            Resize?.Invoke(sender, e);
            
            _size.X = e.Width;
            _size.Y = e.Height;
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

        protected virtual void OnJoystickConnected(object sender, JoystickEventArgs e)
        {
            JoystickConnected?.Invoke(sender, e);
        }
        
        protected virtual void OnTitleChanged(object sender, TitleChangedEventArgs e)
        {
            TitleChanged?.Invoke(sender, e);

            _title = e.Title;
        }
        
        protected virtual void OnVisibleChanged(object sender, VisibilityChangedEventArgs e)
        {
            VisibleChanged?.Invoke(sender, e);

            _isVisible = e.isVisible;
        }
        
        protected virtual void OnFocusedChanged(object sender, FocusedChangedEventArgs e)
        {
            FocusedChanged?.Invoke(sender, e);

            _isFocused = e.isFocused;
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

        protected virtual void OnKeyboardCharMod(object sender, KeyboardCharModEventArgs e)
        {
            KeyboardCharMod?.Invoke(sender, e);
        }
        
        protected virtual void OnKeyUp(object sender, KeyboardKeyEventArgs e)
        {
            KeyUp?.Invoke(sender, e);
        }

        protected virtual void OnMonitorConnected(object sender, MonitorEventArgs e)
        {
            MonitorConnected?.Invoke(sender, e);
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
        private bool _disposedValue; // To detect redundant calls

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

            _mutex.WaitOne();

            _numberOfUsers -= 1;

            if (_numberOfUsers <= 0)
            {
                GLFWProvider.Unload();
            }
            
            _mutex.ReleaseMutex();
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
