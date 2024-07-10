using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VkGenerator.Process;
using VkGenerator.Utility.Extensions;

namespace VkGenerator.Parsing
{
    public record SpecificationData(
            List<EnumType> Enums,
            // FIXME: These are all the enums that are typedef't.
            List<EnumName> EnumNames,
            List<BitmaskName> BitmaskNames,
            List<StructType> Structs,
            Dictionary<string, Constant> Constants,
            List<BitmaskName> Bitmasks,
            List<HandleType> Handles,
            List<Command> Commands,
            List<Feature> Features,
            List<Extension> Extensions);

    public record TypeData (
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

    public record HandleType(string Name, string? Parent, string Type, string TypeEnum, string? Alias);

    public record ExternalType(string Name, string? HeaderFile);

    public record StructType(string Name, List<StructMember> Members, bool Union, string? Comment);
    public record StructMember(string Type, string Name, string? Values)
    {
        public BaseCSType? StrongType { get; set; }
    };

    public record EnumType(string Name, List<EnumMember> Members, bool Bitmask, string? Extension);
    public record EnumMember(string Name, int Value, string? Comment, string? Alias, string? Extension);

    public record Command(string Name, string ReturnType, List<CommandParameter> Parameters)
    {
        public BaseCSType? StrongReturnType;
    }
    public record CommandParameter(string Name, string Type, bool Optional, bool ExternSync, string? Length)
    {
        public BaseCSType? StrongType;
    }

    public record Feature(string Name, string Number, string? Depends, string? Comment, List<RequireTag> RequireTags);

    public record Extension(
        string Name,
        int Number,
        int SortOrder,
        string? Protect,
        string? Platform,
        string Author,
        string Contact,
        string Type,
        string? Depends,
        string? Supported,
        string? Ratified,
        string? PromotedTo,
        string? DeprecatedBy,
        string? ObsoletedBy,
        bool Provisional,
        string? SpecialUse,
        List<RequireTag> RequireTags);
    public record RequireTag(List<RequireEnum> RequiredEnums, List<RequireCommand> RequiredCommands, List<RequireType> RequiredTypes, string? Comment);
    /// <summary>We either know Value or Alias.</summary>
    public record RequireEnum(string Name, int? Value, string Extends, string? Alias, string? Comment);
    public record RequireCommand(string Name);
    public record RequireType(string Name);

    public enum ConstantType
    {
        Int32,
        Uint32,
        Uint64,
        Float,
    }

    public record Constant(ConstantType Type, string Name, ulong IntValue, float FloatValue);

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

            //XElement registry = xdocument.Element("registry") ?? throw new Exception("No <registry> tag.");

            TypeData typeData = ParseTypes(xdocument.Root);

            List<EnumType> enums = ParseEnums(xdocument.Root, out Dictionary<string, Constant> constantsMap);

            List<Command> commands = ParseCommands(xdocument.Root);

            List<Feature> features = ParseFeatures(xdocument.Root);

            List<Extension> extensions = ParseExtensions(xdocument.Root);

            ParseExtensions(xdocument.Root);

            return new SpecificationData(
                enums,
                typeData.EnumNames,
                typeData.BitmaskNames,
                typeData.Structs,
                constantsMap,
                typeData.BitmaskNames,
                typeData.HandleTypes,
                commands,
                features,
                extensions);
        }

        public static TypeData ParseTypes(XElement root)
        {
            XElement? xelement = root.Element("types")!;

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

                // FIXME: union
                // FIXME: functionpointer
                // FIXME: define
                // ....

                if (category == "include")
                {
                    // ignore for now.
                }
                else if (category == "define")
                {
                    // ignore for now.
                }
                else if (category == "union")
                {
                    // FIXME
                    structs.Add(new StructType(name!, ParseStructMembers(type), true, comment));
                }
                else if (category == "struct")
                {
                    //Console.WriteLine($"struct {name} {{ c: {category} r: {requires} api: {api} ote: {objtypeenum} p: {parent} a: {alias} d: {deprecated} ro: {returnedonly}");
                    structs.Add(new StructType(name!, ParseStructMembers(type), false, comment));
                }
                else if (category == "enum")
                {
                    enumNames.Add(new EnumName(name ?? throw new Exception(), alias));
                }
                else if (category == "bitmask")
                {
                    
                    if (alias != null)
                    {
                        string baseType = bitmaskNames.Find(bmn => bmn.Name == alias)?.Type ?? throw new Exception();
                        bitmaskNames.Add(new BitmaskName(baseType, name ?? throw new Exception(), requires, alias));
                    }
                    else
                    {
                        string bitmaskName = type.Element("name")?.Value ?? throw new Exception();
                        string baseType = type.Element("type")?.Value ?? throw new Exception();
                        bitmaskNames.Add(new BitmaskName(baseType, bitmaskName, requires, null));
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

            return new TypeData(structs, enumNames, bitmaskNames, baseTypes, handleTypes, externalTypes);
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
                        string? alias = @const.Attribute("alias")?.Value;
                        if (alias != null)
                        {
                            if (constantsMap.TryGetValue(alias, out Constant? constant))
                            {
                                constantsMap.Add(constName, constant);
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

                            constantsMap.Add(constName, new Constant(constType, constName, intValue, floatValue));
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
                            members.Add(new EnumMember(memberName, aliasMember.Value, aliasMember.Comment, alias, null));
                        }
                        else
                        {
                            string memberName = member.Attribute("name")?.Value ?? throw new Exception();
                            string value = member.Attribute("value")?.Value ?? throw new Exception();
                            string? comment = member.Attribute("comment")?.Value;

                            members.Add(new EnumMember(memberName, (int)Int32Converter.ConvertFromString(value)!, comment, null, null));
                        }
                    }

                    enumTypes.Add(new EnumType(name, members, false, null));
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
                            members.Add(new EnumMember(memberName, aliasMember.Value, aliasMember.Comment, alias, null));
                        }
                        else
                        {
                            string memberName = member.Attribute("name")?.Value ?? throw new Exception();
                            string? comment = member.Attribute("comment")?.Value;

                            string? bitpos = member.Attribute("bitpos")?.Value;
                            if (bitpos != null)
                            {
                                members.Add(new EnumMember(memberName, 1 << int.Parse(bitpos), comment, null, null));
                            }
                            else
                            {
                                string value = member.Attribute("value")?.Value ?? throw new Exception();
                                members.Add(new EnumMember(memberName, (int)Int32Converter.ConvertFromString(value)!, comment, null, null));
                            }
                        }
                    }

                    enumTypes.Add(new EnumType(name, members, true, null));
                }
                else
                {
                    Console.WriteLine($"t: {type} n: {name}");
                }
            }

            return enumTypes;
        }

        public static List<Command> ParseCommands(XElement root)
        {
            XElement? xelement = root.Element("commands")!;

            List<Command> commands = new List<Command>();
            foreach (XElement command in xelement.Elements("command"))
            {
                // FIXME: We don't do vulkansc for now..
                if (command.Attribute("api")?.Value == "vulkansc")
                    continue;

                string? alias = command.Attribute("alias")?.Value;
                if (alias != null)
                {
                    string entryPoint = command.Attribute("name")?.Value ?? throw new Exception();
                    // FIXME: Do alias things.
                }
                else
                {
                    string? successCodes = command.Attribute("successcodes")?.Value;
                    string? errorCodes = command.Attribute("errorcodes")?.Value;

                    XElement proto = command.Element("proto") ?? throw new Exception();

                    string entryPoint = proto.Element("name")?.Value ?? throw new Exception();

                    string returnTypeStr = proto.GetXmlText(element => element.Name != "name" && element.Name != "comment" ? element.Value : string.Empty);

                    // FIXME: Read <implicitexternsyncparams> tags?

                    List<CommandParameter> parameters = new List<CommandParameter>();
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

                        parameters.Add(new CommandParameter(paramName, paramTypeStr, optional, externsync, len));
                    }

                    commands.Add(new Command(entryPoint, returnTypeStr, parameters));
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
                        requireTags.Add(ParseRequireTag(require, 0));
                    }

                    features.Add(new Feature(name, number, depends, comment, requireTags));
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

                    requireTags.Add(ParseRequireTag(require, number));
                }

                extensions.Add(new Extension(
                    name,
                    number,
                    sortOrder,
                    protect,
                    platform,
                    author,
                    contact,
                    type,
                    depends,
                    supported,
                    ratified,
                    promotedTo,
                    deprecatedBy,
                    obsoletedBy,
                    provisional,
                    specialUse,
                    requireTags));
            }

            return extensions;
        }

        public static RequireTag ParseRequireTag(XElement require, int number)
        {
            // FIXME: use?
            string? requireDepends = require.Attribute("depends")?.Value;
            string? tagComment = require.Attribute("comment")?.Value;

            List<RequireEnum> requiredEnums = new List<RequireEnum>();
            foreach (XElement @enum in require.Elements("enum"))
            {
                if (@enum.Attribute("api")?.Value == "vulkansc")
                    continue;

                string? extends = @enum.Attribute("extends")?.Value;
                if (extends == null)
                {
                    // Extensions add a few global constants that are not part of
                    // any enum. We skip these for now.
                    continue;
                }

                string? comment = @enum.Attribute("comment")?.Value;

                string enumName = @enum.Attribute("name")?.Value ?? throw new Exception();

                string? alias = @enum.Attribute("alias")?.Value;
                if (alias != null)
                {
                    requiredEnums.Add(new RequireEnum(enumName, null, extends, alias, comment));
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

                    requiredEnums.Add(new RequireEnum(enumName, value, extends, null, comment));
                }
            }

            List<RequireCommand> requiredCommands = new List<RequireCommand>();
            foreach (XElement command in require.Elements("command"))
            {
                string commandName = command.Attribute("name")?.Value ?? throw new Exception();

                requiredCommands.Add(new RequireCommand(commandName));
            }
            
            List<RequireType> requiredTypes = new List<RequireType>();
            foreach (XElement command in require.Elements("type"))
            {
                string commandName = command.Attribute("name")?.Value ?? throw new Exception();

                requiredTypes.Add(new RequireType(commandName));
            }

            return new RequireTag(requiredEnums, requiredCommands, requiredTypes, tagComment);
        }
    }
}
