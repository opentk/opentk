using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using GeneratorV2.Parsing;

namespace GeneratorV2
{
    public static class Writer
    {
        public static void Write(Specification spec)
        {
            var folderPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "..", "..", "..", "..", "OpenToolkit.Graphics");

            if (Directory.Exists(folderPath))
            {
                Directory.Delete(folderPath, true);
            }
            Directory.CreateDirectory(folderPath);
            WriteProject(Path.Combine(folderPath, "OpenToolkit.Graphics.csproj"));

            WriteDelegates(Path.Combine(folderPath, "Types.cs"));

            foreach (var (apiName, api) in spec.Apis)
            {
                WriteApi(api, folderPath);
            }
        }

        private static void WriteApi(Api api, string folderPath)
        {
            Logger.Info("Writing features to file");
            folderPath = Path.Combine(folderPath, api.Name);
            if (!Directory.Exists(folderPath)) //TODO: Move to a function
            {
                Directory.CreateDirectory(folderPath);
            }
            foreach (var f in api.Features)
            {
                WriteFeatures(folderPath, f);
            }

            Logger.Info("Writing extensions to files");
            Directory.CreateDirectory(Path.Combine(folderPath, "Extensions"));
            foreach (var (vendor, extension) in api.Extensions)
            {
                WriteExtensions(folderPath, api.Name, vendor, extension);
            }

            WriteAllEnum(folderPath, api.Name, api.AllEnum);
        }

        public static void WriteAllEnum(string folderPath, string api, EnumEntryCollection enums)
        {
            using var stream = new FileStream(Path.Combine(folderPath, "All.cs"), FileMode.Create);
            using var streamWriter = new StreamWriter(stream);
            using var writer = new IndentedTextWriter(streamWriter);

            var allEnum = enums.Where(x => x.Value.Value <= uint.MaxValue).Select(x => x.Value).ToHashSet();
            writer.WriteLine($"namespace OpenToolkit.Graphics.Open{api.ToUpper()}");
            using (writer.Scope())
            {
                WriteEnumGroup(writer, "All", allEnum);
            }
        }

        public static void WriteExtensionBaseDocument(string filePath, string api, string vendor, List<Extension> extensions, Action<IndentedTextWriter, Extension> extensionBodyWriter)
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
                    foreach (var ext in extensions)
                    {
                        writer.WriteLine($"public unsafe static partial class {ext.Name}");
                        using (writer.Scope())
                        {
                            extensionBodyWriter(writer, ext);
                        }
                    }
                }
            }
        }

        public static void WriteExtensions(string folderPath, string api, string vendor, List<Extension> extensions)
        {
            folderPath = Path.Combine(folderPath, "Extensions", vendor);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            WriteExtensionBaseDocument(Path.Combine(folderPath, $"Methods.cs"), api, vendor, extensions,
                    (writer, ext) => {
                        foreach (var (cName, c) in ext.Commands)
                        {
                            WriteCommand(writer, c);
                        }
                    });
            WriteExtensionBaseDocument(Path.Combine(folderPath, $"Overloads.cs"), api, vendor, extensions,
                    (writer, ext) => {
                        foreach (var (cName, c) in ext.Commands)
                        {
                            foreach (var o in c.Overloads)
                            {
                                WriteOverload(writer, o, c.Name);
                            }
                        }
                    });
            WriteExtensionBaseDocument(Path.Combine(folderPath, $"Enums.cs"), api, vendor, extensions,
                    (writer, ext) => {
                        if (ext.EnumEntries.Count != 0)
                        {
                            WriteEnumGroups(writer, ext.EnumGroups);
                        }
                    });
        }

        public static void WriteFeatures(string folderPath, Feature feature)
        {
            folderPath = Path.Combine(folderPath, "versions", "V" + feature.Version.Major.ToString() + feature.Version.Minor.ToString());
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var namespacePostfix = $"Open{feature.Api.ToUpper()}.V{feature.Version.Major}{feature.Version.Minor}";
            WriteCommands(Path.Combine(folderPath, $"GL.Methods.cs"), namespacePostfix , feature.Commands);

            WriteEnumGroups(Path.Combine(folderPath, $"Enums.cs"), namespacePostfix, feature.EnumGroups);

            WriteOverloads(Path.Combine(folderPath, $"GL.Overloads.cs"), namespacePostfix, feature.Commands);
        }

        public static void WriteOverloads(string filePath, string namespacePostfix, Dictionary<string, Command> commands)
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
                    {
                        foreach (var o in c.Overloads)
                        {
                            WriteOverload(writer, o, c.Name);
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
                    {
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
                    writer.WriteLine("public static implicit operator uint(GLhandleARB val) => val._value1;");
                    writer.WriteLine("public static implicit operator IntPtr(GLhandleARB val) => val._value2;");
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

        public static void WriteEnumGroups(string filePath, string namespacePostfix, Dictionary<string, HashSet<EnumEntry>> enumGroups)
        {
            using var stream = new FileStream(filePath, FileMode.Create);
            using var streamWriter = new StreamWriter(stream);
            using var writer = new IndentedTextWriter(streamWriter);

            writer.WriteLine("namespace OpenToolkit.Graphics." + namespacePostfix);
            using (writer.Scope())
            {
                WriteEnumGroups(writer, enumGroups);
            }
        }

        private static void WriteEnumGroups(IndentedTextWriter writer, Dictionary<string, HashSet<EnumEntry>> enumGroups)
        {
            foreach (var (groupName, group) in enumGroups)
            {
                if (groupName == "SpecialNumbers")
                {
                    WriteEnumClass(writer, groupName, group);
                }
                else
                {
                    WriteEnumGroup(writer, groupName, group);
                }
            }
        }

        public static void WriteEnumClass(IndentedTextWriter writer, string groupName, HashSet<EnumEntry> group)
        {
            writer.WriteLine($"public static class {groupName}");
            using (writer.Scope())
            {
                var groupEnumerator = group.GetEnumerator();
                var hasNext = groupEnumerator.MoveNext();
                do
                {
                    var curEntry = groupEnumerator.Current;
                    hasNext = groupEnumerator.MoveNext();
                    var type = curEntry.Value > uint.MaxValue ? "ulong" : "uint";
                    writer.WriteLine($"public const {type} {curEntry.MangledName} = 0x{curEntry.Value:X};");
                } while (hasNext);
            }
        }

        public static void WriteEnumGroup(IndentedTextWriter writer, string groupName, HashSet<EnumEntry> group)
        {
            writer.WriteLine($"public enum {groupName} : uint");
            using (writer.Scope())
            {
                var groupEnumerator = group.GetEnumerator();
                var hasNext = groupEnumerator.MoveNext();
                do
                {
                    var curEntry = groupEnumerator.Current;
                    hasNext = groupEnumerator.MoveNext();
                    writer.WriteLine($"{curEntry.MangledName} = 0x{curEntry.Value:X}{ (hasNext ? "," : string.Empty)}");
                } while(hasNext);
            }
        }

        private static void WriteCommand(IndentedTextWriter writer, Command c)
        {
            if (c.IsHandleArb)
            {
                var handle = (HandleARBCommand)c;
                WriteMethod(writer, handle.Apple, $"__APPLE_{c.Name}");
                WriteMethod(writer, handle.Method, $"__GOOD_{c.Name}");
                WriteOverload(writer, handle.BaseOverload, c.Name);
                return;
            }

            WriteMethod(writer, c.Method, c.Name);
        }

        private static void WriteOverload(IndentedTextWriter writer, Overload o, string name)
        {
            writer.Write($"public static {o.ReturnType.Name} {name}(");

            for (var i = 0; i < o.Parameters.Length; i++)
            {
                var parameter = o.Parameters[i];
                var type = parameter.Type.Name.Replace("const", "").Trim();
                writer.Write($"{type} {parameter.Name}");
                if (i != o.Parameters.Length - 1)
                {
                    writer.Write(", ");
                }
            }
            writer.WriteLine(")");
            using(writer.Scope())
            {
                o.BodyWriter(writer, name);
            }
            writer.WriteLine();
        }

        private static void WriteMethod(IndentedTextWriter writer, Method m, string name)
        {
            writer.WriteLine($"[DllImport(\"opengl32.dll\", EntryPoint = \"{m.EntryPoint}\")]");
            writer.Write($"public static extern {m.ReturnType.Name} {name}(");

            for (var i = 0; i < m.Parameters.Length; i++)
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
