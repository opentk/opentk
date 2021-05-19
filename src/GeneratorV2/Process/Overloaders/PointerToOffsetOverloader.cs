using System.Collections.Generic;
using System.Linq;
using GeneratorV2.Writing;

namespace GeneratorV2.Process.Overloaders
{
    public sealed class PointerToOffsetOverloader : IOverloader
    {
        private readonly Dictionary<string, string> _methodsAndParametersToOverload = new Dictionary<string, string>
        {
            // Draw elements permutations.
            {"glDrawElements", "indices"},
            {"glDrawElementsBaseVertex", "indices"},
            {"glDrawElementsBaseVertexEXT", "indices"},
            {"glDrawElementsBaseVertexOES", "indices"},
            {"glDrawElementsInstanced", "indices"},
            {"glDrawElementsInstancedANGLE", "indices"},
            {"glDrawElementsInstancedARB", "indices"},
            {"glDrawElementsInstancedBaseInstance", "indices"},
            {"glDrawElementsInstancedBaseInstanceEXT", "indices"},
            {"glDrawElementsInstancedBaseVertex", "indices"},
            {"glDrawElementsInstancedBaseVertexBaseInstance", "indices"},
            {"glDrawElementsInstancedBaseVertexBaseInstanceEXT", "indices"},
            {"glDrawElementsInstancedBaseVertexEXT", "indices"},
            {"glDrawElementsInstancedBaseVertexOES", "indices"},
            {"glDrawElementsInstancedEXT", "indices"},
            {"glDrawElementsInstancedNV", "indices"},
            {"glDrawRangeElements", "indices"},
            {"glDrawRangeElementsBaseVertex", "indices"},
            {"glDrawRangeElementsBaseVertexEXT", "indices"},
            {"glDrawRangeElementsBaseVertexOES", "indices"},
            {"glDrawRangeElementsEXT", "indices"},
            // {"glMultiDrawElements", "indices"},
            // {"glMultiDrawElementsBaseVertex", "indices"},
            // {"glMultiDrawElementsBaseVertexEXT", "indices"},
            // {"glMultiDrawElementsEXT", "indices"},
            // {"glMultiModeDrawElementsIBM", "indices"},

            // Vertex attribute pointer permutations.
            {"glVertexAttribPointer", "pointer"},
            {"glVertexAttribIPointer", "pointer"},
            {"glVertexAttribLPointer", "pointer"},
        };
        public bool TryGenerateOverloads(Overload overload, out List<Overload>? newOverloads)
        {
            if (!_methodsAndParametersToOverload.TryGetValue(overload.NativeFunction.EntryPoint, out var parameterName))
            {
                newOverloads = null;
                return false;
            }

            // Get the parameter index.
            int parameterIndex = -1;
            while (overload.InputParameters[++parameterIndex].Name != parameterName)
            {
                if (parameterIndex >= overload.InputParameters.Length)
                {
                    newOverloads = null;
                    return false;
                }
            }

            NameTable nameTable = overload.NameTable.New();
            Parameter pointerParameter = overload.InputParameters[parameterIndex];
            Parameter offsetParameter = pointerParameter with {Type = new CSType("nint", false), Name = "offset", Length = null};
            Parameter[] newParameters = overload.InputParameters.ToArray();
            newParameters[parameterIndex] = offsetParameter;
            nameTable.Rename(pointerParameter, pointerParameter.Name);
            nameTable.Rename(offsetParameter, offsetParameter.Name);
            newOverloads = new List<Overload>()
            {
                overload with
                {
                    NestedOverload = overload,
                    MarshalLayerToNested = new PointerToOffsetLayer(pointerParameter, offsetParameter),
                    InputParameters = newParameters,
                    NameTable = nameTable
                }
            };
            return true;
        }

        public class PointerToOffsetLayer : IOverloadLayer
        {
            private Parameter _pointerParameter;
            private Parameter _offsetParameter;

            public PointerToOffsetLayer(Parameter pointerParameter, Parameter offsetParameter)
            {
                _pointerParameter = pointerParameter;
                _offsetParameter = offsetParameter;
            }

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine($"{_pointerParameter.Type.ToCSString()} {nameTable[_pointerParameter]} = ({_pointerParameter.Type.ToCSString()}){nameTable[_offsetParameter]};");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                return returnName;
            }
        }
    }
}
