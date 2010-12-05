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

    sealed class CppSpecWriter : ISpecWriter
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

            Settings.DefaultOutputNamespace = "OpenTK";

            string temp_core_file = Path.GetTempFileName();

            using (BindStreamWriter sw = new BindStreamWriter(temp_core_file))
            {
                WriteLicense(sw);

                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");
                sw.Indent();

                WriteEnums(sw, enums);
                WriteWrappers(sw, wrappers, Type.CSTypes);

                sw.Unindent();
                sw.WriteLine("}");
            }

            string output_core = Path.Combine(Settings.OutputPath, "gl.h");
            if (File.Exists(output_core))
                File.Delete(output_core);
            File.Move(temp_core_file, output_core);
        }

        #endregion

        #region WriteDelegates

        public void WriteDelegates(BindStreamWriter sw, DelegateCollection delegates)
        {
            Trace.WriteLine(String.Format("Writing delegates to:\t{0}", Settings.OutputNamespace));

            foreach (Delegate d in delegates.Values)
            {
                sw.WriteLine("extern {0} {1}({2});", d.ReturnType, d.Name, d.Parameters);
            }
        }

        #endregion

        #region WriteImports

        public void WriteImports(BindStreamWriter sw, DelegateCollection delegates)
        {
        }

        #endregion

        #region WriteWrappers

        public void WriteWrappers(BindStreamWriter sw, FunctionCollection wrappers, Dictionary<string, string> CSTypes)
        {
            sw.WriteLine("struct {0}", Settings.GLClass);
            sw.WriteLine("{");
            sw.Indent();

            foreach (string extension in wrappers.Keys)
            {
                if (extension != "Core")
                {
                    sw.WriteLine("struct {0}", extension);
                    sw.WriteLine("{");
                    sw.Indent();
                }

                // Avoid multiple definitions of the same function
                Delegate last_delegate = null;

                // Write forward-compatible functions
                foreach (Function f in wrappers[extension].Where(f => !f.Deprecated).Select(f => f))
                {
                    WriteDelegate(sw, f, ref last_delegate);
                }

                // Write deprecated functions
                sw.WriteLine("#ifdef ALLOW_DEPRECATED_GL");
                sw.Indent();
                foreach (Function f in wrappers[extension].Where(f => !f.Deprecated).Select(f => f))
                {
                    WriteDelegate(sw, f, ref last_delegate);
                }
                sw.Unindent();
                sw.WriteLine("#endif");

                if (extension != "Core")
                {
                    sw.Unindent();
                    sw.WriteLine("};");
                }
            }

            sw.Unindent();
            sw.WriteLine("};");
        }

        private static void WriteDelegate(BindStreamWriter sw, Function f, ref Delegate last_delegate)
        {
            var d = f.WrappedDelegate;
            // Avoid multiple definitions of the same function
            if (d != last_delegate)
            {
                last_delegate = d;
                sw.WriteLine("static {0} (*p{1})({2});", d.ReturnType, f.TrimmedName, d.Parameters);
                sw.WriteLine("extern p{0} {0};", f.TrimmedName);
            }
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
                sw.WriteLine("typedef {0} {1};", s, CSTypes[s]);
            }
        }

        #endregion

        #region WriteEnums

        public void WriteEnums(BindStreamWriter sw, EnumCollection enums)
        {
            foreach (Enum @enum in enums.Values)
            {
                sw.Write("struct ");
                sw.Write(@enum.Name);
                sw.Write(" : Enumeration<");
                sw.Write(@enum.Name);
                sw.WriteLine(">");
                sw.WriteLine("{");
                sw.Indent();
                sw.WriteLine("enum ");
                sw.WriteLine("{");
                sw.Indent();
                foreach (var c in @enum.ConstantCollection.Values)
                {
                    sw.Write(c);
                    sw.WriteLine(",");
                }
                sw.Unindent();
                sw.WriteLine("};");
                sw.Unindent();
                sw.WriteLine("};");
                sw.WriteLine();
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
