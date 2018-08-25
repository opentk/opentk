using System;
using System.Reflection;
using AdvancedDLSupport;

namespace OpenTK.Core.Loader
{
    /// <summary>
    /// Handles loading API class types into usable instances.
    /// </summary>
    public static class APILoader
    {
        private static readonly ImplementationOptions _options;
        private static readonly NativeLibraryBuilder _builder;

        private static readonly MethodInfo _genericActivatorMethod;

        static APILoader()
        {
            _options = ImplementationOptions.EnableOptimizations |
                       ImplementationOptions.SuppressSecurity |
                       ImplementationOptions.GenerateDisposalChecks |
                       ImplementationOptions.EnableDllMapSupport;

            _builder = new NativeLibraryBuilder(_options);

            // TODO: Add a method in ADL that takes type parameters instead of generic parameters.
            _genericActivatorMethod = typeof(NativeLibraryBuilder).GetMethod(nameof(NativeLibraryBuilder.ActivateClass));
        }

        /// <summary>
        /// Loads the given API type into an active instance.
        /// </summary>
        /// <typeparam name="TAPI">The API type.</typeparam>
        /// <returns>The API instance.</returns>
        public static TAPI Load<TAPI>() where TAPI : NativeLibraryBase
        {
            var metadata = GetAPIMetadata<TAPI>();
            var activatorMethod = _genericActivatorMethod.MakeGenericMethod(typeof(TAPI), metadata.InterfaceType);

            return (TAPI)activatorMethod.Invoke(_builder, new object[] { metadata.Library });
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
    }
}
