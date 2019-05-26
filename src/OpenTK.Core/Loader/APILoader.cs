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
        /// <param name="nameLoader">The type that provides the name of the native library.</param>
        /// <returns>The API instance.</returns>
        public static TAPI Load<TAPI>(IPlatformLibraryNameContainer nameLoader)
            where TAPI : NativeLibraryBase
        {
            return _builder.ActivateClass<TAPI>(nameLoader.GetLibraryName());
        }
    }
}
