using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using GeneratorV2.Writing;

namespace GeneratorV2.Process.Overloaders
{
    public class StringOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            List<Parameter> newParams = new List<Parameter>(overload.InputParameters);
            Overload newOverload = overload;
            for (int i = newParams.Count - 1; i >= 0; i--)
            {
                // FIXME: We want to handle sized strings different!!!
                var param = newParams[i];
                if (param.Type is CSPointer pt && pt.BaseType is CSChar8 bt)
                {
                    var pointerParam = newParams[i];
                    var nameTable = newOverload.NameTable.New();
                    nameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");

                    if (bt.Constant)
                    {
                        // FIXME: Can we know if the string is nullable or not?
                        newParams[i] = newParams[i] with {Type = new CSString(Nullable: false), Length = null};
                        var stringParams = newParams.ToArray();
                        var stringLayer = new StringLayer(pointerParam, newParams[i]);

                        newOverload = newOverload with
                        {
                            NestedOverload = newOverload, MarshalLayerToNested = stringLayer,
                            InputParameters = stringParams, NameTable = nameTable
                        };
                    }
                    else
                    {
                        int stringParamIndex = i;
                        Parameter? lenParam = null;
                        if (param.Length != null)
                        {
                            string? paramName = IOverloadLayer.GetParameterExpression(param.Length, out var expr);
                            if (paramName == null)
                            {
                                Logger.Info(
                                    $"{overload.NativeFunction.EntryPoint} has a COMPSIZE string length for parameter '{param.Name}'!");
                                continue;
                            }

                            int index = newParams.FindIndex(p => p.Name == paramName);
                            lenParam = newParams[index];
                        }

                        if (lenParam == null)
                        {
                            Logger.Info(
                                $"{overload.NativeFunction.EntryPoint} is missing a len attribute for parameter '{param.Name}'");
                            continue;
                        }

                        // FIXME: Can we know if the string is nullable or not?
                        var stringParam = newParams[stringParamIndex] with
                        {
                            Type = new CSRef(CSRef.Type.Out, new CSString(Nullable: false)), Length = null
                        };
                        newParams[stringParamIndex] = stringParam;

                        var stringParams = newParams.ToArray();
                        var stringLayer = new OutStringLayer(pointerParam, lenParam, stringParam);

                        newOverload = newOverload with
                        {
                            NestedOverload = newOverload, MarshalLayerToNested = stringLayer,
                            InputParameters = stringParams, NameTable = nameTable
                        };
                    }
                }
            }

            if (newOverload == overload)
            {
                // We didn't do any overloading
                newOverloads = default;
                return false;
            }
            else
            {
                newOverloads = new List<Overload>()
                {
                    newOverload,
                };
                return true;
            }
        }

        class StringLayer : IOverloadLayer
        {
            public readonly Parameter PointerParameter;
            public readonly Parameter StringParameter;

            public StringLayer(Parameter pointerParameter, Parameter stringParameter)
            {
                PointerParameter = pointerParameter;
                StringParameter = stringParameter;
            }

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine(
                    $"byte* {nameTable[PointerParameter]} = (byte*)Marshal.StringToCoTaskMemUTF8({nameTable[StringParameter]});");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                writer.WriteLine($"Marshal.FreeCoTaskMem((IntPtr){nameTable[PointerParameter]});");
                return returnName;
            }
        }

        class OutStringLayer : IOverloadLayer
        {
            public readonly Parameter PointerParameter;
            public readonly Parameter StringParameter;
            public readonly Parameter StringLengthParameter;

            public OutStringLayer(Parameter pointerParameter, Parameter stringLengthParameter,
                Parameter stringParameter)
            {
                PointerParameter = pointerParameter;
                StringParameter = stringParameter;
                StringLengthParameter = stringLengthParameter;
            }

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine(
                    $"var {nameTable[PointerParameter]} = (byte*)Marshal.AllocCoTaskMem({nameTable[StringLengthParameter]});");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                writer.WriteLine(
                    $"{nameTable[StringParameter]} = Marshal.PtrToStringUTF8((IntPtr){nameTable[PointerParameter]})!;");
                writer.WriteLine($"Marshal.FreeCoTaskMem((IntPtr){nameTable[PointerParameter]});");
                return returnName;
            }
        }
    }
}
