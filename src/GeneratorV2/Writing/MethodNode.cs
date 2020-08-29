using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System.CodeDom.Compiler;
using System.Text;

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
        //private static delegate*<uint, void> CullFace_fnptr = &CullFace_Lazy;
        //public static void CullFace(uint mode)
        //{
        //    CullFace_fnptr(mode);
        //}
        //private static void CullFace_Lazy(uint mode)
        //{
        //    lock(_lock)
        //    {
        //        delegate*<uint, void> lazy = &CullFace_Lazy;
        //        if (CullFace_fnptr == lazy)
        //        {
        //            PreloadCullFace();
        //        }

        //        CullFace_fnptr(mode);
        //    }
        //}
        //private static void PreloadCullFace()
        //{
        //    CullFace_fnptr = _bindingsContext.GetProcAddress("glCullFace");
        //}
        private void WriteMethod(Method m, string name)
        {
            const string lockName = "GLLoader.LockObj";
            const string bindingsName = "GLLoader.BindingsContext";
            var delegateStringBuilder = new StringBuilder();
            var paramStringBuilder = new StringBuilder();
            var paramSignatureStringBuilder = new StringBuilder();

            for (var i = 0; i < m.Parameters.Length; i++)
            {
                var parameter = m.Parameters[i];
                var type = parameter.Type.Name.Replace("const", "").Trim();
                delegateStringBuilder.Append($"{type}, ");

                paramStringBuilder.Append(parameter.Name);
                paramSignatureStringBuilder.Append($"{type} {parameter.Name}");
                if (i != m.Parameters.Length - 1)
                {
                    paramSignatureStringBuilder.Append(", ");
                    paramStringBuilder.Append(", ");
                }
            }
            //Delegate field
            Writer.WriteLine($"//{name}");
            string delegateType = $"delegate*<{delegateStringBuilder}{m.ReturnType.Name}>";
            Writer.WriteLine($"private static {delegateType} _{name}_fnptr = &{name}_Lazy;");
            Writer.WriteLine();

            string paramSignatureList = paramSignatureStringBuilder.ToString();
            string paramList = paramStringBuilder.ToString();

            //Public method
            Writer.WriteLine($"public static {m.ReturnType.Name} {name}({paramSignatureList})");
            using (Writer.Indentation())
            {
                Writer.WriteLine($"=> _{name}_fnptr({paramList});");
            }
            Writer.WriteLine();

            //Preload method
            Writer.WriteLine($"private static void Preload{name}()");
            using (Writer.Indentation())
            {
                Writer.WriteLine($"=> _{name}_fnptr = ({delegateType}){bindingsName}.GetProcAddress(\"{m.EntryPoint}\");");
            }
            Writer.WriteLine();

            //Lazy method
            Writer.WriteLine($"private static {m.ReturnType.Name} {name}_Lazy({paramSignatureList})");
            using (Writer.Scope())
            {
                Writer.WriteLine($"lock ({lockName})");
                using (Writer.Scope())
                {
                    Writer.WriteLine($"if (_{name}_fnptr == ({delegateType})&{name}_Lazy)");
                    using (Writer.Scope())
                    {
                        Writer.WriteLine($"Preload{name}();");
                    }
                }
                if (m.ReturnType.Name != "void")
                {
                    Writer.Write("return ");
                }
                Writer.WriteLine($"_{name}_fnptr({paramList});");
            }
            Writer.WriteLine();
            Writer.WriteLine();




            // Writer.WriteLine($"[DllImport(\"opengl32.dll\", EntryPoint = \"{m.EntryPoint}\")]");
            // Writer.Write($"public static extern {m.ReturnType.Name} {name}(");

            // for (var i = 0; i < m.Parameters.Length; i++)
            // {
            //     var parameter = m.Parameters[i];
            //     var type = parameter.Type.Name.Replace("const", "").Trim();
            //     Writer.Write($"{type} {parameter.Name}");
            //     if (i != m.Parameters.Length - 1)
            //     {
            //         Writer.Write(", ");
            //     }
            // }
            // Writer.WriteLine(");");
            // Writer.WriteLine();
        }
    }
}
