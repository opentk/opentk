using System;
using System.Collections.Generic;
using System.Text;
/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System.IO;
using System.Runtime.InteropServices;
using System.Collections;

namespace OpenTK.OpenGL.Bind
{
    static partial class SpecWriter
    {
        #region WriteSpecs

        public static void WriteSpecs(string output_path, List<Function> functions, List<Function> wrappers, Hashtable enums)
        {
            string filename = Path.Combine(output_path, Settings.OutputClass + ".cs");

            if (!Directory.Exists(Settings.OutputPath))
                Directory.CreateDirectory(Settings.OutputPath);

            StreamWriter sw = new StreamWriter(filename, false);

            Console.WriteLine("Writing {0} class to {1}", Settings.OutputClass, filename);

            WriteLicense(sw);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine();
            sw.WriteLine("namespace {0}", Settings.OutputNamespace);
            sw.WriteLine("{");

            WriteTypes(sw);
            WriteEnums(sw, enums);

            sw.WriteLine("    public static partial class {0}", Settings.OutputClass);
            sw.WriteLine("    {");

            WriteFunctionSignatures(sw, functions);
            WriteDllImports(sw, functions);
            WriteFunctions(sw, functions);
            WriteWrappers(sw, wrappers);
            //WriteConstructor(sw, functions);

            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.WriteLine();

            sw.Flush();
            sw.Close();
        }

        #endregion

        public static void WriteLicense(StreamWriter sw)
        {
        }

        #region WriteTypes
        private static void WriteTypes(StreamWriter sw)
        {
            sw.WriteLine("    #region Types");
            //foreach ( c in constants)
            foreach (string key in Translation.CStypes.Keys)
            {
                sw.WriteLine("    using {0} = System.{1};", key, Translation.CStypes[key]);
                //sw.WriteLine("        public const {0};", c.ToString());
            }
            sw.WriteLine("    #endregion");
            sw.WriteLine();
        }
        #endregion

        #region Write enums
        private static void WriteEnums(StreamWriter sw, Hashtable enums)
        {
            sw.WriteLine("    #region Enums");
            sw.WriteLine("    public struct Enums");
            sw.WriteLine("    {");

            #region Missing constants

            sw.WriteLine("        #region Missing Constants");
            sw.WriteLine();

            // Version 1.4 enum
            sw.WriteLine("        const uint GL_FOG_COORDINATE_SOURCE = 0x8450;");
            sw.WriteLine("        const uint GL_FOG_COORDINATE = 0x8451;");
            sw.WriteLine("        const uint GL_CURRENT_FOG_COORDINATE = 0x8453;");
            sw.WriteLine("        const uint GL_FOG_COORDINATE_ARRAY_TYPE = 0x8454;");
            sw.WriteLine("        const uint GL_FOG_COORDINATE_ARRAY_STRIDE = 0x8455;");
            sw.WriteLine("        const uint GL_FOG_COORDINATE_ARRAY_POINTER = 0x8456;");
            sw.WriteLine("        const uint GL_FOG_COORDINATE_ARRAY = 0x8457;");

            // Version 1.5 enum
            sw.WriteLine("        const uint GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;");

            // Version 1.3 enum
            sw.WriteLine("        const uint GL_SOURCE0_RGB = 0x8580;");
            sw.WriteLine("        const uint GL_SOURCE1_RGB = 0x8581;");
            sw.WriteLine("        const uint GL_SOURCE2_RGB = 0x8582;");
            sw.WriteLine("        const uint GL_SOURCE0_ALPHA = 0x8588;");
            sw.WriteLine("        const uint GL_SOURCE1_ALPHA = 0x8589;");
            sw.WriteLine("        const uint GL_SOURCE2_ALPHA = 0x858A;");

            // Version 2.0 enum
            sw.WriteLine("        const uint GL_BLEND_EQUATION = 0x8009;");

            sw.WriteLine("        const uint GL_MODELVIEW_MATRIX = 0x0BA6;");
            sw.WriteLine("        const uint GL_MODELVIEW = 0x1700;");
            sw.WriteLine("        const uint GL_MODELVIEW_STACK_DEPTH = 0x0BA3;");

            // NV_texture_shader enum
            sw.WriteLine("        const uint GL_OFFSET_TEXTURE_MATRIX_NV = 0x86E1;");
            sw.WriteLine("        const uint GL_OFFSET_TEXTURE_SCALE_NV = 0x86E2;");
            sw.WriteLine("        const uint GL_OFFSET_TEXTURE_BIAS_NV = 0x86E3;");

            sw.WriteLine();
            sw.WriteLine("        #endregion");
            sw.WriteLine();

            #endregion

            foreach (Enum e in enums.Values)
            {
                sw.WriteLine(e.ToString());
            }

            sw.WriteLine("    }");
            sw.WriteLine("    #endregion");
            sw.WriteLine();
        }
        #endregion

        #region Write function signatures
        private static void WriteFunctionSignatures(StreamWriter sw, List<Function> functions)
        {
            sw.WriteLine("        #region Function signatures");
            sw.WriteLine();
            sw.WriteLine("        public static class Delegates");
            sw.WriteLine("        {");

            foreach (Function f in functions)
            {
                sw.WriteLine("            public delegate {0};", f.ToString());
            }

            sw.WriteLine("        }");
            sw.WriteLine("        #endregion");
            sw.WriteLine();
        }
        #endregion

        #region Write dll imports
        private static void WriteDllImports(StreamWriter sw, List<Function> functions)
        {
            sw.WriteLine("        #region Imports");
            sw.WriteLine();
            sw.WriteLine("        internal class Imports");
            sw.WriteLine("        {");

            foreach (Function f in functions)
            {
                if (!f.Extension)
                {
                    sw.WriteLine("            [DllImport(\"opengl32\", EntryPoint = \"gl{0}\")]", f.Name.TrimEnd('_'));
                    sw.WriteLine("            public static extern {0};", f.ToString());
                }
            }

            sw.WriteLine("        }");
            sw.WriteLine("        #endregion");
            sw.WriteLine();
        }
        #endregion

        #region Write functions
        private static void WriteFunctions(StreamWriter sw, List<Function> functions)
        {
            sw.WriteLine("        #region Function initialisation");
            sw.WriteLine();

            foreach (Function f in functions)
            {
                sw.WriteLine("        public static Delegates.{0} {0};", f.Name);
            }

            sw.WriteLine("        #endregion");
            sw.WriteLine();
        }
        #endregion

        #region Write wrappers

        public static void WriteWrappers(StreamWriter sw, List<Function> wrappers)
        {
            sw.WriteLine("        #region Wrappers");
            sw.WriteLine();

            foreach (Function f in wrappers)
            {
                // Hack! Should implement these in the future.
                if (f.Extension)
                    continue;

                if (f.Parameters.ToString().Contains("out IntPtr"))
                    continue;

                if (f.Parameters.ToString().Contains("IntPtr[]"))
                    continue;

                sw.WriteLine("        #region {0}", f.Name.TrimEnd('_'));
                
                if (f.WrapperType == WrapperTypes.ReturnsString)
                {
                    sw.WriteLine("        public static {0} {1}{2}", "string", f.Name.TrimEnd('_'), f.Parameters.ToString());
                    sw.WriteLine("        {");
                    sw.WriteLine("             return Marshal.PtrToStringAnsi({0});", f.CallString());
                    sw.WriteLine("        }");

                }
                else if (f.Name.Contains("glLineStipple"))
                {
                    sw.WriteLine("        public static {0} {1}{2}", f.ReturnValue, f.Name.TrimEnd('_'), f.Parameters.ToString().Replace("GLushort", "GLint"));
                    sw.WriteLine("        {");
                    sw.WriteLine("             glLineStipple_({0}, unchecked((GLushort){1}));", f.Parameters[0].Name, f.Parameters[1].Name);
                    sw.WriteLine("        }");
                }
                else if (f.WrapperType == WrapperTypes.VoidPointerIn || f.WrapperType == WrapperTypes.VoidPointerOut || f.WrapperType == WrapperTypes.ArrayIn)
                {
                    // Add object overload (i.e. turn off type checking).
                    sw.WriteLine("        public static {0} {1}{2}", f.ReturnValue, f.Name.TrimEnd('_'), f.Parameters.ToString().Replace("IntPtr", "object"));
                    sw.WriteLine("        {");
                    int i = 0;
                    StringBuilder sb = new StringBuilder();
                    sb.Append("(");
                    foreach (Parameter p in f.Parameters)
                    {
                        if (p.Type == "IntPtr")
                        {
                            sw.WriteLine("            GCHandle h{0} = GCHandle.Alloc({1}, GCHandleType.Pinned);", i, p.Name);
                            sb.Append("h" + i + ".AddrOfPinnedObject()" + ", ");
                            i++;
                        }
                        else
                        {
                            sb.Append(p.Name + ", ");
                        }
                    }
                    sb.Replace(", ", ")", sb.Length - 2, 2);

                    sw.WriteLine("            try");
                    sw.WriteLine("            {");
                    if (f.ReturnValue == "void")
                        sw.WriteLine("                {0}{1};", f.Name, sb.ToString());
                    else
                        sw.WriteLine("                return {0}{1};", f.Name, sb.ToString());
                    sw.WriteLine("            }");
                    sw.WriteLine("            finally");
                    sw.WriteLine("            {");
                    while (i > 0)
                    {
                        sw.WriteLine("                h{0}.Free();", --i);
                    }
                    sw.WriteLine("            }");
                    sw.WriteLine("        }");

                    // Add IntPtr overload.
                    sw.WriteLine("        public static {0} {1}{2}", f.ReturnValue, f.Name.TrimEnd('_'), f.Parameters.ToString());
                    sw.WriteLine("        {");
                    sb.Replace(", ", ")", sb.Length - 2, 2);
                    if (f.ReturnValue == "void")
                        sw.WriteLine("            {0};", f.CallString());
                    else
                        sw.WriteLine("            return {0};", f.CallString());
                    sw.WriteLine("        }");
                }

                if (f.WrapperType == WrapperTypes.ArrayIn)
                {
                    // Add overload for the case the normal type is used (e.g. float[], bool[] etc).
                    StringBuilder sb = new StringBuilder();
                    sb.Append("(");
                    foreach (Parameter p in f.Parameters)
                    {
                        if (p.Type == "IntPtr")
                        {
                            //sb.Append("[MarshalAs(UnmanagedType.LPArray)] ");
                            sb.Append(p.PreviousType);
                            sb.Append("[] ");
                            sb.Append(p.Name);
                        }
                        else
                            sb.Append(p.ToString());

                        sb.Append(", ");
                    }
                    sb.Replace(", ", ")", sb.Length - 2, 2);
                    sw.WriteLine("        public static {0} {1}{2}", f.ReturnValue, f.Name.TrimEnd('_'), sb.ToString());
                    sw.WriteLine("        {");
                    int i = 0;
                    sb = new StringBuilder();
                    sb.Append("(");
                    foreach (Parameter p in f.Parameters)
                    {
                        if (p.Type == "IntPtr")
                        {
                            sw.WriteLine("            GCHandle h{0} = GCHandle.Alloc({1}, GCHandleType.Pinned);", i, p.Name);
                            sb.Append("h" + i + ".AddrOfPinnedObject()" + ", ");
                            i++;
                        }
                        else
                        {
                            sb.Append(p.Name + ", ");
                        }
                    }
                    sb.Replace(", ", ")", sb.Length - 2, 2);

                    sw.WriteLine("            try");
                    sw.WriteLine("            {");
                    if (f.ReturnValue == "void")
                        sw.WriteLine("                {0}{1};", f.Name, sb.ToString());
                    else
                        sw.WriteLine("                return {0}{1};", f.Name, sb.ToString());
                    sw.WriteLine("            }");
                    sw.WriteLine("            finally");
                    sw.WriteLine("            {");
                    while (i > 0)
                    {
                        sw.WriteLine("                h{0}.Free();", --i);
                    }
                    sw.WriteLine("            }");
                    sw.WriteLine("        }");
                }

                sw.WriteLine("        #endregion");
                sw.WriteLine();
            }
            sw.WriteLine("    #endregion");
            sw.WriteLine();

            //    if (fw.Parameters.ContainsType("object"))
            //    {
            //        Function f = WeakNameLookup(fw.Name, FunctionCollection);

            //        sw.WriteLine("        public {0} {1}{2}", fw.ReturnValue, fw.Name, fw.Parameters.ToString());
            //        sw.WriteLine("        {");

            //        int i = 0;
            //        StringBuilder sb = new StringBuilder();
            //        sb.Append("(");
            //        foreach (Parameter p in fw.Parameters)
            //        {
            //            if (p.Type == "object")
            //            {
            //                sw.WriteLine("            GCHandle h{0} = GCHandle.Alloc({1}, GCHandleType.Pinned);", i, p.Name);
            //                sb.Append("h" + i + ".AddrOfPinnedObject()" + ", ");
            //                i++;
            //            }
            //            else
            //            {
            //                sb.Append(p.Name + ", ");
            //            }
            //        }
            //        sb.Replace(", ", ")", sb.Length - 2, 2);

            //        sw.WriteLine("            try");
            //        sw.WriteLine("            {");
            //        if (fw.ReturnValue == "void")
            //            sw.WriteLine("                {0}{1};", f.Name, sb.ToString());
            //        else
            //            sw.WriteLine("                return {0}{1};", f.Name, sb.ToString());
            //        sw.WriteLine("            }");
            //        sw.WriteLine("            finally");
            //        sw.WriteLine("            {");
            //        while (i > 0)
            //        {
            //            sw.WriteLine("                h{0}.Free();", --i);
            //        }
            //        sw.WriteLine("            }");
            //        sw.WriteLine("        }");
            //        sw.WriteLine();
            //    }

            //sw.WriteLine("        #endregion");
            //sw.WriteLine("    }");
            //sw.WriteLine("}");

            //sw.Flush();
            //sw.Close();
        }
        #endregion
    }
}