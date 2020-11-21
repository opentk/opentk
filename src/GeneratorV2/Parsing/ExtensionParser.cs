using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GeneratorV2.Parsing
{
    public class ExtensionParser
    {
        public List<Extension> Parse(XElement input, Dictionary<string, Command2> commands, EnumEntryCollection enums)
        {
            List<Extension> extensions = new List<Extension>();

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
                    var extension = new Extension(api, extName, NameMangler.MangleClassName(vendor));
                    foreach (var includes in ext.Elements("require"))
                    {
                        var includesApi = includes.Attribute("api")?.Value;
                        if (includesApi == api || includesApi == null)
                        {
                            ParseInclude(enums, commands, extension, includes, vendor);
                        }
                    }

                    extensions.Add(extension);
                }
            }

            return extensions;
        }

        private static void ParseInclude(EnumEntryCollection enums, Dictionary<string, Command2> commands,
            Extension extension, XElement includes, string vendorName)
        {
            foreach (var e in includes.Elements("enum"))
            {
                var eName = e.Attribute("name").Value;
                var enumEntries = enums.GetValues(eName, extension.Api);
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
                    Logger.Error($"Could not find the command '{cName}' used by the extension '{"TODO: print extension name"}'.");
                    continue;
                }

                // TODO: Do we really want to do this?
                // Remove the vedor name from the end to make a nicer C# function.
                string name = command.Name;
                if (command.Name.EndsWith(vendorName))
                {
                    name = name[0..^vendorName.Length];
                }

                extension.Add(new Command2(command.Method, "Gl" + name));
            }
        }
    }
}
