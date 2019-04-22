using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bind.XML.Documentation;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;
using Humanizer;
using JetBrains.Annotations;

namespace Bind.Writers
{
    internal partial class ProfileWriter
    {
        /// <summary>
        /// Asynchronously writes an enum to a file.
        /// </summary>
        /// <param name="enum">The enum to write.</param>
        /// <param name="file">The file to write to.</param>
        /// <param name="ns">The namespace of this enum.</param>
        /// <param name="prefix">The constant prefix for the profile.</param>
        /// <returns>The asynchronous task.</returns>
        public static async Task WriteEnumAsync(this EnumerationSignature @enum, string file, string ns, string prefix)
        {
            var sw = new StreamWriter(file);
            await sw.WriteLineAsync(EmbeddedResources.LicenseText);
            await sw.WriteLineAsync("using System;");
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("namespace " + ns);
            await sw.WriteLineAsync("{");
            await sw.WriteLineAsync("    public enum " + @enum.Name);
            await sw.WriteLineAsync("    {");
            await WriteTokens(sw, @enum.Tokens, prefix);
            await sw.WriteLineAsync("    }");
            await sw.WriteLineAsync("}");
            await sw.FlushAsync();
            sw.Dispose();
        }

        private static async Task WriteTokens
        (
            [NotNull] StreamWriter sw,
            [NotNull] IEnumerable<TokenSignature> tokens,
            [NotNull] string prefix
        )
        {
            // Make sure everything is sorted. This will avoid random changes between
            // consecutive runs of the program.
            tokens = tokens.OrderBy(c => c.Value).ThenBy(c => c.Name).ToList();

            foreach (var token in tokens)
            {
                var valueString = $"0x{token.Value:X}";

                await sw.WriteLineAsync("        /// <summary>");
                var originalTokenName = $"{prefix}{token.Name.Underscore().ToUpperInvariant()}";
                await sw.WriteLineAsync($"        /// Original was {originalTokenName} = {valueString}");
                await sw.WriteLineAsync("        /// </summary>");

                var needsCasting = token.Value > int.MaxValue || token.Value < 0;
                if (needsCasting)
                {
                    Debug.WriteLine($"Warning: casting overflowing enum value \"{token.Name}\" from 64-bit to 32-bit.");
                    valueString = $"unchecked((int){valueString})";
                }

                if (token != tokens.Last())
                {
                    await sw.WriteLineAsync($"        {token.Name} = {valueString},");
                }
                else
                {
                    await sw.WriteLineAsync($"        {token.Name} = {valueString}");
                }
            }
        }

        /// <summary>
        /// Asynchronously writes this interface to a file.
        /// </summary>
        /// <param name="i">The interface.</param>
        /// <param name="file">The file to write to.</param>
        /// <param name="ns">This interface's namespace.</param>
        /// <param name="prefix">The function prefix for this interface.</param>
        /// <param name="doc">The profile's documentation.</param>
        /// <returns>The asynchronous task.</returns>
        public static async Task WriteInterfaceAsync(this (string, IEnumerable<FunctionSignature>) i, string file, string ns, string prefix, ProfileDocumentation doc)
        {
            var sw = new StreamWriter(file);
            await sw.WriteLineAsync(EmbeddedResources.LicenseText);
            await sw.WriteLineAsync("using AdvancedDLSupport;");
            await sw.WriteLineAsync("using OpenToolkit.Core.Native;");
            await sw.WriteLineAsync("using System;");
            await sw.WriteLineAsync("using System.Runtime.InteropServices;");
            await sw.WriteLineAsync("using System.Text;");
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("namespace " + ns);
            await sw.WriteLineAsync("{");
            await sw.WriteLineAsync("    internal interface " + i.Item1);
            await sw.WriteAsync("    {");
            foreach (var function in i.Item2)
            {
                await sw.WriteLineAsync();
                using (var sr = new StringReader(GetDocumentation(function, doc)))
                {
                    string line;
                    while ((line = await sr.ReadLineAsync()) != null)
                    {
                        await sw.WriteLineAsync("        " + line);
                    }
                }

                await sw.WriteLineAsync
                (
                    "        [NativeSymbol(\"" + prefix + function.NativeEntrypoint + "\")]"
                );
                await sw.WriteLineAsync
                (
                    $"        " +
                    $"[AutoGenerated(" +
                    $"Category = \"{function.Categories.First()}\", " +
                    $"Version = \"{function.IntroducedIn}\", " +
                    $"EntryPoint = \"{prefix}{function.NativeEntrypoint}\"" +
                    $")]"
                );
                using (var sr = new StringReader(GetDeclarationString(function) + ";"))
                {
                    string line;
                    while ((line = await sr.ReadLineAsync()) != null)
                    {
                        await sw.WriteLineAsync("        " + line);
                    }
                }
            }

            await sw.WriteLineAsync("    }");
            await sw.WriteLineAsync("}");
            await sw.FlushAsync();
            sw.Dispose();
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

        private static async Task WriteProjectFileAsync(string ns, string dir, string subdir, string coreProj, bool ext)
        {
            if (File.Exists(Path.Combine(dir, ns + ".csproj")))
            {
                return;
            }

            var csproj = new StreamWriter(Path.Combine(dir, ns + ".csproj"));
            await csproj.WriteLineAsync("<Project Sdk=\"Microsoft.NET.Sdk\">");
            await csproj.WriteLineAsync();
            await csproj.WriteLineAsync("  <PropertyGroup>");
            await csproj.WriteLineAsync("    <TargetFramework>netstandard2.0</TargetFramework>");
            await csproj.WriteLineAsync("    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
            await csproj.WriteLineAsync("    <LangVersion>latest</LangVersion>");
            await csproj.WriteLineAsync("    <RootNamespace>" + ns + "</RootNamespace>");
            await csproj.WriteLineAsync("    <AssemblyName>" + ns + "</AssemblyName>");
            await csproj.WriteLineAsync("  </PropertyGroup>");
            await csproj.WriteLineAsync();
            await csproj.WriteLineAsync("  <ItemGroup>");
            if (ext)
            {
                await csproj.WriteLineAsync
                (
                    "    <ProjectReference Include=\"$(OpenTKSolutionRoot)\\src\\" +
                    subdir + "\\" + coreProj
                    + "\\" + coreProj + ".csproj\" />"
                );
            }
            else
            {
                await csproj.WriteLineAsync
                (
                    "    <ProjectReference Include=\"$(OpenTKSolutionRoot)\\src\\OpenTK.Core\\OpenTK.Core.csproj\" />"
                );
            }

            await csproj.WriteLineAsync("  </ItemGroup>");
            await csproj.WriteLineAsync();
            if (ext)
            {
                await csproj.WriteLineAsync("  <Import Project=\"..\\..\\..\\..\\props\\common.props\" />");
            }
            else
            {
                await csproj.WriteLineAsync("  <Import Project=\"..\\..\\..\\props\\common.props\" />");
            }

            await csproj.WriteLineAsync("  <Import Project=\"$(OpenTKSolutionRoot)\\props\\nuget-common.props\" />");
            await csproj.WriteLineAsync("  <Import Project=\"$(OpenTKSolutionRoot)\\props\\stylecop.props\" />");
            await csproj.WriteLineAsync("</Project>");
            await csproj.FlushAsync();
            csproj.Dispose();
        }

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
                sb.AppendLine();
                foreach (var p in function.GenericTypeParameters)
                {
                    var constraints = p.Constraints.Any()
                        ? string.Join(", ", p.Constraints)
                        : "struct";

                    sb.AppendLine($"    where {p.Name} : {constraints}");
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
    }
}
