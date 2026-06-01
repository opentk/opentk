using GeneratorBase;
using GeneratorBase.Utility;
using GeneratorBase.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ALGenerator.Parsing
{
    static class DocumentationParser
    {
        public static Documentation Parse(Stream docs)
        {
            XDocument xdocument = XDocument.Load(docs);

            Dictionary<string, EnumMemberDocumentation> enumDocumentation = ParseEnumDocumentation(xdocument.Root!);
            Dictionary<string, FunctionDocumentation> commandDocumentation = ParseCommandDocumentation(xdocument.Root!);

            return new Documentation(enumDocumentation, commandDocumentation);
        }

        private static readonly Regex RangeRegex = new Regex(@"(.*)\.\.(?:(=?)(.*))?", RegexOptions.Compiled | RegexOptions.CultureInvariant);
        private static Dictionary<string, EnumMemberDocumentation> ParseEnumDocumentation(XElement root)
        {
            Dictionary<string, EnumMemberDocumentation> enumDocs = new Dictionary<string, EnumMemberDocumentation>();

            var enums = root.Elements("enums");
            foreach (var @enum in enums.Elements("enum"))
            {
                string name = @enum.Attribute("name")!.Value;
                string? comment = @enum.Attribute("comment")?.Value;

                PropertyInfo? propInfo = null;
                if (@enum.Element("property") is XElement property)
                {
                    string[] on = property.Attribute("on")!.Value.Split(',');
                    string? type = property.Attribute("type")?.Value;
                    string? @class = property.Attribute("class")?.Value;
                    string[]? group = property.Attribute("group")?.Value?.Split(',');
                    string? @default = property.Attribute("default")?.Value;

                    PropertyRange? range = null;
                    if (property.Attribute("range")?.Value is string rangeString)
                    {
                        var match = RangeRegex.Match(rangeString);
                        if (match.Success)
                        {
                            string start = match.Groups[1].Value;
                            string? end = null;
                            bool inclusive = false;
                            if (match.Groups.Count > 1)
                            {
                                inclusive = match.Groups[2].Value == "=";
                                end = match.Groups[3].Value;
                            }

                            range = new PropertyRange(start, end, inclusive);
                        }
                    }
                    
                    propInfo = new PropertyInfo(on, type, group, range, @default);
                }

                string? comment2 = @enum.Element("comment")?.Value;

                if (comment2 != null)
                {
                    if (comment != null)
                    {
                        comment = $"{comment}{Environment.NewLine}{comment2}";
                    }
                    else
                    {
                        comment = comment2;
                    }
                }

                enumDocs.Add(name, new EnumMemberDocumentation(name, comment) { PropertyInfo = propInfo });
            }

            return enumDocs;
        }

        private static Dictionary<string, FunctionDocumentation> ParseCommandDocumentation(XElement root)
        {
            Dictionary<string, FunctionDocumentation> commandDocs = new Dictionary<string, FunctionDocumentation>();

            var commands = root.Elements("commands");
            foreach (var command in commands.Elements("command"))
            {
                string name = command.Element("proto")!.Element("name")!.Value;
                string comment = command.Attribute("comment")?.Value ?? "";

                commandDocs.Add(name, new FunctionDocumentation()
                {
                    FunctionName = name,
                    Purpose = comment,
                    Parameters = [],
                    RefPagesLinks = [],
                    VersionInfo = default
                });
            }

            return commandDocs;
        }
    }
}
