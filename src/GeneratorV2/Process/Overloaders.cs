using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;
using GeneratorV2.Data;
using GeneratorV2.Writing;

namespace GeneratorV2.Process
{
    public class TrimNameOverloader : IOverloader
    {
        private static readonly Regex Endings = new Regex(
            @"([fd]v?|u?[isb](64)?v?|v|i_v|fi)$",
            RegexOptions.Compiled);

        private static readonly Regex EndingsNotToTrim = new Regex(
            "(sh|ib|[tdrey]s|[eE]n[vd]|bled" +
            "|Attrib|Access|Boolean|Coord|Depth|Feedbacks|Finish|Flag" +
            "|Groups|IDs|Indexed|Instanced|Pixels|Queries|Status|Tess|Through" +
            "|Uniforms|Varyings|Weight|Width)$",
            RegexOptions.Compiled);

        private static readonly Regex EndingsAddV = new Regex("^0", RegexOptions.Compiled);

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            // See: https://github.com/opentk/opentk/blob/082c8d228d0def042b11424ac002776432f44f47/src/Generator.Bind/FuncProcessor.cs#L417

            string name = overload.OverloadName;
            string trimmedName = name;
            // FIXME: Remove extension name before we trim endings
            Match m = EndingsNotToTrim.Match(name);
            if ((m.Index + m.Length) != name.Length)
            {
                m = Endings.Match(name);

                if (m.Length > 0 && m.Index + m.Length == name.Length)
                {
                    // Only trim endings, not internal matches.
                    if (m.Value[m.Length - 1] == 'v' && EndingsAddV.IsMatch(name) &&
                        !name.StartsWith("Get") && !name.StartsWith("MatrixIndex"))
                    {
                        // Only trim ending 'v' when there is a number
                        trimmedName = name.Substring(0, m.Index) + "v";
                    }
                    else
                    {
                        if (!name.EndsWith("xedv"))
                        {
                            trimmedName = name.Substring(0, m.Index);
                        }
                        else
                        {
                            trimmedName = name.Substring(0, m.Index + 1);
                        }
                    }
                }
            }

            if (trimmedName != name)
            {
                newOverloads = new List<Overload>() {overload with {OverloadName = trimmedName}};
                return true;
            }
            else
            {
                newOverloads = default;
                return false;
            }
        }
    }

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

        private record StringReturnLayer(string NewReturnName) : IOverloadLayer
        {
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

    public class BoolOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            Parameter[] parameters = overload.InputParameters.ToArray();
            NameTable nameTable = overload.NameTable;
            List<(Parameter byteParam, Parameter boolParam)> overloadedParameters = new List<(Parameter, Parameter)>();
            for (int i = 0; i < parameters.Length; i++)
            {
                Parameter parameter = parameters[i];
                if (parameter.Type is not CSBool8 bool8)
                {
                    continue;
                }

                nameTable.Rename(parameter, parameter.Name + "_byte");
                parameters[i] = parameter with { Type = new CSType("bool", bool8.Constant) };
                overloadedParameters.Add((parameter, parameters[i]));
            }

            if (overloadedParameters.Count == 0)
            {
                newOverloads = null;
                return false;
            }

            newOverloads = new List<Overload>()
            {
                overload with {
                    NestedOverload = overload,
                    MarshalLayerToNested = new BoolLayer(overloadedParameters),
                    InputParameters = parameters,
                    NameTable = nameTable }
            };
            return true;
        }

        private record BoolLayer(List<(Parameter byteParam, Parameter boolParam)> OverloadedParameters) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                foreach (var (byteParam, boolParam) in OverloadedParameters)
                {
                    writer.WriteLine($"byte {nameTable[byteParam]} = (byte)({nameTable[boolParam]} ? 1 : 0);");
                }
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                return returnName;
            }
        }
    }

    public class FunctionPtrToDelegateOverloader : IOverloader
        {
            public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
            {
                Parameter[] parameters = new Parameter[overload.InputParameters.Length];
                List<Parameter> original = new List<Parameter>();
                List<Parameter> changed = new List<Parameter>();
                NameTable nameTable = overload.NameTable.New();
                for (int i = 0; i < overload.InputParameters.Length; i++)
                {
                    Parameter parameter = overload.InputParameters[i];
                    parameters[i] = parameter;

                    if (parameter.Type is CSFunctionPointer fpt)
                    {
                        // Rename the parameter
                        nameTable.Rename(parameter, $"{parameter.Name}_ptr");

                        original.Add(parameters[i]);

                        parameters[i] = parameters[i] with { Type = new CSDelegateType(fpt.TypeName) };

                        changed.Add(parameters[i]);
                    }
                }

                if (changed.Count > 0)
                {
                    var layer = new FunctionPtrToDelegateLayer(changed, original);
                    newOverloads = new List<Overload>()
                    {
                        overload with { NestedOverload = overload, MarshalLayerToNested = layer, InputParameters = parameters, NameTable = nameTable }
                    };
                    return true;
                }
                else
                {
                    newOverloads = default;
                    return false;
                }
            }

            class FunctionPtrToDelegateLayer : IOverloadLayer
            {
                public readonly List<Parameter> DelegateParameters;
                public readonly List<Parameter> PointerParameters;

                public FunctionPtrToDelegateLayer(List<Parameter> delegateParameters, List<Parameter> pointerParameters)
                {
                    DelegateParameters = delegateParameters;
                    PointerParameters = pointerParameters;
                }

                public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
                {
                    for (int i = 0; i < DelegateParameters.Count; i++)
                    {
                        string type = PointerParameters[i].Type.ToCSString();
                        writer.WriteLine($"{type} {nameTable[PointerParameters[i]]} = Marshal.GetFunctionPointerForDelegate({nameTable[DelegateParameters[i]]});");
                    }
                }

                public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
                {
                    return returnName;
                }
            }
        }

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
            // FIXME: These methods contain an array of offsets, which we cannot currently handle.
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
            int parameterIndex = Array.FindIndex(overload.InputParameters, p => p.Name == parameterName);
            if (parameterIndex == -1)
            {
                Logger.Warning($"{overload.NativeFunction.FunctionName} does not have a parameter with the name {parameterName}");
                newOverloads = null;
                return false;
            }

            NameTable nameTable = overload.NameTable.New();
            Parameter pointerParameter = overload.InputParameters[parameterIndex];
            Parameter offsetParameter = pointerParameter with
            {
                Type = new CSType("nint", false), Name = "offset", Length = null
            };
            Parameter[] newParameters = overload.InputParameters.ToArray();
            newParameters[parameterIndex] = offsetParameter;
            nameTable.Rename(pointerParameter, pointerParameter.Name);
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

        public record PointerToOffsetLayer(Parameter PointerParameter,
            Parameter OffsetParameter) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine(
                    $"{PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = ({PointerParameter.Type.ToCSString()}){nameTable[OffsetParameter]};");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                return returnName;
            }
        }
    }

    public class VoidPtrToIntPtrOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            Parameter[] parameters = overload.InputParameters.ToArray();
            NameTable nameTable = overload.NameTable.New();
            List<(Parameter VPtr, Parameter IPtr)>
                parameterNames = new List<(Parameter VPtr, Parameter IPtr)>();

            for (int i = 0; i < parameters.Length; i++)
            {
                Parameter parameter = parameters[i];
                if (parameter.Type is not CSPointer pointerType ||
                    pointerType.BaseType is not CSVoid)
                {
                    continue;
                }

                nameTable.Rename(parameter, parameter.Name + "_vptr");
                parameters[i] = parameter with {Type = new CSType("IntPtr", false), Length = null};
                parameterNames.Add((parameter, parameters[i]));
            }


            if (parameterNames.Count == 0)
            {
                newOverloads = null;
                return false;
            }

            IOverloadLayer layer = new VoidPtrToIntPtrOverloadLayer(parameterNames);
            newOverloads = new List<Overload>()
            {
                overload with
                {
                    NestedOverload = overload, InputParameters = parameters, MarshalLayerToNested = layer,
                    NameTable = nameTable
                },
                overload,
            };
            return true;
        }

        private record VoidPtrToIntPtrOverloadLayer(
            List<(Parameter VPtr, Parameter IPtr)> ParameterNames) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                foreach ((Parameter vPtr, Parameter iPtr) in ParameterNames)
                {
                    writer.WriteLine($"void* {nameTable[vPtr]} = (void*){nameTable[iPtr]};");
                }
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                return returnName;
            }
        }
    }

    public class GenCreateAndDeleteOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            var nativeName = overload.NativeFunction.FunctionName;
            if (!nativeName.StartsWith("Create") && !nativeName.StartsWith("Gen") && !nativeName.StartsWith("Delete") ||
                !nativeName.EndsWith("s"))
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
            parameters[^1] = pointerParameter with
            {
                Type = new CSRef(refType, pointerParameterType.BaseType), Length = null
            };
            IOverloadLayer layer = refType == CSRef.Type.In
                ? new DeleteOverloadLayer(overload.InputParameters[lengthParameterIndex], parameters[^1],
                    pointerParameter)
                : new GenAndCreateOverloadLayer(overload.InputParameters[lengthParameterIndex], parameters[^1],
                    pointerParameter);

            newOverloads = new List<Overload>()
            {
                overload with
                {
                    InputParameters = parameters, NestedOverload = overload, OverloadName = newName,
                    NameTable = nameTable,
                    MarshalLayerToNested = layer
                },
                overload,
            };
            return true;
        }

        private record DeleteOverloadLayer(Parameter LengthParameter,
            Parameter InParameter,
            Parameter PointerParameter) : IOverloadLayer
        {
            private CsScope _csScope;
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine($"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = 1;");
                writer.WriteLine(
                    $"fixed({PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = &{nameTable[InParameter]})");
                _csScope = writer.CsScope();
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                _csScope.Dispose();
                return returnName;
            }
        }

        private record GenAndCreateOverloadLayer(Parameter LengthParameter,
            Parameter OutParameter,
            Parameter PointerParameter) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine($"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = 1;");
                writer.WriteLine($"Unsafe.SkipInit(out {nameTable[OutParameter]});");
                // FIXME
                writer.WriteLine("// FIXME: This could be a problem for the overloads that take an out parameter");
                writer.WriteLine("// as this parameter could *potentially* move while inside of this function");
                writer.WriteLine("// which would mean that the new value never gets written to the out parameter.");
                writer.WriteLine("// Making for a nasty bug.");
                writer.WriteLine(
                    "// The reason we don't use a fixed expression here is because of the \"single out parameter to return value\" overloading step");
                writer.WriteLine(
                    "// that will make it so this tries to fix a local variable which is not allowed in C# for some reason.");
                writer.WriteLine(
                    "// If you have problems with this we would really appreciate you opening an issue at https://github.com/opentk/opentk");
                writer.WriteLine("// - 2021-05-18");

                writer.WriteLine(
                    $"{PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = ({PointerParameter.Type.ToCSString()})Unsafe.AsPointer(ref {nameTable[OutParameter]});");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                return returnName;
            }
        }
    }

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

        private record StringLayer(Parameter PointerParameter, Parameter StringParameter) : IOverloadLayer
        {
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

        private record OutStringLayer(Parameter PointerParameter,
            Parameter StringLengthParameter,
            Parameter StringParameter) : IOverloadLayer
        {
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
                        Logger.Warning(
                            $"Char pointer leaked from earlier overloaders: \"{overload.NativeFunction.EntryPoint}\" ({param})");
                        continue;
                    }
                    else if (pt.BaseType is CSPointer)
                    {
                        Logger.Warning(
                            $"Pointer leaked from earlier overloaders: \"{overload.NativeFunction.EntryPoint}\" ({param})");
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

                        int lengthParamIndex =
                            Array.FindIndex(overload.InputParameters, p => p.Name == lengthParamName);
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

                        newSpanParams[spanArrayParameterIndex] = newSpanParams[spanArrayParameterIndex] with
                        {
                            Type = new CSSpan(baseType, pointer.Constant)
                        };
                        newArrayParams[spanArrayParameterIndex] = newArrayParams[spanArrayParameterIndex] with
                        {
                            Type = new CSArray(baseType, pointer.Constant)
                        };

                        var spanLayer = new SpanOrArrayLayer(pointerParam, newSpanParams[spanArrayParameterIndex],
                            oldLength, expr, shouldCalculateLength, baseType);
                        var arrayLayer = new SpanOrArrayLayer(pointerParam, newArrayParams[spanArrayParameterIndex],
                            oldLength, expr, shouldCalculateLength, baseType);

                        spanOverload = spanOverload with
                        {
                            NestedOverload = spanOverload, MarshalLayerToNested = spanLayer,
                            InputParameters = newSpanParams, NameTable = spanNameTable, GenericTypes = genericTypes
                        };
                        arrayOverload = arrayOverload with
                        {
                            NestedOverload = arrayOverload, MarshalLayerToNested = arrayLayer,
                            InputParameters = newArrayParams, NameTable = arrayNameTable, GenericTypes = genericTypes
                        };
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

        private record SpanOrArrayLayer(
            Parameter PointerParameter,
            Parameter SpanOrArrayParameter,
            Parameter LengthParameter,
            Func<string, string> ParameterExpression,
            bool ShouldCalculateLength,
            BaseCSType BaseType) : IOverloadLayer
        {
            private CsScope _csScope;

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
                    writer.WriteLine(
                        $"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = ({LengthParameter.Type.ToCSString()})({lengthExpression}{byteSize});");
                }

                writer.WriteLine(
                    $"fixed ({PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = {nameTable[SpanOrArrayParameter]})");
                _csScope = writer.CsScope();
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                _csScope.Dispose();
                return returnName;
            }
        }
    }

    public class RefInsteadOfPointerOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            Parameter[] parameters = new Parameter[overload.InputParameters.Length];
            List<Parameter> original = new List<Parameter>();
            List<Parameter> changed = new List<Parameter>();
            NameTable nameTable = overload.NameTable.New();
            string[] genericTypes = overload.GenericTypes;
            for (int i = 0; i < overload.InputParameters.Length; i++)
            {
                Parameter parameter = overload.InputParameters[i];
                parameters[i] = parameter;

                if (parameter.Type is CSPointer pt)
                {
                    bool constant = pt.Constant;
                    BaseCSType baseType;
                    switch (pt.BaseType)
                    {
                        case CSVoid btVoid:
                            genericTypes = genericTypes.MakeCopyAndGrow(1);
                            genericTypes[^1] = $"T{genericTypes.Length}";
                            baseType = new CSGenericType(genericTypes[^1]);
                            constant |= btVoid.Constant;
                            break;
                        case CSType bt:
                            baseType = pt.BaseType;
                            constant |= bt.Constant;
                            break;
                        default:
                            continue;
                    }
                    // FIXME: When do we know it's an out ref type?
                    CSRef.Type refType = constant ? CSRef.Type.In : CSRef.Type.Ref;

                    // Rename the parameter
                    nameTable.Rename(parameter, $"{parameter.Name}_ptr");

                    original.Add(parameters[i]);

                    parameters[i] = parameters[i] with { Type = new CSRef(refType, baseType) };

                    changed.Add(parameters[i]);
                }
            }

            if (changed.Count > 0)
            {
                var layer = new RefInsteadOfPointerLayer(changed, original);
                newOverloads = new List<Overload>()
                {
                    overload with { NestedOverload = overload, MarshalLayerToNested = layer, InputParameters = parameters, NameTable = nameTable, GenericTypes = genericTypes }
                };
                return true;
            }
            else
            {
                newOverloads = default;
                return false;
            }
        }

        private record RefInsteadOfPointerLayer(List<Parameter> RefParameters,
            List<Parameter> PointerParameters) : IOverloadLayer
        {
            private CsScope _csScope;
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                for (int i = 0; i < RefParameters.Count; i++)
                {
                    string type = PointerParameters[i].Type.ToCSString();
                    writer.WriteLine($"fixed ({type} {nameTable[PointerParameters[i]]} = &{nameTable[RefParameters[i]]})");
                }

                _csScope = writer.CsScope();
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                _csScope.Dispose();
                return returnName;
            }
        }
    }

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
                overload with
                {
                    NestedOverload = overload, InputParameters = newParameters,
                    ReturnType = outType!.ReferencedType,
                    MarshalLayerToNested = new OutToReturnOverloadLayer(outParameter, outType)
                },
                overload,
            };
            return true;
        }

        private record OutToReturnOverloadLayer(Parameter OutParameter, CSRef OutType) : IOverloadLayer
        {
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
