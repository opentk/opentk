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
using System.IO;
using System.Linq;
using System.Text;
using Bind.Structures;
using Bind.Writers;
using Delegate = Bind.Structures.Delegate;
using Enum = Bind.Structures.Enum;
using Type = Bind.Structures.Type;

namespace Bind
{
    /// <summary>
    /// Handles the writing of bindings to files.
    /// </summary>
    internal sealed class BindingsWriter
    {
        // For example, if parameter foo has indirection level = 1, then it
        // is consumed as 'foo*' in the fixed_statements and the call string.
        private static readonly string[] PointerLevels = { "", "*", "**", "***", "****" };

        private static readonly string[] ArrayLevels = { "", "[]", "[,]", "[,,]", "[,,,]" };

        private static readonly Dictionary<string, string> Aliases = new Dictionary<string, string>
        {
            { nameof(Int16), "short" },
            { nameof(UInt16), "ushort" },
            { nameof(Int32), "int" },
            { nameof(UInt32), "uint" },
            { nameof(Int64), "long" },
            { nameof(UInt64), "ulong" },
            { nameof(Single), "float" },
            { nameof(Double), "double" }
        };

        private IGenerator Generator { get; set; }

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
            string tempEnumsFilePath = Path.GetTempFileName();
            using (var outputFile = File.Open(tempEnumsFilePath, FileMode.OpenOrCreate))
            {
                using (SourceWriter sw = new SourceWriter(new StreamWriter(outputFile)))
                {
                    WriteLicense(sw);
                    sw.WriteLineNoTabs();

                    sw.WriteLine("using System;");
                    sw.WriteLineNoTabs();

                    sw.WriteLine($"namespace {Generator.Namespace}");
                    using (sw.BeginBlock())
                    {
                        WriteEnums(sw, enums, wrappers);
                    }
                }
            }

            // Wrappers
            string tempWrappersFilePath = Path.GetTempFileName();
            using (var outputFile = File.Open(tempWrappersFilePath, FileMode.OpenOrCreate))
            {
                using (var sw = new SourceWriter(new StreamWriter(outputFile)))
                {
                    WriteLicense(sw);
                    sw.WriteLineNoTabs();

                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Text;");
                    sw.WriteLine("using System.Runtime.InteropServices;");
                    sw.WriteLineNoTabs();

                    sw.WriteLine("#pragma warning disable 1591 // Missing doc comments");
                    sw.WriteLine("#pragma warning disable 1572 // Wrong param comments");
                    sw.WriteLine("#pragma warning disable 1573 // Missing param comments");
                    sw.WriteLine("#pragma warning disable 626 // extern method without DllImport");

                    sw.WriteLineNoTabs();

                    sw.WriteLine("namespace {0}", Generator.Namespace);
                    using (sw.BeginBlock())
                    {
                        WriteWrappers(sw, wrappers, delegates);
                    }
                }
            }

            var outputEnums = Path.Combine(baseOutputPath, Generator.OutputSubfolder, $"{Generator.APIIdentifier}.Enums.cs");
            var outputWrappers = Path.Combine(baseOutputPath, Generator.OutputSubfolder, $"{Generator.APIIdentifier}.cs");

            if (File.Exists(outputEnums))
            {
                File.Delete(outputEnums);
            }

            if (File.Exists(outputWrappers))
            {
                File.Delete(outputWrappers);
            }

            File.Move(tempEnumsFilePath, outputEnums);
            File.Move(tempWrappersFilePath, outputWrappers);
        }

        private void WriteWrappers(SourceWriter sw, FunctionCollection wrappers, DelegateCollection delegates)
        {
            Trace.WriteLine($"Writing wrappers to:\t{Generator.Namespace}.{Generator.ClassName}");

            sw.WriteLine("partial class {0}", Generator.ClassName);
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

                    sw.WriteLine("EntryPoints = new IntPtr[EntryPointNameOffsets.Length];");
                }

                sw.WriteLineNoTabs();

                foreach (string key in wrappers.Keys)
                {
                    if (key != "Core")
                    {
                        if (!Char.IsDigit(key[0]))
                        {
                            sw.WriteLine("public static partial class {0}", key);
                        }
                        else
                        {
                            // Identifiers cannot start with a number:
                            sw.WriteLine("public static partial class {0}{1}", Generator.ConstantPrefix, key);
                        }
                        using (sw.BeginBlock())
                        {
                            wrappers[key].Sort();
                            foreach (var f in wrappers[key])
                            {
                                WriteMethod(sw, f);

                                if (f != wrappers[key].Last())
                                {
                                    sw.WriteLineNoTabs();
                                }
                            }
                        }
                    }
                    else
                    {
                        wrappers[key].Sort();
                        foreach (var f in wrappers[key])
                        {
                            WriteMethod(sw, f);

                            if (f != wrappers[key].Last())
                            {
                                sw.WriteLineNoTabs();
                            }
                        }
                    }

                    if (key != wrappers.Keys.Last())
                    {
                        sw.WriteLineNoTabs();
                    }
                }

                // Emit native signatures.
                // These are required by the patcher.
                var wrappersToWrite = wrappers.Values.SelectMany(e => e).Select(w => w.WrappedDelegate).Distinct().ToList();
                foreach (var d in wrappersToWrite)
                {
                    sw.WriteLine($"[Slot({d.Slot})]");
                    sw.WriteLine("[DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]");
                    sw.WriteLine("private static extern {0};", GetDeclarationString(d, false));

                    if (d != wrappersToWrite.Last())
                    {
                        sw.WriteLine();
                    }
                }
            }
        }

        private void WriteMethod(SourceWriter sw, Function f)
        {
            WriteDocumentation(sw, f);

            if (!string.IsNullOrEmpty(f.Obsolete))
            {
                sw.WriteLine($"[Obsolete(\"{f.Obsolete}\")]");
            }

            sw.WriteLine($"[AutoGenerated(Category = \"{f.Category}\", Version = \"{f.Version}\", EntryPoint = \"{Generator.FunctionPrefix}{f.WrappedDelegate.EntryPoint}\")]");

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

        private void WriteDocumentation(SourceWriter sw, Function f)
        {
            var docs = f.Documentation;

            var warning = string.Empty;
            var category = string.Empty;
            if (f.Deprecated)
            {
                warning = $"[deprecated: v{f.DeprecatedVersion}]";
            }

            if (f.Extension != "Core" && !string.IsNullOrEmpty(f.Category))
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
                sw.WriteLine("/// {0}{1}", category, warning);
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
                    sw.WriteLine("/// <param name=\"{0}\">", param.Name);
                    if (!string.IsNullOrEmpty(length))
                    {
                        sw.WriteLine("/// {0}", length);
                    }

                    if (!string.IsNullOrEmpty(docparam.Documentation))
                    {
                        sw.WriteLine("/// {0}", docparam.Documentation);
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
                    sw.WriteLine($"/// <param name=\"{param.Name}\">{length}</param>");
                }
            }
        }

        private void WriteConstants(SourceWriter sw, IEnumerable<Constant> constants)
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

                    var needsCasting = c.Value.SkipWhile(ch => ch != 'x').Count() > 7;
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

                var constant = $"{c.Name} = {valueString}";

                sw.Write(constant);
                if (!string.IsNullOrEmpty(constant))
                {
                    sw.WriteLine(",");
                }

                if (c != constants.Last())
                {
                    sw.WriteLineNoTabs();
                }
            }
        }

        private void WriteEnums(SourceWriter sw, EnumCollection enums, FunctionCollection wrappers)
        {
            // Build a dictionary of which functions use which enums
            var enumCounts = new Dictionary<Enum, List<Function>>();
            foreach (var e in enums.Values)
            {
                // Initialize the dictionary
                enumCounts.Add(e, new List<Function>());
            }

            foreach (var wrapper in wrappers.Values.SelectMany(w => w))
            {
                // Add every function to every enum parameter it references
                foreach (var parameter in wrapper.Parameters.Where(p => p.IsEnum))
                {
                    var e = enums[parameter.CurrentType];
                    var list = enumCounts[e];
                    list.Add(wrapper);
                }
            }

            foreach (var @enum in enums.Values)
            {
                // Document which functions use this enum.
                var functions = enumCounts[@enum]
                    .Select(w =>
                        Generator.ClassName + (w.Extension != "Core" ? "." + w.Extension : string.Empty) + "." +
                        w.TrimmedName)
                    .Distinct()
                    .ToList();

                sw.WriteLine("/// <summary>");
                sw.WriteLine(
                    $"/// {(functions.Count >= 3 ? $"Used in {string.Join(", ", functions.Take(2).ToArray())} and {functions.Count - 2} other function{(functions.Count() - 2 > 1 ? "s" : "")}" : functions.Count() >= 1 ? $"Used in {string.Join(", ", functions.ToArray())}" : "Not used directly.")}");
                sw.WriteLine("/// </summary>");

                if (@enum.IsObsolete)
                {
                    sw.WriteLine("[Obsolete(\"{0}\")]", @enum.Obsolete);
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

                if (@enum != enums.Values.Last())
                {
                    sw.WriteLineNoTabs();
                }
            }
        }

        public void WriteLicense(SourceWriter sw)
        {
            var licenseFilePath = Path.Combine(Program.Arguments.LicenseFile);
            var licenseContents = File.ReadAllText(licenseFilePath).TrimEnd();

            sw.WriteLine(licenseContents);
        }

        private string GetDeclarationString(Delegate d, bool isDelegate)
        {
            var sb = new StringBuilder();

            sb.Append(d.Unsafe ? "unsafe " : string.Empty);
            if (isDelegate)
            {
                sb.Append("delegate ");
            }

            sb.Append(GetDeclarationString(d.ReturnType));
            sb.Append(" ");
            sb.Append(Generator.FunctionPrefix);
            sb.Append(d.Name);
            sb.Append(GetDeclarationString(d.Parameters));

            return sb.ToString();
        }

        private string GetDeclarationString(Function f)
        {
            var sb = new StringBuilder();

            sb.Append(f.Unsafe ? "unsafe " : "");
            sb.Append(GetDeclarationString(f.ReturnType));
            sb.Append(" ");

            sb.Append(!string.IsNullOrEmpty(f.TrimmedName) ? f.TrimmedName : f.Name);

            if (f.Parameters.HasGenericParameters)
            {
                sb.Append("<");
                foreach (var p in f.Parameters.Where(p => p.Generic))
                {
                    sb.Append(p.CurrentType);
                    sb.Append(", ");
                }

                sb.Remove(sb.Length - 2, 2);
                sb.Append(">");
            }

            sb.Append(GetDeclarationString(f.Parameters));

            if (f.Parameters.HasGenericParameters)
            {
                sb.AppendLine();
                foreach (var p in f.Parameters.Where(p => p.Generic))
                {
                    sb.AppendLine($"    where {p.CurrentType} : struct");
                }
            }

            return sb.ToString();
        }

        private string GetDeclarationString(Parameter p)
        {
            var sb = new StringBuilder();

            var attributes = new List<string>();
            if (p.Flow == FlowDirection.Out)
            {
                attributes.Add("OutAttribute");
            }
            else if (p.Flow == FlowDirection.Undefined)
            {
                attributes.Add("InAttribute");
                attributes.Add("OutAttribute");
            }

            if (!string.IsNullOrEmpty(p.ComputeSize))
            {
                if (int.TryParse(p.ComputeSize, out var count))
                {
                    attributes.Add($"CountAttribute(Count = {count})");
                }
                else
                {
                    if (p.ComputeSize.StartsWith("COMPSIZE"))
                    {
                        //remove the compsize hint, just keep comma delimited param names
                        var len = "COMPSIZE(".Length;
                        var computed = p.ComputeSize.Substring(len, p.ComputeSize.Length - len - 1);
                        attributes.Add($"CountAttribute(Computed = \"{computed}\")");
                    }
                    else
                    {
                        attributes.Add($"CountAttribute(Parameter = \"{p.ComputeSize}\")");
                    }
                }
            }

            if (attributes.Count != 0)
            {
                sb.Append("[");
                sb.Append(string.Join(", ", attributes));
                sb.Append("] ");
            }

            if (p.Reference)
            {
                if (p.Flow == FlowDirection.Out)
                {
                    sb.Append("out ");
                }
                else
                {
                    sb.Append("ref ");
                }
            }

            sb.Append(GetDeclarationString((Type)p));

            if (!string.IsNullOrEmpty(p.Name))
            {
                sb.Append(" ");
                sb.Append(p.Name);
            }

            return sb.ToString();
        }

        private string GetDeclarationString(ParameterCollection parameters)
        {
            var sb = new StringBuilder();

            sb.Append("(");
            if (parameters.Count > 0)
            {
                foreach (var p in parameters)
                {
                    sb.Append(GetDeclarationString(p));
                    sb.Append(", ");
                }

                sb.Replace(", ", ")", sb.Length - 2, 2);
            }
            else
            {
                sb.Append(")");
            }

            return sb.ToString();
        }

        private string GetDeclarationString(Type type)
        {
            var t = GetQualifiedTypeOrAlias(type);
            return $"{t}{PointerLevels[type.Pointer]}{ArrayLevels[type.Array]}";
        }

        private string GetQualifiedTypeOrAlias(Type type)
        {
            if (Aliases.ContainsKey(type.QualifiedType))
            {
                return Aliases[type.QualifiedType];
            }

            return type.QualifiedType;
        }
    }
}
