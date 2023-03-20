﻿using Generator.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.CodeDom.Compiler;
using Generator.Parsing;
using Generator.Utility;
using System.Text.RegularExpressions;

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

            WriteFunctionPointers(outputProjectPath, data.AllNativeFunctions);
            // This should create folders to put the versions in
            foreach (var api in data.Apis)
            {
                string apiNamespace = api.Api switch
                {
                    OutputApi.GL => "OpenGL",
                    OutputApi.GLCompat => "OpenGL.Compatibility",
                    OutputApi.GLES1 => "OpenGLES1",
                    OutputApi.GLES2 => "OpenGLES2",
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

        private static void WriteFunctionPointers(string directoryPath, List<NativeFunction> nativeFunctions)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "GL.Pointers.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);

            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using OpenTK.Graphics;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}");
            using (writer.CsScope())
            {
                writer.WriteLine($"/// <summary>A collection of all function pointers to all OpenGL entry points.</summary>");
                writer.WriteLine($"public static unsafe partial class GLPointers");
                using (writer.CsScope())
                {
                    foreach (NativeFunction function in nativeFunctions)
                    {
                        WriteFunctionPointer(writer, function);
                    }
                }
            }
        }

        private static void WriteFunctionPointer(IndentedTextWriter writer, NativeFunction function)
        {
            // Write delegate field initialized to the lazy loader.
            // Write public function definition that calls delegate.
            // Write lazy loader function.
            GetNativeFunctionSignature(function, postfixName: false, swapTypesForUnderlyingType: true, removeVendorPostfix: false,
                out string _,
                out StringBuilder paramNames,
                out StringBuilder delegateTypes,
                out StringBuilder signature,
                out bool _,
                out string returnType);

            string entryPoint = function.EntryPoint;

            writer.WriteLine($"internal static delegate* unmanaged<{delegateTypes}> _{entryPoint}_fnptr = &{entryPoint}_Lazy;");

            writer.WriteLine($"[UnmanagedCallersOnly]");
            writer.WriteLine($"private static {returnType} {entryPoint}_Lazy({signature})");
            using (writer.CsScope())
            {
                // Dotnet gurantees you can't get torn values when assigning functionpointers, assuming proper allignment which is default.
                writer.WriteLine($"_{entryPoint}_fnptr = (delegate* unmanaged<{delegateTypes}>){LoaderBindingsContext}.GetProcAddress(\"{function.EntryPoint}\");");

                if (function.ReturnType is not CSVoid)
                {
                    writer.WriteLine($"return _{entryPoint}_fnptr({paramNames});");
                }
                else
                {
                    writer.WriteLine($"_{entryPoint}_fnptr({paramNames});");
                }
            }

            writer.WriteLine();
        }

        private static void GetNativeFunctionSignature(NativeFunction function, bool postfixName, bool swapTypesForUnderlyingType, bool removeVendorPostfix,
            out string name, out StringBuilder paramNames, out StringBuilder delegateTypes, out StringBuilder signature, out bool castReturnType, out string returnType)
        {
            name = function.FunctionName;
            if (removeVendorPostfix) name = NameMangler.RemoveVendorPostfix(name);
            if (postfixName) name += "_";

            paramNames = new StringBuilder();
            delegateTypes = new StringBuilder();
            signature = new StringBuilder();
            for (int i = 0; i < function.Parameters.Count; i++)
            {
                var param = function.Parameters[i];
                string type = swapTypesForUnderlyingType ? SwapUnderlyingTypeForPrimitive(param.Type) : param.Type.ToCSString();

                string primitiveType = SwapUnderlyingTypeForPrimitive(param.Type);
                
                if (type != primitiveType)
                {
                    paramNames.Append($"({primitiveType})");
                }

                // HACK: FIXME: You can't cast a bool to byte, sigh..
                if (swapTypesForUnderlyingType == false && param.Type is CSBool8)
                {
                    paramNames.Append($"({param.Name} ? 1 : 0)");
                }
                else
                {
                    paramNames.Append(param.Name);
                }
                
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

            returnType = swapTypesForUnderlyingType ? SwapUnderlyingTypeForPrimitive(function.ReturnType) : function.ReturnType.ToCSString();
            string primitiveReturnType = SwapUnderlyingTypeForPrimitive(function.ReturnType);
            if (returnType != primitiveReturnType)
            {
                castReturnType = true;
            }
            else
            {

                castReturnType = false;
            }

            delegateTypes.Append(returnType);

            static string SwapUnderlyingTypeForPrimitive(BaseCSType type)
            {
                // Peel off all pointers
                StringBuilder pointers = new StringBuilder();
                while (type is CSPointer cspointer)
                {
                    type = cspointer.BaseType;
                    pointers.Append('*');
                }

                string underlyingType = type switch
                {
                    CSStruct csstruct => csstruct.UnderlyingType?.ToCSString() ?? throw new Exception("A struct didnt contain an underlying type."),
                    CSEnum csenum => csenum.PrimitiveType.ToCSString(),
                    CSBool8 => "byte",
                    _ => type.ToCSString()
                };

                return underlyingType + pointers;
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
                            writer.WriteLine($"/// <summary>{vendor} extensions.</summary>");
                            writer.WriteLine($"public static unsafe partial class {vendor}");
                            scope = writer.CsScope();
                        }

                        foreach (var function in group.NativeFunctions)
                        {
                            bool postfixName = group.NativeFunctionsWithPostfix.Contains(function);
                            bool removeVendorPostfix = group.NativeFunctionWithRemovableVendorPostfix.Contains(function);
                            documentation.TryGetValue(function, out FunctionDocumentation? functionDocumentation);
                            WriteNativeFunction(writer, function, postfixName, removeVendorPostfix, functionDocumentation);
                        }

                        scope?.Dispose();
                    }
                }
            }

            writer.Flush();
        }

        private static void WriteNativeFunction(IndentedTextWriter writer, NativeFunction function, bool postfixName, bool removeVendorPostfix, FunctionDocumentation? documentation)
        {
            GetNativeFunctionSignature(function, postfixName, swapTypesForUnderlyingType: false, removeVendorPostfix,
                out string name,
                out StringBuilder paramNames,
                out StringBuilder delegateTypes,
                out StringBuilder signature,
                out bool handleAbiDifferenceForTypesafeHandles,
                out string returnType);

            string entryPoint = function.EntryPoint;

            if (documentation != null)
            {
                WriteDocumentation(writer, documentation, function.EntryPoint);
            }

            if (handleAbiDifferenceForTypesafeHandles)
            {
                // Here we just cast and return the correct return type in the public facing function.
                // This works because all of the structs that get here should have a defined cast from the primitive type to the struct type.
                // These casts need to be added manually for this to work correctly.
                // - 2021-06-22

                if (function.ReturnType is CSBool8)
                {
                    // HACK: We can't cast byte to bool, sigh...
                    writer.WriteLine($"public static {function.ReturnType.ToCSString()} {name}({signature}) => GLPointers._{entryPoint}_fnptr({paramNames}) != 0;");
                }
                else
                {
                    writer.WriteLine($"public static {function.ReturnType.ToCSString()} {name}({signature}) => ({function.ReturnType.ToCSString()}) GLPointers._{entryPoint}_fnptr({paramNames});");
                }
            }
            else
            {
                writer.WriteLine($"public static {returnType} {name}({signature}) => GLPointers._{entryPoint}_fnptr({paramNames});");
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
                // FIXME: Maybe we want to fix this?
                writer.WriteLineNoTabs("#pragma warning disable CS0419 // Ambiguous reference in cref attribute");

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
                                bool removeVendorPostfix = group.NativeFunctionWithRemovableVendorPostfix.Contains(overload.NativeFunction);
                                WriteOverloadMethod(writer, overload, postfixNativeCall, removeVendorPostfix);
                            }
                        }

                        scope?.Dispose();
                    }
                }

                writer.WriteLineNoTabs("#pragma warning restore CS0419 // Ambiguous reference in cref attribute");
            }
        }

        private static void WriteOverloadMethod(IndentedTextWriter writer, Overload overload, bool postfixNativeCall, bool removeVendorPostfix)
        {
            string parameterTypes = string.Join(", ", overload.NativeFunction.Parameters.Select(p => p.Type.ToCSString()));

            string nativeFunctionName = overload.NativeFunction.FunctionName;
            if (removeVendorPostfix) nativeFunctionName = NameMangler.RemoveVendorPostfix(nativeFunctionName);

            writer.WriteLine($"/// <inheritdoc cref=\"{nativeFunctionName}({parameterTypes})\"/>");

            string parameterString = string.Join(", ", overload.InputParameters.Select(p => $"{p.Type.ToCSString()} {p.Name}"));
            string genericTypes = overload.GenericTypes.Length <= 0 ? "" : $"<{string.Join(", ", overload.GenericTypes)}>";

            string name = overload.OverloadName;
            // FIXME: We want to move this into the processing stage
            // - 2023-02-22 NogginBops
            if (removeVendorPostfix) name = NameMangler.RemoveVendorPostfix(name);

            writer.WriteLine($"public static unsafe {overload.ReturnType.ToCSString()} {name}{genericTypes}({parameterString})");
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

                string? returnName = WriteNestedOverload(writer, overload, new NameTable(), postfixNativeCall, removeVendorPostfix);

                if (returnName != null)
                {
                    writer.WriteLine($"return {returnName};");
                }
            }
        }

        private static string? WriteNestedOverload(IndentedTextWriter writer, Overload overload, NameTable nameTable, bool postfixNativeCall, bool removeVendorPostfix)
        {
            // Update the name table with the names for this overload.
            nameTable.Apply(overload.NameTable);

            overload.MarshalLayerToNested?.WritePrologue(writer, nameTable);

            string? returnName;
            if (overload.NestedOverload != null)
            {
                returnName = WriteNestedOverload(writer, overload.NestedOverload, nameTable, postfixNativeCall, removeVendorPostfix);
            }
            else
            {
                // Writes the native call.
                NativeFunction nativeFunction = overload.NativeFunction;
                string name = nativeFunction.FunctionName;
                if (removeVendorPostfix) name = NameMangler.RemoveVendorPostfix(name);
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


        private static void WriteDocumentation(IndentedTextWriter writer, FunctionDocumentation documentation, string entryPoint)
        {
            writer.WriteLine($"/// <summary> <b>[requires: {string.Join(" | ", documentation.AddedIn)}] [{entryPoint}]</b> {documentation.Purpose} </summary>");

            foreach (ParameterDocumentation parameter in documentation.Parameters)
            {
                writer.WriteLine($"/// <param name=\"{parameter.Name}\">{parameter.Description}</param>");
            }

            if (documentation.RefPagesLink != null)
            {
                writer.WriteLine($"/// <remarks><see href=\"{documentation.RefPagesLink}\" /></remarks>");
            }
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
                writer.WriteLineNoTabs("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");
                // FIXME: Maybe we want to fix this?
                writer.WriteLineNoTabs("#pragma warning disable CS0419 // Ambiguous reference in cref attribute");
                WriteEnumGroups(writer, enumGroups);
                writer.WriteLineNoTabs("#pragma warning restore CA1069 // Enums values should not be duplicated");
                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
                // FIXME: Maybe we want to fix this?
                writer.WriteLineNoTabs("#pragma warning restore CS0419 // Ambiguous reference in cref attribute");
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
                        if (group.FunctionsUsingEnumGroup.Take(3).Any(f => f.RemoveVendorName))
                            ;
                        writer.WriteLine($"///<summary>Used in {string.Join(", ", group.FunctionsUsingEnumGroup.Take(3).Select(f => $"<see cref=\"GL.{(f.Vendor != "" ? $"{f.Vendor}." : "")}{(f.RemoveVendorName ? NameMangler.RemoveVendorPostfix(f.Function.FunctionName) : f.Function.FunctionName)}\" />"))}, ...</summary>");
                    }
                    else
                    {
                        writer.WriteLine($"///<summary>Used in {string.Join(", ", group.FunctionsUsingEnumGroup.Select(f => $"<see cref=\"GL.{(f.Vendor != "" ? $"{f.Vendor}." : "")}{(f.RemoveVendorName ? NameMangler.RemoveVendorPostfix(f.Function.FunctionName) : f.Function.FunctionName)}\" />"))}</summary>");
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
