using System;
using System.Globalization;
using System.IO;
using System.Xml.Linq;
using Bind.Extensions;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.XML
{
    /// <summary>
    /// Shared functionality for the parsing classes.
    /// </summary>
    public static class ParsingHelpers
    {
        /// <summary>
        /// Parses a version from a given <see cref="XElement"/>, returning a default value if the attribute is null.
        /// </summary>
        /// <param name="element">The element the attribute is on.</param>
        /// <param name="attributeName">The name of the attribute to parse from.</param>
        /// <param name="defaultVersion">The default value to return.</param>
        /// <returns>A parsed version.</returns>
        [CanBeNull]
        [ContractAnnotation("defaultVersion : null => canbenull; defaultVersion : notnull => notnull")]
        public static Version ParseVersion([NotNull] XElement element, [NotNull] string attributeName = "version", [CanBeNull] Version defaultVersion = null)
        {
            var versionAttribute = element.Attribute(attributeName);

            if (versionAttribute is null)
            {
                return defaultVersion;
            }

            var versionString = versionAttribute.Value;
            if (string.IsNullOrWhiteSpace(versionString))
            {
                throw new InvalidDataException("The version attribute was empty.");
            }

            return ParseVersion(versionString, defaultVersion);
        }

        /// <summary>
        /// Parses a version from a given <see cref="string"/>, returning a default value if the string is null or
        /// whitespace.
        /// </summary>
        /// <param name="versionString">The version string.</param>
        /// <param name="defaultVersion">The default value to return.</param>
        /// <returns>A parsed version.</returns>
        [CanBeNull]
        [ContractAnnotation("defaultVersion : null => canbenull; defaultVersion : notnull => notnull")]
        public static Version ParseVersion([CanBeNull] string versionString, [CanBeNull] Version defaultVersion = null)
        {
            var version = string.IsNullOrWhiteSpace(versionString)
                ? defaultVersion
                : new Version(versionString);

            return version;
        }

        /// <summary>
        /// Parses a token signatures from the given <see cref="XElement"/>.
        /// </summary>
        /// <param name="tokenElement">The token element.</param>
        /// <returns>A parsed token.</returns>
        [NotNull]
        public static TokenSignature ParseTokenSignature([NotNull] XElement tokenElement)
        {
            var tokenName = tokenElement.GetRequiredAttribute("name").Value;
            var tokenValueHexStr = tokenElement.GetRequiredAttribute("value").Value;

            if (tokenValueHexStr.StartsWith("0x"))
            {
                tokenValueHexStr = tokenValueHexStr.Substring(2);
            }

            if (!long.TryParse(tokenValueHexStr, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var tokenValue))
            {
                if (!long.TryParse(tokenValueHexStr, out tokenValue))
                {
                    throw new InvalidDataException("Token value was not in a valid format.");
                }
            }

            var tokenDeprecationVersion = ParseVersion(tokenElement, "deprecated");

            var tokenRemarks = tokenElement.Attribute("remark")?.Value;

            // We'll do a bit of a cheeky up-tree walk here to get the version.
            var profileElement = tokenElement.Parent?.Parent
                                 ?? throw new InvalidDataException("No parent element for the enum found.");

            var tokenVersion = ParseVersion(profileElement, defaultVersion: new Version(0, 0));

            return new TokenSignature(tokenName, tokenValue, tokenVersion, tokenDeprecationVersion, tokenRemarks);
        }

        /// <summary>
        /// Parses a type signature from the given <see cref="XElement"/>.
        /// </summary>
        /// <param name="typeElement">The type element.</param>
        /// <returns>A parsed type.</returns>
        [NotNull]
        public static TypeSignature ParseTypeSignature([NotNull] XElement typeElement)
        {
            var typeName = typeElement.GetRequiredAttribute("type").Value;

            return new TypeSignature(typeName);
        }

        /// <summary>
        /// Gets the root element of the signature file.
        /// </summary>
        /// <param name="signatures">The signature document.</param>
        /// <returns>The root element.</returns>
        [NotNull]
        public static XElement GetSignatureRoot([NotNull] XDocument signatures)
        {
            return signatures.GetRequiredElement("signatures");
        }
    }
}
