using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GeneratorV2.Parsing
{
    public class CommandParser
    {
        public Dictionary<string, Command2> Parse(XElement input)
        {
            Logger.Info("Begining parsing of commands.");
            var xelement = input.Element("commands");
            var commands = new Dictionary<string, Command2>();
            foreach (var element in xelement.Elements("command"))
            {
                var command = ParseCommand(element);
                if (command != null)
                {
                    commands.Add(command.Method.EntryPoint, command);
                }
            }

            return commands;
        }

        private static Command2 ParseCommand(XElement c)
        {
            var t = c.Element("proto");
            var name = t.Element("name").Value;
            var methodName = name[2..];
            var parameterList = new List<Parameter2>();
            foreach (var element in c.Elements("param"))
            {
                var paramName = NameMangler.MangleParameterName(element.Element("name").Value);
                var ptype = ParsePType(element);
                //isGLhandleArb |= ptype.Name == PlatformSpecificGlHandleArbFlag;
                parameterList.Add(new Parameter2(ptype, paramName));
            }
            var ptype1 = ParsePType(t);
            //isGLhandleArb |= ptype1.Name == PlatformSpecificGlHandleArbFlag;

            var method = new Method2(ptype1, name, parameterList.ToArray());
            foreach (var p in method.Parameters)
            {
                if (p.Type.Length != null)
                {
                    p.Type.Length = Evaluate(p.Type.Length, method);
                }
            }

            return new Command2(method, methodName);
        }

        public static IExpression? Evaluate(IExpression expression, Method method)
        {
            var lazy = expression as LazyEvaluatedExpression;
            if (lazy == null)
            {
                return expression;
            }
            return ParseExpression(lazy.Expression, method);
        }

        public static IExpression? Evaluate(IExpression expression, Method2 method)
        {
            throw new NotImplementedException("This should be changed completely");
        }

        private static IExpression? ParseExpression(string length, Method method)
        {
            if (length == null)
            {
                return null;
            }
            length = length.Trim();
            if (int.TryParse(length, out var val))
            {
                return new Constant(val);
            }
            var str = length.Split('*', 2);
            if (str.Length == 2)
            {
                var left = ParseExpression(str[0], method);
                var right = ParseExpression(str[1], method);
                if (left == null || right == null)
                {
                    Logger.Warning("Error in parsing binary operation expression for length of " + method.EntryPoint);
                    return null;
                }
                return new BinaryOperation(left, '*', right);
            }
            int sInd = length.IndexOf("COMPSIZE(");
            if (sInd != -1)
            {
                sInd =  sInd + "COMPSIZE(".Length;
                int eInd = length.IndexOf(')', sInd);

                if (eInd == -1)
                {
                    Logger.Warning("PType parsing: Missing closing bracket for 'COMPSIZE('.");
                    return null;
                }
                var openingBracket = length.IndexOf('(', sInd);
                if (openingBracket != -1 && openingBracket < eInd)
                {
                    Logger.Warning("PType parsing: Nested brackets not supported.");
                    return null;
                }
                var subStr = length.Substring(sInd, eInd - sInd);
                var parameters = subStr.Split(',');
                var parsedParameter = new IExpression?[string.IsNullOrEmpty(subStr) ? 0 : parameters.Length];
                for (int i = 0; i < parsedParameter.Length; i++)
                {
                    parsedParameter[i] = ParseExpression(parameters[i], method);
                }
                return new CompSize(parsedParameter);
            }

            for (int i = 0; i < length.Length; i++)
            {
                var c = length[i];
                if (i == 0 && !char.IsLetter(c) || !char.IsLetterOrDigit(c))
                {
                    Logger.Warning($"PType parsing: Not a valid parameter reference '{length}'.");
                    return null;
                }
            }

            for (int i = 0; i < method.Parameters.Length; i++)
            {
                var p = method.Parameters[i];
                if (p.Name == length)
                {
                    return new ParameterReference(i, p);
                }
            }

            Logger.Warning($"PType parsing: Cannot parse length - '{length}' is not supported.");
            return null;
        }

        private static PType2 ParsePType(XElement t)
        {
            var group = t.Attribute("group")?.Value;
            var length = t.Attribute("len")?.Value;

            var str = t.GetXmlText(element => !(element.Name == "name") ? element.Value : string.Empty).Trim();

            var pTypeLength = length == null ? null : new LazyEvaluatedExpression(length);

            return new PType2(ParseType(str), group, pTypeLength);
        }

        private static GLType ParseType(string type)
        {
            type = type.Trim();

            if (type.EndsWith(']'))
            {
                int openingBracketIndex = type.LastIndexOf('[');
                if (openingBracketIndex != -1)
                {
                    var lengthStr = type.Substring(openingBracketIndex + 1, type.Length - openingBracketIndex - 2);
                    int length = int.Parse(lengthStr);

                    var baseType = ParseType(type.Substring(0, openingBracketIndex));

                    return new GLArrayType(baseType, false, length);
                }
                else
                {
                    throw new Exception("Missmatched brackets!");
                }
            }

            if (type.EndsWith('*'))
            {
                // We are parsing a pointer type.
                var withoutAsterisk = type[0..^1].TrimEnd();

                bool @const = false;
                if (withoutAsterisk.EndsWith("const"))
                {
                    @const = true;
                    withoutAsterisk = withoutAsterisk[0..^"const".Length];
                }
                else if (withoutAsterisk.StartsWith("const"))
                {
                    @const = true;
                    withoutAsterisk = withoutAsterisk["const".Length..];
                }

                var baseType = ParseType(withoutAsterisk);

                return new GLPointerType(baseType, @const);
            }

            // This is needed for _cl_context, and _cl_event
            // We don't care about struct here because it doesn't add any information (we are not a c compiler).
            if (type.StartsWith("struct"))
            {
                return ParseType(type["struct".Length..]);
            }

            PrimitiveType primitiveType = type switch
            {
                "void" => PrimitiveType.Void,
                "GLenum" => PrimitiveType.Uint,
                "GLboolean" => PrimitiveType.Byte,
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
                "GLchar" => PrimitiveType.Byte,
                "GLcharARB" => PrimitiveType.Byte,
                "GLhalf" => PrimitiveType.Short,
                "GLhalfARB" => PrimitiveType.Short,
                "GLfixed" => PrimitiveType.Int,
                "GLintptr" => PrimitiveType.IntPtr,
                "GLintptrARB" => PrimitiveType.IntPtr,
                "GLsizeiptr" => PrimitiveType.IntPtr,
                "GLsizeiptrARB" => PrimitiveType.IntPtr,
                "GLint64" => PrimitiveType.Int,
                "GLint64EXT" => PrimitiveType.Int,
                "GLuint64" => PrimitiveType.Uint,
                "GLuint64EXT" => PrimitiveType.Uint,
                "GLhalfNV" => PrimitiveType.Ushort,
                "GLvdpauSurfaceNV" => PrimitiveType.IntPtr,
                "GLVULKANPROCNV" => PrimitiveType.Void,

                "GLhandleARB" => PrimitiveType.GLHandleARB, //This type is platform specific on apple.

                //The following have a custom c# implementation in the writer.
                "GLsync" => PrimitiveType.GLSync,
                "_cl_context" => PrimitiveType.CLContext,
                "_cl_event" => PrimitiveType.CLEvent,
                "GLDEBUGPROC" => PrimitiveType.GLDEBUGPROC,
                "GLDEBUGPROCARB" => PrimitiveType.GLDEBUGPROCARB,
                "GLDEBUGPROCKHR" => PrimitiveType.GLDEBUGPROCKHR,
                "GLDEBUGPROCAMD" => PrimitiveType.GLDEBUGPROCAMD,
                "GLDEBUGPROCNV" => PrimitiveType.GLDEBUGPROCNV,
                _ => PrimitiveType.Invalid,
            };

            if (primitiveType == PrimitiveType.Invalid)
            {
                Logger.Error($"Type conversion has not been created for type {type}");
                throw new Exception();
            }

            return new GLBaseType(type, primitiveType, false);
        }
    }
}
