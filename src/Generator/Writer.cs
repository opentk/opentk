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

        internal record FileStrings(string ClassName, string Namespace, string LoaderClass, string LoaderBindingsContext)
        {
            /// <summary>Alias for <see cref="ClassName"/>.</summary>
            public string ApiName => ClassName;
        }

        public static void Write(OutputData data)
        {
            // This is quite fragile, no idea if there is an easy way that is "better".
            string outputProjectPath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new NullReferenceException(),
                "..", "..", "..", "..", GraphicsNamespace);

            foreach (Pointers pointers in data.Pointers)
            {
                FileStrings strings = pointers.File switch
                {
                    GLFile.GL => new FileStrings("GL", "OpenGL", "GLLoader", "GLLoader.BindingsContext"),
                    GLFile.WGL => new FileStrings("Wgl", "Wgl", "WGLLoader", "WGLLoader.BindingsContext"),
                    GLFile.GLX => new FileStrings("Glx", "Glx", "GLXLoader", "GLXLoader.BindingsContext"),
                    _ => throw new Exception(),
                };

                // FIXME: Merge the writing of these function pointers for the relevant namespaces!
                WriteFunctionPointers(outputProjectPath, strings, pointers.NativeFunctions);
            }

            foreach (Namespace @namespace in data.Namespaces)
            {
                WriteNamespace(outputProjectPath, @namespace);
            }
        }

        public static void WriteNamespace(string outputProjectPath, Namespace @namespace)
        {
            // FIXME: Fix function pointers so we can merge this.
            FileStrings strings = @namespace.Name switch
            {
                OutputApi.GL => new FileStrings("GL", "OpenGL", "GLLoader", "GLLoader.BindingsContext"),
                OutputApi.GLCompat => new FileStrings("GL", "OpenGL.Compatibility", "GLLoader", "GLLoader.BindingsContext"),
                OutputApi.GLES1 => new FileStrings("GL", "OpenGLES1", "GLLoader", "GLLoader.BindingsContext"),
                OutputApi.GLES2 => new FileStrings("GL", "OpenGLES2", "GLLoader", "GLLoader.BindingsContext"),
                OutputApi.WGL => new FileStrings("Wgl", "Wgl", "WGLLoader", "WGLLoader.BindingsContext"),
                OutputApi.GLX => new FileStrings("Glx", "Glx", "GLXLoader", "GLXLoader.BindingsContext"),
                _ => throw new Exception($"This is not a valid output API ({@namespace.Name})"),
            };

            string directoryPath = Path.Combine(outputProjectPath, Path.Combine(strings.Namespace.Split('.')));
            if (Directory.Exists(directoryPath) == false) Directory.CreateDirectory(directoryPath);
            var files = Directory.GetFiles(directoryPath, "*.cs", SearchOption.TopDirectoryOnly);
            foreach (var file in files.Where(file => Path.GetFileName(file) != $"{strings.ClassName}.Manual.cs"))
            {
                File.Delete(file);
            }

            WriteNativeFunctions(directoryPath, strings, @namespace.Vendors, @namespace.Documentation);
            WriteOverloads(directoryPath, strings, @namespace.Vendors);

            WriteEnums(directoryPath, strings, @namespace.EnumGroups);
        }

        // FIXME: Maybe we should nest this 
        private static void WriteFunctionPointers(string directoryPath, FileStrings strings, List<NativeFunction> nativeFunctions)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, $"{strings.ClassName}.Pointers.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);

            // FIXME: using OpenTK.Graphics.OpenGL if we are wgl or glx...

            writer.WriteLine($"// This file is auto generated, do not edit. Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss \"GMT\"zzz}");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using OpenTK.Graphics;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.{strings.Namespace}");

            using (writer.CsScope())
            {
                writer.WriteLine($"/// <summary>A collection of all function pointers to all OpenGL entry points.</summary>");
                // FIXME: Better class name?
                writer.WriteLine($"public static unsafe partial class {strings.ClassName}Pointers");
                using (writer.CsScope())
                {
                    foreach (NativeFunction function in nativeFunctions)
                    {
                        WriteFunctionPointer(writer, function, strings);
                    }
                }
            }
        }

        private static void WriteFunctionPointer(IndentedTextWriter writer, NativeFunction function, FileStrings strings)
        {
            // Write delegate field initialized to the lazy loader.
            // Write public function definition that calls delegate.
            // Write lazy loader function.
            GetNativeFunctionSignature(function, postfixName: false, swapTypesForUnderlyingType: true,
                out string _,
                out StringBuilder paramNames,
                out StringBuilder delegateTypes,
                out StringBuilder signature,
                out bool _,
                out string returnType);

            string entryPoint = function.EntryPoint;

            writer.WriteLine($"/// <summary><b>[entry point: <c>{entryPoint}</c>]</b></summary>");
            writer.WriteLine($"public static delegate* unmanaged<{delegateTypes}> _{entryPoint}_fnptr = &{entryPoint}_Lazy;");

            writer.WriteLine($"[UnmanagedCallersOnly]");
            writer.WriteLine($"private static {returnType} {entryPoint}_Lazy({signature})");
            using (writer.CsScope())
            {
                // Dotnet gurantees you can't get torn values when assigning functionpointers, assuming proper allignment which is default.
                writer.WriteLine($"_{entryPoint}_fnptr = (delegate* unmanaged<{delegateTypes}>){strings.LoaderBindingsContext}.GetProcAddress(\"{function.EntryPoint}\");");

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

        private static void GetNativeFunctionSignature(NativeFunction function, bool postfixName, bool swapTypesForUnderlyingType,
            out string name, out StringBuilder paramNames, out StringBuilder delegateTypes, out StringBuilder signature, out bool castReturnType, out string returnType)
        {
            name = function.FunctionName;
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
                    CSStructPrimitive csstruct => csstruct.UnderlyingType?.ToCSString() ?? throw new Exception("A struct didnt contain an underlying type."),
                    CSEnum csenum => csenum.PrimitiveType.ToCSString(),
                    CSBool8 => "byte",
                    _ => type.ToCSString()
                };

                return underlyingType + pointers;
            }
        }

        private static void WriteNativeFunctions(
            string directoryPath,
            FileStrings strings,
            SortedDictionary<string, GLVendorFunctions> groups,
            Dictionary<NativeFunction, FunctionDocumentation> documentation)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, $"{strings.ApiName}.Native.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine($"// This file is auto generated, do not edit. Generated: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss \"GMT\"zzz")}");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using OpenTK.Graphics;");

            // FIXME: This is messy.
            if (strings.Namespace != "OpenGL") writer.WriteLine("using OpenTK.Graphics.OpenGL;");
            if (strings.Namespace != "Wgl") writer.WriteLine("using OpenTK.Graphics.Wgl;");
            if (strings.Namespace != "Glx") writer.WriteLine("using OpenTK.Graphics.Glx;");

            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.{strings.Namespace}");
            using (writer.CsScope())
            {
                writer.WriteLine($"public static unsafe partial class {strings.ApiName}");
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

                        foreach (var function in group.Functions)
                        {
                            bool postfixName = group.NativeFunctionsWithPostfix.Contains(function.NativeFunction);
                            documentation.TryGetValue(function.NativeFunction, out FunctionDocumentation? functionDocumentation);
                            WriteNativeFunction(writer, function.NativeFunction, postfixName, functionDocumentation, strings.ApiName);
                        }

                        scope?.Dispose();
                    }
                }
            }

            writer.Flush();
        }

        private static void WriteNativeFunction(IndentedTextWriter writer, NativeFunction function, bool postfixName, FunctionDocumentation? documentation, string apiName)
        {
            GetNativeFunctionSignature(function, postfixName, swapTypesForUnderlyingType: false,
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
                    writer.WriteLine($"public static {function.ReturnType.ToCSString()} {name}({signature}) => {apiName}Pointers._{entryPoint}_fnptr({paramNames}) != 0;");
                }
                else
                {
                    writer.WriteLine($"public static {function.ReturnType.ToCSString()} {name}({signature}) => ({function.ReturnType.ToCSString()}) {apiName}Pointers._{entryPoint}_fnptr({paramNames});");
                }
            }
            else
            {
                writer.WriteLine($"public static {returnType} {name}({signature}) => {apiName}Pointers._{entryPoint}_fnptr({paramNames});");
            }

            writer.WriteLine();
        }

        private static void WriteOverloads(
            string directoryPath,
            FileStrings strings,
            SortedDictionary<string, GLVendorFunctions> groups)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, $"{strings.ApiName}.Overloads.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine($"// This file is auto generated, do not edit. Generated: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss \"GMT\"zzz")}");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using OpenTK.Mathematics;");
            writer.WriteLine("using OpenTK.Graphics;");

            // FIXME: This is messy.
            if (strings.Namespace != "OpenGL") writer.WriteLine("using OpenTK.Graphics.OpenGL;");
            if (strings.Namespace != "Wgl") writer.WriteLine("using OpenTK.Graphics.Wgl;");
            if (strings.Namespace != "Glx") writer.WriteLine("using OpenTK.Graphics.Glx;");

            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.{strings.Namespace}");
            using (writer.CsScope())
            {
                // FIXME: Maybe we want to fix this?
                writer.WriteLine($"public static unsafe partial class {strings.ApiName}");
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

                        foreach (var function in group.Functions)
                        {
                            foreach (var overload in function.Overloads)
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
            string parameterTypes = string.Join(", ", overload.NativeFunction.Parameters.Select(p => p.Type.ToCSString()));

            string nativeFunctionName = overload.NativeFunction.FunctionName;

            writer.WriteLine($"/// <inheritdoc cref=\"{nativeFunctionName}({parameterTypes})\"/>");

            string parameterString = string.Join(", ", overload.InputParameters.Select(p => $"{p.Type.ToCSString()} {p.Name}"));

            string genericTypes = overload.GenericTypes.Length <= 0 ? "" : $"<{string.Join(", ", overload.GenericTypes)}>";
            writer.WriteLine($"public static unsafe {overload.ReturnType.ToCSString()} {overload.OverloadName}{genericTypes}({parameterString})");
            using (writer.Indent())
            {
                foreach (var type in overload.GenericTypes)
                {
                    writer.WriteLine($"where {type} : unmanaged");
                }
            }

            using (writer.CsScope())
            {
                // FIXME: Shouldn't we create the overloads return type here and let the overload layers
                // create the intermediate return values?
                /*if (overload.ReturnType is not CSVoid && overload.NativeFunction.ReturnType is not CSVoid)
                {
                    writer.WriteLine($"{overload.NativeFunction.ReturnType.ToCSString()} returnValue;");
                }*/
                if (overload.ReturnType is not CSVoid /*&& overload.NativeFunction.ReturnType is not CSVoid*/)
                {
                    writer.WriteLine($"{overload.ReturnType.ToCSString()} {overload.NameTable.ReturnName};");
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


        private static void WriteDocumentation(IndentedTextWriter writer, FunctionDocumentation documentation, string entryPoint)
        {
            writer.Write("/// <summary> ");
            writer.Write($"<b>[requires: {string.Join(" | ", documentation.AddedIn)}]</b> ");
            if (documentation.RemovedIn?.Count > 0)
                writer.Write($"<b>[removed in: {string.Join(" | ", documentation.RemovedIn)}]</b> ");
            writer.Write($"<b>[entry point: <c>{entryPoint}</c>]</b><br/>");
            writer.WriteLine($" {documentation.Purpose} </summary>");

            foreach (ParameterDocumentation parameter in documentation.Parameters)
            {
                writer.WriteLine($"/// <param name=\"{parameter.Name}\">{parameter.Description}</param>");
            }

            if (documentation.RefPagesLink != null)
            {
                writer.WriteLine($"/// <remarks><see href=\"{documentation.RefPagesLink}\" /></remarks>");
            }
        }

        private static void WriteEnums(string directoryPath, FileStrings strings, List<EnumGroup> enumGroups)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Enums.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine($"// This file is auto generated, do not edit. Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss \"GMT\"zzz}");
            writer.WriteLine("using System;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.{strings.Namespace}");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CA1069 // Enums values should not be duplicated");
                writer.WriteLineNoTabs("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");
                // FIXME: Maybe we want to fix this?
                writer.WriteLineNoTabs("#pragma warning disable CS0419 // Ambiguous reference in cref attribute");
                WriteEnumGroups(writer, strings.ApiName, enumGroups);
                writer.WriteLineNoTabs("#pragma warning restore CA1069 // Enums values should not be duplicated");
                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
                // FIXME: Maybe we want to fix this?
                writer.WriteLineNoTabs("#pragma warning restore CS0419 // Ambiguous reference in cref attribute");
            }
        }

        private static void WriteEnumGroups(IndentedTextWriter writer, string apiName, List<EnumGroup> enumGroups)
        {
            foreach (var group in enumGroups)
            {
                if (group.FunctionsUsingEnumGroup != null)
                {
                    if (group.FunctionsUsingEnumGroup.Count > 3)
                    {
                        writer.WriteLine($"///<summary>Used in {string.Join(", ", group.FunctionsUsingEnumGroup.Take(3).Select(f => $"<see cref=\"{apiName}.{(f.Vendor != "" ? $"{f.Vendor}." : "")}{f.Function.FunctionName}\" />"))}, ...</summary>");
                    }
                    else
                    {
                        writer.WriteLine($"///<summary>Used in {string.Join(", ", group.FunctionsUsingEnumGroup.Select(f => $"<see cref=\"{apiName}.{(f.Vendor != "" ? $"{f.Vendor}." : "")}{f.Function.FunctionName}\" />"))}</summary>");
                    }
                }

                if (group.IsFlags) writer.WriteLine($"[Flags]");
                writer.WriteLine($"public enum {group.Name} : uint");
                using (writer.CsScope())
                {
                    foreach (var member in group.Members)
                    {
                        writer.WriteLine($"{member.MangledName} = {member.Value},");
                    }
                }
            }
        }
    }
}
