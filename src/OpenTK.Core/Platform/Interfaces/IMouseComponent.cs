using OpenTK.Mathematics;

namespace OpenTK.Core.Platform
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
        /// If it's possible to set the position of the mouse.
        /// </summary>
        bool CanSetMousePosition { get; }

        /// <summary>
        /// Get the mouse cursor position.
        /// </summary>
        /// <param name="x">X coordinate of the mouse in desktop space.</param>
        /// <param name="y">Y coordinate of the mouse in desktop space.</param>
        void GetPosition(out int x, out int y);

        /// <summary>
        /// Set the mouse cursor position.
        /// </summary>
        /// <param name="x">X coordinate of the mouse in desktop space.</param>
        /// <param name="y">Y coordinate of the mouse in desktop space.</param>
        void SetPosition(int x, int y);

        /// <summary>
        /// Fills the <paramref name="state"/> struct with the current mouse state.
        /// </summary>
        /// <param name="state">The current mouse state.</param>
        void GetMouseState(out MouseState state);
    }
}
