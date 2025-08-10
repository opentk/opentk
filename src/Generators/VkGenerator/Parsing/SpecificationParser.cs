using GeneratorBase;
using GeneratorBase.Utility;
using GeneratorBase.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VkGenerator.Process;

namespace VkGenerator.Parsing
{
    public record SpecificationData(
            List<Define> Defines,
            List<EnumType> Enums,
            // FIXME: These are all the enums that are typedef't.
            List<EnumName> EnumNames,
            List<BitmaskName> BitmaskNames,
            List<StructType> Structs,
            Dictionary<string, Constant> Constants,
            List<HandleType> Handles,
            List<Function> Commands,
            List<Feature> Features,
            List<Extension> Extensions);

    public record TypeData (
        List<Define> Defines, 
        List<StructType> Structs,
        List<EnumName> EnumNames,
        List<BitmaskName> BitmaskNames,
        List<BaseType> BaseTypes,
        List<HandleType> HandleTypes,
        List<ExternalType> ExternalTypes
        );

    public record EnumName(string Name, string? Alias);

    public record BitmaskName(string Type, string Name, string? Requires, string? Alias);

    public record BaseType(string Name, string? Type);

    // Define the types of the macros?
    public record Define(string Name, BaseCSType Type, bool IsConstant, ulong ConstValue, List<DefineArgument> Arguments, string? Implementation)
    {
        public VersionInfo VersionInfo;
    }
    public record DefineArgument(string Name, BaseCSType Type);

    public record HandleType(string Name, string? Parent, string Type, string TypeEnum, string? Alias) : IReferable
    {
        public VersionInfo? VersionInfo;
        public HandleType? ResolvedParent;

        public List<Function> ReferencedBy { get; } = [];
    }

    public record ExternalType(string Name, string? HeaderFile);

    public record StructType(string Name, List<StructMember> Members, bool Union, string? Comment, string? Alias) : IStruct
    {
        List<IStructMember> IStruct.Members => Members.Cast<IStructMember>().ToList();

        public VersionInfo? VersionInfo { get; set; }

        public List<Function> ReferencedBy { get; } = [];
    }
    public record StructMember(string Type, string Name, string? Values) : IStructMember
    {
        public BaseCSType? StrongType { get; set; }
    };

    public record FeatureRef(string Name, string Struct);

    internal class SpecificationParser
    {
        static readonly Int32Converter Int32Converter = new Int32Converter();
        static readonly UInt32Converter UInt32Converter = new UInt32Converter();
        static readonly Int64Converter Int64Converter = new Int64Converter();
        static readonly UInt64Converter UInt64Converter = new UInt64Converter();

        public static SpecificationData Parse(Stream input)
        {
            XDocument? xdocument = XDocument.Load(input);

            if (xdocument.Root == null)
                throw new NullReferenceException("The parsed xml didn't contain a Root node.");

            TypeData typeData = ParseTypes(xdocument.Root);

            List<EnumType> enums = ParseEnums(xdocument.Root, out Dictionary<string, Constant> constantsMap);

            List<Function> commands = ParseCommands(xdocument.Root);

            List<Feature> features = ParseFeatures(xdocument.Root);

            List<Extension> extensions = ParseExtensions(xdocument.Root);

            return new SpecificationData(
                typeData.Defines,
                enums,
                typeData.EnumNames,
                typeData.BitmaskNames,
                typeData.Structs,
                constantsMap,
                typeData.HandleTypes,
                commands,
                features,
                extensions);
        }

        public static SpecificationData ParseVideo(Stream input)
        {
            XDocument? xdocument = XDocument.Load(input);

            if (xdocument.Root == null)
                throw new NullReferenceException("The parsed xml didn't contain a Root node.");

            //XElement registry = xdocument.Element("registry") ?? throw new Exception("No <registry> tag.");

            TypeData typeData = ParseTypes(xdocument.Root);

            List<EnumType> enums = ParseEnums(xdocument.Root, out Dictionary<string, Constant> constantsMap);

            // video.xml doesn't contain any commands
            //List<Command> commands = ParseCommands(xdocument.Root);

            List<Feature> features = ParseFeatures(xdocument.Root);

            List<Extension> extensions = ParseVideoExtensions(xdocument.Root);

            return new SpecificationData(
                typeData.Defines,
                enums,
                typeData.EnumNames,
                typeData.BitmaskNames,
                typeData.Structs,
                constantsMap,
                typeData.HandleTypes,
                new List<Function>(),
                features,
                extensions);
        }

        public static TypeData ParseTypes(XElement root)
        {
            XElement? xelement = root.Element("types")!;

            List<Define> defines = new List<Define>();
            List<StructType> structs = new List<StructType>();
            List<EnumName> enumNames = new List<EnumName>();
            List<BitmaskName> bitmaskNames = new List<BitmaskName>();
            List<BaseType> baseTypes = new List<BaseType>();
            List<HandleType> handleTypes = new List<HandleType>();
            List<ExternalType> externalTypes = new List<ExternalType>();

            foreach (XElement type in xelement.Elements("type"))
            {
                string? category = type.Attribute("category")?.Value;
                string? name = type.Attribute("name")?.Value;
                string? requires = type.Attribute("requires")?.Value;
                bool deprecated = type.Attribute("deprecated")?.Value == "true";
                string? api = type.Attribute("api")?.Value;
                string? objtypeenum = type.Attribute("objtypeenum")?.Value;
                string? parent = type.Attribute("parent")?.Value;
                string? alias = type.Attribute("alias")?.Value;
                bool returnedonly = type.Attribute("returnedonly")?.Value == "true";
                string? comment = type.Attribute("comment")?.Value;

                // FIXME: For now we don't deal with vulkansc
                if (api == "vulkansc")
                {
                    continue;
                }

                if (category == "include")
                {
                    // ignore for now.
                }
                else if (category == "define")
                {
                    defines.Add(ParseDefine(type));
                }
                else if (category == "union")
                {
                    if (alias != null)
                        Console.WriteLine($"Union '{name}' has unexpected alias '{alias}'. We don't deal with this yet in the generator.");
                    structs.Add(new StructType(name!, ParseStructMembers(type), true, comment, null));
                }
                else if (category == "struct")
                {
                    structs.Add(new StructType(name!, ParseStructMembers(type), false, comment, alias));
                }
                else if (category == "enum")
                {
                    enumNames.Add(new EnumName(name ?? throw new Exception(), alias));
                }
                else if (category == "bitmask")
                {
                    string? bitvalues = type.Attribute("bitvalues")?.Value;

                    if (alias != null)
                    {
                        string baseType = bitmaskNames.Find(bmn => bmn.Name == alias)?.Type ?? throw new Exception();
                        bitmaskNames.Add(new BitmaskName(baseType, name ?? throw new Exception(), requires ?? bitvalues, alias));
                    }
                    else
                    {
                        string bitmaskName = type.Element("name")?.Value ?? throw new Exception();
                        string baseType = type.Element("type")?.Value ?? throw new Exception();
                        bitmaskNames.Add(new BitmaskName(baseType, bitmaskName, requires ?? bitvalues, null));
                    }
                }
                else if (category == "basetype")
                {
                    string typeName = type.Element("name")?.Value ?? throw new Exception();
                    string? typeType = type.Element("type")?.Value;

                    baseTypes.Add(new BaseType(typeName, typeType));
                }
                else if (category == "handle")
                {
                    if (alias != null)
                    {
                        HandleType aliasType = handleTypes.Find(bmn => bmn.Name == alias) ?? throw new Exception(); ;
                        handleTypes.Add(new HandleType(name ?? throw new Exception(), parent, aliasType.Type, aliasType.TypeEnum, alias));
                    }
                    else
                    {
                        string handleType = type.Element("type")?.Value ?? throw new Exception();
                        string handleName = type.Element("name")?.Value ?? throw new Exception();

                        handleTypes.Add(new HandleType(handleName, parent, handleType, objtypeenum ?? throw new Exception(), null));
                    }
                }
                else if (category == "funcpointer")
                {
                    // FIXME
                }
                else
                {
                    // Some of the basic types such as "void", "int32_t" are defined without requirements. We skip them.
                    if (requires != null)
                    {
                        externalTypes.Add(new ExternalType(name ?? throw new Exception(), requires ?? throw new Exception()));
                    }
                }
            }

            return new TypeData(defines, structs, enumNames, bitmaskNames, baseTypes, handleTypes, externalTypes);
        }

        internal enum TypeSuffix
        {
            Invalid,
            None,
            U,
            Ull,
            Ll,
        }

        public static ulong ConvertToUInt64(string val, TypeSuffix type)
        {
            return type switch
            {
                TypeSuffix.None => (uint)(int)new Int32Converter().ConvertFromString(val)!,
                TypeSuffix.Ll => (ulong)(long)new Int64Converter().ConvertFromString(val)!,
                TypeSuffix.Ull => (ulong)new UInt64Converter().ConvertFromString(val)!,
                TypeSuffix.U => (uint)new UInt32Converter().ConvertFromString(val)!,
                TypeSuffix.Invalid or _ => throw new Exception($"Invalid suffix '{type}'!"),
            };
        }

        public static Define ParseDefine(XElement define)
        {
            string name = define.Attribute("name")?.Value ?? define.Element("name")?.Value ?? throw new Exception();
            string? type = define.Element("type")?.Value;

            switch (name)
            {
                case "VK_MAKE_VERSION":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [
                        new DefineArgument("major", CSPrimitive.Uint(true)),
                        new DefineArgument("minor", CSPrimitive.Uint(true)),
                        new DefineArgument("patch", CSPrimitive.Uint(true))],
                        "return (major << 22) | (minor << 12) | (patch);");
                case "VK_VERSION_MAJOR":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [
                        new DefineArgument("version", CSPrimitive.Uint(true)) ],
                        "return (version >> 22);");
                case "VK_VERSION_MINOR":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [
                        new DefineArgument("version", CSPrimitive.Uint(true)) ],
                        "return ((version >> 12) & 0x3FFU);");
                case "VK_VERSION_PATCH":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [
                        new DefineArgument("version", CSPrimitive.Uint(true)) ],
                        "return (version & 0xFFFU);");
                case "VK_MAKE_API_VERSION":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [
                        new DefineArgument("variant", CSPrimitive.Uint(true)),
                        new DefineArgument("major", CSPrimitive.Uint(true)),
                        new DefineArgument("minor", CSPrimitive.Uint(true)),
                        new DefineArgument("patch", CSPrimitive.Uint(true))],
                        "return (variant << 29) | (major << 22) | (minor << 12) | (patch);");
                case "VK_API_VERSION_VARIANT":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [
                        new DefineArgument("version", CSPrimitive.Uint(true)) ],
                        "return (version >> 29);");
                case "VK_API_VERSION_MAJOR":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [
                        new DefineArgument("version", CSPrimitive.Uint(true)) ],
                        "return ((version >> 22) & 0x7FU);");
                case "VK_API_VERSION_MINOR":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [
                        new DefineArgument("version", CSPrimitive.Uint(true)) ],
                        "return ((version >> 12) & 0x3FFU);");
                case "VK_API_VERSION_PATCH":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [
                        new DefineArgument("version", CSPrimitive.Uint(true)) ],
                        "return (version & 0xFFFU);");
                // FIXME: Make these into static readonly variables instead of making them functions...
                // - Noggin_bops 2025-07-07
                case "VK_API_VERSION_1_0":
                    return new Define(name, CSPrimitive.Ulong(true), false, 0, [], "return MAKE_API_VERSION(0, 1, 0, 0);");
                case "VK_API_VERSION_1_1":
                    return new Define(name, CSPrimitive.Ulong(true), false, 0, [], "return MAKE_API_VERSION(0, 1, 1, 0);");
                case "VK_API_VERSION_1_2":
                    return new Define(name, CSPrimitive.Ulong(true), false, 0, [], "return MAKE_API_VERSION(0, 1, 2, 0);");
                case "VK_API_VERSION_1_3":
                    return new Define(name, CSPrimitive.Ulong(true), false, 0, [], "return MAKE_API_VERSION(0, 1, 3, 0);");
                case "VK_API_VERSION_1_4":
                    return new Define(name, CSPrimitive.Ulong(true), false, 0, [], "return MAKE_API_VERSION(0, 1, 4, 0);");
                case "VKSC_API_VERSION_1_0":
                    return new Define(name, CSPrimitive.Ulong(true), false, 0, [], "return MAKE_API_VERSION(VKSC_API_VARIANT, 1, 0, 0);");
                case "VK_HEADER_VERSION_COMPLETE":
                    return new Define(name, CSPrimitive.Ulong(true), false, 0, [], "return MAKE_API_VERSION(0, 1, 4, HEADER_VERSION);");

                case "VKSC_API_VARIANT":
                case "VK_HEADER_VERSION":
                    Debug.Assert(type == null);
                    return new Define(name, CSPrimitive.Uint(true), true, ConvertToUInt64(define.Element("name")!.NodesAfterSelf().First().ToString(), TypeSuffix.None), [], null);

                case "VK_API_VERSION":
                case "VK_DEFINE_HANDLE":
                case "VK_USE_64_BIT_PTR_DEFINES":
                case "VK_NULL_HANDLE":
                case "VK_DEFINE_NON_DISPATCHABLE_HANDLE":
                    return new Define(name, new CSNotSupportedType(name), false, 0, [], null);


                case "VK_MAKE_VIDEO_STD_VERSION":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [
                        new DefineArgument("major", CSPrimitive.Uint(true)),
                        new DefineArgument("minor", CSPrimitive.Uint(true)),
                        new DefineArgument("patch", CSPrimitive.Uint(true))],
                        "return ((major) << 22) | ((minor) << 12) | (patch);");
                case "VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_API_VERSION_1_0_0":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [], "return MAKE_VIDEO_STD_VERSION(1, 0, 0);");
                case "VK_STD_VULKAN_VIDEO_CODEC_H264_ENCODE_API_VERSION_1_0_0":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [], "return MAKE_VIDEO_STD_VERSION(1, 0, 0);");
                case "VK_STD_VULKAN_VIDEO_CODEC_H265_DECODE_API_VERSION_1_0_0":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [], "return MAKE_VIDEO_STD_VERSION(1, 0, 0);");
                case "VK_STD_VULKAN_VIDEO_CODEC_H265_ENCODE_API_VERSION_1_0_0":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [], "return MAKE_VIDEO_STD_VERSION(1, 0, 0);");
                case "VK_STD_VULKAN_VIDEO_CODEC_VP9_DECODE_API_VERSION_1_0_0":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [], "return MAKE_VIDEO_STD_VERSION(1, 0, 0);");
                case "VK_STD_VULKAN_VIDEO_CODEC_AV1_DECODE_API_VERSION_1_0_0":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [], "return MAKE_VIDEO_STD_VERSION(1, 0, 0);");
                case "VK_STD_VULKAN_VIDEO_CODEC_AV1_ENCODE_API_VERSION_1_0_0":
                    return new Define(name, CSPrimitive.Uint(true), false, 0, [], "return MAKE_VIDEO_STD_VERSION(1, 0, 0);");

                default:
                    throw new Exception($"Unknown define '{name}'.");
            }
        }

        public static List<StructMember> ParseStructMembers(XElement structType)
        {
            List<StructMember> members = new List<StructMember>();
            foreach (XElement member in structType.Elements("member"))
            {
                // FIXME: We don't do vulkansc for now
                if (member.Attribute("api")?.Value == "vulkansc")
                    continue;

                string? values = member.Attribute("values")?.Value;

                bool optional = member.Attribute("optional")?.Value == "true";
                string? len = member.Attribute("len")?.Value;
                string? limittype = member.Attribute("limittype")?.Value;

                string? typeStr = member.GetXmlText(element => (element.Name != "name" && element.Name != "comment") ? element.Value : string.Empty).Trim();
                string name = member.Element("name")!.Value;

                members.Add(new StructMember(typeStr, name, values));
            }

            return members;
        }

        public static List<EnumType> ParseEnums(XElement root, out Dictionary<string, Constant> constantsMap)
        {
            List<EnumType> enumTypes = new List<EnumType>();

            constantsMap = new Dictionary<string, Constant>();

            foreach (XElement enums in root.Elements("enums"))
            {
                string type = enums.Attribute("type")?.Value ?? throw new Exception();
                string name = enums.Attribute("name")?.Value ?? throw new Exception();

                if (type == "constants")
                {
                    foreach (XElement @const in enums.Elements("enum"))
                    {
                        string constName = @const.Attribute("name")?.Value ?? throw new Exception();
                        string? comment = @const.Attribute("comment")?.Value;
                        string? alias = @const.Attribute("alias")?.Value;
                        if (alias != null)
                        {
                            if (constantsMap.TryGetValue(alias, out Constant? constant))
                            {
                                constantsMap.Add(constName, new Constant(constant.Type, constName, null, comment, constant.IntValue, constant.FloatValue, constant.StringValue));
                            }
                        }
                        else
                        {
                            string constTypeStr = @const.Attribute("type")?.Value ?? throw new Exception();
                            ConstantType constType = constTypeStr switch
                            {
                                "int32_t" => ConstantType.Int32,
                                "uint32_t" => ConstantType.Uint32,
                                "uint64_t" => ConstantType.Uint64,
                                "float" => ConstantType.Float,
                                _ => throw new Exception()
                            };

                            string value = @const.Attribute("value")?.Value ?? throw new Exception();
                            value = value.TrimStart('(').TrimEnd(')', 'U', 'L', 'F');

                            bool invert = value.StartsWith('~');
                            if (invert)
                            {
                                value = value[1..];
                            }

                            ulong intValue = 0;
                            float floatValue = 0;
                            switch (constType)
                            {
                                case ConstantType.Int32:
                                    intValue = (ulong)(int)Int32Converter.ConvertFromString(value)!;
                                    break;
                                case ConstantType.Uint32:
                                    intValue = (ulong)(uint)UInt32Converter.ConvertFromString(value)!;
                                    break;
                                case ConstantType.Uint64:
                                    intValue = (ulong)UInt64Converter.ConvertFromString(value)!;
                                    break;
                                case ConstantType.Float:
                                    // FIXME: InvariantCulture!
                                    floatValue = float.Parse(value);
                                    break;
                                default:
                                    throw new Exception();
                            }

                            if (invert)
                            {
                                intValue = ~intValue;
                            }

                            constantsMap.Add(constName, new Constant(constType, constName, null, comment, intValue, floatValue, ""));
                        }
                    }
                }
                else if (type == "enum")
                {
                    List<EnumMember> members = new List<EnumMember>();
                    foreach (XElement member in enums.Elements("enum"))
                    {
                        string? alias = member.Attribute("alias")?.Value;
                        if (alias != null)
                        {
                            EnumMember aliasMember = members.Find(m => m.Name == alias) ?? throw new Exception();
                            string memberName = member.Attribute("name")?.Value ?? throw new Exception();
                            // FIXME: Should we check if this one has a comment?
                            members.Add(new EnumMember()
                            {
                                Name = memberName,
                                OriginalName = memberName,
                                Value = aliasMember.Value,
                                Comment = aliasMember.Comment,
                                Alias = alias,
                                Extension = null,
                            });
                        }
                        else
                        {
                            string memberName = member.Attribute("name")?.Value ?? throw new Exception();
                            string value = member.Attribute("value")?.Value ?? throw new Exception();
                            string? comment = member.Attribute("comment")?.Value;

                            members.Add(new EnumMember()
                            {
                                Name = memberName,
                                OriginalName = memberName,
                                Value = (ulong)(int)Int32Converter.ConvertFromString(value)!,
                                Comment = comment,
                                Alias = null,
                                Extension = null,
                            });
                        }
                    }

                    enumTypes.Add(new EnumType()
                    {
                        Name = name,
                        IsFlags = false,
                        Members = members,

                        Extension = null,
                    });
                }
                else if (type == "bitmask")
                {
                    List<EnumMember> members = new List<EnumMember>();
                    foreach (XElement member in enums.Elements("enum"))
                    {
                        string? alias = member.Attribute("alias")?.Value;
                        if (alias != null)
                        {
                            EnumMember aliasMember = members.Find(m => m.Name == alias) ?? throw new Exception();
                            string memberName = member.Attribute("name")?.Value ?? throw new Exception();
                            // FIXME: Should we check if this one has a comment?
                            //members.Add(new EnumMember(memberName, aliasMember.Value, aliasMember.Comment, alias, null));
                            members.Add(new EnumMember()
                            {
                                Name = memberName,
                                OriginalName = memberName,
                                Value = aliasMember.Value,
                                Comment = aliasMember.Comment,
                                Alias = alias,
                                Extension = null,
                            });
                        }
                        else
                        {
                            string memberName = member.Attribute("name")?.Value ?? throw new Exception();
                            string? comment = member.Attribute("comment")?.Value;

                            string? bitpos = member.Attribute("bitpos")?.Value;
                            if (bitpos != null)
                            {
                                members.Add(new EnumMember()
                                {
                                    Name = memberName,
                                    OriginalName = memberName,
                                    Value = (ulong)1 << int.Parse(bitpos),
                                    Comment = comment,
                                    Alias = null,
                                    Extension = null,
                                });
                            }
                            else
                            {
                                string value = member.Attribute("value")?.Value ?? throw new Exception();
                                members.Add(new EnumMember()
                                {
                                    Name = memberName,
                                    OriginalName = memberName,
                                    Value = (ulong)(int)Int32Converter.ConvertFromString(value)!,
                                    Comment = comment,
                                    Alias = null,
                                    Extension = null,
                                });
                            }
                        }
                    }

                    //enumTypes.Add(new EnumType(name, members, true, null));
                    enumTypes.Add(new EnumType()
                    {
                        Name = name,
                        IsFlags = true,
                        Members = members,

                        Extension = null,
                    });
                }
                else
                {
                    Console.WriteLine($"t: {type} n: {name}");
                }
            }

            return enumTypes;
        }

        public static List<Function> ParseCommands(XElement root)
        {
            XElement? xelement = root.Element("commands")!;

            List<Function> commands = new List<Function>();
            foreach (XElement command in xelement.Elements("command"))
            {
                // FIXME: We don't do vulkansc for now..
                if (command.Attribute("api")?.Value == "vulkansc")
                    continue;

                string? alias = command.Attribute("alias")?.Value;
                if (alias != null)
                {
                    string entryPoint = command.Attribute("name")?.Value ?? throw new Exception();

                    Function cmd = commands.Find(c => c.Name == alias) ?? throw new Exception();

                    // Add a copy of the aliased function and mark it as an alias.
                    commands.Add(cmd with { Name = entryPoint, Alias = cmd.Name });
                }
                else
                {
                    string? successCodes = command.Attribute("successcodes")?.Value;
                    string? errorCodes = command.Attribute("errorcodes")?.Value;

                    XElement proto = command.Element("proto") ?? throw new Exception();

                    string entryPoint = proto.Element("name")?.Value ?? throw new Exception();

                    string returnTypeStr = proto.GetXmlText(element => element.Name != "name" && element.Name != "comment" ? element.Value : string.Empty);

                    // FIXME: Read <implicitexternsyncparams> tags?

                    List<Parameter> parameters = new List<Parameter>();
                    foreach (XElement param in command.Elements("param"))
                    {
                        // FIXME: We don't do vulkansc for now...
                        if (param.Attribute("api")?.Value == "vulkansc")
                            continue;

                        string paramName = param.Element("name")?.Value ?? throw new Exception();
                        string paramTypeStr = param.GetXmlText(element => element.Name != "name" && element.Name != "comment" ? element.Value : string.Empty);
                        bool optional = param.Attribute("optional")?.Value == "true";
                        bool externsync = param.Attribute("externsync")?.Value == "true";
                        string? len = param.Attribute("len")?.Value;

                        parameters.Add(new Parameter()
                        {
                            Name = paramName,
                            OriginalName = paramName,
                            Type = paramTypeStr,
                            Length = len,

                            Optional = optional,
                            ExternSync = externsync,
                        });
                    }

                    commands.Add(new Function()
                    {
                        // FIXME: Name mangler!
                        Name = entryPoint,
                        EntryPoint = entryPoint,
                        Parameters = parameters,
                        ReturnType = returnTypeStr,

                        Alias = null,
                    });
                }
            }

            return commands;
        }

        public static List<Feature> ParseFeatures(XElement root)
        {
            List<Feature> features = new List<Feature>();
            foreach (XElement feature in root.Elements("feature"))
            {
                string[] apis = feature.Attribute("api")?.Value.Split(',') ?? Array.Empty<string>();
                if (apis.Contains("vulkan"))
                {
                    string name = feature.Attribute("name")?.Value ?? throw new Exception();
                    string number = feature.Attribute("number")?.Value ?? throw new Exception();
                    string? depends = feature.Attribute("depends")?.Value;
                    string? comment = feature.Attribute("comment")?.Value;

                    List<RequireTag> requireTags = new List<RequireTag>();
                    foreach (XElement require in feature.Elements("require"))
                    {
                        if (require.Attribute("api")?.Value == "vulkansc")
                            continue;

                        // Features have extension number 0
                        requireTags.Add(ParseRequireTag(require, 0, null));
                    }

                    List<DeprecateTag> deprecateTags = new List<DeprecateTag>();
                    foreach (XElement deprecate in feature.Elements("deprecate"))
                    {
                        if (deprecate.Attribute("api")?.Value == "vulkansc")
                            continue;

                        // Features have extension number 0
                        deprecateTags.Add(ParseDeprecateTag(deprecate));
                    }

                    List<RemoveTag> removeTags = new List<RemoveTag>();
                    foreach (XElement remove in feature.Elements("remove"))
                    {
                        if (remove.Attribute("api")?.Value == "vulkansc")
                            continue;

                        // Features have extension number 0
                        removeTags.Add(ParseRemoveTag(remove));
                    }

                    features.Add(new Feature()
                    {
                        Name = name,
                        Version = Version.Parse(number),
                        RequireTags = requireTags,
                        DeprecateTags = deprecateTags,
                        RemoveTags = removeTags,

                        Depends = depends,
                    });
                }
            }

            return features;
        }

        public static List<Extension> ParseExtensions(XElement root)
        {
            XElement xelement = root.Element("extensions")!;

            List<Extension> extensions = new List<Extension>();
            foreach (XElement extension in xelement.Elements("extension"))
            {
                if (extension.Attribute("api")?.Value == "vulkansc")
                    continue;

                // FIXME: We should use this field to mark all Commands and EnumTypes as
                // "supported" or not. Currently we expose some APIs that we "shouldn't" expose.
                // - Noggin_bops 2024-09-24
                string? supported = extension.Attribute("supported")?.Value;
                if (supported == "disabled")
                    continue;

                string name = extension.Attribute("name")?.Value ?? throw new Exception();
                int number  = int.Parse(extension.Attribute("number")?.Value ?? throw new Exception());

                if (int.TryParse(extension.Attribute("sortorder")?.Value, out int sortOrder) == false)
                    sortOrder = 0;
                string? protect = extension.Attribute("protect")?.Value;
                string? platform = extension.Attribute("platform")?.Value;
                string author = extension.Attribute("author")?.Value ?? throw new Exception();
                string contact = extension.Attribute("contact")?.Value ?? throw new Exception();
                // "device" or "instance"
                string type = extension.Attribute("type")?.Value ?? throw new Exception();
                string? depends = extension.Attribute("depends")?.Value;
                string? ratified = extension.Attribute("ratified")?.Value;
                string? promotedTo = extension.Attribute("promotedto")?.Value;
                string? deprecatedBy = extension.Attribute("deprecatedby")?.Value;
                string? obsoletedBy = extension.Attribute("obsoletedby")?.Value;
                bool provisional = extension.Attribute("provisional")?.Value == "true";
                string? specialUse = extension.Attribute("specialuse")?.Value;

                List<RequireTag> requireTags = new List<RequireTag>();
                foreach (XElement require in extension.Elements("require"))
                {
                    if (require.Attribute("api")?.Value == "vulkansc")
                        continue;

                    requireTags.Add(ParseRequireTag(require, number, name));
                }

                List<DeprecateTag> deprecateTags = new List<DeprecateTag>();
                foreach (XElement deprecate in extension.Elements("deprecate"))
                {
                    if (deprecate.Attribute("api")?.Value == "vulkansc")
                        continue;

                    deprecateTags.Add(ParseDeprecateTag(deprecate));
                }

                List<RemoveTag> removeTags = new List<RemoveTag>();
                foreach (XElement remove in extension.Elements("remove"))
                {
                    if (remove.Attribute("api")?.Value == "vulkansc")
                        continue;

                    removeTags.Add(ParseRemoveTag(remove));
                }

                extensions.Add(new Extension()
                {
                    Name = name,
                    RequireTags = requireTags,
                    DeprecateTags = deprecateTags,
                    RemoveTags = removeTags,

                    Number = number,
                    SortOrder = sortOrder,
                    Protect = protect,
                    Platform = platform,
                    Author = author,
                    Contact = contact,
                    Type = type,
                    Depends = depends,
                    Supported = supported,
                    Ratified = ratified,
                    DeprecatedBy = deprecatedBy,
                    ObsoletedBy = obsoletedBy,
                    Provisional = provisional,
                    SpecialUse = specialUse,
                });
            }

            return extensions;
        }

        public static RequireTag ParseRequireTag(XElement require, int number, string? extensionName)
        {
            // FIXME: use?
            string? requireDepends = require.Attribute("depends")?.Value;
            string? tagComment = require.Attribute("comment")?.Value;

            List<RequireEnum> addedEnums = new List<RequireEnum>();
            List<Constant> addedConstants = new List<Constant>();

            List<EnumRef> requiredEnums = new List<EnumRef>();
            List<string> requiredConstants = new List<string>();
            foreach (XElement @enum in require.Elements("enum"))
            {
                if (@enum.Attribute("api")?.Value == "vulkansc")
                    continue;

                string? extends = @enum.Attribute("extends")?.Value;
                if (extends == null)
                {
                    // This is a constant.

                    string constName = @enum.Attribute("name")?.Value ?? throw new Exception();
                    string? comment = @enum.Attribute("comment")?.Value;

                    string? valueStr = @enum.Attribute("value")?.Value;
                    if (valueStr != null)
                    {
                        if (valueStr.StartsWith("VK_"))
                        {
                            Console.WriteLine(valueStr);
                            continue;
                        }
                        else if (valueStr.StartsWith('\"') && valueStr.EndsWith('\"'))
                        {
                            // This is a string constant.
                            addedConstants.Add(new Constant(ConstantType.String, constName, extensionName, comment, 0, 0, valueStr));
                            requiredConstants.Add(constName);
                        }
                        else
                        {
                            int value = (int)Int32Converter.ConvertFromString(valueStr)!;

                            // FIXME: Figure out the type?
                            addedConstants.Add(new Constant(ConstantType.Uint32, constName, extensionName, comment, (ulong)value, 0, ""));
                            requiredConstants.Add(constName);
                        }
                    }
                    else
                    {
                        // This is a reference to a constant defined previously as an enum.
                        // Maybe we want to handle this?
                        //Console.WriteLine($"Enum without extends= or value=: {constName}");
                    }
                }
                else
                {
                    string? comment = @enum.Attribute("comment")?.Value;

                    string enumName = @enum.Attribute("name")?.Value ?? throw new Exception();

                    string? alias = @enum.Attribute("alias")?.Value;
                    if (alias != null)
                    {
                        addedEnums.Add(new RequireEnum(enumName, null, extends, alias, comment));
                        requiredEnums.Add(new EnumRef(enumName));
                    }
                    else
                    {
                        string? offsetStr = @enum.Attribute("offset")?.Value;
                        string? bitposStr = @enum.Attribute("bitpos")?.Value;
                        string? valueStr = @enum.Attribute("value")?.Value;

                        int value;
                        if (offsetStr != null)
                        {
                            if (int.TryParse(@enum.Attribute("extnumber")?.Value ?? "", out int extNumber) == false)
                                extNumber = number;

                            value = 1000000000 + ((extNumber - 1) * 1000) + int.Parse(offsetStr);

                            if (@enum.Attribute("dir")?.Value == "-")
                                value = -value;
                        }
                        else if (bitposStr != null)
                        {
                            value = 1 << int.Parse(bitposStr);
                        }
                        else if (valueStr != null)
                        {
                            value = int.Parse(valueStr);
                        }
                        else
                        {
                            throw new Exception();
                        }

                        addedEnums.Add(new RequireEnum(enumName, value, extends, null, comment));
                        requiredEnums.Add(new EnumRef(enumName));
                    }
                }
            }

            List<CommandRef> requiredCommands = new List<CommandRef>();
            foreach (XElement command in require.Elements("command"))
            {
                string commandName = command.Attribute("name")?.Value ?? throw new Exception();

                requiredCommands.Add(new CommandRef(commandName));
            }
            
            List<TypeRef> requiredTypes = new List<TypeRef>();
            foreach (XElement command in require.Elements("type"))
            {
                string commandName = command.Attribute("name")?.Value ?? throw new Exception();

                requiredTypes.Add(new TypeRef(commandName));
            }

            //return new RequireTag(requiredEnums, requiredCommands, requiredTypes, requiredConstants, tagComment);
            return new RequireTag()
            {
                Commands = requiredCommands,
                Enums = requiredEnums,
                Types = requiredTypes,
                Constants = requiredConstants,

                Comment = tagComment,

                AddedEnums = addedEnums,
                AddedConstants = addedConstants,
            };
        }

        public static DeprecateTag ParseDeprecateTag(XElement deprecate)
        {
            string? tagComment = deprecate.Attribute("comment")?.Value;
            string? explanationlink = deprecate.Attribute("explanationlink")?.Value;

            List<CommandRef> deprecatedCommands = new List<CommandRef>();
            foreach (XElement command in deprecate.Elements("command"))
            {
                string commandName = command.Attribute("name")?.Value ?? throw new Exception();

                deprecatedCommands.Add(new CommandRef(commandName));
            }

            List<TypeRef> deprecatedTypes = new List<TypeRef>();
            foreach (XElement type in deprecate.Elements("type"))
            {
                string typeName = type.Attribute("name")?.Value ?? throw new Exception();

                deprecatedTypes.Add(new TypeRef(typeName));
            }

            return new DeprecateTag()
            {
                Commands = deprecatedCommands,
                Enums = [],
                Types = deprecatedTypes,
                Constants = [],

                Comment = tagComment,

                ExplanationLink = explanationlink,
            };
        }

        public static RemoveTag ParseRemoveTag(XElement remove)
        {
            string? tagComment = remove.Attribute("comment")?.Value;
            string? explanationlink = remove.Attribute("explanationlink")?.Value;

            List<EnumRef> removedEnums = new List<EnumRef>();
            foreach (XElement @enum in remove.Elements("command"))
            {
                string enumName = @enum.Attribute("name")?.Value ?? throw new Exception();

                removedEnums.Add(new EnumRef(enumName));
            }

            List<CommandRef> removedCommands = new List<CommandRef>();
            foreach (XElement command in remove.Elements("command"))
            {
                string commandName = command.Attribute("name")?.Value ?? throw new Exception();

                removedCommands.Add(new CommandRef(commandName));
            }

            List<TypeRef> removedTypes = new List<TypeRef>();
            foreach (XElement type in remove.Elements("type"))
            {
                string typeName = type.Attribute("name")?.Value ?? throw new Exception();

                removedTypes.Add(new TypeRef(typeName));
            }

            List<FeatureRef> removedFeatures = new List<FeatureRef>();
            foreach (XElement feature in remove.Elements("feature"))
            {
                string featureName = feature.Attribute("name")?.Value ?? throw new Exception();
                string structName = feature.Attribute("struct")?.Value ?? throw new Exception();

                removedFeatures.Add(new FeatureRef(featureName, structName));
            }

            return new RemoveTag()
            {
                Commands = removedCommands,
                Enums = removedEnums,
                Types = removedTypes,
                Constants = [],

                Comment = tagComment,

                ReasonLink = explanationlink,
            };
        }

        public static List<Extension> ParseVideoExtensions(XElement root)
        {
            XElement xelement = root.Element("extensions")!;

            List<Extension> extensions = new List<Extension>();
            foreach (XElement extension in xelement.Elements("extension"))
            {
                if (extension.Attribute("api")?.Value == "vulkansc")
                    continue;

                string? supported = extension.Attribute("supported")?.Value;
                if (supported == "disabled")
                    continue;

                string name = extension.Attribute("name")?.Value ?? throw new Exception();

                if (int.TryParse(extension.Attribute("sortorder")?.Value, out int sortOrder) == false)
                    sortOrder = 0;
                string? protect = extension.Attribute("protect")?.Value;
                string? platform = extension.Attribute("platform")?.Value;
                // "device" or "instance"
                string? depends = extension.Attribute("depends")?.Value;
                string? ratified = extension.Attribute("ratified")?.Value;
                string? promotedTo = extension.Attribute("promotedto")?.Value;
                string? deprecatedBy = extension.Attribute("deprecatedby")?.Value;
                string? obsoletedBy = extension.Attribute("obsoletedby")?.Value;
                bool provisional = extension.Attribute("provisional")?.Value == "true";
                string? specialUse = extension.Attribute("specialuse")?.Value;

                List<RequireTag> requireTags = new List<RequireTag>();
                foreach (XElement require in extension.Elements("require"))
                {
                    if (require.Attribute("api")?.Value == "vulkansc")
                        continue;

                    requireTags.Add(ParseVideoRequireTag(require, -1, name));
                }

                List<DeprecateTag> deprecateTags = new List<DeprecateTag>();
                foreach (XElement deprecate in extension.Elements("deprecate"))
                {
                    if (deprecate.Attribute("api")?.Value == "vulkansc")
                        continue;

                    deprecateTags.Add(ParseDeprecateTag(deprecate));
                }

                List<RemoveTag> removeTags = new List<RemoveTag>();
                foreach (XElement remove in extension.Elements("remove"))
                {
                    if (remove.Attribute("api")?.Value == "vulkansc")
                        continue;

                    removeTags.Add(ParseRemoveTag(remove));
                }

                extensions.Add(new Extension()
                {
                    Name = name,
                    RequireTags = requireTags,
                    DeprecateTags = deprecateTags,
                    RemoveTags = removeTags,

                    Number = -1,
                    SortOrder = sortOrder,
                    Protect = protect,
                    Platform = platform,
                    Author = null,
                    Contact = null,
                    Type = null,
                    Depends = depends,
                    Supported = supported,
                    Ratified = ratified,
                    DeprecatedBy = deprecatedBy,
                    ObsoletedBy = obsoletedBy,
                    Provisional = provisional,
                    SpecialUse = specialUse,
                });
            }

            return extensions;
        }

        public static RequireTag ParseVideoRequireTag(XElement require, int number, string? extensionName)
        {
            // FIXME: use?
            string? requireDepends = require.Attribute("depends")?.Value;
            string? tagComment = require.Attribute("comment")?.Value;

            List<RequireEnum> addedEnums = new List<RequireEnum>();
            List<Constant> addedConstants = new List<Constant>();

            List<EnumRef> requiredEnums = new List<EnumRef>();
            List<string> requiredConstants = new List<string>();
            foreach (XElement @enum in require.Elements("enum"))
            {
                if (@enum.Attribute("api")?.Value == "vulkansc")
                    continue;

                string? extends = @enum.Attribute("extends")?.Value;
                if (extends == null)
                {
                    // This is a constant.

                    string constName = @enum.Attribute("name")?.Value ?? throw new Exception();
                    string? comment = @enum.Attribute("comment")?.Value;

                    string valueStr = @enum.Attribute("value")?.Value ?? throw new Exception();
                    if (valueStr.StartsWith("VK_"))
                    {
                        Console.WriteLine(valueStr);
                        continue;
                    }
                    else if (valueStr.StartsWith('\"') && valueStr.EndsWith('\"'))
                    {
                        // This is a string constant.
                        addedConstants.Add(new Constant(ConstantType.String, constName, extensionName, comment, 0, 0, valueStr));
                        requiredConstants.Add(constName);
                    }
                    else
                    {
                        int value = (int)Int32Converter.ConvertFromString(valueStr)!;

                        // FIXME: Figure out the type?
                        addedConstants.Add(new Constant(ConstantType.Uint32, constName, extensionName, comment, (ulong)value, 0, ""));
                        requiredConstants.Add(constName);
                    }
                }
                else
                {
                    string? comment = @enum.Attribute("comment")?.Value;

                    string enumName = @enum.Attribute("name")?.Value ?? throw new Exception();

                    string? alias = @enum.Attribute("alias")?.Value;
                    if (alias != null)
                    {
                        addedEnums.Add(new RequireEnum(enumName, null, extends, alias, comment));
                        requiredEnums.Add(new EnumRef(enumName));
                    }
                    else
                    {
                        string valueStr = @enum.Attribute("value")?.Value ?? throw new Exception();
                        int value = int.Parse(valueStr);
                        addedEnums.Add(new RequireEnum(enumName, value, extends, null, comment));
                        requiredEnums.Add(new EnumRef(enumName));
                    }
                }
            }

            List<CommandRef> requiredCommands = new List<CommandRef>();
            foreach (XElement command in require.Elements("command"))
            {
                string commandName = command.Attribute("name")?.Value ?? throw new Exception();

                requiredCommands.Add(new CommandRef(commandName));
            }

            List<TypeRef> requiredTypes = new List<TypeRef>();
            foreach (XElement command in require.Elements("type"))
            {
                string commandName = command.Attribute("name")?.Value ?? throw new Exception();

                requiredTypes.Add(new TypeRef(commandName));
            }

            return new RequireTag()
            {
                Commands = requiredCommands,
                Enums = requiredEnums,
                Types = requiredTypes,
                Constants = requiredConstants,

                Comment = tagComment,

                AddedEnums = addedEnums,
                AddedConstants = addedConstants,
            };
        }
    }
}
