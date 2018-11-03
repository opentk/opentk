using System;
using System.Linq;
using Mono.Cecil;

namespace OpenToolkit.Rewrite.Extensions
{
    /// <summary>
    /// Provides convenience extension methods for <see cref="ICustomAttributeProvider"/>
    /// instances that are used in the OpenToolkit.Rewrite namespace.
    /// </summary>
    public static class ICustomAttributeProviderExtensions
    {
        /// <summary>
        /// Gets a <see cref="CustomAttribute"/> by name and throws
        /// an <see cref="InvalidOperationException"/> if no attribute with the specified name is found.
        /// </summary>
        /// <param name="provider">The <see cref="ICustomAttributeProvider"/> to get the attribute from.</param>
        /// <param name="name">
        /// The name of the attribute. This is case-sensitive, and "Attribute" must be included in the name.
        /// </param>
        /// <returns>The first attribute with the provided name.</returns>
        public static CustomAttribute GetCustomAttribute(this ICustomAttributeProvider provider, string name)
        {
            return provider.GetCustomAttribute(name, true);
        }

        /// <summary>
        /// Gets a <see cref="CustomAttribute"/> by name, and optionally either returns null or
        /// throws an <see cref="InvalidOperationException"/> if no attribute with the specified name is found.
        /// </summary>
        /// <param name="provider">The <see cref="ICustomAttributeProvider"/> to get the attribute from.</param>
        /// <param name="name">
        /// The name of the attribute. This is case-sensitive, and "Attribute" must be included in the name.
        /// </param>
        /// <param name="throwIfNoneFound">
        /// Whether to throw an <see cref="InvalidOperationException"/>
        /// if no attribute with the specified name is found.
        /// </param>
        /// <returns>
        /// If <paramref name="throwIfNoneFound"/> is true: The first attribute with the provided name.<para/>
        /// Otherwise: Either the first attribute with the given name, or null if none is found.
        /// </returns>
        public static CustomAttribute GetCustomAttribute
        (
            this ICustomAttributeProvider provider,
            string name,
            bool throwIfNoneFound
        )
        {
            if (throwIfNoneFound)
            {
                return provider.CustomAttributes.First(a => a.AttributeType.Name == name);
            }

            return provider.CustomAttributes.FirstOrDefault(a => a.AttributeType.Name == name);
        }
    }
}
