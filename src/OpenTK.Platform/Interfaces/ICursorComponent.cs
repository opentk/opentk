using System;
using System.IO;

namespace OpenTK.Platform
{
    /// <summary>
    /// Interface for creating and interacting with cursor images.
    /// </summary>
    /// <seealso cref="Toolkit.Cursor"/>
    public interface ICursorComponent : IPalComponent
    {
        // FIXME: Currently all our platforms can load system cursors so we could probably remove this property...
        // - Noggin_bops 2024-11-09
        /// <summary>
        /// True if the driver can load system cursors.
        /// </summary>
        /// <seealso cref="Create(SystemCursorType)"/>
        bool CanLoadSystemCursors { get; }

        /// <summary>
        /// True if the backend supports inspecting system cursor handles.
        /// If <see langword="true"/>, functions like <see cref="GetSize(CursorHandle, out int, out int)"/> and <see cref="GetHotspot(CursorHandle, out int, out int)"/> works on system cursors.
        /// If <see langword="fals"/>, these functions will fail.
        /// </summary>
        /// <seealso cref="GetSize(CursorHandle, out int, out int)"/>
        /// <seealso cref="GetHotspot(CursorHandle, out int, out int)"/>
        /// <seealso cref="CanLoadSystemCursors"/>
        /// <seealso cref="Create(SystemCursorType)"/>
        bool CanInspectSystemCursors { get; }

        // FIXME: Do we need to destroy system cursors?
        // FIXME: Do two system cursors have reference equality?

        /// <summary>
        /// Create a standard system cursor.
        /// </summary>
        /// <remarks>
        /// This function is only supported if <see cref="CanLoadSystemCursors"/> is <see langword="true"/>.
        /// </remarks>
        /// <param name="systemCursor">Type of the standard cursor to load.</param>
        /// <returns>A handle to the created cursor.</returns>
        /// <exception cref="PlatformNotSupportedException">Driver does not implement this function. See <see cref="CanLoadSystemCursors"/>.</exception>
        /// <seealso cref="CanLoadSystemCursors"/>
        /// <seealso cref="SystemCursorType"/>
        /// <seealso cref="Destroy(CursorHandle)"/>
        CursorHandle Create(SystemCursorType systemCursor);

        /// <summary>
        /// Load a cursor image from memory.
        /// </summary>
        /// <param name="width">Width of the cursor image.</param>
        /// <param name="height">Height of the cursor image.</param>
        /// <param name="image">Buffer containing image data in RGBA order.</param>
        /// <param name="hotspotX">The x coordinate of the cursor hotspot.</param>
        /// <param name="hotspotY">The y coordinate of the cursor hotspot.</param>
        /// <returns>A handle to the created cursor.</returns>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="width"/>, <paramref name="height"/>, <paramref name="hotspotX"/>, or <paramref name="hotspotY"/> are negative.</exception>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="hotspotX"/> or <paramref name="hotspotY"/> are greater than <paramref name="width"/> or <paramref name="height"/> respectively.</exception>
        /// <exception cref="ArgumentException"><paramref name="image"/> is smaller than specified dimensions.</exception>
        /// <seealso cref="Destroy(CursorHandle)"/>
        // FIXME: Is pixel zero top left or bottom left?
        CursorHandle Create(int width, int height, ReadOnlySpan<byte> image, int hotspotX, int hotspotY);

        /// <summary>
        /// Load a cursor image from memory.
        /// </summary>
        /// <param name="width">Width of the cursor image.</param>
        /// <param name="height">Height of the cursor image.</param>
        /// <param name="colorData">Buffer containing RGB color data.</param>
        /// <param name="maskData">Buffer containing mask data. Pixels where the mask is 1 will be visible while mask value of 0 is transparent.</param>
        /// <param name="hotspotX">The x coordinate of the cursor hotspot.</param>
        /// <param name="hotspotY">The y coordinate of the cursor hotspot.</param>
        /// <returns>A handle to the created handle.</returns>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="width"/>, <paramref name="height"/>, <paramref name="hotspotX"/>, or <paramref name="hotspotY"/> are negative.</exception>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="hotspotX"/> or <paramref name="hotspotY"/> are greater than <paramref name="width"/> or <paramref name="height"/> respectively.</exception>
        /// <exception cref="ArgumentException"><paramref name="colorData"/> or <paramref name="maskData"/> is smaller than specified dimensions.</exception>
        /// <seealso cref="Destroy(CursorHandle)"/>
        // FIXME: Make colorData and maskData into a standardized format, and maybe put into a struct?
        CursorHandle Create(int width, int height, ReadOnlySpan<byte> colorData, ReadOnlySpan<byte> maskData, int hotspotX, int hotspotY);

        /// <summary>
        /// Destroy a cursor object.
        /// </summary>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <seealso cref="Create(SystemCursorType)"/>
        /// <seealso cref="Create(int, int, ReadOnlySpan{byte}, int, int)"/>
        /// <seealso cref="Create(int, int, ReadOnlySpan{byte}, ReadOnlySpan{byte}, int, int)"/>
        void Destroy(CursorHandle handle);

        /// <summary>
        /// Returns <see langword="true"/> if this cursor is a system cursor.
        /// </summary>
        /// <param name="handle">Handle to a cursor.</param>
        /// <returns>If the cursor is a system cursor or not.</returns>
        /// <seealso cref="Create(SystemCursorType)"/>.
        /// <seealso cref="CanLoadSystemCursors"/>
        bool IsSystemCursor(CursorHandle handle);

        /// <summary>
        /// Get the size of the cursor image.
        /// </summary>
        /// <remarks>
        /// If <paramref name="handle"/> is a system cursor and <see cref="CanInspectSystemCursors"/> is <see langword="false"/> this function will fail.
        /// </remarks>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="width">Width of the cursor.</param>
        /// <param name="height">Height of the cursor.</param>
        /// <seealso cref="IsSystemCursor(CursorHandle)"/>
        /// <seealso cref="CanInspectSystemCursors"/>
        void GetSize(CursorHandle handle, out int width, out int height);

        /// <summary>
        /// Get the hotspot location of the mouse cursor.
        /// </summary>
        /// <remarks>
        /// If <paramref name="handle"/> is a system cursor and <see cref="CanInspectSystemCursors"/> is false this function will fail.
        /// </remarks>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="x">X coordinate of the hotspot.</param>
        /// <param name="y">Y coordinate of the hotspot.</param>
        /// <seealso cref="IsSystemCursor(CursorHandle)"/>
        /// <seealso cref="CanInspectSystemCursors"/>
        void GetHotspot(CursorHandle handle, out int x, out int y);
    }
}
