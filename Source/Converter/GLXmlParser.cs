using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            // Go through all features and extension in the spec
            // and build a list of which tokens belong to which.
            var features = input.Root.Elements("feature");
            var extensions = input.Root.Elements("extensions").Elements("extension");
            var categories = new SortedDictionary<string, XElement>();

            foreach (var feature in features.Concat(extensions))
            {
                var category = TrimName(feature.Attribute("name").Value);
                var extension = feature.Name == "extension" ? category.Substring(0, category.IndexOf("_")) : "Core";
                var version = feature.Attribute("number") != null ? feature.Attribute("number").Value : null;
                var api =
                    feature.Attribute("api") != null ? feature.Attribute("api").Value :
                    feature.Attribute("supported") != null ? feature.Attribute("supported").Value :
                    null;

                foreach (var token in feature.Elements("require").Elements("enum"))
                {
                    var enum_name = TrimName(token.Attribute("name").Value);
                    if (!categories.ContainsKey(enum_name))
                        categories.Add(enum_name, new XElement("enum"));

                    var e = categories[enum_name];

                    var enum_category = e.Attribute("category") ?? new XAttribute("category", "");
                    var enum_extension = e.Attribute("extension") ?? new XAttribute("extension", "");
                    var enum_api = e.Attribute("api") ?? new XAttribute("api", "");
                    var enum_version = e.Attribute("version") ?? new XAttribute("version", "");

                    enum_category.Value = Join(enum_category.Value, category);
                    enum_extension.Value = Join(enum_extension.Value, extension);
                    enum_api.Value = Join(enum_api.Value, api);
                    enum_version.Value = Join(enum_version.Value, version);

                    e.SetAttributeValue(enum_category.Name, enum_category.Value);
                    e.SetAttributeValue(enum_extension.Name, enum_extension.Value);
                    e.SetAttributeValue(enum_api.Name, enum_api.Value);
                    e.SetAttributeValue(enum_version.Name, enum_version.Value); 
               }
            }

            foreach (var group in features
                     .Concat(extensions)
                     .Concat(input.Root.Elements("groups").Elements("group")))
            {
                var enum_name = TrimName(group.Attribute("name").Value);
                var enum_element = new XElement("enum", new XAttribute("name", enum_name));

                foreach (var token in group.Elements("enum").Concat(group.Elements("require").Elements("enum")))
                {
                    var name = TrimName(token.Attribute("name").Value);

                    XElement e = new XElement(
                        "use",
                        new XAttribute("enum", "All"),
                        new XAttribute("token", name));

                    enum_element.Add(e);
                }

                yield return enum_element;
            }

            // The actual values are defined here
            var all = new XElement("enum", new XAttribute("name", "All"));
            foreach (var enumeration in input.Root.Elements("enums"))
            {
                var type = enumeration.Attribute("type");

                foreach (var token in enumeration.Elements("enum"))
                {
                    var e = new XElement("token", type);
                    var name = TrimName(token.Attribute("name").Value);
                    var value = token.Attribute("value").Value;
                    e.Add(
                        new XAttribute("name", name),
                        new XAttribute("value", value));

                    if (categories.ContainsKey(name))
                    {
                        var category = Lookup(categories, name, "category");
                        var extension = Lookup(categories, name, "extension");
                        var version = Lookup(categories, name, "version");
                        var api = Lookup(categories, name, "api");
                        var deprecated = Lookup(categories, name, "deprecated");

                        e.Add(category);
                        e.Add(extension);
                        e.Add(version);
                        e.Add(api);
                        e.Add(deprecated);
                    }
                    else
                    {
                        Trace.WriteLine(String.Format("Token '{0}' is not part of any feature or extension.", name));
                    }

                    all.Add(e);
                }
            }
            yield return all;
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
                var extension = c.Name == "extension" ? category.Substring(0, category.IndexOf("_")) : "Core";

                var api =
                    c.Attribute("api") != null ? c.Attribute("api").Value :
                    c.Attribute("supported") != null ? c.Attribute("supported").Value :
                    null;
                var version = c.Attribute("number") != null ? c.Attribute("number").Value : null;

                foreach (var command in c.Elements("require").Elements("command"))
                {
                    var cmd_name = TrimName(command.Attribute("name").Value);
                    if (!categories.ContainsKey(cmd_name))
                        categories.Add(cmd_name, new XElement(cmd_name));

                    var cmd_element = categories[cmd_name];

                    var cmd_category = cmd_element.Attribute("category") ?? new XAttribute("category", "");
                    var cmd_extension = cmd_element.Attribute("extension") ?? new XAttribute("extension", "");
                    var cmd_api = cmd_element.Attribute("api") ?? new XAttribute("api", "");
                    var cmd_version = cmd_element.Attribute("version") ?? new XAttribute("version", "");

                    cmd_category.Value = Join(cmd_category.Value, category);
                    cmd_extension.Value = Join(cmd_extension.Value, extension);
                    cmd_api.Value = Join(cmd_api.Value, api);
                    cmd_version.Value = Join(cmd_version.Value, version);

                    cmd_element.SetAttributeValue(cmd_category.Name, cmd_category.Value);
                    cmd_element.SetAttributeValue(cmd_extension.Name, cmd_extension.Value);
                    cmd_element.SetAttributeValue(cmd_api.Name, cmd_api.Value);
                    cmd_element.SetAttributeValue(cmd_version.Name, cmd_version.Value);
                }
            }

            // Lookup which functions are deprecated and mark them so.
            foreach (var c in features)
            {
                var version = c.Attribute("number").Value;

                foreach (var r in c.Elements("remove").Elements("command"))
                {
                    var cmd_name = TrimName(r.Attribute("name").Value);
                    var cmd_element = categories[cmd_name];
                    var cmd_deprecated = cmd_element.Attribute("deprecated") ?? new XAttribute("deprecated", "");

                    cmd_deprecated.Value = Join(cmd_deprecated.Value, version);

                    cmd_element.SetAttributeValue(cmd_deprecated.Name, cmd_deprecated.Value);
                }
            }
  
            // Now, we go through all commands and retrieve their parameters and return types.
            // We also use the list we built above to decorate them with the relevant attributes.
            foreach (var command in input.Root.Elements("commands").Elements("command"))
            {
                var function = new XElement("function");

                var cmd_name = FunctionName(command);
                var name = new XAttribute("name", cmd_name);

                if (!categories.ContainsKey(cmd_name))
                {
                    Trace.WriteLine(String.Format("Command '{0}' is not part of any feature or extension. Ignoring.", cmd_name));
                    continue;
                }
                
                var category = Lookup(categories, cmd_name, "category");
                var extension = Lookup(categories, cmd_name, "extension");
                var version = Lookup(categories, cmd_name, "version");
                var api = Lookup(categories, cmd_name, "api");
                var deprecated = Lookup(categories, cmd_name, "deprecated");

                var returns = new XElement(
                    "returns", 
                    new XAttribute(
                        "type",
                        FunctionParameterType(command.Element("proto"))
                            .Replace("const", String.Empty)
                            .Replace("struct", String.Empty)
                            .Trim()));

                foreach (var parameter in command.Elements("param"))
                {
                    var param = FunctionParameterType(parameter);

                    var p = new XElement("param");
                    var pname = new XAttribute("name", parameter.Element("name").Value);
                    var type = new XAttribute(
                        "type",
                        param
                            .Replace("const", String.Empty)
                            .Replace("struct", String.Empty)
                            .Trim());

                    var count = parameter.Attribute("len") != null ?
                        new XAttribute("count", parameter.Attribute("len").Value) : null;

                    var flow = new XAttribute("flow",
                        param.Contains("*") && !param.Contains("const") ? "out" : "in");

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

            var ret = proto.Remove(proto.LastIndexOf(name)).Trim();

            if (group != null)
            {
                var words = ret.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (words[0] == "struct" || words[0] == "const")
                    words[1] = group.Value;
                else
                    words[0] = group.Value;

                ret = String.Join(" ", words);
            }

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

        static XAttribute Lookup(IDictionary<string, XElement> categories, string cmd_name, string attribute)
        {
            if (categories.ContainsKey(cmd_name))
            {
                return categories[cmd_name].Attribute(attribute);
            }
            return null;
        }
    }
}

