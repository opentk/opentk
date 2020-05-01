using System;
using System.Xml;

namespace OpenToolkit.Generator
{
    public static class Parser
    {
        public static Class Parse(string spec)
        {
            Logger.Info("Parsing spec into xml document.");

            var doc = new XmlDocument();
            doc.LoadXml(spec);
            var reg = doc.LastChild;

            Logger.Info("Parsing commands.");
            var commands = reg.SelectSingleNode("commands").ChildNodes;
            Method[] methods = new Method[commands.Count];
            for (int i = 0; i < commands.Count; i++)
            {
                methods[i] = ParseCommand(commands[i]);
            }

            return new Class("OpenToolkit.Graphics", "GL", methods);
        }

        public static Method ParseCommand(XmlNode command)
        {
            var proto = command.FirstChild;
            var strType = proto.SelectSingleNode("ptype")?.InnerText.Trim() ?? proto.FirstChild.InnerText.Trim();
            var name = proto.SelectSingleNode("name").InnerText.Substring(2);

            var parameterNodes = command.SelectNodes("param");
            var parameters = new Parameter[parameterNodes.Count];
            for (int i = 0; i < parameterNodes.Count; i++)
            {
                var pName = parameterNodes[i].SelectSingleNode("name").InnerText;

                var pType = parameterNodes[i].SelectSingleNode("ptype")?.InnerText ?? parameterNodes[i].FirstChild.InnerText;
                parameters[i] = new Parameter("", StringToType(pType), pName);
            }

            return new Method("", StringToType(strType), name, parameters);
        }

        public static Type StringToType(string type)
        {
            type = type.StartsWith("const") ? type.Substring(6) : type;
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
                "*GLhandleARB" => typeof(void),
                "GLhandleARB" => typeof(uint),
                "GLhalf" => typeof(short),
                "GLhalfARB" => typeof(short),
                "GLfixed" => typeof(int),
                "GLintptr" => typeof(IntPtr),
                "GLintptrARB" => typeof(IntPtr),
                "GLsizeiptr" => typeof(uint), //What type?
                "GLsizeiptrARB" => typeof(uint), //What type?
                "GLint64" => typeof(int),
                "GLint64EXT" => typeof(int),
                "GLuint64" => typeof(uint),
                "GLuint64EXT" => typeof(uint),
                "GLsync" => typeof(uint), //What type
                "GLhalfNV" => typeof(ushort),
                "GLvdpauSurfaceNV" => typeof(IntPtr),
                "GLVULKANPROCNV" => typeof(void),
                _ => null
            };

            if (t == null)
            {
                Logger.Error($"Type conversion has not been created for type {type}");
            }

            return t;
        }
    }
}
