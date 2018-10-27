using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Bind.Extensions;
using JetBrains.Annotations;

namespace Bind.XML.Documentation
{
    /// <summary>
    /// Reads documentation definitions from an XML document.
    /// </summary>
    public static class DocumentationReader
    {
        /// <summary>
        /// Gets a regular expression that matches a numbered parameter name.
        /// </summary>
        private static readonly Regex ParameterSectionIDRegex = new Regex("^parameters\\d*$");

        /// <summary>
        /// Gets a list of files that should not be parsed. Typically, these files don't contain documentation, and are
        /// supporting files with supplementary information.
        /// </summary>
        private static readonly IReadOnlyList<string> DocumentationFileBlacklist = new List<string>
        {
            "removedTypes.xhtml"
        };

        /// <summary>
        /// Gets the root element of the documentation document.
        /// </summary>
        /// <param name="functionDocument">The document.</param>
        /// <returns>The element.</returns>
        [NotNull]
        private static XElement GetDocumentationRoot([NotNull] XDocument functionDocument)
        {
            return functionDocument.GetRequiredSectionByClass("refentry");
        }

        /// <summary>
        /// Reads the documentation available from a profile from the given path. The path is scanned for *.xml
        /// documents, which are then read one by one.
        /// </summary>
        /// <param name="path">The base path.</param>
        /// <returns>The available documentation for the profile.</returns>
        [NotNull]
        public static ProfileDocumentation ReadProfileDocumentation([NotNull, PathReference] string path)
        {
            var functionDocumentations = new List<FunctionDocumentation>();

            var documentationFiles = Directory.EnumerateFiles(path, "*.xhtml", SearchOption.AllDirectories)
                .Where(file => !DocumentationFileBlacklist.Any(file.EndsWith));

            foreach (var documentationFile in documentationFiles)
            {
                using (var fs = File.OpenRead(documentationFile))
                {
                    var doc = XDocument.Load(fs);
                    if (doc.Root?.Name != "div")
                    {
                        continue;
                    }

                    functionDocumentations.AddRange(ReadFunctionDocumentations(doc));
                }
            }

            return new ProfileDocumentation(functionDocumentations);
        }

        /// <summary>
        /// Reads a function documentation definition from the given document.
        /// </summary>
        /// <param name="functionDocument">The document.</param>
        /// <returns>The documentation.</returns>
        [NotNull, ItemNotNull]
        public static IEnumerable<FunctionDocumentation> ReadFunctionDocumentations
        (
            [NotNull] XDocument functionDocument
        )
        {
            var root = GetDocumentationRoot(functionDocument);

            var definedFunctions = ReadFunctionDefinitions(root).ToList();
            if (!TryGetNameByID(root, out var groupName))
            {
                groupName = definedFunctions.First().Name;
            }

            var purposeWithFunctionName = root.GetRequiredSectionByClass("refnamediv").GetRequiredElement("p").Value;
            var dashIndex = purposeWithFunctionName.IndexOf("—", StringComparison.Ordinal);
            var purpose = purposeWithFunctionName.Substring(dashIndex + 2);

            var parameterSetElements = root
                .GetRequiredSectionsByClass("refsect1")
                .Where
                (
                    e =>
                    {
                        if (!TryGetNameByID(e, out var name))
                        {
                            return false;
                        }

                        return ParameterSectionIDRegex.IsMatch(name);
                    }
                );

            var parameterSets = new Dictionary<string, List<ParameterDocumentation>>();
            foreach (var parameterSetElement in parameterSetElements)
            {
                // The name of the function that these parameters are relevant for is mentioned here if multiple
                // functions are documented in the same file. If not, we seek back to find the last defined function.
                var functionName = parameterSetElement
                                       .GetRequiredElement("h2")
                                       .Element("code")?.Value
                                   ?? FindPrecedingFunctionName(parameterSetElement);

                var parameterSet = ReadParameterDocumentations(parameterSetElement).ToList();

                parameterSets.Add(functionName, parameterSet);
            }

            foreach (var (name, parameters) in definedFunctions)
            {
                if (!parameterSets.TryGetValue(name, out var documentedParameters))
                {
                    if (!parameterSets.TryGetValue(string.Empty, out documentedParameters))
                    {
                       documentedParameters = new List<ParameterDocumentation>();
                    }
                }

                // Create the set of parameter documentations
                var relevantParameters = new List<ParameterDocumentation>();
                foreach (var parameter in parameters)
                {
                    var documentedParameter = documentedParameters.FirstOrDefault(p => p.Name == parameter);

                    if (documentedParameter is null)
                    {
                        relevantParameters.Add
                        (
                            new ParameterDocumentation(parameter, "<p>This parameter is undocumented.</p>")
                        );
                    }
                    else
                    {
                        relevantParameters.Add(documentedParameter);
                    }
                }

                yield return new FunctionDocumentation(name, purpose, relevantParameters, groupName);
            }
        }

        /// <summary>
        /// Attempts to get a name from a given element.
        /// </summary>
        /// <param name="element">The element to search.</param>
        /// <param name="name">The name.</param>
        /// <returns>True if a name was found; otherwise, false.</returns>
        [ContractAnnotation("true, name : notnull <= ; false, name : null <=")]
        private static bool TryGetNameByID([NotNull] XElement element, [CanBeNull] out string name)
        {
            name = null;

            // There are two known permutations: one, the id is stored as an attribute, or as a subelement
            // with the attribute. Pricks.
            if (element.Elements("a").Any())
            {
                name = element.GetRequiredElement("a").GetRequiredAttribute("id").Value;
                return true;
            }

            if (element.Attribute("id") is null)
            {
                return false;
            }

            name = element.GetRequiredAttribute("id").Value;
            return true;
        }

        private static string FindPrecedingFunctionName(XElement parameterSetElement)
        {
            var currentNode = parameterSetElement;

            bool isCurrentNodeFunctionDefinition = false;
            while (!isCurrentNodeFunctionDefinition)
            {
                currentNode = (XElement)currentNode.PreviousNode;
                isCurrentNodeFunctionDefinition = currentNode.Name == "div"
                                                      && currentNode.Attribute("class")?.Value == "refsynopsisdiv";
            }

            var prototypeElement = currentNode
                .GetRequiredSectionsByClass("funcsynopsis")
                .Last()
                .GetRequiredSectionsByClass("funcprototype-table", "table")
                .Last();

            var definition = ReadFunctionDefinition(prototypeElement);
            return definition.Name;
        }

        /// <summary>
        /// Reads the function definitions in the document.
        /// </summary>
        /// <param name="rootElement">The root element.</param>
        /// <returns>The functions with their parameter names.</returns>
        [NotNull]
        private static IEnumerable<(string Name, IReadOnlyList<string> ParameterNames)> ReadFunctionDefinitions
        (
            [NotNull] XElement rootElement
        )
        {
            var definedFunctionElements = rootElement
                .GetRequiredSectionsByClass("refsynopsisdiv")
                .SelectMany
                (
                    synopsdiv =>
                        synopsdiv.GetRequiredSectionsByClass("funcsynopsis")
                            .SelectMany
                            (
                                synopsis =>
                                    synopsis
                                        .GetRequiredSectionsByClass("funcprototype-table", "table")
                            ).ToList()
                ).ToList();

            foreach (var functionElement in definedFunctionElements)
            {
                yield return ReadFunctionDefinition(functionElement);
            }
        }

        /// <summary>
        /// Reads a function definition from the given element.
        /// </summary>
        /// <param name="functionPrototypeElement">The function element.</param>
        /// <returns>The function's name and parameter names.</returns>
        private static (string Name, IReadOnlyList<string> ParameterNames) ReadFunctionDefinition
        (
            [NotNull] XElement functionPrototypeElement
        )
        {
            var name = functionPrototypeElement.Elements("tr").First()
                .GetRequiredElement("td")
                .GetRequiredSectionByClass("funcdef", "code")
                .GetRequiredSectionByClass("fsfunc", string.Empty)
                .Value;

            var parameters = functionPrototypeElement.Elements("tr")
                .SelectMany
                (
                    tr =>
                        tr
                            .GetRequiredElements("td")
                            .Where(td => td.Elements("var").Any())
                            .Select(td => td.GetRequiredElement("var").Value)
                )
                .ToList();

            return (name, parameters);
        }

        /// <summary>
        /// Reads a set of parameter documentations from the given element.
        /// </summary>
        /// <param name="parameterSetElement">The element containing the parameter documentations.</param>
        /// <returns>The parameter set.</returns>
        [NotNull, ItemNotNull]
        private static IEnumerable<ParameterDocumentation> ReadParameterDocumentations
        (
            [NotNull] XElement parameterSetElement
        )
        {
            var variableListElement = parameterSetElement
                .GetRequiredSectionByClass("variablelist")
                .GetRequiredElement("dl");

            var parameterNameElements = new List<XElement>();
            foreach (var element in variableListElement.Elements())
            {
                if (element.Name == "dt")
                {
                    // This is an element containing parameter names
                    parameterNameElements.AddRange
                    (
                        element
                        .GetRequiredSectionsByClass("term", "span")
                        .SelectMany(s => s.GetRequiredSectionsByClass("parameter", "em"))
                    );
                }

                if (element.Name == "dd")
                {
                    // This is an element containing parameter documentation for the preceding names
                    foreach (var nameElement in parameterNameElements)
                    {
                        yield return ReadParameterDocumentation(nameElement, element);
                    }

                    parameterNameElements.Clear();
                }
            }
        }

        /// <summary>
        /// Reads a parameter documentation definition from the given element.
        /// </summary>
        /// <param name="nameElement">The element that contains name information about the parameter.</param>
        /// <param name="descriptionElement">The element that contains the parameter's description.</param>
        /// <returns>The documentation.</returns>
        [NotNull]
        private static ParameterDocumentation ReadParameterDocumentation
        (
            [NotNull] XElement nameElement,
            [NotNull] XElement descriptionElement
        )
        {
            var name = nameElement
                .GetRequiredElement("code")
                .Value;

            // We'll save the whole description subtree for later parsing
            var description = descriptionElement.GetRequiredElement("p").ToString();

            return new ParameterDocumentation(name, description);
        }
    }
}
