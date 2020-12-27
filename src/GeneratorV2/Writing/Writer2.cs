using GeneratorV2.Data;
using GeneratorV2.Writing2;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GeneratorV2.Writing
{
    class Writer2
    {
        // FIXME: Find a better place
        public struct CsScope : IDisposable
        {
            public IndentedTextWriter.Scope Scope;

            public CsScope(IndentedTextWriter.Scope scope)
            {
                Scope = scope;
            }

            public void Dispose()
            {
                Scope.Dispose();
                Scope.Writer.WriteLine("}");
            }
        }

        // FIXME: Find a better place
        // Utility for opening a "{ }" scope for C# code.
        public static CsScope Scope(IndentedTextWriter writer)
        {
            writer.WriteLine("{");
            return new CsScope(writer.Indentation());
        }

        public static void Write(OutputData data)
        {
            string outputProjectPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new NullReferenceException(),
                "..", "..", "..", "..", "OpenToolkit.Graphics");

            // FIXME: Delete existing if there is one
            try { Directory.Delete(outputProjectPath, true); } catch { }
            Directory.CreateDirectory(outputProjectPath);

            // NAMESPACE:
            WriteProjectFile(outputProjectPath, "OpenToolkit.Graphics");

            WriteBindingsLoader(outputProjectPath);

            WriteBuiltInTypes(outputProjectPath);

            string glFolder = Path.Combine(outputProjectPath, "OpenGL");

            // This should create folders to put the projects in
            foreach (var version in data.Versions)
            {
                string versionPath = Path.Combine(glFolder, version.Version);

                Directory.CreateDirectory(versionPath);

                WriteNativeFunctions(versionPath, version.Version, version.Functions);

                WriteEnums(versionPath, version.Version, version.EnumGroups, version.AllEnums);
            }
        }

        public static void WriteProjectFile(string projectPath, string rootNamespace)
        {
            // FIXME: Get the name from somewhere?
            using var writer = new IndentedTextWriter(Path.Combine(projectPath, "OpenToolkit.Graphics.csproj"));

            writer.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
            using (writer.Indentation())
            {
                writer.WriteLine("<!-- This file is auto generated, do not edit -->");

                writer.WriteLine("<PropertyGroup>");

                using (writer.Indentation())
                {
                    writer.WriteLine("<TargetFramework>net5.0</TargetFramework>");
                    writer.WriteLine("<Nullable>enable</Nullable>");
                    writer.WriteLine($"<RootNamespace>{rootNamespace}</RootNamespace>");
                    writer.WriteLine("<AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
                    writer.WriteLine("<PackageVersion>5.0.0-pre0.0</PackageVersion>");
                    writer.WriteLine("<Version>5.0.0</Version>");
                }

                writer.WriteLine("</PropertyGroup>");

                writer.WriteLine("<ItemGroup>");

                using (writer.Indentation())
                {
                    writer.WriteLine("<ProjectReference Include=\"../OpenToolkit.Core/OpenToolkit.Core.csproj\" />");
                    writer.WriteLine("<ProjectReference Include=\"../OpenToolkit.Mathematics/OpenToolkit.Mathematics.csproj\" />");
                }

                writer.WriteLine("</ItemGroup>");
            }
            writer.WriteLine("</Project>");
        }

        // FIXME: Maybe this file shouldn't be generated?
        const string LoaderClass = "GLLoader";
        const string LoaderBindingsContext = LoaderClass + ".BindingsContext";
        public static void WriteBindingsLoader(string projectPath)
        {
            using var writer = new IndentedTextWriter(Path.Combine(projectPath, $"{LoaderClass}.cs"));
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            // NAMESPACE:
            writer.WriteLine("namespace OpenToolkit.Graphics.OpenGL");
            using (Scope(writer))
            {
                writer.WriteLine($"public unsafe static class {LoaderClass}");
                using (Scope(writer))
                {
                    writer.WriteLine("internal static object LockObj = new object();");
                    writer.WriteLine("private static IBindingsContext? _bindingsContext;");
                    writer.WriteLine("internal static IBindingsContext BindingsContext => _bindingsContext ?? throw new Exception(\"Bindings not loaded, load with GLLoader.LoadBindings\");");
                    writer.WriteLine("public static void LoadBindings(IBindingsContext c) => _bindingsContext = c;");
                }
            }
        }

        // FIXME: Maybe this file shouldn't be generated?
        public static void WriteBuiltInTypes(string projectPath)
        {
            using var writer = new IndentedTextWriter(Path.Combine(projectPath, "Types.cs"));
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine();
            // NAMESPACE:
            writer.WriteLine("namespace OpenToolkit.Graphics.OpenGL");
            using (Scope(writer))
            {
                // FIXME: We might want to change back to GLDEBUGPROC and provide a nicer wrapper for it.
                writer.WriteLine("public unsafe delegate void GLDebugProc(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
                writer.WriteLine("public unsafe delegate void GLDebugProcARB(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
                writer.WriteLine("public unsafe delegate void GLDebugProcKHR(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);");
                writer.WriteLine("public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);");
                writer.WriteLine("public unsafe delegate void GLDebugProcNV();");
                writer.WriteLine();
                writer.WriteLine("public struct CLContext{}");
                writer.WriteLine("public struct CLEvent{}");
                writer.WriteLine();
                writer.WriteLine("public struct GLSync{}");
                writer.WriteLine("public unsafe struct GLSyncObject");
                using (Scope(writer))
                {
                    writer.WriteLine("internal GLSync* ObjPtr;");
                    writer.WriteLine("internal GLSyncObject(GLSync* syncObject)");
                    writer.WriteLine();
                    using (Scope(writer))
                    {
                        writer.WriteLine("ObjPtr = syncObject;");
                    }
                    writer.WriteLine();
                    writer.WriteLine("public static implicit operator GLSync*(GLSyncObject obj) => obj.ObjPtr;");
                    writer.WriteLine("public static implicit operator GLSyncObject(GLSync* obj) => new GLSyncObject(obj);");
                }
                writer.WriteLine();

                //GLHandleArb
                writer.WriteLine("[StructLayout(LayoutKind.Explicit)]");
                writer.WriteLine("public struct GLHandleARB");
                using (Scope(writer))
                {
                    writer.WriteLine("[FieldOffset(0)] private readonly uint _value1;");
                    writer.WriteLine("[FieldOffset(0)] private readonly IntPtr _value2;");
                    writer.WriteLine();
                    writer.WriteLine("public GLHandleARB(uint val)");
                    using (Scope(writer))
                    {
                        writer.WriteLine("_value2 = IntPtr.Zero;");
                        writer.WriteLine("_value1 = val;");
                    }
                    writer.WriteLine();
                    writer.WriteLine("public GLHandleARB(IntPtr val)");
                    using (Scope(writer))
                    {
                        writer.WriteLine("_value1 = 0;");
                        writer.WriteLine("_value2 = val;");
                    }
                    writer.WriteLine();
                    writer.WriteLine("public static implicit operator GLHandleARB(uint val) => new GLHandleARB(val);");
                    writer.WriteLine("public static implicit operator GLHandleARB(IntPtr val) => new GLHandleARB(val);");
                    writer.WriteLine("public static implicit operator uint(GLHandleARB val) => val._value1;");
                    writer.WriteLine("public static implicit operator IntPtr(GLHandleARB val) => val._value2;");
                }
            }
        }

        public static void WriteNativeFunctions(string directoryPath, string version, List<NativeFunction> nativeFunctions)
        {
            using IndentedTextWriter writer = new IndentedTextWriter(Path.Combine(directoryPath, "GL.cs"));
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            // NAMESPACE:
            writer.WriteLine($"namespace OpenToolkit.Graphics.OpenGL.{version}");
            using (Scope(writer))
            {
                writer.WriteLine($"public static unsafe partial class GL");
                using (Scope(writer))
                {
                    // Write delegate field initialized to the lazy loader.
                    // Write public function definition that calls delegate.
                    // Write lazy loader function.
                    StringBuilder paramNames = new StringBuilder();
                    StringBuilder delegateTypes = new StringBuilder();
                    StringBuilder signature = new StringBuilder();
                    foreach (var function in nativeFunctions)
                    {
                        // Remove the "gl" prefix.
                        string name = function.EntryPoint[2..];

                        paramNames.Clear();
                        delegateTypes.Clear();
                        signature.Clear();

                        for (int i = 0; i < function.Parameters.Count; i++)
                        {
                            var param = function.Parameters[i];

                            paramNames.Append(param.Name);
                            string type = param.Type.ToCSString();
                            delegateTypes.Append(type);
                            signature.Append($"{type} {param.Name}");

                            // If we are adding more types, append a ", "
                            if (i + 1 < function.Parameters.Count)
                            {
                                paramNames.Append(", ");
                                signature.Append(", ");
                            }

                            delegateTypes.Append(", ");
                        }

                        string returnType = function.ReturnType.ToCSString();

                        delegateTypes.Append(returnType);

                        writer.WriteLine($"private static delegate*<{delegateTypes}> _{name}_fnptr = &{name}_Lazy;");

                        writer.WriteLine($"public static {returnType} {name}({signature}) => _{name}_fnptr({paramNames});");

                        writer.WriteLine($"private static {returnType} {name}_Lazy({signature})");
                        using (Scope(writer))
                        {
                            writer.WriteLine($"if (_{name}_fnptr == (delegate*<{delegateTypes}>)&{name}_Lazy)");
                            using (Scope(writer))
                            {
                                writer.WriteLine($"_{name}_fnptr = (delegate*<{delegateTypes}>){LoaderBindingsContext}.GetProcAddress(\"{function.EntryPoint}\");");
                            }

                            if (function.ReturnType is not CSVoid)
                            {
                                writer.WriteLine($"return _{name}_fnptr({paramNames});");
                            }
                            else
                            {
                                writer.WriteLine($"_{name}_fnptr({paramNames});");
                            }
                        }

                        writer.WriteLine();
                    }
                }
            }
        }

        public static void WriteEnums(string directoryPath, string version, List<EnumGroup> enumGroups, List<EnumMemberData> allEnums)
        {
            // FIXME: Disable CA1069
            string path = Path.Combine(directoryPath, "Enums.cs");
            using IndentedTextWriter writer = new IndentedTextWriter(path);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            // NAMESPACE:
            writer.WriteLine($"namespace OpenToolkit.Graphics.OpenGL.{version}");
            using (Scope(writer))
            {
                WriteEnumGroups(writer, enumGroups);
                WriteAllEnum(writer, allEnums);
            }
        }

        public static void WriteEnumGroups(IndentedTextWriter writer, List<EnumGroup> enumGroups)
        {
            foreach (var group in enumGroups)
            {
                if (group.IsFlags) writer.WriteLine($"[Flags]");
                writer.WriteLine($"public enum {group.Name} : uint");
                using (Scope(writer))
                {
                    foreach (var member in group.Members)
                    {
                        writer.WriteLine($"{member.Name} = {member.Value},");
                    }
                }
            }
        }

        public static void WriteAllEnum(IndentedTextWriter writer, List<EnumMemberData> allEnums)
        {
            writer.WriteLine($"public enum All : uint");
            using (Scope(writer))
            {
                foreach (var member in allEnums)
                {
                    // FIXME: We probably shouldn't get these values inside of this list...
                    if (member.Value > uint.MaxValue)
                        continue;

                    writer.WriteLine($"{member.Name} = {member.Value},");
                }
            }
        }
    }
}
