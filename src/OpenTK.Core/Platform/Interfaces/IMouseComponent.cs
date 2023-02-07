namespace OpenTK.Core.Platform
{
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
        /// <param name="handle">Handle to a mouse or null for default.</param>
        /// <param name="x">X coordinate of the mouse in desktop space.</param>
        /// <param name="y">Y coordinate of the mouse in desktop space.</param>
        void GetPosition(MouseHandle handle, out int x, out int y);

        /// <summary>
        /// Set the mouse cursor position.
        /// </summary>
        /// <param name="handle">Handle to a mouse or null for default.</param>
        /// <param name="x">X coordinate of the mouse in desktop space.</param>
        /// <param name="y">Y coordinate of the mouse in desktop space.</param>
        void SetPosition(MouseHandle handle, int x, int y);
    }
}
