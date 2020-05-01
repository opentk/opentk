using System;
using System.Xml;
using System.Xml.Linq;

namespace OpenToolkit.Generator
{
    public static class Parser
    {
        public static Class Parse(in XDocument doc)
        {
            Logger.Info("Parsing spec into xml document.");

            var reg = doc.LastNode;

            Logger.Info("Parsing commands.");
            var commands = reg.sel("commands").ChildNodes;
            IMethod[] methods = new IMethod[commands.Count];
            for (int i = 0; i < commands.Count; i++)
            {
                methods[i] = ParseCommand(commands[i]);
            }

            return new Class("OpenToolkit.Graphics", "GL", methods);
        }

        public static IMethod ParseCommand(XmlNode command)
        {
            var proto = command.FirstChild;
            var strType = proto.SelectSingleNode("ptype")?.InnerText.Trim() ?? proto.FirstChild.InnerText.Trim();
            var entryPoint = proto.SelectSingleNode("name").InnerText;
            var name = entryPoint.Substring(2);

            var parameterNodes = command.SelectNodes("param");
            var parameters = new Parameter[parameterNodes.Count];
            for (int i = 0; i < parameterNodes.Count; i++)
            {
                parameters[i] = ParseParameter(parameterNodes[i]);
            }

            return new Extern("opengl32.dll", entryPoint, "", ParseType(strType), name, parameters);
        }

        public static Parameter ParseParameter(XmlNode parameter)
        {
            var pName = parameter.SelectSingleNode("name").InnerText;

            var pType = parameter.InnerText.Remove(parameter.InnerText.Length - pName.Length);
            var modifier = ParameterModifer.None;
            if (pType.StartsWith("const"))
            {
                pType = pType.Substring(6);
                modifier = ParameterModifer.In;
            }
            return new Parameter("", modifier, ParseType(pType), pName);
        }

        public static Type ParseType(string type)
        {
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
                "GLsizeiptr" => typeof(UIntPtr), //What type?
                "GLsizeiptrARB" => typeof(UIntPtr), //What type?
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
