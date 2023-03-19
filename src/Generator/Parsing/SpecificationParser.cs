using Generator.Utility;
using Generator.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Generator.Parsing
{
    public class SpecificationParser
    {
        public static Specification Parse(Stream input)
        {
            XDocument? xdocument = XDocument.Load(input);

            if (xdocument.Root == null)
                throw new NullReferenceException("The parsed xml didn't contain a Root node.");

            List<Command>? commands = ParseCommands(xdocument.Root);
            List<Enums>? enums = ParseEnums(xdocument.Root);

            List<Feature>? features = ParseFeatures(xdocument.Root);
            List<Extension>? extensions = ParseExtensions(xdocument.Root);

            return new Specification(commands, enums, features, extensions);
        }


        public static List<Command> ParseCommands(XElement input)
        {
            Logger.Info("Begining parsing of commands.");
            XElement? xelement = input.Element("commands")!;

            List<Command>? commands = new List<Command>();
            foreach (XElement? element in xelement.Elements("command"))
            {
                Command? command = ParseCommand(element);

                commands.Add(command);
            }

            return commands;
        }

        private static Command ParseCommand(XElement c)
        {
            XElement? proto = c.Element("proto");
            if (proto == null) throw new Exception("Missing proto tag!");

            string? entryPoint = proto.Element("name")?.Value;
            if (entryPoint == null) throw new Exception("Missing name tag!");

            List<GLParameter>? parameterList = new List<GLParameter>();
            foreach (XElement? element in c.Elements("param"))
            {
                string? paramName = element.Element("name")?.Value;
                PType? ptype = ParsePType(element);

                string[] kind = element.Attribute("kind")?.Value?.Split(',') ?? Array.Empty<string>();

                if (paramName == null) throw new Exception("Missing parameter name!");

                string? length = element.Attribute("len")?.Value;
                Expression? paramLength = length == null ? null : ParseExpression(length);

                parameterList.Add(new GLParameter(ptype, kind, paramName, paramLength));
            }

            PType? returnType = ParsePType(proto);

            return new Command(entryPoint, returnType, parameterList.ToArray());
        }

        private static Expression ParseExpression(string expression)
        {
            Expression? retExpr = ParseExpressionPrio2(expression, out string leftOver);

            if (string.IsNullOrEmpty(leftOver) == false)
                throw new Exception($"Failed to parse expression '{expression}' with leftover '{leftOver}'");

            return retExpr;
        }

        private static Expression ParseExpressionPrio2(string expression, out string leftOver)
        {
            Expression? retExpr = ParseExpressionPrio1(expression, out string exp);
            exp = exp.TrimStart();

            BinaryOperator op;
            // GetOperation is a local function defined below return.
            while ((op = GetOperation(exp)) != BinaryOperator.Invalid)
            {
                exp = exp[1..];
                Expression? right = ParseExpressionPrio1(exp, out exp);
                exp = exp.TrimStart();

                retExpr = new BinaryOperation(retExpr, op, right);
            }

            leftOver = exp;
            return retExpr;

            static BinaryOperator GetOperation(string expression)
            {
                if (expression.Length == 0) return BinaryOperator.Invalid;
                return expression[0] switch
                {
                    '+' => BinaryOperator.Addition,
                    '-' => BinaryOperator.Subtraction,
                    _ => BinaryOperator.Invalid,
                };
            }
        }

        private static Expression ParseExpressionPrio1(string expression, out string leftOver)
        {
            Expression? retExpr = ParseExpressionPrio0(expression, out string exp);
            exp = exp.TrimStart();

            BinaryOperator op;
            // GetOperation is a local function defined below return.
            while ((op = GetOperation(exp)) != BinaryOperator.Invalid)
            {
                exp = exp[1..];
                Expression? right = ParseExpressionPrio0(exp, out exp);
                exp = exp.TrimStart();

                retExpr = new BinaryOperation(retExpr, op, right);
            }

            leftOver = exp;
            return retExpr;

            static BinaryOperator GetOperation(string expression)
            {
                if (expression.Length == 0) return BinaryOperator.Invalid;
                return expression[0] switch
                {
                    '*' => BinaryOperator.Multiplication,
                    '/' => BinaryOperator.Division,
                    _ => BinaryOperator.Invalid,
                };
            }
        }

        private static Expression ParseExpressionPrio0(string expression, out string leftOver)
        {
            expression = expression.TrimStart();
            if (expression.StartsWith("COMPSIZE("))
            {
                string? exp = expression["COMPSIZE(".Length..];
                List<Expression> arguments = new List<Expression>();
                while (exp[0] != ')')
                {
                    arguments.Add(ParseExpressionPrio2(exp, out exp));

                    // NOTE: Possible error here, if whitespaces are introduced in COMPSIZE() inside the spec.
                    if (exp[0] == ',')
                        exp = exp[1..];
                }
                // Remove the last ')'
                leftOver = exp[1..];
                return new CompSize(arguments.ToArray());
            }
            else if (char.IsDigit(expression[0]))
            {
                int i = 1;
                while (i < expression.Length && char.IsDigit(expression[i]))
                {
                    i++;
                }

                leftOver = expression[i..];
                return new Constant(int.Parse(expression[0..i]));
            }
            else if (char.IsLetter(expression[0]))
            {
                int i = 1;
                while (i < expression.Length && char.IsLetterOrDigit(expression[i]))
                {
                    i++;
                }

                leftOver = expression[i..];
                return new ParameterReference(expression[0..i]);
            }
            else throw new Exception($"Could not parse expression '{expression}'");
        }

        private static PType ParsePType(XElement t)
        {
            string? group = t.Attribute("group")?.Value;

            string? className = t.Attribute("class")?.Value;
            HandleType? handle = className switch
            {
                null => null,
                "program" => HandleType.ProgramHandle,
                "program pipeline" => HandleType.ProgramPipelineHandle,
                "texture" => HandleType.TextureHandle,
                "buffer" => HandleType.BufferHandle,
                "shader" => HandleType.ShaderHandle,
                "query" => HandleType.QueryHandle,
                "framebuffer" => HandleType.FramebufferHandle,
                "renderbuffer" => HandleType.RenderbufferHandle,
                "sampler" => HandleType.SamplerHandle,
                "transform feedback" => HandleType.TransformFeedbackHandle,
                "vertex array" => HandleType.VertexArrayHandle,
                // The "Sync" class is already marked with the "GLSync" type which is handled differently from the other types
                // We leave it null here to let the "GLSync" handling do this.
                "sync" => null,
                "display list" => HandleType.DisplayListHandle,
                _ => throw new Exception(className + " is not a supported handle type yet!"),
            };

            string? str = t.GetXmlText(element => element.Name != "name" ? element.Value : string.Empty).Trim();

            return new PType(ParseType(str), handle, group);
        }

        private static GLType ParseType(string type)
        {
            type = type.Trim();

            if (type.EndsWith('*'))
            {
                // This removes the last character of the string, ^1 is an exclusive upper bound.
                string? withoutAsterisk = type[0..^1].TrimEnd();

                // A pointer is only const if const is directly in front of the pointer,
                // if the const is in front of the type the type is the constant and not the pointer.
                bool @const = false;
                if (withoutAsterisk.EndsWith("const"))
                {
                    @const = true;
                    withoutAsterisk = withoutAsterisk[0..^"const".Length];
                }

                GLType? baseType = ParseType(withoutAsterisk);

                return new GLPointerType(baseType, @const);
            }
            else
            {
                bool @const = false;
                if (type.StartsWith("const"))
                {
                    @const = true;
                    type = type["const".Length..].TrimStart();
                }

                // This is needed for _cl_context, and _cl_event
                // We don't care about struct here because it doesn't add any information (we are not a c compiler).
                if (type.StartsWith("struct"))
                {
                    type = type["struct".Length..].TrimStart();
                }

                PrimitiveType primitiveType = type switch
                {
                    "void" => PrimitiveType.Void,
                    "GLenum" => PrimitiveType.Enum,
                    "GLboolean" => PrimitiveType.Bool8,
                    "GLbitfield" => PrimitiveType.Uint,
                    "GLvoid" => PrimitiveType.Void,
                    "GLbyte" => PrimitiveType.Sbyte,
                    "GLubyte" => PrimitiveType.Byte,
                    "GLshort" => PrimitiveType.Short,
                    "GLushort" => PrimitiveType.Ushort,
                    "GLint" => PrimitiveType.Int,
                    "GLuint" => PrimitiveType.Uint,
                    "GLclampx" => PrimitiveType.Int,
                    "GLsizei" => PrimitiveType.Int,
                    "GLfloat" => PrimitiveType.Float,
                    "GLclampf" => PrimitiveType.Float,
                    "GLdouble" => PrimitiveType.Double,
                    "GLclampd" => PrimitiveType.Double,
                    "GLeglClientBufferEXT" => PrimitiveType.VoidPtr,
                    "GLeglImageOES" => PrimitiveType.VoidPtr,
                    "GLchar" => PrimitiveType.Char8,
                    "GLcharARB" => PrimitiveType.Char8,
                    "GLhalf" => PrimitiveType.Half,
                    "GLhalfARB" => PrimitiveType.Half,
                    "GLfixed" => PrimitiveType.Int,
                    "GLintptr" => PrimitiveType.IntPtr,
                    "GLintptrARB" => PrimitiveType.IntPtr,
                    "GLsizeiptr" => PrimitiveType.Nint,
                    "GLsizeiptrARB" => PrimitiveType.Nint,
                    "GLint64" => PrimitiveType.Long,
                    "GLint64EXT" => PrimitiveType.Long,
                    "GLuint64" => PrimitiveType.Ulong,
                    "GLuint64EXT" => PrimitiveType.Ulong,
                    "GLhalfNV" => PrimitiveType.Half,
                    "GLvdpauSurfaceNV" => PrimitiveType.IntPtr,

                    // This type is platform specific on apple.
                    "GLhandleARB" => PrimitiveType.GLHandleARB,

                    // The following have a custom c# implementation in the writer.
                    "GLsync" => PrimitiveType.GLSync,
                    "_cl_context" => PrimitiveType.CLContext,
                    "_cl_event" => PrimitiveType.CLEvent,
                    "GLDEBUGPROC" => PrimitiveType.GLDebugProc,
                    "GLDEBUGPROCARB" => PrimitiveType.GLDebugProcARB,
                    "GLDEBUGPROCKHR" => PrimitiveType.GLDebugProcKHR,
                    "GLDEBUGPROCAMD" => PrimitiveType.GLDebugProcAMD,
                    "GLDEBUGPROCNV" => PrimitiveType.GLDebugProcNV,
                    // This isn't actually used in the output bindings.
                    // But we leave it here as a primitive type so we have the information if we need it later.
                    // - 2021-06-23
                    "GLVULKANPROCNV" => PrimitiveType.GLVulkanProcNV,
                    _ => PrimitiveType.Invalid,
                };

                if (primitiveType == PrimitiveType.Invalid)
                {
                    throw new Exception($"Type conversion has not been created for type {type}");
                }

                return new GLBaseType(type, primitiveType, @const);
            }
        }


        public static List<Enums> ParseEnums(XElement input)
        {
            Logger.Info("Begining parsing of enums.");
            List<Enums> enumsEntries = new List<Enums>();
            foreach (XElement? enums in input.Elements("enums"))
            {
                string? @namespace = enums.Attribute("namespace")?.Value;
                if (@namespace == null) throw new Exception($"Enums entry '{enums}' is missing a namespace attribute.");

                string[] group = enums.Attribute("group")?.Value?.Split(',', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

                string? vendor = enums.Attribute("vendor")?.Value;

                EnumType type = ParseEnumsType(enums.Attribute("type")?.Value);

                string? startStr = enums.Attribute("start")?.Value;
                string? endStr = enums.Attribute("end")?.Value;
                if (startStr == null && endStr != null ||
                    startStr != null && endStr == null)
                    throw new Exception($"Enums entry '{enums}' is missing either a start or end attribute.");

                Range? range = null;
                if (startStr != null && endStr != null)
                {
                    Index start = (Index)ParseInt(startStr);
                    Index end = (Index)ParseInt(endStr);
                    range = new Range(start, end);

                    static int ParseInt(string str)
                    {
                        bool hex = str.StartsWith("0x");
                        if (hex) str = str[2..];
                        return int.Parse(str, hex ? NumberStyles.HexNumber : NumberStyles.Integer);
                    }
                }

                string? comment = enums.Attribute("comment")?.Value;

                List<EnumEntry> entries = new List<EnumEntry>();
                foreach (XElement? @enum in enums.Elements("enum"))
                {
                    entries.Add(ParseEnumEntry(@enum));
                }

                enumsEntries.Add(new Enums(@namespace, group, type, vendor, range, comment, entries));
            }

            return enumsEntries;

            static EnumType ParseEnumsType(string? value) => value switch
            {
                null or "" => EnumType.None,
                "bitmask" => EnumType.Bitmask,
                _ => EnumType.Invalid,
            };
        }

        public static EnumEntry ParseEnumEntry(XElement @enum)
        {
            string? name = @enum.Attribute("name")?.Value;
            string? valueStr = @enum.Attribute("value")?.Value;
            if (valueStr == null || name == null)
            {
                throw new Exception($"Enum {name} did not pass correctly");
            }

            TypeSuffix suffix = ParseEnumTypeSuffix(@enum.Attribute("type")?.Value);

            ulong value = ConvertToUInt64(valueStr, suffix);

            string? alias = @enum.Attribute("alias")?.Value;

            string[] groups = @enum.Attribute("group")?.Value?.Split(',', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

            string? comment = @enum.Attribute("comment")?.Value;

            GLAPI api = ParseApi(@enum.Attribute("api")?.Value);

            return new EnumEntry(name, api, value, alias, comment, groups, suffix);

            static TypeSuffix ParseEnumTypeSuffix(string? suffix) => suffix switch
            {
                null or "" => TypeSuffix.None,
                "u" => TypeSuffix.U,
                "ull" => TypeSuffix.Ull,
                _ => TypeSuffix.Invalid,
            };

            static ulong ConvertToUInt64(string val, TypeSuffix type) => type switch
            {
                TypeSuffix.None => (uint)(int)new Int32Converter().ConvertFromString(val),
                TypeSuffix.Ull => (ulong)(long)new Int64Converter().ConvertFromString(val),
                TypeSuffix.U => (uint)new UInt32Converter().ConvertFromString(val),
                TypeSuffix.Invalid or _ => throw new Exception($"Invalid suffix '{type}'!"),
            };
        }


        public static List<Feature> ParseFeatures(XElement input)
        {
            Logger.Info("Begining parsing of features.");

            List<Feature> features = new List<Feature>();

            foreach (XElement? feature in input.Elements("feature"))
            {
                string? apiStr = feature.Attribute("api")?.Value;
                string? name = feature.Attribute("name")?.Value;
                string? number = feature.Attribute("number")?.Value;

                if (apiStr == null || name == null || number == null)
                {
                    throw new Exception($"Feature '{feature}' is missing an attribute.");
                }

                Version? version = Version.Parse(number);
                GLAPI api = ParseApi(apiStr);

                List<RequireEntry> requireEntries = new List<RequireEntry>();
                foreach (XElement? require in feature.Elements("require"))
                {
                    RequireEntry reqEntry = ParseRequire(require);
                    requireEntries.Add(reqEntry);
                }

                List<RemoveEntry> removeEntries = new List<RemoveEntry>();
                foreach (XElement? remove in feature.Elements("remove"))
                {
                    RemoveEntry removeEntry = ParseRemove(remove);
                    removeEntries.Add(removeEntry);
                }

                features.Add(new Feature(api, version, name, requireEntries, removeEntries));
            }

            return features;
        }

        public static List<Extension> ParseExtensions(XElement input)
        {
            List<Extension> extensions = new List<Extension>();
            XElement? xelement = input.Element("extensions")!;

            foreach (XElement? extension in xelement.Elements("extension"))
            {
                string? extName = extension.Attribute("name")?.Value;
                if (extName == null)
                {
                    throw new Exception($"Extension '{extension}' is missing a name!");
                }

                // Remove "GL_" and get the vendor name from the first part of the extension name
                // Extension name convention: "GL_VENDOR_EXTENSION_NAME"
                string? extNameWithoutGLPrefix = NameMangler.RemoveStart(extName, "GL_");
                string? vendor = extNameWithoutGLPrefix[..extNameWithoutGLPrefix.IndexOf("_")];
                if (string.IsNullOrEmpty(vendor))
                {
                    throw new Exception($"Extension '{extension}' doesn't have the vendor in it's name!");
                }

                if (char.IsDigit(vendor[0]))
                {
                    vendor = "_" + vendor;
                }

                string? comment = extension.Attribute("comment")?.Value;

                GLAPI[]? supportedApis = extension
                    .Attribute("supported")?.Value?
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => ParseApi(s)).ToArray();

                if (supportedApis == null)
                {
                    throw new Exception($"Extension '{extension}' did not specify any supported APIs.");
                }

                List<RequireEntry> requires = new List<RequireEntry>();
                foreach (XElement? require in extension.Elements("require"))
                {
                    requires.Add(ParseRequire(require));
                }

                extensions.Add(new Extension(extName, vendor, supportedApis, comment, requires));
            }

            return extensions;
        }

        public static RequireEntry ParseRequire(XElement requires)
        {
            GLAPI api = ParseApi(requires.Attribute("api")?.Value);
            GLProfile profile = ParseProfile(requires.Attribute("profile")?.Value);
            string? comment = requires.Attribute("comment")?.Value;

            List<string> reqCommands = new List<string>();
            List<string> reqEnums = new List<string>();

            foreach (XElement? entry in requires.Elements())
            {
                // A few entries here have a comment attribute, but we don't bother with it
                string? name = entry.Attribute("name")?.Value;
                if (name == null) throw new Exception($"The entry '{entry}' didn't contain a name attribute.");

                switch (entry.Name.LocalName)
                {
                    case "command":
                        reqCommands.Add(name);
                        break;
                    case "enum":
                        reqEnums.Add(name);
                        break;
                    default:
                        continue;
                }
            }

            return new RequireEntry(api, profile, comment, reqCommands, reqEnums);
        }

        public static RemoveEntry ParseRemove(XElement requires)
        {
            GLProfile profile = ParseProfile(requires.Attribute("profile")?.Value);
            string? comment = requires.Attribute("comment")?.Value;

            List<string> removeCommands = new List<string>();
            List<string> removeEnums = new List<string>();

            foreach (XElement? entry in requires.Elements())
            {
                // A few entries here have a comment attribute, but we don't bother with it
                string? name = entry.Attribute("name")?.Value;
                if (name == null) throw new Exception($"The entry '{entry}' didn't contain a name attribute.");

                switch (entry.Name.LocalName)
                {
                    case "command":
                        removeCommands.Add(name);
                        break;
                    case "enum":
                        removeEnums.Add(name);
                        break;
                    default:
                        continue;
                }
            }

            return new RemoveEntry(profile, comment, removeCommands, removeEnums);
        }


        public static GLAPI ParseApi(string? api) => api switch
        {
            null or "" or "disabled" => GLAPI.None,

            "gl" => GLAPI.GL,
            "gles1" => GLAPI.GLES1,
            "gles2" => GLAPI.GLES2,
            "glsc2" => GLAPI.GLSC2,
            "glcore" => GLAPI.GLCore,

            _ => GLAPI.Invalid,
        };

        public static GLProfile ParseProfile(string? profile) => profile switch
        {
            null or "" => GLProfile.None,

            "core" => GLProfile.Core,
            "compatibility" => GLProfile.Compatibility,
            "common" => GLProfile.Common,

            _ => GLProfile.Invalid,
        };
    }
}
