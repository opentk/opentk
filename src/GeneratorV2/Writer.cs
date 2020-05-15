using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Reflection;
using System.Threading;
using System.Runtime.InteropServices;

namespace GeneratorV2
{
    public static class Writer
    {
        public static void Write(Feature[] features, Dictionary<(string api, string vendor), Extension[]> extensions)
        {
            string folderPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "..", "..", "..", "..", "OpenToolkit.Graphics");

            if (Directory.Exists(folderPath))
            {
                Directory.Delete(folderPath, true);
            }
            Directory.CreateDirectory(folderPath);
            WriteProject(Path.Combine(folderPath, "OpenToolkit.Graphics.csproj"));
            Logger.Info("Writing features to file");

            WriteDelegates(Path.Combine(folderPath, "Types.cs"));

            foreach(var f in features)
            {
                WriteCommands(Path.Combine(folderPath, $"{f.Name}.cs"), $"{f.Api.ToUpper()}{f.Version.Major}{f.Version.Minor}", f.Commands);
            }

            Logger.Info("Writing extensions to files");
            Directory.CreateDirectory(Path.Combine(folderPath,"Extensions"));
            foreach(var (k, v) in extensions)
            {
                if (!Directory.Exists(Path.Combine(folderPath, "Extensions", k.api)))
                {
                    Directory.CreateDirectory(Path.Combine(folderPath, "Extensions",k.api));
                }
                WriteExtensions(Path.Combine(folderPath, "Extensions", k.api, $"{k.vendor}.cs"), k.api, k.vendor, v);
            }
        }

        public static void WriteExtensions(string filePath, string api, string vendor, Extension[] extensions)
        {
            using var stream = new FileStream(filePath, FileMode.Create);
            using var streamWriter = new StreamWriter(stream);
            using var writer = new IndentedTextWriter(streamWriter);

            WriteUsings(writer);
            writer.WriteLine($"namespace OpenToolkit.Graphics.Open{api.ToUpper()}.Extensions");
            using (writer.Scope())
            {
                writer.WriteLine($"public static partial class {vendor}");
                using (writer.Scope())
                {
                    foreach(var ext in extensions)
                    {
                        writer.WriteLine($"public unsafe static partial class {ext.Name}");
                        using (writer.Scope())
                        {
                            foreach (var (cName, c) in ext.Commands)
                            {
                                WriteCommand(writer, c);
                            }
                        }
                    }
                }
            }
        }

        public static void WriteCommands(string filePath, string namespacePostfix, Dictionary<string, Command> commands)
        {
            using var stream = new FileStream(filePath, FileMode.Create);
            using var streamWriter = new StreamWriter(stream);
            using var writer = new IndentedTextWriter(streamWriter);

            WriteUsings(writer);
            writer.WriteLine("namespace OpenToolkit.Graphics." + namespacePostfix);
            using (writer.Scope())
            {
                writer.WriteLine("public unsafe static partial class GL");
                using (writer.Scope())
                {
                    foreach (var (cName, c) in commands)
                    {t
                        WriteCommand(writer, c);
                    }
                }
            }
        }

        private static void WriteDelegates(string filePath)
        {
            using var stream = new FileStream(filePath, FileMode.Create);
            using var streamWriter = new StreamWriter(stream);
            using var writer = new IndentedTextWriter(streamWriter);

            WriteUsings(writer);
            writer.WriteLine("namespace OpenToolkit.Graphics.Types");
            using (writer.Scope())
            {
                writer.WriteLine("public unsafe delegate void GLDEBUGPROC(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
                writer.WriteLine("public unsafe delegate void GLDEBUGPROCARB(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
                writer.WriteLine("public unsafe delegate void GLDEBUGPROCKHR(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
                writer.WriteLine("public unsafe delegate void GLDEBUGPROCAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);");
                writer.WriteLine("public unsafe delegate void GLDEBUGPROCNV();");
                writer.WriteLine("public struct GLsync{};");
                writer.WriteLine("public struct CLContext{};");
                writer.WriteLine("public struct CLEvent{};");

                //GLhandleArb
                writer.WriteLine("public struct GLhandleARB");
                using (writer.Scope())
                {
                    writer.WriteLine("private readonly uint _value1;");
                    writer.WriteLine("private readonly IntPtr _value2;");
                    writer.WriteLine("public GLhandleARB(uint val)");
                    using (writer.Scope())
                    {
                        writer.WriteLine("_value2 = IntPtr.Zero;");
                        writer.WriteLine("_value1 = val;");
                    }
                    writer.WriteLine("public GLhandleARB(IntPtr val)");
                    using (writer.Scope())
                    {
                        writer.WriteLine("_value1 = 0;");
                        writer.WriteLine("_value2 = val;");
                    }
                    writer.WriteLine("public static implicit operator GLhandleARB(uint val) => new GLhandleARB(val);");
                    writer.WriteLine("public static implicit operator GLhandleARB(IntPtr val) => new GLhandleARB(val);");
                }
            }
        }

        private static void WriteUsings(IndentedTextWriter writer)
        {
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using System;");
            writer.WriteLine("using OpenToolkit.Graphics.Types;");
            writer.WriteLine();
        }

        private static void WriteCommand(IndentedTextWriter writer, Command c)
        {
            if (c.IsHandleArb)
            {
                var handle = (HandleARBCommand)c;
                WriteMethod(writer, handle.Apple, $"__APPLE_{c.Name}");
                WriteMethod(writer, handle.Method, $"__GOOD_{c.Name}");
                //TODO: Write overload
                return;
            }

            WriteMethod(writer, c.Method, c.Name);
        }

        private static void WriteMethod(IndentedTextWriter writer, Method m, string name)
        {
            writer.WriteLine($"[DllImport(\"opengl32.dll\", EntryPoint = \"{m.EntryPoint}\")]");
            writer.Write($"public static extern {m.ReturnType.Name} {name}(");

            for (int i = 0; i < m.Parameters.Length; i++)
            {
                var parameter = m.Parameters[i];
                var type = parameter.Type.Name.Replace("const", "").Trim();
                writer.Write($"{type} {parameter.Name}");
                if (i != m.Parameters.Length - 1)
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
