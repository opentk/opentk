//
// INativeWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.ComponentModel;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common.Input;

namespace OpenTK.Windowing.Common
{
    /// <summary>
    /// Defines the interface for a NativeWindow.
    /// </summary>
    public interface INativeWindow : IDisposable
    {
        /// <summary>
        /// Gets a value indicating whether the shutdown sequence has been initiated
        /// for this window, by calling GameWindow.Exit() or hitting the 'close' button.
        /// If this property is true, it is no longer safe to use any OpenTK.Input or
        /// OpenTK.Graphics.OpenGL functions or properties.
        /// </summary>
        bool IsExiting { get; }

        /// <summary>
        /// Gets or sets the clipboard string.
        /// </summary>
        string ClipboardString { get; set; }

        /// <summary>
        /// Gets a value indicating whether the window has been created and has not been destroyed.
        /// </summary>
        bool Exists { get; }

        /// <summary>
        /// Gets or sets the current <see cref="WindowIcon" /> for this window.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This does nothing on macOS; on that platform, the icon is determined by the application bundle.
        /// </para>
        /// </remarks>
        WindowIcon Icon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not this window is event-driven.
        /// An event-driven window will wait for events before updating/rendering. It is useful for non-game applications,
        /// where the program only needs to do any processing after the user inputs something.
        /// </summary>
        bool IsEventDriven { get; set; }

        /// <summary>
        /// Gets or sets the current monitor.
        /// </summary>
        Monitor CurrentMonitor { get; set; }

        /// <summary>
        /// Gets a value representing the current graphics API.
        /// </summary>
        ContextAPI API { get; }

        /// <summary>
        /// Gets a value representing the current graphics API profile.
        /// </summary>
        ContextProfile Profile { get; }

        /// <summary>
        /// Gets a value representing the current graphics profile flags.
        /// </summary>
        ContextFlags Flags { get; }

        /// <summary>
        /// Gets a value representing the current version of the graphics API.
        /// </summary>
        Version APIVersion { get; }

        /// <summary>
        /// Gets the graphics context associated with this NativeWindow.
        /// </summary>
        IGraphicsContext Context { get; }

        /// <summary>
        /// Gets or sets the title of the window.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this window has input focus.
        /// </summary>
        /// <remarks>
        /// A window cannot be manually unfocused by setting this to false.
        /// </remarks>
        bool IsFocused { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the window is visible.
        /// </summary>
        bool IsVisible { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="WindowState" /> for this window.
        /// </summary>
        WindowState WindowState { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="WindowBorder" /> for this window.
        /// </summary>
        WindowBorder WindowBorder { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="OpenTK.Mathematics.Box2i" /> structure the contains the external bounds of this window,
        /// in screen coordinates.
        /// External bounds include the title bar, borders and drawing area of the window.
        /// </summary>
        Box2i Bounds { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="OpenTK.Mathematics.Vector2i" /> structure that contains the location of this window on the
        /// desktop.
        /// </summary>
        Vector2i Location { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="OpenTK.Mathematics.Vector2i" /> structure that contains the external size of this window.
        /// </summary>
        Vector2i Size { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="OpenTK.Mathematics.Box2i" /> structure that contains the internal bounds of this window,
        /// in client coordinates.
        /// The internal bounds include the drawing area of the window, but exclude the titlebar and window borders.
        /// </summary>
        Box2i ClientRectangle { get; set; }

        /// <summary>
        /// Gets a <see cref="OpenTK.Mathematics.Vector2i" /> structure that contains the internal size this window.
        /// </summary>
        Vector2i ClientSize { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the window is fullscreen or not.
        /// </summary>
        bool IsFullscreen { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="OpenTK.Windowing.Common.Input.MouseCursor" /> for this window.
        /// </summary>
        /// <value>The cursor.</value>
        MouseCursor Cursor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mouse cursor is visible.
        /// </summary>
        bool CursorVisible { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mouse cursor is confined inside the window size.
        /// </summary>
        bool CursorGrabbed { get; set; }

        /// <summary>
        /// Gets the current state of the joysticks as of the last time the window processed events.
        /// </summary>
        JoystickState[] JoystickStates { get; }

        /// <summary>
        /// Gets the previous joystick state.
        /// This value is updated with the new state every time the window processes events.
        /// </summary>
        JoystickState[] LastJoystickStates { get; }

        /// <summary>
        ///     Gets the current state of the keyboard as of the last time the window processed events.
        /// </summary>
        KeyboardState KeyboardState { get; }

        /// <summary>
        ///     Gets the previous keyboard state.
        ///     This value is updated with the new state every time the window processes events.
        /// </summary>
        KeyboardState LastKeyboardState { get; }

        /// <summary>
        ///     Gets or sets the position of the mouse relative to the content area of this window.
        /// </summary>
        Vector2 MousePosition { get; set; }

        /// <summary>
        ///     Gets the amount that the mouse moved since the last frame.
        /// </summary>
        /// <summary>
        ///     This does not necessarily correspond to pixels, for example in the case of raw input.
        /// </summary>
        Vector2 MouseDelta { get; }

        /// <summary>
        ///     Gets the current state of the mouse as of the last time the window processed events.
        /// </summary>
        MouseState MouseState { get; }

        /// <summary>
        ///     Gets the previous keyboard state.
        ///     This value is updated with the new state every time the window processes events.
        /// </summary>
        MouseState LastMouseState { get; }

        /// <summary>
        /// Gets a value indicating whether any key is down.
        /// </summary>
        /// <value><c>true</c> if any key is down; otherwise, <c>false</c>.</value>
        bool IsAnyKeyDown { get; }

        /// <summary>
        /// Gets a value indicating whether any mouse button is pressed.
        /// </summary>
        /// <value><c>true</c> if any button is pressed; otherwise, <c>false</c>.</value>
        bool IsAnyMouseButtonDown { get; }

        /// <summary>
        /// Closes this window.
        /// </summary>
        void Close();

        /// <summary>
        /// Processes pending window events.
        /// </summary>
        void ProcessEvents();

        /// <summary>
        /// Processes pending window events and waits <paramref cref="timeout"/> seconds for events.
        /// </summary>
        /// <param name="timeout">The timeout in seconds.</param>
        /// <returns><c>true</c> if events where processed; otherwise <c>false</c>
        /// (Event processing not possible anymore, window is about to be destroyed).</returns>
        bool ProcessEvents(double timeout);

        /// <summary>
        /// Makes the GraphicsContext current on the calling thread.
        /// </summary>
        void MakeCurrent();

        /// <summary>
        /// Transforms the specified point from screen to client coordinates.
        /// </summary>
        /// <param name="point">
        /// A <see cref="OpenTK.Mathematics.Vector2" /> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to client coordinates.
        /// </returns>
        Vector2i PointToClient(Vector2i point);

        /// <summary>
        /// Transforms the specified point from client to screen coordinates.
        /// </summary>
        /// <param name="point">
        /// A <see cref="OpenTK.Mathematics.Vector2" /> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to screen coordinates.
        /// </returns>
        Vector2i PointToScreen(Vector2i point);

        /// <summary>
        /// Gets the current monitor scale.
        /// </summary>
        /// <param name="horizontalScale">Horizontal scale.</param>
        /// <param name="verticalScale">Vertical scale.</param>
        /// <returns><c>true</c>, if current monitor scale was gotten correctly, <c>false</c> otherwise.</returns>
        bool TryGetCurrentMonitorScale(out float horizontalScale, out float verticalScale);

        /// <summary>
        /// Gets the dpi of the current monitor.
        /// </summary>
        /// <param name="horizontalDpi">Horizontal dpi.</param>
        /// <param name="verticalDpi">Vertical dpi.</param>
        /// <returns><c>true</c>, if current monitor's dpi was gotten correctly, <c>false</c> otherwise.</returns>
        /// <remarks>
        /// This methods approximates the dpi of the monitor by multiplying
        /// the monitor scale recieved from <see cref="TryGetCurrentMonitorScale(out float, out float)"/>
        /// by each platforms respective default dpi (72 for macOS and 96 for other systems).
        /// </remarks>
        bool TryGetCurrentMonitorDpi(out float horizontalDpi, out float verticalDpi);

        /// <summary>
        /// Gets the raw dpi of current monitor.
        /// </summary>
        /// <param name="horizontalDpi">Horizontal dpi.</param>
        /// <param name="verticalDpi">Vertical dpi.</param>
        /// <returns><c>true</c>, if current monitor's raw dpi was gotten correctly, <c>false</c> otherwise.</returns>
        /// <remarks>
        /// This method calculates dpi by retrieving monitor dimensions and resolution.
        /// However on certain platforms (such as Windows) these values may not
        /// be scaled correctly.
        /// </remarks>
        bool TryGetCurrentMonitorDpiRaw(out float horizontalDpi, out float verticalDpi);

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this key is currently down.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="key"/> is in the down state; otherwise, <c>false</c>.</returns>
        bool IsKeyDown(Key key);

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this key is currently up.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="key"/> is in the up state; otherwise, <c>false</c>.</returns>
        bool IsKeyUp(Key key);

        /// <summary>
        ///     Gets whether the specified key is pressed in the current frame but released in the previous frame.
        /// </summary>
        /// <remarks>
        ///     "Frame" refers to invocations of <see cref="INativeWindow.ProcessEvents"/> here.
        /// </remarks>
        /// <param name="key">The key to check.</param>
        /// <returns>True if the key is pressed in this frame, but not the last frame.</returns>
        bool IsKeyPressed(Key key);

        /// <summary>
        ///     Gets whether the specified key is released in the current frame but pressed in the previous frame.
        /// </summary>
        /// <remarks>
        ///     "Frame" refers to invocations of <see cref="INativeWindow.ProcessEvents"/> here.
        /// </remarks>
        /// <param name="key">The key to check.</param>
        /// <returns>True if the key is released in this frame, but pressed the last frame.</returns>
        bool IsKeyReleased(Key key);

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this button is currently down.
        /// </summary>
        /// <param name="button">The <see cref="MouseButton" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="button"/> is in the down state; otherwise, <c>false</c>.</returns>
        bool IsMouseButtonDown(MouseButton button);

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this mouse button is currently up.
        /// </summary>
        /// <param name="button">The <see cref="MouseButton" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="button"/> is in the up state; otherwise, <c>false</c>.</returns>
        bool IsMouseButtonUp(MouseButton button);

        /// <summary>
        ///     Gets whether the specified mouse button is pressed in the current frame but released in the previous frame.
        /// </summary>
        /// <remarks>
        ///     "Frame" refers to invocations of <see cref="INativeWindow.ProcessEvents()"/> here.
        /// </remarks>
        /// <param name="button">The button to check.</param>
        /// <returns>True if the button is pressed in this frame, but not the last frame.</returns>
        bool IsMouseButtonPressed(MouseButton button);

        /// <summary>
        ///     Gets whether the specified mouse button is released in the current frame but pressed in the previous frame.
        /// </summary>
        /// <remarks>
        ///     "Frame" refers to invocations of <see cref="INativeWindow.ProcessEvents"/> here.
        /// </remarks>
        /// <param name="button">The button to check.</param>
        /// <returns>True if the button is released in this frame, but pressed the last frame.</returns>
        bool IsMouseButtonReleased(MouseButton button);

        /// <summary>
        /// Occurs whenever the window is moved.
        /// </summary>
        event Action<WindowPositionEventArgs> Move;

        /// <summary>
        /// Occurs whenever the window is resized.
        /// </summary>
        event Action<ResizeEventArgs> Resize;

        /// <summary>
        /// Occurs whenever the window is refreshed.
        /// </summary>
        event Action Refresh;

        /// <summary>
        /// Occurs when the window is about to close.
        /// </summary>
        event Action<CancelEventArgs> Closing;

        /// <summary>
        /// Occurs after the window has closed.
        /// </summary>
        event Action Closed;

        /// <summary>
        /// Occurs when the window is minimized.
        /// </summary>
        event Action<MinimizedEventArgs> Minimized;

        /// <summary>
        /// Occurs when a joystick is connected or disconnected.
        /// </summary>
        event Action<JoystickEventArgs> JoystickConnected;

        /// <summary>
        /// Occurs when the <see cref="INativeWindowProperties.IsFocused" /> property of the window changes.
        /// </summary>
        event Action<FocusedChangedEventArgs> FocusedChanged;

        /// <summary>
        /// Occurs whenever a keyboard key is pressed.
        /// </summary>
        event Action<KeyboardKeyEventArgs> KeyDown;

        /// <summary>
        /// Occurs whenever a Unicode code point is typed.
        /// </summary>
        event Action<TextInputEventArgs> TextInput;

        /// <summary>
        /// Occurs whenever a keyboard key is released.
        /// </summary>
        event Action<KeyboardKeyEventArgs> KeyUp;

        /// <summary>
        /// Occurs when a <see cref="Monitor"/> is connected or disconnected.
        /// </summary>
        event Action<MonitorEventArgs> MonitorConnected;

        /// <summary>
        /// Occurs whenever the mouse cursor leaves the window <see cref="INativeWindowProperties.Bounds" />.
        /// </summary>
        event Action MouseLeave;

        /// <summary>
        /// Occurs whenever the mouse cursor enters the window <see cref="INativeWindowProperties.Bounds" />.
        /// </summary>
        event Action MouseEnter;

        /// <summary>
        /// Occurs whenever a <see cref="Input.MouseButton" /> is clicked.
        /// </summary>
        event Action<MouseButtonEventArgs> MouseDown;

        /// <summary>
        /// Occurs whenever a <see cref="Input.MouseButton" /> is released.
        /// </summary>
        event Action<MouseButtonEventArgs> MouseUp;

        /// <summary>
        /// Occurs whenever the mouse cursor is moved;
        /// </summary>
        event Action<MouseMoveEventArgs> MouseMove;

        /// <summary>
        /// Occurs whenever a mouse wheel is moved;
        /// </summary>
        event Action<MouseWheelEventArgs> MouseWheel;

        /// <summary>
        /// Occurs whenever one or more files are dropped on the window.
        /// </summary>
        event Action<FileDropEventArgs> FileDrop;
    }
}
