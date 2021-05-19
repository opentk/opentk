using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using GeneratorV2.Data;
using GeneratorV2.Writing;

namespace GeneratorV2.Process.Overloaders
{
    public class GenCreateAndDeleteOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            var nativeName = overload.NativeFunction.FunctionName;
            if (!nativeName.StartsWith("Create") && !nativeName.StartsWith("Gen") && !nativeName.StartsWith("Delete") || !nativeName.EndsWith("s"))
            {
                newOverloads = default;
                return false;
            }

            // Here we assume that the last parameter is the pointer parameter.
            var pointerParameter = overload.InputParameters.LastOrDefault();

            if (pointerParameter == null || pointerParameter.Type is not CSPointer pointerParameterType)
            {
                newOverloads = default;
                return false;
            }

            if (pointerParameter.Length == null || pointerParameter.Length is not ParameterReference handleLength)
            {
                newOverloads = default;
                return false;
            }

            var newName = nativeName[..^1];

            int lengthParameterIndex = -1;
            Parameter[] parameters = new Parameter[overload.InputParameters.Length - 1];
            for (var i = 0; i < overload.InputParameters.Length - 1; i++)
            {
                var parameter = overload.InputParameters[i];
                if (parameter.Name.Equals(handleLength.ParameterName))
                {
                    lengthParameterIndex = i;
                }
                else
                {
                    parameters[lengthParameterIndex != -1 ? i + 1 : i] = parameter;
                }
            }

            if (lengthParameterIndex == -1)
                throw new Exception($"Couldnt find len {handleLength.ParameterName} on method {nativeName}");

            var nameTable = overload.NameTable.New();
            nameTable.Rename(pointerParameter, $"{pointerParameter.Name}_handle");

            CSRef.Type refType = nativeName.StartsWith("Delete") ? CSRef.Type.In : CSRef.Type.Out;
            parameters[^1] = pointerParameter with { Type = new CSRef(refType, pointerParameterType.BaseType), Length = null };
            IOverloadLayer layer = refType == CSRef.Type.In ? new DeleteOverloadLayer(overload.InputParameters[lengthParameterIndex], parameters[^1], pointerParameter) :
                new GenAndCreateOverloadLayer(overload.InputParameters[lengthParameterIndex], parameters[^1], pointerParameter);

            newOverloads = new List<Overload>()
            {
                overload with { InputParameters = parameters, NestedOverload = overload, OverloadName = newName, NameTable = nameTable,
                    MarshalLayerToNested = layer},
                overload,
            };
            return true;
        }

        private class DeleteOverloadLayer : IOverloadLayer
        {
            public readonly Parameter LengthParameter;
            public readonly Parameter InParameter;
            public readonly Parameter PointerParameter;

            public DeleteOverloadLayer(Parameter lengthParameter, Parameter inParameter, Parameter pointerParameter)
            {
                LengthParameter = lengthParameter;
                InParameter = inParameter;
                PointerParameter = pointerParameter;
            }

            private CsScope Scope;
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine($"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = 1;");
                writer.WriteLine($"fixed({PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = &{nameTable[InParameter]})");
                Scope = writer.CsScope();
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                Scope.Dispose();
                return returnName;
            }
        }

        private class GenAndCreateOverloadLayer : IOverloadLayer
        {
            public readonly Parameter LengthParameter;
            public readonly Parameter OutParameter;
            public readonly Parameter PointerParameter;

            public GenAndCreateOverloadLayer(Parameter lengthParameter, Parameter outParameter, Parameter pointerParameter)
            {
                LengthParameter = lengthParameter;
                OutParameter = outParameter;
                PointerParameter = pointerParameter;
            }

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine($"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = 1;");
                writer.WriteLine($"Unsafe.SkipInit(out {nameTable[OutParameter]});");
                // FIXME
                writer.WriteLine("// FIXME: This could be a problem for the overloads that take an out parameter");
                writer.WriteLine("// as this parameter could *potentially* move while inside of this function");
                writer.WriteLine("// which would mean that the new value never gets written to the out parameter.");
                writer.WriteLine("// Making for a nasty bug.");
                writer.WriteLine("// The reason we don't use a fixed expression here is because of the \"single out parameter to return value\" overloading step");
                writer.WriteLine("// that will make it so this tries to fix a local variable which is not allowed in C# for some reason.");
                writer.WriteLine("// If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk");
                writer.WriteLine("// - 2021-05-18");

                writer.WriteLine($"{PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = ({PointerParameter.Type.ToCSString()})Unsafe.AsPointer(ref {nameTable[OutParameter]});");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                return returnName;
            }
        }
    }
}
