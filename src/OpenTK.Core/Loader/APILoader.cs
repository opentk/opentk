using System;
using System.Reflection;
using AdvancedDLSupport;

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

        /// <summary>
        /// Loads the given API type into an active instance.
        /// </summary>
        /// <typeparam name="TAPI">The API type.</typeparam>
        /// <typeparam name="TNameContainer">The type that provides the name of the native library.</typeparam>
        /// <returns>The API instance.</returns>
        public static TAPI Load<TAPI, TNameContainer>()
            where TAPI : NativeLibraryBase
            where TNameContainer : PlatformLibraryNameContainerBase, new()
        {
            var nameLoader = new TNameContainer();

            return _builder.ActivateClass<TAPI>(nameLoader.GetLibraryName());
        }
    }
}
