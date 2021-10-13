using System;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Interface for drivers which provide the display component.
    /// </summary>
    public interface IDisplayComponent : IPalComponent
    {
        /// <summary>
        /// True if the driver can set the video mode.
        /// </summary>
        bool CanSetVideoMode { get; }

        /// <summary>
        /// True if the driver can get the virtual position of the display.
        /// </summary>
        bool CanGetVirtualPosition { get; }

        /// <summary>
        /// True if the driver can get the physical size of the display.
        /// </summary>
        bool CanGetDisplaySize { get; }

        /// <summary>
        /// Get the number of available displays.
        /// </summary>
        /// <returns>Number of displays available.</returns>
        int GetDisplayCount();

        /// <summary>
        /// Create a display handle to the indexed display.
        /// </summary>
        /// <param name="index">The display index to create a display handle to.</param>
        /// <returns>Handle to the display.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="index"/> is out of range.</exception>
        DisplayHandle Create(int index);

        /// <summary>
        /// Create a display handle to the primary display.
        /// </summary>
        /// <returns>Handle to the primary display.</returns>
        DisplayHandle CreatePrimary();

        /// <summary>
        /// Destroy a display handle.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void Destroy(DisplayHandle handle);

        /// <summary>
        /// Get the friendly name of a display.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <returns>Display name.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        string GetName(DisplayHandle handle);

        /// <summary>
        /// Get the active video mode of a display.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <param name="mode">Active video mode of display.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetVideoMode(DisplayHandle handle, out VideoMode mode);

        /// <summary>
        /// Set the active video mode of a display.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <param name="mode">Target video mode.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="mode"/> is unsupported by display.</exception>
        /// <exception cref="PalNotImplementedException">The driver does not support this action. See <see cref="CanSetVideoMode"/>.</exception>
        void SetVideoMode(DisplayHandle handle, in VideoMode mode);

        /// <summary>
        /// Get the number of video modes the display supports.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <returns>Number of supported display modes.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        int GetSupportedVideoModeCount(DisplayHandle handle);

        /// <summary>
        /// Get all supported video modes.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <param name="modes">Span where supported display modes will be written to.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetSupportedVideoModes(DisplayHandle handle, Span<VideoMode> modes);

        /// <summary>
        /// Get the physical size of the display.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <param name="width">Width of the display in millimeters.</param>
        /// <param name="height">Height of the display in millimeters.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">Driver cannot get display physical size. See <see cref="CanGetDisplaySize"/>.</exception>
        void GetDisplaySize(DisplayHandle handle, out float width, out float height);

        /// <summary>
        /// Get the position of the display in the virtual desktop.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <param name="x">Virtual X coordinate of the display.</param>
        /// <param name="y">Virtual Y coordinate of the display.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">Driver cannot get display virtual position. See <see cref="CanGetVirtualPosition"/>.</exception>
        void GetVirtualPosition(DisplayHandle handle, out int x, out int y);
    }
}
