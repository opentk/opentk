using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using Bind.Structures;

namespace Bind.CL
{
    class CLGenerator : Bind.GL2.Generator
    {
        public CLGenerator(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            glTypemap = "GL2/gl.tm";
            csTypemap = "csharp.tm";
            
            enumSpec = name + "/signatures.xml";
            enumSpecExt = String.Empty;
            glSpec = name + "/signatures.xml";
            glSpecExt = String.Empty;
            functionOverridesFile = name + "/overrides.xml";

            importsFile = "Core.cs";
            delegatesFile = "Delegates.cs";
            enumsFile = "Enums.cs";
            wrappersFile = "CL.cs";
            Settings.ImportsClass = "Core";
            Settings.DelegatesClass = "Delegates";

            Settings.FunctionPrefix = "cl";

            Settings.OutputClass = "CL";
            Settings.OutputNamespace = "OpenTK.Compute." + name;
            Settings.OutputPath = Path.Combine("../../Source/OpenTK/Compute", name);
        }

        public override Bind.Structures.DelegateCollection ReadDelegates(System.IO.StreamReader specFile)
        {
            DelegateCollection delegates = new DelegateCollection();

            XPathDocument overrides = new XPathDocument(new StreamReader(Path.Combine(Settings.InputPath, functionOverridesFile)));
            
            XPathNavigator nav = new XPathDocument(specFile).CreateNavigator().SelectSingleNode("/signatures");

            foreach (XPathNavigator node in nav.SelectChildren("function", String.Empty))
            {
                Bind.Structures.Delegate d = new Bind.Structures.Delegate();
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

        public override Bind.Structures.EnumCollection ReadEnums(StreamReader specFile)
        {
            EnumCollection enums = new EnumCollection();
            Bind.Structures.Enum all = new Bind.Structures.Enum(Settings.CompleteEnumName); 
            XPathDocument doc = new XPathDocument(specFile);
            XPathNavigator nav = doc.CreateNavigator().SelectSingleNode("/signatures");
            
            foreach (XPathNavigator node in nav.SelectChildren("enum", String.Empty))
            {
                Bind.Structures.Enum e = new Bind.Structures.Enum(node.GetAttribute("name", String.Empty));
                if (String.IsNullOrEmpty(e.Name))
                    throw new InvalidOperationException(String.Format("Empty name for enum element {0}", node.ToString()));

                foreach (XPathNavigator param in node.SelectChildren(XPathNodeType.Element))
                {
                    Constant c = new Constant(param.GetAttribute("name", String.Empty), param.GetAttribute("value", String.Empty));
                    Utilities.Merge(all, c);
                    e.ConstantCollection.Add(c.Name, c);
                }

                Utilities.Merge(enums, e);
            }

            Utilities.Merge(enums, all);
            enums.Translate();
            return enums;
        }
    }
}
