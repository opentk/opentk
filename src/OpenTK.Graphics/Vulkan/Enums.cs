// This file is auto generated, do not edit.
using System;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum VkImageLayout : int
    {
        ImageLayoutUndefined = 0,
        ImageLayoutGeneral = 1,
        ImageLayoutColorAttachmentOptimal = 2,
        ImageLayoutDepthStencilAttachmentOptimal = 3,
        ImageLayoutDepthStencilReadOnlyOptimal = 4,
        ImageLayoutShaderReadOnlyOptimal = 5,
        ImageLayoutTransferSrcOptimal = 6,
        ImageLayoutTransferDstOptimal = 7,
        ImageLayoutPreinitialized = 8,
    }
    public enum VkAttachmentLoadOp : int
    {
        AttachmentLoadOpLoad = 0,
        AttachmentLoadOpClear = 1,
        AttachmentLoadOpDontCare = 2,
    }
    public enum VkAttachmentStoreOp : int
    {
        AttachmentStoreOpStore = 0,
        AttachmentStoreOpDontCare = 1,
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
    }
    public enum VkQueryType : int
    {
        QueryTypeOcclusion = 0,
        QueryTypePipelineStatistics = 1,
        QueryTypeTimestamp = 2,
    }
    public enum VkBorderColor : int
    {
        BorderColorFloatTransparentBlack = 0,
        BorderColorIntTransparentBlack = 1,
        BorderColorFloatOpaqueBlack = 2,
        BorderColorIntOpaqueBlack = 3,
        BorderColorFloatOpaqueWhite = 4,
        BorderColorIntOpaqueWhite = 5,
    }
    public enum VkPipelineBindPoint : int
    {
        PipelineBindPointGraphics = 0,
        PipelineBindPointCompute = 1,
    }
    public enum VkPipelineCacheHeaderVersion : int
    {
        PipelineCacheHeaderVersionOne = 1,
    }
    [Flags]
    public enum VkPipelineCacheCreateFlagBits : int
    {
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
    }
    public enum VkFilter : int
    {
        FilterNearest = 0,
        FilterLinear = 1,
    }
    public enum VkSamplerMipmapMode : int
    {
        SamplerMipmapModeNearest = 0,
        SamplerMipmapModeLinear = 1,
    }
    public enum VkSamplerAddressMode : int
    {
        SamplerAddressModeRepeat = 0,
        SamplerAddressModeMirroredRepeat = 1,
        SamplerAddressModeClampToEdge = 2,
        SamplerAddressModeClampToBorder = 3,
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
        StructureTypeLoaderInstanceCreateInfo = 47,
        StructureTypeLoaderDeviceCreateInfo = 48,
    }
    public enum VkSubpassContents : int
    {
        SubpassContentsInline = 0,
        SubpassContentsSecondaryCommandBuffers = 1,
    }
    public enum VkResult : int
    {
        Success = 0,
        NotReady = 1,
        Timeout = 2,
        EventSet = 3,
        EventReset = 4,
        Incomplete = 5,
        ErrorOutOfHostMemory = -1,
        ErrorOutOfDeviceMemory = -2,
        ErrorInitializationFailed = -3,
        ErrorDeviceLost = -4,
        ErrorMemoryMapFailed = -5,
        ErrorLayerNotPresent = -6,
        ErrorExtensionNotPresent = -7,
        ErrorFeatureNotPresent = -8,
        ErrorIncompatibleDriver = -9,
        ErrorTooManyObjects = -10,
        ErrorFormatNotSupported = -11,
        ErrorFragmentedPool = -12,
        ErrorUnknown = -13,
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
    }
    public enum VkDescriptorUpdateTemplateType : int
    {
        DescriptorUpdateTemplateTypeDescriptorSet = 0,
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
        QueueGraphicsBit = 1,
        QueueComputeBit = 2,
        QueueTransferBit = 4,
        QueueSparseBindingBit = 8,
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
    }
    [Flags]
    public enum VkDeviceQueueCreateFlagBits : int
    {
    }
    [Flags]
    public enum VkMemoryPropertyFlagBits : int
    {
        MemoryPropertyDeviceLocalBit = 1,
        MemoryPropertyHostVisibleBit = 2,
        MemoryPropertyHostCoherentBit = 4,
        MemoryPropertyHostCachedBit = 8,
        MemoryPropertyLazilyAllocatedBit = 16,
    }
    [Flags]
    public enum VkMemoryHeapFlagBits : int
    {
        MemoryHeapDeviceLocalBit = 1,
    }
    [Flags]
    public enum VkAccessFlagBits : int
    {
        AccessIndirectCommandReadBit = 1,
        AccessIndexReadBit = 2,
        AccessVertexAttributeReadBit = 4,
        AccessUniformReadBit = 8,
        AccessInputAttachmentReadBit = 16,
        AccessShaderReadBit = 32,
        AccessShaderWriteBit = 64,
        AccessColorAttachmentReadBit = 128,
        AccessColorAttachmentWriteBit = 256,
        AccessDepthStencilAttachmentReadBit = 512,
        AccessDepthStencilAttachmentWriteBit = 1024,
        AccessTransferReadBit = 2048,
        AccessTransferWriteBit = 4096,
        AccessHostReadBit = 8192,
        AccessHostWriteBit = 16384,
        AccessMemoryReadBit = 32768,
        AccessMemoryWriteBit = 65536,
    }
    [Flags]
    public enum VkBufferUsageFlagBits : int
    {
        BufferUsageTransferSrcBit = 1,
        BufferUsageTransferDstBit = 2,
        BufferUsageUniformTexelBufferBit = 4,
        BufferUsageStorageTexelBufferBit = 8,
        BufferUsageUniformBufferBit = 16,
        BufferUsageStorageBufferBit = 32,
        BufferUsageIndexBufferBit = 64,
        BufferUsageVertexBufferBit = 128,
        BufferUsageIndirectBufferBit = 256,
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
    }
    [Flags]
    public enum VkBufferCreateFlagBits : int
    {
        BufferCreateSparseBindingBit = 1,
        BufferCreateSparseResidencyBit = 2,
        BufferCreateSparseAliasedBit = 4,
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
    }
    [Flags]
    public enum VkImageUsageFlagBits : int
    {
        ImageUsageTransferSrcBit = 1,
        ImageUsageTransferDstBit = 2,
        ImageUsageSampledBit = 4,
        ImageUsageStorageBit = 8,
        ImageUsageColorAttachmentBit = 16,
        ImageUsageDepthStencilAttachmentBit = 32,
        ImageUsageTransientAttachmentBit = 64,
        ImageUsageInputAttachmentBit = 128,
    }
    [Flags]
    public enum VkImageCreateFlagBits : int
    {
        ImageCreateSparseBindingBit = 1,
        ImageCreateSparseResidencyBit = 2,
        ImageCreateSparseAliasedBit = 4,
        ImageCreateMutableFormatBit = 8,
        ImageCreateCubeCompatibleBit = 16,
    }
    [Flags]
    public enum VkImageViewCreateFlagBits : int
    {
    }
    [Flags]
    public enum VkSamplerCreateFlagBits : int
    {
    }
    [Flags]
    public enum VkPipelineCreateFlagBits : int
    {
        PipelineCreateDisableOptimizationBit = 1,
        PipelineCreateAllowDerivativesBit = 2,
        PipelineCreateDerivativeBit = 4,
    }
    [Flags]
    public enum VkPipelineCreateFlagBits2KHR : int
    {
        PipelineCreate2DisableOptimizationBitKhr = 1,
        PipelineCreate2AllowDerivativesBitKhr = 2,
        PipelineCreate2DerivativeBitKhr = 4,
    }
    [Flags]
    public enum VkPipelineShaderStageCreateFlagBits : int
    {
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
        FormatFeatureSampledImageBit = 1,
        FormatFeatureStorageImageBit = 2,
        FormatFeatureStorageImageAtomicBit = 4,
        FormatFeatureUniformTexelBufferBit = 8,
        FormatFeatureStorageTexelBufferBit = 16,
        FormatFeatureStorageTexelBufferAtomicBit = 32,
        FormatFeatureVertexBufferBit = 64,
        FormatFeatureColorAttachmentBit = 128,
        FormatFeatureColorAttachmentBlendBit = 256,
        FormatFeatureDepthStencilAttachmentBit = 512,
        FormatFeatureBlitSrcBit = 1024,
        FormatFeatureBlitDstBit = 2048,
        FormatFeatureSampledImageFilterLinearBit = 4096,
    }
    [Flags]
    public enum VkQueryControlFlagBits : int
    {
        QueryControlPreciseBit = 1,
    }
    [Flags]
    public enum VkQueryResultFlagBits : int
    {
        QueryResult64Bit = 1,
        QueryResultWaitBit = 2,
        QueryResultWithAvailabilityBit = 4,
        QueryResultPartialBit = 8,
    }
    [Flags]
    public enum VkCommandBufferUsageFlagBits : int
    {
        CommandBufferUsageOneTimeSubmitBit = 1,
        CommandBufferUsageRenderPassContinueBit = 2,
        CommandBufferUsageSimultaneousUseBit = 4,
    }
    [Flags]
    public enum VkQueryPipelineStatisticFlagBits : int
    {
        QueryPipelineStatisticInputAssemblyVerticesBit = 1,
        QueryPipelineStatisticInputAssemblyPrimitivesBit = 2,
        QueryPipelineStatisticVertexShaderInvocationsBit = 4,
        QueryPipelineStatisticGeometryShaderInvocationsBit = 8,
        QueryPipelineStatisticGeometryShaderPrimitivesBit = 16,
        QueryPipelineStatisticClippingInvocationsBit = 32,
        QueryPipelineStatisticClippingPrimitivesBit = 64,
        QueryPipelineStatisticFragmentShaderInvocationsBit = 128,
        QueryPipelineStatisticTessellationControlShaderPatchesBit = 256,
        QueryPipelineStatisticTessellationEvaluationShaderInvocationsBit = 512,
        QueryPipelineStatisticComputeShaderInvocationsBit = 1024,
    }
    [Flags]
    public enum VkMemoryMapFlagBits : int
    {
    }
    [Flags]
    public enum VkImageAspectFlagBits : int
    {
        ImageAspectColorBit = 1,
        ImageAspectDepthBit = 2,
        ImageAspectStencilBit = 4,
        ImageAspectMetadataBit = 8,
    }
    [Flags]
    public enum VkSparseImageFormatFlagBits : int
    {
        SparseImageFormatSingleMiptailBit = 1,
        SparseImageFormatAlignedMipSizeBit = 2,
        SparseImageFormatNonstandardBlockSizeBit = 4,
    }
    [Flags]
    public enum VkSparseMemoryBindFlagBits : int
    {
        SparseMemoryBindMetadataBit = 1,
    }
    [Flags]
    public enum VkPipelineStageFlagBits : int
    {
        PipelineStageTopOfPipeBit = 1,
        PipelineStageDrawIndirectBit = 2,
        PipelineStageVertexInputBit = 4,
        PipelineStageVertexShaderBit = 8,
        PipelineStageTessellationControlShaderBit = 16,
        PipelineStageTessellationEvaluationShaderBit = 32,
        PipelineStageGeometryShaderBit = 64,
        PipelineStageFragmentShaderBit = 128,
        PipelineStageEarlyFragmentTestsBit = 256,
        PipelineStageLateFragmentTestsBit = 512,
        PipelineStageColorAttachmentOutputBit = 1024,
        PipelineStageComputeShaderBit = 2048,
        PipelineStageTransferBit = 4096,
        PipelineStageBottomOfPipeBit = 8192,
        PipelineStageHostBit = 16384,
        PipelineStageAllGraphicsBit = 32768,
        PipelineStageAllCommandsBit = 65536,
    }
    [Flags]
    public enum VkCommandPoolCreateFlagBits : int
    {
        CommandPoolCreateTransientBit = 1,
        CommandPoolCreateResetCommandBufferBit = 2,
    }
    [Flags]
    public enum VkCommandPoolResetFlagBits : int
    {
        CommandPoolResetReleaseResourcesBit = 1,
    }
    [Flags]
    public enum VkCommandBufferResetFlagBits : int
    {
        CommandBufferResetReleaseResourcesBit = 1,
    }
    [Flags]
    public enum VkSampleCountFlagBits : int
    {
        SampleCount1Bit = 1,
        SampleCount2Bit = 2,
        SampleCount4Bit = 4,
        SampleCount8Bit = 8,
        SampleCount16Bit = 16,
        SampleCount32Bit = 32,
        SampleCount64Bit = 64,
    }
    [Flags]
    public enum VkAttachmentDescriptionFlagBits : int
    {
        AttachmentDescriptionMayAliasBit = 1,
    }
    [Flags]
    public enum VkStencilFaceFlagBits : int
    {
        StencilFaceFrontBit = 1,
        StencilFaceBackBit = 2,
        StencilFaceFrontAndBack = 3,
        StencilFrontAndBack = 3,
    }
    [Flags]
    public enum VkDescriptorPoolCreateFlagBits : int
    {
        DescriptorPoolCreateFreeDescriptorSetBit = 1,
    }
    [Flags]
    public enum VkDependencyFlagBits : int
    {
        DependencyByRegionBit = 1,
    }
    public enum VkSemaphoreType : int
    {
        SemaphoreTypeBinary = 0,
        SemaphoreTypeTimeline = 1,
    }
    [Flags]
    public enum VkSemaphoreWaitFlagBits : int
    {
        SemaphoreWaitAnyBit = 1,
    }
    public enum VkPresentModeKHR : int
    {
        PresentModeImmediateKhr = 0,
        PresentModeMailboxKhr = 1,
        PresentModeFifoKhr = 2,
        PresentModeFifoRelaxedKhr = 3,
    }
    public enum VkColorSpaceKHR : int
    {
        ColorSpaceSrgbNonlinearKhr = 0,
        ColorspaceSrgbNonlinearKhr = 0,
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
        SubgroupFeatureBasicBit = 1,
        SubgroupFeatureVoteBit = 2,
        SubgroupFeatureArithmeticBit = 4,
        SubgroupFeatureBallotBit = 8,
        SubgroupFeatureShuffleBit = 16,
        SubgroupFeatureShuffleRelativeBit = 32,
        SubgroupFeatureClusteredBit = 64,
        SubgroupFeatureQuadBit = 128,
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
    }
    [Flags]
    public enum VkPrivateDataSlotCreateFlagBits : int
    {
    }
    [Flags]
    public enum VkDescriptorSetLayoutCreateFlagBits : int
    {
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
    }
    [Flags]
    public enum VkExternalMemoryFeatureFlagBits : int
    {
        ExternalMemoryFeatureDedicatedOnlyBit = 1,
        ExternalMemoryFeatureExportableBit = 2,
        ExternalMemoryFeatureImportableBit = 4,
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
    }
    [Flags]
    public enum VkExternalSemaphoreFeatureFlagBits : int
    {
        ExternalSemaphoreFeatureExportableBit = 1,
        ExternalSemaphoreFeatureImportableBit = 2,
    }
    [Flags]
    public enum VkSemaphoreImportFlagBits : int
    {
        SemaphoreImportTemporaryBit = 1,
    }
    [Flags]
    public enum VkExternalFenceHandleTypeFlagBits : int
    {
        ExternalFenceHandleTypeOpaqueFdBit = 1,
        ExternalFenceHandleTypeOpaqueWin32Bit = 2,
        ExternalFenceHandleTypeOpaqueWin32KmtBit = 4,
        ExternalFenceHandleTypeSyncFdBit = 8,
    }
    [Flags]
    public enum VkExternalFenceFeatureFlagBits : int
    {
        ExternalFenceFeatureExportableBit = 1,
        ExternalFenceFeatureImportableBit = 2,
    }
    [Flags]
    public enum VkFenceImportFlagBits : int
    {
        FenceImportTemporaryBit = 1,
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
        PeerMemoryFeatureCopySrcBit = 1,
        PeerMemoryFeatureCopyDstBit = 2,
        PeerMemoryFeatureGenericSrcBit = 4,
        PeerMemoryFeatureGenericDstBit = 8,
    }
    [Flags]
    public enum VkMemoryAllocateFlagBits : int
    {
        MemoryAllocateDeviceMaskBit = 1,
    }
    [Flags]
    public enum VkDeviceGroupPresentModeFlagBitsKHR : int
    {
        DeviceGroupPresentModeLocalBitKhr = 1,
        DeviceGroupPresentModeRemoteBitKhr = 2,
        DeviceGroupPresentModeSumBitKhr = 4,
        DeviceGroupPresentModeLocalMultiDeviceBitKhr = 8,
    }
    [Flags]
    public enum VkSwapchainCreateFlagBitsKHR : int
    {
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
    }
    public enum VkPointClippingBehavior : int
    {
        PointClippingBehaviorAllClipPlanes = 0,
        PointClippingBehaviorUserClipPlanesOnly = 1,
    }
    public enum VkSamplerReductionMode : int
    {
        SamplerReductionModeWeightedAverage = 0,
        SamplerReductionModeMin = 1,
        SamplerReductionModeMax = 2,
    }
    public enum VkTessellationDomainOrigin : int
    {
        TessellationDomainOriginUpperLeft = 0,
        TessellationDomainOriginLowerLeft = 1,
    }
    public enum VkSamplerYcbcrModelConversion : int
    {
        SamplerYcbcrModelConversionRgbIdentity = 0,
        SamplerYcbcrModelConversionYcbcrIdentity = 1,
        SamplerYcbcrModelConversionYcbcr709 = 2,
        SamplerYcbcrModelConversionYcbcr601 = 3,
        SamplerYcbcrModelConversionYcbcr2020 = 4,
    }
    public enum VkSamplerYcbcrRange : int
    {
        SamplerYcbcrRangeItuFull = 0,
        SamplerYcbcrRangeItuNarrow = 1,
    }
    public enum VkChromaLocation : int
    {
        ChromaLocationCositedEven = 0,
        ChromaLocationMidpoint = 1,
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
    }
    public enum VkVendorId : int
    {
        VendorIdKhronos = 65536,
        VendorIdViv = 65537,
        VendorIdVsi = 65538,
        VendorIdKazan = 65539,
        VendorIdCodeplay = 65540,
        VendorIdMesa = 65541,
        VendorIdPocl = 65542,
        VendorIdMobileye = 65543,
    }
    public enum VkDriverId : int
    {
        DriverIdAmdProprietary = 1,
        DriverIdAmdOpenSource = 2,
        DriverIdMesaRadv = 3,
        DriverIdNvidiaProprietary = 4,
        DriverIdIntelProprietaryWindows = 5,
        DriverIdIntelOpenSourceMesa = 6,
        DriverIdImaginationProprietary = 7,
        DriverIdQualcommProprietary = 8,
        DriverIdArmProprietary = 9,
        DriverIdGoogleSwiftshader = 10,
        DriverIdGgpProprietary = 11,
        DriverIdBroadcomProprietary = 12,
        DriverIdMesaLlvmpipe = 13,
        DriverIdMoltenvk = 14,
        DriverIdCoreaviProprietary = 15,
        DriverIdJuiceProprietary = 16,
        DriverIdVerisiliconProprietary = 17,
        DriverIdMesaTurnip = 18,
        DriverIdMesaV3dv = 19,
        DriverIdMesaPanvk = 20,
        DriverIdSamsungProprietary = 21,
        DriverIdMesaVenus = 22,
        DriverIdMesaDozen = 23,
        DriverIdMesaNvk = 24,
        DriverIdImaginationOpenSourceMesa = 25,
        DriverIdMesaHoneykrisp = 26,
        DriverIdReserved27 = 27,
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
    }
    [Flags]
    public enum VkGeometryFlagBitsKHR : int
    {
        GeometryOpaqueBitKhr = 1,
        GeometryNoDuplicateAnyHitInvocationBitKhr = 2,
    }
    [Flags]
    public enum VkBuildAccelerationStructureFlagBitsKHR : int
    {
        BuildAccelerationStructureAllowUpdateBitKhr = 1,
        BuildAccelerationStructureAllowCompactionBitKhr = 2,
        BuildAccelerationStructurePreferFastTraceBitKhr = 4,
        BuildAccelerationStructurePreferFastBuildBitKhr = 8,
        BuildAccelerationStructureLowMemoryBitKhr = 16,
    }
    [Flags]
    public enum VkAccelerationStructureCreateFlagBitsKHR : int
    {
        AccelerationStructureCreateDeviceAddressCaptureReplayBitKhr = 1,
    }
    public enum VkCopyAccelerationStructureModeKHR : int
    {
        CopyAccelerationStructureModeCloneKhr = 0,
        CopyAccelerationStructureModeCompactKhr = 1,
        CopyAccelerationStructureModeSerializeKhr = 2,
        CopyAccelerationStructureModeDeserializeKhr = 3,
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
    }
    public enum VkGeometryTypeKHR : int
    {
        GeometryTypeTrianglesKhr = 0,
        GeometryTypeAabbsKhr = 1,
        GeometryTypeInstancesKhr = 2,
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
    }
    [Flags]
    public enum VkPipelineLayoutCreateFlagBits : int
    {
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
    }
    [Flags]
    public enum VkPipelineDepthStencilStateCreateFlagBits : int
    {
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
    }
    public enum VkQueryResultStatusKHR : int
    {
        QueryResultStatusErrorKhr = -1,
        QueryResultStatusNotReadyKhr = 0,
        QueryResultStatusCompleteKhr = 1,
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
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
