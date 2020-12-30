using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GeneratorV2.Overloading
{
    /*public class StringOverloader : IOverloader
    {
        private class InputLayer : ILayer
        {
            private readonly ILayer _nestedLayer;
            private readonly int _argIndex;

            public InputLayer(ILayer layer, int argIndex)
            {
                _nestedLayer = layer;
                _argIndex = argIndex;
            }

            public Argument? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var arg = args[_argIndex];
                var ptrName = arg.Name + "_iptr";
                var strName = arg.Name + "_str";
                writer.WriteLine($"var {ptrName} = Marshal.StringToCoTaskMemUTF8({arg.Name});");
                writer.WriteLine($"var {strName} = (byte*){ptrName};");
                args[_argIndex] = arg.Clone("byte*", strName);
                var returnValue = _nestedLayer.WriteLayer(writer, methodName, args);
                writer.WriteLine($"Marshal.FreeCoTaskMem((IntPtr){ptrName});");
                return returnValue;
            }
        }
        private class OutputLayer : ILayer
        {
            private readonly ILayer _nestedLayer;
            private readonly int _argIndex;
            private readonly int _lenIdx;

            public OutputLayer(ILayer layer, int argIndex, int lenIdx)
            {
                _nestedLayer = layer;
                _argIndex = argIndex;
                _lenIdx = lenIdx;
            }

            public Argument? WriteLayer(IndentedTextWriter writer, string methodName, Argument[] args)
            {
                var arg = args[_argIndex];
                var ptrName = arg.Name + "_iptr";
                var strName = arg.Name + "_str";

                writer.WriteLine($"var {ptrName} = Marshal.AllocCoTaskMem({args[_lenIdx].Name});");
                writer.WriteLine($"var {strName} = (byte*){ptrName};");
                args[_argIndex] = arg.Clone("byte*", strName);
                var returnValue = _nestedLayer.WriteLayer(writer, methodName, args);
                writer.WriteLine($"{arg.Name} = Marshal.PtrToStringUTF8({ptrName});");
                writer.WriteLine($"Marshal.FreeCoTaskMem({ptrName});");
                return returnValue;
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
            if (type == null || ptrLoc == -1 || type.Name.Remove(ptrLoc, 1).Trim() != "byte" || !type.OriginalTypeName.Contains("GLchar"))
            {
                return false;
            }

            if (type.OriginalTypeName.Contains("const"))
            {

                if (type.Length != null)
                {
                    return false;
                }
                context.Parameters[paramIndex] = new Parameter(new PType("string", type.OriginalTypeName, type.Modifier, type.Group, type.Length), parameter.Name);
                topLayer = new InputLayer(topLayer, paramIndex);
            }
            else
            {
                // TODO: verify that it is always an out param

                var pRef = type.Length as ParameterReference;
                if (pRef != null)
                {
                    throw new Exception("!!!!");
                    //var lenIdx = pRef.ParameterIndex;
                    context.Parameters[paramIndex] = new Parameter(new PType("out string", type.OriginalTypeName, type.Modifier, type.Group, type.Length), parameter.Name);
                    throw new Exception("!!!!");
                    //topLayer = new OutputLayer(topLayer, paramIndex, lenIdx);
                }
                else
                {
                    //TODO: Calculate a compsize here
                    return false;
                }
            }
            return true;
        }

        public unsafe static void GetShaderSource(uint shader, int bufSize, ref int length, out string source)
        {
            var source_iptr = Marshal.AllocCoTaskMem(bufSize);
            var source_str = (byte*)source_iptr;
            fixed (int* length_ptr = &length)
            {
                GetShaderSource(shader, bufSize, length_ptr, source_str);
            }
            source = Marshal.PtrToStringUTF8(source_iptr);
            Marshal.FreeCoTaskMem(source_iptr);
        }


        public unsafe static void GetShaderSource(uint shader, int bufSize, int* length, byte* source)
        {
        }
    }*/
}
