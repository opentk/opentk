using ALGenerator.Process;
using GeneratorBase;
using GeneratorBase.Utility;
using GeneratorBase.Utility.Extensions;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Threading;
using System.Xml.Linq;

namespace ALGenerator.Parsing
{
    internal class SpecificationParser
    {
        internal static Specification Parse(Stream input, NameMangler nameMangler, APIFile currentFile, List<string> ignoreFunctions)
        {
            XDocument? xdocument = XDocument.Load(input);

            if (xdocument.Root == null)
                throw new NullReferenceException("The parsed xml didn't contain a Root node.");

            List<Function> functions = ParseCommands(xdocument.Root, nameMangler, currentFile, ignoreFunctions);
            List<EnumEntry>? enums = ParseEnums(xdocument.Root, nameMangler, currentFile);

            List<Feature>? features = ParseFeatures(xdocument.Root, currentFile);
            List<Extension>? extensions = ParseExtensions(xdocument.Root, currentFile, nameMangler);

            if (currentFile == APIFile.AL)
            {
                // Adds AL_EXT_direct_context functions to the functions list
                // and modifies the AL_EXT_direct_context extensions require tag
                // list to include these functions.
                // - Noggin_bops 2025-08-08
                CreateDirectContextCommands(functions, extensions);
            }

            List<API> APIs = MakeAPIs(features, extensions);

            return new Specification(functions, enums, APIs);
        }

        private static List<API> MakeAPIs(List<Feature> features, List<Extension> extensions)
        {
            Dictionary<ALAPI, List<Feature>> FeaturesPerAPI = new Dictionary<ALAPI, List<Feature>>();
            foreach (var feature in features)
            {
                FeaturesPerAPI.AddToNestedList(feature.ALApi, feature);
            }

            Dictionary<ALAPI, List<Extension>> ExtensionsPerAPI = new Dictionary<ALAPI, List<Extension>>();
            foreach (var extension in extensions)
            {
                foreach (var supportedAPI in extension.SupportedALApis)
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
                    foreach (var requires in feature.RequireTags)
                    {
                        Debug.Assert(requires.ALApi != feature.ALApi);

                        foreach (var entryPoint in requires.Commands)
                        {
                            if (entryPointToReference.TryGetValue(entryPoint.Name, out FunctionReference? value) == false)
                            {
                                value = new FunctionReference(entryPoint.Name, new VersionInfo(feature.Version, []));
                                entryPointToReference.Add(entryPoint.Name, value);
                            }

                            // FIXME: This isn't strictly needed... they are already going to be in order.
                            if (feature.Version < value.VersionInfo.Version)
                            {
                                value = value with { VersionInfo = value.VersionInfo with { Version = feature.Version } };
                            }

                            entryPointToReference[entryPoint.Name] = value;
                        }
                    }

                    Debug.Assert(feature.DeprecateTags.Count == 0);

                    foreach (var removes in feature.RemoveTags)
                    {
                        foreach (var entryPoint in removes.Commands)
                        {
                            if (entryPointToReference.TryGetValue(entryPoint.Name, out FunctionReference? value) == false)
                            {
                                value = new FunctionReference(entryPoint.Name, new VersionInfo(feature.Version, []));
                                entryPointToReference.Add(entryPoint.Name, value);
                            }

                            value.VersionInfo.Remove(new RemoveReason(feature.Version, null, null));

                            entryPointToReference[entryPoint.Name] = value;
                        }
                    }
                }

                foreach (var extension in extensions)
                {
                    Debug.Assert(extension.SupportedALApis.Contains(api));

                    foreach (var requires in extension.RequireTags)
                    {
                        Debug.Assert(extension.SupportedALApis.Contains(requires.ALApi) || requires.ALApi == ALAPI.None);

                        foreach (var entryPoint in requires.Commands)
                        {
                            if (entryPointToReference.TryGetValue(entryPoint.Name, out FunctionReference? value) == false)
                            {
                                value = new FunctionReference(entryPoint.Name, new VersionInfo(null, []));
                                entryPointToReference.Add(entryPoint.Name, value);
                            }

                            value.VersionInfo.Extensions.Add(new ExtensionInfo(extension.Name, extension.Vendor));

                            entryPointToReference[entryPoint.Name] = value;
                        }
                    }

                    Debug.Assert(extension.DeprecateTags.Count == 0);
                    Debug.Assert(extension.RemoveTags.Count == 0);
                }

                return entryPointToReference.Values.ToList();
            }

            static List<EnumReference> MakeEnumReferences(List<Feature> features, List<Extension> extensions, ALAPI api)
            {
                Dictionary<string, EnumReference> enumNameToReference = new Dictionary<string, EnumReference>();

                foreach (var feature in features)
                {
                    foreach (var requires in feature.RequireTags)
                    {
                        Debug.Assert(requires.ALApi != feature.ALApi);

                        foreach (var enumName in requires.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName.Name, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName.Name, new VersionInfo(feature.Version, []), false);
                                enumNameToReference.Add(enumName.Name, value);
                            }

                            Debug.Assert(value.VersionInfo.RemovedBy.Count <= 1);

                            if (value.VersionInfo.RemovedBy.Count == 1 &&
                                value.VersionInfo.RemovedBy[0].Version != null &&
                                feature.Version > value.VersionInfo.RemovedBy[0].Version)
                            {
                                value = value with { VersionInfo = value.VersionInfo with { Version = feature.Version, RemovedBy = [] } };
                            }

                            // FIXME: This isn't strictly needed... they are already going to be in order.
                            if (feature.Version < value.VersionInfo.Version)
                            {
                                value = value with { VersionInfo = value.VersionInfo with { Version = feature.Version } };
                            }

                            enumNameToReference[enumName.Name] = value;
                        }
                    }

                    Debug.Assert(feature.DeprecateTags.Count == 0);

                    foreach (var removes in feature.RemoveTags)
                    {
                        foreach (var enumName in removes.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName.Name, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName.Name, new VersionInfo(feature.Version, []), false);
                                enumNameToReference.Add(enumName.Name, value);
                            }

                            value.VersionInfo.Remove(new RemoveReason(feature.Version, null, null));

                            enumNameToReference[enumName.Name] = value;
                        }
                    }
                }

                foreach (var extension in extensions)
                {
                    Debug.Assert(extension.SupportedALApis.Contains(api));

                    foreach (var requires in extension.RequireTags)
                    {
                        Debug.Assert(extension.SupportedALApis.Contains(requires.ALApi) || requires.ALApi == ALAPI.None);

                        foreach (var enumName in requires.Enums)
                        {
                            if (enumNameToReference.TryGetValue(enumName.Name, out EnumReference? value) == false)
                            {
                                value = new EnumReference(enumName.Name, new VersionInfo(null, []), false);
                                enumNameToReference.Add(enumName.Name, value);
                            }

                            value.VersionInfo.Extensions.Add(new ExtensionInfo(extension.Name, extension.Vendor));

                            enumNameToReference[enumName.Name] = value;
                        }
                    }

                    Debug.Assert(extension.DeprecateTags.Count == 0);
                    Debug.Assert(extension.RemoveTags.Count == 0);
                }

                return enumNameToReference.Values.ToList();
            }
        }

        private static void CreateDirectContextCommands(List<Function> functions, List<Extension> extensions)
        {
            // FIXME: We probably want to generate these functions in the same namespace as their original version.
            // And modify the required string to be something like "[requires: ALC_EXT_EFX & AL_EXT_direct_context]"
            // meaning both ALC_EXT_EFX and AL_EXT_direct_context needs to be supported for this to work.
            // We also need to deal with the fact that AL_EXT_direct_context devices need to load all of their
            // function pointers from alcGetProcAddress2 which you only get access to after creating your first
            // context, similar to how you need to do with OpenGL on windows.
            // - Noggin_bops 2025-08-08

            List<Function> directContextFunctions = new List<Function>();
            List<CommandRef> directContextFunctionNames = new List<CommandRef>();

            CSStructPrimitive contextType = new CSStructPrimitive("ALCContext", false, CSPrimitive.IntPtr(true));

            foreach (var function in functions)
            {
                string entryPoint = $"{NameMangler.RemoveVendorPostfix(function.EntryPoint)}Direct{NameMangler.GetVendorPostfix(function.EntryPoint)}";

                Function directFunction = function with {
                    Parameters = [
                        new Parameter()
                        {
                            Name = "context",
                            OriginalName = "context",
                            Type = contextType.ToCSString(),
                            Length = null,

                            StrongType = contextType,
                            StrongLength = null,

                            Kinds = [],
                        },
                        ..function.Parameters
                        ],
                    // FIXME: Extension stuff!
                    EntryPoint = entryPoint,
                    Name = $"{NameMangler.RemoveVendorPostfix(function.Name)}Direct{NameMangler.GetVendorPostfix(function.Name)}",
                };

                directContextFunctions.Add(directFunction);
                directContextFunctionNames.Add(new CommandRef(entryPoint));
            }
            functions.AddRange(directContextFunctions);

            Extension extension = extensions.Find(e => e.Name == "AL_EXT_direct_context")!;

            extension.RequireTags.Add(new RequireTag()
            {
                Commands = directContextFunctionNames,
                Enums = [],
                Constants = [],

                Comment = "All AL_EXT_direct_context functions",

                ALApi = ALAPI.AL,
            });
        }

        private static List<Function> ParseCommands(XElement input, NameMangler nameMangler, APIFile currentFile, List<string> ignoreFunctions)
        {
            Logger.Info("Begining parsing of commands.");

            List<Function> functions = new List<Function>();
            foreach (XElement? commands in input.Elements("commands"))
            {
                foreach (XElement command in commands.Elements("command"))
                {
                    XElement? proto = command.Element("proto") ?? throw new Exception("Missing proto tag!");

                    string? entryPoint = proto.Element("name")?.Value ?? throw new Exception("Missing name tag!");
                    if (ignoreFunctions.Contains(entryPoint))
                    {
                        continue;
                    }

                    HashSet<GroupRef> referencedEnumGroups = new HashSet<GroupRef>();

                    List<Parameter>? paramList = new List<Parameter>();
                    foreach (XElement? element in command.Elements("param"))
                    {
                        string paramName = element.Element("name")?.Value ?? throw new Exception("Missing parameter name!");
                        string mangledName = NameMangler.MangleParameterName(paramName);

                        BaseCSType type = ParsePType(element, currentFile, nameMangler, out GroupRef? groupRef);
                        if (groupRef != null) referencedEnumGroups.Add(groupRef);

                        string[] kinds = element.Attribute("kind")?.Value?.Split(',') ?? Array.Empty<string>();

                        string? length = element.Attribute("len")?.Value;
                        Expression? paramLength = length == null ? null : ParseExpression(length);

                        paramList.Add(new Parameter
                        {
                            Name = mangledName,
                            OriginalName = paramName,
                            Type = type.ToCSString(),
                            Length = length,

                            StrongType = type,
                            StrongLength = paramLength,

                            Kinds = kinds,
                        });
                    }

                    BaseCSType returnType = ParsePType(proto, currentFile, nameMangler, out GroupRef? returnGroup);
                    if (returnGroup != null) referencedEnumGroups.Add(returnGroup);

                    string functionName = nameMangler.MangleFunctionName(entryPoint);

                    functions.Add(new Function()
                    {
                        Name = functionName,
                        EntryPoint = entryPoint,
                        Parameters = paramList,
                        ReturnType = returnType.ToCSString(),

                        StrongReturnType = returnType,

                        ReferencedEnumGroups = referencedEnumGroups.ToArray(),
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

        private static BaseCSType ParsePType(XElement t, APIFile currentFile, NameMangler nameMangler, out GroupRef? groupRef)
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
                "any" => HandleType.Any,
                "source" => HandleType.Source,
                "buffer" => HandleType.Buffer,
                "effect" => HandleType.Effect,
                "effectSlot" => HandleType.EffectSlot,
                "filter" => HandleType.Filter,
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


        internal static List<EnumEntry> ParseEnums(XElement input, NameMangler nameMangler, APIFile currentFile)
        {
            Logger.Info("Begining parsing of enums.");
            List<EnumEntry> enumsEntries = new List<EnumEntry>();
            foreach (XElement? enums in input.Elements("enums"))
            {
                GroupRef[] parentGroups = ParseGroups(enums.Attribute("group")?.Value, currentFile, nameMangler);

                string? vendor = enums.Attribute("vendor")?.Value;

                bool isFlags = EnumTypeIsBitmask(enums.Attribute("type")?.Value);

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
                            APIFile.AL => OutputApiFlags.AL,
                            APIFile.ALC => OutputApiFlags.ALC,

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
                            case APIFile.AL:
                                enumApi |= OutputApiFlags.AL;
                                break;
                            case APIFile.ALC:
                                enumApi |= OutputApiFlags.ALC;
                                break;
                            default:
                                throw new Exception();
                        }
                    }

                    enumsEntries.Add(new EnumEntry(name, nameMangler.MangleEnumName(name), value, enumApi, isFlags, vendor, alias, groups, suffix));
                }
            }

            return enumsEntries;

            static bool EnumTypeIsBitmask(string? value) => value switch
            {
                null or "" => false,
                "bitmask" => true,
                _ => throw new Exception(),
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

        internal static GroupRef[] ParseGroups(string? groups, APIFile currentFile, NameMangler nameMangler)
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

        internal static GroupRef GroupRefFromString(string group, APIFile currentFile, NameMangler nameMangler)
        {
            string name;
            APIFile file;
            if (group.StartsWith("al::"))
            {
                name = NameMangler.RemoveStart(group, "al::");
                file = APIFile.AL;
            }
            else if (group.StartsWith("alc::"))
            {
                name = NameMangler.RemoveStart(group, "alc::");
                file = APIFile.ALC;
            }
            else
            {
                name = group;
                file = currentFile;
            }

            string translatedName = nameMangler.TranslateEnumGroupName(name);

            return new GroupRef(name, translatedName, file);
        }


        internal static List<Feature> ParseFeatures(XElement input, APIFile currentFile)
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

                List<RequireTag> requireTags = new List<RequireTag>();
                foreach (XElement? require in feature.Elements("require"))
                {
                    RequireTag reqTag = ParseRequire(require);
                    requireTags.Add(reqTag);
                }

                List<RemoveTag> removeTags = new List<RemoveTag>();
                foreach (XElement? remove in feature.Elements("remove"))
                {
                    RemoveTag removeTag = ParseRemove(remove);
                    removeTags.Add(removeTag);
                }

                features.Add(new Feature()
                {
                    Name = name,
                    Version = version,
                    RequireTags = requireTags,
                    DeprecateTags = [],
                    RemoveTags = removeTags,

                    ALApi = api,
                });
            }

            return features;
        }

        internal static List<Extension> ParseExtensions(XElement input, APIFile currentFile, NameMangler nameMangler)
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
                // FIXME: Hack, if the extension name begins with "EAX" it's a Creative extension...
                string? vendor = extNameWithoutGLPrefix.StartsWith("EAX") ? "Creative" : extNameWithoutGLPrefix[..extNameWithoutGLPrefix.IndexOf("_")];
                if (string.IsNullOrEmpty(vendor))
                {
                    throw new Exception($"Extension '{extension}' doesn't have the vendor in it's name!");
                }

                if (char.IsDigit(vendor[0]))
                {
                    vendor = "_" + vendor;
                }

                string? comment = extension.Attribute("comment")?.Value;

                List<RequireTag> requires = new List<RequireTag>();
                foreach (XElement? require in extension.Elements("require"))
                {
                    requires.Add(ParseRequire(require));
                }

                ALAPI supportedApi = FileToAPI(currentFile);

                extensions.Add(new Extension()
                {
                    Name = extName,
                    RequireTags = requires,
                    DeprecateTags = [],
                    RemoveTags = [],

                    Comment = comment,

                    Vendor = vendor,
                    SupportedALApis = [supportedApi],
                });
            }

            return extensions;
        }

        internal static RequireTag ParseRequire(XElement requires)
        {
            ALAPI api = ParseApi(requires.Attribute("api")?.Value);
            string? comment = requires.Attribute("comment")?.Value;

            List<CommandRef> reqCommands = new List<CommandRef>();
            List<EnumRef> reqEnums = new List<EnumRef>();

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
                        reqCommands.Add(new CommandRef(name));
                        break;
                    case "enum":
                        reqEnums.Add(new EnumRef(name));
                        break;
                    default:
                        continue;
                }
            }

            //return new RequireTag(api, comment, reqCommands, reqEnums);
            return new RequireTag()
            {
                Commands = reqCommands,
                Enums = reqEnums,
                Constants = [],

                Comment = comment,

                ALApi = api,
            };
        }

        internal static RemoveTag ParseRemove(XElement requires)
        {
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
                        removeCommands.Add(new CommandRef(name));
                        break;
                    case "enum":
                        removeEnums.Add(new EnumRef(name));
                        break;
                    default:
                        continue;
                }
            }

            return new RemoveTag()
            {
                Commands = removeCommands,
                Enums = removeEnums,
                Constants = [],

                Comment = comment,
            };
        }

        internal static ALAPI FileToAPI(APIFile file)
        {
            switch (file)
            {
                case APIFile.AL:
                    return ALAPI.AL;
                case APIFile.ALC:
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



        internal static List<EFXPreset> ParseEFXPresets(FileStream input, NameMangler nameMangler)
        {
            XDocument? xdocument = XDocument.Load(input);

            if (xdocument.Root == null)
                throw new NullReferenceException("The parsed xml didn't contain a Root node.");

            List<EFXPreset> presets = new List<EFXPreset>();

            XElement xelement = xdocument.Root!;
            foreach (var preset in xelement.Elements("preset"))
            {
                static Vector3 ParseVector3(string str)
                {
                    string[] strs = str.Split(' ');
                    float x = float.Parse(strs[0]);
                    float y = float.Parse(strs[1]);
                    float z = float.Parse(strs[2]);
                    return new Vector3(x, y, z);
                }

                string name = preset.Attribute("name")?.Value ?? throw new Exception();
                float density = float.Parse(preset.Attribute("density")?.Value ?? throw new Exception());
                float diffusion = float.Parse(preset.Attribute("diffusion")?.Value ?? throw new Exception());
                float gain = float.Parse(preset.Attribute("gain")?.Value ?? throw new Exception());
                float gainHF = float.Parse(preset.Attribute("gainHF")?.Value ?? throw new Exception());
                float gainLF = float.Parse(preset.Attribute("gainLF")?.Value ?? throw new Exception());
                float decayTime = float.Parse(preset.Attribute("decayTime")?.Value ?? throw new Exception());
                float decayHFRatio = float.Parse(preset.Attribute("decayHFRatio")?.Value ?? throw new Exception());
                float decayLFRatio = float.Parse(preset.Attribute("decayLFRatio")?.Value ?? throw new Exception());
                float reflectionsGain = float.Parse(preset.Attribute("reflectionsGain")?.Value ?? throw new Exception());
                float reflectionsDelay = float.Parse(preset.Attribute("reflectionsDelay")?.Value ?? throw new Exception());
                Vector3 reflectionsPan = ParseVector3(preset.Attribute("reflectionsPan")?.Value ?? throw new Exception());
                float lateReverbGain = float.Parse(preset.Attribute("lateReverbGain")?.Value ?? throw new Exception());
                float lateReverbDelay = float.Parse(preset.Attribute("lateReverbDelay")?.Value ?? throw new Exception());
                Vector3 lateReverbPan = ParseVector3(preset.Attribute("lateReverbPan")?.Value ?? throw new Exception());
                float echoTime = float.Parse(preset.Attribute("echoTime")?.Value ?? throw new Exception());
                float echoDepth = float.Parse(preset.Attribute("echoDepth")?.Value ?? throw new Exception());
                float modulationTime = float.Parse(preset.Attribute("modulationTime")?.Value ?? throw new Exception());
                float modulationDepth = float.Parse(preset.Attribute("modulationDepth")?.Value ?? throw new Exception());
                float airAbsorptionGainHF = float.Parse(preset.Attribute("airAbsorptionGainHF")?.Value ?? throw new Exception());
                float hfReference = float.Parse(preset.Attribute("hfReference")?.Value ?? throw new Exception());
                float lfReference = float.Parse(preset.Attribute("lfReference")?.Value ?? throw new Exception());
                float roomRolloffFactor = float.Parse(preset.Attribute("roomRolloffFactor")?.Value ?? throw new Exception());
                // FIXME:
                bool decayHFLimit = bool.Parse(preset.Attribute("decayHFLimit")?.Value ?? throw new Exception());
                
                presets.Add(new EFXPreset(
                    nameMangler.MangleEnumName(name),
                    density,
                    diffusion,
                    gain,
                    gainHF,
                    gainLF,
                    decayTime,
                    decayHFRatio,
                    decayLFRatio,
                    reflectionsGain,
                    reflectionsDelay,
                    reflectionsPan,
                    lateReverbGain,
                    lateReverbDelay,
                    lateReverbPan,
                    echoTime,
                    echoDepth,
                    modulationTime,
                    modulationDepth,
                    airAbsorptionGainHF,
                    hfReference,
                    lfReference,
                    roomRolloffFactor,
                    decayHFLimit));
            }

            return presets;
        }
    }
}
