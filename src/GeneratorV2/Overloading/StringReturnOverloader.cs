using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class StringReturnOverloader : IOverloader
    {
        private class Layer : ILayer
        {
            private readonly ILayer _nestedLayer;
            private readonly int _argIndex;

            public Layer(ILayer layer)
            {
                _nestedLayer = layer;
            }

            public string? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var returnName = _nestedLayer.WriteLayer(writer, methodName, args);
                var newReturnName = returnName + "_str";
                writer.WriteLine($"var {newReturnName} = Marshal.PtrToStringAnsi((IntPtr){returnName});");
                return newReturnName;
            }
        }

        public bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int paramIndex)
        {
            var type = context.Command.Method.ReturnType;
            if (paramIndex != -1 || type.Group != "String" || type.Name != "byte*")
            {
                return false;
            }

            context.ReturnType = new PType("string?", type.OriginalTypeName, type.Modifier, type.Group, type.Length);
            topLayer = new Layer(topLayer);
            return true;
        }
    }
}
