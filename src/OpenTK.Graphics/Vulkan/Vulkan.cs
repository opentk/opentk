// This file is auto generated, do not edit.
using OpenTK.Mathematics;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecAv1std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecAv1stdDecode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecAv1stdEncode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH264std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH264stdDecode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH264stdEncode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH265std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH265stdDecode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecH265stdEncode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecVp9std;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecVp9stdDecode;
using OpenTK.Graphics.Vulkan.VulkanVideoCodecsCommon;
using System;
using System.Runtime.CompilerServices;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static unsafe partial class Vk
    {
        /// <summary><b>[requires: VK_EXT_acquire_drm_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireDrmDisplayEXT.html" /></remarks>
        public static VkResult AcquireDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, VkDisplayKHR display)
        {
            return VkPointers._vkAcquireDrmDisplayEXT_fnptr(physicalDevice, drmFd, display);
        }
        /// <summary><b>[requires: VK_EXT_full_screen_exclusive]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireFullScreenExclusiveModeEXT.html" /></remarks>
        public static VkResult AcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
        {
            return VkPointers._vkAcquireFullScreenExclusiveModeEXT_fnptr(device, swapchain);
        }
        /// <summary>[device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireImageANDROID.html" /></remarks>
        public static VkResult AcquireImageANDROID(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence)
        {
            return VkPointers._vkAcquireImageANDROID_fnptr(device, image, nativeFenceFd, semaphore, fence);
        }
        /// <summary><b>[requires: VK_OHOS_native_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireImageOHOS.html" /></remarks>
        public static VkResult AcquireImageOHOS(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence)
        {
            return VkPointers._vkAcquireImageOHOS_fnptr(device, image, nativeFenceFd, semaphore, fence);
        }
        /// <summary><b>[requires: VK_KHR_swapchain | VK_KHR_device_group]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireNextImage2KHR.html" /></remarks>
        public static VkResult AcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex)
        {
            return VkPointers._vkAcquireNextImage2KHR_fnptr(device, pAcquireInfo, pImageIndex);
        }
        /// <summary><b>[requires: VK_KHR_swapchain]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireNextImageKHR.html" /></remarks>
        public static VkResult AcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex)
        {
            return VkPointers._vkAcquireNextImageKHR_fnptr(device, swapchain, timeout, semaphore, fence, pImageIndex);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquirePerformanceConfigurationINTEL.html" /></remarks>
        public static VkResult AcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
        {
            return VkPointers._vkAcquirePerformanceConfigurationINTEL_fnptr(device, pAcquireInfo, pConfiguration);
        }
        /// <summary><b>[requires: VK_KHR_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireProfilingLockKHR.html" /></remarks>
        public static VkResult AcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo)
        {
            return VkPointers._vkAcquireProfilingLockKHR_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_NV_acquire_winrt_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireWinrtDisplayNV.html" /></remarks>
        public static VkResult AcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
        {
            return VkPointers._vkAcquireWinrtDisplayNV_fnptr(physicalDevice, display);
        }
        /// <summary><b>[requires: VK_EXT_acquire_xlib_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireXlibDisplayEXT.html" /></remarks>
        public static VkResult AcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display)
        {
            return VkPointers._vkAcquireXlibDisplayEXT_fnptr(physicalDevice, dpy, display);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAllocateCommandBuffers.html" /></remarks>
        public static VkResult AllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers)
        {
            return VkPointers._vkAllocateCommandBuffers_fnptr(device, pAllocateInfo, pCommandBuffers);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAllocateDescriptorSets.html" /></remarks>
        public static VkResult AllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets)
        {
            return VkPointers._vkAllocateDescriptorSets_fnptr(device, pAllocateInfo, pDescriptorSets);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAllocateMemory.html" /></remarks>
        public static VkResult AllocateMemory(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory)
        {
            return VkPointers._vkAllocateMemory_fnptr(device, pAllocateInfo, pAllocator, pMemory);
        }
        /// <summary><b>[requires: VK_AMD_anti_lag]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAntiLagUpdateAMD.html" /></remarks>
        public static void AntiLagUpdateAMD(VkDevice device, VkAntiLagDataAMD* pData)
        {
            VkPointers._vkAntiLagUpdateAMD_fnptr(device, pData);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBeginCommandBuffer.html" /></remarks>
        public static VkResult BeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo)
        {
            return VkPointers._vkBeginCommandBuffer_fnptr(commandBuffer, pBeginInfo);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindAccelerationStructureMemoryNV.html" /></remarks>
        public static VkResult BindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
        {
            return VkPointers._vkBindAccelerationStructureMemoryNV_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindBufferMemory.html" /></remarks>
        public static VkResult BindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset)
        {
            return VkPointers._vkBindBufferMemory_fnptr(device, buffer, memory, memoryOffset);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindBufferMemory2.html" /></remarks>
        public static VkResult BindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
        {
            return VkPointers._vkBindBufferMemory2_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: VK_KHR_bind_memory2]</b> [device command]  Alias of <see cref="BindBufferMemory2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindBufferMemory2KHR.html" /></remarks>
        public static VkResult BindBufferMemory2KHR(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
        {
            return VkPointers._vkBindBufferMemory2KHR_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindDataGraphPipelineSessionMemoryARM.html" /></remarks>
        public static VkResult BindDataGraphPipelineSessionMemoryARM(VkDevice device, uint bindInfoCount, VkBindDataGraphPipelineSessionMemoryInfoARM* pBindInfos)
        {
            return VkPointers._vkBindDataGraphPipelineSessionMemoryARM_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory.html" /></remarks>
        public static VkResult BindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset)
        {
            return VkPointers._vkBindImageMemory_fnptr(device, image, memory, memoryOffset);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory2.html" /></remarks>
        public static VkResult BindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
        {
            return VkPointers._vkBindImageMemory2_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: VK_KHR_bind_memory2]</b> [device command]  Alias of <see cref="BindImageMemory2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory2KHR.html" /></remarks>
        public static VkResult BindImageMemory2KHR(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
        {
            return VkPointers._vkBindImageMemory2KHR_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: VK_NV_optical_flow]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindOpticalFlowSessionImageNV.html" /></remarks>
        public static VkResult BindOpticalFlowSessionImageNV(VkDevice device, VkOpticalFlowSessionNV session, VkOpticalFlowSessionBindingPointNV bindingPoint, VkImageView view, VkImageLayout layout)
        {
            return VkPointers._vkBindOpticalFlowSessionImageNV_fnptr(device, session, bindingPoint, view, layout);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindTensorMemoryARM.html" /></remarks>
        public static VkResult BindTensorMemoryARM(VkDevice device, uint bindInfoCount, VkBindTensorMemoryInfoARM* pBindInfos)
        {
            return VkPointers._vkBindTensorMemoryARM_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindVideoSessionMemoryKHR.html" /></remarks>
        public static VkResult BindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, VkBindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos)
        {
            return VkPointers._vkBindVideoSessionMemoryKHR_fnptr(device, videoSession, bindSessionMemoryInfoCount, pBindSessionMemoryInfos);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBuildAccelerationStructuresKHR.html" /></remarks>
        public static VkResult BuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            return VkPointers._vkBuildAccelerationStructuresKHR_fnptr(device, deferredOperation, infoCount, pInfos, ppBuildRangeInfos);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBuildMicromapsEXT.html" /></remarks>
        public static VkResult BuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            return VkPointers._vkBuildMicromapsEXT_fnptr(device, deferredOperation, infoCount, pInfos);
        }
        /// <summary><b>[requires: VK_EXT_conditional_rendering]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginConditionalRenderingEXT.html" /></remarks>
        public static void CmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
        {
            VkPointers._vkCmdBeginConditionalRenderingEXT_fnptr(commandBuffer, pConditionalRenderingBegin);
        }
        /// <summary><b>[requires: VK_EXT_custom_resolve]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginCustomResolveEXT.html" /></remarks>
        public static void CmdBeginCustomResolveEXT(VkCommandBuffer commandBuffer, VkBeginCustomResolveInfoEXT* pBeginCustomResolveInfo)
        {
            VkPointers._vkCmdBeginCustomResolveEXT_fnptr(commandBuffer, pBeginCustomResolveInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginDebugUtilsLabelEXT.html" /></remarks>
        public static void CmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            VkPointers._vkCmdBeginDebugUtilsLabelEXT_fnptr(commandBuffer, pLabelInfo);
        }
        /// <summary><b>[requires: VK_QCOM_tile_shading]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginPerTileExecutionQCOM.html" /></remarks>
        public static void CmdBeginPerTileExecutionQCOM(VkCommandBuffer commandBuffer, VkPerTileBeginInfoQCOM* pPerTileBeginInfo)
        {
            VkPointers._vkCmdBeginPerTileExecutionQCOM_fnptr(commandBuffer, pPerTileBeginInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginQuery.html" /></remarks>
        public static void CmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlagBits flags)
        {
            VkPointers._vkCmdBeginQuery_fnptr(commandBuffer, queryPool, query, flags);
        }
        /// <summary><b>[requires: VK_EXT_transform_feedback]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginQueryIndexedEXT.html" /></remarks>
        public static void CmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlagBits flags, uint index)
        {
            VkPointers._vkCmdBeginQueryIndexedEXT_fnptr(commandBuffer, queryPool, query, flags, index);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRendering.html" /></remarks>
        public static void CmdBeginRendering(VkCommandBuffer commandBuffer, VkRenderingInfo* pRenderingInfo)
        {
            VkPointers._vkCmdBeginRendering_fnptr(commandBuffer, pRenderingInfo);
        }
        /// <summary><b>[requires: VK_KHR_dynamic_rendering]</b> [device command]  Alias of <see cref="CmdBeginRendering"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderingKHR.html" /></remarks>
        public static void CmdBeginRenderingKHR(VkCommandBuffer commandBuffer, VkRenderingInfo* pRenderingInfo)
        {
            VkPointers._vkCmdBeginRenderingKHR_fnptr(commandBuffer, pRenderingInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderPass.html" /></remarks>
        public static void CmdBeginRenderPass(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents)
        {
            VkPointers._vkCmdBeginRenderPass_fnptr(commandBuffer, pRenderPassBegin, contents);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderPass2.html" /></remarks>
        public static void CmdBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo)
        {
            VkPointers._vkCmdBeginRenderPass2_fnptr(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
        }
        /// <summary><b>[requires: VK_KHR_create_renderpass2]</b> [device command]  Alias of <see cref="CmdBeginRenderPass2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderPass2KHR.html" /></remarks>
        public static void CmdBeginRenderPass2KHR(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo)
        {
            VkPointers._vkCmdBeginRenderPass2KHR_fnptr(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
        }
        /// <summary><b>[requires: VK_EXT_transform_feedback]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginTransformFeedbackEXT.html" /></remarks>
        public static void CmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            VkPointers._vkCmdBeginTransformFeedbackEXT_fnptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginVideoCodingKHR.html" /></remarks>
        public static void CmdBeginVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoBeginCodingInfoKHR* pBeginInfo)
        {
            VkPointers._vkCmdBeginVideoCodingKHR_fnptr(commandBuffer, pBeginInfo);
        }
        /// <summary><b>[requires: VK_KHR_maintenance6]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorBufferEmbeddedSamplers2EXT.html" /></remarks>
        public static void CmdBindDescriptorBufferEmbeddedSamplers2EXT(VkCommandBuffer commandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT* pBindDescriptorBufferEmbeddedSamplersInfo)
        {
            VkPointers._vkCmdBindDescriptorBufferEmbeddedSamplers2EXT_fnptr(commandBuffer, pBindDescriptorBufferEmbeddedSamplersInfo);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorBufferEmbeddedSamplersEXT.html" /></remarks>
        public static void CmdBindDescriptorBufferEmbeddedSamplersEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set)
        {
            VkPointers._vkCmdBindDescriptorBufferEmbeddedSamplersEXT_fnptr(commandBuffer, pipelineBindPoint, layout, set);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorBuffersEXT.html" /></remarks>
        public static void CmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, VkDescriptorBufferBindingInfoEXT* pBindingInfos)
        {
            VkPointers._vkCmdBindDescriptorBuffersEXT_fnptr(commandBuffer, bufferCount, pBindingInfos);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorSets.html" /></remarks>
        public static void CmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
        {
            VkPointers._vkCmdBindDescriptorSets_fnptr(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorSets2.html" /></remarks>
        public static void CmdBindDescriptorSets2(VkCommandBuffer commandBuffer, VkBindDescriptorSetsInfo* pBindDescriptorSetsInfo)
        {
            VkPointers._vkCmdBindDescriptorSets2_fnptr(commandBuffer, pBindDescriptorSetsInfo);
        }
        /// <summary><b>[requires: VK_KHR_maintenance6]</b> [device command]  Alias of <see cref="CmdBindDescriptorSets2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorSets2KHR.html" /></remarks>
        public static void CmdBindDescriptorSets2KHR(VkCommandBuffer commandBuffer, VkBindDescriptorSetsInfo* pBindDescriptorSetsInfo)
        {
            VkPointers._vkCmdBindDescriptorSets2KHR_fnptr(commandBuffer, pBindDescriptorSetsInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer.html" /></remarks>
        public static void CmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType)
        {
            VkPointers._vkCmdBindIndexBuffer_fnptr(commandBuffer, buffer, offset, indexType);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer2.html" /></remarks>
        public static void CmdBindIndexBuffer2(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, ulong size, VkIndexType indexType)
        {
            VkPointers._vkCmdBindIndexBuffer2_fnptr(commandBuffer, buffer, offset, size, indexType);
        }
        /// <summary><b>[requires: VK_KHR_maintenance5]</b> [device command]  Alias of <see cref="CmdBindIndexBuffer2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer2KHR.html" /></remarks>
        public static void CmdBindIndexBuffer2KHR(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, ulong size, VkIndexType indexType)
        {
            VkPointers._vkCmdBindIndexBuffer2KHR_fnptr(commandBuffer, buffer, offset, size, indexType);
        }
        /// <summary><b>[requires: VK_HUAWEI_invocation_mask]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindInvocationMaskHUAWEI.html" /></remarks>
        public static void CmdBindInvocationMaskHUAWEI(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
        {
            VkPointers._vkCmdBindInvocationMaskHUAWEI_fnptr(commandBuffer, imageView, imageLayout);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindPipeline.html" /></remarks>
        public static void CmdBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
        {
            VkPointers._vkCmdBindPipeline_fnptr(commandBuffer, pipelineBindPoint, pipeline);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindPipelineShaderGroupNV.html" /></remarks>
        public static void CmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
        {
            VkPointers._vkCmdBindPipelineShaderGroupNV_fnptr(commandBuffer, pipelineBindPoint, pipeline, groupIndex);
        }
        /// <summary><b>[requires: VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindShadersEXT.html" /></remarks>
        public static void CmdBindShadersEXT(VkCommandBuffer commandBuffer, uint stageCount, VkShaderStageFlagBits* pStages, VkShaderEXT* pShaders)
        {
            VkPointers._vkCmdBindShadersEXT_fnptr(commandBuffer, stageCount, pStages, pShaders);
        }
        /// <summary><b>[requires: VK_NV_shading_rate_image]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindShadingRateImageNV.html" /></remarks>
        public static void CmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
        {
            VkPointers._vkCmdBindShadingRateImageNV_fnptr(commandBuffer, imageView, imageLayout);
        }
        /// <summary><b>[requires: VK_QCOM_tile_memory_heap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindTileMemoryQCOM.html" /></remarks>
        public static void CmdBindTileMemoryQCOM(VkCommandBuffer commandBuffer, VkTileMemoryBindInfoQCOM* pTileMemoryBindInfo)
        {
            VkPointers._vkCmdBindTileMemoryQCOM_fnptr(commandBuffer, pTileMemoryBindInfo);
        }
        /// <summary><b>[requires: VK_EXT_transform_feedback]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindTransformFeedbackBuffersEXT.html" /></remarks>
        public static void CmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes)
        {
            VkPointers._vkCmdBindTransformFeedbackBuffersEXT_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers.html" /></remarks>
        public static void CmdBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets)
        {
            VkPointers._vkCmdBindVertexBuffers_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers2.html" /></remarks>
        public static void CmdBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes, ulong* pStrides)
        {
            VkPointers._vkCmdBindVertexBuffers2_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdBindVertexBuffers2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers2EXT.html" /></remarks>
        public static void CmdBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes, ulong* pStrides)
        {
            VkPointers._vkCmdBindVertexBuffers2EXT_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage.html" /></remarks>
        public static void CmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter)
        {
            VkPointers._vkCmdBlitImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2.html" /></remarks>
        public static void CmdBlitImage2(VkCommandBuffer commandBuffer, VkBlitImageInfo2* pBlitImageInfo)
        {
            VkPointers._vkCmdBlitImage2_fnptr(commandBuffer, pBlitImageInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_commands2]</b> [device command]  Alias of <see cref="CmdBlitImage2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2KHR.html" /></remarks>
        public static void CmdBlitImage2KHR(VkCommandBuffer commandBuffer, VkBlitImageInfo2* pBlitImageInfo)
        {
            VkPointers._vkCmdBlitImage2KHR_fnptr(commandBuffer, pBlitImageInfo);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructureNV.html" /></remarks>
        public static void CmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, ulong instanceOffset, int update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
        {
            VkPointers._vkCmdBuildAccelerationStructureNV_fnptr(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructuresIndirectKHR.html" /></remarks>
        public static void CmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            VkPointers._vkCmdBuildAccelerationStructuresIndirectKHR_fnptr(commandBuffer, infoCount, pInfos, pIndirectDeviceAddresses, pIndirectStrides, ppMaxPrimitiveCounts);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructuresKHR.html" /></remarks>
        public static void CmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            VkPointers._vkCmdBuildAccelerationStructuresKHR_fnptr(commandBuffer, infoCount, pInfos, ppBuildRangeInfos);
        }
        /// <summary><b>[requires: VK_NV_cluster_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBuildClusterAccelerationStructureIndirectNV.html" /></remarks>
        public static void CmdBuildClusterAccelerationStructureIndirectNV(VkCommandBuffer commandBuffer, VkClusterAccelerationStructureCommandsInfoNV* pCommandInfos)
        {
            VkPointers._vkCmdBuildClusterAccelerationStructureIndirectNV_fnptr(commandBuffer, pCommandInfos);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBuildMicromapsEXT.html" /></remarks>
        public static void CmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            VkPointers._vkCmdBuildMicromapsEXT_fnptr(commandBuffer, infoCount, pInfos);
        }
        /// <summary><b>[requires: VK_NV_partitioned_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBuildPartitionedAccelerationStructuresNV.html" /></remarks>
        public static void CmdBuildPartitionedAccelerationStructuresNV(VkCommandBuffer commandBuffer, VkBuildPartitionedAccelerationStructureInfoNV* pBuildInfo)
        {
            VkPointers._vkCmdBuildPartitionedAccelerationStructuresNV_fnptr(commandBuffer, pBuildInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdClearAttachments.html" /></remarks>
        public static void CmdClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects)
        {
            VkPointers._vkCmdClearAttachments_fnptr(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdClearColorImage.html" /></remarks>
        public static void CmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            VkPointers._vkCmdClearColorImage_fnptr(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdClearDepthStencilImage.html" /></remarks>
        public static void CmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            VkPointers._vkCmdClearDepthStencilImage_fnptr(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdControlVideoCodingKHR.html" /></remarks>
        public static void CmdControlVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoCodingControlInfoKHR* pCodingControlInfo)
        {
            VkPointers._vkCmdControlVideoCodingKHR_fnptr(commandBuffer, pCodingControlInfo);
        }
        /// <summary><b>[requires: VK_NV_cooperative_vector]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdConvertCooperativeVectorMatrixNV.html" /></remarks>
        public static void CmdConvertCooperativeVectorMatrixNV(VkCommandBuffer commandBuffer, uint infoCount, VkConvertCooperativeVectorMatrixInfoNV* pInfos)
        {
            VkPointers._vkCmdConvertCooperativeVectorMatrixNV_fnptr(commandBuffer, infoCount, pInfos);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureKHR.html" /></remarks>
        public static void CmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo)
        {
            VkPointers._vkCmdCopyAccelerationStructureKHR_fnptr(commandBuffer, pInfo);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureNV.html" /></remarks>
        public static void CmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode)
        {
            VkPointers._vkCmdCopyAccelerationStructureNV_fnptr(commandBuffer, dst, src, mode);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureToMemoryKHR.html" /></remarks>
        public static void CmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
        {
            VkPointers._vkCmdCopyAccelerationStructureToMemoryKHR_fnptr(commandBuffer, pInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer.html" /></remarks>
        public static void CmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions)
        {
            VkPointers._vkCmdCopyBuffer_fnptr(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer2.html" /></remarks>
        public static void CmdCopyBuffer2(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* pCopyBufferInfo)
        {
            VkPointers._vkCmdCopyBuffer2_fnptr(commandBuffer, pCopyBufferInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_commands2]</b> [device command]  Alias of <see cref="CmdCopyBuffer2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer2KHR.html" /></remarks>
        public static void CmdCopyBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* pCopyBufferInfo)
        {
            VkPointers._vkCmdCopyBuffer2KHR_fnptr(commandBuffer, pCopyBufferInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBufferToImage.html" /></remarks>
        public static void CmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions)
        {
            VkPointers._vkCmdCopyBufferToImage_fnptr(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBufferToImage2.html" /></remarks>
        public static void CmdCopyBufferToImage2(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
        {
            VkPointers._vkCmdCopyBufferToImage2_fnptr(commandBuffer, pCopyBufferToImageInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_commands2]</b> [device command]  Alias of <see cref="CmdCopyBufferToImage2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBufferToImage2KHR.html" /></remarks>
        public static void CmdCopyBufferToImage2KHR(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
        {
            VkPointers._vkCmdCopyBufferToImage2KHR_fnptr(commandBuffer, pCopyBufferToImageInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImage.html" /></remarks>
        public static void CmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions)
        {
            VkPointers._vkCmdCopyImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImage2.html" /></remarks>
        public static void CmdCopyImage2(VkCommandBuffer commandBuffer, VkCopyImageInfo2* pCopyImageInfo)
        {
            VkPointers._vkCmdCopyImage2_fnptr(commandBuffer, pCopyImageInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_commands2]</b> [device command]  Alias of <see cref="CmdCopyImage2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImage2KHR.html" /></remarks>
        public static void CmdCopyImage2KHR(VkCommandBuffer commandBuffer, VkCopyImageInfo2* pCopyImageInfo)
        {
            VkPointers._vkCmdCopyImage2KHR_fnptr(commandBuffer, pCopyImageInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImageToBuffer.html" /></remarks>
        public static void CmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
        {
            VkPointers._vkCmdCopyImageToBuffer_fnptr(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImageToBuffer2.html" /></remarks>
        public static void CmdCopyImageToBuffer2(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
        {
            VkPointers._vkCmdCopyImageToBuffer2_fnptr(commandBuffer, pCopyImageToBufferInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_commands2]</b> [device command]  Alias of <see cref="CmdCopyImageToBuffer2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImageToBuffer2KHR.html" /></remarks>
        public static void CmdCopyImageToBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
        {
            VkPointers._vkCmdCopyImageToBuffer2KHR_fnptr(commandBuffer, pCopyImageToBufferInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_memory_indirect]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryIndirectKHR.html" /></remarks>
        public static void CmdCopyMemoryIndirectKHR(VkCommandBuffer commandBuffer, VkCopyMemoryIndirectInfoKHR* pCopyMemoryIndirectInfo)
        {
            VkPointers._vkCmdCopyMemoryIndirectKHR_fnptr(commandBuffer, pCopyMemoryIndirectInfo);
        }
        /// <summary><b>[requires: VK_NV_copy_memory_indirect]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryIndirectNV.html" /></remarks>
        public static void CmdCopyMemoryIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride)
        {
            VkPointers._vkCmdCopyMemoryIndirectNV_fnptr(commandBuffer, copyBufferAddress, copyCount, stride);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToAccelerationStructureKHR.html" /></remarks>
        public static void CmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
        {
            VkPointers._vkCmdCopyMemoryToAccelerationStructureKHR_fnptr(commandBuffer, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_memory_indirect]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToImageIndirectKHR.html" /></remarks>
        public static void CmdCopyMemoryToImageIndirectKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToImageIndirectInfoKHR* pCopyMemoryToImageIndirectInfo)
        {
            VkPointers._vkCmdCopyMemoryToImageIndirectKHR_fnptr(commandBuffer, pCopyMemoryToImageIndirectInfo);
        }
        /// <summary><b>[requires: VK_NV_copy_memory_indirect]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToImageIndirectNV.html" /></remarks>
        public static void CmdCopyMemoryToImageIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, VkImageSubresourceLayers* pImageSubresources)
        {
            VkPointers._vkCmdCopyMemoryToImageIndirectNV_fnptr(commandBuffer, copyBufferAddress, copyCount, stride, dstImage, dstImageLayout, pImageSubresources);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToMicromapEXT.html" /></remarks>
        public static void CmdCopyMemoryToMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMemoryToMicromapInfoEXT* pInfo)
        {
            VkPointers._vkCmdCopyMemoryToMicromapEXT_fnptr(commandBuffer, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMicromapEXT.html" /></remarks>
        public static void CmdCopyMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMicromapInfoEXT* pInfo)
        {
            VkPointers._vkCmdCopyMicromapEXT_fnptr(commandBuffer, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMicromapToMemoryEXT.html" /></remarks>
        public static void CmdCopyMicromapToMemoryEXT(VkCommandBuffer commandBuffer, VkCopyMicromapToMemoryInfoEXT* pInfo)
        {
            VkPointers._vkCmdCopyMicromapToMemoryEXT_fnptr(commandBuffer, pInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyQueryPoolResults.html" /></remarks>
        public static void CmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlagBits flags)
        {
            VkPointers._vkCmdCopyQueryPoolResults_fnptr(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyTensorARM.html" /></remarks>
        public static void CmdCopyTensorARM(VkCommandBuffer commandBuffer, VkCopyTensorInfoARM* pCopyTensorInfo)
        {
            VkPointers._vkCmdCopyTensorARM_fnptr(commandBuffer, pCopyTensorInfo);
        }
        /// <summary><b>[requires: VK_NV_cuda_kernel_launch]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCudaLaunchKernelNV.html" /></remarks>
        public static void CmdCudaLaunchKernelNV(VkCommandBuffer commandBuffer, VkCudaLaunchInfoNV* pLaunchInfo)
        {
            VkPointers._vkCmdCudaLaunchKernelNV_fnptr(commandBuffer, pLaunchInfo);
        }
        /// <summary><b>[requires: VK_NVX_binary_import]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCuLaunchKernelNVX.html" /></remarks>
        public static void CmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo)
        {
            VkPointers._vkCmdCuLaunchKernelNVX_fnptr(commandBuffer, pLaunchInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDebugMarkerBeginEXT.html" /></remarks>
        public static void CmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
        {
            VkPointers._vkCmdDebugMarkerBeginEXT_fnptr(commandBuffer, pMarkerInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDebugMarkerEndEXT.html" /></remarks>
        public static void CmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdDebugMarkerEndEXT_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: VK_EXT_debug_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDebugMarkerInsertEXT.html" /></remarks>
        public static void CmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
        {
            VkPointers._vkCmdDebugMarkerInsertEXT_fnptr(commandBuffer, pMarkerInfo);
        }
        /// <summary><b>[requires: VK_KHR_video_decode_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDecodeVideoKHR.html" /></remarks>
        public static void CmdDecodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoDecodeInfoKHR* pDecodeInfo)
        {
            VkPointers._vkCmdDecodeVideoKHR_fnptr(commandBuffer, pDecodeInfo);
        }
        /// <summary><b>[requires: VK_EXT_memory_decompression]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDecompressMemoryEXT.html" /></remarks>
        public static void CmdDecompressMemoryEXT(VkCommandBuffer commandBuffer, VkDecompressMemoryInfoEXT* pDecompressMemoryInfoEXT)
        {
            VkPointers._vkCmdDecompressMemoryEXT_fnptr(commandBuffer, pDecompressMemoryInfoEXT);
        }
        /// <summary><b>[requires: VK_EXT_memory_decompression]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDecompressMemoryIndirectCountEXT.html" /></remarks>
        public static void CmdDecompressMemoryIndirectCountEXT(VkCommandBuffer commandBuffer, VkMemoryDecompressionMethodFlagBitsEXT decompressionMethod, ulong indirectCommandsAddress, ulong indirectCommandsCountAddress, uint maxDecompressionCount, uint stride)
        {
            VkPointers._vkCmdDecompressMemoryIndirectCountEXT_fnptr(commandBuffer, decompressionMethod, indirectCommandsAddress, indirectCommandsCountAddress, maxDecompressionCount, stride);
        }
        /// <summary><b>[requires: VK_NV_memory_decompression]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDecompressMemoryIndirectCountNV.html" /></remarks>
        public static void CmdDecompressMemoryIndirectCountNV(VkCommandBuffer commandBuffer, ulong indirectCommandsAddress, ulong indirectCommandsCountAddress, uint stride)
        {
            VkPointers._vkCmdDecompressMemoryIndirectCountNV_fnptr(commandBuffer, indirectCommandsAddress, indirectCommandsCountAddress, stride);
        }
        /// <summary><b>[requires: VK_NV_memory_decompression]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDecompressMemoryNV.html" /></remarks>
        public static void CmdDecompressMemoryNV(VkCommandBuffer commandBuffer, uint decompressRegionCount, VkDecompressMemoryRegionNV* pDecompressMemoryRegions)
        {
            VkPointers._vkCmdDecompressMemoryNV_fnptr(commandBuffer, decompressRegionCount, pDecompressMemoryRegions);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatch.html" /></remarks>
        public static void CmdDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDispatch_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchBase.html" /></remarks>
        public static void CmdDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDispatchBase_fnptr(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
        }
        /// <summary><b>[requires: VK_KHR_device_group]</b> [device command]  Alias of <see cref="CmdDispatchBase"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchBaseKHR.html" /></remarks>
        public static void CmdDispatchBaseKHR(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDispatchBaseKHR_fnptr(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchDataGraphARM.html" /></remarks>
        public static void CmdDispatchDataGraphARM(VkCommandBuffer commandBuffer, VkDataGraphPipelineSessionARM session, VkDataGraphPipelineDispatchInfoARM* pInfo)
        {
            VkPointers._vkCmdDispatchDataGraphARM_fnptr(commandBuffer, session, pInfo);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchGraphAMDX.html" /></remarks>
        public static void CmdDispatchGraphAMDX(VkCommandBuffer commandBuffer, ulong scratch, ulong scratchSize, VkDispatchGraphCountInfoAMDX* pCountInfo)
        {
            VkPointers._vkCmdDispatchGraphAMDX_fnptr(commandBuffer, scratch, scratchSize, pCountInfo);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchGraphIndirectAMDX.html" /></remarks>
        public static void CmdDispatchGraphIndirectAMDX(VkCommandBuffer commandBuffer, ulong scratch, ulong scratchSize, VkDispatchGraphCountInfoAMDX* pCountInfo)
        {
            VkPointers._vkCmdDispatchGraphIndirectAMDX_fnptr(commandBuffer, scratch, scratchSize, pCountInfo);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchGraphIndirectCountAMDX.html" /></remarks>
        public static void CmdDispatchGraphIndirectCountAMDX(VkCommandBuffer commandBuffer, ulong scratch, ulong scratchSize, ulong countInfo)
        {
            VkPointers._vkCmdDispatchGraphIndirectCountAMDX_fnptr(commandBuffer, scratch, scratchSize, countInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchIndirect.html" /></remarks>
        public static void CmdDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
        {
            VkPointers._vkCmdDispatchIndirect_fnptr(commandBuffer, buffer, offset);
        }
        /// <summary><b>[requires: VK_QCOM_tile_shading]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchTileQCOM.html" /></remarks>
        public static void CmdDispatchTileQCOM(VkCommandBuffer commandBuffer, VkDispatchTileInfoQCOM* pDispatchTileInfo)
        {
            VkPointers._vkCmdDispatchTileQCOM_fnptr(commandBuffer, pDispatchTileInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDraw.html" /></remarks>
        public static void CmdDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            VkPointers._vkCmdDraw_fnptr(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
        }
        /// <summary><b>[requires: VK_HUAWEI_cluster_culling_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawClusterHUAWEI.html" /></remarks>
        public static void CmdDrawClusterHUAWEI(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDrawClusterHUAWEI_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        /// <summary><b>[requires: VK_HUAWEI_cluster_culling_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawClusterIndirectHUAWEI.html" /></remarks>
        public static void CmdDrawClusterIndirectHUAWEI(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
        {
            VkPointers._vkCmdDrawClusterIndirectHUAWEI_fnptr(commandBuffer, buffer, offset);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexed.html" /></remarks>
        public static void CmdDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            VkPointers._vkCmdDrawIndexed_fnptr(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirect.html" /></remarks>
        public static void CmdDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndexedIndirect_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirectCount.html" /></remarks>
        public static void CmdDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndexedIndirectCount_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_AMD_draw_indirect_count]</b> [device command]  Alias of <see cref="CmdDrawIndexedIndirectCount"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirectCountAMD.html" /></remarks>
        public static void CmdDrawIndexedIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndexedIndirectCountAMD_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_KHR_draw_indirect_count]</b> [device command]  Alias of <see cref="CmdDrawIndexedIndirectCount"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirectCountKHR.html" /></remarks>
        public static void CmdDrawIndexedIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndexedIndirectCountKHR_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirect.html" /></remarks>
        public static void CmdDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndirect_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        /// <summary><b>[requires: VK_EXT_transform_feedback]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectByteCountEXT.html" /></remarks>
        public static void CmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
        {
            VkPointers._vkCmdDrawIndirectByteCountEXT_fnptr(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectCount.html" /></remarks>
        public static void CmdDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndirectCount_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_AMD_draw_indirect_count]</b> [device command]  Alias of <see cref="CmdDrawIndirectCount"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectCountAMD.html" /></remarks>
        public static void CmdDrawIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndirectCountAMD_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_KHR_draw_indirect_count]</b> [device command]  Alias of <see cref="CmdDrawIndirectCount"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectCountKHR.html" /></remarks>
        public static void CmdDrawIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawIndirectCountKHR_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_EXT_mesh_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksEXT.html" /></remarks>
        public static void CmdDrawMeshTasksEXT(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            VkPointers._vkCmdDrawMeshTasksEXT_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        /// <summary><b>[requires: VK_EXT_mesh_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectCountEXT.html" /></remarks>
        public static void CmdDrawMeshTasksIndirectCountEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawMeshTasksIndirectCountEXT_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_NV_mesh_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectCountNV.html" /></remarks>
        public static void CmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            VkPointers._vkCmdDrawMeshTasksIndirectCountNV_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_EXT_mesh_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectEXT.html" /></remarks>
        public static void CmdDrawMeshTasksIndirectEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            VkPointers._vkCmdDrawMeshTasksIndirectEXT_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        /// <summary><b>[requires: VK_NV_mesh_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectNV.html" /></remarks>
        public static void CmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            VkPointers._vkCmdDrawMeshTasksIndirectNV_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        /// <summary><b>[requires: VK_NV_mesh_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksNV.html" /></remarks>
        public static void CmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask)
        {
            VkPointers._vkCmdDrawMeshTasksNV_fnptr(commandBuffer, taskCount, firstTask);
        }
        /// <summary><b>[requires: VK_EXT_multi_draw]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMultiEXT.html" /></remarks>
        public static void CmdDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
        {
            VkPointers._vkCmdDrawMultiEXT_fnptr(commandBuffer, drawCount, pVertexInfo, instanceCount, firstInstance, stride);
        }
        /// <summary><b>[requires: VK_EXT_multi_draw]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMultiIndexedEXT.html" /></remarks>
        public static void CmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
        {
            VkPointers._vkCmdDrawMultiIndexedEXT_fnptr(commandBuffer, drawCount, pIndexInfo, instanceCount, firstInstance, stride, pVertexOffset);
        }
        /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEncodeVideoKHR.html" /></remarks>
        public static void CmdEncodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoEncodeInfoKHR* pEncodeInfo)
        {
            VkPointers._vkCmdEncodeVideoKHR_fnptr(commandBuffer, pEncodeInfo);
        }
        /// <summary><b>[requires: VK_EXT_conditional_rendering]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndConditionalRenderingEXT.html" /></remarks>
        public static void CmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdEndConditionalRenderingEXT_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndDebugUtilsLabelEXT.html" /></remarks>
        public static void CmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdEndDebugUtilsLabelEXT_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: VK_QCOM_tile_shading]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndPerTileExecutionQCOM.html" /></remarks>
        public static void CmdEndPerTileExecutionQCOM(VkCommandBuffer commandBuffer, VkPerTileEndInfoQCOM* pPerTileEndInfo)
        {
            VkPointers._vkCmdEndPerTileExecutionQCOM_fnptr(commandBuffer, pPerTileEndInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndQuery.html" /></remarks>
        public static void CmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query)
        {
            VkPointers._vkCmdEndQuery_fnptr(commandBuffer, queryPool, query);
        }
        /// <summary><b>[requires: VK_EXT_transform_feedback]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndQueryIndexedEXT.html" /></remarks>
        public static void CmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index)
        {
            VkPointers._vkCmdEndQueryIndexedEXT_fnptr(commandBuffer, queryPool, query, index);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRendering.html" /></remarks>
        public static void CmdEndRendering(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdEndRendering_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: VK_EXT_fragment_density_map_offset]</b> [device command]  Alias of <see cref="CmdEndRendering2KHR"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRendering2EXT.html" /></remarks>
        public static void CmdEndRendering2EXT(VkCommandBuffer commandBuffer, VkRenderingEndInfoKHR* pRenderingEndInfo)
        {
            VkPointers._vkCmdEndRendering2EXT_fnptr(commandBuffer, pRenderingEndInfo);
        }
        /// <summary><b>[requires: VK_KHR_maintenance10]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRendering2KHR.html" /></remarks>
        public static void CmdEndRendering2KHR(VkCommandBuffer commandBuffer, VkRenderingEndInfoKHR* pRenderingEndInfo)
        {
            VkPointers._vkCmdEndRendering2KHR_fnptr(commandBuffer, pRenderingEndInfo);
        }
        /// <summary><b>[requires: VK_KHR_dynamic_rendering]</b> [device command]  Alias of <see cref="CmdEndRendering"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderingKHR.html" /></remarks>
        public static void CmdEndRenderingKHR(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdEndRenderingKHR_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass.html" /></remarks>
        public static void CmdEndRenderPass(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdEndRenderPass_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass2.html" /></remarks>
        public static void CmdEndRenderPass2(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo)
        {
            VkPointers._vkCmdEndRenderPass2_fnptr(commandBuffer, pSubpassEndInfo);
        }
        /// <summary><b>[requires: VK_KHR_create_renderpass2]</b> [device command]  Alias of <see cref="CmdEndRenderPass2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass2KHR.html" /></remarks>
        public static void CmdEndRenderPass2KHR(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo)
        {
            VkPointers._vkCmdEndRenderPass2KHR_fnptr(commandBuffer, pSubpassEndInfo);
        }
        /// <summary><b>[requires: VK_EXT_transform_feedback]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndTransformFeedbackEXT.html" /></remarks>
        public static void CmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            VkPointers._vkCmdEndTransformFeedbackEXT_fnptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndVideoCodingKHR.html" /></remarks>
        public static void CmdEndVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoEndCodingInfoKHR* pEndCodingInfo)
        {
            VkPointers._vkCmdEndVideoCodingKHR_fnptr(commandBuffer, pEndCodingInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteCommands.html" /></remarks>
        public static void CmdExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
        {
            VkPointers._vkCmdExecuteCommands_fnptr(commandBuffer, commandBufferCount, pCommandBuffers);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteGeneratedCommandsEXT.html" /></remarks>
        public static void CmdExecuteGeneratedCommandsEXT(VkCommandBuffer commandBuffer, int isPreprocessed, VkGeneratedCommandsInfoEXT* pGeneratedCommandsInfo)
        {
            VkPointers._vkCmdExecuteGeneratedCommandsEXT_fnptr(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteGeneratedCommandsNV.html" /></remarks>
        public static void CmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, int isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
        {
            VkPointers._vkCmdExecuteGeneratedCommandsNV_fnptr(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdFillBuffer.html" /></remarks>
        public static void CmdFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data)
        {
            VkPointers._vkCmdFillBuffer_fnptr(commandBuffer, dstBuffer, dstOffset, size, data);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdInitializeGraphScratchMemoryAMDX.html" /></remarks>
        public static void CmdInitializeGraphScratchMemoryAMDX(VkCommandBuffer commandBuffer, VkPipeline executionGraph, ulong scratch, ulong scratchSize)
        {
            VkPointers._vkCmdInitializeGraphScratchMemoryAMDX_fnptr(commandBuffer, executionGraph, scratch, scratchSize);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdInsertDebugUtilsLabelEXT.html" /></remarks>
        public static void CmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            VkPointers._vkCmdInsertDebugUtilsLabelEXT_fnptr(commandBuffer, pLabelInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass.html" /></remarks>
        public static void CmdNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents)
        {
            VkPointers._vkCmdNextSubpass_fnptr(commandBuffer, contents);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass2.html" /></remarks>
        public static void CmdNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo)
        {
            VkPointers._vkCmdNextSubpass2_fnptr(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
        }
        /// <summary><b>[requires: VK_KHR_create_renderpass2]</b> [device command]  Alias of <see cref="CmdNextSubpass2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass2KHR.html" /></remarks>
        public static void CmdNextSubpass2KHR(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo)
        {
            VkPointers._vkCmdNextSubpass2KHR_fnptr(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
        }
        /// <summary><b>[requires: VK_NV_optical_flow]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdOpticalFlowExecuteNV.html" /></remarks>
        public static void CmdOpticalFlowExecuteNV(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, VkOpticalFlowExecuteInfoNV* pExecuteInfo)
        {
            VkPointers._vkCmdOpticalFlowExecuteNV_fnptr(commandBuffer, session, pExecuteInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPipelineBarrier.html" /></remarks>
        public static void CmdPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits srcStageMask, VkPipelineStageFlagBits dstStageMask, VkDependencyFlagBits dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
        {
            VkPointers._vkCmdPipelineBarrier_fnptr(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPipelineBarrier2.html" /></remarks>
        public static void CmdPipelineBarrier2(VkCommandBuffer commandBuffer, VkDependencyInfo* pDependencyInfo)
        {
            VkPointers._vkCmdPipelineBarrier2_fnptr(commandBuffer, pDependencyInfo);
        }
        /// <summary><b>[requires: VK_KHR_synchronization2]</b> [device command]  Alias of <see cref="CmdPipelineBarrier2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPipelineBarrier2KHR.html" /></remarks>
        public static void CmdPipelineBarrier2KHR(VkCommandBuffer commandBuffer, VkDependencyInfo* pDependencyInfo)
        {
            VkPointers._vkCmdPipelineBarrier2KHR_fnptr(commandBuffer, pDependencyInfo);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsEXT.html" /></remarks>
        public static void CmdPreprocessGeneratedCommandsEXT(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoEXT* pGeneratedCommandsInfo, VkCommandBuffer stateCommandBuffer)
        {
            VkPointers._vkCmdPreprocessGeneratedCommandsEXT_fnptr(commandBuffer, pGeneratedCommandsInfo, stateCommandBuffer);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsNV.html" /></remarks>
        public static void CmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
        {
            VkPointers._vkCmdPreprocessGeneratedCommandsNV_fnptr(commandBuffer, pGeneratedCommandsInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushConstants.html" /></remarks>
        public static void CmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlagBits stageFlags, uint offset, uint size, void* pValues)
        {
            VkPointers._vkCmdPushConstants_fnptr(commandBuffer, layout, stageFlags, offset, size, pValues);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushConstants2.html" /></remarks>
        public static void CmdPushConstants2(VkCommandBuffer commandBuffer, VkPushConstantsInfo* pPushConstantsInfo)
        {
            VkPointers._vkCmdPushConstants2_fnptr(commandBuffer, pPushConstantsInfo);
        }
        /// <summary><b>[requires: VK_KHR_maintenance6]</b> [device command]  Alias of <see cref="CmdPushConstants2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushConstants2KHR.html" /></remarks>
        public static void CmdPushConstants2KHR(VkCommandBuffer commandBuffer, VkPushConstantsInfo* pPushConstantsInfo)
        {
            VkPointers._vkCmdPushConstants2KHR_fnptr(commandBuffer, pPushConstantsInfo);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSet.html" /></remarks>
        public static void CmdPushDescriptorSet(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
        {
            VkPointers._vkCmdPushDescriptorSet_fnptr(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSet2.html" /></remarks>
        public static void CmdPushDescriptorSet2(VkCommandBuffer commandBuffer, VkPushDescriptorSetInfo* pPushDescriptorSetInfo)
        {
            VkPointers._vkCmdPushDescriptorSet2_fnptr(commandBuffer, pPushDescriptorSetInfo);
        }
        /// <summary><b>[requires: VK_KHR_maintenance6]</b> [device command]  Alias of <see cref="CmdPushDescriptorSet2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSet2KHR.html" /></remarks>
        public static void CmdPushDescriptorSet2KHR(VkCommandBuffer commandBuffer, VkPushDescriptorSetInfo* pPushDescriptorSetInfo)
        {
            VkPointers._vkCmdPushDescriptorSet2KHR_fnptr(commandBuffer, pPushDescriptorSetInfo);
        }
        /// <summary><b>[requires: VK_KHR_push_descriptor]</b> [device command]  Alias of <see cref="CmdPushDescriptorSet"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetKHR.html" /></remarks>
        public static void CmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
        {
            VkPointers._vkCmdPushDescriptorSetKHR_fnptr(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetWithTemplate.html" /></remarks>
        public static void CmdPushDescriptorSetWithTemplate(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
        {
            VkPointers._vkCmdPushDescriptorSetWithTemplate_fnptr(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetWithTemplate2.html" /></remarks>
        public static void CmdPushDescriptorSetWithTemplate2(VkCommandBuffer commandBuffer, VkPushDescriptorSetWithTemplateInfo* pPushDescriptorSetWithTemplateInfo)
        {
            VkPointers._vkCmdPushDescriptorSetWithTemplate2_fnptr(commandBuffer, pPushDescriptorSetWithTemplateInfo);
        }
        /// <summary><b>[requires: VK_KHR_maintenance6]</b> [device command]  Alias of <see cref="CmdPushDescriptorSetWithTemplate2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetWithTemplate2KHR.html" /></remarks>
        public static void CmdPushDescriptorSetWithTemplate2KHR(VkCommandBuffer commandBuffer, VkPushDescriptorSetWithTemplateInfo* pPushDescriptorSetWithTemplateInfo)
        {
            VkPointers._vkCmdPushDescriptorSetWithTemplate2KHR_fnptr(commandBuffer, pPushDescriptorSetWithTemplateInfo);
        }
        /// <summary><b>[requires: VK_KHR_push_descriptor | VK_KHR_descriptor_update_template]</b> [device command]  Alias of <see cref="CmdPushDescriptorSetWithTemplate"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetWithTemplateKHR.html" /></remarks>
        public static void CmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
        {
            VkPointers._vkCmdPushDescriptorSetWithTemplateKHR_fnptr(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
        }
        /// <summary><b>[requires: VK_KHR_object_refresh]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdRefreshObjectsKHR.html" /></remarks>
        public static void CmdRefreshObjectsKHR(VkCommandBuffer commandBuffer, VkRefreshObjectListKHR* pRefreshObjects)
        {
            VkPointers._vkCmdRefreshObjectsKHR_fnptr(commandBuffer, pRefreshObjects);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResetEvent.html" /></remarks>
        public static void CmdResetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits stageMask)
        {
            VkPointers._vkCmdResetEvent_fnptr(commandBuffer, @event, stageMask);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResetEvent2.html" /></remarks>
        public static void CmdResetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits2 stageMask)
        {
            VkPointers._vkCmdResetEvent2_fnptr(commandBuffer, @event, stageMask);
        }
        /// <summary><b>[requires: VK_KHR_synchronization2]</b> [device command]  Alias of <see cref="CmdResetEvent2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResetEvent2KHR.html" /></remarks>
        public static void CmdResetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits2 stageMask)
        {
            VkPointers._vkCmdResetEvent2KHR_fnptr(commandBuffer, @event, stageMask);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResetQueryPool.html" /></remarks>
        public static void CmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            VkPointers._vkCmdResetQueryPool_fnptr(commandBuffer, queryPool, firstQuery, queryCount);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage.html" /></remarks>
        public static void CmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions)
        {
            VkPointers._vkCmdResolveImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage2.html" /></remarks>
        public static void CmdResolveImage2(VkCommandBuffer commandBuffer, VkResolveImageInfo2* pResolveImageInfo)
        {
            VkPointers._vkCmdResolveImage2_fnptr(commandBuffer, pResolveImageInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_commands2]</b> [device command]  Alias of <see cref="CmdResolveImage2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage2KHR.html" /></remarks>
        public static void CmdResolveImage2KHR(VkCommandBuffer commandBuffer, VkResolveImageInfo2* pResolveImageInfo)
        {
            VkPointers._vkCmdResolveImage2KHR_fnptr(commandBuffer, pResolveImageInfo);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetAlphaToCoverageEnableEXT.html" /></remarks>
        public static void CmdSetAlphaToCoverageEnableEXT(VkCommandBuffer commandBuffer, int alphaToCoverageEnable)
        {
            VkPointers._vkCmdSetAlphaToCoverageEnableEXT_fnptr(commandBuffer, alphaToCoverageEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetAlphaToOneEnableEXT.html" /></remarks>
        public static void CmdSetAlphaToOneEnableEXT(VkCommandBuffer commandBuffer, int alphaToOneEnable)
        {
            VkPointers._vkCmdSetAlphaToOneEnableEXT_fnptr(commandBuffer, alphaToOneEnable);
        }
        /// <summary><b>[requires: VK_EXT_attachment_feedback_loop_dynamic_state]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetAttachmentFeedbackLoopEnableEXT.html" /></remarks>
        public static void CmdSetAttachmentFeedbackLoopEnableEXT(VkCommandBuffer commandBuffer, VkImageAspectFlagBits aspectMask)
        {
            VkPointers._vkCmdSetAttachmentFeedbackLoopEnableEXT_fnptr(commandBuffer, aspectMask);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetBlendConstants.html" /></remarks>
        public static void CmdSetBlendConstants(VkCommandBuffer commandBuffer, float* blendConstants)
        {
            VkPointers._vkCmdSetBlendConstants_fnptr(commandBuffer, blendConstants);
        }
        /// <summary><b>[requires: VK_NV_device_diagnostic_checkpoints]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCheckpointNV.html" /></remarks>
        public static void CmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
        {
            VkPointers._vkCmdSetCheckpointNV_fnptr(commandBuffer, pCheckpointMarker);
        }
        /// <summary><b>[requires: VK_NV_shading_rate_image]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoarseSampleOrderNV.html" /></remarks>
        public static void CmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
        {
            VkPointers._vkCmdSetCoarseSampleOrderNV_fnptr(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorBlendAdvancedEXT.html" /></remarks>
        public static void CmdSetColorBlendAdvancedEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendAdvancedEXT* pColorBlendAdvanced)
        {
            VkPointers._vkCmdSetColorBlendAdvancedEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendAdvanced);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorBlendEnableEXT.html" /></remarks>
        public static void CmdSetColorBlendEnableEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, int* pColorBlendEnables)
        {
            VkPointers._vkCmdSetColorBlendEnableEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEnables);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorBlendEquationEXT.html" /></remarks>
        public static void CmdSetColorBlendEquationEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendEquationEXT* pColorBlendEquations)
        {
            VkPointers._vkCmdSetColorBlendEquationEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEquations);
        }
        /// <summary><b>[requires: VK_EXT_color_write_enable]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorWriteEnableEXT.html" /></remarks>
        public static void CmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, int* pColorWriteEnables)
        {
            VkPointers._vkCmdSetColorWriteEnableEXT_fnptr(commandBuffer, attachmentCount, pColorWriteEnables);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorWriteMaskEXT.html" /></remarks>
        public static void CmdSetColorWriteMaskEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorComponentFlagBits* pColorWriteMasks)
        {
            VkPointers._vkCmdSetColorWriteMaskEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorWriteMasks);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetConservativeRasterizationModeEXT.html" /></remarks>
        public static void CmdSetConservativeRasterizationModeEXT(VkCommandBuffer commandBuffer, VkConservativeRasterizationModeEXT conservativeRasterizationMode)
        {
            VkPointers._vkCmdSetConservativeRasterizationModeEXT_fnptr(commandBuffer, conservativeRasterizationMode);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageModulationModeNV.html" /></remarks>
        public static void CmdSetCoverageModulationModeNV(VkCommandBuffer commandBuffer, VkCoverageModulationModeNV coverageModulationMode)
        {
            VkPointers._vkCmdSetCoverageModulationModeNV_fnptr(commandBuffer, coverageModulationMode);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageModulationTableEnableNV.html" /></remarks>
        public static void CmdSetCoverageModulationTableEnableNV(VkCommandBuffer commandBuffer, int coverageModulationTableEnable)
        {
            VkPointers._vkCmdSetCoverageModulationTableEnableNV_fnptr(commandBuffer, coverageModulationTableEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageModulationTableNV.html" /></remarks>
        public static void CmdSetCoverageModulationTableNV(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, float* pCoverageModulationTable)
        {
            VkPointers._vkCmdSetCoverageModulationTableNV_fnptr(commandBuffer, coverageModulationTableCount, pCoverageModulationTable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageReductionModeNV.html" /></remarks>
        public static void CmdSetCoverageReductionModeNV(VkCommandBuffer commandBuffer, VkCoverageReductionModeNV coverageReductionMode)
        {
            VkPointers._vkCmdSetCoverageReductionModeNV_fnptr(commandBuffer, coverageReductionMode);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageToColorEnableNV.html" /></remarks>
        public static void CmdSetCoverageToColorEnableNV(VkCommandBuffer commandBuffer, int coverageToColorEnable)
        {
            VkPointers._vkCmdSetCoverageToColorEnableNV_fnptr(commandBuffer, coverageToColorEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageToColorLocationNV.html" /></remarks>
        public static void CmdSetCoverageToColorLocationNV(VkCommandBuffer commandBuffer, uint coverageToColorLocation)
        {
            VkPointers._vkCmdSetCoverageToColorLocationNV_fnptr(commandBuffer, coverageToColorLocation);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCullMode.html" /></remarks>
        public static void CmdSetCullMode(VkCommandBuffer commandBuffer, VkCullModeFlagBits cullMode)
        {
            VkPointers._vkCmdSetCullMode_fnptr(commandBuffer, cullMode);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetCullMode"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCullModeEXT.html" /></remarks>
        public static void CmdSetCullModeEXT(VkCommandBuffer commandBuffer, VkCullModeFlagBits cullMode)
        {
            VkPointers._vkCmdSetCullModeEXT_fnptr(commandBuffer, cullMode);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBias.html" /></remarks>
        public static void CmdSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            VkPointers._vkCmdSetDepthBias_fnptr(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
        }
        /// <summary><b>[requires: VK_EXT_depth_bias_control]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBias2EXT.html" /></remarks>
        public static void CmdSetDepthBias2EXT(VkCommandBuffer commandBuffer, VkDepthBiasInfoEXT* pDepthBiasInfo)
        {
            VkPointers._vkCmdSetDepthBias2EXT_fnptr(commandBuffer, pDepthBiasInfo);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBiasEnable.html" /></remarks>
        public static void CmdSetDepthBiasEnable(VkCommandBuffer commandBuffer, int depthBiasEnable)
        {
            VkPointers._vkCmdSetDepthBiasEnable_fnptr(commandBuffer, depthBiasEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state2 | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetDepthBiasEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBiasEnableEXT.html" /></remarks>
        public static void CmdSetDepthBiasEnableEXT(VkCommandBuffer commandBuffer, int depthBiasEnable)
        {
            VkPointers._vkCmdSetDepthBiasEnableEXT_fnptr(commandBuffer, depthBiasEnable);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBounds.html" /></remarks>
        public static void CmdSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds)
        {
            VkPointers._vkCmdSetDepthBounds_fnptr(commandBuffer, minDepthBounds, maxDepthBounds);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBoundsTestEnable.html" /></remarks>
        public static void CmdSetDepthBoundsTestEnable(VkCommandBuffer commandBuffer, int depthBoundsTestEnable)
        {
            VkPointers._vkCmdSetDepthBoundsTestEnable_fnptr(commandBuffer, depthBoundsTestEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetDepthBoundsTestEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBoundsTestEnableEXT.html" /></remarks>
        public static void CmdSetDepthBoundsTestEnableEXT(VkCommandBuffer commandBuffer, int depthBoundsTestEnable)
        {
            VkPointers._vkCmdSetDepthBoundsTestEnableEXT_fnptr(commandBuffer, depthBoundsTestEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClampEnableEXT.html" /></remarks>
        public static void CmdSetDepthClampEnableEXT(VkCommandBuffer commandBuffer, int depthClampEnable)
        {
            VkPointers._vkCmdSetDepthClampEnableEXT_fnptr(commandBuffer, depthClampEnable);
        }
        /// <summary><b>[requires: VK_EXT_shader_object | VK_EXT_depth_clamp_control]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClampRangeEXT.html" /></remarks>
        public static void CmdSetDepthClampRangeEXT(VkCommandBuffer commandBuffer, VkDepthClampModeEXT depthClampMode, VkDepthClampRangeEXT* pDepthClampRange)
        {
            VkPointers._vkCmdSetDepthClampRangeEXT_fnptr(commandBuffer, depthClampMode, pDepthClampRange);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClipEnableEXT.html" /></remarks>
        public static void CmdSetDepthClipEnableEXT(VkCommandBuffer commandBuffer, int depthClipEnable)
        {
            VkPointers._vkCmdSetDepthClipEnableEXT_fnptr(commandBuffer, depthClipEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClipNegativeOneToOneEXT.html" /></remarks>
        public static void CmdSetDepthClipNegativeOneToOneEXT(VkCommandBuffer commandBuffer, int negativeOneToOne)
        {
            VkPointers._vkCmdSetDepthClipNegativeOneToOneEXT_fnptr(commandBuffer, negativeOneToOne);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthCompareOp.html" /></remarks>
        public static void CmdSetDepthCompareOp(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp)
        {
            VkPointers._vkCmdSetDepthCompareOp_fnptr(commandBuffer, depthCompareOp);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetDepthCompareOp"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthCompareOpEXT.html" /></remarks>
        public static void CmdSetDepthCompareOpEXT(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp)
        {
            VkPointers._vkCmdSetDepthCompareOpEXT_fnptr(commandBuffer, depthCompareOp);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthTestEnable.html" /></remarks>
        public static void CmdSetDepthTestEnable(VkCommandBuffer commandBuffer, int depthTestEnable)
        {
            VkPointers._vkCmdSetDepthTestEnable_fnptr(commandBuffer, depthTestEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetDepthTestEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthTestEnableEXT.html" /></remarks>
        public static void CmdSetDepthTestEnableEXT(VkCommandBuffer commandBuffer, int depthTestEnable)
        {
            VkPointers._vkCmdSetDepthTestEnableEXT_fnptr(commandBuffer, depthTestEnable);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthWriteEnable.html" /></remarks>
        public static void CmdSetDepthWriteEnable(VkCommandBuffer commandBuffer, int depthWriteEnable)
        {
            VkPointers._vkCmdSetDepthWriteEnable_fnptr(commandBuffer, depthWriteEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetDepthWriteEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthWriteEnableEXT.html" /></remarks>
        public static void CmdSetDepthWriteEnableEXT(VkCommandBuffer commandBuffer, int depthWriteEnable)
        {
            VkPointers._vkCmdSetDepthWriteEnableEXT_fnptr(commandBuffer, depthWriteEnable);
        }
        /// <summary><b>[requires: VK_KHR_maintenance6]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDescriptorBufferOffsets2EXT.html" /></remarks>
        public static void CmdSetDescriptorBufferOffsets2EXT(VkCommandBuffer commandBuffer, VkSetDescriptorBufferOffsetsInfoEXT* pSetDescriptorBufferOffsetsInfo)
        {
            VkPointers._vkCmdSetDescriptorBufferOffsets2EXT_fnptr(commandBuffer, pSetDescriptorBufferOffsetsInfo);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDescriptorBufferOffsetsEXT.html" /></remarks>
        public static void CmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, ulong* pOffsets)
        {
            VkPointers._vkCmdSetDescriptorBufferOffsetsEXT_fnptr(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, pBufferIndices, pOffsets);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDeviceMask.html" /></remarks>
        public static void CmdSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask)
        {
            VkPointers._vkCmdSetDeviceMask_fnptr(commandBuffer, deviceMask);
        }
        /// <summary><b>[requires: VK_KHR_device_group]</b> [device command]  Alias of <see cref="CmdSetDeviceMask"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDeviceMaskKHR.html" /></remarks>
        public static void CmdSetDeviceMaskKHR(VkCommandBuffer commandBuffer, uint deviceMask)
        {
            VkPointers._vkCmdSetDeviceMaskKHR_fnptr(commandBuffer, deviceMask);
        }
        /// <summary><b>[requires: VK_EXT_discard_rectangles]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDiscardRectangleEnableEXT.html" /></remarks>
        public static void CmdSetDiscardRectangleEnableEXT(VkCommandBuffer commandBuffer, int discardRectangleEnable)
        {
            VkPointers._vkCmdSetDiscardRectangleEnableEXT_fnptr(commandBuffer, discardRectangleEnable);
        }
        /// <summary><b>[requires: VK_EXT_discard_rectangles]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDiscardRectangleEXT.html" /></remarks>
        public static void CmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
        {
            VkPointers._vkCmdSetDiscardRectangleEXT_fnptr(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);
        }
        /// <summary><b>[requires: VK_EXT_discard_rectangles]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDiscardRectangleModeEXT.html" /></remarks>
        public static void CmdSetDiscardRectangleModeEXT(VkCommandBuffer commandBuffer, VkDiscardRectangleModeEXT discardRectangleMode)
        {
            VkPointers._vkCmdSetDiscardRectangleModeEXT_fnptr(commandBuffer, discardRectangleMode);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetEvent.html" /></remarks>
        public static void CmdSetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits stageMask)
        {
            VkPointers._vkCmdSetEvent_fnptr(commandBuffer, @event, stageMask);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetEvent2.html" /></remarks>
        public static void CmdSetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfo* pDependencyInfo)
        {
            VkPointers._vkCmdSetEvent2_fnptr(commandBuffer, @event, pDependencyInfo);
        }
        /// <summary><b>[requires: VK_KHR_synchronization2]</b> [device command]  Alias of <see cref="CmdSetEvent2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetEvent2KHR.html" /></remarks>
        public static void CmdSetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfo* pDependencyInfo)
        {
            VkPointers._vkCmdSetEvent2KHR_fnptr(commandBuffer, @event, pDependencyInfo);
        }
        /// <summary><b>[requires: VK_NV_scissor_exclusive]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetExclusiveScissorEnableNV.html" /></remarks>
        public static void CmdSetExclusiveScissorEnableNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, int* pExclusiveScissorEnables)
        {
            VkPointers._vkCmdSetExclusiveScissorEnableNV_fnptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissorEnables);
        }
        /// <summary><b>[requires: VK_NV_scissor_exclusive]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetExclusiveScissorNV.html" /></remarks>
        public static void CmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
        {
            VkPointers._vkCmdSetExclusiveScissorNV_fnptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetExtraPrimitiveOverestimationSizeEXT.html" /></remarks>
        public static void CmdSetExtraPrimitiveOverestimationSizeEXT(VkCommandBuffer commandBuffer, float extraPrimitiveOverestimationSize)
        {
            VkPointers._vkCmdSetExtraPrimitiveOverestimationSizeEXT_fnptr(commandBuffer, extraPrimitiveOverestimationSize);
        }
        /// <summary><b>[requires: VK_NV_fragment_shading_rate_enums]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetFragmentShadingRateEnumNV.html" /></remarks>
        public static void CmdSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR* combinerOps)
        {
            VkPointers._vkCmdSetFragmentShadingRateEnumNV_fnptr(commandBuffer, shadingRate, combinerOps);
        }
        /// <summary><b>[requires: VK_KHR_fragment_shading_rate]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetFragmentShadingRateKHR.html" /></remarks>
        public static void CmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR* combinerOps)
        {
            VkPointers._vkCmdSetFragmentShadingRateKHR_fnptr(commandBuffer, pFragmentSize, combinerOps);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetFrontFace.html" /></remarks>
        public static void CmdSetFrontFace(VkCommandBuffer commandBuffer, VkFrontFace frontFace)
        {
            VkPointers._vkCmdSetFrontFace_fnptr(commandBuffer, frontFace);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetFrontFace"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetFrontFaceEXT.html" /></remarks>
        public static void CmdSetFrontFaceEXT(VkCommandBuffer commandBuffer, VkFrontFace frontFace)
        {
            VkPointers._vkCmdSetFrontFaceEXT_fnptr(commandBuffer, frontFace);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineRasterizationModeEXT.html" /></remarks>
        public static void CmdSetLineRasterizationModeEXT(VkCommandBuffer commandBuffer, VkLineRasterizationMode lineRasterizationMode)
        {
            VkPointers._vkCmdSetLineRasterizationModeEXT_fnptr(commandBuffer, lineRasterizationMode);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStipple.html" /></remarks>
        public static void CmdSetLineStipple(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
        {
            VkPointers._vkCmdSetLineStipple_fnptr(commandBuffer, lineStippleFactor, lineStipplePattern);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStippleEnableEXT.html" /></remarks>
        public static void CmdSetLineStippleEnableEXT(VkCommandBuffer commandBuffer, int stippledLineEnable)
        {
            VkPointers._vkCmdSetLineStippleEnableEXT_fnptr(commandBuffer, stippledLineEnable);
        }
        /// <summary><b>[requires: VK_EXT_line_rasterization]</b> [device command]  Alias of <see cref="CmdSetLineStipple"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStippleEXT.html" /></remarks>
        public static void CmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
        {
            VkPointers._vkCmdSetLineStippleEXT_fnptr(commandBuffer, lineStippleFactor, lineStipplePattern);
        }
        /// <summary><b>[requires: VK_KHR_line_rasterization]</b> [device command]  Alias of <see cref="CmdSetLineStipple"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStippleKHR.html" /></remarks>
        public static void CmdSetLineStippleKHR(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
        {
            VkPointers._vkCmdSetLineStippleKHR_fnptr(commandBuffer, lineStippleFactor, lineStipplePattern);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineWidth.html" /></remarks>
        public static void CmdSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth)
        {
            VkPointers._vkCmdSetLineWidth_fnptr(commandBuffer, lineWidth);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLogicOpEnableEXT.html" /></remarks>
        public static void CmdSetLogicOpEnableEXT(VkCommandBuffer commandBuffer, int logicOpEnable)
        {
            VkPointers._vkCmdSetLogicOpEnableEXT_fnptr(commandBuffer, logicOpEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state2 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLogicOpEXT.html" /></remarks>
        public static void CmdSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp)
        {
            VkPointers._vkCmdSetLogicOpEXT_fnptr(commandBuffer, logicOp);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state2 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPatchControlPointsEXT.html" /></remarks>
        public static void CmdSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, uint patchControlPoints)
        {
            VkPointers._vkCmdSetPatchControlPointsEXT_fnptr(commandBuffer, patchControlPoints);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPerformanceMarkerINTEL.html" /></remarks>
        public static VkResult CmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo)
        {
            return VkPointers._vkCmdSetPerformanceMarkerINTEL_fnptr(commandBuffer, pMarkerInfo);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPerformanceOverrideINTEL.html" /></remarks>
        public static VkResult CmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo)
        {
            return VkPointers._vkCmdSetPerformanceOverrideINTEL_fnptr(commandBuffer, pOverrideInfo);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPerformanceStreamMarkerINTEL.html" /></remarks>
        public static VkResult CmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo)
        {
            return VkPointers._vkCmdSetPerformanceStreamMarkerINTEL_fnptr(commandBuffer, pMarkerInfo);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPolygonModeEXT.html" /></remarks>
        public static void CmdSetPolygonModeEXT(VkCommandBuffer commandBuffer, VkPolygonMode polygonMode)
        {
            VkPointers._vkCmdSetPolygonModeEXT_fnptr(commandBuffer, polygonMode);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveRestartEnable.html" /></remarks>
        public static void CmdSetPrimitiveRestartEnable(VkCommandBuffer commandBuffer, int primitiveRestartEnable)
        {
            VkPointers._vkCmdSetPrimitiveRestartEnable_fnptr(commandBuffer, primitiveRestartEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state2 | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetPrimitiveRestartEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveRestartEnableEXT.html" /></remarks>
        public static void CmdSetPrimitiveRestartEnableEXT(VkCommandBuffer commandBuffer, int primitiveRestartEnable)
        {
            VkPointers._vkCmdSetPrimitiveRestartEnableEXT_fnptr(commandBuffer, primitiveRestartEnable);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveTopology.html" /></remarks>
        public static void CmdSetPrimitiveTopology(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology)
        {
            VkPointers._vkCmdSetPrimitiveTopology_fnptr(commandBuffer, primitiveTopology);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetPrimitiveTopology"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveTopologyEXT.html" /></remarks>
        public static void CmdSetPrimitiveTopologyEXT(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology)
        {
            VkPointers._vkCmdSetPrimitiveTopologyEXT_fnptr(commandBuffer, primitiveTopology);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetProvokingVertexModeEXT.html" /></remarks>
        public static void CmdSetProvokingVertexModeEXT(VkCommandBuffer commandBuffer, VkProvokingVertexModeEXT provokingVertexMode)
        {
            VkPointers._vkCmdSetProvokingVertexModeEXT_fnptr(commandBuffer, provokingVertexMode);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizationSamplesEXT.html" /></remarks>
        public static void CmdSetRasterizationSamplesEXT(VkCommandBuffer commandBuffer, VkSampleCountFlagBits rasterizationSamples)
        {
            VkPointers._vkCmdSetRasterizationSamplesEXT_fnptr(commandBuffer, rasterizationSamples);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizationStreamEXT.html" /></remarks>
        public static void CmdSetRasterizationStreamEXT(VkCommandBuffer commandBuffer, uint rasterizationStream)
        {
            VkPointers._vkCmdSetRasterizationStreamEXT_fnptr(commandBuffer, rasterizationStream);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizerDiscardEnable.html" /></remarks>
        public static void CmdSetRasterizerDiscardEnable(VkCommandBuffer commandBuffer, int rasterizerDiscardEnable)
        {
            VkPointers._vkCmdSetRasterizerDiscardEnable_fnptr(commandBuffer, rasterizerDiscardEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state2 | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetRasterizerDiscardEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizerDiscardEnableEXT.html" /></remarks>
        public static void CmdSetRasterizerDiscardEnableEXT(VkCommandBuffer commandBuffer, int rasterizerDiscardEnable)
        {
            VkPointers._vkCmdSetRasterizerDiscardEnableEXT_fnptr(commandBuffer, rasterizerDiscardEnable);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRayTracingPipelineStackSizeKHR.html" /></remarks>
        public static void CmdSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, uint pipelineStackSize)
        {
            VkPointers._vkCmdSetRayTracingPipelineStackSizeKHR_fnptr(commandBuffer, pipelineStackSize);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingAttachmentLocations.html" /></remarks>
        public static void CmdSetRenderingAttachmentLocations(VkCommandBuffer commandBuffer, VkRenderingAttachmentLocationInfo* pLocationInfo)
        {
            VkPointers._vkCmdSetRenderingAttachmentLocations_fnptr(commandBuffer, pLocationInfo);
        }
        /// <summary><b>[requires: VK_KHR_dynamic_rendering_local_read]</b> [device command]  Alias of <see cref="CmdSetRenderingAttachmentLocations"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingAttachmentLocationsKHR.html" /></remarks>
        public static void CmdSetRenderingAttachmentLocationsKHR(VkCommandBuffer commandBuffer, VkRenderingAttachmentLocationInfo* pLocationInfo)
        {
            VkPointers._vkCmdSetRenderingAttachmentLocationsKHR_fnptr(commandBuffer, pLocationInfo);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingInputAttachmentIndices.html" /></remarks>
        public static void CmdSetRenderingInputAttachmentIndices(VkCommandBuffer commandBuffer, VkRenderingInputAttachmentIndexInfo* pInputAttachmentIndexInfo)
        {
            VkPointers._vkCmdSetRenderingInputAttachmentIndices_fnptr(commandBuffer, pInputAttachmentIndexInfo);
        }
        /// <summary><b>[requires: VK_KHR_dynamic_rendering_local_read]</b> [device command]  Alias of <see cref="CmdSetRenderingInputAttachmentIndices"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingInputAttachmentIndicesKHR.html" /></remarks>
        public static void CmdSetRenderingInputAttachmentIndicesKHR(VkCommandBuffer commandBuffer, VkRenderingInputAttachmentIndexInfo* pInputAttachmentIndexInfo)
        {
            VkPointers._vkCmdSetRenderingInputAttachmentIndicesKHR_fnptr(commandBuffer, pInputAttachmentIndexInfo);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRepresentativeFragmentTestEnableNV.html" /></remarks>
        public static void CmdSetRepresentativeFragmentTestEnableNV(VkCommandBuffer commandBuffer, int representativeFragmentTestEnable)
        {
            VkPointers._vkCmdSetRepresentativeFragmentTestEnableNV_fnptr(commandBuffer, representativeFragmentTestEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleLocationsEnableEXT.html" /></remarks>
        public static void CmdSetSampleLocationsEnableEXT(VkCommandBuffer commandBuffer, int sampleLocationsEnable)
        {
            VkPointers._vkCmdSetSampleLocationsEnableEXT_fnptr(commandBuffer, sampleLocationsEnable);
        }
        /// <summary><b>[requires: VK_EXT_sample_locations]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleLocationsEXT.html" /></remarks>
        public static void CmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo)
        {
            VkPointers._vkCmdSetSampleLocationsEXT_fnptr(commandBuffer, pSampleLocationsInfo);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleMaskEXT.html" /></remarks>
        public static void CmdSetSampleMaskEXT(VkCommandBuffer commandBuffer, VkSampleCountFlagBits samples, uint* pSampleMask)
        {
            VkPointers._vkCmdSetSampleMaskEXT_fnptr(commandBuffer, samples, pSampleMask);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissor.html" /></remarks>
        public static void CmdSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors)
        {
            VkPointers._vkCmdSetScissor_fnptr(commandBuffer, firstScissor, scissorCount, pScissors);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissorWithCount.html" /></remarks>
        public static void CmdSetScissorWithCount(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors)
        {
            VkPointers._vkCmdSetScissorWithCount_fnptr(commandBuffer, scissorCount, pScissors);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetScissorWithCount"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissorWithCountEXT.html" /></remarks>
        public static void CmdSetScissorWithCountEXT(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors)
        {
            VkPointers._vkCmdSetScissorWithCountEXT_fnptr(commandBuffer, scissorCount, pScissors);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetShadingRateImageEnableNV.html" /></remarks>
        public static void CmdSetShadingRateImageEnableNV(VkCommandBuffer commandBuffer, int shadingRateImageEnable)
        {
            VkPointers._vkCmdSetShadingRateImageEnableNV_fnptr(commandBuffer, shadingRateImageEnable);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilCompareMask.html" /></remarks>
        public static void CmdSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, uint compareMask)
        {
            VkPointers._vkCmdSetStencilCompareMask_fnptr(commandBuffer, faceMask, compareMask);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilOp.html" /></remarks>
        public static void CmdSetStencilOp(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
        {
            VkPointers._vkCmdSetStencilOp_fnptr(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetStencilOp"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilOpEXT.html" /></remarks>
        public static void CmdSetStencilOpEXT(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
        {
            VkPointers._vkCmdSetStencilOpEXT_fnptr(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilReference.html" /></remarks>
        public static void CmdSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, uint reference)
        {
            VkPointers._vkCmdSetStencilReference_fnptr(commandBuffer, faceMask, reference);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilTestEnable.html" /></remarks>
        public static void CmdSetStencilTestEnable(VkCommandBuffer commandBuffer, int stencilTestEnable)
        {
            VkPointers._vkCmdSetStencilTestEnable_fnptr(commandBuffer, stencilTestEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetStencilTestEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilTestEnableEXT.html" /></remarks>
        public static void CmdSetStencilTestEnableEXT(VkCommandBuffer commandBuffer, int stencilTestEnable)
        {
            VkPointers._vkCmdSetStencilTestEnableEXT_fnptr(commandBuffer, stencilTestEnable);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilWriteMask.html" /></remarks>
        public static void CmdSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, uint writeMask)
        {
            VkPointers._vkCmdSetStencilWriteMask_fnptr(commandBuffer, faceMask, writeMask);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetTessellationDomainOriginEXT.html" /></remarks>
        public static void CmdSetTessellationDomainOriginEXT(VkCommandBuffer commandBuffer, VkTessellationDomainOrigin domainOrigin)
        {
            VkPointers._vkCmdSetTessellationDomainOriginEXT_fnptr(commandBuffer, domainOrigin);
        }
        /// <summary><b>[requires: VK_EXT_vertex_input_dynamic_state | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetVertexInputEXT.html" /></remarks>
        public static void CmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
        {
            VkPointers._vkCmdSetVertexInputEXT_fnptr(commandBuffer, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, pVertexAttributeDescriptions);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewport.html" /></remarks>
        public static void CmdSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports)
        {
            VkPointers._vkCmdSetViewport_fnptr(commandBuffer, firstViewport, viewportCount, pViewports);
        }
        /// <summary><b>[requires: VK_NV_shading_rate_image]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportShadingRatePaletteNV.html" /></remarks>
        public static void CmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
        {
            VkPointers._vkCmdSetViewportShadingRatePaletteNV_fnptr(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportSwizzleNV.html" /></remarks>
        public static void CmdSetViewportSwizzleNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportSwizzleNV* pViewportSwizzles)
        {
            VkPointers._vkCmdSetViewportSwizzleNV_fnptr(commandBuffer, firstViewport, viewportCount, pViewportSwizzles);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWithCount.html" /></remarks>
        public static void CmdSetViewportWithCount(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports)
        {
            VkPointers._vkCmdSetViewportWithCount_fnptr(commandBuffer, viewportCount, pViewports);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetViewportWithCount"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWithCountEXT.html" /></remarks>
        public static void CmdSetViewportWithCountEXT(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports)
        {
            VkPointers._vkCmdSetViewportWithCountEXT_fnptr(commandBuffer, viewportCount, pViewports);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWScalingEnableNV.html" /></remarks>
        public static void CmdSetViewportWScalingEnableNV(VkCommandBuffer commandBuffer, int viewportWScalingEnable)
        {
            VkPointers._vkCmdSetViewportWScalingEnableNV_fnptr(commandBuffer, viewportWScalingEnable);
        }
        /// <summary><b>[requires: VK_NV_clip_space_w_scaling]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWScalingNV.html" /></remarks>
        public static void CmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
        {
            VkPointers._vkCmdSetViewportWScalingNV_fnptr(commandBuffer, firstViewport, viewportCount, pViewportWScalings);
        }
        /// <summary><b>[requires: VK_HUAWEI_subpass_shading]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSubpassShadingHUAWEI.html" /></remarks>
        public static void CmdSubpassShadingHUAWEI(VkCommandBuffer commandBuffer)
        {
            VkPointers._vkCmdSubpassShadingHUAWEI_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_maintenance1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysIndirect2KHR.html" /></remarks>
        public static void CmdTraceRaysIndirect2KHR(VkCommandBuffer commandBuffer, ulong indirectDeviceAddress)
        {
            VkPointers._vkCmdTraceRaysIndirect2KHR_fnptr(commandBuffer, indirectDeviceAddress);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysIndirectKHR.html" /></remarks>
        public static void CmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            VkPointers._vkCmdTraceRaysIndirectKHR_fnptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysKHR.html" /></remarks>
        public static void CmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            VkPointers._vkCmdTraceRaysKHR_fnptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysNV.html" /></remarks>
        public static void CmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
        {
            VkPointers._vkCmdTraceRaysNV_fnptr(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdUpdateBuffer.html" /></remarks>
        public static void CmdUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData)
        {
            VkPointers._vkCmdUpdateBuffer_fnptr(commandBuffer, dstBuffer, dstOffset, dataSize, pData);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands_compute]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdUpdatePipelineIndirectBufferNV.html" /></remarks>
        public static void CmdUpdatePipelineIndirectBufferNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
        {
            VkPointers._vkCmdUpdatePipelineIndirectBufferNV_fnptr(commandBuffer, pipelineBindPoint, pipeline);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWaitEvents.html" /></remarks>
        public static void CmdWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlagBits srcStageMask, VkPipelineStageFlagBits dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
        {
            VkPointers._vkCmdWaitEvents_fnptr(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWaitEvents2.html" /></remarks>
        public static void CmdWaitEvents2(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfo* pDependencyInfos)
        {
            VkPointers._vkCmdWaitEvents2_fnptr(commandBuffer, eventCount, pEvents, pDependencyInfos);
        }
        /// <summary><b>[requires: VK_KHR_synchronization2]</b> [device command]  Alias of <see cref="CmdWaitEvents2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWaitEvents2KHR.html" /></remarks>
        public static void CmdWaitEvents2KHR(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfo* pDependencyInfos)
        {
            VkPointers._vkCmdWaitEvents2KHR_fnptr(commandBuffer, eventCount, pEvents, pDependencyInfos);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesKHR.html" /></remarks>
        public static void CmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            VkPointers._vkCmdWriteAccelerationStructuresPropertiesKHR_fnptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesNV.html" /></remarks>
        public static void CmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            VkPointers._vkCmdWriteAccelerationStructuresPropertiesNV_fnptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
        /// <summary><b>[requires: VK_AMD_buffer_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteBufferMarker2AMD.html" /></remarks>
        public static void CmdWriteBufferMarker2AMD(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits2 stage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
        {
            VkPointers._vkCmdWriteBufferMarker2AMD_fnptr(commandBuffer, stage, dstBuffer, dstOffset, marker);
        }
        /// <summary><b>[requires: VK_AMD_buffer_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteBufferMarkerAMD.html" /></remarks>
        public static void CmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
        {
            VkPointers._vkCmdWriteBufferMarkerAMD_fnptr(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteMicromapsPropertiesEXT.html" /></remarks>
        public static void CmdWriteMicromapsPropertiesEXT(VkCommandBuffer commandBuffer, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            VkPointers._vkCmdWriteMicromapsPropertiesEXT_fnptr(commandBuffer, micromapCount, pMicromaps, queryType, queryPool, firstQuery);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp.html" /></remarks>
        public static void CmdWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint query)
        {
            VkPointers._vkCmdWriteTimestamp_fnptr(commandBuffer, pipelineStage, queryPool, query);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp2.html" /></remarks>
        public static void CmdWriteTimestamp2(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits2 stage, VkQueryPool queryPool, uint query)
        {
            VkPointers._vkCmdWriteTimestamp2_fnptr(commandBuffer, stage, queryPool, query);
        }
        /// <summary><b>[requires: VK_KHR_synchronization2]</b> [device command]  Alias of <see cref="CmdWriteTimestamp2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp2KHR.html" /></remarks>
        public static void CmdWriteTimestamp2KHR(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits2 stage, VkQueryPool queryPool, uint query)
        {
            VkPointers._vkCmdWriteTimestamp2KHR_fnptr(commandBuffer, stage, queryPool, query);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCompileDeferredNV.html" /></remarks>
        public static VkResult CompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader)
        {
            return VkPointers._vkCompileDeferredNV_fnptr(device, pipeline, shader);
        }
        /// <summary><b>[requires: VK_NV_cooperative_vector]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkConvertCooperativeVectorMatrixNV.html" /></remarks>
        public static VkResult ConvertCooperativeVectorMatrixNV(VkDevice device, VkConvertCooperativeVectorMatrixInfoNV* pInfo)
        {
            return VkPointers._vkConvertCooperativeVectorMatrixNV_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyAccelerationStructureKHR.html" /></remarks>
        public static VkResult CopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo)
        {
            return VkPointers._vkCopyAccelerationStructureKHR_fnptr(device, deferredOperation, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyAccelerationStructureToMemoryKHR.html" /></remarks>
        public static VkResult CopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
        {
            return VkPointers._vkCopyAccelerationStructureToMemoryKHR_fnptr(device, deferredOperation, pInfo);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyImageToImage.html" /></remarks>
        public static VkResult CopyImageToImage(VkDevice device, VkCopyImageToImageInfo* pCopyImageToImageInfo)
        {
            return VkPointers._vkCopyImageToImage_fnptr(device, pCopyImageToImageInfo);
        }
        /// <summary><b>[requires: VK_EXT_host_image_copy]</b> [device command]  Alias of <see cref="CopyImageToImage"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyImageToImageEXT.html" /></remarks>
        public static VkResult CopyImageToImageEXT(VkDevice device, VkCopyImageToImageInfo* pCopyImageToImageInfo)
        {
            return VkPointers._vkCopyImageToImageEXT_fnptr(device, pCopyImageToImageInfo);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyImageToMemory.html" /></remarks>
        public static VkResult CopyImageToMemory(VkDevice device, VkCopyImageToMemoryInfo* pCopyImageToMemoryInfo)
        {
            return VkPointers._vkCopyImageToMemory_fnptr(device, pCopyImageToMemoryInfo);
        }
        /// <summary><b>[requires: VK_EXT_host_image_copy]</b> [device command]  Alias of <see cref="CopyImageToMemory"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyImageToMemoryEXT.html" /></remarks>
        public static VkResult CopyImageToMemoryEXT(VkDevice device, VkCopyImageToMemoryInfo* pCopyImageToMemoryInfo)
        {
            return VkPointers._vkCopyImageToMemoryEXT_fnptr(device, pCopyImageToMemoryInfo);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToAccelerationStructureKHR.html" /></remarks>
        public static VkResult CopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
        {
            return VkPointers._vkCopyMemoryToAccelerationStructureKHR_fnptr(device, deferredOperation, pInfo);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToImage.html" /></remarks>
        public static VkResult CopyMemoryToImage(VkDevice device, VkCopyMemoryToImageInfo* pCopyMemoryToImageInfo)
        {
            return VkPointers._vkCopyMemoryToImage_fnptr(device, pCopyMemoryToImageInfo);
        }
        /// <summary><b>[requires: VK_EXT_host_image_copy]</b> [device command]  Alias of <see cref="CopyMemoryToImage"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToImageEXT.html" /></remarks>
        public static VkResult CopyMemoryToImageEXT(VkDevice device, VkCopyMemoryToImageInfo* pCopyMemoryToImageInfo)
        {
            return VkPointers._vkCopyMemoryToImageEXT_fnptr(device, pCopyMemoryToImageInfo);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToMicromapEXT.html" /></remarks>
        public static VkResult CopyMemoryToMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToMicromapInfoEXT* pInfo)
        {
            return VkPointers._vkCopyMemoryToMicromapEXT_fnptr(device, deferredOperation, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyMicromapEXT.html" /></remarks>
        public static VkResult CopyMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapInfoEXT* pInfo)
        {
            return VkPointers._vkCopyMicromapEXT_fnptr(device, deferredOperation, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyMicromapToMemoryEXT.html" /></remarks>
        public static VkResult CopyMicromapToMemoryEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapToMemoryInfoEXT* pInfo)
        {
            return VkPointers._vkCopyMicromapToMemoryEXT_fnptr(device, deferredOperation, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateAccelerationStructureKHR.html" /></remarks>
        public static VkResult CreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            return VkPointers._vkCreateAccelerationStructureKHR_fnptr(device, pCreateInfo, pAllocator, pAccelerationStructure);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateAccelerationStructureNV.html" /></remarks>
        public static VkResult CreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            return VkPointers._vkCreateAccelerationStructureNV_fnptr(device, pCreateInfo, pAllocator, pAccelerationStructure);
        }
        /// <summary><b>[requires: VK_KHR_android_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateAndroidSurfaceKHR.html" /></remarks>
        public static VkResult CreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateAndroidSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateBuffer.html" /></remarks>
        public static VkResult CreateBuffer(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer)
        {
            return VkPointers._vkCreateBuffer_fnptr(device, pCreateInfo, pAllocator, pBuffer);
        }
        /// <summary><b>[requires: VK_FUCHSIA_buffer_collection]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateBufferCollectionFUCHSIA.html" /></remarks>
        public static VkResult CreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            return VkPointers._vkCreateBufferCollectionFUCHSIA_fnptr(device, pCreateInfo, pAllocator, pCollection);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateBufferView.html" /></remarks>
        public static VkResult CreateBufferView(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView)
        {
            return VkPointers._vkCreateBufferView_fnptr(device, pCreateInfo, pAllocator, pView);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateCommandPool.html" /></remarks>
        public static VkResult CreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool)
        {
            return VkPointers._vkCreateCommandPool_fnptr(device, pCreateInfo, pAllocator, pCommandPool);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateComputePipelines.html" /></remarks>
        public static VkResult CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return VkPointers._vkCreateComputePipelines_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        /// <summary><b>[requires: VK_NV_cuda_kernel_launch]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateCudaFunctionNV.html" /></remarks>
        public static VkResult CreateCudaFunctionNV(VkDevice device, VkCudaFunctionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCudaFunctionNV* pFunction)
        {
            return VkPointers._vkCreateCudaFunctionNV_fnptr(device, pCreateInfo, pAllocator, pFunction);
        }
        /// <summary><b>[requires: VK_NV_cuda_kernel_launch]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateCudaModuleNV.html" /></remarks>
        public static VkResult CreateCudaModuleNV(VkDevice device, VkCudaModuleCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCudaModuleNV* pModule)
        {
            return VkPointers._vkCreateCudaModuleNV_fnptr(device, pCreateInfo, pAllocator, pModule);
        }
        /// <summary><b>[requires: VK_NVX_binary_import]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateCuFunctionNVX.html" /></remarks>
        public static VkResult CreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
        {
            return VkPointers._vkCreateCuFunctionNVX_fnptr(device, pCreateInfo, pAllocator, pFunction);
        }
        /// <summary><b>[requires: VK_NVX_binary_import]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateCuModuleNVX.html" /></remarks>
        public static VkResult CreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
        {
            return VkPointers._vkCreateCuModuleNVX_fnptr(device, pCreateInfo, pAllocator, pModule);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDataGraphPipelinesARM.html" /></remarks>
        public static VkResult CreateDataGraphPipelinesARM(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkDataGraphPipelineCreateInfoARM* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return VkPointers._vkCreateDataGraphPipelinesARM_fnptr(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDataGraphPipelineSessionARM.html" /></remarks>
        public static VkResult CreateDataGraphPipelineSessionARM(VkDevice device, VkDataGraphPipelineSessionCreateInfoARM* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDataGraphPipelineSessionARM* pSession)
        {
            return VkPointers._vkCreateDataGraphPipelineSessionARM_fnptr(device, pCreateInfo, pAllocator, pSession);
        }
        /// <summary><b>[requires: VK_EXT_debug_report]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDebugReportCallbackEXT.html" /></remarks>
        public static VkResult CreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            return VkPointers._vkCreateDebugReportCallbackEXT_fnptr(instance, pCreateInfo, pAllocator, pCallback);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDebugUtilsMessengerEXT.html" /></remarks>
        public static VkResult CreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            return VkPointers._vkCreateDebugUtilsMessengerEXT_fnptr(instance, pCreateInfo, pAllocator, pMessenger);
        }
        /// <summary><b>[requires: VK_KHR_deferred_host_operations]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDeferredOperationKHR.html" /></remarks>
        public static VkResult CreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation)
        {
            return VkPointers._vkCreateDeferredOperationKHR_fnptr(device, pAllocator, pDeferredOperation);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorPool.html" /></remarks>
        public static VkResult CreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool)
        {
            return VkPointers._vkCreateDescriptorPool_fnptr(device, pCreateInfo, pAllocator, pDescriptorPool);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorSetLayout.html" /></remarks>
        public static VkResult CreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout)
        {
            return VkPointers._vkCreateDescriptorSetLayout_fnptr(device, pCreateInfo, pAllocator, pSetLayout);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorUpdateTemplate.html" /></remarks>
        public static VkResult CreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate)
        {
            return VkPointers._vkCreateDescriptorUpdateTemplate_fnptr(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
        }
        /// <summary><b>[requires: VK_KHR_descriptor_update_template]</b> [device command]  Alias of <see cref="CreateDescriptorUpdateTemplate"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorUpdateTemplateKHR.html" /></remarks>
        public static VkResult CreateDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate)
        {
            return VkPointers._vkCreateDescriptorUpdateTemplateKHR_fnptr(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDevice.html" /></remarks>
        public static VkResult CreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice)
        {
            return VkPointers._vkCreateDevice_fnptr(physicalDevice, pCreateInfo, pAllocator, pDevice);
        }
        /// <summary><b>[requires: VK_EXT_directfb_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDirectFBSurfaceEXT.html" /></remarks>
        public static VkResult CreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateDirectFBSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDisplayModeKHR.html" /></remarks>
        public static VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
        {
            return VkPointers._vkCreateDisplayModeKHR_fnptr(physicalDevice, display, pCreateInfo, pAllocator, pMode);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDisplayPlaneSurfaceKHR.html" /></remarks>
        public static VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateDisplayPlaneSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateEvent.html" /></remarks>
        public static VkResult CreateEvent(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent)
        {
            return VkPointers._vkCreateEvent_fnptr(device, pCreateInfo, pAllocator, pEvent);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateExecutionGraphPipelinesAMDX.html" /></remarks>
        public static VkResult CreateExecutionGraphPipelinesAMDX(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return VkPointers._vkCreateExecutionGraphPipelinesAMDX_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        /// <summary><b>[requires: VK_NV_external_compute_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateExternalComputeQueueNV.html" /></remarks>
        public static VkResult CreateExternalComputeQueueNV(VkDevice device, VkExternalComputeQueueCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkExternalComputeQueueNV* pExternalQueue)
        {
            return VkPointers._vkCreateExternalComputeQueueNV_fnptr(device, pCreateInfo, pAllocator, pExternalQueue);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateFence.html" /></remarks>
        public static VkResult CreateFence(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            return VkPointers._vkCreateFence_fnptr(device, pCreateInfo, pAllocator, pFence);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateFramebuffer.html" /></remarks>
        public static VkResult CreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer)
        {
            return VkPointers._vkCreateFramebuffer_fnptr(device, pCreateInfo, pAllocator, pFramebuffer);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateGraphicsPipelines.html" /></remarks>
        public static VkResult CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return VkPointers._vkCreateGraphicsPipelines_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        /// <summary><b>[requires: VK_EXT_headless_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateHeadlessSurfaceEXT.html" /></remarks>
        public static VkResult CreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateHeadlessSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateImage.html" /></remarks>
        public static VkResult CreateImage(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage)
        {
            return VkPointers._vkCreateImage_fnptr(device, pCreateInfo, pAllocator, pImage);
        }
        /// <summary><b>[requires: VK_FUCHSIA_imagepipe_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateImagePipeSurfaceFUCHSIA.html" /></remarks>
        public static VkResult CreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateImagePipeSurfaceFUCHSIA_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateImageView.html" /></remarks>
        public static VkResult CreateImageView(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView)
        {
            return VkPointers._vkCreateImageView_fnptr(device, pCreateInfo, pAllocator, pView);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateIndirectCommandsLayoutEXT.html" /></remarks>
        public static VkResult CreateIndirectCommandsLayoutEXT(VkDevice device, VkIndirectCommandsLayoutCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutEXT* pIndirectCommandsLayout)
        {
            return VkPointers._vkCreateIndirectCommandsLayoutEXT_fnptr(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateIndirectCommandsLayoutNV.html" /></remarks>
        public static VkResult CreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            return VkPointers._vkCreateIndirectCommandsLayoutNV_fnptr(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateIndirectExecutionSetEXT.html" /></remarks>
        public static VkResult CreateIndirectExecutionSetEXT(VkDevice device, VkIndirectExecutionSetCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectExecutionSetEXT* pIndirectExecutionSet)
        {
            return VkPointers._vkCreateIndirectExecutionSetEXT_fnptr(device, pCreateInfo, pAllocator, pIndirectExecutionSet);
        }
        /// <summary><b>[requires: v1.0]</b> [global command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateInstance.html" /></remarks>
        public static VkResult CreateInstance(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance)
        {
            return VkPointers._vkCreateInstance_fnptr(pCreateInfo, pAllocator, pInstance);
        }
        /// <summary><b>[requires: VK_MVK_ios_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateIOSSurfaceMVK.html" /></remarks>
        public static VkResult CreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateIOSSurfaceMVK_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_MVK_macos_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateMacOSSurfaceMVK.html" /></remarks>
        public static VkResult CreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateMacOSSurfaceMVK_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_EXT_metal_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateMetalSurfaceEXT.html" /></remarks>
        public static VkResult CreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateMetalSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateMicromapEXT.html" /></remarks>
        public static VkResult CreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap)
        {
            return VkPointers._vkCreateMicromapEXT_fnptr(device, pCreateInfo, pAllocator, pMicromap);
        }
        /// <summary><b>[requires: VK_NV_optical_flow]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateOpticalFlowSessionNV.html" /></remarks>
        public static VkResult CreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            return VkPointers._vkCreateOpticalFlowSessionNV_fnptr(device, pCreateInfo, pAllocator, pSession);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_binary]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineBinariesKHR.html" /></remarks>
        public static VkResult CreatePipelineBinariesKHR(VkDevice device, VkPipelineBinaryCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineBinaryHandlesInfoKHR* pBinaries)
        {
            return VkPointers._vkCreatePipelineBinariesKHR_fnptr(device, pCreateInfo, pAllocator, pBinaries);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineCache.html" /></remarks>
        public static VkResult CreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache)
        {
            return VkPointers._vkCreatePipelineCache_fnptr(device, pCreateInfo, pAllocator, pPipelineCache);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineLayout.html" /></remarks>
        public static VkResult CreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout)
        {
            return VkPointers._vkCreatePipelineLayout_fnptr(device, pCreateInfo, pAllocator, pPipelineLayout);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreatePrivateDataSlot.html" /></remarks>
        public static VkResult CreatePrivateDataSlot(VkDevice device, VkPrivateDataSlotCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlot* pPrivateDataSlot)
        {
            return VkPointers._vkCreatePrivateDataSlot_fnptr(device, pCreateInfo, pAllocator, pPrivateDataSlot);
        }
        /// <summary><b>[requires: VK_EXT_private_data]</b> [device command]  Alias of <see cref="CreatePrivateDataSlot"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreatePrivateDataSlotEXT.html" /></remarks>
        public static VkResult CreatePrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlot* pPrivateDataSlot)
        {
            return VkPointers._vkCreatePrivateDataSlotEXT_fnptr(device, pCreateInfo, pAllocator, pPrivateDataSlot);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateQueryPool.html" /></remarks>
        public static VkResult CreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool)
        {
            return VkPointers._vkCreateQueryPool_fnptr(device, pCreateInfo, pAllocator, pQueryPool);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateRayTracingPipelinesKHR.html" /></remarks>
        public static VkResult CreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return VkPointers._vkCreateRayTracingPipelinesKHR_fnptr(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateRayTracingPipelinesNV.html" /></remarks>
        public static VkResult CreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return VkPointers._vkCreateRayTracingPipelinesNV_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateRenderPass.html" /></remarks>
        public static VkResult CreateRenderPass(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
        {
            return VkPointers._vkCreateRenderPass_fnptr(device, pCreateInfo, pAllocator, pRenderPass);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateRenderPass2.html" /></remarks>
        public static VkResult CreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
        {
            return VkPointers._vkCreateRenderPass2_fnptr(device, pCreateInfo, pAllocator, pRenderPass);
        }
        /// <summary><b>[requires: VK_KHR_create_renderpass2]</b> [device command]  Alias of <see cref="CreateRenderPass2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateRenderPass2KHR.html" /></remarks>
        public static VkResult CreateRenderPass2KHR(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
        {
            return VkPointers._vkCreateRenderPass2KHR_fnptr(device, pCreateInfo, pAllocator, pRenderPass);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSampler.html" /></remarks>
        public static VkResult CreateSampler(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler)
        {
            return VkPointers._vkCreateSampler_fnptr(device, pCreateInfo, pAllocator, pSampler);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSamplerYcbcrConversion.html" /></remarks>
        public static VkResult CreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion)
        {
            return VkPointers._vkCreateSamplerYcbcrConversion_fnptr(device, pCreateInfo, pAllocator, pYcbcrConversion);
        }
        /// <summary><b>[requires: VK_KHR_sampler_ycbcr_conversion]</b> [device command]  Alias of <see cref="CreateSamplerYcbcrConversion"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSamplerYcbcrConversionKHR.html" /></remarks>
        public static VkResult CreateSamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion)
        {
            return VkPointers._vkCreateSamplerYcbcrConversionKHR_fnptr(device, pCreateInfo, pAllocator, pYcbcrConversion);
        }
        /// <summary><b>[requires: VK_QNX_screen_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateScreenSurfaceQNX.html" /></remarks>
        public static VkResult CreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateScreenSurfaceQNX_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSemaphore.html" /></remarks>
        public static VkResult CreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore)
        {
            return VkPointers._vkCreateSemaphore_fnptr(device, pCreateInfo, pAllocator, pSemaphore);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSemaphoreSciSyncPoolNV.html" /></remarks>
        public static VkResult CreateSemaphoreSciSyncPoolNV(VkDevice device, VkSemaphoreSciSyncPoolCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphoreSciSyncPoolNV* pSemaphorePool)
        {
            return VkPointers._vkCreateSemaphoreSciSyncPoolNV_fnptr(device, pCreateInfo, pAllocator, pSemaphorePool);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateShaderModule.html" /></remarks>
        public static VkResult CreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule)
        {
            return VkPointers._vkCreateShaderModule_fnptr(device, pCreateInfo, pAllocator, pShaderModule);
        }
        /// <summary><b>[requires: VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateShadersEXT.html" /></remarks>
        public static VkResult CreateShadersEXT(VkDevice device, uint createInfoCount, VkShaderCreateInfoEXT* pCreateInfos, VkAllocationCallbacks* pAllocator, VkShaderEXT* pShaders)
        {
            return VkPointers._vkCreateShadersEXT_fnptr(device, createInfoCount, pCreateInfos, pAllocator, pShaders);
        }
        /// <summary><b>[requires: VK_KHR_display_swapchain]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSharedSwapchainsKHR.html" /></remarks>
        public static VkResult CreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
        {
            return VkPointers._vkCreateSharedSwapchainsKHR_fnptr(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);
        }
        /// <summary><b>[requires: VK_GGP_stream_descriptor_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateStreamDescriptorSurfaceGGP.html" /></remarks>
        public static VkResult CreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateStreamDescriptorSurfaceGGP_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_OHOS_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSurfaceOHOS.html" /></remarks>
        public static VkResult CreateSurfaceOHOS(VkInstance instance, VkSurfaceCreateInfoOHOS* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateSurfaceOHOS_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_KHR_swapchain]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSwapchainKHR.html" /></remarks>
        public static VkResult CreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
        {
            return VkPointers._vkCreateSwapchainKHR_fnptr(device, pCreateInfo, pAllocator, pSwapchain);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateTensorARM.html" /></remarks>
        public static VkResult CreateTensorARM(VkDevice device, VkTensorCreateInfoARM* pCreateInfo, VkAllocationCallbacks* pAllocator, VkTensorARM* pTensor)
        {
            return VkPointers._vkCreateTensorARM_fnptr(device, pCreateInfo, pAllocator, pTensor);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateTensorViewARM.html" /></remarks>
        public static VkResult CreateTensorViewARM(VkDevice device, VkTensorViewCreateInfoARM* pCreateInfo, VkAllocationCallbacks* pAllocator, VkTensorViewARM* pView)
        {
            return VkPointers._vkCreateTensorViewARM_fnptr(device, pCreateInfo, pAllocator, pView);
        }
        /// <summary><b>[requires: VK_EXT_validation_cache]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateValidationCacheEXT.html" /></remarks>
        public static VkResult CreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            return VkPointers._vkCreateValidationCacheEXT_fnptr(device, pCreateInfo, pAllocator, pValidationCache);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateVideoSessionKHR.html" /></remarks>
        public static VkResult CreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            return VkPointers._vkCreateVideoSessionKHR_fnptr(device, pCreateInfo, pAllocator, pVideoSession);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateVideoSessionParametersKHR.html" /></remarks>
        public static VkResult CreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            return VkPointers._vkCreateVideoSessionParametersKHR_fnptr(device, pCreateInfo, pAllocator, pVideoSessionParameters);
        }
        /// <summary><b>[requires: VK_NN_vi_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateViSurfaceNN.html" /></remarks>
        public static VkResult CreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateViSurfaceNN_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_KHR_wayland_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateWaylandSurfaceKHR.html" /></remarks>
        public static VkResult CreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateWaylandSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_KHR_win32_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateWin32SurfaceKHR.html" /></remarks>
        public static VkResult CreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateWin32SurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_KHR_xcb_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateXcbSurfaceKHR.html" /></remarks>
        public static VkResult CreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateXcbSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_KHR_xlib_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateXlibSurfaceKHR.html" /></remarks>
        public static VkResult CreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return VkPointers._vkCreateXlibSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_EXT_debug_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDebugMarkerSetObjectNameEXT.html" /></remarks>
        public static VkResult DebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)
        {
            return VkPointers._vkDebugMarkerSetObjectNameEXT_fnptr(device, pNameInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDebugMarkerSetObjectTagEXT.html" /></remarks>
        public static VkResult DebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)
        {
            return VkPointers._vkDebugMarkerSetObjectTagEXT_fnptr(device, pTagInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_report]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDebugReportMessageEXT.html" /></remarks>
        public static void DebugReportMessageEXT(VkInstance instance, VkDebugReportFlagBitsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong obj, nuint location, int messageCode, byte* pLayerPrefix, byte* pMessage)
        {
            VkPointers._vkDebugReportMessageEXT_fnptr(instance, flags, objectType, obj, location, messageCode, pLayerPrefix, pMessage);
        }
        /// <summary><b>[requires: VK_KHR_deferred_host_operations]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDeferredOperationJoinKHR.html" /></remarks>
        public static VkResult DeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation)
        {
            return VkPointers._vkDeferredOperationJoinKHR_fnptr(device, operation);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyAccelerationStructureKHR.html" /></remarks>
        public static void DestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyAccelerationStructureKHR_fnptr(device, accelerationStructure, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyAccelerationStructureNV.html" /></remarks>
        public static void DestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyAccelerationStructureNV_fnptr(device, accelerationStructure, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyBuffer.html" /></remarks>
        public static void DestroyBuffer(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyBuffer_fnptr(device, buffer, pAllocator);
        }
        /// <summary><b>[requires: VK_FUCHSIA_buffer_collection]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyBufferCollectionFUCHSIA.html" /></remarks>
        public static void DestroyBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyBufferCollectionFUCHSIA_fnptr(device, collection, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyBufferView.html" /></remarks>
        public static void DestroyBufferView(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyBufferView_fnptr(device, bufferView, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyCommandPool.html" /></remarks>
        public static void DestroyCommandPool(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCommandPool_fnptr(device, commandPool, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_cuda_kernel_launch]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyCudaFunctionNV.html" /></remarks>
        public static void DestroyCudaFunctionNV(VkDevice device, VkCudaFunctionNV function, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCudaFunctionNV_fnptr(device, function, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_cuda_kernel_launch]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyCudaModuleNV.html" /></remarks>
        public static void DestroyCudaModuleNV(VkDevice device, VkCudaModuleNV module, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCudaModuleNV_fnptr(device, module, pAllocator);
        }
        /// <summary><b>[requires: VK_NVX_binary_import]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyCuFunctionNVX.html" /></remarks>
        public static void DestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCuFunctionNVX_fnptr(device, function, pAllocator);
        }
        /// <summary><b>[requires: VK_NVX_binary_import]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyCuModuleNVX.html" /></remarks>
        public static void DestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyCuModuleNVX_fnptr(device, module, pAllocator);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDataGraphPipelineSessionARM.html" /></remarks>
        public static void DestroyDataGraphPipelineSessionARM(VkDevice device, VkDataGraphPipelineSessionARM session, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDataGraphPipelineSessionARM_fnptr(device, session, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_debug_report]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDebugReportCallbackEXT.html" /></remarks>
        public static void DestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDebugReportCallbackEXT_fnptr(instance, callback, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDebugUtilsMessengerEXT.html" /></remarks>
        public static void DestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDebugUtilsMessengerEXT_fnptr(instance, messenger, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_deferred_host_operations]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDeferredOperationKHR.html" /></remarks>
        public static void DestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDeferredOperationKHR_fnptr(device, operation, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorPool.html" /></remarks>
        public static void DestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDescriptorPool_fnptr(device, descriptorPool, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorSetLayout.html" /></remarks>
        public static void DestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDescriptorSetLayout_fnptr(device, descriptorSetLayout, pAllocator);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorUpdateTemplate.html" /></remarks>
        public static void DestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDescriptorUpdateTemplate_fnptr(device, descriptorUpdateTemplate, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_descriptor_update_template]</b> [device command]  Alias of <see cref="DestroyDescriptorUpdateTemplate"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorUpdateTemplateKHR.html" /></remarks>
        public static void DestroyDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDescriptorUpdateTemplateKHR_fnptr(device, descriptorUpdateTemplate, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDevice.html" /></remarks>
        public static void DestroyDevice(VkDevice device, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyDevice_fnptr(device, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyEvent.html" /></remarks>
        public static void DestroyEvent(VkDevice device, VkEvent @event, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyEvent_fnptr(device, @event, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_external_compute_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyExternalComputeQueueNV.html" /></remarks>
        public static void DestroyExternalComputeQueueNV(VkDevice device, VkExternalComputeQueueNV externalQueue, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyExternalComputeQueueNV_fnptr(device, externalQueue, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyFence.html" /></remarks>
        public static void DestroyFence(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyFence_fnptr(device, fence, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyFramebuffer.html" /></remarks>
        public static void DestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyFramebuffer_fnptr(device, framebuffer, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyImage.html" /></remarks>
        public static void DestroyImage(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyImage_fnptr(device, image, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyImageView.html" /></remarks>
        public static void DestroyImageView(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyImageView_fnptr(device, imageView, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyIndirectCommandsLayoutEXT.html" /></remarks>
        public static void DestroyIndirectCommandsLayoutEXT(VkDevice device, VkIndirectCommandsLayoutEXT indirectCommandsLayout, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyIndirectCommandsLayoutEXT_fnptr(device, indirectCommandsLayout, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyIndirectCommandsLayoutNV.html" /></remarks>
        public static void DestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyIndirectCommandsLayoutNV_fnptr(device, indirectCommandsLayout, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyIndirectExecutionSetEXT.html" /></remarks>
        public static void DestroyIndirectExecutionSetEXT(VkDevice device, VkIndirectExecutionSetEXT indirectExecutionSet, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyIndirectExecutionSetEXT_fnptr(device, indirectExecutionSet, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyInstance.html" /></remarks>
        public static void DestroyInstance(VkInstance instance, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyInstance_fnptr(instance, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyMicromapEXT.html" /></remarks>
        public static void DestroyMicromapEXT(VkDevice device, VkMicromapEXT micromap, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyMicromapEXT_fnptr(device, micromap, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_optical_flow]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyOpticalFlowSessionNV.html" /></remarks>
        public static void DestroyOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionNV session, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyOpticalFlowSessionNV_fnptr(device, session, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyPipeline.html" /></remarks>
        public static void DestroyPipeline(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPipeline_fnptr(device, pipeline, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_binary]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyPipelineBinaryKHR.html" /></remarks>
        public static void DestroyPipelineBinaryKHR(VkDevice device, VkPipelineBinaryKHR pipelineBinary, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPipelineBinaryKHR_fnptr(device, pipelineBinary, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyPipelineCache.html" /></remarks>
        public static void DestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPipelineCache_fnptr(device, pipelineCache, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyPipelineLayout.html" /></remarks>
        public static void DestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPipelineLayout_fnptr(device, pipelineLayout, pAllocator);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyPrivateDataSlot.html" /></remarks>
        public static void DestroyPrivateDataSlot(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPrivateDataSlot_fnptr(device, privateDataSlot, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_private_data]</b> [device command]  Alias of <see cref="DestroyPrivateDataSlot"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyPrivateDataSlotEXT.html" /></remarks>
        public static void DestroyPrivateDataSlotEXT(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyPrivateDataSlotEXT_fnptr(device, privateDataSlot, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyQueryPool.html" /></remarks>
        public static void DestroyQueryPool(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyQueryPool_fnptr(device, queryPool, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyRenderPass.html" /></remarks>
        public static void DestroyRenderPass(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyRenderPass_fnptr(device, renderPass, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySampler.html" /></remarks>
        public static void DestroySampler(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySampler_fnptr(device, sampler, pAllocator);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySamplerYcbcrConversion.html" /></remarks>
        public static void DestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySamplerYcbcrConversion_fnptr(device, ycbcrConversion, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_sampler_ycbcr_conversion]</b> [device command]  Alias of <see cref="DestroySamplerYcbcrConversion"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySamplerYcbcrConversionKHR.html" /></remarks>
        public static void DestroySamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySamplerYcbcrConversionKHR_fnptr(device, ycbcrConversion, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySemaphore.html" /></remarks>
        public static void DestroySemaphore(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySemaphore_fnptr(device, semaphore, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySemaphoreSciSyncPoolNV.html" /></remarks>
        public static void DestroySemaphoreSciSyncPoolNV(VkDevice device, VkSemaphoreSciSyncPoolNV semaphorePool, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySemaphoreSciSyncPoolNV_fnptr(device, semaphorePool, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyShaderEXT.html" /></remarks>
        public static void DestroyShaderEXT(VkDevice device, VkShaderEXT shader, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyShaderEXT_fnptr(device, shader, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyShaderModule.html" /></remarks>
        public static void DestroyShaderModule(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyShaderModule_fnptr(device, shaderModule, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySurfaceKHR.html" /></remarks>
        public static void DestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySurfaceKHR_fnptr(instance, surface, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_swapchain]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySwapchainKHR.html" /></remarks>
        public static void DestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroySwapchainKHR_fnptr(device, swapchain, pAllocator);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyTensorARM.html" /></remarks>
        public static void DestroyTensorARM(VkDevice device, VkTensorARM tensor, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyTensorARM_fnptr(device, tensor, pAllocator);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyTensorViewARM.html" /></remarks>
        public static void DestroyTensorViewARM(VkDevice device, VkTensorViewARM tensorView, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyTensorViewARM_fnptr(device, tensorView, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_validation_cache]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyValidationCacheEXT.html" /></remarks>
        public static void DestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyValidationCacheEXT_fnptr(device, validationCache, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyVideoSessionKHR.html" /></remarks>
        public static void DestroyVideoSessionKHR(VkDevice device, VkVideoSessionKHR videoSession, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyVideoSessionKHR_fnptr(device, videoSession, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyVideoSessionParametersKHR.html" /></remarks>
        public static void DestroyVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkDestroyVideoSessionParametersKHR_fnptr(device, videoSessionParameters, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDeviceWaitIdle.html" /></remarks>
        public static VkResult DeviceWaitIdle(VkDevice device)
        {
            return VkPointers._vkDeviceWaitIdle_fnptr(device);
        }
        /// <summary><b>[requires: VK_EXT_display_control]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDisplayPowerControlEXT.html" /></remarks>
        public static VkResult DisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo)
        {
            return VkPointers._vkDisplayPowerControlEXT_fnptr(device, display, pDisplayPowerInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEndCommandBuffer.html" /></remarks>
        public static VkResult EndCommandBuffer(VkCommandBuffer commandBuffer)
        {
            return VkPointers._vkEndCommandBuffer_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumerateDeviceExtensionProperties.html" /></remarks>
        public static VkResult EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
        {
            return VkPointers._vkEnumerateDeviceExtensionProperties_fnptr(physicalDevice, pLayerName, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumerateDeviceLayerProperties.html" /></remarks>
        public static VkResult EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties)
        {
            return VkPointers._vkEnumerateDeviceLayerProperties_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: v1.0]</b> [global command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumerateInstanceExtensionProperties.html" /></remarks>
        public static VkResult EnumerateInstanceExtensionProperties(byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
        {
            return VkPointers._vkEnumerateInstanceExtensionProperties_fnptr(pLayerName, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: v1.0]</b> [global command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumerateInstanceLayerProperties.html" /></remarks>
        public static VkResult EnumerateInstanceLayerProperties(uint* pPropertyCount, VkLayerProperties* pProperties)
        {
            return VkPointers._vkEnumerateInstanceLayerProperties_fnptr(pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [global command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumerateInstanceVersion.html" /></remarks>
        public static VkResult EnumerateInstanceVersion(uint* pApiVersion)
        {
            return VkPointers._vkEnumerateInstanceVersion_fnptr(pApiVersion);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceGroups.html" /></remarks>
        public static VkResult EnumeratePhysicalDeviceGroups(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
        {
            return VkPointers._vkEnumeratePhysicalDeviceGroups_fnptr(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
        }
        /// <summary><b>[requires: VK_KHR_device_group_creation]</b> [instance command]  Alias of <see cref="EnumeratePhysicalDeviceGroups"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceGroupsKHR.html" /></remarks>
        public static VkResult EnumeratePhysicalDeviceGroupsKHR(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
        {
            return VkPointers._vkEnumeratePhysicalDeviceGroupsKHR_fnptr(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
        }
        /// <summary><b>[requires: VK_ARM_performance_counters_by_region]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM.html" /></remarks>
        public static VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterARM* pCounters, VkPerformanceCounterDescriptionARM* pCounterDescriptions)
        {
            return VkPointers._vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM_fnptr(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);
        }
        /// <summary><b>[requires: VK_KHR_performance_query]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR.html" /></remarks>
        public static VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            return VkPointers._vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_fnptr(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDevices.html" /></remarks>
        public static VkResult EnumeratePhysicalDevices(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices)
        {
            return VkPointers._vkEnumeratePhysicalDevices_fnptr(instance, pPhysicalDeviceCount, pPhysicalDevices);
        }
        /// <summary><b>[requires: VK_EXT_metal_objects]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkExportMetalObjectsEXT.html" /></remarks>
        public static void ExportMetalObjectsEXT(VkDevice device, VkExportMetalObjectsInfoEXT* pMetalObjectsInfo)
        {
            VkPointers._vkExportMetalObjectsEXT_fnptr(device, pMetalObjectsInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkFlushMappedMemoryRanges.html" /></remarks>
        public static VkResult FlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
        {
            return VkPointers._vkFlushMappedMemoryRanges_fnptr(device, memoryRangeCount, pMemoryRanges);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkFreeCommandBuffers.html" /></remarks>
        public static void FreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
        {
            VkPointers._vkFreeCommandBuffers_fnptr(device, commandPool, commandBufferCount, pCommandBuffers);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkFreeDescriptorSets.html" /></remarks>
        public static VkResult FreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets)
        {
            return VkPointers._vkFreeDescriptorSets_fnptr(device, descriptorPool, descriptorSetCount, pDescriptorSets);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkFreeMemory.html" /></remarks>
        public static void FreeMemory(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator)
        {
            VkPointers._vkFreeMemory_fnptr(device, memory, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureBuildSizesKHR.html" /></remarks>
        public static void GetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            VkPointers._vkGetAccelerationStructureBuildSizesKHR_fnptr(device, buildType, pBuildInfo, pMaxPrimitiveCounts, pSizeInfo);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureDeviceAddressKHR.html" /></remarks>
        public static ulong GetAccelerationStructureDeviceAddressKHR(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo)
        {
            return VkPointers._vkGetAccelerationStructureDeviceAddressKHR_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureHandleNV.html" /></remarks>
        public static VkResult GetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* pData)
        {
            return VkPointers._vkGetAccelerationStructureHandleNV_fnptr(device, accelerationStructure, dataSize, pData);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureMemoryRequirementsNV.html" /></remarks>
        public static void GetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetAccelerationStructureMemoryRequirementsNV_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT.html" /></remarks>
        public static VkResult GetAccelerationStructureOpaqueCaptureDescriptorDataEXT(VkDevice device, VkAccelerationStructureCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: VK_ANDROID_external_memory_android_hardware_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAndroidHardwareBufferPropertiesANDROID.html" /></remarks>
        public static VkResult GetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
        {
            return VkPointers._vkGetAndroidHardwareBufferPropertiesANDROID_fnptr(device, buffer, pProperties);
        }
        /// <summary><b>[requires: VK_FUCHSIA_buffer_collection]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferCollectionPropertiesFUCHSIA.html" /></remarks>
        public static VkResult GetBufferCollectionPropertiesFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferCollectionPropertiesFUCHSIA* pProperties)
        {
            return VkPointers._vkGetBufferCollectionPropertiesFUCHSIA_fnptr(device, collection, pProperties);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddress.html" /></remarks>
        public static ulong GetBufferDeviceAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            return VkPointers._vkGetBufferDeviceAddress_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_buffer_device_address]</b> [device command]  Alias of <see cref="GetBufferDeviceAddress"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddressEXT.html" /></remarks>
        public static ulong GetBufferDeviceAddressEXT(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            return VkPointers._vkGetBufferDeviceAddressEXT_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_buffer_device_address]</b> [device command]  Alias of <see cref="GetBufferDeviceAddress"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddressKHR.html" /></remarks>
        public static ulong GetBufferDeviceAddressKHR(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            return VkPointers._vkGetBufferDeviceAddressKHR_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferMemoryRequirements.html" /></remarks>
        public static void GetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements)
        {
            VkPointers._vkGetBufferMemoryRequirements_fnptr(device, buffer, pMemoryRequirements);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferMemoryRequirements2.html" /></remarks>
        public static void GetBufferMemoryRequirements2(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetBufferMemoryRequirements2_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_get_memory_requirements2]</b> [device command]  Alias of <see cref="GetBufferMemoryRequirements2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferMemoryRequirements2KHR.html" /></remarks>
        public static void GetBufferMemoryRequirements2KHR(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetBufferMemoryRequirements2KHR_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferOpaqueCaptureAddress.html" /></remarks>
        public static ulong GetBufferOpaqueCaptureAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            return VkPointers._vkGetBufferOpaqueCaptureAddress_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_buffer_device_address]</b> [device command]  Alias of <see cref="GetBufferOpaqueCaptureAddress"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferOpaqueCaptureAddressKHR.html" /></remarks>
        public static ulong GetBufferOpaqueCaptureAddressKHR(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            return VkPointers._vkGetBufferOpaqueCaptureAddressKHR_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferOpaqueCaptureDescriptorDataEXT.html" /></remarks>
        public static VkResult GetBufferOpaqueCaptureDescriptorDataEXT(VkDevice device, VkBufferCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetBufferOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: VK_EXT_calibrated_timestamps]</b> [device command]  Alias of <see cref="GetCalibratedTimestampsKHR"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetCalibratedTimestampsEXT.html" /></remarks>
        public static VkResult GetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoKHR* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
        {
            return VkPointers._vkGetCalibratedTimestampsEXT_fnptr(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);
        }
        /// <summary><b>[requires: VK_KHR_calibrated_timestamps]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetCalibratedTimestampsKHR.html" /></remarks>
        public static VkResult GetCalibratedTimestampsKHR(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoKHR* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
        {
            return VkPointers._vkGetCalibratedTimestampsKHR_fnptr(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);
        }
        /// <summary><b>[requires: VK_NV_cluster_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetClusterAccelerationStructureBuildSizesNV.html" /></remarks>
        public static void GetClusterAccelerationStructureBuildSizesNV(VkDevice device, VkClusterAccelerationStructureInputInfoNV* pInfo, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            VkPointers._vkGetClusterAccelerationStructureBuildSizesNV_fnptr(device, pInfo, pSizeInfo);
        }
        /// <summary>[device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetCommandPoolMemoryConsumption.html" /></remarks>
        public static void GetCommandPoolMemoryConsumption(VkDevice device, VkCommandPool commandPool, VkCommandBuffer commandBuffer, VkCommandPoolMemoryConsumption* pConsumption)
        {
            VkPointers._vkGetCommandPoolMemoryConsumption_fnptr(device, commandPool, commandBuffer, pConsumption);
        }
        /// <summary><b>[requires: VK_NV_cuda_kernel_launch]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetCudaModuleCacheNV.html" /></remarks>
        public static VkResult GetCudaModuleCacheNV(VkDevice device, VkCudaModuleNV module, nuint* pCacheSize, void* pCacheData)
        {
            return VkPointers._vkGetCudaModuleCacheNV_fnptr(device, module, pCacheSize, pCacheData);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDataGraphPipelineAvailablePropertiesARM.html" /></remarks>
        public static VkResult GetDataGraphPipelineAvailablePropertiesARM(VkDevice device, VkDataGraphPipelineInfoARM* pPipelineInfo, uint* pPropertiesCount, VkDataGraphPipelinePropertyARM* pProperties)
        {
            return VkPointers._vkGetDataGraphPipelineAvailablePropertiesARM_fnptr(device, pPipelineInfo, pPropertiesCount, pProperties);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDataGraphPipelinePropertiesARM.html" /></remarks>
        public static VkResult GetDataGraphPipelinePropertiesARM(VkDevice device, VkDataGraphPipelineInfoARM* pPipelineInfo, uint propertiesCount, VkDataGraphPipelinePropertyQueryResultARM* pProperties)
        {
            return VkPointers._vkGetDataGraphPipelinePropertiesARM_fnptr(device, pPipelineInfo, propertiesCount, pProperties);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDataGraphPipelineSessionBindPointRequirementsARM.html" /></remarks>
        public static VkResult GetDataGraphPipelineSessionBindPointRequirementsARM(VkDevice device, VkDataGraphPipelineSessionBindPointRequirementsInfoARM* pInfo, uint* pBindPointRequirementCount, VkDataGraphPipelineSessionBindPointRequirementARM* pBindPointRequirements)
        {
            return VkPointers._vkGetDataGraphPipelineSessionBindPointRequirementsARM_fnptr(device, pInfo, pBindPointRequirementCount, pBindPointRequirements);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDataGraphPipelineSessionMemoryRequirementsARM.html" /></remarks>
        public static void GetDataGraphPipelineSessionMemoryRequirementsARM(VkDevice device, VkDataGraphPipelineSessionMemoryRequirementsInfoARM* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetDataGraphPipelineSessionMemoryRequirementsARM_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_deferred_host_operations]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeferredOperationMaxConcurrencyKHR.html" /></remarks>
        public static uint GetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation)
        {
            return VkPointers._vkGetDeferredOperationMaxConcurrencyKHR_fnptr(device, operation);
        }
        /// <summary><b>[requires: VK_KHR_deferred_host_operations]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeferredOperationResultKHR.html" /></remarks>
        public static VkResult GetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation)
        {
            return VkPointers._vkGetDeferredOperationResultKHR_fnptr(device, operation);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorEXT.html" /></remarks>
        public static void GetDescriptorEXT(VkDevice device, VkDescriptorGetInfoEXT* pDescriptorInfo, nuint dataSize, void* pDescriptor)
        {
            VkPointers._vkGetDescriptorEXT_fnptr(device, pDescriptorInfo, dataSize, pDescriptor);
        }
        /// <summary><b>[requires: VK_VALVE_descriptor_set_host_mapping]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetHostMappingVALVE.html" /></remarks>
        public static void GetDescriptorSetHostMappingVALVE(VkDevice device, VkDescriptorSet descriptorSet, void** ppData)
        {
            VkPointers._vkGetDescriptorSetHostMappingVALVE_fnptr(device, descriptorSet, ppData);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutBindingOffsetEXT.html" /></remarks>
        public static void GetDescriptorSetLayoutBindingOffsetEXT(VkDevice device, VkDescriptorSetLayout layout, uint binding, ulong* pOffset)
        {
            VkPointers._vkGetDescriptorSetLayoutBindingOffsetEXT_fnptr(device, layout, binding, pOffset);
        }
        /// <summary><b>[requires: VK_VALVE_descriptor_set_host_mapping]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutHostMappingInfoVALVE.html" /></remarks>
        public static void GetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, VkDescriptorSetBindingReferenceVALVE* pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
        {
            VkPointers._vkGetDescriptorSetLayoutHostMappingInfoVALVE_fnptr(device, pBindingReference, pHostMapping);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutSizeEXT.html" /></remarks>
        public static void GetDescriptorSetLayoutSizeEXT(VkDevice device, VkDescriptorSetLayout layout, ulong* pLayoutSizeInBytes)
        {
            VkPointers._vkGetDescriptorSetLayoutSizeEXT_fnptr(device, layout, pLayoutSizeInBytes);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutSupport.html" /></remarks>
        public static void GetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
        {
            VkPointers._vkGetDescriptorSetLayoutSupport_fnptr(device, pCreateInfo, pSupport);
        }
        /// <summary><b>[requires: VK_KHR_maintenance3]</b> [device command]  Alias of <see cref="GetDescriptorSetLayoutSupport"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutSupportKHR.html" /></remarks>
        public static void GetDescriptorSetLayoutSupportKHR(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
        {
            VkPointers._vkGetDescriptorSetLayoutSupportKHR_fnptr(device, pCreateInfo, pSupport);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceAccelerationStructureCompatibilityKHR.html" /></remarks>
        public static void GetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            VkPointers._vkGetDeviceAccelerationStructureCompatibilityKHR_fnptr(device, pVersionInfo, pCompatibility);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceBufferMemoryRequirements.html" /></remarks>
        public static void GetDeviceBufferMemoryRequirements(VkDevice device, VkDeviceBufferMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetDeviceBufferMemoryRequirements_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_maintenance4]</b> [device command]  Alias of <see cref="GetDeviceBufferMemoryRequirements"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceBufferMemoryRequirementsKHR.html" /></remarks>
        public static void GetDeviceBufferMemoryRequirementsKHR(VkDevice device, VkDeviceBufferMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetDeviceBufferMemoryRequirementsKHR_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_EXT_device_fault]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceFaultInfoEXT.html" /></remarks>
        public static VkResult GetDeviceFaultInfoEXT(VkDevice device, VkDeviceFaultCountsEXT* pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
        {
            return VkPointers._vkGetDeviceFaultInfoEXT_fnptr(device, pFaultCounts, pFaultInfo);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPeerMemoryFeatures.html" /></remarks>
        public static void GetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlagBits* pPeerMemoryFeatures)
        {
            VkPointers._vkGetDeviceGroupPeerMemoryFeatures_fnptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
        }
        /// <summary><b>[requires: VK_KHR_device_group]</b> [device command]  Alias of <see cref="GetDeviceGroupPeerMemoryFeatures"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPeerMemoryFeaturesKHR.html" /></remarks>
        public static void GetDeviceGroupPeerMemoryFeaturesKHR(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlagBits* pPeerMemoryFeatures)
        {
            VkPointers._vkGetDeviceGroupPeerMemoryFeaturesKHR_fnptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
        }
        /// <summary><b>[requires: VK_KHR_swapchain | VK_KHR_device_group]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPresentCapabilitiesKHR.html" /></remarks>
        public static VkResult GetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities)
        {
            return VkPointers._vkGetDeviceGroupPresentCapabilitiesKHR_fnptr(device, pDeviceGroupPresentCapabilities);
        }
        /// <summary><b>[requires: VK_EXT_full_screen_exclusive]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupSurfacePresentModes2EXT.html" /></remarks>
        public static VkResult GetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagBitsKHR* pModes)
        {
            return VkPointers._vkGetDeviceGroupSurfacePresentModes2EXT_fnptr(device, pSurfaceInfo, pModes);
        }
        /// <summary><b>[requires: VK_KHR_swapchain | VK_KHR_device_group]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupSurfacePresentModesKHR.html" /></remarks>
        public static VkResult GetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagBitsKHR* pModes)
        {
            return VkPointers._vkGetDeviceGroupSurfacePresentModesKHR_fnptr(device, surface, pModes);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageMemoryRequirements.html" /></remarks>
        public static void GetDeviceImageMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetDeviceImageMemoryRequirements_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_maintenance4]</b> [device command]  Alias of <see cref="GetDeviceImageMemoryRequirements"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageMemoryRequirementsKHR.html" /></remarks>
        public static void GetDeviceImageMemoryRequirementsKHR(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetDeviceImageMemoryRequirementsKHR_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSparseMemoryRequirements.html" /></remarks>
        public static void GetDeviceImageSparseMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            VkPointers._vkGetDeviceImageSparseMemoryRequirements_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_maintenance4]</b> [device command]  Alias of <see cref="GetDeviceImageSparseMemoryRequirements"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSparseMemoryRequirementsKHR.html" /></remarks>
        public static void GetDeviceImageSparseMemoryRequirementsKHR(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            VkPointers._vkGetDeviceImageSparseMemoryRequirementsKHR_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSubresourceLayout.html" /></remarks>
        public static void GetDeviceImageSubresourceLayout(VkDevice device, VkDeviceImageSubresourceInfo* pInfo, VkSubresourceLayout2* pLayout)
        {
            VkPointers._vkGetDeviceImageSubresourceLayout_fnptr(device, pInfo, pLayout);
        }
        /// <summary><b>[requires: VK_KHR_maintenance5]</b> [device command]  Alias of <see cref="GetDeviceImageSubresourceLayout"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSubresourceLayoutKHR.html" /></remarks>
        public static void GetDeviceImageSubresourceLayoutKHR(VkDevice device, VkDeviceImageSubresourceInfo* pInfo, VkSubresourceLayout2* pLayout)
        {
            VkPointers._vkGetDeviceImageSubresourceLayoutKHR_fnptr(device, pInfo, pLayout);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMemoryCommitment.html" /></remarks>
        public static void GetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, ulong* pCommittedMemoryInBytes)
        {
            VkPointers._vkGetDeviceMemoryCommitment_fnptr(device, memory, pCommittedMemoryInBytes);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMemoryOpaqueCaptureAddress.html" /></remarks>
        public static ulong GetDeviceMemoryOpaqueCaptureAddress(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
        {
            return VkPointers._vkGetDeviceMemoryOpaqueCaptureAddress_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_buffer_device_address]</b> [device command]  Alias of <see cref="GetDeviceMemoryOpaqueCaptureAddress"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMemoryOpaqueCaptureAddressKHR.html" /></remarks>
        public static ulong GetDeviceMemoryOpaqueCaptureAddressKHR(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
        {
            return VkPointers._vkGetDeviceMemoryOpaqueCaptureAddressKHR_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMicromapCompatibilityEXT.html" /></remarks>
        public static void GetDeviceMicromapCompatibilityEXT(VkDevice device, VkMicromapVersionInfoEXT* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            VkPointers._vkGetDeviceMicromapCompatibilityEXT_fnptr(device, pVersionInfo, pCompatibility);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceProcAddr.html" /></remarks>
        public static IntPtr GetDeviceProcAddr(VkDevice device, byte* pName)
        {
            return VkPointers._vkGetDeviceProcAddr_fnptr(device, pName);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceQueue.html" /></remarks>
        public static void GetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue)
        {
            VkPointers._vkGetDeviceQueue_fnptr(device, queueFamilyIndex, queueIndex, pQueue);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceQueue2.html" /></remarks>
        public static void GetDeviceQueue2(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue)
        {
            VkPointers._vkGetDeviceQueue2_fnptr(device, pQueueInfo, pQueue);
        }
        /// <summary><b>[requires: VK_HUAWEI_subpass_shading]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI.html" /></remarks>
        public static VkResult GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize)
        {
            return VkPointers._vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_fnptr(device, renderpass, pMaxWorkgroupSize);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceTensorMemoryRequirementsARM.html" /></remarks>
        public static void GetDeviceTensorMemoryRequirementsARM(VkDevice device, VkDeviceTensorMemoryRequirementsARM* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetDeviceTensorMemoryRequirementsARM_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_get_display_properties2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayModeProperties2KHR.html" /></remarks>
        public static VkResult GetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
        {
            return VkPointers._vkGetDisplayModeProperties2KHR_fnptr(physicalDevice, display, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayModePropertiesKHR.html" /></remarks>
        public static VkResult GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
        {
            return VkPointers._vkGetDisplayModePropertiesKHR_fnptr(physicalDevice, display, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_display_properties2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneCapabilities2KHR.html" /></remarks>
        public static VkResult GetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
        {
            return VkPointers._vkGetDisplayPlaneCapabilities2KHR_fnptr(physicalDevice, pDisplayPlaneInfo, pCapabilities);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneCapabilitiesKHR.html" /></remarks>
        public static VkResult GetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)
        {
            return VkPointers._vkGetDisplayPlaneCapabilitiesKHR_fnptr(physicalDevice, mode, planeIndex, pCapabilities);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneSupportedDisplaysKHR.html" /></remarks>
        public static VkResult GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays)
        {
            return VkPointers._vkGetDisplayPlaneSupportedDisplaysKHR_fnptr(physicalDevice, planeIndex, pDisplayCount, pDisplays);
        }
        /// <summary><b>[requires: VK_EXT_acquire_drm_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDrmDisplayEXT.html" /></remarks>
        public static VkResult GetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, uint connectorId, VkDisplayKHR* display)
        {
            return VkPointers._vkGetDrmDisplayEXT_fnptr(physicalDevice, drmFd, connectorId, display);
        }
        /// <summary><b>[requires: VK_QCOM_tile_properties]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDynamicRenderingTilePropertiesQCOM.html" /></remarks>
        public static VkResult GetDynamicRenderingTilePropertiesQCOM(VkDevice device, VkRenderingInfo* pRenderingInfo, VkTilePropertiesQCOM* pProperties)
        {
            return VkPointers._vkGetDynamicRenderingTilePropertiesQCOM_fnptr(device, pRenderingInfo, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetEncodedVideoSessionParametersKHR.html" /></remarks>
        public static VkResult GetEncodedVideoSessionParametersKHR(VkDevice device, VkVideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, VkVideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, nuint* pDataSize, void* pData)
        {
            return VkPointers._vkGetEncodedVideoSessionParametersKHR_fnptr(device, pVideoSessionParametersInfo, pFeedbackInfo, pDataSize, pData);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetEventStatus.html" /></remarks>
        public static VkResult GetEventStatus(VkDevice device, VkEvent @event)
        {
            return VkPointers._vkGetEventStatus_fnptr(device, @event);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetExecutionGraphPipelineNodeIndexAMDX.html" /></remarks>
        public static VkResult GetExecutionGraphPipelineNodeIndexAMDX(VkDevice device, VkPipeline executionGraph, VkPipelineShaderStageNodeCreateInfoAMDX* pNodeInfo, uint* pNodeIndex)
        {
            return VkPointers._vkGetExecutionGraphPipelineNodeIndexAMDX_fnptr(device, executionGraph, pNodeInfo, pNodeIndex);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetExecutionGraphPipelineScratchSizeAMDX.html" /></remarks>
        public static VkResult GetExecutionGraphPipelineScratchSizeAMDX(VkDevice device, VkPipeline executionGraph, VkExecutionGraphPipelineScratchSizeAMDX* pSizeInfo)
        {
            return VkPointers._vkGetExecutionGraphPipelineScratchSizeAMDX_fnptr(device, executionGraph, pSizeInfo);
        }
        /// <summary><b>[requires: VK_NV_external_compute_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetExternalComputeQueueDataNV.html" /></remarks>
        public static void GetExternalComputeQueueDataNV(VkExternalComputeQueueNV externalQueue, VkExternalComputeQueueDataParamsNV* parameters, void* pData)
        {
            VkPointers._vkGetExternalComputeQueueDataNV_fnptr(externalQueue, parameters, pData);
        }
        /// <summary>[device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFaultData.html" /></remarks>
        public static VkResult GetFaultData(VkDevice device, VkFaultQueryBehavior faultQueryBehavior, int* pUnrecordedFaults, uint* pFaultCount, VkFaultData* pFaults)
        {
            return VkPointers._vkGetFaultData_fnptr(device, faultQueryBehavior, pUnrecordedFaults, pFaultCount, pFaults);
        }
        /// <summary><b>[requires: VK_KHR_external_fence_fd]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFenceFdKHR.html" /></remarks>
        public static VkResult GetFenceFdKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            return VkPointers._vkGetFenceFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync | VK_NV_external_sci_sync2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFenceSciSyncFenceNV.html" /></remarks>
        public static VkResult GetFenceSciSyncFenceNV(VkDevice device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle)
        {
            return VkPointers._vkGetFenceSciSyncFenceNV_fnptr(device, pGetSciSyncHandleInfo, pHandle);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync | VK_NV_external_sci_sync2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFenceSciSyncObjNV.html" /></remarks>
        public static VkResult GetFenceSciSyncObjNV(VkDevice device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle)
        {
            return VkPointers._vkGetFenceSciSyncObjNV_fnptr(device, pGetSciSyncHandleInfo, pHandle);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFenceStatus.html" /></remarks>
        public static VkResult GetFenceStatus(VkDevice device, VkFence fence)
        {
            return VkPointers._vkGetFenceStatus_fnptr(device, fence);
        }
        /// <summary><b>[requires: VK_KHR_external_fence_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFenceWin32HandleKHR.html" /></remarks>
        public static VkResult GetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            return VkPointers._vkGetFenceWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        /// <summary><b>[requires: VK_QCOM_tile_properties]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFramebufferTilePropertiesQCOM.html" /></remarks>
        public static VkResult GetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, uint* pPropertiesCount, VkTilePropertiesQCOM* pProperties)
        {
            return VkPointers._vkGetFramebufferTilePropertiesQCOM_fnptr(device, framebuffer, pPropertiesCount, pProperties);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetGeneratedCommandsMemoryRequirementsEXT.html" /></remarks>
        public static void GetGeneratedCommandsMemoryRequirementsEXT(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoEXT* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetGeneratedCommandsMemoryRequirementsEXT_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetGeneratedCommandsMemoryRequirementsNV.html" /></remarks>
        public static void GetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetGeneratedCommandsMemoryRequirementsNV_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_EXT_image_drm_format_modifier]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageDrmFormatModifierPropertiesEXT.html" /></remarks>
        public static VkResult GetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
        {
            return VkPointers._vkGetImageDrmFormatModifierPropertiesEXT_fnptr(device, image, pProperties);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageMemoryRequirements.html" /></remarks>
        public static void GetImageMemoryRequirements(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements)
        {
            VkPointers._vkGetImageMemoryRequirements_fnptr(device, image, pMemoryRequirements);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageMemoryRequirements2.html" /></remarks>
        public static void GetImageMemoryRequirements2(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetImageMemoryRequirements2_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_get_memory_requirements2]</b> [device command]  Alias of <see cref="GetImageMemoryRequirements2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageMemoryRequirements2KHR.html" /></remarks>
        public static void GetImageMemoryRequirements2KHR(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetImageMemoryRequirements2KHR_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageOpaqueCaptureDescriptorDataEXT.html" /></remarks>
        public static VkResult GetImageOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetImageOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSparseMemoryRequirements.html" /></remarks>
        public static void GetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements)
        {
            VkPointers._vkGetImageSparseMemoryRequirements_fnptr(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSparseMemoryRequirements2.html" /></remarks>
        public static void GetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            VkPointers._vkGetImageSparseMemoryRequirements2_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_get_memory_requirements2]</b> [device command]  Alias of <see cref="GetImageSparseMemoryRequirements2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSparseMemoryRequirements2KHR.html" /></remarks>
        public static void GetImageSparseMemoryRequirements2KHR(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            VkPointers._vkGetImageSparseMemoryRequirements2KHR_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html" /></remarks>
        public static void GetImageSubresourceLayout(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout)
        {
            VkPointers._vkGetImageSubresourceLayout_fnptr(device, image, pSubresource, pLayout);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout2.html" /></remarks>
        public static void GetImageSubresourceLayout2(VkDevice device, VkImage image, VkImageSubresource2* pSubresource, VkSubresourceLayout2* pLayout)
        {
            VkPointers._vkGetImageSubresourceLayout2_fnptr(device, image, pSubresource, pLayout);
        }
        /// <summary><b>[requires: VK_EXT_host_image_copy | VK_EXT_image_compression_control]</b> [device command]  Alias of <see cref="GetImageSubresourceLayout2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout2EXT.html" /></remarks>
        public static void GetImageSubresourceLayout2EXT(VkDevice device, VkImage image, VkImageSubresource2* pSubresource, VkSubresourceLayout2* pLayout)
        {
            VkPointers._vkGetImageSubresourceLayout2EXT_fnptr(device, image, pSubresource, pLayout);
        }
        /// <summary><b>[requires: VK_KHR_maintenance5]</b> [device command]  Alias of <see cref="GetImageSubresourceLayout2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout2KHR.html" /></remarks>
        public static void GetImageSubresourceLayout2KHR(VkDevice device, VkImage image, VkImageSubresource2* pSubresource, VkSubresourceLayout2* pLayout)
        {
            VkPointers._vkGetImageSubresourceLayout2KHR_fnptr(device, image, pSubresource, pLayout);
        }
        /// <summary><b>[requires: VK_NVX_image_view_handle]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageViewAddressNVX.html" /></remarks>
        public static VkResult GetImageViewAddressNVX(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties)
        {
            return VkPointers._vkGetImageViewAddressNVX_fnptr(device, imageView, pProperties);
        }
        /// <summary><b>[requires: VK_NVX_image_view_handle]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageViewHandle64NVX.html" /></remarks>
        public static ulong GetImageViewHandle64NVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
        {
            return VkPointers._vkGetImageViewHandle64NVX_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_NVX_image_view_handle]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageViewHandleNVX.html" /></remarks>
        public static uint GetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
        {
            return VkPointers._vkGetImageViewHandleNVX_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageViewOpaqueCaptureDescriptorDataEXT.html" /></remarks>
        public static VkResult GetImageViewOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageViewCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetImageViewOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetInstanceProcAddr.html" /></remarks>
        public static IntPtr GetInstanceProcAddr(VkInstance instance, byte* pName)
        {
            return VkPointers._vkGetInstanceProcAddr_fnptr(instance, pName);
        }
        /// <summary><b>[requires: VK_NV_low_latency2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetLatencyTimingsNV.html" /></remarks>
        public static void GetLatencyTimingsNV(VkDevice device, VkSwapchainKHR swapchain, VkGetLatencyMarkerInfoNV* pLatencyMarkerInfo)
        {
            VkPointers._vkGetLatencyTimingsNV_fnptr(device, swapchain, pLatencyMarkerInfo);
        }
        /// <summary><b>[requires: VK_ANDROID_external_memory_android_hardware_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryAndroidHardwareBufferANDROID.html" /></remarks>
        public static VkResult GetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, IntPtr* pBuffer)
        {
            return VkPointers._vkGetMemoryAndroidHardwareBufferANDROID_fnptr(device, pInfo, pBuffer);
        }
        /// <summary><b>[requires: VK_KHR_external_memory_fd]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryFdKHR.html" /></remarks>
        public static VkResult GetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            return VkPointers._vkGetMemoryFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        /// <summary><b>[requires: VK_KHR_external_memory_fd]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryFdPropertiesKHR.html" /></remarks>
        public static VkResult GetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties)
        {
            return VkPointers._vkGetMemoryFdPropertiesKHR_fnptr(device, handleType, fd, pMemoryFdProperties);
        }
        /// <summary><b>[requires: VK_EXT_external_memory_host]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryHostPointerPropertiesEXT.html" /></remarks>
        public static VkResult GetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties)
        {
            return VkPointers._vkGetMemoryHostPointerPropertiesEXT_fnptr(device, handleType, pHostPointer, pMemoryHostPointerProperties);
        }
        /// <summary><b>[requires: VK_EXT_external_memory_metal]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryMetalHandleEXT.html" /></remarks>
        public static VkResult GetMemoryMetalHandleEXT(VkDevice device, VkMemoryGetMetalHandleInfoEXT* pGetMetalHandleInfo, void** pHandle)
        {
            return VkPointers._vkGetMemoryMetalHandleEXT_fnptr(device, pGetMetalHandleInfo, pHandle);
        }
        /// <summary><b>[requires: VK_EXT_external_memory_metal]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryMetalHandlePropertiesEXT.html" /></remarks>
        public static VkResult GetMemoryMetalHandlePropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHandle, VkMemoryMetalHandlePropertiesEXT* pMemoryMetalHandleProperties)
        {
            return VkPointers._vkGetMemoryMetalHandlePropertiesEXT_fnptr(device, handleType, pHandle, pMemoryMetalHandleProperties);
        }
        /// <summary><b>[requires: VK_OHOS_external_memory]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryNativeBufferOHOS.html" /></remarks>
        public static VkResult GetMemoryNativeBufferOHOS(VkDevice device, VkMemoryGetNativeBufferInfoOHOS* pInfo, IntPtr* pBuffer)
        {
            return VkPointers._vkGetMemoryNativeBufferOHOS_fnptr(device, pInfo, pBuffer);
        }
        /// <summary><b>[requires: VK_NV_external_memory_rdma]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryRemoteAddressNV.html" /></remarks>
        public static VkResult GetMemoryRemoteAddressNV(VkDevice device, VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, void** pAddress)
        {
            return VkPointers._vkGetMemoryRemoteAddressNV_fnptr(device, pMemoryGetRemoteAddressInfo, pAddress);
        }
        /// <summary><b>[requires: VK_NV_external_memory_sci_buf]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemorySciBufNV.html" /></remarks>
        public static VkResult GetMemorySciBufNV(VkDevice device, VkMemoryGetSciBufInfoNV* pGetSciBufInfo, IntPtr* pHandle)
        {
            return VkPointers._vkGetMemorySciBufNV_fnptr(device, pGetSciBufInfo, pHandle);
        }
        /// <summary><b>[requires: VK_KHR_external_memory_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleKHR.html" /></remarks>
        public static VkResult GetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            return VkPointers._vkGetMemoryWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        /// <summary><b>[requires: VK_NV_external_memory_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleNV.html" /></remarks>
        public static VkResult GetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagBitsNV handleType, IntPtr* pHandle)
        {
            return VkPointers._vkGetMemoryWin32HandleNV_fnptr(device, memory, handleType, pHandle);
        }
        /// <summary><b>[requires: VK_KHR_external_memory_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandlePropertiesKHR.html" /></remarks>
        public static VkResult GetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties)
        {
            return VkPointers._vkGetMemoryWin32HandlePropertiesKHR_fnptr(device, handleType, handle, pMemoryWin32HandleProperties);
        }
        /// <summary><b>[requires: VK_FUCHSIA_external_memory]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryZirconHandleFUCHSIA.html" /></remarks>
        public static VkResult GetMemoryZirconHandleFUCHSIA(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, int* pZirconHandle)
        {
            return VkPointers._vkGetMemoryZirconHandleFUCHSIA_fnptr(device, pGetZirconHandleInfo, pZirconHandle);
        }
        /// <summary><b>[requires: VK_FUCHSIA_external_memory]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryZirconHandlePropertiesFUCHSIA.html" /></remarks>
        public static VkResult GetMemoryZirconHandlePropertiesFUCHSIA(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties)
        {
            return VkPointers._vkGetMemoryZirconHandlePropertiesFUCHSIA_fnptr(device, handleType, zirconHandle, pMemoryZirconHandleProperties);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMicromapBuildSizesEXT.html" /></remarks>
        public static void GetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkMicromapBuildInfoEXT* pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
        {
            VkPointers._vkGetMicromapBuildSizesEXT_fnptr(device, buildType, pBuildInfo, pSizeInfo);
        }
        /// <summary><b>[requires: VK_OHOS_external_memory]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetNativeBufferPropertiesOHOS.html" /></remarks>
        public static VkResult GetNativeBufferPropertiesOHOS(VkDevice device, IntPtr buffer, VkNativeBufferPropertiesOHOS* pProperties)
        {
            return VkPointers._vkGetNativeBufferPropertiesOHOS_fnptr(device, buffer, pProperties);
        }
        /// <summary><b>[requires: VK_NV_partitioned_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPartitionedAccelerationStructuresBuildSizesNV.html" /></remarks>
        public static void GetPartitionedAccelerationStructuresBuildSizesNV(VkDevice device, VkPartitionedAccelerationStructureInstancesInputNV* pInfo, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            VkPointers._vkGetPartitionedAccelerationStructuresBuildSizesNV_fnptr(device, pInfo, pSizeInfo);
        }
        /// <summary><b>[requires: VK_EXT_present_timing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPastPresentationTimingEXT.html" /></remarks>
        public static VkResult GetPastPresentationTimingEXT(VkDevice device, VkPastPresentationTimingInfoEXT* pPastPresentationTimingInfo, VkPastPresentationTimingPropertiesEXT* pPastPresentationTimingProperties)
        {
            return VkPointers._vkGetPastPresentationTimingEXT_fnptr(device, pPastPresentationTimingInfo, pPastPresentationTimingProperties);
        }
        /// <summary><b>[requires: VK_GOOGLE_display_timing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPastPresentationTimingGOOGLE.html" /></remarks>
        public static VkResult GetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
        {
            return VkPointers._vkGetPastPresentationTimingGOOGLE_fnptr(device, swapchain, pPresentationTimingCount, pPresentationTimings);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPerformanceParameterINTEL.html" /></remarks>
        public static VkResult GetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
        {
            return VkPointers._vkGetPerformanceParameterINTEL_fnptr(device, parameter, pValue);
        }
        /// <summary><b>[requires: VK_EXT_calibrated_timestamps]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceCalibrateableTimeDomainsKHR"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCalibrateableTimeDomainsEXT.html" /></remarks>
        public static VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainKHR* pTimeDomains)
        {
            return VkPointers._vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_fnptr(physicalDevice, pTimeDomainCount, pTimeDomains);
        }
        /// <summary><b>[requires: VK_KHR_calibrated_timestamps]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCalibrateableTimeDomainsKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceCalibrateableTimeDomainsKHR(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainKHR* pTimeDomains)
        {
            return VkPointers._vkGetPhysicalDeviceCalibrateableTimeDomainsKHR_fnptr(physicalDevice, pTimeDomainCount, pTimeDomains);
        }
        /// <summary><b>[requires: VK_NV_cooperative_matrix2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV.html" /></remarks>
        public static VkResult GetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixFlexibleDimensionsPropertiesNV* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_cooperative_matrix]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceCooperativeMatrixPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesKHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_NV_cooperative_matrix]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeMatrixPropertiesNV.html" /></remarks>
        public static VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_NV_cooperative_vector]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeVectorPropertiesNV.html" /></remarks>
        public static VkResult GetPhysicalDeviceCooperativeVectorPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeVectorPropertiesNV* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceCooperativeVectorPropertiesNV_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_EXT_directfb_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDirectFBPresentationSupportEXT.html" /></remarks>
        public static int GetPhysicalDeviceDirectFBPresentationSupportEXT(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dfb)
        {
            return VkPointers._vkGetPhysicalDeviceDirectFBPresentationSupportEXT_fnptr(physicalDevice, queueFamilyIndex, dfb);
        }
        /// <summary><b>[requires: VK_KHR_get_display_properties2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPlaneProperties2KHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceDisplayPlaneProperties2KHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPlanePropertiesKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceDisplayPlanePropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_display_properties2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayProperties2KHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceDisplayProperties2KHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPropertiesKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties)
        {
            return VkPointers._vkGetPhysicalDeviceDisplayPropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalBufferProperties.html" /></remarks>
        public static void GetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalBufferProperties_fnptr(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
        }
        /// <summary><b>[requires: VK_KHR_external_memory_capabilities]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceExternalBufferProperties"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalBufferPropertiesKHR.html" /></remarks>
        public static void GetPhysicalDeviceExternalBufferPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalBufferPropertiesKHR_fnptr(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalFenceProperties.html" /></remarks>
        public static void GetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalFenceProperties_fnptr(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
        }
        /// <summary><b>[requires: VK_KHR_external_fence_capabilities]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceExternalFenceProperties"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalFencePropertiesKHR.html" /></remarks>
        public static void GetPhysicalDeviceExternalFencePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalFencePropertiesKHR_fnptr(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
        }
        /// <summary><b>[requires: VK_NV_external_memory_capabilities]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalImageFormatPropertiesNV.html" /></remarks>
        public static VkResult GetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlagBits usage, VkImageCreateFlagBits flags, VkExternalMemoryHandleTypeFlagBitsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceExternalImageFormatPropertiesNV_fnptr(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);
        }
        /// <summary><b>[requires: VK_NV_external_memory_sci_buf]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV.html" /></remarks>
        public static VkResult GetPhysicalDeviceExternalMemorySciBufPropertiesNV(VkPhysicalDevice physicalDevice, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, VkMemorySciBufPropertiesNV* pMemorySciBufProperties)
        {
            return VkPointers._vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_fnptr(physicalDevice, handleType, handle, pMemorySciBufProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalSemaphoreProperties.html" /></remarks>
        public static void GetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalSemaphoreProperties_fnptr(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
        }
        /// <summary><b>[requires: VK_KHR_external_semaphore_capabilities]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceExternalSemaphoreProperties"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalSemaphorePropertiesKHR.html" /></remarks>
        public static void GetPhysicalDeviceExternalSemaphorePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalSemaphorePropertiesKHR_fnptr(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalTensorPropertiesARM.html" /></remarks>
        public static void GetPhysicalDeviceExternalTensorPropertiesARM(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalTensorInfoARM* pExternalTensorInfo, VkExternalTensorPropertiesARM* pExternalTensorProperties)
        {
            VkPointers._vkGetPhysicalDeviceExternalTensorPropertiesARM_fnptr(physicalDevice, pExternalTensorInfo, pExternalTensorProperties);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures.html" /></remarks>
        public static void GetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures)
        {
            VkPointers._vkGetPhysicalDeviceFeatures_fnptr(physicalDevice, pFeatures);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures2.html" /></remarks>
        public static void GetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures)
        {
            VkPointers._vkGetPhysicalDeviceFeatures2_fnptr(physicalDevice, pFeatures);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceFeatures2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures2KHR.html" /></remarks>
        public static void GetPhysicalDeviceFeatures2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures)
        {
            VkPointers._vkGetPhysicalDeviceFeatures2KHR_fnptr(physicalDevice, pFeatures);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties.html" /></remarks>
        public static void GetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties)
        {
            VkPointers._vkGetPhysicalDeviceFormatProperties_fnptr(physicalDevice, format, pFormatProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties2.html" /></remarks>
        public static void GetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties)
        {
            VkPointers._vkGetPhysicalDeviceFormatProperties2_fnptr(physicalDevice, format, pFormatProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceFormatProperties2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties2KHR.html" /></remarks>
        public static void GetPhysicalDeviceFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties)
        {
            VkPointers._vkGetPhysicalDeviceFormatProperties2KHR_fnptr(physicalDevice, format, pFormatProperties);
        }
        /// <summary><b>[requires: VK_KHR_fragment_shading_rate]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFragmentShadingRatesKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
        {
            return VkPointers._vkGetPhysicalDeviceFragmentShadingRatesKHR_fnptr(physicalDevice, pFragmentShadingRateCount, pFragmentShadingRates);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties.html" /></remarks>
        public static VkResult GetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlagBits usage, VkImageCreateFlagBits flags, VkImageFormatProperties* pImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceImageFormatProperties_fnptr(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties2.html" /></remarks>
        public static VkResult GetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceImageFormatProperties2_fnptr(physicalDevice, pImageFormatInfo, pImageFormatProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceImageFormatProperties2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties2KHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceImageFormatProperties2KHR_fnptr(physicalDevice, pImageFormatInfo, pImageFormatProperties);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties.html" /></remarks>
        public static void GetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties)
        {
            VkPointers._vkGetPhysicalDeviceMemoryProperties_fnptr(physicalDevice, pMemoryProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties2.html" /></remarks>
        public static void GetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties)
        {
            VkPointers._vkGetPhysicalDeviceMemoryProperties2_fnptr(physicalDevice, pMemoryProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceMemoryProperties2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties2KHR.html" /></remarks>
        public static void GetPhysicalDeviceMemoryProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties)
        {
            VkPointers._vkGetPhysicalDeviceMemoryProperties2KHR_fnptr(physicalDevice, pMemoryProperties);
        }
        /// <summary><b>[requires: VK_EXT_sample_locations]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMultisamplePropertiesEXT.html" /></remarks>
        public static void GetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT* pMultisampleProperties)
        {
            VkPointers._vkGetPhysicalDeviceMultisamplePropertiesEXT_fnptr(physicalDevice, samples, pMultisampleProperties);
        }
        /// <summary><b>[requires: VK_NV_optical_flow]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceOpticalFlowImageFormatsNV.html" /></remarks>
        public static VkResult GetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceOpticalFlowImageFormatsNV_fnptr(physicalDevice, pOpticalFlowImageFormatInfo, pFormatCount, pImageFormatProperties);
        }
        /// <summary><b>[requires: VK_KHR_swapchain | VK_KHR_device_group]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDevicePresentRectanglesKHR.html" /></remarks>
        public static VkResult GetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects)
        {
            return VkPointers._vkGetPhysicalDevicePresentRectanglesKHR_fnptr(physicalDevice, surface, pRectCount, pRects);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties.html" /></remarks>
        public static void GetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceProperties_fnptr(physicalDevice, pProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties2.html" /></remarks>
        public static void GetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceProperties2_fnptr(physicalDevice, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceProperties2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties2KHR.html" /></remarks>
        public static void GetPhysicalDeviceProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceProperties2KHR_fnptr(physicalDevice, pProperties);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM.html" /></remarks>
        public static void GetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM(VkPhysicalDevice physicalDevice, VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM* pQueueFamilyDataGraphProcessingEngineInfo, VkQueueFamilyDataGraphProcessingEnginePropertiesARM* pQueueFamilyDataGraphProcessingEngineProperties)
        {
            VkPointers._vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM_fnptr(physicalDevice, pQueueFamilyDataGraphProcessingEngineInfo, pQueueFamilyDataGraphProcessingEngineProperties);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM.html" /></remarks>
        public static VkResult GetPhysicalDeviceQueueFamilyDataGraphPropertiesARM(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pQueueFamilyDataGraphPropertyCount, VkQueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties)
        {
            return VkPointers._vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM_fnptr(physicalDevice, queueFamilyIndex, pQueueFamilyDataGraphPropertyCount, pQueueFamilyDataGraphProperties);
        }
        /// <summary><b>[requires: VK_KHR_performance_query]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR.html" /></remarks>
        public static void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses)
        {
            VkPointers._vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_fnptr(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties.html" /></remarks>
        public static void GetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties)
        {
            VkPointers._vkGetPhysicalDeviceQueueFamilyProperties_fnptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties2.html" /></remarks>
        public static void GetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
        {
            VkPointers._vkGetPhysicalDeviceQueueFamilyProperties2_fnptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceQueueFamilyProperties2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties2KHR.html" /></remarks>
        public static void GetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
        {
            VkPointers._vkGetPhysicalDeviceQueueFamilyProperties2KHR_fnptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        /// <summary><b>[requires: VK_KHR_object_refresh]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceRefreshableObjectTypesKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceRefreshableObjectTypesKHR(VkPhysicalDevice physicalDevice, uint* pRefreshableObjectTypeCount, VkObjectType* pRefreshableObjectTypes)
        {
            return VkPointers._vkGetPhysicalDeviceRefreshableObjectTypesKHR_fnptr(physicalDevice, pRefreshableObjectTypeCount, pRefreshableObjectTypes);
        }
        /// <summary><b>[requires: VK_NV_external_memory_sci_buf]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSciBufAttributesNV.html" /></remarks>
        public static VkResult GetPhysicalDeviceSciBufAttributesNV(VkPhysicalDevice physicalDevice, IntPtr pAttributes)
        {
            return VkPointers._vkGetPhysicalDeviceSciBufAttributesNV_fnptr(physicalDevice, pAttributes);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync | VK_NV_external_sci_sync2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSciSyncAttributesNV.html" /></remarks>
        public static VkResult GetPhysicalDeviceSciSyncAttributesNV(VkPhysicalDevice physicalDevice, VkSciSyncAttributesInfoNV* pSciSyncAttributesInfo, IntPtr pAttributes)
        {
            return VkPointers._vkGetPhysicalDeviceSciSyncAttributesNV_fnptr(physicalDevice, pSciSyncAttributesInfo, pAttributes);
        }
        /// <summary><b>[requires: VK_QNX_screen_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceScreenPresentationSupportQNX.html" /></remarks>
        public static int GetPhysicalDeviceScreenPresentationSupportQNX(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* window)
        {
            return VkPointers._vkGetPhysicalDeviceScreenPresentationSupportQNX_fnptr(physicalDevice, queueFamilyIndex, window);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties.html" /></remarks>
        public static void GetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlagBits usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceSparseImageFormatProperties_fnptr(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties2.html" /></remarks>
        public static void GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceSparseImageFormatProperties2_fnptr(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceSparseImageFormatProperties2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties2KHR.html" /></remarks>
        public static void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
        {
            VkPointers._vkGetPhysicalDeviceSparseImageFormatProperties2KHR_fnptr(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_NV_coverage_reduction_mode]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV.html" /></remarks>
        public static VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
        {
            return VkPointers._vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_fnptr(physicalDevice, pCombinationCount, pCombinations);
        }
        /// <summary><b>[requires: VK_EXT_display_surface_counter]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilities2EXT.html" /></remarks>
        public static VkResult GetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceCapabilities2EXT_fnptr(physicalDevice, surface, pSurfaceCapabilities);
        }
        /// <summary><b>[requires: VK_KHR_get_surface_capabilities2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilities2KHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceCapabilities2KHR_fnptr(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);
        }
        /// <summary><b>[requires: VK_KHR_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilitiesKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceCapabilitiesKHR_fnptr(physicalDevice, surface, pSurfaceCapabilities);
        }
        /// <summary><b>[requires: VK_KHR_get_surface_capabilities2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceFormats2KHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceFormats2KHR_fnptr(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);
        }
        /// <summary><b>[requires: VK_KHR_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceFormatsKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceFormatsKHR_fnptr(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);
        }
        /// <summary><b>[requires: VK_EXT_full_screen_exclusive]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfacePresentModes2EXT.html" /></remarks>
        public static VkResult GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            return VkPointers._vkGetPhysicalDeviceSurfacePresentModes2EXT_fnptr(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);
        }
        /// <summary><b>[requires: VK_KHR_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfacePresentModesKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            return VkPointers._vkGetPhysicalDeviceSurfacePresentModesKHR_fnptr(physicalDevice, surface, pPresentModeCount, pPresentModes);
        }
        /// <summary><b>[requires: VK_KHR_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceSupportKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, int* pSupported)
        {
            return VkPointers._vkGetPhysicalDeviceSurfaceSupportKHR_fnptr(physicalDevice, queueFamilyIndex, surface, pSupported);
        }
        /// <summary><b>[requires: v1.3]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceToolProperties.html" /></remarks>
        public static VkResult GetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
        {
            return VkPointers._vkGetPhysicalDeviceToolProperties_fnptr(physicalDevice, pToolCount, pToolProperties);
        }
        /// <summary><b>[requires: VK_EXT_tooling_info]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceToolProperties"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceToolPropertiesEXT.html" /></remarks>
        public static VkResult GetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
        {
            return VkPointers._vkGetPhysicalDeviceToolPropertiesEXT_fnptr(physicalDevice, pToolCount, pToolProperties);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoCapabilitiesKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkVideoProfileInfoKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
        {
            return VkPointers._vkGetPhysicalDeviceVideoCapabilitiesKHR_fnptr(physicalDevice, pVideoProfile, pCapabilities);
        }
        /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo, VkVideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties)
        {
            return VkPointers._vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_fnptr(physicalDevice, pQualityLevelInfo, pQualityLevelProperties);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoFormatPropertiesKHR.html" /></remarks>
        public static VkResult GetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            return VkPointers._vkGetPhysicalDeviceVideoFormatPropertiesKHR_fnptr(physicalDevice, pVideoFormatInfo, pVideoFormatPropertyCount, pVideoFormatProperties);
        }
        /// <summary><b>[requires: VK_KHR_wayland_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceWaylandPresentationSupportKHR.html" /></remarks>
        public static int GetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display)
        {
            return VkPointers._vkGetPhysicalDeviceWaylandPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, display);
        }
        /// <summary><b>[requires: VK_KHR_win32_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceWin32PresentationSupportKHR.html" /></remarks>
        public static int GetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
        {
            return VkPointers._vkGetPhysicalDeviceWin32PresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex);
        }
        /// <summary><b>[requires: VK_KHR_xcb_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceXcbPresentationSupportKHR.html" /></remarks>
        public static int GetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, uint visual_id)
        {
            return VkPointers._vkGetPhysicalDeviceXcbPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, connection, visual_id);
        }
        /// <summary><b>[requires: VK_KHR_xlib_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceXlibPresentationSupportKHR.html" /></remarks>
        public static int GetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, nuint visualID)
        {
            return VkPointers._vkGetPhysicalDeviceXlibPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, dpy, visualID);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_binary]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineBinaryDataKHR.html" /></remarks>
        public static VkResult GetPipelineBinaryDataKHR(VkDevice device, VkPipelineBinaryDataInfoKHR* pInfo, VkPipelineBinaryKeyKHR* pPipelineBinaryKey, nuint* pPipelineBinaryDataSize, void* pPipelineBinaryData)
        {
            return VkPointers._vkGetPipelineBinaryDataKHR_fnptr(device, pInfo, pPipelineBinaryKey, pPipelineBinaryDataSize, pPipelineBinaryData);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineCacheData.html" /></remarks>
        public static VkResult GetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, nuint* pDataSize, void* pData)
        {
            return VkPointers._vkGetPipelineCacheData_fnptr(device, pipelineCache, pDataSize, pData);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_executable_properties]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutableInternalRepresentationsKHR.html" /></remarks>
        public static VkResult GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            return VkPointers._vkGetPipelineExecutableInternalRepresentationsKHR_fnptr(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_executable_properties]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutablePropertiesKHR.html" /></remarks>
        public static VkResult GetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            return VkPointers._vkGetPipelineExecutablePropertiesKHR_fnptr(device, pPipelineInfo, pExecutableCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_executable_properties]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutableStatisticsKHR.html" /></remarks>
        public static VkResult GetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            return VkPointers._vkGetPipelineExecutableStatisticsKHR_fnptr(device, pExecutableInfo, pStatisticCount, pStatistics);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands_compute]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineIndirectDeviceAddressNV.html" /></remarks>
        public static ulong GetPipelineIndirectDeviceAddressNV(VkDevice device, VkPipelineIndirectDeviceAddressInfoNV* pInfo)
        {
            return VkPointers._vkGetPipelineIndirectDeviceAddressNV_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands_compute]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineIndirectMemoryRequirementsNV.html" /></remarks>
        public static void GetPipelineIndirectMemoryRequirementsNV(VkDevice device, VkComputePipelineCreateInfo* pCreateInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetPipelineIndirectMemoryRequirementsNV_fnptr(device, pCreateInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_binary]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineKeyKHR.html" /></remarks>
        public static VkResult GetPipelineKeyKHR(VkDevice device, VkPipelineCreateInfoKHR* pPipelineCreateInfo, VkPipelineBinaryKeyKHR* pPipelineKey)
        {
            return VkPointers._vkGetPipelineKeyKHR_fnptr(device, pPipelineCreateInfo, pPipelineKey);
        }
        /// <summary><b>[requires: VK_EXT_pipeline_properties]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelinePropertiesEXT.html" /></remarks>
        public static VkResult GetPipelinePropertiesEXT(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
        {
            return VkPointers._vkGetPipelinePropertiesEXT_fnptr(device, pPipelineInfo, pPipelineProperties);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPrivateData.html" /></remarks>
        public static void GetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong* pData)
        {
            VkPointers._vkGetPrivateData_fnptr(device, objectType, objectHandle, privateDataSlot, pData);
        }
        /// <summary><b>[requires: VK_EXT_private_data]</b> [device command]  Alias of <see cref="GetPrivateData"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPrivateDataEXT.html" /></remarks>
        public static void GetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong* pData)
        {
            VkPointers._vkGetPrivateDataEXT_fnptr(device, objectType, objectHandle, privateDataSlot, pData);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetQueryPoolResults.html" /></remarks>
        public static VkResult GetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* pData, ulong stride, VkQueryResultFlagBits flags)
        {
            return VkPointers._vkGetQueryPoolResults_fnptr(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);
        }
        /// <summary><b>[requires: VK_NV_device_diagnostic_checkpoints]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetQueueCheckpointData2NV.html" /></remarks>
        public static void GetQueueCheckpointData2NV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
        {
            VkPointers._vkGetQueueCheckpointData2NV_fnptr(queue, pCheckpointDataCount, pCheckpointData);
        }
        /// <summary><b>[requires: VK_NV_device_diagnostic_checkpoints]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetQueueCheckpointDataNV.html" /></remarks>
        public static void GetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
        {
            VkPointers._vkGetQueueCheckpointDataNV_fnptr(queue, pCheckpointDataCount, pCheckpointData);
        }
        /// <summary><b>[requires: VK_EXT_acquire_xlib_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRandROutputDisplayEXT.html" /></remarks>
        public static VkResult GetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, nuint rrOutput, VkDisplayKHR* pDisplay)
        {
            return VkPointers._vkGetRandROutputDisplayEXT_fnptr(physicalDevice, dpy, rrOutput, pDisplay);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingCaptureReplayShaderGroupHandlesKHR.html" /></remarks>
        public static VkResult GetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
        {
            return VkPointers._vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_fnptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingShaderGroupHandlesKHR.html" /></remarks>
        public static VkResult GetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
        {
            return VkPointers._vkGetRayTracingShaderGroupHandlesKHR_fnptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command]  Alias of <see cref="GetRayTracingShaderGroupHandlesKHR"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingShaderGroupHandlesNV.html" /></remarks>
        public static VkResult GetRayTracingShaderGroupHandlesNV(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
        {
            return VkPointers._vkGetRayTracingShaderGroupHandlesNV_fnptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingShaderGroupStackSizeKHR.html" /></remarks>
        public static ulong GetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader)
        {
            return VkPointers._vkGetRayTracingShaderGroupStackSizeKHR_fnptr(device, pipeline, group, groupShader);
        }
        /// <summary><b>[requires: VK_GOOGLE_display_timing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRefreshCycleDurationGOOGLE.html" /></remarks>
        public static VkResult GetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties)
        {
            return VkPointers._vkGetRefreshCycleDurationGOOGLE_fnptr(device, swapchain, pDisplayTimingProperties);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRenderAreaGranularity.html" /></remarks>
        public static void GetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity)
        {
            VkPointers._vkGetRenderAreaGranularity_fnptr(device, renderPass, pGranularity);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRenderingAreaGranularity.html" /></remarks>
        public static void GetRenderingAreaGranularity(VkDevice device, VkRenderingAreaInfo* pRenderingAreaInfo, VkExtent2D* pGranularity)
        {
            VkPointers._vkGetRenderingAreaGranularity_fnptr(device, pRenderingAreaInfo, pGranularity);
        }
        /// <summary><b>[requires: VK_KHR_maintenance5]</b> [device command]  Alias of <see cref="GetRenderingAreaGranularity"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRenderingAreaGranularityKHR.html" /></remarks>
        public static void GetRenderingAreaGranularityKHR(VkDevice device, VkRenderingAreaInfo* pRenderingAreaInfo, VkExtent2D* pGranularity)
        {
            VkPointers._vkGetRenderingAreaGranularityKHR_fnptr(device, pRenderingAreaInfo, pGranularity);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSamplerOpaqueCaptureDescriptorDataEXT.html" /></remarks>
        public static VkResult GetSamplerOpaqueCaptureDescriptorDataEXT(VkDevice device, VkSamplerCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return VkPointers._vkGetSamplerOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: VK_QNX_external_memory_screen_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetScreenBufferPropertiesQNX.html" /></remarks>
        public static VkResult GetScreenBufferPropertiesQNX(VkDevice device, IntPtr* buffer, VkScreenBufferPropertiesQNX* pProperties)
        {
            return VkPointers._vkGetScreenBufferPropertiesQNX_fnptr(device, buffer, pProperties);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreCounterValue.html" /></remarks>
        public static VkResult GetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, ulong* pValue)
        {
            return VkPointers._vkGetSemaphoreCounterValue_fnptr(device, semaphore, pValue);
        }
        /// <summary><b>[requires: VK_KHR_timeline_semaphore]</b> [device command]  Alias of <see cref="GetSemaphoreCounterValue"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreCounterValueKHR.html" /></remarks>
        public static VkResult GetSemaphoreCounterValueKHR(VkDevice device, VkSemaphore semaphore, ulong* pValue)
        {
            return VkPointers._vkGetSemaphoreCounterValueKHR_fnptr(device, semaphore, pValue);
        }
        /// <summary><b>[requires: VK_KHR_external_semaphore_fd]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreFdKHR.html" /></remarks>
        public static VkResult GetSemaphoreFdKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            return VkPointers._vkGetSemaphoreFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreSciSyncObjNV.html" /></remarks>
        public static VkResult GetSemaphoreSciSyncObjNV(VkDevice device, VkSemaphoreGetSciSyncInfoNV* pGetSciSyncInfo, void* pHandle)
        {
            return VkPointers._vkGetSemaphoreSciSyncObjNV_fnptr(device, pGetSciSyncInfo, pHandle);
        }
        /// <summary><b>[requires: VK_KHR_external_semaphore_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreWin32HandleKHR.html" /></remarks>
        public static VkResult GetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            return VkPointers._vkGetSemaphoreWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        /// <summary><b>[requires: VK_FUCHSIA_external_semaphore]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreZirconHandleFUCHSIA.html" /></remarks>
        public static VkResult GetSemaphoreZirconHandleFUCHSIA(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, int* pZirconHandle)
        {
            return VkPointers._vkGetSemaphoreZirconHandleFUCHSIA_fnptr(device, pGetZirconHandleInfo, pZirconHandle);
        }
        /// <summary><b>[requires: VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetShaderBinaryDataEXT.html" /></remarks>
        public static VkResult GetShaderBinaryDataEXT(VkDevice device, VkShaderEXT shader, nuint* pDataSize, void* pData)
        {
            return VkPointers._vkGetShaderBinaryDataEXT_fnptr(device, shader, pDataSize, pData);
        }
        /// <summary><b>[requires: VK_AMD_shader_info]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetShaderInfoAMD.html" /></remarks>
        public static VkResult GetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, nuint* pInfoSize, void* pInfo)
        {
            return VkPointers._vkGetShaderInfoAMD_fnptr(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_shader_module_identifier]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetShaderModuleCreateInfoIdentifierEXT.html" /></remarks>
        public static void GetShaderModuleCreateInfoIdentifierEXT(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            VkPointers._vkGetShaderModuleCreateInfoIdentifierEXT_fnptr(device, pCreateInfo, pIdentifier);
        }
        /// <summary><b>[requires: VK_EXT_shader_module_identifier]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetShaderModuleIdentifierEXT.html" /></remarks>
        public static void GetShaderModuleIdentifierEXT(VkDevice device, VkShaderModule shaderModule, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            VkPointers._vkGetShaderModuleIdentifierEXT_fnptr(device, shaderModule, pIdentifier);
        }
        /// <summary><b>[requires: VK_EXT_display_control]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainCounterEXT.html" /></remarks>
        public static VkResult GetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue)
        {
            return VkPointers._vkGetSwapchainCounterEXT_fnptr(device, swapchain, counter, pCounterValue);
        }
        /// <summary>[device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainGrallocUsage2ANDROID.html" /></remarks>
        public static VkResult GetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlagBits imageUsage, VkSwapchainImageUsageFlagBitsANDROID swapchainImageUsage, ulong* grallocConsumerUsage, ulong* grallocProducerUsage)
        {
            return VkPointers._vkGetSwapchainGrallocUsage2ANDROID_fnptr(device, format, imageUsage, swapchainImageUsage, grallocConsumerUsage, grallocProducerUsage);
        }
        /// <summary>[device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainGrallocUsageANDROID.html" /></remarks>
        public static VkResult GetSwapchainGrallocUsageANDROID(VkDevice device, VkFormat format, VkImageUsageFlagBits imageUsage, int* grallocUsage)
        {
            return VkPointers._vkGetSwapchainGrallocUsageANDROID_fnptr(device, format, imageUsage, grallocUsage);
        }
        /// <summary><b>[requires: VK_OHOS_native_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainGrallocUsageOHOS.html" /></remarks>
        public static VkResult GetSwapchainGrallocUsageOHOS(VkDevice device, VkFormat format, VkImageUsageFlagBits imageUsage, ulong* grallocUsage)
        {
            return VkPointers._vkGetSwapchainGrallocUsageOHOS_fnptr(device, format, imageUsage, grallocUsage);
        }
        /// <summary><b>[requires: VK_KHR_swapchain]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainImagesKHR.html" /></remarks>
        public static VkResult GetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages)
        {
            return VkPointers._vkGetSwapchainImagesKHR_fnptr(device, swapchain, pSwapchainImageCount, pSwapchainImages);
        }
        /// <summary><b>[requires: VK_KHR_shared_presentable_image]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainStatusKHR.html" /></remarks>
        public static VkResult GetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain)
        {
            return VkPointers._vkGetSwapchainStatusKHR_fnptr(device, swapchain);
        }
        /// <summary><b>[requires: VK_EXT_present_timing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainTimeDomainPropertiesEXT.html" /></remarks>
        public static VkResult GetSwapchainTimeDomainPropertiesEXT(VkDevice device, VkSwapchainKHR swapchain, VkSwapchainTimeDomainPropertiesEXT* pSwapchainTimeDomainProperties, ulong* pTimeDomainsCounter)
        {
            return VkPointers._vkGetSwapchainTimeDomainPropertiesEXT_fnptr(device, swapchain, pSwapchainTimeDomainProperties, pTimeDomainsCounter);
        }
        /// <summary><b>[requires: VK_EXT_present_timing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainTimingPropertiesEXT.html" /></remarks>
        public static VkResult GetSwapchainTimingPropertiesEXT(VkDevice device, VkSwapchainKHR swapchain, VkSwapchainTimingPropertiesEXT* pSwapchainTimingProperties, ulong* pSwapchainTimingPropertiesCounter)
        {
            return VkPointers._vkGetSwapchainTimingPropertiesEXT_fnptr(device, swapchain, pSwapchainTimingProperties, pSwapchainTimingPropertiesCounter);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetTensorMemoryRequirementsARM.html" /></remarks>
        public static void GetTensorMemoryRequirementsARM(VkDevice device, VkTensorMemoryRequirementsInfoARM* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            VkPointers._vkGetTensorMemoryRequirementsARM_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetTensorOpaqueCaptureDescriptorDataARM.html" /></remarks>
        public static VkResult GetTensorOpaqueCaptureDescriptorDataARM(VkDevice device, VkTensorCaptureDescriptorDataInfoARM* pInfo, void* pData)
        {
            return VkPointers._vkGetTensorOpaqueCaptureDescriptorDataARM_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetTensorViewOpaqueCaptureDescriptorDataARM.html" /></remarks>
        public static VkResult GetTensorViewOpaqueCaptureDescriptorDataARM(VkDevice device, VkTensorViewCaptureDescriptorDataInfoARM* pInfo, void* pData)
        {
            return VkPointers._vkGetTensorViewOpaqueCaptureDescriptorDataARM_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: VK_EXT_validation_cache]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetValidationCacheDataEXT.html" /></remarks>
        public static VkResult GetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, nuint* pDataSize, void* pData)
        {
            return VkPointers._vkGetValidationCacheDataEXT_fnptr(device, validationCache, pDataSize, pData);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetVideoSessionMemoryRequirementsKHR.html" /></remarks>
        public static VkResult GetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, uint* pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
        {
            return VkPointers._vkGetVideoSessionMemoryRequirementsKHR_fnptr(device, videoSession, pMemoryRequirementsCount, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_NV_acquire_winrt_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetWinrtDisplayNV.html" /></remarks>
        public static VkResult GetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, VkDisplayKHR* pDisplay)
        {
            return VkPointers._vkGetWinrtDisplayNV_fnptr(physicalDevice, deviceRelativeId, pDisplay);
        }
        /// <summary><b>[requires: VK_KHR_external_fence_fd]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportFenceFdKHR.html" /></remarks>
        public static VkResult ImportFenceFdKHR(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo)
        {
            return VkPointers._vkImportFenceFdKHR_fnptr(device, pImportFenceFdInfo);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync | VK_NV_external_sci_sync2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportFenceSciSyncFenceNV.html" /></remarks>
        public static VkResult ImportFenceSciSyncFenceNV(VkDevice device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo)
        {
            return VkPointers._vkImportFenceSciSyncFenceNV_fnptr(device, pImportFenceSciSyncInfo);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync | VK_NV_external_sci_sync2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportFenceSciSyncObjNV.html" /></remarks>
        public static VkResult ImportFenceSciSyncObjNV(VkDevice device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo)
        {
            return VkPointers._vkImportFenceSciSyncObjNV_fnptr(device, pImportFenceSciSyncInfo);
        }
        /// <summary><b>[requires: VK_KHR_external_fence_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportFenceWin32HandleKHR.html" /></remarks>
        public static VkResult ImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
        {
            return VkPointers._vkImportFenceWin32HandleKHR_fnptr(device, pImportFenceWin32HandleInfo);
        }
        /// <summary><b>[requires: VK_KHR_external_semaphore_fd]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreFdKHR.html" /></remarks>
        public static VkResult ImportSemaphoreFdKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo)
        {
            return VkPointers._vkImportSemaphoreFdKHR_fnptr(device, pImportSemaphoreFdInfo);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreSciSyncObjNV.html" /></remarks>
        public static VkResult ImportSemaphoreSciSyncObjNV(VkDevice device, VkImportSemaphoreSciSyncInfoNV* pImportSemaphoreSciSyncInfo)
        {
            return VkPointers._vkImportSemaphoreSciSyncObjNV_fnptr(device, pImportSemaphoreSciSyncInfo);
        }
        /// <summary><b>[requires: VK_KHR_external_semaphore_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreWin32HandleKHR.html" /></remarks>
        public static VkResult ImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo)
        {
            return VkPointers._vkImportSemaphoreWin32HandleKHR_fnptr(device, pImportSemaphoreWin32HandleInfo);
        }
        /// <summary><b>[requires: VK_FUCHSIA_external_semaphore]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreZirconHandleFUCHSIA.html" /></remarks>
        public static VkResult ImportSemaphoreZirconHandleFUCHSIA(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo)
        {
            return VkPointers._vkImportSemaphoreZirconHandleFUCHSIA_fnptr(device, pImportSemaphoreZirconHandleInfo);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkInitializePerformanceApiINTEL.html" /></remarks>
        public static VkResult InitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo)
        {
            return VkPointers._vkInitializePerformanceApiINTEL_fnptr(device, pInitializeInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkInvalidateMappedMemoryRanges.html" /></remarks>
        public static VkResult InvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
        {
            return VkPointers._vkInvalidateMappedMemoryRanges_fnptr(device, memoryRangeCount, pMemoryRanges);
        }
        /// <summary><b>[requires: VK_NV_low_latency2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkLatencySleepNV.html" /></remarks>
        public static VkResult LatencySleepNV(VkDevice device, VkSwapchainKHR swapchain, VkLatencySleepInfoNV* pSleepInfo)
        {
            return VkPointers._vkLatencySleepNV_fnptr(device, swapchain, pSleepInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkMapMemory.html" /></remarks>
        public static VkResult MapMemory(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, VkMemoryMapFlagBits flags, void** ppData)
        {
            return VkPointers._vkMapMemory_fnptr(device, memory, offset, size, flags, ppData);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkMapMemory2.html" /></remarks>
        public static VkResult MapMemory2(VkDevice device, VkMemoryMapInfo* pMemoryMapInfo, void** ppData)
        {
            return VkPointers._vkMapMemory2_fnptr(device, pMemoryMapInfo, ppData);
        }
        /// <summary><b>[requires: VK_KHR_map_memory2]</b> [device command]  Alias of <see cref="MapMemory2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkMapMemory2KHR.html" /></remarks>
        public static VkResult MapMemory2KHR(VkDevice device, VkMemoryMapInfo* pMemoryMapInfo, void** ppData)
        {
            return VkPointers._vkMapMemory2KHR_fnptr(device, pMemoryMapInfo, ppData);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkMergePipelineCaches.html" /></remarks>
        public static VkResult MergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches)
        {
            return VkPointers._vkMergePipelineCaches_fnptr(device, dstCache, srcCacheCount, pSrcCaches);
        }
        /// <summary><b>[requires: VK_EXT_validation_cache]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkMergeValidationCachesEXT.html" /></remarks>
        public static VkResult MergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches)
        {
            return VkPointers._vkMergeValidationCachesEXT_fnptr(device, dstCache, srcCacheCount, pSrcCaches);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueBeginDebugUtilsLabelEXT.html" /></remarks>
        public static void QueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            VkPointers._vkQueueBeginDebugUtilsLabelEXT_fnptr(queue, pLabelInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueBindSparse.html" /></remarks>
        public static VkResult QueueBindSparse(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence)
        {
            return VkPointers._vkQueueBindSparse_fnptr(queue, bindInfoCount, pBindInfo, fence);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueEndDebugUtilsLabelEXT.html" /></remarks>
        public static void QueueEndDebugUtilsLabelEXT(VkQueue queue)
        {
            VkPointers._vkQueueEndDebugUtilsLabelEXT_fnptr(queue);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueInsertDebugUtilsLabelEXT.html" /></remarks>
        public static void QueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            VkPointers._vkQueueInsertDebugUtilsLabelEXT_fnptr(queue, pLabelInfo);
        }
        /// <summary><b>[requires: VK_NV_low_latency2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueNotifyOutOfBandNV.html" /></remarks>
        public static void QueueNotifyOutOfBandNV(VkQueue queue, VkOutOfBandQueueTypeInfoNV* pQueueTypeInfo)
        {
            VkPointers._vkQueueNotifyOutOfBandNV_fnptr(queue, pQueueTypeInfo);
        }
        /// <summary><b>[requires: VK_KHR_swapchain]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueuePresentKHR.html" /></remarks>
        public static VkResult QueuePresentKHR(VkQueue queue, VkPresentInfoKHR* pPresentInfo)
        {
            return VkPointers._vkQueuePresentKHR_fnptr(queue, pPresentInfo);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueSetPerformanceConfigurationINTEL.html" /></remarks>
        public static VkResult QueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
        {
            return VkPointers._vkQueueSetPerformanceConfigurationINTEL_fnptr(queue, configuration);
        }
        /// <summary>[device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueSignalReleaseImageANDROID.html" /></remarks>
        public static VkResult QueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, int* pNativeFenceFd)
        {
            return VkPointers._vkQueueSignalReleaseImageANDROID_fnptr(queue, waitSemaphoreCount, pWaitSemaphores, image, pNativeFenceFd);
        }
        /// <summary><b>[requires: VK_OHOS_native_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueSignalReleaseImageOHOS.html" /></remarks>
        public static VkResult QueueSignalReleaseImageOHOS(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, int* pNativeFenceFd)
        {
            return VkPointers._vkQueueSignalReleaseImageOHOS_fnptr(queue, waitSemaphoreCount, pWaitSemaphores, image, pNativeFenceFd);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueSubmit.html" /></remarks>
        public static VkResult QueueSubmit(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence)
        {
            return VkPointers._vkQueueSubmit_fnptr(queue, submitCount, pSubmits, fence);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueSubmit2.html" /></remarks>
        public static VkResult QueueSubmit2(VkQueue queue, uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence)
        {
            return VkPointers._vkQueueSubmit2_fnptr(queue, submitCount, pSubmits, fence);
        }
        /// <summary><b>[requires: VK_KHR_synchronization2]</b> [device command]  Alias of <see cref="QueueSubmit2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueSubmit2KHR.html" /></remarks>
        public static VkResult QueueSubmit2KHR(VkQueue queue, uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence)
        {
            return VkPointers._vkQueueSubmit2KHR_fnptr(queue, submitCount, pSubmits, fence);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueWaitIdle.html" /></remarks>
        public static VkResult QueueWaitIdle(VkQueue queue)
        {
            return VkPointers._vkQueueWaitIdle_fnptr(queue);
        }
        /// <summary><b>[requires: VK_EXT_display_control]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkRegisterDeviceEventEXT.html" /></remarks>
        public static VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            return VkPointers._vkRegisterDeviceEventEXT_fnptr(device, pDeviceEventInfo, pAllocator, pFence);
        }
        /// <summary><b>[requires: VK_EXT_display_control]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkRegisterDisplayEventEXT.html" /></remarks>
        public static VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            return VkPointers._vkRegisterDisplayEventEXT_fnptr(device, display, pDisplayEventInfo, pAllocator, pFence);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_binary]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseCapturedPipelineDataKHR.html" /></remarks>
        public static VkResult ReleaseCapturedPipelineDataKHR(VkDevice device, VkReleaseCapturedPipelineDataInfoKHR* pInfo, VkAllocationCallbacks* pAllocator)
        {
            return VkPointers._vkReleaseCapturedPipelineDataKHR_fnptr(device, pInfo, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_direct_mode_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseDisplayEXT.html" /></remarks>
        public static VkResult ReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
        {
            return VkPointers._vkReleaseDisplayEXT_fnptr(physicalDevice, display);
        }
        /// <summary><b>[requires: VK_EXT_full_screen_exclusive]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseFullScreenExclusiveModeEXT.html" /></remarks>
        public static VkResult ReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
        {
            return VkPointers._vkReleaseFullScreenExclusiveModeEXT_fnptr(device, swapchain);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleasePerformanceConfigurationINTEL.html" /></remarks>
        public static VkResult ReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration)
        {
            return VkPointers._vkReleasePerformanceConfigurationINTEL_fnptr(device, configuration);
        }
        /// <summary><b>[requires: VK_KHR_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseProfilingLockKHR.html" /></remarks>
        public static void ReleaseProfilingLockKHR(VkDevice device)
        {
            VkPointers._vkReleaseProfilingLockKHR_fnptr(device);
        }
        /// <summary><b>[requires: VK_EXT_swapchain_maintenance1]</b> [device command]  Alias of <see cref="ReleaseSwapchainImagesKHR"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseSwapchainImagesEXT.html" /></remarks>
        public static VkResult ReleaseSwapchainImagesEXT(VkDevice device, VkReleaseSwapchainImagesInfoKHR* pReleaseInfo)
        {
            return VkPointers._vkReleaseSwapchainImagesEXT_fnptr(device, pReleaseInfo);
        }
        /// <summary><b>[requires: VK_KHR_swapchain_maintenance1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseSwapchainImagesKHR.html" /></remarks>
        public static VkResult ReleaseSwapchainImagesKHR(VkDevice device, VkReleaseSwapchainImagesInfoKHR* pReleaseInfo)
        {
            return VkPointers._vkReleaseSwapchainImagesKHR_fnptr(device, pReleaseInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetCommandBuffer.html" /></remarks>
        public static VkResult ResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlagBits flags)
        {
            return VkPointers._vkResetCommandBuffer_fnptr(commandBuffer, flags);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetCommandPool.html" /></remarks>
        public static VkResult ResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlagBits flags)
        {
            return VkPointers._vkResetCommandPool_fnptr(device, commandPool, flags);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetDescriptorPool.html" /></remarks>
        public static VkResult ResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags)
        {
            return VkPointers._vkResetDescriptorPool_fnptr(device, descriptorPool, flags);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetEvent.html" /></remarks>
        public static VkResult ResetEvent(VkDevice device, VkEvent @event)
        {
            return VkPointers._vkResetEvent_fnptr(device, @event);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetFences.html" /></remarks>
        public static VkResult ResetFences(VkDevice device, uint fenceCount, VkFence* pFences)
        {
            return VkPointers._vkResetFences_fnptr(device, fenceCount, pFences);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetQueryPool.html" /></remarks>
        public static void ResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            VkPointers._vkResetQueryPool_fnptr(device, queryPool, firstQuery, queryCount);
        }
        /// <summary><b>[requires: VK_EXT_host_query_reset]</b> [device command]  Alias of <see cref="ResetQueryPool"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetQueryPoolEXT.html" /></remarks>
        public static void ResetQueryPoolEXT(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            VkPointers._vkResetQueryPoolEXT_fnptr(device, queryPool, firstQuery, queryCount);
        }
        /// <summary><b>[requires: VK_FUCHSIA_buffer_collection]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetBufferCollectionBufferConstraintsFUCHSIA.html" /></remarks>
        public static VkResult SetBufferCollectionBufferConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferConstraintsInfoFUCHSIA* pBufferConstraintsInfo)
        {
            return VkPointers._vkSetBufferCollectionBufferConstraintsFUCHSIA_fnptr(device, collection, pBufferConstraintsInfo);
        }
        /// <summary><b>[requires: VK_FUCHSIA_buffer_collection]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetBufferCollectionImageConstraintsFUCHSIA.html" /></remarks>
        public static VkResult SetBufferCollectionImageConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkImageConstraintsInfoFUCHSIA* pImageConstraintsInfo)
        {
            return VkPointers._vkSetBufferCollectionImageConstraintsFUCHSIA_fnptr(device, collection, pImageConstraintsInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetDebugUtilsObjectNameEXT.html" /></remarks>
        public static VkResult SetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo)
        {
            return VkPointers._vkSetDebugUtilsObjectNameEXT_fnptr(device, pNameInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetDebugUtilsObjectTagEXT.html" /></remarks>
        public static VkResult SetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo)
        {
            return VkPointers._vkSetDebugUtilsObjectTagEXT_fnptr(device, pTagInfo);
        }
        /// <summary><b>[requires: VK_EXT_pageable_device_local_memory]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetDeviceMemoryPriorityEXT.html" /></remarks>
        public static void SetDeviceMemoryPriorityEXT(VkDevice device, VkDeviceMemory memory, float priority)
        {
            VkPointers._vkSetDeviceMemoryPriorityEXT_fnptr(device, memory, priority);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetEvent.html" /></remarks>
        public static VkResult SetEvent(VkDevice device, VkEvent @event)
        {
            return VkPointers._vkSetEvent_fnptr(device, @event);
        }
        /// <summary><b>[requires: VK_EXT_hdr_metadata]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetHdrMetadataEXT.html" /></remarks>
        public static void SetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata)
        {
            VkPointers._vkSetHdrMetadataEXT_fnptr(device, swapchainCount, pSwapchains, pMetadata);
        }
        /// <summary><b>[requires: VK_NV_low_latency2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetLatencyMarkerNV.html" /></remarks>
        public static void SetLatencyMarkerNV(VkDevice device, VkSwapchainKHR swapchain, VkSetLatencyMarkerInfoNV* pLatencyMarkerInfo)
        {
            VkPointers._vkSetLatencyMarkerNV_fnptr(device, swapchain, pLatencyMarkerInfo);
        }
        /// <summary><b>[requires: VK_NV_low_latency2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetLatencySleepModeNV.html" /></remarks>
        public static VkResult SetLatencySleepModeNV(VkDevice device, VkSwapchainKHR swapchain, VkLatencySleepModeInfoNV* pSleepModeInfo)
        {
            return VkPointers._vkSetLatencySleepModeNV_fnptr(device, swapchain, pSleepModeInfo);
        }
        /// <summary><b>[requires: VK_AMD_display_native_hdr]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetLocalDimmingAMD.html" /></remarks>
        public static void SetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, int localDimmingEnable)
        {
            VkPointers._vkSetLocalDimmingAMD_fnptr(device, swapChain, localDimmingEnable);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetPrivateData.html" /></remarks>
        public static VkResult SetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data)
        {
            return VkPointers._vkSetPrivateData_fnptr(device, objectType, objectHandle, privateDataSlot, data);
        }
        /// <summary><b>[requires: VK_EXT_private_data]</b> [device command]  Alias of <see cref="SetPrivateData"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetPrivateDataEXT.html" /></remarks>
        public static VkResult SetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data)
        {
            return VkPointers._vkSetPrivateDataEXT_fnptr(device, objectType, objectHandle, privateDataSlot, data);
        }
        /// <summary><b>[requires: VK_EXT_present_timing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetSwapchainPresentTimingQueueSizeEXT.html" /></remarks>
        public static VkResult SetSwapchainPresentTimingQueueSizeEXT(VkDevice device, VkSwapchainKHR swapchain, uint size)
        {
            return VkPointers._vkSetSwapchainPresentTimingQueueSizeEXT_fnptr(device, swapchain, size);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSignalSemaphore.html" /></remarks>
        public static VkResult SignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo)
        {
            return VkPointers._vkSignalSemaphore_fnptr(device, pSignalInfo);
        }
        /// <summary><b>[requires: VK_KHR_timeline_semaphore]</b> [device command]  Alias of <see cref="SignalSemaphore"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSignalSemaphoreKHR.html" /></remarks>
        public static VkResult SignalSemaphoreKHR(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo)
        {
            return VkPointers._vkSignalSemaphoreKHR_fnptr(device, pSignalInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSubmitDebugUtilsMessageEXT.html" /></remarks>
        public static void SubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagBitsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData)
        {
            VkPointers._vkSubmitDebugUtilsMessageEXT_fnptr(instance, messageSeverity, messageTypes, pCallbackData);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkTransitionImageLayout.html" /></remarks>
        public static VkResult TransitionImageLayout(VkDevice device, uint transitionCount, VkHostImageLayoutTransitionInfo* pTransitions)
        {
            return VkPointers._vkTransitionImageLayout_fnptr(device, transitionCount, pTransitions);
        }
        /// <summary><b>[requires: VK_EXT_host_image_copy]</b> [device command]  Alias of <see cref="TransitionImageLayout"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkTransitionImageLayoutEXT.html" /></remarks>
        public static VkResult TransitionImageLayoutEXT(VkDevice device, uint transitionCount, VkHostImageLayoutTransitionInfo* pTransitions)
        {
            return VkPointers._vkTransitionImageLayoutEXT_fnptr(device, transitionCount, pTransitions);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkTrimCommandPool.html" /></remarks>
        public static void TrimCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags)
        {
            VkPointers._vkTrimCommandPool_fnptr(device, commandPool, flags);
        }
        /// <summary><b>[requires: VK_KHR_maintenance1]</b> [device command]  Alias of <see cref="TrimCommandPool"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkTrimCommandPoolKHR.html" /></remarks>
        public static void TrimCommandPoolKHR(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags)
        {
            VkPointers._vkTrimCommandPoolKHR_fnptr(device, commandPool, flags);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUninitializePerformanceApiINTEL.html" /></remarks>
        public static void UninitializePerformanceApiINTEL(VkDevice device)
        {
            VkPointers._vkUninitializePerformanceApiINTEL_fnptr(device);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUnmapMemory.html" /></remarks>
        public static void UnmapMemory(VkDevice device, VkDeviceMemory memory)
        {
            VkPointers._vkUnmapMemory_fnptr(device, memory);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUnmapMemory2.html" /></remarks>
        public static VkResult UnmapMemory2(VkDevice device, VkMemoryUnmapInfo* pMemoryUnmapInfo)
        {
            return VkPointers._vkUnmapMemory2_fnptr(device, pMemoryUnmapInfo);
        }
        /// <summary><b>[requires: VK_KHR_map_memory2]</b> [device command]  Alias of <see cref="UnmapMemory2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUnmapMemory2KHR.html" /></remarks>
        public static VkResult UnmapMemory2KHR(VkDevice device, VkMemoryUnmapInfo* pMemoryUnmapInfo)
        {
            return VkPointers._vkUnmapMemory2KHR_fnptr(device, pMemoryUnmapInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSets.html" /></remarks>
        public static void UpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies)
        {
            VkPointers._vkUpdateDescriptorSets_fnptr(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplate.html" /></remarks>
        public static void UpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
        {
            VkPointers._vkUpdateDescriptorSetWithTemplate_fnptr(device, descriptorSet, descriptorUpdateTemplate, pData);
        }
        /// <summary><b>[requires: VK_KHR_descriptor_update_template]</b> [device command]  Alias of <see cref="UpdateDescriptorSetWithTemplate"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplateKHR.html" /></remarks>
        public static void UpdateDescriptorSetWithTemplateKHR(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
        {
            VkPointers._vkUpdateDescriptorSetWithTemplateKHR_fnptr(device, descriptorSet, descriptorUpdateTemplate, pData);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUpdateIndirectExecutionSetPipelineEXT.html" /></remarks>
        public static void UpdateIndirectExecutionSetPipelineEXT(VkDevice device, VkIndirectExecutionSetEXT indirectExecutionSet, uint executionSetWriteCount, VkWriteIndirectExecutionSetPipelineEXT* pExecutionSetWrites)
        {
            VkPointers._vkUpdateIndirectExecutionSetPipelineEXT_fnptr(device, indirectExecutionSet, executionSetWriteCount, pExecutionSetWrites);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUpdateIndirectExecutionSetShaderEXT.html" /></remarks>
        public static void UpdateIndirectExecutionSetShaderEXT(VkDevice device, VkIndirectExecutionSetEXT indirectExecutionSet, uint executionSetWriteCount, VkWriteIndirectExecutionSetShaderEXT* pExecutionSetWrites)
        {
            VkPointers._vkUpdateIndirectExecutionSetShaderEXT_fnptr(device, indirectExecutionSet, executionSetWriteCount, pExecutionSetWrites);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUpdateVideoSessionParametersKHR.html" /></remarks>
        public static VkResult UpdateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo)
        {
            return VkPointers._vkUpdateVideoSessionParametersKHR_fnptr(device, videoSessionParameters, pUpdateInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWaitForFences.html" /></remarks>
        public static VkResult WaitForFences(VkDevice device, uint fenceCount, VkFence* pFences, int waitAll, ulong timeout)
        {
            return VkPointers._vkWaitForFences_fnptr(device, fenceCount, pFences, waitAll, timeout);
        }
        /// <summary><b>[requires: VK_KHR_present_wait2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWaitForPresent2KHR.html" /></remarks>
        public static VkResult WaitForPresent2KHR(VkDevice device, VkSwapchainKHR swapchain, VkPresentWait2InfoKHR* pPresentWait2Info)
        {
            return VkPointers._vkWaitForPresent2KHR_fnptr(device, swapchain, pPresentWait2Info);
        }
        /// <summary><b>[requires: VK_KHR_present_wait]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWaitForPresentKHR.html" /></remarks>
        public static VkResult WaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout)
        {
            return VkPointers._vkWaitForPresentKHR_fnptr(device, swapchain, presentId, timeout);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWaitSemaphores.html" /></remarks>
        public static VkResult WaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
        {
            return VkPointers._vkWaitSemaphores_fnptr(device, pWaitInfo, timeout);
        }
        /// <summary><b>[requires: VK_KHR_timeline_semaphore]</b> [device command]  Alias of <see cref="WaitSemaphores"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWaitSemaphoresKHR.html" /></remarks>
        public static VkResult WaitSemaphoresKHR(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
        {
            return VkPointers._vkWaitSemaphoresKHR_fnptr(device, pWaitInfo, timeout);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWriteAccelerationStructuresPropertiesKHR.html" /></remarks>
        public static VkResult WriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, nuint dataSize, void* pData, nuint stride)
        {
            return VkPointers._vkWriteAccelerationStructuresPropertiesKHR_fnptr(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWriteMicromapsPropertiesEXT.html" /></remarks>
        public static VkResult WriteMicromapsPropertiesEXT(VkDevice device, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, nuint dataSize, void* pData, nuint stride)
        {
            return VkPointers._vkWriteMicromapsPropertiesEXT_fnptr(device, micromapCount, pMicromaps, queryType, dataSize, pData, stride);
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
