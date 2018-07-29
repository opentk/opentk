using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Bind.Extensions
{
    /// <summary>
    /// Extension methods for the <see cref="XContainer"/> class.
    /// </summary>
    public static class XContainerExtensions
    {
        /// <summary>
        /// Gets a required element from a container.
        /// </summary>
        /// <param name="container">The container to get the element from.</param>
        /// <param name="elementName">The name of the element.</param>
        /// <param name="ignoreNamespace">Whether or not the namespace should be ignored.</param>
        /// <exception cref="InvalidDataException">Thrown if the element is not present.</exception>
        /// <returns>The element.</returns>
        [NotNull]
        public static XElement GetRequiredElement
        (
            [NotNull] this XContainer container,
            [NotNull] string elementName,
            bool ignoreNamespace = true
        )
        {
            var element = ignoreNamespace
                ? container.Elements().FirstOrDefault(a => a.Name.LocalName == elementName)
                : container.Element(elementName);

            if (element is null)
            {
                throw new InvalidDataException($"Required element \"{elementName}\" not found.");
            }

            return element;
        }

        /// <summary>
        /// Gets a set of required elements from a container.
        /// </summary>
        /// <param name="container">The container to get the elements from.</param>
        /// <param name="elementName">The name of the element.</param>
        /// <param name="ignoreNamespace">Whether or not the namespace should be ignored.</param>
        /// <returns>The elements.</returns>
        [NotNull, ItemNotNull]
        public static IEnumerable<XElement> GetRequiredElements
        (
            [NotNull] this XContainer container,
            [NotNull] string elementName,
            bool ignoreNamespace = true
        )
        {
            var elements = ignoreNamespace
                ? container.Elements().Where(a => a.Name.LocalName == elementName)
                : container.Elements(elementName);

            var requiredElements = elements.ToList();
            if (!requiredElements.Any())
            {
                throw new InvalidDataException($"Required element \"{elements}\" not found.");
            }

            return requiredElements;
        }
    }
}
