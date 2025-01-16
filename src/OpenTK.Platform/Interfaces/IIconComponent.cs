using System;

namespace OpenTK.Platform
{
    /// <summary>
    /// Interface creatiing and interacting with window icon images.
    /// </summary>
    /// <seealso cref="Toolkit.Icon"/>
    public interface IIconComponent : IPalComponent
    {
        /// <summary>
        /// If common system icons can be created.
        /// If this is <see langword="true"/> then <see cref="Create(SystemIconType)"/> will work, otherwise an exception will be thrown.
        /// </summary>
        /// <seealso cref="Create(SystemIconType)"/>
        bool CanLoadSystemIcons { get; }

        /// <summary>
        /// Load a system icon.
        /// Only works if <see cref="CanLoadSystemIcons"/> is <see langword="true"/>.
        /// </summary>
        /// <param name="systemIcon">The system icon to create.</param>
        /// <returns>A handle to the created system icon.</returns>
        /// <exception cref="PlatformNotSupportedException">Platform does not implement this function. See <see cref="CanLoadSystemIcons"/>.</exception>
        /// <seealso cref="CanLoadSystemIcons"/>
        IconHandle Create(SystemIconType systemIcon);

        /// <summary>
        /// Load an icon object with image data.
        /// </summary>
        /// <param name="width">Width of the bitmap.</param>
        /// <param name="height">Height of the bitmap.</param>
        /// <param name="data">Image data to load into icon in RGBA format.</param>
        /// <returns>A handle to the created icon.</returns>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="width"/>, or <paramref name="height"/> are negative.</exception>
        /// <exception cref="ArgumentException"><paramref name="data"/> is smaller than specified dimensions.</exception>
        // FIXME: Top to bottom or bottom to top?
        IconHandle Create(int width, int height, ReadOnlySpan<byte> data);

        /// <summary>
        /// Destroy an icon object.
        /// </summary>
        /// <param name="handle">Handle to the icon object to destroy.</param>
        /// <seealso cref="Create(SystemIconType)"/>
        /// <seealso cref="Create(int, int, ReadOnlySpan{byte})"/>
        void Destroy(IconHandle handle);

        /// <summary>
        /// Get the dimensions of a icon object.
        /// </summary>
        /// <param name="handle">Handle to icon object.</param>
        /// <param name="width">Width of the icon.</param>
        /// <param name="height">Height of icon.</param>
        void GetSize(IconHandle handle, out int width, out int height);
    }
}
