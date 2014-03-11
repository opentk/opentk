#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CHeaderToXML
{
    class GLParser : Parser
    {
        static readonly Regex extensions = new Regex(
            @"3DFX|(?!(?<=[1-4])D)[A-Z]{2,}$",
            RegexOptions.Compiled);
        static readonly char[] splitters = new char[] { ' ', '\t', ',', '(', ')', ';', '\n', '\r' };

        enum ParserModes { None, Enum, Func };
        ParserModes CurrentMode;

        enum EntryModes { Core, Compatibility };

        public override IEnumerable<XElement> Parse(string[] lines)
        {
            XElement current = null;

            foreach (string l in lines)
            {
                // Clean up line for further processing and skip invalid lines.
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
                else if (line.StartsWith(words[0] + "("))
                {
                    // This is a new function definition
                    if (current != null)
                        yield return current;

                    var match = extensions.Match(words[0]);
                    string extension = match != null && String.IsNullOrEmpty(match.Value) ? "Core" : match.Value;
                    current = new XElement("function",
                        new XAttribute("name", words[0]),
                        new XAttribute("extension", extension));

                    CurrentMode = ParserModes.Func;
                }
                else if (current != null)
                {
                    // This is an addition to the current element (enum or function)
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
                            else if (words[0] == "profile:")
                            {
                            }
                            else if (words[0].Contains("future_use"))
                            {
                                // This is a bug in the 4.3 specs. Unfortunately,
                                // Khronos is no longer accepting bug reports for
                                // the .spec files.
                                continue;
                            }
                            else
                            {
                                // Typical cause is hand-editing the specs and forgetting to add an '=' sign.
                                throw new InvalidOperationException(String.Format(
                                    "[Error] Invalid constant definition: \"{0}\"", line));
                            }
                            break;

                        case ParserModes.Func:
                            switch (words[0])
                            {
                                case "return":  // Line denotes return value
                                    current.Add(new XElement("returns",
                                        new XAttribute("type", words[1])));
                                    break;

                                case "param":   // Line denotes parameter
                                    int pointer = words[4].Contains("array") ? 1 : 0;
                                    pointer += words[4].Contains("reference") ? 1 : 0;

                                    var elem = new XElement("param",
                                        new XAttribute("name", words[1]),
                                        new XAttribute("type", words[2] + PointerLevel(pointer)),
                                        new XAttribute("flow", words[3] == "in" ? "in" : "out"));
                                    if (pointer > 0 && words.Length > 5 && words[5].Contains("[1]"))
                                        elem.Add(new XAttribute("count", 1));

                                    current.Add(elem);
                                    break;

                                case "version": // Line denotes function version (i.e. 1.0, 1.2, 1.5)
                                    // GetTexParameterIivEXT and GetTexParameterIuivEXT define two(!) versions (why?)
                                    var version = current.Attribute("version");
                                    if (version == null)
                                        current.Add(new XAttribute("version", words[1]));
                                    else
                                        version.Value = words[1];
                                    break;

                                case "category":
                                    current.Add(new XAttribute("category", words[1]));
                                    break;

                                case "deprecated":
                                    current.Add(new XAttribute("deprecated", words[1]));
                                    break;
                            }
                            break;
                    }
                }
            }

            if (current != null)
            {
                yield return current;
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

        string PointerLevel(int pointer)
        {
            switch (pointer)
            {
                case 0: return String.Empty;
                case 1: return "*";
                case 2: return "**";
                case 3: return "***";
                case 4: return "****";
                case 5: return "*****";
                default: throw new NotImplementedException();
            }
        }
    }
}
