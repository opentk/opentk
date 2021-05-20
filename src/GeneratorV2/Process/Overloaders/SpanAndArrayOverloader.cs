using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using GeneratorV2.Writing;

namespace GeneratorV2.Process.Overloaders
{
    public class SpanAndArrayOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            // FIXME: We want to be able to handle more than just one Span and Array overload
            // functions like "glShaderSource" can take more than one array.
            //
            List<Parameter> newParams = new List<Parameter>(overload.InputParameters);
            var genericTypes = overload.GenericTypes;
            Overload arrayOverload = overload;
            Overload spanOverload = overload;
            for (int i = newParams.Count - 1; i >= 0; i--)
            {
                var param = newParams[i];

                if (param.Type is CSPointer pt)
                {
                    if (pt.BaseType is CSChar8)
                    {
                        Logger.Warning($"Char pointer leaked from earlier overloaders: \"{overload.NativeFunction.EntryPoint}\" ({param})");
                        continue;
                    }
                    else if (pt.BaseType is CSPointer)
                    {
                        Logger.Warning($"Pointer leaked from earlier overloaders: \"{overload.NativeFunction.EntryPoint}\" ({param})");
                        continue;
                    }
                }

                if (param.Length != null)
                {
                    string? lengthParamName = IOverloadLayer.GetParameterExpression(param.Length, out var expr);
                    if (lengthParamName != null)
                    {
                        var pointerParam = newParams[i];
                        if (pointerParam.Type is not CSPointer pointer)
                            throw new Exception("A parameter with a 'len' attribute must be a pointer type!");

                        int lengthParamIndex = Array.FindIndex(overload.InputParameters, p => p.Name == lengthParamName);
                        var oldLength = overload.InputParameters[lengthParamIndex];
                        int spanArrayParameterIndex = i;
                        Parameter? paramToBeRemoved = null;
                        bool shouldCalculateLength = overload.InputParameters.Count(p => p.Length == param.Length) <= 1;
                        // If this is the only len attribute that refernces this parameter,
                        // we can remove that parameter as we can calculate it from the length of this parameter (array/span).
                        // FIXME: This check is going to fail if the two 'len' attributes have different "forms" e.g. "n" == "n*4" == "COMPSIZE(n)" etc.
                        if (shouldCalculateLength)
                        {
                            paramToBeRemoved = oldLength;
                            newParams.Remove(oldLength);

                            if (lengthParamIndex < i)
                            {
                                spanArrayParameterIndex--;
                                i--;
                            }
                        }

                        BaseCSType baseType;
                        if (pointer.BaseType is CSVoid)
                        {
                            genericTypes = genericTypes.MakeCopyAndGrow(1);
                            genericTypes[^1] = $"T{genericTypes.Length}";
                            baseType = new CSGenericType(genericTypes[^1]);
                        }
                        else
                        {
                            baseType = pointer.BaseType;
                        }

                        var spanNameTable = overload.NameTable.New();
                        var arrayNameTable = overload.NameTable.New();

                        spanNameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");
                        arrayNameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");

                        var newSpanParams = spanOverload.InputParameters.Where(p => p != paramToBeRemoved).ToArray();
                        var newArrayParams = arrayOverload.InputParameters.Where(p => p != paramToBeRemoved).ToArray();

                        newSpanParams[spanArrayParameterIndex]  = newSpanParams[spanArrayParameterIndex]  with { Type = new CSSpan(baseType, pointer.Constant) };
                        newArrayParams[spanArrayParameterIndex] = newArrayParams[spanArrayParameterIndex] with { Type = new CSArray(baseType, pointer.Constant) };

                        var spanLayer  = new SpanOrArrayLayer(pointerParam, newSpanParams[spanArrayParameterIndex], oldLength, expr, shouldCalculateLength, baseType);
                        var arrayLayer = new SpanOrArrayLayer(pointerParam, newArrayParams[spanArrayParameterIndex], oldLength, expr, shouldCalculateLength, baseType);

                        spanOverload  = spanOverload with { NestedOverload = spanOverload, MarshalLayerToNested = spanLayer,
                            InputParameters = newSpanParams, NameTable = spanNameTable, GenericTypes = genericTypes };
                        arrayOverload = arrayOverload with { NestedOverload = arrayOverload, MarshalLayerToNested = arrayLayer,
                            InputParameters = newArrayParams, NameTable = arrayNameTable, GenericTypes = genericTypes };
                    }
                }
            }

            if (arrayOverload == spanOverload)
            {
                newOverloads = default;
                return false;
            }
            else
            {
                newOverloads = new List<Overload>()
                {
                    spanOverload,
                    arrayOverload,
                    overload,
                };
                return true;
            }
        }

        record SpanOrArrayLayer(
            Parameter PointerParameter,
            Parameter SpanOrArrayParameter,
            Parameter LengthParameter,
            Func<string, string> ParameterExpression,
            bool ShouldCalculateLength,
            BaseCSType BaseType) : IOverloadLayer
        {
            private Scope Scope;
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                // NOTE: We are casting the length field to the target type because some of
                // the functions don't take `int` types directly, instead they take an `IntPtr`.
                // But that is fine because we can cast `int`s to `IntPtr`.
                // This is slightly fragile but it's fine for now.
                // - Noggin_bops 2021-01-22
                if (ShouldCalculateLength)
                {
                    var byteSize = BaseType is CSGenericType ? $" * sizeof({BaseType.ToCSString()})" : "";
                    var lengthExpression = ParameterExpression(nameTable[SpanOrArrayParameter]);
                    writer.WriteLine($"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = ({LengthParameter.Type.ToCSString()})({lengthExpression}{byteSize});");
                }

                writer.WriteLine($"fixed ({PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = {nameTable[SpanOrArrayParameter]})");
                Scope = writer.Scope();
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                Scope.Dispose();
                return returnName;
            }
        }
    }
}
