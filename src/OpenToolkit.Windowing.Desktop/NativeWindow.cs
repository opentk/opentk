// Copyright (c) OpenTK. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using OpenToolkit.Core;
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.Common.Input;
using OpenToolkit.Windowing.GraphicsLibraryFramework;
using GlfwKeyModifiers = OpenToolkit.Windowing.GraphicsLibraryFramework.KeyModifiers;
using InputAction = OpenToolkit.Windowing.GraphicsLibraryFramework.InputAction;
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
        /// Gets the native <see cref="Window"/> pointer for use with <see cref="GLFW"/> API.
        /// </summary>
        protected unsafe Window* WindowPtr { get; }

        // Used for delta calculation in the mouse pos changed event.
        private Vector2 _lastReportedMousePos;

        private KeyboardState _keyboardState = default;

        // GLFW cursor we assigned to the window.
        // Null if the cursor is default.
        private unsafe Cursor* _glfwCursor;

        // Actual managed cursor instance for the public API.
        // Never null.
        private MouseCursor _managedCursor = MouseCursor.Default;

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
                    GLFW.SetCursorPos(WindowPtr, value.X, value.Y);
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
                    var images = value.Images;
                    Span<GCHandle> handles = stackalloc GCHandle[images.Length];
                    Span<GraphicsLibraryFramework.Image> glfwImages =
                        stackalloc GraphicsLibraryFramework.Image[images.Length];

                    for (var i = 0; i < images.Length; i++)
                    {
                        var image = images[i];
                        handles[i] = GCHandle.Alloc(image.Data, GCHandleType.Pinned);
                        var addrOfPinnedObject = (byte*)handles[i].AddrOfPinnedObject();
                        glfwImages[i] = new GraphicsLibraryFramework.Image(image.Width, image.Height, addrOfPinnedObject);
                    }

                    GLFW.SetWindowIcon(WindowPtr, glfwImages);

                    foreach (var handle in handles)
                    {
                        handle.Free();
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
                    return GLFW.GetClipboardString(WindowPtr);
                }
            }

            set
            {
                unsafe
                {
                    GLFW.SetClipboardString(WindowPtr, value);
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
                    GLFW.SetWindowTitle(WindowPtr, value);
                }
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
                var mode = GLFW.GetVideoMode(monitor);
                GLFW.SetWindowMonitor(
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
                    GLFW.FocusWindow(WindowPtr);
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
                        GLFW.ShowWindow(WindowPtr);
                    }
                    else
                    {
                        GLFW.HideWindow(WindowPtr);
                    }
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
                if (GLFW.GetWindowAttrib(WindowPtr, WindowAttributeGetter.Iconified))
                {
                    return WindowState.Minimized;
                }

                if (GLFW.GetWindowAttrib(WindowPtr, WindowAttributeGetter.Maximized))
                {
                    return WindowState.Maximized;
                }

                if (GLFW.GetWindowMonitor(WindowPtr) != null)
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
                        GLFW.RestoreWindow(WindowPtr);
                        break;
                    case WindowState.Minimized:
                        GLFW.IconifyWindow(WindowPtr);
                        break;
                    case WindowState.Maximized:
                        GLFW.MaximizeWindow(WindowPtr);
                        break;
                    case WindowState.Fullscreen:
                        var monitor = CurrentMonitor.ToUnsafePtr<GraphicsLibraryFramework.Monitor>();
                        var mode = GLFW.GetVideoMode(monitor);
                        GLFW.SetWindowMonitor(WindowPtr, monitor, 0, 0, mode->Width, mode->Height, mode->RefreshRate);
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
                if (!GLFW.GetWindowAttrib(WindowPtr, WindowAttributeGetter.Decorated))
                {
                    GLFW.GetVersion(out var major, out var minor, out _);

                    // It isn't possible to implement this in versions of GLFW older than 3.3,
                    // as SetWindowAttrib didn't exist before then.
                    if ((major == 3) && (minor < 3))
                    {
                        throw new NotSupportedException("Cannot be implemented in GLFW 3.2.");
                    }

                    switch (value)
                    {
                        case WindowBorder.Hidden:
                            GLFW.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Decorated, false);
                            break;

                        case WindowBorder.Resizable:
                            GLFW.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Resizable, true);
                            break;

                        case WindowBorder.Fixed:
                            GLFW.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Resizable, false);
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
                GLFW.SetWindowSize(WindowPtr, (int)value.Size.X, (int)value.Size.Y);
                GLFW.SetWindowPos(WindowPtr, (int)value.Min.X, (int)value.Min.Y);
            }
        }

        private Vector2i _location;

        /// <inheritdoc />
        public unsafe Vector2i Location
        {
            get => _location;
            set => GLFW.SetWindowPos(WindowPtr, value.X, value.Y);
        }

        private Vector2i _size;

        /// <inheritdoc />
        public unsafe Vector2i Size
        {
            get => _size;
            set
            {
                _size = value;
                GLFW.SetWindowSize(WindowPtr, value.X, value.Y);
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
        public Vector2i ClientSize { get; private set; }

        /// <inheritdoc />
        public bool IsFullscreen { get; set; }

        /// <inheritdoc />
        public MouseCursor Cursor
        {
            get => _managedCursor;
            set
            {
                _managedCursor = value ?? throw new ArgumentNullException(
                              nameof(value),
                              "Cursor cannot be null. To reset to default cursor, set it to MouseCursor.Default instead.");

                unsafe
                {
                    var oldCursor = _glfwCursor;
                    _glfwCursor = null;

                    // Create the new GLFW cursor
                    if (value.Shape == MouseCursor.StandardShape.CustomShape)
                    {
                        // User provided mouse cursor.
                        fixed (byte* ptr = value.Data)
                        {
                            var cursorImg = new GraphicsLibraryFramework.Image(value.Width, value.Height, ptr);
                            _glfwCursor = GLFW.CreateCursor(cursorImg, value.X, value.Y);
                        }
                    }

                    // If this is the default cursor, we don't need to run CreateStandardCursor.
                    // GLFW will reset the window to default if we assign null as cursor.
                    else if (value != MouseCursor.Default)
                    {
                        // Standard mouse cursor.
                        _glfwCursor = GLFW.CreateStandardCursor(MapStandardCursorShape(value.Shape));
                    }

                    GLFW.SetCursor(WindowPtr, _glfwCursor);

                    if (oldCursor != null)
                    {
                        // Make sure to destroy the old cursor AFTER assigning the new one.
                        // Otherwise the user might briefly see their OS cursor during the reassignment.
                        GLFW.DestroyCursor(oldCursor);
                    }
                }
            }
        }

        /// <inheritdoc />
        public unsafe bool CursorVisible
        {
            get
            {
                var inputMode = GLFW.GetInputMode(WindowPtr, CursorStateAttribute.Cursor);
                return inputMode != CursorModeValue.CursorHidden
                       && inputMode != CursorModeValue.CursorDisabled;
            }

            set =>
                GLFW.SetInputMode(
                    WindowPtr,
                    CursorStateAttribute.Cursor,
                    value ? CursorModeValue.CursorNormal : CursorModeValue.CursorHidden);
        }

        /// <inheritdoc />
        public unsafe bool CursorGrabbed
        {
            get => GLFW.GetInputMode(WindowPtr, CursorStateAttribute.Cursor) == CursorModeValue.CursorDisabled;
            set
            {
                if (value)
                {
                    GLFW.SetInputMode(WindowPtr, CursorStateAttribute.Cursor, CursorModeValue.CursorDisabled);
                }
                else if (CursorVisible)
                {
                    GLFW.SetInputMode(WindowPtr, CursorStateAttribute.Cursor, CursorModeValue.CursorNormal);
                }
                else
                {
                    GLFW.SetInputMode(WindowPtr, CursorStateAttribute.Cursor, CursorModeValue.CursorHidden);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NativeWindow"/> class.
        /// </summary>
        /// <param name="settings">The <see cref="INativeWindow"/> related settings.</param>
        public unsafe NativeWindow(NativeWindowSettings settings)
        {
            GLFWProvider.EnsureInitialized();
            if (!GLFWProvider.IsOnMainThread)
            {
                throw new GLFWException("Can only create windows on the Glfw main thread. (Thread from which Glfw was first created).");
            }

            _title = settings.Title;

            _currentMonitor = settings.CurrentMonitor;

            switch (settings.WindowBorder)
            {
                case WindowBorder.Hidden:
                    GLFW.WindowHint(WindowHintBool.Decorated, false);
                    break;

                case WindowBorder.Resizable:
                    GLFW.WindowHint(WindowHintBool.Resizable, true);
                    break;

                case WindowBorder.Fixed:
                    GLFW.WindowHint(WindowHintBool.Resizable, false);
                    break;
            }

            var isOpenGl = false;
            switch (settings.API)
            {
                case ContextAPI.NoAPI:
                    GLFW.WindowHint(WindowHintClientApi.ClientApi, ClientApi.NoApi);
                    break;

                case ContextAPI.OpenGLES:
                    GLFW.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGlEsApi);
                    isOpenGl = true;
                    break;

                case ContextAPI.OpenGL:
                    GLFW.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGlApi);
                    isOpenGl = true;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            GLFW.WindowHint(WindowHintInt.ContextVersionMajor, settings.APIVersion.Major);
            GLFW.WindowHint(WindowHintInt.ContextVersionMinor, settings.APIVersion.Minor);

            if (settings.Flags.HasFlag(ContextFlags.ForwardCompatible))
            {
                GLFW.WindowHint(WindowHintBool.OpenGLForwardCompat, true);
            }

            if (settings.Flags.HasFlag(ContextFlags.Debug))
            {
                GLFW.WindowHint(WindowHintBool.OpenGLDebugContext, true);
            }

            switch (settings.Profile)
            {
                case ContextProfile.Any:
                    GLFW.WindowHint(WindowHintOpenGlProfile.OpenGlProfile, OpenGlProfile.Any);
                    break;
                case ContextProfile.Compatability:
                    GLFW.WindowHint(WindowHintOpenGlProfile.OpenGlProfile, OpenGlProfile.Compat);
                    break;
                case ContextProfile.Core:
                    GLFW.WindowHint(WindowHintOpenGlProfile.OpenGlProfile, OpenGlProfile.Core);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            GLFW.WindowHint(WindowHintBool.Focused, settings.StartFocused);
            _windowBorder = settings.WindowBorder;

            _isVisible = settings.StartVisible;
            GLFW.WindowHint(WindowHintBool.Visible, _isVisible);

            if (settings.WindowState == WindowState.Fullscreen)
            {
                var monitor = settings.CurrentMonitor.ToUnsafePtr<GraphicsLibraryFramework.Monitor>();
                var modePtr = GLFW.GetVideoMode(monitor);
                GLFW.WindowHint(WindowHintInt.RedBits, modePtr->RedBits);
                GLFW.WindowHint(WindowHintInt.GreenBits, modePtr->GreenBits);
                GLFW.WindowHint(WindowHintInt.BlueBits, modePtr->BlueBits);
                GLFW.WindowHint(WindowHintInt.RefreshRate, modePtr->RefreshRate);
                WindowPtr = GLFW.CreateWindow(modePtr->Width, modePtr->Height, _title, monitor, null);
            }
            else
            {
                WindowPtr = GLFW.CreateWindow(settings.Size.X, settings.Size.Y, _title, null, null);
            }

            Exists = true;

            if (isOpenGl)
            {
                GLFW.MakeContextCurrent(WindowPtr);

                if (settings.AutoLoadBindings)
                {
                    InitializeGlBindings();
                }
            }

            RegisterWindowCallbacks();

            IsFocused = settings.StartFocused;
            WindowState = settings.WindowState;

            IsEventDriven = settings.IsEventDriven;

            if (settings.Icon != null)
            {
                Icon = settings.Icon;
            }

            if (settings.Location.HasValue)
            {
                Location = settings.Location.Value;
            }

            GLFW.GetWindowSize(WindowPtr, out var width, out var height);

            HandleResize(width, height);

            GLFW.GetWindowPos(WindowPtr, out var x, out var y);
            _location = new Vector2i(x, y);
        }

        private static void InitializeGlBindings()
        {
            // We don't put a hard dependency on OpenToolkit.Graphics here.
            // So we need to use reflection to initialize the GL bindings, so users don't have to.

            // Try to load OpenToolkit.Graphics assembly.
            Assembly assembly;
            try
            {
                assembly = Assembly.Load("OpenToolkit.Graphics");
            }
            catch
            {
                // Failed to load graphics, oh well.
                // Up to the user I guess?
                // TODO: Should we expose this load failure to the user better?
                return;
            }

            var provider = new GLFWBindingsContext();

            void LoadBindings(string typeNamespace)
            {
                var type = assembly.GetType($"OpenToolkit.Graphics.{typeNamespace}.GL");
                if (type == null)
                {
                    return;
                }

                var load = type.GetMethod("LoadBindings");
                load.Invoke(null, new object[] { provider });
            }

            LoadBindings("ES11");
            LoadBindings("ES20");
            LoadBindings("ES30");
            LoadBindings("OpenGL");
            LoadBindings("OpenGL4");
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

        private unsafe void HandleResize(int width, int height)
        {
            _size.X = width;
            _size.Y = height;

            GLFW.GetFramebufferSize(WindowPtr, out width, out height);

            ClientSize = new Vector2i(width, height);
        }

        private void RegisterWindowCallbacks()
        {
            unsafe
            {
                _posCallback = (window, x, y) => OnMove(new WindowPositionEventArgs(x, y));
                GLFW.SetWindowPosCallback(WindowPtr, _posCallback);

                _sizeCallback = (window, width, height) => OnResize(new ResizeEventArgs(width, height));
                GLFW.SetWindowSizeCallback(WindowPtr, _sizeCallback);

                _closeCallback = OnCloseCallback;
                GLFW.SetWindowCloseCallback(WindowPtr, _closeCallback);

                _iconifyCallback = (window, iconified) => OnMinimized(new MinimizedEventArgs(iconified));
                GLFW.SetWindowIconifyCallback(WindowPtr, _iconifyCallback);

                _focusCallback = (window, focused) => OnFocusedChanged(new FocusedChangedEventArgs(focused));
                GLFW.SetWindowFocusCallback(WindowPtr, _focusCallback);

                _charCallback = (window, codepoint) => OnTextInput(new TextInputEventArgs((int)codepoint));
                GLFW.SetCharCallback(WindowPtr, _charCallback);

                _keyCallback = (window, key, scancode, action, mods) =>
                {
                    int index = (int)key;

                    var ourKey = Key.Unknown;

                    if (index >= 0 && index < GlfwKeyMapping.Length)
                    {
                        ourKey = GlfwKeyMapping[index];
                    }

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

                        OnKeyUp(args);
                    }
                    else
                    {
                        if (ourKey != Key.Unknown)
                        {
                            _keyboardState.SetKeyState(ourKey, true);
                        }

                        OnKeyDown(args);
                    }
                };
                GLFW.SetKeyCallback(WindowPtr, _keyCallback);

                _cursorEnterCallback = (window, entered) =>
                {
                    if (entered)
                    {
                        OnMouseEnter();
                    }
                    else
                    {
                        OnMouseLeave();
                    }
                };
                GLFW.SetCursorEnterCallback(WindowPtr, _cursorEnterCallback);

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
                        OnMouseUp(args);
                    }
                    else
                    {
                        _mouseState[ourButton] = true;
                        OnMouseDown(args);
                    }
                };
                GLFW.SetMouseButtonCallback(WindowPtr, _mouseButtonCallback);

                _cursorPosCallback = (window, posX, posY) =>
                {
                    var newPos = new Vector2((float)posX, (float)posY);
                    var delta = _lastReportedMousePos - newPos;

                    MouseDelta += delta;

                    _lastReportedMousePos = _mouseState.Position = newPos;

                    OnMouseMove(new MouseMoveEventArgs(newPos, delta));
                };
                GLFW.SetCursorPosCallback(WindowPtr, _cursorPosCallback);

                _scrollCallback = (window, offsetX, offsetY) =>
                    OnMouseWheel(new MouseWheelEventArgs((float)offsetX, (float)offsetY));
                GLFW.SetScrollCallback(WindowPtr, _scrollCallback);

                _dropCallback = (window, count, paths) =>
                {
                    var arrayOfPaths = new string[count];

                    for (var i = 0; i < count; i++)
                    {
                        arrayOfPaths[i] = MarshalUtility.PtrToStringUTF8(paths[i]);
                    }

                    OnFileDrop(new FileDropEventArgs(arrayOfPaths));
                };
                GLFW.SetDropCallback(WindowPtr, _dropCallback);

                _joystickCallback = (joy, eventCode) =>
                {
                    if (eventCode == ConnectedState.Connected)
                    {
                        // Initialize the first joystick state.
                        GLFW.GetJoystickHatsRaw(joy, out var hatCount);
                        GLFW.GetJoystickAxesRaw(joy, out var axisCount);
                        GLFW.GetJoystickButtonsRaw(joy, out var buttonCount);
                        var name = GLFW.GetJoystickName(joy);

                        JoystickStates[joy] = new JoystickState(hatCount, axisCount, buttonCount, joy, name);
                    }
                    else
                    {
                        // Remove the joystick state from the array of joysticks.
                        JoystickStates[joy] = default;
                    }
                    OnJoystickConnected(new JoystickEventArgs(joy, eventCode == ConnectedState.Connected));
                };
                GLFW.SetJoystickCallback(_joystickCallback);

                _monitorCallback = (monitor, eventCode) =>
                {
                    OnMonitorConnected(new MonitorEventArgs(new Monitor((IntPtr)monitor), eventCode == ConnectedState.Connected));
                };
                GLFW.SetMonitorCallback(_monitorCallback);

                _refreshCallback = (window) => OnRefresh();
                GLFW.SetWindowRefreshCallback(WindowPtr, _refreshCallback);
            }
        }

        private unsafe void OnCloseCallback(Window* window)
        {
            var c = new CancelEventArgs();
            OnClosing(c);
            if (c.Cancel)
            {
                GLFW.SetWindowShouldClose(WindowPtr, false);
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
                GLFW.MakeContextCurrent(WindowPtr);
            }
        }

        private unsafe void DestroyWindow()
        {
            if (Exists)
            {
                Exists = false;
                GLFW.DestroyWindow(WindowPtr);

                OnClosed();
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

            GLFW.WaitEventsTimeout(timeout);
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
                GLFW.WaitEvents();
            }
            else
            {
                GLFW.PollEvents();
            }

            ProcessInputEvents();
        }

        private unsafe void ProcessInputEvents()
        {
            GLFW.GetCursorPos(WindowPtr, out var x, out var y);
            _mouseState.Position = new Vector2((float)x, (float)y);

            for (var i = 0; i < JoystickStates.Length; i++)
            {
                var joy = JoystickStates[i];
                if (joy == default)
                {
                    continue;
                }

                var h = GLFW.GetJoystickHatsRaw(joy.Id, out var count);
                var hats = new Hat[count];
                for (var j = 0; j < count; j++)
                {
                    hats[j] = (Hat)h[j];
                }

                var axes = GLFW.GetJoystickAxes(joy.Id);

                var b = GLFW.GetJoystickButtonsRaw(joy.Id, out count);
                var buttons = new bool[count];
                for (var j = 0; j < buttons.Length; j++)
                {
                    buttons[j] = b[j] == InputAction.Press;
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
        public event Action<WindowPositionEventArgs> Move;

        /// <inheritdoc />
        public event Action<ResizeEventArgs> Resize;

        /// <inheritdoc />
        public event Action Refresh;

        /// <inheritdoc />
        public event Action<CancelEventArgs> Closing;

        /// <inheritdoc />
        public event Action Closed;

        /// <inheritdoc />
        public event Action<MinimizedEventArgs> Minimized;

        /// <inheritdoc />
        public event Action<JoystickEventArgs> JoystickConnected;

        /// <inheritdoc />
        public event Action<FocusedChangedEventArgs> FocusedChanged;

        /// <inheritdoc />
        public event Action<KeyboardKeyEventArgs> KeyDown;

        /// <inheritdoc />
        public event Action<TextInputEventArgs> TextInput;

        /// <inheritdoc />
        public event Action<KeyboardKeyEventArgs> KeyUp;

        /// <inheritdoc />
        public event Action<MonitorEventArgs> MonitorConnected;

        /// <inheritdoc />
        public event Action MouseLeave;

        /// <inheritdoc />
        public event Action MouseEnter;

        /// <inheritdoc />
        public event Action<MouseButtonEventArgs> MouseDown;

        /// <inheritdoc />
        public event Action<MouseButtonEventArgs> MouseUp;

        /// <inheritdoc />
        public event Action<MouseMoveEventArgs> MouseMove;

        /// <inheritdoc />
        public event Action<MouseWheelEventArgs> MouseWheel;

        /// <inheritdoc />
        public event Action<FileDropEventArgs> FileDrop;

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

        private unsafe GraphicsLibraryFramework.Monitor* GetDpiMonitor()
        {
            /*
             * According to the GLFW documentation, glfwGetWindowMonitor will return a value only
             * when the window is fullscreen.
             *
             * If the window is not fullscreen, find the monitor manually.
             */
            GraphicsLibraryFramework.Monitor* value = GLFW.GetWindowMonitor(WindowPtr);
            if (value == null)
            {
                value = DpiCalculator.GetMonitorFromWindow(WindowPtr);
            }

            return value;
        }

        /// <inheritdoc />
        public unsafe bool TryGetCurrentMonitorScale(out float horizontalScale, out float verticalScale) =>
            DpiCalculator.TryGetMonitorScale(
                GetDpiMonitor(),
                out horizontalScale,
                out verticalScale
            );

        /// <inheritdoc />
        public unsafe bool TryGetCurrentMonitorDpi(out float horizontalDpi, out float verticalDpi) =>
            DpiCalculator.TryGetMonitorDpi(
                GetDpiMonitor(),
                out horizontalDpi,
                out verticalDpi
            );

        /// <inheritdoc />
        public unsafe bool TryGetCurrentMonitorDpiRaw(out float horizontalDpi, out float verticalDpi) =>
            DpiCalculator.TryGetMonitorDpiRaw(
                GetDpiMonitor(),
                out horizontalDpi,
                out verticalDpi
            );

        /// <summary>
        /// Raises the <see cref="Move"/> event.
        /// </summary>
        /// <param name="e">A <see cref="WindowPositionEventArgs"/> that contains the event data.</param>
        protected virtual void OnMove(WindowPositionEventArgs e)
        {
            Move?.Invoke(e);

            _location.X = e.X;
            _location.Y = e.Y;
        }

        /// <summary>
        /// Raises the <see cref="Resize"/> event.
        /// </summary>
        /// <param name="e">A <see cref="ResizeEventArgs"/> that contains the event data.</param>
        protected virtual void OnResize(ResizeEventArgs e)
        {
            HandleResize(e.Width, e.Height);

            Resize?.Invoke(e);
        }

        /// <summary>
        /// Raises the <see cref="Refresh"/> event.
        /// </summary>
        protected virtual void OnRefresh()
        {
            Refresh?.Invoke();
        }

        /// <summary>
        /// Raises the <see cref="Closing"/> event.
        /// </summary>
        /// <param name="e">A <see cref="CancelEventArgs"/> that contains the event data.</param>
        protected virtual void OnClosing(CancelEventArgs e)
        {
            Closing?.Invoke(e);
        }

        /// <summary>
        /// Raises the <see cref="Closed"/> event.
        /// </summary>
        protected virtual void OnClosed()
        {
            Closed?.Invoke();
        }

        /// <summary>
        /// Raises the <see cref="JoystickConnected"/> event.
        /// </summary>
        /// <param name="e">A <see cref="JoystickEventArgs"/> that contains the event data.</param>
        protected virtual void OnJoystickConnected(JoystickEventArgs e)
        {
            JoystickConnected?.Invoke(e);
        }

        /// <summary>
        /// Raises the <see cref="FocusedChanged"/> event.
        /// </summary>
        /// <param name="e">A <see cref="FocusedChangedEventArgs"/> that contains the event data.</param>
        protected virtual void OnFocusedChanged(FocusedChangedEventArgs e)
        {
            FocusedChanged?.Invoke(e);

            _isFocused = e.IsFocused;
        }

        /// <summary>
        /// Raises the <see cref="KeyDown"/> event.
        /// </summary>
        /// <param name="e">A <see cref="KeyboardKeyEventArgs"/> that contains the event data.</param>
        protected virtual void OnKeyDown(KeyboardKeyEventArgs e)
        {
            KeyDown?.Invoke(e);
        }

        /// <summary>
        /// Raises the <see cref="TextInput"/> event.
        /// </summary>
        /// <param name="e">A <see cref="TextInputEventArgs"/> that contains the event data.</param>
        protected virtual void OnTextInput(TextInputEventArgs e)
        {
            TextInput?.Invoke(e);
        }

        /// <summary>
        /// Raises the <see cref="KeyUp"/> event.
        /// </summary>
        /// <param name="e">A <see cref="KeyboardKeyEventArgs"/> that contains the event data.</param>
        protected virtual void OnKeyUp(KeyboardKeyEventArgs e)
        {
            KeyUp?.Invoke(e);
        }

        /// <summary>
        /// Raises the <see cref="MonitorConnected"/> event.
        /// </summary>
        /// <param name="e">A <see cref="MonitorEventArgs"/> that contains the event data.</param>
        protected virtual void OnMonitorConnected(MonitorEventArgs e)
        {
            MonitorConnected?.Invoke(e);
        }

        /// <summary>
        /// Raises the <see cref="MouseLeave"/> event.
        /// </summary>
        protected virtual void OnMouseLeave()
        {
            MouseLeave?.Invoke();
        }

        /// <summary>
        /// Raises the <see cref="MouseEnter"/> event.
        /// </summary>
        protected virtual void OnMouseEnter()
        {
            MouseEnter?.Invoke();
        }

        /// <summary>
        /// Raises the <see cref="MouseDown"/> event.
        /// </summary>
        /// <param name="e">A <see cref="MouseButtonEventArgs"/> that contains the event data.</param>
        protected virtual void OnMouseDown(MouseButtonEventArgs e)
        {
            MouseDown?.Invoke(e);
        }

        /// <summary>
        /// Raises the <see cref="MouseUp"/> event.
        /// </summary>
        /// <param name="e">A <see cref="MouseButtonEventArgs"/> that contains the event data.</param>
        protected virtual void OnMouseUp(MouseButtonEventArgs e)
        {
            MouseUp?.Invoke(e);
        }

        /// <summary>
        /// Raises the <see cref="MouseMove"/> event.
        /// </summary>
        /// <param name="e">A <see cref="MouseMoveEventArgs"/> that contains the event data.</param>
        protected virtual void OnMouseMove(MouseMoveEventArgs e)
        {
            MouseMove?.Invoke(e);
        }

        /// <summary>
        /// Raises the <see cref="MouseWheel"/> event.
        /// </summary>
        /// <param name="e">A <see cref="MouseWheelEventArgs"/> that contains the event data.</param>
        protected virtual void OnMouseWheel(MouseWheelEventArgs e)
        {
            MouseWheel?.Invoke(e);
        }

        /// <summary>
        /// Raises the <see cref="OnMinimized"/> event.
        /// </summary>
        /// <param name="e">A <see cref="MouseWheelEventArgs"/> that contains the event data.</param>
        protected virtual void OnMinimized(MinimizedEventArgs e)
        {
            Minimized?.Invoke(e);
        }

        /// <summary>
        /// Raises the <see cref="FileDrop"/> event.
        /// </summary>
        /// <param name="e">A <see cref="FileDropEventArgs"/> that contains the event data.</param>
        protected virtual void OnFileDrop(FileDropEventArgs e)
        {
            FileDrop?.Invoke(e);
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

        private static CursorShape MapStandardCursorShape(MouseCursor.StandardShape shape)
        {
            switch (shape)
            {
                case MouseCursor.StandardShape.Arrow:
                    return CursorShape.Arrow;
                case MouseCursor.StandardShape.IBeam:
                    return CursorShape.IBeam;
                case MouseCursor.StandardShape.Crosshair:
                    return CursorShape.Crosshair;
                case MouseCursor.StandardShape.Hand:
                    return CursorShape.Hand;
                case MouseCursor.StandardShape.HResize:
                    return CursorShape.HResize;
                case MouseCursor.StandardShape.VResize:
                    return CursorShape.VResize;
                default:
                    throw new ArgumentOutOfRangeException(nameof(shape), shape, null);
            }
        }
    }
}
