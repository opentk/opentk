using Generator.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.CodeDom.Compiler;

namespace Generator.Writing
{
    class Writer
    {
        const string BaseNamespace = "OpenTK";
        const string GraphicsNamespace = BaseNamespace + ".Graphics";
        const string LoaderClass = "GLLoader";
        const string LoaderBindingsContext = LoaderClass + ".BindingsContext";

        public static void Write(OutputData data)
        {
            string outputProjectPath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new NullReferenceException(),
                "..", "..", "..", "..", GraphicsNamespace);

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

        private static void WriteNativeFunctions(
            string directoryPath,
            string glNamespace,
            Dictionary<string, GLOutputApiGroup> groups)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "GL.Native.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.{glNamespace}");
            using (writer.CsScope())
            {
                writer.WriteLine($"public static unsafe partial class GL");
                using (writer.CsScope())
                {
                    foreach (var (vendor, group) in groups)
                    {
                        CsScope? scope = null;
                        if (!string.IsNullOrWhiteSpace(vendor))
                        {
                            writer.WriteLine($"public static unsafe partial class {vendor}");
                            scope = writer.CsScope();
                        }

                        foreach (var function in group.NativeFunctions)
                        {
                            bool postfixName = group.NativeFunctionsWithPostfix.Contains(function);
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

            // FIXME .net 6
            // In .net 5 there is a bug where struct returns from a function pointer on 64 bit architectures results in the wrong JIT output and throws an exception.
            // See: https://github.com/dotnet/runtime/issues/51170 and https://github.com/dotnet/runtime/issues/35928
            // To fix this we define the function pointer with an equivalent primitive type (if there is one, otherwise throw exception).
            // This allows us to make the problem invisible to the user as all of the public functions have the correct return type.
            // - 2021-06-04

            bool handleNet5functionPointerReturnStructBug;

            string returnType;
            if (function.ReturnType is CSStruct returnStruct)
            {
                if (returnStruct.UnderlyingType == null) throw new Exception("A function returned a struct, but didn't have an underlying representation.");
                returnType = returnStruct.UnderlyingType.ToCSString();

                handleNet5functionPointerReturnStructBug = true;
            }
            else
            {
                returnType = function.ReturnType.ToCSString();

                handleNet5functionPointerReturnStructBug = false;
            }

            delegateTypes.Append(returnType);

            writer.WriteLine($"private static delegate* unmanaged<{delegateTypes}> _{name}_fnptr = &{name}_Lazy;");

            // FIXME: .net 6
            if (handleNet5functionPointerReturnStructBug)
            {
                // Here we just cast and return the correct return type in the public facing function.
                // This works because all of the structs that get here should have a defined cast from the primitive type to the struct type.
                // These casts need to be added manually for this to work correctly.
                // - 2021-06-04
                writer.WriteLine($"public static {function.ReturnType.ToCSString()} {name}({signature}) => ({function.ReturnType.ToCSString()}) _{name}_fnptr({paramNames});");
            }
            else
            {
                writer.WriteLine($"public static {returnType} {name}({signature}) => _{name}_fnptr({paramNames});");
            }

            writer.WriteLine($"[UnmanagedCallersOnly]");
            writer.WriteLine($"private static {returnType} {name}_Lazy({signature})");
            using (writer.CsScope())
            {
                writer.WriteLine($"_{name}_fnptr = (delegate* unmanaged<{delegateTypes}>){LoaderBindingsContext}.GetProcAddress(\"{function.EntryPoint}\");");

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
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "GL.Overloads.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using OpenTK.Mathematics;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.{glNamespace}");
            using (writer.CsScope())
            {
                writer.WriteLine($"public static unsafe partial class GL");
                using (writer.CsScope())
                {
                    foreach (var (vendor, group) in groups)
                    {
                        CsScope? scope = null;
                        if (!string.IsNullOrWhiteSpace(vendor))
                        {
                            writer.WriteLine($"public static unsafe partial class {vendor}");
                            scope = writer.CsScope();
                        }

                        foreach (var nativeFunctionOverloads in group.OverloadsGroupedByNativeFunctions)
                        {
                            foreach (var overload in nativeFunctionOverloads)
                            {
                                bool postfixNativeCall = group.NativeFunctionsWithPostfix.Contains(overload.NativeFunction);
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
            // This is used to cull methods that didn't get any overloads.
            if (overload1.NestedOverload == null &&
                overload1.MarshalLayerToNested == null)
                return;

            string parameterString =
                string.Join(", ", overload1.InputParameters.Select(p => $"{p.Type.ToCSString()} {p.Name}"));

            string genericTypes =
                overload1.GenericTypes.Length <= 0 ? "" : $"<{string.Join(", ", overload1.GenericTypes)}>";
            indentedTextWriter.WriteLine(
                $"public static unsafe {overload1.ReturnType.ToCSString()} {overload1.OverloadName}{genericTypes}({parameterString})");
            using (indentedTextWriter.Indent())
            {
                foreach (var type in overload1.GenericTypes)
                {
                    indentedTextWriter.WriteLine($"where {type} : unmanaged");
                }
            }

            using (indentedTextWriter.CsScope())
            {
                if (overload1.ReturnType is not CSVoid && overload1.NativeFunction.ReturnType is not CSVoid)
                {
                    indentedTextWriter.WriteLine($"{overload1.NativeFunction.ReturnType.ToCSString()} returnValue;");
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
            // FIXME: Disable CA1069 in enums.cs
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Enums.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.{apiNamespace}");
            using (writer.CsScope())
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
                using (writer.CsScope())
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
            using (writer.CsScope())
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
