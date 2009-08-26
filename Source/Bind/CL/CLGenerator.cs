using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.XPath;
using Bind.GL2;
using Bind.Structures;
using Delegate=Bind.Structures.Delegate;
using Enum=Bind.Structures.Enum;

namespace Bind.CL
{
    class CLGenerator : Generator
    {
        public CLGenerator(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            glTypemap = null;
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
            Settings.ConstantPrefix = "CL_";
            Settings.EnumPrefix = "Cl";

            Settings.OutputClass = "CL";
            Settings.OutputNamespace = "OpenTK.Compute." + name;
            Settings.OutputPath = Path.Combine("../../../Source/OpenTK/Compute", name);

            //Settings.Compatibility &= ~Settings.Legacy.TurnVoidPointersToIntPtr;
            Settings.Compatibility |= Settings.Legacy.NoDebugHelpers;
        }

        public override DelegateCollection ReadDelegates(StreamReader specFile)
        {
            DelegateCollection delegates = new DelegateCollection();

            XPathDocument overrides = new XPathDocument(new StreamReader(Path.Combine(Settings.InputPath, functionOverridesFile)));
            
            XPathNavigator nav = new XPathDocument(specFile).CreateNavigator().SelectSingleNode("/signatures");

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
            XPathDocument overrides = new XPathDocument(new StreamReader(Path.Combine(Settings.InputPath, functionOverridesFile)));

            EnumCollection enums = new EnumCollection();
            Enum all = new Enum(Settings.CompleteEnumName); 
            XPathDocument doc = new XPathDocument(specFile);
            XPathNavigator nav = doc.CreateNavigator().SelectSingleNode("/signatures");
            
            foreach (XPathNavigator node in nav.SelectChildren("enum", String.Empty))
            {
                Enum e = new Enum(node.GetAttribute("name", String.Empty));
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
            enums.Translate(overrides);
            return enums;
        }
    }
}
