#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Bind.Structures;

namespace Bind
{
    using Delegate = Bind.Structures.Delegate;
    using Enum = Bind.Structures.Enum;
    using Type = Bind.Structures.Type;

    sealed class CSharpSpecWriter : ISpecWriter
    {
        IBind Generator { get; set; }
        Settings Settings { get { return Generator.Settings; } }

        #region ISpecWriter Members

        public void WriteBindings(IBind generator)
        {
            Generator = generator;
            WriteBindings(generator.Delegates, generator.Wrappers, generator.Enums);
        }

        #endregion

        #region Private Members

        private static void ConsoleRewrite(string text)
        {
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            Console.Write(text);
            for (int i = text.Length; i < 80; i++)
                Console.Write(" ");
            Console.WriteLine();
            Console.SetCursorPosition(left, top);
        }

        #region WriteBindings

        void WriteBindings(DelegateCollection delegates, FunctionCollection wrappers, EnumCollection enums)
        {
            Console.WriteLine("Writing bindings to {0}", Settings.OutputPath);
            if (!Directory.Exists(Settings.OutputPath))
                Directory.CreateDirectory(Settings.OutputPath);

            string temp_enums_file = Path.GetTempFileName();
            string temp_wrappers_file = Path.GetTempFileName();

            // Enums
            using (BindStreamWriter sw = new BindStreamWriter(temp_enums_file))
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
                    sw.WriteLine("namespace {0}", Settings.EnumsOutput);

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
            using (BindStreamWriter sw = new BindStreamWriter(temp_wrappers_file))
            {
                WriteLicense(sw);
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");
                sw.Indent();

                sw.WriteLine("using System;");
                sw.WriteLine("using System.Text;");
                sw.WriteLine("using System.Runtime.InteropServices;");

                WriteWrappers(sw, wrappers, delegates, enums, Generator.CSTypes);

                sw.Unindent();
                sw.WriteLine("}");
            }

            string output_enums = Path.Combine(Settings.OutputPath, Settings.EnumsFile);
            string output_delegates = Path.Combine(Settings.OutputPath, Settings.DelegatesFile);
            string output_core = Path.Combine(Settings.OutputPath, Settings.ImportsFile);
            string output_wrappers = Path.Combine(Settings.OutputPath, Settings.WrappersFile);

            if (File.Exists(output_enums)) File.Delete(output_enums);
            if (File.Exists(output_delegates)) File.Delete(output_delegates);
            if (File.Exists(output_core)) File.Delete(output_core);
            if (File.Exists(output_wrappers)) File.Delete(output_wrappers);

            File.Move(temp_enums_file, output_enums);
            File.Move(temp_wrappers_file, output_wrappers);
        }

        #endregion

        #region WriteWrappers

        void WriteWrappers(BindStreamWriter sw, FunctionCollection wrappers,
            DelegateCollection delegates, EnumCollection enums,
            IDictionary<string, string> CSTypes)
        {
            Trace.WriteLine(String.Format("Writing wrappers to:\t{0}.{1}", Settings.OutputNamespace, Settings.OutputClass));

            sw.WriteLine("#pragma warning disable 3019"); // CLSCompliant attribute
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
                    sw.WriteLine("{0}, 0,", String.Join(", ",
                        System.Text.Encoding.ASCII.GetBytes(name).Select(b => b.ToString()).ToArray()));
                }
            }
            sw.Unindent();
            sw.WriteLine("};");
            // Write entry point name offsets.
            // This is an array of offsets into the EntryPointNames[] array above.
            sw.WriteLine("EntryPointNameOffsets = new int[]", delegates.Count);
            sw.WriteLine("{");
            sw.Indent();
            int offset = 0;
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

            int current_wrapper = 0;
            foreach (string key in wrappers.Keys)
            {
                if (((Settings.Compatibility & Settings.Legacy.NoSeparateFunctionNamespaces) == Settings.Legacy.None) && key != "Core")
                {
                    if (!Char.IsDigit(key[0]))
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
                foreach (Function f in wrappers[key])
                {
                    WriteWrapper(sw, f, enums);
                    current_wrapper++;
                }

                if (((Settings.Compatibility & Settings.Legacy.NoSeparateFunctionNamespaces) == Settings.Legacy.None) && key != "Core")
                {
                    sw.Unindent();
                    sw.WriteLine("}");
                    sw.WriteLine();
                }
            }

            // Emit native signatures.
            // These are required by the patcher.
            int current_signature = 0;
            foreach (var d in wrappers.Values.SelectMany(e => e).Select(w => w.WrappedDelegate).Distinct())
            {
                sw.WriteLine("[Slot({0})]", d.Slot);
                sw.WriteLine("[DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]");
                sw.WriteLine("static extern {0};", GetDeclarationString(d, false));
                current_signature++;
            }

            sw.Unindent();
            sw.WriteLine("}");

            Console.WriteLine("Wrote {0} wrappers for {1} signatures", current_wrapper, current_signature);
        }

        void WriteWrapper(BindStreamWriter sw, Function f, EnumCollection enums)
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
            if (!String.IsNullOrEmpty(f.Obsolete))
            {
                sw.WriteLine("[Obsolete(\"{0}\")]", f.Obsolete);
            }
            else if (f.Deprecated && Settings.IsEnabled(Settings.Legacy.AddDeprecationWarnings))
            {
                sw.WriteLine("[Obsolete(\"Deprecated in OpenGL {0}\")]", f.DeprecatedVersion);
            }

            sw.WriteLine("[AutoGenerated(Category = \"{0}\", Version = \"{1}\", EntryPoint = \"{2}\")]",
                f.Category, f.Version, Settings.FunctionPrefix + f.WrappedDelegate.EntryPoint);

            if (!f.CLSCompliant)
            {
                sw.WriteLine("[CLSCompliant(false)]");
            }

            sw.WriteLine("public static {0} {{ throw new NotImplementedException(); }}", GetDeclarationString(f, Settings.Compatibility));
        }

        void WriteDocumentation(BindStreamWriter sw, Function f)
        {
            var docs = f.Documentation;

            try
            {
                string warning = String.Empty;
                string category = String.Empty;
                if (f.Deprecated)
                {
                    warning = String.Format("[deprecated: v{0}]", f.DeprecatedVersion);
                }

                if (f.Extension != "Core" && !String.IsNullOrEmpty(f.Category))
                {
                    category = String.Format("[requires: {0}]", f.Category);
                }
                else if (!String.IsNullOrEmpty(f.Version))
                {
                    if (f.Category.StartsWith("VERSION"))
                        category = String.Format("[requires: {0}]", "v" + f.Version);
                    else
                        category = String.Format("[requires: {0}]", "v" + f.Version + " or " + f.Category);
                }

                // Write function summary
                sw.Write("/// <summary>");
                if (!String.IsNullOrEmpty(category) || !String.IsNullOrEmpty(warning))
                {
                    sw.Write(WriteOptions.NoIndent, "{0}{1}", category, warning);
                }
                if (!String.IsNullOrEmpty(docs.Summary))
                {
                    sw.WriteLine();
                    sw.WriteLine("/// {0}", docs.Summary);
                    sw.WriteLine("/// </summary>");
                }
                else
                {
                    sw.WriteLine(WriteOptions.NoIndent, "</summary>");
                }

                // Write function parameters
                for (int i = 0; i < f.Parameters.Count; i++)
                {
                    var param = f.Parameters[i];

                    string length = String.Empty;
                    if (!String.IsNullOrEmpty(param.ComputeSize))
                    {
                        length = String.Format("[length: {0}]", param.ComputeSize);
                    }

                    // Try to match the correct parameter from documentation:
                    // - first by name
                    // - then by index
                    var docparam =
                        (docs.Parameters
                            .Where(p => p.Name == param.RawName)
                            .FirstOrDefault()) ??
                        (docs.Parameters.Count > i ?
                            docs.Parameters[i] : null);

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
                        sw.Write("/// <param name=\"{0}\">", param.Name);
                        if (!String.IsNullOrEmpty(length))
                        {
                            sw.Write(WriteOptions.NoIndent, "{0}", length);
                        }
                        if (!String.IsNullOrEmpty(docparam.Documentation))
                        {
                            sw.WriteLine(WriteOptions.NoIndent, " ");
                            sw.WriteLine("/// {0}", docparam.Documentation);
                            sw.WriteLine("/// </param>");
                        }
                        else
                        {
                            sw.WriteLine(WriteOptions.NoIndent, "</param>");
                        }
                    }
                    else
                    {
                        Console.Error.WriteLine(
                            "[Warning] Parameter '{0}' in function '{1}' not found in documentation '{{{2}}}'",
                            param.Name, f.Name,
                            String.Join(",", docs.Parameters.Select(p => p.Name).ToArray()));
                        sw.WriteLine("/// <param name=\"{0}\">{1}</param>",
                            param.Name, length);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("[Warning] Error documenting function {0}: {1}", f.WrappedDelegate.Name, e.ToString());
            }   
        }

        #endregion

        #region WriteTypes

        public void WriteTypes(BindStreamWriter sw, Dictionary<string, string> CSTypes)
        {
            sw.WriteLine();
            foreach (string s in CSTypes.Keys)
            {
                sw.WriteLine("using {0} = System.{1};", s, CSTypes[s]);
            }
        }

        #endregion

        #region WriteConstants

        void WriteConstants(BindStreamWriter sw, IEnumerable<Constant> constants)
        {
             // Make sure everything is sorted. This will avoid random changes between
            // consecutive runs of the program.
            constants = constants.OrderBy(c => c);

            foreach (var c in constants)
            {
                if (!Settings.IsEnabled(Settings.Legacy.NoDocumentation))
                {
                    sw.WriteLine("/// <summary>");
                    sw.WriteLine("/// Original was " + Settings.ConstantPrefix + c.OriginalName + " = " + c.Value);
                    sw.WriteLine("/// </summary>");
                }

                var str = String.Format("{0} = {1}((int){2}{3})", c.Name, c.Unchecked ? "unchecked" : "",
                    !String.IsNullOrEmpty(c.Reference) ? c.Reference + Settings.NamespaceSeparator : "", c.Value);

                sw.Write(str);
                if (!String.IsNullOrEmpty(str))
                    sw.WriteLine(",");
            }
        }

        #endregion

        #region WriteEnums

        void WriteEnums(BindStreamWriter sw, EnumCollection enums, FunctionCollection wrappers)
        {
            //sw.WriteLine("#pragma warning disable 3019");   // CLSCompliant attribute
            //sw.WriteLine("#pragma warning disable 1591");   // Missing doc comments
            //sw.WriteLine();

            if ((Settings.Compatibility & Settings.Legacy.NestedEnums) != Settings.Legacy.None)
                Trace.WriteLine(String.Format("Writing enums to:\t{0}.{1}.{2}", Settings.OutputNamespace, Settings.OutputClass, Settings.NestedEnumsClass));
            else
                Trace.WriteLine(String.Format("Writing enums to:\t{0}", Settings.EnumsOutput));

            if ((Settings.Compatibility & Settings.Legacy.ConstIntEnums) == Settings.Legacy.None)
            {
                if ((Settings.Compatibility & Settings.Legacy.NestedEnums) != Settings.Legacy.None &&
                    !String.IsNullOrEmpty(Settings.NestedEnumsClass))
                {
                    sw.WriteLine("public class Enums");
                    sw.WriteLine("{");
                    sw.Indent();
                }

                // Build a dictionary of which functions use which enums
                var enum_counts = new Dictionary<Enum, List<Function>>();
                foreach (var e in enums.Values)
                {
                    // Initialize the dictionary
                    enum_counts.Add(e, new List<Function>());
                }
                foreach (var wrapper in wrappers.Values.SelectMany(w => w))
                {
                    // Add every function to every enum parameter it references
                    foreach (var parameter in wrapper.Parameters.Where(p => p.IsEnum))
                    {
                        var e = enums[parameter.CurrentType];
                        var list = enum_counts[e];
                        list.Add(wrapper);
                    }
                }

                foreach (Enum @enum in enums.Values)
                {
                    if (!Settings.IsEnabled(Settings.Legacy.NoDocumentation))
                    {
                        // Document which functions use this enum.
                        var functions = enum_counts[@enum]
                            .Select(w => Settings.GLClass + (w.Extension != "Core" ? ("." + w.Extension) : "") + "." + w.TrimmedName)
                            .Distinct();

                        sw.WriteLine("/// <summary>");
                        sw.WriteLine(String.Format("/// {0}",
                            functions.Count() >= 3 ?
                                String.Format("Used in {0} and {1} other function{2}",
                                    String.Join(", ", functions.Take(2).ToArray()),
                                    functions.Count() - 2,
                                    functions.Count() - 2 > 1 ? "s" : "") :
                            functions.Count() >= 1 ?
                                String.Format("Used in {0}",
                                    String.Join(", ", functions.ToArray())) :
                                "Not used directly."));
                        sw.WriteLine("/// </summary>");
                    }

                    if (@enum.IsObsolete)
                        sw.WriteLine("[Obsolete(\"{0}\")]", @enum.Obsolete);
                    if (!@enum.CLSCompliant)
                        sw.WriteLine("[CLSCompliant(false)]");
                    if (@enum.IsFlagCollection)
                        sw.WriteLine("[Flags]");
                    sw.WriteLine("public enum " + @enum.Name + " : " + @enum.Type);
                    sw.WriteLine("{");
                    sw.Indent();
                    WriteConstants(sw, @enum.ConstantCollection.Values);
                    sw.Unindent();
                    sw.WriteLine("}");
                    sw.WriteLine();
                }

                if ((Settings.Compatibility & Settings.Legacy.NestedEnums) != Settings.Legacy.None &&
                    !String.IsNullOrEmpty(Settings.NestedEnumsClass))
                {
                    sw.Unindent();
                    sw.WriteLine("}");
                }
            }
            else
            {
                // Tao legacy mode: dump all enums as constants in GLClass.
                foreach (Constant c in enums[Settings.CompleteEnumName].ConstantCollection.Values)
                {
                    // Print constants avoiding circular definitions
                    if (c.Name != c.Value)
                    {
                        sw.WriteLine(String.Format(
                            "public const int {0} = {2}((int){1});",
                            c.Name.StartsWith(Settings.ConstantPrefix) ? c.Name : Settings.ConstantPrefix + c.Name,
                            Char.IsDigit(c.Value[0]) ? c.Value : c.Value.StartsWith(Settings.ConstantPrefix) ? c.Value : Settings.ConstantPrefix + c.Value,
                            c.Unchecked ? "unchecked" : ""));
                    }
                    else
                    {
                    }
                }
            }
        }

        #endregion

        #region WriteLicense

        public void WriteLicense(BindStreamWriter sw)
        {
            sw.WriteLine(File.ReadAllText(Path.Combine(Settings.InputPath, Settings.LicenseFile)));
            sw.WriteLine();
        }

        #endregion

        // For example, if parameter foo has indirection level = 1, then it
        // is consumed as 'foo*' in the fixed_statements and the call string.
        readonly static string[] pointer_levels = new string[] { "", "*", "**", "***", "****" };
        readonly static string[] array_levels = new string[] { "", "[]", "[,]", "[,,]", "[,,,]" };

        static bool IsEnum(string s, EnumCollection enums)
        {
            return enums.ContainsKey(s);
        }

        string GetDeclarationString(Constant c)
        {
            if (String.IsNullOrEmpty(c.Name))
            {
                throw new InvalidOperationException("Invalid Constant: Name is empty");
            }

            return String.Format("{0} = {1}((int){2}{3})",
                c.Name,
                c.Unchecked ? "unchecked" : String.Empty,
                !String.IsNullOrEmpty(c.Reference) ?
                    c.Reference + Settings.NamespaceSeparator :
                    String.Empty,
                c.Value);
        }

        string GetDeclarationString(Delegate d, bool is_delegate)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(d.Unsafe ? "unsafe " : "");
            if (is_delegate)
                sb.Append("delegate ");
            sb.Append(GetDeclarationString(d.ReturnType, Settings.Legacy.ConstIntEnums));
            sb.Append(" ");
            sb.Append(Settings.FunctionPrefix);
            sb.Append(d.Name);
            sb.Append(GetDeclarationString(d.Parameters, Settings.Legacy.ConstIntEnums));

            return sb.ToString();
        }

        string GetDeclarationString(Enum e)
        {
            StringBuilder sb = new StringBuilder();
            List<Constant> constants = new List<Constant>(e.ConstantCollection.Values);
            constants.Sort(delegate(Constant c1, Constant c2)
            {
                int ret = String.Compare(c1.Value, c2.Value);
                if (ret == 0)
                    return String.Compare(c1.Name, c2.Name);
                return ret;
            });

            if (e.IsFlagCollection)
                sb.AppendLine("[Flags]");
            sb.Append("public enum ");
            sb.Append(e.Name);
            sb.Append(" : ");
            sb.AppendLine(e.Type);
            sb.AppendLine("{");

            foreach (Constant c in constants)
            {
                var declaration = GetDeclarationString(c);
                sb.Append("    ");
                sb.Append(declaration);
                if (!String.IsNullOrEmpty(declaration))
                    sb.AppendLine(",");
            }
            sb.Append("}");

            return sb.ToString();
        }

        string GetDeclarationString(Function f, Settings.Legacy settings)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(f.Unsafe ? "unsafe " : "");
            sb.Append(GetDeclarationString(f.ReturnType, settings));
            sb.Append(" ");
            if ((Settings.Compatibility & Settings.Legacy.NoTrimFunctionEnding) != Settings.Legacy.None)
            {
                sb.Append(Settings.FunctionPrefix);
            }
            sb.Append(!String.IsNullOrEmpty(f.TrimmedName) ? f.TrimmedName : f.Name);

            if (f.Parameters.HasGenericParameters)
            {
                sb.Append("<");
                foreach (Parameter p in f.Parameters)
                {
                    if (p.Generic)
                    {
                        sb.Append(p.CurrentType);
                        sb.Append(",");
                    }
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append(">");
            }

            sb.Append(GetDeclarationString(f.Parameters, settings));

            if (f.Parameters.HasGenericParameters)
            {
                sb.AppendLine();
                foreach (Parameter p in f.Parameters)
                {
                    if (p.Generic)
                        sb.AppendLine(String.Format("    where {0} : struct", p.CurrentType));
                }
            }

            return sb.ToString();
        }

        string GetDeclarationString(Parameter p, bool override_unsafe_setting, Settings.Legacy settings)
        {
            StringBuilder sb = new StringBuilder();

            if (p.Flow == FlowDirection.Out)
                sb.Append("[OutAttribute] ");
            else if (p.Flow == FlowDirection.Undefined)
                sb.Append("[InAttribute, OutAttribute] ");

            if (p.Reference)
            {
                if (p.Flow == FlowDirection.Out)
                    sb.Append("out ");
                else
                    sb.Append("ref ");
            }

            if (!override_unsafe_setting && ((Settings.Compatibility & Settings.Legacy.NoPublicUnsafeFunctions) != Settings.Legacy.None))
            {
                if (p.Pointer != 0)
                {
                    sb.Append("IntPtr");
                }
                else
                {
                    sb.Append(GetDeclarationString(p as Type, settings));
                }
            }
            else
            {
                sb.Append(GetDeclarationString(p as Type, settings));
            }
            if (!String.IsNullOrEmpty(p.Name))
            {
                sb.Append(" ");
                sb.Append(p.Name);
            }

            return sb.ToString();
        }

        string GetDeclarationString(ParameterCollection parameters, Settings.Legacy settings)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("(");
            if (parameters.Count > 0)
            {
                foreach (Parameter p in parameters)
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

        string GetDeclarationString(Type type, Settings.Legacy settings)
        {
            var t = type.QualifiedType;
            if ((settings & Settings.Legacy.ConstIntEnums) != 0)
            {
                if (type.IsEnum)
                {
                    t = "System.Int32";
                }
            }

            return String.Format("{0}{1}{2}",
                t,
                pointer_levels[type.Pointer],
                array_levels[type.Array]);
        }

        #endregion
    }
}
