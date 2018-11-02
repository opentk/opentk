using System;
using System.Reflection;
using AdvancedDLSupport;
using OpenToolkit.Core.Exceptions;
using OpenToolkit.Core.Loader;
using OpenToolkit.OpenAL.Interfaces;

namespace OpenToolkit.OpenAL.Extensions
{
    /// <summary>
    /// Loader class for API extensions.
    /// </summary>
    internal static class ExtensionLoader
    {
        /// <summary>
        /// Loads the API for the given extension, using the base API.
        /// </summary>
        /// <param name="baseAPI">The base API instance.</param>
        /// <typeparam name="TExtension">The extension type.</typeparam>
        /// <returns>The extension.</returns>
        /// <exception cref="ExtensionNotSupportedException">Thrown if the API doesn't support the extension.</exception>
        public static TExtension LoadExtension<TExtension>(IAPIExtension baseAPI)
            where TExtension : ExtensionBase
        {
            var extensionMetadata = GetAPIExtensionMetadata<TExtension>();

            if (!baseAPI.IsExtensionPresent(extensionMetadata.ExtensionName))
            {
                throw new ExtensionNotSupportedException(extensionMetadata.ExtensionName);
            }

            return APILoader.Load<TExtension, OpenALLibraryNameContainer>();
        }

        /// <summary>
        /// Loads the API for the given extension, using the base API.
        /// </summary>
        /// <param name="device">The device of the context.</param>
        /// <param name="baseAPI">The base API instance.</param>
        /// <typeparam name="TContextExtension">The extension type.</typeparam>
        /// <returns>The extension.</returns>
        /// <exception cref="ExtensionNotSupportedException">Thrown if the API doesn't support the extension.</exception>
        internal static unsafe TContextExtension LoadContextExtension<TContextExtension>(Device* device, IContextExtensions baseAPI)
            where TContextExtension : ContextExtensionBase
        {
            var extensionMetadata = GetAPIExtensionMetadata<TContextExtension>();

            if (!baseAPI.IsExtensionPresent(device, extensionMetadata.ExtensionName))
            {
                throw new ExtensionNotSupportedException(extensionMetadata.ExtensionName);
            }

            return APILoader.Load<TContextExtension, OpenALLibraryNameContainer>();
        }

        /// <summary>
        /// Gets some required metadata about an API extension type.
        /// </summary>
        /// <typeparam name="TAPIExtension">The API extension type.</typeparam>
        /// <returns>The metadata.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the API type doesn't have a metadata attribute.
        /// </exception>
        private static ExtensionAttribute GetAPIExtensionMetadata<TAPIExtension>() where TAPIExtension : NativeLibraryBase
        {
            var apiType = typeof(TAPIExtension);

            if (!(apiType.GetCustomAttribute(typeof(ExtensionAttribute)) is ExtensionAttribute attribute))
            {
                throw new InvalidOperationException("The API class didn't have an API class attribute applied to it.");
            }

            return attribute;
        }
    }
}
