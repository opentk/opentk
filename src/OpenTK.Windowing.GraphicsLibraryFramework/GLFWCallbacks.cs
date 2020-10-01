//
// GLFWCallbacks.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    ///     Class containing GLFW related callbacks.
    /// </summary>
    public static unsafe class GLFWCallbacks
    {
        /// <summary>
        ///     The function signature for Unicode character callback functions.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="codepoint">The Unicode code point of the character.</param>
        /// <seealso cref="GLFW.SetCharCallback" />
        public delegate void CharCallback(Window* window, uint codepoint);

        /// <summary>
        ///     The function signature for Unicode character with modifiers callback functions.
        ///     It is called for each input character, regardless of what modifier keys are held down.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="codepoint">The Unicode code point of the character.</param>
        /// <param name="modifiers">Bit field describing which modifier keys were held down.</param>
        /// <seealso cref="GLFW.SetCharModsCallback" />
        public delegate void CharModsCallback(Window* window, uint codepoint, KeyModifiers modifiers);

        /// <summary>
        ///     The function signature for cursor enter/leave callback functions.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="entered"><c>true</c> if the cursor entered the window's client area, or <c>false</c> if it left it.</param>
        /// <seealso cref="GLFW.SetCursorEnterCallback" />
        public delegate void CursorEnterCallback(Window* window, bool entered);

        /// <summary>
        ///     The function signature for cursor position callback functions.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="x">The new cursor x-coordinate, relative to the left edge of the client area.</param>
        /// <param name="y">The new cursor y-coordinate, relative to the top edge of the client area.</param>
        /// <seealso cref="GLFW.SetCursorPosCallback" />
        public delegate void CursorPosCallback(Window* window, double x, double y);

        /// <summary>
        ///     The function signature for file drop callbacks.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="count">The number of dropped files.</param>
        /// <param name="paths">The UTF-8 encoded file and/or directory path names.</param>
        /// <seealso cref="GLFW.SetDropCallback" />
        public delegate void DropCallback(Window* window, int count, byte** paths);

        /// <summary>
        ///     The function signature for error callback functions.
        /// </summary>
        /// <param name="error">An error code.</param>
        /// <param name="description">A UTF-8 encoded string describing the error.</param>
        public delegate void ErrorCallback(ErrorCode error, string description);

        /// <summary>
        ///     The function signature for framebuffer size callback functions.
        /// </summary>
        /// <param name="window">The window whose framebuffer was resized.</param>
        /// <param name="width">The new width, in pixels, of the framebuffer.</param>
        /// <param name="height">The new height, in pixels, of the framebuffer.</param>
        /// <seealso cref="GLFW.SetFramebufferSizeCallback" />
        public delegate void FramebufferSizeCallback(Window* window, int width, int height);

        /// <summary>
        ///     The function signature for joystick configuration callback functions.
        /// </summary>
        /// <param name="joystick">The joystick that was connected or disconnected.</param>
        /// <param name="state">
        ///     One of <see cref="ConnectedState.Connected" /> or <see cref="ConnectedState.Disconnected" />.
        /// </param>
        /// <seealso cref="GLFW.SetJoystickCallback" />
        public delegate void JoystickCallback(int joystick, ConnectedState state);

        /// <summary>
        ///     The function signature for keyboard key callback functions.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="key">The keyboard key that was pressed or released.</param>
        /// <param name="scanCode">The system-specific scancode of the key.</param>
        /// <param name="action">The <see cref="InputAction" /> for that <paramref name="key" />.</param>
        /// <param name="mods">Bit field describing which modifier keys were held down.</param>
        /// <seealso cref="GLFW.SetKeyCallback" />
        public delegate void KeyCallback(Window* window, Keys key, int scanCode, InputAction action, KeyModifiers mods);

        /// <summary>
        ///     The function signature for monitor configuration callback functions.
        /// </summary>
        /// <param name="monitor">The monitor that was connected or disconnected.</param>
        /// <param name="state">
        ///     One <see cref="ConnectedState.Connected" /> of  or <see cref="ConnectedState.Disconnected" />.
        /// </param>
        /// <seealso cref="GLFW.SetMonitorCallback" />
        public delegate void MonitorCallback(Monitor* monitor, ConnectedState state);

        /// <summary>
        ///     The function signature for mouse button callback functions.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="button">The mouse button that was pressed or released.</param>
        /// <param name="action">One of <see cref="InputAction.Press" /> or <see cref="InputAction.Release" />.</param>
        /// <param name="mods">Bit field describing which modifier keys were held down.</param>
        /// <seealso cref="GLFW.SetMouseButtonCallback" />
        public delegate void MouseButtonCallback(Window* window, MouseButton button, InputAction action, KeyModifiers mods); // TODO: Make enums for int params in callback

        /// <summary>
        ///     The function signature for scroll callback functions.
        /// </summary>
        /// <param name="window">The window that received the event.</param>
        /// <param name="offsetX">The scroll offset along the x-axis.</param>
        /// <param name="offsetY">The scroll offset along the y-axis.</param>
        /// <seealso cref="GLFW.SetScrollCallback" />
        public delegate void ScrollCallback(Window* window, double offsetX, double offsetY);

        /// <summary>
        ///     The function signature for window close callback functions.
        /// </summary>
        /// <param name="window">The window that the user attempted to close.</param>
        /// <seealso cref="GLFW.SetWindowCloseCallback" />
        public delegate void WindowCloseCallback(Window* window);

        /// <summary>
        ///     This is the function pointer type for window content scale callbacks.
        /// </summary>
        /// <param name="window">The window whose content scale changed. </param>
        /// <param name="xscale">The new x-axis content scale of the window. </param>
        /// <param name="yscale">The new y-axis content scale of the window.</param>
        /// <seealso cref="GLFW.SetWindowContentScaleCallback" />
        public delegate void WindowContentScaleCallback(Window* window, float xscale, float yscale);

        /// <summary>
        ///     The function signature for window focus callback functions.
        /// </summary>
        /// <param name="window">The window that gained or lost input focus.</param>
        /// <param name="focused"><c>true</c> if the window was given input focus, or <c>false</c> if it lost it.</param>
        /// <seealso cref="GLFW.SetWindowFocusCallback" />
        public delegate void WindowFocusCallback(Window* window, bool focused);

        /// <summary>
        ///     The function signature for window iconify/restore callback functions.
        /// </summary>
        /// <param name="window">The window that was iconified or restored.</param>
        /// <param name="iconified"><c>true</c> if the window was iconified(minimized), or <c>false</c> if it was restored.</param>
        /// <seealso cref="GLFW.SetWindowIconifyCallback" />
        public delegate void WindowIconifyCallback(Window* window, bool iconified);

        /// <summary>
        ///     The function signature for window maximize/restore callback functions.
        /// </summary>
        /// <param name="window">The window that was maximized or restored.</param>
        /// <param name="maximized"><c>true</c> if the window was maximized, or <c>false</c> if it was restored.</param>
        /// <seealso cref="GLFW.SetWindowMaximizeCallback" />
        public delegate void WindowMaximizeCallback(Window* window, bool maximized);

        /// <summary>
        ///     The function signature for window position callback functions.
        /// </summary>
        /// <param name="window">The window that was moved.</param>
        /// <param name="x">
        ///     The new x-coordinate, in screen coordinates, of the upper-left corner of the client area of the window.
        /// </param>
        /// <param name="y">
        ///     The new y-coordinate, in screen coordinates, of the upper-left corner of the client area of the window.
        /// </param>
        /// <seealso cref="GLFW.SetWindowPosCallback" />
        public delegate void WindowPosCallback(Window* window, int x, int y);

        /// <summary>
        ///     The function signature for window refresh functions.
        /// </summary>
        /// <param name="window">The window that needs to be refreshed.</param>
        public delegate void WindowRefreshCallback(Window* window);

        /// <summary>
        ///     The function signature for window size callback functions.
        /// </summary>
        /// <param name="window">The window that was resized.</param>
        /// <param name="width">The new width, in screen coordinates, of the window.</param>
        /// <param name="height">The new height, in screen coordinates, of the window.</param>
        /// <seealso cref="GLFW.SetWindowSizeCallback" />
        public delegate void WindowSizeCallback(Window* window, int width, int height);
    }
}
