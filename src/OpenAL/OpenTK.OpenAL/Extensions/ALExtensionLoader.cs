using OpenToolkit.Core.Exceptions;
using OpenToolkit.Core.Extensions;
using OpenToolkit.Core.Loader;
using OpenToolkit.OpenAL.Interfaces;

namespace OpenToolkit.OpenAL.Extensions
{
    /// <summary>
    /// A loader for OpenAL extensions.
    /// </summary>
    public static class ALExtensionLoader
    {
        /// <summary>
        /// Loads the API for the given extension, using the base API.
        /// </summary>
        /// <param name="device">The device of the context.</param>
        /// <param name="baseAPI">The base API instance.</param>
        /// <typeparam name="TContextExtension">The extension type.</typeparam>
        /// <returns>The extension.</returns>
        /// <exception cref="ExtensionNotSupportedException">Thrown if the API doesn't support the extension.</exception>
        internal static unsafe TContextExtension LoadContextExtension<TContextExtension>
            (Device* device, IContextExtensions baseAPI)
            where TContextExtension : ContextExtensionBase
        {
            var extensionMetadata = ExtensionLoader.GetAPIExtensionMetadata<TContextExtension>();

            if (!baseAPI.IsExtensionPresent(device, extensionMetadata.ExtensionName))
            {
                throw new ExtensionNotSupportedException(extensionMetadata.ExtensionName);
            }

            return APILoader.Load<TContextExtension>(new OpenALLibraryNameContainer());
        }
    }
}
