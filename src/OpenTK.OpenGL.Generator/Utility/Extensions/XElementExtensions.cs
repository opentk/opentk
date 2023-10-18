using System;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Generator.Utility.Extensions
{
    internal static class XElementExtensions
    {
        // TODO: This is only used in one place.
        // Consider moving it into the place where it's being used.
        internal static string GetXmlText(this XElement element, Func<XElement, string>? elementPredicate = null)
        {
            var sb = new StringBuilder();

            foreach (var node in element.Nodes())
            {
                switch (node)
                {
                    case XText txt:
                        sb.Append(txt.Value);
                        break;
                    case XElement xel:
                        sb.Append(elementPredicate == null ? xel.Value : elementPredicate(xel));
                        break;
                    default:
                        sb.Append(node);
                        break;
                }
            }
            return sb.ToString();
        }

        internal static IEnumerable<XElement> ElementsIgnoreNamespace(this XElement element, string name)
        {
            return element.Descendants().Where(e => e.Name.LocalName == name);
        }
        
        internal static XElement ElementIgnoreNamespace(this XElement element, string name)
        {
            return element.Descendants().Where(e => e.Name.LocalName == name).First();
        }

        internal static XElement? ElementIgnoreNamespace(this XElement element, Predicate<XElement> pred)
        {
            return element.Descendants().Where(e => pred(e)).FirstOrDefault();
        }

        internal static XAttribute? AttributeIgnoreNamespace(this XElement element, string name)
        {
            return element.Attributes().Where(a => a.Name.LocalName == "id").FirstOrDefault();
        }
    }
}
