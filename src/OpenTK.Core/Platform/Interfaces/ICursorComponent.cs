using System;
using System.IO;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Interface for drivers which provide the cursor component of the platform abstraction layer.
    /// </summary>
    public interface ICursorComponent : IPalComponent
    {
        /// <summary>
        /// True if the driver can load from a file.
        /// </summary>
        bool CanLoadFromFile { get; }

        /// <summary>
        /// True if the driver can load system cursors.
        /// </summary>
        bool CanLoadSystemCursor { get; }

        /// <summary>
        /// Create a cursor object.
        /// </summary>
        /// <returns>A cursor object.</returns>
        CursorHandle Create();

        /// <summary>
        /// Destroy a cursor object.
        /// </summary>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void Destroy(CursorHandle handle);

        /// <summary>
        /// Get the size of the cursor image.
        /// </summary>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="width">Width of the cursor.</param>
        /// <param name="height">Height of the cursor.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetSize(CursorHandle handle, out int width, out int height);

        /// <summary>
        /// Get the hotspot location of the mouse cursor.
        /// </summary>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="x">X coordinate of the hotspot.</param>
        /// <param name="y">Y coordinate of the hotspot.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetHotspot(CursorHandle handle, out int x, out int y);

        /// <summary>
        /// Get the mouse cursor image.
        /// </summary>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="image">Buffer to copy cursor image into.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetImage(CursorHandle handle, Span<byte> image);

        /// <summary>
        /// Load a standard system cursor.
        /// </summary>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="systemCursor">Name of the standard cursor to load.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">Driver does not implement this function. See <see cref="CanLoadSystemCursor"/>.</exception>
        /// <exception cref="PlatformException">System does not provide cursor type selected by <paramref name="systemCursor"/>.</exception>
        void Load(CursorHandle handle, SystemCursorType systemCursor);

        /// <summary>
        /// Load a cursor image from memory.
        /// </summary>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="width">Width of the cursor image.</param>
        /// <param name="height">Height of the cursor image.</param>
        /// <param name="image">Buffer containing image data.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="width"/> or <paramref name="height"/> is negative.</exception>
        /// <exception cref="ArgumentException"><paramref name="image"/> is smaller than specified dimensions.</exception>
        void Load(CursorHandle handle, int width, int height, ReadOnlySpan<byte> image);

        /// <summary>
        /// Load a cursor from a file.
        /// </summary>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="file">Path to cursor file.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">Driver does not provide this function. See <see cref="CanLoadFromFile"/>.</exception>
        /// <exception cref="FileNotFoundException">File at path <paramref name="file"/> not found.</exception>
        /// <exception cref="IOException">Input output error.</exception>
        /// <exception cref="NotSupportedException">File format not supported or recognized.</exception>
        void Load(CursorHandle handle, string file);

        /// <summary>
        /// Load a cursor from a stream.
        /// </summary>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="stream">Stream containing mouse cursor.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">Driver does not provide this function. See <see cref="CanLoadFromFile"/>.</exception>
        /// <exception cref="IOException">Input Output Error.</exception>
        /// <exception cref="NotSupportedException">File format not supported or recognized.</exception>
        /// <remarks>This function should be implemented using a temporary file if the system does not support reading from a stream.</remarks>
        void Load(CursorHandle handle, Stream stream);

        /// <summary>
        /// Set the cursor hot spot.
        /// </summary>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="x">X coordinate of the hotspot.</param>
        /// <param name="y">Y coordinate of the hotspot.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="x"/> or <paramref name="y"/> is outside of the cursor image.</exception>
        void SetHotspot(CursorHandle handle, int x, int y);
    }
}
