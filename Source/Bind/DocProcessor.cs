using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Xsl;

namespace Bind
{
    class DocProcessor
    {
        static readonly Regex remove_mathml = new Regex(@"<(mml:math)[^>]*?>(?:.|\n)*?</\s*\1\s*>",
            RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);

        static readonly XslCompiledTransform xslt = new XslCompiledTransform();
        static readonly XmlReaderSettings settings = new XmlReaderSettings();

        public DocProcessor(string transform_file)
        {
            xslt.Load(transform_file);
            settings.ProhibitDtd = false;
            settings.XmlResolver = null;
        }

        // Strips MathML tags from the source and replaces the equations with the content
        // found in the <!-- eqn: :--> comments in the docs.
        // Todo: Some simple MathML tags do not include comments, find a solution.
        // Todo: Some files include more than 1 function - find a way to map these extra functions.
        public string ProcessFile(string file)
        {
            string text = File.ReadAllText(file);

            Match m = remove_mathml.Match(text);
            while (m.Length > 0)
            {
                string removed = text.Substring(m.Index, m.Length);
                text = text.Remove(m.Index, m.Length);
                int equation = removed.IndexOf("eqn");
                if (equation > 0)
                {
                    text = text.Insert(m.Index,
                        "<![CDATA[" +
                        removed.Substring(equation + 4, removed.IndexOf(":-->") - equation - 4) +
                        "]]>");
                }
                m = remove_mathml.Match(text);
            }

            XmlReader doc = null;
            try
            {
                // The pure XmlReader is ~20x faster than the XmlTextReader.
                doc = XmlReader.Create(new StringReader(text), settings);
                //doc = new XmlTextReader(new StringReader(text));
                
                using (StringWriter sw = new StringWriter())
                {
                    xslt.Transform(doc, null, sw);
                    return sw.ToString().TrimEnd('\n');
                }
            }
            catch (XmlException e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(doc.ToString());
                return String.Empty;
            }
        }
    }
}
