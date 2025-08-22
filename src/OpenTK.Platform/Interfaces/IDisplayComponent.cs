using System;
using OpenTK.Mathematics;
using OpenTK.Platform.Native.Windows;

namespace OpenTK.Platform
{
    /// <summary>
    /// Interface for drivers which provide the display component.
    /// </summary>
    /// <seealso cref="Toolkit.Display"/>
    public interface IDisplayComponent : IPalComponent
    {
        // FIXME: Add API for getting the display orientation!
        // FIXME: Add API for getting the color information of the display.
        // i.e. the RGB -> XYZ matrix
        // and potential gamma functions.
        // FIXME: Ability to query HDR support?

        /// <summary>
        /// True if the driver can get the virtual position of the display using <see cref="GetVirtualPosition(DisplayHandle, out int, out int)"/>.
        /// </summary>
        bool CanGetVirtualPosition { get; }

        /// <summary>
        /// Get the number of available displays.
        /// </summary>
        /// <returns>Number of displays available.</returns>
        int GetDisplayCount();

        // FIXME: Define the how the indices work?
        // Will we guarantee that index = 0 is the primary monitor?
        // Should we sort the displays in some order?
        // What happens when monitors are added and removed?

        /// <summary>
        /// Create a display handle to the indexed display.
        /// </summary>
        /// <param name="index">The display index to create a display handle to.</param>
        /// <returns>Handle to the display.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="index"/> is out of range.</exception>
        DisplayHandle Open(int index);

        /// <summary>
        /// Create a display handle to the primary display.
        /// </summary>
        /// <returns>Handle to the primary display.</returns>
        DisplayHandle OpenPrimary();

        /// <summary>
        /// Close a display handle.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void Close(DisplayHandle handle);

        /// <summary>
        /// Checks if a display is the primary display or not.
        /// </summary>
        /// <param name="handle">The display to check whether or not is the primary display.</param>
        /// <returns>If this display is the primary display.</returns>
        bool IsPrimary(DisplayHandle handle);

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
        /// Get all supported video modes for a specific display.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <returns>An array of all supported video modes.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        VideoMode[] GetSupportedVideoModes(DisplayHandle handle);

        /// <summary>
        /// Get the position of the display in the virtual desktop.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <param name="x">Virtual X coordinate of the display.</param>
        /// <param name="y">Virtual Y coordinate of the display.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">Driver cannot get display virtual position. See <see cref="CanGetVirtualPosition"/>.</exception>
        void GetVirtualPosition(DisplayHandle handle, out int x, out int y);

        /// <summary>
        /// Get the resolution of the specified display.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <param name="width">The horizontal resolution of the display.</param>
        /// <param name="height">The vertical resolution of the display.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetResolution(DisplayHandle handle, out int width, out int height);

        /// <summary>
        /// Get the work area of this display.
        /// The work area is the area of the display that is not covered by task bars or menu bars.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <param name="area">The work area of the display.</param>
        void GetWorkArea(DisplayHandle handle, out Box2i area);

        /// <summary>
        /// Get the refresh rate if the specified display.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <param name="refreshRate">The refresh rate of the display.</param>
        void GetRefreshRate(DisplayHandle handle, out float refreshRate);

        /// <summary>
        /// Get the scale of the display.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <param name="scaleX">The X-axis scale of the monitor.</param>
        /// <param name="scaleY">The Y-axis scale of the monitor.</param>
        void GetDisplayScale(DisplayHandle handle, out float scaleX, out float scaleY);

        // FIXME: Figure out the API for this...
        /// <summary>
        /// Gets the HDR info of the display, or if the display does not support HDR this function returns <see langword="false"/>.
        /// </summary>
        /// <param name="handle">Handle to a display.</param>
        /// <param name="hdrInfo">HDR info about this display if the display supports HDR.</param>
        /// <returns><see langword="true"/> if the display supports HDR, or <see langword="false"/> if the display does not support HDR.</returns>
        //bool GetHDRInfo(DisplayHandle handle, out HdrInfo hdrInfo);
    }
}
