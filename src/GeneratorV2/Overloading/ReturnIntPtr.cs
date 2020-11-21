using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class IntPtrReturnOverloader : IOverloader
    {
        private class Layer : ILayer
        {
            private readonly ILayer _nestedLayer;

            public Layer(ILayer layer)
            {
                _nestedLayer = layer;
            }

            public Argument? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var returnValue = _nestedLayer.WriteLayer(writer, methodName, args);
                var newReturnName = returnValue.Name + "_iptr";
                writer.WriteLine($"IntPtr {newReturnName} = (IntPtr){returnValue.Name};");
                return returnValue.Clone("IntPtr", newReturnName);
            }
        }

        public bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int paramIndex)
        {
            var type = context.ReturnType;
            var ptrLoc = type.Name.IndexOf('*');
            if (ptrLoc == -1 || !(type.OriginalTypeName.Contains("void") || type.OriginalTypeName.Contains("byte")))
            {
                return false;
            }

            context.ReturnType = new PType("IntPtr", type.OriginalTypeName, type.Modifier, type.Group, type.Length);
            topLayer = new Layer(topLayer);
            return true;
        }
    }
}
