using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OpenTK.OpenGL.Bind
{
    static class ContextWriter
    {
        public static void WriteMainContext(string output_path, List<Function> functions)
        {
            string filename = Path.Combine(output_path, "ContextLoad.cs");

            if (!Directory.Exists(Settings.OutputPath))
                Directory.CreateDirectory(Settings.OutputPath);

            StreamWriter sw = new StreamWriter(filename, false);

            Console.WriteLine("Writing Context.Load() function to {1}", Settings.OutputClass, filename);

            SpecWriter.WriteLicense(sw);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine();
            sw.WriteLine("namespace {0}", Settings.OutputNamespace);
            sw.WriteLine("{");
            sw.WriteLine("    public abstract partial class Context");
            sw.WriteLine("    {");

            sw.WriteLine("        #region OpenGL function loading");
            sw.WriteLine();
            sw.WriteLine("        public virtual void Load()");
            sw.WriteLine("        {");

            foreach (Function f in functions)
            {
                sw.WriteLine("            {2}.{0} = ({2}.Delegates.{0})GetAddress(\"gl{1}\", typeof({2}.Delegates.{0}));", f.Name, f.Name.TrimEnd('_'), Settings.OutputClass);
            }

            sw.WriteLine("        }");
            sw.WriteLine("        #endregion");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.WriteLine();

            sw.Flush();
            sw.Close();
        }

        public static void WriteDerivedContext(string output_path, string class_name, List<Function> functions, params string[] import_list)
        {
            string filename = Path.Combine(output_path, class_name + "Load.cs");

            if (!Directory.Exists(Settings.OutputPath))
                Directory.CreateDirectory(Settings.OutputPath);

            StreamWriter sw = new StreamWriter(filename, false);

            Console.WriteLine("Writing {0}.Load() function to {1}", class_name, filename);

            SpecWriter.WriteLicense(sw);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine();
            sw.WriteLine("namespace {0}.Platform", Settings.OutputNamespace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class {0}", class_name);
            sw.WriteLine("    {");

            sw.WriteLine("        #region OpenGL core and extension function loading");
            sw.WriteLine();
            sw.WriteLine("        public override void Load()");
            sw.WriteLine("        {");
            sw.WriteLine("            base.Load();");

            foreach (Function f in functions)
            {
                if (IsImportFunction(f, import_list))
                    sw.WriteLine("            {0}.{1} = new {0}.Delegates.{1}({0}.Imports.{1});", Settings.OutputClass, f.Name);
            }

            sw.WriteLine("        }");
            sw.WriteLine("        #endregion");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.WriteLine();

            sw.Flush();
            sw.Close();
        }

        #region IsImport
        private static bool IsImportFunction(Function f, string[] import_list)
        {
            if (f.Extension)
                return false;

            foreach (string version in import_list)
                if (f.Version == version)
                    return true;

            return false;
        }
        #endregion
    }
}
