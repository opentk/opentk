
using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class StringSpanOverloader : IOverloader
    {
        private class Layer : ILayer
        {
            private readonly ILayer _nestedLayer;
            private readonly int _argIndex;

            public Layer(ILayer layer, int argIndex)
            {
                _nestedLayer = layer;
                _argIndex = argIndex;
            }

            public Argument? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var arg = args[_argIndex];
                var newName = arg.Name + "_strarr";
                var newType = "Span<IntPtr>";
                writer.WriteLine($"{newType} {newName} = stackalloc IntPtr[{arg.Name}.Length];");
                writer.WriteLine($"for (int i = 0; i < {arg.Name}.Length; i++)");
                //using (writer.Scope())
                {
                    writer.WriteLine($"{newName}[i] = Marshal.StringToCoTaskMemUTF8({arg.Name}[i]);");
                }
                args[_argIndex] = arg.Clone(newType, newName);
                var returnValue = _nestedLayer.WriteLayer(writer, methodName, args);
                writer.WriteLine($"for (int i = 0; i < {newName}.Length; i++)");
                //using (writer.Scope())
                {
                    writer.WriteLine($"Marshal.FreeCoTaskMem({newName}[i]);");
                }
                return returnValue;
            }
        }

        public bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int paramIndex)
        {
            var parameter = context.Parameters[paramIndex];
            if (parameter == null)
            {
                return false;
            }
            var type = parameter.Type;
            if (type == null || type.Name != "Span<IntPtr>" || !type.OriginalTypeName.Contains("GLchar"))
            {
                return false;
            }

            context.Parameters[paramIndex] = new Parameter(new PType("Span<string>", type.OriginalTypeName, type.Modifier, type.Group, type.Length), parameter.Name);
            topLayer = new Layer(topLayer, paramIndex);
            return true;
        }
    }
}
