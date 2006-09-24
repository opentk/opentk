/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OpenTK.OpenGL.Bind
{
    public partial class Process
    {
        /// <summary>
        /// Writes the Translated opengl functions and function prototypes to the static opengl class.
        /// </summary>
        /// <param name="output_path">The folder wherein the class will be written.</param>
        public void WriteFunctions(string output_path)
        {
            if (!Directory.Exists(output_path))
                Directory.CreateDirectory(output_path);

            StreamWriter sw = new StreamWriter(Path.Combine(output_path, "GLFunctions.cs"), false);

            Console.WriteLine("Writing opengl functions to: {0}", output_path);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine();
            sw.WriteLine("namespace {0}", Properties.Bind.Default.OutputNamespace);
            sw.WriteLine("{");
            sw.WriteLine("    public static partial class {0}", Properties.Bind.Default.OutputGLClass);
            sw.WriteLine("    {");
            sw.WriteLine("        public static bool ExtensionsLoaded = false;");
            sw.WriteLine("        public static bool CoreLoaded = false;");
            sw.WriteLine();
            sw.WriteLine("        #region OpenGL functions");
            sw.WriteLine();

            foreach (Function f in FunctionCollection)
            {
                sw.WriteLine("        public static Delegates.{0} {0};", f.Name);
            }

            sw.WriteLine();
            sw.WriteLine("        #endregion");
            sw.WriteLine();

            sw.WriteLine("        #region OpenGL function prototypes");
            sw.WriteLine();
            sw.WriteLine("        public static class Delegates");
            sw.WriteLine("        {");

            foreach (Function f in FunctionCollection)
            {
                sw.WriteLine("            public delegate {0};", f.ToString());
            }

            sw.WriteLine("        }");
            sw.WriteLine();
            sw.WriteLine("        #endregion");
            
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.WriteLine();

            sw.Flush();
            sw.Close();
        }
    }
}
