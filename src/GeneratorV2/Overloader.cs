using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2
{
    public static class Overloader
    {
        public static void OverloadCommands(Specification spec)
        {
            foreach (var (cName, c) in spec.Commands)
            {
                OverloadEnums(c);
                OverloadAllEnum(c);
            }
        }

        //public uint BaseMethod(uint enum1, uint enum2);
        //public GLEnum Overload(GLEnum enum1, GLEnum enum2)
        //{
        //    return (GLEnum)BaseMethod((uint)enum1, (uint)enum2));
        //}
        public static void OverloadAllEnum(Command c)
        {
            var m = c.Method;
            bool ConvertEnumType(PType type, out PType overloadedType)
            {
                if (type.Group == null || !type.OriginalTypeName.Contains("GLenum"))
                {
                    overloadedType = type;
                    return false;
                }
                overloadedType = new PType(type.Name.Replace("uint", "All"), type.OriginalTypeName, type.Modifier, type.Group, type.Length);
                return true;
            }

            var sb = new StringBuilder();
            PType retType = m.ReturnType;
            bool isReturnOverload = false;
            if (m.ReturnType.Name != "void")
            {
                sb.Append("return ");
                if (ConvertEnumType(m.ReturnType, out retType))
                {
                    isReturnOverload |= true;
                    sb.Append($"({retType.Name})");
                }
            }
            sb.Append("{0}");
            sb.Append("(");
            var newParameters = new Parameter[m.Parameters.Length];
            bool isParameterOverload = false;
            for (int i = 0; i < m.Parameters.Length; i++)
            {
                var p = m.Parameters[i];
                if (ConvertEnumType(p.Type, out var type))
                {
                    isParameterOverload |= true;
                    sb.Append($"({p.Type.Name})");
                }
                sb.Append(p.Name);
                if (i != m.Parameters.Length - 1)
                {
                    sb.Append(", ");
                }

                newParameters[i] = new Parameter(type, p.Name);
            }
            sb.Append(");");

            var overloadCode = sb.ToString();

            Action<IndentedTextWriter, string> bodyWriter = (writer, commandName) =>
            {
                writer.WriteLine(string.Format(overloadCode, commandName));
            };
            var overload = new Overload(retType, bodyWriter, newParameters);
            if (isParameterOverload)
            {
                c.Overloads.Add(overload);
            }
        }

        public static void OverloadEnums(Command c)
        {
            var m = c.Method;
            bool ConvertEnumType(PType type, out PType overloadedType)
            {
                if (type.Group == null || !type.OriginalTypeName.Contains("GLenum"))
                {
                    overloadedType = type;
                    return false;
                }
                overloadedType = new PType(type.Name.Replace("uint", type.Group), type.OriginalTypeName, type.Modifier, type.Group, type.Length);
                return true;
            }

            var sb = new StringBuilder();
            PType retType = m.ReturnType;
            bool isReturnOverload = false;
            if (m.ReturnType.Name != "void")
            {
                sb.Append("return ");
                if (ConvertEnumType(m.ReturnType, out retType))
                {
                    isReturnOverload |= true;
                    sb.Append($"({retType.Name})");
                }
            }
            sb.Append("{0}");
            sb.Append("(");
            var newParameters = new Parameter[m.Parameters.Length];
            bool isParameterOverload = false;
            for (int i = 0; i < m.Parameters.Length; i++)
            {
                var p = m.Parameters[i];
                if (ConvertEnumType(p.Type, out var type))
                {
                    isParameterOverload |= true;
                    sb.Append($"({p.Type.Name})");
                }
                sb.Append(p.Name);
                if (i != m.Parameters.Length - 1)
                {
                    sb.Append(", ");
                }

                newParameters[i] = new Parameter(type, p.Name);
            }
            sb.Append(");");

            if (isReturnOverload && !isParameterOverload)
            {
                c.Method = new Method(retType, m.EntryPoint, m.Parameters);
                return;
            }

            var overloadCode = sb.ToString();

            Action<IndentedTextWriter, string> bodyWriter = (writer, commandName) =>
            {
                writer.WriteLine(string.Format(overloadCode, commandName));
            };
            var overload = new Overload(retType, bodyWriter, newParameters);
            if (isParameterOverload)
            {
                c.Overloads.Add(overload);
            }
        }
    }
}
