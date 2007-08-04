using System;
using System.Collections.Generic;
using System.Text;
using Bind.Structures;
using System.Diagnostics;

namespace Bind.GL2
{
    class SpecWriter : ISpecWriter
    {
        #region --- ISpecWriter Members ---

        #region void WriteDelegates

        public void WriteDelegates(BindStreamWriter sw, DelegateCollection delegates)
        {
            Trace.WriteLine(String.Format("Writing delegates to {0}.{1}", Settings.OutputNamespace, Settings.DelegatesClass));

            sw.WriteLine();
            sw.WriteLine("internal static class {0}", Settings.DelegatesClass);
            sw.WriteLine("{");

            sw.Indent();
            // Disable BeforeFieldInit
            sw.WriteLine("static {0}()", Settings.DelegatesClass);
            sw.WriteLine("{");
            // --- Workaround for mono gmcs 1.2.4 issue, where static initalization fails. ---
            sw.Indent();
            sw.WriteLine("{0}.ReloadFunctions();", Settings.GLClass);
            sw.Unindent();
            // --- End workaround ---
            sw.WriteLine("}");
            sw.WriteLine();
            foreach (Bind.Structures.Delegate d in delegates.Values)
            {
                sw.WriteLine("[System.Security.SuppressUnmanagedCodeSecurity()]");
                sw.WriteLine("internal {0};", d.ToString());
                if (d.Extension == "Core")
                {
                    /*sw.WriteLine(
                        "internal {0}static {1} gl{1} = ({1}){2}.{3}(\"gl{1}\", typeof({1})) ?? new {1}({4}.{1});",
                        d.Unsafe ? "unsafe " : "",
                        d.Name,
                        Settings.GLClass,
                        "GetDelegateForExtensionMethod",
                        Settings.ImportsClass);*/
                    // --- Workaround for mono gmcs 1.2.4 issue, where static initalization fails. ---
                    sw.WriteLine(
                        "internal {0}static {1} gl{1} = null;",
                        d.Unsafe ? "unsafe " : "",
                        d.Name);
                    // --- End workaround ---
                }
                else
                {
                    sw.WriteLine(
                        "internal {0}static {1} gl{1} = ({1}){2}.{3}(\"gl{1}\", typeof({1}));",
                        d.Unsafe ? "unsafe " : "",
                        d.Name,
                        Settings.GLClass,
                        "GetDelegateForExtensionMethod");
                }
            }
            sw.Unindent();

            sw.WriteLine("}");
        }

        #endregion

        #region void WriteImports

        public void WriteImports(BindStreamWriter sw, DelegateCollection delegates)
        {
            Trace.WriteLine(String.Format("Writing imports to {0}.{1}", Settings.OutputNamespace, Settings.ImportsClass));

            sw.WriteLine();
            sw.WriteLine("internal static class {0}", Settings.ImportsClass);
            sw.WriteLine("{");

            sw.Indent();
            sw.WriteLine("static {0}() {1} {2}", Settings.ImportsClass, "{", "}");    // Disable BeforeFieldInit
            sw.WriteLine();
            foreach (Bind.Structures.Delegate d in delegates.Values)
            {
                sw.WriteLine("[System.Security.SuppressUnmanagedCodeSecurity()]");
                sw.WriteLine(
                    "[System.Runtime.InteropServices.DllImport({0}.Library, EntryPoint = \"gl{1}\", ExactSpelling = true)]",
                    Settings.GLClass,
                    d.Name
                );
                sw.WriteLine("internal extern static {0};", d.DeclarationString());
            }
            sw.Unindent();

            sw.WriteLine("}");
        }

        #endregion

        #region void WriteWrappers

        public void WriteWrappers(BindStreamWriter sw, FunctionCollection wrappers, Dictionary<string, string> CSTypes)
        {
            Trace.WriteLine(String.Format("Writing wrappers to {0}.{1}", Settings.OutputNamespace, Settings.GLClass));

            sw.WriteLine();
            sw.WriteLine("public static partial class {0}", Settings.GLClass);
            sw.WriteLine("{");

            sw.Indent();
            sw.WriteLine("static {0}() {1} {2}", Settings.GLClass, "{", "}");    // Disable BeforeFieldInit
            sw.WriteLine();
            foreach (string key in wrappers.Keys)
            {
                if (Settings.Compatibility == Settings.Legacy.None && key != "Core")
                {
                    sw.WriteLine("public static class {0}", key);
                    sw.WriteLine("{");
                    sw.Indent();
                }

                foreach (Function f in wrappers[key])
                {
                    if (!f.CLSCompliant)
                    {
                        sw.WriteLine("[System.CLSCompliant(false)]");
                    }
                    sw.WriteLine("public static ");
                    sw.Write(f);
                    sw.WriteLine();
                }

                if (Settings.Compatibility == Settings.Legacy.None && key != "Core")
                {
                    sw.Unindent();
                    sw.WriteLine("}");
                    sw.WriteLine();
                }
            }
            sw.Unindent();
            sw.WriteLine("}");
        }

        #endregion

        #region void WriteTypes

        public void WriteTypes(BindStreamWriter sw, Dictionary<string, string> CSTypes)
        {
            sw.WriteLine("using System;");
            sw.WriteLine();
            foreach (string s in CSTypes.Keys)
            {
                sw.WriteLine("using {0} = System.{1};", s, CSTypes[s]);
            }
        }

        #endregion

        #region void WriteEnums

        public void WriteEnums(BindStreamWriter sw, EnumCollection enums)
        {
            Trace.WriteLine(String.Format("Writing enums to {0}.{1}", Settings.OutputNamespace, Settings.GLClass));

            if (Settings.Compatibility == Settings.Legacy.None)
            {
                sw.WriteLine("public class Enums");
                sw.WriteLine("{");

                sw.Indent();
                foreach (Bind.Structures.Enum @enum in enums.Values)
                {
                    sw.Write(@enum);
                    sw.WriteLine();
                }
                sw.Unindent();

                sw.WriteLine("}");
            }
            else if (Settings.Compatibility == Settings.Legacy.Tao)
            {
                // Tao legacy mode: dump all enums as constants in GLClass.
                foreach (Bind.Structures.Constant c in enums[Settings.CompleteEnumName].ConstantCollection.Values)
                {
                    // Print constants avoiding circular definitions
                    if (c.Name != c.Value)
                    {
                        sw.WriteLine(String.Format(
                            "public const int {0} = {2}((int){1});",
                            c.Name.StartsWith("GL_") ? c.Name : "GL_" + c.Name,
                            Char.IsDigit(c.Value[0]) ? c.Value : c.Value.StartsWith("GL_") ? c.Value : "GL_" + c.Value,
                            c.Unchecked ? "unchecked" : ""));
                    }
                    else
                    {
                    }
                }
            }
        }

        #endregion

        #endregion
    }
}
