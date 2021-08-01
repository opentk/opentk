using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static Generator.Reader;

namespace Generator.Parsing
{
    class TestResolver : XmlResolver
    {
        public override object? GetEntity(Uri absoluteUri, string? role, Type? ofObjectToReturn)
        {
            return null;
        }
    }

    static class DocumentationParser
    {
        public static Documentation Parse(DocumentationSource source)
        {
            Dictionary<string, VersionDocumentation> versionDocumentation = new Dictionary<string, VersionDocumentation>();

            foreach (var folder in source.Folders)
            {
                Dictionary<string, CommandDocumentation> docFolder = new Dictionary<string, CommandDocumentation>();

                Console.WriteLine($"Documentation {folder.Folder}:");
                Console.WriteLine();

                foreach (var file in folder.Files)
                {
                    XmlReaderSettings settings = new XmlReaderSettings { NameTable = new NameTable() };
                    settings.DtdProcessing = DtdProcessing.Ignore;
                    settings.ValidationType = ValidationType.None;
                    XmlNamespaceManager xmlns = new XmlNamespaceManager(settings.NameTable);
                    xmlns.AddNamespace("mml", "");
                    XmlParserContext context = new XmlParserContext(null, xmlns, "", XmlSpace.Default);
                    XmlReader reader = XmlReader.Create(file, settings, context);
                    // https://stackoverflow.com/questions/3504227/prevent-xmltextreader-from-expanding-entities
                    PropertyInfo propertyInfo = reader.GetType().GetProperty("DisableUndeclaredEntityCheck", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    propertyInfo.SetValue(reader, true);
                    XDocument xml = XDocument.Load(reader);
                    CommandDocumentation[] documentation = ParseFile(xml.Root!);

                    foreach (var commandDoc in documentation)
                    {
                        docFolder.Add(commandDoc.Name, commandDoc);
                    }
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                versionDocumentation.Add(folder.Folder, new VersionDocumentation(docFolder));
            }
            return new Documentation(versionDocumentation);
        }


        private static CommandDocumentation[] ParseFile(XElement root)
        {
            var otherNamespace = "http://www.w3.org/XML/1998/namespace";
            var ns = root.Name.Namespace.NamespaceName;
            if (string.IsNullOrEmpty(ns))
            {
                otherNamespace = "";
            }

            List<ParameterDocumentation> parameters = new List<ParameterDocumentation>();

            XElement? refparameters = root.Elements(XName.Get("refsect1", ns)).FirstOrDefault(e => e.Attribute(XName.Get("id", otherNamespace))?.Value == "parameters");
            if (refparameters != null)
            {
                XElement? variableList = refparameters.Element(XName.Get("variablelist", ns));
                foreach (var entry in variableList.Elements(XName.Get("varlistentry", ns)))
                {
                    string parameter = entry.Element(XName.Get("term", ns)).Element(XName.Get("parameter", ns)).Value;
                    // FIXME: Remove tab indentation.
                    string desc = entry.Element(XName.Get("listitem", ns)).Element(XName.Get("para", ns)).Value;

                    parameters.Add(new ParameterDocumentation(parameter, desc));
                    Console.WriteLine($"  {parameter}: {desc}");
                }
            }

            List<CommandDocumentation> documentation = new List<CommandDocumentation>();
            XElement? namediv = root.Element(XName.Get("refnamediv", ns));
            string purpose = namediv.Element(XName.Get("refpurpose", ns)).Value;
            foreach (XElement name in namediv.Elements(XName.Get("refname", ns)))
            {
                documentation.Add(new CommandDocumentation(name.Value, purpose, parameters.ToArray()));

                Console.WriteLine($"{name.Value}");
            }

            return documentation.ToArray();
        }
    }
}
