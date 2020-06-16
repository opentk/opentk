using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GeneratorV2.Parsing
{
    public class ExtensionParser : IParser<XElement>
    {
        public void Parse(XElement input, Specification output)
        {
            var commands = output.Commands;
            EnumEntryCollection enums = output.Enums;
            foreach (var ext in input.Element("extensions").Elements("extension"))
            {
                var extName = ext.Attribute("name")?.Value?.Substring(3);
                if (extName == null)
                {
                    Logger.Error($"Extension did not parse correctly");
                    continue;
                }
                int ind = extName.IndexOf('_', StringComparison.Ordinal);
                if (ind == -1)
                {
                    Logger.Error($"Extension '{extName}' is missing an underscore.");
                    continue;
                }

                var vendor = extName.Remove(ind);
                extName = NameMangler.MangleExtensionName(extName.Substring(ind + 1));

                var supportedApis = ext.Attribute("supported")?.Value?.Split('|', StringSplitOptions.RemoveEmptyEntries) ?? new string[] { };

                foreach (var api in supportedApis)
                {
                    var extension = new Extension(NameMangler.MangleClassName(vendor), extName, api);
                    foreach (var includes in ext.Elements("require"))
                    {
                        var includesApi = includes.Attribute("api")?.Value;
                        if (includesApi == api || includesApi == null)
                        {
                            ParseInclude(enums, commands, extension, includes, vendor);
                        }
                    }

                    output.AddExtension(extension);
                }
            }
        }

        private static void ParseInclude(EnumEntryCollection enums, Dictionary<string, Command> commands,
            Extension extension, XElement includes, string vendorName)
        {
            foreach (var e in includes.Elements("enum"))
            {
                var eName = e.Attribute("name").Value;
                var enumEntries = enums.GetValues(eName, extension.SupportedApi);
                if (enumEntries.Length == 0)
                {
                    Logger.Error($"Extension command include did not parse correctly.");
                    continue;
                }
                foreach(var enumEntry in enumEntries)
                {
                    extension.Add(enumEntry);
                }
            }
            foreach (var e in includes.Elements("command"))
            {
                var cName = e.Attribute("name").Value;
                if (!commands.TryGetValue(cName, out var command))
                {
                    Logger.Error($"Extension command include did not parse correctly.");
                    continue;
                }

                extension.Add(command.CloneCommand("Gl" + (command.Name.EndsWith(vendorName) ?
                                                            command.Name.Remove(command.Name.Length - vendorName.Length) :
                                                            command.Name)));
            }
        }
    }
}
