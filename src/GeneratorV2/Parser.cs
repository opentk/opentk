using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using GeneratorV2.Extensions;

namespace GeneratorV2
{
    public class Parser
    {
        private readonly XDocument _document;
        private const string PlatformSpecificGlHandleArbFlag = "\x1A";

        public Parser(Stream stream)
        {
            Logger.Info("Parser instantiated.");
            _document = XDocument.Load(stream);
        }

        #region Command

        private static void CreatePlatformSpecificGlHandleArb(Dictionary<string, Command> coms, Command commandBase)
        {
            var method = commandBase.Method;
            var success = true;

            PType ClonePType(PType original, string newType)
            {
                if (original.Name.StartsWith(PlatformSpecificGlHandleArbFlag))
                {
                    if (original.Name.Length > PlatformSpecificGlHandleArbFlag.Length && method.EntryPoint != "glGetAttachedObjectsARB")
                    {
                        success = false;
                    }
                    return new PType(newType + original.Name.Substring(1), original.Modifier, original.Group, original.Length);
                }
                return original;
            }
            var appleMethodReturnType = ClonePType(method.ReturnType, "IntPtr");
            var otherMethodReturnType = ClonePType(method.ReturnType, "uint");
            var overloadMethodReturnType = ClonePType(method.ReturnType, "GLhandleARB");
            var appleParameters = new Parameter[method.Parameters.Length];
            var otherParameters = new Parameter[method.Parameters.Length];
            var overloadParameters = new Parameter[method.Parameters.Length];
            for (int i = 0; i < method.Parameters.Length; i++)
            {
                var parameter = method.Parameters[i];
                var paramName = parameter.Name;
                appleParameters[i] = new Parameter(ClonePType(parameter.Type, "IntPtr"), paramName);
                otherParameters[i] = new Parameter(ClonePType(parameter.Type, "uint"), paramName);
                overloadParameters[i] = new Parameter(ClonePType(parameter.Type, "GLhandleARB"), paramName);
            }

            if (!success)
            {
                Logger.Error($"Function {commandBase.Name} has a GLhandleARB* which is not passed correctly");
                return;
            }

            var appleMethod = new Method(appleMethodReturnType, method.EntryPoint, appleParameters);
            var otherMethod = new Method(otherMethodReturnType, method.EntryPoint, otherParameters);

            Action<IndentedTextWriter> bodyWriter = (IndentedTextWriter writer) =>
            {
                void WriteCommand(string name)
                {
                    if (commandBase.Method.ReturnType.Name != "void")
                    {
                        writer.Write("return ");
                    }
                    writer.Write($"{name}{commandBase.Name}(");
                    for (int i = 0; i < overloadParameters.Length; i++)
                    {
                        writer.Write(overloadParameters[i].Name);
                        if (i != overloadParameters.Length - 1)
                        {
                            writer.Write(", ");
                        }
                    }
                }
                void WriteGetAttachedObjects(string name, string type)
                {
                    writer.Write("var len = maxCount.ToInt32();");
                    writer.Write($"{type}* tmp = stackalloc {type}[len];");
                    writer.Write($"{name}{commandBase.Name}(containerObj, maxCount, count, tmp);");
                    writer.Write("for (int i = 0; i < len; i++)");
                    using (writer.Scope())
                    {
                        writer.Write("obj[i] = tmp[i]");
                    }
                }

                writer.WriteLine("if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))");
                using (writer.Scope())
                {
                    if (method.EntryPoint == "glGetAttachedObjectsARB")
                    {
                        WriteGetAttachedObjects("__APPLE_", "uint");
                    }
                    else
                    {
                        WriteCommand("__APPLE_");
                    }
                }
                writer.WriteLine("else");
                using (writer.Scope())
                {
                    if (otherMethod.EntryPoint == "glGetAttachedObjectsARB")
                    {
                        WriteGetAttachedObjects("__GOOD_", "IntPtr");
                    }
                    else
                    {
                        WriteCommand("__GOOD_");
                    }
                }
            };
            var overload = new Overload(overloadMethodReturnType, bodyWriter, overloadParameters);
            coms.Add(method.EntryPoint, new HandleARBCommand(otherMethod, commandBase.Name, appleMethod, overload));
        }


        public Dictionary<string, Command> ParseCommands()
        {
            Logger.Info("Beggining parsing of commands.");
            var reg = _document.Root;

            var commands = reg.Element("commands");

            var coms = new Dictionary<string, Command>();
            foreach (var c in commands.Elements("command"))
            {
                var com = ParseCommand(c, out var isGLhandleArb);
                if (com != null)
                {
                    if (isGLhandleArb)
                    {
                        CreatePlatformSpecificGlHandleArb(coms, com);
                    }
                    else
                    {
                        coms.Add(com.Method.EntryPoint, com);
                    }
                }
            }

            return coms;
        }

        private Command? ParseCommand(XElement c, out bool isGLhandleArb)
        {
            isGLhandleArb = false;
            var entryPoint = string.Empty;
            try
            {
                var prototypeBase = c.Element("proto");
                entryPoint = prototypeBase.Element("name").Value;
                var methodName = entryPoint.Substring(2);

                var parameters = new List<Parameter>();
                foreach (var p in c.Elements("param"))
                {
                    var paramName = MangleParameterName(p.Element("name").Value);
                    var paramType = ParsePType(p);
                    isGLhandleArb |= paramType.Name == PlatformSpecificGlHandleArbFlag;
                    parameters.Add(new Parameter(paramType, paramName));
                }
                var returnType = ParsePType(prototypeBase);
                isGLhandleArb |= returnType.Name == PlatformSpecificGlHandleArbFlag;

                var method = new Method(returnType, entryPoint, parameters.ToArray());
                return new Command(method, methodName);
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
                "GLhandleARB" => PlatformSpecificGlHandleArbFlag, //This type is platform specific on apple.

                //The following have a custom c# implementation in the writer.
                "GLsync" => "GLsync*",
                "_cl_context" => "CLContext",
                "_cl_event" => "CLEvent",
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

        public Dictionary<(string api, string vendor), Extension[]> ParseExtensions(Dictionary<string, Command> commands, Dictionary<string, EnumEntry> enums)
        {
            var extensions = new ApiExtension();
            var reg = _document.Root;

            foreach(var ext in reg.Element("extensions").Elements("extension"))
            {
                var extName = ext.Attribute("name")?.Value?.Substring(3);
                if (extName == null)
                {
                    Logger.Error($"Extension did not parse correctly");
                    continue;
                }
                int ind = extName.IndexOf('_', StringComparison.Ordinal);
                if (ind == -1)
                {
                    Logger.Error($"Extension '{extName}' is missing an underscore.");
                    continue;
                }

                var vendor = extName.Remove(ind);
                extName = MangleExtensionName(extName.Substring(ind + 1));

                var supportedApis = ext.Attribute("supported")?.Value?.Split('|', StringSplitOptions.RemoveEmptyEntries) ?? new string[] {};

                foreach(var api in supportedApis)
                {
                    var extension = new Extension(MangleClassName(vendor), extName, supportedApis);
                    foreach(var includes in ext.Elements("require"))
                    {
                        var includesApi = includes.Attribute("api")?.Value;
                        if (includesApi == api || includesApi == null)
                        {
                            ParseInclude(enums, commands, extension, includes, vendor);
                        }
                    }

                    extensions.AddExtension(api, extension);
                }
            }

            return extensions.ToDictionaryArray();
        }

        private static string MangleClassName(string name)
        {
            return (char.IsDigit(name[0]) ? $"_{name}" : name);
        }

        private static string MangleExtensionName(string name)
        {
            var str = new StringBuilder(name.Length);
            bool capitalize = true;
            for (int i=0;i<name.Length;i++)
            {
                var chr = name[i];
                if (chr == '_')
                {
                    capitalize = true;
                }
                else
                {
                    str.Append(capitalize ? char.ToUpper(chr) : char.ToLower(chr));
                    capitalize = false;
                }
            }
            return MangleClassName(str.ToString());
        }

        private static void ParseInclude(Dictionary<string, EnumEntry> enums, Dictionary<string, Command> commands,
            Extension extension, XElement includes, string vendorName)
        {
            foreach (var e in includes.Elements("enum"))
            {
                var eName = e.Attribute("name")?.Value;
                if (!enums.TryGetValue(eName, out var enumEntry))
                {
                    Logger.Error($"Extension command include did not parse correctly.");
                    continue;
                }
                extension.Add(enumEntry);
            }
            foreach (var e in includes.Elements("command"))
            {
                var cName = e.Attribute("name")?.Value;
                if (!commands.TryGetValue(cName, out var command))
                {
                    Logger.Error($"Extension command include did not parse correctly.");
                    continue;
                }

                extension.Add(command.CloneCommand("Gl" + (command.Name.EndsWith(vendorName) ?
                                                            command.Name.Remove(command.Name.Length - vendorName.Length) :
                                                            command.Name)));
            }
        }
    }
}
