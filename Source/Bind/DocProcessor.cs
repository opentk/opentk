using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;

using Bind.Structures;

namespace Bind
{
    class DocProcessor
    {
        static readonly Regex remove_mathml = new Regex(
            @"<(mml:math|inlineequation)[^>]*?>(?:.|\n)*?</\s*\1\s*>",
            RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);

        static readonly XslCompiledTransform xslt = new XslCompiledTransform();
        static readonly XmlReaderSettings settings = new XmlReaderSettings();

        Documentation Cached;
        string LastFile;

        public DocProcessor(string transform_file)
        {
            if (!File.Exists(transform_file))
            {
                // If no specific transform file exists
                // get the generic transform file from
                // the parent directory
                var dir = Directory.GetParent(Path.GetDirectoryName(transform_file)).FullName;
                var file = Path.GetFileName(transform_file);
                transform_file = Path.Combine(dir, file);
            }
            xslt.Load(transform_file);
            settings.ProhibitDtd = false;
            settings.XmlResolver = null;
        }

        // Strips MathML tags from the source and replaces the equations with the content
        // found in the <!-- eqn: :--> comments in the docs.
        // Todo: Some simple MathML tags do not include comments, find a solution.
        // Todo: Some files include more than 1 function - find a way to map these extra functions.
        public Documentation ProcessFile(string file)
        {
            string text;

            if (LastFile == file)
                return Cached;

            LastFile = file;
            text = File.ReadAllText(file);

            text = text
                .Replace("xml:", String.Empty) // Remove namespaces
                .Replace("&epsi;", "epsilon") // Fix unrecognized &epsi; entities
                .Replace("<constant>", "<c>") // Improve output
                .Replace("</constant>", "</c>");

            Match m = remove_mathml.Match(text);
            while (m.Length > 0)
            {
                string removed = text.Substring(m.Index, m.Length);
                text = text.Remove(m.Index, m.Length);
                int equation = removed.IndexOf("eqn");
                if (equation > 0)
                {
                    // Find the start and end of the equation string
                    int eqn_start = equation + 4;
                    int eqn_end = removed.IndexOf(":-->") - equation - 4;
                    if (eqn_end < 0)
                    {
                        // Note: a few docs from man4 delimit eqn end with ": -->"
                        eqn_end = removed.IndexOf(": -->") - equation - 4;
                    }
                    if (eqn_end < 0)
                    {
                        Console.WriteLine("[Warning] Failed to find equation for mml.");
                        goto next;
                    }

                    string eqn_substring = removed.Substring(eqn_start, eqn_end);
                    text = text.Insert(m.Index, "<![CDATA[" + eqn_substring + "]]>");
                }

            next:
                m = remove_mathml.Match(text);
            }

            //XmlReader doc = null;
            XDocument doc = null;
            try
            {
                // The pure XmlReader is ~20x faster than the XmlTextReader.
                //doc = XmlReader.Create(new StringReader(text), settings);
                doc = XDocument.Parse(text);
                Cached = ToInlineDocs(doc);
                return Cached;
            }
            catch (XmlException e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(doc.ToString());
                return null;
            }
        }

        Documentation ToInlineDocs(XDocument doc)
        {
            var inline = new Documentation
            {
                Summary =
                    ((IEnumerable)doc.XPathEvaluate("//*[name()='refentry']/*[name()='refnamediv']/*[name()='refpurpose']"))
                    .Cast<XElement>().First().Value.Trim(),
                Parameters =
                    ((IEnumerable)doc.XPathEvaluate("*[name()='refentry']/*[name()='refsect1'][@id='parameters']/*[name()='variablelist']/*[name()='varlistentry']"))
                    .Cast<XNode>()
                    .Select(p => new KeyValuePair<string, string>(
                            p.XPathSelectElement("*[name()='term']/*[name()='parameter']").Value.Trim(),
                            p.XPathSelectElement("*[name()='listitem']").Value.Trim()))
                    .ToList()
            };

            inline.Summary = Char.ToUpper(inline.Summary[0]) + inline.Summary.Substring(1);
            return inline;
        }
    }
}
