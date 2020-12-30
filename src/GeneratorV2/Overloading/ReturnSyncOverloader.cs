using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    /*public class ReturnSyncOverloader : IOverloader
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
                var newName = returnValue.Name + "_obj";
                writer.WriteLine($"GLsyncObject {newName} = {returnValue.Name};");
                return returnValue.Clone("GLsyncObject", newName);
            }
        }

        public bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int paramIndex)
        {
            var type = context.ReturnType;
            if (type.Group != "sync" || !type.Name.Contains("GLsync*"))
            {
                return false;
            }

            context.ReturnType = new PType("GLsyncObject", type.OriginalTypeName, type.Modifier, type.Group, type.Length);
            topLayer = new Layer(topLayer);
            return true;
        }
    }*/
}
