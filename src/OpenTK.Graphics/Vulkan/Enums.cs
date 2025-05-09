// This file is auto generated, do not edit.
using System;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> Used by <see cref="Vk.GetAccelerationStructureBuildSizesKHR"/>, <see cref="Vk.GetMicromapBuildSizesEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAccelerationStructureBuildTypeKHR.html" /></remarks>
    public enum VkAccelerationStructureBuildTypeKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        AccelerationStructureBuildTypeDeviceKhr = 1,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        AccelerationStructureBuildTypeHostKhr = 0,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        AccelerationStructureBuildTypeHostOrDeviceKhr = 2,
    }
    /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> Used by <see cref="Vk.GetDeviceAccelerationStructureCompatibilityKHR"/>, <see cref="Vk.GetDeviceMicromapCompatibilityEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAccelerationStructureCompatibilityKHR.html" /></remarks>
    public enum VkAccelerationStructureCompatibilityKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        AccelerationStructureCompatibilityCompatibleKhr = 0,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        AccelerationStructureCompatibilityIncompatibleKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAccelerationStructureCreateFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkAccelerationStructureCreateFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        AccelerationStructureCreateDescriptorBufferCaptureReplayBitExt = 8,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        AccelerationStructureCreateDeviceAddressCaptureReplayBitKhr = 1,
        /// <summary>[requires: <b>VK_NV_ray_tracing_motion_blur</b>] </summary>
        AccelerationStructureCreateMotionBitNv = 4,
    }
    /// <summary><b>[requires: VK_NV_ray_tracing]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAccelerationStructureMemoryRequirementsTypeNV.html" /></remarks>
    public enum VkAccelerationStructureMemoryRequirementsTypeNV : int
    {
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        AccelerationStructureMemoryRequirementsTypeBuildScratchNv = 1,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        AccelerationStructureMemoryRequirementsTypeObjectNv = 0,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        AccelerationStructureMemoryRequirementsTypeUpdateScratchNv = 2,
    }
    /// <summary><b>[requires: VK_NV_ray_tracing_motion_blur]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAccelerationStructureMotionInfoFlagsNV.html" /></remarks>
    [Flags]
    public enum VkAccelerationStructureMotionInfoFlagsNV : uint
    {
    }
    /// <summary><b>[requires: VK_NV_ray_tracing_motion_blur]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAccelerationStructureMotionInstanceFlagsNV.html" /></remarks>
    [Flags]
    public enum VkAccelerationStructureMotionInstanceFlagsNV : uint
    {
    }
    /// <summary><b>[requires: VK_NV_ray_tracing_motion_blur]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAccelerationStructureMotionInstanceTypeNV.html" /></remarks>
    public enum VkAccelerationStructureMotionInstanceTypeNV : int
    {
        /// <summary>[requires: <b>VK_NV_ray_tracing_motion_blur</b>] </summary>
        AccelerationStructureMotionInstanceTypeMatrixMotionNv = 1,
        /// <summary>[requires: <b>VK_NV_ray_tracing_motion_blur</b>] </summary>
        AccelerationStructureMotionInstanceTypeSrtMotionNv = 2,
        /// <summary>[requires: <b>VK_NV_ray_tracing_motion_blur</b>] </summary>
        AccelerationStructureMotionInstanceTypeStaticNv = 0,
    }
    /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAccelerationStructureTypeKHR.html" /></remarks>
    public enum VkAccelerationStructureTypeKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        AccelerationStructureTypeBottomLevelKhr = 1,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        AccelerationStructureTypeBottomLevelNv = 1,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        AccelerationStructureTypeGenericKhr = 2,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        AccelerationStructureTypeTopLevelKhr = 0,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        AccelerationStructureTypeTopLevelNv = 0,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAccessFlagBits.html" /></remarks>
    [Flags]
    public enum VkAccessFlagBits : uint
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        AccessAccelerationStructureReadBitKhr = 2097152,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        AccessAccelerationStructureReadBitNv = 2097152,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        AccessAccelerationStructureWriteBitKhr = 4194304,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        AccessAccelerationStructureWriteBitNv = 4194304,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of color attachment reads</summary>
        AccessColorAttachmentReadBit = 128,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        AccessColorAttachmentReadNoncoherentBitExt = 524288,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of color attachment writes</summary>
        AccessColorAttachmentWriteBit = 256,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        AccessCommandPreprocessReadBitExt = 131072,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        AccessCommandPreprocessReadBitNv = 131072,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        AccessCommandPreprocessWriteBitExt = 262144,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        AccessCommandPreprocessWriteBitNv = 262144,
        /// <summary>[requires: <b>VK_EXT_conditional_rendering</b>] read access flag for reading conditional rendering predicate</summary>
        AccessConditionalRenderingReadBitExt = 1048576,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of depth/stencil attachment reads</summary>
        AccessDepthStencilAttachmentReadBit = 512,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of depth/stencil attachment writes</summary>
        AccessDepthStencilAttachmentWriteBit = 1024,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        AccessFragmentDensityMapReadBitExt = 16777216,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        AccessFragmentShadingRateAttachmentReadBitKhr = 8388608,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of host reads</summary>
        AccessHostReadBit = 8192,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of host writes</summary>
        AccessHostWriteBit = 16384,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of index reads</summary>
        AccessIndexReadBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of indirect command reads</summary>
        AccessIndirectCommandReadBit = 1,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of input attachment reads</summary>
        AccessInputAttachmentReadBit = 16,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of memory reads</summary>
        AccessMemoryReadBit = 32768,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of memory writes</summary>
        AccessMemoryWriteBit = 65536,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        AccessNone = 0,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        AccessNoneKhr = 0,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of shader reads</summary>
        AccessShaderReadBit = 32,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of shader writes</summary>
        AccessShaderWriteBit = 64,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        AccessShadingRateImageReadBitNv = 8388608,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of transfer reads</summary>
        AccessTransferReadBit = 2048,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of transfer writes</summary>
        AccessTransferWriteBit = 4096,
        /// <summary>[requires: <b>VK_EXT_transform_feedback</b>] </summary>
        AccessTransformFeedbackCounterReadBitExt = 67108864,
        /// <summary>[requires: <b>VK_EXT_transform_feedback</b>] </summary>
        AccessTransformFeedbackCounterWriteBitExt = 134217728,
        /// <summary>[requires: <b>VK_EXT_transform_feedback</b>] </summary>
        AccessTransformFeedbackWriteBitExt = 33554432,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of uniform buffer reads</summary>
        AccessUniformReadBit = 8,
        /// <summary>[requires: <b>v1.0</b>] Controls coherency of vertex attribute reads</summary>
        AccessVertexAttributeReadBit = 4,
    }
    /// <summary><b>[requires: v1.3]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAccessFlagBits2.html" /></remarks>
    [Flags]
    public enum VkAccessFlagBits2 : ulong
    {
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2AccelerationStructureReadBitKhr = 2097152,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2AccelerationStructureReadBitNv = 2097152,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2AccelerationStructureWriteBitKhr = 4194304,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2AccelerationStructureWriteBitNv = 4194304,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2ColorAttachmentReadBit = 128,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2ColorAttachmentReadBitKhr = 128,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2ColorAttachmentReadNoncoherentBitExt = 524288,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2ColorAttachmentWriteBit = 256,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2ColorAttachmentWriteBitKhr = 256,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2CommandPreprocessReadBitExt = 131072,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2CommandPreprocessReadBitNv = 131072,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2CommandPreprocessWriteBitExt = 262144,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2CommandPreprocessWriteBitNv = 262144,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] read access flag for reading conditional rendering predicate</summary>
        Access2ConditionalRenderingReadBitExt = 1048576,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2DepthStencilAttachmentReadBit = 512,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2DepthStencilAttachmentReadBitKhr = 512,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2DepthStencilAttachmentWriteBit = 1024,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2DepthStencilAttachmentWriteBitKhr = 1024,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        Access2DescriptorBufferReadBitExt = 512,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2FragmentDensityMapReadBitExt = 16777216,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2FragmentShadingRateAttachmentReadBitKhr = 8388608,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2HostReadBit = 8192,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2HostReadBitKhr = 8192,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2HostWriteBit = 16384,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2HostWriteBitKhr = 16384,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2IndexReadBit = 2,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2IndexReadBitKhr = 2,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2IndirectCommandReadBit = 1,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2IndirectCommandReadBitKhr = 1,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2InputAttachmentReadBit = 16,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2InputAttachmentReadBitKhr = 16,
        /// <summary>[requires: <b>VK_HUAWEI_invocation_mask</b>] </summary>
        Access2InvocationMaskReadBitHuawei = 128,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2MemoryReadBit = 32768,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2MemoryReadBitKhr = 32768,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2MemoryWriteBit = 65536,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2MemoryWriteBitKhr = 65536,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        Access2MicromapReadBitExt = 4096,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        Access2MicromapWriteBitExt = 8192,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2None = 0,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2NoneKhr = 0,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        Access2OpticalFlowReadBitNv = 1024,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        Access2OpticalFlowWriteBitNv = 2048,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_maintenance1</b>] </summary>
        Access2ShaderBindingTableReadBitKhr = 256,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2ShaderReadBit = 32,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2ShaderReadBitKhr = 32,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2ShaderSampledReadBit = 4294967296,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2ShaderSampledReadBitKhr = 4294967296,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2ShaderStorageReadBit = 8589934592,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2ShaderStorageReadBitKhr = 8589934592,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2ShaderStorageWriteBit = 17179869184,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2ShaderStorageWriteBitKhr = 17179869184,
        /// <summary>[requires: <b>VK_QCOM_tile_shading</b>] </summary>
        Access2ShaderTileAttachmentReadBitQcom = 524288,
        /// <summary>[requires: <b>VK_QCOM_tile_shading</b>] </summary>
        Access2ShaderTileAttachmentWriteBitQcom = 1048576,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2ShaderWriteBit = 64,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2ShaderWriteBitKhr = 64,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2ShadingRateImageReadBitNv = 8388608,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2TransferReadBit = 2048,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2TransferReadBitKhr = 2048,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2TransferWriteBit = 4096,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2TransferWriteBitKhr = 4096,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2TransformFeedbackCounterReadBitExt = 67108864,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2TransformFeedbackCounterWriteBitExt = 134217728,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2TransformFeedbackWriteBitExt = 33554432,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2UniformReadBit = 8,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2UniformReadBitKhr = 8,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        Access2VertexAttributeReadBit = 4,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        Access2VertexAttributeReadBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        Access2VideoDecodeReadBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        Access2VideoDecodeWriteBitKhr = 16,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        Access2VideoEncodeReadBitKhr = 32,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        Access2VideoEncodeWriteBitKhr = 64,
    }
    /// <summary><b>[requires: VK_KHR_maintenance8]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAccessFlagBits3KHR.html" /></remarks>
    [Flags]
    public enum VkAccessFlagBits3KHR : ulong
    {
        /// <summary>[requires: <b>VK_KHR_maintenance8</b>] </summary>
        Access3NoneKhr = 0,
    }
    /// <summary><b>[requires: VK_KHR_synchronization2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAccessFlags2KHR.html" /></remarks>
    [Flags]
    public enum VkAccessFlags2KHR : ulong
    {
    }
    /// <summary><b>[requires: VK_KHR_performance_query]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAcquireProfilingLockFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkAcquireProfilingLockFlagBitsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_android_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAndroidSurfaceCreateFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkAndroidSurfaceCreateFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_AMD_anti_lag]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAntiLagModeAMD.html" /></remarks>
    public enum VkAntiLagModeAMD : int
    {
        /// <summary>[requires: <b>VK_AMD_anti_lag</b>] </summary>
        AntiLagModeDriverControlAmd = 0,
        /// <summary>[requires: <b>VK_AMD_anti_lag</b>] </summary>
        AntiLagModeOffAmd = 2,
        /// <summary>[requires: <b>VK_AMD_anti_lag</b>] </summary>
        AntiLagModeOnAmd = 1,
    }
    /// <summary><b>[requires: VK_AMD_anti_lag]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAntiLagStageAMD.html" /></remarks>
    public enum VkAntiLagStageAMD : int
    {
        /// <summary>[requires: <b>VK_AMD_anti_lag</b>] </summary>
        AntiLagStageInputAmd = 0,
        /// <summary>[requires: <b>VK_AMD_anti_lag</b>] </summary>
        AntiLagStagePresentAmd = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAttachmentDescriptionFlagBits.html" /></remarks>
    [Flags]
    public enum VkAttachmentDescriptionFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] The attachment may alias physical memory of another attachment in the same render pass</summary>
        AttachmentDescriptionMayAliasBit = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAttachmentLoadOp.html" /></remarks>
    public enum VkAttachmentLoadOp : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        AttachmentLoadOpClear = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        AttachmentLoadOpDontCare = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        AttachmentLoadOpLoad = 0,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        AttachmentLoadOpNone = 1000400000,
        /// <summary>[requires: <b>VK_EXT_load_store_op_none</b>] </summary>
        AttachmentLoadOpNoneExt = 1000400000,
        /// <summary>[requires: <b>VK_KHR_load_store_op_none</b>] </summary>
        AttachmentLoadOpNoneKhr = 1000400000,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkAttachmentStoreOp.html" /></remarks>
    public enum VkAttachmentStoreOp : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        AttachmentStoreOpDontCare = 1,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        AttachmentStoreOpNone = 1000301000,
        /// <summary>[requires: <b>VK_EXT_load_store_op_none</b>] </summary>
        AttachmentStoreOpNoneExt = 1000301000,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering | VK_KHR_load_store_op_none</b>] </summary>
        AttachmentStoreOpNoneKhr = 1000301000,
        /// <summary>[requires: <b>VK_QCOM_render_pass_store_ops</b>] </summary>
        AttachmentStoreOpNoneQcom = 1000301000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        AttachmentStoreOpStore = 0,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBlendFactor.html" /></remarks>
    public enum VkBlendFactor : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorConstantAlpha = 12,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorConstantColor = 10,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorDstAlpha = 8,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorDstColor = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorOne = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorOneMinusConstantAlpha = 13,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorOneMinusConstantColor = 11,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorOneMinusDstAlpha = 9,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorOneMinusDstColor = 5,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorOneMinusSrcAlpha = 7,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorOneMinusSrcColor = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorOneMinusSrc1Alpha = 18,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorOneMinusSrc1Color = 16,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorSrcAlpha = 6,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorSrcAlphaSaturate = 14,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorSrcColor = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorSrc1Alpha = 17,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorSrc1Color = 15,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendFactorZero = 0,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBlendOp.html" /></remarks>
    public enum VkBlendOp : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendOpAdd = 0,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpBlueExt = 1000148045,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpColorburnExt = 1000148018,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpColordodgeExt = 1000148017,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpContrastExt = 1000148041,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpDarkenExt = 1000148015,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpDifferenceExt = 1000148021,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpDstAtopExt = 1000148010,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpDstExt = 1000148002,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpDstInExt = 1000148006,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpDstOutExt = 1000148008,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpDstOverExt = 1000148004,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpExclusionExt = 1000148022,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpGreenExt = 1000148044,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpHardlightExt = 1000148019,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpHardmixExt = 1000148030,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpHslColorExt = 1000148033,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpHslHueExt = 1000148031,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpHslLuminosityExt = 1000148034,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpHslSaturationExt = 1000148032,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpInvertExt = 1000148023,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpInvertOvgExt = 1000148042,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpInvertRgbExt = 1000148024,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpLightenExt = 1000148016,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpLinearburnExt = 1000148026,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpLineardodgeExt = 1000148025,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpLinearlightExt = 1000148028,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendOpMax = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendOpMin = 3,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpMinusClampedExt = 1000148040,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpMinusExt = 1000148039,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpMultiplyExt = 1000148012,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpOverlayExt = 1000148014,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpPinlightExt = 1000148029,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpPlusClampedAlphaExt = 1000148037,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpPlusClampedExt = 1000148036,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpPlusDarkerExt = 1000148038,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpPlusExt = 1000148035,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpRedExt = 1000148043,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendOpReverseSubtract = 2,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpScreenExt = 1000148013,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpSoftlightExt = 1000148020,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpSrcAtopExt = 1000148009,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpSrcExt = 1000148001,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpSrcInExt = 1000148005,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpSrcOutExt = 1000148007,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpSrcOverExt = 1000148003,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BlendOpSubtract = 1,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpVividlightExt = 1000148027,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpXorExt = 1000148011,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOpZeroExt = 1000148000,
    }
    /// <summary><b>[requires: VK_EXT_blend_operation_advanced]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBlendOverlapEXT.html" /></remarks>
    public enum VkBlendOverlapEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOverlapConjointExt = 2,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOverlapDisjointExt = 1,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        BlendOverlapUncorrelatedExt = 0,
    }
    /// <summary><b>[requires: VK_QCOM_image_processing2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBlockMatchWindowCompareModeQCOM.html" /></remarks>
    public enum VkBlockMatchWindowCompareModeQCOM : int
    {
        /// <summary>[requires: <b>VK_QCOM_image_processing2</b>] </summary>
        BlockMatchWindowCompareModeMaxQcom = 1,
        /// <summary>[requires: <b>VK_QCOM_image_processing2</b>] </summary>
        BlockMatchWindowCompareModeMinQcom = 0,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBorderColor.html" /></remarks>
    public enum VkBorderColor : int
    {
        /// <summary>[requires: <b>VK_EXT_custom_border_color</b>] </summary>
        BorderColorFloatCustomExt = 1000287003,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BorderColorFloatOpaqueBlack = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BorderColorFloatOpaqueWhite = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BorderColorFloatTransparentBlack = 0,
        /// <summary>[requires: <b>VK_EXT_custom_border_color</b>] </summary>
        BorderColorIntCustomExt = 1000287004,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BorderColorIntOpaqueBlack = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BorderColorIntOpaqueWhite = 5,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        BorderColorIntTransparentBlack = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBufferCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkBufferCreateFlagBits : uint
    {
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        BufferCreateDescriptorBufferCaptureReplayBitExt = 32,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        BufferCreateDeviceAddressCaptureReplayBit = 16,
        /// <summary>[requires: <b>VK_EXT_buffer_device_address</b>] </summary>
        BufferCreateDeviceAddressCaptureReplayBitExt = 16,
        /// <summary>[requires: <b>VK_KHR_buffer_device_address</b>] </summary>
        BufferCreateDeviceAddressCaptureReplayBitKhr = 16,
        /// <summary>[requires: <b>v1.1</b>] Buffer requires protected memory</summary>
        BufferCreateProtectedBit = 8,
        /// <summary>[requires: <b>v1.0</b>] Buffer should support constant data access to physical memory ranges mapped into multiple locations of sparse buffers</summary>
        BufferCreateSparseAliasedBit = 4,
        /// <summary>[requires: <b>v1.0</b>] Buffer should support sparse backing</summary>
        BufferCreateSparseBindingBit = 1,
        /// <summary>[requires: <b>v1.0</b>] Buffer should support sparse backing with partial residency</summary>
        BufferCreateSparseResidencyBit = 2,
        /// <summary>[requires: <b>VK_KHR_video_maintenance1</b>] </summary>
        BufferCreateVideoProfileIndependentBitKhr = 64,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBufferUsageFlagBits.html" /></remarks>
    [Flags]
    public enum VkBufferUsageFlagBits : uint
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        BufferUsageAccelerationStructureBuildInputReadOnlyBitKhr = 524288,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        BufferUsageAccelerationStructureStorageBitKhr = 1048576,
        /// <summary>[requires: <b>VK_EXT_conditional_rendering</b>] Specifies the buffer can be used as predicate in conditional rendering</summary>
        BufferUsageConditionalRenderingBitExt = 512,
        /// <summary>[requires: <b>VK_AMDX_shader_enqueue</b>] </summary>
        BufferUsageExecutionGraphScratchBitAmdx = 33554432,
        /// <summary>[requires: <b>v1.0</b>] Can be used as source of fixed-function index fetch (index buffer)</summary>
        BufferUsageIndexBufferBit = 64,
        /// <summary>[requires: <b>v1.0</b>] Can be the source of indirect parameters (e.g. indirect buffer, parameter buffer)</summary>
        BufferUsageIndirectBufferBit = 256,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        BufferUsageMicromapBuildInputReadOnlyBitExt = 8388608,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        BufferUsageMicromapStorageBitExt = 16777216,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        BufferUsagePushDescriptorsDescriptorBufferBitExt = 67108864,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        BufferUsageRayTracingBitNv = 1024,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        BufferUsageResourceDescriptorBufferBitExt = 4194304,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        BufferUsageSamplerDescriptorBufferBitExt = 2097152,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        BufferUsageShaderBindingTableBitKhr = 1024,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        BufferUsageShaderDeviceAddressBit = 131072,
        /// <summary>[requires: <b>VK_EXT_buffer_device_address</b>] </summary>
        BufferUsageShaderDeviceAddressBitExt = 131072,
        /// <summary>[requires: <b>VK_KHR_buffer_device_address</b>] </summary>
        BufferUsageShaderDeviceAddressBitKhr = 131072,
        /// <summary>[requires: <b>v1.0</b>] Can be used as SSBO</summary>
        BufferUsageStorageBufferBit = 32,
        /// <summary>[requires: <b>v1.0</b>] Can be used as IBO</summary>
        BufferUsageStorageTexelBufferBit = 8,
        /// <summary>[requires: <b>v1.0</b>] Can be used as a destination of transfer operations</summary>
        BufferUsageTransferDstBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Can be used as a source of transfer operations</summary>
        BufferUsageTransferSrcBit = 1,
        /// <summary>[requires: <b>VK_EXT_transform_feedback</b>] </summary>
        BufferUsageTransformFeedbackBufferBitExt = 2048,
        /// <summary>[requires: <b>VK_EXT_transform_feedback</b>] </summary>
        BufferUsageTransformFeedbackCounterBufferBitExt = 4096,
        /// <summary>[requires: <b>v1.0</b>] Can be used as UBO</summary>
        BufferUsageUniformBufferBit = 16,
        /// <summary>[requires: <b>v1.0</b>] Can be used as TBO</summary>
        BufferUsageUniformTexelBufferBit = 4,
        /// <summary>[requires: <b>v1.0</b>] Can be used as source of fixed-function vertex fetch (VBO)</summary>
        BufferUsageVertexBufferBit = 128,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        BufferUsageVideoDecodeDstBitKhr = 16384,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        BufferUsageVideoDecodeSrcBitKhr = 8192,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        BufferUsageVideoEncodeDstBitKhr = 32768,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        BufferUsageVideoEncodeSrcBitKhr = 65536,
    }
    /// <summary><b>[requires: v1.4]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBufferUsageFlagBits2.html" /></remarks>
    [Flags]
    public enum VkBufferUsageFlagBits2 : ulong
    {
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2AccelerationStructureBuildInputReadOnlyBitKhr = 524288,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2AccelerationStructureStorageBitKhr = 1048576,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2ConditionalRenderingBitExt = 512,
        /// <summary>[requires: <b>VK_AMDX_shader_enqueue</b>] </summary>
        BufferUsage2ExecutionGraphScratchBitAmdx = 33554432,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        BufferUsage2IndexBufferBit = 64,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2IndexBufferBitKhr = 64,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        BufferUsage2IndirectBufferBit = 256,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2IndirectBufferBitKhr = 256,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2MicromapBuildInputReadOnlyBitExt = 8388608,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2MicromapStorageBitExt = 16777216,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        BufferUsage2PreprocessBufferBitExt = 18446744071562067968,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2PushDescriptorsDescriptorBufferBitExt = 67108864,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2RayTracingBitNv = 1024,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2ResourceDescriptorBufferBitExt = 4194304,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2SamplerDescriptorBufferBitExt = 2097152,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2ShaderBindingTableBitKhr = 1024,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        BufferUsage2ShaderDeviceAddressBit = 131072,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2ShaderDeviceAddressBitKhr = 131072,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        BufferUsage2StorageBufferBit = 32,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2StorageBufferBitKhr = 32,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        BufferUsage2StorageTexelBufferBit = 8,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2StorageTexelBufferBitKhr = 8,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        BufferUsage2TransferDstBit = 2,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2TransferDstBitKhr = 2,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        BufferUsage2TransferSrcBit = 1,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2TransferSrcBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2TransformFeedbackBufferBitExt = 2048,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2TransformFeedbackCounterBufferBitExt = 4096,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        BufferUsage2UniformBufferBit = 16,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2UniformBufferBitKhr = 16,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        BufferUsage2UniformTexelBufferBit = 4,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2UniformTexelBufferBitKhr = 4,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        BufferUsage2VertexBufferBit = 128,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2VertexBufferBitKhr = 128,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2VideoDecodeDstBitKhr = 16384,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2VideoDecodeSrcBitKhr = 8192,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2VideoEncodeDstBitKhr = 32768,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        BufferUsage2VideoEncodeSrcBitKhr = 65536,
    }
    /// <summary><b>[requires: VK_KHR_maintenance5]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBufferUsageFlags2KHR.html" /></remarks>
    [Flags]
    public enum VkBufferUsageFlags2KHR : ulong
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBufferViewCreateFlags.html" /></remarks>
    [Flags]
    public enum VkBufferViewCreateFlags : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBuildAccelerationStructureFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkBuildAccelerationStructureFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        BuildAccelerationStructureAllowCompactionBitKhr = 2,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        BuildAccelerationStructureAllowCompactionBitNv = 2,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_position_fetch</b>] </summary>
        BuildAccelerationStructureAllowDataAccessKhr = 2048,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        BuildAccelerationStructureAllowDisableOpacityMicromapsExt = 128,
        /// <summary>[requires: <b>VK_NV_displacement_micromap</b>] </summary>
        BuildAccelerationStructureAllowDisplacementMicromapUpdateNv = 512,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        BuildAccelerationStructureAllowOpacityMicromapDataUpdateExt = 256,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        BuildAccelerationStructureAllowOpacityMicromapUpdateExt = 64,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        BuildAccelerationStructureAllowUpdateBitKhr = 1,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        BuildAccelerationStructureAllowUpdateBitNv = 1,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        BuildAccelerationStructureLowMemoryBitKhr = 16,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        BuildAccelerationStructureLowMemoryBitNv = 16,
        /// <summary>[requires: <b>VK_NV_ray_tracing_motion_blur</b>] </summary>
        BuildAccelerationStructureMotionBitNv = 32,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        BuildAccelerationStructurePreferFastBuildBitKhr = 8,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        BuildAccelerationStructurePreferFastBuildBitNv = 8,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        BuildAccelerationStructurePreferFastTraceBitKhr = 4,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        BuildAccelerationStructurePreferFastTraceBitNv = 4,
    }
    /// <summary><b>[requires: VK_NV_ray_tracing]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBuildAccelerationStructureFlagsNV.html" /></remarks>
    [Flags]
    public enum VkBuildAccelerationStructureFlagsNV : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBuildAccelerationStructureModeKHR.html" /></remarks>
    public enum VkBuildAccelerationStructureModeKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        BuildAccelerationStructureModeBuildKhr = 0,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        BuildAccelerationStructureModeUpdateKhr = 1,
    }
    /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBuildMicromapFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkBuildMicromapFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        BuildMicromapAllowCompactionBitExt = 4,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        BuildMicromapPreferFastBuildBitExt = 2,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        BuildMicromapPreferFastTraceBitExt = 1,
    }
    /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkBuildMicromapModeEXT.html" /></remarks>
    public enum VkBuildMicromapModeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        BuildMicromapModeBuildExt = 0,
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkChromaLocation.html" /></remarks>
    public enum VkChromaLocation : int
    {
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ChromaLocationCositedEven = 0,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        ChromaLocationCositedEvenKhr = 0,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ChromaLocationMidpoint = 1,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        ChromaLocationMidpointKhr = 1,
    }
    /// <summary><b>[requires: VK_NV_cluster_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkClusterAccelerationStructureAddressResolutionFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkClusterAccelerationStructureAddressResolutionFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureAddressResolutionIndirectedDstAddressArrayBitNv = 4,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureAddressResolutionIndirectedDstImplicitDataBitNv = 1,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureAddressResolutionIndirectedDstSizesArrayBitNv = 8,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureAddressResolutionIndirectedScratchDataBitNv = 2,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureAddressResolutionIndirectedSrcInfosArrayBitNv = 16,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureAddressResolutionIndirectedSrcInfosCountBitNv = 32,
    }
    /// <summary><b>[requires: VK_NV_cluster_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkClusterAccelerationStructureClusterFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkClusterAccelerationStructureClusterFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureClusterAllowDisableOpacityMicromapsNv = 1,
    }
    /// <summary><b>[requires: VK_NV_cluster_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkClusterAccelerationStructureGeometryFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkClusterAccelerationStructureGeometryFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureGeometryCullDisableBitNv = 1,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureGeometryNoDuplicateAnyhitInvocationBitNv = 2,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureGeometryOpaqueBitNv = 4,
    }
    /// <summary><b>[requires: VK_NV_cluster_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkClusterAccelerationStructureIndexFormatFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkClusterAccelerationStructureIndexFormatFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureIndexFormat16bitNv = 2,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureIndexFormat32bitNv = 4,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureIndexFormat8bitNv = 1,
    }
    /// <summary><b>[requires: VK_NV_cluster_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkClusterAccelerationStructureOpModeNV.html" /></remarks>
    public enum VkClusterAccelerationStructureOpModeNV : int
    {
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureOpModeComputeSizesNv = 2,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureOpModeExplicitDestinationsNv = 1,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureOpModeImplicitDestinationsNv = 0,
    }
    /// <summary><b>[requires: VK_NV_cluster_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkClusterAccelerationStructureOpTypeNV.html" /></remarks>
    public enum VkClusterAccelerationStructureOpTypeNV : int
    {
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureOpTypeBuildClustersBottomLevelNv = 1,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureOpTypeBuildTriangleClusterNv = 2,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureOpTypeBuildTriangleClusterTemplateNv = 3,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureOpTypeInstantiateTriangleClusterNv = 4,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureOpTypeMoveObjectsNv = 0,
    }
    /// <summary><b>[requires: VK_NV_cluster_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkClusterAccelerationStructureTypeNV.html" /></remarks>
    public enum VkClusterAccelerationStructureTypeNV : int
    {
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureTypeClustersBottomLevelNv = 0,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureTypeTriangleClusterNv = 1,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        ClusterAccelerationStructureTypeTriangleClusterTemplateNv = 2,
    }
    /// <summary><b>[requires: VK_NV_shading_rate_image]</b> Used by <see cref="Vk.CmdSetCoarseSampleOrderNV"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCoarseSampleOrderTypeNV.html" /></remarks>
    public enum VkCoarseSampleOrderTypeNV : int
    {
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        CoarseSampleOrderTypeCustomNv = 1,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        CoarseSampleOrderTypeDefaultNv = 0,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        CoarseSampleOrderTypePixelMajorNv = 2,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        CoarseSampleOrderTypeSampleMajorNv = 3,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdSetColorWriteMaskEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkColorComponentFlagBits.html" /></remarks>
    [Flags]
    public enum VkColorComponentFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ColorComponentABit = 8,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ColorComponentBBit = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ColorComponentGBit = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ColorComponentRBit = 1,
    }
    /// <summary><b>[requires: VK_KHR_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkColorSpaceKHR.html" /></remarks>
    public enum VkColorSpaceKHR : int
    {
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceAdobergbLinearExt = 1000104011,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceAdobergbNonlinearExt = 1000104012,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceBt2020LinearExt = 1000104007,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceBt709LinearExt = 1000104005,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceBt709NonlinearExt = 1000104006,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceDciP3LinearExt = 1000104003,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceDciP3NonlinearExt = 1000104004,
        /// <summary>[requires: <b>VK_AMD_display_native_hdr</b>] </summary>
        ColorSpaceDisplayNativeAmd = 1000213000,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceDisplayP3LinearExt = 1000104003,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceDisplayP3NonlinearExt = 1000104001,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceDolbyvisionExt = 1000104009,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceExtendedSrgbLinearExt = 1000104002,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceExtendedSrgbNonlinearExt = 1000104014,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceHdr10HlgExt = 1000104010,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpaceHdr10St2084Ext = 1000104008,
        /// <summary>[requires: <b>VK_EXT_swapchain_colorspace</b>] </summary>
        ColorSpacePassThroughExt = 1000104013,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        ColorSpaceSrgbNonlinearKhr = 0,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        ColorspaceSrgbNonlinearKhr = 0,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCommandBufferLevel.html" /></remarks>
    public enum VkCommandBufferLevel : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CommandBufferLevelPrimary = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CommandBufferLevelSecondary = 1,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.ResetCommandBuffer"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCommandBufferResetFlagBits.html" /></remarks>
    [Flags]
    public enum VkCommandBufferResetFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] Release resources owned by the buffer</summary>
        CommandBufferResetReleaseResourcesBit = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCommandBufferUsageFlagBits.html" /></remarks>
    [Flags]
    public enum VkCommandBufferUsageFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CommandBufferUsageOneTimeSubmitBit = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CommandBufferUsageRenderPassContinueBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Command buffer may be submitted/executed more than once simultaneously</summary>
        CommandBufferUsageSimultaneousUseBit = 4,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCommandPoolCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkCommandPoolCreateFlagBits : uint
    {
        /// <summary>[requires: <b>v1.1</b>] Command buffers allocated from pool are protected command buffers</summary>
        CommandPoolCreateProtectedBit = 4,
        /// <summary>[requires: <b>v1.0</b>] Command buffers may release their memory individually</summary>
        CommandPoolCreateResetCommandBufferBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Command buffers have a short lifetime</summary>
        CommandPoolCreateTransientBit = 1,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.ResetCommandPool"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCommandPoolResetFlagBits.html" /></remarks>
    [Flags]
    public enum VkCommandPoolResetFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] Release resources owned by the pool</summary>
        CommandPoolResetReleaseResourcesBit = 1,
    }
    /// <summary><b>[requires: v1.1]</b> Used by <see cref="Vk.TrimCommandPool"/>, <see cref="Vk.TrimCommandPoolKHR"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCommandPoolTrimFlags.html" /></remarks>
    [Flags]
    public enum VkCommandPoolTrimFlags : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_maintenance1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCommandPoolTrimFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkCommandPoolTrimFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdSetDepthCompareOp"/>, <see cref="Vk.CmdSetDepthCompareOpEXT"/>, <see cref="Vk.CmdSetStencilOp"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCompareOp.html" /></remarks>
    public enum VkCompareOp : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CompareOpAlways = 7,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CompareOpEqual = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CompareOpGreater = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CompareOpGreaterOrEqual = 6,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CompareOpLess = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CompareOpLessOrEqual = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CompareOpNever = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CompareOpNotEqual = 5,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkComponentSwizzle.html" /></remarks>
    public enum VkComponentSwizzle : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ComponentSwizzleA = 6,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ComponentSwizzleB = 5,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ComponentSwizzleG = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ComponentSwizzleIdentity = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ComponentSwizzleOne = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ComponentSwizzleR = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ComponentSwizzleZero = 1,
    }
    /// <summary><b>[requires: VK_NV_cooperative_vector | VK_KHR_cooperative_matrix]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkComponentTypeKHR.html" /></remarks>
    public enum VkComponentTypeKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_shader_bfloat16</b>] </summary>
        ComponentTypeBfloat16Khr = 1000141000,
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        ComponentTypeFloatE4m3Nv = 1000491002,
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        ComponentTypeFloatE5m2Nv = 1000491003,
        /// <summary>[requires: <b>VK_NV_cooperative_vector | VK_KHR_cooperative_matrix</b>] </summary>
        ComponentTypeFloat16Khr = 0,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ComponentTypeFloat16Nv = 0,
        /// <summary>[requires: <b>VK_NV_cooperative_vector | VK_KHR_cooperative_matrix</b>] </summary>
        ComponentTypeFloat32Khr = 1,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ComponentTypeFloat32Nv = 1,
        /// <summary>[requires: <b>VK_NV_cooperative_vector | VK_KHR_cooperative_matrix</b>] </summary>
        ComponentTypeFloat64Khr = 2,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ComponentTypeFloat64Nv = 2,
        /// <summary>[requires: <b>VK_NV_cooperative_vector | VK_KHR_cooperative_matrix</b>] </summary>
        ComponentTypeSint16Khr = 4,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ComponentTypeSint16Nv = 4,
        /// <summary>[requires: <b>VK_NV_cooperative_vector | VK_KHR_cooperative_matrix</b>] </summary>
        ComponentTypeSint32Khr = 5,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ComponentTypeSint32Nv = 5,
        /// <summary>[requires: <b>VK_NV_cooperative_vector | VK_KHR_cooperative_matrix</b>] </summary>
        ComponentTypeSint64Khr = 6,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ComponentTypeSint64Nv = 6,
        /// <summary>[requires: <b>VK_NV_cooperative_vector | VK_KHR_cooperative_matrix</b>] </summary>
        ComponentTypeSint8Khr = 3,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ComponentTypeSint8Nv = 3,
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        ComponentTypeSint8PackedNv = 1000491000,
        /// <summary>[requires: <b>VK_NV_cooperative_vector | VK_KHR_cooperative_matrix</b>] </summary>
        ComponentTypeUint16Khr = 8,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ComponentTypeUint16Nv = 8,
        /// <summary>[requires: <b>VK_NV_cooperative_vector | VK_KHR_cooperative_matrix</b>] </summary>
        ComponentTypeUint32Khr = 9,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ComponentTypeUint32Nv = 9,
        /// <summary>[requires: <b>VK_NV_cooperative_vector | VK_KHR_cooperative_matrix</b>] </summary>
        ComponentTypeUint64Khr = 10,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ComponentTypeUint64Nv = 10,
        /// <summary>[requires: <b>VK_NV_cooperative_vector | VK_KHR_cooperative_matrix</b>] </summary>
        ComponentTypeUint8Khr = 7,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ComponentTypeUint8Nv = 7,
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        ComponentTypeUint8PackedNv = 1000491001,
    }
    /// <summary><b>[requires: VK_KHR_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCompositeAlphaFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkCompositeAlphaFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        CompositeAlphaInheritBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        CompositeAlphaOpaqueBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        CompositeAlphaPostMultipliedBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        CompositeAlphaPreMultipliedBitKhr = 2,
    }
    /// <summary><b>[requires: VK_EXT_conditional_rendering]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkConditionalRenderingFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkConditionalRenderingFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_conditional_rendering</b>] </summary>
        ConditionalRenderingInvertedBitExt = 1,
    }
    /// <summary><b>[requires: VK_EXT_conservative_rasterization]</b> Used by <see cref="Vk.CmdSetConservativeRasterizationModeEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkConservativeRasterizationModeEXT.html" /></remarks>
    public enum VkConservativeRasterizationModeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_conservative_rasterization</b>] </summary>
        ConservativeRasterizationModeDisabledExt = 0,
        /// <summary>[requires: <b>VK_EXT_conservative_rasterization</b>] </summary>
        ConservativeRasterizationModeOverestimateExt = 1,
        /// <summary>[requires: <b>VK_EXT_conservative_rasterization</b>] </summary>
        ConservativeRasterizationModeUnderestimateExt = 2,
    }
    /// <summary><b>[requires: VK_NV_cooperative_vector]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCooperativeVectorMatrixLayoutNV.html" /></remarks>
    public enum VkCooperativeVectorMatrixLayoutNV : int
    {
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        CooperativeVectorMatrixLayoutColumnMajorNv = 1,
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        CooperativeVectorMatrixLayoutInferencingOptimalNv = 2,
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        CooperativeVectorMatrixLayoutRowMajorNv = 0,
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        CooperativeVectorMatrixLayoutTrainingOptimalNv = 3,
    }
    /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> Used by <see cref="Vk.CmdCopyAccelerationStructureNV"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCopyAccelerationStructureModeKHR.html" /></remarks>
    public enum VkCopyAccelerationStructureModeKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        CopyAccelerationStructureModeCloneKhr = 0,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        CopyAccelerationStructureModeCloneNv = 0,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        CopyAccelerationStructureModeCompactKhr = 1,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        CopyAccelerationStructureModeCompactNv = 1,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        CopyAccelerationStructureModeDeserializeKhr = 3,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        CopyAccelerationStructureModeSerializeKhr = 2,
    }
    /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCopyMicromapModeEXT.html" /></remarks>
    public enum VkCopyMicromapModeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        CopyMicromapModeCloneExt = 0,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        CopyMicromapModeCompactExt = 3,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        CopyMicromapModeDeserializeExt = 2,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        CopyMicromapModeSerializeExt = 1,
    }
    /// <summary><b>[requires: VK_NV_framebuffer_mixed_samples]</b> Used by <see cref="Vk.CmdSetCoverageModulationModeNV"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCoverageModulationModeNV.html" /></remarks>
    public enum VkCoverageModulationModeNV : int
    {
        /// <summary>[requires: <b>VK_NV_framebuffer_mixed_samples</b>] </summary>
        CoverageModulationModeAlphaNv = 2,
        /// <summary>[requires: <b>VK_NV_framebuffer_mixed_samples</b>] </summary>
        CoverageModulationModeNoneNv = 0,
        /// <summary>[requires: <b>VK_NV_framebuffer_mixed_samples</b>] </summary>
        CoverageModulationModeRgbNv = 1,
        /// <summary>[requires: <b>VK_NV_framebuffer_mixed_samples</b>] </summary>
        CoverageModulationModeRgbaNv = 3,
    }
    /// <summary><b>[requires: VK_NV_coverage_reduction_mode]</b> Used by <see cref="Vk.CmdSetCoverageReductionModeNV"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCoverageReductionModeNV.html" /></remarks>
    public enum VkCoverageReductionModeNV : int
    {
        /// <summary>[requires: <b>VK_NV_coverage_reduction_mode</b>] </summary>
        CoverageReductionModeMergeNv = 0,
        /// <summary>[requires: <b>VK_NV_coverage_reduction_mode</b>] </summary>
        CoverageReductionModeTruncateNv = 1,
    }
    /// <summary><b>[requires: VK_QCOM_filter_cubic_weights]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCubicFilterWeightsQCOM.html" /></remarks>
    public enum VkCubicFilterWeightsQCOM : int
    {
        /// <summary>[requires: <b>VK_QCOM_filter_cubic_weights</b>] </summary>
        CubicFilterWeightsBSplineQcom = 2,
        /// <summary>[requires: <b>VK_QCOM_filter_cubic_weights</b>] </summary>
        CubicFilterWeightsCatmullRomQcom = 0,
        /// <summary>[requires: <b>VK_QCOM_filter_cubic_weights</b>] </summary>
        CubicFilterWeightsMitchellNetravaliQcom = 3,
        /// <summary>[requires: <b>VK_QCOM_filter_cubic_weights</b>] </summary>
        CubicFilterWeightsZeroTangentCardinalQcom = 1,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdSetCullMode"/>, <see cref="Vk.CmdSetCullModeEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkCullModeFlagBits.html" /></remarks>
    [Flags]
    public enum VkCullModeFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CullModeBackBit = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CullModeFrontAndBack = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CullModeFrontBit = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        CullModeNone = 0,
    }
    /// <summary><b>[requires: VK_EXT_debug_report]</b> Used by <see cref="Vk.DebugReportMessageEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDebugReportFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkDebugReportFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_debug_report</b>] </summary>
        DebugReportDebugBitExt = 16,
        /// <summary>[requires: <b>VK_EXT_debug_report</b>] </summary>
        DebugReportErrorBitExt = 8,
        /// <summary>[requires: <b>VK_EXT_debug_report</b>] </summary>
        DebugReportInformationBitExt = 1,
        /// <summary>[requires: <b>VK_EXT_debug_report</b>] </summary>
        DebugReportPerformanceWarningBitExt = 4,
        /// <summary>[requires: <b>VK_EXT_debug_report</b>] </summary>
        DebugReportWarningBitExt = 2,
    }
    /// <summary><b>[requires: VK_EXT_debug_report | VK_EXT_debug_marker]</b> Used by <see cref="Vk.DebugReportMessageEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDebugReportObjectTypeEXT.html" /></remarks>
    public enum VkDebugReportObjectTypeEXT : int
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        DebugReportObjectTypeAccelerationStructureKhrExt = 1000150000,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        DebugReportObjectTypeAccelerationStructureNvExt = 1000165000,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        DebugReportObjectTypeBufferCollectionFuchsiaExt = 1000366000,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeBufferExt = 9,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeBufferViewExt = 13,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeCommandBufferExt = 6,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeCommandPoolExt = 25,
        /// <summary>[requires: <b>VK_NVX_binary_import</b>] </summary>
        DebugReportObjectTypeCuFunctionNvxExt = 1000029001,
        /// <summary>[requires: <b>VK_NVX_binary_import</b>] </summary>
        DebugReportObjectTypeCuModuleNvxExt = 1000029000,
        /// <summary>[requires: <b>VK_NV_cuda_kernel_launch</b>] </summary>
        DebugReportObjectTypeCudaFunctionNvExt = 1000307001,
        /// <summary>[requires: <b>VK_NV_cuda_kernel_launch</b>] </summary>
        DebugReportObjectTypeCudaModuleNvExt = 1000307000,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeDebugReportCallbackExtExt = 28,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeDebugReportExt = 28,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeDescriptorPoolExt = 22,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeDescriptorSetExt = 23,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeDescriptorSetLayoutExt = 20,
        /// <summary>[requires: <b>VK_EXT_debug_report</b>] </summary>
        DebugReportObjectTypeDescriptorUpdateTemplateExt = 1000085000,
        /// <summary>[requires: <b>VK_KHR_descriptor_update_template</b>] </summary>
        DebugReportObjectTypeDescriptorUpdateTemplateKhrExt = 1000085000,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeDeviceExt = 3,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeDeviceMemoryExt = 8,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeDisplayKhrExt = 29,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeDisplayModeKhrExt = 30,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeEventExt = 11,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeFenceExt = 7,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeFramebufferExt = 24,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeImageExt = 10,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeImageViewExt = 14,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeInstanceExt = 1,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypePhysicalDeviceExt = 2,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypePipelineCacheExt = 16,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypePipelineExt = 19,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypePipelineLayoutExt = 17,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeQueryPoolExt = 12,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeQueueExt = 4,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeRenderPassExt = 18,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeSamplerExt = 21,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        DebugReportObjectTypeSamplerYcbcrConversionExt = 1000156000,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        DebugReportObjectTypeSamplerYcbcrConversionKhrExt = 1000156000,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeSemaphoreExt = 5,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeShaderModuleExt = 15,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeSurfaceKhrExt = 26,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeSwapchainKhrExt = 27,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeUnknownExt = 0,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeValidationCacheExt = 33,
        /// <summary>[requires: <b>VK_EXT_debug_report | VK_EXT_debug_marker</b>] </summary>
        DebugReportObjectTypeValidationCacheExtExt = 33,
    }
    /// <summary><b>[requires: VK_EXT_debug_utils]</b> Used by <see cref="Vk.SubmitDebugUtilsMessageEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDebugUtilsMessageSeverityFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkDebugUtilsMessageSeverityFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        DebugUtilsMessageSeverityErrorBitExt = 4096,
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        DebugUtilsMessageSeverityInfoBitExt = 16,
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        DebugUtilsMessageSeverityVerboseBitExt = 1,
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        DebugUtilsMessageSeverityWarningBitExt = 256,
    }
    /// <summary><b>[requires: VK_EXT_debug_utils]</b> Used by <see cref="Vk.SubmitDebugUtilsMessageEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDebugUtilsMessageTypeFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkDebugUtilsMessageTypeFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_device_address_binding_report</b>] </summary>
        DebugUtilsMessageTypeDeviceAddressBindingBitExt = 8,
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        DebugUtilsMessageTypeGeneralBitExt = 1,
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        DebugUtilsMessageTypePerformanceBitExt = 4,
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        DebugUtilsMessageTypeValidationBitExt = 2,
    }
    /// <summary><b>[requires: VK_EXT_debug_utils]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDebugUtilsMessengerCallbackDataFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkDebugUtilsMessengerCallbackDataFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_debug_utils]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDebugUtilsMessengerCreateFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkDebugUtilsMessengerCreateFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdPipelineBarrier"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDependencyFlagBits.html" /></remarks>
    [Flags]
    public enum VkDependencyFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] Dependency is per pixel region </summary>
        DependencyByRegionBit = 1,
        /// <summary>[requires: <b>v1.1</b>] Dependency is across devices</summary>
        DependencyDeviceGroupBit = 4,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        DependencyDeviceGroupBitKhr = 4,
        /// <summary>[requires: <b>VK_EXT_attachment_feedback_loop_layout</b>] Dependency may be a feedback loop</summary>
        DependencyFeedbackLoopBitExt = 8,
        /// <summary>[requires: <b>VK_KHR_maintenance8</b>] </summary>
        DependencyQueueFamilyOwnershipTransferUseAllStagesBitKhr = 32,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        DependencyViewLocalBit = 2,
        /// <summary>[requires: <b>VK_KHR_multiview</b>] </summary>
        DependencyViewLocalBitKhr = 2,
    }
    /// <summary><b>[requires: VK_EXT_depth_bias_control]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDepthBiasRepresentationEXT.html" /></remarks>
    public enum VkDepthBiasRepresentationEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_depth_bias_control</b>] </summary>
        DepthBiasRepresentationFloatExt = 2,
        /// <summary>[requires: <b>VK_EXT_depth_bias_control</b>] </summary>
        DepthBiasRepresentationLeastRepresentableValueForceUnormExt = 1,
        /// <summary>[requires: <b>VK_EXT_depth_bias_control</b>] </summary>
        DepthBiasRepresentationLeastRepresentableValueFormatExt = 0,
    }
    /// <summary><b>[requires: VK_EXT_depth_clamp_control]</b> Used by <see cref="Vk.CmdSetDepthClampRangeEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDepthClampModeEXT.html" /></remarks>
    public enum VkDepthClampModeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_depth_clamp_control</b>] </summary>
        DepthClampModeUserDefinedRangeExt = 1,
        /// <summary>[requires: <b>VK_EXT_depth_clamp_control</b>] </summary>
        DepthClampModeViewportRangeExt = 0,
    }
    /// <summary><b>[requires: v1.2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDescriptorBindingFlagBits.html" /></remarks>
    [Flags]
    public enum VkDescriptorBindingFlagBits : uint
    {
        /// <summary>[requires: <b>v1.2</b>] </summary>
        DescriptorBindingPartiallyBoundBit = 4,
        /// <summary>[requires: <b>VK_EXT_descriptor_indexing</b>] </summary>
        DescriptorBindingPartiallyBoundBitExt = 4,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        DescriptorBindingUpdateAfterBindBit = 1,
        /// <summary>[requires: <b>VK_EXT_descriptor_indexing</b>] </summary>
        DescriptorBindingUpdateAfterBindBitExt = 1,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        DescriptorBindingUpdateUnusedWhilePendingBit = 2,
        /// <summary>[requires: <b>VK_EXT_descriptor_indexing</b>] </summary>
        DescriptorBindingUpdateUnusedWhilePendingBitExt = 2,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        DescriptorBindingVariableDescriptorCountBit = 8,
        /// <summary>[requires: <b>VK_EXT_descriptor_indexing</b>] </summary>
        DescriptorBindingVariableDescriptorCountBitExt = 8,
    }
    /// <summary><b>[requires: VK_EXT_descriptor_indexing]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDescriptorBindingFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkDescriptorBindingFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDescriptorPoolCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkDescriptorPoolCreateFlagBits : uint
    {
        /// <summary>[requires: <b>VK_NV_descriptor_pool_overallocation</b>] </summary>
        DescriptorPoolCreateAllowOverallocationPoolsBitNv = 16,
        /// <summary>[requires: <b>VK_NV_descriptor_pool_overallocation</b>] </summary>
        DescriptorPoolCreateAllowOverallocationSetsBitNv = 8,
        /// <summary>[requires: <b>v1.0</b>] Descriptor sets may be freed individually</summary>
        DescriptorPoolCreateFreeDescriptorSetBit = 1,
        /// <summary>[requires: <b>VK_EXT_mutable_descriptor_type</b>] </summary>
        DescriptorPoolCreateHostOnlyBitExt = 4,
        /// <summary>[requires: <b>VK_VALVE_mutable_descriptor_type</b>] </summary>
        DescriptorPoolCreateHostOnlyBitValve = 4,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        DescriptorPoolCreateUpdateAfterBindBit = 2,
        /// <summary>[requires: <b>VK_EXT_descriptor_indexing</b>] </summary>
        DescriptorPoolCreateUpdateAfterBindBitExt = 2,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.ResetDescriptorPool"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDescriptorPoolResetFlags.html" /></remarks>
    [Flags]
    public enum VkDescriptorPoolResetFlags : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDescriptorSetLayoutCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkDescriptorSetLayoutCreateFlagBits : uint
    {
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        DescriptorSetLayoutCreateDescriptorBufferBitExt = 16,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        DescriptorSetLayoutCreateEmbeddedImmutableSamplersBitExt = 32,
        /// <summary>[requires: <b>VK_EXT_mutable_descriptor_type</b>] </summary>
        DescriptorSetLayoutCreateHostOnlyPoolBitExt = 4,
        /// <summary>[requires: <b>VK_VALVE_mutable_descriptor_type</b>] </summary>
        DescriptorSetLayoutCreateHostOnlyPoolBitValve = 4,
        /// <summary>[requires: <b>VK_NV_device_generated_commands_compute</b>] </summary>
        DescriptorSetLayoutCreateIndirectBindableBitNv = 128,
        /// <summary>[requires: <b>VK_NV_per_stage_descriptor_set</b>] </summary>
        DescriptorSetLayoutCreatePerStageBitNv = 64,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        DescriptorSetLayoutCreatePushDescriptorBit = 1,
        /// <summary>[requires: <b>VK_KHR_push_descriptor</b>] Descriptors are pushed via flink:vkCmdPushDescriptorSet</summary>
        DescriptorSetLayoutCreatePushDescriptorBitKhr = 1,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        DescriptorSetLayoutCreateUpdateAfterBindPoolBit = 2,
        /// <summary>[requires: <b>VK_EXT_descriptor_indexing</b>] </summary>
        DescriptorSetLayoutCreateUpdateAfterBindPoolBitExt = 2,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDescriptorType.html" /></remarks>
    public enum VkDescriptorType : int
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        DescriptorTypeAccelerationStructureKhr = 1000150000,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        DescriptorTypeAccelerationStructureNv = 1000165000,
        /// <summary>[requires: <b>VK_QCOM_image_processing</b>] </summary>
        DescriptorTypeBlockMatchImageQcom = 1000440001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DescriptorTypeCombinedImageSampler = 1,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DescriptorTypeInlineUniformBlock = 1000138000,
        /// <summary>[requires: <b>VK_EXT_inline_uniform_block</b>] </summary>
        DescriptorTypeInlineUniformBlockExt = 1000138000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DescriptorTypeInputAttachment = 10,
        /// <summary>[requires: <b>VK_EXT_mutable_descriptor_type</b>] </summary>
        DescriptorTypeMutableExt = 1000351000,
        /// <summary>[requires: <b>VK_VALVE_mutable_descriptor_type</b>] </summary>
        DescriptorTypeMutableValve = 1000351000,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        DescriptorTypePartitionedAccelerationStructureNv = 1000570000,
        /// <summary>[requires: <b>VK_QCOM_image_processing</b>] </summary>
        DescriptorTypeSampleWeightImageQcom = 1000440000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DescriptorTypeSampledImage = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DescriptorTypeSampler = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DescriptorTypeStorageBuffer = 7,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DescriptorTypeStorageBufferDynamic = 9,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DescriptorTypeStorageImage = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DescriptorTypeStorageTexelBuffer = 5,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DescriptorTypeUniformBuffer = 6,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DescriptorTypeUniformBufferDynamic = 8,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DescriptorTypeUniformTexelBuffer = 4,
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDescriptorUpdateTemplateCreateFlags.html" /></remarks>
    [Flags]
    public enum VkDescriptorUpdateTemplateCreateFlags : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_descriptor_update_template]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDescriptorUpdateTemplateCreateFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkDescriptorUpdateTemplateCreateFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDescriptorUpdateTemplateType.html" /></remarks>
    public enum VkDescriptorUpdateTemplateType : int
    {
        /// <summary>[requires: <b>v1.1</b>] Create descriptor update template for descriptor set updates</summary>
        DescriptorUpdateTemplateTypeDescriptorSet = 0,
        /// <summary>[requires: <b>VK_KHR_descriptor_update_template</b>] </summary>
        DescriptorUpdateTemplateTypeDescriptorSetKhr = 0,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        DescriptorUpdateTemplateTypePushDescriptors = 1,
        /// <summary>[requires: <b>VK_KHR_push_descriptor | VK_KHR_descriptor_update_template</b>] Create descriptor update template for pushed descriptor updates</summary>
        DescriptorUpdateTemplateTypePushDescriptorsKhr = 1,
    }
    /// <summary><b>[requires: VK_EXT_device_address_binding_report]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDeviceAddressBindingFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkDeviceAddressBindingFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_device_address_binding_report</b>] </summary>
        DeviceAddressBindingInternalObjectBitExt = 1,
    }
    /// <summary><b>[requires: VK_EXT_device_address_binding_report]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDeviceAddressBindingTypeEXT.html" /></remarks>
    public enum VkDeviceAddressBindingTypeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_device_address_binding_report</b>] </summary>
        DeviceAddressBindingTypeBindExt = 0,
        /// <summary>[requires: <b>VK_EXT_device_address_binding_report</b>] </summary>
        DeviceAddressBindingTypeUnbindExt = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDeviceCreateFlags.html" /></remarks>
    [Flags]
    public enum VkDeviceCreateFlags : uint
    {
    }
    /// <summary><b>[requires: VK_NV_device_diagnostics_config]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDeviceDiagnosticsConfigFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkDeviceDiagnosticsConfigFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_device_diagnostics_config</b>] </summary>
        DeviceDiagnosticsConfigEnableAutomaticCheckpointsBitNv = 4,
        /// <summary>[requires: <b>VK_NV_device_diagnostics_config</b>] </summary>
        DeviceDiagnosticsConfigEnableResourceTrackingBitNv = 2,
        /// <summary>[requires: <b>VK_NV_device_diagnostics_config</b>] </summary>
        DeviceDiagnosticsConfigEnableShaderDebugInfoBitNv = 1,
        /// <summary>[requires: <b>VK_NV_device_diagnostics_config</b>] </summary>
        DeviceDiagnosticsConfigEnableShaderErrorReportingBitNv = 8,
    }
    /// <summary><b>[requires: VK_EXT_display_control]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDeviceEventTypeEXT.html" /></remarks>
    public enum VkDeviceEventTypeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_display_control</b>] </summary>
        DeviceEventTypeDisplayHotplugExt = 0,
    }
    /// <summary><b>[requires: VK_EXT_device_fault]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDeviceFaultAddressTypeEXT.html" /></remarks>
    public enum VkDeviceFaultAddressTypeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_device_fault</b>] </summary>
        DeviceFaultAddressTypeExecuteInvalidExt = 3,
        /// <summary>[requires: <b>VK_EXT_device_fault</b>] </summary>
        DeviceFaultAddressTypeInstructionPointerFaultExt = 6,
        /// <summary>[requires: <b>VK_EXT_device_fault</b>] </summary>
        DeviceFaultAddressTypeInstructionPointerInvalidExt = 5,
        /// <summary>[requires: <b>VK_EXT_device_fault</b>] </summary>
        DeviceFaultAddressTypeInstructionPointerUnknownExt = 4,
        /// <summary>[requires: <b>VK_EXT_device_fault</b>] Currently unused</summary>
        DeviceFaultAddressTypeNoneExt = 0,
        /// <summary>[requires: <b>VK_EXT_device_fault</b>] </summary>
        DeviceFaultAddressTypeReadInvalidExt = 1,
        /// <summary>[requires: <b>VK_EXT_device_fault</b>] </summary>
        DeviceFaultAddressTypeWriteInvalidExt = 2,
    }
    /// <summary><b>[requires: VK_EXT_device_fault]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDeviceFaultVendorBinaryHeaderVersionEXT.html" /></remarks>
    public enum VkDeviceFaultVendorBinaryHeaderVersionEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_device_fault</b>] </summary>
        DeviceFaultVendorBinaryHeaderVersionOneExt = 1,
    }
    /// <summary><b>[requires: VK_KHR_swapchain | VK_KHR_device_group]</b> Used by <see cref="Vk.GetDeviceGroupSurfacePresentModes2EXT"/>, <see cref="Vk.GetDeviceGroupSurfacePresentModesKHR"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDeviceGroupPresentModeFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkDeviceGroupPresentModeFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_swapchain | VK_KHR_device_group</b>] Present from local memory</summary>
        DeviceGroupPresentModeLocalBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_swapchain | VK_KHR_device_group</b>] Each physical device presents from local memory</summary>
        DeviceGroupPresentModeLocalMultiDeviceBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_swapchain | VK_KHR_device_group</b>] Present from remote memory</summary>
        DeviceGroupPresentModeRemoteBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_swapchain | VK_KHR_device_group</b>] Present sum of local and/or remote memory</summary>
        DeviceGroupPresentModeSumBitKhr = 4,
    }
    /// <summary><b>[requires: VK_EXT_device_memory_report]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDeviceMemoryReportEventTypeEXT.html" /></remarks>
    public enum VkDeviceMemoryReportEventTypeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_device_memory_report</b>] </summary>
        DeviceMemoryReportEventTypeAllocateExt = 0,
        /// <summary>[requires: <b>VK_EXT_device_memory_report</b>] </summary>
        DeviceMemoryReportEventTypeAllocationFailedExt = 4,
        /// <summary>[requires: <b>VK_EXT_device_memory_report</b>] </summary>
        DeviceMemoryReportEventTypeFreeExt = 1,
        /// <summary>[requires: <b>VK_EXT_device_memory_report</b>] </summary>
        DeviceMemoryReportEventTypeImportExt = 2,
        /// <summary>[requires: <b>VK_EXT_device_memory_report</b>] </summary>
        DeviceMemoryReportEventTypeUnimportExt = 3,
    }
    /// <summary><b>[requires: VK_EXT_device_memory_report]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDeviceMemoryReportFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkDeviceMemoryReportFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDeviceQueueCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkDeviceQueueCreateFlagBits : uint
    {
        /// <summary>[requires: <b>v1.1</b>] Queue is a protected-capable device queue</summary>
        DeviceQueueCreateProtectedBit = 1,
    }
    /// <summary><b>[requires: VK_LUNARG_direct_driver_loading]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDirectDriverLoadingFlagsLUNARG.html" /></remarks>
    [Flags]
    public enum VkDirectDriverLoadingFlagsLUNARG : uint
    {
    }
    /// <summary><b>[requires: VK_LUNARG_direct_driver_loading]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDirectDriverLoadingModeLUNARG.html" /></remarks>
    public enum VkDirectDriverLoadingModeLUNARG : int
    {
        /// <summary>[requires: <b>VK_LUNARG_direct_driver_loading</b>] </summary>
        DirectDriverLoadingModeExclusiveLunarg = 0,
        /// <summary>[requires: <b>VK_LUNARG_direct_driver_loading</b>] </summary>
        DirectDriverLoadingModeInclusiveLunarg = 1,
    }
    /// <summary><b>[requires: VK_EXT_directfb_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDirectFBSurfaceCreateFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkDirectFBSurfaceCreateFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_discard_rectangles]</b> Used by <see cref="Vk.CmdSetDiscardRectangleModeEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDiscardRectangleModeEXT.html" /></remarks>
    public enum VkDiscardRectangleModeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_discard_rectangles</b>] </summary>
        DiscardRectangleModeExclusiveExt = 1,
        /// <summary>[requires: <b>VK_EXT_discard_rectangles</b>] </summary>
        DiscardRectangleModeInclusiveExt = 0,
    }
    /// <summary><b>[requires: VK_NV_displacement_micromap]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDisplacementMicromapFormatNV.html" /></remarks>
    public enum VkDisplacementMicromapFormatNV : int
    {
        /// <summary>[requires: <b>VK_NV_displacement_micromap</b>] </summary>
        DisplacementMicromapFormat1024Triangles128BytesNv = 3,
        /// <summary>[requires: <b>VK_NV_displacement_micromap</b>] </summary>
        DisplacementMicromapFormat256Triangles128BytesNv = 2,
        /// <summary>[requires: <b>VK_NV_displacement_micromap</b>] </summary>
        DisplacementMicromapFormat64Triangles64BytesNv = 1,
    }
    /// <summary><b>[requires: VK_EXT_display_control]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDisplayEventTypeEXT.html" /></remarks>
    public enum VkDisplayEventTypeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_display_control</b>] </summary>
        DisplayEventTypeFirstPixelOutExt = 0,
    }
    /// <summary><b>[requires: VK_KHR_display]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDisplayModeCreateFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkDisplayModeCreateFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_display]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDisplayPlaneAlphaFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkDisplayPlaneAlphaFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_display</b>] </summary>
        DisplayPlaneAlphaGlobalBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_display</b>] </summary>
        DisplayPlaneAlphaOpaqueBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_display</b>] </summary>
        DisplayPlaneAlphaPerPixelBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_display</b>] </summary>
        DisplayPlaneAlphaPerPixelPremultipliedBitKhr = 8,
    }
    /// <summary><b>[requires: VK_EXT_display_control]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDisplayPowerStateEXT.html" /></remarks>
    public enum VkDisplayPowerStateEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_display_control</b>] </summary>
        DisplayPowerStateOffExt = 0,
        /// <summary>[requires: <b>VK_EXT_display_control</b>] </summary>
        DisplayPowerStateOnExt = 2,
        /// <summary>[requires: <b>VK_EXT_display_control</b>] </summary>
        DisplayPowerStateSuspendExt = 1,
    }
    /// <summary><b>[requires: VK_KHR_display]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDisplaySurfaceCreateFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkDisplaySurfaceCreateFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_NV_display_stereo]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDisplaySurfaceStereoTypeNV.html" /></remarks>
    public enum VkDisplaySurfaceStereoTypeNV : int
    {
        /// <summary>[requires: <b>VK_NV_display_stereo</b>] </summary>
        DisplaySurfaceStereoTypeHdmi3dNv = 2,
        /// <summary>[requires: <b>VK_NV_display_stereo</b>] </summary>
        DisplaySurfaceStereoTypeInbandDisplayportNv = 3,
        /// <summary>[requires: <b>VK_NV_display_stereo</b>] </summary>
        DisplaySurfaceStereoTypeNoneNv = 0,
        /// <summary>[requires: <b>VK_NV_display_stereo</b>] </summary>
        DisplaySurfaceStereoTypeOnboardDinNv = 1,
    }
    /// <summary><b>[requires: v1.2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDriverId.html" /></remarks>
    public enum VkDriverId : int
    {
        /// <summary>[requires: <b>v1.2</b>] Advanced Micro Devices, Inc.</summary>
        DriverIdAmdOpenSource = 2,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        DriverIdAmdOpenSourceKhr = 2,
        /// <summary>[requires: <b>v1.2</b>] Advanced Micro Devices, Inc.</summary>
        DriverIdAmdProprietary = 1,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        DriverIdAmdProprietaryKhr = 1,
        /// <summary>[requires: <b>v1.2</b>] Arm Limited</summary>
        DriverIdArmProprietary = 9,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        DriverIdArmProprietaryKhr = 9,
        /// <summary>[requires: <b>v1.2</b>] Broadcom Inc.</summary>
        DriverIdBroadcomProprietary = 12,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        DriverIdBroadcomProprietaryKhr = 12,
        /// <summary>[requires: <b>v1.2</b>] Core Avionics &amp; Industrial Inc.</summary>
        DriverIdCoreaviProprietary = 15,
        /// <summary>[requires: <b>v1.2</b>] Google LLC</summary>
        DriverIdGgpProprietary = 11,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        DriverIdGgpProprietaryKhr = 11,
        /// <summary>[requires: <b>v1.2</b>] Google LLC</summary>
        DriverIdGoogleSwiftshader = 10,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        DriverIdGoogleSwiftshaderKhr = 10,
        /// <summary>[requires: <b>v1.2</b>] Imagination Technologies</summary>
        DriverIdImaginationOpenSourceMesa = 25,
        /// <summary>[requires: <b>v1.2</b>] Imagination Technologies</summary>
        DriverIdImaginationProprietary = 7,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        DriverIdImaginationProprietaryKhr = 7,
        /// <summary>[requires: <b>v1.2</b>] Intel Corporation</summary>
        DriverIdIntelOpenSourceMesa = 6,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        DriverIdIntelOpenSourceMesaKhr = 6,
        /// <summary>[requires: <b>v1.2</b>] Intel Corporation</summary>
        DriverIdIntelProprietaryWindows = 5,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        DriverIdIntelProprietaryWindowsKhr = 5,
        /// <summary>[requires: <b>v1.2</b>] Juice Technologies, Inc.</summary>
        DriverIdJuiceProprietary = 16,
        /// <summary>[requires: <b>v1.2</b>] Mesa open source project</summary>
        DriverIdMesaDozen = 23,
        /// <summary>[requires: <b>v1.2</b>] Mesa open source project</summary>
        DriverIdMesaHoneykrisp = 26,
        /// <summary>[requires: <b>v1.2</b>] Mesa</summary>
        DriverIdMesaLlvmpipe = 13,
        /// <summary>[requires: <b>v1.2</b>] Mesa open source project</summary>
        DriverIdMesaNvk = 24,
        /// <summary>[requires: <b>v1.2</b>] Mesa open source project</summary>
        DriverIdMesaPanvk = 20,
        /// <summary>[requires: <b>v1.2</b>] Mesa open source project</summary>
        DriverIdMesaRadv = 3,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        DriverIdMesaRadvKhr = 3,
        /// <summary>[requires: <b>v1.2</b>] Mesa open source project</summary>
        DriverIdMesaTurnip = 18,
        /// <summary>[requires: <b>v1.2</b>] Mesa open source project</summary>
        DriverIdMesaV3dv = 19,
        /// <summary>[requires: <b>v1.2</b>] Mesa open source project</summary>
        DriverIdMesaVenus = 22,
        /// <summary>[requires: <b>v1.2</b>] MoltenVK</summary>
        DriverIdMoltenvk = 14,
        /// <summary>[requires: <b>v1.2</b>] NVIDIA Corporation</summary>
        DriverIdNvidiaProprietary = 4,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        DriverIdNvidiaProprietaryKhr = 4,
        /// <summary>[requires: <b>v1.2</b>] Qualcomm Technologies, Inc.</summary>
        DriverIdQualcommProprietary = 8,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        DriverIdQualcommProprietaryKhr = 8,
        /// <summary>[requires: <b>v1.2</b>] Samsung Electronics Co., Ltd.</summary>
        DriverIdSamsungProprietary = 21,
        /// <summary>[requires: <b>v1.2</b>] Verisilicon, Inc.</summary>
        DriverIdVerisiliconProprietary = 17,
        /// <summary>[requires: <b>v1.2</b>] Vulkan SC Emulation on Vulkan</summary>
        DriverIdVulkanScEmulationOnVulkan = 27,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkDynamicState.html" /></remarks>
    public enum VkDynamicState : int
    {
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateAlphaToCoverageEnableExt = 1000455007,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateAlphaToOneEnableExt = 1000455008,
        /// <summary>[requires: <b>VK_EXT_attachment_feedback_loop_dynamic_state</b>] </summary>
        DynamicStateAttachmentFeedbackLoopEnableExt = 1000524000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DynamicStateBlendConstants = 4,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateColorBlendAdvancedExt = 1000455018,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateColorBlendEnableExt = 1000455010,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateColorBlendEquationExt = 1000455011,
        /// <summary>[requires: <b>VK_EXT_color_write_enable</b>] </summary>
        DynamicStateColorWriteEnableExt = 1000381000,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateColorWriteMaskExt = 1000455012,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateConservativeRasterizationModeExt = 1000455014,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateCoverageModulationModeNv = 1000455027,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateCoverageModulationTableEnableNv = 1000455028,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateCoverageModulationTableNv = 1000455029,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateCoverageReductionModeNv = 1000455032,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateCoverageToColorEnableNv = 1000455025,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateCoverageToColorLocationNv = 1000455026,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateCullMode = 1000267000,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] </summary>
        DynamicStateCullModeExt = 1000267000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DynamicStateDepthBias = 3,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateDepthBiasEnable = 1000377002,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state2</b>] </summary>
        DynamicStateDepthBiasEnableExt = 1000377002,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DynamicStateDepthBounds = 5,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateDepthBoundsTestEnable = 1000267009,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] </summary>
        DynamicStateDepthBoundsTestEnableExt = 1000267009,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateDepthClampEnableExt = 1000455003,
        /// <summary>[requires: <b>VK_EXT_depth_clamp_control</b>] </summary>
        DynamicStateDepthClampRangeExt = 1000582000,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateDepthClipEnableExt = 1000455016,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateDepthClipNegativeOneToOneExt = 1000455022,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateDepthCompareOp = 1000267008,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] </summary>
        DynamicStateDepthCompareOpExt = 1000267008,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateDepthTestEnable = 1000267006,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] </summary>
        DynamicStateDepthTestEnableExt = 1000267006,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateDepthWriteEnable = 1000267007,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] </summary>
        DynamicStateDepthWriteEnableExt = 1000267007,
        /// <summary>[requires: <b>VK_EXT_discard_rectangles</b>] </summary>
        DynamicStateDiscardRectangleEnableExt = 1000099001,
        /// <summary>[requires: <b>VK_EXT_discard_rectangles</b>] </summary>
        DynamicStateDiscardRectangleExt = 1000099000,
        /// <summary>[requires: <b>VK_EXT_discard_rectangles</b>] </summary>
        DynamicStateDiscardRectangleModeExt = 1000099002,
        /// <summary>[requires: <b>VK_NV_scissor_exclusive</b>] </summary>
        DynamicStateExclusiveScissorEnableNv = 1000205000,
        /// <summary>[requires: <b>VK_NV_scissor_exclusive</b>] </summary>
        DynamicStateExclusiveScissorNv = 1000205001,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateExtraPrimitiveOverestimationSizeExt = 1000455015,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        DynamicStateFragmentShadingRateKhr = 1000226000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateFrontFace = 1000267001,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] </summary>
        DynamicStateFrontFaceExt = 1000267001,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateLineRasterizationModeExt = 1000455020,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        DynamicStateLineStipple = 1000259000,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateLineStippleEnableExt = 1000455021,
        /// <summary>[requires: <b>VK_EXT_line_rasterization</b>] </summary>
        DynamicStateLineStippleExt = 1000259000,
        /// <summary>[requires: <b>VK_KHR_line_rasterization</b>] </summary>
        DynamicStateLineStippleKhr = 1000259000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DynamicStateLineWidth = 2,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateLogicOpEnableExt = 1000455009,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state2</b>] Not promoted to 1.3</summary>
        DynamicStateLogicOpExt = 1000377003,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state2</b>] Not promoted to 1.3</summary>
        DynamicStatePatchControlPointsExt = 1000377000,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStatePolygonModeExt = 1000455004,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStatePrimitiveRestartEnable = 1000377004,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state2</b>] </summary>
        DynamicStatePrimitiveRestartEnableExt = 1000377004,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStatePrimitiveTopology = 1000267002,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] </summary>
        DynamicStatePrimitiveTopologyExt = 1000267002,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateProvokingVertexModeExt = 1000455019,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateRasterizationSamplesExt = 1000455005,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateRasterizationStreamExt = 1000455013,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateRasterizerDiscardEnable = 1000377001,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state2</b>] </summary>
        DynamicStateRasterizerDiscardEnableExt = 1000377001,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        DynamicStateRayTracingPipelineStackSizeKhr = 1000347000,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateRepresentativeFragmentTestEnableNv = 1000455031,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateSampleLocationsEnableExt = 1000455017,
        /// <summary>[requires: <b>VK_EXT_sample_locations</b>] </summary>
        DynamicStateSampleLocationsExt = 1000143000,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateSampleMaskExt = 1000455006,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DynamicStateScissor = 1,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateScissorWithCount = 1000267004,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] </summary>
        DynamicStateScissorWithCountExt = 1000267004,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateShadingRateImageEnableNv = 1000455030,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DynamicStateStencilCompareMask = 6,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateStencilOp = 1000267011,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] </summary>
        DynamicStateStencilOpExt = 1000267011,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DynamicStateStencilReference = 8,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateStencilTestEnable = 1000267010,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] </summary>
        DynamicStateStencilTestEnableExt = 1000267010,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DynamicStateStencilWriteMask = 7,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateTessellationDomainOriginExt = 1000455002,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateVertexInputBindingStride = 1000267005,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] </summary>
        DynamicStateVertexInputBindingStrideExt = 1000267005,
        /// <summary>[requires: <b>VK_EXT_vertex_input_dynamic_state</b>] </summary>
        DynamicStateVertexInputExt = 1000352000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        DynamicStateViewport = 0,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        DynamicStateViewportCoarseSampleOrderNv = 1000164006,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        DynamicStateViewportShadingRatePaletteNv = 1000164004,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateViewportSwizzleNv = 1000455024,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        DynamicStateViewportWScalingEnableNv = 1000455023,
        /// <summary>[requires: <b>VK_NV_clip_space_w_scaling</b>] </summary>
        DynamicStateViewportWScalingNv = 1000087000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        DynamicStateViewportWithCount = 1000267003,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] </summary>
        DynamicStateViewportWithCountExt = 1000267003,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkEventCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkEventCreateFlagBits : uint
    {
        /// <summary>[requires: <b>v1.3</b>] </summary>
        EventCreateDeviceOnlyBit = 1,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        EventCreateDeviceOnlyBitKhr = 1,
    }
    /// <summary><b>[requires: VK_EXT_metal_objects]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExportMetalObjectTypeFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkExportMetalObjectTypeFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        ExportMetalObjectTypeMetalBufferBitExt = 4,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        ExportMetalObjectTypeMetalCommandQueueBitExt = 2,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        ExportMetalObjectTypeMetalDeviceBitExt = 1,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        ExportMetalObjectTypeMetalIosurfaceBitExt = 16,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        ExportMetalObjectTypeMetalSharedEventBitExt = 32,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        ExportMetalObjectTypeMetalTextureBitExt = 8,
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalFenceFeatureFlagBits.html" /></remarks>
    [Flags]
    public enum VkExternalFenceFeatureFlagBits : uint
    {
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalFenceFeatureExportableBit = 1,
        /// <summary>[requires: <b>VK_KHR_external_fence_capabilities</b>] </summary>
        ExternalFenceFeatureExportableBitKhr = 1,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalFenceFeatureImportableBit = 2,
        /// <summary>[requires: <b>VK_KHR_external_fence_capabilities</b>] </summary>
        ExternalFenceFeatureImportableBitKhr = 2,
    }
    /// <summary><b>[requires: VK_KHR_external_fence_capabilities]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalFenceFeatureFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkExternalFenceFeatureFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalFenceHandleTypeFlagBits.html" /></remarks>
    [Flags]
    public enum VkExternalFenceHandleTypeFlagBits : uint
    {
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalFenceHandleTypeOpaqueFdBit = 1,
        /// <summary>[requires: <b>VK_KHR_external_fence_capabilities</b>] </summary>
        ExternalFenceHandleTypeOpaqueFdBitKhr = 1,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalFenceHandleTypeOpaqueWin32Bit = 2,
        /// <summary>[requires: <b>VK_KHR_external_fence_capabilities</b>] </summary>
        ExternalFenceHandleTypeOpaqueWin32BitKhr = 2,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalFenceHandleTypeOpaqueWin32KmtBit = 4,
        /// <summary>[requires: <b>VK_KHR_external_fence_capabilities</b>] </summary>
        ExternalFenceHandleTypeOpaqueWin32KmtBitKhr = 4,
        /// <summary>[requires: <b>VK_NV_external_sci_sync | VK_NV_external_sci_sync2</b>] </summary>
        ExternalFenceHandleTypeSciSyncFenceBitNv = 32,
        /// <summary>[requires: <b>VK_NV_external_sci_sync | VK_NV_external_sci_sync2</b>] </summary>
        ExternalFenceHandleTypeSciSyncObjBitNv = 16,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalFenceHandleTypeSyncFdBit = 8,
        /// <summary>[requires: <b>VK_KHR_external_fence_capabilities</b>] </summary>
        ExternalFenceHandleTypeSyncFdBitKhr = 8,
    }
    /// <summary><b>[requires: VK_KHR_external_fence_capabilities]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalFenceHandleTypeFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkExternalFenceHandleTypeFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalMemoryFeatureFlagBits.html" /></remarks>
    [Flags]
    public enum VkExternalMemoryFeatureFlagBits : uint
    {
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalMemoryFeatureDedicatedOnlyBit = 1,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        ExternalMemoryFeatureDedicatedOnlyBitKhr = 1,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalMemoryFeatureExportableBit = 2,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        ExternalMemoryFeatureExportableBitKhr = 2,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalMemoryFeatureImportableBit = 4,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        ExternalMemoryFeatureImportableBitKhr = 4,
    }
    /// <summary><b>[requires: VK_NV_external_memory_capabilities]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalMemoryFeatureFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkExternalMemoryFeatureFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_external_memory_capabilities</b>] </summary>
        ExternalMemoryFeatureDedicatedOnlyBitNv = 1,
        /// <summary>[requires: <b>VK_NV_external_memory_capabilities</b>] </summary>
        ExternalMemoryFeatureExportableBitNv = 2,
        /// <summary>[requires: <b>VK_NV_external_memory_capabilities</b>] </summary>
        ExternalMemoryFeatureImportableBitNv = 4,
    }
    /// <summary><b>[requires: VK_KHR_external_memory_capabilities]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalMemoryFeatureFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkExternalMemoryFeatureFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.1]</b> Used by <see cref="Vk.GetMemoryFdPropertiesKHR"/>, <see cref="Vk.GetMemoryHostPointerPropertiesEXT"/>, <see cref="Vk.GetMemoryMetalHandlePropertiesEXT"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalMemoryHandleTypeFlagBits.html" /></remarks>
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagBits : uint
    {
        /// <summary>[requires: <b>VK_ANDROID_external_memory_android_hardware_buffer</b>] </summary>
        ExternalMemoryHandleTypeAndroidHardwareBufferBitAndroid = 1024,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalMemoryHandleTypeD3d11TextureBit = 8,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        ExternalMemoryHandleTypeD3d11TextureBitKhr = 8,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalMemoryHandleTypeD3d11TextureKmtBit = 16,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        ExternalMemoryHandleTypeD3d11TextureKmtBitKhr = 16,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalMemoryHandleTypeD3d12HeapBit = 32,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        ExternalMemoryHandleTypeD3d12HeapBitKhr = 32,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalMemoryHandleTypeD3d12ResourceBit = 64,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        ExternalMemoryHandleTypeD3d12ResourceBitKhr = 64,
        /// <summary>[requires: <b>VK_EXT_external_memory_dma_buf</b>] </summary>
        ExternalMemoryHandleTypeDmaBufBitExt = 512,
        /// <summary>[requires: <b>VK_EXT_external_memory_host</b>] </summary>
        ExternalMemoryHandleTypeHostAllocationBitExt = 128,
        /// <summary>[requires: <b>VK_EXT_external_memory_host</b>] </summary>
        ExternalMemoryHandleTypeHostMappedForeignMemoryBitExt = 256,
        /// <summary>[requires: <b>VK_EXT_external_memory_metal</b>] </summary>
        ExternalMemoryHandleTypeMtlbufferBitExt = 65536,
        /// <summary>[requires: <b>VK_EXT_external_memory_metal</b>] </summary>
        ExternalMemoryHandleTypeMtlheapBitExt = 262144,
        /// <summary>[requires: <b>VK_EXT_external_memory_metal</b>] </summary>
        ExternalMemoryHandleTypeMtltextureBitExt = 131072,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalMemoryHandleTypeOpaqueFdBit = 1,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        ExternalMemoryHandleTypeOpaqueFdBitKhr = 1,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalMemoryHandleTypeOpaqueWin32Bit = 2,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        ExternalMemoryHandleTypeOpaqueWin32BitKhr = 2,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalMemoryHandleTypeOpaqueWin32KmtBit = 4,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        ExternalMemoryHandleTypeOpaqueWin32KmtBitKhr = 4,
        /// <summary>[requires: <b>VK_NV_external_memory_rdma</b>] </summary>
        ExternalMemoryHandleTypeRdmaAddressBitNv = 4096,
        /// <summary>[requires: <b>VK_NV_external_memory_sci_buf</b>] </summary>
        ExternalMemoryHandleTypeSciBufBitNv = 8192,
        /// <summary>[requires: <b>VK_QNX_external_memory_screen_buffer</b>] </summary>
        ExternalMemoryHandleTypeScreenBufferBitQnx = 16384,
        /// <summary>[requires: <b>VK_FUCHSIA_external_memory</b>] </summary>
        ExternalMemoryHandleTypeZirconVmoBitFuchsia = 2048,
    }
    /// <summary><b>[requires: VK_NV_external_memory_capabilities]</b> Used by <see cref="Vk.GetMemoryWin32HandleNV"/>, <see cref="Vk.GetPhysicalDeviceExternalImageFormatPropertiesNV"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalMemoryHandleTypeFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_external_memory_capabilities</b>] </summary>
        ExternalMemoryHandleTypeD3d11ImageBitNv = 4,
        /// <summary>[requires: <b>VK_NV_external_memory_capabilities</b>] </summary>
        ExternalMemoryHandleTypeD3d11ImageKmtBitNv = 8,
        /// <summary>[requires: <b>VK_NV_external_memory_capabilities</b>] </summary>
        ExternalMemoryHandleTypeOpaqueWin32BitNv = 1,
        /// <summary>[requires: <b>VK_NV_external_memory_capabilities</b>] </summary>
        ExternalMemoryHandleTypeOpaqueWin32KmtBitNv = 2,
    }
    /// <summary><b>[requires: VK_KHR_external_memory_capabilities]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalMemoryHandleTypeFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalSemaphoreFeatureFlagBits.html" /></remarks>
    [Flags]
    public enum VkExternalSemaphoreFeatureFlagBits : uint
    {
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalSemaphoreFeatureExportableBit = 1,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_capabilities</b>] </summary>
        ExternalSemaphoreFeatureExportableBitKhr = 1,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalSemaphoreFeatureImportableBit = 2,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_capabilities</b>] </summary>
        ExternalSemaphoreFeatureImportableBitKhr = 2,
    }
    /// <summary><b>[requires: VK_KHR_external_semaphore_capabilities]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalSemaphoreFeatureFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkExternalSemaphoreFeatureFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalSemaphoreHandleTypeFlagBits.html" /></remarks>
    [Flags]
    public enum VkExternalSemaphoreHandleTypeFlagBits : uint
    {
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalSemaphoreHandleTypeD3d11FenceBit = 8,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalSemaphoreHandleTypeD3d12FenceBit = 8,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_capabilities</b>] </summary>
        ExternalSemaphoreHandleTypeD3d12FenceBitKhr = 8,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalSemaphoreHandleTypeOpaqueFdBit = 1,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_capabilities</b>] </summary>
        ExternalSemaphoreHandleTypeOpaqueFdBitKhr = 1,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalSemaphoreHandleTypeOpaqueWin32Bit = 2,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_capabilities</b>] </summary>
        ExternalSemaphoreHandleTypeOpaqueWin32BitKhr = 2,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalSemaphoreHandleTypeOpaqueWin32KmtBit = 4,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_capabilities</b>] </summary>
        ExternalSemaphoreHandleTypeOpaqueWin32KmtBitKhr = 4,
        /// <summary>[requires: <b>VK_NV_external_sci_sync</b>] </summary>
        ExternalSemaphoreHandleTypeSciSyncObjBitNv = 32,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ExternalSemaphoreHandleTypeSyncFdBit = 16,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_capabilities</b>] </summary>
        ExternalSemaphoreHandleTypeSyncFdBitKhr = 16,
        /// <summary>[requires: <b>VK_FUCHSIA_external_semaphore</b>] </summary>
        ExternalSemaphoreHandleTypeZirconEventBitFuchsia = 128,
    }
    /// <summary><b>[requires: VK_KHR_external_semaphore_capabilities]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkExternalSemaphoreHandleTypeFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkExternalSemaphoreHandleTypeFlagsKHR : uint
    {
    }
    /// <summary></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFaultLevel.html" /></remarks>
    public enum VkFaultLevel : int
    {
        /// <summary></summary>
        FaultLevelCritical = 1,
        /// <summary></summary>
        FaultLevelRecoverable = 2,
        /// <summary></summary>
        FaultLevelUnassigned = 0,
        /// <summary></summary>
        FaultLevelWarning = 3,
    }
    /// <summary>Used by <see cref="Vk.GetFaultData"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFaultQueryBehavior.html" /></remarks>
    public enum VkFaultQueryBehavior : int
    {
        /// <summary></summary>
        FaultQueryBehaviorGetAndClearAllFaults = 0,
    }
    /// <summary></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFaultType.html" /></remarks>
    public enum VkFaultType : int
    {
        /// <summary></summary>
        FaultTypeCommandBufferFull = 5,
        /// <summary></summary>
        FaultTypeImplementation = 2,
        /// <summary></summary>
        FaultTypeInvalid = 0,
        /// <summary></summary>
        FaultTypeInvalidApiUsage = 6,
        /// <summary></summary>
        FaultTypePhysicalDevice = 4,
        /// <summary></summary>
        FaultTypeSystem = 3,
        /// <summary></summary>
        FaultTypeUnassigned = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFenceCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkFenceCreateFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FenceCreateSignaledBit = 1,
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFenceImportFlagBits.html" /></remarks>
    [Flags]
    public enum VkFenceImportFlagBits : uint
    {
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FenceImportTemporaryBit = 1,
        /// <summary>[requires: <b>VK_KHR_external_fence</b>] </summary>
        FenceImportTemporaryBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_external_fence]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFenceImportFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkFenceImportFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdBlitImage"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFilter.html" /></remarks>
    public enum VkFilter : int
    {
        /// <summary>[requires: <b>VK_EXT_filter_cubic</b>] </summary>
        FilterCubicExt = 1000015000,
        /// <summary>[requires: <b>VK_IMG_filter_cubic</b>] </summary>
        FilterCubicImg = 1000015000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FilterLinear = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FilterNearest = 0,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.GetPhysicalDeviceExternalImageFormatPropertiesNV"/>, <see cref="Vk.GetPhysicalDeviceFormatProperties"/>, <see cref="Vk.GetPhysicalDeviceFormatProperties2"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFormat.html" /></remarks>
    public enum VkFormat : int
    {
        /// <summary>[requires: <b>v1.4</b>] </summary>
        FormatA1b5g5r5UnormPack16 = 1000470000,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        FormatA1b5g5r5UnormPack16Khr = 1000470000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA1r5g5b5UnormPack16 = 8,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA2b10g10r10SintPack32 = 69,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA2b10g10r10SnormPack32 = 65,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA2b10g10r10SscaledPack32 = 67,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA2b10g10r10UintPack32 = 68,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA2b10g10r10UnormPack32 = 64,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA2b10g10r10UscaledPack32 = 66,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA2r10g10b10SintPack32 = 63,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA2r10g10b10SnormPack32 = 59,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA2r10g10b10SscaledPack32 = 61,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA2r10g10b10UintPack32 = 62,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA2r10g10b10UnormPack32 = 58,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA2r10g10b10UscaledPack32 = 60,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatA4b4g4r4UnormPack16 = 1000340001,
        /// <summary>[requires: <b>VK_EXT_4444_formats</b>] </summary>
        FormatA4b4g4r4UnormPack16Ext = 1000340001,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatA4r4g4b4UnormPack16 = 1000340000,
        /// <summary>[requires: <b>VK_EXT_4444_formats</b>] </summary>
        FormatA4r4g4b4UnormPack16Ext = 1000340000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        FormatA8Unorm = 1000470001,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        FormatA8UnormKhr = 1000470001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA8b8g8r8SintPack32 = 56,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA8b8g8r8SnormPack32 = 52,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA8b8g8r8SrgbPack32 = 57,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA8b8g8r8SscaledPack32 = 54,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA8b8g8r8UintPack32 = 55,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA8b8g8r8UnormPack32 = 51,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatA8b8g8r8UscaledPack32 = 53,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc10x10SfloatBlock = 1000066011,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc10x10SfloatBlockExt = 1000066011,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc10x10SrgbBlock = 180,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc10x10UnormBlock = 179,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc10x5SfloatBlock = 1000066008,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc10x5SfloatBlockExt = 1000066008,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc10x5SrgbBlock = 174,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc10x5UnormBlock = 173,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc10x6SfloatBlock = 1000066009,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc10x6SfloatBlockExt = 1000066009,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc10x6SrgbBlock = 176,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc10x6UnormBlock = 175,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc10x8SfloatBlock = 1000066010,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc10x8SfloatBlockExt = 1000066010,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc10x8SrgbBlock = 178,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc10x8UnormBlock = 177,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc12x10SfloatBlock = 1000066012,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc12x10SfloatBlockExt = 1000066012,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc12x10SrgbBlock = 182,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc12x10UnormBlock = 181,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc12x12SfloatBlock = 1000066013,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc12x12SfloatBlockExt = 1000066013,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc12x12SrgbBlock = 184,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc12x12UnormBlock = 183,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc4x4SfloatBlock = 1000066000,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc4x4SfloatBlockExt = 1000066000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc4x4SrgbBlock = 158,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc4x4UnormBlock = 157,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc5x4SfloatBlock = 1000066001,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc5x4SfloatBlockExt = 1000066001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc5x4SrgbBlock = 160,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc5x4UnormBlock = 159,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc5x5SfloatBlock = 1000066002,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc5x5SfloatBlockExt = 1000066002,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc5x5SrgbBlock = 162,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc5x5UnormBlock = 161,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc6x5SfloatBlock = 1000066003,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc6x5SfloatBlockExt = 1000066003,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc6x5SrgbBlock = 164,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc6x5UnormBlock = 163,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc6x6SfloatBlock = 1000066004,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc6x6SfloatBlockExt = 1000066004,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc6x6SrgbBlock = 166,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc6x6UnormBlock = 165,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc8x5SfloatBlock = 1000066005,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc8x5SfloatBlockExt = 1000066005,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc8x5SrgbBlock = 168,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc8x5UnormBlock = 167,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc8x6SfloatBlock = 1000066006,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc8x6SfloatBlockExt = 1000066006,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc8x6SrgbBlock = 170,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc8x6UnormBlock = 169,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatAstc8x8SfloatBlock = 1000066007,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        FormatAstc8x8SfloatBlockExt = 1000066007,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc8x8SrgbBlock = 172,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatAstc8x8UnormBlock = 171,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB10g11r11UfloatPack32 = 122,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatB10x6g10x6r10x6g10x6422Unorm4pack16 = 1000156011,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatB10x6g10x6r10x6g10x6422Unorm4pack16Khr = 1000156011,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatB12x4g12x4r12x4g12x4422Unorm4pack16 = 1000156021,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatB12x4g12x4r12x4g12x4422Unorm4pack16Khr = 1000156021,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatB16g16r16g16422Unorm = 1000156028,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatB16g16r16g16422UnormKhr = 1000156028,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB4g4r4a4UnormPack16 = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB5g5r5a1UnormPack16 = 7,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB5g6r5UnormPack16 = 5,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8Sint = 35,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8Snorm = 31,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8Srgb = 36,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8Sscaled = 33,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8Uint = 34,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8Unorm = 30,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8Uscaled = 32,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8a8Sint = 49,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8a8Snorm = 45,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8a8Srgb = 50,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8a8Sscaled = 47,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8a8Uint = 48,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8a8Unorm = 44,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatB8g8r8a8Uscaled = 46,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatB8g8r8g8422Unorm = 1000156001,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatB8g8r8g8422UnormKhr = 1000156001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc1RgbSrgbBlock = 132,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc1RgbUnormBlock = 131,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc1RgbaSrgbBlock = 134,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc1RgbaUnormBlock = 133,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc2SrgbBlock = 136,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc2UnormBlock = 135,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc3SrgbBlock = 138,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc3UnormBlock = 137,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc4SnormBlock = 140,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc4UnormBlock = 139,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc5SnormBlock = 142,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc5UnormBlock = 141,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc6hSfloatBlock = 144,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc6hUfloatBlock = 143,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc7SrgbBlock = 146,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatBc7UnormBlock = 145,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatD16Unorm = 124,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatD16UnormS8Uint = 128,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatD24UnormS8Uint = 129,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatD32Sfloat = 126,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatD32SfloatS8Uint = 130,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatE5b9g9r9UfloatPack32 = 123,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatEacR11SnormBlock = 154,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatEacR11UnormBlock = 153,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatEacR11g11SnormBlock = 156,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatEacR11g11UnormBlock = 155,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatEtc2R8g8b8SrgbBlock = 148,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatEtc2R8g8b8UnormBlock = 147,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatEtc2R8g8b8a1SrgbBlock = 150,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatEtc2R8g8b8a1UnormBlock = 149,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatEtc2R8g8b8a8SrgbBlock = 152,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatEtc2R8g8b8a8UnormBlock = 151,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG10x6B10x6R10x63plane420Unorm3pack16 = 1000156012,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG10x6B10x6R10x63plane420Unorm3pack16Khr = 1000156012,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG10x6B10x6R10x63plane422Unorm3pack16 = 1000156014,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG10x6B10x6R10x63plane422Unorm3pack16Khr = 1000156014,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG10x6B10x6R10x63plane444Unorm3pack16 = 1000156016,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG10x6B10x6R10x63plane444Unorm3pack16Khr = 1000156016,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG10x6B10x6r10x62plane420Unorm3pack16 = 1000156013,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG10x6B10x6r10x62plane420Unorm3pack16Khr = 1000156013,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG10x6B10x6r10x62plane422Unorm3pack16 = 1000156015,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG10x6B10x6r10x62plane422Unorm3pack16Khr = 1000156015,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatG10x6B10x6r10x62plane444Unorm3pack16 = 1000330001,
        /// <summary>[requires: <b>VK_EXT_ycbcr_2plane_444_formats</b>] </summary>
        FormatG10x6B10x6r10x62plane444Unorm3pack16Ext = 1000330001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG10x6b10x6g10x6r10x6422Unorm4pack16 = 1000156010,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG10x6b10x6g10x6r10x6422Unorm4pack16Khr = 1000156010,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG12x4B12x4R12x43plane420Unorm3pack16 = 1000156022,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG12x4B12x4R12x43plane420Unorm3pack16Khr = 1000156022,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG12x4B12x4R12x43plane422Unorm3pack16 = 1000156024,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG12x4B12x4R12x43plane422Unorm3pack16Khr = 1000156024,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG12x4B12x4R12x43plane444Unorm3pack16 = 1000156026,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG12x4B12x4R12x43plane444Unorm3pack16Khr = 1000156026,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG12x4B12x4r12x42plane420Unorm3pack16 = 1000156023,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG12x4B12x4r12x42plane420Unorm3pack16Khr = 1000156023,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG12x4B12x4r12x42plane422Unorm3pack16 = 1000156025,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG12x4B12x4r12x42plane422Unorm3pack16Khr = 1000156025,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatG12x4B12x4r12x42plane444Unorm3pack16 = 1000330002,
        /// <summary>[requires: <b>VK_EXT_ycbcr_2plane_444_formats</b>] </summary>
        FormatG12x4B12x4r12x42plane444Unorm3pack16Ext = 1000330002,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG12x4b12x4g12x4r12x4422Unorm4pack16 = 1000156020,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG12x4b12x4g12x4r12x4422Unorm4pack16Khr = 1000156020,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG16B16R163plane420Unorm = 1000156029,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG16B16R163plane420UnormKhr = 1000156029,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG16B16R163plane422Unorm = 1000156031,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG16B16R163plane422UnormKhr = 1000156031,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG16B16R163plane444Unorm = 1000156033,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG16B16R163plane444UnormKhr = 1000156033,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG16B16r162plane420Unorm = 1000156030,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG16B16r162plane420UnormKhr = 1000156030,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG16B16r162plane422Unorm = 1000156032,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG16B16r162plane422UnormKhr = 1000156032,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatG16B16r162plane444Unorm = 1000330003,
        /// <summary>[requires: <b>VK_EXT_ycbcr_2plane_444_formats</b>] </summary>
        FormatG16B16r162plane444UnormExt = 1000330003,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG16b16g16r16422Unorm = 1000156027,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG16b16g16r16422UnormKhr = 1000156027,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG8B8R83plane420Unorm = 1000156002,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG8B8R83plane420UnormKhr = 1000156002,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG8B8R83plane422Unorm = 1000156004,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG8B8R83plane422UnormKhr = 1000156004,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG8B8R83plane444Unorm = 1000156006,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG8B8R83plane444UnormKhr = 1000156006,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG8B8r82plane420Unorm = 1000156003,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG8B8r82plane420UnormKhr = 1000156003,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG8B8r82plane422Unorm = 1000156005,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG8B8r82plane422UnormKhr = 1000156005,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatG8B8r82plane444Unorm = 1000330000,
        /// <summary>[requires: <b>VK_EXT_ycbcr_2plane_444_formats</b>] </summary>
        FormatG8B8r82plane444UnormExt = 1000330000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatG8b8g8r8422Unorm = 1000156000,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatG8b8g8r8422UnormKhr = 1000156000,
        /// <summary>[requires: <b>VK_IMG_format_pvrtc</b>] </summary>
        FormatPvrtc12bppSrgbBlockImg = 1000054004,
        /// <summary>[requires: <b>VK_IMG_format_pvrtc</b>] </summary>
        FormatPvrtc12bppUnormBlockImg = 1000054000,
        /// <summary>[requires: <b>VK_IMG_format_pvrtc</b>] </summary>
        FormatPvrtc14bppSrgbBlockImg = 1000054005,
        /// <summary>[requires: <b>VK_IMG_format_pvrtc</b>] </summary>
        FormatPvrtc14bppUnormBlockImg = 1000054001,
        /// <summary>[requires: <b>VK_IMG_format_pvrtc</b>] </summary>
        FormatPvrtc22bppSrgbBlockImg = 1000054006,
        /// <summary>[requires: <b>VK_IMG_format_pvrtc</b>] </summary>
        FormatPvrtc22bppUnormBlockImg = 1000054002,
        /// <summary>[requires: <b>VK_IMG_format_pvrtc</b>] </summary>
        FormatPvrtc24bppSrgbBlockImg = 1000054007,
        /// <summary>[requires: <b>VK_IMG_format_pvrtc</b>] </summary>
        FormatPvrtc24bppUnormBlockImg = 1000054003,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatR10x6UnormPack16 = 1000156007,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatR10x6UnormPack16Khr = 1000156007,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatR10x6g10x6Unorm2pack16 = 1000156008,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatR10x6g10x6Unorm2pack16Khr = 1000156008,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatR10x6g10x6b10x6a10x6Unorm4pack16 = 1000156009,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatR10x6g10x6b10x6a10x6Unorm4pack16Khr = 1000156009,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatR12x4UnormPack16 = 1000156017,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatR12x4UnormPack16Khr = 1000156017,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatR12x4g12x4Unorm2pack16 = 1000156018,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatR12x4g12x4Unorm2pack16Khr = 1000156018,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatR12x4g12x4b12x4a12x4Unorm4pack16 = 1000156019,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatR12x4g12x4b12x4a12x4Unorm4pack16Khr = 1000156019,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16Sfloat = 76,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16Sint = 75,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16Snorm = 71,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16Sscaled = 73,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16Uint = 74,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16Unorm = 70,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16Uscaled = 72,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        FormatR16g16S105Nv = 1000464000,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        FormatR16g16Sfixed5Nv = 1000464000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16Sfloat = 83,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16Sint = 82,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16Snorm = 78,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16Sscaled = 80,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16Uint = 81,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16Unorm = 77,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16Uscaled = 79,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16Sfloat = 90,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16Sint = 89,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16Snorm = 85,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16Sscaled = 87,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16Uint = 88,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16Unorm = 84,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16Uscaled = 86,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16a16Sfloat = 97,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16a16Sint = 96,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16a16Snorm = 92,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16a16Sscaled = 94,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16a16Uint = 95,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16a16Unorm = 91,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR16g16b16a16Uscaled = 93,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR32Sfloat = 100,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR32Sint = 99,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR32Uint = 98,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR32g32Sfloat = 103,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR32g32Sint = 102,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR32g32Uint = 101,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR32g32b32Sfloat = 106,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR32g32b32Sint = 105,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR32g32b32Uint = 104,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR32g32b32a32Sfloat = 109,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR32g32b32a32Sint = 108,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR32g32b32a32Uint = 107,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR4g4UnormPack8 = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR4g4b4a4UnormPack16 = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR5g5b5a1UnormPack16 = 6,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR5g6b5UnormPack16 = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR64Sfloat = 112,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR64Sint = 111,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR64Uint = 110,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR64g64Sfloat = 115,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR64g64Sint = 114,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR64g64Uint = 113,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR64g64b64Sfloat = 118,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR64g64b64Sint = 117,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR64g64b64Uint = 116,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR64g64b64a64Sfloat = 121,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR64g64b64a64Sint = 120,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR64g64b64a64Uint = 119,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8Sint = 14,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8Snorm = 10,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8Srgb = 15,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8Sscaled = 12,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8Uint = 13,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8Unorm = 9,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8Uscaled = 11,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8Sint = 21,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8Snorm = 17,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8Srgb = 22,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8Sscaled = 19,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8Uint = 20,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8Unorm = 16,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8Uscaled = 18,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8Sint = 28,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8Snorm = 24,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8Srgb = 29,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8Sscaled = 26,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8Uint = 27,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8Unorm = 23,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8Uscaled = 25,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8a8Sint = 42,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8a8Snorm = 38,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8a8Srgb = 43,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8a8Sscaled = 40,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8a8Uint = 41,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8a8Unorm = 37,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatR8g8b8a8Uscaled = 39,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatS8Uint = 127,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatUndefined = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FormatX8D24UnormPack32 = 125,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFormatFeatureFlagBits.html" /></remarks>
    [Flags]
    public enum VkFormatFeatureFlagBits : uint
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        FormatFeatureAccelerationStructureVertexBufferBitKhr = 536870912,
        /// <summary>[requires: <b>v1.0</b>] Format can be used as the destination image of blits with vkCmdBlitImage</summary>
        FormatFeatureBlitDstBit = 2048,
        /// <summary>[requires: <b>v1.0</b>] Format can be used as the source image of blits with vkCmdBlitImage</summary>
        FormatFeatureBlitSrcBit = 1024,
        /// <summary>[requires: <b>v1.0</b>] Format can be used for color attachment images</summary>
        FormatFeatureColorAttachmentBit = 128,
        /// <summary>[requires: <b>v1.0</b>] Format supports blending in case it is used for color attachment images</summary>
        FormatFeatureColorAttachmentBlendBit = 256,
        /// <summary>[requires: <b>v1.1</b>] Format can have cosited rather than midpoint chroma samples</summary>
        FormatFeatureCositedChromaSamplesBit = 8388608,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatFeatureCositedChromaSamplesBitKhr = 8388608,
        /// <summary>[requires: <b>v1.0</b>] Format can be used for depth/stencil attachment images</summary>
        FormatFeatureDepthStencilAttachmentBit = 512,
        /// <summary>[requires: <b>v1.1</b>] Format supports disjoint planes</summary>
        FormatFeatureDisjointBit = 4194304,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatFeatureDisjointBitKhr = 4194304,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        FormatFeatureFragmentDensityMapBitExt = 16777216,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        FormatFeatureFragmentShadingRateAttachmentBitKhr = 1073741824,
        /// <summary>[requires: <b>v1.1</b>] Format can have midpoint rather than cosited chroma samples</summary>
        FormatFeatureMidpointChromaSamplesBit = 131072,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatFeatureMidpointChromaSamplesBitKhr = 131072,
        /// <summary>[requires: <b>v1.0</b>] Format can be used for sampled images (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)</summary>
        FormatFeatureSampledImageBit = 1,
        /// <summary>[requires: <b>VK_EXT_filter_cubic</b>] </summary>
        FormatFeatureSampledImageFilterCubicBitExt = 8192,
        /// <summary>[requires: <b>VK_IMG_filter_cubic</b>] Format can be filtered with VK_FILTER_CUBIC_IMG when being sampled</summary>
        FormatFeatureSampledImageFilterCubicBitImg = 8192,
        /// <summary>[requires: <b>v1.0</b>] Format can be filtered with VK_FILTER_LINEAR when being sampled</summary>
        FormatFeatureSampledImageFilterLinearBit = 4096,
        /// <summary>[requires: <b>v1.2</b>] Format can be used with min/max reduction filtering</summary>
        FormatFeatureSampledImageFilterMinmaxBit = 65536,
        /// <summary>[requires: <b>VK_EXT_sampler_filter_minmax</b>] </summary>
        FormatFeatureSampledImageFilterMinmaxBitExt = 65536,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBit = 1048576,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBitKhr = 1048576,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 2097152,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr = 2097152,
        /// <summary>[requires: <b>v1.1</b>] Format can be used with linear filtering whilst color conversion is enabled</summary>
        FormatFeatureSampledImageYcbcrConversionLinearFilterBit = 262144,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatFeatureSampledImageYcbcrConversionLinearFilterBitKhr = 262144,
        /// <summary>[requires: <b>v1.1</b>] Format can have different chroma, min and mag filters</summary>
        FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBit = 524288,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBitKhr = 524288,
        /// <summary>[requires: <b>v1.0</b>] Format supports atomic operations in case it is used for storage images</summary>
        FormatFeatureStorageImageAtomicBit = 4,
        /// <summary>[requires: <b>v1.0</b>] Format can be used for storage images (STORAGE_IMAGE descriptor type)</summary>
        FormatFeatureStorageImageBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Format supports atomic operations in case it is used for storage texel buffers</summary>
        FormatFeatureStorageTexelBufferAtomicBit = 32,
        /// <summary>[requires: <b>v1.0</b>] Format can be used for storage texel buffers (IBOs)</summary>
        FormatFeatureStorageTexelBufferBit = 16,
        /// <summary>[requires: <b>v1.1</b>] Format can be used as the destination image of image transfer commands</summary>
        FormatFeatureTransferDstBit = 32768,
        /// <summary>[requires: <b>VK_KHR_maintenance1</b>] </summary>
        FormatFeatureTransferDstBitKhr = 32768,
        /// <summary>[requires: <b>v1.1</b>] Format can be used as the source image of image transfer commands</summary>
        FormatFeatureTransferSrcBit = 16384,
        /// <summary>[requires: <b>VK_KHR_maintenance1</b>] </summary>
        FormatFeatureTransferSrcBitKhr = 16384,
        /// <summary>[requires: <b>v1.0</b>] Format can be used for uniform texel buffers (TBOs)</summary>
        FormatFeatureUniformTexelBufferBit = 8,
        /// <summary>[requires: <b>v1.0</b>] Format can be used for vertex buffers (VBOs)</summary>
        FormatFeatureVertexBufferBit = 64,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        FormatFeatureVideoDecodeDpbBitKhr = 67108864,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        FormatFeatureVideoDecodeOutputBitKhr = 33554432,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        FormatFeatureVideoEncodeDpbBitKhr = 268435456,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        FormatFeatureVideoEncodeInputBitKhr = 134217728,
    }
    /// <summary><b>[requires: v1.3]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFormatFeatureFlagBits2.html" /></remarks>
    [Flags]
    public enum VkFormatFeatureFlagBits2 : ulong
    {
        /// <summary>[requires: <b>VK_NV_ray_tracing_linear_swept_spheres</b>] </summary>
        FormatFeature2AccelerationStructureRadiusBufferBitNv = 524288,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        FormatFeature2AccelerationStructureVertexBufferBitKhr = 536870912,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2BlitDstBit = 2048,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2BlitDstBitKhr = 2048,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2BlitSrcBit = 1024,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2BlitSrcBitKhr = 1024,
        /// <summary>[requires: <b>VK_QCOM_image_processing</b>] </summary>
        FormatFeature2BlockMatchingBitQcom = 16,
        /// <summary>[requires: <b>VK_QCOM_image_processing</b>] </summary>
        FormatFeature2BoxFilterSampledBitQcom = 32,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2ColorAttachmentBit = 128,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2ColorAttachmentBitKhr = 128,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2ColorAttachmentBlendBit = 256,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2ColorAttachmentBlendBitKhr = 256,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2CositedChromaSamplesBit = 8388608,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2CositedChromaSamplesBitKhr = 8388608,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2DepthStencilAttachmentBit = 512,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2DepthStencilAttachmentBitKhr = 512,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2DisjointBit = 4194304,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2DisjointBitKhr = 4194304,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        FormatFeature2FragmentDensityMapBitExt = 16777216,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        FormatFeature2FragmentShadingRateAttachmentBitKhr = 1073741824,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        FormatFeature2HostImageTransferBit = 16384,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] Host image copies are supported</summary>
        FormatFeature2HostImageTransferBitExt = 16384,
        /// <summary>[requires: <b>VK_NV_linear_color_attachment</b>] Format support linear image as render target, it cannot be mixed with non linear attachment</summary>
        FormatFeature2LinearColorAttachmentBitNv = 64,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2MidpointChromaSamplesBit = 131072,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2MidpointChromaSamplesBitKhr = 131072,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        FormatFeature2OpticalFlowCostBitNv = 1024,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        FormatFeature2OpticalFlowImageBitNv = 256,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        FormatFeature2OpticalFlowVectorBitNv = 512,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2SampledImageBit = 1,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2SampledImageBitKhr = 1,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2SampledImageDepthComparisonBit = 8589934592,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2SampledImageDepthComparisonBitKhr = 8589934592,
        /// <summary>[requires: <b>v1.3</b>] This is an interaction with EXT_filter_cubic, though not tagged that way</summary>
        FormatFeature2SampledImageFilterCubicBit = 8192,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2SampledImageFilterCubicBitExt = 8192,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2SampledImageFilterLinearBit = 4096,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2SampledImageFilterLinearBitKhr = 4096,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2SampledImageFilterMinmaxBit = 65536,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2SampledImageFilterMinmaxBitKhr = 65536,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitBit = 1048576,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitBitKhr = 1048576,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 2097152,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr = 2097152,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2SampledImageYcbcrConversionLinearFilterBit = 262144,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2SampledImageYcbcrConversionLinearFilterBitKhr = 262144,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2SampledImageYcbcrConversionSeparateReconstructionFilterBit = 524288,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2SampledImageYcbcrConversionSeparateReconstructionFilterBitKhr = 524288,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2StorageImageAtomicBit = 4,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2StorageImageAtomicBitKhr = 4,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2StorageImageBit = 2,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2StorageImageBitKhr = 2,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2StorageReadWithoutFormatBit = 2147483648,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2StorageReadWithoutFormatBitKhr = 2147483648,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2StorageTexelBufferAtomicBit = 32,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2StorageTexelBufferAtomicBitKhr = 32,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2StorageTexelBufferBit = 16,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2StorageTexelBufferBitKhr = 16,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2StorageWriteWithoutFormatBit = 4294967296,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2StorageWriteWithoutFormatBitKhr = 4294967296,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2TransferDstBit = 32768,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2TransferDstBitKhr = 32768,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2TransferSrcBit = 16384,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2TransferSrcBitKhr = 16384,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2UniformTexelBufferBit = 8,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2UniformTexelBufferBitKhr = 8,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        FormatFeature2VertexBufferBit = 64,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        FormatFeature2VertexBufferBitKhr = 64,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        FormatFeature2VideoDecodeDpbBitKhr = 67108864,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        FormatFeature2VideoDecodeOutputBitKhr = 33554432,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        FormatFeature2VideoEncodeDpbBitKhr = 268435456,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        FormatFeature2VideoEncodeEmphasisMapBitKhr = 262144,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        FormatFeature2VideoEncodeInputBitKhr = 134217728,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        FormatFeature2VideoEncodeQuantizationDeltaMapBitKhr = 131072,
        /// <summary>[requires: <b>VK_QCOM_image_processing</b>] </summary>
        FormatFeature2WeightImageBitQcom = 4,
        /// <summary>[requires: <b>VK_QCOM_image_processing</b>] </summary>
        FormatFeature2WeightSampledImageBitQcom = 8,
    }
    /// <summary><b>[requires: VK_KHR_format_feature_flags2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFormatFeatureFlags2KHR.html" /></remarks>
    [Flags]
    public enum VkFormatFeatureFlags2KHR : ulong
    {
    }
    /// <summary><b>[requires: VK_KHR_fragment_shading_rate]</b> Used by <see cref="Vk.CmdSetFragmentShadingRateEnumNV"/>, <see cref="Vk.CmdSetFragmentShadingRateKHR"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFragmentShadingRateCombinerOpKHR.html" /></remarks>
    public enum VkFragmentShadingRateCombinerOpKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        FragmentShadingRateCombinerOpKeepKhr = 0,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        FragmentShadingRateCombinerOpMaxKhr = 3,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        FragmentShadingRateCombinerOpMinKhr = 2,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        FragmentShadingRateCombinerOpMulKhr = 4,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        FragmentShadingRateCombinerOpReplaceKhr = 1,
    }
    /// <summary><b>[requires: VK_NV_fragment_shading_rate_enums]</b> Used by <see cref="Vk.CmdSetFragmentShadingRateEnumNV"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFragmentShadingRateNV.html" /></remarks>
    public enum VkFragmentShadingRateNV : int
    {
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRate1InvocationPer1x2PixelsNv = 1,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRate1InvocationPer2x1PixelsNv = 4,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRate1InvocationPer2x2PixelsNv = 5,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRate1InvocationPer2x4PixelsNv = 6,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRate1InvocationPer4x2PixelsNv = 9,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRate1InvocationPer4x4PixelsNv = 10,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRate1InvocationPerPixelNv = 0,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRate16InvocationsPerPixelNv = 14,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRate2InvocationsPerPixelNv = 11,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRate4InvocationsPerPixelNv = 12,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRate8InvocationsPerPixelNv = 13,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRateNoInvocationsNv = 15,
    }
    /// <summary><b>[requires: VK_NV_fragment_shading_rate_enums]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFragmentShadingRateTypeNV.html" /></remarks>
    public enum VkFragmentShadingRateTypeNV : int
    {
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRateTypeEnumsNv = 1,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        FragmentShadingRateTypeFragmentSizeNv = 0,
    }
    /// <summary><b>[requires: VK_EXT_frame_boundary]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFrameBoundaryFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkFrameBoundaryFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_frame_boundary</b>] </summary>
        FrameBoundaryFrameEndBitExt = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFramebufferCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkFramebufferCreateFlagBits : uint
    {
        /// <summary>[requires: <b>v1.2</b>] </summary>
        FramebufferCreateImagelessBit = 1,
        /// <summary>[requires: <b>VK_KHR_imageless_framebuffer</b>] </summary>
        FramebufferCreateImagelessBitKhr = 1,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdSetFrontFace"/>, <see cref="Vk.CmdSetFrontFaceEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFrontFace.html" /></remarks>
    public enum VkFrontFace : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FrontFaceClockwise = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        FrontFaceCounterClockwise = 0,
    }
    /// <summary><b>[requires: VK_EXT_full_screen_exclusive]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkFullScreenExclusiveEXT.html" /></remarks>
    public enum VkFullScreenExclusiveEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_full_screen_exclusive</b>] </summary>
        FullScreenExclusiveAllowedExt = 1,
        /// <summary>[requires: <b>VK_EXT_full_screen_exclusive</b>] </summary>
        FullScreenExclusiveApplicationControlledExt = 3,
        /// <summary>[requires: <b>VK_EXT_full_screen_exclusive</b>] </summary>
        FullScreenExclusiveDefaultExt = 0,
        /// <summary>[requires: <b>VK_EXT_full_screen_exclusive</b>] </summary>
        FullScreenExclusiveDisallowedExt = 2,
    }
    /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkGeometryFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkGeometryFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        GeometryNoDuplicateAnyHitInvocationBitKhr = 2,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        GeometryNoDuplicateAnyHitInvocationBitNv = 2,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        GeometryOpaqueBitKhr = 1,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        GeometryOpaqueBitNv = 1,
    }
    /// <summary><b>[requires: VK_NV_ray_tracing]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkGeometryFlagsNV.html" /></remarks>
    [Flags]
    public enum VkGeometryFlagsNV : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkGeometryInstanceFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkGeometryInstanceFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        GeometryInstanceDisableOpacityMicromapsExt = 32,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        GeometryInstanceForceNoOpaqueBitKhr = 8,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        GeometryInstanceForceNoOpaqueBitNv = 8,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        GeometryInstanceForceOpacityMicromap2StateExt = 16,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        GeometryInstanceForceOpaqueBitKhr = 4,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        GeometryInstanceForceOpaqueBitNv = 4,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        GeometryInstanceTriangleCullDisableBitNv = 1,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        GeometryInstanceTriangleFacingCullDisableBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        GeometryInstanceTriangleFlipFacingBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        GeometryInstanceTriangleFrontCounterclockwiseBitKhr = 2,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        GeometryInstanceTriangleFrontCounterclockwiseBitNv = 2,
    }
    /// <summary><b>[requires: VK_NV_ray_tracing]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkGeometryInstanceFlagsNV.html" /></remarks>
    [Flags]
    public enum VkGeometryInstanceFlagsNV : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkGeometryTypeKHR.html" /></remarks>
    public enum VkGeometryTypeKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        GeometryTypeAabbsKhr = 1,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        GeometryTypeAabbsNv = 1,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        GeometryTypeInstancesKhr = 2,
        /// <summary>[requires: <b>VK_NV_ray_tracing_linear_swept_spheres</b>] </summary>
        GeometryTypeLinearSweptSpheresNv = 1000429005,
        /// <summary>[requires: <b>VK_NV_ray_tracing_linear_swept_spheres</b>] </summary>
        GeometryTypeSpheresNv = 1000429004,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        GeometryTypeTrianglesKhr = 0,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        GeometryTypeTrianglesNv = 0,
    }
    /// <summary><b>[requires: VK_EXT_graphics_pipeline_library]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkGraphicsPipelineLibraryFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkGraphicsPipelineLibraryFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_graphics_pipeline_library</b>] </summary>
        GraphicsPipelineLibraryFragmentOutputInterfaceBitExt = 8,
        /// <summary>[requires: <b>VK_EXT_graphics_pipeline_library</b>] </summary>
        GraphicsPipelineLibraryFragmentShaderBitExt = 4,
        /// <summary>[requires: <b>VK_EXT_graphics_pipeline_library</b>] </summary>
        GraphicsPipelineLibraryPreRasterizationShadersBitExt = 2,
        /// <summary>[requires: <b>VK_EXT_graphics_pipeline_library</b>] </summary>
        GraphicsPipelineLibraryVertexInputInterfaceBitExt = 1,
    }
    /// <summary><b>[requires: VK_EXT_headless_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkHeadlessSurfaceCreateFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkHeadlessSurfaceCreateFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: v1.4]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkHostImageCopyFlagBits.html" /></remarks>
    [Flags]
    public enum VkHostImageCopyFlagBits : uint
    {
        /// <summary>[requires: <b>v1.4</b>] </summary>
        HostImageCopyMemcpy = 1,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] </summary>
        HostImageCopyMemcpyExt = 1,
    }
    /// <summary><b>[requires: VK_EXT_host_image_copy]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkHostImageCopyFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkHostImageCopyFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdSetAttachmentFeedbackLoopEnableEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageAspectFlagBits.html" /></remarks>
    [Flags]
    public enum VkImageAspectFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageAspectColorBit = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageAspectDepthBit = 2,
        /// <summary>[requires: <b>VK_EXT_image_drm_format_modifier</b>] </summary>
        ImageAspectMemoryPlane0BitExt = 128,
        /// <summary>[requires: <b>VK_EXT_image_drm_format_modifier</b>] </summary>
        ImageAspectMemoryPlane1BitExt = 256,
        /// <summary>[requires: <b>VK_EXT_image_drm_format_modifier</b>] </summary>
        ImageAspectMemoryPlane2BitExt = 512,
        /// <summary>[requires: <b>VK_EXT_image_drm_format_modifier</b>] </summary>
        ImageAspectMemoryPlane3BitExt = 1024,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageAspectMetadataBit = 8,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        ImageAspectNone = 0,
        /// <summary>[requires: <b>VK_KHR_maintenance4</b>] </summary>
        ImageAspectNoneKhr = 0,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ImageAspectPlane0Bit = 16,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        ImageAspectPlane0BitKhr = 16,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ImageAspectPlane1Bit = 32,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        ImageAspectPlane1BitKhr = 32,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ImageAspectPlane2Bit = 64,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        ImageAspectPlane2BitKhr = 64,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageAspectStencilBit = 4,
    }
    /// <summary><b>[requires: VK_EXT_image_compression_control]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageCompressionFixedRateFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkImageCompressionFixedRateFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate10bpcBitExt = 512,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate11bpcBitExt = 1024,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate12bpcBitExt = 2048,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate13bpcBitExt = 4096,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate14bpcBitExt = 8192,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate15bpcBitExt = 16384,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate16bpcBitExt = 32768,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate17bpcBitExt = 65536,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate18bpcBitExt = 131072,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate19bpcBitExt = 262144,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate1bpcBitExt = 1,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate20bpcBitExt = 524288,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate21bpcBitExt = 1048576,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate22bpcBitExt = 2097152,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate23bpcBitExt = 4194304,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate24bpcBitExt = 8388608,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate2bpcBitExt = 2,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate3bpcBitExt = 4,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate4bpcBitExt = 8,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate5bpcBitExt = 16,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate6bpcBitExt = 32,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate7bpcBitExt = 64,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate8bpcBitExt = 128,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRate9bpcBitExt = 256,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRateNoneExt = 0,
    }
    /// <summary><b>[requires: VK_EXT_image_compression_control]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageCompressionFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkImageCompressionFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionDefaultExt = 0,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionDisabledExt = 4,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRateDefaultExt = 1,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ImageCompressionFixedRateExplicitExt = 2,
    }
    /// <summary><b>[requires: VK_FUCHSIA_buffer_collection]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageConstraintsInfoFlagBitsFUCHSIA.html" /></remarks>
    [Flags]
    public enum VkImageConstraintsInfoFlagBitsFUCHSIA : uint
    {
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        ImageConstraintsInfoCpuReadOftenFuchsia = 2,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        ImageConstraintsInfoCpuReadRarelyFuchsia = 1,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        ImageConstraintsInfoCpuWriteOftenFuchsia = 8,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        ImageConstraintsInfoCpuWriteRarelyFuchsia = 4,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        ImageConstraintsInfoProtectedOptionalFuchsia = 16,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.GetPhysicalDeviceExternalImageFormatPropertiesNV"/>, <see cref="Vk.GetPhysicalDeviceImageFormatProperties"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkImageCreateFlagBits : uint
    {
        /// <summary>[requires: <b>v1.1</b>] The 3D image can be viewed as a 2D or 2D array image</summary>
        ImageCreate2dArrayCompatibleBit = 32,
        /// <summary>[requires: <b>VK_KHR_maintenance1</b>] </summary>
        ImageCreate2dArrayCompatibleBitKhr = 32,
        /// <summary>[requires: <b>VK_EXT_image_2d_view_of_3d</b>] Image is created with a layout where individual slices are capable of being used as 2D images</summary>
        ImageCreate2dViewCompatibleBitExt = 131072,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ImageCreateAliasBit = 1024,
        /// <summary>[requires: <b>VK_KHR_bind_memory2</b>] </summary>
        ImageCreateAliasBitKhr = 1024,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ImageCreateBlockTexelViewCompatibleBit = 128,
        /// <summary>[requires: <b>VK_KHR_maintenance2</b>] </summary>
        ImageCreateBlockTexelViewCompatibleBitKhr = 128,
        /// <summary>[requires: <b>VK_NV_corner_sampled_image</b>] </summary>
        ImageCreateCornerSampledBitNv = 8192,
        /// <summary>[requires: <b>v1.0</b>] Allows creating image views with cube type from the created image</summary>
        ImageCreateCubeCompatibleBit = 16,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        ImageCreateDescriptorBufferCaptureReplayBitExt = 65536,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ImageCreateDisjointBit = 512,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        ImageCreateDisjointBitKhr = 512,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ImageCreateExtendedUsageBit = 256,
        /// <summary>[requires: <b>VK_KHR_maintenance2</b>] </summary>
        ImageCreateExtendedUsageBitKhr = 256,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map_offset</b>] </summary>
        ImageCreateFragmentDensityMapOffsetBitExt = 32768,
        /// <summary>[requires: <b>VK_QCOM_fragment_density_map_offset</b>] </summary>
        ImageCreateFragmentDensityMapOffsetBitQcom = 32768,
        /// <summary>[requires: <b>VK_EXT_multisampled_render_to_single_sampled</b>] </summary>
        ImageCreateMultisampledRenderToSingleSampledBitExt = 262144,
        /// <summary>[requires: <b>v1.0</b>] Allows image views to have different format than the base image</summary>
        ImageCreateMutableFormatBit = 8,
        /// <summary>[requires: <b>v1.1</b>] Image requires protected memory</summary>
        ImageCreateProtectedBit = 2048,
        /// <summary>[requires: <b>VK_EXT_sample_locations</b>] </summary>
        ImageCreateSampleLocationsCompatibleDepthBitExt = 4096,
        /// <summary>[requires: <b>v1.0</b>] Image should support constant data access to physical memory ranges mapped into multiple locations of sparse images</summary>
        ImageCreateSparseAliasedBit = 4,
        /// <summary>[requires: <b>v1.0</b>] Image should support sparse backing</summary>
        ImageCreateSparseBindingBit = 1,
        /// <summary>[requires: <b>v1.0</b>] Image should support sparse backing with partial residency</summary>
        ImageCreateSparseResidencyBit = 2,
        /// <summary>[requires: <b>v1.1</b>] Allows using VkBindImageMemoryDeviceGroupInfo::pSplitInstanceBindRegions when binding memory to the image</summary>
        ImageCreateSplitInstanceBindRegionsBit = 64,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        ImageCreateSplitInstanceBindRegionsBitKhr = 64,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        ImageCreateSubsampledBitExt = 16384,
        /// <summary>[requires: <b>VK_KHR_video_maintenance1</b>] </summary>
        ImageCreateVideoProfileIndependentBitKhr = 1048576,
    }
    /// <summary></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageFormatConstraintsFlagBitsFUCHSIA.html" /></remarks>
    [Flags]
    public enum VkImageFormatConstraintsFlagBitsFUCHSIA : int
    {
    }
    /// <summary><b>[requires: VK_FUCHSIA_buffer_collection]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageFormatConstraintsFlagsFUCHSIA.html" /></remarks>
    [Flags]
    public enum VkImageFormatConstraintsFlagsFUCHSIA : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.BindOpticalFlowSessionImageNV"/>, <see cref="Vk.CmdBindInvocationMaskHUAWEI"/>, <see cref="Vk.CmdBindShadingRateImageNV"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageLayout.html" /></remarks>
    public enum VkImageLayout : int
    {
        /// <summary>[requires: <b>VK_EXT_attachment_feedback_loop_layout</b>] </summary>
        ImageLayoutAttachmentFeedbackLoopOptimalExt = 1000339000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        ImageLayoutAttachmentOptimal = 1000314001,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        ImageLayoutAttachmentOptimalKhr = 1000314001,
        /// <summary>[requires: <b>v1.0</b>] Optimal layout when image is only used for color attachment read/write</summary>
        ImageLayoutColorAttachmentOptimal = 2,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ImageLayoutDepthAttachmentOptimal = 1000241000,
        /// <summary>[requires: <b>VK_KHR_separate_depth_stencil_layouts</b>] </summary>
        ImageLayoutDepthAttachmentOptimalKhr = 1000241000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ImageLayoutDepthAttachmentStencilReadOnlyOptimal = 1000117001,
        /// <summary>[requires: <b>VK_KHR_maintenance2</b>] </summary>
        ImageLayoutDepthAttachmentStencilReadOnlyOptimalKhr = 1000117001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ImageLayoutDepthReadOnlyOptimal = 1000241001,
        /// <summary>[requires: <b>VK_KHR_separate_depth_stencil_layouts</b>] </summary>
        ImageLayoutDepthReadOnlyOptimalKhr = 1000241001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ImageLayoutDepthReadOnlyStencilAttachmentOptimal = 1000117000,
        /// <summary>[requires: <b>VK_KHR_maintenance2</b>] </summary>
        ImageLayoutDepthReadOnlyStencilAttachmentOptimalKhr = 1000117000,
        /// <summary>[requires: <b>v1.0</b>] Optimal layout when image is only used for depth/stencil attachment read/write</summary>
        ImageLayoutDepthStencilAttachmentOptimal = 3,
        /// <summary>[requires: <b>v1.0</b>] Optimal layout when image is used for read only depth/stencil attachment and shader access</summary>
        ImageLayoutDepthStencilReadOnlyOptimal = 4,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        ImageLayoutFragmentDensityMapOptimalExt = 1000218000,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        ImageLayoutFragmentShadingRateAttachmentOptimalKhr = 1000164003,
        /// <summary>[requires: <b>v1.0</b>] General layout when image can be used for any kind of access</summary>
        ImageLayoutGeneral = 1,
        /// <summary>[requires: <b>v1.0</b>] Initial layout used when the data is populated by the CPU</summary>
        ImageLayoutPreinitialized = 8,
        /// <summary>[requires: <b>VK_KHR_swapchain</b>] </summary>
        ImageLayoutPresentSrcKhr = 1000001002,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        ImageLayoutReadOnlyOptimal = 1000314000,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        ImageLayoutReadOnlyOptimalKhr = 1000314000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        ImageLayoutRenderingLocalRead = 1000232000,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering_local_read</b>] </summary>
        ImageLayoutRenderingLocalReadKhr = 1000232000,
        /// <summary>[requires: <b>v1.0</b>] Optimal layout when image is used for read only shader access</summary>
        ImageLayoutShaderReadOnlyOptimal = 5,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ImageLayoutShadingRateOptimalNv = 1000164003,
        /// <summary>[requires: <b>VK_KHR_shared_presentable_image</b>] </summary>
        ImageLayoutSharedPresentKhr = 1000111000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ImageLayoutStencilAttachmentOptimal = 1000241002,
        /// <summary>[requires: <b>VK_KHR_separate_depth_stencil_layouts</b>] </summary>
        ImageLayoutStencilAttachmentOptimalKhr = 1000241002,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ImageLayoutStencilReadOnlyOptimal = 1000241003,
        /// <summary>[requires: <b>VK_KHR_separate_depth_stencil_layouts</b>] </summary>
        ImageLayoutStencilReadOnlyOptimalKhr = 1000241003,
        /// <summary>[requires: <b>v1.0</b>] Optimal layout when image is used only as destination of transfer operations</summary>
        ImageLayoutTransferDstOptimal = 7,
        /// <summary>[requires: <b>v1.0</b>] Optimal layout when image is used only as source of transfer operations</summary>
        ImageLayoutTransferSrcOptimal = 6,
        /// <summary>[requires: <b>v1.0</b>] Implicit layout an image is when its contents are undefined due to various reasons (e.g. right after creation)</summary>
        ImageLayoutUndefined = 0,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        ImageLayoutVideoDecodeDpbKhr = 1000024002,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        ImageLayoutVideoDecodeDstKhr = 1000024000,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        ImageLayoutVideoDecodeSrcKhr = 1000024001,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        ImageLayoutVideoEncodeDpbKhr = 1000299002,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        ImageLayoutVideoEncodeDstKhr = 1000299000,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        ImageLayoutVideoEncodeQuantizationMapKhr = 1000553000,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        ImageLayoutVideoEncodeSrcKhr = 1000299001,
    }
    /// <summary><b>[requires: VK_FUCHSIA_imagepipe_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImagePipeSurfaceCreateFlagsFUCHSIA.html" /></remarks>
    [Flags]
    public enum VkImagePipeSurfaceCreateFlagsFUCHSIA : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.GetPhysicalDeviceExternalImageFormatPropertiesNV"/>, <see cref="Vk.GetPhysicalDeviceImageFormatProperties"/>, <see cref="Vk.GetPhysicalDeviceSparseImageFormatProperties"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageTiling.html" /></remarks>
    public enum VkImageTiling : int
    {
        /// <summary>[requires: <b>VK_EXT_image_drm_format_modifier</b>] </summary>
        ImageTilingDrmFormatModifierExt = 1000158000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageTilingLinear = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageTilingOptimal = 0,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.GetPhysicalDeviceExternalImageFormatPropertiesNV"/>, <see cref="Vk.GetPhysicalDeviceImageFormatProperties"/>, <see cref="Vk.GetPhysicalDeviceSparseImageFormatProperties"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageType.html" /></remarks>
    public enum VkImageType : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageType1d = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageType2d = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageType3d = 2,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.GetPhysicalDeviceExternalImageFormatPropertiesNV"/>, <see cref="Vk.GetPhysicalDeviceImageFormatProperties"/>, <see cref="Vk.GetPhysicalDeviceSparseImageFormatProperties"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageUsageFlagBits.html" /></remarks>
    [Flags]
    public enum VkImageUsageFlagBits : uint
    {
        /// <summary>[requires: <b>VK_EXT_attachment_feedback_loop_layout</b>] </summary>
        ImageUsageAttachmentFeedbackLoopBitExt = 524288,
        /// <summary>[requires: <b>v1.0</b>] Can be used as framebuffer color attachment</summary>
        ImageUsageColorAttachmentBit = 16,
        /// <summary>[requires: <b>v1.0</b>] Can be used as framebuffer depth/stencil attachment</summary>
        ImageUsageDepthStencilAttachmentBit = 32,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        ImageUsageFragmentDensityMapBitExt = 512,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        ImageUsageFragmentShadingRateAttachmentBitKhr = 256,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        ImageUsageHostTransferBit = 4194304,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] Can be used with host image copies</summary>
        ImageUsageHostTransferBitExt = 4194304,
        /// <summary>[requires: <b>v1.0</b>] Can be used as framebuffer input attachment</summary>
        ImageUsageInputAttachmentBit = 128,
        /// <summary>[requires: <b>VK_HUAWEI_invocation_mask</b>] </summary>
        ImageUsageInvocationMaskBitHuawei = 262144,
        /// <summary>[requires: <b>VK_QCOM_image_processing</b>] </summary>
        ImageUsageSampleBlockMatchBitQcom = 2097152,
        /// <summary>[requires: <b>VK_QCOM_image_processing</b>] </summary>
        ImageUsageSampleWeightBitQcom = 1048576,
        /// <summary>[requires: <b>v1.0</b>] Can be sampled from (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)</summary>
        ImageUsageSampledBit = 4,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ImageUsageShadingRateImageBitNv = 256,
        /// <summary>[requires: <b>v1.0</b>] Can be used as storage image (STORAGE_IMAGE descriptor type)</summary>
        ImageUsageStorageBit = 8,
        /// <summary>[requires: <b>v1.0</b>] Can be used as a destination of transfer operations</summary>
        ImageUsageTransferDstBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Can be used as a source of transfer operations</summary>
        ImageUsageTransferSrcBit = 1,
        /// <summary>[requires: <b>v1.0</b>] Image data not needed outside of rendering</summary>
        ImageUsageTransientAttachmentBit = 64,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        ImageUsageVideoDecodeDpbBitKhr = 4096,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        ImageUsageVideoDecodeDstBitKhr = 1024,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        ImageUsageVideoDecodeSrcBitKhr = 2048,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        ImageUsageVideoEncodeDpbBitKhr = 32768,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        ImageUsageVideoEncodeDstBitKhr = 8192,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        ImageUsageVideoEncodeEmphasisMapBitKhr = 67108864,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        ImageUsageVideoEncodeQuantizationDeltaMapBitKhr = 33554432,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        ImageUsageVideoEncodeSrcBitKhr = 16384,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageViewCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkImageViewCreateFlagBits : uint
    {
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        ImageViewCreateDescriptorBufferCaptureReplayBitExt = 4,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map2</b>] </summary>
        ImageViewCreateFragmentDensityMapDeferredBitExt = 2,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        ImageViewCreateFragmentDensityMapDynamicBitExt = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkImageViewType.html" /></remarks>
    public enum VkImageViewType : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageViewType1d = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageViewType1dArray = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageViewType2d = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageViewType2dArray = 5,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageViewType3d = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageViewTypeCube = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ImageViewTypeCubeArray = 6,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdBindIndexBuffer"/>, <see cref="Vk.CmdBindIndexBuffer2"/>, <see cref="Vk.CmdBindIndexBuffer2KHR"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkIndexType.html" /></remarks>
    public enum VkIndexType : int
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        IndexTypeNoneKhr = 1000165000,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        IndexTypeNoneNv = 1000165000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        IndexTypeUint16 = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        IndexTypeUint32 = 1,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        IndexTypeUint8 = 1000265000,
        /// <summary>[requires: <b>VK_EXT_index_type_uint8</b>] </summary>
        IndexTypeUint8Ext = 1000265000,
        /// <summary>[requires: <b>VK_KHR_index_type_uint8</b>] </summary>
        IndexTypeUint8Khr = 1000265000,
    }
    /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkIndirectCommandsInputModeFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkIndirectCommandsInputModeFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsInputModeDxgiIndexBufferExt = 2,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsInputModeVulkanIndexBufferExt = 1,
    }
    /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkIndirectCommandsLayoutUsageFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkIndirectCommandsLayoutUsageFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsLayoutUsageExplicitPreprocessBitExt = 1,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsLayoutUsageUnorderedSequencesBitExt = 2,
    }
    /// <summary><b>[requires: VK_NV_device_generated_commands]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkIndirectCommandsLayoutUsageFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkIndirectCommandsLayoutUsageFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        IndirectCommandsLayoutUsageExplicitPreprocessBitNv = 1,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        IndirectCommandsLayoutUsageIndexedSequencesBitNv = 2,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        IndirectCommandsLayoutUsageUnorderedSequencesBitNv = 4,
    }
    /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkIndirectCommandsTokenTypeEXT.html" /></remarks>
    public enum VkIndirectCommandsTokenTypeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeDispatchExt = 9,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeDrawCountExt = 8,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeDrawExt = 6,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeDrawIndexedCountExt = 7,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeDrawIndexedExt = 5,
        /// <summary>[requires: <b>VK_EXT_mesh_shader</b>] </summary>
        IndirectCommandsTokenTypeDrawMeshTasksCountExt = 1000328001,
        /// <summary>[requires: <b>VK_NV_mesh_shader</b>] </summary>
        IndirectCommandsTokenTypeDrawMeshTasksCountNvExt = 1000202003,
        /// <summary>[requires: <b>VK_EXT_mesh_shader</b>] </summary>
        IndirectCommandsTokenTypeDrawMeshTasksExt = 1000328000,
        /// <summary>[requires: <b>VK_NV_mesh_shader</b>] </summary>
        IndirectCommandsTokenTypeDrawMeshTasksNvExt = 1000202002,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeExecutionSetExt = 0,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeIndexBufferExt = 3,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypePushConstantExt = 1,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeSequenceIndexExt = 2,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_maintenance1</b>] </summary>
        IndirectCommandsTokenTypeTraceRays2Ext = 1000386004,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeVertexBufferExt = 4,
    }
    /// <summary><b>[requires: VK_NV_device_generated_commands]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkIndirectCommandsTokenTypeNV.html" /></remarks>
    public enum VkIndirectCommandsTokenTypeNV : int
    {
        /// <summary>[requires: <b>VK_NV_device_generated_commands_compute</b>] </summary>
        IndirectCommandsTokenTypeDispatchNv = 1000428004,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeDrawIndexedNv = 5,
        /// <summary>[requires: <b>VK_EXT_mesh_shader</b>] </summary>
        IndirectCommandsTokenTypeDrawMeshTasksNv = 1000328000,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeDrawNv = 6,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeDrawTasksNv = 7,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeIndexBufferNv = 2,
        /// <summary>[requires: <b>VK_NV_device_generated_commands_compute</b>] </summary>
        IndirectCommandsTokenTypePipelineNv = 1000428003,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypePushConstantNv = 4,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeShaderGroupNv = 0,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeStateFlagsNv = 1,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        IndirectCommandsTokenTypeVertexBufferNv = 3,
    }
    /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkIndirectExecutionSetInfoTypeEXT.html" /></remarks>
    public enum VkIndirectExecutionSetInfoTypeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectExecutionSetInfoTypePipelinesExt = 0,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        IndirectExecutionSetInfoTypeShaderObjectsExt = 1,
    }
    /// <summary><b>[requires: VK_NV_device_generated_commands]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkIndirectStateFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkIndirectStateFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        IndirectStateFlagFrontfaceBitNv = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkInstanceCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkInstanceCreateFlagBits : uint
    {
        /// <summary>[requires: <b>VK_KHR_portability_enumeration</b>] </summary>
        InstanceCreateEnumeratePortabilityBitKhr = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkInternalAllocationType.html" /></remarks>
    public enum VkInternalAllocationType : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        InternalAllocationTypeExecutable = 0,
    }
    /// <summary><b>[requires: VK_MVK_ios_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkIOSSurfaceCreateFlagsMVK.html" /></remarks>
    [Flags]
    public enum VkIOSSurfaceCreateFlagsMVK : uint
    {
    }
    /// <summary><b>[requires: VK_NV_low_latency2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkLatencyMarkerNV.html" /></remarks>
    public enum VkLatencyMarkerNV : int
    {
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        LatencyMarkerInputSampleNv = 6,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        LatencyMarkerOutOfBandPresentEndNv = 11,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        LatencyMarkerOutOfBandPresentStartNv = 10,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        LatencyMarkerOutOfBandRendersubmitEndNv = 9,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        LatencyMarkerOutOfBandRendersubmitStartNv = 8,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        LatencyMarkerPresentEndNv = 5,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        LatencyMarkerPresentStartNv = 4,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        LatencyMarkerRendersubmitEndNv = 3,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        LatencyMarkerRendersubmitStartNv = 2,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        LatencyMarkerSimulationEndNv = 1,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        LatencyMarkerSimulationStartNv = 0,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        LatencyMarkerTriggerFlashNv = 7,
    }
    /// <summary><b>[requires: VK_MSFT_layered_driver]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkLayeredDriverUnderlyingApiMSFT.html" /></remarks>
    public enum VkLayeredDriverUnderlyingApiMSFT : int
    {
        /// <summary>[requires: <b>VK_MSFT_layered_driver</b>] </summary>
        LayeredDriverUnderlyingApiD3d12Msft = 1,
        /// <summary>[requires: <b>VK_MSFT_layered_driver</b>] </summary>
        LayeredDriverUnderlyingApiNoneMsft = 0,
    }
    /// <summary><b>[requires: VK_EXT_layer_settings]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkLayerSettingTypeEXT.html" /></remarks>
    public enum VkLayerSettingTypeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_layer_settings</b>] </summary>
        LayerSettingTypeBool32Ext = 0,
        /// <summary>[requires: <b>VK_EXT_layer_settings</b>] </summary>
        LayerSettingTypeFloat32Ext = 5,
        /// <summary>[requires: <b>VK_EXT_layer_settings</b>] </summary>
        LayerSettingTypeFloat64Ext = 6,
        /// <summary>[requires: <b>VK_EXT_layer_settings</b>] </summary>
        LayerSettingTypeInt32Ext = 1,
        /// <summary>[requires: <b>VK_EXT_layer_settings</b>] </summary>
        LayerSettingTypeInt64Ext = 2,
        /// <summary>[requires: <b>VK_EXT_layer_settings</b>] </summary>
        LayerSettingTypeStringExt = 7,
        /// <summary>[requires: <b>VK_EXT_layer_settings</b>] </summary>
        LayerSettingTypeUint32Ext = 3,
        /// <summary>[requires: <b>VK_EXT_layer_settings</b>] </summary>
        LayerSettingTypeUint64Ext = 4,
    }
    /// <summary><b>[requires: v1.4]</b> Used by <see cref="Vk.CmdSetLineRasterizationModeEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkLineRasterizationMode.html" /></remarks>
    public enum VkLineRasterizationMode : int
    {
        /// <summary>[requires: <b>v1.4</b>] </summary>
        LineRasterizationModeBresenham = 2,
        /// <summary>[requires: <b>VK_EXT_line_rasterization</b>] </summary>
        LineRasterizationModeBresenhamExt = 2,
        /// <summary>[requires: <b>VK_KHR_line_rasterization</b>] </summary>
        LineRasterizationModeBresenhamKhr = 2,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        LineRasterizationModeDefault = 0,
        /// <summary>[requires: <b>VK_EXT_line_rasterization</b>] </summary>
        LineRasterizationModeDefaultExt = 0,
        /// <summary>[requires: <b>VK_KHR_line_rasterization</b>] </summary>
        LineRasterizationModeDefaultKhr = 0,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        LineRasterizationModeRectangular = 1,
        /// <summary>[requires: <b>VK_EXT_line_rasterization</b>] </summary>
        LineRasterizationModeRectangularExt = 1,
        /// <summary>[requires: <b>VK_KHR_line_rasterization</b>] </summary>
        LineRasterizationModeRectangularKhr = 1,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        LineRasterizationModeRectangularSmooth = 3,
        /// <summary>[requires: <b>VK_EXT_line_rasterization</b>] </summary>
        LineRasterizationModeRectangularSmoothExt = 3,
        /// <summary>[requires: <b>VK_KHR_line_rasterization</b>] </summary>
        LineRasterizationModeRectangularSmoothKhr = 3,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdSetLogicOpEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkLogicOp.html" /></remarks>
    public enum VkLogicOp : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpAnd = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpAndInverted = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpAndReverse = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpClear = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpCopy = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpCopyInverted = 12,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpEquivalent = 9,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpInvert = 10,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpNand = 14,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpNoOp = 5,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpNor = 8,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpOr = 7,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpOrInverted = 13,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpOrReverse = 11,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpSet = 15,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        LogicOpXor = 6,
    }
    /// <summary><b>[requires: VK_MVK_macos_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMacOSSurfaceCreateFlagsMVK.html" /></remarks>
    [Flags]
    public enum VkMacOSSurfaceCreateFlagsMVK : uint
    {
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMemoryAllocateFlagBits.html" /></remarks>
    [Flags]
    public enum VkMemoryAllocateFlagBits : uint
    {
        /// <summary>[requires: <b>v1.2</b>] </summary>
        MemoryAllocateDeviceAddressBit = 2,
        /// <summary>[requires: <b>VK_KHR_buffer_device_address</b>] </summary>
        MemoryAllocateDeviceAddressBitKhr = 2,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        MemoryAllocateDeviceAddressCaptureReplayBit = 4,
        /// <summary>[requires: <b>VK_KHR_buffer_device_address</b>] </summary>
        MemoryAllocateDeviceAddressCaptureReplayBitKhr = 4,
        /// <summary>[requires: <b>v1.1</b>] Force allocation on specific devices</summary>
        MemoryAllocateDeviceMaskBit = 1,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        MemoryAllocateDeviceMaskBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_device_group]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMemoryAllocateFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkMemoryAllocateFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_NV_memory_decompression]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMemoryDecompressionMethodFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkMemoryDecompressionMethodFlagBitsNV : ulong
    {
        /// <summary>[requires: <b>VK_NV_memory_decompression</b>] </summary>
        MemoryDecompressionMethodGdeflate10BitNv = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMemoryHeapFlagBits.html" /></remarks>
    [Flags]
    public enum VkMemoryHeapFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] If set, heap represents device memory</summary>
        MemoryHeapDeviceLocalBit = 1,
        /// <summary>[requires: <b>v1.1</b>] If set, heap allocations allocate multiple instances by default</summary>
        MemoryHeapMultiInstanceBit = 2,
        /// <summary>[requires: <b>VK_KHR_device_group_creation</b>] </summary>
        MemoryHeapMultiInstanceBitKhr = 2,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.MapMemory"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMemoryMapFlagBits.html" /></remarks>
    [Flags]
    public enum VkMemoryMapFlagBits : uint
    {
        /// <summary>[requires: <b>VK_EXT_map_memory_placed</b>] </summary>
        MemoryMapPlacedBitExt = 1,
    }
    /// <summary><b>[requires: VK_AMD_memory_overallocation_behavior]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMemoryOverallocationBehaviorAMD.html" /></remarks>
    public enum VkMemoryOverallocationBehaviorAMD : int
    {
        /// <summary>[requires: <b>VK_AMD_memory_overallocation_behavior</b>] </summary>
        MemoryOverallocationBehaviorAllowedAmd = 1,
        /// <summary>[requires: <b>VK_AMD_memory_overallocation_behavior</b>] </summary>
        MemoryOverallocationBehaviorDefaultAmd = 0,
        /// <summary>[requires: <b>VK_AMD_memory_overallocation_behavior</b>] </summary>
        MemoryOverallocationBehaviorDisallowedAmd = 2,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMemoryPropertyFlagBits.html" /></remarks>
    [Flags]
    public enum VkMemoryPropertyFlagBits : uint
    {
        /// <summary>[requires: <b>VK_AMD_device_coherent_memory</b>] </summary>
        MemoryPropertyDeviceCoherentBitAmd = 64,
        /// <summary>[requires: <b>v1.0</b>] If otherwise stated, then allocate memory on device</summary>
        MemoryPropertyDeviceLocalBit = 1,
        /// <summary>[requires: <b>VK_AMD_device_coherent_memory</b>] </summary>
        MemoryPropertyDeviceUncachedBitAmd = 128,
        /// <summary>[requires: <b>v1.0</b>] Memory will be cached by the host</summary>
        MemoryPropertyHostCachedBit = 8,
        /// <summary>[requires: <b>v1.0</b>] Memory will have i/o coherency. If not set, application may need to use vkFlushMappedMemoryRanges and vkInvalidateMappedMemoryRanges to flush/invalidate host cache</summary>
        MemoryPropertyHostCoherentBit = 4,
        /// <summary>[requires: <b>v1.0</b>] Memory is mappable by host</summary>
        MemoryPropertyHostVisibleBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Memory may be allocated by the driver when it is required</summary>
        MemoryPropertyLazilyAllocatedBit = 16,
        /// <summary>[requires: <b>v1.1</b>] Memory is protected</summary>
        MemoryPropertyProtectedBit = 32,
        /// <summary>[requires: <b>VK_NV_external_memory_rdma</b>] </summary>
        MemoryPropertyRdmaCapableBitNv = 256,
    }
    /// <summary><b>[requires: v1.4]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMemoryUnmapFlagBits.html" /></remarks>
    [Flags]
    public enum VkMemoryUnmapFlagBits : uint
    {
        /// <summary>[requires: <b>VK_EXT_map_memory_placed</b>] </summary>
        MemoryUnmapReserveBitExt = 1,
    }
    /// <summary><b>[requires: VK_KHR_map_memory2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMemoryUnmapFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkMemoryUnmapFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_metal_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMetalSurfaceCreateFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkMetalSurfaceCreateFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMicromapCreateFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkMicromapCreateFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        MicromapCreateDeviceAddressCaptureReplayBitExt = 1,
    }
    /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkMicromapTypeEXT.html" /></remarks>
    public enum VkMicromapTypeEXT : int
    {
        /// <summary>[requires: <b>VK_NV_displacement_micromap</b>] </summary>
        MicromapTypeDisplacementMicromapNv = 1000397000,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        MicromapTypeOpacityMicromapExt = 0,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.GetPhysicalDeviceRefreshableObjectTypesKHR"/>, <see cref="Vk.GetPrivateData"/>, <see cref="Vk.GetPrivateDataEXT"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkObjectType.html" /></remarks>
    public enum VkObjectType : int
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        ObjectTypeAccelerationStructureKhr = 1000150000,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        ObjectTypeAccelerationStructureNv = 1000165000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeBuffer = 9,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] VkBufferCollectionFUCHSIA</summary>
        ObjectTypeBufferCollectionFuchsia = 1000366000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeBufferView = 13,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeCommandBuffer = 6,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeCommandPool = 25,
        /// <summary>[requires: <b>VK_NVX_binary_import</b>] </summary>
        ObjectTypeCuFunctionNvx = 1000029001,
        /// <summary>[requires: <b>VK_NVX_binary_import</b>] </summary>
        ObjectTypeCuModuleNvx = 1000029000,
        /// <summary>[requires: <b>VK_NV_cuda_kernel_launch</b>] </summary>
        ObjectTypeCudaFunctionNv = 1000307001,
        /// <summary>[requires: <b>VK_NV_cuda_kernel_launch</b>] </summary>
        ObjectTypeCudaModuleNv = 1000307000,
        /// <summary>[requires: <b>VK_EXT_debug_report</b>] </summary>
        ObjectTypeDebugReportCallbackExt = 1000011000,
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        ObjectTypeDebugUtilsMessengerExt = 1000128000,
        /// <summary>[requires: <b>VK_KHR_deferred_host_operations</b>] </summary>
        ObjectTypeDeferredOperationKhr = 1000268000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeDescriptorPool = 22,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeDescriptorSet = 23,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeDescriptorSetLayout = 20,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ObjectTypeDescriptorUpdateTemplate = 1000085000,
        /// <summary>[requires: <b>VK_KHR_descriptor_update_template</b>] </summary>
        ObjectTypeDescriptorUpdateTemplateKhr = 1000085000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeDevice = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeDeviceMemory = 8,
        /// <summary>[requires: <b>VK_KHR_display</b>] </summary>
        ObjectTypeDisplayKhr = 1000002000,
        /// <summary>[requires: <b>VK_KHR_display</b>] </summary>
        ObjectTypeDisplayModeKhr = 1000002001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeEvent = 11,
        /// <summary>[requires: <b>VK_NV_external_compute_queue</b>] </summary>
        ObjectTypeExternalComputeQueueNv = 1000556000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeFence = 7,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeFramebuffer = 24,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeImage = 10,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeImageView = 14,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        ObjectTypeIndirectCommandsLayoutExt = 1000572000,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        ObjectTypeIndirectCommandsLayoutNv = 1000277000,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        ObjectTypeIndirectExecutionSetExt = 1000572001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeInstance = 1,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        ObjectTypeMicromapExt = 1000396000,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        ObjectTypeOpticalFlowSessionNv = 1000464000,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        ObjectTypePerformanceConfigurationIntel = 1000210000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypePhysicalDevice = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypePipeline = 19,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        ObjectTypePipelineBinaryKhr = 1000483000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypePipelineCache = 16,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypePipelineLayout = 17,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        ObjectTypePrivateDataSlot = 1000295000,
        /// <summary>[requires: <b>VK_EXT_private_data</b>] </summary>
        ObjectTypePrivateDataSlotExt = 1000295000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeQueryPool = 12,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeQueue = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeRenderPass = 18,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeSampler = 21,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ObjectTypeSamplerYcbcrConversion = 1000156000,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        ObjectTypeSamplerYcbcrConversionKhr = 1000156000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeSemaphore = 5,
        /// <summary>[requires: <b>VK_NV_external_sci_sync2</b>] VkSemaphoreSciSyncPoolNV</summary>
        ObjectTypeSemaphoreSciSyncPoolNv = 1000489000,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        ObjectTypeShaderExt = 1000482000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeShaderModule = 15,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        ObjectTypeSurfaceKhr = 1000000000,
        /// <summary>[requires: <b>VK_KHR_swapchain</b>] </summary>
        ObjectTypeSwapchainKhr = 1000001000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ObjectTypeUnknown = 0,
        /// <summary>[requires: <b>VK_EXT_validation_cache</b>] </summary>
        ObjectTypeValidationCacheExt = 1000160000,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] VkVideoSessionKHR</summary>
        ObjectTypeVideoSessionKhr = 1000023000,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] VkVideoSessionParametersKHR</summary>
        ObjectTypeVideoSessionParametersKhr = 1000023001,
    }
    /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkOpacityMicromapFormatEXT.html" /></remarks>
    public enum VkOpacityMicromapFormatEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        OpacityMicromapFormat2StateExt = 1,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        OpacityMicromapFormat4StateExt = 2,
    }
    /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkOpacityMicromapSpecialIndexEXT.html" /></remarks>
    public enum VkOpacityMicromapSpecialIndexEXT : int
    {
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        OpacityMicromapSpecialIndexClusterGeometryDisableOpacityMicromapNv = -5,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        OpacityMicromapSpecialIndexFullyOpaqueExt = -2,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        OpacityMicromapSpecialIndexFullyTransparentExt = -1,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        OpacityMicromapSpecialIndexFullyUnknownOpaqueExt = -4,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        OpacityMicromapSpecialIndexFullyUnknownTransparentExt = -3,
    }
    /// <summary><b>[requires: VK_NV_optical_flow]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkOpticalFlowExecuteFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkOpticalFlowExecuteFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowExecuteDisableTemporalHintsBitNv = 1,
    }
    /// <summary><b>[requires: VK_NV_optical_flow]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkOpticalFlowGridSizeFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkOpticalFlowGridSizeFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowGridSize1x1BitNv = 1,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowGridSize2x2BitNv = 2,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowGridSize4x4BitNv = 4,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowGridSize8x8BitNv = 8,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowGridSizeUnknownNv = 0,
    }
    /// <summary><b>[requires: VK_NV_optical_flow]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkOpticalFlowPerformanceLevelNV.html" /></remarks>
    public enum VkOpticalFlowPerformanceLevelNV : int
    {
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowPerformanceLevelFastNv = 3,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowPerformanceLevelMediumNv = 2,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowPerformanceLevelSlowNv = 1,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowPerformanceLevelUnknownNv = 0,
    }
    /// <summary><b>[requires: VK_NV_optical_flow]</b> Used by <see cref="Vk.BindOpticalFlowSessionImageNV"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkOpticalFlowSessionBindingPointNV.html" /></remarks>
    public enum VkOpticalFlowSessionBindingPointNV : int
    {
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionBindingPointBackwardCostNv = 7,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionBindingPointBackwardFlowVectorNv = 5,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionBindingPointCostNv = 6,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionBindingPointFlowVectorNv = 4,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionBindingPointGlobalFlowNv = 8,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionBindingPointHintNv = 3,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionBindingPointInputNv = 1,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionBindingPointReferenceNv = 2,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionBindingPointUnknownNv = 0,
    }
    /// <summary><b>[requires: VK_NV_optical_flow]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkOpticalFlowSessionCreateFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkOpticalFlowSessionCreateFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionCreateAllowRegionsBitNv = 8,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionCreateBothDirectionsBitNv = 16,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionCreateEnableCostBitNv = 2,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionCreateEnableGlobalFlowBitNv = 4,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowSessionCreateEnableHintBitNv = 1,
    }
    /// <summary><b>[requires: VK_NV_optical_flow]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkOpticalFlowUsageFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkOpticalFlowUsageFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowUsageCostBitNv = 8,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowUsageGlobalFlowBitNv = 16,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowUsageHintBitNv = 4,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowUsageInputBitNv = 1,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowUsageOutputBitNv = 2,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        OpticalFlowUsageUnknownNv = 0,
    }
    /// <summary><b>[requires: VK_NV_low_latency2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkOutOfBandQueueTypeNV.html" /></remarks>
    public enum VkOutOfBandQueueTypeNV : int
    {
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        OutOfBandQueueTypePresentNv = 1,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        OutOfBandQueueTypeRenderNv = 0,
    }
    /// <summary><b>[requires: VK_NV_partitioned_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPartitionedAccelerationStructureInstanceFlagBitsNV.html" /></remarks>
    [Flags]
    public enum VkPartitionedAccelerationStructureInstanceFlagBitsNV : uint
    {
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        PartitionedAccelerationStructureInstanceFlagEnableExplicitBoundingBoxNv = 16,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        PartitionedAccelerationStructureInstanceFlagForceNoOpaqueBitNv = 8,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        PartitionedAccelerationStructureInstanceFlagForceOpaqueBitNv = 4,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        PartitionedAccelerationStructureInstanceFlagTriangleFacingCullDisableBitNv = 1,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        PartitionedAccelerationStructureInstanceFlagTriangleFlipFacingBitNv = 2,
    }
    /// <summary><b>[requires: VK_NV_partitioned_acceleration_structure]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPartitionedAccelerationStructureOpTypeNV.html" /></remarks>
    public enum VkPartitionedAccelerationStructureOpTypeNV : int
    {
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        PartitionedAccelerationStructureOpTypeUpdateInstanceNv = 1,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        PartitionedAccelerationStructureOpTypeWriteInstanceNv = 0,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        PartitionedAccelerationStructureOpTypeWritePartitionTranslationNv = 2,
    }
    /// <summary><b>[requires: v1.1]</b> Used by <see cref="Vk.GetDeviceGroupPeerMemoryFeatures"/>, <see cref="Vk.GetDeviceGroupPeerMemoryFeaturesKHR"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPeerMemoryFeatureFlagBits.html" /></remarks>
    [Flags]
    public enum VkPeerMemoryFeatureFlagBits : uint
    {
        /// <summary>[requires: <b>v1.1</b>] Can write with vkCmdCopy commands</summary>
        PeerMemoryFeatureCopyDstBit = 2,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        PeerMemoryFeatureCopyDstBitKhr = 2,
        /// <summary>[requires: <b>v1.1</b>] Can read with vkCmdCopy commands</summary>
        PeerMemoryFeatureCopySrcBit = 1,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        PeerMemoryFeatureCopySrcBitKhr = 1,
        /// <summary>[requires: <b>v1.1</b>] Can write with and access type/command</summary>
        PeerMemoryFeatureGenericDstBit = 8,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        PeerMemoryFeatureGenericDstBitKhr = 8,
        /// <summary>[requires: <b>v1.1</b>] Can read with any access type/command</summary>
        PeerMemoryFeatureGenericSrcBit = 4,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        PeerMemoryFeatureGenericSrcBitKhr = 4,
    }
    /// <summary><b>[requires: VK_KHR_device_group]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPeerMemoryFeatureFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkPeerMemoryFeatureFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_INTEL_performance_query]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPerformanceConfigurationTypeINTEL.html" /></remarks>
    public enum VkPerformanceConfigurationTypeINTEL : int
    {
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        PerformanceConfigurationTypeCommandQueueMetricsDiscoveryActivatedIntel = 0,
    }
    /// <summary><b>[requires: VK_KHR_performance_query]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPerformanceCounterDescriptionFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkPerformanceCounterDescriptionFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterDescriptionConcurrentlyImpactedBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterDescriptionConcurrentlyImpactedKhr = 2,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterDescriptionPerformanceImpactingBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterDescriptionPerformanceImpactingKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_performance_query]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPerformanceCounterScopeKHR.html" /></remarks>
    public enum VkPerformanceCounterScopeKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterScopeCommandBufferKhr = 0,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterScopeCommandKhr = 2,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterScopeRenderPassKhr = 1,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        QueryScopeCommandBufferKhr = 0,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        QueryScopeCommandKhr = 2,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        QueryScopeRenderPassKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_performance_query]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPerformanceCounterStorageKHR.html" /></remarks>
    public enum VkPerformanceCounterStorageKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterStorageFloat32Khr = 4,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterStorageFloat64Khr = 5,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterStorageInt32Khr = 0,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterStorageInt64Khr = 1,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterStorageUint32Khr = 2,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterStorageUint64Khr = 3,
    }
    /// <summary><b>[requires: VK_KHR_performance_query]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPerformanceCounterUnitKHR.html" /></remarks>
    public enum VkPerformanceCounterUnitKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterUnitAmpsKhr = 8,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterUnitBytesKhr = 3,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterUnitBytesPerSecondKhr = 4,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterUnitCyclesKhr = 10,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterUnitGenericKhr = 0,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterUnitHertzKhr = 9,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterUnitKelvinKhr = 5,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterUnitNanosecondsKhr = 2,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterUnitPercentageKhr = 1,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterUnitVoltsKhr = 7,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        PerformanceCounterUnitWattsKhr = 6,
    }
    /// <summary><b>[requires: VK_INTEL_performance_query]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPerformanceOverrideTypeINTEL.html" /></remarks>
    public enum VkPerformanceOverrideTypeINTEL : int
    {
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        PerformanceOverrideTypeFlushGpuCachesIntel = 1,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        PerformanceOverrideTypeNullHardwareIntel = 0,
    }
    /// <summary><b>[requires: VK_INTEL_performance_query]</b> Used by <see cref="Vk.GetPerformanceParameterINTEL"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPerformanceParameterTypeINTEL.html" /></remarks>
    public enum VkPerformanceParameterTypeINTEL : int
    {
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        PerformanceParameterTypeHwCountersSupportedIntel = 0,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        PerformanceParameterTypeStreamMarkerValidBitsIntel = 1,
    }
    /// <summary><b>[requires: VK_INTEL_performance_query]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPerformanceValueTypeINTEL.html" /></remarks>
    public enum VkPerformanceValueTypeINTEL : int
    {
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        PerformanceValueTypeBoolIntel = 3,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        PerformanceValueTypeFloatIntel = 2,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        PerformanceValueTypeStringIntel = 4,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        PerformanceValueTypeUint32Intel = 0,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        PerformanceValueTypeUint64Intel = 1,
    }
    /// <summary><b>[requires: VK_KHR_maintenance7]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPhysicalDeviceLayeredApiKHR.html" /></remarks>
    public enum VkPhysicalDeviceLayeredApiKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_maintenance7</b>] </summary>
        PhysicalDeviceLayeredApiD3d12Khr = 1,
        /// <summary>[requires: <b>VK_KHR_maintenance7</b>] </summary>
        PhysicalDeviceLayeredApiMetalKhr = 2,
        /// <summary>[requires: <b>VK_KHR_maintenance7</b>] </summary>
        PhysicalDeviceLayeredApiOpenglKhr = 3,
        /// <summary>[requires: <b>VK_KHR_maintenance7</b>] </summary>
        PhysicalDeviceLayeredApiOpenglesKhr = 4,
        /// <summary>[requires: <b>VK_KHR_maintenance7</b>] </summary>
        PhysicalDeviceLayeredApiVulkanKhr = 0,
    }
    /// <summary><b>[requires: VK_ARM_scheduling_controls]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPhysicalDeviceSchedulingControlsFlagBitsARM.html" /></remarks>
    [Flags]
    public enum VkPhysicalDeviceSchedulingControlsFlagBitsARM : ulong
    {
        /// <summary>[requires: <b>VK_ARM_scheduling_controls</b>] </summary>
        PhysicalDeviceSchedulingControlsShaderCoreCountArm = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPhysicalDeviceType.html" /></remarks>
    public enum VkPhysicalDeviceType : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PhysicalDeviceTypeCpu = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PhysicalDeviceTypeDiscreteGpu = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PhysicalDeviceTypeIntegratedGpu = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PhysicalDeviceTypeOther = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PhysicalDeviceTypeVirtualGpu = 3,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdBindDescriptorBufferEmbeddedSamplersEXT"/>, <see cref="Vk.CmdBindDescriptorSets"/>, <see cref="Vk.CmdBindPipeline"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineBindPoint.html" /></remarks>
    public enum VkPipelineBindPoint : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PipelineBindPointCompute = 1,
        /// <summary>[requires: <b>VK_AMDX_shader_enqueue</b>] </summary>
        PipelineBindPointExecutionGraphAmdx = 1000134000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PipelineBindPointGraphics = 0,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        PipelineBindPointRayTracingKhr = 1000165000,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        PipelineBindPointRayTracingNv = 1000165000,
        /// <summary>[requires: <b>VK_HUAWEI_subpass_shading</b>] </summary>
        PipelineBindPointSubpassShadingHuawei = 1000369003,
    }
    /// <summary><b>[requires: VK_EXT_pipeline_creation_cache_control]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineCacheCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkPipelineCacheCreateFlagBits : uint
    {
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineCacheCreateExternallySynchronizedBit = 1,
        /// <summary>[requires: <b>VK_EXT_pipeline_creation_cache_control</b>] </summary>
        PipelineCacheCreateExternallySynchronizedBitExt = 1,
        /// <summary>[requires: <b>VK_KHR_maintenance8</b>] </summary>
        PipelineCacheCreateInternallySynchronizedMergeBitKhr = 8,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineCacheHeaderVersion.html" /></remarks>
    public enum VkPipelineCacheHeaderVersion : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PipelineCacheHeaderVersionOne = 1,
    }
    /// <summary></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineCacheValidationVersion.html" /></remarks>
    public enum VkPipelineCacheValidationVersion : int
    {
        /// <summary></summary>
        PipelineCacheValidationVersionSafetyCriticalOne = 1,
    }
    /// <summary><b>[requires: VK_EXT_rasterization_order_attachment_access]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineColorBlendStateCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkPipelineColorBlendStateCreateFlagBits : uint
    {
        /// <summary>[requires: <b>VK_ARM_rasterization_order_attachment_access</b>] </summary>
        PipelineColorBlendStateCreateRasterizationOrderAttachmentAccessBitArm = 1,
        /// <summary>[requires: <b>VK_EXT_rasterization_order_attachment_access</b>] </summary>
        PipelineColorBlendStateCreateRasterizationOrderAttachmentAccessBitExt = 1,
    }
    /// <summary><b>[requires: VK_AMD_pipeline_compiler_control]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineCompilerControlFlagBitsAMD.html" /></remarks>
    [Flags]
    public enum VkPipelineCompilerControlFlagBitsAMD : uint
    {
    }
    /// <summary><b>[requires: VK_NV_framebuffer_mixed_samples]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineCoverageModulationStateCreateFlagsNV.html" /></remarks>
    [Flags]
    public enum VkPipelineCoverageModulationStateCreateFlagsNV : uint
    {
    }
    /// <summary><b>[requires: VK_NV_coverage_reduction_mode]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineCoverageReductionStateCreateFlagsNV.html" /></remarks>
    [Flags]
    public enum VkPipelineCoverageReductionStateCreateFlagsNV : uint
    {
    }
    /// <summary><b>[requires: VK_NV_fragment_coverage_to_color]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineCoverageToColorStateCreateFlagsNV.html" /></remarks>
    [Flags]
    public enum VkPipelineCoverageToColorStateCreateFlagsNV : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkPipelineCreateFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PipelineCreateAllowDerivativesBit = 2,
        /// <summary>[requires: <b>VK_KHR_pipeline_executable_properties</b>] </summary>
        PipelineCreateCaptureInternalRepresentationsBitKhr = 128,
        /// <summary>[requires: <b>VK_KHR_pipeline_executable_properties</b>] </summary>
        PipelineCreateCaptureStatisticsBitKhr = 64,
        /// <summary>[requires: <b>VK_EXT_attachment_feedback_loop_layout</b>] </summary>
        PipelineCreateColorAttachmentFeedbackLoopBitExt = 33554432,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        PipelineCreateDeferCompileBitNv = 32,
        /// <summary>[requires: <b>VK_EXT_attachment_feedback_loop_layout</b>] </summary>
        PipelineCreateDepthStencilAttachmentFeedbackLoopBitExt = 67108864,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PipelineCreateDerivativeBit = 4,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        PipelineCreateDescriptorBufferBitExt = 536870912,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PipelineCreateDisableOptimizationBit = 1,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        PipelineCreateDispatchBase = 16,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        PipelineCreateDispatchBaseBit = 16,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        PipelineCreateDispatchBaseKhr = 16,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineCreateEarlyReturnOnFailureBit = 512,
        /// <summary>[requires: <b>VK_EXT_pipeline_creation_cache_control</b>] </summary>
        PipelineCreateEarlyReturnOnFailureBitExt = 512,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineCreateFailOnPipelineCompileRequiredBit = 256,
        /// <summary>[requires: <b>VK_EXT_pipeline_creation_cache_control</b>] </summary>
        PipelineCreateFailOnPipelineCompileRequiredBitExt = 256,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        PipelineCreateIndirectBindableBitNv = 262144,
        /// <summary>[requires: <b>VK_KHR_pipeline_library</b>] </summary>
        PipelineCreateLibraryBitKhr = 2048,
        /// <summary>[requires: <b>VK_EXT_graphics_pipeline_library</b>] </summary>
        PipelineCreateLinkTimeOptimizationBitExt = 1024,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineCreateNoProtectedAccessBit = 134217728,
        /// <summary>[requires: <b>VK_EXT_pipeline_protected_access</b>] </summary>
        PipelineCreateNoProtectedAccessBitExt = 134217728,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineCreateProtectedAccessOnlyBit = 1073741824,
        /// <summary>[requires: <b>VK_EXT_pipeline_protected_access</b>] </summary>
        PipelineCreateProtectedAccessOnlyBitExt = 1073741824,
        /// <summary>[requires: <b>VK_NV_ray_tracing_motion_blur</b>] </summary>
        PipelineCreateRayTracingAllowMotionBitNv = 1048576,
        /// <summary>[requires: <b>VK_NV_displacement_micromap</b>] </summary>
        PipelineCreateRayTracingDisplacementMicromapBitNv = 268435456,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        PipelineCreateRayTracingNoNullAnyHitShadersBitKhr = 16384,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        PipelineCreateRayTracingNoNullClosestHitShadersBitKhr = 32768,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        PipelineCreateRayTracingNoNullIntersectionShadersBitKhr = 131072,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        PipelineCreateRayTracingNoNullMissShadersBitKhr = 65536,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        PipelineCreateRayTracingOpacityMicromapBitExt = 16777216,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        PipelineCreateRayTracingShaderGroupHandleCaptureReplayBitKhr = 524288,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        PipelineCreateRayTracingSkipAabbsBitKhr = 8192,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        PipelineCreateRayTracingSkipTrianglesBitKhr = 4096,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        PipelineCreateRenderingFragmentDensityMapAttachmentBitExt = 4194304,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        PipelineCreateRenderingFragmentShadingRateAttachmentBitKhr = 2097152,
        /// <summary>[requires: <b>VK_EXT_graphics_pipeline_library</b>] </summary>
        PipelineCreateRetainLinkTimeOptimizationInfoBitExt = 8388608,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        PipelineCreateViewIndexFromDeviceIndexBit = 8,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        PipelineCreateViewIndexFromDeviceIndexBitKhr = 8,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        PipelineRasterizationStateCreateFragmentDensityMapAttachmentBitExt = 4194304,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        PipelineRasterizationStateCreateFragmentShadingRateAttachmentBitKhr = 2097152,
    }
    /// <summary><b>[requires: v1.4]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineCreateFlagBits2.html" /></remarks>
    [Flags]
    public enum VkPipelineCreateFlagBits2 : ulong
    {
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineCreate2AllowDerivativesBit = 2,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2AllowDerivativesBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        PipelineCreate2CaptureDataBitKhr = 18446744071562067968,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2CaptureInternalRepresentationsBitKhr = 128,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2CaptureStatisticsBitKhr = 64,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2ColorAttachmentFeedbackLoopBitExt = 33554432,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2DeferCompileBitNv = 32,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2DepthStencilAttachmentFeedbackLoopBitExt = 67108864,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineCreate2DerivativeBit = 4,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2DerivativeBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2DescriptorBufferBitExt = 536870912,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineCreate2DisableOptimizationBit = 1,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2DisableOptimizationBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_maintenance5 | VK_ARM_pipeline_opacity_micromap</b>] </summary>
        PipelineCreate2DisallowOpacityMicromapBitArm = 32,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineCreate2DispatchBaseBit = 16,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2DispatchBaseBitKhr = 16,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineCreate2EarlyReturnOnFailureBit = 512,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2EarlyReturnOnFailureBitKhr = 512,
        /// <summary>[requires: <b>VK_EXT_legacy_dithering</b>] </summary>
        PipelineCreate2EnableLegacyDitheringBitExt = 4,
        /// <summary>[requires: <b>VK_AMDX_shader_enqueue</b>] </summary>
        PipelineCreate2ExecutionGraphBitAmdx = 1,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineCreate2FailOnPipelineCompileRequiredBit = 256,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2FailOnPipelineCompileRequiredBitKhr = 256,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        PipelineCreate2IndirectBindableBitExt = 64,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2IndirectBindableBitNv = 262144,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2LibraryBitKhr = 2048,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2LinkTimeOptimizationBitExt = 1024,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineCreate2NoProtectedAccessBit = 134217728,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2NoProtectedAccessBitExt = 134217728,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineCreate2ProtectedAccessOnlyBit = 1073741824,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2ProtectedAccessOnlyBitExt = 1073741824,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RayTracingAllowMotionBitNv = 1048576,
        /// <summary>[requires: <b>VK_NV_ray_tracing_linear_swept_spheres</b>] </summary>
        PipelineCreate2RayTracingAllowSpheresAndLinearSweptSpheresBitNv = 2,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RayTracingDisplacementMicromapBitNv = 268435456,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RayTracingNoNullAnyHitShadersBitKhr = 16384,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RayTracingNoNullClosestHitShadersBitKhr = 32768,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RayTracingNoNullIntersectionShadersBitKhr = 131072,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RayTracingNoNullMissShadersBitKhr = 65536,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RayTracingOpacityMicromapBitExt = 16777216,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RayTracingShaderGroupHandleCaptureReplayBitKhr = 524288,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RayTracingSkipAabbsBitKhr = 8192,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        PipelineCreate2RayTracingSkipBuiltInPrimitivesBitKhr = 4096,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RayTracingSkipTrianglesBitKhr = 4096,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RenderingFragmentDensityMapAttachmentBitExt = 4194304,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RenderingFragmentShadingRateAttachmentBitKhr = 2097152,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2RetainLinkTimeOptimizationInfoBitExt = 8388608,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineCreate2ViewIndexFromDeviceIndexBit = 8,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        PipelineCreate2ViewIndexFromDeviceIndexBitKhr = 8,
    }
    /// <summary><b>[requires: VK_KHR_maintenance5]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineCreateFlags2KHR.html" /></remarks>
    [Flags]
    public enum VkPipelineCreateFlags2KHR : ulong
    {
    }
    /// <summary><b>[requires: v1.3]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineCreationFeedbackFlagBits.html" /></remarks>
    [Flags]
    public enum VkPipelineCreationFeedbackFlagBits : uint
    {
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineCreationFeedbackApplicationPipelineCacheHitBit = 2,
        /// <summary>[requires: <b>VK_EXT_pipeline_creation_feedback</b>] </summary>
        PipelineCreationFeedbackApplicationPipelineCacheHitBitExt = 2,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineCreationFeedbackBasePipelineAccelerationBit = 4,
        /// <summary>[requires: <b>VK_EXT_pipeline_creation_feedback</b>] </summary>
        PipelineCreationFeedbackBasePipelineAccelerationBitExt = 4,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineCreationFeedbackValidBit = 1,
        /// <summary>[requires: <b>VK_EXT_pipeline_creation_feedback</b>] </summary>
        PipelineCreationFeedbackValidBitExt = 1,
    }
    /// <summary><b>[requires: VK_EXT_pipeline_creation_feedback]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineCreationFeedbackFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkPipelineCreationFeedbackFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_rasterization_order_attachment_access]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineDepthStencilStateCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkPipelineDepthStencilStateCreateFlagBits : uint
    {
        /// <summary>[requires: <b>VK_ARM_rasterization_order_attachment_access</b>] </summary>
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentDepthAccessBitArm = 1,
        /// <summary>[requires: <b>VK_EXT_rasterization_order_attachment_access</b>] </summary>
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentDepthAccessBitExt = 1,
        /// <summary>[requires: <b>VK_ARM_rasterization_order_attachment_access</b>] </summary>
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentStencilAccessBitArm = 2,
        /// <summary>[requires: <b>VK_EXT_rasterization_order_attachment_access</b>] </summary>
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentStencilAccessBitExt = 2,
    }
    /// <summary><b>[requires: VK_EXT_discard_rectangles]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineDiscardRectangleStateCreateFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkPipelineDiscardRectangleStateCreateFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineDynamicStateCreateFlags.html" /></remarks>
    [Flags]
    public enum VkPipelineDynamicStateCreateFlags : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_pipeline_executable_properties]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineExecutableStatisticFormatKHR.html" /></remarks>
    public enum VkPipelineExecutableStatisticFormatKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_pipeline_executable_properties</b>] </summary>
        PipelineExecutableStatisticFormatBool32Khr = 0,
        /// <summary>[requires: <b>VK_KHR_pipeline_executable_properties</b>] </summary>
        PipelineExecutableStatisticFormatFloat64Khr = 3,
        /// <summary>[requires: <b>VK_KHR_pipeline_executable_properties</b>] </summary>
        PipelineExecutableStatisticFormatInt64Khr = 1,
        /// <summary>[requires: <b>VK_KHR_pipeline_executable_properties</b>] </summary>
        PipelineExecutableStatisticFormatUint64Khr = 2,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineInputAssemblyStateCreateFlags.html" /></remarks>
    [Flags]
    public enum VkPipelineInputAssemblyStateCreateFlags : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_graphics_pipeline_library]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineLayoutCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkPipelineLayoutCreateFlagBits : uint
    {
        /// <summary>[requires: <b>VK_EXT_graphics_pipeline_library</b>] </summary>
        PipelineLayoutCreateIndependentSetsBitExt = 2,
    }
    /// <summary></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineMatchControl.html" /></remarks>
    public enum VkPipelineMatchControl : int
    {
        /// <summary></summary>
        PipelineMatchControlApplicationUuidExactMatch = 0,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineMultisampleStateCreateFlags.html" /></remarks>
    [Flags]
    public enum VkPipelineMultisampleStateCreateFlags : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_conservative_rasterization]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineRasterizationConservativeStateCreateFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkPipelineRasterizationConservativeStateCreateFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_depth_clip_enable]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineRasterizationDepthClipStateCreateFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkPipelineRasterizationDepthClipStateCreateFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineRasterizationStateCreateFlags.html" /></remarks>
    [Flags]
    public enum VkPipelineRasterizationStateCreateFlags : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_transform_feedback]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineRasterizationStateStreamCreateFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkPipelineRasterizationStateStreamCreateFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: v1.4]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineRobustnessBufferBehavior.html" /></remarks>
    public enum VkPipelineRobustnessBufferBehavior : int
    {
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineRobustnessBufferBehaviorDeviceDefault = 0,
        /// <summary>[requires: <b>VK_EXT_pipeline_robustness</b>] </summary>
        PipelineRobustnessBufferBehaviorDeviceDefaultExt = 0,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineRobustnessBufferBehaviorDisabled = 1,
        /// <summary>[requires: <b>VK_EXT_pipeline_robustness</b>] </summary>
        PipelineRobustnessBufferBehaviorDisabledExt = 1,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineRobustnessBufferBehaviorRobustBufferAccess = 2,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineRobustnessBufferBehaviorRobustBufferAccess2 = 3,
        /// <summary>[requires: <b>VK_EXT_pipeline_robustness</b>] </summary>
        PipelineRobustnessBufferBehaviorRobustBufferAccess2Ext = 3,
        /// <summary>[requires: <b>VK_EXT_pipeline_robustness</b>] </summary>
        PipelineRobustnessBufferBehaviorRobustBufferAccessExt = 2,
    }
    /// <summary><b>[requires: v1.4]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineRobustnessImageBehavior.html" /></remarks>
    public enum VkPipelineRobustnessImageBehavior : int
    {
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineRobustnessImageBehaviorDeviceDefault = 0,
        /// <summary>[requires: <b>VK_EXT_pipeline_robustness</b>] </summary>
        PipelineRobustnessImageBehaviorDeviceDefaultExt = 0,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineRobustnessImageBehaviorDisabled = 1,
        /// <summary>[requires: <b>VK_EXT_pipeline_robustness</b>] </summary>
        PipelineRobustnessImageBehaviorDisabledExt = 1,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineRobustnessImageBehaviorRobustImageAccess = 2,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        PipelineRobustnessImageBehaviorRobustImageAccess2 = 3,
        /// <summary>[requires: <b>VK_EXT_pipeline_robustness</b>] </summary>
        PipelineRobustnessImageBehaviorRobustImageAccess2Ext = 3,
        /// <summary>[requires: <b>VK_EXT_pipeline_robustness</b>] </summary>
        PipelineRobustnessImageBehaviorRobustImageAccessExt = 2,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineShaderStageCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkPipelineShaderStageCreateFlagBits : uint
    {
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineShaderStageCreateAllowVaryingSubgroupSizeBit = 1,
        /// <summary>[requires: <b>VK_EXT_subgroup_size_control</b>] </summary>
        PipelineShaderStageCreateAllowVaryingSubgroupSizeBitExt = 1,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineShaderStageCreateRequireFullSubgroupsBit = 2,
        /// <summary>[requires: <b>VK_EXT_subgroup_size_control</b>] </summary>
        PipelineShaderStageCreateRequireFullSubgroupsBitExt = 2,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdPipelineBarrier"/>, <see cref="Vk.CmdPipelineBarrier"/>, <see cref="Vk.CmdResetEvent"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineStageFlagBits.html" /></remarks>
    [Flags]
    public enum VkPipelineStageFlagBits : uint
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        PipelineStageAccelerationStructureBuildBitKhr = 33554432,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        PipelineStageAccelerationStructureBuildBitNv = 33554432,
        /// <summary>[requires: <b>v1.0</b>] All stages supported on the queue</summary>
        PipelineStageAllCommandsBit = 65536,
        /// <summary>[requires: <b>v1.0</b>] All stages of the graphics pipeline</summary>
        PipelineStageAllGraphicsBit = 32768,
        /// <summary>[requires: <b>v1.0</b>] After previous commands have completed</summary>
        PipelineStageBottomOfPipeBit = 8192,
        /// <summary>[requires: <b>v1.0</b>] Color attachment writes</summary>
        PipelineStageColorAttachmentOutputBit = 1024,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        PipelineStageCommandPreprocessBitExt = 131072,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        PipelineStageCommandPreprocessBitNv = 131072,
        /// <summary>[requires: <b>v1.0</b>] Compute shading</summary>
        PipelineStageComputeShaderBit = 2048,
        /// <summary>[requires: <b>VK_EXT_conditional_rendering</b>] A pipeline stage for conditional rendering predicate fetch</summary>
        PipelineStageConditionalRenderingBitExt = 262144,
        /// <summary>[requires: <b>v1.0</b>] Draw/DispatchIndirect command fetch</summary>
        PipelineStageDrawIndirectBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Early fragment (depth and stencil) tests</summary>
        PipelineStageEarlyFragmentTestsBit = 256,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        PipelineStageFragmentDensityProcessBitExt = 8388608,
        /// <summary>[requires: <b>v1.0</b>] Fragment shading</summary>
        PipelineStageFragmentShaderBit = 128,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        PipelineStageFragmentShadingRateAttachmentBitKhr = 4194304,
        /// <summary>[requires: <b>v1.0</b>] Geometry shading</summary>
        PipelineStageGeometryShaderBit = 64,
        /// <summary>[requires: <b>v1.0</b>] Indicates host (CPU) is a source/sink of the dependency</summary>
        PipelineStageHostBit = 16384,
        /// <summary>[requires: <b>v1.0</b>] Late fragment (depth and stencil) tests</summary>
        PipelineStageLateFragmentTestsBit = 512,
        /// <summary>[requires: <b>VK_EXT_mesh_shader</b>] </summary>
        PipelineStageMeshShaderBitExt = 1048576,
        /// <summary>[requires: <b>VK_NV_mesh_shader</b>] </summary>
        PipelineStageMeshShaderBitNv = 1048576,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStageNone = 0,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStageNoneKhr = 0,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        PipelineStageRayTracingShaderBitKhr = 2097152,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        PipelineStageRayTracingShaderBitNv = 2097152,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        PipelineStageShadingRateImageBitNv = 4194304,
        /// <summary>[requires: <b>VK_EXT_mesh_shader</b>] </summary>
        PipelineStageTaskShaderBitExt = 524288,
        /// <summary>[requires: <b>VK_NV_mesh_shader</b>] </summary>
        PipelineStageTaskShaderBitNv = 524288,
        /// <summary>[requires: <b>v1.0</b>] Tessellation control shading</summary>
        PipelineStageTessellationControlShaderBit = 16,
        /// <summary>[requires: <b>v1.0</b>] Tessellation evaluation shading</summary>
        PipelineStageTessellationEvaluationShaderBit = 32,
        /// <summary>[requires: <b>v1.0</b>] Before subsequent commands are processed</summary>
        PipelineStageTopOfPipeBit = 1,
        /// <summary>[requires: <b>v1.0</b>] Transfer/copy operations</summary>
        PipelineStageTransferBit = 4096,
        /// <summary>[requires: <b>VK_EXT_transform_feedback</b>] </summary>
        PipelineStageTransformFeedbackBitExt = 16777216,
        /// <summary>[requires: <b>v1.0</b>] Vertex/index fetch</summary>
        PipelineStageVertexInputBit = 4,
        /// <summary>[requires: <b>v1.0</b>] Vertex shading</summary>
        PipelineStageVertexShaderBit = 8,
    }
    /// <summary><b>[requires: v1.3]</b> Used by <see cref="Vk.CmdResetEvent2"/>, <see cref="Vk.CmdResetEvent2KHR"/>, <see cref="Vk.CmdWriteBufferMarker2AMD"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineStageFlagBits2.html" /></remarks>
    [Flags]
    public enum VkPipelineStageFlagBits2 : ulong
    {
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2AccelerationStructureBuildBitKhr = 33554432,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2AccelerationStructureBuildBitNv = 33554432,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_maintenance1</b>] </summary>
        PipelineStage2AccelerationStructureCopyBitKhr = 268435456,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2AllCommandsBit = 65536,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2AllCommandsBitKhr = 65536,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2AllGraphicsBit = 32768,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2AllGraphicsBitKhr = 32768,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2AllTransferBit = 4096,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2AllTransferBitKhr = 4096,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2BlitBit = 17179869184,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2BlitBitKhr = 17179869184,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2BottomOfPipeBit = 8192,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2BottomOfPipeBitKhr = 8192,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2ClearBit = 34359738368,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2ClearBitKhr = 34359738368,
        /// <summary>[requires: <b>VK_HUAWEI_cluster_culling_shader</b>] </summary>
        PipelineStage2ClusterCullingShaderBitHuawei = 512,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2ColorAttachmentOutputBit = 1024,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2ColorAttachmentOutputBitKhr = 1024,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2CommandPreprocessBitExt = 131072,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2CommandPreprocessBitNv = 131072,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2ComputeShaderBit = 2048,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2ComputeShaderBitKhr = 2048,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] A pipeline stage for conditional rendering predicate fetch</summary>
        PipelineStage2ConditionalRenderingBitExt = 262144,
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        PipelineStage2ConvertCooperativeVectorMatrixBitNv = 4096,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2CopyBit = 4294967296,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2CopyBitKhr = 4294967296,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2DrawIndirectBit = 2,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2DrawIndirectBitKhr = 2,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2EarlyFragmentTestsBit = 256,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2EarlyFragmentTestsBitKhr = 256,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2FragmentDensityProcessBitExt = 8388608,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2FragmentShaderBit = 128,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2FragmentShaderBitKhr = 128,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2FragmentShadingRateAttachmentBitKhr = 4194304,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2GeometryShaderBit = 64,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2GeometryShaderBitKhr = 64,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2HostBit = 16384,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2HostBitKhr = 16384,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2IndexInputBit = 68719476736,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2IndexInputBitKhr = 68719476736,
        /// <summary>[requires: <b>VK_HUAWEI_invocation_mask</b>] </summary>
        PipelineStage2InvocationMaskBitHuawei = 256,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2LateFragmentTestsBit = 512,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2LateFragmentTestsBitKhr = 512,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2MeshShaderBitExt = 1048576,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2MeshShaderBitNv = 1048576,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        PipelineStage2MicromapBuildBitExt = 1073741824,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2None = 0,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2NoneKhr = 0,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        PipelineStage2OpticalFlowBitNv = 536870912,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2PreRasterizationShadersBit = 274877906944,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2PreRasterizationShadersBitKhr = 274877906944,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2RayTracingShaderBitKhr = 2097152,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2RayTracingShaderBitNv = 2097152,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2ResolveBit = 8589934592,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2ResolveBitKhr = 8589934592,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2ShadingRateImageBitNv = 4194304,
        /// <summary>[requires: <b>VK_HUAWEI_subpass_shading</b>] </summary>
        PipelineStage2SubpassShaderBitHuawei = 128,
        /// <summary>[requires: <b>VK_HUAWEI_subpass_shading</b>] </summary>
        PipelineStage2SubpassShadingBitHuawei = 128,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2TaskShaderBitExt = 524288,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2TaskShaderBitNv = 524288,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2TessellationControlShaderBit = 16,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2TessellationControlShaderBitKhr = 16,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2TessellationEvaluationShaderBit = 32,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2TessellationEvaluationShaderBitKhr = 32,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2TopOfPipeBit = 1,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2TopOfPipeBitKhr = 1,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2TransferBit = 4096,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2TransferBitKhr = 4096,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2TransformFeedbackBitExt = 16777216,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2VertexAttributeInputBit = 137438953472,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2VertexAttributeInputBitKhr = 137438953472,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2VertexInputBit = 4,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2VertexInputBitKhr = 4,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineStage2VertexShaderBit = 8,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        PipelineStage2VertexShaderBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        PipelineStage2VideoDecodeBitKhr = 67108864,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        PipelineStage2VideoEncodeBitKhr = 134217728,
    }
    /// <summary><b>[requires: VK_KHR_synchronization2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineStageFlags2KHR.html" /></remarks>
    [Flags]
    public enum VkPipelineStageFlags2KHR : ulong
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineTessellationStateCreateFlags.html" /></remarks>
    [Flags]
    public enum VkPipelineTessellationStateCreateFlags : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineVertexInputStateCreateFlags.html" /></remarks>
    [Flags]
    public enum VkPipelineVertexInputStateCreateFlags : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineViewportStateCreateFlags.html" /></remarks>
    [Flags]
    public enum VkPipelineViewportStateCreateFlags : uint
    {
    }
    /// <summary><b>[requires: VK_NV_viewport_swizzle]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPipelineViewportSwizzleStateCreateFlagsNV.html" /></remarks>
    [Flags]
    public enum VkPipelineViewportSwizzleStateCreateFlagsNV : uint
    {
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPointClippingBehavior.html" /></remarks>
    public enum VkPointClippingBehavior : int
    {
        /// <summary>[requires: <b>v1.1</b>] </summary>
        PointClippingBehaviorAllClipPlanes = 0,
        /// <summary>[requires: <b>VK_KHR_maintenance2</b>] </summary>
        PointClippingBehaviorAllClipPlanesKhr = 0,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        PointClippingBehaviorUserClipPlanesOnly = 1,
        /// <summary>[requires: <b>VK_KHR_maintenance2</b>] </summary>
        PointClippingBehaviorUserClipPlanesOnlyKhr = 1,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdSetPolygonModeEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPolygonMode.html" /></remarks>
    public enum VkPolygonMode : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PolygonModeFill = 0,
        /// <summary>[requires: <b>VK_NV_fill_rectangle</b>] </summary>
        PolygonModeFillRectangleNv = 1000153000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PolygonModeLine = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PolygonModePoint = 2,
    }
    /// <summary><b>[requires: VK_EXT_surface_maintenance1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPresentGravityFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkPresentGravityFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_surface_maintenance1</b>] </summary>
        PresentGravityCenteredBitExt = 4,
        /// <summary>[requires: <b>VK_EXT_surface_maintenance1</b>] </summary>
        PresentGravityMaxBitExt = 2,
        /// <summary>[requires: <b>VK_EXT_surface_maintenance1</b>] </summary>
        PresentGravityMinBitExt = 1,
    }
    /// <summary><b>[requires: VK_KHR_surface]</b> Used by <see cref="Vk.GetPhysicalDeviceSurfacePresentModes2EXT"/>, <see cref="Vk.GetPhysicalDeviceSurfacePresentModesKHR"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPresentModeKHR.html" /></remarks>
    public enum VkPresentModeKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        PresentModeFifoKhr = 2,
        /// <summary>[requires: <b>VK_EXT_present_mode_fifo_latest_ready</b>] </summary>
        PresentModeFifoLatestReadyExt = 1000361000,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        PresentModeFifoRelaxedKhr = 3,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        PresentModeImmediateKhr = 0,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        PresentModeMailboxKhr = 1,
        /// <summary>[requires: <b>VK_KHR_shared_presentable_image</b>] </summary>
        PresentModeSharedContinuousRefreshKhr = 1000111001,
        /// <summary>[requires: <b>VK_KHR_shared_presentable_image</b>] </summary>
        PresentModeSharedDemandRefreshKhr = 1000111000,
    }
    /// <summary><b>[requires: VK_EXT_surface_maintenance1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPresentScalingFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkPresentScalingFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_surface_maintenance1</b>] </summary>
        PresentScalingAspectRatioStretchBitExt = 2,
        /// <summary>[requires: <b>VK_EXT_surface_maintenance1</b>] </summary>
        PresentScalingOneToOneBitExt = 1,
        /// <summary>[requires: <b>VK_EXT_surface_maintenance1</b>] </summary>
        PresentScalingStretchBitExt = 4,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdSetPrimitiveTopology"/>, <see cref="Vk.CmdSetPrimitiveTopologyEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPrimitiveTopology.html" /></remarks>
    public enum VkPrimitiveTopology : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PrimitiveTopologyLineList = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PrimitiveTopologyLineListWithAdjacency = 6,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PrimitiveTopologyLineStrip = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PrimitiveTopologyLineStripWithAdjacency = 7,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PrimitiveTopologyPatchList = 10,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PrimitiveTopologyPointList = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PrimitiveTopologyTriangleFan = 5,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PrimitiveTopologyTriangleList = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PrimitiveTopologyTriangleListWithAdjacency = 8,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PrimitiveTopologyTriangleStrip = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        PrimitiveTopologyTriangleStripWithAdjacency = 9,
    }
    /// <summary></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPrivateDataSlotCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkPrivateDataSlotCreateFlagBits : int
    {
    }
    /// <summary><b>[requires: v1.3]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPrivateDataSlotCreateFlags.html" /></remarks>
    [Flags]
    public enum VkPrivateDataSlotCreateFlags : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_private_data]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkPrivateDataSlotCreateFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkPrivateDataSlotCreateFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_provoking_vertex]</b> Used by <see cref="Vk.CmdSetProvokingVertexModeEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkProvokingVertexModeEXT.html" /></remarks>
    public enum VkProvokingVertexModeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_provoking_vertex</b>] </summary>
        ProvokingVertexModeFirstVertexExt = 0,
        /// <summary>[requires: <b>VK_EXT_provoking_vertex</b>] </summary>
        ProvokingVertexModeLastVertexExt = 1,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdBeginQuery"/>, <see cref="Vk.CmdBeginQueryIndexedEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkQueryControlFlagBits.html" /></remarks>
    [Flags]
    public enum VkQueryControlFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] Require precise results to be collected by the query</summary>
        QueryControlPreciseBit = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkQueryPipelineStatisticFlagBits.html" /></remarks>
    [Flags]
    public enum VkQueryPipelineStatisticFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] Optional</summary>
        QueryPipelineStatisticClippingInvocationsBit = 32,
        /// <summary>[requires: <b>v1.0</b>] Optional</summary>
        QueryPipelineStatisticClippingPrimitivesBit = 64,
        /// <summary>[requires: <b>VK_HUAWEI_cluster_culling_shader</b>] </summary>
        QueryPipelineStatisticClusterCullingShaderInvocationsBitHuawei = 8192,
        /// <summary>[requires: <b>v1.0</b>] Optional</summary>
        QueryPipelineStatisticComputeShaderInvocationsBit = 1024,
        /// <summary>[requires: <b>v1.0</b>] Optional</summary>
        QueryPipelineStatisticFragmentShaderInvocationsBit = 128,
        /// <summary>[requires: <b>v1.0</b>] Optional</summary>
        QueryPipelineStatisticGeometryShaderInvocationsBit = 8,
        /// <summary>[requires: <b>v1.0</b>] Optional</summary>
        QueryPipelineStatisticGeometryShaderPrimitivesBit = 16,
        /// <summary>[requires: <b>v1.0</b>] Optional</summary>
        QueryPipelineStatisticInputAssemblyPrimitivesBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Optional</summary>
        QueryPipelineStatisticInputAssemblyVerticesBit = 1,
        /// <summary>[requires: <b>VK_EXT_mesh_shader</b>] </summary>
        QueryPipelineStatisticMeshShaderInvocationsBitExt = 4096,
        /// <summary>[requires: <b>VK_EXT_mesh_shader</b>] </summary>
        QueryPipelineStatisticTaskShaderInvocationsBitExt = 2048,
        /// <summary>[requires: <b>v1.0</b>] Optional</summary>
        QueryPipelineStatisticTessellationControlShaderPatchesBit = 256,
        /// <summary>[requires: <b>v1.0</b>] Optional</summary>
        QueryPipelineStatisticTessellationEvaluationShaderInvocationsBit = 512,
        /// <summary>[requires: <b>v1.0</b>] Optional</summary>
        QueryPipelineStatisticVertexShaderInvocationsBit = 4,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkQueryPoolCreateFlags.html" /></remarks>
    [Flags]
    public enum VkQueryPoolCreateFlags : uint
    {
    }
    /// <summary><b>[requires: VK_INTEL_performance_query]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkQueryPoolSamplingModeINTEL.html" /></remarks>
    public enum VkQueryPoolSamplingModeINTEL : int
    {
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        QueryPoolSamplingModeManualIntel = 0,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdCopyQueryPoolResults"/>, <see cref="Vk.GetQueryPoolResults"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkQueryResultFlagBits.html" /></remarks>
    [Flags]
    public enum VkQueryResultFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] Results of the queries are written to the destination buffer as 64-bit values</summary>
        QueryResult64Bit = 1,
        /// <summary>[requires: <b>v1.0</b>] Copy the partial results of the query even if the final results are not available</summary>
        QueryResultPartialBit = 8,
        /// <summary>[requires: <b>v1.0</b>] Results of the queries are waited on before proceeding with the result copy</summary>
        QueryResultWaitBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Besides the results of the query, the availability of the results is also written</summary>
        QueryResultWithAvailabilityBit = 4,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        QueryResultWithStatusBitKhr = 16,
    }
    /// <summary><b>[requires: VK_KHR_video_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkQueryResultStatusKHR.html" /></remarks>
    public enum VkQueryResultStatusKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        QueryResultStatusCompleteKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        QueryResultStatusErrorKhr = -1,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        QueryResultStatusInsufficientBitstreamBufferRangeKhr = -1000299000,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        QueryResultStatusNotReadyKhr = 0,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdWriteAccelerationStructuresPropertiesKHR"/>, <see cref="Vk.CmdWriteAccelerationStructuresPropertiesNV"/>, <see cref="Vk.CmdWriteMicromapsPropertiesEXT"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkQueryType.html" /></remarks>
    public enum VkQueryType : int
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        QueryTypeAccelerationStructureCompactedSizeKhr = 1000150000,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        QueryTypeAccelerationStructureCompactedSizeNv = 1000165000,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_maintenance1</b>] </summary>
        QueryTypeAccelerationStructureSerializationBottomLevelPointersKhr = 1000386000,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        QueryTypeAccelerationStructureSerializationSizeKhr = 1000150001,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_maintenance1</b>] </summary>
        QueryTypeAccelerationStructureSizeKhr = 1000386001,
        /// <summary>[requires: <b>VK_EXT_mesh_shader</b>] </summary>
        QueryTypeMeshPrimitivesGeneratedExt = 1000328000,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        QueryTypeMicromapCompactedSizeExt = 1000396001,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        QueryTypeMicromapSerializationSizeExt = 1000396000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        QueryTypeOcclusion = 0,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        QueryTypePerformanceQueryIntel = 1000210000,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        QueryTypePerformanceQueryKhr = 1000116000,
        /// <summary>[requires: <b>v1.0</b>] Optional</summary>
        QueryTypePipelineStatistics = 1,
        /// <summary>[requires: <b>VK_EXT_primitives_generated_query</b>] </summary>
        QueryTypePrimitivesGeneratedExt = 1000382000,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        QueryTypeResultStatusOnlyKhr = 1000023000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        QueryTypeTimestamp = 2,
        /// <summary>[requires: <b>VK_EXT_transform_feedback</b>] </summary>
        QueryTypeTransformFeedbackStreamExt = 1000028004,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        QueryTypeVideoEncodeFeedbackKhr = 1000299000,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkQueueFlagBits.html" /></remarks>
    [Flags]
    public enum VkQueueFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] Queue supports compute operations</summary>
        QueueComputeBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Queue supports graphics operations</summary>
        QueueGraphicsBit = 1,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        QueueOpticalFlowBitNv = 256,
        /// <summary>[requires: <b>v1.1</b>] Queues may support protected operations</summary>
        QueueProtectedBit = 16,
        /// <summary>[requires: <b>v1.0</b>] Queue supports sparse resource memory management operations</summary>
        QueueSparseBindingBit = 8,
        /// <summary>[requires: <b>v1.0</b>] Queue supports transfer operations</summary>
        QueueTransferBit = 4,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        QueueVideoDecodeBitKhr = 32,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        QueueVideoEncodeBitKhr = 64,
    }
    /// <summary><b>[requires: v1.4]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkQueueGlobalPriority.html" /></remarks>
    public enum VkQueueGlobalPriority : int
    {
        /// <summary>[requires: <b>v1.4</b>] </summary>
        QueueGlobalPriorityHigh = 512,
        /// <summary>[requires: <b>VK_EXT_global_priority</b>] </summary>
        QueueGlobalPriorityHighExt = 512,
        /// <summary>[requires: <b>VK_KHR_global_priority</b>] </summary>
        QueueGlobalPriorityHighKhr = 512,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        QueueGlobalPriorityLow = 128,
        /// <summary>[requires: <b>VK_EXT_global_priority</b>] </summary>
        QueueGlobalPriorityLowExt = 128,
        /// <summary>[requires: <b>VK_KHR_global_priority</b>] </summary>
        QueueGlobalPriorityLowKhr = 128,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        QueueGlobalPriorityMedium = 256,
        /// <summary>[requires: <b>VK_EXT_global_priority</b>] </summary>
        QueueGlobalPriorityMediumExt = 256,
        /// <summary>[requires: <b>VK_KHR_global_priority</b>] </summary>
        QueueGlobalPriorityMediumKhr = 256,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        QueueGlobalPriorityRealtime = 1024,
        /// <summary>[requires: <b>VK_EXT_global_priority</b>] </summary>
        QueueGlobalPriorityRealtimeExt = 1024,
        /// <summary>[requires: <b>VK_KHR_global_priority</b>] </summary>
        QueueGlobalPriorityRealtimeKhr = 1024,
    }
    /// <summary><b>[requires: VK_AMD_rasterization_order]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkRasterizationOrderAMD.html" /></remarks>
    public enum VkRasterizationOrderAMD : int
    {
        /// <summary>[requires: <b>VK_AMD_rasterization_order</b>] </summary>
        RasterizationOrderRelaxedAmd = 1,
        /// <summary>[requires: <b>VK_AMD_rasterization_order</b>] </summary>
        RasterizationOrderStrictAmd = 0,
    }
    /// <summary><b>[requires: VK_NV_ray_tracing_invocation_reorder]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkRayTracingInvocationReorderModeNV.html" /></remarks>
    public enum VkRayTracingInvocationReorderModeNV : int
    {
        /// <summary>[requires: <b>VK_NV_ray_tracing_invocation_reorder</b>] </summary>
        RayTracingInvocationReorderModeNoneNv = 0,
        /// <summary>[requires: <b>VK_NV_ray_tracing_invocation_reorder</b>] </summary>
        RayTracingInvocationReorderModeReorderNv = 1,
    }
    /// <summary><b>[requires: VK_NV_ray_tracing_linear_swept_spheres]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkRayTracingLssIndexingModeNV.html" /></remarks>
    public enum VkRayTracingLssIndexingModeNV : int
    {
        /// <summary>[requires: <b>VK_NV_ray_tracing_linear_swept_spheres</b>] </summary>
        RayTracingLssIndexingModeListNv = 0,
        /// <summary>[requires: <b>VK_NV_ray_tracing_linear_swept_spheres</b>] </summary>
        RayTracingLssIndexingModeSuccessiveNv = 1,
    }
    /// <summary><b>[requires: VK_NV_ray_tracing_linear_swept_spheres]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkRayTracingLssPrimitiveEndCapsModeNV.html" /></remarks>
    public enum VkRayTracingLssPrimitiveEndCapsModeNV : int
    {
        /// <summary>[requires: <b>VK_NV_ray_tracing_linear_swept_spheres</b>] </summary>
        RayTracingLssPrimitiveEndCapsModeChainedNv = 1,
        /// <summary>[requires: <b>VK_NV_ray_tracing_linear_swept_spheres</b>] </summary>
        RayTracingLssPrimitiveEndCapsModeNoneNv = 0,
    }
    /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkRayTracingShaderGroupTypeKHR.html" /></remarks>
    public enum VkRayTracingShaderGroupTypeKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        RayTracingShaderGroupTypeGeneralKhr = 0,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        RayTracingShaderGroupTypeGeneralNv = 0,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        RayTracingShaderGroupTypeProceduralHitGroupKhr = 2,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        RayTracingShaderGroupTypeProceduralHitGroupNv = 2,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        RayTracingShaderGroupTypeTrianglesHitGroupKhr = 1,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        RayTracingShaderGroupTypeTrianglesHitGroupNv = 1,
    }
    /// <summary><b>[requires: VK_KHR_object_refresh]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkRefreshObjectFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkRefreshObjectFlagBitsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.3]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkRenderingFlagBits.html" /></remarks>
    [Flags]
    public enum VkRenderingFlagBits : uint
    {
        /// <summary>[requires: <b>VK_EXT_nested_command_buffer</b>] </summary>
        RenderingContentsInlineBitExt = 16,
        /// <summary>[requires: <b>VK_KHR_maintenance7</b>] Promoted from extension 452</summary>
        RenderingContentsInlineBitKhr = 16,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        RenderingContentsSecondaryCommandBuffersBit = 1,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering</b>] </summary>
        RenderingContentsSecondaryCommandBuffersBitKhr = 1,
        /// <summary>[requires: <b>VK_EXT_legacy_dithering</b>] </summary>
        RenderingEnableLegacyDitheringBitExt = 8,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        RenderingResumingBit = 4,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering</b>] </summary>
        RenderingResumingBitKhr = 4,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        RenderingSuspendingBit = 2,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering</b>] </summary>
        RenderingSuspendingBitKhr = 2,
    }
    /// <summary><b>[requires: VK_KHR_dynamic_rendering]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkRenderingFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkRenderingFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkRenderPassCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkRenderPassCreateFlagBits : uint
    {
        /// <summary>[requires: <b>VK_QCOM_render_pass_transform</b>] </summary>
        RenderPassCreateTransformBitQcom = 2,
    }
    /// <summary><b>[requires: v1.2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkResolveModeFlagBits.html" /></remarks>
    [Flags]
    public enum VkResolveModeFlagBits : uint
    {
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ResolveModeAverageBit = 2,
        /// <summary>[requires: <b>VK_KHR_depth_stencil_resolve</b>] </summary>
        ResolveModeAverageBitKhr = 2,
        /// <summary>[requires: <b>VK_ANDROID_external_format_resolve</b>] </summary>
        ResolveModeExternalFormatDownsampleAndroid = 16,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ResolveModeMaxBit = 8,
        /// <summary>[requires: <b>VK_KHR_depth_stencil_resolve</b>] </summary>
        ResolveModeMaxBitKhr = 8,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ResolveModeMinBit = 4,
        /// <summary>[requires: <b>VK_KHR_depth_stencil_resolve</b>] </summary>
        ResolveModeMinBitKhr = 4,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ResolveModeNone = 0,
        /// <summary>[requires: <b>VK_KHR_depth_stencil_resolve</b>] </summary>
        ResolveModeNoneKhr = 0,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ResolveModeSampleZeroBit = 1,
        /// <summary>[requires: <b>VK_KHR_depth_stencil_resolve</b>] </summary>
        ResolveModeSampleZeroBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_depth_stencil_resolve]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkResolveModeFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkResolveModeFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.AcquireDrmDisplayEXT"/>, <see cref="Vk.AcquireFullScreenExclusiveModeEXT"/>, <see cref="Vk.AcquireImageANDROID"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkResult.html" /></remarks>
    public enum VkResult : int
    {
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        ErrorCompressionExhaustedExt = -1000338000,
        /// <summary>[requires: <b>v1.0</b>] The logical device has been lost. See &lt;&lt;devsandqueues-lost-device&gt;&gt;</summary>
        ErrorDeviceLost = -4,
        /// <summary>[requires: <b>v1.0</b>] Extension specified does not exist</summary>
        ErrorExtensionNotPresent = -7,
        /// <summary>[requires: <b>v1.0</b>] Requested feature is not available on this device</summary>
        ErrorFeatureNotPresent = -8,
        /// <summary>[requires: <b>v1.0</b>] Requested format is not supported on this device</summary>
        ErrorFormatNotSupported = -11,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ErrorFragmentation = -1000161000,
        /// <summary>[requires: <b>VK_EXT_descriptor_indexing</b>] </summary>
        ErrorFragmentationExt = -1000161000,
        /// <summary>[requires: <b>v1.0</b>] A requested pool allocation has failed due to fragmentation of the pool&apos;s memory</summary>
        ErrorFragmentedPool = -12,
        /// <summary>[requires: <b>VK_EXT_full_screen_exclusive</b>] </summary>
        ErrorFullScreenExclusiveModeLostExt = -1000255000,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        ErrorImageUsageNotSupportedKhr = -1000023000,
        /// <summary>[requires: <b>VK_KHR_display_swapchain</b>] </summary>
        ErrorIncompatibleDisplayKhr = -1000003001,
        /// <summary>[requires: <b>v1.0</b>] Unable to find a Vulkan driver</summary>
        ErrorIncompatibleDriver = -9,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        ErrorIncompatibleShaderBinaryExt = 1000482000,
        /// <summary>[requires: <b>v1.0</b>] Initialization of an object has failed</summary>
        ErrorInitializationFailed = -3,
        /// <summary>[requires: <b>VK_EXT_buffer_device_address</b>] </summary>
        ErrorInvalidDeviceAddressExt = -1000257000,
        /// <summary>[requires: <b>VK_EXT_image_drm_format_modifier</b>] </summary>
        ErrorInvalidDrmFormatModifierPlaneLayoutExt = -1000158000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ErrorInvalidExternalHandle = -1000072003,
        /// <summary>[requires: <b>VK_KHR_external_memory</b>] </summary>
        ErrorInvalidExternalHandleKhr = -1000072003,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ErrorInvalidOpaqueCaptureAddress = -1000257000,
        /// <summary>[requires: <b>VK_KHR_buffer_device_address</b>] </summary>
        ErrorInvalidOpaqueCaptureAddressKhr = -1000257000,
        /// <summary>[requires: <b>VK_NV_glsl_shader</b>] </summary>
        ErrorInvalidShaderNv = -1000012000,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        ErrorInvalidVideoStdParametersKhr = -1000299000,
        /// <summary>[requires: <b>v1.0</b>] Layer specified does not exist</summary>
        ErrorLayerNotPresent = -6,
        /// <summary>[requires: <b>v1.0</b>] Mapping of a memory object has failed</summary>
        ErrorMemoryMapFailed = -5,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        ErrorNativeWindowInUseKhr = -1000000001,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        ErrorNotEnoughSpaceKhr = -1000483000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        ErrorNotPermitted = -1000174001,
        /// <summary>[requires: <b>VK_EXT_global_priority</b>] </summary>
        ErrorNotPermittedExt = -1000174001,
        /// <summary>[requires: <b>VK_KHR_global_priority</b>] </summary>
        ErrorNotPermittedKhr = -1000174001,
        /// <summary>[requires: <b>VK_KHR_swapchain</b>] </summary>
        ErrorOutOfDateKhr = -1000001004,
        /// <summary>[requires: <b>v1.0</b>] A device memory allocation has failed</summary>
        ErrorOutOfDeviceMemory = -2,
        /// <summary>[requires: <b>v1.0</b>] A host memory allocation has failed</summary>
        ErrorOutOfHostMemory = -1,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        ErrorOutOfPoolMemory = -1000069000,
        /// <summary>[requires: <b>VK_KHR_maintenance1</b>] </summary>
        ErrorOutOfPoolMemoryKhr = -1000069000,
        /// <summary>[requires: <b>VK_EXT_pipeline_creation_cache_control</b>] </summary>
        ErrorPipelineCompileRequiredExt = 1000297000,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        ErrorSurfaceLostKhr = -1000000000,
        /// <summary>[requires: <b>v1.0</b>] Too many objects of the type have already been created</summary>
        ErrorTooManyObjects = -10,
        /// <summary>[requires: <b>v1.0</b>] An unknown error has occurred, due to an implementation or application bug</summary>
        ErrorUnknown = -13,
        /// <summary>[requires: <b>VK_EXT_debug_report</b>] </summary>
        ErrorValidationFailedExt = -1000011001,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        ErrorVideoPictureLayoutNotSupportedKhr = -1000023001,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        ErrorVideoProfileCodecNotSupportedKhr = -1000023004,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        ErrorVideoProfileFormatNotSupportedKhr = -1000023003,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        ErrorVideoProfileOperationNotSupportedKhr = -1000023002,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        ErrorVideoStdVersionNotSupportedKhr = -1000023005,
        /// <summary>[requires: <b>v1.0</b>] An event is unsignaled</summary>
        EventReset = 4,
        /// <summary>[requires: <b>v1.0</b>] An event is signaled</summary>
        EventSet = 3,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        IncompatibleShaderBinaryExt = 1000482000,
        /// <summary>[requires: <b>v1.0</b>] A return array was too small for the result</summary>
        Incomplete = 5,
        /// <summary>[requires: <b>v1.0</b>] A fence or query has not yet completed</summary>
        NotReady = 1,
        /// <summary>[requires: <b>VK_KHR_deferred_host_operations</b>] </summary>
        OperationDeferredKhr = 1000268002,
        /// <summary>[requires: <b>VK_KHR_deferred_host_operations</b>] </summary>
        OperationNotDeferredKhr = 1000268003,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        PipelineBinaryMissingKhr = 1000483000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        PipelineCompileRequired = 1000297000,
        /// <summary>[requires: <b>VK_EXT_pipeline_creation_cache_control</b>] </summary>
        PipelineCompileRequiredExt = 1000297000,
        /// <summary>[requires: <b>VK_KHR_swapchain</b>] </summary>
        SuboptimalKhr = 1000001003,
        /// <summary>[requires: <b>v1.0</b>] Command completed successfully</summary>
        Success = 0,
        /// <summary>[requires: <b>VK_KHR_deferred_host_operations</b>] </summary>
        ThreadDoneKhr = 1000268001,
        /// <summary>[requires: <b>VK_KHR_deferred_host_operations</b>] </summary>
        ThreadIdleKhr = 1000268000,
        /// <summary>[requires: <b>v1.0</b>] A wait operation has not completed in the specified time</summary>
        Timeout = 2,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdSetRasterizationSamplesEXT"/>, <see cref="Vk.CmdSetSampleMaskEXT"/>, <see cref="Vk.GetPhysicalDeviceMultisamplePropertiesEXT"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSampleCountFlagBits.html" /></remarks>
    [Flags]
    public enum VkSampleCountFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] Sample count 1 supported</summary>
        SampleCount1Bit = 1,
        /// <summary>[requires: <b>v1.0</b>] Sample count 16 supported</summary>
        SampleCount16Bit = 16,
        /// <summary>[requires: <b>v1.0</b>] Sample count 2 supported</summary>
        SampleCount2Bit = 2,
        /// <summary>[requires: <b>v1.0</b>] Sample count 32 supported</summary>
        SampleCount32Bit = 32,
        /// <summary>[requires: <b>v1.0</b>] Sample count 4 supported</summary>
        SampleCount4Bit = 4,
        /// <summary>[requires: <b>v1.0</b>] Sample count 64 supported</summary>
        SampleCount64Bit = 64,
        /// <summary>[requires: <b>v1.0</b>] Sample count 8 supported</summary>
        SampleCount8Bit = 8,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSamplerAddressMode.html" /></remarks>
    public enum VkSamplerAddressMode : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SamplerAddressModeClampToBorder = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SamplerAddressModeClampToEdge = 2,
        /// <summary>[requires: <b>v1.2 | VK_KHR_sampler_mirror_clamp_to_edge</b>] No need to add an extnumber attribute, since this uses a core enum value</summary>
        SamplerAddressModeMirrorClampToEdge = 4,
        /// <summary>[requires: <b>VK_KHR_sampler_mirror_clamp_to_edge</b>] Introduced for consistency with extension suffixing rules</summary>
        SamplerAddressModeMirrorClampToEdgeKhr = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SamplerAddressModeMirroredRepeat = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SamplerAddressModeRepeat = 0,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSamplerCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkSamplerCreateFlagBits : uint
    {
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        SamplerCreateDescriptorBufferCaptureReplayBitExt = 8,
        /// <summary>[requires: <b>VK_QCOM_image_processing</b>] </summary>
        SamplerCreateImageProcessingBitQcom = 16,
        /// <summary>[requires: <b>VK_EXT_non_seamless_cube_map</b>] </summary>
        SamplerCreateNonSeamlessCubeMapBitExt = 4,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        SamplerCreateSubsampledBitExt = 1,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        SamplerCreateSubsampledCoarseReconstructionBitExt = 2,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSamplerMipmapMode.html" /></remarks>
    public enum VkSamplerMipmapMode : int
    {
        /// <summary>[requires: <b>v1.0</b>] Linear filter between mip levels</summary>
        SamplerMipmapModeLinear = 1,
        /// <summary>[requires: <b>v1.0</b>] Choose nearest mip level</summary>
        SamplerMipmapModeNearest = 0,
    }
    /// <summary><b>[requires: v1.2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSamplerReductionMode.html" /></remarks>
    public enum VkSamplerReductionMode : int
    {
        /// <summary>[requires: <b>v1.2</b>] </summary>
        SamplerReductionModeMax = 2,
        /// <summary>[requires: <b>VK_EXT_sampler_filter_minmax</b>] </summary>
        SamplerReductionModeMaxExt = 2,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        SamplerReductionModeMin = 1,
        /// <summary>[requires: <b>VK_EXT_sampler_filter_minmax</b>] </summary>
        SamplerReductionModeMinExt = 1,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        SamplerReductionModeWeightedAverage = 0,
        /// <summary>[requires: <b>VK_EXT_sampler_filter_minmax</b>] </summary>
        SamplerReductionModeWeightedAverageExt = 0,
        /// <summary>[requires: <b>VK_QCOM_filter_cubic_clamp</b>] </summary>
        SamplerReductionModeWeightedAverageRangeclampQcom = 1000521000,
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSamplerYcbcrModelConversion.html" /></remarks>
    public enum VkSamplerYcbcrModelConversion : int
    {
        /// <summary>[requires: <b>v1.1</b>] </summary>
        SamplerYcbcrModelConversionRgbIdentity = 0,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        SamplerYcbcrModelConversionRgbIdentityKhr = 0,
        /// <summary>[requires: <b>v1.1</b>] aka UHD YUV</summary>
        SamplerYcbcrModelConversionYcbcr2020 = 4,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        SamplerYcbcrModelConversionYcbcr2020Khr = 4,
        /// <summary>[requires: <b>v1.1</b>] aka SD YUV</summary>
        SamplerYcbcrModelConversionYcbcr601 = 3,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        SamplerYcbcrModelConversionYcbcr601Khr = 3,
        /// <summary>[requires: <b>v1.1</b>] aka HD YUV</summary>
        SamplerYcbcrModelConversionYcbcr709 = 2,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        SamplerYcbcrModelConversionYcbcr709Khr = 2,
        /// <summary>[requires: <b>v1.1</b>] just range expansion</summary>
        SamplerYcbcrModelConversionYcbcrIdentity = 1,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        SamplerYcbcrModelConversionYcbcrIdentityKhr = 1,
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSamplerYcbcrRange.html" /></remarks>
    public enum VkSamplerYcbcrRange : int
    {
        /// <summary>[requires: <b>v1.1</b>] Luma 0..1 maps to 0..255, chroma -0.5..0.5 to 1..255 (clamped)</summary>
        SamplerYcbcrRangeItuFull = 0,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        SamplerYcbcrRangeItuFullKhr = 0,
        /// <summary>[requires: <b>v1.1</b>] Luma 0..1 maps to 16..235, chroma -0.5..0.5 to 16..240</summary>
        SamplerYcbcrRangeItuNarrow = 1,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        SamplerYcbcrRangeItuNarrowKhr = 1,
    }
    /// <summary><b>[requires: VK_NV_external_sci_sync | VK_NV_external_sci_sync2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSciSyncClientTypeNV.html" /></remarks>
    public enum VkSciSyncClientTypeNV : int
    {
        /// <summary>[requires: <b>VK_NV_external_sci_sync | VK_NV_external_sci_sync2</b>] </summary>
        SciSyncClientTypeSignalerNv = 0,
        /// <summary>[requires: <b>VK_NV_external_sci_sync | VK_NV_external_sci_sync2</b>] </summary>
        SciSyncClientTypeSignalerWaiterNv = 2,
        /// <summary>[requires: <b>VK_NV_external_sci_sync | VK_NV_external_sci_sync2</b>] </summary>
        SciSyncClientTypeWaiterNv = 1,
    }
    /// <summary><b>[requires: VK_NV_external_sci_sync | VK_NV_external_sci_sync2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSciSyncPrimitiveTypeNV.html" /></remarks>
    public enum VkSciSyncPrimitiveTypeNV : int
    {
        /// <summary>[requires: <b>VK_NV_external_sci_sync | VK_NV_external_sci_sync2</b>] </summary>
        SciSyncPrimitiveTypeFenceNv = 0,
        /// <summary>[requires: <b>VK_NV_external_sci_sync | VK_NV_external_sci_sync2</b>] </summary>
        SciSyncPrimitiveTypeSemaphoreNv = 1,
    }
    /// <summary><b>[requires: VK_KHR_cooperative_matrix]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkScopeKHR.html" /></remarks>
    public enum VkScopeKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_cooperative_matrix</b>] </summary>
        ScopeDeviceKhr = 1,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ScopeDeviceNv = 1,
        /// <summary>[requires: <b>VK_KHR_cooperative_matrix</b>] </summary>
        ScopeQueueFamilyKhr = 5,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ScopeQueueFamilyNv = 5,
        /// <summary>[requires: <b>VK_KHR_cooperative_matrix</b>] </summary>
        ScopeSubgroupKhr = 3,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ScopeSubgroupNv = 3,
        /// <summary>[requires: <b>VK_KHR_cooperative_matrix</b>] </summary>
        ScopeWorkgroupKhr = 2,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        ScopeWorkgroupNv = 2,
    }
    /// <summary><b>[requires: VK_QNX_screen_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkScreenSurfaceCreateFlagsQNX.html" /></remarks>
    [Flags]
    public enum VkScreenSurfaceCreateFlagsQNX : uint
    {
    }
    /// <summary></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSemaphoreCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkSemaphoreCreateFlagBits : int
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSemaphoreCreateFlags.html" /></remarks>
    [Flags]
    public enum VkSemaphoreCreateFlags : uint
    {
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSemaphoreImportFlagBits.html" /></remarks>
    [Flags]
    public enum VkSemaphoreImportFlagBits : uint
    {
        /// <summary>[requires: <b>v1.1</b>] </summary>
        SemaphoreImportTemporaryBit = 1,
        /// <summary>[requires: <b>VK_KHR_external_semaphore</b>] </summary>
        SemaphoreImportTemporaryBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_external_semaphore]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSemaphoreImportFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkSemaphoreImportFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSemaphoreType.html" /></remarks>
    public enum VkSemaphoreType : int
    {
        /// <summary>[requires: <b>v1.2</b>] </summary>
        SemaphoreTypeBinary = 0,
        /// <summary>[requires: <b>VK_KHR_timeline_semaphore</b>] </summary>
        SemaphoreTypeBinaryKhr = 0,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        SemaphoreTypeTimeline = 1,
        /// <summary>[requires: <b>VK_KHR_timeline_semaphore</b>] </summary>
        SemaphoreTypeTimelineKhr = 1,
    }
    /// <summary><b>[requires: v1.2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSemaphoreWaitFlagBits.html" /></remarks>
    [Flags]
    public enum VkSemaphoreWaitFlagBits : uint
    {
        /// <summary>[requires: <b>v1.2</b>] </summary>
        SemaphoreWaitAnyBit = 1,
        /// <summary>[requires: <b>VK_KHR_timeline_semaphore</b>] </summary>
        SemaphoreWaitAnyBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_timeline_semaphore]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSemaphoreWaitFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkSemaphoreWaitFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_shader_object]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkShaderCodeTypeEXT.html" /></remarks>
    public enum VkShaderCodeTypeEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        ShaderCodeTypeBinaryExt = 0,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        ShaderCodeTypeSpirvExt = 1,
    }
    /// <summary><b>[requires: VK_AMD_shader_core_properties2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkShaderCorePropertiesFlagBitsAMD.html" /></remarks>
    [Flags]
    public enum VkShaderCorePropertiesFlagBitsAMD : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_shader_object]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkShaderCreateFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkShaderCreateFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        ShaderCreateAllowVaryingSubgroupSizeBitExt = 2,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        ShaderCreateDispatchBaseBitExt = 16,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        ShaderCreateFragmentDensityMapAttachmentBitExt = 64,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        ShaderCreateFragmentShadingRateAttachmentBitExt = 32,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        ShaderCreateIndirectBindableBitExt = 128,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        ShaderCreateLinkStageBitExt = 1,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        ShaderCreateNoTaskShaderBitExt = 8,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        ShaderCreateRequireFullSubgroupsBitExt = 4,
    }
    /// <summary><b>[requires: v1.2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkShaderFloatControlsIndependence.html" /></remarks>
    public enum VkShaderFloatControlsIndependence : int
    {
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ShaderFloatControlsIndependence32BitOnly = 0,
        /// <summary>[requires: <b>VK_KHR_shader_float_controls</b>] </summary>
        ShaderFloatControlsIndependence32BitOnlyKhr = 0,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ShaderFloatControlsIndependenceAll = 1,
        /// <summary>[requires: <b>VK_KHR_shader_float_controls</b>] </summary>
        ShaderFloatControlsIndependenceAllKhr = 1,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        ShaderFloatControlsIndependenceNone = 2,
        /// <summary>[requires: <b>VK_KHR_shader_float_controls</b>] </summary>
        ShaderFloatControlsIndependenceNoneKhr = 2,
    }
    /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> Used by <see cref="Vk.GetRayTracingShaderGroupStackSizeKHR"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkShaderGroupShaderKHR.html" /></remarks>
    public enum VkShaderGroupShaderKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        ShaderGroupShaderAnyHitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        ShaderGroupShaderClosestHitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        ShaderGroupShaderGeneralKhr = 0,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        ShaderGroupShaderIntersectionKhr = 3,
    }
    /// <summary><b>[requires: VK_AMD_shader_info]</b> Used by <see cref="Vk.GetShaderInfoAMD"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkShaderInfoTypeAMD.html" /></remarks>
    public enum VkShaderInfoTypeAMD : int
    {
        /// <summary>[requires: <b>VK_AMD_shader_info</b>] </summary>
        ShaderInfoTypeBinaryAmd = 1,
        /// <summary>[requires: <b>VK_AMD_shader_info</b>] </summary>
        ShaderInfoTypeDisassemblyAmd = 2,
        /// <summary>[requires: <b>VK_AMD_shader_info</b>] </summary>
        ShaderInfoTypeStatisticsAmd = 0,
    }
    /// <summary></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkShaderModuleCreateFlagBits.html" /></remarks>
    [Flags]
    public enum VkShaderModuleCreateFlagBits : int
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkShaderModuleCreateFlags.html" /></remarks>
    [Flags]
    public enum VkShaderModuleCreateFlags : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdBindShadersEXT"/>, <see cref="Vk.CmdPushConstants"/>, <see cref="Vk.GetShaderInfoAMD"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkShaderStageFlagBits.html" /></remarks>
    [Flags]
    public enum VkShaderStageFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ShaderStageAll = 2147483647,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ShaderStageAllGraphics = 31,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        ShaderStageAnyHitBitKhr = 512,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        ShaderStageAnyHitBitNv = 512,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        ShaderStageCallableBitKhr = 8192,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        ShaderStageCallableBitNv = 8192,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        ShaderStageClosestHitBitKhr = 1024,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        ShaderStageClosestHitBitNv = 1024,
        /// <summary>[requires: <b>VK_HUAWEI_cluster_culling_shader</b>] </summary>
        ShaderStageClusterCullingBitHuawei = 524288,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ShaderStageComputeBit = 32,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ShaderStageFragmentBit = 16,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ShaderStageGeometryBit = 8,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        ShaderStageIntersectionBitKhr = 4096,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        ShaderStageIntersectionBitNv = 4096,
        /// <summary>[requires: <b>VK_EXT_mesh_shader</b>] </summary>
        ShaderStageMeshBitExt = 128,
        /// <summary>[requires: <b>VK_NV_mesh_shader</b>] </summary>
        ShaderStageMeshBitNv = 128,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        ShaderStageMissBitKhr = 2048,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        ShaderStageMissBitNv = 2048,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        ShaderStageRaygenBitKhr = 256,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        ShaderStageRaygenBitNv = 256,
        /// <summary>[requires: <b>VK_HUAWEI_subpass_shading</b>] </summary>
        ShaderStageSubpassShadingBitHuawei = 16384,
        /// <summary>[requires: <b>VK_EXT_mesh_shader</b>] </summary>
        ShaderStageTaskBitExt = 64,
        /// <summary>[requires: <b>VK_NV_mesh_shader</b>] </summary>
        ShaderStageTaskBitNv = 64,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ShaderStageTessellationControlBit = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ShaderStageTessellationEvaluationBit = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        ShaderStageVertexBit = 1,
    }
    /// <summary><b>[requires: VK_NV_shading_rate_image]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkShadingRatePaletteEntryNV.html" /></remarks>
    public enum VkShadingRatePaletteEntryNV : int
    {
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ShadingRatePaletteEntry1InvocationPer1x2PixelsNv = 7,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ShadingRatePaletteEntry1InvocationPer2x1PixelsNv = 6,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ShadingRatePaletteEntry1InvocationPer2x2PixelsNv = 8,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ShadingRatePaletteEntry1InvocationPer2x4PixelsNv = 10,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ShadingRatePaletteEntry1InvocationPer4x2PixelsNv = 9,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ShadingRatePaletteEntry1InvocationPer4x4PixelsNv = 11,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ShadingRatePaletteEntry1InvocationPerPixelNv = 5,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ShadingRatePaletteEntry16InvocationsPerPixelNv = 1,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ShadingRatePaletteEntry2InvocationsPerPixelNv = 4,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ShadingRatePaletteEntry4InvocationsPerPixelNv = 3,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ShadingRatePaletteEntry8InvocationsPerPixelNv = 2,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        ShadingRatePaletteEntryNoInvocationsNv = 0,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSharingMode.html" /></remarks>
    public enum VkSharingMode : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SharingModeConcurrent = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SharingModeExclusive = 0,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSparseImageFormatFlagBits.html" /></remarks>
    [Flags]
    public enum VkSparseImageFormatFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] Image requires mip level dimensions to be an integer multiple of the sparse image block dimensions for non-tail mip levels.</summary>
        SparseImageFormatAlignedMipSizeBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Image uses a non-standard sparse image block dimensions</summary>
        SparseImageFormatNonstandardBlockSizeBit = 4,
        /// <summary>[requires: <b>v1.0</b>] Image uses a single mip tail region for all array layers</summary>
        SparseImageFormatSingleMiptailBit = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSparseMemoryBindFlagBits.html" /></remarks>
    [Flags]
    public enum VkSparseMemoryBindFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] Operation binds resource metadata to memory</summary>
        SparseMemoryBindMetadataBit = 1,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdSetStencilCompareMask"/>, <see cref="Vk.CmdSetStencilOp"/>, <see cref="Vk.CmdSetStencilOpEXT"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkStencilFaceFlagBits.html" /></remarks>
    [Flags]
    public enum VkStencilFaceFlagBits : uint
    {
        /// <summary>[requires: <b>v1.0</b>] Back face</summary>
        StencilFaceBackBit = 2,
        /// <summary>[requires: <b>v1.0</b>] Front and back faces</summary>
        StencilFaceFrontAndBack = 3,
        /// <summary>[requires: <b>v1.0</b>] Front face</summary>
        StencilFaceFrontBit = 1,
        /// <summary>[requires: <b>v1.0</b>] Front and back faces</summary>
        StencilFrontAndBack = 3,
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdSetStencilOp"/>, <see cref="Vk.CmdSetStencilOp"/>, <see cref="Vk.CmdSetStencilOp"/>, ...</summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkStencilOp.html" /></remarks>
    public enum VkStencilOp : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StencilOpDecrementAndClamp = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StencilOpDecrementAndWrap = 7,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StencilOpIncrementAndClamp = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StencilOpIncrementAndWrap = 6,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StencilOpInvert = 5,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StencilOpKeep = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StencilOpReplace = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StencilOpZero = 1,
    }
    /// <summary><b>[requires: VK_GGP_stream_descriptor_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkStreamDescriptorSurfaceCreateFlagsGGP.html" /></remarks>
    [Flags]
    public enum VkStreamDescriptorSurfaceCreateFlagsGGP : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkStructureType.html" /></remarks>
    public enum VkStructureType : int
    {
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeAccelerationStructureBuildGeometryInfoKhr = 1000150000,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeAccelerationStructureBuildSizesInfoKhr = 1000150020,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypeAccelerationStructureCaptureDescriptorDataInfoExt = 1000316009,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeAccelerationStructureCreateInfoKhr = 1000150017,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        StructureTypeAccelerationStructureCreateInfoNv = 1000165001,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeAccelerationStructureDeviceAddressInfoKhr = 1000150002,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeAccelerationStructureGeometryAabbsDataKhr = 1000150003,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeAccelerationStructureGeometryInstancesDataKhr = 1000150004,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeAccelerationStructureGeometryKhr = 1000150006,
        /// <summary>[requires: <b>VK_NV_ray_tracing_linear_swept_spheres</b>] </summary>
        StructureTypeAccelerationStructureGeometryLinearSweptSpheresDataNv = 1000429009,
        /// <summary>[requires: <b>VK_NV_ray_tracing_motion_blur</b>] </summary>
        StructureTypeAccelerationStructureGeometryMotionTrianglesDataNv = 1000327000,
        /// <summary>[requires: <b>VK_NV_ray_tracing_linear_swept_spheres</b>] </summary>
        StructureTypeAccelerationStructureGeometrySpheresDataNv = 1000429010,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeAccelerationStructureGeometryTrianglesDataKhr = 1000150005,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        StructureTypeAccelerationStructureInfoNv = 1000165012,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        StructureTypeAccelerationStructureMemoryRequirementsInfoNv = 1000165008,
        /// <summary>[requires: <b>VK_NV_ray_tracing_motion_blur</b>] </summary>
        StructureTypeAccelerationStructureMotionInfoNv = 1000327002,
        /// <summary>[requires: <b>VK_NV_displacement_micromap</b>] </summary>
        StructureTypeAccelerationStructureTrianglesDisplacementMicromapNv = 1000397002,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        StructureTypeAccelerationStructureTrianglesOpacityMicromapExt = 1000396009,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeAccelerationStructureVersionInfoKhr = 1000150009,
        /// <summary>[requires: <b>VK_KHR_swapchain | VK_KHR_device_group</b>] </summary>
        StructureTypeAcquireNextImageInfoKhr = 1000060010,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        StructureTypeAcquireProfilingLockInfoKhr = 1000116004,
        /// <summary>[requires: <b>VK_SEC_amigo_profiling</b>] </summary>
        StructureTypeAmigoProfilingSubmitInfoSec = 1000485001,
        /// <summary>[requires: <b>VK_ANDROID_external_memory_android_hardware_buffer</b>] </summary>
        StructureTypeAndroidHardwareBufferFormatProperties2Android = 1000129006,
        /// <summary>[requires: <b>VK_ANDROID_external_memory_android_hardware_buffer</b>] </summary>
        StructureTypeAndroidHardwareBufferFormatPropertiesAndroid = 1000129002,
        /// <summary>[requires: <b>VK_ANDROID_external_format_resolve</b>] </summary>
        StructureTypeAndroidHardwareBufferFormatResolvePropertiesAndroid = 1000468002,
        /// <summary>[requires: <b>VK_ANDROID_external_memory_android_hardware_buffer</b>] </summary>
        StructureTypeAndroidHardwareBufferPropertiesAndroid = 1000129001,
        /// <summary>[requires: <b>VK_ANDROID_external_memory_android_hardware_buffer</b>] </summary>
        StructureTypeAndroidHardwareBufferUsageAndroid = 1000129000,
        /// <summary>[requires: <b>VK_KHR_android_surface</b>] </summary>
        StructureTypeAndroidSurfaceCreateInfoKhr = 1000008000,
        /// <summary>[requires: <b>VK_AMD_anti_lag</b>] </summary>
        StructureTypeAntiLagDataAmd = 1000476001,
        /// <summary>[requires: <b>VK_AMD_anti_lag</b>] </summary>
        StructureTypeAntiLagPresentationInfoAmd = 1000476002,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeApplicationInfo = 0,
        /// <summary>[requires: <b>VK_EXT_application_parameters</b>] </summary>
        StructureTypeApplicationParametersExt = 1000435000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeAttachmentDescription2 = 1000109000,
        /// <summary>[requires: <b>VK_KHR_create_renderpass2</b>] </summary>
        StructureTypeAttachmentDescription2Khr = 1000109000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeAttachmentDescriptionStencilLayout = 1000241002,
        /// <summary>[requires: <b>VK_KHR_separate_depth_stencil_layouts</b>] </summary>
        StructureTypeAttachmentDescriptionStencilLayoutKhr = 1000241002,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeAttachmentReference2 = 1000109001,
        /// <summary>[requires: <b>VK_KHR_create_renderpass2</b>] </summary>
        StructureTypeAttachmentReference2Khr = 1000109001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeAttachmentReferenceStencilLayout = 1000241001,
        /// <summary>[requires: <b>VK_KHR_separate_depth_stencil_layouts</b>] </summary>
        StructureTypeAttachmentReferenceStencilLayoutKhr = 1000241001,
        /// <summary>[requires: <b>VK_AMD_mixed_attachment_samples</b>] </summary>
        StructureTypeAttachmentSampleCountInfoAmd = 1000044008,
        /// <summary>[requires: <b>VK_NV_framebuffer_mixed_samples</b>] </summary>
        StructureTypeAttachmentSampleCountInfoNv = 1000044008,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        StructureTypeBindAccelerationStructureMemoryInfoNv = 1000165006,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeBindBufferMemoryDeviceGroupInfo = 1000060013,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        StructureTypeBindBufferMemoryDeviceGroupInfoKhr = 1000060013,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeBindBufferMemoryInfo = 1000157000,
        /// <summary>[requires: <b>VK_KHR_bind_memory2</b>] </summary>
        StructureTypeBindBufferMemoryInfoKhr = 1000157000,
        /// <summary>[requires: <b>VK_KHR_maintenance6</b>] </summary>
        StructureTypeBindDescriptorBufferEmbeddedSamplersInfoExt = 1000545008,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeBindDescriptorSetsInfo = 1000545003,
        /// <summary>[requires: <b>VK_KHR_maintenance6</b>] </summary>
        StructureTypeBindDescriptorSetsInfoKhr = 1000545003,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeBindImageMemoryDeviceGroupInfo = 1000060014,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        StructureTypeBindImageMemoryDeviceGroupInfoKhr = 1000060014,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeBindImageMemoryInfo = 1000157001,
        /// <summary>[requires: <b>VK_KHR_bind_memory2</b>] </summary>
        StructureTypeBindImageMemoryInfoKhr = 1000157001,
        /// <summary>[requires: <b>VK_KHR_swapchain | VK_KHR_device_group</b>] </summary>
        StructureTypeBindImageMemorySwapchainInfoKhr = 1000060009,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeBindImagePlaneMemoryInfo = 1000156002,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        StructureTypeBindImagePlaneMemoryInfoKhr = 1000156002,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeBindMemoryStatus = 1000545002,
        /// <summary>[requires: <b>VK_KHR_maintenance6</b>] </summary>
        StructureTypeBindMemoryStatusKhr = 1000545002,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeBindSparseInfo = 7,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeBindVideoSessionMemoryInfoKhr = 1000023004,
        /// <summary>[requires: <b>VK_QCOM_filter_cubic_weights</b>] </summary>
        StructureTypeBlitImageCubicWeightsInfoQcom = 1000519002,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeBlitImageInfo2 = 1000337004,
        /// <summary>[requires: <b>VK_KHR_copy_commands2</b>] </summary>
        StructureTypeBlitImageInfo2Khr = 1000337004,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypeBufferCaptureDescriptorDataInfoExt = 1000316005,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        StructureTypeBufferCollectionBufferCreateInfoFuchsia = 1000366005,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        StructureTypeBufferCollectionConstraintsInfoFuchsia = 1000366009,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        StructureTypeBufferCollectionCreateInfoFuchsia = 1000366000,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        StructureTypeBufferCollectionImageCreateInfoFuchsia = 1000366002,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        StructureTypeBufferCollectionPropertiesFuchsia = 1000366003,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        StructureTypeBufferConstraintsInfoFuchsia = 1000366004,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeBufferCopy2 = 1000337006,
        /// <summary>[requires: <b>VK_KHR_copy_commands2</b>] </summary>
        StructureTypeBufferCopy2Khr = 1000337006,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeBufferCreateInfo = 12,
        /// <summary>[requires: <b>VK_EXT_buffer_device_address</b>] </summary>
        StructureTypeBufferDeviceAddressCreateInfoExt = 1000244002,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeBufferDeviceAddressInfo = 1000244001,
        /// <summary>[requires: <b>VK_EXT_buffer_device_address</b>] </summary>
        StructureTypeBufferDeviceAddressInfoExt = 1000244001,
        /// <summary>[requires: <b>VK_KHR_buffer_device_address</b>] </summary>
        StructureTypeBufferDeviceAddressInfoKhr = 1000244001,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeBufferImageCopy2 = 1000337009,
        /// <summary>[requires: <b>VK_KHR_copy_commands2</b>] </summary>
        StructureTypeBufferImageCopy2Khr = 1000337009,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeBufferMemoryBarrier = 44,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeBufferMemoryBarrier2 = 1000314001,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        StructureTypeBufferMemoryBarrier2Khr = 1000314001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeBufferMemoryRequirementsInfo2 = 1000146000,
        /// <summary>[requires: <b>VK_KHR_get_memory_requirements2</b>] </summary>
        StructureTypeBufferMemoryRequirementsInfo2Khr = 1000146000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeBufferOpaqueCaptureAddressCreateInfo = 1000257002,
        /// <summary>[requires: <b>VK_KHR_buffer_device_address</b>] </summary>
        StructureTypeBufferOpaqueCaptureAddressCreateInfoKhr = 1000257002,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeBufferUsageFlags2CreateInfo = 1000470006,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        StructureTypeBufferUsageFlags2CreateInfoKhr = 1000470006,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeBufferViewCreateInfo = 13,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        StructureTypeBuildPartitionedAccelerationStructureInfoNv = 1000570004,
        /// <summary>[requires: <b>VK_EXT_calibrated_timestamps</b>] </summary>
        StructureTypeCalibratedTimestampInfoExt = 1000184000,
        /// <summary>[requires: <b>VK_KHR_calibrated_timestamps</b>] </summary>
        StructureTypeCalibratedTimestampInfoKhr = 1000184000,
        /// <summary>[requires: <b>VK_NV_device_diagnostic_checkpoints</b>] </summary>
        StructureTypeCheckpointData2Nv = 1000314009,
        /// <summary>[requires: <b>VK_NV_device_diagnostic_checkpoints</b>] </summary>
        StructureTypeCheckpointDataNv = 1000206000,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        StructureTypeClusterAccelerationStructureClustersBottomLevelInputNv = 1000569002,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        StructureTypeClusterAccelerationStructureCommandsInfoNv = 1000569006,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        StructureTypeClusterAccelerationStructureInputInfoNv = 1000569005,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        StructureTypeClusterAccelerationStructureMoveObjectsInputNv = 1000569004,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        StructureTypeClusterAccelerationStructureTriangleClusterInputNv = 1000569003,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeCommandBufferAllocateInfo = 40,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeCommandBufferBeginInfo = 42,
        /// <summary>[requires: <b>VK_EXT_conditional_rendering</b>] </summary>
        StructureTypeCommandBufferInheritanceConditionalRenderingInfoExt = 1000081000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeCommandBufferInheritanceInfo = 41,
        /// <summary>[requires: <b>VK_QCOM_render_pass_transform</b>] </summary>
        StructureTypeCommandBufferInheritanceRenderPassTransformInfoQcom = 1000282000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeCommandBufferInheritanceRenderingInfo = 1000044004,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering</b>] </summary>
        StructureTypeCommandBufferInheritanceRenderingInfoKhr = 1000044004,
        /// <summary>[requires: <b>VK_NV_inherited_viewport_scissor</b>] </summary>
        StructureTypeCommandBufferInheritanceViewportScissorInfoNv = 1000278001,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeCommandBufferSubmitInfo = 1000314006,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        StructureTypeCommandBufferSubmitInfoKhr = 1000314006,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeCommandPoolCreateInfo = 39,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeComputePipelineCreateInfo = 29,
        /// <summary>[requires: <b>VK_NV_device_generated_commands_compute</b>] </summary>
        StructureTypeComputePipelineIndirectBufferInfoNv = 1000428001,
        /// <summary>[requires: <b>VK_EXT_conditional_rendering</b>] </summary>
        StructureTypeConditionalRenderingBeginInfoExt = 1000081002,
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        StructureTypeConvertCooperativeVectorMatrixInfoNv = 1000491004,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix2</b>] </summary>
        StructureTypeCooperativeMatrixFlexibleDimensionsPropertiesNv = 1000593001,
        /// <summary>[requires: <b>VK_KHR_cooperative_matrix</b>] </summary>
        StructureTypeCooperativeMatrixPropertiesKhr = 1000506001,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        StructureTypeCooperativeMatrixPropertiesNv = 1000249001,
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        StructureTypeCooperativeVectorPropertiesNv = 1000491002,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeCopyAccelerationStructureInfoKhr = 1000150010,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeCopyAccelerationStructureToMemoryInfoKhr = 1000150011,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeCopyBufferInfo2 = 1000337000,
        /// <summary>[requires: <b>VK_KHR_copy_commands2</b>] </summary>
        StructureTypeCopyBufferInfo2Khr = 1000337000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeCopyBufferToImageInfo2 = 1000337002,
        /// <summary>[requires: <b>VK_KHR_copy_commands2</b>] </summary>
        StructureTypeCopyBufferToImageInfo2Khr = 1000337002,
        /// <summary>[requires: <b>VK_QCOM_rotated_copy_commands</b>] </summary>
        StructureTypeCopyCommandTransformInfoQcom = 1000333000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeCopyDescriptorSet = 36,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeCopyImageInfo2 = 1000337001,
        /// <summary>[requires: <b>VK_KHR_copy_commands2</b>] </summary>
        StructureTypeCopyImageInfo2Khr = 1000337001,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeCopyImageToBufferInfo2 = 1000337003,
        /// <summary>[requires: <b>VK_KHR_copy_commands2</b>] </summary>
        StructureTypeCopyImageToBufferInfo2Khr = 1000337003,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeCopyImageToImageInfo = 1000270007,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] </summary>
        StructureTypeCopyImageToImageInfoExt = 1000270007,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeCopyImageToMemoryInfo = 1000270004,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] </summary>
        StructureTypeCopyImageToMemoryInfoExt = 1000270004,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeCopyMemoryToAccelerationStructureInfoKhr = 1000150012,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeCopyMemoryToImageInfo = 1000270005,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] </summary>
        StructureTypeCopyMemoryToImageInfoExt = 1000270005,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        StructureTypeCopyMemoryToMicromapInfoExt = 1000396004,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        StructureTypeCopyMicromapInfoExt = 1000396002,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        StructureTypeCopyMicromapToMemoryInfoExt = 1000396003,
        /// <summary>[requires: <b>VK_NVX_binary_import</b>] </summary>
        StructureTypeCuFunctionCreateInfoNvx = 1000029001,
        /// <summary>[requires: <b>VK_NVX_binary_import</b>] </summary>
        StructureTypeCuLaunchInfoNvx = 1000029002,
        /// <summary>[requires: <b>VK_NVX_binary_import</b>] </summary>
        StructureTypeCuModuleCreateInfoNvx = 1000029000,
        /// <summary>[requires: <b>VK_NVX_binary_import</b>] </summary>
        StructureTypeCuModuleTexturingModeCreateInfoNvx = 1000029004,
        /// <summary>[requires: <b>VK_NV_cuda_kernel_launch</b>] </summary>
        StructureTypeCudaFunctionCreateInfoNv = 1000307001,
        /// <summary>[requires: <b>VK_NV_cuda_kernel_launch</b>] </summary>
        StructureTypeCudaLaunchInfoNv = 1000307002,
        /// <summary>[requires: <b>VK_NV_cuda_kernel_launch</b>] </summary>
        StructureTypeCudaModuleCreateInfoNv = 1000307000,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_win32</b>] </summary>
        StructureTypeD3d12FenceSubmitInfoKhr = 1000078002,
        /// <summary>[requires: <b>VK_EXT_debug_marker</b>] </summary>
        StructureTypeDebugMarkerMarkerInfoExt = 1000022002,
        /// <summary>[requires: <b>VK_EXT_debug_marker</b>] </summary>
        StructureTypeDebugMarkerObjectNameInfoExt = 1000022000,
        /// <summary>[requires: <b>VK_EXT_debug_marker</b>] </summary>
        StructureTypeDebugMarkerObjectTagInfoExt = 1000022001,
        /// <summary>[requires: <b>VK_EXT_debug_report</b>] </summary>
        StructureTypeDebugReportCallbackCreateInfoExt = 1000011000,
        /// <summary>[requires: <b>VK_EXT_debug_report</b>] </summary>
        StructureTypeDebugReportCreateInfoExt = 1000011000,
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        StructureTypeDebugUtilsLabelExt = 1000128002,
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        StructureTypeDebugUtilsMessengerCallbackDataExt = 1000128003,
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        StructureTypeDebugUtilsMessengerCreateInfoExt = 1000128004,
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        StructureTypeDebugUtilsObjectNameInfoExt = 1000128000,
        /// <summary>[requires: <b>VK_EXT_debug_utils</b>] </summary>
        StructureTypeDebugUtilsObjectTagInfoExt = 1000128001,
        /// <summary>[requires: <b>VK_NV_dedicated_allocation</b>] </summary>
        StructureTypeDedicatedAllocationBufferCreateInfoNv = 1000026001,
        /// <summary>[requires: <b>VK_NV_dedicated_allocation</b>] </summary>
        StructureTypeDedicatedAllocationImageCreateInfoNv = 1000026000,
        /// <summary>[requires: <b>VK_NV_dedicated_allocation</b>] </summary>
        StructureTypeDedicatedAllocationMemoryAllocateInfoNv = 1000026002,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeDependencyInfo = 1000314003,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        StructureTypeDependencyInfoKhr = 1000314003,
        /// <summary>[requires: <b>VK_EXT_depth_bias_control</b>] </summary>
        StructureTypeDepthBiasInfoExt = 1000283001,
        /// <summary>[requires: <b>VK_EXT_depth_bias_control</b>] </summary>
        StructureTypeDepthBiasRepresentationInfoExt = 1000283002,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypeDescriptorAddressInfoExt = 1000316003,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypeDescriptorBufferBindingInfoExt = 1000316011,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypeDescriptorBufferBindingPushDescriptorBufferHandleExt = 1000316012,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypeDescriptorGetInfoExt = 1000316004,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeDescriptorPoolCreateInfo = 33,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeDescriptorPoolInlineUniformBlockCreateInfo = 1000138003,
        /// <summary>[requires: <b>VK_EXT_inline_uniform_block</b>] </summary>
        StructureTypeDescriptorPoolInlineUniformBlockCreateInfoExt = 1000138003,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeDescriptorSetAllocateInfo = 34,
        /// <summary>[requires: <b>VK_VALVE_descriptor_set_host_mapping</b>] </summary>
        StructureTypeDescriptorSetBindingReferenceValve = 1000420001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeDescriptorSetLayoutBindingFlagsCreateInfo = 1000161000,
        /// <summary>[requires: <b>VK_EXT_descriptor_indexing</b>] </summary>
        StructureTypeDescriptorSetLayoutBindingFlagsCreateInfoExt = 1000161000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeDescriptorSetLayoutCreateInfo = 32,
        /// <summary>[requires: <b>VK_VALVE_descriptor_set_host_mapping</b>] </summary>
        StructureTypeDescriptorSetLayoutHostMappingInfoValve = 1000420002,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeDescriptorSetLayoutSupport = 1000168001,
        /// <summary>[requires: <b>VK_KHR_maintenance3</b>] </summary>
        StructureTypeDescriptorSetLayoutSupportKhr = 1000168001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeDescriptorSetVariableDescriptorCountAllocateInfo = 1000161003,
        /// <summary>[requires: <b>VK_EXT_descriptor_indexing</b>] </summary>
        StructureTypeDescriptorSetVariableDescriptorCountAllocateInfoExt = 1000161003,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeDescriptorSetVariableDescriptorCountLayoutSupport = 1000161004,
        /// <summary>[requires: <b>VK_EXT_descriptor_indexing</b>] </summary>
        StructureTypeDescriptorSetVariableDescriptorCountLayoutSupportExt = 1000161004,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeDescriptorUpdateTemplateCreateInfo = 1000085000,
        /// <summary>[requires: <b>VK_KHR_descriptor_update_template</b>] </summary>
        StructureTypeDescriptorUpdateTemplateCreateInfoKhr = 1000085000,
        /// <summary>[requires: <b>VK_EXT_device_address_binding_report</b>] </summary>
        StructureTypeDeviceAddressBindingCallbackDataExt = 1000354001,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeDeviceBufferMemoryRequirements = 1000413002,
        /// <summary>[requires: <b>VK_KHR_maintenance4</b>] </summary>
        StructureTypeDeviceBufferMemoryRequirementsKhr = 1000413002,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeDeviceCreateInfo = 3,
        /// <summary>[requires: <b>VK_EXT_device_memory_report</b>] </summary>
        StructureTypeDeviceDeviceMemoryReportCreateInfoExt = 1000284001,
        /// <summary>[requires: <b>VK_NV_device_diagnostics_config</b>] </summary>
        StructureTypeDeviceDiagnosticsConfigCreateInfoNv = 1000300001,
        /// <summary>[requires: <b>VK_EXT_display_control</b>] </summary>
        StructureTypeDeviceEventInfoExt = 1000091001,
        /// <summary>[requires: <b>VK_EXT_device_fault</b>] </summary>
        StructureTypeDeviceFaultCountsExt = 1000341001,
        /// <summary>[requires: <b>VK_EXT_device_fault</b>] </summary>
        StructureTypeDeviceFaultInfoExt = 1000341002,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeDeviceGroupBindSparseInfo = 1000060006,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        StructureTypeDeviceGroupBindSparseInfoKhr = 1000060006,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeDeviceGroupCommandBufferBeginInfo = 1000060004,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        StructureTypeDeviceGroupCommandBufferBeginInfoKhr = 1000060004,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeDeviceGroupDeviceCreateInfo = 1000070001,
        /// <summary>[requires: <b>VK_KHR_device_group_creation</b>] </summary>
        StructureTypeDeviceGroupDeviceCreateInfoKhr = 1000070001,
        /// <summary>[requires: <b>VK_KHR_swapchain | VK_KHR_device_group</b>] </summary>
        StructureTypeDeviceGroupPresentCapabilitiesKhr = 1000060007,
        /// <summary>[requires: <b>VK_KHR_swapchain | VK_KHR_device_group</b>] </summary>
        StructureTypeDeviceGroupPresentInfoKhr = 1000060011,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeDeviceGroupRenderPassBeginInfo = 1000060003,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        StructureTypeDeviceGroupRenderPassBeginInfoKhr = 1000060003,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeDeviceGroupSubmitInfo = 1000060005,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        StructureTypeDeviceGroupSubmitInfoKhr = 1000060005,
        /// <summary>[requires: <b>VK_KHR_swapchain | VK_KHR_device_group</b>] </summary>
        StructureTypeDeviceGroupSwapchainCreateInfoKhr = 1000060012,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeDeviceImageMemoryRequirements = 1000413003,
        /// <summary>[requires: <b>VK_KHR_maintenance4</b>] </summary>
        StructureTypeDeviceImageMemoryRequirementsKhr = 1000413003,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeDeviceImageSubresourceInfo = 1000470004,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        StructureTypeDeviceImageSubresourceInfoKhr = 1000470004,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeDeviceMemoryOpaqueCaptureAddressInfo = 1000257004,
        /// <summary>[requires: <b>VK_KHR_buffer_device_address</b>] </summary>
        StructureTypeDeviceMemoryOpaqueCaptureAddressInfoKhr = 1000257004,
        /// <summary>[requires: <b>VK_AMD_memory_overallocation_behavior</b>] </summary>
        StructureTypeDeviceMemoryOverallocationCreateInfoAmd = 1000189000,
        /// <summary>[requires: <b>VK_EXT_device_memory_report</b>] </summary>
        StructureTypeDeviceMemoryReportCallbackDataExt = 1000284002,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        StructureTypeDevicePipelineBinaryInternalCacheControlKhr = 1000483008,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeDevicePrivateDataCreateInfo = 1000295001,
        /// <summary>[requires: <b>VK_EXT_private_data</b>] </summary>
        StructureTypeDevicePrivateDataCreateInfoExt = 1000295001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeDeviceQueueCreateInfo = 2,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeDeviceQueueGlobalPriorityCreateInfo = 1000174000,
        /// <summary>[requires: <b>VK_EXT_global_priority</b>] </summary>
        StructureTypeDeviceQueueGlobalPriorityCreateInfoExt = 1000174000,
        /// <summary>[requires: <b>VK_KHR_global_priority</b>] </summary>
        StructureTypeDeviceQueueGlobalPriorityCreateInfoKhr = 1000174000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeDeviceQueueInfo2 = 1000145003,
        /// <summary>[requires: <b>VK_ARM_scheduling_controls</b>] </summary>
        StructureTypeDeviceQueueShaderCoreControlCreateInfoArm = 1000417000,
        /// <summary>[requires: <b>VK_LUNARG_direct_driver_loading</b>] </summary>
        StructureTypeDirectDriverLoadingInfoLunarg = 1000459000,
        /// <summary>[requires: <b>VK_LUNARG_direct_driver_loading</b>] </summary>
        StructureTypeDirectDriverLoadingListLunarg = 1000459001,
        /// <summary>[requires: <b>VK_EXT_directfb_surface</b>] </summary>
        StructureTypeDirectfbSurfaceCreateInfoExt = 1000346000,
        /// <summary>[requires: <b>VK_QCOM_tile_shading</b>] </summary>
        StructureTypeDispatchTileInfoQcom = 1000309005,
        /// <summary>[requires: <b>VK_EXT_display_control</b>] </summary>
        StructureTypeDisplayEventInfoExt = 1000091002,
        /// <summary>[requires: <b>VK_KHR_display</b>] </summary>
        StructureTypeDisplayModeCreateInfoKhr = 1000002000,
        /// <summary>[requires: <b>VK_KHR_get_display_properties2</b>] </summary>
        StructureTypeDisplayModeProperties2Khr = 1000121002,
        /// <summary>[requires: <b>VK_NV_display_stereo</b>] </summary>
        StructureTypeDisplayModeStereoPropertiesNv = 1000551001,
        /// <summary>[requires: <b>VK_AMD_display_native_hdr</b>] </summary>
        StructureTypeDisplayNativeHdrSurfaceCapabilitiesAmd = 1000213000,
        /// <summary>[requires: <b>VK_KHR_get_display_properties2</b>] </summary>
        StructureTypeDisplayPlaneCapabilities2Khr = 1000121004,
        /// <summary>[requires: <b>VK_KHR_get_display_properties2</b>] </summary>
        StructureTypeDisplayPlaneInfo2Khr = 1000121003,
        /// <summary>[requires: <b>VK_KHR_get_display_properties2</b>] </summary>
        StructureTypeDisplayPlaneProperties2Khr = 1000121001,
        /// <summary>[requires: <b>VK_EXT_display_control</b>] </summary>
        StructureTypeDisplayPowerInfoExt = 1000091000,
        /// <summary>[requires: <b>VK_KHR_display_swapchain</b>] </summary>
        StructureTypeDisplayPresentInfoKhr = 1000003000,
        /// <summary>[requires: <b>VK_KHR_get_display_properties2</b>] </summary>
        StructureTypeDisplayProperties2Khr = 1000121000,
        /// <summary>[requires: <b>VK_KHR_display</b>] </summary>
        StructureTypeDisplaySurfaceCreateInfoKhr = 1000002001,
        /// <summary>[requires: <b>VK_NV_display_stereo</b>] </summary>
        StructureTypeDisplaySurfaceStereoCreateInfoNv = 1000551000,
        /// <summary>[requires: <b>VK_EXT_image_drm_format_modifier</b>] </summary>
        StructureTypeDrmFormatModifierPropertiesList2Ext = 1000158006,
        /// <summary>[requires: <b>VK_EXT_image_drm_format_modifier</b>] </summary>
        StructureTypeDrmFormatModifierPropertiesListExt = 1000158000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeEventCreateInfo = 10,
        /// <summary>[requires: <b>VK_AMDX_shader_enqueue</b>] </summary>
        StructureTypeExecutionGraphPipelineCreateInfoAmdx = 1000134003,
        /// <summary>[requires: <b>VK_AMDX_shader_enqueue</b>] </summary>
        StructureTypeExecutionGraphPipelineScratchSizeAmdx = 1000134002,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeExportFenceCreateInfo = 1000113000,
        /// <summary>[requires: <b>VK_KHR_external_fence</b>] </summary>
        StructureTypeExportFenceCreateInfoKhr = 1000113000,
        /// <summary>[requires: <b>VK_NV_external_sci_sync | VK_NV_external_sci_sync2</b>] </summary>
        StructureTypeExportFenceSciSyncInfoNv = 1000373001,
        /// <summary>[requires: <b>VK_KHR_external_fence_win32</b>] </summary>
        StructureTypeExportFenceWin32HandleInfoKhr = 1000114001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeExportMemoryAllocateInfo = 1000072002,
        /// <summary>[requires: <b>VK_KHR_external_memory</b>] </summary>
        StructureTypeExportMemoryAllocateInfoKhr = 1000072002,
        /// <summary>[requires: <b>VK_NV_external_memory</b>] </summary>
        StructureTypeExportMemoryAllocateInfoNv = 1000056001,
        /// <summary>[requires: <b>VK_NV_external_memory_sci_buf</b>] </summary>
        StructureTypeExportMemorySciBufInfoNv = 1000374001,
        /// <summary>[requires: <b>VK_KHR_external_memory_win32</b>] </summary>
        StructureTypeExportMemoryWin32HandleInfoKhr = 1000073001,
        /// <summary>[requires: <b>VK_NV_external_memory_win32</b>] </summary>
        StructureTypeExportMemoryWin32HandleInfoNv = 1000057001,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        StructureTypeExportMetalBufferInfoExt = 1000311004,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        StructureTypeExportMetalCommandQueueInfoExt = 1000311003,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        StructureTypeExportMetalDeviceInfoExt = 1000311002,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        StructureTypeExportMetalIoSurfaceInfoExt = 1000311008,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        StructureTypeExportMetalObjectCreateInfoExt = 1000311000,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        StructureTypeExportMetalObjectsInfoExt = 1000311001,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        StructureTypeExportMetalSharedEventInfoExt = 1000311010,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        StructureTypeExportMetalTextureInfoExt = 1000311006,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeExportSemaphoreCreateInfo = 1000077000,
        /// <summary>[requires: <b>VK_KHR_external_semaphore</b>] </summary>
        StructureTypeExportSemaphoreCreateInfoKhr = 1000077000,
        /// <summary>[requires: <b>VK_NV_external_sci_sync</b>] </summary>
        StructureTypeExportSemaphoreSciSyncInfoNv = 1000373005,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_win32</b>] </summary>
        StructureTypeExportSemaphoreWin32HandleInfoKhr = 1000078001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeExternalBufferProperties = 1000071003,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        StructureTypeExternalBufferPropertiesKhr = 1000071003,
        /// <summary>[requires: <b>VK_NV_external_compute_queue</b>] </summary>
        StructureTypeExternalComputeQueueCreateInfoNv = 1000556001,
        /// <summary>[requires: <b>VK_NV_external_compute_queue</b>] </summary>
        StructureTypeExternalComputeQueueDataParamsNv = 1000556002,
        /// <summary>[requires: <b>VK_NV_external_compute_queue</b>] </summary>
        StructureTypeExternalComputeQueueDeviceCreateInfoNv = 1000556000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeExternalFenceProperties = 1000112001,
        /// <summary>[requires: <b>VK_KHR_external_fence_capabilities</b>] </summary>
        StructureTypeExternalFencePropertiesKhr = 1000112001,
        /// <summary>[requires: <b>VK_ANDROID_external_memory_android_hardware_buffer</b>] </summary>
        StructureTypeExternalFormatAndroid = 1000129005,
        /// <summary>[requires: <b>VK_QNX_external_memory_screen_buffer</b>] </summary>
        StructureTypeExternalFormatQnx = 1000529003,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeExternalImageFormatProperties = 1000071001,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        StructureTypeExternalImageFormatPropertiesKhr = 1000071001,
        /// <summary>[requires: <b>VK_EXT_external_memory_acquire_unmodified</b>] </summary>
        StructureTypeExternalMemoryAcquireUnmodifiedExt = 1000453000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeExternalMemoryBufferCreateInfo = 1000072000,
        /// <summary>[requires: <b>VK_KHR_external_memory</b>] </summary>
        StructureTypeExternalMemoryBufferCreateInfoKhr = 1000072000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeExternalMemoryImageCreateInfo = 1000072001,
        /// <summary>[requires: <b>VK_KHR_external_memory</b>] </summary>
        StructureTypeExternalMemoryImageCreateInfoKhr = 1000072001,
        /// <summary>[requires: <b>VK_NV_external_memory</b>] </summary>
        StructureTypeExternalMemoryImageCreateInfoNv = 1000056000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeExternalSemaphoreProperties = 1000076001,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_capabilities</b>] </summary>
        StructureTypeExternalSemaphorePropertiesKhr = 1000076001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeFenceCreateInfo = 8,
        /// <summary>[requires: <b>VK_KHR_external_fence_fd</b>] </summary>
        StructureTypeFenceGetFdInfoKhr = 1000115001,
        /// <summary>[requires: <b>VK_NV_external_sci_sync | VK_NV_external_sci_sync2</b>] </summary>
        StructureTypeFenceGetSciSyncInfoNv = 1000373002,
        /// <summary>[requires: <b>VK_KHR_external_fence_win32</b>] </summary>
        StructureTypeFenceGetWin32HandleInfoKhr = 1000114002,
        /// <summary>[requires: <b>VK_EXT_filter_cubic</b>] </summary>
        StructureTypeFilterCubicImageViewImageFormatPropertiesExt = 1000170001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeFormatProperties2 = 1000059002,
        /// <summary>[requires: <b>VK_KHR_get_physical_device_properties2</b>] </summary>
        StructureTypeFormatProperties2Khr = 1000059002,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeFormatProperties3 = 1000360000,
        /// <summary>[requires: <b>VK_KHR_format_feature_flags2</b>] </summary>
        StructureTypeFormatProperties3Khr = 1000360000,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        StructureTypeFragmentShadingRateAttachmentInfoKhr = 1000226000,
        /// <summary>[requires: <b>VK_EXT_frame_boundary</b>] </summary>
        StructureTypeFrameBoundaryExt = 1000375001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeFramebufferAttachmentImageInfo = 1000108002,
        /// <summary>[requires: <b>VK_KHR_imageless_framebuffer</b>] </summary>
        StructureTypeFramebufferAttachmentImageInfoKhr = 1000108002,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeFramebufferAttachmentsCreateInfo = 1000108001,
        /// <summary>[requires: <b>VK_KHR_imageless_framebuffer</b>] </summary>
        StructureTypeFramebufferAttachmentsCreateInfoKhr = 1000108001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeFramebufferCreateInfo = 37,
        /// <summary>[requires: <b>VK_NV_coverage_reduction_mode</b>] </summary>
        StructureTypeFramebufferMixedSamplesCombinationNv = 1000250002,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypeGeneratedCommandsInfoExt = 1000572004,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        StructureTypeGeneratedCommandsInfoNv = 1000277005,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypeGeneratedCommandsMemoryRequirementsInfoExt = 1000572002,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        StructureTypeGeneratedCommandsMemoryRequirementsInfoNv = 1000277006,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypeGeneratedCommandsPipelineInfoExt = 1000572013,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypeGeneratedCommandsShaderInfoExt = 1000572014,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        StructureTypeGeometryAabbNv = 1000165005,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        StructureTypeGeometryNv = 1000165003,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        StructureTypeGeometryTrianglesNv = 1000165004,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        StructureTypeGetLatencyMarkerInfoNv = 1000505003,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeGraphicsPipelineCreateInfo = 28,
        /// <summary>[requires: <b>VK_EXT_graphics_pipeline_library</b>] </summary>
        StructureTypeGraphicsPipelineLibraryCreateInfoExt = 1000320002,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        StructureTypeGraphicsPipelineShaderGroupsCreateInfoNv = 1000277002,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        StructureTypeGraphicsShaderGroupCreateInfoNv = 1000277001,
        /// <summary>[requires: <b>VK_EXT_hdr_metadata</b>] </summary>
        StructureTypeHdrMetadataExt = 1000105000,
        /// <summary>[requires: <b>VK_HUAWEI_hdr_vivid</b>] </summary>
        StructureTypeHdrVividDynamicMetadataHuawei = 1000590001,
        /// <summary>[requires: <b>VK_EXT_headless_surface</b>] </summary>
        StructureTypeHeadlessSurfaceCreateInfoExt = 1000256000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeHostImageCopyDevicePerformanceQuery = 1000270009,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] </summary>
        StructureTypeHostImageCopyDevicePerformanceQueryExt = 1000270009,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeHostImageLayoutTransitionInfo = 1000270006,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] </summary>
        StructureTypeHostImageLayoutTransitionInfoExt = 1000270006,
        /// <summary>[requires: <b>VK_MESA_image_alignment_control</b>] </summary>
        StructureTypeImageAlignmentControlCreateInfoMesa = 1000575002,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeImageBlit2 = 1000337008,
        /// <summary>[requires: <b>VK_KHR_copy_commands2</b>] </summary>
        StructureTypeImageBlit2Khr = 1000337008,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypeImageCaptureDescriptorDataInfoExt = 1000316006,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        StructureTypeImageCompressionControlExt = 1000338001,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        StructureTypeImageCompressionPropertiesExt = 1000338004,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        StructureTypeImageConstraintsInfoFuchsia = 1000366006,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeImageCopy2 = 1000337007,
        /// <summary>[requires: <b>VK_KHR_copy_commands2</b>] </summary>
        StructureTypeImageCopy2Khr = 1000337007,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeImageCreateInfo = 14,
        /// <summary>[requires: <b>VK_EXT_image_drm_format_modifier</b>] </summary>
        StructureTypeImageDrmFormatModifierExplicitCreateInfoExt = 1000158004,
        /// <summary>[requires: <b>VK_EXT_image_drm_format_modifier</b>] </summary>
        StructureTypeImageDrmFormatModifierListCreateInfoExt = 1000158003,
        /// <summary>[requires: <b>VK_EXT_image_drm_format_modifier</b>] </summary>
        StructureTypeImageDrmFormatModifierPropertiesExt = 1000158005,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        StructureTypeImageFormatConstraintsInfoFuchsia = 1000366007,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeImageFormatListCreateInfo = 1000147000,
        /// <summary>[requires: <b>VK_KHR_image_format_list</b>] </summary>
        StructureTypeImageFormatListCreateInfoKhr = 1000147000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeImageFormatProperties2 = 1000059003,
        /// <summary>[requires: <b>VK_KHR_get_physical_device_properties2</b>] </summary>
        StructureTypeImageFormatProperties2Khr = 1000059003,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeImageMemoryBarrier = 45,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeImageMemoryBarrier2 = 1000314002,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        StructureTypeImageMemoryBarrier2Khr = 1000314002,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeImageMemoryRequirementsInfo2 = 1000146001,
        /// <summary>[requires: <b>VK_KHR_get_memory_requirements2</b>] </summary>
        StructureTypeImageMemoryRequirementsInfo2Khr = 1000146001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeImagePlaneMemoryRequirementsInfo = 1000156003,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        StructureTypeImagePlaneMemoryRequirementsInfoKhr = 1000156003,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeImageResolve2 = 1000337010,
        /// <summary>[requires: <b>VK_KHR_copy_commands2</b>] </summary>
        StructureTypeImageResolve2Khr = 1000337010,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeImageSparseMemoryRequirementsInfo2 = 1000146002,
        /// <summary>[requires: <b>VK_KHR_get_memory_requirements2</b>] </summary>
        StructureTypeImageSparseMemoryRequirementsInfo2Khr = 1000146002,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeImageStencilUsageCreateInfo = 1000246000,
        /// <summary>[requires: <b>VK_EXT_separate_stencil_usage</b>] </summary>
        StructureTypeImageStencilUsageCreateInfoExt = 1000246000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeImageSubresource2 = 1000338003,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        StructureTypeImageSubresource2Ext = 1000338003,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        StructureTypeImageSubresource2Khr = 1000338003,
        /// <summary>[requires: <b>VK_KHR_swapchain | VK_KHR_device_group</b>] </summary>
        StructureTypeImageSwapchainCreateInfoKhr = 1000060008,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeImageToMemoryCopy = 1000270003,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] </summary>
        StructureTypeImageToMemoryCopyExt = 1000270003,
        /// <summary>[requires: <b>VK_NVX_image_view_handle</b>] </summary>
        StructureTypeImageViewAddressPropertiesNvx = 1000030001,
        /// <summary>[requires: <b>VK_EXT_astc_decode_mode</b>] </summary>
        StructureTypeImageViewAstcDecodeModeExt = 1000067000,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypeImageViewCaptureDescriptorDataInfoExt = 1000316007,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeImageViewCreateInfo = 15,
        /// <summary>[requires: <b>VK_NVX_image_view_handle</b>] </summary>
        StructureTypeImageViewHandleInfoNvx = 1000030000,
        /// <summary>[requires: <b>VK_EXT_image_view_min_lod</b>] </summary>
        StructureTypeImageViewMinLodCreateInfoExt = 1000391001,
        /// <summary>[requires: <b>VK_QCOM_image_processing</b>] </summary>
        StructureTypeImageViewSampleWeightCreateInfoQcom = 1000440002,
        /// <summary>[requires: <b>VK_EXT_image_sliced_view_of_3d</b>] </summary>
        StructureTypeImageViewSlicedCreateInfoExt = 1000418001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeImageViewUsageCreateInfo = 1000117002,
        /// <summary>[requires: <b>VK_KHR_maintenance2</b>] </summary>
        StructureTypeImageViewUsageCreateInfoKhr = 1000117002,
        /// <summary>[requires: <b>VK_FUCHSIA_imagepipe_surface</b>] </summary>
        StructureTypeImagepipeSurfaceCreateInfoFuchsia = 1000214000,
        /// <summary>[requires: <b>VK_ANDROID_external_memory_android_hardware_buffer</b>] </summary>
        StructureTypeImportAndroidHardwareBufferInfoAndroid = 1000129003,
        /// <summary>[requires: <b>VK_KHR_external_fence_fd</b>] </summary>
        StructureTypeImportFenceFdInfoKhr = 1000115000,
        /// <summary>[requires: <b>VK_NV_external_sci_sync | VK_NV_external_sci_sync2</b>] </summary>
        StructureTypeImportFenceSciSyncInfoNv = 1000373000,
        /// <summary>[requires: <b>VK_KHR_external_fence_win32</b>] </summary>
        StructureTypeImportFenceWin32HandleInfoKhr = 1000114000,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        StructureTypeImportMemoryBufferCollectionFuchsia = 1000366001,
        /// <summary>[requires: <b>VK_KHR_external_memory_fd</b>] </summary>
        StructureTypeImportMemoryFdInfoKhr = 1000074000,
        /// <summary>[requires: <b>VK_EXT_external_memory_host</b>] </summary>
        StructureTypeImportMemoryHostPointerInfoExt = 1000178000,
        /// <summary>[requires: <b>VK_EXT_external_memory_metal</b>] </summary>
        StructureTypeImportMemoryMetalHandleInfoExt = 1000602000,
        /// <summary>[requires: <b>VK_NV_external_memory_sci_buf</b>] </summary>
        StructureTypeImportMemorySciBufInfoNv = 1000374000,
        /// <summary>[requires: <b>VK_KHR_external_memory_win32</b>] </summary>
        StructureTypeImportMemoryWin32HandleInfoKhr = 1000073000,
        /// <summary>[requires: <b>VK_NV_external_memory_win32</b>] </summary>
        StructureTypeImportMemoryWin32HandleInfoNv = 1000057000,
        /// <summary>[requires: <b>VK_FUCHSIA_external_memory</b>] </summary>
        StructureTypeImportMemoryZirconHandleInfoFuchsia = 1000364000,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        StructureTypeImportMetalBufferInfoExt = 1000311005,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        StructureTypeImportMetalIoSurfaceInfoExt = 1000311009,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        StructureTypeImportMetalSharedEventInfoExt = 1000311011,
        /// <summary>[requires: <b>VK_EXT_metal_objects</b>] </summary>
        StructureTypeImportMetalTextureInfoExt = 1000311007,
        /// <summary>[requires: <b>VK_QNX_external_memory_screen_buffer</b>] </summary>
        StructureTypeImportScreenBufferInfoQnx = 1000529002,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_fd</b>] </summary>
        StructureTypeImportSemaphoreFdInfoKhr = 1000079000,
        /// <summary>[requires: <b>VK_NV_external_sci_sync</b>] </summary>
        StructureTypeImportSemaphoreSciSyncInfoNv = 1000373004,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_win32</b>] </summary>
        StructureTypeImportSemaphoreWin32HandleInfoKhr = 1000078000,
        /// <summary>[requires: <b>VK_FUCHSIA_external_semaphore</b>] </summary>
        StructureTypeImportSemaphoreZirconHandleInfoFuchsia = 1000365000,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypeIndirectCommandsLayoutCreateInfoExt = 1000572006,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        StructureTypeIndirectCommandsLayoutCreateInfoNv = 1000277004,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypeIndirectCommandsLayoutTokenExt = 1000572007,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        StructureTypeIndirectCommandsLayoutTokenNv = 1000277003,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypeIndirectExecutionSetCreateInfoExt = 1000572003,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypeIndirectExecutionSetPipelineInfoExt = 1000572010,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypeIndirectExecutionSetShaderInfoExt = 1000572011,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypeIndirectExecutionSetShaderLayoutInfoExt = 1000572012,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        StructureTypeInitializePerformanceApiInfoIntel = 1000210001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeInstanceCreateInfo = 1,
        /// <summary>[requires: <b>VK_MVK_ios_surface</b>] </summary>
        StructureTypeIosSurfaceCreateInfoMvk = 1000122000,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        StructureTypeLatencySleepInfoNv = 1000505001,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        StructureTypeLatencySleepModeInfoNv = 1000505000,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        StructureTypeLatencySubmissionPresentIdNv = 1000505005,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        StructureTypeLatencySurfaceCapabilitiesNv = 1000505008,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        StructureTypeLatencyTimingsFrameReportNv = 1000505004,
        /// <summary>[requires: <b>VK_EXT_layer_settings</b>] </summary>
        StructureTypeLayerSettingsCreateInfoExt = 1000496000,
        /// <summary>[requires: <b>v1.0</b>] Reserved for internal use by the loader, layers, and ICDs</summary>
        StructureTypeLoaderDeviceCreateInfo = 48,
        /// <summary>[requires: <b>v1.0</b>] Reserved for internal use by the loader, layers, and ICDs</summary>
        StructureTypeLoaderInstanceCreateInfo = 47,
        /// <summary>[requires: <b>VK_MVK_macos_surface</b>] </summary>
        StructureTypeMacosSurfaceCreateInfoMvk = 1000123000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeMappedMemoryRange = 6,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeMemoryAllocateFlagsInfo = 1000060000,
        /// <summary>[requires: <b>VK_KHR_device_group</b>] </summary>
        StructureTypeMemoryAllocateFlagsInfoKhr = 1000060000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeMemoryAllocateInfo = 5,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeMemoryBarrier = 46,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeMemoryBarrier2 = 1000314000,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        StructureTypeMemoryBarrier2Khr = 1000314000,
        /// <summary>[requires: <b>VK_KHR_maintenance8</b>] </summary>
        StructureTypeMemoryBarrierAccessFlags3Khr = 1000574002,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeMemoryDedicatedAllocateInfo = 1000127001,
        /// <summary>[requires: <b>VK_KHR_dedicated_allocation</b>] </summary>
        StructureTypeMemoryDedicatedAllocateInfoKhr = 1000127001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeMemoryDedicatedRequirements = 1000127000,
        /// <summary>[requires: <b>VK_KHR_dedicated_allocation</b>] </summary>
        StructureTypeMemoryDedicatedRequirementsKhr = 1000127000,
        /// <summary>[requires: <b>VK_KHR_external_memory_fd</b>] </summary>
        StructureTypeMemoryFdPropertiesKhr = 1000074001,
        /// <summary>[requires: <b>VK_ANDROID_external_memory_android_hardware_buffer</b>] </summary>
        StructureTypeMemoryGetAndroidHardwareBufferInfoAndroid = 1000129004,
        /// <summary>[requires: <b>VK_KHR_external_memory_fd</b>] </summary>
        StructureTypeMemoryGetFdInfoKhr = 1000074002,
        /// <summary>[requires: <b>VK_EXT_external_memory_metal</b>] </summary>
        StructureTypeMemoryGetMetalHandleInfoExt = 1000602002,
        /// <summary>[requires: <b>VK_NV_external_memory_rdma</b>] </summary>
        StructureTypeMemoryGetRemoteAddressInfoNv = 1000371000,
        /// <summary>[requires: <b>VK_NV_external_memory_sci_buf</b>] </summary>
        StructureTypeMemoryGetSciBufInfoNv = 1000374002,
        /// <summary>[requires: <b>VK_KHR_external_memory_win32</b>] </summary>
        StructureTypeMemoryGetWin32HandleInfoKhr = 1000073003,
        /// <summary>[requires: <b>VK_FUCHSIA_external_memory</b>] </summary>
        StructureTypeMemoryGetZirconHandleInfoFuchsia = 1000364002,
        /// <summary>[requires: <b>VK_EXT_external_memory_host</b>] </summary>
        StructureTypeMemoryHostPointerPropertiesExt = 1000178001,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeMemoryMapInfo = 1000271000,
        /// <summary>[requires: <b>VK_KHR_map_memory2</b>] </summary>
        StructureTypeMemoryMapInfoKhr = 1000271000,
        /// <summary>[requires: <b>VK_EXT_map_memory_placed</b>] </summary>
        StructureTypeMemoryMapPlacedInfoExt = 1000272002,
        /// <summary>[requires: <b>VK_EXT_external_memory_metal</b>] </summary>
        StructureTypeMemoryMetalHandlePropertiesExt = 1000602001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeMemoryOpaqueCaptureAddressAllocateInfo = 1000257003,
        /// <summary>[requires: <b>VK_KHR_buffer_device_address</b>] </summary>
        StructureTypeMemoryOpaqueCaptureAddressAllocateInfoKhr = 1000257003,
        /// <summary>[requires: <b>VK_EXT_memory_priority</b>] </summary>
        StructureTypeMemoryPriorityAllocateInfoExt = 1000238001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeMemoryRequirements2 = 1000146003,
        /// <summary>[requires: <b>VK_KHR_get_memory_requirements2</b>] </summary>
        StructureTypeMemoryRequirements2Khr = 1000146003,
        /// <summary>[requires: <b>VK_NV_external_memory_sci_buf</b>] </summary>
        StructureTypeMemorySciBufPropertiesNv = 1000374003,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeMemoryToImageCopy = 1000270002,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] </summary>
        StructureTypeMemoryToImageCopyExt = 1000270002,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeMemoryUnmapInfo = 1000271001,
        /// <summary>[requires: <b>VK_KHR_map_memory2</b>] </summary>
        StructureTypeMemoryUnmapInfoKhr = 1000271001,
        /// <summary>[requires: <b>VK_KHR_external_memory_win32</b>] </summary>
        StructureTypeMemoryWin32HandlePropertiesKhr = 1000073002,
        /// <summary>[requires: <b>VK_FUCHSIA_external_memory</b>] </summary>
        StructureTypeMemoryZirconHandlePropertiesFuchsia = 1000364001,
        /// <summary>[requires: <b>VK_EXT_metal_surface</b>] </summary>
        StructureTypeMetalSurfaceCreateInfoExt = 1000217000,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        StructureTypeMicromapBuildInfoExt = 1000396000,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        StructureTypeMicromapBuildSizesInfoExt = 1000396008,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        StructureTypeMicromapCreateInfoExt = 1000396007,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        StructureTypeMicromapVersionInfoExt = 1000396001,
        /// <summary>[requires: <b>VK_EXT_sample_locations</b>] </summary>
        StructureTypeMultisamplePropertiesExt = 1000143004,
        /// <summary>[requires: <b>VK_EXT_multisampled_render_to_single_sampled</b>] </summary>
        StructureTypeMultisampledRenderToSingleSampledInfoExt = 1000376002,
        /// <summary>[requires: <b>VK_NVX_multiview_per_view_attributes</b>] </summary>
        StructureTypeMultiviewPerViewAttributesInfoNvx = 1000044009,
        /// <summary>[requires: <b>VK_QCOM_multiview_per_view_render_areas</b>] </summary>
        StructureTypeMultiviewPerViewRenderAreasRenderPassBeginInfoQcom = 1000510001,
        /// <summary>[requires: <b>VK_EXT_mutable_descriptor_type</b>] </summary>
        StructureTypeMutableDescriptorTypeCreateInfoExt = 1000351002,
        /// <summary>[requires: <b>VK_VALVE_mutable_descriptor_type</b>] </summary>
        StructureTypeMutableDescriptorTypeCreateInfoValve = 1000351002,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypeOpaqueCaptureDescriptorDataCreateInfoExt = 1000316010,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        StructureTypeOpticalFlowExecuteInfoNv = 1000464005,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        StructureTypeOpticalFlowImageFormatInfoNv = 1000464002,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        StructureTypeOpticalFlowImageFormatPropertiesNv = 1000464003,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        StructureTypeOpticalFlowSessionCreateInfoNv = 1000464004,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        StructureTypeOpticalFlowSessionCreatePrivateDataInfoNv = 1000464010,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        StructureTypeOutOfBandQueueTypeInfoNv = 1000505006,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        StructureTypePartitionedAccelerationStructureFlagsNv = 1000570005,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        StructureTypePartitionedAccelerationStructureInstancesInputNv = 1000570003,
        /// <summary>[requires: <b>VK_QCOM_tile_shading</b>] </summary>
        StructureTypePerTileBeginInfoQcom = 1000309003,
        /// <summary>[requires: <b>VK_QCOM_tile_shading</b>] </summary>
        StructureTypePerTileEndInfoQcom = 1000309004,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        StructureTypePerformanceConfigurationAcquireInfoIntel = 1000210005,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        StructureTypePerformanceCounterDescriptionKhr = 1000116006,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        StructureTypePerformanceCounterKhr = 1000116005,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        StructureTypePerformanceMarkerInfoIntel = 1000210002,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        StructureTypePerformanceOverrideInfoIntel = 1000210004,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        StructureTypePerformanceQuerySubmitInfoKhr = 1000116003,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        StructureTypePerformanceStreamMarkerInfoIntel = 1000210003,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDevice16bitStorageFeatures = 1000083000,
        /// <summary>[requires: <b>VK_KHR_16bit_storage</b>] </summary>
        StructureTypePhysicalDevice16bitStorageFeaturesKhr = 1000083000,
        /// <summary>[requires: <b>VK_EXT_4444_formats</b>] </summary>
        StructureTypePhysicalDevice4444FormatsFeaturesExt = 1000340000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDevice8bitStorageFeatures = 1000177000,
        /// <summary>[requires: <b>VK_KHR_8bit_storage</b>] </summary>
        StructureTypePhysicalDevice8bitStorageFeaturesKhr = 1000177000,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypePhysicalDeviceAccelerationStructureFeaturesKhr = 1000150013,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypePhysicalDeviceAccelerationStructurePropertiesKhr = 1000150014,
        /// <summary>[requires: <b>VK_EXT_device_address_binding_report</b>] </summary>
        StructureTypePhysicalDeviceAddressBindingReportFeaturesExt = 1000354000,
        /// <summary>[requires: <b>VK_SEC_amigo_profiling</b>] </summary>
        StructureTypePhysicalDeviceAmigoProfilingFeaturesSec = 1000485000,
        /// <summary>[requires: <b>VK_AMD_anti_lag</b>] </summary>
        StructureTypePhysicalDeviceAntiLagFeaturesAmd = 1000476000,
        /// <summary>[requires: <b>VK_EXT_astc_decode_mode</b>] </summary>
        StructureTypePhysicalDeviceAstcDecodeFeaturesExt = 1000067001,
        /// <summary>[requires: <b>VK_EXT_attachment_feedback_loop_dynamic_state</b>] </summary>
        StructureTypePhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesExt = 1000524000,
        /// <summary>[requires: <b>VK_EXT_attachment_feedback_loop_layout</b>] </summary>
        StructureTypePhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesExt = 1000339000,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        StructureTypePhysicalDeviceBlendOperationAdvancedFeaturesExt = 1000148000,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        StructureTypePhysicalDeviceBlendOperationAdvancedPropertiesExt = 1000148001,
        /// <summary>[requires: <b>VK_EXT_border_color_swizzle</b>] </summary>
        StructureTypePhysicalDeviceBorderColorSwizzleFeaturesExt = 1000411000,
        /// <summary>[requires: <b>VK_EXT_buffer_device_address</b>] </summary>
        StructureTypePhysicalDeviceBufferAddressFeaturesExt = 1000244000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceBufferDeviceAddressFeatures = 1000257000,
        /// <summary>[requires: <b>VK_EXT_buffer_device_address</b>] </summary>
        StructureTypePhysicalDeviceBufferDeviceAddressFeaturesExt = 1000244000,
        /// <summary>[requires: <b>VK_KHR_buffer_device_address</b>] </summary>
        StructureTypePhysicalDeviceBufferDeviceAddressFeaturesKhr = 1000257000,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        StructureTypePhysicalDeviceClusterAccelerationStructureFeaturesNv = 1000569000,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        StructureTypePhysicalDeviceClusterAccelerationStructurePropertiesNv = 1000569001,
        /// <summary>[requires: <b>VK_HUAWEI_cluster_culling_shader</b>] </summary>
        StructureTypePhysicalDeviceClusterCullingShaderFeaturesHuawei = 1000404000,
        /// <summary>[requires: <b>VK_HUAWEI_cluster_culling_shader</b>] </summary>
        StructureTypePhysicalDeviceClusterCullingShaderPropertiesHuawei = 1000404001,
        /// <summary>[requires: <b>VK_HUAWEI_cluster_culling_shader</b>] </summary>
        StructureTypePhysicalDeviceClusterCullingShaderVrsFeaturesHuawei = 1000404002,
        /// <summary>[requires: <b>VK_AMD_device_coherent_memory</b>] </summary>
        StructureTypePhysicalDeviceCoherentMemoryFeaturesAmd = 1000229000,
        /// <summary>[requires: <b>VK_EXT_color_write_enable</b>] </summary>
        StructureTypePhysicalDeviceColorWriteEnableFeaturesExt = 1000381000,
        /// <summary>[requires: <b>VK_NV_command_buffer_inheritance</b>] </summary>
        StructureTypePhysicalDeviceCommandBufferInheritanceFeaturesNv = 1000559000,
        /// <summary>[requires: <b>VK_KHR_compute_shader_derivatives</b>] </summary>
        StructureTypePhysicalDeviceComputeShaderDerivativesFeaturesKhr = 1000201000,
        /// <summary>[requires: <b>VK_NV_compute_shader_derivatives</b>] </summary>
        StructureTypePhysicalDeviceComputeShaderDerivativesFeaturesNv = 1000201000,
        /// <summary>[requires: <b>VK_KHR_compute_shader_derivatives</b>] </summary>
        StructureTypePhysicalDeviceComputeShaderDerivativesPropertiesKhr = 1000511000,
        /// <summary>[requires: <b>VK_EXT_conditional_rendering</b>] </summary>
        StructureTypePhysicalDeviceConditionalRenderingFeaturesExt = 1000081001,
        /// <summary>[requires: <b>VK_EXT_conservative_rasterization</b>] </summary>
        StructureTypePhysicalDeviceConservativeRasterizationPropertiesExt = 1000101000,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix2</b>] </summary>
        StructureTypePhysicalDeviceCooperativeMatrix2FeaturesNv = 1000593000,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix2</b>] </summary>
        StructureTypePhysicalDeviceCooperativeMatrix2PropertiesNv = 1000593002,
        /// <summary>[requires: <b>VK_KHR_cooperative_matrix</b>] </summary>
        StructureTypePhysicalDeviceCooperativeMatrixFeaturesKhr = 1000506000,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        StructureTypePhysicalDeviceCooperativeMatrixFeaturesNv = 1000249000,
        /// <summary>[requires: <b>VK_KHR_cooperative_matrix</b>] </summary>
        StructureTypePhysicalDeviceCooperativeMatrixPropertiesKhr = 1000506002,
        /// <summary>[requires: <b>VK_NV_cooperative_matrix</b>] </summary>
        StructureTypePhysicalDeviceCooperativeMatrixPropertiesNv = 1000249002,
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        StructureTypePhysicalDeviceCooperativeVectorFeaturesNv = 1000491000,
        /// <summary>[requires: <b>VK_NV_cooperative_vector</b>] </summary>
        StructureTypePhysicalDeviceCooperativeVectorPropertiesNv = 1000491001,
        /// <summary>[requires: <b>VK_NV_copy_memory_indirect</b>] </summary>
        StructureTypePhysicalDeviceCopyMemoryIndirectFeaturesNv = 1000426000,
        /// <summary>[requires: <b>VK_NV_copy_memory_indirect</b>] </summary>
        StructureTypePhysicalDeviceCopyMemoryIndirectPropertiesNv = 1000426001,
        /// <summary>[requires: <b>VK_NV_corner_sampled_image</b>] </summary>
        StructureTypePhysicalDeviceCornerSampledImageFeaturesNv = 1000050000,
        /// <summary>[requires: <b>VK_NV_coverage_reduction_mode</b>] </summary>
        StructureTypePhysicalDeviceCoverageReductionModeFeaturesNv = 1000250000,
        /// <summary>[requires: <b>VK_QCOM_filter_cubic_clamp</b>] </summary>
        StructureTypePhysicalDeviceCubicClampFeaturesQcom = 1000521000,
        /// <summary>[requires: <b>VK_QCOM_filter_cubic_weights</b>] </summary>
        StructureTypePhysicalDeviceCubicWeightsFeaturesQcom = 1000519001,
        /// <summary>[requires: <b>VK_NV_cuda_kernel_launch</b>] </summary>
        StructureTypePhysicalDeviceCudaKernelLaunchFeaturesNv = 1000307003,
        /// <summary>[requires: <b>VK_NV_cuda_kernel_launch</b>] </summary>
        StructureTypePhysicalDeviceCudaKernelLaunchPropertiesNv = 1000307004,
        /// <summary>[requires: <b>VK_EXT_custom_border_color</b>] </summary>
        StructureTypePhysicalDeviceCustomBorderColorFeaturesExt = 1000287002,
        /// <summary>[requires: <b>VK_EXT_custom_border_color</b>] </summary>
        StructureTypePhysicalDeviceCustomBorderColorPropertiesExt = 1000287001,
        /// <summary>[requires: <b>VK_NV_dedicated_allocation_image_aliasing</b>] </summary>
        StructureTypePhysicalDeviceDedicatedAllocationImageAliasingFeaturesNv = 1000240000,
        /// <summary>[requires: <b>VK_EXT_depth_bias_control</b>] </summary>
        StructureTypePhysicalDeviceDepthBiasControlFeaturesExt = 1000283000,
        /// <summary>[requires: <b>VK_EXT_depth_clamp_control</b>] </summary>
        StructureTypePhysicalDeviceDepthClampControlFeaturesExt = 1000582000,
        /// <summary>[requires: <b>VK_EXT_depth_clamp_zero_one</b>] </summary>
        StructureTypePhysicalDeviceDepthClampZeroOneFeaturesExt = 1000421000,
        /// <summary>[requires: <b>VK_KHR_depth_clamp_zero_one</b>] </summary>
        StructureTypePhysicalDeviceDepthClampZeroOneFeaturesKhr = 1000421000,
        /// <summary>[requires: <b>VK_EXT_depth_clip_control</b>] </summary>
        StructureTypePhysicalDeviceDepthClipControlFeaturesExt = 1000355000,
        /// <summary>[requires: <b>VK_EXT_depth_clip_enable</b>] </summary>
        StructureTypePhysicalDeviceDepthClipEnableFeaturesExt = 1000102000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceDepthStencilResolveProperties = 1000199000,
        /// <summary>[requires: <b>VK_KHR_depth_stencil_resolve</b>] </summary>
        StructureTypePhysicalDeviceDepthStencilResolvePropertiesKhr = 1000199000,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypePhysicalDeviceDescriptorBufferDensityMapPropertiesExt = 1000316001,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypePhysicalDeviceDescriptorBufferFeaturesExt = 1000316002,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypePhysicalDeviceDescriptorBufferPropertiesExt = 1000316000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceDescriptorIndexingFeatures = 1000161001,
        /// <summary>[requires: <b>VK_EXT_descriptor_indexing</b>] </summary>
        StructureTypePhysicalDeviceDescriptorIndexingFeaturesExt = 1000161001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceDescriptorIndexingProperties = 1000161002,
        /// <summary>[requires: <b>VK_EXT_descriptor_indexing</b>] </summary>
        StructureTypePhysicalDeviceDescriptorIndexingPropertiesExt = 1000161002,
        /// <summary>[requires: <b>VK_NV_descriptor_pool_overallocation</b>] </summary>
        StructureTypePhysicalDeviceDescriptorPoolOverallocationFeaturesNv = 1000546000,
        /// <summary>[requires: <b>VK_VALVE_descriptor_set_host_mapping</b>] </summary>
        StructureTypePhysicalDeviceDescriptorSetHostMappingFeaturesValve = 1000420000,
        /// <summary>[requires: <b>VK_NV_device_generated_commands_compute</b>] </summary>
        StructureTypePhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNv = 1000428000,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypePhysicalDeviceDeviceGeneratedCommandsFeaturesExt = 1000572000,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        StructureTypePhysicalDeviceDeviceGeneratedCommandsFeaturesNv = 1000277007,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypePhysicalDeviceDeviceGeneratedCommandsPropertiesExt = 1000572001,
        /// <summary>[requires: <b>VK_NV_device_generated_commands</b>] </summary>
        StructureTypePhysicalDeviceDeviceGeneratedCommandsPropertiesNv = 1000277000,
        /// <summary>[requires: <b>VK_EXT_device_memory_report</b>] </summary>
        StructureTypePhysicalDeviceDeviceMemoryReportFeaturesExt = 1000284000,
        /// <summary>[requires: <b>VK_NV_device_diagnostics_config</b>] </summary>
        StructureTypePhysicalDeviceDiagnosticsConfigFeaturesNv = 1000300000,
        /// <summary>[requires: <b>VK_EXT_discard_rectangles</b>] </summary>
        StructureTypePhysicalDeviceDiscardRectanglePropertiesExt = 1000099000,
        /// <summary>[requires: <b>VK_NV_displacement_micromap</b>] </summary>
        StructureTypePhysicalDeviceDisplacementMicromapFeaturesNv = 1000397000,
        /// <summary>[requires: <b>VK_NV_displacement_micromap</b>] </summary>
        StructureTypePhysicalDeviceDisplacementMicromapPropertiesNv = 1000397001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceDriverProperties = 1000196000,
        /// <summary>[requires: <b>VK_KHR_driver_properties</b>] </summary>
        StructureTypePhysicalDeviceDriverPropertiesKhr = 1000196000,
        /// <summary>[requires: <b>VK_EXT_physical_device_drm</b>] </summary>
        StructureTypePhysicalDeviceDrmPropertiesExt = 1000353000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceDynamicRenderingFeatures = 1000044003,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering</b>] </summary>
        StructureTypePhysicalDeviceDynamicRenderingFeaturesKhr = 1000044003,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceDynamicRenderingLocalReadFeatures = 1000232000,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering_local_read</b>] </summary>
        StructureTypePhysicalDeviceDynamicRenderingLocalReadFeaturesKhr = 1000232000,
        /// <summary>[requires: <b>VK_EXT_dynamic_rendering_unused_attachments</b>] </summary>
        StructureTypePhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesExt = 1000499000,
        /// <summary>[requires: <b>VK_NV_scissor_exclusive</b>] </summary>
        StructureTypePhysicalDeviceExclusiveScissorFeaturesNv = 1000205002,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state2</b>] Not promoted to 1.3</summary>
        StructureTypePhysicalDeviceExtendedDynamicState2FeaturesExt = 1000377000,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        StructureTypePhysicalDeviceExtendedDynamicState3FeaturesExt = 1000455000,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state3</b>] </summary>
        StructureTypePhysicalDeviceExtendedDynamicState3PropertiesExt = 1000455001,
        /// <summary>[requires: <b>VK_EXT_extended_dynamic_state</b>] Not promoted to 1.3</summary>
        StructureTypePhysicalDeviceExtendedDynamicStateFeaturesExt = 1000267000,
        /// <summary>[requires: <b>VK_NV_extended_sparse_address_space</b>] </summary>
        StructureTypePhysicalDeviceExtendedSparseAddressSpaceFeaturesNv = 1000492000,
        /// <summary>[requires: <b>VK_NV_extended_sparse_address_space</b>] </summary>
        StructureTypePhysicalDeviceExtendedSparseAddressSpacePropertiesNv = 1000492001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceExternalBufferInfo = 1000071002,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        StructureTypePhysicalDeviceExternalBufferInfoKhr = 1000071002,
        /// <summary>[requires: <b>VK_NV_external_compute_queue</b>] </summary>
        StructureTypePhysicalDeviceExternalComputeQueuePropertiesNv = 1000556003,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceExternalFenceInfo = 1000112000,
        /// <summary>[requires: <b>VK_KHR_external_fence_capabilities</b>] </summary>
        StructureTypePhysicalDeviceExternalFenceInfoKhr = 1000112000,
        /// <summary>[requires: <b>VK_ANDROID_external_format_resolve</b>] </summary>
        StructureTypePhysicalDeviceExternalFormatResolveFeaturesAndroid = 1000468000,
        /// <summary>[requires: <b>VK_ANDROID_external_format_resolve</b>] </summary>
        StructureTypePhysicalDeviceExternalFormatResolvePropertiesAndroid = 1000468001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceExternalImageFormatInfo = 1000071000,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities</b>] </summary>
        StructureTypePhysicalDeviceExternalImageFormatInfoKhr = 1000071000,
        /// <summary>[requires: <b>VK_EXT_external_memory_host</b>] </summary>
        StructureTypePhysicalDeviceExternalMemoryHostPropertiesExt = 1000178002,
        /// <summary>[requires: <b>VK_NV_external_memory_rdma</b>] </summary>
        StructureTypePhysicalDeviceExternalMemoryRdmaFeaturesNv = 1000371001,
        /// <summary>[requires: <b>VK_NV_external_memory_sci_buf</b>] </summary>
        StructureTypePhysicalDeviceExternalMemorySciBufFeaturesNv = 1000374004,
        /// <summary>[requires: <b>VK_QNX_external_memory_screen_buffer</b>] </summary>
        StructureTypePhysicalDeviceExternalMemoryScreenBufferFeaturesQnx = 1000529004,
        /// <summary>[requires: <b>VK_NV_external_memory_sci_buf</b>] </summary>
        StructureTypePhysicalDeviceExternalSciBufFeaturesNv = 1000374004,
        /// <summary>[requires: <b>VK_NV_external_sci_sync2</b>] </summary>
        StructureTypePhysicalDeviceExternalSciSync2FeaturesNv = 1000489002,
        /// <summary>[requires: <b>VK_NV_external_sci_sync</b>] </summary>
        StructureTypePhysicalDeviceExternalSciSyncFeaturesNv = 1000373007,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceExternalSemaphoreInfo = 1000076000,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_capabilities</b>] </summary>
        StructureTypePhysicalDeviceExternalSemaphoreInfoKhr = 1000076000,
        /// <summary>[requires: <b>VK_EXT_device_fault</b>] </summary>
        StructureTypePhysicalDeviceFaultFeaturesExt = 1000341000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceFeatures2 = 1000059000,
        /// <summary>[requires: <b>VK_KHR_get_physical_device_properties2</b>] </summary>
        StructureTypePhysicalDeviceFeatures2Khr = 1000059000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceFloatControlsProperties = 1000197000,
        /// <summary>[requires: <b>VK_KHR_shader_float_controls</b>] </summary>
        StructureTypePhysicalDeviceFloatControlsPropertiesKhr = 1000197000,
        /// <summary>[requires: <b>VK_KHR_shader_float16_int8</b>] </summary>
        StructureTypePhysicalDeviceFloat16Int8FeaturesKhr = 1000082000,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map2</b>] </summary>
        StructureTypePhysicalDeviceFragmentDensityMap2FeaturesExt = 1000332000,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map2</b>] </summary>
        StructureTypePhysicalDeviceFragmentDensityMap2PropertiesExt = 1000332001,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        StructureTypePhysicalDeviceFragmentDensityMapFeaturesExt = 1000218000,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map_offset</b>] </summary>
        StructureTypePhysicalDeviceFragmentDensityMapOffsetFeaturesExt = 1000425000,
        /// <summary>[requires: <b>VK_QCOM_fragment_density_map_offset</b>] </summary>
        StructureTypePhysicalDeviceFragmentDensityMapOffsetFeaturesQcom = 1000425000,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map_offset</b>] </summary>
        StructureTypePhysicalDeviceFragmentDensityMapOffsetPropertiesExt = 1000425001,
        /// <summary>[requires: <b>VK_QCOM_fragment_density_map_offset</b>] </summary>
        StructureTypePhysicalDeviceFragmentDensityMapOffsetPropertiesQcom = 1000425001,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        StructureTypePhysicalDeviceFragmentDensityMapPropertiesExt = 1000218001,
        /// <summary>[requires: <b>VK_KHR_fragment_shader_barycentric</b>] </summary>
        StructureTypePhysicalDeviceFragmentShaderBarycentricFeaturesKhr = 1000203000,
        /// <summary>[requires: <b>VK_NV_fragment_shader_barycentric</b>] </summary>
        StructureTypePhysicalDeviceFragmentShaderBarycentricFeaturesNv = 1000203000,
        /// <summary>[requires: <b>VK_KHR_fragment_shader_barycentric</b>] </summary>
        StructureTypePhysicalDeviceFragmentShaderBarycentricPropertiesKhr = 1000322000,
        /// <summary>[requires: <b>VK_EXT_fragment_shader_interlock</b>] </summary>
        StructureTypePhysicalDeviceFragmentShaderInterlockFeaturesExt = 1000251000,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        StructureTypePhysicalDeviceFragmentShadingRateEnumsFeaturesNv = 1000326001,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        StructureTypePhysicalDeviceFragmentShadingRateEnumsPropertiesNv = 1000326000,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        StructureTypePhysicalDeviceFragmentShadingRateFeaturesKhr = 1000226003,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        StructureTypePhysicalDeviceFragmentShadingRateKhr = 1000226004,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        StructureTypePhysicalDeviceFragmentShadingRatePropertiesKhr = 1000226002,
        /// <summary>[requires: <b>VK_EXT_frame_boundary</b>] </summary>
        StructureTypePhysicalDeviceFrameBoundaryFeaturesExt = 1000375000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceGlobalPriorityQueryFeatures = 1000388000,
        /// <summary>[requires: <b>VK_EXT_global_priority_query</b>] </summary>
        StructureTypePhysicalDeviceGlobalPriorityQueryFeaturesExt = 1000388000,
        /// <summary>[requires: <b>VK_KHR_global_priority</b>] </summary>
        StructureTypePhysicalDeviceGlobalPriorityQueryFeaturesKhr = 1000388000,
        /// <summary>[requires: <b>VK_EXT_graphics_pipeline_library</b>] </summary>
        StructureTypePhysicalDeviceGraphicsPipelineLibraryFeaturesExt = 1000320000,
        /// <summary>[requires: <b>VK_EXT_graphics_pipeline_library</b>] </summary>
        StructureTypePhysicalDeviceGraphicsPipelineLibraryPropertiesExt = 1000320001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceGroupProperties = 1000070000,
        /// <summary>[requires: <b>VK_KHR_device_group_creation</b>] </summary>
        StructureTypePhysicalDeviceGroupPropertiesKhr = 1000070000,
        /// <summary>[requires: <b>VK_HUAWEI_hdr_vivid</b>] </summary>
        StructureTypePhysicalDeviceHdrVividFeaturesHuawei = 1000590000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceHostImageCopyFeatures = 1000270000,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] </summary>
        StructureTypePhysicalDeviceHostImageCopyFeaturesExt = 1000270000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceHostImageCopyProperties = 1000270001,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] </summary>
        StructureTypePhysicalDeviceHostImageCopyPropertiesExt = 1000270001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceHostQueryResetFeatures = 1000261000,
        /// <summary>[requires: <b>VK_EXT_host_query_reset</b>] </summary>
        StructureTypePhysicalDeviceHostQueryResetFeaturesExt = 1000261000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceIdProperties = 1000071004,
        /// <summary>[requires: <b>VK_KHR_external_memory_capabilities | VK_KHR_external_semaphore_capabilities | VK_KHR_external_fence_capabilities</b>] </summary>
        StructureTypePhysicalDeviceIdPropertiesKhr = 1000071004,
        /// <summary>[requires: <b>VK_EXT_image_2d_view_of_3d</b>] </summary>
        StructureTypePhysicalDeviceImage2dViewOf3dFeaturesExt = 1000393000,
        /// <summary>[requires: <b>VK_MESA_image_alignment_control</b>] </summary>
        StructureTypePhysicalDeviceImageAlignmentControlFeaturesMesa = 1000575000,
        /// <summary>[requires: <b>VK_MESA_image_alignment_control</b>] </summary>
        StructureTypePhysicalDeviceImageAlignmentControlPropertiesMesa = 1000575001,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        StructureTypePhysicalDeviceImageCompressionControlFeaturesExt = 1000338000,
        /// <summary>[requires: <b>VK_EXT_image_compression_control_swapchain</b>] </summary>
        StructureTypePhysicalDeviceImageCompressionControlSwapchainFeaturesExt = 1000437000,
        /// <summary>[requires: <b>VK_EXT_image_drm_format_modifier</b>] </summary>
        StructureTypePhysicalDeviceImageDrmFormatModifierInfoExt = 1000158002,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceImageFormatInfo2 = 1000059004,
        /// <summary>[requires: <b>VK_KHR_get_physical_device_properties2</b>] </summary>
        StructureTypePhysicalDeviceImageFormatInfo2Khr = 1000059004,
        /// <summary>[requires: <b>VK_QCOM_image_processing2</b>] </summary>
        StructureTypePhysicalDeviceImageProcessing2FeaturesQcom = 1000518000,
        /// <summary>[requires: <b>VK_QCOM_image_processing2</b>] </summary>
        StructureTypePhysicalDeviceImageProcessing2PropertiesQcom = 1000518001,
        /// <summary>[requires: <b>VK_QCOM_image_processing</b>] </summary>
        StructureTypePhysicalDeviceImageProcessingFeaturesQcom = 1000440000,
        /// <summary>[requires: <b>VK_QCOM_image_processing</b>] </summary>
        StructureTypePhysicalDeviceImageProcessingPropertiesQcom = 1000440001,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceImageRobustnessFeatures = 1000335000,
        /// <summary>[requires: <b>VK_EXT_image_robustness</b>] </summary>
        StructureTypePhysicalDeviceImageRobustnessFeaturesExt = 1000335000,
        /// <summary>[requires: <b>VK_EXT_image_sliced_view_of_3d</b>] </summary>
        StructureTypePhysicalDeviceImageSlicedViewOf3dFeaturesExt = 1000418000,
        /// <summary>[requires: <b>VK_EXT_filter_cubic</b>] </summary>
        StructureTypePhysicalDeviceImageViewImageFormatInfoExt = 1000170000,
        /// <summary>[requires: <b>VK_EXT_image_view_min_lod</b>] </summary>
        StructureTypePhysicalDeviceImageViewMinLodFeaturesExt = 1000391000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceImagelessFramebufferFeatures = 1000108000,
        /// <summary>[requires: <b>VK_KHR_imageless_framebuffer</b>] </summary>
        StructureTypePhysicalDeviceImagelessFramebufferFeaturesKhr = 1000108000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceIndexTypeUint8Features = 1000265000,
        /// <summary>[requires: <b>VK_EXT_index_type_uint8</b>] </summary>
        StructureTypePhysicalDeviceIndexTypeUint8FeaturesExt = 1000265000,
        /// <summary>[requires: <b>VK_KHR_index_type_uint8</b>] </summary>
        StructureTypePhysicalDeviceIndexTypeUint8FeaturesKhr = 1000265000,
        /// <summary>[requires: <b>VK_NV_inherited_viewport_scissor</b>] </summary>
        StructureTypePhysicalDeviceInheritedViewportScissorFeaturesNv = 1000278000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceInlineUniformBlockFeatures = 1000138000,
        /// <summary>[requires: <b>VK_EXT_inline_uniform_block</b>] </summary>
        StructureTypePhysicalDeviceInlineUniformBlockFeaturesExt = 1000138000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceInlineUniformBlockProperties = 1000138001,
        /// <summary>[requires: <b>VK_EXT_inline_uniform_block</b>] </summary>
        StructureTypePhysicalDeviceInlineUniformBlockPropertiesExt = 1000138001,
        /// <summary>[requires: <b>VK_HUAWEI_invocation_mask</b>] </summary>
        StructureTypePhysicalDeviceInvocationMaskFeaturesHuawei = 1000370000,
        /// <summary>[requires: <b>VK_KHR_maintenance7</b>] </summary>
        StructureTypePhysicalDeviceLayeredApiPropertiesKhr = 1000562003,
        /// <summary>[requires: <b>VK_KHR_maintenance7</b>] </summary>
        StructureTypePhysicalDeviceLayeredApiPropertiesListKhr = 1000562002,
        /// <summary>[requires: <b>VK_KHR_maintenance7</b>] </summary>
        StructureTypePhysicalDeviceLayeredApiVulkanPropertiesKhr = 1000562004,
        /// <summary>[requires: <b>VK_MSFT_layered_driver</b>] </summary>
        StructureTypePhysicalDeviceLayeredDriverPropertiesMsft = 1000530000,
        /// <summary>[requires: <b>VK_EXT_legacy_dithering</b>] </summary>
        StructureTypePhysicalDeviceLegacyDitheringFeaturesExt = 1000465000,
        /// <summary>[requires: <b>VK_EXT_legacy_vertex_attributes</b>] </summary>
        StructureTypePhysicalDeviceLegacyVertexAttributesFeaturesExt = 1000495000,
        /// <summary>[requires: <b>VK_EXT_legacy_vertex_attributes</b>] </summary>
        StructureTypePhysicalDeviceLegacyVertexAttributesPropertiesExt = 1000495001,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceLineRasterizationFeatures = 1000259000,
        /// <summary>[requires: <b>VK_EXT_line_rasterization</b>] </summary>
        StructureTypePhysicalDeviceLineRasterizationFeaturesExt = 1000259000,
        /// <summary>[requires: <b>VK_KHR_line_rasterization</b>] </summary>
        StructureTypePhysicalDeviceLineRasterizationFeaturesKhr = 1000259000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceLineRasterizationProperties = 1000259002,
        /// <summary>[requires: <b>VK_EXT_line_rasterization</b>] </summary>
        StructureTypePhysicalDeviceLineRasterizationPropertiesExt = 1000259002,
        /// <summary>[requires: <b>VK_KHR_line_rasterization</b>] </summary>
        StructureTypePhysicalDeviceLineRasterizationPropertiesKhr = 1000259002,
        /// <summary>[requires: <b>VK_NV_linear_color_attachment</b>] </summary>
        StructureTypePhysicalDeviceLinearColorAttachmentFeaturesNv = 1000430000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceMaintenance3Properties = 1000168000,
        /// <summary>[requires: <b>VK_KHR_maintenance3</b>] </summary>
        StructureTypePhysicalDeviceMaintenance3PropertiesKhr = 1000168000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceMaintenance4Features = 1000413000,
        /// <summary>[requires: <b>VK_KHR_maintenance4</b>] </summary>
        StructureTypePhysicalDeviceMaintenance4FeaturesKhr = 1000413000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceMaintenance4Properties = 1000413001,
        /// <summary>[requires: <b>VK_KHR_maintenance4</b>] </summary>
        StructureTypePhysicalDeviceMaintenance4PropertiesKhr = 1000413001,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceMaintenance5Features = 1000470000,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        StructureTypePhysicalDeviceMaintenance5FeaturesKhr = 1000470000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceMaintenance5Properties = 1000470001,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        StructureTypePhysicalDeviceMaintenance5PropertiesKhr = 1000470001,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceMaintenance6Features = 1000545000,
        /// <summary>[requires: <b>VK_KHR_maintenance6</b>] </summary>
        StructureTypePhysicalDeviceMaintenance6FeaturesKhr = 1000545000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceMaintenance6Properties = 1000545001,
        /// <summary>[requires: <b>VK_KHR_maintenance6</b>] </summary>
        StructureTypePhysicalDeviceMaintenance6PropertiesKhr = 1000545001,
        /// <summary>[requires: <b>VK_KHR_maintenance7</b>] </summary>
        StructureTypePhysicalDeviceMaintenance7FeaturesKhr = 1000562000,
        /// <summary>[requires: <b>VK_KHR_maintenance7</b>] </summary>
        StructureTypePhysicalDeviceMaintenance7PropertiesKhr = 1000562001,
        /// <summary>[requires: <b>VK_KHR_maintenance8</b>] </summary>
        StructureTypePhysicalDeviceMaintenance8FeaturesKhr = 1000574000,
        /// <summary>[requires: <b>VK_EXT_map_memory_placed</b>] </summary>
        StructureTypePhysicalDeviceMapMemoryPlacedFeaturesExt = 1000272000,
        /// <summary>[requires: <b>VK_EXT_map_memory_placed</b>] </summary>
        StructureTypePhysicalDeviceMapMemoryPlacedPropertiesExt = 1000272001,
        /// <summary>[requires: <b>VK_EXT_memory_budget</b>] </summary>
        StructureTypePhysicalDeviceMemoryBudgetPropertiesExt = 1000237000,
        /// <summary>[requires: <b>VK_NV_memory_decompression</b>] </summary>
        StructureTypePhysicalDeviceMemoryDecompressionFeaturesNv = 1000427000,
        /// <summary>[requires: <b>VK_NV_memory_decompression</b>] </summary>
        StructureTypePhysicalDeviceMemoryDecompressionPropertiesNv = 1000427001,
        /// <summary>[requires: <b>VK_EXT_memory_priority</b>] </summary>
        StructureTypePhysicalDeviceMemoryPriorityFeaturesExt = 1000238000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceMemoryProperties2 = 1000059006,
        /// <summary>[requires: <b>VK_KHR_get_physical_device_properties2</b>] </summary>
        StructureTypePhysicalDeviceMemoryProperties2Khr = 1000059006,
        /// <summary>[requires: <b>VK_EXT_mesh_shader</b>] </summary>
        StructureTypePhysicalDeviceMeshShaderFeaturesExt = 1000328000,
        /// <summary>[requires: <b>VK_NV_mesh_shader</b>] </summary>
        StructureTypePhysicalDeviceMeshShaderFeaturesNv = 1000202000,
        /// <summary>[requires: <b>VK_EXT_mesh_shader</b>] </summary>
        StructureTypePhysicalDeviceMeshShaderPropertiesExt = 1000328001,
        /// <summary>[requires: <b>VK_NV_mesh_shader</b>] </summary>
        StructureTypePhysicalDeviceMeshShaderPropertiesNv = 1000202001,
        /// <summary>[requires: <b>VK_EXT_multi_draw</b>] </summary>
        StructureTypePhysicalDeviceMultiDrawFeaturesExt = 1000392000,
        /// <summary>[requires: <b>VK_EXT_multi_draw</b>] </summary>
        StructureTypePhysicalDeviceMultiDrawPropertiesExt = 1000392001,
        /// <summary>[requires: <b>VK_EXT_multisampled_render_to_single_sampled</b>] </summary>
        StructureTypePhysicalDeviceMultisampledRenderToSingleSampledFeaturesExt = 1000376000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceMultiviewFeatures = 1000053001,
        /// <summary>[requires: <b>VK_KHR_multiview</b>] </summary>
        StructureTypePhysicalDeviceMultiviewFeaturesKhr = 1000053001,
        /// <summary>[requires: <b>VK_NVX_multiview_per_view_attributes</b>] </summary>
        StructureTypePhysicalDeviceMultiviewPerViewAttributesPropertiesNvx = 1000097000,
        /// <summary>[requires: <b>VK_QCOM_multiview_per_view_render_areas</b>] </summary>
        StructureTypePhysicalDeviceMultiviewPerViewRenderAreasFeaturesQcom = 1000510000,
        /// <summary>[requires: <b>VK_QCOM_multiview_per_view_viewports</b>] </summary>
        StructureTypePhysicalDeviceMultiviewPerViewViewportsFeaturesQcom = 1000488000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceMultiviewProperties = 1000053002,
        /// <summary>[requires: <b>VK_KHR_multiview</b>] </summary>
        StructureTypePhysicalDeviceMultiviewPropertiesKhr = 1000053002,
        /// <summary>[requires: <b>VK_EXT_mutable_descriptor_type</b>] </summary>
        StructureTypePhysicalDeviceMutableDescriptorTypeFeaturesExt = 1000351000,
        /// <summary>[requires: <b>VK_VALVE_mutable_descriptor_type</b>] </summary>
        StructureTypePhysicalDeviceMutableDescriptorTypeFeaturesValve = 1000351000,
        /// <summary>[requires: <b>VK_EXT_nested_command_buffer</b>] </summary>
        StructureTypePhysicalDeviceNestedCommandBufferFeaturesExt = 1000451000,
        /// <summary>[requires: <b>VK_EXT_nested_command_buffer</b>] </summary>
        StructureTypePhysicalDeviceNestedCommandBufferPropertiesExt = 1000451001,
        /// <summary>[requires: <b>VK_EXT_non_seamless_cube_map</b>] </summary>
        StructureTypePhysicalDeviceNonSeamlessCubeMapFeaturesExt = 1000422000,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        StructureTypePhysicalDeviceOpacityMicromapFeaturesExt = 1000396005,
        /// <summary>[requires: <b>VK_EXT_opacity_micromap</b>] </summary>
        StructureTypePhysicalDeviceOpacityMicromapPropertiesExt = 1000396006,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        StructureTypePhysicalDeviceOpticalFlowFeaturesNv = 1000464000,
        /// <summary>[requires: <b>VK_NV_optical_flow</b>] </summary>
        StructureTypePhysicalDeviceOpticalFlowPropertiesNv = 1000464001,
        /// <summary>[requires: <b>VK_EXT_pageable_device_local_memory</b>] </summary>
        StructureTypePhysicalDevicePageableDeviceLocalMemoryFeaturesExt = 1000412000,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        StructureTypePhysicalDevicePartitionedAccelerationStructureFeaturesNv = 1000570000,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        StructureTypePhysicalDevicePartitionedAccelerationStructurePropertiesNv = 1000570001,
        /// <summary>[requires: <b>VK_EXT_pci_bus_info</b>] </summary>
        StructureTypePhysicalDevicePciBusInfoPropertiesExt = 1000212000,
        /// <summary>[requires: <b>VK_NV_per_stage_descriptor_set</b>] </summary>
        StructureTypePhysicalDevicePerStageDescriptorSetFeaturesNv = 1000516000,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        StructureTypePhysicalDevicePerformanceQueryFeaturesKhr = 1000116000,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        StructureTypePhysicalDevicePerformanceQueryPropertiesKhr = 1000116001,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        StructureTypePhysicalDevicePipelineBinaryFeaturesKhr = 1000483000,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        StructureTypePhysicalDevicePipelineBinaryPropertiesKhr = 1000483004,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDevicePipelineCreationCacheControlFeatures = 1000297000,
        /// <summary>[requires: <b>VK_EXT_pipeline_creation_cache_control</b>] </summary>
        StructureTypePhysicalDevicePipelineCreationCacheControlFeaturesExt = 1000297000,
        /// <summary>[requires: <b>VK_KHR_pipeline_executable_properties</b>] </summary>
        StructureTypePhysicalDevicePipelineExecutablePropertiesFeaturesKhr = 1000269000,
        /// <summary>[requires: <b>VK_EXT_pipeline_library_group_handles</b>] </summary>
        StructureTypePhysicalDevicePipelineLibraryGroupHandlesFeaturesExt = 1000498000,
        /// <summary>[requires: <b>VK_ARM_pipeline_opacity_micromap</b>] </summary>
        StructureTypePhysicalDevicePipelineOpacityMicromapFeaturesArm = 1000596000,
        /// <summary>[requires: <b>VK_EXT_pipeline_properties</b>] </summary>
        StructureTypePhysicalDevicePipelinePropertiesFeaturesExt = 1000372001,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDevicePipelineProtectedAccessFeatures = 1000466000,
        /// <summary>[requires: <b>VK_EXT_pipeline_protected_access</b>] </summary>
        StructureTypePhysicalDevicePipelineProtectedAccessFeaturesExt = 1000466000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDevicePipelineRobustnessFeatures = 1000068001,
        /// <summary>[requires: <b>VK_EXT_pipeline_robustness</b>] </summary>
        StructureTypePhysicalDevicePipelineRobustnessFeaturesExt = 1000068001,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDevicePipelineRobustnessProperties = 1000068002,
        /// <summary>[requires: <b>VK_EXT_pipeline_robustness</b>] </summary>
        StructureTypePhysicalDevicePipelineRobustnessPropertiesExt = 1000068002,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDevicePointClippingProperties = 1000117000,
        /// <summary>[requires: <b>VK_KHR_maintenance2</b>] </summary>
        StructureTypePhysicalDevicePointClippingPropertiesKhr = 1000117000,
        /// <summary>[requires: <b>VK_KHR_portability_subset</b>] </summary>
        StructureTypePhysicalDevicePortabilitySubsetFeaturesKhr = 1000163000,
        /// <summary>[requires: <b>VK_KHR_portability_subset</b>] </summary>
        StructureTypePhysicalDevicePortabilitySubsetPropertiesKhr = 1000163001,
        /// <summary>[requires: <b>VK_NV_present_barrier</b>] </summary>
        StructureTypePhysicalDevicePresentBarrierFeaturesNv = 1000292000,
        /// <summary>[requires: <b>VK_KHR_present_id</b>] </summary>
        StructureTypePhysicalDevicePresentIdFeaturesKhr = 1000294001,
        /// <summary>[requires: <b>VK_NV_present_metering</b>] </summary>
        StructureTypePhysicalDevicePresentMeteringFeaturesNv = 1000613001,
        /// <summary>[requires: <b>VK_EXT_present_mode_fifo_latest_ready</b>] </summary>
        StructureTypePhysicalDevicePresentModeFifoLatestReadyFeaturesExt = 1000361000,
        /// <summary>[requires: <b>VK_KHR_present_wait</b>] </summary>
        StructureTypePhysicalDevicePresentWaitFeaturesKhr = 1000248000,
        /// <summary>[requires: <b>VK_EXT_primitive_topology_list_restart</b>] </summary>
        StructureTypePhysicalDevicePrimitiveTopologyListRestartFeaturesExt = 1000356000,
        /// <summary>[requires: <b>VK_EXT_primitives_generated_query</b>] </summary>
        StructureTypePhysicalDevicePrimitivesGeneratedQueryFeaturesExt = 1000382000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDevicePrivateDataFeatures = 1000295000,
        /// <summary>[requires: <b>VK_EXT_private_data</b>] </summary>
        StructureTypePhysicalDevicePrivateDataFeaturesExt = 1000295000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceProperties2 = 1000059001,
        /// <summary>[requires: <b>VK_KHR_get_physical_device_properties2</b>] </summary>
        StructureTypePhysicalDeviceProperties2Khr = 1000059001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceProtectedMemoryFeatures = 1000145001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceProtectedMemoryProperties = 1000145002,
        /// <summary>[requires: <b>VK_EXT_provoking_vertex</b>] </summary>
        StructureTypePhysicalDeviceProvokingVertexFeaturesExt = 1000254000,
        /// <summary>[requires: <b>VK_EXT_provoking_vertex</b>] </summary>
        StructureTypePhysicalDeviceProvokingVertexPropertiesExt = 1000254002,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDevicePushDescriptorProperties = 1000080000,
        /// <summary>[requires: <b>VK_KHR_push_descriptor</b>] </summary>
        StructureTypePhysicalDevicePushDescriptorPropertiesKhr = 1000080000,
        /// <summary>[requires: <b>VK_ARM_rasterization_order_attachment_access</b>] </summary>
        StructureTypePhysicalDeviceRasterizationOrderAttachmentAccessFeaturesArm = 1000342000,
        /// <summary>[requires: <b>VK_EXT_rasterization_order_attachment_access</b>] </summary>
        StructureTypePhysicalDeviceRasterizationOrderAttachmentAccessFeaturesExt = 1000342000,
        /// <summary>[requires: <b>VK_NV_raw_access_chains</b>] </summary>
        StructureTypePhysicalDeviceRawAccessChainsFeaturesNv = 1000555000,
        /// <summary>[requires: <b>VK_KHR_ray_query</b>] </summary>
        StructureTypePhysicalDeviceRayQueryFeaturesKhr = 1000348013,
        /// <summary>[requires: <b>VK_NV_ray_tracing_invocation_reorder</b>] </summary>
        StructureTypePhysicalDeviceRayTracingInvocationReorderFeaturesNv = 1000490000,
        /// <summary>[requires: <b>VK_NV_ray_tracing_invocation_reorder</b>] </summary>
        StructureTypePhysicalDeviceRayTracingInvocationReorderPropertiesNv = 1000490001,
        /// <summary>[requires: <b>VK_NV_ray_tracing_linear_swept_spheres</b>] </summary>
        StructureTypePhysicalDeviceRayTracingLinearSweptSpheresFeaturesNv = 1000429008,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_maintenance1</b>] </summary>
        StructureTypePhysicalDeviceRayTracingMaintenance1FeaturesKhr = 1000386000,
        /// <summary>[requires: <b>VK_NV_ray_tracing_motion_blur</b>] </summary>
        StructureTypePhysicalDeviceRayTracingMotionBlurFeaturesNv = 1000327001,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        StructureTypePhysicalDeviceRayTracingPipelineFeaturesKhr = 1000347000,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        StructureTypePhysicalDeviceRayTracingPipelinePropertiesKhr = 1000347001,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_position_fetch</b>] </summary>
        StructureTypePhysicalDeviceRayTracingPositionFetchFeaturesKhr = 1000481000,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        StructureTypePhysicalDeviceRayTracingPropertiesNv = 1000165009,
        /// <summary>[requires: <b>VK_NV_ray_tracing_validation</b>] </summary>
        StructureTypePhysicalDeviceRayTracingValidationFeaturesNv = 1000568000,
        /// <summary>[requires: <b>VK_IMG_relaxed_line_rasterization</b>] </summary>
        StructureTypePhysicalDeviceRelaxedLineRasterizationFeaturesImg = 1000110000,
        /// <summary>[requires: <b>VK_ARM_render_pass_striped</b>] </summary>
        StructureTypePhysicalDeviceRenderPassStripedFeaturesArm = 1000424000,
        /// <summary>[requires: <b>VK_ARM_render_pass_striped</b>] </summary>
        StructureTypePhysicalDeviceRenderPassStripedPropertiesArm = 1000424001,
        /// <summary>[requires: <b>VK_NV_representative_fragment_test</b>] </summary>
        StructureTypePhysicalDeviceRepresentativeFragmentTestFeaturesNv = 1000166000,
        /// <summary>[requires: <b>VK_EXT_rgba10x6_formats</b>] </summary>
        StructureTypePhysicalDeviceRgba10x6FormatsFeaturesExt = 1000344000,
        /// <summary>[requires: <b>VK_EXT_robustness2</b>] </summary>
        StructureTypePhysicalDeviceRobustness2FeaturesExt = 1000286000,
        /// <summary>[requires: <b>VK_EXT_robustness2</b>] </summary>
        StructureTypePhysicalDeviceRobustness2PropertiesExt = 1000286001,
        /// <summary>[requires: <b>VK_EXT_sample_locations</b>] </summary>
        StructureTypePhysicalDeviceSampleLocationsPropertiesExt = 1000143003,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceSamplerFilterMinmaxProperties = 1000130000,
        /// <summary>[requires: <b>VK_EXT_sampler_filter_minmax</b>] </summary>
        StructureTypePhysicalDeviceSamplerFilterMinmaxPropertiesExt = 1000130000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceSamplerYcbcrConversionFeatures = 1000156004,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        StructureTypePhysicalDeviceSamplerYcbcrConversionFeaturesKhr = 1000156004,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceScalarBlockLayoutFeatures = 1000221000,
        /// <summary>[requires: <b>VK_EXT_scalar_block_layout</b>] </summary>
        StructureTypePhysicalDeviceScalarBlockLayoutFeaturesExt = 1000221000,
        /// <summary>[requires: <b>VK_ARM_scheduling_controls</b>] </summary>
        StructureTypePhysicalDeviceSchedulingControlsFeaturesArm = 1000417001,
        /// <summary>[requires: <b>VK_ARM_scheduling_controls</b>] </summary>
        StructureTypePhysicalDeviceSchedulingControlsPropertiesArm = 1000417002,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceSeparateDepthStencilLayoutsFeatures = 1000241000,
        /// <summary>[requires: <b>VK_KHR_separate_depth_stencil_layouts</b>] </summary>
        StructureTypePhysicalDeviceSeparateDepthStencilLayoutsFeaturesKhr = 1000241000,
        /// <summary>[requires: <b>VK_EXT_shader_atomic_float2</b>] </summary>
        StructureTypePhysicalDeviceShaderAtomicFloat2FeaturesExt = 1000273000,
        /// <summary>[requires: <b>VK_EXT_shader_atomic_float</b>] </summary>
        StructureTypePhysicalDeviceShaderAtomicFloatFeaturesExt = 1000260000,
        /// <summary>[requires: <b>VK_NV_shader_atomic_float16_vector</b>] </summary>
        StructureTypePhysicalDeviceShaderAtomicFloat16VectorFeaturesNv = 1000563000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceShaderAtomicInt64Features = 1000180000,
        /// <summary>[requires: <b>VK_KHR_shader_atomic_int64</b>] </summary>
        StructureTypePhysicalDeviceShaderAtomicInt64FeaturesKhr = 1000180000,
        /// <summary>[requires: <b>VK_KHR_shader_bfloat16</b>] </summary>
        StructureTypePhysicalDeviceShaderBfloat16FeaturesKhr = 1000141000,
        /// <summary>[requires: <b>VK_KHR_shader_clock</b>] </summary>
        StructureTypePhysicalDeviceShaderClockFeaturesKhr = 1000181000,
        /// <summary>[requires: <b>VK_ARM_shader_core_builtins</b>] </summary>
        StructureTypePhysicalDeviceShaderCoreBuiltinsFeaturesArm = 1000497000,
        /// <summary>[requires: <b>VK_ARM_shader_core_builtins</b>] </summary>
        StructureTypePhysicalDeviceShaderCoreBuiltinsPropertiesArm = 1000497001,
        /// <summary>[requires: <b>VK_AMD_shader_core_properties2</b>] </summary>
        StructureTypePhysicalDeviceShaderCoreProperties2Amd = 1000227000,
        /// <summary>[requires: <b>VK_AMD_shader_core_properties</b>] </summary>
        StructureTypePhysicalDeviceShaderCorePropertiesAmd = 1000185000,
        /// <summary>[requires: <b>VK_ARM_shader_core_properties</b>] </summary>
        StructureTypePhysicalDeviceShaderCorePropertiesArm = 1000415000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceShaderDemoteToHelperInvocationFeatures = 1000276000,
        /// <summary>[requires: <b>VK_EXT_shader_demote_to_helper_invocation</b>] </summary>
        StructureTypePhysicalDeviceShaderDemoteToHelperInvocationFeaturesExt = 1000276000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceShaderDrawParameterFeatures = 1000063000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceShaderDrawParametersFeatures = 1000063000,
        /// <summary>[requires: <b>VK_AMD_shader_early_and_late_fragment_tests</b>] </summary>
        StructureTypePhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAmd = 1000321000,
        /// <summary>[requires: <b>VK_AMDX_shader_enqueue</b>] </summary>
        StructureTypePhysicalDeviceShaderEnqueueFeaturesAmdx = 1000134000,
        /// <summary>[requires: <b>VK_AMDX_shader_enqueue</b>] </summary>
        StructureTypePhysicalDeviceShaderEnqueuePropertiesAmdx = 1000134001,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceShaderExpectAssumeFeatures = 1000544000,
        /// <summary>[requires: <b>VK_KHR_shader_expect_assume</b>] </summary>
        StructureTypePhysicalDeviceShaderExpectAssumeFeaturesKhr = 1000544000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceShaderFloatControls2Features = 1000528000,
        /// <summary>[requires: <b>VK_KHR_shader_float_controls2</b>] </summary>
        StructureTypePhysicalDeviceShaderFloatControls2FeaturesKhr = 1000528000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceShaderFloat16Int8Features = 1000082000,
        /// <summary>[requires: <b>VK_KHR_shader_float16_int8</b>] </summary>
        StructureTypePhysicalDeviceShaderFloat16Int8FeaturesKhr = 1000082000,
        /// <summary>[requires: <b>VK_EXT_shader_image_atomic_int64</b>] </summary>
        StructureTypePhysicalDeviceShaderImageAtomicInt64FeaturesExt = 1000234000,
        /// <summary>[requires: <b>VK_NV_shader_image_footprint</b>] </summary>
        StructureTypePhysicalDeviceShaderImageFootprintFeaturesNv = 1000204000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceShaderIntegerDotProductFeatures = 1000280000,
        /// <summary>[requires: <b>VK_KHR_shader_integer_dot_product</b>] </summary>
        StructureTypePhysicalDeviceShaderIntegerDotProductFeaturesKhr = 1000280000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceShaderIntegerDotProductProperties = 1000280001,
        /// <summary>[requires: <b>VK_KHR_shader_integer_dot_product</b>] </summary>
        StructureTypePhysicalDeviceShaderIntegerDotProductPropertiesKhr = 1000280001,
        /// <summary>[requires: <b>VK_INTEL_shader_integer_functions2</b>] </summary>
        StructureTypePhysicalDeviceShaderIntegerFunctions2FeaturesIntel = 1000209000,
        /// <summary>[requires: <b>VK_KHR_shader_maximal_reconvergence</b>] </summary>
        StructureTypePhysicalDeviceShaderMaximalReconvergenceFeaturesKhr = 1000434000,
        /// <summary>[requires: <b>VK_EXT_shader_module_identifier</b>] </summary>
        StructureTypePhysicalDeviceShaderModuleIdentifierFeaturesExt = 1000462000,
        /// <summary>[requires: <b>VK_EXT_shader_module_identifier</b>] </summary>
        StructureTypePhysicalDeviceShaderModuleIdentifierPropertiesExt = 1000462001,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        StructureTypePhysicalDeviceShaderObjectFeaturesExt = 1000482000,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        StructureTypePhysicalDeviceShaderObjectPropertiesExt = 1000482001,
        /// <summary>[requires: <b>VK_KHR_shader_quad_control</b>] </summary>
        StructureTypePhysicalDeviceShaderQuadControlFeaturesKhr = 1000235000,
        /// <summary>[requires: <b>VK_KHR_shader_relaxed_extended_instruction</b>] </summary>
        StructureTypePhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKhr = 1000558000,
        /// <summary>[requires: <b>VK_EXT_shader_replicated_composites</b>] </summary>
        StructureTypePhysicalDeviceShaderReplicatedCompositesFeaturesExt = 1000564000,
        /// <summary>[requires: <b>VK_NV_shader_sm_builtins</b>] </summary>
        StructureTypePhysicalDeviceShaderSmBuiltinsFeaturesNv = 1000154000,
        /// <summary>[requires: <b>VK_NV_shader_sm_builtins</b>] </summary>
        StructureTypePhysicalDeviceShaderSmBuiltinsPropertiesNv = 1000154001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceShaderSubgroupExtendedTypesFeatures = 1000175000,
        /// <summary>[requires: <b>VK_KHR_shader_subgroup_extended_types</b>] </summary>
        StructureTypePhysicalDeviceShaderSubgroupExtendedTypesFeaturesKhr = 1000175000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceShaderSubgroupRotateFeatures = 1000416000,
        /// <summary>[requires: <b>VK_KHR_shader_subgroup_rotate</b>] </summary>
        StructureTypePhysicalDeviceShaderSubgroupRotateFeaturesKhr = 1000416000,
        /// <summary>[requires: <b>VK_KHR_shader_subgroup_uniform_control_flow</b>] </summary>
        StructureTypePhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKhr = 1000323000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceShaderTerminateInvocationFeatures = 1000215000,
        /// <summary>[requires: <b>VK_KHR_shader_terminate_invocation</b>] </summary>
        StructureTypePhysicalDeviceShaderTerminateInvocationFeaturesKhr = 1000215000,
        /// <summary>[requires: <b>VK_EXT_shader_tile_image</b>] </summary>
        StructureTypePhysicalDeviceShaderTileImageFeaturesExt = 1000395000,
        /// <summary>[requires: <b>VK_EXT_shader_tile_image</b>] </summary>
        StructureTypePhysicalDeviceShaderTileImagePropertiesExt = 1000395001,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        StructureTypePhysicalDeviceShadingRateImageFeaturesNv = 1000164001,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        StructureTypePhysicalDeviceShadingRateImagePropertiesNv = 1000164002,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceSparseImageFormatInfo2 = 1000059008,
        /// <summary>[requires: <b>VK_KHR_get_physical_device_properties2</b>] </summary>
        StructureTypePhysicalDeviceSparseImageFormatInfo2Khr = 1000059008,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceSubgroupProperties = 1000094000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceSubgroupSizeControlFeatures = 1000225002,
        /// <summary>[requires: <b>VK_EXT_subgroup_size_control</b>] </summary>
        StructureTypePhysicalDeviceSubgroupSizeControlFeaturesExt = 1000225002,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceSubgroupSizeControlProperties = 1000225000,
        /// <summary>[requires: <b>VK_EXT_subgroup_size_control</b>] </summary>
        StructureTypePhysicalDeviceSubgroupSizeControlPropertiesExt = 1000225000,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        StructureTypePhysicalDeviceSubpassMergeFeedbackFeaturesExt = 1000458000,
        /// <summary>[requires: <b>VK_HUAWEI_subpass_shading</b>] </summary>
        StructureTypePhysicalDeviceSubpassShadingFeaturesHuawei = 1000369001,
        /// <summary>[requires: <b>VK_HUAWEI_subpass_shading</b>] </summary>
        StructureTypePhysicalDeviceSubpassShadingPropertiesHuawei = 1000369002,
        /// <summary>[requires: <b>VK_KHR_get_surface_capabilities2</b>] </summary>
        StructureTypePhysicalDeviceSurfaceInfo2Khr = 1000119000,
        /// <summary>[requires: <b>VK_EXT_swapchain_maintenance1</b>] </summary>
        StructureTypePhysicalDeviceSwapchainMaintenance1FeaturesExt = 1000275000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceSynchronization2Features = 1000314007,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        StructureTypePhysicalDeviceSynchronization2FeaturesKhr = 1000314007,
        /// <summary>[requires: <b>VK_EXT_texel_buffer_alignment</b>] Not promoted to 1.3</summary>
        StructureTypePhysicalDeviceTexelBufferAlignmentFeaturesExt = 1000281000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceTexelBufferAlignmentProperties = 1000281001,
        /// <summary>[requires: <b>VK_EXT_texel_buffer_alignment</b>] </summary>
        StructureTypePhysicalDeviceTexelBufferAlignmentPropertiesExt = 1000281001,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceTextureCompressionAstcHdrFeatures = 1000066000,
        /// <summary>[requires: <b>VK_EXT_texture_compression_astc_hdr</b>] </summary>
        StructureTypePhysicalDeviceTextureCompressionAstcHdrFeaturesExt = 1000066000,
        /// <summary>[requires: <b>VK_QCOM_tile_properties</b>] </summary>
        StructureTypePhysicalDeviceTilePropertiesFeaturesQcom = 1000484000,
        /// <summary>[requires: <b>VK_QCOM_tile_shading</b>] </summary>
        StructureTypePhysicalDeviceTileShadingFeaturesQcom = 1000309000,
        /// <summary>[requires: <b>VK_QCOM_tile_shading</b>] </summary>
        StructureTypePhysicalDeviceTileShadingPropertiesQcom = 1000309001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceTimelineSemaphoreFeatures = 1000207000,
        /// <summary>[requires: <b>VK_KHR_timeline_semaphore</b>] </summary>
        StructureTypePhysicalDeviceTimelineSemaphoreFeaturesKhr = 1000207000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceTimelineSemaphoreProperties = 1000207001,
        /// <summary>[requires: <b>VK_KHR_timeline_semaphore</b>] </summary>
        StructureTypePhysicalDeviceTimelineSemaphorePropertiesKhr = 1000207001,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceToolProperties = 1000245000,
        /// <summary>[requires: <b>VK_EXT_tooling_info</b>] </summary>
        StructureTypePhysicalDeviceToolPropertiesExt = 1000245000,
        /// <summary>[requires: <b>VK_EXT_transform_feedback</b>] </summary>
        StructureTypePhysicalDeviceTransformFeedbackFeaturesExt = 1000028000,
        /// <summary>[requires: <b>VK_EXT_transform_feedback</b>] </summary>
        StructureTypePhysicalDeviceTransformFeedbackPropertiesExt = 1000028001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceUniformBufferStandardLayoutFeatures = 1000253000,
        /// <summary>[requires: <b>VK_KHR_uniform_buffer_standard_layout</b>] </summary>
        StructureTypePhysicalDeviceUniformBufferStandardLayoutFeaturesKhr = 1000253000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceVariablePointerFeatures = 1000120000,
        /// <summary>[requires: <b>VK_KHR_variable_pointers</b>] </summary>
        StructureTypePhysicalDeviceVariablePointerFeaturesKhr = 1000120000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePhysicalDeviceVariablePointersFeatures = 1000120000,
        /// <summary>[requires: <b>VK_KHR_variable_pointers</b>] </summary>
        StructureTypePhysicalDeviceVariablePointersFeaturesKhr = 1000120000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceVertexAttributeDivisorFeatures = 1000190002,
        /// <summary>[requires: <b>VK_EXT_vertex_attribute_divisor</b>] </summary>
        StructureTypePhysicalDeviceVertexAttributeDivisorFeaturesExt = 1000190002,
        /// <summary>[requires: <b>VK_KHR_vertex_attribute_divisor</b>] </summary>
        StructureTypePhysicalDeviceVertexAttributeDivisorFeaturesKhr = 1000190002,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceVertexAttributeDivisorProperties = 1000525000,
        /// <summary>[requires: <b>VK_EXT_vertex_attribute_divisor</b>] </summary>
        StructureTypePhysicalDeviceVertexAttributeDivisorPropertiesExt = 1000190000,
        /// <summary>[requires: <b>VK_KHR_vertex_attribute_divisor</b>] </summary>
        StructureTypePhysicalDeviceVertexAttributeDivisorPropertiesKhr = 1000525000,
        /// <summary>[requires: <b>VK_EXT_vertex_attribute_robustness</b>] </summary>
        StructureTypePhysicalDeviceVertexAttributeRobustnessFeaturesExt = 1000608000,
        /// <summary>[requires: <b>VK_EXT_vertex_input_dynamic_state</b>] </summary>
        StructureTypePhysicalDeviceVertexInputDynamicStateFeaturesExt = 1000352000,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        StructureTypePhysicalDeviceVideoEncodeAv1FeaturesKhr = 1000513004,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        StructureTypePhysicalDeviceVideoEncodeQualityLevelInfoKhr = 1000299006,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        StructureTypePhysicalDeviceVideoEncodeQuantizationMapFeaturesKhr = 1000553009,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypePhysicalDeviceVideoFormatInfoKhr = 1000023014,
        /// <summary>[requires: <b>VK_KHR_video_maintenance1</b>] </summary>
        StructureTypePhysicalDeviceVideoMaintenance1FeaturesKhr = 1000515000,
        /// <summary>[requires: <b>VK_KHR_video_maintenance2</b>] </summary>
        StructureTypePhysicalDeviceVideoMaintenance2FeaturesKhr = 1000586000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceVulkan11Features = 49,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceVulkan11Properties = 50,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceVulkan12Features = 51,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceVulkan12Properties = 52,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceVulkan13Features = 53,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceVulkan13Properties = 54,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceVulkan14Features = 55,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePhysicalDeviceVulkan14Properties = 56,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypePhysicalDeviceVulkanMemoryModelFeatures = 1000211000,
        /// <summary>[requires: <b>VK_KHR_vulkan_memory_model</b>] </summary>
        StructureTypePhysicalDeviceVulkanMemoryModelFeaturesKhr = 1000211000,
        /// <summary>[requires: <b>VK_KHR_workgroup_memory_explicit_layout</b>] </summary>
        StructureTypePhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKhr = 1000336000,
        /// <summary>[requires: <b>VK_EXT_ycbcr_2plane_444_formats</b>] </summary>
        StructureTypePhysicalDeviceYcbcr2Plane444FormatsFeaturesExt = 1000330000,
        /// <summary>[requires: <b>VK_QCOM_ycbcr_degamma</b>] </summary>
        StructureTypePhysicalDeviceYcbcrDegammaFeaturesQcom = 1000520000,
        /// <summary>[requires: <b>VK_EXT_ycbcr_image_arrays</b>] </summary>
        StructureTypePhysicalDeviceYcbcrImageArraysFeaturesExt = 1000252000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePhysicalDeviceZeroInitializeWorkgroupMemoryFeatures = 1000325000,
        /// <summary>[requires: <b>VK_KHR_zero_initialize_workgroup_memory</b>] </summary>
        StructureTypePhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKhr = 1000325000,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        StructureTypePipelineBinaryCreateInfoKhr = 1000483001,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        StructureTypePipelineBinaryDataInfoKhr = 1000483006,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        StructureTypePipelineBinaryHandlesInfoKhr = 1000483009,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        StructureTypePipelineBinaryInfoKhr = 1000483002,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        StructureTypePipelineBinaryKeyKhr = 1000483003,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypePipelineCacheCreateInfo = 17,
        /// <summary>[requires: <b>VK_EXT_blend_operation_advanced</b>] </summary>
        StructureTypePipelineColorBlendAdvancedStateCreateInfoExt = 1000148002,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypePipelineColorBlendStateCreateInfo = 26,
        /// <summary>[requires: <b>VK_EXT_color_write_enable</b>] </summary>
        StructureTypePipelineColorWriteCreateInfoExt = 1000381001,
        /// <summary>[requires: <b>VK_AMD_pipeline_compiler_control</b>] </summary>
        StructureTypePipelineCompilerControlCreateInfoAmd = 1000183000,
        /// <summary>[requires: <b>VK_NV_framebuffer_mixed_samples</b>] </summary>
        StructureTypePipelineCoverageModulationStateCreateInfoNv = 1000152000,
        /// <summary>[requires: <b>VK_NV_coverage_reduction_mode</b>] </summary>
        StructureTypePipelineCoverageReductionStateCreateInfoNv = 1000250001,
        /// <summary>[requires: <b>VK_NV_fragment_coverage_to_color</b>] </summary>
        StructureTypePipelineCoverageToColorStateCreateInfoNv = 1000149000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePipelineCreateFlags2CreateInfo = 1000470005,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        StructureTypePipelineCreateFlags2CreateInfoKhr = 1000470005,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        StructureTypePipelineCreateInfoKhr = 1000483007,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePipelineCreationFeedbackCreateInfo = 1000192000,
        /// <summary>[requires: <b>VK_EXT_pipeline_creation_feedback</b>] </summary>
        StructureTypePipelineCreationFeedbackCreateInfoExt = 1000192000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypePipelineDepthStencilStateCreateInfo = 25,
        /// <summary>[requires: <b>VK_EXT_discard_rectangles</b>] </summary>
        StructureTypePipelineDiscardRectangleStateCreateInfoExt = 1000099001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypePipelineDynamicStateCreateInfo = 27,
        /// <summary>[requires: <b>VK_KHR_pipeline_executable_properties</b>] </summary>
        StructureTypePipelineExecutableInfoKhr = 1000269003,
        /// <summary>[requires: <b>VK_KHR_pipeline_executable_properties</b>] </summary>
        StructureTypePipelineExecutableInternalRepresentationKhr = 1000269005,
        /// <summary>[requires: <b>VK_KHR_pipeline_executable_properties</b>] </summary>
        StructureTypePipelineExecutablePropertiesKhr = 1000269002,
        /// <summary>[requires: <b>VK_KHR_pipeline_executable_properties</b>] </summary>
        StructureTypePipelineExecutableStatisticKhr = 1000269004,
        /// <summary>[requires: <b>VK_NV_fragment_shading_rate_enums</b>] </summary>
        StructureTypePipelineFragmentShadingRateEnumStateCreateInfoNv = 1000326002,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        StructureTypePipelineFragmentShadingRateStateCreateInfoKhr = 1000226001,
        /// <summary>[requires: <b>VK_NV_device_generated_commands_compute</b>] </summary>
        StructureTypePipelineIndirectDeviceAddressInfoNv = 1000428002,
        /// <summary>[requires: <b>VK_EXT_pipeline_properties</b>] </summary>
        StructureTypePipelineInfoExt = 1000269001,
        /// <summary>[requires: <b>VK_KHR_pipeline_executable_properties</b>] </summary>
        StructureTypePipelineInfoKhr = 1000269001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypePipelineInputAssemblyStateCreateInfo = 20,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypePipelineLayoutCreateInfo = 30,
        /// <summary>[requires: <b>VK_KHR_pipeline_library</b>] </summary>
        StructureTypePipelineLibraryCreateInfoKhr = 1000290000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypePipelineMultisampleStateCreateInfo = 24,
        /// <summary>[requires: <b>VK_EXT_pipeline_properties</b>] </summary>
        StructureTypePipelinePropertiesIdentifierExt = 1000372000,
        /// <summary>[requires: <b>VK_EXT_conservative_rasterization</b>] </summary>
        StructureTypePipelineRasterizationConservativeStateCreateInfoExt = 1000101001,
        /// <summary>[requires: <b>VK_EXT_depth_clip_enable</b>] </summary>
        StructureTypePipelineRasterizationDepthClipStateCreateInfoExt = 1000102001,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePipelineRasterizationLineStateCreateInfo = 1000259001,
        /// <summary>[requires: <b>VK_EXT_line_rasterization</b>] </summary>
        StructureTypePipelineRasterizationLineStateCreateInfoExt = 1000259001,
        /// <summary>[requires: <b>VK_KHR_line_rasterization</b>] </summary>
        StructureTypePipelineRasterizationLineStateCreateInfoKhr = 1000259001,
        /// <summary>[requires: <b>VK_EXT_provoking_vertex</b>] </summary>
        StructureTypePipelineRasterizationProvokingVertexStateCreateInfoExt = 1000254001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypePipelineRasterizationStateCreateInfo = 23,
        /// <summary>[requires: <b>VK_AMD_rasterization_order</b>] </summary>
        StructureTypePipelineRasterizationStateRasterizationOrderAmd = 1000018000,
        /// <summary>[requires: <b>VK_EXT_transform_feedback</b>] </summary>
        StructureTypePipelineRasterizationStateStreamCreateInfoExt = 1000028002,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePipelineRenderingCreateInfo = 1000044002,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering</b>] </summary>
        StructureTypePipelineRenderingCreateInfoKhr = 1000044002,
        /// <summary>[requires: <b>VK_NV_representative_fragment_test</b>] </summary>
        StructureTypePipelineRepresentativeFragmentTestStateCreateInfoNv = 1000166001,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePipelineRobustnessCreateInfo = 1000068000,
        /// <summary>[requires: <b>VK_EXT_pipeline_robustness</b>] </summary>
        StructureTypePipelineRobustnessCreateInfoExt = 1000068000,
        /// <summary>[requires: <b>VK_EXT_sample_locations</b>] </summary>
        StructureTypePipelineSampleLocationsStateCreateInfoExt = 1000143002,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypePipelineShaderStageCreateInfo = 18,
        /// <summary>[requires: <b>VK_EXT_shader_module_identifier</b>] </summary>
        StructureTypePipelineShaderStageModuleIdentifierCreateInfoExt = 1000462002,
        /// <summary>[requires: <b>VK_AMDX_shader_enqueue</b>] </summary>
        StructureTypePipelineShaderStageNodeCreateInfoAmdx = 1000134004,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePipelineShaderStageRequiredSubgroupSizeCreateInfo = 1000225001,
        /// <summary>[requires: <b>VK_EXT_subgroup_size_control</b>] </summary>
        StructureTypePipelineShaderStageRequiredSubgroupSizeCreateInfoExt = 1000225001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypePipelineTessellationDomainOriginStateCreateInfo = 1000117003,
        /// <summary>[requires: <b>VK_KHR_maintenance2</b>] </summary>
        StructureTypePipelineTessellationDomainOriginStateCreateInfoKhr = 1000117003,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypePipelineTessellationStateCreateInfo = 21,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePipelineVertexInputDivisorStateCreateInfo = 1000190001,
        /// <summary>[requires: <b>VK_EXT_vertex_attribute_divisor</b>] </summary>
        StructureTypePipelineVertexInputDivisorStateCreateInfoExt = 1000190001,
        /// <summary>[requires: <b>VK_KHR_vertex_attribute_divisor</b>] </summary>
        StructureTypePipelineVertexInputDivisorStateCreateInfoKhr = 1000190001,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypePipelineVertexInputStateCreateInfo = 19,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        StructureTypePipelineViewportCoarseSampleOrderStateCreateInfoNv = 1000164005,
        /// <summary>[requires: <b>VK_EXT_depth_clamp_control</b>] </summary>
        StructureTypePipelineViewportDepthClampControlCreateInfoExt = 1000582001,
        /// <summary>[requires: <b>VK_EXT_depth_clip_control</b>] </summary>
        StructureTypePipelineViewportDepthClipControlCreateInfoExt = 1000355001,
        /// <summary>[requires: <b>VK_NV_scissor_exclusive</b>] </summary>
        StructureTypePipelineViewportExclusiveScissorStateCreateInfoNv = 1000205000,
        /// <summary>[requires: <b>VK_NV_shading_rate_image</b>] </summary>
        StructureTypePipelineViewportShadingRateImageStateCreateInfoNv = 1000164000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypePipelineViewportStateCreateInfo = 22,
        /// <summary>[requires: <b>VK_NV_viewport_swizzle</b>] </summary>
        StructureTypePipelineViewportSwizzleStateCreateInfoNv = 1000098000,
        /// <summary>[requires: <b>VK_NV_clip_space_w_scaling</b>] </summary>
        StructureTypePipelineViewportWScalingStateCreateInfoNv = 1000087000,
        /// <summary>[requires: <b>VK_GGP_frame_token</b>] </summary>
        StructureTypePresentFrameTokenGgp = 1000191000,
        /// <summary>[requires: <b>VK_KHR_present_id</b>] </summary>
        StructureTypePresentIdKhr = 1000294000,
        /// <summary>[requires: <b>VK_KHR_swapchain</b>] </summary>
        StructureTypePresentInfoKhr = 1000001001,
        /// <summary>[requires: <b>VK_KHR_incremental_present</b>] </summary>
        StructureTypePresentRegionsKhr = 1000084000,
        /// <summary>[requires: <b>VK_GOOGLE_display_timing</b>] </summary>
        StructureTypePresentTimesInfoGoogle = 1000092000,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypePrivateDataSlotCreateInfo = 1000295002,
        /// <summary>[requires: <b>VK_EXT_private_data</b>] </summary>
        StructureTypePrivateDataSlotCreateInfoExt = 1000295002,
        /// <summary>[requires: <b>VK_NV_private_vendor_info</b>] </summary>
        StructureTypePrivateVendorInfoPlaceholderOffset0Nv = 1000051000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeProtectedSubmitInfo = 1000145000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePushConstantsInfo = 1000545004,
        /// <summary>[requires: <b>VK_KHR_maintenance6</b>] </summary>
        StructureTypePushConstantsInfoKhr = 1000545004,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePushDescriptorSetInfo = 1000545005,
        /// <summary>[requires: <b>VK_KHR_maintenance6</b>] </summary>
        StructureTypePushDescriptorSetInfoKhr = 1000545005,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypePushDescriptorSetWithTemplateInfo = 1000545006,
        /// <summary>[requires: <b>VK_KHR_maintenance6</b>] </summary>
        StructureTypePushDescriptorSetWithTemplateInfoKhr = 1000545006,
        /// <summary>[requires: <b>VK_NV_low_latency</b>] </summary>
        StructureTypeQueryLowLatencySupportNv = 1000310000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeQueryPoolCreateInfo = 11,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        StructureTypeQueryPoolCreateInfoIntel = 1000210000,
        /// <summary>[requires: <b>VK_KHR_performance_query</b>] </summary>
        StructureTypeQueryPoolPerformanceCreateInfoKhr = 1000116002,
        /// <summary>[requires: <b>VK_INTEL_performance_query</b>] </summary>
        StructureTypeQueryPoolPerformanceQueryCreateInfoIntel = 1000210000,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        StructureTypeQueryPoolVideoEncodeFeedbackCreateInfoKhr = 1000299005,
        /// <summary>[requires: <b>VK_NV_device_diagnostic_checkpoints</b>] </summary>
        StructureTypeQueueFamilyCheckpointProperties2Nv = 1000314008,
        /// <summary>[requires: <b>VK_NV_device_diagnostic_checkpoints</b>] </summary>
        StructureTypeQueueFamilyCheckpointPropertiesNv = 1000206001,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeQueueFamilyGlobalPriorityProperties = 1000388001,
        /// <summary>[requires: <b>VK_EXT_global_priority_query</b>] </summary>
        StructureTypeQueueFamilyGlobalPriorityPropertiesExt = 1000388001,
        /// <summary>[requires: <b>VK_KHR_global_priority</b>] </summary>
        StructureTypeQueueFamilyGlobalPriorityPropertiesKhr = 1000388001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeQueueFamilyProperties2 = 1000059005,
        /// <summary>[requires: <b>VK_KHR_get_physical_device_properties2</b>] </summary>
        StructureTypeQueueFamilyProperties2Khr = 1000059005,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeQueueFamilyQueryResultStatusPropertiesKhr = 1000023016,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeQueueFamilyVideoPropertiesKhr = 1000023012,
        /// <summary>[requires: <b>VK_NV_cluster_acceleration_structure</b>] </summary>
        StructureTypeRayTracingPipelineClusterAccelerationStructureCreateInfoNv = 1000569007,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        StructureTypeRayTracingPipelineCreateInfoKhr = 1000150015,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        StructureTypeRayTracingPipelineCreateInfoNv = 1000165000,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        StructureTypeRayTracingPipelineInterfaceCreateInfoKhr = 1000150018,
        /// <summary>[requires: <b>VK_KHR_ray_tracing_pipeline</b>] </summary>
        StructureTypeRayTracingShaderGroupCreateInfoKhr = 1000150016,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        StructureTypeRayTracingShaderGroupCreateInfoNv = 1000165011,
        /// <summary>[requires: <b>VK_KHR_object_refresh</b>] </summary>
        StructureTypeRefreshObjectListKhr = 1000308000,
        /// <summary>[requires: <b>VK_KHR_pipeline_binary</b>] </summary>
        StructureTypeReleaseCapturedPipelineDataInfoKhr = 1000483005,
        /// <summary>[requires: <b>VK_EXT_swapchain_maintenance1</b>] </summary>
        StructureTypeReleaseSwapchainImagesInfoExt = 1000275005,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeRenderPassAttachmentBeginInfo = 1000108003,
        /// <summary>[requires: <b>VK_KHR_imageless_framebuffer</b>] </summary>
        StructureTypeRenderPassAttachmentBeginInfoKhr = 1000108003,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeRenderPassBeginInfo = 43,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeRenderPassCreateInfo = 38,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeRenderPassCreateInfo2 = 1000109004,
        /// <summary>[requires: <b>VK_KHR_create_renderpass2</b>] </summary>
        StructureTypeRenderPassCreateInfo2Khr = 1000109004,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        StructureTypeRenderPassCreationControlExt = 1000458001,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        StructureTypeRenderPassCreationFeedbackCreateInfoExt = 1000458002,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        StructureTypeRenderPassFragmentDensityMapCreateInfoExt = 1000218002,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map_offset</b>] </summary>
        StructureTypeRenderPassFragmentDensityMapOffsetEndInfoExt = 1000425002,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeRenderPassInputAttachmentAspectCreateInfo = 1000117001,
        /// <summary>[requires: <b>VK_KHR_maintenance2</b>] </summary>
        StructureTypeRenderPassInputAttachmentAspectCreateInfoKhr = 1000117001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeRenderPassMultiviewCreateInfo = 1000053000,
        /// <summary>[requires: <b>VK_KHR_multiview</b>] </summary>
        StructureTypeRenderPassMultiviewCreateInfoKhr = 1000053000,
        /// <summary>[requires: <b>VK_EXT_sample_locations</b>] </summary>
        StructureTypeRenderPassSampleLocationsBeginInfoExt = 1000143001,
        /// <summary>[requires: <b>VK_ARM_render_pass_striped</b>] </summary>
        StructureTypeRenderPassStripeBeginInfoArm = 1000424002,
        /// <summary>[requires: <b>VK_ARM_render_pass_striped</b>] </summary>
        StructureTypeRenderPassStripeInfoArm = 1000424003,
        /// <summary>[requires: <b>VK_ARM_render_pass_striped</b>] </summary>
        StructureTypeRenderPassStripeSubmitInfoArm = 1000424004,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        StructureTypeRenderPassSubpassFeedbackCreateInfoExt = 1000458003,
        /// <summary>[requires: <b>VK_QCOM_tile_shading</b>] </summary>
        StructureTypeRenderPassTileShadingCreateInfoQcom = 1000309002,
        /// <summary>[requires: <b>VK_QCOM_render_pass_transform</b>] </summary>
        StructureTypeRenderPassTransformBeginInfoQcom = 1000282001,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeRenderingAreaInfo = 1000470003,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        StructureTypeRenderingAreaInfoKhr = 1000470003,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeRenderingAttachmentInfo = 1000044001,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering</b>] </summary>
        StructureTypeRenderingAttachmentInfoKhr = 1000044001,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeRenderingAttachmentLocationInfo = 1000232001,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering_local_read</b>] </summary>
        StructureTypeRenderingAttachmentLocationInfoKhr = 1000232001,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map_offset</b>] </summary>
        StructureTypeRenderingEndInfoExt = 1000619003,
        /// <summary>[requires: <b>VK_EXT_fragment_density_map</b>] </summary>
        StructureTypeRenderingFragmentDensityMapAttachmentInfoExt = 1000044007,
        /// <summary>[requires: <b>VK_KHR_fragment_shading_rate</b>] </summary>
        StructureTypeRenderingFragmentShadingRateAttachmentInfoKhr = 1000044006,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeRenderingInfo = 1000044000,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering</b>] </summary>
        StructureTypeRenderingInfoKhr = 1000044000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeRenderingInputAttachmentIndexInfo = 1000232002,
        /// <summary>[requires: <b>VK_KHR_dynamic_rendering_local_read</b>] </summary>
        StructureTypeRenderingInputAttachmentIndexInfoKhr = 1000232002,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeResolveImageInfo2 = 1000337005,
        /// <summary>[requires: <b>VK_KHR_copy_commands2</b>] </summary>
        StructureTypeResolveImageInfo2Khr = 1000337005,
        /// <summary>[requires: <b>VK_EXT_sample_locations</b>] </summary>
        StructureTypeSampleLocationsInfoExt = 1000143000,
        /// <summary>[requires: <b>VK_QCOM_image_processing2</b>] </summary>
        StructureTypeSamplerBlockMatchWindowCreateInfoQcom = 1000518002,
        /// <summary>[requires: <b>VK_EXT_border_color_swizzle</b>] </summary>
        StructureTypeSamplerBorderColorComponentMappingCreateInfoExt = 1000411001,
        /// <summary>[requires: <b>VK_EXT_descriptor_buffer</b>] </summary>
        StructureTypeSamplerCaptureDescriptorDataInfoExt = 1000316008,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeSamplerCreateInfo = 31,
        /// <summary>[requires: <b>VK_QCOM_filter_cubic_weights</b>] </summary>
        StructureTypeSamplerCubicWeightsCreateInfoQcom = 1000519000,
        /// <summary>[requires: <b>VK_EXT_custom_border_color</b>] </summary>
        StructureTypeSamplerCustomBorderColorCreateInfoExt = 1000287000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeSamplerReductionModeCreateInfo = 1000130001,
        /// <summary>[requires: <b>VK_EXT_sampler_filter_minmax</b>] </summary>
        StructureTypeSamplerReductionModeCreateInfoExt = 1000130001,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeSamplerYcbcrConversionCreateInfo = 1000156000,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        StructureTypeSamplerYcbcrConversionCreateInfoKhr = 1000156000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeSamplerYcbcrConversionImageFormatProperties = 1000156005,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        StructureTypeSamplerYcbcrConversionImageFormatPropertiesKhr = 1000156005,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeSamplerYcbcrConversionInfo = 1000156001,
        /// <summary>[requires: <b>VK_KHR_sampler_ycbcr_conversion</b>] </summary>
        StructureTypeSamplerYcbcrConversionInfoKhr = 1000156001,
        /// <summary>[requires: <b>VK_QCOM_ycbcr_degamma</b>] </summary>
        StructureTypeSamplerYcbcrConversionYcbcrDegammaCreateInfoQcom = 1000520001,
        /// <summary>[requires: <b>VK_NV_external_sci_sync | VK_NV_external_sci_sync2</b>] </summary>
        StructureTypeSciSyncAttributesInfoNv = 1000373003,
        /// <summary>[requires: <b>VK_QNX_external_memory_screen_buffer</b>] </summary>
        StructureTypeScreenBufferFormatPropertiesQnx = 1000529001,
        /// <summary>[requires: <b>VK_QNX_external_memory_screen_buffer</b>] </summary>
        StructureTypeScreenBufferPropertiesQnx = 1000529000,
        /// <summary>[requires: <b>VK_QNX_screen_surface</b>] </summary>
        StructureTypeScreenSurfaceCreateInfoQnx = 1000378000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeSemaphoreCreateInfo = 9,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_fd</b>] </summary>
        StructureTypeSemaphoreGetFdInfoKhr = 1000079001,
        /// <summary>[requires: <b>VK_NV_external_sci_sync</b>] </summary>
        StructureTypeSemaphoreGetSciSyncInfoNv = 1000373006,
        /// <summary>[requires: <b>VK_KHR_external_semaphore_win32</b>] </summary>
        StructureTypeSemaphoreGetWin32HandleInfoKhr = 1000078003,
        /// <summary>[requires: <b>VK_FUCHSIA_external_semaphore</b>] </summary>
        StructureTypeSemaphoreGetZirconHandleInfoFuchsia = 1000365001,
        /// <summary>[requires: <b>VK_NV_external_sci_sync2</b>] </summary>
        StructureTypeSemaphoreSciSyncCreateInfoNv = 1000489001,
        /// <summary>[requires: <b>VK_NV_external_sci_sync2</b>] </summary>
        StructureTypeSemaphoreSciSyncPoolCreateInfoNv = 1000489000,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeSemaphoreSignalInfo = 1000207005,
        /// <summary>[requires: <b>VK_KHR_timeline_semaphore</b>] </summary>
        StructureTypeSemaphoreSignalInfoKhr = 1000207005,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeSemaphoreSubmitInfo = 1000314005,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        StructureTypeSemaphoreSubmitInfoKhr = 1000314005,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeSemaphoreTypeCreateInfo = 1000207002,
        /// <summary>[requires: <b>VK_KHR_timeline_semaphore</b>] </summary>
        StructureTypeSemaphoreTypeCreateInfoKhr = 1000207002,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeSemaphoreWaitInfo = 1000207004,
        /// <summary>[requires: <b>VK_KHR_timeline_semaphore</b>] </summary>
        StructureTypeSemaphoreWaitInfoKhr = 1000207004,
        /// <summary>[requires: <b>VK_KHR_maintenance6</b>] </summary>
        StructureTypeSetDescriptorBufferOffsetsInfoExt = 1000545007,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        StructureTypeSetLatencyMarkerInfoNv = 1000505002,
        /// <summary>[requires: <b>VK_NV_present_metering</b>] </summary>
        StructureTypeSetPresentConfigNv = 1000613000,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        StructureTypeShaderCreateInfoExt = 1000482002,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeShaderModuleCreateInfo = 16,
        /// <summary>[requires: <b>VK_EXT_shader_module_identifier</b>] </summary>
        StructureTypeShaderModuleIdentifierExt = 1000462003,
        /// <summary>[requires: <b>VK_EXT_validation_cache</b>] </summary>
        StructureTypeShaderModuleValidationCacheCreateInfoExt = 1000160001,
        /// <summary>[requires: <b>VK_EXT_shader_object</b>] </summary>
        StructureTypeShaderRequiredSubgroupSizeCreateInfoExt = 1000225001,
        /// <summary>[requires: <b>VK_KHR_shared_presentable_image</b>] </summary>
        StructureTypeSharedPresentSurfaceCapabilitiesKhr = 1000111000,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeSparseImageFormatProperties2 = 1000059007,
        /// <summary>[requires: <b>VK_KHR_get_physical_device_properties2</b>] </summary>
        StructureTypeSparseImageFormatProperties2Khr = 1000059007,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        StructureTypeSparseImageMemoryRequirements2 = 1000146004,
        /// <summary>[requires: <b>VK_KHR_get_memory_requirements2</b>] </summary>
        StructureTypeSparseImageMemoryRequirements2Khr = 1000146004,
        /// <summary>[requires: <b>VK_GGP_stream_descriptor_surface</b>] </summary>
        StructureTypeStreamDescriptorSurfaceCreateInfoGgp = 1000049000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeSubmitInfo = 4,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeSubmitInfo2 = 1000314004,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        StructureTypeSubmitInfo2Khr = 1000314004,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeSubpassBeginInfo = 1000109005,
        /// <summary>[requires: <b>VK_KHR_create_renderpass2</b>] </summary>
        StructureTypeSubpassBeginInfoKhr = 1000109005,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeSubpassDependency2 = 1000109003,
        /// <summary>[requires: <b>VK_KHR_create_renderpass2</b>] </summary>
        StructureTypeSubpassDependency2Khr = 1000109003,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeSubpassDescription2 = 1000109002,
        /// <summary>[requires: <b>VK_KHR_create_renderpass2</b>] </summary>
        StructureTypeSubpassDescription2Khr = 1000109002,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeSubpassDescriptionDepthStencilResolve = 1000199001,
        /// <summary>[requires: <b>VK_KHR_depth_stencil_resolve</b>] </summary>
        StructureTypeSubpassDescriptionDepthStencilResolveKhr = 1000199001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeSubpassEndInfo = 1000109006,
        /// <summary>[requires: <b>VK_KHR_create_renderpass2</b>] </summary>
        StructureTypeSubpassEndInfoKhr = 1000109006,
        /// <summary>[requires: <b>VK_QCOM_fragment_density_map_offset</b>] </summary>
        StructureTypeSubpassFragmentDensityMapOffsetEndInfoQcom = 1000425002,
        /// <summary>[requires: <b>VK_EXT_multisampled_render_to_single_sampled</b>] </summary>
        StructureTypeSubpassResolvePerformanceQueryExt = 1000376001,
        /// <summary>[requires: <b>VK_HUAWEI_subpass_shading</b>] </summary>
        StructureTypeSubpassShadingPipelineCreateInfoHuawei = 1000369000,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeSubresourceHostMemcpySize = 1000270008,
        /// <summary>[requires: <b>VK_EXT_host_image_copy</b>] </summary>
        StructureTypeSubresourceHostMemcpySizeExt = 1000270008,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        StructureTypeSubresourceLayout2 = 1000338002,
        /// <summary>[requires: <b>VK_EXT_image_compression_control</b>] </summary>
        StructureTypeSubresourceLayout2Ext = 1000338002,
        /// <summary>[requires: <b>VK_KHR_maintenance5</b>] </summary>
        StructureTypeSubresourceLayout2Khr = 1000338002,
        /// <summary>[requires: <b>VK_EXT_display_surface_counter</b>] </summary>
        StructureTypeSurfaceCapabilities2Ext = 1000090000,
        /// <summary>[requires: <b>VK_KHR_get_surface_capabilities2</b>] </summary>
        StructureTypeSurfaceCapabilities2Khr = 1000119001,
        /// <summary>[requires: <b>VK_EXT_full_screen_exclusive</b>] </summary>
        StructureTypeSurfaceCapabilitiesFullScreenExclusiveExt = 1000255002,
        /// <summary>[requires: <b>VK_NV_present_barrier</b>] </summary>
        StructureTypeSurfaceCapabilitiesPresentBarrierNv = 1000292001,
        /// <summary>[requires: <b>VK_KHR_get_surface_capabilities2</b>] </summary>
        StructureTypeSurfaceFormat2Khr = 1000119002,
        /// <summary>[requires: <b>VK_EXT_full_screen_exclusive</b>] </summary>
        StructureTypeSurfaceFullScreenExclusiveInfoExt = 1000255000,
        /// <summary>[requires: <b>VK_EXT_full_screen_exclusive</b>] </summary>
        StructureTypeSurfaceFullScreenExclusiveWin32InfoExt = 1000255001,
        /// <summary>[requires: <b>VK_EXT_surface_maintenance1</b>] </summary>
        StructureTypeSurfacePresentModeCompatibilityExt = 1000274002,
        /// <summary>[requires: <b>VK_EXT_surface_maintenance1</b>] </summary>
        StructureTypeSurfacePresentModeExt = 1000274000,
        /// <summary>[requires: <b>VK_EXT_surface_maintenance1</b>] </summary>
        StructureTypeSurfacePresentScalingCapabilitiesExt = 1000274001,
        /// <summary>[requires: <b>VK_KHR_surface_protected_capabilities</b>] </summary>
        StructureTypeSurfaceProtectedCapabilitiesKhr = 1000239000,
        /// <summary>[requires: <b>VK_EXT_display_control</b>] </summary>
        StructureTypeSwapchainCounterCreateInfoExt = 1000091003,
        /// <summary>[requires: <b>VK_KHR_swapchain</b>] </summary>
        StructureTypeSwapchainCreateInfoKhr = 1000001000,
        /// <summary>[requires: <b>VK_AMD_display_native_hdr</b>] </summary>
        StructureTypeSwapchainDisplayNativeHdrCreateInfoAmd = 1000213001,
        /// <summary>[requires: <b>VK_NV_low_latency2</b>] </summary>
        StructureTypeSwapchainLatencyCreateInfoNv = 1000505007,
        /// <summary>[requires: <b>VK_NV_present_barrier</b>] </summary>
        StructureTypeSwapchainPresentBarrierCreateInfoNv = 1000292002,
        /// <summary>[requires: <b>VK_EXT_swapchain_maintenance1</b>] </summary>
        StructureTypeSwapchainPresentFenceInfoExt = 1000275001,
        /// <summary>[requires: <b>VK_EXT_swapchain_maintenance1</b>] </summary>
        StructureTypeSwapchainPresentModeInfoExt = 1000275003,
        /// <summary>[requires: <b>VK_EXT_swapchain_maintenance1</b>] </summary>
        StructureTypeSwapchainPresentModesCreateInfoExt = 1000275002,
        /// <summary>[requires: <b>VK_EXT_swapchain_maintenance1</b>] </summary>
        StructureTypeSwapchainPresentScalingCreateInfoExt = 1000275004,
        /// <summary>[requires: <b>VK_FUCHSIA_buffer_collection</b>] </summary>
        StructureTypeSysmemColorSpaceFuchsia = 1000366008,
        /// <summary>[requires: <b>VK_AMD_texture_gather_bias_lod</b>] </summary>
        StructureTypeTextureLodGatherFormatPropertiesAmd = 1000041000,
        /// <summary>[requires: <b>VK_QCOM_tile_properties</b>] </summary>
        StructureTypeTilePropertiesQcom = 1000484001,
        /// <summary>[requires: <b>v1.2</b>] </summary>
        StructureTypeTimelineSemaphoreSubmitInfo = 1000207003,
        /// <summary>[requires: <b>VK_KHR_timeline_semaphore</b>] </summary>
        StructureTypeTimelineSemaphoreSubmitInfoKhr = 1000207003,
        /// <summary>[requires: <b>VK_EXT_validation_cache</b>] </summary>
        StructureTypeValidationCacheCreateInfoExt = 1000160000,
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        StructureTypeValidationFeaturesExt = 1000247000,
        /// <summary>[requires: <b>VK_EXT_validation_flags</b>] </summary>
        StructureTypeValidationFlagsExt = 1000061000,
        /// <summary>[requires: <b>VK_EXT_vertex_input_dynamic_state | VK_EXT_shader_object</b>] </summary>
        StructureTypeVertexInputAttributeDescription2Ext = 1000352002,
        /// <summary>[requires: <b>VK_EXT_vertex_input_dynamic_state | VK_EXT_shader_object</b>] </summary>
        StructureTypeVertexInputBindingDescription2Ext = 1000352001,
        /// <summary>[requires: <b>VK_NN_vi_surface</b>] </summary>
        StructureTypeViSurfaceCreateInfoNn = 1000062000,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoBeginCodingInfoKhr = 1000023008,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoCapabilitiesKhr = 1000023001,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoCodingControlInfoKhr = 1000023010,
        /// <summary>[requires: <b>VK_KHR_video_decode_av1</b>] </summary>
        StructureTypeVideoDecodeAv1CapabilitiesKhr = 1000512000,
        /// <summary>[requires: <b>VK_KHR_video_decode_av1</b>] </summary>
        StructureTypeVideoDecodeAv1DpbSlotInfoKhr = 1000512005,
        /// <summary>[requires: <b>VK_KHR_video_maintenance2</b>] </summary>
        StructureTypeVideoDecodeAv1InlineSessionParametersInfoKhr = 1000586003,
        /// <summary>[requires: <b>VK_KHR_video_decode_av1</b>] </summary>
        StructureTypeVideoDecodeAv1PictureInfoKhr = 1000512001,
        /// <summary>[requires: <b>VK_KHR_video_decode_av1</b>] </summary>
        StructureTypeVideoDecodeAv1ProfileInfoKhr = 1000512003,
        /// <summary>[requires: <b>VK_KHR_video_decode_av1</b>] </summary>
        StructureTypeVideoDecodeAv1SessionParametersCreateInfoKhr = 1000512004,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        StructureTypeVideoDecodeCapabilitiesKhr = 1000024001,
        /// <summary>[requires: <b>VK_KHR_video_decode_h264</b>] </summary>
        StructureTypeVideoDecodeH264CapabilitiesKhr = 1000040000,
        /// <summary>[requires: <b>VK_KHR_video_decode_h264</b>] </summary>
        StructureTypeVideoDecodeH264DpbSlotInfoKhr = 1000040006,
        /// <summary>[requires: <b>VK_KHR_video_maintenance2</b>] </summary>
        StructureTypeVideoDecodeH264InlineSessionParametersInfoKhr = 1000586001,
        /// <summary>[requires: <b>VK_KHR_video_decode_h264</b>] </summary>
        StructureTypeVideoDecodeH264PictureInfoKhr = 1000040001,
        /// <summary>[requires: <b>VK_KHR_video_decode_h264</b>] </summary>
        StructureTypeVideoDecodeH264ProfileInfoKhr = 1000040003,
        /// <summary>[requires: <b>VK_KHR_video_decode_h264</b>] </summary>
        StructureTypeVideoDecodeH264SessionParametersAddInfoKhr = 1000040005,
        /// <summary>[requires: <b>VK_KHR_video_decode_h264</b>] </summary>
        StructureTypeVideoDecodeH264SessionParametersCreateInfoKhr = 1000040004,
        /// <summary>[requires: <b>VK_KHR_video_decode_h265</b>] </summary>
        StructureTypeVideoDecodeH265CapabilitiesKhr = 1000187000,
        /// <summary>[requires: <b>VK_KHR_video_decode_h265</b>] </summary>
        StructureTypeVideoDecodeH265DpbSlotInfoKhr = 1000187005,
        /// <summary>[requires: <b>VK_KHR_video_maintenance2</b>] </summary>
        StructureTypeVideoDecodeH265InlineSessionParametersInfoKhr = 1000586002,
        /// <summary>[requires: <b>VK_KHR_video_decode_h265</b>] </summary>
        StructureTypeVideoDecodeH265PictureInfoKhr = 1000187004,
        /// <summary>[requires: <b>VK_KHR_video_decode_h265</b>] </summary>
        StructureTypeVideoDecodeH265ProfileInfoKhr = 1000187003,
        /// <summary>[requires: <b>VK_KHR_video_decode_h265</b>] </summary>
        StructureTypeVideoDecodeH265SessionParametersAddInfoKhr = 1000187002,
        /// <summary>[requires: <b>VK_KHR_video_decode_h265</b>] </summary>
        StructureTypeVideoDecodeH265SessionParametersCreateInfoKhr = 1000187001,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        StructureTypeVideoDecodeInfoKhr = 1000024000,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        StructureTypeVideoDecodeUsageInfoKhr = 1000024002,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        StructureTypeVideoEncodeAv1CapabilitiesKhr = 1000513000,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        StructureTypeVideoEncodeAv1DpbSlotInfoKhr = 1000513003,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        StructureTypeVideoEncodeAv1GopRemainingFrameInfoKhr = 1000513010,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        StructureTypeVideoEncodeAv1PictureInfoKhr = 1000513002,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        StructureTypeVideoEncodeAv1ProfileInfoKhr = 1000513005,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        StructureTypeVideoEncodeAv1QualityLevelPropertiesKhr = 1000513008,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        StructureTypeVideoEncodeAv1QuantizationMapCapabilitiesKhr = 1000553007,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        StructureTypeVideoEncodeAv1RateControlInfoKhr = 1000513006,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        StructureTypeVideoEncodeAv1RateControlLayerInfoKhr = 1000513007,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        StructureTypeVideoEncodeAv1SessionCreateInfoKhr = 1000513009,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        StructureTypeVideoEncodeAv1SessionParametersCreateInfoKhr = 1000513001,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        StructureTypeVideoEncodeCapabilitiesKhr = 1000299003,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264CapabilitiesKhr = 1000038000,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264DpbSlotInfoKhr = 1000038004,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264GopRemainingFrameInfoKhr = 1000038006,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264NaluSliceInfoKhr = 1000038005,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264PictureInfoKhr = 1000038003,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264ProfileInfoKhr = 1000038007,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264QualityLevelPropertiesKhr = 1000038011,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        StructureTypeVideoEncodeH264QuantizationMapCapabilitiesKhr = 1000553003,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264RateControlInfoKhr = 1000038008,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264RateControlLayerInfoKhr = 1000038009,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264SessionCreateInfoKhr = 1000038010,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264SessionParametersAddInfoKhr = 1000038002,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264SessionParametersCreateInfoKhr = 1000038001,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264SessionParametersFeedbackInfoKhr = 1000038013,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        StructureTypeVideoEncodeH264SessionParametersGetInfoKhr = 1000038012,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265CapabilitiesKhr = 1000039000,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265DpbSlotInfoKhr = 1000039004,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265GopRemainingFrameInfoKhr = 1000039006,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265NaluSliceSegmentInfoKhr = 1000039005,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265PictureInfoKhr = 1000039003,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265ProfileInfoKhr = 1000039007,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265QualityLevelPropertiesKhr = 1000039012,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        StructureTypeVideoEncodeH265QuantizationMapCapabilitiesKhr = 1000553004,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265RateControlInfoKhr = 1000039009,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265RateControlLayerInfoKhr = 1000039010,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265SessionCreateInfoKhr = 1000039011,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265SessionParametersAddInfoKhr = 1000039002,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265SessionParametersCreateInfoKhr = 1000039001,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265SessionParametersFeedbackInfoKhr = 1000039014,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        StructureTypeVideoEncodeH265SessionParametersGetInfoKhr = 1000039013,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        StructureTypeVideoEncodeInfoKhr = 1000299000,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        StructureTypeVideoEncodeQualityLevelInfoKhr = 1000299008,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        StructureTypeVideoEncodeQualityLevelPropertiesKhr = 1000299007,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        StructureTypeVideoEncodeQuantizationMapCapabilitiesKhr = 1000553000,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        StructureTypeVideoEncodeQuantizationMapInfoKhr = 1000553002,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        StructureTypeVideoEncodeQuantizationMapSessionParametersCreateInfoKhr = 1000553005,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        StructureTypeVideoEncodeRateControlInfoKhr = 1000299001,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        StructureTypeVideoEncodeRateControlLayerInfoKhr = 1000299002,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        StructureTypeVideoEncodeSessionParametersFeedbackInfoKhr = 1000299010,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        StructureTypeVideoEncodeSessionParametersGetInfoKhr = 1000299009,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        StructureTypeVideoEncodeUsageInfoKhr = 1000299004,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoEndCodingInfoKhr = 1000023009,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        StructureTypeVideoFormatAv1QuantizationMapPropertiesKhr = 1000553008,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        StructureTypeVideoFormatH265QuantizationMapPropertiesKhr = 1000553006,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoFormatPropertiesKhr = 1000023015,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        StructureTypeVideoFormatQuantizationMapPropertiesKhr = 1000553001,
        /// <summary>[requires: <b>VK_KHR_video_maintenance1</b>] </summary>
        StructureTypeVideoInlineQueryInfoKhr = 1000515001,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoPictureResourceInfoKhr = 1000023002,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoProfileInfoKhr = 1000023000,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoProfileListInfoKhr = 1000023013,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoReferenceSlotInfoKhr = 1000023011,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoSessionCreateInfoKhr = 1000023005,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoSessionMemoryRequirementsKhr = 1000023003,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoSessionParametersCreateInfoKhr = 1000023006,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        StructureTypeVideoSessionParametersUpdateInfoKhr = 1000023007,
        /// <summary>[requires: <b>VK_KHR_wayland_surface</b>] </summary>
        StructureTypeWaylandSurfaceCreateInfoKhr = 1000006000,
        /// <summary>[requires: <b>VK_KHR_win32_keyed_mutex</b>] </summary>
        StructureTypeWin32KeyedMutexAcquireReleaseInfoKhr = 1000075000,
        /// <summary>[requires: <b>VK_NV_win32_keyed_mutex</b>] </summary>
        StructureTypeWin32KeyedMutexAcquireReleaseInfoNv = 1000058000,
        /// <summary>[requires: <b>VK_KHR_win32_surface</b>] </summary>
        StructureTypeWin32SurfaceCreateInfoKhr = 1000009000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        StructureTypeWriteDescriptorSet = 35,
        /// <summary>[requires: <b>VK_KHR_acceleration_structure</b>] </summary>
        StructureTypeWriteDescriptorSetAccelerationStructureKhr = 1000150007,
        /// <summary>[requires: <b>VK_NV_ray_tracing</b>] </summary>
        StructureTypeWriteDescriptorSetAccelerationStructureNv = 1000165007,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        StructureTypeWriteDescriptorSetInlineUniformBlock = 1000138002,
        /// <summary>[requires: <b>VK_EXT_inline_uniform_block</b>] </summary>
        StructureTypeWriteDescriptorSetInlineUniformBlockExt = 1000138002,
        /// <summary>[requires: <b>VK_NV_partitioned_acceleration_structure</b>] </summary>
        StructureTypeWriteDescriptorSetPartitionedAccelerationStructureNv = 1000570002,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypeWriteIndirectExecutionSetPipelineExt = 1000572008,
        /// <summary>[requires: <b>VK_EXT_device_generated_commands</b>] </summary>
        StructureTypeWriteIndirectExecutionSetShaderExt = 1000572009,
        /// <summary>[requires: <b>VK_KHR_xcb_surface</b>] </summary>
        StructureTypeXcbSurfaceCreateInfoKhr = 1000005000,
        /// <summary>[requires: <b>VK_KHR_xlib_surface</b>] </summary>
        StructureTypeXlibSurfaceCreateInfoKhr = 1000004000,
    }
    /// <summary><b>[requires: v1.1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSubgroupFeatureFlagBits.html" /></remarks>
    [Flags]
    public enum VkSubgroupFeatureFlagBits : uint
    {
        /// <summary>[requires: <b>v1.1</b>] Arithmetic subgroup operations</summary>
        SubgroupFeatureArithmeticBit = 4,
        /// <summary>[requires: <b>v1.1</b>] Ballot subgroup operations</summary>
        SubgroupFeatureBallotBit = 8,
        /// <summary>[requires: <b>v1.1</b>] Basic subgroup operations</summary>
        SubgroupFeatureBasicBit = 1,
        /// <summary>[requires: <b>v1.1</b>] Clustered subgroup operations</summary>
        SubgroupFeatureClusteredBit = 64,
        /// <summary>[requires: <b>VK_NV_shader_subgroup_partitioned</b>] </summary>
        SubgroupFeaturePartitionedBitNv = 256,
        /// <summary>[requires: <b>v1.1</b>] Quad subgroup operations</summary>
        SubgroupFeatureQuadBit = 128,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        SubgroupFeatureRotateBit = 512,
        /// <summary>[requires: <b>VK_KHR_shader_subgroup_rotate</b>] </summary>
        SubgroupFeatureRotateBitKhr = 512,
        /// <summary>[requires: <b>v1.4</b>] </summary>
        SubgroupFeatureRotateClusteredBit = 1024,
        /// <summary>[requires: <b>VK_KHR_shader_subgroup_rotate</b>] </summary>
        SubgroupFeatureRotateClusteredBitKhr = 1024,
        /// <summary>[requires: <b>v1.1</b>] Shuffle subgroup operations</summary>
        SubgroupFeatureShuffleBit = 16,
        /// <summary>[requires: <b>v1.1</b>] Shuffle relative subgroup operations</summary>
        SubgroupFeatureShuffleRelativeBit = 32,
        /// <summary>[requires: <b>v1.1</b>] Vote subgroup operations</summary>
        SubgroupFeatureVoteBit = 2,
    }
    /// <summary><b>[requires: v1.3]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSubmitFlagBits.html" /></remarks>
    [Flags]
    public enum VkSubmitFlagBits : uint
    {
        /// <summary>[requires: <b>v1.3</b>] </summary>
        SubmitProtectedBit = 1,
        /// <summary>[requires: <b>VK_KHR_synchronization2</b>] </summary>
        SubmitProtectedBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_synchronization2]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSubmitFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkSubmitFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: v1.0]</b> Used by <see cref="Vk.CmdBeginRenderPass"/>, <see cref="Vk.CmdNextSubpass"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSubpassContents.html" /></remarks>
    public enum VkSubpassContents : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SubpassContentsInline = 0,
        /// <summary>[requires: <b>VK_EXT_nested_command_buffer</b>] </summary>
        SubpassContentsInlineAndSecondaryCommandBuffersExt = 1000451000,
        /// <summary>[requires: <b>VK_KHR_maintenance7</b>] </summary>
        SubpassContentsInlineAndSecondaryCommandBuffersKhr = 1000451000,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SubpassContentsSecondaryCommandBuffers = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSubpassDescriptionFlagBits.html" /></remarks>
    [Flags]
    public enum VkSubpassDescriptionFlagBits : uint
    {
        /// <summary>[requires: <b>VK_EXT_legacy_dithering</b>] </summary>
        SubpassDescriptionEnableLegacyDitheringBitExt = 128,
        /// <summary>[requires: <b>VK_QCOM_render_pass_shader_resolve</b>] </summary>
        SubpassDescriptionFragmentRegionBitQcom = 4,
        /// <summary>[requires: <b>VK_NVX_multiview_per_view_attributes</b>] </summary>
        SubpassDescriptionPerViewAttributesBitNvx = 1,
        /// <summary>[requires: <b>VK_NVX_multiview_per_view_attributes</b>] </summary>
        SubpassDescriptionPerViewPositionXOnlyBitNvx = 2,
        /// <summary>[requires: <b>VK_ARM_rasterization_order_attachment_access</b>] </summary>
        SubpassDescriptionRasterizationOrderAttachmentColorAccessBitArm = 16,
        /// <summary>[requires: <b>VK_EXT_rasterization_order_attachment_access</b>] </summary>
        SubpassDescriptionRasterizationOrderAttachmentColorAccessBitExt = 16,
        /// <summary>[requires: <b>VK_ARM_rasterization_order_attachment_access</b>] </summary>
        SubpassDescriptionRasterizationOrderAttachmentDepthAccessBitArm = 32,
        /// <summary>[requires: <b>VK_EXT_rasterization_order_attachment_access</b>] </summary>
        SubpassDescriptionRasterizationOrderAttachmentDepthAccessBitExt = 32,
        /// <summary>[requires: <b>VK_ARM_rasterization_order_attachment_access</b>] </summary>
        SubpassDescriptionRasterizationOrderAttachmentStencilAccessBitArm = 64,
        /// <summary>[requires: <b>VK_EXT_rasterization_order_attachment_access</b>] </summary>
        SubpassDescriptionRasterizationOrderAttachmentStencilAccessBitExt = 64,
        /// <summary>[requires: <b>VK_QCOM_render_pass_shader_resolve</b>] </summary>
        SubpassDescriptionShaderResolveBitQcom = 8,
        /// <summary>[requires: <b>VK_QCOM_tile_shading</b>] </summary>
        SubpassDescriptionTileShadingApronBitQcom = 256,
    }
    /// <summary><b>[requires: VK_EXT_subpass_merge_feedback]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSubpassMergeStatusEXT.html" /></remarks>
    public enum VkSubpassMergeStatusEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusDisallowedExt = 1,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusMergedExt = 0,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusNotMergedAliasingExt = 5,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusNotMergedDependenciesExt = 6,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusNotMergedDepthStencilCountExt = 10,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusNotMergedIncompatibleInputAttachmentExt = 7,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusNotMergedInsufficientStorageExt = 9,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusNotMergedResolveAttachmentReuseExt = 11,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusNotMergedSamplesMismatchExt = 3,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusNotMergedSideEffectsExt = 2,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusNotMergedSingleSubpassExt = 12,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusNotMergedTooManyAttachmentsExt = 8,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusNotMergedUnspecifiedExt = 13,
        /// <summary>[requires: <b>VK_EXT_subpass_merge_feedback</b>] </summary>
        SubpassMergeStatusNotMergedViewsMismatchExt = 4,
    }
    /// <summary><b>[requires: VK_EXT_display_surface_counter]</b> Used by <see cref="Vk.GetSwapchainCounterEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSurfaceCounterFlagBitsEXT.html" /></remarks>
    [Flags]
    public enum VkSurfaceCounterFlagBitsEXT : uint
    {
        /// <summary>[requires: <b>VK_EXT_display_surface_counter</b>] </summary>
        SurfaceCounterVblankBitExt = 1,
        /// <summary>[requires: <b>VK_EXT_display_surface_counter</b>] </summary>
        SurfaceCounterVblankExt = 1,
    }
    /// <summary><b>[requires: VK_KHR_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSurfaceTransformFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkSurfaceTransformFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        SurfaceTransformHorizontalMirrorBitKhr = 16,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        SurfaceTransformHorizontalMirrorRotate180BitKhr = 64,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        SurfaceTransformHorizontalMirrorRotate270BitKhr = 128,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        SurfaceTransformHorizontalMirrorRotate90BitKhr = 32,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        SurfaceTransformIdentityBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        SurfaceTransformInheritBitKhr = 256,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        SurfaceTransformRotate180BitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        SurfaceTransformRotate270BitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_surface</b>] </summary>
        SurfaceTransformRotate90BitKhr = 2,
    }
    /// <summary><b>[requires: VK_KHR_swapchain]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSwapchainCreateFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkSwapchainCreateFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_EXT_swapchain_maintenance1</b>] </summary>
        SwapchainCreateDeferredMemoryAllocationBitExt = 8,
        /// <summary>[requires: <b>VK_KHR_swapchain_mutable_format</b>] </summary>
        SwapchainCreateMutableFormatBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_swapchain</b>] Swapchain is protected</summary>
        SwapchainCreateProtectedBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_swapchain | VK_KHR_device_group</b>] Allow images with VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT</summary>
        SwapchainCreateSplitInstanceBindRegionsBitKhr = 1,
    }
    /// <summary>Used by <see cref="Vk.GetSwapchainGrallocUsage2ANDROID"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSwapchainImageUsageFlagBitsANDROID.html" /></remarks>
    [Flags]
    public enum VkSwapchainImageUsageFlagBitsANDROID : uint
    {
        /// <summary></summary>
        SwapchainImageUsageSharedBitAndroid = 1,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkSystemAllocationScope.html" /></remarks>
    public enum VkSystemAllocationScope : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SystemAllocationScopeCache = 2,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SystemAllocationScopeCommand = 0,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SystemAllocationScopeDevice = 3,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SystemAllocationScopeInstance = 4,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        SystemAllocationScopeObject = 1,
    }
    /// <summary><b>[requires: v1.1]</b> Used by <see cref="Vk.CmdSetTessellationDomainOriginEXT"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkTessellationDomainOrigin.html" /></remarks>
    public enum VkTessellationDomainOrigin : int
    {
        /// <summary>[requires: <b>v1.1</b>] </summary>
        TessellationDomainOriginLowerLeft = 1,
        /// <summary>[requires: <b>VK_KHR_maintenance2</b>] </summary>
        TessellationDomainOriginLowerLeftKhr = 1,
        /// <summary>[requires: <b>v1.1</b>] </summary>
        TessellationDomainOriginUpperLeft = 0,
        /// <summary>[requires: <b>VK_KHR_maintenance2</b>] </summary>
        TessellationDomainOriginUpperLeftKhr = 0,
    }
    /// <summary><b>[requires: VK_QCOM_tile_shading]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkTileShadingRenderPassFlagBitsQCOM.html" /></remarks>
    [Flags]
    public enum VkTileShadingRenderPassFlagBitsQCOM : uint
    {
        /// <summary>[requires: <b>VK_QCOM_tile_shading</b>] </summary>
        TileShadingRenderPassEnableBitQcom = 1,
        /// <summary>[requires: <b>VK_QCOM_tile_shading</b>] </summary>
        TileShadingRenderPassPerTileExecutionBitQcom = 2,
    }
    /// <summary><b>[requires: VK_KHR_calibrated_timestamps]</b> Used by <see cref="Vk.GetPhysicalDeviceCalibrateableTimeDomainsEXT"/>, <see cref="Vk.GetPhysicalDeviceCalibrateableTimeDomainsKHR"/></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkTimeDomainKHR.html" /></remarks>
    public enum VkTimeDomainKHR : int
    {
        /// <summary>[requires: <b>VK_EXT_calibrated_timestamps</b>] </summary>
        TimeDomainClockMonotonicExt = 1,
        /// <summary>[requires: <b>VK_KHR_calibrated_timestamps</b>] </summary>
        TimeDomainClockMonotonicKhr = 1,
        /// <summary>[requires: <b>VK_EXT_calibrated_timestamps</b>] </summary>
        TimeDomainClockMonotonicRawExt = 2,
        /// <summary>[requires: <b>VK_KHR_calibrated_timestamps</b>] </summary>
        TimeDomainClockMonotonicRawKhr = 2,
        /// <summary>[requires: <b>VK_EXT_calibrated_timestamps</b>] </summary>
        TimeDomainDeviceExt = 0,
        /// <summary>[requires: <b>VK_KHR_calibrated_timestamps</b>] </summary>
        TimeDomainDeviceKhr = 0,
        /// <summary>[requires: <b>VK_EXT_calibrated_timestamps</b>] </summary>
        TimeDomainQueryPerformanceCounterExt = 3,
        /// <summary>[requires: <b>VK_KHR_calibrated_timestamps</b>] </summary>
        TimeDomainQueryPerformanceCounterKhr = 3,
    }
    /// <summary><b>[requires: v1.3]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkToolPurposeFlagBits.html" /></remarks>
    [Flags]
    public enum VkToolPurposeFlagBits : uint
    {
        /// <summary>[requires: <b>v1.3</b>] </summary>
        ToolPurposeAdditionalFeaturesBit = 8,
        /// <summary>[requires: <b>VK_EXT_tooling_info</b>] </summary>
        ToolPurposeAdditionalFeaturesBitExt = 8,
        /// <summary>[requires: <b>VK_EXT_tooling_info | VK_EXT_tooling_info</b>] </summary>
        ToolPurposeDebugMarkersBitExt = 64,
        /// <summary>[requires: <b>VK_EXT_tooling_info | VK_EXT_tooling_info</b>] </summary>
        ToolPurposeDebugReportingBitExt = 32,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        ToolPurposeModifyingFeaturesBit = 16,
        /// <summary>[requires: <b>VK_EXT_tooling_info</b>] </summary>
        ToolPurposeModifyingFeaturesBitExt = 16,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        ToolPurposeProfilingBit = 2,
        /// <summary>[requires: <b>VK_EXT_tooling_info</b>] </summary>
        ToolPurposeProfilingBitExt = 2,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        ToolPurposeTracingBit = 4,
        /// <summary>[requires: <b>VK_EXT_tooling_info</b>] </summary>
        ToolPurposeTracingBitExt = 4,
        /// <summary>[requires: <b>v1.3</b>] </summary>
        ToolPurposeValidationBit = 1,
        /// <summary>[requires: <b>VK_EXT_tooling_info</b>] </summary>
        ToolPurposeValidationBitExt = 1,
    }
    /// <summary><b>[requires: VK_EXT_tooling_info]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkToolPurposeFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkToolPurposeFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_validation_cache]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkValidationCacheCreateFlagsEXT.html" /></remarks>
    [Flags]
    public enum VkValidationCacheCreateFlagsEXT : uint
    {
    }
    /// <summary><b>[requires: VK_EXT_validation_cache]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkValidationCacheHeaderVersionEXT.html" /></remarks>
    public enum VkValidationCacheHeaderVersionEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_validation_cache</b>] </summary>
        ValidationCacheHeaderVersionOneExt = 1,
    }
    /// <summary><b>[requires: VK_EXT_validation_flags]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkValidationCheckEXT.html" /></remarks>
    public enum VkValidationCheckEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_validation_flags</b>] </summary>
        ValidationCheckAllExt = 0,
        /// <summary>[requires: <b>VK_EXT_validation_flags</b>] </summary>
        ValidationCheckShadersExt = 1,
    }
    /// <summary><b>[requires: VK_EXT_validation_features]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkValidationFeatureDisableEXT.html" /></remarks>
    public enum VkValidationFeatureDisableEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureDisableAllExt = 0,
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureDisableApiParametersExt = 3,
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureDisableCoreChecksExt = 5,
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureDisableObjectLifetimesExt = 4,
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureDisableShaderValidationCacheExt = 7,
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureDisableShadersExt = 1,
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureDisableThreadSafetyExt = 2,
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureDisableUniqueHandlesExt = 6,
    }
    /// <summary><b>[requires: VK_EXT_validation_features]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkValidationFeatureEnableEXT.html" /></remarks>
    public enum VkValidationFeatureEnableEXT : int
    {
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureEnableBestPracticesExt = 2,
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureEnableDebugPrintfExt = 3,
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureEnableGpuAssistedExt = 0,
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureEnableGpuAssistedReserveBindingSlotExt = 1,
        /// <summary>[requires: <b>VK_EXT_validation_features</b>] </summary>
        ValidationFeatureEnableSynchronizationValidationExt = 4,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVendorId.html" /></remarks>
    public enum VkVendorId : int
    {
        /// <summary>[requires: <b>v1.0</b>] Codeplay Software Ltd. vendor ID</summary>
        VendorIdCodeplay = 65540,
        /// <summary>[requires: <b>v1.0</b>] Kazan Software Renderer</summary>
        VendorIdKazan = 65539,
        /// <summary>[requires: <b>v1.0</b>] Khronos vendor ID</summary>
        VendorIdKhronos = 65536,
        /// <summary>[requires: <b>v1.0</b>] Mesa vendor ID</summary>
        VendorIdMesa = 65541,
        /// <summary>[requires: <b>v1.0</b>] Mobileye vendor ID</summary>
        VendorIdMobileye = 65543,
        /// <summary>[requires: <b>v1.0</b>] PoCL vendor ID</summary>
        VendorIdPocl = 65542,
        /// <summary>[requires: <b>v1.0</b>] Vivante vendor ID</summary>
        VendorIdViv = 65537,
        /// <summary>[requires: <b>v1.0</b>] VeriSilicon vendor ID</summary>
        VendorIdVsi = 65538,
    }
    /// <summary><b>[requires: v1.0]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVertexInputRate.html" /></remarks>
    public enum VkVertexInputRate : int
    {
        /// <summary>[requires: <b>v1.0</b>] </summary>
        VertexInputRateInstance = 1,
        /// <summary>[requires: <b>v1.0</b>] </summary>
        VertexInputRateVertex = 0,
    }
    /// <summary><b>[requires: VK_KHR_video_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoBeginCodingFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoBeginCodingFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_video_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoCapabilityFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoCapabilityFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoCapabilityProtectedContentBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoCapabilitySeparateReferenceImagesBitKhr = 2,
    }
    /// <summary><b>[requires: VK_KHR_video_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoChromaSubsamplingFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoChromaSubsamplingFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoChromaSubsampling420BitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoChromaSubsampling422BitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoChromaSubsampling444BitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoChromaSubsamplingInvalidKhr = 0,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoChromaSubsamplingMonochromeBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_video_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoCodecOperationFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoCodecOperationFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_decode_av1</b>] </summary>
        VideoCodecOperationDecodeAv1BitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_decode_h264</b>] </summary>
        VideoCodecOperationDecodeH264BitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_decode_h265</b>] </summary>
        VideoCodecOperationDecodeH265BitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoCodecOperationEncodeAv1BitKhr = 262144,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoCodecOperationEncodeH264BitKhr = 65536,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoCodecOperationEncodeH265BitKhr = 131072,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoCodecOperationNoneKhr = 0,
    }
    /// <summary><b>[requires: VK_KHR_video_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoCodingControlFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoCodingControlFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoCodingControlEncodeQualityLevelBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoCodingControlEncodeRateControlBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoCodingControlResetBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_video_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoComponentBitDepthFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoComponentBitDepthFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoComponentBitDepth10BitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoComponentBitDepth12BitKhr = 16,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoComponentBitDepth8BitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoComponentBitDepthInvalidKhr = 0,
    }
    /// <summary><b>[requires: VK_KHR_video_decode_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoDecodeCapabilityFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoDecodeCapabilityFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        VideoDecodeCapabilityDpbAndOutputCoincideBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        VideoDecodeCapabilityDpbAndOutputDistinctBitKhr = 2,
    }
    /// <summary><b>[requires: VK_KHR_video_decode_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoDecodeFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoDecodeFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_video_decode_h264]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoDecodeH264PictureLayoutFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoDecodeH264PictureLayoutFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_decode_h264</b>] </summary>
        VideoDecodeH264PictureLayoutInterlacedInterleavedLinesBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_decode_h264</b>] </summary>
        VideoDecodeH264PictureLayoutInterlacedSeparatePlanesBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_decode_h264</b>] </summary>
        VideoDecodeH264PictureLayoutProgressiveKhr = 0,
    }
    /// <summary><b>[requires: VK_KHR_video_decode_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoDecodeUsageFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoDecodeUsageFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        VideoDecodeUsageDefaultKhr = 0,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        VideoDecodeUsageOfflineBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        VideoDecodeUsageStreamingBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_decode_queue</b>] </summary>
        VideoDecodeUsageTranscodingBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_av1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeAV1CapabilityFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeAV1CapabilityFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1CapabilityFrameSizeOverrideBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1CapabilityGenerateObuExtensionHeaderBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1CapabilityMotionVectorScalingBitKhr = 16,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1CapabilityPerRateControlGroupMinMaxQIndexBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1CapabilityPrimaryReferenceCdfOnlyBitKhr = 4,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_av1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeAV1PredictionModeKHR.html" /></remarks>
    public enum VkVideoEncodeAV1PredictionModeKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1PredictionModeBidirectionalCompoundKhr = 3,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1PredictionModeIntraOnlyKhr = 0,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1PredictionModeSingleReferenceKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1PredictionModeUnidirectionalCompoundKhr = 2,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_av1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeAV1RateControlFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeAV1RateControlFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1RateControlReferencePatternDyadicBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1RateControlReferencePatternFlatBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1RateControlRegularGopBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1RateControlTemporalLayerPatternDyadicBitKhr = 2,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_av1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeAV1RateControlGroupKHR.html" /></remarks>
    public enum VkVideoEncodeAV1RateControlGroupKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1RateControlGroupBipredictiveKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1RateControlGroupIntraKhr = 0,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1RateControlGroupPredictiveKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_av1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeAV1StdFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeAV1StdFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1StdDeltaQBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1StdPrimaryRefFrameBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1StdSkipModePresentUnsetBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1StdUniformTileSpacingFlagSetBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_av1]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeAV1SuperblockSizeFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeAV1SuperblockSizeFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1SuperblockSize128BitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_av1</b>] </summary>
        VideoEncodeAv1SuperblockSize64BitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeCapabilityFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeCapabilityFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        VideoEncodeCapabilityEmphasisMapBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeCapabilityInsufficientBitstreamBufferRangeDetectionBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeCapabilityPrecedingExternallyEncodedBytesBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        VideoEncodeCapabilityQuantizationDeltaMapBitKhr = 4,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeContentFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeContentFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeContentCameraBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeContentDefaultKhr = 0,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeContentDesktopBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeContentRenderedBitKhr = 4,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeFeedbackFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeFeedbackFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeFeedbackBitstreamBufferOffsetBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeFeedbackBitstreamBytesWrittenBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeFeedbackBitstreamHasOverridesBitKhr = 4,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_quantization_map]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        VideoEncodeWithEmphasisMapBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        VideoEncodeWithQuantizationDeltaMapBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_h264]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeH264CapabilityFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeH264CapabilityFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264CapabilityBFrameInL0ListBitKhr = 16,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264CapabilityBFrameInL1ListBitKhr = 32,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264CapabilityDifferentSliceTypeBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264CapabilityGeneratePrefixNaluBitKhr = 256,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264CapabilityHrdComplianceBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        VideoEncodeH264CapabilityMbQpDiffWraparoundBitKhr = 512,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264CapabilityPerPictureTypeMinMaxQpBitKhr = 64,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264CapabilityPerSliceConstantQpBitKhr = 128,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264CapabilityPredictionWeightTableGeneratedBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264CapabilityRowUnalignedSliceBitKhr = 4,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_h264]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeH264RateControlFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeH264RateControlFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264RateControlAttemptHrdComplianceBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264RateControlReferencePatternDyadicBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264RateControlReferencePatternFlatBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264RateControlRegularGopBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264RateControlTemporalLayerPatternDyadicBitKhr = 16,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_h264]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeH264StdFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeH264StdFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdChromaQpIndexOffsetBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdConstrainedIntraPredFlagSetBitKhr = 16384,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdDeblockingFilterDisabledBitKhr = 32768,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdDeblockingFilterEnabledBitKhr = 65536,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdDeblockingFilterPartialBitKhr = 131072,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdDifferentSliceQpDeltaBitKhr = 1048576,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdDirect8x8InferenceFlagUnsetBitKhr = 8192,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdDirectSpatialMvPredFlagUnsetBitKhr = 1024,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdEntropyCodingModeFlagSetBitKhr = 4096,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdEntropyCodingModeFlagUnsetBitKhr = 2048,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdPicInitQpMinus26BitKhr = 32,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdQpprimeYZeroTransformBypassFlagSetBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdScalingMatrixPresentFlagSetBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdSecondChromaQpIndexOffsetBitKhr = 16,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdSeparateColorPlaneFlagSetBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdSliceQpDeltaBitKhr = 524288,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdTransform8x8ModeFlagSetBitKhr = 512,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdWeightedBipredIdcExplicitBitKhr = 128,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdWeightedBipredIdcImplicitBitKhr = 256,
        /// <summary>[requires: <b>VK_KHR_video_encode_h264</b>] </summary>
        VideoEncodeH264StdWeightedPredFlagSetBitKhr = 64,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_h265]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeH265CapabilityFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeH265CapabilityFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CapabilityBFrameInL0ListBitKhr = 16,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CapabilityBFrameInL1ListBitKhr = 32,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        VideoEncodeH265CapabilityCuQpDiffWraparoundBitKhr = 1024,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CapabilityDifferentSliceSegmentTypeBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CapabilityHrdComplianceBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CapabilityMultipleSliceSegmentsPerTileBitKhr = 512,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CapabilityMultipleTilesPerSliceSegmentBitKhr = 256,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CapabilityPerPictureTypeMinMaxQpBitKhr = 64,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CapabilityPerSliceSegmentConstantQpBitKhr = 128,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CapabilityPredictionWeightTableGeneratedBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CapabilityRowUnalignedSliceSegmentBitKhr = 4,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_h265]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeH265CtbSizeFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeH265CtbSizeFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CtbSize16BitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CtbSize32BitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265CtbSize64BitKhr = 4,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_h265]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeH265RateControlFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeH265RateControlFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265RateControlAttemptHrdComplianceBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265RateControlReferencePatternDyadicBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265RateControlReferencePatternFlatBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265RateControlRegularGopBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265RateControlTemporalSubLayerPatternDyadicBitKhr = 16,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_h265]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeH265StdFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeH265StdFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdConstrainedIntraPredFlagSetBitKhr = 16384,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdDeblockingFilterOverrideEnabledFlagSetBitKhr = 65536,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdDependentSliceSegmentFlagSetBitKhr = 262144,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdDependentSliceSegmentsEnabledFlagSetBitKhr = 131072,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdDifferentSliceQpDeltaBitKhr = 1048576,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdEntropyCodingSyncEnabledFlagSetBitKhr = 32768,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdInitQpMinus26BitKhr = 32,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdLog2ParallelMergeLevelMinus2BitKhr = 256,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdPcmEnabledFlagSetBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdPpsSliceChromaQpOffsetsPresentFlagSetBitKhr = 4096,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdSampleAdaptiveOffsetEnabledFlagSetBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdScalingListDataPresentFlagSetBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdSeparateColorPlaneFlagSetBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdSignDataHidingEnabledFlagSetBitKhr = 512,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdSliceQpDeltaBitKhr = 524288,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdSpsTemporalMvpEnabledFlagSetBitKhr = 16,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdTransformSkipEnabledFlagSetBitKhr = 1024,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdTransformSkipEnabledFlagUnsetBitKhr = 2048,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdTransquantBypassEnabledFlagSetBitKhr = 8192,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdWeightedBipredFlagSetBitKhr = 128,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265StdWeightedPredFlagSetBitKhr = 64,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_h265]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeH265TransformBlockSizeFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeH265TransformBlockSizeFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265TransformBlockSize16BitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265TransformBlockSize32BitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265TransformBlockSize4BitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_h265</b>] </summary>
        VideoEncodeH265TransformBlockSize8BitKhr = 2,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeRateControlFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeRateControlFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeRateControlModeFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeRateControlModeFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeRateControlModeCbrBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeRateControlModeDefaultKhr = 0,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeRateControlModeDisabledBitKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeRateControlModeVbrBitKhr = 4,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeTuningModeKHR.html" /></remarks>
    public enum VkVideoEncodeTuningModeKHR : int
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeTuningModeDefaultKhr = 0,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeTuningModeHighQualityKhr = 1,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeTuningModeLosslessKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeTuningModeLowLatencyKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeTuningModeUltraLowLatencyKhr = 3,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEncodeUsageFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEncodeUsageFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeUsageConferencingBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeUsageDefaultKhr = 0,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeUsageRecordingBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeUsageStreamingBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoEncodeUsageTranscodingBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_video_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoEndCodingFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoEndCodingFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_video_queue]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoSessionCreateFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoSessionCreateFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        VideoSessionCreateAllowEncodeEmphasisMapBitKhr = 16,
        /// <summary>[requires: <b>VK_KHR_video_encode_queue</b>] </summary>
        VideoSessionCreateAllowEncodeParameterOptimizationsBitKhr = 2,
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        VideoSessionCreateAllowEncodeQuantizationDeltaMapBitKhr = 8,
        /// <summary>[requires: <b>VK_KHR_video_maintenance1</b>] </summary>
        VideoSessionCreateInlineQueriesBitKhr = 4,
        /// <summary>[requires: <b>VK_KHR_video_maintenance2</b>] </summary>
        VideoSessionCreateInlineSessionParametersBitKhr = 32,
        /// <summary>[requires: <b>VK_KHR_video_queue</b>] </summary>
        VideoSessionCreateProtectedContentBitKhr = 1,
    }
    /// <summary><b>[requires: VK_KHR_video_encode_quantization_map]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkVideoSessionParametersCreateFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkVideoSessionParametersCreateFlagBitsKHR : uint
    {
        /// <summary>[requires: <b>VK_KHR_video_encode_quantization_map</b>] </summary>
        VideoSessionParametersCreateQuantizationMapCompatibleBitKhr = 1,
    }
    /// <summary><b>[requires: VK_NV_viewport_swizzle]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkViewportCoordinateSwizzleNV.html" /></remarks>
    public enum VkViewportCoordinateSwizzleNV : int
    {
        /// <summary>[requires: <b>VK_NV_viewport_swizzle</b>] </summary>
        ViewportCoordinateSwizzleNegativeWNv = 7,
        /// <summary>[requires: <b>VK_NV_viewport_swizzle</b>] </summary>
        ViewportCoordinateSwizzleNegativeXNv = 1,
        /// <summary>[requires: <b>VK_NV_viewport_swizzle</b>] </summary>
        ViewportCoordinateSwizzleNegativeYNv = 3,
        /// <summary>[requires: <b>VK_NV_viewport_swizzle</b>] </summary>
        ViewportCoordinateSwizzleNegativeZNv = 5,
        /// <summary>[requires: <b>VK_NV_viewport_swizzle</b>] </summary>
        ViewportCoordinateSwizzlePositiveWNv = 6,
        /// <summary>[requires: <b>VK_NV_viewport_swizzle</b>] </summary>
        ViewportCoordinateSwizzlePositiveXNv = 0,
        /// <summary>[requires: <b>VK_NV_viewport_swizzle</b>] </summary>
        ViewportCoordinateSwizzlePositiveYNv = 2,
        /// <summary>[requires: <b>VK_NV_viewport_swizzle</b>] </summary>
        ViewportCoordinateSwizzlePositiveZNv = 4,
    }
    /// <summary><b>[requires: VK_NN_vi_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkViSurfaceCreateFlagsNN.html" /></remarks>
    [Flags]
    public enum VkViSurfaceCreateFlagsNN : uint
    {
    }
    /// <summary></summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkWaylandSurfaceCreateFlagBitsKHR.html" /></remarks>
    [Flags]
    public enum VkWaylandSurfaceCreateFlagBitsKHR : int
    {
    }
    /// <summary><b>[requires: VK_KHR_wayland_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkWaylandSurfaceCreateFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkWaylandSurfaceCreateFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_win32_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkWin32SurfaceCreateFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkWin32SurfaceCreateFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_xcb_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkXcbSurfaceCreateFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkXcbSurfaceCreateFlagsKHR : uint
    {
    }
    /// <summary><b>[requires: VK_KHR_xlib_surface]</b> </summary>
    /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VkXlibSurfaceCreateFlagsKHR.html" /></remarks>
    [Flags]
    public enum VkXlibSurfaceCreateFlagsKHR : uint
    {
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
