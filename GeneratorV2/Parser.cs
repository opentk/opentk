using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace GeneratorV2
{
    public class Parser
    {
        private readonly XDocument _document;

        public Parser(Stream stream)
        {
            Logger.Info("Parser instantiated.");
            _document = XDocument.Load(stream);
        }

        public Command[] ParseCommands()
        {
            Logger.Info("Beggining parsing of commands.");
            var reg = _document.Root;

            var commands = reg.Element("commands");

            var coms = new List<Command>();
            foreach (var c in commands.Elements("command"))
            {
                var com = ParseCommand(c);
                if (com != null)
                {
                    coms.Add(com);
                }
            }

            return coms.ToArray();
        }

        private Command? ParseCommand(XElement c)
        {
            var entryPoint = string.Empty;
            try
            {
                var prototypeBase = c.Element("proto");
                entryPoint = prototypeBase.Element("name").Value;
                var methodName = entryPoint.Substring(2);
                var returnType = prototypeBase.Element("ptype")?.Value
                                        ?? prototypeBase.GetXmlText(element => string.Empty);

                returnType = returnType.Trim();

                var parameters = new List<Parameter>();
                foreach (var p in c.Elements("param"))
                {
                    var group = p.Attribute("group")?.Value;
                    var length = p.Attribute("len")?.Value;

                    var paramName = MangleParameterName(p.Element("name").Value);

                    var paramType = p.GetXmlText(element => element.Name == "name" ? string.Empty : element.Value).Trim();
                
                    parameters.Add(new Parameter(paramType, paramName, group, length));
                }
                var method = new Method(returnType, methodName, entryPoint, parameters.ToArray());
                return new Command(method);
            }
            catch(NullReferenceException)
            {
                Logger.Error($"Error in parsing method \"{entryPoint}\"");
                return null;
            }
        }

        [Pure]
        private static string MangleParameterName(string name)
        {
            return name switch
            {
                "ref" => "reference",
                "params" => "parameters",
                "object" => "obj",
                "base" => "@base",
                "string" => "str",
                _ => name
            };
        }
    }
}
