using System;
using System.IO;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Interface for PAL drivers which provide the icon component.
    /// </summary>
    public interface IIconComponent : IPalComponent
    {
        /// <summary>
        /// True if icon objects can be loaded from files.
        /// </summary>
        bool CanLoadFile { get; }

        /// <summary>
        /// True if icon objects can be populated from common system icons.
        /// </summary>
        bool CanLoadSystemIcon { get; }

        /// <summary>
        /// True if icon objects can have mip maps.
        /// </summary>
        bool HasMipmaps { get; }

        /// <summary>
        /// Create an icon object.
        /// </summary>
        /// <returns>Handle to an icon object.</returns>
        IconHandle Create();

        /// <summary>
        /// Destroy an icon object.
        /// </summary>
        /// <param name="handle">Handle to the icon object to destroy.</param>
        /// <exception cref="ArgumentException"><paramref name="handle"/> is null.</exception>
        void Destroy(IconHandle handle);

        /// <summary>
        /// Create the mipmap levels of an icon object if not already done.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <exception cref="ArgumentException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">Driver does not provide mipmaps. See <see cref="HasMipmaps"/>.</exception>
        void GenerateMipmaps(IconHandle handle);

        /// <summary>
        /// Get the dimensions of a icon object.
        /// </summary>
        /// <param name="handle">Handle to icon object.</param>
        /// <param name="width">Width of the icon.</param>
        /// <param name="height">Height of icon.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetDimensions(IconHandle handle, out int width, out int height);

        /// <summary>
        /// Get the dimensions of an icon object.
        /// </summary>
        /// <param name="handle">Handle to icon object.</param>
        /// <param name="level">Mipmap level of the object.</param>
        /// <param name="width">Width of the icon.</param>
        /// <param name="height">Height of icon.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">Driver does not provide mipmaps. See <see cref="HasMipmaps"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Icon does not have mipmap level specified by <paramref name="level"/>.</exception>
        void GetDimensions(IconHandle handle, int level, out int width, out int height);

        /// <summary>
        /// Get the bitmap visual of an icon object.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <param name="data">A buffer to copy bitmap data into.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetBitmap(IconHandle handle, Span<byte> data);

        /// <summary>
        /// Get the bitmap visual of an icon object.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <param name="level">Mipmap level of the visual to copy.</param>
        /// <param name="data">A buffer to copy bitmap data into.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">Driver does not implement mipmap functionality.</exception>
        void GetBitmap(IconHandle handle, int level, Span<byte> data);

        /// <summary>
        /// Get the size of the bitmap visual in bytes.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <returns>The size of the bitmap visual in bytes.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        int GetBitmapSize(IconHandle handle);

        /// <summary>
        /// Get the size of the bitmap visual in bytes.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <param name="level">Mipmap level of the visual to get the size of.</param>
        /// <returns>The size of the bitmap visual in bytes.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">Driver does not implement mipmap functionality.</exception>
        int GetBitmapSize(IconHandle handle, int level);

        /// <summary>
        /// Load an icon object with image data.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <param name="data">Image data to load into icon.</param>
        /// <exception cref="ArgumentException"><paramref name="handle"/> is null.</exception>
        void Load(IconHandle handle, ReadOnlySpan<byte> data);

        /// <summary>
        /// Load an icon object with image data.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <param name="data">Image data to load into icon.</param>
        /// <param name="level">Mip level to load data onto.</param>
        /// <exception cref="ArgumentException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PalNotImplementedException">Driver does not provide mipmaps. See <see cref="HasMipmaps"/>.</exception>
        void Load(IconHandle handle, ReadOnlySpan<byte> data, int level);

        /// <summary>
        /// Load an icon object from a file.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <param name="file">Path to the icon file.</param>
        /// <exception cref="ArgumentException"><paramref name="handle"/> or <paramref name="file"/> is null.</exception>
        /// <exception cref="FileNotFoundException">Icon file not found.</exception>
        /// <exception cref="IOException">Generic IO error.</exception>
        /// <exception cref="PalNotImplementedException">Driver does not implement loading from files. See <see cref="CanLoadFile"/>.</exception>
        void Load(IconHandle handle, string file);

        /// <summary>
        /// Load an icon object from a stream.
        /// </summary>
        /// <param name="handle">Handle to icon object.</param>
        /// <param name="stream">Stream containing icon file.</param>
        /// <exception cref="ArgumentException"><paramref name="handle"/> or <paramref name="stream"/> is null.</exception>
        /// <exception cref="FileNotFoundException">Icon file not found.</exception>
        /// <exception cref="IOException">Generic IO error.</exception>
        /// <exception cref="PalNotImplementedException">Driver does not implement loading from files. See <see cref="CanLoadFile"/>.</exception>
        /// <remarks>If the icon cannot be loaded from an open file or stream handle, the driver should implement this function through a temporary file.</remarks>
        void Load(IconHandle handle, Stream stream);

        /// <summary>
        /// Load a common system icon.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <param name="name">To be replaced by an enumeration.</param>
        /// <exception cref="ArgumentException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="Exception">System does not provide an icon for the given value of <paramref name="name"/>.</exception>
        /// <exception cref="PalNotImplementedException">Driver does not implement loading system icons. See <see cref="CanLoadSystemIcon"/>.</exception>
        void Load(IconHandle handle, SystemIconType name);
    }
}
