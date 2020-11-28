using GeneratorV2.Data;
using GeneratorV2.Writing2;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeneratorV2.Writing
{
    class Writer2
    {
        public static void Write(OutputData data)
        {
            IndentedTextWriter writer = new IndentedTextWriter(new StreamWriter(File.OpenWrite("./TestOutput.cs")));
            writer.WriteLine($"public static unsafe class Test {{");
            writer.Indent++;

            NativeMethods.WriteNativeFunctions(writer, data.Versions[0].Functions);

            writer.Indent--;
            writer.WriteLine($"}}");

            foreach (var group in data.Versions[0].EnumGroups)
            {
                if (group.Flags) writer.WriteLine($"[Flags]");
                writer.WriteLine($"public enum {group.Name} {{");
                writer.Indent++;

                WriteEnumGroup(writer, group);

                writer.Indent--;
                writer.WriteLine($"}}");
            }
        }

        public static void WriteEnumGroup(IndentedTextWriter writer, EnumGroup group)
        {
            foreach (var member in group.Members)
            {
                writer.WriteLine($"{member.Name} = {member.Value},");
            }
        }
    }
}
