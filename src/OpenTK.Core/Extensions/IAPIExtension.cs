using System;
using AdvancedDLSupport;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.Core.Extensions
{
    /// <summary>
    /// Defines the API surface of an API extension.
    /// </summary>
    public interface IAPIExtension
    {
        /// <summary>
        /// Gets the library name container for this extension.
        /// </summary>
        IPlatformLibraryNameContainer NameContainer { get; }

        /// <summary>
        /// Determines whether or not the named extension is available.
        /// </summary>
        /// <param name="name">The name of the extension.</param>
        /// <returns>true if the extension is available; otherwise, false.</returns>
        bool IsExtensionPresent([CallerFree] string name);
    }
}
