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
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.XPath;
using Bind.Structures;

namespace Bind
{
    using Delegate = Bind.Structures.Delegate;
    using Enum = Bind.Structures.Enum;

    class XmlSpecReader : ISpecReader
    {
        #region ISpecReader Members

        public void ReadDelegates(string file, DelegateCollection delegates)
        {
            var specs = new XPathDocument(file);
            foreach (XPathNavigator nav in specs.CreateNavigator().Select("/signatures/delete"))
            {
                foreach (XPathNavigator node in nav.SelectChildren("function", String.Empty))
                    delegates.Remove(node.GetAttribute("name", String.Empty));
            }
            foreach (XPathNavigator nav in specs.CreateNavigator().Select("/signatures/add"))
            {
                Utilities.Merge(delegates, ReadDelegates(nav));
            }
        }

        private DelegateCollection ReadDelegates(XPathNavigator specs)
        {
            DelegateCollection delegates = new DelegateCollection();

            foreach (XPathNavigator node in specs.SelectChildren("function", String.Empty))
            {
                var name = node.GetAttribute("name", String.Empty);

                // Check whether we are adding to an existing delegate or creating a new one.
                Delegate d = null;
                if (delegates.ContainsKey(name))
                {
                    d = delegates[name];
                }
                else
                {
                    d = new Delegate();
                    d.Name = name;
                    d.Version = node.GetAttribute("version", String.Empty);
                    d.Category = node.GetAttribute("category", String.Empty);
                    d.DeprecatedVersion = node.GetAttribute("deprecated", String.Empty);
                    d.Deprecated = !String.IsNullOrEmpty(d.DeprecatedVersion);
                }

                foreach (XPathNavigator param in node.SelectChildren(XPathNodeType.Element))
                {
                    switch (param.Name)
                    {
                        case "returns":
                            d.ReturnType.CurrentType = param.GetAttribute("type", String.Empty);
                            break;

                        case "param":
                            Parameter p = new Parameter();
                            p.CurrentType = param.GetAttribute("type", String.Empty);
                            p.Name = param.GetAttribute("name", String.Empty);

                            string element_count = param.GetAttribute("elementcount", String.Empty);
                            if (String.IsNullOrEmpty(element_count))
                                element_count = param.GetAttribute("count", String.Empty);
                            if (!String.IsNullOrEmpty(element_count))
                                p.ElementCount = Int32.Parse(element_count);

                            p.Flow = Parameter.GetFlowDirection(param.GetAttribute("flow", String.Empty));

                            d.Parameters.Add(p);
                            break;
                    }
                }

                delegates.Add(d);
            }

            return delegates;
        }

        public void ReadEnums(string file, EnumCollection enums)
        {
            // First, read all enum definitions from spec and override file.
            // Afterwards, read all token/enum overrides from overrides file.
            // Every single enum is merged into

            var specs = new XPathDocument(file);
            foreach (XPathNavigator nav in specs.CreateNavigator().Select("/signatures/delete"))
            {
                foreach (XPathNavigator node in nav.SelectChildren("enum", String.Empty))
                    enums.Remove(node.GetAttribute("name", String.Empty));
            }
            foreach (XPathNavigator nav in specs.CreateNavigator().Select("/signatures/add"))
            {
                Utilities.Merge(enums, ReadEnums(nav));
            }
        }

        private EnumCollection ReadEnums(XPathNavigator nav)
        {
            EnumCollection enums = new EnumCollection();
            Enum all = new Enum() { Name = Settings.CompleteEnumName };

            if (nav != null)
            {
                foreach (XPathNavigator node in nav.SelectChildren("enum", String.Empty))
                {
                    Enum e = new Enum()
                    {
                        Name = node.GetAttribute("name", String.Empty),
                        Type = node.GetAttribute("type", String.Empty)
                    };
                    if (String.IsNullOrEmpty(e.Name))
                        throw new InvalidOperationException(String.Format("Empty name for enum element {0}", node.ToString()));

                    foreach (XPathNavigator param in node.SelectChildren(XPathNodeType.Element))
                    {
                        Constant c = null;
                        switch (param.Name)
                        {
                            case "token":
                                c = new Constant
                                {
                                    Name = param.GetAttribute("name", String.Empty),
                                    Value = param.GetAttribute("value", String.Empty)
                                };
                                break;

                            case "use":
                                c = new Constant
                                {
                                    Name = param.GetAttribute("token", String.Empty),
                                    Reference = param.GetAttribute("enum", String.Empty),
                                    Value = param.GetAttribute("token", String.Empty),
                                };
                                break;

                            default:
                                throw new NotSupportedException();
                        }
                        Utilities.Merge(all, c);
                        try
                        {
                            if (!e.ConstantCollection.ContainsKey(c.Name))
                            {
                                e.ConstantCollection.Add(c.Name, c);
                            }
                            else if (e.ConstantCollection[c.Name].Value != c.Value)
                            {
                                var existing = e.ConstantCollection[c.Name];
                                if (existing.Reference != null && c.Reference == null)
                                {
                                    e.ConstantCollection[c.Name] = c;
                                }
                                else if (existing.Reference == null && c.Reference != null)
                                { } // Keep existing
                                else
                                {
                                    Console.WriteLine("[Warning] Conflicting token {0}.{1} with value {2} != {3}",
                                        e.Name, c.Name, e.ConstantCollection[c.Name].Value, c.Value);
                                }
                            }
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("[Warning] Failed to add constant {0} to enum {1}: {2}", c.Name, e.Name, ex.Message);
                        }
                    }

                    Utilities.Merge(enums, e);
                }
            }

            Utilities.Merge(enums, all);
            return enums;
        }

        public Dictionary<string, string> ReadTypeMap(string file)
        {
            using (var sr = new StreamReader(file))
            {
                Console.WriteLine("Reading opengl types.");
                Dictionary<string, string> GLTypes = new Dictionary<string, string>();

                if (sr == null)
                    return GLTypes;

                do
                {
                    string line = sr.ReadLine();

                    if (String.IsNullOrEmpty(line) || line.StartsWith("#"))
                        continue;

                    string[] words = line.Split(" ,*\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    if (words[0].ToLower() == "void")
                    {
                        // Special case for "void" -> "". We make it "void" -> "void"
                        GLTypes.Add(words[0], "void");
                    }
                    else if (words[0] == "VoidPointer" || words[0] == "ConstVoidPointer")
                    {
                        // "(Const)VoidPointer" -> "void*"
                        GLTypes.Add(words[0], "void*");
                    }
                    else if (words[0] == "CharPointer" || words[0] == "charPointerARB")
                    {
                        // The typematching logic cannot handle pointers to pointers, e.g. CharPointer* -> char** -> string* -> string[].
                        // Hence we give it a push.
                        // Note: When both CurrentType == "String" and Pointer == true, the typematching is hardcoded to use
                        // String[] or StringBuilder[].
                        GLTypes.Add(words[0], "String");
                    }
                    /*else if (words[0].Contains("Pointer"))
                    {
                        GLTypes.Add(words[0], words[1].Replace("Pointer", "*"));
                    }*/
                    else if (words[1].Contains("GLvoid"))
                    {
                        GLTypes.Add(words[0], "void");
                    }
                    else if (words[1] == "const" && words[2] == "GLubyte")
                    {
                        GLTypes.Add(words[0], "String");
                    }
                    else if (words[1] == "struct")
                    {
                        GLTypes.Add(words[0], words[2]);
                    }
                    else
                    {
                        GLTypes.Add(words[0], words[1]);
                    }
                }
                while (!sr.EndOfStream);

                return GLTypes;
            }
        }

        public Dictionary<string, string> ReadCSTypeMap(string file)
        {
            using (var sr = new StreamReader(file))
            {
                Dictionary<string, string> CSTypes = new Dictionary<string, string>();
                Console.WriteLine("Reading C# types.");

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (String.IsNullOrEmpty(line) || line.StartsWith("#"))
                        continue;

                    string[] words = line.Split(" ,\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length < 2)
                        continue;

                    if (((Settings.Compatibility & Settings.Legacy.NoBoolParameters) != Settings.Legacy.None) && words[1] == "bool")
                        words[1] = "Int32";

                    CSTypes.Add(words[0], words[1]);
                }

                return CSTypes;
            }
        }

        #endregion
    }
}
