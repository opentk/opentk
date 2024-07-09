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

namespace VkGenerator
{
    internal static class Writer
    {
        private const string BaseNamespace = "OpenTK";
        private const string GraphicsNamespace = BaseNamespace + ".Graphics";
        private const string VulkanNamespace = GraphicsNamespace + ".Vulkan";

        private const string LoaderClass = "VKLoader";
        private const string LoaderBindingsContext = LoaderClass + ".BindingsContext";

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
                                    writer.WriteLine($"public fixed {csFixedSizeArray.BaseType.ToCSString()} {member.Name}[{csFixedSizeArray.Size}];");
                                }
                            }
                            else
                            {
                                writer.WriteLine($"public {member.StrongType!.ToCSString()} {member.Name};");
                            }
                        }
                    }
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }
    }
}
