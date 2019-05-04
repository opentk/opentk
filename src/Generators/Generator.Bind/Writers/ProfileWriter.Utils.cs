using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Bind.XML.Documentation;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using Humanizer;
using JetBrains.Annotations;

namespace Bind.Writers
{
    internal partial class ProfileWriter
    {
        private static void WritePlaceholderDocumentation
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
                sw.WriteLine($"/// <param name=\"{parameter.Name}\">To be added.</param>");
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
                sw.WriteLine("/// <returns>To be added.</returns>");
            }
        }

        private static string GetDocumentation(FunctionSignature function, ProfileDocumentation doc)
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
                    sw.WriteLine($"/// <param name=\"{parameter.Name}\">To be added.</param>");
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
                    sw.WriteLine($"/// {descriptionLine}");
                }

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
                sw.WriteLine("/// <returns>See online documentation.</returns>");
            }

            return sw.ToString();
        }

        /// <summary>
        /// Returns a string that's blah blah.
        /// </summary>
        /// <param name="sig">Blah.</param>
        /// <returns>Blep.</returns>
        public static string Tmp(FunctionSignature sig)
        {
            return GetDeclarationString(sig);
        }

        [NotNull]
        private static string GetDeclarationString([NotNull] FunctionSignature function)
        {
            var sb = new StringBuilder();

            if (function.Parameters.Any(p => p.Type.IsPointer) || function.ReturnType.IsPointer)
            {
                sb.Append("unsafe ");
            }

            sb.Append(GetDeclarationString(function.ReturnType));
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

        [NotNull]
        private static string GetDeclarationString([NotNull] ParameterSignature parameter)
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

            sb.Append(GetDeclarationString(parameter.Type));

            sb.Append(" ");
            sb.Append(CheckName(parameter.Name));

            return sb.ToString();
        }

        private static string CheckName(string name)
        {
            if (Utilities.CSharpKeywords.Contains(name))
            {
                return "@" + name;
            }

            return name;
        }

        [NotNull]
        private static string GetDeclarationString([NotNull] TypeSignature type)
        {
            return type.ToString();
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
