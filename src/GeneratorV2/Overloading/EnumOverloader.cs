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
