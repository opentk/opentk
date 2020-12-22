
using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace GeneratorV2.Writing
{
    public class OverloadNode : WriterNode
    {
        protected readonly Command _command;

        public OverloadNode(Command command)
        {
            _command = command;
        }

        public override void Write()
        {
            foreach (var o in _command.Overloads)
            {
                WriteOverload(o);
            }
        }

        protected void WriteOverload(Overload o)
        {
            Writer.Write($"public static {o.ReturnType.Name} {_command.Name}");
            if (o.TypeParameterCount > 0)
            {
                Writer.Write("<");
                for (int i = 1; i <= o.TypeParameterCount; i++)
                {
                    Writer.Write("T" + i);
                    if (i != o.TypeParameterCount)
                    {
                        Writer.Write(", ");
                    }
                }
                Writer.Write(">");
            }
            Writer.Write("(");

            for (var i = 0; i < o.Parameters.Length; i++)
            {
                var parameter = o.Parameters[i];
                var type = parameter.Type.Name.Replace("const", "").Trim();
                Writer.Write($"{type} {parameter.Name}");
                if (i != o.Parameters.Length - 1)
                {
                    Writer.Write(", ");
                }
            }
            Writer.WriteLine(")");

            if (o.TypeParameterCount > 0)
            {
                //using (IndentationExtension.Indentation(Writer))
                {
                    for (int i = 1; i <= o.TypeParameterCount; i++)
                    {
                        Writer.WriteLine($"where T{i} : unmanaged");
                    }
                }
            }

            //using (Writer.Scope())
            {
                //o.BodyWriter(Writer, _command.Name);
            }
            Writer.WriteLine();
        }
    }
}
