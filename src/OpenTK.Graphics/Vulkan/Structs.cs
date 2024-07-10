// This file is auto generated, do not edit.
using OpenTK.Mathematics;
using OpenTK.Graphics.Vulkan.VideoCodecH264;
using OpenTK.Graphics.Vulkan.VideoCodecH264.Decode;
using OpenTK.Graphics.Vulkan.VideoCodecH264.Encode;
using OpenTK.Graphics.Vulkan.VideoCodecH265;
using OpenTK.Graphics.Vulkan.VideoCodecH265.Decode;
using OpenTK.Graphics.Vulkan.VideoCodecH265.Encode;
using OpenTK.Graphics.Vulkan.VideoCodecAV1;
using OpenTK.Graphics.Vulkan.VideoCodecAV1.Decode;
using System;
using System.Runtime.CompilerServices;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public unsafe struct VkBaseOutStructure
    {
        public VkStructureType sType;
        public VkBaseOutStructure* pNext;
    }
    public unsafe struct VkBaseInStructure
    {
        public VkStructureType sType;
        public VkBaseInStructure* pNext;
    }
    public unsafe struct VkOffset2D
    {
        public int x;
        public int y;
    }
    public unsafe struct VkOffset3D
    {
        public int x;
        public int y;
        public int z;
    }
    public unsafe struct VkExtent2D
    {
        public uint width;
        public uint height;
    }
    public unsafe struct VkExtent3D
    {
        public uint width;
        public uint height;
        public uint depth;
    }
    public unsafe struct VkViewport
    {
        public float x;
        public float y;
        public float width;
        public float height;
        public float minDepth;
        public float maxDepth;
    }
    public unsafe struct VkRect2D
    {
        public VkOffset2D offset;
        public VkExtent2D extent;
    }
    public unsafe struct VkClearRect
    {
        public VkRect2D rect;
        public uint baseArrayLayer;
        public uint layerCount;
    }
    public unsafe struct VkComponentMapping
    {
        public VkComponentSwizzle r;
        public VkComponentSwizzle g;
        public VkComponentSwizzle b;
        public VkComponentSwizzle a;
    }
    public unsafe struct VkPhysicalDeviceProperties
    {
        public uint apiVersion;
        public uint driverVersion;
        public uint vendorID;
        public uint deviceID;
        public VkPhysicalDeviceType deviceType;
        [InlineArray(256)]
        public struct deviceNameInlineArray
        {
            public byte element;
        }
        public deviceNameInlineArray deviceName;
        public fixed byte pipelineCacheUUID[16];
        public VkPhysicalDeviceLimits limits;
        public VkPhysicalDeviceSparseProperties sparseProperties;
    }
    public unsafe struct VkExtensionProperties
    {
        [InlineArray(256)]
        public struct extensionNameInlineArray
        {
            public byte element;
        }
        public extensionNameInlineArray extensionName;
        public uint specVersion;
    }
    public unsafe struct VkLayerProperties
    {
        [InlineArray(256)]
        public struct layerNameInlineArray
        {
            public byte element;
        }
        public layerNameInlineArray layerName;
        public uint specVersion;
        public uint implementationVersion;
        [InlineArray(256)]
        public struct descriptionInlineArray
        {
            public byte element;
        }
        public descriptionInlineArray description;
    }
    public unsafe struct VkApplicationInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pApplicationName;
        public uint applicationVersion;
        public byte* pEngineName;
        public uint engineVersion;
        public uint apiVersion;
    }
    public unsafe struct VkAllocationCallbacks
    {
        public void* pUserData;
        public IntPtr pfnAllocation;
        public IntPtr pfnReallocation;
        public IntPtr pfnFree;
        public IntPtr pfnInternalAllocation;
        public IntPtr pfnInternalFree;
    }
    public unsafe struct VkDeviceQueueCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceQueueCreateFlagBits flags;
        public uint queueFamilyIndex;
        public uint queueCount;
        public float* pQueuePriorities;
    }
    public unsafe struct VkDeviceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceCreateFlags flags;
        public uint queueCreateInfoCount;
        public VkDeviceQueueCreateInfo* pQueueCreateInfos;
        public uint enabledLayerCount;
        public byte** ppEnabledLayerNames;
        public uint enabledExtensionCount;
        public byte** ppEnabledExtensionNames;
        public VkPhysicalDeviceFeatures* pEnabledFeatures;
    }
    public unsafe struct VkInstanceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkInstanceCreateFlagBits flags;
        public VkApplicationInfo* pApplicationInfo;
        public uint enabledLayerCount;
        public byte** ppEnabledLayerNames;
        public uint enabledExtensionCount;
        public byte** ppEnabledExtensionNames;
    }
    public unsafe struct VkQueueFamilyProperties
    {
        public VkQueueFlagBits queueFlags;
        public uint queueCount;
        public uint timestampValidBits;
        public VkExtent3D minImageTransferGranularity;
    }
    public unsafe struct VkPhysicalDeviceMemoryProperties
    {
        public uint memoryTypeCount;
        [InlineArray(32)]
        public struct memoryTypesInlineArray
        {
            public VkMemoryType element;
        }
        public memoryTypesInlineArray memoryTypes;
        public uint memoryHeapCount;
        [InlineArray(16)]
        public struct memoryHeapsInlineArray
        {
            public VkMemoryHeap element;
        }
        public memoryHeapsInlineArray memoryHeaps;
    }
    public unsafe struct VkMemoryAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong allocationSize;
        public uint memoryTypeIndex;
    }
    public unsafe struct VkMemoryRequirements
    {
        public ulong size;
        public ulong alignment;
        public uint memoryTypeBits;
    }
    public unsafe struct VkSparseImageFormatProperties
    {
        public VkImageAspectFlagBits aspectMask;
        public VkExtent3D imageGranularity;
        public VkSparseImageFormatFlagBits flags;
    }
    public unsafe struct VkSparseImageMemoryRequirements
    {
        public VkSparseImageFormatProperties formatProperties;
        public uint imageMipTailFirstLod;
        public ulong imageMipTailSize;
        public ulong imageMipTailOffset;
        public ulong imageMipTailStride;
    }
    public unsafe struct VkMemoryType
    {
        public VkMemoryPropertyFlagBits propertyFlags;
        public uint heapIndex;
    }
    public unsafe struct VkMemoryHeap
    {
        public ulong size;
        public VkMemoryHeapFlagBits flags;
    }
    public unsafe struct VkMappedMemoryRange
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public ulong offset;
        public ulong size;
    }
    public unsafe struct VkFormatProperties
    {
        public VkFormatFeatureFlagBits linearTilingFeatures;
        public VkFormatFeatureFlagBits optimalTilingFeatures;
        public VkFormatFeatureFlagBits bufferFeatures;
    }
    public unsafe struct VkImageFormatProperties
    {
        public VkExtent3D maxExtent;
        public uint maxMipLevels;
        public uint maxArrayLayers;
        public VkSampleCountFlagBits sampleCounts;
        public ulong maxResourceSize;
    }
    public unsafe struct VkDescriptorBufferInfo
    {
        public VkBuffer buffer;
        public ulong offset;
        public ulong range;
    }
    public unsafe struct VkDescriptorImageInfo
    {
        public VkSampler sampler;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
    }
    public unsafe struct VkWriteDescriptorSet
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSet dstSet;
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public VkDescriptorType descriptorType;
        public VkDescriptorImageInfo* pImageInfo;
        public VkDescriptorBufferInfo* pBufferInfo;
        public VkBufferView* pTexelBufferView;
    }
    public unsafe struct VkCopyDescriptorSet
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSet srcSet;
        public uint srcBinding;
        public uint srcArrayElement;
        public VkDescriptorSet dstSet;
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
    }
    public unsafe struct VkBufferUsageFlags2CreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferUsageFlags2KHR usage;
    }
    public unsafe struct VkBufferCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCreateFlagBits flags;
        public ulong size;
        public VkBufferUsageFlagBits usage;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
    }
    public unsafe struct VkBufferViewCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferViewCreateFlags flags;
        public VkBuffer buffer;
        public VkFormat format;
        public ulong offset;
        public ulong range;
    }
    public unsafe struct VkImageSubresource
    {
        public VkImageAspectFlagBits aspectMask;
        public uint mipLevel;
        public uint arrayLayer;
    }
    public unsafe struct VkImageSubresourceLayers
    {
        public VkImageAspectFlagBits aspectMask;
        public uint mipLevel;
        public uint baseArrayLayer;
        public uint layerCount;
    }
    public unsafe struct VkImageSubresourceRange
    {
        public VkImageAspectFlagBits aspectMask;
        public uint baseMipLevel;
        public uint levelCount;
        public uint baseArrayLayer;
        public uint layerCount;
    }
    public unsafe struct VkMemoryBarrier
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccessFlagBits srcAccessMask;
        public VkAccessFlagBits dstAccessMask;
    }
    public unsafe struct VkBufferMemoryBarrier
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccessFlagBits srcAccessMask;
        public VkAccessFlagBits dstAccessMask;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
    }
    public unsafe struct VkImageMemoryBarrier
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccessFlagBits srcAccessMask;
        public VkAccessFlagBits dstAccessMask;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkImage image;
        public VkImageSubresourceRange subresourceRange;
    }
    public unsafe struct VkImageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateFlagBits flags;
        public VkImageType imageType;
        public VkFormat format;
        public VkExtent3D extent;
        public uint mipLevels;
        public uint arrayLayers;
        public VkSampleCountFlagBits samples;
        public VkImageTiling tiling;
        public VkImageUsageFlagBits usage;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public VkImageLayout initialLayout;
    }
    public unsafe struct VkSubresourceLayout
    {
        public ulong offset;
        public ulong size;
        public ulong rowPitch;
        public ulong arrayPitch;
        public ulong depthPitch;
    }
    public unsafe struct VkImageViewCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageViewCreateFlagBits flags;
        public VkImage image;
        public VkImageViewType viewType;
        public VkFormat format;
        public VkComponentMapping components;
        public VkImageSubresourceRange subresourceRange;
    }
    public unsafe struct VkBufferCopy
    {
        public ulong srcOffset;
        public ulong dstOffset;
        public ulong size;
    }
    public unsafe struct VkSparseMemoryBind
    {
        public ulong resourceOffset;
        public ulong size;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public VkSparseMemoryBindFlagBits flags;
    }
    public unsafe struct VkSparseImageMemoryBind
    {
        public VkImageSubresource subresource;
        public VkOffset3D offset;
        public VkExtent3D extent;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public VkSparseMemoryBindFlagBits flags;
    }
    public unsafe struct VkSparseBufferMemoryBindInfo
    {
        public VkBuffer buffer;
        public uint bindCount;
        public VkSparseMemoryBind* pBinds;
    }
    public unsafe struct VkSparseImageOpaqueMemoryBindInfo
    {
        public VkImage image;
        public uint bindCount;
        public VkSparseMemoryBind* pBinds;
    }
    public unsafe struct VkSparseImageMemoryBindInfo
    {
        public VkImage image;
        public uint bindCount;
        public VkSparseImageMemoryBind* pBinds;
    }
    public unsafe struct VkBindSparseInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreCount;
        public VkSemaphore* pWaitSemaphores;
        public uint bufferBindCount;
        public VkSparseBufferMemoryBindInfo* pBufferBinds;
        public uint imageOpaqueBindCount;
        public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
        public uint imageBindCount;
        public VkSparseImageMemoryBindInfo* pImageBinds;
        public uint signalSemaphoreCount;
        public VkSemaphore* pSignalSemaphores;
    }
    public unsafe struct VkImageCopy
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
    }
    public unsafe struct VkImageBlit
    {
        public VkImageSubresourceLayers srcSubresource;
        [InlineArray(2)]
        public struct srcOffsetsInlineArray
        {
            public VkOffset3D element;
        }
        public srcOffsetsInlineArray srcOffsets;
        public VkImageSubresourceLayers dstSubresource;
        [InlineArray(2)]
        public struct dstOffsetsInlineArray
        {
            public VkOffset3D element;
        }
        public dstOffsetsInlineArray dstOffsets;
    }
    public unsafe struct VkBufferImageCopy
    {
        public ulong bufferOffset;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
    }
    public unsafe struct VkCopyMemoryIndirectCommandNV
    {
        public ulong srcAddress;
        public ulong dstAddress;
        public ulong size;
    }
    public unsafe struct VkCopyMemoryToImageIndirectCommandNV
    {
        public ulong srcAddress;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
    }
    public unsafe struct VkImageResolve
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
    }
    public unsafe struct VkShaderModuleCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderModuleCreateFlags flags;
        public nuint codeSize;
        public uint* pCode;
    }
    public unsafe struct VkDescriptorSetLayoutBinding
    {
        public uint binding;
        public VkDescriptorType descriptorType;
        public uint descriptorCount;
        public VkShaderStageFlagBits stageFlags;
        public VkSampler* pImmutableSamplers;
    }
    public unsafe struct VkDescriptorSetLayoutCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSetLayoutCreateFlagBits flags;
        public uint bindingCount;
        public VkDescriptorSetLayoutBinding* pBindings;
    }
    public unsafe struct VkDescriptorPoolSize
    {
        public VkDescriptorType type;
        public uint descriptorCount;
    }
    public unsafe struct VkDescriptorPoolCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorPoolCreateFlagBits flags;
        public uint maxSets;
        public uint poolSizeCount;
        public VkDescriptorPoolSize* pPoolSizes;
    }
    public unsafe struct VkDescriptorSetAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorPool descriptorPool;
        public uint descriptorSetCount;
        public VkDescriptorSetLayout* pSetLayouts;
    }
    public unsafe struct VkSpecializationMapEntry
    {
        public uint constantID;
        public uint offset;
        public nuint size;
    }
    public unsafe struct VkSpecializationInfo
    {
        public uint mapEntryCount;
        public VkSpecializationMapEntry* pMapEntries;
        public nuint dataSize;
        public void* pData;
    }
    public unsafe struct VkPipelineShaderStageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineShaderStageCreateFlagBits flags;
        public VkShaderStageFlagBits stage;
        public VkShaderModule module;
        public byte* pName;
        public VkSpecializationInfo* pSpecializationInfo;
    }
    public unsafe struct VkComputePipelineCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlagBits flags;
        public VkPipelineShaderStageCreateInfo stage;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
    }
    public unsafe struct VkComputePipelineIndirectBufferInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong deviceAddress;
        public ulong size;
        public ulong pipelineDeviceAddressCaptureReplay;
    }
    public unsafe struct VkPipelineCreateFlags2CreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlags2KHR flags;
    }
    public unsafe struct VkVertexInputBindingDescription
    {
        public uint binding;
        public uint stride;
        public VkVertexInputRate inputRate;
    }
    public unsafe struct VkVertexInputAttributeDescription
    {
        public uint location;
        public uint binding;
        public VkFormat format;
        public uint offset;
    }
    public unsafe struct VkPipelineVertexInputStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineVertexInputStateCreateFlags flags;
        public uint vertexBindingDescriptionCount;
        public VkVertexInputBindingDescription* pVertexBindingDescriptions;
        public uint vertexAttributeDescriptionCount;
        public VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
    }
    public unsafe struct VkPipelineInputAssemblyStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineInputAssemblyStateCreateFlags flags;
        public VkPrimitiveTopology topology;
        public int primitiveRestartEnable;
    }
    public unsafe struct VkPipelineTessellationStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineTessellationStateCreateFlags flags;
        public uint patchControlPoints;
    }
    public unsafe struct VkPipelineViewportStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineViewportStateCreateFlags flags;
        public uint viewportCount;
        public VkViewport* pViewports;
        public uint scissorCount;
        public VkRect2D* pScissors;
    }
    public unsafe struct VkPipelineRasterizationStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRasterizationStateCreateFlags flags;
        public int depthClampEnable;
        public int rasterizerDiscardEnable;
        public VkPolygonMode polygonMode;
        public VkCullModeFlagBits cullMode;
        public VkFrontFace frontFace;
        public int depthBiasEnable;
        public float depthBiasConstantFactor;
        public float depthBiasClamp;
        public float depthBiasSlopeFactor;
        public float lineWidth;
    }
    public unsafe struct VkPipelineMultisampleStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineMultisampleStateCreateFlags flags;
        public VkSampleCountFlagBits rasterizationSamples;
        public int sampleShadingEnable;
        public float minSampleShading;
        public uint* pSampleMask;
        public int alphaToCoverageEnable;
        public int alphaToOneEnable;
    }
    public unsafe struct VkPipelineColorBlendAttachmentState
    {
        public int blendEnable;
        public VkBlendFactor srcColorBlendFactor;
        public VkBlendFactor dstColorBlendFactor;
        public VkBlendOp colorBlendOp;
        public VkBlendFactor srcAlphaBlendFactor;
        public VkBlendFactor dstAlphaBlendFactor;
        public VkBlendOp alphaBlendOp;
        public VkColorComponentFlagBits colorWriteMask;
    }
    public unsafe struct VkPipelineColorBlendStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineColorBlendStateCreateFlagBits flags;
        public int logicOpEnable;
        public VkLogicOp logicOp;
        public uint attachmentCount;
        public VkPipelineColorBlendAttachmentState* pAttachments;
        public fixed float blendConstants[4];
    }
    public unsafe struct VkPipelineDynamicStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineDynamicStateCreateFlags flags;
        public uint dynamicStateCount;
        public VkDynamicState* pDynamicStates;
    }
    public unsafe struct VkStencilOpState
    {
        public VkStencilOp failOp;
        public VkStencilOp passOp;
        public VkStencilOp depthFailOp;
        public VkCompareOp compareOp;
        public uint compareMask;
        public uint writeMask;
        public uint reference;
    }
    public unsafe struct VkPipelineDepthStencilStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineDepthStencilStateCreateFlagBits flags;
        public int depthTestEnable;
        public int depthWriteEnable;
        public VkCompareOp depthCompareOp;
        public int depthBoundsTestEnable;
        public int stencilTestEnable;
        public VkStencilOpState front;
        public VkStencilOpState back;
        public float minDepthBounds;
        public float maxDepthBounds;
    }
    public unsafe struct VkGraphicsPipelineCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlagBits flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
        public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
        public VkPipelineTessellationStateCreateInfo* pTessellationState;
        public VkPipelineViewportStateCreateInfo* pViewportState;
        public VkPipelineRasterizationStateCreateInfo* pRasterizationState;
        public VkPipelineMultisampleStateCreateInfo* pMultisampleState;
        public VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;
        public VkPipelineColorBlendStateCreateInfo* pColorBlendState;
        public VkPipelineDynamicStateCreateInfo* pDynamicState;
        public VkPipelineLayout layout;
        public VkRenderPass renderPass;
        public uint subpass;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
    }
    public unsafe struct VkPipelineCacheCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCacheCreateFlagBits flags;
        public nuint initialDataSize;
        public void* pInitialData;
    }
    public unsafe struct VkPipelineCacheHeaderVersionOne
    {
        public uint headerSize;
        public VkPipelineCacheHeaderVersion headerVersion;
        public uint vendorID;
        public uint deviceID;
        public fixed byte pipelineCacheUUID[16];
    }
    public unsafe struct VkPipelineCacheStageValidationIndexEntry
    {
        public ulong codeSize;
        public ulong codeOffset;
    }
    public unsafe struct VkPipelineCacheSafetyCriticalIndexEntry
    {
        public fixed byte pipelineIdentifier[16];
        public ulong pipelineMemorySize;
        public ulong jsonSize;
        public ulong jsonOffset;
        public uint stageIndexCount;
        public uint stageIndexStride;
        public ulong stageIndexOffset;
    }
    public unsafe struct VkPipelineCacheHeaderVersionSafetyCriticalOne
    {
        public VkPipelineCacheHeaderVersionOne headerVersionOne;
        public VkPipelineCacheValidationVersion validationVersion;
        public uint implementationData;
        public uint pipelineIndexCount;
        public uint pipelineIndexStride;
        public ulong pipelineIndexOffset;
    }
    public unsafe struct VkPushConstantRange
    {
        public VkShaderStageFlagBits stageFlags;
        public uint offset;
        public uint size;
    }
    public unsafe struct VkPipelineLayoutCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineLayoutCreateFlagBits flags;
        public uint setLayoutCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public uint pushConstantRangeCount;
        public VkPushConstantRange* pPushConstantRanges;
    }
    public unsafe struct VkSamplerCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSamplerCreateFlagBits flags;
        public VkFilter magFilter;
        public VkFilter minFilter;
        public VkSamplerMipmapMode mipmapMode;
        public VkSamplerAddressMode addressModeU;
        public VkSamplerAddressMode addressModeV;
        public VkSamplerAddressMode addressModeW;
        public float mipLodBias;
        public int anisotropyEnable;
        public float maxAnisotropy;
        public int compareEnable;
        public VkCompareOp compareOp;
        public float minLod;
        public float maxLod;
        public VkBorderColor borderColor;
        public int unnormalizedCoordinates;
    }
    public unsafe struct VkCommandPoolCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandPoolCreateFlagBits flags;
        public uint queueFamilyIndex;
    }
    public unsafe struct VkCommandBufferAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandPool commandPool;
        public VkCommandBufferLevel level;
        public uint commandBufferCount;
    }
    public unsafe struct VkCommandBufferInheritanceInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPass renderPass;
        public uint subpass;
        public VkFramebuffer framebuffer;
        public int occlusionQueryEnable;
        public VkQueryControlFlagBits queryFlags;
        public VkQueryPipelineStatisticFlagBits pipelineStatistics;
    }
    public unsafe struct VkCommandBufferBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandBufferUsageFlagBits flags;
        public VkCommandBufferInheritanceInfo* pInheritanceInfo;
    }
    public unsafe struct VkRenderPassBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPass renderPass;
        public VkFramebuffer framebuffer;
        public VkRect2D renderArea;
        public uint clearValueCount;
        public VkClearValue* pClearValues;
    }
    public unsafe struct VkClearColorValue
    {
        public fixed float float32[4];
        public fixed int int32[4];
        public fixed uint uint32[4];
    }
    public unsafe struct VkClearDepthStencilValue
    {
        public float depth;
        public uint stencil;
    }
    public unsafe struct VkClearValue
    {
        public VkClearColorValue color;
        public VkClearDepthStencilValue depthStencil;
    }
    public unsafe struct VkClearAttachment
    {
        public VkImageAspectFlagBits aspectMask;
        public uint colorAttachment;
        public VkClearValue clearValue;
    }
    public unsafe struct VkAttachmentDescription
    {
        public VkAttachmentDescriptionFlagBits flags;
        public VkFormat format;
        public VkSampleCountFlagBits samples;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkAttachmentLoadOp stencilLoadOp;
        public VkAttachmentStoreOp stencilStoreOp;
        public VkImageLayout initialLayout;
        public VkImageLayout finalLayout;
    }
    public unsafe struct VkAttachmentReference
    {
        public uint attachment;
        public VkImageLayout layout;
    }
    public unsafe struct VkSubpassDescription
    {
        public VkSubpassDescriptionFlagBits flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint inputAttachmentCount;
        public VkAttachmentReference* pInputAttachments;
        public uint colorAttachmentCount;
        public VkAttachmentReference* pColorAttachments;
        public VkAttachmentReference* pResolveAttachments;
        public VkAttachmentReference* pDepthStencilAttachment;
        public uint preserveAttachmentCount;
        public uint* pPreserveAttachments;
    }
    public unsafe struct VkSubpassDependency
    {
        public uint srcSubpass;
        public uint dstSubpass;
        public VkPipelineStageFlagBits srcStageMask;
        public VkPipelineStageFlagBits dstStageMask;
        public VkAccessFlagBits srcAccessMask;
        public VkAccessFlagBits dstAccessMask;
        public VkDependencyFlagBits dependencyFlags;
    }
    public unsafe struct VkRenderPassCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassCreateFlagBits flags;
        public uint attachmentCount;
        public VkAttachmentDescription* pAttachments;
        public uint subpassCount;
        public VkSubpassDescription* pSubpasses;
        public uint dependencyCount;
        public VkSubpassDependency* pDependencies;
    }
    public unsafe struct VkEventCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkEventCreateFlagBits flags;
    }
    public unsafe struct VkFenceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFenceCreateFlagBits flags;
    }
    public unsafe struct VkPhysicalDeviceFeatures
    {
        public int robustBufferAccess;
        public int fullDrawIndexUint32;
        public int imageCubeArray;
        public int independentBlend;
        public int geometryShader;
        public int tessellationShader;
        public int sampleRateShading;
        public int dualSrcBlend;
        public int logicOp;
        public int multiDrawIndirect;
        public int drawIndirectFirstInstance;
        public int depthClamp;
        public int depthBiasClamp;
        public int fillModeNonSolid;
        public int depthBounds;
        public int wideLines;
        public int largePoints;
        public int alphaToOne;
        public int multiViewport;
        public int samplerAnisotropy;
        public int textureCompressionETC2;
        public int textureCompressionASTC_LDR;
        public int textureCompressionBC;
        public int occlusionQueryPrecise;
        public int pipelineStatisticsQuery;
        public int vertexPipelineStoresAndAtomics;
        public int fragmentStoresAndAtomics;
        public int shaderTessellationAndGeometryPointSize;
        public int shaderImageGatherExtended;
        public int shaderStorageImageExtendedFormats;
        public int shaderStorageImageMultisample;
        public int shaderStorageImageReadWithoutFormat;
        public int shaderStorageImageWriteWithoutFormat;
        public int shaderUniformBufferArrayDynamicIndexing;
        public int shaderSampledImageArrayDynamicIndexing;
        public int shaderStorageBufferArrayDynamicIndexing;
        public int shaderStorageImageArrayDynamicIndexing;
        public int shaderClipDistance;
        public int shaderCullDistance;
        public int shaderFloat64;
        public int shaderInt64;
        public int shaderInt16;
        public int shaderResourceResidency;
        public int shaderResourceMinLod;
        public int sparseBinding;
        public int sparseResidencyBuffer;
        public int sparseResidencyImage2D;
        public int sparseResidencyImage3D;
        public int sparseResidency2Samples;
        public int sparseResidency4Samples;
        public int sparseResidency8Samples;
        public int sparseResidency16Samples;
        public int sparseResidencyAliased;
        public int variableMultisampleRate;
        public int inheritedQueries;
    }
    public unsafe struct VkPhysicalDeviceSparseProperties
    {
        public int residencyStandard2DBlockShape;
        public int residencyStandard2DMultisampleBlockShape;
        public int residencyStandard3DBlockShape;
        public int residencyAlignedMipSize;
        public int residencyNonResidentStrict;
    }
    public unsafe struct VkPhysicalDeviceLimits
    {
        public uint maxImageDimension1D;
        public uint maxImageDimension2D;
        public uint maxImageDimension3D;
        public uint maxImageDimensionCube;
        public uint maxImageArrayLayers;
        public uint maxTexelBufferElements;
        public uint maxUniformBufferRange;
        public uint maxStorageBufferRange;
        public uint maxPushConstantsSize;
        public uint maxMemoryAllocationCount;
        public uint maxSamplerAllocationCount;
        public ulong bufferImageGranularity;
        public ulong sparseAddressSpaceSize;
        public uint maxBoundDescriptorSets;
        public uint maxPerStageDescriptorSamplers;
        public uint maxPerStageDescriptorUniformBuffers;
        public uint maxPerStageDescriptorStorageBuffers;
        public uint maxPerStageDescriptorSampledImages;
        public uint maxPerStageDescriptorStorageImages;
        public uint maxPerStageDescriptorInputAttachments;
        public uint maxPerStageResources;
        public uint maxDescriptorSetSamplers;
        public uint maxDescriptorSetUniformBuffers;
        public uint maxDescriptorSetUniformBuffersDynamic;
        public uint maxDescriptorSetStorageBuffers;
        public uint maxDescriptorSetStorageBuffersDynamic;
        public uint maxDescriptorSetSampledImages;
        public uint maxDescriptorSetStorageImages;
        public uint maxDescriptorSetInputAttachments;
        public uint maxVertexInputAttributes;
        public uint maxVertexInputBindings;
        public uint maxVertexInputAttributeOffset;
        public uint maxVertexInputBindingStride;
        public uint maxVertexOutputComponents;
        public uint maxTessellationGenerationLevel;
        public uint maxTessellationPatchSize;
        public uint maxTessellationControlPerVertexInputComponents;
        public uint maxTessellationControlPerVertexOutputComponents;
        public uint maxTessellationControlPerPatchOutputComponents;
        public uint maxTessellationControlTotalOutputComponents;
        public uint maxTessellationEvaluationInputComponents;
        public uint maxTessellationEvaluationOutputComponents;
        public uint maxGeometryShaderInvocations;
        public uint maxGeometryInputComponents;
        public uint maxGeometryOutputComponents;
        public uint maxGeometryOutputVertices;
        public uint maxGeometryTotalOutputComponents;
        public uint maxFragmentInputComponents;
        public uint maxFragmentOutputAttachments;
        public uint maxFragmentDualSrcAttachments;
        public uint maxFragmentCombinedOutputResources;
        public uint maxComputeSharedMemorySize;
        public fixed uint maxComputeWorkGroupCount[3];
        public uint maxComputeWorkGroupInvocations;
        public fixed uint maxComputeWorkGroupSize[3];
        public uint subPixelPrecisionBits;
        public uint subTexelPrecisionBits;
        public uint mipmapPrecisionBits;
        public uint maxDrawIndexedIndexValue;
        public uint maxDrawIndirectCount;
        public float maxSamplerLodBias;
        public float maxSamplerAnisotropy;
        public uint maxViewports;
        public fixed uint maxViewportDimensions[2];
        public fixed float viewportBoundsRange[2];
        public uint viewportSubPixelBits;
        public nuint minMemoryMapAlignment;
        public ulong minTexelBufferOffsetAlignment;
        public ulong minUniformBufferOffsetAlignment;
        public ulong minStorageBufferOffsetAlignment;
        public int minTexelOffset;
        public uint maxTexelOffset;
        public int minTexelGatherOffset;
        public uint maxTexelGatherOffset;
        public float minInterpolationOffset;
        public float maxInterpolationOffset;
        public uint subPixelInterpolationOffsetBits;
        public uint maxFramebufferWidth;
        public uint maxFramebufferHeight;
        public uint maxFramebufferLayers;
        public VkSampleCountFlagBits framebufferColorSampleCounts;
        public VkSampleCountFlagBits framebufferDepthSampleCounts;
        public VkSampleCountFlagBits framebufferStencilSampleCounts;
        public VkSampleCountFlagBits framebufferNoAttachmentsSampleCounts;
        public uint maxColorAttachments;
        public VkSampleCountFlagBits sampledImageColorSampleCounts;
        public VkSampleCountFlagBits sampledImageIntegerSampleCounts;
        public VkSampleCountFlagBits sampledImageDepthSampleCounts;
        public VkSampleCountFlagBits sampledImageStencilSampleCounts;
        public VkSampleCountFlagBits storageImageSampleCounts;
        public uint maxSampleMaskWords;
        public int timestampComputeAndGraphics;
        public float timestampPeriod;
        public uint maxClipDistances;
        public uint maxCullDistances;
        public uint maxCombinedClipAndCullDistances;
        public uint discreteQueuePriorities;
        public fixed float pointSizeRange[2];
        public fixed float lineWidthRange[2];
        public float pointSizeGranularity;
        public float lineWidthGranularity;
        public int strictLines;
        public int standardSampleLocations;
        public ulong optimalBufferCopyOffsetAlignment;
        public ulong optimalBufferCopyRowPitchAlignment;
        public ulong nonCoherentAtomSize;
    }
    public unsafe struct VkSemaphoreCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphoreCreateFlags flags;
    }
    public unsafe struct VkQueryPoolCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueryPoolCreateFlags flags;
        public VkQueryType queryType;
        public uint queryCount;
        public VkQueryPipelineStatisticFlagBits pipelineStatistics;
    }
    public unsafe struct VkFramebufferCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFramebufferCreateFlagBits flags;
        public VkRenderPass renderPass;
        public uint attachmentCount;
        public VkImageView* pAttachments;
        public uint width;
        public uint height;
        public uint layers;
    }
    public unsafe struct VkDrawIndirectCommand
    {
        public uint vertexCount;
        public uint instanceCount;
        public uint firstVertex;
        public uint firstInstance;
    }
    public unsafe struct VkDrawIndexedIndirectCommand
    {
        public uint indexCount;
        public uint instanceCount;
        public uint firstIndex;
        public int vertexOffset;
        public uint firstInstance;
    }
    public unsafe struct VkDispatchIndirectCommand
    {
        public uint x;
        public uint y;
        public uint z;
    }
    public unsafe struct VkMultiDrawInfoEXT
    {
        public uint firstVertex;
        public uint vertexCount;
    }
    public unsafe struct VkMultiDrawIndexedInfoEXT
    {
        public uint firstIndex;
        public uint indexCount;
        public int vertexOffset;
    }
    public unsafe struct VkSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreCount;
        public VkSemaphore* pWaitSemaphores;
        public VkPipelineStageFlagBits* pWaitDstStageMask;
        public uint commandBufferCount;
        public VkCommandBuffer* pCommandBuffers;
        public uint signalSemaphoreCount;
        public VkSemaphore* pSignalSemaphores;
    }
    public unsafe struct VkDisplayPropertiesKHR
    {
        public VkDisplayKHR display;
        public byte* displayName;
        public VkExtent2D physicalDimensions;
        public VkExtent2D physicalResolution;
        public VkSurfaceTransformFlagBitsKHR supportedTransforms;
        public int planeReorderPossible;
        public int persistentContent;
    }
    public unsafe struct VkDisplayPlanePropertiesKHR
    {
        public VkDisplayKHR currentDisplay;
        public uint currentStackIndex;
    }
    public unsafe struct VkDisplayModeParametersKHR
    {
        public VkExtent2D visibleRegion;
        public uint refreshRate;
    }
    public unsafe struct VkDisplayModePropertiesKHR
    {
        public VkDisplayModeKHR displayMode;
        public VkDisplayModeParametersKHR parameters;
    }
    public unsafe struct VkDisplayModeCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayModeCreateFlagsKHR flags;
        public VkDisplayModeParametersKHR parameters;
    }
    public unsafe struct VkDisplayPlaneCapabilitiesKHR
    {
        public VkDisplayPlaneAlphaFlagBitsKHR supportedAlpha;
        public VkOffset2D minSrcPosition;
        public VkOffset2D maxSrcPosition;
        public VkExtent2D minSrcExtent;
        public VkExtent2D maxSrcExtent;
        public VkOffset2D minDstPosition;
        public VkOffset2D maxDstPosition;
        public VkExtent2D minDstExtent;
        public VkExtent2D maxDstExtent;
    }
    public unsafe struct VkDisplaySurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplaySurfaceCreateFlagsKHR flags;
        public VkDisplayModeKHR displayMode;
        public uint planeIndex;
        public uint planeStackIndex;
        public VkSurfaceTransformFlagBitsKHR transform;
        public float globalAlpha;
        public VkDisplayPlaneAlphaFlagBitsKHR alphaMode;
        public VkExtent2D imageExtent;
    }
    public unsafe struct VkDisplayPresentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRect2D srcRect;
        public VkRect2D dstRect;
        public int persistent;
    }
    public unsafe struct VkSurfaceCapabilitiesKHR
    {
        public uint minImageCount;
        public uint maxImageCount;
        public VkExtent2D currentExtent;
        public VkExtent2D minImageExtent;
        public VkExtent2D maxImageExtent;
        public uint maxImageArrayLayers;
        public VkSurfaceTransformFlagBitsKHR supportedTransforms;
        public VkSurfaceTransformFlagBitsKHR currentTransform;
        public VkCompositeAlphaFlagBitsKHR supportedCompositeAlpha;
        public VkImageUsageFlagBits supportedUsageFlags;
    }
    public unsafe struct VkAndroidSurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAndroidSurfaceCreateFlagsKHR flags;
        public IntPtr window;
    }
    public unsafe struct VkViSurfaceCreateInfoNN
    {
        public VkStructureType sType;
        public void* pNext;
        public VkViSurfaceCreateFlagsNN flags;
        public void* window;
    }
    public unsafe struct VkWaylandSurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkWaylandSurfaceCreateFlagsKHR flags;
        public IntPtr display;
        public IntPtr surface;
    }
    public unsafe struct VkWin32SurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkWin32SurfaceCreateFlagsKHR flags;
        public IntPtr hinstance;
        public IntPtr hwnd;
    }
    public unsafe struct VkXlibSurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkXlibSurfaceCreateFlagsKHR flags;
        public IntPtr dpy;
        public nuint window;
    }
    public unsafe struct VkXcbSurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkXcbSurfaceCreateFlagsKHR flags;
        public IntPtr connection;
        public uint window;
    }
    public unsafe struct VkDirectFBSurfaceCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDirectFBSurfaceCreateFlagsEXT flags;
        public IntPtr dfb;
        public IntPtr surface;
    }
    public unsafe struct VkImagePipeSurfaceCreateInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImagePipeSurfaceCreateFlagsFUCHSIA flags;
        public int imagePipeHandle;
    }
    public unsafe struct VkStreamDescriptorSurfaceCreateInfoGGP
    {
        public VkStructureType sType;
        public void* pNext;
        public VkStreamDescriptorSurfaceCreateFlagsGGP flags;
    }
    public unsafe struct VkScreenSurfaceCreateInfoQNX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkScreenSurfaceCreateFlagsQNX flags;
        public IntPtr* context;
        public IntPtr* window;
    }
    public unsafe struct VkSurfaceFormatKHR
    {
        public VkFormat format;
        public VkColorSpaceKHR colorSpace;
    }
    public unsafe struct VkSwapchainCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainCreateFlagBitsKHR flags;
        public VkSurfaceKHR surface;
        public uint minImageCount;
        public VkFormat imageFormat;
        public VkColorSpaceKHR imageColorSpace;
        public VkExtent2D imageExtent;
        public uint imageArrayLayers;
        public VkImageUsageFlagBits imageUsage;
        public VkSharingMode imageSharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public VkSurfaceTransformFlagBitsKHR preTransform;
        public VkCompositeAlphaFlagBitsKHR compositeAlpha;
        public VkPresentModeKHR presentMode;
        public int clipped;
        public VkSwapchainKHR oldSwapchain;
    }
    public unsafe struct VkPresentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreCount;
        public VkSemaphore* pWaitSemaphores;
        public uint swapchainCount;
        public VkSwapchainKHR* pSwapchains;
        public uint* pImageIndices;
        public VkResult* pResults;
    }
    public unsafe struct VkDebugReportCallbackCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugReportFlagBitsEXT flags;
        public IntPtr pfnCallback;
        public void* pUserData;
    }
    public unsafe struct VkValidationFlagsEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint disabledValidationCheckCount;
        public VkValidationCheckEXT* pDisabledValidationChecks;
    }
    public unsafe struct VkValidationFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint enabledValidationFeatureCount;
        public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
        public uint disabledValidationFeatureCount;
        public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
    }
    public unsafe struct VkLayerSettingsCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint settingCount;
        public VkLayerSettingEXT* pSettings;
    }
    public unsafe struct VkLayerSettingEXT
    {
        public byte* pLayerName;
        public byte* pSettingName;
        public VkLayerSettingTypeEXT type;
        public uint valueCount;
        public void* pValues;
    }
    public unsafe struct VkApplicationParametersEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint vendorID;
        public uint deviceID;
        public uint key;
        public ulong value;
    }
    public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRasterizationOrderAMD rasterizationOrder;
    }
    public unsafe struct VkDebugMarkerObjectNameInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugReportObjectTypeEXT objectType;
        public ulong obj;
        public byte* pObjectName;
    }
    public unsafe struct VkDebugMarkerObjectTagInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugReportObjectTypeEXT objectType;
        public ulong obj;
        public ulong tagName;
        public nuint tagSize;
        public void* pTag;
    }
    public unsafe struct VkDebugMarkerMarkerInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pMarkerName;
        public fixed float color[4];
    }
    public unsafe struct VkDedicatedAllocationImageCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int dedicatedAllocation;
    }
    public unsafe struct VkDedicatedAllocationBufferCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int dedicatedAllocation;
    }
    public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkBuffer buffer;
    }
    public unsafe struct VkExternalImageFormatPropertiesNV
    {
        public VkImageFormatProperties imageFormatProperties;
        public VkExternalMemoryFeatureFlagBitsNV externalMemoryFeatures;
        public VkExternalMemoryHandleTypeFlagBitsNV exportFromImportedHandleTypes;
        public VkExternalMemoryHandleTypeFlagBitsNV compatibleHandleTypes;
    }
    public unsafe struct VkExternalMemoryImageCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBitsNV handleTypes;
    }
    public unsafe struct VkExportMemoryAllocateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBitsNV handleTypes;
    }
    public unsafe struct VkImportMemoryWin32HandleInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBitsNV handleType;
        public IntPtr handle;
    }
    public unsafe struct VkExportMemoryWin32HandleInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
    }
    public unsafe struct VkExportMemorySciBufInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr pAttributes;
    }
    public unsafe struct VkImportMemorySciBufInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public IntPtr handle;
    }
    public unsafe struct VkMemoryGetSciBufInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlagBits handleType;
    }
    public unsafe struct VkMemorySciBufPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
    }
    public unsafe struct VkPhysicalDeviceExternalMemorySciBufFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int sciBufImport;
        public int sciBufExport;
    }
    public unsafe struct VkPhysicalDeviceExternalSciBufFeaturesNV
    {
    }
    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint acquireCount;
        public VkDeviceMemory* pAcquireSyncs;
        public ulong* pAcquireKeys;
        public uint* pAcquireTimeoutMilliseconds;
        public uint releaseCount;
        public VkDeviceMemory* pReleaseSyncs;
        public ulong* pReleaseKeys;
    }
    public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int deviceGeneratedCommands;
    }
    public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int deviceGeneratedCompute;
        public int deviceGeneratedComputePipelines;
        public int deviceGeneratedComputeCaptureReplay;
    }
    public unsafe struct VkDevicePrivateDataCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint privateDataSlotRequestCount;
    }
    public unsafe struct VkDevicePrivateDataCreateInfoEXT
    {
    }
    public unsafe struct VkPrivateDataSlotCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPrivateDataSlotCreateFlags flags;
    }
    public unsafe struct VkPrivateDataSlotCreateInfoEXT
    {
    }
    public unsafe struct VkPhysicalDevicePrivateDataFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int privateData;
    }
    public unsafe struct VkPhysicalDevicePrivateDataFeaturesEXT
    {
    }
    public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxGraphicsShaderGroupCount;
        public uint maxIndirectSequenceCount;
        public uint maxIndirectCommandsTokenCount;
        public uint maxIndirectCommandsStreamCount;
        public uint maxIndirectCommandsTokenOffset;
        public uint maxIndirectCommandsStreamStride;
        public uint minSequencesCountBufferOffsetAlignment;
        public uint minSequencesIndexBufferOffsetAlignment;
        public uint minIndirectCommandsBufferOffsetAlignment;
    }
    public unsafe struct VkPhysicalDeviceMultiDrawPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxMultiDrawCount;
    }
    public unsafe struct VkGraphicsShaderGroupCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
        public VkPipelineTessellationStateCreateInfo* pTessellationState;
    }
    public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint groupCount;
        public VkGraphicsShaderGroupCreateInfoNV* pGroups;
        public uint pipelineCount;
        public VkPipeline* pPipelines;
    }
    public unsafe struct VkBindShaderGroupIndirectCommandNV
    {
        public uint groupIndex;
    }
    public unsafe struct VkBindIndexBufferIndirectCommandNV
    {
        public ulong bufferAddress;
        public uint size;
        public VkIndexType indexType;
    }
    public unsafe struct VkBindVertexBufferIndirectCommandNV
    {
        public ulong bufferAddress;
        public uint size;
        public uint stride;
    }
    public unsafe struct VkSetStateFlagsIndirectCommandNV
    {
        public uint data;
    }
    public unsafe struct VkIndirectCommandsStreamNV
    {
        public VkBuffer buffer;
        public ulong offset;
    }
    public unsafe struct VkIndirectCommandsLayoutTokenNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndirectCommandsTokenTypeNV tokenType;
        public uint stream;
        public uint offset;
        public uint vertexBindingUnit;
        public int vertexDynamicStride;
        public VkPipelineLayout pushconstantPipelineLayout;
        public VkShaderStageFlagBits pushconstantShaderStageFlags;
        public uint pushconstantOffset;
        public uint pushconstantSize;
        public VkIndirectStateFlagBitsNV indirectStateFlags;
        public uint indexTypeCount;
        public VkIndexType* pIndexTypes;
        public uint* pIndexTypeValues;
    }
    public unsafe struct VkIndirectCommandsLayoutCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndirectCommandsLayoutUsageFlagBitsNV flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint tokenCount;
        public VkIndirectCommandsLayoutTokenNV* pTokens;
        public uint streamCount;
        public uint* pStreamStrides;
    }
    public unsafe struct VkGeneratedCommandsInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipeline pipeline;
        public VkIndirectCommandsLayoutNV indirectCommandsLayout;
        public uint streamCount;
        public VkIndirectCommandsStreamNV* pStreams;
        public uint sequencesCount;
        public VkBuffer preprocessBuffer;
        public ulong preprocessOffset;
        public ulong preprocessSize;
        public VkBuffer sequencesCountBuffer;
        public ulong sequencesCountOffset;
        public VkBuffer sequencesIndexBuffer;
        public ulong sequencesIndexOffset;
    }
    public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipeline pipeline;
        public VkIndirectCommandsLayoutNV indirectCommandsLayout;
        public uint maxSequencesCount;
    }
    public unsafe struct VkPipelineIndirectDeviceAddressInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipeline pipeline;
    }
    public unsafe struct VkBindPipelineIndirectCommandNV
    {
        public ulong pipelineAddress;
    }
    public unsafe struct VkPhysicalDeviceFeatures2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceFeatures features;
    }
    public unsafe struct VkPhysicalDeviceFeatures2KHR
    {
    }
    public unsafe struct VkPhysicalDeviceProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceProperties properties;
    }
    public unsafe struct VkPhysicalDeviceProperties2KHR
    {
    }
    public unsafe struct VkFormatProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormatProperties formatProperties;
    }
    public unsafe struct VkFormatProperties2KHR
    {
    }
    public unsafe struct VkImageFormatProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageFormatProperties imageFormatProperties;
    }
    public unsafe struct VkImageFormatProperties2KHR
    {
    }
    public unsafe struct VkPhysicalDeviceImageFormatInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkImageType type;
        public VkImageTiling tiling;
        public VkImageUsageFlagBits usage;
        public VkImageCreateFlagBits flags;
    }
    public unsafe struct VkPhysicalDeviceImageFormatInfo2KHR
    {
    }
    public unsafe struct VkQueueFamilyProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueueFamilyProperties queueFamilyProperties;
    }
    public unsafe struct VkQueueFamilyProperties2KHR
    {
    }
    public unsafe struct VkPhysicalDeviceMemoryProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceMemoryProperties memoryProperties;
    }
    public unsafe struct VkPhysicalDeviceMemoryProperties2KHR
    {
    }
    public unsafe struct VkSparseImageFormatProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSparseImageFormatProperties properties;
    }
    public unsafe struct VkSparseImageFormatProperties2KHR
    {
    }
    public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkImageType type;
        public VkSampleCountFlagBits samples;
        public VkImageUsageFlagBits usage;
        public VkImageTiling tiling;
    }
    public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2KHR
    {
    }
    public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPushDescriptors;
    }
    public unsafe struct VkConformanceVersion
    {
        public byte major;
        public byte minor;
        public byte subminor;
        public byte patch;
    }
    public unsafe struct VkConformanceVersionKHR
    {
    }
    public unsafe struct VkPhysicalDeviceDriverProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDriverId driverID;
        [InlineArray(256)]
        public struct driverNameInlineArray
        {
            public byte element;
        }
        public driverNameInlineArray driverName;
        [InlineArray(256)]
        public struct driverInfoInlineArray
        {
            public byte element;
        }
        public driverInfoInlineArray driverInfo;
        public VkConformanceVersion conformanceVersion;
    }
    public unsafe struct VkPhysicalDeviceDriverPropertiesKHR
    {
    }
    public unsafe struct VkPresentRegionsKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentRegionKHR* pRegions;
    }
    public unsafe struct VkPresentRegionKHR
    {
        public uint rectangleCount;
        public VkRectLayerKHR* pRectangles;
    }
    public unsafe struct VkRectLayerKHR
    {
        public VkOffset2D offset;
        public VkExtent2D extent;
        public uint layer;
    }
    public unsafe struct VkPhysicalDeviceVariablePointersFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int variablePointersStorageBuffer;
        public int variablePointers;
    }
    public unsafe struct VkPhysicalDeviceVariablePointersFeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceVariablePointerFeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceVariablePointerFeatures
    {
    }
    public unsafe struct VkExternalMemoryProperties
    {
        public VkExternalMemoryFeatureFlagBits externalMemoryFeatures;
        public VkExternalMemoryHandleTypeFlagBits exportFromImportedHandleTypes;
        public VkExternalMemoryHandleTypeFlagBits compatibleHandleTypes;
    }
    public unsafe struct VkExternalMemoryPropertiesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceExternalImageFormatInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleType;
    }
    public unsafe struct VkPhysicalDeviceExternalImageFormatInfoKHR
    {
    }
    public unsafe struct VkExternalImageFormatProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryProperties externalMemoryProperties;
    }
    public unsafe struct VkExternalImageFormatPropertiesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceExternalBufferInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCreateFlagBits flags;
        public VkBufferUsageFlagBits usage;
        public VkExternalMemoryHandleTypeFlagBits handleType;
    }
    public unsafe struct VkPhysicalDeviceExternalBufferInfoKHR
    {
    }
    public unsafe struct VkExternalBufferProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryProperties externalMemoryProperties;
    }
    public unsafe struct VkExternalBufferPropertiesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceIDProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte deviceUUID[16];
        public fixed byte driverUUID[16];
        public fixed byte deviceLUID[8];
        public uint deviceNodeMask;
        public int deviceLUIDValid;
    }
    public unsafe struct VkPhysicalDeviceIDPropertiesKHR
    {
    }
    public unsafe struct VkExternalMemoryImageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleTypes;
    }
    public unsafe struct VkExternalMemoryImageCreateInfoKHR
    {
    }
    public unsafe struct VkExternalMemoryBufferCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleTypes;
    }
    public unsafe struct VkExternalMemoryBufferCreateInfoKHR
    {
    }
    public unsafe struct VkExportMemoryAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleTypes;
    }
    public unsafe struct VkExportMemoryAllocateInfoKHR
    {
    }
    public unsafe struct VkImportMemoryWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public IntPtr handle;
        public char* name;
    }
    public unsafe struct VkExportMemoryWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public char* name;
    }
    public unsafe struct VkImportMemoryZirconHandleInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public int handle;
    }
    public unsafe struct VkMemoryZirconHandlePropertiesFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
    }
    public unsafe struct VkMemoryGetZirconHandleInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlagBits handleType;
    }
    public unsafe struct VkMemoryWin32HandlePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
    }
    public unsafe struct VkMemoryGetWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlagBits handleType;
    }
    public unsafe struct VkImportMemoryFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public int fd;
    }
    public unsafe struct VkMemoryFdPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
    }
    public unsafe struct VkMemoryGetFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlagBits handleType;
    }
    public unsafe struct VkWin32KeyedMutexAcquireReleaseInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint acquireCount;
        public VkDeviceMemory* pAcquireSyncs;
        public ulong* pAcquireKeys;
        public uint* pAcquireTimeouts;
        public uint releaseCount;
        public VkDeviceMemory* pReleaseSyncs;
        public ulong* pReleaseKeys;
    }
    public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
    }
    public unsafe struct VkPhysicalDeviceExternalSemaphoreInfoKHR
    {
    }
    public unsafe struct VkExternalSemaphoreProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalSemaphoreHandleTypeFlagBits exportFromImportedHandleTypes;
        public VkExternalSemaphoreHandleTypeFlagBits compatibleHandleTypes;
        public VkExternalSemaphoreFeatureFlagBits externalSemaphoreFeatures;
    }
    public unsafe struct VkExternalSemaphorePropertiesKHR
    {
    }
    public unsafe struct VkExportSemaphoreCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalSemaphoreHandleTypeFlagBits handleTypes;
    }
    public unsafe struct VkExportSemaphoreCreateInfoKHR
    {
    }
    public unsafe struct VkImportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlagBits flags;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public IntPtr handle;
        public char* name;
    }
    public unsafe struct VkExportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public char* name;
    }
    public unsafe struct VkD3D12FenceSubmitInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreValuesCount;
        public ulong* pWaitSemaphoreValues;
        public uint signalSemaphoreValuesCount;
        public ulong* pSignalSemaphoreValues;
    }
    public unsafe struct VkSemaphoreGetWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
    }
    public unsafe struct VkImportSemaphoreFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlagBits flags;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public int fd;
    }
    public unsafe struct VkSemaphoreGetFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
    }
    public unsafe struct VkImportSemaphoreZirconHandleInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlagBits flags;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public int zirconHandle;
    }
    public unsafe struct VkSemaphoreGetZirconHandleInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
    }
    public unsafe struct VkPhysicalDeviceExternalFenceInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalFenceHandleTypeFlagBits handleType;
    }
    public unsafe struct VkPhysicalDeviceExternalFenceInfoKHR
    {
    }
    public unsafe struct VkExternalFenceProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalFenceHandleTypeFlagBits exportFromImportedHandleTypes;
        public VkExternalFenceHandleTypeFlagBits compatibleHandleTypes;
        public VkExternalFenceFeatureFlagBits externalFenceFeatures;
    }
    public unsafe struct VkExternalFencePropertiesKHR
    {
    }
    public unsafe struct VkExportFenceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalFenceHandleTypeFlagBits handleTypes;
    }
    public unsafe struct VkExportFenceCreateInfoKHR
    {
    }
    public unsafe struct VkImportFenceWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkFenceImportFlagBits flags;
        public VkExternalFenceHandleTypeFlagBits handleType;
        public IntPtr handle;
        public char* name;
    }
    public unsafe struct VkExportFenceWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public char* name;
    }
    public unsafe struct VkFenceGetWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlagBits handleType;
    }
    public unsafe struct VkImportFenceFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkFenceImportFlagBits flags;
        public VkExternalFenceHandleTypeFlagBits handleType;
        public int fd;
    }
    public unsafe struct VkFenceGetFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlagBits handleType;
    }
    public unsafe struct VkExportFenceSciSyncInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr pAttributes;
    }
    public unsafe struct VkImportFenceSciSyncInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlagBits handleType;
        public void* handle;
    }
    public unsafe struct VkFenceGetSciSyncInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlagBits handleType;
    }
    public unsafe struct VkExportSemaphoreSciSyncInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr pAttributes;
    }
    public unsafe struct VkImportSemaphoreSciSyncInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
        public void* handle;
    }
    public unsafe struct VkSemaphoreGetSciSyncInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlagBits handleType;
    }
    public unsafe struct VkSciSyncAttributesInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSciSyncClientTypeNV clientType;
        public VkSciSyncPrimitiveTypeNV primitiveType;
    }
    public unsafe struct VkPhysicalDeviceExternalSciSyncFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int sciSyncFence;
        public int sciSyncSemaphore;
        public int sciSyncImport;
        public int sciSyncExport;
    }
    public unsafe struct VkPhysicalDeviceExternalSciSync2FeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int sciSyncFence;
        public int sciSyncSemaphore2;
        public int sciSyncImport;
        public int sciSyncExport;
    }
    public unsafe struct VkSemaphoreSciSyncPoolCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr handle;
    }
    public unsafe struct VkSemaphoreSciSyncCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphoreSciSyncPoolNV semaphorePool;
        public IntPtr pFence;
    }
    public unsafe struct VkDeviceSemaphoreSciSyncPoolReservationCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint semaphoreSciSyncPoolRequestCount;
    }
    public unsafe struct VkPhysicalDeviceMultiviewFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int multiview;
        public int multiviewGeometryShader;
        public int multiviewTessellationShader;
    }
    public unsafe struct VkPhysicalDeviceMultiviewFeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceMultiviewProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxMultiviewViewCount;
        public uint maxMultiviewInstanceIndex;
    }
    public unsafe struct VkPhysicalDeviceMultiviewPropertiesKHR
    {
    }
    public unsafe struct VkRenderPassMultiviewCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint subpassCount;
        public uint* pViewMasks;
        public uint dependencyCount;
        public int* pViewOffsets;
        public uint correlationMaskCount;
        public uint* pCorrelationMasks;
    }
    public unsafe struct VkRenderPassMultiviewCreateInfoKHR
    {
    }
    public unsafe struct VkSurfaceCapabilities2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minImageCount;
        public uint maxImageCount;
        public VkExtent2D currentExtent;
        public VkExtent2D minImageExtent;
        public VkExtent2D maxImageExtent;
        public uint maxImageArrayLayers;
        public VkSurfaceTransformFlagBitsKHR supportedTransforms;
        public VkSurfaceTransformFlagBitsKHR currentTransform;
        public VkCompositeAlphaFlagBitsKHR supportedCompositeAlpha;
        public VkImageUsageFlagBits supportedUsageFlags;
        public VkSurfaceCounterFlagBitsEXT supportedSurfaceCounters;
    }
    public unsafe struct VkDisplayPowerInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPowerStateEXT powerState;
    }
    public unsafe struct VkDeviceEventInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceEventTypeEXT deviceEvent;
    }
    public unsafe struct VkDisplayEventInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayEventTypeEXT displayEvent;
    }
    public unsafe struct VkSwapchainCounterCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceCounterFlagBitsEXT surfaceCounters;
    }
    public unsafe struct VkPhysicalDeviceGroupProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint physicalDeviceCount;
        [InlineArray(32)]
        public struct physicalDevicesInlineArray
        {
            public VkPhysicalDevice element;
        }
        public physicalDevicesInlineArray physicalDevices;
        public int subsetAllocation;
    }
    public unsafe struct VkPhysicalDeviceGroupPropertiesKHR
    {
    }
    public unsafe struct VkMemoryAllocateFlagsInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryAllocateFlagBits flags;
        public uint deviceMask;
    }
    public unsafe struct VkMemoryAllocateFlagsInfoKHR
    {
    }
    public unsafe struct VkBindBufferMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
    }
    public unsafe struct VkBindBufferMemoryInfoKHR
    {
    }
    public unsafe struct VkBindBufferMemoryDeviceGroupInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
    }
    public unsafe struct VkBindBufferMemoryDeviceGroupInfoKHR
    {
    }
    public unsafe struct VkBindImageMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
    }
    public unsafe struct VkBindImageMemoryInfoKHR
    {
    }
    public unsafe struct VkBindImageMemoryDeviceGroupInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        public uint splitInstanceBindRegionCount;
        public VkRect2D* pSplitInstanceBindRegions;
    }
    public unsafe struct VkBindImageMemoryDeviceGroupInfoKHR
    {
    }
    public unsafe struct VkDeviceGroupRenderPassBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceMask;
        public uint deviceRenderAreaCount;
        public VkRect2D* pDeviceRenderAreas;
    }
    public unsafe struct VkDeviceGroupRenderPassBeginInfoKHR
    {
    }
    public unsafe struct VkDeviceGroupCommandBufferBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceMask;
    }
    public unsafe struct VkDeviceGroupCommandBufferBeginInfoKHR
    {
    }
    public unsafe struct VkDeviceGroupSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreCount;
        public uint* pWaitSemaphoreDeviceIndices;
        public uint commandBufferCount;
        public uint* pCommandBufferDeviceMasks;
        public uint signalSemaphoreCount;
        public uint* pSignalSemaphoreDeviceIndices;
    }
    public unsafe struct VkDeviceGroupSubmitInfoKHR
    {
    }
    public unsafe struct VkDeviceGroupBindSparseInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint resourceDeviceIndex;
        public uint memoryDeviceIndex;
    }
    public unsafe struct VkDeviceGroupBindSparseInfoKHR
    {
    }
    public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed uint presentMask[32];
        public VkDeviceGroupPresentModeFlagBitsKHR modes;
    }
    public unsafe struct VkImageSwapchainCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
    }
    public unsafe struct VkBindImageMemorySwapchainInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public uint imageIndex;
    }
    public unsafe struct VkAcquireNextImageInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public ulong timeout;
        public VkSemaphore semaphore;
        public VkFence fence;
        public uint deviceMask;
    }
    public unsafe struct VkDeviceGroupPresentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public uint* pDeviceMasks;
        public VkDeviceGroupPresentModeFlagBitsKHR mode;
    }
    public unsafe struct VkDeviceGroupDeviceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint physicalDeviceCount;
        public VkPhysicalDevice* pPhysicalDevices;
    }
    public unsafe struct VkDeviceGroupDeviceCreateInfoKHR
    {
    }
    public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceGroupPresentModeFlagBitsKHR modes;
    }
    public unsafe struct VkDescriptorUpdateTemplateEntry
    {
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public VkDescriptorType descriptorType;
        public nuint offset;
        public nuint stride;
    }
    public unsafe struct VkDescriptorUpdateTemplateEntryKHR
    {
    }
    public unsafe struct VkDescriptorUpdateTemplateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorUpdateTemplateCreateFlags flags;
        public uint descriptorUpdateEntryCount;
        public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
        public VkDescriptorUpdateTemplateType templateType;
        public VkDescriptorSetLayout descriptorSetLayout;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipelineLayout pipelineLayout;
        public uint set;
    }
    public unsafe struct VkDescriptorUpdateTemplateCreateInfoKHR
    {
    }
    public unsafe struct VkXYColorEXT
    {
        public float x;
        public float y;
    }
    public unsafe struct VkPhysicalDevicePresentIdFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int presentId;
    }
    public unsafe struct VkPresentIdKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public ulong* pPresentIds;
    }
    public unsafe struct VkPhysicalDevicePresentWaitFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int presentWait;
    }
    public unsafe struct VkHdrMetadataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkXYColorEXT displayPrimaryRed;
        public VkXYColorEXT displayPrimaryGreen;
        public VkXYColorEXT displayPrimaryBlue;
        public VkXYColorEXT whitePoint;
        public float maxLuminance;
        public float minLuminance;
        public float maxContentLightLevel;
        public float maxFrameAverageLightLevel;
    }
    public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public int localDimmingSupport;
    }
    public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public int localDimmingEnable;
    }
    public unsafe struct VkRefreshCycleDurationGOOGLE
    {
        public ulong refreshDuration;
    }
    public unsafe struct VkPastPresentationTimingGOOGLE
    {
        public uint presentID;
        public ulong desiredPresentTime;
        public ulong actualPresentTime;
        public ulong earliestPresentTime;
        public ulong presentMargin;
    }
    public unsafe struct VkPresentTimesInfoGOOGLE
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentTimeGOOGLE* pTimes;
    }
    public unsafe struct VkPresentTimeGOOGLE
    {
        public uint presentID;
        public ulong desiredPresentTime;
    }
    public unsafe struct VkIOSSurfaceCreateInfoMVK
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIOSSurfaceCreateFlagsMVK flags;
        public void* pView;
    }
    public unsafe struct VkMacOSSurfaceCreateInfoMVK
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMacOSSurfaceCreateFlagsMVK flags;
        public void* pView;
    }
    public unsafe struct VkMetalSurfaceCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMetalSurfaceCreateFlagsEXT flags;
        public IntPtr* pLayer;
    }
    public unsafe struct VkViewportWScalingNV
    {
        public float xcoeff;
        public float ycoeff;
    }
    public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int viewportWScalingEnable;
        public uint viewportCount;
        public VkViewportWScalingNV* pViewportWScalings;
    }
    public unsafe struct VkViewportSwizzleNV
    {
        public VkViewportCoordinateSwizzleNV x;
        public VkViewportCoordinateSwizzleNV y;
        public VkViewportCoordinateSwizzleNV z;
        public VkViewportCoordinateSwizzleNV w;
    }
    public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineViewportSwizzleStateCreateFlagsNV flags;
        public uint viewportCount;
        public VkViewportSwizzleNV* pViewportSwizzles;
    }
    public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxDiscardRectangles;
    }
    public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineDiscardRectangleStateCreateFlagsEXT flags;
        public VkDiscardRectangleModeEXT discardRectangleMode;
        public uint discardRectangleCount;
        public VkRect2D* pDiscardRectangles;
    }
    public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public int perViewPositionAllComponents;
    }
    public unsafe struct VkInputAttachmentAspectReference
    {
        public uint subpass;
        public uint inputAttachmentIndex;
        public VkImageAspectFlagBits aspectMask;
    }
    public unsafe struct VkInputAttachmentAspectReferenceKHR
    {
    }
    public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint aspectReferenceCount;
        public VkInputAttachmentAspectReference* pAspectReferences;
    }
    public unsafe struct VkRenderPassInputAttachmentAspectCreateInfoKHR
    {
    }
    public unsafe struct VkPhysicalDeviceSurfaceInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceKHR surface;
    }
    public unsafe struct VkSurfaceCapabilities2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceCapabilitiesKHR surfaceCapabilities;
    }
    public unsafe struct VkSurfaceFormat2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceFormatKHR surfaceFormat;
    }
    public unsafe struct VkDisplayProperties2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPropertiesKHR displayProperties;
    }
    public unsafe struct VkDisplayPlaneProperties2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPlanePropertiesKHR displayPlaneProperties;
    }
    public unsafe struct VkDisplayModeProperties2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayModePropertiesKHR displayModeProperties;
    }
    public unsafe struct VkDisplayPlaneInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayModeKHR mode;
        public uint planeIndex;
    }
    public unsafe struct VkDisplayPlaneCapabilities2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPlaneCapabilitiesKHR capabilities;
    }
    public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlagBits sharedPresentSupportedUsageFlags;
    }
    public unsafe struct VkPhysicalDevice16BitStorageFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int storageBuffer16BitAccess;
        public int uniformAndStorageBuffer16BitAccess;
        public int storagePushConstant16;
        public int storageInputOutput16;
    }
    public unsafe struct VkPhysicalDevice16BitStorageFeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceSubgroupProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint subgroupSize;
        public VkShaderStageFlagBits supportedStages;
        public VkSubgroupFeatureFlagBits supportedOperations;
        public int quadOperationsInAllStages;
    }
    public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderSubgroupExtendedTypes;
    }
    public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR
    {
    }
    public unsafe struct VkBufferMemoryRequirementsInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
    }
    public unsafe struct VkBufferMemoryRequirementsInfo2KHR
    {
    }
    public unsafe struct VkDeviceBufferMemoryRequirements
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCreateInfo* pCreateInfo;
    }
    public unsafe struct VkDeviceBufferMemoryRequirementsKHR
    {
    }
    public unsafe struct VkImageMemoryRequirementsInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
    }
    public unsafe struct VkImageMemoryRequirementsInfo2KHR
    {
    }
    public unsafe struct VkImageSparseMemoryRequirementsInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
    }
    public unsafe struct VkImageSparseMemoryRequirementsInfo2KHR
    {
    }
    public unsafe struct VkDeviceImageMemoryRequirements
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateInfo* pCreateInfo;
        public VkImageAspectFlagBits planeAspect;
    }
    public unsafe struct VkDeviceImageMemoryRequirementsKHR
    {
    }
    public unsafe struct VkMemoryRequirements2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryRequirements memoryRequirements;
    }
    public unsafe struct VkMemoryRequirements2KHR
    {
    }
    public unsafe struct VkSparseImageMemoryRequirements2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSparseImageMemoryRequirements memoryRequirements;
    }
    public unsafe struct VkSparseImageMemoryRequirements2KHR
    {
    }
    public unsafe struct VkPhysicalDevicePointClippingProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPointClippingBehavior pointClippingBehavior;
    }
    public unsafe struct VkPhysicalDevicePointClippingPropertiesKHR
    {
    }
    public unsafe struct VkMemoryDedicatedRequirements
    {
        public VkStructureType sType;
        public void* pNext;
        public int prefersDedicatedAllocation;
        public int requiresDedicatedAllocation;
    }
    public unsafe struct VkMemoryDedicatedRequirementsKHR
    {
    }
    public unsafe struct VkMemoryDedicatedAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkBuffer buffer;
    }
    public unsafe struct VkMemoryDedicatedAllocateInfoKHR
    {
    }
    public unsafe struct VkImageViewUsageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlagBits usage;
    }
    public unsafe struct VkImageViewSlicedCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint sliceOffset;
        public uint sliceCount;
    }
    public unsafe struct VkImageViewUsageCreateInfoKHR
    {
    }
    public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTessellationDomainOrigin domainOrigin;
    }
    public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfoKHR
    {
    }
    public unsafe struct VkSamplerYcbcrConversionInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSamplerYcbcrConversion conversion;
    }
    public unsafe struct VkSamplerYcbcrConversionInfoKHR
    {
    }
    public unsafe struct VkSamplerYcbcrConversionCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkSamplerYcbcrModelConversion ycbcrModel;
        public VkSamplerYcbcrRange ycbcrRange;
        public VkComponentMapping components;
        public VkChromaLocation xChromaOffset;
        public VkChromaLocation yChromaOffset;
        public VkFilter chromaFilter;
        public int forceExplicitReconstruction;
    }
    public unsafe struct VkSamplerYcbcrConversionCreateInfoKHR
    {
    }
    public unsafe struct VkBindImagePlaneMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageAspectFlagBits planeAspect;
    }
    public unsafe struct VkBindImagePlaneMemoryInfoKHR
    {
    }
    public unsafe struct VkImagePlaneMemoryRequirementsInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageAspectFlagBits planeAspect;
    }
    public unsafe struct VkImagePlaneMemoryRequirementsInfoKHR
    {
    }
    public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int samplerYcbcrConversion;
    }
    public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR
    {
    }
    public unsafe struct VkSamplerYcbcrConversionImageFormatProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint combinedImageSamplerDescriptorCount;
    }
    public unsafe struct VkSamplerYcbcrConversionImageFormatPropertiesKHR
    {
    }
    public unsafe struct VkTextureLODGatherFormatPropertiesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public int supportsTextureGatherLODBiasAMD;
    }
    public unsafe struct VkConditionalRenderingBeginInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public ulong offset;
        public VkConditionalRenderingFlagBitsEXT flags;
    }
    public unsafe struct VkProtectedSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public int protectedSubmit;
    }
    public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int protectedMemory;
    }
    public unsafe struct VkPhysicalDeviceProtectedMemoryProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public int protectedNoFault;
    }
    public unsafe struct VkDeviceQueueInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceQueueCreateFlagBits flags;
        public uint queueFamilyIndex;
        public uint queueIndex;
    }
    public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCoverageToColorStateCreateFlagsNV flags;
        public int coverageToColorEnable;
        public uint coverageToColorLocation;
    }
    public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public int filterMinmaxSingleComponentFormats;
        public int filterMinmaxImageComponentMapping;
    }
    public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT
    {
    }
    public unsafe struct VkSampleLocationEXT
    {
        public float x;
        public float y;
    }
    public unsafe struct VkSampleLocationsInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlagBits sampleLocationsPerPixel;
        public VkExtent2D sampleLocationGridSize;
        public uint sampleLocationsCount;
        public VkSampleLocationEXT* pSampleLocations;
    }
    public unsafe struct VkAttachmentSampleLocationsEXT
    {
        public uint attachmentIndex;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }
    public unsafe struct VkSubpassSampleLocationsEXT
    {
        public uint subpassIndex;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }
    public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentInitialSampleLocationsCount;
        public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
        public uint postSubpassSampleLocationsCount;
        public VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
    }
    public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int sampleLocationsEnable;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }
    public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlagBits sampleLocationSampleCounts;
        public VkExtent2D maxSampleLocationGridSize;
        public fixed float sampleLocationCoordinateRange[2];
        public uint sampleLocationSubPixelBits;
        public int variableSampleLocations;
    }
    public unsafe struct VkMultisamplePropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D maxSampleLocationGridSize;
    }
    public unsafe struct VkSamplerReductionModeCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSamplerReductionMode reductionMode;
    }
    public unsafe struct VkSamplerReductionModeCreateInfoEXT
    {
    }
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int advancedBlendCoherentOperations;
    }
    public unsafe struct VkPhysicalDeviceMultiDrawFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int multiDraw;
    }
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint advancedBlendMaxColorAttachments;
        public int advancedBlendIndependentBlend;
        public int advancedBlendNonPremultipliedSrcColor;
        public int advancedBlendNonPremultipliedDstColor;
        public int advancedBlendCorrelatedOverlap;
        public int advancedBlendAllOperations;
    }
    public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int srcPremultiplied;
        public int dstPremultiplied;
        public VkBlendOverlapEXT blendOverlap;
    }
    public unsafe struct VkPhysicalDeviceInlineUniformBlockFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int inlineUniformBlock;
        public int descriptorBindingInlineUniformBlockUpdateAfterBind;
    }
    public unsafe struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
    {
    }
    public unsafe struct VkPhysicalDeviceInlineUniformBlockProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxInlineUniformBlockSize;
        public uint maxPerStageDescriptorInlineUniformBlocks;
        public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        public uint maxDescriptorSetInlineUniformBlocks;
        public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    }
    public unsafe struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT
    {
    }
    public unsafe struct VkWriteDescriptorSetInlineUniformBlock
    {
        public VkStructureType sType;
        public void* pNext;
        public uint dataSize;
        public void* pData;
    }
    public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT
    {
    }
    public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxInlineUniformBlockBindings;
    }
    public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
    {
    }
    public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCoverageModulationStateCreateFlagsNV flags;
        public VkCoverageModulationModeNV coverageModulationMode;
        public int coverageModulationTableEnable;
        public uint coverageModulationTableCount;
        public float* pCoverageModulationTable;
    }
    public unsafe struct VkImageFormatListCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint viewFormatCount;
        public VkFormat* pViewFormats;
    }
    public unsafe struct VkImageFormatListCreateInfoKHR
    {
    }
    public unsafe struct VkValidationCacheCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkValidationCacheCreateFlagsEXT flags;
        public nuint initialDataSize;
        public void* pInitialData;
    }
    public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkValidationCacheEXT validationCache;
    }
    public unsafe struct VkPhysicalDeviceMaintenance3Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPerSetDescriptors;
        public ulong maxMemoryAllocationSize;
    }
    public unsafe struct VkPhysicalDeviceMaintenance3PropertiesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceMaintenance4Features
    {
        public VkStructureType sType;
        public void* pNext;
        public int maintenance4;
    }
    public unsafe struct VkPhysicalDeviceMaintenance4FeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceMaintenance4Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong maxBufferSize;
    }
    public unsafe struct VkPhysicalDeviceMaintenance4PropertiesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceMaintenance5FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int maintenance5;
    }
    public unsafe struct VkPhysicalDeviceMaintenance5PropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int earlyFragmentMultisampleCoverageAfterSampleCounting;
        public int earlyFragmentSampleMaskTestBeforeSampleCounting;
        public int depthStencilSwizzleOneSupport;
        public int polygonModePointSize;
        public int nonStrictSinglePixelWideLinesUseParallelogram;
        public int nonStrictWideLinesUseParallelogram;
    }
    public unsafe struct VkPhysicalDeviceMaintenance6FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int maintenance6;
    }
    public unsafe struct VkPhysicalDeviceMaintenance6PropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int blockTexelViewCompatibleMultipleLayers;
        public uint maxCombinedImageSamplerDescriptorCount;
        public int fragmentShadingRateClampCombinerInputs;
    }
    public unsafe struct VkPhysicalDeviceMaintenance7FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int maintenance7;
    }
    public unsafe struct VkPhysicalDeviceMaintenance7PropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int robustFragmentShadingRateAttachmentAccess;
        public int separateDepthStencilAttachmentAccess;
        public uint maxDescriptorSetTotalUniformBuffersDynamic;
        public uint maxDescriptorSetTotalStorageBuffersDynamic;
        public uint maxDescriptorSetTotalBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
    }
    public unsafe struct VkPhysicalDeviceLayeredApiPropertiesListKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint layeredApiCount;
        public VkPhysicalDeviceLayeredApiPropertiesKHR* pLayeredApis;
    }
    public unsafe struct VkPhysicalDeviceLayeredApiPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint vendorID;
        public uint deviceID;
        public VkPhysicalDeviceLayeredApiKHR layeredAPI;
        [InlineArray(256)]
        public struct deviceNameInlineArray
        {
            public byte element;
        }
        public deviceNameInlineArray deviceName;
    }
    public unsafe struct VkPhysicalDeviceLayeredApiVulkanPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceProperties2 properties;
    }
    public unsafe struct VkRenderingAreaInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkFormat* pColorAttachmentFormats;
        public VkFormat depthAttachmentFormat;
        public VkFormat stencilAttachmentFormat;
    }
    public unsafe struct VkDescriptorSetLayoutSupport
    {
        public VkStructureType sType;
        public void* pNext;
        public int supported;
    }
    public unsafe struct VkDescriptorSetLayoutSupportKHR
    {
    }
    public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderDrawParameters;
    }
    public unsafe struct VkPhysicalDeviceShaderDrawParameterFeatures
    {
    }
    public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderFloat16;
        public int shaderInt8;
    }
    public unsafe struct VkPhysicalDeviceShaderFloat16Int8FeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceFloat16Int8FeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceFloatControlsProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public VkShaderFloatControlsIndependence roundingModeIndependence;
        public int shaderSignedZeroInfNanPreserveFloat16;
        public int shaderSignedZeroInfNanPreserveFloat32;
        public int shaderSignedZeroInfNanPreserveFloat64;
        public int shaderDenormPreserveFloat16;
        public int shaderDenormPreserveFloat32;
        public int shaderDenormPreserveFloat64;
        public int shaderDenormFlushToZeroFloat16;
        public int shaderDenormFlushToZeroFloat32;
        public int shaderDenormFlushToZeroFloat64;
        public int shaderRoundingModeRTEFloat16;
        public int shaderRoundingModeRTEFloat32;
        public int shaderRoundingModeRTEFloat64;
        public int shaderRoundingModeRTZFloat16;
        public int shaderRoundingModeRTZFloat32;
        public int shaderRoundingModeRTZFloat64;
    }
    public unsafe struct VkPhysicalDeviceFloatControlsPropertiesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceHostQueryResetFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int hostQueryReset;
    }
    public unsafe struct VkPhysicalDeviceHostQueryResetFeaturesEXT
    {
    }
    public unsafe struct VkNativeBufferUsage2ANDROID
    {
        public ulong consumer;
        public ulong producer;
    }
    public unsafe struct VkNativeBufferANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public void* handle;
        public int stride;
        public int format;
        public int usage;
        public VkNativeBufferUsage2ANDROID usage2;
    }
    public unsafe struct VkSwapchainImageCreateInfoANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainImageUsageFlagBitsANDROID usage;
    }
    public unsafe struct VkPhysicalDevicePresentationPropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public int sharedImage;
    }
    public unsafe struct VkShaderResourceUsageAMD
    {
        public uint numUsedVgprs;
        public uint numUsedSgprs;
        public uint ldsSizePerLocalWorkGroup;
        public nuint ldsUsageSizeInBytes;
        public nuint scratchMemUsageInBytes;
    }
    public unsafe struct VkShaderStatisticsInfoAMD
    {
        public VkShaderStageFlagBits shaderStageMask;
        public VkShaderResourceUsageAMD resourceUsage;
        public uint numPhysicalVgprs;
        public uint numPhysicalSgprs;
        public uint numAvailableVgprs;
        public uint numAvailableSgprs;
        public fixed uint computeWorkGroupSize[3];
    }
    public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueueGlobalPriorityKHR globalPriority;
    }
    public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT
    {
    }
    public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int globalPriorityQuery;
    }
    public unsafe struct VkPhysicalDeviceGlobalPriorityQueryFeaturesEXT
    {
    }
    public unsafe struct VkQueueFamilyGlobalPriorityPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint priorityCount;
        [InlineArray(16)]
        public struct prioritiesInlineArray
        {
            public VkQueueGlobalPriorityKHR element;
        }
        public prioritiesInlineArray priorities;
    }
    public unsafe struct VkQueueFamilyGlobalPriorityPropertiesEXT
    {
    }
    public unsafe struct VkDebugUtilsObjectNameInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkObjectType objectType;
        public ulong objectHandle;
        public byte* pObjectName;
    }
    public unsafe struct VkDebugUtilsObjectTagInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkObjectType objectType;
        public ulong objectHandle;
        public ulong tagName;
        public nuint tagSize;
        public void* pTag;
    }
    public unsafe struct VkDebugUtilsLabelEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pLabelName;
        public fixed float color[4];
    }
    public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugUtilsMessengerCreateFlagsEXT flags;
        public VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity;
        public VkDebugUtilsMessageTypeFlagBitsEXT messageType;
        public IntPtr pfnUserCallback;
        public void* pUserData;
    }
    public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugUtilsMessengerCallbackDataFlagsEXT flags;
        public byte* pMessageIdName;
        public int messageIdNumber;
        public byte* pMessage;
        public uint queueLabelCount;
        public VkDebugUtilsLabelEXT* pQueueLabels;
        public uint cmdBufLabelCount;
        public VkDebugUtilsLabelEXT* pCmdBufLabels;
        public uint objectCount;
        public VkDebugUtilsObjectNameInfoEXT* pObjects;
    }
    public unsafe struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int deviceMemoryReport;
    }
    public unsafe struct VkDeviceDeviceMemoryReportCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemoryReportFlagsEXT flags;
        public IntPtr pfnUserCallback;
        public void* pUserData;
    }
    public unsafe struct VkDeviceMemoryReportCallbackDataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemoryReportFlagsEXT flags;
        public VkDeviceMemoryReportEventTypeEXT type;
        public ulong memoryObjectId;
        public ulong size;
        public VkObjectType objectType;
        public ulong objectHandle;
        public uint heapIndex;
    }
    public unsafe struct VkImportMemoryHostPointerInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagBits handleType;
        public void* pHostPointer;
    }
    public unsafe struct VkMemoryHostPointerPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
    }
    public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong minImportedHostPointerAlignment;
    }
    public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public float primitiveOverestimationSize;
        public float maxExtraPrimitiveOverestimationSize;
        public float extraPrimitiveOverestimationSizeGranularity;
        public int primitiveUnderestimation;
        public int conservativePointAndLineRasterization;
        public int degenerateTrianglesRasterized;
        public int degenerateLinesRasterized;
        public int fullyCoveredFragmentShaderInputVariable;
        public int conservativeRasterizationPostDepthCoverage;
    }
    public unsafe struct VkCalibratedTimestampInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTimeDomainKHR timeDomain;
    }
    public unsafe struct VkCalibratedTimestampInfoEXT
    {
    }
    public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderEngineCount;
        public uint shaderArraysPerEngineCount;
        public uint computeUnitsPerShaderArray;
        public uint simdPerComputeUnit;
        public uint wavefrontsPerSimd;
        public uint wavefrontSize;
        public uint sgprsPerSimd;
        public uint minSgprAllocation;
        public uint maxSgprAllocation;
        public uint sgprAllocationGranularity;
        public uint vgprsPerSimd;
        public uint minVgprAllocation;
        public uint maxVgprAllocation;
        public uint vgprAllocationGranularity;
    }
    public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderCorePropertiesFlagBitsAMD shaderCoreFeatures;
        public uint activeComputeUnitCount;
    }
    public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRasterizationConservativeStateCreateFlagsEXT flags;
        public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
        public float extraPrimitiveOverestimationSize;
    }
    public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderInputAttachmentArrayDynamicIndexing;
        public int shaderUniformTexelBufferArrayDynamicIndexing;
        public int shaderStorageTexelBufferArrayDynamicIndexing;
        public int shaderUniformBufferArrayNonUniformIndexing;
        public int shaderSampledImageArrayNonUniformIndexing;
        public int shaderStorageBufferArrayNonUniformIndexing;
        public int shaderStorageImageArrayNonUniformIndexing;
        public int shaderInputAttachmentArrayNonUniformIndexing;
        public int shaderUniformTexelBufferArrayNonUniformIndexing;
        public int shaderStorageTexelBufferArrayNonUniformIndexing;
        public int descriptorBindingUniformBufferUpdateAfterBind;
        public int descriptorBindingSampledImageUpdateAfterBind;
        public int descriptorBindingStorageImageUpdateAfterBind;
        public int descriptorBindingStorageBufferUpdateAfterBind;
        public int descriptorBindingUniformTexelBufferUpdateAfterBind;
        public int descriptorBindingStorageTexelBufferUpdateAfterBind;
        public int descriptorBindingUpdateUnusedWhilePending;
        public int descriptorBindingPartiallyBound;
        public int descriptorBindingVariableDescriptorCount;
        public int runtimeDescriptorArray;
    }
    public unsafe struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT
    {
    }
    public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxUpdateAfterBindDescriptorsInAllPools;
        public int shaderUniformBufferArrayNonUniformIndexingNative;
        public int shaderSampledImageArrayNonUniformIndexingNative;
        public int shaderStorageBufferArrayNonUniformIndexingNative;
        public int shaderStorageImageArrayNonUniformIndexingNative;
        public int shaderInputAttachmentArrayNonUniformIndexingNative;
        public int robustBufferAccessUpdateAfterBind;
        public int quadDivergentImplicitLod;
        public uint maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint maxPerStageUpdateAfterBindResources;
        public uint maxDescriptorSetUpdateAfterBindSamplers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindSampledImages;
        public uint maxDescriptorSetUpdateAfterBindStorageImages;
        public uint maxDescriptorSetUpdateAfterBindInputAttachments;
    }
    public unsafe struct VkPhysicalDeviceDescriptorIndexingPropertiesEXT
    {
    }
    public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint bindingCount;
        public VkDescriptorBindingFlagBits* pBindingFlags;
    }
    public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT
    {
    }
    public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint descriptorSetCount;
        public uint* pDescriptorCounts;
    }
    public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT
    {
    }
    public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxVariableDescriptorCount;
    }
    public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT
    {
    }
    public unsafe struct VkAttachmentDescription2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAttachmentDescriptionFlagBits flags;
        public VkFormat format;
        public VkSampleCountFlagBits samples;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkAttachmentLoadOp stencilLoadOp;
        public VkAttachmentStoreOp stencilStoreOp;
        public VkImageLayout initialLayout;
        public VkImageLayout finalLayout;
    }
    public unsafe struct VkAttachmentDescription2KHR
    {
    }
    public unsafe struct VkAttachmentReference2
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachment;
        public VkImageLayout layout;
        public VkImageAspectFlagBits aspectMask;
    }
    public unsafe struct VkAttachmentReference2KHR
    {
    }
    public unsafe struct VkSubpassDescription2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubpassDescriptionFlagBits flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint viewMask;
        public uint inputAttachmentCount;
        public VkAttachmentReference2* pInputAttachments;
        public uint colorAttachmentCount;
        public VkAttachmentReference2* pColorAttachments;
        public VkAttachmentReference2* pResolveAttachments;
        public VkAttachmentReference2* pDepthStencilAttachment;
        public uint preserveAttachmentCount;
        public uint* pPreserveAttachments;
    }
    public unsafe struct VkSubpassDescription2KHR
    {
    }
    public unsafe struct VkSubpassDependency2
    {
        public VkStructureType sType;
        public void* pNext;
        public uint srcSubpass;
        public uint dstSubpass;
        public VkPipelineStageFlagBits srcStageMask;
        public VkPipelineStageFlagBits dstStageMask;
        public VkAccessFlagBits srcAccessMask;
        public VkAccessFlagBits dstAccessMask;
        public VkDependencyFlagBits dependencyFlags;
        public int viewOffset;
    }
    public unsafe struct VkSubpassDependency2KHR
    {
    }
    public unsafe struct VkRenderPassCreateInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassCreateFlagBits flags;
        public uint attachmentCount;
        public VkAttachmentDescription2* pAttachments;
        public uint subpassCount;
        public VkSubpassDescription2* pSubpasses;
        public uint dependencyCount;
        public VkSubpassDependency2* pDependencies;
        public uint correlatedViewMaskCount;
        public uint* pCorrelatedViewMasks;
    }
    public unsafe struct VkRenderPassCreateInfo2KHR
    {
    }
    public unsafe struct VkSubpassBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubpassContents contents;
    }
    public unsafe struct VkSubpassBeginInfoKHR
    {
    }
    public unsafe struct VkSubpassEndInfo
    {
        public VkStructureType sType;
        public void* pNext;
    }
    public unsafe struct VkSubpassEndInfoKHR
    {
    }
    public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int timelineSemaphore;
    }
    public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceTimelineSemaphoreProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong maxTimelineSemaphoreValueDifference;
    }
    public unsafe struct VkPhysicalDeviceTimelineSemaphorePropertiesKHR
    {
    }
    public unsafe struct VkSemaphoreTypeCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphoreType semaphoreType;
        public ulong initialValue;
    }
    public unsafe struct VkSemaphoreTypeCreateInfoKHR
    {
    }
    public unsafe struct VkTimelineSemaphoreSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreValueCount;
        public ulong* pWaitSemaphoreValues;
        public uint signalSemaphoreValueCount;
        public ulong* pSignalSemaphoreValues;
    }
    public unsafe struct VkTimelineSemaphoreSubmitInfoKHR
    {
    }
    public unsafe struct VkSemaphoreWaitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphoreWaitFlagBits flags;
        public uint semaphoreCount;
        public VkSemaphore* pSemaphores;
        public ulong* pValues;
    }
    public unsafe struct VkSemaphoreWaitInfoKHR
    {
    }
    public unsafe struct VkSemaphoreSignalInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public ulong value;
    }
    public unsafe struct VkSemaphoreSignalInfoKHR
    {
    }
    public unsafe struct VkVertexInputBindingDivisorDescriptionKHR
    {
        public uint binding;
        public uint divisor;
    }
    public unsafe struct VkVertexInputBindingDivisorDescriptionEXT
    {
    }
    public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint vertexBindingDivisorCount;
        public VkVertexInputBindingDivisorDescriptionKHR* pVertexBindingDivisors;
    }
    public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
    {
    }
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxVertexAttribDivisor;
    }
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxVertexAttribDivisor;
        public int supportsNonZeroFirstInstance;
    }
    public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint pciDomain;
        public uint pciBus;
        public uint pciDevice;
        public uint pciFunction;
    }
    public unsafe struct VkImportAndroidHardwareBufferInfoANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr buffer;
    }
    public unsafe struct VkAndroidHardwareBufferUsageANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong androidHardwareBufferUsage;
    }
    public unsafe struct VkAndroidHardwareBufferPropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong allocationSize;
        public uint memoryTypeBits;
    }
    public unsafe struct VkMemoryGetAndroidHardwareBufferInfoANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
    }
    public unsafe struct VkAndroidHardwareBufferFormatPropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public ulong externalFormat;
        public VkFormatFeatureFlagBits formatFeatures;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
    }
    public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int conditionalRenderingEnable;
    }
    public unsafe struct VkExternalFormatANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong externalFormat;
    }
    public unsafe struct VkPhysicalDevice8BitStorageFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int storageBuffer8BitAccess;
        public int uniformAndStorageBuffer8BitAccess;
        public int storagePushConstant8;
    }
    public unsafe struct VkPhysicalDevice8BitStorageFeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int conditionalRendering;
        public int inheritedConditionalRendering;
    }
    public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int vulkanMemoryModel;
        public int vulkanMemoryModelDeviceScope;
        public int vulkanMemoryModelAvailabilityVisibilityChains;
    }
    public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderBufferInt64Atomics;
        public int shaderSharedInt64Atomics;
    }
    public unsafe struct VkPhysicalDeviceShaderAtomicInt64FeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderBufferFloat32Atomics;
        public int shaderBufferFloat32AtomicAdd;
        public int shaderBufferFloat64Atomics;
        public int shaderBufferFloat64AtomicAdd;
        public int shaderSharedFloat32Atomics;
        public int shaderSharedFloat32AtomicAdd;
        public int shaderSharedFloat64Atomics;
        public int shaderSharedFloat64AtomicAdd;
        public int shaderImageFloat32Atomics;
        public int shaderImageFloat32AtomicAdd;
        public int sparseImageFloat32Atomics;
        public int sparseImageFloat32AtomicAdd;
    }
    public unsafe struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderBufferFloat16Atomics;
        public int shaderBufferFloat16AtomicAdd;
        public int shaderBufferFloat16AtomicMinMax;
        public int shaderBufferFloat32AtomicMinMax;
        public int shaderBufferFloat64AtomicMinMax;
        public int shaderSharedFloat16Atomics;
        public int shaderSharedFloat16AtomicAdd;
        public int shaderSharedFloat16AtomicMinMax;
        public int shaderSharedFloat32AtomicMinMax;
        public int shaderSharedFloat64AtomicMinMax;
        public int shaderImageFloat32AtomicMinMax;
        public int sparseImageFloat32AtomicMinMax;
    }
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int vertexAttributeInstanceRateDivisor;
        public int vertexAttributeInstanceRateZeroDivisor;
    }
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
    {
    }
    public unsafe struct VkQueueFamilyCheckpointPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlagBits checkpointExecutionStageMask;
    }
    public unsafe struct VkCheckpointDataNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlagBits stage;
        public void* pCheckpointMarker;
    }
    public unsafe struct VkPhysicalDeviceDepthStencilResolveProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkResolveModeFlagBits supportedDepthResolveModes;
        public VkResolveModeFlagBits supportedStencilResolveModes;
        public int independentResolveNone;
        public int independentResolve;
    }
    public unsafe struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR
    {
    }
    public unsafe struct VkSubpassDescriptionDepthStencilResolve
    {
        public VkStructureType sType;
        public void* pNext;
        public VkResolveModeFlagBits depthResolveMode;
        public VkResolveModeFlagBits stencilResolveMode;
        public VkAttachmentReference2* pDepthStencilResolveAttachment;
    }
    public unsafe struct VkSubpassDescriptionDepthStencilResolveKHR
    {
    }
    public unsafe struct VkImageViewASTCDecodeModeEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat decodeMode;
    }
    public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int decodeModeSharedExponent;
    }
    public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int transformFeedback;
        public int geometryStreams;
    }
    public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxTransformFeedbackStreams;
        public uint maxTransformFeedbackBuffers;
        public ulong maxTransformFeedbackBufferSize;
        public uint maxTransformFeedbackStreamDataSize;
        public uint maxTransformFeedbackBufferDataSize;
        public uint maxTransformFeedbackBufferDataStride;
        public int transformFeedbackQueries;
        public int transformFeedbackStreamsLinesTriangles;
        public int transformFeedbackRasterizationStreamSelect;
        public int transformFeedbackDraw;
    }
    public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
        public uint rasterizationStream;
    }
    public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int representativeFragmentTest;
    }
    public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int representativeFragmentTestEnable;
    }
    public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int exclusiveScissor;
    }
    public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint exclusiveScissorCount;
        public VkRect2D* pExclusiveScissors;
    }
    public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int cornerSampledImage;
    }
    public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int computeDerivativeGroupQuads;
        public int computeDerivativeGroupLinear;
    }
    public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV
    {
    }
    public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int imageFootprint;
    }
    public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int dedicatedAllocationImageAliasing;
    }
    public unsafe struct VkPhysicalDeviceCopyMemoryIndirectFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int indirectCopy;
    }
    public unsafe struct VkPhysicalDeviceCopyMemoryIndirectPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueueFlagBits supportedQueues;
    }
    public unsafe struct VkPhysicalDeviceMemoryDecompressionFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int memoryDecompression;
    }
    public unsafe struct VkPhysicalDeviceMemoryDecompressionPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryDecompressionMethodFlagsNV decompressionMethods;
        public ulong maxDecompressionIndirectCount;
    }
    public unsafe struct VkShadingRatePaletteNV
    {
        public uint shadingRatePaletteEntryCount;
        public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
    }
    public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int shadingRateImageEnable;
        public uint viewportCount;
        public VkShadingRatePaletteNV* pShadingRatePalettes;
    }
    public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int shadingRateImage;
        public int shadingRateCoarseSampleOrder;
    }
    public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D shadingRateTexelSize;
        public uint shadingRatePaletteSize;
        public uint shadingRateMaxCoarseSamples;
    }
    public unsafe struct VkPhysicalDeviceInvocationMaskFeaturesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public int invocationMask;
    }
    public unsafe struct VkCoarseSampleLocationNV
    {
        public uint pixelX;
        public uint pixelY;
        public uint sample;
    }
    public unsafe struct VkCoarseSampleOrderCustomNV
    {
        public VkShadingRatePaletteEntryNV shadingRate;
        public uint sampleCount;
        public uint sampleLocationCount;
        public VkCoarseSampleLocationNV* pSampleLocations;
    }
    public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCoarseSampleOrderTypeNV sampleOrderType;
        public uint customSampleOrderCount;
        public VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
    }
    public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int taskShader;
        public int meshShader;
    }
    public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxDrawMeshTasksCount;
        public uint maxTaskWorkGroupInvocations;
        public fixed uint maxTaskWorkGroupSize[3];
        public uint maxTaskTotalMemorySize;
        public uint maxTaskOutputCount;
        public uint maxMeshWorkGroupInvocations;
        public fixed uint maxMeshWorkGroupSize[3];
        public uint maxMeshTotalMemorySize;
        public uint maxMeshOutputVertices;
        public uint maxMeshOutputPrimitives;
        public uint maxMeshMultiviewViewCount;
        public uint meshOutputPerVertexGranularity;
        public uint meshOutputPerPrimitiveGranularity;
    }
    public unsafe struct VkDrawMeshTasksIndirectCommandNV
    {
        public uint taskCount;
        public uint firstTask;
    }
    public unsafe struct VkPhysicalDeviceMeshShaderFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int taskShader;
        public int meshShader;
        public int multiviewMeshShader;
        public int primitiveFragmentShadingRateMeshShader;
        public int meshShaderQueries;
    }
    public unsafe struct VkPhysicalDeviceMeshShaderPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxTaskWorkGroupTotalCount;
        public fixed uint maxTaskWorkGroupCount[3];
        public uint maxTaskWorkGroupInvocations;
        public fixed uint maxTaskWorkGroupSize[3];
        public uint maxTaskPayloadSize;
        public uint maxTaskSharedMemorySize;
        public uint maxTaskPayloadAndSharedMemorySize;
        public uint maxMeshWorkGroupTotalCount;
        public fixed uint maxMeshWorkGroupCount[3];
        public uint maxMeshWorkGroupInvocations;
        public fixed uint maxMeshWorkGroupSize[3];
        public uint maxMeshSharedMemorySize;
        public uint maxMeshPayloadAndSharedMemorySize;
        public uint maxMeshOutputMemorySize;
        public uint maxMeshPayloadAndOutputMemorySize;
        public uint maxMeshOutputComponents;
        public uint maxMeshOutputVertices;
        public uint maxMeshOutputPrimitives;
        public uint maxMeshOutputLayers;
        public uint maxMeshMultiviewViewCount;
        public uint meshOutputPerVertexGranularity;
        public uint meshOutputPerPrimitiveGranularity;
        public uint maxPreferredTaskWorkGroupInvocations;
        public uint maxPreferredMeshWorkGroupInvocations;
        public int prefersLocalInvocationVertexOutput;
        public int prefersLocalInvocationPrimitiveOutput;
        public int prefersCompactVertexOutput;
        public int prefersCompactPrimitiveOutput;
    }
    public unsafe struct VkDrawMeshTasksIndirectCommandEXT
    {
        public uint groupCountX;
        public uint groupCountY;
        public uint groupCountZ;
    }
    public unsafe struct VkRayTracingShaderGroupCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRayTracingShaderGroupTypeKHR type;
        public uint generalShader;
        public uint closestHitShader;
        public uint anyHitShader;
        public uint intersectionShader;
    }
    public unsafe struct VkRayTracingShaderGroupCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRayTracingShaderGroupTypeKHR type;
        public uint generalShader;
        public uint closestHitShader;
        public uint anyHitShader;
        public uint intersectionShader;
        public void* pShaderGroupCaptureReplayHandle;
    }
    public unsafe struct VkRayTracingPipelineCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlagBits flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public uint groupCount;
        public VkRayTracingShaderGroupCreateInfoNV* pGroups;
        public uint maxRecursionDepth;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
    }
    public unsafe struct VkRayTracingPipelineCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlagBits flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public uint groupCount;
        public VkRayTracingShaderGroupCreateInfoKHR* pGroups;
        public uint maxPipelineRayRecursionDepth;
        public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
        public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
        public VkPipelineDynamicStateCreateInfo* pDynamicState;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
    }
    public unsafe struct VkGeometryTrianglesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer vertexData;
        public ulong vertexOffset;
        public uint vertexCount;
        public ulong vertexStride;
        public VkFormat vertexFormat;
        public VkBuffer indexData;
        public ulong indexOffset;
        public uint indexCount;
        public VkIndexType indexType;
        public VkBuffer transformData;
        public ulong transformOffset;
    }
    public unsafe struct VkGeometryAABBNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer aabbData;
        public uint numAABBs;
        public uint stride;
        public ulong offset;
    }
    public unsafe struct VkGeometryDataNV
    {
        public VkGeometryTrianglesNV triangles;
        public VkGeometryAABBNV aabbs;
    }
    public unsafe struct VkGeometryNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkGeometryTypeKHR geometryType;
        public VkGeometryDataNV geometry;
        public VkGeometryFlagBitsKHR flags;
    }
    public unsafe struct VkAccelerationStructureInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureTypeKHR type;
        public VkBuildAccelerationStructureFlagsNV flags;
        public uint instanceCount;
        public uint geometryCount;
        public VkGeometryNV* pGeometries;
    }
    public unsafe struct VkAccelerationStructureCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong compactedSize;
        public VkAccelerationStructureInfoNV info;
    }
    public unsafe struct VkBindAccelerationStructureMemoryInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureNV accelerationStructure;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
    }
    public unsafe struct VkWriteDescriptorSetAccelerationStructureKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint accelerationStructureCount;
        public VkAccelerationStructureKHR* pAccelerationStructures;
    }
    public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint accelerationStructureCount;
        public VkAccelerationStructureNV* pAccelerationStructures;
    }
    public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureMemoryRequirementsTypeNV type;
        public VkAccelerationStructureNV accelerationStructure;
    }
    public unsafe struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int accelerationStructure;
        public int accelerationStructureCaptureReplay;
        public int accelerationStructureIndirectBuild;
        public int accelerationStructureHostCommands;
        public int descriptorBindingAccelerationStructureUpdateAfterBind;
    }
    public unsafe struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int rayTracingPipeline;
        public int rayTracingPipelineShaderGroupHandleCaptureReplay;
        public int rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
        public int rayTracingPipelineTraceRaysIndirect;
        public int rayTraversalPrimitiveCulling;
    }
    public unsafe struct VkPhysicalDeviceRayQueryFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int rayQuery;
    }
    public unsafe struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong maxGeometryCount;
        public ulong maxInstanceCount;
        public ulong maxPrimitiveCount;
        public uint maxPerStageDescriptorAccelerationStructures;
        public uint maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
        public uint maxDescriptorSetAccelerationStructures;
        public uint maxDescriptorSetUpdateAfterBindAccelerationStructures;
        public uint minAccelerationStructureScratchOffsetAlignment;
    }
    public unsafe struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderGroupHandleSize;
        public uint maxRayRecursionDepth;
        public uint maxShaderGroupStride;
        public uint shaderGroupBaseAlignment;
        public uint shaderGroupHandleCaptureReplaySize;
        public uint maxRayDispatchInvocationCount;
        public uint shaderGroupHandleAlignment;
        public uint maxRayHitAttributeSize;
    }
    public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderGroupHandleSize;
        public uint maxRecursionDepth;
        public uint maxShaderGroupStride;
        public uint shaderGroupBaseAlignment;
        public ulong maxGeometryCount;
        public ulong maxInstanceCount;
        public ulong maxTriangleCount;
        public uint maxDescriptorSetAccelerationStructures;
    }
    public unsafe struct VkStridedDeviceAddressRegionKHR
    {
        public ulong deviceAddress;
        public ulong stride;
        public ulong size;
    }
    public unsafe struct VkTraceRaysIndirectCommandKHR
    {
        public uint width;
        public uint height;
        public uint depth;
    }
    public unsafe struct VkTraceRaysIndirectCommand2KHR
    {
        public ulong raygenShaderRecordAddress;
        public ulong raygenShaderRecordSize;
        public ulong missShaderBindingTableAddress;
        public ulong missShaderBindingTableSize;
        public ulong missShaderBindingTableStride;
        public ulong hitShaderBindingTableAddress;
        public ulong hitShaderBindingTableSize;
        public ulong hitShaderBindingTableStride;
        public ulong callableShaderBindingTableAddress;
        public ulong callableShaderBindingTableSize;
        public ulong callableShaderBindingTableStride;
        public uint width;
        public uint height;
        public uint depth;
    }
    public unsafe struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int rayTracingMaintenance1;
        public int rayTracingPipelineTraceRaysIndirect2;
    }
    public unsafe struct VkDrmFormatModifierPropertiesListEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
    }
    public unsafe struct VkDrmFormatModifierPropertiesEXT
    {
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkFormatFeatureFlagBits drmFormatModifierTilingFeatures;
    }
    public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
    }
    public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public ulong* pDrmFormatModifiers;
    }
    public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkSubresourceLayout* pPlaneLayouts;
    }
    public unsafe struct VkImageDrmFormatModifierPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
    }
    public unsafe struct VkImageStencilUsageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlagBits stencilUsage;
    }
    public unsafe struct VkImageStencilUsageCreateInfoEXT
    {
    }
    public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
    }
    public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int fragmentDensityMap;
        public int fragmentDensityMapDynamic;
        public int fragmentDensityMapNonSubsampledImages;
    }
    public unsafe struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int fragmentDensityMapDeferred;
    }
    public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public int fragmentDensityMapOffset;
    }
    public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D minFragmentDensityTexelSize;
        public VkExtent2D maxFragmentDensityTexelSize;
        public int fragmentDensityInvocations;
    }
    public unsafe struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int subsampledLoads;
        public int subsampledCoarseReconstructionEarlyAccess;
        public uint maxSubsampledArrayLayers;
        public uint maxDescriptorSetSubsampledSamplers;
    }
    public unsafe struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D fragmentDensityOffsetGranularity;
    }
    public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAttachmentReference fragmentDensityMapAttachment;
    }
    public unsafe struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint fragmentDensityOffsetCount;
        public VkOffset2D* pFragmentDensityOffsets;
    }
    public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int scalarBlockLayout;
    }
    public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeaturesEXT
    {
    }
    public unsafe struct VkSurfaceProtectedCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int supportsProtected;
    }
    public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int uniformBufferStandardLayout;
    }
    public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int depthClipEnable;
    }
    public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags;
        public int depthClipEnable;
    }
    public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed ulong heapBudget[16];
        public fixed ulong heapUsage[16];
    }
    public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int memoryPriority;
    }
    public unsafe struct VkMemoryPriorityAllocateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public float priority;
    }
    public unsafe struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int pageableDeviceLocalMemory;
    }
    public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int bufferDeviceAddress;
        public int bufferDeviceAddressCaptureReplay;
        public int bufferDeviceAddressMultiDevice;
    }
    public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int bufferDeviceAddress;
        public int bufferDeviceAddressCaptureReplay;
        public int bufferDeviceAddressMultiDevice;
    }
    public unsafe struct VkPhysicalDeviceBufferAddressFeaturesEXT
    {
    }
    public unsafe struct VkBufferDeviceAddressInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
    }
    public unsafe struct VkBufferDeviceAddressInfoKHR
    {
    }
    public unsafe struct VkBufferDeviceAddressInfoEXT
    {
    }
    public unsafe struct VkBufferOpaqueCaptureAddressCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong opaqueCaptureAddress;
    }
    public unsafe struct VkBufferOpaqueCaptureAddressCreateInfoKHR
    {
    }
    public unsafe struct VkBufferDeviceAddressCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong deviceAddress;
    }
    public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageViewType imageViewType;
    }
    public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int filterCubic;
        public int filterCubicMinmax;
    }
    public unsafe struct VkPhysicalDeviceImagelessFramebufferFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int imagelessFramebuffer;
    }
    public unsafe struct VkPhysicalDeviceImagelessFramebufferFeaturesKHR
    {
    }
    public unsafe struct VkFramebufferAttachmentsCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentImageInfoCount;
        public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
    }
    public unsafe struct VkFramebufferAttachmentsCreateInfoKHR
    {
    }
    public unsafe struct VkFramebufferAttachmentImageInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateFlagBits flags;
        public VkImageUsageFlagBits usage;
        public uint width;
        public uint height;
        public uint layerCount;
        public uint viewFormatCount;
        public VkFormat* pViewFormats;
    }
    public unsafe struct VkFramebufferAttachmentImageInfoKHR
    {
    }
    public unsafe struct VkRenderPassAttachmentBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentCount;
        public VkImageView* pAttachments;
    }
    public unsafe struct VkRenderPassAttachmentBeginInfoKHR
    {
    }
    public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int textureCompressionASTC_HDR;
    }
    public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT
    {
    }
    public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int cooperativeMatrix;
        public int cooperativeMatrixRobustBufferAccess;
    }
    public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlagBits cooperativeMatrixSupportedStages;
    }
    public unsafe struct VkCooperativeMatrixPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint MSize;
        public uint NSize;
        public uint KSize;
        public VkComponentTypeKHR AType;
        public VkComponentTypeKHR BType;
        public VkComponentTypeKHR CType;
        public VkComponentTypeKHR DType;
        public VkScopeKHR scope;
    }
    public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int ycbcrImageArrays;
    }
    public unsafe struct VkImageViewHandleInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public VkDescriptorType descriptorType;
        public VkSampler sampler;
    }
    public unsafe struct VkImageViewAddressPropertiesNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong deviceAddress;
        public ulong size;
    }
    public unsafe struct VkPresentFrameTokenGGP
    {
        public VkStructureType sType;
        public void* pNext;
    }
    public unsafe struct VkPipelineCreationFeedback
    {
        public VkPipelineCreationFeedbackFlagBits flags;
        public ulong duration;
    }
    public unsafe struct VkPipelineCreationFeedbackEXT
    {
    }
    public unsafe struct VkPipelineCreationFeedbackCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreationFeedback* pPipelineCreationFeedback;
        public uint pipelineStageCreationFeedbackCount;
        public VkPipelineCreationFeedback* pPipelineStageCreationFeedbacks;
    }
    public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT
    {
    }
    public unsafe struct VkSurfaceFullScreenExclusiveInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFullScreenExclusiveEXT fullScreenExclusive;
    }
    public unsafe struct VkSurfaceFullScreenExclusiveWin32InfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr hmonitor;
    }
    public unsafe struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int fullScreenExclusiveSupported;
    }
    public unsafe struct VkPhysicalDevicePresentBarrierFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int presentBarrier;
    }
    public unsafe struct VkSurfaceCapabilitiesPresentBarrierNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int presentBarrierSupported;
    }
    public unsafe struct VkSwapchainPresentBarrierCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int presentBarrierEnable;
    }
    public unsafe struct VkPhysicalDevicePerformanceQueryFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int performanceCounterQueryPools;
        public int performanceCounterMultipleQueryPools;
    }
    public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int allowCommandBufferQueryCopies;
    }
    public unsafe struct VkPerformanceCounterKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceCounterUnitKHR unit;
        public VkPerformanceCounterScopeKHR scope;
        public VkPerformanceCounterStorageKHR storage;
        public fixed byte uuid[16];
    }
    public unsafe struct VkPerformanceCounterDescriptionKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceCounterDescriptionFlagBitsKHR flags;
        [InlineArray(256)]
        public struct nameInlineArray
        {
            public byte element;
        }
        public nameInlineArray name;
        [InlineArray(256)]
        public struct categoryInlineArray
        {
            public byte element;
        }
        public categoryInlineArray category;
        [InlineArray(256)]
        public struct descriptionInlineArray
        {
            public byte element;
        }
        public descriptionInlineArray description;
    }
    public unsafe struct VkQueryPoolPerformanceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint queueFamilyIndex;
        public uint counterIndexCount;
        public uint* pCounterIndices;
    }
    public unsafe struct VkPerformanceCounterResultKHR
    {
        public int int32;
        public long int64;
        public uint uint32;
        public ulong uint64;
        public float float32;
        public double float64;
    }
    public unsafe struct VkAcquireProfilingLockInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAcquireProfilingLockFlagBitsKHR flags;
        public ulong timeout;
    }
    public unsafe struct VkPerformanceQuerySubmitInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint counterPassIndex;
    }
    public unsafe struct VkPerformanceQueryReservationInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPerformanceQueriesPerPool;
    }
    public unsafe struct VkHeadlessSurfaceCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkHeadlessSurfaceCreateFlagsEXT flags;
    }
    public unsafe struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int coverageReductionMode;
    }
    public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCoverageReductionStateCreateFlagsNV flags;
        public VkCoverageReductionModeNV coverageReductionMode;
    }
    public unsafe struct VkFramebufferMixedSamplesCombinationNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCoverageReductionModeNV coverageReductionMode;
        public VkSampleCountFlagBits rasterizationSamples;
        public VkSampleCountFlagBits depthStencilSamples;
        public VkSampleCountFlagBits colorSamples;
    }
    public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderIntegerFunctions2;
    }
    public unsafe struct VkPerformanceValueDataINTEL
    {
        public uint value32;
        public ulong value64;
        public float valueFloat;
        public int valueBool;
        public byte* valueString;
    }
    public unsafe struct VkPerformanceValueINTEL
    {
        public VkPerformanceValueTypeINTEL type;
        public VkPerformanceValueDataINTEL data;
    }
    public unsafe struct VkInitializePerformanceApiInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pUserData;
    }
    public unsafe struct VkQueryPoolPerformanceQueryCreateInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
    }
    public unsafe struct VkQueryPoolCreateInfoINTEL
    {
    }
    public unsafe struct VkPerformanceMarkerInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong marker;
    }
    public unsafe struct VkPerformanceStreamMarkerInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public uint marker;
    }
    public unsafe struct VkPerformanceOverrideInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceOverrideTypeINTEL type;
        public int enable;
        public ulong parameter;
    }
    public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceConfigurationTypeINTEL type;
    }
    public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderSubgroupClock;
        public int shaderDeviceClock;
    }
    public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int indexTypeUint8;
    }
    public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
    {
    }
    public unsafe struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderSMCount;
        public uint shaderWarpsPerSM;
    }
    public unsafe struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderSMBuiltins;
    }
    public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int fragmentShaderSampleInterlock;
        public int fragmentShaderPixelInterlock;
        public int fragmentShaderShadingRateInterlock;
    }
    public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int separateDepthStencilLayouts;
    }
    public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR
    {
    }
    public unsafe struct VkAttachmentReferenceStencilLayout
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageLayout stencilLayout;
    }
    public unsafe struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int primitiveTopologyListRestart;
        public int primitiveTopologyPatchListRestart;
    }
    public unsafe struct VkAttachmentReferenceStencilLayoutKHR
    {
    }
    public unsafe struct VkAttachmentDescriptionStencilLayout
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageLayout stencilInitialLayout;
        public VkImageLayout stencilFinalLayout;
    }
    public unsafe struct VkAttachmentDescriptionStencilLayoutKHR
    {
    }
    public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int pipelineExecutableInfo;
    }
    public unsafe struct VkPipelineInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipeline pipeline;
    }
    public unsafe struct VkPipelineInfoEXT
    {
    }
    public unsafe struct VkPipelineExecutablePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlagBits stages;
        [InlineArray(256)]
        public struct nameInlineArray
        {
            public byte element;
        }
        public nameInlineArray name;
        [InlineArray(256)]
        public struct descriptionInlineArray
        {
            public byte element;
        }
        public descriptionInlineArray description;
        public uint subgroupSize;
    }
    public unsafe struct VkPipelineExecutableInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipeline pipeline;
        public uint executableIndex;
    }
    public unsafe struct VkPipelineExecutableStatisticValueKHR
    {
        public int b32;
        public long i64;
        public ulong u64;
        public double f64;
    }
    public unsafe struct VkPipelineExecutableStatisticKHR
    {
        public VkStructureType sType;
        public void* pNext;
        [InlineArray(256)]
        public struct nameInlineArray
        {
            public byte element;
        }
        public nameInlineArray name;
        [InlineArray(256)]
        public struct descriptionInlineArray
        {
            public byte element;
        }
        public descriptionInlineArray description;
        public VkPipelineExecutableStatisticFormatKHR format;
        public VkPipelineExecutableStatisticValueKHR value;
    }
    public unsafe struct VkPipelineExecutableInternalRepresentationKHR
    {
        public VkStructureType sType;
        public void* pNext;
        [InlineArray(256)]
        public struct nameInlineArray
        {
            public byte element;
        }
        public nameInlineArray name;
        [InlineArray(256)]
        public struct descriptionInlineArray
        {
            public byte element;
        }
        public descriptionInlineArray description;
        public int isText;
        public nuint dataSize;
        public void* pData;
    }
    public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderDemoteToHelperInvocation;
    }
    public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
    {
    }
    public unsafe struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int texelBufferAlignment;
    }
    public unsafe struct VkPhysicalDeviceTexelBufferAlignmentProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong storageTexelBufferOffsetAlignmentBytes;
        public int storageTexelBufferOffsetSingleTexelAlignment;
        public ulong uniformTexelBufferOffsetAlignmentBytes;
        public int uniformTexelBufferOffsetSingleTexelAlignment;
    }
    public unsafe struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
    {
    }
    public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int subgroupSizeControl;
        public int computeFullSubgroups;
    }
    public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
    {
    }
    public unsafe struct VkPhysicalDeviceSubgroupSizeControlProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minSubgroupSize;
        public uint maxSubgroupSize;
        public uint maxComputeWorkgroupSubgroups;
        public VkShaderStageFlagBits requiredSubgroupSizeStages;
    }
    public unsafe struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
    {
    }
    public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint requiredSubgroupSize;
    }
    public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
    {
    }
    public unsafe struct VkShaderRequiredSubgroupSizeCreateInfoEXT
    {
    }
    public unsafe struct VkSubpassShadingPipelineCreateInfoHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPass renderPass;
        public uint subpass;
    }
    public unsafe struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxSubpassShadingWorkgroupSizeAspectRatio;
    }
    public unsafe struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed uint maxWorkGroupCount[3];
        public fixed uint maxWorkGroupSize[3];
        public uint maxOutputClusterCount;
        public ulong indirectBufferOffsetAlignment;
    }
    public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong opaqueCaptureAddress;
    }
    public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfoKHR
    {
    }
    public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
    }
    public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfoKHR
    {
    }
    public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int rectangularLines;
        public int bresenhamLines;
        public int smoothLines;
        public int stippledRectangularLines;
        public int stippledBresenhamLines;
        public int stippledSmoothLines;
    }
    public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT
    {
    }
    public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint lineSubPixelPrecisionBits;
    }
    public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT
    {
    }
    public unsafe struct VkPipelineRasterizationLineStateCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkLineRasterizationModeKHR lineRasterizationMode;
        public int stippledLineEnable;
        public uint lineStippleFactor;
        public ushort lineStipplePattern;
    }
    public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT
    {
    }
    public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int pipelineCreationCacheControl;
    }
    public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT
    {
    }
    public unsafe struct VkPhysicalDeviceVulkan11Features
    {
        public VkStructureType sType;
        public void* pNext;
        public int storageBuffer16BitAccess;
        public int uniformAndStorageBuffer16BitAccess;
        public int storagePushConstant16;
        public int storageInputOutput16;
        public int multiview;
        public int multiviewGeometryShader;
        public int multiviewTessellationShader;
        public int variablePointersStorageBuffer;
        public int variablePointers;
        public int protectedMemory;
        public int samplerYcbcrConversion;
        public int shaderDrawParameters;
    }
    public unsafe struct VkPhysicalDeviceVulkan11Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte deviceUUID[16];
        public fixed byte driverUUID[16];
        public fixed byte deviceLUID[8];
        public uint deviceNodeMask;
        public int deviceLUIDValid;
        public uint subgroupSize;
        public VkShaderStageFlagBits subgroupSupportedStages;
        public VkSubgroupFeatureFlagBits subgroupSupportedOperations;
        public int subgroupQuadOperationsInAllStages;
        public VkPointClippingBehavior pointClippingBehavior;
        public uint maxMultiviewViewCount;
        public uint maxMultiviewInstanceIndex;
        public int protectedNoFault;
        public uint maxPerSetDescriptors;
        public ulong maxMemoryAllocationSize;
    }
    public unsafe struct VkPhysicalDeviceVulkan12Features
    {
        public VkStructureType sType;
        public void* pNext;
        public int samplerMirrorClampToEdge;
        public int drawIndirectCount;
        public int storageBuffer8BitAccess;
        public int uniformAndStorageBuffer8BitAccess;
        public int storagePushConstant8;
        public int shaderBufferInt64Atomics;
        public int shaderSharedInt64Atomics;
        public int shaderFloat16;
        public int shaderInt8;
        public int descriptorIndexing;
        public int shaderInputAttachmentArrayDynamicIndexing;
        public int shaderUniformTexelBufferArrayDynamicIndexing;
        public int shaderStorageTexelBufferArrayDynamicIndexing;
        public int shaderUniformBufferArrayNonUniformIndexing;
        public int shaderSampledImageArrayNonUniformIndexing;
        public int shaderStorageBufferArrayNonUniformIndexing;
        public int shaderStorageImageArrayNonUniformIndexing;
        public int shaderInputAttachmentArrayNonUniformIndexing;
        public int shaderUniformTexelBufferArrayNonUniformIndexing;
        public int shaderStorageTexelBufferArrayNonUniformIndexing;
        public int descriptorBindingUniformBufferUpdateAfterBind;
        public int descriptorBindingSampledImageUpdateAfterBind;
        public int descriptorBindingStorageImageUpdateAfterBind;
        public int descriptorBindingStorageBufferUpdateAfterBind;
        public int descriptorBindingUniformTexelBufferUpdateAfterBind;
        public int descriptorBindingStorageTexelBufferUpdateAfterBind;
        public int descriptorBindingUpdateUnusedWhilePending;
        public int descriptorBindingPartiallyBound;
        public int descriptorBindingVariableDescriptorCount;
        public int runtimeDescriptorArray;
        public int samplerFilterMinmax;
        public int scalarBlockLayout;
        public int imagelessFramebuffer;
        public int uniformBufferStandardLayout;
        public int shaderSubgroupExtendedTypes;
        public int separateDepthStencilLayouts;
        public int hostQueryReset;
        public int timelineSemaphore;
        public int bufferDeviceAddress;
        public int bufferDeviceAddressCaptureReplay;
        public int bufferDeviceAddressMultiDevice;
        public int vulkanMemoryModel;
        public int vulkanMemoryModelDeviceScope;
        public int vulkanMemoryModelAvailabilityVisibilityChains;
        public int shaderOutputViewportIndex;
        public int shaderOutputLayer;
        public int subgroupBroadcastDynamicId;
    }
    public unsafe struct VkPhysicalDeviceVulkan12Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDriverId driverID;
        [InlineArray(256)]
        public struct driverNameInlineArray
        {
            public byte element;
        }
        public driverNameInlineArray driverName;
        [InlineArray(256)]
        public struct driverInfoInlineArray
        {
            public byte element;
        }
        public driverInfoInlineArray driverInfo;
        public VkConformanceVersion conformanceVersion;
        public VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public VkShaderFloatControlsIndependence roundingModeIndependence;
        public int shaderSignedZeroInfNanPreserveFloat16;
        public int shaderSignedZeroInfNanPreserveFloat32;
        public int shaderSignedZeroInfNanPreserveFloat64;
        public int shaderDenormPreserveFloat16;
        public int shaderDenormPreserveFloat32;
        public int shaderDenormPreserveFloat64;
        public int shaderDenormFlushToZeroFloat16;
        public int shaderDenormFlushToZeroFloat32;
        public int shaderDenormFlushToZeroFloat64;
        public int shaderRoundingModeRTEFloat16;
        public int shaderRoundingModeRTEFloat32;
        public int shaderRoundingModeRTEFloat64;
        public int shaderRoundingModeRTZFloat16;
        public int shaderRoundingModeRTZFloat32;
        public int shaderRoundingModeRTZFloat64;
        public uint maxUpdateAfterBindDescriptorsInAllPools;
        public int shaderUniformBufferArrayNonUniformIndexingNative;
        public int shaderSampledImageArrayNonUniformIndexingNative;
        public int shaderStorageBufferArrayNonUniformIndexingNative;
        public int shaderStorageImageArrayNonUniformIndexingNative;
        public int shaderInputAttachmentArrayNonUniformIndexingNative;
        public int robustBufferAccessUpdateAfterBind;
        public int quadDivergentImplicitLod;
        public uint maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint maxPerStageUpdateAfterBindResources;
        public uint maxDescriptorSetUpdateAfterBindSamplers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindSampledImages;
        public uint maxDescriptorSetUpdateAfterBindStorageImages;
        public uint maxDescriptorSetUpdateAfterBindInputAttachments;
        public VkResolveModeFlagBits supportedDepthResolveModes;
        public VkResolveModeFlagBits supportedStencilResolveModes;
        public int independentResolveNone;
        public int independentResolve;
        public int filterMinmaxSingleComponentFormats;
        public int filterMinmaxImageComponentMapping;
        public ulong maxTimelineSemaphoreValueDifference;
        public VkSampleCountFlagBits framebufferIntegerColorSampleCounts;
    }
    public unsafe struct VkPhysicalDeviceVulkan13Features
    {
        public VkStructureType sType;
        public void* pNext;
        public int robustImageAccess;
        public int inlineUniformBlock;
        public int descriptorBindingInlineUniformBlockUpdateAfterBind;
        public int pipelineCreationCacheControl;
        public int privateData;
        public int shaderDemoteToHelperInvocation;
        public int shaderTerminateInvocation;
        public int subgroupSizeControl;
        public int computeFullSubgroups;
        public int synchronization2;
        public int textureCompressionASTC_HDR;
        public int shaderZeroInitializeWorkgroupMemory;
        public int dynamicRendering;
        public int shaderIntegerDotProduct;
        public int maintenance4;
    }
    public unsafe struct VkPhysicalDeviceVulkan13Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minSubgroupSize;
        public uint maxSubgroupSize;
        public uint maxComputeWorkgroupSubgroups;
        public VkShaderStageFlagBits requiredSubgroupSizeStages;
        public uint maxInlineUniformBlockSize;
        public uint maxPerStageDescriptorInlineUniformBlocks;
        public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        public uint maxDescriptorSetInlineUniformBlocks;
        public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
        public uint maxInlineUniformTotalSize;
        public int integerDotProduct8BitUnsignedAccelerated;
        public int integerDotProduct8BitSignedAccelerated;
        public int integerDotProduct8BitMixedSignednessAccelerated;
        public int integerDotProduct4x8BitPackedUnsignedAccelerated;
        public int integerDotProduct4x8BitPackedSignedAccelerated;
        public int integerDotProduct4x8BitPackedMixedSignednessAccelerated;
        public int integerDotProduct16BitUnsignedAccelerated;
        public int integerDotProduct16BitSignedAccelerated;
        public int integerDotProduct16BitMixedSignednessAccelerated;
        public int integerDotProduct32BitUnsignedAccelerated;
        public int integerDotProduct32BitSignedAccelerated;
        public int integerDotProduct32BitMixedSignednessAccelerated;
        public int integerDotProduct64BitUnsignedAccelerated;
        public int integerDotProduct64BitSignedAccelerated;
        public int integerDotProduct64BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating8BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
        public int integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating16BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating32BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating64BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
        public ulong storageTexelBufferOffsetAlignmentBytes;
        public int storageTexelBufferOffsetSingleTexelAlignment;
        public ulong uniformTexelBufferOffsetAlignmentBytes;
        public int uniformTexelBufferOffsetSingleTexelAlignment;
        public ulong maxBufferSize;
    }
    public unsafe struct VkPipelineCompilerControlCreateInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCompilerControlFlagBitsAMD compilerControlFlags;
    }
    public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public int deviceCoherentMemory;
    }
    public unsafe struct VkFaultData
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFaultLevel faultLevel;
        public VkFaultType faultType;
    }
    public unsafe struct VkFaultCallbackInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint faultCount;
        public VkFaultData* pFaults;
        public IntPtr pfnFaultCallback;
    }
    public unsafe struct VkPhysicalDeviceToolProperties
    {
        public VkStructureType sType;
        public void* pNext;
        [InlineArray(256)]
        public struct nameInlineArray
        {
            public byte element;
        }
        public nameInlineArray name;
        [InlineArray(256)]
        public struct versionInlineArray
        {
            public byte element;
        }
        public versionInlineArray version;
        public VkToolPurposeFlagBits purposes;
        [InlineArray(256)]
        public struct descriptionInlineArray
        {
            public byte element;
        }
        public descriptionInlineArray description;
        [InlineArray(256)]
        public struct layerInlineArray
        {
            public byte element;
        }
        public layerInlineArray layer;
    }
    public unsafe struct VkPhysicalDeviceToolPropertiesEXT
    {
    }
    public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkClearColorValue customBorderColor;
        public VkFormat format;
    }
    public unsafe struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxCustomBorderColorSamplers;
    }
    public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int customBorderColors;
        public int customBorderColorWithoutFormat;
    }
    public unsafe struct VkSamplerBorderColorComponentMappingCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkComponentMapping components;
        public int srgb;
    }
    public unsafe struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int borderColorSwizzle;
        public int borderColorSwizzleFromImage;
    }
    public unsafe struct VkDeviceOrHostAddressKHR
    {
        public ulong deviceAddress;
        public void* hostAddress;
    }
    public unsafe struct VkDeviceOrHostAddressConstKHR
    {
        public ulong deviceAddress;
        public void* hostAddress;
    }
    public unsafe struct VkDeviceOrHostAddressConstAMDX
    {
        public ulong deviceAddress;
        public void* hostAddress;
    }
    public unsafe struct VkAccelerationStructureGeometryTrianglesDataKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat vertexFormat;
        public VkDeviceOrHostAddressConstKHR vertexData;
        public ulong vertexStride;
        public uint maxVertex;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexData;
        public VkDeviceOrHostAddressConstKHR transformData;
    }
    public unsafe struct VkAccelerationStructureGeometryAabbsDataKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR data;
        public ulong stride;
    }
    public unsafe struct VkAccelerationStructureGeometryInstancesDataKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int arrayOfPointers;
        public VkDeviceOrHostAddressConstKHR data;
    }
    public unsafe struct VkAccelerationStructureGeometryDataKHR
    {
        public VkAccelerationStructureGeometryTrianglesDataKHR triangles;
        public VkAccelerationStructureGeometryAabbsDataKHR aabbs;
        public VkAccelerationStructureGeometryInstancesDataKHR instances;
    }
    public unsafe struct VkAccelerationStructureGeometryKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkGeometryTypeKHR geometryType;
        public VkAccelerationStructureGeometryDataKHR geometry;
        public VkGeometryFlagBitsKHR flags;
    }
    public unsafe struct VkAccelerationStructureBuildGeometryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureTypeKHR type;
        public VkBuildAccelerationStructureFlagBitsKHR flags;
        public VkBuildAccelerationStructureModeKHR mode;
        public VkAccelerationStructureKHR srcAccelerationStructure;
        public VkAccelerationStructureKHR dstAccelerationStructure;
        public uint geometryCount;
        public VkAccelerationStructureGeometryKHR* pGeometries;
        public VkAccelerationStructureGeometryKHR** ppGeometries;
        public VkDeviceOrHostAddressKHR scratchData;
    }
    public unsafe struct VkAccelerationStructureBuildRangeInfoKHR
    {
        public uint primitiveCount;
        public uint primitiveOffset;
        public uint firstVertex;
        public uint transformOffset;
    }
    public unsafe struct VkAccelerationStructureCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureCreateFlagBitsKHR createFlags;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        public VkAccelerationStructureTypeKHR type;
        public ulong deviceAddress;
    }
    public unsafe struct VkAabbPositionsKHR
    {
        public float minX;
        public float minY;
        public float minZ;
        public float maxX;
        public float maxY;
        public float maxZ;
    }
    public unsafe struct VkAabbPositionsNV
    {
    }
    public unsafe struct VkTransformMatrixKHR
    {
        public Matrix4x3 matrix;
    }
    public unsafe struct VkTransformMatrixNV
    {
    }
    public unsafe struct VkAccelerationStructureInstanceKHR
    {
        public VkTransformMatrixKHR transform;
        public uint instanceCustomIndex;
        public uint mask;
        public uint instanceShaderBindingTableRecordOffset;
        public VkGeometryInstanceFlagBitsKHR flags;
        public ulong accelerationStructureReference;
    }
    public unsafe struct VkAccelerationStructureInstanceNV
    {
    }
    public unsafe struct VkAccelerationStructureDeviceAddressInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR accelerationStructure;
    }
    public unsafe struct VkAccelerationStructureVersionInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pVersionData;
    }
    public unsafe struct VkCopyAccelerationStructureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR src;
        public VkAccelerationStructureKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
    }
    public unsafe struct VkCopyAccelerationStructureToMemoryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR src;
        public VkDeviceOrHostAddressKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
    }
    public unsafe struct VkCopyMemoryToAccelerationStructureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR src;
        public VkAccelerationStructureKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
    }
    public unsafe struct VkRayTracingPipelineInterfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPipelineRayPayloadSize;
        public uint maxPipelineRayHitAttributeSize;
    }
    public unsafe struct VkPipelineLibraryCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint libraryCount;
        public VkPipeline* pLibraries;
    }
    public unsafe struct VkRefreshObjectKHR
    {
        public VkObjectType objectType;
        public ulong objectHandle;
        public VkRefreshObjectFlagBitsKHR flags;
    }
    public unsafe struct VkRefreshObjectListKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint objectCount;
        public VkRefreshObjectKHR* pObjects;
    }
    public unsafe struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int extendedDynamicState;
    }
    public unsafe struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int extendedDynamicState2;
        public int extendedDynamicState2LogicOp;
        public int extendedDynamicState2PatchControlPoints;
    }
    public unsafe struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int extendedDynamicState3TessellationDomainOrigin;
        public int extendedDynamicState3DepthClampEnable;
        public int extendedDynamicState3PolygonMode;
        public int extendedDynamicState3RasterizationSamples;
        public int extendedDynamicState3SampleMask;
        public int extendedDynamicState3AlphaToCoverageEnable;
        public int extendedDynamicState3AlphaToOneEnable;
        public int extendedDynamicState3LogicOpEnable;
        public int extendedDynamicState3ColorBlendEnable;
        public int extendedDynamicState3ColorBlendEquation;
        public int extendedDynamicState3ColorWriteMask;
        public int extendedDynamicState3RasterizationStream;
        public int extendedDynamicState3ConservativeRasterizationMode;
        public int extendedDynamicState3ExtraPrimitiveOverestimationSize;
        public int extendedDynamicState3DepthClipEnable;
        public int extendedDynamicState3SampleLocationsEnable;
        public int extendedDynamicState3ColorBlendAdvanced;
        public int extendedDynamicState3ProvokingVertexMode;
        public int extendedDynamicState3LineRasterizationMode;
        public int extendedDynamicState3LineStippleEnable;
        public int extendedDynamicState3DepthClipNegativeOneToOne;
        public int extendedDynamicState3ViewportWScalingEnable;
        public int extendedDynamicState3ViewportSwizzle;
        public int extendedDynamicState3CoverageToColorEnable;
        public int extendedDynamicState3CoverageToColorLocation;
        public int extendedDynamicState3CoverageModulationMode;
        public int extendedDynamicState3CoverageModulationTableEnable;
        public int extendedDynamicState3CoverageModulationTable;
        public int extendedDynamicState3CoverageReductionMode;
        public int extendedDynamicState3RepresentativeFragmentTestEnable;
        public int extendedDynamicState3ShadingRateImageEnable;
    }
    public unsafe struct VkPhysicalDeviceExtendedDynamicState3PropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int dynamicPrimitiveTopologyUnrestricted;
    }
    public unsafe struct VkColorBlendEquationEXT
    {
        public VkBlendFactor srcColorBlendFactor;
        public VkBlendFactor dstColorBlendFactor;
        public VkBlendOp colorBlendOp;
        public VkBlendFactor srcAlphaBlendFactor;
        public VkBlendFactor dstAlphaBlendFactor;
        public VkBlendOp alphaBlendOp;
    }
    public unsafe struct VkColorBlendAdvancedEXT
    {
        public VkBlendOp advancedBlendOp;
        public int srcPremultiplied;
        public int dstPremultiplied;
        public VkBlendOverlapEXT blendOverlap;
        public int clampResults;
    }
    public unsafe struct VkRenderPassTransformBeginInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceTransformFlagBitsKHR transform;
    }
    public unsafe struct VkCopyCommandTransformInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceTransformFlagBitsKHR transform;
    }
    public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceTransformFlagBitsKHR transform;
        public VkRect2D renderArea;
    }
    public unsafe struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int diagnosticsConfig;
    }
    public unsafe struct VkDeviceDiagnosticsConfigCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceDiagnosticsConfigFlagBitsNV flags;
    }
    public unsafe struct VkPipelineOfflineCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte pipelineIdentifier[16];
        public VkPipelineMatchControl matchControl;
        public ulong poolEntrySize;
    }
    public unsafe struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderZeroInitializeWorkgroupMemory;
    }
    public unsafe struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderSubgroupUniformControlFlow;
    }
    public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int robustBufferAccess2;
        public int robustImageAccess2;
        public int nullDescriptor;
    }
    public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong robustStorageBufferAccessSizeAlignment;
        public ulong robustUniformBufferAccessSizeAlignment;
    }
    public unsafe struct VkPhysicalDeviceImageRobustnessFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int robustImageAccess;
    }
    public unsafe struct VkPhysicalDeviceImageRobustnessFeaturesEXT
    {
    }
    public unsafe struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int workgroupMemoryExplicitLayout;
        public int workgroupMemoryExplicitLayoutScalarBlockLayout;
        public int workgroupMemoryExplicitLayout8BitAccess;
        public int workgroupMemoryExplicitLayout16BitAccess;
    }
    public unsafe struct VkPhysicalDevicePortabilitySubsetFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int constantAlphaColorBlendFactors;
        public int events;
        public int imageViewFormatReinterpretation;
        public int imageViewFormatSwizzle;
        public int imageView2DOn3DImage;
        public int multisampleArrayImage;
        public int mutableComparisonSamplers;
        public int pointPolygons;
        public int samplerMipLodBias;
        public int separateStencilMaskRef;
        public int shaderSampleRateInterpolationFunctions;
        public int tessellationIsolines;
        public int tessellationPointMode;
        public int triangleFans;
        public int vertexAttributeAccessBeyondStride;
    }
    public unsafe struct VkPhysicalDevicePortabilitySubsetPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minVertexInputBindingStrideAlignment;
    }
    public unsafe struct VkPhysicalDevice4444FormatsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int formatA4R4G4B4;
        public int formatA4B4G4R4;
    }
    public unsafe struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public int subpassShading;
    }
    public unsafe struct VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public int clustercullingShader;
        public int multiviewClusterCullingShader;
    }
    public unsafe struct VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public int clusterShadingRate;
    }
    public unsafe struct VkBufferCopy2
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong srcOffset;
        public ulong dstOffset;
        public ulong size;
    }
    public unsafe struct VkBufferCopy2KHR
    {
    }
    public unsafe struct VkImageCopy2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
    }
    public unsafe struct VkImageCopy2KHR
    {
    }
    public unsafe struct VkImageBlit2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        [InlineArray(2)]
        public struct srcOffsetsInlineArray
        {
            public VkOffset3D element;
        }
        public srcOffsetsInlineArray srcOffsets;
        public VkImageSubresourceLayers dstSubresource;
        [InlineArray(2)]
        public struct dstOffsetsInlineArray
        {
            public VkOffset3D element;
        }
        public dstOffsetsInlineArray dstOffsets;
    }
    public unsafe struct VkImageBlit2KHR
    {
    }
    public unsafe struct VkBufferImageCopy2
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong bufferOffset;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
    }
    public unsafe struct VkBufferImageCopy2KHR
    {
    }
    public unsafe struct VkImageResolve2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
    }
    public unsafe struct VkImageResolve2KHR
    {
    }
    public unsafe struct VkCopyBufferInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer srcBuffer;
        public VkBuffer dstBuffer;
        public uint regionCount;
        public VkBufferCopy2* pRegions;
    }
    public unsafe struct VkCopyBufferInfo2KHR
    {
    }
    public unsafe struct VkCopyImageInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageCopy2* pRegions;
    }
    public unsafe struct VkCopyImageInfo2KHR
    {
    }
    public unsafe struct VkBlitImageInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageBlit2* pRegions;
        public VkFilter filter;
    }
    public unsafe struct VkBlitImageInfo2KHR
    {
    }
    public unsafe struct VkCopyBufferToImageInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer srcBuffer;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkBufferImageCopy2* pRegions;
    }
    public unsafe struct VkCopyBufferToImageInfo2KHR
    {
    }
    public unsafe struct VkCopyImageToBufferInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkBuffer dstBuffer;
        public uint regionCount;
        public VkBufferImageCopy2* pRegions;
    }
    public unsafe struct VkCopyImageToBufferInfo2KHR
    {
    }
    public unsafe struct VkResolveImageInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageResolve2* pRegions;
    }
    public unsafe struct VkResolveImageInfo2KHR
    {
    }
    public unsafe struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderImageInt64Atomics;
        public int sparseImageInt64Atomics;
    }
    public unsafe struct VkFragmentShadingRateAttachmentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAttachmentReference2* pFragmentShadingRateAttachment;
        public VkExtent2D shadingRateAttachmentTexelSize;
    }
    public unsafe struct VkPipelineFragmentShadingRateStateCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D fragmentSize;
        [InlineArray(2)]
        public struct combinerOpsInlineArray
        {
            public VkFragmentShadingRateCombinerOpKHR element;
        }
        public combinerOpsInlineArray combinerOps;
    }
    public unsafe struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int pipelineFragmentShadingRate;
        public int primitiveFragmentShadingRate;
        public int attachmentFragmentShadingRate;
    }
    public unsafe struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D minFragmentShadingRateAttachmentTexelSize;
        public VkExtent2D maxFragmentShadingRateAttachmentTexelSize;
        public uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
        public int primitiveFragmentShadingRateWithMultipleViewports;
        public int layeredShadingRateAttachments;
        public int fragmentShadingRateNonTrivialCombinerOps;
        public VkExtent2D maxFragmentSize;
        public uint maxFragmentSizeAspectRatio;
        public uint maxFragmentShadingRateCoverageSamples;
        public VkSampleCountFlagBits maxFragmentShadingRateRasterizationSamples;
        public int fragmentShadingRateWithShaderDepthStencilWrites;
        public int fragmentShadingRateWithSampleMask;
        public int fragmentShadingRateWithShaderSampleMask;
        public int fragmentShadingRateWithConservativeRasterization;
        public int fragmentShadingRateWithFragmentShaderInterlock;
        public int fragmentShadingRateWithCustomSampleLocations;
        public int fragmentShadingRateStrictMultiplyCombiner;
    }
    public unsafe struct VkPhysicalDeviceFragmentShadingRateKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlagBits sampleCounts;
        public VkExtent2D fragmentSize;
    }
    public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderTerminateInvocation;
    }
    public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int fragmentShadingRateEnums;
        public int supersampleFragmentShadingRates;
        public int noInvocationFragmentShadingRates;
    }
    public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlagBits maxFragmentShadingRateInvocationCount;
    }
    public unsafe struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFragmentShadingRateTypeNV shadingRateType;
        public VkFragmentShadingRateNV shadingRate;
        [InlineArray(2)]
        public struct combinerOpsInlineArray
        {
            public VkFragmentShadingRateCombinerOpKHR element;
        }
        public combinerOpsInlineArray combinerOps;
    }
    public unsafe struct VkAccelerationStructureBuildSizesInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong accelerationStructureSize;
        public ulong updateScratchSize;
        public ulong buildScratchSize;
    }
    public unsafe struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int image2DViewOf3D;
        public int sampler2DViewOf3D;
    }
    public unsafe struct VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int imageSlicedViewOf3D;
    }
    public unsafe struct VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int attachmentFeedbackLoopDynamicState;
    }
    public unsafe struct VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int legacyVertexAttributes;
    }
    public unsafe struct VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int nativeUnalignedPerformance;
    }
    public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int mutableDescriptorType;
    }
    public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
    {
    }
    public unsafe struct VkMutableDescriptorTypeListEXT
    {
        public uint descriptorTypeCount;
        public VkDescriptorType* pDescriptorTypes;
    }
    public unsafe struct VkMutableDescriptorTypeListVALVE
    {
    }
    public unsafe struct VkMutableDescriptorTypeCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint mutableDescriptorTypeListCount;
        public VkMutableDescriptorTypeListEXT* pMutableDescriptorTypeLists;
    }
    public unsafe struct VkMutableDescriptorTypeCreateInfoVALVE
    {
    }
    public unsafe struct VkPhysicalDeviceDepthClipControlFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int depthClipControl;
    }
    public unsafe struct VkPipelineViewportDepthClipControlCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int negativeOneToOne;
    }
    public unsafe struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int vertexInputDynamicState;
    }
    public unsafe struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int externalMemoryRDMA;
    }
    public unsafe struct VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderRelaxedExtendedInstruction;
    }
    public unsafe struct VkVertexInputBindingDescription2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint binding;
        public uint stride;
        public VkVertexInputRate inputRate;
        public uint divisor;
    }
    public unsafe struct VkVertexInputAttributeDescription2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint location;
        public uint binding;
        public VkFormat format;
        public uint offset;
    }
    public unsafe struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int colorWriteEnable;
    }
    public unsafe struct VkPipelineColorWriteCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentCount;
        public int* pColorWriteEnables;
    }
    public unsafe struct VkMemoryBarrier2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags2 srcStageMask;
        public VkAccessFlags2 srcAccessMask;
        public VkPipelineStageFlags2 dstStageMask;
        public VkAccessFlags2 dstAccessMask;
    }
    public unsafe struct VkMemoryBarrier2KHR
    {
    }
    public unsafe struct VkImageMemoryBarrier2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags2 srcStageMask;
        public VkAccessFlags2 srcAccessMask;
        public VkPipelineStageFlags2 dstStageMask;
        public VkAccessFlags2 dstAccessMask;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkImage image;
        public VkImageSubresourceRange subresourceRange;
    }
    public unsafe struct VkImageMemoryBarrier2KHR
    {
    }
    public unsafe struct VkBufferMemoryBarrier2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags2 srcStageMask;
        public VkAccessFlags2 srcAccessMask;
        public VkPipelineStageFlags2 dstStageMask;
        public VkAccessFlags2 dstAccessMask;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
    }
    public unsafe struct VkBufferMemoryBarrier2KHR
    {
    }
    public unsafe struct VkDependencyInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDependencyFlagBits dependencyFlags;
        public uint memoryBarrierCount;
        public VkMemoryBarrier2* pMemoryBarriers;
        public uint bufferMemoryBarrierCount;
        public VkBufferMemoryBarrier2* pBufferMemoryBarriers;
        public uint imageMemoryBarrierCount;
        public VkImageMemoryBarrier2* pImageMemoryBarriers;
    }
    public unsafe struct VkDependencyInfoKHR
    {
    }
    public unsafe struct VkSemaphoreSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public ulong value;
        public VkPipelineStageFlags2 stageMask;
        public uint deviceIndex;
    }
    public unsafe struct VkSemaphoreSubmitInfoKHR
    {
    }
    public unsafe struct VkCommandBufferSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandBuffer commandBuffer;
        public uint deviceMask;
    }
    public unsafe struct VkCommandBufferSubmitInfoKHR
    {
    }
    public unsafe struct VkSubmitInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubmitFlagBits flags;
        public uint waitSemaphoreInfoCount;
        public VkSemaphoreSubmitInfo* pWaitSemaphoreInfos;
        public uint commandBufferInfoCount;
        public VkCommandBufferSubmitInfo* pCommandBufferInfos;
        public uint signalSemaphoreInfoCount;
        public VkSemaphoreSubmitInfo* pSignalSemaphoreInfos;
    }
    public unsafe struct VkSubmitInfo2KHR
    {
    }
    public unsafe struct VkQueueFamilyCheckpointProperties2NV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags2 checkpointExecutionStageMask;
    }
    public unsafe struct VkCheckpointData2NV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags2 stage;
        public void* pCheckpointMarker;
    }
    public unsafe struct VkPhysicalDeviceSynchronization2Features
    {
        public VkStructureType sType;
        public void* pNext;
        public int synchronization2;
    }
    public unsafe struct VkPhysicalDeviceSynchronization2FeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceHostImageCopyFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int hostImageCopy;
    }
    public unsafe struct VkPhysicalDeviceHostImageCopyPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint copySrcLayoutCount;
        public VkImageLayout* pCopySrcLayouts;
        public uint copyDstLayoutCount;
        public VkImageLayout* pCopyDstLayouts;
        public fixed byte optimalTilingLayoutUUID[16];
        public int identicalMemoryTypeRequirements;
    }
    public unsafe struct VkMemoryToImageCopyEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pHostPointer;
        public uint memoryRowLength;
        public uint memoryImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
    }
    public unsafe struct VkImageToMemoryCopyEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pHostPointer;
        public uint memoryRowLength;
        public uint memoryImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
    }
    public unsafe struct VkCopyMemoryToImageInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkHostImageCopyFlagBitsEXT flags;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkMemoryToImageCopyEXT* pRegions;
    }
    public unsafe struct VkCopyImageToMemoryInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkHostImageCopyFlagBitsEXT flags;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public uint regionCount;
        public VkImageToMemoryCopyEXT* pRegions;
    }
    public unsafe struct VkCopyImageToImageInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkHostImageCopyFlagBitsEXT flags;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageCopy2* pRegions;
    }
    public unsafe struct VkHostImageLayoutTransitionInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public VkImageSubresourceRange subresourceRange;
    }
    public unsafe struct VkSubresourceHostMemcpySizeEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong size;
    }
    public unsafe struct VkHostImageCopyDevicePerformanceQueryEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int optimalDeviceAccess;
        public int identicalMemoryLayout;
    }
    public unsafe struct VkPhysicalDeviceVulkanSC10Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public int deviceNoDynamicHostAllocations;
        public int deviceDestroyFreesMemory;
        public int commandPoolMultipleCommandBuffersRecording;
        public int commandPoolResetCommandBuffer;
        public int commandBufferSimultaneousUse;
        public int secondaryCommandBufferNullOrImagelessFramebuffer;
        public int recycleDescriptorSetMemory;
        public int recyclePipelineMemory;
        public uint maxRenderPassSubpasses;
        public uint maxRenderPassDependencies;
        public uint maxSubpassInputAttachments;
        public uint maxSubpassPreserveAttachments;
        public uint maxFramebufferAttachments;
        public uint maxDescriptorSetLayoutBindings;
        public uint maxQueryFaultCount;
        public uint maxCallbackFaultCount;
        public uint maxCommandPoolCommandBuffers;
        public ulong maxCommandBufferSize;
    }
    public unsafe struct VkPipelinePoolSize
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong poolEntrySize;
        public uint poolEntryCount;
    }
    public unsafe struct VkDeviceObjectReservationCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint pipelineCacheCreateInfoCount;
        public VkPipelineCacheCreateInfo* pPipelineCacheCreateInfos;
        public uint pipelinePoolSizeCount;
        public VkPipelinePoolSize* pPipelinePoolSizes;
        public uint semaphoreRequestCount;
        public uint commandBufferRequestCount;
        public uint fenceRequestCount;
        public uint deviceMemoryRequestCount;
        public uint bufferRequestCount;
        public uint imageRequestCount;
        public uint eventRequestCount;
        public uint queryPoolRequestCount;
        public uint bufferViewRequestCount;
        public uint imageViewRequestCount;
        public uint layeredImageViewRequestCount;
        public uint pipelineCacheRequestCount;
        public uint pipelineLayoutRequestCount;
        public uint renderPassRequestCount;
        public uint graphicsPipelineRequestCount;
        public uint computePipelineRequestCount;
        public uint descriptorSetLayoutRequestCount;
        public uint samplerRequestCount;
        public uint descriptorPoolRequestCount;
        public uint descriptorSetRequestCount;
        public uint framebufferRequestCount;
        public uint commandPoolRequestCount;
        public uint samplerYcbcrConversionRequestCount;
        public uint surfaceRequestCount;
        public uint swapchainRequestCount;
        public uint displayModeRequestCount;
        public uint subpassDescriptionRequestCount;
        public uint attachmentDescriptionRequestCount;
        public uint descriptorSetLayoutBindingRequestCount;
        public uint descriptorSetLayoutBindingLimit;
        public uint maxImageViewMipLevels;
        public uint maxImageViewArrayLayers;
        public uint maxLayeredImageViewMipLevels;
        public uint maxOcclusionQueriesPerPool;
        public uint maxPipelineStatisticsQueriesPerPool;
        public uint maxTimestampQueriesPerPool;
        public uint maxImmutableSamplersPerDescriptorSetLayout;
    }
    public unsafe struct VkCommandPoolMemoryReservationCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong commandPoolReservedSize;
        public uint commandPoolMaxCommandBuffers;
    }
    public unsafe struct VkCommandPoolMemoryConsumption
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong commandPoolAllocated;
        public ulong commandPoolReservedSize;
        public ulong commandBufferAllocated;
    }
    public unsafe struct VkPhysicalDeviceVulkanSC10Features
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderAtomicInstructions;
    }
    public unsafe struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int primitivesGeneratedQuery;
        public int primitivesGeneratedQueryWithRasterizerDiscard;
        public int primitivesGeneratedQueryWithNonZeroStreams;
    }
    public unsafe struct VkPhysicalDeviceLegacyDitheringFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int legacyDithering;
    }
    public unsafe struct VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int multisampledRenderToSingleSampled;
    }
    public unsafe struct VkSubpassResolvePerformanceQueryEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int optimal;
    }
    public unsafe struct VkMultisampledRenderToSingleSampledInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int multisampledRenderToSingleSampledEnable;
        public VkSampleCountFlagBits rasterizationSamples;
    }
    public unsafe struct VkPhysicalDevicePipelineProtectedAccessFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int pipelineProtectedAccess;
    }
    public unsafe struct VkQueueFamilyVideoPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoCodecOperationFlagBitsKHR videoCodecOperations;
    }
    public unsafe struct VkQueueFamilyQueryResultStatusPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int queryResultStatusSupport;
    }
    public unsafe struct VkVideoProfileListInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint profileCount;
        public VkVideoProfileInfoKHR* pProfiles;
    }
    public unsafe struct VkPhysicalDeviceVideoFormatInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlagBits imageUsage;
    }
    public unsafe struct VkVideoFormatPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkComponentMapping componentMapping;
        public VkImageCreateFlagBits imageCreateFlags;
        public VkImageType imageType;
        public VkImageTiling imageTiling;
        public VkImageUsageFlagBits imageUsageFlags;
    }
    public unsafe struct VkVideoProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoCodecOperationFlagBitsKHR videoCodecOperation;
        public VkVideoChromaSubsamplingFlagBitsKHR chromaSubsampling;
        public VkVideoComponentBitDepthFlagBitsKHR lumaBitDepth;
        public VkVideoComponentBitDepthFlagBitsKHR chromaBitDepth;
    }
    public unsafe struct VkVideoCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoCapabilityFlagBitsKHR flags;
        public ulong minBitstreamBufferOffsetAlignment;
        public ulong minBitstreamBufferSizeAlignment;
        public VkExtent2D pictureAccessGranularity;
        public VkExtent2D minCodedExtent;
        public VkExtent2D maxCodedExtent;
        public uint maxDpbSlots;
        public uint maxActiveReferencePictures;
        public VkExtensionProperties stdHeaderVersion;
    }
    public unsafe struct VkVideoSessionMemoryRequirementsKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryBindIndex;
        public VkMemoryRequirements memoryRequirements;
    }
    public unsafe struct VkBindVideoSessionMemoryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryBindIndex;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public ulong memorySize;
    }
    public unsafe struct VkVideoPictureResourceInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOffset2D codedOffset;
        public VkExtent2D codedExtent;
        public uint baseArrayLayer;
        public VkImageView imageViewBinding;
    }
    public unsafe struct VkVideoReferenceSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int slotIndex;
        public VkVideoPictureResourceInfoKHR* pPictureResource;
    }
    public unsafe struct VkVideoDecodeCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoDecodeCapabilityFlagBitsKHR flags;
    }
    public unsafe struct VkVideoDecodeUsageInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoDecodeUsageFlagBitsKHR videoUsageHints;
    }
    public unsafe struct VkVideoDecodeInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoDecodeFlagsKHR flags;
        public VkBuffer srcBuffer;
        public ulong srcBufferOffset;
        public ulong srcBufferRange;
        public VkVideoPictureResourceInfoKHR dstPictureResource;
        public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
        public uint referenceSlotCount;
        public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
    }
    public unsafe struct VkPhysicalDeviceVideoMaintenance1FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int videoMaintenance1;
    }
    public unsafe struct VkVideoInlineQueryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueryPool queryPool;
        public uint firstQuery;
        public uint queryCount;
    }
    public unsafe struct VkVideoDecodeH264ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoH264ProfileIdc stdProfileIdc;
        public VkVideoDecodeH264PictureLayoutFlagBitsKHR pictureLayout;
    }
    public unsafe struct VkVideoDecodeH264CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoH264LevelIdc maxLevelIdc;
        public VkOffset2D fieldOffsetGranularity;
    }
    public unsafe struct VkVideoDecodeH264SessionParametersAddInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stdSPSCount;
        public StdVideoH264SequenceParameterSet* pStdSPSs;
        public uint stdPPSCount;
        public StdVideoH264PictureParameterSet* pStdPPSs;
    }
    public unsafe struct VkVideoDecodeH264SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoDecodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
    }
    public unsafe struct VkVideoDecodeH264PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoDecodeH264PictureInfo* pStdPictureInfo;
        public uint sliceCount;
        public uint* pSliceOffsets;
    }
    public unsafe struct VkVideoDecodeH264DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoDecodeH264ReferenceInfo* pStdReferenceInfo;
    }
    public unsafe struct VkVideoDecodeH265ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoH265ProfileIdc stdProfileIdc;
    }
    public unsafe struct VkVideoDecodeH265CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoH265LevelIdc maxLevelIdc;
    }
    public unsafe struct VkVideoDecodeH265SessionParametersAddInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stdVPSCount;
        public StdVideoH265VideoParameterSet* pStdVPSs;
        public uint stdSPSCount;
        public StdVideoH265SequenceParameterSet* pStdSPSs;
        public uint stdPPSCount;
        public StdVideoH265PictureParameterSet* pStdPPSs;
    }
    public unsafe struct VkVideoDecodeH265SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxStdVPSCount;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoDecodeH265SessionParametersAddInfoKHR* pParametersAddInfo;
    }
    public unsafe struct VkVideoDecodeH265PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoDecodeH265PictureInfo* pStdPictureInfo;
        public uint sliceSegmentCount;
        public uint* pSliceSegmentOffsets;
    }
    public unsafe struct VkVideoDecodeH265DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoDecodeH265ReferenceInfo* pStdReferenceInfo;
    }
    public unsafe struct VkVideoDecodeAV1ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoAV1Profile stdProfile;
        public int filmGrainSupport;
    }
    public unsafe struct VkVideoDecodeAV1CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoAV1Level maxLevel;
    }
    public unsafe struct VkVideoDecodeAV1SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoAV1SequenceHeader* pStdSequenceHeader;
    }
    public unsafe struct VkVideoDecodeAV1PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoDecodeAV1PictureInfo* pStdPictureInfo;
        public fixed int referenceNameSlotIndices[7];
        public uint frameHeaderOffset;
        public uint tileCount;
        public uint* pTileOffsets;
        public uint* pTileSizes;
    }
    public unsafe struct VkVideoDecodeAV1DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoDecodeAV1ReferenceInfo* pStdReferenceInfo;
    }
    public unsafe struct VkVideoSessionCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint queueFamilyIndex;
        public VkVideoSessionCreateFlagBitsKHR flags;
        public VkVideoProfileInfoKHR* pVideoProfile;
        public VkFormat pictureFormat;
        public VkExtent2D maxCodedExtent;
        public VkFormat referencePictureFormat;
        public uint maxDpbSlots;
        public uint maxActiveReferencePictures;
        public VkExtensionProperties* pStdHeaderVersion;
    }
    public unsafe struct VkVideoSessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoSessionParametersCreateFlagsKHR flags;
        public VkVideoSessionParametersKHR videoSessionParametersTemplate;
        public VkVideoSessionKHR videoSession;
    }
    public unsafe struct VkVideoSessionParametersUpdateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint updateSequenceCount;
    }
    public unsafe struct VkVideoEncodeSessionParametersGetInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoSessionParametersKHR videoSessionParameters;
    }
    public unsafe struct VkVideoEncodeSessionParametersFeedbackInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int hasOverrides;
    }
    public unsafe struct VkVideoBeginCodingInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoBeginCodingFlagsKHR flags;
        public VkVideoSessionKHR videoSession;
        public VkVideoSessionParametersKHR videoSessionParameters;
        public uint referenceSlotCount;
        public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
    }
    public unsafe struct VkVideoEndCodingInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEndCodingFlagsKHR flags;
    }
    public unsafe struct VkVideoCodingControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoCodingControlFlagBitsKHR flags;
    }
    public unsafe struct VkVideoEncodeUsageInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeUsageFlagBitsKHR videoUsageHints;
        public VkVideoEncodeContentFlagBitsKHR videoContentHints;
        public VkVideoEncodeTuningModeKHR tuningMode;
    }
    public unsafe struct VkVideoEncodeInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeFlagBitsKHR flags;
        public VkBuffer dstBuffer;
        public ulong dstBufferOffset;
        public ulong dstBufferRange;
        public VkVideoPictureResourceInfoKHR srcPictureResource;
        public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
        public uint referenceSlotCount;
        public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
        public uint precedingExternallyEncodedBytes;
    }
    public unsafe struct VkQueryPoolVideoEncodeFeedbackCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeFeedbackFlagBitsKHR encodeFeedbackFlags;
    }
    public unsafe struct VkVideoEncodeQualityLevelInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint qualityLevel;
    }
    public unsafe struct VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoProfileInfoKHR* pVideoProfile;
        public uint qualityLevel;
    }
    public unsafe struct VkVideoEncodeQualityLevelPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeRateControlModeFlagBitsKHR preferredRateControlMode;
        public uint preferredRateControlLayerCount;
    }
    public unsafe struct VkVideoEncodeRateControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeRateControlFlagsKHR flags;
        public VkVideoEncodeRateControlModeFlagBitsKHR rateControlMode;
        public uint layerCount;
        public VkVideoEncodeRateControlLayerInfoKHR* pLayers;
        public uint virtualBufferSizeInMs;
        public uint initialVirtualBufferSizeInMs;
    }
    public unsafe struct VkVideoEncodeRateControlLayerInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong averageBitrate;
        public ulong maxBitrate;
        public uint frameRateNumerator;
        public uint frameRateDenominator;
    }
    public unsafe struct VkVideoEncodeCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeCapabilityFlagBitsKHR flags;
        public VkVideoEncodeRateControlModeFlagBitsKHR rateControlModes;
        public uint maxRateControlLayers;
        public ulong maxBitrate;
        public uint maxQualityLevels;
        public VkExtent2D encodeInputPictureGranularity;
        public VkVideoEncodeFeedbackFlagBitsKHR supportedEncodeFeedbackFlags;
    }
    public unsafe struct VkVideoEncodeH264CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH264CapabilityFlagBitsKHR flags;
        public StdVideoH264LevelIdc maxLevelIdc;
        public uint maxSliceCount;
        public uint maxPPictureL0ReferenceCount;
        public uint maxBPictureL0ReferenceCount;
        public uint maxL1ReferenceCount;
        public uint maxTemporalLayerCount;
        public int expectDyadicTemporalLayerPattern;
        public int minQp;
        public int maxQp;
        public int prefersGopRemainingFrames;
        public int requiresGopRemainingFrames;
        public VkVideoEncodeH264StdFlagBitsKHR stdSyntaxFlags;
    }
    public unsafe struct VkVideoEncodeH264QualityLevelPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH264RateControlFlagBitsKHR preferredRateControlFlags;
        public uint preferredGopFrameCount;
        public uint preferredIdrPeriod;
        public uint preferredConsecutiveBFrameCount;
        public uint preferredTemporalLayerCount;
        public VkVideoEncodeH264QpKHR preferredConstantQp;
        public uint preferredMaxL0ReferenceCount;
        public uint preferredMaxL1ReferenceCount;
        public int preferredStdEntropyCodingModeFlag;
    }
    public unsafe struct VkVideoEncodeH264SessionCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int useMaxLevelIdc;
        public StdVideoH264LevelIdc maxLevelIdc;
    }
    public unsafe struct VkVideoEncodeH264SessionParametersAddInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stdSPSCount;
        public StdVideoH264SequenceParameterSet* pStdSPSs;
        public uint stdPPSCount;
        public StdVideoH264PictureParameterSet* pStdPPSs;
    }
    public unsafe struct VkVideoEncodeH264SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoEncodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
    }
    public unsafe struct VkVideoEncodeH264SessionParametersGetInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int writeStdSPS;
        public int writeStdPPS;
        public uint stdSPSId;
        public uint stdPPSId;
    }
    public unsafe struct VkVideoEncodeH264SessionParametersFeedbackInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int hasStdSPSOverrides;
        public int hasStdPPSOverrides;
    }
    public unsafe struct VkVideoEncodeH264DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoEncodeH264ReferenceInfo* pStdReferenceInfo;
    }
    public unsafe struct VkVideoEncodeH264PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint naluSliceEntryCount;
        public VkVideoEncodeH264NaluSliceInfoKHR* pNaluSliceEntries;
        public StdVideoEncodeH264PictureInfo* pStdPictureInfo;
        public int generatePrefixNalu;
    }
    public unsafe struct VkVideoEncodeH264ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoH264ProfileIdc stdProfileIdc;
    }
    public unsafe struct VkVideoEncodeH264NaluSliceInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int constantQp;
        public StdVideoEncodeH264SliceHeader* pStdSliceHeader;
    }
    public unsafe struct VkVideoEncodeH264RateControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH264RateControlFlagBitsKHR flags;
        public uint gopFrameCount;
        public uint idrPeriod;
        public uint consecutiveBFrameCount;
        public uint temporalLayerCount;
    }
    public unsafe struct VkVideoEncodeH264QpKHR
    {
        public int qpI;
        public int qpP;
        public int qpB;
    }
    public unsafe struct VkVideoEncodeH264FrameSizeKHR
    {
        public uint frameISize;
        public uint framePSize;
        public uint frameBSize;
    }
    public unsafe struct VkVideoEncodeH264GopRemainingFrameInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int useGopRemainingFrames;
        public uint gopRemainingI;
        public uint gopRemainingP;
        public uint gopRemainingB;
    }
    public unsafe struct VkVideoEncodeH264RateControlLayerInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int useMinQp;
        public VkVideoEncodeH264QpKHR minQp;
        public int useMaxQp;
        public VkVideoEncodeH264QpKHR maxQp;
        public int useMaxFrameSize;
        public VkVideoEncodeH264FrameSizeKHR maxFrameSize;
    }
    public unsafe struct VkVideoEncodeH265CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH265CapabilityFlagBitsKHR flags;
        public StdVideoH265LevelIdc maxLevelIdc;
        public uint maxSliceSegmentCount;
        public VkExtent2D maxTiles;
        public VkVideoEncodeH265CtbSizeFlagBitsKHR ctbSizes;
        public VkVideoEncodeH265TransformBlockSizeFlagBitsKHR transformBlockSizes;
        public uint maxPPictureL0ReferenceCount;
        public uint maxBPictureL0ReferenceCount;
        public uint maxL1ReferenceCount;
        public uint maxSubLayerCount;
        public int expectDyadicTemporalSubLayerPattern;
        public int minQp;
        public int maxQp;
        public int prefersGopRemainingFrames;
        public int requiresGopRemainingFrames;
        public VkVideoEncodeH265StdFlagBitsKHR stdSyntaxFlags;
    }
    public unsafe struct VkVideoEncodeH265QualityLevelPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH265RateControlFlagBitsKHR preferredRateControlFlags;
        public uint preferredGopFrameCount;
        public uint preferredIdrPeriod;
        public uint preferredConsecutiveBFrameCount;
        public uint preferredSubLayerCount;
        public VkVideoEncodeH265QpKHR preferredConstantQp;
        public uint preferredMaxL0ReferenceCount;
        public uint preferredMaxL1ReferenceCount;
    }
    public unsafe struct VkVideoEncodeH265SessionCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int useMaxLevelIdc;
        public StdVideoH265LevelIdc maxLevelIdc;
    }
    public unsafe struct VkVideoEncodeH265SessionParametersAddInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stdVPSCount;
        public StdVideoH265VideoParameterSet* pStdVPSs;
        public uint stdSPSCount;
        public StdVideoH265SequenceParameterSet* pStdSPSs;
        public uint stdPPSCount;
        public StdVideoH265PictureParameterSet* pStdPPSs;
    }
    public unsafe struct VkVideoEncodeH265SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxStdVPSCount;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoEncodeH265SessionParametersAddInfoKHR* pParametersAddInfo;
    }
    public unsafe struct VkVideoEncodeH265SessionParametersGetInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int writeStdVPS;
        public int writeStdSPS;
        public int writeStdPPS;
        public uint stdVPSId;
        public uint stdSPSId;
        public uint stdPPSId;
    }
    public unsafe struct VkVideoEncodeH265SessionParametersFeedbackInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int hasStdVPSOverrides;
        public int hasStdSPSOverrides;
        public int hasStdPPSOverrides;
    }
    public unsafe struct VkVideoEncodeH265PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint naluSliceSegmentEntryCount;
        public VkVideoEncodeH265NaluSliceSegmentInfoKHR* pNaluSliceSegmentEntries;
        public StdVideoEncodeH265PictureInfo* pStdPictureInfo;
    }
    public unsafe struct VkVideoEncodeH265NaluSliceSegmentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int constantQp;
        public StdVideoEncodeH265SliceSegmentHeader* pStdSliceSegmentHeader;
    }
    public unsafe struct VkVideoEncodeH265RateControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH265RateControlFlagBitsKHR flags;
        public uint gopFrameCount;
        public uint idrPeriod;
        public uint consecutiveBFrameCount;
        public uint subLayerCount;
    }
    public unsafe struct VkVideoEncodeH265QpKHR
    {
        public int qpI;
        public int qpP;
        public int qpB;
    }
    public unsafe struct VkVideoEncodeH265FrameSizeKHR
    {
        public uint frameISize;
        public uint framePSize;
        public uint frameBSize;
    }
    public unsafe struct VkVideoEncodeH265GopRemainingFrameInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int useGopRemainingFrames;
        public uint gopRemainingI;
        public uint gopRemainingP;
        public uint gopRemainingB;
    }
    public unsafe struct VkVideoEncodeH265RateControlLayerInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int useMinQp;
        public VkVideoEncodeH265QpKHR minQp;
        public int useMaxQp;
        public VkVideoEncodeH265QpKHR maxQp;
        public int useMaxFrameSize;
        public VkVideoEncodeH265FrameSizeKHR maxFrameSize;
    }
    public unsafe struct VkVideoEncodeH265ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoH265ProfileIdc stdProfileIdc;
    }
    public unsafe struct VkVideoEncodeH265DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoEncodeH265ReferenceInfo* pStdReferenceInfo;
    }
    public unsafe struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int inheritedViewportScissor2D;
    }
    public unsafe struct VkCommandBufferInheritanceViewportScissorInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int viewportScissor2D;
        public uint viewportDepthCount;
        public VkViewport* pViewportDepths;
    }
    public unsafe struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int ycbcr2plane444Formats;
    }
    public unsafe struct VkPhysicalDeviceProvokingVertexFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int provokingVertexLast;
        public int transformFeedbackPreservesProvokingVertex;
    }
    public unsafe struct VkPhysicalDeviceProvokingVertexPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int provokingVertexModePerPipeline;
        public int transformFeedbackPreservesTriangleFanProvokingVertex;
    }
    public unsafe struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkProvokingVertexModeEXT provokingVertexMode;
    }
    public unsafe struct VkCuModuleCreateInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public nuint dataSize;
        public void* pData;
    }
    public unsafe struct VkCuFunctionCreateInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCuModuleNVX module;
        public byte* pName;
    }
    public unsafe struct VkCuLaunchInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCuFunctionNVX function;
        public uint gridDimX;
        public uint gridDimY;
        public uint gridDimZ;
        public uint blockDimX;
        public uint blockDimY;
        public uint blockDimZ;
        public uint sharedMemBytes;
        public nuint paramCount;
        public void** pParams;
        public nuint extraCount;
        public void** pExtras;
    }
    public unsafe struct VkPhysicalDeviceDescriptorBufferFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int descriptorBuffer;
        public int descriptorBufferCaptureReplay;
        public int descriptorBufferImageLayoutIgnored;
        public int descriptorBufferPushDescriptors;
    }
    public unsafe struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int combinedImageSamplerDescriptorSingleArray;
        public int bufferlessPushDescriptors;
        public int allowSamplerImageViewPostSubmitCreation;
        public ulong descriptorBufferOffsetAlignment;
        public uint maxDescriptorBufferBindings;
        public uint maxResourceDescriptorBufferBindings;
        public uint maxSamplerDescriptorBufferBindings;
        public uint maxEmbeddedImmutableSamplerBindings;
        public uint maxEmbeddedImmutableSamplers;
        public nuint bufferCaptureReplayDescriptorDataSize;
        public nuint imageCaptureReplayDescriptorDataSize;
        public nuint imageViewCaptureReplayDescriptorDataSize;
        public nuint samplerCaptureReplayDescriptorDataSize;
        public nuint accelerationStructureCaptureReplayDescriptorDataSize;
        public nuint samplerDescriptorSize;
        public nuint combinedImageSamplerDescriptorSize;
        public nuint sampledImageDescriptorSize;
        public nuint storageImageDescriptorSize;
        public nuint uniformTexelBufferDescriptorSize;
        public nuint robustUniformTexelBufferDescriptorSize;
        public nuint storageTexelBufferDescriptorSize;
        public nuint robustStorageTexelBufferDescriptorSize;
        public nuint uniformBufferDescriptorSize;
        public nuint robustUniformBufferDescriptorSize;
        public nuint storageBufferDescriptorSize;
        public nuint robustStorageBufferDescriptorSize;
        public nuint inputAttachmentDescriptorSize;
        public nuint accelerationStructureDescriptorSize;
        public ulong maxSamplerDescriptorBufferRange;
        public ulong maxResourceDescriptorBufferRange;
        public ulong samplerDescriptorBufferAddressSpaceSize;
        public ulong resourceDescriptorBufferAddressSpaceSize;
        public ulong descriptorBufferAddressSpaceSize;
    }
    public unsafe struct VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public nuint combinedImageSamplerDensityMapDescriptorSize;
    }
    public unsafe struct VkDescriptorAddressInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong address;
        public ulong range;
        public VkFormat format;
    }
    public unsafe struct VkDescriptorBufferBindingInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong address;
        public VkBufferUsageFlagBits usage;
    }
    public unsafe struct VkDescriptorBufferBindingPushDescriptorBufferHandleEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
    }
    public unsafe struct VkDescriptorDataEXT
    {
        public VkSampler* pSampler;
        public VkDescriptorImageInfo* pCombinedImageSampler;
        public VkDescriptorImageInfo* pInputAttachmentImage;
        public VkDescriptorImageInfo* pSampledImage;
        public VkDescriptorImageInfo* pStorageImage;
        public VkDescriptorAddressInfoEXT* pUniformTexelBuffer;
        public VkDescriptorAddressInfoEXT* pStorageTexelBuffer;
        public VkDescriptorAddressInfoEXT* pUniformBuffer;
        public VkDescriptorAddressInfoEXT* pStorageBuffer;
        public ulong accelerationStructure;
    }
    public unsafe struct VkDescriptorGetInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorType type;
        public VkDescriptorDataEXT data;
    }
    public unsafe struct VkBufferCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
    }
    public unsafe struct VkImageCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
    }
    public unsafe struct VkImageViewCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
    }
    public unsafe struct VkSamplerCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampler sampler;
    }
    public unsafe struct VkAccelerationStructureCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR accelerationStructure;
        public VkAccelerationStructureNV accelerationStructureNV;
    }
    public unsafe struct VkOpaqueCaptureDescriptorDataCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public void* opaqueCaptureDescriptorData;
    }
    public unsafe struct VkPhysicalDeviceShaderIntegerDotProductFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderIntegerDotProduct;
    }
    public unsafe struct VkPhysicalDeviceShaderIntegerDotProductFeaturesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceShaderIntegerDotProductProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public int integerDotProduct8BitUnsignedAccelerated;
        public int integerDotProduct8BitSignedAccelerated;
        public int integerDotProduct8BitMixedSignednessAccelerated;
        public int integerDotProduct4x8BitPackedUnsignedAccelerated;
        public int integerDotProduct4x8BitPackedSignedAccelerated;
        public int integerDotProduct4x8BitPackedMixedSignednessAccelerated;
        public int integerDotProduct16BitUnsignedAccelerated;
        public int integerDotProduct16BitSignedAccelerated;
        public int integerDotProduct16BitMixedSignednessAccelerated;
        public int integerDotProduct32BitUnsignedAccelerated;
        public int integerDotProduct32BitSignedAccelerated;
        public int integerDotProduct32BitMixedSignednessAccelerated;
        public int integerDotProduct64BitUnsignedAccelerated;
        public int integerDotProduct64BitSignedAccelerated;
        public int integerDotProduct64BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating8BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
        public int integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating16BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating32BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
        public int integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
        public int integerDotProductAccumulatingSaturating64BitSignedAccelerated;
        public int integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
    }
    public unsafe struct VkPhysicalDeviceShaderIntegerDotProductPropertiesKHR
    {
    }
    public unsafe struct VkPhysicalDeviceDrmPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int hasPrimary;
        public int hasRender;
        public long primaryMajor;
        public long primaryMinor;
        public long renderMajor;
        public long renderMinor;
    }
    public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int fragmentShaderBarycentric;
    }
    public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int triStripVertexOrderIndependentOfProvokingVertex;
    }
    public unsafe struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int rayTracingMotionBlur;
        public int rayTracingMotionBlurPipelineTraceRaysIndirect;
    }
    public unsafe struct VkPhysicalDeviceRayTracingValidationFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int rayTracingValidation;
    }
    public unsafe struct VkAccelerationStructureGeometryMotionTrianglesDataNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR vertexData;
    }
    public unsafe struct VkAccelerationStructureMotionInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxInstances;
        public VkAccelerationStructureMotionInfoFlagsNV flags;
    }
    public unsafe struct VkSRTDataNV
    {
        public float sx;
        public float a;
        public float b;
        public float pvx;
        public float sy;
        public float c;
        public float pvy;
        public float sz;
        public float pvz;
        public float qx;
        public float qy;
        public float qz;
        public float qw;
        public float tx;
        public float ty;
        public float tz;
    }
    public unsafe struct VkAccelerationStructureSRTMotionInstanceNV
    {
        public VkSRTDataNV transformT0;
        public VkSRTDataNV transformT1;
        public uint instanceCustomIndex;
        public uint mask;
        public uint instanceShaderBindingTableRecordOffset;
        public VkGeometryInstanceFlagBitsKHR flags;
        public ulong accelerationStructureReference;
    }
    public unsafe struct VkAccelerationStructureMatrixMotionInstanceNV
    {
        public VkTransformMatrixKHR transformT0;
        public VkTransformMatrixKHR transformT1;
        public uint instanceCustomIndex;
        public uint mask;
        public uint instanceShaderBindingTableRecordOffset;
        public VkGeometryInstanceFlagBitsKHR flags;
        public ulong accelerationStructureReference;
    }
    public unsafe struct VkAccelerationStructureMotionInstanceDataNV
    {
        public VkAccelerationStructureInstanceKHR staticInstance;
        public VkAccelerationStructureMatrixMotionInstanceNV matrixMotionInstance;
        public VkAccelerationStructureSRTMotionInstanceNV srtMotionInstance;
    }
    public unsafe struct VkAccelerationStructureMotionInstanceNV
    {
        public VkAccelerationStructureMotionInstanceTypeNV type;
        public VkAccelerationStructureMotionInstanceFlagsNV flags;
        public VkAccelerationStructureMotionInstanceDataNV data;
    }
    public unsafe struct VkMemoryGetRemoteAddressInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlagBits handleType;
    }
    public unsafe struct VkImportMemoryBufferCollectionFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCollectionFUCHSIA collection;
        public uint index;
    }
    public unsafe struct VkBufferCollectionImageCreateInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCollectionFUCHSIA collection;
        public uint index;
    }
    public unsafe struct VkBufferCollectionBufferCreateInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCollectionFUCHSIA collection;
        public uint index;
    }
    public unsafe struct VkBufferCollectionCreateInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public int collectionToken;
    }
    public unsafe struct VkBufferCollectionPropertiesFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
        public uint bufferCount;
        public uint createInfoIndex;
        public ulong sysmemPixelFormat;
        public VkFormatFeatureFlagBits formatFeatures;
        public VkSysmemColorSpaceFUCHSIA sysmemColorSpaceIndex;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
    }
    public unsafe struct VkBufferConstraintsInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCreateInfo createInfo;
        public VkFormatFeatureFlagBits requiredFormatFeatures;
        public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;
    }
    public unsafe struct VkSysmemColorSpaceFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint colorSpace;
    }
    public unsafe struct VkImageFormatConstraintsInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateInfo imageCreateInfo;
        public VkFormatFeatureFlagBits requiredFormatFeatures;
        public VkImageFormatConstraintsFlagsFUCHSIA flags;
        public ulong sysmemPixelFormat;
        public uint colorSpaceCount;
        public VkSysmemColorSpaceFUCHSIA* pColorSpaces;
    }
    public unsafe struct VkImageConstraintsInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint formatConstraintsCount;
        public VkImageFormatConstraintsInfoFUCHSIA* pFormatConstraints;
        public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;
        public VkImageConstraintsInfoFlagBitsFUCHSIA flags;
    }
    public unsafe struct VkBufferCollectionConstraintsInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minBufferCount;
        public uint maxBufferCount;
        public uint minBufferCountForCamping;
        public uint minBufferCountForDedicatedSlack;
        public uint minBufferCountForSharedSlack;
    }
    public unsafe struct VkCudaModuleCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public nuint dataSize;
        public void* pData;
    }
    public unsafe struct VkCudaFunctionCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCudaModuleNV module;
        public byte* pName;
    }
    public unsafe struct VkCudaLaunchInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCudaFunctionNV function;
        public uint gridDimX;
        public uint gridDimY;
        public uint gridDimZ;
        public uint blockDimX;
        public uint blockDimY;
        public uint blockDimZ;
        public uint sharedMemBytes;
        public nuint paramCount;
        public void** pParams;
        public nuint extraCount;
        public void** pExtras;
    }
    public unsafe struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int formatRgba10x6WithoutYCbCrSampler;
    }
    public unsafe struct VkFormatProperties3
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormatFeatureFlags2 linearTilingFeatures;
        public VkFormatFeatureFlags2 optimalTilingFeatures;
        public VkFormatFeatureFlags2 bufferFeatures;
    }
    public unsafe struct VkFormatProperties3KHR
    {
    }
    public unsafe struct VkDrmFormatModifierPropertiesList2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public VkDrmFormatModifierProperties2EXT* pDrmFormatModifierProperties;
    }
    public unsafe struct VkDrmFormatModifierProperties2EXT
    {
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkFormatFeatureFlags2 drmFormatModifierTilingFeatures;
    }
    public unsafe struct VkAndroidHardwareBufferFormatProperties2ANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public ulong externalFormat;
        public VkFormatFeatureFlags2 formatFeatures;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
    }
    public unsafe struct VkPipelineRenderingCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkFormat* pColorAttachmentFormats;
        public VkFormat depthAttachmentFormat;
        public VkFormat stencilAttachmentFormat;
    }
    public unsafe struct VkPipelineRenderingCreateInfoKHR
    {
    }
    public unsafe struct VkRenderingInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderingFlagBits flags;
        public VkRect2D renderArea;
        public uint layerCount;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkRenderingAttachmentInfo* pColorAttachments;
        public VkRenderingAttachmentInfo* pDepthAttachment;
        public VkRenderingAttachmentInfo* pStencilAttachment;
    }
    public unsafe struct VkRenderingInfoKHR
    {
    }
    public unsafe struct VkRenderingAttachmentInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
        public VkResolveModeFlagBits resolveMode;
        public VkImageView resolveImageView;
        public VkImageLayout resolveImageLayout;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkClearValue clearValue;
    }
    public unsafe struct VkRenderingAttachmentInfoKHR
    {
    }
    public unsafe struct VkRenderingFragmentShadingRateAttachmentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
        public VkExtent2D shadingRateAttachmentTexelSize;
    }
    public unsafe struct VkRenderingFragmentDensityMapAttachmentInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
    }
    public unsafe struct VkPhysicalDeviceDynamicRenderingFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public int dynamicRendering;
    }
    public unsafe struct VkPhysicalDeviceDynamicRenderingFeaturesKHR
    {
    }
    public unsafe struct VkCommandBufferInheritanceRenderingInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderingFlagBits flags;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkFormat* pColorAttachmentFormats;
        public VkFormat depthAttachmentFormat;
        public VkFormat stencilAttachmentFormat;
        public VkSampleCountFlagBits rasterizationSamples;
    }
    public unsafe struct VkCommandBufferInheritanceRenderingInfoKHR
    {
    }
    public unsafe struct VkAttachmentSampleCountInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public uint colorAttachmentCount;
        public VkSampleCountFlagBits* pColorAttachmentSamples;
        public VkSampleCountFlagBits depthStencilAttachmentSamples;
    }
    public unsafe struct VkAttachmentSampleCountInfoNV
    {
    }
    public unsafe struct VkMultiviewPerViewAttributesInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public int perViewAttributes;
        public int perViewAttributesPositionXOnly;
    }
    public unsafe struct VkPhysicalDeviceImageViewMinLodFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int minLod;
    }
    public unsafe struct VkImageViewMinLodCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public float minLod;
    }
    public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int rasterizationOrderColorAttachmentAccess;
        public int rasterizationOrderDepthAttachmentAccess;
        public int rasterizationOrderStencilAttachmentAccess;
    }
    public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM
    {
    }
    public unsafe struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int linearColorAttachment;
    }
    public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int graphicsPipelineLibrary;
    }
    public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int graphicsPipelineLibraryFastLinking;
        public int graphicsPipelineLibraryIndependentInterpolationDecoration;
    }
    public unsafe struct VkGraphicsPipelineLibraryCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkGraphicsPipelineLibraryFlagBitsEXT flags;
    }
    public unsafe struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public int descriptorSetHostMapping;
    }
    public unsafe struct VkDescriptorSetBindingReferenceVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSetLayout descriptorSetLayout;
        public uint binding;
    }
    public unsafe struct VkDescriptorSetLayoutHostMappingInfoVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public nuint descriptorOffset;
        public uint descriptorSize;
    }
    public unsafe struct VkPhysicalDeviceNestedCommandBufferFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int nestedCommandBuffer;
        public int nestedCommandBufferRendering;
        public int nestedCommandBufferSimultaneousUse;
    }
    public unsafe struct VkPhysicalDeviceNestedCommandBufferPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxCommandBufferNestingLevel;
    }
    public unsafe struct VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderModuleIdentifier;
    }
    public unsafe struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte shaderModuleIdentifierAlgorithmUUID[16];
    }
    public unsafe struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint identifierSize;
        public byte* pIdentifier;
    }
    public unsafe struct VkShaderModuleIdentifierEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint identifierSize;
        public fixed byte identifier[32];
    }
    public unsafe struct VkImageCompressionControlEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCompressionFlagBitsEXT flags;
        public uint compressionControlPlaneCount;
        public VkImageCompressionFixedRateFlagBitsEXT* pFixedRateFlags;
    }
    public unsafe struct VkPhysicalDeviceImageCompressionControlFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int imageCompressionControl;
    }
    public unsafe struct VkImageCompressionPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCompressionFlagBitsEXT imageCompressionFlags;
        public VkImageCompressionFixedRateFlagBitsEXT imageCompressionFixedRateFlags;
    }
    public unsafe struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int imageCompressionControlSwapchain;
    }
    public unsafe struct VkImageSubresource2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresource imageSubresource;
    }
    public unsafe struct VkImageSubresource2EXT
    {
    }
    public unsafe struct VkSubresourceLayout2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubresourceLayout subresourceLayout;
    }
    public unsafe struct VkSubresourceLayout2EXT
    {
    }
    public unsafe struct VkRenderPassCreationControlEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int disallowMerging;
    }
    public unsafe struct VkRenderPassCreationFeedbackInfoEXT
    {
        public uint postMergeSubpassCount;
    }
    public unsafe struct VkRenderPassCreationFeedbackCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassCreationFeedbackInfoEXT* pRenderPassFeedback;
    }
    public unsafe struct VkRenderPassSubpassFeedbackInfoEXT
    {
        public VkSubpassMergeStatusEXT subpassMergeStatus;
        [InlineArray(256)]
        public struct descriptionInlineArray
        {
            public byte element;
        }
        public descriptionInlineArray description;
        public uint postMergeIndex;
    }
    public unsafe struct VkRenderPassSubpassFeedbackCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassSubpassFeedbackInfoEXT* pSubpassFeedback;
    }
    public unsafe struct VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int subpassMergeFeedback;
    }
    public unsafe struct VkMicromapBuildInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMicromapTypeEXT type;
        public VkBuildMicromapFlagBitsEXT flags;
        public VkBuildMicromapModeEXT mode;
        public VkMicromapEXT dstMicromap;
        public uint usageCountsCount;
        public VkMicromapUsageEXT* pUsageCounts;
        public VkMicromapUsageEXT** ppUsageCounts;
        public VkDeviceOrHostAddressConstKHR data;
        public VkDeviceOrHostAddressKHR scratchData;
        public VkDeviceOrHostAddressConstKHR triangleArray;
        public ulong triangleArrayStride;
    }
    public unsafe struct VkMicromapCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMicromapCreateFlagBitsEXT createFlags;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        public VkMicromapTypeEXT type;
        public ulong deviceAddress;
    }
    public unsafe struct VkMicromapVersionInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pVersionData;
    }
    public unsafe struct VkCopyMicromapInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMicromapEXT src;
        public VkMicromapEXT dst;
        public VkCopyMicromapModeEXT mode;
    }
    public unsafe struct VkCopyMicromapToMemoryInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMicromapEXT src;
        public VkDeviceOrHostAddressKHR dst;
        public VkCopyMicromapModeEXT mode;
    }
    public unsafe struct VkCopyMemoryToMicromapInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR src;
        public VkMicromapEXT dst;
        public VkCopyMicromapModeEXT mode;
    }
    public unsafe struct VkMicromapBuildSizesInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong micromapSize;
        public ulong buildScratchSize;
        public int discardable;
    }
    public unsafe struct VkMicromapUsageEXT
    {
        public uint count;
        public uint subdivisionLevel;
        public uint format;
    }
    public unsafe struct VkMicromapTriangleEXT
    {
        public uint dataOffset;
        public ushort subdivisionLevel;
        public ushort format;
    }
    public unsafe struct VkPhysicalDeviceOpacityMicromapFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int micromap;
        public int micromapCaptureReplay;
        public int micromapHostCommands;
    }
    public unsafe struct VkPhysicalDeviceOpacityMicromapPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxOpacity2StateSubdivisionLevel;
        public uint maxOpacity4StateSubdivisionLevel;
    }
    public unsafe struct VkAccelerationStructureTrianglesOpacityMicromapEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexBuffer;
        public ulong indexStride;
        public uint baseTriangle;
        public uint usageCountsCount;
        public VkMicromapUsageEXT* pUsageCounts;
        public VkMicromapUsageEXT** ppUsageCounts;
        public VkMicromapEXT micromap;
    }
    public unsafe struct VkPhysicalDeviceDisplacementMicromapFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int displacementMicromap;
    }
    public unsafe struct VkPhysicalDeviceDisplacementMicromapPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxDisplacementMicromapSubdivisionLevel;
    }
    public unsafe struct VkAccelerationStructureTrianglesDisplacementMicromapNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat displacementBiasAndScaleFormat;
        public VkFormat displacementVectorFormat;
        public VkDeviceOrHostAddressConstKHR displacementBiasAndScaleBuffer;
        public ulong displacementBiasAndScaleStride;
        public VkDeviceOrHostAddressConstKHR displacementVectorBuffer;
        public ulong displacementVectorStride;
        public VkDeviceOrHostAddressConstKHR displacedMicromapPrimitiveFlags;
        public ulong displacedMicromapPrimitiveFlagsStride;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexBuffer;
        public ulong indexStride;
        public uint baseTriangle;
        public uint usageCountsCount;
        public VkMicromapUsageEXT* pUsageCounts;
        public VkMicromapUsageEXT** ppUsageCounts;
        public VkMicromapEXT micromap;
    }
    public unsafe struct VkPipelinePropertiesIdentifierEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte pipelineIdentifier[16];
    }
    public unsafe struct VkPhysicalDevicePipelinePropertiesFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int pipelinePropertiesIdentifier;
    }
    public unsafe struct VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderEarlyAndLateFragmentTests;
    }
    public unsafe struct VkExternalMemoryAcquireUnmodifiedEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int acquireUnmodifiedMemory;
    }
    public unsafe struct VkExportMetalObjectCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExportMetalObjectTypeFlagBitsEXT exportObjectType;
    }
    public unsafe struct VkExportMetalObjectsInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
    }
    public unsafe struct VkExportMetalDeviceInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr mtlDevice;
    }
    public unsafe struct VkExportMetalCommandQueueInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueue queue;
        public IntPtr mtlCommandQueue;
    }
    public unsafe struct VkExportMetalBufferInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public IntPtr mtlBuffer;
    }
    public unsafe struct VkImportMetalBufferInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr mtlBuffer;
    }
    public unsafe struct VkExportMetalTextureInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkImageView imageView;
        public VkBufferView bufferView;
        public VkImageAspectFlagBits plane;
        public IntPtr mtlTexture;
    }
    public unsafe struct VkImportMetalTextureInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageAspectFlagBits plane;
        public IntPtr mtlTexture;
    }
    public unsafe struct VkExportMetalIOSurfaceInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public IntPtr ioSurface;
    }
    public unsafe struct VkImportMetalIOSurfaceInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr ioSurface;
    }
    public unsafe struct VkExportMetalSharedEventInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkEvent @event;
        public IntPtr mtlSharedEvent;
    }
    public unsafe struct VkImportMetalSharedEventInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr mtlSharedEvent;
    }
    public unsafe struct VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int nonSeamlessCubeMap;
    }
    public unsafe struct VkPhysicalDevicePipelineRobustnessFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int pipelineRobustness;
    }
    public unsafe struct VkPipelineRobustnessCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRobustnessBufferBehaviorEXT storageBuffers;
        public VkPipelineRobustnessBufferBehaviorEXT uniformBuffers;
        public VkPipelineRobustnessBufferBehaviorEXT vertexInputs;
        public VkPipelineRobustnessImageBehaviorEXT images;
    }
    public unsafe struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessStorageBuffers;
        public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessUniformBuffers;
        public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessVertexInputs;
        public VkPipelineRobustnessImageBehaviorEXT defaultRobustnessImages;
    }
    public unsafe struct VkImageViewSampleWeightCreateInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOffset2D filterCenter;
        public VkExtent2D filterSize;
        public uint numPhases;
    }
    public unsafe struct VkPhysicalDeviceImageProcessingFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public int textureSampleWeighted;
        public int textureBoxFilter;
        public int textureBlockMatch;
    }
    public unsafe struct VkPhysicalDeviceImageProcessingPropertiesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxWeightFilterPhases;
        public VkExtent2D maxWeightFilterDimension;
        public VkExtent2D maxBlockMatchRegion;
        public VkExtent2D maxBoxFilterBlockSize;
    }
    public unsafe struct VkPhysicalDeviceTilePropertiesFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public int tileProperties;
    }
    public unsafe struct VkTilePropertiesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent3D tileSize;
        public VkExtent2D apronSize;
        public VkOffset2D origin;
    }
    public unsafe struct VkPhysicalDeviceAmigoProfilingFeaturesSEC
    {
        public VkStructureType sType;
        public void* pNext;
        public int amigoProfiling;
    }
    public unsafe struct VkAmigoProfilingSubmitInfoSEC
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong firstDrawTimestamp;
        public ulong swapBufferTimestamp;
    }
    public unsafe struct VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int attachmentFeedbackLoopLayout;
    }
    public unsafe struct VkPhysicalDeviceDepthClampZeroOneFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int depthClampZeroOne;
    }
    public unsafe struct VkPhysicalDeviceAddressBindingReportFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int reportAddressBinding;
    }
    public unsafe struct VkDeviceAddressBindingCallbackDataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceAddressBindingFlagBitsEXT flags;
        public ulong baseAddress;
        public ulong size;
        public VkDeviceAddressBindingTypeEXT bindingType;
    }
    public unsafe struct VkPhysicalDeviceOpticalFlowFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int opticalFlow;
    }
    public unsafe struct VkPhysicalDeviceOpticalFlowPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOpticalFlowGridSizeFlagBitsNV supportedOutputGridSizes;
        public VkOpticalFlowGridSizeFlagBitsNV supportedHintGridSizes;
        public int hintSupported;
        public int costSupported;
        public int bidirectionalFlowSupported;
        public int globalFlowSupported;
        public uint minWidth;
        public uint minHeight;
        public uint maxWidth;
        public uint maxHeight;
        public uint maxNumRegionsOfInterest;
    }
    public unsafe struct VkOpticalFlowImageFormatInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOpticalFlowUsageFlagBitsNV usage;
    }
    public unsafe struct VkOpticalFlowImageFormatPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
    }
    public unsafe struct VkOpticalFlowSessionCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint width;
        public uint height;
        public VkFormat imageFormat;
        public VkFormat flowVectorFormat;
        public VkFormat costFormat;
        public VkOpticalFlowGridSizeFlagBitsNV outputGridSize;
        public VkOpticalFlowGridSizeFlagBitsNV hintGridSize;
        public VkOpticalFlowPerformanceLevelNV performanceLevel;
        public VkOpticalFlowSessionCreateFlagBitsNV flags;
    }
    public unsafe struct VkOpticalFlowSessionCreatePrivateDataInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint id;
        public uint size;
        public void* pPrivateData;
    }
    public unsafe struct VkOpticalFlowExecuteInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOpticalFlowExecuteFlagBitsNV flags;
        public uint regionCount;
        public VkRect2D* pRegions;
    }
    public unsafe struct VkPhysicalDeviceFaultFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int deviceFault;
        public int deviceFaultVendorBinary;
    }
    public unsafe struct VkDeviceFaultAddressInfoEXT
    {
        public VkDeviceFaultAddressTypeEXT addressType;
        public ulong reportedAddress;
        public ulong addressPrecision;
    }
    public unsafe struct VkDeviceFaultVendorInfoEXT
    {
        [InlineArray(256)]
        public struct descriptionInlineArray
        {
            public byte element;
        }
        public descriptionInlineArray description;
        public ulong vendorFaultCode;
        public ulong vendorFaultData;
    }
    public unsafe struct VkDeviceFaultCountsEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint addressInfoCount;
        public uint vendorInfoCount;
        public ulong vendorBinarySize;
    }
    public unsafe struct VkDeviceFaultInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        [InlineArray(256)]
        public struct descriptionInlineArray
        {
            public byte element;
        }
        public descriptionInlineArray description;
        public VkDeviceFaultAddressInfoEXT* pAddressInfos;
        public VkDeviceFaultVendorInfoEXT* pVendorInfos;
        public void* pVendorBinaryData;
    }
    public unsafe struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
    {
        public uint headerSize;
        public VkDeviceFaultVendorBinaryHeaderVersionEXT headerVersion;
        public uint vendorID;
        public uint deviceID;
        public uint driverVersion;
        public fixed byte pipelineCacheUUID[16];
        public uint applicationNameOffset;
        public uint applicationVersion;
        public uint engineNameOffset;
        public uint engineVersion;
        public uint apiVersion;
    }
    public unsafe struct VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int pipelineLibraryGroupHandles;
    }
    public unsafe struct VkDepthBiasInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public float depthBiasConstantFactor;
        public float depthBiasClamp;
        public float depthBiasSlopeFactor;
    }
    public unsafe struct VkDepthBiasRepresentationInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDepthBiasRepresentationEXT depthBiasRepresentation;
        public int depthBiasExact;
    }
    public unsafe struct VkDecompressMemoryRegionNV
    {
        public ulong srcAddress;
        public ulong dstAddress;
        public ulong compressedSize;
        public ulong decompressedSize;
        public VkMemoryDecompressionMethodFlagsNV decompressionMethod;
    }
    public unsafe struct VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong shaderCoreMask;
        public uint shaderCoreCount;
        public uint shaderWarpsPerCore;
    }
    public unsafe struct VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderCoreBuiltins;
    }
    public unsafe struct VkFrameBoundaryEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFrameBoundaryFlagBitsEXT flags;
        public ulong frameID;
        public uint imageCount;
        public VkImage* pImages;
        public uint bufferCount;
        public VkBuffer* pBuffers;
        public ulong tagName;
        public nuint tagSize;
        public void* pTag;
    }
    public unsafe struct VkPhysicalDeviceFrameBoundaryFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int frameBoundary;
    }
    public unsafe struct VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int dynamicRenderingUnusedAttachments;
    }
    public unsafe struct VkSurfacePresentModeEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPresentModeKHR presentMode;
    }
    public unsafe struct VkSurfacePresentScalingCapabilitiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPresentScalingFlagBitsEXT supportedPresentScaling;
        public VkPresentGravityFlagBitsEXT supportedPresentGravityX;
        public VkPresentGravityFlagBitsEXT supportedPresentGravityY;
        public VkExtent2D minScaledImageExtent;
        public VkExtent2D maxScaledImageExtent;
    }
    public unsafe struct VkSurfacePresentModeCompatibilityEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint presentModeCount;
        public VkPresentModeKHR* pPresentModes;
    }
    public unsafe struct VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int swapchainMaintenance1;
    }
    public unsafe struct VkSwapchainPresentFenceInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkFence* pFences;
    }
    public unsafe struct VkSwapchainPresentModesCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint presentModeCount;
        public VkPresentModeKHR* pPresentModes;
    }
    public unsafe struct VkSwapchainPresentModeInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentModeKHR* pPresentModes;
    }
    public unsafe struct VkSwapchainPresentScalingCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPresentScalingFlagBitsEXT scalingBehavior;
        public VkPresentGravityFlagBitsEXT presentGravityX;
        public VkPresentGravityFlagBitsEXT presentGravityY;
    }
    public unsafe struct VkReleaseSwapchainImagesInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public uint imageIndexCount;
        public uint* pImageIndices;
    }
    public unsafe struct VkPhysicalDeviceDepthBiasControlFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int depthBiasControl;
        public int leastRepresentableValueForceUnormRepresentation;
        public int floatRepresentation;
        public int depthBiasExact;
    }
    public unsafe struct VkPhysicalDeviceRayTracingInvocationReorderFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int rayTracingInvocationReorder;
    }
    public unsafe struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRayTracingInvocationReorderModeNV rayTracingInvocationReorderReorderingHint;
    }
    public unsafe struct VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int extendedSparseAddressSpace;
    }
    public unsafe struct VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong extendedSparseAddressSpaceSize;
        public VkImageUsageFlagBits extendedSparseImageUsageFlags;
        public VkBufferUsageFlagBits extendedSparseBufferUsageFlags;
    }
    public unsafe struct VkDirectDriverLoadingInfoLUNARG
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDirectDriverLoadingFlagsLUNARG flags;
        public IntPtr pfnGetInstanceProcAddr;
    }
    public unsafe struct VkDirectDriverLoadingListLUNARG
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDirectDriverLoadingModeLUNARG mode;
        public uint driverCount;
        public VkDirectDriverLoadingInfoLUNARG* pDrivers;
    }
    public unsafe struct VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public int multiviewPerViewViewports;
    }
    public unsafe struct VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int rayTracingPositionFetch;
    }
    public unsafe struct VkDeviceImageSubresourceInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateInfo* pCreateInfo;
        public VkImageSubresource2KHR* pSubresource;
    }
    public unsafe struct VkPhysicalDeviceShaderCorePropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint pixelRate;
        public uint texelRate;
        public uint fmaRate;
    }
    public unsafe struct VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public int multiviewPerViewRenderAreas;
    }
    public unsafe struct VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint perViewRenderAreaCount;
        public VkRect2D* pPerViewRenderAreas;
    }
    public unsafe struct VkQueryLowLatencySupportNV
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pQueriedLowLatencyData;
    }
    public unsafe struct VkMemoryMapInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryMapFlagBits flags;
        public VkDeviceMemory memory;
        public ulong offset;
        public ulong size;
    }
    public unsafe struct VkMemoryUnmapInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryUnmapFlagBitsKHR flags;
        public VkDeviceMemory memory;
    }
    public unsafe struct VkPhysicalDeviceShaderObjectFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderObject;
    }
    public unsafe struct VkPhysicalDeviceShaderObjectPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte shaderBinaryUUID[16];
        public uint shaderBinaryVersion;
    }
    public unsafe struct VkShaderCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderCreateFlagBitsEXT flags;
        public VkShaderStageFlagBits stage;
        public VkShaderStageFlagBits nextStage;
        public VkShaderCodeTypeEXT codeType;
        public nuint codeSize;
        public void* pCode;
        public byte* pName;
        public uint setLayoutCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public uint pushConstantRangeCount;
        public VkPushConstantRange* pPushConstantRanges;
        public VkSpecializationInfo* pSpecializationInfo;
    }
    public unsafe struct VkPhysicalDeviceShaderTileImageFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderTileImageColorReadAccess;
        public int shaderTileImageDepthReadAccess;
        public int shaderTileImageStencilReadAccess;
    }
    public unsafe struct VkPhysicalDeviceShaderTileImagePropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderTileImageCoherentReadAccelerated;
        public int shaderTileImageReadSampleFromPixelRateInvocation;
        public int shaderTileImageReadFromHelperInvocation;
    }
    public unsafe struct VkImportScreenBufferInfoQNX
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* buffer;
    }
    public unsafe struct VkScreenBufferPropertiesQNX
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong allocationSize;
        public uint memoryTypeBits;
    }
    public unsafe struct VkScreenBufferFormatPropertiesQNX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public ulong externalFormat;
        public ulong screenUsage;
        public VkFormatFeatureFlagBits formatFeatures;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
    }
    public unsafe struct VkExternalFormatQNX
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong externalFormat;
    }
    public unsafe struct VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX
    {
        public VkStructureType sType;
        public void* pNext;
        public int screenBufferImport;
    }
    public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int cooperativeMatrix;
        public int cooperativeMatrixRobustBufferAccess;
    }
    public unsafe struct VkCooperativeMatrixPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint MSize;
        public uint NSize;
        public uint KSize;
        public VkComponentTypeKHR AType;
        public VkComponentTypeKHR BType;
        public VkComponentTypeKHR CType;
        public VkComponentTypeKHR ResultType;
        public int saturatingAccumulation;
        public VkScopeKHR scope;
    }
    public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlagBits cooperativeMatrixSupportedStages;
    }
    public unsafe struct VkPhysicalDeviceShaderEnqueuePropertiesAMDX
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxExecutionGraphDepth;
        public uint maxExecutionGraphShaderOutputNodes;
        public uint maxExecutionGraphShaderPayloadSize;
        public uint maxExecutionGraphShaderPayloadCount;
        public uint executionGraphDispatchAddressAlignment;
    }
    public unsafe struct VkPhysicalDeviceShaderEnqueueFeaturesAMDX
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderEnqueue;
    }
    public unsafe struct VkExecutionGraphPipelineCreateInfoAMDX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlagBits flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
    }
    public unsafe struct VkPipelineShaderStageNodeCreateInfoAMDX
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pName;
        public uint index;
    }
    public unsafe struct VkExecutionGraphPipelineScratchSizeAMDX
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong size;
    }
    public unsafe struct VkDispatchGraphInfoAMDX
    {
        public uint nodeIndex;
        public uint payloadCount;
        public VkDeviceOrHostAddressConstAMDX payloads;
        public ulong payloadStride;
    }
    public unsafe struct VkDispatchGraphCountInfoAMDX
    {
        public uint count;
        public VkDeviceOrHostAddressConstAMDX infos;
        public ulong stride;
    }
    public unsafe struct VkBindMemoryStatusKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkResult* pResult;
    }
    public unsafe struct VkBindDescriptorSetsInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlagBits stageFlags;
        public VkPipelineLayout layout;
        public uint firstSet;
        public uint descriptorSetCount;
        public VkDescriptorSet* pDescriptorSets;
        public uint dynamicOffsetCount;
        public uint* pDynamicOffsets;
    }
    public unsafe struct VkPushConstantsInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineLayout layout;
        public VkShaderStageFlagBits stageFlags;
        public uint offset;
        public uint size;
        public void* pValues;
    }
    public unsafe struct VkPushDescriptorSetInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlagBits stageFlags;
        public VkPipelineLayout layout;
        public uint set;
        public uint descriptorWriteCount;
        public VkWriteDescriptorSet* pDescriptorWrites;
    }
    public unsafe struct VkPushDescriptorSetWithTemplateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorUpdateTemplate descriptorUpdateTemplate;
        public VkPipelineLayout layout;
        public uint set;
        public void* pData;
    }
    public unsafe struct VkSetDescriptorBufferOffsetsInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlagBits stageFlags;
        public VkPipelineLayout layout;
        public uint firstSet;
        public uint setCount;
        public uint* pBufferIndices;
        public ulong* pOffsets;
    }
    public unsafe struct VkBindDescriptorBufferEmbeddedSamplersInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlagBits stageFlags;
        public VkPipelineLayout layout;
        public uint set;
    }
    public unsafe struct VkPhysicalDeviceCubicClampFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public int cubicRangeClamp;
    }
    public unsafe struct VkPhysicalDeviceYcbcrDegammaFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public int ycbcrDegamma;
    }
    public unsafe struct VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public int enableYDegamma;
        public int enableCbCrDegamma;
    }
    public unsafe struct VkPhysicalDeviceCubicWeightsFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public int selectableCubicWeights;
    }
    public unsafe struct VkSamplerCubicWeightsCreateInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCubicFilterWeightsQCOM cubicWeights;
    }
    public unsafe struct VkBlitImageCubicWeightsInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCubicFilterWeightsQCOM cubicWeights;
    }
    public unsafe struct VkPhysicalDeviceImageProcessing2FeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public int textureBlockMatch2;
    }
    public unsafe struct VkPhysicalDeviceImageProcessing2PropertiesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D maxBlockMatchWindow;
    }
    public unsafe struct VkSamplerBlockMatchWindowCreateInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D windowExtent;
        public VkBlockMatchWindowCompareModeQCOM windowCompareMode;
    }
    public unsafe struct VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int descriptorPoolOverallocation;
    }
    public unsafe struct VkPhysicalDeviceLayeredDriverPropertiesMSFT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkLayeredDriverUnderlyingApiMSFT underlyingAPI;
    }
    public unsafe struct VkPhysicalDevicePerStageDescriptorSetFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int perStageDescriptorSet;
        public int dynamicPipelineLayout;
    }
    public unsafe struct VkPhysicalDeviceExternalFormatResolveFeaturesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public int externalFormatResolve;
    }
    public unsafe struct VkPhysicalDeviceExternalFormatResolvePropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public int nullColorAttachmentWithExternalFormatResolve;
        public VkChromaLocation externalFormatResolveChromaOffsetX;
        public VkChromaLocation externalFormatResolveChromaOffsetY;
    }
    public unsafe struct VkAndroidHardwareBufferFormatResolvePropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat colorAttachmentFormat;
    }
    public unsafe struct VkLatencySleepModeInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int lowLatencyMode;
        public int lowLatencyBoost;
        public uint minimumIntervalUs;
    }
    public unsafe struct VkLatencySleepInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore signalSemaphore;
        public ulong value;
    }
    public unsafe struct VkSetLatencyMarkerInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong presentID;
        public VkLatencyMarkerNV marker;
    }
    public unsafe struct VkGetLatencyMarkerInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint timingCount;
        public VkLatencyTimingsFrameReportNV* pTimings;
    }
    public unsafe struct VkLatencyTimingsFrameReportNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong presentID;
        public ulong inputSampleTimeUs;
        public ulong simStartTimeUs;
        public ulong simEndTimeUs;
        public ulong renderSubmitStartTimeUs;
        public ulong renderSubmitEndTimeUs;
        public ulong presentStartTimeUs;
        public ulong presentEndTimeUs;
        public ulong driverStartTimeUs;
        public ulong driverEndTimeUs;
        public ulong osRenderQueueStartTimeUs;
        public ulong osRenderQueueEndTimeUs;
        public ulong gpuRenderStartTimeUs;
        public ulong gpuRenderEndTimeUs;
    }
    public unsafe struct VkOutOfBandQueueTypeInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOutOfBandQueueTypeNV queueType;
    }
    public unsafe struct VkLatencySubmissionPresentIdNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong presentID;
    }
    public unsafe struct VkSwapchainLatencyCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int latencyModeEnable;
    }
    public unsafe struct VkLatencySurfaceCapabilitiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint presentModeCount;
        public VkPresentModeKHR* pPresentModes;
    }
    public unsafe struct VkPhysicalDeviceCudaKernelLaunchFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int cudaKernelLaunchFeatures;
    }
    public unsafe struct VkPhysicalDeviceCudaKernelLaunchPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint computeCapabilityMinor;
        public uint computeCapabilityMajor;
    }
    public unsafe struct VkDeviceQueueShaderCoreControlCreateInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderCoreCount;
    }
    public unsafe struct VkPhysicalDeviceSchedulingControlsFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public int schedulingControls;
    }
    public unsafe struct VkPhysicalDeviceSchedulingControlsPropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceSchedulingControlsFlagsARM schedulingControlsFlags;
    }
    public unsafe struct VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG
    {
        public VkStructureType sType;
        public void* pNext;
        public int relaxedLineRasterization;
    }
    public unsafe struct VkPhysicalDeviceRenderPassStripedFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public int renderPassStriped;
    }
    public unsafe struct VkPhysicalDeviceRenderPassStripedPropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D renderPassStripeGranularity;
        public uint maxRenderPassStripes;
    }
    public unsafe struct VkRenderPassStripeInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRect2D stripeArea;
    }
    public unsafe struct VkRenderPassStripeBeginInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stripeInfoCount;
        public VkRenderPassStripeInfoARM* pStripeInfos;
    }
    public unsafe struct VkRenderPassStripeSubmitInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stripeSemaphoreInfoCount;
        public VkSemaphoreSubmitInfo* pStripeSemaphoreInfos;
    }
    public unsafe struct VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderMaximalReconvergence;
    }
    public unsafe struct VkPhysicalDeviceShaderSubgroupRotateFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderSubgroupRotate;
        public int shaderSubgroupRotateClustered;
    }
    public unsafe struct VkPhysicalDeviceShaderExpectAssumeFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderExpectAssume;
    }
    public unsafe struct VkPhysicalDeviceShaderFloatControls2FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderFloatControls2;
    }
    public unsafe struct VkPhysicalDeviceDynamicRenderingLocalReadFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int dynamicRenderingLocalRead;
    }
    public unsafe struct VkRenderingAttachmentLocationInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint colorAttachmentCount;
        public uint* pColorAttachmentLocations;
    }
    public unsafe struct VkRenderingInputAttachmentIndexInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint colorAttachmentCount;
        public uint* pColorAttachmentInputIndices;
        public uint* pDepthInputAttachmentIndex;
        public uint* pStencilInputAttachmentIndex;
    }
    public unsafe struct VkPhysicalDeviceShaderQuadControlFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderQuadControl;
    }
    public unsafe struct VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderFloat16VectorAtomics;
    }
    public unsafe struct VkPhysicalDeviceMapMemoryPlacedFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int memoryMapPlaced;
        public int memoryMapRangePlaced;
        public int memoryUnmapReserve;
    }
    public unsafe struct VkPhysicalDeviceMapMemoryPlacedPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong minPlacedMemoryMapAlignment;
    }
    public unsafe struct VkMemoryMapPlacedInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pPlacedAddress;
    }
    public unsafe struct VkPhysicalDeviceRawAccessChainsFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderRawAccessChains;
    }
    public unsafe struct VkPhysicalDeviceImageAlignmentControlFeaturesMESA
    {
        public VkStructureType sType;
        public void* pNext;
        public int imageAlignmentControl;
    }
    public unsafe struct VkPhysicalDeviceImageAlignmentControlPropertiesMESA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint supportedImageAlignmentMask;
    }
    public unsafe struct VkImageAlignmentControlCreateInfoMESA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maximumRequestedAlignment;
    }
    public unsafe struct VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public int shaderReplicatedComposites;
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
