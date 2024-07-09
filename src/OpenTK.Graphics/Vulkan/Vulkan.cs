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
    public static unsafe partial class Vk
    {
        public static VkResult CreateInstance(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pInstance)
        {
            return VkPointers._vkCreateInstance_fnptr(pCreateInfo, pAllocator, pInstance);
        }
        public static void DestroyInstance(IntPtr instance, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyInstance_fnptr(instance, pAllocator);
        }
        public static VkResult EnumeratePhysicalDevices(IntPtr instance, uint* pPhysicalDeviceCount, IntPtr* pPhysicalDevices)
        {
            return VkPointers._vkEnumeratePhysicalDevices_fnptr(instance, pPhysicalDeviceCount, pPhysicalDevices);
        }
        public static IntPtr GetDeviceProcAddr(IntPtr device, byte* pName)
        {
            return VkPointers._vkGetDeviceProcAddr_fnptr(device, pName);
        }
        public static IntPtr GetInstanceProcAddr(IntPtr instance, byte* pName)
        {
            return VkPointers._vkGetInstanceProcAddr_fnptr(instance, pName);
        }
        public static void GetPhysicalDeviceProperties(IntPtr physicalDevice, VkPhysicalDeviceProperties* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceProperties_fnptr(physicalDevice, pProperties);
        }
        public static void GetPhysicalDeviceQueueFamilyProperties(IntPtr physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties)
        {
            VkPointers._vkGetPhysicalDeviceQueueFamilyProperties_fnptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        public static void GetPhysicalDeviceMemoryProperties(IntPtr physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties)
        {
            VkPointers._vkGetPhysicalDeviceMemoryProperties_fnptr(physicalDevice, pMemoryProperties);
        }
        public static void GetPhysicalDeviceFeatures(IntPtr physicalDevice, VkPhysicalDeviceFeatures* pFeatures)
        {
            VkPointers._vkGetPhysicalDeviceFeatures_fnptr(physicalDevice, pFeatures);
        }
        public static void GetPhysicalDeviceFormatProperties(IntPtr physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties)
        {
            VkPointers._vkGetPhysicalDeviceFormatProperties_fnptr(physicalDevice, format, pFormatProperties);
        }
        public static VkResult GetPhysicalDeviceImageFormatProperties(IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlagBits usage, VkImageCreateFlagBits flags, VkImageFormatProperties* pImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceImageFormatProperties_fnptr(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);
        }
        public static VkResult CreateDevice(IntPtr physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pDevice)
        {
            return VkPointers._vkCreateDevice_fnptr(physicalDevice, pCreateInfo, pAllocator, pDevice);
        }
        public static void DestroyDevice(IntPtr device, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDevice_fnptr(device, pAllocator);
        }
        public static VkResult EnumerateInstanceVersion(uint* pApiVersion)
        {
            return VkPointers._vkEnumerateInstanceVersion_fnptr(pApiVersion);
        }
        public static VkResult EnumerateInstanceLayerProperties(uint* pPropertyCount, VkLayerProperties* pProperties)
        {
            return VkPointers._vkEnumerateInstanceLayerProperties_fnptr(pPropertyCount, pProperties);
        }
        public static VkResult EnumerateInstanceExtensionProperties(byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
        {
            return VkPointers._vkEnumerateInstanceExtensionProperties_fnptr(pLayerName, pPropertyCount, pProperties);
        }
        public static VkResult EnumerateDeviceLayerProperties(IntPtr physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties)
        {
            return VkPointers._vkEnumerateDeviceLayerProperties_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static VkResult EnumerateDeviceExtensionProperties(IntPtr physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
        {
            return VkPointers._vkEnumerateDeviceExtensionProperties_fnptr(physicalDevice, pLayerName, pPropertyCount, pProperties);
        }
        public static void GetDeviceQueue(IntPtr device, uint queueFamilyIndex, uint queueIndex, IntPtr* pQueue)
        {
            VkPointers._vkGetDeviceQueue_fnptr(device, queueFamilyIndex, queueIndex, pQueue);
        }
        public static VkResult QueueSubmit(IntPtr queue, uint submitCount, VkSubmitInfo* pSubmits, IntPtr fence)
        {
            return VkPointers._vkQueueSubmit_fnptr(queue, submitCount, pSubmits, fence);
        }
        public static VkResult QueueWaitIdle(IntPtr queue)
        {
            return VkPointers._vkQueueWaitIdle_fnptr(queue);
        }
        public static VkResult DeviceWaitIdle(IntPtr device)
        {
            return VkPointers._vkDeviceWaitIdle_fnptr(device);
        }
        public static VkResult AllocateMemory(IntPtr device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pMemory)
        {
            return VkPointers._vkAllocateMemory_fnptr(device, pAllocateInfo, pAllocator, pMemory);
        }
        public static void FreeMemory(IntPtr device, IntPtr memory, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkFreeMemory_fnptr(device, memory, pAllocator);
        }
        public static VkResult MapMemory(IntPtr device, IntPtr memory, ulong offset, ulong size, VkMemoryMapFlagBits flags, void** ppData)
        {
            return VkPointers._vkMapMemory_fnptr(device, memory, offset, size, flags, ppData);
        }
        public static void UnmapMemory(IntPtr device, IntPtr memory)
        {
            VkPointers._vkUnmapMemory_fnptr(device, memory);
        }
        public static VkResult FlushMappedMemoryRanges(IntPtr device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
        {
            return VkPointers._vkFlushMappedMemoryRanges_fnptr(device, memoryRangeCount, pMemoryRanges);
        }
        public static VkResult InvalidateMappedMemoryRanges(IntPtr device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
        {
            return VkPointers._vkInvalidateMappedMemoryRanges_fnptr(device, memoryRangeCount, pMemoryRanges);
        }
        public static void GetDeviceMemoryCommitment(IntPtr device, IntPtr memory, ulong* pCommittedMemoryInBytes)
        {
            VkPointers._vkGetDeviceMemoryCommitment_fnptr(device, memory, pCommittedMemoryInBytes);
        }
        public static void GetBufferMemoryRequirements(IntPtr device, IntPtr buffer, VkMemoryRequirements* pMemoryRequirements)
        {
            VkPointers._vkGetBufferMemoryRequirements_fnptr(device, buffer, pMemoryRequirements);
        }
        public static VkResult BindBufferMemory(IntPtr device, IntPtr buffer, IntPtr memory, ulong memoryOffset)
        {
            return VkPointers._vkBindBufferMemory_fnptr(device, buffer, memory, memoryOffset);
        }
        public static void GetImageMemoryRequirements(IntPtr device, IntPtr image, VkMemoryRequirements* pMemoryRequirements)
        {
            VkPointers._vkGetImageMemoryRequirements_fnptr(device, image, pMemoryRequirements);
        }
        public static VkResult BindImageMemory(IntPtr device, IntPtr image, IntPtr memory, ulong memoryOffset)
        {
            return VkPointers._vkBindImageMemory_fnptr(device, image, memory, memoryOffset);
        }
        public static void GetImageSparseMemoryRequirements(IntPtr device, IntPtr image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements)
        {
            VkPointers._vkGetImageSparseMemoryRequirements_fnptr(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        public static void GetPhysicalDeviceSparseImageFormatProperties(IntPtr physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlagBits usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceSparseImageFormatProperties_fnptr(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);
        }
        public static VkResult QueueBindSparse(IntPtr queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, IntPtr fence)
        {
            return VkPointers._vkQueueBindSparse_fnptr(queue, bindInfoCount, pBindInfo, fence);
        }
        public static VkResult CreateFence(IntPtr device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pFence)
        {
            return VkPointers._vkCreateFence_fnptr(device, pCreateInfo, pAllocator, pFence);
        }
        public static void DestroyFence(IntPtr device, IntPtr fence, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyFence_fnptr(device, fence, pAllocator);
        }
        public static VkResult ResetFences(IntPtr device, uint fenceCount, IntPtr* pFences)
        {
            return VkPointers._vkResetFences_fnptr(device, fenceCount, pFences);
        }
        public static VkResult GetFenceStatus(IntPtr device, IntPtr fence)
        {
            return VkPointers._vkGetFenceStatus_fnptr(device, fence);
        }
        public static VkResult WaitForFences(IntPtr device, uint fenceCount, IntPtr* pFences, int waitAll, ulong timeout)
        {
            return VkPointers._vkWaitForFences_fnptr(device, fenceCount, pFences, waitAll, timeout);
        }
        public static VkResult CreateSemaphore(IntPtr device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSemaphore)
        {
            return VkPointers._vkCreateSemaphore_fnptr(device, pCreateInfo, pAllocator, pSemaphore);
        }
        public static void DestroySemaphore(IntPtr device, IntPtr semaphore, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySemaphore_fnptr(device, semaphore, pAllocator);
        }
        public static VkResult CreateEvent(IntPtr device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pEvent)
        {
            return VkPointers._vkCreateEvent_fnptr(device, pCreateInfo, pAllocator, pEvent);
        }
        public static void DestroyEvent(IntPtr device, IntPtr @event, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyEvent_fnptr(device, @event, pAllocator);
        }
        public static VkResult GetEventStatus(IntPtr device, IntPtr @event)
        {
            return VkPointers._vkGetEventStatus_fnptr(device, @event);
        }
        public static VkResult SetEvent(IntPtr device, IntPtr @event)
        {
            return VkPointers._vkSetEvent_fnptr(device, @event);
        }
        public static VkResult ResetEvent(IntPtr device, IntPtr @event)
        {
            return VkPointers._vkResetEvent_fnptr(device, @event);
        }
        public static VkResult CreateQueryPool(IntPtr device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pQueryPool)
        {
            return VkPointers._vkCreateQueryPool_fnptr(device, pCreateInfo, pAllocator, pQueryPool);
        }
        public static void DestroyQueryPool(IntPtr device, IntPtr queryPool, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyQueryPool_fnptr(device, queryPool, pAllocator);
        }
        public static VkResult GetQueryPoolResults(IntPtr device, IntPtr queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* pData, ulong stride, VkQueryResultFlagBits flags)
        {
            return VkPointers._vkGetQueryPoolResults_fnptr(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);
        }
        public static void ResetQueryPool(IntPtr device, IntPtr queryPool, uint firstQuery, uint queryCount)
        {
            VkPointers._vkResetQueryPool_fnptr(device, queryPool, firstQuery, queryCount);
        }
        public static VkResult CreateBuffer(IntPtr device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pBuffer)
        {
            return VkPointers._vkCreateBuffer_fnptr(device, pCreateInfo, pAllocator, pBuffer);
        }
        public static void DestroyBuffer(IntPtr device, IntPtr buffer, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyBuffer_fnptr(device, buffer, pAllocator);
        }
        public static VkResult CreateBufferView(IntPtr device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pView)
        {
            return VkPointers._vkCreateBufferView_fnptr(device, pCreateInfo, pAllocator, pView);
        }
        public static void DestroyBufferView(IntPtr device, IntPtr bufferView, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyBufferView_fnptr(device, bufferView, pAllocator);
        }
        public static VkResult CreateImage(IntPtr device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pImage)
        {
            return VkPointers._vkCreateImage_fnptr(device, pCreateInfo, pAllocator, pImage);
        }
        public static void DestroyImage(IntPtr device, IntPtr image, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyImage_fnptr(device, image, pAllocator);
        }
        public static void GetImageSubresourceLayout(IntPtr device, IntPtr image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout)
        {
            VkPointers._vkGetImageSubresourceLayout_fnptr(device, image, pSubresource, pLayout);
        }
        public static VkResult CreateImageView(IntPtr device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pView)
        {
            return VkPointers._vkCreateImageView_fnptr(device, pCreateInfo, pAllocator, pView);
        }
        public static void DestroyImageView(IntPtr device, IntPtr imageView, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyImageView_fnptr(device, imageView, pAllocator);
        }
        public static VkResult CreateShaderModule(IntPtr device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pShaderModule)
        {
            return VkPointers._vkCreateShaderModule_fnptr(device, pCreateInfo, pAllocator, pShaderModule);
        }
        public static void DestroyShaderModule(IntPtr device, IntPtr shaderModule, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyShaderModule_fnptr(device, shaderModule, pAllocator);
        }
        public static VkResult CreatePipelineCache(IntPtr device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pPipelineCache)
        {
            return VkPointers._vkCreatePipelineCache_fnptr(device, pCreateInfo, pAllocator, pPipelineCache);
        }
        public static void DestroyPipelineCache(IntPtr device, IntPtr pipelineCache, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPipelineCache_fnptr(device, pipelineCache, pAllocator);
        }
        public static VkResult GetPipelineCacheData(IntPtr device, IntPtr pipelineCache, nuint* pDataSize, void* pData)
        {
            return VkPointers._vkGetPipelineCacheData_fnptr(device, pipelineCache, pDataSize, pData);
        }
        public static VkResult MergePipelineCaches(IntPtr device, IntPtr dstCache, uint srcCacheCount, IntPtr* pSrcCaches)
        {
            return VkPointers._vkMergePipelineCaches_fnptr(device, dstCache, srcCacheCount, pSrcCaches);
        }
        public static VkResult CreateGraphicsPipelines(IntPtr device, IntPtr pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, IntPtr* pPipelines)
        {
            return VkPointers._vkCreateGraphicsPipelines_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static VkResult CreateComputePipelines(IntPtr device, IntPtr pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, IntPtr* pPipelines)
        {
            return VkPointers._vkCreateComputePipelines_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static VkResult GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(IntPtr device, IntPtr renderpass, VkExtent2D* pMaxWorkgroupSize)
        {
            return VkPointers._vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_fnptr(device, renderpass, pMaxWorkgroupSize);
        }
        public static void DestroyPipeline(IntPtr device, IntPtr pipeline, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPipeline_fnptr(device, pipeline, pAllocator);
        }
        public static VkResult CreatePipelineLayout(IntPtr device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pPipelineLayout)
        {
            return VkPointers._vkCreatePipelineLayout_fnptr(device, pCreateInfo, pAllocator, pPipelineLayout);
        }
        public static void DestroyPipelineLayout(IntPtr device, IntPtr pipelineLayout, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPipelineLayout_fnptr(device, pipelineLayout, pAllocator);
        }
        public static VkResult CreateSampler(IntPtr device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSampler)
        {
            return VkPointers._vkCreateSampler_fnptr(device, pCreateInfo, pAllocator, pSampler);
        }
        public static void DestroySampler(IntPtr device, IntPtr sampler, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySampler_fnptr(device, sampler, pAllocator);
        }
        public static VkResult CreateDescriptorSetLayout(IntPtr device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSetLayout)
        {
            return VkPointers._vkCreateDescriptorSetLayout_fnptr(device, pCreateInfo, pAllocator, pSetLayout);
        }
        public static void DestroyDescriptorSetLayout(IntPtr device, IntPtr descriptorSetLayout, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDescriptorSetLayout_fnptr(device, descriptorSetLayout, pAllocator);
        }
        public static VkResult CreateDescriptorPool(IntPtr device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pDescriptorPool)
        {
            return VkPointers._vkCreateDescriptorPool_fnptr(device, pCreateInfo, pAllocator, pDescriptorPool);
        }
        public static void DestroyDescriptorPool(IntPtr device, IntPtr descriptorPool, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDescriptorPool_fnptr(device, descriptorPool, pAllocator);
        }
        public static VkResult ResetDescriptorPool(IntPtr device, IntPtr descriptorPool, VkDescriptorPoolResetFlags flags)
        {
            return VkPointers._vkResetDescriptorPool_fnptr(device, descriptorPool, flags);
        }
        public static VkResult AllocateDescriptorSets(IntPtr device, VkDescriptorSetAllocateInfo* pAllocateInfo, IntPtr* pDescriptorSets)
        {
            return VkPointers._vkAllocateDescriptorSets_fnptr(device, pAllocateInfo, pDescriptorSets);
        }
        public static VkResult FreeDescriptorSets(IntPtr device, IntPtr descriptorPool, uint descriptorSetCount, IntPtr* pDescriptorSets)
        {
            return VkPointers._vkFreeDescriptorSets_fnptr(device, descriptorPool, descriptorSetCount, pDescriptorSets);
        }
        public static void UpdateDescriptorSets(IntPtr device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies)
        {
            VkPointers._vkUpdateDescriptorSets_fnptr(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);
        }
        public static VkResult CreateFramebuffer(IntPtr device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pFramebuffer)
        {
            return VkPointers._vkCreateFramebuffer_fnptr(device, pCreateInfo, pAllocator, pFramebuffer);
        }
        public static void DestroyFramebuffer(IntPtr device, IntPtr framebuffer, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyFramebuffer_fnptr(device, framebuffer, pAllocator);
        }
        public static VkResult CreateRenderPass(IntPtr device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pRenderPass)
        {
            return VkPointers._vkCreateRenderPass_fnptr(device, pCreateInfo, pAllocator, pRenderPass);
        }
        public static void DestroyRenderPass(IntPtr device, IntPtr renderPass, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyRenderPass_fnptr(device, renderPass, pAllocator);
        }
        public static void GetRenderAreaGranularity(IntPtr device, IntPtr renderPass, VkExtent2D* pGranularity)
        {
            VkPointers._vkGetRenderAreaGranularity_fnptr(device, renderPass, pGranularity);
        }
        public static void GetRenderingAreaGranularityKHR(IntPtr device, VkRenderingAreaInfoKHR* pRenderingAreaInfo, VkExtent2D* pGranularity)
        {
            VkPointers._vkGetRenderingAreaGranularityKHR_fnptr(device, pRenderingAreaInfo, pGranularity);
        }
        public static VkResult CreateCommandPool(IntPtr device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pCommandPool)
        {
            return VkPointers._vkCreateCommandPool_fnptr(device, pCreateInfo, pAllocator, pCommandPool);
        }
        public static void DestroyCommandPool(IntPtr device, IntPtr commandPool, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCommandPool_fnptr(device, commandPool, pAllocator);
        }
        public static VkResult ResetCommandPool(IntPtr device, IntPtr commandPool, VkCommandPoolResetFlagBits flags)
        {
            return VkPointers._vkResetCommandPool_fnptr(device, commandPool, flags);
        }
        public static VkResult AllocateCommandBuffers(IntPtr device, VkCommandBufferAllocateInfo* pAllocateInfo, IntPtr* pCommandBuffers)
        {
            return VkPointers._vkAllocateCommandBuffers_fnptr(device, pAllocateInfo, pCommandBuffers);
        }
        public static void FreeCommandBuffers(IntPtr device, IntPtr commandPool, uint commandBufferCount, IntPtr* pCommandBuffers)
        {
            VkPointers._vkFreeCommandBuffers_fnptr(device, commandPool, commandBufferCount, pCommandBuffers);
        }
        public static VkResult BeginCommandBuffer(IntPtr commandBuffer, VkCommandBufferBeginInfo* pBeginInfo)
        {
            return VkPointers._vkBeginCommandBuffer_fnptr(commandBuffer, pBeginInfo);
        }
        public static VkResult EndCommandBuffer(IntPtr commandBuffer)
        {
            return VkPointers._vkEndCommandBuffer_fnptr(commandBuffer);
        }
        public static VkResult ResetCommandBuffer(IntPtr commandBuffer, VkCommandBufferResetFlagBits flags)
        {
            return VkPointers._vkResetCommandBuffer_fnptr(commandBuffer, flags);
        }
        public static void CmdBindPipeline(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr pipeline)
        {
            VkPointers._vkCmdBindPipeline_fnptr(commandBuffer, pipelineBindPoint, pipeline);
        }
        public static void CmdSetAttachmentFeedbackLoopEnableEXT(IntPtr commandBuffer, VkImageAspectFlagBits aspectMask)
        {
            VkPointers._vkCmdSetAttachmentFeedbackLoopEnableEXT_fnptr(commandBuffer, aspectMask);
        }
        public static void CmdSetViewport(IntPtr commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports)
        {
            VkPointers._vkCmdSetViewport_fnptr(commandBuffer, firstViewport, viewportCount, pViewports);
        }
        public static void CmdSetScissor(IntPtr commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors)
        {
            VkPointers._vkCmdSetScissor_fnptr(commandBuffer, firstScissor, scissorCount, pScissors);
        }
        public static void CmdSetLineWidth(IntPtr commandBuffer, float lineWidth)
        {
            VkPointers._vkCmdSetLineWidth_fnptr(commandBuffer, lineWidth);
        }
        public static void CmdSetDepthBias(IntPtr commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            VkPointers._vkCmdSetDepthBias_fnptr(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
        }
        public static void CmdSetBlendConstants(IntPtr commandBuffer, float* blendConstants)
        {
            VkPointers._vkCmdSetBlendConstants_fnptr(commandBuffer, blendConstants);
        }
        public static void CmdSetDepthBounds(IntPtr commandBuffer, float minDepthBounds, float maxDepthBounds)
        {
            VkPointers._vkCmdSetDepthBounds_fnptr(commandBuffer, minDepthBounds, maxDepthBounds);
        }
        public static void CmdSetStencilCompareMask(IntPtr commandBuffer, VkStencilFaceFlagBits faceMask, uint compareMask)
        {
            VkPointers._vkCmdSetStencilCompareMask_fnptr(commandBuffer, faceMask, compareMask);
        }
        public static void CmdSetStencilWriteMask(IntPtr commandBuffer, VkStencilFaceFlagBits faceMask, uint writeMask)
        {
            VkPointers._vkCmdSetStencilWriteMask_fnptr(commandBuffer, faceMask, writeMask);
        }
        public static void CmdSetStencilReference(IntPtr commandBuffer, VkStencilFaceFlagBits faceMask, uint reference)
        {
            VkPointers._vkCmdSetStencilReference_fnptr(commandBuffer, faceMask, reference);
        }
        public static void CmdBindDescriptorSets(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr layout, uint firstSet, uint descriptorSetCount, IntPtr* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
        {
            VkPointers._vkCmdBindDescriptorSets_fnptr(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);
        }
        public static void CmdBindIndexBuffer(IntPtr commandBuffer, IntPtr buffer, ulong offset, VkIndexType indexType)
        {
            VkPointers._vkCmdBindIndexBuffer_fnptr(commandBuffer, buffer, offset, indexType);
        }
        public static void CmdBindVertexBuffers(IntPtr commandBuffer, uint firstBinding, uint bindingCount, IntPtr* pBuffers, ulong* pOffsets)
        {
            VkPointers._vkCmdBindVertexBuffers_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);
        }
        public static void CmdDraw(IntPtr commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            VkPointers._vkCmdDraw_fnptr(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
        }
        public static void CmdDrawIndexed(IntPtr commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            VkPointers._vkCmdDrawIndexed_fnptr(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
        }
        public static void CmdDrawMultiEXT(IntPtr commandBuffer, uint drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
        {
            VkPointers._vkCmdDrawMultiEXT_fnptr(commandBuffer, drawCount, pVertexInfo, instanceCount, firstInstance, stride);
        }
        public static void CmdDrawMultiIndexedEXT(IntPtr commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
        {
            VkPointers._vkCmdDrawMultiIndexedEXT_fnptr(commandBuffer, drawCount, pIndexInfo, instanceCount, firstInstance, stride, pVertexOffset);
        }
        public static void CmdDrawIndirect(IntPtr commandBuffer, IntPtr buffer, ulong offset, uint drawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndirect_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        public static void CmdDrawIndexedIndirect(IntPtr commandBuffer, IntPtr buffer, ulong offset, uint drawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndexedIndirect_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        public static void CmdDispatch(IntPtr commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDispatch_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        public static void CmdDispatchIndirect(IntPtr commandBuffer, IntPtr buffer, ulong offset)
        {
            VkPointers._vkCmdDispatchIndirect_fnptr(commandBuffer, buffer, offset);
        }
        public static void CmdSubpassShadingHUAWEI(IntPtr commandBuffer)
        {
            VkPointers._vkCmdSubpassShadingHUAWEI_fnptr(commandBuffer);
        }
        public static void CmdDrawClusterHUAWEI(IntPtr commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDrawClusterHUAWEI_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        public static void CmdDrawClusterIndirectHUAWEI(IntPtr commandBuffer, IntPtr buffer, ulong offset)
        {
            VkPointers._vkCmdDrawClusterIndirectHUAWEI_fnptr(commandBuffer, buffer, offset);
        }
        public static void CmdUpdatePipelineIndirectBufferNV(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr pipeline)
        {
            VkPointers._vkCmdUpdatePipelineIndirectBufferNV_fnptr(commandBuffer, pipelineBindPoint, pipeline);
        }
        public static void CmdCopyBuffer(IntPtr commandBuffer, IntPtr srcBuffer, IntPtr dstBuffer, uint regionCount, VkBufferCopy* pRegions)
        {
            VkPointers._vkCmdCopyBuffer_fnptr(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);
        }
        public static void CmdCopyImage(IntPtr commandBuffer, IntPtr srcImage, VkImageLayout srcImageLayout, IntPtr dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions)
        {
            VkPointers._vkCmdCopyImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
        }
        public static void CmdBlitImage(IntPtr commandBuffer, IntPtr srcImage, VkImageLayout srcImageLayout, IntPtr dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter)
        {
            VkPointers._vkCmdBlitImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
        }
        public static void CmdCopyBufferToImage(IntPtr commandBuffer, IntPtr srcBuffer, IntPtr dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions)
        {
            VkPointers._vkCmdCopyBufferToImage_fnptr(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);
        }
        public static void CmdCopyImageToBuffer(IntPtr commandBuffer, IntPtr srcImage, VkImageLayout srcImageLayout, IntPtr dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
        {
            VkPointers._vkCmdCopyImageToBuffer_fnptr(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
        }
        public static void CmdCopyMemoryIndirectNV(IntPtr commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride)
        {
            VkPointers._vkCmdCopyMemoryIndirectNV_fnptr(commandBuffer, copyBufferAddress, copyCount, stride);
        }
        public static void CmdCopyMemoryToImageIndirectNV(IntPtr commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, IntPtr dstImage, VkImageLayout dstImageLayout, VkImageSubresourceLayers* pImageSubresources)
        {
            VkPointers._vkCmdCopyMemoryToImageIndirectNV_fnptr(commandBuffer, copyBufferAddress, copyCount, stride, dstImage, dstImageLayout, pImageSubresources);
        }
        public static void CmdUpdateBuffer(IntPtr commandBuffer, IntPtr dstBuffer, ulong dstOffset, ulong dataSize, void* pData)
        {
            VkPointers._vkCmdUpdateBuffer_fnptr(commandBuffer, dstBuffer, dstOffset, dataSize, pData);
        }
        public static void CmdFillBuffer(IntPtr commandBuffer, IntPtr dstBuffer, ulong dstOffset, ulong size, uint data)
        {
            VkPointers._vkCmdFillBuffer_fnptr(commandBuffer, dstBuffer, dstOffset, size, data);
        }
        public static void CmdClearColorImage(IntPtr commandBuffer, IntPtr image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            VkPointers._vkCmdClearColorImage_fnptr(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);
        }
        public static void CmdClearDepthStencilImage(IntPtr commandBuffer, IntPtr image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            VkPointers._vkCmdClearDepthStencilImage_fnptr(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);
        }
        public static void CmdClearAttachments(IntPtr commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects)
        {
            VkPointers._vkCmdClearAttachments_fnptr(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);
        }
        public static void CmdResolveImage(IntPtr commandBuffer, IntPtr srcImage, VkImageLayout srcImageLayout, IntPtr dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions)
        {
            VkPointers._vkCmdResolveImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
        }
        public static void CmdSetEvent(IntPtr commandBuffer, IntPtr @event, VkPipelineStageFlagBits stageMask)
        {
            VkPointers._vkCmdSetEvent_fnptr(commandBuffer, @event, stageMask);
        }
        public static void CmdResetEvent(IntPtr commandBuffer, IntPtr @event, VkPipelineStageFlagBits stageMask)
        {
            VkPointers._vkCmdResetEvent_fnptr(commandBuffer, @event, stageMask);
        }
        public static void CmdWaitEvents(IntPtr commandBuffer, uint eventCount, IntPtr* pEvents, VkPipelineStageFlagBits srcStageMask, VkPipelineStageFlagBits dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
        {
            VkPointers._vkCmdWaitEvents_fnptr(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }
        public static void CmdPipelineBarrier(IntPtr commandBuffer, VkPipelineStageFlagBits srcStageMask, VkPipelineStageFlagBits dstStageMask, VkDependencyFlagBits dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
        {
            VkPointers._vkCmdPipelineBarrier_fnptr(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }
        public static void CmdBeginQuery(IntPtr commandBuffer, IntPtr queryPool, uint query, VkQueryControlFlagBits flags)
        {
            VkPointers._vkCmdBeginQuery_fnptr(commandBuffer, queryPool, query, flags);
        }
        public static void CmdEndQuery(IntPtr commandBuffer, IntPtr queryPool, uint query)
        {
            VkPointers._vkCmdEndQuery_fnptr(commandBuffer, queryPool, query);
        }
        public static void CmdBeginConditionalRenderingEXT(IntPtr commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
        {
            VkPointers._vkCmdBeginConditionalRenderingEXT_fnptr(commandBuffer, pConditionalRenderingBegin);
        }
        public static void CmdEndConditionalRenderingEXT(IntPtr commandBuffer)
        {
            VkPointers._vkCmdEndConditionalRenderingEXT_fnptr(commandBuffer);
        }
        public static void CmdResetQueryPool(IntPtr commandBuffer, IntPtr queryPool, uint firstQuery, uint queryCount)
        {
            VkPointers._vkCmdResetQueryPool_fnptr(commandBuffer, queryPool, firstQuery, queryCount);
        }
        public static void CmdWriteTimestamp(IntPtr commandBuffer, VkPipelineStageFlagBits pipelineStage, IntPtr queryPool, uint query)
        {
            VkPointers._vkCmdWriteTimestamp_fnptr(commandBuffer, pipelineStage, queryPool, query);
        }
        public static void CmdCopyQueryPoolResults(IntPtr commandBuffer, IntPtr queryPool, uint firstQuery, uint queryCount, IntPtr dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlagBits flags)
        {
            VkPointers._vkCmdCopyQueryPoolResults_fnptr(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
        }
        public static void CmdPushConstants(IntPtr commandBuffer, IntPtr layout, VkShaderStageFlagBits stageFlags, uint offset, uint size, void* pValues)
        {
            VkPointers._vkCmdPushConstants_fnptr(commandBuffer, layout, stageFlags, offset, size, pValues);
        }
        public static void CmdBeginRenderPass(IntPtr commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents)
        {
            VkPointers._vkCmdBeginRenderPass_fnptr(commandBuffer, pRenderPassBegin, contents);
        }
        public static void CmdNextSubpass(IntPtr commandBuffer, VkSubpassContents contents)
        {
            VkPointers._vkCmdNextSubpass_fnptr(commandBuffer, contents);
        }
        public static void CmdEndRenderPass(IntPtr commandBuffer)
        {
            VkPointers._vkCmdEndRenderPass_fnptr(commandBuffer);
        }
        public static void CmdExecuteCommands(IntPtr commandBuffer, uint commandBufferCount, IntPtr* pCommandBuffers)
        {
            VkPointers._vkCmdExecuteCommands_fnptr(commandBuffer, commandBufferCount, pCommandBuffers);
        }
        public static VkResult CreateAndroidSurfaceKHR(IntPtr instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateAndroidSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult GetPhysicalDeviceDisplayPropertiesKHR(IntPtr physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceDisplayPropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(IntPtr physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceDisplayPlanePropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static VkResult GetDisplayPlaneSupportedDisplaysKHR(IntPtr physicalDevice, uint planeIndex, uint* pDisplayCount, IntPtr* pDisplays)
        {
            return VkPointers._vkGetDisplayPlaneSupportedDisplaysKHR_fnptr(physicalDevice, planeIndex, pDisplayCount, pDisplays);
        }
        public static VkResult GetDisplayModePropertiesKHR(IntPtr physicalDevice, IntPtr display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
        {
            return VkPointers._vkGetDisplayModePropertiesKHR_fnptr(physicalDevice, display, pPropertyCount, pProperties);
        }
        public static VkResult CreateDisplayModeKHR(IntPtr physicalDevice, IntPtr display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pMode)
        {
            return VkPointers._vkCreateDisplayModeKHR_fnptr(physicalDevice, display, pCreateInfo, pAllocator, pMode);
        }
        public static VkResult GetDisplayPlaneCapabilitiesKHR(IntPtr physicalDevice, IntPtr mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)
        {
            return VkPointers._vkGetDisplayPlaneCapabilitiesKHR_fnptr(physicalDevice, mode, planeIndex, pCapabilities);
        }
        public static VkResult CreateDisplayPlaneSurfaceKHR(IntPtr instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateDisplayPlaneSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult CreateSharedSwapchainsKHR(IntPtr device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, IntPtr* pSwapchains)
        {
            return VkPointers._vkCreateSharedSwapchainsKHR_fnptr(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);
        }
        public static void DestroySurfaceKHR(IntPtr instance, IntPtr surface, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySurfaceKHR_fnptr(instance, surface, pAllocator);
        }
        public static VkResult GetPhysicalDeviceSurfaceSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex, IntPtr surface, int* pSupported)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceSupportKHR_fnptr(physicalDevice, queueFamilyIndex, surface, pSupported);
        }
        public static VkResult GetPhysicalDeviceSurfaceCapabilitiesKHR(IntPtr physicalDevice, IntPtr surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceCapabilitiesKHR_fnptr(physicalDevice, surface, pSurfaceCapabilities);
        }
        public static VkResult GetPhysicalDeviceSurfaceFormatsKHR(IntPtr physicalDevice, IntPtr surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceFormatsKHR_fnptr(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);
        }
        public static VkResult GetPhysicalDeviceSurfacePresentModesKHR(IntPtr physicalDevice, IntPtr surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            return VkPointers._vkGetPhysicalDeviceSurfacePresentModesKHR_fnptr(physicalDevice, surface, pPresentModeCount, pPresentModes);
        }
        public static VkResult CreateSwapchainKHR(IntPtr device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSwapchain)
        {
            return VkPointers._vkCreateSwapchainKHR_fnptr(device, pCreateInfo, pAllocator, pSwapchain);
        }
        public static void DestroySwapchainKHR(IntPtr device, IntPtr swapchain, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySwapchainKHR_fnptr(device, swapchain, pAllocator);
        }
        public static VkResult GetSwapchainImagesKHR(IntPtr device, IntPtr swapchain, uint* pSwapchainImageCount, IntPtr* pSwapchainImages)
        {
            return VkPointers._vkGetSwapchainImagesKHR_fnptr(device, swapchain, pSwapchainImageCount, pSwapchainImages);
        }
        public static VkResult AcquireNextImageKHR(IntPtr device, IntPtr swapchain, ulong timeout, IntPtr semaphore, IntPtr fence, uint* pImageIndex)
        {
            return VkPointers._vkAcquireNextImageKHR_fnptr(device, swapchain, timeout, semaphore, fence, pImageIndex);
        }
        public static VkResult QueuePresentKHR(IntPtr queue, VkPresentInfoKHR* pPresentInfo)
        {
            return VkPointers._vkQueuePresentKHR_fnptr(queue, pPresentInfo);
        }
        public static VkResult CreateViSurfaceNN(IntPtr instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateViSurfaceNN_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult CreateWaylandSurfaceKHR(IntPtr instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateWaylandSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static int GetPhysicalDeviceWaylandPresentationSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex, IntPtr display)
        {
            return VkPointers._vkGetPhysicalDeviceWaylandPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, display);
        }
        public static VkResult CreateWin32SurfaceKHR(IntPtr instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateWin32SurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static int GetPhysicalDeviceWin32PresentationSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex)
        {
            return VkPointers._vkGetPhysicalDeviceWin32PresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex);
        }
        public static VkResult CreateXlibSurfaceKHR(IntPtr instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateXlibSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static int GetPhysicalDeviceXlibPresentationSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex, IntPtr dpy, nuint visualID)
        {
            return VkPointers._vkGetPhysicalDeviceXlibPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, dpy, visualID);
        }
        public static VkResult CreateXcbSurfaceKHR(IntPtr instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateXcbSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static int GetPhysicalDeviceXcbPresentationSupportKHR(IntPtr physicalDevice, uint queueFamilyIndex, IntPtr connection, uint visual_id)
        {
            return VkPointers._vkGetPhysicalDeviceXcbPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, connection, visual_id);
        }
        public static VkResult CreateDirectFBSurfaceEXT(IntPtr instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateDirectFBSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static int GetPhysicalDeviceDirectFBPresentationSupportEXT(IntPtr physicalDevice, uint queueFamilyIndex, IntPtr dfb)
        {
            return VkPointers._vkGetPhysicalDeviceDirectFBPresentationSupportEXT_fnptr(physicalDevice, queueFamilyIndex, dfb);
        }
        public static VkResult CreateImagePipeSurfaceFUCHSIA(IntPtr instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateImagePipeSurfaceFUCHSIA_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult CreateStreamDescriptorSurfaceGGP(IntPtr instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateStreamDescriptorSurfaceGGP_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult CreateScreenSurfaceQNX(IntPtr instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateScreenSurfaceQNX_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static int GetPhysicalDeviceScreenPresentationSupportQNX(IntPtr physicalDevice, uint queueFamilyIndex, IntPtr* window)
        {
            return VkPointers._vkGetPhysicalDeviceScreenPresentationSupportQNX_fnptr(physicalDevice, queueFamilyIndex, window);
        }
        public static VkResult CreateDebugReportCallbackEXT(IntPtr instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pCallback)
        {
            return VkPointers._vkCreateDebugReportCallbackEXT_fnptr(instance, pCreateInfo, pAllocator, pCallback);
        }
        public static void DestroyDebugReportCallbackEXT(IntPtr instance, IntPtr callback, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDebugReportCallbackEXT_fnptr(instance, callback, pAllocator);
        }
        public static void DebugReportMessageEXT(IntPtr instance, VkDebugReportFlagBitsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong obj, nuint location, int messageCode, byte* pLayerPrefix, byte* pMessage)
        {
            VkPointers._vkDebugReportMessageEXT_fnptr(instance, flags, objectType, obj, location, messageCode, pLayerPrefix, pMessage);
        }
        public static VkResult DebugMarkerSetObjectNameEXT(IntPtr device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)
        {
            return VkPointers._vkDebugMarkerSetObjectNameEXT_fnptr(device, pNameInfo);
        }
        public static VkResult DebugMarkerSetObjectTagEXT(IntPtr device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)
        {
            return VkPointers._vkDebugMarkerSetObjectTagEXT_fnptr(device, pTagInfo);
        }
        public static void CmdDebugMarkerBeginEXT(IntPtr commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
        {
            VkPointers._vkCmdDebugMarkerBeginEXT_fnptr(commandBuffer, pMarkerInfo);
        }
        public static void CmdDebugMarkerEndEXT(IntPtr commandBuffer)
        {
            VkPointers._vkCmdDebugMarkerEndEXT_fnptr(commandBuffer);
        }
        public static void CmdDebugMarkerInsertEXT(IntPtr commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
        {
            VkPointers._vkCmdDebugMarkerInsertEXT_fnptr(commandBuffer, pMarkerInfo);
        }
        public static VkResult GetPhysicalDeviceExternalImageFormatPropertiesNV(IntPtr physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlagBits usage, VkImageCreateFlagBits flags, VkExternalMemoryHandleTypeFlagBitsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceExternalImageFormatPropertiesNV_fnptr(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);
        }
        public static VkResult GetMemoryWin32HandleNV(IntPtr device, IntPtr memory, VkExternalMemoryHandleTypeFlagBitsNV handleType, IntPtr* pHandle)
        {
            return VkPointers._vkGetMemoryWin32HandleNV_fnptr(device, memory, handleType, pHandle);
        }
        public static void CmdExecuteGeneratedCommandsNV(IntPtr commandBuffer, int isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
        {
            VkPointers._vkCmdExecuteGeneratedCommandsNV_fnptr(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);
        }
        public static void CmdPreprocessGeneratedCommandsNV(IntPtr commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
        {
            VkPointers._vkCmdPreprocessGeneratedCommandsNV_fnptr(commandBuffer, pGeneratedCommandsInfo);
        }
        public static void CmdBindPipelineShaderGroupNV(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr pipeline, uint groupIndex)
        {
            VkPointers._vkCmdBindPipelineShaderGroupNV_fnptr(commandBuffer, pipelineBindPoint, pipeline, groupIndex);
        }
        public static void GetGeneratedCommandsMemoryRequirementsNV(IntPtr device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetGeneratedCommandsMemoryRequirementsNV_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static VkResult CreateIndirectCommandsLayoutNV(IntPtr device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pIndirectCommandsLayout)
        {
            return VkPointers._vkCreateIndirectCommandsLayoutNV_fnptr(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);
        }
        public static void DestroyIndirectCommandsLayoutNV(IntPtr device, IntPtr indirectCommandsLayout, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyIndirectCommandsLayoutNV_fnptr(device, indirectCommandsLayout, pAllocator);
        }
        public static void GetPhysicalDeviceFeatures2(IntPtr physicalDevice, VkPhysicalDeviceFeatures2* pFeatures)
        {
            VkPointers._vkGetPhysicalDeviceFeatures2_fnptr(physicalDevice, pFeatures);
        }
        public static void GetPhysicalDeviceProperties2(IntPtr physicalDevice, VkPhysicalDeviceProperties2* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceProperties2_fnptr(physicalDevice, pProperties);
        }
        public static void GetPhysicalDeviceFormatProperties2(IntPtr physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties)
        {
            VkPointers._vkGetPhysicalDeviceFormatProperties2_fnptr(physicalDevice, format, pFormatProperties);
        }
        public static VkResult GetPhysicalDeviceImageFormatProperties2(IntPtr physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceImageFormatProperties2_fnptr(physicalDevice, pImageFormatInfo, pImageFormatProperties);
        }
        public static void GetPhysicalDeviceQueueFamilyProperties2(IntPtr physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
        {
            VkPointers._vkGetPhysicalDeviceQueueFamilyProperties2_fnptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        public static void GetPhysicalDeviceMemoryProperties2(IntPtr physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties)
        {
            VkPointers._vkGetPhysicalDeviceMemoryProperties2_fnptr(physicalDevice, pMemoryProperties);
        }
        public static void GetPhysicalDeviceSparseImageFormatProperties2(IntPtr physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceSparseImageFormatProperties2_fnptr(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
        }
        public static void CmdPushDescriptorSetKHR(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
        {
            VkPointers._vkCmdPushDescriptorSetKHR_fnptr(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
        }
        public static void TrimCommandPool(IntPtr device, IntPtr commandPool, VkCommandPoolTrimFlags flags)
        {
            VkPointers._vkTrimCommandPool_fnptr(device, commandPool, flags);
        }
        public static void GetPhysicalDeviceExternalBufferProperties(IntPtr physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalBufferProperties_fnptr(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
        }
        public static VkResult GetMemoryWin32HandleKHR(IntPtr device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            return VkPointers._vkGetMemoryWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        public static VkResult GetMemoryWin32HandlePropertiesKHR(IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties)
        {
            return VkPointers._vkGetMemoryWin32HandlePropertiesKHR_fnptr(device, handleType, handle, pMemoryWin32HandleProperties);
        }
        public static VkResult GetMemoryFdKHR(IntPtr device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            return VkPointers._vkGetMemoryFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        public static VkResult GetMemoryFdPropertiesKHR(IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties)
        {
            return VkPointers._vkGetMemoryFdPropertiesKHR_fnptr(device, handleType, fd, pMemoryFdProperties);
        }
        public static VkResult GetMemoryZirconHandleFUCHSIA(IntPtr device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, int* pZirconHandle)
        {
            return VkPointers._vkGetMemoryZirconHandleFUCHSIA_fnptr(device, pGetZirconHandleInfo, pZirconHandle);
        }
        public static VkResult GetMemoryZirconHandlePropertiesFUCHSIA(IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, int zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties)
        {
            return VkPointers._vkGetMemoryZirconHandlePropertiesFUCHSIA_fnptr(device, handleType, zirconHandle, pMemoryZirconHandleProperties);
        }
        public static VkResult GetMemoryRemoteAddressNV(IntPtr device, VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, void** pAddress)
        {
            return VkPointers._vkGetMemoryRemoteAddressNV_fnptr(device, pMemoryGetRemoteAddressInfo, pAddress);
        }
        public static VkResult GetMemorySciBufNV(IntPtr device, VkMemoryGetSciBufInfoNV* pGetSciBufInfo, IntPtr* pHandle)
        {
            return VkPointers._vkGetMemorySciBufNV_fnptr(device, pGetSciBufInfo, pHandle);
        }
        public static VkResult GetPhysicalDeviceExternalMemorySciBufPropertiesNV(IntPtr physicalDevice, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, VkMemorySciBufPropertiesNV* pMemorySciBufProperties)
        {
            return VkPointers._vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_fnptr(physicalDevice, handleType, handle, pMemorySciBufProperties);
        }
        public static VkResult GetPhysicalDeviceSciBufAttributesNV(IntPtr physicalDevice, IntPtr pAttributes)
        {
            return VkPointers._vkGetPhysicalDeviceSciBufAttributesNV_fnptr(physicalDevice, pAttributes);
        }
        public static void GetPhysicalDeviceExternalSemaphoreProperties(IntPtr physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalSemaphoreProperties_fnptr(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
        }
        public static VkResult GetSemaphoreWin32HandleKHR(IntPtr device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            return VkPointers._vkGetSemaphoreWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        public static VkResult ImportSemaphoreWin32HandleKHR(IntPtr device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo)
        {
            return VkPointers._vkImportSemaphoreWin32HandleKHR_fnptr(device, pImportSemaphoreWin32HandleInfo);
        }
        public static VkResult GetSemaphoreFdKHR(IntPtr device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            return VkPointers._vkGetSemaphoreFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        public static VkResult ImportSemaphoreFdKHR(IntPtr device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo)
        {
            return VkPointers._vkImportSemaphoreFdKHR_fnptr(device, pImportSemaphoreFdInfo);
        }
        public static VkResult GetSemaphoreZirconHandleFUCHSIA(IntPtr device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, int* pZirconHandle)
        {
            return VkPointers._vkGetSemaphoreZirconHandleFUCHSIA_fnptr(device, pGetZirconHandleInfo, pZirconHandle);
        }
        public static VkResult ImportSemaphoreZirconHandleFUCHSIA(IntPtr device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo)
        {
            return VkPointers._vkImportSemaphoreZirconHandleFUCHSIA_fnptr(device, pImportSemaphoreZirconHandleInfo);
        }
        public static void GetPhysicalDeviceExternalFenceProperties(IntPtr physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalFenceProperties_fnptr(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
        }
        public static VkResult GetFenceWin32HandleKHR(IntPtr device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            return VkPointers._vkGetFenceWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        public static VkResult ImportFenceWin32HandleKHR(IntPtr device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
        {
            return VkPointers._vkImportFenceWin32HandleKHR_fnptr(device, pImportFenceWin32HandleInfo);
        }
        public static VkResult GetFenceFdKHR(IntPtr device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            return VkPointers._vkGetFenceFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        public static VkResult ImportFenceFdKHR(IntPtr device, VkImportFenceFdInfoKHR* pImportFenceFdInfo)
        {
            return VkPointers._vkImportFenceFdKHR_fnptr(device, pImportFenceFdInfo);
        }
        public static VkResult GetFenceSciSyncFenceNV(IntPtr device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle)
        {
            return VkPointers._vkGetFenceSciSyncFenceNV_fnptr(device, pGetSciSyncHandleInfo, pHandle);
        }
        public static VkResult GetFenceSciSyncObjNV(IntPtr device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle)
        {
            return VkPointers._vkGetFenceSciSyncObjNV_fnptr(device, pGetSciSyncHandleInfo, pHandle);
        }
        public static VkResult ImportFenceSciSyncFenceNV(IntPtr device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo)
        {
            return VkPointers._vkImportFenceSciSyncFenceNV_fnptr(device, pImportFenceSciSyncInfo);
        }
        public static VkResult ImportFenceSciSyncObjNV(IntPtr device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo)
        {
            return VkPointers._vkImportFenceSciSyncObjNV_fnptr(device, pImportFenceSciSyncInfo);
        }
        public static VkResult GetSemaphoreSciSyncObjNV(IntPtr device, VkSemaphoreGetSciSyncInfoNV* pGetSciSyncInfo, void* pHandle)
        {
            return VkPointers._vkGetSemaphoreSciSyncObjNV_fnptr(device, pGetSciSyncInfo, pHandle);
        }
        public static VkResult ImportSemaphoreSciSyncObjNV(IntPtr device, VkImportSemaphoreSciSyncInfoNV* pImportSemaphoreSciSyncInfo)
        {
            return VkPointers._vkImportSemaphoreSciSyncObjNV_fnptr(device, pImportSemaphoreSciSyncInfo);
        }
        public static VkResult GetPhysicalDeviceSciSyncAttributesNV(IntPtr physicalDevice, VkSciSyncAttributesInfoNV* pSciSyncAttributesInfo, IntPtr pAttributes)
        {
            return VkPointers._vkGetPhysicalDeviceSciSyncAttributesNV_fnptr(physicalDevice, pSciSyncAttributesInfo, pAttributes);
        }
        public static VkResult CreateSemaphoreSciSyncPoolNV(IntPtr device, VkSemaphoreSciSyncPoolCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSemaphorePool)
        {
            return VkPointers._vkCreateSemaphoreSciSyncPoolNV_fnptr(device, pCreateInfo, pAllocator, pSemaphorePool);
        }
        public static void DestroySemaphoreSciSyncPoolNV(IntPtr device, IntPtr semaphorePool, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySemaphoreSciSyncPoolNV_fnptr(device, semaphorePool, pAllocator);
        }
        public static VkResult ReleaseDisplayEXT(IntPtr physicalDevice, IntPtr display)
        {
            return VkPointers._vkReleaseDisplayEXT_fnptr(physicalDevice, display);
        }
        public static VkResult AcquireXlibDisplayEXT(IntPtr physicalDevice, IntPtr dpy, IntPtr display)
        {
            return VkPointers._vkAcquireXlibDisplayEXT_fnptr(physicalDevice, dpy, display);
        }
        public static VkResult GetRandROutputDisplayEXT(IntPtr physicalDevice, IntPtr dpy, nuint rrOutput, IntPtr* pDisplay)
        {
            return VkPointers._vkGetRandROutputDisplayEXT_fnptr(physicalDevice, dpy, rrOutput, pDisplay);
        }
        public static VkResult AcquireWinrtDisplayNV(IntPtr physicalDevice, IntPtr display)
        {
            return VkPointers._vkAcquireWinrtDisplayNV_fnptr(physicalDevice, display);
        }
        public static VkResult GetWinrtDisplayNV(IntPtr physicalDevice, uint deviceRelativeId, IntPtr* pDisplay)
        {
            return VkPointers._vkGetWinrtDisplayNV_fnptr(physicalDevice, deviceRelativeId, pDisplay);
        }
        public static VkResult DisplayPowerControlEXT(IntPtr device, IntPtr display, VkDisplayPowerInfoEXT* pDisplayPowerInfo)
        {
            return VkPointers._vkDisplayPowerControlEXT_fnptr(device, display, pDisplayPowerInfo);
        }
        public static VkResult RegisterDeviceEventEXT(IntPtr device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, IntPtr* pFence)
        {
            return VkPointers._vkRegisterDeviceEventEXT_fnptr(device, pDeviceEventInfo, pAllocator, pFence);
        }
        public static VkResult RegisterDisplayEventEXT(IntPtr device, IntPtr display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, IntPtr* pFence)
        {
            return VkPointers._vkRegisterDisplayEventEXT_fnptr(device, display, pDisplayEventInfo, pAllocator, pFence);
        }
        public static VkResult GetSwapchainCounterEXT(IntPtr device, IntPtr swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue)
        {
            return VkPointers._vkGetSwapchainCounterEXT_fnptr(device, swapchain, counter, pCounterValue);
        }
        public static VkResult GetPhysicalDeviceSurfaceCapabilities2EXT(IntPtr physicalDevice, IntPtr surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceCapabilities2EXT_fnptr(physicalDevice, surface, pSurfaceCapabilities);
        }
        public static VkResult EnumeratePhysicalDeviceGroups(IntPtr instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
        {
            return VkPointers._vkEnumeratePhysicalDeviceGroups_fnptr(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
        }
        public static void GetDeviceGroupPeerMemoryFeatures(IntPtr device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlagBits* pPeerMemoryFeatures)
        {
            VkPointers._vkGetDeviceGroupPeerMemoryFeatures_fnptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
        }
        public static VkResult BindBufferMemory2(IntPtr device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
        {
            return VkPointers._vkBindBufferMemory2_fnptr(device, bindInfoCount, pBindInfos);
        }
        public static VkResult BindImageMemory2(IntPtr device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
        {
            return VkPointers._vkBindImageMemory2_fnptr(device, bindInfoCount, pBindInfos);
        }
        public static void CmdSetDeviceMask(IntPtr commandBuffer, uint deviceMask)
        {
            VkPointers._vkCmdSetDeviceMask_fnptr(commandBuffer, deviceMask);
        }
        public static VkResult GetDeviceGroupPresentCapabilitiesKHR(IntPtr device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities)
        {
            return VkPointers._vkGetDeviceGroupPresentCapabilitiesKHR_fnptr(device, pDeviceGroupPresentCapabilities);
        }
        public static VkResult GetDeviceGroupSurfacePresentModesKHR(IntPtr device, IntPtr surface, VkDeviceGroupPresentModeFlagBitsKHR* pModes)
        {
            return VkPointers._vkGetDeviceGroupSurfacePresentModesKHR_fnptr(device, surface, pModes);
        }
        public static VkResult AcquireNextImage2KHR(IntPtr device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex)
        {
            return VkPointers._vkAcquireNextImage2KHR_fnptr(device, pAcquireInfo, pImageIndex);
        }
        public static void CmdDispatchBase(IntPtr commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDispatchBase_fnptr(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
        }
        public static VkResult GetPhysicalDevicePresentRectanglesKHR(IntPtr physicalDevice, IntPtr surface, uint* pRectCount, VkRect2D* pRects)
        {
            return VkPointers._vkGetPhysicalDevicePresentRectanglesKHR_fnptr(physicalDevice, surface, pRectCount, pRects);
        }
        public static VkResult CreateDescriptorUpdateTemplate(IntPtr device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pDescriptorUpdateTemplate)
        {
            return VkPointers._vkCreateDescriptorUpdateTemplate_fnptr(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
        }
        public static void DestroyDescriptorUpdateTemplate(IntPtr device, IntPtr descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDescriptorUpdateTemplate_fnptr(device, descriptorUpdateTemplate, pAllocator);
        }
        public static void UpdateDescriptorSetWithTemplate(IntPtr device, IntPtr descriptorSet, IntPtr descriptorUpdateTemplate, void* pData)
        {
            VkPointers._vkUpdateDescriptorSetWithTemplate_fnptr(device, descriptorSet, descriptorUpdateTemplate, pData);
        }
        public static void CmdPushDescriptorSetWithTemplateKHR(IntPtr commandBuffer, IntPtr descriptorUpdateTemplate, IntPtr layout, uint set, void* pData)
        {
            VkPointers._vkCmdPushDescriptorSetWithTemplateKHR_fnptr(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
        }
        public static void SetHdrMetadataEXT(IntPtr device, uint swapchainCount, IntPtr* pSwapchains, VkHdrMetadataEXT* pMetadata)
        {
            VkPointers._vkSetHdrMetadataEXT_fnptr(device, swapchainCount, pSwapchains, pMetadata);
        }
        public static VkResult GetSwapchainStatusKHR(IntPtr device, IntPtr swapchain)
        {
            return VkPointers._vkGetSwapchainStatusKHR_fnptr(device, swapchain);
        }
        public static VkResult GetRefreshCycleDurationGOOGLE(IntPtr device, IntPtr swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties)
        {
            return VkPointers._vkGetRefreshCycleDurationGOOGLE_fnptr(device, swapchain, pDisplayTimingProperties);
        }
        public static VkResult GetPastPresentationTimingGOOGLE(IntPtr device, IntPtr swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
        {
            return VkPointers._vkGetPastPresentationTimingGOOGLE_fnptr(device, swapchain, pPresentationTimingCount, pPresentationTimings);
        }
        public static VkResult CreateIOSSurfaceMVK(IntPtr instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateIOSSurfaceMVK_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult CreateMacOSSurfaceMVK(IntPtr instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateMacOSSurfaceMVK_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult CreateMetalSurfaceEXT(IntPtr instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateMetalSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static void CmdSetViewportWScalingNV(IntPtr commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
        {
            VkPointers._vkCmdSetViewportWScalingNV_fnptr(commandBuffer, firstViewport, viewportCount, pViewportWScalings);
        }
        public static void CmdSetDiscardRectangleEXT(IntPtr commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
        {
            VkPointers._vkCmdSetDiscardRectangleEXT_fnptr(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);
        }
        public static void CmdSetDiscardRectangleEnableEXT(IntPtr commandBuffer, int discardRectangleEnable)
        {
            VkPointers._vkCmdSetDiscardRectangleEnableEXT_fnptr(commandBuffer, discardRectangleEnable);
        }
        public static void CmdSetDiscardRectangleModeEXT(IntPtr commandBuffer, VkDiscardRectangleModeEXT discardRectangleMode)
        {
            VkPointers._vkCmdSetDiscardRectangleModeEXT_fnptr(commandBuffer, discardRectangleMode);
        }
        public static void CmdSetSampleLocationsEXT(IntPtr commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo)
        {
            VkPointers._vkCmdSetSampleLocationsEXT_fnptr(commandBuffer, pSampleLocationsInfo);
        }
        public static void GetPhysicalDeviceMultisamplePropertiesEXT(IntPtr physicalDevice, VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT* pMultisampleProperties)
        {
            VkPointers._vkGetPhysicalDeviceMultisamplePropertiesEXT_fnptr(physicalDevice, samples, pMultisampleProperties);
        }
        public static VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(IntPtr physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceCapabilities2KHR_fnptr(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);
        }
        public static VkResult GetPhysicalDeviceSurfaceFormats2KHR(IntPtr physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceFormats2KHR_fnptr(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);
        }
        public static VkResult GetPhysicalDeviceDisplayProperties2KHR(IntPtr physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceDisplayProperties2KHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static VkResult GetPhysicalDeviceDisplayPlaneProperties2KHR(IntPtr physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceDisplayPlaneProperties2KHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static VkResult GetDisplayModeProperties2KHR(IntPtr physicalDevice, IntPtr display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
        {
            return VkPointers._vkGetDisplayModeProperties2KHR_fnptr(physicalDevice, display, pPropertyCount, pProperties);
        }
        public static VkResult GetDisplayPlaneCapabilities2KHR(IntPtr physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
        {
            return VkPointers._vkGetDisplayPlaneCapabilities2KHR_fnptr(physicalDevice, pDisplayPlaneInfo, pCapabilities);
        }
        public static void GetBufferMemoryRequirements2(IntPtr device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetBufferMemoryRequirements2_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static void GetImageMemoryRequirements2(IntPtr device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetImageMemoryRequirements2_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static void GetImageSparseMemoryRequirements2(IntPtr device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            VkPointers._vkGetImageSparseMemoryRequirements2_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        public static void GetDeviceBufferMemoryRequirements(IntPtr device, VkDeviceBufferMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetDeviceBufferMemoryRequirements_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static void GetDeviceImageMemoryRequirements(IntPtr device, VkDeviceImageMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetDeviceImageMemoryRequirements_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static void GetDeviceImageSparseMemoryRequirements(IntPtr device, VkDeviceImageMemoryRequirements* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            VkPointers._vkGetDeviceImageSparseMemoryRequirements_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        public static VkResult CreateSamplerYcbcrConversion(IntPtr device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pYcbcrConversion)
        {
            return VkPointers._vkCreateSamplerYcbcrConversion_fnptr(device, pCreateInfo, pAllocator, pYcbcrConversion);
        }
        public static void DestroySamplerYcbcrConversion(IntPtr device, IntPtr ycbcrConversion, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySamplerYcbcrConversion_fnptr(device, ycbcrConversion, pAllocator);
        }
        public static void GetDeviceQueue2(IntPtr device, VkDeviceQueueInfo2* pQueueInfo, IntPtr* pQueue)
        {
            VkPointers._vkGetDeviceQueue2_fnptr(device, pQueueInfo, pQueue);
        }
        public static VkResult CreateValidationCacheEXT(IntPtr device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pValidationCache)
        {
            return VkPointers._vkCreateValidationCacheEXT_fnptr(device, pCreateInfo, pAllocator, pValidationCache);
        }
        public static void DestroyValidationCacheEXT(IntPtr device, IntPtr validationCache, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyValidationCacheEXT_fnptr(device, validationCache, pAllocator);
        }
        public static VkResult GetValidationCacheDataEXT(IntPtr device, IntPtr validationCache, nuint* pDataSize, void* pData)
        {
            return VkPointers._vkGetValidationCacheDataEXT_fnptr(device, validationCache, pDataSize, pData);
        }
        public static VkResult MergeValidationCachesEXT(IntPtr device, IntPtr dstCache, uint srcCacheCount, IntPtr* pSrcCaches)
        {
            return VkPointers._vkMergeValidationCachesEXT_fnptr(device, dstCache, srcCacheCount, pSrcCaches);
        }
        public static void GetDescriptorSetLayoutSupport(IntPtr device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
        {
            VkPointers._vkGetDescriptorSetLayoutSupport_fnptr(device, pCreateInfo, pSupport);
        }
        public static VkResult GetSwapchainGrallocUsageANDROID(IntPtr device, VkFormat format, VkImageUsageFlagBits imageUsage, int* grallocUsage)
        {
            return VkPointers._vkGetSwapchainGrallocUsageANDROID_fnptr(device, format, imageUsage, grallocUsage);
        }
        public static VkResult GetSwapchainGrallocUsage2ANDROID(IntPtr device, VkFormat format, VkImageUsageFlagBits imageUsage, VkSwapchainImageUsageFlagBitsANDROID swapchainImageUsage, ulong* grallocConsumerUsage, ulong* grallocProducerUsage)
        {
            return VkPointers._vkGetSwapchainGrallocUsage2ANDROID_fnptr(device, format, imageUsage, swapchainImageUsage, grallocConsumerUsage, grallocProducerUsage);
        }
        public static VkResult AcquireImageANDROID(IntPtr device, IntPtr image, int nativeFenceFd, IntPtr semaphore, IntPtr fence)
        {
            return VkPointers._vkAcquireImageANDROID_fnptr(device, image, nativeFenceFd, semaphore, fence);
        }
        public static VkResult QueueSignalReleaseImageANDROID(IntPtr queue, uint waitSemaphoreCount, IntPtr* pWaitSemaphores, IntPtr image, int* pNativeFenceFd)
        {
            return VkPointers._vkQueueSignalReleaseImageANDROID_fnptr(queue, waitSemaphoreCount, pWaitSemaphores, image, pNativeFenceFd);
        }
        public static VkResult GetShaderInfoAMD(IntPtr device, IntPtr pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, nuint* pInfoSize, void* pInfo)
        {
            return VkPointers._vkGetShaderInfoAMD_fnptr(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);
        }
        public static void SetLocalDimmingAMD(IntPtr device, IntPtr swapChain, int localDimmingEnable)
        {
            VkPointers._vkSetLocalDimmingAMD_fnptr(device, swapChain, localDimmingEnable);
        }
        public static VkResult GetPhysicalDeviceCalibrateableTimeDomainsKHR(IntPtr physicalDevice, uint* pTimeDomainCount, VkTimeDomainKHR* pTimeDomains)
        {
            return VkPointers._vkGetPhysicalDeviceCalibrateableTimeDomainsKHR_fnptr(physicalDevice, pTimeDomainCount, pTimeDomains);
        }
        public static VkResult GetCalibratedTimestampsKHR(IntPtr device, uint timestampCount, VkCalibratedTimestampInfoKHR* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
        {
            return VkPointers._vkGetCalibratedTimestampsKHR_fnptr(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);
        }
        public static VkResult SetDebugUtilsObjectNameEXT(IntPtr device, VkDebugUtilsObjectNameInfoEXT* pNameInfo)
        {
            return VkPointers._vkSetDebugUtilsObjectNameEXT_fnptr(device, pNameInfo);
        }
        public static VkResult SetDebugUtilsObjectTagEXT(IntPtr device, VkDebugUtilsObjectTagInfoEXT* pTagInfo)
        {
            return VkPointers._vkSetDebugUtilsObjectTagEXT_fnptr(device, pTagInfo);
        }
        public static void QueueBeginDebugUtilsLabelEXT(IntPtr queue, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            VkPointers._vkQueueBeginDebugUtilsLabelEXT_fnptr(queue, pLabelInfo);
        }
        public static void QueueEndDebugUtilsLabelEXT(IntPtr queue)
        {
            VkPointers._vkQueueEndDebugUtilsLabelEXT_fnptr(queue);
        }
        public static void QueueInsertDebugUtilsLabelEXT(IntPtr queue, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            VkPointers._vkQueueInsertDebugUtilsLabelEXT_fnptr(queue, pLabelInfo);
        }
        public static void CmdBeginDebugUtilsLabelEXT(IntPtr commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            VkPointers._vkCmdBeginDebugUtilsLabelEXT_fnptr(commandBuffer, pLabelInfo);
        }
        public static void CmdEndDebugUtilsLabelEXT(IntPtr commandBuffer)
        {
            VkPointers._vkCmdEndDebugUtilsLabelEXT_fnptr(commandBuffer);
        }
        public static void CmdInsertDebugUtilsLabelEXT(IntPtr commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            VkPointers._vkCmdInsertDebugUtilsLabelEXT_fnptr(commandBuffer, pLabelInfo);
        }
        public static VkResult CreateDebugUtilsMessengerEXT(IntPtr instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pMessenger)
        {
            return VkPointers._vkCreateDebugUtilsMessengerEXT_fnptr(instance, pCreateInfo, pAllocator, pMessenger);
        }
        public static void DestroyDebugUtilsMessengerEXT(IntPtr instance, IntPtr messenger, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDebugUtilsMessengerEXT_fnptr(instance, messenger, pAllocator);
        }
        public static void SubmitDebugUtilsMessageEXT(IntPtr instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagBitsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData)
        {
            VkPointers._vkSubmitDebugUtilsMessageEXT_fnptr(instance, messageSeverity, messageTypes, pCallbackData);
        }
        public static VkResult GetMemoryHostPointerPropertiesEXT(IntPtr device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties)
        {
            return VkPointers._vkGetMemoryHostPointerPropertiesEXT_fnptr(device, handleType, pHostPointer, pMemoryHostPointerProperties);
        }
        public static void CmdWriteBufferMarkerAMD(IntPtr commandBuffer, VkPipelineStageFlagBits pipelineStage, IntPtr dstBuffer, ulong dstOffset, uint marker)
        {
            VkPointers._vkCmdWriteBufferMarkerAMD_fnptr(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
        }
        public static VkResult CreateRenderPass2(IntPtr device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pRenderPass)
        {
            return VkPointers._vkCreateRenderPass2_fnptr(device, pCreateInfo, pAllocator, pRenderPass);
        }
        public static void CmdBeginRenderPass2(IntPtr commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo)
        {
            VkPointers._vkCmdBeginRenderPass2_fnptr(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
        }
        public static void CmdNextSubpass2(IntPtr commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo)
        {
            VkPointers._vkCmdNextSubpass2_fnptr(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
        }
        public static void CmdEndRenderPass2(IntPtr commandBuffer, VkSubpassEndInfo* pSubpassEndInfo)
        {
            VkPointers._vkCmdEndRenderPass2_fnptr(commandBuffer, pSubpassEndInfo);
        }
        public static VkResult GetSemaphoreCounterValue(IntPtr device, IntPtr semaphore, ulong* pValue)
        {
            return VkPointers._vkGetSemaphoreCounterValue_fnptr(device, semaphore, pValue);
        }
        public static VkResult WaitSemaphores(IntPtr device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
        {
            return VkPointers._vkWaitSemaphores_fnptr(device, pWaitInfo, timeout);
        }
        public static VkResult SignalSemaphore(IntPtr device, VkSemaphoreSignalInfo* pSignalInfo)
        {
            return VkPointers._vkSignalSemaphore_fnptr(device, pSignalInfo);
        }
        public static VkResult GetAndroidHardwareBufferPropertiesANDROID(IntPtr device, IntPtr buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
        {
            return VkPointers._vkGetAndroidHardwareBufferPropertiesANDROID_fnptr(device, buffer, pProperties);
        }
        public static VkResult GetMemoryAndroidHardwareBufferANDROID(IntPtr device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, IntPtr* pBuffer)
        {
            return VkPointers._vkGetMemoryAndroidHardwareBufferANDROID_fnptr(device, pInfo, pBuffer);
        }
        public static void CmdDrawIndirectCount(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndirectCount_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        public static void CmdDrawIndexedIndirectCount(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndexedIndirectCount_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        public static void CmdSetCheckpointNV(IntPtr commandBuffer, void* pCheckpointMarker)
        {
            VkPointers._vkCmdSetCheckpointNV_fnptr(commandBuffer, pCheckpointMarker);
        }
        public static void GetQueueCheckpointDataNV(IntPtr queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
        {
            VkPointers._vkGetQueueCheckpointDataNV_fnptr(queue, pCheckpointDataCount, pCheckpointData);
        }
        public static void CmdBindTransformFeedbackBuffersEXT(IntPtr commandBuffer, uint firstBinding, uint bindingCount, IntPtr* pBuffers, ulong* pOffsets, ulong* pSizes)
        {
            VkPointers._vkCmdBindTransformFeedbackBuffersEXT_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);
        }
        public static void CmdBeginTransformFeedbackEXT(IntPtr commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr* pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            VkPointers._vkCmdBeginTransformFeedbackEXT_fnptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
        }
        public static void CmdEndTransformFeedbackEXT(IntPtr commandBuffer, uint firstCounterBuffer, uint counterBufferCount, IntPtr* pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            VkPointers._vkCmdEndTransformFeedbackEXT_fnptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
        }
        public static void CmdBeginQueryIndexedEXT(IntPtr commandBuffer, IntPtr queryPool, uint query, VkQueryControlFlagBits flags, uint index)
        {
            VkPointers._vkCmdBeginQueryIndexedEXT_fnptr(commandBuffer, queryPool, query, flags, index);
        }
        public static void CmdEndQueryIndexedEXT(IntPtr commandBuffer, IntPtr queryPool, uint query, uint index)
        {
            VkPointers._vkCmdEndQueryIndexedEXT_fnptr(commandBuffer, queryPool, query, index);
        }
        public static void CmdDrawIndirectByteCountEXT(IntPtr commandBuffer, uint instanceCount, uint firstInstance, IntPtr counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
        {
            VkPointers._vkCmdDrawIndirectByteCountEXT_fnptr(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
        }
        public static void CmdSetExclusiveScissorNV(IntPtr commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
        {
            VkPointers._vkCmdSetExclusiveScissorNV_fnptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);
        }
        public static void CmdSetExclusiveScissorEnableNV(IntPtr commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, int* pExclusiveScissorEnables)
        {
            VkPointers._vkCmdSetExclusiveScissorEnableNV_fnptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissorEnables);
        }
        public static void CmdBindShadingRateImageNV(IntPtr commandBuffer, IntPtr imageView, VkImageLayout imageLayout)
        {
            VkPointers._vkCmdBindShadingRateImageNV_fnptr(commandBuffer, imageView, imageLayout);
        }
        public static void CmdSetViewportShadingRatePaletteNV(IntPtr commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
        {
            VkPointers._vkCmdSetViewportShadingRatePaletteNV_fnptr(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);
        }
        public static void CmdSetCoarseSampleOrderNV(IntPtr commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
        {
            VkPointers._vkCmdSetCoarseSampleOrderNV_fnptr(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
        }
        public static void CmdDrawMeshTasksNV(IntPtr commandBuffer, uint taskCount, uint firstTask)
        {
            VkPointers._vkCmdDrawMeshTasksNV_fnptr(commandBuffer, taskCount, firstTask);
        }
        public static void CmdDrawMeshTasksIndirectNV(IntPtr commandBuffer, IntPtr buffer, ulong offset, uint drawCount, uint stride)
        {
            VkPointers._vkCmdDrawMeshTasksIndirectNV_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        public static void CmdDrawMeshTasksIndirectCountNV(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawMeshTasksIndirectCountNV_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        public static void CmdDrawMeshTasksEXT(IntPtr commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDrawMeshTasksEXT_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        public static void CmdDrawMeshTasksIndirectEXT(IntPtr commandBuffer, IntPtr buffer, ulong offset, uint drawCount, uint stride)
        {
            VkPointers._vkCmdDrawMeshTasksIndirectEXT_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        public static void CmdDrawMeshTasksIndirectCountEXT(IntPtr commandBuffer, IntPtr buffer, ulong offset, IntPtr countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawMeshTasksIndirectCountEXT_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        public static VkResult CompileDeferredNV(IntPtr device, IntPtr pipeline, uint shader)
        {
            return VkPointers._vkCompileDeferredNV_fnptr(device, pipeline, shader);
        }
        public static VkResult CreateAccelerationStructureNV(IntPtr device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pAccelerationStructure)
        {
            return VkPointers._vkCreateAccelerationStructureNV_fnptr(device, pCreateInfo, pAllocator, pAccelerationStructure);
        }
        public static void CmdBindInvocationMaskHUAWEI(IntPtr commandBuffer, IntPtr imageView, VkImageLayout imageLayout)
        {
            VkPointers._vkCmdBindInvocationMaskHUAWEI_fnptr(commandBuffer, imageView, imageLayout);
        }
        public static void DestroyAccelerationStructureKHR(IntPtr device, IntPtr accelerationStructure, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyAccelerationStructureKHR_fnptr(device, accelerationStructure, pAllocator);
        }
        public static void DestroyAccelerationStructureNV(IntPtr device, IntPtr accelerationStructure, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyAccelerationStructureNV_fnptr(device, accelerationStructure, pAllocator);
        }
        public static void GetAccelerationStructureMemoryRequirementsNV(IntPtr device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2KHR* pMemoryRequirements)
        {
            VkPointers._vkGetAccelerationStructureMemoryRequirementsNV_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static VkResult BindAccelerationStructureMemoryNV(IntPtr device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
        {
            return VkPointers._vkBindAccelerationStructureMemoryNV_fnptr(device, bindInfoCount, pBindInfos);
        }
        public static void CmdCopyAccelerationStructureNV(IntPtr commandBuffer, IntPtr dst, IntPtr src, VkCopyAccelerationStructureModeKHR mode)
        {
            VkPointers._vkCmdCopyAccelerationStructureNV_fnptr(commandBuffer, dst, src, mode);
        }
        public static void CmdCopyAccelerationStructureKHR(IntPtr commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo)
        {
            VkPointers._vkCmdCopyAccelerationStructureKHR_fnptr(commandBuffer, pInfo);
        }
        public static VkResult CopyAccelerationStructureKHR(IntPtr device, IntPtr deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo)
        {
            return VkPointers._vkCopyAccelerationStructureKHR_fnptr(device, deferredOperation, pInfo);
        }
        public static void CmdCopyAccelerationStructureToMemoryKHR(IntPtr commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
        {
            VkPointers._vkCmdCopyAccelerationStructureToMemoryKHR_fnptr(commandBuffer, pInfo);
        }
        public static VkResult CopyAccelerationStructureToMemoryKHR(IntPtr device, IntPtr deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
        {
            return VkPointers._vkCopyAccelerationStructureToMemoryKHR_fnptr(device, deferredOperation, pInfo);
        }
        public static void CmdCopyMemoryToAccelerationStructureKHR(IntPtr commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
        {
            VkPointers._vkCmdCopyMemoryToAccelerationStructureKHR_fnptr(commandBuffer, pInfo);
        }
        public static VkResult CopyMemoryToAccelerationStructureKHR(IntPtr device, IntPtr deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
        {
            return VkPointers._vkCopyMemoryToAccelerationStructureKHR_fnptr(device, deferredOperation, pInfo);
        }
        public static void CmdWriteAccelerationStructuresPropertiesKHR(IntPtr commandBuffer, uint accelerationStructureCount, IntPtr* pAccelerationStructures, VkQueryType queryType, IntPtr queryPool, uint firstQuery)
        {
            VkPointers._vkCmdWriteAccelerationStructuresPropertiesKHR_fnptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
        public static void CmdWriteAccelerationStructuresPropertiesNV(IntPtr commandBuffer, uint accelerationStructureCount, IntPtr* pAccelerationStructures, VkQueryType queryType, IntPtr queryPool, uint firstQuery)
        {
            VkPointers._vkCmdWriteAccelerationStructuresPropertiesNV_fnptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
        public static void CmdBuildAccelerationStructureNV(IntPtr commandBuffer, VkAccelerationStructureInfoNV* pInfo, IntPtr instanceData, ulong instanceOffset, int update, IntPtr dst, IntPtr src, IntPtr scratch, ulong scratchOffset)
        {
            VkPointers._vkCmdBuildAccelerationStructureNV_fnptr(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
        }
        public static VkResult WriteAccelerationStructuresPropertiesKHR(IntPtr device, uint accelerationStructureCount, IntPtr* pAccelerationStructures, VkQueryType queryType, nuint dataSize, void* pData, nuint stride)
        {
            return VkPointers._vkWriteAccelerationStructuresPropertiesKHR_fnptr(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);
        }
        public static void CmdTraceRaysKHR(IntPtr commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            VkPointers._vkCmdTraceRaysKHR_fnptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }
        public static void CmdTraceRaysNV(IntPtr commandBuffer, IntPtr raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, IntPtr missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, IntPtr hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, IntPtr callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
        {
            VkPointers._vkCmdTraceRaysNV_fnptr(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
        }
        public static VkResult GetRayTracingShaderGroupHandlesKHR(IntPtr device, IntPtr pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
        {
            return VkPointers._vkGetRayTracingShaderGroupHandlesKHR_fnptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        public static VkResult GetRayTracingCaptureReplayShaderGroupHandlesKHR(IntPtr device, IntPtr pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
        {
            return VkPointers._vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_fnptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        public static VkResult GetAccelerationStructureHandleNV(IntPtr device, IntPtr accelerationStructure, nuint dataSize, void* pData)
        {
            return VkPointers._vkGetAccelerationStructureHandleNV_fnptr(device, accelerationStructure, dataSize, pData);
        }
        public static VkResult CreateRayTracingPipelinesNV(IntPtr device, IntPtr pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, IntPtr* pPipelines)
        {
            return VkPointers._vkCreateRayTracingPipelinesNV_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static VkResult CreateRayTracingPipelinesKHR(IntPtr device, IntPtr deferredOperation, IntPtr pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, IntPtr* pPipelines)
        {
            return VkPointers._vkCreateRayTracingPipelinesKHR_fnptr(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNV(IntPtr physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static void CmdTraceRaysIndirectKHR(IntPtr commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            VkPointers._vkCmdTraceRaysIndirectKHR_fnptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
        }
        public static void CmdTraceRaysIndirect2KHR(IntPtr commandBuffer, ulong indirectDeviceAddress)
        {
            VkPointers._vkCmdTraceRaysIndirect2KHR_fnptr(commandBuffer, indirectDeviceAddress);
        }
        public static void GetDeviceAccelerationStructureCompatibilityKHR(IntPtr device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            VkPointers._vkGetDeviceAccelerationStructureCompatibilityKHR_fnptr(device, pVersionInfo, pCompatibility);
        }
        public static ulong GetRayTracingShaderGroupStackSizeKHR(IntPtr device, IntPtr pipeline, uint group, VkShaderGroupShaderKHR groupShader)
        {
            return VkPointers._vkGetRayTracingShaderGroupStackSizeKHR_fnptr(device, pipeline, group, groupShader);
        }
        public static void CmdSetRayTracingPipelineStackSizeKHR(IntPtr commandBuffer, uint pipelineStackSize)
        {
            VkPointers._vkCmdSetRayTracingPipelineStackSizeKHR_fnptr(commandBuffer, pipelineStackSize);
        }
        public static uint GetImageViewHandleNVX(IntPtr device, VkImageViewHandleInfoNVX* pInfo)
        {
            return VkPointers._vkGetImageViewHandleNVX_fnptr(device, pInfo);
        }
        public static VkResult GetImageViewAddressNVX(IntPtr device, IntPtr imageView, VkImageViewAddressPropertiesNVX* pProperties)
        {
            return VkPointers._vkGetImageViewAddressNVX_fnptr(device, imageView, pProperties);
        }
        public static VkResult GetPhysicalDeviceSurfacePresentModes2EXT(IntPtr physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            return VkPointers._vkGetPhysicalDeviceSurfacePresentModes2EXT_fnptr(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);
        }
        public static VkResult GetDeviceGroupSurfacePresentModes2EXT(IntPtr device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagBitsKHR* pModes)
        {
            return VkPointers._vkGetDeviceGroupSurfacePresentModes2EXT_fnptr(device, pSurfaceInfo, pModes);
        }
        public static VkResult AcquireFullScreenExclusiveModeEXT(IntPtr device, IntPtr swapchain)
        {
            return VkPointers._vkAcquireFullScreenExclusiveModeEXT_fnptr(device, swapchain);
        }
        public static VkResult ReleaseFullScreenExclusiveModeEXT(IntPtr device, IntPtr swapchain)
        {
            return VkPointers._vkReleaseFullScreenExclusiveModeEXT_fnptr(device, swapchain);
        }
        public static VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(IntPtr physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            return VkPointers._vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_fnptr(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);
        }
        public static void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(IntPtr physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses)
        {
            VkPointers._vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_fnptr(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);
        }
        public static VkResult AcquireProfilingLockKHR(IntPtr device, VkAcquireProfilingLockInfoKHR* pInfo)
        {
            return VkPointers._vkAcquireProfilingLockKHR_fnptr(device, pInfo);
        }
        public static void ReleaseProfilingLockKHR(IntPtr device)
        {
            VkPointers._vkReleaseProfilingLockKHR_fnptr(device);
        }
        public static VkResult GetImageDrmFormatModifierPropertiesEXT(IntPtr device, IntPtr image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
        {
            return VkPointers._vkGetImageDrmFormatModifierPropertiesEXT_fnptr(device, image, pProperties);
        }
        public static ulong GetBufferOpaqueCaptureAddress(IntPtr device, VkBufferDeviceAddressInfo* pInfo)
        {
            return VkPointers._vkGetBufferOpaqueCaptureAddress_fnptr(device, pInfo);
        }
        public static ulong GetBufferDeviceAddress(IntPtr device, VkBufferDeviceAddressInfo* pInfo)
        {
            return VkPointers._vkGetBufferDeviceAddress_fnptr(device, pInfo);
        }
        public static VkResult CreateHeadlessSurfaceEXT(IntPtr instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSurface)
        {
            return VkPointers._vkCreateHeadlessSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(IntPtr physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
        {
            return VkPointers._vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_fnptr(physicalDevice, pCombinationCount, pCombinations);
        }
        public static VkResult InitializePerformanceApiINTEL(IntPtr device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo)
        {
            return VkPointers._vkInitializePerformanceApiINTEL_fnptr(device, pInitializeInfo);
        }
        public static void UninitializePerformanceApiINTEL(IntPtr device)
        {
            VkPointers._vkUninitializePerformanceApiINTEL_fnptr(device);
        }
        public static VkResult CmdSetPerformanceMarkerINTEL(IntPtr commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo)
        {
            return VkPointers._vkCmdSetPerformanceMarkerINTEL_fnptr(commandBuffer, pMarkerInfo);
        }
        public static VkResult CmdSetPerformanceStreamMarkerINTEL(IntPtr commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo)
        {
            return VkPointers._vkCmdSetPerformanceStreamMarkerINTEL_fnptr(commandBuffer, pMarkerInfo);
        }
        public static VkResult CmdSetPerformanceOverrideINTEL(IntPtr commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo)
        {
            return VkPointers._vkCmdSetPerformanceOverrideINTEL_fnptr(commandBuffer, pOverrideInfo);
        }
        public static VkResult AcquirePerformanceConfigurationINTEL(IntPtr device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, IntPtr* pConfiguration)
        {
            return VkPointers._vkAcquirePerformanceConfigurationINTEL_fnptr(device, pAcquireInfo, pConfiguration);
        }
        public static VkResult ReleasePerformanceConfigurationINTEL(IntPtr device, IntPtr configuration)
        {
            return VkPointers._vkReleasePerformanceConfigurationINTEL_fnptr(device, configuration);
        }
        public static VkResult QueueSetPerformanceConfigurationINTEL(IntPtr queue, IntPtr configuration)
        {
            return VkPointers._vkQueueSetPerformanceConfigurationINTEL_fnptr(queue, configuration);
        }
        public static VkResult GetPerformanceParameterINTEL(IntPtr device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
        {
            return VkPointers._vkGetPerformanceParameterINTEL_fnptr(device, parameter, pValue);
        }
        public static ulong GetDeviceMemoryOpaqueCaptureAddress(IntPtr device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
        {
            return VkPointers._vkGetDeviceMemoryOpaqueCaptureAddress_fnptr(device, pInfo);
        }
        public static VkResult GetPipelineExecutablePropertiesKHR(IntPtr device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            return VkPointers._vkGetPipelineExecutablePropertiesKHR_fnptr(device, pPipelineInfo, pExecutableCount, pProperties);
        }
        public static VkResult GetPipelineExecutableStatisticsKHR(IntPtr device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            return VkPointers._vkGetPipelineExecutableStatisticsKHR_fnptr(device, pExecutableInfo, pStatisticCount, pStatistics);
        }
        public static VkResult GetPipelineExecutableInternalRepresentationsKHR(IntPtr device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            return VkPointers._vkGetPipelineExecutableInternalRepresentationsKHR_fnptr(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);
        }
        public static void CmdSetLineStippleKHR(IntPtr commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
        {
            VkPointers._vkCmdSetLineStippleKHR_fnptr(commandBuffer, lineStippleFactor, lineStipplePattern);
        }
        public static VkResult GetFaultData(IntPtr device, VkFaultQueryBehavior faultQueryBehavior, int* pUnrecordedFaults, uint* pFaultCount, VkFaultData* pFaults)
        {
            return VkPointers._vkGetFaultData_fnptr(device, faultQueryBehavior, pUnrecordedFaults, pFaultCount, pFaults);
        }
        public static VkResult GetPhysicalDeviceToolProperties(IntPtr physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
        {
            return VkPointers._vkGetPhysicalDeviceToolProperties_fnptr(physicalDevice, pToolCount, pToolProperties);
        }
        public static VkResult CreateAccelerationStructureKHR(IntPtr device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pAccelerationStructure)
        {
            return VkPointers._vkCreateAccelerationStructureKHR_fnptr(device, pCreateInfo, pAllocator, pAccelerationStructure);
        }
        public static void CmdBuildAccelerationStructuresKHR(IntPtr commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            VkPointers._vkCmdBuildAccelerationStructuresKHR_fnptr(commandBuffer, infoCount, pInfos, ppBuildRangeInfos);
        }
        public static void CmdBuildAccelerationStructuresIndirectKHR(IntPtr commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            VkPointers._vkCmdBuildAccelerationStructuresIndirectKHR_fnptr(commandBuffer, infoCount, pInfos, pIndirectDeviceAddresses, pIndirectStrides, ppMaxPrimitiveCounts);
        }
        public static VkResult BuildAccelerationStructuresKHR(IntPtr device, IntPtr deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            return VkPointers._vkBuildAccelerationStructuresKHR_fnptr(device, deferredOperation, infoCount, pInfos, ppBuildRangeInfos);
        }
        public static ulong GetAccelerationStructureDeviceAddressKHR(IntPtr device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo)
        {
            return VkPointers._vkGetAccelerationStructureDeviceAddressKHR_fnptr(device, pInfo);
        }
        public static VkResult CreateDeferredOperationKHR(IntPtr device, VkAllocationCallbacks* pAllocator, IntPtr* pDeferredOperation)
        {
            return VkPointers._vkCreateDeferredOperationKHR_fnptr(device, pAllocator, pDeferredOperation);
        }
        public static void DestroyDeferredOperationKHR(IntPtr device, IntPtr operation, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDeferredOperationKHR_fnptr(device, operation, pAllocator);
        }
        public static uint GetDeferredOperationMaxConcurrencyKHR(IntPtr device, IntPtr operation)
        {
            return VkPointers._vkGetDeferredOperationMaxConcurrencyKHR_fnptr(device, operation);
        }
        public static VkResult GetDeferredOperationResultKHR(IntPtr device, IntPtr operation)
        {
            return VkPointers._vkGetDeferredOperationResultKHR_fnptr(device, operation);
        }
        public static VkResult DeferredOperationJoinKHR(IntPtr device, IntPtr operation)
        {
            return VkPointers._vkDeferredOperationJoinKHR_fnptr(device, operation);
        }
        public static void GetPipelineIndirectMemoryRequirementsNV(IntPtr device, VkComputePipelineCreateInfo* pCreateInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetPipelineIndirectMemoryRequirementsNV_fnptr(device, pCreateInfo, pMemoryRequirements);
        }
        public static ulong GetPipelineIndirectDeviceAddressNV(IntPtr device, VkPipelineIndirectDeviceAddressInfoNV* pInfo)
        {
            return VkPointers._vkGetPipelineIndirectDeviceAddressNV_fnptr(device, pInfo);
        }
        public static void CmdSetCullMode(IntPtr commandBuffer, VkCullModeFlagBits cullMode)
        {
            VkPointers._vkCmdSetCullMode_fnptr(commandBuffer, cullMode);
        }
        public static void CmdSetFrontFace(IntPtr commandBuffer, VkFrontFace frontFace)
        {
            VkPointers._vkCmdSetFrontFace_fnptr(commandBuffer, frontFace);
        }
        public static void CmdSetPrimitiveTopology(IntPtr commandBuffer, VkPrimitiveTopology primitiveTopology)
        {
            VkPointers._vkCmdSetPrimitiveTopology_fnptr(commandBuffer, primitiveTopology);
        }
        public static void CmdSetViewportWithCount(IntPtr commandBuffer, uint viewportCount, VkViewport* pViewports)
        {
            VkPointers._vkCmdSetViewportWithCount_fnptr(commandBuffer, viewportCount, pViewports);
        }
        public static void CmdSetScissorWithCount(IntPtr commandBuffer, uint scissorCount, VkRect2D* pScissors)
        {
            VkPointers._vkCmdSetScissorWithCount_fnptr(commandBuffer, scissorCount, pScissors);
        }
        public static void CmdBindIndexBuffer2KHR(IntPtr commandBuffer, IntPtr buffer, ulong offset, ulong size, VkIndexType indexType)
        {
            VkPointers._vkCmdBindIndexBuffer2KHR_fnptr(commandBuffer, buffer, offset, size, indexType);
        }
        public static void CmdBindVertexBuffers2(IntPtr commandBuffer, uint firstBinding, uint bindingCount, IntPtr* pBuffers, ulong* pOffsets, ulong* pSizes, ulong* pStrides)
        {
            VkPointers._vkCmdBindVertexBuffers2_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
        }
        public static void CmdSetDepthTestEnable(IntPtr commandBuffer, int depthTestEnable)
        {
            VkPointers._vkCmdSetDepthTestEnable_fnptr(commandBuffer, depthTestEnable);
        }
        public static void CmdSetDepthWriteEnable(IntPtr commandBuffer, int depthWriteEnable)
        {
            VkPointers._vkCmdSetDepthWriteEnable_fnptr(commandBuffer, depthWriteEnable);
        }
        public static void CmdSetDepthCompareOp(IntPtr commandBuffer, VkCompareOp depthCompareOp)
        {
            VkPointers._vkCmdSetDepthCompareOp_fnptr(commandBuffer, depthCompareOp);
        }
        public static void CmdSetDepthBoundsTestEnable(IntPtr commandBuffer, int depthBoundsTestEnable)
        {
            VkPointers._vkCmdSetDepthBoundsTestEnable_fnptr(commandBuffer, depthBoundsTestEnable);
        }
        public static void CmdSetStencilTestEnable(IntPtr commandBuffer, int stencilTestEnable)
        {
            VkPointers._vkCmdSetStencilTestEnable_fnptr(commandBuffer, stencilTestEnable);
        }
        public static void CmdSetStencilOp(IntPtr commandBuffer, VkStencilFaceFlagBits faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
        {
            VkPointers._vkCmdSetStencilOp_fnptr(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
        }
        public static void CmdSetPatchControlPointsEXT(IntPtr commandBuffer, uint patchControlPoints)
        {
            VkPointers._vkCmdSetPatchControlPointsEXT_fnptr(commandBuffer, patchControlPoints);
        }
        public static void CmdSetRasterizerDiscardEnable(IntPtr commandBuffer, int rasterizerDiscardEnable)
        {
            VkPointers._vkCmdSetRasterizerDiscardEnable_fnptr(commandBuffer, rasterizerDiscardEnable);
        }
        public static void CmdSetDepthBiasEnable(IntPtr commandBuffer, int depthBiasEnable)
        {
            VkPointers._vkCmdSetDepthBiasEnable_fnptr(commandBuffer, depthBiasEnable);
        }
        public static void CmdSetLogicOpEXT(IntPtr commandBuffer, VkLogicOp logicOp)
        {
            VkPointers._vkCmdSetLogicOpEXT_fnptr(commandBuffer, logicOp);
        }
        public static void CmdSetPrimitiveRestartEnable(IntPtr commandBuffer, int primitiveRestartEnable)
        {
            VkPointers._vkCmdSetPrimitiveRestartEnable_fnptr(commandBuffer, primitiveRestartEnable);
        }
        public static void CmdSetTessellationDomainOriginEXT(IntPtr commandBuffer, VkTessellationDomainOrigin domainOrigin)
        {
            VkPointers._vkCmdSetTessellationDomainOriginEXT_fnptr(commandBuffer, domainOrigin);
        }
        public static void CmdSetDepthClampEnableEXT(IntPtr commandBuffer, int depthClampEnable)
        {
            VkPointers._vkCmdSetDepthClampEnableEXT_fnptr(commandBuffer, depthClampEnable);
        }
        public static void CmdSetPolygonModeEXT(IntPtr commandBuffer, VkPolygonMode polygonMode)
        {
            VkPointers._vkCmdSetPolygonModeEXT_fnptr(commandBuffer, polygonMode);
        }
        public static void CmdSetRasterizationSamplesEXT(IntPtr commandBuffer, VkSampleCountFlagBits rasterizationSamples)
        {
            VkPointers._vkCmdSetRasterizationSamplesEXT_fnptr(commandBuffer, rasterizationSamples);
        }
        public static void CmdSetSampleMaskEXT(IntPtr commandBuffer, VkSampleCountFlagBits samples, uint* pSampleMask)
        {
            VkPointers._vkCmdSetSampleMaskEXT_fnptr(commandBuffer, samples, pSampleMask);
        }
        public static void CmdSetAlphaToCoverageEnableEXT(IntPtr commandBuffer, int alphaToCoverageEnable)
        {
            VkPointers._vkCmdSetAlphaToCoverageEnableEXT_fnptr(commandBuffer, alphaToCoverageEnable);
        }
        public static void CmdSetAlphaToOneEnableEXT(IntPtr commandBuffer, int alphaToOneEnable)
        {
            VkPointers._vkCmdSetAlphaToOneEnableEXT_fnptr(commandBuffer, alphaToOneEnable);
        }
        public static void CmdSetLogicOpEnableEXT(IntPtr commandBuffer, int logicOpEnable)
        {
            VkPointers._vkCmdSetLogicOpEnableEXT_fnptr(commandBuffer, logicOpEnable);
        }
        public static void CmdSetColorBlendEnableEXT(IntPtr commandBuffer, uint firstAttachment, uint attachmentCount, int* pColorBlendEnables)
        {
            VkPointers._vkCmdSetColorBlendEnableEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEnables);
        }
        public static void CmdSetColorBlendEquationEXT(IntPtr commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendEquationEXT* pColorBlendEquations)
        {
            VkPointers._vkCmdSetColorBlendEquationEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEquations);
        }
        public static void CmdSetColorWriteMaskEXT(IntPtr commandBuffer, uint firstAttachment, uint attachmentCount, VkColorComponentFlagBits* pColorWriteMasks)
        {
            VkPointers._vkCmdSetColorWriteMaskEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorWriteMasks);
        }
        public static void CmdSetRasterizationStreamEXT(IntPtr commandBuffer, uint rasterizationStream)
        {
            VkPointers._vkCmdSetRasterizationStreamEXT_fnptr(commandBuffer, rasterizationStream);
        }
        public static void CmdSetConservativeRasterizationModeEXT(IntPtr commandBuffer, VkConservativeRasterizationModeEXT conservativeRasterizationMode)
        {
            VkPointers._vkCmdSetConservativeRasterizationModeEXT_fnptr(commandBuffer, conservativeRasterizationMode);
        }
        public static void CmdSetExtraPrimitiveOverestimationSizeEXT(IntPtr commandBuffer, float extraPrimitiveOverestimationSize)
        {
            VkPointers._vkCmdSetExtraPrimitiveOverestimationSizeEXT_fnptr(commandBuffer, extraPrimitiveOverestimationSize);
        }
        public static void CmdSetDepthClipEnableEXT(IntPtr commandBuffer, int depthClipEnable)
        {
            VkPointers._vkCmdSetDepthClipEnableEXT_fnptr(commandBuffer, depthClipEnable);
        }
        public static void CmdSetSampleLocationsEnableEXT(IntPtr commandBuffer, int sampleLocationsEnable)
        {
            VkPointers._vkCmdSetSampleLocationsEnableEXT_fnptr(commandBuffer, sampleLocationsEnable);
        }
        public static void CmdSetColorBlendAdvancedEXT(IntPtr commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendAdvancedEXT* pColorBlendAdvanced)
        {
            VkPointers._vkCmdSetColorBlendAdvancedEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendAdvanced);
        }
        public static void CmdSetProvokingVertexModeEXT(IntPtr commandBuffer, VkProvokingVertexModeEXT provokingVertexMode)
        {
            VkPointers._vkCmdSetProvokingVertexModeEXT_fnptr(commandBuffer, provokingVertexMode);
        }
        public static void CmdSetLineRasterizationModeEXT(IntPtr commandBuffer, VkLineRasterizationModeKHR lineRasterizationMode)
        {
            VkPointers._vkCmdSetLineRasterizationModeEXT_fnptr(commandBuffer, lineRasterizationMode);
        }
        public static void CmdSetLineStippleEnableEXT(IntPtr commandBuffer, int stippledLineEnable)
        {
            VkPointers._vkCmdSetLineStippleEnableEXT_fnptr(commandBuffer, stippledLineEnable);
        }
        public static void CmdSetDepthClipNegativeOneToOneEXT(IntPtr commandBuffer, int negativeOneToOne)
        {
            VkPointers._vkCmdSetDepthClipNegativeOneToOneEXT_fnptr(commandBuffer, negativeOneToOne);
        }
        public static void CmdSetViewportWScalingEnableNV(IntPtr commandBuffer, int viewportWScalingEnable)
        {
            VkPointers._vkCmdSetViewportWScalingEnableNV_fnptr(commandBuffer, viewportWScalingEnable);
        }
        public static void CmdSetViewportSwizzleNV(IntPtr commandBuffer, uint firstViewport, uint viewportCount, VkViewportSwizzleNV* pViewportSwizzles)
        {
            VkPointers._vkCmdSetViewportSwizzleNV_fnptr(commandBuffer, firstViewport, viewportCount, pViewportSwizzles);
        }
        public static void CmdSetCoverageToColorEnableNV(IntPtr commandBuffer, int coverageToColorEnable)
        {
            VkPointers._vkCmdSetCoverageToColorEnableNV_fnptr(commandBuffer, coverageToColorEnable);
        }
        public static void CmdSetCoverageToColorLocationNV(IntPtr commandBuffer, uint coverageToColorLocation)
        {
            VkPointers._vkCmdSetCoverageToColorLocationNV_fnptr(commandBuffer, coverageToColorLocation);
        }
        public static void CmdSetCoverageModulationModeNV(IntPtr commandBuffer, VkCoverageModulationModeNV coverageModulationMode)
        {
            VkPointers._vkCmdSetCoverageModulationModeNV_fnptr(commandBuffer, coverageModulationMode);
        }
        public static void CmdSetCoverageModulationTableEnableNV(IntPtr commandBuffer, int coverageModulationTableEnable)
        {
            VkPointers._vkCmdSetCoverageModulationTableEnableNV_fnptr(commandBuffer, coverageModulationTableEnable);
        }
        public static void CmdSetCoverageModulationTableNV(IntPtr commandBuffer, uint coverageModulationTableCount, float* pCoverageModulationTable)
        {
            VkPointers._vkCmdSetCoverageModulationTableNV_fnptr(commandBuffer, coverageModulationTableCount, pCoverageModulationTable);
        }
        public static void CmdSetShadingRateImageEnableNV(IntPtr commandBuffer, int shadingRateImageEnable)
        {
            VkPointers._vkCmdSetShadingRateImageEnableNV_fnptr(commandBuffer, shadingRateImageEnable);
        }
        public static void CmdSetCoverageReductionModeNV(IntPtr commandBuffer, VkCoverageReductionModeNV coverageReductionMode)
        {
            VkPointers._vkCmdSetCoverageReductionModeNV_fnptr(commandBuffer, coverageReductionMode);
        }
        public static void CmdSetRepresentativeFragmentTestEnableNV(IntPtr commandBuffer, int representativeFragmentTestEnable)
        {
            VkPointers._vkCmdSetRepresentativeFragmentTestEnableNV_fnptr(commandBuffer, representativeFragmentTestEnable);
        }
        public static VkResult CreatePrivateDataSlot(IntPtr device, VkPrivateDataSlotCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pPrivateDataSlot)
        {
            return VkPointers._vkCreatePrivateDataSlot_fnptr(device, pCreateInfo, pAllocator, pPrivateDataSlot);
        }
        public static void DestroyPrivateDataSlot(IntPtr device, IntPtr privateDataSlot, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPrivateDataSlot_fnptr(device, privateDataSlot, pAllocator);
        }
        public static VkResult SetPrivateData(IntPtr device, VkObjectType objectType, ulong objectHandle, IntPtr privateDataSlot, ulong data)
        {
            return VkPointers._vkSetPrivateData_fnptr(device, objectType, objectHandle, privateDataSlot, data);
        }
        public static void GetPrivateData(IntPtr device, VkObjectType objectType, ulong objectHandle, IntPtr privateDataSlot, ulong* pData)
        {
            VkPointers._vkGetPrivateData_fnptr(device, objectType, objectHandle, privateDataSlot, pData);
        }
        public static void CmdCopyBuffer2(IntPtr commandBuffer, VkCopyBufferInfo2* pCopyBufferInfo)
        {
            VkPointers._vkCmdCopyBuffer2_fnptr(commandBuffer, pCopyBufferInfo);
        }
        public static void CmdCopyImage2(IntPtr commandBuffer, VkCopyImageInfo2* pCopyImageInfo)
        {
            VkPointers._vkCmdCopyImage2_fnptr(commandBuffer, pCopyImageInfo);
        }
        public static void CmdBlitImage2(IntPtr commandBuffer, VkBlitImageInfo2* pBlitImageInfo)
        {
            VkPointers._vkCmdBlitImage2_fnptr(commandBuffer, pBlitImageInfo);
        }
        public static void CmdCopyBufferToImage2(IntPtr commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
        {
            VkPointers._vkCmdCopyBufferToImage2_fnptr(commandBuffer, pCopyBufferToImageInfo);
        }
        public static void CmdCopyImageToBuffer2(IntPtr commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
        {
            VkPointers._vkCmdCopyImageToBuffer2_fnptr(commandBuffer, pCopyImageToBufferInfo);
        }
        public static void CmdResolveImage2(IntPtr commandBuffer, VkResolveImageInfo2* pResolveImageInfo)
        {
            VkPointers._vkCmdResolveImage2_fnptr(commandBuffer, pResolveImageInfo);
        }
        public static void CmdRefreshObjectsKHR(IntPtr commandBuffer, VkRefreshObjectListKHR* pRefreshObjects)
        {
            VkPointers._vkCmdRefreshObjectsKHR_fnptr(commandBuffer, pRefreshObjects);
        }
        public static VkResult GetPhysicalDeviceRefreshableObjectTypesKHR(IntPtr physicalDevice, uint* pRefreshableObjectTypeCount, VkObjectType* pRefreshableObjectTypes)
        {
            return VkPointers._vkGetPhysicalDeviceRefreshableObjectTypesKHR_fnptr(physicalDevice, pRefreshableObjectTypeCount, pRefreshableObjectTypes);
        }
        public static void CmdSetFragmentShadingRateKHR(IntPtr commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR* combinerOps)
        {
            VkPointers._vkCmdSetFragmentShadingRateKHR_fnptr(commandBuffer, pFragmentSize, combinerOps);
        }
        public static VkResult GetPhysicalDeviceFragmentShadingRatesKHR(IntPtr physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
        {
            return VkPointers._vkGetPhysicalDeviceFragmentShadingRatesKHR_fnptr(physicalDevice, pFragmentShadingRateCount, pFragmentShadingRates);
        }
        public static void CmdSetFragmentShadingRateEnumNV(IntPtr commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR* combinerOps)
        {
            VkPointers._vkCmdSetFragmentShadingRateEnumNV_fnptr(commandBuffer, shadingRate, combinerOps);
        }
        public static void GetAccelerationStructureBuildSizesKHR(IntPtr device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            VkPointers._vkGetAccelerationStructureBuildSizesKHR_fnptr(device, buildType, pBuildInfo, pMaxPrimitiveCounts, pSizeInfo);
        }
        public static void CmdSetVertexInputEXT(IntPtr commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
        {
            VkPointers._vkCmdSetVertexInputEXT_fnptr(commandBuffer, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, pVertexAttributeDescriptions);
        }
        public static void CmdSetColorWriteEnableEXT(IntPtr commandBuffer, uint attachmentCount, int* pColorWriteEnables)
        {
            VkPointers._vkCmdSetColorWriteEnableEXT_fnptr(commandBuffer, attachmentCount, pColorWriteEnables);
        }
        public static void CmdSetEvent2(IntPtr commandBuffer, IntPtr @event, VkDependencyInfo* pDependencyInfo)
        {
            VkPointers._vkCmdSetEvent2_fnptr(commandBuffer, @event, pDependencyInfo);
        }
        public static void CmdResetEvent2(IntPtr commandBuffer, IntPtr @event, VkPipelineStageFlags2 stageMask)
        {
            VkPointers._vkCmdResetEvent2_fnptr(commandBuffer, @event, stageMask);
        }
        public static void CmdWaitEvents2(IntPtr commandBuffer, uint eventCount, IntPtr* pEvents, VkDependencyInfo* pDependencyInfos)
        {
            VkPointers._vkCmdWaitEvents2_fnptr(commandBuffer, eventCount, pEvents, pDependencyInfos);
        }
        public static void CmdPipelineBarrier2(IntPtr commandBuffer, VkDependencyInfo* pDependencyInfo)
        {
            VkPointers._vkCmdPipelineBarrier2_fnptr(commandBuffer, pDependencyInfo);
        }
        public static VkResult QueueSubmit2(IntPtr queue, uint submitCount, VkSubmitInfo2* pSubmits, IntPtr fence)
        {
            return VkPointers._vkQueueSubmit2_fnptr(queue, submitCount, pSubmits, fence);
        }
        public static void CmdWriteTimestamp2(IntPtr commandBuffer, VkPipelineStageFlags2 stage, IntPtr queryPool, uint query)
        {
            VkPointers._vkCmdWriteTimestamp2_fnptr(commandBuffer, stage, queryPool, query);
        }
        public static void CmdWriteBufferMarker2AMD(IntPtr commandBuffer, VkPipelineStageFlags2 stage, IntPtr dstBuffer, ulong dstOffset, uint marker)
        {
            VkPointers._vkCmdWriteBufferMarker2AMD_fnptr(commandBuffer, stage, dstBuffer, dstOffset, marker);
        }
        public static void GetQueueCheckpointData2NV(IntPtr queue, uint* pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
        {
            VkPointers._vkGetQueueCheckpointData2NV_fnptr(queue, pCheckpointDataCount, pCheckpointData);
        }
        public static VkResult CopyMemoryToImageEXT(IntPtr device, VkCopyMemoryToImageInfoEXT* pCopyMemoryToImageInfo)
        {
            return VkPointers._vkCopyMemoryToImageEXT_fnptr(device, pCopyMemoryToImageInfo);
        }
        public static VkResult CopyImageToMemoryEXT(IntPtr device, VkCopyImageToMemoryInfoEXT* pCopyImageToMemoryInfo)
        {
            return VkPointers._vkCopyImageToMemoryEXT_fnptr(device, pCopyImageToMemoryInfo);
        }
        public static VkResult CopyImageToImageEXT(IntPtr device, VkCopyImageToImageInfoEXT* pCopyImageToImageInfo)
        {
            return VkPointers._vkCopyImageToImageEXT_fnptr(device, pCopyImageToImageInfo);
        }
        public static VkResult TransitionImageLayoutEXT(IntPtr device, uint transitionCount, VkHostImageLayoutTransitionInfoEXT* pTransitions)
        {
            return VkPointers._vkTransitionImageLayoutEXT_fnptr(device, transitionCount, pTransitions);
        }
        public static void GetCommandPoolMemoryConsumption(IntPtr device, IntPtr commandPool, IntPtr commandBuffer, VkCommandPoolMemoryConsumption* pConsumption)
        {
            VkPointers._vkGetCommandPoolMemoryConsumption_fnptr(device, commandPool, commandBuffer, pConsumption);
        }
        public static VkResult GetPhysicalDeviceVideoCapabilitiesKHR(IntPtr physicalDevice, VkVideoProfileInfoKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
        {
            return VkPointers._vkGetPhysicalDeviceVideoCapabilitiesKHR_fnptr(physicalDevice, pVideoProfile, pCapabilities);
        }
        public static VkResult GetPhysicalDeviceVideoFormatPropertiesKHR(IntPtr physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceVideoFormatPropertiesKHR_fnptr(physicalDevice, pVideoFormatInfo, pVideoFormatPropertyCount, pVideoFormatProperties);
        }
        public static VkResult GetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(IntPtr physicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo, VkVideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties)
        {
            return VkPointers._vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_fnptr(physicalDevice, pQualityLevelInfo, pQualityLevelProperties);
        }
        public static VkResult CreateVideoSessionKHR(IntPtr device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pVideoSession)
        {
            return VkPointers._vkCreateVideoSessionKHR_fnptr(device, pCreateInfo, pAllocator, pVideoSession);
        }
        public static void DestroyVideoSessionKHR(IntPtr device, IntPtr videoSession, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyVideoSessionKHR_fnptr(device, videoSession, pAllocator);
        }
        public static VkResult CreateVideoSessionParametersKHR(IntPtr device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pVideoSessionParameters)
        {
            return VkPointers._vkCreateVideoSessionParametersKHR_fnptr(device, pCreateInfo, pAllocator, pVideoSessionParameters);
        }
        public static VkResult UpdateVideoSessionParametersKHR(IntPtr device, IntPtr videoSessionParameters, VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo)
        {
            return VkPointers._vkUpdateVideoSessionParametersKHR_fnptr(device, videoSessionParameters, pUpdateInfo);
        }
        public static VkResult GetEncodedVideoSessionParametersKHR(IntPtr device, VkVideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, VkVideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, nuint* pDataSize, void* pData)
        {
            return VkPointers._vkGetEncodedVideoSessionParametersKHR_fnptr(device, pVideoSessionParametersInfo, pFeedbackInfo, pDataSize, pData);
        }
        public static void DestroyVideoSessionParametersKHR(IntPtr device, IntPtr videoSessionParameters, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyVideoSessionParametersKHR_fnptr(device, videoSessionParameters, pAllocator);
        }
        public static VkResult GetVideoSessionMemoryRequirementsKHR(IntPtr device, IntPtr videoSession, uint* pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
        {
            return VkPointers._vkGetVideoSessionMemoryRequirementsKHR_fnptr(device, videoSession, pMemoryRequirementsCount, pMemoryRequirements);
        }
        public static VkResult BindVideoSessionMemoryKHR(IntPtr device, IntPtr videoSession, uint bindSessionMemoryInfoCount, VkBindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos)
        {
            return VkPointers._vkBindVideoSessionMemoryKHR_fnptr(device, videoSession, bindSessionMemoryInfoCount, pBindSessionMemoryInfos);
        }
        public static void CmdDecodeVideoKHR(IntPtr commandBuffer, VkVideoDecodeInfoKHR* pDecodeInfo)
        {
            VkPointers._vkCmdDecodeVideoKHR_fnptr(commandBuffer, pDecodeInfo);
        }
        public static void CmdBeginVideoCodingKHR(IntPtr commandBuffer, VkVideoBeginCodingInfoKHR* pBeginInfo)
        {
            VkPointers._vkCmdBeginVideoCodingKHR_fnptr(commandBuffer, pBeginInfo);
        }
        public static void CmdControlVideoCodingKHR(IntPtr commandBuffer, VkVideoCodingControlInfoKHR* pCodingControlInfo)
        {
            VkPointers._vkCmdControlVideoCodingKHR_fnptr(commandBuffer, pCodingControlInfo);
        }
        public static void CmdEndVideoCodingKHR(IntPtr commandBuffer, VkVideoEndCodingInfoKHR* pEndCodingInfo)
        {
            VkPointers._vkCmdEndVideoCodingKHR_fnptr(commandBuffer, pEndCodingInfo);
        }
        public static void CmdEncodeVideoKHR(IntPtr commandBuffer, VkVideoEncodeInfoKHR* pEncodeInfo)
        {
            VkPointers._vkCmdEncodeVideoKHR_fnptr(commandBuffer, pEncodeInfo);
        }
        public static void CmdDecompressMemoryNV(IntPtr commandBuffer, uint decompressRegionCount, VkDecompressMemoryRegionNV* pDecompressMemoryRegions)
        {
            VkPointers._vkCmdDecompressMemoryNV_fnptr(commandBuffer, decompressRegionCount, pDecompressMemoryRegions);
        }
        public static void CmdDecompressMemoryIndirectCountNV(IntPtr commandBuffer, ulong indirectCommandsAddress, ulong indirectCommandsCountAddress, uint stride)
        {
            VkPointers._vkCmdDecompressMemoryIndirectCountNV_fnptr(commandBuffer, indirectCommandsAddress, indirectCommandsCountAddress, stride);
        }
        public static VkResult CreateCuModuleNVX(IntPtr device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pModule)
        {
            return VkPointers._vkCreateCuModuleNVX_fnptr(device, pCreateInfo, pAllocator, pModule);
        }
        public static VkResult CreateCuFunctionNVX(IntPtr device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pFunction)
        {
            return VkPointers._vkCreateCuFunctionNVX_fnptr(device, pCreateInfo, pAllocator, pFunction);
        }
        public static void DestroyCuModuleNVX(IntPtr device, IntPtr module, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCuModuleNVX_fnptr(device, module, pAllocator);
        }
        public static void DestroyCuFunctionNVX(IntPtr device, IntPtr function, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCuFunctionNVX_fnptr(device, function, pAllocator);
        }
        public static void CmdCuLaunchKernelNVX(IntPtr commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo)
        {
            VkPointers._vkCmdCuLaunchKernelNVX_fnptr(commandBuffer, pLaunchInfo);
        }
        public static void GetDescriptorSetLayoutSizeEXT(IntPtr device, IntPtr layout, ulong* pLayoutSizeInBytes)
        {
            VkPointers._vkGetDescriptorSetLayoutSizeEXT_fnptr(device, layout, pLayoutSizeInBytes);
        }
        public static void GetDescriptorSetLayoutBindingOffsetEXT(IntPtr device, IntPtr layout, uint binding, ulong* pOffset)
        {
            VkPointers._vkGetDescriptorSetLayoutBindingOffsetEXT_fnptr(device, layout, binding, pOffset);
        }
        public static void GetDescriptorEXT(IntPtr device, VkDescriptorGetInfoEXT* pDescriptorInfo, nuint dataSize, void* pDescriptor)
        {
            VkPointers._vkGetDescriptorEXT_fnptr(device, pDescriptorInfo, dataSize, pDescriptor);
        }
        public static void CmdBindDescriptorBuffersEXT(IntPtr commandBuffer, uint bufferCount, VkDescriptorBufferBindingInfoEXT* pBindingInfos)
        {
            VkPointers._vkCmdBindDescriptorBuffersEXT_fnptr(commandBuffer, bufferCount, pBindingInfos);
        }
        public static void CmdSetDescriptorBufferOffsetsEXT(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr layout, uint firstSet, uint setCount, uint* pBufferIndices, ulong* pOffsets)
        {
            VkPointers._vkCmdSetDescriptorBufferOffsetsEXT_fnptr(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, pBufferIndices, pOffsets);
        }
        public static void CmdBindDescriptorBufferEmbeddedSamplersEXT(IntPtr commandBuffer, VkPipelineBindPoint pipelineBindPoint, IntPtr layout, uint set)
        {
            VkPointers._vkCmdBindDescriptorBufferEmbeddedSamplersEXT_fnptr(commandBuffer, pipelineBindPoint, layout, set);
        }
        public static VkResult GetBufferOpaqueCaptureDescriptorDataEXT(IntPtr device, VkBufferCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetBufferOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static VkResult GetImageOpaqueCaptureDescriptorDataEXT(IntPtr device, VkImageCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetImageOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static VkResult GetImageViewOpaqueCaptureDescriptorDataEXT(IntPtr device, VkImageViewCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetImageViewOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static VkResult GetSamplerOpaqueCaptureDescriptorDataEXT(IntPtr device, VkSamplerCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetSamplerOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static VkResult GetAccelerationStructureOpaqueCaptureDescriptorDataEXT(IntPtr device, VkAccelerationStructureCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static void SetDeviceMemoryPriorityEXT(IntPtr device, IntPtr memory, float priority)
        {
            VkPointers._vkSetDeviceMemoryPriorityEXT_fnptr(device, memory, priority);
        }
        public static VkResult AcquireDrmDisplayEXT(IntPtr physicalDevice, int drmFd, IntPtr display)
        {
            return VkPointers._vkAcquireDrmDisplayEXT_fnptr(physicalDevice, drmFd, display);
        }
        public static VkResult GetDrmDisplayEXT(IntPtr physicalDevice, int drmFd, uint connectorId, IntPtr* display)
        {
            return VkPointers._vkGetDrmDisplayEXT_fnptr(physicalDevice, drmFd, connectorId, display);
        }
        public static VkResult WaitForPresentKHR(IntPtr device, IntPtr swapchain, ulong presentId, ulong timeout)
        {
            return VkPointers._vkWaitForPresentKHR_fnptr(device, swapchain, presentId, timeout);
        }
        public static VkResult CreateBufferCollectionFUCHSIA(IntPtr device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pCollection)
        {
            return VkPointers._vkCreateBufferCollectionFUCHSIA_fnptr(device, pCreateInfo, pAllocator, pCollection);
        }
        public static VkResult SetBufferCollectionBufferConstraintsFUCHSIA(IntPtr device, IntPtr collection, VkBufferConstraintsInfoFUCHSIA* pBufferConstraintsInfo)
        {
            return VkPointers._vkSetBufferCollectionBufferConstraintsFUCHSIA_fnptr(device, collection, pBufferConstraintsInfo);
        }
        public static VkResult SetBufferCollectionImageConstraintsFUCHSIA(IntPtr device, IntPtr collection, VkImageConstraintsInfoFUCHSIA* pImageConstraintsInfo)
        {
            return VkPointers._vkSetBufferCollectionImageConstraintsFUCHSIA_fnptr(device, collection, pImageConstraintsInfo);
        }
        public static void DestroyBufferCollectionFUCHSIA(IntPtr device, IntPtr collection, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyBufferCollectionFUCHSIA_fnptr(device, collection, pAllocator);
        }
        public static VkResult GetBufferCollectionPropertiesFUCHSIA(IntPtr device, IntPtr collection, VkBufferCollectionPropertiesFUCHSIA* pProperties)
        {
            return VkPointers._vkGetBufferCollectionPropertiesFUCHSIA_fnptr(device, collection, pProperties);
        }
        public static VkResult CreateCudaModuleNV(IntPtr device, VkCudaModuleCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pModule)
        {
            return VkPointers._vkCreateCudaModuleNV_fnptr(device, pCreateInfo, pAllocator, pModule);
        }
        public static VkResult GetCudaModuleCacheNV(IntPtr device, IntPtr module, nuint* pCacheSize, void* pCacheData)
        {
            return VkPointers._vkGetCudaModuleCacheNV_fnptr(device, module, pCacheSize, pCacheData);
        }
        public static VkResult CreateCudaFunctionNV(IntPtr device, VkCudaFunctionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pFunction)
        {
            return VkPointers._vkCreateCudaFunctionNV_fnptr(device, pCreateInfo, pAllocator, pFunction);
        }
        public static void DestroyCudaModuleNV(IntPtr device, IntPtr module, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCudaModuleNV_fnptr(device, module, pAllocator);
        }
        public static void DestroyCudaFunctionNV(IntPtr device, IntPtr function, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCudaFunctionNV_fnptr(device, function, pAllocator);
        }
        public static void CmdCudaLaunchKernelNV(IntPtr commandBuffer, VkCudaLaunchInfoNV* pLaunchInfo)
        {
            VkPointers._vkCmdCudaLaunchKernelNV_fnptr(commandBuffer, pLaunchInfo);
        }
        public static void CmdBeginRendering(IntPtr commandBuffer, VkRenderingInfo* pRenderingInfo)
        {
            VkPointers._vkCmdBeginRendering_fnptr(commandBuffer, pRenderingInfo);
        }
        public static void CmdEndRendering(IntPtr commandBuffer)
        {
            VkPointers._vkCmdEndRendering_fnptr(commandBuffer);
        }
        public static void GetDescriptorSetLayoutHostMappingInfoVALVE(IntPtr device, VkDescriptorSetBindingReferenceVALVE* pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
        {
            VkPointers._vkGetDescriptorSetLayoutHostMappingInfoVALVE_fnptr(device, pBindingReference, pHostMapping);
        }
        public static void GetDescriptorSetHostMappingVALVE(IntPtr device, IntPtr descriptorSet, void** ppData)
        {
            VkPointers._vkGetDescriptorSetHostMappingVALVE_fnptr(device, descriptorSet, ppData);
        }
        public static VkResult CreateMicromapEXT(IntPtr device, VkMicromapCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pMicromap)
        {
            return VkPointers._vkCreateMicromapEXT_fnptr(device, pCreateInfo, pAllocator, pMicromap);
        }
        public static void CmdBuildMicromapsEXT(IntPtr commandBuffer, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            VkPointers._vkCmdBuildMicromapsEXT_fnptr(commandBuffer, infoCount, pInfos);
        }
        public static VkResult BuildMicromapsEXT(IntPtr device, IntPtr deferredOperation, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            return VkPointers._vkBuildMicromapsEXT_fnptr(device, deferredOperation, infoCount, pInfos);
        }
        public static void DestroyMicromapEXT(IntPtr device, IntPtr micromap, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyMicromapEXT_fnptr(device, micromap, pAllocator);
        }
        public static void CmdCopyMicromapEXT(IntPtr commandBuffer, VkCopyMicromapInfoEXT* pInfo)
        {
            VkPointers._vkCmdCopyMicromapEXT_fnptr(commandBuffer, pInfo);
        }
        public static VkResult CopyMicromapEXT(IntPtr device, IntPtr deferredOperation, VkCopyMicromapInfoEXT* pInfo)
        {
            return VkPointers._vkCopyMicromapEXT_fnptr(device, deferredOperation, pInfo);
        }
        public static void CmdCopyMicromapToMemoryEXT(IntPtr commandBuffer, VkCopyMicromapToMemoryInfoEXT* pInfo)
        {
            VkPointers._vkCmdCopyMicromapToMemoryEXT_fnptr(commandBuffer, pInfo);
        }
        public static VkResult CopyMicromapToMemoryEXT(IntPtr device, IntPtr deferredOperation, VkCopyMicromapToMemoryInfoEXT* pInfo)
        {
            return VkPointers._vkCopyMicromapToMemoryEXT_fnptr(device, deferredOperation, pInfo);
        }
        public static void CmdCopyMemoryToMicromapEXT(IntPtr commandBuffer, VkCopyMemoryToMicromapInfoEXT* pInfo)
        {
            VkPointers._vkCmdCopyMemoryToMicromapEXT_fnptr(commandBuffer, pInfo);
        }
        public static VkResult CopyMemoryToMicromapEXT(IntPtr device, IntPtr deferredOperation, VkCopyMemoryToMicromapInfoEXT* pInfo)
        {
            return VkPointers._vkCopyMemoryToMicromapEXT_fnptr(device, deferredOperation, pInfo);
        }
        public static void CmdWriteMicromapsPropertiesEXT(IntPtr commandBuffer, uint micromapCount, IntPtr* pMicromaps, VkQueryType queryType, IntPtr queryPool, uint firstQuery)
        {
            VkPointers._vkCmdWriteMicromapsPropertiesEXT_fnptr(commandBuffer, micromapCount, pMicromaps, queryType, queryPool, firstQuery);
        }
        public static VkResult WriteMicromapsPropertiesEXT(IntPtr device, uint micromapCount, IntPtr* pMicromaps, VkQueryType queryType, nuint dataSize, void* pData, nuint stride)
        {
            return VkPointers._vkWriteMicromapsPropertiesEXT_fnptr(device, micromapCount, pMicromaps, queryType, dataSize, pData, stride);
        }
        public static void GetDeviceMicromapCompatibilityEXT(IntPtr device, VkMicromapVersionInfoEXT* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            VkPointers._vkGetDeviceMicromapCompatibilityEXT_fnptr(device, pVersionInfo, pCompatibility);
        }
        public static void GetMicromapBuildSizesEXT(IntPtr device, VkAccelerationStructureBuildTypeKHR buildType, VkMicromapBuildInfoEXT* pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
        {
            VkPointers._vkGetMicromapBuildSizesEXT_fnptr(device, buildType, pBuildInfo, pSizeInfo);
        }
        public static void GetShaderModuleIdentifierEXT(IntPtr device, IntPtr shaderModule, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            VkPointers._vkGetShaderModuleIdentifierEXT_fnptr(device, shaderModule, pIdentifier);
        }
        public static void GetShaderModuleCreateInfoIdentifierEXT(IntPtr device, VkShaderModuleCreateInfo* pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            VkPointers._vkGetShaderModuleCreateInfoIdentifierEXT_fnptr(device, pCreateInfo, pIdentifier);
        }
        public static void GetImageSubresourceLayout2KHR(IntPtr device, IntPtr image, VkImageSubresource2KHR* pSubresource, VkSubresourceLayout2KHR* pLayout)
        {
            VkPointers._vkGetImageSubresourceLayout2KHR_fnptr(device, image, pSubresource, pLayout);
        }
        public static VkResult GetPipelinePropertiesEXT(IntPtr device, VkPipelineInfoEXT* pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
        {
            return VkPointers._vkGetPipelinePropertiesEXT_fnptr(device, pPipelineInfo, pPipelineProperties);
        }
        public static void ExportMetalObjectsEXT(IntPtr device, VkExportMetalObjectsInfoEXT* pMetalObjectsInfo)
        {
            VkPointers._vkExportMetalObjectsEXT_fnptr(device, pMetalObjectsInfo);
        }
        public static VkResult GetFramebufferTilePropertiesQCOM(IntPtr device, IntPtr framebuffer, uint* pPropertiesCount, VkTilePropertiesQCOM* pProperties)
        {
            return VkPointers._vkGetFramebufferTilePropertiesQCOM_fnptr(device, framebuffer, pPropertiesCount, pProperties);
        }
        public static VkResult GetDynamicRenderingTilePropertiesQCOM(IntPtr device, VkRenderingInfo* pRenderingInfo, VkTilePropertiesQCOM* pProperties)
        {
            return VkPointers._vkGetDynamicRenderingTilePropertiesQCOM_fnptr(device, pRenderingInfo, pProperties);
        }
        public static VkResult GetPhysicalDeviceOpticalFlowImageFormatsNV(IntPtr physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceOpticalFlowImageFormatsNV_fnptr(physicalDevice, pOpticalFlowImageFormatInfo, pFormatCount, pImageFormatProperties);
        }
        public static VkResult CreateOpticalFlowSessionNV(IntPtr device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, IntPtr* pSession)
        {
            return VkPointers._vkCreateOpticalFlowSessionNV_fnptr(device, pCreateInfo, pAllocator, pSession);
        }
        public static void DestroyOpticalFlowSessionNV(IntPtr device, IntPtr session, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyOpticalFlowSessionNV_fnptr(device, session, pAllocator);
        }
        public static VkResult BindOpticalFlowSessionImageNV(IntPtr device, IntPtr session, VkOpticalFlowSessionBindingPointNV bindingPoint, IntPtr view, VkImageLayout layout)
        {
            return VkPointers._vkBindOpticalFlowSessionImageNV_fnptr(device, session, bindingPoint, view, layout);
        }
        public static void CmdOpticalFlowExecuteNV(IntPtr commandBuffer, IntPtr session, VkOpticalFlowExecuteInfoNV* pExecuteInfo)
        {
            VkPointers._vkCmdOpticalFlowExecuteNV_fnptr(commandBuffer, session, pExecuteInfo);
        }
        public static VkResult GetDeviceFaultInfoEXT(IntPtr device, VkDeviceFaultCountsEXT* pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
        {
            return VkPointers._vkGetDeviceFaultInfoEXT_fnptr(device, pFaultCounts, pFaultInfo);
        }
        public static void CmdSetDepthBias2EXT(IntPtr commandBuffer, VkDepthBiasInfoEXT* pDepthBiasInfo)
        {
            VkPointers._vkCmdSetDepthBias2EXT_fnptr(commandBuffer, pDepthBiasInfo);
        }
        public static VkResult ReleaseSwapchainImagesEXT(IntPtr device, VkReleaseSwapchainImagesInfoEXT* pReleaseInfo)
        {
            return VkPointers._vkReleaseSwapchainImagesEXT_fnptr(device, pReleaseInfo);
        }
        public static void GetDeviceImageSubresourceLayoutKHR(IntPtr device, VkDeviceImageSubresourceInfoKHR* pInfo, VkSubresourceLayout2KHR* pLayout)
        {
            VkPointers._vkGetDeviceImageSubresourceLayoutKHR_fnptr(device, pInfo, pLayout);
        }
        public static VkResult MapMemory2KHR(IntPtr device, VkMemoryMapInfoKHR* pMemoryMapInfo, void** ppData)
        {
            return VkPointers._vkMapMemory2KHR_fnptr(device, pMemoryMapInfo, ppData);
        }
        public static VkResult UnmapMemory2KHR(IntPtr device, VkMemoryUnmapInfoKHR* pMemoryUnmapInfo)
        {
            return VkPointers._vkUnmapMemory2KHR_fnptr(device, pMemoryUnmapInfo);
        }
        public static VkResult CreateShadersEXT(IntPtr device, uint createInfoCount, VkShaderCreateInfoEXT* pCreateInfos, VkAllocationCallbacks* pAllocator, IntPtr* pShaders)
        {
            return VkPointers._vkCreateShadersEXT_fnptr(device, createInfoCount, pCreateInfos, pAllocator, pShaders);
        }
        public static void DestroyShaderEXT(IntPtr device, IntPtr shader, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyShaderEXT_fnptr(device, shader, pAllocator);
        }
        public static VkResult GetShaderBinaryDataEXT(IntPtr device, IntPtr shader, nuint* pDataSize, void* pData)
        {
            return VkPointers._vkGetShaderBinaryDataEXT_fnptr(device, shader, pDataSize, pData);
        }
        public static void CmdBindShadersEXT(IntPtr commandBuffer, uint stageCount, VkShaderStageFlagBits* pStages, IntPtr* pShaders)
        {
            VkPointers._vkCmdBindShadersEXT_fnptr(commandBuffer, stageCount, pStages, pShaders);
        }
        public static VkResult GetScreenBufferPropertiesQNX(IntPtr device, IntPtr* buffer, VkScreenBufferPropertiesQNX* pProperties)
        {
            return VkPointers._vkGetScreenBufferPropertiesQNX_fnptr(device, buffer, pProperties);
        }
        public static VkResult GetPhysicalDeviceCooperativeMatrixPropertiesKHR(IntPtr physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesKHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static VkResult GetExecutionGraphPipelineScratchSizeAMDX(IntPtr device, IntPtr executionGraph, VkExecutionGraphPipelineScratchSizeAMDX* pSizeInfo)
        {
            return VkPointers._vkGetExecutionGraphPipelineScratchSizeAMDX_fnptr(device, executionGraph, pSizeInfo);
        }
        public static VkResult GetExecutionGraphPipelineNodeIndexAMDX(IntPtr device, IntPtr executionGraph, VkPipelineShaderStageNodeCreateInfoAMDX* pNodeInfo, uint* pNodeIndex)
        {
            return VkPointers._vkGetExecutionGraphPipelineNodeIndexAMDX_fnptr(device, executionGraph, pNodeInfo, pNodeIndex);
        }
        public static VkResult CreateExecutionGraphPipelinesAMDX(IntPtr device, IntPtr pipelineCache, uint createInfoCount, VkExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, VkAllocationCallbacks* pAllocator, IntPtr* pPipelines)
        {
            return VkPointers._vkCreateExecutionGraphPipelinesAMDX_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static void CmdInitializeGraphScratchMemoryAMDX(IntPtr commandBuffer, ulong scratch)
        {
            VkPointers._vkCmdInitializeGraphScratchMemoryAMDX_fnptr(commandBuffer, scratch);
        }
        public static void CmdDispatchGraphAMDX(IntPtr commandBuffer, ulong scratch, VkDispatchGraphCountInfoAMDX* pCountInfo)
        {
            VkPointers._vkCmdDispatchGraphAMDX_fnptr(commandBuffer, scratch, pCountInfo);
        }
        public static void CmdDispatchGraphIndirectAMDX(IntPtr commandBuffer, ulong scratch, VkDispatchGraphCountInfoAMDX* pCountInfo)
        {
            VkPointers._vkCmdDispatchGraphIndirectAMDX_fnptr(commandBuffer, scratch, pCountInfo);
        }
        public static void CmdDispatchGraphIndirectCountAMDX(IntPtr commandBuffer, ulong scratch, ulong countInfo)
        {
            VkPointers._vkCmdDispatchGraphIndirectCountAMDX_fnptr(commandBuffer, scratch, countInfo);
        }
        public static void CmdBindDescriptorSets2KHR(IntPtr commandBuffer, VkBindDescriptorSetsInfoKHR* pBindDescriptorSetsInfo)
        {
            VkPointers._vkCmdBindDescriptorSets2KHR_fnptr(commandBuffer, pBindDescriptorSetsInfo);
        }
        public static void CmdPushConstants2KHR(IntPtr commandBuffer, VkPushConstantsInfoKHR* pPushConstantsInfo)
        {
            VkPointers._vkCmdPushConstants2KHR_fnptr(commandBuffer, pPushConstantsInfo);
        }
        public static void CmdPushDescriptorSet2KHR(IntPtr commandBuffer, VkPushDescriptorSetInfoKHR* pPushDescriptorSetInfo)
        {
            VkPointers._vkCmdPushDescriptorSet2KHR_fnptr(commandBuffer, pPushDescriptorSetInfo);
        }
        public static void CmdPushDescriptorSetWithTemplate2KHR(IntPtr commandBuffer, VkPushDescriptorSetWithTemplateInfoKHR* pPushDescriptorSetWithTemplateInfo)
        {
            VkPointers._vkCmdPushDescriptorSetWithTemplate2KHR_fnptr(commandBuffer, pPushDescriptorSetWithTemplateInfo);
        }
        public static void CmdSetDescriptorBufferOffsets2EXT(IntPtr commandBuffer, VkSetDescriptorBufferOffsetsInfoEXT* pSetDescriptorBufferOffsetsInfo)
        {
            VkPointers._vkCmdSetDescriptorBufferOffsets2EXT_fnptr(commandBuffer, pSetDescriptorBufferOffsetsInfo);
        }
        public static void CmdBindDescriptorBufferEmbeddedSamplers2EXT(IntPtr commandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT* pBindDescriptorBufferEmbeddedSamplersInfo)
        {
            VkPointers._vkCmdBindDescriptorBufferEmbeddedSamplers2EXT_fnptr(commandBuffer, pBindDescriptorBufferEmbeddedSamplersInfo);
        }
        public static VkResult SetLatencySleepModeNV(IntPtr device, IntPtr swapchain, VkLatencySleepModeInfoNV* pSleepModeInfo)
        {
            return VkPointers._vkSetLatencySleepModeNV_fnptr(device, swapchain, pSleepModeInfo);
        }
        public static VkResult LatencySleepNV(IntPtr device, IntPtr swapchain, VkLatencySleepInfoNV* pSleepInfo)
        {
            return VkPointers._vkLatencySleepNV_fnptr(device, swapchain, pSleepInfo);
        }
        public static void SetLatencyMarkerNV(IntPtr device, IntPtr swapchain, VkSetLatencyMarkerInfoNV* pLatencyMarkerInfo)
        {
            VkPointers._vkSetLatencyMarkerNV_fnptr(device, swapchain, pLatencyMarkerInfo);
        }
        public static void GetLatencyTimingsNV(IntPtr device, IntPtr swapchain, VkGetLatencyMarkerInfoNV* pLatencyMarkerInfo)
        {
            VkPointers._vkGetLatencyTimingsNV_fnptr(device, swapchain, pLatencyMarkerInfo);
        }
        public static void QueueNotifyOutOfBandNV(IntPtr queue, VkOutOfBandQueueTypeInfoNV* pQueueTypeInfo)
        {
            VkPointers._vkQueueNotifyOutOfBandNV_fnptr(queue, pQueueTypeInfo);
        }
        public static void CmdSetRenderingAttachmentLocationsKHR(IntPtr commandBuffer, VkRenderingAttachmentLocationInfoKHR* pLocationInfo)
        {
            VkPointers._vkCmdSetRenderingAttachmentLocationsKHR_fnptr(commandBuffer, pLocationInfo);
        }
        public static void CmdSetRenderingInputAttachmentIndicesKHR(IntPtr commandBuffer, VkRenderingInputAttachmentIndexInfoKHR* pInputAttachmentIndexInfo)
        {
            VkPointers._vkCmdSetRenderingInputAttachmentIndicesKHR_fnptr(commandBuffer, pInputAttachmentIndexInfo);
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
