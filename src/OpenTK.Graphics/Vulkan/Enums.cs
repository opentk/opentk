// This file is auto generated, do not edit.
using System;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum VkImageLayout : int
    {
        /// <summary>Implicit layout an image is when its contents are undefined due to various reasons (e.g. right after creation)</summary>
        ImageLayoutUndefined = 0,
        /// <summary>General layout when image can be used for any kind of access</summary>
        ImageLayoutGeneral = 1,
        /// <summary>Optimal layout when image is only used for color attachment read/write</summary>
        ImageLayoutColorAttachmentOptimal = 2,
        /// <summary>Optimal layout when image is only used for depth/stencil attachment read/write</summary>
        ImageLayoutDepthStencilAttachmentOptimal = 3,
        /// <summary>Optimal layout when image is used for read only depth/stencil attachment and shader access</summary>
        ImageLayoutDepthStencilReadOnlyOptimal = 4,
        /// <summary>Optimal layout when image is used for read only shader access</summary>
        ImageLayoutShaderReadOnlyOptimal = 5,
        /// <summary>Optimal layout when image is used only as source of transfer operations</summary>
        ImageLayoutTransferSrcOptimal = 6,
        /// <summary>Optimal layout when image is used only as destination of transfer operations</summary>
        ImageLayoutTransferDstOptimal = 7,
        /// <summary>Initial layout used when the data is populated by the CPU</summary>
        ImageLayoutPreinitialized = 8,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ImageLayoutDepthReadOnlyStencilAttachmentOptimal = 1000117000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ImageLayoutDepthAttachmentStencilReadOnlyOptimal = 1000117001,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        ImageLayoutDepthAttachmentOptimal = 1000241000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        ImageLayoutDepthReadOnlyOptimal = 1000241001,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        ImageLayoutStencilAttachmentOptimal = 1000241002,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        ImageLayoutStencilReadOnlyOptimal = 1000241003,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        ImageLayoutReadOnlyOptimal = 1000314000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        ImageLayoutAttachmentOptimal = 1000314001,
        /// <summary>[requires: VK_KHR_swapchain]</summary>
        ImageLayoutPresentSrcKhr = 1000001002,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        ImageLayoutVideoDecodeDstKhr = 1000024000,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        ImageLayoutVideoDecodeSrcKhr = 1000024001,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        ImageLayoutVideoDecodeDpbKhr = 1000024002,
        /// <summary>[requires: VK_KHR_shared_presentable_image]</summary>
        ImageLayoutSharedPresentKhr = 1000111000,
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        ImageLayoutFragmentDensityMapOptimalExt = 1000218000,
        /// <summary>[requires: VK_KHR_fragment_shading_rate]</summary>
        ImageLayoutFragmentShadingRateAttachmentOptimalKhr = 1000164003,
        /// <summary>[requires: VK_KHR_dynamic_rendering_local_read]</summary>
        ImageLayoutRenderingLocalReadKhr = 1000232000,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        ImageLayoutVideoEncodeDstKhr = 1000299000,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        ImageLayoutVideoEncodeSrcKhr = 1000299001,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        ImageLayoutVideoEncodeDpbKhr = 1000299002,
        /// <summary>[requires: VK_EXT_attachment_feedback_loop_layout]</summary>
        ImageLayoutAttachmentFeedbackLoopOptimalExt = 1000339000,
        /// <summary>[requires: VK_KHR_maintenance2]</summary>
        ImageLayoutDepthReadOnlyStencilAttachmentOptimalKhr = 1000117000,
        /// <summary>[requires: VK_KHR_maintenance2]</summary>
        ImageLayoutDepthAttachmentStencilReadOnlyOptimalKhr = 1000117001,
        /// <summary>[requires: VK_NV_shading_rate_image]</summary>
        ImageLayoutShadingRateOptimalNv = 1000164003,
        /// <summary>[requires: VK_KHR_separate_depth_stencil_layouts]</summary>
        ImageLayoutDepthAttachmentOptimalKhr = 1000241000,
        /// <summary>[requires: VK_KHR_separate_depth_stencil_layouts]</summary>
        ImageLayoutDepthReadOnlyOptimalKhr = 1000241001,
        /// <summary>[requires: VK_KHR_separate_depth_stencil_layouts]</summary>
        ImageLayoutStencilAttachmentOptimalKhr = 1000241002,
        /// <summary>[requires: VK_KHR_separate_depth_stencil_layouts]</summary>
        ImageLayoutStencilReadOnlyOptimalKhr = 1000241003,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        ImageLayoutReadOnlyOptimalKhr = 1000314000,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        ImageLayoutAttachmentOptimalKhr = 1000314001,
    }
    public enum VkAttachmentLoadOp : int
    {
        AttachmentLoadOpLoad = 0,
        AttachmentLoadOpClear = 1,
        AttachmentLoadOpDontCare = 2,
        /// <summary>[requires: VK_KHR_load_store_op_none]</summary>
        AttachmentLoadOpNoneKhr = 1000400000,
        /// <summary>[requires: VK_EXT_load_store_op_none]</summary>
        AttachmentLoadOpNoneExt = 1000400000,
    }
    public enum VkAttachmentStoreOp : int
    {
        AttachmentStoreOpStore = 0,
        AttachmentStoreOpDontCare = 1,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        AttachmentStoreOpNone = 1000301000,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        AttachmentStoreOpNoneKhr = 1000301000,
        /// <summary>[requires: VK_QCOM_render_pass_store_ops]</summary>
        AttachmentStoreOpNoneQcom = 1000301000,
        /// <summary>[requires: VK_EXT_load_store_op_none]</summary>
        AttachmentStoreOpNoneExt = 1000301000,
    }
    public enum VkImageType : int
    {
        ImageType1d = 0,
        ImageType2d = 1,
        ImageType3d = 2,
    }
    public enum VkImageTiling : int
    {
        ImageTilingOptimal = 0,
        ImageTilingLinear = 1,
        /// <summary>[requires: VK_EXT_image_drm_format_modifier]</summary>
        ImageTilingDrmFormatModifierExt = 1000158000,
    }
    public enum VkImageViewType : int
    {
        ImageViewType1d = 0,
        ImageViewType2d = 1,
        ImageViewType3d = 2,
        ImageViewTypeCube = 3,
        ImageViewType1dArray = 4,
        ImageViewType2dArray = 5,
        ImageViewTypeCubeArray = 6,
    }
    public enum VkCommandBufferLevel : int
    {
        CommandBufferLevelPrimary = 0,
        CommandBufferLevelSecondary = 1,
    }
    public enum VkComponentSwizzle : int
    {
        ComponentSwizzleIdentity = 0,
        ComponentSwizzleZero = 1,
        ComponentSwizzleOne = 2,
        ComponentSwizzleR = 3,
        ComponentSwizzleG = 4,
        ComponentSwizzleB = 5,
        ComponentSwizzleA = 6,
    }
    public enum VkDescriptorType : int
    {
        DescriptorTypeSampler = 0,
        DescriptorTypeCombinedImageSampler = 1,
        DescriptorTypeSampledImage = 2,
        DescriptorTypeStorageImage = 3,
        DescriptorTypeUniformTexelBuffer = 4,
        DescriptorTypeStorageTexelBuffer = 5,
        DescriptorTypeUniformBuffer = 6,
        DescriptorTypeStorageBuffer = 7,
        DescriptorTypeUniformBufferDynamic = 8,
        DescriptorTypeStorageBufferDynamic = 9,
        DescriptorTypeInputAttachment = 10,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DescriptorTypeInlineUniformBlock = 1000138000,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        DescriptorTypeAccelerationStructureKhr = 1000150000,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        DescriptorTypeAccelerationStructureNv = 1000165000,
        /// <summary>[requires: VK_QCOM_image_processing]</summary>
        DescriptorTypeSampleWeightImageQcom = 1000440000,
        /// <summary>[requires: VK_QCOM_image_processing]</summary>
        DescriptorTypeBlockMatchImageQcom = 1000440001,
        /// <summary>[requires: VK_EXT_mutable_descriptor_type]</summary>
        DescriptorTypeMutableExt = 1000351000,
        /// <summary>[requires: VK_EXT_inline_uniform_block]</summary>
        DescriptorTypeInlineUniformBlockExt = 1000138000,
        /// <summary>[requires: VK_VALVE_mutable_descriptor_type]</summary>
        DescriptorTypeMutableValve = 1000351000,
    }
    public enum VkQueryType : int
    {
        QueryTypeOcclusion = 0,
        /// <summary>Optional</summary>
        QueryTypePipelineStatistics = 1,
        QueryTypeTimestamp = 2,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        QueryTypeResultStatusOnlyKhr = 1000023000,
        /// <summary>[requires: VK_EXT_transform_feedback]</summary>
        QueryTypeTransformFeedbackStreamExt = 1000028004,
        /// <summary>[requires: VK_KHR_performance_query]</summary>
        QueryTypePerformanceQueryKhr = 1000116000,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        QueryTypeAccelerationStructureCompactedSizeKhr = 1000150000,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        QueryTypeAccelerationStructureSerializationSizeKhr = 1000150001,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        QueryTypeAccelerationStructureCompactedSizeNv = 1000165000,
        /// <summary>[requires: VK_INTEL_performance_query]</summary>
        QueryTypePerformanceQueryIntel = 1000210000,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        QueryTypeVideoEncodeFeedbackKhr = 1000299000,
        /// <summary>[requires: VK_EXT_mesh_shader]</summary>
        QueryTypeMeshPrimitivesGeneratedExt = 1000328000,
        /// <summary>[requires: VK_EXT_primitives_generated_query]</summary>
        QueryTypePrimitivesGeneratedExt = 1000382000,
        /// <summary>[requires: VK_KHR_ray_tracing_maintenance1]</summary>
        QueryTypeAccelerationStructureSerializationBottomLevelPointersKhr = 1000386000,
        /// <summary>[requires: VK_KHR_ray_tracing_maintenance1]</summary>
        QueryTypeAccelerationStructureSizeKhr = 1000386001,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        QueryTypeMicromapSerializationSizeExt = 1000396000,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        QueryTypeMicromapCompactedSizeExt = 1000396001,
    }
    public enum VkBorderColor : int
    {
        BorderColorFloatTransparentBlack = 0,
        BorderColorIntTransparentBlack = 1,
        BorderColorFloatOpaqueBlack = 2,
        BorderColorIntOpaqueBlack = 3,
        BorderColorFloatOpaqueWhite = 4,
        BorderColorIntOpaqueWhite = 5,
        /// <summary>[requires: VK_EXT_custom_border_color]</summary>
        BorderColorFloatCustomExt = 1000287003,
        /// <summary>[requires: VK_EXT_custom_border_color]</summary>
        BorderColorIntCustomExt = 1000287004,
    }
    public enum VkPipelineBindPoint : int
    {
        PipelineBindPointGraphics = 0,
        PipelineBindPointCompute = 1,
        /// <summary>[requires: VK_AMDX_shader_enqueue]</summary>
        PipelineBindPointExecutionGraphAmdx = 1000134000,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        PipelineBindPointRayTracingKhr = 1000165000,
        /// <summary>[requires: VK_HUAWEI_subpass_shading]</summary>
        PipelineBindPointSubpassShadingHuawei = 1000369003,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        PipelineBindPointRayTracingNv = 1000165000,
    }
    public enum VkPipelineCacheHeaderVersion : int
    {
        PipelineCacheHeaderVersionOne = 1,
    }
    [Flags]
    public enum VkPipelineCacheCreateFlagBits : int
    {
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        PipelineCacheCreateExternallySynchronizedBit = 1,
        /// <summary>[requires: VK_EXT_pipeline_creation_cache_control]</summary>
        PipelineCacheCreateExternallySynchronizedBitExt = 1,
    }
    public enum VkPrimitiveTopology : int
    {
        PrimitiveTopologyPointList = 0,
        PrimitiveTopologyLineList = 1,
        PrimitiveTopologyLineStrip = 2,
        PrimitiveTopologyTriangleList = 3,
        PrimitiveTopologyTriangleStrip = 4,
        PrimitiveTopologyTriangleFan = 5,
        PrimitiveTopologyLineListWithAdjacency = 6,
        PrimitiveTopologyLineStripWithAdjacency = 7,
        PrimitiveTopologyTriangleListWithAdjacency = 8,
        PrimitiveTopologyTriangleStripWithAdjacency = 9,
        PrimitiveTopologyPatchList = 10,
    }
    public enum VkSharingMode : int
    {
        SharingModeExclusive = 0,
        SharingModeConcurrent = 1,
    }
    public enum VkIndexType : int
    {
        IndexTypeUint16 = 0,
        IndexTypeUint32 = 1,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        IndexTypeNoneKhr = 1000165000,
        /// <summary>[requires: VK_KHR_index_type_uint8]</summary>
        IndexTypeUint8Khr = 1000265000,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        IndexTypeNoneNv = 1000165000,
        /// <summary>[requires: VK_EXT_index_type_uint8]</summary>
        IndexTypeUint8Ext = 1000265000,
    }
    public enum VkFilter : int
    {
        FilterNearest = 0,
        FilterLinear = 1,
        /// <summary>[requires: VK_EXT_filter_cubic]</summary>
        FilterCubicExt = 1000015000,
        /// <summary>[requires: VK_IMG_filter_cubic]</summary>
        FilterCubicImg = 1000015000,
    }
    public enum VkSamplerMipmapMode : int
    {
        /// <summary>Choose nearest mip level</summary>
        SamplerMipmapModeNearest = 0,
        /// <summary>Linear filter between mip levels</summary>
        SamplerMipmapModeLinear = 1,
    }
    public enum VkSamplerAddressMode : int
    {
        SamplerAddressModeRepeat = 0,
        SamplerAddressModeMirroredRepeat = 1,
        SamplerAddressModeClampToEdge = 2,
        SamplerAddressModeClampToBorder = 3,
        /// <summary>[requires: VK_VERSION_1_2]No need to add an extnumber attribute, since this uses a core enum value</summary>
        SamplerAddressModeMirrorClampToEdge = 4,
        /// <summary>[requires: VK_KHR_sampler_mirror_clamp_to_edge]Introduced for consistency with extension suffixing rules</summary>
        SamplerAddressModeMirrorClampToEdgeKhr = 4,
    }
    public enum VkCompareOp : int
    {
        CompareOpNever = 0,
        CompareOpLess = 1,
        CompareOpEqual = 2,
        CompareOpLessOrEqual = 3,
        CompareOpGreater = 4,
        CompareOpNotEqual = 5,
        CompareOpGreaterOrEqual = 6,
        CompareOpAlways = 7,
    }
    public enum VkPolygonMode : int
    {
        PolygonModeFill = 0,
        PolygonModeLine = 1,
        PolygonModePoint = 2,
        /// <summary>[requires: VK_NV_fill_rectangle]</summary>
        PolygonModeFillRectangleNv = 1000153000,
    }
    public enum VkFrontFace : int
    {
        FrontFaceCounterClockwise = 0,
        FrontFaceClockwise = 1,
    }
    public enum VkBlendFactor : int
    {
        BlendFactorZero = 0,
        BlendFactorOne = 1,
        BlendFactorSrcColor = 2,
        BlendFactorOneMinusSrcColor = 3,
        BlendFactorDstColor = 4,
        BlendFactorOneMinusDstColor = 5,
        BlendFactorSrcAlpha = 6,
        BlendFactorOneMinusSrcAlpha = 7,
        BlendFactorDstAlpha = 8,
        BlendFactorOneMinusDstAlpha = 9,
        BlendFactorConstantColor = 10,
        BlendFactorOneMinusConstantColor = 11,
        BlendFactorConstantAlpha = 12,
        BlendFactorOneMinusConstantAlpha = 13,
        BlendFactorSrcAlphaSaturate = 14,
        BlendFactorSrc1Color = 15,
        BlendFactorOneMinusSrc1Color = 16,
        BlendFactorSrc1Alpha = 17,
        BlendFactorOneMinusSrc1Alpha = 18,
    }
    public enum VkBlendOp : int
    {
        BlendOpAdd = 0,
        BlendOpSubtract = 1,
        BlendOpReverseSubtract = 2,
        BlendOpMin = 3,
        BlendOpMax = 4,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpZeroExt = 1000148000,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpSrcExt = 1000148001,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpDstExt = 1000148002,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpSrcOverExt = 1000148003,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpDstOverExt = 1000148004,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpSrcInExt = 1000148005,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpDstInExt = 1000148006,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpSrcOutExt = 1000148007,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpDstOutExt = 1000148008,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpSrcAtopExt = 1000148009,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpDstAtopExt = 1000148010,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpXorExt = 1000148011,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpMultiplyExt = 1000148012,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpScreenExt = 1000148013,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpOverlayExt = 1000148014,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpDarkenExt = 1000148015,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpLightenExt = 1000148016,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpColordodgeExt = 1000148017,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpColorburnExt = 1000148018,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpHardlightExt = 1000148019,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpSoftlightExt = 1000148020,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpDifferenceExt = 1000148021,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpExclusionExt = 1000148022,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpInvertExt = 1000148023,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpInvertRgbExt = 1000148024,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpLineardodgeExt = 1000148025,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpLinearburnExt = 1000148026,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpVividlightExt = 1000148027,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpLinearlightExt = 1000148028,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpPinlightExt = 1000148029,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpHardmixExt = 1000148030,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpHslHueExt = 1000148031,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpHslSaturationExt = 1000148032,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpHslColorExt = 1000148033,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpHslLuminosityExt = 1000148034,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpPlusExt = 1000148035,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpPlusClampedExt = 1000148036,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpPlusClampedAlphaExt = 1000148037,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpPlusDarkerExt = 1000148038,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpMinusExt = 1000148039,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpMinusClampedExt = 1000148040,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpContrastExt = 1000148041,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpInvertOvgExt = 1000148042,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpRedExt = 1000148043,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpGreenExt = 1000148044,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        BlendOpBlueExt = 1000148045,
    }
    public enum VkStencilOp : int
    {
        StencilOpKeep = 0,
        StencilOpZero = 1,
        StencilOpReplace = 2,
        StencilOpIncrementAndClamp = 3,
        StencilOpDecrementAndClamp = 4,
        StencilOpInvert = 5,
        StencilOpIncrementAndWrap = 6,
        StencilOpDecrementAndWrap = 7,
    }
    public enum VkLogicOp : int
    {
        LogicOpClear = 0,
        LogicOpAnd = 1,
        LogicOpAndReverse = 2,
        LogicOpCopy = 3,
        LogicOpAndInverted = 4,
        LogicOpNoOp = 5,
        LogicOpXor = 6,
        LogicOpOr = 7,
        LogicOpNor = 8,
        LogicOpEquivalent = 9,
        LogicOpInvert = 10,
        LogicOpOrReverse = 11,
        LogicOpCopyInverted = 12,
        LogicOpOrInverted = 13,
        LogicOpNand = 14,
        LogicOpSet = 15,
    }
    public enum VkInternalAllocationType : int
    {
        InternalAllocationTypeExecutable = 0,
    }
    public enum VkSystemAllocationScope : int
    {
        SystemAllocationScopeCommand = 0,
        SystemAllocationScopeObject = 1,
        SystemAllocationScopeCache = 2,
        SystemAllocationScopeDevice = 3,
        SystemAllocationScopeInstance = 4,
    }
    public enum VkPhysicalDeviceType : int
    {
        PhysicalDeviceTypeOther = 0,
        PhysicalDeviceTypeIntegratedGpu = 1,
        PhysicalDeviceTypeDiscreteGpu = 2,
        PhysicalDeviceTypeVirtualGpu = 3,
        PhysicalDeviceTypeCpu = 4,
    }
    public enum VkVertexInputRate : int
    {
        VertexInputRateVertex = 0,
        VertexInputRateInstance = 1,
    }
    public enum VkFormat : int
    {
        FormatUndefined = 0,
        FormatR4g4UnormPack8 = 1,
        FormatR4g4b4a4UnormPack16 = 2,
        FormatB4g4r4a4UnormPack16 = 3,
        FormatR5g6b5UnormPack16 = 4,
        FormatB5g6r5UnormPack16 = 5,
        FormatR5g5b5a1UnormPack16 = 6,
        FormatB5g5r5a1UnormPack16 = 7,
        FormatA1r5g5b5UnormPack16 = 8,
        FormatR8Unorm = 9,
        FormatR8Snorm = 10,
        FormatR8Uscaled = 11,
        FormatR8Sscaled = 12,
        FormatR8Uint = 13,
        FormatR8Sint = 14,
        FormatR8Srgb = 15,
        FormatR8g8Unorm = 16,
        FormatR8g8Snorm = 17,
        FormatR8g8Uscaled = 18,
        FormatR8g8Sscaled = 19,
        FormatR8g8Uint = 20,
        FormatR8g8Sint = 21,
        FormatR8g8Srgb = 22,
        FormatR8g8b8Unorm = 23,
        FormatR8g8b8Snorm = 24,
        FormatR8g8b8Uscaled = 25,
        FormatR8g8b8Sscaled = 26,
        FormatR8g8b8Uint = 27,
        FormatR8g8b8Sint = 28,
        FormatR8g8b8Srgb = 29,
        FormatB8g8r8Unorm = 30,
        FormatB8g8r8Snorm = 31,
        FormatB8g8r8Uscaled = 32,
        FormatB8g8r8Sscaled = 33,
        FormatB8g8r8Uint = 34,
        FormatB8g8r8Sint = 35,
        FormatB8g8r8Srgb = 36,
        FormatR8g8b8a8Unorm = 37,
        FormatR8g8b8a8Snorm = 38,
        FormatR8g8b8a8Uscaled = 39,
        FormatR8g8b8a8Sscaled = 40,
        FormatR8g8b8a8Uint = 41,
        FormatR8g8b8a8Sint = 42,
        FormatR8g8b8a8Srgb = 43,
        FormatB8g8r8a8Unorm = 44,
        FormatB8g8r8a8Snorm = 45,
        FormatB8g8r8a8Uscaled = 46,
        FormatB8g8r8a8Sscaled = 47,
        FormatB8g8r8a8Uint = 48,
        FormatB8g8r8a8Sint = 49,
        FormatB8g8r8a8Srgb = 50,
        FormatA8b8g8r8UnormPack32 = 51,
        FormatA8b8g8r8SnormPack32 = 52,
        FormatA8b8g8r8UscaledPack32 = 53,
        FormatA8b8g8r8SscaledPack32 = 54,
        FormatA8b8g8r8UintPack32 = 55,
        FormatA8b8g8r8SintPack32 = 56,
        FormatA8b8g8r8SrgbPack32 = 57,
        FormatA2r10g10b10UnormPack32 = 58,
        FormatA2r10g10b10SnormPack32 = 59,
        FormatA2r10g10b10UscaledPack32 = 60,
        FormatA2r10g10b10SscaledPack32 = 61,
        FormatA2r10g10b10UintPack32 = 62,
        FormatA2r10g10b10SintPack32 = 63,
        FormatA2b10g10r10UnormPack32 = 64,
        FormatA2b10g10r10SnormPack32 = 65,
        FormatA2b10g10r10UscaledPack32 = 66,
        FormatA2b10g10r10SscaledPack32 = 67,
        FormatA2b10g10r10UintPack32 = 68,
        FormatA2b10g10r10SintPack32 = 69,
        FormatR16Unorm = 70,
        FormatR16Snorm = 71,
        FormatR16Uscaled = 72,
        FormatR16Sscaled = 73,
        FormatR16Uint = 74,
        FormatR16Sint = 75,
        FormatR16Sfloat = 76,
        FormatR16g16Unorm = 77,
        FormatR16g16Snorm = 78,
        FormatR16g16Uscaled = 79,
        FormatR16g16Sscaled = 80,
        FormatR16g16Uint = 81,
        FormatR16g16Sint = 82,
        FormatR16g16Sfloat = 83,
        FormatR16g16b16Unorm = 84,
        FormatR16g16b16Snorm = 85,
        FormatR16g16b16Uscaled = 86,
        FormatR16g16b16Sscaled = 87,
        FormatR16g16b16Uint = 88,
        FormatR16g16b16Sint = 89,
        FormatR16g16b16Sfloat = 90,
        FormatR16g16b16a16Unorm = 91,
        FormatR16g16b16a16Snorm = 92,
        FormatR16g16b16a16Uscaled = 93,
        FormatR16g16b16a16Sscaled = 94,
        FormatR16g16b16a16Uint = 95,
        FormatR16g16b16a16Sint = 96,
        FormatR16g16b16a16Sfloat = 97,
        FormatR32Uint = 98,
        FormatR32Sint = 99,
        FormatR32Sfloat = 100,
        FormatR32g32Uint = 101,
        FormatR32g32Sint = 102,
        FormatR32g32Sfloat = 103,
        FormatR32g32b32Uint = 104,
        FormatR32g32b32Sint = 105,
        FormatR32g32b32Sfloat = 106,
        FormatR32g32b32a32Uint = 107,
        FormatR32g32b32a32Sint = 108,
        FormatR32g32b32a32Sfloat = 109,
        FormatR64Uint = 110,
        FormatR64Sint = 111,
        FormatR64Sfloat = 112,
        FormatR64g64Uint = 113,
        FormatR64g64Sint = 114,
        FormatR64g64Sfloat = 115,
        FormatR64g64b64Uint = 116,
        FormatR64g64b64Sint = 117,
        FormatR64g64b64Sfloat = 118,
        FormatR64g64b64a64Uint = 119,
        FormatR64g64b64a64Sint = 120,
        FormatR64g64b64a64Sfloat = 121,
        FormatB10g11r11UfloatPack32 = 122,
        FormatE5b9g9r9UfloatPack32 = 123,
        FormatD16Unorm = 124,
        FormatX8D24UnormPack32 = 125,
        FormatD32Sfloat = 126,
        FormatS8Uint = 127,
        FormatD16UnormS8Uint = 128,
        FormatD24UnormS8Uint = 129,
        FormatD32SfloatS8Uint = 130,
        FormatBc1RgbUnormBlock = 131,
        FormatBc1RgbSrgbBlock = 132,
        FormatBc1RgbaUnormBlock = 133,
        FormatBc1RgbaSrgbBlock = 134,
        FormatBc2UnormBlock = 135,
        FormatBc2SrgbBlock = 136,
        FormatBc3UnormBlock = 137,
        FormatBc3SrgbBlock = 138,
        FormatBc4UnormBlock = 139,
        FormatBc4SnormBlock = 140,
        FormatBc5UnormBlock = 141,
        FormatBc5SnormBlock = 142,
        FormatBc6hUfloatBlock = 143,
        FormatBc6hSfloatBlock = 144,
        FormatBc7UnormBlock = 145,
        FormatBc7SrgbBlock = 146,
        FormatEtc2R8g8b8UnormBlock = 147,
        FormatEtc2R8g8b8SrgbBlock = 148,
        FormatEtc2R8g8b8a1UnormBlock = 149,
        FormatEtc2R8g8b8a1SrgbBlock = 150,
        FormatEtc2R8g8b8a8UnormBlock = 151,
        FormatEtc2R8g8b8a8SrgbBlock = 152,
        FormatEacR11UnormBlock = 153,
        FormatEacR11SnormBlock = 154,
        FormatEacR11g11UnormBlock = 155,
        FormatEacR11g11SnormBlock = 156,
        FormatAstc4x4UnormBlock = 157,
        FormatAstc4x4SrgbBlock = 158,
        FormatAstc5x4UnormBlock = 159,
        FormatAstc5x4SrgbBlock = 160,
        FormatAstc5x5UnormBlock = 161,
        FormatAstc5x5SrgbBlock = 162,
        FormatAstc6x5UnormBlock = 163,
        FormatAstc6x5SrgbBlock = 164,
        FormatAstc6x6UnormBlock = 165,
        FormatAstc6x6SrgbBlock = 166,
        FormatAstc8x5UnormBlock = 167,
        FormatAstc8x5SrgbBlock = 168,
        FormatAstc8x6UnormBlock = 169,
        FormatAstc8x6SrgbBlock = 170,
        FormatAstc8x8UnormBlock = 171,
        FormatAstc8x8SrgbBlock = 172,
        FormatAstc10x5UnormBlock = 173,
        FormatAstc10x5SrgbBlock = 174,
        FormatAstc10x6UnormBlock = 175,
        FormatAstc10x6SrgbBlock = 176,
        FormatAstc10x8UnormBlock = 177,
        FormatAstc10x8SrgbBlock = 178,
        FormatAstc10x10UnormBlock = 179,
        FormatAstc10x10SrgbBlock = 180,
        FormatAstc12x10UnormBlock = 181,
        FormatAstc12x10SrgbBlock = 182,
        FormatAstc12x12UnormBlock = 183,
        FormatAstc12x12SrgbBlock = 184,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG8b8g8r8422Unorm = 1000156000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatB8g8r8g8422Unorm = 1000156001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG8B8R83plane420Unorm = 1000156002,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG8B8r82plane420Unorm = 1000156003,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG8B8R83plane422Unorm = 1000156004,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG8B8r82plane422Unorm = 1000156005,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG8B8R83plane444Unorm = 1000156006,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatR10x6UnormPack16 = 1000156007,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatR10x6g10x6Unorm2pack16 = 1000156008,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatR10x6g10x6b10x6a10x6Unorm4pack16 = 1000156009,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG10x6b10x6g10x6r10x6422Unorm4pack16 = 1000156010,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatB10x6g10x6r10x6g10x6422Unorm4pack16 = 1000156011,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG10x6B10x6R10x63plane420Unorm3pack16 = 1000156012,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG10x6B10x6r10x62plane420Unorm3pack16 = 1000156013,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG10x6B10x6R10x63plane422Unorm3pack16 = 1000156014,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG10x6B10x6r10x62plane422Unorm3pack16 = 1000156015,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG10x6B10x6R10x63plane444Unorm3pack16 = 1000156016,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatR12x4UnormPack16 = 1000156017,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatR12x4g12x4Unorm2pack16 = 1000156018,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatR12x4g12x4b12x4a12x4Unorm4pack16 = 1000156019,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG12x4b12x4g12x4r12x4422Unorm4pack16 = 1000156020,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatB12x4g12x4r12x4g12x4422Unorm4pack16 = 1000156021,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG12x4B12x4R12x43plane420Unorm3pack16 = 1000156022,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG12x4B12x4r12x42plane420Unorm3pack16 = 1000156023,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG12x4B12x4R12x43plane422Unorm3pack16 = 1000156024,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG12x4B12x4r12x42plane422Unorm3pack16 = 1000156025,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG12x4B12x4R12x43plane444Unorm3pack16 = 1000156026,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG16b16g16r16422Unorm = 1000156027,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatB16g16r16g16422Unorm = 1000156028,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG16B16R163plane420Unorm = 1000156029,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG16B16r162plane420Unorm = 1000156030,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG16B16R163plane422Unorm = 1000156031,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG16B16r162plane422Unorm = 1000156032,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatG16B16R163plane444Unorm = 1000156033,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatG8B8r82plane444Unorm = 1000330000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatG10x6B10x6r10x62plane444Unorm3pack16 = 1000330001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatG12x4B12x4r12x42plane444Unorm3pack16 = 1000330002,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatG16B16r162plane444Unorm = 1000330003,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatA4r4g4b4UnormPack16 = 1000340000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatA4b4g4r4UnormPack16 = 1000340001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc4x4SfloatBlock = 1000066000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc5x4SfloatBlock = 1000066001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc5x5SfloatBlock = 1000066002,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc6x5SfloatBlock = 1000066003,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc6x6SfloatBlock = 1000066004,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc8x5SfloatBlock = 1000066005,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc8x6SfloatBlock = 1000066006,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc8x8SfloatBlock = 1000066007,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc10x5SfloatBlock = 1000066008,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc10x6SfloatBlock = 1000066009,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc10x8SfloatBlock = 1000066010,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc10x10SfloatBlock = 1000066011,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc12x10SfloatBlock = 1000066012,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        FormatAstc12x12SfloatBlock = 1000066013,
        /// <summary>[requires: VK_IMG_format_pvrtc]</summary>
        FormatPvrtc12bppUnormBlockImg = 1000054000,
        /// <summary>[requires: VK_IMG_format_pvrtc]</summary>
        FormatPvrtc14bppUnormBlockImg = 1000054001,
        /// <summary>[requires: VK_IMG_format_pvrtc]</summary>
        FormatPvrtc22bppUnormBlockImg = 1000054002,
        /// <summary>[requires: VK_IMG_format_pvrtc]</summary>
        FormatPvrtc24bppUnormBlockImg = 1000054003,
        /// <summary>[requires: VK_IMG_format_pvrtc]</summary>
        FormatPvrtc12bppSrgbBlockImg = 1000054004,
        /// <summary>[requires: VK_IMG_format_pvrtc]</summary>
        FormatPvrtc14bppSrgbBlockImg = 1000054005,
        /// <summary>[requires: VK_IMG_format_pvrtc]</summary>
        FormatPvrtc22bppSrgbBlockImg = 1000054006,
        /// <summary>[requires: VK_IMG_format_pvrtc]</summary>
        FormatPvrtc24bppSrgbBlockImg = 1000054007,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        FormatR16g16Sfixed5Nv = 1000464000,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        FormatA1b5g5r5UnormPack16Khr = 1000470000,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        FormatA8UnormKhr = 1000470001,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc4x4SfloatBlockExt = 1000066000,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc5x4SfloatBlockExt = 1000066001,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc5x5SfloatBlockExt = 1000066002,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc6x5SfloatBlockExt = 1000066003,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc6x6SfloatBlockExt = 1000066004,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc8x5SfloatBlockExt = 1000066005,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc8x6SfloatBlockExt = 1000066006,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc8x8SfloatBlockExt = 1000066007,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc10x5SfloatBlockExt = 1000066008,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc10x6SfloatBlockExt = 1000066009,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc10x8SfloatBlockExt = 1000066010,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc10x10SfloatBlockExt = 1000066011,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc12x10SfloatBlockExt = 1000066012,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        FormatAstc12x12SfloatBlockExt = 1000066013,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG8b8g8r8422UnormKhr = 1000156000,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatB8g8r8g8422UnormKhr = 1000156001,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG8B8R83plane420UnormKhr = 1000156002,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG8B8r82plane420UnormKhr = 1000156003,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG8B8R83plane422UnormKhr = 1000156004,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG8B8r82plane422UnormKhr = 1000156005,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG8B8R83plane444UnormKhr = 1000156006,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatR10x6UnormPack16Khr = 1000156007,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatR10x6g10x6Unorm2pack16Khr = 1000156008,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatR10x6g10x6b10x6a10x6Unorm4pack16Khr = 1000156009,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG10x6b10x6g10x6r10x6422Unorm4pack16Khr = 1000156010,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatB10x6g10x6r10x6g10x6422Unorm4pack16Khr = 1000156011,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG10x6B10x6R10x63plane420Unorm3pack16Khr = 1000156012,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG10x6B10x6r10x62plane420Unorm3pack16Khr = 1000156013,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG10x6B10x6R10x63plane422Unorm3pack16Khr = 1000156014,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG10x6B10x6r10x62plane422Unorm3pack16Khr = 1000156015,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG10x6B10x6R10x63plane444Unorm3pack16Khr = 1000156016,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatR12x4UnormPack16Khr = 1000156017,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatR12x4g12x4Unorm2pack16Khr = 1000156018,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatR12x4g12x4b12x4a12x4Unorm4pack16Khr = 1000156019,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG12x4b12x4g12x4r12x4422Unorm4pack16Khr = 1000156020,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatB12x4g12x4r12x4g12x4422Unorm4pack16Khr = 1000156021,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG12x4B12x4R12x43plane420Unorm3pack16Khr = 1000156022,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG12x4B12x4r12x42plane420Unorm3pack16Khr = 1000156023,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG12x4B12x4R12x43plane422Unorm3pack16Khr = 1000156024,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG12x4B12x4r12x42plane422Unorm3pack16Khr = 1000156025,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG12x4B12x4R12x43plane444Unorm3pack16Khr = 1000156026,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG16b16g16r16422UnormKhr = 1000156027,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatB16g16r16g16422UnormKhr = 1000156028,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG16B16R163plane420UnormKhr = 1000156029,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG16B16r162plane420UnormKhr = 1000156030,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG16B16R163plane422UnormKhr = 1000156031,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG16B16r162plane422UnormKhr = 1000156032,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatG16B16R163plane444UnormKhr = 1000156033,
        /// <summary>[requires: VK_EXT_ycbcr_2plane_444_formats]</summary>
        FormatG8B8r82plane444UnormExt = 1000330000,
        /// <summary>[requires: VK_EXT_ycbcr_2plane_444_formats]</summary>
        FormatG10x6B10x6r10x62plane444Unorm3pack16Ext = 1000330001,
        /// <summary>[requires: VK_EXT_ycbcr_2plane_444_formats]</summary>
        FormatG12x4B12x4r12x42plane444Unorm3pack16Ext = 1000330002,
        /// <summary>[requires: VK_EXT_ycbcr_2plane_444_formats]</summary>
        FormatG16B16r162plane444UnormExt = 1000330003,
        /// <summary>[requires: VK_EXT_4444_formats]</summary>
        FormatA4r4g4b4UnormPack16Ext = 1000340000,
        /// <summary>[requires: VK_EXT_4444_formats]</summary>
        FormatA4b4g4r4UnormPack16Ext = 1000340001,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        FormatR16g16S105Nv = 1000464000,
    }
    public enum VkStructureType : int
    {
        StructureTypeApplicationInfo = 0,
        StructureTypeInstanceCreateInfo = 1,
        StructureTypeDeviceQueueCreateInfo = 2,
        StructureTypeDeviceCreateInfo = 3,
        StructureTypeSubmitInfo = 4,
        StructureTypeMemoryAllocateInfo = 5,
        StructureTypeMappedMemoryRange = 6,
        StructureTypeBindSparseInfo = 7,
        StructureTypeFenceCreateInfo = 8,
        StructureTypeSemaphoreCreateInfo = 9,
        StructureTypeEventCreateInfo = 10,
        StructureTypeQueryPoolCreateInfo = 11,
        StructureTypeBufferCreateInfo = 12,
        StructureTypeBufferViewCreateInfo = 13,
        StructureTypeImageCreateInfo = 14,
        StructureTypeImageViewCreateInfo = 15,
        StructureTypeShaderModuleCreateInfo = 16,
        StructureTypePipelineCacheCreateInfo = 17,
        StructureTypePipelineShaderStageCreateInfo = 18,
        StructureTypePipelineVertexInputStateCreateInfo = 19,
        StructureTypePipelineInputAssemblyStateCreateInfo = 20,
        StructureTypePipelineTessellationStateCreateInfo = 21,
        StructureTypePipelineViewportStateCreateInfo = 22,
        StructureTypePipelineRasterizationStateCreateInfo = 23,
        StructureTypePipelineMultisampleStateCreateInfo = 24,
        StructureTypePipelineDepthStencilStateCreateInfo = 25,
        StructureTypePipelineColorBlendStateCreateInfo = 26,
        StructureTypePipelineDynamicStateCreateInfo = 27,
        StructureTypeGraphicsPipelineCreateInfo = 28,
        StructureTypeComputePipelineCreateInfo = 29,
        StructureTypePipelineLayoutCreateInfo = 30,
        StructureTypeSamplerCreateInfo = 31,
        StructureTypeDescriptorSetLayoutCreateInfo = 32,
        StructureTypeDescriptorPoolCreateInfo = 33,
        StructureTypeDescriptorSetAllocateInfo = 34,
        StructureTypeWriteDescriptorSet = 35,
        StructureTypeCopyDescriptorSet = 36,
        StructureTypeFramebufferCreateInfo = 37,
        StructureTypeRenderPassCreateInfo = 38,
        StructureTypeCommandPoolCreateInfo = 39,
        StructureTypeCommandBufferAllocateInfo = 40,
        StructureTypeCommandBufferInheritanceInfo = 41,
        StructureTypeCommandBufferBeginInfo = 42,
        StructureTypeRenderPassBeginInfo = 43,
        StructureTypeBufferMemoryBarrier = 44,
        StructureTypeImageMemoryBarrier = 45,
        StructureTypeMemoryBarrier = 46,
        /// <summary>Reserved for internal use by the loader, layers, and ICDs</summary>
        StructureTypeLoaderInstanceCreateInfo = 47,
        /// <summary>Reserved for internal use by the loader, layers, and ICDs</summary>
        StructureTypeLoaderDeviceCreateInfo = 48,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceSubgroupProperties = 1000094000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeBindBufferMemoryInfo = 1000157000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeBindImageMemoryInfo = 1000157001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDevice16bitStorageFeatures = 1000083000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeMemoryDedicatedRequirements = 1000127000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeMemoryDedicatedAllocateInfo = 1000127001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeMemoryAllocateFlagsInfo = 1000060000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeDeviceGroupRenderPassBeginInfo = 1000060003,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeDeviceGroupCommandBufferBeginInfo = 1000060004,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeDeviceGroupSubmitInfo = 1000060005,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeDeviceGroupBindSparseInfo = 1000060006,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeBindBufferMemoryDeviceGroupInfo = 1000060013,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeBindImageMemoryDeviceGroupInfo = 1000060014,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceGroupProperties = 1000070000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeDeviceGroupDeviceCreateInfo = 1000070001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeBufferMemoryRequirementsInfo2 = 1000146000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeImageMemoryRequirementsInfo2 = 1000146001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeImageSparseMemoryRequirementsInfo2 = 1000146002,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeMemoryRequirements2 = 1000146003,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeSparseImageMemoryRequirements2 = 1000146004,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceFeatures2 = 1000059000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceProperties2 = 1000059001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeFormatProperties2 = 1000059002,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeImageFormatProperties2 = 1000059003,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceImageFormatInfo2 = 1000059004,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeQueueFamilyProperties2 = 1000059005,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceMemoryProperties2 = 1000059006,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeSparseImageFormatProperties2 = 1000059007,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceSparseImageFormatInfo2 = 1000059008,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDevicePointClippingProperties = 1000117000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeRenderPassInputAttachmentAspectCreateInfo = 1000117001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeImageViewUsageCreateInfo = 1000117002,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePipelineTessellationDomainOriginStateCreateInfo = 1000117003,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeRenderPassMultiviewCreateInfo = 1000053000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceMultiviewFeatures = 1000053001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceMultiviewProperties = 1000053002,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceVariablePointersFeatures = 1000120000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeProtectedSubmitInfo = 1000145000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceProtectedMemoryFeatures = 1000145001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceProtectedMemoryProperties = 1000145002,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeDeviceQueueInfo2 = 1000145003,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeSamplerYcbcrConversionCreateInfo = 1000156000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeSamplerYcbcrConversionInfo = 1000156001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeBindImagePlaneMemoryInfo = 1000156002,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeImagePlaneMemoryRequirementsInfo = 1000156003,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceSamplerYcbcrConversionFeatures = 1000156004,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeSamplerYcbcrConversionImageFormatProperties = 1000156005,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeDescriptorUpdateTemplateCreateInfo = 1000085000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceExternalImageFormatInfo = 1000071000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeExternalImageFormatProperties = 1000071001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceExternalBufferInfo = 1000071002,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeExternalBufferProperties = 1000071003,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceIdProperties = 1000071004,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeExternalMemoryBufferCreateInfo = 1000072000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeExternalMemoryImageCreateInfo = 1000072001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeExportMemoryAllocateInfo = 1000072002,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceExternalFenceInfo = 1000112000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeExternalFenceProperties = 1000112001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeExportFenceCreateInfo = 1000113000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeExportSemaphoreCreateInfo = 1000077000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceExternalSemaphoreInfo = 1000076000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeExternalSemaphoreProperties = 1000076001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceMaintenance3Properties = 1000168000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypeDescriptorSetLayoutSupport = 1000168001,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceShaderDrawParametersFeatures = 1000063000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceVulkan11Features = 49,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceVulkan11Properties = 50,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceVulkan12Features = 51,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceVulkan12Properties = 52,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeImageFormatListCreateInfo = 1000147000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeAttachmentDescription2 = 1000109000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeAttachmentReference2 = 1000109001,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeSubpassDescription2 = 1000109002,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeSubpassDependency2 = 1000109003,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeRenderPassCreateInfo2 = 1000109004,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeSubpassBeginInfo = 1000109005,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeSubpassEndInfo = 1000109006,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDevice8bitStorageFeatures = 1000177000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceDriverProperties = 1000196000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceShaderAtomicInt64Features = 1000180000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceShaderFloat16Int8Features = 1000082000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceFloatControlsProperties = 1000197000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeDescriptorSetLayoutBindingFlagsCreateInfo = 1000161000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceDescriptorIndexingFeatures = 1000161001,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceDescriptorIndexingProperties = 1000161002,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeDescriptorSetVariableDescriptorCountAllocateInfo = 1000161003,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeDescriptorSetVariableDescriptorCountLayoutSupport = 1000161004,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceDepthStencilResolveProperties = 1000199000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeSubpassDescriptionDepthStencilResolve = 1000199001,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceScalarBlockLayoutFeatures = 1000221000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeImageStencilUsageCreateInfo = 1000246000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceSamplerFilterMinmaxProperties = 1000130000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeSamplerReductionModeCreateInfo = 1000130001,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceVulkanMemoryModelFeatures = 1000211000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceImagelessFramebufferFeatures = 1000108000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeFramebufferAttachmentsCreateInfo = 1000108001,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeFramebufferAttachmentImageInfo = 1000108002,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeRenderPassAttachmentBeginInfo = 1000108003,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceUniformBufferStandardLayoutFeatures = 1000253000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceShaderSubgroupExtendedTypesFeatures = 1000175000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceSeparateDepthStencilLayoutsFeatures = 1000241000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeAttachmentReferenceStencilLayout = 1000241001,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeAttachmentDescriptionStencilLayout = 1000241002,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceHostQueryResetFeatures = 1000261000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceTimelineSemaphoreFeatures = 1000207000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceTimelineSemaphoreProperties = 1000207001,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeSemaphoreTypeCreateInfo = 1000207002,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeTimelineSemaphoreSubmitInfo = 1000207003,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeSemaphoreWaitInfo = 1000207004,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeSemaphoreSignalInfo = 1000207005,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypePhysicalDeviceBufferDeviceAddressFeatures = 1000257000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeBufferDeviceAddressInfo = 1000244001,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeBufferOpaqueCaptureAddressCreateInfo = 1000257002,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeMemoryOpaqueCaptureAddressAllocateInfo = 1000257003,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        StructureTypeDeviceMemoryOpaqueCaptureAddressInfo = 1000257004,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceVulkan13Features = 53,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceVulkan13Properties = 54,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePipelineCreationFeedbackCreateInfo = 1000192000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceShaderTerminateInvocationFeatures = 1000215000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceToolProperties = 1000245000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceShaderDemoteToHelperInvocationFeatures = 1000276000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDevicePrivateDataFeatures = 1000295000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeDevicePrivateDataCreateInfo = 1000295001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePrivateDataSlotCreateInfo = 1000295002,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDevicePipelineCreationCacheControlFeatures = 1000297000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeMemoryBarrier2 = 1000314000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeBufferMemoryBarrier2 = 1000314001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeImageMemoryBarrier2 = 1000314002,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeDependencyInfo = 1000314003,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeSubmitInfo2 = 1000314004,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeSemaphoreSubmitInfo = 1000314005,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeCommandBufferSubmitInfo = 1000314006,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceSynchronization2Features = 1000314007,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceZeroInitializeWorkgroupMemoryFeatures = 1000325000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceImageRobustnessFeatures = 1000335000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeCopyBufferInfo2 = 1000337000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeCopyImageInfo2 = 1000337001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeCopyBufferToImageInfo2 = 1000337002,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeCopyImageToBufferInfo2 = 1000337003,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeBlitImageInfo2 = 1000337004,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeResolveImageInfo2 = 1000337005,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeBufferCopy2 = 1000337006,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeImageCopy2 = 1000337007,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeImageBlit2 = 1000337008,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeBufferImageCopy2 = 1000337009,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeImageResolve2 = 1000337010,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceSubgroupSizeControlProperties = 1000225000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePipelineShaderStageRequiredSubgroupSizeCreateInfo = 1000225001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceSubgroupSizeControlFeatures = 1000225002,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceInlineUniformBlockFeatures = 1000138000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceInlineUniformBlockProperties = 1000138001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeWriteDescriptorSetInlineUniformBlock = 1000138002,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeDescriptorPoolInlineUniformBlockCreateInfo = 1000138003,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceTextureCompressionAstcHdrFeatures = 1000066000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeRenderingInfo = 1000044000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeRenderingAttachmentInfo = 1000044001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePipelineRenderingCreateInfo = 1000044002,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceDynamicRenderingFeatures = 1000044003,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeCommandBufferInheritanceRenderingInfo = 1000044004,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceShaderIntegerDotProductFeatures = 1000280000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceShaderIntegerDotProductProperties = 1000280001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceTexelBufferAlignmentProperties = 1000281001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeFormatProperties3 = 1000360000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceMaintenance4Features = 1000413000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypePhysicalDeviceMaintenance4Properties = 1000413001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeDeviceBufferMemoryRequirements = 1000413002,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        StructureTypeDeviceImageMemoryRequirements = 1000413003,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceVariablePointerFeatures = 1000120000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        StructureTypePhysicalDeviceShaderDrawParameterFeatures = 1000063000,
        /// <summary>[requires: VK_KHR_swapchain]</summary>
        StructureTypeSwapchainCreateInfoKhr = 1000001000,
        /// <summary>[requires: VK_KHR_swapchain]</summary>
        StructureTypePresentInfoKhr = 1000001001,
        /// <summary>[requires: VK_KHR_swapchain]</summary>
        StructureTypeDeviceGroupPresentCapabilitiesKhr = 1000060007,
        /// <summary>[requires: VK_KHR_swapchain]</summary>
        StructureTypeImageSwapchainCreateInfoKhr = 1000060008,
        /// <summary>[requires: VK_KHR_swapchain]</summary>
        StructureTypeBindImageMemorySwapchainInfoKhr = 1000060009,
        /// <summary>[requires: VK_KHR_swapchain]</summary>
        StructureTypeAcquireNextImageInfoKhr = 1000060010,
        /// <summary>[requires: VK_KHR_swapchain]</summary>
        StructureTypeDeviceGroupPresentInfoKhr = 1000060011,
        /// <summary>[requires: VK_KHR_swapchain]</summary>
        StructureTypeDeviceGroupSwapchainCreateInfoKhr = 1000060012,
        /// <summary>[requires: VK_KHR_display]</summary>
        StructureTypeDisplayModeCreateInfoKhr = 1000002000,
        /// <summary>[requires: VK_KHR_display]</summary>
        StructureTypeDisplaySurfaceCreateInfoKhr = 1000002001,
        /// <summary>[requires: VK_KHR_display_swapchain]</summary>
        StructureTypeDisplayPresentInfoKhr = 1000003000,
        /// <summary>[requires: VK_KHR_xlib_surface]</summary>
        StructureTypeXlibSurfaceCreateInfoKhr = 1000004000,
        /// <summary>[requires: VK_KHR_xcb_surface]</summary>
        StructureTypeXcbSurfaceCreateInfoKhr = 1000005000,
        /// <summary>[requires: VK_KHR_wayland_surface]</summary>
        StructureTypeWaylandSurfaceCreateInfoKhr = 1000006000,
        /// <summary>[requires: VK_KHR_android_surface]</summary>
        StructureTypeAndroidSurfaceCreateInfoKhr = 1000008000,
        /// <summary>[requires: VK_KHR_win32_surface]</summary>
        StructureTypeWin32SurfaceCreateInfoKhr = 1000009000,
        /// <summary>[requires: VK_EXT_debug_report]</summary>
        StructureTypeDebugReportCallbackCreateInfoExt = 1000011000,
        /// <summary>[requires: VK_AMD_rasterization_order]</summary>
        StructureTypePipelineRasterizationStateRasterizationOrderAmd = 1000018000,
        /// <summary>[requires: VK_EXT_debug_marker]</summary>
        StructureTypeDebugMarkerObjectNameInfoExt = 1000022000,
        /// <summary>[requires: VK_EXT_debug_marker]</summary>
        StructureTypeDebugMarkerObjectTagInfoExt = 1000022001,
        /// <summary>[requires: VK_EXT_debug_marker]</summary>
        StructureTypeDebugMarkerMarkerInfoExt = 1000022002,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoProfileInfoKhr = 1000023000,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoCapabilitiesKhr = 1000023001,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoPictureResourceInfoKhr = 1000023002,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoSessionMemoryRequirementsKhr = 1000023003,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeBindVideoSessionMemoryInfoKhr = 1000023004,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoSessionCreateInfoKhr = 1000023005,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoSessionParametersCreateInfoKhr = 1000023006,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoSessionParametersUpdateInfoKhr = 1000023007,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoBeginCodingInfoKhr = 1000023008,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoEndCodingInfoKhr = 1000023009,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoCodingControlInfoKhr = 1000023010,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoReferenceSlotInfoKhr = 1000023011,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeQueueFamilyVideoPropertiesKhr = 1000023012,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoProfileListInfoKhr = 1000023013,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypePhysicalDeviceVideoFormatInfoKhr = 1000023014,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeVideoFormatPropertiesKhr = 1000023015,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        StructureTypeQueueFamilyQueryResultStatusPropertiesKhr = 1000023016,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        StructureTypeVideoDecodeInfoKhr = 1000024000,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        StructureTypeVideoDecodeCapabilitiesKhr = 1000024001,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        StructureTypeVideoDecodeUsageInfoKhr = 1000024002,
        /// <summary>[requires: VK_NV_dedicated_allocation]</summary>
        StructureTypeDedicatedAllocationImageCreateInfoNv = 1000026000,
        /// <summary>[requires: VK_NV_dedicated_allocation]</summary>
        StructureTypeDedicatedAllocationBufferCreateInfoNv = 1000026001,
        /// <summary>[requires: VK_NV_dedicated_allocation]</summary>
        StructureTypeDedicatedAllocationMemoryAllocateInfoNv = 1000026002,
        /// <summary>[requires: VK_EXT_transform_feedback]</summary>
        StructureTypePhysicalDeviceTransformFeedbackFeaturesExt = 1000028000,
        /// <summary>[requires: VK_EXT_transform_feedback]</summary>
        StructureTypePhysicalDeviceTransformFeedbackPropertiesExt = 1000028001,
        /// <summary>[requires: VK_EXT_transform_feedback]</summary>
        StructureTypePipelineRasterizationStateStreamCreateInfoExt = 1000028002,
        /// <summary>[requires: VK_NVX_binary_import]</summary>
        StructureTypeCuModuleCreateInfoNvx = 1000029000,
        /// <summary>[requires: VK_NVX_binary_import]</summary>
        StructureTypeCuFunctionCreateInfoNvx = 1000029001,
        /// <summary>[requires: VK_NVX_binary_import]</summary>
        StructureTypeCuLaunchInfoNvx = 1000029002,
        /// <summary>[requires: VK_NVX_image_view_handle]</summary>
        StructureTypeImageViewHandleInfoNvx = 1000030000,
        /// <summary>[requires: VK_NVX_image_view_handle]</summary>
        StructureTypeImageViewAddressPropertiesNvx = 1000030001,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264CapabilitiesKhr = 1000038000,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264SessionParametersCreateInfoKhr = 1000038001,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264SessionParametersAddInfoKhr = 1000038002,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264PictureInfoKhr = 1000038003,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264DpbSlotInfoKhr = 1000038004,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264NaluSliceInfoKhr = 1000038005,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264GopRemainingFrameInfoKhr = 1000038006,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264ProfileInfoKhr = 1000038007,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264RateControlInfoKhr = 1000038008,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264RateControlLayerInfoKhr = 1000038009,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264SessionCreateInfoKhr = 1000038010,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264QualityLevelPropertiesKhr = 1000038011,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264SessionParametersGetInfoKhr = 1000038012,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        StructureTypeVideoEncodeH264SessionParametersFeedbackInfoKhr = 1000038013,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265CapabilitiesKhr = 1000039000,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265SessionParametersCreateInfoKhr = 1000039001,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265SessionParametersAddInfoKhr = 1000039002,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265PictureInfoKhr = 1000039003,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265DpbSlotInfoKhr = 1000039004,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265NaluSliceSegmentInfoKhr = 1000039005,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265GopRemainingFrameInfoKhr = 1000039006,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265ProfileInfoKhr = 1000039007,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265RateControlInfoKhr = 1000039009,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265RateControlLayerInfoKhr = 1000039010,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265SessionCreateInfoKhr = 1000039011,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265QualityLevelPropertiesKhr = 1000039012,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265SessionParametersGetInfoKhr = 1000039013,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        StructureTypeVideoEncodeH265SessionParametersFeedbackInfoKhr = 1000039014,
        /// <summary>[requires: VK_KHR_video_decode_h264]</summary>
        StructureTypeVideoDecodeH264CapabilitiesKhr = 1000040000,
        /// <summary>[requires: VK_KHR_video_decode_h264]</summary>
        StructureTypeVideoDecodeH264PictureInfoKhr = 1000040001,
        /// <summary>[requires: VK_KHR_video_decode_h264]</summary>
        StructureTypeVideoDecodeH264ProfileInfoKhr = 1000040003,
        /// <summary>[requires: VK_KHR_video_decode_h264]</summary>
        StructureTypeVideoDecodeH264SessionParametersCreateInfoKhr = 1000040004,
        /// <summary>[requires: VK_KHR_video_decode_h264]</summary>
        StructureTypeVideoDecodeH264SessionParametersAddInfoKhr = 1000040005,
        /// <summary>[requires: VK_KHR_video_decode_h264]</summary>
        StructureTypeVideoDecodeH264DpbSlotInfoKhr = 1000040006,
        /// <summary>[requires: VK_AMD_texture_gather_bias_lod]</summary>
        StructureTypeTextureLodGatherFormatPropertiesAmd = 1000041000,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        StructureTypeRenderingFragmentShadingRateAttachmentInfoKhr = 1000044006,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        StructureTypeRenderingFragmentDensityMapAttachmentInfoExt = 1000044007,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        StructureTypeAttachmentSampleCountInfoAmd = 1000044008,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        StructureTypeMultiviewPerViewAttributesInfoNvx = 1000044009,
        /// <summary>[requires: VK_GGP_stream_descriptor_surface]</summary>
        StructureTypeStreamDescriptorSurfaceCreateInfoGgp = 1000049000,
        /// <summary>[requires: VK_NV_corner_sampled_image]</summary>
        StructureTypePhysicalDeviceCornerSampledImageFeaturesNv = 1000050000,
        /// <summary>[requires: VK_NV_private_vendor_info]</summary>
        StructureTypePrivateVendorInfoPlaceholderOffset0Nv = 1000051000,
        /// <summary>[requires: VK_NV_external_memory]</summary>
        StructureTypeExternalMemoryImageCreateInfoNv = 1000056000,
        /// <summary>[requires: VK_NV_external_memory]</summary>
        StructureTypeExportMemoryAllocateInfoNv = 1000056001,
        /// <summary>[requires: VK_NV_external_memory_win32]</summary>
        StructureTypeImportMemoryWin32HandleInfoNv = 1000057000,
        /// <summary>[requires: VK_NV_external_memory_win32]</summary>
        StructureTypeExportMemoryWin32HandleInfoNv = 1000057001,
        /// <summary>[requires: VK_NV_win32_keyed_mutex]</summary>
        StructureTypeWin32KeyedMutexAcquireReleaseInfoNv = 1000058000,
        /// <summary>[requires: VK_EXT_validation_flags]</summary>
        StructureTypeValidationFlagsExt = 1000061000,
        /// <summary>[requires: VK_NN_vi_surface]</summary>
        StructureTypeViSurfaceCreateInfoNn = 1000062000,
        /// <summary>[requires: VK_EXT_astc_decode_mode]</summary>
        StructureTypeImageViewAstcDecodeModeExt = 1000067000,
        /// <summary>[requires: VK_EXT_astc_decode_mode]</summary>
        StructureTypePhysicalDeviceAstcDecodeFeaturesExt = 1000067001,
        /// <summary>[requires: VK_EXT_pipeline_robustness]</summary>
        StructureTypePipelineRobustnessCreateInfoExt = 1000068000,
        /// <summary>[requires: VK_EXT_pipeline_robustness]</summary>
        StructureTypePhysicalDevicePipelineRobustnessFeaturesExt = 1000068001,
        /// <summary>[requires: VK_EXT_pipeline_robustness]</summary>
        StructureTypePhysicalDevicePipelineRobustnessPropertiesExt = 1000068002,
        /// <summary>[requires: VK_KHR_external_memory_win32]</summary>
        StructureTypeImportMemoryWin32HandleInfoKhr = 1000073000,
        /// <summary>[requires: VK_KHR_external_memory_win32]</summary>
        StructureTypeExportMemoryWin32HandleInfoKhr = 1000073001,
        /// <summary>[requires: VK_KHR_external_memory_win32]</summary>
        StructureTypeMemoryWin32HandlePropertiesKhr = 1000073002,
        /// <summary>[requires: VK_KHR_external_memory_win32]</summary>
        StructureTypeMemoryGetWin32HandleInfoKhr = 1000073003,
        /// <summary>[requires: VK_KHR_external_memory_fd]</summary>
        StructureTypeImportMemoryFdInfoKhr = 1000074000,
        /// <summary>[requires: VK_KHR_external_memory_fd]</summary>
        StructureTypeMemoryFdPropertiesKhr = 1000074001,
        /// <summary>[requires: VK_KHR_external_memory_fd]</summary>
        StructureTypeMemoryGetFdInfoKhr = 1000074002,
        /// <summary>[requires: VK_KHR_win32_keyed_mutex]</summary>
        StructureTypeWin32KeyedMutexAcquireReleaseInfoKhr = 1000075000,
        /// <summary>[requires: VK_KHR_external_semaphore_win32]</summary>
        StructureTypeImportSemaphoreWin32HandleInfoKhr = 1000078000,
        /// <summary>[requires: VK_KHR_external_semaphore_win32]</summary>
        StructureTypeExportSemaphoreWin32HandleInfoKhr = 1000078001,
        /// <summary>[requires: VK_KHR_external_semaphore_win32]</summary>
        StructureTypeD3d12FenceSubmitInfoKhr = 1000078002,
        /// <summary>[requires: VK_KHR_external_semaphore_win32]</summary>
        StructureTypeSemaphoreGetWin32HandleInfoKhr = 1000078003,
        /// <summary>[requires: VK_KHR_external_semaphore_fd]</summary>
        StructureTypeImportSemaphoreFdInfoKhr = 1000079000,
        /// <summary>[requires: VK_KHR_external_semaphore_fd]</summary>
        StructureTypeSemaphoreGetFdInfoKhr = 1000079001,
        /// <summary>[requires: VK_KHR_push_descriptor]</summary>
        StructureTypePhysicalDevicePushDescriptorPropertiesKhr = 1000080000,
        /// <summary>[requires: VK_EXT_conditional_rendering]</summary>
        StructureTypeCommandBufferInheritanceConditionalRenderingInfoExt = 1000081000,
        /// <summary>[requires: VK_EXT_conditional_rendering]</summary>
        StructureTypePhysicalDeviceConditionalRenderingFeaturesExt = 1000081001,
        /// <summary>[requires: VK_EXT_conditional_rendering]</summary>
        StructureTypeConditionalRenderingBeginInfoExt = 1000081002,
        /// <summary>[requires: VK_KHR_incremental_present]</summary>
        StructureTypePresentRegionsKhr = 1000084000,
        /// <summary>[requires: VK_NV_clip_space_w_scaling]</summary>
        StructureTypePipelineViewportWScalingStateCreateInfoNv = 1000087000,
        /// <summary>[requires: VK_EXT_display_surface_counter]</summary>
        StructureTypeSurfaceCapabilities2Ext = 1000090000,
        /// <summary>[requires: VK_EXT_display_control]</summary>
        StructureTypeDisplayPowerInfoExt = 1000091000,
        /// <summary>[requires: VK_EXT_display_control]</summary>
        StructureTypeDeviceEventInfoExt = 1000091001,
        /// <summary>[requires: VK_EXT_display_control]</summary>
        StructureTypeDisplayEventInfoExt = 1000091002,
        /// <summary>[requires: VK_EXT_display_control]</summary>
        StructureTypeSwapchainCounterCreateInfoExt = 1000091003,
        /// <summary>[requires: VK_GOOGLE_display_timing]</summary>
        StructureTypePresentTimesInfoGoogle = 1000092000,
        /// <summary>[requires: VK_NVX_multiview_per_view_attributes]</summary>
        StructureTypePhysicalDeviceMultiviewPerViewAttributesPropertiesNvx = 1000097000,
        /// <summary>[requires: VK_NV_viewport_swizzle]</summary>
        StructureTypePipelineViewportSwizzleStateCreateInfoNv = 1000098000,
        /// <summary>[requires: VK_EXT_discard_rectangles]</summary>
        StructureTypePhysicalDeviceDiscardRectanglePropertiesExt = 1000099000,
        /// <summary>[requires: VK_EXT_discard_rectangles]</summary>
        StructureTypePipelineDiscardRectangleStateCreateInfoExt = 1000099001,
        /// <summary>[requires: VK_EXT_conservative_rasterization]</summary>
        StructureTypePhysicalDeviceConservativeRasterizationPropertiesExt = 1000101000,
        /// <summary>[requires: VK_EXT_conservative_rasterization]</summary>
        StructureTypePipelineRasterizationConservativeStateCreateInfoExt = 1000101001,
        /// <summary>[requires: VK_EXT_depth_clip_enable]</summary>
        StructureTypePhysicalDeviceDepthClipEnableFeaturesExt = 1000102000,
        /// <summary>[requires: VK_EXT_depth_clip_enable]</summary>
        StructureTypePipelineRasterizationDepthClipStateCreateInfoExt = 1000102001,
        /// <summary>[requires: VK_EXT_hdr_metadata]</summary>
        StructureTypeHdrMetadataExt = 1000105000,
        /// <summary>[requires: VK_IMG_relaxed_line_rasterization]</summary>
        StructureTypePhysicalDeviceRelaxedLineRasterizationFeaturesImg = 1000110000,
        /// <summary>[requires: VK_KHR_shared_presentable_image]</summary>
        StructureTypeSharedPresentSurfaceCapabilitiesKhr = 1000111000,
        /// <summary>[requires: VK_KHR_external_fence_win32]</summary>
        StructureTypeImportFenceWin32HandleInfoKhr = 1000114000,
        /// <summary>[requires: VK_KHR_external_fence_win32]</summary>
        StructureTypeExportFenceWin32HandleInfoKhr = 1000114001,
        /// <summary>[requires: VK_KHR_external_fence_win32]</summary>
        StructureTypeFenceGetWin32HandleInfoKhr = 1000114002,
        /// <summary>[requires: VK_KHR_external_fence_fd]</summary>
        StructureTypeImportFenceFdInfoKhr = 1000115000,
        /// <summary>[requires: VK_KHR_external_fence_fd]</summary>
        StructureTypeFenceGetFdInfoKhr = 1000115001,
        /// <summary>[requires: VK_KHR_performance_query]</summary>
        StructureTypePhysicalDevicePerformanceQueryFeaturesKhr = 1000116000,
        /// <summary>[requires: VK_KHR_performance_query]</summary>
        StructureTypePhysicalDevicePerformanceQueryPropertiesKhr = 1000116001,
        /// <summary>[requires: VK_KHR_performance_query]</summary>
        StructureTypeQueryPoolPerformanceCreateInfoKhr = 1000116002,
        /// <summary>[requires: VK_KHR_performance_query]</summary>
        StructureTypePerformanceQuerySubmitInfoKhr = 1000116003,
        /// <summary>[requires: VK_KHR_performance_query]</summary>
        StructureTypeAcquireProfilingLockInfoKhr = 1000116004,
        /// <summary>[requires: VK_KHR_performance_query]</summary>
        StructureTypePerformanceCounterKhr = 1000116005,
        /// <summary>[requires: VK_KHR_performance_query]</summary>
        StructureTypePerformanceCounterDescriptionKhr = 1000116006,
        /// <summary>[requires: VK_KHR_get_surface_capabilities2]</summary>
        StructureTypePhysicalDeviceSurfaceInfo2Khr = 1000119000,
        /// <summary>[requires: VK_KHR_get_surface_capabilities2]</summary>
        StructureTypeSurfaceCapabilities2Khr = 1000119001,
        /// <summary>[requires: VK_KHR_get_surface_capabilities2]</summary>
        StructureTypeSurfaceFormat2Khr = 1000119002,
        /// <summary>[requires: VK_KHR_get_display_properties2]</summary>
        StructureTypeDisplayProperties2Khr = 1000121000,
        /// <summary>[requires: VK_KHR_get_display_properties2]</summary>
        StructureTypeDisplayPlaneProperties2Khr = 1000121001,
        /// <summary>[requires: VK_KHR_get_display_properties2]</summary>
        StructureTypeDisplayModeProperties2Khr = 1000121002,
        /// <summary>[requires: VK_KHR_get_display_properties2]</summary>
        StructureTypeDisplayPlaneInfo2Khr = 1000121003,
        /// <summary>[requires: VK_KHR_get_display_properties2]</summary>
        StructureTypeDisplayPlaneCapabilities2Khr = 1000121004,
        /// <summary>[requires: VK_MVK_ios_surface]</summary>
        StructureTypeIosSurfaceCreateInfoMvk = 1000122000,
        /// <summary>[requires: VK_MVK_macos_surface]</summary>
        StructureTypeMacosSurfaceCreateInfoMvk = 1000123000,
        /// <summary>[requires: VK_EXT_debug_utils]</summary>
        StructureTypeDebugUtilsObjectNameInfoExt = 1000128000,
        /// <summary>[requires: VK_EXT_debug_utils]</summary>
        StructureTypeDebugUtilsObjectTagInfoExt = 1000128001,
        /// <summary>[requires: VK_EXT_debug_utils]</summary>
        StructureTypeDebugUtilsLabelExt = 1000128002,
        /// <summary>[requires: VK_EXT_debug_utils]</summary>
        StructureTypeDebugUtilsMessengerCallbackDataExt = 1000128003,
        /// <summary>[requires: VK_EXT_debug_utils]</summary>
        StructureTypeDebugUtilsMessengerCreateInfoExt = 1000128004,
        /// <summary>[requires: VK_ANDROID_external_memory_android_hardware_buffer]</summary>
        StructureTypeAndroidHardwareBufferUsageAndroid = 1000129000,
        /// <summary>[requires: VK_ANDROID_external_memory_android_hardware_buffer]</summary>
        StructureTypeAndroidHardwareBufferPropertiesAndroid = 1000129001,
        /// <summary>[requires: VK_ANDROID_external_memory_android_hardware_buffer]</summary>
        StructureTypeAndroidHardwareBufferFormatPropertiesAndroid = 1000129002,
        /// <summary>[requires: VK_ANDROID_external_memory_android_hardware_buffer]</summary>
        StructureTypeImportAndroidHardwareBufferInfoAndroid = 1000129003,
        /// <summary>[requires: VK_ANDROID_external_memory_android_hardware_buffer]</summary>
        StructureTypeMemoryGetAndroidHardwareBufferInfoAndroid = 1000129004,
        /// <summary>[requires: VK_ANDROID_external_memory_android_hardware_buffer]</summary>
        StructureTypeExternalFormatAndroid = 1000129005,
        /// <summary>[requires: VK_ANDROID_external_memory_android_hardware_buffer]</summary>
        StructureTypeAndroidHardwareBufferFormatProperties2Android = 1000129006,
        /// <summary>[requires: VK_AMDX_shader_enqueue]</summary>
        StructureTypePhysicalDeviceShaderEnqueueFeaturesAmdx = 1000134000,
        /// <summary>[requires: VK_AMDX_shader_enqueue]</summary>
        StructureTypePhysicalDeviceShaderEnqueuePropertiesAmdx = 1000134001,
        /// <summary>[requires: VK_AMDX_shader_enqueue]</summary>
        StructureTypeExecutionGraphPipelineScratchSizeAmdx = 1000134002,
        /// <summary>[requires: VK_AMDX_shader_enqueue]</summary>
        StructureTypeExecutionGraphPipelineCreateInfoAmdx = 1000134003,
        /// <summary>[requires: VK_AMDX_shader_enqueue]</summary>
        StructureTypePipelineShaderStageNodeCreateInfoAmdx = 1000134004,
        /// <summary>[requires: VK_EXT_sample_locations]</summary>
        StructureTypeSampleLocationsInfoExt = 1000143000,
        /// <summary>[requires: VK_EXT_sample_locations]</summary>
        StructureTypeRenderPassSampleLocationsBeginInfoExt = 1000143001,
        /// <summary>[requires: VK_EXT_sample_locations]</summary>
        StructureTypePipelineSampleLocationsStateCreateInfoExt = 1000143002,
        /// <summary>[requires: VK_EXT_sample_locations]</summary>
        StructureTypePhysicalDeviceSampleLocationsPropertiesExt = 1000143003,
        /// <summary>[requires: VK_EXT_sample_locations]</summary>
        StructureTypeMultisamplePropertiesExt = 1000143004,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        StructureTypePhysicalDeviceBlendOperationAdvancedFeaturesExt = 1000148000,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        StructureTypePhysicalDeviceBlendOperationAdvancedPropertiesExt = 1000148001,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        StructureTypePipelineColorBlendAdvancedStateCreateInfoExt = 1000148002,
        /// <summary>[requires: VK_NV_fragment_coverage_to_color]</summary>
        StructureTypePipelineCoverageToColorStateCreateInfoNv = 1000149000,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeWriteDescriptorSetAccelerationStructureKhr = 1000150007,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeAccelerationStructureBuildGeometryInfoKhr = 1000150000,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeAccelerationStructureDeviceAddressInfoKhr = 1000150002,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeAccelerationStructureGeometryAabbsDataKhr = 1000150003,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeAccelerationStructureGeometryInstancesDataKhr = 1000150004,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeAccelerationStructureGeometryTrianglesDataKhr = 1000150005,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeAccelerationStructureGeometryKhr = 1000150006,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeAccelerationStructureVersionInfoKhr = 1000150009,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeCopyAccelerationStructureInfoKhr = 1000150010,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeCopyAccelerationStructureToMemoryInfoKhr = 1000150011,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeCopyMemoryToAccelerationStructureInfoKhr = 1000150012,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypePhysicalDeviceAccelerationStructureFeaturesKhr = 1000150013,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypePhysicalDeviceAccelerationStructurePropertiesKhr = 1000150014,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeAccelerationStructureCreateInfoKhr = 1000150017,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        StructureTypeAccelerationStructureBuildSizesInfoKhr = 1000150020,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        StructureTypePhysicalDeviceRayTracingPipelineFeaturesKhr = 1000347000,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        StructureTypePhysicalDeviceRayTracingPipelinePropertiesKhr = 1000347001,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        StructureTypeRayTracingPipelineCreateInfoKhr = 1000150015,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        StructureTypeRayTracingShaderGroupCreateInfoKhr = 1000150016,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        StructureTypeRayTracingPipelineInterfaceCreateInfoKhr = 1000150018,
        /// <summary>[requires: VK_KHR_ray_query]</summary>
        StructureTypePhysicalDeviceRayQueryFeaturesKhr = 1000348013,
        /// <summary>[requires: VK_NV_framebuffer_mixed_samples]</summary>
        StructureTypePipelineCoverageModulationStateCreateInfoNv = 1000152000,
        /// <summary>[requires: VK_NV_shader_sm_builtins]</summary>
        StructureTypePhysicalDeviceShaderSmBuiltinsFeaturesNv = 1000154000,
        /// <summary>[requires: VK_NV_shader_sm_builtins]</summary>
        StructureTypePhysicalDeviceShaderSmBuiltinsPropertiesNv = 1000154001,
        /// <summary>[requires: VK_EXT_image_drm_format_modifier]</summary>
        StructureTypeDrmFormatModifierPropertiesListExt = 1000158000,
        /// <summary>[requires: VK_EXT_image_drm_format_modifier]</summary>
        StructureTypePhysicalDeviceImageDrmFormatModifierInfoExt = 1000158002,
        /// <summary>[requires: VK_EXT_image_drm_format_modifier]</summary>
        StructureTypeImageDrmFormatModifierListCreateInfoExt = 1000158003,
        /// <summary>[requires: VK_EXT_image_drm_format_modifier]</summary>
        StructureTypeImageDrmFormatModifierExplicitCreateInfoExt = 1000158004,
        /// <summary>[requires: VK_EXT_image_drm_format_modifier]</summary>
        StructureTypeImageDrmFormatModifierPropertiesExt = 1000158005,
        /// <summary>[requires: VK_EXT_image_drm_format_modifier]</summary>
        StructureTypeDrmFormatModifierPropertiesList2Ext = 1000158006,
        /// <summary>[requires: VK_EXT_validation_cache]</summary>
        StructureTypeValidationCacheCreateInfoExt = 1000160000,
        /// <summary>[requires: VK_EXT_validation_cache]</summary>
        StructureTypeShaderModuleValidationCacheCreateInfoExt = 1000160001,
        /// <summary>[requires: VK_KHR_portability_subset]</summary>
        StructureTypePhysicalDevicePortabilitySubsetFeaturesKhr = 1000163000,
        /// <summary>[requires: VK_KHR_portability_subset]</summary>
        StructureTypePhysicalDevicePortabilitySubsetPropertiesKhr = 1000163001,
        /// <summary>[requires: VK_NV_shading_rate_image]</summary>
        StructureTypePipelineViewportShadingRateImageStateCreateInfoNv = 1000164000,
        /// <summary>[requires: VK_NV_shading_rate_image]</summary>
        StructureTypePhysicalDeviceShadingRateImageFeaturesNv = 1000164001,
        /// <summary>[requires: VK_NV_shading_rate_image]</summary>
        StructureTypePhysicalDeviceShadingRateImagePropertiesNv = 1000164002,
        /// <summary>[requires: VK_NV_shading_rate_image]</summary>
        StructureTypePipelineViewportCoarseSampleOrderStateCreateInfoNv = 1000164005,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        StructureTypeRayTracingPipelineCreateInfoNv = 1000165000,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        StructureTypeAccelerationStructureCreateInfoNv = 1000165001,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        StructureTypeGeometryNv = 1000165003,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        StructureTypeGeometryTrianglesNv = 1000165004,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        StructureTypeGeometryAabbNv = 1000165005,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        StructureTypeBindAccelerationStructureMemoryInfoNv = 1000165006,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        StructureTypeWriteDescriptorSetAccelerationStructureNv = 1000165007,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        StructureTypeAccelerationStructureMemoryRequirementsInfoNv = 1000165008,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        StructureTypePhysicalDeviceRayTracingPropertiesNv = 1000165009,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        StructureTypeRayTracingShaderGroupCreateInfoNv = 1000165011,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        StructureTypeAccelerationStructureInfoNv = 1000165012,
        /// <summary>[requires: VK_NV_representative_fragment_test]</summary>
        StructureTypePhysicalDeviceRepresentativeFragmentTestFeaturesNv = 1000166000,
        /// <summary>[requires: VK_NV_representative_fragment_test]</summary>
        StructureTypePipelineRepresentativeFragmentTestStateCreateInfoNv = 1000166001,
        /// <summary>[requires: VK_EXT_filter_cubic]</summary>
        StructureTypePhysicalDeviceImageViewImageFormatInfoExt = 1000170000,
        /// <summary>[requires: VK_EXT_filter_cubic]</summary>
        StructureTypeFilterCubicImageViewImageFormatPropertiesExt = 1000170001,
        /// <summary>[requires: VK_EXT_external_memory_host]</summary>
        StructureTypeImportMemoryHostPointerInfoExt = 1000178000,
        /// <summary>[requires: VK_EXT_external_memory_host]</summary>
        StructureTypeMemoryHostPointerPropertiesExt = 1000178001,
        /// <summary>[requires: VK_EXT_external_memory_host]</summary>
        StructureTypePhysicalDeviceExternalMemoryHostPropertiesExt = 1000178002,
        /// <summary>[requires: VK_KHR_shader_clock]</summary>
        StructureTypePhysicalDeviceShaderClockFeaturesKhr = 1000181000,
        /// <summary>[requires: VK_AMD_pipeline_compiler_control]</summary>
        StructureTypePipelineCompilerControlCreateInfoAmd = 1000183000,
        /// <summary>[requires: VK_AMD_shader_core_properties]</summary>
        StructureTypePhysicalDeviceShaderCorePropertiesAmd = 1000185000,
        /// <summary>[requires: VK_KHR_video_decode_h265]</summary>
        StructureTypeVideoDecodeH265CapabilitiesKhr = 1000187000,
        /// <summary>[requires: VK_KHR_video_decode_h265]</summary>
        StructureTypeVideoDecodeH265SessionParametersCreateInfoKhr = 1000187001,
        /// <summary>[requires: VK_KHR_video_decode_h265]</summary>
        StructureTypeVideoDecodeH265SessionParametersAddInfoKhr = 1000187002,
        /// <summary>[requires: VK_KHR_video_decode_h265]</summary>
        StructureTypeVideoDecodeH265ProfileInfoKhr = 1000187003,
        /// <summary>[requires: VK_KHR_video_decode_h265]</summary>
        StructureTypeVideoDecodeH265PictureInfoKhr = 1000187004,
        /// <summary>[requires: VK_KHR_video_decode_h265]</summary>
        StructureTypeVideoDecodeH265DpbSlotInfoKhr = 1000187005,
        /// <summary>[requires: VK_KHR_global_priority]</summary>
        StructureTypeDeviceQueueGlobalPriorityCreateInfoKhr = 1000174000,
        /// <summary>[requires: VK_KHR_global_priority]</summary>
        StructureTypePhysicalDeviceGlobalPriorityQueryFeaturesKhr = 1000388000,
        /// <summary>[requires: VK_KHR_global_priority]</summary>
        StructureTypeQueueFamilyGlobalPriorityPropertiesKhr = 1000388001,
        /// <summary>[requires: VK_AMD_memory_overallocation_behavior]</summary>
        StructureTypeDeviceMemoryOverallocationCreateInfoAmd = 1000189000,
        /// <summary>[requires: VK_EXT_vertex_attribute_divisor]</summary>
        StructureTypePhysicalDeviceVertexAttributeDivisorPropertiesExt = 1000190000,
        /// <summary>[requires: VK_GGP_frame_token]</summary>
        StructureTypePresentFrameTokenGgp = 1000191000,
        /// <summary>[requires: VK_NV_compute_shader_derivatives]</summary>
        StructureTypePhysicalDeviceComputeShaderDerivativesFeaturesNv = 1000201000,
        /// <summary>[requires: VK_NV_mesh_shader]</summary>
        StructureTypePhysicalDeviceMeshShaderFeaturesNv = 1000202000,
        /// <summary>[requires: VK_NV_mesh_shader]</summary>
        StructureTypePhysicalDeviceMeshShaderPropertiesNv = 1000202001,
        /// <summary>[requires: VK_NV_shader_image_footprint]</summary>
        StructureTypePhysicalDeviceShaderImageFootprintFeaturesNv = 1000204000,
        /// <summary>[requires: VK_NV_scissor_exclusive]</summary>
        StructureTypePipelineViewportExclusiveScissorStateCreateInfoNv = 1000205000,
        /// <summary>[requires: VK_NV_scissor_exclusive]</summary>
        StructureTypePhysicalDeviceExclusiveScissorFeaturesNv = 1000205002,
        /// <summary>[requires: VK_NV_device_diagnostic_checkpoints]</summary>
        StructureTypeCheckpointDataNv = 1000206000,
        /// <summary>[requires: VK_NV_device_diagnostic_checkpoints]</summary>
        StructureTypeQueueFamilyCheckpointPropertiesNv = 1000206001,
        /// <summary>[requires: VK_INTEL_shader_integer_functions2]</summary>
        StructureTypePhysicalDeviceShaderIntegerFunctions2FeaturesIntel = 1000209000,
        /// <summary>[requires: VK_INTEL_performance_query]</summary>
        StructureTypeQueryPoolPerformanceQueryCreateInfoIntel = 1000210000,
        /// <summary>[requires: VK_INTEL_performance_query]</summary>
        StructureTypeInitializePerformanceApiInfoIntel = 1000210001,
        /// <summary>[requires: VK_INTEL_performance_query]</summary>
        StructureTypePerformanceMarkerInfoIntel = 1000210002,
        /// <summary>[requires: VK_INTEL_performance_query]</summary>
        StructureTypePerformanceStreamMarkerInfoIntel = 1000210003,
        /// <summary>[requires: VK_INTEL_performance_query]</summary>
        StructureTypePerformanceOverrideInfoIntel = 1000210004,
        /// <summary>[requires: VK_INTEL_performance_query]</summary>
        StructureTypePerformanceConfigurationAcquireInfoIntel = 1000210005,
        /// <summary>[requires: VK_EXT_pci_bus_info]</summary>
        StructureTypePhysicalDevicePciBusInfoPropertiesExt = 1000212000,
        /// <summary>[requires: VK_AMD_display_native_hdr]</summary>
        StructureTypeDisplayNativeHdrSurfaceCapabilitiesAmd = 1000213000,
        /// <summary>[requires: VK_AMD_display_native_hdr]</summary>
        StructureTypeSwapchainDisplayNativeHdrCreateInfoAmd = 1000213001,
        /// <summary>[requires: VK_FUCHSIA_imagepipe_surface]</summary>
        StructureTypeImagepipeSurfaceCreateInfoFuchsia = 1000214000,
        /// <summary>[requires: VK_EXT_metal_surface]</summary>
        StructureTypeMetalSurfaceCreateInfoExt = 1000217000,
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        StructureTypePhysicalDeviceFragmentDensityMapFeaturesExt = 1000218000,
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        StructureTypePhysicalDeviceFragmentDensityMapPropertiesExt = 1000218001,
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        StructureTypeRenderPassFragmentDensityMapCreateInfoExt = 1000218002,
        /// <summary>[requires: VK_KHR_fragment_shading_rate]</summary>
        StructureTypeFragmentShadingRateAttachmentInfoKhr = 1000226000,
        /// <summary>[requires: VK_KHR_fragment_shading_rate]</summary>
        StructureTypePipelineFragmentShadingRateStateCreateInfoKhr = 1000226001,
        /// <summary>[requires: VK_KHR_fragment_shading_rate]</summary>
        StructureTypePhysicalDeviceFragmentShadingRatePropertiesKhr = 1000226002,
        /// <summary>[requires: VK_KHR_fragment_shading_rate]</summary>
        StructureTypePhysicalDeviceFragmentShadingRateFeaturesKhr = 1000226003,
        /// <summary>[requires: VK_KHR_fragment_shading_rate]</summary>
        StructureTypePhysicalDeviceFragmentShadingRateKhr = 1000226004,
        /// <summary>[requires: VK_AMD_shader_core_properties2]</summary>
        StructureTypePhysicalDeviceShaderCoreProperties2Amd = 1000227000,
        /// <summary>[requires: VK_AMD_device_coherent_memory]</summary>
        StructureTypePhysicalDeviceCoherentMemoryFeaturesAmd = 1000229000,
        /// <summary>[requires: VK_KHR_dynamic_rendering_local_read]</summary>
        StructureTypePhysicalDeviceDynamicRenderingLocalReadFeaturesKhr = 1000232000,
        /// <summary>[requires: VK_KHR_dynamic_rendering_local_read]</summary>
        StructureTypeRenderingAttachmentLocationInfoKhr = 1000232001,
        /// <summary>[requires: VK_KHR_dynamic_rendering_local_read]</summary>
        StructureTypeRenderingInputAttachmentIndexInfoKhr = 1000232002,
        /// <summary>[requires: VK_EXT_shader_image_atomic_int64]</summary>
        StructureTypePhysicalDeviceShaderImageAtomicInt64FeaturesExt = 1000234000,
        /// <summary>[requires: VK_KHR_shader_quad_control]</summary>
        StructureTypePhysicalDeviceShaderQuadControlFeaturesKhr = 1000235000,
        /// <summary>[requires: VK_EXT_memory_budget]</summary>
        StructureTypePhysicalDeviceMemoryBudgetPropertiesExt = 1000237000,
        /// <summary>[requires: VK_EXT_memory_priority]</summary>
        StructureTypePhysicalDeviceMemoryPriorityFeaturesExt = 1000238000,
        /// <summary>[requires: VK_EXT_memory_priority]</summary>
        StructureTypeMemoryPriorityAllocateInfoExt = 1000238001,
        /// <summary>[requires: VK_KHR_surface_protected_capabilities]</summary>
        StructureTypeSurfaceProtectedCapabilitiesKhr = 1000239000,
        /// <summary>[requires: VK_NV_dedicated_allocation_image_aliasing]</summary>
        StructureTypePhysicalDeviceDedicatedAllocationImageAliasingFeaturesNv = 1000240000,
        /// <summary>[requires: VK_EXT_buffer_device_address]</summary>
        StructureTypePhysicalDeviceBufferDeviceAddressFeaturesExt = 1000244000,
        /// <summary>[requires: VK_EXT_buffer_device_address]</summary>
        StructureTypeBufferDeviceAddressCreateInfoExt = 1000244002,
        /// <summary>[requires: VK_EXT_validation_features]</summary>
        StructureTypeValidationFeaturesExt = 1000247000,
        /// <summary>[requires: VK_KHR_present_wait]</summary>
        StructureTypePhysicalDevicePresentWaitFeaturesKhr = 1000248000,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        StructureTypePhysicalDeviceCooperativeMatrixFeaturesNv = 1000249000,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        StructureTypeCooperativeMatrixPropertiesNv = 1000249001,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        StructureTypePhysicalDeviceCooperativeMatrixPropertiesNv = 1000249002,
        /// <summary>[requires: VK_NV_coverage_reduction_mode]</summary>
        StructureTypePhysicalDeviceCoverageReductionModeFeaturesNv = 1000250000,
        /// <summary>[requires: VK_NV_coverage_reduction_mode]</summary>
        StructureTypePipelineCoverageReductionStateCreateInfoNv = 1000250001,
        /// <summary>[requires: VK_NV_coverage_reduction_mode]</summary>
        StructureTypeFramebufferMixedSamplesCombinationNv = 1000250002,
        /// <summary>[requires: VK_EXT_fragment_shader_interlock]</summary>
        StructureTypePhysicalDeviceFragmentShaderInterlockFeaturesExt = 1000251000,
        /// <summary>[requires: VK_EXT_ycbcr_image_arrays]</summary>
        StructureTypePhysicalDeviceYcbcrImageArraysFeaturesExt = 1000252000,
        /// <summary>[requires: VK_EXT_provoking_vertex]</summary>
        StructureTypePhysicalDeviceProvokingVertexFeaturesExt = 1000254000,
        /// <summary>[requires: VK_EXT_provoking_vertex]</summary>
        StructureTypePipelineRasterizationProvokingVertexStateCreateInfoExt = 1000254001,
        /// <summary>[requires: VK_EXT_provoking_vertex]</summary>
        StructureTypePhysicalDeviceProvokingVertexPropertiesExt = 1000254002,
        /// <summary>[requires: VK_EXT_full_screen_exclusive]</summary>
        StructureTypeSurfaceFullScreenExclusiveInfoExt = 1000255000,
        /// <summary>[requires: VK_EXT_full_screen_exclusive]</summary>
        StructureTypeSurfaceCapabilitiesFullScreenExclusiveExt = 1000255002,
        /// <summary>[requires: VK_EXT_full_screen_exclusive]</summary>
        StructureTypeSurfaceFullScreenExclusiveWin32InfoExt = 1000255001,
        /// <summary>[requires: VK_EXT_headless_surface]</summary>
        StructureTypeHeadlessSurfaceCreateInfoExt = 1000256000,
        /// <summary>[requires: VK_EXT_shader_atomic_float]</summary>
        StructureTypePhysicalDeviceShaderAtomicFloatFeaturesExt = 1000260000,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]Not promoted to 1.3</summary>
        StructureTypePhysicalDeviceExtendedDynamicStateFeaturesExt = 1000267000,
        /// <summary>[requires: VK_KHR_pipeline_executable_properties]</summary>
        StructureTypePhysicalDevicePipelineExecutablePropertiesFeaturesKhr = 1000269000,
        /// <summary>[requires: VK_KHR_pipeline_executable_properties]</summary>
        StructureTypePipelineInfoKhr = 1000269001,
        /// <summary>[requires: VK_KHR_pipeline_executable_properties]</summary>
        StructureTypePipelineExecutablePropertiesKhr = 1000269002,
        /// <summary>[requires: VK_KHR_pipeline_executable_properties]</summary>
        StructureTypePipelineExecutableInfoKhr = 1000269003,
        /// <summary>[requires: VK_KHR_pipeline_executable_properties]</summary>
        StructureTypePipelineExecutableStatisticKhr = 1000269004,
        /// <summary>[requires: VK_KHR_pipeline_executable_properties]</summary>
        StructureTypePipelineExecutableInternalRepresentationKhr = 1000269005,
        /// <summary>[requires: VK_EXT_host_image_copy]</summary>
        StructureTypePhysicalDeviceHostImageCopyFeaturesExt = 1000270000,
        /// <summary>[requires: VK_EXT_host_image_copy]</summary>
        StructureTypePhysicalDeviceHostImageCopyPropertiesExt = 1000270001,
        /// <summary>[requires: VK_EXT_host_image_copy]</summary>
        StructureTypeMemoryToImageCopyExt = 1000270002,
        /// <summary>[requires: VK_EXT_host_image_copy]</summary>
        StructureTypeImageToMemoryCopyExt = 1000270003,
        /// <summary>[requires: VK_EXT_host_image_copy]</summary>
        StructureTypeCopyImageToMemoryInfoExt = 1000270004,
        /// <summary>[requires: VK_EXT_host_image_copy]</summary>
        StructureTypeCopyMemoryToImageInfoExt = 1000270005,
        /// <summary>[requires: VK_EXT_host_image_copy]</summary>
        StructureTypeHostImageLayoutTransitionInfoExt = 1000270006,
        /// <summary>[requires: VK_EXT_host_image_copy]</summary>
        StructureTypeCopyImageToImageInfoExt = 1000270007,
        /// <summary>[requires: VK_EXT_host_image_copy]</summary>
        StructureTypeSubresourceHostMemcpySizeExt = 1000270008,
        /// <summary>[requires: VK_EXT_host_image_copy]</summary>
        StructureTypeHostImageCopyDevicePerformanceQueryExt = 1000270009,
        /// <summary>[requires: VK_KHR_map_memory2]</summary>
        StructureTypeMemoryMapInfoKhr = 1000271000,
        /// <summary>[requires: VK_KHR_map_memory2]</summary>
        StructureTypeMemoryUnmapInfoKhr = 1000271001,
        /// <summary>[requires: VK_EXT_map_memory_placed]</summary>
        StructureTypePhysicalDeviceMapMemoryPlacedFeaturesExt = 1000272000,
        /// <summary>[requires: VK_EXT_map_memory_placed]</summary>
        StructureTypePhysicalDeviceMapMemoryPlacedPropertiesExt = 1000272001,
        /// <summary>[requires: VK_EXT_map_memory_placed]</summary>
        StructureTypeMemoryMapPlacedInfoExt = 1000272002,
        /// <summary>[requires: VK_EXT_shader_atomic_float2]</summary>
        StructureTypePhysicalDeviceShaderAtomicFloat2FeaturesExt = 1000273000,
        /// <summary>[requires: VK_EXT_surface_maintenance1]</summary>
        StructureTypeSurfacePresentModeExt = 1000274000,
        /// <summary>[requires: VK_EXT_surface_maintenance1]</summary>
        StructureTypeSurfacePresentScalingCapabilitiesExt = 1000274001,
        /// <summary>[requires: VK_EXT_surface_maintenance1]</summary>
        StructureTypeSurfacePresentModeCompatibilityExt = 1000274002,
        /// <summary>[requires: VK_EXT_swapchain_maintenance1]</summary>
        StructureTypePhysicalDeviceSwapchainMaintenance1FeaturesExt = 1000275000,
        /// <summary>[requires: VK_EXT_swapchain_maintenance1]</summary>
        StructureTypeSwapchainPresentFenceInfoExt = 1000275001,
        /// <summary>[requires: VK_EXT_swapchain_maintenance1]</summary>
        StructureTypeSwapchainPresentModesCreateInfoExt = 1000275002,
        /// <summary>[requires: VK_EXT_swapchain_maintenance1]</summary>
        StructureTypeSwapchainPresentModeInfoExt = 1000275003,
        /// <summary>[requires: VK_EXT_swapchain_maintenance1]</summary>
        StructureTypeSwapchainPresentScalingCreateInfoExt = 1000275004,
        /// <summary>[requires: VK_EXT_swapchain_maintenance1]</summary>
        StructureTypeReleaseSwapchainImagesInfoExt = 1000275005,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        StructureTypePhysicalDeviceDeviceGeneratedCommandsPropertiesNv = 1000277000,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        StructureTypeGraphicsShaderGroupCreateInfoNv = 1000277001,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        StructureTypeGraphicsPipelineShaderGroupsCreateInfoNv = 1000277002,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        StructureTypeIndirectCommandsLayoutTokenNv = 1000277003,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        StructureTypeIndirectCommandsLayoutCreateInfoNv = 1000277004,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        StructureTypeGeneratedCommandsInfoNv = 1000277005,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        StructureTypeGeneratedCommandsMemoryRequirementsInfoNv = 1000277006,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        StructureTypePhysicalDeviceDeviceGeneratedCommandsFeaturesNv = 1000277007,
        /// <summary>[requires: VK_NV_inherited_viewport_scissor]</summary>
        StructureTypePhysicalDeviceInheritedViewportScissorFeaturesNv = 1000278000,
        /// <summary>[requires: VK_NV_inherited_viewport_scissor]</summary>
        StructureTypeCommandBufferInheritanceViewportScissorInfoNv = 1000278001,
        /// <summary>[requires: VK_EXT_texel_buffer_alignment]Not promoted to 1.3</summary>
        StructureTypePhysicalDeviceTexelBufferAlignmentFeaturesExt = 1000281000,
        /// <summary>[requires: VK_QCOM_render_pass_transform]</summary>
        StructureTypeCommandBufferInheritanceRenderPassTransformInfoQcom = 1000282000,
        /// <summary>[requires: VK_QCOM_render_pass_transform]</summary>
        StructureTypeRenderPassTransformBeginInfoQcom = 1000282001,
        /// <summary>[requires: VK_EXT_depth_bias_control]</summary>
        StructureTypePhysicalDeviceDepthBiasControlFeaturesExt = 1000283000,
        /// <summary>[requires: VK_EXT_depth_bias_control]</summary>
        StructureTypeDepthBiasInfoExt = 1000283001,
        /// <summary>[requires: VK_EXT_depth_bias_control]</summary>
        StructureTypeDepthBiasRepresentationInfoExt = 1000283002,
        /// <summary>[requires: VK_EXT_device_memory_report]</summary>
        StructureTypePhysicalDeviceDeviceMemoryReportFeaturesExt = 1000284000,
        /// <summary>[requires: VK_EXT_device_memory_report]</summary>
        StructureTypeDeviceDeviceMemoryReportCreateInfoExt = 1000284001,
        /// <summary>[requires: VK_EXT_device_memory_report]</summary>
        StructureTypeDeviceMemoryReportCallbackDataExt = 1000284002,
        /// <summary>[requires: VK_EXT_robustness2]</summary>
        StructureTypePhysicalDeviceRobustness2FeaturesExt = 1000286000,
        /// <summary>[requires: VK_EXT_robustness2]</summary>
        StructureTypePhysicalDeviceRobustness2PropertiesExt = 1000286001,
        /// <summary>[requires: VK_EXT_custom_border_color]</summary>
        StructureTypeSamplerCustomBorderColorCreateInfoExt = 1000287000,
        /// <summary>[requires: VK_EXT_custom_border_color]</summary>
        StructureTypePhysicalDeviceCustomBorderColorPropertiesExt = 1000287001,
        /// <summary>[requires: VK_EXT_custom_border_color]</summary>
        StructureTypePhysicalDeviceCustomBorderColorFeaturesExt = 1000287002,
        /// <summary>[requires: VK_KHR_pipeline_library]</summary>
        StructureTypePipelineLibraryCreateInfoKhr = 1000290000,
        /// <summary>[requires: VK_NV_present_barrier]</summary>
        StructureTypePhysicalDevicePresentBarrierFeaturesNv = 1000292000,
        /// <summary>[requires: VK_NV_present_barrier]</summary>
        StructureTypeSurfaceCapabilitiesPresentBarrierNv = 1000292001,
        /// <summary>[requires: VK_NV_present_barrier]</summary>
        StructureTypeSwapchainPresentBarrierCreateInfoNv = 1000292002,
        /// <summary>[requires: VK_KHR_present_id]</summary>
        StructureTypePresentIdKhr = 1000294000,
        /// <summary>[requires: VK_KHR_present_id]</summary>
        StructureTypePhysicalDevicePresentIdFeaturesKhr = 1000294001,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        StructureTypeVideoEncodeInfoKhr = 1000299000,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        StructureTypeVideoEncodeRateControlInfoKhr = 1000299001,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        StructureTypeVideoEncodeRateControlLayerInfoKhr = 1000299002,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        StructureTypeVideoEncodeCapabilitiesKhr = 1000299003,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        StructureTypeVideoEncodeUsageInfoKhr = 1000299004,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        StructureTypeQueryPoolVideoEncodeFeedbackCreateInfoKhr = 1000299005,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        StructureTypePhysicalDeviceVideoEncodeQualityLevelInfoKhr = 1000299006,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        StructureTypeVideoEncodeQualityLevelPropertiesKhr = 1000299007,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        StructureTypeVideoEncodeQualityLevelInfoKhr = 1000299008,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        StructureTypeVideoEncodeSessionParametersGetInfoKhr = 1000299009,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        StructureTypeVideoEncodeSessionParametersFeedbackInfoKhr = 1000299010,
        /// <summary>[requires: VK_NV_device_diagnostics_config]</summary>
        StructureTypePhysicalDeviceDiagnosticsConfigFeaturesNv = 1000300000,
        /// <summary>[requires: VK_NV_device_diagnostics_config]</summary>
        StructureTypeDeviceDiagnosticsConfigCreateInfoNv = 1000300001,
        /// <summary>[requires: VK_NV_cuda_kernel_launch]</summary>
        StructureTypeCudaModuleCreateInfoNv = 1000307000,
        /// <summary>[requires: VK_NV_cuda_kernel_launch]</summary>
        StructureTypeCudaFunctionCreateInfoNv = 1000307001,
        /// <summary>[requires: VK_NV_cuda_kernel_launch]</summary>
        StructureTypeCudaLaunchInfoNv = 1000307002,
        /// <summary>[requires: VK_NV_cuda_kernel_launch]</summary>
        StructureTypePhysicalDeviceCudaKernelLaunchFeaturesNv = 1000307003,
        /// <summary>[requires: VK_NV_cuda_kernel_launch]</summary>
        StructureTypePhysicalDeviceCudaKernelLaunchPropertiesNv = 1000307004,
        /// <summary>[requires: VK_KHR_object_refresh]</summary>
        StructureTypeRefreshObjectListKhr = 1000308000,
        /// <summary>[requires: VK_NV_low_latency]</summary>
        StructureTypeQueryLowLatencySupportNv = 1000310000,
        /// <summary>[requires: VK_EXT_metal_objects]</summary>
        StructureTypeExportMetalObjectCreateInfoExt = 1000311000,
        /// <summary>[requires: VK_EXT_metal_objects]</summary>
        StructureTypeExportMetalObjectsInfoExt = 1000311001,
        /// <summary>[requires: VK_EXT_metal_objects]</summary>
        StructureTypeExportMetalDeviceInfoExt = 1000311002,
        /// <summary>[requires: VK_EXT_metal_objects]</summary>
        StructureTypeExportMetalCommandQueueInfoExt = 1000311003,
        /// <summary>[requires: VK_EXT_metal_objects]</summary>
        StructureTypeExportMetalBufferInfoExt = 1000311004,
        /// <summary>[requires: VK_EXT_metal_objects]</summary>
        StructureTypeImportMetalBufferInfoExt = 1000311005,
        /// <summary>[requires: VK_EXT_metal_objects]</summary>
        StructureTypeExportMetalTextureInfoExt = 1000311006,
        /// <summary>[requires: VK_EXT_metal_objects]</summary>
        StructureTypeImportMetalTextureInfoExt = 1000311007,
        /// <summary>[requires: VK_EXT_metal_objects]</summary>
        StructureTypeExportMetalIoSurfaceInfoExt = 1000311008,
        /// <summary>[requires: VK_EXT_metal_objects]</summary>
        StructureTypeImportMetalIoSurfaceInfoExt = 1000311009,
        /// <summary>[requires: VK_EXT_metal_objects]</summary>
        StructureTypeExportMetalSharedEventInfoExt = 1000311010,
        /// <summary>[requires: VK_EXT_metal_objects]</summary>
        StructureTypeImportMetalSharedEventInfoExt = 1000311011,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        StructureTypeQueueFamilyCheckpointProperties2Nv = 1000314008,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        StructureTypeCheckpointData2Nv = 1000314009,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypePhysicalDeviceDescriptorBufferPropertiesExt = 1000316000,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypePhysicalDeviceDescriptorBufferDensityMapPropertiesExt = 1000316001,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypePhysicalDeviceDescriptorBufferFeaturesExt = 1000316002,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypeDescriptorAddressInfoExt = 1000316003,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypeDescriptorGetInfoExt = 1000316004,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypeBufferCaptureDescriptorDataInfoExt = 1000316005,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypeImageCaptureDescriptorDataInfoExt = 1000316006,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypeImageViewCaptureDescriptorDataInfoExt = 1000316007,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypeSamplerCaptureDescriptorDataInfoExt = 1000316008,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypeOpaqueCaptureDescriptorDataCreateInfoExt = 1000316010,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypeDescriptorBufferBindingInfoExt = 1000316011,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypeDescriptorBufferBindingPushDescriptorBufferHandleExt = 1000316012,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        StructureTypeAccelerationStructureCaptureDescriptorDataInfoExt = 1000316009,
        /// <summary>[requires: VK_EXT_graphics_pipeline_library]</summary>
        StructureTypePhysicalDeviceGraphicsPipelineLibraryFeaturesExt = 1000320000,
        /// <summary>[requires: VK_EXT_graphics_pipeline_library]</summary>
        StructureTypePhysicalDeviceGraphicsPipelineLibraryPropertiesExt = 1000320001,
        /// <summary>[requires: VK_EXT_graphics_pipeline_library]</summary>
        StructureTypeGraphicsPipelineLibraryCreateInfoExt = 1000320002,
        /// <summary>[requires: VK_AMD_shader_early_and_late_fragment_tests]</summary>
        StructureTypePhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAmd = 1000321000,
        /// <summary>[requires: VK_KHR_fragment_shader_barycentric]</summary>
        StructureTypePhysicalDeviceFragmentShaderBarycentricFeaturesKhr = 1000203000,
        /// <summary>[requires: VK_KHR_fragment_shader_barycentric]</summary>
        StructureTypePhysicalDeviceFragmentShaderBarycentricPropertiesKhr = 1000322000,
        /// <summary>[requires: VK_KHR_shader_subgroup_uniform_control_flow]</summary>
        StructureTypePhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKhr = 1000323000,
        /// <summary>[requires: VK_NV_fragment_shading_rate_enums]</summary>
        StructureTypePhysicalDeviceFragmentShadingRateEnumsPropertiesNv = 1000326000,
        /// <summary>[requires: VK_NV_fragment_shading_rate_enums]</summary>
        StructureTypePhysicalDeviceFragmentShadingRateEnumsFeaturesNv = 1000326001,
        /// <summary>[requires: VK_NV_fragment_shading_rate_enums]</summary>
        StructureTypePipelineFragmentShadingRateEnumStateCreateInfoNv = 1000326002,
        /// <summary>[requires: VK_NV_ray_tracing_motion_blur]</summary>
        StructureTypeAccelerationStructureGeometryMotionTrianglesDataNv = 1000327000,
        /// <summary>[requires: VK_NV_ray_tracing_motion_blur]</summary>
        StructureTypePhysicalDeviceRayTracingMotionBlurFeaturesNv = 1000327001,
        /// <summary>[requires: VK_NV_ray_tracing_motion_blur]</summary>
        StructureTypeAccelerationStructureMotionInfoNv = 1000327002,
        /// <summary>[requires: VK_EXT_mesh_shader]</summary>
        StructureTypePhysicalDeviceMeshShaderFeaturesExt = 1000328000,
        /// <summary>[requires: VK_EXT_mesh_shader]</summary>
        StructureTypePhysicalDeviceMeshShaderPropertiesExt = 1000328001,
        /// <summary>[requires: VK_EXT_ycbcr_2plane_444_formats]</summary>
        StructureTypePhysicalDeviceYcbcr2Plane444FormatsFeaturesExt = 1000330000,
        /// <summary>[requires: VK_EXT_fragment_density_map2]</summary>
        StructureTypePhysicalDeviceFragmentDensityMap2FeaturesExt = 1000332000,
        /// <summary>[requires: VK_EXT_fragment_density_map2]</summary>
        StructureTypePhysicalDeviceFragmentDensityMap2PropertiesExt = 1000332001,
        /// <summary>[requires: VK_QCOM_rotated_copy_commands]</summary>
        StructureTypeCopyCommandTransformInfoQcom = 1000333000,
        /// <summary>[requires: VK_KHR_workgroup_memory_explicit_layout]</summary>
        StructureTypePhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKhr = 1000336000,
        /// <summary>[requires: VK_EXT_image_compression_control]</summary>
        StructureTypePhysicalDeviceImageCompressionControlFeaturesExt = 1000338000,
        /// <summary>[requires: VK_EXT_image_compression_control]</summary>
        StructureTypeImageCompressionControlExt = 1000338001,
        /// <summary>[requires: VK_EXT_image_compression_control]</summary>
        StructureTypeImageCompressionPropertiesExt = 1000338004,
        /// <summary>[requires: VK_EXT_attachment_feedback_loop_layout]</summary>
        StructureTypePhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesExt = 1000339000,
        /// <summary>[requires: VK_EXT_4444_formats]</summary>
        StructureTypePhysicalDevice4444FormatsFeaturesExt = 1000340000,
        /// <summary>[requires: VK_EXT_device_fault]</summary>
        StructureTypePhysicalDeviceFaultFeaturesExt = 1000341000,
        /// <summary>[requires: VK_EXT_device_fault]</summary>
        StructureTypeDeviceFaultCountsExt = 1000341001,
        /// <summary>[requires: VK_EXT_device_fault]</summary>
        StructureTypeDeviceFaultInfoExt = 1000341002,
        /// <summary>[requires: VK_EXT_rgba10x6_formats]</summary>
        StructureTypePhysicalDeviceRgba10x6FormatsFeaturesExt = 1000344000,
        /// <summary>[requires: VK_EXT_directfb_surface]</summary>
        StructureTypeDirectfbSurfaceCreateInfoExt = 1000346000,
        /// <summary>[requires: VK_EXT_vertex_input_dynamic_state]</summary>
        StructureTypePhysicalDeviceVertexInputDynamicStateFeaturesExt = 1000352000,
        /// <summary>[requires: VK_EXT_vertex_input_dynamic_state]</summary>
        StructureTypeVertexInputBindingDescription2Ext = 1000352001,
        /// <summary>[requires: VK_EXT_vertex_input_dynamic_state]</summary>
        StructureTypeVertexInputAttributeDescription2Ext = 1000352002,
        /// <summary>[requires: VK_EXT_physical_device_drm]</summary>
        StructureTypePhysicalDeviceDrmPropertiesExt = 1000353000,
        /// <summary>[requires: VK_EXT_device_address_binding_report]</summary>
        StructureTypePhysicalDeviceAddressBindingReportFeaturesExt = 1000354000,
        /// <summary>[requires: VK_EXT_device_address_binding_report]</summary>
        StructureTypeDeviceAddressBindingCallbackDataExt = 1000354001,
        /// <summary>[requires: VK_EXT_depth_clip_control]</summary>
        StructureTypePhysicalDeviceDepthClipControlFeaturesExt = 1000355000,
        /// <summary>[requires: VK_EXT_depth_clip_control]</summary>
        StructureTypePipelineViewportDepthClipControlCreateInfoExt = 1000355001,
        /// <summary>[requires: VK_EXT_primitive_topology_list_restart]</summary>
        StructureTypePhysicalDevicePrimitiveTopologyListRestartFeaturesExt = 1000356000,
        /// <summary>[requires: VK_FUCHSIA_external_memory]</summary>
        StructureTypeImportMemoryZirconHandleInfoFuchsia = 1000364000,
        /// <summary>[requires: VK_FUCHSIA_external_memory]</summary>
        StructureTypeMemoryZirconHandlePropertiesFuchsia = 1000364001,
        /// <summary>[requires: VK_FUCHSIA_external_memory]</summary>
        StructureTypeMemoryGetZirconHandleInfoFuchsia = 1000364002,
        /// <summary>[requires: VK_FUCHSIA_external_semaphore]</summary>
        StructureTypeImportSemaphoreZirconHandleInfoFuchsia = 1000365000,
        /// <summary>[requires: VK_FUCHSIA_external_semaphore]</summary>
        StructureTypeSemaphoreGetZirconHandleInfoFuchsia = 1000365001,
        /// <summary>[requires: VK_FUCHSIA_buffer_collection]</summary>
        StructureTypeBufferCollectionCreateInfoFuchsia = 1000366000,
        /// <summary>[requires: VK_FUCHSIA_buffer_collection]</summary>
        StructureTypeImportMemoryBufferCollectionFuchsia = 1000366001,
        /// <summary>[requires: VK_FUCHSIA_buffer_collection]</summary>
        StructureTypeBufferCollectionImageCreateInfoFuchsia = 1000366002,
        /// <summary>[requires: VK_FUCHSIA_buffer_collection]</summary>
        StructureTypeBufferCollectionPropertiesFuchsia = 1000366003,
        /// <summary>[requires: VK_FUCHSIA_buffer_collection]</summary>
        StructureTypeBufferConstraintsInfoFuchsia = 1000366004,
        /// <summary>[requires: VK_FUCHSIA_buffer_collection]</summary>
        StructureTypeBufferCollectionBufferCreateInfoFuchsia = 1000366005,
        /// <summary>[requires: VK_FUCHSIA_buffer_collection]</summary>
        StructureTypeImageConstraintsInfoFuchsia = 1000366006,
        /// <summary>[requires: VK_FUCHSIA_buffer_collection]</summary>
        StructureTypeImageFormatConstraintsInfoFuchsia = 1000366007,
        /// <summary>[requires: VK_FUCHSIA_buffer_collection]</summary>
        StructureTypeSysmemColorSpaceFuchsia = 1000366008,
        /// <summary>[requires: VK_FUCHSIA_buffer_collection]</summary>
        StructureTypeBufferCollectionConstraintsInfoFuchsia = 1000366009,
        /// <summary>[requires: VK_HUAWEI_subpass_shading]</summary>
        StructureTypeSubpassShadingPipelineCreateInfoHuawei = 1000369000,
        /// <summary>[requires: VK_HUAWEI_subpass_shading]</summary>
        StructureTypePhysicalDeviceSubpassShadingFeaturesHuawei = 1000369001,
        /// <summary>[requires: VK_HUAWEI_subpass_shading]</summary>
        StructureTypePhysicalDeviceSubpassShadingPropertiesHuawei = 1000369002,
        /// <summary>[requires: VK_HUAWEI_invocation_mask]</summary>
        StructureTypePhysicalDeviceInvocationMaskFeaturesHuawei = 1000370000,
        /// <summary>[requires: VK_NV_external_memory_rdma]</summary>
        StructureTypeMemoryGetRemoteAddressInfoNv = 1000371000,
        /// <summary>[requires: VK_NV_external_memory_rdma]</summary>
        StructureTypePhysicalDeviceExternalMemoryRdmaFeaturesNv = 1000371001,
        /// <summary>[requires: VK_EXT_pipeline_properties]</summary>
        StructureTypePipelinePropertiesIdentifierExt = 1000372000,
        /// <summary>[requires: VK_EXT_pipeline_properties]</summary>
        StructureTypePhysicalDevicePipelinePropertiesFeaturesExt = 1000372001,
        /// <summary>[requires: VK_NV_external_sci_sync]</summary>
        StructureTypeImportFenceSciSyncInfoNv = 1000373000,
        /// <summary>[requires: VK_NV_external_sci_sync]</summary>
        StructureTypeExportFenceSciSyncInfoNv = 1000373001,
        /// <summary>[requires: VK_NV_external_sci_sync]</summary>
        StructureTypeFenceGetSciSyncInfoNv = 1000373002,
        /// <summary>[requires: VK_NV_external_sci_sync]</summary>
        StructureTypeSciSyncAttributesInfoNv = 1000373003,
        /// <summary>[requires: VK_NV_external_sci_sync]</summary>
        StructureTypeImportSemaphoreSciSyncInfoNv = 1000373004,
        /// <summary>[requires: VK_NV_external_sci_sync]</summary>
        StructureTypeExportSemaphoreSciSyncInfoNv = 1000373005,
        /// <summary>[requires: VK_NV_external_sci_sync]</summary>
        StructureTypeSemaphoreGetSciSyncInfoNv = 1000373006,
        /// <summary>[requires: VK_NV_external_sci_sync]</summary>
        StructureTypePhysicalDeviceExternalSciSyncFeaturesNv = 1000373007,
        /// <summary>[requires: VK_NV_external_memory_sci_buf]</summary>
        StructureTypeImportMemorySciBufInfoNv = 1000374000,
        /// <summary>[requires: VK_NV_external_memory_sci_buf]</summary>
        StructureTypeExportMemorySciBufInfoNv = 1000374001,
        /// <summary>[requires: VK_NV_external_memory_sci_buf]</summary>
        StructureTypeMemoryGetSciBufInfoNv = 1000374002,
        /// <summary>[requires: VK_NV_external_memory_sci_buf]</summary>
        StructureTypeMemorySciBufPropertiesNv = 1000374003,
        /// <summary>[requires: VK_NV_external_memory_sci_buf]</summary>
        StructureTypePhysicalDeviceExternalMemorySciBufFeaturesNv = 1000374004,
        /// <summary>[requires: VK_EXT_frame_boundary]</summary>
        StructureTypePhysicalDeviceFrameBoundaryFeaturesExt = 1000375000,
        /// <summary>[requires: VK_EXT_frame_boundary]</summary>
        StructureTypeFrameBoundaryExt = 1000375001,
        /// <summary>[requires: VK_EXT_multisampled_render_to_single_sampled]</summary>
        StructureTypePhysicalDeviceMultisampledRenderToSingleSampledFeaturesExt = 1000376000,
        /// <summary>[requires: VK_EXT_multisampled_render_to_single_sampled]</summary>
        StructureTypeSubpassResolvePerformanceQueryExt = 1000376001,
        /// <summary>[requires: VK_EXT_multisampled_render_to_single_sampled]</summary>
        StructureTypeMultisampledRenderToSingleSampledInfoExt = 1000376002,
        /// <summary>[requires: VK_EXT_extended_dynamic_state2]Not promoted to 1.3</summary>
        StructureTypePhysicalDeviceExtendedDynamicState2FeaturesExt = 1000377000,
        /// <summary>[requires: VK_QNX_screen_surface]</summary>
        StructureTypeScreenSurfaceCreateInfoQnx = 1000378000,
        /// <summary>[requires: VK_EXT_color_write_enable]</summary>
        StructureTypePhysicalDeviceColorWriteEnableFeaturesExt = 1000381000,
        /// <summary>[requires: VK_EXT_color_write_enable]</summary>
        StructureTypePipelineColorWriteCreateInfoExt = 1000381001,
        /// <summary>[requires: VK_EXT_primitives_generated_query]</summary>
        StructureTypePhysicalDevicePrimitivesGeneratedQueryFeaturesExt = 1000382000,
        /// <summary>[requires: VK_KHR_ray_tracing_maintenance1]</summary>
        StructureTypePhysicalDeviceRayTracingMaintenance1FeaturesKhr = 1000386000,
        /// <summary>[requires: VK_EXT_image_view_min_lod]</summary>
        StructureTypePhysicalDeviceImageViewMinLodFeaturesExt = 1000391000,
        /// <summary>[requires: VK_EXT_image_view_min_lod]</summary>
        StructureTypeImageViewMinLodCreateInfoExt = 1000391001,
        /// <summary>[requires: VK_EXT_multi_draw]</summary>
        StructureTypePhysicalDeviceMultiDrawFeaturesExt = 1000392000,
        /// <summary>[requires: VK_EXT_multi_draw]</summary>
        StructureTypePhysicalDeviceMultiDrawPropertiesExt = 1000392001,
        /// <summary>[requires: VK_EXT_image_2d_view_of_3d]</summary>
        StructureTypePhysicalDeviceImage2dViewOf3dFeaturesExt = 1000393000,
        /// <summary>[requires: VK_EXT_shader_tile_image]</summary>
        StructureTypePhysicalDeviceShaderTileImageFeaturesExt = 1000395000,
        /// <summary>[requires: VK_EXT_shader_tile_image]</summary>
        StructureTypePhysicalDeviceShaderTileImagePropertiesExt = 1000395001,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        StructureTypeMicromapBuildInfoExt = 1000396000,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        StructureTypeMicromapVersionInfoExt = 1000396001,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        StructureTypeCopyMicromapInfoExt = 1000396002,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        StructureTypeCopyMicromapToMemoryInfoExt = 1000396003,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        StructureTypeCopyMemoryToMicromapInfoExt = 1000396004,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        StructureTypePhysicalDeviceOpacityMicromapFeaturesExt = 1000396005,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        StructureTypePhysicalDeviceOpacityMicromapPropertiesExt = 1000396006,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        StructureTypeMicromapCreateInfoExt = 1000396007,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        StructureTypeMicromapBuildSizesInfoExt = 1000396008,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        StructureTypeAccelerationStructureTrianglesOpacityMicromapExt = 1000396009,
        /// <summary>[requires: VK_NV_displacement_micromap]</summary>
        StructureTypePhysicalDeviceDisplacementMicromapFeaturesNv = 1000397000,
        /// <summary>[requires: VK_NV_displacement_micromap]</summary>
        StructureTypePhysicalDeviceDisplacementMicromapPropertiesNv = 1000397001,
        /// <summary>[requires: VK_NV_displacement_micromap]</summary>
        StructureTypeAccelerationStructureTrianglesDisplacementMicromapNv = 1000397002,
        /// <summary>[requires: VK_HUAWEI_cluster_culling_shader]</summary>
        StructureTypePhysicalDeviceClusterCullingShaderFeaturesHuawei = 1000404000,
        /// <summary>[requires: VK_HUAWEI_cluster_culling_shader]</summary>
        StructureTypePhysicalDeviceClusterCullingShaderPropertiesHuawei = 1000404001,
        /// <summary>[requires: VK_HUAWEI_cluster_culling_shader]</summary>
        StructureTypePhysicalDeviceClusterCullingShaderVrsFeaturesHuawei = 1000404002,
        /// <summary>[requires: VK_EXT_border_color_swizzle]</summary>
        StructureTypePhysicalDeviceBorderColorSwizzleFeaturesExt = 1000411000,
        /// <summary>[requires: VK_EXT_border_color_swizzle]</summary>
        StructureTypeSamplerBorderColorComponentMappingCreateInfoExt = 1000411001,
        /// <summary>[requires: VK_EXT_pageable_device_local_memory]</summary>
        StructureTypePhysicalDevicePageableDeviceLocalMemoryFeaturesExt = 1000412000,
        /// <summary>[requires: VK_ARM_shader_core_properties]</summary>
        StructureTypePhysicalDeviceShaderCorePropertiesArm = 1000415000,
        /// <summary>[requires: VK_KHR_shader_subgroup_rotate]</summary>
        StructureTypePhysicalDeviceShaderSubgroupRotateFeaturesKhr = 1000416000,
        /// <summary>[requires: VK_ARM_scheduling_controls]</summary>
        StructureTypeDeviceQueueShaderCoreControlCreateInfoArm = 1000417000,
        /// <summary>[requires: VK_ARM_scheduling_controls]</summary>
        StructureTypePhysicalDeviceSchedulingControlsFeaturesArm = 1000417001,
        /// <summary>[requires: VK_ARM_scheduling_controls]</summary>
        StructureTypePhysicalDeviceSchedulingControlsPropertiesArm = 1000417002,
        /// <summary>[requires: VK_EXT_image_sliced_view_of_3d]</summary>
        StructureTypePhysicalDeviceImageSlicedViewOf3dFeaturesExt = 1000418000,
        /// <summary>[requires: VK_EXT_image_sliced_view_of_3d]</summary>
        StructureTypeImageViewSlicedCreateInfoExt = 1000418001,
        /// <summary>[requires: VK_VALVE_descriptor_set_host_mapping]</summary>
        StructureTypePhysicalDeviceDescriptorSetHostMappingFeaturesValve = 1000420000,
        /// <summary>[requires: VK_VALVE_descriptor_set_host_mapping]</summary>
        StructureTypeDescriptorSetBindingReferenceValve = 1000420001,
        /// <summary>[requires: VK_VALVE_descriptor_set_host_mapping]</summary>
        StructureTypeDescriptorSetLayoutHostMappingInfoValve = 1000420002,
        /// <summary>[requires: VK_EXT_depth_clamp_zero_one]</summary>
        StructureTypePhysicalDeviceDepthClampZeroOneFeaturesExt = 1000421000,
        /// <summary>[requires: VK_EXT_non_seamless_cube_map]</summary>
        StructureTypePhysicalDeviceNonSeamlessCubeMapFeaturesExt = 1000422000,
        /// <summary>[requires: VK_ARM_render_pass_striped]</summary>
        StructureTypePhysicalDeviceRenderPassStripedFeaturesArm = 1000424000,
        /// <summary>[requires: VK_ARM_render_pass_striped]</summary>
        StructureTypePhysicalDeviceRenderPassStripedPropertiesArm = 1000424001,
        /// <summary>[requires: VK_ARM_render_pass_striped]</summary>
        StructureTypeRenderPassStripeBeginInfoArm = 1000424002,
        /// <summary>[requires: VK_ARM_render_pass_striped]</summary>
        StructureTypeRenderPassStripeInfoArm = 1000424003,
        /// <summary>[requires: VK_ARM_render_pass_striped]</summary>
        StructureTypeRenderPassStripeSubmitInfoArm = 1000424004,
        /// <summary>[requires: VK_QCOM_fragment_density_map_offset]</summary>
        StructureTypePhysicalDeviceFragmentDensityMapOffsetFeaturesQcom = 1000425000,
        /// <summary>[requires: VK_QCOM_fragment_density_map_offset]</summary>
        StructureTypePhysicalDeviceFragmentDensityMapOffsetPropertiesQcom = 1000425001,
        /// <summary>[requires: VK_QCOM_fragment_density_map_offset]</summary>
        StructureTypeSubpassFragmentDensityMapOffsetEndInfoQcom = 1000425002,
        /// <summary>[requires: VK_NV_copy_memory_indirect]</summary>
        StructureTypePhysicalDeviceCopyMemoryIndirectFeaturesNv = 1000426000,
        /// <summary>[requires: VK_NV_copy_memory_indirect]</summary>
        StructureTypePhysicalDeviceCopyMemoryIndirectPropertiesNv = 1000426001,
        /// <summary>[requires: VK_NV_memory_decompression]</summary>
        StructureTypePhysicalDeviceMemoryDecompressionFeaturesNv = 1000427000,
        /// <summary>[requires: VK_NV_memory_decompression]</summary>
        StructureTypePhysicalDeviceMemoryDecompressionPropertiesNv = 1000427001,
        /// <summary>[requires: VK_NV_device_generated_commands_compute]</summary>
        StructureTypePhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNv = 1000428000,
        /// <summary>[requires: VK_NV_device_generated_commands_compute]</summary>
        StructureTypeComputePipelineIndirectBufferInfoNv = 1000428001,
        /// <summary>[requires: VK_NV_device_generated_commands_compute]</summary>
        StructureTypePipelineIndirectDeviceAddressInfoNv = 1000428002,
        /// <summary>[requires: VK_NV_linear_color_attachment]</summary>
        StructureTypePhysicalDeviceLinearColorAttachmentFeaturesNv = 1000430000,
        /// <summary>[requires: VK_KHR_shader_maximal_reconvergence]</summary>
        StructureTypePhysicalDeviceShaderMaximalReconvergenceFeaturesKhr = 1000434000,
        /// <summary>[requires: VK_EXT_application_parameters]</summary>
        StructureTypeApplicationParametersExt = 1000435000,
        /// <summary>[requires: VK_EXT_image_compression_control_swapchain]</summary>
        StructureTypePhysicalDeviceImageCompressionControlSwapchainFeaturesExt = 1000437000,
        /// <summary>[requires: VK_QCOM_image_processing]</summary>
        StructureTypePhysicalDeviceImageProcessingFeaturesQcom = 1000440000,
        /// <summary>[requires: VK_QCOM_image_processing]</summary>
        StructureTypePhysicalDeviceImageProcessingPropertiesQcom = 1000440001,
        /// <summary>[requires: VK_QCOM_image_processing]</summary>
        StructureTypeImageViewSampleWeightCreateInfoQcom = 1000440002,
        /// <summary>[requires: VK_EXT_nested_command_buffer]</summary>
        StructureTypePhysicalDeviceNestedCommandBufferFeaturesExt = 1000451000,
        /// <summary>[requires: VK_EXT_nested_command_buffer]</summary>
        StructureTypePhysicalDeviceNestedCommandBufferPropertiesExt = 1000451001,
        /// <summary>[requires: VK_EXT_external_memory_acquire_unmodified]</summary>
        StructureTypeExternalMemoryAcquireUnmodifiedExt = 1000453000,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        StructureTypePhysicalDeviceExtendedDynamicState3FeaturesExt = 1000455000,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        StructureTypePhysicalDeviceExtendedDynamicState3PropertiesExt = 1000455001,
        /// <summary>[requires: VK_EXT_subpass_merge_feedback]</summary>
        StructureTypePhysicalDeviceSubpassMergeFeedbackFeaturesExt = 1000458000,
        /// <summary>[requires: VK_EXT_subpass_merge_feedback]</summary>
        StructureTypeRenderPassCreationControlExt = 1000458001,
        /// <summary>[requires: VK_EXT_subpass_merge_feedback]</summary>
        StructureTypeRenderPassCreationFeedbackCreateInfoExt = 1000458002,
        /// <summary>[requires: VK_EXT_subpass_merge_feedback]</summary>
        StructureTypeRenderPassSubpassFeedbackCreateInfoExt = 1000458003,
        /// <summary>[requires: VK_LUNARG_direct_driver_loading]</summary>
        StructureTypeDirectDriverLoadingInfoLunarg = 1000459000,
        /// <summary>[requires: VK_LUNARG_direct_driver_loading]</summary>
        StructureTypeDirectDriverLoadingListLunarg = 1000459001,
        /// <summary>[requires: VK_EXT_shader_module_identifier]</summary>
        StructureTypePhysicalDeviceShaderModuleIdentifierFeaturesExt = 1000462000,
        /// <summary>[requires: VK_EXT_shader_module_identifier]</summary>
        StructureTypePhysicalDeviceShaderModuleIdentifierPropertiesExt = 1000462001,
        /// <summary>[requires: VK_EXT_shader_module_identifier]</summary>
        StructureTypePipelineShaderStageModuleIdentifierCreateInfoExt = 1000462002,
        /// <summary>[requires: VK_EXT_shader_module_identifier]</summary>
        StructureTypeShaderModuleIdentifierExt = 1000462003,
        /// <summary>[requires: VK_EXT_rasterization_order_attachment_access]</summary>
        StructureTypePhysicalDeviceRasterizationOrderAttachmentAccessFeaturesExt = 1000342000,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        StructureTypePhysicalDeviceOpticalFlowFeaturesNv = 1000464000,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        StructureTypePhysicalDeviceOpticalFlowPropertiesNv = 1000464001,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        StructureTypeOpticalFlowImageFormatInfoNv = 1000464002,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        StructureTypeOpticalFlowImageFormatPropertiesNv = 1000464003,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        StructureTypeOpticalFlowSessionCreateInfoNv = 1000464004,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        StructureTypeOpticalFlowExecuteInfoNv = 1000464005,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        StructureTypeOpticalFlowSessionCreatePrivateDataInfoNv = 1000464010,
        /// <summary>[requires: VK_EXT_legacy_dithering]</summary>
        StructureTypePhysicalDeviceLegacyDitheringFeaturesExt = 1000465000,
        /// <summary>[requires: VK_EXT_pipeline_protected_access]</summary>
        StructureTypePhysicalDevicePipelineProtectedAccessFeaturesExt = 1000466000,
        /// <summary>[requires: VK_ANDROID_external_format_resolve]</summary>
        StructureTypePhysicalDeviceExternalFormatResolveFeaturesAndroid = 1000468000,
        /// <summary>[requires: VK_ANDROID_external_format_resolve]</summary>
        StructureTypePhysicalDeviceExternalFormatResolvePropertiesAndroid = 1000468001,
        /// <summary>[requires: VK_ANDROID_external_format_resolve]</summary>
        StructureTypeAndroidHardwareBufferFormatResolvePropertiesAndroid = 1000468002,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        StructureTypePhysicalDeviceMaintenance5FeaturesKhr = 1000470000,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        StructureTypePhysicalDeviceMaintenance5PropertiesKhr = 1000470001,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        StructureTypeRenderingAreaInfoKhr = 1000470003,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        StructureTypeDeviceImageSubresourceInfoKhr = 1000470004,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        StructureTypeSubresourceLayout2Khr = 1000338002,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        StructureTypeImageSubresource2Khr = 1000338003,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        StructureTypePipelineCreateFlags2CreateInfoKhr = 1000470005,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        StructureTypeBufferUsageFlags2CreateInfoKhr = 1000470006,
        /// <summary>[requires: VK_KHR_ray_tracing_position_fetch]</summary>
        StructureTypePhysicalDeviceRayTracingPositionFetchFeaturesKhr = 1000481000,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        StructureTypePhysicalDeviceShaderObjectFeaturesExt = 1000482000,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        StructureTypePhysicalDeviceShaderObjectPropertiesExt = 1000482001,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        StructureTypeShaderCreateInfoExt = 1000482002,
        /// <summary>[requires: VK_QCOM_tile_properties]</summary>
        StructureTypePhysicalDeviceTilePropertiesFeaturesQcom = 1000484000,
        /// <summary>[requires: VK_QCOM_tile_properties]</summary>
        StructureTypeTilePropertiesQcom = 1000484001,
        /// <summary>[requires: VK_SEC_amigo_profiling]</summary>
        StructureTypePhysicalDeviceAmigoProfilingFeaturesSec = 1000485000,
        /// <summary>[requires: VK_SEC_amigo_profiling]</summary>
        StructureTypeAmigoProfilingSubmitInfoSec = 1000485001,
        /// <summary>[requires: VK_QCOM_multiview_per_view_viewports]</summary>
        StructureTypePhysicalDeviceMultiviewPerViewViewportsFeaturesQcom = 1000488000,
        /// <summary>[requires: VK_NV_external_sci_sync2]</summary>
        StructureTypeSemaphoreSciSyncPoolCreateInfoNv = 1000489000,
        /// <summary>[requires: VK_NV_external_sci_sync2]</summary>
        StructureTypeSemaphoreSciSyncCreateInfoNv = 1000489001,
        /// <summary>[requires: VK_NV_external_sci_sync2]</summary>
        StructureTypePhysicalDeviceExternalSciSync2FeaturesNv = 1000489002,
        /// <summary>[requires: VK_NV_ray_tracing_invocation_reorder]</summary>
        StructureTypePhysicalDeviceRayTracingInvocationReorderFeaturesNv = 1000490000,
        /// <summary>[requires: VK_NV_ray_tracing_invocation_reorder]</summary>
        StructureTypePhysicalDeviceRayTracingInvocationReorderPropertiesNv = 1000490001,
        /// <summary>[requires: VK_NV_extended_sparse_address_space]</summary>
        StructureTypePhysicalDeviceExtendedSparseAddressSpaceFeaturesNv = 1000492000,
        /// <summary>[requires: VK_NV_extended_sparse_address_space]</summary>
        StructureTypePhysicalDeviceExtendedSparseAddressSpacePropertiesNv = 1000492001,
        /// <summary>[requires: VK_EXT_mutable_descriptor_type]</summary>
        StructureTypePhysicalDeviceMutableDescriptorTypeFeaturesExt = 1000351000,
        /// <summary>[requires: VK_EXT_mutable_descriptor_type]</summary>
        StructureTypeMutableDescriptorTypeCreateInfoExt = 1000351002,
        /// <summary>[requires: VK_EXT_legacy_vertex_attributes]</summary>
        StructureTypePhysicalDeviceLegacyVertexAttributesFeaturesExt = 1000495000,
        /// <summary>[requires: VK_EXT_legacy_vertex_attributes]</summary>
        StructureTypePhysicalDeviceLegacyVertexAttributesPropertiesExt = 1000495001,
        /// <summary>[requires: VK_EXT_layer_settings]</summary>
        StructureTypeLayerSettingsCreateInfoExt = 1000496000,
        /// <summary>[requires: VK_ARM_shader_core_builtins]</summary>
        StructureTypePhysicalDeviceShaderCoreBuiltinsFeaturesArm = 1000497000,
        /// <summary>[requires: VK_ARM_shader_core_builtins]</summary>
        StructureTypePhysicalDeviceShaderCoreBuiltinsPropertiesArm = 1000497001,
        /// <summary>[requires: VK_EXT_pipeline_library_group_handles]</summary>
        StructureTypePhysicalDevicePipelineLibraryGroupHandlesFeaturesExt = 1000498000,
        /// <summary>[requires: VK_EXT_dynamic_rendering_unused_attachments]</summary>
        StructureTypePhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesExt = 1000499000,
        /// <summary>[requires: VK_NV_low_latency2]</summary>
        StructureTypeLatencySleepModeInfoNv = 1000505000,
        /// <summary>[requires: VK_NV_low_latency2]</summary>
        StructureTypeLatencySleepInfoNv = 1000505001,
        /// <summary>[requires: VK_NV_low_latency2]</summary>
        StructureTypeSetLatencyMarkerInfoNv = 1000505002,
        /// <summary>[requires: VK_NV_low_latency2]</summary>
        StructureTypeGetLatencyMarkerInfoNv = 1000505003,
        /// <summary>[requires: VK_NV_low_latency2]</summary>
        StructureTypeLatencyTimingsFrameReportNv = 1000505004,
        /// <summary>[requires: VK_NV_low_latency2]</summary>
        StructureTypeLatencySubmissionPresentIdNv = 1000505005,
        /// <summary>[requires: VK_NV_low_latency2]</summary>
        StructureTypeOutOfBandQueueTypeInfoNv = 1000505006,
        /// <summary>[requires: VK_NV_low_latency2]</summary>
        StructureTypeSwapchainLatencyCreateInfoNv = 1000505007,
        /// <summary>[requires: VK_NV_low_latency2]</summary>
        StructureTypeLatencySurfaceCapabilitiesNv = 1000505008,
        /// <summary>[requires: VK_KHR_cooperative_matrix]</summary>
        StructureTypePhysicalDeviceCooperativeMatrixFeaturesKhr = 1000506000,
        /// <summary>[requires: VK_KHR_cooperative_matrix]</summary>
        StructureTypeCooperativeMatrixPropertiesKhr = 1000506001,
        /// <summary>[requires: VK_KHR_cooperative_matrix]</summary>
        StructureTypePhysicalDeviceCooperativeMatrixPropertiesKhr = 1000506002,
        /// <summary>[requires: VK_QCOM_multiview_per_view_render_areas]</summary>
        StructureTypePhysicalDeviceMultiviewPerViewRenderAreasFeaturesQcom = 1000510000,
        /// <summary>[requires: VK_QCOM_multiview_per_view_render_areas]</summary>
        StructureTypeMultiviewPerViewRenderAreasRenderPassBeginInfoQcom = 1000510001,
        /// <summary>[requires: VK_KHR_video_decode_av1]</summary>
        StructureTypeVideoDecodeAv1CapabilitiesKhr = 1000512000,
        /// <summary>[requires: VK_KHR_video_decode_av1]</summary>
        StructureTypeVideoDecodeAv1PictureInfoKhr = 1000512001,
        /// <summary>[requires: VK_KHR_video_decode_av1]</summary>
        StructureTypeVideoDecodeAv1ProfileInfoKhr = 1000512003,
        /// <summary>[requires: VK_KHR_video_decode_av1]</summary>
        StructureTypeVideoDecodeAv1SessionParametersCreateInfoKhr = 1000512004,
        /// <summary>[requires: VK_KHR_video_decode_av1]</summary>
        StructureTypeVideoDecodeAv1DpbSlotInfoKhr = 1000512005,
        /// <summary>[requires: VK_KHR_video_maintenance1]</summary>
        StructureTypePhysicalDeviceVideoMaintenance1FeaturesKhr = 1000515000,
        /// <summary>[requires: VK_KHR_video_maintenance1]</summary>
        StructureTypeVideoInlineQueryInfoKhr = 1000515001,
        /// <summary>[requires: VK_NV_per_stage_descriptor_set]</summary>
        StructureTypePhysicalDevicePerStageDescriptorSetFeaturesNv = 1000516000,
        /// <summary>[requires: VK_QCOM_image_processing2]</summary>
        StructureTypePhysicalDeviceImageProcessing2FeaturesQcom = 1000518000,
        /// <summary>[requires: VK_QCOM_image_processing2]</summary>
        StructureTypePhysicalDeviceImageProcessing2PropertiesQcom = 1000518001,
        /// <summary>[requires: VK_QCOM_image_processing2]</summary>
        StructureTypeSamplerBlockMatchWindowCreateInfoQcom = 1000518002,
        /// <summary>[requires: VK_QCOM_filter_cubic_weights]</summary>
        StructureTypeSamplerCubicWeightsCreateInfoQcom = 1000519000,
        /// <summary>[requires: VK_QCOM_filter_cubic_weights]</summary>
        StructureTypePhysicalDeviceCubicWeightsFeaturesQcom = 1000519001,
        /// <summary>[requires: VK_QCOM_filter_cubic_weights]</summary>
        StructureTypeBlitImageCubicWeightsInfoQcom = 1000519002,
        /// <summary>[requires: VK_QCOM_ycbcr_degamma]</summary>
        StructureTypePhysicalDeviceYcbcrDegammaFeaturesQcom = 1000520000,
        /// <summary>[requires: VK_QCOM_ycbcr_degamma]</summary>
        StructureTypeSamplerYcbcrConversionYcbcrDegammaCreateInfoQcom = 1000520001,
        /// <summary>[requires: VK_QCOM_filter_cubic_clamp]</summary>
        StructureTypePhysicalDeviceCubicClampFeaturesQcom = 1000521000,
        /// <summary>[requires: VK_EXT_attachment_feedback_loop_dynamic_state]</summary>
        StructureTypePhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesExt = 1000524000,
        /// <summary>[requires: VK_KHR_vertex_attribute_divisor]</summary>
        StructureTypePhysicalDeviceVertexAttributeDivisorPropertiesKhr = 1000525000,
        /// <summary>[requires: VK_KHR_vertex_attribute_divisor]</summary>
        StructureTypePipelineVertexInputDivisorStateCreateInfoKhr = 1000190001,
        /// <summary>[requires: VK_KHR_vertex_attribute_divisor]</summary>
        StructureTypePhysicalDeviceVertexAttributeDivisorFeaturesKhr = 1000190002,
        /// <summary>[requires: VK_KHR_shader_float_controls2]</summary>
        StructureTypePhysicalDeviceShaderFloatControls2FeaturesKhr = 1000528000,
        /// <summary>[requires: VK_QNX_external_memory_screen_buffer]</summary>
        StructureTypeScreenBufferPropertiesQnx = 1000529000,
        /// <summary>[requires: VK_QNX_external_memory_screen_buffer]</summary>
        StructureTypeScreenBufferFormatPropertiesQnx = 1000529001,
        /// <summary>[requires: VK_QNX_external_memory_screen_buffer]</summary>
        StructureTypeImportScreenBufferInfoQnx = 1000529002,
        /// <summary>[requires: VK_QNX_external_memory_screen_buffer]</summary>
        StructureTypeExternalFormatQnx = 1000529003,
        /// <summary>[requires: VK_QNX_external_memory_screen_buffer]</summary>
        StructureTypePhysicalDeviceExternalMemoryScreenBufferFeaturesQnx = 1000529004,
        /// <summary>[requires: VK_MSFT_layered_driver]</summary>
        StructureTypePhysicalDeviceLayeredDriverPropertiesMsft = 1000530000,
        /// <summary>[requires: VK_KHR_index_type_uint8]</summary>
        StructureTypePhysicalDeviceIndexTypeUint8FeaturesKhr = 1000265000,
        /// <summary>[requires: VK_KHR_line_rasterization]</summary>
        StructureTypePhysicalDeviceLineRasterizationFeaturesKhr = 1000259000,
        /// <summary>[requires: VK_KHR_line_rasterization]</summary>
        StructureTypePipelineRasterizationLineStateCreateInfoKhr = 1000259001,
        /// <summary>[requires: VK_KHR_line_rasterization]</summary>
        StructureTypePhysicalDeviceLineRasterizationPropertiesKhr = 1000259002,
        /// <summary>[requires: VK_KHR_calibrated_timestamps]</summary>
        StructureTypeCalibratedTimestampInfoKhr = 1000184000,
        /// <summary>[requires: VK_KHR_shader_expect_assume]</summary>
        StructureTypePhysicalDeviceShaderExpectAssumeFeaturesKhr = 1000544000,
        /// <summary>[requires: VK_KHR_maintenance6]</summary>
        StructureTypePhysicalDeviceMaintenance6FeaturesKhr = 1000545000,
        /// <summary>[requires: VK_KHR_maintenance6]</summary>
        StructureTypePhysicalDeviceMaintenance6PropertiesKhr = 1000545001,
        /// <summary>[requires: VK_KHR_maintenance6]</summary>
        StructureTypeBindMemoryStatusKhr = 1000545002,
        /// <summary>[requires: VK_KHR_maintenance6]</summary>
        StructureTypeBindDescriptorSetsInfoKhr = 1000545003,
        /// <summary>[requires: VK_KHR_maintenance6]</summary>
        StructureTypePushConstantsInfoKhr = 1000545004,
        /// <summary>[requires: VK_KHR_maintenance6]</summary>
        StructureTypePushDescriptorSetInfoKhr = 1000545005,
        /// <summary>[requires: VK_KHR_maintenance6]</summary>
        StructureTypePushDescriptorSetWithTemplateInfoKhr = 1000545006,
        /// <summary>[requires: VK_KHR_maintenance6]</summary>
        StructureTypeSetDescriptorBufferOffsetsInfoExt = 1000545007,
        /// <summary>[requires: VK_KHR_maintenance6]</summary>
        StructureTypeBindDescriptorBufferEmbeddedSamplersInfoExt = 1000545008,
        /// <summary>[requires: VK_NV_descriptor_pool_overallocation]</summary>
        StructureTypePhysicalDeviceDescriptorPoolOverallocationFeaturesNv = 1000546000,
        /// <summary>[requires: VK_NV_raw_access_chains]</summary>
        StructureTypePhysicalDeviceRawAccessChainsFeaturesNv = 1000555000,
        /// <summary>[requires: VK_KHR_shader_relaxed_extended_instruction]</summary>
        StructureTypePhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKhr = 1000558000,
        /// <summary>[requires: VK_KHR_maintenance7]</summary>
        StructureTypePhysicalDeviceMaintenance7FeaturesKhr = 1000562000,
        /// <summary>[requires: VK_KHR_maintenance7]</summary>
        StructureTypePhysicalDeviceMaintenance7PropertiesKhr = 1000562001,
        /// <summary>[requires: VK_KHR_maintenance7]</summary>
        StructureTypePhysicalDeviceLayeredApiPropertiesListKhr = 1000562002,
        /// <summary>[requires: VK_KHR_maintenance7]</summary>
        StructureTypePhysicalDeviceLayeredApiPropertiesKhr = 1000562003,
        /// <summary>[requires: VK_KHR_maintenance7]</summary>
        StructureTypePhysicalDeviceLayeredApiVulkanPropertiesKhr = 1000562004,
        /// <summary>[requires: VK_NV_shader_atomic_float16_vector]</summary>
        StructureTypePhysicalDeviceShaderAtomicFloat16VectorFeaturesNv = 1000563000,
        /// <summary>[requires: VK_EXT_shader_replicated_composites]</summary>
        StructureTypePhysicalDeviceShaderReplicatedCompositesFeaturesExt = 1000564000,
        /// <summary>[requires: VK_NV_ray_tracing_validation]</summary>
        StructureTypePhysicalDeviceRayTracingValidationFeaturesNv = 1000568000,
        /// <summary>[requires: VK_MESA_image_alignment_control]</summary>
        StructureTypePhysicalDeviceImageAlignmentControlFeaturesMesa = 1000575000,
        /// <summary>[requires: VK_MESA_image_alignment_control]</summary>
        StructureTypePhysicalDeviceImageAlignmentControlPropertiesMesa = 1000575001,
        /// <summary>[requires: VK_MESA_image_alignment_control]</summary>
        StructureTypeImageAlignmentControlCreateInfoMesa = 1000575002,
        /// <summary>[requires: VK_EXT_debug_report]</summary>
        StructureTypeDebugReportCreateInfoExt = 1000011000,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        StructureTypeRenderingInfoKhr = 1000044000,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        StructureTypeRenderingAttachmentInfoKhr = 1000044001,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        StructureTypePipelineRenderingCreateInfoKhr = 1000044002,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        StructureTypePhysicalDeviceDynamicRenderingFeaturesKhr = 1000044003,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        StructureTypeCommandBufferInheritanceRenderingInfoKhr = 1000044004,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        StructureTypeAttachmentSampleCountInfoNv = 1000044008,
        /// <summary>[requires: VK_KHR_multiview]</summary>
        StructureTypeRenderPassMultiviewCreateInfoKhr = 1000053000,
        /// <summary>[requires: VK_KHR_multiview]</summary>
        StructureTypePhysicalDeviceMultiviewFeaturesKhr = 1000053001,
        /// <summary>[requires: VK_KHR_multiview]</summary>
        StructureTypePhysicalDeviceMultiviewPropertiesKhr = 1000053002,
        /// <summary>[requires: VK_KHR_get_physical_device_properties2]</summary>
        StructureTypePhysicalDeviceFeatures2Khr = 1000059000,
        /// <summary>[requires: VK_KHR_get_physical_device_properties2]</summary>
        StructureTypePhysicalDeviceProperties2Khr = 1000059001,
        /// <summary>[requires: VK_KHR_get_physical_device_properties2]</summary>
        StructureTypeFormatProperties2Khr = 1000059002,
        /// <summary>[requires: VK_KHR_get_physical_device_properties2]</summary>
        StructureTypeImageFormatProperties2Khr = 1000059003,
        /// <summary>[requires: VK_KHR_get_physical_device_properties2]</summary>
        StructureTypePhysicalDeviceImageFormatInfo2Khr = 1000059004,
        /// <summary>[requires: VK_KHR_get_physical_device_properties2]</summary>
        StructureTypeQueueFamilyProperties2Khr = 1000059005,
        /// <summary>[requires: VK_KHR_get_physical_device_properties2]</summary>
        StructureTypePhysicalDeviceMemoryProperties2Khr = 1000059006,
        /// <summary>[requires: VK_KHR_get_physical_device_properties2]</summary>
        StructureTypeSparseImageFormatProperties2Khr = 1000059007,
        /// <summary>[requires: VK_KHR_get_physical_device_properties2]</summary>
        StructureTypePhysicalDeviceSparseImageFormatInfo2Khr = 1000059008,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        StructureTypeMemoryAllocateFlagsInfoKhr = 1000060000,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        StructureTypeDeviceGroupRenderPassBeginInfoKhr = 1000060003,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        StructureTypeDeviceGroupCommandBufferBeginInfoKhr = 1000060004,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        StructureTypeDeviceGroupSubmitInfoKhr = 1000060005,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        StructureTypeDeviceGroupBindSparseInfoKhr = 1000060006,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        StructureTypeBindBufferMemoryDeviceGroupInfoKhr = 1000060013,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        StructureTypeBindImageMemoryDeviceGroupInfoKhr = 1000060014,
        /// <summary>[requires: VK_EXT_texture_compression_astc_hdr]</summary>
        StructureTypePhysicalDeviceTextureCompressionAstcHdrFeaturesExt = 1000066000,
        /// <summary>[requires: VK_KHR_device_group_creation]</summary>
        StructureTypePhysicalDeviceGroupPropertiesKhr = 1000070000,
        /// <summary>[requires: VK_KHR_device_group_creation]</summary>
        StructureTypeDeviceGroupDeviceCreateInfoKhr = 1000070001,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        StructureTypePhysicalDeviceExternalImageFormatInfoKhr = 1000071000,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        StructureTypeExternalImageFormatPropertiesKhr = 1000071001,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        StructureTypePhysicalDeviceExternalBufferInfoKhr = 1000071002,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        StructureTypeExternalBufferPropertiesKhr = 1000071003,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        StructureTypePhysicalDeviceIdPropertiesKhr = 1000071004,
        /// <summary>[requires: VK_KHR_external_memory]</summary>
        StructureTypeExternalMemoryBufferCreateInfoKhr = 1000072000,
        /// <summary>[requires: VK_KHR_external_memory]</summary>
        StructureTypeExternalMemoryImageCreateInfoKhr = 1000072001,
        /// <summary>[requires: VK_KHR_external_memory]</summary>
        StructureTypeExportMemoryAllocateInfoKhr = 1000072002,
        /// <summary>[requires: VK_KHR_external_semaphore_capabilities]</summary>
        StructureTypePhysicalDeviceExternalSemaphoreInfoKhr = 1000076000,
        /// <summary>[requires: VK_KHR_external_semaphore_capabilities]</summary>
        StructureTypeExternalSemaphorePropertiesKhr = 1000076001,
        /// <summary>[requires: VK_KHR_external_semaphore]</summary>
        StructureTypeExportSemaphoreCreateInfoKhr = 1000077000,
        /// <summary>[requires: VK_KHR_shader_float16_int8]</summary>
        StructureTypePhysicalDeviceShaderFloat16Int8FeaturesKhr = 1000082000,
        /// <summary>[requires: VK_KHR_shader_float16_int8]</summary>
        StructureTypePhysicalDeviceFloat16Int8FeaturesKhr = 1000082000,
        /// <summary>[requires: VK_KHR_16bit_storage]</summary>
        StructureTypePhysicalDevice16bitStorageFeaturesKhr = 1000083000,
        /// <summary>[requires: VK_KHR_descriptor_update_template]</summary>
        StructureTypeDescriptorUpdateTemplateCreateInfoKhr = 1000085000,
        /// <summary>[requires: VK_KHR_imageless_framebuffer]</summary>
        StructureTypePhysicalDeviceImagelessFramebufferFeaturesKhr = 1000108000,
        /// <summary>[requires: VK_KHR_imageless_framebuffer]</summary>
        StructureTypeFramebufferAttachmentsCreateInfoKhr = 1000108001,
        /// <summary>[requires: VK_KHR_imageless_framebuffer]</summary>
        StructureTypeFramebufferAttachmentImageInfoKhr = 1000108002,
        /// <summary>[requires: VK_KHR_imageless_framebuffer]</summary>
        StructureTypeRenderPassAttachmentBeginInfoKhr = 1000108003,
        /// <summary>[requires: VK_KHR_create_renderpass2]</summary>
        StructureTypeAttachmentDescription2Khr = 1000109000,
        /// <summary>[requires: VK_KHR_create_renderpass2]</summary>
        StructureTypeAttachmentReference2Khr = 1000109001,
        /// <summary>[requires: VK_KHR_create_renderpass2]</summary>
        StructureTypeSubpassDescription2Khr = 1000109002,
        /// <summary>[requires: VK_KHR_create_renderpass2]</summary>
        StructureTypeSubpassDependency2Khr = 1000109003,
        /// <summary>[requires: VK_KHR_create_renderpass2]</summary>
        StructureTypeRenderPassCreateInfo2Khr = 1000109004,
        /// <summary>[requires: VK_KHR_create_renderpass2]</summary>
        StructureTypeSubpassBeginInfoKhr = 1000109005,
        /// <summary>[requires: VK_KHR_create_renderpass2]</summary>
        StructureTypeSubpassEndInfoKhr = 1000109006,
        /// <summary>[requires: VK_KHR_external_fence_capabilities]</summary>
        StructureTypePhysicalDeviceExternalFenceInfoKhr = 1000112000,
        /// <summary>[requires: VK_KHR_external_fence_capabilities]</summary>
        StructureTypeExternalFencePropertiesKhr = 1000112001,
        /// <summary>[requires: VK_KHR_external_fence]</summary>
        StructureTypeExportFenceCreateInfoKhr = 1000113000,
        /// <summary>[requires: VK_KHR_maintenance2]</summary>
        StructureTypePhysicalDevicePointClippingPropertiesKhr = 1000117000,
        /// <summary>[requires: VK_KHR_maintenance2]</summary>
        StructureTypeRenderPassInputAttachmentAspectCreateInfoKhr = 1000117001,
        /// <summary>[requires: VK_KHR_maintenance2]</summary>
        StructureTypeImageViewUsageCreateInfoKhr = 1000117002,
        /// <summary>[requires: VK_KHR_maintenance2]</summary>
        StructureTypePipelineTessellationDomainOriginStateCreateInfoKhr = 1000117003,
        /// <summary>[requires: VK_KHR_variable_pointers]</summary>
        StructureTypePhysicalDeviceVariablePointersFeaturesKhr = 1000120000,
        /// <summary>[requires: VK_KHR_variable_pointers]</summary>
        StructureTypePhysicalDeviceVariablePointerFeaturesKhr = 1000120000,
        /// <summary>[requires: VK_KHR_dedicated_allocation]</summary>
        StructureTypeMemoryDedicatedRequirementsKhr = 1000127000,
        /// <summary>[requires: VK_KHR_dedicated_allocation]</summary>
        StructureTypeMemoryDedicatedAllocateInfoKhr = 1000127001,
        /// <summary>[requires: VK_EXT_sampler_filter_minmax]</summary>
        StructureTypePhysicalDeviceSamplerFilterMinmaxPropertiesExt = 1000130000,
        /// <summary>[requires: VK_EXT_sampler_filter_minmax]</summary>
        StructureTypeSamplerReductionModeCreateInfoExt = 1000130001,
        /// <summary>[requires: VK_EXT_inline_uniform_block]</summary>
        StructureTypePhysicalDeviceInlineUniformBlockFeaturesExt = 1000138000,
        /// <summary>[requires: VK_EXT_inline_uniform_block]</summary>
        StructureTypePhysicalDeviceInlineUniformBlockPropertiesExt = 1000138001,
        /// <summary>[requires: VK_EXT_inline_uniform_block]</summary>
        StructureTypeWriteDescriptorSetInlineUniformBlockExt = 1000138002,
        /// <summary>[requires: VK_EXT_inline_uniform_block]</summary>
        StructureTypeDescriptorPoolInlineUniformBlockCreateInfoExt = 1000138003,
        /// <summary>[requires: VK_KHR_get_memory_requirements2]</summary>
        StructureTypeBufferMemoryRequirementsInfo2Khr = 1000146000,
        /// <summary>[requires: VK_KHR_get_memory_requirements2]</summary>
        StructureTypeImageMemoryRequirementsInfo2Khr = 1000146001,
        /// <summary>[requires: VK_KHR_get_memory_requirements2]</summary>
        StructureTypeImageSparseMemoryRequirementsInfo2Khr = 1000146002,
        /// <summary>[requires: VK_KHR_get_memory_requirements2]</summary>
        StructureTypeMemoryRequirements2Khr = 1000146003,
        /// <summary>[requires: VK_KHR_get_memory_requirements2]</summary>
        StructureTypeSparseImageMemoryRequirements2Khr = 1000146004,
        /// <summary>[requires: VK_KHR_image_format_list]</summary>
        StructureTypeImageFormatListCreateInfoKhr = 1000147000,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        StructureTypeSamplerYcbcrConversionCreateInfoKhr = 1000156000,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        StructureTypeSamplerYcbcrConversionInfoKhr = 1000156001,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        StructureTypeBindImagePlaneMemoryInfoKhr = 1000156002,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        StructureTypeImagePlaneMemoryRequirementsInfoKhr = 1000156003,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        StructureTypePhysicalDeviceSamplerYcbcrConversionFeaturesKhr = 1000156004,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        StructureTypeSamplerYcbcrConversionImageFormatPropertiesKhr = 1000156005,
        /// <summary>[requires: VK_KHR_bind_memory2]</summary>
        StructureTypeBindBufferMemoryInfoKhr = 1000157000,
        /// <summary>[requires: VK_KHR_bind_memory2]</summary>
        StructureTypeBindImageMemoryInfoKhr = 1000157001,
        /// <summary>[requires: VK_EXT_descriptor_indexing]</summary>
        StructureTypeDescriptorSetLayoutBindingFlagsCreateInfoExt = 1000161000,
        /// <summary>[requires: VK_EXT_descriptor_indexing]</summary>
        StructureTypePhysicalDeviceDescriptorIndexingFeaturesExt = 1000161001,
        /// <summary>[requires: VK_EXT_descriptor_indexing]</summary>
        StructureTypePhysicalDeviceDescriptorIndexingPropertiesExt = 1000161002,
        /// <summary>[requires: VK_EXT_descriptor_indexing]</summary>
        StructureTypeDescriptorSetVariableDescriptorCountAllocateInfoExt = 1000161003,
        /// <summary>[requires: VK_EXT_descriptor_indexing]</summary>
        StructureTypeDescriptorSetVariableDescriptorCountLayoutSupportExt = 1000161004,
        /// <summary>[requires: VK_KHR_maintenance3]</summary>
        StructureTypePhysicalDeviceMaintenance3PropertiesKhr = 1000168000,
        /// <summary>[requires: VK_KHR_maintenance3]</summary>
        StructureTypeDescriptorSetLayoutSupportKhr = 1000168001,
        /// <summary>[requires: VK_EXT_global_priority]</summary>
        StructureTypeDeviceQueueGlobalPriorityCreateInfoExt = 1000174000,
        /// <summary>[requires: VK_KHR_shader_subgroup_extended_types]</summary>
        StructureTypePhysicalDeviceShaderSubgroupExtendedTypesFeaturesKhr = 1000175000,
        /// <summary>[requires: VK_KHR_8bit_storage]</summary>
        StructureTypePhysicalDevice8bitStorageFeaturesKhr = 1000177000,
        /// <summary>[requires: VK_KHR_shader_atomic_int64]</summary>
        StructureTypePhysicalDeviceShaderAtomicInt64FeaturesKhr = 1000180000,
        /// <summary>[requires: VK_EXT_calibrated_timestamps]</summary>
        StructureTypeCalibratedTimestampInfoExt = 1000184000,
        /// <summary>[requires: VK_EXT_vertex_attribute_divisor]</summary>
        StructureTypePipelineVertexInputDivisorStateCreateInfoExt = 1000190001,
        /// <summary>[requires: VK_EXT_vertex_attribute_divisor]</summary>
        StructureTypePhysicalDeviceVertexAttributeDivisorFeaturesExt = 1000190002,
        /// <summary>[requires: VK_EXT_pipeline_creation_feedback]</summary>
        StructureTypePipelineCreationFeedbackCreateInfoExt = 1000192000,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        StructureTypePhysicalDeviceDriverPropertiesKhr = 1000196000,
        /// <summary>[requires: VK_KHR_shader_float_controls]</summary>
        StructureTypePhysicalDeviceFloatControlsPropertiesKhr = 1000197000,
        /// <summary>[requires: VK_KHR_depth_stencil_resolve]</summary>
        StructureTypePhysicalDeviceDepthStencilResolvePropertiesKhr = 1000199000,
        /// <summary>[requires: VK_KHR_depth_stencil_resolve]</summary>
        StructureTypeSubpassDescriptionDepthStencilResolveKhr = 1000199001,
        /// <summary>[requires: VK_NV_fragment_shader_barycentric]</summary>
        StructureTypePhysicalDeviceFragmentShaderBarycentricFeaturesNv = 1000203000,
        /// <summary>[requires: VK_KHR_timeline_semaphore]</summary>
        StructureTypePhysicalDeviceTimelineSemaphoreFeaturesKhr = 1000207000,
        /// <summary>[requires: VK_KHR_timeline_semaphore]</summary>
        StructureTypePhysicalDeviceTimelineSemaphorePropertiesKhr = 1000207001,
        /// <summary>[requires: VK_KHR_timeline_semaphore]</summary>
        StructureTypeSemaphoreTypeCreateInfoKhr = 1000207002,
        /// <summary>[requires: VK_KHR_timeline_semaphore]</summary>
        StructureTypeTimelineSemaphoreSubmitInfoKhr = 1000207003,
        /// <summary>[requires: VK_KHR_timeline_semaphore]</summary>
        StructureTypeSemaphoreWaitInfoKhr = 1000207004,
        /// <summary>[requires: VK_KHR_timeline_semaphore]</summary>
        StructureTypeSemaphoreSignalInfoKhr = 1000207005,
        /// <summary>[requires: VK_INTEL_performance_query]</summary>
        StructureTypeQueryPoolCreateInfoIntel = 1000210000,
        /// <summary>[requires: VK_KHR_vulkan_memory_model]</summary>
        StructureTypePhysicalDeviceVulkanMemoryModelFeaturesKhr = 1000211000,
        /// <summary>[requires: VK_KHR_shader_terminate_invocation]</summary>
        StructureTypePhysicalDeviceShaderTerminateInvocationFeaturesKhr = 1000215000,
        /// <summary>[requires: VK_EXT_scalar_block_layout]</summary>
        StructureTypePhysicalDeviceScalarBlockLayoutFeaturesExt = 1000221000,
        /// <summary>[requires: VK_EXT_subgroup_size_control]</summary>
        StructureTypePhysicalDeviceSubgroupSizeControlPropertiesExt = 1000225000,
        /// <summary>[requires: VK_EXT_subgroup_size_control]</summary>
        StructureTypePipelineShaderStageRequiredSubgroupSizeCreateInfoExt = 1000225001,
        /// <summary>[requires: VK_EXT_subgroup_size_control]</summary>
        StructureTypePhysicalDeviceSubgroupSizeControlFeaturesExt = 1000225002,
        /// <summary>[requires: VK_KHR_separate_depth_stencil_layouts]</summary>
        StructureTypePhysicalDeviceSeparateDepthStencilLayoutsFeaturesKhr = 1000241000,
        /// <summary>[requires: VK_KHR_separate_depth_stencil_layouts]</summary>
        StructureTypeAttachmentReferenceStencilLayoutKhr = 1000241001,
        /// <summary>[requires: VK_KHR_separate_depth_stencil_layouts]</summary>
        StructureTypeAttachmentDescriptionStencilLayoutKhr = 1000241002,
        /// <summary>[requires: VK_EXT_buffer_device_address]</summary>
        StructureTypePhysicalDeviceBufferAddressFeaturesExt = 1000244000,
        /// <summary>[requires: VK_EXT_buffer_device_address]</summary>
        StructureTypeBufferDeviceAddressInfoExt = 1000244001,
        /// <summary>[requires: VK_EXT_tooling_info]</summary>
        StructureTypePhysicalDeviceToolPropertiesExt = 1000245000,
        /// <summary>[requires: VK_EXT_separate_stencil_usage]</summary>
        StructureTypeImageStencilUsageCreateInfoExt = 1000246000,
        /// <summary>[requires: VK_KHR_uniform_buffer_standard_layout]</summary>
        StructureTypePhysicalDeviceUniformBufferStandardLayoutFeaturesKhr = 1000253000,
        /// <summary>[requires: VK_KHR_buffer_device_address]</summary>
        StructureTypePhysicalDeviceBufferDeviceAddressFeaturesKhr = 1000257000,
        /// <summary>[requires: VK_KHR_buffer_device_address]</summary>
        StructureTypeBufferDeviceAddressInfoKhr = 1000244001,
        /// <summary>[requires: VK_KHR_buffer_device_address]</summary>
        StructureTypeBufferOpaqueCaptureAddressCreateInfoKhr = 1000257002,
        /// <summary>[requires: VK_KHR_buffer_device_address]</summary>
        StructureTypeMemoryOpaqueCaptureAddressAllocateInfoKhr = 1000257003,
        /// <summary>[requires: VK_KHR_buffer_device_address]</summary>
        StructureTypeDeviceMemoryOpaqueCaptureAddressInfoKhr = 1000257004,
        /// <summary>[requires: VK_EXT_line_rasterization]</summary>
        StructureTypePhysicalDeviceLineRasterizationFeaturesExt = 1000259000,
        /// <summary>[requires: VK_EXT_line_rasterization]</summary>
        StructureTypePipelineRasterizationLineStateCreateInfoExt = 1000259001,
        /// <summary>[requires: VK_EXT_line_rasterization]</summary>
        StructureTypePhysicalDeviceLineRasterizationPropertiesExt = 1000259002,
        /// <summary>[requires: VK_EXT_host_query_reset]</summary>
        StructureTypePhysicalDeviceHostQueryResetFeaturesExt = 1000261000,
        /// <summary>[requires: VK_EXT_index_type_uint8]</summary>
        StructureTypePhysicalDeviceIndexTypeUint8FeaturesExt = 1000265000,
        /// <summary>[requires: VK_EXT_shader_demote_to_helper_invocation]</summary>
        StructureTypePhysicalDeviceShaderDemoteToHelperInvocationFeaturesExt = 1000276000,
        /// <summary>[requires: VK_KHR_shader_integer_dot_product]</summary>
        StructureTypePhysicalDeviceShaderIntegerDotProductFeaturesKhr = 1000280000,
        /// <summary>[requires: VK_KHR_shader_integer_dot_product]</summary>
        StructureTypePhysicalDeviceShaderIntegerDotProductPropertiesKhr = 1000280001,
        /// <summary>[requires: VK_EXT_texel_buffer_alignment]</summary>
        StructureTypePhysicalDeviceTexelBufferAlignmentPropertiesExt = 1000281001,
        /// <summary>[requires: VK_EXT_private_data]</summary>
        StructureTypePhysicalDevicePrivateDataFeaturesExt = 1000295000,
        /// <summary>[requires: VK_EXT_private_data]</summary>
        StructureTypeDevicePrivateDataCreateInfoExt = 1000295001,
        /// <summary>[requires: VK_EXT_private_data]</summary>
        StructureTypePrivateDataSlotCreateInfoExt = 1000295002,
        /// <summary>[requires: VK_EXT_pipeline_creation_cache_control]</summary>
        StructureTypePhysicalDevicePipelineCreationCacheControlFeaturesExt = 1000297000,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        StructureTypeMemoryBarrier2Khr = 1000314000,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        StructureTypeBufferMemoryBarrier2Khr = 1000314001,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        StructureTypeImageMemoryBarrier2Khr = 1000314002,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        StructureTypeDependencyInfoKhr = 1000314003,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        StructureTypeSubmitInfo2Khr = 1000314004,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        StructureTypeSemaphoreSubmitInfoKhr = 1000314005,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        StructureTypeCommandBufferSubmitInfoKhr = 1000314006,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        StructureTypePhysicalDeviceSynchronization2FeaturesKhr = 1000314007,
        /// <summary>[requires: VK_KHR_zero_initialize_workgroup_memory]</summary>
        StructureTypePhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKhr = 1000325000,
        /// <summary>[requires: VK_EXT_image_robustness]</summary>
        StructureTypePhysicalDeviceImageRobustnessFeaturesExt = 1000335000,
        /// <summary>[requires: VK_KHR_copy_commands2]</summary>
        StructureTypeCopyBufferInfo2Khr = 1000337000,
        /// <summary>[requires: VK_KHR_copy_commands2]</summary>
        StructureTypeCopyImageInfo2Khr = 1000337001,
        /// <summary>[requires: VK_KHR_copy_commands2]</summary>
        StructureTypeCopyBufferToImageInfo2Khr = 1000337002,
        /// <summary>[requires: VK_KHR_copy_commands2]</summary>
        StructureTypeCopyImageToBufferInfo2Khr = 1000337003,
        /// <summary>[requires: VK_KHR_copy_commands2]</summary>
        StructureTypeBlitImageInfo2Khr = 1000337004,
        /// <summary>[requires: VK_KHR_copy_commands2]</summary>
        StructureTypeResolveImageInfo2Khr = 1000337005,
        /// <summary>[requires: VK_KHR_copy_commands2]</summary>
        StructureTypeBufferCopy2Khr = 1000337006,
        /// <summary>[requires: VK_KHR_copy_commands2]</summary>
        StructureTypeImageCopy2Khr = 1000337007,
        /// <summary>[requires: VK_KHR_copy_commands2]</summary>
        StructureTypeImageBlit2Khr = 1000337008,
        /// <summary>[requires: VK_KHR_copy_commands2]</summary>
        StructureTypeBufferImageCopy2Khr = 1000337009,
        /// <summary>[requires: VK_KHR_copy_commands2]</summary>
        StructureTypeImageResolve2Khr = 1000337010,
        /// <summary>[requires: VK_EXT_image_compression_control]</summary>
        StructureTypeSubresourceLayout2Ext = 1000338002,
        /// <summary>[requires: VK_EXT_image_compression_control]</summary>
        StructureTypeImageSubresource2Ext = 1000338003,
        /// <summary>[requires: VK_ARM_rasterization_order_attachment_access]</summary>
        StructureTypePhysicalDeviceRasterizationOrderAttachmentAccessFeaturesArm = 1000342000,
        /// <summary>[requires: VK_VALVE_mutable_descriptor_type]</summary>
        StructureTypePhysicalDeviceMutableDescriptorTypeFeaturesValve = 1000351000,
        /// <summary>[requires: VK_VALVE_mutable_descriptor_type]</summary>
        StructureTypeMutableDescriptorTypeCreateInfoValve = 1000351002,
        /// <summary>[requires: VK_KHR_format_feature_flags2]</summary>
        StructureTypeFormatProperties3Khr = 1000360000,
        /// <summary>[requires: VK_EXT_pipeline_properties]</summary>
        StructureTypePipelineInfoExt = 1000269001,
        /// <summary>[requires: VK_NV_external_memory_sci_buf]</summary>
        StructureTypePhysicalDeviceExternalSciBufFeaturesNv = 1000374004,
        /// <summary>[requires: VK_EXT_global_priority_query]</summary>
        StructureTypePhysicalDeviceGlobalPriorityQueryFeaturesExt = 1000388000,
        /// <summary>[requires: VK_EXT_global_priority_query]</summary>
        StructureTypeQueueFamilyGlobalPriorityPropertiesExt = 1000388001,
        /// <summary>[requires: VK_KHR_maintenance4]</summary>
        StructureTypePhysicalDeviceMaintenance4FeaturesKhr = 1000413000,
        /// <summary>[requires: VK_KHR_maintenance4]</summary>
        StructureTypePhysicalDeviceMaintenance4PropertiesKhr = 1000413001,
        /// <summary>[requires: VK_KHR_maintenance4]</summary>
        StructureTypeDeviceBufferMemoryRequirementsKhr = 1000413002,
        /// <summary>[requires: VK_KHR_maintenance4]</summary>
        StructureTypeDeviceImageMemoryRequirementsKhr = 1000413003,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        StructureTypeShaderRequiredSubgroupSizeCreateInfoExt = 1000225001,
    }
    public enum VkSubpassContents : int
    {
        SubpassContentsInline = 0,
        SubpassContentsSecondaryCommandBuffers = 1,
        /// <summary>[requires: VK_KHR_maintenance7]</summary>
        SubpassContentsInlineAndSecondaryCommandBuffersKhr = 1000451000,
        /// <summary>[requires: VK_EXT_nested_command_buffer]</summary>
        SubpassContentsInlineAndSecondaryCommandBuffersExt = 1000451000,
    }
    public enum VkResult : int
    {
        /// <summary>Command completed successfully</summary>
        Success = 0,
        /// <summary>A fence or query has not yet completed</summary>
        NotReady = 1,
        /// <summary>A wait operation has not completed in the specified time</summary>
        Timeout = 2,
        /// <summary>An event is signaled</summary>
        EventSet = 3,
        /// <summary>An event is unsignaled</summary>
        EventReset = 4,
        /// <summary>A return array was too small for the result</summary>
        Incomplete = 5,
        /// <summary>A host memory allocation has failed</summary>
        ErrorOutOfHostMemory = -1,
        /// <summary>A device memory allocation has failed</summary>
        ErrorOutOfDeviceMemory = -2,
        /// <summary>Initialization of an object has failed</summary>
        ErrorInitializationFailed = -3,
        /// <summary>The logical device has been lost. See <<devsandqueues-lost-device>></summary>
        ErrorDeviceLost = -4,
        /// <summary>Mapping of a memory object has failed</summary>
        ErrorMemoryMapFailed = -5,
        /// <summary>Layer specified does not exist</summary>
        ErrorLayerNotPresent = -6,
        /// <summary>Extension specified does not exist</summary>
        ErrorExtensionNotPresent = -7,
        /// <summary>Requested feature is not available on this device</summary>
        ErrorFeatureNotPresent = -8,
        /// <summary>Unable to find a Vulkan driver</summary>
        ErrorIncompatibleDriver = -9,
        /// <summary>Too many objects of the type have already been created</summary>
        ErrorTooManyObjects = -10,
        /// <summary>Requested format is not supported on this device</summary>
        ErrorFormatNotSupported = -11,
        /// <summary>A requested pool allocation has failed due to fragmentation of the pool's memory</summary>
        ErrorFragmentedPool = -12,
        /// <summary>An unknown error has occurred, due to an implementation or application bug</summary>
        ErrorUnknown = -13,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ErrorOutOfPoolMemory = -1000069000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ErrorInvalidExternalHandle = -1000072003,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        ErrorFragmentation = -1000161000,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        ErrorInvalidOpaqueCaptureAddress = -1000257000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        PipelineCompileRequired = 1000297000,
        /// <summary>[requires: VK_KHR_surface]</summary>
        ErrorSurfaceLostKhr = -1000000000,
        /// <summary>[requires: VK_KHR_surface]</summary>
        ErrorNativeWindowInUseKhr = -1000000001,
        /// <summary>[requires: VK_KHR_swapchain]</summary>
        SuboptimalKhr = 1000001003,
        /// <summary>[requires: VK_KHR_swapchain]</summary>
        ErrorOutOfDateKhr = -1000001004,
        /// <summary>[requires: VK_KHR_display_swapchain]</summary>
        ErrorIncompatibleDisplayKhr = -1000003001,
        /// <summary>[requires: VK_EXT_debug_report]</summary>
        ErrorValidationFailedExt = -1000011001,
        /// <summary>[requires: VK_NV_glsl_shader]</summary>
        ErrorInvalidShaderNv = -1000012000,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        ErrorImageUsageNotSupportedKhr = -1000023000,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        ErrorVideoPictureLayoutNotSupportedKhr = -1000023001,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        ErrorVideoProfileOperationNotSupportedKhr = -1000023002,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        ErrorVideoProfileFormatNotSupportedKhr = -1000023003,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        ErrorVideoProfileCodecNotSupportedKhr = -1000023004,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        ErrorVideoStdVersionNotSupportedKhr = -1000023005,
        /// <summary>[requires: VK_EXT_image_drm_format_modifier]</summary>
        ErrorInvalidDrmFormatModifierPlaneLayoutExt = -1000158000,
        /// <summary>[requires: VK_KHR_global_priority]</summary>
        ErrorNotPermittedKhr = -1000174001,
        /// <summary>[requires: VK_EXT_full_screen_exclusive]</summary>
        ErrorFullScreenExclusiveModeLostExt = -1000255000,
        /// <summary>[requires: VK_KHR_deferred_host_operations]</summary>
        ThreadIdleKhr = 1000268000,
        /// <summary>[requires: VK_KHR_deferred_host_operations]</summary>
        ThreadDoneKhr = 1000268001,
        /// <summary>[requires: VK_KHR_deferred_host_operations]</summary>
        OperationDeferredKhr = 1000268002,
        /// <summary>[requires: VK_KHR_deferred_host_operations]</summary>
        OperationNotDeferredKhr = 1000268003,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        ErrorInvalidVideoStdParametersKhr = -1000299000,
        /// <summary>[requires: VK_EXT_image_compression_control]</summary>
        ErrorCompressionExhaustedExt = -1000338000,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        IncompatibleShaderBinaryExt = 1000482000,
        /// <summary>[requires: VK_KHR_maintenance1]</summary>
        ErrorOutOfPoolMemoryKhr = -1000069000,
        /// <summary>[requires: VK_KHR_external_memory]</summary>
        ErrorInvalidExternalHandleKhr = -1000072003,
        /// <summary>[requires: VK_EXT_descriptor_indexing]</summary>
        ErrorFragmentationExt = -1000161000,
        /// <summary>[requires: VK_EXT_global_priority]</summary>
        ErrorNotPermittedExt = -1000174001,
        /// <summary>[requires: VK_EXT_buffer_device_address]</summary>
        ErrorInvalidDeviceAddressExt = -1000257000,
        /// <summary>[requires: VK_KHR_buffer_device_address]</summary>
        ErrorInvalidOpaqueCaptureAddressKhr = -1000257000,
        /// <summary>[requires: VK_EXT_pipeline_creation_cache_control]</summary>
        PipelineCompileRequiredExt = 1000297000,
        /// <summary>[requires: VK_EXT_pipeline_creation_cache_control]</summary>
        ErrorPipelineCompileRequiredExt = 1000297000,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        ErrorIncompatibleShaderBinaryExt = 1000482000,
    }
    public enum VkDynamicState : int
    {
        DynamicStateViewport = 0,
        DynamicStateScissor = 1,
        DynamicStateLineWidth = 2,
        DynamicStateDepthBias = 3,
        DynamicStateBlendConstants = 4,
        DynamicStateDepthBounds = 5,
        DynamicStateStencilCompareMask = 6,
        DynamicStateStencilWriteMask = 7,
        DynamicStateStencilReference = 8,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateCullMode = 1000267000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateFrontFace = 1000267001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStatePrimitiveTopology = 1000267002,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateViewportWithCount = 1000267003,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateScissorWithCount = 1000267004,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateVertexInputBindingStride = 1000267005,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateDepthTestEnable = 1000267006,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateDepthWriteEnable = 1000267007,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateDepthCompareOp = 1000267008,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateDepthBoundsTestEnable = 1000267009,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateStencilTestEnable = 1000267010,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateStencilOp = 1000267011,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateRasterizerDiscardEnable = 1000377001,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStateDepthBiasEnable = 1000377002,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        DynamicStatePrimitiveRestartEnable = 1000377004,
        /// <summary>[requires: VK_NV_clip_space_w_scaling]</summary>
        DynamicStateViewportWScalingNv = 1000087000,
        /// <summary>[requires: VK_EXT_discard_rectangles]</summary>
        DynamicStateDiscardRectangleExt = 1000099000,
        /// <summary>[requires: VK_EXT_discard_rectangles]</summary>
        DynamicStateDiscardRectangleEnableExt = 1000099001,
        /// <summary>[requires: VK_EXT_discard_rectangles]</summary>
        DynamicStateDiscardRectangleModeExt = 1000099002,
        /// <summary>[requires: VK_EXT_sample_locations]</summary>
        DynamicStateSampleLocationsExt = 1000143000,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        DynamicStateRayTracingPipelineStackSizeKhr = 1000347000,
        /// <summary>[requires: VK_NV_shading_rate_image]</summary>
        DynamicStateViewportShadingRatePaletteNv = 1000164004,
        /// <summary>[requires: VK_NV_shading_rate_image]</summary>
        DynamicStateViewportCoarseSampleOrderNv = 1000164006,
        /// <summary>[requires: VK_NV_scissor_exclusive]</summary>
        DynamicStateExclusiveScissorEnableNv = 1000205000,
        /// <summary>[requires: VK_NV_scissor_exclusive]</summary>
        DynamicStateExclusiveScissorNv = 1000205001,
        /// <summary>[requires: VK_KHR_fragment_shading_rate]</summary>
        DynamicStateFragmentShadingRateKhr = 1000226000,
        /// <summary>[requires: VK_EXT_vertex_input_dynamic_state]</summary>
        DynamicStateVertexInputExt = 1000352000,
        /// <summary>[requires: VK_EXT_extended_dynamic_state2]Not promoted to 1.3</summary>
        DynamicStatePatchControlPointsExt = 1000377000,
        /// <summary>[requires: VK_EXT_extended_dynamic_state2]Not promoted to 1.3</summary>
        DynamicStateLogicOpExt = 1000377003,
        /// <summary>[requires: VK_EXT_color_write_enable]</summary>
        DynamicStateColorWriteEnableExt = 1000381000,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateDepthClampEnableExt = 1000455003,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStatePolygonModeExt = 1000455004,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateRasterizationSamplesExt = 1000455005,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateSampleMaskExt = 1000455006,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateAlphaToCoverageEnableExt = 1000455007,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateAlphaToOneEnableExt = 1000455008,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateLogicOpEnableExt = 1000455009,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateColorBlendEnableExt = 1000455010,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateColorBlendEquationExt = 1000455011,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateColorWriteMaskExt = 1000455012,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateTessellationDomainOriginExt = 1000455002,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateRasterizationStreamExt = 1000455013,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateConservativeRasterizationModeExt = 1000455014,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateExtraPrimitiveOverestimationSizeExt = 1000455015,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateDepthClipEnableExt = 1000455016,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateSampleLocationsEnableExt = 1000455017,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateColorBlendAdvancedExt = 1000455018,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateProvokingVertexModeExt = 1000455019,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateLineRasterizationModeExt = 1000455020,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateLineStippleEnableExt = 1000455021,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateDepthClipNegativeOneToOneExt = 1000455022,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateViewportWScalingEnableNv = 1000455023,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateViewportSwizzleNv = 1000455024,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateCoverageToColorEnableNv = 1000455025,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateCoverageToColorLocationNv = 1000455026,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateCoverageModulationModeNv = 1000455027,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateCoverageModulationTableEnableNv = 1000455028,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateCoverageModulationTableNv = 1000455029,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateShadingRateImageEnableNv = 1000455030,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateRepresentativeFragmentTestEnableNv = 1000455031,
        /// <summary>[requires: VK_EXT_extended_dynamic_state3]</summary>
        DynamicStateCoverageReductionModeNv = 1000455032,
        /// <summary>[requires: VK_EXT_attachment_feedback_loop_dynamic_state]</summary>
        DynamicStateAttachmentFeedbackLoopEnableExt = 1000524000,
        /// <summary>[requires: VK_KHR_line_rasterization]</summary>
        DynamicStateLineStippleKhr = 1000259000,
        /// <summary>[requires: VK_EXT_line_rasterization]</summary>
        DynamicStateLineStippleExt = 1000259000,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]</summary>
        DynamicStateCullModeExt = 1000267000,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]</summary>
        DynamicStateFrontFaceExt = 1000267001,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]</summary>
        DynamicStatePrimitiveTopologyExt = 1000267002,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]</summary>
        DynamicStateViewportWithCountExt = 1000267003,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]</summary>
        DynamicStateScissorWithCountExt = 1000267004,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]</summary>
        DynamicStateVertexInputBindingStrideExt = 1000267005,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]</summary>
        DynamicStateDepthTestEnableExt = 1000267006,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]</summary>
        DynamicStateDepthWriteEnableExt = 1000267007,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]</summary>
        DynamicStateDepthCompareOpExt = 1000267008,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]</summary>
        DynamicStateDepthBoundsTestEnableExt = 1000267009,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]</summary>
        DynamicStateStencilTestEnableExt = 1000267010,
        /// <summary>[requires: VK_EXT_extended_dynamic_state]</summary>
        DynamicStateStencilOpExt = 1000267011,
        /// <summary>[requires: VK_EXT_extended_dynamic_state2]</summary>
        DynamicStateRasterizerDiscardEnableExt = 1000377001,
        /// <summary>[requires: VK_EXT_extended_dynamic_state2]</summary>
        DynamicStateDepthBiasEnableExt = 1000377002,
        /// <summary>[requires: VK_EXT_extended_dynamic_state2]</summary>
        DynamicStatePrimitiveRestartEnableExt = 1000377004,
    }
    public enum VkDescriptorUpdateTemplateType : int
    {
        /// <summary>Create descriptor update template for descriptor set updates</summary>
        DescriptorUpdateTemplateTypeDescriptorSet = 0,
        /// <summary>[requires: VK_KHR_push_descriptor]Create descriptor update template for pushed descriptor updates</summary>
        DescriptorUpdateTemplateTypePushDescriptorsKhr = 1,
        /// <summary>[requires: VK_KHR_descriptor_update_template]</summary>
        DescriptorUpdateTemplateTypeDescriptorSetKhr = 0,
    }
    public enum VkObjectType : int
    {
        ObjectTypeUnknown = 0,
        ObjectTypeInstance = 1,
        ObjectTypePhysicalDevice = 2,
        ObjectTypeDevice = 3,
        ObjectTypeQueue = 4,
        ObjectTypeSemaphore = 5,
        ObjectTypeCommandBuffer = 6,
        ObjectTypeFence = 7,
        ObjectTypeDeviceMemory = 8,
        ObjectTypeBuffer = 9,
        ObjectTypeImage = 10,
        ObjectTypeEvent = 11,
        ObjectTypeQueryPool = 12,
        ObjectTypeBufferView = 13,
        ObjectTypeImageView = 14,
        ObjectTypeShaderModule = 15,
        ObjectTypePipelineCache = 16,
        ObjectTypePipelineLayout = 17,
        ObjectTypeRenderPass = 18,
        ObjectTypePipeline = 19,
        ObjectTypeDescriptorSetLayout = 20,
        ObjectTypeSampler = 21,
        ObjectTypeDescriptorPool = 22,
        ObjectTypeDescriptorSet = 23,
        ObjectTypeFramebuffer = 24,
        ObjectTypeCommandPool = 25,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ObjectTypeSamplerYcbcrConversion = 1000156000,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ObjectTypeDescriptorUpdateTemplate = 1000085000,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        ObjectTypePrivateDataSlot = 1000295000,
        /// <summary>[requires: VK_KHR_surface]</summary>
        ObjectTypeSurfaceKhr = 1000000000,
        /// <summary>[requires: VK_KHR_swapchain]</summary>
        ObjectTypeSwapchainKhr = 1000001000,
        /// <summary>[requires: VK_KHR_display]</summary>
        ObjectTypeDisplayKhr = 1000002000,
        /// <summary>[requires: VK_KHR_display]</summary>
        ObjectTypeDisplayModeKhr = 1000002001,
        /// <summary>[requires: VK_EXT_debug_report]</summary>
        ObjectTypeDebugReportCallbackExt = 1000011000,
        /// <summary>[requires: VK_KHR_video_queue]VkVideoSessionKHR</summary>
        ObjectTypeVideoSessionKhr = 1000023000,
        /// <summary>[requires: VK_KHR_video_queue]VkVideoSessionParametersKHR</summary>
        ObjectTypeVideoSessionParametersKhr = 1000023001,
        /// <summary>[requires: VK_NVX_binary_import]</summary>
        ObjectTypeCuModuleNvx = 1000029000,
        /// <summary>[requires: VK_NVX_binary_import]</summary>
        ObjectTypeCuFunctionNvx = 1000029001,
        /// <summary>[requires: VK_EXT_debug_utils]</summary>
        ObjectTypeDebugUtilsMessengerExt = 1000128000,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        ObjectTypeAccelerationStructureKhr = 1000150000,
        /// <summary>[requires: VK_EXT_validation_cache]</summary>
        ObjectTypeValidationCacheExt = 1000160000,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        ObjectTypeAccelerationStructureNv = 1000165000,
        /// <summary>[requires: VK_INTEL_performance_query]</summary>
        ObjectTypePerformanceConfigurationIntel = 1000210000,
        /// <summary>[requires: VK_KHR_deferred_host_operations]</summary>
        ObjectTypeDeferredOperationKhr = 1000268000,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        ObjectTypeIndirectCommandsLayoutNv = 1000277000,
        /// <summary>[requires: VK_NV_cuda_kernel_launch]</summary>
        ObjectTypeCudaModuleNv = 1000307000,
        /// <summary>[requires: VK_NV_cuda_kernel_launch]</summary>
        ObjectTypeCudaFunctionNv = 1000307001,
        /// <summary>[requires: VK_FUCHSIA_buffer_collection]VkBufferCollectionFUCHSIA</summary>
        ObjectTypeBufferCollectionFuchsia = 1000366000,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        ObjectTypeMicromapExt = 1000396000,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        ObjectTypeOpticalFlowSessionNv = 1000464000,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        ObjectTypeShaderExt = 1000482000,
        /// <summary>[requires: VK_NV_external_sci_sync2]VkSemaphoreSciSyncPoolNV</summary>
        ObjectTypeSemaphoreSciSyncPoolNv = 1000489000,
        /// <summary>[requires: VK_KHR_descriptor_update_template]</summary>
        ObjectTypeDescriptorUpdateTemplateKhr = 1000085000,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        ObjectTypeSamplerYcbcrConversionKhr = 1000156000,
        /// <summary>[requires: VK_EXT_private_data]</summary>
        ObjectTypePrivateDataSlotExt = 1000295000,
    }
    public enum VkRayTracingInvocationReorderModeNV : int
    {
        RayTracingInvocationReorderModeNoneNv = 0,
        RayTracingInvocationReorderModeReorderNv = 1,
    }
    public enum VkDirectDriverLoadingModeLUNARG : int
    {
        DirectDriverLoadingModeExclusiveLunarg = 0,
        DirectDriverLoadingModeInclusiveLunarg = 1,
    }
    [Flags]
    public enum VkQueueFlagBits : int
    {
        /// <summary>Queue supports graphics operations</summary>
        QueueGraphicsBit = 1,
        /// <summary>Queue supports compute operations</summary>
        QueueComputeBit = 2,
        /// <summary>Queue supports transfer operations</summary>
        QueueTransferBit = 4,
        /// <summary>Queue supports sparse resource memory management operations</summary>
        QueueSparseBindingBit = 8,
        /// <summary>[requires: VK_VERSION_1_1]Queues may support protected operations</summary>
        QueueProtectedBit = 16,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        QueueVideoDecodeBitKhr = 32,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        QueueVideoEncodeBitKhr = 64,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        QueueOpticalFlowBitNv = 256,
    }
    [Flags]
    public enum VkCullModeFlagBits : int
    {
        CullModeNone = 0,
        CullModeFrontBit = 1,
        CullModeBackBit = 2,
        CullModeFrontAndBack = 3,
    }
    [Flags]
    public enum VkRenderPassCreateFlagBits : int
    {
        /// <summary>[requires: VK_QCOM_render_pass_transform]</summary>
        RenderPassCreateTransformBitQcom = 2,
    }
    [Flags]
    public enum VkDeviceQueueCreateFlagBits : int
    {
        /// <summary>[requires: VK_VERSION_1_1]Queue is a protected-capable device queue</summary>
        DeviceQueueCreateProtectedBit = 1,
    }
    [Flags]
    public enum VkMemoryPropertyFlagBits : int
    {
        /// <summary>If otherwise stated, then allocate memory on device</summary>
        MemoryPropertyDeviceLocalBit = 1,
        /// <summary>Memory is mappable by host</summary>
        MemoryPropertyHostVisibleBit = 2,
        /// <summary>Memory will have i/o coherency. If not set, application may need to use vkFlushMappedMemoryRanges and vkInvalidateMappedMemoryRanges to flush/invalidate host cache</summary>
        MemoryPropertyHostCoherentBit = 4,
        /// <summary>Memory will be cached by the host</summary>
        MemoryPropertyHostCachedBit = 8,
        /// <summary>Memory may be allocated by the driver when it is required</summary>
        MemoryPropertyLazilyAllocatedBit = 16,
        /// <summary>[requires: VK_VERSION_1_1]Memory is protected</summary>
        MemoryPropertyProtectedBit = 32,
        /// <summary>[requires: VK_AMD_device_coherent_memory]</summary>
        MemoryPropertyDeviceCoherentBitAmd = 64,
        /// <summary>[requires: VK_AMD_device_coherent_memory]</summary>
        MemoryPropertyDeviceUncachedBitAmd = 128,
        /// <summary>[requires: VK_NV_external_memory_rdma]</summary>
        MemoryPropertyRdmaCapableBitNv = 256,
    }
    [Flags]
    public enum VkMemoryHeapFlagBits : int
    {
        /// <summary>If set, heap represents device memory</summary>
        MemoryHeapDeviceLocalBit = 1,
        /// <summary>[requires: VK_VERSION_1_1]If set, heap allocations allocate multiple instances by default</summary>
        MemoryHeapMultiInstanceBit = 2,
        /// <summary>[requires: VK_KHR_device_group_creation]</summary>
        MemoryHeapMultiInstanceBitKhr = 2,
    }
    [Flags]
    public enum VkAccessFlagBits : int
    {
        /// <summary>Controls coherency of indirect command reads</summary>
        AccessIndirectCommandReadBit = 1,
        /// <summary>Controls coherency of index reads</summary>
        AccessIndexReadBit = 2,
        /// <summary>Controls coherency of vertex attribute reads</summary>
        AccessVertexAttributeReadBit = 4,
        /// <summary>Controls coherency of uniform buffer reads</summary>
        AccessUniformReadBit = 8,
        /// <summary>Controls coherency of input attachment reads</summary>
        AccessInputAttachmentReadBit = 16,
        /// <summary>Controls coherency of shader reads</summary>
        AccessShaderReadBit = 32,
        /// <summary>Controls coherency of shader writes</summary>
        AccessShaderWriteBit = 64,
        /// <summary>Controls coherency of color attachment reads</summary>
        AccessColorAttachmentReadBit = 128,
        /// <summary>Controls coherency of color attachment writes</summary>
        AccessColorAttachmentWriteBit = 256,
        /// <summary>Controls coherency of depth/stencil attachment reads</summary>
        AccessDepthStencilAttachmentReadBit = 512,
        /// <summary>Controls coherency of depth/stencil attachment writes</summary>
        AccessDepthStencilAttachmentWriteBit = 1024,
        /// <summary>Controls coherency of transfer reads</summary>
        AccessTransferReadBit = 2048,
        /// <summary>Controls coherency of transfer writes</summary>
        AccessTransferWriteBit = 4096,
        /// <summary>Controls coherency of host reads</summary>
        AccessHostReadBit = 8192,
        /// <summary>Controls coherency of host writes</summary>
        AccessHostWriteBit = 16384,
        /// <summary>Controls coherency of memory reads</summary>
        AccessMemoryReadBit = 32768,
        /// <summary>Controls coherency of memory writes</summary>
        AccessMemoryWriteBit = 65536,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        AccessNone = 0,
        /// <summary>[requires: VK_EXT_transform_feedback]</summary>
        AccessTransformFeedbackWriteBitExt = 33554432,
        /// <summary>[requires: VK_EXT_transform_feedback]</summary>
        AccessTransformFeedbackCounterReadBitExt = 67108864,
        /// <summary>[requires: VK_EXT_transform_feedback]</summary>
        AccessTransformFeedbackCounterWriteBitExt = 134217728,
        /// <summary>[requires: VK_EXT_conditional_rendering]read access flag for reading conditional rendering predicate</summary>
        AccessConditionalRenderingReadBitExt = 1048576,
        /// <summary>[requires: VK_EXT_blend_operation_advanced]</summary>
        AccessColorAttachmentReadNoncoherentBitExt = 524288,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        AccessAccelerationStructureReadBitKhr = 2097152,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        AccessAccelerationStructureWriteBitKhr = 4194304,
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        AccessFragmentDensityMapReadBitExt = 16777216,
        /// <summary>[requires: VK_KHR_fragment_shading_rate]</summary>
        AccessFragmentShadingRateAttachmentReadBitKhr = 8388608,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        AccessCommandPreprocessReadBitNv = 131072,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        AccessCommandPreprocessWriteBitNv = 262144,
        /// <summary>[requires: VK_NV_shading_rate_image]</summary>
        AccessShadingRateImageReadBitNv = 8388608,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        AccessAccelerationStructureReadBitNv = 2097152,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        AccessAccelerationStructureWriteBitNv = 4194304,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        AccessNoneKhr = 0,
    }
    [Flags]
    public enum VkBufferUsageFlagBits : int
    {
        /// <summary>Can be used as a source of transfer operations</summary>
        BufferUsageTransferSrcBit = 1,
        /// <summary>Can be used as a destination of transfer operations</summary>
        BufferUsageTransferDstBit = 2,
        /// <summary>Can be used as TBO</summary>
        BufferUsageUniformTexelBufferBit = 4,
        /// <summary>Can be used as IBO</summary>
        BufferUsageStorageTexelBufferBit = 8,
        /// <summary>Can be used as UBO</summary>
        BufferUsageUniformBufferBit = 16,
        /// <summary>Can be used as SSBO</summary>
        BufferUsageStorageBufferBit = 32,
        /// <summary>Can be used as source of fixed-function index fetch (index buffer)</summary>
        BufferUsageIndexBufferBit = 64,
        /// <summary>Can be used as source of fixed-function vertex fetch (VBO)</summary>
        BufferUsageVertexBufferBit = 128,
        /// <summary>Can be the source of indirect parameters (e.g. indirect buffer, parameter buffer)</summary>
        BufferUsageIndirectBufferBit = 256,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        BufferUsageShaderDeviceAddressBit = 131072,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        BufferUsageVideoDecodeSrcBitKhr = 8192,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        BufferUsageVideoDecodeDstBitKhr = 16384,
        /// <summary>[requires: VK_EXT_transform_feedback]</summary>
        BufferUsageTransformFeedbackBufferBitExt = 2048,
        /// <summary>[requires: VK_EXT_transform_feedback]</summary>
        BufferUsageTransformFeedbackCounterBufferBitExt = 4096,
        /// <summary>[requires: VK_EXT_conditional_rendering]Specifies the buffer can be used as predicate in conditional rendering</summary>
        BufferUsageConditionalRenderingBitExt = 512,
        /// <summary>[requires: VK_AMDX_shader_enqueue]</summary>
        BufferUsageExecutionGraphScratchBitAmdx = 33554432,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        BufferUsageAccelerationStructureBuildInputReadOnlyBitKhr = 524288,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        BufferUsageAccelerationStructureStorageBitKhr = 1048576,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        BufferUsageShaderBindingTableBitKhr = 1024,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        BufferUsageVideoEncodeDstBitKhr = 32768,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        BufferUsageVideoEncodeSrcBitKhr = 65536,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        BufferUsageSamplerDescriptorBufferBitExt = 2097152,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        BufferUsageResourceDescriptorBufferBitExt = 4194304,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        BufferUsagePushDescriptorsDescriptorBufferBitExt = 67108864,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        BufferUsageMicromapBuildInputReadOnlyBitExt = 8388608,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        BufferUsageMicromapStorageBitExt = 16777216,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        BufferUsageRayTracingBitNv = 1024,
        /// <summary>[requires: VK_EXT_buffer_device_address]</summary>
        BufferUsageShaderDeviceAddressBitExt = 131072,
        /// <summary>[requires: VK_KHR_buffer_device_address]</summary>
        BufferUsageShaderDeviceAddressBitKhr = 131072,
    }
    [Flags]
    public enum VkBufferUsageFlagBits2KHR : int
    {
        BufferUsage2TransferSrcBitKhr = 1,
        BufferUsage2TransferDstBitKhr = 2,
        BufferUsage2UniformTexelBufferBitKhr = 4,
        BufferUsage2StorageTexelBufferBitKhr = 8,
        BufferUsage2UniformBufferBitKhr = 16,
        BufferUsage2StorageBufferBitKhr = 32,
        BufferUsage2IndexBufferBitKhr = 64,
        BufferUsage2VertexBufferBitKhr = 128,
        BufferUsage2IndirectBufferBitKhr = 256,
        /// <summary>[requires: VK_AMDX_shader_enqueue]</summary>
        BufferUsage2ExecutionGraphScratchBitAmdx = 33554432,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2ConditionalRenderingBitExt = 512,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2ShaderBindingTableBitKhr = 1024,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2TransformFeedbackBufferBitExt = 2048,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2TransformFeedbackCounterBufferBitExt = 4096,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2VideoDecodeSrcBitKhr = 8192,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2VideoDecodeDstBitKhr = 16384,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2VideoEncodeDstBitKhr = 32768,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2VideoEncodeSrcBitKhr = 65536,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2ShaderDeviceAddressBitKhr = 131072,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2AccelerationStructureBuildInputReadOnlyBitKhr = 524288,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2AccelerationStructureStorageBitKhr = 1048576,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2SamplerDescriptorBufferBitExt = 2097152,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2ResourceDescriptorBufferBitExt = 4194304,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2PushDescriptorsDescriptorBufferBitExt = 67108864,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2MicromapBuildInputReadOnlyBitExt = 8388608,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2MicromapStorageBitExt = 16777216,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        BufferUsage2RayTracingBitNv = 1024,
    }
    [Flags]
    public enum VkBufferCreateFlagBits : int
    {
        /// <summary>Buffer should support sparse backing</summary>
        BufferCreateSparseBindingBit = 1,
        /// <summary>Buffer should support sparse backing with partial residency</summary>
        BufferCreateSparseResidencyBit = 2,
        /// <summary>Buffer should support constant data access to physical memory ranges mapped into multiple locations of sparse buffers</summary>
        BufferCreateSparseAliasedBit = 4,
        /// <summary>[requires: VK_VERSION_1_1]Buffer requires protected memory</summary>
        BufferCreateProtectedBit = 8,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        BufferCreateDeviceAddressCaptureReplayBit = 16,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        BufferCreateDescriptorBufferCaptureReplayBitExt = 32,
        /// <summary>[requires: VK_KHR_video_maintenance1]</summary>
        BufferCreateVideoProfileIndependentBitKhr = 64,
        /// <summary>[requires: VK_EXT_buffer_device_address]</summary>
        BufferCreateDeviceAddressCaptureReplayBitExt = 16,
        /// <summary>[requires: VK_KHR_buffer_device_address]</summary>
        BufferCreateDeviceAddressCaptureReplayBitKhr = 16,
    }
    [Flags]
    public enum VkShaderStageFlagBits : int
    {
        ShaderStageVertexBit = 1,
        ShaderStageTessellationControlBit = 2,
        ShaderStageTessellationEvaluationBit = 4,
        ShaderStageGeometryBit = 8,
        ShaderStageFragmentBit = 16,
        ShaderStageComputeBit = 32,
        ShaderStageAllGraphics = 31,
        ShaderStageAll = 2147483647,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        ShaderStageRaygenBitKhr = 256,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        ShaderStageAnyHitBitKhr = 512,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        ShaderStageClosestHitBitKhr = 1024,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        ShaderStageMissBitKhr = 2048,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        ShaderStageIntersectionBitKhr = 4096,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        ShaderStageCallableBitKhr = 8192,
        /// <summary>[requires: VK_EXT_mesh_shader]</summary>
        ShaderStageTaskBitExt = 64,
        /// <summary>[requires: VK_EXT_mesh_shader]</summary>
        ShaderStageMeshBitExt = 128,
        /// <summary>[requires: VK_HUAWEI_subpass_shading]</summary>
        ShaderStageSubpassShadingBitHuawei = 16384,
        /// <summary>[requires: VK_HUAWEI_cluster_culling_shader]</summary>
        ShaderStageClusterCullingBitHuawei = 524288,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        ShaderStageRaygenBitNv = 256,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        ShaderStageAnyHitBitNv = 512,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        ShaderStageClosestHitBitNv = 1024,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        ShaderStageMissBitNv = 2048,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        ShaderStageIntersectionBitNv = 4096,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        ShaderStageCallableBitNv = 8192,
        /// <summary>[requires: VK_NV_mesh_shader]</summary>
        ShaderStageTaskBitNv = 64,
        /// <summary>[requires: VK_NV_mesh_shader]</summary>
        ShaderStageMeshBitNv = 128,
    }
    [Flags]
    public enum VkImageUsageFlagBits : int
    {
        /// <summary>Can be used as a source of transfer operations</summary>
        ImageUsageTransferSrcBit = 1,
        /// <summary>Can be used as a destination of transfer operations</summary>
        ImageUsageTransferDstBit = 2,
        /// <summary>Can be sampled from (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)</summary>
        ImageUsageSampledBit = 4,
        /// <summary>Can be used as storage image (STORAGE_IMAGE descriptor type)</summary>
        ImageUsageStorageBit = 8,
        /// <summary>Can be used as framebuffer color attachment</summary>
        ImageUsageColorAttachmentBit = 16,
        /// <summary>Can be used as framebuffer depth/stencil attachment</summary>
        ImageUsageDepthStencilAttachmentBit = 32,
        /// <summary>Image data not needed outside of rendering</summary>
        ImageUsageTransientAttachmentBit = 64,
        /// <summary>Can be used as framebuffer input attachment</summary>
        ImageUsageInputAttachmentBit = 128,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        ImageUsageVideoDecodeDstBitKhr = 1024,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        ImageUsageVideoDecodeSrcBitKhr = 2048,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        ImageUsageVideoDecodeDpbBitKhr = 4096,
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        ImageUsageFragmentDensityMapBitExt = 512,
        /// <summary>[requires: VK_KHR_fragment_shading_rate]</summary>
        ImageUsageFragmentShadingRateAttachmentBitKhr = 256,
        /// <summary>[requires: VK_EXT_host_image_copy]Can be used with host image copies</summary>
        ImageUsageHostTransferBitExt = 4194304,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        ImageUsageVideoEncodeDstBitKhr = 8192,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        ImageUsageVideoEncodeSrcBitKhr = 16384,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        ImageUsageVideoEncodeDpbBitKhr = 32768,
        /// <summary>[requires: VK_EXT_attachment_feedback_loop_layout]</summary>
        ImageUsageAttachmentFeedbackLoopBitExt = 524288,
        /// <summary>[requires: VK_HUAWEI_invocation_mask]</summary>
        ImageUsageInvocationMaskBitHuawei = 262144,
        /// <summary>[requires: VK_QCOM_image_processing]</summary>
        ImageUsageSampleWeightBitQcom = 1048576,
        /// <summary>[requires: VK_QCOM_image_processing]</summary>
        ImageUsageSampleBlockMatchBitQcom = 2097152,
        /// <summary>[requires: VK_NV_shading_rate_image]</summary>
        ImageUsageShadingRateImageBitNv = 256,
    }
    [Flags]
    public enum VkImageCreateFlagBits : int
    {
        /// <summary>Image should support sparse backing</summary>
        ImageCreateSparseBindingBit = 1,
        /// <summary>Image should support sparse backing with partial residency</summary>
        ImageCreateSparseResidencyBit = 2,
        /// <summary>Image should support constant data access to physical memory ranges mapped into multiple locations of sparse images</summary>
        ImageCreateSparseAliasedBit = 4,
        /// <summary>Allows image views to have different format than the base image</summary>
        ImageCreateMutableFormatBit = 8,
        /// <summary>Allows creating image views with cube type from the created image</summary>
        ImageCreateCubeCompatibleBit = 16,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ImageCreateAliasBit = 1024,
        /// <summary>[requires: VK_VERSION_1_1]Allows using VkBindImageMemoryDeviceGroupInfo::pSplitInstanceBindRegions when binding memory to the image</summary>
        ImageCreateSplitInstanceBindRegionsBit = 64,
        /// <summary>[requires: VK_VERSION_1_1]The 3D image can be viewed as a 2D or 2D array image</summary>
        ImageCreate2dArrayCompatibleBit = 32,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ImageCreateBlockTexelViewCompatibleBit = 128,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ImageCreateExtendedUsageBit = 256,
        /// <summary>[requires: VK_VERSION_1_1]Image requires protected memory</summary>
        ImageCreateProtectedBit = 2048,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ImageCreateDisjointBit = 512,
        /// <summary>[requires: VK_NV_corner_sampled_image]</summary>
        ImageCreateCornerSampledBitNv = 8192,
        /// <summary>[requires: VK_EXT_sample_locations]</summary>
        ImageCreateSampleLocationsCompatibleDepthBitExt = 4096,
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        ImageCreateSubsampledBitExt = 16384,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        ImageCreateDescriptorBufferCaptureReplayBitExt = 65536,
        /// <summary>[requires: VK_EXT_multisampled_render_to_single_sampled]</summary>
        ImageCreateMultisampledRenderToSingleSampledBitExt = 262144,
        /// <summary>[requires: VK_EXT_image_2d_view_of_3d]Image is created with a layout where individual slices are capable of being used as 2D images</summary>
        ImageCreate2dViewCompatibleBitExt = 131072,
        /// <summary>[requires: VK_QCOM_fragment_density_map_offset]</summary>
        ImageCreateFragmentDensityMapOffsetBitQcom = 32768,
        /// <summary>[requires: VK_KHR_video_maintenance1]</summary>
        ImageCreateVideoProfileIndependentBitKhr = 1048576,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        ImageCreateSplitInstanceBindRegionsBitKhr = 64,
        /// <summary>[requires: VK_KHR_maintenance1]</summary>
        ImageCreate2dArrayCompatibleBitKhr = 32,
        /// <summary>[requires: VK_KHR_maintenance2]</summary>
        ImageCreateBlockTexelViewCompatibleBitKhr = 128,
        /// <summary>[requires: VK_KHR_maintenance2]</summary>
        ImageCreateExtendedUsageBitKhr = 256,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        ImageCreateDisjointBitKhr = 512,
        /// <summary>[requires: VK_KHR_bind_memory2]</summary>
        ImageCreateAliasBitKhr = 1024,
    }
    [Flags]
    public enum VkImageViewCreateFlagBits : int
    {
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        ImageViewCreateFragmentDensityMapDynamicBitExt = 1,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        ImageViewCreateDescriptorBufferCaptureReplayBitExt = 4,
        /// <summary>[requires: VK_EXT_fragment_density_map2]</summary>
        ImageViewCreateFragmentDensityMapDeferredBitExt = 2,
    }
    [Flags]
    public enum VkSamplerCreateFlagBits : int
    {
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        SamplerCreateSubsampledBitExt = 1,
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        SamplerCreateSubsampledCoarseReconstructionBitExt = 2,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        SamplerCreateDescriptorBufferCaptureReplayBitExt = 8,
        /// <summary>[requires: VK_EXT_non_seamless_cube_map]</summary>
        SamplerCreateNonSeamlessCubeMapBitExt = 4,
        /// <summary>[requires: VK_QCOM_image_processing]</summary>
        SamplerCreateImageProcessingBitQcom = 16,
    }
    [Flags]
    public enum VkPipelineCreateFlagBits : int
    {
        PipelineCreateDisableOptimizationBit = 1,
        PipelineCreateAllowDerivativesBit = 2,
        PipelineCreateDerivativeBit = 4,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        PipelineCreateViewIndexFromDeviceIndexBit = 8,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        PipelineCreateDispatchBaseBit = 16,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        PipelineCreateFailOnPipelineCompileRequiredBit = 256,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        PipelineCreateEarlyReturnOnFailureBit = 512,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        PipelineCreateDispatchBase = 16,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        PipelineCreateRenderingFragmentShadingRateAttachmentBitKhr = 2097152,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        PipelineCreateRenderingFragmentDensityMapAttachmentBitExt = 4194304,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        PipelineCreateRayTracingNoNullAnyHitShadersBitKhr = 16384,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        PipelineCreateRayTracingNoNullClosestHitShadersBitKhr = 32768,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        PipelineCreateRayTracingNoNullMissShadersBitKhr = 65536,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        PipelineCreateRayTracingNoNullIntersectionShadersBitKhr = 131072,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        PipelineCreateRayTracingSkipTrianglesBitKhr = 4096,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        PipelineCreateRayTracingSkipAabbsBitKhr = 8192,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        PipelineCreateRayTracingShaderGroupHandleCaptureReplayBitKhr = 524288,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        PipelineCreateDeferCompileBitNv = 32,
        /// <summary>[requires: VK_KHR_pipeline_executable_properties]</summary>
        PipelineCreateCaptureStatisticsBitKhr = 64,
        /// <summary>[requires: VK_KHR_pipeline_executable_properties]</summary>
        PipelineCreateCaptureInternalRepresentationsBitKhr = 128,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        PipelineCreateIndirectBindableBitNv = 262144,
        /// <summary>[requires: VK_KHR_pipeline_library]</summary>
        PipelineCreateLibraryBitKhr = 2048,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        PipelineCreateDescriptorBufferBitExt = 536870912,
        /// <summary>[requires: VK_EXT_graphics_pipeline_library]</summary>
        PipelineCreateRetainLinkTimeOptimizationInfoBitExt = 8388608,
        /// <summary>[requires: VK_EXT_graphics_pipeline_library]</summary>
        PipelineCreateLinkTimeOptimizationBitExt = 1024,
        /// <summary>[requires: VK_NV_ray_tracing_motion_blur]</summary>
        PipelineCreateRayTracingAllowMotionBitNv = 1048576,
        /// <summary>[requires: VK_EXT_attachment_feedback_loop_layout]</summary>
        PipelineCreateColorAttachmentFeedbackLoopBitExt = 33554432,
        /// <summary>[requires: VK_EXT_attachment_feedback_loop_layout]</summary>
        PipelineCreateDepthStencilAttachmentFeedbackLoopBitExt = 67108864,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        PipelineCreateRayTracingOpacityMicromapBitExt = 16777216,
        /// <summary>[requires: VK_NV_displacement_micromap]</summary>
        PipelineCreateRayTracingDisplacementMicromapBitNv = 268435456,
        /// <summary>[requires: VK_EXT_pipeline_protected_access]</summary>
        PipelineCreateNoProtectedAccessBitExt = 134217728,
        /// <summary>[requires: VK_EXT_pipeline_protected_access]</summary>
        PipelineCreateProtectedAccessOnlyBitExt = 1073741824,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        PipelineRasterizationStateCreateFragmentShadingRateAttachmentBitKhr = 2097152,
        /// <summary>[requires: VK_KHR_dynamic_rendering]</summary>
        PipelineRasterizationStateCreateFragmentDensityMapAttachmentBitExt = 4194304,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        PipelineCreateViewIndexFromDeviceIndexBitKhr = 8,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        PipelineCreateDispatchBaseKhr = 16,
        /// <summary>[requires: VK_EXT_pipeline_creation_cache_control]</summary>
        PipelineCreateFailOnPipelineCompileRequiredBitExt = 256,
        /// <summary>[requires: VK_EXT_pipeline_creation_cache_control]</summary>
        PipelineCreateEarlyReturnOnFailureBitExt = 512,
    }
    [Flags]
    public enum VkPipelineCreateFlagBits2KHR : int
    {
        PipelineCreate2DisableOptimizationBitKhr = 1,
        PipelineCreate2AllowDerivativesBitKhr = 2,
        PipelineCreate2DerivativeBitKhr = 4,
        /// <summary>[requires: VK_EXT_legacy_dithering]</summary>
        PipelineCreate2EnableLegacyDitheringBitExt = 4,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2ViewIndexFromDeviceIndexBitKhr = 8,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2DispatchBaseBitKhr = 16,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2DeferCompileBitNv = 32,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2CaptureStatisticsBitKhr = 64,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2CaptureInternalRepresentationsBitKhr = 128,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2FailOnPipelineCompileRequiredBitKhr = 256,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2EarlyReturnOnFailureBitKhr = 512,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2LinkTimeOptimizationBitExt = 1024,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RetainLinkTimeOptimizationInfoBitExt = 8388608,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2LibraryBitKhr = 2048,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RayTracingSkipTrianglesBitKhr = 4096,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RayTracingSkipAabbsBitKhr = 8192,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RayTracingNoNullAnyHitShadersBitKhr = 16384,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RayTracingNoNullClosestHitShadersBitKhr = 32768,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RayTracingNoNullMissShadersBitKhr = 65536,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RayTracingNoNullIntersectionShadersBitKhr = 131072,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RayTracingShaderGroupHandleCaptureReplayBitKhr = 524288,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2IndirectBindableBitNv = 262144,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RayTracingAllowMotionBitNv = 1048576,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RenderingFragmentShadingRateAttachmentBitKhr = 2097152,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RenderingFragmentDensityMapAttachmentBitExt = 4194304,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RayTracingOpacityMicromapBitExt = 16777216,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2ColorAttachmentFeedbackLoopBitExt = 33554432,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2DepthStencilAttachmentFeedbackLoopBitExt = 67108864,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2NoProtectedAccessBitExt = 134217728,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2ProtectedAccessOnlyBitExt = 1073741824,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2RayTracingDisplacementMicromapBitNv = 268435456,
        /// <summary>[requires: VK_KHR_maintenance5]</summary>
        PipelineCreate2DescriptorBufferBitExt = 536870912,
    }
    [Flags]
    public enum VkPipelineShaderStageCreateFlagBits : int
    {
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        PipelineShaderStageCreateAllowVaryingSubgroupSizeBit = 1,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        PipelineShaderStageCreateRequireFullSubgroupsBit = 2,
        /// <summary>[requires: VK_EXT_subgroup_size_control]</summary>
        PipelineShaderStageCreateAllowVaryingSubgroupSizeBitExt = 1,
        /// <summary>[requires: VK_EXT_subgroup_size_control]</summary>
        PipelineShaderStageCreateRequireFullSubgroupsBitExt = 2,
    }
    [Flags]
    public enum VkColorComponentFlagBits : int
    {
        ColorComponentRBit = 1,
        ColorComponentGBit = 2,
        ColorComponentBBit = 4,
        ColorComponentABit = 8,
    }
    [Flags]
    public enum VkFenceCreateFlagBits : int
    {
        FenceCreateSignaledBit = 1,
    }
    [Flags]
    public enum VkSemaphoreCreateFlagBits : int
    {
    }
    [Flags]
    public enum VkFormatFeatureFlagBits : int
    {
        /// <summary>Format can be used for sampled images (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)</summary>
        FormatFeatureSampledImageBit = 1,
        /// <summary>Format can be used for storage images (STORAGE_IMAGE descriptor type)</summary>
        FormatFeatureStorageImageBit = 2,
        /// <summary>Format supports atomic operations in case it is used for storage images</summary>
        FormatFeatureStorageImageAtomicBit = 4,
        /// <summary>Format can be used for uniform texel buffers (TBOs)</summary>
        FormatFeatureUniformTexelBufferBit = 8,
        /// <summary>Format can be used for storage texel buffers (IBOs)</summary>
        FormatFeatureStorageTexelBufferBit = 16,
        /// <summary>Format supports atomic operations in case it is used for storage texel buffers</summary>
        FormatFeatureStorageTexelBufferAtomicBit = 32,
        /// <summary>Format can be used for vertex buffers (VBOs)</summary>
        FormatFeatureVertexBufferBit = 64,
        /// <summary>Format can be used for color attachment images</summary>
        FormatFeatureColorAttachmentBit = 128,
        /// <summary>Format supports blending in case it is used for color attachment images</summary>
        FormatFeatureColorAttachmentBlendBit = 256,
        /// <summary>Format can be used for depth/stencil attachment images</summary>
        FormatFeatureDepthStencilAttachmentBit = 512,
        /// <summary>Format can be used as the source image of blits with vkCmdBlitImage</summary>
        FormatFeatureBlitSrcBit = 1024,
        /// <summary>Format can be used as the destination image of blits with vkCmdBlitImage</summary>
        FormatFeatureBlitDstBit = 2048,
        /// <summary>Format can be filtered with VK_FILTER_LINEAR when being sampled</summary>
        FormatFeatureSampledImageFilterLinearBit = 4096,
        /// <summary>[requires: VK_VERSION_1_1]Format can be used as the source image of image transfer commands</summary>
        FormatFeatureTransferSrcBit = 16384,
        /// <summary>[requires: VK_VERSION_1_1]Format can be used as the destination image of image transfer commands</summary>
        FormatFeatureTransferDstBit = 32768,
        /// <summary>[requires: VK_VERSION_1_1]Format can have midpoint rather than cosited chroma samples</summary>
        FormatFeatureMidpointChromaSamplesBit = 131072,
        /// <summary>[requires: VK_VERSION_1_1]Format can be used with linear filtering whilst color conversion is enabled</summary>
        FormatFeatureSampledImageYcbcrConversionLinearFilterBit = 262144,
        /// <summary>[requires: VK_VERSION_1_1]Format can have different chroma, min and mag filters</summary>
        FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBit = 524288,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBit = 1048576,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 2097152,
        /// <summary>[requires: VK_VERSION_1_1]Format supports disjoint planes</summary>
        FormatFeatureDisjointBit = 4194304,
        /// <summary>[requires: VK_VERSION_1_1]Format can have cosited rather than midpoint chroma samples</summary>
        FormatFeatureCositedChromaSamplesBit = 8388608,
        /// <summary>[requires: VK_VERSION_1_2]Format can be used with min/max reduction filtering</summary>
        FormatFeatureSampledImageFilterMinmaxBit = 65536,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        FormatFeatureVideoDecodeOutputBitKhr = 33554432,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        FormatFeatureVideoDecodeDpbBitKhr = 67108864,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        FormatFeatureAccelerationStructureVertexBufferBitKhr = 536870912,
        /// <summary>[requires: VK_EXT_filter_cubic]</summary>
        FormatFeatureSampledImageFilterCubicBitExt = 8192,
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        FormatFeatureFragmentDensityMapBitExt = 16777216,
        /// <summary>[requires: VK_KHR_fragment_shading_rate]</summary>
        FormatFeatureFragmentShadingRateAttachmentBitKhr = 1073741824,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        FormatFeatureVideoEncodeInputBitKhr = 134217728,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        FormatFeatureVideoEncodeDpbBitKhr = 268435456,
        /// <summary>[requires: VK_IMG_filter_cubic]Format can be filtered with VK_FILTER_CUBIC_IMG when being sampled</summary>
        FormatFeatureSampledImageFilterCubicBitImg = 8192,
        /// <summary>[requires: VK_KHR_maintenance1]</summary>
        FormatFeatureTransferSrcBitKhr = 16384,
        /// <summary>[requires: VK_KHR_maintenance1]</summary>
        FormatFeatureTransferDstBitKhr = 32768,
        /// <summary>[requires: VK_EXT_sampler_filter_minmax]</summary>
        FormatFeatureSampledImageFilterMinmaxBitExt = 65536,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatFeatureMidpointChromaSamplesBitKhr = 131072,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatFeatureSampledImageYcbcrConversionLinearFilterBitKhr = 262144,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatFeatureSampledImageYcbcrConversionSeparateReconstructionFilterBitKhr = 524288,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitBitKhr = 1048576,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatFeatureSampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr = 2097152,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatFeatureDisjointBitKhr = 4194304,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        FormatFeatureCositedChromaSamplesBitKhr = 8388608,
    }
    [Flags]
    public enum VkQueryControlFlagBits : int
    {
        /// <summary>Require precise results to be collected by the query</summary>
        QueryControlPreciseBit = 1,
    }
    [Flags]
    public enum VkQueryResultFlagBits : int
    {
        /// <summary>Results of the queries are written to the destination buffer as 64-bit values</summary>
        QueryResult64Bit = 1,
        /// <summary>Results of the queries are waited on before proceeding with the result copy</summary>
        QueryResultWaitBit = 2,
        /// <summary>Besides the results of the query, the availability of the results is also written</summary>
        QueryResultWithAvailabilityBit = 4,
        /// <summary>Copy the partial results of the query even if the final results are not available</summary>
        QueryResultPartialBit = 8,
        /// <summary>[requires: VK_KHR_video_queue]</summary>
        QueryResultWithStatusBitKhr = 16,
    }
    [Flags]
    public enum VkCommandBufferUsageFlagBits : int
    {
        CommandBufferUsageOneTimeSubmitBit = 1,
        CommandBufferUsageRenderPassContinueBit = 2,
        /// <summary>Command buffer may be submitted/executed more than once simultaneously</summary>
        CommandBufferUsageSimultaneousUseBit = 4,
    }
    [Flags]
    public enum VkQueryPipelineStatisticFlagBits : int
    {
        /// <summary>Optional</summary>
        QueryPipelineStatisticInputAssemblyVerticesBit = 1,
        /// <summary>Optional</summary>
        QueryPipelineStatisticInputAssemblyPrimitivesBit = 2,
        /// <summary>Optional</summary>
        QueryPipelineStatisticVertexShaderInvocationsBit = 4,
        /// <summary>Optional</summary>
        QueryPipelineStatisticGeometryShaderInvocationsBit = 8,
        /// <summary>Optional</summary>
        QueryPipelineStatisticGeometryShaderPrimitivesBit = 16,
        /// <summary>Optional</summary>
        QueryPipelineStatisticClippingInvocationsBit = 32,
        /// <summary>Optional</summary>
        QueryPipelineStatisticClippingPrimitivesBit = 64,
        /// <summary>Optional</summary>
        QueryPipelineStatisticFragmentShaderInvocationsBit = 128,
        /// <summary>Optional</summary>
        QueryPipelineStatisticTessellationControlShaderPatchesBit = 256,
        /// <summary>Optional</summary>
        QueryPipelineStatisticTessellationEvaluationShaderInvocationsBit = 512,
        /// <summary>Optional</summary>
        QueryPipelineStatisticComputeShaderInvocationsBit = 1024,
        /// <summary>[requires: VK_EXT_mesh_shader]</summary>
        QueryPipelineStatisticTaskShaderInvocationsBitExt = 2048,
        /// <summary>[requires: VK_EXT_mesh_shader]</summary>
        QueryPipelineStatisticMeshShaderInvocationsBitExt = 4096,
        /// <summary>[requires: VK_HUAWEI_cluster_culling_shader]</summary>
        QueryPipelineStatisticClusterCullingShaderInvocationsBitHuawei = 8192,
    }
    [Flags]
    public enum VkMemoryMapFlagBits : int
    {
        /// <summary>[requires: VK_EXT_map_memory_placed]</summary>
        MemoryMapPlacedBitExt = 1,
    }
    [Flags]
    public enum VkImageAspectFlagBits : int
    {
        ImageAspectColorBit = 1,
        ImageAspectDepthBit = 2,
        ImageAspectStencilBit = 4,
        ImageAspectMetadataBit = 8,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ImageAspectPlane0Bit = 16,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ImageAspectPlane1Bit = 32,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        ImageAspectPlane2Bit = 64,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        ImageAspectNone = 0,
        /// <summary>[requires: VK_EXT_image_drm_format_modifier]</summary>
        ImageAspectMemoryPlane0BitExt = 128,
        /// <summary>[requires: VK_EXT_image_drm_format_modifier]</summary>
        ImageAspectMemoryPlane1BitExt = 256,
        /// <summary>[requires: VK_EXT_image_drm_format_modifier]</summary>
        ImageAspectMemoryPlane2BitExt = 512,
        /// <summary>[requires: VK_EXT_image_drm_format_modifier]</summary>
        ImageAspectMemoryPlane3BitExt = 1024,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        ImageAspectPlane0BitKhr = 16,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        ImageAspectPlane1BitKhr = 32,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        ImageAspectPlane2BitKhr = 64,
        /// <summary>[requires: VK_KHR_maintenance4]</summary>
        ImageAspectNoneKhr = 0,
    }
    [Flags]
    public enum VkSparseImageFormatFlagBits : int
    {
        /// <summary>Image uses a single mip tail region for all array layers</summary>
        SparseImageFormatSingleMiptailBit = 1,
        /// <summary>Image requires mip level dimensions to be an integer multiple of the sparse image block dimensions for non-tail mip levels.</summary>
        SparseImageFormatAlignedMipSizeBit = 2,
        /// <summary>Image uses a non-standard sparse image block dimensions</summary>
        SparseImageFormatNonstandardBlockSizeBit = 4,
    }
    [Flags]
    public enum VkSparseMemoryBindFlagBits : int
    {
        /// <summary>Operation binds resource metadata to memory</summary>
        SparseMemoryBindMetadataBit = 1,
    }
    [Flags]
    public enum VkPipelineStageFlagBits : int
    {
        /// <summary>Before subsequent commands are processed</summary>
        PipelineStageTopOfPipeBit = 1,
        /// <summary>Draw/DispatchIndirect command fetch</summary>
        PipelineStageDrawIndirectBit = 2,
        /// <summary>Vertex/index fetch</summary>
        PipelineStageVertexInputBit = 4,
        /// <summary>Vertex shading</summary>
        PipelineStageVertexShaderBit = 8,
        /// <summary>Tessellation control shading</summary>
        PipelineStageTessellationControlShaderBit = 16,
        /// <summary>Tessellation evaluation shading</summary>
        PipelineStageTessellationEvaluationShaderBit = 32,
        /// <summary>Geometry shading</summary>
        PipelineStageGeometryShaderBit = 64,
        /// <summary>Fragment shading</summary>
        PipelineStageFragmentShaderBit = 128,
        /// <summary>Early fragment (depth and stencil) tests</summary>
        PipelineStageEarlyFragmentTestsBit = 256,
        /// <summary>Late fragment (depth and stencil) tests</summary>
        PipelineStageLateFragmentTestsBit = 512,
        /// <summary>Color attachment writes</summary>
        PipelineStageColorAttachmentOutputBit = 1024,
        /// <summary>Compute shading</summary>
        PipelineStageComputeShaderBit = 2048,
        /// <summary>Transfer/copy operations</summary>
        PipelineStageTransferBit = 4096,
        /// <summary>After previous commands have completed</summary>
        PipelineStageBottomOfPipeBit = 8192,
        /// <summary>Indicates host (CPU) is a source/sink of the dependency</summary>
        PipelineStageHostBit = 16384,
        /// <summary>All stages of the graphics pipeline</summary>
        PipelineStageAllGraphicsBit = 32768,
        /// <summary>All stages supported on the queue</summary>
        PipelineStageAllCommandsBit = 65536,
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        PipelineStageNone = 0,
        /// <summary>[requires: VK_EXT_transform_feedback]</summary>
        PipelineStageTransformFeedbackBitExt = 16777216,
        /// <summary>[requires: VK_EXT_conditional_rendering]A pipeline stage for conditional rendering predicate fetch</summary>
        PipelineStageConditionalRenderingBitExt = 262144,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        PipelineStageAccelerationStructureBuildBitKhr = 33554432,
        /// <summary>[requires: VK_KHR_ray_tracing_pipeline]</summary>
        PipelineStageRayTracingShaderBitKhr = 2097152,
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        PipelineStageFragmentDensityProcessBitExt = 8388608,
        /// <summary>[requires: VK_KHR_fragment_shading_rate]</summary>
        PipelineStageFragmentShadingRateAttachmentBitKhr = 4194304,
        /// <summary>[requires: VK_NV_device_generated_commands]</summary>
        PipelineStageCommandPreprocessBitNv = 131072,
        /// <summary>[requires: VK_EXT_mesh_shader]</summary>
        PipelineStageTaskShaderBitExt = 524288,
        /// <summary>[requires: VK_EXT_mesh_shader]</summary>
        PipelineStageMeshShaderBitExt = 1048576,
        /// <summary>[requires: VK_NV_shading_rate_image]</summary>
        PipelineStageShadingRateImageBitNv = 4194304,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        PipelineStageRayTracingShaderBitNv = 2097152,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        PipelineStageAccelerationStructureBuildBitNv = 33554432,
        /// <summary>[requires: VK_NV_mesh_shader]</summary>
        PipelineStageTaskShaderBitNv = 524288,
        /// <summary>[requires: VK_NV_mesh_shader]</summary>
        PipelineStageMeshShaderBitNv = 1048576,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStageNoneKhr = 0,
    }
    [Flags]
    public enum VkCommandPoolCreateFlagBits : int
    {
        /// <summary>Command buffers have a short lifetime</summary>
        CommandPoolCreateTransientBit = 1,
        /// <summary>Command buffers may release their memory individually</summary>
        CommandPoolCreateResetCommandBufferBit = 2,
        /// <summary>[requires: VK_VERSION_1_1]Command buffers allocated from pool are protected command buffers</summary>
        CommandPoolCreateProtectedBit = 4,
    }
    [Flags]
    public enum VkCommandPoolResetFlagBits : int
    {
        /// <summary>Release resources owned by the pool</summary>
        CommandPoolResetReleaseResourcesBit = 1,
    }
    [Flags]
    public enum VkCommandBufferResetFlagBits : int
    {
        /// <summary>Release resources owned by the buffer</summary>
        CommandBufferResetReleaseResourcesBit = 1,
    }
    [Flags]
    public enum VkSampleCountFlagBits : int
    {
        /// <summary>Sample count 1 supported</summary>
        SampleCount1Bit = 1,
        /// <summary>Sample count 2 supported</summary>
        SampleCount2Bit = 2,
        /// <summary>Sample count 4 supported</summary>
        SampleCount4Bit = 4,
        /// <summary>Sample count 8 supported</summary>
        SampleCount8Bit = 8,
        /// <summary>Sample count 16 supported</summary>
        SampleCount16Bit = 16,
        /// <summary>Sample count 32 supported</summary>
        SampleCount32Bit = 32,
        /// <summary>Sample count 64 supported</summary>
        SampleCount64Bit = 64,
    }
    [Flags]
    public enum VkAttachmentDescriptionFlagBits : int
    {
        /// <summary>The attachment may alias physical memory of another attachment in the same render pass</summary>
        AttachmentDescriptionMayAliasBit = 1,
    }
    [Flags]
    public enum VkStencilFaceFlagBits : int
    {
        /// <summary>Front face</summary>
        StencilFaceFrontBit = 1,
        /// <summary>Back face</summary>
        StencilFaceBackBit = 2,
        /// <summary>Front and back faces</summary>
        StencilFaceFrontAndBack = 3,
        /// <summary>Front and back faces</summary>
        StencilFrontAndBack = 3,
    }
    [Flags]
    public enum VkDescriptorPoolCreateFlagBits : int
    {
        /// <summary>Descriptor sets may be freed individually</summary>
        DescriptorPoolCreateFreeDescriptorSetBit = 1,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        DescriptorPoolCreateUpdateAfterBindBit = 2,
        /// <summary>[requires: VK_EXT_mutable_descriptor_type]</summary>
        DescriptorPoolCreateHostOnlyBitExt = 4,
        /// <summary>[requires: VK_NV_descriptor_pool_overallocation]</summary>
        DescriptorPoolCreateAllowOverallocationSetsBitNv = 8,
        /// <summary>[requires: VK_NV_descriptor_pool_overallocation]</summary>
        DescriptorPoolCreateAllowOverallocationPoolsBitNv = 16,
        /// <summary>[requires: VK_EXT_descriptor_indexing]</summary>
        DescriptorPoolCreateUpdateAfterBindBitExt = 2,
        /// <summary>[requires: VK_VALVE_mutable_descriptor_type]</summary>
        DescriptorPoolCreateHostOnlyBitValve = 4,
    }
    [Flags]
    public enum VkDependencyFlagBits : int
    {
        /// <summary>Dependency is per pixel region </summary>
        DependencyByRegionBit = 1,
        /// <summary>[requires: VK_VERSION_1_1]Dependency is across devices</summary>
        DependencyDeviceGroupBit = 4,
        /// <summary>[requires: VK_VERSION_1_1]</summary>
        DependencyViewLocalBit = 2,
        /// <summary>[requires: VK_EXT_attachment_feedback_loop_layout]Dependency may be a feedback loop</summary>
        DependencyFeedbackLoopBitExt = 8,
        /// <summary>[requires: VK_KHR_multiview]</summary>
        DependencyViewLocalBitKhr = 2,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        DependencyDeviceGroupBitKhr = 4,
    }
    public enum VkSemaphoreType : int
    {
        SemaphoreTypeBinary = 0,
        SemaphoreTypeTimeline = 1,
        /// <summary>[requires: VK_KHR_timeline_semaphore]</summary>
        SemaphoreTypeBinaryKhr = 0,
        /// <summary>[requires: VK_KHR_timeline_semaphore]</summary>
        SemaphoreTypeTimelineKhr = 1,
    }
    [Flags]
    public enum VkSemaphoreWaitFlagBits : int
    {
        SemaphoreWaitAnyBit = 1,
        /// <summary>[requires: VK_KHR_timeline_semaphore]</summary>
        SemaphoreWaitAnyBitKhr = 1,
    }
    public enum VkPresentModeKHR : int
    {
        PresentModeImmediateKhr = 0,
        PresentModeMailboxKhr = 1,
        PresentModeFifoKhr = 2,
        PresentModeFifoRelaxedKhr = 3,
        /// <summary>[requires: VK_KHR_shared_presentable_image]</summary>
        PresentModeSharedDemandRefreshKhr = 1000111000,
        /// <summary>[requires: VK_KHR_shared_presentable_image]</summary>
        PresentModeSharedContinuousRefreshKhr = 1000111001,
    }
    public enum VkColorSpaceKHR : int
    {
        ColorSpaceSrgbNonlinearKhr = 0,
        ColorspaceSrgbNonlinearKhr = 0,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceDisplayP3NonlinearExt = 1000104001,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceExtendedSrgbLinearExt = 1000104002,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceDisplayP3LinearExt = 1000104003,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceDciP3NonlinearExt = 1000104004,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceBt709LinearExt = 1000104005,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceBt709NonlinearExt = 1000104006,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceBt2020LinearExt = 1000104007,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceHdr10St2084Ext = 1000104008,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceDolbyvisionExt = 1000104009,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceHdr10HlgExt = 1000104010,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceAdobergbLinearExt = 1000104011,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceAdobergbNonlinearExt = 1000104012,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpacePassThroughExt = 1000104013,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceExtendedSrgbNonlinearExt = 1000104014,
        /// <summary>[requires: VK_AMD_display_native_hdr]</summary>
        ColorSpaceDisplayNativeAmd = 1000213000,
        /// <summary>[requires: VK_EXT_swapchain_colorspace]</summary>
        ColorSpaceDciP3LinearExt = 1000104003,
    }
    [Flags]
    public enum VkDisplayPlaneAlphaFlagBitsKHR : int
    {
        DisplayPlaneAlphaOpaqueBitKhr = 1,
        DisplayPlaneAlphaGlobalBitKhr = 2,
        DisplayPlaneAlphaPerPixelBitKhr = 4,
        DisplayPlaneAlphaPerPixelPremultipliedBitKhr = 8,
    }
    [Flags]
    public enum VkCompositeAlphaFlagBitsKHR : int
    {
        CompositeAlphaOpaqueBitKhr = 1,
        CompositeAlphaPreMultipliedBitKhr = 2,
        CompositeAlphaPostMultipliedBitKhr = 4,
        CompositeAlphaInheritBitKhr = 8,
    }
    [Flags]
    public enum VkSurfaceTransformFlagBitsKHR : int
    {
        SurfaceTransformIdentityBitKhr = 1,
        SurfaceTransformRotate90BitKhr = 2,
        SurfaceTransformRotate180BitKhr = 4,
        SurfaceTransformRotate270BitKhr = 8,
        SurfaceTransformHorizontalMirrorBitKhr = 16,
        SurfaceTransformHorizontalMirrorRotate90BitKhr = 32,
        SurfaceTransformHorizontalMirrorRotate180BitKhr = 64,
        SurfaceTransformHorizontalMirrorRotate270BitKhr = 128,
        SurfaceTransformInheritBitKhr = 256,
    }
    [Flags]
    public enum VkSwapchainImageUsageFlagBitsANDROID : int
    {
        SwapchainImageUsageSharedBitAndroid = 1,
    }
    public enum VkTimeDomainKHR : int
    {
        TimeDomainDeviceKhr = 0,
        TimeDomainClockMonotonicKhr = 1,
        TimeDomainClockMonotonicRawKhr = 2,
        TimeDomainQueryPerformanceCounterKhr = 3,
        /// <summary>[requires: VK_EXT_calibrated_timestamps]</summary>
        TimeDomainDeviceExt = 0,
        /// <summary>[requires: VK_EXT_calibrated_timestamps]</summary>
        TimeDomainClockMonotonicExt = 1,
        /// <summary>[requires: VK_EXT_calibrated_timestamps]</summary>
        TimeDomainClockMonotonicRawExt = 2,
        /// <summary>[requires: VK_EXT_calibrated_timestamps]</summary>
        TimeDomainQueryPerformanceCounterExt = 3,
    }
    [Flags]
    public enum VkDebugReportFlagBitsEXT : int
    {
        DebugReportInformationBitExt = 1,
        DebugReportWarningBitExt = 2,
        DebugReportPerformanceWarningBitExt = 4,
        DebugReportErrorBitExt = 8,
        DebugReportDebugBitExt = 16,
    }
    public enum VkDebugReportObjectTypeEXT : int
    {
        DebugReportObjectTypeUnknownExt = 0,
        DebugReportObjectTypeInstanceExt = 1,
        DebugReportObjectTypePhysicalDeviceExt = 2,
        DebugReportObjectTypeDeviceExt = 3,
        DebugReportObjectTypeQueueExt = 4,
        DebugReportObjectTypeSemaphoreExt = 5,
        DebugReportObjectTypeCommandBufferExt = 6,
        DebugReportObjectTypeFenceExt = 7,
        DebugReportObjectTypeDeviceMemoryExt = 8,
        DebugReportObjectTypeBufferExt = 9,
        DebugReportObjectTypeImageExt = 10,
        DebugReportObjectTypeEventExt = 11,
        DebugReportObjectTypeQueryPoolExt = 12,
        DebugReportObjectTypeBufferViewExt = 13,
        DebugReportObjectTypeImageViewExt = 14,
        DebugReportObjectTypeShaderModuleExt = 15,
        DebugReportObjectTypePipelineCacheExt = 16,
        DebugReportObjectTypePipelineLayoutExt = 17,
        DebugReportObjectTypeRenderPassExt = 18,
        DebugReportObjectTypePipelineExt = 19,
        DebugReportObjectTypeDescriptorSetLayoutExt = 20,
        DebugReportObjectTypeSamplerExt = 21,
        DebugReportObjectTypeDescriptorPoolExt = 22,
        DebugReportObjectTypeDescriptorSetExt = 23,
        DebugReportObjectTypeFramebufferExt = 24,
        DebugReportObjectTypeCommandPoolExt = 25,
        DebugReportObjectTypeSurfaceKhrExt = 26,
        DebugReportObjectTypeSwapchainKhrExt = 27,
        DebugReportObjectTypeDebugReportCallbackExtExt = 28,
        DebugReportObjectTypeDebugReportExt = 28,
        DebugReportObjectTypeDisplayKhrExt = 29,
        DebugReportObjectTypeDisplayModeKhrExt = 30,
        DebugReportObjectTypeValidationCacheExtExt = 33,
        DebugReportObjectTypeValidationCacheExt = 33,
        /// <summary>[requires: VK_EXT_debug_report]</summary>
        DebugReportObjectTypeSamplerYcbcrConversionExt = 1000156000,
        /// <summary>[requires: VK_EXT_debug_report]</summary>
        DebugReportObjectTypeDescriptorUpdateTemplateExt = 1000085000,
        /// <summary>[requires: VK_NVX_binary_import]</summary>
        DebugReportObjectTypeCuModuleNvxExt = 1000029000,
        /// <summary>[requires: VK_NVX_binary_import]</summary>
        DebugReportObjectTypeCuFunctionNvxExt = 1000029001,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        DebugReportObjectTypeAccelerationStructureKhrExt = 1000150000,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        DebugReportObjectTypeAccelerationStructureNvExt = 1000165000,
        /// <summary>[requires: VK_NV_cuda_kernel_launch]</summary>
        DebugReportObjectTypeCudaModuleNvExt = 1000307000,
        /// <summary>[requires: VK_NV_cuda_kernel_launch]</summary>
        DebugReportObjectTypeCudaFunctionNvExt = 1000307001,
        /// <summary>[requires: VK_FUCHSIA_buffer_collection]</summary>
        DebugReportObjectTypeBufferCollectionFuchsiaExt = 1000366000,
        /// <summary>[requires: VK_KHR_descriptor_update_template]</summary>
        DebugReportObjectTypeDescriptorUpdateTemplateKhrExt = 1000085000,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        DebugReportObjectTypeSamplerYcbcrConversionKhrExt = 1000156000,
    }
    public enum VkDeviceMemoryReportEventTypeEXT : int
    {
        DeviceMemoryReportEventTypeAllocateExt = 0,
        DeviceMemoryReportEventTypeFreeExt = 1,
        DeviceMemoryReportEventTypeImportExt = 2,
        DeviceMemoryReportEventTypeUnimportExt = 3,
        DeviceMemoryReportEventTypeAllocationFailedExt = 4,
    }
    public enum VkRasterizationOrderAMD : int
    {
        RasterizationOrderStrictAmd = 0,
        RasterizationOrderRelaxedAmd = 1,
    }
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagBitsNV : int
    {
        ExternalMemoryHandleTypeOpaqueWin32BitNv = 1,
        ExternalMemoryHandleTypeOpaqueWin32KmtBitNv = 2,
        ExternalMemoryHandleTypeD3d11ImageBitNv = 4,
        ExternalMemoryHandleTypeD3d11ImageKmtBitNv = 8,
    }
    [Flags]
    public enum VkExternalMemoryFeatureFlagBitsNV : int
    {
        ExternalMemoryFeatureDedicatedOnlyBitNv = 1,
        ExternalMemoryFeatureExportableBitNv = 2,
        ExternalMemoryFeatureImportableBitNv = 4,
    }
    public enum VkValidationCheckEXT : int
    {
        ValidationCheckAllExt = 0,
        ValidationCheckShadersExt = 1,
    }
    public enum VkValidationFeatureEnableEXT : int
    {
        ValidationFeatureEnableGpuAssistedExt = 0,
        ValidationFeatureEnableGpuAssistedReserveBindingSlotExt = 1,
        ValidationFeatureEnableBestPracticesExt = 2,
        ValidationFeatureEnableDebugPrintfExt = 3,
        ValidationFeatureEnableSynchronizationValidationExt = 4,
    }
    public enum VkValidationFeatureDisableEXT : int
    {
        ValidationFeatureDisableAllExt = 0,
        ValidationFeatureDisableShadersExt = 1,
        ValidationFeatureDisableThreadSafetyExt = 2,
        ValidationFeatureDisableApiParametersExt = 3,
        ValidationFeatureDisableObjectLifetimesExt = 4,
        ValidationFeatureDisableCoreChecksExt = 5,
        ValidationFeatureDisableUniqueHandlesExt = 6,
        ValidationFeatureDisableShaderValidationCacheExt = 7,
    }
    public enum VkLayerSettingTypeEXT : int
    {
        LayerSettingTypeBool32Ext = 0,
        LayerSettingTypeInt32Ext = 1,
        LayerSettingTypeInt64Ext = 2,
        LayerSettingTypeUint32Ext = 3,
        LayerSettingTypeUint64Ext = 4,
        LayerSettingTypeFloat32Ext = 5,
        LayerSettingTypeFloat64Ext = 6,
        LayerSettingTypeStringExt = 7,
    }
    [Flags]
    public enum VkSubgroupFeatureFlagBits : int
    {
        /// <summary>Basic subgroup operations</summary>
        SubgroupFeatureBasicBit = 1,
        /// <summary>Vote subgroup operations</summary>
        SubgroupFeatureVoteBit = 2,
        /// <summary>Arithmetic subgroup operations</summary>
        SubgroupFeatureArithmeticBit = 4,
        /// <summary>Ballot subgroup operations</summary>
        SubgroupFeatureBallotBit = 8,
        /// <summary>Shuffle subgroup operations</summary>
        SubgroupFeatureShuffleBit = 16,
        /// <summary>Shuffle relative subgroup operations</summary>
        SubgroupFeatureShuffleRelativeBit = 32,
        /// <summary>Clustered subgroup operations</summary>
        SubgroupFeatureClusteredBit = 64,
        /// <summary>Quad subgroup operations</summary>
        SubgroupFeatureQuadBit = 128,
        /// <summary>[requires: VK_NV_shader_subgroup_partitioned]</summary>
        SubgroupFeaturePartitionedBitNv = 256,
        /// <summary>[requires: VK_KHR_shader_subgroup_rotate]</summary>
        SubgroupFeatureRotateBitKhr = 512,
        /// <summary>[requires: VK_KHR_shader_subgroup_rotate]</summary>
        SubgroupFeatureRotateClusteredBitKhr = 1024,
    }
    [Flags]
    public enum VkIndirectCommandsLayoutUsageFlagBitsNV : int
    {
        IndirectCommandsLayoutUsageExplicitPreprocessBitNv = 1,
        IndirectCommandsLayoutUsageIndexedSequencesBitNv = 2,
        IndirectCommandsLayoutUsageUnorderedSequencesBitNv = 4,
    }
    [Flags]
    public enum VkIndirectStateFlagBitsNV : int
    {
        IndirectStateFlagFrontfaceBitNv = 1,
    }
    public enum VkIndirectCommandsTokenTypeNV : int
    {
        IndirectCommandsTokenTypeShaderGroupNv = 0,
        IndirectCommandsTokenTypeStateFlagsNv = 1,
        IndirectCommandsTokenTypeIndexBufferNv = 2,
        IndirectCommandsTokenTypeVertexBufferNv = 3,
        IndirectCommandsTokenTypePushConstantNv = 4,
        IndirectCommandsTokenTypeDrawIndexedNv = 5,
        IndirectCommandsTokenTypeDrawNv = 6,
        IndirectCommandsTokenTypeDrawTasksNv = 7,
        /// <summary>[requires: VK_EXT_mesh_shader]</summary>
        IndirectCommandsTokenTypeDrawMeshTasksNv = 1000328000,
        /// <summary>[requires: VK_NV_device_generated_commands_compute]</summary>
        IndirectCommandsTokenTypePipelineNv = 1000428003,
        /// <summary>[requires: VK_NV_device_generated_commands_compute]</summary>
        IndirectCommandsTokenTypeDispatchNv = 1000428004,
    }
    [Flags]
    public enum VkPrivateDataSlotCreateFlagBits : int
    {
    }
    [Flags]
    public enum VkDescriptorSetLayoutCreateFlagBits : int
    {
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        DescriptorSetLayoutCreateUpdateAfterBindPoolBit = 2,
        /// <summary>[requires: VK_KHR_push_descriptor]Descriptors are pushed via flink:vkCmdPushDescriptorSetKHR</summary>
        DescriptorSetLayoutCreatePushDescriptorBitKhr = 1,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        DescriptorSetLayoutCreateDescriptorBufferBitExt = 16,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        DescriptorSetLayoutCreateEmbeddedImmutableSamplersBitExt = 32,
        /// <summary>[requires: VK_NV_device_generated_commands_compute]</summary>
        DescriptorSetLayoutCreateIndirectBindableBitNv = 128,
        /// <summary>[requires: VK_EXT_mutable_descriptor_type]</summary>
        DescriptorSetLayoutCreateHostOnlyPoolBitExt = 4,
        /// <summary>[requires: VK_NV_per_stage_descriptor_set]</summary>
        DescriptorSetLayoutCreatePerStageBitNv = 64,
        /// <summary>[requires: VK_EXT_descriptor_indexing]</summary>
        DescriptorSetLayoutCreateUpdateAfterBindPoolBitExt = 2,
        /// <summary>[requires: VK_VALVE_mutable_descriptor_type]</summary>
        DescriptorSetLayoutCreateHostOnlyPoolBitValve = 4,
    }
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagBits : int
    {
        ExternalMemoryHandleTypeOpaqueFdBit = 1,
        ExternalMemoryHandleTypeOpaqueWin32Bit = 2,
        ExternalMemoryHandleTypeOpaqueWin32KmtBit = 4,
        ExternalMemoryHandleTypeD3d11TextureBit = 8,
        ExternalMemoryHandleTypeD3d11TextureKmtBit = 16,
        ExternalMemoryHandleTypeD3d12HeapBit = 32,
        ExternalMemoryHandleTypeD3d12ResourceBit = 64,
        /// <summary>[requires: VK_EXT_external_memory_dma_buf]</summary>
        ExternalMemoryHandleTypeDmaBufBitExt = 512,
        /// <summary>[requires: VK_ANDROID_external_memory_android_hardware_buffer]</summary>
        ExternalMemoryHandleTypeAndroidHardwareBufferBitAndroid = 1024,
        /// <summary>[requires: VK_EXT_external_memory_host]</summary>
        ExternalMemoryHandleTypeHostAllocationBitExt = 128,
        /// <summary>[requires: VK_EXT_external_memory_host]</summary>
        ExternalMemoryHandleTypeHostMappedForeignMemoryBitExt = 256,
        /// <summary>[requires: VK_FUCHSIA_external_memory]</summary>
        ExternalMemoryHandleTypeZirconVmoBitFuchsia = 2048,
        /// <summary>[requires: VK_NV_external_memory_rdma]</summary>
        ExternalMemoryHandleTypeRdmaAddressBitNv = 4096,
        /// <summary>[requires: VK_NV_external_memory_sci_buf]</summary>
        ExternalMemoryHandleTypeSciBufBitNv = 8192,
        /// <summary>[requires: VK_QNX_external_memory_screen_buffer]</summary>
        ExternalMemoryHandleTypeScreenBufferBitQnx = 16384,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        ExternalMemoryHandleTypeOpaqueFdBitKhr = 1,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        ExternalMemoryHandleTypeOpaqueWin32BitKhr = 2,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        ExternalMemoryHandleTypeOpaqueWin32KmtBitKhr = 4,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        ExternalMemoryHandleTypeD3d11TextureBitKhr = 8,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        ExternalMemoryHandleTypeD3d11TextureKmtBitKhr = 16,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        ExternalMemoryHandleTypeD3d12HeapBitKhr = 32,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        ExternalMemoryHandleTypeD3d12ResourceBitKhr = 64,
    }
    [Flags]
    public enum VkExternalMemoryFeatureFlagBits : int
    {
        ExternalMemoryFeatureDedicatedOnlyBit = 1,
        ExternalMemoryFeatureExportableBit = 2,
        ExternalMemoryFeatureImportableBit = 4,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        ExternalMemoryFeatureDedicatedOnlyBitKhr = 1,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        ExternalMemoryFeatureExportableBitKhr = 2,
        /// <summary>[requires: VK_KHR_external_memory_capabilities]</summary>
        ExternalMemoryFeatureImportableBitKhr = 4,
    }
    [Flags]
    public enum VkExternalSemaphoreHandleTypeFlagBits : int
    {
        ExternalSemaphoreHandleTypeOpaqueFdBit = 1,
        ExternalSemaphoreHandleTypeOpaqueWin32Bit = 2,
        ExternalSemaphoreHandleTypeOpaqueWin32KmtBit = 4,
        ExternalSemaphoreHandleTypeD3d12FenceBit = 8,
        ExternalSemaphoreHandleTypeD3d11FenceBit = 8,
        ExternalSemaphoreHandleTypeSyncFdBit = 16,
        /// <summary>[requires: VK_FUCHSIA_external_semaphore]</summary>
        ExternalSemaphoreHandleTypeZirconEventBitFuchsia = 128,
        /// <summary>[requires: VK_NV_external_sci_sync]</summary>
        ExternalSemaphoreHandleTypeSciSyncObjBitNv = 32,
        /// <summary>[requires: VK_KHR_external_semaphore_capabilities]</summary>
        ExternalSemaphoreHandleTypeOpaqueFdBitKhr = 1,
        /// <summary>[requires: VK_KHR_external_semaphore_capabilities]</summary>
        ExternalSemaphoreHandleTypeOpaqueWin32BitKhr = 2,
        /// <summary>[requires: VK_KHR_external_semaphore_capabilities]</summary>
        ExternalSemaphoreHandleTypeOpaqueWin32KmtBitKhr = 4,
        /// <summary>[requires: VK_KHR_external_semaphore_capabilities]</summary>
        ExternalSemaphoreHandleTypeD3d12FenceBitKhr = 8,
        /// <summary>[requires: VK_KHR_external_semaphore_capabilities]</summary>
        ExternalSemaphoreHandleTypeSyncFdBitKhr = 16,
    }
    [Flags]
    public enum VkExternalSemaphoreFeatureFlagBits : int
    {
        ExternalSemaphoreFeatureExportableBit = 1,
        ExternalSemaphoreFeatureImportableBit = 2,
        /// <summary>[requires: VK_KHR_external_semaphore_capabilities]</summary>
        ExternalSemaphoreFeatureExportableBitKhr = 1,
        /// <summary>[requires: VK_KHR_external_semaphore_capabilities]</summary>
        ExternalSemaphoreFeatureImportableBitKhr = 2,
    }
    [Flags]
    public enum VkSemaphoreImportFlagBits : int
    {
        SemaphoreImportTemporaryBit = 1,
        /// <summary>[requires: VK_KHR_external_semaphore]</summary>
        SemaphoreImportTemporaryBitKhr = 1,
    }
    [Flags]
    public enum VkExternalFenceHandleTypeFlagBits : int
    {
        ExternalFenceHandleTypeOpaqueFdBit = 1,
        ExternalFenceHandleTypeOpaqueWin32Bit = 2,
        ExternalFenceHandleTypeOpaqueWin32KmtBit = 4,
        ExternalFenceHandleTypeSyncFdBit = 8,
        /// <summary>[requires: VK_NV_external_sci_sync]</summary>
        ExternalFenceHandleTypeSciSyncObjBitNv = 16,
        /// <summary>[requires: VK_NV_external_sci_sync]</summary>
        ExternalFenceHandleTypeSciSyncFenceBitNv = 32,
        /// <summary>[requires: VK_KHR_external_fence_capabilities]</summary>
        ExternalFenceHandleTypeOpaqueFdBitKhr = 1,
        /// <summary>[requires: VK_KHR_external_fence_capabilities]</summary>
        ExternalFenceHandleTypeOpaqueWin32BitKhr = 2,
        /// <summary>[requires: VK_KHR_external_fence_capabilities]</summary>
        ExternalFenceHandleTypeOpaqueWin32KmtBitKhr = 4,
        /// <summary>[requires: VK_KHR_external_fence_capabilities]</summary>
        ExternalFenceHandleTypeSyncFdBitKhr = 8,
    }
    [Flags]
    public enum VkExternalFenceFeatureFlagBits : int
    {
        ExternalFenceFeatureExportableBit = 1,
        ExternalFenceFeatureImportableBit = 2,
        /// <summary>[requires: VK_KHR_external_fence_capabilities]</summary>
        ExternalFenceFeatureExportableBitKhr = 1,
        /// <summary>[requires: VK_KHR_external_fence_capabilities]</summary>
        ExternalFenceFeatureImportableBitKhr = 2,
    }
    [Flags]
    public enum VkFenceImportFlagBits : int
    {
        FenceImportTemporaryBit = 1,
        /// <summary>[requires: VK_KHR_external_fence]</summary>
        FenceImportTemporaryBitKhr = 1,
    }
    [Flags]
    public enum VkSurfaceCounterFlagBitsEXT : int
    {
        SurfaceCounterVblankBitExt = 1,
        SurfaceCounterVblankExt = 1,
    }
    public enum VkDisplayPowerStateEXT : int
    {
        DisplayPowerStateOffExt = 0,
        DisplayPowerStateSuspendExt = 1,
        DisplayPowerStateOnExt = 2,
    }
    public enum VkDeviceEventTypeEXT : int
    {
        DeviceEventTypeDisplayHotplugExt = 0,
    }
    public enum VkDisplayEventTypeEXT : int
    {
        DisplayEventTypeFirstPixelOutExt = 0,
    }
    [Flags]
    public enum VkPeerMemoryFeatureFlagBits : int
    {
        /// <summary>Can read with vkCmdCopy commands</summary>
        PeerMemoryFeatureCopySrcBit = 1,
        /// <summary>Can write with vkCmdCopy commands</summary>
        PeerMemoryFeatureCopyDstBit = 2,
        /// <summary>Can read with any access type/command</summary>
        PeerMemoryFeatureGenericSrcBit = 4,
        /// <summary>Can write with and access type/command</summary>
        PeerMemoryFeatureGenericDstBit = 8,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        PeerMemoryFeatureCopySrcBitKhr = 1,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        PeerMemoryFeatureCopyDstBitKhr = 2,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        PeerMemoryFeatureGenericSrcBitKhr = 4,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        PeerMemoryFeatureGenericDstBitKhr = 8,
    }
    [Flags]
    public enum VkMemoryAllocateFlagBits : int
    {
        /// <summary>Force allocation on specific devices</summary>
        MemoryAllocateDeviceMaskBit = 1,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        MemoryAllocateDeviceAddressBit = 2,
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        MemoryAllocateDeviceAddressCaptureReplayBit = 4,
        /// <summary>[requires: VK_KHR_device_group]</summary>
        MemoryAllocateDeviceMaskBitKhr = 1,
        /// <summary>[requires: VK_KHR_buffer_device_address]</summary>
        MemoryAllocateDeviceAddressBitKhr = 2,
        /// <summary>[requires: VK_KHR_buffer_device_address]</summary>
        MemoryAllocateDeviceAddressCaptureReplayBitKhr = 4,
    }
    [Flags]
    public enum VkDeviceGroupPresentModeFlagBitsKHR : int
    {
        /// <summary>Present from local memory</summary>
        DeviceGroupPresentModeLocalBitKhr = 1,
        /// <summary>Present from remote memory</summary>
        DeviceGroupPresentModeRemoteBitKhr = 2,
        /// <summary>Present sum of local and/or remote memory</summary>
        DeviceGroupPresentModeSumBitKhr = 4,
        /// <summary>Each physical device presents from local memory</summary>
        DeviceGroupPresentModeLocalMultiDeviceBitKhr = 8,
    }
    [Flags]
    public enum VkSwapchainCreateFlagBitsKHR : int
    {
        /// <summary>[requires: VK_KHR_swapchain]Allow images with VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT</summary>
        SwapchainCreateSplitInstanceBindRegionsBitKhr = 1,
        /// <summary>[requires: VK_KHR_swapchain]Swapchain is protected</summary>
        SwapchainCreateProtectedBitKhr = 2,
        /// <summary>[requires: VK_KHR_swapchain_mutable_format]</summary>
        SwapchainCreateMutableFormatBitKhr = 4,
        /// <summary>[requires: VK_EXT_swapchain_maintenance1]</summary>
        SwapchainCreateDeferredMemoryAllocationBitExt = 8,
    }
    public enum VkViewportCoordinateSwizzleNV : int
    {
        ViewportCoordinateSwizzlePositiveXNv = 0,
        ViewportCoordinateSwizzleNegativeXNv = 1,
        ViewportCoordinateSwizzlePositiveYNv = 2,
        ViewportCoordinateSwizzleNegativeYNv = 3,
        ViewportCoordinateSwizzlePositiveZNv = 4,
        ViewportCoordinateSwizzleNegativeZNv = 5,
        ViewportCoordinateSwizzlePositiveWNv = 6,
        ViewportCoordinateSwizzleNegativeWNv = 7,
    }
    public enum VkDiscardRectangleModeEXT : int
    {
        DiscardRectangleModeInclusiveExt = 0,
        DiscardRectangleModeExclusiveExt = 1,
    }
    [Flags]
    public enum VkSubpassDescriptionFlagBits : int
    {
        /// <summary>[requires: VK_NVX_multiview_per_view_attributes]</summary>
        SubpassDescriptionPerViewAttributesBitNvx = 1,
        /// <summary>[requires: VK_NVX_multiview_per_view_attributes]</summary>
        SubpassDescriptionPerViewPositionXOnlyBitNvx = 2,
        /// <summary>[requires: VK_QCOM_render_pass_shader_resolve]</summary>
        SubpassDescriptionFragmentRegionBitQcom = 4,
        /// <summary>[requires: VK_QCOM_render_pass_shader_resolve]</summary>
        SubpassDescriptionShaderResolveBitQcom = 8,
        /// <summary>[requires: VK_EXT_rasterization_order_attachment_access]</summary>
        SubpassDescriptionRasterizationOrderAttachmentColorAccessBitExt = 16,
        /// <summary>[requires: VK_EXT_rasterization_order_attachment_access]</summary>
        SubpassDescriptionRasterizationOrderAttachmentDepthAccessBitExt = 32,
        /// <summary>[requires: VK_EXT_rasterization_order_attachment_access]</summary>
        SubpassDescriptionRasterizationOrderAttachmentStencilAccessBitExt = 64,
        /// <summary>[requires: VK_EXT_legacy_dithering]</summary>
        SubpassDescriptionEnableLegacyDitheringBitExt = 128,
        /// <summary>[requires: VK_ARM_rasterization_order_attachment_access]</summary>
        SubpassDescriptionRasterizationOrderAttachmentColorAccessBitArm = 16,
        /// <summary>[requires: VK_ARM_rasterization_order_attachment_access]</summary>
        SubpassDescriptionRasterizationOrderAttachmentDepthAccessBitArm = 32,
        /// <summary>[requires: VK_ARM_rasterization_order_attachment_access]</summary>
        SubpassDescriptionRasterizationOrderAttachmentStencilAccessBitArm = 64,
    }
    public enum VkPointClippingBehavior : int
    {
        PointClippingBehaviorAllClipPlanes = 0,
        PointClippingBehaviorUserClipPlanesOnly = 1,
        /// <summary>[requires: VK_KHR_maintenance2]</summary>
        PointClippingBehaviorAllClipPlanesKhr = 0,
        /// <summary>[requires: VK_KHR_maintenance2]</summary>
        PointClippingBehaviorUserClipPlanesOnlyKhr = 1,
    }
    public enum VkSamplerReductionMode : int
    {
        SamplerReductionModeWeightedAverage = 0,
        SamplerReductionModeMin = 1,
        SamplerReductionModeMax = 2,
        /// <summary>[requires: VK_QCOM_filter_cubic_clamp]</summary>
        SamplerReductionModeWeightedAverageRangeclampQcom = 1000521000,
        /// <summary>[requires: VK_EXT_sampler_filter_minmax]</summary>
        SamplerReductionModeWeightedAverageExt = 0,
        /// <summary>[requires: VK_EXT_sampler_filter_minmax]</summary>
        SamplerReductionModeMinExt = 1,
        /// <summary>[requires: VK_EXT_sampler_filter_minmax]</summary>
        SamplerReductionModeMaxExt = 2,
    }
    public enum VkTessellationDomainOrigin : int
    {
        TessellationDomainOriginUpperLeft = 0,
        TessellationDomainOriginLowerLeft = 1,
        /// <summary>[requires: VK_KHR_maintenance2]</summary>
        TessellationDomainOriginUpperLeftKhr = 0,
        /// <summary>[requires: VK_KHR_maintenance2]</summary>
        TessellationDomainOriginLowerLeftKhr = 1,
    }
    public enum VkSamplerYcbcrModelConversion : int
    {
        SamplerYcbcrModelConversionRgbIdentity = 0,
        /// <summary>just range expansion</summary>
        SamplerYcbcrModelConversionYcbcrIdentity = 1,
        /// <summary>aka HD YUV</summary>
        SamplerYcbcrModelConversionYcbcr709 = 2,
        /// <summary>aka SD YUV</summary>
        SamplerYcbcrModelConversionYcbcr601 = 3,
        /// <summary>aka UHD YUV</summary>
        SamplerYcbcrModelConversionYcbcr2020 = 4,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        SamplerYcbcrModelConversionRgbIdentityKhr = 0,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        SamplerYcbcrModelConversionYcbcrIdentityKhr = 1,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        SamplerYcbcrModelConversionYcbcr709Khr = 2,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        SamplerYcbcrModelConversionYcbcr601Khr = 3,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        SamplerYcbcrModelConversionYcbcr2020Khr = 4,
    }
    public enum VkSamplerYcbcrRange : int
    {
        /// <summary>Luma 0..1 maps to 0..255, chroma -0.5..0.5 to 1..255 (clamped)</summary>
        SamplerYcbcrRangeItuFull = 0,
        /// <summary>Luma 0..1 maps to 16..235, chroma -0.5..0.5 to 16..240</summary>
        SamplerYcbcrRangeItuNarrow = 1,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        SamplerYcbcrRangeItuFullKhr = 0,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        SamplerYcbcrRangeItuNarrowKhr = 1,
    }
    public enum VkChromaLocation : int
    {
        ChromaLocationCositedEven = 0,
        ChromaLocationMidpoint = 1,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        ChromaLocationCositedEvenKhr = 0,
        /// <summary>[requires: VK_KHR_sampler_ycbcr_conversion]</summary>
        ChromaLocationMidpointKhr = 1,
    }
    public enum VkBlendOverlapEXT : int
    {
        BlendOverlapUncorrelatedExt = 0,
        BlendOverlapDisjointExt = 1,
        BlendOverlapConjointExt = 2,
    }
    public enum VkCoverageModulationModeNV : int
    {
        CoverageModulationModeNoneNv = 0,
        CoverageModulationModeRgbNv = 1,
        CoverageModulationModeAlphaNv = 2,
        CoverageModulationModeRgbaNv = 3,
    }
    public enum VkCoverageReductionModeNV : int
    {
        CoverageReductionModeMergeNv = 0,
        CoverageReductionModeTruncateNv = 1,
    }
    public enum VkValidationCacheHeaderVersionEXT : int
    {
        ValidationCacheHeaderVersionOneExt = 1,
    }
    public enum VkShaderInfoTypeAMD : int
    {
        ShaderInfoTypeStatisticsAmd = 0,
        ShaderInfoTypeBinaryAmd = 1,
        ShaderInfoTypeDisassemblyAmd = 2,
    }
    public enum VkQueueGlobalPriorityKHR : int
    {
        QueueGlobalPriorityLowKhr = 128,
        QueueGlobalPriorityMediumKhr = 256,
        QueueGlobalPriorityHighKhr = 512,
        QueueGlobalPriorityRealtimeKhr = 1024,
        QueueGlobalPriorityLowExt = 128,
        QueueGlobalPriorityMediumExt = 256,
        QueueGlobalPriorityHighExt = 512,
        QueueGlobalPriorityRealtimeExt = 1024,
    }
    [Flags]
    public enum VkDebugUtilsMessageSeverityFlagBitsEXT : int
    {
        DebugUtilsMessageSeverityVerboseBitExt = 1,
        DebugUtilsMessageSeverityInfoBitExt = 16,
        DebugUtilsMessageSeverityWarningBitExt = 256,
        DebugUtilsMessageSeverityErrorBitExt = 4096,
    }
    [Flags]
    public enum VkDebugUtilsMessageTypeFlagBitsEXT : int
    {
        DebugUtilsMessageTypeGeneralBitExt = 1,
        DebugUtilsMessageTypeValidationBitExt = 2,
        DebugUtilsMessageTypePerformanceBitExt = 4,
        /// <summary>[requires: VK_EXT_device_address_binding_report]</summary>
        DebugUtilsMessageTypeDeviceAddressBindingBitExt = 8,
    }
    public enum VkConservativeRasterizationModeEXT : int
    {
        ConservativeRasterizationModeDisabledExt = 0,
        ConservativeRasterizationModeOverestimateExt = 1,
        ConservativeRasterizationModeUnderestimateExt = 2,
    }
    [Flags]
    public enum VkDescriptorBindingFlagBits : int
    {
        DescriptorBindingUpdateAfterBindBit = 1,
        DescriptorBindingUpdateUnusedWhilePendingBit = 2,
        DescriptorBindingPartiallyBoundBit = 4,
        DescriptorBindingVariableDescriptorCountBit = 8,
        /// <summary>[requires: VK_EXT_descriptor_indexing]</summary>
        DescriptorBindingUpdateAfterBindBitExt = 1,
        /// <summary>[requires: VK_EXT_descriptor_indexing]</summary>
        DescriptorBindingUpdateUnusedWhilePendingBitExt = 2,
        /// <summary>[requires: VK_EXT_descriptor_indexing]</summary>
        DescriptorBindingPartiallyBoundBitExt = 4,
        /// <summary>[requires: VK_EXT_descriptor_indexing]</summary>
        DescriptorBindingVariableDescriptorCountBitExt = 8,
    }
    public enum VkVendorId : int
    {
        /// <summary>Khronos vendor ID</summary>
        VendorIdKhronos = 65536,
        /// <summary>Vivante vendor ID</summary>
        VendorIdViv = 65537,
        /// <summary>VeriSilicon vendor ID</summary>
        VendorIdVsi = 65538,
        /// <summary>Kazan Software Renderer</summary>
        VendorIdKazan = 65539,
        /// <summary>Codeplay Software Ltd. vendor ID</summary>
        VendorIdCodeplay = 65540,
        /// <summary>Mesa vendor ID</summary>
        VendorIdMesa = 65541,
        /// <summary>PoCL vendor ID</summary>
        VendorIdPocl = 65542,
        /// <summary>Mobileye vendor ID</summary>
        VendorIdMobileye = 65543,
    }
    public enum VkDriverId : int
    {
        /// <summary>Advanced Micro Devices, Inc.</summary>
        DriverIdAmdProprietary = 1,
        /// <summary>Advanced Micro Devices, Inc.</summary>
        DriverIdAmdOpenSource = 2,
        /// <summary>Mesa open source project</summary>
        DriverIdMesaRadv = 3,
        /// <summary>NVIDIA Corporation</summary>
        DriverIdNvidiaProprietary = 4,
        /// <summary>Intel Corporation</summary>
        DriverIdIntelProprietaryWindows = 5,
        /// <summary>Intel Corporation</summary>
        DriverIdIntelOpenSourceMesa = 6,
        /// <summary>Imagination Technologies</summary>
        DriverIdImaginationProprietary = 7,
        /// <summary>Qualcomm Technologies, Inc.</summary>
        DriverIdQualcommProprietary = 8,
        /// <summary>Arm Limited</summary>
        DriverIdArmProprietary = 9,
        /// <summary>Google LLC</summary>
        DriverIdGoogleSwiftshader = 10,
        /// <summary>Google LLC</summary>
        DriverIdGgpProprietary = 11,
        /// <summary>Broadcom Inc.</summary>
        DriverIdBroadcomProprietary = 12,
        /// <summary>Mesa</summary>
        DriverIdMesaLlvmpipe = 13,
        /// <summary>MoltenVK</summary>
        DriverIdMoltenvk = 14,
        /// <summary>Core Avionics & Industrial Inc.</summary>
        DriverIdCoreaviProprietary = 15,
        /// <summary>Juice Technologies, Inc.</summary>
        DriverIdJuiceProprietary = 16,
        /// <summary>Verisilicon, Inc.</summary>
        DriverIdVerisiliconProprietary = 17,
        /// <summary>Mesa open source project</summary>
        DriverIdMesaTurnip = 18,
        /// <summary>Mesa open source project</summary>
        DriverIdMesaV3dv = 19,
        /// <summary>Mesa open source project</summary>
        DriverIdMesaPanvk = 20,
        /// <summary>Samsung Electronics Co., Ltd.</summary>
        DriverIdSamsungProprietary = 21,
        /// <summary>Mesa open source project</summary>
        DriverIdMesaVenus = 22,
        /// <summary>Mesa open source project</summary>
        DriverIdMesaDozen = 23,
        /// <summary>Mesa open source project</summary>
        DriverIdMesaNvk = 24,
        /// <summary>Imagination Technologies</summary>
        DriverIdImaginationOpenSourceMesa = 25,
        /// <summary>Mesa open source project</summary>
        DriverIdMesaHoneykrisp = 26,
        /// <summary>Reserved for undisclosed driver project</summary>
        DriverIdReserved27 = 27,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        DriverIdAmdProprietaryKhr = 1,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        DriverIdAmdOpenSourceKhr = 2,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        DriverIdMesaRadvKhr = 3,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        DriverIdNvidiaProprietaryKhr = 4,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        DriverIdIntelProprietaryWindowsKhr = 5,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        DriverIdIntelOpenSourceMesaKhr = 6,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        DriverIdImaginationProprietaryKhr = 7,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        DriverIdQualcommProprietaryKhr = 8,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        DriverIdArmProprietaryKhr = 9,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        DriverIdGoogleSwiftshaderKhr = 10,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        DriverIdGgpProprietaryKhr = 11,
        /// <summary>[requires: VK_KHR_driver_properties]</summary>
        DriverIdBroadcomProprietaryKhr = 12,
    }
    [Flags]
    public enum VkConditionalRenderingFlagBitsEXT : int
    {
        ConditionalRenderingInvertedBitExt = 1,
    }
    [Flags]
    public enum VkResolveModeFlagBits : int
    {
        ResolveModeNone = 0,
        ResolveModeSampleZeroBit = 1,
        ResolveModeAverageBit = 2,
        ResolveModeMinBit = 4,
        ResolveModeMaxBit = 8,
        /// <summary>[requires: VK_ANDROID_external_format_resolve]</summary>
        ResolveModeExternalFormatDownsampleAndroid = 16,
        /// <summary>[requires: VK_KHR_depth_stencil_resolve]</summary>
        ResolveModeNoneKhr = 0,
        /// <summary>[requires: VK_KHR_depth_stencil_resolve]</summary>
        ResolveModeSampleZeroBitKhr = 1,
        /// <summary>[requires: VK_KHR_depth_stencil_resolve]</summary>
        ResolveModeAverageBitKhr = 2,
        /// <summary>[requires: VK_KHR_depth_stencil_resolve]</summary>
        ResolveModeMinBitKhr = 4,
        /// <summary>[requires: VK_KHR_depth_stencil_resolve]</summary>
        ResolveModeMaxBitKhr = 8,
    }
    public enum VkShadingRatePaletteEntryNV : int
    {
        ShadingRatePaletteEntryNoInvocationsNv = 0,
        ShadingRatePaletteEntry16InvocationsPerPixelNv = 1,
        ShadingRatePaletteEntry8InvocationsPerPixelNv = 2,
        ShadingRatePaletteEntry4InvocationsPerPixelNv = 3,
        ShadingRatePaletteEntry2InvocationsPerPixelNv = 4,
        ShadingRatePaletteEntry1InvocationPerPixelNv = 5,
        ShadingRatePaletteEntry1InvocationPer2x1PixelsNv = 6,
        ShadingRatePaletteEntry1InvocationPer1x2PixelsNv = 7,
        ShadingRatePaletteEntry1InvocationPer2x2PixelsNv = 8,
        ShadingRatePaletteEntry1InvocationPer4x2PixelsNv = 9,
        ShadingRatePaletteEntry1InvocationPer2x4PixelsNv = 10,
        ShadingRatePaletteEntry1InvocationPer4x4PixelsNv = 11,
    }
    public enum VkCoarseSampleOrderTypeNV : int
    {
        CoarseSampleOrderTypeDefaultNv = 0,
        CoarseSampleOrderTypeCustomNv = 1,
        CoarseSampleOrderTypePixelMajorNv = 2,
        CoarseSampleOrderTypeSampleMajorNv = 3,
    }
    [Flags]
    public enum VkGeometryInstanceFlagBitsKHR : int
    {
        GeometryInstanceTriangleFacingCullDisableBitKhr = 1,
        GeometryInstanceTriangleFlipFacingBitKhr = 2,
        GeometryInstanceForceOpaqueBitKhr = 4,
        GeometryInstanceForceNoOpaqueBitKhr = 8,
        GeometryInstanceTriangleFrontCounterclockwiseBitKhr = 2,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        GeometryInstanceForceOpacityMicromap2StateExt = 16,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        GeometryInstanceDisableOpacityMicromapsExt = 32,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        GeometryInstanceTriangleCullDisableBitNv = 1,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        GeometryInstanceTriangleFrontCounterclockwiseBitNv = 2,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        GeometryInstanceForceOpaqueBitNv = 4,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        GeometryInstanceForceNoOpaqueBitNv = 8,
    }
    [Flags]
    public enum VkGeometryFlagBitsKHR : int
    {
        GeometryOpaqueBitKhr = 1,
        GeometryNoDuplicateAnyHitInvocationBitKhr = 2,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        GeometryOpaqueBitNv = 1,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        GeometryNoDuplicateAnyHitInvocationBitNv = 2,
    }
    [Flags]
    public enum VkBuildAccelerationStructureFlagBitsKHR : int
    {
        BuildAccelerationStructureAllowUpdateBitKhr = 1,
        BuildAccelerationStructureAllowCompactionBitKhr = 2,
        BuildAccelerationStructurePreferFastTraceBitKhr = 4,
        BuildAccelerationStructurePreferFastBuildBitKhr = 8,
        BuildAccelerationStructureLowMemoryBitKhr = 16,
        /// <summary>[requires: VK_NV_ray_tracing_motion_blur]</summary>
        BuildAccelerationStructureMotionBitNv = 32,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        BuildAccelerationStructureAllowOpacityMicromapUpdateExt = 64,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        BuildAccelerationStructureAllowDisableOpacityMicromapsExt = 128,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        BuildAccelerationStructureAllowOpacityMicromapDataUpdateExt = 256,
        /// <summary>[requires: VK_NV_displacement_micromap]</summary>
        BuildAccelerationStructureAllowDisplacementMicromapUpdateNv = 512,
        /// <summary>[requires: VK_KHR_ray_tracing_position_fetch]</summary>
        BuildAccelerationStructureAllowDataAccessKhr = 2048,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        BuildAccelerationStructureAllowUpdateBitNv = 1,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        BuildAccelerationStructureAllowCompactionBitNv = 2,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        BuildAccelerationStructurePreferFastTraceBitNv = 4,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        BuildAccelerationStructurePreferFastBuildBitNv = 8,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        BuildAccelerationStructureLowMemoryBitNv = 16,
    }
    [Flags]
    public enum VkAccelerationStructureCreateFlagBitsKHR : int
    {
        AccelerationStructureCreateDeviceAddressCaptureReplayBitKhr = 1,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        AccelerationStructureCreateDescriptorBufferCaptureReplayBitExt = 8,
        /// <summary>[requires: VK_NV_ray_tracing_motion_blur]</summary>
        AccelerationStructureCreateMotionBitNv = 4,
    }
    public enum VkCopyAccelerationStructureModeKHR : int
    {
        CopyAccelerationStructureModeCloneKhr = 0,
        CopyAccelerationStructureModeCompactKhr = 1,
        CopyAccelerationStructureModeSerializeKhr = 2,
        CopyAccelerationStructureModeDeserializeKhr = 3,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        CopyAccelerationStructureModeCloneNv = 0,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        CopyAccelerationStructureModeCompactNv = 1,
    }
    public enum VkBuildAccelerationStructureModeKHR : int
    {
        BuildAccelerationStructureModeBuildKhr = 0,
        BuildAccelerationStructureModeUpdateKhr = 1,
    }
    public enum VkAccelerationStructureTypeKHR : int
    {
        AccelerationStructureTypeTopLevelKhr = 0,
        AccelerationStructureTypeBottomLevelKhr = 1,
        AccelerationStructureTypeGenericKhr = 2,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        AccelerationStructureTypeTopLevelNv = 0,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        AccelerationStructureTypeBottomLevelNv = 1,
    }
    public enum VkGeometryTypeKHR : int
    {
        GeometryTypeTrianglesKhr = 0,
        GeometryTypeAabbsKhr = 1,
        GeometryTypeInstancesKhr = 2,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        GeometryTypeTrianglesNv = 0,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        GeometryTypeAabbsNv = 1,
    }
    public enum VkAccelerationStructureMemoryRequirementsTypeNV : int
    {
        AccelerationStructureMemoryRequirementsTypeObjectNv = 0,
        AccelerationStructureMemoryRequirementsTypeBuildScratchNv = 1,
        AccelerationStructureMemoryRequirementsTypeUpdateScratchNv = 2,
    }
    public enum VkAccelerationStructureBuildTypeKHR : int
    {
        AccelerationStructureBuildTypeHostKhr = 0,
        AccelerationStructureBuildTypeDeviceKhr = 1,
        AccelerationStructureBuildTypeHostOrDeviceKhr = 2,
    }
    public enum VkRayTracingShaderGroupTypeKHR : int
    {
        RayTracingShaderGroupTypeGeneralKhr = 0,
        RayTracingShaderGroupTypeTrianglesHitGroupKhr = 1,
        RayTracingShaderGroupTypeProceduralHitGroupKhr = 2,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        RayTracingShaderGroupTypeGeneralNv = 0,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        RayTracingShaderGroupTypeTrianglesHitGroupNv = 1,
        /// <summary>[requires: VK_NV_ray_tracing]</summary>
        RayTracingShaderGroupTypeProceduralHitGroupNv = 2,
    }
    public enum VkAccelerationStructureCompatibilityKHR : int
    {
        AccelerationStructureCompatibilityCompatibleKhr = 0,
        AccelerationStructureCompatibilityIncompatibleKhr = 1,
    }
    public enum VkShaderGroupShaderKHR : int
    {
        ShaderGroupShaderGeneralKhr = 0,
        ShaderGroupShaderClosestHitKhr = 1,
        ShaderGroupShaderAnyHitKhr = 2,
        ShaderGroupShaderIntersectionKhr = 3,
    }
    public enum VkMemoryOverallocationBehaviorAMD : int
    {
        MemoryOverallocationBehaviorDefaultAmd = 0,
        MemoryOverallocationBehaviorAllowedAmd = 1,
        MemoryOverallocationBehaviorDisallowedAmd = 2,
    }
    [Flags]
    public enum VkFramebufferCreateFlagBits : int
    {
        /// <summary>[requires: VK_VERSION_1_2]</summary>
        FramebufferCreateImagelessBit = 1,
        /// <summary>[requires: VK_KHR_imageless_framebuffer]</summary>
        FramebufferCreateImagelessBitKhr = 1,
    }
    [Flags]
    public enum VkDeviceDiagnosticsConfigFlagBitsNV : int
    {
        DeviceDiagnosticsConfigEnableShaderDebugInfoBitNv = 1,
        DeviceDiagnosticsConfigEnableResourceTrackingBitNv = 2,
        DeviceDiagnosticsConfigEnableAutomaticCheckpointsBitNv = 4,
        DeviceDiagnosticsConfigEnableShaderErrorReportingBitNv = 8,
    }
    [Flags]
    public enum VkPipelineCreationFeedbackFlagBits : int
    {
        PipelineCreationFeedbackValidBit = 1,
        PipelineCreationFeedbackValidBitExt = 1,
        PipelineCreationFeedbackApplicationPipelineCacheHitBit = 2,
        PipelineCreationFeedbackApplicationPipelineCacheHitBitExt = 2,
        PipelineCreationFeedbackBasePipelineAccelerationBit = 4,
        PipelineCreationFeedbackBasePipelineAccelerationBitExt = 4,
    }
    public enum VkFullScreenExclusiveEXT : int
    {
        FullScreenExclusiveDefaultExt = 0,
        FullScreenExclusiveAllowedExt = 1,
        FullScreenExclusiveDisallowedExt = 2,
        FullScreenExclusiveApplicationControlledExt = 3,
    }
    public enum VkPerformanceCounterScopeKHR : int
    {
        PerformanceCounterScopeCommandBufferKhr = 0,
        PerformanceCounterScopeRenderPassKhr = 1,
        PerformanceCounterScopeCommandKhr = 2,
        QueryScopeCommandBufferKhr = 0,
        QueryScopeRenderPassKhr = 1,
        QueryScopeCommandKhr = 2,
    }
    [Flags]
    public enum VkMemoryDecompressionMethodFlagBitsNV : int
    {
        MemoryDecompressionMethodGdeflate10BitNv = 1,
    }
    public enum VkPerformanceCounterUnitKHR : int
    {
        PerformanceCounterUnitGenericKhr = 0,
        PerformanceCounterUnitPercentageKhr = 1,
        PerformanceCounterUnitNanosecondsKhr = 2,
        PerformanceCounterUnitBytesKhr = 3,
        PerformanceCounterUnitBytesPerSecondKhr = 4,
        PerformanceCounterUnitKelvinKhr = 5,
        PerformanceCounterUnitWattsKhr = 6,
        PerformanceCounterUnitVoltsKhr = 7,
        PerformanceCounterUnitAmpsKhr = 8,
        PerformanceCounterUnitHertzKhr = 9,
        PerformanceCounterUnitCyclesKhr = 10,
    }
    public enum VkPerformanceCounterStorageKHR : int
    {
        PerformanceCounterStorageInt32Khr = 0,
        PerformanceCounterStorageInt64Khr = 1,
        PerformanceCounterStorageUint32Khr = 2,
        PerformanceCounterStorageUint64Khr = 3,
        PerformanceCounterStorageFloat32Khr = 4,
        PerformanceCounterStorageFloat64Khr = 5,
    }
    [Flags]
    public enum VkPerformanceCounterDescriptionFlagBitsKHR : int
    {
        PerformanceCounterDescriptionPerformanceImpactingBitKhr = 1,
        PerformanceCounterDescriptionPerformanceImpactingKhr = 1,
        PerformanceCounterDescriptionConcurrentlyImpactedBitKhr = 2,
        PerformanceCounterDescriptionConcurrentlyImpactedKhr = 2,
    }
    [Flags]
    public enum VkAcquireProfilingLockFlagBitsKHR : int
    {
    }
    [Flags]
    public enum VkShaderCorePropertiesFlagBitsAMD : int
    {
    }
    [Flags]
    public enum VkRefreshObjectFlagBitsKHR : int
    {
    }
    public enum VkPerformanceConfigurationTypeINTEL : int
    {
        PerformanceConfigurationTypeCommandQueueMetricsDiscoveryActivatedIntel = 0,
    }
    public enum VkQueryPoolSamplingModeINTEL : int
    {
        QueryPoolSamplingModeManualIntel = 0,
    }
    public enum VkPerformanceOverrideTypeINTEL : int
    {
        PerformanceOverrideTypeNullHardwareIntel = 0,
        PerformanceOverrideTypeFlushGpuCachesIntel = 1,
    }
    public enum VkPerformanceParameterTypeINTEL : int
    {
        PerformanceParameterTypeHwCountersSupportedIntel = 0,
        PerformanceParameterTypeStreamMarkerValidBitsIntel = 1,
    }
    public enum VkPerformanceValueTypeINTEL : int
    {
        PerformanceValueTypeUint32Intel = 0,
        PerformanceValueTypeUint64Intel = 1,
        PerformanceValueTypeFloatIntel = 2,
        PerformanceValueTypeBoolIntel = 3,
        PerformanceValueTypeStringIntel = 4,
    }
    public enum VkShaderFloatControlsIndependence : int
    {
        ShaderFloatControlsIndependence32BitOnly = 0,
        ShaderFloatControlsIndependenceAll = 1,
        ShaderFloatControlsIndependenceNone = 2,
        /// <summary>[requires: VK_KHR_shader_float_controls]</summary>
        ShaderFloatControlsIndependence32BitOnlyKhr = 0,
        /// <summary>[requires: VK_KHR_shader_float_controls]</summary>
        ShaderFloatControlsIndependenceAllKhr = 1,
        /// <summary>[requires: VK_KHR_shader_float_controls]</summary>
        ShaderFloatControlsIndependenceNoneKhr = 2,
    }
    public enum VkPipelineExecutableStatisticFormatKHR : int
    {
        PipelineExecutableStatisticFormatBool32Khr = 0,
        PipelineExecutableStatisticFormatInt64Khr = 1,
        PipelineExecutableStatisticFormatUint64Khr = 2,
        PipelineExecutableStatisticFormatFloat64Khr = 3,
    }
    public enum VkLineRasterizationModeKHR : int
    {
        LineRasterizationModeDefaultKhr = 0,
        LineRasterizationModeDefaultExt = 0,
        LineRasterizationModeRectangularKhr = 1,
        LineRasterizationModeRectangularExt = 1,
        LineRasterizationModeBresenhamKhr = 2,
        LineRasterizationModeBresenhamExt = 2,
        LineRasterizationModeRectangularSmoothKhr = 3,
        LineRasterizationModeRectangularSmoothExt = 3,
    }
    [Flags]
    public enum VkShaderModuleCreateFlagBits : int
    {
    }
    [Flags]
    public enum VkPipelineCompilerControlFlagBitsAMD : int
    {
    }
    public enum VkFaultLevel : int
    {
        FaultLevelUnassigned = 0,
        FaultLevelCritical = 1,
        FaultLevelRecoverable = 2,
        FaultLevelWarning = 3,
    }
    public enum VkFaultType : int
    {
        FaultTypeInvalid = 0,
        FaultTypeUnassigned = 1,
        FaultTypeImplementation = 2,
        FaultTypeSystem = 3,
        FaultTypePhysicalDevice = 4,
        FaultTypeCommandBufferFull = 5,
        FaultTypeInvalidApiUsage = 6,
    }
    public enum VkFaultQueryBehavior : int
    {
        FaultQueryBehaviorGetAndClearAllFaults = 0,
    }
    [Flags]
    public enum VkToolPurposeFlagBits : int
    {
        ToolPurposeValidationBit = 1,
        ToolPurposeValidationBitExt = 1,
        ToolPurposeProfilingBit = 2,
        ToolPurposeProfilingBitExt = 2,
        ToolPurposeTracingBit = 4,
        ToolPurposeTracingBitExt = 4,
        ToolPurposeAdditionalFeaturesBit = 8,
        ToolPurposeAdditionalFeaturesBitExt = 8,
        ToolPurposeModifyingFeaturesBit = 16,
        ToolPurposeModifyingFeaturesBitExt = 16,
        /// <summary>[requires: VK_EXT_tooling_info]</summary>
        ToolPurposeDebugReportingBitExt = 32,
        /// <summary>[requires: VK_EXT_tooling_info]</summary>
        ToolPurposeDebugMarkersBitExt = 64,
    }
    public enum VkPipelineMatchControl : int
    {
        PipelineMatchControlApplicationUuidExactMatch = 0,
    }
    public enum VkFragmentShadingRateCombinerOpKHR : int
    {
        FragmentShadingRateCombinerOpKeepKhr = 0,
        FragmentShadingRateCombinerOpReplaceKhr = 1,
        FragmentShadingRateCombinerOpMinKhr = 2,
        FragmentShadingRateCombinerOpMaxKhr = 3,
        FragmentShadingRateCombinerOpMulKhr = 4,
    }
    public enum VkFragmentShadingRateNV : int
    {
        FragmentShadingRate1InvocationPerPixelNv = 0,
        FragmentShadingRate1InvocationPer1x2PixelsNv = 1,
        FragmentShadingRate1InvocationPer2x1PixelsNv = 4,
        FragmentShadingRate1InvocationPer2x2PixelsNv = 5,
        FragmentShadingRate1InvocationPer2x4PixelsNv = 6,
        FragmentShadingRate1InvocationPer4x2PixelsNv = 9,
        FragmentShadingRate1InvocationPer4x4PixelsNv = 10,
        FragmentShadingRate2InvocationsPerPixelNv = 11,
        FragmentShadingRate4InvocationsPerPixelNv = 12,
        FragmentShadingRate8InvocationsPerPixelNv = 13,
        FragmentShadingRate16InvocationsPerPixelNv = 14,
        FragmentShadingRateNoInvocationsNv = 15,
    }
    public enum VkFragmentShadingRateTypeNV : int
    {
        FragmentShadingRateTypeFragmentSizeNv = 0,
        FragmentShadingRateTypeEnumsNv = 1,
    }
    public enum VkSubpassMergeStatusEXT : int
    {
        SubpassMergeStatusMergedExt = 0,
        SubpassMergeStatusDisallowedExt = 1,
        SubpassMergeStatusNotMergedSideEffectsExt = 2,
        SubpassMergeStatusNotMergedSamplesMismatchExt = 3,
        SubpassMergeStatusNotMergedViewsMismatchExt = 4,
        SubpassMergeStatusNotMergedAliasingExt = 5,
        SubpassMergeStatusNotMergedDependenciesExt = 6,
        SubpassMergeStatusNotMergedIncompatibleInputAttachmentExt = 7,
        SubpassMergeStatusNotMergedTooManyAttachmentsExt = 8,
        SubpassMergeStatusNotMergedInsufficientStorageExt = 9,
        SubpassMergeStatusNotMergedDepthStencilCountExt = 10,
        SubpassMergeStatusNotMergedResolveAttachmentReuseExt = 11,
        SubpassMergeStatusNotMergedSingleSubpassExt = 12,
        SubpassMergeStatusNotMergedUnspecifiedExt = 13,
    }
    [Flags]
    public enum VkAccessFlagBits2 : int
    {
        Access2None = 0,
        Access2NoneKhr = 0,
        Access2IndirectCommandReadBit = 1,
        Access2IndirectCommandReadBitKhr = 1,
        Access2IndexReadBit = 2,
        Access2IndexReadBitKhr = 2,
        Access2VertexAttributeReadBit = 4,
        Access2VertexAttributeReadBitKhr = 4,
        Access2UniformReadBit = 8,
        Access2UniformReadBitKhr = 8,
        Access2InputAttachmentReadBit = 16,
        Access2InputAttachmentReadBitKhr = 16,
        Access2ShaderReadBit = 32,
        Access2ShaderReadBitKhr = 32,
        Access2ShaderWriteBit = 64,
        Access2ShaderWriteBitKhr = 64,
        Access2ColorAttachmentReadBit = 128,
        Access2ColorAttachmentReadBitKhr = 128,
        Access2ColorAttachmentWriteBit = 256,
        Access2ColorAttachmentWriteBitKhr = 256,
        Access2DepthStencilAttachmentReadBit = 512,
        Access2DepthStencilAttachmentReadBitKhr = 512,
        Access2DepthStencilAttachmentWriteBit = 1024,
        Access2DepthStencilAttachmentWriteBitKhr = 1024,
        Access2TransferReadBit = 2048,
        Access2TransferReadBitKhr = 2048,
        Access2TransferWriteBit = 4096,
        Access2TransferWriteBitKhr = 4096,
        Access2HostReadBit = 8192,
        Access2HostReadBitKhr = 8192,
        Access2HostWriteBit = 16384,
        Access2HostWriteBitKhr = 16384,
        Access2MemoryReadBit = 32768,
        Access2MemoryReadBitKhr = 32768,
        Access2MemoryWriteBit = 65536,
        Access2MemoryWriteBitKhr = 65536,
        Access2ShaderSampledReadBit = 1,
        Access2ShaderSampledReadBitKhr = 1,
        Access2ShaderStorageReadBit = 2,
        Access2ShaderStorageReadBitKhr = 2,
        Access2ShaderStorageWriteBit = 4,
        Access2ShaderStorageWriteBitKhr = 4,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        Access2VideoDecodeReadBitKhr = 8,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        Access2VideoDecodeWriteBitKhr = 16,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        Access2VideoEncodeReadBitKhr = 32,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        Access2VideoEncodeWriteBitKhr = 64,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2TransformFeedbackWriteBitExt = 33554432,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2TransformFeedbackCounterReadBitExt = 67108864,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2TransformFeedbackCounterWriteBitExt = 134217728,
        /// <summary>[requires: VK_KHR_synchronization2]read access flag for reading conditional rendering predicate</summary>
        Access2ConditionalRenderingReadBitExt = 1048576,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2CommandPreprocessReadBitNv = 131072,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2CommandPreprocessWriteBitNv = 262144,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2FragmentShadingRateAttachmentReadBitKhr = 8388608,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2AccelerationStructureReadBitKhr = 2097152,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2AccelerationStructureWriteBitKhr = 4194304,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2FragmentDensityMapReadBitExt = 16777216,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2ColorAttachmentReadNoncoherentBitExt = 524288,
        /// <summary>[requires: VK_EXT_descriptor_buffer]</summary>
        Access2DescriptorBufferReadBitExt = 512,
        /// <summary>[requires: VK_HUAWEI_invocation_mask]</summary>
        Access2InvocationMaskReadBitHuawei = 128,
        /// <summary>[requires: VK_KHR_ray_tracing_maintenance1]</summary>
        Access2ShaderBindingTableReadBitKhr = 256,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        Access2MicromapReadBitExt = 4096,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        Access2MicromapWriteBitExt = 8192,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        Access2OpticalFlowReadBitNv = 1024,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        Access2OpticalFlowWriteBitNv = 2048,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2ShadingRateImageReadBitNv = 8388608,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2AccelerationStructureReadBitNv = 2097152,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        Access2AccelerationStructureWriteBitNv = 4194304,
    }
    [Flags]
    public enum VkPipelineStageFlagBits2 : int
    {
        PipelineStage2None = 0,
        PipelineStage2NoneKhr = 0,
        PipelineStage2TopOfPipeBit = 1,
        PipelineStage2TopOfPipeBitKhr = 1,
        PipelineStage2DrawIndirectBit = 2,
        PipelineStage2DrawIndirectBitKhr = 2,
        PipelineStage2VertexInputBit = 4,
        PipelineStage2VertexInputBitKhr = 4,
        PipelineStage2VertexShaderBit = 8,
        PipelineStage2VertexShaderBitKhr = 8,
        PipelineStage2TessellationControlShaderBit = 16,
        PipelineStage2TessellationControlShaderBitKhr = 16,
        PipelineStage2TessellationEvaluationShaderBit = 32,
        PipelineStage2TessellationEvaluationShaderBitKhr = 32,
        PipelineStage2GeometryShaderBit = 64,
        PipelineStage2GeometryShaderBitKhr = 64,
        PipelineStage2FragmentShaderBit = 128,
        PipelineStage2FragmentShaderBitKhr = 128,
        PipelineStage2EarlyFragmentTestsBit = 256,
        PipelineStage2EarlyFragmentTestsBitKhr = 256,
        PipelineStage2LateFragmentTestsBit = 512,
        PipelineStage2LateFragmentTestsBitKhr = 512,
        PipelineStage2ColorAttachmentOutputBit = 1024,
        PipelineStage2ColorAttachmentOutputBitKhr = 1024,
        PipelineStage2ComputeShaderBit = 2048,
        PipelineStage2ComputeShaderBitKhr = 2048,
        PipelineStage2AllTransferBit = 4096,
        PipelineStage2AllTransferBitKhr = 4096,
        PipelineStage2TransferBit = 4096,
        PipelineStage2TransferBitKhr = 4096,
        PipelineStage2BottomOfPipeBit = 8192,
        PipelineStage2BottomOfPipeBitKhr = 8192,
        PipelineStage2HostBit = 16384,
        PipelineStage2HostBitKhr = 16384,
        PipelineStage2AllGraphicsBit = 32768,
        PipelineStage2AllGraphicsBitKhr = 32768,
        PipelineStage2AllCommandsBit = 65536,
        PipelineStage2AllCommandsBitKhr = 65536,
        PipelineStage2CopyBit = 1,
        PipelineStage2CopyBitKhr = 1,
        PipelineStage2ResolveBit = 2,
        PipelineStage2ResolveBitKhr = 2,
        PipelineStage2BlitBit = 4,
        PipelineStage2BlitBitKhr = 4,
        PipelineStage2ClearBit = 8,
        PipelineStage2ClearBitKhr = 8,
        PipelineStage2IndexInputBit = 16,
        PipelineStage2IndexInputBitKhr = 16,
        PipelineStage2VertexAttributeInputBit = 32,
        PipelineStage2VertexAttributeInputBitKhr = 32,
        PipelineStage2PreRasterizationShadersBit = 64,
        PipelineStage2PreRasterizationShadersBitKhr = 64,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        PipelineStage2VideoDecodeBitKhr = 67108864,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        PipelineStage2VideoEncodeBitKhr = 134217728,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2TransformFeedbackBitExt = 16777216,
        /// <summary>[requires: VK_KHR_synchronization2]A pipeline stage for conditional rendering predicate fetch</summary>
        PipelineStage2ConditionalRenderingBitExt = 262144,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2CommandPreprocessBitNv = 131072,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2FragmentShadingRateAttachmentBitKhr = 4194304,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2AccelerationStructureBuildBitKhr = 33554432,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2RayTracingShaderBitKhr = 2097152,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2FragmentDensityProcessBitExt = 8388608,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2TaskShaderBitExt = 524288,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2MeshShaderBitExt = 1048576,
        /// <summary>[requires: VK_HUAWEI_subpass_shading]</summary>
        PipelineStage2SubpassShaderBitHuawei = 128,
        /// <summary>[requires: VK_HUAWEI_invocation_mask]</summary>
        PipelineStage2InvocationMaskBitHuawei = 256,
        /// <summary>[requires: VK_KHR_ray_tracing_maintenance1]</summary>
        PipelineStage2AccelerationStructureCopyBitKhr = 268435456,
        /// <summary>[requires: VK_EXT_opacity_micromap]</summary>
        PipelineStage2MicromapBuildBitExt = 1073741824,
        /// <summary>[requires: VK_HUAWEI_cluster_culling_shader]</summary>
        PipelineStage2ClusterCullingShaderBitHuawei = 512,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        PipelineStage2OpticalFlowBitNv = 536870912,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2ShadingRateImageBitNv = 4194304,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2RayTracingShaderBitNv = 2097152,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2AccelerationStructureBuildBitNv = 33554432,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2TaskShaderBitNv = 524288,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        PipelineStage2MeshShaderBitNv = 1048576,
        /// <summary>[requires: VK_HUAWEI_subpass_shading]</summary>
        PipelineStage2SubpassShadingBitHuawei = 128,
    }
    [Flags]
    public enum VkSubmitFlagBits : int
    {
        SubmitProtectedBit = 1,
        SubmitProtectedBitKhr = 1,
    }
    [Flags]
    public enum VkEventCreateFlagBits : int
    {
        /// <summary>[requires: VK_VERSION_1_3]</summary>
        EventCreateDeviceOnlyBit = 1,
        /// <summary>[requires: VK_KHR_synchronization2]</summary>
        EventCreateDeviceOnlyBitKhr = 1,
    }
    [Flags]
    public enum VkPipelineLayoutCreateFlagBits : int
    {
        /// <summary>[requires: VK_EXT_graphics_pipeline_library]</summary>
        PipelineLayoutCreateIndependentSetsBitExt = 2,
    }
    public enum VkSciSyncClientTypeNV : int
    {
        SciSyncClientTypeSignalerNv = 0,
        SciSyncClientTypeWaiterNv = 1,
        SciSyncClientTypeSignalerWaiterNv = 2,
    }
    public enum VkSciSyncPrimitiveTypeNV : int
    {
        SciSyncPrimitiveTypeFenceNv = 0,
        SciSyncPrimitiveTypeSemaphoreNv = 1,
    }
    public enum VkProvokingVertexModeEXT : int
    {
        ProvokingVertexModeFirstVertexExt = 0,
        ProvokingVertexModeLastVertexExt = 1,
    }
    public enum VkPipelineCacheValidationVersion : int
    {
        PipelineCacheValidationVersionSafetyCriticalOne = 1,
    }
    public enum VkAccelerationStructureMotionInstanceTypeNV : int
    {
        AccelerationStructureMotionInstanceTypeStaticNv = 0,
        AccelerationStructureMotionInstanceTypeMatrixMotionNv = 1,
        AccelerationStructureMotionInstanceTypeSrtMotionNv = 2,
    }
    [Flags]
    public enum VkPipelineColorBlendStateCreateFlagBits : int
    {
        /// <summary>[requires: VK_EXT_rasterization_order_attachment_access]</summary>
        PipelineColorBlendStateCreateRasterizationOrderAttachmentAccessBitExt = 1,
        /// <summary>[requires: VK_ARM_rasterization_order_attachment_access]</summary>
        PipelineColorBlendStateCreateRasterizationOrderAttachmentAccessBitArm = 1,
    }
    [Flags]
    public enum VkPipelineDepthStencilStateCreateFlagBits : int
    {
        /// <summary>[requires: VK_EXT_rasterization_order_attachment_access]</summary>
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentDepthAccessBitExt = 1,
        /// <summary>[requires: VK_EXT_rasterization_order_attachment_access]</summary>
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentStencilAccessBitExt = 2,
        /// <summary>[requires: VK_ARM_rasterization_order_attachment_access]</summary>
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentDepthAccessBitArm = 1,
        /// <summary>[requires: VK_ARM_rasterization_order_attachment_access]</summary>
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentStencilAccessBitArm = 2,
    }
    [Flags]
    public enum VkGraphicsPipelineLibraryFlagBitsEXT : int
    {
        GraphicsPipelineLibraryVertexInputInterfaceBitExt = 1,
        GraphicsPipelineLibraryPreRasterizationShadersBitExt = 2,
        GraphicsPipelineLibraryFragmentShaderBitExt = 4,
        GraphicsPipelineLibraryFragmentOutputInterfaceBitExt = 8,
    }
    [Flags]
    public enum VkDeviceAddressBindingFlagBitsEXT : int
    {
        DeviceAddressBindingInternalObjectBitExt = 1,
    }
    public enum VkDeviceAddressBindingTypeEXT : int
    {
        DeviceAddressBindingTypeBindExt = 0,
        DeviceAddressBindingTypeUnbindExt = 1,
    }
    [Flags]
    public enum VkFrameBoundaryFlagBitsEXT : int
    {
        FrameBoundaryFrameEndBitExt = 1,
    }
    [Flags]
    public enum VkPresentScalingFlagBitsEXT : int
    {
        PresentScalingOneToOneBitExt = 1,
        PresentScalingAspectRatioStretchBitExt = 2,
        PresentScalingStretchBitExt = 4,
    }
    [Flags]
    public enum VkPresentGravityFlagBitsEXT : int
    {
        PresentGravityMinBitExt = 1,
        PresentGravityMaxBitExt = 2,
        PresentGravityCenteredBitExt = 4,
    }
    [Flags]
    public enum VkPhysicalDeviceSchedulingControlsFlagBitsARM : int
    {
        PhysicalDeviceSchedulingControlsShaderCoreCountArm = 1,
    }
    [Flags]
    public enum VkVideoCodecOperationFlagBitsKHR : int
    {
        VideoCodecOperationNoneKhr = 0,
        /// <summary>[requires: VK_KHR_video_encode_h264]</summary>
        VideoCodecOperationEncodeH264BitKhr = 65536,
        /// <summary>[requires: VK_KHR_video_encode_h265]</summary>
        VideoCodecOperationEncodeH265BitKhr = 131072,
        /// <summary>[requires: VK_KHR_video_decode_h264]</summary>
        VideoCodecOperationDecodeH264BitKhr = 1,
        /// <summary>[requires: VK_KHR_video_decode_h265]</summary>
        VideoCodecOperationDecodeH265BitKhr = 2,
        /// <summary>[requires: VK_KHR_video_decode_av1]</summary>
        VideoCodecOperationDecodeAv1BitKhr = 4,
    }
    [Flags]
    public enum VkVideoChromaSubsamplingFlagBitsKHR : int
    {
        VideoChromaSubsamplingInvalidKhr = 0,
        VideoChromaSubsamplingMonochromeBitKhr = 1,
        VideoChromaSubsampling420BitKhr = 2,
        VideoChromaSubsampling422BitKhr = 4,
        VideoChromaSubsampling444BitKhr = 8,
    }
    [Flags]
    public enum VkVideoComponentBitDepthFlagBitsKHR : int
    {
        VideoComponentBitDepthInvalidKhr = 0,
        VideoComponentBitDepth8BitKhr = 1,
        VideoComponentBitDepth10BitKhr = 4,
        VideoComponentBitDepth12BitKhr = 16,
    }
    [Flags]
    public enum VkVideoCapabilityFlagBitsKHR : int
    {
        VideoCapabilityProtectedContentBitKhr = 1,
        VideoCapabilitySeparateReferenceImagesBitKhr = 2,
    }
    [Flags]
    public enum VkVideoSessionCreateFlagBitsKHR : int
    {
        VideoSessionCreateProtectedContentBitKhr = 1,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        VideoSessionCreateAllowEncodeParameterOptimizationsBitKhr = 2,
        /// <summary>[requires: VK_KHR_video_maintenance1]</summary>
        VideoSessionCreateInlineQueriesBitKhr = 4,
    }
    [Flags]
    public enum VkVideoDecodeH264PictureLayoutFlagBitsKHR : int
    {
        VideoDecodeH264PictureLayoutProgressiveKhr = 0,
        VideoDecodeH264PictureLayoutInterlacedInterleavedLinesBitKhr = 1,
        VideoDecodeH264PictureLayoutInterlacedSeparatePlanesBitKhr = 2,
    }
    [Flags]
    public enum VkVideoCodingControlFlagBitsKHR : int
    {
        VideoCodingControlResetBitKhr = 1,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        VideoCodingControlEncodeRateControlBitKhr = 2,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        VideoCodingControlEncodeQualityLevelBitKhr = 4,
    }
    public enum VkQueryResultStatusKHR : int
    {
        QueryResultStatusErrorKhr = -1,
        QueryResultStatusNotReadyKhr = 0,
        QueryResultStatusCompleteKhr = 1,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        QueryResultStatusInsufficientBitstreamBufferRangeKhr = -1000299000,
    }
    [Flags]
    public enum VkVideoDecodeUsageFlagBitsKHR : int
    {
        VideoDecodeUsageDefaultKhr = 0,
        VideoDecodeUsageTranscodingBitKhr = 1,
        VideoDecodeUsageOfflineBitKhr = 2,
        VideoDecodeUsageStreamingBitKhr = 4,
    }
    [Flags]
    public enum VkVideoDecodeCapabilityFlagBitsKHR : int
    {
        VideoDecodeCapabilityDpbAndOutputCoincideBitKhr = 1,
        VideoDecodeCapabilityDpbAndOutputDistinctBitKhr = 2,
    }
    [Flags]
    public enum VkVideoEncodeFlagBitsKHR : int
    {
    }
    [Flags]
    public enum VkVideoEncodeUsageFlagBitsKHR : int
    {
        VideoEncodeUsageDefaultKhr = 0,
        VideoEncodeUsageTranscodingBitKhr = 1,
        VideoEncodeUsageStreamingBitKhr = 2,
        VideoEncodeUsageRecordingBitKhr = 4,
        VideoEncodeUsageConferencingBitKhr = 8,
    }
    [Flags]
    public enum VkVideoEncodeContentFlagBitsKHR : int
    {
        VideoEncodeContentDefaultKhr = 0,
        VideoEncodeContentCameraBitKhr = 1,
        VideoEncodeContentDesktopBitKhr = 2,
        VideoEncodeContentRenderedBitKhr = 4,
    }
    public enum VkVideoEncodeTuningModeKHR : int
    {
        VideoEncodeTuningModeDefaultKhr = 0,
        VideoEncodeTuningModeHighQualityKhr = 1,
        VideoEncodeTuningModeLowLatencyKhr = 2,
        VideoEncodeTuningModeUltraLowLatencyKhr = 3,
        VideoEncodeTuningModeLosslessKhr = 4,
    }
    [Flags]
    public enum VkVideoEncodeCapabilityFlagBitsKHR : int
    {
        VideoEncodeCapabilityPrecedingExternallyEncodedBytesBitKhr = 1,
        VideoEncodeCapabilityInsufficientBitstreamBufferRangeDetectionBitKhr = 2,
    }
    [Flags]
    public enum VkVideoEncodeFeedbackFlagBitsKHR : int
    {
        VideoEncodeFeedbackBitstreamBufferOffsetBitKhr = 1,
        VideoEncodeFeedbackBitstreamBytesWrittenBitKhr = 2,
        VideoEncodeFeedbackBitstreamHasOverridesBitKhr = 4,
    }
    [Flags]
    public enum VkVideoEncodeRateControlModeFlagBitsKHR : int
    {
        VideoEncodeRateControlModeDefaultKhr = 0,
        VideoEncodeRateControlModeDisabledBitKhr = 1,
        VideoEncodeRateControlModeCbrBitKhr = 2,
        VideoEncodeRateControlModeVbrBitKhr = 4,
    }
    [Flags]
    public enum VkVideoEncodeH264CapabilityFlagBitsKHR : int
    {
        VideoEncodeH264CapabilityHrdComplianceBitKhr = 1,
        VideoEncodeH264CapabilityPredictionWeightTableGeneratedBitKhr = 2,
        VideoEncodeH264CapabilityRowUnalignedSliceBitKhr = 4,
        VideoEncodeH264CapabilityDifferentSliceTypeBitKhr = 8,
        VideoEncodeH264CapabilityBFrameInL0ListBitKhr = 16,
        VideoEncodeH264CapabilityBFrameInL1ListBitKhr = 32,
        VideoEncodeH264CapabilityPerPictureTypeMinMaxQpBitKhr = 64,
        VideoEncodeH264CapabilityPerSliceConstantQpBitKhr = 128,
        VideoEncodeH264CapabilityGeneratePrefixNaluBitKhr = 256,
    }
    [Flags]
    public enum VkVideoEncodeH264StdFlagBitsKHR : int
    {
        VideoEncodeH264StdSeparateColorPlaneFlagSetBitKhr = 1,
        VideoEncodeH264StdQpprimeYZeroTransformBypassFlagSetBitKhr = 2,
        VideoEncodeH264StdScalingMatrixPresentFlagSetBitKhr = 4,
        VideoEncodeH264StdChromaQpIndexOffsetBitKhr = 8,
        VideoEncodeH264StdSecondChromaQpIndexOffsetBitKhr = 16,
        VideoEncodeH264StdPicInitQpMinus26BitKhr = 32,
        VideoEncodeH264StdWeightedPredFlagSetBitKhr = 64,
        VideoEncodeH264StdWeightedBipredIdcExplicitBitKhr = 128,
        VideoEncodeH264StdWeightedBipredIdcImplicitBitKhr = 256,
        VideoEncodeH264StdTransform8x8ModeFlagSetBitKhr = 512,
        VideoEncodeH264StdDirectSpatialMvPredFlagUnsetBitKhr = 1024,
        VideoEncodeH264StdEntropyCodingModeFlagUnsetBitKhr = 2048,
        VideoEncodeH264StdEntropyCodingModeFlagSetBitKhr = 4096,
        VideoEncodeH264StdDirect8x8InferenceFlagUnsetBitKhr = 8192,
        VideoEncodeH264StdConstrainedIntraPredFlagSetBitKhr = 16384,
        VideoEncodeH264StdDeblockingFilterDisabledBitKhr = 32768,
        VideoEncodeH264StdDeblockingFilterEnabledBitKhr = 65536,
        VideoEncodeH264StdDeblockingFilterPartialBitKhr = 131072,
        VideoEncodeH264StdSliceQpDeltaBitKhr = 524288,
        VideoEncodeH264StdDifferentSliceQpDeltaBitKhr = 1048576,
    }
    [Flags]
    public enum VkVideoEncodeH264RateControlFlagBitsKHR : int
    {
        VideoEncodeH264RateControlAttemptHrdComplianceBitKhr = 1,
        VideoEncodeH264RateControlRegularGopBitKhr = 2,
        VideoEncodeH264RateControlReferencePatternFlatBitKhr = 4,
        VideoEncodeH264RateControlReferencePatternDyadicBitKhr = 8,
        VideoEncodeH264RateControlTemporalLayerPatternDyadicBitKhr = 16,
    }
    [Flags]
    public enum VkHostImageCopyFlagBitsEXT : int
    {
        HostImageCopyMemcpyExt = 1,
    }
    [Flags]
    public enum VkImageFormatConstraintsFlagBitsFUCHSIA : int
    {
    }
    [Flags]
    public enum VkImageConstraintsInfoFlagBitsFUCHSIA : int
    {
        ImageConstraintsInfoCpuReadRarelyFuchsia = 1,
        ImageConstraintsInfoCpuReadOftenFuchsia = 2,
        ImageConstraintsInfoCpuWriteRarelyFuchsia = 4,
        ImageConstraintsInfoCpuWriteOftenFuchsia = 8,
        ImageConstraintsInfoProtectedOptionalFuchsia = 16,
    }
    [Flags]
    public enum VkFormatFeatureFlagBits2 : int
    {
        FormatFeature2SampledImageBit = 1,
        FormatFeature2SampledImageBitKhr = 1,
        FormatFeature2StorageImageBit = 2,
        FormatFeature2StorageImageBitKhr = 2,
        FormatFeature2StorageImageAtomicBit = 4,
        FormatFeature2StorageImageAtomicBitKhr = 4,
        FormatFeature2UniformTexelBufferBit = 8,
        FormatFeature2UniformTexelBufferBitKhr = 8,
        FormatFeature2StorageTexelBufferBit = 16,
        FormatFeature2StorageTexelBufferBitKhr = 16,
        FormatFeature2StorageTexelBufferAtomicBit = 32,
        FormatFeature2StorageTexelBufferAtomicBitKhr = 32,
        FormatFeature2VertexBufferBit = 64,
        FormatFeature2VertexBufferBitKhr = 64,
        FormatFeature2ColorAttachmentBit = 128,
        FormatFeature2ColorAttachmentBitKhr = 128,
        FormatFeature2ColorAttachmentBlendBit = 256,
        FormatFeature2ColorAttachmentBlendBitKhr = 256,
        FormatFeature2DepthStencilAttachmentBit = 512,
        FormatFeature2DepthStencilAttachmentBitKhr = 512,
        FormatFeature2BlitSrcBit = 1024,
        FormatFeature2BlitSrcBitKhr = 1024,
        FormatFeature2BlitDstBit = 2048,
        FormatFeature2BlitDstBitKhr = 2048,
        FormatFeature2SampledImageFilterLinearBit = 4096,
        FormatFeature2SampledImageFilterLinearBitKhr = 4096,
        FormatFeature2SampledImageFilterCubicBit = 8192,
        FormatFeature2SampledImageFilterCubicBitExt = 8192,
        FormatFeature2TransferSrcBit = 16384,
        FormatFeature2TransferSrcBitKhr = 16384,
        FormatFeature2TransferDstBit = 32768,
        FormatFeature2TransferDstBitKhr = 32768,
        FormatFeature2SampledImageFilterMinmaxBit = 65536,
        FormatFeature2SampledImageFilterMinmaxBitKhr = 65536,
        FormatFeature2MidpointChromaSamplesBit = 131072,
        FormatFeature2MidpointChromaSamplesBitKhr = 131072,
        FormatFeature2SampledImageYcbcrConversionLinearFilterBit = 262144,
        FormatFeature2SampledImageYcbcrConversionLinearFilterBitKhr = 262144,
        FormatFeature2SampledImageYcbcrConversionSeparateReconstructionFilterBit = 524288,
        FormatFeature2SampledImageYcbcrConversionSeparateReconstructionFilterBitKhr = 524288,
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitBit = 1048576,
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitBitKhr = 1048576,
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 2097152,
        FormatFeature2SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKhr = 2097152,
        FormatFeature2DisjointBit = 4194304,
        FormatFeature2DisjointBitKhr = 4194304,
        FormatFeature2CositedChromaSamplesBit = 8388608,
        FormatFeature2CositedChromaSamplesBitKhr = 8388608,
        FormatFeature2StorageReadWithoutFormatBit = -2147483648,
        FormatFeature2StorageReadWithoutFormatBitKhr = -2147483648,
        FormatFeature2StorageWriteWithoutFormatBit = 1,
        FormatFeature2StorageWriteWithoutFormatBitKhr = 1,
        FormatFeature2SampledImageDepthComparisonBit = 2,
        FormatFeature2SampledImageDepthComparisonBitKhr = 2,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        FormatFeature2VideoDecodeOutputBitKhr = 33554432,
        /// <summary>[requires: VK_KHR_video_decode_queue]</summary>
        FormatFeature2VideoDecodeDpbBitKhr = 67108864,
        /// <summary>[requires: VK_KHR_acceleration_structure]</summary>
        FormatFeature2AccelerationStructureVertexBufferBitKhr = 536870912,
        /// <summary>[requires: VK_EXT_fragment_density_map]</summary>
        FormatFeature2FragmentDensityMapBitExt = 16777216,
        /// <summary>[requires: VK_KHR_fragment_shading_rate]</summary>
        FormatFeature2FragmentShadingRateAttachmentBitKhr = 1073741824,
        /// <summary>[requires: VK_EXT_host_image_copy]Host image copies are supported</summary>
        FormatFeature2HostImageTransferBitExt = 16384,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        FormatFeature2VideoEncodeInputBitKhr = 134217728,
        /// <summary>[requires: VK_KHR_video_encode_queue]</summary>
        FormatFeature2VideoEncodeDpbBitKhr = 268435456,
        /// <summary>[requires: VK_NV_linear_color_attachment]Format support linear image as render target, it cannot be mixed with non linear attachment</summary>
        FormatFeature2LinearColorAttachmentBitNv = 64,
        /// <summary>[requires: VK_QCOM_image_processing]</summary>
        FormatFeature2WeightImageBitQcom = 4,
        /// <summary>[requires: VK_QCOM_image_processing]</summary>
        FormatFeature2WeightSampledImageBitQcom = 8,
        /// <summary>[requires: VK_QCOM_image_processing]</summary>
        FormatFeature2BlockMatchingBitQcom = 16,
        /// <summary>[requires: VK_QCOM_image_processing]</summary>
        FormatFeature2BoxFilterSampledBitQcom = 32,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        FormatFeature2OpticalFlowImageBitNv = 256,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        FormatFeature2OpticalFlowVectorBitNv = 512,
        /// <summary>[requires: VK_NV_optical_flow]</summary>
        FormatFeature2OpticalFlowCostBitNv = 1024,
    }
    [Flags]
    public enum VkRenderingFlagBits : int
    {
        RenderingContentsSecondaryCommandBuffersBit = 1,
        RenderingContentsSecondaryCommandBuffersBitKhr = 1,
        RenderingSuspendingBit = 2,
        RenderingSuspendingBitKhr = 2,
        RenderingResumingBit = 4,
        RenderingResumingBitKhr = 4,
        /// <summary>[requires: VK_EXT_legacy_dithering]</summary>
        RenderingEnableLegacyDitheringBitExt = 8,
        /// <summary>[requires: VK_KHR_maintenance7]Promoted from extension 452</summary>
        RenderingContentsInlineBitKhr = 16,
        /// <summary>[requires: VK_EXT_nested_command_buffer]</summary>
        RenderingContentsInlineBitExt = 16,
    }
    [Flags]
    public enum VkVideoEncodeH265CapabilityFlagBitsKHR : int
    {
        VideoEncodeH265CapabilityHrdComplianceBitKhr = 1,
        VideoEncodeH265CapabilityPredictionWeightTableGeneratedBitKhr = 2,
        VideoEncodeH265CapabilityRowUnalignedSliceSegmentBitKhr = 4,
        VideoEncodeH265CapabilityDifferentSliceSegmentTypeBitKhr = 8,
        VideoEncodeH265CapabilityBFrameInL0ListBitKhr = 16,
        VideoEncodeH265CapabilityBFrameInL1ListBitKhr = 32,
        VideoEncodeH265CapabilityPerPictureTypeMinMaxQpBitKhr = 64,
        VideoEncodeH265CapabilityPerSliceSegmentConstantQpBitKhr = 128,
        VideoEncodeH265CapabilityMultipleTilesPerSliceSegmentBitKhr = 256,
        VideoEncodeH265CapabilityMultipleSliceSegmentsPerTileBitKhr = 512,
    }
    [Flags]
    public enum VkVideoEncodeH265StdFlagBitsKHR : int
    {
        VideoEncodeH265StdSeparateColorPlaneFlagSetBitKhr = 1,
        VideoEncodeH265StdSampleAdaptiveOffsetEnabledFlagSetBitKhr = 2,
        VideoEncodeH265StdScalingListDataPresentFlagSetBitKhr = 4,
        VideoEncodeH265StdPcmEnabledFlagSetBitKhr = 8,
        VideoEncodeH265StdSpsTemporalMvpEnabledFlagSetBitKhr = 16,
        VideoEncodeH265StdInitQpMinus26BitKhr = 32,
        VideoEncodeH265StdWeightedPredFlagSetBitKhr = 64,
        VideoEncodeH265StdWeightedBipredFlagSetBitKhr = 128,
        VideoEncodeH265StdLog2ParallelMergeLevelMinus2BitKhr = 256,
        VideoEncodeH265StdSignDataHidingEnabledFlagSetBitKhr = 512,
        VideoEncodeH265StdTransformSkipEnabledFlagSetBitKhr = 1024,
        VideoEncodeH265StdTransformSkipEnabledFlagUnsetBitKhr = 2048,
        VideoEncodeH265StdPpsSliceChromaQpOffsetsPresentFlagSetBitKhr = 4096,
        VideoEncodeH265StdTransquantBypassEnabledFlagSetBitKhr = 8192,
        VideoEncodeH265StdConstrainedIntraPredFlagSetBitKhr = 16384,
        VideoEncodeH265StdEntropyCodingSyncEnabledFlagSetBitKhr = 32768,
        VideoEncodeH265StdDeblockingFilterOverrideEnabledFlagSetBitKhr = 65536,
        VideoEncodeH265StdDependentSliceSegmentsEnabledFlagSetBitKhr = 131072,
        VideoEncodeH265StdDependentSliceSegmentFlagSetBitKhr = 262144,
        VideoEncodeH265StdSliceQpDeltaBitKhr = 524288,
        VideoEncodeH265StdDifferentSliceQpDeltaBitKhr = 1048576,
    }
    [Flags]
    public enum VkVideoEncodeH265RateControlFlagBitsKHR : int
    {
        VideoEncodeH265RateControlAttemptHrdComplianceBitKhr = 1,
        VideoEncodeH265RateControlRegularGopBitKhr = 2,
        VideoEncodeH265RateControlReferencePatternFlatBitKhr = 4,
        VideoEncodeH265RateControlReferencePatternDyadicBitKhr = 8,
        VideoEncodeH265RateControlTemporalSubLayerPatternDyadicBitKhr = 16,
    }
    [Flags]
    public enum VkVideoEncodeH265CtbSizeFlagBitsKHR : int
    {
        VideoEncodeH265CtbSize16BitKhr = 1,
        VideoEncodeH265CtbSize32BitKhr = 2,
        VideoEncodeH265CtbSize64BitKhr = 4,
    }
    [Flags]
    public enum VkVideoEncodeH265TransformBlockSizeFlagBitsKHR : int
    {
        VideoEncodeH265TransformBlockSize4BitKhr = 1,
        VideoEncodeH265TransformBlockSize8BitKhr = 2,
        VideoEncodeH265TransformBlockSize16BitKhr = 4,
        VideoEncodeH265TransformBlockSize32BitKhr = 8,
    }
    [Flags]
    public enum VkExportMetalObjectTypeFlagBitsEXT : int
    {
        ExportMetalObjectTypeMetalDeviceBitExt = 1,
        ExportMetalObjectTypeMetalCommandQueueBitExt = 2,
        ExportMetalObjectTypeMetalBufferBitExt = 4,
        ExportMetalObjectTypeMetalTextureBitExt = 8,
        ExportMetalObjectTypeMetalIosurfaceBitExt = 16,
        ExportMetalObjectTypeMetalSharedEventBitExt = 32,
    }
    [Flags]
    public enum VkInstanceCreateFlagBits : int
    {
        /// <summary>[requires: VK_KHR_portability_enumeration]</summary>
        InstanceCreateEnumeratePortabilityBitKhr = 1,
    }
    [Flags]
    public enum VkImageCompressionFlagBitsEXT : int
    {
        ImageCompressionDefaultExt = 0,
        ImageCompressionFixedRateDefaultExt = 1,
        ImageCompressionFixedRateExplicitExt = 2,
        ImageCompressionDisabledExt = 4,
    }
    [Flags]
    public enum VkImageCompressionFixedRateFlagBitsEXT : int
    {
        ImageCompressionFixedRateNoneExt = 0,
        ImageCompressionFixedRate1bpcBitExt = 1,
        ImageCompressionFixedRate2bpcBitExt = 2,
        ImageCompressionFixedRate3bpcBitExt = 4,
        ImageCompressionFixedRate4bpcBitExt = 8,
        ImageCompressionFixedRate5bpcBitExt = 16,
        ImageCompressionFixedRate6bpcBitExt = 32,
        ImageCompressionFixedRate7bpcBitExt = 64,
        ImageCompressionFixedRate8bpcBitExt = 128,
        ImageCompressionFixedRate9bpcBitExt = 256,
        ImageCompressionFixedRate10bpcBitExt = 512,
        ImageCompressionFixedRate11bpcBitExt = 1024,
        ImageCompressionFixedRate12bpcBitExt = 2048,
        ImageCompressionFixedRate13bpcBitExt = 4096,
        ImageCompressionFixedRate14bpcBitExt = 8192,
        ImageCompressionFixedRate15bpcBitExt = 16384,
        ImageCompressionFixedRate16bpcBitExt = 32768,
        ImageCompressionFixedRate17bpcBitExt = 65536,
        ImageCompressionFixedRate18bpcBitExt = 131072,
        ImageCompressionFixedRate19bpcBitExt = 262144,
        ImageCompressionFixedRate20bpcBitExt = 524288,
        ImageCompressionFixedRate21bpcBitExt = 1048576,
        ImageCompressionFixedRate22bpcBitExt = 2097152,
        ImageCompressionFixedRate23bpcBitExt = 4194304,
        ImageCompressionFixedRate24bpcBitExt = 8388608,
    }
    public enum VkPipelineRobustnessBufferBehaviorEXT : int
    {
        PipelineRobustnessBufferBehaviorDeviceDefaultExt = 0,
        PipelineRobustnessBufferBehaviorDisabledExt = 1,
        PipelineRobustnessBufferBehaviorRobustBufferAccessExt = 2,
        PipelineRobustnessBufferBehaviorRobustBufferAccess2Ext = 3,
    }
    public enum VkPipelineRobustnessImageBehaviorEXT : int
    {
        PipelineRobustnessImageBehaviorDeviceDefaultExt = 0,
        PipelineRobustnessImageBehaviorDisabledExt = 1,
        PipelineRobustnessImageBehaviorRobustImageAccessExt = 2,
        PipelineRobustnessImageBehaviorRobustImageAccess2Ext = 3,
    }
    [Flags]
    public enum VkOpticalFlowGridSizeFlagBitsNV : int
    {
        OpticalFlowGridSizeUnknownNv = 0,
        OpticalFlowGridSize1x1BitNv = 1,
        OpticalFlowGridSize2x2BitNv = 2,
        OpticalFlowGridSize4x4BitNv = 4,
        OpticalFlowGridSize8x8BitNv = 8,
    }
    [Flags]
    public enum VkOpticalFlowUsageFlagBitsNV : int
    {
        OpticalFlowUsageUnknownNv = 0,
        OpticalFlowUsageInputBitNv = 1,
        OpticalFlowUsageOutputBitNv = 2,
        OpticalFlowUsageHintBitNv = 4,
        OpticalFlowUsageCostBitNv = 8,
        OpticalFlowUsageGlobalFlowBitNv = 16,
    }
    public enum VkOpticalFlowPerformanceLevelNV : int
    {
        OpticalFlowPerformanceLevelUnknownNv = 0,
        OpticalFlowPerformanceLevelSlowNv = 1,
        OpticalFlowPerformanceLevelMediumNv = 2,
        OpticalFlowPerformanceLevelFastNv = 3,
    }
    public enum VkOpticalFlowSessionBindingPointNV : int
    {
        OpticalFlowSessionBindingPointUnknownNv = 0,
        OpticalFlowSessionBindingPointInputNv = 1,
        OpticalFlowSessionBindingPointReferenceNv = 2,
        OpticalFlowSessionBindingPointHintNv = 3,
        OpticalFlowSessionBindingPointFlowVectorNv = 4,
        OpticalFlowSessionBindingPointBackwardFlowVectorNv = 5,
        OpticalFlowSessionBindingPointCostNv = 6,
        OpticalFlowSessionBindingPointBackwardCostNv = 7,
        OpticalFlowSessionBindingPointGlobalFlowNv = 8,
    }
    [Flags]
    public enum VkOpticalFlowSessionCreateFlagBitsNV : int
    {
        OpticalFlowSessionCreateEnableHintBitNv = 1,
        OpticalFlowSessionCreateEnableCostBitNv = 2,
        OpticalFlowSessionCreateEnableGlobalFlowBitNv = 4,
        OpticalFlowSessionCreateAllowRegionsBitNv = 8,
        OpticalFlowSessionCreateBothDirectionsBitNv = 16,
    }
    [Flags]
    public enum VkOpticalFlowExecuteFlagBitsNV : int
    {
        OpticalFlowExecuteDisableTemporalHintsBitNv = 1,
    }
    public enum VkMicromapTypeEXT : int
    {
        MicromapTypeOpacityMicromapExt = 0,
        /// <summary>[requires: VK_NV_displacement_micromap]</summary>
        MicromapTypeDisplacementMicromapNv = 1000397000,
    }
    [Flags]
    public enum VkBuildMicromapFlagBitsEXT : int
    {
        BuildMicromapPreferFastTraceBitExt = 1,
        BuildMicromapPreferFastBuildBitExt = 2,
        BuildMicromapAllowCompactionBitExt = 4,
    }
    [Flags]
    public enum VkMicromapCreateFlagBitsEXT : int
    {
        MicromapCreateDeviceAddressCaptureReplayBitExt = 1,
    }
    public enum VkCopyMicromapModeEXT : int
    {
        CopyMicromapModeCloneExt = 0,
        CopyMicromapModeSerializeExt = 1,
        CopyMicromapModeDeserializeExt = 2,
        CopyMicromapModeCompactExt = 3,
    }
    public enum VkBuildMicromapModeEXT : int
    {
        BuildMicromapModeBuildExt = 0,
    }
    public enum VkOpacityMicromapFormatEXT : int
    {
        OpacityMicromapFormat2StateExt = 1,
        OpacityMicromapFormat4StateExt = 2,
    }
    public enum VkOpacityMicromapSpecialIndexEXT : int
    {
        OpacityMicromapSpecialIndexFullyTransparentExt = -1,
        OpacityMicromapSpecialIndexFullyOpaqueExt = -2,
        OpacityMicromapSpecialIndexFullyUnknownTransparentExt = -3,
        OpacityMicromapSpecialIndexFullyUnknownOpaqueExt = -4,
    }
    public enum VkDepthBiasRepresentationEXT : int
    {
        DepthBiasRepresentationLeastRepresentableValueFormatExt = 0,
        DepthBiasRepresentationLeastRepresentableValueForceUnormExt = 1,
        DepthBiasRepresentationFloatExt = 2,
    }
    public enum VkDeviceFaultAddressTypeEXT : int
    {
        /// <summary>Currently unused</summary>
        DeviceFaultAddressTypeNoneExt = 0,
        DeviceFaultAddressTypeReadInvalidExt = 1,
        DeviceFaultAddressTypeWriteInvalidExt = 2,
        DeviceFaultAddressTypeExecuteInvalidExt = 3,
        DeviceFaultAddressTypeInstructionPointerUnknownExt = 4,
        DeviceFaultAddressTypeInstructionPointerInvalidExt = 5,
        DeviceFaultAddressTypeInstructionPointerFaultExt = 6,
    }
    public enum VkDeviceFaultVendorBinaryHeaderVersionEXT : int
    {
        DeviceFaultVendorBinaryHeaderVersionOneExt = 1,
    }
    public enum VkDisplacementMicromapFormatNV : int
    {
        DisplacementMicromapFormat64Triangles64BytesNv = 1,
        DisplacementMicromapFormat256Triangles128BytesNv = 2,
        DisplacementMicromapFormat1024Triangles128BytesNv = 3,
    }
    [Flags]
    public enum VkShaderCreateFlagBitsEXT : int
    {
        ShaderCreateLinkStageBitExt = 1,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        ShaderCreateAllowVaryingSubgroupSizeBitExt = 2,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        ShaderCreateRequireFullSubgroupsBitExt = 4,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        ShaderCreateNoTaskShaderBitExt = 8,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        ShaderCreateDispatchBaseBitExt = 16,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        ShaderCreateFragmentShadingRateAttachmentBitExt = 32,
        /// <summary>[requires: VK_EXT_shader_object]</summary>
        ShaderCreateFragmentDensityMapAttachmentBitExt = 64,
    }
    public enum VkShaderCodeTypeEXT : int
    {
        ShaderCodeTypeBinaryExt = 0,
        ShaderCodeTypeSpirvExt = 1,
    }
    public enum VkScopeKHR : int
    {
        ScopeDeviceKhr = 1,
        ScopeWorkgroupKhr = 2,
        ScopeSubgroupKhr = 3,
        ScopeQueueFamilyKhr = 5,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ScopeDeviceNv = 1,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ScopeWorkgroupNv = 2,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ScopeSubgroupNv = 3,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ScopeQueueFamilyNv = 5,
    }
    public enum VkComponentTypeKHR : int
    {
        ComponentTypeFloat16Khr = 0,
        ComponentTypeFloat32Khr = 1,
        ComponentTypeFloat64Khr = 2,
        ComponentTypeSint8Khr = 3,
        ComponentTypeSint16Khr = 4,
        ComponentTypeSint32Khr = 5,
        ComponentTypeSint64Khr = 6,
        ComponentTypeUint8Khr = 7,
        ComponentTypeUint16Khr = 8,
        ComponentTypeUint32Khr = 9,
        ComponentTypeUint64Khr = 10,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ComponentTypeFloat16Nv = 0,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ComponentTypeFloat32Nv = 1,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ComponentTypeFloat64Nv = 2,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ComponentTypeSint8Nv = 3,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ComponentTypeSint16Nv = 4,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ComponentTypeSint32Nv = 5,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ComponentTypeSint64Nv = 6,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ComponentTypeUint8Nv = 7,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ComponentTypeUint16Nv = 8,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ComponentTypeUint32Nv = 9,
        /// <summary>[requires: VK_NV_cooperative_matrix]</summary>
        ComponentTypeUint64Nv = 10,
    }
    public enum VkCubicFilterWeightsQCOM : int
    {
        CubicFilterWeightsCatmullRomQcom = 0,
        CubicFilterWeightsZeroTangentCardinalQcom = 1,
        CubicFilterWeightsBSplineQcom = 2,
        CubicFilterWeightsMitchellNetravaliQcom = 3,
    }
    public enum VkBlockMatchWindowCompareModeQCOM : int
    {
        BlockMatchWindowCompareModeMinQcom = 0,
        BlockMatchWindowCompareModeMaxQcom = 1,
    }
    public enum VkPhysicalDeviceLayeredApiKHR : int
    {
        PhysicalDeviceLayeredApiVulkanKhr = 0,
        PhysicalDeviceLayeredApiD3d12Khr = 1,
        PhysicalDeviceLayeredApiMetalKhr = 2,
        PhysicalDeviceLayeredApiOpenglKhr = 3,
        PhysicalDeviceLayeredApiOpenglesKhr = 4,
    }
    public enum VkLayeredDriverUnderlyingApiMSFT : int
    {
        LayeredDriverUnderlyingApiNoneMsft = 0,
        LayeredDriverUnderlyingApiD3d12Msft = 1,
    }
    public enum VkLatencyMarkerNV : int
    {
        LatencyMarkerSimulationStartNv = 0,
        LatencyMarkerSimulationEndNv = 1,
        LatencyMarkerRendersubmitStartNv = 2,
        LatencyMarkerRendersubmitEndNv = 3,
        LatencyMarkerPresentStartNv = 4,
        LatencyMarkerPresentEndNv = 5,
        LatencyMarkerInputSampleNv = 6,
        LatencyMarkerTriggerFlashNv = 7,
        LatencyMarkerOutOfBandRendersubmitStartNv = 8,
        LatencyMarkerOutOfBandRendersubmitEndNv = 9,
        LatencyMarkerOutOfBandPresentStartNv = 10,
        LatencyMarkerOutOfBandPresentEndNv = 11,
    }
    public enum VkOutOfBandQueueTypeNV : int
    {
        OutOfBandQueueTypeRenderNv = 0,
        OutOfBandQueueTypePresentNv = 1,
    }
    [Flags]
    public enum VkMemoryUnmapFlagBitsKHR : int
    {
        /// <summary>[requires: VK_EXT_map_memory_placed]</summary>
        MemoryUnmapReserveBitExt = 1,
    }
    [Flags]
    public enum VkQueryPoolCreateFlags : int
    {
    }
    [Flags]
    public enum VkPipelineDynamicStateCreateFlags : int
    {
    }
    [Flags]
    public enum VkPipelineMultisampleStateCreateFlags : int
    {
    }
    [Flags]
    public enum VkPipelineRasterizationStateCreateFlags : int
    {
    }
    [Flags]
    public enum VkPipelineViewportStateCreateFlags : int
    {
    }
    [Flags]
    public enum VkPipelineTessellationStateCreateFlags : int
    {
    }
    [Flags]
    public enum VkPipelineInputAssemblyStateCreateFlags : int
    {
    }
    [Flags]
    public enum VkPipelineVertexInputStateCreateFlags : int
    {
    }
    [Flags]
    public enum VkBufferViewCreateFlags : int
    {
    }
    [Flags]
    public enum VkDeviceCreateFlags : int
    {
    }
    [Flags]
    public enum VkSemaphoreCreateFlags : int
    {
    }
    [Flags]
    public enum VkShaderModuleCreateFlags : int
    {
    }
    [Flags]
    public enum VkDescriptorPoolResetFlags : int
    {
    }
    [Flags]
    public enum VkGeometryFlagsNV : int
    {
    }
    [Flags]
    public enum VkGeometryInstanceFlagsNV : int
    {
    }
    [Flags]
    public enum VkBuildAccelerationStructureFlagsNV : int
    {
    }
    [Flags]
    public enum VkPrivateDataSlotCreateFlags : int
    {
    }
    [Flags]
    public enum VkPrivateDataSlotCreateFlagsEXT : int
    {
    }
    [Flags]
    public enum VkDescriptorUpdateTemplateCreateFlags : int
    {
    }
    [Flags]
    public enum VkDescriptorUpdateTemplateCreateFlagsKHR : int
    {
    }
    [Flags]
    public enum VkPipelineCreationFeedbackFlagsEXT : int
    {
    }
    [Flags]
    public enum VkSemaphoreWaitFlagsKHR : int
    {
    }
    [Flags]
    public enum VkAccessFlags2 : int
    {
    }
    [Flags]
    public enum VkAccessFlags2KHR : int
    {
    }
    [Flags]
    public enum VkPipelineStageFlags2 : int
    {
    }
    [Flags]
    public enum VkPipelineStageFlags2KHR : int
    {
    }
    [Flags]
    public enum VkAccelerationStructureMotionInfoFlagsNV : int
    {
    }
    [Flags]
    public enum VkAccelerationStructureMotionInstanceFlagsNV : int
    {
    }
    [Flags]
    public enum VkFormatFeatureFlags2 : int
    {
    }
    [Flags]
    public enum VkFormatFeatureFlags2KHR : int
    {
    }
    [Flags]
    public enum VkMemoryDecompressionMethodFlagsNV : int
    {
    }
    [Flags]
    public enum VkRenderingFlagsKHR : int
    {
    }
    [Flags]
    public enum VkDirectDriverLoadingFlagsLUNARG : int
    {
    }
    [Flags]
    public enum VkPipelineCreateFlags2KHR : int
    {
    }
    [Flags]
    public enum VkBufferUsageFlags2KHR : int
    {
    }
    [Flags]
    public enum VkDisplayModeCreateFlagsKHR : int
    {
    }
    [Flags]
    public enum VkDisplaySurfaceCreateFlagsKHR : int
    {
    }
    [Flags]
    public enum VkAndroidSurfaceCreateFlagsKHR : int
    {
    }
    [Flags]
    public enum VkViSurfaceCreateFlagsNN : int
    {
    }
    [Flags]
    public enum VkWaylandSurfaceCreateFlagsKHR : int
    {
    }
    [Flags]
    public enum VkWin32SurfaceCreateFlagsKHR : int
    {
    }
    [Flags]
    public enum VkXlibSurfaceCreateFlagsKHR : int
    {
    }
    [Flags]
    public enum VkXcbSurfaceCreateFlagsKHR : int
    {
    }
    [Flags]
    public enum VkDirectFBSurfaceCreateFlagsEXT : int
    {
    }
    [Flags]
    public enum VkIOSSurfaceCreateFlagsMVK : int
    {
    }
    [Flags]
    public enum VkMacOSSurfaceCreateFlagsMVK : int
    {
    }
    [Flags]
    public enum VkMetalSurfaceCreateFlagsEXT : int
    {
    }
    [Flags]
    public enum VkImagePipeSurfaceCreateFlagsFUCHSIA : int
    {
    }
    [Flags]
    public enum VkStreamDescriptorSurfaceCreateFlagsGGP : int
    {
    }
    [Flags]
    public enum VkHeadlessSurfaceCreateFlagsEXT : int
    {
    }
    [Flags]
    public enum VkScreenSurfaceCreateFlagsQNX : int
    {
    }
    [Flags]
    public enum VkPeerMemoryFeatureFlagsKHR : int
    {
    }
    [Flags]
    public enum VkMemoryAllocateFlagsKHR : int
    {
    }
    [Flags]
    public enum VkCommandPoolTrimFlags : int
    {
    }
    [Flags]
    public enum VkCommandPoolTrimFlagsKHR : int
    {
    }
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagsKHR : int
    {
    }
    [Flags]
    public enum VkExternalMemoryFeatureFlagsKHR : int
    {
    }
    [Flags]
    public enum VkExternalSemaphoreHandleTypeFlagsKHR : int
    {
    }
    [Flags]
    public enum VkExternalSemaphoreFeatureFlagsKHR : int
    {
    }
    [Flags]
    public enum VkSemaphoreImportFlagsKHR : int
    {
    }
    [Flags]
    public enum VkExternalFenceHandleTypeFlagsKHR : int
    {
    }
    [Flags]
    public enum VkExternalFenceFeatureFlagsKHR : int
    {
    }
    [Flags]
    public enum VkFenceImportFlagsKHR : int
    {
    }
    [Flags]
    public enum VkPipelineViewportSwizzleStateCreateFlagsNV : int
    {
    }
    [Flags]
    public enum VkPipelineDiscardRectangleStateCreateFlagsEXT : int
    {
    }
    [Flags]
    public enum VkPipelineCoverageToColorStateCreateFlagsNV : int
    {
    }
    [Flags]
    public enum VkPipelineCoverageModulationStateCreateFlagsNV : int
    {
    }
    [Flags]
    public enum VkPipelineCoverageReductionStateCreateFlagsNV : int
    {
    }
    [Flags]
    public enum VkValidationCacheCreateFlagsEXT : int
    {
    }
    [Flags]
    public enum VkDebugUtilsMessengerCreateFlagsEXT : int
    {
    }
    [Flags]
    public enum VkDebugUtilsMessengerCallbackDataFlagsEXT : int
    {
    }
    [Flags]
    public enum VkDeviceMemoryReportFlagsEXT : int
    {
    }
    [Flags]
    public enum VkPipelineRasterizationConservativeStateCreateFlagsEXT : int
    {
    }
    [Flags]
    public enum VkDescriptorBindingFlagsEXT : int
    {
    }
    [Flags]
    public enum VkResolveModeFlagsKHR : int
    {
    }
    [Flags]
    public enum VkPipelineRasterizationStateStreamCreateFlagsEXT : int
    {
    }
    [Flags]
    public enum VkPipelineRasterizationDepthClipStateCreateFlagsEXT : int
    {
    }
    [Flags]
    public enum VkToolPurposeFlagsEXT : int
    {
    }
    [Flags]
    public enum VkSubmitFlagsKHR : int
    {
    }
    [Flags]
    public enum VkImageFormatConstraintsFlagsFUCHSIA : int
    {
    }
    [Flags]
    public enum VkPhysicalDeviceSchedulingControlsFlagsARM : int
    {
    }
    [Flags]
    public enum VkVideoSessionParametersCreateFlagsKHR : int
    {
    }
    [Flags]
    public enum VkVideoBeginCodingFlagsKHR : int
    {
    }
    [Flags]
    public enum VkVideoEndCodingFlagsKHR : int
    {
    }
    [Flags]
    public enum VkVideoDecodeFlagsKHR : int
    {
    }
    [Flags]
    public enum VkVideoEncodeRateControlFlagsKHR : int
    {
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
