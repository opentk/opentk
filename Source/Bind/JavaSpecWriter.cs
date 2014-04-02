#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2011 the Open Toolkit library.
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

    sealed class JavaSpecWriter : ISpecWriter
    {
        const string DigitPrefix = "T"; // Prefix for identifiers that start with a digit
        const string OutputFileHeader = "GL.java";

        BindStreamWriter sw_h = new BindStreamWriter(Path.GetTempFileName());

        IBind Generator { get; set; }
        Settings Settings { get { return Generator.Settings; } }

        #region WriteBindings

        public void WriteBindings(IBind generator)
        {
            Generator = generator;
            WriteBindings(generator.Delegates, generator.Wrappers, generator.Enums);
        }

        void WriteBindings(DelegateCollection delegates, FunctionCollection wrappers, EnumCollection enums)
        {
            Console.WriteLine("Writing bindings to {0}", Settings.OutputPath);
            if (!Directory.Exists(Settings.OutputPath))
                Directory.CreateDirectory(Settings.OutputPath);

            // Hack: Fix 3dfx extension category so it doesn't start with a digit
            if (wrappers.ContainsKey("3dfx"))
            {
                var three_dee_fx = wrappers["3dfx"];
                wrappers.Remove("3dfx");
                wrappers.Add(DigitPrefix + "3dfx", three_dee_fx);
            }

            using (var sw = sw_h)
            {
                WriteLicense(sw);

                sw.WriteLine("package {0}.{1};", Settings.OutputNamespace, Settings.GLClass);
                sw.WriteLine();
                sw.WriteLine("import java.nio.*;");
                sw.WriteLine();

                WriteDefinitions(sw, enums, wrappers, Generator.CSTypes);

                sw.Flush();
                sw.Close();
            }

            string output_header = Path.Combine(Settings.OutputPath, OutputFileHeader);
            Move(sw_h.File, output_header);
        }

        void Move(string file, string dest)
        {
            if (File.Exists(dest))
                File.Delete(dest);
            File.Move(file, dest);
        }

        #endregion

        #region WriteDefinitions

        void WriteDefinitions(BindStreamWriter sw,
            EnumCollection enums, FunctionCollection wrappers,
            IDictionary<string, string> CSTypes)
        {
            sw.WriteLine("public class {0}", Settings.GLClass);
            sw.WriteLine("{");
            sw.Indent();

            foreach (string extension in wrappers.Keys)
            {
                if (extension != "Core")
                {
                    sw.WriteLine("public static class {0}", extension);
                    sw.WriteLine("{");
                    sw.Indent();
                }

                // Write wrappers
                foreach (var f in wrappers[extension])
                {
                    WriteWrapper(f, sw);
                }

                if (extension != "Core")
                {
                    sw.Unindent();
                    sw.WriteLine("}");
                }
            }

            WriteEnums(sw, enums);

            sw.Unindent();
            sw.WriteLine("}");
        }

        #endregion

        #region WriteEnums

        public void WriteEnums(BindStreamWriter sw, EnumCollection enums)
        {
            foreach (Enum @enum in enums.Values)
            {
                sw.WriteLine("public enum {0}", @enum.Name);
                sw.WriteLine("{");
                sw.Indent();
                int count = @enum.ConstantCollection.Values.Count;
                if (count == 0)
                {
                    // Java enums must have at least one value.
                    sw.WriteLine("None;");
                }
                else
                {
                    foreach (var c in @enum.ConstantCollection.Values)
                    {
                        sw.WriteLine(String.Format("{0}({1}{2}){3}",
                            c.Name,
                            !String.IsNullOrEmpty(c.Reference) ? (c.Reference + Settings.NamespaceSeparator) : "",
                            !String.IsNullOrEmpty(c.Reference) ? c.Value : c.Value.ToLower(),
                            --count == 0 ? ";" : ","));
                    }
                    sw.WriteLine();
                    sw.WriteLine("{0} mValue;", @enum.Type);
                    sw.WriteLine("{0}({1} value) {{ mValue = value; }}", @enum.Name, @enum.Type);
                }
                sw.Unindent();
                sw.WriteLine("}");
                sw.WriteLine();
            }
        }

        #endregion

        #region WriteWrappers

        static void WriteWrapper(Function f, BindStreamWriter sw)
        {
            var valid = true;
            var generic_parameters = GenerateGenericTypeString(f);
            var parameters = GenerateParameterString(f, out valid);
            var ret_parameter = GenerateReturnParameterString(f);
            if (!valid)
                return;

            if (!String.IsNullOrEmpty(generic_parameters))
                sw.WriteLine("public static <{0}> {1} {2}({3})", generic_parameters,
                    ret_parameter, f.TrimmedName, parameters);
            else
                sw.WriteLine("public static {0} {1}({2})", ret_parameter, f.TrimmedName,
                    parameters);

            sw.WriteLine("{");
            sw.Indent();
            WriteMethodBody(sw, f);
            sw.Unindent();
            sw.WriteLine("}");
        }

        static void WriteMethodBody(BindStreamWriter sw, Function f)
        {
            //var callstring = f.Parameters.CallString();
            //if (f.ReturnType != null && !f.ReturnType.ToString().ToLower().Contains("void"))
            //    sw.WriteLine("return GLES20.{0}{1};", f.WrappedDelegate.Name, callstring);
            //else
            //    sw.WriteLine("GLES20.{0}{1};", f.WrappedDelegate.Name, callstring);
        }

        static string GenerateParameterString(Function f, out bool valid)
        {
            if (f == null)
                throw new ArgumentNullException("f");

            valid = true;
            var sb = new StringBuilder();

            if (f.Parameters.Count > 0)
            {
                foreach (var p in f.Parameters)
                {
                    if (p.Reference)
                    {
                        // Use a boxed type instead of primitives (i.e. "Byte" rather than "byte"), since
                        // the former are reference types. We don't need to do anything for regular reference
                        // types.
                        // Hack: we do this by upper-casing the first letter of the type. This should work for
                        // all primitive types, but won't work for enums and other reference types. In these
                        // cases, we'll just ignore the reference overload.
                        if (Char.IsLower(p.CurrentType[0]))
                        {
                            // Hack: Int -> Integer and Bool -> Boolean
                            if (p.CurrentType == "int")
                                sb.Append("Integer");
                            else if (p.CurrentType == "bool")
                                sb.Append("Boolean");
                            else
                                sb.Append(Char.ToUpper(p.CurrentType[0]) + p.CurrentType.Substring(1));
                        }
                        else
                        {
                            valid = false;
                            return String.Empty;
                        }
                    }
                    else if (p.Array > 0)
                    {
                        // Generic arrays are handled in the IntPtr case below.
                        if (p.Generic)
                        {
                            valid = false;
                            return String.Empty;
                        }

                        sb.Append(p.CurrentType);
                        for (int i = 0; i < p.Array; i++)
                            sb.Append("[]");
                    }
                    else if (p.Pointer > 0)
                    {
                        // Java does not support pointers
                        // Todo: maybe use one of the java.nio.* pointer classes?
                        valid = false;
                        return String.Empty;
                    }
                    else if (p.CurrentType == "IntPtr")
                    {
                        sb.Append("Buffer");
                    }
                    else
                    {
                        sb.Append(p.CurrentType);
                    }

                    sb.Append(" ");
                    sb.Append(p.Name);
                    sb.Append(", ");
                }

                if (f.Parameters.Count > 0)
                    sb.Remove(sb.Length - 2, 2);
            }

            return sb.ToString();
        }

        static string GenerateGenericTypeString(Function f)
        {
            var parameters = f.Parameters.Where(p => p.Generic);
            if (parameters.Count() > 0)
            {
                var sb = new StringBuilder();
                foreach (var p in f.Parameters.Where(p => p.Generic))
                {
                    sb.Append(p.CurrentType);
                    sb.Append(", ");
                }
                if (parameters.Count() > 0)
                    sb.Remove(sb.Length - 2, 2);

                return sb.ToString();
            }

            return String.Empty;
        }

        private static string GenerateReturnParameterString(Function f)
        {
            if (f.ReturnType.CurrentType == "IntPtr")
                return "Buffer";
            else
                return f.ReturnType.CurrentType;
        }

        void WriteDocumentation(BindStreamWriter sw, Function f)
        {
            var docs = f.Documentation;

            try
            {
                string warning = "[deprecated: v{0}]";
                string category = "[requires: {0}]";
                if (f.Deprecated)
                {
                    warning = String.Format(warning, f.DeprecatedVersion);
                    docs.Summary = docs.Summary.Insert(0, warning);
                }

                if (f.Extension != "Core" && !String.IsNullOrEmpty(f.Category))
                {
                    category = String.Format(category, f.Category);
                    docs.Summary = docs.Summary.Insert(0, category);
                }
                else if (!String.IsNullOrEmpty(f.Version))
                {
                    if (f.Category.StartsWith("VERSION"))
                        category = String.Format(category, "v" + f.Version);
                    else
                        category = String.Format(category, "v" + f.Version + " and " + f.Category);
                    docs.Summary = docs.Summary.Insert(0, category);
                }

                for (int i = 0; i < f.WrappedDelegate.Parameters.Count; i++)
                {
                    var param = f.WrappedDelegate.Parameters[i];
                    if (param.ComputeSize != String.Empty)
                    {
                        docs.Parameters[i].Documentation.Insert(0,
                            String.Format("[length: {0}]", param.ComputeSize));
                    }
                }

                sw.WriteLine("/// <summary>{0}</summary>", docs.Summary);
                foreach (var p in docs.Parameters)
                {
                    sw.WriteLine("/// <param name=\"{0}\">{1}</param>", p.Name, p.Documentation);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("[Warning] Error documenting function {0}: {1}",
                    f.WrappedDelegate.Name, e.ToString());
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
