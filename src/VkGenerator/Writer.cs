using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using VkGenerator.Parsing;
using VkGenerator.Process;
using VkGenerator.Utility;
using VkGenerator.Utility.Extensions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VkGenerator
{
    internal static class Writer
    {
        private const string BaseNamespace = "OpenTK";
        private const string GraphicsNamespace = BaseNamespace + ".Graphics";
        private const string VulkanNamespace = GraphicsNamespace + ".Vulkan";

        private const string LoaderClass = "VKLoader";

        public static void Write(SpecificationData data, SpecificationData video)
        {
            // This is quite fragile, no idea if there is an easy way that is "better".
            string outputProjectPath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new NullReferenceException(),
                "..", "..", "..", "..", GraphicsNamespace);

            string directoryPath = Path.Combine(outputProjectPath, "Vulkan");
            if (Directory.Exists(directoryPath) == false) Directory.CreateDirectory(directoryPath);

            WriteEnums(directoryPath, data.Enums);

            WriteStructs(directoryPath, data.Structs, data.Enums, video);
            WriteHandles(directoryPath, data.Handles);

            WriteFunctionPointers(directoryPath, data.Commands, video);
            WriteCommands(directoryPath, data.Commands, video);

            WriteConstants(directoryPath, data.Constants);
        }

        private static void WriteEnums(string directoryPath, List<EnumType> enums)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Enums.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.Vulkan");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");

                foreach (EnumType @enum in enums)
                {
                    if (@enum.Bitmask)
                    {
                        writer.WriteLine("[Flags]");
                    }

                    // FIXME: Figure out the right underlying type!s
                    writer.WriteLine($"public enum {@enum.Name} : {@enum.StrongUnderlyingType?.ToCSString() ?? throw new Exception()}");
                    using (writer.CsScope())
                    {
                        foreach (EnumMember member in @enum.Members)
                        {
                            string? comment = NameMangler.MaybeRemoveStart(member.Comment, "// ");
                            if (member.Extension != null)
                            {
                                writer.WriteLine($"/// <summary>[requires: <b>{member.Extension}</b>]{comment}</summary>");
                            }
                            else if (comment != null)
                            {
                                writer.WriteLine($"/// <summary>{comment}</summary>");
                            }

                            if (@enum.StrongUnderlyingType == CSPrimitive.Int(true))
                            {
                                writer.WriteLine($"{NameMangler.MangleEnumName(member.Name)} = {(int)member.Value},");
                            }
                            else if (@enum.StrongUnderlyingType == CSPrimitive.Uint(true))
                            {
                                writer.WriteLine($"{NameMangler.MangleEnumName(member.Name)} = {(uint)member.Value},");
                            }
                            else if (@enum.StrongUnderlyingType == CSPrimitive.Ulong(true))
                            {
                                writer.WriteLine($"{NameMangler.MangleEnumName(member.Name)} = {(ulong)member.Value},");
                            }
                            else
                            {
                                Debug.Assert(false);
                            }
                        }
                    }
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }

        private static void WriteStructs(string directoryPath, List<StructType> structs, List<EnumType> enums, SpecificationData video)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Structs.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using OpenTK.Mathematics;");
            foreach (Extension extension in video.Extensions)
            {
                writer.WriteLine($"using {GraphicsNamespace}.Vulkan.{NameMangler.MangleExtensionName(extension.Name)};");
            }
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.Vulkan");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");

                foreach (StructType @struct in structs)
                {
                    if (@struct.Comment != null)
                    {
                        writer.WriteLine($"/// <summary>{NameMangler.MaybeRemoveStart(@struct.Comment, "// ")}</summary>");
                    }

                    WriteStruct(writer, @struct, enums);
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }

        private static void WriteHandles(string directoryPath, List<HandleType> handles)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Handles.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Diagnostics;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.Vulkan");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");

                foreach (HandleType handle in handles)
                {
                    // FIXME: Figure out the right underlying type!s
                    writer.WriteLine($"[DebuggerDisplay(\"{handle.Name}\\\\{{{{Handle}}\\\\}}\")]");
                    writer.WriteLine($"public unsafe struct {handle.Name} : IEquatable<{handle.Name}>");
                    using (writer.CsScope())
                    {
                        writer.WriteLine($"public static {handle.Name} Zero => new {handle.Name}(0);");
                        writer.WriteLine($"public ulong Handle;");
                        writer.WriteLine($"public {handle.Name}(ulong handle) => Handle = handle;");
                        writer.WriteLine($"public override bool Equals(object? obj) => obj is {handle.Name} instance && Equals(instance);");
                        writer.WriteLine($"public bool Equals({handle.Name} other) => Handle.Equals(other.Handle);");
                        writer.WriteLine($"public override int GetHashCode() => HashCode.Combine(Handle);");
                        writer.WriteLine($"public override string? ToString() => Handle.ToString();");
                        writer.WriteLine($"public static bool operator ==({handle.Name} left, {handle.Name} right) => left.Equals(right);");
                        writer.WriteLine($"public static bool operator !=({handle.Name} left, {handle.Name} right) => !(left == right);");
                        writer.WriteLine($"public static explicit operator ulong({handle.Name} handle) => handle.Handle;");
                        writer.WriteLine($"public static explicit operator {handle.Name}(ulong handle) => new {handle.Name}(handle);");
                    }
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }

        private static void WriteCommands(string directoryPath, List<Command> commands, SpecificationData video)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Vulkan.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using OpenTK.Mathematics;");
            foreach (Extension extension in video.Extensions)
            {
                writer.WriteLine($"using {GraphicsNamespace}.Vulkan.{NameMangler.MangleExtensionName(extension.Name)};");
            }
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.Vulkan");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");

                writer.WriteLine("public static unsafe partial class Vk");
                using (writer.CsScope())
                {
                    foreach (Command command in commands)
                    {
                        string entryPoint = command.Name;
                        string functionName = NameMangler.MangleFunctionName(command.Name);

                        StringBuilder signature = new StringBuilder();
                        StringBuilder paramNames = new StringBuilder();
                        foreach (CommandParameter parameter in command.Parameters)
                        {
                            string name = NameMangler.MangleParameterName(parameter.Name);
                            string type = parameter.StrongType!.ToCSString();
                            signature.Append($"{type} {name}, ");
                            paramNames.Append($"{name}, ");
                        }
                        signature.Length -= 2;
                        paramNames.Length -= 2;

                        writer.WriteLine($"public static {command.StrongReturnType!.ToCSString()} {functionName}({signature})");
                        using (writer.CsScope())
                        {
                            if (command.StrongReturnType is not CSVoid)
                            {
                                writer.WriteLine($"return VkPointers._{entryPoint}_fnptr({paramNames});");
                            }
                            else
                            {
                                writer.WriteLine($"VkPointers._{entryPoint}_fnptr({paramNames});");
                            }
                        }
                    }
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }

        private static void WriteFunctionPointers(string directoryPath, List<Command> commands, SpecificationData video)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Vulkan.Pointers.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using OpenTK.Mathematics;");
            foreach (Extension extension in video.Extensions)
            {
                writer.WriteLine($"using {GraphicsNamespace}.Vulkan.{NameMangler.MangleExtensionName(extension.Name)};");
            }
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.Vulkan");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");

                writer.WriteLine("public static unsafe partial class VkPointers");
                using (writer.CsScope())
                {
                    foreach (Command command in commands)
                    {
                        string entryPoint = command.Name;

                        StringBuilder signature = new StringBuilder();
                        StringBuilder delegateTypes = new StringBuilder();
                        StringBuilder paramNames = new StringBuilder();
                        foreach (CommandParameter parameter in command.Parameters)
                        {
                            string name = NameMangler.MangleParameterName(parameter.Name);
                            string type = parameter.StrongType!.ToCSString();
                            signature.Append($"{type} {name}, ");
                            delegateTypes.Append($"{type}, ");
                            paramNames.Append($"{name}, ");
                        }
                        signature.Length -= 2;
                        paramNames.Length -= 2;

                        delegateTypes.Append($"{command.StrongReturnType!.ToCSString()}");

                        writer.WriteLine($"internal static delegate* unmanaged<{delegateTypes}> _{entryPoint}_fnptr = &{entryPoint}_Lazy;");

                        writer.WriteLine($"[UnmanagedCallersOnly]");
                        writer.WriteLine($"private static {command.StrongReturnType!.ToCSString()} {entryPoint}_Lazy({signature})");
                        using (writer.CsScope())
                        {
                            // Dotnet gurantees you can't get torn values when assigning functionpointers, assuming proper allignment which is default.
                            writer.WriteLine($"_{entryPoint}_fnptr = (delegate* unmanaged<{delegateTypes}>){LoaderClass}.GetInstanceProcAddress(\"{entryPoint}\");");

                            if (command.StrongReturnType is not CSVoid)
                            {
                                writer.WriteLine($"return _{entryPoint}_fnptr({paramNames});");
                            }
                            else
                            {
                                writer.WriteLine($"_{entryPoint}_fnptr({paramNames});");
                            }
                        }
                    }
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }

        private static void WriteConstants(string directoryPath, Dictionary<string, Constant> constants)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Constants.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using OpenTK.Mathematics;");
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.Vulkan");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");

                writer.WriteLine("public static unsafe partial class Vk");
                using (writer.CsScope())
                {
                    foreach ((string name, Constant constant) in constants)
                    {
                        if (constant.Extension != null)
                        {
                            writer.WriteLine($"/// <summary>[from: <b>{constant.Extension}</b>]{constant.Comment}</summary>");
                        }
                        else if (constant.Comment != null)
                        {
                            writer.WriteLine($"/// <summary>{constant.Comment}</summary>");
                        }

                        switch (constant.Type)
                        {
                            case ConstantType.Int32:
                                writer.WriteLine($"public const int {NameMangler.MangleConstantName(name)} = {(int)constant.IntValue};");
                                break;
                            case ConstantType.Uint32:
                                writer.WriteLine($"public const uint {NameMangler.MangleConstantName(name)} = {(uint)constant.IntValue};");
                                break;
                            case ConstantType.Uint64:
                                writer.WriteLine($"public const ulong {NameMangler.MangleConstantName(name)} = {(ulong)constant.IntValue};");
                                break;
                            case ConstantType.Float:
                                writer.WriteLine($"public const float {NameMangler.MangleConstantName(name)} = {(int)constant.FloatValue};");
                                break;
                            case ConstantType.String:
                                // FIXME: Should expose these are string and/or ReadOnlySpan<byte>?
                                writer.WriteLine($"public const string {NameMangler.MangleConstantName(name)} = {constant.StringValue};");
                                break;
                            default:
                                throw new Exception();
                        }
                    }
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }


        public static void WriteVideo(SpecificationData video)
        {
            // This is quite fragile, no idea if there is an easy way that is "better".
            string outputProjectPath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new NullReferenceException(),
                "..", "..", "..", "..", GraphicsNamespace);

            string directoryPath = Path.Combine(outputProjectPath, "Vulkan");
            if (Directory.Exists(directoryPath) == false) Directory.CreateDirectory(directoryPath);


            WriteVideoNamespace(directoryPath, video);
        }

        private static void WriteVideoNamespace(string directoryPath, SpecificationData video)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Video.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            foreach (Extension extension in video.Extensions)
            {
                writer.WriteLine($"using {GraphicsNamespace}.Vulkan.{NameMangler.MangleExtensionName(extension.Name)};");
            }
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.CompilerServices;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.Vulkan");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");

                foreach (Extension extension in video.Extensions)
                {
                    writer.WriteLine($"namespace {NameMangler.MangleExtensionName(extension.Name)}");
                    using (writer.CsScope())
                    {
                        // FIXME: Consolidate all require stuff into one single thing so we
                        // don't get multiple constant classes for example.
                        foreach (RequireTag requireTag in extension.RequireTags)
                        {
                            writer.WriteLine($"public static class Constants");
                            using (writer.CsScope())
                            {
                                foreach (Constant constant in requireTag.Constants)
                                {
                                    switch (constant.Type)
                                    {
                                        case ConstantType.Int32:
                                            writer.WriteLine($"public const int {NameMangler.MangleConstantName(constant.Name)} = {(int)constant.IntValue};");
                                            break;
                                        case ConstantType.Uint32:
                                            writer.WriteLine($"public const uint {NameMangler.MangleConstantName(constant.Name)} = {(uint)constant.IntValue};");
                                            break;
                                        case ConstantType.Uint64:
                                            writer.WriteLine($"public const ulong {NameMangler.MangleConstantName(constant.Name)} = {(ulong)constant.IntValue};");
                                            break;
                                        case ConstantType.Float:
                                            writer.WriteLine($"public const float {NameMangler.MangleConstantName(constant.Name)} = {constant.FloatValue};");
                                            break;
                                        case ConstantType.String:
                                            writer.WriteLine($"/// <summary>{NameMangler.XmlEscapeCharacters(constant.StringValue)}</summary>");
                                            writer.WriteLine($"public static ReadOnlySpan<byte> {NameMangler.MangleConstantName(constant.Name)} => {constant.StringValue}u8;");
                                            break;
                                        default:
                                            throw new Exception();
                                    }
                                }
                            }

                            foreach (RequireType requiredType in requireTag.RequiredTypes)
                            {
                                EnumType? @enum = video.Enums.Find(e => e.Name == requiredType.Name);
                                StructType? @struct = video.Structs.Find(s => s.Name == requiredType.Name);
                                if (@enum != null)
                                {
                                    // FIXME: Mangle the enum name?
                                    writer.WriteLine($"public enum {@enum.Name} : uint");
                                    using (writer.CsScope())
                                    {
                                        foreach (EnumMember member in @enum.Members)
                                        {
                                            Debug.Assert(member.Extension == null, "As of 2024-07-15 video.xml doesn't specify extends on enums.");

                                            string? comment = NameMangler.MaybeRemoveStart(member.Comment, "// ");
                                            if (comment != null)
                                            {
                                                writer.WriteLine($"/// <summary>{comment}</summary>");
                                            }
                                            writer.WriteLine($"{NameMangler.MangleEnumName(member.Name)} = {member.Value},");
                                        }
                                    }
                                }
                                else if (@struct != null)
                                {
                                    WriteStruct(writer, @struct, video.Enums);
                                }
                                else
                                {
                                    Console.WriteLine($"Could not find {requiredType.Name}");
                                }
                            }
                        }
                    }
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }



        private static void WriteStruct(IndentedTextWriter writer, StructType @struct, List<EnumType> enums)
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
                bool hasSType = false;
                foreach (StructMember member in @struct.Members)
                {
                    // FIXME: What do we do with these?
                    if (member.StrongType is CSNotSupportedType)
                    {
                        // We can't have unsupported types in our ctor
                        canWriteSimpleCtor &= false;

                        Console.WriteLine("Unsupported type in struct!!");
                        writer.WriteLine($"// Unsupported type for field {member.Name}");
                        continue;
                    }
                    else if (member.StrongType is CSFixedSizeArray csFixedSizeArray)
                    {
                        // We can't have fixed sized arrays in our ctor
                        canWriteSimpleCtor &= false;

                        WriteInlineArray(writer, @struct.Union, member, csFixedSizeArray, 1);

                        static void WriteInlineArray(IndentedTextWriter writer, bool union, StructMember member, CSFixedSizeArray csFixedSizeArray, int level)
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
                                    WriteInlineArray(writer, false, member, csFixedSizeArray2, level);
                                    //writer.WriteLine($"public {member.Name}InlineArray{level} element;");
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

                                if (union)
                                {
                                    writer.WriteLine($"[FieldOffset(0)]");
                                }
                                writer.WriteLine($"public {helperTypeName} {member.Name};");
                            }
                            else
                            {
                                if (union)
                                {
                                    writer.WriteLine($"[FieldOffset(0)]");
                                }
                                writer.WriteLine($"public fixed {csFixedSizeArray.BaseType.ToCSString()} {NameMangler.MangleMemberName(member.Name)}[{csFixedSizeArray.Size}];");
                            }
                        }
                    }
                    else if (member.StrongType is CSEnum csEnum && csEnum.TypeName == "VkStructureType" && member.Values != null)
                    {
                        Debug.Assert(@struct.Union == false);
                        Debug.Assert(member.Values.Contains(',') == false, "We assume only one valid value.");
                        Debug.Assert(member.Name == "sType" && member.Type == "VkStructureType", "Atm we only support sType values.");
                        // FIXME: Assert that the enum member is from the VkStructureType enum!
                        EnumMember? enumMember = Processor.FindEnumMember(enums, member.Values);
                        if (enumMember == null)
                        {
                            Console.WriteLine($"Could't find sType '{member.Values}'");
                            writer.WriteLine($"public {member.StrongType!.ToCSString()} {NameMangler.MangleMemberName(member.Name)};");
                        }
                        else
                        {
                            hasSType = true;

                            writer.WriteLine($"public {member.StrongType!.ToCSString()} {NameMangler.MangleMemberName(member.Name)} = VkStructureType.{NameMangler.MangleEnumName(member.Values)};");
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
                                writer.WriteLine($" // TODO: Accessor property for {member.Name}, size: {actualWidth}, offset: {underlyingBitwidth - bitsLeft}");
                                writer.WriteLine($"public {csBitfield.UnderlyingType.ToCSString()} {NameMangler.MangleMemberName(member.Name)}");
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
                        if (@struct.Union)
                        {
                            writer.WriteLine($"[FieldOffset(0)]");
                        }
                        writer.WriteLine($"public {member.StrongType!.ToCSString()} {NameMangler.MangleMemberName(member.Name)};");
                    }
                }

                if (canWriteSimpleCtor)
                {
                    StringBuilder signature = new StringBuilder();
                    foreach (StructMember member in @struct.Members)
                    {
                        signature.Append($"{member.StrongType!.ToCSString()} {NameMangler.MangleMemberName(member.Name)}, ");
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
                            string memberName = NameMangler.MangleMemberName(member.Name);
                            writer.WriteLine($"this.{memberName} = {memberName};");
                        }
                    }
                }
                else if (hasSType)
                {
                    // A struct with field initializers must include an explicitly declared ctor.
                    // So we just add an empty ctor.
                    // - Noggin_bops 2024-07-10
                    writer.WriteLine($"public {@struct.Name}(){{ }}");
                }
            }
        }

    }
}
