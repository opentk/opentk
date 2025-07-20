using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrGenerator.Parsing;

namespace XrGenerator.Process
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
            data.Bitmasks.Sort((b1, b2) => string.Compare(b1.Name, b2.Name, StringComparison.InvariantCulture));
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
                    foreach (RequireEnum requiredEnum in require.RequiredEnums)
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
                    foreach (RequireEnum requiredEnum in require.RequiredEnums)
                    {
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
                    foreach (RequireEnum requiredEnum in require.RequiredEnums)
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
                    foreach (RequireEnum requiredEnum in require.RequiredEnums)
                    {
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
                    foreach (Constant constant in requireTag.Constants)
                    {
                        // FIXME: Mark these as from a specific extension so we can add a comment about that.
                        data.Constants.Add(constant.Name, constant);
                    }
                }
            }
        }

        public static Dictionary<string, TypeEntry> BuildTypeMap(SpecificationData data)
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
                        "XrFlags" => CSPrimitive.Uint(true),
                        "XrFlags64" => CSPrimitive.Ulong(true),
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

            foreach (BitmaskName bitmask in data.Bitmasks)
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

                    EnumType newEnumType = new EnumType(bitmask.Name, new List<EnumMember>(), true, null, null) { StrongUnderlyingType = type };

                    typeMap.Add(bitmask.Name, new TypeEntry(new CSEnum(bitmask.Name, type, true), newEnumType));

                    // FIXME: This isn't the place to do this!!!!
                    data.Enums.Add(newEnumType);
                }
            }

            foreach (HandleType handle in data.Handles)
            {
                typeMap.Add(handle.Name, new TypeEntry(new CSStruct(handle.Name, true), handle));
            }

            return typeMap;
        }

        public static Dictionary<string, Constant> BuildConstantsMap(SpecificationData data)
        {
            Dictionary<string, Constant> constantsMap = new Dictionary<string, Constant>(data.Constants);

            foreach (Define define in data.Defines)
            {
                if (define.IsConstant)
                {
                    constantsMap.Add(define.Name, new Constant(ConstantType.Int32, define.Name, null, null, define.ConstValue, 0, ""));
                }
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
                    Debug.Assert(handle.Name == "XrInstance");
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
            foreach (Command command in data.Commands)
            {
                command.StrongReturnType = ParseType(command.ReturnType, typeMap, data.Constants, out IReferable? reference);
                command.StrongReturnType = ReplaceOpaqueStructPointers(command.StrongReturnType);
                command.StrongReturnType = ReplaceFixedSizeArraysWithPointers(command.StrongReturnType);

                reference?.MarkReferencedBy(command);

                foreach (CommandParameter param in command.Parameters)
                {
                    param.StrongType = ParseType(param.Type, typeMap, data.Constants, out reference);
                    param.StrongType = ReplaceOpaqueStructPointers(param.StrongType);
                    param.StrongType = ReplaceFixedSizeArraysWithPointers(param.StrongType);

                    reference?.MarkReferencedBy(command);
                }
            }
        }

        public static void ResolveVersionInfo(SpecificationData data, Dictionary<string, TypeEntry> typeMap)
        {
            foreach (Feature feature in data.Features)
            {
                // FIXME: More robust parsing?
                Version featureVer = Version.Parse(feature.Number);
                
                foreach (RequireTag require in feature.RequireTags)
                {
                    foreach (RequireCommand requireCommand in require.RequiredCommands)
                    {
                        Command command = data.Commands.Find(c => c.Name == requireCommand.Name) ?? throw new Exception();

                        if (command.VersionInfo == null)
                        {
                            command.VersionInfo = new VersionInfo(featureVer, null, new List<string>());
                        }
                        else if (command.VersionInfo.Version > featureVer)
                        {
                            Debug.Assert(false, "This has never happened. So this codepath is untested.");
                            command.VersionInfo = command.VersionInfo with { Version = featureVer };
                        }
                    }

                    foreach (RequireEnum requireEnum in require.RequiredEnums)
                    {
                        EnumType? extends = data.Enums.Find(e => e.Name == requireEnum.Extends);
                        Debug.Assert(extends != null);
                        EnumMember member = extends.Members.Find(m => m.Name == requireEnum.Name) ?? throw new Exception();
                        if (member.VersionInfo == null)
                        {
                            member.VersionInfo = new VersionInfo(featureVer, null, new List<string>());
                        }
                        else if (member.VersionInfo.Version < featureVer)
                        {
                            Debug.Assert(false, "This has never happened. So this codepath is untested.");
                            member.VersionInfo = member.VersionInfo with { Version = featureVer };
                        }
                    }

                    foreach (RequireType requireType in require.RequiredTypes)
                    {
                        StructType? structType = data.Structs.Find(s => s.Name == requireType.Name);
                        EnumType? enumType = data.Enums.Find(e => e.Name == requireType.Name);
                        Debug.Assert(!(structType != null && enumType != null), "We matched two types for this require... Something has gone bad.");
                        if (structType != null)
                        {
                            if (structType.VersionInfo == null)
                            {
                                structType.VersionInfo = new VersionInfo(featureVer, null, new List<string>());
                            }
                            else if (structType.VersionInfo.Version < featureVer)
                            {
                                Debug.Assert(false, "This has never happened. So this codepath is untested.");
                                structType.VersionInfo = structType.VersionInfo with { Version = featureVer };
                            }
                        }
                        else if (enumType != null)
                        {
                            if (enumType.VersionInfo == null)
                            {
                                enumType.VersionInfo = new VersionInfo(featureVer, null, new List<string>());
                            }
                            else if (enumType.VersionInfo.Version < featureVer)
                            {
                                Debug.Assert(false, "This has never happened. So this codepath is untested.");
                                enumType.VersionInfo = enumType.VersionInfo with { Version = featureVer };
                            }
                        }
                    }
                }
            }

            foreach (Extension extension in data.Extensions)
            {
                string extensionName = extension.Name;
                foreach (RequireTag require in extension.RequireTags)
                {
                    foreach (RequireCommand requireCommand in require.RequiredCommands)
                    {
                        Command command = data.Commands.Find(c => c.Name == requireCommand.Name) ?? throw new Exception();

                        if (command.VersionInfo == null)
                        {
                            command.VersionInfo = new VersionInfo(null, null, [extensionName]);
                        }
                        else
                        {
                            command.VersionInfo.Extensions.Add(extensionName);
                        }
                    }

                    foreach (RequireEnum requireEnum in require.RequiredEnums)
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
                            member.VersionInfo = new VersionInfo(null, null, [extensionName]);
                        }
                        else
                        {
                            member.VersionInfo.Extensions.Add(extensionName);
                        }
                    }

                    foreach (RequireType requireType in require.RequiredTypes)
                    {
                        StructType? structType = data.Structs.Find(s => s.Name == requireType.Name);
                        EnumType? enumType = data.Enums.Find(e => e.Name == requireType.Name);
                        Debug.Assert(!(structType != null && enumType != null), "We matched two types for this require... Something has gone bad.");
                        if (structType != null)
                        {
                            if (structType.VersionInfo == null)
                            {
                                structType.VersionInfo = new VersionInfo(null, null, [extensionName]);
                            }
                            else
                            {
                                structType.VersionInfo.Extensions.Add(extensionName);
                            }
                        }
                        else if (enumType != null)
                        {
                            if (enumType.VersionInfo == null)
                            {
                                enumType.VersionInfo = new VersionInfo(null, null, [extensionName]);
                            }
                            else
                            {
                                enumType.VersionInfo.Extensions.Add(extensionName);
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
                        "XrFlags" => CSPrimitive.Uint(true),
                        "XrFlags64" => CSPrimitive.Ulong(true),
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

                return new CSPointer(baseType, @const);
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
                // FIXME: Maybe add enums to the constant map?
                // This is the only enum that is used as a constant however...
                // - Noggin_bops 2025-03-30
                else if (sizeStr == "XR_EYE_POSITION_COUNT_FB")
                {
                    size = 2;
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
                        // FIXME: This is not true, it differs between operating systems!
                        // - Noggin_bops 2025-03-30
                        "wchar_t" => new CSChar16(@const),
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

                        "XrBool32" => CSPrimitive.Int(@const),
                        "XrFlags64" => CSPrimitive.Ulong(@const),
                        "XrTime" => CSPrimitive.Long(@const),
                        "XrDuration" => CSPrimitive.Long(@const),
                        "XrVersion" => CSPrimitive.Ulong(@const),
                        "XrSpaceUserIdFB" => CSPrimitive.Ulong(@const),

                        "XrFutureEXT" => CSPrimitive.Ulong(@const),

                        // Atoms
                        "XrPath" => CSPrimitive.Ulong(@const),
                        "XrSystemId" => CSPrimitive.Ulong(@const),
                        "XrControllerModelKeyMSFT" => CSPrimitive.Ulong(@const),
                        "XrAsyncRequestIdFB" => CSPrimitive.Ulong(@const),
                        "XrRenderModelKeyFB" => CSPrimitive.Ulong(@const),
                        "XrMarkerML" => CSPrimitive.Ulong(@const),

                        // FIXME: Platform types.
                        "ANativeWindow" => new CSStruct("ANativeWindow", @const),
                        // FIXME:
                        "jobject" => new CSStruct("void", @const),
                        "CGLContextObj" => CSPrimitive.IntPtr(@const),
                        "D3D_FEATURE_LEVEL" => CSPrimitive.Int(@const),
                        "ID3D11Device" => CSPrimitive.IntPtr(@const),
                        "ID3D11Texture2D" => CSPrimitive.IntPtr(@const),
                        "ID3D12CommandQueue" => CSPrimitive.IntPtr(@const),
                        "ID3D12Device" => CSPrimitive.IntPtr(@const),
                        "ID3D12Resource" => CSPrimitive.IntPtr(@const),
                        "EGLDisplay" => new CSStruct("EGLDisplay", @const),
                        "EGLConfig" => new CSStruct("EGLConfig", @const),
                        "EGLContext" => new CSStruct("EGLContext", @const),
                        "EGLenum" => new CSStruct("OpenTK.Graphics.Egl.All", @const),
                        "GLXFBConfig" => new CSStruct("GLXFBConfig", @const),
                        "GLXDrawable" => new CSStruct("GLXDrawable", @const),
                        "GLXContext" => new CSStruct("GLXContext", @const),
                        "HGLRC" => CSPrimitive.IntPtr(@const),
                        "IUnknown" => CSPrimitive.IntPtr(@const),
                        "wl_display" => new CSStruct("wl_display", @const), // FIXME: This is just a struct?
                        "HDC" => CSPrimitive.IntPtr(@const),
                        "LUID" => new CSStruct("Guid", @const),
                        "LARGE_INTEGER" => CSPrimitive.Long(@const),
                        "Display" => new CSStruct("Display", @const), // FIXME: This is just a struct?
                        "VisualID" => CSPrimitive.Nuint(@const),
                        "Window" => CSPrimitive.Nuint(@const),
                        "xcb_glx_fbconfig_t" => CSPrimitive.Uint(@const),
                        "xcb_glx_drawable_t" => CSPrimitive.Uint(@const),
                        "xcb_glx_context_t" => CSPrimitive.Uint(@const),
                        "xcb_connection_t" => new CSStruct("xcb_connection_t", @const),
                        "xcb_visualid_t" => CSPrimitive.Uint(@const),
                        "xcb_window_t" => CSPrimitive.Uint(@const),
                        // FIXME: Where does PFN_vkGetInstanceProcAddr define in vulkan.h come from?
                        "PFN_vkGetInstanceProcAddr" => new CSFunctionPointer("VkGetInstanceProcAddrLUNARG", @const,
                            new CSOpaqueFunctionPointer("VkVoidFunction", true),
                            [
                                new CSStruct("VkInstance", true),
                                new CSPointer(new CSChar8(true), true),
                            ]),
                        "VkAllocationCallbacks" => new CSStruct("VkAllocationCallbacks", @const),
                        "VkComponentSwizzle" => new CSStruct("VkComponentSwizzle", @const),
                        "VkDevice" => new CSStruct("VkDevice", @const),
                        "VkDeviceCreateInfo" => new CSStruct("VkDeviceCreateInfo", @const),
                        "VkFilter" => new CSStruct("VkFilter", @const),
                        "VkFormat" => new CSStruct("VkFormat", @const),
                        "VkImage" => new CSStruct("VkImage", @const),
                        "VkImageCreateFlags" => new CSStruct("VkImageCreateFlagBits", @const),
                        "VkImageUsageFlags" => new CSStruct("VkImageUsageFlagBits", @const),
                        "VkInstance" => new CSStruct("VkInstance", @const),
                        "VkInstanceCreateInfo" => new CSStruct("VkInstanceCreateInfo", @const),
                        "VkPhysicalDevice" => new CSStruct("VkPhysicalDevice", @const),
                        "VkResult" => new CSStruct("VkResult", @const),
                        "VkSamplerAddressMode" => new CSStruct("VkSamplerAddressMode", @const),
                        "VkSamplerMipmapMode" => new CSStruct("VkSamplerMipmapMode", @const),
                        // FIXME?
                        "timespec" => new CSStruct("void", @const),
                        "MLCoordinateFrameUID" => new CSStruct("Guid", @const),

                        "PFN_xrVoidFunction" => new CSFunctionPointer("PFN_xrVoidFunction", @const, new CSVoid(@const), []),

                        "PFN_xrGetInstanceProcAddr" => new CSFunctionPointer("XrGetInstanceProcAddr", @const,
                            new CSEnum("XrResult", CSPrimitive.Int(true), true),
                            [
                                new CSStruct("XrInstance", true),
                                new CSPointer(new CSChar8(true), true),
                                new CSPointer(new CSVoid(false), false),
                            ]),

                        "PFN_xrCreateApiLayerInstance" => new CSFunctionPointer("XrCreateApiLayerInstance", @const,
                            new CSEnum("XrResult", CSPrimitive.Int(true), true),
                            [
                                new CSPointer(new CSStruct("XrInstanceCreateInfo", true), true),
                                new CSPointer(new CSStruct("XrApiLayerCreateInfo", true), true),
                                new CSPointer(new CSChar8(true), true),
                                new CSPointer(new CSStruct("XrInstance", false), false),
                            ]),

                        "PFN_xrDebugUtilsMessengerCallbackEXT" => new CSFunctionPointer("XrDebugUtilsMessengerCallbackEXT", @const,
                            new CSBool32(true),
                            [
                                new CSStruct("XrDebugUtilsMessageSeverityFlagBitsEXT", true),
                                new CSStruct("XrDebugUtilsMessageTypeFlagBitsEXT", true),
                                new CSPointer(new CSStruct("XrDebugUtilsMessengerCallbackDataEXT", true), true),
                                new CSPointer(new CSVoid(false), false),
                            ]),

                        "PFN_xrEglGetProcAddressMNDX" => new CSFunctionPointer("XrEglGetProcAddressMNDX", @const,
                            new CSPointer(new CSVoid(false), false),
                            [
                                new CSPointer(new CSChar8(true), true),
                            ]),



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
