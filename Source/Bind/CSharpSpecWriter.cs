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

                WriteWrappers(sw, wrappers, enums, Generator.CSTypes);

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

            foreach (var overloads in delegates.Values)
            {
                // Generate only one delegate per entry point..
                // Overloads are only used for wrapper generation,
                // so ignore them.
                var d = overloads.First();

                sw.WriteLine("[System.Security.SuppressUnmanagedCodeSecurity()]");
                sw.WriteLine("internal {0};", GetDeclarationString(d, true));
                sw.WriteLine("internal {0}static {2} {1}{2};",   //  = null
                         d.Unsafe ? "unsafe " : "",
                         Settings.FunctionPrefix,
                         d.Name);
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
            foreach (var overloads in delegates.Values)
            {
                var d = overloads.First(); // generate only 1 DllImport per entry point
                sw.WriteLine("[System.Security.SuppressUnmanagedCodeSecurity()]");
                sw.WriteLine(
                    "[System.Runtime.InteropServices.DllImport({0}.Library, EntryPoint = \"{1}{2}\"{3})]",
                    Settings.OutputClass,
                    Settings.FunctionPrefix,
                    d.EntryPoint,
                    d.EntryPoint.EndsWith("W") || d.EntryPoint.EndsWith("A") ? ", CharSet = CharSet.Auto" : ", ExactSpelling = true"
                );
                sw.WriteLine("internal extern static {0};", GetDeclarationString(d, false));
            }
            sw.Unindent();
            sw.WriteLine("}");
            sw.Unindent();
            sw.WriteLine("}");
        }

        #endregion

        #region WriteWrappers

        void WriteWrappers(BindStreamWriter sw, FunctionCollection wrappers, EnumCollection enums, IDictionary<string, string> CSTypes)
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
                    current = WriteWrapper(sw, current, f, enums);
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

        int WriteWrapper(BindStreamWriter sw, int current, Function f, EnumCollection enums)
        {
            if ((Settings.Compatibility & Settings.Legacy.NoDocumentation) == 0)
            {
                string text = String.Format("Writing function #{0}: {1}", current++, f.ToString());
                ConsoleRewrite(text);

                WriteDocumentation(sw, f);
            }
            WriteMethod(sw, f, enums);
            sw.WriteLine();
            return current;
        }

        private void WriteMethod(BindStreamWriter sw, Function f, EnumCollection enums)
        {
            CreateBody(f, enums);

            if (!String.IsNullOrEmpty(f.Obsolete))
            {
                sw.WriteLine("[Obsolete(\"{0}\")]", f.Obsolete);
            }
            else if (f.Deprecated && Settings.IsEnabled(Settings.Legacy.AddDeprecationWarnings))
            {
                sw.WriteLine("[Obsolete(\"Deprecated in OpenGL {0}\")]", f.DeprecatedVersion);
            }

            if (!f.CLSCompliant)
            {
                sw.WriteLine("[System.CLSCompliant(false)]");
            }

            sw.WriteLine("[AutoGenerated(Category = \"{0}\", Version = \"{1}\", EntryPoint = \"{2}\")]",
                f.Category, f.Version, Settings.FunctionPrefix + f.WrappedDelegate.EntryPoint);
            sw.WriteLine("public static ");
            sw.Write(GetDeclarationString(f));
            sw.WriteLine();
        }

        DocProcessor processor_;
        DocProcessor Processor
        {
            get
            {
                if (processor_ == null)
                    processor_ = new DocProcessor(Path.Combine(Settings.DocPath, Settings.DocFile));
                return processor_;
            }
        }
        Dictionary<string, string> docfiles;
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

                var docs = new List<string>();
                if (docfiles.ContainsKey(docfile))
                {
                    docs.AddRange(Processor.ProcessFile(docfiles[docfile]));
                }
                if (docs.Count == 0)
                {
                    docs.Add("/// <summary></summary>");
                }

                int summary_start = docs[0].IndexOf("<summary>") + "<summary>".Length;
                string warning = "[deprecated: v{0}]";
                string category = "[requires: {0}]";
                if (f.Deprecated)
                {
                    warning = String.Format(warning, f.DeprecatedVersion);
                    docs[0] = docs[0].Insert(summary_start, warning);
                }

                if (f.Extension != "Core" && !String.IsNullOrEmpty(f.Category))
                {
                    category = String.Format(category, f.Category);
                    docs[0] = docs[0].Insert(summary_start, category);
                }
                else if (!String.IsNullOrEmpty(f.Version))
                {
                    if (f.Category.StartsWith("VERSION"))
                        category = String.Format(category, "v" + f.Version);
                    else
                        category = String.Format(category, "v" + f.Version + " and " + f.Category);
                    docs[0] = docs[0].Insert(summary_start, category);
                }

                foreach (var doc in docs)
                {
                    sw.WriteLine(doc);
                }
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

                int current = 0;
                foreach (Enum @enum in enums.Values)
                {
                    string text = String.Format("Writing enum #{0}: {1}", current++, @enum.Name);
                    ConsoleRewrite(text);

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

        void CreateBody(Function func, EnumCollection enums)
        {
            Function f = new Function(func);
            f.Body.Clear();

            var handle_statements = new List<string>();
            var handle_release_statements = new List<string>();
            var fixed_statements = new List<string>();
            var assign_statements = new List<string>();
            var declaration_statements = new List<string>();

            // Obtain pointers by pinning the parameters
            int index = -1;
            foreach (Parameter p in f.Parameters)
            {
                index++;
                if (p.NeedsPin)
                {
                    if (p.WrapperType == WrapperTypes.GenericParameter)
                    {
                        // Use GCHandle to obtain pointer to generic parameters and 'fixed' for arrays.
                        // This is because fixed can only take the address of fields, not managed objects.
                        handle_statements.Add(String.Format(
                            "{0} {1}_ptr = {0}.Alloc({1}, GCHandleType.Pinned);",
                            "GCHandle", p.Name));

                        handle_release_statements.Add(String.Format("{0}_ptr.Free();", p.Name));

                        // Due to the GCHandle-style pinning (which boxes value types), we need to assign the modified
                        // value back to the reference parameter (but only if it has an out or in/out flow direction).
                        if ((p.Flow == FlowDirection.Out || p.Flow == FlowDirection.Undefined) && p.Reference)
                        {
                            assign_statements.Add(String.Format(
                                "{0} = ({1}){0}_ptr.Target;",
                                p.Name, p.QualifiedType));
                        }
                    }
                    else if (p.WrapperType == WrapperTypes.PointerParameter ||
                        p.WrapperType == WrapperTypes.ArrayParameter ||
                        p.WrapperType == WrapperTypes.ReferenceParameter)
                    {
                        // A fixed statement is issued for all non-generic pointers, arrays and references.
                        fixed_statements.Add(String.Format(
                            "fixed ({0}{3} {1} = {2})",
                            p.QualifiedType,
                            p.Name + "_ptr",
                            p.Array > 0 ? p.Name : "&" + p.Name,
                            pointer_levels[p.IndirectionLevel]));

                        // Arrays are not value types, so we don't need to do anything for them.
                        // Pointers are passed directly by value, so we don't need to assign them back either (they don't change).
                        if ((p.Flow == FlowDirection.Out || p.Flow == FlowDirection.Undefined) && p.Reference)
                        {
                            assign_statements.Add(String.Format("{0} = *{0}_ptr;", p.Name));
                        }
                    }
                    else if (p.WrapperType == WrapperTypes.None)
                    {
                        // do nothing
                    }
                    else
                    {
                        throw new ApplicationException(String.Format(
                            "Unknown wrapper type '{0}', code generation failed",
                            p.WrapperType));
                    }
                }
                else if (p.WrapperType == WrapperTypes.ConvenienceArrayType)
                {
                    var p_array = f.WrappedDelegate.Parameters[f.WrappedDelegate.Parameters.Count - 1];
                    var p_size = f.WrappedDelegate.Parameters[f.WrappedDelegate.Parameters.Count - 2];
                    declaration_statements.Add(String.Format(
                        "const {0} = 1;",
                        GetDeclarationString(p_size, false)));
                    declaration_statements.Add(String.Format("{0}_ptr = ({1})&{2};",
                        GetDeclarationString(p_array, false),
                        GetDeclarationString(p_array as Type),
                        p.Name));
                }

                p.QualifiedType = f.WrappedDelegate.Parameters[index].QualifiedType;
            }

            if (f.ReturnType.WrapperType == WrapperTypes.ConvenienceReturnType ||
                f.ReturnType.WrapperType == WrapperTypes.ConvenienceArrayReturnType)
            {
                var r = f.ReturnType;
                var p = f.WrappedDelegate.Parameters.Last();
                if (r.WrapperType == WrapperTypes.ConvenienceArrayReturnType)
                {
                    var p_size = f.WrappedDelegate.Parameters[f.WrappedDelegate.Parameters.Count - 2];
                    declaration_statements.Add(String.Format(
                        "const {0} = 1;",
                        GetDeclarationString(p_size, false)));
                }
                declaration_statements.Add(String.Format("{0} retval;", GetDeclarationString(r)));
                declaration_statements.Add(String.Format("{0}{2} {1}_ptr = &retval;",
                    GetDeclarationString(r),
                    p.Name,
                    pointer_levels[p.IndirectionLevel]));
            }

            f.Body.Indent();

            // Automatic OpenGL error checking.
            // See OpenTK.Graphics.ErrorHelper for more information.
            // Make sure that no error checking is added to the GetError function,
            // as that would cause infinite recursion!
            if ((Settings.Compatibility & Settings.Legacy.NoDebugHelpers) == 0)
            {
                if (f.TrimmedName != "GetError")
                {
                    f.Body.Add("#if DEBUG");
                    f.Body.Add("using (new ErrorHelper(GraphicsContext.CurrentContext))");
                    f.Body.Add("{");
                    if (f.TrimmedName == "Begin")
                        f.Body.Add("GraphicsContext.CurrentContext.ErrorChecking = false;");
                    f.Body.Add("#endif");
                }
            }

            bool add_unsafe = !f.Unsafe &&
                (fixed_statements.Count > 0 || declaration_statements.Count > 0);
            if (add_unsafe)
            {
                f.Body.Add("unsafe");
                f.Body.Add("{");
                f.Body.Indent();
            }

            if (declaration_statements.Count > 0)
            {
                f.Body.AddRange(declaration_statements);
            } 

            if (fixed_statements.Count > 0)
            {
                f.Body.AddRange(fixed_statements);
                f.Body.Add("{");
                f.Body.Indent();
            }

            if (handle_statements.Count > 0)
            {
                f.Body.AddRange(handle_statements);
                f.Body.Add("try");
                f.Body.Add("{");
                f.Body.Indent();
            }

            // Hack: When creating untyped enum wrappers, it is possible that the wrapper uses an "All"
            // enum, while the delegate uses a specific enum (e.g. "TextureUnit"). For this reason, we need
            // to modify the parameters before generating the call string.
            // Note: We cannot generate a callstring using WrappedDelegate directly, as its parameters will
            // typically be different than the parameters of the wrapper. We need to modify the parameters
            // of the wrapper directly.
            if ((Settings.Compatibility & Settings.Legacy.KeepUntypedEnums) != 0)
            {
                int parameter_index = -1; // Used for comparing wrapper parameters with delegate parameters
                foreach (Parameter p in f.Parameters)
                {
                    parameter_index++;
                    if (IsEnum(p.Name, enums) && p.QualifiedType != f.WrappedDelegate.Parameters[parameter_index].QualifiedType)
                    {
                        p.QualifiedType = f.WrappedDelegate.Parameters[parameter_index].QualifiedType;
                    }
                }
            }

            if (assign_statements.Count > 0)
            {
                // Call function
                var callstring = GetInvocationString(f);
                if (func.Parameters.Any(p => p.WrapperType == WrapperTypes.ConvenienceArrayType))
                {
                    // foo(int id) { foo(1, ref id) }
                    callstring = GetInvocationString(f.WrappedDelegate);
                    f.Body.Add(String.Format("{0}{1};",
                        f.ReturnType.CurrentType.ToLower().Contains("void") ? String.Empty : "return ",
                        callstring));
                }
                else if (f.ReturnType.CurrentType.ToLower().Contains("void"))
                {
                    f.Body.Add(String.Format("{0};", callstring));
                }
                else if (func.ReturnType.WrapperType == WrapperTypes.ConvenienceReturnType ||
                         func.ReturnType.WrapperType == WrapperTypes.ConvenienceArrayReturnType)
                {
                    // int foo() { int value; foo(1, &value); retval = value }
                    callstring = GetInvocationString(f.WrappedDelegate);
                    var p = f.WrappedDelegate.Parameters.Last();
                    f.Body.Add(String.Format("{0};", callstring));
                    f.Body.Add(String.Format(
                        "retval = {0}{1};",
                        pointer_levels[p.IndirectionLevel],
                        p.Name));
                }
                else if (func.ReturnType.CurrentType.ToLower().Contains("string"))
                {
                    f.Body.Add(String.Format("{0} {1} = null; unsafe {{ {1} = new string((sbyte*){2}); }}",
                        func.ReturnType.QualifiedType, "retval", callstring));
                }
                else
                {
                    f.Body.Add(String.Format("{0} {1} = {2};",
                        GetDeclarationString(f.ReturnType), "retval", callstring));
                }

                // Assign out parameters
                f.Body.AddRange(assign_statements);

                // Return
                if (!f.ReturnType.CurrentType.ToLower().Contains("void"))
                {
                    f.Body.Add("return retval;");
                }
            }
            else
            {
                // Call function and return
                var callstring = GetInvocationString(f);
                if (func.Parameters.Any(p => p.WrapperType == WrapperTypes.ConvenienceArrayType))
                {
                    // int foo(int id) { return foo(1, ref id) }
                    callstring = GetInvocationString(f.WrappedDelegate);
                    f.Body.Add(String.Format("{0}{1};",
                        f.ReturnType.CurrentType.ToLower().Contains("void") ? String.Empty : "return ",
                        callstring));
                }
                else if (f.ReturnType.CurrentType.ToLower().Contains("void"))
                {
                    f.Body.Add(String.Format("{0};", callstring));
                }
                else if (func.ReturnType.WrapperType == WrapperTypes.ConvenienceReturnType ||
                         func.ReturnType.WrapperType == WrapperTypes.ConvenienceArrayReturnType)
                {
                    // int foo() { int retval; foo(1, &retval); return retval }
                    callstring = GetInvocationString(f.WrappedDelegate);
                    f.Body.Add(String.Format("{0};", callstring));
                    f.Body.Add(String.Format("return retval;"));
                }
                else if (func.ReturnType.CurrentType.ToLower().Contains("string"))
                {
                    f.Body.Add(String.Format("unsafe {{ return new string((sbyte*){0}); }}",
                        callstring));
                }
                else
                {
                    f.Body.Add(String.Format("return {0};", callstring));
                }
            }

            // Free all allocated GCHandles
            if (handle_statements.Count > 0)
            {
                f.Body.Unindent();
                f.Body.Add("}");
                f.Body.Add("finally");
                f.Body.Add("{");
                f.Body.Indent();

                f.Body.AddRange(handle_release_statements);

                f.Body.Unindent();
                f.Body.Add("}");
            }

            if (add_unsafe)
            {
                f.Body.Unindent();
                f.Body.Add("}");
            }

            if (fixed_statements.Count > 0)
            {
                f.Body.Unindent();
                f.Body.Add("}");
            }

            if ((Settings.Compatibility & Settings.Legacy.NoDebugHelpers) == 0)
            {
                if (f.TrimmedName != "GetError")
                {
                    f.Body.Add("#if DEBUG");
                    if (f.TrimmedName == "End")
                        f.Body.Add("GraphicsContext.CurrentContext.ErrorChecking = true;");
                    f.Body.Add("}");
                    f.Body.Add("#endif");
                }
            }

            f.Body.Unindent();

            func.Body = f.Body;
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
            sb.Append(GetDeclarationString(d.ReturnType));
            sb.Append(" ");
            sb.Append(d.Name);
            sb.Append(GetDeclarationString(d.Parameters));

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

        string GetDeclarationString(Function f)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(f.Unsafe ? "unsafe " : "");
            sb.Append(GetDeclarationString(f.ReturnType));
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
            sb.AppendLine(GetDeclarationString(f.Parameters));
            if (f.Parameters.HasGenericParameters)
            {
                foreach (Parameter p in f.Parameters)
                {
                    if (p.Generic)
                        sb.AppendLine(String.Format("    where {0} : struct", p.CurrentType));
                }
            }

            sb.AppendLine("{");
            foreach (var line in f.Body)
            {
                sb.AppendLine(line);
            }
            sb.Append("}");

            return sb.ToString();
        }

        string GetDeclarationString(Parameter p, bool override_unsafe_setting)
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
                    sb.Append(GetDeclarationString(p as Type));
                }
            }
            else
            {
                sb.Append(GetDeclarationString(p as Type));
            }
            if (!String.IsNullOrEmpty(p.Name))
            {
                sb.Append(" ");
                sb.Append(p.Name);
            }

            return sb.ToString();
        }

        string GetDeclarationString(ParameterCollection parameters)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("(");
            if (parameters.Count > 0)
            {
                foreach (Parameter p in parameters)
                {
                    sb.Append(GetDeclarationString(p, false));
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

        string GetDeclarationString(Type type)
        {
            return String.Format("{0}{1}{2}",
                type.QualifiedType,
                pointer_levels[type.Pointer],
                array_levels[type.Array]);
        }

        string GetInvocationString(Delegate d)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Settings.DelegatesClass);
            sb.Append(Settings.NamespaceSeparator);
            sb.Append(Settings.FunctionPrefix);
            sb.Append(d.Name);
            sb.Append(GetInvocationString(d.Parameters));

            return sb.ToString();
        }

        string GetInvocationString(ParameterCollection parameters)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("(");

            if (parameters.Count > 0)
            {
                foreach (Parameter p in parameters)
                {
                    if (p.Unchecked)
                        sb.Append("unchecked((" + p.QualifiedType + ")");

                    if (!p.Generic && p.CurrentType != "object")
                    {
                        if (p.CurrentType.ToLower().Contains("string"))
                        {
                            sb.Append(String.Format("({0}{1})",
                                p.QualifiedType, (p.Array > 0) ? "[]" : ""));
                        }
                        else if (p.IndirectionLevel != 0)
                        {
                            if (((Settings.Compatibility & Settings.Legacy.TurnVoidPointersToIntPtr) != Settings.Legacy.None) &&
                                p.Pointer != 0 && p.CurrentType.Contains("void"))
                            {
                                sb.Append("(IntPtr)");
                            }
                            else
                            {
                                sb.Append("(");

                                sb.Append(p.QualifiedType);
                                for (int i = 0; i < p.IndirectionLevel; i++)
                                    sb.Append("*");
                                sb.Append(")");
                            }
                        }
                        else
                        {
                            sb.Append(String.Format("({0})", p.QualifiedType));
                        }
                    }


                    switch (p.WrapperType)
                    {
                        case WrapperTypes.GenericParameter:
                            if (p.Generic)
                            {
                                sb.Append("(IntPtr)");
                                sb.Append(p.Name);
                                sb.Append("_ptr.AddrOfPinnedObject()");
                            }
                            else
                            {
                                sb.Append(p.Name);
                            }
                            break;

                        case WrapperTypes.ArrayParameter:
                        case WrapperTypes.ReferenceParameter:
                            sb.Append(p.Name);
                            sb.Append("_ptr");
                            break;

                        default:
                            sb.Append(p.Name);
                            break;
                    }

                    if (p.Unchecked)
                        sb.Append(")");

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

        #endregion
    }
}
