using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class SyncOverloader : IOverloader
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
                var newName = arg.Name + "_obj";
                writer.WriteLine($"GLsyncObject {newName} = {arg.Name};");
                args[_argIndex] = arg.Clone("GLsyncObject", newName);
                return _nestedLayer.WriteLayer(writer, methodName, args);
            }
        }

        public bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int paramIndex)
        {
            var param = context.Parameters[paramIndex];
            if (param.Type.Group != "sync" || !param.Type.Name.Contains("GLsync*"))
            {
                return false;
            }

            var type = param.Type;
            context.Parameters[paramIndex] = new Parameter(new PType("GLsyncObject", type.OriginalTypeName, type.Modifier, type.Group, type.Length), param.Name);
            topLayer = new Layer(topLayer, paramIndex);
            return true;
        }
    }
}
