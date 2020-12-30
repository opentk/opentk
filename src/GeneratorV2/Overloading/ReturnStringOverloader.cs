using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    /*public class ReturnStringOverloader : IOverloader
    {
        private class Layer : ILayer
        {
            private readonly ILayer _nestedLayer;
            private readonly int _argIndex;

            public Layer(ILayer layer)
            {
                _nestedLayer = layer;
            }

            public Argument? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var returnValue = _nestedLayer.WriteLayer(writer, methodName, args);
                var newReturnName = returnValue.Name + "_str";
                writer.WriteLine($"string? {newReturnName} = Marshal.PtrToStringAnsi({returnValue.Name});");
                return returnValue.Clone("string?", newReturnName);
            }
        }

        public bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int paramIndex)
        {
            var type = context.ReturnType;
            if (paramIndex != -1 || type.Group != "String" || type.Name != "IntPtr")
            {
                return false;
            }

            context.ReturnType = new PType("string?", type.OriginalTypeName, type.Modifier, type.Group, type.Length);
            topLayer = new Layer(topLayer);
            return true;
        }
    }*/
}
