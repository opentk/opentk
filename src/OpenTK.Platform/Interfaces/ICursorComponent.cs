using System;
using System.IO;

namespace OpenTK.Platform
{
    /// <summary>
    /// Interface for drivers which provide the cursor component of the platform abstraction layer.
    /// </summary>
    public interface ICursorComponent : IPalComponent
    {
        /// <summary>
        /// True if the driver can load system cursors.
        /// </summary>
        /// <seealso cref="Create(SystemCursorType)"/>
        bool CanLoadSystemCursors { get; }

        /// <summary>
        /// True if the backend supports inspecting system cursor handles.
        /// If true, functions like <see cref="GetSize(CursorHandle, out int, out int)"/> and <see cref="GetHotspot(CursorHandle, out int, out int)"/> works on system cursors.
        /// If false, these functions will fail.
        /// </summary>
        /// <seealso cref="GetSize(CursorHandle, out int, out int)"/>
        /// <seealso cref="GetHotspot(CursorHandle, out int, out int)"/>
        bool CanInspectSystemCursors { get; }

        // FIXME: Do we need to destroy system cursors?
        // FIXME: Do two system cursors have reference equality?

        /// <summary>
        /// Create a standard system cursor.
        /// </summary>
        /// <remarks>
        /// This function is only supported if <see cref="CanLoadSystemCursors"/> is true.
        /// </remarks>
        /// <param name="systemCursor">Type of the standard cursor to load.</param>
        /// <returns>A handle to the created cursor.</returns>
        /// <exception cref="PalNotImplementedException">Driver does not implement this function. See <see cref="CanLoadSystemCursors"/>.</exception>
        /// <exception cref="PlatformException">System does not provide cursor type selected by <paramref name="systemCursor"/>.</exception>
        CursorHandle Create(SystemCursorType systemCursor);

        /// <summary>
        /// Load a cursor image from memory.
        /// </summary>
        /// <param name="width">Width of the cursor image.</param>
        /// <param name="height">Height of the cursor image.</param>
        /// <param name="image">Buffer containing image data.</param>
        /// <param name="hotspotX">The x coordinate of the cursor hotspot.</param>
        /// <param name="hotspotY">The y coordinate of the cursor hotspot.</param>
        /// <returns>A handle to the created cursor.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="width"/> or <paramref name="height"/> is negative.</exception>
        /// <exception cref="ArgumentException"><paramref name="image"/> is smaller than specified dimensions.</exception>
        CursorHandle Create(int width, int height, ReadOnlySpan<byte> image, int hotspotX, int hotspotY);

        /// <summary>
        /// Load a cursor image from memory.
        /// </summary>
        /// <param name="width">Width of the cursor image.</param>
        /// <param name="height">Height of the cursor image.</param>
        /// <param name="colorData">Buffer containing color data.</param>
        /// <param name="maskData">Buffer containing mask data.</param>
        /// <param name="hotspotX">The x coordinate of the cursor hotspot.</param>
        /// <param name="hotspotY">The y coordinate of the cursor hotspot.</param>
        /// <returns>A handle to the created handle.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="width"/> or <paramref name="height"/> is negative.</exception>
        /// <exception cref="ArgumentException"><paramref name="colorData"/> or <paramref name="maskData"/> is smaller than specified dimensions.</exception>
        // FIXME: Define the data format for colorData and maskData. Is this a BW or color cursor??
        // FIXME: Make colorData and maskData into a standardized format, and maybe put into a struct?
        CursorHandle Create(int width, int height, ReadOnlySpan<byte> colorData, ReadOnlySpan<byte> maskData, int hotspotX, int hotspotY);

        /// <summary>
        /// Destroy a cursor object.
        /// </summary>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void Destroy(CursorHandle handle);

        /// <summary>
        /// Returns true if this cursor is a system cursor.
        /// </summary>
        /// <param name="handle">Handle to a cursor.</param>
        /// <returns>If the cursor is a system cursor or not.</returns>
        /// <seealso cref="Create(SystemCursorType)"/>.
        bool IsSystemCursor(CursorHandle handle);

        /// <summary>
        /// Get the size of the cursor image.
        /// </summary>
        /// <remarks>
        /// If <paramref name="handle"/> is a system cursor and <see cref="CanInspectSystemCursors"/> is false this function will fail.
        /// </remarks>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="width">Width of the cursor.</param>
        /// <param name="height">Height of the cursor.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <seealso cref="IsSystemCursor(CursorHandle)"/>
        /// <seealso cref="CanInspectSystemCursors"/>
        void GetSize(CursorHandle handle, out int width, out int height);

        /// <summary>
        /// Get the hotspot location of the mouse cursor.
        /// Getting the hotspot of a system cursor is not guaranteed to be possible, check <see cref="CanInspectSystemCursors"/> before trying.
        /// </summary>
        /// <remarks>
        /// If <paramref name="handle"/> is a system cursor and <see cref="CanInspectSystemCursors"/> is false this function will fail.
        /// </remarks>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="x">X coordinate of the hotspot.</param>
        /// <param name="y">Y coordinate of the hotspot.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <seealso cref="IsSystemCursor(CursorHandle)"/>
        /// <seealso cref="CanInspectSystemCursors"/>
        void GetHotspot(CursorHandle handle, out int x, out int y);
    }
}
