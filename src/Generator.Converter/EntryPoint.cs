//
// Copyright (C) 2009 the Open Toolkit (http://www.opentk.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

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
    /// The main class containing the EntryPoint of the Generator.Converter Application.
    /// </summary>
    internal class EntryPoint
    {
        private static Options cliOptions;

        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(result => cliOptions = result)
                .WithNotParsed(error => Environment.Exit(-1));

            try
            {
                XmlParser xmlParser = new GLXmlParser { Prefix = cliOptions.Prefix };

                var sigs = cliOptions.InputFiles.Select(h => xmlParser.Parse((string)h)).ToList();

                // Merge any duplicate enum entries (in case an enum is declared
                // in multiple files with different entries in each file).
                var entries = MergeDuplicates(sigs);
                SortTokens(entries);

                var settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.Encoding = Encoding.UTF8;

                TextWriter out_stream = null;
                if (cliOptions.OutputFile == null)
                {
                    out_stream = Console.Out;
                    Console.OutputEncoding = Encoding.UTF8;
                }
                else
                {
                    out_stream = new StreamWriter(cliOptions.OutputFile, false);
                }

                using (var writer = XmlWriter.Create(out_stream, settings))
                {
                    var output = new XElement("signatures", new XAttribute("version", "2"));
                    foreach (var api in sigs.SelectMany(s => s))
                    {
                        output.Add(
                            new XElement(
                                    "add",
                                    new XAttribute(
                                        "name",
                                        api.Attribute("name").Value),
                                    api.Attribute("version") != null ? new XAttribute("version", api.Attribute("version").Value) : null,
                                    api.Elements()
                                    .OrderBy(s => s.Name.LocalName)
                                    .ThenBy(s => (string)s.Attribute("value") ?? string.Empty)
                                    .ThenBy(s => (string)s.Attribute("name") ?? string.Empty)
                                    .ThenBy(s => (string)s.Attribute("version") ?? string.Empty)
                                    .ThenBy(s => (string)s.Attribute("extension") ?? string.Empty)
                            ));
                    }

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
