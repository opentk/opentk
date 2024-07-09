using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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

        public static void Write(SpecificationData data)
        {
            // This is quite fragile, no idea if there is an easy way that is "better".
            string outputProjectPath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new NullReferenceException(),
                "..", "..", "..", "..", GraphicsNamespace);

            string directoryPath = Path.Combine(outputProjectPath, "Vulkan");
            if (Directory.Exists(directoryPath) == false) Directory.CreateDirectory(directoryPath);

            WriteEnums(directoryPath, data.Enums);

            WriteStructs(directoryPath, data.Structs);

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
                            writer.WriteLine($"{NameMangler.MangleEnumName(member.Name)} = {member.Value},");
                        }
                    }
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }

        private static void WriteStructs(string directoryPath, List<StructType> structs)
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
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.Vulkan");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");

                foreach (StructType @struct in structs)
                {
                    // FIXME: Figure out the right underlying type!s
                    writer.WriteLine($"public unsafe struct {@struct.Name}");
                    using (writer.CsScope())
                    {
                        foreach (StructMember member in @struct.Members)
                        {
                            // FIXME: What do we do with these?
                            if (member.StrongType is CSNotSupportedType)
                            {
                                continue;
                            }
                            else if (member.StrongType is CSFixedSizeArray csFixedSizeArray)
                            {
                                if (csFixedSizeArray.BaseType is not CSPrimitive csPrimitive || csPrimitive.TypeName == "IntPtr")
                                {
                                    string helperTypeName = $"{member.Name}InlineArray";
                                    writer.WriteLine($"[InlineArray({csFixedSizeArray.Size})]");
                                    writer.WriteLine($"public struct {helperTypeName}");
                                    using (writer.CsScope())
                                    {
                                        writer.WriteLine($"public {csFixedSizeArray.BaseType.ToCSString()} element;");
                                    }

                                    writer.WriteLine($"public {helperTypeName} {member.Name};");
                                }
                                else
                                {
                                    writer.WriteLine($"public fixed {csFixedSizeArray.BaseType.ToCSString()} {NameMangler.MangleMemberName(member.Name)}[{csFixedSizeArray.Size}];");
                                }
                            }
                            else
                            {
                                writer.WriteLine($"public {member.StrongType!.ToCSString()} {NameMangler.MangleMemberName(member.Name)};");
                            }
                        }
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
