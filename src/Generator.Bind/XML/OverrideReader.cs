using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Bind.Extensions;
using Bind.Structures;
using Bind.XML.Overrides;
using Bind.XML.Overrides.Enumerations;
using Bind.XML.Overrides.Functions;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;
using static Bind.XML.ParsingHelpers;

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
        /// Retrieves the overridden profiles in the signatures.
        /// </summary>
        /// <returns>A set of profiles.</returns>
        [NotNull, ItemNotNull]
        public IEnumerable<ApiProfileOverride> GetProfileOverrides()
        {
            var foundProfiles = new Dictionary
            <
                string,
                Dictionary
                <
                    Version,
                    List<XElement>
                >
            >();

            var profileElements = GetOverridesRoot().Elements().Where(e => e.Name == "add" || e.Name == "overload" || e.Name == "replace");
            foreach (var profileElement in profileElements)
            {
                var profileNamesAndVersions = (Names: ParseProfileNames(profileElement), Versions: ParseProfileVersions(profileElement));

                var profilePairs = profileNamesAndVersions.Names.SelectMany
                (
                    n =>
                        new[] { n }.Zip(profileNamesAndVersions.Versions, (x, y) => (x, y))
                );

                foreach (var (profileName, profileVersion) in profilePairs)
                {
                    if (foundProfiles.TryGetValue(profileName, out var existingProfileVersions))
                    {
                        if (existingProfileVersions.TryGetValue(profileVersion, out var existingProfile))
                        {
                            existingProfile.Add(profileElement);
                            continue;
                        }

                        // We do have the name registered, but not this version
                        existingProfileVersions.Add(profileVersion, new List<XElement> { profileElement });
                        continue;
                    }

                    // We don't have it registered
                    foundProfiles.Add
                    (
                        profileName,
                        new Dictionary<Version, List<XElement>>
                        {
                            { profileVersion, new List<XElement> { profileElement } }
                        }
                    );
                }
            }

            foreach (var (profileName, elementsByVersion) in foundProfiles)
            {
                foreach (var (version, elements) in elementsByVersion)
                {
                    var functionAdditions = new List<FunctionOverride>();
                    var enumerationAdditions = new List<EnumerationOverride>();

                    var functionReplacements = new List<FunctionOverride>();
                    var functionOverloads = new List<FunctionOverride>();

                    foreach (var element in elements)
                    {
                        switch (element.Name.ToString())
                        {
                            case "add":
                            {
                                functionAdditions.AddRange(element.Elements("function").Select(ParseFunctionOverride));
                                enumerationAdditions.AddRange(element.Elements("enum").Select(ParseEnumeration));

                                break;
                            }
                            case "replace":
                            {
                                functionReplacements.AddRange(element.Elements("function").Select(ParseFunctionOverride));
                                break;
                            }
                            case "overload":
                            {
                                functionOverloads.AddRange(element.Elements("function").Select(ParseFunctionOverride));
                                break;
                            }
                            default:
                            {
                                throw new InvalidDataException("Invalid element found in profile.");
                            }
                        }
                    }

                    yield return new ApiProfileOverride
                    (
                        profileName,
                        version,
                        functionAdditions,
                        enumerationAdditions,
                        functionReplacements,
                        functionOverloads
                    );
                }
            }
        }

        [NotNull]
        private FunctionOverride ParseFunctionOverride([NotNull] XElement functionElement)
        {
            var baseFunctionName = functionElement.GetRequiredAttribute("name").Value;
            var baseFunctionExtensions = functionElement.Attribute("extension")?.Value;

            var parameters = functionElement.Elements("param").Select(ParseParameterSignature).ToList();

            var newVersion = ParseVersion(functionElement.Element("version")?.Value);
            var obsoletionReason = functionElement.Element("obsolete")?.Value;

            var returnElement = functionElement.Element("returns");
            var newReturnType = returnElement is null
                ? null
                : ParseTypeSignature(returnElement);

            return new FunctionOverride
            (
                baseFunctionName,
                baseFunctionExtensions,
                newVersion,
                obsoletionReason,
                newReturnType,
                parameters
            );
        }

        /// <summary>
        /// Parses a function parameter signature from the given <see cref="XElement"/>.
        /// </summary>
        /// <param name="paramElement">The parameter element.</param>
        /// <returns>A parsed parameter.</returns>
        [NotNull]
        private ParameterOverride ParseParameterSignature
        (
            [NotNull] XElement paramElement
        )
        {
            var baseName = paramElement.GetRequiredAttribute("name").Value;

            var newName = paramElement.Element("name")?.Value;
            var newTypeElement = paramElement.Element("type");
            var newType = newTypeElement is null
                ? null
                : new TypeSignature(newTypeElement.Value);

            var newFlowElement = paramElement.Element("flow");
            FlowDirection? newFlow = null;
            if (!(newFlowElement is null))
            {
                if (!Enum.TryParse<FlowDirection>(newFlowElement.Value, true, out var parsedFlow))
                {
                    throw new InvalidDataException("Could not parse the parameter flow.");
                }

                newFlow = parsedFlow;
            }

            var newCount = paramElement.Attribute("count")?.Value;

            return new ParameterOverride
            (
                baseName,
                newName,
                newType,
                newFlow,
                newCount
            );
        }

        [NotNull]
        private EnumerationOverride ParseEnumeration([NotNull] XElement enumElement)
        {
            var enumName = enumElement.GetRequiredAttribute("name").Value;

            var directTokens = enumElement.Elements("token").Select(ParseTokenSignature).ToList();
            var useTokens = enumElement.Elements("use").Select(ParseUseTokenOverride).ToList();
            var reuseTokens = enumElement.Elements("reuse").Select(ParseReuseEnumerationOverride).ToList();

            return new EnumerationOverride(enumName, directTokens, useTokens, reuseTokens);
        }

        /// <summary>
        /// Parses a reuse token from a given <see cref="XElement"/>.
        /// </summary>
        /// <param name="reuseElement">The element.</param>
        /// <returns>A parsed token.</returns>
        [NotNull]
        private ReuseEnumerationOverride ParseReuseEnumerationOverride([NotNull] XElement reuseElement)
        {
            var enumName = reuseElement.GetRequiredAttribute("enum").Value;

            return new ReuseEnumerationOverride(enumName);
        }

        /// <summary>
        /// Parses a use token from a given <see cref="XElement"/>.
        /// </summary>
        /// <param name="useElement">The element.</param>
        /// <returns>A parsed token.</returns>
        [NotNull]
        private UseTokenOverride ParseUseTokenOverride([NotNull] XElement useElement)
        {
            var tokenName = useElement.GetRequiredAttribute("token").Value;
            var enumName = useElement.Attribute("enum")?.Value;

            return new UseTokenOverride(tokenName, enumName);
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

        [NotNull, ItemNotNull]
        private IEnumerable<string> ParseProfileNames([NotNull] XElement profileElement)
        {
            var profileNameString = profileElement.Attribute("name")?.Value
                                    ?? throw new InvalidDataException("Profile name attribute not found.");

            return profileNameString.Split('|');
        }

        [NotNull, ItemNotNull]
        private IEnumerable<Version> ParseProfileVersions([NotNull] XElement profileElement)
        {
            var profileVersionString = profileElement.Attribute("version")?.Value ?? string.Empty;
            var profileVersionStrings = profileVersionString.Split('|');

            return profileVersionStrings.Select
            (
                s =>
                    string.IsNullOrWhiteSpace(s)
                        ? new Version("0.0")
                        : new Version(s)
            );
        }
    }
}
