
using System;
using System.Text;
using System.Xml.Linq;


namespace GeneratorV2
{
    public static class XElementExtensions
    {
        public static string GetXmlText(this XElement element, Func<XElement, string>? elementPredicate = null)
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
    }
}
