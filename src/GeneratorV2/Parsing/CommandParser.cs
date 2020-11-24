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
        public static Dictionary<string, Command2> Parse(XElement input)
        {
            Logger.Info("Begining parsing of commands.");
            var xelement = input.Element("commands")!;

            var commands = new Dictionary<string, Command2>();
            foreach (var element in xelement.Elements("command"))
            {
                var command = ParseCommand(element);
                commands.Add(command.Method.EntryPoint, command);
            }

            return commands;
        }

        private static Command2 ParseCommand(XElement c)
        {
            var proto = c.Element("proto");
            if (proto == null) throw new Exception("Missing proto tag!");

            var name = proto.Element("name")?.Value;
            if (name == null) throw new Exception("Missing name tag!");

            var parameterList = new List<Parameter2>();
            foreach (var element in c.Elements("param"))
            {
                var paramName = element.Element("name")?.Value;
                var ptype = ParsePType(element);

                if (paramName == null) throw new Exception("Missing parameter name!");

                //isGLhandleArb |= ptype.Name == PlatformSpecificGlHandleArbFlag;
                parameterList.Add(new Parameter2(ptype, paramName));
            }

            var returnType = ParsePType(proto);

            var method = new Method2(returnType, name, parameterList.ToArray());

            // TODO: We can skip the Command class and just use Method directly.
            return new Command2(method, name);
        }

        private static IExpression ParseExpression(string expression)
        {
            var retExpr = ParseExpressionPrio2(expression, out string leftOver);

            if (string.IsNullOrEmpty(leftOver) == false)
                throw new Exception($"Failed to parse expression '{expression}' with leftover '{leftOver}'");

            return retExpr;
        }

        private static IExpression ParseExpressionPrio2(string expression, out string leftOver)
        {
            var retExpr = ParseExpressionPrio1(expression, out string exp);
            exp = exp.TrimStart();

            BinaryOperator op;
            while ((op = GetOperation(exp)) != BinaryOperator.Invalid)
            {
                exp = exp[1..];
                var right = ParseExpressionPrio1(exp, out exp);
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

        private static IExpression ParseExpressionPrio1(string expression, out string leftOver)
        {
            var retExpr = ParseExpressionPrio0(expression, out string exp);
            exp = exp.TrimStart();

            BinaryOperator op;
            while ((op = GetOperation(exp)) != BinaryOperator.Invalid)
            {
                exp = exp[1..];
                var right = ParseExpressionPrio0(exp, out exp);
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
                    '%' => BinaryOperator.Modulo,
                    _ => BinaryOperator.Invalid,
                };
            }
        }

        private static IExpression ParseExpressionPrio0(string expression, out string leftOver)
        {
            expression = expression.TrimStart();
            if (expression.StartsWith("COMPSIZE("))
            {
                var exp = expression["COMPSIZE(".Length..];
                List<IExpression> arguments = new List<IExpression>();
                while (exp[0] != ')')
                {
                    arguments.Add(ParseExpressionPrio2(exp, out exp));

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
            else
            {
                if (char.IsLetter(expression[0]))
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
        }

        private static PType2 ParsePType(XElement t)
        {
            var group = t.Attribute("group")?.Value;
            var length = t.Attribute("len")?.Value;

            var str = t.GetXmlText(element => !(element.Name == "name") ? element.Value : string.Empty).Trim();

            var pTypeLength = length == null ? null : ParseExpression(length);

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

            // FIXME: Make this a 1 to 1 map
            PrimitiveType primitiveType = type switch
            {
                "void" => PrimitiveType.Void,
                "GLenum" => PrimitiveType.Enum,
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

                // FIXME
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
