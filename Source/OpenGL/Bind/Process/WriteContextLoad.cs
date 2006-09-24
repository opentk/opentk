/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OpenTK.OpenGL.Bind
{
    partial class Process
    {
        #region Write the per-context load function

        /// <summary>
        /// Write the platform specific Load() and LoadExtensions() functions.
        /// </summary>
        /// <param name="Properties.Bind.Default.OutputPath">The folder where the generated file will be saved.</param>
        /// <param name="class_name">The name of the partial class that contains the load functions.</param>
        /// <param name="core_blocks">The names of the function groups that are considered "core" for the specified platform. (e.g. GL_VERSION_1_1 for Windows prior to Vista)</param>
        void WritePerContextLoad(string output_path, string class_name, params string[] import_functions)
        {
            if (!Directory.Exists(output_path))
                Directory.CreateDirectory(output_path);

            string filename = Path.Combine(output_path, class_name + "Load.cs");
            StreamWriter sw = new StreamWriter(filename, false);

            Console.WriteLine("Writing {0} to {1}", class_name, output_path);

            // Write using directives.
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine("using {0};", Properties.Bind.Default.OutputNamespace);
            sw.WriteLine();

            // Open namespace and class.
            sw.WriteLine("namespace {0}.{1}", Properties.Bind.Default.OutputNamespace, Properties.Bind.Default.OutputPlatformNamespace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class {0}", class_name);
            sw.WriteLine("    {");

            #region Write the DllImports

            // Write the [DllImported] functions.
            sw.WriteLine("        #region DllImports");
            sw.WriteLine();
            sw.WriteLine("        internal class Imports");
            sw.WriteLine("        {");

            foreach (Function f in FunctionCollection)
            {
                if (IsImportFunction(f, import_functions))
                {
                    sw.WriteLine("            [DllImport(_dll_name, EntryPoint = \"{0}\")]", "gl" + f.Name);
                    sw.WriteLine("            public static extern {0};", f.ToString());
                    sw.WriteLine();
                }
            }

            sw.WriteLine("        }");
            sw.WriteLine("        #endregion");
            sw.WriteLine();

            #endregion

            #region Write the Load function for the opengl core.

            // Write the Load function.
            sw.WriteLine("        #region Load core");
            sw.WriteLine();
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// Loads the core opengl functions (versions 1.0-2.0).");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public override void Load()");
            sw.WriteLine("        {");
            sw.WriteLine("            if ({0}.CoreLoaded) return;", Properties.Bind.Default.OutputGLClass);
            sw.WriteLine("            if ({0}.ExtensionsLoaded) return;", Properties.Bind.Default.OutputGLClass);

            foreach (Function f in FunctionCollection)
            {
                if (!f.Extension)
                {
                    if (IsImportFunction(f, import_functions))
                        sw.WriteLine("            {0}.{1} = new {0}.Delegates.{1}(Imports.{1});",
                            Properties.Bind.Default.OutputGLClass,
                            f.Name);
                    else
                        sw.WriteLine("            {0}.{1} = ({0}.Delegates.{1}) GetAddress(\"gl{1}\", typeof({0}.Delegates.{1}));",
                            Properties.Bind.Default.OutputGLClass,
                            f.Name);
                }
            }

            sw.WriteLine("        CoreLoaded = true;");
            sw.WriteLine("        }");
            sw.WriteLine();
            sw.WriteLine("        #endregion");
            sw.WriteLine();

            #endregion

            #region Write the LoadExtensions function for the opengl extensions.

            // Write the LoadExtensions function.
            sw.WriteLine("        #region Load extensions");
            sw.WriteLine();
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// Loads the opengl extensions (e.g. ARB, EXT, vendor and platform specific functions).");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public override void LoadExtensions()");
            sw.WriteLine("        {");

            foreach (Function f in FunctionCollection)
            {
                if (f.Extension)
                    sw.WriteLine("            {0}.{1} = ({0}.Delegates.{1}) GetAddress(\"gl{1}\", typeof({0}.Delegates.{1}));",
                        Properties.Bind.Default.OutputGLClass,
                        f.Name);
            }
            
            sw.WriteLine("        CoreLoaded = true;");
            sw.WriteLine("        }");
            sw.WriteLine();
            sw.WriteLine("        #endregion");

            #endregion

            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Flush();
            sw.Close();
        }

        private bool IsImportFunction(Function f, string[] import_functions)
        {
            if (f.Extension)
                return false;

            foreach (string s in import_functions)
                if (f.Version == s)
                    return true;
            
            return false;
        }

        #endregion
    }
}
