using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CHeaderToXML
{
    class GLParser : Parser
    {
        static readonly char[] splitters = new char[] { ' ', '\t', ',', '(', ')', ';', '\n', '\r' };

        enum ParserModes { None, Enum, Func };
        ParserModes CurrentMode;

        public override IEnumerable<XElement> Parse(string[] lines)
        {
            XElement current = null;

            foreach (string l in lines)
            {
                string line = l.Replace('\t', ' ').Trim();
                if (!IsValid(line))
                    continue;

                string[] words = SplitWords(line);
                if (line.Contains("enum:"))
                {
                    // This is a new enum definition
                    if (current != null)
                        yield return current;
                    
                    current = new XElement("enum",
                        new XAttribute("name", words[0]));
                    
                    CurrentMode = ParserModes.Enum;
                }
                else if (words.First() == "function")
                {
                    if (current != null)
                        yield return current;

                    CurrentMode = ParserModes.Func;
                    throw new NotImplementedException();
                }
                else if (current != null)
                {
                    switch (CurrentMode)
                    {
                        case ParserModes.Enum:
                            if (words[0] == "use")
                            {
                                current.Add(new XElement("use",
                                    new XAttribute("enum", words[1]),
                                    new XAttribute("token", words[2])));
                            }
                            else if (words[1] == "=")
                            {
                                current.Add(new XElement("token",
                                    new XAttribute("name", words[0]),
                                    new XAttribute("value", words[2])));
                            }
                            else
                            {
                                // Typical cause is hand-editing the specs and forgetting to add an '=' sign.
                                throw new InvalidOperationException(String.Format(
                                    "[Error] Invalid constant definition: \"{0}\"", line));
                            }
                            break;

                        case ParserModes.Func:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        string[] SplitWords(string line)
        {
            return line.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        }

        bool IsValid(string line)
        {
            return !(String.IsNullOrEmpty(line) ||
                line.StartsWith("#") ||                 // Disregard comments.
                line.StartsWith("passthru") ||          // Disregard passthru statements.
                line.StartsWith("required-props:") ||
                line.StartsWith("param:") ||
                line.StartsWith("dlflags:") ||
                line.StartsWith("glxflags:") ||
                line.StartsWith("vectorequiv:") ||
                //line.StartsWith("category:") ||
                line.StartsWith("version:") ||
                line.StartsWith("glxsingle:") ||
                line.StartsWith("glxropcode:") ||
                line.StartsWith("glxvendorpriv:") ||
                line.StartsWith("glsflags:") ||
                line.StartsWith("glsopcode:") ||
                line.StartsWith("glsalias:") ||
                line.StartsWith("wglflags:") ||
                line.StartsWith("extension:") ||
                line.StartsWith("alias:") ||
                line.StartsWith("offset:"));
        }
    }
}
