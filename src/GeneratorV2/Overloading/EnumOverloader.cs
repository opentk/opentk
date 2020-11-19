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
        private class Layer : ILayer
        {
            private readonly ILayer _nestedLayer;   
            private readonly string _argName;
            private readonly string _typeName;
            private readonly int _argIndex;

            public Layer(ILayer nestedLayer, int argIndex, string argName, string typeName)
            {
                _nestedLayer = nestedLayer;
                _argIndex = argIndex;
                _argName = argName;
                _typeName = typeName;
            }


            public string? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var arg = args[_argIndex];
                args[_argIndex] = arg.Clone(_typeName, _argName);

                writer.WriteLine($"var {_argName} = ({_typeName}){arg.Name};");

                return _nestedLayer.WriteLayer(writer, methodName, args);
            }
        }

        public bool TryOverloadParameter(OverloadContext context, ref ILayer currentLayer, int i)
        {
            var parameter = context.Parameters[i];
            if (parameter == null)
            {
                return false;
            }
            var type = parameter.Type;

            if (!(type.OriginalTypeName.Contains("GLenum") && type.Name.Contains("uint")))
            {
                return false;
            }
            var argName = parameter.Name + "_value";
            context.Parameters[i] = new Parameter(new PType(type.Name.Replace("uint", "All"), type.OriginalTypeName,
                type.Modifier, type.Group, type.Length), parameter.Name);

            currentLayer = new Layer(currentLayer, i, argName, type.Name);
            return true;
        }
    }
}
