using System;
using System.Xml;

namespace OpenToolkit.Generator
{
    public static class Parser
    {
        public static Class Parse(string spec)
        {
            Logger.Info("Parsing spec into xml document.");

            var doc = new XmlDocument();
            doc.LoadXml(spec);
            var reg = doc.LastChild;

            Logger.Info("Parsing commands.");
            var commands = reg.SelectSingleNode("commands").ChildNodes;
            Method[] methods = new Method[commands.Count];
            for (int i = 0; i < commands.Count; i++)
            {
                methods[i] = ParseCommand(commands[i]);
            }

            return new Class("OpenToolkit.Graphics", "GL", methods);
        }

        public static Method ParseCommand(XmlNode command)
        {
            var proto = command.FirstChild;
            var strType = proto.InnerText.Remove(proto.InnerText.IndexOf(' '));
            var name = proto.LastChild.InnerText.Substring(2);

            var parameterNodes = command.SelectNodes("param");
            var parameters = new Parameter[parameterNodes.Count];
            for (int i = 0; i < parameterNodes.Count; i++)
            {
                var pName = parameterNodes[i].FirstChild.InnerText;
                var pType = parameterNodes[i].LastChild.InnerText;
                parameters[i] = new Parameter("", pType, pName);
            }

            return new Method();
        }

        public static Type StringToType(string type)
        {
            var t = type switch
            {
                "" => typeof(void),
                _ => null
            };

            if (t == null)
            {
                Logger.Error($"Type conversion has not been created for type {type}");
            }

            return t;
        }
    }
}
