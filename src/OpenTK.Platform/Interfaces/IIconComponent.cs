using System;
using System.IO;

namespace OpenTK.Platform
{
    /// <summary>
    /// Interface for PAL drivers which provide the icon component.
    /// </summary>
    public interface IIconComponent : IPalComponent
    {
        /// <summary>
        /// True if icon objects can be populated from common system icons.
        /// If this is true, then <see cref="Create(SystemIconType)"/> will work, otherwise an exception will be thrown.
        /// </summary>
        /// <seealso cref="Create(SystemIconType)"/>
        bool CanLoadSystemIcons { get; }

        /// <summary>
        /// Load a system icon.
        /// Only works if <see cref="CanLoadSystemIcons"/> is true.
        /// </summary>
        /// <param name="systemIcon">The system icon to create.</param>
        /// <returns>A handle to the created system icon.</returns>
        /// <seealso cref="CanLoadSystemIcons"/>
        IconHandle Create(SystemIconType systemIcon);

        /// <summary>
        /// Load an icon object with image data.
        /// </summary>
        /// <param name="width">Width of the bitmap.</param>
        /// <param name="height">Height of the bitmap.</param>
        /// <param name="data">Image data to load into icon.</param>
        /// <returns>A handle to the created icon.</returns>
        // FIXME: Define the pixel format of the Span<byte>!
        IconHandle Create(int width, int height, ReadOnlySpan<byte> data);

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
        void GetSize(IconHandle handle, out int width, out int height);
    }
}
