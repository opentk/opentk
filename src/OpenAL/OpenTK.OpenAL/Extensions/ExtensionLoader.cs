using System;
using System.Reflection;
using AdvancedDLSupport;
using OpenTK.Core.Exceptions;
using OpenTK.Core.Loader;

namespace OpenTK.OpenAL.Extensions
{
    public class ExtensionLoader
    {
        public static TExtension LoadExtension<TExtension>(IAPIExtension baseAPI)
            where TExtension : NativeLibraryBase
        {
            var extensionMetadata = GetAPIExtensionMetadata<TExtension>();

            if (!baseAPI.IsExtensionPresent(extensionMetadata.ExtensionName))
            {
                throw new ExtensionNotFoundException(extensionMetadata.ExtensionName);
            }

            return APILoader.Load<TExtension>();
        }

        /// <summary>
        /// Gets some required metadata about an API type.
        /// </summary>
        /// <typeparam name="TAPI">The API type.</typeparam>
        /// <returns>The metadata.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the API type doesn't have a metadata attribute.
        /// </exception>
        private static APIClassAttribute GetAPIMetadata<TAPI>() where TAPI : NativeLibraryBase
        {
            var apiType = typeof(TAPI);

            if (!(apiType.GetCustomAttribute(typeof(APIClassAttribute)) is APIClassAttribute attribute))
            {
                throw new InvalidOperationException("The API class didn't have an API class attribute applied to it.");
            }

            return attribute;
        }

        /// <summary>
        /// Gets some required metadata about an API extension type.
        /// </summary>
        /// <typeparam name="TAPIExtension">The API extension type.</typeparam>
        /// <returns>The metadata.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the API type doesn't have a metadata attribute.
        /// </exception>
        private static APIExtensionAttribute GetAPIExtensionMetadata<TAPIExtension>() where TAPIExtension : NativeLibraryBase
        {
            var apiType = typeof(TAPIExtension);

            if (!(apiType.GetCustomAttribute(typeof(APIExtensionAttribute)) is APIExtensionAttribute attribute))
            {
                throw new InvalidOperationException("The API class didn't have an API class attribute applied to it.");
            }

            return attribute;
        }
    }
}
