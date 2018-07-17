using System.IO;
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
        /// <param name="attributeName">The name of the element.</param>
        /// <exception cref="InvalidDataException">Thrown if the element is not present.</exception>
        /// <returns>The element.</returns>
        [NotNull]
        public static XElement GetRequiredElement([NotNull] this XContainer container, string attributeName)
        {
            var attribute = container.Element(attributeName);
            if (attribute is null)
            {
                throw new InvalidDataException($"Required element \"{attributeName}\" not found.");
            }

            return attribute;
        }
    }
}
