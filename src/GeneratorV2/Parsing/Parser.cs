using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace GeneratorV2.Parsing
{
    public class Parser
    {
        public static Specification Parse(Stream input)
        {
            var xdocument = XDocument.Load(input);
            var commands = CommandParser.Parse(xdocument.Root);
            var enums =  ParseEnums(xdocument.Root);

            var features = ParseFeatures(xdocument.Root, commands, enums);
            var extensions = ParseExtensions(xdocument.Root, commands, enums);

            

            return new Specification(null, commands, enums);
        }

        public static List<EnumsEntry> ParseEnums(XElement input)
        {
            Logger.Info("Begining parsing of enums.");
            List<EnumsEntry> enumsEntries = new List<EnumsEntry>();
            foreach (var enums in input.Elements("enums"))
            {
                var @namespace = enums.Attribute("namespace")?.Value;
                if (@namespace == null) throw new Exception($"Enums entry '{enums}' is missing a namespace attribute.");

                var group = enums.Attribute("group")?.Value?.Split(',', StringSplitOptions.RemoveEmptyEntries);

                var vendor = enums.Attribute("vendor")?.Value;

                var type = ParseEnumsType(enums.Attribute("type")?.Value);

                var startStr = enums.Attribute("start")?.Value;
                var endStr = enums.Attribute("end")?.Value;
                if ((startStr == null) != (endStr == null))
                    throw new Exception($"Enums entry '{enums}' is missing either a start or end attribute.");

                Range? range = null;
                if (startStr != null)
                {
                    var start = new Int32Converter().ConvertFromString(startStr);
                    var end = new Int32Converter().ConvertFromString(endStr);
                    range = new Range((Index)start, (Index)end);
                }

                var alias = enums.Attribute("alias")?.Value;

                var comment = enums.Attribute("comment")?.Value;

                List<EnumEntry2> entries = new List<EnumEntry2>();
                foreach (var @enum in enums.Elements("enum"))
                {
                    entries.Add(ParseEnumEntry(@enum));
                }

                enumsEntries.Add(new EnumsEntry(@namespace, group, type, vendor, range, alias, comment, entries));
            }

            return enumsEntries;

            static EnumType ParseEnumsType(string? value) => value switch
            {
                null or "" => EnumType.None,
                "bitmask" => EnumType.Bitmask,
                _ => EnumType.Invalid,
            };
        }

        public static List<Feature> ParseFeatures(XElement input, Dictionary<string, Command2> commands, List<EnumsEntry> enums)
        {
            Logger.Info("Begining parsing of features.");

            List<Feature> features = new List<Feature>();

            foreach (var feature in input.Elements("feature"))
            {
                var apiStr = feature.Attribute("api")?.Value;
                var name = feature.Attribute("name")?.Value;
                var number = feature.Attribute("number")?.Value;

                if (apiStr == null || name == null || number == null)
                {
                    throw new Exception($"Feature '{feature}' is missing an attribute.");
                }

                var version = Version.Parse(number);
                var api = ParseApi(apiStr);

                List<RequireEntry> requireEntries = new List<RequireEntry>();
                foreach (var require in feature.Elements("require"))
                {
                    RequireEntry reqEntry = ParseRequire(require, commands, enums);
                    requireEntries.Add(reqEntry);
                }

                List<RemoveEntry> removeEntries = new List<RemoveEntry>();
                foreach (var remove in feature.Elements("remove"))
                {
                    RemoveEntry removeEntry = ParseRemove(remove, commands, enums);
                    removeEntries.Add(removeEntry);
                }

                features.Add(new Feature(api, version, name, requireEntries, removeEntries));
            }

            return features;
        }

        public static List<Extension> ParseExtensions(XElement input, Dictionary<string, Command2> commands, List<EnumsEntry> enums)
        {
            List<Extension> extensions = new List<Extension>();

            foreach (var extension in input.Elements("extension"))
            {
                var extName = extension.Attribute("name")?.Value;
                if (extName == null)
                {
                    throw new Exception($"Extension '{extension}' is missing a name!");
                }

                var vendor = extName[3..extName.IndexOf("_", 3, StringComparison.Ordinal)];
                if (string.IsNullOrEmpty(vendor))
                {
                    throw new Exception($"Extension '{extension}' doesn't have the vendor in it's name!");
                }

                var comment = extension.Attribute("comment")?.Value;

                var supportedApis = extension
                    .Attribute("supported")?.Value?
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => ParseApi(s)).ToArray();

                if (supportedApis == null)
                {
                    throw new Exception($"Extension '{extension}' did not specify any supported APIs.");
                }

                List<RequireEntry> requires = new List<RequireEntry>();
                foreach (var require in extension.Elements("require"))
                {
                    requires.Add(Parser.ParseRequire(extension, commands, enums));
                }

                extensions.Add(new Extension(extName, vendor, supportedApis, comment, requires));
            }

            return extensions;
        }



        public static EnumEntry2 ParseEnumEntry(XElement @enum)
        {
            var name = @enum.Attribute("name")?.Value;
            var valueStr = @enum.Attribute("value")?.Value;
            if (valueStr == null || name == null)
            {
                throw new Exception($"Enum {name} did not pass correctly");
            }

            var suffix = ParseEnumTypeSuffix(@enum.Attribute("type")?.Value);

            var value = ConvertToUInt64(valueStr, suffix);

            var groups = @enum.Attribute("group")?.Value?.Split(',', StringSplitOptions.RemoveEmptyEntries);

            var comment = @enum.Attribute("comment")?.Value;

            var api = Parser.ParseApi(@enum.Attribute("api")?.Value);

            return new EnumEntry2(name, api, value, comment, groups, suffix);

            static TypeSuffix ParseEnumTypeSuffix(string? suffix) => suffix switch
            {
                null or "" => TypeSuffix.None,
                "u" => TypeSuffix.U,
                "ull" => TypeSuffix.Ull,
                _ => TypeSuffix.Invalid,
            };

            static ulong ConvertToUInt64(string val, TypeSuffix type) => type switch
            {
                TypeSuffix.None => (uint)(int)new Int32Converter().ConvertFromString(val),
                TypeSuffix.Ull => (ulong)(long)new Int64Converter().ConvertFromString(val),
                TypeSuffix.U => (ulong)(long)new UInt32Converter().ConvertFromString(val),
                TypeSuffix.Invalid or _ => throw new Exception($"Invalid suffix '{type}'!"),
            };
        }

        public static RequireEntry ParseRequire(XElement requires, Dictionary<string, Command2> commands, List<EnumsEntry> enums)
        {
            var api = ParseApi(requires.Attribute("api")?.Value);
            var profile = ParseProfile(requires.Attribute("profile")?.Value);
            var comment = requires.Attribute("comment")?.Value;

            List<Command2> reqCommands = new List<Command2>();
            List<EnumEntry> reqEnums = new List<EnumEntry>();

            foreach (var entry in requires.Elements())
            {
                string? name = entry.Attribute("name")?.Value;
                if (name == null) throw new Exception($"The entry '{entry}' didn't contain a name attribute.");

                switch (entry.Name.LocalName)
                {
                    case "command":
                        if (commands.TryGetValue(name, out var command))
                        {
                            reqCommands.Add(command);
                        }
                        break;
                    case "enum":
                        if (enums.TryGetValue(name, out var @enum))
                        {
                            reqEnums.Add(@enum);
                        }
                        break;
                    default:
                        continue;
                }
            }

            return new RequireEntry(api, profile, comment, reqCommands, reqEnums);
        }

        public static RemoveEntry ParseRemove(XElement requires, Dictionary<string, Command2> commands, List<EnumsEntry> enums)
        {
            var profile = ParseProfile(requires.Attribute("profile")?.Value);
            var comment = requires.Attribute("comment")?.Value;

            List<Command2> removeCommands = new List<Command2>();
            List<EnumEntry> removeEnums = new List<EnumEntry>();

            foreach (var entry in requires.Elements())
            {
                string? name = entry.Attribute("name")?.Value;
                if (name == null) throw new Exception($"The entry '{entry}' didn't contain a name attribute.");

                switch (entry.Name.LocalName)
                {
                    case "command":
                        if (commands.TryGetValue(name, out var command))
                        {
                            removeCommands.Add(command);
                        }
                        break;
                    case "enum":
                        if (enums.TryGetValue(name, out var @enum))
                        {
                            removeEnums.Add(@enum);
                        }
                        break;
                    default:
                        continue;
                }
            }

            return new RemoveEntry(profile, comment, removeCommands, removeEnums);
        }



        public static GLAPI ParseApi(string? api) => api switch
        {
            null or "" => GLAPI.None,

            "gl" => GLAPI.GL,
            "gles1" => GLAPI.GLES1,
            "gles2" => GLAPI.GLES2,
            "glsc2" => GLAPI.GLSC2,

            _ => GLAPI.Invalid,
        };

        public static GLProfile ParseProfile(string? profile) => profile switch
        {
            null or "" => GLProfile.None,

            "core" => GLProfile.Core,
            "compatibility" => GLProfile.Compatibility,
            "common" => GLProfile.Common,

            _ => GLProfile.Invalid,
        };
    }
}
