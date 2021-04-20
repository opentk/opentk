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
            string outputProjectPath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new NullReferenceException(),
                "..", "..", "..", "..", GraphicsNamespace);

            // RewriteProject(outputProjectPath);


            // This should create folders to put the versions in
            foreach (var api in data.Apis)
            {
                string apiNamespace = api.Api switch
                {
                    OutputApi.GL => "OpenGL",
                    OutputApi.GLCompat => "OpenGL.Compatibility",
                    OutputApi.GLES1 => "OpenGLES1",
                    OutputApi.GLES3 => "OpenGLES3",
                    _ => throw new Exception($"This is not a valid output API ({api.Api})"),
                };
                string directoryPath = Path.Combine(outputProjectPath, Path.Combine(apiNamespace.Split('.')));
                if (Directory.Exists(directoryPath) == false) Directory.CreateDirectory(directoryPath);
                var files = Directory.GetFiles(directoryPath, "*.cs", SearchOption.TopDirectoryOnly);
                foreach (var file in files.Where(file => Path.GetFileName(file) != "GL.Manual.cs"))
                {
                    File.Delete(file);
                }

                // if (!Directory.Exists(directoryPath))
                // {
                //     Directory.CreateDirectory(directoryPath);
                // }

                WriteNativeFunctions(directoryPath, apiNamespace, api.Vendors);
                WriteOverloads(directoryPath, apiNamespace, api.Vendors);

                WriteEnums(directoryPath, apiNamespace, api.EnumGroups, api.AllEnums);
            }
        }

        private static void RewriteProject(string outputProjectPath)
        {
            try
            {
                Directory.Delete(outputProjectPath, true);
            }
            catch (UnauthorizedAccessException)
            {
            }

            Directory.CreateDirectory(outputProjectPath);

            // NAMESPACE:
            WritePaketFile(outputProjectPath);

            WriteProjectFile(outputProjectPath);

            WriteBindingsLoader(outputProjectPath);

            WriteBuiltInTypes(outputProjectPath);
        }

        private static void WritePaketFile(string projectPath)
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
                    writer.WriteLine($"{BaseNamespace}.Core ~> #VERSION#");
                    writer.WriteLine($"{BaseNamespace}.Mathematics ~> #VERSION#");
                }
            }

            writer.WriteLine("files");
            using (writer.Indentation())
            {
                writer.WriteLine($"bin\\Release\\net5.0\\{GraphicsNamespace}.dll ==> lib\\net5.0");
                writer.WriteLine($"bin\\Release\\net5.0\\{GraphicsNamespace}.pdb ==> lib\\net5.0");
            }
        }

        private static void WriteProjectFile(string projectPath)
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
                    </PropertyGroup>
                    <ItemGroup>
                        <ProjectReference Include=""../{BaseNamespace}.Core/{BaseNamespace}.Core.csproj"" />
                        <ProjectReference Include=""../{BaseNamespace}.Mathematics/{BaseNamespace}.Mathematics.csproj"" />
                    </ItemGroup>
                </Project>
                ");
        }

        private static void WriteBindingsLoader(string projectPath)
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

        private static void WriteBuiltInTypes(string projectPath)
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

        private static void WriteNativeFunctions(
            string directoryPath,
            string glNamespace,
            Dictionary<string, GLOutputApiGroup> groups)
        {
            using IndentedTextWriter writer = new IndentedTextWriter(Path.Combine(directoryPath, "GL.Native.cs"));
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine();
            // NAMESPACE:
            writer.WriteLine($"namespace {GraphicsNamespace}.{glNamespace}");
            using (Scope(writer))
            {
                writer.WriteLine($"public static unsafe partial class GL");
                using (Scope(writer))
                {
                    foreach (var (vendor, group) in groups)
                    {
                        CsScope? scope = null;
                        if (!string.IsNullOrWhiteSpace(vendor))
                        {
                            writer.WriteLine($"public static unsafe partial class {vendor}");
                            scope = Scope(writer);
                        }

                        foreach (var (function, postfixName) in group.Functions)
                        {
                            WriteNativeMethod(function, postfixName, writer);
                        }

                        scope?.Dispose();
                    }
                }
            }

            writer.Flush();
        }

        private static void WriteNativeMethod(NativeFunction function, bool postfixName, IndentedTextWriter writer)
        {
            // Write delegate field initialized to the lazy loader.
            // Write public function definition that calls delegate.
            // Write lazy loader function.
            string name = function.FunctionName;
            if (postfixName) name += "_";

            StringBuilder paramNames = new StringBuilder();
            StringBuilder delegateTypes = new StringBuilder();
            StringBuilder signature = new StringBuilder();

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
                writer.WriteLine($"_{name}_fnptr = (delegate*<{delegateTypes}>){LoaderBindingsContext}.GetProcAddress(\"{function.EntryPoint}\");");

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

        private static void WriteOverloads(
            string directoryPath,
            string glNamespace,
            Dictionary<string, GLOutputApiGroup> groups)
        {
            using IndentedTextWriter writer =
                new IndentedTextWriter(Path.Combine(directoryPath, "GL.Overloads.cs"));
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.{glNamespace}");
            using (Scope(writer))
            {
                writer.WriteLine($"public static unsafe partial class GL");
                using (Scope(writer))
                {
                    foreach (var (vendor, group) in groups)
                    {
                        CsScope? scope = null;
                        if (!string.IsNullOrWhiteSpace(vendor))
                        {
                            writer.WriteLine($"public static unsafe partial class {vendor}");
                            scope = Scope(writer);
                        }

                        foreach (var (overs, postfixNativeCall) in group.Overloads)
                        {
                            foreach (var overload in overs)
                            {
                                WriteOverloadMethod(overload, writer, postfixNativeCall);
                            }
                        }

                        scope?.Dispose();
                    }
                }
            }
        }

        private static void WriteOverloadMethod(Overload overload1, IndentedTextWriter indentedTextWriter, bool postfixNativeCall)
        {
            // FIXME: This was(?) used to cull "overloads" that didn't get any .
            if (overload1.NestedOverload == null &&
                overload1.MarshalLayerToNested == null)
                return;

            string parameterString =
                string.Join(", ", overload1.InputParameters.Select(p => $"{p.Type.ToCSString()} {p.Name}"));

            // FIXME: Make the overload contain the name. (remove postfix usecase)
            // FIXME: Make NativeFunction contain the preprocessed name as well as the entry point.
            string genericTypes =
                overload1.GenericTypes.Length <= 0 ? "" : $"<{string.Join(", ", overload1.GenericTypes)}>";
            indentedTextWriter.WriteLine(
                $"public static unsafe {overload1.ReturnType.ToCSString()} {overload1.OverloadName}{genericTypes}({parameterString})");
            using (indentedTextWriter.Indentation())
            {
                foreach (var type in overload1.GenericTypes)
                {
                    indentedTextWriter.WriteLine($"where {type} : unmanaged");
                }
            }

            using (Scope(indentedTextWriter))
            {
                if (overload1.ReturnType is not CSVoid && overload1.NativeFunction.ReturnType is not CSVoid)
                {
                    indentedTextWriter.WriteLine($"{overload1.NativeFunction.ReturnType.ToCSString()} returnValue;");
                }
                
                if (overload1.NativeFunction.EntryPoint == "glNamedBufferData")
                {
                    ;
                }

                string? returnName = WriteNestedOverload(indentedTextWriter, overload1, new NameTable(), postfixNativeCall);

                if (returnName != null)
                {
                    indentedTextWriter.WriteLine($"return {returnName};");
                }
            }
        }

        private static string? WriteNativeCall(IndentedTextWriter writer, NativeFunction function, NameTable table, bool postfixNativeCall)
        {
            string name = function.FunctionName;
            if (postfixNativeCall) name += "_";

            string arguments = string.Join(", ", function.Parameters.Select(p => table[p]));

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

        private static string? WriteNestedOverload(IndentedTextWriter writer, Overload overload, NameTable nameTable, bool postfixNativeCall)
        {
            // Update the name table with the names for this overload.
            nameTable.Apply(overload.NameTable);

            overload.MarshalLayerToNested?.WritePrologue(writer, nameTable);

            string? returnName;
            if (overload.NestedOverload != null)
                returnName = WriteNestedOverload(writer, overload.NestedOverload, nameTable, postfixNativeCall);
            else
                returnName = WriteNativeCall(writer, overload.NativeFunction, nameTable, postfixNativeCall);

            return overload.MarshalLayerToNested?.WriteEpilogue(writer, nameTable, returnName) ?? returnName;
        }

        private static void WriteEnums(string directoryPath, string apiNamespace, List<EnumGroup> enumGroups, List<EnumMemberData> allEnums)
        {
            // FIXME: Disable CA1069
            string path = Path.Combine(directoryPath, "Enums.cs");
            using IndentedTextWriter writer = new IndentedTextWriter(path);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            // NAMESPACE:
            writer.WriteLine($"namespace {GraphicsNamespace}.{apiNamespace}");
            using (Scope(writer))
            {
                WriteAllEnum(writer, allEnums);
                WriteEnumGroups(writer, enumGroups);
            }
        }

        private static void WriteEnumGroups(IndentedTextWriter writer, List<EnumGroup> enumGroups)
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

        private static void WriteAllEnum(IndentedTextWriter writer, List<EnumMemberData> allEnums)
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
