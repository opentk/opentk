using System.Linq;
using AdvancedDLSupport;
using OpenToolkit.Core.API;

namespace OpenToolkit.Core.Loader
{
    /// <summary>
    /// Handles loading API class types into usable instances.
    /// </summary>
    public static class APILoader
    {
        private static readonly ImplementationOptions _options;
        private static readonly NativeLibraryBuilder _builder;

        static APILoader()
        {
            _options = ImplementationOptions.EnableOptimizations |
                       ImplementationOptions.SuppressSecurity |
                       ImplementationOptions.GenerateDisposalChecks |
                       ImplementationOptions.EnableDllMapSupport;

            _builder = new NativeLibraryBuilder(_options);
        }

        private static IPlatformLibraryNameContainer GetDefaultLibraryNameContainer<TAPI>()
        {
            var attributes = typeof(TAPI).GetCustomAttributes(typeof(DefaultPlatformLibraryAttribute), true)
                .OfType<DefaultPlatformLibraryAttribute>().ToArray();
            if (attributes.Length > 1)
            {
                throw new APILoadingException($"Only one {nameof(DefaultPlatformLibraryAttribute)} allowed: {typeof(TAPI).Name}");
            }

            return attributes.FirstOrDefault()?.PlatformLibraryNameContainer;
        }

        /// <summary>
        /// Loads the given API type into an active instance.
        /// </summary>
        /// <typeparam name="TAPI">The API type.</typeparam>
        /// <param name="nameLoader">The type that provides the name of the native library.</param>
        /// <returns>The API instance.</returns>
        public static TAPI Load<TAPI>(IPlatformLibraryNameContainer nameLoader = null)
            where TAPI : class, IAPI
        {
            nameLoader = nameLoader ?? GetDefaultLibraryNameContainer<TAPI>();
            if (nameLoader == null)
            {
                throw new APILoadingException($"{nameof(nameLoader)} argument null and no default platform library could be found.");
            }

            var type = typeof(TAPI);

            if (typeof(APIBase).IsAssignableFrom(type))
            {
                return (TAPI)_builder.ActivateClass(nameLoader.GetLibraryName(), type, type.GetInterfaces());
            }

            return _builder.ActivateInterface<TAPI>(nameLoader.GetLibraryName());
        }
    }
}
