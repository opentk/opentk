using System;

namespace OpenToolkit.Core.Loader
{
    /// <summary>
    /// Provides the default <see cref="IPlatformLibraryNameContainer"/> for APIs.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class DefaultPlatformLibraryAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultPlatformLibraryAttribute"/> class.
        /// </summary>
        /// <param name="platformLibraryNameContainerType">
        /// The default <see cref="IPlatformLibraryNameContainer"/> to associate with this class/interface.
        /// </param>
        public DefaultPlatformLibraryAttribute(Type platformLibraryNameContainerType)
        {
            if (!typeof(IPlatformLibraryNameContainer).IsAssignableFrom(platformLibraryNameContainerType))
            {
                throw new ArgumentException(nameof(platformLibraryNameContainerType));
            }

            PlatformLibraryNameContainer = (IPlatformLibraryNameContainer)Activator.CreateInstance(platformLibraryNameContainerType);
        }

        /// <summary>
        /// Gets the default <see cref="IPlatformLibraryNameContainer"/>.
        /// </summary>
        public IPlatformLibraryNameContainer PlatformLibraryNameContainer { get; }
    }
}
