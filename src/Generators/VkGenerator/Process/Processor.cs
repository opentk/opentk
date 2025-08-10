using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkGenerator.Parsing;
using GeneratorBase.Utility;
using GeneratorBase.Utility.Extensions;
using GeneratorBase;

namespace VkGenerator.Process
{
    internal record TypeEntry(BaseCSType CSType, IReferable Referable);

    internal class Processor
    {
        public static void SortMembers(SpecificationData data)
        {
            // Here we want to make it so that ordering changes in the vk.xml spec doesn't generate code diffs in OpenTK.
            // We do this by sorting the enums, structures, enum members, etc so that they always appear in predictable order.
            // OBS. We don't sort struct members, as that would change their layout.
            // - Noggin_bops 2024-12-08

            data.Enums.Sort((e1, e2) => string.Compare(e1.Name, e2.Name, StringComparison.InvariantCulture));
            data.EnumNames.Sort((e1, e2) => string.Compare(e1.Name, e2.Name, StringComparison.InvariantCulture));
            data.BitmaskNames.Sort((b1, b2) => string.Compare(b1.Name, b2.Name, StringComparison.InvariantCulture));
            data.Structs.Sort((s1, s2) => string.Compare(s1.Name, s2.Name, StringComparison.InvariantCulture));
            data.Handles.Sort((h1, h2) => string.Compare(h1.Name, h2.Name, StringComparison.InvariantCulture));
            data.Commands.Sort((c1, c2) => string.Compare(c1.Name, c2.Name, StringComparison.InvariantCulture));
            // FIXME: ?
            data.Features.Sort((f1, f2) => string.Compare(f1.Name, f2.Name, StringComparison.InvariantCulture));
            data.Extensions.Sort((e1, e2) => string.Compare(e1.Name, e2.Name, StringComparison.InvariantCulture));

            foreach (EnumType @enum in data.Enums)
            {
                @enum.Members.Sort((m1, m2) => string.Compare(m1.Name, m2.Name, StringComparison.InvariantCulture));
                @enum.ReferencedBy?.Sort((r1, r2) => string.Compare(r1.Name, r2.Name, StringComparison.InvariantCulture));
            }

            foreach (StructType @struct in data.Structs)
            {
                @struct.ReferencedBy?.Sort((r1, r2) => string.Compare(r1.Name, r2.Name, StringComparison.InvariantCulture));
            }

            foreach (HandleType handle in data.Handles)
            {
                handle.ReferencedBy?.Sort((r1, r2) => string.Compare(r1.Name, r2.Name, StringComparison.InvariantCulture));
            }
        }

        public static EnumMember? FindEnumMember(List<EnumType> enums, string memberName)
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

        public static void ApplyFeatureEnums(SpecificationData data)
        {
            // First we add all non-aliased enum values, so we can look them up later when we add the aliased enums.
            foreach (Feature feature in data.Features)
            {
                foreach (RequireTag require in feature.RequireTags)
                {
                    foreach (RequireEnum requiredEnum in require.AddedEnums)
                    {
                        if (requiredEnum.Alias == null)
                        {
                            EnumType? extends = data.Enums.Find(e => e.Name == requiredEnum.Extends);
                            Debug.Assert(extends != null);
                            if (extends.Members.Find(m => m.Name == requiredEnum.Name) == null)
                            {
                                extends.Members.Add(new EnumMember(requiredEnum.Name, (ulong)requiredEnum.Value!.Value, requiredEnum.Comment, null, feature.Name));
                            }
                        }
                    }
                }
            }

            // Then add all aliased enums
            foreach (Feature feature in data.Features)
            {
                foreach (RequireTag require in feature.RequireTags)
                {
                    foreach (RequireEnum requiredEnum in require.AddedEnums)
                    {
                        // VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT and VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT both mangle to the same name in C#.
                        // Atm this is the only symbol to have this problem, so we do a quick hack instead of doing something fancy to detect this situation.
                        // - Noggin_bops 2024-07-09
                        if (requiredEnum.Name == "VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT")
                            continue;

                        if (requiredEnum.Alias != null)
                        {
                            EnumType? extends = data.Enums.Find(e => e.Name == requiredEnum.Extends);
                            Debug.Assert(extends != null);
                            if (extends.Members.Find(m => m.Name == requiredEnum.Name) == null)
                            {
                                // FIXME: Maybe we need to search through all possible enum not just the ones in this namespace....
                                EnumMember aliasedMember = FindEnumMember(data.Enums, requiredEnum.Alias) ?? throw new Exception();
                                extends.Members.Add(new EnumMember(requiredEnum.Name, aliasedMember.Value, requiredEnum.Comment, requiredEnum.Alias, feature.Name));
                            }
                        }
                    }
                }
            }
        }

        public static void ApplyExtensionEnums(SpecificationData data)
        {
            // First we add all non-aliased enum values, so we can look them up later when we add the aliased enums.
            foreach (Extension extension in data.Extensions)
            {
                foreach (RequireTag require in extension.RequireTags)
                {
                    foreach (RequireEnum requiredEnum in require.AddedEnums)
                    {
                        if (requiredEnum.Alias == null)
                        {
                            EnumType? extends = data.Enums.Find(e => e.Name == requiredEnum.Extends);
                            Debug.Assert(extends != null);
                            if (extends.Members.Find(m => m.Name == requiredEnum.Name) == null)
                            {
                                extends.Members.Add(new EnumMember(requiredEnum.Name, (ulong)requiredEnum.Value!.Value, requiredEnum.Comment, null, extension.Name));
                            }
                        }
                    }
                }
            }

            // Then add all aliased enums
            foreach (Extension extension in data.Extensions)
            {
                foreach (RequireTag require in extension.RequireTags)
                {
                    foreach (RequireEnum requiredEnum in require.AddedEnums)
                    {
                        // VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT and VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT both mangle to the same name in C#.
                        // Atm this is the only symbol to have this problem, so we do a quick hack instead of doing something fancy to detect this situation.
                        // - Noggin_bops 2024-07-09
                        if (requiredEnum.Name == "VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT")
                            continue;

                        if (requiredEnum.Alias != null)
                        {
                            EnumType? extends = data.Enums.Find(e => e.Name == requiredEnum.Extends);
                            Debug.Assert(extends != null);
                            if (extends.Members.Find(m => m.Name == requiredEnum.Name) == null)
                            {
                                // FIXME: Maybe we need to search through all possible enum not just the ones in this namespace....
                                EnumMember aliasedMember = FindEnumMember(data.Enums, requiredEnum.Alias) ?? throw new Exception();
                                extends.Members.Add(new EnumMember(requiredEnum.Name, aliasedMember.Value, requiredEnum.Comment, requiredEnum.Alias, extension.Name));
                            }
                        }
                    }
                }
            }
        }

        public static void ApplyVideoEnums(SpecificationData data, SpecificationData video)
        {
            // FIXME: We want to generate these somewhere else!
            //data.Enums.AddRange(video.Enums);
            //data.EnumNames.AddRange(video.EnumNames);
        }

        public static void ApplyExtensionConstants(SpecificationData data)
        {
            foreach (Extension extension in data.Extensions)
            {
                foreach (RequireTag requireTag in extension.RequireTags)
                {
                    foreach (Constant constant in requireTag.AddedConstants)
                    {
                        // FIXME: Mark these as from a specific extension so we can add a comment about that.
                        data.Constants.Add(constant.Name, constant);
                    }
                }
            }
        }

        public static Dictionary<string, TypeEntry> BuildTypeMap(SpecificationData data, SpecificationData video)
        {
            Dictionary<string, TypeEntry> typeMap = new Dictionary<string, TypeEntry>();

            // First we add add all non-aliased struct types so that we can resolve
            // the aliases in a second pass.
            // - Noggin_bops 2025-03-22
            foreach (StructType @struct in data.Structs)
            {
                if (@struct.Alias == null)
                {
                    typeMap.Add(@struct.Name, new TypeEntry(new CSStruct(@struct.Name, true), @struct));
                }
            }

            foreach (StructType @struct in data.Structs)
            {
                if (@struct.Alias != null)
                {
                    if (typeMap.TryGetValue(@struct.Alias, out TypeEntry? aliasStruct))
                    {
                        // For now we count references to an alias as references to the aliased struct.
                        // - Noggin_bops 2025-03-22
                        typeMap.Add(@struct.Name, new TypeEntry(aliasStruct.CSType, aliasStruct.Referable));

                        // FIXME: Maybe make this a separate step..
                        // Here we also take the oppurtunity to copy over the struct members from the aliased type.
                        @struct.Members.AddRange(((StructType)aliasStruct.Referable).Members);
                    }
                    else
                    {
                        Debug.Assert(false);
                    }
                }
            }

            foreach (EnumType @enum in data.Enums)
            {
                BitmaskName? bitmaskName = data.BitmaskNames.Find(en => en.Requires == @enum.Name);

                if (bitmaskName != null)
                {
                    CSPrimitive type = bitmaskName.Type switch
                    {
                        "VkFlags" => CSPrimitive.Uint(true),
                        "VkFlags64" => CSPrimitive.Ulong(true),
                        _ => throw new Exception(),
                    };
                    typeMap.Add(@enum.Name, new TypeEntry(new CSEnum(@enum.Name, type, true), @enum));
                }
                else
                {
                    // FIXME: Underlying enum type!
                    typeMap.Add(@enum.Name, new TypeEntry(new CSEnum(@enum.Name, CSPrimitive.Uint(true), true), @enum));
                }
            }

            foreach (EnumName enumName in data.EnumNames)
            {
                if (enumName.Alias != null)
                {
                    if (typeMap.TryGetValue(enumName.Alias, out TypeEntry? enumType))
                    {
                        // For now we count references to an alias as references to the aliased enum.
                        // - Noggin_bops 2024-12-08
                        typeMap.Add(enumName.Name, new TypeEntry(enumType.CSType, enumType.Referable));
                    }
                    else
                    {
                        Debug.Assert(false);
                    }
                }
                else
                {
                    // FIXME: There are a bunch more empty enums like VkPipelineVertexInputStateCreateFlags etc

                    // VkQueryPoolCreateFlags, VkQueryPoolCreateFlagBits, VkDeviceCreateFlags, and VkDeviceCreateFlagBits have no members
                    if (enumName.Name != "VkQueryPoolCreateFlags" &&
                        enumName.Name != "VkQueryPoolCreateFlagBits" &&
                        enumName.Name != "VkDeviceCreateFlags" &&
                        enumName.Name != "VkDeviceCreateFlagBits")
                    {
                        Debug.Assert(typeMap.ContainsKey(enumName.Name));
                    }
                }
            }

            foreach (BitmaskName bitmask in data.BitmaskNames)
            {
                // FIXME: Should we use the ...Bits name or the typedef names?
                // For now we use the ...Bits name because it's easiest that way
                if (bitmask.Requires != null && typeMap.TryGetValue(bitmask.Requires, out TypeEntry? enumType))
                {
                    // FIXME: Is this the right thing???
                    typeMap.Add(bitmask.Name, new TypeEntry(enumType.CSType, enumType.Referable));
                }
                else
                {
                    CSPrimitive type = bitmask.Type switch
                    {
                        "VkFlags" => CSPrimitive.Uint(true),
                        "VkFlags64" => CSPrimitive.Ulong(true),
                        _ => throw new Exception(),
                    };

                    EnumType newEnumType = new EnumType(bitmask.Name, new List<EnumMember>(), true, null) { StrongUnderlyingType = type };

                    typeMap.Add(bitmask.Name, new TypeEntry(new CSEnum(bitmask.Name, type, true), newEnumType));

                    // FIXME: This isn't the place to do this!!!!
                    data.Enums.Add(newEnumType);
                }
            }

            foreach (HandleType handle in data.Handles)
            {
                typeMap.Add(handle.Name, new TypeEntry(new CSStruct(handle.Name, true), handle));
            }

            // Add video.xml types so we can reference them
            foreach (StructType @struct in video.Structs)
            {
                typeMap.Add(@struct.Name, new TypeEntry(new CSStruct(@struct.Name, true), @struct));
            }

            foreach (EnumType @enum in video.Enums)
            {
                typeMap.Add(@enum.Name, new TypeEntry(new CSEnum(@enum.Name, CSPrimitive.Int(true), true), @enum));
            }

            foreach (EnumName enumName in video.EnumNames)
            {
                if (enumName.Alias != null)
                {
                    if (typeMap.TryGetValue(enumName.Alias, out TypeEntry? enumType))
                    {
                        // For now we count references to an alias as references to the aliased enum.
                        // - Noggin_bops 2024-12-08
                        typeMap.Add(enumName.Name, new TypeEntry(enumType.CSType, enumType.Referable));
                    }
                    else
                    {
                        Debug.Assert(false);
                    }
                }
                else
                {
                    // FIXME: There are a bunch more empty enums like VkPipelineVertexInputStateCreateFlags etc

                    // VkQueryPoolCreateFlags, VkQueryPoolCreateFlagBits, VkDeviceCreateFlags, and VkDeviceCreateFlagBits have no members
                    if (enumName.Name != "VkQueryPoolCreateFlags" &&
                        enumName.Name != "VkQueryPoolCreateFlagBits" &&
                        enumName.Name != "VkDeviceCreateFlags" &&
                        enumName.Name != "VkDeviceCreateFlagBits")
                    {
                        Debug.Assert(typeMap.ContainsKey(enumName.Name));
                    }
                }
            }

            Debug.Assert(video.BitmaskNames.Count == 0);

            Debug.Assert(video.Handles.Count == 0);

            return typeMap;
        }

        public static Dictionary<string, Constant> BuildConstantsMap(SpecificationData data, SpecificationData video)
        {
            Dictionary<string, Constant> constantsMap = new Dictionary<string, Constant>(data.Constants);

            foreach (var (name, constant) in video.Constants)
            {
                constantsMap.Add(name, constant);
            }

            /*
            foreach (Extension extension in data.Extensions)
            {
                foreach (RequireTag requireTag in extension.RequireTags)
                {
                    foreach (Constant constant in requireTag.Constants)
                    {
                        constantsMap.Add(constant.Name, constant);
                    }
                }
            }

            foreach (Extension extension in video.Extensions)
            {
                foreach (RequireTag requireTag in extension.RequireTags)
                {
                    foreach (Constant constant in requireTag.Constants)
                    {
                        constantsMap.Add(constant.Name, constant);
                    }
                }
            }
            */

            return constantsMap;
        }

        public static void ResolveStructMemberTypes(SpecificationData data, Dictionary<string, TypeEntry> typeMap, Dictionary<string, Constant> constantsMap)
        {
            foreach (StructType @struct in data.Structs)
            {
                foreach (StructMember member in @struct.Members)
                {
                    member.StrongType = ParseType(member.Type, typeMap, constantsMap, out _);
                    member.StrongType = ReplaceOpaqueStructPointers(member.StrongType);
                }
            }
        }

        public static void ResolveHandleParent(SpecificationData data)
        {
            foreach (HandleType handle in data.Handles)
            {
                if (handle.Alias != null)
                {
                    continue;
                }

                if (handle.Parent == null)
                {
                    Debug.Assert(handle.Name == "VkInstance");
                    continue;
                }
                HandleType? parent = data.Handles.Find(h => h.Name == handle.Parent);
                Debug.Assert(parent != null);
                handle.ResolvedParent = parent;
            }

            foreach (HandleType handle in data.Handles)
            {
                if (handle.Alias != null)
                {
                    HandleType? alias = data.Handles.Find(h => h.Name == handle.Alias);
                    Debug.Assert(alias != null);
                    handle.ResolvedParent = alias.ResolvedParent;
                }
            }
        }

        public static void ResolveCommandTypes(SpecificationData data, Dictionary<string, TypeEntry> typeMap)
        {
            foreach (Function command in data.Commands)
            {
                command.StrongReturnType = ParseType(command.ReturnType, typeMap, data.Constants, out IReferable? reference);
                command.StrongReturnType = ReplaceOpaqueStructPointers(command.StrongReturnType);
                command.StrongReturnType = ReplaceFixedSizeArraysWithPointers(command.StrongReturnType);

                reference?.MarkReferencedBy(command);

                foreach (Parameter param in command.Parameters)
                {
                    param.StrongType = ParseType(param.Type, typeMap, data.Constants, out reference);
                    param.StrongType = ReplaceOpaqueStructPointers(param.StrongType);
                    param.StrongType = ReplaceFixedSizeArraysWithPointers(param.StrongType);

                    reference?.MarkReferencedBy(command);
                }

                if (command.Parameters.Count > 0)
                {
                    HandleType? handle = data.Handles.Find(h => h.Name == command.Parameters[0].Type);
                    if (handle != null)
                    {

                        if (HasParent(handle, "VkDevice"))
                        {
                            command.CommandType = CommandType.Device;
                        }
                        else if (HasParent(handle, "VkInstance"))
                        {
                            command.CommandType = CommandType.Instance;
                        }
                        else
                        {
                            command.CommandType = CommandType.Invalid;
                            Debug.Assert(false);
                        }

                        static bool HasParent(HandleType handle, string parent)
                        {
                            HandleType? current = handle;
                            do
                            {
                                if (current.Name == parent)
                                {
                                    return true;
                                }

                                current = current.ResolvedParent;
                            } while (current != null);

                            return false;
                        }
                    }
                    else
                    {
                        // These are currently the only global commands in vulkan.
                        // - Noggin_bops 2025-03-25
                        Debug.Assert(command.Name == "vkEnumerateInstanceVersion" ||
                            command.Name == "vkEnumerateInstanceExtensionProperties" ||
                            command.Name == "vkEnumerateInstanceLayerProperties" ||
                            command.Name == "vkCreateInstance");
                        command.CommandType = CommandType.Global;
                    }
                }
            }
        }

        public static void ResolveVersionInfo(SpecificationData data, Dictionary<string, TypeEntry> typeMap)
        {
            foreach (Feature feature in data.Features)
            {
                foreach (RequireTag require in feature.RequireTags)
                {
                    foreach (CommandRef requireCommand in require.Commands)
                    {
                        Function command = data.Commands.Find(c => c.Name == requireCommand.Name) ?? throw new Exception();

                        if (command.VersionInfo == null)
                        {
                            command.VersionInfo = new VersionInfo(feature.Version, []);
                        }
                        else if (command.VersionInfo.Version > feature.Version)
                        {
                            Debug.Assert(false, "This has never happened. So this codepath is untested.");
                            command.VersionInfo = command.VersionInfo with { Version = feature.Version };
                        }
                    }

                    // FIXME: Should we be looking at AddedEnum, Enums or both??
                    foreach (RequireEnum requireEnum in require.AddedEnums)
                    {
                        EnumType? extends = data.Enums.Find(e => e.Name == requireEnum.Extends);
                        Debug.Assert(extends != null);
                        EnumMember member = extends.Members.Find(m => m.Name == requireEnum.Name) ?? throw new Exception();
                        if (member.VersionInfo == null)
                        {
                            member.VersionInfo = new VersionInfo(feature.Version, []);
                        }
                        else if (member.VersionInfo.Version < feature.Version)
                        {
                            Debug.Assert(false, "This has never happened. So this codepath is untested.");
                            member.VersionInfo = member.VersionInfo with { Version = feature.Version };
                        }
                    }

                    foreach (TypeRef requireType in require.Types)
                    {
                        Define? define = data.Defines.Find(d => d.Name == requireType.Name);
                        StructType? structType = data.Structs.Find(s => s.Name == requireType.Name);
                        EnumType? enumType = data.Enums.Find(e => e.Name == requireType.Name);
                        HandleType? handleType = data.Handles.Find(h => h.Name == requireType.Name);
                        Debug.Assert(ListExtensions.CountTrue(define != null, structType != null, enumType != null, handleType != null) <= 1, "We matched more than one type for this require... Something has gone bad.");
                        if (define != null)
                        {
                            if (define.VersionInfo == null)
                            {
                                define.VersionInfo = new VersionInfo(feature.Version, []);
                            }
                            else if (define.VersionInfo.Version < feature.Version)
                            {
                                Debug.Assert(false, "This has never happened. So this codepath is untested.");
                                define.VersionInfo = define.VersionInfo with { Version = feature.Version };
                            }
                        }
                        else if (structType != null)
                        {
                            if (structType.VersionInfo == null)
                            {
                                structType.VersionInfo = new VersionInfo(feature.Version, []);
                            }
                            else if (structType.VersionInfo.Version < feature.Version)
                            {
                                Debug.Assert(false, "This has never happened. So this codepath is untested.");
                                structType.VersionInfo = structType.VersionInfo with { Version = feature.Version };
                            }
                        }
                        else if (enumType != null)
                        {
                            if (enumType.VersionInfo == null)
                            {
                                enumType.VersionInfo = new VersionInfo(feature.Version, []);
                            }
                            else if (enumType.VersionInfo.Version < feature.Version)
                            {
                                Debug.Assert(false, "This has never happened. So this codepath is untested.");
                                enumType.VersionInfo = enumType.VersionInfo with { Version = feature.Version };
                            }
                        }
                        else if (handleType != null)
                        {
                            if (handleType.VersionInfo == null)
                            {
                                handleType.VersionInfo = new VersionInfo(feature.Version, []);
                            }
                            else if (handleType.VersionInfo.Version < feature.Version)
                            {
                                Debug.Assert(false, "This has never happened. So this codepath is untested.");
                                handleType.VersionInfo = handleType.VersionInfo with { Version = feature.Version };
                            }
                        }
                    }
                }
            }

            foreach (Extension extension in data.Extensions)
            {
                ExtensionInfo extInfo = new ExtensionInfo(extension.Name, extension.Author);

                foreach (RequireTag require in extension.RequireTags)
                {
                    foreach (CommandRef requireCommand in require.Commands)
                    {
                        Function command = data.Commands.Find(c => c.Name == requireCommand.Name) ?? throw new Exception();

                        if (command.VersionInfo == null)
                        {
                            command.VersionInfo = new VersionInfo(null, [extInfo]);
                        }
                        else
                        {
                            command.VersionInfo.Extensions.Add(extInfo);
                        }
                    }

                    // FIXME: Should we be looking at AddedEnum, Enums or both??
                    foreach (RequireEnum requireEnum in require.AddedEnums)
                    {
                        // FIXME: This enum is referenced in the VK_EXT_display_surface_counter but it's
                        // actually never defined outside it. So we won't be able to find it's EnumType.
                        // One solution would be to add this enum member automatically, but as it's misspelled
                        // and should not be used we opt to just ignore this member.
                        // As of 2024-09-24 Vulkan 1.3.295 this is the only such occurance in the specification.
                        // - Noggin_bops 2024-09-24
                        if (requireEnum.Name == "VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT")
                            continue;

                        EnumType? extends = data.Enums.Find(e => e.Name == requireEnum.Extends);
                        Debug.Assert(extends != null);
                        EnumMember member = extends.Members.Find(m => m.Name == requireEnum.Name) ?? throw new Exception();
                        if (member.VersionInfo == null)
                        {
                            member.VersionInfo = new VersionInfo(null, [extInfo]);
                        }
                        else
                        {
                            member.VersionInfo.Extensions.Add(extInfo);
                        }
                    }

                    foreach (TypeRef requireType in require.Types)
                    {
                        Define? define = data.Defines.Find(d => d.Name == requireType.Name);
                        StructType? structType = data.Structs.Find(s => s.Name == requireType.Name);
                        EnumType? enumType = data.Enums.Find(e => e.Name == requireType.Name);
                        HandleType? handleType = data.Handles.Find(h => h.Name == requireType.Name);
                        Debug.Assert(ListExtensions.CountTrue(define != null, structType != null, enumType != null, handleType != null) <= 1, "We matched more than one type for this require... Something has gone bad.");
                        if (define != null)
                        {
                            if (define.VersionInfo == null)
                            {
                                define.VersionInfo = new VersionInfo(null, [extInfo]);
                            }
                            else
                            {
                                define.VersionInfo.Extensions.Add(extInfo);
                            }
                        }
                        else if (structType != null)
                        {
                            if (structType.VersionInfo == null)
                            {
                                structType.VersionInfo = new VersionInfo(null, [extInfo]);
                            }
                            else
                            {
                                structType.VersionInfo.Extensions.Add(extInfo);
                            }
                        }
                        else if (enumType != null)
                        {
                            if (enumType.VersionInfo == null)
                            {
                                enumType.VersionInfo = new VersionInfo(null, [extInfo]);
                            }
                            else
                            {
                                enumType.VersionInfo.Extensions.Add(extInfo);
                            }
                        }
                        else if (handleType != null)
                        {
                            if (handleType.VersionInfo == null)
                            {
                                handleType.VersionInfo = new VersionInfo(null, [extInfo]);
                            }
                            else
                            {
                                handleType.VersionInfo.Extensions.Add(extInfo);
                            }
                        }
                    }
                }
            }
        }

        public static void ResolveEnumUnderlyingTypes(SpecificationData data)
        {
            foreach (EnumType @enum in data.Enums)
            {
                // FIXME: Can we refer to thing between vk.xml and video.xml?
                BitmaskName? bitmaskName = data.BitmaskNames.Find(en => en.Requires == @enum.Name);

                if (bitmaskName != null)
                {
                    CSPrimitive type = bitmaskName.Type switch
                    {
                        "VkFlags" => CSPrimitive.Uint(true),
                        "VkFlags64" => CSPrimitive.Ulong(true),
                        _ => throw new Exception(),
                    };
                    @enum.StrongUnderlyingType = type;
                }
                else
                {
                    @enum.StrongUnderlyingType = CSPrimitive.Int(true);
                }
            }
        }

        public static void MarkDeprecations(SpecificationData data)
        {
            foreach (Feature feature in data.Features)
            {
                foreach (DeprecateTag deprecateTag in feature.DeprecateTags)
                {
                    foreach (CommandRef deprecatedCommand in deprecateTag.Commands)
                    {
                        Function? command = data.Commands.Find(c => c.Name == deprecatedCommand.Name);

                        if (command != null)
                        {
                            Debug.Assert(command.VersionInfo != null, "ResolveVersionInfo needs to be called before this function is called.");

                            command.VersionInfo.Deprecate(new DeprecationReason(feature.Version, null, deprecateTag.ExplanationLink));
                        }
                        else
                        {
                            Logger.Warning($"Could not find deprecated command '{deprecatedCommand.Name}'");
                        }
                    }

                    foreach (TypeRef deprecatedType in deprecateTag.Types)
                    {
                        if (data.Enums.TryFind(e => e.Name == deprecatedType.Name, out EnumType? @enum))
                        {
                            Debug.Assert(@enum.VersionInfo != null, "ResolveVersionInfo needs to be called before this function is called.");

                            @enum.VersionInfo.Deprecate(new DeprecationReason(feature.Version, null, deprecateTag.ExplanationLink));
                        }
                        else if (data.Structs.TryFind(s => s.Name == deprecatedType.Name, out StructType? @struct))
                        {
                            Debug.Assert(@struct.VersionInfo != null, "ResolveVersionInfo needs to be called before this function is called.");

                            @struct.VersionInfo.Deprecate(new DeprecationReason(feature.Version, null, deprecateTag.ExplanationLink));
                        }
                        else if (data.Handles.TryFind(h => h.Name == deprecatedType.Name, out HandleType? handle))
                        {
                            Debug.Assert(handle.VersionInfo != null, "ResolveVersionInfo needs to be called before this function is called.");

                            handle.VersionInfo.Deprecate(new DeprecationReason(feature.Version, null, deprecateTag.ExplanationLink));
                        }
                        else if (data.Defines.TryFind(d => d.Name == deprecatedType.Name, out Define? define))
                        {
                            Debug.Assert(define.VersionInfo != null, "ResolveVersionInfo needs to be called before this function is called.");

                            define.VersionInfo.Deprecate(new DeprecationReason(feature.Version, null, deprecateTag.ExplanationLink));
                        }
                        else
                        {
                            Logger.Warning($"Unable to find type: '{deprecatedType.Name}' when applying v{feature.Version} deprecations.");
                        }
                    }
                }
            }

            foreach (Extension extension in data.Extensions)
            {
                foreach (DeprecateTag deprecateTag in extension.DeprecateTags)
                {
                    foreach (CommandRef deprecatedCommand in deprecateTag.Commands)
                    {
                        Function? command = data.Commands.Find(c => c.Name == deprecatedCommand.Name);

                        if (command != null)
                        {
                            Debug.Assert(command.VersionInfo != null, "ResolveVersionInfo needs to be called before this function is called.");

                            command.VersionInfo.Deprecate(new DeprecationReason(null, extension.Name, deprecateTag.ExplanationLink));
                        }
                        else
                        {
                            Logger.Warning($"Could not find deprecated command '{deprecatedCommand.Name}'");
                        }
                    }

                    foreach (TypeRef deprecatedType in deprecateTag.Types)
                    {
                        if (data.Enums.TryFind(e => e.Name == deprecatedType.Name, out EnumType? @enum))
                        {
                            Debug.Assert(@enum.VersionInfo != null, "ResolveVersionInfo needs to be called before this function is called.");

                            @enum.VersionInfo.Deprecate(new DeprecationReason(null, extension.Name, deprecateTag.ExplanationLink));
                        }
                        else if (data.Structs.TryFind(s => s.Name == deprecatedType.Name, out StructType? @struct))
                        {
                            Debug.Assert(@struct.VersionInfo != null, "ResolveVersionInfo needs to be called before this function is called.");

                            @struct.VersionInfo.Deprecate(new DeprecationReason(null, extension.Name, deprecateTag.ExplanationLink));
                        }
                        else if (data.Handles.TryFind(h => h.Name == deprecatedType.Name, out HandleType? handle))
                        {
                            Debug.Assert(handle.VersionInfo != null, "ResolveVersionInfo needs to be called before this function is called.");

                            handle.VersionInfo.Deprecate(new DeprecationReason(null, extension.Name, deprecateTag.ExplanationLink));
                        }
                        else if (data.Defines.TryFind(d => d.Name == deprecatedType.Name, out Define? define))
                        {
                            Debug.Assert(define.VersionInfo != null, "ResolveVersionInfo needs to be called before this function is called.");

                            define.VersionInfo.Deprecate(new DeprecationReason(null, extension.Name, deprecateTag.ExplanationLink));
                        }
                        else
                        {
                            Logger.Warning($"Unable to find type: '{deprecatedType.Name}' when applying '{extension.Name}' deprecations.");
                        }
                    }
                }
            }
        }

        private static BaseCSType ParseType(string type, Dictionary<string, TypeEntry> typeMap, Dictionary<string, Constant> constantsMap, out IReferable? reference)
        {
            type = type.Trim();

            if (type.EndsWith('*'))
            {
                // This removes the last character of the string, ^1 is an exclusive upper bound.
                string? withoutAsterisk = type[0..^1].TrimEnd();

                // A pointer is only const if const is directly in front of the pointer,
                // if the const is in front of the type the type is the constant and not the pointer.
                bool @const = false;
                if (withoutAsterisk.EndsWith("const"))
                {
                    @const = true;
                    withoutAsterisk = withoutAsterisk[0..^"const".Length];
                }

                BaseCSType? baseType = ParseType(withoutAsterisk, typeMap, constantsMap, out reference);

                // Some structs are created as CSOpaqueStructs, this means that the only 
                // valid way to use these is through a pointer. We intercept them here
                // and create the proper CSStructPrimitive types from them.
                // - Noggin_bops 2025-08-04
                if (baseType is CSOpaqueStruct opaque)
                {
                    switch (opaque.TypeName)
                    {
                        // FIXME: Decide if we want `DisplayPtr`, `Display` or something like `XDisplay`?
                        // - Noggin_bops 2024-03-07
                        case "Display":
                            return CSPrimitive.IntPtr(opaque.Constant);//new CSStructPrimitive("DisplayPtr", opaque.Constant, CSPrimitive.IntPtr(true));
                        case "ANativeWindow":
                            return CSPrimitive.IntPtr(opaque.Constant);//new CSStructPrimitive("ANativeWindow", opaque.Constant, CSPrimitive.IntPtr(true));
                        case "AHardwareBuffer":
                            return CSPrimitive.IntPtr(opaque.Constant);//return new CSStructPrimitive("AHardwareBuffer", opaque.Constant, CSPrimitive.IntPtr(true));
                        default:
                            throw new Exception($"Unknown opaque struct type {opaque.TypeName}.");
                    }
                }
                else
                {
                    return new CSPointer(baseType, @const);
                }
            }
            else if (type.EndsWith(']'))
            {
                // To simplify the code we just detect this special case.
                if (type == "float[3][4]")
                {
                    // FIXME: Is it Matrix4x3 or Matrix3x4??
                    reference = null;
                    return new CSStruct("Matrix4x3", false);
                }

                int startIndex = type.LastIndexOf('[');
                string sizeStr = type[(startIndex + 1)..^1];

                ulong size;
                if (constantsMap.TryGetValue(sizeStr, out Constant? @const))
                {
                    if (@const.Type == ConstantType.Float)
                    {
                        throw new Exception("Cannot make a fixed array with a float size!");
                    }

                    size = @const.IntValue;
                }
                else if (int.TryParse(sizeStr, out int iSize))
                {
                    size = (ulong)iSize;
                }
                else
                {
                    throw new Exception();
                }

                string typeWithoutArray = type[..startIndex];

                BaseCSType baseType = ParseType(typeWithoutArray, typeMap, constantsMap, out reference);

                return new CSFixedSizeArray(baseType, size);
            }
            else if (type.Contains(':'))
            {
                int colonIndex = type.IndexOf(':');
                int bitWidth = int.Parse(type[(colonIndex + 1)..]);

                string typeWithoutBitfield = type[0..colonIndex].TrimEnd();
                BaseCSType baseType = ParseType(typeWithoutBitfield, typeMap, constantsMap, out reference);

                return new CSBitfield(baseType, bitWidth);
            }
            else
            {
                bool @const = false;
                if (type.StartsWith("const"))
                {
                    @const = true;
                    type = type["const".Length..].TrimStart();
                }

                // This is needed for _cl_context, and _cl_event
                // We don't care about struct here because it doesn't add any information (we are not a c compiler).
                if (type.StartsWith("struct"))
                {
                    type = type["struct".Length..].TrimStart();
                }

                if (typeMap.TryGetValue(type, out TypeEntry? csMapType))
                {
                    reference = csMapType.Referable;
                    if (csMapType.CSType is CSStruct csStruct)
                    {
                        // FIXME: @const!
                        return csStruct;
                    }
                    else if (csMapType.CSType is CSEnum csEnum)
                    {
                        // FIXME: @const!
                        return csEnum;
                    }
                    else if (csMapType.CSType is CSPrimitive csPrimitive && csPrimitive.TypeName == "IntPtr")
                    {
                        return csPrimitive;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

                BaseCSType csType;
                {
                    csType = type switch
                    {
                        "void" => new CSVoid(@const),
                        "char" => new CSChar8(@const),
                        "uint8_t" => CSPrimitive.Byte(@const),
                        "int8_t" => CSPrimitive.Sbyte(@const),
                        "int" => CSPrimitive.Int(@const),
                        "uint16_t" => CSPrimitive.Ushort(@const),
                        "int16_t" => CSPrimitive.Short(@const),
                        "int32_t" => CSPrimitive.Int(@const),
                        "uint32_t" => CSPrimitive.Uint(@const),
                        "int64_t" => CSPrimitive.Long(@const),
                        "uint64_t" => CSPrimitive.Ulong(@const),
                        "size_t" => CSPrimitive.Nuint(@const),

                        "float" => CSPrimitive.Float(@const),
                        "double" => CSPrimitive.Double(@const),

                        // FIXME: These should be possible to resolve automatically..?
                        "PFN_vkInternalAllocationNotification" => new CSFunctionPointer("VkInternalAllocationNotification", @const,
                            new CSVoid(true),
                            [
                                new CSPointer(new CSVoid(false), false),
                                CSPrimitive.Nuint(true),
                                new CSEnum("VkInternalAllocationType", CSPrimitive.Uint(true), true),
                                new CSEnum("VkSystemAllocationScope", CSPrimitive.Uint(true), true),
                            ]),
                        "PFN_vkInternalFreeNotification" => new CSFunctionPointer("VkInternalFreeNotification", @const,
                            new CSVoid(true),
                            [
                                new CSPointer(new CSVoid(false), false),
                                CSPrimitive.Nuint(true),
                                new CSEnum("VkInternalAllocationType", CSPrimitive.Uint(true), true),
                                new CSEnum("VkSystemAllocationScope", CSPrimitive.Uint(true), true),
                            ]),
                        "PFN_vkReallocationFunction" => new CSFunctionPointer("VkReallocationFunction", @const,
                            new CSPointer(new CSVoid(true), true),
                            [
                                new CSPointer(new CSVoid(false), false),
                                new CSPointer(new CSVoid(false), false),
                                CSPrimitive.Nuint(true),
                                CSPrimitive.Nuint(true),
                                new CSEnum("VkSystemAllocationScope", CSPrimitive.Uint(true), true),
                            ]),
                        "PFN_vkAllocationFunction" => new CSFunctionPointer("VkAllocationFunction", @const,
                            new CSPointer(new CSVoid(true), true),
                            [
                                new CSPointer(new CSVoid(false), false),
                                CSPrimitive.Nuint(true),
                                CSPrimitive.Nuint(true),
                                new CSEnum("VkSystemAllocationScope", CSPrimitive.Uint(true), true),
                            ]),
                        "PFN_vkFreeFunction" => new CSFunctionPointer("VkFreeFunction", @const,
                            new CSVoid(true),
                            [
                                new CSPointer(new CSVoid(false), false),
                                new CSPointer(new CSVoid(false), false),
                            ]),
                        "PFN_vkVoidFunction" => new CSOpaqueFunctionPointer("VkVoidFunction", @const),
                        "PFN_vkDebugReportCallbackEXT" => new CSFunctionPointer("VkDebugReportCallbackEXT", @const,
                            new CSBool32(true),
                            [
                                new CSEnum("VkDebugReportFlagBitsEXT", CSPrimitive.Uint(true), true),
                                new CSEnum("VkDebugReportObjectTypeEXT", CSPrimitive.Uint(true), true),
                                CSPrimitive.Ulong(true),
                                CSPrimitive.Nuint(true),
                                CSPrimitive.Int(true),
                                new CSPointer(new CSChar8(true), true),
                                new CSPointer(new CSChar8(true), true),
                                new CSPointer(new CSVoid(false), false),
                            ]),
                        "PFN_vkDebugUtilsMessengerCallbackEXT" => new CSFunctionPointer("VkDebugUtilsMessengerCallbackEXT", @const,
                            new CSBool32(true),
                            [
                                new CSEnum("VkDebugUtilsMessageSeverityFlagBitsEXT", CSPrimitive.Uint(true), true),
                                new CSEnum("VkDebugUtilsMessageTypeFlagBitsEXT", CSPrimitive.Uint(true), true),
                                new CSPointer(new CSStruct("VkDebugUtilsMessengerCallbackDataEXT", true), true),
                                new CSPointer(new CSVoid(false), false),
                            ]),
                        "PFN_vkFaultCallbackFunction" => new CSFunctionPointer("VkFaultCallbackFunction", @const,
                            new CSVoid(true),
                            [
                                new CSBool32(true),
                                CSPrimitive.Uint(true),
                                new CSPointer(new CSStruct("VkFaultData", true), true),
                            ]),
                        "PFN_vkDeviceMemoryReportCallbackEXT" => new CSFunctionPointer("VkDeviceMemoryReportCallbackEXT", @const,
                            new CSVoid(true),
                            [
                                new CSPointer(new CSStruct("VkDeviceMemoryReportCallbackDataEXT", true), true),
                                new CSPointer(new CSVoid(false), false),
                            ]),
                        "PFN_vkGetInstanceProcAddrLUNARG" => new CSFunctionPointer("VkGetInstanceProcAddrLUNARG", @const,
                            new CSOpaqueFunctionPointer("VkVoidFunction", true),
                            [
                                new CSStruct("VkInstance", true),
                                new CSPointer(new CSChar8(true), true),
                            ]),

                        "VkSampleMask" => CSPrimitive.Uint(@const),
                        "VkBool32" => new CSBool32(@const),
                        "VkFlags" => CSPrimitive.Uint(@const),
                        "VkFlags64" => CSPrimitive.Ulong(@const),
                        "VkDeviceSize" => CSPrimitive.Ulong(@const),
                        "VkDeviceAddress" => CSPrimitive.Ulong(@const),

                        "VkRemoteAddressNV" => new CSPointer(new CSVoid(@const), @const),

                        "Display" => new CSOpaqueStruct("Display", @const), // FIXME: This is just a struct?
                        "VisualID" => CSPrimitive.Nuint(@const),
                        // FIXME: Strong type?
                        //"Window" => new CSStructPrimitive("Window", @const, CSPrimitive.Nuint(@const)),
                        "Window" => CSPrimitive.Nuint(@const),
                        "RROutput" => CSPrimitive.Nuint(@const),

                        "wl_display" => new CSStruct("wl_display", @const), // FIXME: This is just a struct?
                        "wl_surface" => new CSStruct("wl_surface", @const),

                        "HINSTANCE" => CSPrimitive.IntPtr(@const),
                        "HWND" => CSPrimitive.IntPtr(@const),
                        "HMONITOR" => CSPrimitive.IntPtr(@const),
                        "HANDLE" => CSPrimitive.IntPtr(@const),
                        "SECURITY_ATTRIBUTES" => new CSStruct("SECURITY_ATTRIBUTES", @const),
                        "DWORD" => CSPrimitive.Uint(@const),
                        "LPCWSTR" => new CSPointer(new CSChar16(true), @const),

                        "xcb_connection_t" => new CSStruct("xcb_connection_t", @const),
                        "xcb_visualid_t" => CSPrimitive.Uint(@const),
                        "xcb_window_t" => CSPrimitive.Uint(@const),

                        "IDirectFB" => new CSStruct("IDirectFB", @const),
                        "IDirectFBSurface" => new CSStruct("IDirectFBSurface", @const),

                        "zx_handle_t" => CSPrimitive.Int(@const),

                        // Google Games Platform aka. Stadia which is dead
                        // and we can't get any headers or anything from it.
                        "GgpStreamDescriptor" => new CSNotSupportedType("GgpStreamDescriptor"),
                        "GgpFrameToken" => new CSNotSupportedType("GgpFrameToken"),

                        "_screen_context" => CSPrimitive.IntPtr(@const),
                        "_screen_window" => CSPrimitive.IntPtr(@const),
                        "_screen_buffer" => CSPrimitive.IntPtr(@const),

                        "NvSciSyncAttrList" => CSPrimitive.IntPtr(@const),
                        "NvSciSyncObj" => CSPrimitive.IntPtr(@const),
                        // uint64_t payload[6]; 
                        "NvSciSyncFence" => new CSStruct("NvSciSyncFence", @const),
                        "NvSciBufAttrList" => CSPrimitive.IntPtr(@const),
                        "NvSciBufObj" => CSPrimitive.IntPtr(@const),

                        "ANativeWindow" => new CSOpaqueStruct("ANativeWindow", @const),
                        "AHardwareBuffer" => new CSOpaqueStruct("AHardwareBuffer", @const),

                        "CAMetalLayer" => CSPrimitive.IntPtr(@const),
                        "MTLDevice_id" => CSPrimitive.IntPtr(@const),
                        "MTLCommandQueue_id" => CSPrimitive.IntPtr(@const),
                        "MTLBuffer_id" => CSPrimitive.IntPtr(@const),
                        "MTLTexture_id" => CSPrimitive.IntPtr(@const),
                        "MTLSharedEvent_id" => CSPrimitive.IntPtr(@const),
                        "IOSurfaceRef" => CSPrimitive.IntPtr(@const),

                        "OHNativeWindow" => new CSStruct("OHNativeWindow", @const),

                        /*
                        // From vk_video/vulkan_video_codec_h264std.h
                        "StdVideoH264ProfileIdc" => new CSEnum("StdVideoH264ProfileIdc", CSPrimitive.Int(@const), @const),
                        "StdVideoH264LevelIdc" => new CSEnum("StdVideoH264LevelIdc", CSPrimitive.Int(@const), @const),
                        "StdVideoH264ChromaFormatIdc" => new CSEnum("StdVideoH264ChromaFormatIdc", CSPrimitive.Int(@const), @const),
                        "StdVideoH264PocType" => new CSEnum("StdVideoH264PocType", CSPrimitive.Int(@const), @const),
                        "StdVideoH264SpsFlags" => new CSStruct("StdVideoH264SpsFlags", @const),
                        "StdVideoH264ScalingLists" => new CSStruct("StdVideoH264ScalingLists", @const),
                        "StdVideoH264SequenceParameterSetVui" => new CSStruct("StdVideoH264SequenceParameterSetVui", @const),
                        "StdVideoH264AspectRatioIdc" => new CSEnum("StdVideoH264AspectRatioIdc", CSPrimitive.Int(@const), @const),
                        "StdVideoH264HrdParameters" => new CSStruct("StdVideoH264HrdParameters", @const),
                        "StdVideoH264SpsVuiFlags" => new CSStruct("StdVideoH264SpsVuiFlags", @const),
                        "StdVideoH264WeightedBipredIdc" => new CSEnum("StdVideoH264WeightedBipredIdc", CSPrimitive.Int(@const), @const),
                        "StdVideoH264PpsFlags" => new CSStruct("StdVideoH264PpsFlags", @const),
                        "StdVideoH264SliceType" => new CSEnum("StdVideoH264SliceType", CSPrimitive.Int(@const), @const),
                        "StdVideoH264CabacInitIdc" => new CSEnum("StdVideoH264CabacInitIdc", CSPrimitive.Int(@const), @const),
                        "StdVideoH264DisableDeblockingFilterIdc" => new CSEnum("StdVideoH264DisableDeblockingFilterIdc", CSPrimitive.Int(@const), @const),
                        "StdVideoH264PictureType" => new CSEnum("StdVideoH264PictureType", CSPrimitive.Int(@const), @const),
                        "StdVideoH264ModificationOfPicNumsIdc" => new CSEnum("StdVideoH264ModificationOfPicNumsIdc", CSPrimitive.Int(@const), @const),
                        "StdVideoH264MemMgmtControlOp" => new CSEnum("StdVideoH264MemMgmtControlOp", CSPrimitive.Int(@const), @const),

                        "StdVideoH264SequenceParameterSet" => new CSStruct("StdVideoH264SequenceParameterSet", @const),
                        "StdVideoH264PictureParameterSet" => new CSStruct("StdVideoH264PictureParameterSet", @const),

                        "StdVideoDecodeH264PictureInfo" => new CSStruct("StdVideoDecodeH264PictureInfo", @const),
                        "StdVideoDecodeH264ReferenceInfo" => new CSStruct("StdVideoDecodeH264ReferenceInfo", @const),
                        "StdVideoDecodeH264PictureInfoFlags" => new CSStruct("StdVideoDecodeH264PictureInfoFlags", @const),
                        "StdVideoDecodeH264ReferenceInfoFlags" => new CSStruct("StdVideoDecodeH264ReferenceInfoFlags", @const),

                        "StdVideoH265ProfileIdc" => new CSEnum("StdVideoH265ProfileIdc", CSPrimitive.Int(@const), @const),
                        "StdVideoH265VideoParameterSet" => new CSStruct("StdVideoH265VideoParameterSet", @const),
                        "StdVideoH265SequenceParameterSet" => new CSStruct("StdVideoH265SequenceParameterSet", @const),
                        "StdVideoH265PictureParameterSet" => new CSStruct("StdVideoH265PictureParameterSet", @const),
                        "StdVideoH265DecPicBufMgr" => new CSStruct("StdVideoH265DecPicBufMgr", @const),
                        "StdVideoH265HrdParameters" => new CSStruct("StdVideoH265HrdParameters", @const),
                        "StdVideoH265VpsFlags" => new CSStruct("StdVideoH265VpsFlags", @const),
                        "StdVideoH265LevelIdc" => new CSEnum("StdVideoH265LevelIdc", CSPrimitive.Int(@const), @const),
                        "StdVideoH265SpsFlags" => new CSEnum("StdVideoH265SpsFlags", CSPrimitive.Int(@const), @const),
                        "StdVideoH265ScalingLists" => new CSStruct("StdVideoH265ScalingLists", @const),
                        "StdVideoH265SequenceParameterSetVui" => new CSStruct("StdVideoH265SequenceParameterSetVui", @const),
                        "StdVideoH265PredictorPaletteEntries" => new CSStruct("StdVideoH265PredictorPaletteEntries", @const),
                        "StdVideoH265PpsFlags" => new CSStruct("StdVideoH265PpsFlags", @const),
                        "StdVideoH265SubLayerHrdParameters" => new CSStruct("StdVideoH265SubLayerHrdParameters", @const),
                        "StdVideoH265HrdFlags" => new CSEnum("StdVideoH265HrdFlags", CSPrimitive.Int(@const), @const),
                        "StdVideoH265SpsVuiFlags" => new CSEnum("StdVideoH265SpsVuiFlags", CSPrimitive.Int(@const), @const),
                        "StdVideoH265SliceType" => new CSEnum("StdVideoH265SliceType", CSPrimitive.Int(@const), @const),
                        "StdVideoH265PictureType" => new CSEnum("StdVideoH265PictureType", CSPrimitive.Int(@const), @const),

                        "StdVideoDecodeH265PictureInfo" => new CSStruct("StdVideoDecodeH265PictureInfo", @const),
                        "StdVideoDecodeH265ReferenceInfo" => new CSStruct("StdVideoDecodeH265ReferenceInfo", @const),
                        "StdVideoDecodeH265PictureInfoFlags" => new CSStruct("StdVideoDecodeH265PictureInfoFlags", @const),
                        "StdVideoDecodeH265ReferenceInfoFlags" => new CSStruct("StdVideoDecodeH265ReferenceInfoFlags", @const),

                        "StdVideoAV1Profile" => new CSEnum("StdVideoAV1Profile", CSPrimitive.Int(@const), @const),
                        "StdVideoAV1Level" => new CSEnum("StdVideoAV1Level", CSPrimitive.Int(@const), @const),
                        "StdVideoAV1SequenceHeader" => new CSStruct("StdVideoAV1SequenceHeader", @const),

                        "StdVideoDecodeAV1PictureInfo" => new CSStruct("StdVideoDecodeAV1PictureInfo", @const),
                        "StdVideoDecodeAV1ReferenceInfo" => new CSStruct("StdVideoDecodeAV1ReferenceInfo", @const),

                        "StdVideoEncodeH264SliceHeader" => new CSStruct("StdVideoEncodeH264SliceHeader", @const),
                        "StdVideoEncodeH264PictureInfo" => new CSStruct("StdVideoEncodeH264PictureInfo", @const),
                        "StdVideoEncodeH264ReferenceInfo" => new CSStruct("StdVideoEncodeH264ReferenceInfo", @const),
                        "StdVideoEncodeH264SliceHeaderFlags" => new CSStruct("StdVideoEncodeH264SliceHeaderFlags", @const),
                        "StdVideoEncodeH264ReferenceListsInfo" => new CSStruct("StdVideoEncodeH264ReferenceListsInfo", @const),
                        "StdVideoEncodeH264PictureInfoFlags" => new CSStruct("StdVideoEncodeH264PictureInfoFlags", @const),
                        "StdVideoEncodeH264ReferenceInfoFlags" => new CSStruct("StdVideoEncodeH264ReferenceInfoFlags", @const),
                        "StdVideoEncodeH264RefMgmtFlags" => new CSStruct("StdVideoEncodeH264RefMgmtFlags", @const),
                        "StdVideoEncodeH264RefListModEntry" => new CSStruct("StdVideoEncodeH264RefListModEntry", @const),
                        "StdVideoEncodeH264RefPicMarkingEntry" => new CSStruct("StdVideoEncodeH264RefPicMarkingEntry", @const),

                        "StdVideoEncodeH265PictureInfoFlags" => new CSStruct("StdVideoEncodeH265PictureInfoFlags", @const),
                        "StdVideoEncodeH265PictureInfo" => new CSStruct("StdVideoEncodeH265PictureInfo", @const),
                        "StdVideoEncodeH265SliceSegmentHeader" => new CSStruct("StdVideoEncodeH265SliceSegmentHeader", @const),
                        "StdVideoEncodeH265ReferenceInfo" => new CSStruct("StdVideoEncodeH265ReferenceInfo", @const),
                        "StdVideoEncodeH265ReferenceListsInfo" => new CSStruct("StdVideoEncodeH265ReferenceListsInfo", @const),
                        "StdVideoEncodeH265SliceSegmentHeaderFlags" => new CSStruct("StdVideoEncodeH265SliceSegmentHeaderFlags", @const),
                        "StdVideoEncodeH265ReferenceInfoFlags" => new CSStruct("StdVideoEncodeH265ReferenceInfoFlags", @const),
                        "StdVideoEncodeH265ReferenceModificationFlags" => new CSStruct("StdVideoEncodeH265ReferenceModificationFlags", @const),
                        */

                        _ => throw new Exception($"Type conversion has not been created for type {type}"),
                    };
                }

                reference = null;
                return csType;
            }
        }

        private static BaseCSType ReplaceOpaqueStructPointers(BaseCSType type)
        {
            if (type is CSPointer csPointer && csPointer.BaseType is CSStruct csStruct)
            {
                switch (csStruct.TypeName)
                {
                    case "wl_display":
                    case "wl_surface":
                    case "Display":
                    case "xcb_connection_t":
                    case "IDirectFB":
                    case "IDirectFBSurface":
                    case "ANativeWindow":
                    case "AHardwareBuffer":
                    case "NvSciSyncFence":
                    case "OHNativeWindow":
                        return CSPrimitive.IntPtr(csPointer.Constant);
                    default:
                        return type;
                }
            }
            // If it wasn't a pointer to a struct, we try and dereference the pointer/array/whatever and do the same thing here.
            else if (type is IBaseTypeCSType nestingType)
            {
                return nestingType.CreateWithNewType(ReplaceOpaqueStructPointers(nestingType.BaseType));
            }
            else
            {
                return type;
            }
        }

        private static BaseCSType ReplaceFixedSizeArraysWithPointers(BaseCSType type)
        {
            if (type is CSFixedSizeArray csFixedSizeArray)
            {
                return new CSPointer(csFixedSizeArray.BaseType, false);
            }
            // If it wasn't a pointer to a struct, we try and dereference the pointer/array/whatever and do the same thing here.
            else if (type is IBaseTypeCSType nestingType)
            {
                return nestingType.CreateWithNewType(ReplaceFixedSizeArraysWithPointers(nestingType.BaseType));
            }
            else
            {
                return type;
            }
        }
    }
}
