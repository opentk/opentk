using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CHeaderToXML
{
    class GLXmlParser : Parser
    {
        public GLXmlParser()
        {

        }

        public override IEnumerable<XElement> Parse(string[] lines)
        {
            var input = XDocument.Parse(String.Join(" ", lines));

            // Enumerations
            var groups = input.Root
                .Elements("groups")
                .Elements("group");
            foreach (var group in groups)
            {
                var e = new XElement("enum");
                e.Name = group.Attribute("name").Value;
                foreach (var token in group.Elements("enum"))
                {
                    if (token.Attribute("value") != null)
                    {
                        e.Add(new XElement("token",
                            new XAttribute("name", token.Attribute("name")),
                            new XAttribute("value", token.Attribute("value"))));
                    }
                    else
                    {
                        e.Add(new XElement("use",
                            new XAttribute("token", token.Attribute("name"))));
                    }
                }

                yield return e;
            }
        }
    }
}

