using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.XPath;
using Bind.GL2;
using Bind.Structures;
using Delegate=Bind.Structures.Delegate;
using Enum=Bind.Structures.Enum;

namespace Bind.ES
{
    class ESGenerator : Generator
    {
        public ESGenerator(string nsName, string dirName)
        {
            if (String.IsNullOrEmpty(nsName))
                throw new ArgumentNullException("nsName");
            if (dirName == null)
                dirName = nsName;

            glTypemap = "GL2/gl.tm";
            csTypemap = "csharp.tm";

            enumSpec = dirName + "/signatures.xml";
            enumSpecExt = String.Empty;
            glSpec = dirName  + "/signatures.xml";
            glSpecExt = String.Empty;
            functionOverridesFile = dirName + "/overrides.xml";

            importsFile = "Core.cs";
            delegatesFile = "Delegates.cs";
            enumsFile = "Enums.cs";
            wrappersFile = "ES.cs";
            Settings.ImportsClass = "Core";
            Settings.DelegatesClass = "Delegates";

            Settings.OutputClass = "GL";
            Settings.OutputNamespace = "OpenTK.Graphics." + nsName;
            Settings.OutputPath = Path.Combine(Settings.OutputPath, dirName);
        }

        public override DelegateCollection ReadDelegates(StreamReader specFile)
        {
            DelegateCollection delegates = new DelegateCollection();
            XPathDocument specs = new XPathDocument(specFile);
            XPathDocument overrides = new XPathDocument(new StreamReader(Path.Combine(Settings.InputPath, functionOverridesFile)));

            foreach (XPathNavigator nav in new XPathNavigator[] {
                specs.CreateNavigator().SelectSingleNode("/signatures"),
                overrides.CreateNavigator().SelectSingleNode("/overrides/add") })
            {
                if (nav != null)
                {
                    foreach (XPathNavigator node in nav.SelectChildren("function", String.Empty))
                    {
                        Delegate d = new Delegate();
                        d.Name = node.GetAttribute("name", String.Empty);
                        //d.Extension = node.GetAttribute("extension");
                        d.Version = node.GetAttribute("version", String.Empty);
                        d.Category = node.GetAttribute("category", String.Empty);
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
                                    if (!String.IsNullOrEmpty(element_count))
                                        p.ElementCount = Int32.Parse(element_count);

                                    p.Flow = Parameter.GetFlowDirection(param.GetAttribute("flow", String.Empty));

                                    d.Parameters.Add(p);
                                    break;
                            }
                        }
                        d.Translate(overrides);
                        delegates.Add(d);
                    }
                }
            }

            return delegates;
        }

        public override Dictionary<string, string> ReadTypeMap(StreamReader specFile)
        {
            return base.ReadTypeMap(specFile);
        }

        public override Dictionary<string, string> ReadCSTypeMap(StreamReader specFile)
        {
            return base.ReadCSTypeMap(specFile);
        }

        public override EnumCollection ReadEnums(StreamReader specFile)
        {
            // First, read all enum definitions from spec and override file.
            // Afterwards, read all token/enum overrides from overrides file.
            // Every single enum is merged into

            EnumCollection enums = new EnumCollection();
            Enum all = new Enum() { Name = Settings.CompleteEnumName }; 
            XPathDocument specs = new XPathDocument(specFile);
            XPathDocument overrides = new XPathDocument(new StreamReader(Path.Combine(Settings.InputPath, functionOverridesFile)));

            foreach (XPathNavigator nav in new XPathNavigator[] {
                specs.CreateNavigator().SelectSingleNode("/signatures"),
                overrides.CreateNavigator().SelectSingleNode("/overrides/add") })
            {
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
                            Constant c = new Constant(param.GetAttribute("name", String.Empty), param.GetAttribute("value", String.Empty));
                            Utilities.Merge(all, c);
                            try { e.ConstantCollection.Add(c.Name, c); }
                            catch (ArgumentException ex) { Console.WriteLine("[Warning] Failed to add constant {0} to enum {1}: {2}", c.Name, e.Name, ex.Message); }
                        }

                        Utilities.Merge(enums, e);
                    }
                }
            }

            Utilities.Merge(enums, all);
            enums.Translate(overrides);
            return enums;
        }
    }
}
