using System;
using System.IO;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Interface for PAL drivers which provide the icon component.
    /// </summary>
    public interface IIconComponent : IPalComponent
    {
        // FIXME: Define the pixel format of the Span<byte> icons!

        /// <summary>
        /// True if icon objects can be populated from common system icons.
        /// </summary>
        bool CanLoadSystemIcon { get; }

        /// <summary>
        /// Create an icon object.
        /// </summary>
        /// <returns>Handle to an icon object.</returns>
        IconHandle Create();

        /// <summary>
        /// Destroy an icon object.
        /// </summary>
        /// <param name="handle">Handle to the icon object to destroy.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void Destroy(IconHandle handle);

        /// <summary>
        /// Get the dimensions of a icon object.
        /// </summary>
        /// <param name="handle">Handle to icon object.</param>
        /// <param name="width">Width of the icon.</param>
        /// <param name="height">Height of icon.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetDimensions(IconHandle handle, out int width, out int height);

        /// <summary>
        /// Get the bitmap visual of an icon object.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <param name="data">A buffer to copy bitmap data into.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void GetBitmapData(IconHandle handle, Span<byte> data);

        /// <summary>
        /// Get the size of the bitmap visual in bytes.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <returns>The size of the bitmap visual in bytes.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        int GetBitmapByteSize(IconHandle handle);

        /// <summary>
        /// Load an icon object with image data.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <param name="width">Width of the bitmap.</param>
        /// <param name="height">Height of the bitmap.</param>
        /// <param name="data">Image data to load into icon.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        void Load(IconHandle handle, int width, int height, ReadOnlySpan<byte> data);

        /// <summary>
        /// Load a common system icon.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <param name="name">To be replaced by an enumeration.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        /// <exception cref="PlatformException">System does not provide an icon for the given value of <paramref name="name"/>.</exception>
        /// <exception cref="PalNotImplementedException">Driver does not implement loading system icons. See <see cref="CanLoadSystemIcon"/>.</exception>
        void Load(IconHandle handle, SystemIconType name);
    }
}
