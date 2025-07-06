// This file is auto generated, do not edit.
using OpenTK.Mathematics;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static unsafe partial class Vk
    {
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_PHYSICAL_DEVICE_NAME_SIZE.html" /></remarks>
        public const uint MaxPhysicalDeviceNameSize = 256;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_UUID_SIZE.html" /></remarks>
        public const uint UuidSize = 16;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_LUID_SIZE.html" /></remarks>
        public const uint LuidSize = 8;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_EXTENSION_NAME_SIZE.html" /></remarks>
        public const uint MaxExtensionNameSize = 256;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_DESCRIPTION_SIZE.html" /></remarks>
        public const uint MaxDescriptionSize = 256;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_MEMORY_TYPES.html" /></remarks>
        public const uint MaxMemoryTypes = 32;
        /// <summary>The maximum number of unique memory heaps, each of which supporting 1 or more memory types</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_MEMORY_HEAPS.html" /></remarks>
        public const uint MaxMemoryHeaps = 16;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_LOD_CLAMP_NONE.html" /></remarks>
        public const float LodClampNone = 1000;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_REMAINING_MIP_LEVELS.html" /></remarks>
        public const uint RemainingMipLevels = 4294967295;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_REMAINING_ARRAY_LAYERS.html" /></remarks>
        public const uint RemainingArrayLayers = 4294967295;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_REMAINING_3D_SLICES_EXT.html" /></remarks>
        public const uint Remaining3dSlicesExt = 4294967295;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_WHOLE_SIZE.html" /></remarks>
        public const ulong WholeSize = 18446744073709551615;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ATTACHMENT_UNUSED.html" /></remarks>
        public const uint AttachmentUnused = 4294967295;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_TRUE.html" /></remarks>
        public const uint True = 1;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_FALSE.html" /></remarks>
        public const uint False = 0;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QUEUE_FAMILY_IGNORED.html" /></remarks>
        public const uint QueueFamilyIgnored = 4294967295;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QUEUE_FAMILY_EXTERNAL.html" /></remarks>
        public const uint QueueFamilyExternal = 4294967294;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QUEUE_FAMILY_FOREIGN_EXT.html" /></remarks>
        public const uint QueueFamilyForeignExt = 4294967293;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_SUBPASS_EXTERNAL.html" /></remarks>
        public const uint SubpassExternal = 4294967295;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_DEVICE_GROUP_SIZE.html" /></remarks>
        public const uint MaxDeviceGroupSize = 32;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_DRIVER_NAME_SIZE.html" /></remarks>
        public const uint MaxDriverNameSize = 256;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_DRIVER_INFO_SIZE.html" /></remarks>
        public const uint MaxDriverInfoSize = 256;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_SHADER_UNUSED_KHR.html" /></remarks>
        public const uint ShaderUnusedKhr = 4294967295;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_GLOBAL_PRIORITY_SIZE.html" /></remarks>
        public const uint MaxGlobalPrioritySize = 16;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT.html" /></remarks>
        public const uint MaxShaderModuleIdentifierSizeExt = 32;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_PIPELINE_BINARY_KEY_SIZE_KHR.html" /></remarks>
        public const uint MaxPipelineBinaryKeySizeKhr = 32;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_VIDEO_AV1_REFERENCES_PER_FRAME_KHR.html" /></remarks>
        public const uint MaxVideoAv1ReferencesPerFrameKhr = 7;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_VIDEO_VP9_REFERENCES_PER_FRAME_KHR.html" /></remarks>
        public const uint MaxVideoVp9ReferencesPerFrameKhr = 3;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_SHADER_INDEX_UNUSED_AMDX.html" /></remarks>
        public const uint ShaderIndexUnusedAmdx = 4294967295;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_PARTITIONED_ACCELERATION_STRUCTURE_PARTITION_INDEX_GLOBAL_NV.html" /></remarks>
        public const uint PartitionedAccelerationStructurePartitionIndexGlobalNv = 4294967295;
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MAX_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_SET_NAME_SIZE_ARM.html" /></remarks>
        public const uint MaxPhysicalDeviceDataGraphOperationSetNameSizeArm = 128;
        /// <summary>[from: <b>VK_KHR_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint KhrSurfaceSpecVersion = 25;
        /// <summary>[from: <b>VK_KHR_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string KhrSurfaceExtensionName = "VK_KHR_surface";
        /// <summary>[from: <b>VK_KHR_swapchain</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SWAPCHAIN_SPEC_VERSION.html" /></remarks>
        public const uint KhrSwapchainSpecVersion = 70;
        /// <summary>[from: <b>VK_KHR_swapchain</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SWAPCHAIN_EXTENSION_NAME.html" /></remarks>
        public const string KhrSwapchainExtensionName = "VK_KHR_swapchain";
        /// <summary>[from: <b>VK_KHR_display</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DISPLAY_SPEC_VERSION.html" /></remarks>
        public const uint KhrDisplaySpecVersion = 23;
        /// <summary>[from: <b>VK_KHR_display</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DISPLAY_EXTENSION_NAME.html" /></remarks>
        public const string KhrDisplayExtensionName = "VK_KHR_display";
        /// <summary>[from: <b>VK_KHR_display_swapchain</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DISPLAY_SWAPCHAIN_SPEC_VERSION.html" /></remarks>
        public const uint KhrDisplaySwapchainSpecVersion = 10;
        /// <summary>[from: <b>VK_KHR_display_swapchain</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME.html" /></remarks>
        public const string KhrDisplaySwapchainExtensionName = "VK_KHR_display_swapchain";
        /// <summary>[from: <b>VK_KHR_xlib_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_XLIB_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint KhrXlibSurfaceSpecVersion = 6;
        /// <summary>[from: <b>VK_KHR_xlib_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_XLIB_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string KhrXlibSurfaceExtensionName = "VK_KHR_xlib_surface";
        /// <summary>[from: <b>VK_KHR_xcb_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_XCB_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint KhrXcbSurfaceSpecVersion = 6;
        /// <summary>[from: <b>VK_KHR_xcb_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_XCB_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string KhrXcbSurfaceExtensionName = "VK_KHR_xcb_surface";
        /// <summary>[from: <b>VK_KHR_wayland_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_WAYLAND_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint KhrWaylandSurfaceSpecVersion = 6;
        /// <summary>[from: <b>VK_KHR_wayland_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_WAYLAND_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string KhrWaylandSurfaceExtensionName = "VK_KHR_wayland_surface";
        /// <summary>[from: <b>VK_KHR_android_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_ANDROID_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint KhrAndroidSurfaceSpecVersion = 6;
        /// <summary>[from: <b>VK_KHR_android_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_ANDROID_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string KhrAndroidSurfaceExtensionName = "VK_KHR_android_surface";
        /// <summary>[from: <b>VK_KHR_win32_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_WIN32_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint KhrWin32SurfaceSpecVersion = 6;
        /// <summary>[from: <b>VK_KHR_win32_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_WIN32_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string KhrWin32SurfaceExtensionName = "VK_KHR_win32_surface";
        /// <summary>[from: <b>VK_EXT_debug_report</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEBUG_REPORT_SPEC_VERSION.html" /></remarks>
        public const uint ExtDebugReportSpecVersion = 10;
        /// <summary>[from: <b>VK_EXT_debug_report</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEBUG_REPORT_EXTENSION_NAME.html" /></remarks>
        public const string ExtDebugReportExtensionName = "VK_EXT_debug_report";
        /// <summary>[from: <b>VK_NV_glsl_shader</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_GLSL_SHADER_SPEC_VERSION.html" /></remarks>
        public const uint NvGlslShaderSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_glsl_shader</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_GLSL_SHADER_EXTENSION_NAME.html" /></remarks>
        public const string NvGlslShaderExtensionName = "VK_NV_glsl_shader";
        /// <summary>[from: <b>VK_EXT_depth_range_unrestricted</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEPTH_RANGE_UNRESTRICTED_SPEC_VERSION.html" /></remarks>
        public const uint ExtDepthRangeUnrestrictedSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_depth_range_unrestricted</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME.html" /></remarks>
        public const string ExtDepthRangeUnrestrictedExtensionName = "VK_EXT_depth_range_unrestricted";
        /// <summary>[from: <b>VK_KHR_sampler_mirror_clamp_to_edge</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_SPEC_VERSION.html" /></remarks>
        public const uint KhrSamplerMirrorClampToEdgeSpecVersion = 3;
        /// <summary>[from: <b>VK_KHR_sampler_mirror_clamp_to_edge</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_EXTENSION_NAME.html" /></remarks>
        public const string KhrSamplerMirrorClampToEdgeExtensionName = "VK_KHR_sampler_mirror_clamp_to_edge";
        /// <summary>[from: <b>VK_IMG_filter_cubic</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_IMG_FILTER_CUBIC_SPEC_VERSION.html" /></remarks>
        public const uint ImgFilterCubicSpecVersion = 1;
        /// <summary>[from: <b>VK_IMG_filter_cubic</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_IMG_FILTER_CUBIC_EXTENSION_NAME.html" /></remarks>
        public const string ImgFilterCubicExtensionName = "VK_IMG_filter_cubic";
        /// <summary>[from: <b>VK_AMD_rasterization_order</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_RASTERIZATION_ORDER_SPEC_VERSION.html" /></remarks>
        public const uint AmdRasterizationOrderSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_rasterization_order</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME.html" /></remarks>
        public const string AmdRasterizationOrderExtensionName = "VK_AMD_rasterization_order";
        /// <summary>[from: <b>VK_AMD_shader_trinary_minmax</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_TRINARY_MINMAX_SPEC_VERSION.html" /></remarks>
        public const uint AmdShaderTrinaryMinmaxSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_trinary_minmax</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_TRINARY_MINMAX_EXTENSION_NAME.html" /></remarks>
        public const string AmdShaderTrinaryMinmaxExtensionName = "VK_AMD_shader_trinary_minmax";
        /// <summary>[from: <b>VK_AMD_shader_explicit_vertex_parameter</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_SPEC_VERSION.html" /></remarks>
        public const uint AmdShaderExplicitVertexParameterSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_explicit_vertex_parameter</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME.html" /></remarks>
        public const string AmdShaderExplicitVertexParameterExtensionName = "VK_AMD_shader_explicit_vertex_parameter";
        /// <summary>[from: <b>VK_EXT_debug_marker</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEBUG_MARKER_SPEC_VERSION.html" /></remarks>
        public const uint ExtDebugMarkerSpecVersion = 4;
        /// <summary>[from: <b>VK_EXT_debug_marker</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEBUG_MARKER_EXTENSION_NAME.html" /></remarks>
        public const string ExtDebugMarkerExtensionName = "VK_EXT_debug_marker";
        /// <summary>[from: <b>VK_KHR_video_queue</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_QUEUE_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoQueueSpecVersion = 8;
        /// <summary>[from: <b>VK_KHR_video_queue</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_QUEUE_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoQueueExtensionName = "VK_KHR_video_queue";
        /// <summary>[from: <b>VK_KHR_video_decode_queue</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_DECODE_QUEUE_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoDecodeQueueSpecVersion = 8;
        /// <summary>[from: <b>VK_KHR_video_decode_queue</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_DECODE_QUEUE_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoDecodeQueueExtensionName = "VK_KHR_video_decode_queue";
        /// <summary>[from: <b>VK_AMD_gcn_shader</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_GCN_SHADER_SPEC_VERSION.html" /></remarks>
        public const uint AmdGcnShaderSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_gcn_shader</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_GCN_SHADER_EXTENSION_NAME.html" /></remarks>
        public const string AmdGcnShaderExtensionName = "VK_AMD_gcn_shader";
        /// <summary>[from: <b>VK_NV_dedicated_allocation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DEDICATED_ALLOCATION_SPEC_VERSION.html" /></remarks>
        public const uint NvDedicatedAllocationSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_dedicated_allocation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DEDICATED_ALLOCATION_EXTENSION_NAME.html" /></remarks>
        public const string NvDedicatedAllocationExtensionName = "VK_NV_dedicated_allocation";
        /// <summary>[from: <b>VK_EXT_transform_feedback</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_TRANSFORM_FEEDBACK_SPEC_VERSION.html" /></remarks>
        public const uint ExtTransformFeedbackSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_transform_feedback</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME.html" /></remarks>
        public const string ExtTransformFeedbackExtensionName = "VK_EXT_transform_feedback";
        /// <summary>[from: <b>VK_NVX_binary_import</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NVX_BINARY_IMPORT_SPEC_VERSION.html" /></remarks>
        public const uint NvxBinaryImportSpecVersion = 2;
        /// <summary>[from: <b>VK_NVX_binary_import</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NVX_BINARY_IMPORT_EXTENSION_NAME.html" /></remarks>
        public const string NvxBinaryImportExtensionName = "VK_NVX_binary_import";
        /// <summary>[from: <b>VK_NVX_image_view_handle</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NVX_IMAGE_VIEW_HANDLE_SPEC_VERSION.html" /></remarks>
        public const uint NvxImageViewHandleSpecVersion = 3;
        /// <summary>[from: <b>VK_NVX_image_view_handle</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME.html" /></remarks>
        public const string NvxImageViewHandleExtensionName = "VK_NVX_image_view_handle";
        /// <summary>[from: <b>VK_AMD_draw_indirect_count</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_DRAW_INDIRECT_COUNT_SPEC_VERSION.html" /></remarks>
        public const uint AmdDrawIndirectCountSpecVersion = 2;
        /// <summary>[from: <b>VK_AMD_draw_indirect_count</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_DRAW_INDIRECT_COUNT_EXTENSION_NAME.html" /></remarks>
        public const string AmdDrawIndirectCountExtensionName = "VK_AMD_draw_indirect_count";
        /// <summary>[from: <b>VK_AMD_negative_viewport_height</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION.html" /></remarks>
        public const uint AmdNegativeViewportHeightSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_negative_viewport_height</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME.html" /></remarks>
        public const string AmdNegativeViewportHeightExtensionName = "VK_AMD_negative_viewport_height";
        /// <summary>[from: <b>VK_AMD_gpu_shader_half_float</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_GPU_SHADER_HALF_FLOAT_SPEC_VERSION.html" /></remarks>
        public const uint AmdGpuShaderHalfFloatSpecVersion = 2;
        /// <summary>[from: <b>VK_AMD_gpu_shader_half_float</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_GPU_SHADER_HALF_FLOAT_EXTENSION_NAME.html" /></remarks>
        public const string AmdGpuShaderHalfFloatExtensionName = "VK_AMD_gpu_shader_half_float";
        /// <summary>[from: <b>VK_AMD_shader_ballot</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_BALLOT_SPEC_VERSION.html" /></remarks>
        public const uint AmdShaderBallotSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_ballot</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_BALLOT_EXTENSION_NAME.html" /></remarks>
        public const string AmdShaderBallotExtensionName = "VK_AMD_shader_ballot";
        /// <summary>[from: <b>VK_KHR_video_encode_h264</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_ENCODE_H264_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoEncodeH264SpecVersion = 14;
        /// <summary>[from: <b>VK_KHR_video_encode_h264</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_ENCODE_H264_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoEncodeH264ExtensionName = "VK_KHR_video_encode_h264";
        /// <summary>[from: <b>VK_KHR_video_encode_h265</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_ENCODE_H265_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoEncodeH265SpecVersion = 14;
        /// <summary>[from: <b>VK_KHR_video_encode_h265</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_ENCODE_H265_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoEncodeH265ExtensionName = "VK_KHR_video_encode_h265";
        /// <summary>[from: <b>VK_KHR_video_decode_h264</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_DECODE_H264_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoDecodeH264SpecVersion = 9;
        /// <summary>[from: <b>VK_KHR_video_decode_h264</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_DECODE_H264_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoDecodeH264ExtensionName = "VK_KHR_video_decode_h264";
        /// <summary>[from: <b>VK_AMD_texture_gather_bias_lod</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_TEXTURE_GATHER_BIAS_LOD_SPEC_VERSION.html" /></remarks>
        public const uint AmdTextureGatherBiasLodSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_texture_gather_bias_lod</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_TEXTURE_GATHER_BIAS_LOD_EXTENSION_NAME.html" /></remarks>
        public const string AmdTextureGatherBiasLodExtensionName = "VK_AMD_texture_gather_bias_lod";
        /// <summary>[from: <b>VK_AMD_shader_info</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_INFO_SPEC_VERSION.html" /></remarks>
        public const uint AmdShaderInfoSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_info</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_INFO_EXTENSION_NAME.html" /></remarks>
        public const string AmdShaderInfoExtensionName = "VK_AMD_shader_info";
        /// <summary>[from: <b>VK_KHR_dynamic_rendering</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DYNAMIC_RENDERING_SPEC_VERSION.html" /></remarks>
        public const uint KhrDynamicRenderingSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_dynamic_rendering</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DYNAMIC_RENDERING_EXTENSION_NAME.html" /></remarks>
        public const string KhrDynamicRenderingExtensionName = "VK_KHR_dynamic_rendering";
        /// <summary>[from: <b>VK_AMD_shader_image_load_store_lod</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_SPEC_VERSION.html" /></remarks>
        public const uint AmdShaderImageLoadStoreLodSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_image_load_store_lod</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_EXTENSION_NAME.html" /></remarks>
        public const string AmdShaderImageLoadStoreLodExtensionName = "VK_AMD_shader_image_load_store_lod";
        /// <summary>[from: <b>VK_GGP_stream_descriptor_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GGP_STREAM_DESCRIPTOR_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint GgpStreamDescriptorSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_GGP_stream_descriptor_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GGP_STREAM_DESCRIPTOR_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string GgpStreamDescriptorSurfaceExtensionName = "VK_GGP_stream_descriptor_surface";
        /// <summary>[from: <b>VK_NV_corner_sampled_image</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_CORNER_SAMPLED_IMAGE_SPEC_VERSION.html" /></remarks>
        public const uint NvCornerSampledImageSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_corner_sampled_image</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME.html" /></remarks>
        public const string NvCornerSampledImageExtensionName = "VK_NV_corner_sampled_image";
        /// <summary>[from: <b>VK_NV_private_vendor_info</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_PRIVATE_VENDOR_INFO_SPEC_VERSION.html" /></remarks>
        public const uint NvPrivateVendorInfoSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_private_vendor_info</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_PRIVATE_VENDOR_INFO_EXTENSION_NAME.html" /></remarks>
        public const string NvPrivateVendorInfoExtensionName = "VK_NV_private_vendor_info";
        /// <summary>[from: <b>VK_KHR_multiview</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MULTIVIEW_SPEC_VERSION.html" /></remarks>
        public const uint KhrMultiviewSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_multiview</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MULTIVIEW_EXTENSION_NAME.html" /></remarks>
        public const string KhrMultiviewExtensionName = "VK_KHR_multiview";
        /// <summary>[from: <b>VK_IMG_format_pvrtc</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_IMG_FORMAT_PVRTC_SPEC_VERSION.html" /></remarks>
        public const uint ImgFormatPvrtcSpecVersion = 1;
        /// <summary>[from: <b>VK_IMG_format_pvrtc</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_IMG_FORMAT_PVRTC_EXTENSION_NAME.html" /></remarks>
        public const string ImgFormatPvrtcExtensionName = "VK_IMG_format_pvrtc";
        /// <summary>[from: <b>VK_NV_external_memory_capabilities</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION.html" /></remarks>
        public const uint NvExternalMemoryCapabilitiesSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_external_memory_capabilities</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME.html" /></remarks>
        public const string NvExternalMemoryCapabilitiesExtensionName = "VK_NV_external_memory_capabilities";
        /// <summary>[from: <b>VK_NV_external_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_MEMORY_SPEC_VERSION.html" /></remarks>
        public const uint NvExternalMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_NV_external_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME.html" /></remarks>
        public const string NvExternalMemoryExtensionName = "VK_NV_external_memory";
        /// <summary>[from: <b>VK_NV_external_memory_win32</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_MEMORY_WIN32_SPEC_VERSION.html" /></remarks>
        public const uint NvExternalMemoryWin32SpecVersion = 1;
        /// <summary>[from: <b>VK_NV_external_memory_win32</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME.html" /></remarks>
        public const string NvExternalMemoryWin32ExtensionName = "VK_NV_external_memory_win32";
        /// <summary>[from: <b>VK_NV_win32_keyed_mutex</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_WIN32_KEYED_MUTEX_SPEC_VERSION.html" /></remarks>
        public const uint NvWin32KeyedMutexSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_win32_keyed_mutex</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME.html" /></remarks>
        public const string NvWin32KeyedMutexExtensionName = "VK_NV_win32_keyed_mutex";
        /// <summary>[from: <b>VK_KHR_get_physical_device_properties2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrGetPhysicalDeviceProperties2SpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_get_physical_device_properties2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrGetPhysicalDeviceProperties2ExtensionName = "VK_KHR_get_physical_device_properties2";
        /// <summary>[from: <b>VK_KHR_device_group</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DEVICE_GROUP_SPEC_VERSION.html" /></remarks>
        public const uint KhrDeviceGroupSpecVersion = 4;
        /// <summary>[from: <b>VK_KHR_device_group</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DEVICE_GROUP_EXTENSION_NAME.html" /></remarks>
        public const string KhrDeviceGroupExtensionName = "VK_KHR_device_group";
        /// <summary>[from: <b>VK_EXT_validation_flags</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_VALIDATION_FLAGS_SPEC_VERSION.html" /></remarks>
        public const uint ExtValidationFlagsSpecVersion = 3;
        /// <summary>[from: <b>VK_EXT_validation_flags</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_VALIDATION_FLAGS_EXTENSION_NAME.html" /></remarks>
        public const string ExtValidationFlagsExtensionName = "VK_EXT_validation_flags";
        /// <summary>[from: <b>VK_NN_vi_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NN_VI_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint NnViSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_NN_vi_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NN_VI_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string NnViSurfaceExtensionName = "VK_NN_vi_surface";
        /// <summary>[from: <b>VK_KHR_shader_draw_parameters</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_DRAW_PARAMETERS_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderDrawParametersSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_draw_parameters</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_DRAW_PARAMETERS_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderDrawParametersExtensionName = "VK_KHR_shader_draw_parameters";
        /// <summary>[from: <b>VK_EXT_shader_subgroup_ballot</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_SUBGROUP_BALLOT_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderSubgroupBallotSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_subgroup_ballot</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_SUBGROUP_BALLOT_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderSubgroupBallotExtensionName = "VK_EXT_shader_subgroup_ballot";
        /// <summary>[from: <b>VK_EXT_shader_subgroup_vote</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_SUBGROUP_VOTE_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderSubgroupVoteSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_subgroup_vote</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_SUBGROUP_VOTE_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderSubgroupVoteExtensionName = "VK_EXT_shader_subgroup_vote";
        /// <summary>[from: <b>VK_EXT_texture_compression_astc_hdr</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_SPEC_VERSION.html" /></remarks>
        public const uint ExtTextureCompressionAstcHdrSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_texture_compression_astc_hdr</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_EXTENSION_NAME.html" /></remarks>
        public const string ExtTextureCompressionAstcHdrExtensionName = "VK_EXT_texture_compression_astc_hdr";
        /// <summary>[from: <b>VK_EXT_astc_decode_mode</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ASTC_DECODE_MODE_SPEC_VERSION.html" /></remarks>
        public const uint ExtAstcDecodeModeSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_astc_decode_mode</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ASTC_DECODE_MODE_EXTENSION_NAME.html" /></remarks>
        public const string ExtAstcDecodeModeExtensionName = "VK_EXT_astc_decode_mode";
        /// <summary>[from: <b>VK_EXT_pipeline_robustness</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PIPELINE_ROBUSTNESS_SPEC_VERSION.html" /></remarks>
        public const uint ExtPipelineRobustnessSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_pipeline_robustness</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PIPELINE_ROBUSTNESS_EXTENSION_NAME.html" /></remarks>
        public const string ExtPipelineRobustnessExtensionName = "VK_EXT_pipeline_robustness";
        /// <summary>[from: <b>VK_KHR_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_1_SPEC_VERSION.html" /></remarks>
        public const uint KhrMaintenance1SpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_1_EXTENSION_NAME.html" /></remarks>
        public const string KhrMaintenance1ExtensionName = "VK_KHR_maintenance1";
        /// <summary>[from: <b>VK_KHR_device_group_creation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DEVICE_GROUP_CREATION_SPEC_VERSION.html" /></remarks>
        public const uint KhrDeviceGroupCreationSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_device_group_creation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME.html" /></remarks>
        public const string KhrDeviceGroupCreationExtensionName = "VK_KHR_device_group_creation";
        /// <summary>[from: <b>VK_KHR_external_memory_capabilities</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION.html" /></remarks>
        public const uint KhrExternalMemoryCapabilitiesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_memory_capabilities</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME.html" /></remarks>
        public const string KhrExternalMemoryCapabilitiesExtensionName = "VK_KHR_external_memory_capabilities";
        /// <summary>[from: <b>VK_KHR_external_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION.html" /></remarks>
        public const uint KhrExternalMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME.html" /></remarks>
        public const string KhrExternalMemoryExtensionName = "VK_KHR_external_memory";
        /// <summary>[from: <b>VK_KHR_external_memory_win32</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_MEMORY_WIN32_SPEC_VERSION.html" /></remarks>
        public const uint KhrExternalMemoryWin32SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_memory_win32</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME.html" /></remarks>
        public const string KhrExternalMemoryWin32ExtensionName = "VK_KHR_external_memory_win32";
        /// <summary>[from: <b>VK_KHR_external_memory_fd</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_MEMORY_FD_SPEC_VERSION.html" /></remarks>
        public const uint KhrExternalMemoryFdSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_memory_fd</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME.html" /></remarks>
        public const string KhrExternalMemoryFdExtensionName = "VK_KHR_external_memory_fd";
        /// <summary>[from: <b>VK_KHR_win32_keyed_mutex</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_WIN32_KEYED_MUTEX_SPEC_VERSION.html" /></remarks>
        public const uint KhrWin32KeyedMutexSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_win32_keyed_mutex</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME.html" /></remarks>
        public const string KhrWin32KeyedMutexExtensionName = "VK_KHR_win32_keyed_mutex";
        /// <summary>[from: <b>VK_KHR_external_semaphore_capabilities</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_SPEC_VERSION.html" /></remarks>
        public const uint KhrExternalSemaphoreCapabilitiesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_semaphore_capabilities</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME.html" /></remarks>
        public const string KhrExternalSemaphoreCapabilitiesExtensionName = "VK_KHR_external_semaphore_capabilities";
        /// <summary>[from: <b>VK_KHR_external_semaphore</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_SEMAPHORE_SPEC_VERSION.html" /></remarks>
        public const uint KhrExternalSemaphoreSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_semaphore</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_SEMAPHORE_EXTENSION_NAME.html" /></remarks>
        public const string KhrExternalSemaphoreExtensionName = "VK_KHR_external_semaphore";
        /// <summary>[from: <b>VK_KHR_external_semaphore_win32</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_SEMAPHORE_WIN32_SPEC_VERSION.html" /></remarks>
        public const uint KhrExternalSemaphoreWin32SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_semaphore_win32</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME.html" /></remarks>
        public const string KhrExternalSemaphoreWin32ExtensionName = "VK_KHR_external_semaphore_win32";
        /// <summary>[from: <b>VK_KHR_external_semaphore_fd</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_SEMAPHORE_FD_SPEC_VERSION.html" /></remarks>
        public const uint KhrExternalSemaphoreFdSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_semaphore_fd</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME.html" /></remarks>
        public const string KhrExternalSemaphoreFdExtensionName = "VK_KHR_external_semaphore_fd";
        /// <summary>[from: <b>VK_KHR_push_descriptor</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PUSH_DESCRIPTOR_SPEC_VERSION.html" /></remarks>
        public const uint KhrPushDescriptorSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_push_descriptor</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME.html" /></remarks>
        public const string KhrPushDescriptorExtensionName = "VK_KHR_push_descriptor";
        /// <summary>[from: <b>VK_EXT_conditional_rendering</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_CONDITIONAL_RENDERING_SPEC_VERSION.html" /></remarks>
        public const uint ExtConditionalRenderingSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_conditional_rendering</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME.html" /></remarks>
        public const string ExtConditionalRenderingExtensionName = "VK_EXT_conditional_rendering";
        /// <summary>[from: <b>VK_KHR_shader_float16_int8</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_FLOAT16_INT8_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderFloat16Int8SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_float16_int8</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_FLOAT16_INT8_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderFloat16Int8ExtensionName = "VK_KHR_shader_float16_int8";
        /// <summary>[from: <b>VK_KHR_16bit_storage</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_16BIT_STORAGE_SPEC_VERSION.html" /></remarks>
        public const uint Khr16bitStorageSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_16bit_storage</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_16BIT_STORAGE_EXTENSION_NAME.html" /></remarks>
        public const string Khr16bitStorageExtensionName = "VK_KHR_16bit_storage";
        /// <summary>[from: <b>VK_KHR_incremental_present</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION.html" /></remarks>
        public const uint KhrIncrementalPresentSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_incremental_present</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME.html" /></remarks>
        public const string KhrIncrementalPresentExtensionName = "VK_KHR_incremental_present";
        /// <summary>[from: <b>VK_KHR_descriptor_update_template</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_SPEC_VERSION.html" /></remarks>
        public const uint KhrDescriptorUpdateTemplateSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_descriptor_update_template</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_EXTENSION_NAME.html" /></remarks>
        public const string KhrDescriptorUpdateTemplateExtensionName = "VK_KHR_descriptor_update_template";
        /// <summary>[from: <b>VK_NV_clip_space_w_scaling</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_CLIP_SPACE_W_SCALING_SPEC_VERSION.html" /></remarks>
        public const uint NvClipSpaceWScalingSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_clip_space_w_scaling</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME.html" /></remarks>
        public const string NvClipSpaceWScalingExtensionName = "VK_NV_clip_space_w_scaling";
        /// <summary>[from: <b>VK_EXT_direct_mode_display</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DIRECT_MODE_DISPLAY_SPEC_VERSION.html" /></remarks>
        public const uint ExtDirectModeDisplaySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_direct_mode_display</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME.html" /></remarks>
        public const string ExtDirectModeDisplayExtensionName = "VK_EXT_direct_mode_display";
        /// <summary>[from: <b>VK_EXT_acquire_xlib_display</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ACQUIRE_XLIB_DISPLAY_SPEC_VERSION.html" /></remarks>
        public const uint ExtAcquireXlibDisplaySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_acquire_xlib_display</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ACQUIRE_XLIB_DISPLAY_EXTENSION_NAME.html" /></remarks>
        public const string ExtAcquireXlibDisplayExtensionName = "VK_EXT_acquire_xlib_display";
        /// <summary>[from: <b>VK_EXT_display_surface_counter</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DISPLAY_SURFACE_COUNTER_SPEC_VERSION.html" /></remarks>
        public const uint ExtDisplaySurfaceCounterSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_display_surface_counter</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DISPLAY_SURFACE_COUNTER_EXTENSION_NAME.html" /></remarks>
        public const string ExtDisplaySurfaceCounterExtensionName = "VK_EXT_display_surface_counter";
        /// <summary>[from: <b>VK_EXT_display_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DISPLAY_CONTROL_SPEC_VERSION.html" /></remarks>
        public const uint ExtDisplayControlSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_display_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME.html" /></remarks>
        public const string ExtDisplayControlExtensionName = "VK_EXT_display_control";
        /// <summary>[from: <b>VK_GOOGLE_display_timing</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_DISPLAY_TIMING_SPEC_VERSION.html" /></remarks>
        public const uint GoogleDisplayTimingSpecVersion = 1;
        /// <summary>[from: <b>VK_GOOGLE_display_timing</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME.html" /></remarks>
        public const string GoogleDisplayTimingExtensionName = "VK_GOOGLE_display_timing";
        /// <summary>[from: <b>VK_NV_sample_mask_override_coverage</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_SPEC_VERSION.html" /></remarks>
        public const uint NvSampleMaskOverrideCoverageSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_sample_mask_override_coverage</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME.html" /></remarks>
        public const string NvSampleMaskOverrideCoverageExtensionName = "VK_NV_sample_mask_override_coverage";
        /// <summary>[from: <b>VK_NV_geometry_shader_passthrough</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_GEOMETRY_SHADER_PASSTHROUGH_SPEC_VERSION.html" /></remarks>
        public const uint NvGeometryShaderPassthroughSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_geometry_shader_passthrough</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_GEOMETRY_SHADER_PASSTHROUGH_EXTENSION_NAME.html" /></remarks>
        public const string NvGeometryShaderPassthroughExtensionName = "VK_NV_geometry_shader_passthrough";
        /// <summary>[from: <b>VK_NV_viewport_array2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_VIEWPORT_ARRAY_2_SPEC_VERSION.html" /></remarks>
        public const uint NvViewportArray2SpecVersion = 1;
        /// <summary>[from: <b>VK_NV_viewport_array2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_VIEWPORT_ARRAY_2_EXTENSION_NAME.html" /></remarks>
        public const string NvViewportArray2ExtensionName = "VK_NV_viewport_array2";
        /// <summary>[from: <b>VK_NVX_multiview_per_view_attributes</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_SPEC_VERSION.html" /></remarks>
        public const uint NvxMultiviewPerViewAttributesSpecVersion = 1;
        /// <summary>[from: <b>VK_NVX_multiview_per_view_attributes</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME.html" /></remarks>
        public const string NvxMultiviewPerViewAttributesExtensionName = "VK_NVX_multiview_per_view_attributes";
        /// <summary>[from: <b>VK_NV_viewport_swizzle</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_VIEWPORT_SWIZZLE_SPEC_VERSION.html" /></remarks>
        public const uint NvViewportSwizzleSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_viewport_swizzle</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_VIEWPORT_SWIZZLE_EXTENSION_NAME.html" /></remarks>
        public const string NvViewportSwizzleExtensionName = "VK_NV_viewport_swizzle";
        /// <summary>[from: <b>VK_EXT_discard_rectangles</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DISCARD_RECTANGLES_SPEC_VERSION.html" /></remarks>
        public const uint ExtDiscardRectanglesSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_discard_rectangles</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME.html" /></remarks>
        public const string ExtDiscardRectanglesExtensionName = "VK_EXT_discard_rectangles";
        /// <summary>[from: <b>VK_EXT_conservative_rasterization</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_CONSERVATIVE_RASTERIZATION_SPEC_VERSION.html" /></remarks>
        public const uint ExtConservativeRasterizationSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_conservative_rasterization</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_CONSERVATIVE_RASTERIZATION_EXTENSION_NAME.html" /></remarks>
        public const string ExtConservativeRasterizationExtensionName = "VK_EXT_conservative_rasterization";
        /// <summary>[from: <b>VK_EXT_depth_clip_enable</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEPTH_CLIP_ENABLE_SPEC_VERSION.html" /></remarks>
        public const uint ExtDepthClipEnableSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_depth_clip_enable</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEPTH_CLIP_ENABLE_EXTENSION_NAME.html" /></remarks>
        public const string ExtDepthClipEnableExtensionName = "VK_EXT_depth_clip_enable";
        /// <summary>[from: <b>VK_EXT_swapchain_colorspace</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SWAPCHAIN_COLOR_SPACE_SPEC_VERSION.html" /></remarks>
        public const uint ExtSwapchainColorSpaceSpecVersion = 5;
        /// <summary>[from: <b>VK_EXT_swapchain_colorspace</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME.html" /></remarks>
        public const string ExtSwapchainColorSpaceExtensionName = "VK_EXT_swapchain_colorspace";
        /// <summary>[from: <b>VK_EXT_hdr_metadata</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_HDR_METADATA_SPEC_VERSION.html" /></remarks>
        public const uint ExtHdrMetadataSpecVersion = 3;
        /// <summary>[from: <b>VK_EXT_hdr_metadata</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_HDR_METADATA_EXTENSION_NAME.html" /></remarks>
        public const string ExtHdrMetadataExtensionName = "VK_EXT_hdr_metadata";
        /// <summary>[from: <b>VK_KHR_imageless_framebuffer</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_IMAGELESS_FRAMEBUFFER_SPEC_VERSION.html" /></remarks>
        public const uint KhrImagelessFramebufferSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_imageless_framebuffer</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME.html" /></remarks>
        public const string KhrImagelessFramebufferExtensionName = "VK_KHR_imageless_framebuffer";
        /// <summary>[from: <b>VK_KHR_create_renderpass2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_CREATE_RENDERPASS_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrCreateRenderpass2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_create_renderpass2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrCreateRenderpass2ExtensionName = "VK_KHR_create_renderpass2";
        /// <summary>[from: <b>VK_IMG_relaxed_line_rasterization</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_IMG_RELAXED_LINE_RASTERIZATION_SPEC_VERSION.html" /></remarks>
        public const uint ImgRelaxedLineRasterizationSpecVersion = 1;
        /// <summary>[from: <b>VK_IMG_relaxed_line_rasterization</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_IMG_RELAXED_LINE_RASTERIZATION_EXTENSION_NAME.html" /></remarks>
        public const string ImgRelaxedLineRasterizationExtensionName = "VK_IMG_relaxed_line_rasterization";
        /// <summary>[from: <b>VK_KHR_shared_presentable_image</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHARED_PRESENTABLE_IMAGE_SPEC_VERSION.html" /></remarks>
        public const uint KhrSharedPresentableImageSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shared_presentable_image</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME.html" /></remarks>
        public const string KhrSharedPresentableImageExtensionName = "VK_KHR_shared_presentable_image";
        /// <summary>[from: <b>VK_KHR_external_fence_capabilities</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_FENCE_CAPABILITIES_SPEC_VERSION.html" /></remarks>
        public const uint KhrExternalFenceCapabilitiesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_fence_capabilities</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_FENCE_CAPABILITIES_EXTENSION_NAME.html" /></remarks>
        public const string KhrExternalFenceCapabilitiesExtensionName = "VK_KHR_external_fence_capabilities";
        /// <summary>[from: <b>VK_KHR_external_fence</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_FENCE_SPEC_VERSION.html" /></remarks>
        public const uint KhrExternalFenceSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_fence</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_FENCE_EXTENSION_NAME.html" /></remarks>
        public const string KhrExternalFenceExtensionName = "VK_KHR_external_fence";
        /// <summary>[from: <b>VK_KHR_external_fence_win32</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_FENCE_WIN32_SPEC_VERSION.html" /></remarks>
        public const uint KhrExternalFenceWin32SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_fence_win32</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME.html" /></remarks>
        public const string KhrExternalFenceWin32ExtensionName = "VK_KHR_external_fence_win32";
        /// <summary>[from: <b>VK_KHR_external_fence_fd</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_FENCE_FD_SPEC_VERSION.html" /></remarks>
        public const uint KhrExternalFenceFdSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_fence_fd</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME.html" /></remarks>
        public const string KhrExternalFenceFdExtensionName = "VK_KHR_external_fence_fd";
        /// <summary>[from: <b>VK_KHR_performance_query</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PERFORMANCE_QUERY_SPEC_VERSION.html" /></remarks>
        public const uint KhrPerformanceQuerySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_performance_query</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME.html" /></remarks>
        public const string KhrPerformanceQueryExtensionName = "VK_KHR_performance_query";
        /// <summary>[from: <b>VK_KHR_maintenance2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrMaintenance2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_maintenance2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrMaintenance2ExtensionName = "VK_KHR_maintenance2";
        /// <summary>[from: <b>VK_KHR_get_surface_capabilities2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_GET_SURFACE_CAPABILITIES_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrGetSurfaceCapabilities2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_get_surface_capabilities2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrGetSurfaceCapabilities2ExtensionName = "VK_KHR_get_surface_capabilities2";
        /// <summary>[from: <b>VK_KHR_variable_pointers</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VARIABLE_POINTERS_SPEC_VERSION.html" /></remarks>
        public const uint KhrVariablePointersSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_variable_pointers</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VARIABLE_POINTERS_EXTENSION_NAME.html" /></remarks>
        public const string KhrVariablePointersExtensionName = "VK_KHR_variable_pointers";
        /// <summary>[from: <b>VK_KHR_get_display_properties2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_GET_DISPLAY_PROPERTIES_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrGetDisplayProperties2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_get_display_properties2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrGetDisplayProperties2ExtensionName = "VK_KHR_get_display_properties2";
        /// <summary>[from: <b>VK_MVK_ios_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MVK_IOS_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint MvkIosSurfaceSpecVersion = 3;
        /// <summary>[from: <b>VK_MVK_ios_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MVK_IOS_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string MvkIosSurfaceExtensionName = "VK_MVK_ios_surface";
        /// <summary>[from: <b>VK_MVK_macos_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MVK_MACOS_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint MvkMacosSurfaceSpecVersion = 3;
        /// <summary>[from: <b>VK_MVK_macos_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MVK_MACOS_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string MvkMacosSurfaceExtensionName = "VK_MVK_macos_surface";
        /// <summary>[from: <b>VK_EXT_external_memory_dma_buf</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTERNAL_MEMORY_DMA_BUF_SPEC_VERSION.html" /></remarks>
        public const uint ExtExternalMemoryDmaBufSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_external_memory_dma_buf</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME.html" /></remarks>
        public const string ExtExternalMemoryDmaBufExtensionName = "VK_EXT_external_memory_dma_buf";
        /// <summary>[from: <b>VK_EXT_queue_family_foreign</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_QUEUE_FAMILY_FOREIGN_SPEC_VERSION.html" /></remarks>
        public const uint ExtQueueFamilyForeignSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_queue_family_foreign</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME.html" /></remarks>
        public const string ExtQueueFamilyForeignExtensionName = "VK_EXT_queue_family_foreign";
        /// <summary>[from: <b>VK_KHR_dedicated_allocation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DEDICATED_ALLOCATION_SPEC_VERSION.html" /></remarks>
        public const uint KhrDedicatedAllocationSpecVersion = 3;
        /// <summary>[from: <b>VK_KHR_dedicated_allocation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DEDICATED_ALLOCATION_EXTENSION_NAME.html" /></remarks>
        public const string KhrDedicatedAllocationExtensionName = "VK_KHR_dedicated_allocation";
        /// <summary>[from: <b>VK_EXT_debug_utils</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEBUG_UTILS_SPEC_VERSION.html" /></remarks>
        public const uint ExtDebugUtilsSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_debug_utils</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEBUG_UTILS_EXTENSION_NAME.html" /></remarks>
        public const string ExtDebugUtilsExtensionName = "VK_EXT_debug_utils";
        /// <summary>[from: <b>VK_ANDROID_external_memory_android_hardware_buffer</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_SPEC_VERSION.html" /></remarks>
        public const uint AndroidExternalMemoryAndroidHardwareBufferSpecVersion = 5;
        /// <summary>[from: <b>VK_ANDROID_external_memory_android_hardware_buffer</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER_EXTENSION_NAME.html" /></remarks>
        public const string AndroidExternalMemoryAndroidHardwareBufferExtensionName = "VK_ANDROID_external_memory_android_hardware_buffer";
        /// <summary>[from: <b>VK_EXT_sampler_filter_minmax</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SAMPLER_FILTER_MINMAX_SPEC_VERSION.html" /></remarks>
        public const uint ExtSamplerFilterMinmaxSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_sampler_filter_minmax</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SAMPLER_FILTER_MINMAX_EXTENSION_NAME.html" /></remarks>
        public const string ExtSamplerFilterMinmaxExtensionName = "VK_EXT_sampler_filter_minmax";
        /// <summary>[from: <b>VK_KHR_storage_buffer_storage_class</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_SPEC_VERSION.html" /></remarks>
        public const uint KhrStorageBufferStorageClassSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_storage_buffer_storage_class</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_EXTENSION_NAME.html" /></remarks>
        public const string KhrStorageBufferStorageClassExtensionName = "VK_KHR_storage_buffer_storage_class";
        /// <summary>[from: <b>VK_AMD_gpu_shader_int16</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_GPU_SHADER_INT16_SPEC_VERSION.html" /></remarks>
        public const uint AmdGpuShaderInt16SpecVersion = 2;
        /// <summary>[from: <b>VK_AMD_gpu_shader_int16</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME.html" /></remarks>
        public const string AmdGpuShaderInt16ExtensionName = "VK_AMD_gpu_shader_int16";
        /// <summary>[from: <b>VK_AMDX_shader_enqueue</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMDX_SHADER_ENQUEUE_SPEC_VERSION.html" /></remarks>
        public const uint AmdxShaderEnqueueSpecVersion = 2;
        /// <summary>[from: <b>VK_AMDX_shader_enqueue</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMDX_SHADER_ENQUEUE_EXTENSION_NAME.html" /></remarks>
        public const string AmdxShaderEnqueueExtensionName = "VK_AMDX_shader_enqueue";
        /// <summary>[from: <b>VK_AMD_mixed_attachment_samples</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_MIXED_ATTACHMENT_SAMPLES_SPEC_VERSION.html" /></remarks>
        public const uint AmdMixedAttachmentSamplesSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_mixed_attachment_samples</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_MIXED_ATTACHMENT_SAMPLES_EXTENSION_NAME.html" /></remarks>
        public const string AmdMixedAttachmentSamplesExtensionName = "VK_AMD_mixed_attachment_samples";
        /// <summary>[from: <b>VK_AMD_shader_fragment_mask</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_FRAGMENT_MASK_SPEC_VERSION.html" /></remarks>
        public const uint AmdShaderFragmentMaskSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_fragment_mask</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_FRAGMENT_MASK_EXTENSION_NAME.html" /></remarks>
        public const string AmdShaderFragmentMaskExtensionName = "VK_AMD_shader_fragment_mask";
        /// <summary>[from: <b>VK_EXT_inline_uniform_block</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_INLINE_UNIFORM_BLOCK_SPEC_VERSION.html" /></remarks>
        public const uint ExtInlineUniformBlockSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_inline_uniform_block</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME.html" /></remarks>
        public const string ExtInlineUniformBlockExtensionName = "VK_EXT_inline_uniform_block";
        /// <summary>[from: <b>VK_EXT_shader_stencil_export</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_STENCIL_EXPORT_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderStencilExportSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_stencil_export</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_STENCIL_EXPORT_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderStencilExportExtensionName = "VK_EXT_shader_stencil_export";
        /// <summary>[from: <b>VK_KHR_shader_bfloat16</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_BFLOAT16_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderBfloat16SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_bfloat16</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_BFLOAT16_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderBfloat16ExtensionName = "VK_KHR_shader_bfloat16";
        /// <summary>[from: <b>VK_EXT_sample_locations</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SAMPLE_LOCATIONS_SPEC_VERSION.html" /></remarks>
        public const uint ExtSampleLocationsSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_sample_locations</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME.html" /></remarks>
        public const string ExtSampleLocationsExtensionName = "VK_EXT_sample_locations";
        /// <summary>[from: <b>VK_KHR_relaxed_block_layout</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_RELAXED_BLOCK_LAYOUT_SPEC_VERSION.html" /></remarks>
        public const uint KhrRelaxedBlockLayoutSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_relaxed_block_layout</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_RELAXED_BLOCK_LAYOUT_EXTENSION_NAME.html" /></remarks>
        public const string KhrRelaxedBlockLayoutExtensionName = "VK_KHR_relaxed_block_layout";
        /// <summary>[from: <b>VK_KHR_get_memory_requirements2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_GET_MEMORY_REQUIREMENTS_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrGetMemoryRequirements2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_get_memory_requirements2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrGetMemoryRequirements2ExtensionName = "VK_KHR_get_memory_requirements2";
        /// <summary>[from: <b>VK_KHR_image_format_list</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_IMAGE_FORMAT_LIST_SPEC_VERSION.html" /></remarks>
        public const uint KhrImageFormatListSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_image_format_list</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_IMAGE_FORMAT_LIST_EXTENSION_NAME.html" /></remarks>
        public const string KhrImageFormatListExtensionName = "VK_KHR_image_format_list";
        /// <summary>[from: <b>VK_EXT_blend_operation_advanced</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_BLEND_OPERATION_ADVANCED_SPEC_VERSION.html" /></remarks>
        public const uint ExtBlendOperationAdvancedSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_blend_operation_advanced</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_BLEND_OPERATION_ADVANCED_EXTENSION_NAME.html" /></remarks>
        public const string ExtBlendOperationAdvancedExtensionName = "VK_EXT_blend_operation_advanced";
        /// <summary>[from: <b>VK_NV_fragment_coverage_to_color</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_FRAGMENT_COVERAGE_TO_COLOR_SPEC_VERSION.html" /></remarks>
        public const uint NvFragmentCoverageToColorSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_fragment_coverage_to_color</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_FRAGMENT_COVERAGE_TO_COLOR_EXTENSION_NAME.html" /></remarks>
        public const string NvFragmentCoverageToColorExtensionName = "VK_NV_fragment_coverage_to_color";
        /// <summary>[from: <b>VK_KHR_acceleration_structure</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_ACCELERATION_STRUCTURE_SPEC_VERSION.html" /></remarks>
        public const uint KhrAccelerationStructureSpecVersion = 13;
        /// <summary>[from: <b>VK_KHR_acceleration_structure</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME.html" /></remarks>
        public const string KhrAccelerationStructureExtensionName = "VK_KHR_acceleration_structure";
        /// <summary>[from: <b>VK_KHR_ray_tracing_pipeline</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_RAY_TRACING_PIPELINE_SPEC_VERSION.html" /></remarks>
        public const uint KhrRayTracingPipelineSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_ray_tracing_pipeline</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME.html" /></remarks>
        public const string KhrRayTracingPipelineExtensionName = "VK_KHR_ray_tracing_pipeline";
        /// <summary>[from: <b>VK_KHR_ray_query</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_RAY_QUERY_SPEC_VERSION.html" /></remarks>
        public const uint KhrRayQuerySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_ray_query</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_RAY_QUERY_EXTENSION_NAME.html" /></remarks>
        public const string KhrRayQueryExtensionName = "VK_KHR_ray_query";
        /// <summary>[from: <b>VK_NV_framebuffer_mixed_samples</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_FRAMEBUFFER_MIXED_SAMPLES_SPEC_VERSION.html" /></remarks>
        public const uint NvFramebufferMixedSamplesSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_framebuffer_mixed_samples</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_FRAMEBUFFER_MIXED_SAMPLES_EXTENSION_NAME.html" /></remarks>
        public const string NvFramebufferMixedSamplesExtensionName = "VK_NV_framebuffer_mixed_samples";
        /// <summary>[from: <b>VK_NV_fill_rectangle</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_FILL_RECTANGLE_SPEC_VERSION.html" /></remarks>
        public const uint NvFillRectangleSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_fill_rectangle</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_FILL_RECTANGLE_EXTENSION_NAME.html" /></remarks>
        public const string NvFillRectangleExtensionName = "VK_NV_fill_rectangle";
        /// <summary>[from: <b>VK_NV_shader_sm_builtins</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SHADER_SM_BUILTINS_SPEC_VERSION.html" /></remarks>
        public const uint NvShaderSmBuiltinsSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_shader_sm_builtins</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SHADER_SM_BUILTINS_EXTENSION_NAME.html" /></remarks>
        public const string NvShaderSmBuiltinsExtensionName = "VK_NV_shader_sm_builtins";
        /// <summary>[from: <b>VK_EXT_post_depth_coverage</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_POST_DEPTH_COVERAGE_SPEC_VERSION.html" /></remarks>
        public const uint ExtPostDepthCoverageSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_post_depth_coverage</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME.html" /></remarks>
        public const string ExtPostDepthCoverageExtensionName = "VK_EXT_post_depth_coverage";
        /// <summary>[from: <b>VK_KHR_sampler_ycbcr_conversion</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SAMPLER_YCBCR_CONVERSION_SPEC_VERSION.html" /></remarks>
        public const uint KhrSamplerYcbcrConversionSpecVersion = 14;
        /// <summary>[from: <b>VK_KHR_sampler_ycbcr_conversion</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME.html" /></remarks>
        public const string KhrSamplerYcbcrConversionExtensionName = "VK_KHR_sampler_ycbcr_conversion";
        /// <summary>[from: <b>VK_KHR_bind_memory2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_BIND_MEMORY_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrBindMemory2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_bind_memory2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_BIND_MEMORY_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrBindMemory2ExtensionName = "VK_KHR_bind_memory2";
        /// <summary>[from: <b>VK_EXT_image_drm_format_modifier</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_SPEC_VERSION.html" /></remarks>
        public const uint ExtImageDrmFormatModifierSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_image_drm_format_modifier</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME.html" /></remarks>
        public const string ExtImageDrmFormatModifierExtensionName = "VK_EXT_image_drm_format_modifier";
        /// <summary>[from: <b>VK_EXT_validation_cache</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_VALIDATION_CACHE_SPEC_VERSION.html" /></remarks>
        public const uint ExtValidationCacheSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_validation_cache</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_VALIDATION_CACHE_EXTENSION_NAME.html" /></remarks>
        public const string ExtValidationCacheExtensionName = "VK_EXT_validation_cache";
        /// <summary>[from: <b>VK_EXT_descriptor_indexing</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DESCRIPTOR_INDEXING_SPEC_VERSION.html" /></remarks>
        public const uint ExtDescriptorIndexingSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_descriptor_indexing</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DESCRIPTOR_INDEXING_EXTENSION_NAME.html" /></remarks>
        public const string ExtDescriptorIndexingExtensionName = "VK_EXT_descriptor_indexing";
        /// <summary>[from: <b>VK_EXT_shader_viewport_index_layer</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderViewportIndexLayerSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_viewport_index_layer</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderViewportIndexLayerExtensionName = "VK_EXT_shader_viewport_index_layer";
        /// <summary>[from: <b>VK_KHR_portability_subset</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PORTABILITY_SUBSET_SPEC_VERSION.html" /></remarks>
        public const uint KhrPortabilitySubsetSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_portability_subset</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME.html" /></remarks>
        public const string KhrPortabilitySubsetExtensionName = "VK_KHR_portability_subset";
        /// <summary>[from: <b>VK_NV_shading_rate_image</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SHADING_RATE_IMAGE_SPEC_VERSION.html" /></remarks>
        public const uint NvShadingRateImageSpecVersion = 3;
        /// <summary>[from: <b>VK_NV_shading_rate_image</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME.html" /></remarks>
        public const string NvShadingRateImageExtensionName = "VK_NV_shading_rate_image";
        /// <summary>[from: <b>VK_NV_ray_tracing</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_RAY_TRACING_SPEC_VERSION.html" /></remarks>
        public const uint NvRayTracingSpecVersion = 3;
        /// <summary>[from: <b>VK_NV_ray_tracing</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_RAY_TRACING_EXTENSION_NAME.html" /></remarks>
        public const string NvRayTracingExtensionName = "VK_NV_ray_tracing";
        /// <summary>[from: <b>VK_NV_representative_fragment_test</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_REPRESENTATIVE_FRAGMENT_TEST_SPEC_VERSION.html" /></remarks>
        public const uint NvRepresentativeFragmentTestSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_representative_fragment_test</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_REPRESENTATIVE_FRAGMENT_TEST_EXTENSION_NAME.html" /></remarks>
        public const string NvRepresentativeFragmentTestExtensionName = "VK_NV_representative_fragment_test";
        /// <summary>[from: <b>VK_KHR_maintenance3</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_3_SPEC_VERSION.html" /></remarks>
        public const uint KhrMaintenance3SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_maintenance3</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_3_EXTENSION_NAME.html" /></remarks>
        public const string KhrMaintenance3ExtensionName = "VK_KHR_maintenance3";
        /// <summary>[from: <b>VK_KHR_draw_indirect_count</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DRAW_INDIRECT_COUNT_SPEC_VERSION.html" /></remarks>
        public const uint KhrDrawIndirectCountSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_draw_indirect_count</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME.html" /></remarks>
        public const string KhrDrawIndirectCountExtensionName = "VK_KHR_draw_indirect_count";
        /// <summary>[from: <b>VK_EXT_filter_cubic</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FILTER_CUBIC_SPEC_VERSION.html" /></remarks>
        public const uint ExtFilterCubicSpecVersion = 3;
        /// <summary>[from: <b>VK_EXT_filter_cubic</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FILTER_CUBIC_EXTENSION_NAME.html" /></remarks>
        public const string ExtFilterCubicExtensionName = "VK_EXT_filter_cubic";
        /// <summary>[from: <b>VK_QCOM_render_pass_shader_resolve</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_RENDER_PASS_SHADER_RESOLVE_SPEC_VERSION.html" /></remarks>
        public const uint QcomRenderPassShaderResolveSpecVersion = 4;
        /// <summary>[from: <b>VK_QCOM_render_pass_shader_resolve</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_RENDER_PASS_SHADER_RESOLVE_EXTENSION_NAME.html" /></remarks>
        public const string QcomRenderPassShaderResolveExtensionName = "VK_QCOM_render_pass_shader_resolve";
        /// <summary>[from: <b>VK_EXT_global_priority</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_GLOBAL_PRIORITY_SPEC_VERSION.html" /></remarks>
        public const uint ExtGlobalPrioritySpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_global_priority</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_GLOBAL_PRIORITY_EXTENSION_NAME.html" /></remarks>
        public const string ExtGlobalPriorityExtensionName = "VK_EXT_global_priority";
        /// <summary>[from: <b>VK_KHR_shader_subgroup_extended_types</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderSubgroupExtendedTypesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_subgroup_extended_types</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderSubgroupExtendedTypesExtensionName = "VK_KHR_shader_subgroup_extended_types";
        /// <summary>[from: <b>VK_KHR_8bit_storage</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_8BIT_STORAGE_SPEC_VERSION.html" /></remarks>
        public const uint Khr8bitStorageSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_8bit_storage</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_8BIT_STORAGE_EXTENSION_NAME.html" /></remarks>
        public const string Khr8bitStorageExtensionName = "VK_KHR_8bit_storage";
        /// <summary>[from: <b>VK_EXT_external_memory_host</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTERNAL_MEMORY_HOST_SPEC_VERSION.html" /></remarks>
        public const uint ExtExternalMemoryHostSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_external_memory_host</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME.html" /></remarks>
        public const string ExtExternalMemoryHostExtensionName = "VK_EXT_external_memory_host";
        /// <summary>[from: <b>VK_AMD_buffer_marker</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_BUFFER_MARKER_SPEC_VERSION.html" /></remarks>
        public const uint AmdBufferMarkerSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_buffer_marker</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_BUFFER_MARKER_EXTENSION_NAME.html" /></remarks>
        public const string AmdBufferMarkerExtensionName = "VK_AMD_buffer_marker";
        /// <summary>[from: <b>VK_KHR_shader_atomic_int64</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_ATOMIC_INT64_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderAtomicInt64SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_atomic_int64</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_ATOMIC_INT64_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderAtomicInt64ExtensionName = "VK_KHR_shader_atomic_int64";
        /// <summary>[from: <b>VK_KHR_shader_clock</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_CLOCK_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderClockSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_clock</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_CLOCK_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderClockExtensionName = "VK_KHR_shader_clock";
        /// <summary>[from: <b>VK_AMD_pipeline_compiler_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_PIPELINE_COMPILER_CONTROL_SPEC_VERSION.html" /></remarks>
        public const uint AmdPipelineCompilerControlSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_pipeline_compiler_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_PIPELINE_COMPILER_CONTROL_EXTENSION_NAME.html" /></remarks>
        public const string AmdPipelineCompilerControlExtensionName = "VK_AMD_pipeline_compiler_control";
        /// <summary>[from: <b>VK_EXT_calibrated_timestamps</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_CALIBRATED_TIMESTAMPS_SPEC_VERSION.html" /></remarks>
        public const uint ExtCalibratedTimestampsSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_calibrated_timestamps</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_CALIBRATED_TIMESTAMPS_EXTENSION_NAME.html" /></remarks>
        public const string ExtCalibratedTimestampsExtensionName = "VK_EXT_calibrated_timestamps";
        /// <summary>[from: <b>VK_AMD_shader_core_properties</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_CORE_PROPERTIES_SPEC_VERSION.html" /></remarks>
        public const uint AmdShaderCorePropertiesSpecVersion = 2;
        /// <summary>[from: <b>VK_AMD_shader_core_properties</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_CORE_PROPERTIES_EXTENSION_NAME.html" /></remarks>
        public const string AmdShaderCorePropertiesExtensionName = "VK_AMD_shader_core_properties";
        /// <summary>[from: <b>VK_KHR_video_decode_h265</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_DECODE_H265_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoDecodeH265SpecVersion = 8;
        /// <summary>[from: <b>VK_KHR_video_decode_h265</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_DECODE_H265_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoDecodeH265ExtensionName = "VK_KHR_video_decode_h265";
        /// <summary>[from: <b>VK_KHR_global_priority</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_GLOBAL_PRIORITY_SPEC_VERSION.html" /></remarks>
        public const uint KhrGlobalPrioritySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_global_priority</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_GLOBAL_PRIORITY_EXTENSION_NAME.html" /></remarks>
        public const string KhrGlobalPriorityExtensionName = "VK_KHR_global_priority";
        /// <summary>[from: <b>VK_AMD_memory_overallocation_behavior</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_SPEC_VERSION.html" /></remarks>
        public const uint AmdMemoryOverallocationBehaviorSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_memory_overallocation_behavior</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME.html" /></remarks>
        public const string AmdMemoryOverallocationBehaviorExtensionName = "VK_AMD_memory_overallocation_behavior";
        /// <summary>[from: <b>VK_EXT_vertex_attribute_divisor</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION.html" /></remarks>
        public const uint ExtVertexAttributeDivisorSpecVersion = 3;
        /// <summary>[from: <b>VK_EXT_vertex_attribute_divisor</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME.html" /></remarks>
        public const string ExtVertexAttributeDivisorExtensionName = "VK_EXT_vertex_attribute_divisor";
        /// <summary>[from: <b>VK_GGP_frame_token</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GGP_FRAME_TOKEN_SPEC_VERSION.html" /></remarks>
        public const uint GgpFrameTokenSpecVersion = 1;
        /// <summary>[from: <b>VK_GGP_frame_token</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GGP_FRAME_TOKEN_EXTENSION_NAME.html" /></remarks>
        public const string GgpFrameTokenExtensionName = "VK_GGP_frame_token";
        /// <summary>[from: <b>VK_EXT_pipeline_creation_feedback</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PIPELINE_CREATION_FEEDBACK_SPEC_VERSION.html" /></remarks>
        public const uint ExtPipelineCreationFeedbackSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_pipeline_creation_feedback</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PIPELINE_CREATION_FEEDBACK_EXTENSION_NAME.html" /></remarks>
        public const string ExtPipelineCreationFeedbackExtensionName = "VK_EXT_pipeline_creation_feedback";
        /// <summary>[from: <b>VK_KHR_driver_properties</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DRIVER_PROPERTIES_SPEC_VERSION.html" /></remarks>
        public const uint KhrDriverPropertiesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_driver_properties</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME.html" /></remarks>
        public const string KhrDriverPropertiesExtensionName = "VK_KHR_driver_properties";
        /// <summary>[from: <b>VK_KHR_shader_float_controls</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_FLOAT_CONTROLS_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderFloatControlsSpecVersion = 4;
        /// <summary>[from: <b>VK_KHR_shader_float_controls</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_FLOAT_CONTROLS_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderFloatControlsExtensionName = "VK_KHR_shader_float_controls";
        /// <summary>[from: <b>VK_NV_shader_subgroup_partitioned</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SHADER_SUBGROUP_PARTITIONED_SPEC_VERSION.html" /></remarks>
        public const uint NvShaderSubgroupPartitionedSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_shader_subgroup_partitioned</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SHADER_SUBGROUP_PARTITIONED_EXTENSION_NAME.html" /></remarks>
        public const string NvShaderSubgroupPartitionedExtensionName = "VK_NV_shader_subgroup_partitioned";
        /// <summary>[from: <b>VK_KHR_depth_stencil_resolve</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DEPTH_STENCIL_RESOLVE_SPEC_VERSION.html" /></remarks>
        public const uint KhrDepthStencilResolveSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_depth_stencil_resolve</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME.html" /></remarks>
        public const string KhrDepthStencilResolveExtensionName = "VK_KHR_depth_stencil_resolve";
        /// <summary>[from: <b>VK_KHR_swapchain_mutable_format</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_SPEC_VERSION.html" /></remarks>
        public const uint KhrSwapchainMutableFormatSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_swapchain_mutable_format</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME.html" /></remarks>
        public const string KhrSwapchainMutableFormatExtensionName = "VK_KHR_swapchain_mutable_format";
        /// <summary>[from: <b>VK_NV_compute_shader_derivatives</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION.html" /></remarks>
        public const uint NvComputeShaderDerivativesSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_compute_shader_derivatives</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME.html" /></remarks>
        public const string NvComputeShaderDerivativesExtensionName = "VK_NV_compute_shader_derivatives";
        /// <summary>[from: <b>VK_NV_mesh_shader</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_MESH_SHADER_SPEC_VERSION.html" /></remarks>
        public const uint NvMeshShaderSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_mesh_shader</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_MESH_SHADER_EXTENSION_NAME.html" /></remarks>
        public const string NvMeshShaderExtensionName = "VK_NV_mesh_shader";
        /// <summary>[from: <b>VK_NV_fragment_shader_barycentric</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION.html" /></remarks>
        public const uint NvFragmentShaderBarycentricSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_fragment_shader_barycentric</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME.html" /></remarks>
        public const string NvFragmentShaderBarycentricExtensionName = "VK_NV_fragment_shader_barycentric";
        /// <summary>[from: <b>VK_NV_shader_image_footprint</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SHADER_IMAGE_FOOTPRINT_SPEC_VERSION.html" /></remarks>
        public const uint NvShaderImageFootprintSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_shader_image_footprint</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SHADER_IMAGE_FOOTPRINT_EXTENSION_NAME.html" /></remarks>
        public const string NvShaderImageFootprintExtensionName = "VK_NV_shader_image_footprint";
        /// <summary>[from: <b>VK_NV_scissor_exclusive</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SCISSOR_EXCLUSIVE_SPEC_VERSION.html" /></remarks>
        public const uint NvScissorExclusiveSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_scissor_exclusive</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME.html" /></remarks>
        public const string NvScissorExclusiveExtensionName = "VK_NV_scissor_exclusive";
        /// <summary>[from: <b>VK_NV_device_diagnostic_checkpoints</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_SPEC_VERSION.html" /></remarks>
        public const uint NvDeviceDiagnosticCheckpointsSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_device_diagnostic_checkpoints</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME.html" /></remarks>
        public const string NvDeviceDiagnosticCheckpointsExtensionName = "VK_NV_device_diagnostic_checkpoints";
        /// <summary>[from: <b>VK_KHR_timeline_semaphore</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_TIMELINE_SEMAPHORE_SPEC_VERSION.html" /></remarks>
        public const uint KhrTimelineSemaphoreSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_timeline_semaphore</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_TIMELINE_SEMAPHORE_EXTENSION_NAME.html" /></remarks>
        public const string KhrTimelineSemaphoreExtensionName = "VK_KHR_timeline_semaphore";
        /// <summary>[from: <b>VK_INTEL_shader_integer_functions2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_SPEC_VERSION.html" /></remarks>
        public const uint IntelShaderIntegerFunctions2SpecVersion = 1;
        /// <summary>[from: <b>VK_INTEL_shader_integer_functions2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_EXTENSION_NAME.html" /></remarks>
        public const string IntelShaderIntegerFunctions2ExtensionName = "VK_INTEL_shader_integer_functions2";
        /// <summary>[from: <b>VK_INTEL_performance_query</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_INTEL_PERFORMANCE_QUERY_SPEC_VERSION.html" /></remarks>
        public const uint IntelPerformanceQuerySpecVersion = 2;
        /// <summary>[from: <b>VK_INTEL_performance_query</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME.html" /></remarks>
        public const string IntelPerformanceQueryExtensionName = "VK_INTEL_performance_query";
        /// <summary>[from: <b>VK_KHR_vulkan_memory_model</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VULKAN_MEMORY_MODEL_SPEC_VERSION.html" /></remarks>
        public const uint KhrVulkanMemoryModelSpecVersion = 3;
        /// <summary>[from: <b>VK_KHR_vulkan_memory_model</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VULKAN_MEMORY_MODEL_EXTENSION_NAME.html" /></remarks>
        public const string KhrVulkanMemoryModelExtensionName = "VK_KHR_vulkan_memory_model";
        /// <summary>[from: <b>VK_EXT_pci_bus_info</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PCI_BUS_INFO_SPEC_VERSION.html" /></remarks>
        public const uint ExtPciBusInfoSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_pci_bus_info</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PCI_BUS_INFO_EXTENSION_NAME.html" /></remarks>
        public const string ExtPciBusInfoExtensionName = "VK_EXT_pci_bus_info";
        /// <summary>[from: <b>VK_AMD_display_native_hdr</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_DISPLAY_NATIVE_HDR_SPEC_VERSION.html" /></remarks>
        public const uint AmdDisplayNativeHdrSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_display_native_hdr</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME.html" /></remarks>
        public const string AmdDisplayNativeHdrExtensionName = "VK_AMD_display_native_hdr";
        /// <summary>[from: <b>VK_FUCHSIA_imagepipe_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_IMAGEPIPE_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint FuchsiaImagepipeSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_FUCHSIA_imagepipe_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_IMAGEPIPE_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string FuchsiaImagepipeSurfaceExtensionName = "VK_FUCHSIA_imagepipe_surface";
        /// <summary>[from: <b>VK_KHR_shader_terminate_invocation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_TERMINATE_INVOCATION_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderTerminateInvocationSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_terminate_invocation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_TERMINATE_INVOCATION_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderTerminateInvocationExtensionName = "VK_KHR_shader_terminate_invocation";
        /// <summary>[from: <b>VK_EXT_metal_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_METAL_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint ExtMetalSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_metal_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_METAL_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string ExtMetalSurfaceExtensionName = "VK_EXT_metal_surface";
        /// <summary>[from: <b>VK_EXT_fragment_density_map</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FRAGMENT_DENSITY_MAP_SPEC_VERSION.html" /></remarks>
        public const uint ExtFragmentDensityMapSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_fragment_density_map</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FRAGMENT_DENSITY_MAP_EXTENSION_NAME.html" /></remarks>
        public const string ExtFragmentDensityMapExtensionName = "VK_EXT_fragment_density_map";
        /// <summary>[from: <b>VK_EXT_scalar_block_layout</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SCALAR_BLOCK_LAYOUT_SPEC_VERSION.html" /></remarks>
        public const uint ExtScalarBlockLayoutSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_scalar_block_layout</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SCALAR_BLOCK_LAYOUT_EXTENSION_NAME.html" /></remarks>
        public const string ExtScalarBlockLayoutExtensionName = "VK_EXT_scalar_block_layout";
        /// <summary>[from: <b>VK_GOOGLE_hlsl_functionality1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_HLSL_FUNCTIONALITY_1_SPEC_VERSION.html" /></remarks>
        public const uint GoogleHlslFunctionality1SpecVersion = 1;
        /// <summary>[from: <b>VK_GOOGLE_hlsl_functionality1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME.html" /></remarks>
        public const string GoogleHlslFunctionality1ExtensionName = "VK_GOOGLE_hlsl_functionality1";
        /// <summary>[from: <b>VK_GOOGLE_decorate_string</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_DECORATE_STRING_SPEC_VERSION.html" /></remarks>
        public const uint GoogleDecorateStringSpecVersion = 1;
        /// <summary>[from: <b>VK_GOOGLE_decorate_string</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME.html" /></remarks>
        public const string GoogleDecorateStringExtensionName = "VK_GOOGLE_decorate_string";
        /// <summary>[from: <b>VK_EXT_subgroup_size_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SUBGROUP_SIZE_CONTROL_SPEC_VERSION.html" /></remarks>
        public const uint ExtSubgroupSizeControlSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_subgroup_size_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SUBGROUP_SIZE_CONTROL_EXTENSION_NAME.html" /></remarks>
        public const string ExtSubgroupSizeControlExtensionName = "VK_EXT_subgroup_size_control";
        /// <summary>[from: <b>VK_KHR_fragment_shading_rate</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_FRAGMENT_SHADING_RATE_SPEC_VERSION.html" /></remarks>
        public const uint KhrFragmentShadingRateSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_fragment_shading_rate</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME.html" /></remarks>
        public const string KhrFragmentShadingRateExtensionName = "VK_KHR_fragment_shading_rate";
        /// <summary>[from: <b>VK_AMD_shader_core_properties2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_CORE_PROPERTIES_2_SPEC_VERSION.html" /></remarks>
        public const uint AmdShaderCoreProperties2SpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_core_properties2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_CORE_PROPERTIES_2_EXTENSION_NAME.html" /></remarks>
        public const string AmdShaderCoreProperties2ExtensionName = "VK_AMD_shader_core_properties2";
        /// <summary>[from: <b>VK_AMD_device_coherent_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_DEVICE_COHERENT_MEMORY_SPEC_VERSION.html" /></remarks>
        public const uint AmdDeviceCoherentMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_device_coherent_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME.html" /></remarks>
        public const string AmdDeviceCoherentMemoryExtensionName = "VK_AMD_device_coherent_memory";
        /// <summary>[from: <b>VK_KHR_dynamic_rendering_local_read</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DYNAMIC_RENDERING_LOCAL_READ_SPEC_VERSION.html" /></remarks>
        public const uint KhrDynamicRenderingLocalReadSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_dynamic_rendering_local_read</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DYNAMIC_RENDERING_LOCAL_READ_EXTENSION_NAME.html" /></remarks>
        public const string KhrDynamicRenderingLocalReadExtensionName = "VK_KHR_dynamic_rendering_local_read";
        /// <summary>[from: <b>VK_EXT_shader_image_atomic_int64</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_IMAGE_ATOMIC_INT64_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderImageAtomicInt64SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_image_atomic_int64</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_IMAGE_ATOMIC_INT64_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderImageAtomicInt64ExtensionName = "VK_EXT_shader_image_atomic_int64";
        /// <summary>[from: <b>VK_KHR_shader_quad_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_QUAD_CONTROL_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderQuadControlSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_quad_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_QUAD_CONTROL_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderQuadControlExtensionName = "VK_KHR_shader_quad_control";
        /// <summary>[from: <b>VK_KHR_spirv_1_4</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SPIRV_1_4_SPEC_VERSION.html" /></remarks>
        public const uint KhrSpirv14SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_spirv_1_4</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SPIRV_1_4_EXTENSION_NAME.html" /></remarks>
        public const string KhrSpirv14ExtensionName = "VK_KHR_spirv_1_4";
        /// <summary>[from: <b>VK_EXT_memory_budget</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MEMORY_BUDGET_SPEC_VERSION.html" /></remarks>
        public const uint ExtMemoryBudgetSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_memory_budget</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MEMORY_BUDGET_EXTENSION_NAME.html" /></remarks>
        public const string ExtMemoryBudgetExtensionName = "VK_EXT_memory_budget";
        /// <summary>[from: <b>VK_EXT_memory_priority</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MEMORY_PRIORITY_SPEC_VERSION.html" /></remarks>
        public const uint ExtMemoryPrioritySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_memory_priority</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MEMORY_PRIORITY_EXTENSION_NAME.html" /></remarks>
        public const string ExtMemoryPriorityExtensionName = "VK_EXT_memory_priority";
        /// <summary>[from: <b>VK_KHR_surface_protected_capabilities</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SURFACE_PROTECTED_CAPABILITIES_SPEC_VERSION.html" /></remarks>
        public const uint KhrSurfaceProtectedCapabilitiesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_surface_protected_capabilities</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME.html" /></remarks>
        public const string KhrSurfaceProtectedCapabilitiesExtensionName = "VK_KHR_surface_protected_capabilities";
        /// <summary>[from: <b>VK_NV_dedicated_allocation_image_aliasing</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_SPEC_VERSION.html" /></remarks>
        public const uint NvDedicatedAllocationImageAliasingSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_dedicated_allocation_image_aliasing</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME.html" /></remarks>
        public const string NvDedicatedAllocationImageAliasingExtensionName = "VK_NV_dedicated_allocation_image_aliasing";
        /// <summary>[from: <b>VK_KHR_separate_depth_stencil_layouts</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_SPEC_VERSION.html" /></remarks>
        public const uint KhrSeparateDepthStencilLayoutsSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_separate_depth_stencil_layouts</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_EXTENSION_NAME.html" /></remarks>
        public const string KhrSeparateDepthStencilLayoutsExtensionName = "VK_KHR_separate_depth_stencil_layouts";
        /// <summary>[from: <b>VK_EXT_buffer_device_address</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_BUFFER_DEVICE_ADDRESS_SPEC_VERSION.html" /></remarks>
        public const uint ExtBufferDeviceAddressSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_buffer_device_address</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME.html" /></remarks>
        public const string ExtBufferDeviceAddressExtensionName = "VK_EXT_buffer_device_address";
        /// <summary>[from: <b>VK_EXT_tooling_info</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_TOOLING_INFO_SPEC_VERSION.html" /></remarks>
        public const uint ExtToolingInfoSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_tooling_info</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_TOOLING_INFO_EXTENSION_NAME.html" /></remarks>
        public const string ExtToolingInfoExtensionName = "VK_EXT_tooling_info";
        /// <summary>[from: <b>VK_EXT_separate_stencil_usage</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SEPARATE_STENCIL_USAGE_SPEC_VERSION.html" /></remarks>
        public const uint ExtSeparateStencilUsageSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_separate_stencil_usage</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SEPARATE_STENCIL_USAGE_EXTENSION_NAME.html" /></remarks>
        public const string ExtSeparateStencilUsageExtensionName = "VK_EXT_separate_stencil_usage";
        /// <summary>[from: <b>VK_EXT_validation_features</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_VALIDATION_FEATURES_SPEC_VERSION.html" /></remarks>
        public const uint ExtValidationFeaturesSpecVersion = 6;
        /// <summary>[from: <b>VK_EXT_validation_features</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_VALIDATION_FEATURES_EXTENSION_NAME.html" /></remarks>
        public const string ExtValidationFeaturesExtensionName = "VK_EXT_validation_features";
        /// <summary>[from: <b>VK_KHR_present_wait</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PRESENT_WAIT_SPEC_VERSION.html" /></remarks>
        public const uint KhrPresentWaitSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_present_wait</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PRESENT_WAIT_EXTENSION_NAME.html" /></remarks>
        public const string KhrPresentWaitExtensionName = "VK_KHR_present_wait";
        /// <summary>[from: <b>VK_NV_cooperative_matrix</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COOPERATIVE_MATRIX_SPEC_VERSION.html" /></remarks>
        public const uint NvCooperativeMatrixSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_cooperative_matrix</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME.html" /></remarks>
        public const string NvCooperativeMatrixExtensionName = "VK_NV_cooperative_matrix";
        /// <summary>[from: <b>VK_NV_coverage_reduction_mode</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COVERAGE_REDUCTION_MODE_SPEC_VERSION.html" /></remarks>
        public const uint NvCoverageReductionModeSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_coverage_reduction_mode</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME.html" /></remarks>
        public const string NvCoverageReductionModeExtensionName = "VK_NV_coverage_reduction_mode";
        /// <summary>[from: <b>VK_EXT_fragment_shader_interlock</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FRAGMENT_SHADER_INTERLOCK_SPEC_VERSION.html" /></remarks>
        public const uint ExtFragmentShaderInterlockSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_fragment_shader_interlock</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FRAGMENT_SHADER_INTERLOCK_EXTENSION_NAME.html" /></remarks>
        public const string ExtFragmentShaderInterlockExtensionName = "VK_EXT_fragment_shader_interlock";
        /// <summary>[from: <b>VK_EXT_ycbcr_image_arrays</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_YCBCR_IMAGE_ARRAYS_SPEC_VERSION.html" /></remarks>
        public const uint ExtYcbcrImageArraysSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_ycbcr_image_arrays</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME.html" /></remarks>
        public const string ExtYcbcrImageArraysExtensionName = "VK_EXT_ycbcr_image_arrays";
        /// <summary>[from: <b>VK_KHR_uniform_buffer_standard_layout</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_SPEC_VERSION.html" /></remarks>
        public const uint KhrUniformBufferStandardLayoutSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_uniform_buffer_standard_layout</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME.html" /></remarks>
        public const string KhrUniformBufferStandardLayoutExtensionName = "VK_KHR_uniform_buffer_standard_layout";
        /// <summary>[from: <b>VK_EXT_provoking_vertex</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PROVOKING_VERTEX_SPEC_VERSION.html" /></remarks>
        public const uint ExtProvokingVertexSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_provoking_vertex</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PROVOKING_VERTEX_EXTENSION_NAME.html" /></remarks>
        public const string ExtProvokingVertexExtensionName = "VK_EXT_provoking_vertex";
        /// <summary>[from: <b>VK_EXT_full_screen_exclusive</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FULL_SCREEN_EXCLUSIVE_SPEC_VERSION.html" /></remarks>
        public const uint ExtFullScreenExclusiveSpecVersion = 4;
        /// <summary>[from: <b>VK_EXT_full_screen_exclusive</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME.html" /></remarks>
        public const string ExtFullScreenExclusiveExtensionName = "VK_EXT_full_screen_exclusive";
        /// <summary>[from: <b>VK_EXT_headless_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_HEADLESS_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint ExtHeadlessSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_headless_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_HEADLESS_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string ExtHeadlessSurfaceExtensionName = "VK_EXT_headless_surface";
        /// <summary>[from: <b>VK_KHR_buffer_device_address</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_BUFFER_DEVICE_ADDRESS_SPEC_VERSION.html" /></remarks>
        public const uint KhrBufferDeviceAddressSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_buffer_device_address</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME.html" /></remarks>
        public const string KhrBufferDeviceAddressExtensionName = "VK_KHR_buffer_device_address";
        /// <summary>[from: <b>VK_EXT_line_rasterization</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_LINE_RASTERIZATION_SPEC_VERSION.html" /></remarks>
        public const uint ExtLineRasterizationSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_line_rasterization</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_LINE_RASTERIZATION_EXTENSION_NAME.html" /></remarks>
        public const string ExtLineRasterizationExtensionName = "VK_EXT_line_rasterization";
        /// <summary>[from: <b>VK_EXT_shader_atomic_float</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_ATOMIC_FLOAT_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderAtomicFloatSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_atomic_float</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_ATOMIC_FLOAT_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderAtomicFloatExtensionName = "VK_EXT_shader_atomic_float";
        /// <summary>[from: <b>VK_EXT_host_query_reset</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_HOST_QUERY_RESET_SPEC_VERSION.html" /></remarks>
        public const uint ExtHostQueryResetSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_host_query_reset</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME.html" /></remarks>
        public const string ExtHostQueryResetExtensionName = "VK_EXT_host_query_reset";
        /// <summary>[from: <b>VK_EXT_index_type_uint8</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_INDEX_TYPE_UINT8_SPEC_VERSION.html" /></remarks>
        public const uint ExtIndexTypeUint8SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_index_type_uint8</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_INDEX_TYPE_UINT8_EXTENSION_NAME.html" /></remarks>
        public const string ExtIndexTypeUint8ExtensionName = "VK_EXT_index_type_uint8";
        /// <summary>[from: <b>VK_EXT_extended_dynamic_state</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTENDED_DYNAMIC_STATE_SPEC_VERSION.html" /></remarks>
        public const uint ExtExtendedDynamicStateSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_extended_dynamic_state</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME.html" /></remarks>
        public const string ExtExtendedDynamicStateExtensionName = "VK_EXT_extended_dynamic_state";
        /// <summary>[from: <b>VK_KHR_deferred_host_operations</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DEFERRED_HOST_OPERATIONS_SPEC_VERSION.html" /></remarks>
        public const uint KhrDeferredHostOperationsSpecVersion = 4;
        /// <summary>[from: <b>VK_KHR_deferred_host_operations</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME.html" /></remarks>
        public const string KhrDeferredHostOperationsExtensionName = "VK_KHR_deferred_host_operations";
        /// <summary>[from: <b>VK_KHR_pipeline_executable_properties</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION.html" /></remarks>
        public const uint KhrPipelineExecutablePropertiesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_pipeline_executable_properties</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME.html" /></remarks>
        public const string KhrPipelineExecutablePropertiesExtensionName = "VK_KHR_pipeline_executable_properties";
        /// <summary>[from: <b>VK_EXT_host_image_copy</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_HOST_IMAGE_COPY_SPEC_VERSION.html" /></remarks>
        public const uint ExtHostImageCopySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_host_image_copy</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_HOST_IMAGE_COPY_EXTENSION_NAME.html" /></remarks>
        public const string ExtHostImageCopyExtensionName = "VK_EXT_host_image_copy";
        /// <summary>[from: <b>VK_KHR_map_memory2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAP_MEMORY_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrMapMemory2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_map_memory2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAP_MEMORY_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrMapMemory2ExtensionName = "VK_KHR_map_memory2";
        /// <summary>[from: <b>VK_EXT_map_memory_placed</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MAP_MEMORY_PLACED_SPEC_VERSION.html" /></remarks>
        public const uint ExtMapMemoryPlacedSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_map_memory_placed</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MAP_MEMORY_PLACED_EXTENSION_NAME.html" /></remarks>
        public const string ExtMapMemoryPlacedExtensionName = "VK_EXT_map_memory_placed";
        /// <summary>[from: <b>VK_EXT_shader_atomic_float2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_ATOMIC_FLOAT_2_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderAtomicFloat2SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_atomic_float2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_ATOMIC_FLOAT_2_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderAtomicFloat2ExtensionName = "VK_EXT_shader_atomic_float2";
        /// <summary>[from: <b>VK_EXT_surface_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SURFACE_MAINTENANCE_1_SPEC_VERSION.html" /></remarks>
        public const uint ExtSurfaceMaintenance1SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_surface_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SURFACE_MAINTENANCE_1_EXTENSION_NAME.html" /></remarks>
        public const string ExtSurfaceMaintenance1ExtensionName = "VK_EXT_surface_maintenance1";
        /// <summary>[from: <b>VK_EXT_swapchain_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SWAPCHAIN_MAINTENANCE_1_SPEC_VERSION.html" /></remarks>
        public const uint ExtSwapchainMaintenance1SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_swapchain_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SWAPCHAIN_MAINTENANCE_1_EXTENSION_NAME.html" /></remarks>
        public const string ExtSwapchainMaintenance1ExtensionName = "VK_EXT_swapchain_maintenance1";
        /// <summary>[from: <b>VK_EXT_shader_demote_to_helper_invocation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderDemoteToHelperInvocationSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_demote_to_helper_invocation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderDemoteToHelperInvocationExtensionName = "VK_EXT_shader_demote_to_helper_invocation";
        /// <summary>[from: <b>VK_NV_device_generated_commands</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DEVICE_GENERATED_COMMANDS_SPEC_VERSION.html" /></remarks>
        public const uint NvDeviceGeneratedCommandsSpecVersion = 3;
        /// <summary>[from: <b>VK_NV_device_generated_commands</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME.html" /></remarks>
        public const string NvDeviceGeneratedCommandsExtensionName = "VK_NV_device_generated_commands";
        /// <summary>[from: <b>VK_NV_inherited_viewport_scissor</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_INHERITED_VIEWPORT_SCISSOR_SPEC_VERSION.html" /></remarks>
        public const uint NvInheritedViewportScissorSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_inherited_viewport_scissor</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_INHERITED_VIEWPORT_SCISSOR_EXTENSION_NAME.html" /></remarks>
        public const string NvInheritedViewportScissorExtensionName = "VK_NV_inherited_viewport_scissor";
        /// <summary>[from: <b>VK_KHR_shader_integer_dot_product</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_INTEGER_DOT_PRODUCT_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderIntegerDotProductSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_integer_dot_product</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_INTEGER_DOT_PRODUCT_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderIntegerDotProductExtensionName = "VK_KHR_shader_integer_dot_product";
        /// <summary>[from: <b>VK_EXT_texel_buffer_alignment</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_TEXEL_BUFFER_ALIGNMENT_SPEC_VERSION.html" /></remarks>
        public const uint ExtTexelBufferAlignmentSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_texel_buffer_alignment</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_TEXEL_BUFFER_ALIGNMENT_EXTENSION_NAME.html" /></remarks>
        public const string ExtTexelBufferAlignmentExtensionName = "VK_EXT_texel_buffer_alignment";
        /// <summary>[from: <b>VK_QCOM_render_pass_transform</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_RENDER_PASS_TRANSFORM_SPEC_VERSION.html" /></remarks>
        public const uint QcomRenderPassTransformSpecVersion = 5;
        /// <summary>[from: <b>VK_QCOM_render_pass_transform</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_RENDER_PASS_TRANSFORM_EXTENSION_NAME.html" /></remarks>
        public const string QcomRenderPassTransformExtensionName = "VK_QCOM_render_pass_transform";
        /// <summary>[from: <b>VK_EXT_depth_bias_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEPTH_BIAS_CONTROL_SPEC_VERSION.html" /></remarks>
        public const uint ExtDepthBiasControlSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_depth_bias_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEPTH_BIAS_CONTROL_EXTENSION_NAME.html" /></remarks>
        public const string ExtDepthBiasControlExtensionName = "VK_EXT_depth_bias_control";
        /// <summary>[from: <b>VK_EXT_device_memory_report</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEVICE_MEMORY_REPORT_SPEC_VERSION.html" /></remarks>
        public const uint ExtDeviceMemoryReportSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_device_memory_report</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEVICE_MEMORY_REPORT_EXTENSION_NAME.html" /></remarks>
        public const string ExtDeviceMemoryReportExtensionName = "VK_EXT_device_memory_report";
        /// <summary>[from: <b>VK_EXT_acquire_drm_display</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ACQUIRE_DRM_DISPLAY_SPEC_VERSION.html" /></remarks>
        public const uint ExtAcquireDrmDisplaySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_acquire_drm_display</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME.html" /></remarks>
        public const string ExtAcquireDrmDisplayExtensionName = "VK_EXT_acquire_drm_display";
        /// <summary>[from: <b>VK_EXT_robustness2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ROBUSTNESS_2_SPEC_VERSION.html" /></remarks>
        public const uint ExtRobustness2SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_robustness2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ROBUSTNESS_2_EXTENSION_NAME.html" /></remarks>
        public const string ExtRobustness2ExtensionName = "VK_EXT_robustness2";
        /// <summary>[from: <b>VK_EXT_custom_border_color</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_CUSTOM_BORDER_COLOR_SPEC_VERSION.html" /></remarks>
        public const uint ExtCustomBorderColorSpecVersion = 12;
        /// <summary>[from: <b>VK_EXT_custom_border_color</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME.html" /></remarks>
        public const string ExtCustomBorderColorExtensionName = "VK_EXT_custom_border_color";
        /// <summary>[from: <b>VK_GOOGLE_user_type</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_USER_TYPE_SPEC_VERSION.html" /></remarks>
        public const uint GoogleUserTypeSpecVersion = 1;
        /// <summary>[from: <b>VK_GOOGLE_user_type</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_USER_TYPE_EXTENSION_NAME.html" /></remarks>
        public const string GoogleUserTypeExtensionName = "VK_GOOGLE_user_type";
        /// <summary>[from: <b>VK_KHR_pipeline_library</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PIPELINE_LIBRARY_SPEC_VERSION.html" /></remarks>
        public const uint KhrPipelineLibrarySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_pipeline_library</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PIPELINE_LIBRARY_EXTENSION_NAME.html" /></remarks>
        public const string KhrPipelineLibraryExtensionName = "VK_KHR_pipeline_library";
        /// <summary>[from: <b>VK_NV_present_barrier</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_PRESENT_BARRIER_SPEC_VERSION.html" /></remarks>
        public const uint NvPresentBarrierSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_present_barrier</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_PRESENT_BARRIER_EXTENSION_NAME.html" /></remarks>
        public const string NvPresentBarrierExtensionName = "VK_NV_present_barrier";
        /// <summary>[from: <b>VK_KHR_shader_non_semantic_info</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderNonSemanticInfoSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_non_semantic_info</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderNonSemanticInfoExtensionName = "VK_KHR_shader_non_semantic_info";
        /// <summary>[from: <b>VK_KHR_present_id</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PRESENT_ID_SPEC_VERSION.html" /></remarks>
        public const uint KhrPresentIdSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_present_id</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PRESENT_ID_EXTENSION_NAME.html" /></remarks>
        public const string KhrPresentIdExtensionName = "VK_KHR_present_id";
        /// <summary>[from: <b>VK_EXT_private_data</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PRIVATE_DATA_SPEC_VERSION.html" /></remarks>
        public const uint ExtPrivateDataSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_private_data</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PRIVATE_DATA_EXTENSION_NAME.html" /></remarks>
        public const string ExtPrivateDataExtensionName = "VK_EXT_private_data";
        /// <summary>[from: <b>VK_EXT_pipeline_creation_cache_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_SPEC_VERSION.html" /></remarks>
        public const uint ExtPipelineCreationCacheControlSpecVersion = 3;
        /// <summary>[from: <b>VK_EXT_pipeline_creation_cache_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME.html" /></remarks>
        public const string ExtPipelineCreationCacheControlExtensionName = "VK_EXT_pipeline_creation_cache_control";
        /// <summary>[from: <b>VK_KHR_video_encode_queue</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_ENCODE_QUEUE_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoEncodeQueueSpecVersion = 12;
        /// <summary>[from: <b>VK_KHR_video_encode_queue</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoEncodeQueueExtensionName = "VK_KHR_video_encode_queue";
        /// <summary>[from: <b>VK_NV_device_diagnostics_config</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DEVICE_DIAGNOSTICS_CONFIG_SPEC_VERSION.html" /></remarks>
        public const uint NvDeviceDiagnosticsConfigSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_device_diagnostics_config</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME.html" /></remarks>
        public const string NvDeviceDiagnosticsConfigExtensionName = "VK_NV_device_diagnostics_config";
        /// <summary>[from: <b>VK_QCOM_render_pass_store_ops</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_RENDER_PASS_STORE_OPS_SPEC_VERSION.html" /></remarks>
        public const uint QcomRenderPassStoreOpsSpecVersion = 2;
        /// <summary>[from: <b>VK_QCOM_render_pass_store_ops</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME.html" /></remarks>
        public const string QcomRenderPassStoreOpsExtensionName = "VK_QCOM_render_pass_store_ops";
        /// <summary>[from: <b>VK_NV_cuda_kernel_launch</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_CUDA_KERNEL_LAUNCH_SPEC_VERSION.html" /></remarks>
        public const uint NvCudaKernelLaunchSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_cuda_kernel_launch</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_CUDA_KERNEL_LAUNCH_EXTENSION_NAME.html" /></remarks>
        public const string NvCudaKernelLaunchExtensionName = "VK_NV_cuda_kernel_launch";
        /// <summary>[from: <b>VK_KHR_object_refresh</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_OBJECT_REFRESH_SPEC_VERSION.html" /></remarks>
        public const uint KhrObjectRefreshSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_object_refresh</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_OBJECT_REFRESH_EXTENSION_NAME.html" /></remarks>
        public const string KhrObjectRefreshExtensionName = "VK_KHR_object_refresh";
        /// <summary>[from: <b>VK_QCOM_tile_shading</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_TILE_SHADING_SPEC_VERSION.html" /></remarks>
        public const uint QcomTileShadingSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_tile_shading</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_TILE_SHADING_EXTENSION_NAME.html" /></remarks>
        public const string QcomTileShadingExtensionName = "VK_QCOM_tile_shading";
        /// <summary>[from: <b>VK_NV_low_latency</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_LOW_LATENCY_SPEC_VERSION.html" /></remarks>
        public const uint NvLowLatencySpecVersion = 1;
        /// <summary>[from: <b>VK_NV_low_latency</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_LOW_LATENCY_EXTENSION_NAME.html" /></remarks>
        public const string NvLowLatencyExtensionName = "VK_NV_low_latency";
        /// <summary>[from: <b>VK_EXT_metal_objects</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_METAL_OBJECTS_SPEC_VERSION.html" /></remarks>
        public const uint ExtMetalObjectsSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_metal_objects</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_METAL_OBJECTS_EXTENSION_NAME.html" /></remarks>
        public const string ExtMetalObjectsExtensionName = "VK_EXT_metal_objects";
        /// <summary>[from: <b>VK_KHR_synchronization2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SYNCHRONIZATION_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrSynchronization2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_synchronization2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrSynchronization2ExtensionName = "VK_KHR_synchronization2";
        /// <summary>[from: <b>VK_EXT_descriptor_buffer</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DESCRIPTOR_BUFFER_SPEC_VERSION.html" /></remarks>
        public const uint ExtDescriptorBufferSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_descriptor_buffer</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DESCRIPTOR_BUFFER_EXTENSION_NAME.html" /></remarks>
        public const string ExtDescriptorBufferExtensionName = "VK_EXT_descriptor_buffer";
        /// <summary>[from: <b>VK_EXT_graphics_pipeline_library</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_GRAPHICS_PIPELINE_LIBRARY_SPEC_VERSION.html" /></remarks>
        public const uint ExtGraphicsPipelineLibrarySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_graphics_pipeline_library</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_GRAPHICS_PIPELINE_LIBRARY_EXTENSION_NAME.html" /></remarks>
        public const string ExtGraphicsPipelineLibraryExtensionName = "VK_EXT_graphics_pipeline_library";
        /// <summary>[from: <b>VK_AMD_shader_early_and_late_fragment_tests</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_SPEC_VERSION.html" /></remarks>
        public const uint AmdShaderEarlyAndLateFragmentTestsSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_early_and_late_fragment_tests</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_EXTENSION_NAME.html" /></remarks>
        public const string AmdShaderEarlyAndLateFragmentTestsExtensionName = "VK_AMD_shader_early_and_late_fragment_tests";
        /// <summary>[from: <b>VK_KHR_fragment_shader_barycentric</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION.html" /></remarks>
        public const uint KhrFragmentShaderBarycentricSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_fragment_shader_barycentric</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME.html" /></remarks>
        public const string KhrFragmentShaderBarycentricExtensionName = "VK_KHR_fragment_shader_barycentric";
        /// <summary>[from: <b>VK_KHR_shader_subgroup_uniform_control_flow</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderSubgroupUniformControlFlowSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_subgroup_uniform_control_flow</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderSubgroupUniformControlFlowExtensionName = "VK_KHR_shader_subgroup_uniform_control_flow";
        /// <summary>[from: <b>VK_KHR_zero_initialize_workgroup_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_SPEC_VERSION.html" /></remarks>
        public const uint KhrZeroInitializeWorkgroupMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_zero_initialize_workgroup_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME.html" /></remarks>
        public const string KhrZeroInitializeWorkgroupMemoryExtensionName = "VK_KHR_zero_initialize_workgroup_memory";
        /// <summary>[from: <b>VK_NV_fragment_shading_rate_enums</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_FRAGMENT_SHADING_RATE_ENUMS_SPEC_VERSION.html" /></remarks>
        public const uint NvFragmentShadingRateEnumsSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_fragment_shading_rate_enums</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME.html" /></remarks>
        public const string NvFragmentShadingRateEnumsExtensionName = "VK_NV_fragment_shading_rate_enums";
        /// <summary>[from: <b>VK_NV_ray_tracing_motion_blur</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_RAY_TRACING_MOTION_BLUR_SPEC_VERSION.html" /></remarks>
        public const uint NvRayTracingMotionBlurSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_ray_tracing_motion_blur</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_RAY_TRACING_MOTION_BLUR_EXTENSION_NAME.html" /></remarks>
        public const string NvRayTracingMotionBlurExtensionName = "VK_NV_ray_tracing_motion_blur";
        /// <summary>[from: <b>VK_EXT_mesh_shader</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MESH_SHADER_SPEC_VERSION.html" /></remarks>
        public const uint ExtMeshShaderSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_mesh_shader</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MESH_SHADER_EXTENSION_NAME.html" /></remarks>
        public const string ExtMeshShaderExtensionName = "VK_EXT_mesh_shader";
        /// <summary>[from: <b>VK_EXT_ycbcr_2plane_444_formats</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_YCBCR_2PLANE_444_FORMATS_SPEC_VERSION.html" /></remarks>
        public const uint ExtYcbcr2plane444FormatsSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_ycbcr_2plane_444_formats</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_YCBCR_2PLANE_444_FORMATS_EXTENSION_NAME.html" /></remarks>
        public const string ExtYcbcr2plane444FormatsExtensionName = "VK_EXT_ycbcr_2plane_444_formats";
        /// <summary>[from: <b>VK_EXT_fragment_density_map2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION.html" /></remarks>
        public const uint ExtFragmentDensityMap2SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_fragment_density_map2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME.html" /></remarks>
        public const string ExtFragmentDensityMap2ExtensionName = "VK_EXT_fragment_density_map2";
        /// <summary>[from: <b>VK_QCOM_rotated_copy_commands</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_ROTATED_COPY_COMMANDS_SPEC_VERSION.html" /></remarks>
        public const uint QcomRotatedCopyCommandsSpecVersion = 2;
        /// <summary>[from: <b>VK_QCOM_rotated_copy_commands</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME.html" /></remarks>
        public const string QcomRotatedCopyCommandsExtensionName = "VK_QCOM_rotated_copy_commands";
        /// <summary>[from: <b>VK_EXT_image_robustness</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_ROBUSTNESS_SPEC_VERSION.html" /></remarks>
        public const uint ExtImageRobustnessSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_image_robustness</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_ROBUSTNESS_EXTENSION_NAME.html" /></remarks>
        public const string ExtImageRobustnessExtensionName = "VK_EXT_image_robustness";
        /// <summary>[from: <b>VK_KHR_workgroup_memory_explicit_layout</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_SPEC_VERSION.html" /></remarks>
        public const uint KhrWorkgroupMemoryExplicitLayoutSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_workgroup_memory_explicit_layout</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_EXTENSION_NAME.html" /></remarks>
        public const string KhrWorkgroupMemoryExplicitLayoutExtensionName = "VK_KHR_workgroup_memory_explicit_layout";
        /// <summary>[from: <b>VK_KHR_copy_commands2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_COPY_COMMANDS_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrCopyCommands2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_copy_commands2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrCopyCommands2ExtensionName = "VK_KHR_copy_commands2";
        /// <summary>[from: <b>VK_EXT_image_compression_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_COMPRESSION_CONTROL_SPEC_VERSION.html" /></remarks>
        public const uint ExtImageCompressionControlSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_image_compression_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_COMPRESSION_CONTROL_EXTENSION_NAME.html" /></remarks>
        public const string ExtImageCompressionControlExtensionName = "VK_EXT_image_compression_control";
        /// <summary>[from: <b>VK_EXT_attachment_feedback_loop_layout</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_SPEC_VERSION.html" /></remarks>
        public const uint ExtAttachmentFeedbackLoopLayoutSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_attachment_feedback_loop_layout</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_EXTENSION_NAME.html" /></remarks>
        public const string ExtAttachmentFeedbackLoopLayoutExtensionName = "VK_EXT_attachment_feedback_loop_layout";
        /// <summary>[from: <b>VK_EXT_4444_formats</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_4444_FORMATS_SPEC_VERSION.html" /></remarks>
        public const uint Ext4444FormatsSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_4444_formats</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_4444_FORMATS_EXTENSION_NAME.html" /></remarks>
        public const string Ext4444FormatsExtensionName = "VK_EXT_4444_formats";
        /// <summary>[from: <b>VK_EXT_device_fault</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEVICE_FAULT_SPEC_VERSION.html" /></remarks>
        public const uint ExtDeviceFaultSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_device_fault</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEVICE_FAULT_EXTENSION_NAME.html" /></remarks>
        public const string ExtDeviceFaultExtensionName = "VK_EXT_device_fault";
        /// <summary>[from: <b>VK_ARM_rasterization_order_attachment_access</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_SPEC_VERSION.html" /></remarks>
        public const uint ArmRasterizationOrderAttachmentAccessSpecVersion = 1;
        /// <summary>[from: <b>VK_ARM_rasterization_order_attachment_access</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_EXTENSION_NAME.html" /></remarks>
        public const string ArmRasterizationOrderAttachmentAccessExtensionName = "VK_ARM_rasterization_order_attachment_access";
        /// <summary>[from: <b>VK_EXT_rgba10x6_formats</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_RGBA10X6_FORMATS_SPEC_VERSION.html" /></remarks>
        public const uint ExtRgba10x6FormatsSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_rgba10x6_formats</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_RGBA10X6_FORMATS_EXTENSION_NAME.html" /></remarks>
        public const string ExtRgba10x6FormatsExtensionName = "VK_EXT_rgba10x6_formats";
        /// <summary>[from: <b>VK_NV_acquire_winrt_display</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_ACQUIRE_WINRT_DISPLAY_SPEC_VERSION.html" /></remarks>
        public const uint NvAcquireWinrtDisplaySpecVersion = 1;
        /// <summary>[from: <b>VK_NV_acquire_winrt_display</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME.html" /></remarks>
        public const string NvAcquireWinrtDisplayExtensionName = "VK_NV_acquire_winrt_display";
        /// <summary>[from: <b>VK_EXT_directfb_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DIRECTFB_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint ExtDirectfbSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_directfb_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DIRECTFB_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string ExtDirectfbSurfaceExtensionName = "VK_EXT_directfb_surface";
        /// <summary>[from: <b>VK_VALVE_mutable_descriptor_type</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION.html" /></remarks>
        public const uint ValveMutableDescriptorTypeSpecVersion = 1;
        /// <summary>[from: <b>VK_VALVE_mutable_descriptor_type</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME.html" /></remarks>
        public const string ValveMutableDescriptorTypeExtensionName = "VK_VALVE_mutable_descriptor_type";
        /// <summary>[from: <b>VK_EXT_vertex_input_dynamic_state</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_SPEC_VERSION.html" /></remarks>
        public const uint ExtVertexInputDynamicStateSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_vertex_input_dynamic_state</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME.html" /></remarks>
        public const string ExtVertexInputDynamicStateExtensionName = "VK_EXT_vertex_input_dynamic_state";
        /// <summary>[from: <b>VK_EXT_physical_device_drm</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PHYSICAL_DEVICE_DRM_SPEC_VERSION.html" /></remarks>
        public const uint ExtPhysicalDeviceDrmSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_physical_device_drm</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PHYSICAL_DEVICE_DRM_EXTENSION_NAME.html" /></remarks>
        public const string ExtPhysicalDeviceDrmExtensionName = "VK_EXT_physical_device_drm";
        /// <summary>[from: <b>VK_EXT_device_address_binding_report</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEVICE_ADDRESS_BINDING_REPORT_SPEC_VERSION.html" /></remarks>
        public const uint ExtDeviceAddressBindingReportSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_device_address_binding_report</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEVICE_ADDRESS_BINDING_REPORT_EXTENSION_NAME.html" /></remarks>
        public const string ExtDeviceAddressBindingReportExtensionName = "VK_EXT_device_address_binding_report";
        /// <summary>[from: <b>VK_EXT_depth_clip_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEPTH_CLIP_CONTROL_SPEC_VERSION.html" /></remarks>
        public const uint ExtDepthClipControlSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_depth_clip_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEPTH_CLIP_CONTROL_EXTENSION_NAME.html" /></remarks>
        public const string ExtDepthClipControlExtensionName = "VK_EXT_depth_clip_control";
        /// <summary>[from: <b>VK_EXT_primitive_topology_list_restart</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_SPEC_VERSION.html" /></remarks>
        public const uint ExtPrimitiveTopologyListRestartSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_primitive_topology_list_restart</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_EXTENSION_NAME.html" /></remarks>
        public const string ExtPrimitiveTopologyListRestartExtensionName = "VK_EXT_primitive_topology_list_restart";
        /// <summary>[from: <b>VK_KHR_format_feature_flags2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_FORMAT_FEATURE_FLAGS_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrFormatFeatureFlags2SpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_format_feature_flags2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_FORMAT_FEATURE_FLAGS_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrFormatFeatureFlags2ExtensionName = "VK_KHR_format_feature_flags2";
        /// <summary>[from: <b>VK_EXT_present_mode_fifo_latest_ready</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PRESENT_MODE_FIFO_LATEST_READY_SPEC_VERSION.html" /></remarks>
        public const uint ExtPresentModeFifoLatestReadySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_present_mode_fifo_latest_ready</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PRESENT_MODE_FIFO_LATEST_READY_EXTENSION_NAME.html" /></remarks>
        public const string ExtPresentModeFifoLatestReadyExtensionName = "VK_EXT_present_mode_fifo_latest_ready";
        /// <summary>[from: <b>VK_FUCHSIA_external_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_EXTERNAL_MEMORY_SPEC_VERSION.html" /></remarks>
        public const uint FuchsiaExternalMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_FUCHSIA_external_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_EXTERNAL_MEMORY_EXTENSION_NAME.html" /></remarks>
        public const string FuchsiaExternalMemoryExtensionName = "VK_FUCHSIA_external_memory";
        /// <summary>[from: <b>VK_FUCHSIA_external_semaphore</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_EXTERNAL_SEMAPHORE_SPEC_VERSION.html" /></remarks>
        public const uint FuchsiaExternalSemaphoreSpecVersion = 1;
        /// <summary>[from: <b>VK_FUCHSIA_external_semaphore</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_EXTERNAL_SEMAPHORE_EXTENSION_NAME.html" /></remarks>
        public const string FuchsiaExternalSemaphoreExtensionName = "VK_FUCHSIA_external_semaphore";
        /// <summary>[from: <b>VK_FUCHSIA_buffer_collection</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_BUFFER_COLLECTION_SPEC_VERSION.html" /></remarks>
        public const uint FuchsiaBufferCollectionSpecVersion = 2;
        /// <summary>[from: <b>VK_FUCHSIA_buffer_collection</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_FUCHSIA_BUFFER_COLLECTION_EXTENSION_NAME.html" /></remarks>
        public const string FuchsiaBufferCollectionExtensionName = "VK_FUCHSIA_buffer_collection";
        /// <summary>[from: <b>VK_HUAWEI_subpass_shading</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_SUBPASS_SHADING_SPEC_VERSION.html" /></remarks>
        public const uint HuaweiSubpassShadingSpecVersion = 3;
        /// <summary>[from: <b>VK_HUAWEI_subpass_shading</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME.html" /></remarks>
        public const string HuaweiSubpassShadingExtensionName = "VK_HUAWEI_subpass_shading";
        /// <summary>[from: <b>VK_HUAWEI_invocation_mask</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_INVOCATION_MASK_SPEC_VERSION.html" /></remarks>
        public const uint HuaweiInvocationMaskSpecVersion = 1;
        /// <summary>[from: <b>VK_HUAWEI_invocation_mask</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_INVOCATION_MASK_EXTENSION_NAME.html" /></remarks>
        public const string HuaweiInvocationMaskExtensionName = "VK_HUAWEI_invocation_mask";
        /// <summary>[from: <b>VK_NV_external_memory_rdma</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_MEMORY_RDMA_SPEC_VERSION.html" /></remarks>
        public const uint NvExternalMemoryRdmaSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_external_memory_rdma</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME.html" /></remarks>
        public const string NvExternalMemoryRdmaExtensionName = "VK_NV_external_memory_rdma";
        /// <summary>[from: <b>VK_EXT_pipeline_properties</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PIPELINE_PROPERTIES_SPEC_VERSION.html" /></remarks>
        public const uint ExtPipelinePropertiesSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_pipeline_properties</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PIPELINE_PROPERTIES_EXTENSION_NAME.html" /></remarks>
        public const string ExtPipelinePropertiesExtensionName = "VK_EXT_pipeline_properties";
        /// <summary>[from: <b>VK_NV_external_sci_sync</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_SCI_SYNC_SPEC_VERSION.html" /></remarks>
        public const uint NvExternalSciSyncSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_external_sci_sync</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_SCI_SYNC_EXTENSION_NAME.html" /></remarks>
        public const string NvExternalSciSyncExtensionName = "VK_NV_external_sci_sync";
        /// <summary>[from: <b>VK_NV_external_memory_sci_buf</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_MEMORY_SCI_BUF_SPEC_VERSION.html" /></remarks>
        public const uint NvExternalMemorySciBufSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_external_memory_sci_buf</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_MEMORY_SCI_BUF_EXTENSION_NAME.html" /></remarks>
        public const string NvExternalMemorySciBufExtensionName = "VK_NV_external_memory_sci_buf";
        /// <summary>[from: <b>VK_EXT_frame_boundary</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FRAME_BOUNDARY_SPEC_VERSION.html" /></remarks>
        public const uint ExtFrameBoundarySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_frame_boundary</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FRAME_BOUNDARY_EXTENSION_NAME.html" /></remarks>
        public const string ExtFrameBoundaryExtensionName = "VK_EXT_frame_boundary";
        /// <summary>[from: <b>VK_EXT_multisampled_render_to_single_sampled</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_SPEC_VERSION.html" /></remarks>
        public const uint ExtMultisampledRenderToSingleSampledSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_multisampled_render_to_single_sampled</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_EXTENSION_NAME.html" /></remarks>
        public const string ExtMultisampledRenderToSingleSampledExtensionName = "VK_EXT_multisampled_render_to_single_sampled";
        /// <summary>[from: <b>VK_EXT_extended_dynamic_state2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTENDED_DYNAMIC_STATE_2_SPEC_VERSION.html" /></remarks>
        public const uint ExtExtendedDynamicState2SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_extended_dynamic_state2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME.html" /></remarks>
        public const string ExtExtendedDynamicState2ExtensionName = "VK_EXT_extended_dynamic_state2";
        /// <summary>[from: <b>VK_QNX_screen_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QNX_SCREEN_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint QnxScreenSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_QNX_screen_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QNX_SCREEN_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string QnxScreenSurfaceExtensionName = "VK_QNX_screen_surface";
        /// <summary>[from: <b>VK_EXT_color_write_enable</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_COLOR_WRITE_ENABLE_SPEC_VERSION.html" /></remarks>
        public const uint ExtColorWriteEnableSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_color_write_enable</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_COLOR_WRITE_ENABLE_EXTENSION_NAME.html" /></remarks>
        public const string ExtColorWriteEnableExtensionName = "VK_EXT_color_write_enable";
        /// <summary>[from: <b>VK_EXT_primitives_generated_query</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PRIMITIVES_GENERATED_QUERY_SPEC_VERSION.html" /></remarks>
        public const uint ExtPrimitivesGeneratedQuerySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_primitives_generated_query</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PRIMITIVES_GENERATED_QUERY_EXTENSION_NAME.html" /></remarks>
        public const string ExtPrimitivesGeneratedQueryExtensionName = "VK_EXT_primitives_generated_query";
        /// <summary>[from: <b>VK_KHR_ray_tracing_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_RAY_TRACING_MAINTENANCE_1_SPEC_VERSION.html" /></remarks>
        public const uint KhrRayTracingMaintenance1SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_ray_tracing_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_RAY_TRACING_MAINTENANCE_1_EXTENSION_NAME.html" /></remarks>
        public const string KhrRayTracingMaintenance1ExtensionName = "VK_KHR_ray_tracing_maintenance1";
        /// <summary>[from: <b>VK_EXT_global_priority_query</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_GLOBAL_PRIORITY_QUERY_SPEC_VERSION.html" /></remarks>
        public const uint ExtGlobalPriorityQuerySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_global_priority_query</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_GLOBAL_PRIORITY_QUERY_EXTENSION_NAME.html" /></remarks>
        public const string ExtGlobalPriorityQueryExtensionName = "VK_EXT_global_priority_query";
        /// <summary>[from: <b>VK_EXT_image_view_min_lod</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_VIEW_MIN_LOD_SPEC_VERSION.html" /></remarks>
        public const uint ExtImageViewMinLodSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_image_view_min_lod</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_VIEW_MIN_LOD_EXTENSION_NAME.html" /></remarks>
        public const string ExtImageViewMinLodExtensionName = "VK_EXT_image_view_min_lod";
        /// <summary>[from: <b>VK_EXT_multi_draw</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MULTI_DRAW_SPEC_VERSION.html" /></remarks>
        public const uint ExtMultiDrawSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_multi_draw</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MULTI_DRAW_EXTENSION_NAME.html" /></remarks>
        public const string ExtMultiDrawExtensionName = "VK_EXT_multi_draw";
        /// <summary>[from: <b>VK_EXT_image_2d_view_of_3d</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_2D_VIEW_OF_3D_SPEC_VERSION.html" /></remarks>
        public const uint ExtImage2dViewOf3dSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_image_2d_view_of_3d</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_2D_VIEW_OF_3D_EXTENSION_NAME.html" /></remarks>
        public const string ExtImage2dViewOf3dExtensionName = "VK_EXT_image_2d_view_of_3d";
        /// <summary>[from: <b>VK_KHR_portability_enumeration</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PORTABILITY_ENUMERATION_SPEC_VERSION.html" /></remarks>
        public const uint KhrPortabilityEnumerationSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_portability_enumeration</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PORTABILITY_ENUMERATION_EXTENSION_NAME.html" /></remarks>
        public const string KhrPortabilityEnumerationExtensionName = "VK_KHR_portability_enumeration";
        /// <summary>[from: <b>VK_EXT_shader_tile_image</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_TILE_IMAGE_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderTileImageSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_tile_image</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_TILE_IMAGE_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderTileImageExtensionName = "VK_EXT_shader_tile_image";
        /// <summary>[from: <b>VK_EXT_opacity_micromap</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_OPACITY_MICROMAP_SPEC_VERSION.html" /></remarks>
        public const uint ExtOpacityMicromapSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_opacity_micromap</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_OPACITY_MICROMAP_EXTENSION_NAME.html" /></remarks>
        public const string ExtOpacityMicromapExtensionName = "VK_EXT_opacity_micromap";
        /// <summary>[from: <b>VK_NV_displacement_micromap</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DISPLACEMENT_MICROMAP_SPEC_VERSION.html" /></remarks>
        public const uint NvDisplacementMicromapSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_displacement_micromap</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DISPLACEMENT_MICROMAP_EXTENSION_NAME.html" /></remarks>
        public const string NvDisplacementMicromapExtensionName = "VK_NV_displacement_micromap";
        /// <summary>[from: <b>VK_EXT_load_store_op_none</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_LOAD_STORE_OP_NONE_SPEC_VERSION.html" /></remarks>
        public const uint ExtLoadStoreOpNoneSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_load_store_op_none</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_LOAD_STORE_OP_NONE_EXTENSION_NAME.html" /></remarks>
        public const string ExtLoadStoreOpNoneExtensionName = "VK_EXT_load_store_op_none";
        /// <summary>[from: <b>VK_HUAWEI_cluster_culling_shader</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_CLUSTER_CULLING_SHADER_SPEC_VERSION.html" /></remarks>
        public const uint HuaweiClusterCullingShaderSpecVersion = 3;
        /// <summary>[from: <b>VK_HUAWEI_cluster_culling_shader</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_CLUSTER_CULLING_SHADER_EXTENSION_NAME.html" /></remarks>
        public const string HuaweiClusterCullingShaderExtensionName = "VK_HUAWEI_cluster_culling_shader";
        /// <summary>[from: <b>VK_EXT_border_color_swizzle</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_BORDER_COLOR_SWIZZLE_SPEC_VERSION.html" /></remarks>
        public const uint ExtBorderColorSwizzleSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_border_color_swizzle</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_BORDER_COLOR_SWIZZLE_EXTENSION_NAME.html" /></remarks>
        public const string ExtBorderColorSwizzleExtensionName = "VK_EXT_border_color_swizzle";
        /// <summary>[from: <b>VK_EXT_pageable_device_local_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_SPEC_VERSION.html" /></remarks>
        public const uint ExtPageableDeviceLocalMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_pageable_device_local_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_EXTENSION_NAME.html" /></remarks>
        public const string ExtPageableDeviceLocalMemoryExtensionName = "VK_EXT_pageable_device_local_memory";
        /// <summary>[from: <b>VK_KHR_maintenance4</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_4_SPEC_VERSION.html" /></remarks>
        public const uint KhrMaintenance4SpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_maintenance4</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_4_EXTENSION_NAME.html" /></remarks>
        public const string KhrMaintenance4ExtensionName = "VK_KHR_maintenance4";
        /// <summary>[from: <b>VK_ARM_shader_core_properties</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_SHADER_CORE_PROPERTIES_SPEC_VERSION.html" /></remarks>
        public const uint ArmShaderCorePropertiesSpecVersion = 1;
        /// <summary>[from: <b>VK_ARM_shader_core_properties</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_SHADER_CORE_PROPERTIES_EXTENSION_NAME.html" /></remarks>
        public const string ArmShaderCorePropertiesExtensionName = "VK_ARM_shader_core_properties";
        /// <summary>[from: <b>VK_KHR_shader_subgroup_rotate</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_SUBGROUP_ROTATE_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderSubgroupRotateSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_shader_subgroup_rotate</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_SUBGROUP_ROTATE_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderSubgroupRotateExtensionName = "VK_KHR_shader_subgroup_rotate";
        /// <summary>[from: <b>VK_ARM_scheduling_controls</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_SCHEDULING_CONTROLS_SPEC_VERSION.html" /></remarks>
        public const uint ArmSchedulingControlsSpecVersion = 1;
        /// <summary>[from: <b>VK_ARM_scheduling_controls</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_SCHEDULING_CONTROLS_EXTENSION_NAME.html" /></remarks>
        public const string ArmSchedulingControlsExtensionName = "VK_ARM_scheduling_controls";
        /// <summary>[from: <b>VK_EXT_image_sliced_view_of_3d</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_SLICED_VIEW_OF_3D_SPEC_VERSION.html" /></remarks>
        public const uint ExtImageSlicedViewOf3dSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_image_sliced_view_of_3d</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_SLICED_VIEW_OF_3D_EXTENSION_NAME.html" /></remarks>
        public const string ExtImageSlicedViewOf3dExtensionName = "VK_EXT_image_sliced_view_of_3d";
        /// <summary>[from: <b>VK_VALVE_descriptor_set_host_mapping</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_VALVE_DESCRIPTOR_SET_HOST_MAPPING_SPEC_VERSION.html" /></remarks>
        public const uint ValveDescriptorSetHostMappingSpecVersion = 1;
        /// <summary>[from: <b>VK_VALVE_descriptor_set_host_mapping</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_VALVE_DESCRIPTOR_SET_HOST_MAPPING_EXTENSION_NAME.html" /></remarks>
        public const string ValveDescriptorSetHostMappingExtensionName = "VK_VALVE_descriptor_set_host_mapping";
        /// <summary>[from: <b>VK_EXT_depth_clamp_zero_one</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEPTH_CLAMP_ZERO_ONE_SPEC_VERSION.html" /></remarks>
        public const uint ExtDepthClampZeroOneSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_depth_clamp_zero_one</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEPTH_CLAMP_ZERO_ONE_EXTENSION_NAME.html" /></remarks>
        public const string ExtDepthClampZeroOneExtensionName = "VK_EXT_depth_clamp_zero_one";
        /// <summary>[from: <b>VK_EXT_non_seamless_cube_map</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_NON_SEAMLESS_CUBE_MAP_SPEC_VERSION.html" /></remarks>
        public const uint ExtNonSeamlessCubeMapSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_non_seamless_cube_map</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_NON_SEAMLESS_CUBE_MAP_EXTENSION_NAME.html" /></remarks>
        public const string ExtNonSeamlessCubeMapExtensionName = "VK_EXT_non_seamless_cube_map";
        /// <summary>[from: <b>VK_ARM_render_pass_striped</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_RENDER_PASS_STRIPED_SPEC_VERSION.html" /></remarks>
        public const uint ArmRenderPassStripedSpecVersion = 1;
        /// <summary>[from: <b>VK_ARM_render_pass_striped</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_RENDER_PASS_STRIPED_EXTENSION_NAME.html" /></remarks>
        public const string ArmRenderPassStripedExtensionName = "VK_ARM_render_pass_striped";
        /// <summary>[from: <b>VK_QCOM_fragment_density_map_offset</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_SPEC_VERSION.html" /></remarks>
        public const uint QcomFragmentDensityMapOffsetSpecVersion = 3;
        /// <summary>[from: <b>VK_QCOM_fragment_density_map_offset</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_FRAGMENT_DENSITY_MAP_OFFSET_EXTENSION_NAME.html" /></remarks>
        public const string QcomFragmentDensityMapOffsetExtensionName = "VK_QCOM_fragment_density_map_offset";
        /// <summary>[from: <b>VK_NV_copy_memory_indirect</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COPY_MEMORY_INDIRECT_SPEC_VERSION.html" /></remarks>
        public const uint NvCopyMemoryIndirectSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_copy_memory_indirect</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COPY_MEMORY_INDIRECT_EXTENSION_NAME.html" /></remarks>
        public const string NvCopyMemoryIndirectExtensionName = "VK_NV_copy_memory_indirect";
        /// <summary>[from: <b>VK_NV_memory_decompression</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_MEMORY_DECOMPRESSION_SPEC_VERSION.html" /></remarks>
        public const uint NvMemoryDecompressionSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_memory_decompression</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_MEMORY_DECOMPRESSION_EXTENSION_NAME.html" /></remarks>
        public const string NvMemoryDecompressionExtensionName = "VK_NV_memory_decompression";
        /// <summary>[from: <b>VK_NV_device_generated_commands_compute</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DEVICE_GENERATED_COMMANDS_COMPUTE_SPEC_VERSION.html" /></remarks>
        public const uint NvDeviceGeneratedCommandsComputeSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_device_generated_commands_compute</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DEVICE_GENERATED_COMMANDS_COMPUTE_EXTENSION_NAME.html" /></remarks>
        public const string NvDeviceGeneratedCommandsComputeExtensionName = "VK_NV_device_generated_commands_compute";
        /// <summary>[from: <b>VK_NV_ray_tracing_linear_swept_spheres</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_RAY_TRACING_LINEAR_SWEPT_SPHERES_SPEC_VERSION.html" /></remarks>
        public const uint NvRayTracingLinearSweptSpheresSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_ray_tracing_linear_swept_spheres</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_RAY_TRACING_LINEAR_SWEPT_SPHERES_EXTENSION_NAME.html" /></remarks>
        public const string NvRayTracingLinearSweptSpheresExtensionName = "VK_NV_ray_tracing_linear_swept_spheres";
        /// <summary>[from: <b>VK_NV_linear_color_attachment</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_LINEAR_COLOR_ATTACHMENT_SPEC_VERSION.html" /></remarks>
        public const uint NvLinearColorAttachmentSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_linear_color_attachment</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_LINEAR_COLOR_ATTACHMENT_EXTENSION_NAME.html" /></remarks>
        public const string NvLinearColorAttachmentExtensionName = "VK_NV_linear_color_attachment";
        /// <summary>[from: <b>VK_GOOGLE_surfaceless_query</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_SURFACELESS_QUERY_SPEC_VERSION.html" /></remarks>
        public const uint GoogleSurfacelessQuerySpecVersion = 2;
        /// <summary>[from: <b>VK_GOOGLE_surfaceless_query</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_SURFACELESS_QUERY_EXTENSION_NAME.html" /></remarks>
        public const string GoogleSurfacelessQueryExtensionName = "VK_GOOGLE_surfaceless_query";
        /// <summary>[from: <b>VK_KHR_shader_maximal_reconvergence</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_MAXIMAL_RECONVERGENCE_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderMaximalReconvergenceSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_maximal_reconvergence</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_MAXIMAL_RECONVERGENCE_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderMaximalReconvergenceExtensionName = "VK_KHR_shader_maximal_reconvergence";
        /// <summary>[from: <b>VK_EXT_application_parameters</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_APPLICATION_PARAMETERS_SPEC_VERSION.html" /></remarks>
        public const uint ExtApplicationParametersSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_application_parameters</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_APPLICATION_PARAMETERS_EXTENSION_NAME.html" /></remarks>
        public const string ExtApplicationParametersExtensionName = "VK_EXT_application_parameters";
        /// <summary>[from: <b>VK_EXT_image_compression_control_swapchain</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_SPEC_VERSION.html" /></remarks>
        public const uint ExtImageCompressionControlSwapchainSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_image_compression_control_swapchain</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_EXTENSION_NAME.html" /></remarks>
        public const string ExtImageCompressionControlSwapchainExtensionName = "VK_EXT_image_compression_control_swapchain";
        /// <summary>[from: <b>VK_QCOM_image_processing</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_IMAGE_PROCESSING_SPEC_VERSION.html" /></remarks>
        public const uint QcomImageProcessingSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_image_processing</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_IMAGE_PROCESSING_EXTENSION_NAME.html" /></remarks>
        public const string QcomImageProcessingExtensionName = "VK_QCOM_image_processing";
        /// <summary>[from: <b>VK_EXT_nested_command_buffer</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_NESTED_COMMAND_BUFFER_SPEC_VERSION.html" /></remarks>
        public const uint ExtNestedCommandBufferSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_nested_command_buffer</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_NESTED_COMMAND_BUFFER_EXTENSION_NAME.html" /></remarks>
        public const string ExtNestedCommandBufferExtensionName = "VK_EXT_nested_command_buffer";
        /// <summary>[from: <b>VK_EXT_external_memory_acquire_unmodified</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_SPEC_VERSION.html" /></remarks>
        public const uint ExtExternalMemoryAcquireUnmodifiedSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_external_memory_acquire_unmodified</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXTENSION_NAME.html" /></remarks>
        public const string ExtExternalMemoryAcquireUnmodifiedExtensionName = "VK_EXT_external_memory_acquire_unmodified";
        /// <summary>[from: <b>VK_EXT_extended_dynamic_state3</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTENDED_DYNAMIC_STATE_3_SPEC_VERSION.html" /></remarks>
        public const uint ExtExtendedDynamicState3SpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_extended_dynamic_state3</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTENDED_DYNAMIC_STATE_3_EXTENSION_NAME.html" /></remarks>
        public const string ExtExtendedDynamicState3ExtensionName = "VK_EXT_extended_dynamic_state3";
        /// <summary>[from: <b>VK_EXT_subpass_merge_feedback</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SUBPASS_MERGE_FEEDBACK_SPEC_VERSION.html" /></remarks>
        public const uint ExtSubpassMergeFeedbackSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_subpass_merge_feedback</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SUBPASS_MERGE_FEEDBACK_EXTENSION_NAME.html" /></remarks>
        public const string ExtSubpassMergeFeedbackExtensionName = "VK_EXT_subpass_merge_feedback";
        /// <summary>[from: <b>VK_LUNARG_direct_driver_loading</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_LUNARG_DIRECT_DRIVER_LOADING_SPEC_VERSION.html" /></remarks>
        public const uint LunargDirectDriverLoadingSpecVersion = 1;
        /// <summary>[from: <b>VK_LUNARG_direct_driver_loading</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_LUNARG_DIRECT_DRIVER_LOADING_EXTENSION_NAME.html" /></remarks>
        public const string LunargDirectDriverLoadingExtensionName = "VK_LUNARG_direct_driver_loading";
        /// <summary>[from: <b>VK_ARM_tensors</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_TENSORS_SPEC_VERSION.html" /></remarks>
        public const uint ArmTensorsSpecVersion = 1;
        /// <summary>[from: <b>VK_ARM_tensors</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_TENSORS_EXTENSION_NAME.html" /></remarks>
        public const string ArmTensorsExtensionName = "VK_ARM_tensors";
        /// <summary>[from: <b>VK_EXT_shader_module_identifier</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_MODULE_IDENTIFIER_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderModuleIdentifierSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_module_identifier</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_MODULE_IDENTIFIER_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderModuleIdentifierExtensionName = "VK_EXT_shader_module_identifier";
        /// <summary>[from: <b>VK_EXT_rasterization_order_attachment_access</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_SPEC_VERSION.html" /></remarks>
        public const uint ExtRasterizationOrderAttachmentAccessSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_rasterization_order_attachment_access</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_EXTENSION_NAME.html" /></remarks>
        public const string ExtRasterizationOrderAttachmentAccessExtensionName = "VK_EXT_rasterization_order_attachment_access";
        /// <summary>[from: <b>VK_NV_optical_flow</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_OPTICAL_FLOW_SPEC_VERSION.html" /></remarks>
        public const uint NvOpticalFlowSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_optical_flow</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_OPTICAL_FLOW_EXTENSION_NAME.html" /></remarks>
        public const string NvOpticalFlowExtensionName = "VK_NV_optical_flow";
        /// <summary>[from: <b>VK_EXT_legacy_dithering</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_LEGACY_DITHERING_SPEC_VERSION.html" /></remarks>
        public const uint ExtLegacyDitheringSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_legacy_dithering</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_LEGACY_DITHERING_EXTENSION_NAME.html" /></remarks>
        public const string ExtLegacyDitheringExtensionName = "VK_EXT_legacy_dithering";
        /// <summary>[from: <b>VK_EXT_pipeline_protected_access</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PIPELINE_PROTECTED_ACCESS_SPEC_VERSION.html" /></remarks>
        public const uint ExtPipelineProtectedAccessSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_pipeline_protected_access</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PIPELINE_PROTECTED_ACCESS_EXTENSION_NAME.html" /></remarks>
        public const string ExtPipelineProtectedAccessExtensionName = "VK_EXT_pipeline_protected_access";
        /// <summary>[from: <b>VK_ANDROID_external_format_resolve</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ANDROID_EXTERNAL_FORMAT_RESOLVE_SPEC_VERSION.html" /></remarks>
        public const uint AndroidExternalFormatResolveSpecVersion = 1;
        /// <summary>[from: <b>VK_ANDROID_external_format_resolve</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ANDROID_EXTERNAL_FORMAT_RESOLVE_EXTENSION_NAME.html" /></remarks>
        public const string AndroidExternalFormatResolveExtensionName = "VK_ANDROID_external_format_resolve";
        /// <summary>[from: <b>VK_KHR_maintenance5</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_5_SPEC_VERSION.html" /></remarks>
        public const uint KhrMaintenance5SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_maintenance5</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_5_EXTENSION_NAME.html" /></remarks>
        public const string KhrMaintenance5ExtensionName = "VK_KHR_maintenance5";
        /// <summary>[from: <b>VK_AMD_anti_lag</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_ANTI_LAG_SPEC_VERSION.html" /></remarks>
        public const uint AmdAntiLagSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_anti_lag</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_AMD_ANTI_LAG_EXTENSION_NAME.html" /></remarks>
        public const string AmdAntiLagExtensionName = "VK_AMD_anti_lag";
        /// <summary>[from: <b>VK_KHR_present_id2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PRESENT_ID_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrPresentId2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_present_id2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PRESENT_ID_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrPresentId2ExtensionName = "VK_KHR_present_id2";
        /// <summary>[from: <b>VK_KHR_present_wait2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PRESENT_WAIT_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrPresentWait2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_present_wait2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PRESENT_WAIT_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrPresentWait2ExtensionName = "VK_KHR_present_wait2";
        /// <summary>[from: <b>VK_KHR_ray_tracing_position_fetch</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_RAY_TRACING_POSITION_FETCH_SPEC_VERSION.html" /></remarks>
        public const uint KhrRayTracingPositionFetchSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_ray_tracing_position_fetch</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_RAY_TRACING_POSITION_FETCH_EXTENSION_NAME.html" /></remarks>
        public const string KhrRayTracingPositionFetchExtensionName = "VK_KHR_ray_tracing_position_fetch";
        /// <summary>[from: <b>VK_EXT_shader_object</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_OBJECT_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderObjectSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_object</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_OBJECT_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderObjectExtensionName = "VK_EXT_shader_object";
        /// <summary>[from: <b>VK_KHR_pipeline_binary</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PIPELINE_BINARY_SPEC_VERSION.html" /></remarks>
        public const uint KhrPipelineBinarySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_pipeline_binary</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PIPELINE_BINARY_EXTENSION_NAME.html" /></remarks>
        public const string KhrPipelineBinaryExtensionName = "VK_KHR_pipeline_binary";
        /// <summary>[from: <b>VK_QCOM_tile_properties</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_TILE_PROPERTIES_SPEC_VERSION.html" /></remarks>
        public const uint QcomTilePropertiesSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_tile_properties</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_TILE_PROPERTIES_EXTENSION_NAME.html" /></remarks>
        public const string QcomTilePropertiesExtensionName = "VK_QCOM_tile_properties";
        /// <summary>[from: <b>VK_SEC_amigo_profiling</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_SEC_AMIGO_PROFILING_SPEC_VERSION.html" /></remarks>
        public const uint SecAmigoProfilingSpecVersion = 1;
        /// <summary>[from: <b>VK_SEC_amigo_profiling</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_SEC_AMIGO_PROFILING_EXTENSION_NAME.html" /></remarks>
        public const string SecAmigoProfilingExtensionName = "VK_SEC_amigo_profiling";
        /// <summary>[from: <b>VK_KHR_surface_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SURFACE_MAINTENANCE_1_SPEC_VERSION.html" /></remarks>
        public const uint KhrSurfaceMaintenance1SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_surface_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SURFACE_MAINTENANCE_1_EXTENSION_NAME.html" /></remarks>
        public const string KhrSurfaceMaintenance1ExtensionName = "VK_KHR_surface_maintenance1";
        /// <summary>[from: <b>VK_KHR_swapchain_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SWAPCHAIN_MAINTENANCE_1_SPEC_VERSION.html" /></remarks>
        public const uint KhrSwapchainMaintenance1SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_swapchain_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SWAPCHAIN_MAINTENANCE_1_EXTENSION_NAME.html" /></remarks>
        public const string KhrSwapchainMaintenance1ExtensionName = "VK_KHR_swapchain_maintenance1";
        /// <summary>[from: <b>VK_QCOM_multiview_per_view_viewports</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_MULTIVIEW_PER_VIEW_VIEWPORTS_SPEC_VERSION.html" /></remarks>
        public const uint QcomMultiviewPerViewViewportsSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_multiview_per_view_viewports</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_MULTIVIEW_PER_VIEW_VIEWPORTS_EXTENSION_NAME.html" /></remarks>
        public const string QcomMultiviewPerViewViewportsExtensionName = "VK_QCOM_multiview_per_view_viewports";
        /// <summary>[from: <b>VK_NV_external_sci_sync2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_SCI_SYNC_2_SPEC_VERSION.html" /></remarks>
        public const uint NvExternalSciSync2SpecVersion = 1;
        /// <summary>[from: <b>VK_NV_external_sci_sync2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_SCI_SYNC_2_EXTENSION_NAME.html" /></remarks>
        public const string NvExternalSciSync2ExtensionName = "VK_NV_external_sci_sync2";
        /// <summary>[from: <b>VK_NV_ray_tracing_invocation_reorder</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_RAY_TRACING_INVOCATION_REORDER_SPEC_VERSION.html" /></remarks>
        public const uint NvRayTracingInvocationReorderSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_ray_tracing_invocation_reorder</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_RAY_TRACING_INVOCATION_REORDER_EXTENSION_NAME.html" /></remarks>
        public const string NvRayTracingInvocationReorderExtensionName = "VK_NV_ray_tracing_invocation_reorder";
        /// <summary>[from: <b>VK_NV_cooperative_vector</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COOPERATIVE_VECTOR_SPEC_VERSION.html" /></remarks>
        public const uint NvCooperativeVectorSpecVersion = 4;
        /// <summary>[from: <b>VK_NV_cooperative_vector</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COOPERATIVE_VECTOR_EXTENSION_NAME.html" /></remarks>
        public const string NvCooperativeVectorExtensionName = "VK_NV_cooperative_vector";
        /// <summary>[from: <b>VK_NV_extended_sparse_address_space</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTENDED_SPARSE_ADDRESS_SPACE_SPEC_VERSION.html" /></remarks>
        public const uint NvExtendedSparseAddressSpaceSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_extended_sparse_address_space</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTENDED_SPARSE_ADDRESS_SPACE_EXTENSION_NAME.html" /></remarks>
        public const string NvExtendedSparseAddressSpaceExtensionName = "VK_NV_extended_sparse_address_space";
        /// <summary>[from: <b>VK_EXT_mutable_descriptor_type</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION.html" /></remarks>
        public const uint ExtMutableDescriptorTypeSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_mutable_descriptor_type</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME.html" /></remarks>
        public const string ExtMutableDescriptorTypeExtensionName = "VK_EXT_mutable_descriptor_type";
        /// <summary>[from: <b>VK_EXT_legacy_vertex_attributes</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_LEGACY_VERTEX_ATTRIBUTES_SPEC_VERSION.html" /></remarks>
        public const uint ExtLegacyVertexAttributesSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_legacy_vertex_attributes</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_LEGACY_VERTEX_ATTRIBUTES_EXTENSION_NAME.html" /></remarks>
        public const string ExtLegacyVertexAttributesExtensionName = "VK_EXT_legacy_vertex_attributes";
        /// <summary>[from: <b>VK_EXT_layer_settings</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_LAYER_SETTINGS_SPEC_VERSION.html" /></remarks>
        public const uint ExtLayerSettingsSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_layer_settings</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_LAYER_SETTINGS_EXTENSION_NAME.html" /></remarks>
        public const string ExtLayerSettingsExtensionName = "VK_EXT_layer_settings";
        /// <summary>[from: <b>VK_ARM_shader_core_builtins</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_SHADER_CORE_BUILTINS_SPEC_VERSION.html" /></remarks>
        public const uint ArmShaderCoreBuiltinsSpecVersion = 2;
        /// <summary>[from: <b>VK_ARM_shader_core_builtins</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_SHADER_CORE_BUILTINS_EXTENSION_NAME.html" /></remarks>
        public const string ArmShaderCoreBuiltinsExtensionName = "VK_ARM_shader_core_builtins";
        /// <summary>[from: <b>VK_EXT_pipeline_library_group_handles</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PIPELINE_LIBRARY_GROUP_HANDLES_SPEC_VERSION.html" /></remarks>
        public const uint ExtPipelineLibraryGroupHandlesSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_pipeline_library_group_handles</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_PIPELINE_LIBRARY_GROUP_HANDLES_EXTENSION_NAME.html" /></remarks>
        public const string ExtPipelineLibraryGroupHandlesExtensionName = "VK_EXT_pipeline_library_group_handles";
        /// <summary>[from: <b>VK_EXT_dynamic_rendering_unused_attachments</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_SPEC_VERSION.html" /></remarks>
        public const uint ExtDynamicRenderingUnusedAttachmentsSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_dynamic_rendering_unused_attachments</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_EXTENSION_NAME.html" /></remarks>
        public const string ExtDynamicRenderingUnusedAttachmentsExtensionName = "VK_EXT_dynamic_rendering_unused_attachments";
        /// <summary>[from: <b>VK_NV_low_latency2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_LOW_LATENCY_2_SPEC_VERSION.html" /></remarks>
        public const uint NvLowLatency2SpecVersion = 2;
        /// <summary>[from: <b>VK_NV_low_latency2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_LOW_LATENCY_2_EXTENSION_NAME.html" /></remarks>
        public const string NvLowLatency2ExtensionName = "VK_NV_low_latency2";
        /// <summary>[from: <b>VK_KHR_cooperative_matrix</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_COOPERATIVE_MATRIX_SPEC_VERSION.html" /></remarks>
        public const uint KhrCooperativeMatrixSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_cooperative_matrix</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_COOPERATIVE_MATRIX_EXTENSION_NAME.html" /></remarks>
        public const string KhrCooperativeMatrixExtensionName = "VK_KHR_cooperative_matrix";
        /// <summary>[from: <b>VK_ARM_data_graph</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_DATA_GRAPH_SPEC_VERSION.html" /></remarks>
        public const uint ArmDataGraphSpecVersion = 1;
        /// <summary>[from: <b>VK_ARM_data_graph</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_DATA_GRAPH_EXTENSION_NAME.html" /></remarks>
        public const string ArmDataGraphExtensionName = "VK_ARM_data_graph";
        /// <summary>[from: <b>VK_QCOM_multiview_per_view_render_areas</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_MULTIVIEW_PER_VIEW_RENDER_AREAS_SPEC_VERSION.html" /></remarks>
        public const uint QcomMultiviewPerViewRenderAreasSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_multiview_per_view_render_areas</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_MULTIVIEW_PER_VIEW_RENDER_AREAS_EXTENSION_NAME.html" /></remarks>
        public const string QcomMultiviewPerViewRenderAreasExtensionName = "VK_QCOM_multiview_per_view_render_areas";
        /// <summary>[from: <b>VK_KHR_compute_shader_derivatives</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION.html" /></remarks>
        public const uint KhrComputeShaderDerivativesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_compute_shader_derivatives</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME.html" /></remarks>
        public const string KhrComputeShaderDerivativesExtensionName = "VK_KHR_compute_shader_derivatives";
        /// <summary>[from: <b>VK_KHR_video_decode_av1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_DECODE_AV1_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoDecodeAv1SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_video_decode_av1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_DECODE_AV1_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoDecodeAv1ExtensionName = "VK_KHR_video_decode_av1";
        /// <summary>[from: <b>VK_KHR_video_encode_av1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_ENCODE_AV1_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoEncodeAv1SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_video_encode_av1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_ENCODE_AV1_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoEncodeAv1ExtensionName = "VK_KHR_video_encode_av1";
        /// <summary>[from: <b>VK_KHR_video_decode_vp9</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_DECODE_VP9_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoDecodeVp9SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_video_decode_vp9</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_DECODE_VP9_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoDecodeVp9ExtensionName = "VK_KHR_video_decode_vp9";
        /// <summary>[from: <b>VK_KHR_video_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_MAINTENANCE_1_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoMaintenance1SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_video_maintenance1</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_MAINTENANCE_1_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoMaintenance1ExtensionName = "VK_KHR_video_maintenance1";
        /// <summary>[from: <b>VK_NV_per_stage_descriptor_set</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_PER_STAGE_DESCRIPTOR_SET_SPEC_VERSION.html" /></remarks>
        public const uint NvPerStageDescriptorSetSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_per_stage_descriptor_set</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_PER_STAGE_DESCRIPTOR_SET_EXTENSION_NAME.html" /></remarks>
        public const string NvPerStageDescriptorSetExtensionName = "VK_NV_per_stage_descriptor_set";
        /// <summary>[from: <b>VK_QCOM_image_processing2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_IMAGE_PROCESSING_2_SPEC_VERSION.html" /></remarks>
        public const uint QcomImageProcessing2SpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_image_processing2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_IMAGE_PROCESSING_2_EXTENSION_NAME.html" /></remarks>
        public const string QcomImageProcessing2ExtensionName = "VK_QCOM_image_processing2";
        /// <summary>[from: <b>VK_QCOM_filter_cubic_weights</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_FILTER_CUBIC_WEIGHTS_SPEC_VERSION.html" /></remarks>
        public const uint QcomFilterCubicWeightsSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_filter_cubic_weights</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_FILTER_CUBIC_WEIGHTS_EXTENSION_NAME.html" /></remarks>
        public const string QcomFilterCubicWeightsExtensionName = "VK_QCOM_filter_cubic_weights";
        /// <summary>[from: <b>VK_QCOM_ycbcr_degamma</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_YCBCR_DEGAMMA_SPEC_VERSION.html" /></remarks>
        public const uint QcomYcbcrDegammaSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_ycbcr_degamma</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_YCBCR_DEGAMMA_EXTENSION_NAME.html" /></remarks>
        public const string QcomYcbcrDegammaExtensionName = "VK_QCOM_ycbcr_degamma";
        /// <summary>[from: <b>VK_QCOM_filter_cubic_clamp</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_FILTER_CUBIC_CLAMP_SPEC_VERSION.html" /></remarks>
        public const uint QcomFilterCubicClampSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_filter_cubic_clamp</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_FILTER_CUBIC_CLAMP_EXTENSION_NAME.html" /></remarks>
        public const string QcomFilterCubicClampExtensionName = "VK_QCOM_filter_cubic_clamp";
        /// <summary>[from: <b>VK_EXT_attachment_feedback_loop_dynamic_state</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_SPEC_VERSION.html" /></remarks>
        public const uint ExtAttachmentFeedbackLoopDynamicStateSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_attachment_feedback_loop_dynamic_state</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_EXTENSION_NAME.html" /></remarks>
        public const string ExtAttachmentFeedbackLoopDynamicStateExtensionName = "VK_EXT_attachment_feedback_loop_dynamic_state";
        /// <summary>[from: <b>VK_KHR_vertex_attribute_divisor</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION.html" /></remarks>
        public const uint KhrVertexAttributeDivisorSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_vertex_attribute_divisor</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME.html" /></remarks>
        public const string KhrVertexAttributeDivisorExtensionName = "VK_KHR_vertex_attribute_divisor";
        /// <summary>[from: <b>VK_KHR_load_store_op_none</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_LOAD_STORE_OP_NONE_SPEC_VERSION.html" /></remarks>
        public const uint KhrLoadStoreOpNoneSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_load_store_op_none</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_LOAD_STORE_OP_NONE_EXTENSION_NAME.html" /></remarks>
        public const string KhrLoadStoreOpNoneExtensionName = "VK_KHR_load_store_op_none";
        /// <summary>[from: <b>VK_KHR_unified_image_layouts</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_UNIFIED_IMAGE_LAYOUTS_SPEC_VERSION.html" /></remarks>
        public const uint KhrUnifiedImageLayoutsSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_unified_image_layouts</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_UNIFIED_IMAGE_LAYOUTS_EXTENSION_NAME.html" /></remarks>
        public const string KhrUnifiedImageLayoutsExtensionName = "VK_KHR_unified_image_layouts";
        /// <summary>[from: <b>VK_KHR_shader_float_controls2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_FLOAT_CONTROLS_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderFloatControls2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_float_controls2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_FLOAT_CONTROLS_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderFloatControls2ExtensionName = "VK_KHR_shader_float_controls2";
        /// <summary>[from: <b>VK_QNX_external_memory_screen_buffer</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QNX_EXTERNAL_MEMORY_SCREEN_BUFFER_SPEC_VERSION.html" /></remarks>
        public const uint QnxExternalMemoryScreenBufferSpecVersion = 1;
        /// <summary>[from: <b>VK_QNX_external_memory_screen_buffer</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QNX_EXTERNAL_MEMORY_SCREEN_BUFFER_EXTENSION_NAME.html" /></remarks>
        public const string QnxExternalMemoryScreenBufferExtensionName = "VK_QNX_external_memory_screen_buffer";
        /// <summary>[from: <b>VK_MSFT_layered_driver</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MSFT_LAYERED_DRIVER_SPEC_VERSION.html" /></remarks>
        public const uint MsftLayeredDriverSpecVersion = 1;
        /// <summary>[from: <b>VK_MSFT_layered_driver</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MSFT_LAYERED_DRIVER_EXTENSION_NAME.html" /></remarks>
        public const string MsftLayeredDriverExtensionName = "VK_MSFT_layered_driver";
        /// <summary>[from: <b>VK_KHR_index_type_uint8</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_INDEX_TYPE_UINT8_SPEC_VERSION.html" /></remarks>
        public const uint KhrIndexTypeUint8SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_index_type_uint8</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_INDEX_TYPE_UINT8_EXTENSION_NAME.html" /></remarks>
        public const string KhrIndexTypeUint8ExtensionName = "VK_KHR_index_type_uint8";
        /// <summary>[from: <b>VK_KHR_line_rasterization</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_LINE_RASTERIZATION_SPEC_VERSION.html" /></remarks>
        public const uint KhrLineRasterizationSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_line_rasterization</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_LINE_RASTERIZATION_EXTENSION_NAME.html" /></remarks>
        public const string KhrLineRasterizationExtensionName = "VK_KHR_line_rasterization";
        /// <summary>[from: <b>VK_KHR_calibrated_timestamps</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_CALIBRATED_TIMESTAMPS_SPEC_VERSION.html" /></remarks>
        public const uint KhrCalibratedTimestampsSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_calibrated_timestamps</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_CALIBRATED_TIMESTAMPS_EXTENSION_NAME.html" /></remarks>
        public const string KhrCalibratedTimestampsExtensionName = "VK_KHR_calibrated_timestamps";
        /// <summary>[from: <b>VK_KHR_shader_expect_assume</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_EXPECT_ASSUME_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderExpectAssumeSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_expect_assume</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_EXPECT_ASSUME_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderExpectAssumeExtensionName = "VK_KHR_shader_expect_assume";
        /// <summary>[from: <b>VK_KHR_maintenance6</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_6_SPEC_VERSION.html" /></remarks>
        public const uint KhrMaintenance6SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_maintenance6</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_6_EXTENSION_NAME.html" /></remarks>
        public const string KhrMaintenance6ExtensionName = "VK_KHR_maintenance6";
        /// <summary>[from: <b>VK_NV_descriptor_pool_overallocation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DESCRIPTOR_POOL_OVERALLOCATION_SPEC_VERSION.html" /></remarks>
        public const uint NvDescriptorPoolOverallocationSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_descriptor_pool_overallocation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DESCRIPTOR_POOL_OVERALLOCATION_EXTENSION_NAME.html" /></remarks>
        public const string NvDescriptorPoolOverallocationExtensionName = "VK_NV_descriptor_pool_overallocation";
        /// <summary>[from: <b>VK_QCOM_tile_memory_heap</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_TILE_MEMORY_HEAP_SPEC_VERSION.html" /></remarks>
        public const uint QcomTileMemoryHeapSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_tile_memory_heap</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_QCOM_TILE_MEMORY_HEAP_EXTENSION_NAME.html" /></remarks>
        public const string QcomTileMemoryHeapExtensionName = "VK_QCOM_tile_memory_heap";
        /// <summary>[from: <b>VK_NV_display_stereo</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DISPLAY_STEREO_SPEC_VERSION.html" /></remarks>
        public const uint NvDisplayStereoSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_display_stereo</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_DISPLAY_STEREO_EXTENSION_NAME.html" /></remarks>
        public const string NvDisplayStereoExtensionName = "VK_NV_display_stereo";
        /// <summary>[from: <b>VK_KHR_video_encode_intra_refresh</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_ENCODE_INTRA_REFRESH_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoEncodeIntraRefreshSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_video_encode_intra_refresh</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_ENCODE_INTRA_REFRESH_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoEncodeIntraRefreshExtensionName = "VK_KHR_video_encode_intra_refresh";
        /// <summary>[from: <b>VK_KHR_video_encode_quantization_map</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_ENCODE_QUANTIZATION_MAP_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoEncodeQuantizationMapSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_video_encode_quantization_map</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_ENCODE_QUANTIZATION_MAP_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoEncodeQuantizationMapExtensionName = "VK_KHR_video_encode_quantization_map";
        /// <summary>[from: <b>VK_NV_raw_access_chains</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_RAW_ACCESS_CHAINS_SPEC_VERSION.html" /></remarks>
        public const uint NvRawAccessChainsSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_raw_access_chains</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_RAW_ACCESS_CHAINS_EXTENSION_NAME.html" /></remarks>
        public const string NvRawAccessChainsExtensionName = "VK_NV_raw_access_chains";
        /// <summary>[from: <b>VK_NV_external_compute_queue</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_COMPUTE_QUEUE_SPEC_VERSION.html" /></remarks>
        public const uint NvExternalComputeQueueSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_external_compute_queue</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_EXTERNAL_COMPUTE_QUEUE_EXTENSION_NAME.html" /></remarks>
        public const string NvExternalComputeQueueExtensionName = "VK_NV_external_compute_queue";
        /// <summary>[from: <b>VK_KHR_shader_relaxed_extended_instruction</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_RELAXED_EXTENDED_INSTRUCTION_SPEC_VERSION.html" /></remarks>
        public const uint KhrShaderRelaxedExtendedInstructionSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_relaxed_extended_instruction</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_SHADER_RELAXED_EXTENDED_INSTRUCTION_EXTENSION_NAME.html" /></remarks>
        public const string KhrShaderRelaxedExtendedInstructionExtensionName = "VK_KHR_shader_relaxed_extended_instruction";
        /// <summary>[from: <b>VK_NV_command_buffer_inheritance</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COMMAND_BUFFER_INHERITANCE_SPEC_VERSION.html" /></remarks>
        public const uint NvCommandBufferInheritanceSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_command_buffer_inheritance</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COMMAND_BUFFER_INHERITANCE_EXTENSION_NAME.html" /></remarks>
        public const string NvCommandBufferInheritanceExtensionName = "VK_NV_command_buffer_inheritance";
        /// <summary>[from: <b>VK_KHR_maintenance7</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_7_SPEC_VERSION.html" /></remarks>
        public const uint KhrMaintenance7SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_maintenance7</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_7_EXTENSION_NAME.html" /></remarks>
        public const string KhrMaintenance7ExtensionName = "VK_KHR_maintenance7";
        /// <summary>[from: <b>VK_NV_shader_atomic_float16_vector</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SHADER_ATOMIC_FLOAT16_VECTOR_SPEC_VERSION.html" /></remarks>
        public const uint NvShaderAtomicFloat16VectorSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_shader_atomic_float16_vector</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_SHADER_ATOMIC_FLOAT16_VECTOR_EXTENSION_NAME.html" /></remarks>
        public const string NvShaderAtomicFloat16VectorExtensionName = "VK_NV_shader_atomic_float16_vector";
        /// <summary>[from: <b>VK_EXT_shader_replicated_composites</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_REPLICATED_COMPOSITES_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderReplicatedCompositesSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_replicated_composites</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_REPLICATED_COMPOSITES_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderReplicatedCompositesExtensionName = "VK_EXT_shader_replicated_composites";
        /// <summary>[from: <b>VK_EXT_shader_float8</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_FLOAT8_SPEC_VERSION.html" /></remarks>
        public const uint ExtShaderFloat8SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_float8</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_SHADER_FLOAT8_EXTENSION_NAME.html" /></remarks>
        public const string ExtShaderFloat8ExtensionName = "VK_EXT_shader_float8";
        /// <summary>[from: <b>VK_NV_ray_tracing_validation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_RAY_TRACING_VALIDATION_SPEC_VERSION.html" /></remarks>
        public const uint NvRayTracingValidationSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_ray_tracing_validation</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_RAY_TRACING_VALIDATION_EXTENSION_NAME.html" /></remarks>
        public const string NvRayTracingValidationExtensionName = "VK_NV_ray_tracing_validation";
        /// <summary>[from: <b>VK_NV_cluster_acceleration_structure</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_CLUSTER_ACCELERATION_STRUCTURE_SPEC_VERSION.html" /></remarks>
        public const uint NvClusterAccelerationStructureSpecVersion = 3;
        /// <summary>[from: <b>VK_NV_cluster_acceleration_structure</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_CLUSTER_ACCELERATION_STRUCTURE_EXTENSION_NAME.html" /></remarks>
        public const string NvClusterAccelerationStructureExtensionName = "VK_NV_cluster_acceleration_structure";
        /// <summary>[from: <b>VK_NV_partitioned_acceleration_structure</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_PARTITIONED_ACCELERATION_STRUCTURE_SPEC_VERSION.html" /></remarks>
        public const uint NvPartitionedAccelerationStructureSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_partitioned_acceleration_structure</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_PARTITIONED_ACCELERATION_STRUCTURE_EXTENSION_NAME.html" /></remarks>
        public const string NvPartitionedAccelerationStructureExtensionName = "VK_NV_partitioned_acceleration_structure";
        /// <summary>[from: <b>VK_EXT_device_generated_commands</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEVICE_GENERATED_COMMANDS_SPEC_VERSION.html" /></remarks>
        public const uint ExtDeviceGeneratedCommandsSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_device_generated_commands</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME.html" /></remarks>
        public const string ExtDeviceGeneratedCommandsExtensionName = "VK_EXT_device_generated_commands";
        /// <summary>[from: <b>VK_KHR_maintenance8</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_8_SPEC_VERSION.html" /></remarks>
        public const uint KhrMaintenance8SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_maintenance8</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_8_EXTENSION_NAME.html" /></remarks>
        public const string KhrMaintenance8ExtensionName = "VK_KHR_maintenance8";
        /// <summary>[from: <b>VK_MESA_image_alignment_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MESA_IMAGE_ALIGNMENT_CONTROL_SPEC_VERSION.html" /></remarks>
        public const uint MesaImageAlignmentControlSpecVersion = 1;
        /// <summary>[from: <b>VK_MESA_image_alignment_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_MESA_IMAGE_ALIGNMENT_CONTROL_EXTENSION_NAME.html" /></remarks>
        public const string MesaImageAlignmentControlExtensionName = "VK_MESA_image_alignment_control";
        /// <summary>[from: <b>VK_EXT_depth_clamp_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEPTH_CLAMP_CONTROL_SPEC_VERSION.html" /></remarks>
        public const uint ExtDepthClampControlSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_depth_clamp_control</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_DEPTH_CLAMP_CONTROL_EXTENSION_NAME.html" /></remarks>
        public const string ExtDepthClampControlExtensionName = "VK_EXT_depth_clamp_control";
        /// <summary>[from: <b>VK_KHR_maintenance9</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_9_SPEC_VERSION.html" /></remarks>
        public const uint KhrMaintenance9SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_maintenance9</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_MAINTENANCE_9_EXTENSION_NAME.html" /></remarks>
        public const string KhrMaintenance9ExtensionName = "VK_KHR_maintenance9";
        /// <summary>[from: <b>VK_KHR_video_maintenance2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_MAINTENANCE_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrVideoMaintenance2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_video_maintenance2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_VIDEO_MAINTENANCE_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrVideoMaintenance2ExtensionName = "VK_KHR_video_maintenance2";
        /// <summary>[from: <b>VK_OHOS_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_OHOS_SURFACE_SPEC_VERSION.html" /></remarks>
        public const uint OhosSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_OHOS_surface</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_OHOS_SURFACE_EXTENSION_NAME.html" /></remarks>
        public const string OhosSurfaceExtensionName = "VK_OHOS_surface";
        /// <summary>[from: <b>VK_HUAWEI_hdr_vivid</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_HDR_VIVID_SPEC_VERSION.html" /></remarks>
        public const uint HuaweiHdrVividSpecVersion = 1;
        /// <summary>[from: <b>VK_HUAWEI_hdr_vivid</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_HDR_VIVID_EXTENSION_NAME.html" /></remarks>
        public const string HuaweiHdrVividExtensionName = "VK_HUAWEI_hdr_vivid";
        /// <summary>[from: <b>VK_NV_cooperative_matrix2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COOPERATIVE_MATRIX_2_SPEC_VERSION.html" /></remarks>
        public const uint NvCooperativeMatrix2SpecVersion = 1;
        /// <summary>[from: <b>VK_NV_cooperative_matrix2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_COOPERATIVE_MATRIX_2_EXTENSION_NAME.html" /></remarks>
        public const string NvCooperativeMatrix2ExtensionName = "VK_NV_cooperative_matrix2";
        /// <summary>[from: <b>VK_ARM_pipeline_opacity_micromap</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_PIPELINE_OPACITY_MICROMAP_SPEC_VERSION.html" /></remarks>
        public const uint ArmPipelineOpacityMicromapSpecVersion = 1;
        /// <summary>[from: <b>VK_ARM_pipeline_opacity_micromap</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_PIPELINE_OPACITY_MICROMAP_EXTENSION_NAME.html" /></remarks>
        public const string ArmPipelineOpacityMicromapExtensionName = "VK_ARM_pipeline_opacity_micromap";
        /// <summary>[from: <b>VK_EXT_external_memory_metal</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTERNAL_MEMORY_METAL_SPEC_VERSION.html" /></remarks>
        public const uint ExtExternalMemoryMetalSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_external_memory_metal</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_EXTERNAL_MEMORY_METAL_EXTENSION_NAME.html" /></remarks>
        public const string ExtExternalMemoryMetalExtensionName = "VK_EXT_external_memory_metal";
        /// <summary>[from: <b>VK_KHR_depth_clamp_zero_one</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DEPTH_CLAMP_ZERO_ONE_SPEC_VERSION.html" /></remarks>
        public const uint KhrDepthClampZeroOneSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_depth_clamp_zero_one</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_DEPTH_CLAMP_ZERO_ONE_EXTENSION_NAME.html" /></remarks>
        public const string KhrDepthClampZeroOneExtensionName = "VK_KHR_depth_clamp_zero_one";
        /// <summary>[from: <b>VK_EXT_vertex_attribute_robustness</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_VERTEX_ATTRIBUTE_ROBUSTNESS_SPEC_VERSION.html" /></remarks>
        public const uint ExtVertexAttributeRobustnessSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_vertex_attribute_robustness</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_VERTEX_ATTRIBUTE_ROBUSTNESS_EXTENSION_NAME.html" /></remarks>
        public const string ExtVertexAttributeRobustnessExtensionName = "VK_EXT_vertex_attribute_robustness";
        /// <summary>[from: <b>VK_ARM_format_pack</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_FORMAT_PACK_SPEC_VERSION.html" /></remarks>
        public const uint ArmFormatPackSpecVersion = 1;
        /// <summary>[from: <b>VK_ARM_format_pack</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_ARM_FORMAT_PACK_EXTENSION_NAME.html" /></remarks>
        public const string ArmFormatPackExtensionName = "VK_ARM_format_pack";
        /// <summary>[from: <b>VK_VALVE_fragment_density_map_layered</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_VALVE_FRAGMENT_DENSITY_MAP_LAYERED_SPEC_VERSION.html" /></remarks>
        public const uint ValveFragmentDensityMapLayeredSpecVersion = 1;
        /// <summary>[from: <b>VK_VALVE_fragment_density_map_layered</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_VALVE_FRAGMENT_DENSITY_MAP_LAYERED_EXTENSION_NAME.html" /></remarks>
        public const string ValveFragmentDensityMapLayeredExtensionName = "VK_VALVE_fragment_density_map_layered";
        /// <summary>[from: <b>VK_KHR_robustness2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_ROBUSTNESS_2_SPEC_VERSION.html" /></remarks>
        public const uint KhrRobustness2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_robustness2</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_ROBUSTNESS_2_EXTENSION_NAME.html" /></remarks>
        public const string KhrRobustness2ExtensionName = "VK_KHR_robustness2";
        /// <summary>[from: <b>VK_NV_present_metering</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_PRESENT_METERING_SPEC_VERSION.html" /></remarks>
        public const uint NvPresentMeteringSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_present_metering</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_NV_PRESENT_METERING_EXTENSION_NAME.html" /></remarks>
        public const string NvPresentMeteringExtensionName = "VK_NV_present_metering";
        /// <summary>[from: <b>VK_EXT_fragment_density_map_offset</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FRAGMENT_DENSITY_MAP_OFFSET_SPEC_VERSION.html" /></remarks>
        public const uint ExtFragmentDensityMapOffsetSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_fragment_density_map_offset</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_FRAGMENT_DENSITY_MAP_OFFSET_EXTENSION_NAME.html" /></remarks>
        public const string ExtFragmentDensityMapOffsetExtensionName = "VK_EXT_fragment_density_map_offset";
        /// <summary>[from: <b>VK_EXT_zero_initialize_device_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ZERO_INITIALIZE_DEVICE_MEMORY_SPEC_VERSION.html" /></remarks>
        public const uint ExtZeroInitializeDeviceMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_zero_initialize_device_memory</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_EXT_ZERO_INITIALIZE_DEVICE_MEMORY_EXTENSION_NAME.html" /></remarks>
        public const string ExtZeroInitializeDeviceMemoryExtensionName = "VK_EXT_zero_initialize_device_memory";
        /// <summary>[from: <b>VK_KHR_present_mode_fifo_latest_ready</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PRESENT_MODE_FIFO_LATEST_READY_SPEC_VERSION.html" /></remarks>
        public const uint KhrPresentModeFifoLatestReadySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_present_mode_fifo_latest_ready</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_KHR_PRESENT_MODE_FIFO_LATEST_READY_EXTENSION_NAME.html" /></remarks>
        public const string KhrPresentModeFifoLatestReadyExtensionName = "VK_KHR_present_mode_fifo_latest_ready";
        /// <summary>[from: <b>VK_SEC_pipeline_cache_incremental_mode</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_SEC_PIPELINE_CACHE_INCREMENTAL_MODE_SPEC_VERSION.html" /></remarks>
        public const uint SecPipelineCacheIncrementalModeSpecVersion = 1;
        /// <summary>[from: <b>VK_SEC_pipeline_cache_incremental_mode</b>]</summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VK_SEC_PIPELINE_CACHE_INCREMENTAL_MODE_EXTENSION_NAME.html" /></remarks>
        public const string SecPipelineCacheIncrementalModeExtensionName = "VK_SEC_pipeline_cache_incremental_mode";
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
