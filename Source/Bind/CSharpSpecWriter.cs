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
        readonly char[] numbers = "0123456789".ToCharArray();

        #region WriteBindings

        public void WriteBindings(IBind generator)
        {
            WriteBindings(generator.Delegates, generator.Wrappers, generator.Enums);
        }

        void WriteBindings(DelegateCollection delegates, FunctionCollection wrappers, EnumCollection enums)
        {
            Console.WriteLine("Writing bindings to {0}", Settings.OutputPath);
            if (!Directory.Exists(Settings.OutputPath))
                Directory.CreateDirectory(Settings.OutputPath);

            string temp_enums_file = Path.GetTempFileName();
            string temp_delegates_file = Path.GetTempFileName();
            string temp_core_file = Path.GetTempFileName();
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

            // Delegates
            using (BindStreamWriter sw = new BindStreamWriter(temp_delegates_file))
            {
                WriteLicense(sw);
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");
                sw.Indent();

                sw.WriteLine("using System;");
                sw.WriteLine("using System.Text;");
                sw.WriteLine("using System.Runtime.InteropServices;");

                sw.WriteLine("#pragma warning disable 0649");
                WriteDelegates(sw, delegates);

                sw.Unindent();
                sw.WriteLine("}");
            }

            // Core
            using (BindStreamWriter sw = new BindStreamWriter(temp_core_file))
            {
                WriteLicense(sw);
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");
                sw.Indent();
                //specWriter.WriteTypes(sw, Bind.Structures.Type.CSTypes);
                sw.WriteLine("using System;");
                sw.WriteLine("using System.Text;");
                sw.WriteLine("using System.Runtime.InteropServices;");

                WriteImports(sw, delegates);

                sw.Unindent();
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

                WriteWrappers(sw, wrappers, Type.CSTypes);

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
            File.Move(temp_delegates_file, output_delegates);
            File.Move(temp_core_file, output_core);
            File.Move(temp_wrappers_file, output_wrappers);
        }

        #endregion

        #region WriteDelegates

        void WriteDelegates(BindStreamWriter sw, DelegateCollection delegates)
        {
            Trace.WriteLine(String.Format("Writing delegates to:\t{0}.{1}.{2}", Settings.OutputNamespace, Settings.OutputClass, Settings.DelegatesClass));

            sw.WriteLine("#pragma warning disable 3019");   // CLSCompliant attribute
            sw.WriteLine("#pragma warning disable 1591");   // Missing doc comments

            sw.WriteLine();
            sw.WriteLine("partial class {0}", Settings.OutputClass);
            sw.WriteLine("{");
            sw.Indent();

            sw.WriteLine("internal static partial class {0}", Settings.DelegatesClass);
            sw.WriteLine("{");
            sw.Indent();

            foreach (Delegate d in delegates.Values)
            {
                sw.WriteLine("[System.Security.SuppressUnmanagedCodeSecurity()]");
                sw.WriteLine("internal {0};", d.ToString());
                sw.WriteLine("internal {0}static {1} {2}{1};",   //  = null
                    d.Unsafe ? "unsafe " : "",
                    d.Name,
                    Settings.FunctionPrefix);
            }

            sw.Unindent();
            sw.WriteLine("}");

            sw.Unindent();
            sw.WriteLine("}");
        }

        #endregion

        #region WriteImports

        public void WriteImports(BindStreamWriter sw, DelegateCollection delegates)
        {
            Trace.WriteLine(String.Format("Writing imports to:\t{0}.{1}.{2}", Settings.OutputNamespace, Settings.OutputClass, Settings.ImportsClass));

            sw.WriteLine("#pragma warning disable 3019");   // CLSCompliant attribute
            sw.WriteLine("#pragma warning disable 1591");   // Missing doc comments

            sw.WriteLine();
            sw.WriteLine("partial class {0}", Settings.OutputClass);
            sw.WriteLine("{");
            sw.Indent();
            sw.WriteLine();
            sw.WriteLine("internal static partial class {0}", Settings.ImportsClass);
            sw.WriteLine("{");
            sw.Indent();
            //sw.WriteLine("static {0}() {1} {2}", Settings.ImportsClass, "{", "}");    // Disable BeforeFieldInit
            sw.WriteLine();
            foreach (Delegate d in delegates.Values)
            {
                sw.WriteLine("[System.Security.SuppressUnmanagedCodeSecurity()]");
                sw.WriteLine(
                    "[System.Runtime.InteropServices.DllImport({0}.Library, EntryPoint = \"{1}{2}\"{3})]",
                    Settings.OutputClass,
                    Settings.FunctionPrefix,
                    d.Name,
                    d.Name.EndsWith("W") || d.Name.EndsWith("A") ? ", CharSet = CharSet.Auto" : ", ExactSpelling = true"
                );
                sw.WriteLine("internal extern static {0};", d.DeclarationString());
            }
            sw.Unindent();
            sw.WriteLine("}");
            sw.Unindent();
            sw.WriteLine("}");
        }

        #endregion

        #region WriteWrappers

        public void WriteWrappers(BindStreamWriter sw, FunctionCollection wrappers, Dictionary<string, string> CSTypes)
        {
            Trace.WriteLine(String.Format("Writing wrappers to:\t{0}.{1}", Settings.OutputNamespace, Settings.OutputClass));

            sw.WriteLine("#pragma warning disable 3019");   // CLSCompliant attribute
            sw.WriteLine("#pragma warning disable 1591");   // Missing doc comments
            sw.WriteLine("#pragma warning disable 1572");   // Wrong param comments
            sw.WriteLine("#pragma warning disable 1573");   // Missing param comments

            sw.WriteLine();
            sw.WriteLine("partial class {0}", Settings.OutputClass);
            sw.WriteLine("{");

            sw.Indent();
            //sw.WriteLine("static {0}() {1} {2}", className, "{", "}");    // Static init in GLHelper.cs
            sw.WriteLine();

            int current = 0;
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
                    current = WriteWrapper(sw, current, f);
                }

                if (((Settings.Compatibility & Settings.Legacy.NoSeparateFunctionNamespaces) == Settings.Legacy.None) && key != "Core")
                {
                    sw.Unindent();
                    sw.WriteLine("}");
                    sw.WriteLine();
                }
            }
            sw.Unindent();
            sw.WriteLine("}");
        }

        int WriteWrapper(BindStreamWriter sw, int current, Function f)
        {
            if ((Settings.Compatibility & Settings.Legacy.NoDocumentation) == 0)
            {
                Console.WriteLine("Creating docs for #{0} ({1})", current++, f.Name);
                WriteDocumentation(sw, f);
            }
            WriteMethod(sw, f);
            return current;
        }

        private static void WriteMethod(BindStreamWriter sw, Function f)
        {
            if (f.Deprecated && Settings.IsEnabled(Settings.Legacy.AddDeprecationWarnings))
            {
                sw.WriteLine("[Obsolete(\"Deprecated in OpenGL {0}\")]", f.DeprecatedVersion);
            }

            if (!f.CLSCompliant)
            {
                sw.WriteLine("[System.CLSCompliant(false)]");
            }

            sw.WriteLine("[AutoGenerated(Category = \"{0}\", Version = \"{1}\", EntryPoint = \"{2}\")]",
                f.Category, f.Version, Settings.FunctionPrefix + f.WrappedDelegate.Name);
            sw.WriteLine("public static ");
            sw.Write(f);
            sw.WriteLine();
        }

        static DocProcessor processor = new DocProcessor(Path.Combine(Settings.DocPath, Settings.DocFile));
        static Dictionary<string, string> docfiles;
        void WriteDocumentation(BindStreamWriter sw, Function f)
        {
            if (docfiles == null)
            {
                docfiles = new Dictionary<string, string>();
                foreach (string file in Directory.GetFiles(Settings.DocPath))
                {
                    docfiles.Add(Path.GetFileName(file), file);
                }
            }

            string docfile = null;
            try
            {
                docfile = Settings.FunctionPrefix + f.WrappedDelegate.Name + ".xml";
                if (!docfiles.ContainsKey(docfile))
                    docfile = Settings.FunctionPrefix + f.TrimmedName + ".xml";
                if (!docfiles.ContainsKey(docfile))
                    docfile = Settings.FunctionPrefix + f.TrimmedName.TrimEnd(numbers) + ".xml";

                string doc = null;
                if (docfiles.ContainsKey(docfile))
                {
                    doc = processor.ProcessFile(docfiles[docfile]);
                }
                if (doc == null)
                {
                    doc = "/// <summary></summary>";
                }

                int summary_start = doc.IndexOf("<summary>") + "<summary>".Length;
                string warning = "[deprecated: v{0}]";
                string category = "[requires: {0}]";
                if (f.Deprecated)
                {
                    warning = String.Format(warning, f.DeprecatedVersion);
                    doc = doc.Insert(summary_start, warning);
                }

                if (f.Extension != "Core" && !String.IsNullOrEmpty(f.Category))
                {
                    category = String.Format(category, f.Category);
                    doc = doc.Insert(summary_start, category);
                }
                else if (!String.IsNullOrEmpty(f.Version))
                {
                    if (f.Category.StartsWith("VERSION"))
                        category = String.Format(category, "v" + f.Version);
                    else
                        category = String.Format(category, "v" + f.Version + " and " + f.Category);
                    doc = doc.Insert(summary_start, category);
                }

                sw.WriteLine(doc);
            }
            catch (Exception e)
            {
                Console.WriteLine("[Warning] Error processing file {0}: {1}", docfile, e.ToString());
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

                foreach (Enum @enum in enums.Values)
                {
                    if (!Settings.IsEnabled(Settings.Legacy.NoDocumentation))
                    {
                        // Document which functions use this enum.
                        var functions =
                            (from wrapper in wrappers
                            from function in wrapper.Value
                            from param in function.Parameters
                            where param.CurrentType == @enum.Name
                            select Settings.GLClass + (function.Extension != "Core" ? ("." + function.Extension) : "") + "." + function.TrimmedName)
                            .Distinct();

                        sw.WriteLine("/// <summary>");
                        sw.WriteLine(String.Format("/// {0}", functions.Count() > 0 ?
                            ("Used in " + String.Join(", ", functions.ToArray())) : "Not used directly."));
                        sw.WriteLine("/// </summary>");
                    }

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
    }
}
