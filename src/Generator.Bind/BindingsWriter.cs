﻿//
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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Bind.Extensions;
using Bind.Generators;
using Bind.Structures;
using Bind.Writers;
using Humanizer;

namespace Bind
{
    /// <summary>
    /// Handles the writing of bindings to files.
    /// </summary>
    internal sealed class BindingsWriter
    {
        private IGenerator Generator { get; set; }

        /// <summary>
        /// Writes the bindings for the given generator to file.
        /// </summary>
        /// <param name="generator">The generator.</param>
        public void WriteBindings(IGenerator generator)
        {
            Generator = generator;
            WriteBindings(generator.Delegates, generator.Wrappers, generator.Enums);
        }

        private void WriteBindings(DelegateCollection delegates, FunctionCollection wrappers, EnumCollection enums)
        {
            var baseOutputPath = Program.Arguments.OutputPath;

            Console.WriteLine($"Writing bindings to {baseOutputPath}");

            if (!Directory.Exists(baseOutputPath))
            {
                Directory.CreateDirectory(baseOutputPath);
            }

            // Enums
            WriteEnums(enums, wrappers);

            // Wrappers
            WriteWrappers(wrappers, delegates);
        }

        private void WriteWrappers(FunctionCollection wrappers, DelegateCollection delegates)
        {
            Trace.WriteLine($"Writing wrappers to:\t{Generator.Namespace}.{Generator.ClassName}");

            var baseOutputPath = Path.Combine(Program.Arguments.OutputPath, Generator.OutputSubfolder);
            var wrappersOutputDirectory = Path.Combine(baseOutputPath, "Wrappers");

            if (!Directory.Exists(wrappersOutputDirectory))
            {
                Directory.CreateDirectory(wrappersOutputDirectory);
            }

            // Create the interop setup neccesary
            var tempInteropFilePath = Path.GetTempFileName();
            using (var outputFile = File.Open(tempInteropFilePath, FileMode.OpenOrCreate))
            {
                using (var sw = new SourceWriter(new StreamWriter(outputFile)))
                {
                    WriteLicense(sw);
                    sw.WriteLineNoTabs();

                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Text;");
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLineNoTabs();

                    sw.WriteLine($"namespace {Generator.Namespace}");
                    using (sw.BeginBlock())
                    {
                        sw.WriteLine($"public sealed partial class {Generator.ClassName}");
                        using (sw.BeginBlock())
                        {
                            // Write constructor
                            sw.WriteLine($"static {Generator.ClassName}()");
                            using (sw.BeginBlock())
                            {
                                // Write entry point names.
                                // Instead of strings, which are costly to construct,
                                // we use a 1d array of ASCII bytes. Names are laid out
                                // sequentially, with a nul-terminator between them.
                                sw.WriteLine("EntryPointNames = new byte[]");
                                using (sw.BeginBlock(true))
                                {
                                    foreach (var d in delegates.Values.Select(d => d.First()))
                                    {
                                        var name = Generator.FunctionPrefix + d.Name;
                                        var byteString = string.Join
                                        (
                                            ", ",
                                            Encoding.ASCII.GetBytes(name).Select(b => b.ToString()).ToArray()
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
                                    foreach (var d in delegates.Values.Select(d => d.First()))
                                    {
                                        sw.WriteLine($"{offset},");
                                        var name = Generator.FunctionPrefix + d.Name;
                                        offset += name.Length + 1;
                                    }
                                }

                                sw.WriteLineNoTabs();

                                sw.WriteLine("EntryPoints = new IntPtr[EntryPointNameOffsets.Length];");
                            }
                        }
                    }
                }
            }

            var outputFilePath = Path.Combine(wrappersOutputDirectory, $"{Generator.ClassName}.cs");

            if (File.Exists(outputFilePath))
            {
                File.Delete(outputFilePath);
            }

            File.Move(tempInteropFilePath, outputFilePath);

            // Next, we'll create the individual category files
            foreach (var (extensionName, extensionWrappers) in wrappers)
            {
                var extensionOutputDirectory = Path.Combine(wrappersOutputDirectory, extensionName);

                if (!Directory.Exists(extensionOutputDirectory))
                {
                    Directory.CreateDirectory(extensionOutputDirectory);
                }

                var wrappersByCategory = extensionWrappers.GroupBy(w => w.Category);
                foreach (var category in wrappersByCategory)
                {
                    var categoryNameWithoutExtensionPrefix = category.Key.Substring(category.Key.IndexOf('_') + 1);
                    var titleCaseCategoryName = categoryNameWithoutExtensionPrefix.Pascalize();

                    var tempWrapperOutputPath = Path.GetTempFileName();
                    using (var outputFile = File.Open(tempWrapperOutputPath, FileMode.OpenOrCreate))
                    {
                        using (var sw = new SourceWriter(new StreamWriter(outputFile)))
                        {
                            WriteLicense(sw);
                            sw.WriteLineNoTabs();

                            sw.WriteLine("using System;");
                            sw.WriteLine("using System.Text;");
                            sw.WriteLine("using System.Runtime.InteropServices;");
                            sw.WriteLineNoTabs();

                            sw.WriteLine($"namespace {Generator.Namespace}");
                            using (sw.BeginBlock())
                            {
                                SourceWriterBlock outerBlock = null;
                                if (extensionName == "Core")
                                {
                                    sw.WriteLine($"public sealed partial class {Generator.ClassName}");
                                }
                                else
                                {
                                    sw.WriteLine($"public sealed partial class {Generator.ClassName}");

                                    outerBlock = sw.BeginBlock();

                                    sw.WriteLine("/// <summary>");
                                    sw.WriteLine($"/// Contains native bindings to functions in the category \"{titleCaseCategoryName}\" in the extension \"{extensionName}\".");
                                    sw.WriteLine("/// </summary>");
                                    sw.WriteLine($"public static partial class {extensionName}");
                                }

                                using (sw.BeginBlock())
                                {
                                    var categoryWrappers = category.OrderBy(w => w).ToList();
                                    foreach (var wrapper in categoryWrappers)
                                    {
                                        WriteMethod(sw, wrapper);

                                        if (wrapper != categoryWrappers.Last())
                                        {
                                            sw.WriteLineNoTabs();
                                        }
                                    }

                                    sw.WriteLineNoTabs();

                                    sw.WriteLine("#pragma warning disable SA1300 // Element should begin with an upper-case letter");
                                    sw.WriteLineNoTabs();

                                    // Emit native signatures.
                                    // These are required by the patcher.
                                    var categoryNatives = categoryWrappers.Select(w => w.WrappedDelegateDefinition).Distinct().ToList();
                                    foreach (var native in categoryNatives)
                                    {
                                        sw.WriteLine($"[Slot({native.Slot})]");
                                        sw.WriteLine("[DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]");
                                        sw.WriteLine($"private static extern {GetDeclarationString(native, false)};");

                                        if (native != categoryNatives.Last())
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

                    var outputCategorySubPath = Path.Combine(extensionOutputDirectory, $"{titleCaseCategoryName}.cs");

                    if (File.Exists(outputCategorySubPath))
                    {
                        File.Delete(outputCategorySubPath);
                    }

                    File.Move(tempWrapperOutputPath, outputCategorySubPath);
                }
            }
        }

        private void WriteMethod(SourceWriter sw, FunctionDefinition f)
        {
            WriteDocumentation(sw, f);

            if (f.IsDeprecated)
            {
                sw.WriteLine($"[Obsolete(\"Deprecated in version {f.DeprecatedVersion}.\")");
            }
            else if (f.IsObsolete)
            {
                sw.WriteLine($"[Obsolete(\"{f.ObsoletionReason}\")]");
            }

            sw.WriteLine($"[AutoGenerated(Category = \"{f.Category}\", Version = \"{f.Version}\", EntryPoint = \"{Generator.FunctionPrefix}{f.WrappedDelegateDefinition.EntryPoint}\")]");

            var declarationString = GetDeclarationString(f).TrimEnd();
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

        private void WriteDocumentation(SourceWriter sw, FunctionDefinition f)
        {
            var docs = f.DocumentationDefinition;

            var warning = string.Empty;
            var category = string.Empty;
            if (f.IsDeprecated)
            {
                warning = $"[deprecated: v{f.DeprecatedVersion}]";
            }

            if (f.ExtensionName != "Core" && !string.IsNullOrEmpty(f.Category))
            {
                category = $"[requires: {f.Category}]";
            }
            else if (!string.IsNullOrEmpty(f.Version))
            {
                if (f.Category.StartsWith("VERSION"))
                {
                    category = $"[requires: {"v" + f.Version}]";
                }
                else
                {
                    category = $"[requires: {"v" + f.Version + " or " + f.Category}]";
                }
            }

            // Write function summary
            sw.WriteLine("/// <summary>");
            if (!string.IsNullOrEmpty(category) || !string.IsNullOrEmpty(warning))
            {
                sw.WriteLine($"/// {category}{warning}");
            }

            if (!string.IsNullOrEmpty(docs.Summary))
            {
                var summaryLines = docs.Summary.TrimEnd().Split('\n');
                foreach (var summaryLine in summaryLines)
                {
                    sw.WriteLine($"/// {summaryLine}");
                }
            }
            sw.WriteLine("/// </summary>");

            // Write function parameters
            for (var i = 0; i < f.Parameters.Count; i++)
            {
                var param = f.Parameters[i];

                // XML documentation doesn't require keyword escaping.
                var docParameterName = param.Name.TrimStart('@');

                var length = string.Empty;
                if (!string.IsNullOrEmpty(param.ComputeSize))
                {
                    length = $"[length: {param.ComputeSize}]";
                }

                // Try to match the correct parameter from documentation:
                // - first by name
                // - then by index
                var docparam =
                    docs.Parameters
                        .FirstOrDefault(p => p.Name == param.RawName) ??
                    (docs.Parameters.Count > i ? docs.Parameters[i] : null);

                if (docparam != null)
                {
                    // '@ref' -> 'ref' etc
                    if (docparam.Name != param.RawName && docparam.Name != param.RawName.Substring(1))
                    {
                        Console.Error.WriteLine
                        (
                            $"[Warning] Parameter '{param.RawName}' in function '{f.Name}' has incorrect doc name '{docparam.Name}'"
                        );
                    }

                    // Note: we use param.Name, because the documentation sometimes
                    // uses different names than the specification.
                    sw.WriteLine($"/// <param name=\"{docParameterName}\">");
                    if (!string.IsNullOrEmpty(length))
                    {
                        sw.WriteLine($"/// {length}");
                    }

                    if (!string.IsNullOrEmpty(docparam.Documentation))
                    {
                        sw.WriteLine($"/// {docparam.Documentation}");
                    }

                    sw.WriteLine("/// </param>");
                }
                else
                {
                    var docstring = string.Join(",", docs.Parameters.Select(p => p.Name).ToArray());

                    Console.Error.WriteLine
                    (
                        $"[Warning] Parameter '{param.Name}' in function '{f.Name}' not found in documentation '{docstring}'"
                    );

                    sw.WriteLine($"/// <param name=\"{docParameterName}\">{length}</param>");
                }
            }

            // Write generic parameter documentation
            var genericParameterNames = f.Parameters.Where(p => p.Generic).Select(p => p.ParameterType.TypeName).Distinct();
            foreach (var genericParameterName in genericParameterNames)
            {
                sw.WriteLine($"/// <typeparam name=\"{genericParameterName}\"></typeparam>");
            }
        }

        private void WriteConstants(SourceWriter sw, IEnumerable<ConstantDefinition> constants)
        {
            // Make sure everything is sorted. This will avoid random changes between
            // consecutive runs of the program.
            constants = constants.OrderBy(c => c).ToList();

            foreach (var c in constants)
            {
                sw.WriteLine("/// <summary>");
                sw.WriteLine($"/// Original was {Generator.ConstantPrefix}{c.OriginalName} = {c.Value}");
                sw.WriteLine("/// </summary>");

                string valueString;
                if (string.IsNullOrEmpty(c.Reference))
                {
                    // This enum has a value
                    valueString = c.Value;
                }
                else
                {
                    // The enum is a reference to another enum
                    valueString = $"{c.Reference}.{c.Value}";
                }

                var isHex = c.Value.StartsWith("0x");
                if (isHex)
                {
                    valueString = valueString.ToLowerInvariant();

                    var hexValue = new string(c.Value.SkipWhile(ch => ch != 'x').Skip(1).ToArray());
                    long integerValue = long.Parse(hexValue, NumberStyles.HexNumber);

                    var needsCasting = integerValue > int.MaxValue || integerValue < 0;
                    if (needsCasting)
                    {
                        // We need to cast this to a straight integer
                        if (c.Unchecked)
                        {
                            valueString = $"unchecked((int){valueString})";
                        }
                        else
                        {
                            valueString = $"((int){valueString})";
                        }
                    }
                }

                sw.Write($"{c.Name} = {valueString}");

                if (c != constants.Last())
                {
                    sw.WriteLine(",");
                    sw.WriteLineNoTabs();
                }
                else
                {
                    sw.WriteLine();
                }
            }
        }

        private void WriteEnums(EnumCollection enums, FunctionCollection wrappers)
        {
            // Build a dictionary of which functions use which enums
            var enumCounts = new Dictionary<EnumDefinition, List<FunctionDefinition>>();
            foreach (var e in enums.Values)
            {
                // Initialize the dictionary
                enumCounts.Add(e, new List<FunctionDefinition>());
            }

            foreach (var wrapper in wrappers.Values.SelectMany(w => w))
            {
                // Add every function to every enum parameter it references
                foreach (var parameter in wrapper.Parameters.Where(p => p.ParameterType.IsEnum))
                {
                    var e = enums[parameter.ParameterType.TypeName];
                    var list = enumCounts[e];
                    list.Add(wrapper);
                }
            }

            var baseOutputPath = Path.Combine(Program.Arguments.OutputPath, Generator.OutputSubfolder);
            var enumOutputDirectory = Path.Combine(baseOutputPath, "Enums");

            if (!Directory.Exists(enumOutputDirectory))
            {
                Directory.CreateDirectory(enumOutputDirectory);
            }

            foreach (var @enum in enums.Values)
            {
                var tempEnumFilePath = Path.GetTempFileName();
                using (var outputFile = File.Open(tempEnumFilePath, FileMode.OpenOrCreate))
                {
                    using (var sw = new SourceWriter(new StreamWriter(outputFile)))
                    {
                        WriteLicense(sw);
                        sw.WriteLineNoTabs();

                        sw.WriteLine("using System;");
                        sw.WriteLineNoTabs();

                        sw.WriteLine("#pragma warning disable SA1139 // Use literal suffix notation instead of casting");
                        sw.WriteLineNoTabs();

                        sw.WriteLine($"namespace {Generator.Namespace}");
                        using (sw.BeginBlock())
                        {
                            // Document which functions use this enum.
                            var functions = enumCounts[@enum]
                                .Select(w =>
                                    Generator.ClassName + (w.ExtensionName != "Core" ? "." + w.ExtensionName : string.Empty) + "." +
                                    w.TrimmedName)
                                .Distinct()
                                .ToList();

                            sw.WriteLine("/// <summary>");
                            sw.WriteLine(
                                $"/// {(functions.Count >= 3 ? $"Used in {string.Join(", ", functions.Take(2).ToArray())} and {functions.Count - 2} other function{(functions.Count() - 2 > 1 ? "s" : string.Empty)}" : functions.Count() >= 1 ? $"Used in {string.Join(", ", functions.ToArray())}" : "Not used directly.")}");
                            sw.WriteLine("/// </summary>");

                            if (@enum.IsObsolete)
                            {
                                sw.WriteLine($"[Obsolete(\"{@enum.Obsolete}\")]");
                            }

                            if (@enum.IsFlagCollection)
                            {
                                sw.WriteLine("[Flags]");
                            }

                            var enumTypeString = string.Empty;
                            if (@enum.Type != "int")
                            {
                                enumTypeString = $" : {@enum.Type}";
                            }

                            sw.WriteLine($"public enum {@enum.Name}{enumTypeString}");
                            using (sw.BeginBlock())
                            {
                                WriteConstants(sw, @enum.ConstantCollection.Values);
                            }
                        }
                    }
                }

                var outputEnumPath = Path.Combine(enumOutputDirectory, $"{@enum.Name}.cs");

                if (File.Exists(outputEnumPath))
                {
                    File.Delete(outputEnumPath);
                }

                File.Move(tempEnumFilePath, outputEnumPath);
            }
        }

        private void WriteLicense(SourceWriter sw)
        {
            var licenseFilePath = Path.Combine(Program.Arguments.LicenseFile);
            var licenseContents = File.ReadAllText(licenseFilePath).TrimEnd();

            sw.WriteLine(licenseContents);
        }

        private string GetDeclarationString(DelegateDefinition d, bool isDelegate)
        {
            var sb = new StringBuilder();

            sb.Append(d.RequiresUnsafeDeclaration ? "unsafe " : string.Empty);
            if (isDelegate)
            {
                sb.Append("delegate ");
            }

            sb.Append(d.ReturnTypeDefinition.GetDeclarationString());
            sb.Append(" ");
            sb.Append(Generator.FunctionPrefix);
            sb.Append(d.Name);
            sb.Append(d.Parameters.GetDeclarationString());

            return sb.ToString();
        }

        private string GetDeclarationString(FunctionDefinition f)
        {
            var sb = new StringBuilder();

            if (f.RequiresUnsafeDeclaration)
            {
                sb.Append("unsafe ");
            }

            sb.Append(f.ReturnTypeDefinition.GetDeclarationString());
            sb.Append(" ");

            sb.Append(!string.IsNullOrEmpty(f.TrimmedName) ? f.TrimmedName : f.Name);

            if (f.Parameters.Any(p => p.Generic))
            {
                sb.Append("<");
                foreach (var p in f.Parameters.Where(p => p.Generic))
                {
                    sb.Append(p.ParameterType.TypeName);
                    sb.Append(", ");
                }

                sb.Remove(sb.Length - 2, 2);
                sb.Append(">");
            }

            sb.Append(f.Parameters.GetDeclarationString());

            if (f.Parameters.Any(p => p.Generic))
            {
                sb.AppendLine();
                foreach (var p in f.Parameters.Where(p => p.Generic))
                {
                    sb.AppendLine($"    where {p.ParameterType.TypeName} : struct");
                }
            }

            return sb.ToString();
        }
    }
}
