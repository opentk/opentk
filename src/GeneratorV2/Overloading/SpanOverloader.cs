using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class SpanOverloader : IOverloader
    {
        private class Layer : ILayer 
        {
            private readonly ILayer _nestedLayer;
            private readonly int _lenIndex, _argIndex;

            public Layer(ILayer nestedLayer, int argIndex, int lenIndex)
            {
                _nestedLayer = nestedLayer;
                _argIndex = argIndex;
                _lenIndex = lenIndex;
            }

            public void WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var spanArg = args[_argIndex];

                int sInd = spanArg.Type.IndexOf('<');
                int eInd = spanArg.Type.LastIndexOf('>');

                var newType = spanArg.Type.Substring(sInd + 1, eInd - sInd - 1) + "*";
                args[_argIndex] = spanArg.Clone(newType, $"{spanArg.Name}_ptr");
                var lenArg = args[_lenIndex];

                writer.WriteLine($"{lenArg.Type} {lenArg.Name} = ({lenArg.Type}){spanArg.Name}.Length;");
                writer.WriteLine($"fixed ({newType} {spanArg.Name}_ptr = {spanArg.Name})");
                using (writer.Scope())
                {

                    _nestedLayer.WriteLayer(writer, methodName, args);
                }
            }
        }

        public bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int i)
        {
            var parameter = context.Parameters[i];
            var type = parameter.Type;
            if (type.Length == null)
            {
                return false;
            }

            
            var lenIdx = Array.FindIndex(context.Parameters, p => p != null && p.Name == type.Length);
            if (lenIdx == -1)//TODO: Compsize etc.
            {
                Logger.Warning($"Method \"{context.Command.Name}\" is missing param \"{type.Length}\"");
                return false;
            }
            context.Parameters[lenIdx] = null;
            var elementType = type.Name.Remove(type.Name.Length - 1);
            if (elementType == "void")
            {
                elementType = $"T{++context.TypeParameterCount}";
            }
            context.Parameters[i] = new Parameter(new PType((type.Modifier == PModifier.ReadOnlySpan ? "ReadOnly" : string.Empty) + $"Span<{elementType}>", type.OriginalTypeName,
                type.Modifier, type.Group, type.Length), parameter.Name);

            topLayer = new Layer(topLayer, i, lenIdx);
            return true;
        }
    }

    /*
     * public extern unsafe void Test(int* array, int count);
     * 
     * void Test(Span<int> array)
     * {
     *      int count = array.Length;
     *      fixed (var array_ptr = &array.GetPinnableReference())
     *      {
     *          Test(array_ptr, count);
     *      }
     * }
    */
}
