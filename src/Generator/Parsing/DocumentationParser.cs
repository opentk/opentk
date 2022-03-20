using Generator.Utility;
using Generator.Utility.Extensions;
using Generator.Writing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Generator.Parsing
{
    static class DocumentationParser
    {
        public static Documentation Parse(DocumentationSource source)
        {
            Dictionary<OutputApi, VersionDocumentation> versionDocumentation = new Dictionary<OutputApi, VersionDocumentation>();

            foreach (var folder in source.Folders)
            {
                Dictionary<string, CommandDocumentation> docFolder = new Dictionary<string, CommandDocumentation>();

                //Logger.Info($"Documentation {folder.Folder}:\n\n");

                foreach (var file in folder.Files)
                {
                    XmlReaderSettings settings = new XmlReaderSettings { NameTable = new System.Xml.NameTable() };
                    settings.DtdProcessing = DtdProcessing.Ignore;
                    settings.ValidationType = ValidationType.None;
                    XmlNamespaceManager xmlns = new XmlNamespaceManager(settings.NameTable);
                    xmlns.AddNamespace("mml", "");
                    XmlParserContext context = new XmlParserContext(null, xmlns, "", XmlSpace.Default);
                    XmlReader reader = XmlReader.Create(file, settings, context);
                    // https://stackoverflow.com/questions/3504227/prevent-xmltextreader-from-expanding-entities
                    PropertyInfo? propertyInfo = reader.GetType().GetProperty("DisableUndeclaredEntityCheck", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    propertyInfo!.SetValue(reader, true);
                    XDocument xml = XDocument.Load(reader);
                    CommandDocumentation[] documentation = ParseFile(xml.Root!);

                    foreach (var commandDoc in documentation)
                    {
                        docFolder.Add(commandDoc.Name, commandDoc);
                    }
                }

                OutputApi api = folder.Folder switch
                {
                    "es1.1" => OutputApi.GLES1,
                    "es3" => OutputApi.GLES3,
                    "gl2.1" => OutputApi.GLCompat,
                    "gl4" => OutputApi.GL,
                    _ => throw new NotImplementedException(),
                };

                versionDocumentation.Add(api, new VersionDocumentation(docFolder));
            }

            // Merge in gl4 documentation into glcompat
            var compatDocs = versionDocumentation[OutputApi.GLCompat];
            foreach (var (name, commandDocumentation) in versionDocumentation[OutputApi.GL].Commands)
            {
                compatDocs.Commands[name] = commandDocumentation;
            }

            return new Documentation(versionDocumentation);
        }


        private static CommandDocumentation[] ParseFile(XElement root)
        {
            // FIXME:

            List<CommandDocumentation> documentation = new List<CommandDocumentation>();

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
                                parametersDescriptions.Add(parameter.Value, desc);
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
                    string parameterName = parameter.Value;
                    if (parameterName == "void")
                    {
                        Logger.Warning("void!!!!!!!!!");
                        continue;
                    }

                    parametersDescriptions.TryGetValue(parameterName, out string? desc);
                    if (desc != null)
                        desc = NameMangler.MangleParameterDescription(desc);

                    parameters.Add(new ParameterDocumentation(parameterName, desc ?? "!!missing documentation!!"));
                    //Logger.Info($"  {parameter}: {desc}");
                }

                documentation.Add(new CommandDocumentation(function.Value, purpose, parameters.ToArray()));
            }

            return documentation.ToArray();
        }
    }
}
