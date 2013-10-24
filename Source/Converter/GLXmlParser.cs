using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CHeaderToXML
{
    class GLXmlParser : Parser
    {
        string EnumPrefix { get { return Prefix.ToUpper() + "_"; } }
        string FuncPrefix { get { return Prefix; } }

        public GLXmlParser()
        {
        }

        public override IEnumerable<XElement> Parse(string[] lines)
        {
            var input = XDocument.Parse(String.Join(" ", lines));

            List<XElement> elements = new List<XElement>();
            elements.AddRange(ParseEnums(input));
            elements.AddRange(ParseFunctions(input));

            return elements;
        }

        IEnumerable<XElement> ParseEnums(XDocument input)
        {
            foreach (var group in input.Root.Elements("groups").Elements("group"))
            {
                var e = new XElement("enum", new XAttribute("name", TrimName(group.Attribute("name").Value)));
                foreach (var token in group.Elements("enum"))
                {
                    if (token.Attribute("value") != null)
                    {
                        e.Add(new XElement("token",
                            new XAttribute("name", TrimName(token.Attribute("name").Value)),
                            new XAttribute("value", token.Attribute("value").Value)));
                    }
                    else
                    {
                        e.Add(new XElement("use",
                            new XAttribute("token", TrimName(token.Attribute("name").Value))));
                    }
                }

                yield return e;
            }

            var all = new XElement("enum", new XAttribute("name", "All"));
            foreach (var token in input.Root.Elements("enums").Elements("enum"))
            {
                all.Add(token);
            }
            yield return all;

            var features = input.Root.Elements("feature");
            var extensions = input.Root.Elements("extension");
            foreach (var feature in features.Concat(extensions))
            {
                var e = new XElement("enum",
                    new XAttribute("name", feature.Attribute("name").Value),
                    new XAttribute("version", feature.Attribute("number").Value));

                foreach (var token in feature.Elements("require").Elements("enum"))
                {
                    e.Add(new XElement("use", new XAttribute("token", token.Attribute("name").Value)));
                }

                yield return e;
            }
        }

        IEnumerable<XElement> ParseFunctions(XDocument input)
        {
            //  Go through the list of commands and build OpenTK functions out of those.
            // Every function has a number of attributes that define which API version and
            // category (see above) they belong to.
            // It also includes information about the return type and parameters. These
            // are then parsed by the binding generator in order to create the necessary
            // overloads for correct use.

            // First, we go through all available features and extensions and build a list
            // of commands that belong to them.
            // We will then use this information to "decorate" our bindings with
            // information about versioning, extension support and deprecation.
            var features = input.Root.Elements("feature");
            var extensions = input.Root.Elements("extensions").Elements("extension");
            var categories = new SortedDictionary<string, XElement>();

            foreach (var c in features.Concat(extensions))
            {
                var category = TrimName(c.Attribute("name").Value);
                var api = c.Attribute("api") != null ? c.Attribute("api").Value : null;
                var version = c.Attribute("number") != null ? c.Attribute("number").Value : null;

                foreach (var command in c.Elements("require").Elements("command"))
                {
                    var cmd_name = TrimName(command.Attribute("name").Value);
                    if (!categories.ContainsKey(cmd_name))
                        categories.Add(cmd_name, new XElement(cmd_name));

                    var cmd_element = categories[cmd_name];

                    var cmd_category = cmd_element.Attribute("category") ?? new XAttribute("category", "");
                    var cmd_api = cmd_element.Attribute("api") ?? new XAttribute("api", "");
                    var cmd_version = cmd_element.Attribute("version") ?? new XAttribute("version", "");

                    cmd_category.Value = Join(cmd_category.Value, category);
                    cmd_api.Value = Join(cmd_api.Value, api);
                    cmd_version.Value = Join(cmd_version.Value, version);

                    cmd_element.SetAttributeValue(cmd_category.Name, cmd_category.Value);
                    cmd_element.SetAttributeValue(cmd_api.Name, cmd_api.Value);
                    cmd_element.SetAttributeValue(cmd_version.Name, cmd_version.Value);
                }
            }
  
            // Now, we go through all commands and retrieve their parameters and return types.
            // We also use the list we built above to decorate them with the relevant attributes.
            foreach (var command in input.Root.Elements("commands").Elements("command"))
            {
                var function = new XElement("function");

                var cmd_name = FunctionName(command);
                var name = new XAttribute("name", cmd_name);

                var extension = new XAttribute("extension", "");
                var returns = new XElement("returns", FunctionParameterType(command.Element("proto")));

                var category = categories.ContainsKey(cmd_name) ? new XAttribute("category", categories[cmd_name].Attribute("category").Value) : null;
                var version = categories.ContainsKey(cmd_name) ? new XAttribute("version", categories[cmd_name].Attribute("version").Value) : null;
                var api = categories.ContainsKey(cmd_name) ? new XAttribute("api", categories[cmd_name].Attribute("api").Value) : null;

                var deprecated = new XAttribute("deprecated", "");

                foreach (var parameter in command.Elements("param"))
                {
                    var p = new XElement("param");
                    var pname = new XAttribute("name", parameter.Element("name").Value);
                    var type = new XAttribute("type", FunctionParameterType(parameter));

                    var count = parameter.Attribute("len") != null ?
                        new XAttribute("count", parameter.Attribute("len").Value) : null;

                    var flow = new XAttribute("flow",
                        type.Value.Contains("*") && !type.Value.Contains("const") ? "out" : "in");

                    p.Add(pname, type, flow);
                    if (count != null)
                    {
                        p.Add(count);
                    }

                    function.Add(p);
                }

                function.Add(name);
                function.Add(extension);
                function.Add(returns);
                function.Add(category);
                function.Add(version);
                function.Add(api);
                function.Add(deprecated);

                yield return function;
            }
        }

        string FunctionName(XElement e)
        {
            return TrimName(e.Element("proto").Element("name").Value);
        }

        string FunctionParameterType(XElement e)
        {
            // Parse the C-like <proto> element. Possible instances:
            // Return types:
            // - <proto>void <name>glGetSharpenTexFuncSGIS</name></proto>
            //   -> <returns>void</returns>
            // - <proto group="String">const <ptype>GLubyte</ptype> *<name>glGetString</name></proto>
            //   -> <returns>String</returns> 
            // Note: group attribute takes precedence if it exists. This matches the old .spec file format.
            // Parameter types:
            // - <param><ptype>GLenum</ptype> <name>shadertype</name></param>
            //   -> <param name="shadertype" type="GLenum" />
            // - <param len="1"><ptype>GLsizei</ptype> *<name>length</name></param>
            //   -> <param name="length" type="GLsizei" count="1" />

            var proto = e.Value;
            var name = e.Element("name").Value;
            var group = e.Attribute("group");
            var ret = group != null ? group.Value : proto.Remove(proto.LastIndexOf(name)).Trim();
            return ret;
        }

        string TrimName(string name)
        {
            if (name.StartsWith(EnumPrefix))
                return name.Remove(0, EnumPrefix.Length);
            else if (name.StartsWith(FuncPrefix))
                return name.Remove(0, FuncPrefix.Length);
            else
                return name;
        }

        static string Join(string left, string right)
        {
            if (!String.IsNullOrEmpty(left) && !String.IsNullOrEmpty(right))
                return left + "|" + right;
            else if (!String.IsNullOrEmpty(left))
                return left;
            else if (!String.IsNullOrEmpty(right))
                return right;
            else
                return String.Empty;
        }
    }
}

