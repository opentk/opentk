using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Bind.Extensions;
using Bind.Structures;
using Bind.Versioning;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.XML.Signatures
{
    /// <summary>
    /// Reads signature definitions from an XML document.
    /// </summary>
    public static class SignatureReader
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

        /// <summary>
        /// Retrieves the available profiles in the signatures.
        /// </summary>
        /// <param name="signatureFilePath">The path to the document.</param>
        /// <returns>A set of profiles.</returns>
        [NotNull, ItemNotNull]
        public static IEnumerable<ApiProfile> GetAvailableProfiles([NotNull, PathReference] string signatureFilePath)
        {
            if (!File.Exists(signatureFilePath))
            {
                throw new FileNotFoundException("Couldn't find the given signatures file.", signatureFilePath);
            }

            XDocument doc;
            using (var s = File.OpenRead(signatureFilePath))
            {
                doc = XDocument.Load(s);
            }

            return GetAvailableProfiles(doc);
        }

        /// <summary>
        /// Retrieves the available profiles in the signatures.
        /// </summary>
        /// <param name="signatureDocument">The signature document.</param>
        /// <returns>A set of profiles.</returns>
        [NotNull, ItemNotNull]
        public static IEnumerable<ApiProfile> GetAvailableProfiles([NotNull] XDocument signatureDocument)
        {
            var profileElements = ParsingHelpers.GetSignatureRoot(signatureDocument).Elements().Where(e => e.Name == "add");
            foreach (var profileElement in profileElements)
            {
                yield return ParseApiProfile(profileElement);
            }
        }

        /// <summary>
        /// Parses an API profile from the given <see cref="XElement"/>.
        /// </summary>
        /// <param name="profileElement">The profile element.</param>
        /// <returns>A parsed profile.</returns>
        [NotNull]
        private static ApiProfile ParseApiProfile([NotNull] XElement profileElement)
        {
            var profileName = profileElement.GetRequiredAttribute("name").Value;

            var profileVersion = ParsingHelpers.ParseVersion(profileElement, defaultVersion: new Version(0, 0));

            var functionElements = profileElement.Elements().Where(e => e.Name == "function");
            var functions = functionElements.Select(ParseFunctionSignature).ToList();

            var enumElements = profileElement.Elements().Where(e => e.Name == "enum");
            var enums = enumElements.Select(ParseEnumerationSignature).ToList();

            return new ApiProfile(profileName, new VersionRange(profileVersion, profileVersion), functions, enums);
        }

        /// <summary>
        /// Parses a function signature from the given <see cref="XElement"/>.
        /// </summary>
        /// <param name="functionElement">The function element.</param>
        /// <returns>A parsed function.</returns>
        [NotNull]
        private static FunctionSignature ParseFunctionSignature([NotNull] XElement functionElement)
        {
            var functionName = functionElement.GetRequiredAttribute("name").Value;
            var functionCategory = functionElement.GetRequiredAttribute("category").Value;
            var functionExtensions = functionElement.GetRequiredAttribute("extension").Value;

            var functionVersion = ParsingHelpers.ParseVersion(functionElement, defaultVersion: new Version(0, 0));
            var functionDeprecationVersion = ParsingHelpers.ParseVersion(functionElement, "deprecated");

            var parameters = ParseParameterSignatures(functionElement);

            var returnElement = functionElement.GetRequiredElement("returns");
            var returnType = ParsingHelpers.ParseTypeSignature(returnElement);

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
        private static IReadOnlyList<ParameterSignature> ParseParameterSignatures([NotNull] XElement functionElement)
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
        private static ParameterSignature ParseParameterSignature
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

            var paramName = paramElement.GetRequiredAttribute("name").Value;

            // A parameter is technically a type signature (think of it as ParameterSignature : ITypeSignature)
            var paramType = ParsingHelpers.ParseTypeSignature(paramElement);

            var paramFlowStr = paramElement.GetRequiredAttribute("flow").Value;

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
        /// Parses a function signature from the given <see cref="XElement"/>.
        /// </summary>
        /// <param name="enumElement">The enum element.</param>
        /// <returns>A parsed enumeration.</returns>
        [NotNull]
        private static EnumerationSignature ParseEnumerationSignature([NotNull] XElement enumElement)
        {
            var enumName = enumElement.GetRequiredAttribute("name").Value;

            var tokenElements = enumElement.Elements().Where(e => e.Name == "token");
            var tokens = tokenElements.Select(ParsingHelpers.ParseTokenSignature).ToList();

            // We'll do a bit of a cheeky up-tree walk here to get the version.
            var profileElement = enumElement.Parent
                                 ?? throw new InvalidDataException("No parent element for the enum found.");

            var enumVersion = ParsingHelpers.ParseVersion(profileElement, defaultVersion: new Version(0, 0));

            return new EnumerationSignature(enumName, enumVersion, tokens);
        }
    }
}
