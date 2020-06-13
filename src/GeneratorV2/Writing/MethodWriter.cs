using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System.CodeDom.Compiler;
using System.IO;

namespace GeneratorV2.Writing
{
    public class MethodWriter : OverloadWriter
    {
        public void Write(string namespaceName, string outputPath, CommandEnumCollection input)
        {
            using var stream = new FileStream(outputPath, FileMode.Create);
            using var streamWriter = new StreamWriter(stream);
            using var writer = new IndentedTextWriter(streamWriter);

            WriterUtility.WriteUsings(writer);

            writer.WriteLine("namespace " + namespaceName);
            using (writer.Scope())
            {
                writer.WriteLine("public unsafe static partial class GL");
                using (writer.Scope())
                {
                    foreach (var (cName, c) in input.Commands)
                    {
                        WriteMethod(writer, c);
                    }
                }
            }
        }

        private static void WriteMethod(IndentedTextWriter writer, Command c)
        {
            if (c.IsHandleArb)
            {
                var handle = (HandleARBCommand)c;
                WriteMethod(writer, handle.Apple, $"__APPLE_{c.Name}");
                WriteMethod(writer, handle.Method, $"__GOOD_{c.Name}");
                WriteOverload(writer, handle.BaseOverload, c.Name);
                return;
            }

            WriteMethod(writer, c.Method, c.Name);
        }

        private static void WriteMethod(IndentedTextWriter writer, Method m, string name)
        {
            writer.WriteLine($"[DllImport(\"opengl32.dll\", EntryPoint = \"{m.EntryPoint}\")]");
            writer.Write($"public static extern {m.ReturnType.Name} {name}(");

            for (var i = 0; i < m.Parameters.Length; i++)
            {
                var parameter = m.Parameters[i];
                var type = parameter.Type.Name.Replace("const", "").Trim();
                writer.Write($"{type} {parameter.Name}");
                if (i != m.Parameters.Length - 1)
                {
                    writer.Write(", ");
                }
            }
            writer.WriteLine(");");
            writer.WriteLine();
        }
    }
}
