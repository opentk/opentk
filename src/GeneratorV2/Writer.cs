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
        public static void Write(Feature[] features)
        {
            WriteProject("OpenToolkit.Graphics.csproj");
            Logger.Info("Writing features to file");

            foreach(var f in features)
            {
                WriteCommands($"{f.Name}.cs", $"{f.Api.ToUpper()}{f.Version.Major}{f.Version.Minor}", f.Commands);
            }
        }

        public static void WriteCommands(string filePath, string namespacePostfix, Dictionary<string, Command> commands)
        {
            using var stream = File.OpenWrite(filePath);
            using var streamWriter = new StreamWriter(stream);
            using var writer = new IndentedTextWriter(streamWriter);

            WriteUsings(writer);
            writer.WriteLine("namespace OpenToolkit.Graphics." + namespacePostfix);
            using (writer.Scope())
            {
                WriteDelegates(writer);
                writer.WriteLine("public unsafe static partial class GL");
                using (writer.Scope())
                {
                    foreach (var (cName, c) in commands)
                    {
                        WriteCommand(writer, c);
                    }
                }
            }
        }

        private static void WriteDelegates(IndentedTextWriter writer)
        {
            writer.WriteLine("public unsafe delegate void GLDEBUGPROC(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
            writer.WriteLine("public unsafe delegate void GLDEBUGPROCARB(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
            writer.WriteLine("public unsafe delegate void GLDEBUGPROCKHR(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
            writer.WriteLine("public unsafe delegate void GLDEBUGPROCAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);");
            writer.WriteLine("public unsafe delegate void GLDEBUGPROCNV();");
            writer.WriteLine("public struct GLsync{};");
            writer.WriteLine("public struct _cl_context{};");
            writer.WriteLine("public struct _cl_event{};");
        }

        private static void WriteUsings(IndentedTextWriter writer)
        {
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using System;");
            writer.WriteLine();
        }

        private static void WriteCommand(IndentedTextWriter writer, Command c)
        {
            writer.WriteLine($"[DllImport(\"opengl32.dll\", EntryPoint = \"{c.Method.EntryPoint}\")]");
            writer.Write($"public static extern {c.Method.ReturnType.Name} {c.Method.Name}(");

            for (int i = 0; i < c.Method.Parameters.Length; i++)
            {
                var type = c.Method.Parameters[i].Type.Name.Replace("const", "").Trim();
                writer.Write($"{type} {c.Method.Parameters[i].Name}");
                if (i != c.Method.Parameters.Length - 1)
                {
                    writer.Write(", ");
                }
            }
            writer.WriteLine(");");
            writer.WriteLine();
        }

        private static void WriteProject(string fileName)
        {
            using var stream = File.OpenWrite(fileName);
            using var streamWriter = new StreamWriter(stream);
            using var writer = new IndentedTextWriter(streamWriter);

            writer.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
            using(writer.Indentation())
            {
                writer.WriteLine("<PropertyGroup>");

                using(writer.Indentation())
                {
                    writer.WriteLine("<TargetFramework>netcoreapp3.1</TargetFramework>");
                    writer.WriteLine("<Nullable>enable</Nullable>");
                    writer.WriteLine("<RootNamespace>OpenToolkit.Graphics</RootNamespace>");
                    writer.WriteLine("<AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
        
                }

                writer.WriteLine("</PropertyGroup>");
            }
            writer.WriteLine("</Project>");
        }
    }
}
