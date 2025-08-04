using GeneratorBase;
using GeneratorBase.Utility;
using GeneratorBase.Utility.Extensions;
using ALGenerator.Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Buffers.Binary;
using System.Net.Http.Headers;

namespace ALGenerator.Parsing
{
    internal class SpecificationParser
    {
        internal static Specification2 Parse(Stream input, NameMangler nameMangler, ALFile currentFile, List<string> ignoreFunctions)
        {
            XDocument? xdocument = XDocument.Load(input);

            if (xdocument.Root == null)
                throw new NullReferenceException("The parsed xml didn't contain a Root node.");

            List<NativeFunction> functions = ParseCommands(xdocument.Root, nameMangler, currentFile, ignoreFunctions);
            List<EnumEntry>? enums = ParseEnums(xdocument.Root, nameMangler, currentFile);

            List<Feature>? features = ParseFeatures(xdocument.Root, currentFile);
            List<Extension>? extensions = ParseExtensions(xdocument.Root, currentFile, nameMangler);

            List<API> APIs = MakeAPIs(features, extensions);

            return new Specification2(functions, enums, APIs);
        }

        private static List<API> MakeAPIs(List<Feature> features, List<Extension> extensions)
        {
            Dictionary<ALAPI, List<Feature>> FeaturesPerAPI = new Dictionary<ALAPI, List<Feature>>();
            foreach (var feature in features)
            {
                FeaturesPerAPI.AddToNestedList(feature.Api, feature);
            }

            Dictionary<ALAPI, List<Extension>> ExtensionsPerAPI = new Dictionary<ALAPI, List<Extension>>();
            foreach (var extension in extensions)
            {
                foreach (var supportedAPI in extension.SupportedApis)
                {
                    ExtensionsPerAPI.AddToNestedList(supportedAPI, extension);
                }
            }

            List<API> APIs = new List<API>();
            foreach (var api in FeaturesPerAPI.Keys.Union(ExtensionsPerAPI.Keys))
            {
                // We use GetValueOrDefault in case we have zero features or extensions,
                // this happens in egl_angle_ext.xml which doesn't define any features.
                // - Noggin_bops 2024-11-11
                List<FunctionReference> functions = MakeFunctionReferences(FeaturesPerAPI.GetValueOrDefault(api, new List<Feature>()), ExtensionsPerAPI.GetValueOrDefault(api, new List<Extension>()), api);
                // FIXME: Here we miss the enums that where not defined in this file. for example wgl::ObjectTypeDX
                List<EnumReference> enums = MakeEnumReferences(FeaturesPerAPI.GetValueOrDefault(api, new List<Feature>()), ExtensionsPerAPI.GetValueOrDefault(api, new List<Extension>()), api);

                InputAPI inAPI = api switch
                {
                    ALAPI.AL => InputAPI.AL,
                    ALAPI.ALC => InputAPI.ALC,

                    _ => throw new Exception(),
                };

                APIs.Add(new API(inAPI, functions, enums));
            }

            return APIs;

            static List<FunctionReference> MakeFunctionReferences(List<Feature> features, List<Extension> extensions, ALAPI api)
            {
                //List<FunctionReference> functions = new List<FunctionReference>();
                Dictionary<string, FunctionReference> entryPointToReference = new Dictionary<string, FunctionReference>();

                // FIXME: If we want to generate the compatibility thing we want to remove all of the 
                foreach (var feature in features)
                {
                    foreach (var requires in feature.Requires)
                    {
                        Debug.Assert(requires.Api != feature.Api);

                        foreach (var entryPoint in requires.Commands)
                        {
                            if (entryPointToReference.TryGetValue(entryPoint, out FunctionReference? value) == false)
                            {
                                value = new FunctionReference(entryPoint, feature.Version, null, new List<ExtensionReference>());
                                entryPointToReference.Add(entryPoint, value);
                            }

                            // FIXME: This isn't strictly needed... they are already going to be in order.
                            if (feature.Version < value.AddedIn)
                            {
                                value = value with { AddedIn = feature.Version };
                            }

                            entryPointToReference[entryPoint] = value;
                        }
                    }

                    foreach (var removes in feature.Removes)
                    {
                        foreach (var entryPoint in removes.Commands)
                        {
                            if (entryPointToReference.TryGetValue(entryPoint, out FunctionReference? value) == false)
                            {
                                value = new FunctionReference(entryPoint, feature.Version, null, new List<ExtensionReference>());
                                entryPointToReference.Add(entryPoint, value);
                            }

                            // If we should, update the removed in.
                            if (value.RemovedIn == null || feature.Version < value.RemovedIn)
                            {
                                value = value with { RemovedIn = feature.Version };
                            }

                            entryPointToReference[entryPoint] = value;
                        }
                    }
                }

                foreach (var extension in extensions)
                {
                    Debug.Assert(extension.SupportedApis.Contains(api));

                    foreach (var requires in extension.Requires)
                    {
                        Debug.Assert(extension.SupportedApis.Contains(requires.Api) || requires.Api == ALAPI.None);

                        foreach (var entryPoint in requires.Commands)
                        {
                            if (entryPointToReference.TryGetValue(entryPoint, out FunctionReference? value) == false)
                            {
                                value = new FunctionReference(entryPoint, null, null, new List<ExtensionReference>());
                                entryPointToReference.Add(entryPoint, value);
                            }

                            value.PartOfExtensions.Add(new ExtensionReference(extension.Name, extension.Vendor));

                            entryPointToReference[entryPoint] = value;
                        }
                    }
                }

                return entryPointToReference.Values.ToList();
            }

            static List<EnumReference> MakeEnumReferences(List<Feature> features, List<Extension> extensions, ALAPI api)
            {
                Dictionary<string, EnumReference> enumNameToReference = new Dictionary<string, EnumReference>();

                foreach (var feature in features)
                {
                    foreach (var requires in feature.Requires)
                    {
                        Debug.Assert(requires.Api != feature.Api);

                        foreach (var enumName in requires.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName, feature.Version, null, new List<ExtensionReference>(), false);
                                enumNameToReference.Add(enumName, value);
                            }

                            // If this enum value was removed and later readded.
                            if (value.RemovedIn != null && feature.Version > value.RemovedIn)
                            {
                                value = value with { AddedIn = feature.Version, RemovedIn = null };
                            }

                            // FIXME: This isn't strictly needed... they are already going to be in order.
                            if (feature.Version < value.AddedIn)
                            {
                                value = value with { AddedIn = feature.Version };
                            }

                            enumNameToReference[enumName] = value;
                        }
                    }

                    foreach (var removes in feature.Removes)
                    {
                        foreach (var enumName in removes.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName, feature.Version, null, new List<ExtensionReference>(), false);
                                enumNameToReference.Add(enumName, value);
                            }

                            // If we should, update the removed in.
                            if (value.RemovedIn == null || feature.Version < value.RemovedIn)
                            {
                                value = value with { RemovedIn = feature.Version };
                            }

                            enumNameToReference[enumName] = value;
                        }
                    }
                }

                foreach (var extension in extensions)
                {
                    Debug.Assert(extension.SupportedApis.Contains(api));

                    foreach (var requires in extension.Requires)
                    {
                        Debug.Assert(extension.SupportedApis.Contains(requires.Api) || requires.Api == ALAPI.None);

                        foreach (var enumName in requires.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName, null, null, new List<ExtensionReference>(), false);
                                enumNameToReference.Add(enumName, value);
                            }

                            value.PartOfExtensions.Add(new ExtensionReference(extension.Name, extension.Vendor));

                            enumNameToReference[enumName] = value;
                        }
                    }
                }

                return enumNameToReference.Values.ToList();
            }
        }

        // FIXME: Maybe change name?
        private static List<NativeFunction> ParseCommands(XElement input, NameMangler nameMangler, ALFile currentFile, List<string> ignoreFunctions)
        {
            Logger.Info("Begining parsing of commands.");

            List<NativeFunction> functions = new List<NativeFunction>();
            foreach (XElement? commands in input.Elements("commands"))
            {
                foreach (XElement command in commands .Elements("command"))
                {
                    NativeFunction function = ParseCommand(command, nameMangler, currentFile);

                    // Don't add this command to the list if we should ignore it.
                    if (ignoreFunctions.Contains(function.EntryPoint))
                    {
                        continue;
                    }

                    functions.Add(function);
                }
            }

            return functions;
        }

        private static NativeFunction ParseCommand(XElement c, NameMangler nameMangler, ALFile currentFile)
        {
            XElement? proto = c.Element("proto");
            if (proto == null) throw new Exception("Missing proto tag!");

            string? entryPoint = proto.Element("name")?.Value;
            if (entryPoint == null) throw new Exception("Missing name tag!");

            HashSet<GroupRef> referencedEnumGroups = new HashSet<GroupRef>();

            List<Parameter>? paramList = new List<Parameter>();
            foreach (XElement? element in c.Elements("param"))
            {
                string paramName = element.Element("name")?.Value ?? throw new Exception("Missing parameter name!");
                string mangledName = NameMangler.MangleParameterName(paramName);

                BaseCSType type = ParsePType(element, currentFile, nameMangler, out GroupRef? groupRef);
                if (groupRef != null) referencedEnumGroups.Add(groupRef);

                string[] kind = element.Attribute("kind")?.Value?.Split(',') ?? Array.Empty<string>();

                string? length = element.Attribute("len")?.Value;
                Expression? paramLength = length == null ? null : ParseExpression(length);

                // FIXME: Parse kinds in some way?
                paramList.Add(new Parameter(type, kind, paramName, mangledName, paramLength));
            }

            BaseCSType returnType = ParsePType(proto, currentFile, nameMangler, out GroupRef? returnGroup);
            if (returnGroup != null) referencedEnumGroups.Add(returnGroup);
            
            string functionName = nameMangler.MangleFunctionName(entryPoint);

            return new NativeFunction(entryPoint, functionName, paramList, returnType, referencedEnumGroups.ToArray());
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

        private static BaseCSType ParsePType(XElement t, ALFile currentFile, NameMangler nameMangler, out GroupRef? groupRef)
        {
            string? group = t.Attribute("group")?.Value;
            if (group != null)
                groupRef = GroupRefFromString(group, currentFile, nameMangler);
            else
                groupRef = null;

            string? className = t.Attribute("class")?.Value;
            HandleType? handle = className switch
            {
                null => null,
                // FIXME!
                _ => throw new Exception(className + " is not a supported handle type yet!"),
            };

            string? str = t.GetXmlText(element => element.Name != "name" ? element.Value : string.Empty).Trim();

            BaseCSType type = ParseType(str, handle, groupRef, nameMangler);
            return type;
        }

        private static BaseCSType ParseType(string type, HandleType? handle, GroupRef? group, NameMangler nameMangler)
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

                BaseCSType? baseType = ParseType(withoutAsterisk, handle, group, nameMangler);

                // Some structs are created as CSOpaqueStructs, this means that the only 
                // valid way to use these is through a pointer. We intercept them here
                // and create the proper CSStructPrimitive types from them.
                // - Noggin_bops 2024-03-07
                if (baseType is CSOpaqueStruct opaque)
                {
                    switch (opaque.TypeName)
                    {
                        // FIXME: Decide if we want `DisplayPtr`, `Display` or something like `XDisplay`?
                        // - Noggin_bops 2024-03-07
                        case "ALCDevice":
                            return new CSStructPrimitive("ALCDevice", opaque.Constant, CSPrimitive.IntPtr(true));
                        case "ALCContext":
                            return new CSStructPrimitive("ALCContext", opaque.Constant, CSPrimitive.IntPtr(true));
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

                // To make OpenTK 5 more like OpenTK 4 we want handles to be int instead of uint
                if (handle != null)
                {
                    return CSPrimitive.Int(@const);
                }

                // For now we only expect int and uint to be able to be turned into groupNameToEnumGroup.
                // - 2022-08-09
                // FIXME: We might want to make sure that the underlying type for the enumName groupName is the same as the parameter groupName.
                //   Right now we blindly substituting the type for the enumName.
                if (group != null &&
                        (type == "GLuint" ||
                        type == "GLint" ||
                        type == "INT" ||
                        type == "UINT" ||
                        type == "INT32" ||
                        type == "int" ||
                        type == "int32_t" ||
                        type == "EGLint" ||
                        type == "EGLuint"))
                {
                    Logger.Info($"Making {type} into group {group.TranslatedName}");
                    CSPrimitive baseType = type switch
                    {
                        "GLint" => CSPrimitive.Int(@const),
                        "GLuint" => CSPrimitive.Uint(@const),
                        "INT" => CSPrimitive.Int(@const),
                        "UINT" => CSPrimitive.Uint(@const),
                        "INT32" => CSPrimitive.Int(@const),
                        "int" => CSPrimitive.Int(@const),
                        "int32_t" => CSPrimitive.Int(@const),
                        "EGLint" => CSPrimitive.Int(@const),
                        "EGLuint" => CSPrimitive.Uint(@const),
                        _ => throw new Exception("This should not happen!"),
                    };

                    return new CSEnum(group.TranslatedName, baseType, @const);
                }
                
                BaseCSType csType;
                {
                    csType = type switch
                    {
                        "void" => new CSVoid(@const),
                        "uint" => CSPrimitive.Uint(@const),
                        "float" => CSPrimitive.Float(@const),
                        "double" => CSPrimitive.Double(@const),

                        "ALCdevice" => new CSOpaqueStruct("ALCDevice", @const),
                        "ALCcontext" => new CSOpaqueStruct("ALCContext", @const),
                        "ALCboolean" => new CSBool8(@const),
                        "ALCchar" => new CSChar8(@const),
                        "ALCbyte" => CSPrimitive.Sbyte(@const),
                        "ALCubyte" => CSPrimitive.Byte(@const),
                        "ALCshort" => CSPrimitive.Short(@const),
                        "ALCushort" => CSPrimitive.Ushort(@const),
                        "ALCint" => CSPrimitive.Int(@const),
                        "ALCuint" => CSPrimitive.Uint(@const),
                        "ALCsizei" => CSPrimitive.Int(@const),
                        "ALCenum" => new CSEnum(group?.TranslatedName ?? "All", CSPrimitive.Int(true), @const),
                        "ALCfloat" => CSPrimitive.Float(@const),
                        "ALCdouble" => CSPrimitive.Double(@const),
                        "ALCvoid" => new CSVoid(@const),
                        "ALCint64SOFT" => CSPrimitive.Long(@const),
                        "ALCuint64SOFT" => CSPrimitive.Ulong(@const),

                        "ALCEVENTPROCTYPESOFT" => new CSFunctionPointer("ALCEventProcTypeSOFT", true, new CSVoid(true), [
                            new CSEnum("All", CSPrimitive.Int(true), true),
                            new CSEnum("All", CSPrimitive.Int(true), true),
                            new CSStructPrimitive("ALCDevice", false, CSPrimitive.IntPtr(true)),
                            CSPrimitive.Nuint(true),
                            new CSPointer(new CSChar8(true), true),
                            new CSPointer(new CSVoid(true), false)
                            ]),

                        "ALboolean" => new CSBool8(@const),
                        "ALchar" => new CSChar8(@const),
                        "ALbyte" => CSPrimitive.Sbyte(@const),
                        "ALubyte" => CSPrimitive.Byte(@const),
                        "ALshort" => CSPrimitive.Short(@const),
                        "ALushort" => CSPrimitive.Ushort(@const),
                        "ALint" => CSPrimitive.Int(@const),
                        "ALuint" => CSPrimitive.Uint(@const),
                        "ALsizei" => CSPrimitive.Int(@const),
                        "ALenum" => new CSEnum(group?.TranslatedName ?? "All", CSPrimitive.Int(true), @const),
                        "ALfloat" => CSPrimitive.Float(@const),
                        "ALdouble" => CSPrimitive.Double(@const),
                        "ALvoid" => new CSVoid(@const),
                        "ALint64SOFT" => CSPrimitive.Long(@const),
                        "ALuint64SOFT" => CSPrimitive.Ulong(@const),

                        "ALDEBUGPROCEXT" => new CSFunctionPointer("ALDebugProcEXT", true, CSPrimitive.Int(true), [
                            new CSEnum("All", CSPrimitive.Int(true), true),
                            new CSEnum("All", CSPrimitive.Int(true), true),
                            CSPrimitive.Uint(true),
                            new CSEnum("All", CSPrimitive.Int(true), true),
                            CSPrimitive.Nuint(true),
                            new CSPointer(new CSChar8(true), true),
                            new CSPointer(new CSVoid(true), false)
                            ]),

                        "LPALFOLDBACKCALLBACK" => new CSFunctionPointer("ALFoldbackCallback", true, new CSVoid(true), [
                            new CSEnum("All", CSPrimitive.Int(true), true),
                            CSPrimitive.Nuint(true)
                            ]),

                        "alSourceNotificationProc" => new CSFunctionPointer("ALSourceNotificationProc", true, new CSVoid(true), [
                            CSPrimitive.Uint(true),
                            CSPrimitive.Uint(true),
                            new CSPointer(new CSVoid(true), false)
                            ]),

                        "ALBUFFERCALLBACKTYPESOFT" => new CSFunctionPointer("ALBufferCallbackTypeSOFT", true, CSPrimitive.Nuint(true), [
                            new CSPointer(new CSVoid(true), false),
                            new CSPointer(new CSVoid(true), false),
                            CSPrimitive.Nuint(true),
                            ]),

                        "ALEVENTPROCSOFT" => new CSFunctionPointer("ALEventProcSOFT", true, new CSVoid(true), [
                            new CSEnum("All", CSPrimitive.Int(true), true),
                            CSPrimitive.Uint(true),
                            CSPrimitive.Uint(true),
                            CSPrimitive.Nuint(true),
                            new CSPointer(new CSChar8(true), true),
                            new CSPointer(new CSVoid(true), false)
                            ]),

                        "ALBUFFERDATACALLBACKLOKI" => new CSFunctionPointer("ALBufferDataCallbackLOKI", true, CSPrimitive.Int(true), [
                            CSPrimitive.Uint(true),
                            CSPrimitive.Uint(true),
                            new CSPointer(new CSVoid(true), false),
                            new CSEnum("All", CSPrimitive.Int(true), true),
                            CSPrimitive.Uint(true)
                            ]),

                        _ => throw new Exception($"Type conversion has not been created for type {type}"),
                    };
                }

                return csType;
            }
        }


        internal static List<EnumEntry> ParseEnums(XElement input, NameMangler nameMangler, ALFile currentFile)
        {
            Logger.Info("Begining parsing of enums.");
            List<EnumEntry> enumsEntries = new List<EnumEntry>();
            foreach (XElement? enums in input.Elements("enums"))
            {
                GroupRef[] parentGroups = ParseGroups(enums.Attribute("group")?.Value, currentFile, nameMangler);

                string? vendor = enums.Attribute("vendor")?.Value;

                EnumType type = ParseEnumsType(enums.Attribute("type")?.Value);

                string? enumsComment = enums.Attribute("comment")?.Value;

                foreach (XElement? @enum in enums.Elements("enum"))
                {
                    string? name = @enum.Attribute("name")?.Value;
                    string? valueStr = @enum.Attribute("value")?.Value;
                    if (valueStr == null || name == null)
                    {
                        throw new Exception($"Enum {name} did not pass correctly");
                    }

                    TypeSuffix suffix = ParseEnumTypeSuffix(@enum.Attribute("type")?.Value);

                    ulong value = ConvertToUInt64(valueStr, suffix);

                    string? alias = @enum.Attribute("alias")?.Value;

                    GroupRef[] groups = ParseGroups(@enum.Attribute("group")?.Value, currentFile, nameMangler);
                    // Mark this with all of the groups from the parent tag.
                    groups = ArrayUtil.MergeDeduplicate(groups, parentGroups);

                    string? enumComment = @enum.Attribute("comment")?.Value;

                    ALAPI api = ParseApi(@enum.Attribute("api")?.Value);
                    OutputApiFlags enumApi;
                    if (api == ALAPI.None)
                    {
                        enumApi = currentFile switch
                        {
                            ALFile.AL => OutputApiFlags.AL,
                            ALFile.ALC => OutputApiFlags.ALC,

                            _ => throw new Exception(),
                        };
                    }
                    else 
                    {
                        enumApi = api switch
                        {
                            ALAPI.AL => OutputApiFlags.AL,
                            ALAPI.ALC => OutputApiFlags.ALC,

                            _ => throw new Exception(),
                        };
                    }

                    foreach (var group in groups)
                    {
                        switch (group.Namespace)
                        {
                            case ALFile.AL:
                                enumApi |= OutputApiFlags.AL;
                                break;
                            case ALFile.ALC:
                                enumApi |= OutputApiFlags.ALC;
                                break;
                        }
                    }

                    enumsEntries.Add(new EnumEntry(name, nameMangler.MangleEnumName(name), value, enumApi, type, vendor, alias, groups, suffix));
                }
            }

            return enumsEntries;

            static EnumType ParseEnumsType(string? value) => value switch
            {
                null or "" => EnumType.None,
                "bitmask" => EnumType.Bitmask,
                _ => EnumType.Invalid,
            };

            static TypeSuffix ParseEnumTypeSuffix(string? suffix) => suffix switch
            {
                null or "" => TypeSuffix.None,
                "u" => TypeSuffix.U,
                "ull" => TypeSuffix.Ull,
                _ => TypeSuffix.Invalid,
            };

            static ulong ConvertToUInt64(string val, TypeSuffix type)
            {
                if (val.StartsWith('\''))
                {
                    return (ulong)(val[1] << 3 | val[2] << 2 | val[3] << 1 | val[4]);
                }

                return type switch
                {
                    TypeSuffix.None => (uint)(int)new Int32Converter().ConvertFromString(val)!,
                    TypeSuffix.Ull => (ulong)new UInt64Converter().ConvertFromString(val)!,
                    TypeSuffix.U => (uint)new UInt32Converter().ConvertFromString(val)!,
                    TypeSuffix.Invalid or _ => throw new Exception($"Invalid suffix '{type}'!"),
                };
            }
        }

        internal static GroupRef[] ParseGroups(string? groups, ALFile currentFile, NameMangler nameMangler)
        {
            if (groups == null) return Array.Empty<GroupRef>();

            string[] rawGroups = groups.Split(',', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
            GroupRef[] groupRefs = new GroupRef[rawGroups.Length];
            for (int i = 0; i < rawGroups.Length; i++)
            {
                groupRefs[i] = GroupRefFromString(rawGroups[i], currentFile, nameMangler);
            }

            return groupRefs;
        }

        internal static GroupRef GroupRefFromString(string group, ALFile currentFile, NameMangler nameMangler)
        {
            string name;
            ALFile file;
            if (group.StartsWith("al::"))
            {
                name = NameMangler.RemoveStart(group, "al::");
                file = ALFile.AL;
            }
            else if (group.StartsWith("alc::"))
            {
                name = NameMangler.RemoveStart(group, "alc::");
                file = ALFile.ALC;
            }
            else
            {
                name = group;
                file = currentFile;
            }

            string translatedName = nameMangler.TranslateEnumGroupName(name);

            return new GroupRef(name, translatedName, file);
        }


        internal static List<Feature> ParseFeatures(XElement input, ALFile currentFile)
        {
            Logger.Info("Begining parsing of features.");

            List<Feature> features = new List<Feature>();

            XElement xelement = input.Element("features")!;
            foreach (XElement? feature in xelement.Elements("feature"))
            {
                string? name = feature.Attribute("name")?.Value;
                string? number = feature.Attribute("number")?.Value;

                if (name == null || number == null)
                {
                    throw new Exception($"Feature '{feature}' is missing an attribute.");
                }

                Version? version = Version.Parse(number);
                ALAPI api = FileToAPI(currentFile);

                List<RequireEntry> requireEntries = new List<RequireEntry>();
                foreach (XElement? require in feature.Elements("require"))
                {
                    RequireEntry reqEntry = ParseRequire(require);
                    requireEntries.Add(reqEntry);
                }

                List<RemoveEntry> removeEntries = new List<RemoveEntry>();
                foreach (XElement? remove in feature.Elements("remove"))
                {
                    RemoveEntry removeEntry = ParseRemove(remove);
                    removeEntries.Add(removeEntry);
                }

                features.Add(new Feature(api, version, name, requireEntries, removeEntries));
            }

            return features;
        }

        internal static List<Extension> ParseExtensions(XElement input, ALFile currentFile, NameMangler nameMangler)
        {
            List<Extension> extensions = new List<Extension>();
            XElement? xelement = input.Element("extensions")!;

            foreach (XElement? extension in xelement.Elements("extension"))
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

                List<RequireEntry> requires = new List<RequireEntry>();
                foreach (XElement? require in extension.Elements("require"))
                {
                    requires.Add(ParseRequire(require));
                }

                ALAPI supportedApi = FileToAPI(currentFile);

                extensions.Add(new Extension(extName, vendor, [supportedApi], comment, requires));
            }

            return extensions;
        }

        internal static RequireEntry ParseRequire(XElement requires)
        {
            ALAPI api = ParseApi(requires.Attribute("api")?.Value);
            string? comment = requires.Attribute("comment")?.Value;

            List<string> reqCommands = new List<string>();
            List<string> reqEnums = new List<string>();

            foreach (XElement? entry in requires.Elements())
            {
                // FIXME: We want to generate direct context bindings.
                // Noggin_bops 2025-08-04
                if (entry.Name == "direct_context_commands")
                    continue;

                // A few entries here have a comment attribute, but we don't bother with it
                string? name = entry.Attribute("name")?.Value;
                if (name == null) throw new Exception($"The entry '{entry}' didn't contain a name attribute.");

                switch (entry.Name.LocalName)
                {
                    case "command":
                        reqCommands.Add(name);
                        break;
                    case "enum":
                        reqEnums.Add(name);
                        break;
                    default:
                        continue;
                }
            }

            return new RequireEntry(api, comment, reqCommands, reqEnums);
        }

        internal static RemoveEntry ParseRemove(XElement requires)
        {
            string? comment = requires.Attribute("comment")?.Value;

            List<string> removeCommands = new List<string>();
            List<string> removeEnums = new List<string>();

            foreach (XElement? entry in requires.Elements())
            {
                // A few entries here have a comment attribute, but we don't bother with it
                string? name = entry.Attribute("name")?.Value;
                if (name == null) throw new Exception($"The entry '{entry}' didn't contain a name attribute.");

                switch (entry.Name.LocalName)
                {
                    case "command":
                        removeCommands.Add(name);
                        break;
                    case "enum":
                        removeEnums.Add(name);
                        break;
                    default:
                        continue;
                }
            }

            return new RemoveEntry(comment, removeCommands, removeEnums);
        }

        internal static ALAPI FileToAPI(ALFile file)
        {
            switch (file)
            {
                case ALFile.AL:
                    return ALAPI.AL;
                case ALFile.ALC:
                    return ALAPI.ALC;
                default:
                    throw new Exception();
            }
        }

        internal static ALAPI ParseApi(string? api) => api switch
        {
            null or "" or "disabled" => ALAPI.None,

            "al" => ALAPI.AL,
            "alc" => ALAPI.ALC,

            _ => ALAPI.Invalid,
        };
    }
}
