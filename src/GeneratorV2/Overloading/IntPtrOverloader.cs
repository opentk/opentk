using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class IntPtrOverloader : IOverloader
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

            public void WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var arg = args[_argIndex];
                var newArgName = arg.Name + "_iptr";
                var newTypeName = arg.Type.Replace("IntPtr", "void *");
                writer.WriteLine($"var {newArgName} = ({newTypeName}){arg.Name};");

                args[_argIndex] = arg.Clone(newTypeName, newArgName);

                _nestedLayer.WriteLayer(writer, methodName, args);
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
            var ptrLoc2 = type.Name.IndexOf('*', ptrLoc + 1);
            if (ptrLoc == -1 || ptrLoc2 == -1 || !type.Name.Contains("void"))
            {
                return false;
            }

            var newTypeName = type.Name.Remove(ptrLoc, 1).Replace("void", "IntPtr");
            context.Parameters[paramIndex] = new Parameter(new PType(newTypeName, type.OriginalTypeName, type.Modifier, type.Group, type.Length), parameter.Name);

            topLayer = new Layer(topLayer, paramIndex);
            return true;
        }
    }
}
