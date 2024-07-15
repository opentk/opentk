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
        public const uint MaxPhysicalDeviceNameSize = 256;
        public const uint UuidSize = 16;
        public const uint LuidSize = 8;
        public const uint LuidSizeKhr = 8;
        public const uint MaxExtensionNameSize = 256;
        public const uint MaxDescriptionSize = 256;
        public const uint MaxMemoryTypes = 32;
        /// <summary>The maximum number of unique memory heaps, each of which supporting 1 or more memory types</summary>
        public const uint MaxMemoryHeaps = 16;
        public const float LodClampNone = 1000;
        public const uint RemainingMipLevels = 4294967295;
        public const uint RemainingArrayLayers = 4294967295;
        public const uint Remaining3dSlicesExt = 4294967295;
        public const ulong WholeSize = 18446744073709551615;
        public const uint AttachmentUnused = 4294967295;
        public const uint True = 1;
        public const uint False = 0;
        public const uint QueueFamilyIgnored = 4294967295;
        public const uint QueueFamilyExternal = 4294967294;
        public const uint QueueFamilyExternalKhr = 4294967294;
        public const uint QueueFamilyForeignExt = 4294967293;
        public const uint SubpassExternal = 4294967295;
        public const uint MaxDeviceGroupSize = 32;
        public const uint MaxDeviceGroupSizeKhr = 32;
        public const uint MaxDriverNameSize = 256;
        public const uint MaxDriverNameSizeKhr = 256;
        public const uint MaxDriverInfoSize = 256;
        public const uint MaxDriverInfoSizeKhr = 256;
        public const uint ShaderUnusedKhr = 4294967295;
        public const uint ShaderUnusedNv = 4294967295;
        public const uint MaxGlobalPrioritySizeKhr = 16;
        public const uint MaxGlobalPrioritySizeExt = 16;
        public const uint MaxShaderModuleIdentifierSizeExt = 32;
        public const uint MaxVideoAv1ReferencesPerFrameKhr = 7;
        public const uint ShaderIndexUnusedAmdx = 4294967295;
        /// <summary>[from: <b>VK_KHR_surface</b>]</summary>
        public const uint KhrSurfaceSpecVersion = 25;
        /// <summary>[from: <b>VK_KHR_surface</b>]</summary>
        public const string KhrSurfaceExtensionName = "VK_KHR_surface";
        /// <summary>[from: <b>VK_KHR_swapchain</b>]</summary>
        public const uint KhrSwapchainSpecVersion = 70;
        /// <summary>[from: <b>VK_KHR_swapchain</b>]</summary>
        public const string KhrSwapchainExtensionName = "VK_KHR_swapchain";
        /// <summary>[from: <b>VK_KHR_display</b>]</summary>
        public const uint KhrDisplaySpecVersion = 23;
        /// <summary>[from: <b>VK_KHR_display</b>]</summary>
        public const string KhrDisplayExtensionName = "VK_KHR_display";
        /// <summary>[from: <b>VK_KHR_display_swapchain</b>]</summary>
        public const uint KhrDisplaySwapchainSpecVersion = 10;
        /// <summary>[from: <b>VK_KHR_display_swapchain</b>]</summary>
        public const string KhrDisplaySwapchainExtensionName = "VK_KHR_display_swapchain";
        /// <summary>[from: <b>VK_KHR_xlib_surface</b>]</summary>
        public const uint KhrXlibSurfaceSpecVersion = 6;
        /// <summary>[from: <b>VK_KHR_xlib_surface</b>]</summary>
        public const string KhrXlibSurfaceExtensionName = "VK_KHR_xlib_surface";
        /// <summary>[from: <b>VK_KHR_xcb_surface</b>]</summary>
        public const uint KhrXcbSurfaceSpecVersion = 6;
        /// <summary>[from: <b>VK_KHR_xcb_surface</b>]</summary>
        public const string KhrXcbSurfaceExtensionName = "VK_KHR_xcb_surface";
        /// <summary>[from: <b>VK_KHR_wayland_surface</b>]</summary>
        public const uint KhrWaylandSurfaceSpecVersion = 6;
        /// <summary>[from: <b>VK_KHR_wayland_surface</b>]</summary>
        public const string KhrWaylandSurfaceExtensionName = "VK_KHR_wayland_surface";
        /// <summary>[from: <b>VK_KHR_android_surface</b>]</summary>
        public const uint KhrAndroidSurfaceSpecVersion = 6;
        /// <summary>[from: <b>VK_KHR_android_surface</b>]</summary>
        public const string KhrAndroidSurfaceExtensionName = "VK_KHR_android_surface";
        /// <summary>[from: <b>VK_KHR_win32_surface</b>]</summary>
        public const uint KhrWin32SurfaceSpecVersion = 6;
        /// <summary>[from: <b>VK_KHR_win32_surface</b>]</summary>
        public const string KhrWin32SurfaceExtensionName = "VK_KHR_win32_surface";
        /// <summary>[from: <b>VK_EXT_debug_report</b>]</summary>
        public const uint ExtDebugReportSpecVersion = 10;
        /// <summary>[from: <b>VK_EXT_debug_report</b>]</summary>
        public const string ExtDebugReportExtensionName = "VK_EXT_debug_report";
        /// <summary>[from: <b>VK_NV_glsl_shader</b>]</summary>
        public const uint NvGlslShaderSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_glsl_shader</b>]</summary>
        public const string NvGlslShaderExtensionName = "VK_NV_glsl_shader";
        /// <summary>[from: <b>VK_EXT_depth_range_unrestricted</b>]</summary>
        public const uint ExtDepthRangeUnrestrictedSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_depth_range_unrestricted</b>]</summary>
        public const string ExtDepthRangeUnrestrictedExtensionName = "VK_EXT_depth_range_unrestricted";
        /// <summary>[from: <b>VK_KHR_sampler_mirror_clamp_to_edge</b>]</summary>
        public const uint KhrSamplerMirrorClampToEdgeSpecVersion = 3;
        /// <summary>[from: <b>VK_KHR_sampler_mirror_clamp_to_edge</b>]</summary>
        public const string KhrSamplerMirrorClampToEdgeExtensionName = "VK_KHR_sampler_mirror_clamp_to_edge";
        /// <summary>[from: <b>VK_IMG_filter_cubic</b>]</summary>
        public const uint ImgFilterCubicSpecVersion = 1;
        /// <summary>[from: <b>VK_IMG_filter_cubic</b>]</summary>
        public const string ImgFilterCubicExtensionName = "VK_IMG_filter_cubic";
        /// <summary>[from: <b>VK_AMD_rasterization_order</b>]</summary>
        public const uint AmdRasterizationOrderSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_rasterization_order</b>]</summary>
        public const string AmdRasterizationOrderExtensionName = "VK_AMD_rasterization_order";
        /// <summary>[from: <b>VK_AMD_shader_trinary_minmax</b>]</summary>
        public const uint AmdShaderTrinaryMinmaxSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_trinary_minmax</b>]</summary>
        public const string AmdShaderTrinaryMinmaxExtensionName = "VK_AMD_shader_trinary_minmax";
        /// <summary>[from: <b>VK_AMD_shader_explicit_vertex_parameter</b>]</summary>
        public const uint AmdShaderExplicitVertexParameterSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_explicit_vertex_parameter</b>]</summary>
        public const string AmdShaderExplicitVertexParameterExtensionName = "VK_AMD_shader_explicit_vertex_parameter";
        /// <summary>[from: <b>VK_EXT_debug_marker</b>]</summary>
        public const uint ExtDebugMarkerSpecVersion = 4;
        /// <summary>[from: <b>VK_EXT_debug_marker</b>]</summary>
        public const string ExtDebugMarkerExtensionName = "VK_EXT_debug_marker";
        /// <summary>[from: <b>VK_KHR_video_queue</b>]</summary>
        public const uint KhrVideoQueueSpecVersion = 8;
        /// <summary>[from: <b>VK_KHR_video_queue</b>]</summary>
        public const string KhrVideoQueueExtensionName = "VK_KHR_video_queue";
        /// <summary>[from: <b>VK_KHR_video_decode_queue</b>]</summary>
        public const uint KhrVideoDecodeQueueSpecVersion = 8;
        /// <summary>[from: <b>VK_KHR_video_decode_queue</b>]</summary>
        public const string KhrVideoDecodeQueueExtensionName = "VK_KHR_video_decode_queue";
        /// <summary>[from: <b>VK_AMD_gcn_shader</b>]</summary>
        public const uint AmdGcnShaderSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_gcn_shader</b>]</summary>
        public const string AmdGcnShaderExtensionName = "VK_AMD_gcn_shader";
        /// <summary>[from: <b>VK_NV_dedicated_allocation</b>]</summary>
        public const uint NvDedicatedAllocationSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_dedicated_allocation</b>]</summary>
        public const string NvDedicatedAllocationExtensionName = "VK_NV_dedicated_allocation";
        /// <summary>[from: <b>VK_EXT_transform_feedback</b>]</summary>
        public const uint ExtTransformFeedbackSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_transform_feedback</b>]</summary>
        public const string ExtTransformFeedbackExtensionName = "VK_EXT_transform_feedback";
        /// <summary>[from: <b>VK_NVX_binary_import</b>]</summary>
        public const uint NvxBinaryImportSpecVersion = 1;
        /// <summary>[from: <b>VK_NVX_binary_import</b>]</summary>
        public const string NvxBinaryImportExtensionName = "VK_NVX_binary_import";
        /// <summary>[from: <b>VK_NVX_image_view_handle</b>]</summary>
        public const uint NvxImageViewHandleSpecVersion = 2;
        /// <summary>[from: <b>VK_NVX_image_view_handle</b>]</summary>
        public const string NvxImageViewHandleExtensionName = "VK_NVX_image_view_handle";
        /// <summary>[from: <b>VK_AMD_draw_indirect_count</b>]</summary>
        public const uint AmdDrawIndirectCountSpecVersion = 2;
        /// <summary>[from: <b>VK_AMD_draw_indirect_count</b>]</summary>
        public const string AmdDrawIndirectCountExtensionName = "VK_AMD_draw_indirect_count";
        /// <summary>[from: <b>VK_AMD_negative_viewport_height</b>]</summary>
        public const uint AmdNegativeViewportHeightSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_negative_viewport_height</b>]</summary>
        public const string AmdNegativeViewportHeightExtensionName = "VK_AMD_negative_viewport_height";
        /// <summary>[from: <b>VK_AMD_gpu_shader_half_float</b>]</summary>
        public const uint AmdGpuShaderHalfFloatSpecVersion = 2;
        /// <summary>[from: <b>VK_AMD_gpu_shader_half_float</b>]</summary>
        public const string AmdGpuShaderHalfFloatExtensionName = "VK_AMD_gpu_shader_half_float";
        /// <summary>[from: <b>VK_AMD_shader_ballot</b>]</summary>
        public const uint AmdShaderBallotSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_ballot</b>]</summary>
        public const string AmdShaderBallotExtensionName = "VK_AMD_shader_ballot";
        /// <summary>[from: <b>VK_KHR_video_encode_h264</b>]</summary>
        public const uint KhrVideoEncodeH264SpecVersion = 14;
        /// <summary>[from: <b>VK_KHR_video_encode_h264</b>]</summary>
        public const string KhrVideoEncodeH264ExtensionName = "VK_KHR_video_encode_h264";
        /// <summary>[from: <b>VK_KHR_video_encode_h265</b>]</summary>
        public const uint KhrVideoEncodeH265SpecVersion = 14;
        /// <summary>[from: <b>VK_KHR_video_encode_h265</b>]</summary>
        public const string KhrVideoEncodeH265ExtensionName = "VK_KHR_video_encode_h265";
        /// <summary>[from: <b>VK_KHR_video_decode_h264</b>]</summary>
        public const uint KhrVideoDecodeH264SpecVersion = 9;
        /// <summary>[from: <b>VK_KHR_video_decode_h264</b>]</summary>
        public const string KhrVideoDecodeH264ExtensionName = "VK_KHR_video_decode_h264";
        /// <summary>[from: <b>VK_AMD_texture_gather_bias_lod</b>]</summary>
        public const uint AmdTextureGatherBiasLodSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_texture_gather_bias_lod</b>]</summary>
        public const string AmdTextureGatherBiasLodExtensionName = "VK_AMD_texture_gather_bias_lod";
        /// <summary>[from: <b>VK_AMD_shader_info</b>]</summary>
        public const uint AmdShaderInfoSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_info</b>]</summary>
        public const string AmdShaderInfoExtensionName = "VK_AMD_shader_info";
        /// <summary>[from: <b>VK_KHR_dynamic_rendering</b>]</summary>
        public const uint KhrDynamicRenderingSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_dynamic_rendering</b>]</summary>
        public const string KhrDynamicRenderingExtensionName = "VK_KHR_dynamic_rendering";
        /// <summary>[from: <b>VK_AMD_shader_image_load_store_lod</b>]</summary>
        public const uint AmdShaderImageLoadStoreLodSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_image_load_store_lod</b>]</summary>
        public const string AmdShaderImageLoadStoreLodExtensionName = "VK_AMD_shader_image_load_store_lod";
        /// <summary>[from: <b>VK_GGP_stream_descriptor_surface</b>]</summary>
        public const uint GgpStreamDescriptorSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_GGP_stream_descriptor_surface</b>]</summary>
        public const string GgpStreamDescriptorSurfaceExtensionName = "VK_GGP_stream_descriptor_surface";
        /// <summary>[from: <b>VK_NV_corner_sampled_image</b>]</summary>
        public const uint NvCornerSampledImageSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_corner_sampled_image</b>]</summary>
        public const string NvCornerSampledImageExtensionName = "VK_NV_corner_sampled_image";
        /// <summary>[from: <b>VK_NV_private_vendor_info</b>]</summary>
        public const uint NvPrivateVendorInfoSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_private_vendor_info</b>]</summary>
        public const string NvPrivateVendorInfoExtensionName = "VK_NV_private_vendor_info";
        /// <summary>[from: <b>VK_KHR_multiview</b>]</summary>
        public const uint KhrMultiviewSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_multiview</b>]</summary>
        public const string KhrMultiviewExtensionName = "VK_KHR_multiview";
        /// <summary>[from: <b>VK_IMG_format_pvrtc</b>]</summary>
        public const uint ImgFormatPvrtcSpecVersion = 1;
        /// <summary>[from: <b>VK_IMG_format_pvrtc</b>]</summary>
        public const string ImgFormatPvrtcExtensionName = "VK_IMG_format_pvrtc";
        /// <summary>[from: <b>VK_NV_external_memory_capabilities</b>]</summary>
        public const uint NvExternalMemoryCapabilitiesSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_external_memory_capabilities</b>]</summary>
        public const string NvExternalMemoryCapabilitiesExtensionName = "VK_NV_external_memory_capabilities";
        /// <summary>[from: <b>VK_NV_external_memory</b>]</summary>
        public const uint NvExternalMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_NV_external_memory</b>]</summary>
        public const string NvExternalMemoryExtensionName = "VK_NV_external_memory";
        /// <summary>[from: <b>VK_NV_external_memory_win32</b>]</summary>
        public const uint NvExternalMemoryWin32SpecVersion = 1;
        /// <summary>[from: <b>VK_NV_external_memory_win32</b>]</summary>
        public const string NvExternalMemoryWin32ExtensionName = "VK_NV_external_memory_win32";
        /// <summary>[from: <b>VK_NV_win32_keyed_mutex</b>]</summary>
        public const uint NvWin32KeyedMutexSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_win32_keyed_mutex</b>]</summary>
        public const string NvWin32KeyedMutexExtensionName = "VK_NV_win32_keyed_mutex";
        /// <summary>[from: <b>VK_KHR_get_physical_device_properties2</b>]</summary>
        public const uint KhrGetPhysicalDeviceProperties2SpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_get_physical_device_properties2</b>]</summary>
        public const string KhrGetPhysicalDeviceProperties2ExtensionName = "VK_KHR_get_physical_device_properties2";
        /// <summary>[from: <b>VK_KHR_device_group</b>]</summary>
        public const uint KhrDeviceGroupSpecVersion = 4;
        /// <summary>[from: <b>VK_KHR_device_group</b>]</summary>
        public const string KhrDeviceGroupExtensionName = "VK_KHR_device_group";
        /// <summary>[from: <b>VK_EXT_validation_flags</b>]</summary>
        public const uint ExtValidationFlagsSpecVersion = 3;
        /// <summary>[from: <b>VK_EXT_validation_flags</b>]</summary>
        public const string ExtValidationFlagsExtensionName = "VK_EXT_validation_flags";
        /// <summary>[from: <b>VK_NN_vi_surface</b>]</summary>
        public const uint NnViSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_NN_vi_surface</b>]</summary>
        public const string NnViSurfaceExtensionName = "VK_NN_vi_surface";
        /// <summary>[from: <b>VK_KHR_shader_draw_parameters</b>]</summary>
        public const uint KhrShaderDrawParametersSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_draw_parameters</b>]</summary>
        public const string KhrShaderDrawParametersExtensionName = "VK_KHR_shader_draw_parameters";
        /// <summary>[from: <b>VK_EXT_shader_subgroup_ballot</b>]</summary>
        public const uint ExtShaderSubgroupBallotSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_subgroup_ballot</b>]</summary>
        public const string ExtShaderSubgroupBallotExtensionName = "VK_EXT_shader_subgroup_ballot";
        /// <summary>[from: <b>VK_EXT_shader_subgroup_vote</b>]</summary>
        public const uint ExtShaderSubgroupVoteSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_subgroup_vote</b>]</summary>
        public const string ExtShaderSubgroupVoteExtensionName = "VK_EXT_shader_subgroup_vote";
        /// <summary>[from: <b>VK_EXT_texture_compression_astc_hdr</b>]</summary>
        public const uint ExtTextureCompressionAstcHdrSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_texture_compression_astc_hdr</b>]</summary>
        public const string ExtTextureCompressionAstcHdrExtensionName = "VK_EXT_texture_compression_astc_hdr";
        /// <summary>[from: <b>VK_EXT_astc_decode_mode</b>]</summary>
        public const uint ExtAstcDecodeModeSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_astc_decode_mode</b>]</summary>
        public const string ExtAstcDecodeModeExtensionName = "VK_EXT_astc_decode_mode";
        /// <summary>[from: <b>VK_EXT_pipeline_robustness</b>]</summary>
        public const uint ExtPipelineRobustnessSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_pipeline_robustness</b>]</summary>
        public const string ExtPipelineRobustnessExtensionName = "VK_EXT_pipeline_robustness";
        /// <summary>[from: <b>VK_KHR_maintenance1</b>]</summary>
        public const uint KhrMaintenance1SpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_maintenance1</b>]</summary>
        public const string KhrMaintenance1ExtensionName = "VK_KHR_maintenance1";
        /// <summary>[from: <b>VK_KHR_device_group_creation</b>]</summary>
        public const uint KhrDeviceGroupCreationSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_device_group_creation</b>]</summary>
        public const string KhrDeviceGroupCreationExtensionName = "VK_KHR_device_group_creation";
        /// <summary>[from: <b>VK_KHR_external_memory_capabilities</b>]</summary>
        public const uint KhrExternalMemoryCapabilitiesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_memory_capabilities</b>]</summary>
        public const string KhrExternalMemoryCapabilitiesExtensionName = "VK_KHR_external_memory_capabilities";
        /// <summary>[from: <b>VK_KHR_external_memory</b>]</summary>
        public const uint KhrExternalMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_memory</b>]</summary>
        public const string KhrExternalMemoryExtensionName = "VK_KHR_external_memory";
        /// <summary>[from: <b>VK_KHR_external_memory_win32</b>]</summary>
        public const uint KhrExternalMemoryWin32SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_memory_win32</b>]</summary>
        public const string KhrExternalMemoryWin32ExtensionName = "VK_KHR_external_memory_win32";
        /// <summary>[from: <b>VK_KHR_external_memory_fd</b>]</summary>
        public const uint KhrExternalMemoryFdSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_memory_fd</b>]</summary>
        public const string KhrExternalMemoryFdExtensionName = "VK_KHR_external_memory_fd";
        /// <summary>[from: <b>VK_KHR_win32_keyed_mutex</b>]</summary>
        public const uint KhrWin32KeyedMutexSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_win32_keyed_mutex</b>]</summary>
        public const string KhrWin32KeyedMutexExtensionName = "VK_KHR_win32_keyed_mutex";
        /// <summary>[from: <b>VK_KHR_external_semaphore_capabilities</b>]</summary>
        public const uint KhrExternalSemaphoreCapabilitiesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_semaphore_capabilities</b>]</summary>
        public const string KhrExternalSemaphoreCapabilitiesExtensionName = "VK_KHR_external_semaphore_capabilities";
        /// <summary>[from: <b>VK_KHR_external_semaphore</b>]</summary>
        public const uint KhrExternalSemaphoreSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_semaphore</b>]</summary>
        public const string KhrExternalSemaphoreExtensionName = "VK_KHR_external_semaphore";
        /// <summary>[from: <b>VK_KHR_external_semaphore_win32</b>]</summary>
        public const uint KhrExternalSemaphoreWin32SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_semaphore_win32</b>]</summary>
        public const string KhrExternalSemaphoreWin32ExtensionName = "VK_KHR_external_semaphore_win32";
        /// <summary>[from: <b>VK_KHR_external_semaphore_fd</b>]</summary>
        public const uint KhrExternalSemaphoreFdSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_semaphore_fd</b>]</summary>
        public const string KhrExternalSemaphoreFdExtensionName = "VK_KHR_external_semaphore_fd";
        /// <summary>[from: <b>VK_KHR_push_descriptor</b>]</summary>
        public const uint KhrPushDescriptorSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_push_descriptor</b>]</summary>
        public const string KhrPushDescriptorExtensionName = "VK_KHR_push_descriptor";
        /// <summary>[from: <b>VK_EXT_conditional_rendering</b>]</summary>
        public const uint ExtConditionalRenderingSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_conditional_rendering</b>]</summary>
        public const string ExtConditionalRenderingExtensionName = "VK_EXT_conditional_rendering";
        /// <summary>[from: <b>VK_KHR_shader_float16_int8</b>]</summary>
        public const uint KhrShaderFloat16Int8SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_float16_int8</b>]</summary>
        public const string KhrShaderFloat16Int8ExtensionName = "VK_KHR_shader_float16_int8";
        /// <summary>[from: <b>VK_KHR_16bit_storage</b>]</summary>
        public const uint Khr16bitStorageSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_16bit_storage</b>]</summary>
        public const string Khr16bitStorageExtensionName = "VK_KHR_16bit_storage";
        /// <summary>[from: <b>VK_KHR_incremental_present</b>]</summary>
        public const uint KhrIncrementalPresentSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_incremental_present</b>]</summary>
        public const string KhrIncrementalPresentExtensionName = "VK_KHR_incremental_present";
        /// <summary>[from: <b>VK_KHR_descriptor_update_template</b>]</summary>
        public const uint KhrDescriptorUpdateTemplateSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_descriptor_update_template</b>]</summary>
        public const string KhrDescriptorUpdateTemplateExtensionName = "VK_KHR_descriptor_update_template";
        /// <summary>[from: <b>VK_NV_clip_space_w_scaling</b>]</summary>
        public const uint NvClipSpaceWScalingSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_clip_space_w_scaling</b>]</summary>
        public const string NvClipSpaceWScalingExtensionName = "VK_NV_clip_space_w_scaling";
        /// <summary>[from: <b>VK_EXT_direct_mode_display</b>]</summary>
        public const uint ExtDirectModeDisplaySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_direct_mode_display</b>]</summary>
        public const string ExtDirectModeDisplayExtensionName = "VK_EXT_direct_mode_display";
        /// <summary>[from: <b>VK_EXT_acquire_xlib_display</b>]</summary>
        public const uint ExtAcquireXlibDisplaySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_acquire_xlib_display</b>]</summary>
        public const string ExtAcquireXlibDisplayExtensionName = "VK_EXT_acquire_xlib_display";
        /// <summary>[from: <b>VK_EXT_display_surface_counter</b>]</summary>
        public const uint ExtDisplaySurfaceCounterSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_display_surface_counter</b>]</summary>
        public const string ExtDisplaySurfaceCounterExtensionName = "VK_EXT_display_surface_counter";
        /// <summary>[from: <b>VK_EXT_display_control</b>]</summary>
        public const uint ExtDisplayControlSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_display_control</b>]</summary>
        public const string ExtDisplayControlExtensionName = "VK_EXT_display_control";
        /// <summary>[from: <b>VK_GOOGLE_display_timing</b>]</summary>
        public const uint GoogleDisplayTimingSpecVersion = 1;
        /// <summary>[from: <b>VK_GOOGLE_display_timing</b>]</summary>
        public const string GoogleDisplayTimingExtensionName = "VK_GOOGLE_display_timing";
        /// <summary>[from: <b>VK_NV_sample_mask_override_coverage</b>]</summary>
        public const uint NvSampleMaskOverrideCoverageSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_sample_mask_override_coverage</b>]</summary>
        public const string NvSampleMaskOverrideCoverageExtensionName = "VK_NV_sample_mask_override_coverage";
        /// <summary>[from: <b>VK_NV_geometry_shader_passthrough</b>]</summary>
        public const uint NvGeometryShaderPassthroughSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_geometry_shader_passthrough</b>]</summary>
        public const string NvGeometryShaderPassthroughExtensionName = "VK_NV_geometry_shader_passthrough";
        /// <summary>[from: <b>VK_NV_viewport_array2</b>]</summary>
        public const uint NvViewportArray2SpecVersion = 1;
        /// <summary>[from: <b>VK_NV_viewport_array2</b>]</summary>
        public const string NvViewportArray2ExtensionName = "VK_NV_viewport_array2";
        /// <summary>[from: <b>VK_NVX_multiview_per_view_attributes</b>]</summary>
        public const uint NvxMultiviewPerViewAttributesSpecVersion = 1;
        /// <summary>[from: <b>VK_NVX_multiview_per_view_attributes</b>]</summary>
        public const string NvxMultiviewPerViewAttributesExtensionName = "VK_NVX_multiview_per_view_attributes";
        /// <summary>[from: <b>VK_NV_viewport_swizzle</b>]</summary>
        public const uint NvViewportSwizzleSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_viewport_swizzle</b>]</summary>
        public const string NvViewportSwizzleExtensionName = "VK_NV_viewport_swizzle";
        /// <summary>[from: <b>VK_EXT_discard_rectangles</b>]</summary>
        public const uint ExtDiscardRectanglesSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_discard_rectangles</b>]</summary>
        public const string ExtDiscardRectanglesExtensionName = "VK_EXT_discard_rectangles";
        /// <summary>[from: <b>VK_EXT_conservative_rasterization</b>]</summary>
        public const uint ExtConservativeRasterizationSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_conservative_rasterization</b>]</summary>
        public const string ExtConservativeRasterizationExtensionName = "VK_EXT_conservative_rasterization";
        /// <summary>[from: <b>VK_EXT_depth_clip_enable</b>]</summary>
        public const uint ExtDepthClipEnableSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_depth_clip_enable</b>]</summary>
        public const string ExtDepthClipEnableExtensionName = "VK_EXT_depth_clip_enable";
        /// <summary>[from: <b>VK_EXT_swapchain_colorspace</b>]</summary>
        public const uint ExtSwapchainColorSpaceSpecVersion = 4;
        /// <summary>[from: <b>VK_EXT_swapchain_colorspace</b>]</summary>
        public const string ExtSwapchainColorSpaceExtensionName = "VK_EXT_swapchain_colorspace";
        /// <summary>[from: <b>VK_EXT_hdr_metadata</b>]</summary>
        public const uint ExtHdrMetadataSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_hdr_metadata</b>]</summary>
        public const string ExtHdrMetadataExtensionName = "VK_EXT_hdr_metadata";
        /// <summary>[from: <b>VK_KHR_imageless_framebuffer</b>]</summary>
        public const uint KhrImagelessFramebufferSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_imageless_framebuffer</b>]</summary>
        public const string KhrImagelessFramebufferExtensionName = "VK_KHR_imageless_framebuffer";
        /// <summary>[from: <b>VK_KHR_create_renderpass2</b>]</summary>
        public const uint KhrCreateRenderpass2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_create_renderpass2</b>]</summary>
        public const string KhrCreateRenderpass2ExtensionName = "VK_KHR_create_renderpass2";
        /// <summary>[from: <b>VK_IMG_relaxed_line_rasterization</b>]</summary>
        public const uint ImgRelaxedLineRasterizationSpecVersion = 1;
        /// <summary>[from: <b>VK_IMG_relaxed_line_rasterization</b>]</summary>
        public const string ImgRelaxedLineRasterizationExtensionName = "VK_IMG_relaxed_line_rasterization";
        /// <summary>[from: <b>VK_KHR_shared_presentable_image</b>]</summary>
        public const uint KhrSharedPresentableImageSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shared_presentable_image</b>]</summary>
        public const string KhrSharedPresentableImageExtensionName = "VK_KHR_shared_presentable_image";
        /// <summary>[from: <b>VK_KHR_external_fence_capabilities</b>]</summary>
        public const uint KhrExternalFenceCapabilitiesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_fence_capabilities</b>]</summary>
        public const string KhrExternalFenceCapabilitiesExtensionName = "VK_KHR_external_fence_capabilities";
        /// <summary>[from: <b>VK_KHR_external_fence</b>]</summary>
        public const uint KhrExternalFenceSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_fence</b>]</summary>
        public const string KhrExternalFenceExtensionName = "VK_KHR_external_fence";
        /// <summary>[from: <b>VK_KHR_external_fence_win32</b>]</summary>
        public const uint KhrExternalFenceWin32SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_fence_win32</b>]</summary>
        public const string KhrExternalFenceWin32ExtensionName = "VK_KHR_external_fence_win32";
        /// <summary>[from: <b>VK_KHR_external_fence_fd</b>]</summary>
        public const uint KhrExternalFenceFdSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_external_fence_fd</b>]</summary>
        public const string KhrExternalFenceFdExtensionName = "VK_KHR_external_fence_fd";
        /// <summary>[from: <b>VK_KHR_performance_query</b>]</summary>
        public const uint KhrPerformanceQuerySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_performance_query</b>]</summary>
        public const string KhrPerformanceQueryExtensionName = "VK_KHR_performance_query";
        /// <summary>[from: <b>VK_KHR_maintenance2</b>]</summary>
        public const uint KhrMaintenance2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_maintenance2</b>]</summary>
        public const string KhrMaintenance2ExtensionName = "VK_KHR_maintenance2";
        /// <summary>[from: <b>VK_KHR_get_surface_capabilities2</b>]</summary>
        public const uint KhrGetSurfaceCapabilities2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_get_surface_capabilities2</b>]</summary>
        public const string KhrGetSurfaceCapabilities2ExtensionName = "VK_KHR_get_surface_capabilities2";
        /// <summary>[from: <b>VK_KHR_variable_pointers</b>]</summary>
        public const uint KhrVariablePointersSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_variable_pointers</b>]</summary>
        public const string KhrVariablePointersExtensionName = "VK_KHR_variable_pointers";
        /// <summary>[from: <b>VK_KHR_get_display_properties2</b>]</summary>
        public const uint KhrGetDisplayProperties2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_get_display_properties2</b>]</summary>
        public const string KhrGetDisplayProperties2ExtensionName = "VK_KHR_get_display_properties2";
        /// <summary>[from: <b>VK_MVK_ios_surface</b>]</summary>
        public const uint MvkIosSurfaceSpecVersion = 3;
        /// <summary>[from: <b>VK_MVK_ios_surface</b>]</summary>
        public const string MvkIosSurfaceExtensionName = "VK_MVK_ios_surface";
        /// <summary>[from: <b>VK_MVK_macos_surface</b>]</summary>
        public const uint MvkMacosSurfaceSpecVersion = 3;
        /// <summary>[from: <b>VK_MVK_macos_surface</b>]</summary>
        public const string MvkMacosSurfaceExtensionName = "VK_MVK_macos_surface";
        /// <summary>[from: <b>VK_EXT_external_memory_dma_buf</b>]</summary>
        public const uint ExtExternalMemoryDmaBufSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_external_memory_dma_buf</b>]</summary>
        public const string ExtExternalMemoryDmaBufExtensionName = "VK_EXT_external_memory_dma_buf";
        /// <summary>[from: <b>VK_EXT_queue_family_foreign</b>]</summary>
        public const uint ExtQueueFamilyForeignSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_queue_family_foreign</b>]</summary>
        public const string ExtQueueFamilyForeignExtensionName = "VK_EXT_queue_family_foreign";
        /// <summary>[from: <b>VK_KHR_dedicated_allocation</b>]</summary>
        public const uint KhrDedicatedAllocationSpecVersion = 3;
        /// <summary>[from: <b>VK_KHR_dedicated_allocation</b>]</summary>
        public const string KhrDedicatedAllocationExtensionName = "VK_KHR_dedicated_allocation";
        /// <summary>[from: <b>VK_EXT_debug_utils</b>]</summary>
        public const uint ExtDebugUtilsSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_debug_utils</b>]</summary>
        public const string ExtDebugUtilsExtensionName = "VK_EXT_debug_utils";
        /// <summary>[from: <b>VK_ANDROID_external_memory_android_hardware_buffer</b>]</summary>
        public const uint AndroidExternalMemoryAndroidHardwareBufferSpecVersion = 5;
        /// <summary>[from: <b>VK_ANDROID_external_memory_android_hardware_buffer</b>]</summary>
        public const string AndroidExternalMemoryAndroidHardwareBufferExtensionName = "VK_ANDROID_external_memory_android_hardware_buffer";
        /// <summary>[from: <b>VK_EXT_sampler_filter_minmax</b>]</summary>
        public const uint ExtSamplerFilterMinmaxSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_sampler_filter_minmax</b>]</summary>
        public const string ExtSamplerFilterMinmaxExtensionName = "VK_EXT_sampler_filter_minmax";
        /// <summary>[from: <b>VK_KHR_storage_buffer_storage_class</b>]</summary>
        public const uint KhrStorageBufferStorageClassSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_storage_buffer_storage_class</b>]</summary>
        public const string KhrStorageBufferStorageClassExtensionName = "VK_KHR_storage_buffer_storage_class";
        /// <summary>[from: <b>VK_AMD_gpu_shader_int16</b>]</summary>
        public const uint AmdGpuShaderInt16SpecVersion = 2;
        /// <summary>[from: <b>VK_AMD_gpu_shader_int16</b>]</summary>
        public const string AmdGpuShaderInt16ExtensionName = "VK_AMD_gpu_shader_int16";
        /// <summary>[from: <b>VK_AMDX_shader_enqueue</b>]</summary>
        public const uint AmdxShaderEnqueueSpecVersion = 1;
        /// <summary>[from: <b>VK_AMDX_shader_enqueue</b>]</summary>
        public const string AmdxShaderEnqueueExtensionName = "VK_AMDX_shader_enqueue";
        /// <summary>[from: <b>VK_AMD_mixed_attachment_samples</b>]</summary>
        public const uint AmdMixedAttachmentSamplesSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_mixed_attachment_samples</b>]</summary>
        public const string AmdMixedAttachmentSamplesExtensionName = "VK_AMD_mixed_attachment_samples";
        /// <summary>[from: <b>VK_AMD_shader_fragment_mask</b>]</summary>
        public const uint AmdShaderFragmentMaskSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_fragment_mask</b>]</summary>
        public const string AmdShaderFragmentMaskExtensionName = "VK_AMD_shader_fragment_mask";
        /// <summary>[from: <b>VK_EXT_inline_uniform_block</b>]</summary>
        public const uint ExtInlineUniformBlockSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_inline_uniform_block</b>]</summary>
        public const string ExtInlineUniformBlockExtensionName = "VK_EXT_inline_uniform_block";
        /// <summary>[from: <b>VK_EXT_shader_stencil_export</b>]</summary>
        public const uint ExtShaderStencilExportSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_stencil_export</b>]</summary>
        public const string ExtShaderStencilExportExtensionName = "VK_EXT_shader_stencil_export";
        /// <summary>[from: <b>VK_EXT_sample_locations</b>]</summary>
        public const uint ExtSampleLocationsSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_sample_locations</b>]</summary>
        public const string ExtSampleLocationsExtensionName = "VK_EXT_sample_locations";
        /// <summary>[from: <b>VK_KHR_relaxed_block_layout</b>]</summary>
        public const uint KhrRelaxedBlockLayoutSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_relaxed_block_layout</b>]</summary>
        public const string KhrRelaxedBlockLayoutExtensionName = "VK_KHR_relaxed_block_layout";
        /// <summary>[from: <b>VK_KHR_get_memory_requirements2</b>]</summary>
        public const uint KhrGetMemoryRequirements2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_get_memory_requirements2</b>]</summary>
        public const string KhrGetMemoryRequirements2ExtensionName = "VK_KHR_get_memory_requirements2";
        /// <summary>[from: <b>VK_KHR_image_format_list</b>]</summary>
        public const uint KhrImageFormatListSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_image_format_list</b>]</summary>
        public const string KhrImageFormatListExtensionName = "VK_KHR_image_format_list";
        /// <summary>[from: <b>VK_EXT_blend_operation_advanced</b>]</summary>
        public const uint ExtBlendOperationAdvancedSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_blend_operation_advanced</b>]</summary>
        public const string ExtBlendOperationAdvancedExtensionName = "VK_EXT_blend_operation_advanced";
        /// <summary>[from: <b>VK_NV_fragment_coverage_to_color</b>]</summary>
        public const uint NvFragmentCoverageToColorSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_fragment_coverage_to_color</b>]</summary>
        public const string NvFragmentCoverageToColorExtensionName = "VK_NV_fragment_coverage_to_color";
        /// <summary>[from: <b>VK_KHR_acceleration_structure</b>]</summary>
        public const uint KhrAccelerationStructureSpecVersion = 13;
        /// <summary>[from: <b>VK_KHR_acceleration_structure</b>]</summary>
        public const string KhrAccelerationStructureExtensionName = "VK_KHR_acceleration_structure";
        /// <summary>[from: <b>VK_KHR_ray_tracing_pipeline</b>]</summary>
        public const uint KhrRayTracingPipelineSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_ray_tracing_pipeline</b>]</summary>
        public const string KhrRayTracingPipelineExtensionName = "VK_KHR_ray_tracing_pipeline";
        /// <summary>[from: <b>VK_KHR_ray_query</b>]</summary>
        public const uint KhrRayQuerySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_ray_query</b>]</summary>
        public const string KhrRayQueryExtensionName = "VK_KHR_ray_query";
        /// <summary>[from: <b>VK_NV_framebuffer_mixed_samples</b>]</summary>
        public const uint NvFramebufferMixedSamplesSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_framebuffer_mixed_samples</b>]</summary>
        public const string NvFramebufferMixedSamplesExtensionName = "VK_NV_framebuffer_mixed_samples";
        /// <summary>[from: <b>VK_NV_fill_rectangle</b>]</summary>
        public const uint NvFillRectangleSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_fill_rectangle</b>]</summary>
        public const string NvFillRectangleExtensionName = "VK_NV_fill_rectangle";
        /// <summary>[from: <b>VK_NV_shader_sm_builtins</b>]</summary>
        public const uint NvShaderSmBuiltinsSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_shader_sm_builtins</b>]</summary>
        public const string NvShaderSmBuiltinsExtensionName = "VK_NV_shader_sm_builtins";
        /// <summary>[from: <b>VK_EXT_post_depth_coverage</b>]</summary>
        public const uint ExtPostDepthCoverageSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_post_depth_coverage</b>]</summary>
        public const string ExtPostDepthCoverageExtensionName = "VK_EXT_post_depth_coverage";
        /// <summary>[from: <b>VK_KHR_sampler_ycbcr_conversion</b>]</summary>
        public const uint KhrSamplerYcbcrConversionSpecVersion = 14;
        /// <summary>[from: <b>VK_KHR_sampler_ycbcr_conversion</b>]</summary>
        public const string KhrSamplerYcbcrConversionExtensionName = "VK_KHR_sampler_ycbcr_conversion";
        /// <summary>[from: <b>VK_KHR_bind_memory2</b>]</summary>
        public const uint KhrBindMemory2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_bind_memory2</b>]</summary>
        public const string KhrBindMemory2ExtensionName = "VK_KHR_bind_memory2";
        /// <summary>[from: <b>VK_EXT_image_drm_format_modifier</b>]</summary>
        public const uint ExtImageDrmFormatModifierSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_image_drm_format_modifier</b>]</summary>
        public const string ExtImageDrmFormatModifierExtensionName = "VK_EXT_image_drm_format_modifier";
        /// <summary>[from: <b>VK_EXT_validation_cache</b>]</summary>
        public const uint ExtValidationCacheSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_validation_cache</b>]</summary>
        public const string ExtValidationCacheExtensionName = "VK_EXT_validation_cache";
        /// <summary>[from: <b>VK_EXT_descriptor_indexing</b>]</summary>
        public const uint ExtDescriptorIndexingSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_descriptor_indexing</b>]</summary>
        public const string ExtDescriptorIndexingExtensionName = "VK_EXT_descriptor_indexing";
        /// <summary>[from: <b>VK_EXT_shader_viewport_index_layer</b>]</summary>
        public const uint ExtShaderViewportIndexLayerSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_viewport_index_layer</b>]</summary>
        public const string ExtShaderViewportIndexLayerExtensionName = "VK_EXT_shader_viewport_index_layer";
        /// <summary>[from: <b>VK_KHR_portability_subset</b>]</summary>
        public const uint KhrPortabilitySubsetSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_portability_subset</b>]</summary>
        public const string KhrPortabilitySubsetExtensionName = "VK_KHR_portability_subset";
        /// <summary>[from: <b>VK_NV_shading_rate_image</b>]</summary>
        public const uint NvShadingRateImageSpecVersion = 3;
        /// <summary>[from: <b>VK_NV_shading_rate_image</b>]</summary>
        public const string NvShadingRateImageExtensionName = "VK_NV_shading_rate_image";
        /// <summary>[from: <b>VK_NV_ray_tracing</b>]</summary>
        public const uint NvRayTracingSpecVersion = 3;
        /// <summary>[from: <b>VK_NV_ray_tracing</b>]</summary>
        public const string NvRayTracingExtensionName = "VK_NV_ray_tracing";
        /// <summary>[from: <b>VK_NV_representative_fragment_test</b>]</summary>
        public const uint NvRepresentativeFragmentTestSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_representative_fragment_test</b>]</summary>
        public const string NvRepresentativeFragmentTestExtensionName = "VK_NV_representative_fragment_test";
        /// <summary>[from: <b>VK_KHR_maintenance3</b>]</summary>
        public const uint KhrMaintenance3SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_maintenance3</b>]</summary>
        public const string KhrMaintenance3ExtensionName = "VK_KHR_maintenance3";
        /// <summary>[from: <b>VK_KHR_draw_indirect_count</b>]</summary>
        public const uint KhrDrawIndirectCountSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_draw_indirect_count</b>]</summary>
        public const string KhrDrawIndirectCountExtensionName = "VK_KHR_draw_indirect_count";
        /// <summary>[from: <b>VK_EXT_filter_cubic</b>]</summary>
        public const uint ExtFilterCubicSpecVersion = 3;
        /// <summary>[from: <b>VK_EXT_filter_cubic</b>]</summary>
        public const string ExtFilterCubicExtensionName = "VK_EXT_filter_cubic";
        /// <summary>[from: <b>VK_QCOM_render_pass_shader_resolve</b>]</summary>
        public const uint QcomRenderPassShaderResolveSpecVersion = 4;
        /// <summary>[from: <b>VK_QCOM_render_pass_shader_resolve</b>]</summary>
        public const string QcomRenderPassShaderResolveExtensionName = "VK_QCOM_render_pass_shader_resolve";
        /// <summary>[from: <b>VK_EXT_global_priority</b>]</summary>
        public const uint ExtGlobalPrioritySpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_global_priority</b>]</summary>
        public const string ExtGlobalPriorityExtensionName = "VK_EXT_global_priority";
        /// <summary>[from: <b>VK_KHR_shader_subgroup_extended_types</b>]</summary>
        public const uint KhrShaderSubgroupExtendedTypesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_subgroup_extended_types</b>]</summary>
        public const string KhrShaderSubgroupExtendedTypesExtensionName = "VK_KHR_shader_subgroup_extended_types";
        /// <summary>[from: <b>VK_KHR_8bit_storage</b>]</summary>
        public const uint Khr8bitStorageSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_8bit_storage</b>]</summary>
        public const string Khr8bitStorageExtensionName = "VK_KHR_8bit_storage";
        /// <summary>[from: <b>VK_EXT_external_memory_host</b>]</summary>
        public const uint ExtExternalMemoryHostSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_external_memory_host</b>]</summary>
        public const string ExtExternalMemoryHostExtensionName = "VK_EXT_external_memory_host";
        /// <summary>[from: <b>VK_AMD_buffer_marker</b>]</summary>
        public const uint AmdBufferMarkerSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_buffer_marker</b>]</summary>
        public const string AmdBufferMarkerExtensionName = "VK_AMD_buffer_marker";
        /// <summary>[from: <b>VK_KHR_shader_atomic_int64</b>]</summary>
        public const uint KhrShaderAtomicInt64SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_atomic_int64</b>]</summary>
        public const string KhrShaderAtomicInt64ExtensionName = "VK_KHR_shader_atomic_int64";
        /// <summary>[from: <b>VK_KHR_shader_clock</b>]</summary>
        public const uint KhrShaderClockSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_clock</b>]</summary>
        public const string KhrShaderClockExtensionName = "VK_KHR_shader_clock";
        /// <summary>[from: <b>VK_AMD_pipeline_compiler_control</b>]</summary>
        public const uint AmdPipelineCompilerControlSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_pipeline_compiler_control</b>]</summary>
        public const string AmdPipelineCompilerControlExtensionName = "VK_AMD_pipeline_compiler_control";
        /// <summary>[from: <b>VK_EXT_calibrated_timestamps</b>]</summary>
        public const uint ExtCalibratedTimestampsSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_calibrated_timestamps</b>]</summary>
        public const string ExtCalibratedTimestampsExtensionName = "VK_EXT_calibrated_timestamps";
        /// <summary>[from: <b>VK_AMD_shader_core_properties</b>]</summary>
        public const uint AmdShaderCorePropertiesSpecVersion = 2;
        /// <summary>[from: <b>VK_AMD_shader_core_properties</b>]</summary>
        public const string AmdShaderCorePropertiesExtensionName = "VK_AMD_shader_core_properties";
        /// <summary>[from: <b>VK_KHR_video_decode_h265</b>]</summary>
        public const uint KhrVideoDecodeH265SpecVersion = 8;
        /// <summary>[from: <b>VK_KHR_video_decode_h265</b>]</summary>
        public const string KhrVideoDecodeH265ExtensionName = "VK_KHR_video_decode_h265";
        /// <summary>[from: <b>VK_KHR_global_priority</b>]</summary>
        public const uint KhrGlobalPrioritySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_global_priority</b>]</summary>
        public const string KhrGlobalPriorityExtensionName = "VK_KHR_global_priority";
        /// <summary>[from: <b>VK_AMD_memory_overallocation_behavior</b>]</summary>
        public const uint AmdMemoryOverallocationBehaviorSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_memory_overallocation_behavior</b>]</summary>
        public const string AmdMemoryOverallocationBehaviorExtensionName = "VK_AMD_memory_overallocation_behavior";
        /// <summary>[from: <b>VK_EXT_vertex_attribute_divisor</b>]</summary>
        public const uint ExtVertexAttributeDivisorSpecVersion = 3;
        /// <summary>[from: <b>VK_EXT_vertex_attribute_divisor</b>]</summary>
        public const string ExtVertexAttributeDivisorExtensionName = "VK_EXT_vertex_attribute_divisor";
        /// <summary>[from: <b>VK_GGP_frame_token</b>]</summary>
        public const uint GgpFrameTokenSpecVersion = 1;
        /// <summary>[from: <b>VK_GGP_frame_token</b>]</summary>
        public const string GgpFrameTokenExtensionName = "VK_GGP_frame_token";
        /// <summary>[from: <b>VK_EXT_pipeline_creation_feedback</b>]</summary>
        public const uint ExtPipelineCreationFeedbackSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_pipeline_creation_feedback</b>]</summary>
        public const string ExtPipelineCreationFeedbackExtensionName = "VK_EXT_pipeline_creation_feedback";
        /// <summary>[from: <b>VK_KHR_driver_properties</b>]</summary>
        public const uint KhrDriverPropertiesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_driver_properties</b>]</summary>
        public const string KhrDriverPropertiesExtensionName = "VK_KHR_driver_properties";
        /// <summary>[from: <b>VK_KHR_shader_float_controls</b>]</summary>
        public const uint KhrShaderFloatControlsSpecVersion = 4;
        /// <summary>[from: <b>VK_KHR_shader_float_controls</b>]</summary>
        public const string KhrShaderFloatControlsExtensionName = "VK_KHR_shader_float_controls";
        /// <summary>[from: <b>VK_NV_shader_subgroup_partitioned</b>]</summary>
        public const uint NvShaderSubgroupPartitionedSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_shader_subgroup_partitioned</b>]</summary>
        public const string NvShaderSubgroupPartitionedExtensionName = "VK_NV_shader_subgroup_partitioned";
        /// <summary>[from: <b>VK_KHR_depth_stencil_resolve</b>]</summary>
        public const uint KhrDepthStencilResolveSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_depth_stencil_resolve</b>]</summary>
        public const string KhrDepthStencilResolveExtensionName = "VK_KHR_depth_stencil_resolve";
        /// <summary>[from: <b>VK_KHR_swapchain_mutable_format</b>]</summary>
        public const uint KhrSwapchainMutableFormatSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_swapchain_mutable_format</b>]</summary>
        public const string KhrSwapchainMutableFormatExtensionName = "VK_KHR_swapchain_mutable_format";
        /// <summary>[from: <b>VK_NV_compute_shader_derivatives</b>]</summary>
        public const uint NvComputeShaderDerivativesSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_compute_shader_derivatives</b>]</summary>
        public const string NvComputeShaderDerivativesExtensionName = "VK_NV_compute_shader_derivatives";
        /// <summary>[from: <b>VK_NV_mesh_shader</b>]</summary>
        public const uint NvMeshShaderSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_mesh_shader</b>]</summary>
        public const string NvMeshShaderExtensionName = "VK_NV_mesh_shader";
        /// <summary>[from: <b>VK_NV_fragment_shader_barycentric</b>]</summary>
        public const uint NvFragmentShaderBarycentricSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_fragment_shader_barycentric</b>]</summary>
        public const string NvFragmentShaderBarycentricExtensionName = "VK_NV_fragment_shader_barycentric";
        /// <summary>[from: <b>VK_NV_shader_image_footprint</b>]</summary>
        public const uint NvShaderImageFootprintSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_shader_image_footprint</b>]</summary>
        public const string NvShaderImageFootprintExtensionName = "VK_NV_shader_image_footprint";
        /// <summary>[from: <b>VK_NV_scissor_exclusive</b>]</summary>
        public const uint NvScissorExclusiveSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_scissor_exclusive</b>]</summary>
        public const string NvScissorExclusiveExtensionName = "VK_NV_scissor_exclusive";
        /// <summary>[from: <b>VK_NV_device_diagnostic_checkpoints</b>]</summary>
        public const uint NvDeviceDiagnosticCheckpointsSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_device_diagnostic_checkpoints</b>]</summary>
        public const string NvDeviceDiagnosticCheckpointsExtensionName = "VK_NV_device_diagnostic_checkpoints";
        /// <summary>[from: <b>VK_KHR_timeline_semaphore</b>]</summary>
        public const uint KhrTimelineSemaphoreSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_timeline_semaphore</b>]</summary>
        public const string KhrTimelineSemaphoreExtensionName = "VK_KHR_timeline_semaphore";
        /// <summary>[from: <b>VK_INTEL_shader_integer_functions2</b>]</summary>
        public const uint IntelShaderIntegerFunctions2SpecVersion = 1;
        /// <summary>[from: <b>VK_INTEL_shader_integer_functions2</b>]</summary>
        public const string IntelShaderIntegerFunctions2ExtensionName = "VK_INTEL_shader_integer_functions2";
        /// <summary>[from: <b>VK_INTEL_performance_query</b>]</summary>
        public const uint IntelPerformanceQuerySpecVersion = 2;
        /// <summary>[from: <b>VK_INTEL_performance_query</b>]</summary>
        public const string IntelPerformanceQueryExtensionName = "VK_INTEL_performance_query";
        /// <summary>[from: <b>VK_KHR_vulkan_memory_model</b>]</summary>
        public const uint KhrVulkanMemoryModelSpecVersion = 3;
        /// <summary>[from: <b>VK_KHR_vulkan_memory_model</b>]</summary>
        public const string KhrVulkanMemoryModelExtensionName = "VK_KHR_vulkan_memory_model";
        /// <summary>[from: <b>VK_EXT_pci_bus_info</b>]</summary>
        public const uint ExtPciBusInfoSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_pci_bus_info</b>]</summary>
        public const string ExtPciBusInfoExtensionName = "VK_EXT_pci_bus_info";
        /// <summary>[from: <b>VK_AMD_display_native_hdr</b>]</summary>
        public const uint AmdDisplayNativeHdrSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_display_native_hdr</b>]</summary>
        public const string AmdDisplayNativeHdrExtensionName = "VK_AMD_display_native_hdr";
        /// <summary>[from: <b>VK_FUCHSIA_imagepipe_surface</b>]</summary>
        public const uint FuchsiaImagepipeSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_FUCHSIA_imagepipe_surface</b>]</summary>
        public const string FuchsiaImagepipeSurfaceExtensionName = "VK_FUCHSIA_imagepipe_surface";
        /// <summary>[from: <b>VK_KHR_shader_terminate_invocation</b>]</summary>
        public const uint KhrShaderTerminateInvocationSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_terminate_invocation</b>]</summary>
        public const string KhrShaderTerminateInvocationExtensionName = "VK_KHR_shader_terminate_invocation";
        /// <summary>[from: <b>VK_EXT_metal_surface</b>]</summary>
        public const uint ExtMetalSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_metal_surface</b>]</summary>
        public const string ExtMetalSurfaceExtensionName = "VK_EXT_metal_surface";
        /// <summary>[from: <b>VK_EXT_fragment_density_map</b>]</summary>
        public const uint ExtFragmentDensityMapSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_fragment_density_map</b>]</summary>
        public const string ExtFragmentDensityMapExtensionName = "VK_EXT_fragment_density_map";
        /// <summary>[from: <b>VK_EXT_scalar_block_layout</b>]</summary>
        public const uint ExtScalarBlockLayoutSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_scalar_block_layout</b>]</summary>
        public const string ExtScalarBlockLayoutExtensionName = "VK_EXT_scalar_block_layout";
        /// <summary>[from: <b>VK_GOOGLE_hlsl_functionality1</b>]</summary>
        public const uint GoogleHlslFunctionality1SpecVersion = 1;
        /// <summary>[from: <b>VK_GOOGLE_hlsl_functionality1</b>]</summary>
        public const string GoogleHlslFunctionality1ExtensionName = "VK_GOOGLE_hlsl_functionality1";
        /// <summary>[from: <b>VK_GOOGLE_decorate_string</b>]</summary>
        public const uint GoogleDecorateStringSpecVersion = 1;
        /// <summary>[from: <b>VK_GOOGLE_decorate_string</b>]</summary>
        public const string GoogleDecorateStringExtensionName = "VK_GOOGLE_decorate_string";
        /// <summary>[from: <b>VK_EXT_subgroup_size_control</b>]</summary>
        public const uint ExtSubgroupSizeControlSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_subgroup_size_control</b>]</summary>
        public const string ExtSubgroupSizeControlExtensionName = "VK_EXT_subgroup_size_control";
        /// <summary>[from: <b>VK_KHR_fragment_shading_rate</b>]</summary>
        public const uint KhrFragmentShadingRateSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_fragment_shading_rate</b>]</summary>
        public const string KhrFragmentShadingRateExtensionName = "VK_KHR_fragment_shading_rate";
        /// <summary>[from: <b>VK_AMD_shader_core_properties2</b>]</summary>
        public const uint AmdShaderCoreProperties2SpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_core_properties2</b>]</summary>
        public const string AmdShaderCoreProperties2ExtensionName = "VK_AMD_shader_core_properties2";
        /// <summary>[from: <b>VK_AMD_device_coherent_memory</b>]</summary>
        public const uint AmdDeviceCoherentMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_device_coherent_memory</b>]</summary>
        public const string AmdDeviceCoherentMemoryExtensionName = "VK_AMD_device_coherent_memory";
        /// <summary>[from: <b>VK_KHR_dynamic_rendering_local_read</b>]</summary>
        public const uint KhrDynamicRenderingLocalReadSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_dynamic_rendering_local_read</b>]</summary>
        public const string KhrDynamicRenderingLocalReadExtensionName = "VK_KHR_dynamic_rendering_local_read";
        /// <summary>[from: <b>VK_EXT_shader_image_atomic_int64</b>]</summary>
        public const uint ExtShaderImageAtomicInt64SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_image_atomic_int64</b>]</summary>
        public const string ExtShaderImageAtomicInt64ExtensionName = "VK_EXT_shader_image_atomic_int64";
        /// <summary>[from: <b>VK_KHR_shader_quad_control</b>]</summary>
        public const uint KhrShaderQuadControlSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_quad_control</b>]</summary>
        public const string KhrShaderQuadControlExtensionName = "VK_KHR_shader_quad_control";
        /// <summary>[from: <b>VK_KHR_spirv_1_4</b>]</summary>
        public const uint KhrSpirv14SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_spirv_1_4</b>]</summary>
        public const string KhrSpirv14ExtensionName = "VK_KHR_spirv_1_4";
        /// <summary>[from: <b>VK_EXT_memory_budget</b>]</summary>
        public const uint ExtMemoryBudgetSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_memory_budget</b>]</summary>
        public const string ExtMemoryBudgetExtensionName = "VK_EXT_memory_budget";
        /// <summary>[from: <b>VK_EXT_memory_priority</b>]</summary>
        public const uint ExtMemoryPrioritySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_memory_priority</b>]</summary>
        public const string ExtMemoryPriorityExtensionName = "VK_EXT_memory_priority";
        /// <summary>[from: <b>VK_KHR_surface_protected_capabilities</b>]</summary>
        public const uint KhrSurfaceProtectedCapabilitiesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_surface_protected_capabilities</b>]</summary>
        public const string KhrSurfaceProtectedCapabilitiesExtensionName = "VK_KHR_surface_protected_capabilities";
        /// <summary>[from: <b>VK_NV_dedicated_allocation_image_aliasing</b>]</summary>
        public const uint NvDedicatedAllocationImageAliasingSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_dedicated_allocation_image_aliasing</b>]</summary>
        public const string NvDedicatedAllocationImageAliasingExtensionName = "VK_NV_dedicated_allocation_image_aliasing";
        /// <summary>[from: <b>VK_KHR_separate_depth_stencil_layouts</b>]</summary>
        public const uint KhrSeparateDepthStencilLayoutsSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_separate_depth_stencil_layouts</b>]</summary>
        public const string KhrSeparateDepthStencilLayoutsExtensionName = "VK_KHR_separate_depth_stencil_layouts";
        /// <summary>[from: <b>VK_EXT_buffer_device_address</b>]</summary>
        public const uint ExtBufferDeviceAddressSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_buffer_device_address</b>]</summary>
        public const string ExtBufferDeviceAddressExtensionName = "VK_EXT_buffer_device_address";
        /// <summary>[from: <b>VK_EXT_tooling_info</b>]</summary>
        public const uint ExtToolingInfoSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_tooling_info</b>]</summary>
        public const string ExtToolingInfoExtensionName = "VK_EXT_tooling_info";
        /// <summary>[from: <b>VK_EXT_separate_stencil_usage</b>]</summary>
        public const uint ExtSeparateStencilUsageSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_separate_stencil_usage</b>]</summary>
        public const string ExtSeparateStencilUsageExtensionName = "VK_EXT_separate_stencil_usage";
        /// <summary>[from: <b>VK_EXT_validation_features</b>]</summary>
        public const uint ExtValidationFeaturesSpecVersion = 6;
        /// <summary>[from: <b>VK_EXT_validation_features</b>]</summary>
        public const string ExtValidationFeaturesExtensionName = "VK_EXT_validation_features";
        /// <summary>[from: <b>VK_KHR_present_wait</b>]</summary>
        public const uint KhrPresentWaitSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_present_wait</b>]</summary>
        public const string KhrPresentWaitExtensionName = "VK_KHR_present_wait";
        /// <summary>[from: <b>VK_NV_cooperative_matrix</b>]</summary>
        public const uint NvCooperativeMatrixSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_cooperative_matrix</b>]</summary>
        public const string NvCooperativeMatrixExtensionName = "VK_NV_cooperative_matrix";
        /// <summary>[from: <b>VK_NV_coverage_reduction_mode</b>]</summary>
        public const uint NvCoverageReductionModeSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_coverage_reduction_mode</b>]</summary>
        public const string NvCoverageReductionModeExtensionName = "VK_NV_coverage_reduction_mode";
        /// <summary>[from: <b>VK_EXT_fragment_shader_interlock</b>]</summary>
        public const uint ExtFragmentShaderInterlockSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_fragment_shader_interlock</b>]</summary>
        public const string ExtFragmentShaderInterlockExtensionName = "VK_EXT_fragment_shader_interlock";
        /// <summary>[from: <b>VK_EXT_ycbcr_image_arrays</b>]</summary>
        public const uint ExtYcbcrImageArraysSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_ycbcr_image_arrays</b>]</summary>
        public const string ExtYcbcrImageArraysExtensionName = "VK_EXT_ycbcr_image_arrays";
        /// <summary>[from: <b>VK_KHR_uniform_buffer_standard_layout</b>]</summary>
        public const uint KhrUniformBufferStandardLayoutSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_uniform_buffer_standard_layout</b>]</summary>
        public const string KhrUniformBufferStandardLayoutExtensionName = "VK_KHR_uniform_buffer_standard_layout";
        /// <summary>[from: <b>VK_EXT_provoking_vertex</b>]</summary>
        public const uint ExtProvokingVertexSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_provoking_vertex</b>]</summary>
        public const string ExtProvokingVertexExtensionName = "VK_EXT_provoking_vertex";
        /// <summary>[from: <b>VK_EXT_full_screen_exclusive</b>]</summary>
        public const uint ExtFullScreenExclusiveSpecVersion = 4;
        /// <summary>[from: <b>VK_EXT_full_screen_exclusive</b>]</summary>
        public const string ExtFullScreenExclusiveExtensionName = "VK_EXT_full_screen_exclusive";
        /// <summary>[from: <b>VK_EXT_headless_surface</b>]</summary>
        public const uint ExtHeadlessSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_headless_surface</b>]</summary>
        public const string ExtHeadlessSurfaceExtensionName = "VK_EXT_headless_surface";
        /// <summary>[from: <b>VK_KHR_buffer_device_address</b>]</summary>
        public const uint KhrBufferDeviceAddressSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_buffer_device_address</b>]</summary>
        public const string KhrBufferDeviceAddressExtensionName = "VK_KHR_buffer_device_address";
        /// <summary>[from: <b>VK_EXT_line_rasterization</b>]</summary>
        public const uint ExtLineRasterizationSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_line_rasterization</b>]</summary>
        public const string ExtLineRasterizationExtensionName = "VK_EXT_line_rasterization";
        /// <summary>[from: <b>VK_EXT_shader_atomic_float</b>]</summary>
        public const uint ExtShaderAtomicFloatSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_atomic_float</b>]</summary>
        public const string ExtShaderAtomicFloatExtensionName = "VK_EXT_shader_atomic_float";
        /// <summary>[from: <b>VK_EXT_host_query_reset</b>]</summary>
        public const uint ExtHostQueryResetSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_host_query_reset</b>]</summary>
        public const string ExtHostQueryResetExtensionName = "VK_EXT_host_query_reset";
        /// <summary>[from: <b>VK_EXT_index_type_uint8</b>]</summary>
        public const uint ExtIndexTypeUint8SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_index_type_uint8</b>]</summary>
        public const string ExtIndexTypeUint8ExtensionName = "VK_EXT_index_type_uint8";
        /// <summary>[from: <b>VK_EXT_extended_dynamic_state</b>]</summary>
        public const uint ExtExtendedDynamicStateSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_extended_dynamic_state</b>]</summary>
        public const string ExtExtendedDynamicStateExtensionName = "VK_EXT_extended_dynamic_state";
        /// <summary>[from: <b>VK_KHR_deferred_host_operations</b>]</summary>
        public const uint KhrDeferredHostOperationsSpecVersion = 4;
        /// <summary>[from: <b>VK_KHR_deferred_host_operations</b>]</summary>
        public const string KhrDeferredHostOperationsExtensionName = "VK_KHR_deferred_host_operations";
        /// <summary>[from: <b>VK_KHR_pipeline_executable_properties</b>]</summary>
        public const uint KhrPipelineExecutablePropertiesSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_pipeline_executable_properties</b>]</summary>
        public const string KhrPipelineExecutablePropertiesExtensionName = "VK_KHR_pipeline_executable_properties";
        /// <summary>[from: <b>VK_EXT_host_image_copy</b>]</summary>
        public const uint ExtHostImageCopySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_host_image_copy</b>]</summary>
        public const string ExtHostImageCopyExtensionName = "VK_EXT_host_image_copy";
        /// <summary>[from: <b>VK_KHR_map_memory2</b>]</summary>
        public const uint KhrMapMemory2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_map_memory2</b>]</summary>
        public const string KhrMapMemory2ExtensionName = "VK_KHR_map_memory2";
        /// <summary>[from: <b>VK_EXT_map_memory_placed</b>]</summary>
        public const uint ExtMapMemoryPlacedSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_map_memory_placed</b>]</summary>
        public const string ExtMapMemoryPlacedExtensionName = "VK_EXT_map_memory_placed";
        /// <summary>[from: <b>VK_EXT_shader_atomic_float2</b>]</summary>
        public const uint ExtShaderAtomicFloat2SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_atomic_float2</b>]</summary>
        public const string ExtShaderAtomicFloat2ExtensionName = "VK_EXT_shader_atomic_float2";
        /// <summary>[from: <b>VK_EXT_surface_maintenance1</b>]</summary>
        public const uint ExtSurfaceMaintenance1SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_surface_maintenance1</b>]</summary>
        public const string ExtSurfaceMaintenance1ExtensionName = "VK_EXT_surface_maintenance1";
        /// <summary>[from: <b>VK_EXT_swapchain_maintenance1</b>]</summary>
        public const uint ExtSwapchainMaintenance1SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_swapchain_maintenance1</b>]</summary>
        public const string ExtSwapchainMaintenance1ExtensionName = "VK_EXT_swapchain_maintenance1";
        /// <summary>[from: <b>VK_EXT_shader_demote_to_helper_invocation</b>]</summary>
        public const uint ExtShaderDemoteToHelperInvocationSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_demote_to_helper_invocation</b>]</summary>
        public const string ExtShaderDemoteToHelperInvocationExtensionName = "VK_EXT_shader_demote_to_helper_invocation";
        /// <summary>[from: <b>VK_NV_device_generated_commands</b>]</summary>
        public const uint NvDeviceGeneratedCommandsSpecVersion = 3;
        /// <summary>[from: <b>VK_NV_device_generated_commands</b>]</summary>
        public const string NvDeviceGeneratedCommandsExtensionName = "VK_NV_device_generated_commands";
        /// <summary>[from: <b>VK_NV_inherited_viewport_scissor</b>]</summary>
        public const uint NvInheritedViewportScissorSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_inherited_viewport_scissor</b>]</summary>
        public const string NvInheritedViewportScissorExtensionName = "VK_NV_inherited_viewport_scissor";
        /// <summary>[from: <b>VK_KHR_shader_integer_dot_product</b>]</summary>
        public const uint KhrShaderIntegerDotProductSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_integer_dot_product</b>]</summary>
        public const string KhrShaderIntegerDotProductExtensionName = "VK_KHR_shader_integer_dot_product";
        /// <summary>[from: <b>VK_EXT_texel_buffer_alignment</b>]</summary>
        public const uint ExtTexelBufferAlignmentSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_texel_buffer_alignment</b>]</summary>
        public const string ExtTexelBufferAlignmentExtensionName = "VK_EXT_texel_buffer_alignment";
        /// <summary>[from: <b>VK_QCOM_render_pass_transform</b>]</summary>
        public const uint QcomRenderPassTransformSpecVersion = 4;
        /// <summary>[from: <b>VK_QCOM_render_pass_transform</b>]</summary>
        public const string QcomRenderPassTransformExtensionName = "VK_QCOM_render_pass_transform";
        /// <summary>[from: <b>VK_EXT_depth_bias_control</b>]</summary>
        public const uint ExtDepthBiasControlSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_depth_bias_control</b>]</summary>
        public const string ExtDepthBiasControlExtensionName = "VK_EXT_depth_bias_control";
        /// <summary>[from: <b>VK_EXT_device_memory_report</b>]</summary>
        public const uint ExtDeviceMemoryReportSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_device_memory_report</b>]</summary>
        public const string ExtDeviceMemoryReportExtensionName = "VK_EXT_device_memory_report";
        /// <summary>[from: <b>VK_EXT_acquire_drm_display</b>]</summary>
        public const uint ExtAcquireDrmDisplaySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_acquire_drm_display</b>]</summary>
        public const string ExtAcquireDrmDisplayExtensionName = "VK_EXT_acquire_drm_display";
        /// <summary>[from: <b>VK_EXT_robustness2</b>]</summary>
        public const uint ExtRobustness2SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_robustness2</b>]</summary>
        public const string ExtRobustness2ExtensionName = "VK_EXT_robustness2";
        /// <summary>[from: <b>VK_EXT_custom_border_color</b>]</summary>
        public const uint ExtCustomBorderColorSpecVersion = 12;
        /// <summary>[from: <b>VK_EXT_custom_border_color</b>]</summary>
        public const string ExtCustomBorderColorExtensionName = "VK_EXT_custom_border_color";
        /// <summary>[from: <b>VK_GOOGLE_user_type</b>]</summary>
        public const uint GoogleUserTypeSpecVersion = 1;
        /// <summary>[from: <b>VK_GOOGLE_user_type</b>]</summary>
        public const string GoogleUserTypeExtensionName = "VK_GOOGLE_user_type";
        /// <summary>[from: <b>VK_KHR_pipeline_library</b>]</summary>
        public const uint KhrPipelineLibrarySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_pipeline_library</b>]</summary>
        public const string KhrPipelineLibraryExtensionName = "VK_KHR_pipeline_library";
        /// <summary>[from: <b>VK_NV_present_barrier</b>]</summary>
        public const uint NvPresentBarrierSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_present_barrier</b>]</summary>
        public const string NvPresentBarrierExtensionName = "VK_NV_present_barrier";
        /// <summary>[from: <b>VK_KHR_shader_non_semantic_info</b>]</summary>
        public const uint KhrShaderNonSemanticInfoSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_non_semantic_info</b>]</summary>
        public const string KhrShaderNonSemanticInfoExtensionName = "VK_KHR_shader_non_semantic_info";
        /// <summary>[from: <b>VK_KHR_present_id</b>]</summary>
        public const uint KhrPresentIdSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_present_id</b>]</summary>
        public const string KhrPresentIdExtensionName = "VK_KHR_present_id";
        /// <summary>[from: <b>VK_EXT_private_data</b>]</summary>
        public const uint ExtPrivateDataSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_private_data</b>]</summary>
        public const string ExtPrivateDataExtensionName = "VK_EXT_private_data";
        /// <summary>[from: <b>VK_EXT_pipeline_creation_cache_control</b>]</summary>
        public const uint ExtPipelineCreationCacheControlSpecVersion = 3;
        /// <summary>[from: <b>VK_EXT_pipeline_creation_cache_control</b>]</summary>
        public const string ExtPipelineCreationCacheControlExtensionName = "VK_EXT_pipeline_creation_cache_control";
        /// <summary>[from: <b>VK_KHR_video_encode_queue</b>]</summary>
        public const uint KhrVideoEncodeQueueSpecVersion = 12;
        /// <summary>[from: <b>VK_KHR_video_encode_queue</b>]</summary>
        public const string KhrVideoEncodeQueueExtensionName = "VK_KHR_video_encode_queue";
        /// <summary>[from: <b>VK_NV_device_diagnostics_config</b>]</summary>
        public const uint NvDeviceDiagnosticsConfigSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_device_diagnostics_config</b>]</summary>
        public const string NvDeviceDiagnosticsConfigExtensionName = "VK_NV_device_diagnostics_config";
        /// <summary>[from: <b>VK_QCOM_render_pass_store_ops</b>]</summary>
        public const uint QcomRenderPassStoreOpsSpecVersion = 2;
        /// <summary>[from: <b>VK_QCOM_render_pass_store_ops</b>]</summary>
        public const string QcomRenderPassStoreOpsExtensionName = "VK_QCOM_render_pass_store_ops";
        /// <summary>[from: <b>VK_NV_cuda_kernel_launch</b>]</summary>
        public const uint NvCudaKernelLaunchSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_cuda_kernel_launch</b>]</summary>
        public const string NvCudaKernelLaunchExtensionName = "VK_NV_cuda_kernel_launch";
        /// <summary>[from: <b>VK_KHR_object_refresh</b>]</summary>
        public const uint KhrObjectRefreshSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_object_refresh</b>]</summary>
        public const string KhrObjectRefreshExtensionName = "VK_KHR_object_refresh";
        /// <summary>[from: <b>VK_NV_low_latency</b>]</summary>
        public const uint NvLowLatencySpecVersion = 1;
        /// <summary>[from: <b>VK_NV_low_latency</b>]</summary>
        public const string NvLowLatencyExtensionName = "VK_NV_low_latency";
        /// <summary>[from: <b>VK_EXT_metal_objects</b>]</summary>
        public const uint ExtMetalObjectsSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_metal_objects</b>]</summary>
        public const string ExtMetalObjectsExtensionName = "VK_EXT_metal_objects";
        /// <summary>[from: <b>VK_KHR_synchronization2</b>]</summary>
        public const uint KhrSynchronization2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_synchronization2</b>]</summary>
        public const string KhrSynchronization2ExtensionName = "VK_KHR_synchronization2";
        /// <summary>[from: <b>VK_EXT_descriptor_buffer</b>]</summary>
        public const uint ExtDescriptorBufferSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_descriptor_buffer</b>]</summary>
        public const string ExtDescriptorBufferExtensionName = "VK_EXT_descriptor_buffer";
        /// <summary>[from: <b>VK_EXT_graphics_pipeline_library</b>]</summary>
        public const uint ExtGraphicsPipelineLibrarySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_graphics_pipeline_library</b>]</summary>
        public const string ExtGraphicsPipelineLibraryExtensionName = "VK_EXT_graphics_pipeline_library";
        /// <summary>[from: <b>VK_AMD_shader_early_and_late_fragment_tests</b>]</summary>
        public const uint AmdShaderEarlyAndLateFragmentTestsSpecVersion = 1;
        /// <summary>[from: <b>VK_AMD_shader_early_and_late_fragment_tests</b>]</summary>
        public const string AmdShaderEarlyAndLateFragmentTestsExtensionName = "VK_AMD_shader_early_and_late_fragment_tests";
        /// <summary>[from: <b>VK_KHR_fragment_shader_barycentric</b>]</summary>
        public const uint KhrFragmentShaderBarycentricSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_fragment_shader_barycentric</b>]</summary>
        public const string KhrFragmentShaderBarycentricExtensionName = "VK_KHR_fragment_shader_barycentric";
        /// <summary>[from: <b>VK_KHR_shader_subgroup_uniform_control_flow</b>]</summary>
        public const uint KhrShaderSubgroupUniformControlFlowSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_subgroup_uniform_control_flow</b>]</summary>
        public const string KhrShaderSubgroupUniformControlFlowExtensionName = "VK_KHR_shader_subgroup_uniform_control_flow";
        /// <summary>[from: <b>VK_KHR_zero_initialize_workgroup_memory</b>]</summary>
        public const uint KhrZeroInitializeWorkgroupMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_zero_initialize_workgroup_memory</b>]</summary>
        public const string KhrZeroInitializeWorkgroupMemoryExtensionName = "VK_KHR_zero_initialize_workgroup_memory";
        /// <summary>[from: <b>VK_NV_fragment_shading_rate_enums</b>]</summary>
        public const uint NvFragmentShadingRateEnumsSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_fragment_shading_rate_enums</b>]</summary>
        public const string NvFragmentShadingRateEnumsExtensionName = "VK_NV_fragment_shading_rate_enums";
        /// <summary>[from: <b>VK_NV_ray_tracing_motion_blur</b>]</summary>
        public const uint NvRayTracingMotionBlurSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_ray_tracing_motion_blur</b>]</summary>
        public const string NvRayTracingMotionBlurExtensionName = "VK_NV_ray_tracing_motion_blur";
        /// <summary>[from: <b>VK_EXT_mesh_shader</b>]</summary>
        public const uint ExtMeshShaderSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_mesh_shader</b>]</summary>
        public const string ExtMeshShaderExtensionName = "VK_EXT_mesh_shader";
        /// <summary>[from: <b>VK_EXT_ycbcr_2plane_444_formats</b>]</summary>
        public const uint ExtYcbcr2plane444FormatsSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_ycbcr_2plane_444_formats</b>]</summary>
        public const string ExtYcbcr2plane444FormatsExtensionName = "VK_EXT_ycbcr_2plane_444_formats";
        /// <summary>[from: <b>VK_EXT_fragment_density_map2</b>]</summary>
        public const uint ExtFragmentDensityMap2SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_fragment_density_map2</b>]</summary>
        public const string ExtFragmentDensityMap2ExtensionName = "VK_EXT_fragment_density_map2";
        /// <summary>[from: <b>VK_QCOM_rotated_copy_commands</b>]</summary>
        public const uint QcomRotatedCopyCommandsSpecVersion = 2;
        /// <summary>[from: <b>VK_QCOM_rotated_copy_commands</b>]</summary>
        public const string QcomRotatedCopyCommandsExtensionName = "VK_QCOM_rotated_copy_commands";
        /// <summary>[from: <b>VK_EXT_image_robustness</b>]</summary>
        public const uint ExtImageRobustnessSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_image_robustness</b>]</summary>
        public const string ExtImageRobustnessExtensionName = "VK_EXT_image_robustness";
        /// <summary>[from: <b>VK_KHR_workgroup_memory_explicit_layout</b>]</summary>
        public const uint KhrWorkgroupMemoryExplicitLayoutSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_workgroup_memory_explicit_layout</b>]</summary>
        public const string KhrWorkgroupMemoryExplicitLayoutExtensionName = "VK_KHR_workgroup_memory_explicit_layout";
        /// <summary>[from: <b>VK_KHR_copy_commands2</b>]</summary>
        public const uint KhrCopyCommands2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_copy_commands2</b>]</summary>
        public const string KhrCopyCommands2ExtensionName = "VK_KHR_copy_commands2";
        /// <summary>[from: <b>VK_EXT_image_compression_control</b>]</summary>
        public const uint ExtImageCompressionControlSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_image_compression_control</b>]</summary>
        public const string ExtImageCompressionControlExtensionName = "VK_EXT_image_compression_control";
        /// <summary>[from: <b>VK_EXT_attachment_feedback_loop_layout</b>]</summary>
        public const uint ExtAttachmentFeedbackLoopLayoutSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_attachment_feedback_loop_layout</b>]</summary>
        public const string ExtAttachmentFeedbackLoopLayoutExtensionName = "VK_EXT_attachment_feedback_loop_layout";
        /// <summary>[from: <b>VK_EXT_4444_formats</b>]</summary>
        public const uint Ext4444FormatsSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_4444_formats</b>]</summary>
        public const string Ext4444FormatsExtensionName = "VK_EXT_4444_formats";
        /// <summary>[from: <b>VK_EXT_device_fault</b>]</summary>
        public const uint ExtDeviceFaultSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_device_fault</b>]</summary>
        public const string ExtDeviceFaultExtensionName = "VK_EXT_device_fault";
        /// <summary>[from: <b>VK_ARM_rasterization_order_attachment_access</b>]</summary>
        public const uint ArmRasterizationOrderAttachmentAccessSpecVersion = 1;
        /// <summary>[from: <b>VK_ARM_rasterization_order_attachment_access</b>]</summary>
        public const string ArmRasterizationOrderAttachmentAccessExtensionName = "VK_ARM_rasterization_order_attachment_access";
        /// <summary>[from: <b>VK_EXT_rgba10x6_formats</b>]</summary>
        public const uint ExtRgba10x6FormatsSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_rgba10x6_formats</b>]</summary>
        public const string ExtRgba10x6FormatsExtensionName = "VK_EXT_rgba10x6_formats";
        /// <summary>[from: <b>VK_NV_acquire_winrt_display</b>]</summary>
        public const uint NvAcquireWinrtDisplaySpecVersion = 1;
        /// <summary>[from: <b>VK_NV_acquire_winrt_display</b>]</summary>
        public const string NvAcquireWinrtDisplayExtensionName = "VK_NV_acquire_winrt_display";
        /// <summary>[from: <b>VK_EXT_directfb_surface</b>]</summary>
        public const uint ExtDirectfbSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_directfb_surface</b>]</summary>
        public const string ExtDirectfbSurfaceExtensionName = "VK_EXT_directfb_surface";
        /// <summary>[from: <b>VK_VALVE_mutable_descriptor_type</b>]</summary>
        public const uint ValveMutableDescriptorTypeSpecVersion = 1;
        /// <summary>[from: <b>VK_VALVE_mutable_descriptor_type</b>]</summary>
        public const string ValveMutableDescriptorTypeExtensionName = "VK_VALVE_mutable_descriptor_type";
        /// <summary>[from: <b>VK_EXT_vertex_input_dynamic_state</b>]</summary>
        public const uint ExtVertexInputDynamicStateSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_vertex_input_dynamic_state</b>]</summary>
        public const string ExtVertexInputDynamicStateExtensionName = "VK_EXT_vertex_input_dynamic_state";
        /// <summary>[from: <b>VK_EXT_physical_device_drm</b>]</summary>
        public const uint ExtPhysicalDeviceDrmSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_physical_device_drm</b>]</summary>
        public const string ExtPhysicalDeviceDrmExtensionName = "VK_EXT_physical_device_drm";
        /// <summary>[from: <b>VK_EXT_device_address_binding_report</b>]</summary>
        public const uint ExtDeviceAddressBindingReportSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_device_address_binding_report</b>]</summary>
        public const string ExtDeviceAddressBindingReportExtensionName = "VK_EXT_device_address_binding_report";
        /// <summary>[from: <b>VK_EXT_depth_clip_control</b>]</summary>
        public const uint ExtDepthClipControlSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_depth_clip_control</b>]</summary>
        public const string ExtDepthClipControlExtensionName = "VK_EXT_depth_clip_control";
        /// <summary>[from: <b>VK_EXT_primitive_topology_list_restart</b>]</summary>
        public const uint ExtPrimitiveTopologyListRestartSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_primitive_topology_list_restart</b>]</summary>
        public const string ExtPrimitiveTopologyListRestartExtensionName = "VK_EXT_primitive_topology_list_restart";
        /// <summary>[from: <b>VK_KHR_format_feature_flags2</b>]</summary>
        public const uint KhrFormatFeatureFlags2SpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_format_feature_flags2</b>]</summary>
        public const string KhrFormatFeatureFlags2ExtensionName = "VK_KHR_format_feature_flags2";
        /// <summary>[from: <b>VK_FUCHSIA_external_memory</b>]</summary>
        public const uint FuchsiaExternalMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_FUCHSIA_external_memory</b>]</summary>
        public const string FuchsiaExternalMemoryExtensionName = "VK_FUCHSIA_external_memory";
        /// <summary>[from: <b>VK_FUCHSIA_external_semaphore</b>]</summary>
        public const uint FuchsiaExternalSemaphoreSpecVersion = 1;
        /// <summary>[from: <b>VK_FUCHSIA_external_semaphore</b>]</summary>
        public const string FuchsiaExternalSemaphoreExtensionName = "VK_FUCHSIA_external_semaphore";
        /// <summary>[from: <b>VK_FUCHSIA_buffer_collection</b>]</summary>
        public const uint FuchsiaBufferCollectionSpecVersion = 2;
        /// <summary>[from: <b>VK_FUCHSIA_buffer_collection</b>]</summary>
        public const string FuchsiaBufferCollectionExtensionName = "VK_FUCHSIA_buffer_collection";
        /// <summary>[from: <b>VK_HUAWEI_subpass_shading</b>]</summary>
        public const uint HuaweiSubpassShadingSpecVersion = 3;
        /// <summary>[from: <b>VK_HUAWEI_subpass_shading</b>]</summary>
        public const string HuaweiSubpassShadingExtensionName = "VK_HUAWEI_subpass_shading";
        /// <summary>[from: <b>VK_HUAWEI_invocation_mask</b>]</summary>
        public const uint HuaweiInvocationMaskSpecVersion = 1;
        /// <summary>[from: <b>VK_HUAWEI_invocation_mask</b>]</summary>
        public const string HuaweiInvocationMaskExtensionName = "VK_HUAWEI_invocation_mask";
        /// <summary>[from: <b>VK_NV_external_memory_rdma</b>]</summary>
        public const uint NvExternalMemoryRdmaSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_external_memory_rdma</b>]</summary>
        public const string NvExternalMemoryRdmaExtensionName = "VK_NV_external_memory_rdma";
        /// <summary>[from: <b>VK_EXT_pipeline_properties</b>]</summary>
        public const uint ExtPipelinePropertiesSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_pipeline_properties</b>]</summary>
        public const string ExtPipelinePropertiesExtensionName = "VK_EXT_pipeline_properties";
        /// <summary>[from: <b>VK_NV_external_sci_sync</b>]</summary>
        public const uint NvExternalSciSyncSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_external_sci_sync</b>]</summary>
        public const string NvExternalSciSyncExtensionName = "VK_NV_external_sci_sync";
        /// <summary>[from: <b>VK_NV_external_memory_sci_buf</b>]</summary>
        public const uint NvExternalMemorySciBufSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_external_memory_sci_buf</b>]</summary>
        public const string NvExternalMemorySciBufExtensionName = "VK_NV_external_memory_sci_buf";
        /// <summary>[from: <b>VK_EXT_frame_boundary</b>]</summary>
        public const uint ExtFrameBoundarySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_frame_boundary</b>]</summary>
        public const string ExtFrameBoundaryExtensionName = "VK_EXT_frame_boundary";
        /// <summary>[from: <b>VK_EXT_multisampled_render_to_single_sampled</b>]</summary>
        public const uint ExtMultisampledRenderToSingleSampledSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_multisampled_render_to_single_sampled</b>]</summary>
        public const string ExtMultisampledRenderToSingleSampledExtensionName = "VK_EXT_multisampled_render_to_single_sampled";
        /// <summary>[from: <b>VK_EXT_extended_dynamic_state2</b>]</summary>
        public const uint ExtExtendedDynamicState2SpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_extended_dynamic_state2</b>]</summary>
        public const string ExtExtendedDynamicState2ExtensionName = "VK_EXT_extended_dynamic_state2";
        /// <summary>[from: <b>VK_QNX_screen_surface</b>]</summary>
        public const uint QnxScreenSurfaceSpecVersion = 1;
        /// <summary>[from: <b>VK_QNX_screen_surface</b>]</summary>
        public const string QnxScreenSurfaceExtensionName = "VK_QNX_screen_surface";
        /// <summary>[from: <b>VK_EXT_color_write_enable</b>]</summary>
        public const uint ExtColorWriteEnableSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_color_write_enable</b>]</summary>
        public const string ExtColorWriteEnableExtensionName = "VK_EXT_color_write_enable";
        /// <summary>[from: <b>VK_EXT_primitives_generated_query</b>]</summary>
        public const uint ExtPrimitivesGeneratedQuerySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_primitives_generated_query</b>]</summary>
        public const string ExtPrimitivesGeneratedQueryExtensionName = "VK_EXT_primitives_generated_query";
        /// <summary>[from: <b>VK_KHR_ray_tracing_maintenance1</b>]</summary>
        public const uint KhrRayTracingMaintenance1SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_ray_tracing_maintenance1</b>]</summary>
        public const string KhrRayTracingMaintenance1ExtensionName = "VK_KHR_ray_tracing_maintenance1";
        /// <summary>[from: <b>VK_EXT_global_priority_query</b>]</summary>
        public const uint ExtGlobalPriorityQuerySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_global_priority_query</b>]</summary>
        public const string ExtGlobalPriorityQueryExtensionName = "VK_EXT_global_priority_query";
        /// <summary>[from: <b>VK_EXT_image_view_min_lod</b>]</summary>
        public const uint ExtImageViewMinLodSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_image_view_min_lod</b>]</summary>
        public const string ExtImageViewMinLodExtensionName = "VK_EXT_image_view_min_lod";
        /// <summary>[from: <b>VK_EXT_multi_draw</b>]</summary>
        public const uint ExtMultiDrawSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_multi_draw</b>]</summary>
        public const string ExtMultiDrawExtensionName = "VK_EXT_multi_draw";
        /// <summary>[from: <b>VK_EXT_image_2d_view_of_3d</b>]</summary>
        public const uint ExtImage2dViewOf3dSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_image_2d_view_of_3d</b>]</summary>
        public const string ExtImage2dViewOf3dExtensionName = "VK_EXT_image_2d_view_of_3d";
        /// <summary>[from: <b>VK_KHR_portability_enumeration</b>]</summary>
        public const uint KhrPortabilityEnumerationSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_portability_enumeration</b>]</summary>
        public const string KhrPortabilityEnumerationExtensionName = "VK_KHR_portability_enumeration";
        /// <summary>[from: <b>VK_EXT_shader_tile_image</b>]</summary>
        public const uint ExtShaderTileImageSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_tile_image</b>]</summary>
        public const string ExtShaderTileImageExtensionName = "VK_EXT_shader_tile_image";
        /// <summary>[from: <b>VK_EXT_opacity_micromap</b>]</summary>
        public const uint ExtOpacityMicromapSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_opacity_micromap</b>]</summary>
        public const string ExtOpacityMicromapExtensionName = "VK_EXT_opacity_micromap";
        /// <summary>[from: <b>VK_NV_displacement_micromap</b>]</summary>
        public const uint NvDisplacementMicromapSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_displacement_micromap</b>]</summary>
        public const string NvDisplacementMicromapExtensionName = "VK_NV_displacement_micromap";
        /// <summary>[from: <b>VK_EXT_load_store_op_none</b>]</summary>
        public const uint ExtLoadStoreOpNoneSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_load_store_op_none</b>]</summary>
        public const string ExtLoadStoreOpNoneExtensionName = "VK_EXT_load_store_op_none";
        /// <summary>[from: <b>VK_HUAWEI_cluster_culling_shader</b>]</summary>
        public const uint HuaweiClusterCullingShaderSpecVersion = 3;
        /// <summary>[from: <b>VK_HUAWEI_cluster_culling_shader</b>]</summary>
        public const string HuaweiClusterCullingShaderExtensionName = "VK_HUAWEI_cluster_culling_shader";
        /// <summary>[from: <b>VK_EXT_border_color_swizzle</b>]</summary>
        public const uint ExtBorderColorSwizzleSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_border_color_swizzle</b>]</summary>
        public const string ExtBorderColorSwizzleExtensionName = "VK_EXT_border_color_swizzle";
        /// <summary>[from: <b>VK_EXT_pageable_device_local_memory</b>]</summary>
        public const uint ExtPageableDeviceLocalMemorySpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_pageable_device_local_memory</b>]</summary>
        public const string ExtPageableDeviceLocalMemoryExtensionName = "VK_EXT_pageable_device_local_memory";
        /// <summary>[from: <b>VK_KHR_maintenance4</b>]</summary>
        public const uint KhrMaintenance4SpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_maintenance4</b>]</summary>
        public const string KhrMaintenance4ExtensionName = "VK_KHR_maintenance4";
        /// <summary>[from: <b>VK_ARM_shader_core_properties</b>]</summary>
        public const uint ArmShaderCorePropertiesSpecVersion = 1;
        /// <summary>[from: <b>VK_ARM_shader_core_properties</b>]</summary>
        public const string ArmShaderCorePropertiesExtensionName = "VK_ARM_shader_core_properties";
        /// <summary>[from: <b>VK_KHR_shader_subgroup_rotate</b>]</summary>
        public const uint KhrShaderSubgroupRotateSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_shader_subgroup_rotate</b>]</summary>
        public const string KhrShaderSubgroupRotateExtensionName = "VK_KHR_shader_subgroup_rotate";
        /// <summary>[from: <b>VK_ARM_scheduling_controls</b>]</summary>
        public const uint ArmSchedulingControlsSpecVersion = 1;
        /// <summary>[from: <b>VK_ARM_scheduling_controls</b>]</summary>
        public const string ArmSchedulingControlsExtensionName = "VK_ARM_scheduling_controls";
        /// <summary>[from: <b>VK_EXT_image_sliced_view_of_3d</b>]</summary>
        public const uint ExtImageSlicedViewOf3dSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_image_sliced_view_of_3d</b>]</summary>
        public const string ExtImageSlicedViewOf3dExtensionName = "VK_EXT_image_sliced_view_of_3d";
        /// <summary>[from: <b>VK_VALVE_descriptor_set_host_mapping</b>]</summary>
        public const uint ValveDescriptorSetHostMappingSpecVersion = 1;
        /// <summary>[from: <b>VK_VALVE_descriptor_set_host_mapping</b>]</summary>
        public const string ValveDescriptorSetHostMappingExtensionName = "VK_VALVE_descriptor_set_host_mapping";
        /// <summary>[from: <b>VK_EXT_depth_clamp_zero_one</b>]</summary>
        public const uint ExtDepthClampZeroOneSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_depth_clamp_zero_one</b>]</summary>
        public const string ExtDepthClampZeroOneExtensionName = "VK_EXT_depth_clamp_zero_one";
        /// <summary>[from: <b>VK_EXT_non_seamless_cube_map</b>]</summary>
        public const uint ExtNonSeamlessCubeMapSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_non_seamless_cube_map</b>]</summary>
        public const string ExtNonSeamlessCubeMapExtensionName = "VK_EXT_non_seamless_cube_map";
        /// <summary>[from: <b>VK_ARM_render_pass_striped</b>]</summary>
        public const uint ArmRenderPassStripedSpecVersion = 1;
        /// <summary>[from: <b>VK_ARM_render_pass_striped</b>]</summary>
        public const string ArmRenderPassStripedExtensionName = "VK_ARM_render_pass_striped";
        /// <summary>[from: <b>VK_QCOM_fragment_density_map_offset</b>]</summary>
        public const uint QcomFragmentDensityMapOffsetSpecVersion = 2;
        /// <summary>[from: <b>VK_QCOM_fragment_density_map_offset</b>]</summary>
        public const string QcomFragmentDensityMapOffsetExtensionName = "VK_QCOM_fragment_density_map_offset";
        /// <summary>[from: <b>VK_NV_copy_memory_indirect</b>]</summary>
        public const uint NvCopyMemoryIndirectSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_copy_memory_indirect</b>]</summary>
        public const string NvCopyMemoryIndirectExtensionName = "VK_NV_copy_memory_indirect";
        /// <summary>[from: <b>VK_NV_memory_decompression</b>]</summary>
        public const uint NvMemoryDecompressionSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_memory_decompression</b>]</summary>
        public const string NvMemoryDecompressionExtensionName = "VK_NV_memory_decompression";
        /// <summary>[from: <b>VK_NV_device_generated_commands_compute</b>]</summary>
        public const uint NvDeviceGeneratedCommandsComputeSpecVersion = 2;
        /// <summary>[from: <b>VK_NV_device_generated_commands_compute</b>]</summary>
        public const string NvDeviceGeneratedCommandsComputeExtensionName = "VK_NV_device_generated_commands_compute";
        /// <summary>[from: <b>VK_NV_linear_color_attachment</b>]</summary>
        public const uint NvLinearColorAttachmentSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_linear_color_attachment</b>]</summary>
        public const string NvLinearColorAttachmentExtensionName = "VK_NV_linear_color_attachment";
        /// <summary>[from: <b>VK_GOOGLE_surfaceless_query</b>]</summary>
        public const uint GoogleSurfacelessQuerySpecVersion = 2;
        /// <summary>[from: <b>VK_GOOGLE_surfaceless_query</b>]</summary>
        public const string GoogleSurfacelessQueryExtensionName = "VK_GOOGLE_surfaceless_query";
        /// <summary>[from: <b>VK_KHR_shader_maximal_reconvergence</b>]</summary>
        public const uint KhrShaderMaximalReconvergenceSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_maximal_reconvergence</b>]</summary>
        public const string KhrShaderMaximalReconvergenceExtensionName = "VK_KHR_shader_maximal_reconvergence";
        /// <summary>[from: <b>VK_EXT_application_parameters</b>]</summary>
        public const uint ExtApplicationParametersSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_application_parameters</b>]</summary>
        public const string ExtApplicationParametersExtensionName = "VK_EXT_application_parameters";
        /// <summary>[from: <b>VK_EXT_image_compression_control_swapchain</b>]</summary>
        public const uint ExtImageCompressionControlSwapchainSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_image_compression_control_swapchain</b>]</summary>
        public const string ExtImageCompressionControlSwapchainExtensionName = "VK_EXT_image_compression_control_swapchain";
        /// <summary>[from: <b>VK_QCOM_image_processing</b>]</summary>
        public const uint QcomImageProcessingSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_image_processing</b>]</summary>
        public const string QcomImageProcessingExtensionName = "VK_QCOM_image_processing";
        /// <summary>[from: <b>VK_EXT_nested_command_buffer</b>]</summary>
        public const uint ExtNestedCommandBufferSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_nested_command_buffer</b>]</summary>
        public const string ExtNestedCommandBufferExtensionName = "VK_EXT_nested_command_buffer";
        /// <summary>[from: <b>VK_EXT_external_memory_acquire_unmodified</b>]</summary>
        public const uint ExtExternalMemoryAcquireUnmodifiedSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_external_memory_acquire_unmodified</b>]</summary>
        public const string ExtExternalMemoryAcquireUnmodifiedExtensionName = "VK_EXT_external_memory_acquire_unmodified";
        /// <summary>[from: <b>VK_EXT_extended_dynamic_state3</b>]</summary>
        public const uint ExtExtendedDynamicState3SpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_extended_dynamic_state3</b>]</summary>
        public const string ExtExtendedDynamicState3ExtensionName = "VK_EXT_extended_dynamic_state3";
        /// <summary>[from: <b>VK_EXT_subpass_merge_feedback</b>]</summary>
        public const uint ExtSubpassMergeFeedbackSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_subpass_merge_feedback</b>]</summary>
        public const string ExtSubpassMergeFeedbackExtensionName = "VK_EXT_subpass_merge_feedback";
        /// <summary>[from: <b>VK_LUNARG_direct_driver_loading</b>]</summary>
        public const uint LunargDirectDriverLoadingSpecVersion = 1;
        /// <summary>[from: <b>VK_LUNARG_direct_driver_loading</b>]</summary>
        public const string LunargDirectDriverLoadingExtensionName = "VK_LUNARG_direct_driver_loading";
        /// <summary>[from: <b>VK_EXT_shader_module_identifier</b>]</summary>
        public const uint ExtShaderModuleIdentifierSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_module_identifier</b>]</summary>
        public const string ExtShaderModuleIdentifierExtensionName = "VK_EXT_shader_module_identifier";
        /// <summary>[from: <b>VK_EXT_rasterization_order_attachment_access</b>]</summary>
        public const uint ExtRasterizationOrderAttachmentAccessSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_rasterization_order_attachment_access</b>]</summary>
        public const string ExtRasterizationOrderAttachmentAccessExtensionName = "VK_EXT_rasterization_order_attachment_access";
        /// <summary>[from: <b>VK_NV_optical_flow</b>]</summary>
        public const uint NvOpticalFlowSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_optical_flow</b>]</summary>
        public const string NvOpticalFlowExtensionName = "VK_NV_optical_flow";
        /// <summary>[from: <b>VK_EXT_legacy_dithering</b>]</summary>
        public const uint ExtLegacyDitheringSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_legacy_dithering</b>]</summary>
        public const string ExtLegacyDitheringExtensionName = "VK_EXT_legacy_dithering";
        /// <summary>[from: <b>VK_EXT_pipeline_protected_access</b>]</summary>
        public const uint ExtPipelineProtectedAccessSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_pipeline_protected_access</b>]</summary>
        public const string ExtPipelineProtectedAccessExtensionName = "VK_EXT_pipeline_protected_access";
        /// <summary>[from: <b>VK_ANDROID_external_format_resolve</b>]</summary>
        public const uint AndroidExternalFormatResolveSpecVersion = 1;
        /// <summary>[from: <b>VK_ANDROID_external_format_resolve</b>]</summary>
        public const string AndroidExternalFormatResolveExtensionName = "VK_ANDROID_external_format_resolve";
        /// <summary>[from: <b>VK_KHR_maintenance5</b>]</summary>
        public const uint KhrMaintenance5SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_maintenance5</b>]</summary>
        public const string KhrMaintenance5ExtensionName = "VK_KHR_maintenance5";
        /// <summary>[from: <b>VK_KHR_ray_tracing_position_fetch</b>]</summary>
        public const uint KhrRayTracingPositionFetchSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_ray_tracing_position_fetch</b>]</summary>
        public const string KhrRayTracingPositionFetchExtensionName = "VK_KHR_ray_tracing_position_fetch";
        /// <summary>[from: <b>VK_EXT_shader_object</b>]</summary>
        public const uint ExtShaderObjectSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_object</b>]</summary>
        public const string ExtShaderObjectExtensionName = "VK_EXT_shader_object";
        /// <summary>[from: <b>VK_QCOM_tile_properties</b>]</summary>
        public const uint QcomTilePropertiesSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_tile_properties</b>]</summary>
        public const string QcomTilePropertiesExtensionName = "VK_QCOM_tile_properties";
        /// <summary>[from: <b>VK_SEC_amigo_profiling</b>]</summary>
        public const uint SecAmigoProfilingSpecVersion = 1;
        /// <summary>[from: <b>VK_SEC_amigo_profiling</b>]</summary>
        public const string SecAmigoProfilingExtensionName = "VK_SEC_amigo_profiling";
        /// <summary>[from: <b>VK_QCOM_multiview_per_view_viewports</b>]</summary>
        public const uint QcomMultiviewPerViewViewportsSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_multiview_per_view_viewports</b>]</summary>
        public const string QcomMultiviewPerViewViewportsExtensionName = "VK_QCOM_multiview_per_view_viewports";
        /// <summary>[from: <b>VK_NV_external_sci_sync2</b>]</summary>
        public const uint NvExternalSciSync2SpecVersion = 1;
        /// <summary>[from: <b>VK_NV_external_sci_sync2</b>]</summary>
        public const string NvExternalSciSync2ExtensionName = "VK_NV_external_sci_sync2";
        /// <summary>[from: <b>VK_NV_ray_tracing_invocation_reorder</b>]</summary>
        public const uint NvRayTracingInvocationReorderSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_ray_tracing_invocation_reorder</b>]</summary>
        public const string NvRayTracingInvocationReorderExtensionName = "VK_NV_ray_tracing_invocation_reorder";
        /// <summary>[from: <b>VK_NV_extended_sparse_address_space</b>]</summary>
        public const uint NvExtendedSparseAddressSpaceSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_extended_sparse_address_space</b>]</summary>
        public const string NvExtendedSparseAddressSpaceExtensionName = "VK_NV_extended_sparse_address_space";
        /// <summary>[from: <b>VK_EXT_mutable_descriptor_type</b>]</summary>
        public const uint ExtMutableDescriptorTypeSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_mutable_descriptor_type</b>]</summary>
        public const string ExtMutableDescriptorTypeExtensionName = "VK_EXT_mutable_descriptor_type";
        /// <summary>[from: <b>VK_EXT_legacy_vertex_attributes</b>]</summary>
        public const uint ExtLegacyVertexAttributesSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_legacy_vertex_attributes</b>]</summary>
        public const string ExtLegacyVertexAttributesExtensionName = "VK_EXT_legacy_vertex_attributes";
        /// <summary>[from: <b>VK_EXT_layer_settings</b>]</summary>
        public const uint ExtLayerSettingsSpecVersion = 2;
        /// <summary>[from: <b>VK_EXT_layer_settings</b>]</summary>
        public const string ExtLayerSettingsExtensionName = "VK_EXT_layer_settings";
        /// <summary>[from: <b>VK_ARM_shader_core_builtins</b>]</summary>
        public const uint ArmShaderCoreBuiltinsSpecVersion = 2;
        /// <summary>[from: <b>VK_ARM_shader_core_builtins</b>]</summary>
        public const string ArmShaderCoreBuiltinsExtensionName = "VK_ARM_shader_core_builtins";
        /// <summary>[from: <b>VK_EXT_pipeline_library_group_handles</b>]</summary>
        public const uint ExtPipelineLibraryGroupHandlesSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_pipeline_library_group_handles</b>]</summary>
        public const string ExtPipelineLibraryGroupHandlesExtensionName = "VK_EXT_pipeline_library_group_handles";
        /// <summary>[from: <b>VK_EXT_dynamic_rendering_unused_attachments</b>]</summary>
        public const uint ExtDynamicRenderingUnusedAttachmentsSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_dynamic_rendering_unused_attachments</b>]</summary>
        public const string ExtDynamicRenderingUnusedAttachmentsExtensionName = "VK_EXT_dynamic_rendering_unused_attachments";
        /// <summary>[from: <b>VK_NV_low_latency2</b>]</summary>
        public const uint NvLowLatency2SpecVersion = 2;
        /// <summary>[from: <b>VK_NV_low_latency2</b>]</summary>
        public const string NvLowLatency2ExtensionName = "VK_NV_low_latency2";
        /// <summary>[from: <b>VK_KHR_cooperative_matrix</b>]</summary>
        public const uint KhrCooperativeMatrixSpecVersion = 2;
        /// <summary>[from: <b>VK_KHR_cooperative_matrix</b>]</summary>
        public const string KhrCooperativeMatrixExtensionName = "VK_KHR_cooperative_matrix";
        /// <summary>[from: <b>VK_QCOM_multiview_per_view_render_areas</b>]</summary>
        public const uint QcomMultiviewPerViewRenderAreasSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_multiview_per_view_render_areas</b>]</summary>
        public const string QcomMultiviewPerViewRenderAreasExtensionName = "VK_QCOM_multiview_per_view_render_areas";
        /// <summary>[from: <b>VK_KHR_video_decode_av1</b>]</summary>
        public const uint KhrVideoDecodeAv1SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_video_decode_av1</b>]</summary>
        public const string KhrVideoDecodeAv1ExtensionName = "VK_KHR_video_decode_av1";
        /// <summary>[from: <b>VK_KHR_video_maintenance1</b>]</summary>
        public const uint KhrVideoMaintenance1SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_video_maintenance1</b>]</summary>
        public const string KhrVideoMaintenance1ExtensionName = "VK_KHR_video_maintenance1";
        /// <summary>[from: <b>VK_NV_per_stage_descriptor_set</b>]</summary>
        public const uint NvPerStageDescriptorSetSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_per_stage_descriptor_set</b>]</summary>
        public const string NvPerStageDescriptorSetExtensionName = "VK_NV_per_stage_descriptor_set";
        /// <summary>[from: <b>VK_QCOM_image_processing2</b>]</summary>
        public const uint QcomImageProcessing2SpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_image_processing2</b>]</summary>
        public const string QcomImageProcessing2ExtensionName = "VK_QCOM_image_processing2";
        /// <summary>[from: <b>VK_QCOM_filter_cubic_weights</b>]</summary>
        public const uint QcomFilterCubicWeightsSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_filter_cubic_weights</b>]</summary>
        public const string QcomFilterCubicWeightsExtensionName = "VK_QCOM_filter_cubic_weights";
        /// <summary>[from: <b>VK_QCOM_ycbcr_degamma</b>]</summary>
        public const uint QcomYcbcrDegammaSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_ycbcr_degamma</b>]</summary>
        public const string QcomYcbcrDegammaExtensionName = "VK_QCOM_ycbcr_degamma";
        /// <summary>[from: <b>VK_QCOM_filter_cubic_clamp</b>]</summary>
        public const uint QcomFilterCubicClampSpecVersion = 1;
        /// <summary>[from: <b>VK_QCOM_filter_cubic_clamp</b>]</summary>
        public const string QcomFilterCubicClampExtensionName = "VK_QCOM_filter_cubic_clamp";
        /// <summary>[from: <b>VK_EXT_attachment_feedback_loop_dynamic_state</b>]</summary>
        public const uint ExtAttachmentFeedbackLoopDynamicStateSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_attachment_feedback_loop_dynamic_state</b>]</summary>
        public const string ExtAttachmentFeedbackLoopDynamicStateExtensionName = "VK_EXT_attachment_feedback_loop_dynamic_state";
        /// <summary>[from: <b>VK_KHR_vertex_attribute_divisor</b>]</summary>
        public const uint KhrVertexAttributeDivisorSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_vertex_attribute_divisor</b>]</summary>
        public const string KhrVertexAttributeDivisorExtensionName = "VK_KHR_vertex_attribute_divisor";
        /// <summary>[from: <b>VK_KHR_load_store_op_none</b>]</summary>
        public const uint KhrLoadStoreOpNoneSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_load_store_op_none</b>]</summary>
        public const string KhrLoadStoreOpNoneExtensionName = "VK_KHR_load_store_op_none";
        /// <summary>[from: <b>VK_KHR_shader_float_controls2</b>]</summary>
        public const uint KhrShaderFloatControls2SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_float_controls2</b>]</summary>
        public const string KhrShaderFloatControls2ExtensionName = "VK_KHR_shader_float_controls2";
        /// <summary>[from: <b>VK_QNX_external_memory_screen_buffer</b>]</summary>
        public const uint QnxExternalMemoryScreenBufferSpecVersion = 1;
        /// <summary>[from: <b>VK_QNX_external_memory_screen_buffer</b>]</summary>
        public const string QnxExternalMemoryScreenBufferExtensionName = "VK_QNX_external_memory_screen_buffer";
        /// <summary>[from: <b>VK_MSFT_layered_driver</b>]</summary>
        public const uint MsftLayeredDriverSpecVersion = 1;
        /// <summary>[from: <b>VK_MSFT_layered_driver</b>]</summary>
        public const string MsftLayeredDriverExtensionName = "VK_MSFT_layered_driver";
        /// <summary>[from: <b>VK_KHR_index_type_uint8</b>]</summary>
        public const uint KhrIndexTypeUint8SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_index_type_uint8</b>]</summary>
        public const string KhrIndexTypeUint8ExtensionName = "VK_KHR_index_type_uint8";
        /// <summary>[from: <b>VK_KHR_line_rasterization</b>]</summary>
        public const uint KhrLineRasterizationSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_line_rasterization</b>]</summary>
        public const string KhrLineRasterizationExtensionName = "VK_KHR_line_rasterization";
        /// <summary>[from: <b>VK_KHR_calibrated_timestamps</b>]</summary>
        public const uint KhrCalibratedTimestampsSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_calibrated_timestamps</b>]</summary>
        public const string KhrCalibratedTimestampsExtensionName = "VK_KHR_calibrated_timestamps";
        /// <summary>[from: <b>VK_KHR_shader_expect_assume</b>]</summary>
        public const uint KhrShaderExpectAssumeSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_expect_assume</b>]</summary>
        public const string KhrShaderExpectAssumeExtensionName = "VK_KHR_shader_expect_assume";
        /// <summary>[from: <b>VK_KHR_maintenance6</b>]</summary>
        public const uint KhrMaintenance6SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_maintenance6</b>]</summary>
        public const string KhrMaintenance6ExtensionName = "VK_KHR_maintenance6";
        /// <summary>[from: <b>VK_NV_descriptor_pool_overallocation</b>]</summary>
        public const uint NvDescriptorPoolOverallocationSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_descriptor_pool_overallocation</b>]</summary>
        public const string NvDescriptorPoolOverallocationExtensionName = "VK_NV_descriptor_pool_overallocation";
        /// <summary>[from: <b>VK_NV_raw_access_chains</b>]</summary>
        public const uint NvRawAccessChainsSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_raw_access_chains</b>]</summary>
        public const string NvRawAccessChainsExtensionName = "VK_NV_raw_access_chains";
        /// <summary>[from: <b>VK_KHR_shader_relaxed_extended_instruction</b>]</summary>
        public const uint KhrShaderRelaxedExtendedInstructionSpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_shader_relaxed_extended_instruction</b>]</summary>
        public const string KhrShaderRelaxedExtendedInstructionExtensionName = "VK_KHR_shader_relaxed_extended_instruction";
        /// <summary>[from: <b>VK_KHR_maintenance7</b>]</summary>
        public const uint KhrMaintenance7SpecVersion = 1;
        /// <summary>[from: <b>VK_KHR_maintenance7</b>]</summary>
        public const string KhrMaintenance7ExtensionName = "VK_KHR_maintenance7";
        /// <summary>[from: <b>VK_NV_shader_atomic_float16_vector</b>]</summary>
        public const uint NvShaderAtomicFloat16VectorSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_shader_atomic_float16_vector</b>]</summary>
        public const string NvShaderAtomicFloat16VectorExtensionName = "VK_NV_shader_atomic_float16_vector";
        /// <summary>[from: <b>VK_EXT_shader_replicated_composites</b>]</summary>
        public const uint ExtShaderReplicatedCompositesSpecVersion = 1;
        /// <summary>[from: <b>VK_EXT_shader_replicated_composites</b>]</summary>
        public const string ExtShaderReplicatedCompositesExtensionName = "VK_EXT_shader_replicated_composites";
        /// <summary>[from: <b>VK_NV_ray_tracing_validation</b>]</summary>
        public const uint NvRayTracingValidationSpecVersion = 1;
        /// <summary>[from: <b>VK_NV_ray_tracing_validation</b>]</summary>
        public const string NvRayTracingValidationExtensionName = "VK_NV_ray_tracing_validation";
        /// <summary>[from: <b>VK_MESA_image_alignment_control</b>]</summary>
        public const uint MesaImageAlignmentControlSpecVersion = 1;
        /// <summary>[from: <b>VK_MESA_image_alignment_control</b>]</summary>
        public const string MesaImageAlignmentControlExtensionName = "VK_MESA_image_alignment_control";
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
