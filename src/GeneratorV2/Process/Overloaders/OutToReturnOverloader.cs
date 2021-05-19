using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using GeneratorV2.Writing;

namespace GeneratorV2.Process.Overloaders
{
    public class OutToReturnOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            var oldParameters = overload.InputParameters;
            if (overload.ReturnType is not CSVoid || oldParameters.Length == 0)
            {
                newOverloads = null;
                return false;
            }

            // Find the one and only out param, if there are more we do an early return.
            Parameter[] newParameters = new Parameter[oldParameters.Length - 1];
            Parameter? outParameter = null;
            CSRef? outType = null;
            for (int i = 0; i < oldParameters.Length; i++)
            {
                var parameter = oldParameters[i];
                if (parameter.Type is CSRef pRef && pRef.RefType == CSRef.Type.Out)
                {
                    if (outParameter != null)
                    {
                        newOverloads = null;
                        return false;
                    }

                    outType = pRef;
                    outParameter = parameter;
                }
                else if (i != oldParameters.Length - 1)
                {
                    newParameters[outParameter != null ? i + 1 : i] = parameter;
                }
            }

            if (outType == null || outParameter == null)
            {
                newOverloads = null;
                return false;
            }

            newOverloads = new List<Overload>()
            {
                overload with { NestedOverload = overload, InputParameters = newParameters,
                    ReturnType = outType!.ReferencedType, MarshalLayerToNested = new OutToReturnOverloadLayer(outParameter, outType)},
                overload,
            };
            return true;
        }

        private class OutToReturnOverloadLayer : IOverloadLayer
        {
            public readonly Parameter OutParameter;
            public readonly CSRef OutType;

            public OutToReturnOverloadLayer(Parameter outParameter, CSRef outType)
            {
                OutParameter = outParameter;
                OutType = outType;
            }

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine($"{OutType.ReferencedType.ToCSString()} {nameTable[OutParameter]};");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                return OutParameter.Name;
            }
        }
    }
}
