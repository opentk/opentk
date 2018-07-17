using System.IO;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Bind.Extensions
{
    /// <summary>
    /// Extensions for the <see cref="XElement"/> class.
    /// </summary>
    public static class XElementExtensions
    {
        /// <summary>
        /// Gets a required attribute from an element.
        /// </summary>
        /// <param name="element">The element to get the attribute from.</param>
        /// <param name="attributeName">The name of the attribute.</param>
        /// <exception cref="InvalidDataException">Thrown if the attribute is not present.</exception>
        /// <returns>The attribute.</returns>
        [NotNull]
        public static XAttribute GetRequiredAttribute([NotNull] this XElement element, string attributeName)
        {
            var attribute = element.Attribute(attributeName);
            if (attribute is null)
            {
                throw new InvalidDataException($"Required attribute \"{attributeName}\" not found.");
            }

            return attribute;
        }
    }
}
