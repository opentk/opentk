using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
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

        #region Command
        public Dictionary<string, Command> ParseCommands()
        {
            Logger.Info("Beggining parsing of commands.");
            var reg = _document.Root;

            var commands = reg.Element("commands");

            var coms = new Dictionary<string, Command>();
            foreach (var c in commands.Elements("command"))
            {
                var com = ParseCommand(c);
                if (com != null)
                {
                    coms.Add(com.Method.EntryPoint, com);
                }
            }

            return coms;
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
                    var paramName = MangleParameterName(p.Element("name").Value);
                    var paramType = ParsePType(p);
                
                    parameters.Add(new Parameter(paramType, paramName));
                }
                var method = new Method(ParsePType(prototypeBase), methodName, entryPoint, parameters.ToArray());
                return new Command(method);
            }
            catch(NullReferenceException)
            {
                Logger.Error($"Error in parsing method \"{entryPoint}\"");
                return null;
            }
        }

        private static string MangleParameterName(string name)
        {
            return name switch
            {
                "ref" => "reference",
                "params" => "parameters",
                "object" => "obj",
                "base" => "@base",
                "string" => "str",
                "event" => "@event",
                "in" => "input",
                _ => name
            };
        }

        private static PType ParsePType(XElement t)
        {
            var group = t.Attribute("group")?.Value;
            var length = t.Attribute("len")?.Value;

            var paramType = t.GetXmlText(element => element.Name == "name" ? string.Empty : element.Value).Trim();
            var mod = PModifier.None;
            return new PType(ParseType(paramType, ref mod, ref length), mod, group, length);
        }

        private static string ParseType(string type, ref PModifier modifier, ref string? length)
        {
            type = type.Trim();

            if (type.EndsWith(']'))
            {
                int openingBracketIndex = type.LastIndexOf('[');
                if (openingBracketIndex != -1)
                {
                    if (length != null)
                    {
                        throw new NotSupportedException("Nested array type parsing not supported!");
                    }


                    length = type.Substring(openingBracketIndex + 1, type.Length - openingBracketIndex - 2);
                    return ParseType(type.Substring(0, openingBracketIndex) + "*", ref modifier, ref length);
                }
            }

            if (type.EndsWith('*'))
            {
                return ParseType(type[0..^1], ref modifier, ref length) + "*";
            }

            if (type.EndsWith("const"))
            {
                modifier |= PModifier.ReadOnlySpan;
                return ParseType(type.Substring(0, type.Length - "const".Length), ref modifier, ref length);
            }
            
            if (type.StartsWith("const"))
            {
                modifier |= PModifier.In;
                return ParseType(type["const".Length..], ref modifier, ref length);
            }

            if (type.StartsWith("struct"))
            {
                type = type["struct".Length..].Trim();
            }

            var t = type switch
            {
                "void" => "void",
                "GLenum" => "uint",
                "GLboolean" => "byte",
                "GLbitfield" => "uint",
                "GLvoid" => "void",
                "GLbyte" => "sbyte",
                "GLubyte" => "byte",
                "GLshort" => "short",
                "GLushort" => "ushort",
                "GLint" => "int",
                "GLuint" => "uint",
                "GLclampx" => "int",
                "GLsizei" => "int",
                "GLfloat" => "float",
                "GLclampf" => "float",
                "GLdouble" => "double",
                "GLclampd" => "double",
                "GLeglClientBufferEXT" => "void*",
                "GLeglImageOES" => "void*",
                "GLchar" => "char",
                "GLcharARB" => "char",
                "*GLhandleARB" => "void*", //OS dependent
                "GLhandleARB" => "uint", //OS dependent
                "GLhalf" => "short",
                "GLhalfARB" => "short",
                "GLfixed" => "int",
                "GLintptr" => "IntPtr",
                "GLintptrARB" => "IntPtr",
                "GLsizeiptr" => "IntPtr",
                "GLsizeiptrARB" => "IntPtr",
                "GLint64" => "int",
                "GLint64EXT" => "int",
                "GLuint64" => "uint",
                "GLuint64EXT" => "uint",
                "GLhalfNV" => "ushort",
                "GLvdpauSurfaceNV" => "IntPtr",
                "GLVULKANPROCNV" => "void",

                //The following have a custom c# implementation in the writer.
                "GLsync" => "GLsync",
                "_cl_context" => "_cl_context",
                "_cl_event" => "_cl_event",
                "GLDEBUGPROC" => "GLDEBUGPROC",
                "GLDEBUGPROCARB" => "GLDEBUGPROCARB",
                "GLDEBUGPROCKHR" => "GLDEBUGPROCKHR",
                "GLDEBUGPROCAMD" => "GLDEBUGPROCAMD",
                "GLDEBUGPROCNV" => "GLDEBUGPROCNV",
                _ => null
            };

            if (t == null)
            {
                Logger.Error($"Type conversion has not been created for type {type}");
                return type;
            }

            return t;
        }
        #endregion Commands

        #region Enum
        public Dictionary<string, EnumEntry> ParseEnums()
        {
            Logger.Info("Beggining parsing of enums.");

            var parsedEnums = new Dictionary<string, EnumEntry>();

            var reg = _document.Root;

            foreach(var e in reg.Elements("enums"))
            {
                foreach(var eEntry in e.Elements("enum"))
                {
                    var entry = ParseEnumEntry(eEntry);
                    if (entry != null)
                    {
                        parsedEnums.TryAdd(entry.Name, entry); // TODO: fix duplicate
                    }
                }
            }
            return parsedEnums;
        }
        public static ulong ConvertToUInt64(string val)
        {
            return (ulong)(long)new System.ComponentModel.Int64Converter().ConvertFromString(val);
        }
        public EnumEntry? ParseEnumEntry(XElement e)
        {
            var entryName = e.Attribute("name")?.Value;
            var valueStr = e.Attribute("value")?.Value;
            if (valueStr == null || entryName == null)
            {
                Logger.Error($"Enum {entryName} did not pass correctly");
                return null;
            }
            var value = ConvertToUInt64(valueStr);
            var groups = (e.Attribute("group")?.Value ?? string.Empty).Split(',', StringSplitOptions.RemoveEmptyEntries);

            var enumType = e.Parent.Attribute("type")?.Value switch
            {
                "bitmask" => EnumType.Bitmask,
                _ => EnumType.None
            };
            return new EnumEntry(entryName, value, groups, enumType);
        }

        #endregion Enum

        #region Features
        public Feature[] ParseFeatures(Dictionary<string, Command> commands, Dictionary<string, EnumEntry> enums)
        {
            Logger.Info("Beggining parsing of features.");

            var reg = _document.Root;
            var features = new List<Feature>();

            Feature previousFeature = null;

            foreach(var f in reg.Elements("feature"))
            {
                var api = f.Attribute("api")?.Value;
                var name = f.Attribute("name")?.Value;
                var versionStr = f.Attribute("number")?.Value;
                if (api == null || name == null || versionStr == null)
                {
                    Logger.Error($"Feature {name} did not parse correctly.");
                    continue;
                }
                var version = Version.Parse(versionStr);

                var excludeEnums = new HashSet<string>();
                var excludeCommands = new HashSet<string>();
                foreach (var excludes in f.Elements("remove"))
                {
                    ParseExclude(excludes, excludeEnums, excludeCommands);
                }

                var feature = new Feature(api, name, version);

                if (feature.Api == previousFeature?.Api)
                {
                    feature.Add(previousFeature, excludeEnums, excludeCommands);
                }

                foreach(var includes in f.Elements("require"))
                {
                    ParseInclude(enums, commands, feature, includes);
                }


                previousFeature = feature;
                features.Add(feature);
            }
            return features.ToArray();
        }
        private static void ParseExclude(XElement excludes, HashSet<string> excludeEnums, HashSet<string> excludeCommands)
        {
            var profile = excludes.Attribute("profile")?.Value;
            if (profile != "compatibility" && profile != null)
            {
                return;
            }

            foreach(var e in excludes.Elements("enum"))
            {
                var eName = e.Attribute("name")?.Value;
                if (eName == null)
                {
                    Logger.Error($"Feature enum exclude did not parse correctly.");
                    continue;
                }
                excludeEnums.Add(eName);
            }

            foreach(var c in excludes.Elements("command"))
            {
                var cName = c.Attribute("name")?.Value;
                if (cName == null)
                {
                    Logger.Error($"Feature command exclude did not parse correctly.");
                    continue;
                }
                excludeCommands.Add(cName);
            }
        }
        private static void ParseInclude(Dictionary<string, EnumEntry> enums, Dictionary<string, Command> commands,
            Feature feature, XElement includes)
        {
            var profile = includes.Attribute("profile")?.Value;
            if (profile != "compatibility" && profile != null)
            {
                return;
            }

            foreach (var e in includes.Elements("enum"))
            {
                var eName = e.Attribute("name")?.Value;
                if (!enums.TryGetValue(eName, out var enumEntry))
                {
                    Logger.Error($"Feature command include did not parse correctly.");
                    continue;
                }
                feature.Add(enumEntry);
            }
            foreach (var e in includes.Elements("command"))
            {
                var cName = e.Attribute("name")?.Value;
                if (!commands.TryGetValue(cName, out var command))
                {
                    Logger.Error($"Feature command include did not parse correctly.");
                    continue;
                }
                feature.Add(command);
            }
        }
        #endregion Features


        public Dictionary<string, Extension[]> ParseExtensions(Dictionary<string, Command> commands, Dictionary<string, EnumEntry> enums)
        {
            var reg = _document.

            return null;
        }
    }
}
