using System;
using System.Xml;
using System.Xml.Linq;

namespace OpenToolkit.Generator
{
    public static class Parser
    {
        public static Class Parse(in string spec)
        {
            Logger.Info("Parsing spec into xml document.");

            var doc = new XmlDocument();
            doc.LoadXml(spec);
            var reg = doc.LastChild;

            Logger.Info("Parsing commands.");
            var commands = reg.SelectSingleNode("commands").ChildNodes;
            var methods = new Method[commands.Count];
            for (int i = 0; i < commands.Count; i++)
            {
                methods[i] = ParseCommand(commands[i]);
            }

            return new Class("OpenToolkit.Graphics", "GL", methods);
        }

        public static Method ParseCommand(XmlNode command)
        {
            var proto = command.FirstChild;
            var entryPoint = proto.SelectSingleNode("name").InnerText;
            var name = entryPoint.Substring(2);
            var strType = proto.InnerText.Remove(proto.InnerText.Length - entryPoint.Length).Trim();
            strType = strType.StartsWith("const ") ? strType.Substring(6) : strType;

            var parameterNodes = command.SelectNodes("param");
            var parameters = new Parameter[parameterNodes.Count];
            for (int i = 0; i < parameterNodes.Count; i++)
            {
                parameters[i] = ParseParameter(parameterNodes[i]);
            }

            (string, object) param1 = (null, "opengl32.dll");
            (string, object) param2 = ("EntryPoint", entryPoint);
            var attribute = new Attribute("System.DllImport",new[] {param1, param2});

            return new Method(new []{attribute}, ParseType(strType), name, parameters);
        }

        public static Parameter ParseParameter(XmlNode parameter)
        {
            var pName = parameter.SelectSingleNode("name").InnerText;

            var pType = parameter.InnerText.Remove(parameter.InnerText.Length - pName.Length);

            var modifier = ParameterModifer.None;

            if (pType.StartsWith("const"))
            {
                pType = pType.Substring(6);
                modifier = ParameterModifer.Const;
            }

            var attributes = new Attribute[parameter.Attributes.Count];
            for (int i = 0; i < attributes.Length; i++)
            {
                attributes[i] = new Attribute(parameter.Attributes[i].Name,
                    new (string, object)[]{(null, parameter.Attributes[i].Value)});
            }

            return new Parameter(attributes, modifier, ParseType(pType), pName);
        }

        public static Type ParseType(string type)
        {
            var pointer = 0;
            type = type.Trim();
            while (type.EndsWith("*"))
            {
                pointer++;
                type = type.Remove(type.Length - 1);
            }

            type = type.Trim();

            var t = type switch
            {
                "void" => typeof(void),
                "void *" => typeof(void *),
                "void **" => typeof(void **),
                "GLenum" => typeof(uint),
                "GLboolean" => typeof(byte),
                "GLbitfield" => typeof(uint),
                "GLvoid" => typeof(void),
                "GLbyte" => typeof(sbyte),
                "GLubyte" => typeof(byte),
                "GLshort" => typeof(short),
                "GLushort" => typeof(ushort),
                "GLint" => typeof(int),
                "GLuint" => typeof(uint),
                "GLclampx" => typeof(int),
                "GLsizei" => typeof(int),
                "GLfloat" => typeof(float),
                "GLclampf" => typeof(float),
                "GLdouble" => typeof(double),
                "GLclampd" => typeof(double),
                "GLeglClientBufferEXT" => typeof(void *),
                "GLeglImageOES" => typeof(void *),
                "GLchar" => typeof(char),
                "GLcharARB" => typeof(char),
                "*GLhandleARB" => typeof(void), //OS dependent
                "GLhandleARB" => typeof(uint), //OS dependent
                "GLhalf" => typeof(short),
                "GLhalfARB" => typeof(short),
                "GLfixed" => typeof(int),
                "GLintptr" => typeof(IntPtr),
                "GLintptrARB" => typeof(IntPtr),
                "GLsizeiptr" => typeof(UIntPtr),
                "GLsizeiptrARB" => typeof(UIntPtr),
                "GLint64" => typeof(int),
                "GLint64EXT" => typeof(int),
                "GLuint64" => typeof(uint),
                "GLuint64EXT" => typeof(uint),
                //"GLsync" => typeof(uint), //Struct
                "GLhalfNV" => typeof(ushort),
                "GLvdpauSurfaceNV" => typeof(IntPtr),
                "GLVULKANPROCNV" => typeof(void),
                _ => null
            };

            if (t == null)
            {
                Logger.Error($"Type conversion has not been created for type {type}");
            }
            else
            {
                for (int i = 0; i < pointer; i++)
                {
                    t = t.MakePointerType()
                }
            }

            return t;
        }
    }
}
