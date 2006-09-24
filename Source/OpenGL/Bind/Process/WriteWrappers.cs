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
        #region Write Wrappers

        void WriteWrappers(string output_path)
        {
            if (!Directory.Exists(output_path))
                Directory.CreateDirectory(output_path);

            output_path = Path.Combine(output_path, "GLWrappers.cs");
            StreamWriter sw = new StreamWriter(output_path, false);
            Console.WriteLine("Writing wrappers to {0}", output_path);
            
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine();
            sw.WriteLine("namespace {0}", Properties.Bind.Default.OutputNamespace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class {0}", Properties.Bind.Default.OutputGLClass);
            sw.WriteLine("    {");
            sw.WriteLine("        #region Wrappers");
            sw.WriteLine();

            foreach (Function fw in WrapperCollection)
            {
                sw.WriteLine("        // Wrapper for function {0}", fw.Name);

                if (fw.Parameters.ContainsType("object"))
                {
                    Function f = WeakNameLookup(fw.Name, FunctionCollection);

                    sw.WriteLine("        public {0} {1}{2}", fw.ReturnValue, fw.Name, fw.Parameters.ToString());
                    sw.WriteLine("        {");

                    int i = 0;
                    StringBuilder sb = new StringBuilder();
                    sb.Append("(");
                    foreach (Parameter p in fw.Parameters)
                    {
                        if (p.Type == "object")
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
                    if (fw.ReturnValue == "void")
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
                    sw.WriteLine();
                }
            }

#region Commented out

            /*
            foreach (Function f in FunctionCollection)
            {
                if (f.NeedsWrapper)
                {
                    sw.WriteLine("        // Wrapper for function {0}", f.Name);

                    if (f.ReturnValue == "IntPtr")
                    {
                        sw.WriteLine("        public {0} {1}{2}", f.ReturnValue, f.Name.TrimEnd('_'), f.Parameters.ToString());
                        sw.WriteLine("        {");
                        //    sw.WriteLine("                return Marshal.PtrToStructure(_{0}{1}, new byte[]);", f.Name.TrimStart('g', 'l'), f.Parameters.GetNameString());
                        sw.WriteLine("            throw new NotImplementedException(\"Wrapper not implemented yet.\");");
                        sw.WriteLine("        }");
                        sw.WriteLine();
                    }

                }
            }
            */
            /*
            foreach (Block b in BlockCollection)
            {
                foreach (Function f in b.Functions)
                {
                    if (f.NeedsWrapper)
                    {
                        sw.WriteLine("        // Wrapper for function _{0}", f.Name);

                        if (f.Name == "glGetString")  // Wraps GLubyte* glGetString(GLenum name);
                        {
                            sw.WriteLine("        public {0} {1}{2}", "string", f.Name.TrimStart('g', 'l'), f.Parameters.ToString());
                            sw.WriteLine("        {");
                            sw.WriteLine("            return Marshal.PtrToStringAnsi(_{0}{1});", f.Name.TrimStart('g', 'l'), f.Parameters.GetNameString());
                            sw.WriteLine("        }");
                            sw.WriteLine();
                        }
                        else if (f.ReturnValue == "Array")  // For the 3 functions that return a GLvoid*.
                        {
                            sw.WriteLine("        public {0} {1}{2}", f.ReturnValue, f.Name.TrimStart('g', 'l'), f.Parameters.ToString());
                            sw.WriteLine("        {");
//    sw.WriteLine("                return Marshal.PtrToStructure(_{0}{1}, new byte[]);", f.Name.TrimStart('g', 'l'), f.Parameters.GetNameString());
                            sw.WriteLine("            throw new NotImplementedException(\"Wrapper not implemented yet.\");");
                            sw.WriteLine("        }");
                            sw.WriteLine();
                        }
                        else if (f.Parameters.ToString().Contains("out Object[]"))
                        {
                            sw.WriteLine("        public {0} {1}{2}", f.ReturnValue, f.Name.TrimStart('g', 'l'), f.Parameters.ToString());
                            sw.WriteLine("        {");
                            sw.WriteLine("            throw new NotImplementedException(\"Wrapper not implemented yet.\");");
                            sw.WriteLine("        }");
                            sw.WriteLine();
                        }
                        else if (f.Parameters.ToString().Contains("Object[]"))
                        {
                            sw.WriteLine("        public  {0} {1}{2}", f.ReturnValue, f.Name.TrimStart('g', 'l'), f.Parameters.ToString());
                            sw.WriteLine("        {");
                            sw.WriteLine("            throw new NotImplementedException(\"Wrapper not implemented yet.\");");
                            sw.WriteLine("        }");
                            sw.WriteLine();
                        }
                        else if (f.Parameters.ToString().Contains("out Object"))   // For those functions that have an Array 'out' parameter:
                        {
                            sw.WriteLine("        public {0} {1}{2}", f.ReturnValue, f.Name.TrimStart('g', 'l'), f.Parameters.ToString());
                            sw.WriteLine("        {");
                            sw.WriteLine("            throw new NotImplementedException(\"Wrapper not implemented yet.\");");
                            // HACK: The Array parameter is always the last one (I think)
                            //    sw.WriteLine("                GCHandle h = GCHandle.Alloc({0}, GCHandleType.Pinned);", f.Parameters[f.Parameters.Count-1].Name);
                            //    sw.WriteLine("                try");
                            //    sw.WriteLine("                {");
                            //    sw.WriteLine("                    _{0}{1};", f.Name, f.ParameterNamesWithArrayRenamingString);
                            //    sw.WriteLine("                }");
                            //    sw.WriteLine("                finally");
                            //    sw.WriteLine("                {");
                            //    sw.WriteLine("                    h.Free();");
                            //    sw.WriteLine("                }");
                            sw.WriteLine("        }");
                            sw.WriteLine();
                        }
                        else if (f.Parameters.ToString().Contains("Object"))
                        {
                            sw.WriteLine("        public {0} {1}{2}", f.ReturnValue, f.Name.TrimStart('g', 'l'), f.Parameters.ToString());
                            sw.WriteLine("        {");

                            int i = 0;
                            StringBuilder sb = new StringBuilder();
                            sb.Append("(");
                            foreach (Parameter p in f.Parameters)
                            {
                                if (p.Type == "Object")
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
                                sw.WriteLine("                _{0}{1};", f.Name.TrimStart('g', 'l'), sb.ToString());
                            else
                                sw.WriteLine("                return _{0}{1};", f.Name.TrimStart('g', 'l'), sb.ToString());
                            sw.WriteLine("            }");
                            sw.WriteLine("            finally");
                            sw.WriteLine("            {");
                            while (i > 0)
                            {
                                sw.WriteLine("                h{0}.Free();", --i);
                            }
                            sw.WriteLine("            }");
                            sw.WriteLine("        }");
                            sw.WriteLine();
                        }
                        else
                        {
                            sw.WriteLine("        public {0} {1}{2}", f.ReturnValue, f.Name.TrimStart('g', 'l'), f.Parameters.ToString());
                            sw.WriteLine("        {");
                            sw.WriteLine("            throw new NotImplementedException(\"Wrapper not implemented yet.\");");
                            sw.WriteLine("        }");
                            sw.WriteLine();
                        }
                        //sw.WriteLine("        public static extern {0} {1} {2};", f.ReturnValue, f.Name.TrimStart('g', 'l'), f.ParameterString);
                    }
                }
            }
            */

#endregion

            sw.WriteLine("        #endregion");
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Flush();
            sw.Close();
        }

        #endregion

        Function WeakNameLookup(string name, List<Function> function_list)
        {
            foreach (Function f in FunctionCollection)
            {
                if (f.Name.Contains(name))
                    return f;
            }
            return null;
        }
    }
}
