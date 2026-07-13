using GeneratorBase;
using GeneratorBase.Utility;
using GeneratorBase.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CLGenerator.Parsing
{
    internal class SpecificationParser
    {
        public record TypeDefine(string Name, string Type) : IReferable
        {
            public BaseCSType StrongType;
            public List<Function> ReferencedBy { get; } = [];
        };
        internal record TypeEntry(BaseCSType CSType, IReferable Referable);

        public record TypeData(
            List<TypeDefine> Typedefs,
            List<StructType> Structs);

        internal static SpecificationFile Parse(Stream input, NameMangler nameMangler, ApiFile currentFile, List<string> ignoreFunctions)
        {
            XDocument? xdocument = XDocument.Load(input);

            if (xdocument.Root == null)
                throw new NullReferenceException("The parsed xml didn't contain a Root node.");

            // FIXME: Parse #defines like in vulkan.
            TypeData types = ParseTypes(xdocument.Root, nameMangler);

            // FIXME: Parse constants.

            List<Function> functions = ParseCommands(xdocument.Root, nameMangler, currentFile, ignoreFunctions);
            List<EnumEntry> enums = ParseEnums(xdocument.Root, nameMangler, currentFile);

            List<Feature> features = ParseFeatures(xdocument.Root, currentFile, ignoreFunctions);
            List<Extension> extensions = ParseExtensions(xdocument.Root, currentFile, nameMangler, ignoreFunctions);

            ResolveFunctionTypes(functions, types);
            ResolveStructMemberTypes(types.Structs, types);

            // FIXME: Add type map here...
            return new SpecificationFile(currentFile, functions, enums, types.Structs, features, extensions);
        }

        private static void ResolveFunctionTypes(List<Function> functions, TypeData typeData)
        {
            Dictionary<string, TypeEntry> typeMap = [];
            foreach (TypeDefine typedef in typeData.Typedefs)
            {
                typeMap.Add(typedef.Name, new TypeEntry(typedef.StrongType, typedef));
            }
            foreach (StructType @struct in typeData.Structs)
            {
                typeMap.Add(@struct.Name, new TypeEntry(new CSStruct(@struct.Name, true), @struct));
            }

            foreach (Function function in functions)
            {
                function.StrongReturnType = ParseType(function.ReturnType, typeMap, [], out IReferable? reference);
                reference?.MarkReferencedBy(function);

                foreach (Parameter parameter in function.Parameters)
                {
                    parameter.StrongType = ParseType(parameter.Type, typeMap, [], out reference);
                    reference?.MarkReferencedBy(function);
                }
            }
        }

        private static void ResolveStructMemberTypes(List<StructType> structs, TypeData typeData)
        {
            Dictionary<string, TypeEntry> typeMap = [];
            foreach (TypeDefine typedef in typeData.Typedefs)
            {
                typeMap.Add(typedef.Name, new TypeEntry(typedef.StrongType, typedef));
            }
            foreach (StructType @struct in typeData.Structs)
            {
                typeMap.Add(@struct.Name, new TypeEntry(new CSStruct(@struct.Name, true), @struct));
            }

            // FIXME: Parse the constants properly...
            Dictionary<string, Constant> constMap = new Dictionary<string, Constant>()
            {
                { "CL_NAME_VERSION_MAX_NAME_SIZE", new Constant(ConstantType.Int32, "CL_NAME_VERSION_MAX_NAME_SIZE", null, null, 64, default, "") },
                { "CL_NAME_VERSION_MAX_NAME_SIZE_KHR", new Constant(ConstantType.Int32, "CL_NAME_VERSION_MAX_NAME_SIZE_KHR", null, null, 64, default, "") },
                { "CL_QUEUE_FAMILY_MAX_NAME_SIZE_INTEL", new Constant(ConstantType.Int32, "CL_QUEUE_FAMILY_MAX_NAME_SIZE_INTEL", null, null, 64, default, "") },
                
            };

            foreach (StructType @struct in structs)
            {
                foreach (StructMember member in @struct.Members)
                {
                    member.StrongType = ParseType(member.Type, typeMap, constMap, out IReferable? reference);
                    //reference.MarkReferencedBy();
                }
            }
        }

        private static BaseCSType ParseType(string type, Dictionary<string, TypeEntry> typeMap, Dictionary<string, Constant> constantsMap, out IReferable? reference)
        {
            type = type.Trim();

            if (type.EndsWith('*') || type.EndsWith("[]"))
            {
                string? withoutPointer;
                // This removes the last character of the string, ^1 is an exclusive upper bound.
                if (type.EndsWith('*'))
                    withoutPointer = type[0..^"*".Length].TrimEnd();
                else
                    withoutPointer = type[0..^"[]".Length].TrimEnd();

                // A pointer is only const if const is directly in front of the pointer,
                // if the const is in front of the type the type is the constant and not the pointer.
                bool @const = false;
                if (withoutPointer.EndsWith("const"))
                {
                    @const = true;
                    withoutPointer = withoutPointer[0..^"const".Length];
                }

                BaseCSType? baseType = ParseType(withoutPointer, typeMap, constantsMap, out reference);

                // Some structs are created as CSOpaqueStructs, this means that the only 
                // valid way to use these is through a pointer. We intercept them here
                // and create the proper CSStructPrimitive types from them.
                // - Noggin_bops 2025-08-04
                if (baseType is CSOpaqueStruct opaque)
                {
                    switch (opaque.TypeName)
                    {
                        case "cl_icd_dispatch":
                            return CSPrimitive.IntPtr(opaque.Constant);//new CSStructPrimitive("cl_icd_dispatch", opaque.Constant, CSPrimitive.IntPtr(true));
                        default:
                            throw new Exception($"Unknown opaque struct type {opaque.TypeName}.");
                    }
                }
                else
                {
                    return new CSPointer(baseType, @const);
                }
            }
            else if (type.EndsWith(']'))
            {
                // To simplify the code we just detect this special case.
                if (type == "float[3][4]")
                {
                    // FIXME: Is it Matrix4x3 or Matrix3x4??
                    reference = null;
                    return new CSStruct("Matrix4x3", false);
                }

                int startIndex = type.LastIndexOf('[');
                string sizeStr = type[(startIndex + 1)..^1];

                ulong size;
                if (constantsMap.TryGetValue(sizeStr, out Constant? @const))
                {
                    if (@const.Type == ConstantType.Float)
                    {
                        throw new Exception("Cannot make a fixed array with a float size!");
                    }

                    size = @const.IntValue;
                }
                else if (int.TryParse(sizeStr, out int iSize))
                {
                    size = (ulong)iSize;
                }
                else
                {
                    throw new Exception();
                }

                string typeWithoutArray = type[..startIndex];

                BaseCSType baseType = ParseType(typeWithoutArray, typeMap, constantsMap, out reference);

                return new CSFixedSizeArray(baseType, size);
            }
            else if (type.Contains(':'))
            {
                int colonIndex = type.IndexOf(':');
                int bitWidth = int.Parse(type[(colonIndex + 1)..]);

                string typeWithoutBitfield = type[0..colonIndex].TrimEnd();
                BaseCSType baseType = ParseType(typeWithoutBitfield, typeMap, constantsMap, out reference);

                return new CSBitfield(baseType, bitWidth);
            }
            else if (type.Contains('('))
            {
                // This needs to be a function pointer in the form:
                // return (*)(param1 [name1], param2 [name2], ...)

                Regex fnptrRegex = new Regex(@"^(\w+)\s*\(\w*\s*\*\s*(\w*)\)\s*\((.*)\)$");
                Match match = fnptrRegex.Match(type);
                if (match.Success)
                {
                    List<IReferable> referables = new List<IReferable>();

                    string returnTypeStr = match.Groups[1].Value;
                    BaseCSType returnType = ParseType(returnTypeStr, typeMap, constantsMap, out IReferable? returnTypeReferable);
                    if (returnTypeReferable != null)
                        referables.Add(returnTypeReferable);

                    string fnptrName = match.Groups[2].Value;

                    string[] @params = match.Groups[3].Value.Split(',', StringSplitOptions.TrimEntries);
                    List<BaseCSType> parameterTypes = new List<BaseCSType>(@params.Length);
                    for (int i = 0; i < @params.Length; i++)
                    {
                        // For now we don't deal with nested function pointer types.
                        Regex parameterRegex = new Regex(@"^(?:const\s+)*(?:\w+)(?:(?:const)?\*|(?:const)?\s)*(\w+)?\s*(?:\[+\d*\]+)*$");
                        Match parameterNameMatch = parameterRegex.Match(@params[i]);
                        if (parameterNameMatch.Success == false)
                            throw new Exception($"We currently don't support parsing function pointer parameter types with this syntax: {@params[i]}");
                        string paramType = @params[i].Remove(parameterNameMatch.Groups[1].Index, parameterNameMatch.Groups[1].Length);
                        parameterTypes.Add(ParseType(paramType, typeMap, constantsMap, out IReferable? parameterReference));
                        if (parameterReference != null)
                            referables.Add(parameterReference);
                    }

                    reference = new AggregateReferable(referables);
                    return new CSFunctionPointer(fnptrName, true, returnType, parameterTypes);
                }
                else
                {
                    throw new Exception($"Couldn't parse function pointer '{type}'");
                }
            }
            else
            {
                bool @const = false;
                if (type.StartsWith("const"))
                {
                    @const = true;
                    type = type["const".Length..].TrimStart();
                }

                // This is needed for _cl_context, and _cl_event
                // We don't care about struct here because it doesn't add any information (we are not a c compiler).
                if (type.StartsWith("struct"))
                {
                    type = type["struct".Length..].TrimStart();
                }

                if (typeMap.TryGetValue(type, out TypeEntry? csMapType))
                {
                    reference = csMapType.Referable;
                    return csMapType.CSType;
                }

                BaseCSType csType;
                {
                    csType = type switch
                    {
                        "void" => new CSVoid(@const),
                        "char" => new CSChar8(@const),
                        "uint8_t" => CSPrimitive.Byte(@const),
                        "int8_t" => CSPrimitive.Sbyte(@const),
                        "int" => CSPrimitive.Int(@const),
                        "uint16_t" => CSPrimitive.Ushort(@const),
                        "int16_t" => CSPrimitive.Short(@const),
                        "int32_t" => CSPrimitive.Int(@const),
                        "uint32_t" => CSPrimitive.Uint(@const),
                        "int64_t" => CSPrimitive.Long(@const),
                        "uint64_t" => CSPrimitive.Ulong(@const),

                        "unsigned char" => new CSChar8(@const),

                        "size_t" => CSPrimitive.Nuint(@const),
                        "intptr_t" => CSPrimitive.IntPtr(@const),

                        "float" => CSPrimitive.Float(@const),
                        "double" => CSPrimitive.Double(@const),

                        "ID3D10Buffer" => CSPrimitive.IntPtr(@const),
                        "ID3D10Texture2D" => CSPrimitive.IntPtr(@const),
                        "ID3D10Texture3D" => CSPrimitive.IntPtr(@const),
                        "ID3D11Buffer" => CSPrimitive.IntPtr(@const),
                        "ID3D11Texture2D" => CSPrimitive.IntPtr(@const),
                        "ID3D11Texture3D" => CSPrimitive.IntPtr(@const),
                        "IDirect3DSurface9" => CSPrimitive.IntPtr(@const),
                        "D3DFORMAT" => CSPrimitive.Uint(@const),
                        "HANDLE" => CSPrimitive.IntPtr(@const),
                        "DXGI_FORMAT" => CSPrimitive.Uint(@const),
                        "UINT" => CSPrimitive.Uint(@const),

                        "VASurfaceID" => CSPrimitive.Uint(@const),
                        "VAImageFormat" => new CSStruct("VAImageFormat", @const),

                        _ => throw new Exception($"Type conversion has not been created for type {type}"),
                    };
                }

                reference = null;
                return csType;
            }
        }

        private static TypeData ParseTypes(XElement input, NameMangler nameMangler)
        {
            List<TypeDefine> typedefs = new List<TypeDefine>();
            List<StructType> structs = new List<StructType>();
            foreach (XElement typesElement in input.Elements("types"))
            {
                foreach (XElement type in typesElement.Elements("type"))
                {
                    string? category = type.Attribute("category")?.Value;
                    if (category == "include")
                    {
                        continue;
                    }
                    else if (category == "basetype")
                    {
                        continue;
                    }
                    else if (category == "define")
                    {
                        if (type.Value.StartsWith("typedef"))
                        {
                            string name = type.Element("name")!.Value;

                            string? typeStr = type.GetXmlText(element => element.Name != "name" ? element.Value : string.Empty).Trim();
                            typeStr = NameMangler.RemoveStart(typeStr, "typedef");
                            typeStr = NameMangler.RemoveEnd(typeStr, ";");
                            int index = typeStr.IndexOf("__attribute__");
                            if (index >= 0)
                            {
                                typeStr = typeStr.Remove(index);
                            }
                            typeStr = typeStr.Trim();

                            typedefs.Add(new TypeDefine(name, typeStr));
                        }
                        else if (type.Value.StartsWith("#define"))
                        {

                        }
                        else if (type.Attribute("name")?.Value == "CL_ICD2_TAG_KHR")
                        {

                        }
                        else throw new Exception();
                    }
                    else if (category == "struct")
                    {
                        string name = type.Attribute("name")!.Value;

                        List<StructMember> members = [];
                        foreach (XElement member in type.Elements("member"))
                        {
                            if (member.Value.StartsWith("union"))
                            {
                                // FIXME: There is a single place in cl.xml where a member is expressed as a direct union
                                // we need to deal with this here.
                                continue;
                            }

                            string? values = member.Attribute("values")?.Value;

                            bool[] optional = member.Attribute("optional")?.Value?.Split(',').Select(s => bool.Parse(s)).ToArray() ?? [];
                            string? len = member.Attribute("len")?.Value;
                            string? altLen = member.Attribute("altlen")?.Value;

                            string? typeStr = member.GetXmlText(element => (element.Name != "name" && element.Name != "comment") ? element.Value : string.Empty).Trim();
                            string memberName = member.Element("name")!.Value;
                            string? comment = member.Element("comment")?.Value;

                            ExternSyncInfo externsync = ParseExternSync(member.Attribute("externsync")?.Value);

                            members.Add(new StructMember(typeStr, memberName, comment)
                            {
                                Length = len,
                                AltLength = altLen,
                                ExternSync = externsync,
                                Values = values,
                            });
                        }

                        structs.Add(new StructType(name, members, false, default, default));
                    }
                    else throw new Exception();
                }
            }

            // FIXME: We don't need to resolve these types here, we should move this to a later stage...

            // cl.xml doesn't do typedefs in order, so we can't resolve them linearly.
            // So instead we need to do this non-linearly.
            Dictionary<string, BaseCSType> typeMap = new Dictionary<string, BaseCSType>(typedefs.Count)
            {
                { "int", CSPrimitive.Int(true) },
                { "unsigned int", CSPrimitive.Uint(true) },
                { "double", CSPrimitive.Double(true) },
                { "float", CSPrimitive.Float(true) },
                { "int16_t", CSPrimitive.Short(true) },
                { "int32_t", CSPrimitive.Int(true) },
                { "int64_t", CSPrimitive.Long(true) },
                { "int8_t", CSPrimitive.Sbyte(true) },
                { "uint8_t", CSPrimitive.Byte(true) },
                { "uint16_t", CSPrimitive.Ushort(true) },
                { "uint32_t", CSPrimitive.Uint(true) },
                { "uint64_t", CSPrimitive.Ulong(true) },
                { "intptr_t", CSPrimitive.IntPtr(true) },
                { "void", new CSVoid(true) },
            };
            List<TypeDefine> unresolvedTypes = new List<TypeDefine>(typedefs);
            bool resolvedAnyTypeThisIteration;
            do
            {
                resolvedAnyTypeThisIteration = false;

                for (int i = unresolvedTypes.Count - 1; i >= 0; i--)
                {
                    TypeDefine def = unresolvedTypes[i];

                    if (TryResolveType(def, typeMap, out BaseCSType? type))
                    {
                        def.StrongType = type;

                        typeMap.Add(def.Name, type);
                        resolvedAnyTypeThisIteration = true;

                        unresolvedTypes.RemoveAt(i);
                    }
                }

            } while (resolvedAnyTypeThisIteration);

            if (unresolvedTypes.Count > 0)
            {
                throw new Exception($"Was not able to resolve {unresolvedTypes.Count} types!");
            }

            return new TypeData(typedefs, structs);

            static ExternSyncInfo ParseExternSync(string? externSync)
            {
                if (string.IsNullOrEmpty(externSync))
                    return new ExternSyncInfo(ExternSyncType.None, null);

                if (externSync == "true")
                    return new ExternSyncInfo(ExternSyncType.Always, null);
                else if (externSync == "maybe")
                    return new ExternSyncInfo(ExternSyncType.Maybe, null);
                else if (externSync.StartsWith("maybe:"))
                    return new ExternSyncInfo(ExternSyncType.SubtypeMaybe, NameMangler.RemoveStart(externSync, "maybe:"));
                else
                    return new ExternSyncInfo(ExternSyncType.Subtype, externSync);
            }

            static bool TryResolveType(TypeDefine define, Dictionary<string, BaseCSType> typeMap, [NotNullWhen(true)] out BaseCSType? resolvedType)
            {
                if (typeMap.TryGetValue(define.Type, out resolvedType) == true)
                {
                    return true;
                }
                else if (define.Type.EndsWith('*'))
                {
                    string baseType = NameMangler.RemoveEnd(define.Type, "*");
                    Debug.Assert(baseType.Contains('*') == false);
                    if (typeMap.TryGetValue(baseType, out resolvedType))
                    {
                        // FIXME: Const???
                        resolvedType = new CSPointer(resolvedType, false);
                        return true;
                    }
                    else if (baseType.StartsWith("struct "))
                    {
                        // FIXME: Const???
                        //resolvedType = new CSPointer(new CSOpaqueStruct(NameMangler.RemoveStart(baseType, "struct "), true), false);
                        resolvedType = CSPrimitive.IntPtr(false);
                        return true;
                    }
                    else
                    {
                        resolvedType = null;
                        return false;
                    }
                }
                else if (define.Type == "struct _cl_icd_dispatch")
                {
                    // For some reason the definition of struct _cl_icd_dispatch is not included in cl.xml
                    // So for now we include it here as an opaque struct...
                    // - Noggin_bops 2026-07-12
                    resolvedType = new CSOpaqueStruct(define.Name, true);
                    return true;
                }
                else
                {
                    resolvedType = null;
                    return false;
                }
            }
        }

        private static List<Function> ParseCommands(XElement input, NameMangler nameMangler, ApiFile currentFile, List<string> ignoreFunctions)
        {
            Logger.Info("Begining parsing of commands.");
            List<Function> functions = new List<Function>();
            foreach (var commands in input.Elements("commands"))
            {
                foreach (XElement command in commands.Elements("command"))
                {
                    XElement proto = command.Element("proto") ?? throw new Exception("Missing proto tag!");

                    string entryPoint = proto.Element("name")?.Value ?? throw new Exception("Missing name tag!");
                    if (ignoreFunctions.Contains(entryPoint))
                    {
                        continue;
                    }

                    List<Parameter>? paramList = new List<Parameter>();
                    foreach (XElement? param in command.Elements("param"))
                    {
                        string paramName = param.Element("name")?.Value ?? throw new Exception("Missing parameter name!");
                        string mangledName = NameMangler.MangleParameterName(paramName);

                        string paramTypeStr = param.GetXmlText(element => element.Name != "name" && element.Name != "comment" ? element.Value : string.Empty);

                        string[] kinds = param.Attribute("kind")?.Value?.Split(',') ?? Array.Empty<string>();

                        string? length = param.Attribute("len")?.Value;
                        Expression? paramLength = length == null ? null : ParseExpression(length);

                        paramList.Add(new Parameter()
                        {
                            Name = mangledName,
                            OriginalName = paramName,
                            Type = paramTypeStr,
                            Length = length,

                            StrongType = null,
                            StrongLength = paramLength,

                            Kinds = kinds
                        });
                    }

                    string returnTypeStr = proto.GetXmlText(element => element.Name != "name" && element.Name != "comment" ? element.Value : string.Empty);

                    string functionName = nameMangler.MangleFunctionName(entryPoint);

                    functions.Add(new Function()
                    {
                        Name = functionName,
                        EntryPoint = entryPoint,
                        ReturnType = returnTypeStr,
                        Parameters = paramList,

                        ReferencedEnumGroups = [],
                    });
                }
            }
            return functions;
        }

        private static Expression ParseExpression(string expression)
        {
            Expression? retExpr = ParseExpressionPrio2(expression, out string leftOver);

            if (string.IsNullOrEmpty(leftOver) == false)
                throw new Exception($"Failed to parse expression '{expression}' with leftover '{leftOver}'");

            return retExpr;
        }

        private static Expression ParseExpressionPrio2(string expression, out string leftOver)
        {
            Expression? retExpr = ParseExpressionPrio1(expression, out string exp);
            exp = exp.TrimStart();

            BinaryOperator op;
            // GetOperation is a local function defined below return.
            while ((op = GetOperation(exp)) != BinaryOperator.Invalid)
            {
                exp = exp[1..];
                Expression? right = ParseExpressionPrio1(exp, out exp);
                exp = exp.TrimStart();

                retExpr = new BinaryOperationExpression(retExpr, op, right);
            }

            leftOver = exp;
            return retExpr;

            static BinaryOperator GetOperation(string expression)
            {
                if (expression.Length == 0) return BinaryOperator.Invalid;
                return expression[0] switch
                {
                    '+' => BinaryOperator.Addition,
                    '-' => BinaryOperator.Subtraction,
                    _ => BinaryOperator.Invalid,
                };
            }
        }

        private static Expression ParseExpressionPrio1(string expression, out string leftOver)
        {
            Expression? retExpr = ParseExpressionPrio0(expression, out string exp);
            exp = exp.TrimStart();

            BinaryOperator op;
            // GetOperation is a local function defined below return.
            while ((op = GetOperation(exp)) != BinaryOperator.Invalid)
            {
                exp = exp[1..];
                Expression? right = ParseExpressionPrio0(exp, out exp);
                exp = exp.TrimStart();

                retExpr = new BinaryOperationExpression(retExpr, op, right);
            }

            leftOver = exp;
            return retExpr;

            static BinaryOperator GetOperation(string expression)
            {
                if (expression.Length == 0) return BinaryOperator.Invalid;
                return expression[0] switch
                {
                    '*' => BinaryOperator.Multiplication,
                    '/' => BinaryOperator.Division,
                    _ => BinaryOperator.Invalid,
                };
            }
        }

        private static Expression ParseExpressionPrio0(string expression, out string leftOver)
        {
            expression = expression.TrimStart();
            if (expression.StartsWith("COMPSIZE("))
            {
                string? exp = expression["COMPSIZE(".Length..];
                List<Expression> arguments = new List<Expression>();
                while (exp[0] != ')')
                {
                    arguments.Add(ParseExpressionPrio2(exp, out exp));

                    // NOTE: Possible error here, if whitespaces are introduced in COMPSIZE() inside the spec.
                    if (exp[0] == ',')
                        exp = exp[1..];
                }
                // Remove the last ')'
                leftOver = exp[1..];
                return new CompSizeExpression(arguments.ToArray());
            }
            else if (char.IsDigit(expression[0]))
            {
                int i = 1;
                while (i < expression.Length && char.IsDigit(expression[i]))
                {
                    i++;
                }

                leftOver = expression[i..];
                return new ConstantExpression(int.Parse(expression[0..i]));
            }
            else if (char.IsLetter(expression[0]))
            {
                int i = 1;
                while (i < expression.Length && (char.IsLetterOrDigit(expression[i]) || expression[i] == '_'))
                {
                    i++;
                }

                leftOver = expression[i..];
                return new ParameterReferenceExpression(expression[0..i]);
            }
            else throw new Exception($"Could not parse expression '{expression}'");
        }

        private static BaseCSType ParseType(string type, GroupRef? group, NameMangler nameMangler)
        {
            type = type.Trim();

            if (type.EndsWith('*'))
            {
                // This removes the last character of the string, ^1 is an exclusive upper bound.
                string? withoutAsterisk = type[0..^1].TrimEnd();

                // A pointer is only const if const is directly in front of the pointer,
                // if the const is in front of the type the type is the constant and not the pointer.
                bool @const = false;
                if (withoutAsterisk.EndsWith("const"))
                {
                    @const = true;
                    withoutAsterisk = withoutAsterisk[0..^"const".Length];
                }

                BaseCSType? baseType = ParseType(withoutAsterisk, group, nameMangler);

                // Some structs are created as CSOpaqueStructs, this means that the only 
                // valid way to use these is through a pointer. We intercept them here
                // and create the proper CSStructPrimitive types from them.
                // - Noggin_bops 2024-03-07
                if (baseType is CSOpaqueStruct opaque)
                {
                    switch (opaque.TypeName)
                    {
                        default:
                            throw new Exception($"Unknown opaque struct type {opaque.TypeName}.");
                    }
                }
                else
                {
                    return new CSPointer(baseType, @const);
                }

            }
            else
            {
                bool @const = false;
                if (type.StartsWith("const"))
                {
                    @const = true;
                    type = type["const".Length..].TrimStart();
                }

                // This is needed for _cl_context, and _cl_event
                // We don't care about struct here because it doesn't add any information (we are not a c compiler).
                if (type.StartsWith("struct"))
                {
                    type = type["struct".Length..].TrimStart();
                }

                // For now we only expect int and uint to be able to be turned into groupNameToEnumGroup.
                // - 2022-08-09
                // FIXME: We might want to make sure that the underlying type for the enumName groupName is the same as the parameter groupName.
                //   Right now we blindly substituting the type for the enumName.
                if (group != null &&
                        (type == "cl_uint" ||
                        type == "cl_int" ||
                        type == "INT" ||
                        type == "UINT" ||
                        type == "INT32" ||
                        type == "int" ||
                        type == "int32_t"))
                {
                    Logger.Info($"Making {type} into group {group.TranslatedName}");
                    CSPrimitive baseType = type switch
                    {
                        "cl_int" => CSPrimitive.Int(@const),
                        "cl_uint" => CSPrimitive.Uint(@const),
                        "INT" => CSPrimitive.Int(@const),
                        "UINT" => CSPrimitive.Uint(@const),
                        "INT32" => CSPrimitive.Int(@const),
                        "int" => CSPrimitive.Int(@const),
                        "int32_t" => CSPrimitive.Int(@const),
                        _ => throw new Exception("This should not happen!"),
                    };

                    return new CSEnum(group.TranslatedName, baseType, @const);
                }
                
                BaseCSType csType;
                {
                    csType = type switch
                    {
                        "cl_platform_id" => CSPrimitive.IntPtr(@const),// FIXME? new CSPointer(new CSOpaqueStruct("CLPlatformID", @const), @const),

                        _ => throw new Exception($"Type conversion has not been created for type {type}"),
                    };
                }

                return csType;
            }
        }


        internal static List<EnumEntry> ParseEnums(XElement input, NameMangler nameMangler, ApiFile currentFile)
        {
            Logger.Info("Begining parsing of enums.");
            List<EnumEntry> enumsEntries = new List<EnumEntry>();
            foreach (XElement? enums in input.Elements("enums"))
            {
                string enumsTagName = enums.Attribute("name")?.Value ?? throw new Exception($"Enums entry '{enums}' is missing a name attribute.");

                // FIXME: Parse constants!
                if (enumsTagName.StartsWith("Constants") ||
                    enumsTagName == "MiscNumbers")
                {
                    continue;
                }

                GroupRef[] parentGroups = ParseGroups(enums.Attribute("group")?.Value, currentFile, nameMangler);

                string? vendor = enums.Attribute("vendor")?.Value;

                bool isFlags = IsEnumTypeBitmask(enums.Attribute("type")?.Value);

                string? enumsComment = enums.Attribute("comment")?.Value;

                foreach (XElement? @enum in enums.Elements("enum"))
                {
                    string? name = @enum.Attribute("name")?.Value;
                    EnumSize size = ParseEnumTypeSuffix(@enum.Attribute("type")?.Value);

                    string? bitposStr = @enum.Attribute("bitpos")?.Value;
                    string? valueStr = @enum.Attribute("value")?.Value;

                    // FIXME: We could technically parse these values but it's not worth the hassle atm.
                    // FIXME: Make this constant...
                    Dictionary<string, ulong> specialEnumValues = new Dictionary<string, ulong>
                    {
                        {"CL_TRUE", 1},
                        {"CL_FALSE", 0},
                    };

                    ulong value;
                    if (bitposStr != null)
                    {
                        value = 1ul << int.Parse(bitposStr);
                    }
                    else if (valueStr != null)
                    {
                        if (specialEnumValues.TryGetValue(valueStr, out value) == false)
                        {
                            // "(0xd+ << d+)" format
                            Match m = Regex.Match(valueStr, "\\((0x[0-9A-F]+) << (\\d+)\\)");
                            if (m.Success)
                            {
                                value = ConvertToUInt64(m.Groups[1].Value, size) << int.Parse(m.Groups[2].Value);
                            }
                            else
                            {
                                value = ConvertToUInt64(valueStr, size);
                            }
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }




                    string? alias = @enum.Attribute("alias")?.Value;

                    GroupRef[] groups = ParseGroups(@enum.Attribute("group")?.Value, currentFile, nameMangler);
                    // Mark this with all of the groups from the parent tag.
                    groups = ArrayUtil.MergeDeduplicate(groups, parentGroups);

                    string? enumComment = @enum.Attribute("comment")?.Value;

                    OutputApi api = ParseApi(@enum.Attribute("api")?.Value);
                    OutputApiFlags enumApi;
                    if (api == OutputApi.Invalid)
                    {
                        enumApi = currentFile switch
                        {
                            ApiFile.CL => OutputApiFlags.CL,

                            _ => throw new Exception(),
                        };
                    }
                    else 
                    {
                        enumApi = api switch
                        {
                            OutputApi.CL => OutputApiFlags.CL,

                            OutputApi.Invalid => throw new Exception(),
                            _ => throw new Exception(),
                        };
                    }

                    foreach (var group in groups)
                    {
                        switch (group.Namespace)
                        {
                            case ApiFile.CL:
                                enumApi |= OutputApiFlags.CL;
                                break;
                        }
                    }

                    enumsEntries.Add(new EnumEntry(nameMangler.MangleEnumName(name), name, value, enumApi, isFlags, vendor, alias, groups, size));
                }
            }

            return enumsEntries;

            static bool IsEnumTypeBitmask(string? value) => value switch
            {
                null or "" => false,
                "bitmask" => true,
                _ => throw new Exception(),
            };

            static EnumSize ParseEnumTypeSuffix(string? suffix) => suffix switch
            {
                // See https://github.com/KhronosGroup/OpenGL-Registry/blob/0dc24166d162723781f1bf9fe433f71fa03a7aa0/xml/readme.tex#L383
                // 2020-11-22
                null or "" => EnumSize.Int32,
                "u" => EnumSize.Uint32,
                "ull" => EnumSize.Uint64,
                _ => EnumSize.Invalid,
            };

            static ulong ConvertToUInt64(string val, EnumSize type)
            {
                if (val.StartsWith("EGL_CAST("))
                {
                    // FIXME: We could try to verify the type we are casting to here...
                    return (ulong)(long)new Int64Converter().ConvertFromString(val[(val.IndexOf(',')+1)..val.IndexOf(')')])!;
                }

                return type switch
                {
                    EnumSize.Int32 => (uint)(int)new Int32Converter().ConvertFromString(val)!,
                    EnumSize.Uint32 => (uint)new UInt32Converter().ConvertFromString(val)!,
                    EnumSize.Int64 => (ulong)new Int64Converter().ConvertFromString(val)!,
                    EnumSize.Uint64 => (ulong)new UInt64Converter().ConvertFromString(val)!,
                    EnumSize.Invalid or _ => throw new Exception($"Invalid suffix '{type}'!"),
                };
            }
        }

        internal static GroupRef[] ParseGroups(string? groups, ApiFile currentFile, NameMangler nameMangler)
        {
            if (groups == null) return [];

            string[] rawGroups = groups.Split(',', StringSplitOptions.RemoveEmptyEntries) ?? [];
            List<GroupRef> groupRefs = new List<GroupRef>(rawGroups.Length);
            for (int i = 0; i < rawGroups.Length; i++)
            {
                GroupRef group = GroupRefFromString(rawGroups[i], currentFile, nameMangler);
                // FIXME: Make this a per file "ignorable" group...
                if (group.OriginalName == "SpecialNumbers")
                    continue;
                groupRefs.Add(group);
            }

            return groupRefs.ToArray();
        }

        internal static GroupRef GroupRefFromString(string group, ApiFile currentFile, NameMangler nameMangler)
        {
            string name;
            ApiFile file;
            if (group.StartsWith("gl::"))
            {
                name = NameMangler.RemoveStart(group, "gl::");
                file = ApiFile.GL;
            }
            else if (group.StartsWith("wgl::"))
            {
                name = NameMangler.RemoveStart(group, "wgl::");
                file = ApiFile.WGL;
            }
            else if (group.StartsWith("glx::"))
            {
                name = NameMangler.RemoveStart(group, "glx::");
                file = ApiFile.GLX;
            }
            else
            {
                name = group;
                file = currentFile;
            }

            string translatedName = nameMangler.TranslateEnumGroupName(name);

            return new GroupRef(name, translatedName, file);
        }


        internal static List<Feature> ParseFeatures(XElement input, ApiFile currentFile, List<string> ignoreFunctions)
        {
            Logger.Info("Begining parsing of features.");

            List<Feature> features = new List<Feature>();

            foreach (XElement? feature in input.Elements("feature"))
            {
                string? apiStr = feature.Attribute("api")?.Value;
                if (apiStr == "glsc2")
                    continue;
                string? name = feature.Attribute("name")?.Value;
                string? number = feature.Attribute("number")?.Value;

                if (apiStr == null || name == null || number == null)
                {
                    throw new Exception($"Feature '{feature}' is missing an attribute.");
                }

                Version? version = Version.Parse(number);
                OutputApi api = ParseApiWithFileFallback(apiStr, currentFile);

                List<RequireTag> requireEntries = new List<RequireTag>();
                foreach (XElement? require in feature.Elements("require"))
                {
                    RequireTag reqTag = ParseRequire(require, ignoreFunctions);
                    if (reqTag.Api == OutputApi.Invalid)
                        reqTag = reqTag with { Api = api };
                    requireEntries.Add(reqTag);
                }

                List<RemoveTag> removeEntries = new List<RemoveTag>();
                foreach (XElement? remove in feature.Elements("remove"))
                {
                    RemoveTag removeTag = ParseRemove(remove, ignoreFunctions);
                    removeEntries.Add(removeTag);
                }

                features.Add(new Feature()
                {
                    Name = name,
                    Version = version,
                    RequireTags = requireEntries,
                    DeprecateTags = [],
                    RemoveTags = removeEntries,

                    Api = api,
                });
            }

            return features;
        }

        internal static List<Extension> ParseExtensions(XElement input, ApiFile currentFile, NameMangler nameMangler, List<string> ignoreFunctions)
        {
            List<Extension> extensions = new List<Extension>();
            foreach (var exts in input.Elements("extensions"))
            {
                foreach (XElement? extension in exts.Elements("extension"))
                {
                    string? extName = extension.Attribute("name")?.Value;
                    if (extName == null)
                    {
                        throw new Exception($"Extension '{extension}' is missing a name!");
                    }

                    // Remove "GL_" and get the vendor name from the first part of the extension name
                    // Extension name convention: "GL_VENDOR_EXTENSION_NAME"
                    string? extNameWithoutGLPrefix = nameMangler.RemoveExtensionPrefix(extName);
                    string? vendor = extNameWithoutGLPrefix[..extNameWithoutGLPrefix.IndexOf("_")];
                    if (string.IsNullOrEmpty(vendor))
                    {
                        throw new Exception($"Extension '{extension}' doesn't have the vendor in it's name!");
                    }

                    if (char.IsDigit(vendor[0]))
                    {
                        vendor = "_" + vendor;
                    }

                    string? comment = extension.Attribute("comment")?.Value;

                    OutputApi[]? supportedApis = extension
                        .Attribute("supported")?.Value?
                        .Split('|', StringSplitOptions.RemoveEmptyEntries)
                        .Where(s => s != "glcore" && s != "glsc2" && s != "disabled")
                        .Select(s => ParseApiWithFileFallback(s, currentFile)).ToArray();

                    if (supportedApis == null)
                    {
                        throw new Exception($"Extension '{extension}' did not specify any supported APIs.");
                    }

                    List<RequireTag> requires = new List<RequireTag>();
                    foreach (XElement? require in extension.Elements("require"))
                    {
                        RequireTag reqTag = ParseRequire(require, ignoreFunctions);
                        if (reqTag.Api == OutputApi.Invalid)
                        {
                            foreach (var api in supportedApis)
                            {
                                reqTag = reqTag with { Api = api };
                                requires.Add(reqTag);
                            }
                        }
                        else
                        {
                            requires.Add(reqTag);
                        }
                    }

                    extensions.Add(new Extension()
                    {
                        Name = extName,
                        RequireTags = requires,
                        DeprecateTags = [],
                        RemoveTags = [],

                        Comment = comment,

                        Vendor = vendor,
                        SupportedApis = supportedApis,
                    });
                }
            }


            return extensions;
        }

        internal static RequireTag ParseRequire(XElement requires, List<string> ignoreFunctions)
        {
            OutputApi api = ParseApi(requires.Attribute("api")?.Value);
            GLProfile profile = ParseProfile(requires.Attribute("profile")?.Value);
            string? comment = requires.Attribute("comment")?.Value;

            // FIXME:
            if (comment == "Constants")
                return new RequireTag() { Commands = [], Enums = [], Constants = [] };

            List<CommandRef> reqCommands = new List<CommandRef>();
            List<EnumRef> reqEnums = new List<EnumRef>();

            foreach (XElement? entry in requires.Elements())
            {
                if (entry.Name.LocalName == "comment")
                {
                    continue;
                }

                // A few entries here have a comment attribute, but we don't bother with it
                string? name = entry.Attribute("name")?.Value;
                if (name == null) throw new Exception($"The entry '{entry}' didn't contain a name attribute.");
                // GLX_EXTENSION_NAME is a string that we don't want to include.
                if (name == "GLX_EXTENSION_NAME")
                    continue;

                switch (entry.Name.LocalName)
                {
                    case "command":
                        if (ignoreFunctions.Contains(name))
                            continue;
                        reqCommands.Add(new CommandRef(name));
                        break;
                    case "enum":
                        reqEnums.Add(new EnumRef(name));
                        break;
                    case "type":
                        continue;
                    default:
                        throw new Exception();
                }
            }

            return new RequireTag()
            {
                Commands = reqCommands,
                Enums = reqEnums,
                Constants = [],

                Comment = comment,

                Api = api,
                GLProfile = profile,
            };
        }

        internal static RemoveTag ParseRemove(XElement requires, List<string> ignoreFunctions)
        {
            GLProfile profile = ParseProfile(requires.Attribute("profile")?.Value);
            string? comment = requires.Attribute("comment")?.Value;

            List<CommandRef> removeCommands = new List<CommandRef>();
            List<EnumRef> removeEnums = new List<EnumRef>();

            foreach (XElement? entry in requires.Elements())
            {
                // A few entries here have a comment attribute, but we don't bother with it
                string? name = entry.Attribute("name")?.Value;
                if (name == null) throw new Exception($"The entry '{entry}' didn't contain a name attribute.");

                switch (entry.Name.LocalName)
                {
                    case "command":
                        if (ignoreFunctions.Contains(name))
                            continue;
                        removeCommands.Add(new CommandRef(name));
                        break;
                    case "enum":
                        removeEnums.Add(new EnumRef(name));
                        break;
                    default:
                        throw new Exception();
                }
            }

            //return new RemoveTag(profile, comment, removeCommands, removeEnums);
            return new RemoveTag()
            {
                Commands = removeCommands,
                Enums = removeEnums,
                Constants = [],

                Comment = comment,

                Profile = profile,
            };
        }

        internal static OutputApi ParseApiWithFileFallback(string? api, ApiFile file)
        {
            OutputApi outputApi = ParseApi(api);
            if (outputApi == OutputApi.Invalid)
                outputApi = file switch
                {
                    ApiFile.CL => OutputApi.CL,

                    _ => throw new Exception(),
                };
            return outputApi;
        }

        internal static OutputApi ParseApi(string? api) => api switch
        {
            null or "" => OutputApi.Invalid,

            "cl" => OutputApi.CL,

            _ => OutputApi.Invalid,
        };

        internal static GLProfile ParseProfile(string? profile) => profile switch
        {
            null or "" => GLProfile.None,

            "core" => GLProfile.Core,
            "compatibility" => GLProfile.Compatibility,
            "common" => GLProfile.Common,

            _ => throw new Exception(),
        };
    }
}
