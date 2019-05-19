/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Bind.Translation.Trimmers;
using Bind.XML.Documentation;
using Bind.XML.Overrides;
using Bind.XML.Overrides.Functions;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using Humanizer;
using JetBrains.Annotations;

namespace Bind
{
    /// <summary>
    /// Various utilities for use by the tool.
    /// </summary>
    internal static class Utilities
    {
        /// <summary>
        /// Gets a list of keywords in the C# language.
        /// </summary>
        [NotNull]
        public static List<string> CSharpKeywords => new List<string>
        {
            "abstract",
            "event",
            "new",
            "struct",
            "as",
            "explicit",
            "null",
            "switch",
            "base",
            "extern",
            "object",
            "this",
            "bool",
            "false",
            "operator",
            "throw",
            "break",
            "finally",
            "out",
            "true",
            "byte",
            "fixed",
            "override",
            "try",
            "case",
            "float",
            "params",
            "typeof",
            "catch",
            "for",
            "private",
            "uint",
            "char",
            "foreach",
            "protected",
            "ulong",
            "checked",
            "goto",
            "public",
            "unchecked",
            "class",
            "if",
            "readonly",
            "unsafe",
            "const",
            "implicit",
            "ref",
            "ushort",
            "continue",
            "in",
            "return",
            "using",
            "decimal",
            "int",
            "sbyte",
            "virtual",
            "default",
            "interface",
            "sealed",
            "volatile",
            "delegate",
            "internal",
            "short",
            "void",
            "do",
            "is",
            "sizeof",
            "while",
            "double",
            "lock",
            "stackalloc",
            "else",
            "long",
            "static",
            "enum",
            "namespace",
            "string"
        };

        /// <summary>
        /// Gets an array declaration string that matches the given level of array dimensions.
        /// </summary>
        /// <param name="arrayDimensions">The dimension.</param>
        /// <returns>The string.</returns>
        [NotNull]
        public static string GetArrayDimensionString(int arrayDimensions)
        {
            if (arrayDimensions == 0)
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            builder.Append('[');
            builder.Append(new string(',', arrayDimensions - 1));
            builder.Append(']');

            return builder.ToString();
        }

        /// <summary>
        /// Gets the possible variations on the base name of the given override. Typically, this boils down to the
        /// following three cases, in order:
        ///
        /// * FunctionNamefvEXT
        /// * FunctionNamefv
        /// * FunctionName
        ///
        /// Care should be taken when creating new overrides that the intended function is targeted.
        /// </summary>
        /// <param name="functionOverride">The override to create variations of.</param>
        /// <returns>The name variations, ordered by length, starting with the longest.</returns>
        [NotNull, ItemNotNull]
        public static IEnumerable<string> GetNameVariations([NotNull] FunctionOverride functionOverride)
        {
            if (functionOverride.NameType == OverrideNameType.EntryPoint)
            {
                return new[] { functionOverride.BaseName };
            }

            var extensionTrimmer = new OpenGLFunctionExtensionTrimmer();
            var dataTypeTrimmer = new OpenGLFunctionDataTypeTrimmer();

            var variations = new List<string>();
            var currentVariation = functionOverride.BaseName;

            variations.Add(currentVariation);

            if (extensionTrimmer.IsRelevant(functionOverride))
            {
                currentVariation = extensionTrimmer.Trim(functionOverride);
                variations.Add(currentVariation);
            }

            if (dataTypeTrimmer.IsRelevant(currentVariation))
            {
                variations.Add(dataTypeTrimmer.Trim(currentVariation));
            }

            return variations.Distinct().OrderByDescending(v => v.Length);
        }

        /// <summary>
        /// Gets the possible variations on the base name of the given override. Typically, this boils down to the
        /// following three cases, in order:
        ///
        /// * FunctionNamefvEXT
        /// * FunctionNamefv
        /// * FunctionName
        ///
        /// Care should be taken when creating new overrides that the intended function is targeted.
        /// </summary>
        /// <param name="functionOverride">The override to create variations of.</param>
        /// <returns>The name variations, ordered by length, starting with the longest.</returns>
        [NotNull, ItemNotNull]
        public static IEnumerable<string> GetNameVariations([NotNull] RemoveOverride functionOverride)
        {
            return functionOverride.NameType == OverrideNameType.EntryPoint
                ? new[] { functionOverride.Name }
                : GetNameVariations(functionOverride.Name);
        }

        /// <summary>
        /// Gets the possible variations on the given entry point. Typically, this boils down to the
        /// following three cases, in order:
        ///
        /// * FunctionNamefvEXT
        /// * FunctionNamefv
        /// * FunctionName
        ///
        /// Care should be taken when creating new overrides that the intended function is targeted.
        /// </summary>
        /// <param name="functionEntrypoint">The entrypoint to create variations of.</param>
        /// <returns>The name variations, ordered by length, starting with the longest.</returns>
        [NotNull, ItemNotNull]
        public static IEnumerable<string> GetNameVariations(string functionEntrypoint)
        {
            var extensionTrimmer = new OpenGLFunctionExtensionTrimmer();
            var dataTypeTrimmer = new OpenGLFunctionDataTypeTrimmer();

            var variations = new List<string>();
            var currentVariation = functionEntrypoint;

            variations.Add(currentVariation);

            if (extensionTrimmer.IsRelevant(currentVariation))
            {
                currentVariation = extensionTrimmer.Trim(currentVariation);
                variations.Add(currentVariation);
            }

            if (dataTypeTrimmer.IsRelevant(currentVariation))
            {
                variations.Add(dataTypeTrimmer.Trim(currentVariation));
            }

            return variations.Distinct().OrderByDescending(v => v.Length);
        }

        /// <summary>
        /// Writes the default documentation to the given <see cref="StringWriter"/>. This is used when there's no
        /// documentation for a function.
        /// </summary>
        /// <param name="sw">The StringWriter to write the documentation to.</param>
        /// <param name="function">The function to which the documentation regards.</param>
        public static void WritePlaceholderDocumentation
        (
            [NotNull] StringWriter sw,
            [NotNull] FunctionSignature function
        )
        {
            sw.WriteLine("/// <summary>");
            sw.WriteLine("/// To be added.");
            sw.WriteLine("/// </summary>");

            foreach (var parameter in function.Parameters)
            {
                sw.WriteLine($"/// <param name=\"{parameter.Name}\">See summary.</param>");
            }

            if (function.HasGenericTypeParameters)
            {
                foreach (var genericTypeParameter in function.GenericTypeParameters)
                {
                    var referencingParameter = function.Parameters.First(f => f.Type.Name == genericTypeParameter.Name);
                    sw.WriteLine
                    (
                        $"/// <typeparam name=\"{genericTypeParameter.Name}\">The generic type of " +
                        $"{referencingParameter.Name}.</typeparam>"
                    );
                }
            }

            if (!function.ReturnType.Name.Equals(typeof(void).Name, StringComparison.OrdinalIgnoreCase))
            {
                sw.WriteLine("/// <returns>See summary.</returns>");
            }
        }

        /// <summary>
        /// Gets the XML documentation for the given function, using the given <see cref="ProfileDocumentation"/> as a
        /// source for documentation.
        /// </summary>
        /// <param name="function">The function to which the returned documentation regards.</param>
        /// <param name="doc">The documentation source.</param>
        /// <returns>The XML documentation for the given function.</returns>
        public static string GetDocumentation(FunctionSignature function, ProfileDocumentation doc)
        {
            var sw = new StringWriter();
            if (!doc.TryGetDocumentation(function, out var documentation))
            {
                Debug.WriteLine
                (
                    $"The function \"{function.Name}\" lacks documentation. Consider adding a documentation file for " +
                    $"the function."
                );

                WritePlaceholderDocumentation(sw, function);
                return sw.ToString();
            }

            sw.WriteLine("/// <summary>");
            var summaryLines = documentation.Purpose.TrimEnd().Split('\n');
            foreach (var summaryLine in summaryLines)
            {
                sw.WriteLine($"/// {summaryLine}");
            }

            sw.WriteLine("/// </summary>");

            for (int i = 0; i < function.Parameters.Count; ++i)
            {
                var parameter = function.Parameters[i];
                var parameterDocumentation = documentation.Parameters.FirstOrDefault(dp => dp.Name == parameter.Name);
                if (parameterDocumentation is null)
                {
                    sw.WriteLine($"/// <param name=\"{parameter.Name}\">See summary.</param>");
                    continue;
                }

                // XML documentation doesn't require keyword escaping.
                if (parameter.Name.TrimStart('@') != parameterDocumentation.Name)
                {
                    Debug.WriteLine
                    (
                        $"Parameter {parameter.Name} in function {function.Name} has incorrect documentation name " +
                        $"{parameterDocumentation.Name}."
                    );
                }

                sw.WriteLine($"/// <param name=\"{parameterDocumentation.Name}\">");
                if (!(parameter.Count is null))
                {
                    if (parameter.Count.IsStatic)
                    {
                        sw.WriteLine($"/// This parameter contains {parameter.Count.Count} elements.");
                        sw.WriteLine("///");
                    }

                    if (parameter.Count.IsComputed)
                    {
                        var parameterList = parameter.Count.ComputedFrom.Select(cf => cf.Name).Humanize();
                        sw.WriteLine($"/// This parameter's element count is computed from {parameterList}.");
                        sw.WriteLine("///");
                    }

                    if (parameter.Count.IsReference)
                    {
                        // ReSharper disable once PossibleNullReferenceException
                        sw.WriteLine($"/// This parameter's element count is taken from {parameter.Count.ValueReference.Name}.");
                        sw.WriteLine("///");
                    }
                }

                var descriptionLines = parameterDocumentation.Description.TrimEnd().Split('\n');
                foreach (var descriptionLine in descriptionLines)
                {
                    sw.Write($"/// {descriptionLine}");
                }

                sw.WriteLine();
                sw.WriteLine("/// </param>");
            }

            foreach (var genericTypeParameter in function.GenericTypeParameters)
            {
                var referencingParameter = function.Parameters.First(f => f.Type.Name == genericTypeParameter.Name);
                sw.WriteLine
                (
                    $"/// <typeparam name=\"{genericTypeParameter.Name}\">The generic type of " +
                    $"{referencingParameter.Name}.</typeparam>"
                );
            }

            if (!function.ReturnType.Name.Equals(typeof(void).Name, StringComparison.OrdinalIgnoreCase))
            {
                sw.WriteLine("/// <returns>See summary.</returns>");
            }

            return sw.ToString();
        }

        /// <summary>
        /// Gets the C# function declaration for the given function.
        /// </summary>
        /// <param name="function">The function to get a declaration string for.</param>
        /// <returns>A C# function declaration string.</returns>
        [NotNull]
        public static string GetDeclarationString([NotNull] FunctionSignature function)
        {
            var sb = new StringBuilder();

            if (function.Parameters.Any(p => p.Type.IsPointer) || function.ReturnType.IsPointer)
            {
                sb.Append("unsafe ");
            }

            sb.Append(function.ReturnType.ToString());
            sb.Append(" ");

            sb.Append(function.Name);
            if (function.HasGenericTypeParameters)
            {
                sb.Append("<");
                var genericParameterNames = function.GenericTypeParameters.Select(p => p.Name);
                var genericParameterList = string.Join(", ", genericParameterNames);
                sb.Append(genericParameterList);
                sb.Append(">");
            }

            sb.Append("(");
            if (function.Parameters.Count > 0)
            {
                var parameterDeclarations = function.Parameters.Select(GetDeclarationString);
                var parameterList = string.Join(", ", parameterDeclarations);
                sb.Append(parameterList);
            }

            sb.Append(")");

            if (function.HasGenericTypeParameters)
            {
                foreach (var p in function.GenericTypeParameters)
                {
                    sb.AppendLine();
                    var constraints = p.Constraints.Any()
                        ? string.Join(", ", p.Constraints)
                        : "struct";

                    sb.Append($"            where {p.Name} : {constraints}");
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Gets the C# declaration string for the given parameter.
        /// </summary>
        /// <param name="parameter">The parameter to get a declaration string for.</param>
        /// <returns>A C# parameter declaration string.</returns>
        [NotNull]
        public static string GetDeclarationString([NotNull] ParameterSignature parameter)
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
                    attributes.Add($"Count(Count = {parameter.Count.Count})");
                }
                else if (parameter.Count.IsComputed)
                {
                    var parameterList = string.Join(", ", parameter.Count.ComputedFrom.Select(p => CheckName(p.Name)));
                    attributes.Add($"Count(Computed = \"{parameterList}\")");
                }
                else if (parameter.Count.IsReference)
                {
                    // ReSharper disable once PossibleNullReferenceException
                    attributes.Add($"Count(Parameter = \"{CheckName(parameter.Count.ValueReference.Name)}\")");
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
            sb.Append(CheckName(parameter.Name));

            return sb.ToString();
        }

        /// <summary>
        /// Checks whether the given name will generate a compiler error, and returns a string that is compiler-safe.
        /// </summary>
        /// <param name="name">The name to check.</param>
        /// <returns>
        /// The given name if it's already compiler-safe, otherwise it returns the name prepended with an
        /// @ symbol.
        /// </returns>
        public static string CheckName(string name)
        {
            if (CSharpKeywords.Contains(name))
            {
                return "@" + name;
            }

            return name;
        }

        /// <summary>
        /// Gets a namespace suffix from the given category name. This will convert something
        /// like EXT_extension_name to EXT.ExtensionName.
        /// </summary>
        /// <param name="name">The category name.</param>
        /// <returns>The namespace name for this category.</returns>
        public static string ConvertExtensionNameToNamespace(string name)
        {
            var ret = string.Empty;
            var split = name.Split('_');
            foreach (var chunk in split)
            {
                var cl = chunk.ToList();
                cl[0] = chunk.Substring(0, 1).ToUpper()[0];
                ret += new string(cl.ToArray()) + ".";
            }

            var firstDot = ret.IndexOf('.');
            var firstHalf = ret.Substring(0, firstDot);
            var secondHalf = ret.Substring(firstDot).Replace(".", string.Empty);

            return firstHalf + "." + secondHalf;
        }
    }
}
