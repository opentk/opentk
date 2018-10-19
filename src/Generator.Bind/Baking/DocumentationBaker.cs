using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Bind.Extensions;
using Bind.Translation.Translators;
using Bind.XML.Documentation;
using Bind.XML.Signatures;
using Humanizer;
using JetBrains.Annotations;

namespace Bind.Baking
{
    /// <summary>
    /// Bakes the documentation for a profile into more human-readable and XMLDoc-friendly formats.
    /// </summary>
    public class DocumentationBaker
    {
        /// <summary>
        /// Gets the <see cref="ApiProfile"/> that is relevant for the documentation set. Typically, this is a coalesced
        /// profile from a previous stage.
        /// </summary>
        [NotNull]
        private readonly ApiProfile _apiProfile;

        /// <summary>
        /// Gets an identifier translator, used for resolving referenced methods and enumerations.
        /// </summary>
        private readonly NativeIdentifierTranslator _identifierTranslator;

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentationBaker"/> class.
        /// </summary>
        /// <param name="apiProfile">The profile that the documentation should be baked against.</param>
        public DocumentationBaker([NotNull] ApiProfile apiProfile)
        {
            _apiProfile = apiProfile ?? throw new ArgumentNullException(nameof(apiProfile));

            _identifierTranslator = new NativeIdentifierTranslator();
        }

        /// <summary>
        /// Bakes the given documentation set, correcting and augmenting its documentation to .NET inline XML docs.
        /// </summary>
        /// <param name="documentation">The documentation.</param>
        /// <returns>The baked documentation set.</returns>
        [NotNull]
        public ProfileDocumentation BakeDocumentation([NotNull] ProfileDocumentation documentation)
        {
            var bakedFunctions = new List<FunctionDocumentation>();
            foreach (var function in documentation.Functions)
            {
                var functionNameWithoutPrefix = new string(function.Name.SkipWhile(char.IsLower).ToArray());

                var actualFunction =
                    _apiProfile.FindFunctionWithEntrypoint(functionNameWithoutPrefix);
                if (actualFunction is null)
                {
                    // This function isn't a part of the profile
                    continue;
                }

                bakedFunctions.Add(BakeFunctionDocumentation(function));
            }

            return new ProfileDocumentation(bakedFunctions);
        }

        /// <summary>
        /// Bakes the documentation in the given function documentation.
        /// </summary>
        /// <param name="function">The function documentation to bake.</param>
        /// <returns>The baked function.</returns>
        [NotNull]
        private FunctionDocumentation BakeFunctionDocumentation([NotNull] FunctionDocumentation function)
        {
            var purposeBuilder = new StringBuilder();
            purposeBuilder.Append(function.Purpose.Transform(To.SentenceCase));

            if (purposeBuilder[purposeBuilder.Length - 1] != '.')
            {
                purposeBuilder.Append('.');
            }

            var bakedParameters = function.Parameters.Select(p => BakeParameterDocumentation(function, p)).ToList();

            return new FunctionDocumentation(function.Name, purposeBuilder.ToString(), bakedParameters, function.Group);
        }

        /// <summary>
        /// Bakes the documentation in the given parameter documentation.
        /// </summary>
        /// <param name="function">The function the parameter belongs to.</param>
        /// <param name="parameter">The parameter documentation to bake.</param>
        /// <returns>The baked parameter.</returns>
        [NotNull]
        private ParameterDocumentation BakeParameterDocumentation
        (
            [NotNull] FunctionDocumentation function,
            [NotNull] ParameterDocumentation parameter
        )
        {
            var readerSettings = new XmlReaderSettings
            {
                ConformanceLevel = ConformanceLevel.Fragment,
                IgnoreComments = true,
                IgnoreWhitespace = true
            };

            var descriptionBuilder = new StringBuilder();
            using (var sr = new StringReader(parameter.Description))
            {
                using (var xr = XmlReader.Create(sr, readerSettings))
                {
                    var descriptionFragment = XDocument.Load(xr).Root;

                    // Each node handler may consume nodes that come after it. When they do, they're placed in this list
                    // so that they can be skipped.
                    var greedilyConsumedNodes = new List<XNode>();

                    // ReSharper disable once PossibleNullReferenceException
                    foreach (var node in descriptionFragment.Nodes())
                    {
                        if (greedilyConsumedNodes.Contains(node))
                        {
                            continue;
                        }

                        switch (node)
                        {
                            case XText text:
                            {
                                var lines = text.Value.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (var line in lines)
                                {
                                    if (string.IsNullOrWhiteSpace(line))
                                    {
                                        continue;
                                    }

                                    descriptionBuilder.AppendLine(line.Trim());
                                }

                                break;
                            }
                            case XElement element:
                            {
                                if (element.Name == "math")
                                {
                                    // This is a MathML block. We'll just write it as-is.
                                    descriptionBuilder.Append(element);
                                    break;
                                }

                                if (element.Attribute("class") is null)
                                {
                                    // Some sort of weird HTML tag
                                    descriptionBuilder.Append(element);
                                    break;
                                }

                                var elementClass = element.GetRequiredAttribute("class").Value;
                                switch (elementClass)
                                {
                                    case "parameter":
                                    {
                                        AppendParameterNode(descriptionBuilder, element);
                                        break;
                                    }
                                    case "constant":
                                    {
                                        AppendConstantNode(descriptionBuilder, function, parameter, element, greedilyConsumedNodes);
                                        break;
                                    }
                                    case "replaceable":
                                    case "code":
                                    case "emphasis":
                                    {
                                        AppendEmphasisNode(descriptionBuilder, element);
                                        break;
                                    }
                                    case "citerefentry":
                                    case "function":
                                    {
                                        AppendFunctionNode(descriptionBuilder, element);
                                        break;
                                    }
                                    case "footnote":
                                    {
                                        // Skip footnotes
                                        break;
                                    }
                                    default:
                                    {
                                        throw new ArgumentOutOfRangeException
                                        (
                                            nameof(node),
                                            $"Unrecognized element class\"{elementClass}\"."
                                        );
                                    }
                                }

                                break;
                            }
                            default:
                            {
                                throw new ArgumentOutOfRangeException(nameof(node), "Unrecognized node type.");
                            }
                        }
                    }
                }
            }

            var description = descriptionBuilder.ToString().Trim();

            if (!description.EndsWith("."))
            {
                description = $"{description}.";
            }

            return new ParameterDocumentation(parameter.Name, description);
        }

        /// <summary>
        /// Appends the contents of a parameter reference node, transformed into its best-matching XMLDoc equivalent.
        /// </summary>
        /// <param name="descriptionBuilder">The builder to append to.</param>
        /// <param name="parameterNode">The node.</param>
        private static void AppendParameterNode
        (
            [NotNull] StringBuilder descriptionBuilder,
            [NotNull] XElement parameterNode
        )
        {
            var parameterName = parameterNode.GetRequiredElement("code").Value;
            descriptionBuilder.Append($"<paramref name=\"{parameterName}\"/>");
        }

        /// <summary>
        /// Appends the contents of an emphasis node, transformed into its best-matching XMLDoc equivalent.
        /// </summary>
        /// <param name="descriptionBuilder">The builder to append to.</param>
        /// <param name="emphasisNode">The node.</param>
        private static void AppendEmphasisNode
        (
            [NotNull] StringBuilder descriptionBuilder,
            [NotNull] XElement emphasisNode
        )
        {
            descriptionBuilder.Append($"<i>{emphasisNode.Value}</i>");
        }

        /// <summary>
        /// Appends the contents of a function reference node, transformed into its best-matching XMLDoc equivalent.
        /// </summary>
        /// <param name="descriptionBuilder">The builder to append to.</param>
        /// <param name="functionNode">The node.</param>
        private void AppendFunctionNode([NotNull] StringBuilder descriptionBuilder, [NotNull] XElement functionNode)
        {
            var functionNameWithoutPrefix = new string(functionNode.Value.SkipWhile(char.IsLower).ToArray());

            // Look up the function with that entrypoint
            var referencedFunction =
                _apiProfile.FindFunctionWithEntrypoint(functionNameWithoutPrefix);

            if (referencedFunction is null)
            {
                descriptionBuilder.Append($"a function in the {functionNode.Value} set");
            }
            else
            {
                descriptionBuilder.Append
                (
                    $"<see cref=\"{referencedFunction.Name}\"/>"
                );
            }
        }

        /// <summary>
        /// Appends the contents of a constant value node, transformed into its best-matching XMLDoc equivalent.
        /// </summary>
        /// <param name="descriptionBuilder">The builder to append to.</param>
        /// <param name="function">The function the node is in.</param>
        /// <param name="parameter">The parameter the node is in.</param>
        /// <param name="constantNode">The node.</param>
        /// <param name="greedilyConsumedNodes">Nodes that have been greedily consumed.</param>
        private void AppendConstantNode
        (
            [NotNull] StringBuilder descriptionBuilder,
            [NotNull] FunctionDocumentation function,
            [NotNull] ParameterDocumentation parameter,
            [NotNull] XElement constantNode,
            [NotNull, ItemNotNull] ICollection<XNode> greedilyConsumedNodes
        )
        {
            var constantName = constantNode.Value;
            if (constantName.StartsWith("GL_"))
            {
                // It's an enum - transform its name, and look it up
                var translatedName = _identifierTranslator.Translate
                (
                    constantName.Remove(0, 3)
                );

                // Arbitrary number handling
                string arbitraryNumberName = null;
                var hasArbitraryNumberInsert = false;
                if (translatedName.EndsWith("i"))
                {
                    translatedName = translatedName.Remove(translatedName.Length - 1);
                    hasArbitraryNumberInsert = true;
                    arbitraryNumberName = "i";
                }

                var hasEmphasizedNumberInsert = constantNode.NextNode is XElement emphasisNode &&
                                                (emphasisNode.Attribute("class")?.Value == "emphasis" ||
                                                 emphasisNode.Attribute("class")?.Value == "replaceable");
                if (hasEmphasizedNumberInsert)
                {
                    var nextNode = (XElement)constantNode.NextNode;
                    arbitraryNumberName = nextNode.Value;
                    hasArbitraryNumberInsert = true;
                }

                // See if it's followed by a number (emphasized)
                if (hasArbitraryNumberInsert)
                {
                    // It is a number, so we'll just stick a 0 on the end as a stand-in
                    translatedName = $"{translatedName}0";
                }

                if (hasEmphasizedNumberInsert)
                {
                    greedilyConsumedNodes.Add(constantNode.NextNode);
                }

                // See if we can find the name of the enum that the constant is in
                // Look up the function that the parameter is in
                var functionNameWithoutPrefix = new string(function.Name.SkipWhile(char.IsLower).ToArray());

                var actualFunction =
                    _apiProfile.FindFunctionWithEntrypoint(functionNameWithoutPrefix);

                if (actualFunction is null)
                {
                    throw new InvalidOperationException
                    (
                        $"Could not find a function named \"{functionNameWithoutPrefix}\""
                    );
                }

                var actualParameter =
                    actualFunction.Parameters.FirstOrDefault(p => p.Name == parameter.Name);

                var typeName = actualParameter?.Type.Name;
                if (typeName is null)
                {
                    Debug.WriteLine
                    (
                        $"Could not find the parameter named \"{parameter.Name}\" in " +
                        $"\"{actualFunction.Name}\". Consider adding a name override to " +
                        $"match the documentation."
                    );
                }

                if (typeName is null || _apiProfile.Enumerations.All(e => e.Name != typeName))
                {
                    var containingEnum = _apiProfile.FindContainingEnumeration(translatedName);
                    if (containingEnum is null)
                    {
                        typeName = "Unknown";
                    }
                    else
                    {
                        typeName = containingEnum.Name;
                    }

                    Debug.WriteLine
                    (
                        $"Falling back to a manual enum type search for " +
                        $"\"{translatedName}\"."
                    );
                }

                descriptionBuilder.Append
                (
                    $"<see cref=\"{typeName}.{translatedName}\"/>"
                );

                if (hasArbitraryNumberInsert)
                {
                    descriptionBuilder.Append($" (consider 0 as <i>{arbitraryNumberName}</i>)");
                }
            }
            else
            {
                // It's a constant value of some sort - transform it to lower, and inline
                descriptionBuilder.Append
                (
                    $"<value>{constantName.Transform(To.LowerCase)}</value>"
                );
            }
        }
    }
}
