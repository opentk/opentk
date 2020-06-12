using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

namespace GeneratorV2.Parsing
{
    public class EnumParser : IParser<XElement>
    {
        public void Parse(XElement input, Specification output)
        {
            Logger.Info("Beggining parsing of enums.");
            EnumEntryCollection enums = output.Enums;
            foreach (var e in input.Elements("enums"))
            {
                var parentGroups = e.Attribute("group")?.Value?.Split(',', StringSplitOptions.None) ?? new string[0];
                foreach (var eEntry in e.Elements("enum"))
                {
                    var enumEntry = ParseEnumEntry(parentGroups, eEntry);
                    if (enumEntry != null)
                    {
                        enums.Add(enumEntry);
                    }
                }
            }
        }

        public static ulong ConvertToUInt64(string val, string? type)
        {
            switch (type)
            {
                case "ull":
                case "ll":
                    return (ulong)(long)new Int64Converter().ConvertFromString(val);
                default:
                    return (uint)(int)new Int32Converter().ConvertFromString(val);
            }
        }

        public EnumEntry? ParseEnumEntry(string[] parentGroups, XElement e)
        {
            var entryName = e.Attribute("name")?.Value;
            var valueStr = e.Attribute("value")?.Value;
            if (valueStr == null || entryName == null)
            {
                Logger.Error($"Enum {entryName} did not pass correctly");
                return null;
            }
            var mangledName = NameMangler.MangleEnumName(entryName);
            var value = ConvertToUInt64(valueStr, e.Attribute("type")?.Value);
            var groups = (e.Attribute("group")?.Value?.Split(',', StringSplitOptions.RemoveEmptyEntries) ?? new string[0]).Concat(parentGroups).ToArray();
            var api = e.Attribute("api")?.Value;

            var enumType = e.Parent.Attribute("type")?.Value switch
            {
                "bitmask" => EnumType.Bitmask,
                _ => EnumType.None
            };
            return new EnumEntry(entryName, api, mangledName, value, groups, enumType);
        }
    }
}
