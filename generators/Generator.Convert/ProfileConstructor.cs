using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Generator.Common;
using Generator.Convert.Construction;
using Generator.Convert.XML;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace Generator.Convert
{
    public class ProfileConstructor : IDisposable
    {
        public List<string> InputFiles { get; set; }
        public string OutputFolder { get; set; }
        public string Prefix { get; set; }
        public bool Pretty { get; set; }
        public Dictionary<string, string> TypeMap { get; set; }

        public IEnumerable<Profile> ReadProfiles()
        {
            var parser = new GLXmlParser {Prefix = Prefix};
            var sigs = InputFiles.Select(x => parser.Parse(x)).ToList();

            // Merge any duplicate enum entries (in case an enum is declared
            // in multiple files with different entries in each file).
            var entries = MergeDuplicates(sigs);
            SortTokens(entries);
            return Task.WhenAll(sigs.SelectMany(s => s).Select(ReadProfileAsync)).GetAwaiter().GetResult();
        }

        private Task<Profile> ReadProfileAsync(XElement api)
        {
            var profile = new Profile
            {
                Name = api.Attribute("name")?.Value,
                Version = api.Attribute("version")?.Value ?? string.Empty,
                TypeMap = TypeMap
            };
            var elements = api.Elements()
                .OrderBy(s => s.Name.LocalName)
                .ThenBy(s => (string)s.Attribute("value") ?? string.Empty)
                .ThenBy(s => (string)s.Attribute("name") ?? string.Empty)
                .ThenBy(s => (string)s.Attribute("version") ?? string.Empty)
                .ThenBy(s => (string)s.Attribute("extension") ?? string.Empty)
                .ToList();
            var enums = elements.Where(x => x.Name == "enum");
            var functions = elements.Where(x => x.Name == "function");
            profile.ParseXml(enums, functions);
            return Task.FromResult(profile);
        }

        public void WriteProfiles()
        {
            if (!Directory.Exists(OutputFolder))
            {
                Directory.CreateDirectory(OutputFolder);
            }

            foreach (var profile in ReadProfiles())
            {
                using
                (
                    var outStream = OutputFolder == null
                        ? Console.Out
                        : new StreamWriter
                        (
                            Path.Combine
                            (
                                OutputFolder,
                                "api-" +
                                profile.Name +
                                (!string.IsNullOrEmpty(profile.Version) ? "-" + profile.Version : null) +
                                ".json"
                            )
                        )
                )
                {
                    outStream.Write
                    (
                        JsonConvert.SerializeObject(profile, Pretty ? Formatting.Indented : Formatting.None)
                    );
                    outStream.Flush();
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
                var name = (string)e.Attribute("name") ?? "";
                var version = (string)e.Attribute("version") ?? "";
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

        public void Dispose()
        {
        }
    }
}