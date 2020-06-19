
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
            Writer.Write($"public static {o.ReturnType.Name} {_command.Name}(");

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
            using (Writer.Scope())
            {
                o.BodyWriter(Writer, _command.Name);
            }
            Writer.WriteLine();
        }
    }
}
