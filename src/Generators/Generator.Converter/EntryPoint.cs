using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using CommandLine;

namespace OpenTK.Convert
{
    /// <summary>
    /// The main entry point for the bindings converter.
    /// </summary>
    internal class EntryPoint
    {
        private static Options CLIOptions;

        /// <summary>
        /// The main entry point for the bindings converter.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(result => CLIOptions = result)
                .WithNotParsed(error => Environment.Exit(-1));

            try
            {
                XmlParser xmlParser = new GLXmlParser { Prefix = CLIOptions.Prefix };

                var sigs = CLIOptions.InputFiles.Select(h => xmlParser.Parse((string)h)).ToList();

                // Merge any duplicate enum entries (in case an enum is declared
                // in multiple files with different entries in each file).
                var entries = MergeDuplicates(sigs);
                SortTokens(entries);

                var settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.Encoding = Encoding.UTF8;

                TextWriter out_stream = null;
                if (CLIOptions.OutputFile == null)
                {
                    out_stream = Console.Out;
                    Console.OutputEncoding = Encoding.UTF8;
                }
                else
                {
                    out_stream = new StreamWriter(CLIOptions.OutputFile, false);
                }

                using (var writer = XmlWriter.Create(out_stream, settings))
                {
                    var output = new XElement
                    (
                        "signatures",
                        new XAttribute("version", "2")
                        // XmlException: The ':' character, hexadecimal value 0x3A, cannot be included in a name.
                        //new XAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance"),
                        //new XAttribute("xsi:noNamespaceSchemaLocation", "../signatures.xsd")
                    );

                    foreach (var api in sigs.SelectMany(s => s))
                    {
#pragma warning disable SA1118
                        output.Add
                        (
                            new XElement
                            (
                                "add",
                                new XAttribute("name", api.Attribute("name").Value),
                                api.Attribute("version") != null
                                    ? new XAttribute("version", api.Attribute("version").Value)
                                    : null,
                                api.Elements()
                                    .OrderBy(s => s.Name.LocalName)
                                    .ThenBy(s => (string)s.Attribute("value") ?? string.Empty)
                                    .ThenBy(s => (string)s.Attribute("name") ?? string.Empty)
                                    .ThenBy(s => (string)s.Attribute("version") ?? string.Empty)
                                    .ThenBy(s => (string)s.Attribute("extension") ?? string.Empty)
                            ));
                    }
#pragma warning restore SA1118

                    output.WriteTo(writer);
                    writer.Flush();
                    writer.Close();
                }

                out_stream.Dispose();
            }
            finally
            {
                Console.WriteLine();
                if (Debugger.IsAttached)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                }
            }
        }

        private static void SortTokens(Dictionary<string, XElement> entries)
        {
            foreach (var e in entries)
            {
                if (e.Value.Name.LocalName != "enum")
                {
                    continue;
                }

                var tokens = e.Value.Elements()
                    .OrderBy(t => (string)t.Attribute("name"))
                    .ToList();
                e.Value.RemoveNodes();
                e.Value.Add(tokens);
            }
        }

        private static Dictionary<string, XElement> MergeDuplicates(IEnumerable<IEnumerable<XElement>> sigs)
        {
            var entries = new Dictionary<string, XElement>();
            foreach (var e in sigs.SelectMany(s => s))
            {
                var name = (string)e.Attribute("name") ?? string.Empty;
                var version = (string)e.Attribute("version") ?? string.Empty;
                var key = name + version;
                if (entries.ContainsKey(key))
                {
                    var p = entries[key];
                    var curTokens = p.Nodes().ToList();
                    p.RemoveNodes();
                    p.Add(curTokens.Concat(e.Nodes()).Distinct(new EnumTokenComparer()));
                }
                else
                {
                    entries.Add(key, e);
                }
            }

            return entries;
        }
    }
}
