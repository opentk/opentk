using GeneratorV2.Data;
using GeneratorV2.Writing;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace GeneratorV2.Writing
{
    class Writer
    {
        // FIXME: Find a better place
        // Move this into IndentedTextWriter.cs
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

        // FIXME: Should this be "OpenTK.Graphics.OpenGL" instead?
        const string BaseNamespace = "OpenTK";
        const string GraphicsNamespace = BaseNamespace + ".Graphics";
        const string LoaderClass = "GLLoader";
        const string LoaderBindingsContext = LoaderClass + ".BindingsContext";

        public static void Write(OutputData data)
        {
            string outputProjectPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new NullReferenceException(),
                "..", "..", "..", "..", GraphicsNamespace);

            // FIXME: Delete existing if there is one
            try { Directory.Delete(outputProjectPath, true); } catch { }
            Directory.CreateDirectory(outputProjectPath);

            // NAMESPACE:
            WritePaketFile(outputProjectPath);

            WriteProjectFile(outputProjectPath);

            WriteBindingsLoader(outputProjectPath);

            WriteBuiltInTypes(outputProjectPath);

            string glFolder = Path.Combine(outputProjectPath, "OpenGL");

            // This should create folders to put the versions in
            foreach (var version in data.Versions)
            {
                string apiName = version.Api switch
                {
                    OutputApi.GL => "GL",
                    OutputApi.GLES => "GLES",
                    _ => throw new Exception($"This is not a valid output API ({version.Api})"),
                };
                string versionName = $"{apiName}{version.Version.Major}{version.Version.Minor}";
                string versionPath = Path.Combine(glFolder, versionName);

                Directory.CreateDirectory(versionPath);

                WriteNativeFunctions(versionPath, versionName, version.Functions);
                WriteOverloads(versionPath, versionName, version.Overloads);

                WriteEnums(versionPath, versionName, version.EnumGroups, version.AllEnums);
            }
        }

        public static void WritePaketFile(string projectPath)
        {

            using var writer = new IndentedTextWriter(Path.Combine(projectPath, $"paket"));

            writer.WriteLine("type file");
            writer.WriteLine($"id {GraphicsNamespace}");

            writer.WriteLine("description");
            using (writer.Indentation())
            {
                writer.WriteLine("OpenGl and OpenGlEs bindings for dotnet from the Khronos openGL c library.");
            }

            writer.WriteLine("dependencies");
            using (writer.Indentation())
            {
                writer.WriteLine("framework: net5.0");
                using (writer.Indentation())
                {
                    writer.WriteLine("OpenToolkit.Core ~> #VERSION#");
                    writer.WriteLine("OpenToolkit.Mathematics ~> #VERSION#");
                }
            }

            writer.WriteLine("files");
            using (writer.Indentation())
            {
                writer.WriteLine($"bin\\Release\\net5.0\\{GraphicsNamespace}.dll ==> lib\\net5.0");
                writer.WriteLine($"bin\\Release\\net5.0\\{GraphicsNamespace}.pdb ==> lib\\net5.0");
            }
        }

        public static void WriteProjectFile(string projectPath)
        {
            using var writer = new IndentedTextWriter(Path.Combine(projectPath, $"{GraphicsNamespace}.csproj"));

            // FIXME: Maybe get the version from somewhere too?
            // The indentation is gonna be weird in the file doing it like this,
            // but it shouldn't be edited in there anyways.
            writer.Write($@"
                <!-- This file is auto generated, do not edit -->
                <Project Sdk=""Microsoft.NET.Sdk"">
                    <PropertyGroup>
                        <TargetFramework>net5.0</TargetFramework>
                        <Nullable>enable</Nullable>
                        <RootNamespace>{GraphicsNamespace}</RootNamespace>
                        <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
                        <PackageVersion>5.0.0-pre0.0</PackageVersion>
                        <Version>5.0.0</Version>
                    </PropertyGroup>
                    <ItemGroup>
                        <ProjectReference Include=""../{BaseNamespace}.Core/{BaseNamespace}.Core.csproj"" />
                        <ProjectReference Include=""../{BaseNamespace}.Mathematics/{BaseNamespace}.Mathematics.csproj"" />
                    </ItemGroup>
                </Project>
                ");
        }

        public static void WriteBindingsLoader(string projectPath)
        {
            using var writer = new IndentedTextWriter(Path.Combine(projectPath, $"{LoaderClass}.cs"));
            writer.Write($@"
                // This file is auto generated, do not edit.
                using System;

                namespace {GraphicsNamespace}
                {{
                    public unsafe static class {LoaderClass}
                    {{
                        internal static object LockObj = new object();
                        private static IBindingsContext? _bindingsContext;
                        internal static IBindingsContext BindingsContext => _bindingsContext ?? throw new Exception(""Bindings not loaded, load with GLLoader.LoadBindings"");
                        public static void LoadBindings(IBindingsContext c) => _bindingsContext = c;
                    }}
                }}
                ");
        }

        public static void WriteBuiltInTypes(string projectPath)
        {
            using var writer = new IndentedTextWriter(Path.Combine(projectPath, "Types.cs"));
            writer.Write($@"
                // This file is auto generated, do not edit.
                using System;
                using System.Runtime.InteropServices;

                namespace {GraphicsNamespace}
                {{
                    public unsafe delegate void GLDebugProc(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);
                    public unsafe delegate void GLDebugProcARB(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);
                    public unsafe delegate void GLDebugProcKHR(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);
                    public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
                    public unsafe delegate void GLDebugProcNV();

                    public struct CLContext{{}}
                    public struct CLEvent{{}}

                    public struct GLSync{{}}
                    public unsafe struct GLSyncObject
                    {{
                        internal GLSync* ObjPtr;
                        internal GLSyncObject(GLSync* syncObject)

                        {{
                            ObjPtr = syncObject;
                        }}

                        public static implicit operator GLSync*(GLSyncObject obj) => obj.ObjPtr;
                        public static implicit operator GLSyncObject(GLSync* obj) => new GLSyncObject(obj);
                    }}

                    [StructLayout(LayoutKind.Explicit)]
                    public struct GLHandleARB
                    {{
                        [FieldOffset(0)] private readonly uint _value1;
                        [FieldOffset(0)] private readonly IntPtr _value2;

                        public GLHandleARB(uint val)
                        {{
                            _value2 = IntPtr.Zero;
                            _value1 = val;
                        }}

                        public GLHandleARB(IntPtr val)
                        {{
                            _value1 = 0;
                            _value2 = val;
                        }}

                        public static implicit operator GLHandleARB(uint val) => new GLHandleARB(val);
                        public static implicit operator GLHandleARB(IntPtr val) => new GLHandleARB(val);
                        public static implicit operator uint(GLHandleARB val) => val._value1;
                        public static implicit operator IntPtr(GLHandleARB val) => val._value2;
                    }}
                }}
                ");
        }

        public static void WriteNativeFunctions(string directoryPath, string version, List<OverloaderNativeFunction> nativeFunctions)
        {
            using IndentedTextWriter writer = new IndentedTextWriter(Path.Combine(directoryPath, "GL.cs"));
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            // NAMESPACE:
            writer.WriteLine($"namespace {GraphicsNamespace}.OpenGL.{version}");
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
                    foreach (var (function, postfixName) in nativeFunctions)
                    {
                        string name = function.FunctionName;
                        if (postfixName) name += "_";

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

            writer.Flush();
        }

        public static void WriteOverloads(string directoryPath, string version, List<OverloaderFunctionOverloads> overloads)
        {
            using IndentedTextWriter writer = new IndentedTextWriter(Path.Combine(directoryPath, "GL.Overloads.cs"));
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.OpenGL.{version}");
            using (Scope(writer))
            {
                writer.WriteLine($"public static unsafe partial class GL");
                using (Scope(writer))
                {
                    foreach (var (overs, postfixNativeCall) in overloads)
                    {
                        foreach (var overload in overs)
                        {
                            // FIXME: This was(?) used to cull "overloads" that didn't get any .
                            if (overload.NestedOverload == null &&
                                overload.MarshalLayerToNested == null)
                                continue;

                            string parameterString = string.Join(", ", overload.InputParameters.Select(p => $"{p.Type.ToCSString()} {p.Name}"));

                            // FIXME: Make the overload contain the name. (remove postfix usecase)
                            // FIXME: Make NativeFunction contain the preprocessed name as well as the entry point.
                            string genericTypes = overload.GenericTypes.Length <= 0 ? "" : $"<{string.Join(", ", overload.GenericTypes)}>";
                            writer.WriteLine($"public static unsafe {overload.ReturnType.ToCSString()} {overload.NativeFunction.EntryPoint[2..]}{genericTypes}({parameterString})");
                            using (writer.Indentation())
                            {
                                foreach (var type in overload.GenericTypes)
                                {
                                    writer.WriteLine($"where {type} : unmanaged");
                                }
                            }

                            using (Scope(writer))
                            {
                                if (overload.ReturnType is not CSVoid)
                                {
                                    writer.WriteLine($"{overload.NativeFunction.ReturnType.ToCSString()} returnValue;");
                                }

                                string? returnName = WriteNestedOverload(writer, overload, postfixNativeCall);

                                if (returnName != null)
                                {
                                    writer.WriteLine($"return {returnName};");
                                }
                            }
                        }
                    }
                }
            }

            static string? WriteNestedOverload(IndentedTextWriter writer, Overload overload, bool postfixNativeCall)
            {
                overload.MarshalLayerToNested?.WritePrologue(writer);

                string? returnName;
                if (overload.NestedOverload != null)
                    returnName = WriteNestedOverload(writer, overload.NestedOverload, postfixNativeCall);
                else
                    returnName = WriteNativeCall(writer, overload.NativeFunction, postfixNativeCall);

                return overload.MarshalLayerToNested?.WriteEpilogue(writer, returnName) ?? returnName;
            }

            static string? WriteNativeCall(IndentedTextWriter writer, NativeFunction function, bool postfixNativeCall)
            {
                string name = function.FunctionName;
                if (postfixNativeCall) name += "_";

                string arguments = string.Join(", ", function.Parameters.Select(p => p.Name));

                if (function.ReturnType is CSVoid)
                {
                    writer.WriteLine($"{name}({arguments});");
                    return null;
                }
                else
                {
                    writer.WriteLine($"returnValue = {name}({arguments});");
                    return "returnValue";
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
            writer.WriteLine($"namespace {GraphicsNamespace}.OpenGL.{version}");
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
