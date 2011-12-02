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
        readonly char[] numbers = "0123456789".ToCharArray();
        const string DigitPrefix = "T"; // Prefix for identifiers that start with a digit
        const string OutputFileHeader = "GL.java";

        BindStreamWriter sw_h = new BindStreamWriter(Path.GetTempFileName());

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

            // Hack: Fix 3dfx extension category so it doesn't start with a digit
            if (wrappers.ContainsKey("3dfx"))
            {
                var three_dee_fx = wrappers["3dfx"];
                wrappers.Remove("3dfx");
                wrappers.Add(DigitPrefix + "3dfx", three_dee_fx);
            }

            Settings.DefaultOutputNamespace = "com.opentk";

            using (var sw = sw_h)
            {
                WriteLicense(sw);

                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");
                sw.Indent();

                //WriteGetAddress(sw);
                //WriteTypes(sw);
                WriteEnums(sw, enums);
                WriteDefinitions(sw, enums, wrappers, Type.CSTypes);

                sw.Unindent();
                sw.WriteLine("}");

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

        static void WriteWrapper(Function f, BindStreamWriter sw)
        {
            var parameters = f.WrappedDelegate.Parameters.ToString()
            .Replace("[OutAttribute]", String.Empty);
            sw.WriteLine("{");
            sw.Indent();
            WriteMethodBody(sw, f);
            sw.Unindent();
            sw.WriteLine("}");
        }

        #endregion

        #region WriteDefinitions

        void WriteDefinitions(BindStreamWriter sw,
        EnumCollection enums, FunctionCollection wrappers,
        Dictionary<string, string> CSTypes)
        {
            sw.WriteLine("namespace {0}", Settings.GLClass);
            sw.WriteLine("{");
            sw.Indent();

            foreach (string extension in wrappers.Keys)
            {
                if (extension != "Core")
                {
                    sw.WriteLine("namespace {0}", extension);
                    sw.WriteLine("{");
                    sw.Indent();
                }

                // Avoid multiple definitions of the same function
                Delegate last_delegate = null;

                // Write wrappers
                foreach (var f in wrappers[extension])
                {
                    WriteWrapper(f, sw);
                }

                if (extension != "Core")
                {
                    sw.Unindent();
                    sw.WriteLine("};");
                }
            }

            sw.Unindent();
            sw.WriteLine("};");

            sw.Unindent();
            sw.WriteLine("}");
        }

        #endregion

        static string GetNamespace(string ext)
        {
            if (ext == "Core")
                return Settings.GLClass;
            else
                return String.Format("{0}::{1}", Settings.GLClass, Char.IsDigit(ext[0]) ? DigitPrefix + ext : ext);
        }

        #region WriteEnums

        public void WriteEnums(BindStreamWriter sw, EnumCollection enums)
        {
            foreach (Enum @enum in enums.Values)
            {
                sw.WriteLine("public enum {0}", @enum.Name);
                sw.WriteLine("{");
                sw.Indent();
                foreach (var c in @enum.ConstantCollection.Values)
                {
                    // Java doesn't have the concept of "unchecked", so remove this.
                    if (!c.Unchecked)
                        sw.WriteLine("{0},", c);
                    else
                        sw.WriteLine("{0},", c.ToString().Replace("unchecked", String.Empty));
                }
                sw.Unindent();
                sw.WriteLine("}");
                sw.WriteLine();
            }
        }

        #endregion

        #region WriteTypes

        void WriteTypes(BindStreamWriter sw)
        {
            //sw.WriteLine(TypeDefinitions);
        }

        #endregion

        #region WriteDelegate

        static void WriteDelegate(BindStreamWriter sw, Delegate d, ref Delegate last_delegate)
        {
            // Avoid multiple definitions of the same function
            if (d != last_delegate)
            {
                last_delegate = d;
                var parameters = d.Parameters.ToString()
                .Replace("String[]", "String*")
                .Replace("[OutAttribute]", String.Empty);
                sw.WriteLine("typedef {0} (APIENTRY *p{1}){2};", d.ReturnType, d.Name, parameters);
                sw.WriteLine("inline p{0}& {0}()", d.Name);
                sw.WriteLine("{");
                sw.Indent();
                sw.WriteLine("static p{0} address = 0;", d.Name);
                sw.WriteLine("return address;");
                sw.Unindent();
                sw.WriteLine("}");
            }
        }

        #endregion

        #region WriteWrappers

        static void WriteMethodBody(BindStreamWriter sw, Function f)
        {

            var callstring = f.Parameters.CallString();
            if (f.ReturnType != null && !f.ReturnType.ToString().ToLower().Contains("void"))
                sw.WriteLine("return GLES20::{0}(){1};", f.WrappedDelegate.Name, callstring);
            else
                sw.WriteLine("GLES20::{0}(){1};", f.WrappedDelegate.Name, callstring);
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

        #region WriteLicense

        public void WriteLicense(BindStreamWriter sw)
        {
            sw.WriteLine(File.ReadAllText(Path.Combine(Settings.InputPath, Settings.LicenseFile)));
            sw.WriteLine();
        }

        #endregion
    }
}
