using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public class VectorOverloader : IOverloader
    {
        private class InputLayer : ILayer
        {
            private readonly ILayer _nestedLayer;
            private readonly int _argIndex;
            private readonly string _type;

            public InputLayer(ILayer layer, int argIndex, string type)
            {
                _nestedLayer = layer;
                _argIndex = argIndex;
                _type = type;
            }

            public Argument? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var arg = args[_argIndex];
                var newName = arg.Name + "_ptr";
                var newType = _type;

                writer.WriteLine($"{_type} {newName} = &{arg.Name}.X;");

                args[_argIndex] = arg.Clone(newType, newName);

                return _nestedLayer.WriteLayer(writer, methodName, args);
            }
        }

        private class OutputLayer : ILayer
        {
            private readonly ILayer _nestedLayer;
            private readonly int _argIndex;
            private readonly string _type;

            public OutputLayer(ILayer layer, int argIndex, string type)
            {
                _nestedLayer = layer;
                _argIndex = argIndex;
                _type = type;
            }

            public Argument? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var arg = args[_argIndex];
                var newName = arg.Name + "_ptr";
                var newType = _type;

                writer.WriteLine($"{args[_argIndex].Name} = default;");
                writer.WriteLine($"fixed ({_type} {newName} = &{arg.Name}.X)");
                //using (writer.Scope())
                {
                    args[_argIndex] = arg.Clone(newType, newName);

                    return _nestedLayer.WriteLayer(writer, methodName, args);
                }
            }
        }
        public struct Vector2 { public float x, y; }
        public static unsafe void MultiTexCoord2fv(out Vector2 v)
        {
            v = default;
            fixed (float* v_ptr = &v.x)
            {
                MultiTexCoord2fv(v_ptr);
            }
        }

        public unsafe static void MultiTexCoord2fv(float* v)
        {
            MultiTexCoord2fv(v);
        }

        public bool TryOverloadParameter(OverloadContext context, ref ILayer topLayer, int paramIndex)
        {
            var param = context.Parameters[paramIndex];
            var length = param.Type.Length as Constant;
            var ptrLoc = param.Type.Name.IndexOf('*');
            if (length == null || length.Value <= 1 || length.Value > 4 || ptrLoc == -1 /*|| !context.Method.EntryPoint.EndsWith("v")*/)
            {
                return false;
            }

            string newType = "Vector" + length.Value;
            string oldType = param.Type.Name;
            switch (oldType.Remove(ptrLoc).Trim())
            {
                case "float":
                    break;
                case "int":
                    newType += "i";
                    break;
                case "double":
                    newType += "d";
                    break;
                    //TODO: Figure out what to do for these
                case "sbyte":
                    return false;
                case "byte":
                    return false;
                case "short":
                    return false;
                case "ushort":
                    return false;
                case "uint":
                    return false;
                case "IntPtr":
                    return false;
                default:
                    Logger.Warning("No vector type for " + oldType);
                    break;
            }

            if (param.Type.OriginalTypeName.StartsWith("const"))
            {
                topLayer = new InputLayer(topLayer, paramIndex, oldType);
            }
            else
            {
                newType = "out " + newType;
                topLayer = new OutputLayer(topLayer, paramIndex, oldType);
            }
            var type = param.Type;
            context.Parameters[paramIndex] = new Parameter(new PType(newType, type.OriginalTypeName, type.Modifier, type.Group, type.Length),
                param.Name);

            return true;
        }
    }
}
