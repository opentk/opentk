using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeneratorV2
{
    public static class Writer
    {
        private static readonly (string alias, string type)[] _usings = new (string, string)[] {
            ("GLenum", "System.UInt32"),
            ("GLboolean", "System.SByte"),
            ("GLbitfield", "System.UInt32"),
            ("GLvoid", "void"),
            ("GLbyte", "System.SByte"),
            ("GLubyte", "System.Byte"),
            ("GLshort", "System.Int16"),
            ("GLushort", "System.UInt16"),
            ("GLint", "System.Int32"),
            ("GLuint", "System.UInt32"),
            ("GLclampx", "System.Int32"),
            ("GLsizei", "System.Int32"),
            ("GLfloat", "System.Single"),
            ("GLclampf", "System.Single"),
            ("GLdouble", "System.Double"),
            ("GLclampd", "System.Double"),
            ("GLeglClientBufferEXT", "void*"),
            ("GLeglImageOES", "void*"),
            ("GLchar", "System.SByte"),
            ("GLcharARB", "System.SByte"),
            ("GLhalf", "System.UInt16"),
            ("GLhalfARB", "System.UInt16"),
            ("GLfixed", "System.Int32"),
            ("GLintptr", "System.IntPtr"),
            ("GLintptrARB", "System.IntPtr"),
            ("GLsizeiptr", "System.IntPtr"),
            ("GLsizeiptrARB", "System.IntPtr"),
            ("GLint64", "System.Int64"),
            ("GLint64EXT", "System.Int64"),
            ("GLuint64", "System.UInt64"),
            ("GLuint64EXT", "System.UInt64"),
            ("GLsync", "#MISSING#(struct __GLsync)*"),
            ("context", "#MISSING#(struct _cl_)"),
            ("event", "#MISSING#(struct _cl_)"),
            ("GLhalfNV", "System.UInt16"),
            ("GLvdpauSurfaceNV", "System.IntPtr"),
        };

        public static void Write(Command[] commands)
        {
            using var stream = File.OpenWrite("Gl.methods.cs");
            using var streamWriter = new StreamWriter(stream);
            using var writer = new IndentedTextWriter(streamWriter);

            writer.WriteLine("namespace OpenToolkit.Graphics.GL46");
            
            using (writer.Scope())
            {
                WriteUsings(writer);
                writer.WriteLine("public static partial class GL");
                using (writer.Scope())
                {
                    foreach (var c in commands)
                    {
                        WriteCommand(writer, c);
                    }
                }
            }
        }

        private static void WriteUsings(IndentedTextWriter writer)
        {
            foreach (var (alias, type) in _usings)
            {
                writer.WriteLine($"using {alias} = {type};");
            }
            writer.WriteLine();
        }

        private static void WriteCommand(IndentedTextWriter writer, Command c)
        {
            writer.WriteLine($"[DllImport(\"opengl32.dll\", EntryPoint = \"{c.Method.EntryPoint}\")]");
            writer.Write($"public static extern {c.Method.ReturnType} {c.Method.Name}(");

            for (int i = 0; i < c.Method.Parameters.Length; i++)
            {
                var type = c.Method.Parameters[i].Type.Replace("const", "").Trim();
                writer.Write($"{type} {c.Method.Parameters[i].Name}");
                if (i != c.Method.Parameters.Length - 1)
                {
                    writer.Write(", ");
                }
            }
            writer.WriteLine(");");
            writer.WriteLine();
        }
    }
}
