using GeneratorV2.Data;
using GeneratorV2.Parsing;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class EnumOverloader : IOverloader
    {
        /*private class Layer : ILayer
        {
            private readonly string _paramName;
            private readonly string _argName;
            private readonly ILayer _nestedLayer;

            public Layer(ILayer nestedLayer, string paramName, string argName)
            {
                _nestedLayer = nestedLayer;
                _paramName = paramName;
                _argName = argName;
            }
            public void WriteLayer(IndentedTextWriter writer)
            {
                writer.WriteLayer($"var {_argName} = (uint){_paramName};")
                _nestedLayer.WriteLayer(writer);
            }
        }*/

        public bool TryOverloadParameter(OverloadContext context, ref ILayer currentLayer, int i)
        {
            var parameter = context.Parameters[i];
            var type = parameter.Type;

            if (!(type.OriginalTypeName.Contains("GLenum") && type.Name.Contains("uint")))
            {
                return false;
            }
            context.Arguments[i] = $"({type.Name})({parameter.Name})";
            context.Parameters[i] = new Parameter(new PType(type.Name.Replace("uint", "All"), type.OriginalTypeName,
                type.Modifier, type.Group, type.Length), parameter.Name);
            return true;
        }
    }
}
