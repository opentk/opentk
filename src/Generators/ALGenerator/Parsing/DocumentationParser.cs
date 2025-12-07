using GeneratorBase.Utility;
using GeneratorBase.Utility.Extensions;
using ALGenerator.Process;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace ALGenerator.Parsing
{
    static class DocumentationParser
    {
        public static Documentation Parse(Stream docs)
        {
            Dictionary<OutputApi, VersionDocumentation> versionDocumentation = new Dictionary<OutputApi, VersionDocumentation>();

            XDocument xdocument = XDocument.Load(docs);

            Dictionary<string, CommandDocumentation> docFolder = new Dictionary<string, CommandDocumentation>();

            //Logger.Info($"Documentation {folder.Folder}:\n\n");

            OutputApi api = OutputApi.Invalid;

            //XmlReaderSettings settings = new XmlReaderSettings
            //{
            //    NameTable = new System.Xml.NameTable(),
            //    DtdProcessing = DtdProcessing.Ignore,
            //    ValidationType = ValidationType.None
            //};
            //XmlNamespaceManager xmlns = new XmlNamespaceManager(settings.NameTable);
            //xmlns.AddNamespace("mml", "");
            //XmlParserContext context = new XmlParserContext(null, xmlns, "", XmlSpace.Default);
            //XmlReader reader = XmlReader.Create(docs, settings, context);
            //// https://stackoverflow.com/questions/3504227/prevent-xmltextreader-from-expanding-entities
            //PropertyInfo? propertyInfo = reader.GetType().GetProperty("DisableUndeclaredEntityCheck", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            //propertyInfo!.SetValue(reader, true);
            //XDocument xml = XDocument.Load(reader);

            //string refPagesLink = "https://www.khronos.org/registry/OpenGL-Refpages/";
            //string filename = Path.GetFileNameWithoutExtension(file.Name);
            //switch (api)
            //{
            //    case OutputApi.AL:
            //        refPagesLink += $"al/html/{filename}.xhtml";
            //        break;
            //    case OutputApi.ALC:
            //        refPagesLink += $"alc/xhtml/{filename}.xml";
            //        break;
            //    default:
            //        throw new Exception("API not supported for documentation.");
            //}

            Dictionary<string, EnumMemberDocumentation> enumDocumentation = ParseEnumDocumentation(xdocument.Root!);
            Dictionary<string, CommandDocumentation> commandDocumentation = ParseCommandDocumentation(xdocument.Root!);

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

                enumDocs.Add(name, new EnumMemberDocumentation(name, comment, comment2, propInfo));
            }

            return enumDocs;


            /*
            XElement namediv = root.ElementIgnoreNamespace("refnamediv");
            string purpose = namediv.ElementIgnoreNamespace("refpurpose").Value;
            purpose = NameMangler.MangleCommandPurpose(purpose);

            Dictionary<string, string> parametersDescriptions = new Dictionary<string, string>();

            XElement ? refparameters = root.ElementIgnoreNamespace(e => e.AttributeIgnoreNamespace("id")?.Value == "parameters");
            if (refparameters != null)
            {
                XElement variableList = refparameters.ElementIgnoreNamespace("variablelist");
                foreach (var entry in variableList.ElementsIgnoreNamespace("varlistentry"))
                {
                    string desc = entry.ElementIgnoreNamespace("para").Value;
                    desc = NameMangler.MangleParameterDescription(desc);

                    foreach (var term in entry.ElementsIgnoreNamespace("term"))
                    {
                        foreach (var parameter in term.ElementsIgnoreNamespace("parameter"))
                        {
                            if (parametersDescriptions.ContainsKey(parameter.Value) == false)
                            {
                                parametersDescriptions.Add(NameMangler.MangleParameterName(parameter.Value), desc);
                            }
                        }
                    }
                }
            }

            XElement synopsis = root.ElementIgnoreNamespace("refsynopsisdiv");
            foreach (XElement prototype in synopsis.ElementsIgnoreNamespace("funcprototype"))
            {
                var function = prototype.ElementIgnoreNamespace("function");

                List<ParameterDocumentation> parameters = new List<ParameterDocumentation>();
                foreach (var parameter in prototype.ElementsIgnoreNamespace("parameter"))
                {
                    string parameterName = NameMangler.MangleParameterName(parameter.Value);
                    if (parameterName == "void")
                    {
                        Logger.Warning("void!!!!!!!!!");
                        continue;
                    }

                    parametersDescriptions.TryGetValue(parameterName, out string? desc);

                    parameters.Add(new ParameterDocumentation(parameterName, desc ?? "!!missing documentation!!"));
                }

                documentation.Add(new CommandDocumentation(function.Value, purpose, parameters.ToArray(), refPagesLink));

            return documentation.ToArray();
            }*/
        }

        private static Dictionary<string, CommandDocumentation> ParseCommandDocumentation(XElement root)
        {
            Dictionary<string, CommandDocumentation> commandDocs = new Dictionary<string, CommandDocumentation>();

            var commands = root.Elements("commands");
            foreach (var command in commands.Elements("command"))
            {
                string name = command.Element("proto")!.Element("name")!.Value;
                string comment = command.Attribute("comment")?.Value ?? "";

                commandDocs.Add(name, new CommandDocumentation(name, comment, [], null));
            }

            return commandDocs;
        }
    }
}
