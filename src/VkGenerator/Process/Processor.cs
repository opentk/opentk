using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkGenerator.Parsing;

namespace VkGenerator.Process
{
    public record TypedStructType(BaseCSType Type, string Name);

    internal class Processor
    {
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
                                extends.Members.Add(new EnumMember(requiredEnum.Name, requiredEnum.Value!.Value, requiredEnum.Comment, null, feature.Name));
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
                    foreach (RequireEnum requiredEnum in require.RequiredEnums)
                    {
                        if (requiredEnum.Alias == null)
                        {
                            EnumType? extends = data.Enums.Find(e => e.Name == requiredEnum.Extends);
                            Debug.Assert(extends != null);
                            if (extends.Members.Find(m => m.Name == requiredEnum.Name) == null)
                            {
                                extends.Members.Add(new EnumMember(requiredEnum.Name, requiredEnum.Value!.Value, requiredEnum.Comment, null, extension.Name));
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

        public static Dictionary<string, BaseCSType> BuildTypeMap(SpecificationData data)
        {
            Dictionary<string, BaseCSType> typeMap = new Dictionary<string, BaseCSType>();
            foreach (StructType @struct in data.Structs)
            {
                typeMap.Add(@struct.Name, new CSStruct(@struct.Name, true));
            }

            foreach (EnumType @enum in data.Enums)
            {
                // FIXME: Underlying enum type!
                typeMap.Add(@enum.Name, new CSEnum(@enum.Name, CSPrimitive.Int(true), true));
            }

            foreach (EnumName enumName in data.EnumNames)
            {
                if (enumName.Alias != null)
                {
                    if (typeMap.TryGetValue(enumName.Alias, out BaseCSType? enumType))
                    {
                        typeMap.Add(enumName.Name, enumType);
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
                if (bitmask.Requires != null && typeMap.TryGetValue(bitmask.Requires, out BaseCSType? enumType))
                {
                    typeMap.Add(bitmask.Name, enumType);
                }
                else
                {
                    // FIXME: Some of this is going to be fixed when we add in extensions...
                    typeMap.Add(bitmask.Name, new CSEnum(bitmask.Name, CSPrimitive.Int(true), true));
                    Console.WriteLine(bitmask.Name);

                    // FIXME: This isn't the place to do this!!!!
                    data.Enums.Add(new EnumType(bitmask.Name, new List<EnumMember>(), true, null));
                }
            }

            foreach (HandleType handle in data.Handles)
            {
                typeMap.Add(handle.Name, new CSStruct(handle.Name, true));
            }

            return typeMap;
        }

        public static void ResolveStructMemberTypes(SpecificationData data, Dictionary<string, BaseCSType> typeMap)
        {
            foreach (StructType @struct in data.Structs)
            {
                foreach (StructMember member in @struct.Members)
                {
                    member.StrongType = ParseType(member.Type, typeMap, data.Constants);
                    member.StrongType = ReplaceOpaqueStructPointers(member.StrongType);
                }
            }
        }

        public static void ResolveCommandTypes(SpecificationData data, Dictionary<string, BaseCSType> typeMap)
        {
            foreach (Command command in data.Commands)
            {
                command.StrongReturnType = ParseType(command.ReturnType, typeMap, data.Constants);
                command.StrongReturnType = ReplaceOpaqueStructPointers(command.StrongReturnType);
                command.StrongReturnType = ReplaceFixedSizeArraysWithPointers(command.StrongReturnType);


                foreach (CommandParameter param in command.Parameters)
                {
                    param.StrongType = ParseType(param.Type, typeMap, data.Constants);
                    param.StrongType = ReplaceOpaqueStructPointers(param.StrongType);
                    param.StrongType = ReplaceFixedSizeArraysWithPointers(param.StrongType);
                }
            }
        }

        private static BaseCSType ParseType(string type, Dictionary<string, BaseCSType> typeMap, Dictionary<string, Constant> constantsMap)
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

                BaseCSType? baseType = ParseType(withoutAsterisk, typeMap, constantsMap);

                return new CSPointer(baseType, @const);
            }
            else if (type.EndsWith(']'))
            {
                // There is just a single place in the specification with a
                // double array type. It's VkTransformMatrixKHR.
                // To simplify the code we just detect this special case.
                if (type == "float[3][4]")
                {
                    // FIXME: Is it Matrix4x3 or Matrix3x4??
                    return new CSStruct("Matrix4x3", false);
                }

                Debug.Assert(type.Count(c => c == '[') == 1, "We don't support 2d arrays...");

                int startIndex = type.IndexOf("[");

                string sizeStr = type[(startIndex + 1)..^1];
                // FIXME: Resolve size!

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

                string typeWithoutArray = type.Substring(0, startIndex);

                BaseCSType baseType = ParseType(typeWithoutArray, typeMap, constantsMap);

                return new CSFixedSizeArray(baseType, size);
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

                // FIXME: These are bitfield members!
                // This makes binding work that much more complicated as struct layout is
                // implementation defined in c.
                // We don't have a good solution for this atm, maybe a new CSBitfield type?
                // - Noggin_bops 2024-07-09
                if (type.EndsWith(":24"))
                {
                    Console.WriteLine(type);
                    type = type[..^":24".Length];
                }
                else if (type.EndsWith(":8"))
                {
                    Console.WriteLine(type);
                    type = type[..^":8".Length];
                }

                if (typeMap.TryGetValue(type, out BaseCSType? csMapType))
                {
                    if (csMapType is CSStruct csStruct)
                    {
                        // FIXME: @const!
                        return csStruct;
                    }
                    else if (csMapType is CSEnum csEnum)
                    {
                        // FIXME: @const!
                        return csEnum;
                    }
                    else if (csMapType is CSPrimitive csPrimitive && csPrimitive.TypeName == "IntPtr")
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
                        "int" => CSPrimitive.Int(@const),
                        "uint16_t" => CSPrimitive.Ushort(@const),
                        "int32_t" => CSPrimitive.Int(@const),
                        "uint32_t" => CSPrimitive.Uint(@const),
                        "int64_t" => CSPrimitive.Long(@const),
                        "uint64_t" => CSPrimitive.Ulong(@const),
                        "size_t" => CSPrimitive.Nuint(@const),

                        "float" => CSPrimitive.Float(@const),
                        "double" => CSPrimitive.Double(@const),

                        // FIXME: These should be possible to resolve automatically..?
                        "PFN_vkInternalAllocationNotification" => new CSFunctionPointer("VkInternalAllocationNotification", @const),
                        "PFN_vkInternalFreeNotification" => new CSFunctionPointer("VkInternalFreeNotification", @const),
                        "PFN_vkReallocationFunction" => new CSFunctionPointer("VkReallocationFunction", @const),
                        "PFN_vkAllocationFunction" => new CSFunctionPointer("VkAllocationFunction", @const),
                        "PFN_vkFreeFunction" => new CSFunctionPointer("VkFreeFunction", @const),
                        "PFN_vkVoidFunction" => new CSFunctionPointer("VkVoidFunction", @const),
                        "PFN_vkDebugReportCallbackEXT" => new CSFunctionPointer("VkDebugReportCallbackEXT", @const),
                        "PFN_vkDebugUtilsMessengerCallbackEXT" => new CSFunctionPointer("VkDebugUtilsMessengerCallbackEXT", @const),
                        "PFN_vkFaultCallbackFunction" => new CSFunctionPointer("VkFaultCallbackFunction", @const),
                        "PFN_vkDeviceMemoryReportCallbackEXT" => new CSFunctionPointer("VkDeviceMemoryReportCallbackEXT", @const),
                        "PFN_vkGetInstanceProcAddrLUNARG" => new CSFunctionPointer("VkGetInstanceProcAddrLUNARG", @const),

                        "VkSampleMask" => CSPrimitive.Uint(@const),
                        "VkBool32" => new CSBool32(@const),
                        "VkFlags" => CSPrimitive.Uint(@const),
                        "VkFlags64" => CSPrimitive.Ulong(@const),
                        "VkDeviceSize" => CSPrimitive.Ulong(@const),
                        "VkDeviceAddress" => CSPrimitive.Ulong(@const),

                        "VkRemoteAddressNV" => new CSPointer(new CSVoid(@const), @const),

                        "Display" => new CSStruct("Display", @const), // FIXME: This is just a struct?
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
                        "GgpStreamDescriptor" => new CSNotSupportedType(),
                        "GgpFrameToken" => new CSNotSupportedType(),

                        "_screen_context" => CSPrimitive.IntPtr(@const),
                        "_screen_window" => CSPrimitive.IntPtr(@const),
                        "_screen_buffer" => CSPrimitive.IntPtr(@const),

                        "NvSciSyncAttrList" => CSPrimitive.IntPtr(@const),
                        "NvSciSyncObj" => CSPrimitive.IntPtr(@const),
                        // uint64_t payload[6]; 
                        "NvSciSyncFence" => new CSStruct("NvSciSyncFence", @const),
                        "NvSciBufAttrList" => CSPrimitive.IntPtr(@const),
                        "NvSciBufObj" => CSPrimitive.IntPtr(@const),

                        "ANativeWindow" => new CSStruct("ANativeWindow", @const),
                        "AHardwareBuffer" => new CSStruct("AHardwareBuffer", @const),

                        "CAMetalLayer" => CSPrimitive.IntPtr(@const),
                        "MTLDevice_id" => CSPrimitive.IntPtr(@const),
                        "MTLCommandQueue_id" => CSPrimitive.IntPtr(@const),
                        "MTLBuffer_id" => CSPrimitive.IntPtr(@const),
                        "MTLTexture_id" => CSPrimitive.IntPtr(@const),
                        "MTLSharedEvent_id" => CSPrimitive.IntPtr(@const),
                        "IOSurfaceRef" => CSPrimitive.IntPtr(@const),

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

                        _ => throw new Exception($"Type conversion has not been created for type {type}"),
                    };
                }

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
