namespace OpenToolkit.Core.Loader
{
    /// <summary>
    /// Defines a class that holds library names used on various platforms.
    /// </summary>
    public interface IPlatformLibraryNameContainer
    {
        /// <summary>
        /// Gets the library name to use on Windows.
        /// </summary>
        string Windows { get; }

        /// <summary>
        /// Gets the library name to use on Linux.
        /// </summary>
        string Linux { get; }

        /// <summary>
        /// Gets the library name to use on MacOS.
        /// </summary>
        string MacOS { get; }

        /// <summary>
        /// Gets the library name to use on Android.
        /// </summary>
        string Android { get; }

        /// <summary>
        /// Gets the library name to use on iOS.
        /// </summary>
        string IOS { get; }

        /// <summary>
        /// Gets the library name to use on the current platform.
        /// </summary>
        /// <returns>The library name.</returns>
        string GetLibraryName();
    }
}
