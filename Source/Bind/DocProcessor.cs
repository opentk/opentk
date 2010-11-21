using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Xsl;

namespace Bind
{
    class DocProcessor
    {
        static readonly Regex remove_mathml = new Regex(
            @"<(mml:math|inlineequation)[^>]*?>(?:.|\n)*?</\s*\1\s*>",
            RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);

        static readonly XslCompiledTransform xslt = new XslCompiledTransform();
        static readonly XmlReaderSettings settings = new XmlReaderSettings();

        string Text;
        string LastFile;

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
            if (LastFile == file)
                return Text;

            LastFile = file;
            Text = File.ReadAllText(file);

            Match m = remove_mathml.Match(Text);
            while (m.Length > 0)
            {
                string removed = Text.Substring(m.Index, m.Length);
                Text = Text.Remove(m.Index, m.Length);
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
                    Text = Text.Insert(m.Index, "<![CDATA[" + eqn_substring + "]]>");
                }

            next:
                m = remove_mathml.Match(Text);
            }

            XmlReader doc = null;
            try
            {
                // The pure XmlReader is ~20x faster than the XmlTextReader.
                doc = XmlReader.Create(new StringReader(Text), settings);
                //doc = new XmlTextReader(new StringReader(text));
                
                using (StringWriter sw = new StringWriter())
                {
                    xslt.Transform(doc, null, sw);
                    Text = sw.ToString().TrimEnd('\n');
                    return Text;
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
