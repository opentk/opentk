using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class RefOverloader : IOverloader
    {
        private class Layer : ILayer
        {
            private readonly ILayer _nestedLayer;
            private readonly int _argIndex;

            public Layer(ILayer nestedLayer, int argIndex)
            {
                _nestedLayer = nestedLayer;
                _argIndex = argIndex;
            }

            public void WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var arg = args[_argIndex];
                var refStart = arg.Type.IndexOf("ref ");
                var newType = arg.Type.Substring(refStart + "ref ".Length) + "*";
                var newName = arg.Name + "_ptr";
                writer.WriteLine($"fixed ({newType} {newName} = &{arg.Name})");
                using (writer.Scope())
                {
                    args[_argIndex] = arg.Clone(newType, newName);
                    _nestedLayer.WriteLayer(writer, methodName, args);
                }
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
            var ptrLoc = type.Name.IndexOf('*');
            var c = type?.Length as Constant;
            if (type == null || c == null || c.Value != 1 || ptrLoc == -1)
            {
                return false;
            }

            var typeName = type.Name.Remove(ptrLoc, 1);
            typeName = "ref " + typeName;
            context.Parameters[paramIndex] = new Parameter(new PType(typeName, type.OriginalTypeName, type.Modifier, type.Group, null), parameter.Name);

            topLayer = new Layer(topLayer, paramIndex);
            return true;
        }
    }
}
