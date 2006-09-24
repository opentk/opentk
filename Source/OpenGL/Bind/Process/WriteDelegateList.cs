/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OpenTK.OpenGL.Bind
{
/*
    partial class Process
    {
        #region Write Delegates.

        /// <summary>
        /// Writes the full list of delegates for opengl functions.
        /// </summary>
        /// <param name="output_path">The path where the GL class will be written to.</param>
        void WriteDelegates(string output_path, string class_name)
        {
            if (!Directory.Exists(output_path))
                Directory.CreateDirectory(output_path);

            string delegates_path = Path.Combine(output_path, "GLFunctions.cs");
            StreamWriter sw = new StreamWriter(delegates_path, false);
            Console.WriteLine("Writing delegates to: {0}", delegates_path);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine("using {0};", _opengl_delegates_namespace);
            sw.WriteLine();
            sw.WriteLine("namespace {0}", _opengl_namespace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class {0}", class_name);
            sw.WriteLine("    {");
            sw.WriteLine("        #region OpenGL Function Declarations.");
            sw.WriteLine();

            foreach (Block b in BlockList)
            {
                sw.WriteLine("        #region {0} Functions", b.Name);
                sw.WriteLine();

                foreach (Function f in b.Functions)
                {
                    //sw.WriteLine("        public static {0} {1};", f.Name, f.Name.TrimStart('g', 'l'));

                    if (!f.NeedsWrapper)
                        sw.WriteLine("        public static {0} {1};", f.Name, f.Name.TrimStart('g', 'l'));
                    else
                        sw.WriteLine("        public static {0} _{1};", f.Name, f.Name.TrimStart('g', 'l'));
                }

                sw.WriteLine();
                sw.WriteLine("        #endregion");
                sw.WriteLine();
            }

            sw.WriteLine("        #endregion");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Flush();
            sw.Close();
        }

        #endregion
    }
*/
}
