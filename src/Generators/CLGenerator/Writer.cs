using GeneratorBase;
using GeneratorBase.Overloading;
using GeneratorBase.Process;
using GeneratorBase.Utility;
using GeneratorBase.Utility.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CLGenerator
{
    internal static class Writer
    {
        private const string BaseNamespace = "OpenTK";
        private const string Namespace = BaseNamespace + ".Compute2";

        internal record FileStrings(string FileNamePrefix, string ClassName, string Namespace, string LoaderClass, string LoaderBindingsContext)
        {
            /// <summary>Alias for <see cref="ClassName"/>.</summary>
            public string ApiName => ClassName;
        }

        public static void Write(OutputData data, NameMangler nameMangler)
        {
            // This is quite fragile, no idea if there is an easy way that is "better".
            string outputProjectPath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new NullReferenceException(),
                "..", "..", "..", "..", "..", Namespace);

            foreach (ApiPointers pointers in data.Pointers)
            {
                FileStrings strings = pointers.File switch
                {
                    ApiFile.CL => new FileStrings("CL", "CL", "OpenCL", "CLLoader", "CLLoader.BindingsContext"),
                    _ => throw new Exception(),
                };

                // FIXME: Merge the writing of these function pointers for the relevant namespaces!
                WriteFunctionPointers(outputProjectPath, strings, pointers.Functions);
            }

            foreach (OutputApiData @namespace in data.Namespaces)
            {
                WriteNamespace(outputProjectPath, @namespace);
            }

            WriteStructs(outputProjectPath, data.Structs, data.Namespaces[0].Enums, nameMangler);
        }

        public static void WriteNamespace(string outputProjectPath, OutputApiData @namespace)
        {
            // FIXME: Fix function pointers so we can merge this.
            FileStrings strings = @namespace.Api switch
            {
                OutputApi.CL => new FileStrings("CL", "CL", "OpenCL", "CLLoader", "CLLoader.BindingsContext"),
                _ => throw new Exception($"This is not a valid output API ({@namespace.Api})"),
            };

            string directoryPath = Path.Combine(outputProjectPath, Path.Combine(strings.Namespace.Split('.')));
            if (Directory.Exists(directoryPath) == false) Directory.CreateDirectory(directoryPath);
            var files = Directory.GetFiles(directoryPath, "*.cs", SearchOption.TopDirectoryOnly);
            foreach (var file in files.Where(file => Path.GetFileName(file) != $"{strings.FileNamePrefix}.Manual.cs"))
            {
                File.Delete(file);
            }

            WriteNativeFunctions(directoryPath, strings, @namespace.VendorFunctions, @namespace.FunctionDocumentation);
            WriteOverloads(directoryPath, strings, @namespace.VendorFunctions);

            WriteEnums(directoryPath, strings, @namespace.Enums);
        }

        // FIXME: Maybe we should nest this 
        private static void WriteFunctionPointers(string directoryPath, FileStrings strings, List<Function> nativeFunctions)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, $"{strings.FileNamePrefix}.Pointers.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);

            writer.WriteLine($"// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine("using OpenTK.Compute2;");
            writer.WriteLine();
            writer.WriteLine($"namespace {Namespace}.{strings.Namespace}");

            using (writer.CsScope())
            {
                writer.WriteLine($"/// <summary>A collection of all function pointers to all OpenCL entry points.</summary>");
                // FIXME: Better class name?
                writer.WriteLine($"public static unsafe partial class {strings.ClassName}Pointers");
                using (writer.CsScope())
                {
                    foreach (Function function in nativeFunctions)
                    {
                        WriteFunctionPointer(writer, function, strings);
                    }
                }
            }
        }

        private static void WriteFunctionPointer(IndentedTextWriter writer, Function function, FileStrings strings)
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

            string funcPointer = $"_{function.EntryPoint}_fnptr";

            writer.WriteLine($"/// <summary><b>[entry point: <c>{function.EntryPoint}</c>]</b></summary>");
            writer.WriteLine($"public static delegate* unmanaged<{delegateTypes}> {funcPointer};");

            writer.WriteLine($"[MethodImpl(MethodImplOptions.NoInlining)]");
            writer.WriteLine($"internal static {returnType} {function.EntryPoint}_Lazy({signature})");
            using (writer.CsScope())
            {
                writer.WriteLine($"if ({funcPointer} == null)");
                using (writer.Indent())
                {
                    // Dotnet gurantees you can't get torn values when assigning functionpointers, assuming proper allignment which is default.
                    writer.WriteLine($"{funcPointer} = (delegate* unmanaged<{delegateTypes}>){strings.LoaderBindingsContext}.GetProcAddress(\"{function.EntryPoint}\");");
                }

                if (function.StrongReturnType is not CSVoid)
                {
                    writer.WriteLine($"return {funcPointer}({paramNames});");
                }
                else
                {
                    writer.WriteLine($"{funcPointer}({paramNames});");
                }
            }

            writer.WriteLine();
        }

        private static void GetNativeFunctionSignature(Function function, bool postfixName, bool swapTypesForUnderlyingType,
            out string name, out StringBuilder paramNames, out StringBuilder delegateTypes, out StringBuilder signature, out bool castReturnType, out string returnType)
        {
            name = function.Name;
            if (postfixName) name += "_";

            paramNames = new StringBuilder();
            delegateTypes = new StringBuilder();
            signature = new StringBuilder();
            for (int i = 0; i < function.Parameters.Count; i++)
            {
                var param = function.Parameters[i];
                string type = swapTypesForUnderlyingType ? SwapUnderlyingTypeForPrimitive(param.StrongType!) : param.StrongType!.ToCSString();

                string primitiveType = SwapUnderlyingTypeForPrimitive(param.StrongType!);
                
                if (type != primitiveType)
                {
                    paramNames.Append($"({primitiveType})");
                }

                // HACK: FIXME: You can't cast a bool to byte, sigh..
                if (swapTypesForUnderlyingType == false && param.StrongType is CSBool8)
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

            returnType = swapTypesForUnderlyingType ? SwapUnderlyingTypeForPrimitive(function.StrongReturnType!) : function.StrongReturnType!.ToCSString();
            string primitiveReturnType = SwapUnderlyingTypeForPrimitive(function.StrongReturnType!);
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
            List<VendorFunctions> groups,
            Dictionary<Function, FunctionDocumentation> documentation)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, $"{strings.FileNamePrefix}.Native.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine($"// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using OpenTK.Compute2;");

            writer.WriteLine();
            writer.WriteLine($"namespace {Namespace}.{strings.Namespace}");
            using (writer.CsScope())
            {
                writer.WriteLine($"public static unsafe partial class {strings.ApiName}");
                using (writer.CsScope())
                {
                    foreach (var group in groups)
                    {
                        CsScope? scope = null;
                        if (!string.IsNullOrWhiteSpace(group.Vendor))
                        {
                            writer.WriteLine($"/// <summary>{group.Vendor} extensions.</summary>");
                            writer.WriteLine($"public static unsafe partial class {group.Vendor}");
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

        private static void WriteNativeFunction(IndentedTextWriter writer, Function function, bool postfixName, FunctionDocumentation? documentation, string apiName)
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
                WriteDocumentation(writer, function, documentation);
            }

            if (handleAbiDifferenceForTypesafeHandles)
            {
                // Here we just cast and return the correct return type in the public facing function.
                // This works because all of the structs that get here should have a defined cast from the primitive type to the struct type.
                // These casts need to be added manually for this to work correctly.
                // - 2021-06-22

                if (function.StrongReturnType is CSBool8)
                {
                    // HACK: We can't cast byte to bool, sigh...
                    writer.WriteLine($"public static {function.StrongReturnType!.ToCSString()} {name}({signature}) => {apiName}Pointers.{entryPoint}_Lazy({paramNames}) != 0;");
                }
                else
                {
                    writer.WriteLine($"public static {function.StrongReturnType!.ToCSString()} {name}({signature}) => ({function.StrongReturnType!.ToCSString()}) {apiName}Pointers.{entryPoint}_Lazy({paramNames});");
                }
            }
            else
            {
                writer.WriteLine($"public static {returnType} {name}({signature}) => {apiName}Pointers.{entryPoint}_Lazy({paramNames});");
            }

            writer.WriteLine();
        }

        private static void WriteOverloads(
            string directoryPath,
            FileStrings strings,
            List<VendorFunctions> groups)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, $"{strings.FileNamePrefix}.Overloads.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine($"// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using OpenTK.Core.Native;");
            writer.WriteLine("using OpenTK.Mathematics;");
            writer.WriteLine("using OpenTK.Compute2;");

            writer.WriteLine();
            writer.WriteLine($"namespace {Namespace}.{strings.Namespace}");
            using (writer.CsScope())
            {
                // FIXME: Maybe we want to fix this?
                writer.WriteLine($"public static unsafe partial class {strings.ApiName}");
                using (writer.CsScope())
                {
                    foreach (var group in groups)
                    {
                        CsScope? scope = null;
                        if (!string.IsNullOrWhiteSpace(group.Vendor))
                        {
                            writer.WriteLine($"public static unsafe partial class {group.Vendor}");
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
            string parameterTypes = string.Join(", ", overload.NativeFunction.Parameters.Select(p => p.StrongType!.ToCSString()));

            string nativeFunctionName = overload.NativeFunction.Name;
            if (postfixNativeCall)
            {
                nativeFunctionName += "_";
            }

            writer.WriteLine($"/// <inheritdoc cref=\"{nativeFunctionName}({parameterTypes})\"/>");

            string parameterString = string.Join(", ", overload.InputParameters.Select(p => $"{p.StrongType!.ToCSString()} {p.Name}"));

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
                Function nativeFunction = overload.NativeFunction;
                string name = nativeFunction.Name;
                if (postfixNativeCall) name += "_";

                string arguments = string.Join(", ", nativeFunction.Parameters.Select(p => nameTable[p]));

                if (nativeFunction.StrongReturnType is CSVoid)
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



        private static void WriteStructs(string directoryPath, List<StructType> structs, List<EnumType> enums, NameMangler nameMangler)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Structs.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using OpenTK.Mathematics;");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine();
            writer.WriteLine($"namespace {Namespace}");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");

                foreach (StructType @struct in structs)
                {
                    writer.Write("/// <summary>");
                    if (@struct.VersionInfo != null)
                    {
                        writer.WriteVersionInfo(@struct.VersionInfo);
                    }
                    else
                    {
                        ReadOnlySpan<string> exceptedNames = [
                            ];

                        if (exceptedNames.Contains(@struct.Name) == false)
                        {
                            // FIXME: For now no structs have documentation...
                            //Debug.Assert(false);
                        }
                    }
                    if (@struct.Comment != null)
                    {
                        writer.Write($"{NameMangler.XmlEscapeCharacters(NameMangler.MaybeRemoveStart(@struct.Comment, "// "))}");
                    }
                    if (@struct.ReferencedBy.Count > 0)
                    {
                        if (@struct.Comment != null)
                            writer.Write("<br/>");

                        writer.Write($"Used by {string.Join(", ", @struct.ReferencedBy.Take(3).Select(c => $"<see cref=\"CL.{c.Name}\"/>"))}");
                        if (@struct.ReferencedBy.Count > 3)
                        {
                            writer.Write(", ...");
                        }
                    }
                    writer.WriteLine("</summary>");

                    // FIXME: Make sure to not do name mangling?
                    writer.WriteLine($"/// <remarks><see href=\"FIXME: url to struct docs {@struct.Name}.html\" /></remarks>");

                    WriteStruct(writer, @struct, enums, nameMangler);
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }

        private static void WriteStruct(IndentedTextWriter writer, StructType @struct, List<EnumType> enums, NameMangler nameMangler)
        {
            if (@struct.Union)
            {
                writer.WriteLine($"[StructLayout(LayoutKind.Explicit)]");
            }

            writer.WriteLine($"public unsafe struct {@struct.Name}");
            using (writer.CsScope())
            {
                int bitfieldCount = 0;
                int underlyingBitwidth = -1;
                int bitsLeft = -1;

                bool canWriteSimpleCtor = (@struct.Union == false);
                foreach (StructMember member in @struct.Members)
                {
                    static void WriteMemeberDocs(IndentedTextWriter writer, StructMember member)
                    {
                        writer.Write("/// <summary>");
                        if (member.ExternSync.Type != ExternSyncType.None)
                        {
                            writer.Write($"[extern sync: {member.ExternSync}] ");
                        }
                        if (string.IsNullOrEmpty(member.Comment) == false)
                        {
                            writer.Write(NameMangler.XmlEscapeCharacters(member.Comment));
                        }
                        writer.WriteLine("</summary>");
                    }

                    // FIXME: What do we do with these?
                    if (member.StrongType is CSNotSupportedType notSupported)
                    {
                        // We can't have unsupported types in our ctor
                        canWriteSimpleCtor &= false;

                        Console.WriteLine($"Unsupported type '{notSupported.UnsupportedType}' in struct {@struct.Name}!");
                        writer.WriteLine($"// Unsupported type for field {member.Name}");
                        continue;
                    }
                    else if (member.StrongType is CSFixedSizeArray csFixedSizeArray)
                    {
                        // We can't have fixed sized arrays in our ctor
                        canWriteSimpleCtor &= false;

                        WriteInlineArray(writer, @struct.Union, member, csFixedSizeArray, 1, nameMangler);

                        static void WriteInlineArray(IndentedTextWriter writer, bool union, StructMember member, CSFixedSizeArray csFixedSizeArray, int level, NameMangler nameMangler)
                        {
                            // FIXME: Reference the constant instead of just emitting a magic number!
                            if (csFixedSizeArray.BaseType is CSFixedSizeArray csFixedSizeArray2)
                            {
                                //FIXME: Figure out the name recursion 
                                string helperTypeName = $"{member.Name}InlineArray{level++}";
                                writer.WriteLine($"[InlineArray({csFixedSizeArray.Size})]");
                                writer.WriteLine($"public struct {helperTypeName}");
                                using (writer.CsScope())
                                {
                                    WriteInlineArray(writer, false, member, csFixedSizeArray2, level, nameMangler);
                                    //writer.WriteLine($"public {member.Name}InlineArray{level} element;");
                                }

                                if (level == 1)
                                {
                                    WriteMemeberDocs(writer, member);
                                }
                                if (union)
                                {
                                    writer.WriteLine($"[FieldOffset(0)]");
                                }
                                writer.WriteLine($"public {helperTypeName} {member.Name};");
                            }
                            else if (csFixedSizeArray.BaseType is not CSPrimitive csPrimitive || csPrimitive.TypeName == "IntPtr" || level > 1)
                            {
                                string helperTypeName = $"{member.Name}InlineArray{level}";
                                writer.WriteLine($"[InlineArray({csFixedSizeArray.Size})]");
                                writer.WriteLine($"public struct {helperTypeName}");
                                using (writer.CsScope())
                                {
                                    writer.WriteLine($"public {csFixedSizeArray.BaseType.ToCSString()} element;");
                                }

                                if (level == 1)
                                {
                                    WriteMemeberDocs(writer, member);
                                }
                                if (union)
                                {
                                    writer.WriteLine($"[FieldOffset(0)]");
                                }
                                writer.WriteLine($"public {helperTypeName} {member.Name};");
                            }
                            else
                            {
                                if (level == 1)
                                {
                                    WriteMemeberDocs(writer, member);
                                }
                                if (union)
                                {
                                    writer.WriteLine($"[FieldOffset(0)]");
                                }
                                writer.WriteLine($"public fixed {csFixedSizeArray.BaseType.ToCSString()} {nameMangler.MangleStructMemberName(member.Name)}[{csFixedSizeArray.Size}];");
                            }
                        }
                    }
                    else if (member.StrongType is CSBitfield csBitfield)
                    {
                        // FIXME: For now we disable ctors for structs with bitfields
                        canWriteSimpleCtor &= false;

                        if (csBitfield.UnderlyingType is IBitwidthCSType bitwidthType)
                        {
                            if (bitwidthType.BitWidth == null)
                            {
                                Debug.Assert(false, $"No valid bitwidth for: {bitwidthType}");
                            }
                            else
                            {
                                int underlyingWidth = bitwidthType.BitWidth.Value;
                                int actualWidth = csBitfield.BitWidth;

                                if (underlyingWidth != underlyingBitwidth || bitsLeft < actualWidth)
                                {
                                    writer.WriteLine($"private {csBitfield.UnderlyingType.ToCSString()} _bitfield{bitfieldCount++};");
                                    underlyingBitwidth = underlyingWidth;
                                    bitsLeft = underlyingWidth;
                                }

                                Debug.Assert(underlyingBitwidth > 0);
                                Debug.Assert(bitsLeft > 0);

                                int size = actualWidth;
                                int offset = underlyingBitwidth - bitsLeft;
                                WriteMemeberDocs(writer, member);
                                writer.WriteLine($"public {csBitfield.UnderlyingType.ToCSString()} {nameMangler.MangleStructMemberName(member.Name)}");
                                using (writer.CsScope())
                                {
                                    // FIXME: Do only 1u if the underlying type is unsigned...?
                                    writer.WriteLine($"get => ({csBitfield.UnderlyingType.ToCSString()})((_bitfield{bitfieldCount - 1} >> {offset}) & 0x{(1u << size) - 1u:X}u);");
                                    BaseCSType targetType = csBitfield.UnderlyingType;
                                    if (targetType is CSEnum csBitfieldEnum)
                                    {
                                        targetType = csBitfieldEnum.PrimitiveType;
                                    }
                                    writer.WriteLine($"set => _bitfield{bitfieldCount - 1} = (_bitfield{bitfieldCount - 1} & ~(0x{(1u << size) - 1u:X}u << {offset})) | (((({targetType.ToCSString()})value) & 0x{(1u << size) - 1u:X}u) << {offset});");

                                }
                                bitsLeft -= actualWidth;
                            }
                        }
                        else
                        {
                            Debug.Assert(false, $"Not bitwidth type: {csBitfield.UnderlyingType}");
                        }
                    }
                    else
                    {
                        WriteMemeberDocs(writer, member);
                        if (@struct.Union)
                        {
                            writer.WriteLine($"[FieldOffset(0)]");
                        }
                        writer.WriteLine($"public {member.StrongType!.ToCSString()} {nameMangler.MangleStructMemberName(member.Name)};");
                    }
                }

                // Write empty ctor so our default values can apply.
                {
                    writer.WriteLine($"public {@struct.Name}() {{ }}");
                }

                if (canWriteSimpleCtor && @struct.Members.Count > 0)
                {
                    StringBuilder signature = new StringBuilder();
                    foreach (StructMember member in @struct.Members)
                    {
                        signature.Append($"{member.StrongType!.ToCSString()} {nameMangler.MangleStructMemberName(member.Name)}, ");
                    }
                    if (@struct.Members.Count > 0)
                    {
                        signature.Length -= 2;
                    }

                    writer.WriteLine($"public {@struct.Name}({signature})");
                    using (writer.CsScope())
                    {
                        foreach (StructMember member in @struct.Members)
                        {
                            string memberName = nameMangler.MangleStructMemberName(member.Name);
                            writer.WriteLine($"this.{memberName} = {memberName};");
                        }
                    }
                }
            }

            static EnumMember? FindEnumMember(List<EnumType> enums, string memberName)
            {
                foreach (EnumType @enum in enums)
                {
                    foreach (EnumMember member in @enum.Members)
                    {
                        if (member.Name == memberName)
                        {
                            return member;
                        }
                    }
                }

                return null;
            }
        }


        private static void WriteDocumentation(IndentedTextWriter writer, Function function, FunctionDocumentation documentation)
        {
            writer.Write("/// <summary> ");
            writer.WriteVersionInfo(documentation.VersionInfo);
            writer.Write($"<b>[entry point: <c>{function.EntryPoint}</c>]</b><br/>");
            writer.WriteLine($" {documentation.Purpose} </summary>");

            for (int i = 0; i < documentation.Parameters.Length; i++)
            {
                ParameterDocumentation parameterDoc = documentation.Parameters[i];
                Parameter parameter = function.Parameters[i];

                // We use the parameter name here, if the documentation uses another name
                // we've already warned about this, and using the name the C# documentation
                // system expects reduces a lot of the warnings that are generated.
                // - Noggin_bops 2025-08-08
                writer.WriteLine($"/// <param name=\"{NameMangler.MaybeRemoveStart(parameter.Name, "@")}\">{parameterDoc.Description}</param>");
            }

            if (documentation.RefPagesLinks.Count > 0)
            {
                writer.WriteLine($"/// <remarks>{string.Join("<br/>", documentation.RefPagesLinks.Select(url => url.ToSeeXmlTag()))}</remarks>");
            }
        }

        private static void WriteEnumMemberDocumentation(IndentedTextWriter writer, EnumMember member)
        {
            writer.Write($"/// <summary>");
            writer.WriteVersionInfo(member.VersionInfo!);
            writer.WriteLine("</summary>");
            writer.WriteLine($"/// <remarks>[originally: {member.OriginalName}]</remarks>");
        }

        private static void WriteEnums(string directoryPath, FileStrings strings, List<EnumType> enumGroups)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Enums.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine($"// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            writer.WriteLine($"namespace {Namespace}.{strings.Namespace}");
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

        private static void WriteEnumGroups(IndentedTextWriter writer, string apiName, List<EnumType> enumGroups)
        {
            foreach (var group in enumGroups)
            {
                if (group.FunctionsUsingEnumGroup.Count > 0)
                {
                    Logger.Info($"references: {group.FunctionsUsingEnumGroup.Count}");
                    if (group.FunctionsUsingEnumGroup.Count > 3)
                    {
                        writer.WriteLine($"///<summary>Used in {string.Join(", ", group.FunctionsUsingEnumGroup.Take(3).Select(f => $"<see cref=\"{apiName}.{(f.Vendor != "" ? $"{f.Vendor}." : "")}{f.Function.Name}\" />"))}, ...</summary>");
                    }
                    else
                    {
                        writer.WriteLine($"///<summary>Used in {string.Join(", ", group.FunctionsUsingEnumGroup.Select(f => $"<see cref=\"{apiName}.{(f.Vendor != "" ? $"{f.Vendor}." : "")}{f.Function.Name}\" />"))}</summary>");
                    }
                }

                if (group.IsFlags) writer.WriteLine($"[Flags]");
                writer.WriteLine($"public enum {group.Name} : uint");
                using (writer.CsScope())
                {
                    foreach (var member in group.Members)
                    {
                        WriteEnumMemberDocumentation(writer, member);

                        // HACK: Some enums have a value of -1, and because
                        // we don't know the bitwidth of the enum here we can't cast
                        // the value correctly. This hack fixes this for -1 but doesn't
                        // work for any other negative numbers...
                        // - Noggin_bops 2024-11-11
                        if (member.Value == ulong.MaxValue)
                        {
                            writer.WriteLine($"{member.Name} = unchecked((uint)-1),");
                        }
                        else
                        {
                            writer.WriteLine($"{member.Name} = {member.Value},");
                        }
                    }
                }
            }
        }
    }
}
