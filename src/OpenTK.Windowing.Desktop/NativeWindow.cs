// Copyright (c) OpenTK. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using OpenToolkit.GraphicsLibraryFramework;
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.Common.Input;
using InputAction = OpenToolkit.GraphicsLibraryFramework.InputAction;
using KeyModifiers = OpenToolkit.Windowing.Common.Input.KeyModifiers;
using Monitor = OpenToolkit.Windowing.Common.Monitor;

namespace OpenToolkit.Windowing.Desktop
{
    /// <summary>
    /// Instances of this class implement the <see cref="INativeWindow"/> interface on the current platform.
    /// </summary>
    public class NativeWindow : INativeWindow
    {
        /// <summary>
        /// Gets a <see cref="GLFW"/> API implementation.
        /// </summary>
        protected static GLFW Glfw => GLFWProvider.GLFW.Value;

        /// <summary>
        /// The current number of windows open. If this is zero when a window closes, GLFW will be terminated.
        /// </summary>
        private static int _numberOfUsers;

        /// <summary>
        /// Gets the native <see cref="Window"/> pointer for use with <see cref="GLFW"/> API.
        /// </summary>
        protected unsafe Window* WindowPtr { get; }

        /// <summary>
        /// The X position of the mouse on the last update. Used to calculate the mouse delta.
        /// </summary>
        private double _lastMousePositionX;

        /// <summary>
        /// The Y position of the mouse on the last update. Used to calculate the mouse delta.
        /// </summary>
        private double _lastMousePositionY;

        private WindowIcon _icon;

        /// <inheritdoc />
        public WindowIcon Icon
        {
            get => _icon;
            set
            {
                unsafe
                {
                    fixed (GraphicsLibraryFramework.Image* ptr =
                        Unsafe.As<GraphicsLibraryFramework.Image[]>(value.Images))
                    {
                        Glfw.SetWindowIcon(WindowPtr, value.Images.Length, ptr);
                    }
                }

                _icon = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this window is event driven or not.
        /// </summary>
        public bool IsEventDriven { get; set; }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public string Title
        {
            get => _title;
            set
            {
                unsafe
                {
                    Glfw.SetWindowTitle(WindowPtr, value);
                }

                OnTitleChanged(this, new TitleChangedEventArgs(value));
            }
        }

        private Monitor _currentMonitor;

        /// <summary>
        /// Gets or sets the current <see cref="Monitor"/>.
        /// </summary>
        public unsafe Monitor CurrentMonitor
        {
            get => _currentMonitor;

            set
            {
                var monitor = value.ToUnsafePtr<GraphicsLibraryFramework.Monitor>();
                var mode = Glfw.GetVideoMode(monitor);
                Glfw.SetWindowMonitor
                (
                    WindowPtr,
                    monitor,
                    (int)_location.X,
                    (int)_location.Y,
                    (int)_size.X,
                    (int)_size.Y,
                    mode->RefreshRate
                );
            }
        }

        private bool _isFocused;

        /// <inheritdoc />
        public unsafe bool IsFocused
        {
            get => _isFocused;
            set
            {
                if (value)
                {
                    Glfw.FocusWindow(WindowPtr);
                }
            }
        }

        private bool _isVisible;

        /// <inheritdoc />
        public bool IsVisible
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
                    OnVisibleChanged(this, new VisibilityChangedEventArgs(value));
                }
            }
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public unsafe WindowState WindowState
        {
            get
            {
                if (Glfw.GetWindowAttrib(WindowPtr, WindowAttributeGetter.Iconified))
                {
                    return WindowState.Minimized;
                }

                if (Glfw.GetWindowAttrib(WindowPtr, WindowAttributeGetter.Maximized))
                {
                    return WindowState.Maximized;
                }

                if (Glfw.GetWindowMonitor(WindowPtr) != null)
                {
                    return WindowState.Fullscreen;
                }

                /*var mode = Glfw.GetVideoMode(CurrentMonitor.ToUnsafePtr<GraphicsLibraryFramework.Monitor>());

                Glfw.GetWindowSize(WindowPtr, out var windowWidth, out var windowHeight);

                if (mode->Width == windowWidth && mode->Height == windowHeight)
                {
                    return WindowState.Maximized;
                }*/

                return WindowState.Normal;
            }

            set
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
                        var monitor = CurrentMonitor.ToUnsafePtr<GraphicsLibraryFramework.Monitor>();
                        var mode = Glfw.GetVideoMode(monitor);
                        Glfw.SetWindowMonitor(WindowPtr, monitor, 0, 0, mode->Width, mode->Height, mode->RefreshRate);
                        break;
                }
            }
        }

        private WindowBorder _windowBorder;

        /// <inheritdoc />
        public unsafe WindowBorder WindowBorder
        {
            get => _windowBorder;

            set
            {
                if (!Glfw.GetWindowAttrib(WindowPtr, WindowAttributeGetter.Decorated))
                {
                    Glfw.GetVersion(out var major, out var minor, out _);

                    // It isn't possible to implement this in versions of GLFW older than 3.3,
                    // as SetWindowAttrib didn't exist before then.
                    if ((major == 3) && (minor < 3))
                    {
                        throw new NotSupportedException("Cannot be implemented in GLFW 3.2.");
                    }

                    switch (value)
                    {
                        case WindowBorder.Hidden:
                            Glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Decorated, false);
                            break;

                        case WindowBorder.Resizable:
                            Glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Resizable, true);
                            break;

                        case WindowBorder.Fixed:
                            Glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Resizable, false);
                            break;
                    }
                }

                _windowBorder = value;
            }
        }

        /// <inheritdoc />
        public unsafe Box2 Bounds
        {
            get => Box2.FromDimensions(Location, Size);
            set
            {
                Glfw.SetWindowSize(WindowPtr, (int)value.Width, (int)value.Height);
                Glfw.SetWindowPos(WindowPtr, (int)value.Left, (int)value.Top);
            }
        }

        private Vector2 _location;

        /// <inheritdoc />
        public unsafe Vector2 Location
        {
            get => _location;
            set => Glfw.SetWindowPos(WindowPtr, (int)value.X, (int)value.Y);
        }

        private Vector2 _size;

        /// <inheritdoc />
        public unsafe Vector2 Size
        {
            get => _size;
            set => Glfw.SetWindowSize(WindowPtr, (int)value.X, (int)value.Y);
        }

        /// <inheritdoc />
        public unsafe int X
        {
            get => (int)Location.X;
            set
            {
                _location.X = value;

                Glfw.SetWindowPos(WindowPtr, value, (int)_location.Y);
            }
        }

        /// <inheritdoc />
        public unsafe int Y
        {
            get => (int)Location.Y;
            set
            {
                _location.Y = value;

                Glfw.SetWindowPos(WindowPtr, (int)_location.X, value);
            }
        }

        /// <inheritdoc />
        public unsafe int Width
        {
            get => (int)Size.X;
            set
            {
                _size.X = value;

                Glfw.SetWindowSize(WindowPtr, value, (int)_size.Y);
            }
        }

        /// <inheritdoc />
        public unsafe int Height
        {
            get => (int)Size.Y;
            set
            {
                _size.Y = value;

                Glfw.SetWindowSize(WindowPtr, (int)_size.Y, value);
            }
        }

        /// <inheritdoc />
        public Box2 ClientRectangle
        {
            get => Box2.FromDimensions(Location, Size);
            set
            {
                Location = new Vector2(value.Right, value.Top);
                Size = new Vector2(value.Width, value.Height);
            }
        }

        /// <inheritdoc />
        public Vector2 ClientSize { get; }

        private MouseCursor _cursor;

        /// <inheritdoc />
        public bool IsFullscreen { get; set; }

        /// <inheritdoc />
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
                            var cursorImg = new GraphicsLibraryFramework.Image(value.Width, value.Height, (IntPtr)ptr);
                            var cursor = Glfw.CreateCursor(&cursorImg, value.X, value.Y);
                            Glfw.SetCursor(WindowPtr, cursor);
                        }
                    }
                }
            }
        }

        /// <inheritdoc />
        public unsafe bool CursorVisible
        {
            get
            {
                var inputMode = Glfw.GetInputMode(WindowPtr, CursorStateAttribute.Cursor);
                return inputMode != CursorModeValue.CursorHidden
                       && inputMode != CursorModeValue.CursorDisabled;
            }

            set =>
                Glfw.SetInputMode
                (
                    WindowPtr,
                    CursorStateAttribute.Cursor,
                    value ? CursorModeValue.CursorNormal : CursorModeValue.CursorHidden
                );
        }

        /// <inheritdoc />
        public unsafe bool CursorGrabbed
        {
            get => Glfw.GetInputMode(WindowPtr, CursorStateAttribute.Cursor) == CursorModeValue.CursorDisabled;
            set
            {
                if (value)
                {
                    Glfw.SetInputMode(WindowPtr, CursorStateAttribute.Cursor, CursorModeValue.CursorDisabled);
                }
                else if (CursorVisible)
                {
                    Glfw.SetInputMode(WindowPtr, CursorStateAttribute.Cursor, CursorModeValue.CursorNormal);
                }
                else
                {
                    Glfw.SetInputMode(WindowPtr, CursorStateAttribute.Cursor, CursorModeValue.CursorHidden);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NativeWindow"/> class.
        /// </summary>
        /// <param name="settings">The <see cref="INativeWindow"/> related settings.</param>
        public NativeWindow(INativeWindowProperties settings)
        {
            _title = settings.Title;

            unsafe
            {
                _currentMonitor = settings.CurrentMonitor;

                switch (settings.WindowBorder)
                {
                    case WindowBorder.Hidden:
                        Glfw.WindowHint(WindowHintBool.Decorated, false);
                        break;

                    case WindowBorder.Resizable:
                        Glfw.WindowHint(WindowHintBool.Resizable, true);
                        break;

                    case WindowBorder.Fixed:
                        Glfw.WindowHint(WindowHintBool.Resizable, false);
                        break;
                }

                Glfw.WindowHint(WindowHintBool.Focused, settings.IsFocused);
                _windowBorder = settings.WindowBorder;

                if (settings.WindowState == WindowState.Fullscreen)
                {
                    var monitor = settings.CurrentMonitor.ToUnsafePtr<GraphicsLibraryFramework.Monitor>();
                    var modePtr = Glfw.GetVideoMode(monitor);
                    Glfw.WindowHint(WindowHintInt.RedBits, modePtr->RedBits);
                    Glfw.WindowHint(WindowHintInt.GreenBits, modePtr->GreenBits);
                    Glfw.WindowHint(WindowHintInt.BlueBits, modePtr->BlueBits);
                    Glfw.WindowHint(WindowHintInt.RefreshRate, modePtr->RefreshRate);
                    WindowPtr = Glfw.CreateWindow(modePtr->Width, modePtr->Height, _title, monitor, null);
                }
                else
                {
                    WindowPtr = Glfw.CreateWindow(settings.Width, settings.Height, _title, null, null);
                }

                RegisterWindowCallbacks();

                IsFocused = settings.IsFocused;
                IsVisible = settings.IsVisible;
                WindowState = settings.WindowState;

                IsEventDriven = settings.IsEventDriven;

                Location = settings.Location;

                Glfw.GetFramebufferSize(WindowPtr, out var width, out var height);
                ClientSize = new Vector2(width, height);
            }

            Interlocked.Increment(ref _numberOfUsers);
        }

        private GLFWCallbacks.WindowPosCallback _posCallback;
        private GLFWCallbacks.WindowSizeCallback _sizeCallback;
        private GLFWCallbacks.WindowCloseCallback _closeCallback;
        private GLFWCallbacks.WindowIconifyCallback _iconifyCallback;
        private GLFWCallbacks.WindowFocusCallback _focusCallback;
        private GLFWCallbacks.CharCallback _charCallback;
        private GLFWCallbacks.KeyCallback _keyCallback;
        private GLFWCallbacks.CursorEnterCallback _cursorEnterCallback;
        private GLFWCallbacks.MouseButtonCallback _mouseButtonCallback;
        private GLFWCallbacks.CursorPosCallback _cursorPosCallback;
        private GLFWCallbacks.ScrollCallback _scrollCallback;
        private GLFWCallbacks.DropCallback _dropCallback;
        private GLFWCallbacks.CharModsCallback _charModsCallback;
        private GLFWCallbacks.JoystickCallback _joystickCallback;
        private GLFWCallbacks.MonitorCallback _monitorCallback;

        private void RegisterWindowCallbacks()
        {
            unsafe
            {
                _posCallback = (window, x, y) => OnMove(this, new WindowPositionEventArgs(x, y));
                Glfw.SetWindowPosCallback(WindowPtr, _posCallback);

                _sizeCallback = (window, width, height) => OnResize(this, new ResizeEventArgs(width, height));
                Glfw.SetWindowSizeCallback(WindowPtr, _sizeCallback);

                _closeCallback = window => OnClosing(this, new CancelEventArgs());
                Glfw.SetWindowCloseCallback(WindowPtr, _closeCallback);

                _iconifyCallback = (window, iconified) => OnIconChanged(this, new MinimizedEventArgs(iconified));
                Glfw.SetWindowIconifyCallback(WindowPtr, _iconifyCallback);

                _focusCallback = (window, focused) => OnFocusedChanged(this, new FocusedChangedEventArgs(focused));
                Glfw.SetWindowFocusCallback(WindowPtr, _focusCallback);

                _charCallback = (window, codepoint) => OnKeyPress(this, new KeyPressEventArgs((char)codepoint));
                Glfw.SetCharCallback(WindowPtr, _charCallback);

                _keyCallback = (window, key, scancode, action, mods) =>
                {
                    var args = new KeyboardKeyEventArgs
                    {
                        Key = (Key)key,
                        ScanCode = scancode,
                        IsRepeat = action == InputAction.Repeat,
                        Modifiers = (KeyModifiers)mods
                    };

                    if (action == InputAction.Release)
                    {
                        OnKeyUp(this, args);
                    }
                    else
                    {
                        OnKeyDown(this, args);
                    }
                };
                Glfw.SetKeyCallback(WindowPtr, _keyCallback);

                _cursorEnterCallback = (window, entered) =>
                {
                    if (entered)
                    {
                        OnMouseEnter(this, EventArgs.Empty);
                    }
                    else
                    {
                        OnMouseLeave(this, EventArgs.Empty);
                    }
                };
                Glfw.SetCursorEnterCallback(WindowPtr, _cursorEnterCallback);

                _mouseButtonCallback = (window, button, action, mods) =>
                {
                    var args = new MouseButtonEventArgs
                    {
                        Button = (MouseButton)button,
                        Action = (Common.InputAction)action,
                        Modifiers = (KeyModifiers)mods,
                    };

                    if (action == InputAction.Release)
                    {
                        OnMouseUp(this, args);
                    }
                    else
                    {
                        OnMouseDown(this, args);
                    }
                };
                Glfw.SetMouseButtonCallback(WindowPtr, _mouseButtonCallback);

                _cursorPosCallback = (window, xpos, ypos) =>
                {
                    var deltaX = _lastMousePositionX - xpos;
                    var deltaY = _lastMousePositionY - ypos;

                    OnMouseMove(this, new MouseMoveEventArgs(xpos, ypos, deltaX, deltaY));

                    _lastMousePositionX = xpos;
                    _lastMousePositionY = ypos;
                };
                Glfw.SetCursorPosCallback(WindowPtr, _cursorPosCallback);

                _scrollCallback = (window, offsetX, offsetY) =>
                    OnMouseWheel(this, new MouseWheelEventArgs(offsetX, offsetY));
                Glfw.SetScrollCallback(WindowPtr, _scrollCallback);

                _dropCallback = (window, count, paths) =>
                {
                    var pathsStrings = (char**)paths;

                    var arrayOfPaths = new string[count];

                    for (var i = 0; i < count; i++)
                    {
                        if (pathsStrings != null)
                        {
                            arrayOfPaths[i] = new string(pathsStrings[i]);
                        }
                    }

                    OnFileDrop(this, new FileDropEventArgs(arrayOfPaths));
                };
                Glfw.SetDropCallback(WindowPtr, _dropCallback);

                _charModsCallback = (window, codepoint, mods) =>
                {
                    OnKeyboardCharMod(this, new KeyboardCharModEventArgs(codepoint, (KeyModifiers)mods));
                };
                Glfw.SetCharModsCallback(WindowPtr, _charModsCallback);

                _joystickCallback = (joy, eventCode) =>
                {
                    OnJoystickConnected(this, new JoystickEventArgs(joy, eventCode == ConnectedState.Connected));
                };
                Glfw.SetJoystickCallback(_joystickCallback);

                _monitorCallback = (monitor, eventCode) =>
                {
                    OnMonitorConnected(this, new MonitorEventArgs(new Monitor((IntPtr)monitor), eventCode == ConnectedState.Connected));
                };
                Glfw.SetMonitorCallback(_monitorCallback);
            }
        }

        /// <inheritdoc />
        public virtual void Close()
        {
            unsafe
            {
                Glfw.SetWindowShouldClose(WindowPtr, true);
                OnClosed(this, EventArgs.Empty);
            }
        }

        /// <inheritdoc />
        public void MakeCurrent()
        {
            unsafe
            {
                Glfw.MakeContextCurrent(WindowPtr);
            }
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public Vector2 PointToClient(Vector2 point)
        {
            return point - Location;
        }

        /// <inheritdoc />
        public Vector2 PointToScreen(Vector2 point)
        {
            return point + Location;
        }

        /// <inheritdoc />
        public event EventHandler<WindowPositionEventArgs> Move;

        /// <inheritdoc />
        public event EventHandler<ResizeEventArgs> Resize;

        /// <inheritdoc />
        public event EventHandler<CancelEventArgs> Closing;

        /// <inheritdoc />
        public event EventHandler<EventArgs> Closed;

        /// <inheritdoc />
        public event EventHandler<EventArgs> Disposed;

        /// <inheritdoc />
        public event EventHandler<MinimizedEventArgs> Iconified;

        /// <inheritdoc />
        public event EventHandler<EventArgs> IconChanged;

        /// <inheritdoc />
        public event EventHandler<JoystickEventArgs> JoystickConnected;

        /// <inheritdoc />
        public event EventHandler<TitleChangedEventArgs> TitleChanged;

        /// <inheritdoc />
        public event EventHandler<VisibilityChangedEventArgs> VisibleChanged;

        /// <inheritdoc />
        public event EventHandler<FocusedChangedEventArgs> FocusedChanged;

        /// <inheritdoc />
        public event EventHandler<EventArgs> WindowBorderChanged;

        /// <inheritdoc />
        public event EventHandler<EventArgs> WindowStateChanged;

        /// <inheritdoc />
        public event EventHandler<KeyboardKeyEventArgs> KeyDown;

        /// <inheritdoc />
        public event EventHandler<KeyPressEventArgs> KeyPress;

        /// <inheritdoc />
        public event EventHandler<KeyboardCharModEventArgs> KeyboardCharMod;

        /// <inheritdoc />
        public event EventHandler<KeyboardKeyEventArgs> KeyUp;

        /// <inheritdoc />
        public event EventHandler<MonitorEventArgs> MonitorConnected;

        /// <inheritdoc />
        public event EventHandler<EventArgs> MouseLeave;

        /// <inheritdoc />
        public event EventHandler<EventArgs> MouseEnter;

        /// <inheritdoc />
        public event EventHandler<MouseButtonEventArgs> MouseDown;

        /// <inheritdoc />
        public event EventHandler<MouseButtonEventArgs> MouseUp;

        /// <inheritdoc />
        public event EventHandler<MouseMoveEventArgs> MouseMove;

        /// <inheritdoc />
        public event EventHandler<MouseWheelEventArgs> MouseWheel;

        /// <inheritdoc />
        public event EventHandler<FileDropEventArgs> FileDrop;

        /// <summary>
        /// Raises the <see cref="Move"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="WindowPositionEventArgs"/> that contains the event data.</param>
        protected virtual void OnMove(object sender, WindowPositionEventArgs e)
        {
            Move?.Invoke(sender, e);

            _location.X = e.X;
            _location.Y = e.Y;
        }

        /// <summary>
        /// Raises the <see cref="Resize"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="ResizeEventArgs"/> that contains the event data.</param>
        protected virtual void OnResize(object sender, ResizeEventArgs e)
        {
            Resize?.Invoke(sender, e);

            _size.X = e.Width;
            _size.Y = e.Height;
        }

        /// <summary>
        /// Raises the <see cref="Closing"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="CancelEventArgs"/> that contains the event data.</param>
        protected virtual void OnClosing(object sender, CancelEventArgs e)
        {
            Closing?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="Closed"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
        protected virtual void OnClosed(object sender, EventArgs e)
        {
            Closed?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="Disposed"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
        protected virtual void OnDisposed(object sender, EventArgs e)
        {
            Disposed?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="IconChanged"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
        protected virtual void OnIconChanged(object sender, EventArgs e)
        {
            IconChanged?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="JoystickConnected"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="JoystickEventArgs"/> that contains the event data.</param>
        protected virtual void OnJoystickConnected(object sender, JoystickEventArgs e)
        {
            JoystickConnected?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="TitleChanged"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="TitleChangedEventArgs"/> that contains the event data.</param>
        protected virtual void OnTitleChanged(object sender, TitleChangedEventArgs e)
        {
            TitleChanged?.Invoke(sender, e);

            _title = e.Title;
        }

        /// <summary>
        /// Raises the <see cref="VisibleChanged"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="VisibilityChangedEventArgs"/> that contains the event data.</param>
        protected virtual void OnVisibleChanged(object sender, VisibilityChangedEventArgs e)
        {
            VisibleChanged?.Invoke(sender, e);

            _isVisible = e.IsVisible;
        }

        /// <summary>
        /// Raises the <see cref="FocusedChanged"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="FocusedChangedEventArgs"/> that contains the event data.</param>
        protected virtual void OnFocusedChanged(object sender, FocusedChangedEventArgs e)
        {
            FocusedChanged?.Invoke(sender, e);

            _isFocused = e.IsFocused;
        }

        /// <summary>
        /// Raises the <see cref="WindowBorderChanged"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
        protected virtual void OnWindowBorderChanged(object sender, EventArgs e)
        {
            WindowBorderChanged?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="WindowStateChanged"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
        protected virtual void OnWindowStateChanged(object sender, EventArgs e)
        {
            WindowStateChanged?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="KeyDown"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="KeyboardKeyEventArgs"/> that contains the event data.</param>
        protected virtual void OnKeyDown(object sender, KeyboardKeyEventArgs e)
        {
            KeyDown?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="KeyPress"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="KeyPressEventArgs"/> that contains the event data.</param>
        protected virtual void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="KeyboardCharMod"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="KeyboardCharModEventArgs"/> that contains the event data.</param>
        protected virtual void OnKeyboardCharMod(object sender, KeyboardCharModEventArgs e)
        {
            KeyboardCharMod?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="KeyUp"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="KeyboardKeyEventArgs"/> that contains the event data.</param>
        protected virtual void OnKeyUp(object sender, KeyboardKeyEventArgs e)
        {
            KeyUp?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="MonitorConnected"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="MonitorEventArgs"/> that contains the event data.</param>
        protected virtual void OnMonitorConnected(object sender, MonitorEventArgs e)
        {
            MonitorConnected?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="MouseLeave"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
        protected virtual void OnMouseLeave(object sender, EventArgs e)
        {
            MouseLeave?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="MouseEnter"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
        protected virtual void OnMouseEnter(object sender, EventArgs e)
        {
            MouseEnter?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="MouseDown"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="MouseButtonEventArgs"/> that contains the event data.</param>
        protected virtual void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MouseDown?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="MouseUp"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="MouseButtonEventArgs"/> that contains the event data.</param>
        protected virtual void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            MouseUp?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="MouseMove"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="MouseMoveEventArgs"/> that contains the event data.</param>
        protected virtual void OnMouseMove(object sender, MouseMoveEventArgs e)
        {
            MouseMove?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="MouseWheel"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="MouseWheelEventArgs"/> that contains the event data.</param>
        protected virtual void OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
            MouseWheel?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="OnIconified"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="MouseWheelEventArgs"/> that contains the event data.</param>
        protected virtual void OnIconified(object sender, MinimizedEventArgs e)
        {
            Iconified?.Invoke(sender, e);
        }

        /// <summary>
        /// Raises the <see cref="FileDrop"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="FileDropEventArgs"/> that contains the event data.</param>
        protected virtual void OnFileDrop(object sender, FileDropEventArgs e)
        {
            FileDrop?.Invoke(sender, e);
        }

        private bool _disposedValue; // To detect redundant calls

        /// <inheritdoc cref="IDisposable.Dispose" />
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

            // Unloading twice impossible if no one did e.g. multiple disposes.
            if (Interlocked.Decrement(ref _numberOfUsers) <= 0)
            {
                GLFWProvider.Unload();
            }
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="NativeWindow"/> class.
        /// </summary>
        ~NativeWindow()
        {
            Dispose(false);
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
