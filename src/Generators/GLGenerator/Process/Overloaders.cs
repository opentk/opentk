using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using GLGenerator.Parsing;
using GeneratorBase.Utility;
using GeneratorBase.Utility.Extensions;
using GLGenerator.Process;
using GeneratorBase;

namespace GLGenerator.Process
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
            //new GetReturnOverloader(),
            new BoolReturnOverloader(),

            new ColorTypeOverloader(),
            new MathTypeOverloader(),
            new FunctionPtrToDelegateOverloader(),
            new PointerToOffsetOverloader(),
            new VoidPtrToIntPtrOverloader(),
            new GenCreateAndDeleteOverloader(),
            new StringOverloader(),
            new StringArrayOverloader(),
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
            if (overload.NativeFunction.EntryPoint.StartsWith("glGet") &&
                overload.NativeFunction.EntryPoint.StartsWith("glGetUniform") == false &&
                overload.NativeFunction.EntryPoint.StartsWith("glGetVertexAttrib") == false
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
                    if (overload.InputParameters[^1].Length is not null)
                    {
                        // If there is a length and it's not "1", we don't generate an overload.
                        if (overload.InputParameters[^1].Length is ConstantExpression constant && constant.Value != 1)
                        {
                            newOverloads = null;
                            return false;
                        }
                    }

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
                var layer = new StringReturnLayer(new CSPointer(CSPrimitive.Byte(true), true), newReturnName, overload.NameTable.ReturnName!);
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

                    if (parameter.Length is ConstantExpression constant)
                    {
                        int colorSize = constant.Value;
                        if (colorSize > 4 || colorSize < 3)
                            throw new Exception($"The kind=Color parameter {parameter.Name} in {overload.NativeFunction.EntryPoint} was marked with a size that was not 3 or 4. length: {colorSize}");

                        string colorSpace = colorSize == 4 ? "Rgba" : "Rgb";

                        nameTable.Rename(parameter, $"{parameter.Name}_ptr");

                        // FIXME: ref vs ref readonly depending on Constant memeber
                        Parameter colorParameter = parameter with { Type = new CSRef(CSRef.Type.RefReadonly, new CSStruct($"Color{colorSize}<{colorSpace}>", pointer.Constant)), Length = null };

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
                        if (parameter.Length is ConstantExpression constant)
                        {
                            // Verify length with kind
                            Debug.Assert(_kindSize[mathKind] == constant.Value);
                        }
                        else if (parameter.Length is BinaryOperationExpression binaryOperation)
                        {
                            if (binaryOperation.TryDecomposeIntoParameterRefAndConstant(out ConstantExpression? @const, out ParameterReferenceExpression? parameterReference))
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

                        Parameter refParamter = parameter with { Type = new CSRef(baseType.Constant ? CSRef.Type.RefReadonly : CSRef.Type.Ref, mathType), Length = null };
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

                            Parameter refParamter = parameter with { Type = new CSRef(baseType.Constant ? CSRef.Type.RefReadonly : CSRef.Type.Ref, mathType), Length = null };
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

                if (parameter.Type is CSOpaqueFunctionPointer fpt)
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
                Type = CSPrimitive.Nint(false),
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
                parameters[i] = parameter with { Type = CSPrimitive.IntPtr(false), Length = null };
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

            if (pointerParameter.Length == null || pointerParameter.Length is not ParameterReferenceExpression handleLength)
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
            nameTable.MarkFixed(overload.InputParameters[lengthParameterIndex]);

            IOverloadLayer layer;
            if (nativeName.StartsWith("Delete"))
            {
                parameters[^1] = pointerParameter with
                {
                    // Remove ending 's' in parameter name.
                    // This works for Queries/Query because the parameter names in these functions is "ids
                    // - 2022-06-27
                    Name = newPointerParameterName,
                    Type = pointerParameterType.BaseType,
                    Length = null
                };
                layer = new DeleteOverloadLayer(overload.InputParameters[lengthParameterIndex], parameters[^1], pointerParameter);
            }
            else
            {
                parameters[^1] = pointerParameter with
                {
                    // Remove ending 's' in parameter name.
                    // This works for Queries/Query because the parameter names in these functions is "ids
                    // - 2022-06-27
                    Name = newPointerParameterName,
                    Type = new CSRef(CSRef.Type.Out, pointerParameterType.BaseType),
                    Length = null
                };
                layer = new GenAndCreateOverloadLayer(overload.InputParameters[lengthParameterIndex], parameters[^1], pointerParameter);
            }

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
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine($"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = 1;");
                writer.WriteLine($"{PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = &{nameTable[InParameter]};");
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                return returnName;
            }
        }

        private record GenAndCreateOverloadLayer(Parameter LengthParameter,
            Parameter OutParameter,
            Parameter PointerParameter) : IOverloadLayer
        {
            private CsScope? _csScope = null;
            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
                writer.WriteLine($"{LengthParameter.Type.ToCSString()} {nameTable[LengthParameter]} = 1;");
                writer.WriteLine($"Unsafe.SkipInit(out {nameTable[OutParameter]});");
                if (nameTable.IsFixed(OutParameter))
                {
                    writer.WriteLine($"{PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = &{nameTable[OutParameter]};");
                    _csScope = null;
                }
                else
                {
                    writer.WriteLine($"fixed({PointerParameter.Type.ToCSString()} {nameTable[PointerParameter]} = &{nameTable[OutParameter]})");
                    _csScope = writer.CsScope();
                }
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                if (_csScope.HasValue)
                    _csScope.Value.Dispose();

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
                var param = newParams[i];

                // There are a few functions that are supposed to take string arguments but are defined as
                // GLubyte* or unsigned byte*. The ones marked with kind="String" we overload so that they get the correct signature.
                // - Noggin_bops 2024-09-23
                if (param.Kinds.Contains("String") && param.Type is CSPointer spt && spt.BaseType is CSPrimitive sbt && sbt.TypeName == "byte")
                {
                    var pointerParam = newParams[i];
                    var nameTable = newOverload.NameTable.New();
                    nameTable.Rename(pointerParam, $"{pointerParam.Name}_ptr");

                    StringLayer.StringType stringType = StringLayer.StringType.Char8;

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
                else if (param.Type is CSPointer pt && pt.BaseType is ICSCharType bt)
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

    internal class StringArrayOverloader : IOverloader
    {
        public bool TryGenerateOverloads(Overload overload, [NotNullWhen(true)] out List<Overload>? newOverloads)
        {
            int stringArrayParameterIndex = -1;
            for (int i = 0; i < overload.InputParameters.Length; i++)
            {
                var param = overload.InputParameters[i];

                if (param.Type is CSPointer pointer && pointer.BaseType is CSPointer pointer2 && pointer2.BaseType is ICSCharType bt)
                {
                    Debug.Assert(stringArrayParameterIndex == -1, "We only expect one string array argument per function.");
                    Debug.Assert(bt is CSChar8);
                    stringArrayParameterIndex = i;
                }
            }

            if (stringArrayParameterIndex != -1)
            {
                List<Parameter> newParams = new List<Parameter>(overload.InputParameters);

                var nameTable = overload.NameTable.New();

                var arrayParam = newParams[stringArrayParameterIndex];
                nameTable.Rename(arrayParam, $"{arrayParam.Name}_ptr");
                newParams[stringArrayParameterIndex] = arrayParam with { Type = new CSArray(new CSString(false)) };

                StringArrayLayer.StringType stringType = ((arrayParam.Type as CSPointer)!.BaseType as CSPointer)!.BaseType switch
                {
                    CSChar8 => StringArrayLayer.StringType.Char8,
                    CSChar16 => StringArrayLayer.StringType.Char16,
                    _ => throw new Exception("Unknown string type!"),
                };

                // FIXME: Can we know if the string is nullable or not?
                newParams[stringArrayParameterIndex] = newParams[stringArrayParameterIndex] with { Type = new CSArray(new CSString(Nullable: false)) };
                var stringParams = newParams.ToArray();
                var stringArrayLayer = new StringArrayLayer(arrayParam, newParams[stringArrayParameterIndex], stringType);

                newOverloads = [overload with
                {
                    NestedOverload = overload,
                    MarshalLayerToNested = stringArrayLayer,
                    InputParameters = newParams.ToArray(),
                    NameTable = nameTable
                }];
                return true;
            }
            else
            {
                newOverloads = null;
                return false;
            }
        }


        private record StringArrayLayer(Parameter PointerParameter, Parameter StringArrayParameter, StringArrayLayer.StringType Type) : IOverloadLayer
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
                        writer.WriteLine($"byte** {nameTable[PointerParameter]} = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8({nameTable[StringArrayParameter]});");
                        break;
                    case StringType.Char16:
                        writer.WriteLine($"char** {nameTable[PointerParameter]} = (char**)MarshalTk.StringArrayToCoTaskMemUni({nameTable[StringArrayParameter]});");
                        break;
                    default:
                        throw new Exception($"Unknown string type '{Type}'.");
                }
            }

            public string? WriteEpilogue(IndentedTextWriter writer, NameTable nameTable, string? returnName)
            {
                writer.WriteLine($"MarshalTk.FreeStringArrayCoTaskMem((IntPtr){nameTable[PointerParameter]}, {nameTable[StringArrayParameter]}.Length);");
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
            List<Parameter> newArrayParams = new List<Parameter>(overload.InputParameters);
            List<Parameter> newSpanParams = new List<Parameter>(overload.InputParameters);
            string[] genericTypes = overload.GenericTypes;
            Overload arrayOverload = overload;
            Overload spanOverload = overload;

            // FIXME: We would ideally combine all span and array overloads into a single overload layer
            // to reduce fixed() nesting in the generated code.
            // - Noggin_bops 2024-03-16
            for (int i = 0; i < overload.InputParameters.Length; i++)
            {
                Parameter param = overload.InputParameters[i];

                if (param.Type is CSPointer pointer)
                {
                    if (pointer.BaseType is CSChar8)
                    {
                        Logger.Warning($"Char pointer leaked from earlier overloaders: \"{overload.NativeFunction.EntryPoint}\" ({param})");
                        continue;
                    }
                    else if (pointer.BaseType is CSPointer)
                    {
                        // FIXME: Maybe we can generate an IntPtr[] overload when this happens?
                        // - Noggin_bops 2025-08-08
                        Logger.Warning($"Pointer leaked from earlier overloaders: \"{overload.NativeFunction.EntryPoint}\" ({param})");
                        continue;
                    }
                    else
                    {
                        // If the parameter has length 1 there is no point in having an array overload.
                        // We leave it to be ref overloaded instead.
                        // - Noggin_bops 2024-03-16
                        if (param.Length is ConstantExpression constant && constant.Value == 1)
                        {
                            continue;
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

                        spanNameTable.Rename(param, $"{param.Name}_ptr");
                        arrayNameTable.Rename(param, $"{param.Name}_ptr");

                        newArrayParams[i] = newArrayParams[i] with { Type = new CSArray(baseType) };
                        newSpanParams[i] = newSpanParams[i] with { Type = new CSSpan(baseType, isBaseTypeConstant) };

                        var arrayLayer = new SpanOrArrayLayer(param, newArrayParams[i]);
                        var spanLayer = new SpanOrArrayLayer(param, newSpanParams[i]);

                        arrayOverload = arrayOverload with
                        {
                            NestedOverload = arrayOverload,
                            MarshalLayerToNested = arrayLayer,
                            InputParameters = newArrayParams.ToArray(),
                            NameTable = arrayNameTable,
                            GenericTypes = genericTypes
                        };
                        spanOverload = spanOverload with
                        {
                            NestedOverload = spanOverload,
                            MarshalLayerToNested = spanLayer,
                            InputParameters = newSpanParams.ToArray(),
                            NameTable = spanNameTable,
                            GenericTypes = genericTypes
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
            Parameter SpanOrArrayParameter) : IOverloadLayer
        {
            private CsScope _csScope;

            public void WritePrologue(IndentedTextWriter writer, NameTable nameTable)
            {
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

                    bool outParamSuitable;
                    if (parameter.Length != null)
                    {
                        if (parameter.Length is ConstantExpression c && c.Value == 1)
                        {
                            // The length is 1, in/out overload is suitable.
                            outParamSuitable = true;
                        }
                        else if (parameter.Length is CompSizeExpression && overload.NativeFunction.EntryPoint.StartsWith("glGet"))
                        {
                            // We assume that all glGet* functions with CompSize arguments are fine to mark as out
                            outParamSuitable = true;
                        }
                        else
                        {
                            // Non-zero length, not suitable for out overload.
                            outParamSuitable = false;
                        }
                    }
                    else
                    {
                        // If there is no length parameter we have very little information
                        // about if this parameter is suitable as an out parameter.
                        // Therefore we take a safe bet that it's not suitable.
                        // - Noggin_bops 2024-03-16
                        outParamSuitable = false;
                    }

                    CSRef.Type refType;
                    // This is a list of functions that either have "in" parameters not marked with const in gl.xml
                    // or functions that use the same pointer parameter for both input and output.
                    // - Noggin_bops 2024-03-16
                    // FIXME: Check GLX for non-const in parameters and ref parameters!
                    switch (overload.NativeFunction.EntryPoint)
                    {
                        // FIXME: glImportMemoryWin32HandleEXT should take a HANDLE object, i.e. IntPtr....
                        case "glImportMemoryWin32HandleEXT"   when parameter.Name == "handle":       refType = CSRef.Type.RefReadonly; break;
                        case "glSelectPerfMonitorCountersAMD" when parameter.Name == "counterList":  refType = CSRef.Type.RefReadonly; break;
                        case "glSharpenTexFuncSGIS"           when parameter.Name == "points":       refType = CSRef.Type.RefReadonly; break;
                        case "glVertexArrayRangeAPPLE"        when parameter.Name == "pointer":      refType = CSRef.Type.RefReadonly; break;
                        // FIXME: Should we have glCullParameter*vEXT here? They have len="4" and never get triggered...
                        case "glCullParameterdvEXT"           when parameter.Name == "params":       refType = CSRef.Type.RefReadonly; break;
                        case "glCullParameterfvEXT"           when parameter.Name == "params":       refType = CSRef.Type.RefReadonly; break;
                        case "glDeletePerfMonitorsAMD"        when parameter.Name == "monitors":     refType = CSRef.Type.RefReadonly; break;
                        case "glFlushVertexArrayRangeAPPLE"   when parameter.Name == "pointer":      refType = CSRef.Type.RefReadonly; break;

                        case "wglDXLockObjectsNV"             when parameter.Name == "hObjects":     refType = CSRef.Type.RefReadonly; break;
                        case "wglDXOpenDeviceNV"              when parameter.Name == "dxDevice":     refType = CSRef.Type.RefReadonly; break;
                        case "wglDXRegisterObjectNV"          when parameter.Name == "dxObject":     refType = CSRef.Type.RefReadonly; break;
                        case "wglDXSetResourceShareHandleNV"  when parameter.Name == "dxObject":     refType = CSRef.Type.RefReadonly; break;
                        case "wglDXUnlockObjectsNV"           when parameter.Name == "hObjects":     refType = CSRef.Type.RefReadonly; break;
                        case "wglGetPixelFormatAttribfvEXT"   when parameter.Name == "piAttributes": refType = CSRef.Type.RefReadonly; break;
                        case "wglGetPixelFormatAttribivEXT"   when parameter.Name == "piAttributes": refType = CSRef.Type.RefReadonly; break;

                        // We do the special handling above so that we can assume that any parameter that is not marked
                        // "const" here is an out parameter.
                        // Any potential ref parameters should be handled above.
                        // - Noggin_bops 2024-03-16
                        default: refType = constant ? CSRef.Type.RefReadonly : outParamSuitable ? CSRef.Type.Out : CSRef.Type.Ref;  break;
                    }

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
                // First we take references to all already "fixed" variables.
                for (int i = 0; i < RefParameters.Count; i++)
                {
                    if (nameTable.IsFixed(RefParameters[i]))
                    {
                        string type = PointerParameters[i].Type.ToCSString();
                        writer.WriteLine($"{type} {nameTable[PointerParameters[i]]} = &{nameTable[RefParameters[i]]};");
                    }
                }

                // Second we fix all of the not already fixed parameters.
                for (int i = 0; i < RefParameters.Count; i++)
                {
                    if (nameTable.IsFixed(RefParameters[i]) == false)
                    {
                        string type = PointerParameters[i].Type.ToCSString();
                        writer.WriteLine($"fixed ({type} {nameTable[PointerParameters[i]]} = &{nameTable[RefParameters[i]]})");
                    }
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

            if (oldParameters[^1].Type is CSRef pRef && pRef.RefType == CSRef.Type.Out)
            {
                Parameter[] newParameters = new Parameter[oldParameters.Length - 1];
                Array.Copy(oldParameters, newParameters, newParameters.Length);
                Parameter? outParameter = oldParameters[^1];
                CSRef? outType = pRef;

                NameTable nameTable = overload.NameTable.New();
                nameTable.ReturnName = outParameter.Name;

                // This is now a local variable.
                nameTable.MarkFixed(outParameter);

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
            else
            {
                newOverloads = null;
                return false;
            }
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
