using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.Common;
using Generator.Common.Functions;
using Generator.Convert.Documentation;
using Humanizer;
using JetBrains.Annotations;

namespace Generator.Convert.Construction
{
    /// <summary>
    /// A collection of methods for reading and writing documents to functions.
    /// </summary>
    public static class DocumentationWriter
    {
        /// <summary>
        /// Writes <see cref="ProfileDocumentation"/> to a function's <see cref="Function.Doc"/> property.
        /// </summary>
        /// <param name="function">The function to write to.</param>
        /// <param name="documentation">The documentation source.</param>
        /// <returns>An asynchronous task.</returns>
        public static Task WriteDocumentationAsync([NotNull] Function function, ProfileDocumentation documentation)
        {
            var sw = new StringBuilder();
            if (!documentation.TryGetDocumentation(function, out var functionDoc))
            {
                Debug.WriteLine
                (
                    $"The function \"{function.Name}\" lacks documentation. Consider adding a documentation file for " +
                    $"the function."
                );

                WritePlaceholderDocumentation(sw, function);
                return Task.CompletedTask;
            }

            sw.AppendLine("/// <summary>");
            var summaryLines = functionDoc.Purpose.TrimEnd().Split('\n');
            foreach (var summaryLine in summaryLines)
            {
                sw.AppendLine($"/// {summaryLine}");
            }

            sw.AppendLine("/// </summary>");

            for (int i = 0; i < function.Parameters.Count; ++i)
            {
                var parameter = function.Parameters[i];
                var parameterDocumentation = functionDoc.Parameters.FirstOrDefault(dp => dp.Name == parameter.Name);
                if (parameterDocumentation is null)
                {
                    sw.AppendLine($"/// <param name=\"{parameter.Name}\">To be added.</param>");
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

                sw.AppendLine($"/// <param name=\"{parameterDocumentation.Name}\">");
                if (!(parameter.Count is null))
                {
                    if (parameter.Count.IsStatic)
                    {
                        sw.AppendLine($"/// This parameter contains {parameter.Count.StaticCount} elements.");
                        sw.AppendLine("///");
                    }

                    if (parameter.Count.IsComputed)
                    {
                        var parameterList = parameter.Count.ComputedFrom.Select(cf => cf.Name).Humanize();
                        sw.AppendLine($"/// This parameter's element count is computed from {parameterList}.");
                        sw.AppendLine("///");
                    }

                    if (parameter.Count.IsReference)
                    {
                        // ReSharper disable once PossibleNullReferenceException
                        sw.AppendLine
                        (
                            $"/// This parameter's element count is taken from {parameter.Count.ValueReference.Name}."
                        );
                        sw.AppendLine("///");
                    }
                }

                var descriptionLines = parameterDocumentation.Description.TrimEnd().Split('\n');
                foreach (var descriptionLine in descriptionLines)
                {
                    sw.AppendLine($"/// {descriptionLine}");
                }

                sw.AppendLine("/// </param>");
                function.Doc = sw.ToString();
            }

            foreach (var genericTypeParameter in function.GenericTypeParameters)
            {
                var referencingParameter = function.Parameters.First(f => f.Type.Name == genericTypeParameter.Name);
                sw.AppendLine
                (
                    $"/// <typeparam name=\"{genericTypeParameter.Name}\">The generic type of " +
                    $"{referencingParameter.Name}.</typeparam>"
                );
            }

            if (!function.ReturnType.Name.Equals(typeof(void).Name, StringComparison.OrdinalIgnoreCase))
            {
                sw.AppendLine("/// <returns>See online documentation.</returns>");
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// Asynchronously writes documentation to all functions at once.
        /// </summary>
        /// <param name="functions">The functions to write documentation to.</param>
        /// <param name="documentation">The documentation.</param>
        /// <returns>An asynchronous task.</returns>
        public static async Task WriteDocumentationAsync
        (
            [NotNull, ItemNotNull] IEnumerable<Function> functions,
            ProfileDocumentation documentation
        )
        {
            await Task.WhenAll(functions.Select(x => WriteDocumentationAsync(x, documentation)));
        }

        /// <summary>
        /// Writes documentation to all functions at once.
        /// </summary>
        /// <param name="functions">The functions to write documentation to.</param>
        /// <param name="documentation">The documentation.</param>
        public static void Write(IEnumerable<Function> functions, ProfileDocumentation documentation)
        {
            WriteDocumentationAsync(functions, documentation).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Writes documentation to all functions in a profile at once.
        /// </summary>
        /// <param name="profile">The profile to write documentation to.</param>
        /// <param name="documentation">The documentation.</param>
        public static void Write(Profile profile, ProfileDocumentation documentation)
        {
            Task.WhenAll
            (
                profile.Projects.Select(x => x.Value.Interfaces)
                    .SelectMany(x => x.Values)
                    .Select(x => x.Functions)
                    .Select(x => WriteDocumentationAsync(x, documentation))
            )
            .GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the documentation for a baked profile - a raw profile should not be used.
        /// </summary>
        /// <param name="profile">The baked profile.</param>
        /// <param name="docsDotGl">The root of a docs.gl clone.</param>
        /// <returns>The documentation for this baked profile.</returns>
        public static ProfileDocumentation GetDocumentation(Profile profile, string docsDotGl)
        {
            if (profile.Name.StartsWith("OpenGL"))
            {
                var doc = new Dictionary<int, ProfileDocumentation>
                {
                    { 2, DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "gl2")) },
                    { 3, DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "gl3")) },
                    { 4, DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "gl4")) },
                };
                return GetOnlyNewest(doc);
            }

            if (profile.Name == "GLES")
            {
                var doc = new Dictionary<int, ProfileDocumentation>
                {
                    { 1, DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "es1")) },
                    { 2, DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "es2")) },
                    { 3, DocumentationReader.ReadProfileDocumentation(Path.Combine(docsDotGl, "es3")) },
                };
                return GetOnlyNewest(doc);
            }

            // no docs.gl entry for this profile, return dummy documentation.
            return new ProfileDocumentation(new List<FunctionDocumentation>());
        }

        private static ProfileDocumentation GetOnlyNewest(Dictionary<int, ProfileDocumentation> documentations)
        {
            var functions = new Dictionary<string, FunctionDocumentation>();
            foreach (var doc in documentations)
            {
                foreach (var function in doc.Value.Functions)
                {
                    functions[function.Name] = function;
                }
            }

            return new ProfileDocumentation(functions.Values.ToList());
        }

        private static void WritePlaceholderDocumentation([NotNull] StringBuilder sw, [NotNull] Function function)
        {
            sw.AppendLine("/// <summary>");
            sw.AppendLine("/// To be added.");
            sw.AppendLine("/// </summary>");

            foreach (var parameter in function.Parameters)
            {
                sw.AppendLine($"/// <param name=\"{parameter.Name}\">To be added.</param>");
            }

            if (function.GenericTypeParameters.Any())
            {
                foreach (var genericTypeParameter in function.GenericTypeParameters)
                {
                    var referencingParameter = function.Parameters.First(f => f.Type.Name == genericTypeParameter.Name);
                    sw.AppendLine
                    (
                        $"/// <typeparam name=\"{genericTypeParameter.Name}\">The generic type of " +
                        $"{referencingParameter.Name}.</typeparam>"
                    );
                }
            }

            if (!function.ReturnType.Name.Equals(typeof(void).Name, StringComparison.OrdinalIgnoreCase))
            {
                sw.AppendLine("/// <returns>To be added.</returns>");
            }
        }
    }
}
