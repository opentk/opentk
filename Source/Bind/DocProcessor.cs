using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;

namespace Bind
{
    class DocProcessor
    {
        static readonly Regex remove_doctype = new Regex("<!DOCTYPE.*/>", RegexOptions.Compiled | RegexOptions.Multiline);
        static readonly Regex remove_mathml = new Regex(@"<(mml:math)[^>]*?>(?:.|\n)*?</\s*\1\s*>",
            RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
        static readonly StreamWriter output_stream = new StreamWriter(new MemoryStream());

        static readonly XslCompiledTransform xslt = new System.Xml.Xsl.XslCompiledTransform();
        static readonly XmlReaderSettings settings = new XmlReaderSettings();

        public DocProcessor(string transform_file)
        {
            xslt.Load(transform_file);
            settings.ProhibitDtd = false;
            settings.XmlResolver = null;
        }

        public string ProcessFile(string file)
        {
            string text = File.ReadAllText(file);

            Match m = remove_mathml.Match(text);
            while (m.Length > 0)
            {
                text = text.Remove(m.Index, m.Length);
                m = remove_mathml.Match(text);
            }
            //text = remove_doctype.Replace(sb.ToString(), String.Empty, 1), String.Empty);

            // The pure XmlReader is ~20x faster than the XmlTextReader.
            var doc = XmlReader.Create(new StringReader(text), settings);
            //var doc = new XmlTextReader(new StringReader(text));

            using (StringWriter sw = new StringWriter())
            {
                xslt.Transform(doc, null, sw);
                return sw.ToString();
            }
        }
    }
}
