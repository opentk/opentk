//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bind.Generators;
using Bind.Translation.Translators;
using Bind.XML.Documentation;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;
using Humanizer;
using JetBrains.Annotations;
using MoreLinq.Extensions;

namespace Bind.Writers
{
    /// <summary>
    /// Handles asynchronous writing of bindings to files.
    /// </summary>
    internal sealed class BindingWriter
    {
        [NotNull]
        private readonly IGeneratorSettings _generatorSettings;

        [NotNull]
        private readonly ApiProfile _profile;

        [NotNull]
        private readonly ProfileDocumentation _documentation;

        /// <summary>
        /// Holds a dictionary of enumerations, and the functions that use them.
        /// </summary>
        [NotNull]
        private readonly IReadOnlyDictionary<EnumerationSignature, IReadOnlyList<FunctionSignature>> _enumerationUsages;

        /// <summary>
        /// Holds a list of entrypoint names and their allocated entrypoint pointer indexes.
        /// </summary>
        [NotNull]
        private readonly IReadOnlyDictionary<string, int> _entrypointSlots;

        private readonly NativeIdentifierTranslator _identifierTranslator;

        /// <summary>
        /// Initializes a new instance of the <see cref="BindingWriter"/> class.
        /// </summary>
        /// <param name="generatorSettings">The generator settings.</param>
        /// <param name="profile">The profile.</param>
        /// <param name="documentation">The documentation for the profile.</param>
        public BindingWriter
        (
            [NotNull] IGeneratorSettings generatorSettings,
            [NotNull] ApiProfile profile,
            [NotNull] ProfileDocumentation documentation
        )
        {
            _generatorSettings = generatorSettings ?? throw new ArgumentNullException(nameof(generatorSettings));
            _profile = profile ?? throw new ArgumentNullException(nameof(profile));
            _documentation = documentation ?? throw new ArgumentNullException(nameof(documentation));

            var allFunctions = profile.NativeSignatures.Concat(profile.Overloads).ToList();
            var enumerationUsages = new Dictionary<EnumerationSignature, IReadOnlyList<FunctionSignature>>();
            foreach (var e in profile.Enumerations)
            {
                // Initialize the dictionary
                var functionsUsingThisEnum = allFunctions
                    .Where(f => f.Parameters.Any(p => p.Type.Name == e.Name))
                    .ToList();

                enumerationUsages.Add(e, functionsUsingThisEnum);
            }

            _enumerationUsages = enumerationUsages;

            _entrypointSlots = profile.NativeSignatures
                .Select((ns, i) => (ns.NativeEntrypoint, i))
                .ToDictionary(t1 => t1.Item1, t2 => t2.Item2);

            _identifierTranslator = new NativeIdentifierTranslator();
        }

        /// <summary>
        /// Writes the bindings to file.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task WriteBindingsAsync()
        {
            var baseOutputPath = Program.Arguments.OutputPath;

            Console.WriteLine($"Writing bindings to {baseOutputPath}");

            if (!Directory.Exists(baseOutputPath))
            {
                Directory.CreateDirectory(baseOutputPath);
            }

            return Task.WhenAll(WriteEnumsAsync(), WriteWrappersAsync());
        }

        private Task WriteWrappersAsync()
        {
            Trace.WriteLine($"Writing wrappers to:\t{_generatorSettings.Namespace}.{_generatorSettings.ClassName}");

            var baseOutputPath = Path.Combine(Program.Arguments.OutputPath, _generatorSettings.OutputSubfolder);
            var wrappersOutputDirectory = Path.Combine(baseOutputPath, "Wrappers");

            if (!Directory.Exists(wrappersOutputDirectory))
            {
                Directory.CreateDirectory(wrappersOutputDirectory);
            }

            // Group the signatures and overloads by extension
            var extensionNames = _profile.GetExtensions();

            // Create the interop setup necessary
            var createConstructorFileTask = Task.Run(() => WriteWrapperClassConstructorFile(wrappersOutputDirectory));
            var extensionWriteTasks = extensionNames.Select(extensionName => WriteExtensionWrapperFiles(extensionName, wrappersOutputDirectory));

            var tasks = AppendExtension.Append(extensionWriteTasks, createConstructorFileTask);
            return Task.WhenAll(tasks);
        }

        private Task WriteExtensionWrapperFiles([NotNull] string extensionName, [NotNull] string wrappersOutputDirectory)
        {
            var translatedExtensionName = _identifierTranslator.Translate(extensionName);
            var extensionOutputDirectory = Path.Combine(wrappersOutputDirectory, translatedExtensionName);

            if (!Directory.Exists(extensionOutputDirectory))
            {
                Directory.CreateDirectory(extensionOutputDirectory);
            }

            var allCategories = _profile.GetCategories();
            var categoryTasks = allCategories.Select(category => Task.Run(() => WriteCategoryWrapperFile(extensionOutputDirectory, extensionName, category)));

            return Task.WhenAll(categoryTasks);
        }

        private void WriteCategoryWrapperFile
        (
            [NotNull] string extensionOutputDirectory,
            [NotNull] string extensionName,
            [NotNull] string category
        )
        {
            var translatedExtensionName = _identifierTranslator.Translate(extensionName);

            var nativeSignatures = _profile.NativeSignatures
                .Where(ns => ns.Extension == extensionName && ns.Categories.First() == category)
                .OrderBy(s => s.Name)
                .ThenBy(s => s.Parameters.Count)
                .ToList();

            var overloads = _profile.Overloads
                .Where(o => o.Extension == extensionName && o.Categories.First() == category)
                .ToList();

            var categorySignatures = nativeSignatures
                .Concat(overloads)
                .OrderBy(s => s.Name)
                .ThenBy(s => s.Parameters.Count)
                .ThenBy(s => s.ToString())
                .ToList();

            if (categorySignatures.Count == 0)
            {
                return;
            }

            var translatedCategoryName = _identifierTranslator.Translate(category);

            // Create the category file
            var tempWrapperOutputPath = Path.GetTempFileName();
            using (var outputFile = File.Open(tempWrapperOutputPath, FileMode.OpenOrCreate))
            {
                using (var sw = new SourceWriter(new StreamWriter(outputFile)))
                {
                    sw.WriteLine(EmbeddedResources.LicenseText);
                    sw.WriteLineNoTabs();

                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLine("using System.Text;");
                    sw.WriteLineNoTabs();

                    sw.WriteLine($"namespace {_generatorSettings.Namespace}");
                    using (sw.BeginBlock())
                    {
                        SourceWriterBlock? outerBlock = null;
                        if (extensionName == "Core")
                        {
                            sw.WriteLine($"public sealed partial class {_generatorSettings.ClassName}");
                        }
                        else
                        {
                            sw.WriteLine($"public sealed partial class {_generatorSettings.ClassName}");

                            outerBlock = sw.BeginBlock();

                            sw.WriteLine("/// <summary>");
                            sw.WriteLine
                            (
                                $"/// Contains native bindings to functions in the category" +
                                $" \"{translatedCategoryName}\" in the extension " +
                                $"\"{translatedExtensionName}\"."
                            );
                            sw.WriteLine("/// </summary>");

                            // Identifiers can't begin with numbers
                            var safeExtensionName = char.IsDigit(extensionName[0])
                                ? $"{_generatorSettings.ConstantPrefix}{extensionName}"
                                : extensionName;

                            sw.WriteLine($"public static partial class {safeExtensionName}");
                        }

                        // Write the native signature methods
                        // Write the overload methods
                        using (sw.BeginBlock())
                        {
                            var last = categorySignatures[categorySignatures.Count - 1];
                            foreach (var signature in categorySignatures)
                            {
                                WriteMethod(sw, signature);

                                if (signature != last)
                                {
                                    sw.WriteLineNoTabs();
                                }
                            }

                            sw.WriteLineNoTabs();

                            sw.WriteLine(
                                "#pragma warning disable SA1300 // Element should begin with an upper-case letter");
                            sw.WriteLineNoTabs();

                            // Write the native signature externs
                            // These are required by the patcher.
                            foreach (var signature in nativeSignatures)
                            {
                                sw.WriteLine(
                                    $"[Slot({_entrypointSlots[signature.NativeEntrypoint].ToString()})]");
                                sw.WriteLine(
                                    "[DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]");
                                sw.WriteLine
                                (
                                    $"private static extern {GetNativeDeclarationString(signature)};"
                                );

                                if (signature != nativeSignatures.Last())
                                {
                                    sw.WriteLineNoTabs();
                                }
                            }
                        }

                        // We've got a nested class to close
                        outerBlock?.Dispose();
                    }
                }
            }

            var outputCategorySubPath = Path.Combine(extensionOutputDirectory, $"{translatedCategoryName}.cs");

            if (File.Exists(outputCategorySubPath))
            {
                File.Delete(outputCategorySubPath);
            }

            File.Move(tempWrapperOutputPath, outputCategorySubPath);
        }

        private void WriteWrapperClassConstructorFile([NotNull] string wrappersOutputDirectory)
        {
            var tempInteropFilePath = Path.GetTempFileName();
            using (var outputFile = File.Open(tempInteropFilePath, FileMode.OpenOrCreate))
            {
                using (var sw = new SourceWriter(new StreamWriter(outputFile)))
                {
                    sw.WriteLine(EmbeddedResources.LicenseText);
                    sw.WriteLineNoTabs();

                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLine("using System.Text;");
                    sw.WriteLineNoTabs();

                    sw.WriteLine($"namespace {_generatorSettings.Namespace}");
                    using (sw.BeginBlock())
                    {
                        sw.WriteLine($"public sealed partial class {_generatorSettings.ClassName}");
                        using (sw.BeginBlock())
                        {
                            // Write constructor
                            sw.WriteLine($"static {_generatorSettings.ClassName}()");
                            using (sw.BeginBlock())
                            {
                                var nativeEntrypointsWithPrefix = _profile.NativeSignatures
                                    .Select
                                    (
                                        ns => $"{_generatorSettings.FunctionPrefix}{ns.Name}"
                                    )
                                    .ToList();

                                // Write entry point names.
                                // Instead of strings, which are costly to construct,
                                // we use a 1d array of ASCII bytes. Names are laid out
                                // sequentially, with a nul-terminator between them.
                                sw.WriteLine("EntryPointNames = new byte[]");
                                using (sw.BeginBlock(true))
                                {
                                    foreach (var nativeEntrypoint in nativeEntrypointsWithPrefix)
                                    {
                                        var byteString = string.Join
                                        (
                                            ", ",
                                            Encoding.ASCII.GetBytes(nativeEntrypoint).Select(b => b.ToString()).ToArray()
                                        );

                                        sw.WriteLine($"{byteString}, 0,");
                                    }
                                }

                                sw.WriteLineNoTabs();

                                // Write entry point name offsets.
                                // This is an array of offsets into the EntryPointNames[] array above.
                                sw.WriteLine("EntryPointNameOffsets = new int[]");
                                using (sw.BeginBlock(true))
                                {
                                    var offset = 0;
                                    foreach (var nativeEntrypoint in nativeEntrypointsWithPrefix)
                                    {
                                        sw.WriteLine($"{offset.ToString()},");
                                        offset += nativeEntrypoint.Length + 1;
                                    }
                                }

                                sw.WriteLineNoTabs();

                                sw.WriteLine("EntryPoints = new IntPtr[EntryPointNameOffsets.Length];");
                            }
                        }
                    }
                }
            }

            var outputFilePath = Path.Combine(wrappersOutputDirectory, $"{_generatorSettings.ClassName}.cs");

            if (File.Exists(outputFilePath))
            {
                File.Delete(outputFilePath);
            }

            File.Move(tempInteropFilePath, outputFilePath);
        }

        private void WriteMethod([NotNull] SourceWriter sw, [NotNull] FunctionSignature function)
        {
            WriteDocumentation(sw, function);

            if (!(function.DeprecatedIn is null) || !(function.DeprecationReason is null))
            {
                var deprecationBuilder = new StringBuilder();

                if (!(function.DeprecatedIn is null))
                {
                    deprecationBuilder.Append($"Deprecated in version {function.DeprecatedIn} of the specification.");
                }

                if (!(function.DeprecationReason is null))
                {
                    deprecationBuilder.Append(function.DeprecationReason);
                }

                sw.WriteLine($"[Obsolete(\"{deprecationBuilder}\")]");
            }

            sw.WriteLine
            (
                $"[AutoGenerated(" +
                $"Category = \"{function.Categories.First()}\", " +
                $"Version = \"{function.IntroducedIn}\", " +
                $"EntryPoint = \"{_generatorSettings.FunctionPrefix}{function.NativeEntrypoint}\"" +
                $")]"
            );

            var declarationString = GetDeclarationString(function).TrimEnd();
            var declarationStringLines = declarationString.Split('\n').ToList();

            sw.WriteLine($"public static {declarationStringLines.First()}");
            foreach (var line in declarationStringLines.Skip(1))
            {
                sw.WriteLine(line);
            }

            using (sw.BeginBlock())
            {
                sw.WriteLine("throw new BindingsNotRewrittenException();");
            }
        }

        private void WritePlaceholderDocumentation
        (
            [NotNull] SourceWriter sw,
            [NotNull] FunctionSignature function
        )
        {
            sw.WriteLine("/// <summary>");
            sw.WriteLine("/// This function lacks documentation. See online docs for further information.");
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

        private void WriteDocumentation([NotNull] SourceWriter sw, [NotNull] FunctionSignature function)
        {
            if (!_documentation.TryGetDocumentation(function, out var documentation))
            {
                Debug.WriteLine
                (
                    $"The function \"{function.Name}\" lacks documentation. Consider adding a documentation file for " +
                    $"the function."
                );

                WritePlaceholderDocumentation(sw, function);
                return;
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
                    sw.WriteLine($"/// <param name=\"{parameter.Name}\">This parameter lacks documentation.</param>");
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
        }

        private async Task WriteEnumsAsync()
        {
            var baseOutputPath = Path.Combine(Program.Arguments.OutputPath, _generatorSettings.OutputSubfolder);
            var enumOutputDirectory = Path.Combine(baseOutputPath, "Enums");

            if (!Directory.Exists(enumOutputDirectory))
            {
                Directory.CreateDirectory(enumOutputDirectory);
            }

            var genEnumTasks =
                _profile.Enumerations.Select(e => Task.Run(() => WriteEnumerationFile(enumOutputDirectory, e)));
            await Task.WhenAll(genEnumTasks);
        }

        private void WriteEnumerationFile
        (
            [NotNull] string enumOutputDirectory,
            [NotNull] EnumerationSignature enumeration
        )
        {
            var tempEnumFilePath = Path.GetTempFileName();
            using (var outputFile = File.Open(tempEnumFilePath, FileMode.OpenOrCreate))
            {
                using (var sw = new SourceWriter(new StreamWriter(outputFile)))
                {
                    sw.WriteLine(EmbeddedResources.LicenseText);
                    sw.WriteLineNoTabs();

                    if (enumeration.IsFlagEnum)
                    {
                        sw.WriteLine("using System;");
                        sw.WriteLineNoTabs();
                    }

                    sw.WriteLine("// ReSharper disable InconsistentNaming");
                    sw.WriteLine("#pragma warning disable SA1139 // Use literal suffix notation instead of casting");
                    sw.WriteLineNoTabs();

                    sw.WriteLine($"namespace {_generatorSettings.Namespace}");
                    using (sw.BeginBlock())
                    {
                        // Document which functions use this enum.
                        sw.WriteLine("/// <summary>");
                        sw.WriteLine($"/// {GetEnumUsageString(enumeration)}");
                        sw.WriteLine("/// </summary>");

                        if (enumeration.IsFlagEnum)
                        {
                            sw.WriteLine("[Flags]");
                        }

                        sw.WriteLine($"public enum {enumeration.Name}");
                        using (sw.BeginBlock())
                        {
                            WriteTokens(sw, enumeration.Tokens);
                        }
                    }
                }
            }

            var outputEnumPath = Path.Combine(enumOutputDirectory, $"{enumeration.Name}.cs");

            if (File.Exists(outputEnumPath))
            {
                File.Delete(outputEnumPath);
            }

            File.Move(tempEnumFilePath, outputEnumPath);
        }

        private void WriteTokens([NotNull] SourceWriter sw, [NotNull] IEnumerable<TokenSignature> tokens)
        {
            // Make sure everything is sorted. This will avoid random changes between
            // consecutive runs of the program.
            tokens = tokens.OrderBy(c => c.Value).ThenBy(c => c.Name).ToList();

            foreach (var token in tokens)
            {
                var valueString = $"0x{token.Value:X}";

                sw.WriteLine("/// <summary>");
                var originalTokenName = $"{_generatorSettings.ConstantPrefix}{token.Name.Underscore().ToUpperInvariant()}";
                sw.WriteLine($"/// Original was {originalTokenName} = {valueString}");
                sw.WriteLine("/// </summary>");

                var needsCasting = token.Value > int.MaxValue || token.Value < 0;
                if (needsCasting)
                {
                    Debug.WriteLine($"Warning: casting overflowing enum value \"{token.Name}\" from 64-bit to 32-bit.");
                    valueString = $"unchecked((int){valueString})";
                }

                if (token != tokens.Last())
                {
                    sw.WriteLine($"{token.Name} = {valueString},");
                    sw.WriteLineNoTabs();
                }
                else
                {
                    sw.WriteLine($"{token.Name} = {valueString}");
                }
            }
        }

        [NotNull]
        private string GetEnumUsageString([NotNull] EnumerationSignature enumeration)
        {
            var functions = _enumerationUsages[enumeration]
                .Select
                (
                    f =>
                        $"{_generatorSettings.ClassName}{(f.Extension != "Core" ? "." + f.Extension : string.Empty)}.{f.Name}"
                )
                .Distinct()
                .ToList();

            if (functions.Count >= 3)
            {
                var additionalReference = functions.Count - 2 > 1
                    ? "functions"
                    : "function";

                return $"Used in {functions.Take(2).Humanize()}, as well as {(functions.Count - 2).ToString()} " +
                       $"other {additionalReference}.";
            }

            if (functions.Count >= 1)
            {
                return $"Used in {functions.Humanize()}.";
            }

            return "Not used directly.";
        }

        [NotNull]
        private string GetNativeDeclarationString([NotNull] FunctionSignature function)
        {
            var sb = new StringBuilder();

            if (function.Parameters.Any(p => p.Type.IsPointer))
            {
                sb.Append("unsafe ");
            }

            sb.Append(GetDeclarationString(function.ReturnType));
            sb.Append(" ");

            sb.Append(_generatorSettings.FunctionPrefix);
            sb.Append(function.NativeEntrypoint);

            sb.Append("(");
            if (function.Parameters.Count > 0)
            {
                var parameterDeclarations = function.Parameters.Select(GetDeclarationString);
                var parameterList = string.Join(", ", parameterDeclarations);
                sb.Append(parameterList);
            }

            sb.Append(")");

            return sb.ToString();
        }

        [NotNull]
        private string GetDeclarationString([NotNull] FunctionSignature function)
        {
            var sb = new StringBuilder();

            if (function.Parameters.Any(p => p.Type.IsPointer))
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
        private string GetDeclarationString([NotNull] ParameterSignature parameter)
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

            sb.Append(GetDeclarationString(parameter.Type));

            sb.Append(" ");
            sb.Append(parameter.Name);

            return sb.ToString();
        }

        [NotNull]
        private string GetDeclarationString([NotNull] TypeSignature type)
        {
            return type.ToString();
        }
    }
}
