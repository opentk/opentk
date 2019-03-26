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
using KeyModifiers = OpenToolkit.Windowing.Common.Input.KeyModifiers;
using Monitor = OpenToolkit.Windowing.Common.Monitor;

namespace OpenToolkit.Windowing.Desktop
{
    public class NativeWindow : INativeWindow
    {
        protected static GLFW Glfw => GLFWProvider.GLFW.Value;
        protected readonly unsafe Window* WindowPtr;
        
        /// <summary>
        /// The X position of the mouse on the last update. Used to calculate the mouse delta.
        /// </summary>
        protected double LastMousePositionX;
        
        /// <summary>
        /// The Y position of the mouse on the last update. Used to calculate the mouse delta.
        /// </summary>
        protected double LastMousePositionY;

        /// <summary>
        /// The current number of windows open. If this is zero when a window closes, GLFW will be terminated.
        /// </summary>
        protected static int NumberOfUsers;
        
        protected static Mutex Mutex;
        
        public bool IsEventDriven { get; set; }

        public string ClipboardString
        {
            get
            {
                unsafe
                {
                    return Glfw.GetClipboardString(WindowPtr);
                }
            }

            set
            {
                unsafe
                {
                    Glfw.SetClipboardString(WindowPtr, value);
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
                    Glfw.SetWindowTitle(WindowPtr, value);
                }
            }
        }

        public unsafe Monitor CurrentMonitor
        {
            get
            {
                var monitor = (IntPtr)Glfw.GetWindowMonitor(WindowPtr);
                
                return new Monitor(monitor);
            }
            set
            {
                var monitor = (GraphicsLibraryFramework.Monitor*)value.Ptr;
                var mode = Glfw.GetVideoMode(monitor);
                Glfw.SetWindowMonitor(WindowPtr, monitor, (int)_location.X, (int)_location.Y,
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
                    unsafe { Glfw.FocusWindow(WindowPtr); }
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
                        Glfw.ShowWindow(WindowPtr);
                    }
                    else
                    {
                        Glfw.HideWindow(WindowPtr);
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
                    return WindowPtr != null && !Glfw.WindowShouldClose(WindowPtr);
                }
            }
        }
        
        public WindowState WindowState
        {
            get
            {
                unsafe
                {
                    if (Glfw.GetWindowAttrib(WindowPtr, WindowAttribute.Iconified) == 1)
                    {
                        return WindowState.Minimized;
                    }

                    if (Glfw.GetWindowMonitor(WindowPtr) != null)
                    {
                        return WindowState.Fullscreen;
                    }

                    var mode = Glfw.GetVideoMode((GraphicsLibraryFramework.Monitor*)CurrentMonitor.Ptr);

                    Glfw.GetWindowSize(WindowPtr, out var windowWidth, out var windowHeight);

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
                            Glfw.RestoreWindow(WindowPtr);
                            break;
                        case WindowState.Minimized:
                            Glfw.IconifyWindow(WindowPtr);
                            break;
                        case WindowState.Maximized:
                            Glfw.MaximizeWindow(WindowPtr);
                            break;
                        case WindowState.Fullscreen:
                            var monitor = (GraphicsLibraryFramework.Monitor*)CurrentMonitor.Ptr;
                            var mode = Glfw.GetVideoMode(monitor);
                            Glfw.SetWindowMonitor(WindowPtr, monitor, 0, 0, mode->width, mode->height,
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
                            Glfw.SetWindowAttrib(WindowPtr, WindowAttribute.Decorated, 0);
                            break;
                    
                        case WindowBorder.Resizable:
                            Glfw.SetWindowAttrib(WindowPtr, WindowAttribute.Resizable, 1);
                            break;
                    
                        case WindowBorder.Fixed:
                            Glfw.SetWindowAttrib(WindowPtr, WindowAttribute.Resizable, 0);
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
                    Glfw.SetWindowSize(WindowPtr, (int)value.Width, (int)value.Height);
                    Glfw.SetWindowPos(WindowPtr, (int)value.Left, (int)value.Top);
                }
            }
        }

        private Vector2 _location;

        public Vector2 Location
        {
            get => _location;
            set
            {
                unsafe { Glfw.SetWindowPos(WindowPtr, (int)value.X, (int)value.Y); }
            }
        }

        private Vector2 _size;

        public Vector2 Size
        {
            get => _size;
            set
            {
                unsafe { Glfw.SetWindowSize(WindowPtr, (int)value.X, (int)value.Y); }
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
                    Glfw.SetWindowPos(WindowPtr, value, (int)_location.Y);
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
                    Glfw.SetWindowPos(WindowPtr, (int)_location.X, value);
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
                    Glfw.SetWindowSize(WindowPtr, value, (int)_size.Y);
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
                    Glfw.SetWindowSize(WindowPtr, (int)_size.Y, value);
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
        
        private MouseCursor _cursor;

        public MouseCursor Cursor
        {
            get => _cursor;
            set
            {
                _cursor = value;

                unsafe
                {
                    if (value == MouseCursor.Default)
                    {
                        var cursor = Glfw.CreateStandardCursor(CursorShape.Arrow);
                        Glfw.SetCursor(WindowPtr, cursor);
                    }
                    else
                    {
                        fixed (byte* ptr = value.Data)
                        {
                            var cursorImg = new Image {Width = value.Width, Height = value.Height, Pixels = (IntPtr)ptr};
                            var cursor = Glfw.CreateCursor(&cursorImg, value.X, value.Y);
                            Glfw.SetCursor(WindowPtr, cursor);
                        }
                    }
                }
            }
        }
        
        public bool CursorVisible
        {
            get
            {
                unsafe
                {
                    var inputMode = Glfw.GetInputMode(WindowPtr, InputMode.Cursor);
                    return inputMode != InputModeValue.CursorHidden
                           && inputMode != InputModeValue.CursorDisabled;
                }
            }
            set
            {
                unsafe
                {
                    Glfw.SetInputMode(WindowPtr, InputMode.Cursor,
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
                    return Glfw.GetInputMode(WindowPtr, InputMode.Cursor) == InputModeValue.CursorDisabled;
                }
            }
            
            set
            {
                unsafe
                {
                    if (value)
                    {
                        Glfw.SetInputMode(WindowPtr, InputMode.Cursor, InputModeValue.CursorDisabled);
                    }
                    else if (CursorVisible)
                    {
                        Glfw.SetInputMode(WindowPtr, InputMode.Cursor, InputModeValue.CursorNormal);
                    }
                    else
                    {
                        Glfw.SetInputMode(WindowPtr, InputMode.Cursor, InputModeValue.CursorHidden);
                    }
                }
            }
        }

        public NativeWindow(INativeWindowProperties settings)
        {
            _title = settings.Title;
            
            Mutex = new Mutex();

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
                    var monitor = (GraphicsLibraryFramework.Monitor*)settings.CurrentMonitor.Ptr;
                    var modePtr = Glfw.GetVideoMode(monitor);
                    Glfw.WindowHint(WindowHint.RedBits, modePtr->redBits);
                    Glfw.WindowHint(WindowHint.GreenBits, modePtr->greenBits);
                    Glfw.WindowHint(WindowHint.BlueBits, modePtr->blueBits);
                    Glfw.WindowHint(WindowHint.RefreshRate, modePtr->refreshRate);
                    WindowPtr = Glfw.CreateWindow(modePtr->width, modePtr->height,
                        _title, monitor, null);
                }
                else
                {
                    WindowPtr = Glfw.CreateWindow(settings.Width, settings.Height, _title, null, null);
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
                
                Glfw.GetFramebufferSize(WindowPtr, out var width, out var height);
                ClientSize = new Vector2(width, height);
            }

            Mutex.WaitOne();

            NumberOfUsers += 1;
            
            Mutex.ReleaseMutex();
        }

        private void RegisterWindowCallbacks()
        {
            unsafe
            {
                Glfw.SetWindowPosCallback(WindowPtr, (window, x, y) => OnMove(this, new WindowPositionEventArgs(x, y)));
                
                Glfw.SetWindowSizeCallback(WindowPtr, (width, height) => OnResize(this, new ResizeEventArgs(width, height)));
                
                Glfw.SetWindowCloseCallback(WindowPtr, window => OnClosing(this, new CancelEventArgs()));
                
                Glfw.SetWindowIconifyCallback(WindowPtr, (window, iconified) => OnIconChanged(this, new IconifyEventArgs(iconified)));
                
                Glfw.SetWindowFocusCallback(WindowPtr, (window, focused) => OnFocusedChanged(this, new FocusedChangedEventArgs(focused)));
                
                Glfw.SetCharCallback(WindowPtr, (window, codepoint) => OnKeyPress(this, new KeyPressEventArgs((char)codepoint)));
                
                Glfw.SetKeyCallback(WindowPtr, (window, key, scancode, action, mods) =>
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
                
                Glfw.SetCursorEnterCallback(WindowPtr, (window, entered) =>
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
                
                Glfw.SetMouseButtonCallback(WindowPtr, (window, button, action, mods) =>
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
                
                Glfw.SetCursorPosCallback(WindowPtr, (window, xpos, ypos) =>
                {
                    var deltaX = LastMousePositionX - xpos;
                    var deltaY = LastMousePositionY - ypos;
                    
                    OnMouseMove(this, new MouseMoveEventArgs(xpos, ypos, deltaX, deltaY));

                    LastMousePositionX = xpos;
                    LastMousePositionY = ypos;
                });
                
                Glfw.SetScrollCallback(WindowPtr, (window, xOffset, yOffset) => OnMouseWheel(this, new MouseWheelEventArgs()));
                
                Glfw.SetDropCallback(WindowPtr, (window, count, paths) =>
                {
                    var pathsStrings = (char**)paths;

                    var arrayOfPaths = new string[count];

                    for (var i = 0; i < count; i++)
                    {
                        if (pathsStrings != null)
                        arrayOfPaths[i] = new string(pathsStrings[i]);        
                    }
                    
                    OnFileDrop(this, new FileDropEventArgs(arrayOfPaths));
                });

                
                Glfw.SetCharModsCallback(WindowPtr, (window, codepoint, mods) =>
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
                Glfw.SetWindowShouldClose(WindowPtr, 1);
                OnClosed(this, EventArgs.Empty);
            }
        }

        public void MakeCurrent()
        {
            unsafe
            {
                Glfw.MakeContextCurrent(WindowPtr);
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
                if (WindowPtr != null)
                {
                    Glfw.DestroyWindow(WindowPtr);
                    Closed?.Invoke(this, EventArgs.Empty);
                }
            }

            _disposedValue = true;
            Disposed?.Invoke(this, EventArgs.Empty);

            Mutex.WaitOne();

            NumberOfUsers -= 1;

            if (NumberOfUsers <= 0)
            {
                GLFWProvider.Unload();
            }
            
            Mutex.ReleaseMutex();
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
