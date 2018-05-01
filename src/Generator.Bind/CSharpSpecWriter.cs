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
using Bind.Structures;
using Delegate = Bind.Structures.Delegate;
using Enum = Bind.Structures.Enum;
using Type = Bind.Structures.Type;

namespace Bind
{
    internal sealed class CSharpSpecWriter
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

        private IBind Generator { get; set; }
        private Settings Settings => Generator.Settings;

        public void WriteBindings(IBind generator)
        {
            Generator = generator;
            WriteBindings(generator.Delegates, generator.Wrappers, generator.Enums);
        }

        private void WriteBindings(DelegateCollection delegates, FunctionCollection wrappers, EnumCollection enums)
        {
            Console.WriteLine("Writing bindings to {0}", Settings.OutputPath);
            if (!Directory.Exists(Settings.OutputPath))
            {
                Directory.CreateDirectory(Settings.OutputPath);
            }

            var tempEnumsFile = Path.GetTempFileName();
            var tempWrappersFile = Path.GetTempFileName();

            // Enums
            using (var sw = new BindStreamWriter(tempEnumsFile))
            {
                WriteLicense(sw);

                sw.WriteLine("using System;");
                sw.WriteLine();

                if ((Settings.Compatibility & Settings.Legacy.NestedEnums) != Settings.Legacy.None)
                {
                    sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                    sw.WriteLine("{");
                    sw.Indent();
                    sw.WriteLine("static partial class {0}", Settings.OutputClass);
                }
                else
                {
                    sw.WriteLine("namespace {0}", Settings.EnumsOutput);
                }

                sw.WriteLine("{");

                sw.Indent();
                WriteEnums(sw, enums, wrappers);
                sw.Unindent();

                if ((Settings.Compatibility & Settings.Legacy.NestedEnums) != Settings.Legacy.None)
                {
                    sw.WriteLine("}");
                    sw.Unindent();
                }

                sw.WriteLine("}");
            }

            // Wrappers
            using (var sw = new BindStreamWriter(tempWrappersFile))
            {
                WriteLicense(sw);
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");
                sw.Indent();

                sw.WriteLine("using System;");
                sw.WriteLine("using System.Text;");
                sw.WriteLine("using System.Runtime.InteropServices;");
                sw.WriteLine("using OpenTK.Mathematics;");

                WriteWrappers(sw, wrappers, delegates, enums, Generator.CSTypes);

                sw.Unindent();
                sw.WriteLine("}");
            }

            var outputEnums = Path.Combine(Settings.OutputPath, Settings.EnumsFile);
            var outputDelegates = Path.Combine(Settings.OutputPath, Settings.DelegatesFile);
            var outputCore = Path.Combine(Settings.OutputPath, Settings.ImportsFile);
            var outputWrappers = Path.Combine(Settings.OutputPath, Settings.WrappersFile);

            if (File.Exists(outputEnums))
            {
                File.Delete(outputEnums);
            }

            if (File.Exists(outputDelegates))
            {
                File.Delete(outputDelegates);
            }

            if (File.Exists(outputCore))
            {
                File.Delete(outputCore);
            }

            if (File.Exists(outputWrappers))
            {
                File.Delete(outputWrappers);
            }

            File.Move(tempEnumsFile, outputEnums);
            File.Move(tempWrappersFile, outputWrappers);
        }

        private void WriteWrappers(BindStreamWriter sw, FunctionCollection wrappers,
            DelegateCollection delegates, EnumCollection enums,
            IDictionary<string, string> csTypes)
        {
            Trace.WriteLine($"Writing wrappers to:\t{Settings.OutputNamespace}.{Settings.OutputClass}");

            sw.WriteLine("#pragma warning disable 1591"); // Missing doc comments
            sw.WriteLine("#pragma warning disable 1572"); // Wrong param comments
            sw.WriteLine("#pragma warning disable 1573"); // Missing param comments
            sw.WriteLine("#pragma warning disable 626"); // extern method without DllImport

            sw.WriteLine();
            sw.WriteLine("partial class {0}", Settings.OutputClass);
            sw.WriteLine("{");
            sw.Indent();

            // Write constructor
            sw.WriteLine("static {0}()", Settings.OutputClass);
            sw.WriteLine("{");
            sw.Indent();
            // Write entry point names.
            // Instead of strings, which are costly to construct,
            // we use a 1d array of ASCII bytes. Names are laid out
            // sequentially, with a nul-terminator between them.
            sw.WriteLine("EntryPointNames = new byte[]", delegates.Count);
            sw.WriteLine("{");
            sw.Indent();
            foreach (var d in delegates.Values.Select(d => d.First()))
            {
                if (d.RequiresSlot(Settings))
                {
                    var name = Settings.FunctionPrefix + d.Name;
                    sw.WriteLine("{0}, 0,", string.Join(", ",
                        Encoding.ASCII.GetBytes(name).Select(b => b.ToString()).ToArray()));
                }
            }

            sw.Unindent();
            sw.WriteLine("};");
            // Write entry point name offsets.
            // This is an array of offsets into the EntryPointNames[] array above.
            sw.WriteLine("EntryPointNameOffsets = new int[]", delegates.Count);
            sw.WriteLine("{");
            sw.Indent();
            var offset = 0;
            foreach (var d in delegates.Values.Select(d => d.First()))
            {
                if (d.RequiresSlot(Settings))
                {
                    sw.WriteLine("{0},", offset);
                    var name = Settings.FunctionPrefix + d.Name;
                    offset += name.Length + 1;
                }
            }

            sw.Unindent();
            sw.WriteLine("};");
            sw.WriteLine("EntryPoints = new IntPtr[EntryPointNameOffsets.Length];");
            sw.Unindent();
            sw.WriteLine("}");
            sw.WriteLine();

            var currentWrapper = 0;
            foreach (var key in wrappers.Keys)
            {
                if ((Settings.Compatibility & Settings.Legacy.NoSeparateFunctionNamespaces) == Settings.Legacy.None &&
                    key != "Core")
                {
                    if (!char.IsDigit(key[0]))
                    {
                        sw.WriteLine("public static partial class {0}", key);
                    }
                    else
                    {
                        // Identifiers cannot start with a number:
                        sw.WriteLine("public static partial class {0}{1}", Settings.ConstantPrefix, key);
                    }

                    sw.WriteLine("{");
                    sw.Indent();
                }

                wrappers[key].Sort();
                foreach (var f in wrappers[key])
                {
                    WriteWrapper(sw, f, enums);
                    currentWrapper++;
                }

                if ((Settings.Compatibility & Settings.Legacy.NoSeparateFunctionNamespaces) == Settings.Legacy.None &&
                    key != "Core")
                {
                    sw.Unindent();
                    sw.WriteLine("}");
                    sw.WriteLine();
                }
            }

            // Emit native signatures.
            // These are required by the patcher.
            var currentSignature = 0;
            var wrappersToWrite = wrappers.Values.SelectMany(e => e).Select(w => w.WrappedDelegate).Distinct().ToList();
            foreach (var d in wrappersToWrite)
            {
                sw.WriteLine("[Slot({0})]", d.Slot);
                sw.WriteLine(
                    "[DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]");
                sw.WriteLine("private static extern {0};", GetDeclarationString(d, false));

                if (d != wrappersToWrite.Last())
                {
                    sw.WriteLine();
                }

                currentSignature++;
            }

            sw.Unindent();
            sw.WriteLine("}");

            Console.WriteLine("Wrote {0} wrappers for {1} signatures", currentWrapper, currentSignature);
        }

        private void WriteWrapper(BindStreamWriter sw, Function f, EnumCollection enums)
        {
            if ((Settings.Compatibility & Settings.Legacy.NoDocumentation) == 0)
            {
                WriteDocumentation(sw, f);
            }

            WriteMethod(sw, f, enums);
            sw.WriteLine();
        }

        private void WriteMethod(BindStreamWriter sw, Function f, EnumCollection enums)
        {
            if (!string.IsNullOrEmpty(f.Obsolete))
            {
                sw.WriteLine("[Obsolete(\"{0}\")]", f.Obsolete);
            }
            else if (f.Deprecated && Settings.IsEnabled(Settings.Legacy.AddDeprecationWarnings))
            {
                sw.WriteLine("[Obsolete(\"Deprecated in OpenGL {0}\")]", f.DeprecatedVersion);
            }

            sw.WriteLine("[AutoGenerated(Category = \"{0}\", Version = \"{1}\", EntryPoint = \"{2}\")]",
                f.Category, f.Version, Settings.FunctionPrefix + f.WrappedDelegate.EntryPoint);

            sw.WriteLine("public static {0} {{ throw new BindingsNotRewrittenException(); }}",
                GetDeclarationString(f, Settings.Compatibility));
        }

        private void WriteDocumentation(BindStreamWriter sw, Function f)
        {
            var docs = f.Documentation;

            try
            {
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
                    sw.WriteLine("/// {0}", docs.Summary);
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
                        if (docparam.Name != param.RawName &&
                            docparam.Name != param.RawName.Substring(1)) // '@ref' -> 'ref' etc
                        {
                            Console.Error.WriteLine(
                                "[Warning] Parameter '{0}' in function '{1}' has incorrect doc name '{2}'",
                                param.RawName, f.Name, docparam.Name);
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
                        Console.Error.WriteLine(
                            "[Warning] Parameter '{0}' in function '{1}' not found in documentation '{{{2}}}'",
                            param.Name, f.Name,
                            string.Join(",", docs.Parameters.Select(p => p.Name).ToArray()));
                        sw.WriteLine("/// <param name=\"{0}\">{1}</param>",
                            param.Name, length);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("[Warning] Error documenting function {0}: {1}", f.WrappedDelegate.Name, e);
            }
        }

        private void WriteConstants(BindStreamWriter sw, IEnumerable<Constant> constants)
        {
            // Make sure everything is sorted. This will avoid random changes between
            // consecutive runs of the program.
            constants = constants.OrderBy(c => c).ToList();

            foreach (var c in constants)
            {
                if (c != constants.First())
                {
                    sw.WriteLine();
                }

                if (!Settings.IsEnabled(Settings.Legacy.NoDocumentation))
                {
                    sw.WriteLine("/// <summary>");
                    sw.WriteLine("/// Original was " + Settings.ConstantPrefix + c.OriginalName + " = " + c.Value);
                    sw.WriteLine("/// </summary>");
                }

                string valueString;
                if (string.IsNullOrEmpty(c.Reference))
                {
                    // This enum has a value
                    valueString = c.Value;
                }
                else
                {
                    // The enum is a reference to another enum
                    valueString = $"{c.Reference}{Settings.NamespaceSeparator}{c.Value}";
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
            }
        }

        private void WriteEnums(BindStreamWriter sw, EnumCollection enums, FunctionCollection wrappers)
        {
            //sw.WriteLine("#pragma warning disable 1591");   // Missing doc comments
            //sw.WriteLine();

            if ((Settings.Compatibility & Settings.Legacy.NestedEnums) != Settings.Legacy.None)
            {
                Trace.WriteLine(
                    $"Writing enums to:\t{Settings.OutputNamespace}.{Settings.OutputClass}.{Settings.NestedEnumsClass}");
            }
            else
            {
                Trace.WriteLine($"Writing enums to:\t{Settings.EnumsOutput}");
            }

            if ((Settings.Compatibility & Settings.Legacy.ConstIntEnums) == Settings.Legacy.None)
            {
                if ((Settings.Compatibility & Settings.Legacy.NestedEnums) != Settings.Legacy.None &&
                    !string.IsNullOrEmpty(Settings.NestedEnumsClass))
                {
                    sw.WriteLine("public class Enums");
                    sw.WriteLine("{");
                    sw.Indent();
                }

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
                    if (!Settings.IsEnabled(Settings.Legacy.NoDocumentation))
                    {
                        // Document which functions use this enum.
                        var functions = enumCounts[@enum]
                            .Select(w =>
                                Settings.GLClass + (w.Extension != "Core" ? "." + w.Extension : "") + "." +
                                w.TrimmedName)
                            .Distinct();

                        sw.WriteLine("/// <summary>");
                        sw.WriteLine(
                            $"/// {(functions.Count() >= 3 ? $"Used in {string.Join(", ", functions.Take(2).ToArray())} and {functions.Count() - 2} other function{(functions.Count() - 2 > 1 ? "s" : "")}" : functions.Count() >= 1 ? $"Used in {string.Join(", ", functions.ToArray())}" : "Not used directly.")}");
                        sw.WriteLine("/// </summary>");
                    }

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
                    sw.WriteLine("{");
                    sw.Indent();
                    WriteConstants(sw, @enum.ConstantCollection.Values);
                    sw.Unindent();
                    sw.WriteLine("}");
                    sw.WriteLine();
                }

                if ((Settings.Compatibility & Settings.Legacy.NestedEnums) == Settings.Legacy.None ||
                    string.IsNullOrEmpty(Settings.NestedEnumsClass))
                {
                    return;
                }

                sw.Unindent();
                sw.WriteLine("}");
            }
            else
            {
                // Tao legacy mode: dump all enums as constants in GLClass.
                foreach (var c in enums[Settings.CompleteEnumName].ConstantCollection.Values)
                {
                    // Print constants avoiding circular definitions
                    if (c.Name != c.Value)
                    {
                        sw.WriteLine(string.Format(
                            "public const int {0} = {2}((int){1});",
                            c.Name.StartsWith(Settings.ConstantPrefix) ? c.Name : Settings.ConstantPrefix + c.Name,
                            char.IsDigit(c.Value[0]) ? c.Value :
                            c.Value.StartsWith(Settings.ConstantPrefix) ? c.Value : Settings.ConstantPrefix + c.Value,
                            c.Unchecked ? "unchecked" : ""));
                    }
                }
            }
        }

        public void WriteLicense(BindStreamWriter sw)
        {
            sw.WriteLine(File.ReadAllText(Path.Combine(Settings.InputPath, Settings.LicenseFile)));
            sw.WriteLine();
        }

        private string GetDeclarationString(Delegate d, bool isDelegate)
        {
            var sb = new StringBuilder();

            sb.Append(d.Unsafe ? "unsafe " : "");
            if (isDelegate)
            {
                sb.Append("delegate ");
            }

            sb.Append(GetDeclarationString(d.ReturnType, Settings.Legacy.ConstIntEnums));
            sb.Append(" ");
            sb.Append(Settings.FunctionPrefix);
            sb.Append(d.Name);
            sb.Append(GetDeclarationString(d.Parameters, Settings.Legacy.ConstIntEnums));

            return sb.ToString();
        }

        private string GetDeclarationString(Function f, Settings.Legacy settings)
        {
            var sb = new StringBuilder();

            sb.Append(f.Unsafe ? "unsafe " : "");
            sb.Append(GetDeclarationString(f.ReturnType, settings));
            sb.Append(" ");
            if ((Settings.Compatibility & Settings.Legacy.NoTrimFunctionEnding) != Settings.Legacy.None)
            {
                sb.Append(Settings.FunctionPrefix);
            }

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

            sb.Append(GetDeclarationString(f.Parameters, settings));

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

        private string GetDeclarationString(Parameter p, bool overrideUnsafeSetting, Settings.Legacy settings)
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
                int count;
                if (int.TryParse(p.ComputeSize, out count))
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

            if (!overrideUnsafeSetting && (Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) !=
                Settings.Legacy.None)
            {
                if (p.Pointer != 0)
                {
                    sb.Append("IntPtr");
                }
                else
                {
                    sb.Append(GetDeclarationString(p, settings));
                }
            }
            else
            {
                sb.Append(GetDeclarationString(p, settings));
            }

            if (!string.IsNullOrEmpty(p.Name))
            {
                sb.Append(" ");
                sb.Append(p.Name);
            }

            return sb.ToString();
        }

        private string GetDeclarationString(ParameterCollection parameters, Settings.Legacy settings)
        {
            var sb = new StringBuilder();

            sb.Append("(");
            if (parameters.Count > 0)
            {
                foreach (var p in parameters)
                {
                    sb.Append(GetDeclarationString(p, false, settings));
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

        private string GetDeclarationString(Type type, Settings.Legacy settings)
        {
            var t = GetQualifiedTypeOrAlias(type);
            if ((settings & Settings.Legacy.ConstIntEnums) != 0)
            {
                if (type.IsEnum)
                {
                    t = "int";
                }
            }

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
