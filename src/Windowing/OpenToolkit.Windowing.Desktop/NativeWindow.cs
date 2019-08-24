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
using GlfwKeyModifiers = OpenToolkit.GraphicsLibraryFramework.KeyModifiers;
using InputAction = OpenToolkit.GraphicsLibraryFramework.InputAction;
using KeyModifiers = OpenToolkit.Windowing.Common.Input.KeyModifiers;
using Monitor = OpenToolkit.Windowing.Common.Monitor;
using MouseButton = OpenToolkit.Windowing.Common.Input.MouseButton;

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

        // Used for delta calculation in the mouse pos changed event.
        private Vector2 _lastReportedMousePos;

        private KeyboardState _keyboardState = default;

        /// <inheritdoc />
        public KeyboardState KeyboardState => _keyboardState;

        /// <inheritdoc />
        public KeyboardState LastKeyboardState { get; private set; }

        private JoystickState[] _joystickStates = new JoystickState[16];

        /// <inheritdoc/>
        public JoystickState[] JoystickStates { get => _joystickStates; }

        /// <inheritdoc/>
        public JoystickState[] LastJoystickStates { get; private set; }

        /// <inheritdoc />
        public Vector2 MousePosition
        {
            get => _mouseState.Position;
            set
            {
                unsafe
                {
                    Glfw.SetCursorPos(WindowPtr, value.X, value.Y);
                }

                _mouseState.Position = value;
            }
        }

        private MouseState _mouseState = default;

        /// <inheritdoc />
        public Vector2 MouseDelta { get; private set; }

        /// <inheritdoc />
        public MouseState MouseState => _mouseState;

        /// <inheritdoc />
        public MouseState LastMouseState { get; private set; }

        /// <inheritdoc />
        public bool IsAnyKeyDown => _keyboardState.IsAnyKeyDown;

        /// <inheritdoc />
        public bool IsAnyMouseButtonDown => _mouseState.IsAnyButtonDown;

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

        /// <inheritdoc />
        public ContextAPI API { get; }

        /// <inheritdoc />
        public ContextProfile Profile { get; }

        /// <inheritdoc />
        public ContextFlags Flags { get; }

        /// <inheritdoc />
        public Version APIVersion { get; }

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
                Glfw.SetWindowMonitor(
                    WindowPtr,
                    monitor,
                    _location.X,
                    _location.Y,
                    _size.X,
                    _size.Y,
                    mode->RefreshRate);
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
        public bool Exists { get; private set; }

        /// <inheritdoc />
        public bool IsExiting { get; private set; }

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
        public unsafe Box2i Bounds
        {
            get => new Box2i(Location, Location + Size);
            set
            {
                Glfw.SetWindowSize(WindowPtr, (int)value.Size.X, (int)value.Size.Y);
                Glfw.SetWindowPos(WindowPtr, (int)value.Min.X, (int)value.Min.Y);
            }
        }

        private Vector2i _location;

        /// <inheritdoc />
        public unsafe Vector2i Location
        {
            get => _location;
            set => Glfw.SetWindowPos(WindowPtr, value.X, value.Y);
        }

        private Vector2i _size;

        /// <inheritdoc />
        public unsafe Vector2i Size
        {
            get => _size;
            set => Glfw.SetWindowSize(WindowPtr, value.X, value.Y);
        }

        /// <inheritdoc />
        public unsafe int X
        {
            get => Location.X;
            set
            {
                Glfw.SetWindowPos(WindowPtr, value, _location.Y);
            }
        }

        /// <inheritdoc />
        public unsafe int Y
        {
            get => Location.Y;
            set
            {
                Glfw.SetWindowPos(WindowPtr, _location.X, value);
            }
        }

        /// <inheritdoc />
        public unsafe int Width
        {
            get => Size.X;
            set
            {
                Glfw.SetWindowSize(WindowPtr, value, _size.Y);
            }
        }

        /// <inheritdoc />
        public unsafe int Height
        {
            get => Size.Y;
            set
            {
                Glfw.SetWindowSize(WindowPtr, _size.X, value);
            }
        }

        /// <inheritdoc />
        public Box2i ClientRectangle
        {
            get => new Box2i(Location, Location + Size);
            set
            {
                Location = value.Min;
                Size = value.Size;
            }
        }

        /// <inheritdoc />
        public Vector2i ClientSize { get; }

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
                Glfw.SetInputMode(
                    WindowPtr,
                    CursorStateAttribute.Cursor,
                    value ? CursorModeValue.CursorNormal : CursorModeValue.CursorHidden);
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
            if (!GLFWProvider.IsOnMainThread)
            {
                throw new GLFWException("Can only create windows on the Glfw main thread. (Thread from which Glfw was first created).");
            }

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

                var makeContextCurrent = false;
                switch (settings.API)
                {
                    case ContextAPI.NoAPI:
                        Glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.NoApi);
                        break;

                    case ContextAPI.OpenGLES:
                        Glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGlEsApi);
                        makeContextCurrent = true;
                        break;

                    case ContextAPI.OpenGL:
                        Glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGlApi);
                        makeContextCurrent = true;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Glfw.WindowHint(WindowHintInt.ContextVersionMajor, settings.APIVersion.Major);
                Glfw.WindowHint(WindowHintInt.ContextVersionMinor, settings.APIVersion.Minor);

                if (settings.Flags.HasFlag(ContextFlags.ForwardCompatible))
                {
                    Glfw.WindowHint(WindowHintBool.OpenGLForwardCompat, true);
                }

                if (settings.Flags.HasFlag(ContextFlags.Debug))
                {
                    Glfw.WindowHint(WindowHintBool.OpenGLDebugContext, true);
                }

                switch (settings.Profile)
                {
                    case ContextProfile.Compatability:
                        Glfw.WindowHint(WindowHintOpenGlProfile.OpenGlProfile, OpenGlProfile.Compat);
                        break;
                    case ContextProfile.Core:
                        Glfw.WindowHint(WindowHintOpenGlProfile.OpenGlProfile, OpenGlProfile.Core);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
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

                Exists = true;

                if (makeContextCurrent)
                {
                    Glfw.MakeContextCurrent(WindowPtr);
                }

                RegisterWindowCallbacks();

                IsFocused = settings.IsFocused;
                IsVisible = settings.IsVisible;
                WindowState = settings.WindowState;

                IsEventDriven = settings.IsEventDriven;

                Location = settings.Location;

                Glfw.GetFramebufferSize(WindowPtr, out var width, out var height);
                ClientSize = new Vector2i(width, height);

                Glfw.GetWindowSize(WindowPtr, out width, out height);
                _size = new Vector2i(width, height);

                Glfw.GetWindowPos(WindowPtr, out var x, out var y);
                _location = new Vector2i(x, y);
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
        private GLFWCallbacks.JoystickCallback _joystickCallback;
        private GLFWCallbacks.MonitorCallback _monitorCallback;
        private GLFWCallbacks.WindowRefreshCallback _refreshCallback;

        private void RegisterWindowCallbacks()
        {
            unsafe
            {
                _posCallback = (window, x, y) => OnMove(this, new WindowPositionEventArgs(x, y));
                Glfw.SetWindowPosCallback(WindowPtr, _posCallback);

                _sizeCallback = (window, width, height) => OnResize(this, new ResizeEventArgs(width, height));
                Glfw.SetWindowSizeCallback(WindowPtr, _sizeCallback);

                _closeCallback = OnCloseCallback;
                Glfw.SetWindowCloseCallback(WindowPtr, _closeCallback);

                _iconifyCallback = (window, iconified) => OnMinimized(this, new MinimizedEventArgs(iconified));
                Glfw.SetWindowIconifyCallback(WindowPtr, _iconifyCallback);

                _focusCallback = (window, focused) => OnFocusedChanged(this, new FocusedChangedEventArgs(focused));
                Glfw.SetWindowFocusCallback(WindowPtr, _focusCallback);

                _charCallback = (window, codepoint) => OnTextInput(this, new TextInputEventArgs((int)codepoint));
                Glfw.SetCharCallback(WindowPtr, _charCallback);

                _keyCallback = (window, key, scancode, action, mods) =>
                {
                    var ourKey = GlfwKeyMapping[(int)key];

                    var args = new KeyboardKeyEventArgs(
                        ourKey,
                        scancode,
                        MapGlfwKeyModifiers(mods),
                        action == InputAction.Repeat);

                    if (action == InputAction.Release)
                    {
                        if (ourKey != Key.Unknown)
                        {
                            _keyboardState.SetKeyState(ourKey, false);
                        }

                        OnKeyUp(this, args);
                    }
                    else
                    {
                        if (ourKey != Key.Unknown)
                        {
                            _keyboardState.SetKeyState(ourKey, true);
                        }

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
                    var ourButton = (MouseButton)button;
                    var args = new MouseButtonEventArgs(
                        ourButton,
                        MapGlfwInputAction(action),
                        MapGlfwKeyModifiers(mods));

                    if (action == InputAction.Release)
                    {
                        _mouseState[ourButton] = false;
                        OnMouseUp(this, args);
                    }
                    else
                    {
                        _mouseState[ourButton] = true;
                        OnMouseDown(this, args);
                    }
                };
                Glfw.SetMouseButtonCallback(WindowPtr, _mouseButtonCallback);

                _cursorPosCallback = (window, posX, posY) =>
                {
                    var newPos = new Vector2((float)posX, (float)posY);
                    var delta = _lastReportedMousePos - newPos;

                    MouseDelta += delta;

                    _lastReportedMousePos = _mouseState.Position = newPos;

                    OnMouseMove(this, new MouseMoveEventArgs(newPos, delta));
                };
                Glfw.SetCursorPosCallback(WindowPtr, _cursorPosCallback);

                _scrollCallback = (window, offsetX, offsetY) =>
                    OnMouseWheel(this, new MouseWheelEventArgs((float)offsetX, (float)offsetY));
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

                _joystickCallback = (joy, eventCode) =>
                {
                    if (eventCode == ConnectedState.Connected)
                    {
                        // Initialize the first joystick state.
                        int hatCount = 0;
                        Glfw.GetJoystickHats(joy, out hatCount);
                        int axisCount = 0;
                        Glfw.GetJoystickAxes(joy, out hatCount);
                        int buttonCount = 0;
                        Glfw.GetJoystickButtons(joy, out buttonCount);
                        string name = Glfw.GetJoystickName(joy);

                        JoystickStates[joy] = new JoystickState(hatCount, axisCount, buttonCount, joy, name);
                    }
                    else
                    {
                        // Remove the joystick state from the array of joysticks.
                        JoystickStates[joy] = default;
                    }
                    OnJoystickConnected(this, new JoystickEventArgs(joy, eventCode == ConnectedState.Connected));
                };
                Glfw.SetJoystickCallback(_joystickCallback);

                _monitorCallback = (monitor, eventCode) =>
                {
                    OnMonitorConnected(this, new MonitorEventArgs(new Monitor((IntPtr)monitor), eventCode == ConnectedState.Connected));
                };
                Glfw.SetMonitorCallback(_monitorCallback);

                _refreshCallback = (window) => OnRefresh(this, EventArgs.Empty);
                Glfw.SetWindowRefreshCallback(WindowPtr, _refreshCallback);
            }
        }

        private unsafe void OnCloseCallback(Window* window)
        {
            var c = new CancelEventArgs();
            OnClosing(this, c);
            if (c.Cancel)
            {
                Glfw.SetWindowShouldClose(WindowPtr, false);
            }
            else
            {
                IsExiting = true;
            }
        }

        /// <inheritdoc />
        public virtual void Close()
        {
            unsafe
            {
                OnCloseCallback(WindowPtr);
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

        private unsafe void DestroyWindow()
        {
            if (Exists)
            {
                Exists = false;
                Glfw.DestroyWindow(WindowPtr);

                OnClosed(this, EventArgs.Empty);
            }
        }

        private bool PreProcessEvents()
        {
            LastKeyboardState = KeyboardState;
            LastMouseState = MouseState;
            LastJoystickStates = JoystickStates;
            MouseDelta = Vector2.Zero;

            if (IsExiting)
            {
                DestroyWindow();
                return false;
            }

            return true;
        }

        /// <inheritdoc />
        public bool ProcessEvents(double timeout)
        {
            if (!PreProcessEvents())
            {
                return false;
            }

            Glfw.WaitEventsTimeout(timeout);
            ProcessInputEvents();

            return true;
        }

        /// <inheritdoc />
        public virtual void ProcessEvents()
        {
            if (!PreProcessEvents())
            {
                return;
            }

            if (IsEventDriven)
            {
                Glfw.WaitEvents();
            }
            else
            {
                Glfw.PollEvents();
            }

            ProcessInputEvents();
        }

        private unsafe void ProcessInputEvents()
        {
            Glfw.GetCursorPos(WindowPtr, out var x, out var y);
            _mouseState.Position = new Vector2((float)x, (float)y);

            for (int i = 0; i < JoystickStates.Length; i++)
            {
                JoystickState joy = JoystickStates[i];
                if (joy == default)
                {
                    continue;
                }

                int count = 0;

                var h = Glfw.GetJoystickHats(joy.Id, out count);
                Hat[] hats = new Hat[count];
                for (int j = 0; j < count; j++)
                {
                    hats[j] = (Hat)h[j];
                }

                var a = Glfw.GetJoystickAxes(joy.Id, out count);
                float[] axes = new float[count];
                for (int j = 0; j < count; j++)
                {
                    axes[j] = a[j];
                }

                var b = Glfw.GetJoystickButtons(joy.Id, out count);
                var buttons = new bool[count];
                for (int j = 0; j < buttons.Length; j++)
                {
                    buttons[j] = b[j] == 1;
                }

                JoystickStates[i] = new JoystickState(hats, axes, buttons, joy.Id, joy.Name);
            }
        }

        /// <inheritdoc />
        public Vector2i PointToClient(Vector2i point)
        {
            return point - Location;
        }

        /// <inheritdoc />
        public Vector2i PointToScreen(Vector2i point)
        {
            return point + Location;
        }

        /// <inheritdoc />
        public event EventHandler<WindowPositionEventArgs> Move;

        /// <inheritdoc />
        public event EventHandler<ResizeEventArgs> Resize;

        /// <inheritdoc />
        public event EventHandler<EventArgs> Refresh;

        /// <inheritdoc />
        public event EventHandler<CancelEventArgs> Closing;

        /// <inheritdoc />
        public event EventHandler<EventArgs> Closed;

        /// <inheritdoc />
        public event EventHandler<EventArgs> Disposed;

        /// <inheritdoc />
        public event EventHandler<MinimizedEventArgs> Minimized;

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
        public event EventHandler<TextInputEventArgs> TextInput;

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

        /// <inheritdoc />
        public bool IsKeyDown(Key key)
        {
            return _keyboardState.IsKeyDown(key);
        }

        /// <inheritdoc />
        public bool IsKeyUp(Key key)
        {
            return _keyboardState.IsKeyUp(key);
        }

        /// <inheritdoc />
        public bool IsKeyPressed(Key key)
        {
            return _keyboardState.IsKeyDown(key) && !LastKeyboardState.IsKeyDown(key);
        }

        /// <inheritdoc />
        public bool IsKeyReleased(Key key)
        {
            return !_keyboardState.IsKeyDown(key) && LastKeyboardState.IsKeyDown(key);
        }

        /// <inheritdoc />
        public bool IsMouseButtonDown(MouseButton button)
        {
            return _mouseState.IsButtonDown(button);
        }

        /// <inheritdoc />
        public bool IsMouseButtonUp(MouseButton button)
        {
            return _mouseState.IsButtonUp(button);
        }

        /// <inheritdoc />
        public bool IsMouseButtonPressed(MouseButton button)
        {
            return _mouseState.IsButtonDown(button) && !LastMouseState.IsButtonDown(button);
        }

        /// <inheritdoc />
        public bool IsMouseButtonReleased(MouseButton button)
        {
            return !_mouseState.IsButtonDown(button) && LastMouseState.IsButtonDown(button);
        }

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
        /// Raises the <see cref="Refresh"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="EventArgs"/> that contains the event data.</param>
        protected virtual void OnRefresh(object sender, EventArgs e)
        {
            Refresh?.Invoke(sender, e);
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
        /// Raises the <see cref="TextInput"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="TextInputEventArgs"/> that contains the event data.</param>
        protected virtual void OnTextInput(object sender, TextInputEventArgs e)
        {
            TextInput?.Invoke(sender, e);
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
        /// Raises the <see cref="OnMinimized"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="MouseWheelEventArgs"/> that contains the event data.</param>
        protected virtual void OnMinimized(object sender, MinimizedEventArgs e)
        {
            Minimized?.Invoke(sender, e);
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
            if (_disposedValue)
            {
                return;
            }

            if (disposing)
            {
            }

            // Free unmanaged resources
            DestroyWindow();

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

        // Maps GLFW's key enum to our key enum.
        // There's a few gaps here and there since this is a direct array.
        // Those default to Unknown.
        private static readonly Key[] GlfwKeyMapping = GenerateGlfwKeyMapping();

        private static Key[] GenerateGlfwKeyMapping()
        {
            var map = new Key[(int)Keys.LastKey + 1];
            map[(int)Keys.Space] = Key.Space;
            map[(int)Keys.Apostrophe] = Key.Quote;
            map[(int)Keys.Comma] = Key.Comma;
            map[(int)Keys.Minus] = Key.Minus;
            map[(int)Keys.Period] = Key.Period;
            map[(int)Keys.Slash] = Key.Slash;
            map[(int)Keys.D0] = Key.Number0;
            map[(int)Keys.D1] = Key.Number1;
            map[(int)Keys.D2] = Key.Number2;
            map[(int)Keys.D3] = Key.Number3;
            map[(int)Keys.D4] = Key.Number4;
            map[(int)Keys.D5] = Key.Number5;
            map[(int)Keys.D6] = Key.Number6;
            map[(int)Keys.D7] = Key.Number7;
            map[(int)Keys.D8] = Key.Number8;
            map[(int)Keys.D9] = Key.Number9;
            map[(int)Keys.Semicolon] = Key.Semicolon;
            map[(int)Keys.Equal] = Key.Plus;
            map[(int)Keys.A] = Key.A;
            map[(int)Keys.B] = Key.B;
            map[(int)Keys.C] = Key.C;
            map[(int)Keys.D] = Key.D;
            map[(int)Keys.E] = Key.E;
            map[(int)Keys.F] = Key.F;
            map[(int)Keys.G] = Key.G;
            map[(int)Keys.H] = Key.H;
            map[(int)Keys.I] = Key.I;
            map[(int)Keys.J] = Key.J;
            map[(int)Keys.K] = Key.K;
            map[(int)Keys.L] = Key.L;
            map[(int)Keys.M] = Key.M;
            map[(int)Keys.N] = Key.N;
            map[(int)Keys.O] = Key.O;
            map[(int)Keys.P] = Key.P;
            map[(int)Keys.Q] = Key.Q;
            map[(int)Keys.R] = Key.R;
            map[(int)Keys.S] = Key.S;
            map[(int)Keys.T] = Key.T;
            map[(int)Keys.U] = Key.U;
            map[(int)Keys.V] = Key.V;
            map[(int)Keys.W] = Key.W;
            map[(int)Keys.X] = Key.X;
            map[(int)Keys.Y] = Key.Y;
            map[(int)Keys.Z] = Key.Z;
            map[(int)Keys.LeftBracket] = Key.BracketLeft;
            map[(int)Keys.Backslash] = Key.BackSlash;
            map[(int)Keys.RightBracket] = Key.BracketRight;
            map[(int)Keys.GraveAccent] = Key.Grave;

            // TODO: What are these world keys and how do I handle them.
            // map[(int)Keys.World1] = Key.Z;
            // map[(int)Keys.World2] = Key.Z;
            map[(int)Keys.Escape] = Key.Escape;
            map[(int)Keys.Enter] = Key.Enter;
            map[(int)Keys.Tab] = Key.Tab;
            map[(int)Keys.Backspace] = Key.BackSpace;
            map[(int)Keys.Insert] = Key.Insert;
            map[(int)Keys.Delete] = Key.Delete;
            map[(int)Keys.Right] = Key.Right;
            map[(int)Keys.Left] = Key.Left;
            map[(int)Keys.Down] = Key.Down;
            map[(int)Keys.Up] = Key.Up;
            map[(int)Keys.PageUp] = Key.PageUp;
            map[(int)Keys.PageDown] = Key.PageDown;
            map[(int)Keys.Home] = Key.Home;
            map[(int)Keys.End] = Key.End;
            map[(int)Keys.CapsLock] = Key.CapsLock;
            map[(int)Keys.ScrollLock] = Key.ScrollLock;
            map[(int)Keys.NumLock] = Key.NumLock;
            map[(int)Keys.PrintScreen] = Key.PrintScreen;
            map[(int)Keys.Pause] = Key.Pause;
            map[(int)Keys.F1] = Key.F1;
            map[(int)Keys.F2] = Key.F2;
            map[(int)Keys.F3] = Key.F3;
            map[(int)Keys.F4] = Key.F4;
            map[(int)Keys.F5] = Key.F5;
            map[(int)Keys.F6] = Key.F6;
            map[(int)Keys.F7] = Key.F7;
            map[(int)Keys.F8] = Key.F8;
            map[(int)Keys.F9] = Key.F9;
            map[(int)Keys.F10] = Key.F10;
            map[(int)Keys.F11] = Key.F11;
            map[(int)Keys.F12] = Key.F12;
            map[(int)Keys.F13] = Key.F13;
            map[(int)Keys.F14] = Key.F14;
            map[(int)Keys.F15] = Key.F15;
            map[(int)Keys.F16] = Key.F16;
            map[(int)Keys.F17] = Key.F17;
            map[(int)Keys.F18] = Key.F18;
            map[(int)Keys.F19] = Key.F19;
            map[(int)Keys.F20] = Key.F20;
            map[(int)Keys.F21] = Key.F21;
            map[(int)Keys.F22] = Key.F22;
            map[(int)Keys.F23] = Key.F23;
            map[(int)Keys.F24] = Key.F24;
            map[(int)Keys.F25] = Key.F25;
            map[(int)Keys.KeyPad0] = Key.Keypad0;
            map[(int)Keys.KeyPad1] = Key.Keypad1;
            map[(int)Keys.KeyPad2] = Key.Keypad2;
            map[(int)Keys.KeyPad3] = Key.Keypad3;
            map[(int)Keys.KeyPad4] = Key.Keypad4;
            map[(int)Keys.KeyPad5] = Key.Keypad5;
            map[(int)Keys.KeyPad6] = Key.Keypad6;
            map[(int)Keys.KeyPad7] = Key.Keypad7;
            map[(int)Keys.KeyPad8] = Key.Keypad8;
            map[(int)Keys.KeyPad9] = Key.Keypad9;
            map[(int)Keys.KeyPadDecimal] = Key.KeypadDecimal;
            map[(int)Keys.KeyPadDivide] = Key.KeypadDivide;
            map[(int)Keys.KeyPadMultiply] = Key.KeypadMultiply;
            map[(int)Keys.KeyPadSubtract] = Key.KeypadSubtract;
            map[(int)Keys.KeyPadAdd] = Key.KeypadAdd;
            map[(int)Keys.KeyPadEnter] = Key.KeypadEnter;
            map[(int)Keys.KeyPadEqual] = Key.KeypadEqual;
            map[(int)Keys.LeftShift] = Key.ShiftLeft;
            map[(int)Keys.LeftControl] = Key.ControlLeft;
            map[(int)Keys.LeftAlt] = Key.AltLeft;
            map[(int)Keys.LeftSuper] = Key.WinLeft;
            map[(int)Keys.RightShift] = Key.ShiftRight;
            map[(int)Keys.RightControl] = Key.ControlRight;
            map[(int)Keys.RightAlt] = Key.AltRight;
            map[(int)Keys.RightSuper] = Key.WinRight;
            map[(int)Keys.Menu] = Key.Menu;
            return map;
        }

        private static KeyModifiers MapGlfwKeyModifiers(GlfwKeyModifiers modifiers)
        {
            KeyModifiers value = default;

            if (modifiers.HasFlag(GlfwKeyModifiers.Alt))
            {
                value |= KeyModifiers.Alt;
            }

            if (modifiers.HasFlag(GlfwKeyModifiers.Shift))
            {
                value |= KeyModifiers.Shift;
            }

            if (modifiers.HasFlag(GlfwKeyModifiers.Control))
            {
                value |= KeyModifiers.Control;
            }

            if (modifiers.HasFlag(GlfwKeyModifiers.Super))
            {
                value |= KeyModifiers.Command;
            }

            return value;
        }

        private static Common.InputAction MapGlfwInputAction(InputAction action)
        {
            switch (action)
            {
                case InputAction.Release:
                    return Common.InputAction.Release;
                case InputAction.Press:
                    return Common.InputAction.Press;
                case InputAction.Repeat:
                    return Common.InputAction.Repeat;
                default:
                    throw new ArgumentOutOfRangeException(nameof(action), action, null);
            }
        }
    }
}
