using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Generator.Parsing;
using Generator.Utility;
using Generator.Utility.Extensions;
using Generator.Writing;
using static Generator.Process.ColorTypeOverloader;

namespace Generator.Process
{
    internal interface IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads);

        // /!\ IMPORTANT /!\:
        // All return mathType overloaders need to run before any of the other overloaders.
        // This is to ensure that correct scoping for the new return variables.
        // FIXME: Maybe we dont want classes for these?
        internal static readonly IOverloader[] Overloaders = new IOverloader[]
        {
            new TrimNameOverloader(),

            new StringReturnOverloader(),
            new GetReturnOverloader(),
            new BoolReturnOverloader(),

            new ColorTypeOverloader(),
            new MathTypeOverloader(),
            new FunctionPtrToDelegateOverloader(),
            new PointerToOffsetOverloader(),
            new VoidPtrToIntPtrOverloader(),
            new GenCreateAndDeleteOverloader(),
            new StringOverloader(),
            new SpanAndArrayOverloader(),
            new RefInsteadOfPointerOverloader(),
            new OutToReturnOverloader(),
        };
    }

    internal class TrimNameOverloader : IOverloader
    {
        private static readonly Regex Endings = new Regex(
            @"(u?[sb](64)?v?|v|i_v|fi)$",
            RegexOptions.Compiled);

        private static readonly Regex EndingsNotToTrim = new Regex(
            "(sh|ib|[tdrey]s|[eE]n[vd]|bled" +
            "|Attrib|Address|Access|Boolean|Bitmaps|Coord|Depth|Feedbacks|Finish|Flag" +
            "|Groups|IDs|Indexed|Instanced|Pixels|Queries|Status|Tess|Through" +
            "|Uniforms|Varyings|Weight|Width|[1-4][fdhi]v)$",
            RegexOptions.Compiled);

        private static readonly Regex EndingsAddV = new Regex("^0", RegexOptions.Compiled);

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            // See: https://github.com/opentk/opentk/blob/082c8d228d0def042b11424ac002776432f44f47/src/Generator.Bind/FuncProcessor.cs#L417
            
            string name = overload.OverloadName;
            string trimmedName = name;
            // FIXME: Remove vendor name before we trim endings
            //
            // We actually need to remove vendor names in context of the other
            // functions that will be in the same scope as this function
            // There are a number of ARB functions that have two defintions
            // for a function, one with the ARB postfix and one without.
            // This causes problems when we remove the postfix as the two
            // functions now conflict.
            // - Noggin_bops 2023-01-26
            Match m = EndingsNotToTrim.Match(name);
            if (m.Index + m.Length != name.Length)
            {
                m = Endings.Match(name);

                if (m.Length > 0 && m.Index + m.Length == name.Length)
                {
                    if (!name.EndsWith("xedv"))
                    {
                        trimmedName = name.Substring(0, m.Index);
                    }
                    else
                    {
                        trimmedName = name.Substring(0, m.Index);
                    }
                }
            }

            if (trimmedName != name)
            {
                newOverloads = new List<Overload>() { overload with
                {
                    OverloadName = trimmedName,
                    NestedOverload = overload,
                    MarshalLayerToNested = null
                }};
                return true;
            }
            else
            {
                newOverloads = default;
                return false;
            }
        }
    }

    internal class GetReturnOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            if (overload.NativeFunction.EntryPoint.StartsWith("glGet")
                // FIXME: It might be better to be more selective about what
                // functions we overload like this to reduce the number of
                // garbage overloads generated.
                /*
                overload.NativeFunction.EntryPoint.StartsWith("glGetInteger") ||
                overload.NativeFunction.EntryPoint.StartsWith("glGetFloat") ||
                overload.NativeFunction.EntryPoint.StartsWith("glGetDouble") ||
                overload.NativeFunction.EntryPoint.StartsWith("glGetBoolean") ||
                overload.NativeFunction.EntryPoint.StartsWith("glGetFixed") ||
                overload.NativeFunction.EntryPoint.StartsWith("glGetShader") ||
                overload.NativeFunction.EntryPoint.StartsWith("glGetProgram") ||
                overload.NativeFunction.EntryPoint.StartsWith("glGetBuffer") ||
                overload.NativeFunction.EntryPoint.StartsWith("glGetFramebuffer") ||
                overload.NativeFunction.EntryPoint.StartsWith("glGetTexture") ||
                overload.NativeFunction.EntryPoint.StartsWith("glGetSampler") ||
                overload.NativeFunction.EntryPoint.StartsWith("glGetVertexArray") ||
                */
                )
            {
                if (overload.InputParameters.Length == 0)
                {
                    newOverloads = default;
                    return false;
                }

                // We are looking for function where the last parameter is a pointer argument called "data" that we are going to convert to a return value.
                if (overload.InputParameters[^1].Type is CSPointer pointer &&
                    pointer.BaseType is not CSVoid &&
                    pointer.BaseType is not CSChar8)
                {
                    string newReturnName = $"{overload.InputParameters[^1].Name}_val";
                    var layer = new GetReturnLayer(overload.InputParameters[^1], pointer.BaseType, newReturnName);

                    var inputParams = overload.InputParameters[0..^1];

                    var nameTable = overload.NameTable.New();
                    nameTable.ReturnName = newReturnName;

                    newOverloads = new List<Overload>()
                    {
                        overload,
                        overload with
                        {
                            NestedOverload = overload,
                            MarshalLayerToNested = layer,
                            InputParameters = inputParams,
                            ReturnType = pointer.BaseType,
                            NameTable = nameTable,
                        }
                    };
                    return true;
                }
            }

            newOverloads = default;
            return false;
        }

        private record GetReturnLayer(Parameter ReturnParam, BaseCSType BaseType, string NewReturnName) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                // FIXME: Detect if we need to create our own variable!
                //writer.WriteLine($"{BaseType.ToCSString()} {NewReturnName};");
                writer.WriteLine($"{ReturnParam.Type.ToCSString()} {nameTable[ReturnParam]} = &{NewReturnName};");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                return NewReturnName;
            }
        }
    }

    internal class StringReturnOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            // See: https://github.com/KhronosGroup/OpenGL-Registry/issues/363
            // These are the only two functions that return strings 2020-12-29
            if (overload.NativeFunction.EntryPoint == "glGetString" ||
                overload.NativeFunction.EntryPoint == "glGetStringi")
            {
                var newReturnName = $"{overload.NameTable.ReturnName}_str";
                var layer = new StringReturnLayer(new CSPointer(new CSPrimitive("byte", true), true), newReturnName, overload.NameTable.ReturnName!);
                var returnType = new CSString(Nullable: true);
                var nameTable = overload.NameTable.New();
                nameTable.ReturnName = newReturnName;
                newOverloads = new List<Overload>()
                {
                    overload with
                    {
                        NestedOverload = overload,
                        MarshalLayerToNested = layer,
                        ReturnType = returnType,
                        NameTable = nameTable,
                    }
                };
                return true;
            }
            else if (overload.ReturnType is CSPointer pt && pt.BaseType is ICSCharType bt)
            {
                var newReturnName = $"{overload.NameTable.ReturnName}_str";
                var layer = new StringReturnLayer(pt, newReturnName, overload.NameTable.ReturnName!);
                var returnType = new CSString(Nullable: true);
                var nameTable = overload.NameTable.New();
                nameTable.ReturnName = newReturnName;
                newOverloads = new List<Overload>()
                {
                    overload with
                    {
                        NestedOverload = overload,
                        MarshalLayerToNested = layer,
                        ReturnType = returnType,
                        NameTable = nameTable,
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

        private record StringReturnLayer(CSPointer PointerType, string NewReturnName, string NestedReturnName) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                // This is weird, here we need to create the variable that the internal layers
                // are going to consider as the final return variable. So we need access to the
                // return name of the nested layer.
                writer.WriteLine($"{PointerType.ToCSString()} {NestedReturnName};");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                writer.WriteLine($"{NewReturnName} = Marshal.PtrToStringAnsi((IntPtr){returnName});");
                return NewReturnName;
            }
        }
    }

    internal class BoolReturnOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            if (overload.ReturnType is CSBool32 boolType)
            {
                var newReturnName = $"{overload.NameTable.ReturnName}_bool";
                var layer = new BoolReturnLayer(boolType, newReturnName, overload.NameTable.ReturnName!);
                var returnType = new CSBool8(boolType.Constant);
                var nameTable = overload.NameTable.New();
                nameTable.ReturnName = newReturnName;
                newOverloads = new List<Overload>()
                {
                    overload with
                    {
                        NestedOverload = overload,
                        MarshalLayerToNested = layer,
                        ReturnType = returnType,
                        NameTable = nameTable,
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

        private record BoolReturnLayer(BaseCSType Type, string NewReturnName, string NestedReturnName) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                // This is weird, here we need to create the variable that the internal layers
                // are going to consider as the final return variable. So we need access to the
                // return name of the nested layer.
                writer.WriteLine($"{Type.ToCSString()} {NestedReturnName};");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                writer.WriteLine($"{NewReturnName} = {returnName} != 0;");
                return NewReturnName;
            }
        }
    }

    internal class ColorTypeOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            NameTable nameTable = overload.NameTable.New();

            Parameter[] parameters = overload.InputParameters.ToArray();
            List<Parameter> colorParameters = new List<Parameter>();
            List<Parameter> pointerParameters = new List<Parameter>();
            bool isOverloaded = false;
            for (int i = 0; i < parameters.Length; i++)
            {
                Parameter parameter = parameters[i];

                if (parameter.Type is CSPointer pointer && parameter.Kinds.Contains("Color"))
                {
                    // We only support float colors!
                    if (pointer.BaseType is not CSPrimitive primitive || primitive.TypeName != "float")
                    {
                        continue;
                    }

                    if (parameter.Length == null)
                    {
                        continue;
                    }

                    if (parameter.Length is Constant constant)
                    {
                        int colorSize = constant.Value;
                        if (colorSize > 4 || colorSize < 3)
                            throw new Exception($"The kind=Color parameter {parameter.Name} in {overload.NativeFunction.EntryPoint} was marked with a size that was not 3 or 4. length: {colorSize}");

                        string colorSpace = colorSize == 4 ? "Rgba" : "Rgb";

                        nameTable.Rename(parameter, $"{parameter.Name}_ptr");

                        // FIXME: ref vs in depending on Constant memeber
                        Parameter colorParameter = parameter with { Type = new CSRef(CSRef.Type.In, new CSPrimitive($"Color{colorSize}<{colorSpace}>", pointer.Constant)), Length = null };

                        pointerParameters.Add(parameter);
                        colorParameters.Add(colorParameter);
                        parameters[i] = colorParameter;

                        isOverloaded = true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }

            if (isOverloaded)
            {
                // FIXME: We want to remove the v postfix, but vendor names are still in the overload names...
                // We probably want to remove the extension name from the overload name.
                string overloadName = overload.OverloadName;
                if (overloadName.EndsWith('v'))
                {
                    overloadName = NameMangler.RemoveEnd(overload.OverloadName, "v");
                }

                newOverloads = new List<Overload>()
                {
                    overload with
                    {
                        OverloadName = overloadName,
                        InputParameters = parameters,
                        MarshalLayerToNested = new ColorLayer(colorParameters, pointerParameters),
                        NameTable = nameTable,
                        NestedOverload = overload,
                    }
                };
                return true;
            }

            newOverloads = null;
            return false;
        }

        internal record ColorLayer(List<Parameter> ColorParamters, List<Parameter> PointerParameters) : IOverloadLayer
        {
            CsScope _csScope;
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                for (int i = 0; i < ColorParamters.Count; i++)
                {
                    Parameter colorParamter = ColorParamters[i];
                    BaseCSType colorType = ((CSRef)colorParamter.Type).ReferencedType;

                    writer.WriteLine($"fixed ({colorType.ToCSString()}* tmp_{nameTable[colorParamter]} = &{nameTable[colorParamter]})");
                }
                _csScope = writer.CsScope();

                for (int i = 0; i < ColorParamters.Count; i++)
                {
                    Parameter colorParamter = ColorParamters[i];
                    Parameter pointerParameter = PointerParameters[i];

                    writer.WriteLine($"{pointerParameter.Type.ToCSString()} {nameTable[pointerParameter]} = ({pointerParameter.Type.ToCSString()})tmp_{nameTable[colorParamter]};");
                }
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                _csScope.Dispose();
                return returnName;
            }
        }
    }

    internal sealed class MathTypeOverloader : IOverloader
    {
        // Regex to match names of vector methods.
        private static readonly Regex VectorNameMatch = new Regex("(?<!6)([1-4])([fdhi])v$", RegexOptions.Compiled);
        
        private static readonly HashSet<string> _mathKinds = new HashSet<string>()
        {
            "Vector1",
            "Vector2",
            "Vector3",
            "Vector4",

            "Matrix2x2",
            "Matrix2x3",
            "Matrix2x4",
            "Matrix3x2",
            "Matrix3x3",
            "Matrix3x4",
            "Matrix4x2",
            "Matrix4x3",
            "Matrix4x4",
        };

        private static readonly Dictionary<string, int> _kindSize = new Dictionary<string, int>()
        {
            { "Vector1", 1 },
            { "Vector2", 2 },
            { "Vector3", 3 },
            { "Vector4", 4 },

            { "Matrix2x2", 4 },
            { "Matrix2x3", 6 },
            { "Matrix2x4", 8 },
            { "Matrix3x2", 6 },
            { "Matrix3x3", 9 },
            { "Matrix3x4", 12 },
            { "Matrix4x2", 8 },
            { "Matrix4x3", 12 },
            { "Matrix4x4", 16 },
        };

        private static readonly Dictionary<string, string> _toSystemNumerics = new Dictionary<string, string>()
        {
            { "Vector2", "System.Numerics.Vector2" },
            { "Vector3", "System.Numerics.Vector3" },
            { "Vector4", "System.Numerics.Vector4" },
            { "Matrix3x2", "System.Numerics.Matrix3x2" },
            { "Matrix4", "System.Numerics.Matrix4x4" },
        };

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            NameTable nameTable = overload.NameTable.New();

            bool isOverloaded = false;
            bool generateSpanAndArrayOverload = false;

            Parameter[] refParametersArr = overload.InputParameters.ToArray();
            Parameter[] spanParametersArr = overload.InputParameters.ToArray();
            Parameter[] arrayParametersArr = overload.InputParameters.ToArray();

            List<Parameter> refParameters = new List<Parameter>();
            List<Parameter> spanParameters = new List<Parameter>();
            List<Parameter> arrayParameters = new List<Parameter>();

            List<Parameter> pointerParameters = new List<Parameter>();
            for (int i = 0; i < overload.InputParameters.Length; i++)
            {
                Parameter parameter = overload.InputParameters[i];

                if (parameter.Type is CSPointer pointer && pointer.BaseType is CSPrimitive baseType)
                {
                    // FIXME: Maybe we don't overload the uint vectors??
                    string? typePostfix = pointer.BaseType switch
                    {
                        CSPrimitive { TypeName: "int" } => "i",
                        CSPrimitive { TypeName: "uint" } => "i",
                        CSPrimitive { TypeName: "half" } => "h",
                        CSPrimitive { TypeName: "float" } => "",
                        CSPrimitive { TypeName: "double" } => "d",
                        _ => null,
                    };

                    string? mathKind = parameter.Kinds.GetMatching(_mathKinds);
                    if (mathKind != null)
                    {
                        if (parameter.Length is Constant constant)
                        {
                            // Verify length with kind
                            Debug.Assert(_kindSize[mathKind] == constant.Value);
                        }
                        else if (parameter.Length is BinaryOperation binaryOperation)
                        {
                            if (binaryOperation.TryDecomposeIntoParameterRefAndConstant(out Constant? @const, out ParameterReference? parameterReference))
                            {
                                Debug.Assert(_kindSize[mathKind] == @const.Value);

                                generateSpanAndArrayOverload = true;
                            }
                        }

                        nameTable.Rename(parameter, $"{parameter.Name}_ptr");

                        pointerParameters.Add(parameter);

                        string name = mathKind switch
                        {
                            // Vector1 is just the base type itself.
                            "Vector1" => baseType.TypeName,

                            "Matrix2x2" or
                            "Matrix3x3" or
                            "Matrix4x4" => $"{mathKind[0..^2]}{typePostfix}",

                            _ => $"{mathKind}{typePostfix}",
                        };

                        CSStruct mathType = new CSStruct(name, baseType.Constant);

                        Parameter refParamter = parameter with { Type = new CSRef(baseType.Constant ? CSRef.Type.In : CSRef.Type.Ref, mathType), Length = null };
                        Parameter spanParamter = parameter with { Type = new CSSpan(mathType, baseType.Constant), Length = null };
                        Parameter arrayParamter = parameter with { Type = new CSArray(mathType), Length = null };

                        refParameters.Add(refParamter);
                        spanParameters.Add(spanParamter);
                        arrayParameters.Add(arrayParamter);

                        refParametersArr[i] = refParamter;
                        spanParametersArr[i] = spanParamter;
                        arrayParametersArr[i] = arrayParamter;

                        isOverloaded = true;
                        continue;
                    }
                    else
                    {
                        // Not all functions that take vectors are marked with the vector kinds
                        // However there is a pattern for function which take vector parameters
                        // This allows function like glTexCoord2f to have the correct vector overload
                        // We don't need to do this for matrices as all functions taking matrices are
                        // correctly marked with the matrix kinds.
                        // - 2023-03-20 Noggin_Bops

                        Match vectorMatch = VectorNameMatch.Match(overload.OverloadName);
                        if (vectorMatch.Success)
                        {
                            int vectorSize = int.Parse(vectorMatch.Groups[1].Value);
                            typePostfix = vectorMatch.Groups[2].Value;
                            if (typePostfix == "f") typePostfix = "";
                            string typeName = $"Vector{vectorSize}{typePostfix}";

                            if (vectorSize == 1)
                            {
                                typeName = baseType.TypeName;
                            }

                            nameTable.Rename(parameter, $"{parameter.Name}_ptr");

                            pointerParameters.Add(parameter);

                            CSStruct mathType = new CSStruct(typeName, baseType.Constant);

                            Parameter refParamter = parameter with { Type = new CSRef(baseType.Constant ? CSRef.Type.In : CSRef.Type.Ref, mathType), Length = null };
                            Parameter spanParamter = parameter with { Type = new CSSpan(mathType, baseType.Constant), Length = null };
                            Parameter arrayParamter = parameter with { Type = new CSArray(mathType), Length = null };

                            refParameters.Add(refParamter);
                            spanParameters.Add(spanParamter);
                            arrayParameters.Add(arrayParamter);

                            refParametersArr[i] = refParamter;
                            spanParametersArr[i] = spanParamter;
                            arrayParametersArr[i] = arrayParamter;

                            isOverloaded = true;
                            continue;
                        }
                    }
                }
            }

            if (isOverloaded)
            {
                // FIXME: We want to remove the v postfix, but vendor names are still in the overload names...
                // We probably want to remove the extension name from the overload name.
                string overloadName = overload.OverloadName;
                if (overloadName.EndsWith('v'))
                {
                    overloadName = NameMangler.RemoveEnd(overload.OverloadName, "v");
                }

                Overload refOverload = overload with
                {
                    OverloadName = overloadName,
                    InputParameters = refParametersArr,
                    MarshalLayerToNested = new MathLayer(pointerParameters, refParameters),
                    NameTable = nameTable,
                    NestedOverload = overload,
                };

                Overload spanOverload = overload with
                {
                    OverloadName = overloadName,
                    InputParameters = spanParametersArr,
                    MarshalLayerToNested = new MathLayer(pointerParameters, spanParameters),
                    NameTable = nameTable,
                    NestedOverload = overload,
                };

                Overload arrayOverload = overload with
                {
                    OverloadName = overloadName,
                    InputParameters = arrayParametersArr,
                    MarshalLayerToNested = new MathLayer(pointerParameters, arrayParameters),
                    NameTable = nameTable,
                    NestedOverload = overload,
                };

                // FIXME: Create the system.math overloads
                // FIXME: Create the array and span overloads
                newOverloads = new List<Overload>()
                {
                    refOverload,
                };

                if (generateSpanAndArrayOverload)
                {
                    newOverloads.Add(spanOverload);
                    newOverloads.Add(arrayOverload);
                }

                Overload? numericsRef =   GenSystemNumericsOverload(refOverload, pointerParameters);
                Overload? numericsSpan =  GenSystemNumericsOverload(spanOverload, pointerParameters);
                Overload? numericsArray = GenSystemNumericsOverload(arrayOverload, pointerParameters);

                if (numericsRef != null)   newOverloads.Add(numericsRef);
                if (numericsSpan != null)  newOverloads.Add(numericsSpan);
                if (numericsArray != null) newOverloads.Add(numericsArray);

                return true;
            }

            newOverloads = null;
            return false;


            static Overload? GenSystemNumericsOverload(Overload overload, List<Parameter> pointerParameters)
            {
                bool modified = false;

                Parameter[] parameters = overload.InputParameters.ToArray();
                List<Parameter> NumericsParameters = new List<Parameter>();
                
                for (int i = 0; i < overload.InputParameters.Length; i++)
                {
                    Parameter parameter = overload.InputParameters[i];

                    if (parameter.Type is IBaseTypeCSType pointerType &&
                        pointerType.BaseType is CSStruct mathType &&
                        _toSystemNumerics.TryGetValue(mathType.TypeName, out string? numericsTypeName))
                    {
                        // Create new object with the same mathType as pointerType
                        Parameter numericsParam = parameter with { Type = pointerType.CreateWithNewType(new CSStruct(numericsTypeName, mathType.Constant)) };

                        parameters[i] = numericsParam;

                        NumericsParameters.Add(numericsParam);

                        modified = true;
                    }
                }

                if (modified)
                {
                    return overload with
                    {
                        InputParameters = parameters,
                        MarshalLayerToNested = new MathLayer(pointerParameters, NumericsParameters),
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        internal record MathLayer(List<Parameter> PointerParams, List<Parameter> VectorParams) : IOverloadLayer
        {
            private CsScope _csScope;
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                for (int i = 0; i < PointerParams.Count; i++)
                {
                    Parameter ptrParam = PointerParams[i];
                    Parameter vectorParam = VectorParams[i];
                    BaseCSType vectorType = ((IBaseTypeCSType)vectorParam.Type).BaseType;
                    bool takeAddress = ((IBaseTypeCSType)vectorParam.Type).TakeAddressInFixedStatement;

                    writer.WriteLine($"fixed ({vectorType.ToCSString()}* tmp_{nameTable[vectorParam]} = {(takeAddress ? "&" : "")}{nameTable[vectorParam]})");
                }
                _csScope = writer.CsScope();

                for (int i = 0; i < PointerParams.Count; i++)
                {
                    Parameter pointerParameter = PointerParams[i];
                    Parameter colorParamter = VectorParams[i];

                    writer.WriteLine($"{pointerParameter.Type.ToCSString()} {nameTable[pointerParameter]} = ({pointerParameter.Type.ToCSString()})tmp_{nameTable[colorParamter]};");
                }
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                _csScope.Dispose();
                return returnName;
            }
        }
    }

    internal class FunctionPtrToDelegateOverloader : IOverloader
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
            internal readonly List<Parameter> DelegateParameters;
            internal readonly List<Parameter> PointerParameters;

            internal FunctionPtrToDelegateLayer(List<Parameter> delegateParameters, List<Parameter> pointerParameters)
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

    internal sealed class PointerToOffsetOverloader : IOverloader
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

        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            if (_methodsAndParametersToOverload.TryGetValue(overload.NativeFunction.EntryPoint, out var parameterName) == false)
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
                Type = new CSPrimitive("nint", false),
                Name = "offset",
                Length = null
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

        internal record PointerToOffsetLayer(Parameter PointerParameter,
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

    internal class VoidPtrToIntPtrOverloader : IOverloader
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
                parameters[i] = parameter with { Type = new CSPrimitive("IntPtr", false), Length = null };
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

    internal class GenCreateAndDeleteOverloader : IOverloader
    {
        internal static readonly string[] Prefixes = new string[] { "Gen", "Create", "Delete" };

        // Atm only Queries/Query needs this renaming
        // - 2022-06-27
        internal static Dictionary<string, string> pluralNameToSingularName = new Dictionary<string, string>()
        {
            { "Queries", "Query" },
            { "TransformFeedbacks", "TransformFeedback" },
            { "VertexArrays", "VertexArray" },
            { "Textures", "Texture" },
            { "Samplers", "Sampler" },
            { "Renderbuffers", "Renderbuffer" },
            { "ProgramPipelines", "ProgramPipeline" },
            { "Framebuffers", "Framebuffer" },
            { "Buffers", "Buffer" },
        };

        internal static Dictionary<string, string> parameterNamesToChange = new Dictionary<string, string>()
        {
            { "ids", "id" },
            { "arrays", "array" },
            { "textures", "texture" },
            { "samplers", "sampler" },
            { "renderbuffers", "renderbuffer" },
            { "pipelines", "pipeline" },
            { "framebuffers", "framebuffer" },
            { "buffers", "buffer" },
        };

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

            string? namePrefix = null;
            string? nameWithoutPrefix = null;
            foreach (var prefix in Prefixes)
            {
                if (nativeName.StartsWith(prefix))
                {
                    namePrefix = prefix;
                    nameWithoutPrefix = nativeName[prefix.Length..];
                }
            }

            if (nameWithoutPrefix == null || namePrefix == null)
                throw new Exception($"Function name '{nativeName}' doesn't start with Gen/Create/Delete and cannot be overloaded by this overloader.");

            string newName;
            if (pluralNameToSingularName.TryGetValue(nameWithoutPrefix, out string? newPostfix))
            {
                newName = $"{namePrefix}{newPostfix}";
            }
            else
            {
                // If the name didn't have a custom singular name, we just remove the trailing 's'
                newName = nativeName;
                Logger.Warning($"Function '{nativeName}' ({nameWithoutPrefix}) {nameWithoutPrefix[..^1]} needs a depluralized name.");
            }

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

            string? newPointerParameterName;
            if (parameterNamesToChange.TryGetValue(pointerParameter.Name, out newPointerParameterName) == false)
            {
                newPointerParameterName = pointerParameter.Name;
                Logger.Warning($"Parameter '{pointerParameter.Name}' needs a depluralized name!");
            }

            var nameTable = overload.NameTable.New();
            nameTable.Rename(pointerParameter, $"{pointerParameter.Name}_handle");

            CSRef.Type refType = nativeName.StartsWith("Delete") ? CSRef.Type.In : CSRef.Type.Out;
            parameters[^1] = pointerParameter with
            {
                // Remove ending 's' in parameter name.
                // This works for Queries/Query because the parameter names in these functions is "ids
                // - 2022-06-27
                Name = newPointerParameterName,
                Type = new CSRef(refType, pointerParameterType.BaseType),
                Length = null
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

    internal class StringOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            List<Parameter> newParams = new List<Parameter>(overload.InputParameters);
            Overload newOverload = overload;
            for (int i = newParams.Count - 1; i >= 0; i--)
            {
                // FIXME: We want to handle sized strings different!!!
                var param = newParams[i];
                if (param.Type is CSPointer pt && pt.BaseType is ICSCharType bt)
                {
                    var pointerParam = newParams[i];
                    var nameTable = newOverload.NameTable.New();
                    nameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");

                    if (bt.Constant)
                    {
                        StringLayer.StringType stringType = bt switch
                        {
                            CSChar8 => StringLayer.StringType.Char8,
                            CSChar16 => StringLayer.StringType.Char16,
                            _ => throw new Exception("Unknown string type!"),
                        };

                        // FIXME: Can we know if the string is nullable or not?
                        newParams[i] = newParams[i] with { Type = new CSString(Nullable: false), Length = null };
                        var stringParams = newParams.ToArray();
                        var stringLayer = new StringLayer(pointerParam, newParams[i], stringType);

                        newOverload = newOverload with
                        {
                            NestedOverload = newOverload,
                            MarshalLayerToNested = stringLayer,
                            InputParameters = stringParams,
                            NameTable = nameTable
                        };
                    }
                    else
                    {
                        int stringParamIndex = i;
                        Parameter? lenParam = null;
                        if (param.Length != null)
                        {
                            string? paramName = Expression.InvertExpressionAndGetReferencedName(param.Length, out var expr);
                            if (paramName == null)
                            {
                                Logger.Info($"{overload.NativeFunction.EntryPoint} has a COMPSIZE string length for parameter '{param.Name}'!");
                                continue;
                            }

                            int index = newParams.FindIndex(p => p.Name == paramName);
                            lenParam = newParams[index];
                        }

                        if (lenParam == null)
                        {
                            Logger.Info($"{overload.NativeFunction.EntryPoint} is missing a len attribute for parameter '{param.Name}'");
                            continue;
                        }

                        // FIXME: Can we know if the string is nullable or not?
                        var stringParam = newParams[stringParamIndex] with
                        {
                            Type = new CSRef(CSRef.Type.Out, new CSString(Nullable: false)),
                            Length = null
                        };
                        newParams[stringParamIndex] = stringParam;

                        // As wgl doesn't output any 16-bit strings we don't handle this case for now
                        // - 2023-03-23 NogginBops
                        if (bt is CSChar16)
                        {
                            throw new Exception("We don't support out 16-bit strings atm.");
                        }

                        var stringParams = newParams.ToArray();
                        var stringLayer = new OutStringLayer(pointerParam, lenParam, stringParam);

                        newOverload = newOverload with
                        {
                            NestedOverload = newOverload,
                            MarshalLayerToNested = stringLayer,
                            InputParameters = stringParams,
                            NameTable = nameTable
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

        private record StringLayer(Parameter PointerParameter, Parameter StringParameter, StringLayer.StringType Type) : IOverloadLayer
        {
            internal enum StringType
            {
                Char8,
                Char16,
            }

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                switch (Type)
                {
                    case StringType.Char8:
                        writer.WriteLine($"byte* {nameTable[PointerParameter]} = (byte*)Marshal.StringToCoTaskMemUTF8({nameTable[StringParameter]});");
                        break;
                    case StringType.Char16:
                        writer.WriteLine($"char* {nameTable[PointerParameter]} = (char*)Marshal.StringToCoTaskMemAuto({nameTable[StringParameter]});");
                        break;
                    default:
                        throw new Exception($"Unknown string type '{Type}'.");
                }
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
                if (StringLengthParameter.Type is CSPrimitive primitive)
                {
                    // If the parameter is unsigned we need to cast it for AllocCoTaskMem
                    if (primitive.TypeName == "int")
                    {
                        writer.WriteLine($"var {nameTable[PointerParameter]} = (byte*)Marshal.AllocCoTaskMem({nameTable[StringLengthParameter]});");
                    }
                    else if (primitive.TypeName == "uint")
                    {
                        
                        writer.WriteLine($"var {nameTable[PointerParameter]} = (byte*)Marshal.AllocCoTaskMem((int){nameTable[StringLengthParameter]});");
                    }
                    else
                    {
                        throw new Exception($"Unsupported primitive type for length parameter ({primitive.ToCSString()})!");
                    }
                }
                else if (StringLengthParameter.Type is CSPointer pointer && pointer.BaseType is CSPrimitive basePrimitive)
                {
                    if (basePrimitive.TypeName == "int")
                    {
                        // This case is needed for ExtGetProgramBinarySourceQCOM and ExtGetProgramBinarySourceQCOM
                        // - 2022-03-22
                        writer.WriteLine($"var {nameTable[PointerParameter]} = (byte*)Marshal.AllocCoTaskMem(*{nameTable[StringLengthParameter]});");
                    }
                    else
                    {
                        throw new Exception($"Unsupported pointer type for length parameter ({pointer.ToCSString()})!");
                    }
                }
                else
                {
                    throw new Exception($"Unsupported type for length parameter ({StringLengthParameter.Type.ToCSString()})");
                }
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                writer.WriteLine($"{nameTable[StringParameter]} = Marshal.PtrToStringUTF8((IntPtr){nameTable[PointerParameter]})!;");
                writer.WriteLine($"Marshal.FreeCoTaskMem((IntPtr){nameTable[PointerParameter]});");
                return returnName;
            }
        }
    }

    internal class SpanAndArrayOverloader : IOverloader
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
                    string? lengthParamName = Expression.InvertExpressionAndGetReferencedName(param.Length, out var expr);
                    var pointerParam = newParams[i];
                    if (pointerParam.Type is not CSPointer pointer)
                        throw new Exception("A parameter with a 'len' attribute must be a pointer type!");

                    Parameter? oldLength = null;
                    int spanArrayParameterIndex = i;
                    Parameter? paramToBeRemoved = null;
                    bool shouldCalculateLength = overload.InputParameters.Count(p => p.Length == param.Length) <= 1 && lengthParamName != null;
                    if (shouldCalculateLength)
                    {
                        // If this is the only len attribute that references this parameter,
                        // we can remove that parameter as we can calculate it from the length of this parameter (array/span).
                        // FIXME: This check is going to fail if the two 'len' attributes have different "forms" e.g. "n" == "n*4" == "COMPSIZE(n)" etc.
                        int lengthParamIndex =
                            Array.FindIndex(overload.InputParameters, p => p.Name == lengthParamName);
                        oldLength = overload.InputParameters[lengthParamIndex];

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

                    bool isBaseTypeConstant = false;
                    if (pointer.BaseType is IConstantCSType constantType)
                    {
                        isBaseTypeConstant = constantType.Constant;
                    }

                    var spanNameTable = overload.NameTable.New();
                    var arrayNameTable = overload.NameTable.New();

                    spanNameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");
                    arrayNameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");

                    var newSpanParams = spanOverload.InputParameters.Where(p => p != paramToBeRemoved).ToArray();
                    var newArrayParams = arrayOverload.InputParameters.Where(p => p != paramToBeRemoved).ToArray();

                    newSpanParams[spanArrayParameterIndex] = newSpanParams[spanArrayParameterIndex] with
                    {
                        Type = new CSSpan(baseType, isBaseTypeConstant)
                    };
                    newArrayParams[spanArrayParameterIndex] = newArrayParams[spanArrayParameterIndex] with
                    {
                        Type = new CSArray(baseType)
                    };

                    var spanLayer = new SpanOrArrayLayer(pointerParam, newSpanParams[spanArrayParameterIndex], oldLength, expr, baseType);
                    var arrayLayer = new SpanOrArrayLayer(pointerParam, newArrayParams[spanArrayParameterIndex], oldLength, expr, baseType);

                    spanOverload = spanOverload with
                    {
                        NestedOverload = spanOverload,
                        MarshalLayerToNested = spanLayer,
                        InputParameters = newSpanParams,
                        NameTable = spanNameTable,
                        GenericTypes = genericTypes
                    };
                    arrayOverload = arrayOverload with
                    {
                        NestedOverload = arrayOverload,
                        MarshalLayerToNested = arrayLayer,
                        InputParameters = newArrayParams,
                        NameTable = arrayNameTable,
                        GenericTypes = genericTypes
                    };
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
            Parameter? LengthParameter,
            Func<string, string> ParameterExpression,
            BaseCSType BaseType) : IOverloadLayer
        {
            private CsScope _csScope;

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                // NOTE: We are casting the length field to the target mathType because some of
                // the functions don't take `int` types directly, instead they take an `IntPtr`.
                // But that is fine because we can cast `int`s to `IntPtr`.
                // This is slightly fragile but it's fine for now.
                // - Noggin_bops 2021-01-22
                if (LengthParameter != null)
                {
                    var byteSize = BaseType is CSGenericType ? $" * sizeof({BaseType.ToCSString()})" : "";
                    var lengthExpression = ParameterExpression(nameTable[SpanOrArrayParameter]);
                    writer.WriteLine(
                        $"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = ({LengthParameter.Type.ToCSString()})({lengthExpression}{byteSize});");
                }

                writer.WriteLine($"fixed ({PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = {nameTable[SpanOrArrayParameter]})");
                _csScope = writer.CsScope();
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                _csScope.Dispose();
                return returnName;
            }
        }
    }

    internal class RefInsteadOfPointerOverloader : IOverloader
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
                        case CSPrimitive bt:
                            baseType = pt.BaseType;
                            constant |= bt.Constant;
                            break;
                        case CSEnum bt:
                            baseType = pt.BaseType;
                            constant |= bt.Constant;
                            break;
                        case CSStructPrimitive bt:
                            baseType = pt.BaseType;
                            constant = bt.Constant;
                            break;
                        case CSStruct bt:
                            baseType = pt.BaseType;
                            constant |= bt.Constant;
                            break;
                        case CSBool8 bt:
                            baseType = pt.BaseType;
                            constant |= bt.Constant;
                            break;
                        case CSBool32 bt:
                            baseType = pt.BaseType;
                            constant |= bt.Constant;
                            break;

                        case CSPointer:
                        case CSChar8:
                        case CSChar16:
                            continue;

                        default:
                            throw new InvalidOperationException($"{pt} is not supported by the ref overloader.");
                    }
                    // FIXME: When do we know it's an out ref mathType?
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
                    overload with {
                        NestedOverload = overload,
                        MarshalLayerToNested = layer,
                        InputParameters = parameters,
                        NameTable = nameTable,
                        GenericTypes = genericTypes
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

    internal class OutToReturnOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            var oldParameters = overload.InputParameters;
            if (overload.ReturnType is not CSVoid || oldParameters.Length == 0)
            {
                newOverloads = null;
                return false;
            }

            // Find the one and only out parameter, if there are more we do an early return.
            Parameter[] newParameters = new Parameter[oldParameters.Length - 1];
            Parameter? outParameter = null;
            CSRef? outType = null;
            int newIndex = 0; // The destination index of parameters
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
                else if (newIndex != oldParameters.Length - 1)
                {
                    newParameters[newIndex] = parameter;
                    newIndex++;
                }
            }

            if (outType == null || outParameter == null)
            {
                newOverloads = null;
                return false;
            }

            var nameTable = overload.NameTable.New();
            nameTable.ReturnName = outParameter.Name;

            newOverloads = new List<Overload>()
            {
                overload with
                {
                    NestedOverload = overload,
                    InputParameters = newParameters,
                    ReturnType = outType!.ReferencedType,
                    MarshalLayerToNested = new OutToReturnOverloadLayer(outParameter, outType),
                    NameTable = nameTable,
                },
                overload,
            };
            return true;
        }

        private record OutToReturnOverloadLayer(Parameter OutParameter, CSRef OutType) : IOverloadLayer
        {
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                //writer.WriteLine($"{OutType.ReferencedType.ToCSString()} {nameTable[OutParameter]};");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                return OutParameter.Name;
            }
        }
    }
}
