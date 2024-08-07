// This file is auto generated, do not edit.
using OpenTK.Mathematics;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecsCommon;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH264std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH264stdDecode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH264stdEncode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH265std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH265stdDecode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH265stdEncode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecAv1std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecAv1stdDecode;
using System;
using System.Runtime.CompilerServices;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static unsafe partial class Vk
    {
        public static VkResult CreateInstance(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance)
        {
            return VkPointers._vkCreateInstance_fnptr(pCreateInfo, pAllocator, pInstance);
        }
        public static void DestroyInstance(VkInstance instance, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyInstance_fnptr(instance, pAllocator);
        }
        public static VkResult EnumeratePhysicalDevices(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices)
        {
            return VkPointers._vkEnumeratePhysicalDevices_fnptr(instance, pPhysicalDeviceCount, pPhysicalDevices);
        }
        public static IntPtr GetDeviceProcAddr(VkDevice device, byte* pName)
        {
            return VkPointers._vkGetDeviceProcAddr_fnptr(device, pName);
        }
        public static IntPtr GetInstanceProcAddr(VkInstance instance, byte* pName)
        {
            return VkPointers._vkGetInstanceProcAddr_fnptr(instance, pName);
        }
        public static void GetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceProperties_fnptr(physicalDevice, pProperties);
        }
        public static void GetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties)
        {
            VkPointers._vkGetPhysicalDeviceQueueFamilyProperties_fnptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        public static void GetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties)
        {
            VkPointers._vkGetPhysicalDeviceMemoryProperties_fnptr(physicalDevice, pMemoryProperties);
        }
        public static void GetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures)
        {
            VkPointers._vkGetPhysicalDeviceFeatures_fnptr(physicalDevice, pFeatures);
        }
        public static void GetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties)
        {
            VkPointers._vkGetPhysicalDeviceFormatProperties_fnptr(physicalDevice, format, pFormatProperties);
        }
        public static VkResult GetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlagBits usage, VkImageCreateFlagBits flags, VkImageFormatProperties* pImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceImageFormatProperties_fnptr(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);
        }
        public static VkResult CreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice)
        {
            return VkPointers._vkCreateDevice_fnptr(physicalDevice, pCreateInfo, pAllocator, pDevice);
        }
        public static void DestroyDevice(VkDevice device, VkAllocationCallbacks* pAllocator)
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
        public static VkResult EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties)
        {
            return VkPointers._vkEnumerateDeviceLayerProperties_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static VkResult EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
        {
            return VkPointers._vkEnumerateDeviceExtensionProperties_fnptr(physicalDevice, pLayerName, pPropertyCount, pProperties);
        }
        public static void GetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue)
        {
            VkPointers._vkGetDeviceQueue_fnptr(device, queueFamilyIndex, queueIndex, pQueue);
        }
        public static VkResult QueueSubmit(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence)
        {
            return VkPointers._vkQueueSubmit_fnptr(queue, submitCount, pSubmits, fence);
        }
        public static VkResult QueueWaitIdle(VkQueue queue)
        {
            return VkPointers._vkQueueWaitIdle_fnptr(queue);
        }
        public static VkResult DeviceWaitIdle(VkDevice device)
        {
            return VkPointers._vkDeviceWaitIdle_fnptr(device);
        }
        public static VkResult AllocateMemory(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory)
        {
            return VkPointers._vkAllocateMemory_fnptr(device, pAllocateInfo, pAllocator, pMemory);
        }
        public static void FreeMemory(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkFreeMemory_fnptr(device, memory, pAllocator);
        }
        public static VkResult MapMemory(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, VkMemoryMapFlagBits flags, void** ppData)
        {
            return VkPointers._vkMapMemory_fnptr(device, memory, offset, size, flags, ppData);
        }
        public static void UnmapMemory(VkDevice device, VkDeviceMemory memory)
        {
            VkPointers._vkUnmapMemory_fnptr(device, memory);
        }
        public static VkResult FlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
        {
            return VkPointers._vkFlushMappedMemoryRanges_fnptr(device, memoryRangeCount, pMemoryRanges);
        }
        public static VkResult InvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
        {
            return VkPointers._vkInvalidateMappedMemoryRanges_fnptr(device, memoryRangeCount, pMemoryRanges);
        }
        public static void GetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, ulong* pCommittedMemoryInBytes)
        {
            VkPointers._vkGetDeviceMemoryCommitment_fnptr(device, memory, pCommittedMemoryInBytes);
        }
        public static void GetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements)
        {
            VkPointers._vkGetBufferMemoryRequirements_fnptr(device, buffer, pMemoryRequirements);
        }
        public static VkResult BindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset)
        {
            return VkPointers._vkBindBufferMemory_fnptr(device, buffer, memory, memoryOffset);
        }
        public static void GetImageMemoryRequirements(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements)
        {
            VkPointers._vkGetImageMemoryRequirements_fnptr(device, image, pMemoryRequirements);
        }
        public static VkResult BindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset)
        {
            return VkPointers._vkBindImageMemory_fnptr(device, image, memory, memoryOffset);
        }
        public static void GetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements)
        {
            VkPointers._vkGetImageSparseMemoryRequirements_fnptr(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        public static void GetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlagBits usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceSparseImageFormatProperties_fnptr(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);
        }
        public static VkResult QueueBindSparse(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence)
        {
            return VkPointers._vkQueueBindSparse_fnptr(queue, bindInfoCount, pBindInfo, fence);
        }
        public static VkResult CreateFence(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            return VkPointers._vkCreateFence_fnptr(device, pCreateInfo, pAllocator, pFence);
        }
        public static void DestroyFence(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyFence_fnptr(device, fence, pAllocator);
        }
        public static VkResult ResetFences(VkDevice device, uint fenceCount, VkFence* pFences)
        {
            return VkPointers._vkResetFences_fnptr(device, fenceCount, pFences);
        }
        public static VkResult GetFenceStatus(VkDevice device, VkFence fence)
        {
            return VkPointers._vkGetFenceStatus_fnptr(device, fence);
        }
        public static VkResult WaitForFences(VkDevice device, uint fenceCount, VkFence* pFences, int waitAll, ulong timeout)
        {
            return VkPointers._vkWaitForFences_fnptr(device, fenceCount, pFences, waitAll, timeout);
        }
        public static VkResult CreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore)
        {
            return VkPointers._vkCreateSemaphore_fnptr(device, pCreateInfo, pAllocator, pSemaphore);
        }
        public static void DestroySemaphore(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySemaphore_fnptr(device, semaphore, pAllocator);
        }
        public static VkResult CreateEvent(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent)
        {
            return VkPointers._vkCreateEvent_fnptr(device, pCreateInfo, pAllocator, pEvent);
        }
        public static void DestroyEvent(VkDevice device, VkEvent @event, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyEvent_fnptr(device, @event, pAllocator);
        }
        public static VkResult GetEventStatus(VkDevice device, VkEvent @event)
        {
            return VkPointers._vkGetEventStatus_fnptr(device, @event);
        }
        public static VkResult SetEvent(VkDevice device, VkEvent @event)
        {
            return VkPointers._vkSetEvent_fnptr(device, @event);
        }
        public static VkResult ResetEvent(VkDevice device, VkEvent @event)
        {
            return VkPointers._vkResetEvent_fnptr(device, @event);
        }
        public static VkResult CreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool)
        {
            return VkPointers._vkCreateQueryPool_fnptr(device, pCreateInfo, pAllocator, pQueryPool);
        }
        public static void DestroyQueryPool(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyQueryPool_fnptr(device, queryPool, pAllocator);
        }
        public static VkResult GetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* pData, ulong stride, VkQueryResultFlagBits flags)
        {
            return VkPointers._vkGetQueryPoolResults_fnptr(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);
        }
        public static void ResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            VkPointers._vkResetQueryPool_fnptr(device, queryPool, firstQuery, queryCount);
        }
        public static VkResult CreateBuffer(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer)
        {
            return VkPointers._vkCreateBuffer_fnptr(device, pCreateInfo, pAllocator, pBuffer);
        }
        public static void DestroyBuffer(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyBuffer_fnptr(device, buffer, pAllocator);
        }
        public static VkResult CreateBufferView(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView)
        {
            return VkPointers._vkCreateBufferView_fnptr(device, pCreateInfo, pAllocator, pView);
        }
        public static void DestroyBufferView(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyBufferView_fnptr(device, bufferView, pAllocator);
        }
        public static VkResult CreateImage(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage)
        {
            return VkPointers._vkCreateImage_fnptr(device, pCreateInfo, pAllocator, pImage);
        }
        public static void DestroyImage(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyImage_fnptr(device, image, pAllocator);
        }
        public static void GetImageSubresourceLayout(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout)
        {
            VkPointers._vkGetImageSubresourceLayout_fnptr(device, image, pSubresource, pLayout);
        }
        public static VkResult CreateImageView(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView)
        {
            return VkPointers._vkCreateImageView_fnptr(device, pCreateInfo, pAllocator, pView);
        }
        public static void DestroyImageView(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyImageView_fnptr(device, imageView, pAllocator);
        }
        public static VkResult CreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule)
        {
            return VkPointers._vkCreateShaderModule_fnptr(device, pCreateInfo, pAllocator, pShaderModule);
        }
        public static void DestroyShaderModule(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyShaderModule_fnptr(device, shaderModule, pAllocator);
        }
        public static VkResult CreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache)
        {
            return VkPointers._vkCreatePipelineCache_fnptr(device, pCreateInfo, pAllocator, pPipelineCache);
        }
        public static void DestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPipelineCache_fnptr(device, pipelineCache, pAllocator);
        }
        public static VkResult GetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, nuint* pDataSize, void* pData)
        {
            return VkPointers._vkGetPipelineCacheData_fnptr(device, pipelineCache, pDataSize, pData);
        }
        public static VkResult MergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches)
        {
            return VkPointers._vkMergePipelineCaches_fnptr(device, dstCache, srcCacheCount, pSrcCaches);
        }
        public static VkResult CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return VkPointers._vkCreateGraphicsPipelines_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static VkResult CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return VkPointers._vkCreateComputePipelines_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static VkResult GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize)
        {
            return VkPointers._vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_fnptr(device, renderpass, pMaxWorkgroupSize);
        }
        public static void DestroyPipeline(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPipeline_fnptr(device, pipeline, pAllocator);
        }
        public static VkResult CreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout)
        {
            return VkPointers._vkCreatePipelineLayout_fnptr(device, pCreateInfo, pAllocator, pPipelineLayout);
        }
        public static void DestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPipelineLayout_fnptr(device, pipelineLayout, pAllocator);
        }
        public static VkResult CreateSampler(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler)
        {
            return VkPointers._vkCreateSampler_fnptr(device, pCreateInfo, pAllocator, pSampler);
        }
        public static void DestroySampler(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySampler_fnptr(device, sampler, pAllocator);
        }
        public static VkResult CreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout)
        {
            return VkPointers._vkCreateDescriptorSetLayout_fnptr(device, pCreateInfo, pAllocator, pSetLayout);
        }
        public static void DestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDescriptorSetLayout_fnptr(device, descriptorSetLayout, pAllocator);
        }
        public static VkResult CreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool)
        {
            return VkPointers._vkCreateDescriptorPool_fnptr(device, pCreateInfo, pAllocator, pDescriptorPool);
        }
        public static void DestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDescriptorPool_fnptr(device, descriptorPool, pAllocator);
        }
        public static VkResult ResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags)
        {
            return VkPointers._vkResetDescriptorPool_fnptr(device, descriptorPool, flags);
        }
        public static VkResult AllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets)
        {
            return VkPointers._vkAllocateDescriptorSets_fnptr(device, pAllocateInfo, pDescriptorSets);
        }
        public static VkResult FreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets)
        {
            return VkPointers._vkFreeDescriptorSets_fnptr(device, descriptorPool, descriptorSetCount, pDescriptorSets);
        }
        public static void UpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies)
        {
            VkPointers._vkUpdateDescriptorSets_fnptr(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);
        }
        public static VkResult CreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer)
        {
            return VkPointers._vkCreateFramebuffer_fnptr(device, pCreateInfo, pAllocator, pFramebuffer);
        }
        public static void DestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyFramebuffer_fnptr(device, framebuffer, pAllocator);
        }
        public static VkResult CreateRenderPass(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
        {
            return VkPointers._vkCreateRenderPass_fnptr(device, pCreateInfo, pAllocator, pRenderPass);
        }
        public static void DestroyRenderPass(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyRenderPass_fnptr(device, renderPass, pAllocator);
        }
        public static void GetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity)
        {
            VkPointers._vkGetRenderAreaGranularity_fnptr(device, renderPass, pGranularity);
        }
        public static void GetRenderingAreaGranularityKHR(VkDevice device, VkRenderingAreaInfoKHR* pRenderingAreaInfo, VkExtent2D* pGranularity)
        {
            VkPointers._vkGetRenderingAreaGranularityKHR_fnptr(device, pRenderingAreaInfo, pGranularity);
        }
        public static VkResult CreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool)
        {
            return VkPointers._vkCreateCommandPool_fnptr(device, pCreateInfo, pAllocator, pCommandPool);
        }
        public static void DestroyCommandPool(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCommandPool_fnptr(device, commandPool, pAllocator);
        }
        public static VkResult ResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlagBits flags)
        {
            return VkPointers._vkResetCommandPool_fnptr(device, commandPool, flags);
        }
        public static VkResult AllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers)
        {
            return VkPointers._vkAllocateCommandBuffers_fnptr(device, pAllocateInfo, pCommandBuffers);
        }
        public static void FreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
        {
            VkPointers._vkFreeCommandBuffers_fnptr(device, commandPool, commandBufferCount, pCommandBuffers);
        }
        public static VkResult BeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo)
        {
            return VkPointers._vkBeginCommandBuffer_fnptr(commandBuffer, pBeginInfo);
        }
        public static VkResult EndCommandBuffer(VkCommandBuffer commandBuffer)
        {
            return VkPointers._vkEndCommandBuffer_fnptr(commandBuffer);
        }
        public static VkResult ResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlagBits flags)
        {
            return VkPointers._vkResetCommandBuffer_fnptr(commandBuffer, flags);
        }
        public static void CmdBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
        {
            VkPointers._vkCmdBindPipeline_fnptr(commandBuffer, pipelineBindPoint, pipeline);
        }
        public static void CmdSetAttachmentFeedbackLoopEnableEXT(VkCommandBuffer commandBuffer, VkImageAspectFlagBits aspectMask)
        {
            VkPointers._vkCmdSetAttachmentFeedbackLoopEnableEXT_fnptr(commandBuffer, aspectMask);
        }
        public static void CmdSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports)
        {
            VkPointers._vkCmdSetViewport_fnptr(commandBuffer, firstViewport, viewportCount, pViewports);
        }
        public static void CmdSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors)
        {
            VkPointers._vkCmdSetScissor_fnptr(commandBuffer, firstScissor, scissorCount, pScissors);
        }
        public static void CmdSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth)
        {
            VkPointers._vkCmdSetLineWidth_fnptr(commandBuffer, lineWidth);
        }
        public static void CmdSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            VkPointers._vkCmdSetDepthBias_fnptr(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
        }
        public static void CmdSetBlendConstants(VkCommandBuffer commandBuffer, float* blendConstants)
        {
            VkPointers._vkCmdSetBlendConstants_fnptr(commandBuffer, blendConstants);
        }
        public static void CmdSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds)
        {
            VkPointers._vkCmdSetDepthBounds_fnptr(commandBuffer, minDepthBounds, maxDepthBounds);
        }
        public static void CmdSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, uint compareMask)
        {
            VkPointers._vkCmdSetStencilCompareMask_fnptr(commandBuffer, faceMask, compareMask);
        }
        public static void CmdSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, uint writeMask)
        {
            VkPointers._vkCmdSetStencilWriteMask_fnptr(commandBuffer, faceMask, writeMask);
        }
        public static void CmdSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, uint reference)
        {
            VkPointers._vkCmdSetStencilReference_fnptr(commandBuffer, faceMask, reference);
        }
        public static void CmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
        {
            VkPointers._vkCmdBindDescriptorSets_fnptr(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);
        }
        public static void CmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType)
        {
            VkPointers._vkCmdBindIndexBuffer_fnptr(commandBuffer, buffer, offset, indexType);
        }
        public static void CmdBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets)
        {
            VkPointers._vkCmdBindVertexBuffers_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);
        }
        public static void CmdDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            VkPointers._vkCmdDraw_fnptr(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
        }
        public static void CmdDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            VkPointers._vkCmdDrawIndexed_fnptr(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
        }
        public static void CmdDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
        {
            VkPointers._vkCmdDrawMultiEXT_fnptr(commandBuffer, drawCount, pVertexInfo, instanceCount, firstInstance, stride);
        }
        public static void CmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
        {
            VkPointers._vkCmdDrawMultiIndexedEXT_fnptr(commandBuffer, drawCount, pIndexInfo, instanceCount, firstInstance, stride, pVertexOffset);
        }
        public static void CmdDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndirect_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        public static void CmdDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndexedIndirect_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        public static void CmdDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDispatch_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        public static void CmdDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
        {
            VkPointers._vkCmdDispatchIndirect_fnptr(commandBuffer, buffer, offset);
        }
        public static void CmdSubpassShadingHUAWEI(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdSubpassShadingHUAWEI_fnptr(commandBuffer);
        }
        public static void CmdDrawClusterHUAWEI(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDrawClusterHUAWEI_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        public static void CmdDrawClusterIndirectHUAWEI(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
        {
            VkPointers._vkCmdDrawClusterIndirectHUAWEI_fnptr(commandBuffer, buffer, offset);
        }
        public static void CmdUpdatePipelineIndirectBufferNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
        {
            VkPointers._vkCmdUpdatePipelineIndirectBufferNV_fnptr(commandBuffer, pipelineBindPoint, pipeline);
        }
        public static void CmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions)
        {
            VkPointers._vkCmdCopyBuffer_fnptr(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);
        }
        public static void CmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions)
        {
            VkPointers._vkCmdCopyImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
        }
        public static void CmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter)
        {
            VkPointers._vkCmdBlitImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
        }
        public static void CmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions)
        {
            VkPointers._vkCmdCopyBufferToImage_fnptr(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);
        }
        public static void CmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
        {
            VkPointers._vkCmdCopyImageToBuffer_fnptr(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
        }
        public static void CmdCopyMemoryIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride)
        {
            VkPointers._vkCmdCopyMemoryIndirectNV_fnptr(commandBuffer, copyBufferAddress, copyCount, stride);
        }
        public static void CmdCopyMemoryToImageIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, VkImageSubresourceLayers* pImageSubresources)
        {
            VkPointers._vkCmdCopyMemoryToImageIndirectNV_fnptr(commandBuffer, copyBufferAddress, copyCount, stride, dstImage, dstImageLayout, pImageSubresources);
        }
        public static void CmdUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData)
        {
            VkPointers._vkCmdUpdateBuffer_fnptr(commandBuffer, dstBuffer, dstOffset, dataSize, pData);
        }
        public static void CmdFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data)
        {
            VkPointers._vkCmdFillBuffer_fnptr(commandBuffer, dstBuffer, dstOffset, size, data);
        }
        public static void CmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            VkPointers._vkCmdClearColorImage_fnptr(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);
        }
        public static void CmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            VkPointers._vkCmdClearDepthStencilImage_fnptr(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);
        }
        public static void CmdClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects)
        {
            VkPointers._vkCmdClearAttachments_fnptr(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);
        }
        public static void CmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions)
        {
            VkPointers._vkCmdResolveImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
        }
        public static void CmdSetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits stageMask)
        {
            VkPointers._vkCmdSetEvent_fnptr(commandBuffer, @event, stageMask);
        }
        public static void CmdResetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits stageMask)
        {
            VkPointers._vkCmdResetEvent_fnptr(commandBuffer, @event, stageMask);
        }
        public static void CmdWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlagBits srcStageMask, VkPipelineStageFlagBits dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
        {
            VkPointers._vkCmdWaitEvents_fnptr(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }
        public static void CmdPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits srcStageMask, VkPipelineStageFlagBits dstStageMask, VkDependencyFlagBits dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
        {
            VkPointers._vkCmdPipelineBarrier_fnptr(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }
        public static void CmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlagBits flags)
        {
            VkPointers._vkCmdBeginQuery_fnptr(commandBuffer, queryPool, query, flags);
        }
        public static void CmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query)
        {
            VkPointers._vkCmdEndQuery_fnptr(commandBuffer, queryPool, query);
        }
        public static void CmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
        {
            VkPointers._vkCmdBeginConditionalRenderingEXT_fnptr(commandBuffer, pConditionalRenderingBegin);
        }
        public static void CmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdEndConditionalRenderingEXT_fnptr(commandBuffer);
        }
        public static void CmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            VkPointers._vkCmdResetQueryPool_fnptr(commandBuffer, queryPool, firstQuery, queryCount);
        }
        public static void CmdWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint query)
        {
            VkPointers._vkCmdWriteTimestamp_fnptr(commandBuffer, pipelineStage, queryPool, query);
        }
        public static void CmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlagBits flags)
        {
            VkPointers._vkCmdCopyQueryPoolResults_fnptr(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
        }
        public static void CmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlagBits stageFlags, uint offset, uint size, void* pValues)
        {
            VkPointers._vkCmdPushConstants_fnptr(commandBuffer, layout, stageFlags, offset, size, pValues);
        }
        public static void CmdBeginRenderPass(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents)
        {
            VkPointers._vkCmdBeginRenderPass_fnptr(commandBuffer, pRenderPassBegin, contents);
        }
        public static void CmdNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents)
        {
            VkPointers._vkCmdNextSubpass_fnptr(commandBuffer, contents);
        }
        public static void CmdEndRenderPass(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdEndRenderPass_fnptr(commandBuffer);
        }
        public static void CmdExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
        {
            VkPointers._vkCmdExecuteCommands_fnptr(commandBuffer, commandBufferCount, pCommandBuffers);
        }
        public static VkResult CreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateAndroidSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceDisplayPropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceDisplayPlanePropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static VkResult GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays)
        {
            return VkPointers._vkGetDisplayPlaneSupportedDisplaysKHR_fnptr(physicalDevice, planeIndex, pDisplayCount, pDisplays);
        }
        public static VkResult GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
        {
            return VkPointers._vkGetDisplayModePropertiesKHR_fnptr(physicalDevice, display, pPropertyCount, pProperties);
        }
        public static VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
        {
            return VkPointers._vkCreateDisplayModeKHR_fnptr(physicalDevice, display, pCreateInfo, pAllocator, pMode);
        }
        public static VkResult GetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)
        {
            return VkPointers._vkGetDisplayPlaneCapabilitiesKHR_fnptr(physicalDevice, mode, planeIndex, pCapabilities);
        }
        public static VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateDisplayPlaneSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult CreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
        {
            return VkPointers._vkCreateSharedSwapchainsKHR_fnptr(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);
        }
        public static void DestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySurfaceKHR_fnptr(instance, surface, pAllocator);
        }
        public static VkResult GetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, int* pSupported)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceSupportKHR_fnptr(physicalDevice, queueFamilyIndex, surface, pSupported);
        }
        public static VkResult GetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceCapabilitiesKHR_fnptr(physicalDevice, surface, pSurfaceCapabilities);
        }
        public static VkResult GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceFormatsKHR_fnptr(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);
        }
        public static VkResult GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            return VkPointers._vkGetPhysicalDeviceSurfacePresentModesKHR_fnptr(physicalDevice, surface, pPresentModeCount, pPresentModes);
        }
        public static VkResult CreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
        {
            return VkPointers._vkCreateSwapchainKHR_fnptr(device, pCreateInfo, pAllocator, pSwapchain);
        }
        public static void DestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySwapchainKHR_fnptr(device, swapchain, pAllocator);
        }
        public static VkResult GetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages)
        {
            return VkPointers._vkGetSwapchainImagesKHR_fnptr(device, swapchain, pSwapchainImageCount, pSwapchainImages);
        }
        public static VkResult AcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex)
        {
            return VkPointers._vkAcquireNextImageKHR_fnptr(device, swapchain, timeout, semaphore, fence, pImageIndex);
        }
        public static VkResult QueuePresentKHR(VkQueue queue, VkPresentInfoKHR* pPresentInfo)
        {
            return VkPointers._vkQueuePresentKHR_fnptr(queue, pPresentInfo);
        }
        public static VkResult CreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateViSurfaceNN_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult CreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateWaylandSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static int GetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display)
        {
            return VkPointers._vkGetPhysicalDeviceWaylandPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, display);
        }
        public static VkResult CreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateWin32SurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static int GetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
        {
            return VkPointers._vkGetPhysicalDeviceWin32PresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex);
        }
        public static VkResult CreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateXlibSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static int GetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, nuint visualID)
        {
            return VkPointers._vkGetPhysicalDeviceXlibPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, dpy, visualID);
        }
        public static VkResult CreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateXcbSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static int GetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, uint visual_id)
        {
            return VkPointers._vkGetPhysicalDeviceXcbPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, connection, visual_id);
        }
        public static VkResult CreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateDirectFBSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static int GetPhysicalDeviceDirectFBPresentationSupportEXT(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dfb)
        {
            return VkPointers._vkGetPhysicalDeviceDirectFBPresentationSupportEXT_fnptr(physicalDevice, queueFamilyIndex, dfb);
        }
        public static VkResult CreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateImagePipeSurfaceFUCHSIA_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult CreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateStreamDescriptorSurfaceGGP_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult CreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateScreenSurfaceQNX_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static int GetPhysicalDeviceScreenPresentationSupportQNX(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* window)
        {
            return VkPointers._vkGetPhysicalDeviceScreenPresentationSupportQNX_fnptr(physicalDevice, queueFamilyIndex, window);
        }
        public static VkResult CreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            return VkPointers._vkCreateDebugReportCallbackEXT_fnptr(instance, pCreateInfo, pAllocator, pCallback);
        }
        public static void DestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDebugReportCallbackEXT_fnptr(instance, callback, pAllocator);
        }
        public static void DebugReportMessageEXT(VkInstance instance, VkDebugReportFlagBitsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong obj, nuint location, int messageCode, byte* pLayerPrefix, byte* pMessage)
        {
            VkPointers._vkDebugReportMessageEXT_fnptr(instance, flags, objectType, obj, location, messageCode, pLayerPrefix, pMessage);
        }
        public static VkResult DebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)
        {
            return VkPointers._vkDebugMarkerSetObjectNameEXT_fnptr(device, pNameInfo);
        }
        public static VkResult DebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)
        {
            return VkPointers._vkDebugMarkerSetObjectTagEXT_fnptr(device, pTagInfo);
        }
        public static void CmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
        {
            VkPointers._vkCmdDebugMarkerBeginEXT_fnptr(commandBuffer, pMarkerInfo);
        }
        public static void CmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdDebugMarkerEndEXT_fnptr(commandBuffer);
        }
        public static void CmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
        {
            VkPointers._vkCmdDebugMarkerInsertEXT_fnptr(commandBuffer, pMarkerInfo);
        }
        public static VkResult GetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlagBits usage, VkImageCreateFlagBits flags, VkExternalMemoryHandleTypeFlagBitsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceExternalImageFormatPropertiesNV_fnptr(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);
        }
        public static VkResult GetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagBitsNV handleType, IntPtr* pHandle)
        {
            return VkPointers._vkGetMemoryWin32HandleNV_fnptr(device, memory, handleType, pHandle);
        }
        public static void CmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, int isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
        {
            VkPointers._vkCmdExecuteGeneratedCommandsNV_fnptr(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);
        }
        public static void CmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
        {
            VkPointers._vkCmdPreprocessGeneratedCommandsNV_fnptr(commandBuffer, pGeneratedCommandsInfo);
        }
        public static void CmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
        {
            VkPointers._vkCmdBindPipelineShaderGroupNV_fnptr(commandBuffer, pipelineBindPoint, pipeline, groupIndex);
        }
        public static void GetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetGeneratedCommandsMemoryRequirementsNV_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static VkResult CreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            return VkPointers._vkCreateIndirectCommandsLayoutNV_fnptr(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);
        }
        public static void DestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyIndirectCommandsLayoutNV_fnptr(device, indirectCommandsLayout, pAllocator);
        }
        public static void GetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures)
        {
            VkPointers._vkGetPhysicalDeviceFeatures2_fnptr(physicalDevice, pFeatures);
        }
        public static void GetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceProperties2_fnptr(physicalDevice, pProperties);
        }
        public static void GetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties)
        {
            VkPointers._vkGetPhysicalDeviceFormatProperties2_fnptr(physicalDevice, format, pFormatProperties);
        }
        public static VkResult GetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceImageFormatProperties2_fnptr(physicalDevice, pImageFormatInfo, pImageFormatProperties);
        }
        public static void GetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
        {
            VkPointers._vkGetPhysicalDeviceQueueFamilyProperties2_fnptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        public static void GetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties)
        {
            VkPointers._vkGetPhysicalDeviceMemoryProperties2_fnptr(physicalDevice, pMemoryProperties);
        }
        public static void GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceSparseImageFormatProperties2_fnptr(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
        }
        public static void CmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
        {
            VkPointers._vkCmdPushDescriptorSetKHR_fnptr(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
        }
        public static void TrimCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags)
        {
            VkPointers._vkTrimCommandPool_fnptr(device, commandPool, flags);
        }
        public static void GetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalBufferProperties_fnptr(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
        }
        public static VkResult GetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            return VkPointers._vkGetMemoryWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        public static VkResult GetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties)
        {
            return VkPointers._vkGetMemoryWin32HandlePropertiesKHR_fnptr(device, handleType, handle, pMemoryWin32HandleProperties);
        }
        public static VkResult GetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            return VkPointers._vkGetMemoryFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        public static VkResult GetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties)
        {
            return VkPointers._vkGetMemoryFdPropertiesKHR_fnptr(device, handleType, fd, pMemoryFdProperties);
        }
        public static VkResult GetMemoryZirconHandleFUCHSIA(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, int* pZirconHandle)
        {
            return VkPointers._vkGetMemoryZirconHandleFUCHSIA_fnptr(device, pGetZirconHandleInfo, pZirconHandle);
        }
        public static VkResult GetMemoryZirconHandlePropertiesFUCHSIA(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties)
        {
            return VkPointers._vkGetMemoryZirconHandlePropertiesFUCHSIA_fnptr(device, handleType, zirconHandle, pMemoryZirconHandleProperties);
        }
        public static VkResult GetMemoryRemoteAddressNV(VkDevice device, VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, void** pAddress)
        {
            return VkPointers._vkGetMemoryRemoteAddressNV_fnptr(device, pMemoryGetRemoteAddressInfo, pAddress);
        }
        public static VkResult GetMemorySciBufNV(VkDevice device, VkMemoryGetSciBufInfoNV* pGetSciBufInfo, IntPtr* pHandle)
        {
            return VkPointers._vkGetMemorySciBufNV_fnptr(device, pGetSciBufInfo, pHandle);
        }
        public static VkResult GetPhysicalDeviceExternalMemorySciBufPropertiesNV(VkPhysicalDevice physicalDevice, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, VkMemorySciBufPropertiesNV* pMemorySciBufProperties)
        {
            return VkPointers._vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_fnptr(physicalDevice, handleType, handle, pMemorySciBufProperties);
        }
        public static VkResult GetPhysicalDeviceSciBufAttributesNV(VkPhysicalDevice physicalDevice, IntPtr pAttributes)
        {
            return VkPointers._vkGetPhysicalDeviceSciBufAttributesNV_fnptr(physicalDevice, pAttributes);
        }
        public static void GetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalSemaphoreProperties_fnptr(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
        }
        public static VkResult GetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            return VkPointers._vkGetSemaphoreWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        public static VkResult ImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo)
        {
            return VkPointers._vkImportSemaphoreWin32HandleKHR_fnptr(device, pImportSemaphoreWin32HandleInfo);
        }
        public static VkResult GetSemaphoreFdKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            return VkPointers._vkGetSemaphoreFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        public static VkResult ImportSemaphoreFdKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo)
        {
            return VkPointers._vkImportSemaphoreFdKHR_fnptr(device, pImportSemaphoreFdInfo);
        }
        public static VkResult GetSemaphoreZirconHandleFUCHSIA(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, int* pZirconHandle)
        {
            return VkPointers._vkGetSemaphoreZirconHandleFUCHSIA_fnptr(device, pGetZirconHandleInfo, pZirconHandle);
        }
        public static VkResult ImportSemaphoreZirconHandleFUCHSIA(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo)
        {
            return VkPointers._vkImportSemaphoreZirconHandleFUCHSIA_fnptr(device, pImportSemaphoreZirconHandleInfo);
        }
        public static void GetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalFenceProperties_fnptr(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
        }
        public static VkResult GetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            return VkPointers._vkGetFenceWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        public static VkResult ImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
        {
            return VkPointers._vkImportFenceWin32HandleKHR_fnptr(device, pImportFenceWin32HandleInfo);
        }
        public static VkResult GetFenceFdKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            return VkPointers._vkGetFenceFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        public static VkResult ImportFenceFdKHR(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo)
        {
            return VkPointers._vkImportFenceFdKHR_fnptr(device, pImportFenceFdInfo);
        }
        public static VkResult GetFenceSciSyncFenceNV(VkDevice device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle)
        {
            return VkPointers._vkGetFenceSciSyncFenceNV_fnptr(device, pGetSciSyncHandleInfo, pHandle);
        }
        public static VkResult GetFenceSciSyncObjNV(VkDevice device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle)
        {
            return VkPointers._vkGetFenceSciSyncObjNV_fnptr(device, pGetSciSyncHandleInfo, pHandle);
        }
        public static VkResult ImportFenceSciSyncFenceNV(VkDevice device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo)
        {
            return VkPointers._vkImportFenceSciSyncFenceNV_fnptr(device, pImportFenceSciSyncInfo);
        }
        public static VkResult ImportFenceSciSyncObjNV(VkDevice device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo)
        {
            return VkPointers._vkImportFenceSciSyncObjNV_fnptr(device, pImportFenceSciSyncInfo);
        }
        public static VkResult GetSemaphoreSciSyncObjNV(VkDevice device, VkSemaphoreGetSciSyncInfoNV* pGetSciSyncInfo, void* pHandle)
        {
            return VkPointers._vkGetSemaphoreSciSyncObjNV_fnptr(device, pGetSciSyncInfo, pHandle);
        }
        public static VkResult ImportSemaphoreSciSyncObjNV(VkDevice device, VkImportSemaphoreSciSyncInfoNV* pImportSemaphoreSciSyncInfo)
        {
            return VkPointers._vkImportSemaphoreSciSyncObjNV_fnptr(device, pImportSemaphoreSciSyncInfo);
        }
        public static VkResult GetPhysicalDeviceSciSyncAttributesNV(VkPhysicalDevice physicalDevice, VkSciSyncAttributesInfoNV* pSciSyncAttributesInfo, IntPtr pAttributes)
        {
            return VkPointers._vkGetPhysicalDeviceSciSyncAttributesNV_fnptr(physicalDevice, pSciSyncAttributesInfo, pAttributes);
        }
        public static VkResult CreateSemaphoreSciSyncPoolNV(VkDevice device, VkSemaphoreSciSyncPoolCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphoreSciSyncPoolNV* pSemaphorePool)
        {
            return VkPointers._vkCreateSemaphoreSciSyncPoolNV_fnptr(device, pCreateInfo, pAllocator, pSemaphorePool);
        }
        public static void DestroySemaphoreSciSyncPoolNV(VkDevice device, VkSemaphoreSciSyncPoolNV semaphorePool, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySemaphoreSciSyncPoolNV_fnptr(device, semaphorePool, pAllocator);
        }
        public static VkResult ReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
        {
            return VkPointers._vkReleaseDisplayEXT_fnptr(physicalDevice, display);
        }
        public static VkResult AcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display)
        {
            return VkPointers._vkAcquireXlibDisplayEXT_fnptr(physicalDevice, dpy, display);
        }
        public static VkResult GetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, nuint rrOutput, VkDisplayKHR* pDisplay)
        {
            return VkPointers._vkGetRandROutputDisplayEXT_fnptr(physicalDevice, dpy, rrOutput, pDisplay);
        }
        public static VkResult AcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
        {
            return VkPointers._vkAcquireWinrtDisplayNV_fnptr(physicalDevice, display);
        }
        public static VkResult GetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, VkDisplayKHR* pDisplay)
        {
            return VkPointers._vkGetWinrtDisplayNV_fnptr(physicalDevice, deviceRelativeId, pDisplay);
        }
        public static VkResult DisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo)
        {
            return VkPointers._vkDisplayPowerControlEXT_fnptr(device, display, pDisplayPowerInfo);
        }
        public static VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            return VkPointers._vkRegisterDeviceEventEXT_fnptr(device, pDeviceEventInfo, pAllocator, pFence);
        }
        public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            return VkPointers._vkRegisterDisplayEventEXT_fnptr(device, display, pDisplayEventInfo, pAllocator, pFence);
        }
        public static VkResult GetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue)
        {
            return VkPointers._vkGetSwapchainCounterEXT_fnptr(device, swapchain, counter, pCounterValue);
        }
        public static VkResult GetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceCapabilities2EXT_fnptr(physicalDevice, surface, pSurfaceCapabilities);
        }
        public static VkResult EnumeratePhysicalDeviceGroups(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
        {
            return VkPointers._vkEnumeratePhysicalDeviceGroups_fnptr(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
        }
        public static void GetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlagBits* pPeerMemoryFeatures)
        {
            VkPointers._vkGetDeviceGroupPeerMemoryFeatures_fnptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
        }
        public static VkResult BindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
        {
            return VkPointers._vkBindBufferMemory2_fnptr(device, bindInfoCount, pBindInfos);
        }
        public static VkResult BindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
        {
            return VkPointers._vkBindImageMemory2_fnptr(device, bindInfoCount, pBindInfos);
        }
        public static void CmdSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask)
        {
            VkPointers._vkCmdSetDeviceMask_fnptr(commandBuffer, deviceMask);
        }
        public static VkResult GetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities)
        {
            return VkPointers._vkGetDeviceGroupPresentCapabilitiesKHR_fnptr(device, pDeviceGroupPresentCapabilities);
        }
        public static VkResult GetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagBitsKHR* pModes)
        {
            return VkPointers._vkGetDeviceGroupSurfacePresentModesKHR_fnptr(device, surface, pModes);
        }
        public static VkResult AcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex)
        {
            return VkPointers._vkAcquireNextImage2KHR_fnptr(device, pAcquireInfo, pImageIndex);
        }
        public static void CmdDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDispatchBase_fnptr(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
        }
        public static VkResult GetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects)
        {
            return VkPointers._vkGetPhysicalDevicePresentRectanglesKHR_fnptr(physicalDevice, surface, pRectCount, pRects);
        }
        public static VkResult CreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate)
        {
            return VkPointers._vkCreateDescriptorUpdateTemplate_fnptr(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
        }
        public static void DestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDescriptorUpdateTemplate_fnptr(device, descriptorUpdateTemplate, pAllocator);
        }
        public static void UpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
        {
            VkPointers._vkUpdateDescriptorSetWithTemplate_fnptr(device, descriptorSet, descriptorUpdateTemplate, pData);
        }
        public static void CmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
        {
            VkPointers._vkCmdPushDescriptorSetWithTemplateKHR_fnptr(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
        }
        public static void SetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata)
        {
            VkPointers._vkSetHdrMetadataEXT_fnptr(device, swapchainCount, pSwapchains, pMetadata);
        }
        public static VkResult GetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain)
        {
            return VkPointers._vkGetSwapchainStatusKHR_fnptr(device, swapchain);
        }
        public static VkResult GetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties)
        {
            return VkPointers._vkGetRefreshCycleDurationGOOGLE_fnptr(device, swapchain, pDisplayTimingProperties);
        }
        public static VkResult GetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
        {
            return VkPointers._vkGetPastPresentationTimingGOOGLE_fnptr(device, swapchain, pPresentationTimingCount, pPresentationTimings);
        }
        public static VkResult CreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateIOSSurfaceMVK_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult CreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateMacOSSurfaceMVK_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult CreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateMetalSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static void CmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
        {
            VkPointers._vkCmdSetViewportWScalingNV_fnptr(commandBuffer, firstViewport, viewportCount, pViewportWScalings);
        }
        public static void CmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
        {
            VkPointers._vkCmdSetDiscardRectangleEXT_fnptr(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);
        }
        public static void CmdSetDiscardRectangleEnableEXT(VkCommandBuffer commandBuffer, int discardRectangleEnable)
        {
            VkPointers._vkCmdSetDiscardRectangleEnableEXT_fnptr(commandBuffer, discardRectangleEnable);
        }
        public static void CmdSetDiscardRectangleModeEXT(VkCommandBuffer commandBuffer, VkDiscardRectangleModeEXT discardRectangleMode)
        {
            VkPointers._vkCmdSetDiscardRectangleModeEXT_fnptr(commandBuffer, discardRectangleMode);
        }
        public static void CmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo)
        {
            VkPointers._vkCmdSetSampleLocationsEXT_fnptr(commandBuffer, pSampleLocationsInfo);
        }
        public static void GetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT* pMultisampleProperties)
        {
            VkPointers._vkGetPhysicalDeviceMultisamplePropertiesEXT_fnptr(physicalDevice, samples, pMultisampleProperties);
        }
        public static VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceCapabilities2KHR_fnptr(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);
        }
        public static VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceFormats2KHR_fnptr(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);
        }
        public static VkResult GetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceDisplayProperties2KHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static VkResult GetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceDisplayPlaneProperties2KHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static VkResult GetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
        {
            return VkPointers._vkGetDisplayModeProperties2KHR_fnptr(physicalDevice, display, pPropertyCount, pProperties);
        }
        public static VkResult GetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
        {
            return VkPointers._vkGetDisplayPlaneCapabilities2KHR_fnptr(physicalDevice, pDisplayPlaneInfo, pCapabilities);
        }
        public static void GetBufferMemoryRequirements2(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetBufferMemoryRequirements2_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static void GetImageMemoryRequirements2(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetImageMemoryRequirements2_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static void GetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            VkPointers._vkGetImageSparseMemoryRequirements2_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        public static void GetDeviceBufferMemoryRequirements(VkDevice device, VkDeviceBufferMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetDeviceBufferMemoryRequirements_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static void GetDeviceImageMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetDeviceImageMemoryRequirements_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static void GetDeviceImageSparseMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            VkPointers._vkGetDeviceImageSparseMemoryRequirements_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        public static VkResult CreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion)
        {
            return VkPointers._vkCreateSamplerYcbcrConversion_fnptr(device, pCreateInfo, pAllocator, pYcbcrConversion);
        }
        public static void DestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySamplerYcbcrConversion_fnptr(device, ycbcrConversion, pAllocator);
        }
        public static void GetDeviceQueue2(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue)
        {
            VkPointers._vkGetDeviceQueue2_fnptr(device, pQueueInfo, pQueue);
        }
        public static VkResult CreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            return VkPointers._vkCreateValidationCacheEXT_fnptr(device, pCreateInfo, pAllocator, pValidationCache);
        }
        public static void DestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyValidationCacheEXT_fnptr(device, validationCache, pAllocator);
        }
        public static VkResult GetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, nuint* pDataSize, void* pData)
        {
            return VkPointers._vkGetValidationCacheDataEXT_fnptr(device, validationCache, pDataSize, pData);
        }
        public static VkResult MergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches)
        {
            return VkPointers._vkMergeValidationCachesEXT_fnptr(device, dstCache, srcCacheCount, pSrcCaches);
        }
        public static void GetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
        {
            VkPointers._vkGetDescriptorSetLayoutSupport_fnptr(device, pCreateInfo, pSupport);
        }
        public static VkResult GetSwapchainGrallocUsageANDROID(VkDevice device, VkFormat format, VkImageUsageFlagBits imageUsage, int* grallocUsage)
        {
            return VkPointers._vkGetSwapchainGrallocUsageANDROID_fnptr(device, format, imageUsage, grallocUsage);
        }
        public static VkResult GetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlagBits imageUsage, VkSwapchainImageUsageFlagBitsANDROID swapchainImageUsage, ulong* grallocConsumerUsage, ulong* grallocProducerUsage)
        {
            return VkPointers._vkGetSwapchainGrallocUsage2ANDROID_fnptr(device, format, imageUsage, swapchainImageUsage, grallocConsumerUsage, grallocProducerUsage);
        }
        public static VkResult AcquireImageANDROID(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence)
        {
            return VkPointers._vkAcquireImageANDROID_fnptr(device, image, nativeFenceFd, semaphore, fence);
        }
        public static VkResult QueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, int* pNativeFenceFd)
        {
            return VkPointers._vkQueueSignalReleaseImageANDROID_fnptr(queue, waitSemaphoreCount, pWaitSemaphores, image, pNativeFenceFd);
        }
        public static VkResult GetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, nuint* pInfoSize, void* pInfo)
        {
            return VkPointers._vkGetShaderInfoAMD_fnptr(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);
        }
        public static void SetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, int localDimmingEnable)
        {
            VkPointers._vkSetLocalDimmingAMD_fnptr(device, swapChain, localDimmingEnable);
        }
        public static VkResult GetPhysicalDeviceCalibrateableTimeDomainsKHR(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainKHR* pTimeDomains)
        {
            return VkPointers._vkGetPhysicalDeviceCalibrateableTimeDomainsKHR_fnptr(physicalDevice, pTimeDomainCount, pTimeDomains);
        }
        public static VkResult GetCalibratedTimestampsKHR(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoKHR* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
        {
            return VkPointers._vkGetCalibratedTimestampsKHR_fnptr(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);
        }
        public static VkResult SetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo)
        {
            return VkPointers._vkSetDebugUtilsObjectNameEXT_fnptr(device, pNameInfo);
        }
        public static VkResult SetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo)
        {
            return VkPointers._vkSetDebugUtilsObjectTagEXT_fnptr(device, pTagInfo);
        }
        public static void QueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            VkPointers._vkQueueBeginDebugUtilsLabelEXT_fnptr(queue, pLabelInfo);
        }
        public static void QueueEndDebugUtilsLabelEXT(VkQueue queue)
        {
            VkPointers._vkQueueEndDebugUtilsLabelEXT_fnptr(queue);
        }
        public static void QueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            VkPointers._vkQueueInsertDebugUtilsLabelEXT_fnptr(queue, pLabelInfo);
        }
        public static void CmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            VkPointers._vkCmdBeginDebugUtilsLabelEXT_fnptr(commandBuffer, pLabelInfo);
        }
        public static void CmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdEndDebugUtilsLabelEXT_fnptr(commandBuffer);
        }
        public static void CmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            VkPointers._vkCmdInsertDebugUtilsLabelEXT_fnptr(commandBuffer, pLabelInfo);
        }
        public static VkResult CreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            return VkPointers._vkCreateDebugUtilsMessengerEXT_fnptr(instance, pCreateInfo, pAllocator, pMessenger);
        }
        public static void DestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDebugUtilsMessengerEXT_fnptr(instance, messenger, pAllocator);
        }
        public static void SubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagBitsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData)
        {
            VkPointers._vkSubmitDebugUtilsMessageEXT_fnptr(instance, messageSeverity, messageTypes, pCallbackData);
        }
        public static VkResult GetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties)
        {
            return VkPointers._vkGetMemoryHostPointerPropertiesEXT_fnptr(device, handleType, pHostPointer, pMemoryHostPointerProperties);
        }
        public static void CmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
        {
            VkPointers._vkCmdWriteBufferMarkerAMD_fnptr(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
        }
        public static VkResult CreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
        {
            return VkPointers._vkCreateRenderPass2_fnptr(device, pCreateInfo, pAllocator, pRenderPass);
        }
        public static void CmdBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo)
        {
            VkPointers._vkCmdBeginRenderPass2_fnptr(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
        }
        public static void CmdNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo)
        {
            VkPointers._vkCmdNextSubpass2_fnptr(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
        }
        public static void CmdEndRenderPass2(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo)
        {
            VkPointers._vkCmdEndRenderPass2_fnptr(commandBuffer, pSubpassEndInfo);
        }
        public static VkResult GetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, ulong* pValue)
        {
            return VkPointers._vkGetSemaphoreCounterValue_fnptr(device, semaphore, pValue);
        }
        public static VkResult WaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
        {
            return VkPointers._vkWaitSemaphores_fnptr(device, pWaitInfo, timeout);
        }
        public static VkResult SignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo)
        {
            return VkPointers._vkSignalSemaphore_fnptr(device, pSignalInfo);
        }
        public static VkResult GetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
        {
            return VkPointers._vkGetAndroidHardwareBufferPropertiesANDROID_fnptr(device, buffer, pProperties);
        }
        public static VkResult GetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, IntPtr* pBuffer)
        {
            return VkPointers._vkGetMemoryAndroidHardwareBufferANDROID_fnptr(device, pInfo, pBuffer);
        }
        public static void CmdDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndirectCount_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        public static void CmdDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndexedIndirectCount_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        public static void CmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
        {
            VkPointers._vkCmdSetCheckpointNV_fnptr(commandBuffer, pCheckpointMarker);
        }
        public static void GetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
        {
            VkPointers._vkGetQueueCheckpointDataNV_fnptr(queue, pCheckpointDataCount, pCheckpointData);
        }
        public static void CmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes)
        {
            VkPointers._vkCmdBindTransformFeedbackBuffersEXT_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);
        }
        public static void CmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            VkPointers._vkCmdBeginTransformFeedbackEXT_fnptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
        }
        public static void CmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            VkPointers._vkCmdEndTransformFeedbackEXT_fnptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
        }
        public static void CmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlagBits flags, uint index)
        {
            VkPointers._vkCmdBeginQueryIndexedEXT_fnptr(commandBuffer, queryPool, query, flags, index);
        }
        public static void CmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index)
        {
            VkPointers._vkCmdEndQueryIndexedEXT_fnptr(commandBuffer, queryPool, query, index);
        }
        public static void CmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
        {
            VkPointers._vkCmdDrawIndirectByteCountEXT_fnptr(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
        }
        public static void CmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
        {
            VkPointers._vkCmdSetExclusiveScissorNV_fnptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);
        }
        public static void CmdSetExclusiveScissorEnableNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, int* pExclusiveScissorEnables)
        {
            VkPointers._vkCmdSetExclusiveScissorEnableNV_fnptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissorEnables);
        }
        public static void CmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
        {
            VkPointers._vkCmdBindShadingRateImageNV_fnptr(commandBuffer, imageView, imageLayout);
        }
        public static void CmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
        {
            VkPointers._vkCmdSetViewportShadingRatePaletteNV_fnptr(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);
        }
        public static void CmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
        {
            VkPointers._vkCmdSetCoarseSampleOrderNV_fnptr(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
        }
        public static void CmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask)
        {
            VkPointers._vkCmdDrawMeshTasksNV_fnptr(commandBuffer, taskCount, firstTask);
        }
        public static void CmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            VkPointers._vkCmdDrawMeshTasksIndirectNV_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        public static void CmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawMeshTasksIndirectCountNV_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        public static void CmdDrawMeshTasksEXT(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDrawMeshTasksEXT_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        public static void CmdDrawMeshTasksIndirectEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            VkPointers._vkCmdDrawMeshTasksIndirectEXT_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        public static void CmdDrawMeshTasksIndirectCountEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawMeshTasksIndirectCountEXT_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        public static VkResult CompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader)
        {
            return VkPointers._vkCompileDeferredNV_fnptr(device, pipeline, shader);
        }
        public static VkResult CreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            return VkPointers._vkCreateAccelerationStructureNV_fnptr(device, pCreateInfo, pAllocator, pAccelerationStructure);
        }
        public static void CmdBindInvocationMaskHUAWEI(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
        {
            VkPointers._vkCmdBindInvocationMaskHUAWEI_fnptr(commandBuffer, imageView, imageLayout);
        }
        public static void DestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyAccelerationStructureKHR_fnptr(device, accelerationStructure, pAllocator);
        }
        public static void DestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyAccelerationStructureNV_fnptr(device, accelerationStructure, pAllocator);
        }
        public static void GetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2KHR* pMemoryRequirements)
        {
            VkPointers._vkGetAccelerationStructureMemoryRequirementsNV_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static VkResult BindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
        {
            return VkPointers._vkBindAccelerationStructureMemoryNV_fnptr(device, bindInfoCount, pBindInfos);
        }
        public static void CmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode)
        {
            VkPointers._vkCmdCopyAccelerationStructureNV_fnptr(commandBuffer, dst, src, mode);
        }
        public static void CmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo)
        {
            VkPointers._vkCmdCopyAccelerationStructureKHR_fnptr(commandBuffer, pInfo);
        }
        public static VkResult CopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo)
        {
            return VkPointers._vkCopyAccelerationStructureKHR_fnptr(device, deferredOperation, pInfo);
        }
        public static void CmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
        {
            VkPointers._vkCmdCopyAccelerationStructureToMemoryKHR_fnptr(commandBuffer, pInfo);
        }
        public static VkResult CopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
        {
            return VkPointers._vkCopyAccelerationStructureToMemoryKHR_fnptr(device, deferredOperation, pInfo);
        }
        public static void CmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
        {
            VkPointers._vkCmdCopyMemoryToAccelerationStructureKHR_fnptr(commandBuffer, pInfo);
        }
        public static VkResult CopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
        {
            return VkPointers._vkCopyMemoryToAccelerationStructureKHR_fnptr(device, deferredOperation, pInfo);
        }
        public static void CmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            VkPointers._vkCmdWriteAccelerationStructuresPropertiesKHR_fnptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
        public static void CmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            VkPointers._vkCmdWriteAccelerationStructuresPropertiesNV_fnptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
        public static void CmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, ulong instanceOffset, int update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
        {
            VkPointers._vkCmdBuildAccelerationStructureNV_fnptr(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
        }
        public static VkResult WriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, nuint dataSize, void* pData, nuint stride)
        {
            return VkPointers._vkWriteAccelerationStructuresPropertiesKHR_fnptr(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);
        }
        public static void CmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            VkPointers._vkCmdTraceRaysKHR_fnptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }
        public static void CmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
        {
            VkPointers._vkCmdTraceRaysNV_fnptr(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
        }
        public static VkResult GetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
        {
            return VkPointers._vkGetRayTracingShaderGroupHandlesKHR_fnptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        public static VkResult GetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
        {
            return VkPointers._vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_fnptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        public static VkResult GetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* pData)
        {
            return VkPointers._vkGetAccelerationStructureHandleNV_fnptr(device, accelerationStructure, dataSize, pData);
        }
        public static VkResult CreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return VkPointers._vkCreateRayTracingPipelinesNV_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static VkResult CreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return VkPointers._vkCreateRayTracingPipelinesKHR_fnptr(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static void CmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            VkPointers._vkCmdTraceRaysIndirectKHR_fnptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
        }
        public static void CmdTraceRaysIndirect2KHR(VkCommandBuffer commandBuffer, ulong indirectDeviceAddress)
        {
            VkPointers._vkCmdTraceRaysIndirect2KHR_fnptr(commandBuffer, indirectDeviceAddress);
        }
        public static void GetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            VkPointers._vkGetDeviceAccelerationStructureCompatibilityKHR_fnptr(device, pVersionInfo, pCompatibility);
        }
        public static ulong GetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader)
        {
            return VkPointers._vkGetRayTracingShaderGroupStackSizeKHR_fnptr(device, pipeline, group, groupShader);
        }
        public static void CmdSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, uint pipelineStackSize)
        {
            VkPointers._vkCmdSetRayTracingPipelineStackSizeKHR_fnptr(commandBuffer, pipelineStackSize);
        }
        public static uint GetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
        {
            return VkPointers._vkGetImageViewHandleNVX_fnptr(device, pInfo);
        }
        public static VkResult GetImageViewAddressNVX(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties)
        {
            return VkPointers._vkGetImageViewAddressNVX_fnptr(device, imageView, pProperties);
        }
        public static VkResult GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            return VkPointers._vkGetPhysicalDeviceSurfacePresentModes2EXT_fnptr(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);
        }
        public static VkResult GetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagBitsKHR* pModes)
        {
            return VkPointers._vkGetDeviceGroupSurfacePresentModes2EXT_fnptr(device, pSurfaceInfo, pModes);
        }
        public static VkResult AcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
        {
            return VkPointers._vkAcquireFullScreenExclusiveModeEXT_fnptr(device, swapchain);
        }
        public static VkResult ReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
        {
            return VkPointers._vkReleaseFullScreenExclusiveModeEXT_fnptr(device, swapchain);
        }
        public static VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            return VkPointers._vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_fnptr(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);
        }
        public static void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses)
        {
            VkPointers._vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_fnptr(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);
        }
        public static VkResult AcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo)
        {
            return VkPointers._vkAcquireProfilingLockKHR_fnptr(device, pInfo);
        }
        public static void ReleaseProfilingLockKHR(VkDevice device)
        {
            VkPointers._vkReleaseProfilingLockKHR_fnptr(device);
        }
        public static VkResult GetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
        {
            return VkPointers._vkGetImageDrmFormatModifierPropertiesEXT_fnptr(device, image, pProperties);
        }
        public static ulong GetBufferOpaqueCaptureAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            return VkPointers._vkGetBufferOpaqueCaptureAddress_fnptr(device, pInfo);
        }
        public static ulong GetBufferDeviceAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            return VkPointers._vkGetBufferDeviceAddress_fnptr(device, pInfo);
        }
        public static VkResult CreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateHeadlessSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
        {
            return VkPointers._vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_fnptr(physicalDevice, pCombinationCount, pCombinations);
        }
        public static VkResult InitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo)
        {
            return VkPointers._vkInitializePerformanceApiINTEL_fnptr(device, pInitializeInfo);
        }
        public static void UninitializePerformanceApiINTEL(VkDevice device)
        {
            VkPointers._vkUninitializePerformanceApiINTEL_fnptr(device);
        }
        public static VkResult CmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo)
        {
            return VkPointers._vkCmdSetPerformanceMarkerINTEL_fnptr(commandBuffer, pMarkerInfo);
        }
        public static VkResult CmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo)
        {
            return VkPointers._vkCmdSetPerformanceStreamMarkerINTEL_fnptr(commandBuffer, pMarkerInfo);
        }
        public static VkResult CmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo)
        {
            return VkPointers._vkCmdSetPerformanceOverrideINTEL_fnptr(commandBuffer, pOverrideInfo);
        }
        public static VkResult AcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
        {
            return VkPointers._vkAcquirePerformanceConfigurationINTEL_fnptr(device, pAcquireInfo, pConfiguration);
        }
        public static VkResult ReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration)
        {
            return VkPointers._vkReleasePerformanceConfigurationINTEL_fnptr(device, configuration);
        }
        public static VkResult QueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
        {
            return VkPointers._vkQueueSetPerformanceConfigurationINTEL_fnptr(queue, configuration);
        }
        public static VkResult GetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
        {
            return VkPointers._vkGetPerformanceParameterINTEL_fnptr(device, parameter, pValue);
        }
        public static ulong GetDeviceMemoryOpaqueCaptureAddress(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
        {
            return VkPointers._vkGetDeviceMemoryOpaqueCaptureAddress_fnptr(device, pInfo);
        }
        public static VkResult GetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            return VkPointers._vkGetPipelineExecutablePropertiesKHR_fnptr(device, pPipelineInfo, pExecutableCount, pProperties);
        }
        public static VkResult GetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            return VkPointers._vkGetPipelineExecutableStatisticsKHR_fnptr(device, pExecutableInfo, pStatisticCount, pStatistics);
        }
        public static VkResult GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            return VkPointers._vkGetPipelineExecutableInternalRepresentationsKHR_fnptr(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);
        }
        public static void CmdSetLineStippleKHR(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
        {
            VkPointers._vkCmdSetLineStippleKHR_fnptr(commandBuffer, lineStippleFactor, lineStipplePattern);
        }
        public static VkResult GetFaultData(VkDevice device, VkFaultQueryBehavior faultQueryBehavior, int* pUnrecordedFaults, uint* pFaultCount, VkFaultData* pFaults)
        {
            return VkPointers._vkGetFaultData_fnptr(device, faultQueryBehavior, pUnrecordedFaults, pFaultCount, pFaults);
        }
        public static VkResult GetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
        {
            return VkPointers._vkGetPhysicalDeviceToolProperties_fnptr(physicalDevice, pToolCount, pToolProperties);
        }
        public static VkResult CreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            return VkPointers._vkCreateAccelerationStructureKHR_fnptr(device, pCreateInfo, pAllocator, pAccelerationStructure);
        }
        public static void CmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            VkPointers._vkCmdBuildAccelerationStructuresKHR_fnptr(commandBuffer, infoCount, pInfos, ppBuildRangeInfos);
        }
        public static void CmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            VkPointers._vkCmdBuildAccelerationStructuresIndirectKHR_fnptr(commandBuffer, infoCount, pInfos, pIndirectDeviceAddresses, pIndirectStrides, ppMaxPrimitiveCounts);
        }
        public static VkResult BuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            return VkPointers._vkBuildAccelerationStructuresKHR_fnptr(device, deferredOperation, infoCount, pInfos, ppBuildRangeInfos);
        }
        public static ulong GetAccelerationStructureDeviceAddressKHR(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo)
        {
            return VkPointers._vkGetAccelerationStructureDeviceAddressKHR_fnptr(device, pInfo);
        }
        public static VkResult CreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation)
        {
            return VkPointers._vkCreateDeferredOperationKHR_fnptr(device, pAllocator, pDeferredOperation);
        }
        public static void DestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDeferredOperationKHR_fnptr(device, operation, pAllocator);
        }
        public static uint GetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation)
        {
            return VkPointers._vkGetDeferredOperationMaxConcurrencyKHR_fnptr(device, operation);
        }
        public static VkResult GetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation)
        {
            return VkPointers._vkGetDeferredOperationResultKHR_fnptr(device, operation);
        }
        public static VkResult DeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation)
        {
            return VkPointers._vkDeferredOperationJoinKHR_fnptr(device, operation);
        }
        public static void GetPipelineIndirectMemoryRequirementsNV(VkDevice device, VkComputePipelineCreateInfo* pCreateInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetPipelineIndirectMemoryRequirementsNV_fnptr(device, pCreateInfo, pMemoryRequirements);
        }
        public static ulong GetPipelineIndirectDeviceAddressNV(VkDevice device, VkPipelineIndirectDeviceAddressInfoNV* pInfo)
        {
            return VkPointers._vkGetPipelineIndirectDeviceAddressNV_fnptr(device, pInfo);
        }
        public static void CmdSetCullMode(VkCommandBuffer commandBuffer, VkCullModeFlagBits cullMode)
        {
            VkPointers._vkCmdSetCullMode_fnptr(commandBuffer, cullMode);
        }
        public static void CmdSetFrontFace(VkCommandBuffer commandBuffer, VkFrontFace frontFace)
        {
            VkPointers._vkCmdSetFrontFace_fnptr(commandBuffer, frontFace);
        }
        public static void CmdSetPrimitiveTopology(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology)
        {
            VkPointers._vkCmdSetPrimitiveTopology_fnptr(commandBuffer, primitiveTopology);
        }
        public static void CmdSetViewportWithCount(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports)
        {
            VkPointers._vkCmdSetViewportWithCount_fnptr(commandBuffer, viewportCount, pViewports);
        }
        public static void CmdSetScissorWithCount(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors)
        {
            VkPointers._vkCmdSetScissorWithCount_fnptr(commandBuffer, scissorCount, pScissors);
        }
        public static void CmdBindIndexBuffer2KHR(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, ulong size, VkIndexType indexType)
        {
            VkPointers._vkCmdBindIndexBuffer2KHR_fnptr(commandBuffer, buffer, offset, size, indexType);
        }
        public static void CmdBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes, ulong* pStrides)
        {
            VkPointers._vkCmdBindVertexBuffers2_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
        }
        public static void CmdSetDepthTestEnable(VkCommandBuffer commandBuffer, int depthTestEnable)
        {
            VkPointers._vkCmdSetDepthTestEnable_fnptr(commandBuffer, depthTestEnable);
        }
        public static void CmdSetDepthWriteEnable(VkCommandBuffer commandBuffer, int depthWriteEnable)
        {
            VkPointers._vkCmdSetDepthWriteEnable_fnptr(commandBuffer, depthWriteEnable);
        }
        public static void CmdSetDepthCompareOp(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp)
        {
            VkPointers._vkCmdSetDepthCompareOp_fnptr(commandBuffer, depthCompareOp);
        }
        public static void CmdSetDepthBoundsTestEnable(VkCommandBuffer commandBuffer, int depthBoundsTestEnable)
        {
            VkPointers._vkCmdSetDepthBoundsTestEnable_fnptr(commandBuffer, depthBoundsTestEnable);
        }
        public static void CmdSetStencilTestEnable(VkCommandBuffer commandBuffer, int stencilTestEnable)
        {
            VkPointers._vkCmdSetStencilTestEnable_fnptr(commandBuffer, stencilTestEnable);
        }
        public static void CmdSetStencilOp(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
        {
            VkPointers._vkCmdSetStencilOp_fnptr(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
        }
        public static void CmdSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, uint patchControlPoints)
        {
            VkPointers._vkCmdSetPatchControlPointsEXT_fnptr(commandBuffer, patchControlPoints);
        }
        public static void CmdSetRasterizerDiscardEnable(VkCommandBuffer commandBuffer, int rasterizerDiscardEnable)
        {
            VkPointers._vkCmdSetRasterizerDiscardEnable_fnptr(commandBuffer, rasterizerDiscardEnable);
        }
        public static void CmdSetDepthBiasEnable(VkCommandBuffer commandBuffer, int depthBiasEnable)
        {
            VkPointers._vkCmdSetDepthBiasEnable_fnptr(commandBuffer, depthBiasEnable);
        }
        public static void CmdSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp)
        {
            VkPointers._vkCmdSetLogicOpEXT_fnptr(commandBuffer, logicOp);
        }
        public static void CmdSetPrimitiveRestartEnable(VkCommandBuffer commandBuffer, int primitiveRestartEnable)
        {
            VkPointers._vkCmdSetPrimitiveRestartEnable_fnptr(commandBuffer, primitiveRestartEnable);
        }
        public static void CmdSetTessellationDomainOriginEXT(VkCommandBuffer commandBuffer, VkTessellationDomainOrigin domainOrigin)
        {
            VkPointers._vkCmdSetTessellationDomainOriginEXT_fnptr(commandBuffer, domainOrigin);
        }
        public static void CmdSetDepthClampEnableEXT(VkCommandBuffer commandBuffer, int depthClampEnable)
        {
            VkPointers._vkCmdSetDepthClampEnableEXT_fnptr(commandBuffer, depthClampEnable);
        }
        public static void CmdSetPolygonModeEXT(VkCommandBuffer commandBuffer, VkPolygonMode polygonMode)
        {
            VkPointers._vkCmdSetPolygonModeEXT_fnptr(commandBuffer, polygonMode);
        }
        public static void CmdSetRasterizationSamplesEXT(VkCommandBuffer commandBuffer, VkSampleCountFlagBits rasterizationSamples)
        {
            VkPointers._vkCmdSetRasterizationSamplesEXT_fnptr(commandBuffer, rasterizationSamples);
        }
        public static void CmdSetSampleMaskEXT(VkCommandBuffer commandBuffer, VkSampleCountFlagBits samples, uint* pSampleMask)
        {
            VkPointers._vkCmdSetSampleMaskEXT_fnptr(commandBuffer, samples, pSampleMask);
        }
        public static void CmdSetAlphaToCoverageEnableEXT(VkCommandBuffer commandBuffer, int alphaToCoverageEnable)
        {
            VkPointers._vkCmdSetAlphaToCoverageEnableEXT_fnptr(commandBuffer, alphaToCoverageEnable);
        }
        public static void CmdSetAlphaToOneEnableEXT(VkCommandBuffer commandBuffer, int alphaToOneEnable)
        {
            VkPointers._vkCmdSetAlphaToOneEnableEXT_fnptr(commandBuffer, alphaToOneEnable);
        }
        public static void CmdSetLogicOpEnableEXT(VkCommandBuffer commandBuffer, int logicOpEnable)
        {
            VkPointers._vkCmdSetLogicOpEnableEXT_fnptr(commandBuffer, logicOpEnable);
        }
        public static void CmdSetColorBlendEnableEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, int* pColorBlendEnables)
        {
            VkPointers._vkCmdSetColorBlendEnableEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEnables);
        }
        public static void CmdSetColorBlendEquationEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendEquationEXT* pColorBlendEquations)
        {
            VkPointers._vkCmdSetColorBlendEquationEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEquations);
        }
        public static void CmdSetColorWriteMaskEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorComponentFlagBits* pColorWriteMasks)
        {
            VkPointers._vkCmdSetColorWriteMaskEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorWriteMasks);
        }
        public static void CmdSetRasterizationStreamEXT(VkCommandBuffer commandBuffer, uint rasterizationStream)
        {
            VkPointers._vkCmdSetRasterizationStreamEXT_fnptr(commandBuffer, rasterizationStream);
        }
        public static void CmdSetConservativeRasterizationModeEXT(VkCommandBuffer commandBuffer, VkConservativeRasterizationModeEXT conservativeRasterizationMode)
        {
            VkPointers._vkCmdSetConservativeRasterizationModeEXT_fnptr(commandBuffer, conservativeRasterizationMode);
        }
        public static void CmdSetExtraPrimitiveOverestimationSizeEXT(VkCommandBuffer commandBuffer, float extraPrimitiveOverestimationSize)
        {
            VkPointers._vkCmdSetExtraPrimitiveOverestimationSizeEXT_fnptr(commandBuffer, extraPrimitiveOverestimationSize);
        }
        public static void CmdSetDepthClipEnableEXT(VkCommandBuffer commandBuffer, int depthClipEnable)
        {
            VkPointers._vkCmdSetDepthClipEnableEXT_fnptr(commandBuffer, depthClipEnable);
        }
        public static void CmdSetSampleLocationsEnableEXT(VkCommandBuffer commandBuffer, int sampleLocationsEnable)
        {
            VkPointers._vkCmdSetSampleLocationsEnableEXT_fnptr(commandBuffer, sampleLocationsEnable);
        }
        public static void CmdSetColorBlendAdvancedEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendAdvancedEXT* pColorBlendAdvanced)
        {
            VkPointers._vkCmdSetColorBlendAdvancedEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendAdvanced);
        }
        public static void CmdSetProvokingVertexModeEXT(VkCommandBuffer commandBuffer, VkProvokingVertexModeEXT provokingVertexMode)
        {
            VkPointers._vkCmdSetProvokingVertexModeEXT_fnptr(commandBuffer, provokingVertexMode);
        }
        public static void CmdSetLineRasterizationModeEXT(VkCommandBuffer commandBuffer, VkLineRasterizationModeKHR lineRasterizationMode)
        {
            VkPointers._vkCmdSetLineRasterizationModeEXT_fnptr(commandBuffer, lineRasterizationMode);
        }
        public static void CmdSetLineStippleEnableEXT(VkCommandBuffer commandBuffer, int stippledLineEnable)
        {
            VkPointers._vkCmdSetLineStippleEnableEXT_fnptr(commandBuffer, stippledLineEnable);
        }
        public static void CmdSetDepthClipNegativeOneToOneEXT(VkCommandBuffer commandBuffer, int negativeOneToOne)
        {
            VkPointers._vkCmdSetDepthClipNegativeOneToOneEXT_fnptr(commandBuffer, negativeOneToOne);
        }
        public static void CmdSetViewportWScalingEnableNV(VkCommandBuffer commandBuffer, int viewportWScalingEnable)
        {
            VkPointers._vkCmdSetViewportWScalingEnableNV_fnptr(commandBuffer, viewportWScalingEnable);
        }
        public static void CmdSetViewportSwizzleNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportSwizzleNV* pViewportSwizzles)
        {
            VkPointers._vkCmdSetViewportSwizzleNV_fnptr(commandBuffer, firstViewport, viewportCount, pViewportSwizzles);
        }
        public static void CmdSetCoverageToColorEnableNV(VkCommandBuffer commandBuffer, int coverageToColorEnable)
        {
            VkPointers._vkCmdSetCoverageToColorEnableNV_fnptr(commandBuffer, coverageToColorEnable);
        }
        public static void CmdSetCoverageToColorLocationNV(VkCommandBuffer commandBuffer, uint coverageToColorLocation)
        {
            VkPointers._vkCmdSetCoverageToColorLocationNV_fnptr(commandBuffer, coverageToColorLocation);
        }
        public static void CmdSetCoverageModulationModeNV(VkCommandBuffer commandBuffer, VkCoverageModulationModeNV coverageModulationMode)
        {
            VkPointers._vkCmdSetCoverageModulationModeNV_fnptr(commandBuffer, coverageModulationMode);
        }
        public static void CmdSetCoverageModulationTableEnableNV(VkCommandBuffer commandBuffer, int coverageModulationTableEnable)
        {
            VkPointers._vkCmdSetCoverageModulationTableEnableNV_fnptr(commandBuffer, coverageModulationTableEnable);
        }
        public static void CmdSetCoverageModulationTableNV(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, float* pCoverageModulationTable)
        {
            VkPointers._vkCmdSetCoverageModulationTableNV_fnptr(commandBuffer, coverageModulationTableCount, pCoverageModulationTable);
        }
        public static void CmdSetShadingRateImageEnableNV(VkCommandBuffer commandBuffer, int shadingRateImageEnable)
        {
            VkPointers._vkCmdSetShadingRateImageEnableNV_fnptr(commandBuffer, shadingRateImageEnable);
        }
        public static void CmdSetCoverageReductionModeNV(VkCommandBuffer commandBuffer, VkCoverageReductionModeNV coverageReductionMode)
        {
            VkPointers._vkCmdSetCoverageReductionModeNV_fnptr(commandBuffer, coverageReductionMode);
        }
        public static void CmdSetRepresentativeFragmentTestEnableNV(VkCommandBuffer commandBuffer, int representativeFragmentTestEnable)
        {
            VkPointers._vkCmdSetRepresentativeFragmentTestEnableNV_fnptr(commandBuffer, representativeFragmentTestEnable);
        }
        public static VkResult CreatePrivateDataSlot(VkDevice device, VkPrivateDataSlotCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlot* pPrivateDataSlot)
        {
            return VkPointers._vkCreatePrivateDataSlot_fnptr(device, pCreateInfo, pAllocator, pPrivateDataSlot);
        }
        public static void DestroyPrivateDataSlot(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPrivateDataSlot_fnptr(device, privateDataSlot, pAllocator);
        }
        public static VkResult SetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data)
        {
            return VkPointers._vkSetPrivateData_fnptr(device, objectType, objectHandle, privateDataSlot, data);
        }
        public static void GetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong* pData)
        {
            VkPointers._vkGetPrivateData_fnptr(device, objectType, objectHandle, privateDataSlot, pData);
        }
        public static void CmdCopyBuffer2(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* pCopyBufferInfo)
        {
            VkPointers._vkCmdCopyBuffer2_fnptr(commandBuffer, pCopyBufferInfo);
        }
        public static void CmdCopyImage2(VkCommandBuffer commandBuffer, VkCopyImageInfo2* pCopyImageInfo)
        {
            VkPointers._vkCmdCopyImage2_fnptr(commandBuffer, pCopyImageInfo);
        }
        public static void CmdBlitImage2(VkCommandBuffer commandBuffer, VkBlitImageInfo2* pBlitImageInfo)
        {
            VkPointers._vkCmdBlitImage2_fnptr(commandBuffer, pBlitImageInfo);
        }
        public static void CmdCopyBufferToImage2(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
        {
            VkPointers._vkCmdCopyBufferToImage2_fnptr(commandBuffer, pCopyBufferToImageInfo);
        }
        public static void CmdCopyImageToBuffer2(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
        {
            VkPointers._vkCmdCopyImageToBuffer2_fnptr(commandBuffer, pCopyImageToBufferInfo);
        }
        public static void CmdResolveImage2(VkCommandBuffer commandBuffer, VkResolveImageInfo2* pResolveImageInfo)
        {
            VkPointers._vkCmdResolveImage2_fnptr(commandBuffer, pResolveImageInfo);
        }
        public static void CmdRefreshObjectsKHR(VkCommandBuffer commandBuffer, VkRefreshObjectListKHR* pRefreshObjects)
        {
            VkPointers._vkCmdRefreshObjectsKHR_fnptr(commandBuffer, pRefreshObjects);
        }
        public static VkResult GetPhysicalDeviceRefreshableObjectTypesKHR(VkPhysicalDevice physicalDevice, uint* pRefreshableObjectTypeCount, VkObjectType* pRefreshableObjectTypes)
        {
            return VkPointers._vkGetPhysicalDeviceRefreshableObjectTypesKHR_fnptr(physicalDevice, pRefreshableObjectTypeCount, pRefreshableObjectTypes);
        }
        public static void CmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR* combinerOps)
        {
            VkPointers._vkCmdSetFragmentShadingRateKHR_fnptr(commandBuffer, pFragmentSize, combinerOps);
        }
        public static VkResult GetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
        {
            return VkPointers._vkGetPhysicalDeviceFragmentShadingRatesKHR_fnptr(physicalDevice, pFragmentShadingRateCount, pFragmentShadingRates);
        }
        public static void CmdSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR* combinerOps)
        {
            VkPointers._vkCmdSetFragmentShadingRateEnumNV_fnptr(commandBuffer, shadingRate, combinerOps);
        }
        public static void GetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            VkPointers._vkGetAccelerationStructureBuildSizesKHR_fnptr(device, buildType, pBuildInfo, pMaxPrimitiveCounts, pSizeInfo);
        }
        public static void CmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
        {
            VkPointers._vkCmdSetVertexInputEXT_fnptr(commandBuffer, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, pVertexAttributeDescriptions);
        }
        public static void CmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, int* pColorWriteEnables)
        {
            VkPointers._vkCmdSetColorWriteEnableEXT_fnptr(commandBuffer, attachmentCount, pColorWriteEnables);
        }
        public static void CmdSetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfo* pDependencyInfo)
        {
            VkPointers._vkCmdSetEvent2_fnptr(commandBuffer, @event, pDependencyInfo);
        }
        public static void CmdResetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits2 stageMask)
        {
            VkPointers._vkCmdResetEvent2_fnptr(commandBuffer, @event, stageMask);
        }
        public static void CmdWaitEvents2(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfo* pDependencyInfos)
        {
            VkPointers._vkCmdWaitEvents2_fnptr(commandBuffer, eventCount, pEvents, pDependencyInfos);
        }
        public static void CmdPipelineBarrier2(VkCommandBuffer commandBuffer, VkDependencyInfo* pDependencyInfo)
        {
            VkPointers._vkCmdPipelineBarrier2_fnptr(commandBuffer, pDependencyInfo);
        }
        public static VkResult QueueSubmit2(VkQueue queue, uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence)
        {
            return VkPointers._vkQueueSubmit2_fnptr(queue, submitCount, pSubmits, fence);
        }
        public static void CmdWriteTimestamp2(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits2 stage, VkQueryPool queryPool, uint query)
        {
            VkPointers._vkCmdWriteTimestamp2_fnptr(commandBuffer, stage, queryPool, query);
        }
        public static void CmdWriteBufferMarker2AMD(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits2 stage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
        {
            VkPointers._vkCmdWriteBufferMarker2AMD_fnptr(commandBuffer, stage, dstBuffer, dstOffset, marker);
        }
        public static void GetQueueCheckpointData2NV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
        {
            VkPointers._vkGetQueueCheckpointData2NV_fnptr(queue, pCheckpointDataCount, pCheckpointData);
        }
        public static VkResult CopyMemoryToImageEXT(VkDevice device, VkCopyMemoryToImageInfoEXT* pCopyMemoryToImageInfo)
        {
            return VkPointers._vkCopyMemoryToImageEXT_fnptr(device, pCopyMemoryToImageInfo);
        }
        public static VkResult CopyImageToMemoryEXT(VkDevice device, VkCopyImageToMemoryInfoEXT* pCopyImageToMemoryInfo)
        {
            return VkPointers._vkCopyImageToMemoryEXT_fnptr(device, pCopyImageToMemoryInfo);
        }
        public static VkResult CopyImageToImageEXT(VkDevice device, VkCopyImageToImageInfoEXT* pCopyImageToImageInfo)
        {
            return VkPointers._vkCopyImageToImageEXT_fnptr(device, pCopyImageToImageInfo);
        }
        public static VkResult TransitionImageLayoutEXT(VkDevice device, uint transitionCount, VkHostImageLayoutTransitionInfoEXT* pTransitions)
        {
            return VkPointers._vkTransitionImageLayoutEXT_fnptr(device, transitionCount, pTransitions);
        }
        public static void GetCommandPoolMemoryConsumption(VkDevice device, VkCommandPool commandPool, VkCommandBuffer commandBuffer, VkCommandPoolMemoryConsumption* pConsumption)
        {
            VkPointers._vkGetCommandPoolMemoryConsumption_fnptr(device, commandPool, commandBuffer, pConsumption);
        }
        public static VkResult GetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkVideoProfileInfoKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
        {
            return VkPointers._vkGetPhysicalDeviceVideoCapabilitiesKHR_fnptr(physicalDevice, pVideoProfile, pCapabilities);
        }
        public static VkResult GetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceVideoFormatPropertiesKHR_fnptr(physicalDevice, pVideoFormatInfo, pVideoFormatPropertyCount, pVideoFormatProperties);
        }
        public static VkResult GetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo, VkVideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties)
        {
            return VkPointers._vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_fnptr(physicalDevice, pQualityLevelInfo, pQualityLevelProperties);
        }
        public static VkResult CreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            return VkPointers._vkCreateVideoSessionKHR_fnptr(device, pCreateInfo, pAllocator, pVideoSession);
        }
        public static void DestroyVideoSessionKHR(VkDevice device, VkVideoSessionKHR videoSession, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyVideoSessionKHR_fnptr(device, videoSession, pAllocator);
        }
        public static VkResult CreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            return VkPointers._vkCreateVideoSessionParametersKHR_fnptr(device, pCreateInfo, pAllocator, pVideoSessionParameters);
        }
        public static VkResult UpdateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo)
        {
            return VkPointers._vkUpdateVideoSessionParametersKHR_fnptr(device, videoSessionParameters, pUpdateInfo);
        }
        public static VkResult GetEncodedVideoSessionParametersKHR(VkDevice device, VkVideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, VkVideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, nuint* pDataSize, void* pData)
        {
            return VkPointers._vkGetEncodedVideoSessionParametersKHR_fnptr(device, pVideoSessionParametersInfo, pFeedbackInfo, pDataSize, pData);
        }
        public static void DestroyVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyVideoSessionParametersKHR_fnptr(device, videoSessionParameters, pAllocator);
        }
        public static VkResult GetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, uint* pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
        {
            return VkPointers._vkGetVideoSessionMemoryRequirementsKHR_fnptr(device, videoSession, pMemoryRequirementsCount, pMemoryRequirements);
        }
        public static VkResult BindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, VkBindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos)
        {
            return VkPointers._vkBindVideoSessionMemoryKHR_fnptr(device, videoSession, bindSessionMemoryInfoCount, pBindSessionMemoryInfos);
        }
        public static void CmdDecodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoDecodeInfoKHR* pDecodeInfo)
        {
            VkPointers._vkCmdDecodeVideoKHR_fnptr(commandBuffer, pDecodeInfo);
        }
        public static void CmdBeginVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoBeginCodingInfoKHR* pBeginInfo)
        {
            VkPointers._vkCmdBeginVideoCodingKHR_fnptr(commandBuffer, pBeginInfo);
        }
        public static void CmdControlVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoCodingControlInfoKHR* pCodingControlInfo)
        {
            VkPointers._vkCmdControlVideoCodingKHR_fnptr(commandBuffer, pCodingControlInfo);
        }
        public static void CmdEndVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoEndCodingInfoKHR* pEndCodingInfo)
        {
            VkPointers._vkCmdEndVideoCodingKHR_fnptr(commandBuffer, pEndCodingInfo);
        }
        public static void CmdEncodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoEncodeInfoKHR* pEncodeInfo)
        {
            VkPointers._vkCmdEncodeVideoKHR_fnptr(commandBuffer, pEncodeInfo);
        }
        public static void CmdDecompressMemoryNV(VkCommandBuffer commandBuffer, uint decompressRegionCount, VkDecompressMemoryRegionNV* pDecompressMemoryRegions)
        {
            VkPointers._vkCmdDecompressMemoryNV_fnptr(commandBuffer, decompressRegionCount, pDecompressMemoryRegions);
        }
        public static void CmdDecompressMemoryIndirectCountNV(VkCommandBuffer commandBuffer, ulong indirectCommandsAddress, ulong indirectCommandsCountAddress, uint stride)
        {
            VkPointers._vkCmdDecompressMemoryIndirectCountNV_fnptr(commandBuffer, indirectCommandsAddress, indirectCommandsCountAddress, stride);
        }
        public static VkResult CreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
        {
            return VkPointers._vkCreateCuModuleNVX_fnptr(device, pCreateInfo, pAllocator, pModule);
        }
        public static VkResult CreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
        {
            return VkPointers._vkCreateCuFunctionNVX_fnptr(device, pCreateInfo, pAllocator, pFunction);
        }
        public static void DestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCuModuleNVX_fnptr(device, module, pAllocator);
        }
        public static void DestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCuFunctionNVX_fnptr(device, function, pAllocator);
        }
        public static void CmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo)
        {
            VkPointers._vkCmdCuLaunchKernelNVX_fnptr(commandBuffer, pLaunchInfo);
        }
        public static void GetDescriptorSetLayoutSizeEXT(VkDevice device, VkDescriptorSetLayout layout, ulong* pLayoutSizeInBytes)
        {
            VkPointers._vkGetDescriptorSetLayoutSizeEXT_fnptr(device, layout, pLayoutSizeInBytes);
        }
        public static void GetDescriptorSetLayoutBindingOffsetEXT(VkDevice device, VkDescriptorSetLayout layout, uint binding, ulong* pOffset)
        {
            VkPointers._vkGetDescriptorSetLayoutBindingOffsetEXT_fnptr(device, layout, binding, pOffset);
        }
        public static void GetDescriptorEXT(VkDevice device, VkDescriptorGetInfoEXT* pDescriptorInfo, nuint dataSize, void* pDescriptor)
        {
            VkPointers._vkGetDescriptorEXT_fnptr(device, pDescriptorInfo, dataSize, pDescriptor);
        }
        public static void CmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, VkDescriptorBufferBindingInfoEXT* pBindingInfos)
        {
            VkPointers._vkCmdBindDescriptorBuffersEXT_fnptr(commandBuffer, bufferCount, pBindingInfos);
        }
        public static void CmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, ulong* pOffsets)
        {
            VkPointers._vkCmdSetDescriptorBufferOffsetsEXT_fnptr(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, pBufferIndices, pOffsets);
        }
        public static void CmdBindDescriptorBufferEmbeddedSamplersEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set)
        {
            VkPointers._vkCmdBindDescriptorBufferEmbeddedSamplersEXT_fnptr(commandBuffer, pipelineBindPoint, layout, set);
        }
        public static VkResult GetBufferOpaqueCaptureDescriptorDataEXT(VkDevice device, VkBufferCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetBufferOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static VkResult GetImageOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetImageOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static VkResult GetImageViewOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageViewCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetImageViewOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static VkResult GetSamplerOpaqueCaptureDescriptorDataEXT(VkDevice device, VkSamplerCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetSamplerOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static VkResult GetAccelerationStructureOpaqueCaptureDescriptorDataEXT(VkDevice device, VkAccelerationStructureCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static void SetDeviceMemoryPriorityEXT(VkDevice device, VkDeviceMemory memory, float priority)
        {
            VkPointers._vkSetDeviceMemoryPriorityEXT_fnptr(device, memory, priority);
        }
        public static VkResult AcquireDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, VkDisplayKHR display)
        {
            return VkPointers._vkAcquireDrmDisplayEXT_fnptr(physicalDevice, drmFd, display);
        }
        public static VkResult GetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, uint connectorId, VkDisplayKHR* display)
        {
            return VkPointers._vkGetDrmDisplayEXT_fnptr(physicalDevice, drmFd, connectorId, display);
        }
        public static VkResult WaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout)
        {
            return VkPointers._vkWaitForPresentKHR_fnptr(device, swapchain, presentId, timeout);
        }
        public static VkResult CreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            return VkPointers._vkCreateBufferCollectionFUCHSIA_fnptr(device, pCreateInfo, pAllocator, pCollection);
        }
        public static VkResult SetBufferCollectionBufferConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferConstraintsInfoFUCHSIA* pBufferConstraintsInfo)
        {
            return VkPointers._vkSetBufferCollectionBufferConstraintsFUCHSIA_fnptr(device, collection, pBufferConstraintsInfo);
        }
        public static VkResult SetBufferCollectionImageConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkImageConstraintsInfoFUCHSIA* pImageConstraintsInfo)
        {
            return VkPointers._vkSetBufferCollectionImageConstraintsFUCHSIA_fnptr(device, collection, pImageConstraintsInfo);
        }
        public static void DestroyBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyBufferCollectionFUCHSIA_fnptr(device, collection, pAllocator);
        }
        public static VkResult GetBufferCollectionPropertiesFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferCollectionPropertiesFUCHSIA* pProperties)
        {
            return VkPointers._vkGetBufferCollectionPropertiesFUCHSIA_fnptr(device, collection, pProperties);
        }
        public static VkResult CreateCudaModuleNV(VkDevice device, VkCudaModuleCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCudaModuleNV* pModule)
        {
            return VkPointers._vkCreateCudaModuleNV_fnptr(device, pCreateInfo, pAllocator, pModule);
        }
        public static VkResult GetCudaModuleCacheNV(VkDevice device, VkCudaModuleNV module, nuint* pCacheSize, void* pCacheData)
        {
            return VkPointers._vkGetCudaModuleCacheNV_fnptr(device, module, pCacheSize, pCacheData);
        }
        public static VkResult CreateCudaFunctionNV(VkDevice device, VkCudaFunctionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCudaFunctionNV* pFunction)
        {
            return VkPointers._vkCreateCudaFunctionNV_fnptr(device, pCreateInfo, pAllocator, pFunction);
        }
        public static void DestroyCudaModuleNV(VkDevice device, VkCudaModuleNV module, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCudaModuleNV_fnptr(device, module, pAllocator);
        }
        public static void DestroyCudaFunctionNV(VkDevice device, VkCudaFunctionNV function, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCudaFunctionNV_fnptr(device, function, pAllocator);
        }
        public static void CmdCudaLaunchKernelNV(VkCommandBuffer commandBuffer, VkCudaLaunchInfoNV* pLaunchInfo)
        {
            VkPointers._vkCmdCudaLaunchKernelNV_fnptr(commandBuffer, pLaunchInfo);
        }
        public static void CmdBeginRendering(VkCommandBuffer commandBuffer, VkRenderingInfo* pRenderingInfo)
        {
            VkPointers._vkCmdBeginRendering_fnptr(commandBuffer, pRenderingInfo);
        }
        public static void CmdEndRendering(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdEndRendering_fnptr(commandBuffer);
        }
        public static void GetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, VkDescriptorSetBindingReferenceVALVE* pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
        {
            VkPointers._vkGetDescriptorSetLayoutHostMappingInfoVALVE_fnptr(device, pBindingReference, pHostMapping);
        }
        public static void GetDescriptorSetHostMappingVALVE(VkDevice device, VkDescriptorSet descriptorSet, void** ppData)
        {
            VkPointers._vkGetDescriptorSetHostMappingVALVE_fnptr(device, descriptorSet, ppData);
        }
        public static VkResult CreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap)
        {
            return VkPointers._vkCreateMicromapEXT_fnptr(device, pCreateInfo, pAllocator, pMicromap);
        }
        public static void CmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            VkPointers._vkCmdBuildMicromapsEXT_fnptr(commandBuffer, infoCount, pInfos);
        }
        public static VkResult BuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            return VkPointers._vkBuildMicromapsEXT_fnptr(device, deferredOperation, infoCount, pInfos);
        }
        public static void DestroyMicromapEXT(VkDevice device, VkMicromapEXT micromap, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyMicromapEXT_fnptr(device, micromap, pAllocator);
        }
        public static void CmdCopyMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMicromapInfoEXT* pInfo)
        {
            VkPointers._vkCmdCopyMicromapEXT_fnptr(commandBuffer, pInfo);
        }
        public static VkResult CopyMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapInfoEXT* pInfo)
        {
            return VkPointers._vkCopyMicromapEXT_fnptr(device, deferredOperation, pInfo);
        }
        public static void CmdCopyMicromapToMemoryEXT(VkCommandBuffer commandBuffer, VkCopyMicromapToMemoryInfoEXT* pInfo)
        {
            VkPointers._vkCmdCopyMicromapToMemoryEXT_fnptr(commandBuffer, pInfo);
        }
        public static VkResult CopyMicromapToMemoryEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapToMemoryInfoEXT* pInfo)
        {
            return VkPointers._vkCopyMicromapToMemoryEXT_fnptr(device, deferredOperation, pInfo);
        }
        public static void CmdCopyMemoryToMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMemoryToMicromapInfoEXT* pInfo)
        {
            VkPointers._vkCmdCopyMemoryToMicromapEXT_fnptr(commandBuffer, pInfo);
        }
        public static VkResult CopyMemoryToMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToMicromapInfoEXT* pInfo)
        {
            return VkPointers._vkCopyMemoryToMicromapEXT_fnptr(device, deferredOperation, pInfo);
        }
        public static void CmdWriteMicromapsPropertiesEXT(VkCommandBuffer commandBuffer, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            VkPointers._vkCmdWriteMicromapsPropertiesEXT_fnptr(commandBuffer, micromapCount, pMicromaps, queryType, queryPool, firstQuery);
        }
        public static VkResult WriteMicromapsPropertiesEXT(VkDevice device, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, nuint dataSize, void* pData, nuint stride)
        {
            return VkPointers._vkWriteMicromapsPropertiesEXT_fnptr(device, micromapCount, pMicromaps, queryType, dataSize, pData, stride);
        }
        public static void GetDeviceMicromapCompatibilityEXT(VkDevice device, VkMicromapVersionInfoEXT* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            VkPointers._vkGetDeviceMicromapCompatibilityEXT_fnptr(device, pVersionInfo, pCompatibility);
        }
        public static void GetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkMicromapBuildInfoEXT* pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
        {
            VkPointers._vkGetMicromapBuildSizesEXT_fnptr(device, buildType, pBuildInfo, pSizeInfo);
        }
        public static void GetShaderModuleIdentifierEXT(VkDevice device, VkShaderModule shaderModule, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            VkPointers._vkGetShaderModuleIdentifierEXT_fnptr(device, shaderModule, pIdentifier);
        }
        public static void GetShaderModuleCreateInfoIdentifierEXT(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            VkPointers._vkGetShaderModuleCreateInfoIdentifierEXT_fnptr(device, pCreateInfo, pIdentifier);
        }
        public static void GetImageSubresourceLayout2KHR(VkDevice device, VkImage image, VkImageSubresource2KHR* pSubresource, VkSubresourceLayout2KHR* pLayout)
        {
            VkPointers._vkGetImageSubresourceLayout2KHR_fnptr(device, image, pSubresource, pLayout);
        }
        public static VkResult GetPipelinePropertiesEXT(VkDevice device, VkPipelineInfoEXT* pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
        {
            return VkPointers._vkGetPipelinePropertiesEXT_fnptr(device, pPipelineInfo, pPipelineProperties);
        }
        public static void ExportMetalObjectsEXT(VkDevice device, VkExportMetalObjectsInfoEXT* pMetalObjectsInfo)
        {
            VkPointers._vkExportMetalObjectsEXT_fnptr(device, pMetalObjectsInfo);
        }
        public static VkResult GetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, uint* pPropertiesCount, VkTilePropertiesQCOM* pProperties)
        {
            return VkPointers._vkGetFramebufferTilePropertiesQCOM_fnptr(device, framebuffer, pPropertiesCount, pProperties);
        }
        public static VkResult GetDynamicRenderingTilePropertiesQCOM(VkDevice device, VkRenderingInfo* pRenderingInfo, VkTilePropertiesQCOM* pProperties)
        {
            return VkPointers._vkGetDynamicRenderingTilePropertiesQCOM_fnptr(device, pRenderingInfo, pProperties);
        }
        public static VkResult GetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceOpticalFlowImageFormatsNV_fnptr(physicalDevice, pOpticalFlowImageFormatInfo, pFormatCount, pImageFormatProperties);
        }
        public static VkResult CreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            return VkPointers._vkCreateOpticalFlowSessionNV_fnptr(device, pCreateInfo, pAllocator, pSession);
        }
        public static void DestroyOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionNV session, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyOpticalFlowSessionNV_fnptr(device, session, pAllocator);
        }
        public static VkResult BindOpticalFlowSessionImageNV(VkDevice device, VkOpticalFlowSessionNV session, VkOpticalFlowSessionBindingPointNV bindingPoint, VkImageView view, VkImageLayout layout)
        {
            return VkPointers._vkBindOpticalFlowSessionImageNV_fnptr(device, session, bindingPoint, view, layout);
        }
        public static void CmdOpticalFlowExecuteNV(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, VkOpticalFlowExecuteInfoNV* pExecuteInfo)
        {
            VkPointers._vkCmdOpticalFlowExecuteNV_fnptr(commandBuffer, session, pExecuteInfo);
        }
        public static VkResult GetDeviceFaultInfoEXT(VkDevice device, VkDeviceFaultCountsEXT* pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
        {
            return VkPointers._vkGetDeviceFaultInfoEXT_fnptr(device, pFaultCounts, pFaultInfo);
        }
        public static void CmdSetDepthBias2EXT(VkCommandBuffer commandBuffer, VkDepthBiasInfoEXT* pDepthBiasInfo)
        {
            VkPointers._vkCmdSetDepthBias2EXT_fnptr(commandBuffer, pDepthBiasInfo);
        }
        public static VkResult ReleaseSwapchainImagesEXT(VkDevice device, VkReleaseSwapchainImagesInfoEXT* pReleaseInfo)
        {
            return VkPointers._vkReleaseSwapchainImagesEXT_fnptr(device, pReleaseInfo);
        }
        public static void GetDeviceImageSubresourceLayoutKHR(VkDevice device, VkDeviceImageSubresourceInfoKHR* pInfo, VkSubresourceLayout2KHR* pLayout)
        {
            VkPointers._vkGetDeviceImageSubresourceLayoutKHR_fnptr(device, pInfo, pLayout);
        }
        public static VkResult MapMemory2KHR(VkDevice device, VkMemoryMapInfoKHR* pMemoryMapInfo, void** ppData)
        {
            return VkPointers._vkMapMemory2KHR_fnptr(device, pMemoryMapInfo, ppData);
        }
        public static VkResult UnmapMemory2KHR(VkDevice device, VkMemoryUnmapInfoKHR* pMemoryUnmapInfo)
        {
            return VkPointers._vkUnmapMemory2KHR_fnptr(device, pMemoryUnmapInfo);
        }
        public static VkResult CreateShadersEXT(VkDevice device, uint createInfoCount, VkShaderCreateInfoEXT* pCreateInfos, VkAllocationCallbacks* pAllocator, VkShaderEXT* pShaders)
        {
            return VkPointers._vkCreateShadersEXT_fnptr(device, createInfoCount, pCreateInfos, pAllocator, pShaders);
        }
        public static void DestroyShaderEXT(VkDevice device, VkShaderEXT shader, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyShaderEXT_fnptr(device, shader, pAllocator);
        }
        public static VkResult GetShaderBinaryDataEXT(VkDevice device, VkShaderEXT shader, nuint* pDataSize, void* pData)
        {
            return VkPointers._vkGetShaderBinaryDataEXT_fnptr(device, shader, pDataSize, pData);
        }
        public static void CmdBindShadersEXT(VkCommandBuffer commandBuffer, uint stageCount, VkShaderStageFlagBits* pStages, VkShaderEXT* pShaders)
        {
            VkPointers._vkCmdBindShadersEXT_fnptr(commandBuffer, stageCount, pStages, pShaders);
        }
        public static VkResult GetScreenBufferPropertiesQNX(VkDevice device, IntPtr* buffer, VkScreenBufferPropertiesQNX* pProperties)
        {
            return VkPointers._vkGetScreenBufferPropertiesQNX_fnptr(device, buffer, pProperties);
        }
        public static VkResult GetPhysicalDeviceCooperativeMatrixPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesKHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static VkResult GetExecutionGraphPipelineScratchSizeAMDX(VkDevice device, VkPipeline executionGraph, VkExecutionGraphPipelineScratchSizeAMDX* pSizeInfo)
        {
            return VkPointers._vkGetExecutionGraphPipelineScratchSizeAMDX_fnptr(device, executionGraph, pSizeInfo);
        }
        public static VkResult GetExecutionGraphPipelineNodeIndexAMDX(VkDevice device, VkPipeline executionGraph, VkPipelineShaderStageNodeCreateInfoAMDX* pNodeInfo, uint* pNodeIndex)
        {
            return VkPointers._vkGetExecutionGraphPipelineNodeIndexAMDX_fnptr(device, executionGraph, pNodeInfo, pNodeIndex);
        }
        public static VkResult CreateExecutionGraphPipelinesAMDX(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return VkPointers._vkCreateExecutionGraphPipelinesAMDX_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static void CmdInitializeGraphScratchMemoryAMDX(VkCommandBuffer commandBuffer, ulong scratch)
        {
            VkPointers._vkCmdInitializeGraphScratchMemoryAMDX_fnptr(commandBuffer, scratch);
        }
        public static void CmdDispatchGraphAMDX(VkCommandBuffer commandBuffer, ulong scratch, VkDispatchGraphCountInfoAMDX* pCountInfo)
        {
            VkPointers._vkCmdDispatchGraphAMDX_fnptr(commandBuffer, scratch, pCountInfo);
        }
        public static void CmdDispatchGraphIndirectAMDX(VkCommandBuffer commandBuffer, ulong scratch, VkDispatchGraphCountInfoAMDX* pCountInfo)
        {
            VkPointers._vkCmdDispatchGraphIndirectAMDX_fnptr(commandBuffer, scratch, pCountInfo);
        }
        public static void CmdDispatchGraphIndirectCountAMDX(VkCommandBuffer commandBuffer, ulong scratch, ulong countInfo)
        {
            VkPointers._vkCmdDispatchGraphIndirectCountAMDX_fnptr(commandBuffer, scratch, countInfo);
        }
        public static void CmdBindDescriptorSets2KHR(VkCommandBuffer commandBuffer, VkBindDescriptorSetsInfoKHR* pBindDescriptorSetsInfo)
        {
            VkPointers._vkCmdBindDescriptorSets2KHR_fnptr(commandBuffer, pBindDescriptorSetsInfo);
        }
        public static void CmdPushConstants2KHR(VkCommandBuffer commandBuffer, VkPushConstantsInfoKHR* pPushConstantsInfo)
        {
            VkPointers._vkCmdPushConstants2KHR_fnptr(commandBuffer, pPushConstantsInfo);
        }
        public static void CmdPushDescriptorSet2KHR(VkCommandBuffer commandBuffer, VkPushDescriptorSetInfoKHR* pPushDescriptorSetInfo)
        {
            VkPointers._vkCmdPushDescriptorSet2KHR_fnptr(commandBuffer, pPushDescriptorSetInfo);
        }
        public static void CmdPushDescriptorSetWithTemplate2KHR(VkCommandBuffer commandBuffer, VkPushDescriptorSetWithTemplateInfoKHR* pPushDescriptorSetWithTemplateInfo)
        {
            VkPointers._vkCmdPushDescriptorSetWithTemplate2KHR_fnptr(commandBuffer, pPushDescriptorSetWithTemplateInfo);
        }
        public static void CmdSetDescriptorBufferOffsets2EXT(VkCommandBuffer commandBuffer, VkSetDescriptorBufferOffsetsInfoEXT* pSetDescriptorBufferOffsetsInfo)
        {
            VkPointers._vkCmdSetDescriptorBufferOffsets2EXT_fnptr(commandBuffer, pSetDescriptorBufferOffsetsInfo);
        }
        public static void CmdBindDescriptorBufferEmbeddedSamplers2EXT(VkCommandBuffer commandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT* pBindDescriptorBufferEmbeddedSamplersInfo)
        {
            VkPointers._vkCmdBindDescriptorBufferEmbeddedSamplers2EXT_fnptr(commandBuffer, pBindDescriptorBufferEmbeddedSamplersInfo);
        }
        public static VkResult SetLatencySleepModeNV(VkDevice device, VkSwapchainKHR swapchain, VkLatencySleepModeInfoNV* pSleepModeInfo)
        {
            return VkPointers._vkSetLatencySleepModeNV_fnptr(device, swapchain, pSleepModeInfo);
        }
        public static VkResult LatencySleepNV(VkDevice device, VkSwapchainKHR swapchain, VkLatencySleepInfoNV* pSleepInfo)
        {
            return VkPointers._vkLatencySleepNV_fnptr(device, swapchain, pSleepInfo);
        }
        public static void SetLatencyMarkerNV(VkDevice device, VkSwapchainKHR swapchain, VkSetLatencyMarkerInfoNV* pLatencyMarkerInfo)
        {
            VkPointers._vkSetLatencyMarkerNV_fnptr(device, swapchain, pLatencyMarkerInfo);
        }
        public static void GetLatencyTimingsNV(VkDevice device, VkSwapchainKHR swapchain, VkGetLatencyMarkerInfoNV* pLatencyMarkerInfo)
        {
            VkPointers._vkGetLatencyTimingsNV_fnptr(device, swapchain, pLatencyMarkerInfo);
        }
        public static void QueueNotifyOutOfBandNV(VkQueue queue, VkOutOfBandQueueTypeInfoNV* pQueueTypeInfo)
        {
            VkPointers._vkQueueNotifyOutOfBandNV_fnptr(queue, pQueueTypeInfo);
        }
        public static void CmdSetRenderingAttachmentLocationsKHR(VkCommandBuffer commandBuffer, VkRenderingAttachmentLocationInfoKHR* pLocationInfo)
        {
            VkPointers._vkCmdSetRenderingAttachmentLocationsKHR_fnptr(commandBuffer, pLocationInfo);
        }
        public static void CmdSetRenderingInputAttachmentIndicesKHR(VkCommandBuffer commandBuffer, VkRenderingInputAttachmentIndexInfoKHR* pInputAttachmentIndexInfo)
        {
            VkPointers._vkCmdSetRenderingInputAttachmentIndicesKHR_fnptr(commandBuffer, pInputAttachmentIndexInfo);
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
