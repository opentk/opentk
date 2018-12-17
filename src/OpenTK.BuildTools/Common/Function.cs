using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using JetBrains.Annotations;
using Newtonsoft.Json;
using OpenTK.BuildTools.Convert;
using static OpenTK.BuildTools.Convert.ParsingHelpers;

namespace OpenTK.BuildTools.Common
{
    /// <summary>
    /// Represents a C# function.
    /// </summary>
    public class Function
    {
        /// <summary>
        /// Gets or sets the name of this function.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is function is unsafe or safe.
        /// </summary>
        public bool IsUnsafe { get; set; }

        /// <summary>
        /// Gets or sets the return type of this function.
        /// </summary>
        public Type ReturnType { get; set; }

        /// <summary>
        /// Gets or sets the name of this function, as defined by the API specification.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the function.
        /// </summary>
        [NotNull, ItemNotNull]
        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        /// <summary>
        /// Gets or sets the categories in which this function falls under.
        /// </summary>
        [NotNull, ItemNotNull, JsonIgnore]
        public string[] Categories { get; set; }

        /// <summary>
        /// Gets or sets the generic type parameters of the function.
        /// </summary>
        [NotNull, ItemNotNull]
        public List<GenericTypeParameter> GenericTypeParameters { get; set; } =
            new List<GenericTypeParameter>();

        /// <summary>
        /// Gets or sets a list of attributes to be applied to this function.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();

        /// <summary>
        /// Gets or sets the formatted XML documentation for this function.
        /// </summary>
        public string Doc { get; set; }
        
        /// <summary>
        /// Gets or sets the name (vendor) of the given extension.
        /// </summary>
        public string ExtensionName { get; set; }

        public static Function Parse(XElement element)
        {
            var functionName = element.GetRequiredAttribute("name").Value;
            var functionCategories = element.GetRequiredAttribute("category")
                .Value
                .Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
            var functionExtensions = element.GetRequiredAttribute("extension").Value;

            var functionVersion = ParseVersion(element, defaultVersion: new Version(0, 0));
            var functionDeprecationVersion = ParseVersion(element, "deprecated");

            var parameters = ParseParameters(element);

            var returnElement = element.GetRequiredElement("returns");
            var returnType = ParseTypeSignature(returnElement);
            return new Function()
            {
                Name = NativeIdentifierTranslator.TranslateIdentifierName(functionName),
                NativeName = functionName,
                Parameters = parameters.ToList(),
                ReturnType = returnType,
                Categories = functionCategories,
                ExtensionName = functionExtensions
            };
        }

        [NotNull, ItemNotNull]
        private static IReadOnlyList<Parameter> ParseParameters([NotNull] XElement functionElement)
        {
            var parameterElements = functionElement.Elements().Where(e => e.Name == "param");
            var parametersWithComputedCounts =
                new List<(Parameter Parameter, IReadOnlyList<string> ComputedCountParameterNames)>();
            var parametersWithValueReferenceCounts =
                new List<(Parameter Parameter, string ParameterReferenceName)>();

            var resultParameters = new List<Parameter>();

            foreach (var parameterElement in parameterElements)
            {
                var parameter = ParseParameter
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
        [NotNull,
         ContractAnnotation
         (
             "hasComputedCount : true => computedCountParameterNames : notnull; hasValueReference : true => valueReferenceName : notnull"
         )]
        private static Parameter ParseParameter
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

            // A parameter is technically a type signature (think of it as Parameter : ITypeSignature)
            var paramType = ParseTypeSignature(paramElement);

            var paramFlowStr = paramElement.GetRequiredAttribute("flow").Value;

            if (!System.Enum.TryParse<FlowDirection>(paramFlowStr, true, out var paramFlow))
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

            return new Parameter() {Name = paramName, Flow = paramFlow, Type = paramType, Count = countSignature};
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var sb = new StringBuilder();

            if (Parameters.Any(p => p.Type.IsPointer) || ReturnType.IsPointer)
            {
                sb.Append("unsafe ");
            }

            sb.Append(ReturnType);
            sb.Append(" ");

            sb.Append(Name);
            if (GenericTypeParameters.Count != 0)
            {
                sb.Append("<");
                var genericParameterNames = GenericTypeParameters.Select(p => p.Name);
                var genericParameterList = string.Join(", ", genericParameterNames);
                sb.Append(genericParameterList);
                sb.Append(">");
            }

            sb.Append("(");
            if (Parameters.Count > 0)
            {
                var parameterDeclarations = Parameters.Select(GetDeclarationString);
                var parameterList = string.Join(", ", parameterDeclarations);
                sb.Append(parameterList);
            }

            sb.Append(")");

            if (GenericTypeParameters.Count != 0)
            {
                sb.Append(" ");
                for (var index = 0; index < GenericTypeParameters.Count; index++)
                {
                    var p = GenericTypeParameters[index];
                    var constraints = p.Constraints.Any()
                        ? string.Join(", ", p.Constraints)
                        : "struct";

                    sb.Append($"where {p.Name} : {constraints}");
                    if (index != GenericTypeParameters.Count - 1)
                    {
                        sb.Append(" ");
                    }
                }
            }

            sb.Append(";");

            return sb.ToString();
        }

        [NotNull]
        private string GetDeclarationString([NotNull] Parameter parameter)
        {
            var sb = new StringBuilder();

            var attributes = new List<string>();
            if (parameter.Flow == FlowDirection.Out)
            {
                attributes.Add("Out");
            }
            else if (parameter.Flow == FlowDirection.Undefined)
            {
                attributes.Add("In");
                attributes.Add("Out");
            }

            if (!(parameter.Count is null))
            {
                if (parameter.Count.IsStatic)
                {
                    attributes.Add($"Count(Count = {parameter.Count.StaticCount})");
                }
                else if (parameter.Count.IsComputed)
                {
                    var parameterList = string.Join(", ", parameter.Count.ComputedFrom.Select(p => p.Name));
                    attributes.Add($"Count(Computed = \"{parameterList}\")");
                }
                else if (parameter.Count.IsReference)
                {
                    // ReSharper disable once PossibleNullReferenceException
                    attributes.Add($"CountAttribute(Parameter = \"{parameter.Count.ValueReference.Name}\")");
                }
            }

            if (attributes.Count != 0)
            {
                sb.Append("[");
                sb.Append(string.Join(", ", attributes));
                sb.Append("] ");
            }

            sb.Append(parameter.Type.ToString());

            sb.Append(" ");
            sb.Append(parameter.Name);

            return sb.ToString();
        }
    }
}