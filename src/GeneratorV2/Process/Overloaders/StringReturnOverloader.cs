using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using GeneratorV2.Writing;

namespace GeneratorV2.Process.Overloaders
{
    public class StringReturnOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            // See: https://github.com/KhronosGroup/OpenGL-Registry/issues/363
            // These are the only two functions that return strings 2020-12-29
            if (overload.NativeFunction.EntryPoint == "glGetString" ||
                overload.NativeFunction.EntryPoint == "glGetStringi")
            {
                var newReturnName = $"{overload.ReturnVariableName}_str";
                var layer = new StringReturnLayer(newReturnName);
                var returnType = new CSString(Nullable: true);
                newOverloads = new List<Overload>()
                {
                    overload with
                    {
                        NestedOverload = overload, MarshalLayerToNested = layer, ReturnType = returnType,
                        ReturnVariableName = newReturnName
                    }
                };
                return true;
            }
            else
            {
                newOverloads = default;
                return false;
            }
        }

        class StringReturnLayer : IOverloadLayer
        {
            readonly string NewReturnName;

            public StringReturnLayer(string newReturnName)
            {
                NewReturnName = newReturnName;
            }

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine($"string? {NewReturnName};");
            }

            public string WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                writer.WriteLine($"{NewReturnName} = Marshal.PtrToStringAnsi((IntPtr){returnName});");
                return NewReturnName;
            }
        }
    }
}
