using OpenTK.Mathematics;

namespace OpenTK.Platform
{
    // FIXME: Better define the coordinate system for the mouse position.
    // Do we want to start using floats instead of ints for coordinates?

    /// <summary>
    /// A struct to contain information about the current mouse state.
    /// </summary>
    public struct MouseState
    {
        /// <summary>
        /// The mouse position in either screen coordinates (if received from <see cref="IMouseComponent.GetGlobalMouseState(out MouseState)"/>) 
        /// or window relative coordinates (if received from <see cref="IMouseComponent.GetMouseState(WindowHandle, out MouseState)"/>).
        /// </summary>
        public Vector2 Position;

        /// <summary>
        /// Virtual position of the scroll wheel.
        /// </summary>
        public Vector2 Scroll; // FIXME: Define this better

        /// <summary>
        /// Flags to indicate which mouse buttons are being pressed.
        /// </summary>
        public MouseButtonFlags PressedButtons;
    }

    /// <summary>
    /// Base interface for drivers which implement the mouse component.
    /// </summary>
    public interface IMouseComponent : IPalComponent
    {
        /// <summary>
        /// If it's possible to set the position of the mouse using <see cref="SetPosition(int, int)"/>.
        /// </summary>
        /// <seealso cref="SetPosition(int, int)"/>.
        bool CanSetMousePosition { get; }

        /// <summary>
        /// If raw mouse motion is supported on this platform.
        /// If this is <see langword="false"/> <see cref="IsRawMouseMotionEnabled(WindowHandle)"/> and <see cref="EnableRawMouseMotion(WindowHandle, bool)"/> should not be used.
        /// </summary>
        /// <seealso cref="IsRawMouseMotionEnabled(WindowHandle)"/>
        /// <seealso cref="EnableRawMouseMotion(WindowHandle, bool)"/>
        // FIXME: Maybe we should move raw mouse motion stuff to IWindowComponent as it's a per window setting?
        // - Noggin_bops 2024-07-31
        bool SupportsRawMouseMotion { get; }

        // FIXME: Should we report mouse positions using float?

        /// <summary>
        /// Get the global mouse cursor position.
        /// This function may query the mouse position outside of event processing to get the position of the mouse at the time this function is called.
        /// The mouse position returned is the mouse position as it is on screen, it will not return virtual coordinates when using <see cref="CursorCaptureMode.Locked"/>.
        /// </summary>
        /// <param name="globalPosition">Coordinate of the mouse in screen coordinates.</param>
        /// <seealso cref="GetPosition(WindowHandle, out Vector2i)"/>
        /// <seealso cref="SetGlobalPosition(Vector2)"/>
        void GetGlobalPosition(out Vector2 globalPosition);

        /// <summary>
        /// Gets the mouse position as seen from the specified window.
        /// This function takes into consideration only the mouse events that the specified window has received and does not represent global state.
        /// If the window has locked the cursor using <see cref="CursorCaptureMode.Locked"/>, this function will return virtual coordinates (unlike <see cref="GetGlobalPosition(out Vector2i)"/>).
        /// </summary>
        /// <param name="window">The window to get the mouse position for.</param>
        /// <param name="position">Coordinate of the mouse in client coordinates.</param>
        void GetPosition(WindowHandle window, out Vector2 position);

        /// <summary>
        /// Set the global mouse cursor position.
        /// Check that <see cref="CanSetMousePosition"/> is <see langword="true"/> before using this.
        /// </summary>
        /// <param name="newGlobalPosition">New coordinate of the mouse in screen space.</param>
        /// <seealso cref="GetGlobalPosition(out Vector2)"/>
        /// <seealso cref="CanSetMousePosition"/>
        void SetGlobalPosition(Vector2 newGlobalPosition);

        /// <summary>
        /// Fills the <paramref name="state"/> struct with the current mouse state.
        /// This function may query the mouse state outside of event processing to get the position of the mouse at the time this function is called.
        /// The <see cref="MouseState.Position"/> will be the screen mouse position and not virtual coordinates described by <see cref="CursorCaptureMode.Locked"/>.
        /// The <see cref="MouseState.Position"/> is in window screen coordinates.
        /// </summary>
        /// <param name="state">The current mouse state.</param>
        /// <seealso cref="GetMouseState(WindowHandle, out MouseState)"/>
        void GetGlobalMouseState(out MouseState state);

        /// <summary>
        /// Fills the <paramref name="state"/> struct with the current mouse state for the specified window.
        /// This function takes into consideration only the mouse events that the specified window has received and does not represent global state.
        /// If the window has locked the cursor using <see cref="CursorCaptureMode.Locked"/>, this function will return virtual coordinates (unlike <see cref="GetGlobalMouseState(out MouseState)"/>).
        /// The <see cref="MouseState.Position"/> is in window relative coordinates.
        /// </summary>
        /// <param name="window">The window to get the mouse state from.</param>
        /// <param name="state">The current mouse state.</param>
        /// <seealso cref="GetGlobalMouseState(out MouseState)"/>
        void GetMouseState(WindowHandle window, out MouseState state);

        /// <summary>
        /// Returns whether raw mouse motion is enabled for the given window or not.
        /// Check that <see cref="SupportsRawMouseMotion"/> is <see langword="true"/> before using this.
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <returns>If raw mouse motion is enabled.</returns>
        /// <seealso cref="SupportsRawMouseMotion"/>
        /// <seealso cref="EnableRawMouseMotion(WindowHandle, bool)"/>
        bool IsRawMouseMotionEnabled(WindowHandle window);

        /// <summary>
        /// Enables or disables raw mouse motion for a specific window.
        /// When raw mouse motion is enabled the window will receive <see cref="RawMouseMoveEventArgs"/> events,
        /// in addition to the normal <see cref="MouseMoveEventArgs"/> events.
        /// Check that <see cref="SupportsRawMouseMotion"/> is <see langword = "true"/> before using this.
        /// </summary>
        /// <param name="window">The window to enable or disable raw mouse motion for.</param>
        /// <param name="enable">Whether to enable or disable raw mouse motion.</param>
        /// <seealso cref="SupportsRawMouseMotion"/>
        /// <see cref="IsRawMouseMotionEnabled(WindowHandle)"/>
        void EnableRawMouseMotion(WindowHandle window, bool enable);
    }
}
