using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text;
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

        public static void Write(SpecificationData data, SpecificationData video)
        {
            // This is quite fragile, no idea if there is an easy way that is "better".
            string outputProjectPath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new NullReferenceException(),
                "..", "..", "..", "..", GraphicsNamespace);

            string directoryPath = Path.Combine(outputProjectPath, "Vulkan");
            if (Directory.Exists(directoryPath) == false) Directory.CreateDirectory(directoryPath);

            WriteDefines(directoryPath, data.Defines, video.Defines);

            WriteEnums(directoryPath, data.Enums);

            WriteStructs(directoryPath, data.Structs, data.Enums, video);
            WriteHandles(directoryPath, data.Handles);

            WriteFunctionPointers(directoryPath, data.Commands, video);
            WriteCommands(directoryPath, data.Commands, video);
            WriteDispatchTables(directoryPath, data.Commands, video);

            WriteConstants(directoryPath, data.Constants);
        }

        private static void WriteDefines(string directoryPath, List<Define> defines, List<Define> videoDefines)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "Defines.cs"));
            using IndentedTextWriter writer = new IndentedTextWriter(stream);
            writer.WriteLine("// This file is auto generated, do not edit.");
            writer.WriteLine("using System;");
            writer.WriteLine();
            writer.WriteLine($"namespace {GraphicsNamespace}.Vulkan");
            using (writer.CsScope())
            {
                writer.WriteLineNoTabs("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");

                writer.WriteLine("public static unsafe partial class Vk");
                using (writer.CsScope())
                {

                    WriteDefines(writer, defines);

                    writer.WriteLine();
                    writer.WriteLine("// Vulkan video macros");
                    writer.WriteLine();

                    WriteDefines(writer, videoDefines);
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }

            static void WriteDefines(IndentedTextWriter writer, List<Define> defines)
            {
                foreach (Define define in defines)
                {
                    if (define.IsConstant == false && define.Implementation == null)
                        continue;

                    writer.Write("/// <summary>");
                    if (define.VersionInfo != null)
                    {
                        WriteVersionInfo(writer, define.VersionInfo);
                    }
                    else
                    {
                        // There are two "valid" reasons why a define would be missing version data.
                        // 1. The only reference to the define is in a disabled extension.
                        //    Currently such defines still get emitted even if no-one references them.
                        // 2. The define is part of vulkansc or a vulkansc extension. We don't deal with vulkancs atm.
                        //
                        // This is a list of the known defines that fullfill any of these criteria.
                        // - Noggin_bops 2025-07-06
                        ReadOnlySpan<string> exceptedNames = [
                                "VKSC_API_VARIANT",
                                "VKSC_API_VERSION_1_0"
                            ];

                        if (exceptedNames.Contains(define.Name) == false)
                        {
                            Debug.Assert(false);
                        }
                    }
                    writer.WriteLine("</summary>");

                    // FIXME: Make sure to not do name mangling?
                    writer.WriteLine($"/// <remarks><see href=\"https://registry.khronos.org/vulkan/specs/latest/man/html/{define.Name}.html\" /></remarks>");

                    if (define.IsConstant)
                    {
                        writer.WriteLine($"public const {define.Type.ToCSString()} {NameMangler.MangleDefineName(define.Name)} = unchecked(({define.Type.ToCSString()}){define.ConstValue});");
                    }
                    else if (define.Implementation != null)
                    {
                        StringBuilder arguments = new StringBuilder();
                        foreach (var arg in define.Arguments)
                        {
                            arguments.Append($"{arg.Type.ToCSString()} {arg.Name}, ");
                        }
                        if (arguments.Length > 0)
                            arguments.Length -= 2;

                        writer.WriteLine($"public static {define.Type.ToCSString()} {NameMangler.MangleDefineName(define.Name)}({arguments}) {{ {define.Implementation} }}");
                    }
                }
            }
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
                    writer.Write("/// <summary>");
                    if (@enum.VersionInfo != null)
                    {
                        WriteVersionInfo(writer, @enum.VersionInfo);
                    }
                    else
                    {
                        // There are three "valid" reasons why a enum type would be missing version data.
                        // 1. The only reference to the enum type is in a disabled extension.
                        //    Currently such enum types still get emitted even if no-one references them.
                        // 2. The enum type is part of vulkansc or a vulkansc extension. We don't deal with vulkancs atm.
                        // 3. The enum doesn't have any values associated with it, this happens with some "Bits" enum that
                        //    have no entries.
                        //
                        // This is a list of the known enum types that fullfill any of these criteria.
                        // - Noggin_bops 2024-09-24
                        ReadOnlySpan<string> exceptedNames = [
                                "VkSemaphoreCreateFlagBits",
                                "VkSwapchainImageUsageFlagBitsANDROID",
                                "VkPrivateDataSlotCreateFlagBits",
                                "VkShaderModuleCreateFlagBits",
                                "VkFaultLevel",
                                "VkFaultType",
                                "VkFaultQueryBehavior",
                                "VkPipelineMatchControl",
                                "VkPipelineCacheValidationVersion",
                                "VkVideoEncodeFlagBitsKHR",
                                "VkImageFormatConstraintsFlagBitsFUCHSIA",
                                "VkWaylandSurfaceCreateFlagBitsKHR",
                            ];

                        if (exceptedNames.Contains(@enum.Name) == false)
                        {
                            Debug.Assert(false);
                        }
                    }
                    if (@enum.ReferencedBy != null)
                    {
                        writer.Write($"Used by {string.Join(", ", @enum.ReferencedBy.Take(3).Select(c => $"<see cref=\"Vk.{NameMangler.MangleFunctionName(c.Name)}\"/>"))}");
                        if (@enum.ReferencedBy.Count > 3)
                        {
                            writer.Write(", ...");
                        }
                    }
                    writer.WriteLine("</summary>");

                    // FIXME: Make sure to not do name mangling?
                    writer.WriteLine($"/// <remarks><see href=\"https://registry.khronos.org/vulkan/specs/latest/man/html/{@enum.Name}.html\" /></remarks>");

                    if (@enum.Bitmask)
                    {
                        writer.WriteLine("[Flags]");
                    }

                    // FIXME: Figure out the right underlying type!
                    writer.WriteLine($"public enum {@enum.Name} : {@enum.StrongUnderlyingType?.ToCSString() ?? throw new Exception()}");
                    using (writer.CsScope())
                    {
                        foreach (EnumMember member in @enum.Members)
                        {
                            if (member.Extension != null && member.VersionInfo != null)
                            {
                                if (member.Extension.StartsWith("VK_VERSION") == false)
                                    Debug.Assert(member.VersionInfo.Extensions.Contains(member.Extension));
                            }

                            writer.Write("/// <summary>");
                            if (member.VersionInfo != null)
                            {
                                List<string> strs = [.. member.VersionInfo.Extensions];
                                if (member.VersionInfo.Version != null)
                                {
                                    strs.Insert(0, $"v{member.VersionInfo.Version.Major}.{member.VersionInfo.Version.Minor}");
                                }
                                writer.Write($"[requires: <b>{string.Join(" | ", strs)}</b>] ");
                            }
                            else
                            {
                                if (@enum.VersionInfo != null)
                                {
                                    // If the enum member didn't have it's own version info, take the one from the enum type.
                                    // This means we assume that if we have no version info for a member it's part of the "base package"
                                    // for this enum type.
                                    // - Noggin_bops 2024-09-24

                                    List<string> strs = [.. @enum.VersionInfo.Extensions];
                                    if (@enum.VersionInfo.Version != null)
                                    {
                                        strs.Insert(0, $"v{@enum.VersionInfo.Version.Major}.{@enum.VersionInfo.Version.Minor}");
                                    }
                                    writer.Write($"[requires: <b>{string.Join(" | ", strs)}</b>] ");
                                }
                                else
                                {
                                    // There are two "valid" reasons why a enum member would be missing version data.
                                    // 1. The only reference to the enum member is in a disabled extension.
                                    //    Currently such enum members still get emitted even if no-one references them.
                                    // 2. The enum member is part of vulkansc or a vulkansc extension. We don't deal with vulkancs atm.
                                    //
                                    // This is a list of the known enum member that fullfill either of these criteria.
                                    // - Noggin_bops 2024-09-24
                                    ReadOnlySpan<(string, string)> exceptedNames = [
                                                ("VkFaultQueryBehavior", "VK_FAULT_QUERY_BEHAVIOR_GET_AND_CLEAR_ALL_FAULTS"),
                                                ("VkPipelineMatchControl", "VK_PIPELINE_MATCH_CONTROL_APPLICATION_UUID_EXACT_MATCH"),
                                                ("VkPipelineCacheValidationVersion", "VK_PIPELINE_CACHE_VALIDATION_VERSION_SAFETY_CRITICAL_ONE"),
                                                ("VkSwapchainImageUsageFlagBitsANDROID", "VK_SWAPCHAIN_IMAGE_USAGE_SHARED_BIT_ANDROID"),
                                                ("VkFaultLevel", "VK_FAULT_LEVEL_UNASSIGNED"),
                                                ("VkFaultLevel", "VK_FAULT_LEVEL_CRITICAL"),
                                                ("VkFaultLevel", "VK_FAULT_LEVEL_RECOVERABLE"),
                                                ("VkFaultLevel", "VK_FAULT_LEVEL_WARNING"),
                                                ("VkFaultType", "VK_FAULT_TYPE_INVALID"),
                                                ("VkFaultType", "VK_FAULT_TYPE_UNASSIGNED"),
                                                ("VkFaultType", "VK_FAULT_TYPE_IMPLEMENTATION"),
                                                ("VkFaultType", "VK_FAULT_TYPE_SYSTEM"),
                                                ("VkFaultType", "VK_FAULT_TYPE_PHYSICAL_DEVICE"),
                                                ("VkFaultType", "VK_FAULT_TYPE_COMMAND_BUFFER_FULL"),
                                                ("VkFaultType", "VK_FAULT_TYPE_INVALID_API_USAGE")
                                            ];

                                    if (exceptedNames.Contains((@enum.Name, member.Name)) == false)
                                    {
                                        Debug.Assert(false);
                                    }
                                }
                            }

                            string? comment = NameMangler.MaybeRemoveStart(member.Comment, "// ");
                            if (comment != null)
                            {
                                writer.Write($"{NameMangler.XmlEscapeCharacters(comment)}");
                            }
                            writer.WriteLine("</summary>");

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
                    writer.Write("/// <summary>");
                    if (@struct.VersionInfo != null)
                    {
                        WriteVersionInfo(writer, @struct.VersionInfo);
                    }
                    else
                    {
                        // There are two "valid" reasons why a struct would be missing version data.
                        // 1. The only reference to the struct is in a disabled extension.
                        //    Currently such structs still get emitted even if no-one references them.
                        // 2. The struct is part of vulkansc or a vulkansc extension. We don't deal with vulkancs atm.
                        //
                        // This is a list of the known structs that fullfill either of these criteria.
                        // - Noggin_bops 2024-09-24
                        ReadOnlySpan<string> exceptedNames = [
                                "VkPipelineCacheStageValidationIndexEntry",
                                "VkPipelineCacheSafetyCriticalIndexEntry",
                                "VkPipelineCacheHeaderVersionSafetyCriticalOne",
                                "VkDeviceSemaphoreSciSyncPoolReservationCreateInfoNV",
                                "VkNativeBufferUsage2ANDROID",
                                "VkNativeBufferANDROID",
                                "VkSwapchainImageCreateInfoANDROID",
                                "VkPhysicalDevicePresentationPropertiesANDROID",
                                "VkPerformanceQueryReservationInfoKHR",
                                "VkFaultData",
                                "VkFaultCallbackInfo",
                                "VkPipelineOfflineCreateInfo",
                                "VkPhysicalDeviceVulkanSC10Properties",
                                "VkPipelinePoolSize",
                                "VkDeviceObjectReservationCreateInfo",
                                "VkCommandPoolMemoryReservationCreateInfo",
                                "VkCommandPoolMemoryConsumption",
                                "VkPhysicalDeviceVulkanSC10Features",
                            ];

                        if (exceptedNames.Contains(@struct.Name) == false)
                        {
                            Debug.Assert(false);
                        }
                    }
                    if (@struct.Comment != null)
                    {
                        writer.Write($"{NameMangler.XmlEscapeCharacters(NameMangler.MaybeRemoveStart(@struct.Comment, "// "))}");
                    }
                    if (@struct.ReferencedBy != null)
                    {
                        if (@struct.Comment != null)
                            writer.Write("<br/>");

                        writer.Write($"Used by {string.Join(", ", @struct.ReferencedBy.Take(3).Select(c => $"<see cref=\"Vk.{NameMangler.MangleFunctionName(c.Name)}\"/>"))}");
                        if (@struct.ReferencedBy.Count > 3)
                        {
                            writer.Write(", ...");
                        }
                    }
                    writer.WriteLine("</summary>");

                    // FIXME: Make sure to not do name mangling?
                    writer.WriteLine($"/// <remarks><see href=\"https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/{@struct.Name}.html\" /></remarks>");

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
                    writer.Write("/// <summary>");
                    if (handle.VersionInfo != null)
                    {
                        WriteVersionInfo(writer, handle.VersionInfo);
                    }
                    else
                    {
                        // There are no handles that do not have version info so far.
                        // - Noggin_bops 2025-07-06
                        ReadOnlySpan<string> exceptedNames = [];

                        if (exceptedNames.Contains(handle.Name) == false)
                        {
                            Debug.Assert(false);
                        }
                    }
                    if (handle.ReferencedBy != null)
                    {
                        writer.Write($"Used by {string.Join(", ", handle.ReferencedBy.Take(3).Select(c => $"<see cref=\"Vk.{NameMangler.MangleFunctionName(c.Name)}\"/>"))}");
                        if (handle.ReferencedBy.Count > 3)
                        {
                            writer.Write(", ...");
                        }
                    }
                    writer.WriteLine("</summary>");

                    // FIXME: Make sure to not do name mangling?
                    writer.WriteLine($"/// <remarks><see href=\"https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/{handle.Name}.html\" /></remarks>");

                    // FIXME: Figure out the right underlying type!
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
                        WriteCommand(writer, command, "static ", "VkPointers.");
                    }
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }

        public static void WriteCommand(IndentedTextWriter writer, Command command, string functionModifiers, string fnpointerPrefix)
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

            // Write documentation string.
            {
                writer.Write("/// <summary>");
                if (command.VersionInfo != null)
                {
                    List<string> strs = [.. command.VersionInfo.Extensions];
                    if (command.VersionInfo.Version != null)
                    {
                        strs.Insert(0, $"v{command.VersionInfo.Version.Major}.{command.VersionInfo.Version.Minor}");
                    }
                    writer.Write($"<b>[requires: {string.Join(" | ", strs)}]</b> ");
                }
                else
                {
                    // There are two "valid" reasons why a command would be missing version data.
                    // 1. The only reference to the command is in a disabled extension.
                    //    Currently such functions still get emitted even if no-one references them.
                    // 2. The command is part of vulkansc or a vulkansc extension. We don't deal with vulkancs atm.
                    //
                    // This is a list of the known commands that fullfill either of these criteria.
                    // - Noggin_bops 2024-09-24
                    ReadOnlySpan<string> exceptedNames = [
                        "vkGetSwapchainGrallocUsageANDROID",
                                    "vkGetSwapchainGrallocUsage2ANDROID",
                                    "vkAcquireImageANDROID",
                                    "vkQueueSignalReleaseImageANDROID",
                                    "vkGetFaultData",
                                    "vkGetCommandPoolMemoryConsumption",
                                ];

                    if (exceptedNames.Contains(command.Name) == false)
                    {
                        // See comment above.
                        Debug.Assert(false);
                    }
                }

                switch (command.CommandType)
                {
                    case CommandType.Global:
                        writer.Write("[global command] ");
                        break;
                    case CommandType.Instance:
                        writer.Write("[instance command] ");
                        break;
                    case CommandType.Device:
                        writer.Write("[device command] ");
                        break;
                    case CommandType.Invalid:
                    default:
                        throw new InvalidEnumArgumentException($"Invalid command type: {command.CommandType}");
                }

                if (command.Alias != null)
                {
                    writer.Write($" Alias of <see cref=\"{NameMangler.MangleFunctionName(command.Alias)}\"/>");
                }
                writer.WriteLine("</summary>");
            }

            writer.WriteLine($"/// <remarks><see href=\"https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/{entryPoint}.html\" /></remarks>");

            writer.WriteLine($"public {functionModifiers}{command.StrongReturnType!.ToCSString()} {functionName}({signature})");
            using (writer.CsScope())
            {
                if (command.StrongReturnType is not CSVoid)
                {
                    writer.WriteLine($"return {fnpointerPrefix}_{entryPoint}_fnptr({paramNames});");
                }
                else
                {
                    writer.WriteLine($"{fnpointerPrefix}_{entryPoint}_fnptr({paramNames});");
                }
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
                        WriteFunctionPointer(writer, command, "static ", true);
                    }
                }

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }
        }

        public static void WriteFunctionPointer(IndentedTextWriter writer, Command command, string memberModifiers, bool lazyLoader)
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

            if (lazyLoader)
            {
                writer.WriteLine($"public {memberModifiers}delegate* unmanaged<{delegateTypes}> _{entryPoint}_fnptr = &{entryPoint}_Lazy;");

                writer.WriteLine($"[UnmanagedCallersOnly]");
                writer.WriteLine($"private {memberModifiers}{command.StrongReturnType!.ToCSString()} {entryPoint}_Lazy({signature})");
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
            else
            {
                writer.WriteLine($"public {memberModifiers}delegate* unmanaged<{delegateTypes}> _{entryPoint}_fnptr;");
            }
        }


        public static void WriteDispatchTables(string directoryPath, List<Command> commands, SpecificationData video)
        {
            using StreamWriter stream = File.CreateText(Path.Combine(directoryPath, "DispatchTables.cs"));
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

                WriteInstanceDispatchTable(writer, commands);
                WriteDeviceDispatchTable(writer, commands);

                writer.WriteLineNoTabs("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
            }

            static void WriteInstanceDispatchTable(IndentedTextWriter writer, List<Command> commands)
            {
                writer.WriteLine($"public unsafe partial struct InstanceDispatchTable");
                using (writer.CsScope())
                {
                    writer.WriteLine("///<summary>The <see cref=\"VkInstance\"/> used to load this dispatch table.</summary>");
                    writer.WriteLine("public readonly VkInstance Instance;");
                    
                    writer.WriteLine($"public InstanceDispatchTable(VkInstance instance)");
                    using (writer.CsScope())
                    {
                        writer.WriteLine("Instance = instance;");
                        foreach (Command command in commands)
                        {
                            if (command.CommandType != CommandType.Instance)
                                continue;

                            string entryPoint = command.Name;
                            string functionName = NameMangler.MangleFunctionName(command.Name);

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

                            writer.WriteLine($"_{entryPoint}_fnptr = (delegate* unmanaged<{delegateTypes}>){LoaderClass}.GetInstanceProcAddress(instance, \"{entryPoint}\");");
                        }
                    }

                    // FIXME: If the first argument is the instance itself
                    // we might want to do like VkBootstrap does as implicitly
                    // fill it in.
                    // - Noggin_bops 2025-03-27
                    foreach (Command command in commands)
                    {
                        if (command.CommandType != CommandType.Instance)
                            continue;

                        WriteCommand(writer, command, "", "");
                    }

                    foreach (Command command in commands)
                    {
                        if (command.CommandType != CommandType.Instance)
                            continue;

                        WriteFunctionPointer(writer, command, "", false);
                    }
                }
            }

            static void WriteDeviceDispatchTable(IndentedTextWriter writer, List<Command> commands)
            {
                writer.WriteLine($"public unsafe partial struct DeviceDispatchTable");
                using (writer.CsScope())
                {
                    writer.WriteLine("///<summary>The <see cref=\"VkDevice\"/> used to load this dispatch table.</summary>");
                    writer.WriteLine("public readonly VkDevice Device;");
                    
                    writer.WriteLine($"public DeviceDispatchTable(VkDevice device)");
                    using (writer.CsScope())
                    {
                        writer.WriteLine("Device = device;");
                        foreach (Command command in commands)
                        {
                            if (command.CommandType != CommandType.Device)
                                continue;

                            string entryPoint = command.Name;
                            string functionName = NameMangler.MangleFunctionName(command.Name);

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

                            writer.WriteLine($"_{entryPoint}_fnptr = (delegate* unmanaged<{delegateTypes}>){LoaderClass}.GetDeviceProcAddr(device, \"{entryPoint}\");");
                        }
                    }

                    // FIXME: If the first argument is the device itself
                    // we might want to do like VkBootstrap does as implicitly
                    // fill it in.
                    // - Noggin_bops 2025-03-27
                    foreach (Command command in commands)
                    {
                        if (command.CommandType != CommandType.Device)
                            continue;

                        WriteCommand(writer, command, "", "");
                    }

                    foreach (Command command in commands)
                    {
                        if (command.CommandType != CommandType.Device)
                            continue;

                        WriteFunctionPointer(writer, command, "", false);
                    }
                }
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
                            writer.WriteLine($"/// <summary>[from: <b>{constant.Extension}</b>]{NameMangler.XmlEscapeCharacters(constant.Comment)}</summary>");
                        }
                        else if (constant.Comment != null)
                        {
                            writer.WriteLine($"/// <summary>{NameMangler.XmlEscapeCharacters(constant.Comment)}</summary>");
                        }

                        writer.WriteLine($"/// <remarks><see href=\"https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/{name}.html\" /></remarks>");

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

                            foreach (TypeRef requiredType in requireTag.RequiredTypes)
                            {
                                EnumType? @enum = video.Enums.Find(e => e.Name == requiredType.Name);
                                StructType? @struct = video.Structs.Find(s => s.Name == requiredType.Name);
                                if (@enum != null)
                                {
                                    writer.Write("/// <summary>");
                                    if (@enum.VersionInfo != null)
                                    {
                                        WriteVersionInfo(writer, @enum.VersionInfo);
                                    }
                                    else
                                    {
                                        Debug.Assert(false);
                                    }
                                    writer.WriteLine("</summary>");

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
                                                writer.WriteLine($"/// <summary>{NameMangler.XmlEscapeCharacters(comment)}</summary>");
                                            }
                                            writer.WriteLine($"{NameMangler.MangleEnumName(member.Name)} = {member.Value},");
                                        }
                                    }
                                }
                                else if (@struct != null)
                                {
                                    writer.Write("/// <summary>");
                                    if (@struct.VersionInfo != null)
                                    {
                                        WriteVersionInfo(writer, @struct.VersionInfo);
                                    }
                                    else
                                    {
                                        Debug.Assert(false);
                                    }
                                    writer.WriteLine("</summary>");

                                    WriteStruct(writer, @struct, video.Enums);
                                }
                                else
                                {
                                    Console.WriteLine($"Could not find {requiredType.Name} in {extension.Name} extension.");
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
                foreach (StructMember member in @struct.Members)
                {
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
                            Console.WriteLine($"Could't find sType '{member.Values}' for {@struct.Name}");
                            writer.WriteLine($"public {member.StrongType!.ToCSString()} {NameMangler.MangleMemberName(member.Name)};");
                        }
                        else
                        {
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

                // Write empty ctor so our default values can apply.
                {
                    writer.WriteLine($"public {@struct.Name}() {{ }}");
                }

                if (canWriteSimpleCtor && @struct.Members.Count > 0)
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
            }
        }

        private static void WriteVersionInfo(IndentedTextWriter writer, VersionInfo versionInfo)
        {
            List<string> strs = [.. versionInfo.Extensions];
            if (versionInfo.Version != null)
            {
                strs.Insert(0, $"v{versionInfo.Version.Major}.{versionInfo.Version.Minor}");
            }
            writer.Write($"<b>[requires: {string.Join(" | ", strs)}]</b> ");

            if (versionInfo.DeprecatedBy?.Count > 0)
            {
                writer.WriteLine();
                foreach (DeprecationReason deprecation in versionInfo.DeprecatedBy)
                {
                    string v = deprecation.Version != null ? $"v{deprecation.Version}" : deprecation.Extension ?? throw new Exception();
                    string explanationLink = deprecation.ExplanationLink != null ? $"see: <see href=\"https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#{deprecation.ExplanationLink}\" />" : "";
                    writer.WriteLine($"/// <br/><b>[deprecated by: {v}]</b> {explanationLink}");
                }
                writer.Write("/// ");
            }
        }
    }
}
