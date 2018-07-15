using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Bind.XML.Overrides;
using JetBrains.Annotations;

namespace Bind.XML
{
    /// <summary>
    /// Reads and organizes override signatures from an XML document.
    /// </summary>
    public class OverrideReader
    {
        [NotNull]
        private XDocument _overrides;

        /// <summary>
        /// Initializes a new instance of the <see cref="OverrideReader"/> class.
        /// </summary>
        /// <param name="signatureFilePath">The path to the overrides file.</param>
        public OverrideReader([NotNull, PathReference] string signatureFilePath)
        {
            if (!File.Exists(signatureFilePath))
            {
                throw new FileNotFoundException("Couldn't find the given signatures file.", signatureFilePath);
            }

            using (var s = File.OpenRead(signatureFilePath))
            {
                _overrides = XDocument.Load(s);
            }
        }

        /// <summary>
        /// Gets the root element of the overrides file.
        /// </summary>
        /// <returns>The root element.</returns>
        [NotNull]
        private XElement GetOverridesRoot()
        {
            return _overrides.Element("signatures") ?? throw new InvalidDataException("No root element found.");
        }

        /// <summary>
        /// Retrieves the overridden profiles in the signatures.
        /// </summary>
        /// <returns>A set of profiles.</returns>
        [NotNull, ItemNotNull]
        public IEnumerable<ApiProfileOverride> GetProfileOverrides()
        {
            var profileElements = GetOverridesRoot().Elements().Where(e => e.Name == "add");
            foreach (var profileElement in profileElements)
            {
                yield return ParseApiProfileOverride(profileElement);
            }
        }

        [NotNull]
        private ApiProfileOverride ParseApiProfileOverride([NotNull] XElement profileElement)
        {
            throw new System.NotImplementedException();
        }
    }
}
