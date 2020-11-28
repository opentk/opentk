using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorV2.Writing2
{
    class NativeMethods
    {
        public static void WriteNativeFunctions(IndentedTextWriter writer, List<NativeFunction> nativeFunctions)
        {
            // Write delegate field initialized to the lazy loader.
            // Write public function definition that calls delegate.
            // Write lazy loader function.

            StringBuilder delegateType = new StringBuilder();
            foreach (var function in nativeFunctions)
            {
                delegateType.Clear();

                foreach (var parameter in function.Parameters)
                {
                    delegateType.Append(parameter.Type.Type);
                    delegateType.Append(',');
                }

                delegateType.Append(function.ReturnType.Type);

                writer.WriteLine($"private static delegate*<{delegateType}> _{function.Name}_fnptr;");
            }
        }
    }
}
