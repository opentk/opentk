using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Bind.Extensions;
using Bind.Versioning;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;
using static Bind.XML.ParsingHelpers;

namespace Bind.XML.Signatures
{
    /// <summary>
    /// Reads signature definitions from an XML document.
    ///
    /// This builds up a working domain model from the XML specification of the API, which we use to generate our bindings.
    /// </summary>
    public static class SignatureReader
    {
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
            var profileElements = GetSignatureRoot(signatureDocument).Elements().Where(e => e.Name == "add");
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

            var profileVersion = ParseVersion(profileElement, defaultVersion: new Version(0, 0));

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
            var functionCategories = functionElement.GetRequiredAttribute("category").Value
                .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            var functionExtensions = functionElement.GetRequiredAttribute("extension").Value;

            var functionVersion = ParseVersion(functionElement, defaultVersion: new Version(0, 0));
            var functionDeprecationVersion = ParseVersion(functionElement, "deprecated");

            var parameters = ParseParameterSignatures(functionElement);

            var returnElement = functionElement.GetRequiredElement("returns");
            var returnType = ParseTypeSignature(returnElement);

            return new FunctionSignature
            (
                functionName,
                functionName, // The function name in the specification is the entrypoint
                functionCategories,
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
                    out var valueReferenceName,
                    out var valueReferenceExpression
                );

                if (hasComputedCount)
                {
                    parametersWithComputedCounts.Add((parameter, computedCountParameterNames));
                }

                if (hasValueReference)
                {
                    parametersWithValueReferenceCounts.Add((parameter, valueReferenceName));

                    // TODO: Pass on the mathematical expression
                }

                resultParameters.Add(parameter);
            }

            ResolveComputedCountSignatures(resultParameters, parametersWithComputedCounts);

            ResolveReferenceCountSignatures(resultParameters, parametersWithValueReferenceCounts);

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
        /// <param name="valueReferenceExpression">The expression that should be applied to the value reference.</param>
        /// <returns>A parsed parameter.</returns>
        [NotNull, ContractAnnotation("hasComputedCount : true => computedCountParameterNames : notnull; hasValueReference : true => valueReferenceName : notnull")]
        private static ParameterSignature ParseParameterSignature
        (
            [NotNull] XElement paramElement,
            out bool hasComputedCount,
            [CanBeNull] out IReadOnlyList<string> computedCountParameterNames,
            out bool hasValueReference,
            [CanBeNull] out string valueReferenceName,
            [CanBeNull] out string valueReferenceExpression
        )
        {
            var paramName = paramElement.GetRequiredAttribute("name").Value;

            // A parameter is technically a type signature (think of it as ParameterSignature : ITypeSignature)
            var paramType = ParseTypeSignature(paramElement);

            var paramFlowStr = paramElement.GetRequiredAttribute("flow").Value;

            if (!Enum.TryParse<FlowDirection>(paramFlowStr, true, out var paramFlow))
            {
                throw new InvalidDataException("Could not parse the parameter flow.");
            }

            var paramCountStr = paramElement.Attribute("count")?.Value;
            var countSignature = ParseCountSignature
            (
                paramCountStr,
                out hasComputedCount,
                out computedCountParameterNames,
                out hasValueReference,
                out valueReferenceName,
                out valueReferenceExpression
            );

            return new ParameterSignature(paramName, paramType, paramFlow, countSignature);
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
            var tokens = tokenElements.Select(ParseTokenSignature).ToList();

            return new EnumerationSignature(enumName, tokens);
        }
    }
}
