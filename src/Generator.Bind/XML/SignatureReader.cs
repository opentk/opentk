using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Bind.Structures;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.XML
{
    /// <summary>
    /// Reads signature definitions from an XML document.
    /// </summary>
    public class SignatureReader
    {
        /// <summary>
        /// A regular expression that matches the parameter names inside of a COMPSIZE(a,b,c) expression.
        /// </summary>
        private static readonly Regex ComputedSizeParametersRegex =
            new Regex("(?<=COMPSIZE\\()(\\w+?,?)+?(?=\\))", RegexOptions.Compiled);

        /// <summary>
        /// A regular expression that matches a single parameter name, used as a reference for the count. Typically
        /// points to an "n", "count", "min", or "max" parameter.
        /// </summary>
        private static readonly Regex CountParameterReferenceRegex =
            new Regex("^[[:alpha:]]+?$", RegexOptions.Compiled);

        [NotNull]
        private XDocument _signatures;

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureReader"/> class.
        /// </summary>
        /// <param name="signatureFilePath">The path to the signatures file.</param>
        public SignatureReader([NotNull, PathReference] string signatureFilePath)
        {
            if (!File.Exists(signatureFilePath))
            {
                throw new FileNotFoundException("Couldn't find the given signatures file.", signatureFilePath);
            }

            using (var s = File.OpenRead(signatureFilePath))
            {
                _signatures = XDocument.Load(s);
            }
        }

        /// <summary>
        /// Gets the root element of the signature file.
        /// </summary>
        /// <returns>The root element.</returns>
        [NotNull]
        private XElement GetSignatureRoot()
        {
            return _signatures.Element("signatures") ?? throw new InvalidDataException("No root element found.");
        }

        /// <summary>
        /// Parses an API profile from the given <see cref="XElement"/>.
        /// </summary>
        /// <param name="profileElement">The profile element.</param>
        /// <returns>A parsed profile.</returns>
        [NotNull]
        private ApiProfile ParseApiProfile([NotNull] XElement profileElement)
        {
            var profileName = profileElement.Attribute("name")?.Value
                              ?? throw new InvalidDataException("Profile name attribute not found.");

            var profileVersionStr = profileElement.Attribute("version")?.Value;
            var profileVersion = string.IsNullOrWhiteSpace(profileVersionStr)
                ? new Version("0.0")
                : new Version(profileVersionStr);

            var functionElements = profileElement.Elements().Where(e => e.Name == "function");
            var functions = functionElements.Select(ParseFunctionSignature).ToList();

            var enumElements = profileElement.Elements().Where(e => e.Name == "enum");
            var enums = enumElements.Select(ParseEnumerationSignature).ToList();

            return new ApiProfile(profileName, profileVersion, functions, enums);
        }

        /// <summary>
        /// Parses a function signature from the given <see cref="XElement"/>.
        /// </summary>
        /// <param name="functionElement">The function element.</param>
        /// <returns>A parsed function.</returns>
        [NotNull]
        private FunctionSignature ParseFunctionSignature([NotNull] XElement functionElement)
        {
            var functionName = functionElement.Attribute("name")?.Value
                               ?? throw new InvalidDataException("Function name attribute not found.");

            var functionCategory = functionElement.Attribute("category")?.Value
                                   ?? throw new InvalidDataException("Function category not found.");

            var functionExtensions = functionElement.Attribute("extension")?.Value
                                     ?? throw new InvalidDataException("Function extension not found.");

            var functionVersionStr = functionElement.Attribute("version")?.Value;
            var functionVersion = string.IsNullOrWhiteSpace(functionVersionStr)
                ? new Version("0.0")
                : new Version(functionVersionStr);

            var functionDeprecationVersionStr = functionElement.Attribute("deprecated")?.Value;
            var functionDeprecationVersion = string.IsNullOrWhiteSpace(functionDeprecationVersionStr)
                ? null
                : new Version(functionDeprecationVersionStr);

            var parameters = ParseParameterSignatures(functionElement);

            var returnElement = functionElement.Element("returns")
                                ?? throw new InvalidDataException("Function return value not found.");
            var returnType = ParseTypeSignature(returnElement);

            return new FunctionSignature
            (
                functionName,
                functionCategory,
                functionExtensions,
                functionVersion,
                returnType,
                parameters,
                functionDeprecationVersion
            );
        }

        [NotNull, ItemNotNull]
        private IReadOnlyList<ParameterSignature> ParseParameterSignatures([NotNull] XElement functionElement)
        {
            var parameterElements = functionElement.Elements().Where(e => e.Name == "param");
            var parametersWithComputedCounts =
                new List<(ParameterSignature Parameter, IReadOnlyList<string> ComputedCountParameterNames)>();
            var parametersWithValueReferenceCounts =
                new List<(ParameterSignature Parameter, string ParameterReferenceName)>();

            var resultParameters = new List<ParameterSignature>();

            foreach (var parameterElement in parameterElements)
            {
                var parameter = ParseParameterSignature
                (
                    parameterElement,
                    out var hasComputedCount,
                    out var computedCountParameterNames,
                    out var hasValueReference,
                    out var valueReferenceName
                );

                if (hasComputedCount)
                {
                    parametersWithComputedCounts.Add((parameter, computedCountParameterNames));
                }

                if (hasValueReference)
                {
                    parametersWithValueReferenceCounts.Add((parameter, valueReferenceName));
                }

                resultParameters.Add(parameter);
            }

            foreach (var (parameter, computedCountNames) in parametersWithComputedCounts)
            {
                var computedParameters = resultParameters.Where(p => computedCountNames.Contains(p.Name)).ToList();
                var countSignature = new CountSignature(computedParameters);

                parameter.Count = countSignature;
            }

            foreach (var (parameter, valueReferenceName) in parametersWithValueReferenceCounts)
            {
                var referenceParameter = resultParameters.FirstOrDefault(p => p.Name == valueReferenceName)
                                         ?? throw new InvalidDataException
                                         (
                                             "Referenced parameter in count attribute not found."
                                         );

                var countSignature = new CountSignature(referenceParameter);

                parameter.Count = countSignature;
            }

            return resultParameters;
        }

        /// <summary>
        /// Parses a function parameter signature from the given <see cref="XElement"/>.
        /// </summary>
        /// <param name="paramElement">The parameter element.</param>
        /// <param name="hasComputedCount">Whether or not the parameter has a computed count.</param>
        /// <param name="computedCountParameterNames">
        /// The names of the parameters that the count is computed from, if any.
        /// </param>
        /// <param name="hasValueReference">Whether or not the parameter has a count value reference.</param>
        /// <param name="valueReferenceName">The name of the parameter that the count value references.</param>
        /// <returns>A parsed parameter.</returns>
        [NotNull]
        private ParameterSignature ParseParameterSignature
        (
            [NotNull] XElement paramElement,
            out bool hasComputedCount,
            [CanBeNull] out IReadOnlyList<string> computedCountParameterNames,
            out bool hasValueReference,
            [CanBeNull] out string valueReferenceName
        )
        {
            computedCountParameterNames = null;
            valueReferenceName = null;

            hasComputedCount = false;
            hasValueReference = false;

            var paramName = paramElement.Attribute("name")?.Value
                            ?? throw new InvalidDataException("Parameter name not found.");

            // A parameter is technically a type signature (think of it as ParameterSignature : ITypeSignature)
            var paramType = ParseTypeSignature(paramElement);

            var paramFlowStr = paramElement.Attribute("flow")?.Value
                               ?? throw new InvalidDataException("Parameter flow not found.");

            if (!Enum.TryParse<FlowDirection>(paramFlowStr, true, out var paramFlow))
            {
                throw new InvalidDataException("Could not parse the parameter flow.");
            }

            var paramCountStr = paramElement.Attribute("count")?.Value;
            if (paramCountStr is null)
            {
                return new ParameterSignature(paramName, paramType, paramFlow);
            }

            if (int.TryParse(paramCountStr, out var staticCount))
            {
                var countSignature = new CountSignature(staticCount);
                return new ParameterSignature(paramName, paramType, paramFlow, countSignature);
            }

            if (ComputedSizeParametersRegex.IsMatch(paramCountStr))
            {
                // It's a computed count, so we'll extract the names and let the count signature resolve in the second pass
                var countParamNames = ComputedSizeParametersRegex
                    .Matches(paramCountStr)
                    .Cast<Match>()
                    .Select(m => m.Value)
                    .First()
                    .Split(',');

                computedCountParameterNames = countParamNames.ToList();

                hasComputedCount = true;
            }
            else if (CountParameterReferenceRegex.IsMatch(paramCountStr))
            {
                // It's a parameter value reference count (that is, taken from the value of another parameter)
                valueReferenceName = ComputedSizeParametersRegex
                    .Matches(paramCountStr)
                    .Cast<Match>()
                    .Select(m => m.Value)
                    .First();

                hasValueReference = true;
            }

            return new ParameterSignature(paramName, paramType, paramFlow);
        }

        /// <summary>
        /// Parses a type signature from the given <see cref="XElement"/>.
        /// </summary>
        /// <param name="typeElement">The type element.</param>
        /// <returns>A parsed type.</returns>
        [NotNull]
        private TypeSignature ParseTypeSignature([NotNull] XElement typeElement)
        {
            var typeName = typeElement.Attribute("type")?.Value
                           ?? throw new InvalidDataException("Type attribute not found.");

            return new TypeSignature(typeName);
        }

        /// <summary>
        /// Parses a function signature from the given <see cref="XElement"/>.
        /// </summary>
        /// <param name="enumElement">The enum element.</param>
        /// <returns>A parsed enumeration.</returns>
        [NotNull]
        private EnumerationSignature ParseEnumerationSignature([NotNull] XElement enumElement)
        {
            var enumName = enumElement.Attribute("name")?.Value
                           ?? throw new InvalidDataException("Enumeration name not found.");

            var tokenElements = enumElement.Elements().Where(e => e.Name == "token");
            var tokens = tokenElements.Select(ParseTokenSignature).ToList();

            // We'll do a bit of a cheeky up-tree walk here to get the version.
            var profileElement = enumElement.Parent
                                 ?? throw new InvalidDataException("No parent element for the enum found.");

            var profileVersionStr = profileElement.Attribute("version")?.Value;
            var enumVersion = profileVersionStr is null
                ? new Version("0.0")
                : new Version(profileVersionStr);

            return new EnumerationSignature(enumName, tokens, enumVersion);
        }

        /// <summary>
        /// Parses a token signatures from the given <see cref="XElement"/>.
        /// </summary>
        /// <param name="tokenElement">The token element.</param>
        /// <returns>A parsed token.</returns>
        [NotNull]
        private TokenSignature ParseTokenSignature([NotNull] XElement tokenElement)
        {
            var tokenName = tokenElement.Attribute("name")?.Value
                           ?? throw new InvalidDataException("Token name not found.");

            var tokenValueHexStr = tokenElement.Attribute("value")?.Value
                           ?? throw new InvalidDataException("Token value not found.");

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

            var tokenDeprecationVersionStr = tokenElement.Attribute("deprecated")?.Value;
            var tokenDeprecationVersion = string.IsNullOrWhiteSpace(tokenDeprecationVersionStr)
                ? null
                : new Version(tokenDeprecationVersionStr);

            var tokenRemarks = tokenElement.Attribute("remark")?.Value;

            // We'll do a bit of a cheeky up-tree walk here to get the version.
            var profileElement = tokenElement.Parent?.Parent
                                 ?? throw new InvalidDataException("No parent element for the enum found.");

            var profileVersionStr = profileElement.Attribute("version")?.Value;
            var tokenVersion = string.IsNullOrWhiteSpace(profileVersionStr)
                ? new Version("0.0")
                : new Version(profileVersionStr);

            return new TokenSignature(tokenName, tokenValue, tokenVersion, tokenDeprecationVersion, tokenRemarks);
        }

        /// <summary>
        /// Retrieves the available profiles in the signatures.
        /// </summary>
        /// <returns>A set profiles.</returns>
        [NotNull, ItemNotNull]
        public IEnumerable<ApiProfile> GetAvailableProfiles()
        {
            var profileElements = GetSignatureRoot().Elements().Where(e => e.Name == "add");
            foreach (var profileElement in profileElements)
            {
                yield return ParseApiProfile(profileElement);
            }
        }
    }
}
