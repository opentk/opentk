using System.Xml.Linq;

namespace OpenTK.Convert
{
    /// <summary>
    /// Extension class for XAttribute.
    /// </summary>
    internal static class XAttributeExtension
    {
        /// <summary>
        /// Returns the value of a <seealso cref="XAttribute"/> object, or <see cref="string.Empty" /> if the given <seealso cref="XAttribute"/> object is null.
        /// </summary>
        /// <param name="a">The <seealso cref="XAttribute"/> object from the value is to be extracted.</param>
        /// <returns>The value of the given <seealso cref="XAttribute"/>, or <see cref="string.Empty" /> if the given <seealso cref="XAttribute"/> object is null.</returns>
        public static string ValueOrDefault(this XAttribute a)
        {
            return a != null ? a.Value : string.Empty;
        }
    }
}
