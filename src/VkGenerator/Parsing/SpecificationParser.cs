using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
            List<Command> Commands);

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

    public record StructType(string Name, List<StructMember> Members, bool Union);
    public record StructMember(string Type, string Name)
    {
        public BaseCSType? StrongType { get; set; }
    };

    public record EnumType(string Name, List<EnumMember> Members, bool Bitmask);
    public record EnumMember(string Name, int Value, string? Comment, string? Alias);

    public record Command(string Name, string ReturnType, List<CommandParameter> Parameters)
    {
        public BaseCSType? StrongReturnType;
    }
    public record CommandParameter(string Name, string Type, bool Optional, bool ExternSync, string? Length)
    {
        public BaseCSType? StrongType;
    }

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

            return new SpecificationData(
                enums,
                typeData.EnumNames,
                typeData.BitmaskNames,
                typeData.Structs,
                constantsMap,
                typeData.BitmaskNames,
                typeData.HandleTypes,
                commands);
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
                    structs.Add(new StructType(name!, ParseStructMembers(type), true));
                }
                else if (category == "struct")
                {
                    //Console.WriteLine($"struct {name} {{ c: {category} r: {requires} api: {api} ote: {objtypeenum} p: {parent} a: {alias} d: {deprecated} ro: {returnedonly}");
                    structs.Add(new StructType(name!, ParseStructMembers(type), false));
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

                bool optional = member.Attribute("optional")?.Value == "true";
                string? len = member.Attribute("len")?.Value;
                string? limittype = member.Attribute("limittype")?.Value;

                string? typeStr = member.GetXmlText(element => (element.Name != "name" && element.Name != "comment") ? element.Value : string.Empty).Trim();
                string name = member.Element("name")!.Value;

                members.Add(new StructMember(typeStr, name));
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
                            members.Add(new EnumMember(memberName, aliasMember.Value, aliasMember.Comment, alias));
                        }
                        else
                        {
                            string memberName = member.Attribute("name")?.Value ?? throw new Exception();
                            string value = member.Attribute("value")?.Value ?? throw new Exception();
                            string? comment = member.Attribute("comment")?.Value;

                            members.Add(new EnumMember(memberName, (int)Int32Converter.ConvertFromString(value)!, comment, null));
                        }
                    }

                    enumTypes.Add(new EnumType(name, members, false));
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
                            members.Add(new EnumMember(memberName, aliasMember.Value, aliasMember.Comment, alias));
                        }
                        else
                        {
                            string memberName = member.Attribute("name")?.Value ?? throw new Exception();
                            string? comment = member.Attribute("comment")?.Value;

                            string? bitpos = member.Attribute("bitpos")?.Value;
                            if (bitpos != null)
                            {
                                members.Add(new EnumMember(memberName, 1 << int.Parse(bitpos), comment, null));
                            }
                            else
                            {
                                string value = member.Attribute("value")?.Value ?? throw new Exception();
                                members.Add(new EnumMember(memberName, (int)Int32Converter.ConvertFromString(value)!, comment, null));
                            }
                        }
                    }

                    enumTypes.Add(new EnumType(name, members, true));
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
    }
}
