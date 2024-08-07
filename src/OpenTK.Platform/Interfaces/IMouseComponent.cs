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
        /// The mouse position in desktop coordinates.
        /// </summary>
        public Vector2i Position;

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

        // FIXME: When using CaptureMode.Locked should these return the virtual position?
        // If not, we need to have a clear distinction between which coordinates get
        // virtualized and which ones do not.

        /// <summary>
        /// Get the mouse cursor position.
        /// </summary>
        /// <param name="x">X coordinate of the mouse in desktop space.</param>
        /// <param name="y">Y coordinate of the mouse in desktop space.</param>
        void GetPosition(out int x, out int y);

        /// <summary>
        /// Set the mouse cursor position.
        /// Check that <see cref="CanSetMousePosition"/> is <see langword="true"/> before using this.
        /// </summary>
        /// <param name="x">X coordinate of the mouse in desktop space.</param>
        /// <param name="y">Y coordinate of the mouse in desktop space.</param>
        /// <seealso cref="CanSetMousePosition"/>
        void SetPosition(int x, int y);

        /// <summary>
        /// Fills the <paramref name="state"/> struct with the current mouse state.
        /// </summary>
        /// <param name="state">The current mouse state.</param>
        void GetMouseState(out MouseState state);

        /// <summary>
        /// Returns whether raw mouse motion is enabled for the given window or not.
        /// Check that <see cref="SupportsRawMouseMotion"/> is <see langword="true"/> before using this.
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <returns>If raw mouse motion is enabled.</returns>
        /// <seealso cref="SupportsRawMouseMotion"/>
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
        void EnableRawMouseMotion(WindowHandle window, bool enable);
    }
}
