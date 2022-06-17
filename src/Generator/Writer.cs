using Generator.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.CodeDom.Compiler;
using Generator.Parsing;
using Generator.Utility;

namespace Generator.Writing
{
    internal static class Writer
    {
        private const string BaseNamespace = "OpenTK";
        private const string GraphicsNamespace = BaseNamespace + ".Graphics";
        private const string LoaderClass = "GLLoader";
        private const string LoaderBindingsContext = LoaderClass + ".BindingsContext";

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

                WriteNativeFunctions(directoryPath, apiNamespace, api.Vendors, api.Documentation);
                WriteOverloads(directoryPath, apiNamespace, api.Vendors);

                WriteEnums(directoryPath, apiNamespace, api.EnumGroups);
            }
        }

        private static void WriteNativeFunctions(
            string directoryPath,
            string glNamespace,
            Dictionary<string, GLVendorFunctions> groups,
            Dictionary<NativeFunction, FunctionDocumentation> documentation)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "GL.Native.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using OpenTK.Graphics;");
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
                            documentation.TryGetValue(function, out FunctionDocumentation? functionDocumentation);
                            WriteNativeMethod(writer, function, postfixName, functionDocumentation);
                        }

                        scope?.Dispose();
                    }
                }
            }

            writer.Flush();
        }

        private static void WriteNativeMethod(IndentedTextWriter writer, NativeFunction function, bool postfixName, FunctionDocumentation? documentation)
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

            // Because there might be ABI differences between returning a struct and a primitive type we can't assume the GL function is gonna return a struct,
            // so we need to match the native function signature excactly, to avoid a mismatch in the ABI.
            // - 2021-06-22
            bool handleAbiDifferenceForTypesafeHandles;

            string returnType;
            if (function.ReturnType is CSStruct returnStruct)
            {
                if (returnStruct.UnderlyingType == null) throw new Exception("A function returned a struct, but didn't have an underlying representation.");
                returnType = returnStruct.UnderlyingType.ToCSString();

                handleAbiDifferenceForTypesafeHandles = true;
            }
            else
            {
                returnType = function.ReturnType.ToCSString();

                handleAbiDifferenceForTypesafeHandles = false;
            }

            delegateTypes.Append(returnType);

            writer.WriteLine($"private static delegate* unmanaged<{delegateTypes}> _{name}_fnptr = &{name}_Lazy;");

            if (documentation != null)
            {
                WriteDocumentation(writer, documentation);
            }

            if (handleAbiDifferenceForTypesafeHandles)
            {
                // Here we just cast and return the correct return type in the public facing function.
                // This works because all of the structs that get here should have a defined cast from the primitive type to the struct type.
                // These casts need to be added manually for this to work correctly.
                // - 2021-06-22
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
                // Dotnet gurantees you can't get torn values when assigning functionpointers, assuming proper allignment which is default.
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
            Dictionary<string, GLVendorFunctions> groups)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "GL.Overloads.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using OpenTK.Mathematics;");
            writer.WriteLine("using OpenTK.Graphics;");
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
                                WriteOverloadMethod(writer, overload, postfixNativeCall);
                            }
                        }

                        scope?.Dispose();
                    }
                }
            }
        }

        private static void WriteOverloadMethod(IndentedTextWriter writer, Overload overload, bool postfixNativeCall)
        {
            writer.WriteLine($"/// <inheritdoc cref=\"{overload.NativeFunction.FunctionName}\"/>");

            string parameterString =
                string.Join(", ", overload.InputParameters.Select(p => $"{p.Type.ToCSString()} {p.Name}"));

            string genericTypes =
                overload.GenericTypes.Length <= 0 ? "" : $"<{string.Join(", ", overload.GenericTypes)}>";
            writer.WriteLine(
                $"public static unsafe {overload.ReturnType.ToCSString()} {overload.OverloadName}{genericTypes}({parameterString})");
            using (writer.Indent())
            {
                foreach (var type in overload.GenericTypes)
                {
                    writer.WriteLine($"where {type} : unmanaged");
                }
            }

            using (writer.CsScope())
            {
                if (overload.ReturnType is not CSVoid && overload.NativeFunction.ReturnType is not CSVoid)
                {
                    writer.WriteLine($"{overload.NativeFunction.ReturnType.ToCSString()} returnValue;");
                }

                string? returnName = WriteNestedOverload(writer, overload, new NameTable(), postfixNativeCall);

                if (returnName != null)
                {
                    writer.WriteLine($"return {returnName};");
                }
            }
        }

        private static string? WriteNestedOverload(IndentedTextWriter writer, Overload overload, NameTable nameTable, bool postfixNativeCall)
        {
            // Update the name table with the names for this overload.
            nameTable.Apply(overload.NameTable);

            overload.MarshalLayerToNested?.WritePrologue(writer, nameTable);

            string? returnName;
            if (overload.NestedOverload != null)
            {
                returnName = WriteNestedOverload(writer, overload.NestedOverload, nameTable, postfixNativeCall);
            }
            else
            {
                // Writes the native call.
                NativeFunction nativeFunction = overload.NativeFunction;
                string name = nativeFunction.FunctionName;
                if (postfixNativeCall) name += "_";

                string arguments = string.Join(", ", nativeFunction.Parameters.Select(p => nameTable[p]));

                if (nativeFunction.ReturnType is CSVoid)
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

            return overload.MarshalLayerToNested?.WriteEpilogue(writer, nameTable, returnName) ?? returnName;
        }


        private static void WriteDocumentation(IndentedTextWriter writer, FunctionDocumentation documentation)
        {
            writer.WriteLine($"/// <summary> <b>[requires: {string.Join(" | ", documentation.AddedIn)}]</b> {documentation.Purpose} </summary>");

            foreach (ParameterDocumentation parameter in documentation.Parameters)
            {
                writer.WriteLine($"/// <param name=\"{parameter.Name}\">{parameter.Description}</param>");
            }
            writer.WriteLine($"/// <remarks><see href=\"{documentation.RefPagesLink}\" /></remarks>");
        }

        private static void WriteEnums(string directoryPath, string apiNamespace, List<EnumGroup> enumGroups)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Enums.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.{apiNamespace}");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CA1069 // Enums values should not be duplicated");
                WriteEnumGroups(writer, enumGroups);
                writer.WriteLineNoTabs("#pragma warning restore CA1069 // Enums values should not be duplicated");
            }
        }

        private static void WriteEnumGroups(IndentedTextWriter writer, List<EnumGroup> enumGroups)
        {
            foreach (var group in enumGroups)
            {
                if (group.FunctionsUsingEnumGroup != null)
                {
                    if (group.FunctionsUsingEnumGroup.Count > 3)
                    {
                        writer.WriteLine($"///<summary>Used in {string.Join(", ", group.FunctionsUsingEnumGroup.Take(3).Select(f => $"<see cref=\"GL.{f.FunctionName}\" />"))}, ...</summary>");
                    }
                    else
                    {
                        writer.WriteLine($"///<summary>Used in {string.Join(", ", group.FunctionsUsingEnumGroup.Select(f => $"<see cref=\"GL.{f.FunctionName}\" />"))}</summary>");
                    }
                }

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
    }
}
