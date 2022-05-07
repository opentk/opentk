namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Base interface for drivers which implement the mouse component.
    /// </summary>
    public interface IMouseComponent : IPalComponent
    {
        /// <summary>
        /// True if multiple mouse are supported.
        /// </summary>
        bool IsMultiMouse { get; }

        /// <summary>
        /// Get mice count.
        /// </summary>
        /// <returns>The number of mice installed on the system.</returns>
        /// <exception cref="PalNotImplementedException">The abstraction layer driver does not provide multi-mice capabilities.</exception>
        int GetMouseCount();

        /// <summary>
        /// Create a handle to a mouse.
        /// </summary>
        /// <param name="index">Index of the mouse to create a handle to.</param>
        /// <returns>Handle to a mouse.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><paramref name="index"/> is larger than number of mice in system.</exception>
        /// <exception cref="PalNotImplementedException">The abstraction layer driver does not provide multi-mice capabilities.</exception>
        MouseHandle Create(int index);

        /// <summary>
        /// Destroy a mouse handle.
        /// </summary>
        /// <param name="handle">Handle to a mouse.</param>
        /// <exception cref="System.ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void Destroy(MouseHandle handle);

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
