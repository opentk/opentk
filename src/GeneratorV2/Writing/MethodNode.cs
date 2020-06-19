using GeneratorV2.Data;
using System.CodeDom.Compiler;

namespace GeneratorV2.Writing
{
    public class MethodNode : OverloadNode
    {
        public MethodNode(Command command) : base(command) { }

        public override void Write()
        {
            if (_command.IsHandleArb)
            {
                WriteMethodHandleArb();
            }
            else
            {
                WriteMethod(_command.Method, _command.Name);
            }
        }

        private void WriteMethodHandleArb()
        {
            var handle = (HandleARBCommand)_command;
            WriteMethod(handle.Apple, $"__APPLE_{_command.Name}");
            WriteMethod(handle.Method, $"__GOOD_{_command.Name}");
            WriteOverload(handle.BaseOverload);
        }

        private void WriteMethod(Method m, string name)
        {
            Writer.WriteLine($"[DllImport(\"opengl32.dll\", EntryPoint = \"{m.EntryPoint}\")]");
            Writer.Write($"public static extern {m.ReturnType.Name} {name}(");

            for (var i = 0; i < m.Parameters.Length; i++)
            {
                var parameter = m.Parameters[i];
                var type = parameter.Type.Name.Replace("const", "").Trim();
                Writer.Write($"{type} {parameter.Name}");
                if (i != m.Parameters.Length - 1)
                {
                    Writer.Write(", ");
                }
            }
            Writer.WriteLine(");");
            Writer.WriteLine();
        }
    }
}
