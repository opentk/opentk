﻿// Copyright (c) OpenTK. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using OpenTK.Core;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Common.Input;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    /// A Native Window.
    /// </summary>
    public class NativeWindow : IDisposable
    {
        /// <summary>
        /// Gets the native <see cref="Window"/> pointer for use with <see cref="GLFW"/> API.
        /// </summary>
        public unsafe Window* WindowPtr { get; protected set; }

        // Both of these are used to cache the size and location of the window before going into full screen mode.
        // When getting out of full screen mode, the location and size will be set to these value in all states other then minimized.
        private Vector2i _cachedWindowClientSize;
        private Vector2i _cachedWindowLocation;

        // Used for delta calculation in the mouse position changed event.
        private Vector2 _lastReportedMousePos;

        // Stores exceptions thrown in callbacks so that we can rethrow them after ProcessEvents().
        private static ConcurrentQueue<ExceptionDispatchInfo> _callbackExceptions = new ConcurrentQueue<ExceptionDispatchInfo>();

        // GLFW cursor we assigned to the window.
        // Null if the cursor is default.
        private unsafe Cursor* _glfwCursor;

        // Actual managed cursor instance for the public API.
        // Never null.
        private MouseCursor _managedCursor = MouseCursor.Default;

        /// <summary>
        ///     Gets the current state of the keyboard as of the last time the window processed events.
        /// </summary>
        public KeyboardState KeyboardState { get; } = new KeyboardState();

        /// <summary>
        ///     Gets the previous keyboard state.
        ///     This value is updated with the new state every time the window processes events.
        /// </summary>
        [Obsolete("Use " + nameof(KeyboardState.WasKeyDown) + " instead.", true)]
        public KeyboardState LastKeyboardState => null;

        private readonly JoystickState[] _joystickStates = new JoystickState[16];

        /// <summary>
        /// Gets the current state of the joysticks as of the last time the window processed events.
        /// </summary>
        public IReadOnlyList<JoystickState> JoystickStates
        {
            get => _joystickStates;
        }

        [Obsolete("Use " + nameof(JoystickState.WasButtonDown) + ", " + nameof(JoystickState.GetAxisPrevious) + " and " + nameof(JoystickState.GetHatPrevious) + " instead.", true)]
        public IReadOnlyList<JoystickState> LastJoystickStates => null;

        /// <summary>
        ///     Gets or sets the position of the mouse relative to the content area of this window.
        ///     NOTE: It is not necessary to center the mouse on each frame. Use CursorGrabbed = true;
        ///     to enable this behavior.
        /// </summary>
        public Vector2 MousePosition
        {
            get => _lastReportedMousePos;
            set
            {
                unsafe
                {
                    // This call invokes the OnMouseMove event, which in turn updates _lastReportedMousePos.
                    GLFW.SetCursorPos(WindowPtr, value.X, value.Y);
                }
            }
        }

        /// <summary>
        ///     Gets the amount that the mouse moved since the last frame.
        ///     This does not necessarily correspond to pixels, for example in the case of raw input.
        /// </summary>
        [Obsolete("Use " + nameof(OpenTK.Windowing.GraphicsLibraryFramework.MouseState.Delta) + " member of the " + nameof(NativeWindow.MouseState) + " property instead.", true)]
        public Vector2 MouseDelta => Vector2.Zero;

        /// <summary>
        ///     Gets the current state of the mouse as of the last time the window processed events.
        /// </summary>
        public MouseState MouseState { get; } = new MouseState();

        /// <summary>
        ///     Gets the previous keyboard state.
        ///     This value is updated with the new state every time the window processes events.
        /// </summary>
        [Obsolete("Use " + nameof(OpenTK.Windowing.GraphicsLibraryFramework.MouseState.WasButtonDown) + " and " + nameof(OpenTK.Windowing.GraphicsLibraryFramework.MouseState.PreviousPosition) + " members of the " + nameof(NativeWindow.MouseState) + " property instead.", true)]
        public MouseState LastMouseState => null;

        /// <summary>
        /// Gets a value indicating whether any key is down.
        /// </summary>
        /// <value><c>true</c> if any key is down; otherwise, <c>false</c>.</value>
        public bool IsAnyKeyDown => KeyboardState.IsAnyKeyDown;

        /// <summary>
        /// Gets a value indicating whether any mouse button is pressed.
        /// </summary>
        /// <value><c>true</c> if any button is pressed; otherwise, <c>false</c>.</value>
        public bool IsAnyMouseButtonDown => MouseState.IsAnyButtonDown;

        private VSyncMode _vSync;

        /// <summary>
        /// Gets or sets the VSync state of this <see cref="NativeWindow"/>.
        /// </summary>
        /// <value>
        /// The VSync state.
        /// </value>
        public VSyncMode VSync
        {
            get
            {
                if (Context == null)
                {
                    throw new InvalidOperationException("Cannot control vsync when running with ContextAPI.NoAPI.");
                }

                return _vSync;
            }

            set
            {
                if (Context == null)
                {
                    throw new InvalidOperationException("Cannot control vsync when running with ContextAPI.NoAPI.");
                }

                // We don't do anything here for adaptive because that's handled in GameWindow.
                switch (value)
                {
                    case VSyncMode.On:
                        Context.SwapInterval = 1;
                        break;

                    case VSyncMode.Off:
                        Context.SwapInterval = 0;
                        break;
                }
                _vSync = value;
            }
        }

        private WindowIcon _icon;

        /// <summary>
        /// Gets or sets the current <see cref="WindowIcon" /> for this window.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This does nothing on macOS; on that platform, the icon is determined by the application bundle.
        /// </para>
        /// </remarks>
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
                        glfwImages[i] =
                            new GraphicsLibraryFramework.Image(image.Width, image.Height, addrOfPinnedObject);
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
        /// Gets or sets a value indicating whether or not this window is event-driven.
        /// An event-driven window will wait for events before updating/rendering. It is useful for non-game applications,
        /// where the program only needs to do any processing after the user inputs something.
        /// </summary>
        public bool IsEventDriven { get; set; }

        /// <summary>
        /// Gets or sets the clipboard string.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the title of the window.
        /// </summary>
        public string Title
        {
            get => _title;
            set
            {
                unsafe
                {
                    GLFW.SetWindowTitle(WindowPtr, value);

                    _title = value;
                }
            }
        }

        /// <summary>
        /// Gets a value representing the current graphics API.
        /// </summary>
        public ContextAPI API { get; }

        /// <summary>
        /// Gets a value representing the current graphics API profile.
        /// </summary>
        public ContextProfile Profile { get; }

        /// <summary>
        /// Gets a value representing the current graphics profile flags.
        /// </summary>
        public ContextFlags Flags { get; }

        /// <summary>
        /// Gets a value representing the current version of the graphics API.
        /// </summary>
        public Version APIVersion { get; }

        /// <summary>
        /// Gets the graphics context associated with this NativeWindow.
        /// </summary>
        public IGLFWGraphicsContext Context { get; }

        private MonitorHandle _currentMonitor;

        /// <summary>
        /// Gets or sets the current <see cref="MonitorHandle"/>.
        /// </summary>
        public unsafe MonitorHandle CurrentMonitor
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

                _currentMonitor = value;
            }
        }

        // This is updated by the constructor and by the OnFocusChanged event. We presume that OnFocusChanged will fire after a call to GLFW.FocusWindow.
        private bool _isFocused;

        /// <summary>
        /// Gets a value indicating whether this window has input focus.
        /// </summary>
        public bool IsFocused
        {
            get => _isFocused;
        }

        /// <summary>
        /// Brings the window into focus.
        /// </summary>
        public unsafe void Focus()
        {
            GLFW.FocusWindow(WindowPtr);
        }

        private bool _isVisible;

        /// <summary>
        /// Gets or sets a value indicating whether the window is visible.
        /// </summary>
        public unsafe bool IsVisible
        {
            get => _isVisible;
            set
            {
                if (value != _isVisible)
                {
                    _isVisible = value;

                    if (_isVisible)
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

        /// <summary>
        /// Gets a value indicating whether the window has been created and has not been destroyed.
        /// </summary>
        public bool Exists { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the shutdown sequence has been initiated
        /// for this window, by calling NativeWindow.Close() or hitting the 'close' button.
        /// </summary>
        public unsafe bool IsExiting => GLFW.WindowShouldClose(WindowPtr);

        private WindowState _windowState = WindowState.Normal;

        /// <summary>
        /// Gets or sets the <see cref="WindowState" /> for this window.
        /// </summary>
        public unsafe WindowState WindowState
        {
            get => _windowState;

            set
            {
                if (_windowState == WindowState.Fullscreen && value != WindowState.Fullscreen)
                {
                    // We are going from fullscreen to something else.
                    GLFW.SetWindowMonitor(WindowPtr, null, _cachedWindowLocation.X, _cachedWindowLocation.Y, _cachedWindowClientSize.X, _cachedWindowClientSize.Y, 0);
                }

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
                        // Cache the window size so we can reset to it when we go out of fullscreen.
                        _cachedWindowClientSize = ClientSize;
                        _cachedWindowLocation = Location;
                        var monitor = CurrentMonitor.ToUnsafePtr<GraphicsLibraryFramework.Monitor>();
                        var modePtr = GLFW.GetVideoMode(monitor);
                        GLFW.SetWindowMonitor(WindowPtr, monitor, 0, 0, modePtr->Width, modePtr->Height, modePtr->RefreshRate);
                        break;
                }

                _windowState = value;
            }
        }

        private WindowBorder _windowBorder;

        /// <summary>
        /// Gets or sets the <see cref="WindowBorder" /> for this window.
        /// </summary>
        public unsafe WindowBorder WindowBorder
        {
            get => _windowBorder;

            set
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
                        GLFW.SetWindowAttrib(WindowPtr, WindowAttribute.Decorated, false);
                        break;
                    case WindowBorder.Resizable:
                        GLFW.SetWindowAttrib(WindowPtr, WindowAttribute.Decorated, true);
                        GLFW.SetWindowAttrib(WindowPtr, WindowAttribute.Resizable, true);
                        break;
                    case WindowBorder.Fixed:
                        GLFW.SetWindowAttrib(WindowPtr, WindowAttribute.Decorated, true);
                        GLFW.SetWindowAttrib(WindowPtr, WindowAttribute.Resizable, false);
                        break;
                }

                _windowBorder = value;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="OpenTK.Mathematics.Box2i" /> structure the contains the external bounds of this window,
        /// in screen coordinates.
        /// External bounds include the title bar, borders and drawing area of the window.
        /// </summary>
        public unsafe Box2i Bounds
        {
            get => new Box2i(Location, Location + Size);
            set
            {
                GLFW.SetWindowSize(WindowPtr, (int)value.Size.X, (int)value.Size.Y);
                GLFW.SetWindowPos(WindowPtr, (int)value.Min.X, (int)value.Min.Y);
            }
        }

        // This is updated by the constructor, by OnMove, and in the Location property setter.
        private Vector2i _location;

        /// <summary>
        /// Gets or sets a <see cref="OpenTK.Mathematics.Vector2i" /> structure that contains the location of this window on the
        /// desktop.
        /// </summary>
        public unsafe Vector2i Location
        {
            get => _location;
            set
            {
                GLFW.SetWindowPos(WindowPtr, value.X, value.Y);
                _location = value;
            }
        }

        private Vector2i _size;
        private Vector2i? _minimumSize;
        private Vector2i? _maximumSize;

        /// <summary>
        /// Gets or sets a <see cref="OpenTK.Mathematics.Vector2i" /> structure that contains the external size of this window.
        /// </summary>
        public unsafe Vector2i Size
        {
            get => _size;
            set
            {
                _size = value;
                GLFW.SetWindowSize(WindowPtr, value.X, value.Y);
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="OpenTK.Mathematics.Vector2i" /> structure that contains the minimum external size of this window.
        /// </summary>
        /// <remarks>
        /// Set to <c>null</c> to remove the minimum size constraint.
        /// If you set size limits and an aspect ratio that conflict, the results are undefined.
        /// </remarks>
        public unsafe Vector2i? MinimumSize
        {
            get => _minimumSize;
            set
            {
                _minimumSize = value;
                GLFW.SetWindowSizeLimits(WindowPtr, value?.X ?? GLFW.DontCare, value?.Y ?? GLFW.DontCare, _maximumSize?.X ?? GLFW.DontCare, _maximumSize?.Y ?? GLFW.DontCare);
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="OpenTK.Mathematics.Vector2i" /> structure that contains the maximum external size of this window.
        /// </summary>
        /// <remarks>
        /// Set to <c>null</c> to remove the maximum size constraint.
        /// If you set size limits and an aspect ratio that conflict, the results are undefined.
        /// </remarks>
        public unsafe Vector2i? MaximumSize
        {
            get => _maximumSize;
            set
            {
                _maximumSize = value;
                GLFW.SetWindowSizeLimits(WindowPtr, _minimumSize?.X ?? GLFW.DontCare, _minimumSize?.Y ?? GLFW.DontCare, value?.X ?? GLFW.DontCare, value?.Y ?? GLFW.DontCare);
            }
        }

        private (int numerator, int denominator)? _aspectRatio;

        /// <summary>
        /// Gets or sets the aspect ratio this window is locked to.
        /// </summary>
        /// <remarks>
        /// Set to <c>null</c> disable aspect ratio locking.
        /// If you set size limits and an aspect ratio lock that conflict, the results are undefined.
        /// </remarks>
        public unsafe (int numerator, int denominator)? AspectRatio
        {
            get => _aspectRatio;
            set
            {
                _aspectRatio = value;
                GLFW.SetWindowAspectRatio(WindowPtr, value?.numerator ?? GLFW.DontCare, value?.denominator ?? GLFW.DontCare);
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="OpenTK.Mathematics.Box2i" /> structure that contains the internal bounds of this window,
        /// in client coordinates.
        /// The internal bounds include the drawing area of the window, but exclude the title bar and window borders.
        /// </summary>
        public Box2i ClientRectangle
        {
            get => new Box2i(Location, Location + Size);
            set
            {
                Location = value.Min;
                Size = value.Size;
            }
        }

        /// <summary>
        /// Gets a <see cref="OpenTK.Mathematics.Vector2i" /> structure that contains the internal size this window.
        /// </summary>
        public Vector2i ClientSize { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the window is fullscreen or not.
        /// Use <see cref="WindowState"/> to set the window to fullscreen.
        /// </summary>
        public bool IsFullscreen => WindowState == WindowState.Fullscreen;

        /// <summary>
        /// Gets or sets the <see cref="OpenTK.Windowing.Common.Input.MouseCursor" /> for this window.
        /// </summary>
        /// <value>The cursor.</value>
        public MouseCursor Cursor
        {
            get => _managedCursor;
            set
            {
                _managedCursor = value ??
                                 throw new ArgumentNullException(
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

        /// <summary>
        /// Gets or sets the cursor state of the windows cursor.
        /// </summary>
        public unsafe CursorState CursorState
        {
            get
            {
                CursorModeValue inputMode = GLFW.GetInputMode(WindowPtr, CursorStateAttribute.Cursor);
                switch (inputMode)
                {
                    case CursorModeValue.CursorNormal:
                        return CursorState.Normal;
                    case CursorModeValue.CursorHidden:
                        return CursorState.Hidden;
                    case CursorModeValue.CursorDisabled:
                        return CursorState.Grabbed;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            set
            {
                CursorModeValue inputMode;
                switch (value)
                {
                    case CursorState.Normal:
                        inputMode = CursorModeValue.CursorNormal;
                        break;
                    case CursorState.Hidden:
                        inputMode = CursorModeValue.CursorHidden;
                        break;
                    case CursorState.Grabbed:
                        inputMode = CursorModeValue.CursorDisabled;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                GLFW.SetInputMode(WindowPtr, CursorStateAttribute.Cursor, inputMode);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the mouse cursor is visible.
        /// </summary>
        [Obsolete("Use CursorState insatead.")]
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

        /// <summary>
        /// Gets or sets a value indicating whether the mouse cursor is confined inside the window size.
        /// </summary>
        [Obsolete("Use CursorState instead.")]
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
        /// <param name="settings">The <see cref="NativeWindow"/> related settings.</param>
        public unsafe NativeWindow(NativeWindowSettings settings)
        {
            GLFWProvider.EnsureInitialized();

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
            API = settings.API;
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

            APIVersion = settings.APIVersion;

            Flags = settings.Flags;
            if (settings.Flags.HasFlag(ContextFlags.ForwardCompatible))
            {
                GLFW.WindowHint(WindowHintBool.OpenGLForwardCompat, true);
            }

            if (settings.Flags.HasFlag(ContextFlags.Debug))
            {
                GLFW.WindowHint(WindowHintBool.OpenGLDebugContext, true);
            }

            Profile = settings.Profile;
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

            GLFW.WindowHint(WindowHintInt.Samples, settings.NumberOfSamples);

            GLFW.WindowHint(WindowHintBool.SrgbCapable, settings.SrgbCapable);

            if (settings.TransparentFramebuffer is bool transparent)
            {
                GLFW.WindowHint(WindowHintBool.TransparentFramebuffer, transparent);
            }

            // We do the work to set the hint bits outside of the CreateWindow conditional
            // so that the window will get the correct fullscreen red/green/blue bits stored
            // in its hidden fields regardless of how it gets created.  (The extra curly
            // braces here keep the local `monitor` definition from conflicting with the
            // _monitorCallback lambda below.)
            {
                var monitor = settings.CurrentMonitor.ToUnsafePtr<GraphicsLibraryFramework.Monitor>();
                var modePtr = GLFW.GetVideoMode(monitor);
                GLFW.WindowHint(WindowHintInt.RedBits, settings.RedBits ?? modePtr->RedBits);
                GLFW.WindowHint(WindowHintInt.GreenBits, settings.GreenBits ?? modePtr->GreenBits);
                GLFW.WindowHint(WindowHintInt.BlueBits, settings.BlueBits ?? modePtr->BlueBits);
                if (settings.AlphaBits.HasValue)
                {
                    GLFW.WindowHint(WindowHintInt.AlphaBits, settings.AlphaBits.Value);
                }

                if (settings.DepthBits.HasValue)
                {
                    GLFW.WindowHint(WindowHintInt.DepthBits, settings.DepthBits.Value);
                }

                if (settings.StencilBits.HasValue)
                {
                    GLFW.WindowHint(WindowHintInt.StencilBits, settings.StencilBits.Value);
                }

                GLFW.WindowHint(WindowHintInt.RefreshRate, modePtr->RefreshRate);

                if (settings.WindowState == WindowState.Fullscreen && _isVisible)
                {
                    _windowState = WindowState.Fullscreen;
                    _cachedWindowLocation = settings.Location ?? new Vector2i(32, 32);  // Better than nothing.
                    _cachedWindowClientSize = settings.Size;
                    WindowPtr = GLFW.CreateWindow(modePtr->Width, modePtr->Height, _title, monitor, (Window*)(settings.SharedContext?.WindowPtr ?? IntPtr.Zero));
                }
                else
                {
                    WindowPtr = GLFW.CreateWindow(settings.Size.X, settings.Size.Y, _title, null, (Window*)(settings.SharedContext?.WindowPtr ?? IntPtr.Zero));
                }
            }

            // For Vulkan, we need to pass ContextAPI.NoAPI, otherwise we will get an exception.
            // See https://github.com/glfw/glfw/blob/56a4cb0a3a2c7a44a2fd8ab3335adf915e19d30c/src/vulkan.c#L320
            //
            // But Calling MakeCurrent while using NoApi, we will get an exception from GLFW,
            // because Vulkan does not have that concept.
            // See https://github.com/glfw/glfw/blob/fd79b02840a36b74e4289cc53dc332de6403b8fd/src/context.c#L618
            if (settings.API != ContextAPI.NoAPI)
            {
                Context = new GLFWGraphicsContext(WindowPtr);
            }

            Exists = true;

            if (isOpenGl)
            {
                Context?.MakeCurrent();

                if (settings.AutoLoadBindings)
                {
                    InitializeGlBindings();
                }
            }

            // Enables the caps lock modifier to be detected and updated
            GLFW.SetInputMode(WindowPtr, LockKeyModAttribute.LockKeyMods, true);

            RegisterWindowCallbacks();

            InitialiseJoystickStates();

            _isFocused = settings.StartFocused;
            if (settings.StartFocused)
            {
                Focus();
            }

            // Setting WindowState to e.g. Normal while the
            // window is hidden will show the window
            // So if we don't set WindowState when StartVisible is false.
            if (settings.StartVisible)
            {
                WindowState = settings.WindowState;
            }

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

            AspectRatio = settings.AspectRatio;
            _minimumSize = settings.MinimumSize;
            _maximumSize = settings.MaximumSize;

            GLFW.SetWindowSizeLimits(WindowPtr, _minimumSize?.X ?? GLFW.DontCare, _minimumSize?.Y ?? GLFW.DontCare, _maximumSize?.X ?? GLFW.DontCare, _maximumSize?.Y ?? GLFW.DontCare);

            GLFW.GetWindowPos(WindowPtr, out var x, out var y);
            _location = new Vector2i(x, y);

            GLFW.GetCursorPos(WindowPtr, out var mousex, out var mousey);
            _lastReportedMousePos = new Vector2((float)mousex, (float)mousey);
            MouseState.Position = _lastReportedMousePos;

            _isFocused = GLFW.GetWindowAttrib(WindowPtr, WindowAttributeGetBool.Focused);

            // We can't set Vsync if we are using ContextAPI.NoAPI.
            if (API != ContextAPI.NoAPI)
            {
                VSync = settings.Vsync;
            }
        }

        private static void InitializeGlBindings()
        {
            // We don't put a hard dependency on OpenTK.Graphics here.
            // So we need to use reflection to initialize the GL bindings, so users don't have to.

            // Try to load OpenTK.Graphics assembly.
            Assembly assembly;
            try
            {
                assembly = Assembly.Load("OpenTK.Graphics");
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
                var type = assembly.GetType($"OpenTK.Graphics.{typeNamespace}.GL");
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

        private unsafe void HandleResize(int width, int height)
        {
            _size.X = width;
            _size.Y = height;

            GLFW.GetFramebufferSize(WindowPtr, out width, out height);

            ClientSize = new Vector2i(width, height);
        }

        /// <summary>
        /// After the OS notifies us of a window change, we can't be certain that our
        /// cached state is correct.  This method exists to allow us to directly ask
        /// the OS what state it says our window is really in.
        /// </summary>
        /// <returns>The current actual state of the window.</returns>
        private unsafe WindowState GetWindowStateFromGLFW()
        {
            if (GLFW.GetWindowAttrib(WindowPtr, WindowAttributeGetBool.Iconified))
            {
                return WindowState.Minimized;
            }

            if (GLFW.GetWindowAttrib(WindowPtr, WindowAttributeGetBool.Maximized))
            {
                return WindowState.Maximized;
            }

            if (GLFW.GetWindowMonitor(WindowPtr) != null)
            {
                return WindowState.Fullscreen;
            }

            return WindowState.Normal;
        }

        private GLFWCallbacks.WindowPosCallback _windowPosCallback;
        private GLFWCallbacks.WindowSizeCallback _windowSizeCallback;
        private GLFWCallbacks.WindowIconifyCallback _windowIconifyCallback;
        private GLFWCallbacks.WindowMaximizeCallback _windowMaximizeCallback;
        private GLFWCallbacks.WindowFocusCallback _windowFocusCallback;
        private GLFWCallbacks.CharCallback _charCallback;
        private GLFWCallbacks.ScrollCallback _scrollCallback;
        private GLFWCallbacks.WindowRefreshCallback _windowRefreshCallback;
        private GLFWCallbacks.WindowCloseCallback _windowCloseCallback;
        private GLFWCallbacks.KeyCallback _keyCallback;
        private GLFWCallbacks.CursorEnterCallback _cursorEnterCallback;
        private GLFWCallbacks.MouseButtonCallback _mouseButtonCallback;
        private GLFWCallbacks.CursorPosCallback _cursorPosCallback;
        private GLFWCallbacks.DropCallback _dropCallback;
        private GLFWCallbacks.JoystickCallback _joystickCallback;

        [Obsolete("Use the Monitors.OnMonitorConnected event instead.", true)]
        private GLFWCallbacks.MonitorCallback _monitorCallback;

        private unsafe void RegisterWindowCallbacks()
        {
            // These must be assigned to fields even when they're methods

            _windowPosCallback = WindowPosCallback;
            _windowSizeCallback = WindowSizeCallback;
            _windowCloseCallback = WindowCloseCallback;
            _windowRefreshCallback = WindowRefreshCallback;
            _windowFocusCallback = WindowFocusCallback;
            _windowIconifyCallback = WindowIconifyCallback;
            _windowMaximizeCallback = WindowMaximizeCallback;
            // FIXME: Add FramebufferSizeCallback and WindowContentsScaleCallback

            _mouseButtonCallback = MouseButtonCallback;
            _cursorPosCallback = CursorPosCallback;
            _cursorEnterCallback = CursorEnterCallback;
            _scrollCallback = ScrollCallback;

            _keyCallback = KeyCallback;
            _charCallback = CharCallback;
            // FIXME: CharModsCallback

            _dropCallback = DropCallback;

            _joystickCallback = JoystickCallback;

            GLFW.SetWindowPosCallback(WindowPtr, _windowPosCallback);
            GLFW.SetWindowSizeCallback(WindowPtr, _windowSizeCallback);
            GLFW.SetWindowCloseCallback(WindowPtr, _windowCloseCallback);
            GLFW.SetWindowRefreshCallback(WindowPtr, _windowRefreshCallback);
            GLFW.SetWindowFocusCallback(WindowPtr, _windowFocusCallback);
            GLFW.SetWindowIconifyCallback(WindowPtr, _windowIconifyCallback);
            GLFW.SetWindowMaximizeCallback(WindowPtr, _windowMaximizeCallback);

            GLFW.SetMouseButtonCallback(WindowPtr, _mouseButtonCallback);
            GLFW.SetCursorPosCallback(WindowPtr, _cursorPosCallback);
            GLFW.SetCursorEnterCallback(WindowPtr, _cursorEnterCallback);
            GLFW.SetScrollCallback(WindowPtr, _scrollCallback);

            GLFW.SetKeyCallback(WindowPtr, _keyCallback);
            GLFW.SetCharCallback(WindowPtr, _charCallback);

            GLFW.SetDropCallback(WindowPtr, _dropCallback);

            Joysticks.JoystickCallback += _joystickCallback;
        }

        private void UnregisterWindowCallbacks()
        {
            Joysticks.JoystickCallback -= _joystickCallback;
        }

        private unsafe void InitialiseJoystickStates()
        {
            // Check for Joysticks that are connected at application launch
            for (int i = 0; i < _joystickStates.Length; i++)
            {
                if (GLFW.JoystickPresent(i))
                {
                    GLFW.GetJoystickHatsRaw(i, out var hatCount);
                    GLFW.GetJoystickAxesRaw(i, out var axisCount);
                    GLFW.GetJoystickButtonsRaw(i, out var buttonCount);
                    var name = GLFW.GetJoystickName(i);

                    _joystickStates[i] = new JoystickState(hatCount, axisCount, buttonCount, i, name);
                }
            }
        }

        private unsafe void WindowPosCallback(Window* window, int x, int y)
        {
            try
            {
                OnMove(new WindowPositionEventArgs(x, y));
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void WindowSizeCallback(Window* window, int width, int height)
        {
            try
            {
                OnResize(new ResizeEventArgs(width, height));
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void WindowCloseCallback(Window* window)
        {
            try
            {
                var c = new CancelEventArgs();
                OnClosing(c);
                if (c.Cancel)
                {
                    GLFW.SetWindowShouldClose(WindowPtr, false);
                }
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void WindowRefreshCallback(Window* window)
        {
            try
            {
                OnRefresh();
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void WindowFocusCallback(Window* window, bool focused)
        {
            try
            {
                OnFocusedChanged(new FocusedChangedEventArgs(focused));
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void WindowIconifyCallback(Window* window, bool iconified)
        {
            try
            {
                OnMinimized(new MinimizedEventArgs(iconified));
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void WindowMaximizeCallback(Window* window, bool maximized)
        {
            try
            {
                OnMaximized(new MaximizedEventArgs(maximized));
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void MouseButtonCallback(Window* window, MouseButton button, InputAction action, KeyModifiers mods)
        {
            try
            {
                var args = new MouseButtonEventArgs(button, action, mods);

                if (action == InputAction.Release)
                {
                    MouseState[button] = false;
                    OnMouseUp(args);
                }
                else
                {
                    MouseState[button] = true;
                    OnMouseDown(args);
                }
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void CursorPosCallback(Window* window, double posX, double posY)
        {
            try
            {
                var newPos = new Vector2((float)posX, (float)posY);
                var delta = newPos - _lastReportedMousePos;

                _lastReportedMousePos = newPos;

                OnMouseMove(new MouseMoveEventArgs(newPos, delta));
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void CursorEnterCallback(Window* window, bool entered)
        {
            try
            {
                if (entered)
                {
                    OnMouseEnter();
                }
                else
                {
                    OnMouseLeave();
                }
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void ScrollCallback(Window* window, double offsetX, double offsetY)
        {
            try
            {
                // GLFW says this function can be called not only in response to functions like glfwPollEvents();
                // There might be a function like glfwSetWindowSize what will trigger a scroll event to trigger inside that function.
                // We ignore this case for now and just accept that the scroll value will change after such a function call.
                var offset = new Vector2((float)offsetX, (float)offsetY);

                MouseState.Scroll += offset;

                OnMouseWheel(new MouseWheelEventArgs(offset));
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void KeyCallback(Window* window, Keys key, int scancode, InputAction action, KeyModifiers mods)
        {
            try
            {
                var args = new KeyboardKeyEventArgs(key, scancode, mods, action == InputAction.Repeat);

                if (action == InputAction.Release)
                {
                    if (key != Keys.Unknown)
                    {
                        KeyboardState.SetKeyState(key, false);
                    }

                    OnKeyUp(args);
                }
                else
                {
                    if (key != Keys.Unknown)
                    {
                        KeyboardState.SetKeyState(key, true);
                    }

                    OnKeyDown(args);
                }
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void CharCallback(Window* window, uint codepoint)
        {
            try
            {
                OnTextInput(new TextInputEventArgs((int)codepoint));
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void DropCallback(Window* window, int count, byte** paths)
        {
            try
            {
                var arrayOfPaths = new string[count];

                for (var i = 0; i < count; i++)
                {
                    arrayOfPaths[i] = MarshalUtility.PtrToStringUTF8(paths[i]);
                }

                OnFileDrop(new FileDropEventArgs(arrayOfPaths));
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        private unsafe void JoystickCallback(int joy, ConnectedState eventCode)
        {
            try
            {
                if (eventCode == ConnectedState.Connected)
                {
                    // Initialize the first joystick state.
                    GLFW.GetJoystickHatsRaw(joy, out var hatCount);
                    GLFW.GetJoystickAxesRaw(joy, out var axisCount);
                    GLFW.GetJoystickButtonsRaw(joy, out var buttonCount);
                    var name = GLFW.GetJoystickName(joy);

                    _joystickStates[joy] = new JoystickState(hatCount, axisCount, buttonCount, joy, name);
                }
                else
                {
                    // Remove the joystick state from the array of joysticks.
                    _joystickStates[joy] = null;
                }

                OnJoystickConnected(new JoystickEventArgs(joy, eventCode == ConnectedState.Connected));
            }
            catch (Exception e)
            {
                _callbackExceptions.Enqueue(ExceptionDispatchInfo.Capture(e));
            }
        }

        /// <summary>
        /// Closes this window.
        /// </summary>
        public virtual unsafe void Close()
        {
            // We don't have to catch exceptions here as this code isn't called directly from unmanaged code
            CancelEventArgs c = new CancelEventArgs();
            OnClosing(c);
            if (c.Cancel == false)
            {
                GLFW.SetWindowShouldClose(WindowPtr, true);
            }
        }

        /// <summary>
        /// Makes the GraphicsContext current on the calling thread.
        /// </summary>
        public void MakeCurrent()
        {
            if (Context == null)
            {
                throw new InvalidOperationException("Cannot make a context current when running with ContextAPI.NoAPI.");
            }

            Context?.MakeCurrent();
        }

        /// <summary>
        /// Processes pending window events and waits <paramref name="timeout"/> seconds for events.
        /// </summary>
        /// <param name="timeout">The timeout in seconds.</param>
        /// <returns>This function will always return true.</returns>
        public bool ProcessEvents(double timeout)
        {
            GLFW.WaitEventsTimeout(timeout);

            ProcessInputEvents();

            RethrowCallbackExceptionsIfNeeded();

            // FIXME: Remove this return and the documentation comment about it
            return true;
        }

        /// <summary>
        /// Processes pending window events.
        /// </summary>
        [Obsolete("This function wrongly implies that only events from this window are processed, while in fact events for all windows are processed. Use NativeWindow.ProcessWindowEvents() instead.")]
        public virtual void ProcessEvents()
        {
            ProcessInputEvents();

            ProcessWindowEvents(IsEventDriven);
        }

        /// <summary>
        /// Processes pending window events, either by calling <see cref="GLFW.WaitEvents"/> or <see cref="GLFW.PollEvents"/> depending on if <paramref name="waitForEvents"/> is set to true or not.
        /// </summary>
        /// <remarks>This function should only be called from the main thread.</remarks>
        /// <param name="waitForEvents">Whether to call <see cref="GLFW.WaitEvents()"/> or <see cref="GLFW.PollEvents()"/>.</param>
        public static void ProcessWindowEvents(bool waitForEvents)
        {
            if (waitForEvents)
            {
                GLFW.WaitEvents();
            }
            else
            {
                GLFW.PollEvents();
            }

            RethrowCallbackExceptionsIfNeeded();
        }

        // This list must only ever be accessed from the main thread, inside RethrowCallbackExceptionsIfNeeded().
        private static List<ExceptionDispatchInfo> _localThreadExceptions = new List<ExceptionDispatchInfo>();

        private static void RethrowCallbackExceptionsIfNeeded()
        {
            // Pull a thread-local copy of the exceptions from the queue.  This is thread-safe,
            // always collecting up the queue to a known specific instant in time.
            while (_callbackExceptions.TryDequeue(out ExceptionDispatchInfo exception))
            {
                _localThreadExceptions.Add(exception);
            }

            if (_localThreadExceptions.Count == 1)
            {
                ExceptionDispatchInfo exception = _localThreadExceptions[0];
                _localThreadExceptions.Clear();
                exception.Throw();
            }
            else if (_localThreadExceptions.Count > 1)
            {
                // FIXME: This doesn't seem to produce great exception messages... is there something we can do about this?
                Exception[] exceptions = new Exception[_localThreadExceptions.Count];
                for (int i = 0; i < _localThreadExceptions.Count; i++)
                {
                    exceptions[i] = _localThreadExceptions[i].SourceException;
                }
                Exception exception = new AggregateException("Multiple exceptions in callback handlers while processing events.", exceptions);
                _localThreadExceptions.Clear();
                throw exception;
            }
        }

        /// <summary>
        /// Updates the input state in preparation for a call to <see cref="GLFW.PollEvents"/> or <see cref="GLFW.WaitEvents"/>.
        /// Do not call this function if you are calling <see cref="ProcessEvents()"/> or if you are running the window using <see cref="GameWindow.Run()"/>.
        /// </summary>
        public unsafe void ProcessInputEvents()
        {
            MouseState.Update();
            KeyboardState.Update();

            GLFW.GetCursorPos(WindowPtr, out var x, out var y);
            MouseState.Position = new Vector2((float)x, (float)y);

            for (var i = 0; i < _joystickStates.Length; i++)
            {
                if (_joystickStates[i] == null)
                {
                    continue;
                }

                _joystickStates[i].Update();
            }
        }

        /// <summary>
        /// Transforms the specified point from screen to client coordinates.
        /// </summary>
        /// <param name="point">
        /// A <see cref="OpenTK.Mathematics.Vector2" /> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to client coordinates.
        /// </returns>
        public Vector2i PointToClient(Vector2i point)
        {
            return point - Location;
        }

        /// <summary>
        /// Transforms the specified point from client to screen coordinates.
        /// </summary>
        /// <param name="point">
        /// A <see cref="OpenTK.Mathematics.Vector2" /> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to screen coordinates.
        /// </returns>
        public Vector2i PointToScreen(Vector2i point)
        {
            return point + Location;
        }

        /// <summary>
        /// Occurs whenever the window is moved.
        /// </summary>
        public event Action<WindowPositionEventArgs> Move;

        /// <summary>
        /// Occurs whenever the window is resized.
        /// </summary>
        public event Action<ResizeEventArgs> Resize;

        /// <summary>
        /// Occurs whenever the window is refreshed.
        /// </summary>
        public event Action Refresh;

        /// <summary>
        /// Occurs when the window is about to close.
        /// </summary>
        public event Action<CancelEventArgs> Closing;

        /// <summary>
        /// Occurs after the window has closed.
        /// </summary>
        [Obsolete("This event will never be invoked.")]
        public event Action Closed;

        /// <summary>
        /// Occurs when the window is minimized.
        /// <para> WARNING: During this callback <see cref="ClientSize"/> will not be guaranteed to contain the new size of the window.</para>
        /// </summary>
        public event Action<MinimizedEventArgs> Minimized;

        /// <summary>
        /// Occurs when the window is maximized.
        /// <para> WARNING: During this callback <see cref="ClientSize"/> will not be guaranteed to contain the new size of the window.</para>
        /// </summary>
        public event Action<MaximizedEventArgs> Maximized;

        /// <summary>
        /// Occurs when a joystick is connected or disconnected.
        /// </summary>
        public event Action<JoystickEventArgs> JoystickConnected;

        /// <summary>
        /// Occurs when the <see cref="NativeWindow.IsFocused" /> property of the window changes.
        /// </summary>
        public event Action<FocusedChangedEventArgs> FocusedChanged;

        /// <summary>
        /// Occurs whenever a keyboard key is pressed.
        /// </summary>
        public event Action<KeyboardKeyEventArgs> KeyDown;

        /// <summary>
        /// Occurs whenever a Unicode code point is typed.
        /// </summary>
        public event Action<TextInputEventArgs> TextInput;

        /// <summary>
        /// Occurs whenever a keyboard key is released.
        /// </summary>
        public event Action<KeyboardKeyEventArgs> KeyUp;

        /// <summary>
        /// Occurs when a <see cref="MonitorHandle"/> is connected or disconnected.
        /// </summary>
        [Obsolete("Use the Monitors.OnMonitorConnected event instead.", true)]
        public event Action<MonitorEventArgs> MonitorConnected;

        /// <summary>
        /// Occurs whenever the mouse cursor leaves the window <see cref="NativeWindow.Bounds" />.
        /// </summary>
        public event Action MouseLeave;

        /// <summary>
        /// Occurs whenever the mouse cursor enters the window <see cref="NativeWindow.Bounds" />.
        /// </summary>
        public event Action MouseEnter;

        /// <summary>
        /// Occurs whenever a <see cref="MouseButton" /> is clicked.
        /// </summary>
        public event Action<MouseButtonEventArgs> MouseDown;

        /// <summary>
        /// Occurs whenever a <see cref="MouseButton" /> is released.
        /// </summary>
        public event Action<MouseButtonEventArgs> MouseUp;

        /// <summary>
        /// Occurs whenever the mouse cursor is moved;
        /// </summary>
        public event Action<MouseMoveEventArgs> MouseMove;

        /// <summary>
        /// Occurs whenever a mouse wheel is moved;
        /// </summary>
        public event Action<MouseWheelEventArgs> MouseWheel;

        /// <summary>
        /// Occurs whenever one or more files are dropped on the window.
        /// </summary>
        public event Action<FileDropEventArgs> FileDrop;

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this key is currently down.
        /// </summary>
        /// <param name="key">The <see cref="Keys">key</see> to check.</param>
        /// <returns><c>true</c> if <paramref name="key"/> is in the down state; otherwise, <c>false</c>.</returns>
        public bool IsKeyDown(Keys key)
        {
            return KeyboardState.IsKeyDown(key);
        }

        /// <summary>
        ///     Gets whether the specified key is pressed in the current frame but released in the previous frame.
        /// </summary>
        /// <remarks>
        ///     "Frame" refers to invocations of <see cref="NativeWindow.ProcessEvents()"/> here.
        /// </remarks>
        /// <param name="key">The <see cref="Keys">key</see> to check.</param>
        /// <returns>True if the key is pressed in this frame, but not the last frame.</returns>
        public bool IsKeyPressed(Keys key)
        {
            return KeyboardState.IsKeyDown(key) && !KeyboardState.WasKeyDown(key);
        }

        /// <summary>
        ///     Gets whether the specified key is released in the current frame but pressed in the previous frame.
        /// </summary>
        /// <remarks>
        ///     "Frame" refers to invocations of <see cref="NativeWindow.ProcessEvents()"/> here.
        /// </remarks>
        /// <param name="key">The <see cref="Keys">key</see> to check.</param>
        /// <returns>True if the key is released in this frame, but pressed the last frame.</returns>
        public bool IsKeyReleased(Keys key)
        {
            return !KeyboardState.IsKeyDown(key) && KeyboardState.WasKeyDown(key);
        }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this button is currently down.
        /// </summary>
        /// <param name="button">The <see cref="MouseButton" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="button"/> is in the down state; otherwise, <c>false</c>.</returns>
        public bool IsMouseButtonDown(MouseButton button)
        {
            return MouseState.IsButtonDown(button);
        }

        /// <summary>
        ///     Gets whether the specified mouse button is pressed in the current frame but released in the previous frame.
        /// </summary>
        /// <remarks>
        ///     "Frame" refers to invocations of <see cref="NativeWindow.ProcessEvents()"/> here.
        /// </remarks>
        /// <param name="button">The button to check.</param>
        /// <returns>True if the button is pressed in this frame, but not the last frame.</returns>
        public bool IsMouseButtonPressed(MouseButton button)
        {
            return MouseState.IsButtonDown(button) && !MouseState.WasButtonDown(button);
        }

        /// <summary>
        ///     Gets whether the specified mouse button is released in the current frame but pressed in the previous frame.
        /// </summary>
        /// <remarks>
        ///     "Frame" refers to invocations of <see cref="NativeWindow.ProcessEvents()"/> here.
        /// </remarks>
        /// <param name="button">The button to check.</param>
        /// <returns>True if the button is released in this frame, but pressed the last frame.</returns>
        public bool IsMouseButtonReleased(MouseButton button)
        {
            return !MouseState.IsButtonDown(button) && MouseState.WasButtonDown(button);
        }

        /// <summary>
        /// Find the monitor this window is currently in.
        /// </summary>
        /// <returns>The monitor the window is in, if found.</returns>
        /// <remarks>
        /// This method first tries to find the monitor by querying the GLFW
        /// backend. However this rarely works, so this function invokes
        /// <see cref="Monitors.GetMonitorFromWindow(NativeWindow)"/>
        /// to find it.
        /// </remarks>
        [Obsolete("Use Monitors.GetMonitorFromWindow instead", true)]
        public unsafe MonitorInfo FindMonitor()
        {
            return Monitors.GetMonitorFromWindow(WindowPtr);
        }

        /// <summary>
        /// Gets the current monitor scale.
        /// </summary>
        /// <param name="horizontalScale">Horizontal scale.</param>
        /// <param name="verticalScale">Vertical scale.</param>
        /// <returns><c>true</c>, if current monitor scale was gotten correctly, <c>false</c> otherwise.</returns>
        public unsafe bool TryGetCurrentMonitorScale(out float horizontalScale, out float verticalScale)
        {
            MonitorInfo info = Monitors.GetMonitorFromWindow(this);
            horizontalScale = info.HorizontalScale;
            verticalScale = info.VerticalScale;
            return true;
        }

        /// <summary>
        /// Gets the dpi of the current monitor.
        /// </summary>
        /// <param name="horizontalDpi">Horizontal dpi.</param>
        /// <param name="verticalDpi">Vertical dpi.</param>
        /// <returns><c>true</c>, if current monitor's dpi was gotten correctly, <c>false</c> otherwise.</returns>
        /// <remarks>
        /// This methods approximates the dpi of the monitor by multiplying
        /// the monitor scale received from <see cref="TryGetCurrentMonitorScale(out float, out float)"/>
        /// by each platforms respective default dpi (72 for macOS and 96 for other systems).
        /// </remarks>
        public unsafe bool TryGetCurrentMonitorDpi(out float horizontalDpi, out float verticalDpi)
        {
            MonitorInfo info = Monitors.GetMonitorFromWindow(this);
            horizontalDpi = info.HorizontalDpi;
            verticalDpi = info.VerticalDpi;
            return true;
        }

        /// <summary>
        /// Gets the raw dpi of current monitor.
        /// </summary>
        /// <param name="horizontalRawDpi">Raw horizontal dpi.</param>
        /// <param name="verticalRawDpi">Raw vertical dpi.</param>
        /// <returns><c>true</c>, if current monitor's raw dpi was gotten correctly, <c>false</c> otherwise.</returns>
        /// <remarks>
        /// This method calculates dpi by retrieving monitor dimensions and resolution.
        /// However on certain platforms (such as Windows) these values may not
        /// be scaled correctly.
        /// </remarks>
        public unsafe bool TryGetCurrentMonitorDpiRaw(out float horizontalRawDpi, out float verticalRawDpi)
        {
            MonitorInfo info = Monitors.GetMonitorFromWindow(this);
            horizontalRawDpi = info.HorizontalRawDpi;
            verticalRawDpi = info.VerticalRawDpi;
            return true;
        }

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
        [Obsolete("This method will never be called.")]
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
        [Obsolete("Use the Monitors.OnMonitorConnected event instead.", true)]
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
        /// <para>Raises the <see cref="OnMinimized"/> event.</para>
        /// <para> WARNING: During this callback <see cref="ClientSize"/> will not be guaranteed to contain the new size of the window.</para>
        /// </summary>
        /// <param name="e">A <see cref="MinimizedEventArgs"/> that contains the event data.</param>
        protected virtual void OnMinimized(MinimizedEventArgs e)
        {
            _windowState = e.IsMinimized ? WindowState.Minimized : GetWindowStateFromGLFW();

            Minimized?.Invoke(e);
        }

        /// <summary>
        /// <para>Raises the <see cref="OnMaximized"/> event.</para>
        /// <para>WARNING: During this callback <see cref="ClientSize"/> will not be guaranteed to contain the new size of the window.</para>
        /// </summary>
        /// <param name="e">A <see cref="MaximizedEventArgs"/> that contains the event data.</param>
        protected virtual void OnMaximized(MaximizedEventArgs e)
        {
            _windowState = e.IsMaximized ? WindowState.Maximized : GetWindowStateFromGLFW();

            Maximized?.Invoke(e);
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
        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_disposedValue)
            {
                return;
            }

            if (disposing)
            {
            }

            if (GLFWProvider.IsOnMainThread)
            {
                UnregisterWindowCallbacks();
                GLFW.DestroyWindow(WindowPtr);
                Exists = false;
            }
            else
            {
                throw new GLFWException("You can only dispose windows on the main thread. The window needs to be disposed as it cannot safely be disposed in the finalizer.");
            }

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

        /// <summary>
        /// Centers the <see cref="NativeWindow"/> on the monitor where resides.
        /// </summary>
        public void CenterWindow() => CenterWindow(Size);

        /// <summary>
        /// Centers and resizes the <see cref="NativeWindow"/> on the monitor where resides.
        /// </summary>
        /// <param name="newSize">The size to make the centered window.</param>
        public void CenterWindow(Vector2i newSize)
        {
            // Find out which monitor the window is already on.
            MonitorInfo monitorInfo = Monitors.GetMonitorFromWindow(this);

            // Calculate a suitable upper-left corner for the window, based on this monitor's
            // coordinates.  This should work correctly even in unusual multi-monitor layouts.
            Box2i monitorRectangle = monitorInfo.ClientArea;
            int x = (monitorRectangle.Min.X + monitorRectangle.Max.X - newSize.X) / 2;
            int y = (monitorRectangle.Min.Y + monitorRectangle.Max.Y - newSize.Y) / 2;

            // Avoid putting it offscreen.
            if (x < monitorRectangle.Min.X)
            {
                x = monitorRectangle.Min.X;
            }

            if (y < monitorRectangle.Min.Y)
            {
                y = monitorRectangle.Min.Y;
            }

            // Actually move the window.
            ClientRectangle = new Box2i(x, y, x + newSize.X, y + newSize.Y);
        }
    }
}
