using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VkGenerator.Parsing;
using VkGenerator.Process;
using VkGenerator.Utility;
using VkGenerator.Utility.Extensions;

namespace VkGenerator
{
    internal static class Writer
    {
        private const string BaseNamespace = "OpenTK";
        private const string GraphicsNamespace = BaseNamespace + ".Graphics";
        private const string VulkanNamespace = GraphicsNamespace + ".Vulkan";

        private const string LoaderClass = "VKLoader";

        public static void Write(SpecificationData data)
        {
            // This is quite fragile, no idea if there is an easy way that is "better".
            string outputProjectPath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new NullReferenceException(),
                "..", "..", "..", "..", GraphicsNamespace);

            string directoryPath = Path.Combine(outputProjectPath, "Vulkan");
            if (Directory.Exists(directoryPath) == false) Directory.CreateDirectory(directoryPath);

            WriteEnums(directoryPath, data.Enums);

            WriteStructs(directoryPath, data.Structs, data.Enums);
            WriteHandles(directoryPath, data.Handles);

            WriteFunctionPointers(directoryPath, data.Commands);
            WriteCommands(directoryPath, data.Commands);
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
                    writer.WriteLine($"public enum {@enum.Name} : int");
                    using (writer.CsScope())
                    {
                        foreach (EnumMember member in @enum.Members)
                        {
                            string? comment = NameMangler.MaybeRemoveStart(member.Comment, "// ");
                            if (member.Extension != null)
                            {
                                writer.WriteLine($"/// <summary>[requires: {member.Extension}]{comment}</summary>");
                            }
                            else if (comment != null)
                            {
                                writer.WriteLine($"/// <summary>{comment}</summary>");
                            }
                            writer.WriteLine($"{NameMangler.MangleEnumName(member.Name)} = {member.Value},");
                        }
                    }
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }

        private static void WriteStructs(string directoryPath, List<StructType> structs, List<EnumType> enums)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Structs.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using OpenTK.Mathematics;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH264;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH264.Decode;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH264.Encode;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH265;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH265.Decode;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH265.Encode;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecAV1;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecAV1.Decode;");
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

                    if (@struct.Union)
                    {
                        writer.WriteLine($"[StructLayout(LayoutKind.Explicit)]");
                    }

                    // FIXME: Figure out the right underlying type!s
                    writer.WriteLine($"public unsafe struct {@struct.Name}");
                    using (writer.CsScope())
                    {
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

                                if (csFixedSizeArray.BaseType is not CSPrimitive csPrimitive || csPrimitive.TypeName == "IntPtr")
                                {
                                    string helperTypeName = $"{member.Name}InlineArray";
                                    writer.WriteLine($"[InlineArray({csFixedSizeArray.Size})]");
                                    writer.WriteLine($"public struct {helperTypeName}");
                                    using (writer.CsScope())
                                    {
                                        writer.WriteLine($"public {csFixedSizeArray.BaseType.ToCSString()} element;");
                                    }

                                    if (@struct.Union)
                                    {
                                        writer.WriteLine($"[FieldOffset(0)]");
                                    }
                                    writer.WriteLine($"public {helperTypeName} {member.Name};");
                                }
                                else
                                {
                                    if (@struct.Union)
                                    {
                                        writer.WriteLine($"[FieldOffset(0)]");
                                    }
                                    writer.WriteLine($"public fixed {csFixedSizeArray.BaseType.ToCSString()} {NameMangler.MangleMemberName(member.Name)}[{csFixedSizeArray.Size}];");
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

        private static void WriteCommands(string directoryPath, List<Command> commands)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Vulkan.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using OpenTK.Mathematics;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH264;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH264.Decode;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH264.Encode;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH265;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH265.Decode;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH265.Encode;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecAV1;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecAV1.Decode;");
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

        private static void WriteFunctionPointers(string directoryPath, List<Command> commands)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Vulkan.Pointers.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using OpenTK.Mathematics;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH264;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH264.Decode;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH264.Encode;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH265;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH265.Decode;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecH265.Encode;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecAV1;");
            writer.WriteLine($"using {GraphicsNamespace}.Vulkan.VideoCodecAV1.Decode;");
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
    }
}
