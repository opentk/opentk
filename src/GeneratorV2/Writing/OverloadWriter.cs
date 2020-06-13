
using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeneratorV2.Writing
{
    public class OverloadWriter : ISingleWriter<Command>
    {
        public virtual void Write(Command input, IndentedTextWriter writer)
        {
            foreach (var o in input.Overloads)
            {
                WriteOverload(writer, o, input.Name);
            }
        }

        protected static void WriteOverload(IndentedTextWriter writer, Overload o, string name)
        {
            writer.Write($"public static {o.ReturnType.Name} {name}(");

            for (var i = 0; i < o.Parameters.Length; i++)
            {
                var parameter = o.Parameters[i];
                var type = parameter.Type.Name.Replace("const", "").Trim();
                writer.Write($"{type} {parameter.Name}");
                if (i != o.Parameters.Length - 1)
                {
                    writer.Write(", ");
                }
            }
            writer.WriteLine(")");
            using (writer.Scope())
            {
                o.BodyWriter(writer, name);
            }
            writer.WriteLine();
        }
    }
}
