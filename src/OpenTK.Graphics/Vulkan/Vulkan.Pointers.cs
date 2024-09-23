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
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static unsafe partial class VkPointers
    {
        public static delegate* unmanaged<VkInstanceCreateInfo*, VkAllocationCallbacks*, VkInstance*, VkResult> _vkCreateInstance_fnptr = &vkCreateInstance_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateInstance_Lazy(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance)
        {
            _vkCreateInstance_fnptr = (delegate* unmanaged<VkInstanceCreateInfo*, VkAllocationCallbacks*, VkInstance*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateInstance");
            return _vkCreateInstance_fnptr(pCreateInfo, pAllocator, pInstance);
        }
        public static delegate* unmanaged<VkInstance, VkAllocationCallbacks*, void> _vkDestroyInstance_fnptr = &vkDestroyInstance_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyInstance_Lazy(VkInstance instance, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyInstance_fnptr = (delegate* unmanaged<VkInstance, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyInstance");
            _vkDestroyInstance_fnptr(instance, pAllocator);
        }
        public static delegate* unmanaged<VkInstance, uint*, VkPhysicalDevice*, VkResult> _vkEnumeratePhysicalDevices_fnptr = &vkEnumeratePhysicalDevices_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkEnumeratePhysicalDevices_Lazy(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices)
        {
            _vkEnumeratePhysicalDevices_fnptr = (delegate* unmanaged<VkInstance, uint*, VkPhysicalDevice*, VkResult>)VKLoader.GetInstanceProcAddress("vkEnumeratePhysicalDevices");
            return _vkEnumeratePhysicalDevices_fnptr(instance, pPhysicalDeviceCount, pPhysicalDevices);
        }
        public static delegate* unmanaged<VkDevice, byte*, IntPtr> _vkGetDeviceProcAddr_fnptr = &vkGetDeviceProcAddr_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr vkGetDeviceProcAddr_Lazy(VkDevice device, byte* pName)
        {
            _vkGetDeviceProcAddr_fnptr = (delegate* unmanaged<VkDevice, byte*, IntPtr>)VKLoader.GetInstanceProcAddress("vkGetDeviceProcAddr");
            return _vkGetDeviceProcAddr_fnptr(device, pName);
        }
        public static delegate* unmanaged<VkInstance, byte*, IntPtr> _vkGetInstanceProcAddr_fnptr = &vkGetInstanceProcAddr_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr vkGetInstanceProcAddr_Lazy(VkInstance instance, byte* pName)
        {
            _vkGetInstanceProcAddr_fnptr = (delegate* unmanaged<VkInstance, byte*, IntPtr>)VKLoader.GetInstanceProcAddress("vkGetInstanceProcAddr");
            return _vkGetInstanceProcAddr_fnptr(instance, pName);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties*, void> _vkGetPhysicalDeviceProperties_fnptr = &vkGetPhysicalDeviceProperties_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceProperties_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties)
        {
            _vkGetPhysicalDeviceProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceProperties");
            _vkGetPhysicalDeviceProperties_fnptr(physicalDevice, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties*, void> _vkGetPhysicalDeviceQueueFamilyProperties_fnptr = &vkGetPhysicalDeviceQueueFamilyProperties_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceQueueFamilyProperties_Lazy(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties)
        {
            _vkGetPhysicalDeviceQueueFamilyProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceQueueFamilyProperties");
            _vkGetPhysicalDeviceQueueFamilyProperties_fnptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties*, void> _vkGetPhysicalDeviceMemoryProperties_fnptr = &vkGetPhysicalDeviceMemoryProperties_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceMemoryProperties_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties)
        {
            _vkGetPhysicalDeviceMemoryProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceMemoryProperties");
            _vkGetPhysicalDeviceMemoryProperties_fnptr(physicalDevice, pMemoryProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceFeatures*, void> _vkGetPhysicalDeviceFeatures_fnptr = &vkGetPhysicalDeviceFeatures_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceFeatures_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures)
        {
            _vkGetPhysicalDeviceFeatures_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceFeatures*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceFeatures");
            _vkGetPhysicalDeviceFeatures_fnptr(physicalDevice, pFeatures);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkFormat, VkFormatProperties*, void> _vkGetPhysicalDeviceFormatProperties_fnptr = &vkGetPhysicalDeviceFormatProperties_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceFormatProperties_Lazy(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties)
        {
            _vkGetPhysicalDeviceFormatProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkFormat, VkFormatProperties*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceFormatProperties");
            _vkGetPhysicalDeviceFormatProperties_fnptr(physicalDevice, format, pFormatProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, VkImageFormatProperties*, VkResult> _vkGetPhysicalDeviceImageFormatProperties_fnptr = &vkGetPhysicalDeviceImageFormatProperties_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceImageFormatProperties_Lazy(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlagBits usage, VkImageCreateFlagBits flags, VkImageFormatProperties* pImageFormatProperties)
        {
            _vkGetPhysicalDeviceImageFormatProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, VkImageFormatProperties*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceImageFormatProperties");
            return _vkGetPhysicalDeviceImageFormatProperties_fnptr(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkDeviceCreateInfo*, VkAllocationCallbacks*, VkDevice*, VkResult> _vkCreateDevice_fnptr = &vkCreateDevice_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateDevice_Lazy(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice)
        {
            _vkCreateDevice_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDeviceCreateInfo*, VkAllocationCallbacks*, VkDevice*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateDevice");
            return _vkCreateDevice_fnptr(physicalDevice, pCreateInfo, pAllocator, pDevice);
        }
        public static delegate* unmanaged<VkDevice, VkAllocationCallbacks*, void> _vkDestroyDevice_fnptr = &vkDestroyDevice_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyDevice_Lazy(VkDevice device, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDevice_fnptr = (delegate* unmanaged<VkDevice, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyDevice");
            _vkDestroyDevice_fnptr(device, pAllocator);
        }
        public static delegate* unmanaged<uint*, VkResult> _vkEnumerateInstanceVersion_fnptr = &vkEnumerateInstanceVersion_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkEnumerateInstanceVersion_Lazy(uint* pApiVersion)
        {
            _vkEnumerateInstanceVersion_fnptr = (delegate* unmanaged<uint*, VkResult>)VKLoader.GetInstanceProcAddress("vkEnumerateInstanceVersion");
            return _vkEnumerateInstanceVersion_fnptr(pApiVersion);
        }
        public static delegate* unmanaged<uint*, VkLayerProperties*, VkResult> _vkEnumerateInstanceLayerProperties_fnptr = &vkEnumerateInstanceLayerProperties_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkEnumerateInstanceLayerProperties_Lazy(uint* pPropertyCount, VkLayerProperties* pProperties)
        {
            _vkEnumerateInstanceLayerProperties_fnptr = (delegate* unmanaged<uint*, VkLayerProperties*, VkResult>)VKLoader.GetInstanceProcAddress("vkEnumerateInstanceLayerProperties");
            return _vkEnumerateInstanceLayerProperties_fnptr(pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<byte*, uint*, VkExtensionProperties*, VkResult> _vkEnumerateInstanceExtensionProperties_fnptr = &vkEnumerateInstanceExtensionProperties_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkEnumerateInstanceExtensionProperties_Lazy(byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
        {
            _vkEnumerateInstanceExtensionProperties_fnptr = (delegate* unmanaged<byte*, uint*, VkExtensionProperties*, VkResult>)VKLoader.GetInstanceProcAddress("vkEnumerateInstanceExtensionProperties");
            return _vkEnumerateInstanceExtensionProperties_fnptr(pLayerName, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkLayerProperties*, VkResult> _vkEnumerateDeviceLayerProperties_fnptr = &vkEnumerateDeviceLayerProperties_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkEnumerateDeviceLayerProperties_Lazy(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties)
        {
            _vkEnumerateDeviceLayerProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkLayerProperties*, VkResult>)VKLoader.GetInstanceProcAddress("vkEnumerateDeviceLayerProperties");
            return _vkEnumerateDeviceLayerProperties_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, byte*, uint*, VkExtensionProperties*, VkResult> _vkEnumerateDeviceExtensionProperties_fnptr = &vkEnumerateDeviceExtensionProperties_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkEnumerateDeviceExtensionProperties_Lazy(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
        {
            _vkEnumerateDeviceExtensionProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, byte*, uint*, VkExtensionProperties*, VkResult>)VKLoader.GetInstanceProcAddress("vkEnumerateDeviceExtensionProperties");
            return _vkEnumerateDeviceExtensionProperties_fnptr(physicalDevice, pLayerName, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkDevice, uint, uint, VkQueue*, void> _vkGetDeviceQueue_fnptr = &vkGetDeviceQueue_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDeviceQueue_Lazy(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue)
        {
            _vkGetDeviceQueue_fnptr = (delegate* unmanaged<VkDevice, uint, uint, VkQueue*, void>)VKLoader.GetInstanceProcAddress("vkGetDeviceQueue");
            _vkGetDeviceQueue_fnptr(device, queueFamilyIndex, queueIndex, pQueue);
        }
        public static delegate* unmanaged<VkQueue, uint, VkSubmitInfo*, VkFence, VkResult> _vkQueueSubmit_fnptr = &vkQueueSubmit_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkQueueSubmit_Lazy(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence)
        {
            _vkQueueSubmit_fnptr = (delegate* unmanaged<VkQueue, uint, VkSubmitInfo*, VkFence, VkResult>)VKLoader.GetInstanceProcAddress("vkQueueSubmit");
            return _vkQueueSubmit_fnptr(queue, submitCount, pSubmits, fence);
        }
        public static delegate* unmanaged<VkQueue, VkResult> _vkQueueWaitIdle_fnptr = &vkQueueWaitIdle_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkQueueWaitIdle_Lazy(VkQueue queue)
        {
            _vkQueueWaitIdle_fnptr = (delegate* unmanaged<VkQueue, VkResult>)VKLoader.GetInstanceProcAddress("vkQueueWaitIdle");
            return _vkQueueWaitIdle_fnptr(queue);
        }
        public static delegate* unmanaged<VkDevice, VkResult> _vkDeviceWaitIdle_fnptr = &vkDeviceWaitIdle_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkDeviceWaitIdle_Lazy(VkDevice device)
        {
            _vkDeviceWaitIdle_fnptr = (delegate* unmanaged<VkDevice, VkResult>)VKLoader.GetInstanceProcAddress("vkDeviceWaitIdle");
            return _vkDeviceWaitIdle_fnptr(device);
        }
        public static delegate* unmanaged<VkDevice, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory*, VkResult> _vkAllocateMemory_fnptr = &vkAllocateMemory_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkAllocateMemory_Lazy(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory)
        {
            _vkAllocateMemory_fnptr = (delegate* unmanaged<VkDevice, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory*, VkResult>)VKLoader.GetInstanceProcAddress("vkAllocateMemory");
            return _vkAllocateMemory_fnptr(device, pAllocateInfo, pAllocator, pMemory);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void> _vkFreeMemory_fnptr = &vkFreeMemory_Lazy;
        [UnmanagedCallersOnly]
        private static void vkFreeMemory_Lazy(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator)
        {
            _vkFreeMemory_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkFreeMemory");
            _vkFreeMemory_fnptr(device, memory, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceMemory, ulong, ulong, VkMemoryMapFlagBits, void**, VkResult> _vkMapMemory_fnptr = &vkMapMemory_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkMapMemory_Lazy(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, VkMemoryMapFlagBits flags, void** ppData)
        {
            _vkMapMemory_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemory, ulong, ulong, VkMemoryMapFlagBits, void**, VkResult>)VKLoader.GetInstanceProcAddress("vkMapMemory");
            return _vkMapMemory_fnptr(device, memory, offset, size, flags, ppData);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceMemory, void> _vkUnmapMemory_fnptr = &vkUnmapMemory_Lazy;
        [UnmanagedCallersOnly]
        private static void vkUnmapMemory_Lazy(VkDevice device, VkDeviceMemory memory)
        {
            _vkUnmapMemory_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemory, void>)VKLoader.GetInstanceProcAddress("vkUnmapMemory");
            _vkUnmapMemory_fnptr(device, memory);
        }
        public static delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult> _vkFlushMappedMemoryRanges_fnptr = &vkFlushMappedMemoryRanges_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkFlushMappedMemoryRanges_Lazy(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
        {
            _vkFlushMappedMemoryRanges_fnptr = (delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult>)VKLoader.GetInstanceProcAddress("vkFlushMappedMemoryRanges");
            return _vkFlushMappedMemoryRanges_fnptr(device, memoryRangeCount, pMemoryRanges);
        }
        public static delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult> _vkInvalidateMappedMemoryRanges_fnptr = &vkInvalidateMappedMemoryRanges_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkInvalidateMappedMemoryRanges_Lazy(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
        {
            _vkInvalidateMappedMemoryRanges_fnptr = (delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult>)VKLoader.GetInstanceProcAddress("vkInvalidateMappedMemoryRanges");
            return _vkInvalidateMappedMemoryRanges_fnptr(device, memoryRangeCount, pMemoryRanges);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceMemory, ulong*, void> _vkGetDeviceMemoryCommitment_fnptr = &vkGetDeviceMemoryCommitment_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDeviceMemoryCommitment_Lazy(VkDevice device, VkDeviceMemory memory, ulong* pCommittedMemoryInBytes)
        {
            _vkGetDeviceMemoryCommitment_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemory, ulong*, void>)VKLoader.GetInstanceProcAddress("vkGetDeviceMemoryCommitment");
            _vkGetDeviceMemoryCommitment_fnptr(device, memory, pCommittedMemoryInBytes);
        }
        public static delegate* unmanaged<VkDevice, VkBuffer, VkMemoryRequirements*, void> _vkGetBufferMemoryRequirements_fnptr = &vkGetBufferMemoryRequirements_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetBufferMemoryRequirements_Lazy(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements)
        {
            _vkGetBufferMemoryRequirements_fnptr = (delegate* unmanaged<VkDevice, VkBuffer, VkMemoryRequirements*, void>)VKLoader.GetInstanceProcAddress("vkGetBufferMemoryRequirements");
            _vkGetBufferMemoryRequirements_fnptr(device, buffer, pMemoryRequirements);
        }
        public static delegate* unmanaged<VkDevice, VkBuffer, VkDeviceMemory, ulong, VkResult> _vkBindBufferMemory_fnptr = &vkBindBufferMemory_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkBindBufferMemory_Lazy(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset)
        {
            _vkBindBufferMemory_fnptr = (delegate* unmanaged<VkDevice, VkBuffer, VkDeviceMemory, ulong, VkResult>)VKLoader.GetInstanceProcAddress("vkBindBufferMemory");
            return _vkBindBufferMemory_fnptr(device, buffer, memory, memoryOffset);
        }
        public static delegate* unmanaged<VkDevice, VkImage, VkMemoryRequirements*, void> _vkGetImageMemoryRequirements_fnptr = &vkGetImageMemoryRequirements_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetImageMemoryRequirements_Lazy(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements)
        {
            _vkGetImageMemoryRequirements_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkMemoryRequirements*, void>)VKLoader.GetInstanceProcAddress("vkGetImageMemoryRequirements");
            _vkGetImageMemoryRequirements_fnptr(device, image, pMemoryRequirements);
        }
        public static delegate* unmanaged<VkDevice, VkImage, VkDeviceMemory, ulong, VkResult> _vkBindImageMemory_fnptr = &vkBindImageMemory_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkBindImageMemory_Lazy(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset)
        {
            _vkBindImageMemory_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkDeviceMemory, ulong, VkResult>)VKLoader.GetInstanceProcAddress("vkBindImageMemory");
            return _vkBindImageMemory_fnptr(device, image, memory, memoryOffset);
        }
        public static delegate* unmanaged<VkDevice, VkImage, uint*, VkSparseImageMemoryRequirements*, void> _vkGetImageSparseMemoryRequirements_fnptr = &vkGetImageSparseMemoryRequirements_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetImageSparseMemoryRequirements_Lazy(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements)
        {
            _vkGetImageSparseMemoryRequirements_fnptr = (delegate* unmanaged<VkDevice, VkImage, uint*, VkSparseImageMemoryRequirements*, void>)VKLoader.GetInstanceProcAddress("vkGetImageSparseMemoryRequirements");
            _vkGetImageSparseMemoryRequirements_fnptr(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlagBits, VkImageUsageFlagBits, VkImageTiling, uint*, VkSparseImageFormatProperties*, void> _vkGetPhysicalDeviceSparseImageFormatProperties_fnptr = &vkGetPhysicalDeviceSparseImageFormatProperties_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceSparseImageFormatProperties_Lazy(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlagBits usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties)
        {
            _vkGetPhysicalDeviceSparseImageFormatProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlagBits, VkImageUsageFlagBits, VkImageTiling, uint*, VkSparseImageFormatProperties*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSparseImageFormatProperties");
            _vkGetPhysicalDeviceSparseImageFormatProperties_fnptr(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult> _vkQueueBindSparse_fnptr = &vkQueueBindSparse_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkQueueBindSparse_Lazy(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence)
        {
            _vkQueueBindSparse_fnptr = (delegate* unmanaged<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult>)VKLoader.GetInstanceProcAddress("vkQueueBindSparse");
            return _vkQueueBindSparse_fnptr(queue, bindInfoCount, pBindInfo, fence);
        }
        public static delegate* unmanaged<VkDevice, VkFenceCreateInfo*, VkAllocationCallbacks*, VkFence*, VkResult> _vkCreateFence_fnptr = &vkCreateFence_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateFence_Lazy(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            _vkCreateFence_fnptr = (delegate* unmanaged<VkDevice, VkFenceCreateInfo*, VkAllocationCallbacks*, VkFence*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateFence");
            return _vkCreateFence_fnptr(device, pCreateInfo, pAllocator, pFence);
        }
        public static delegate* unmanaged<VkDevice, VkFence, VkAllocationCallbacks*, void> _vkDestroyFence_fnptr = &vkDestroyFence_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyFence_Lazy(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyFence_fnptr = (delegate* unmanaged<VkDevice, VkFence, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyFence");
            _vkDestroyFence_fnptr(device, fence, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, uint, VkFence*, VkResult> _vkResetFences_fnptr = &vkResetFences_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkResetFences_Lazy(VkDevice device, uint fenceCount, VkFence* pFences)
        {
            _vkResetFences_fnptr = (delegate* unmanaged<VkDevice, uint, VkFence*, VkResult>)VKLoader.GetInstanceProcAddress("vkResetFences");
            return _vkResetFences_fnptr(device, fenceCount, pFences);
        }
        public static delegate* unmanaged<VkDevice, VkFence, VkResult> _vkGetFenceStatus_fnptr = &vkGetFenceStatus_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetFenceStatus_Lazy(VkDevice device, VkFence fence)
        {
            _vkGetFenceStatus_fnptr = (delegate* unmanaged<VkDevice, VkFence, VkResult>)VKLoader.GetInstanceProcAddress("vkGetFenceStatus");
            return _vkGetFenceStatus_fnptr(device, fence);
        }
        public static delegate* unmanaged<VkDevice, uint, VkFence*, int, ulong, VkResult> _vkWaitForFences_fnptr = &vkWaitForFences_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkWaitForFences_Lazy(VkDevice device, uint fenceCount, VkFence* pFences, int waitAll, ulong timeout)
        {
            _vkWaitForFences_fnptr = (delegate* unmanaged<VkDevice, uint, VkFence*, int, ulong, VkResult>)VKLoader.GetInstanceProcAddress("vkWaitForFences");
            return _vkWaitForFences_fnptr(device, fenceCount, pFences, waitAll, timeout);
        }
        public static delegate* unmanaged<VkDevice, VkSemaphoreCreateInfo*, VkAllocationCallbacks*, VkSemaphore*, VkResult> _vkCreateSemaphore_fnptr = &vkCreateSemaphore_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateSemaphore_Lazy(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore)
        {
            _vkCreateSemaphore_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreCreateInfo*, VkAllocationCallbacks*, VkSemaphore*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateSemaphore");
            return _vkCreateSemaphore_fnptr(device, pCreateInfo, pAllocator, pSemaphore);
        }
        public static delegate* unmanaged<VkDevice, VkSemaphore, VkAllocationCallbacks*, void> _vkDestroySemaphore_fnptr = &vkDestroySemaphore_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroySemaphore_Lazy(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySemaphore_fnptr = (delegate* unmanaged<VkDevice, VkSemaphore, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroySemaphore");
            _vkDestroySemaphore_fnptr(device, semaphore, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkEventCreateInfo*, VkAllocationCallbacks*, VkEvent*, VkResult> _vkCreateEvent_fnptr = &vkCreateEvent_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateEvent_Lazy(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent)
        {
            _vkCreateEvent_fnptr = (delegate* unmanaged<VkDevice, VkEventCreateInfo*, VkAllocationCallbacks*, VkEvent*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateEvent");
            return _vkCreateEvent_fnptr(device, pCreateInfo, pAllocator, pEvent);
        }
        public static delegate* unmanaged<VkDevice, VkEvent, VkAllocationCallbacks*, void> _vkDestroyEvent_fnptr = &vkDestroyEvent_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyEvent_Lazy(VkDevice device, VkEvent @event, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyEvent_fnptr = (delegate* unmanaged<VkDevice, VkEvent, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyEvent");
            _vkDestroyEvent_fnptr(device, @event, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkEvent, VkResult> _vkGetEventStatus_fnptr = &vkGetEventStatus_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetEventStatus_Lazy(VkDevice device, VkEvent @event)
        {
            _vkGetEventStatus_fnptr = (delegate* unmanaged<VkDevice, VkEvent, VkResult>)VKLoader.GetInstanceProcAddress("vkGetEventStatus");
            return _vkGetEventStatus_fnptr(device, @event);
        }
        public static delegate* unmanaged<VkDevice, VkEvent, VkResult> _vkSetEvent_fnptr = &vkSetEvent_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkSetEvent_Lazy(VkDevice device, VkEvent @event)
        {
            _vkSetEvent_fnptr = (delegate* unmanaged<VkDevice, VkEvent, VkResult>)VKLoader.GetInstanceProcAddress("vkSetEvent");
            return _vkSetEvent_fnptr(device, @event);
        }
        public static delegate* unmanaged<VkDevice, VkEvent, VkResult> _vkResetEvent_fnptr = &vkResetEvent_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkResetEvent_Lazy(VkDevice device, VkEvent @event)
        {
            _vkResetEvent_fnptr = (delegate* unmanaged<VkDevice, VkEvent, VkResult>)VKLoader.GetInstanceProcAddress("vkResetEvent");
            return _vkResetEvent_fnptr(device, @event);
        }
        public static delegate* unmanaged<VkDevice, VkQueryPoolCreateInfo*, VkAllocationCallbacks*, VkQueryPool*, VkResult> _vkCreateQueryPool_fnptr = &vkCreateQueryPool_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateQueryPool_Lazy(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool)
        {
            _vkCreateQueryPool_fnptr = (delegate* unmanaged<VkDevice, VkQueryPoolCreateInfo*, VkAllocationCallbacks*, VkQueryPool*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateQueryPool");
            return _vkCreateQueryPool_fnptr(device, pCreateInfo, pAllocator, pQueryPool);
        }
        public static delegate* unmanaged<VkDevice, VkQueryPool, VkAllocationCallbacks*, void> _vkDestroyQueryPool_fnptr = &vkDestroyQueryPool_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyQueryPool_Lazy(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyQueryPool_fnptr = (delegate* unmanaged<VkDevice, VkQueryPool, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyQueryPool");
            _vkDestroyQueryPool_fnptr(device, queryPool, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, nuint, void*, ulong, VkQueryResultFlagBits, VkResult> _vkGetQueryPoolResults_fnptr = &vkGetQueryPoolResults_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetQueryPoolResults_Lazy(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* pData, ulong stride, VkQueryResultFlagBits flags)
        {
            _vkGetQueryPoolResults_fnptr = (delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, nuint, void*, ulong, VkQueryResultFlagBits, VkResult>)VKLoader.GetInstanceProcAddress("vkGetQueryPoolResults");
            return _vkGetQueryPoolResults_fnptr(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);
        }
        public static delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, void> _vkResetQueryPool_fnptr = &vkResetQueryPool_Lazy;
        [UnmanagedCallersOnly]
        private static void vkResetQueryPool_Lazy(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            _vkResetQueryPool_fnptr = (delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkResetQueryPool");
            _vkResetQueryPool_fnptr(device, queryPool, firstQuery, queryCount);
        }
        public static delegate* unmanaged<VkDevice, VkBufferCreateInfo*, VkAllocationCallbacks*, VkBuffer*, VkResult> _vkCreateBuffer_fnptr = &vkCreateBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateBuffer_Lazy(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer)
        {
            _vkCreateBuffer_fnptr = (delegate* unmanaged<VkDevice, VkBufferCreateInfo*, VkAllocationCallbacks*, VkBuffer*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateBuffer");
            return _vkCreateBuffer_fnptr(device, pCreateInfo, pAllocator, pBuffer);
        }
        public static delegate* unmanaged<VkDevice, VkBuffer, VkAllocationCallbacks*, void> _vkDestroyBuffer_fnptr = &vkDestroyBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyBuffer_Lazy(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyBuffer_fnptr = (delegate* unmanaged<VkDevice, VkBuffer, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyBuffer");
            _vkDestroyBuffer_fnptr(device, buffer, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkBufferViewCreateInfo*, VkAllocationCallbacks*, VkBufferView*, VkResult> _vkCreateBufferView_fnptr = &vkCreateBufferView_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateBufferView_Lazy(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView)
        {
            _vkCreateBufferView_fnptr = (delegate* unmanaged<VkDevice, VkBufferViewCreateInfo*, VkAllocationCallbacks*, VkBufferView*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateBufferView");
            return _vkCreateBufferView_fnptr(device, pCreateInfo, pAllocator, pView);
        }
        public static delegate* unmanaged<VkDevice, VkBufferView, VkAllocationCallbacks*, void> _vkDestroyBufferView_fnptr = &vkDestroyBufferView_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyBufferView_Lazy(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyBufferView_fnptr = (delegate* unmanaged<VkDevice, VkBufferView, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyBufferView");
            _vkDestroyBufferView_fnptr(device, bufferView, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage*, VkResult> _vkCreateImage_fnptr = &vkCreateImage_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateImage_Lazy(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage)
        {
            _vkCreateImage_fnptr = (delegate* unmanaged<VkDevice, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateImage");
            return _vkCreateImage_fnptr(device, pCreateInfo, pAllocator, pImage);
        }
        public static delegate* unmanaged<VkDevice, VkImage, VkAllocationCallbacks*, void> _vkDestroyImage_fnptr = &vkDestroyImage_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyImage_Lazy(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyImage_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyImage");
            _vkDestroyImage_fnptr(device, image, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkImage, VkImageSubresource*, VkSubresourceLayout*, void> _vkGetImageSubresourceLayout_fnptr = &vkGetImageSubresourceLayout_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetImageSubresourceLayout_Lazy(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout)
        {
            _vkGetImageSubresourceLayout_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkImageSubresource*, VkSubresourceLayout*, void>)VKLoader.GetInstanceProcAddress("vkGetImageSubresourceLayout");
            _vkGetImageSubresourceLayout_fnptr(device, image, pSubresource, pLayout);
        }
        public static delegate* unmanaged<VkDevice, VkImageViewCreateInfo*, VkAllocationCallbacks*, VkImageView*, VkResult> _vkCreateImageView_fnptr = &vkCreateImageView_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateImageView_Lazy(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView)
        {
            _vkCreateImageView_fnptr = (delegate* unmanaged<VkDevice, VkImageViewCreateInfo*, VkAllocationCallbacks*, VkImageView*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateImageView");
            return _vkCreateImageView_fnptr(device, pCreateInfo, pAllocator, pView);
        }
        public static delegate* unmanaged<VkDevice, VkImageView, VkAllocationCallbacks*, void> _vkDestroyImageView_fnptr = &vkDestroyImageView_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyImageView_Lazy(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyImageView_fnptr = (delegate* unmanaged<VkDevice, VkImageView, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyImageView");
            _vkDestroyImageView_fnptr(device, imageView, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkShaderModuleCreateInfo*, VkAllocationCallbacks*, VkShaderModule*, VkResult> _vkCreateShaderModule_fnptr = &vkCreateShaderModule_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateShaderModule_Lazy(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule)
        {
            _vkCreateShaderModule_fnptr = (delegate* unmanaged<VkDevice, VkShaderModuleCreateInfo*, VkAllocationCallbacks*, VkShaderModule*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateShaderModule");
            return _vkCreateShaderModule_fnptr(device, pCreateInfo, pAllocator, pShaderModule);
        }
        public static delegate* unmanaged<VkDevice, VkShaderModule, VkAllocationCallbacks*, void> _vkDestroyShaderModule_fnptr = &vkDestroyShaderModule_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyShaderModule_Lazy(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyShaderModule_fnptr = (delegate* unmanaged<VkDevice, VkShaderModule, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyShaderModule");
            _vkDestroyShaderModule_fnptr(device, shaderModule, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineCacheCreateInfo*, VkAllocationCallbacks*, VkPipelineCache*, VkResult> _vkCreatePipelineCache_fnptr = &vkCreatePipelineCache_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreatePipelineCache_Lazy(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache)
        {
            _vkCreatePipelineCache_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCacheCreateInfo*, VkAllocationCallbacks*, VkPipelineCache*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreatePipelineCache");
            return _vkCreatePipelineCache_fnptr(device, pCreateInfo, pAllocator, pPipelineCache);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void> _vkDestroyPipelineCache_fnptr = &vkDestroyPipelineCache_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyPipelineCache_Lazy(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyPipelineCache_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyPipelineCache");
            _vkDestroyPipelineCache_fnptr(device, pipelineCache, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineCache, nuint*, void*, VkResult> _vkGetPipelineCacheData_fnptr = &vkGetPipelineCacheData_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPipelineCacheData_Lazy(VkDevice device, VkPipelineCache pipelineCache, nuint* pDataSize, void* pData)
        {
            _vkGetPipelineCacheData_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, nuint*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPipelineCacheData");
            return _vkGetPipelineCacheData_fnptr(device, pipelineCache, pDataSize, pData);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkPipelineCache*, VkResult> _vkMergePipelineCaches_fnptr = &vkMergePipelineCaches_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkMergePipelineCaches_Lazy(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches)
        {
            _vkMergePipelineCaches_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkPipelineCache*, VkResult>)VKLoader.GetInstanceProcAddress("vkMergePipelineCaches");
            return _vkMergePipelineCaches_fnptr(device, dstCache, srcCacheCount, pSrcCaches);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineBinaryCreateInfoKHR*, VkAllocationCallbacks*, VkPipelineBinaryHandlesInfoKHR*, VkResult> _vkCreatePipelineBinariesKHR_fnptr = &vkCreatePipelineBinariesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreatePipelineBinariesKHR_Lazy(VkDevice device, VkPipelineBinaryCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineBinaryHandlesInfoKHR* pBinaries)
        {
            _vkCreatePipelineBinariesKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineBinaryCreateInfoKHR*, VkAllocationCallbacks*, VkPipelineBinaryHandlesInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreatePipelineBinariesKHR");
            return _vkCreatePipelineBinariesKHR_fnptr(device, pCreateInfo, pAllocator, pBinaries);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineBinaryKHR, VkAllocationCallbacks*, void> _vkDestroyPipelineBinaryKHR_fnptr = &vkDestroyPipelineBinaryKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyPipelineBinaryKHR_Lazy(VkDevice device, VkPipelineBinaryKHR pipelineBinary, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyPipelineBinaryKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineBinaryKHR, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyPipelineBinaryKHR");
            _vkDestroyPipelineBinaryKHR_fnptr(device, pipelineBinary, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineCreateInfoKHR*, VkPipelineBinaryKeyKHR*, VkResult> _vkGetPipelineKeyKHR_fnptr = &vkGetPipelineKeyKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPipelineKeyKHR_Lazy(VkDevice device, VkPipelineCreateInfoKHR* pPipelineCreateInfo, VkPipelineBinaryKeyKHR* pPipelineKey)
        {
            _vkGetPipelineKeyKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCreateInfoKHR*, VkPipelineBinaryKeyKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPipelineKeyKHR");
            return _vkGetPipelineKeyKHR_fnptr(device, pPipelineCreateInfo, pPipelineKey);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineBinaryDataInfoKHR*, VkPipelineBinaryKeyKHR*, nuint*, void*, VkResult> _vkGetPipelineBinaryDataKHR_fnptr = &vkGetPipelineBinaryDataKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPipelineBinaryDataKHR_Lazy(VkDevice device, VkPipelineBinaryDataInfoKHR* pInfo, VkPipelineBinaryKeyKHR* pPipelineBinaryKey, nuint* pPipelineBinaryDataSize, void* pPipelineBinaryData)
        {
            _vkGetPipelineBinaryDataKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineBinaryDataInfoKHR*, VkPipelineBinaryKeyKHR*, nuint*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPipelineBinaryDataKHR");
            return _vkGetPipelineBinaryDataKHR_fnptr(device, pInfo, pPipelineBinaryKey, pPipelineBinaryDataSize, pPipelineBinaryData);
        }
        public static delegate* unmanaged<VkDevice, VkReleaseCapturedPipelineDataInfoKHR*, VkAllocationCallbacks*, VkResult> _vkReleaseCapturedPipelineDataKHR_fnptr = &vkReleaseCapturedPipelineDataKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkReleaseCapturedPipelineDataKHR_Lazy(VkDevice device, VkReleaseCapturedPipelineDataInfoKHR* pInfo, VkAllocationCallbacks* pAllocator)
        {
            _vkReleaseCapturedPipelineDataKHR_fnptr = (delegate* unmanaged<VkDevice, VkReleaseCapturedPipelineDataInfoKHR*, VkAllocationCallbacks*, VkResult>)VKLoader.GetInstanceProcAddress("vkReleaseCapturedPipelineDataKHR");
            return _vkReleaseCapturedPipelineDataKHR_fnptr(device, pInfo, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkGraphicsPipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateGraphicsPipelines_fnptr = &vkCreateGraphicsPipelines_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateGraphicsPipelines_Lazy(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            _vkCreateGraphicsPipelines_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkGraphicsPipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateGraphicsPipelines");
            return _vkCreateGraphicsPipelines_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateComputePipelines_fnptr = &vkCreateComputePipelines_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateComputePipelines_Lazy(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            _vkCreateComputePipelines_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateComputePipelines");
            return _vkCreateComputePipelines_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static delegate* unmanaged<VkDevice, VkRenderPass, VkExtent2D*, VkResult> _vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_fnptr = &vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_Lazy(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize)
        {
            _vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_fnptr = (delegate* unmanaged<VkDevice, VkRenderPass, VkExtent2D*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI");
            return _vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_fnptr(device, renderpass, pMaxWorkgroupSize);
        }
        public static delegate* unmanaged<VkDevice, VkPipeline, VkAllocationCallbacks*, void> _vkDestroyPipeline_fnptr = &vkDestroyPipeline_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyPipeline_Lazy(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyPipeline_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyPipeline");
            _vkDestroyPipeline_fnptr(device, pipeline, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineLayoutCreateInfo*, VkAllocationCallbacks*, VkPipelineLayout*, VkResult> _vkCreatePipelineLayout_fnptr = &vkCreatePipelineLayout_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreatePipelineLayout_Lazy(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout)
        {
            _vkCreatePipelineLayout_fnptr = (delegate* unmanaged<VkDevice, VkPipelineLayoutCreateInfo*, VkAllocationCallbacks*, VkPipelineLayout*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreatePipelineLayout");
            return _vkCreatePipelineLayout_fnptr(device, pCreateInfo, pAllocator, pPipelineLayout);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void> _vkDestroyPipelineLayout_fnptr = &vkDestroyPipelineLayout_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyPipelineLayout_Lazy(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyPipelineLayout_fnptr = (delegate* unmanaged<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyPipelineLayout");
            _vkDestroyPipelineLayout_fnptr(device, pipelineLayout, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkSamplerCreateInfo*, VkAllocationCallbacks*, VkSampler*, VkResult> _vkCreateSampler_fnptr = &vkCreateSampler_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateSampler_Lazy(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler)
        {
            _vkCreateSampler_fnptr = (delegate* unmanaged<VkDevice, VkSamplerCreateInfo*, VkAllocationCallbacks*, VkSampler*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateSampler");
            return _vkCreateSampler_fnptr(device, pCreateInfo, pAllocator, pSampler);
        }
        public static delegate* unmanaged<VkDevice, VkSampler, VkAllocationCallbacks*, void> _vkDestroySampler_fnptr = &vkDestroySampler_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroySampler_Lazy(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySampler_fnptr = (delegate* unmanaged<VkDevice, VkSampler, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroySampler");
            _vkDestroySampler_fnptr(device, sampler, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkAllocationCallbacks*, VkDescriptorSetLayout*, VkResult> _vkCreateDescriptorSetLayout_fnptr = &vkCreateDescriptorSetLayout_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateDescriptorSetLayout_Lazy(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout)
        {
            _vkCreateDescriptorSetLayout_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkAllocationCallbacks*, VkDescriptorSetLayout*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateDescriptorSetLayout");
            return _vkCreateDescriptorSetLayout_fnptr(device, pCreateInfo, pAllocator, pSetLayout);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void> _vkDestroyDescriptorSetLayout_fnptr = &vkDestroyDescriptorSetLayout_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyDescriptorSetLayout_Lazy(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDescriptorSetLayout_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyDescriptorSetLayout");
            _vkDestroyDescriptorSetLayout_fnptr(device, descriptorSetLayout, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorPoolCreateInfo*, VkAllocationCallbacks*, VkDescriptorPool*, VkResult> _vkCreateDescriptorPool_fnptr = &vkCreateDescriptorPool_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateDescriptorPool_Lazy(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool)
        {
            _vkCreateDescriptorPool_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorPoolCreateInfo*, VkAllocationCallbacks*, VkDescriptorPool*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateDescriptorPool");
            return _vkCreateDescriptorPool_fnptr(device, pCreateInfo, pAllocator, pDescriptorPool);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void> _vkDestroyDescriptorPool_fnptr = &vkDestroyDescriptorPool_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyDescriptorPool_Lazy(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDescriptorPool_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyDescriptorPool");
            _vkDestroyDescriptorPool_fnptr(device, descriptorPool, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorPool, VkDescriptorPoolResetFlags, VkResult> _vkResetDescriptorPool_fnptr = &vkResetDescriptorPool_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkResetDescriptorPool_Lazy(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags)
        {
            _vkResetDescriptorPool_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorPool, VkDescriptorPoolResetFlags, VkResult>)VKLoader.GetInstanceProcAddress("vkResetDescriptorPool");
            return _vkResetDescriptorPool_fnptr(device, descriptorPool, flags);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorSetAllocateInfo*, VkDescriptorSet*, VkResult> _vkAllocateDescriptorSets_fnptr = &vkAllocateDescriptorSets_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkAllocateDescriptorSets_Lazy(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets)
        {
            _vkAllocateDescriptorSets_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetAllocateInfo*, VkDescriptorSet*, VkResult>)VKLoader.GetInstanceProcAddress("vkAllocateDescriptorSets");
            return _vkAllocateDescriptorSets_fnptr(device, pAllocateInfo, pDescriptorSets);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorPool, uint, VkDescriptorSet*, VkResult> _vkFreeDescriptorSets_fnptr = &vkFreeDescriptorSets_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkFreeDescriptorSets_Lazy(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets)
        {
            _vkFreeDescriptorSets_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorPool, uint, VkDescriptorSet*, VkResult>)VKLoader.GetInstanceProcAddress("vkFreeDescriptorSets");
            return _vkFreeDescriptorSets_fnptr(device, descriptorPool, descriptorSetCount, pDescriptorSets);
        }
        public static delegate* unmanaged<VkDevice, uint, VkWriteDescriptorSet*, uint, VkCopyDescriptorSet*, void> _vkUpdateDescriptorSets_fnptr = &vkUpdateDescriptorSets_Lazy;
        [UnmanagedCallersOnly]
        private static void vkUpdateDescriptorSets_Lazy(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies)
        {
            _vkUpdateDescriptorSets_fnptr = (delegate* unmanaged<VkDevice, uint, VkWriteDescriptorSet*, uint, VkCopyDescriptorSet*, void>)VKLoader.GetInstanceProcAddress("vkUpdateDescriptorSets");
            _vkUpdateDescriptorSets_fnptr(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);
        }
        public static delegate* unmanaged<VkDevice, VkFramebufferCreateInfo*, VkAllocationCallbacks*, VkFramebuffer*, VkResult> _vkCreateFramebuffer_fnptr = &vkCreateFramebuffer_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateFramebuffer_Lazy(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer)
        {
            _vkCreateFramebuffer_fnptr = (delegate* unmanaged<VkDevice, VkFramebufferCreateInfo*, VkAllocationCallbacks*, VkFramebuffer*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateFramebuffer");
            return _vkCreateFramebuffer_fnptr(device, pCreateInfo, pAllocator, pFramebuffer);
        }
        public static delegate* unmanaged<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void> _vkDestroyFramebuffer_fnptr = &vkDestroyFramebuffer_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyFramebuffer_Lazy(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyFramebuffer_fnptr = (delegate* unmanaged<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyFramebuffer");
            _vkDestroyFramebuffer_fnptr(device, framebuffer, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkRenderPassCreateInfo*, VkAllocationCallbacks*, VkRenderPass*, VkResult> _vkCreateRenderPass_fnptr = &vkCreateRenderPass_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateRenderPass_Lazy(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
        {
            _vkCreateRenderPass_fnptr = (delegate* unmanaged<VkDevice, VkRenderPassCreateInfo*, VkAllocationCallbacks*, VkRenderPass*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateRenderPass");
            return _vkCreateRenderPass_fnptr(device, pCreateInfo, pAllocator, pRenderPass);
        }
        public static delegate* unmanaged<VkDevice, VkRenderPass, VkAllocationCallbacks*, void> _vkDestroyRenderPass_fnptr = &vkDestroyRenderPass_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyRenderPass_Lazy(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyRenderPass_fnptr = (delegate* unmanaged<VkDevice, VkRenderPass, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyRenderPass");
            _vkDestroyRenderPass_fnptr(device, renderPass, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkRenderPass, VkExtent2D*, void> _vkGetRenderAreaGranularity_fnptr = &vkGetRenderAreaGranularity_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetRenderAreaGranularity_Lazy(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity)
        {
            _vkGetRenderAreaGranularity_fnptr = (delegate* unmanaged<VkDevice, VkRenderPass, VkExtent2D*, void>)VKLoader.GetInstanceProcAddress("vkGetRenderAreaGranularity");
            _vkGetRenderAreaGranularity_fnptr(device, renderPass, pGranularity);
        }
        public static delegate* unmanaged<VkDevice, VkRenderingAreaInfoKHR*, VkExtent2D*, void> _vkGetRenderingAreaGranularityKHR_fnptr = &vkGetRenderingAreaGranularityKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetRenderingAreaGranularityKHR_Lazy(VkDevice device, VkRenderingAreaInfoKHR* pRenderingAreaInfo, VkExtent2D* pGranularity)
        {
            _vkGetRenderingAreaGranularityKHR_fnptr = (delegate* unmanaged<VkDevice, VkRenderingAreaInfoKHR*, VkExtent2D*, void>)VKLoader.GetInstanceProcAddress("vkGetRenderingAreaGranularityKHR");
            _vkGetRenderingAreaGranularityKHR_fnptr(device, pRenderingAreaInfo, pGranularity);
        }
        public static delegate* unmanaged<VkDevice, VkCommandPoolCreateInfo*, VkAllocationCallbacks*, VkCommandPool*, VkResult> _vkCreateCommandPool_fnptr = &vkCreateCommandPool_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateCommandPool_Lazy(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool)
        {
            _vkCreateCommandPool_fnptr = (delegate* unmanaged<VkDevice, VkCommandPoolCreateInfo*, VkAllocationCallbacks*, VkCommandPool*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateCommandPool");
            return _vkCreateCommandPool_fnptr(device, pCreateInfo, pAllocator, pCommandPool);
        }
        public static delegate* unmanaged<VkDevice, VkCommandPool, VkAllocationCallbacks*, void> _vkDestroyCommandPool_fnptr = &vkDestroyCommandPool_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyCommandPool_Lazy(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyCommandPool_fnptr = (delegate* unmanaged<VkDevice, VkCommandPool, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyCommandPool");
            _vkDestroyCommandPool_fnptr(device, commandPool, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolResetFlagBits, VkResult> _vkResetCommandPool_fnptr = &vkResetCommandPool_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkResetCommandPool_Lazy(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlagBits flags)
        {
            _vkResetCommandPool_fnptr = (delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolResetFlagBits, VkResult>)VKLoader.GetInstanceProcAddress("vkResetCommandPool");
            return _vkResetCommandPool_fnptr(device, commandPool, flags);
        }
        public static delegate* unmanaged<VkDevice, VkCommandBufferAllocateInfo*, VkCommandBuffer*, VkResult> _vkAllocateCommandBuffers_fnptr = &vkAllocateCommandBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkAllocateCommandBuffers_Lazy(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers)
        {
            _vkAllocateCommandBuffers_fnptr = (delegate* unmanaged<VkDevice, VkCommandBufferAllocateInfo*, VkCommandBuffer*, VkResult>)VKLoader.GetInstanceProcAddress("vkAllocateCommandBuffers");
            return _vkAllocateCommandBuffers_fnptr(device, pAllocateInfo, pCommandBuffers);
        }
        public static delegate* unmanaged<VkDevice, VkCommandPool, uint, VkCommandBuffer*, void> _vkFreeCommandBuffers_fnptr = &vkFreeCommandBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static void vkFreeCommandBuffers_Lazy(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
        {
            _vkFreeCommandBuffers_fnptr = (delegate* unmanaged<VkDevice, VkCommandPool, uint, VkCommandBuffer*, void>)VKLoader.GetInstanceProcAddress("vkFreeCommandBuffers");
            _vkFreeCommandBuffers_fnptr(device, commandPool, commandBufferCount, pCommandBuffers);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCommandBufferBeginInfo*, VkResult> _vkBeginCommandBuffer_fnptr = &vkBeginCommandBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkBeginCommandBuffer_Lazy(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo)
        {
            _vkBeginCommandBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCommandBufferBeginInfo*, VkResult>)VKLoader.GetInstanceProcAddress("vkBeginCommandBuffer");
            return _vkBeginCommandBuffer_fnptr(commandBuffer, pBeginInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkResult> _vkEndCommandBuffer_fnptr = &vkEndCommandBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkEndCommandBuffer_Lazy(VkCommandBuffer commandBuffer)
        {
            _vkEndCommandBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkResult>)VKLoader.GetInstanceProcAddress("vkEndCommandBuffer");
            return _vkEndCommandBuffer_fnptr(commandBuffer);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCommandBufferResetFlagBits, VkResult> _vkResetCommandBuffer_fnptr = &vkResetCommandBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkResetCommandBuffer_Lazy(VkCommandBuffer commandBuffer, VkCommandBufferResetFlagBits flags)
        {
            _vkResetCommandBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCommandBufferResetFlagBits, VkResult>)VKLoader.GetInstanceProcAddress("vkResetCommandBuffer");
            return _vkResetCommandBuffer_fnptr(commandBuffer, flags);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> _vkCmdBindPipeline_fnptr = &vkCmdBindPipeline_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindPipeline_Lazy(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
        {
            _vkCmdBindPipeline_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void>)VKLoader.GetInstanceProcAddress("vkCmdBindPipeline");
            _vkCmdBindPipeline_fnptr(commandBuffer, pipelineBindPoint, pipeline);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkImageAspectFlagBits, void> _vkCmdSetAttachmentFeedbackLoopEnableEXT_fnptr = &vkCmdSetAttachmentFeedbackLoopEnableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetAttachmentFeedbackLoopEnableEXT_Lazy(VkCommandBuffer commandBuffer, VkImageAspectFlagBits aspectMask)
        {
            _vkCmdSetAttachmentFeedbackLoopEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImageAspectFlagBits, void>)VKLoader.GetInstanceProcAddress("vkCmdSetAttachmentFeedbackLoopEnableEXT");
            _vkCmdSetAttachmentFeedbackLoopEnableEXT_fnptr(commandBuffer, aspectMask);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewport*, void> _vkCmdSetViewport_fnptr = &vkCmdSetViewport_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetViewport_Lazy(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports)
        {
            _vkCmdSetViewport_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewport*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetViewport");
            _vkCmdSetViewport_fnptr(commandBuffer, firstViewport, viewportCount, pViewports);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void> _vkCmdSetScissor_fnptr = &vkCmdSetScissor_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetScissor_Lazy(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors)
        {
            _vkCmdSetScissor_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetScissor");
            _vkCmdSetScissor_fnptr(commandBuffer, firstScissor, scissorCount, pScissors);
        }
        public static delegate* unmanaged<VkCommandBuffer, float, void> _vkCmdSetLineWidth_fnptr = &vkCmdSetLineWidth_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetLineWidth_Lazy(VkCommandBuffer commandBuffer, float lineWidth)
        {
            _vkCmdSetLineWidth_fnptr = (delegate* unmanaged<VkCommandBuffer, float, void>)VKLoader.GetInstanceProcAddress("vkCmdSetLineWidth");
            _vkCmdSetLineWidth_fnptr(commandBuffer, lineWidth);
        }
        public static delegate* unmanaged<VkCommandBuffer, float, float, float, void> _vkCmdSetDepthBias_fnptr = &vkCmdSetDepthBias_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDepthBias_Lazy(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            _vkCmdSetDepthBias_fnptr = (delegate* unmanaged<VkCommandBuffer, float, float, float, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDepthBias");
            _vkCmdSetDepthBias_fnptr(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
        }
        public static delegate* unmanaged<VkCommandBuffer, float*, void> _vkCmdSetBlendConstants_fnptr = &vkCmdSetBlendConstants_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetBlendConstants_Lazy(VkCommandBuffer commandBuffer, float* blendConstants)
        {
            _vkCmdSetBlendConstants_fnptr = (delegate* unmanaged<VkCommandBuffer, float*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetBlendConstants");
            _vkCmdSetBlendConstants_fnptr(commandBuffer, blendConstants);
        }
        public static delegate* unmanaged<VkCommandBuffer, float, float, void> _vkCmdSetDepthBounds_fnptr = &vkCmdSetDepthBounds_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDepthBounds_Lazy(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds)
        {
            _vkCmdSetDepthBounds_fnptr = (delegate* unmanaged<VkCommandBuffer, float, float, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDepthBounds");
            _vkCmdSetDepthBounds_fnptr(commandBuffer, minDepthBounds, maxDepthBounds);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, uint, void> _vkCmdSetStencilCompareMask_fnptr = &vkCmdSetStencilCompareMask_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetStencilCompareMask_Lazy(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, uint compareMask)
        {
            _vkCmdSetStencilCompareMask_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdSetStencilCompareMask");
            _vkCmdSetStencilCompareMask_fnptr(commandBuffer, faceMask, compareMask);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, uint, void> _vkCmdSetStencilWriteMask_fnptr = &vkCmdSetStencilWriteMask_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetStencilWriteMask_Lazy(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, uint writeMask)
        {
            _vkCmdSetStencilWriteMask_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdSetStencilWriteMask");
            _vkCmdSetStencilWriteMask_fnptr(commandBuffer, faceMask, writeMask);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, uint, void> _vkCmdSetStencilReference_fnptr = &vkCmdSetStencilReference_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetStencilReference_Lazy(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, uint reference)
        {
            _vkCmdSetStencilReference_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdSetStencilReference");
            _vkCmdSetStencilReference_fnptr(commandBuffer, faceMask, reference);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkDescriptorSet*, uint, uint*, void> _vkCmdBindDescriptorSets_fnptr = &vkCmdBindDescriptorSets_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindDescriptorSets_Lazy(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
        {
            _vkCmdBindDescriptorSets_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkDescriptorSet*, uint, uint*, void>)VKLoader.GetInstanceProcAddress("vkCmdBindDescriptorSets");
            _vkCmdBindDescriptorSets_fnptr(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkIndexType, void> _vkCmdBindIndexBuffer_fnptr = &vkCmdBindIndexBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindIndexBuffer_Lazy(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType)
        {
            _vkCmdBindIndexBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkIndexType, void>)VKLoader.GetInstanceProcAddress("vkCmdBindIndexBuffer");
            _vkCmdBindIndexBuffer_fnptr(commandBuffer, buffer, offset, indexType);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> _vkCmdBindVertexBuffers_fnptr = &vkCmdBindVertexBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindVertexBuffers_Lazy(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets)
        {
            _vkCmdBindVertexBuffers_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void>)VKLoader.GetInstanceProcAddress("vkCmdBindVertexBuffers");
            _vkCmdBindVertexBuffers_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, void> _vkCmdDraw_fnptr = &vkCmdDraw_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDraw_Lazy(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            _vkCmdDraw_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDraw");
            _vkCmdDraw_fnptr(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, uint, int, uint, void> _vkCmdDrawIndexed_fnptr = &vkCmdDrawIndexed_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawIndexed_Lazy(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            _vkCmdDrawIndexed_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, int, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawIndexed");
            _vkCmdDrawIndexed_fnptr(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkMultiDrawInfoEXT*, uint, uint, uint, void> _vkCmdDrawMultiEXT_fnptr = &vkCmdDrawMultiEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawMultiEXT_Lazy(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
        {
            _vkCmdDrawMultiEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkMultiDrawInfoEXT*, uint, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawMultiEXT");
            _vkCmdDrawMultiEXT_fnptr(commandBuffer, drawCount, pVertexInfo, instanceCount, firstInstance, stride);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkMultiDrawIndexedInfoEXT*, uint, uint, uint, int*, void> _vkCmdDrawMultiIndexedEXT_fnptr = &vkCmdDrawMultiIndexedEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawMultiIndexedEXT_Lazy(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
        {
            _vkCmdDrawMultiIndexedEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkMultiDrawIndexedInfoEXT*, uint, uint, uint, int*, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawMultiIndexedEXT");
            _vkCmdDrawMultiIndexedEXT_fnptr(commandBuffer, drawCount, pIndexInfo, instanceCount, firstInstance, stride, pVertexOffset);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndirect_fnptr = &vkCmdDrawIndirect_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawIndirect_Lazy(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            _vkCmdDrawIndirect_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawIndirect");
            _vkCmdDrawIndirect_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndexedIndirect_fnptr = &vkCmdDrawIndexedIndirect_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawIndexedIndirect_Lazy(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            _vkCmdDrawIndexedIndirect_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawIndexedIndirect");
            _vkCmdDrawIndexedIndirect_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void> _vkCmdDispatch_fnptr = &vkCmdDispatch_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDispatch_Lazy(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            _vkCmdDispatch_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDispatch");
            _vkCmdDispatch_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, void> _vkCmdDispatchIndirect_fnptr = &vkCmdDispatchIndirect_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDispatchIndirect_Lazy(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
        {
            _vkCmdDispatchIndirect_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, void>)VKLoader.GetInstanceProcAddress("vkCmdDispatchIndirect");
            _vkCmdDispatchIndirect_fnptr(commandBuffer, buffer, offset);
        }
        public static delegate* unmanaged<VkCommandBuffer, void> _vkCmdSubpassShadingHUAWEI_fnptr = &vkCmdSubpassShadingHUAWEI_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSubpassShadingHUAWEI_Lazy(VkCommandBuffer commandBuffer)
        {
            _vkCmdSubpassShadingHUAWEI_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetInstanceProcAddress("vkCmdSubpassShadingHUAWEI");
            _vkCmdSubpassShadingHUAWEI_fnptr(commandBuffer);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void> _vkCmdDrawClusterHUAWEI_fnptr = &vkCmdDrawClusterHUAWEI_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawClusterHUAWEI_Lazy(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            _vkCmdDrawClusterHUAWEI_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawClusterHUAWEI");
            _vkCmdDrawClusterHUAWEI_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, void> _vkCmdDrawClusterIndirectHUAWEI_fnptr = &vkCmdDrawClusterIndirectHUAWEI_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawClusterIndirectHUAWEI_Lazy(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
        {
            _vkCmdDrawClusterIndirectHUAWEI_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawClusterIndirectHUAWEI");
            _vkCmdDrawClusterIndirectHUAWEI_fnptr(commandBuffer, buffer, offset);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> _vkCmdUpdatePipelineIndirectBufferNV_fnptr = &vkCmdUpdatePipelineIndirectBufferNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdUpdatePipelineIndirectBufferNV_Lazy(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
        {
            _vkCmdUpdatePipelineIndirectBufferNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void>)VKLoader.GetInstanceProcAddress("vkCmdUpdatePipelineIndirectBufferNV");
            _vkCmdUpdatePipelineIndirectBufferNV_fnptr(commandBuffer, pipelineBindPoint, pipeline);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void> _vkCmdCopyBuffer_fnptr = &vkCmdCopyBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyBuffer_Lazy(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions)
        {
            _vkCmdCopyBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyBuffer");
            _vkCmdCopyBuffer_fnptr(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageCopy*, void> _vkCmdCopyImage_fnptr = &vkCmdCopyImage_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyImage_Lazy(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions)
        {
            _vkCmdCopyImage_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageCopy*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyImage");
            _vkCmdCopyImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageBlit*, VkFilter, void> _vkCmdBlitImage_fnptr = &vkCmdBlitImage_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBlitImage_Lazy(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter)
        {
            _vkCmdBlitImage_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageBlit*, VkFilter, void>)VKLoader.GetInstanceProcAddress("vkCmdBlitImage");
            _vkCmdBlitImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, VkImage, VkImageLayout, uint, VkBufferImageCopy*, void> _vkCmdCopyBufferToImage_fnptr = &vkCmdCopyBufferToImage_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyBufferToImage_Lazy(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions)
        {
            _vkCmdCopyBufferToImage_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, VkImage, VkImageLayout, uint, VkBufferImageCopy*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyBufferToImage");
            _vkCmdCopyBufferToImage_fnptr(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void> _vkCmdCopyImageToBuffer_fnptr = &vkCmdCopyImageToBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyImageToBuffer_Lazy(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
        {
            _vkCmdCopyImageToBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyImageToBuffer");
            _vkCmdCopyImageToBuffer_fnptr(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
        }
        public static delegate* unmanaged<VkCommandBuffer, ulong, uint, uint, void> _vkCmdCopyMemoryIndirectNV_fnptr = &vkCmdCopyMemoryIndirectNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyMemoryIndirectNV_Lazy(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride)
        {
            _vkCmdCopyMemoryIndirectNV_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyMemoryIndirectNV");
            _vkCmdCopyMemoryIndirectNV_fnptr(commandBuffer, copyBufferAddress, copyCount, stride);
        }
        public static delegate* unmanaged<VkCommandBuffer, ulong, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void> _vkCmdCopyMemoryToImageIndirectNV_fnptr = &vkCmdCopyMemoryToImageIndirectNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyMemoryToImageIndirectNV_Lazy(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, VkImageSubresourceLayers* pImageSubresources)
        {
            _vkCmdCopyMemoryToImageIndirectNV_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyMemoryToImageIndirectNV");
            _vkCmdCopyMemoryToImageIndirectNV_fnptr(commandBuffer, copyBufferAddress, copyCount, stride, dstImage, dstImageLayout, pImageSubresources);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, void*, void> _vkCmdUpdateBuffer_fnptr = &vkCmdUpdateBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdUpdateBuffer_Lazy(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData)
        {
            _vkCmdUpdateBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, void*, void>)VKLoader.GetInstanceProcAddress("vkCmdUpdateBuffer");
            _vkCmdUpdateBuffer_fnptr(commandBuffer, dstBuffer, dstOffset, dataSize, pData);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, uint, void> _vkCmdFillBuffer_fnptr = &vkCmdFillBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdFillBuffer_Lazy(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data)
        {
            _vkCmdFillBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdFillBuffer");
            _vkCmdFillBuffer_fnptr(commandBuffer, dstBuffer, dstOffset, size, data);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkClearColorValue*, uint, VkImageSubresourceRange*, void> _vkCmdClearColorImage_fnptr = &vkCmdClearColorImage_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdClearColorImage_Lazy(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            _vkCmdClearColorImage_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkClearColorValue*, uint, VkImageSubresourceRange*, void>)VKLoader.GetInstanceProcAddress("vkCmdClearColorImage");
            _vkCmdClearColorImage_fnptr(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkClearDepthStencilValue*, uint, VkImageSubresourceRange*, void> _vkCmdClearDepthStencilImage_fnptr = &vkCmdClearDepthStencilImage_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdClearDepthStencilImage_Lazy(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            _vkCmdClearDepthStencilImage_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkClearDepthStencilValue*, uint, VkImageSubresourceRange*, void>)VKLoader.GetInstanceProcAddress("vkCmdClearDepthStencilImage");
            _vkCmdClearDepthStencilImage_fnptr(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkClearAttachment*, uint, VkClearRect*, void> _vkCmdClearAttachments_fnptr = &vkCmdClearAttachments_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdClearAttachments_Lazy(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects)
        {
            _vkCmdClearAttachments_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkClearAttachment*, uint, VkClearRect*, void>)VKLoader.GetInstanceProcAddress("vkCmdClearAttachments");
            _vkCmdClearAttachments_fnptr(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageResolve*, void> _vkCmdResolveImage_fnptr = &vkCmdResolveImage_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdResolveImage_Lazy(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions)
        {
            _vkCmdResolveImage_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageResolve*, void>)VKLoader.GetInstanceProcAddress("vkCmdResolveImage");
            _vkCmdResolveImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits, void> _vkCmdSetEvent_fnptr = &vkCmdSetEvent_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetEvent_Lazy(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits stageMask)
        {
            _vkCmdSetEvent_fnptr = (delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits, void>)VKLoader.GetInstanceProcAddress("vkCmdSetEvent");
            _vkCmdSetEvent_fnptr(commandBuffer, @event, stageMask);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits, void> _vkCmdResetEvent_fnptr = &vkCmdResetEvent_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdResetEvent_Lazy(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits stageMask)
        {
            _vkCmdResetEvent_fnptr = (delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits, void>)VKLoader.GetInstanceProcAddress("vkCmdResetEvent");
            _vkCmdResetEvent_fnptr(commandBuffer, @event, stageMask);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkPipelineStageFlagBits, VkPipelineStageFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void> _vkCmdWaitEvents_fnptr = &vkCmdWaitEvents_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdWaitEvents_Lazy(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlagBits srcStageMask, VkPipelineStageFlagBits dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
        {
            _vkCmdWaitEvents_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkPipelineStageFlagBits, VkPipelineStageFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void>)VKLoader.GetInstanceProcAddress("vkCmdWaitEvents");
            _vkCmdWaitEvents_fnptr(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits, VkPipelineStageFlagBits, VkDependencyFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void> _vkCmdPipelineBarrier_fnptr = &vkCmdPipelineBarrier_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdPipelineBarrier_Lazy(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits srcStageMask, VkPipelineStageFlagBits dstStageMask, VkDependencyFlagBits dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
        {
            _vkCmdPipelineBarrier_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits, VkPipelineStageFlagBits, VkDependencyFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void>)VKLoader.GetInstanceProcAddress("vkCmdPipelineBarrier");
            _vkCmdPipelineBarrier_fnptr(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlagBits, void> _vkCmdBeginQuery_fnptr = &vkCmdBeginQuery_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBeginQuery_Lazy(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlagBits flags)
        {
            _vkCmdBeginQuery_fnptr = (delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlagBits, void>)VKLoader.GetInstanceProcAddress("vkCmdBeginQuery");
            _vkCmdBeginQuery_fnptr(commandBuffer, queryPool, query, flags);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, void> _vkCmdEndQuery_fnptr = &vkCmdEndQuery_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdEndQuery_Lazy(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query)
        {
            _vkCmdEndQuery_fnptr = (delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdEndQuery");
            _vkCmdEndQuery_fnptr(commandBuffer, queryPool, query);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void> _vkCmdBeginConditionalRenderingEXT_fnptr = &vkCmdBeginConditionalRenderingEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBeginConditionalRenderingEXT_Lazy(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
        {
            _vkCmdBeginConditionalRenderingEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdBeginConditionalRenderingEXT");
            _vkCmdBeginConditionalRenderingEXT_fnptr(commandBuffer, pConditionalRenderingBegin);
        }
        public static delegate* unmanaged<VkCommandBuffer, void> _vkCmdEndConditionalRenderingEXT_fnptr = &vkCmdEndConditionalRenderingEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdEndConditionalRenderingEXT_Lazy(VkCommandBuffer commandBuffer)
        {
            _vkCmdEndConditionalRenderingEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetInstanceProcAddress("vkCmdEndConditionalRenderingEXT");
            _vkCmdEndConditionalRenderingEXT_fnptr(commandBuffer);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, void> _vkCmdResetQueryPool_fnptr = &vkCmdResetQueryPool_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdResetQueryPool_Lazy(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            _vkCmdResetQueryPool_fnptr = (delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdResetQueryPool");
            _vkCmdResetQueryPool_fnptr(commandBuffer, queryPool, firstQuery, queryCount);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits, VkQueryPool, uint, void> _vkCmdWriteTimestamp_fnptr = &vkCmdWriteTimestamp_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdWriteTimestamp_Lazy(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint query)
        {
            _vkCmdWriteTimestamp_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits, VkQueryPool, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdWriteTimestamp");
            _vkCmdWriteTimestamp_fnptr(commandBuffer, pipelineStage, queryPool, query);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, VkQueryResultFlagBits, void> _vkCmdCopyQueryPoolResults_fnptr = &vkCmdCopyQueryPoolResults_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyQueryPoolResults_Lazy(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlagBits flags)
        {
            _vkCmdCopyQueryPoolResults_fnptr = (delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, VkQueryResultFlagBits, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyQueryPoolResults");
            _vkCmdCopyQueryPoolResults_fnptr(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineLayout, VkShaderStageFlagBits, uint, uint, void*, void> _vkCmdPushConstants_fnptr = &vkCmdPushConstants_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdPushConstants_Lazy(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlagBits stageFlags, uint offset, uint size, void* pValues)
        {
            _vkCmdPushConstants_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineLayout, VkShaderStageFlagBits, uint, uint, void*, void>)VKLoader.GetInstanceProcAddress("vkCmdPushConstants");
            _vkCmdPushConstants_fnptr(commandBuffer, layout, stageFlags, offset, size, pValues);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassContents, void> _vkCmdBeginRenderPass_fnptr = &vkCmdBeginRenderPass_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBeginRenderPass_Lazy(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents)
        {
            _vkCmdBeginRenderPass_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassContents, void>)VKLoader.GetInstanceProcAddress("vkCmdBeginRenderPass");
            _vkCmdBeginRenderPass_fnptr(commandBuffer, pRenderPassBegin, contents);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkSubpassContents, void> _vkCmdNextSubpass_fnptr = &vkCmdNextSubpass_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdNextSubpass_Lazy(VkCommandBuffer commandBuffer, VkSubpassContents contents)
        {
            _vkCmdNextSubpass_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSubpassContents, void>)VKLoader.GetInstanceProcAddress("vkCmdNextSubpass");
            _vkCmdNextSubpass_fnptr(commandBuffer, contents);
        }
        public static delegate* unmanaged<VkCommandBuffer, void> _vkCmdEndRenderPass_fnptr = &vkCmdEndRenderPass_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdEndRenderPass_Lazy(VkCommandBuffer commandBuffer)
        {
            _vkCmdEndRenderPass_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetInstanceProcAddress("vkCmdEndRenderPass");
            _vkCmdEndRenderPass_fnptr(commandBuffer);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkCommandBuffer*, void> _vkCmdExecuteCommands_fnptr = &vkCmdExecuteCommands_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdExecuteCommands_Lazy(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
        {
            _vkCmdExecuteCommands_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkCommandBuffer*, void>)VKLoader.GetInstanceProcAddress("vkCmdExecuteCommands");
            _vkCmdExecuteCommands_fnptr(commandBuffer, commandBufferCount, pCommandBuffers);
        }
        public static delegate* unmanaged<VkInstance, VkAndroidSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateAndroidSurfaceKHR_fnptr = &vkCreateAndroidSurfaceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateAndroidSurfaceKHR_Lazy(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateAndroidSurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkAndroidSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateAndroidSurfaceKHR");
            return _vkCreateAndroidSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPropertiesKHR*, VkResult> _vkGetPhysicalDeviceDisplayPropertiesKHR_fnptr = &vkGetPhysicalDeviceDisplayPropertiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceDisplayPropertiesKHR_Lazy(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties)
        {
            _vkGetPhysicalDeviceDisplayPropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceDisplayPropertiesKHR");
            return _vkGetPhysicalDeviceDisplayPropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPlanePropertiesKHR*, VkResult> _vkGetPhysicalDeviceDisplayPlanePropertiesKHR_fnptr = &vkGetPhysicalDeviceDisplayPlanePropertiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR_Lazy(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
        {
            _vkGetPhysicalDeviceDisplayPlanePropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPlanePropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceDisplayPlanePropertiesKHR");
            return _vkGetPhysicalDeviceDisplayPlanePropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkDisplayKHR*, VkResult> _vkGetDisplayPlaneSupportedDisplaysKHR_fnptr = &vkGetDisplayPlaneSupportedDisplaysKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDisplayPlaneSupportedDisplaysKHR_Lazy(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays)
        {
            _vkGetDisplayPlaneSupportedDisplaysKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkDisplayKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDisplayPlaneSupportedDisplaysKHR");
            return _vkGetDisplayPlaneSupportedDisplaysKHR_fnptr(physicalDevice, planeIndex, pDisplayCount, pDisplays);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModePropertiesKHR*, VkResult> _vkGetDisplayModePropertiesKHR_fnptr = &vkGetDisplayModePropertiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDisplayModePropertiesKHR_Lazy(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
        {
            _vkGetDisplayModePropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModePropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDisplayModePropertiesKHR");
            return _vkGetDisplayModePropertiesKHR_fnptr(physicalDevice, display, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkDisplayModeCreateInfoKHR*, VkAllocationCallbacks*, VkDisplayModeKHR*, VkResult> _vkCreateDisplayModeKHR_fnptr = &vkCreateDisplayModeKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateDisplayModeKHR_Lazy(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
        {
            _vkCreateDisplayModeKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkDisplayModeCreateInfoKHR*, VkAllocationCallbacks*, VkDisplayModeKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateDisplayModeKHR");
            return _vkCreateDisplayModeKHR_fnptr(physicalDevice, display, pCreateInfo, pAllocator, pMode);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkDisplayModeKHR, uint, VkDisplayPlaneCapabilitiesKHR*, VkResult> _vkGetDisplayPlaneCapabilitiesKHR_fnptr = &vkGetDisplayPlaneCapabilitiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDisplayPlaneCapabilitiesKHR_Lazy(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)
        {
            _vkGetDisplayPlaneCapabilitiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayModeKHR, uint, VkDisplayPlaneCapabilitiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDisplayPlaneCapabilitiesKHR");
            return _vkGetDisplayPlaneCapabilitiesKHR_fnptr(physicalDevice, mode, planeIndex, pCapabilities);
        }
        public static delegate* unmanaged<VkInstance, VkDisplaySurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateDisplayPlaneSurfaceKHR_fnptr = &vkCreateDisplayPlaneSurfaceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateDisplayPlaneSurfaceKHR_Lazy(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateDisplayPlaneSurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkDisplaySurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateDisplayPlaneSurfaceKHR");
            return _vkCreateDisplayPlaneSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkDevice, uint, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult> _vkCreateSharedSwapchainsKHR_fnptr = &vkCreateSharedSwapchainsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateSharedSwapchainsKHR_Lazy(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
        {
            _vkCreateSharedSwapchainsKHR_fnptr = (delegate* unmanaged<VkDevice, uint, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateSharedSwapchainsKHR");
            return _vkCreateSharedSwapchainsKHR_fnptr(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);
        }
        public static delegate* unmanaged<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void> _vkDestroySurfaceKHR_fnptr = &vkDestroySurfaceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroySurfaceKHR_Lazy(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroySurfaceKHR");
            _vkDestroySurfaceKHR_fnptr(instance, surface, pAllocator);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint, VkSurfaceKHR, int*, VkResult> _vkGetPhysicalDeviceSurfaceSupportKHR_fnptr = &vkGetPhysicalDeviceSurfaceSupportKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceSurfaceSupportKHR_Lazy(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, int* pSupported)
        {
            _vkGetPhysicalDeviceSurfaceSupportKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, VkSurfaceKHR, int*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSurfaceSupportKHR");
            return _vkGetPhysicalDeviceSurfaceSupportKHR_fnptr(physicalDevice, queueFamilyIndex, surface, pSupported);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilitiesKHR*, VkResult> _vkGetPhysicalDeviceSurfaceCapabilitiesKHR_fnptr = &vkGetPhysicalDeviceSurfaceCapabilitiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR_Lazy(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities)
        {
            _vkGetPhysicalDeviceSurfaceCapabilitiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilitiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSurfaceCapabilitiesKHR");
            return _vkGetPhysicalDeviceSurfaceCapabilitiesKHR_fnptr(physicalDevice, surface, pSurfaceCapabilities);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkSurfaceFormatKHR*, VkResult> _vkGetPhysicalDeviceSurfaceFormatsKHR_fnptr = &vkGetPhysicalDeviceSurfaceFormatsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceSurfaceFormatsKHR_Lazy(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
        {
            _vkGetPhysicalDeviceSurfaceFormatsKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkSurfaceFormatKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSurfaceFormatsKHR");
            return _vkGetPhysicalDeviceSurfaceFormatsKHR_fnptr(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkPresentModeKHR*, VkResult> _vkGetPhysicalDeviceSurfacePresentModesKHR_fnptr = &vkGetPhysicalDeviceSurfacePresentModesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceSurfacePresentModesKHR_Lazy(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            _vkGetPhysicalDeviceSurfacePresentModesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkPresentModeKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSurfacePresentModesKHR");
            return _vkGetPhysicalDeviceSurfacePresentModesKHR_fnptr(physicalDevice, surface, pPresentModeCount, pPresentModes);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult> _vkCreateSwapchainKHR_fnptr = &vkCreateSwapchainKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateSwapchainKHR_Lazy(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
        {
            _vkCreateSwapchainKHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateSwapchainKHR");
            return _vkCreateSwapchainKHR_fnptr(device, pCreateInfo, pAllocator, pSwapchain);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void> _vkDestroySwapchainKHR_fnptr = &vkDestroySwapchainKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroySwapchainKHR_Lazy(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySwapchainKHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroySwapchainKHR");
            _vkDestroySwapchainKHR_fnptr(device, swapchain, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, uint*, VkImage*, VkResult> _vkGetSwapchainImagesKHR_fnptr = &vkGetSwapchainImagesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetSwapchainImagesKHR_Lazy(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages)
        {
            _vkGetSwapchainImagesKHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, uint*, VkImage*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetSwapchainImagesKHR");
            return _vkGetSwapchainImagesKHR_fnptr(device, swapchain, pSwapchainImageCount, pSwapchainImages);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, uint*, VkResult> _vkAcquireNextImageKHR_fnptr = &vkAcquireNextImageKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkAcquireNextImageKHR_Lazy(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex)
        {
            _vkAcquireNextImageKHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, uint*, VkResult>)VKLoader.GetInstanceProcAddress("vkAcquireNextImageKHR");
            return _vkAcquireNextImageKHR_fnptr(device, swapchain, timeout, semaphore, fence, pImageIndex);
        }
        public static delegate* unmanaged<VkQueue, VkPresentInfoKHR*, VkResult> _vkQueuePresentKHR_fnptr = &vkQueuePresentKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkQueuePresentKHR_Lazy(VkQueue queue, VkPresentInfoKHR* pPresentInfo)
        {
            _vkQueuePresentKHR_fnptr = (delegate* unmanaged<VkQueue, VkPresentInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkQueuePresentKHR");
            return _vkQueuePresentKHR_fnptr(queue, pPresentInfo);
        }
        public static delegate* unmanaged<VkInstance, VkViSurfaceCreateInfoNN*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateViSurfaceNN_fnptr = &vkCreateViSurfaceNN_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateViSurfaceNN_Lazy(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateViSurfaceNN_fnptr = (delegate* unmanaged<VkInstance, VkViSurfaceCreateInfoNN*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateViSurfaceNN");
            return _vkCreateViSurfaceNN_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkInstance, VkWaylandSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateWaylandSurfaceKHR_fnptr = &vkCreateWaylandSurfaceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateWaylandSurfaceKHR_Lazy(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateWaylandSurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkWaylandSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateWaylandSurfaceKHR");
            return _vkCreateWaylandSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, int> _vkGetPhysicalDeviceWaylandPresentationSupportKHR_fnptr = &vkGetPhysicalDeviceWaylandPresentationSupportKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int vkGetPhysicalDeviceWaylandPresentationSupportKHR_Lazy(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display)
        {
            _vkGetPhysicalDeviceWaylandPresentationSupportKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, int>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceWaylandPresentationSupportKHR");
            return _vkGetPhysicalDeviceWaylandPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, display);
        }
        public static delegate* unmanaged<VkInstance, VkWin32SurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateWin32SurfaceKHR_fnptr = &vkCreateWin32SurfaceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateWin32SurfaceKHR_Lazy(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateWin32SurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkWin32SurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateWin32SurfaceKHR");
            return _vkCreateWin32SurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint, int> _vkGetPhysicalDeviceWin32PresentationSupportKHR_fnptr = &vkGetPhysicalDeviceWin32PresentationSupportKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int vkGetPhysicalDeviceWin32PresentationSupportKHR_Lazy(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
        {
            _vkGetPhysicalDeviceWin32PresentationSupportKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, int>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceWin32PresentationSupportKHR");
            return _vkGetPhysicalDeviceWin32PresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex);
        }
        public static delegate* unmanaged<VkInstance, VkXlibSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateXlibSurfaceKHR_fnptr = &vkCreateXlibSurfaceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateXlibSurfaceKHR_Lazy(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateXlibSurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkXlibSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateXlibSurfaceKHR");
            return _vkCreateXlibSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, nuint, int> _vkGetPhysicalDeviceXlibPresentationSupportKHR_fnptr = &vkGetPhysicalDeviceXlibPresentationSupportKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int vkGetPhysicalDeviceXlibPresentationSupportKHR_Lazy(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, nuint visualID)
        {
            _vkGetPhysicalDeviceXlibPresentationSupportKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, nuint, int>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceXlibPresentationSupportKHR");
            return _vkGetPhysicalDeviceXlibPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, dpy, visualID);
        }
        public static delegate* unmanaged<VkInstance, VkXcbSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateXcbSurfaceKHR_fnptr = &vkCreateXcbSurfaceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateXcbSurfaceKHR_Lazy(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateXcbSurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkXcbSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateXcbSurfaceKHR");
            return _vkCreateXcbSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, uint, int> _vkGetPhysicalDeviceXcbPresentationSupportKHR_fnptr = &vkGetPhysicalDeviceXcbPresentationSupportKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int vkGetPhysicalDeviceXcbPresentationSupportKHR_Lazy(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, uint visual_id)
        {
            _vkGetPhysicalDeviceXcbPresentationSupportKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, uint, int>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceXcbPresentationSupportKHR");
            return _vkGetPhysicalDeviceXcbPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, connection, visual_id);
        }
        public static delegate* unmanaged<VkInstance, VkDirectFBSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateDirectFBSurfaceEXT_fnptr = &vkCreateDirectFBSurfaceEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateDirectFBSurfaceEXT_Lazy(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateDirectFBSurfaceEXT_fnptr = (delegate* unmanaged<VkInstance, VkDirectFBSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateDirectFBSurfaceEXT");
            return _vkCreateDirectFBSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, int> _vkGetPhysicalDeviceDirectFBPresentationSupportEXT_fnptr = &vkGetPhysicalDeviceDirectFBPresentationSupportEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int vkGetPhysicalDeviceDirectFBPresentationSupportEXT_Lazy(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dfb)
        {
            _vkGetPhysicalDeviceDirectFBPresentationSupportEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, int>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceDirectFBPresentationSupportEXT");
            return _vkGetPhysicalDeviceDirectFBPresentationSupportEXT_fnptr(physicalDevice, queueFamilyIndex, dfb);
        }
        public static delegate* unmanaged<VkInstance, VkImagePipeSurfaceCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateImagePipeSurfaceFUCHSIA_fnptr = &vkCreateImagePipeSurfaceFUCHSIA_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateImagePipeSurfaceFUCHSIA_Lazy(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateImagePipeSurfaceFUCHSIA_fnptr = (delegate* unmanaged<VkInstance, VkImagePipeSurfaceCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateImagePipeSurfaceFUCHSIA");
            return _vkCreateImagePipeSurfaceFUCHSIA_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkInstance, VkStreamDescriptorSurfaceCreateInfoGGP*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateStreamDescriptorSurfaceGGP_fnptr = &vkCreateStreamDescriptorSurfaceGGP_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateStreamDescriptorSurfaceGGP_Lazy(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateStreamDescriptorSurfaceGGP_fnptr = (delegate* unmanaged<VkInstance, VkStreamDescriptorSurfaceCreateInfoGGP*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateStreamDescriptorSurfaceGGP");
            return _vkCreateStreamDescriptorSurfaceGGP_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkInstance, VkScreenSurfaceCreateInfoQNX*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateScreenSurfaceQNX_fnptr = &vkCreateScreenSurfaceQNX_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateScreenSurfaceQNX_Lazy(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateScreenSurfaceQNX_fnptr = (delegate* unmanaged<VkInstance, VkScreenSurfaceCreateInfoQNX*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateScreenSurfaceQNX");
            return _vkCreateScreenSurfaceQNX_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint, IntPtr*, int> _vkGetPhysicalDeviceScreenPresentationSupportQNX_fnptr = &vkGetPhysicalDeviceScreenPresentationSupportQNX_Lazy;
        [UnmanagedCallersOnly]
        private static int vkGetPhysicalDeviceScreenPresentationSupportQNX_Lazy(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* window)
        {
            _vkGetPhysicalDeviceScreenPresentationSupportQNX_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, IntPtr*, int>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceScreenPresentationSupportQNX");
            return _vkGetPhysicalDeviceScreenPresentationSupportQNX_fnptr(physicalDevice, queueFamilyIndex, window);
        }
        public static delegate* unmanaged<VkInstance, VkDebugReportCallbackCreateInfoEXT*, VkAllocationCallbacks*, VkDebugReportCallbackEXT*, VkResult> _vkCreateDebugReportCallbackEXT_fnptr = &vkCreateDebugReportCallbackEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateDebugReportCallbackEXT_Lazy(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            _vkCreateDebugReportCallbackEXT_fnptr = (delegate* unmanaged<VkInstance, VkDebugReportCallbackCreateInfoEXT*, VkAllocationCallbacks*, VkDebugReportCallbackEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateDebugReportCallbackEXT");
            return _vkCreateDebugReportCallbackEXT_fnptr(instance, pCreateInfo, pAllocator, pCallback);
        }
        public static delegate* unmanaged<VkInstance, VkDebugReportCallbackEXT, VkAllocationCallbacks*, void> _vkDestroyDebugReportCallbackEXT_fnptr = &vkDestroyDebugReportCallbackEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyDebugReportCallbackEXT_Lazy(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDebugReportCallbackEXT_fnptr = (delegate* unmanaged<VkInstance, VkDebugReportCallbackEXT, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyDebugReportCallbackEXT");
            _vkDestroyDebugReportCallbackEXT_fnptr(instance, callback, pAllocator);
        }
        public static delegate* unmanaged<VkInstance, VkDebugReportFlagBitsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*, void> _vkDebugReportMessageEXT_fnptr = &vkDebugReportMessageEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDebugReportMessageEXT_Lazy(VkInstance instance, VkDebugReportFlagBitsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong obj, nuint location, int messageCode, byte* pLayerPrefix, byte* pMessage)
        {
            _vkDebugReportMessageEXT_fnptr = (delegate* unmanaged<VkInstance, VkDebugReportFlagBitsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*, void>)VKLoader.GetInstanceProcAddress("vkDebugReportMessageEXT");
            _vkDebugReportMessageEXT_fnptr(instance, flags, objectType, obj, location, messageCode, pLayerPrefix, pMessage);
        }
        public static delegate* unmanaged<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult> _vkDebugMarkerSetObjectNameEXT_fnptr = &vkDebugMarkerSetObjectNameEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkDebugMarkerSetObjectNameEXT_Lazy(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)
        {
            _vkDebugMarkerSetObjectNameEXT_fnptr = (delegate* unmanaged<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkDebugMarkerSetObjectNameEXT");
            return _vkDebugMarkerSetObjectNameEXT_fnptr(device, pNameInfo);
        }
        public static delegate* unmanaged<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult> _vkDebugMarkerSetObjectTagEXT_fnptr = &vkDebugMarkerSetObjectTagEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkDebugMarkerSetObjectTagEXT_Lazy(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)
        {
            _vkDebugMarkerSetObjectTagEXT_fnptr = (delegate* unmanaged<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkDebugMarkerSetObjectTagEXT");
            return _vkDebugMarkerSetObjectTagEXT_fnptr(device, pTagInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> _vkCmdDebugMarkerBeginEXT_fnptr = &vkCmdDebugMarkerBeginEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDebugMarkerBeginEXT_Lazy(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
        {
            _vkCmdDebugMarkerBeginEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdDebugMarkerBeginEXT");
            _vkCmdDebugMarkerBeginEXT_fnptr(commandBuffer, pMarkerInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, void> _vkCmdDebugMarkerEndEXT_fnptr = &vkCmdDebugMarkerEndEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDebugMarkerEndEXT_Lazy(VkCommandBuffer commandBuffer)
        {
            _vkCmdDebugMarkerEndEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetInstanceProcAddress("vkCmdDebugMarkerEndEXT");
            _vkCmdDebugMarkerEndEXT_fnptr(commandBuffer);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> _vkCmdDebugMarkerInsertEXT_fnptr = &vkCmdDebugMarkerInsertEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDebugMarkerInsertEXT_Lazy(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
        {
            _vkCmdDebugMarkerInsertEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdDebugMarkerInsertEXT");
            _vkCmdDebugMarkerInsertEXT_fnptr(commandBuffer, pMarkerInfo);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, VkExternalMemoryHandleTypeFlagBitsNV, VkExternalImageFormatPropertiesNV*, VkResult> _vkGetPhysicalDeviceExternalImageFormatPropertiesNV_fnptr = &vkGetPhysicalDeviceExternalImageFormatPropertiesNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV_Lazy(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlagBits usage, VkImageCreateFlagBits flags, VkExternalMemoryHandleTypeFlagBitsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties)
        {
            _vkGetPhysicalDeviceExternalImageFormatPropertiesNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, VkExternalMemoryHandleTypeFlagBitsNV, VkExternalImageFormatPropertiesNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceExternalImageFormatPropertiesNV");
            return _vkGetPhysicalDeviceExternalImageFormatPropertiesNV_fnptr(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceMemory, VkExternalMemoryHandleTypeFlagBitsNV, IntPtr*, VkResult> _vkGetMemoryWin32HandleNV_fnptr = &vkGetMemoryWin32HandleNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetMemoryWin32HandleNV_Lazy(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagBitsNV handleType, IntPtr* pHandle)
        {
            _vkGetMemoryWin32HandleNV_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemory, VkExternalMemoryHandleTypeFlagBitsNV, IntPtr*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetMemoryWin32HandleNV");
            return _vkGetMemoryWin32HandleNV_fnptr(device, memory, handleType, pHandle);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, VkGeneratedCommandsInfoNV*, void> _vkCmdExecuteGeneratedCommandsNV_fnptr = &vkCmdExecuteGeneratedCommandsNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdExecuteGeneratedCommandsNV_Lazy(VkCommandBuffer commandBuffer, int isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
        {
            _vkCmdExecuteGeneratedCommandsNV_fnptr = (delegate* unmanaged<VkCommandBuffer, int, VkGeneratedCommandsInfoNV*, void>)VKLoader.GetInstanceProcAddress("vkCmdExecuteGeneratedCommandsNV");
            _vkCmdExecuteGeneratedCommandsNV_fnptr(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void> _vkCmdPreprocessGeneratedCommandsNV_fnptr = &vkCmdPreprocessGeneratedCommandsNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdPreprocessGeneratedCommandsNV_Lazy(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
        {
            _vkCmdPreprocessGeneratedCommandsNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void>)VKLoader.GetInstanceProcAddress("vkCmdPreprocessGeneratedCommandsNV");
            _vkCmdPreprocessGeneratedCommandsNV_fnptr(commandBuffer, pGeneratedCommandsInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, uint, void> _vkCmdBindPipelineShaderGroupNV_fnptr = &vkCmdBindPipelineShaderGroupNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindPipelineShaderGroupNV_Lazy(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
        {
            _vkCmdBindPipelineShaderGroupNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdBindPipelineShaderGroupNV");
            _vkCmdBindPipelineShaderGroupNV_fnptr(commandBuffer, pipelineBindPoint, pipeline, groupIndex);
        }
        public static delegate* unmanaged<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> _vkGetGeneratedCommandsMemoryRequirementsNV_fnptr = &vkGetGeneratedCommandsMemoryRequirementsNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetGeneratedCommandsMemoryRequirementsNV_Lazy(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetGeneratedCommandsMemoryRequirementsNV_fnptr = (delegate* unmanaged<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void>)VKLoader.GetInstanceProcAddress("vkGetGeneratedCommandsMemoryRequirementsNV");
            _vkGetGeneratedCommandsMemoryRequirementsNV_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutCreateInfoNV*, VkAllocationCallbacks*, VkIndirectCommandsLayoutNV*, VkResult> _vkCreateIndirectCommandsLayoutNV_fnptr = &vkCreateIndirectCommandsLayoutNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateIndirectCommandsLayoutNV_Lazy(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            _vkCreateIndirectCommandsLayoutNV_fnptr = (delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutCreateInfoNV*, VkAllocationCallbacks*, VkIndirectCommandsLayoutNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateIndirectCommandsLayoutNV");
            return _vkCreateIndirectCommandsLayoutNV_fnptr(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);
        }
        public static delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void> _vkDestroyIndirectCommandsLayoutNV_fnptr = &vkDestroyIndirectCommandsLayoutNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyIndirectCommandsLayoutNV_Lazy(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyIndirectCommandsLayoutNV_fnptr = (delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyIndirectCommandsLayoutNV");
            _vkDestroyIndirectCommandsLayoutNV_fnptr(device, indirectCommandsLayout, pAllocator);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> _vkGetPhysicalDeviceFeatures2_fnptr = &vkGetPhysicalDeviceFeatures2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceFeatures2_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures)
        {
            _vkGetPhysicalDeviceFeatures2_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceFeatures2");
            _vkGetPhysicalDeviceFeatures2_fnptr(physicalDevice, pFeatures);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> _vkGetPhysicalDeviceProperties2_fnptr = &vkGetPhysicalDeviceProperties2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceProperties2_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties)
        {
            _vkGetPhysicalDeviceProperties2_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceProperties2");
            _vkGetPhysicalDeviceProperties2_fnptr(physicalDevice, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> _vkGetPhysicalDeviceFormatProperties2_fnptr = &vkGetPhysicalDeviceFormatProperties2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceFormatProperties2_Lazy(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties)
        {
            _vkGetPhysicalDeviceFormatProperties2_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceFormatProperties2");
            _vkGetPhysicalDeviceFormatProperties2_fnptr(physicalDevice, format, pFormatProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult> _vkGetPhysicalDeviceImageFormatProperties2_fnptr = &vkGetPhysicalDeviceImageFormatProperties2_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceImageFormatProperties2_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties)
        {
            _vkGetPhysicalDeviceImageFormatProperties2_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceImageFormatProperties2");
            return _vkGetPhysicalDeviceImageFormatProperties2_fnptr(physicalDevice, pImageFormatInfo, pImageFormatProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void> _vkGetPhysicalDeviceQueueFamilyProperties2_fnptr = &vkGetPhysicalDeviceQueueFamilyProperties2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceQueueFamilyProperties2_Lazy(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
        {
            _vkGetPhysicalDeviceQueueFamilyProperties2_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceQueueFamilyProperties2");
            _vkGetPhysicalDeviceQueueFamilyProperties2_fnptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> _vkGetPhysicalDeviceMemoryProperties2_fnptr = &vkGetPhysicalDeviceMemoryProperties2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceMemoryProperties2_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties)
        {
            _vkGetPhysicalDeviceMemoryProperties2_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceMemoryProperties2");
            _vkGetPhysicalDeviceMemoryProperties2_fnptr(physicalDevice, pMemoryProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void> _vkGetPhysicalDeviceSparseImageFormatProperties2_fnptr = &vkGetPhysicalDeviceSparseImageFormatProperties2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceSparseImageFormatProperties2_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
        {
            _vkGetPhysicalDeviceSparseImageFormatProperties2_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSparseImageFormatProperties2");
            _vkGetPhysicalDeviceSparseImageFormatProperties2_fnptr(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void> _vkCmdPushDescriptorSetKHR_fnptr = &vkCmdPushDescriptorSetKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdPushDescriptorSetKHR_Lazy(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
        {
            _vkCmdPushDescriptorSetKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void>)VKLoader.GetInstanceProcAddress("vkCmdPushDescriptorSetKHR");
            _vkCmdPushDescriptorSetKHR_fnptr(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
        }
        public static delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> _vkTrimCommandPool_fnptr = &vkTrimCommandPool_Lazy;
        [UnmanagedCallersOnly]
        private static void vkTrimCommandPool_Lazy(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags)
        {
            _vkTrimCommandPool_fnptr = (delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void>)VKLoader.GetInstanceProcAddress("vkTrimCommandPool");
            _vkTrimCommandPool_fnptr(device, commandPool, flags);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void> _vkGetPhysicalDeviceExternalBufferProperties_fnptr = &vkGetPhysicalDeviceExternalBufferProperties_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceExternalBufferProperties_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
        {
            _vkGetPhysicalDeviceExternalBufferProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceExternalBufferProperties");
            _vkGetPhysicalDeviceExternalBufferProperties_fnptr(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
        }
        public static delegate* unmanaged<VkDevice, VkMemoryGetWin32HandleInfoKHR*, IntPtr*, VkResult> _vkGetMemoryWin32HandleKHR_fnptr = &vkGetMemoryWin32HandleKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetMemoryWin32HandleKHR_Lazy(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            _vkGetMemoryWin32HandleKHR_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetWin32HandleInfoKHR*, IntPtr*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetMemoryWin32HandleKHR");
            return _vkGetMemoryWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        public static delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, IntPtr, VkMemoryWin32HandlePropertiesKHR*, VkResult> _vkGetMemoryWin32HandlePropertiesKHR_fnptr = &vkGetMemoryWin32HandlePropertiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetMemoryWin32HandlePropertiesKHR_Lazy(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties)
        {
            _vkGetMemoryWin32HandlePropertiesKHR_fnptr = (delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, IntPtr, VkMemoryWin32HandlePropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetMemoryWin32HandlePropertiesKHR");
            return _vkGetMemoryWin32HandlePropertiesKHR_fnptr(device, handleType, handle, pMemoryWin32HandleProperties);
        }
        public static delegate* unmanaged<VkDevice, VkMemoryGetFdInfoKHR*, int*, VkResult> _vkGetMemoryFdKHR_fnptr = &vkGetMemoryFdKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetMemoryFdKHR_Lazy(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            _vkGetMemoryFdKHR_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetFdInfoKHR*, int*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetMemoryFdKHR");
            return _vkGetMemoryFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        public static delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, int, VkMemoryFdPropertiesKHR*, VkResult> _vkGetMemoryFdPropertiesKHR_fnptr = &vkGetMemoryFdPropertiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetMemoryFdPropertiesKHR_Lazy(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties)
        {
            _vkGetMemoryFdPropertiesKHR_fnptr = (delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, int, VkMemoryFdPropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetMemoryFdPropertiesKHR");
            return _vkGetMemoryFdPropertiesKHR_fnptr(device, handleType, fd, pMemoryFdProperties);
        }
        public static delegate* unmanaged<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, int*, VkResult> _vkGetMemoryZirconHandleFUCHSIA_fnptr = &vkGetMemoryZirconHandleFUCHSIA_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetMemoryZirconHandleFUCHSIA_Lazy(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, int* pZirconHandle)
        {
            _vkGetMemoryZirconHandleFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, int*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetMemoryZirconHandleFUCHSIA");
            return _vkGetMemoryZirconHandleFUCHSIA_fnptr(device, pGetZirconHandleInfo, pZirconHandle);
        }
        public static delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, int, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult> _vkGetMemoryZirconHandlePropertiesFUCHSIA_fnptr = &vkGetMemoryZirconHandlePropertiesFUCHSIA_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetMemoryZirconHandlePropertiesFUCHSIA_Lazy(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties)
        {
            _vkGetMemoryZirconHandlePropertiesFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, int, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetMemoryZirconHandlePropertiesFUCHSIA");
            return _vkGetMemoryZirconHandlePropertiesFUCHSIA_fnptr(device, handleType, zirconHandle, pMemoryZirconHandleProperties);
        }
        public static delegate* unmanaged<VkDevice, VkMemoryGetRemoteAddressInfoNV*, void**, VkResult> _vkGetMemoryRemoteAddressNV_fnptr = &vkGetMemoryRemoteAddressNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetMemoryRemoteAddressNV_Lazy(VkDevice device, VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, void** pAddress)
        {
            _vkGetMemoryRemoteAddressNV_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetRemoteAddressInfoNV*, void**, VkResult>)VKLoader.GetInstanceProcAddress("vkGetMemoryRemoteAddressNV");
            return _vkGetMemoryRemoteAddressNV_fnptr(device, pMemoryGetRemoteAddressInfo, pAddress);
        }
        public static delegate* unmanaged<VkDevice, VkMemoryGetSciBufInfoNV*, IntPtr*, VkResult> _vkGetMemorySciBufNV_fnptr = &vkGetMemorySciBufNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetMemorySciBufNV_Lazy(VkDevice device, VkMemoryGetSciBufInfoNV* pGetSciBufInfo, IntPtr* pHandle)
        {
            _vkGetMemorySciBufNV_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetSciBufInfoNV*, IntPtr*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetMemorySciBufNV");
            return _vkGetMemorySciBufNV_fnptr(device, pGetSciBufInfo, pHandle);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkExternalMemoryHandleTypeFlagBits, IntPtr, VkMemorySciBufPropertiesNV*, VkResult> _vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_fnptr = &vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_Lazy(VkPhysicalDevice physicalDevice, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, VkMemorySciBufPropertiesNV* pMemorySciBufProperties)
        {
            _vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkExternalMemoryHandleTypeFlagBits, IntPtr, VkMemorySciBufPropertiesNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV");
            return _vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_fnptr(physicalDevice, handleType, handle, pMemorySciBufProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, IntPtr, VkResult> _vkGetPhysicalDeviceSciBufAttributesNV_fnptr = &vkGetPhysicalDeviceSciBufAttributesNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceSciBufAttributesNV_Lazy(VkPhysicalDevice physicalDevice, IntPtr pAttributes)
        {
            _vkGetPhysicalDeviceSciBufAttributesNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, IntPtr, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSciBufAttributesNV");
            return _vkGetPhysicalDeviceSciBufAttributesNV_fnptr(physicalDevice, pAttributes);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void> _vkGetPhysicalDeviceExternalSemaphoreProperties_fnptr = &vkGetPhysicalDeviceExternalSemaphoreProperties_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceExternalSemaphoreProperties_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
        {
            _vkGetPhysicalDeviceExternalSemaphoreProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceExternalSemaphoreProperties");
            _vkGetPhysicalDeviceExternalSemaphoreProperties_fnptr(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
        }
        public static delegate* unmanaged<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, IntPtr*, VkResult> _vkGetSemaphoreWin32HandleKHR_fnptr = &vkGetSemaphoreWin32HandleKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetSemaphoreWin32HandleKHR_Lazy(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            _vkGetSemaphoreWin32HandleKHR_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, IntPtr*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetSemaphoreWin32HandleKHR");
            return _vkGetSemaphoreWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        public static delegate* unmanaged<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult> _vkImportSemaphoreWin32HandleKHR_fnptr = &vkImportSemaphoreWin32HandleKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkImportSemaphoreWin32HandleKHR_Lazy(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo)
        {
            _vkImportSemaphoreWin32HandleKHR_fnptr = (delegate* unmanaged<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkImportSemaphoreWin32HandleKHR");
            return _vkImportSemaphoreWin32HandleKHR_fnptr(device, pImportSemaphoreWin32HandleInfo);
        }
        public static delegate* unmanaged<VkDevice, VkSemaphoreGetFdInfoKHR*, int*, VkResult> _vkGetSemaphoreFdKHR_fnptr = &vkGetSemaphoreFdKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetSemaphoreFdKHR_Lazy(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            _vkGetSemaphoreFdKHR_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreGetFdInfoKHR*, int*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetSemaphoreFdKHR");
            return _vkGetSemaphoreFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        public static delegate* unmanaged<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult> _vkImportSemaphoreFdKHR_fnptr = &vkImportSemaphoreFdKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkImportSemaphoreFdKHR_Lazy(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo)
        {
            _vkImportSemaphoreFdKHR_fnptr = (delegate* unmanaged<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkImportSemaphoreFdKHR");
            return _vkImportSemaphoreFdKHR_fnptr(device, pImportSemaphoreFdInfo);
        }
        public static delegate* unmanaged<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, int*, VkResult> _vkGetSemaphoreZirconHandleFUCHSIA_fnptr = &vkGetSemaphoreZirconHandleFUCHSIA_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetSemaphoreZirconHandleFUCHSIA_Lazy(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, int* pZirconHandle)
        {
            _vkGetSemaphoreZirconHandleFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, int*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetSemaphoreZirconHandleFUCHSIA");
            return _vkGetSemaphoreZirconHandleFUCHSIA_fnptr(device, pGetZirconHandleInfo, pZirconHandle);
        }
        public static delegate* unmanaged<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult> _vkImportSemaphoreZirconHandleFUCHSIA_fnptr = &vkImportSemaphoreZirconHandleFUCHSIA_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkImportSemaphoreZirconHandleFUCHSIA_Lazy(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo)
        {
            _vkImportSemaphoreZirconHandleFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult>)VKLoader.GetInstanceProcAddress("vkImportSemaphoreZirconHandleFUCHSIA");
            return _vkImportSemaphoreZirconHandleFUCHSIA_fnptr(device, pImportSemaphoreZirconHandleInfo);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void> _vkGetPhysicalDeviceExternalFenceProperties_fnptr = &vkGetPhysicalDeviceExternalFenceProperties_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceExternalFenceProperties_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties)
        {
            _vkGetPhysicalDeviceExternalFenceProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceExternalFenceProperties");
            _vkGetPhysicalDeviceExternalFenceProperties_fnptr(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
        }
        public static delegate* unmanaged<VkDevice, VkFenceGetWin32HandleInfoKHR*, IntPtr*, VkResult> _vkGetFenceWin32HandleKHR_fnptr = &vkGetFenceWin32HandleKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetFenceWin32HandleKHR_Lazy(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            _vkGetFenceWin32HandleKHR_fnptr = (delegate* unmanaged<VkDevice, VkFenceGetWin32HandleInfoKHR*, IntPtr*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetFenceWin32HandleKHR");
            return _vkGetFenceWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        public static delegate* unmanaged<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult> _vkImportFenceWin32HandleKHR_fnptr = &vkImportFenceWin32HandleKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkImportFenceWin32HandleKHR_Lazy(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
        {
            _vkImportFenceWin32HandleKHR_fnptr = (delegate* unmanaged<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkImportFenceWin32HandleKHR");
            return _vkImportFenceWin32HandleKHR_fnptr(device, pImportFenceWin32HandleInfo);
        }
        public static delegate* unmanaged<VkDevice, VkFenceGetFdInfoKHR*, int*, VkResult> _vkGetFenceFdKHR_fnptr = &vkGetFenceFdKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetFenceFdKHR_Lazy(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            _vkGetFenceFdKHR_fnptr = (delegate* unmanaged<VkDevice, VkFenceGetFdInfoKHR*, int*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetFenceFdKHR");
            return _vkGetFenceFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        public static delegate* unmanaged<VkDevice, VkImportFenceFdInfoKHR*, VkResult> _vkImportFenceFdKHR_fnptr = &vkImportFenceFdKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkImportFenceFdKHR_Lazy(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo)
        {
            _vkImportFenceFdKHR_fnptr = (delegate* unmanaged<VkDevice, VkImportFenceFdInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkImportFenceFdKHR");
            return _vkImportFenceFdKHR_fnptr(device, pImportFenceFdInfo);
        }
        public static delegate* unmanaged<VkDevice, VkFenceGetSciSyncInfoNV*, void*, VkResult> _vkGetFenceSciSyncFenceNV_fnptr = &vkGetFenceSciSyncFenceNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetFenceSciSyncFenceNV_Lazy(VkDevice device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle)
        {
            _vkGetFenceSciSyncFenceNV_fnptr = (delegate* unmanaged<VkDevice, VkFenceGetSciSyncInfoNV*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetFenceSciSyncFenceNV");
            return _vkGetFenceSciSyncFenceNV_fnptr(device, pGetSciSyncHandleInfo, pHandle);
        }
        public static delegate* unmanaged<VkDevice, VkFenceGetSciSyncInfoNV*, void*, VkResult> _vkGetFenceSciSyncObjNV_fnptr = &vkGetFenceSciSyncObjNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetFenceSciSyncObjNV_Lazy(VkDevice device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle)
        {
            _vkGetFenceSciSyncObjNV_fnptr = (delegate* unmanaged<VkDevice, VkFenceGetSciSyncInfoNV*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetFenceSciSyncObjNV");
            return _vkGetFenceSciSyncObjNV_fnptr(device, pGetSciSyncHandleInfo, pHandle);
        }
        public static delegate* unmanaged<VkDevice, VkImportFenceSciSyncInfoNV*, VkResult> _vkImportFenceSciSyncFenceNV_fnptr = &vkImportFenceSciSyncFenceNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkImportFenceSciSyncFenceNV_Lazy(VkDevice device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo)
        {
            _vkImportFenceSciSyncFenceNV_fnptr = (delegate* unmanaged<VkDevice, VkImportFenceSciSyncInfoNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkImportFenceSciSyncFenceNV");
            return _vkImportFenceSciSyncFenceNV_fnptr(device, pImportFenceSciSyncInfo);
        }
        public static delegate* unmanaged<VkDevice, VkImportFenceSciSyncInfoNV*, VkResult> _vkImportFenceSciSyncObjNV_fnptr = &vkImportFenceSciSyncObjNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkImportFenceSciSyncObjNV_Lazy(VkDevice device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo)
        {
            _vkImportFenceSciSyncObjNV_fnptr = (delegate* unmanaged<VkDevice, VkImportFenceSciSyncInfoNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkImportFenceSciSyncObjNV");
            return _vkImportFenceSciSyncObjNV_fnptr(device, pImportFenceSciSyncInfo);
        }
        public static delegate* unmanaged<VkDevice, VkSemaphoreGetSciSyncInfoNV*, void*, VkResult> _vkGetSemaphoreSciSyncObjNV_fnptr = &vkGetSemaphoreSciSyncObjNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetSemaphoreSciSyncObjNV_Lazy(VkDevice device, VkSemaphoreGetSciSyncInfoNV* pGetSciSyncInfo, void* pHandle)
        {
            _vkGetSemaphoreSciSyncObjNV_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreGetSciSyncInfoNV*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetSemaphoreSciSyncObjNV");
            return _vkGetSemaphoreSciSyncObjNV_fnptr(device, pGetSciSyncInfo, pHandle);
        }
        public static delegate* unmanaged<VkDevice, VkImportSemaphoreSciSyncInfoNV*, VkResult> _vkImportSemaphoreSciSyncObjNV_fnptr = &vkImportSemaphoreSciSyncObjNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkImportSemaphoreSciSyncObjNV_Lazy(VkDevice device, VkImportSemaphoreSciSyncInfoNV* pImportSemaphoreSciSyncInfo)
        {
            _vkImportSemaphoreSciSyncObjNV_fnptr = (delegate* unmanaged<VkDevice, VkImportSemaphoreSciSyncInfoNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkImportSemaphoreSciSyncObjNV");
            return _vkImportSemaphoreSciSyncObjNV_fnptr(device, pImportSemaphoreSciSyncInfo);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkSciSyncAttributesInfoNV*, IntPtr, VkResult> _vkGetPhysicalDeviceSciSyncAttributesNV_fnptr = &vkGetPhysicalDeviceSciSyncAttributesNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceSciSyncAttributesNV_Lazy(VkPhysicalDevice physicalDevice, VkSciSyncAttributesInfoNV* pSciSyncAttributesInfo, IntPtr pAttributes)
        {
            _vkGetPhysicalDeviceSciSyncAttributesNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSciSyncAttributesInfoNV*, IntPtr, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSciSyncAttributesNV");
            return _vkGetPhysicalDeviceSciSyncAttributesNV_fnptr(physicalDevice, pSciSyncAttributesInfo, pAttributes);
        }
        public static delegate* unmanaged<VkDevice, VkSemaphoreSciSyncPoolCreateInfoNV*, VkAllocationCallbacks*, VkSemaphoreSciSyncPoolNV*, VkResult> _vkCreateSemaphoreSciSyncPoolNV_fnptr = &vkCreateSemaphoreSciSyncPoolNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateSemaphoreSciSyncPoolNV_Lazy(VkDevice device, VkSemaphoreSciSyncPoolCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphoreSciSyncPoolNV* pSemaphorePool)
        {
            _vkCreateSemaphoreSciSyncPoolNV_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreSciSyncPoolCreateInfoNV*, VkAllocationCallbacks*, VkSemaphoreSciSyncPoolNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateSemaphoreSciSyncPoolNV");
            return _vkCreateSemaphoreSciSyncPoolNV_fnptr(device, pCreateInfo, pAllocator, pSemaphorePool);
        }
        public static delegate* unmanaged<VkDevice, VkSemaphoreSciSyncPoolNV, VkAllocationCallbacks*, void> _vkDestroySemaphoreSciSyncPoolNV_fnptr = &vkDestroySemaphoreSciSyncPoolNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroySemaphoreSciSyncPoolNV_Lazy(VkDevice device, VkSemaphoreSciSyncPoolNV semaphorePool, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySemaphoreSciSyncPoolNV_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreSciSyncPoolNV, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroySemaphoreSciSyncPoolNV");
            _vkDestroySemaphoreSciSyncPoolNV_fnptr(device, semaphorePool, pAllocator);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult> _vkReleaseDisplayEXT_fnptr = &vkReleaseDisplayEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkReleaseDisplayEXT_Lazy(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
        {
            _vkReleaseDisplayEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult>)VKLoader.GetInstanceProcAddress("vkReleaseDisplayEXT");
            return _vkReleaseDisplayEXT_fnptr(physicalDevice, display);
        }
        public static delegate* unmanaged<VkPhysicalDevice, IntPtr, VkDisplayKHR, VkResult> _vkAcquireXlibDisplayEXT_fnptr = &vkAcquireXlibDisplayEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkAcquireXlibDisplayEXT_Lazy(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display)
        {
            _vkAcquireXlibDisplayEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, IntPtr, VkDisplayKHR, VkResult>)VKLoader.GetInstanceProcAddress("vkAcquireXlibDisplayEXT");
            return _vkAcquireXlibDisplayEXT_fnptr(physicalDevice, dpy, display);
        }
        public static delegate* unmanaged<VkPhysicalDevice, IntPtr, nuint, VkDisplayKHR*, VkResult> _vkGetRandROutputDisplayEXT_fnptr = &vkGetRandROutputDisplayEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetRandROutputDisplayEXT_Lazy(VkPhysicalDevice physicalDevice, IntPtr dpy, nuint rrOutput, VkDisplayKHR* pDisplay)
        {
            _vkGetRandROutputDisplayEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, IntPtr, nuint, VkDisplayKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetRandROutputDisplayEXT");
            return _vkGetRandROutputDisplayEXT_fnptr(physicalDevice, dpy, rrOutput, pDisplay);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult> _vkAcquireWinrtDisplayNV_fnptr = &vkAcquireWinrtDisplayNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkAcquireWinrtDisplayNV_Lazy(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
        {
            _vkAcquireWinrtDisplayNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult>)VKLoader.GetInstanceProcAddress("vkAcquireWinrtDisplayNV");
            return _vkAcquireWinrtDisplayNV_fnptr(physicalDevice, display);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint, VkDisplayKHR*, VkResult> _vkGetWinrtDisplayNV_fnptr = &vkGetWinrtDisplayNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetWinrtDisplayNV_Lazy(VkPhysicalDevice physicalDevice, uint deviceRelativeId, VkDisplayKHR* pDisplay)
        {
            _vkGetWinrtDisplayNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, VkDisplayKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetWinrtDisplayNV");
            return _vkGetWinrtDisplayNV_fnptr(physicalDevice, deviceRelativeId, pDisplay);
        }
        public static delegate* unmanaged<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult> _vkDisplayPowerControlEXT_fnptr = &vkDisplayPowerControlEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkDisplayPowerControlEXT_Lazy(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo)
        {
            _vkDisplayPowerControlEXT_fnptr = (delegate* unmanaged<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkDisplayPowerControlEXT");
            return _vkDisplayPowerControlEXT_fnptr(device, display, pDisplayPowerInfo);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> _vkRegisterDeviceEventEXT_fnptr = &vkRegisterDeviceEventEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkRegisterDeviceEventEXT_Lazy(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            _vkRegisterDeviceEventEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult>)VKLoader.GetInstanceProcAddress("vkRegisterDeviceEventEXT");
            return _vkRegisterDeviceEventEXT_fnptr(device, pDeviceEventInfo, pAllocator, pFence);
        }
        public static delegate* unmanaged<VkDevice, VkDisplayKHR, VkDisplayEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> _vkRegisterDisplayEventEXT_fnptr = &vkRegisterDisplayEventEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkRegisterDisplayEventEXT_Lazy(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            _vkRegisterDisplayEventEXT_fnptr = (delegate* unmanaged<VkDevice, VkDisplayKHR, VkDisplayEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult>)VKLoader.GetInstanceProcAddress("vkRegisterDisplayEventEXT");
            return _vkRegisterDisplayEventEXT_fnptr(device, display, pDisplayEventInfo, pAllocator, pFence);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagBitsEXT, ulong*, VkResult> _vkGetSwapchainCounterEXT_fnptr = &vkGetSwapchainCounterEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetSwapchainCounterEXT_Lazy(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue)
        {
            _vkGetSwapchainCounterEXT_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagBitsEXT, ulong*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetSwapchainCounterEXT");
            return _vkGetSwapchainCounterEXT_fnptr(device, swapchain, counter, pCounterValue);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult> _vkGetPhysicalDeviceSurfaceCapabilities2EXT_fnptr = &vkGetPhysicalDeviceSurfaceCapabilities2EXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT_Lazy(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
        {
            _vkGetPhysicalDeviceSurfaceCapabilities2EXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSurfaceCapabilities2EXT");
            return _vkGetPhysicalDeviceSurfaceCapabilities2EXT_fnptr(physicalDevice, surface, pSurfaceCapabilities);
        }
        public static delegate* unmanaged<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult> _vkEnumeratePhysicalDeviceGroups_fnptr = &vkEnumeratePhysicalDeviceGroups_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkEnumeratePhysicalDeviceGroups_Lazy(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
        {
            _vkEnumeratePhysicalDeviceGroups_fnptr = (delegate* unmanaged<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult>)VKLoader.GetInstanceProcAddress("vkEnumeratePhysicalDeviceGroups");
            return _vkEnumeratePhysicalDeviceGroups_fnptr(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
        }
        public static delegate* unmanaged<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlagBits*, void> _vkGetDeviceGroupPeerMemoryFeatures_fnptr = &vkGetDeviceGroupPeerMemoryFeatures_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDeviceGroupPeerMemoryFeatures_Lazy(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlagBits* pPeerMemoryFeatures)
        {
            _vkGetDeviceGroupPeerMemoryFeatures_fnptr = (delegate* unmanaged<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlagBits*, void>)VKLoader.GetInstanceProcAddress("vkGetDeviceGroupPeerMemoryFeatures");
            _vkGetDeviceGroupPeerMemoryFeatures_fnptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
        }
        public static delegate* unmanaged<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> _vkBindBufferMemory2_fnptr = &vkBindBufferMemory2_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkBindBufferMemory2_Lazy(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
        {
            _vkBindBufferMemory2_fnptr = (delegate* unmanaged<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult>)VKLoader.GetInstanceProcAddress("vkBindBufferMemory2");
            return _vkBindBufferMemory2_fnptr(device, bindInfoCount, pBindInfos);
        }
        public static delegate* unmanaged<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> _vkBindImageMemory2_fnptr = &vkBindImageMemory2_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkBindImageMemory2_Lazy(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
        {
            _vkBindImageMemory2_fnptr = (delegate* unmanaged<VkDevice, uint, VkBindImageMemoryInfo*, VkResult>)VKLoader.GetInstanceProcAddress("vkBindImageMemory2");
            return _vkBindImageMemory2_fnptr(device, bindInfoCount, pBindInfos);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, void> _vkCmdSetDeviceMask_fnptr = &vkCmdSetDeviceMask_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDeviceMask_Lazy(VkCommandBuffer commandBuffer, uint deviceMask)
        {
            _vkCmdSetDeviceMask_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDeviceMask");
            _vkCmdSetDeviceMask_fnptr(commandBuffer, deviceMask);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult> _vkGetDeviceGroupPresentCapabilitiesKHR_fnptr = &vkGetDeviceGroupPresentCapabilitiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDeviceGroupPresentCapabilitiesKHR_Lazy(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities)
        {
            _vkGetDeviceGroupPresentCapabilitiesKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDeviceGroupPresentCapabilitiesKHR");
            return _vkGetDeviceGroupPresentCapabilitiesKHR_fnptr(device, pDeviceGroupPresentCapabilities);
        }
        public static delegate* unmanaged<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagBitsKHR*, VkResult> _vkGetDeviceGroupSurfacePresentModesKHR_fnptr = &vkGetDeviceGroupSurfacePresentModesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDeviceGroupSurfacePresentModesKHR_Lazy(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagBitsKHR* pModes)
        {
            _vkGetDeviceGroupSurfacePresentModesKHR_fnptr = (delegate* unmanaged<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagBitsKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDeviceGroupSurfacePresentModesKHR");
            return _vkGetDeviceGroupSurfacePresentModesKHR_fnptr(device, surface, pModes);
        }
        public static delegate* unmanaged<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult> _vkAcquireNextImage2KHR_fnptr = &vkAcquireNextImage2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkAcquireNextImage2KHR_Lazy(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex)
        {
            _vkAcquireNextImage2KHR_fnptr = (delegate* unmanaged<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult>)VKLoader.GetInstanceProcAddress("vkAcquireNextImage2KHR");
            return _vkAcquireNextImage2KHR_fnptr(device, pAcquireInfo, pImageIndex);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void> _vkCmdDispatchBase_fnptr = &vkCmdDispatchBase_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDispatchBase_Lazy(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            _vkCmdDispatchBase_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDispatchBase");
            _vkCmdDispatchBase_fnptr(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult> _vkGetPhysicalDevicePresentRectanglesKHR_fnptr = &vkGetPhysicalDevicePresentRectanglesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDevicePresentRectanglesKHR_Lazy(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects)
        {
            _vkGetPhysicalDevicePresentRectanglesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDevicePresentRectanglesKHR");
            return _vkGetPhysicalDevicePresentRectanglesKHR_fnptr(physicalDevice, surface, pRectCount, pRects);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult> _vkCreateDescriptorUpdateTemplate_fnptr = &vkCreateDescriptorUpdateTemplate_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateDescriptorUpdateTemplate_Lazy(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate)
        {
            _vkCreateDescriptorUpdateTemplate_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateDescriptorUpdateTemplate");
            return _vkCreateDescriptorUpdateTemplate_fnptr(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> _vkDestroyDescriptorUpdateTemplate_fnptr = &vkDestroyDescriptorUpdateTemplate_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyDescriptorUpdateTemplate_Lazy(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDescriptorUpdateTemplate_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyDescriptorUpdateTemplate");
            _vkDestroyDescriptorUpdateTemplate_fnptr(device, descriptorUpdateTemplate, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> _vkUpdateDescriptorSetWithTemplate_fnptr = &vkUpdateDescriptorSetWithTemplate_Lazy;
        [UnmanagedCallersOnly]
        private static void vkUpdateDescriptorSetWithTemplate_Lazy(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
        {
            _vkUpdateDescriptorSetWithTemplate_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void>)VKLoader.GetInstanceProcAddress("vkUpdateDescriptorSetWithTemplate");
            _vkUpdateDescriptorSetWithTemplate_fnptr(device, descriptorSet, descriptorUpdateTemplate, pData);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> _vkCmdPushDescriptorSetWithTemplateKHR_fnptr = &vkCmdPushDescriptorSetWithTemplateKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdPushDescriptorSetWithTemplateKHR_Lazy(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
        {
            _vkCmdPushDescriptorSetWithTemplateKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void>)VKLoader.GetInstanceProcAddress("vkCmdPushDescriptorSetWithTemplateKHR");
            _vkCmdPushDescriptorSetWithTemplateKHR_fnptr(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
        }
        public static delegate* unmanaged<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void> _vkSetHdrMetadataEXT_fnptr = &vkSetHdrMetadataEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkSetHdrMetadataEXT_Lazy(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata)
        {
            _vkSetHdrMetadataEXT_fnptr = (delegate* unmanaged<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void>)VKLoader.GetInstanceProcAddress("vkSetHdrMetadataEXT");
            _vkSetHdrMetadataEXT_fnptr(device, swapchainCount, pSwapchains, pMetadata);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult> _vkGetSwapchainStatusKHR_fnptr = &vkGetSwapchainStatusKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetSwapchainStatusKHR_Lazy(VkDevice device, VkSwapchainKHR swapchain)
        {
            _vkGetSwapchainStatusKHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult>)VKLoader.GetInstanceProcAddress("vkGetSwapchainStatusKHR");
            return _vkGetSwapchainStatusKHR_fnptr(device, swapchain);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult> _vkGetRefreshCycleDurationGOOGLE_fnptr = &vkGetRefreshCycleDurationGOOGLE_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetRefreshCycleDurationGOOGLE_Lazy(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties)
        {
            _vkGetRefreshCycleDurationGOOGLE_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetRefreshCycleDurationGOOGLE");
            return _vkGetRefreshCycleDurationGOOGLE_fnptr(device, swapchain, pDisplayTimingProperties);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, uint*, VkPastPresentationTimingGOOGLE*, VkResult> _vkGetPastPresentationTimingGOOGLE_fnptr = &vkGetPastPresentationTimingGOOGLE_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPastPresentationTimingGOOGLE_Lazy(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
        {
            _vkGetPastPresentationTimingGOOGLE_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, uint*, VkPastPresentationTimingGOOGLE*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPastPresentationTimingGOOGLE");
            return _vkGetPastPresentationTimingGOOGLE_fnptr(device, swapchain, pPresentationTimingCount, pPresentationTimings);
        }
        public static delegate* unmanaged<VkInstance, VkIOSSurfaceCreateInfoMVK*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateIOSSurfaceMVK_fnptr = &vkCreateIOSSurfaceMVK_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateIOSSurfaceMVK_Lazy(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateIOSSurfaceMVK_fnptr = (delegate* unmanaged<VkInstance, VkIOSSurfaceCreateInfoMVK*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateIOSSurfaceMVK");
            return _vkCreateIOSSurfaceMVK_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkInstance, VkMacOSSurfaceCreateInfoMVK*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateMacOSSurfaceMVK_fnptr = &vkCreateMacOSSurfaceMVK_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateMacOSSurfaceMVK_Lazy(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateMacOSSurfaceMVK_fnptr = (delegate* unmanaged<VkInstance, VkMacOSSurfaceCreateInfoMVK*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateMacOSSurfaceMVK");
            return _vkCreateMacOSSurfaceMVK_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkInstance, VkMetalSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateMetalSurfaceEXT_fnptr = &vkCreateMetalSurfaceEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateMetalSurfaceEXT_Lazy(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateMetalSurfaceEXT_fnptr = (delegate* unmanaged<VkInstance, VkMetalSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateMetalSurfaceEXT");
            return _vkCreateMetalSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewportWScalingNV*, void> _vkCmdSetViewportWScalingNV_fnptr = &vkCmdSetViewportWScalingNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetViewportWScalingNV_Lazy(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
        {
            _vkCmdSetViewportWScalingNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewportWScalingNV*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetViewportWScalingNV");
            _vkCmdSetViewportWScalingNV_fnptr(commandBuffer, firstViewport, viewportCount, pViewportWScalings);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void> _vkCmdSetDiscardRectangleEXT_fnptr = &vkCmdSetDiscardRectangleEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDiscardRectangleEXT_Lazy(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
        {
            _vkCmdSetDiscardRectangleEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDiscardRectangleEXT");
            _vkCmdSetDiscardRectangleEXT_fnptr(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDiscardRectangleEnableEXT_fnptr = &vkCmdSetDiscardRectangleEnableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDiscardRectangleEnableEXT_Lazy(VkCommandBuffer commandBuffer, int discardRectangleEnable)
        {
            _vkCmdSetDiscardRectangleEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDiscardRectangleEnableEXT");
            _vkCmdSetDiscardRectangleEnableEXT_fnptr(commandBuffer, discardRectangleEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkDiscardRectangleModeEXT, void> _vkCmdSetDiscardRectangleModeEXT_fnptr = &vkCmdSetDiscardRectangleModeEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDiscardRectangleModeEXT_Lazy(VkCommandBuffer commandBuffer, VkDiscardRectangleModeEXT discardRectangleMode)
        {
            _vkCmdSetDiscardRectangleModeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDiscardRectangleModeEXT, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDiscardRectangleModeEXT");
            _vkCmdSetDiscardRectangleModeEXT_fnptr(commandBuffer, discardRectangleMode);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkSampleLocationsInfoEXT*, void> _vkCmdSetSampleLocationsEXT_fnptr = &vkCmdSetSampleLocationsEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetSampleLocationsEXT_Lazy(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo)
        {
            _vkCmdSetSampleLocationsEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSampleLocationsInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetSampleLocationsEXT");
            _vkCmdSetSampleLocationsEXT_fnptr(commandBuffer, pSampleLocationsInfo);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkSampleCountFlagBits, VkMultisamplePropertiesEXT*, void> _vkGetPhysicalDeviceMultisamplePropertiesEXT_fnptr = &vkGetPhysicalDeviceMultisamplePropertiesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceMultisamplePropertiesEXT_Lazy(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT* pMultisampleProperties)
        {
            _vkGetPhysicalDeviceMultisamplePropertiesEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSampleCountFlagBits, VkMultisamplePropertiesEXT*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceMultisamplePropertiesEXT");
            _vkGetPhysicalDeviceMultisamplePropertiesEXT_fnptr(physicalDevice, samples, pMultisampleProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkSurfaceCapabilities2KHR*, VkResult> _vkGetPhysicalDeviceSurfaceCapabilities2KHR_fnptr = &vkGetPhysicalDeviceSurfaceCapabilities2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
        {
            _vkGetPhysicalDeviceSurfaceCapabilities2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkSurfaceCapabilities2KHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSurfaceCapabilities2KHR");
            return _vkGetPhysicalDeviceSurfaceCapabilities2KHR_fnptr(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkSurfaceFormat2KHR*, VkResult> _vkGetPhysicalDeviceSurfaceFormats2KHR_fnptr = &vkGetPhysicalDeviceSurfaceFormats2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceSurfaceFormats2KHR_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            _vkGetPhysicalDeviceSurfaceFormats2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkSurfaceFormat2KHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSurfaceFormats2KHR");
            return _vkGetPhysicalDeviceSurfaceFormats2KHR_fnptr(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayProperties2KHR*, VkResult> _vkGetPhysicalDeviceDisplayProperties2KHR_fnptr = &vkGetPhysicalDeviceDisplayProperties2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceDisplayProperties2KHR_Lazy(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties)
        {
            _vkGetPhysicalDeviceDisplayProperties2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayProperties2KHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceDisplayProperties2KHR");
            return _vkGetPhysicalDeviceDisplayProperties2KHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPlaneProperties2KHR*, VkResult> _vkGetPhysicalDeviceDisplayPlaneProperties2KHR_fnptr = &vkGetPhysicalDeviceDisplayPlaneProperties2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR_Lazy(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
        {
            _vkGetPhysicalDeviceDisplayPlaneProperties2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPlaneProperties2KHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceDisplayPlaneProperties2KHR");
            return _vkGetPhysicalDeviceDisplayPlaneProperties2KHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModeProperties2KHR*, VkResult> _vkGetDisplayModeProperties2KHR_fnptr = &vkGetDisplayModeProperties2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDisplayModeProperties2KHR_Lazy(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
        {
            _vkGetDisplayModeProperties2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModeProperties2KHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDisplayModeProperties2KHR");
            return _vkGetDisplayModeProperties2KHR_fnptr(physicalDevice, display, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkDisplayPlaneInfo2KHR*, VkDisplayPlaneCapabilities2KHR*, VkResult> _vkGetDisplayPlaneCapabilities2KHR_fnptr = &vkGetDisplayPlaneCapabilities2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDisplayPlaneCapabilities2KHR_Lazy(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
        {
            _vkGetDisplayPlaneCapabilities2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayPlaneInfo2KHR*, VkDisplayPlaneCapabilities2KHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDisplayPlaneCapabilities2KHR");
            return _vkGetDisplayPlaneCapabilities2KHR_fnptr(physicalDevice, pDisplayPlaneInfo, pCapabilities);
        }
        public static delegate* unmanaged<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> _vkGetBufferMemoryRequirements2_fnptr = &vkGetBufferMemoryRequirements2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetBufferMemoryRequirements2_Lazy(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetBufferMemoryRequirements2_fnptr = (delegate* unmanaged<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>)VKLoader.GetInstanceProcAddress("vkGetBufferMemoryRequirements2");
            _vkGetBufferMemoryRequirements2_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static delegate* unmanaged<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> _vkGetImageMemoryRequirements2_fnptr = &vkGetImageMemoryRequirements2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetImageMemoryRequirements2_Lazy(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetImageMemoryRequirements2_fnptr = (delegate* unmanaged<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>)VKLoader.GetInstanceProcAddress("vkGetImageMemoryRequirements2");
            _vkGetImageMemoryRequirements2_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static delegate* unmanaged<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void> _vkGetImageSparseMemoryRequirements2_fnptr = &vkGetImageSparseMemoryRequirements2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetImageSparseMemoryRequirements2_Lazy(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            _vkGetImageSparseMemoryRequirements2_fnptr = (delegate* unmanaged<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void>)VKLoader.GetInstanceProcAddress("vkGetImageSparseMemoryRequirements2");
            _vkGetImageSparseMemoryRequirements2_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> _vkGetDeviceBufferMemoryRequirements_fnptr = &vkGetDeviceBufferMemoryRequirements_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDeviceBufferMemoryRequirements_Lazy(VkDevice device, VkDeviceBufferMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetDeviceBufferMemoryRequirements_fnptr = (delegate* unmanaged<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void>)VKLoader.GetInstanceProcAddress("vkGetDeviceBufferMemoryRequirements");
            _vkGetDeviceBufferMemoryRequirements_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> _vkGetDeviceImageMemoryRequirements_fnptr = &vkGetDeviceImageMemoryRequirements_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDeviceImageMemoryRequirements_Lazy(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetDeviceImageMemoryRequirements_fnptr = (delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void>)VKLoader.GetInstanceProcAddress("vkGetDeviceImageMemoryRequirements");
            _vkGetDeviceImageMemoryRequirements_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void> _vkGetDeviceImageSparseMemoryRequirements_fnptr = &vkGetDeviceImageSparseMemoryRequirements_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDeviceImageSparseMemoryRequirements_Lazy(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            _vkGetDeviceImageSparseMemoryRequirements_fnptr = (delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void>)VKLoader.GetInstanceProcAddress("vkGetDeviceImageSparseMemoryRequirements");
            _vkGetDeviceImageSparseMemoryRequirements_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        public static delegate* unmanaged<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult> _vkCreateSamplerYcbcrConversion_fnptr = &vkCreateSamplerYcbcrConversion_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateSamplerYcbcrConversion_Lazy(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion)
        {
            _vkCreateSamplerYcbcrConversion_fnptr = (delegate* unmanaged<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateSamplerYcbcrConversion");
            return _vkCreateSamplerYcbcrConversion_fnptr(device, pCreateInfo, pAllocator, pYcbcrConversion);
        }
        public static delegate* unmanaged<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> _vkDestroySamplerYcbcrConversion_fnptr = &vkDestroySamplerYcbcrConversion_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroySamplerYcbcrConversion_Lazy(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySamplerYcbcrConversion_fnptr = (delegate* unmanaged<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroySamplerYcbcrConversion");
            _vkDestroySamplerYcbcrConversion_fnptr(device, ycbcrConversion, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceQueueInfo2*, VkQueue*, void> _vkGetDeviceQueue2_fnptr = &vkGetDeviceQueue2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDeviceQueue2_Lazy(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue)
        {
            _vkGetDeviceQueue2_fnptr = (delegate* unmanaged<VkDevice, VkDeviceQueueInfo2*, VkQueue*, void>)VKLoader.GetInstanceProcAddress("vkGetDeviceQueue2");
            _vkGetDeviceQueue2_fnptr(device, pQueueInfo, pQueue);
        }
        public static delegate* unmanaged<VkDevice, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, VkValidationCacheEXT*, VkResult> _vkCreateValidationCacheEXT_fnptr = &vkCreateValidationCacheEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateValidationCacheEXT_Lazy(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            _vkCreateValidationCacheEXT_fnptr = (delegate* unmanaged<VkDevice, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, VkValidationCacheEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateValidationCacheEXT");
            return _vkCreateValidationCacheEXT_fnptr(device, pCreateInfo, pAllocator, pValidationCache);
        }
        public static delegate* unmanaged<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void> _vkDestroyValidationCacheEXT_fnptr = &vkDestroyValidationCacheEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyValidationCacheEXT_Lazy(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyValidationCacheEXT_fnptr = (delegate* unmanaged<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyValidationCacheEXT");
            _vkDestroyValidationCacheEXT_fnptr(device, validationCache, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkValidationCacheEXT, nuint*, void*, VkResult> _vkGetValidationCacheDataEXT_fnptr = &vkGetValidationCacheDataEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetValidationCacheDataEXT_Lazy(VkDevice device, VkValidationCacheEXT validationCache, nuint* pDataSize, void* pData)
        {
            _vkGetValidationCacheDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkValidationCacheEXT, nuint*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetValidationCacheDataEXT");
            return _vkGetValidationCacheDataEXT_fnptr(device, validationCache, pDataSize, pData);
        }
        public static delegate* unmanaged<VkDevice, VkValidationCacheEXT, uint, VkValidationCacheEXT*, VkResult> _vkMergeValidationCachesEXT_fnptr = &vkMergeValidationCachesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkMergeValidationCachesEXT_Lazy(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches)
        {
            _vkMergeValidationCachesEXT_fnptr = (delegate* unmanaged<VkDevice, VkValidationCacheEXT, uint, VkValidationCacheEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkMergeValidationCachesEXT");
            return _vkMergeValidationCachesEXT_fnptr(device, dstCache, srcCacheCount, pSrcCaches);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void> _vkGetDescriptorSetLayoutSupport_fnptr = &vkGetDescriptorSetLayoutSupport_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDescriptorSetLayoutSupport_Lazy(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
        {
            _vkGetDescriptorSetLayoutSupport_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void>)VKLoader.GetInstanceProcAddress("vkGetDescriptorSetLayoutSupport");
            _vkGetDescriptorSetLayoutSupport_fnptr(device, pCreateInfo, pSupport);
        }
        public static delegate* unmanaged<VkDevice, VkFormat, VkImageUsageFlagBits, int*, VkResult> _vkGetSwapchainGrallocUsageANDROID_fnptr = &vkGetSwapchainGrallocUsageANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetSwapchainGrallocUsageANDROID_Lazy(VkDevice device, VkFormat format, VkImageUsageFlagBits imageUsage, int* grallocUsage)
        {
            _vkGetSwapchainGrallocUsageANDROID_fnptr = (delegate* unmanaged<VkDevice, VkFormat, VkImageUsageFlagBits, int*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetSwapchainGrallocUsageANDROID");
            return _vkGetSwapchainGrallocUsageANDROID_fnptr(device, format, imageUsage, grallocUsage);
        }
        public static delegate* unmanaged<VkDevice, VkFormat, VkImageUsageFlagBits, VkSwapchainImageUsageFlagBitsANDROID, ulong*, ulong*, VkResult> _vkGetSwapchainGrallocUsage2ANDROID_fnptr = &vkGetSwapchainGrallocUsage2ANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetSwapchainGrallocUsage2ANDROID_Lazy(VkDevice device, VkFormat format, VkImageUsageFlagBits imageUsage, VkSwapchainImageUsageFlagBitsANDROID swapchainImageUsage, ulong* grallocConsumerUsage, ulong* grallocProducerUsage)
        {
            _vkGetSwapchainGrallocUsage2ANDROID_fnptr = (delegate* unmanaged<VkDevice, VkFormat, VkImageUsageFlagBits, VkSwapchainImageUsageFlagBitsANDROID, ulong*, ulong*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetSwapchainGrallocUsage2ANDROID");
            return _vkGetSwapchainGrallocUsage2ANDROID_fnptr(device, format, imageUsage, swapchainImageUsage, grallocConsumerUsage, grallocProducerUsage);
        }
        public static delegate* unmanaged<VkDevice, VkImage, int, VkSemaphore, VkFence, VkResult> _vkAcquireImageANDROID_fnptr = &vkAcquireImageANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkAcquireImageANDROID_Lazy(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence)
        {
            _vkAcquireImageANDROID_fnptr = (delegate* unmanaged<VkDevice, VkImage, int, VkSemaphore, VkFence, VkResult>)VKLoader.GetInstanceProcAddress("vkAcquireImageANDROID");
            return _vkAcquireImageANDROID_fnptr(device, image, nativeFenceFd, semaphore, fence);
        }
        public static delegate* unmanaged<VkQueue, uint, VkSemaphore*, VkImage, int*, VkResult> _vkQueueSignalReleaseImageANDROID_fnptr = &vkQueueSignalReleaseImageANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkQueueSignalReleaseImageANDROID_Lazy(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, int* pNativeFenceFd)
        {
            _vkQueueSignalReleaseImageANDROID_fnptr = (delegate* unmanaged<VkQueue, uint, VkSemaphore*, VkImage, int*, VkResult>)VKLoader.GetInstanceProcAddress("vkQueueSignalReleaseImageANDROID");
            return _vkQueueSignalReleaseImageANDROID_fnptr(queue, waitSemaphoreCount, pWaitSemaphores, image, pNativeFenceFd);
        }
        public static delegate* unmanaged<VkDevice, VkPipeline, VkShaderStageFlagBits, VkShaderInfoTypeAMD, nuint*, void*, VkResult> _vkGetShaderInfoAMD_fnptr = &vkGetShaderInfoAMD_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetShaderInfoAMD_Lazy(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, nuint* pInfoSize, void* pInfo)
        {
            _vkGetShaderInfoAMD_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, VkShaderStageFlagBits, VkShaderInfoTypeAMD, nuint*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetShaderInfoAMD");
            return _vkGetShaderInfoAMD_fnptr(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, int, void> _vkSetLocalDimmingAMD_fnptr = &vkSetLocalDimmingAMD_Lazy;
        [UnmanagedCallersOnly]
        private static void vkSetLocalDimmingAMD_Lazy(VkDevice device, VkSwapchainKHR swapChain, int localDimmingEnable)
        {
            _vkSetLocalDimmingAMD_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, int, void>)VKLoader.GetInstanceProcAddress("vkSetLocalDimmingAMD");
            _vkSetLocalDimmingAMD_fnptr(device, swapChain, localDimmingEnable);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkTimeDomainKHR*, VkResult> _vkGetPhysicalDeviceCalibrateableTimeDomainsKHR_fnptr = &vkGetPhysicalDeviceCalibrateableTimeDomainsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsKHR_Lazy(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainKHR* pTimeDomains)
        {
            _vkGetPhysicalDeviceCalibrateableTimeDomainsKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkTimeDomainKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceCalibrateableTimeDomainsKHR");
            return _vkGetPhysicalDeviceCalibrateableTimeDomainsKHR_fnptr(physicalDevice, pTimeDomainCount, pTimeDomains);
        }
        public static delegate* unmanaged<VkDevice, uint, VkCalibratedTimestampInfoKHR*, ulong*, ulong*, VkResult> _vkGetCalibratedTimestampsKHR_fnptr = &vkGetCalibratedTimestampsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetCalibratedTimestampsKHR_Lazy(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoKHR* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
        {
            _vkGetCalibratedTimestampsKHR_fnptr = (delegate* unmanaged<VkDevice, uint, VkCalibratedTimestampInfoKHR*, ulong*, ulong*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetCalibratedTimestampsKHR");
            return _vkGetCalibratedTimestampsKHR_fnptr(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);
        }
        public static delegate* unmanaged<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult> _vkSetDebugUtilsObjectNameEXT_fnptr = &vkSetDebugUtilsObjectNameEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkSetDebugUtilsObjectNameEXT_Lazy(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo)
        {
            _vkSetDebugUtilsObjectNameEXT_fnptr = (delegate* unmanaged<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkSetDebugUtilsObjectNameEXT");
            return _vkSetDebugUtilsObjectNameEXT_fnptr(device, pNameInfo);
        }
        public static delegate* unmanaged<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult> _vkSetDebugUtilsObjectTagEXT_fnptr = &vkSetDebugUtilsObjectTagEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkSetDebugUtilsObjectTagEXT_Lazy(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo)
        {
            _vkSetDebugUtilsObjectTagEXT_fnptr = (delegate* unmanaged<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkSetDebugUtilsObjectTagEXT");
            return _vkSetDebugUtilsObjectTagEXT_fnptr(device, pTagInfo);
        }
        public static delegate* unmanaged<VkQueue, VkDebugUtilsLabelEXT*, void> _vkQueueBeginDebugUtilsLabelEXT_fnptr = &vkQueueBeginDebugUtilsLabelEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkQueueBeginDebugUtilsLabelEXT_Lazy(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            _vkQueueBeginDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<VkQueue, VkDebugUtilsLabelEXT*, void>)VKLoader.GetInstanceProcAddress("vkQueueBeginDebugUtilsLabelEXT");
            _vkQueueBeginDebugUtilsLabelEXT_fnptr(queue, pLabelInfo);
        }
        public static delegate* unmanaged<VkQueue, void> _vkQueueEndDebugUtilsLabelEXT_fnptr = &vkQueueEndDebugUtilsLabelEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkQueueEndDebugUtilsLabelEXT_Lazy(VkQueue queue)
        {
            _vkQueueEndDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<VkQueue, void>)VKLoader.GetInstanceProcAddress("vkQueueEndDebugUtilsLabelEXT");
            _vkQueueEndDebugUtilsLabelEXT_fnptr(queue);
        }
        public static delegate* unmanaged<VkQueue, VkDebugUtilsLabelEXT*, void> _vkQueueInsertDebugUtilsLabelEXT_fnptr = &vkQueueInsertDebugUtilsLabelEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkQueueInsertDebugUtilsLabelEXT_Lazy(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            _vkQueueInsertDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<VkQueue, VkDebugUtilsLabelEXT*, void>)VKLoader.GetInstanceProcAddress("vkQueueInsertDebugUtilsLabelEXT");
            _vkQueueInsertDebugUtilsLabelEXT_fnptr(queue, pLabelInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> _vkCmdBeginDebugUtilsLabelEXT_fnptr = &vkCmdBeginDebugUtilsLabelEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBeginDebugUtilsLabelEXT_Lazy(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            _vkCmdBeginDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdBeginDebugUtilsLabelEXT");
            _vkCmdBeginDebugUtilsLabelEXT_fnptr(commandBuffer, pLabelInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, void> _vkCmdEndDebugUtilsLabelEXT_fnptr = &vkCmdEndDebugUtilsLabelEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdEndDebugUtilsLabelEXT_Lazy(VkCommandBuffer commandBuffer)
        {
            _vkCmdEndDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetInstanceProcAddress("vkCmdEndDebugUtilsLabelEXT");
            _vkCmdEndDebugUtilsLabelEXT_fnptr(commandBuffer);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> _vkCmdInsertDebugUtilsLabelEXT_fnptr = &vkCmdInsertDebugUtilsLabelEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdInsertDebugUtilsLabelEXT_Lazy(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            _vkCmdInsertDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdInsertDebugUtilsLabelEXT");
            _vkCmdInsertDebugUtilsLabelEXT_fnptr(commandBuffer, pLabelInfo);
        }
        public static delegate* unmanaged<VkInstance, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, VkDebugUtilsMessengerEXT*, VkResult> _vkCreateDebugUtilsMessengerEXT_fnptr = &vkCreateDebugUtilsMessengerEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateDebugUtilsMessengerEXT_Lazy(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            _vkCreateDebugUtilsMessengerEXT_fnptr = (delegate* unmanaged<VkInstance, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, VkDebugUtilsMessengerEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateDebugUtilsMessengerEXT");
            return _vkCreateDebugUtilsMessengerEXT_fnptr(instance, pCreateInfo, pAllocator, pMessenger);
        }
        public static delegate* unmanaged<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void> _vkDestroyDebugUtilsMessengerEXT_fnptr = &vkDestroyDebugUtilsMessengerEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyDebugUtilsMessengerEXT_Lazy(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDebugUtilsMessengerEXT_fnptr = (delegate* unmanaged<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyDebugUtilsMessengerEXT");
            _vkDestroyDebugUtilsMessengerEXT_fnptr(instance, messenger, pAllocator);
        }
        public static delegate* unmanaged<VkInstance, VkDebugUtilsMessageSeverityFlagBitsEXT, VkDebugUtilsMessageTypeFlagBitsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void> _vkSubmitDebugUtilsMessageEXT_fnptr = &vkSubmitDebugUtilsMessageEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkSubmitDebugUtilsMessageEXT_Lazy(VkInstance instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagBitsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData)
        {
            _vkSubmitDebugUtilsMessageEXT_fnptr = (delegate* unmanaged<VkInstance, VkDebugUtilsMessageSeverityFlagBitsEXT, VkDebugUtilsMessageTypeFlagBitsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void>)VKLoader.GetInstanceProcAddress("vkSubmitDebugUtilsMessageEXT");
            _vkSubmitDebugUtilsMessageEXT_fnptr(instance, messageSeverity, messageTypes, pCallbackData);
        }
        public static delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, void*, VkMemoryHostPointerPropertiesEXT*, VkResult> _vkGetMemoryHostPointerPropertiesEXT_fnptr = &vkGetMemoryHostPointerPropertiesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetMemoryHostPointerPropertiesEXT_Lazy(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties)
        {
            _vkGetMemoryHostPointerPropertiesEXT_fnptr = (delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, void*, VkMemoryHostPointerPropertiesEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetMemoryHostPointerPropertiesEXT");
            return _vkGetMemoryHostPointerPropertiesEXT_fnptr(device, handleType, pHostPointer, pMemoryHostPointerProperties);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits, VkBuffer, ulong, uint, void> _vkCmdWriteBufferMarkerAMD_fnptr = &vkCmdWriteBufferMarkerAMD_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdWriteBufferMarkerAMD_Lazy(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
        {
            _vkCmdWriteBufferMarkerAMD_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits, VkBuffer, ulong, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdWriteBufferMarkerAMD");
            _vkCmdWriteBufferMarkerAMD_fnptr(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
        }
        public static delegate* unmanaged<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult> _vkCreateRenderPass2_fnptr = &vkCreateRenderPass2_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateRenderPass2_Lazy(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
        {
            _vkCreateRenderPass2_fnptr = (delegate* unmanaged<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateRenderPass2");
            return _vkCreateRenderPass2_fnptr(device, pCreateInfo, pAllocator, pRenderPass);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void> _vkCmdBeginRenderPass2_fnptr = &vkCmdBeginRenderPass2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBeginRenderPass2_Lazy(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo)
        {
            _vkCmdBeginRenderPass2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void>)VKLoader.GetInstanceProcAddress("vkCmdBeginRenderPass2");
            _vkCmdBeginRenderPass2_fnptr(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void> _vkCmdNextSubpass2_fnptr = &vkCmdNextSubpass2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdNextSubpass2_Lazy(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo)
        {
            _vkCmdNextSubpass2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void>)VKLoader.GetInstanceProcAddress("vkCmdNextSubpass2");
            _vkCmdNextSubpass2_fnptr(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkSubpassEndInfo*, void> _vkCmdEndRenderPass2_fnptr = &vkCmdEndRenderPass2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdEndRenderPass2_Lazy(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo)
        {
            _vkCmdEndRenderPass2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSubpassEndInfo*, void>)VKLoader.GetInstanceProcAddress("vkCmdEndRenderPass2");
            _vkCmdEndRenderPass2_fnptr(commandBuffer, pSubpassEndInfo);
        }
        public static delegate* unmanaged<VkDevice, VkSemaphore, ulong*, VkResult> _vkGetSemaphoreCounterValue_fnptr = &vkGetSemaphoreCounterValue_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetSemaphoreCounterValue_Lazy(VkDevice device, VkSemaphore semaphore, ulong* pValue)
        {
            _vkGetSemaphoreCounterValue_fnptr = (delegate* unmanaged<VkDevice, VkSemaphore, ulong*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetSemaphoreCounterValue");
            return _vkGetSemaphoreCounterValue_fnptr(device, semaphore, pValue);
        }
        public static delegate* unmanaged<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult> _vkWaitSemaphores_fnptr = &vkWaitSemaphores_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkWaitSemaphores_Lazy(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
        {
            _vkWaitSemaphores_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult>)VKLoader.GetInstanceProcAddress("vkWaitSemaphores");
            return _vkWaitSemaphores_fnptr(device, pWaitInfo, timeout);
        }
        public static delegate* unmanaged<VkDevice, VkSemaphoreSignalInfo*, VkResult> _vkSignalSemaphore_fnptr = &vkSignalSemaphore_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkSignalSemaphore_Lazy(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo)
        {
            _vkSignalSemaphore_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreSignalInfo*, VkResult>)VKLoader.GetInstanceProcAddress("vkSignalSemaphore");
            return _vkSignalSemaphore_fnptr(device, pSignalInfo);
        }
        public static delegate* unmanaged<VkDevice, IntPtr, VkAndroidHardwareBufferPropertiesANDROID*, VkResult> _vkGetAndroidHardwareBufferPropertiesANDROID_fnptr = &vkGetAndroidHardwareBufferPropertiesANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetAndroidHardwareBufferPropertiesANDROID_Lazy(VkDevice device, IntPtr buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
        {
            _vkGetAndroidHardwareBufferPropertiesANDROID_fnptr = (delegate* unmanaged<VkDevice, IntPtr, VkAndroidHardwareBufferPropertiesANDROID*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetAndroidHardwareBufferPropertiesANDROID");
            return _vkGetAndroidHardwareBufferPropertiesANDROID_fnptr(device, buffer, pProperties);
        }
        public static delegate* unmanaged<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, IntPtr*, VkResult> _vkGetMemoryAndroidHardwareBufferANDROID_fnptr = &vkGetMemoryAndroidHardwareBufferANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetMemoryAndroidHardwareBufferANDROID_Lazy(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, IntPtr* pBuffer)
        {
            _vkGetMemoryAndroidHardwareBufferANDROID_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, IntPtr*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetMemoryAndroidHardwareBufferANDROID");
            return _vkGetMemoryAndroidHardwareBufferANDROID_fnptr(device, pInfo, pBuffer);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndirectCount_fnptr = &vkCmdDrawIndirectCount_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawIndirectCount_Lazy(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            _vkCmdDrawIndirectCount_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawIndirectCount");
            _vkCmdDrawIndirectCount_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndexedIndirectCount_fnptr = &vkCmdDrawIndexedIndirectCount_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawIndexedIndirectCount_Lazy(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            _vkCmdDrawIndexedIndirectCount_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawIndexedIndirectCount");
            _vkCmdDrawIndexedIndirectCount_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        public static delegate* unmanaged<VkCommandBuffer, void*, void> _vkCmdSetCheckpointNV_fnptr = &vkCmdSetCheckpointNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetCheckpointNV_Lazy(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
        {
            _vkCmdSetCheckpointNV_fnptr = (delegate* unmanaged<VkCommandBuffer, void*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetCheckpointNV");
            _vkCmdSetCheckpointNV_fnptr(commandBuffer, pCheckpointMarker);
        }
        public static delegate* unmanaged<VkQueue, uint*, VkCheckpointDataNV*, void> _vkGetQueueCheckpointDataNV_fnptr = &vkGetQueueCheckpointDataNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetQueueCheckpointDataNV_Lazy(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
        {
            _vkGetQueueCheckpointDataNV_fnptr = (delegate* unmanaged<VkQueue, uint*, VkCheckpointDataNV*, void>)VKLoader.GetInstanceProcAddress("vkGetQueueCheckpointDataNV");
            _vkGetQueueCheckpointDataNV_fnptr(queue, pCheckpointDataCount, pCheckpointData);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, void> _vkCmdBindTransformFeedbackBuffersEXT_fnptr = &vkCmdBindTransformFeedbackBuffersEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindTransformFeedbackBuffersEXT_Lazy(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes)
        {
            _vkCmdBindTransformFeedbackBuffersEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, void>)VKLoader.GetInstanceProcAddress("vkCmdBindTransformFeedbackBuffersEXT");
            _vkCmdBindTransformFeedbackBuffersEXT_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> _vkCmdBeginTransformFeedbackEXT_fnptr = &vkCmdBeginTransformFeedbackEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBeginTransformFeedbackEXT_Lazy(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            _vkCmdBeginTransformFeedbackEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void>)VKLoader.GetInstanceProcAddress("vkCmdBeginTransformFeedbackEXT");
            _vkCmdBeginTransformFeedbackEXT_fnptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> _vkCmdEndTransformFeedbackEXT_fnptr = &vkCmdEndTransformFeedbackEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdEndTransformFeedbackEXT_Lazy(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            _vkCmdEndTransformFeedbackEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void>)VKLoader.GetInstanceProcAddress("vkCmdEndTransformFeedbackEXT");
            _vkCmdEndTransformFeedbackEXT_fnptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlagBits, uint, void> _vkCmdBeginQueryIndexedEXT_fnptr = &vkCmdBeginQueryIndexedEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBeginQueryIndexedEXT_Lazy(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlagBits flags, uint index)
        {
            _vkCmdBeginQueryIndexedEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlagBits, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdBeginQueryIndexedEXT");
            _vkCmdBeginQueryIndexedEXT_fnptr(commandBuffer, queryPool, query, flags, index);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, void> _vkCmdEndQueryIndexedEXT_fnptr = &vkCmdEndQueryIndexedEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdEndQueryIndexedEXT_Lazy(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index)
        {
            _vkCmdEndQueryIndexedEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdEndQueryIndexedEXT");
            _vkCmdEndQueryIndexedEXT_fnptr(commandBuffer, queryPool, query, index);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndirectByteCountEXT_fnptr = &vkCmdDrawIndirectByteCountEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawIndirectByteCountEXT_Lazy(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
        {
            _vkCmdDrawIndirectByteCountEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer, ulong, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawIndirectByteCountEXT");
            _vkCmdDrawIndirectByteCountEXT_fnptr(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void> _vkCmdSetExclusiveScissorNV_fnptr = &vkCmdSetExclusiveScissorNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetExclusiveScissorNV_Lazy(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
        {
            _vkCmdSetExclusiveScissorNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetExclusiveScissorNV");
            _vkCmdSetExclusiveScissorNV_fnptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, int*, void> _vkCmdSetExclusiveScissorEnableNV_fnptr = &vkCmdSetExclusiveScissorEnableNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetExclusiveScissorEnableNV_Lazy(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, int* pExclusiveScissorEnables)
        {
            _vkCmdSetExclusiveScissorEnableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, int*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetExclusiveScissorEnableNV");
            _vkCmdSetExclusiveScissorEnableNV_fnptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissorEnables);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void> _vkCmdBindShadingRateImageNV_fnptr = &vkCmdBindShadingRateImageNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindShadingRateImageNV_Lazy(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
        {
            _vkCmdBindShadingRateImageNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void>)VKLoader.GetInstanceProcAddress("vkCmdBindShadingRateImageNV");
            _vkCmdBindShadingRateImageNV_fnptr(commandBuffer, imageView, imageLayout);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void> _vkCmdSetViewportShadingRatePaletteNV_fnptr = &vkCmdSetViewportShadingRatePaletteNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetViewportShadingRatePaletteNV_Lazy(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
        {
            _vkCmdSetViewportShadingRatePaletteNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetViewportShadingRatePaletteNV");
            _vkCmdSetViewportShadingRatePaletteNV_fnptr(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void> _vkCmdSetCoarseSampleOrderNV_fnptr = &vkCmdSetCoarseSampleOrderNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetCoarseSampleOrderNV_Lazy(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
        {
            _vkCmdSetCoarseSampleOrderNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetCoarseSampleOrderNV");
            _vkCmdSetCoarseSampleOrderNV_fnptr(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, void> _vkCmdDrawMeshTasksNV_fnptr = &vkCmdDrawMeshTasksNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawMeshTasksNV_Lazy(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask)
        {
            _vkCmdDrawMeshTasksNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawMeshTasksNV");
            _vkCmdDrawMeshTasksNV_fnptr(commandBuffer, taskCount, firstTask);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> _vkCmdDrawMeshTasksIndirectNV_fnptr = &vkCmdDrawMeshTasksIndirectNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawMeshTasksIndirectNV_Lazy(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            _vkCmdDrawMeshTasksIndirectNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawMeshTasksIndirectNV");
            _vkCmdDrawMeshTasksIndirectNV_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> _vkCmdDrawMeshTasksIndirectCountNV_fnptr = &vkCmdDrawMeshTasksIndirectCountNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawMeshTasksIndirectCountNV_Lazy(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            _vkCmdDrawMeshTasksIndirectCountNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawMeshTasksIndirectCountNV");
            _vkCmdDrawMeshTasksIndirectCountNV_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void> _vkCmdDrawMeshTasksEXT_fnptr = &vkCmdDrawMeshTasksEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawMeshTasksEXT_Lazy(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            _vkCmdDrawMeshTasksEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawMeshTasksEXT");
            _vkCmdDrawMeshTasksEXT_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> _vkCmdDrawMeshTasksIndirectEXT_fnptr = &vkCmdDrawMeshTasksIndirectEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawMeshTasksIndirectEXT_Lazy(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            _vkCmdDrawMeshTasksIndirectEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawMeshTasksIndirectEXT");
            _vkCmdDrawMeshTasksIndirectEXT_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> _vkCmdDrawMeshTasksIndirectCountEXT_fnptr = &vkCmdDrawMeshTasksIndirectCountEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDrawMeshTasksIndirectCountEXT_Lazy(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            _vkCmdDrawMeshTasksIndirectCountEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDrawMeshTasksIndirectCountEXT");
            _vkCmdDrawMeshTasksIndirectCountEXT_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        public static delegate* unmanaged<VkDevice, VkPipeline, uint, VkResult> _vkCompileDeferredNV_fnptr = &vkCompileDeferredNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCompileDeferredNV_Lazy(VkDevice device, VkPipeline pipeline, uint shader)
        {
            _vkCompileDeferredNV_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, uint, VkResult>)VKLoader.GetInstanceProcAddress("vkCompileDeferredNV");
            return _vkCompileDeferredNV_fnptr(device, pipeline, shader);
        }
        public static delegate* unmanaged<VkDevice, VkAccelerationStructureCreateInfoNV*, VkAllocationCallbacks*, VkAccelerationStructureNV*, VkResult> _vkCreateAccelerationStructureNV_fnptr = &vkCreateAccelerationStructureNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateAccelerationStructureNV_Lazy(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            _vkCreateAccelerationStructureNV_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureCreateInfoNV*, VkAllocationCallbacks*, VkAccelerationStructureNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateAccelerationStructureNV");
            return _vkCreateAccelerationStructureNV_fnptr(device, pCreateInfo, pAllocator, pAccelerationStructure);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void> _vkCmdBindInvocationMaskHUAWEI_fnptr = &vkCmdBindInvocationMaskHUAWEI_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindInvocationMaskHUAWEI_Lazy(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
        {
            _vkCmdBindInvocationMaskHUAWEI_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void>)VKLoader.GetInstanceProcAddress("vkCmdBindInvocationMaskHUAWEI");
            _vkCmdBindInvocationMaskHUAWEI_fnptr(commandBuffer, imageView, imageLayout);
        }
        public static delegate* unmanaged<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void> _vkDestroyAccelerationStructureKHR_fnptr = &vkDestroyAccelerationStructureKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyAccelerationStructureKHR_Lazy(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyAccelerationStructureKHR_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyAccelerationStructureKHR");
            _vkDestroyAccelerationStructureKHR_fnptr(device, accelerationStructure, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void> _vkDestroyAccelerationStructureNV_fnptr = &vkDestroyAccelerationStructureNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyAccelerationStructureNV_Lazy(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyAccelerationStructureNV_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyAccelerationStructureNV");
            _vkDestroyAccelerationStructureNV_fnptr(device, accelerationStructure, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkAccelerationStructureMemoryRequirementsInfoNV*, VkMemoryRequirements2KHR*, void> _vkGetAccelerationStructureMemoryRequirementsNV_fnptr = &vkGetAccelerationStructureMemoryRequirementsNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetAccelerationStructureMemoryRequirementsNV_Lazy(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2KHR* pMemoryRequirements)
        {
            _vkGetAccelerationStructureMemoryRequirementsNV_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureMemoryRequirementsInfoNV*, VkMemoryRequirements2KHR*, void>)VKLoader.GetInstanceProcAddress("vkGetAccelerationStructureMemoryRequirementsNV");
            _vkGetAccelerationStructureMemoryRequirementsNV_fnptr(device, pInfo, pMemoryRequirements);
        }
        public static delegate* unmanaged<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult> _vkBindAccelerationStructureMemoryNV_fnptr = &vkBindAccelerationStructureMemoryNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkBindAccelerationStructureMemoryNV_Lazy(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
        {
            _vkBindAccelerationStructureMemoryNV_fnptr = (delegate* unmanaged<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkBindAccelerationStructureMemoryNV");
            return _vkBindAccelerationStructureMemoryNV_fnptr(device, bindInfoCount, pBindInfos);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void> _vkCmdCopyAccelerationStructureNV_fnptr = &vkCmdCopyAccelerationStructureNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyAccelerationStructureNV_Lazy(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode)
        {
            _vkCmdCopyAccelerationStructureNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyAccelerationStructureNV");
            _vkCmdCopyAccelerationStructureNV_fnptr(commandBuffer, dst, src, mode);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void> _vkCmdCopyAccelerationStructureKHR_fnptr = &vkCmdCopyAccelerationStructureKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyAccelerationStructureKHR_Lazy(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo)
        {
            _vkCmdCopyAccelerationStructureKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyAccelerationStructureKHR");
            _vkCmdCopyAccelerationStructureKHR_fnptr(commandBuffer, pInfo);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureInfoKHR*, VkResult> _vkCopyAccelerationStructureKHR_fnptr = &vkCopyAccelerationStructureKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCopyAccelerationStructureKHR_Lazy(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo)
        {
            _vkCopyAccelerationStructureKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCopyAccelerationStructureKHR");
            return _vkCopyAccelerationStructureKHR_fnptr(device, deferredOperation, pInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void> _vkCmdCopyAccelerationStructureToMemoryKHR_fnptr = &vkCmdCopyAccelerationStructureToMemoryKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyAccelerationStructureToMemoryKHR_Lazy(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
        {
            _vkCmdCopyAccelerationStructureToMemoryKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyAccelerationStructureToMemoryKHR");
            _vkCmdCopyAccelerationStructureToMemoryKHR_fnptr(commandBuffer, pInfo);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureToMemoryInfoKHR*, VkResult> _vkCopyAccelerationStructureToMemoryKHR_fnptr = &vkCopyAccelerationStructureToMemoryKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCopyAccelerationStructureToMemoryKHR_Lazy(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
        {
            _vkCopyAccelerationStructureToMemoryKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureToMemoryInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCopyAccelerationStructureToMemoryKHR");
            return _vkCopyAccelerationStructureToMemoryKHR_fnptr(device, deferredOperation, pInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void> _vkCmdCopyMemoryToAccelerationStructureKHR_fnptr = &vkCmdCopyMemoryToAccelerationStructureKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyMemoryToAccelerationStructureKHR_Lazy(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
        {
            _vkCmdCopyMemoryToAccelerationStructureKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyMemoryToAccelerationStructureKHR");
            _vkCmdCopyMemoryToAccelerationStructureKHR_fnptr(commandBuffer, pInfo);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToAccelerationStructureInfoKHR*, VkResult> _vkCopyMemoryToAccelerationStructureKHR_fnptr = &vkCopyMemoryToAccelerationStructureKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCopyMemoryToAccelerationStructureKHR_Lazy(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
        {
            _vkCopyMemoryToAccelerationStructureKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToAccelerationStructureInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCopyMemoryToAccelerationStructureKHR");
            return _vkCopyMemoryToAccelerationStructureKHR_fnptr(device, deferredOperation, pInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void> _vkCmdWriteAccelerationStructuresPropertiesKHR_fnptr = &vkCmdWriteAccelerationStructuresPropertiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdWriteAccelerationStructuresPropertiesKHR_Lazy(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            _vkCmdWriteAccelerationStructuresPropertiesKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdWriteAccelerationStructuresPropertiesKHR");
            _vkCmdWriteAccelerationStructuresPropertiesKHR_fnptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void> _vkCmdWriteAccelerationStructuresPropertiesNV_fnptr = &vkCmdWriteAccelerationStructuresPropertiesNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdWriteAccelerationStructuresPropertiesNV_Lazy(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            _vkCmdWriteAccelerationStructuresPropertiesNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdWriteAccelerationStructuresPropertiesNV");
            _vkCmdWriteAccelerationStructuresPropertiesNV_fnptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, ulong, int, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, ulong, void> _vkCmdBuildAccelerationStructureNV_fnptr = &vkCmdBuildAccelerationStructureNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBuildAccelerationStructureNV_Lazy(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, ulong instanceOffset, int update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
        {
            _vkCmdBuildAccelerationStructureNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, ulong, int, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, ulong, void>)VKLoader.GetInstanceProcAddress("vkCmdBuildAccelerationStructureNV");
            _vkCmdBuildAccelerationStructureNV_fnptr(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
        }
        public static delegate* unmanaged<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, nuint, void*, nuint, VkResult> _vkWriteAccelerationStructuresPropertiesKHR_fnptr = &vkWriteAccelerationStructuresPropertiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkWriteAccelerationStructuresPropertiesKHR_Lazy(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, nuint dataSize, void* pData, nuint stride)
        {
            _vkWriteAccelerationStructuresPropertiesKHR_fnptr = (delegate* unmanaged<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, nuint, void*, nuint, VkResult>)VKLoader.GetInstanceProcAddress("vkWriteAccelerationStructuresPropertiesKHR");
            return _vkWriteAccelerationStructuresPropertiesKHR_fnptr(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint, void> _vkCmdTraceRaysKHR_fnptr = &vkCmdTraceRaysKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdTraceRaysKHR_Lazy(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            _vkCmdTraceRaysKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdTraceRaysKHR");
            _vkCmdTraceRaysKHR_fnptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, uint, uint, uint, void> _vkCmdTraceRaysNV_fnptr = &vkCmdTraceRaysNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdTraceRaysNV_Lazy(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
        {
            _vkCmdTraceRaysNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, uint, uint, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdTraceRaysNV");
            _vkCmdTraceRaysNV_fnptr(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
        }
        public static delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> _vkGetRayTracingShaderGroupHandlesKHR_fnptr = &vkGetRayTracingShaderGroupHandlesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetRayTracingShaderGroupHandlesKHR_Lazy(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
        {
            _vkGetRayTracingShaderGroupHandlesKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetRayTracingShaderGroupHandlesKHR");
            return _vkGetRayTracingShaderGroupHandlesKHR_fnptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        public static delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> _vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_fnptr = &vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_Lazy(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
        {
            _vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetRayTracingCaptureReplayShaderGroupHandlesKHR");
            return _vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_fnptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        public static delegate* unmanaged<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult> _vkGetAccelerationStructureHandleNV_fnptr = &vkGetAccelerationStructureHandleNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetAccelerationStructureHandleNV_Lazy(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* pData)
        {
            _vkGetAccelerationStructureHandleNV_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetAccelerationStructureHandleNV");
            return _vkGetAccelerationStructureHandleNV_fnptr(device, accelerationStructure, dataSize, pData);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateRayTracingPipelinesNV_fnptr = &vkCreateRayTracingPipelinesNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateRayTracingPipelinesNV_Lazy(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            _vkCreateRayTracingPipelinesNV_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, VkAllocationCallbacks*, VkPipeline*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateRayTracingPipelinesNV");
            return _vkCreateRayTracingPipelinesNV_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateRayTracingPipelinesKHR_fnptr = &vkCreateRayTracingPipelinesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateRayTracingPipelinesKHR_Lazy(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            _vkCreateRayTracingPipelinesKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, VkAllocationCallbacks*, VkPipeline*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateRayTracingPipelinesKHR");
            return _vkCreateRayTracingPipelinesKHR_fnptr(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult> _vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_fnptr = &vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_Lazy(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
        {
            _vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceCooperativeMatrixPropertiesNV");
            return _vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, ulong, void> _vkCmdTraceRaysIndirectKHR_fnptr = &vkCmdTraceRaysIndirectKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdTraceRaysIndirectKHR_Lazy(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            _vkCmdTraceRaysIndirectKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, ulong, void>)VKLoader.GetInstanceProcAddress("vkCmdTraceRaysIndirectKHR");
            _vkCmdTraceRaysIndirectKHR_fnptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
        }
        public static delegate* unmanaged<VkCommandBuffer, ulong, void> _vkCmdTraceRaysIndirect2KHR_fnptr = &vkCmdTraceRaysIndirect2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdTraceRaysIndirect2KHR_Lazy(VkCommandBuffer commandBuffer, ulong indirectDeviceAddress)
        {
            _vkCmdTraceRaysIndirect2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, void>)VKLoader.GetInstanceProcAddress("vkCmdTraceRaysIndirect2KHR");
            _vkCmdTraceRaysIndirect2KHR_fnptr(commandBuffer, indirectDeviceAddress);
        }
        public static delegate* unmanaged<VkDevice, VkAccelerationStructureVersionInfoKHR*, VkAccelerationStructureCompatibilityKHR*, void> _vkGetDeviceAccelerationStructureCompatibilityKHR_fnptr = &vkGetDeviceAccelerationStructureCompatibilityKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDeviceAccelerationStructureCompatibilityKHR_Lazy(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            _vkGetDeviceAccelerationStructureCompatibilityKHR_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureVersionInfoKHR*, VkAccelerationStructureCompatibilityKHR*, void>)VKLoader.GetInstanceProcAddress("vkGetDeviceAccelerationStructureCompatibilityKHR");
            _vkGetDeviceAccelerationStructureCompatibilityKHR_fnptr(device, pVersionInfo, pCompatibility);
        }
        public static delegate* unmanaged<VkDevice, VkPipeline, uint, VkShaderGroupShaderKHR, ulong> _vkGetRayTracingShaderGroupStackSizeKHR_fnptr = &vkGetRayTracingShaderGroupStackSizeKHR_Lazy;
        [UnmanagedCallersOnly]
        private static ulong vkGetRayTracingShaderGroupStackSizeKHR_Lazy(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader)
        {
            _vkGetRayTracingShaderGroupStackSizeKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, uint, VkShaderGroupShaderKHR, ulong>)VKLoader.GetInstanceProcAddress("vkGetRayTracingShaderGroupStackSizeKHR");
            return _vkGetRayTracingShaderGroupStackSizeKHR_fnptr(device, pipeline, group, groupShader);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, void> _vkCmdSetRayTracingPipelineStackSizeKHR_fnptr = &vkCmdSetRayTracingPipelineStackSizeKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetRayTracingPipelineStackSizeKHR_Lazy(VkCommandBuffer commandBuffer, uint pipelineStackSize)
        {
            _vkCmdSetRayTracingPipelineStackSizeKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdSetRayTracingPipelineStackSizeKHR");
            _vkCmdSetRayTracingPipelineStackSizeKHR_fnptr(commandBuffer, pipelineStackSize);
        }
        public static delegate* unmanaged<VkDevice, VkImageViewHandleInfoNVX*, uint> _vkGetImageViewHandleNVX_fnptr = &vkGetImageViewHandleNVX_Lazy;
        [UnmanagedCallersOnly]
        private static uint vkGetImageViewHandleNVX_Lazy(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
        {
            _vkGetImageViewHandleNVX_fnptr = (delegate* unmanaged<VkDevice, VkImageViewHandleInfoNVX*, uint>)VKLoader.GetInstanceProcAddress("vkGetImageViewHandleNVX");
            return _vkGetImageViewHandleNVX_fnptr(device, pInfo);
        }
        public static delegate* unmanaged<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult> _vkGetImageViewAddressNVX_fnptr = &vkGetImageViewAddressNVX_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetImageViewAddressNVX_Lazy(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties)
        {
            _vkGetImageViewAddressNVX_fnptr = (delegate* unmanaged<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetImageViewAddressNVX");
            return _vkGetImageViewAddressNVX_fnptr(device, imageView, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkPresentModeKHR*, VkResult> _vkGetPhysicalDeviceSurfacePresentModes2EXT_fnptr = &vkGetPhysicalDeviceSurfacePresentModes2EXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            _vkGetPhysicalDeviceSurfacePresentModes2EXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkPresentModeKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSurfacePresentModes2EXT");
            return _vkGetPhysicalDeviceSurfacePresentModes2EXT_fnptr(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);
        }
        public static delegate* unmanaged<VkDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkDeviceGroupPresentModeFlagBitsKHR*, VkResult> _vkGetDeviceGroupSurfacePresentModes2EXT_fnptr = &vkGetDeviceGroupSurfacePresentModes2EXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDeviceGroupSurfacePresentModes2EXT_Lazy(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagBitsKHR* pModes)
        {
            _vkGetDeviceGroupSurfacePresentModes2EXT_fnptr = (delegate* unmanaged<VkDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkDeviceGroupPresentModeFlagBitsKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDeviceGroupSurfacePresentModes2EXT");
            return _vkGetDeviceGroupSurfacePresentModes2EXT_fnptr(device, pSurfaceInfo, pModes);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult> _vkAcquireFullScreenExclusiveModeEXT_fnptr = &vkAcquireFullScreenExclusiveModeEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkAcquireFullScreenExclusiveModeEXT_Lazy(VkDevice device, VkSwapchainKHR swapchain)
        {
            _vkAcquireFullScreenExclusiveModeEXT_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult>)VKLoader.GetInstanceProcAddress("vkAcquireFullScreenExclusiveModeEXT");
            return _vkAcquireFullScreenExclusiveModeEXT_fnptr(device, swapchain);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult> _vkReleaseFullScreenExclusiveModeEXT_fnptr = &vkReleaseFullScreenExclusiveModeEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkReleaseFullScreenExclusiveModeEXT_Lazy(VkDevice device, VkSwapchainKHR swapchain)
        {
            _vkReleaseFullScreenExclusiveModeEXT_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult>)VKLoader.GetInstanceProcAddress("vkReleaseFullScreenExclusiveModeEXT");
            return _vkReleaseFullScreenExclusiveModeEXT_fnptr(device, swapchain);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkPerformanceCounterKHR*, VkPerformanceCounterDescriptionKHR*, VkResult> _vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_fnptr = &vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_Lazy(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            _vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkPerformanceCounterKHR*, VkPerformanceCounterDescriptionKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR");
            return _vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_fnptr(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, uint*, void> _vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_fnptr = &vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_Lazy(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses)
        {
            _vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, uint*, void>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR");
            _vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_fnptr(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);
        }
        public static delegate* unmanaged<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult> _vkAcquireProfilingLockKHR_fnptr = &vkAcquireProfilingLockKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkAcquireProfilingLockKHR_Lazy(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo)
        {
            _vkAcquireProfilingLockKHR_fnptr = (delegate* unmanaged<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkAcquireProfilingLockKHR");
            return _vkAcquireProfilingLockKHR_fnptr(device, pInfo);
        }
        public static delegate* unmanaged<VkDevice, void> _vkReleaseProfilingLockKHR_fnptr = &vkReleaseProfilingLockKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkReleaseProfilingLockKHR_Lazy(VkDevice device)
        {
            _vkReleaseProfilingLockKHR_fnptr = (delegate* unmanaged<VkDevice, void>)VKLoader.GetInstanceProcAddress("vkReleaseProfilingLockKHR");
            _vkReleaseProfilingLockKHR_fnptr(device);
        }
        public static delegate* unmanaged<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult> _vkGetImageDrmFormatModifierPropertiesEXT_fnptr = &vkGetImageDrmFormatModifierPropertiesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetImageDrmFormatModifierPropertiesEXT_Lazy(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
        {
            _vkGetImageDrmFormatModifierPropertiesEXT_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetImageDrmFormatModifierPropertiesEXT");
            return _vkGetImageDrmFormatModifierPropertiesEXT_fnptr(device, image, pProperties);
        }
        public static delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong> _vkGetBufferOpaqueCaptureAddress_fnptr = &vkGetBufferOpaqueCaptureAddress_Lazy;
        [UnmanagedCallersOnly]
        private static ulong vkGetBufferOpaqueCaptureAddress_Lazy(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            _vkGetBufferOpaqueCaptureAddress_fnptr = (delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong>)VKLoader.GetInstanceProcAddress("vkGetBufferOpaqueCaptureAddress");
            return _vkGetBufferOpaqueCaptureAddress_fnptr(device, pInfo);
        }
        public static delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong> _vkGetBufferDeviceAddress_fnptr = &vkGetBufferDeviceAddress_Lazy;
        [UnmanagedCallersOnly]
        private static ulong vkGetBufferDeviceAddress_Lazy(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            _vkGetBufferDeviceAddress_fnptr = (delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong>)VKLoader.GetInstanceProcAddress("vkGetBufferDeviceAddress");
            return _vkGetBufferDeviceAddress_fnptr(device, pInfo);
        }
        public static delegate* unmanaged<VkInstance, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateHeadlessSurfaceEXT_fnptr = &vkCreateHeadlessSurfaceEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateHeadlessSurfaceEXT_Lazy(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            _vkCreateHeadlessSurfaceEXT_fnptr = (delegate* unmanaged<VkInstance, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateHeadlessSurfaceEXT");
            return _vkCreateHeadlessSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult> _vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_fnptr = &vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_Lazy(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
        {
            _vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV");
            return _vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_fnptr(physicalDevice, pCombinationCount, pCombinations);
        }
        public static delegate* unmanaged<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult> _vkInitializePerformanceApiINTEL_fnptr = &vkInitializePerformanceApiINTEL_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkInitializePerformanceApiINTEL_Lazy(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo)
        {
            _vkInitializePerformanceApiINTEL_fnptr = (delegate* unmanaged<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult>)VKLoader.GetInstanceProcAddress("vkInitializePerformanceApiINTEL");
            return _vkInitializePerformanceApiINTEL_fnptr(device, pInitializeInfo);
        }
        public static delegate* unmanaged<VkDevice, void> _vkUninitializePerformanceApiINTEL_fnptr = &vkUninitializePerformanceApiINTEL_Lazy;
        [UnmanagedCallersOnly]
        private static void vkUninitializePerformanceApiINTEL_Lazy(VkDevice device)
        {
            _vkUninitializePerformanceApiINTEL_fnptr = (delegate* unmanaged<VkDevice, void>)VKLoader.GetInstanceProcAddress("vkUninitializePerformanceApiINTEL");
            _vkUninitializePerformanceApiINTEL_fnptr(device);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult> _vkCmdSetPerformanceMarkerINTEL_fnptr = &vkCmdSetPerformanceMarkerINTEL_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCmdSetPerformanceMarkerINTEL_Lazy(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo)
        {
            _vkCmdSetPerformanceMarkerINTEL_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult>)VKLoader.GetInstanceProcAddress("vkCmdSetPerformanceMarkerINTEL");
            return _vkCmdSetPerformanceMarkerINTEL_fnptr(commandBuffer, pMarkerInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult> _vkCmdSetPerformanceStreamMarkerINTEL_fnptr = &vkCmdSetPerformanceStreamMarkerINTEL_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCmdSetPerformanceStreamMarkerINTEL_Lazy(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo)
        {
            _vkCmdSetPerformanceStreamMarkerINTEL_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult>)VKLoader.GetInstanceProcAddress("vkCmdSetPerformanceStreamMarkerINTEL");
            return _vkCmdSetPerformanceStreamMarkerINTEL_fnptr(commandBuffer, pMarkerInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult> _vkCmdSetPerformanceOverrideINTEL_fnptr = &vkCmdSetPerformanceOverrideINTEL_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCmdSetPerformanceOverrideINTEL_Lazy(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo)
        {
            _vkCmdSetPerformanceOverrideINTEL_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult>)VKLoader.GetInstanceProcAddress("vkCmdSetPerformanceOverrideINTEL");
            return _vkCmdSetPerformanceOverrideINTEL_fnptr(commandBuffer, pOverrideInfo);
        }
        public static delegate* unmanaged<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult> _vkAcquirePerformanceConfigurationINTEL_fnptr = &vkAcquirePerformanceConfigurationINTEL_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkAcquirePerformanceConfigurationINTEL_Lazy(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
        {
            _vkAcquirePerformanceConfigurationINTEL_fnptr = (delegate* unmanaged<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult>)VKLoader.GetInstanceProcAddress("vkAcquirePerformanceConfigurationINTEL");
            return _vkAcquirePerformanceConfigurationINTEL_fnptr(device, pAcquireInfo, pConfiguration);
        }
        public static delegate* unmanaged<VkDevice, VkPerformanceConfigurationINTEL, VkResult> _vkReleasePerformanceConfigurationINTEL_fnptr = &vkReleasePerformanceConfigurationINTEL_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkReleasePerformanceConfigurationINTEL_Lazy(VkDevice device, VkPerformanceConfigurationINTEL configuration)
        {
            _vkReleasePerformanceConfigurationINTEL_fnptr = (delegate* unmanaged<VkDevice, VkPerformanceConfigurationINTEL, VkResult>)VKLoader.GetInstanceProcAddress("vkReleasePerformanceConfigurationINTEL");
            return _vkReleasePerformanceConfigurationINTEL_fnptr(device, configuration);
        }
        public static delegate* unmanaged<VkQueue, VkPerformanceConfigurationINTEL, VkResult> _vkQueueSetPerformanceConfigurationINTEL_fnptr = &vkQueueSetPerformanceConfigurationINTEL_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkQueueSetPerformanceConfigurationINTEL_Lazy(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
        {
            _vkQueueSetPerformanceConfigurationINTEL_fnptr = (delegate* unmanaged<VkQueue, VkPerformanceConfigurationINTEL, VkResult>)VKLoader.GetInstanceProcAddress("vkQueueSetPerformanceConfigurationINTEL");
            return _vkQueueSetPerformanceConfigurationINTEL_fnptr(queue, configuration);
        }
        public static delegate* unmanaged<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult> _vkGetPerformanceParameterINTEL_fnptr = &vkGetPerformanceParameterINTEL_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPerformanceParameterINTEL_Lazy(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
        {
            _vkGetPerformanceParameterINTEL_fnptr = (delegate* unmanaged<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPerformanceParameterINTEL");
            return _vkGetPerformanceParameterINTEL_fnptr(device, parameter, pValue);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong> _vkGetDeviceMemoryOpaqueCaptureAddress_fnptr = &vkGetDeviceMemoryOpaqueCaptureAddress_Lazy;
        [UnmanagedCallersOnly]
        private static ulong vkGetDeviceMemoryOpaqueCaptureAddress_Lazy(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
        {
            _vkGetDeviceMemoryOpaqueCaptureAddress_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong>)VKLoader.GetInstanceProcAddress("vkGetDeviceMemoryOpaqueCaptureAddress");
            return _vkGetDeviceMemoryOpaqueCaptureAddress_fnptr(device, pInfo);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineInfoKHR*, uint*, VkPipelineExecutablePropertiesKHR*, VkResult> _vkGetPipelineExecutablePropertiesKHR_fnptr = &vkGetPipelineExecutablePropertiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPipelineExecutablePropertiesKHR_Lazy(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            _vkGetPipelineExecutablePropertiesKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineInfoKHR*, uint*, VkPipelineExecutablePropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPipelineExecutablePropertiesKHR");
            return _vkGetPipelineExecutablePropertiesKHR_fnptr(device, pPipelineInfo, pExecutableCount, pProperties);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableStatisticKHR*, VkResult> _vkGetPipelineExecutableStatisticsKHR_fnptr = &vkGetPipelineExecutableStatisticsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPipelineExecutableStatisticsKHR_Lazy(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            _vkGetPipelineExecutableStatisticsKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableStatisticKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPipelineExecutableStatisticsKHR");
            return _vkGetPipelineExecutableStatisticsKHR_fnptr(device, pExecutableInfo, pStatisticCount, pStatistics);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableInternalRepresentationKHR*, VkResult> _vkGetPipelineExecutableInternalRepresentationsKHR_fnptr = &vkGetPipelineExecutableInternalRepresentationsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPipelineExecutableInternalRepresentationsKHR_Lazy(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            _vkGetPipelineExecutableInternalRepresentationsKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableInternalRepresentationKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPipelineExecutableInternalRepresentationsKHR");
            return _vkGetPipelineExecutableInternalRepresentationsKHR_fnptr(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, ushort, void> _vkCmdSetLineStippleKHR_fnptr = &vkCmdSetLineStippleKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetLineStippleKHR_Lazy(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
        {
            _vkCmdSetLineStippleKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, ushort, void>)VKLoader.GetInstanceProcAddress("vkCmdSetLineStippleKHR");
            _vkCmdSetLineStippleKHR_fnptr(commandBuffer, lineStippleFactor, lineStipplePattern);
        }
        public static delegate* unmanaged<VkDevice, VkFaultQueryBehavior, int*, uint*, VkFaultData*, VkResult> _vkGetFaultData_fnptr = &vkGetFaultData_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetFaultData_Lazy(VkDevice device, VkFaultQueryBehavior faultQueryBehavior, int* pUnrecordedFaults, uint* pFaultCount, VkFaultData* pFaults)
        {
            _vkGetFaultData_fnptr = (delegate* unmanaged<VkDevice, VkFaultQueryBehavior, int*, uint*, VkFaultData*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetFaultData");
            return _vkGetFaultData_fnptr(device, faultQueryBehavior, pUnrecordedFaults, pFaultCount, pFaults);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult> _vkGetPhysicalDeviceToolProperties_fnptr = &vkGetPhysicalDeviceToolProperties_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceToolProperties_Lazy(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
        {
            _vkGetPhysicalDeviceToolProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceToolProperties");
            return _vkGetPhysicalDeviceToolProperties_fnptr(physicalDevice, pToolCount, pToolProperties);
        }
        public static delegate* unmanaged<VkDevice, VkAccelerationStructureCreateInfoKHR*, VkAllocationCallbacks*, VkAccelerationStructureKHR*, VkResult> _vkCreateAccelerationStructureKHR_fnptr = &vkCreateAccelerationStructureKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateAccelerationStructureKHR_Lazy(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            _vkCreateAccelerationStructureKHR_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureCreateInfoKHR*, VkAllocationCallbacks*, VkAccelerationStructureKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateAccelerationStructureKHR");
            return _vkCreateAccelerationStructureKHR_fnptr(device, pCreateInfo, pAllocator, pAccelerationStructure);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, void> _vkCmdBuildAccelerationStructuresKHR_fnptr = &vkCmdBuildAccelerationStructuresKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBuildAccelerationStructuresKHR_Lazy(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            _vkCmdBuildAccelerationStructuresKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, void>)VKLoader.GetInstanceProcAddress("vkCmdBuildAccelerationStructuresKHR");
            _vkCmdBuildAccelerationStructuresKHR_fnptr(commandBuffer, infoCount, pInfos, ppBuildRangeInfos);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, ulong*, uint*, uint**, void> _vkCmdBuildAccelerationStructuresIndirectKHR_fnptr = &vkCmdBuildAccelerationStructuresIndirectKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBuildAccelerationStructuresIndirectKHR_Lazy(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            _vkCmdBuildAccelerationStructuresIndirectKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, ulong*, uint*, uint**, void>)VKLoader.GetInstanceProcAddress("vkCmdBuildAccelerationStructuresIndirectKHR");
            _vkCmdBuildAccelerationStructuresIndirectKHR_fnptr(commandBuffer, infoCount, pInfos, pIndirectDeviceAddresses, pIndirectStrides, ppMaxPrimitiveCounts);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult> _vkBuildAccelerationStructuresKHR_fnptr = &vkBuildAccelerationStructuresKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkBuildAccelerationStructuresKHR_Lazy(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            _vkBuildAccelerationStructuresKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult>)VKLoader.GetInstanceProcAddress("vkBuildAccelerationStructuresKHR");
            return _vkBuildAccelerationStructuresKHR_fnptr(device, deferredOperation, infoCount, pInfos, ppBuildRangeInfos);
        }
        public static delegate* unmanaged<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, ulong> _vkGetAccelerationStructureDeviceAddressKHR_fnptr = &vkGetAccelerationStructureDeviceAddressKHR_Lazy;
        [UnmanagedCallersOnly]
        private static ulong vkGetAccelerationStructureDeviceAddressKHR_Lazy(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo)
        {
            _vkGetAccelerationStructureDeviceAddressKHR_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, ulong>)VKLoader.GetInstanceProcAddress("vkGetAccelerationStructureDeviceAddressKHR");
            return _vkGetAccelerationStructureDeviceAddressKHR_fnptr(device, pInfo);
        }
        public static delegate* unmanaged<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult> _vkCreateDeferredOperationKHR_fnptr = &vkCreateDeferredOperationKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateDeferredOperationKHR_Lazy(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation)
        {
            _vkCreateDeferredOperationKHR_fnptr = (delegate* unmanaged<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateDeferredOperationKHR");
            return _vkCreateDeferredOperationKHR_fnptr(device, pAllocator, pDeferredOperation);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void> _vkDestroyDeferredOperationKHR_fnptr = &vkDestroyDeferredOperationKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyDeferredOperationKHR_Lazy(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDeferredOperationKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyDeferredOperationKHR");
            _vkDestroyDeferredOperationKHR_fnptr(device, operation, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint> _vkGetDeferredOperationMaxConcurrencyKHR_fnptr = &vkGetDeferredOperationMaxConcurrencyKHR_Lazy;
        [UnmanagedCallersOnly]
        private static uint vkGetDeferredOperationMaxConcurrencyKHR_Lazy(VkDevice device, VkDeferredOperationKHR operation)
        {
            _vkGetDeferredOperationMaxConcurrencyKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint>)VKLoader.GetInstanceProcAddress("vkGetDeferredOperationMaxConcurrencyKHR");
            return _vkGetDeferredOperationMaxConcurrencyKHR_fnptr(device, operation);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkResult> _vkGetDeferredOperationResultKHR_fnptr = &vkGetDeferredOperationResultKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDeferredOperationResultKHR_Lazy(VkDevice device, VkDeferredOperationKHR operation)
        {
            _vkGetDeferredOperationResultKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDeferredOperationResultKHR");
            return _vkGetDeferredOperationResultKHR_fnptr(device, operation);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkResult> _vkDeferredOperationJoinKHR_fnptr = &vkDeferredOperationJoinKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkDeferredOperationJoinKHR_Lazy(VkDevice device, VkDeferredOperationKHR operation)
        {
            _vkDeferredOperationJoinKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkResult>)VKLoader.GetInstanceProcAddress("vkDeferredOperationJoinKHR");
            return _vkDeferredOperationJoinKHR_fnptr(device, operation);
        }
        public static delegate* unmanaged<VkDevice, VkComputePipelineCreateInfo*, VkMemoryRequirements2*, void> _vkGetPipelineIndirectMemoryRequirementsNV_fnptr = &vkGetPipelineIndirectMemoryRequirementsNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPipelineIndirectMemoryRequirementsNV_Lazy(VkDevice device, VkComputePipelineCreateInfo* pCreateInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetPipelineIndirectMemoryRequirementsNV_fnptr = (delegate* unmanaged<VkDevice, VkComputePipelineCreateInfo*, VkMemoryRequirements2*, void>)VKLoader.GetInstanceProcAddress("vkGetPipelineIndirectMemoryRequirementsNV");
            _vkGetPipelineIndirectMemoryRequirementsNV_fnptr(device, pCreateInfo, pMemoryRequirements);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineIndirectDeviceAddressInfoNV*, ulong> _vkGetPipelineIndirectDeviceAddressNV_fnptr = &vkGetPipelineIndirectDeviceAddressNV_Lazy;
        [UnmanagedCallersOnly]
        private static ulong vkGetPipelineIndirectDeviceAddressNV_Lazy(VkDevice device, VkPipelineIndirectDeviceAddressInfoNV* pInfo)
        {
            _vkGetPipelineIndirectDeviceAddressNV_fnptr = (delegate* unmanaged<VkDevice, VkPipelineIndirectDeviceAddressInfoNV*, ulong>)VKLoader.GetInstanceProcAddress("vkGetPipelineIndirectDeviceAddressNV");
            return _vkGetPipelineIndirectDeviceAddressNV_fnptr(device, pInfo);
        }
        public static delegate* unmanaged<VkDevice, VkAntiLagDataAMD*, void> _vkAntiLagUpdateAMD_fnptr = &vkAntiLagUpdateAMD_Lazy;
        [UnmanagedCallersOnly]
        private static void vkAntiLagUpdateAMD_Lazy(VkDevice device, VkAntiLagDataAMD* pData)
        {
            _vkAntiLagUpdateAMD_fnptr = (delegate* unmanaged<VkDevice, VkAntiLagDataAMD*, void>)VKLoader.GetInstanceProcAddress("vkAntiLagUpdateAMD");
            _vkAntiLagUpdateAMD_fnptr(device, pData);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCullModeFlagBits, void> _vkCmdSetCullMode_fnptr = &vkCmdSetCullMode_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetCullMode_Lazy(VkCommandBuffer commandBuffer, VkCullModeFlagBits cullMode)
        {
            _vkCmdSetCullMode_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCullModeFlagBits, void>)VKLoader.GetInstanceProcAddress("vkCmdSetCullMode");
            _vkCmdSetCullMode_fnptr(commandBuffer, cullMode);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkFrontFace, void> _vkCmdSetFrontFace_fnptr = &vkCmdSetFrontFace_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetFrontFace_Lazy(VkCommandBuffer commandBuffer, VkFrontFace frontFace)
        {
            _vkCmdSetFrontFace_fnptr = (delegate* unmanaged<VkCommandBuffer, VkFrontFace, void>)VKLoader.GetInstanceProcAddress("vkCmdSetFrontFace");
            _vkCmdSetFrontFace_fnptr(commandBuffer, frontFace);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPrimitiveTopology, void> _vkCmdSetPrimitiveTopology_fnptr = &vkCmdSetPrimitiveTopology_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetPrimitiveTopology_Lazy(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology)
        {
            _vkCmdSetPrimitiveTopology_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPrimitiveTopology, void>)VKLoader.GetInstanceProcAddress("vkCmdSetPrimitiveTopology");
            _vkCmdSetPrimitiveTopology_fnptr(commandBuffer, primitiveTopology);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkViewport*, void> _vkCmdSetViewportWithCount_fnptr = &vkCmdSetViewportWithCount_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetViewportWithCount_Lazy(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports)
        {
            _vkCmdSetViewportWithCount_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkViewport*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetViewportWithCount");
            _vkCmdSetViewportWithCount_fnptr(commandBuffer, viewportCount, pViewports);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkRect2D*, void> _vkCmdSetScissorWithCount_fnptr = &vkCmdSetScissorWithCount_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetScissorWithCount_Lazy(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors)
        {
            _vkCmdSetScissorWithCount_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkRect2D*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetScissorWithCount");
            _vkCmdSetScissorWithCount_fnptr(commandBuffer, scissorCount, pScissors);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, VkIndexType, void> _vkCmdBindIndexBuffer2KHR_fnptr = &vkCmdBindIndexBuffer2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindIndexBuffer2KHR_Lazy(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, ulong size, VkIndexType indexType)
        {
            _vkCmdBindIndexBuffer2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, VkIndexType, void>)VKLoader.GetInstanceProcAddress("vkCmdBindIndexBuffer2KHR");
            _vkCmdBindIndexBuffer2KHR_fnptr(commandBuffer, buffer, offset, size, indexType);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, ulong*, void> _vkCmdBindVertexBuffers2_fnptr = &vkCmdBindVertexBuffers2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindVertexBuffers2_Lazy(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes, ulong* pStrides)
        {
            _vkCmdBindVertexBuffers2_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, ulong*, void>)VKLoader.GetInstanceProcAddress("vkCmdBindVertexBuffers2");
            _vkCmdBindVertexBuffers2_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthTestEnable_fnptr = &vkCmdSetDepthTestEnable_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDepthTestEnable_Lazy(VkCommandBuffer commandBuffer, int depthTestEnable)
        {
            _vkCmdSetDepthTestEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDepthTestEnable");
            _vkCmdSetDepthTestEnable_fnptr(commandBuffer, depthTestEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthWriteEnable_fnptr = &vkCmdSetDepthWriteEnable_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDepthWriteEnable_Lazy(VkCommandBuffer commandBuffer, int depthWriteEnable)
        {
            _vkCmdSetDepthWriteEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDepthWriteEnable");
            _vkCmdSetDepthWriteEnable_fnptr(commandBuffer, depthWriteEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCompareOp, void> _vkCmdSetDepthCompareOp_fnptr = &vkCmdSetDepthCompareOp_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDepthCompareOp_Lazy(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp)
        {
            _vkCmdSetDepthCompareOp_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCompareOp, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDepthCompareOp");
            _vkCmdSetDepthCompareOp_fnptr(commandBuffer, depthCompareOp);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthBoundsTestEnable_fnptr = &vkCmdSetDepthBoundsTestEnable_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDepthBoundsTestEnable_Lazy(VkCommandBuffer commandBuffer, int depthBoundsTestEnable)
        {
            _vkCmdSetDepthBoundsTestEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDepthBoundsTestEnable");
            _vkCmdSetDepthBoundsTestEnable_fnptr(commandBuffer, depthBoundsTestEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetStencilTestEnable_fnptr = &vkCmdSetStencilTestEnable_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetStencilTestEnable_Lazy(VkCommandBuffer commandBuffer, int stencilTestEnable)
        {
            _vkCmdSetStencilTestEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetStencilTestEnable");
            _vkCmdSetStencilTestEnable_fnptr(commandBuffer, stencilTestEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void> _vkCmdSetStencilOp_fnptr = &vkCmdSetStencilOp_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetStencilOp_Lazy(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
        {
            _vkCmdSetStencilOp_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void>)VKLoader.GetInstanceProcAddress("vkCmdSetStencilOp");
            _vkCmdSetStencilOp_fnptr(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, void> _vkCmdSetPatchControlPointsEXT_fnptr = &vkCmdSetPatchControlPointsEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetPatchControlPointsEXT_Lazy(VkCommandBuffer commandBuffer, uint patchControlPoints)
        {
            _vkCmdSetPatchControlPointsEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdSetPatchControlPointsEXT");
            _vkCmdSetPatchControlPointsEXT_fnptr(commandBuffer, patchControlPoints);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetRasterizerDiscardEnable_fnptr = &vkCmdSetRasterizerDiscardEnable_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetRasterizerDiscardEnable_Lazy(VkCommandBuffer commandBuffer, int rasterizerDiscardEnable)
        {
            _vkCmdSetRasterizerDiscardEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetRasterizerDiscardEnable");
            _vkCmdSetRasterizerDiscardEnable_fnptr(commandBuffer, rasterizerDiscardEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthBiasEnable_fnptr = &vkCmdSetDepthBiasEnable_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDepthBiasEnable_Lazy(VkCommandBuffer commandBuffer, int depthBiasEnable)
        {
            _vkCmdSetDepthBiasEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDepthBiasEnable");
            _vkCmdSetDepthBiasEnable_fnptr(commandBuffer, depthBiasEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkLogicOp, void> _vkCmdSetLogicOpEXT_fnptr = &vkCmdSetLogicOpEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetLogicOpEXT_Lazy(VkCommandBuffer commandBuffer, VkLogicOp logicOp)
        {
            _vkCmdSetLogicOpEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkLogicOp, void>)VKLoader.GetInstanceProcAddress("vkCmdSetLogicOpEXT");
            _vkCmdSetLogicOpEXT_fnptr(commandBuffer, logicOp);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetPrimitiveRestartEnable_fnptr = &vkCmdSetPrimitiveRestartEnable_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetPrimitiveRestartEnable_Lazy(VkCommandBuffer commandBuffer, int primitiveRestartEnable)
        {
            _vkCmdSetPrimitiveRestartEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetPrimitiveRestartEnable");
            _vkCmdSetPrimitiveRestartEnable_fnptr(commandBuffer, primitiveRestartEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkTessellationDomainOrigin, void> _vkCmdSetTessellationDomainOriginEXT_fnptr = &vkCmdSetTessellationDomainOriginEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetTessellationDomainOriginEXT_Lazy(VkCommandBuffer commandBuffer, VkTessellationDomainOrigin domainOrigin)
        {
            _vkCmdSetTessellationDomainOriginEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkTessellationDomainOrigin, void>)VKLoader.GetInstanceProcAddress("vkCmdSetTessellationDomainOriginEXT");
            _vkCmdSetTessellationDomainOriginEXT_fnptr(commandBuffer, domainOrigin);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthClampEnableEXT_fnptr = &vkCmdSetDepthClampEnableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDepthClampEnableEXT_Lazy(VkCommandBuffer commandBuffer, int depthClampEnable)
        {
            _vkCmdSetDepthClampEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDepthClampEnableEXT");
            _vkCmdSetDepthClampEnableEXT_fnptr(commandBuffer, depthClampEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPolygonMode, void> _vkCmdSetPolygonModeEXT_fnptr = &vkCmdSetPolygonModeEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetPolygonModeEXT_Lazy(VkCommandBuffer commandBuffer, VkPolygonMode polygonMode)
        {
            _vkCmdSetPolygonModeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPolygonMode, void>)VKLoader.GetInstanceProcAddress("vkCmdSetPolygonModeEXT");
            _vkCmdSetPolygonModeEXT_fnptr(commandBuffer, polygonMode);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkSampleCountFlagBits, void> _vkCmdSetRasterizationSamplesEXT_fnptr = &vkCmdSetRasterizationSamplesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetRasterizationSamplesEXT_Lazy(VkCommandBuffer commandBuffer, VkSampleCountFlagBits rasterizationSamples)
        {
            _vkCmdSetRasterizationSamplesEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSampleCountFlagBits, void>)VKLoader.GetInstanceProcAddress("vkCmdSetRasterizationSamplesEXT");
            _vkCmdSetRasterizationSamplesEXT_fnptr(commandBuffer, rasterizationSamples);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkSampleCountFlagBits, uint*, void> _vkCmdSetSampleMaskEXT_fnptr = &vkCmdSetSampleMaskEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetSampleMaskEXT_Lazy(VkCommandBuffer commandBuffer, VkSampleCountFlagBits samples, uint* pSampleMask)
        {
            _vkCmdSetSampleMaskEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSampleCountFlagBits, uint*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetSampleMaskEXT");
            _vkCmdSetSampleMaskEXT_fnptr(commandBuffer, samples, pSampleMask);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetAlphaToCoverageEnableEXT_fnptr = &vkCmdSetAlphaToCoverageEnableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetAlphaToCoverageEnableEXT_Lazy(VkCommandBuffer commandBuffer, int alphaToCoverageEnable)
        {
            _vkCmdSetAlphaToCoverageEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetAlphaToCoverageEnableEXT");
            _vkCmdSetAlphaToCoverageEnableEXT_fnptr(commandBuffer, alphaToCoverageEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetAlphaToOneEnableEXT_fnptr = &vkCmdSetAlphaToOneEnableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetAlphaToOneEnableEXT_Lazy(VkCommandBuffer commandBuffer, int alphaToOneEnable)
        {
            _vkCmdSetAlphaToOneEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetAlphaToOneEnableEXT");
            _vkCmdSetAlphaToOneEnableEXT_fnptr(commandBuffer, alphaToOneEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetLogicOpEnableEXT_fnptr = &vkCmdSetLogicOpEnableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetLogicOpEnableEXT_Lazy(VkCommandBuffer commandBuffer, int logicOpEnable)
        {
            _vkCmdSetLogicOpEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetLogicOpEnableEXT");
            _vkCmdSetLogicOpEnableEXT_fnptr(commandBuffer, logicOpEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, int*, void> _vkCmdSetColorBlendEnableEXT_fnptr = &vkCmdSetColorBlendEnableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetColorBlendEnableEXT_Lazy(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, int* pColorBlendEnables)
        {
            _vkCmdSetColorBlendEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, int*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetColorBlendEnableEXT");
            _vkCmdSetColorBlendEnableEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEnables);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorBlendEquationEXT*, void> _vkCmdSetColorBlendEquationEXT_fnptr = &vkCmdSetColorBlendEquationEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetColorBlendEquationEXT_Lazy(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendEquationEXT* pColorBlendEquations)
        {
            _vkCmdSetColorBlendEquationEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorBlendEquationEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetColorBlendEquationEXT");
            _vkCmdSetColorBlendEquationEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEquations);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorComponentFlagBits*, void> _vkCmdSetColorWriteMaskEXT_fnptr = &vkCmdSetColorWriteMaskEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetColorWriteMaskEXT_Lazy(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorComponentFlagBits* pColorWriteMasks)
        {
            _vkCmdSetColorWriteMaskEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorComponentFlagBits*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetColorWriteMaskEXT");
            _vkCmdSetColorWriteMaskEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorWriteMasks);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, void> _vkCmdSetRasterizationStreamEXT_fnptr = &vkCmdSetRasterizationStreamEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetRasterizationStreamEXT_Lazy(VkCommandBuffer commandBuffer, uint rasterizationStream)
        {
            _vkCmdSetRasterizationStreamEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdSetRasterizationStreamEXT");
            _vkCmdSetRasterizationStreamEXT_fnptr(commandBuffer, rasterizationStream);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkConservativeRasterizationModeEXT, void> _vkCmdSetConservativeRasterizationModeEXT_fnptr = &vkCmdSetConservativeRasterizationModeEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetConservativeRasterizationModeEXT_Lazy(VkCommandBuffer commandBuffer, VkConservativeRasterizationModeEXT conservativeRasterizationMode)
        {
            _vkCmdSetConservativeRasterizationModeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkConservativeRasterizationModeEXT, void>)VKLoader.GetInstanceProcAddress("vkCmdSetConservativeRasterizationModeEXT");
            _vkCmdSetConservativeRasterizationModeEXT_fnptr(commandBuffer, conservativeRasterizationMode);
        }
        public static delegate* unmanaged<VkCommandBuffer, float, void> _vkCmdSetExtraPrimitiveOverestimationSizeEXT_fnptr = &vkCmdSetExtraPrimitiveOverestimationSizeEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetExtraPrimitiveOverestimationSizeEXT_Lazy(VkCommandBuffer commandBuffer, float extraPrimitiveOverestimationSize)
        {
            _vkCmdSetExtraPrimitiveOverestimationSizeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, float, void>)VKLoader.GetInstanceProcAddress("vkCmdSetExtraPrimitiveOverestimationSizeEXT");
            _vkCmdSetExtraPrimitiveOverestimationSizeEXT_fnptr(commandBuffer, extraPrimitiveOverestimationSize);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthClipEnableEXT_fnptr = &vkCmdSetDepthClipEnableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDepthClipEnableEXT_Lazy(VkCommandBuffer commandBuffer, int depthClipEnable)
        {
            _vkCmdSetDepthClipEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDepthClipEnableEXT");
            _vkCmdSetDepthClipEnableEXT_fnptr(commandBuffer, depthClipEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetSampleLocationsEnableEXT_fnptr = &vkCmdSetSampleLocationsEnableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetSampleLocationsEnableEXT_Lazy(VkCommandBuffer commandBuffer, int sampleLocationsEnable)
        {
            _vkCmdSetSampleLocationsEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetSampleLocationsEnableEXT");
            _vkCmdSetSampleLocationsEnableEXT_fnptr(commandBuffer, sampleLocationsEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorBlendAdvancedEXT*, void> _vkCmdSetColorBlendAdvancedEXT_fnptr = &vkCmdSetColorBlendAdvancedEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetColorBlendAdvancedEXT_Lazy(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendAdvancedEXT* pColorBlendAdvanced)
        {
            _vkCmdSetColorBlendAdvancedEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorBlendAdvancedEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetColorBlendAdvancedEXT");
            _vkCmdSetColorBlendAdvancedEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendAdvanced);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkProvokingVertexModeEXT, void> _vkCmdSetProvokingVertexModeEXT_fnptr = &vkCmdSetProvokingVertexModeEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetProvokingVertexModeEXT_Lazy(VkCommandBuffer commandBuffer, VkProvokingVertexModeEXT provokingVertexMode)
        {
            _vkCmdSetProvokingVertexModeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkProvokingVertexModeEXT, void>)VKLoader.GetInstanceProcAddress("vkCmdSetProvokingVertexModeEXT");
            _vkCmdSetProvokingVertexModeEXT_fnptr(commandBuffer, provokingVertexMode);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkLineRasterizationModeKHR, void> _vkCmdSetLineRasterizationModeEXT_fnptr = &vkCmdSetLineRasterizationModeEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetLineRasterizationModeEXT_Lazy(VkCommandBuffer commandBuffer, VkLineRasterizationModeKHR lineRasterizationMode)
        {
            _vkCmdSetLineRasterizationModeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkLineRasterizationModeKHR, void>)VKLoader.GetInstanceProcAddress("vkCmdSetLineRasterizationModeEXT");
            _vkCmdSetLineRasterizationModeEXT_fnptr(commandBuffer, lineRasterizationMode);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetLineStippleEnableEXT_fnptr = &vkCmdSetLineStippleEnableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetLineStippleEnableEXT_Lazy(VkCommandBuffer commandBuffer, int stippledLineEnable)
        {
            _vkCmdSetLineStippleEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetLineStippleEnableEXT");
            _vkCmdSetLineStippleEnableEXT_fnptr(commandBuffer, stippledLineEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthClipNegativeOneToOneEXT_fnptr = &vkCmdSetDepthClipNegativeOneToOneEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDepthClipNegativeOneToOneEXT_Lazy(VkCommandBuffer commandBuffer, int negativeOneToOne)
        {
            _vkCmdSetDepthClipNegativeOneToOneEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDepthClipNegativeOneToOneEXT");
            _vkCmdSetDepthClipNegativeOneToOneEXT_fnptr(commandBuffer, negativeOneToOne);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetViewportWScalingEnableNV_fnptr = &vkCmdSetViewportWScalingEnableNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetViewportWScalingEnableNV_Lazy(VkCommandBuffer commandBuffer, int viewportWScalingEnable)
        {
            _vkCmdSetViewportWScalingEnableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetViewportWScalingEnableNV");
            _vkCmdSetViewportWScalingEnableNV_fnptr(commandBuffer, viewportWScalingEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewportSwizzleNV*, void> _vkCmdSetViewportSwizzleNV_fnptr = &vkCmdSetViewportSwizzleNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetViewportSwizzleNV_Lazy(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportSwizzleNV* pViewportSwizzles)
        {
            _vkCmdSetViewportSwizzleNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewportSwizzleNV*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetViewportSwizzleNV");
            _vkCmdSetViewportSwizzleNV_fnptr(commandBuffer, firstViewport, viewportCount, pViewportSwizzles);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetCoverageToColorEnableNV_fnptr = &vkCmdSetCoverageToColorEnableNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetCoverageToColorEnableNV_Lazy(VkCommandBuffer commandBuffer, int coverageToColorEnable)
        {
            _vkCmdSetCoverageToColorEnableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetCoverageToColorEnableNV");
            _vkCmdSetCoverageToColorEnableNV_fnptr(commandBuffer, coverageToColorEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, void> _vkCmdSetCoverageToColorLocationNV_fnptr = &vkCmdSetCoverageToColorLocationNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetCoverageToColorLocationNV_Lazy(VkCommandBuffer commandBuffer, uint coverageToColorLocation)
        {
            _vkCmdSetCoverageToColorLocationNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdSetCoverageToColorLocationNV");
            _vkCmdSetCoverageToColorLocationNV_fnptr(commandBuffer, coverageToColorLocation);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCoverageModulationModeNV, void> _vkCmdSetCoverageModulationModeNV_fnptr = &vkCmdSetCoverageModulationModeNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetCoverageModulationModeNV_Lazy(VkCommandBuffer commandBuffer, VkCoverageModulationModeNV coverageModulationMode)
        {
            _vkCmdSetCoverageModulationModeNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCoverageModulationModeNV, void>)VKLoader.GetInstanceProcAddress("vkCmdSetCoverageModulationModeNV");
            _vkCmdSetCoverageModulationModeNV_fnptr(commandBuffer, coverageModulationMode);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetCoverageModulationTableEnableNV_fnptr = &vkCmdSetCoverageModulationTableEnableNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetCoverageModulationTableEnableNV_Lazy(VkCommandBuffer commandBuffer, int coverageModulationTableEnable)
        {
            _vkCmdSetCoverageModulationTableEnableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetCoverageModulationTableEnableNV");
            _vkCmdSetCoverageModulationTableEnableNV_fnptr(commandBuffer, coverageModulationTableEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, float*, void> _vkCmdSetCoverageModulationTableNV_fnptr = &vkCmdSetCoverageModulationTableNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetCoverageModulationTableNV_Lazy(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, float* pCoverageModulationTable)
        {
            _vkCmdSetCoverageModulationTableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, float*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetCoverageModulationTableNV");
            _vkCmdSetCoverageModulationTableNV_fnptr(commandBuffer, coverageModulationTableCount, pCoverageModulationTable);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetShadingRateImageEnableNV_fnptr = &vkCmdSetShadingRateImageEnableNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetShadingRateImageEnableNV_Lazy(VkCommandBuffer commandBuffer, int shadingRateImageEnable)
        {
            _vkCmdSetShadingRateImageEnableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetShadingRateImageEnableNV");
            _vkCmdSetShadingRateImageEnableNV_fnptr(commandBuffer, shadingRateImageEnable);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCoverageReductionModeNV, void> _vkCmdSetCoverageReductionModeNV_fnptr = &vkCmdSetCoverageReductionModeNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetCoverageReductionModeNV_Lazy(VkCommandBuffer commandBuffer, VkCoverageReductionModeNV coverageReductionMode)
        {
            _vkCmdSetCoverageReductionModeNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCoverageReductionModeNV, void>)VKLoader.GetInstanceProcAddress("vkCmdSetCoverageReductionModeNV");
            _vkCmdSetCoverageReductionModeNV_fnptr(commandBuffer, coverageReductionMode);
        }
        public static delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetRepresentativeFragmentTestEnableNV_fnptr = &vkCmdSetRepresentativeFragmentTestEnableNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetRepresentativeFragmentTestEnableNV_Lazy(VkCommandBuffer commandBuffer, int representativeFragmentTestEnable)
        {
            _vkCmdSetRepresentativeFragmentTestEnableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetInstanceProcAddress("vkCmdSetRepresentativeFragmentTestEnableNV");
            _vkCmdSetRepresentativeFragmentTestEnableNV_fnptr(commandBuffer, representativeFragmentTestEnable);
        }
        public static delegate* unmanaged<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult> _vkCreatePrivateDataSlot_fnptr = &vkCreatePrivateDataSlot_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreatePrivateDataSlot_Lazy(VkDevice device, VkPrivateDataSlotCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlot* pPrivateDataSlot)
        {
            _vkCreatePrivateDataSlot_fnptr = (delegate* unmanaged<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreatePrivateDataSlot");
            return _vkCreatePrivateDataSlot_fnptr(device, pCreateInfo, pAllocator, pPrivateDataSlot);
        }
        public static delegate* unmanaged<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> _vkDestroyPrivateDataSlot_fnptr = &vkDestroyPrivateDataSlot_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyPrivateDataSlot_Lazy(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyPrivateDataSlot_fnptr = (delegate* unmanaged<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyPrivateDataSlot");
            _vkDestroyPrivateDataSlot_fnptr(device, privateDataSlot, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult> _vkSetPrivateData_fnptr = &vkSetPrivateData_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkSetPrivateData_Lazy(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data)
        {
            _vkSetPrivateData_fnptr = (delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult>)VKLoader.GetInstanceProcAddress("vkSetPrivateData");
            return _vkSetPrivateData_fnptr(device, objectType, objectHandle, privateDataSlot, data);
        }
        public static delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void> _vkGetPrivateData_fnptr = &vkGetPrivateData_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetPrivateData_Lazy(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong* pData)
        {
            _vkGetPrivateData_fnptr = (delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void>)VKLoader.GetInstanceProcAddress("vkGetPrivateData");
            _vkGetPrivateData_fnptr(device, objectType, objectHandle, privateDataSlot, pData);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCopyBufferInfo2*, void> _vkCmdCopyBuffer2_fnptr = &vkCmdCopyBuffer2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyBuffer2_Lazy(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* pCopyBufferInfo)
        {
            _vkCmdCopyBuffer2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyBufferInfo2*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyBuffer2");
            _vkCmdCopyBuffer2_fnptr(commandBuffer, pCopyBufferInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCopyImageInfo2*, void> _vkCmdCopyImage2_fnptr = &vkCmdCopyImage2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyImage2_Lazy(VkCommandBuffer commandBuffer, VkCopyImageInfo2* pCopyImageInfo)
        {
            _vkCmdCopyImage2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyImageInfo2*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyImage2");
            _vkCmdCopyImage2_fnptr(commandBuffer, pCopyImageInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBlitImageInfo2*, void> _vkCmdBlitImage2_fnptr = &vkCmdBlitImage2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBlitImage2_Lazy(VkCommandBuffer commandBuffer, VkBlitImageInfo2* pBlitImageInfo)
        {
            _vkCmdBlitImage2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBlitImageInfo2*, void>)VKLoader.GetInstanceProcAddress("vkCmdBlitImage2");
            _vkCmdBlitImage2_fnptr(commandBuffer, pBlitImageInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> _vkCmdCopyBufferToImage2_fnptr = &vkCmdCopyBufferToImage2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyBufferToImage2_Lazy(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
        {
            _vkCmdCopyBufferToImage2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyBufferToImageInfo2*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyBufferToImage2");
            _vkCmdCopyBufferToImage2_fnptr(commandBuffer, pCopyBufferToImageInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> _vkCmdCopyImageToBuffer2_fnptr = &vkCmdCopyImageToBuffer2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyImageToBuffer2_Lazy(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
        {
            _vkCmdCopyImageToBuffer2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyImageToBufferInfo2*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyImageToBuffer2");
            _vkCmdCopyImageToBuffer2_fnptr(commandBuffer, pCopyImageToBufferInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkResolveImageInfo2*, void> _vkCmdResolveImage2_fnptr = &vkCmdResolveImage2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdResolveImage2_Lazy(VkCommandBuffer commandBuffer, VkResolveImageInfo2* pResolveImageInfo)
        {
            _vkCmdResolveImage2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkResolveImageInfo2*, void>)VKLoader.GetInstanceProcAddress("vkCmdResolveImage2");
            _vkCmdResolveImage2_fnptr(commandBuffer, pResolveImageInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkRefreshObjectListKHR*, void> _vkCmdRefreshObjectsKHR_fnptr = &vkCmdRefreshObjectsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdRefreshObjectsKHR_Lazy(VkCommandBuffer commandBuffer, VkRefreshObjectListKHR* pRefreshObjects)
        {
            _vkCmdRefreshObjectsKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRefreshObjectListKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdRefreshObjectsKHR");
            _vkCmdRefreshObjectsKHR_fnptr(commandBuffer, pRefreshObjects);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkObjectType*, VkResult> _vkGetPhysicalDeviceRefreshableObjectTypesKHR_fnptr = &vkGetPhysicalDeviceRefreshableObjectTypesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceRefreshableObjectTypesKHR_Lazy(VkPhysicalDevice physicalDevice, uint* pRefreshableObjectTypeCount, VkObjectType* pRefreshableObjectTypes)
        {
            _vkGetPhysicalDeviceRefreshableObjectTypesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkObjectType*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceRefreshableObjectTypesKHR");
            return _vkGetPhysicalDeviceRefreshableObjectTypesKHR_fnptr(physicalDevice, pRefreshableObjectTypeCount, pRefreshableObjectTypes);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkExtent2D*, VkFragmentShadingRateCombinerOpKHR*, void> _vkCmdSetFragmentShadingRateKHR_fnptr = &vkCmdSetFragmentShadingRateKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetFragmentShadingRateKHR_Lazy(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR* combinerOps)
        {
            _vkCmdSetFragmentShadingRateKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkExtent2D*, VkFragmentShadingRateCombinerOpKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetFragmentShadingRateKHR");
            _vkCmdSetFragmentShadingRateKHR_fnptr(commandBuffer, pFragmentSize, combinerOps);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult> _vkGetPhysicalDeviceFragmentShadingRatesKHR_fnptr = &vkGetPhysicalDeviceFragmentShadingRatesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR_Lazy(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
        {
            _vkGetPhysicalDeviceFragmentShadingRatesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceFragmentShadingRatesKHR");
            return _vkGetPhysicalDeviceFragmentShadingRatesKHR_fnptr(physicalDevice, pFragmentShadingRateCount, pFragmentShadingRates);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkFragmentShadingRateNV, VkFragmentShadingRateCombinerOpKHR*, void> _vkCmdSetFragmentShadingRateEnumNV_fnptr = &vkCmdSetFragmentShadingRateEnumNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetFragmentShadingRateEnumNV_Lazy(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR* combinerOps)
        {
            _vkCmdSetFragmentShadingRateEnumNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkFragmentShadingRateNV, VkFragmentShadingRateCombinerOpKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetFragmentShadingRateEnumNV");
            _vkCmdSetFragmentShadingRateEnumNV_fnptr(commandBuffer, shadingRate, combinerOps);
        }
        public static delegate* unmanaged<VkDevice, VkAccelerationStructureBuildTypeKHR, VkAccelerationStructureBuildGeometryInfoKHR*, uint*, VkAccelerationStructureBuildSizesInfoKHR*, void> _vkGetAccelerationStructureBuildSizesKHR_fnptr = &vkGetAccelerationStructureBuildSizesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetAccelerationStructureBuildSizesKHR_Lazy(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            _vkGetAccelerationStructureBuildSizesKHR_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureBuildTypeKHR, VkAccelerationStructureBuildGeometryInfoKHR*, uint*, VkAccelerationStructureBuildSizesInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkGetAccelerationStructureBuildSizesKHR");
            _vkGetAccelerationStructureBuildSizesKHR_fnptr(device, buildType, pBuildInfo, pMaxPrimitiveCounts, pSizeInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void> _vkCmdSetVertexInputEXT_fnptr = &vkCmdSetVertexInputEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetVertexInputEXT_Lazy(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
        {
            _vkCmdSetVertexInputEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetVertexInputEXT");
            _vkCmdSetVertexInputEXT_fnptr(commandBuffer, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, pVertexAttributeDescriptions);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, int*, void> _vkCmdSetColorWriteEnableEXT_fnptr = &vkCmdSetColorWriteEnableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetColorWriteEnableEXT_Lazy(VkCommandBuffer commandBuffer, uint attachmentCount, int* pColorWriteEnables)
        {
            _vkCmdSetColorWriteEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, int*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetColorWriteEnableEXT");
            _vkCmdSetColorWriteEnableEXT_fnptr(commandBuffer, attachmentCount, pColorWriteEnables);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> _vkCmdSetEvent2_fnptr = &vkCmdSetEvent2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetEvent2_Lazy(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfo* pDependencyInfo)
        {
            _vkCmdSetEvent2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkEvent, VkDependencyInfo*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetEvent2");
            _vkCmdSetEvent2_fnptr(commandBuffer, @event, pDependencyInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits2, void> _vkCmdResetEvent2_fnptr = &vkCmdResetEvent2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdResetEvent2_Lazy(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits2 stageMask)
        {
            _vkCmdResetEvent2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits2, void>)VKLoader.GetInstanceProcAddress("vkCmdResetEvent2");
            _vkCmdResetEvent2_fnptr(commandBuffer, @event, stageMask);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void> _vkCmdWaitEvents2_fnptr = &vkCmdWaitEvents2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdWaitEvents2_Lazy(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfo* pDependencyInfos)
        {
            _vkCmdWaitEvents2_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void>)VKLoader.GetInstanceProcAddress("vkCmdWaitEvents2");
            _vkCmdWaitEvents2_fnptr(commandBuffer, eventCount, pEvents, pDependencyInfos);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkDependencyInfo*, void> _vkCmdPipelineBarrier2_fnptr = &vkCmdPipelineBarrier2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdPipelineBarrier2_Lazy(VkCommandBuffer commandBuffer, VkDependencyInfo* pDependencyInfo)
        {
            _vkCmdPipelineBarrier2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDependencyInfo*, void>)VKLoader.GetInstanceProcAddress("vkCmdPipelineBarrier2");
            _vkCmdPipelineBarrier2_fnptr(commandBuffer, pDependencyInfo);
        }
        public static delegate* unmanaged<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult> _vkQueueSubmit2_fnptr = &vkQueueSubmit2_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkQueueSubmit2_Lazy(VkQueue queue, uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence)
        {
            _vkQueueSubmit2_fnptr = (delegate* unmanaged<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult>)VKLoader.GetInstanceProcAddress("vkQueueSubmit2");
            return _vkQueueSubmit2_fnptr(queue, submitCount, pSubmits, fence);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits2, VkQueryPool, uint, void> _vkCmdWriteTimestamp2_fnptr = &vkCmdWriteTimestamp2_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdWriteTimestamp2_Lazy(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits2 stage, VkQueryPool queryPool, uint query)
        {
            _vkCmdWriteTimestamp2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits2, VkQueryPool, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdWriteTimestamp2");
            _vkCmdWriteTimestamp2_fnptr(commandBuffer, stage, queryPool, query);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits2, VkBuffer, ulong, uint, void> _vkCmdWriteBufferMarker2AMD_fnptr = &vkCmdWriteBufferMarker2AMD_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdWriteBufferMarker2AMD_Lazy(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits2 stage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
        {
            _vkCmdWriteBufferMarker2AMD_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits2, VkBuffer, ulong, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdWriteBufferMarker2AMD");
            _vkCmdWriteBufferMarker2AMD_fnptr(commandBuffer, stage, dstBuffer, dstOffset, marker);
        }
        public static delegate* unmanaged<VkQueue, uint*, VkCheckpointData2NV*, void> _vkGetQueueCheckpointData2NV_fnptr = &vkGetQueueCheckpointData2NV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetQueueCheckpointData2NV_Lazy(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
        {
            _vkGetQueueCheckpointData2NV_fnptr = (delegate* unmanaged<VkQueue, uint*, VkCheckpointData2NV*, void>)VKLoader.GetInstanceProcAddress("vkGetQueueCheckpointData2NV");
            _vkGetQueueCheckpointData2NV_fnptr(queue, pCheckpointDataCount, pCheckpointData);
        }
        public static delegate* unmanaged<VkDevice, VkCopyMemoryToImageInfoEXT*, VkResult> _vkCopyMemoryToImageEXT_fnptr = &vkCopyMemoryToImageEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCopyMemoryToImageEXT_Lazy(VkDevice device, VkCopyMemoryToImageInfoEXT* pCopyMemoryToImageInfo)
        {
            _vkCopyMemoryToImageEXT_fnptr = (delegate* unmanaged<VkDevice, VkCopyMemoryToImageInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkCopyMemoryToImageEXT");
            return _vkCopyMemoryToImageEXT_fnptr(device, pCopyMemoryToImageInfo);
        }
        public static delegate* unmanaged<VkDevice, VkCopyImageToMemoryInfoEXT*, VkResult> _vkCopyImageToMemoryEXT_fnptr = &vkCopyImageToMemoryEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCopyImageToMemoryEXT_Lazy(VkDevice device, VkCopyImageToMemoryInfoEXT* pCopyImageToMemoryInfo)
        {
            _vkCopyImageToMemoryEXT_fnptr = (delegate* unmanaged<VkDevice, VkCopyImageToMemoryInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkCopyImageToMemoryEXT");
            return _vkCopyImageToMemoryEXT_fnptr(device, pCopyImageToMemoryInfo);
        }
        public static delegate* unmanaged<VkDevice, VkCopyImageToImageInfoEXT*, VkResult> _vkCopyImageToImageEXT_fnptr = &vkCopyImageToImageEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCopyImageToImageEXT_Lazy(VkDevice device, VkCopyImageToImageInfoEXT* pCopyImageToImageInfo)
        {
            _vkCopyImageToImageEXT_fnptr = (delegate* unmanaged<VkDevice, VkCopyImageToImageInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkCopyImageToImageEXT");
            return _vkCopyImageToImageEXT_fnptr(device, pCopyImageToImageInfo);
        }
        public static delegate* unmanaged<VkDevice, uint, VkHostImageLayoutTransitionInfoEXT*, VkResult> _vkTransitionImageLayoutEXT_fnptr = &vkTransitionImageLayoutEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkTransitionImageLayoutEXT_Lazy(VkDevice device, uint transitionCount, VkHostImageLayoutTransitionInfoEXT* pTransitions)
        {
            _vkTransitionImageLayoutEXT_fnptr = (delegate* unmanaged<VkDevice, uint, VkHostImageLayoutTransitionInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkTransitionImageLayoutEXT");
            return _vkTransitionImageLayoutEXT_fnptr(device, transitionCount, pTransitions);
        }
        public static delegate* unmanaged<VkDevice, VkCommandPool, VkCommandBuffer, VkCommandPoolMemoryConsumption*, void> _vkGetCommandPoolMemoryConsumption_fnptr = &vkGetCommandPoolMemoryConsumption_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetCommandPoolMemoryConsumption_Lazy(VkDevice device, VkCommandPool commandPool, VkCommandBuffer commandBuffer, VkCommandPoolMemoryConsumption* pConsumption)
        {
            _vkGetCommandPoolMemoryConsumption_fnptr = (delegate* unmanaged<VkDevice, VkCommandPool, VkCommandBuffer, VkCommandPoolMemoryConsumption*, void>)VKLoader.GetInstanceProcAddress("vkGetCommandPoolMemoryConsumption");
            _vkGetCommandPoolMemoryConsumption_fnptr(device, commandPool, commandBuffer, pConsumption);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkVideoProfileInfoKHR*, VkVideoCapabilitiesKHR*, VkResult> _vkGetPhysicalDeviceVideoCapabilitiesKHR_fnptr = &vkGetPhysicalDeviceVideoCapabilitiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR_Lazy(VkPhysicalDevice physicalDevice, VkVideoProfileInfoKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
        {
            _vkGetPhysicalDeviceVideoCapabilitiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkVideoProfileInfoKHR*, VkVideoCapabilitiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceVideoCapabilitiesKHR");
            return _vkGetPhysicalDeviceVideoCapabilitiesKHR_fnptr(physicalDevice, pVideoProfile, pCapabilities);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceVideoFormatInfoKHR*, uint*, VkVideoFormatPropertiesKHR*, VkResult> _vkGetPhysicalDeviceVideoFormatPropertiesKHR_fnptr = &vkGetPhysicalDeviceVideoFormatPropertiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            _vkGetPhysicalDeviceVideoFormatPropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceVideoFormatInfoKHR*, uint*, VkVideoFormatPropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceVideoFormatPropertiesKHR");
            return _vkGetPhysicalDeviceVideoFormatPropertiesKHR_fnptr(physicalDevice, pVideoFormatInfo, pVideoFormatPropertyCount, pVideoFormatProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR*, VkVideoEncodeQualityLevelPropertiesKHR*, VkResult> _vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_fnptr = &vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_Lazy(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo, VkVideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties)
        {
            _vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR*, VkVideoEncodeQualityLevelPropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR");
            return _vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_fnptr(physicalDevice, pQualityLevelInfo, pQualityLevelProperties);
        }
        public static delegate* unmanaged<VkDevice, VkVideoSessionCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionKHR*, VkResult> _vkCreateVideoSessionKHR_fnptr = &vkCreateVideoSessionKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateVideoSessionKHR_Lazy(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            _vkCreateVideoSessionKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateVideoSessionKHR");
            return _vkCreateVideoSessionKHR_fnptr(device, pCreateInfo, pAllocator, pVideoSession);
        }
        public static delegate* unmanaged<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void> _vkDestroyVideoSessionKHR_fnptr = &vkDestroyVideoSessionKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyVideoSessionKHR_Lazy(VkDevice device, VkVideoSessionKHR videoSession, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyVideoSessionKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyVideoSessionKHR");
            _vkDestroyVideoSessionKHR_fnptr(device, videoSession, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkVideoSessionParametersCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionParametersKHR*, VkResult> _vkCreateVideoSessionParametersKHR_fnptr = &vkCreateVideoSessionParametersKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateVideoSessionParametersKHR_Lazy(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            _vkCreateVideoSessionParametersKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionParametersCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionParametersKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateVideoSessionParametersKHR");
            return _vkCreateVideoSessionParametersKHR_fnptr(device, pCreateInfo, pAllocator, pVideoSessionParameters);
        }
        public static delegate* unmanaged<VkDevice, VkVideoSessionParametersKHR, VkVideoSessionParametersUpdateInfoKHR*, VkResult> _vkUpdateVideoSessionParametersKHR_fnptr = &vkUpdateVideoSessionParametersKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkUpdateVideoSessionParametersKHR_Lazy(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo)
        {
            _vkUpdateVideoSessionParametersKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionParametersKHR, VkVideoSessionParametersUpdateInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkUpdateVideoSessionParametersKHR");
            return _vkUpdateVideoSessionParametersKHR_fnptr(device, videoSessionParameters, pUpdateInfo);
        }
        public static delegate* unmanaged<VkDevice, VkVideoEncodeSessionParametersGetInfoKHR*, VkVideoEncodeSessionParametersFeedbackInfoKHR*, nuint*, void*, VkResult> _vkGetEncodedVideoSessionParametersKHR_fnptr = &vkGetEncodedVideoSessionParametersKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetEncodedVideoSessionParametersKHR_Lazy(VkDevice device, VkVideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, VkVideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, nuint* pDataSize, void* pData)
        {
            _vkGetEncodedVideoSessionParametersKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoEncodeSessionParametersGetInfoKHR*, VkVideoEncodeSessionParametersFeedbackInfoKHR*, nuint*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetEncodedVideoSessionParametersKHR");
            return _vkGetEncodedVideoSessionParametersKHR_fnptr(device, pVideoSessionParametersInfo, pFeedbackInfo, pDataSize, pData);
        }
        public static delegate* unmanaged<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void> _vkDestroyVideoSessionParametersKHR_fnptr = &vkDestroyVideoSessionParametersKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyVideoSessionParametersKHR_Lazy(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyVideoSessionParametersKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyVideoSessionParametersKHR");
            _vkDestroyVideoSessionParametersKHR_fnptr(device, videoSessionParameters, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkVideoSessionKHR, uint*, VkVideoSessionMemoryRequirementsKHR*, VkResult> _vkGetVideoSessionMemoryRequirementsKHR_fnptr = &vkGetVideoSessionMemoryRequirementsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetVideoSessionMemoryRequirementsKHR_Lazy(VkDevice device, VkVideoSessionKHR videoSession, uint* pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
        {
            _vkGetVideoSessionMemoryRequirementsKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionKHR, uint*, VkVideoSessionMemoryRequirementsKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetVideoSessionMemoryRequirementsKHR");
            return _vkGetVideoSessionMemoryRequirementsKHR_fnptr(device, videoSession, pMemoryRequirementsCount, pMemoryRequirements);
        }
        public static delegate* unmanaged<VkDevice, VkVideoSessionKHR, uint, VkBindVideoSessionMemoryInfoKHR*, VkResult> _vkBindVideoSessionMemoryKHR_fnptr = &vkBindVideoSessionMemoryKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkBindVideoSessionMemoryKHR_Lazy(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, VkBindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos)
        {
            _vkBindVideoSessionMemoryKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionKHR, uint, VkBindVideoSessionMemoryInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkBindVideoSessionMemoryKHR");
            return _vkBindVideoSessionMemoryKHR_fnptr(device, videoSession, bindSessionMemoryInfoCount, pBindSessionMemoryInfos);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkVideoDecodeInfoKHR*, void> _vkCmdDecodeVideoKHR_fnptr = &vkCmdDecodeVideoKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDecodeVideoKHR_Lazy(VkCommandBuffer commandBuffer, VkVideoDecodeInfoKHR* pDecodeInfo)
        {
            _vkCmdDecodeVideoKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkVideoDecodeInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdDecodeVideoKHR");
            _vkCmdDecodeVideoKHR_fnptr(commandBuffer, pDecodeInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void> _vkCmdBeginVideoCodingKHR_fnptr = &vkCmdBeginVideoCodingKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBeginVideoCodingKHR_Lazy(VkCommandBuffer commandBuffer, VkVideoBeginCodingInfoKHR* pBeginInfo)
        {
            _vkCmdBeginVideoCodingKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdBeginVideoCodingKHR");
            _vkCmdBeginVideoCodingKHR_fnptr(commandBuffer, pBeginInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void> _vkCmdControlVideoCodingKHR_fnptr = &vkCmdControlVideoCodingKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdControlVideoCodingKHR_Lazy(VkCommandBuffer commandBuffer, VkVideoCodingControlInfoKHR* pCodingControlInfo)
        {
            _vkCmdControlVideoCodingKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdControlVideoCodingKHR");
            _vkCmdControlVideoCodingKHR_fnptr(commandBuffer, pCodingControlInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void> _vkCmdEndVideoCodingKHR_fnptr = &vkCmdEndVideoCodingKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdEndVideoCodingKHR_Lazy(VkCommandBuffer commandBuffer, VkVideoEndCodingInfoKHR* pEndCodingInfo)
        {
            _vkCmdEndVideoCodingKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdEndVideoCodingKHR");
            _vkCmdEndVideoCodingKHR_fnptr(commandBuffer, pEndCodingInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkVideoEncodeInfoKHR*, void> _vkCmdEncodeVideoKHR_fnptr = &vkCmdEncodeVideoKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdEncodeVideoKHR_Lazy(VkCommandBuffer commandBuffer, VkVideoEncodeInfoKHR* pEncodeInfo)
        {
            _vkCmdEncodeVideoKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkVideoEncodeInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdEncodeVideoKHR");
            _vkCmdEncodeVideoKHR_fnptr(commandBuffer, pEncodeInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkDecompressMemoryRegionNV*, void> _vkCmdDecompressMemoryNV_fnptr = &vkCmdDecompressMemoryNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDecompressMemoryNV_Lazy(VkCommandBuffer commandBuffer, uint decompressRegionCount, VkDecompressMemoryRegionNV* pDecompressMemoryRegions)
        {
            _vkCmdDecompressMemoryNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkDecompressMemoryRegionNV*, void>)VKLoader.GetInstanceProcAddress("vkCmdDecompressMemoryNV");
            _vkCmdDecompressMemoryNV_fnptr(commandBuffer, decompressRegionCount, pDecompressMemoryRegions);
        }
        public static delegate* unmanaged<VkCommandBuffer, ulong, ulong, uint, void> _vkCmdDecompressMemoryIndirectCountNV_fnptr = &vkCmdDecompressMemoryIndirectCountNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDecompressMemoryIndirectCountNV_Lazy(VkCommandBuffer commandBuffer, ulong indirectCommandsAddress, ulong indirectCommandsCountAddress, uint stride)
        {
            _vkCmdDecompressMemoryIndirectCountNV_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, ulong, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdDecompressMemoryIndirectCountNV");
            _vkCmdDecompressMemoryIndirectCountNV_fnptr(commandBuffer, indirectCommandsAddress, indirectCommandsCountAddress, stride);
        }
        public static delegate* unmanaged<VkDevice, VkCuModuleCreateInfoNVX*, VkAllocationCallbacks*, VkCuModuleNVX*, VkResult> _vkCreateCuModuleNVX_fnptr = &vkCreateCuModuleNVX_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateCuModuleNVX_Lazy(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
        {
            _vkCreateCuModuleNVX_fnptr = (delegate* unmanaged<VkDevice, VkCuModuleCreateInfoNVX*, VkAllocationCallbacks*, VkCuModuleNVX*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateCuModuleNVX");
            return _vkCreateCuModuleNVX_fnptr(device, pCreateInfo, pAllocator, pModule);
        }
        public static delegate* unmanaged<VkDevice, VkCuFunctionCreateInfoNVX*, VkAllocationCallbacks*, VkCuFunctionNVX*, VkResult> _vkCreateCuFunctionNVX_fnptr = &vkCreateCuFunctionNVX_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateCuFunctionNVX_Lazy(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
        {
            _vkCreateCuFunctionNVX_fnptr = (delegate* unmanaged<VkDevice, VkCuFunctionCreateInfoNVX*, VkAllocationCallbacks*, VkCuFunctionNVX*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateCuFunctionNVX");
            return _vkCreateCuFunctionNVX_fnptr(device, pCreateInfo, pAllocator, pFunction);
        }
        public static delegate* unmanaged<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void> _vkDestroyCuModuleNVX_fnptr = &vkDestroyCuModuleNVX_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyCuModuleNVX_Lazy(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyCuModuleNVX_fnptr = (delegate* unmanaged<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyCuModuleNVX");
            _vkDestroyCuModuleNVX_fnptr(device, module, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void> _vkDestroyCuFunctionNVX_fnptr = &vkDestroyCuFunctionNVX_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyCuFunctionNVX_Lazy(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyCuFunctionNVX_fnptr = (delegate* unmanaged<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyCuFunctionNVX");
            _vkDestroyCuFunctionNVX_fnptr(device, function, pAllocator);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCuLaunchInfoNVX*, void> _vkCmdCuLaunchKernelNVX_fnptr = &vkCmdCuLaunchKernelNVX_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCuLaunchKernelNVX_Lazy(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo)
        {
            _vkCmdCuLaunchKernelNVX_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCuLaunchInfoNVX*, void>)VKLoader.GetInstanceProcAddress("vkCmdCuLaunchKernelNVX");
            _vkCmdCuLaunchKernelNVX_fnptr(commandBuffer, pLaunchInfo);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorSetLayout, ulong*, void> _vkGetDescriptorSetLayoutSizeEXT_fnptr = &vkGetDescriptorSetLayoutSizeEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDescriptorSetLayoutSizeEXT_Lazy(VkDevice device, VkDescriptorSetLayout layout, ulong* pLayoutSizeInBytes)
        {
            _vkGetDescriptorSetLayoutSizeEXT_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetLayout, ulong*, void>)VKLoader.GetInstanceProcAddress("vkGetDescriptorSetLayoutSizeEXT");
            _vkGetDescriptorSetLayoutSizeEXT_fnptr(device, layout, pLayoutSizeInBytes);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorSetLayout, uint, ulong*, void> _vkGetDescriptorSetLayoutBindingOffsetEXT_fnptr = &vkGetDescriptorSetLayoutBindingOffsetEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDescriptorSetLayoutBindingOffsetEXT_Lazy(VkDevice device, VkDescriptorSetLayout layout, uint binding, ulong* pOffset)
        {
            _vkGetDescriptorSetLayoutBindingOffsetEXT_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetLayout, uint, ulong*, void>)VKLoader.GetInstanceProcAddress("vkGetDescriptorSetLayoutBindingOffsetEXT");
            _vkGetDescriptorSetLayoutBindingOffsetEXT_fnptr(device, layout, binding, pOffset);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorGetInfoEXT*, nuint, void*, void> _vkGetDescriptorEXT_fnptr = &vkGetDescriptorEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDescriptorEXT_Lazy(VkDevice device, VkDescriptorGetInfoEXT* pDescriptorInfo, nuint dataSize, void* pDescriptor)
        {
            _vkGetDescriptorEXT_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorGetInfoEXT*, nuint, void*, void>)VKLoader.GetInstanceProcAddress("vkGetDescriptorEXT");
            _vkGetDescriptorEXT_fnptr(device, pDescriptorInfo, dataSize, pDescriptor);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkDescriptorBufferBindingInfoEXT*, void> _vkCmdBindDescriptorBuffersEXT_fnptr = &vkCmdBindDescriptorBuffersEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindDescriptorBuffersEXT_Lazy(VkCommandBuffer commandBuffer, uint bufferCount, VkDescriptorBufferBindingInfoEXT* pBindingInfos)
        {
            _vkCmdBindDescriptorBuffersEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkDescriptorBufferBindingInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdBindDescriptorBuffersEXT");
            _vkCmdBindDescriptorBuffersEXT_fnptr(commandBuffer, bufferCount, pBindingInfos);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, uint*, ulong*, void> _vkCmdSetDescriptorBufferOffsetsEXT_fnptr = &vkCmdSetDescriptorBufferOffsetsEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDescriptorBufferOffsetsEXT_Lazy(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, ulong* pOffsets)
        {
            _vkCmdSetDescriptorBufferOffsetsEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, uint*, ulong*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDescriptorBufferOffsetsEXT");
            _vkCmdSetDescriptorBufferOffsetsEXT_fnptr(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, pBufferIndices, pOffsets);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void> _vkCmdBindDescriptorBufferEmbeddedSamplersEXT_fnptr = &vkCmdBindDescriptorBufferEmbeddedSamplersEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindDescriptorBufferEmbeddedSamplersEXT_Lazy(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set)
        {
            _vkCmdBindDescriptorBufferEmbeddedSamplersEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdBindDescriptorBufferEmbeddedSamplersEXT");
            _vkCmdBindDescriptorBufferEmbeddedSamplersEXT_fnptr(commandBuffer, pipelineBindPoint, layout, set);
        }
        public static delegate* unmanaged<VkDevice, VkBufferCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetBufferOpaqueCaptureDescriptorDataEXT_fnptr = &vkGetBufferOpaqueCaptureDescriptorDataEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetBufferOpaqueCaptureDescriptorDataEXT_Lazy(VkDevice device, VkBufferCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            _vkGetBufferOpaqueCaptureDescriptorDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkBufferCaptureDescriptorDataInfoEXT*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetBufferOpaqueCaptureDescriptorDataEXT");
            return _vkGetBufferOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static delegate* unmanaged<VkDevice, VkImageCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetImageOpaqueCaptureDescriptorDataEXT_fnptr = &vkGetImageOpaqueCaptureDescriptorDataEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetImageOpaqueCaptureDescriptorDataEXT_Lazy(VkDevice device, VkImageCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            _vkGetImageOpaqueCaptureDescriptorDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkImageCaptureDescriptorDataInfoEXT*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetImageOpaqueCaptureDescriptorDataEXT");
            return _vkGetImageOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static delegate* unmanaged<VkDevice, VkImageViewCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetImageViewOpaqueCaptureDescriptorDataEXT_fnptr = &vkGetImageViewOpaqueCaptureDescriptorDataEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetImageViewOpaqueCaptureDescriptorDataEXT_Lazy(VkDevice device, VkImageViewCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            _vkGetImageViewOpaqueCaptureDescriptorDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkImageViewCaptureDescriptorDataInfoEXT*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetImageViewOpaqueCaptureDescriptorDataEXT");
            return _vkGetImageViewOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static delegate* unmanaged<VkDevice, VkSamplerCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetSamplerOpaqueCaptureDescriptorDataEXT_fnptr = &vkGetSamplerOpaqueCaptureDescriptorDataEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetSamplerOpaqueCaptureDescriptorDataEXT_Lazy(VkDevice device, VkSamplerCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            _vkGetSamplerOpaqueCaptureDescriptorDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkSamplerCaptureDescriptorDataInfoEXT*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetSamplerOpaqueCaptureDescriptorDataEXT");
            return _vkGetSamplerOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static delegate* unmanaged<VkDevice, VkAccelerationStructureCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_fnptr = &vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_Lazy(VkDevice device, VkAccelerationStructureCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            _vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureCaptureDescriptorDataInfoEXT*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT");
            return _vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceMemory, float, void> _vkSetDeviceMemoryPriorityEXT_fnptr = &vkSetDeviceMemoryPriorityEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkSetDeviceMemoryPriorityEXT_Lazy(VkDevice device, VkDeviceMemory memory, float priority)
        {
            _vkSetDeviceMemoryPriorityEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemory, float, void>)VKLoader.GetInstanceProcAddress("vkSetDeviceMemoryPriorityEXT");
            _vkSetDeviceMemoryPriorityEXT_fnptr(device, memory, priority);
        }
        public static delegate* unmanaged<VkPhysicalDevice, int, VkDisplayKHR, VkResult> _vkAcquireDrmDisplayEXT_fnptr = &vkAcquireDrmDisplayEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkAcquireDrmDisplayEXT_Lazy(VkPhysicalDevice physicalDevice, int drmFd, VkDisplayKHR display)
        {
            _vkAcquireDrmDisplayEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, int, VkDisplayKHR, VkResult>)VKLoader.GetInstanceProcAddress("vkAcquireDrmDisplayEXT");
            return _vkAcquireDrmDisplayEXT_fnptr(physicalDevice, drmFd, display);
        }
        public static delegate* unmanaged<VkPhysicalDevice, int, uint, VkDisplayKHR*, VkResult> _vkGetDrmDisplayEXT_fnptr = &vkGetDrmDisplayEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDrmDisplayEXT_Lazy(VkPhysicalDevice physicalDevice, int drmFd, uint connectorId, VkDisplayKHR* display)
        {
            _vkGetDrmDisplayEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, int, uint, VkDisplayKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDrmDisplayEXT");
            return _vkGetDrmDisplayEXT_fnptr(physicalDevice, drmFd, connectorId, display);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, ulong, ulong, VkResult> _vkWaitForPresentKHR_fnptr = &vkWaitForPresentKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkWaitForPresentKHR_Lazy(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout)
        {
            _vkWaitForPresentKHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, ulong, ulong, VkResult>)VKLoader.GetInstanceProcAddress("vkWaitForPresentKHR");
            return _vkWaitForPresentKHR_fnptr(device, swapchain, presentId, timeout);
        }
        public static delegate* unmanaged<VkDevice, VkBufferCollectionCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkBufferCollectionFUCHSIA*, VkResult> _vkCreateBufferCollectionFUCHSIA_fnptr = &vkCreateBufferCollectionFUCHSIA_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateBufferCollectionFUCHSIA_Lazy(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            _vkCreateBufferCollectionFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkBufferCollectionCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkBufferCollectionFUCHSIA*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateBufferCollectionFUCHSIA");
            return _vkCreateBufferCollectionFUCHSIA_fnptr(device, pCreateInfo, pAllocator, pCollection);
        }
        public static delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkBufferConstraintsInfoFUCHSIA*, VkResult> _vkSetBufferCollectionBufferConstraintsFUCHSIA_fnptr = &vkSetBufferCollectionBufferConstraintsFUCHSIA_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkSetBufferCollectionBufferConstraintsFUCHSIA_Lazy(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferConstraintsInfoFUCHSIA* pBufferConstraintsInfo)
        {
            _vkSetBufferCollectionBufferConstraintsFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkBufferConstraintsInfoFUCHSIA*, VkResult>)VKLoader.GetInstanceProcAddress("vkSetBufferCollectionBufferConstraintsFUCHSIA");
            return _vkSetBufferCollectionBufferConstraintsFUCHSIA_fnptr(device, collection, pBufferConstraintsInfo);
        }
        public static delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkImageConstraintsInfoFUCHSIA*, VkResult> _vkSetBufferCollectionImageConstraintsFUCHSIA_fnptr = &vkSetBufferCollectionImageConstraintsFUCHSIA_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkSetBufferCollectionImageConstraintsFUCHSIA_Lazy(VkDevice device, VkBufferCollectionFUCHSIA collection, VkImageConstraintsInfoFUCHSIA* pImageConstraintsInfo)
        {
            _vkSetBufferCollectionImageConstraintsFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkImageConstraintsInfoFUCHSIA*, VkResult>)VKLoader.GetInstanceProcAddress("vkSetBufferCollectionImageConstraintsFUCHSIA");
            return _vkSetBufferCollectionImageConstraintsFUCHSIA_fnptr(device, collection, pImageConstraintsInfo);
        }
        public static delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkAllocationCallbacks*, void> _vkDestroyBufferCollectionFUCHSIA_fnptr = &vkDestroyBufferCollectionFUCHSIA_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyBufferCollectionFUCHSIA_Lazy(VkDevice device, VkBufferCollectionFUCHSIA collection, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyBufferCollectionFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyBufferCollectionFUCHSIA");
            _vkDestroyBufferCollectionFUCHSIA_fnptr(device, collection, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkBufferCollectionPropertiesFUCHSIA*, VkResult> _vkGetBufferCollectionPropertiesFUCHSIA_fnptr = &vkGetBufferCollectionPropertiesFUCHSIA_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetBufferCollectionPropertiesFUCHSIA_Lazy(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferCollectionPropertiesFUCHSIA* pProperties)
        {
            _vkGetBufferCollectionPropertiesFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkBufferCollectionPropertiesFUCHSIA*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetBufferCollectionPropertiesFUCHSIA");
            return _vkGetBufferCollectionPropertiesFUCHSIA_fnptr(device, collection, pProperties);
        }
        public static delegate* unmanaged<VkDevice, VkCudaModuleCreateInfoNV*, VkAllocationCallbacks*, VkCudaModuleNV*, VkResult> _vkCreateCudaModuleNV_fnptr = &vkCreateCudaModuleNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateCudaModuleNV_Lazy(VkDevice device, VkCudaModuleCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCudaModuleNV* pModule)
        {
            _vkCreateCudaModuleNV_fnptr = (delegate* unmanaged<VkDevice, VkCudaModuleCreateInfoNV*, VkAllocationCallbacks*, VkCudaModuleNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateCudaModuleNV");
            return _vkCreateCudaModuleNV_fnptr(device, pCreateInfo, pAllocator, pModule);
        }
        public static delegate* unmanaged<VkDevice, VkCudaModuleNV, nuint*, void*, VkResult> _vkGetCudaModuleCacheNV_fnptr = &vkGetCudaModuleCacheNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetCudaModuleCacheNV_Lazy(VkDevice device, VkCudaModuleNV module, nuint* pCacheSize, void* pCacheData)
        {
            _vkGetCudaModuleCacheNV_fnptr = (delegate* unmanaged<VkDevice, VkCudaModuleNV, nuint*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetCudaModuleCacheNV");
            return _vkGetCudaModuleCacheNV_fnptr(device, module, pCacheSize, pCacheData);
        }
        public static delegate* unmanaged<VkDevice, VkCudaFunctionCreateInfoNV*, VkAllocationCallbacks*, VkCudaFunctionNV*, VkResult> _vkCreateCudaFunctionNV_fnptr = &vkCreateCudaFunctionNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateCudaFunctionNV_Lazy(VkDevice device, VkCudaFunctionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCudaFunctionNV* pFunction)
        {
            _vkCreateCudaFunctionNV_fnptr = (delegate* unmanaged<VkDevice, VkCudaFunctionCreateInfoNV*, VkAllocationCallbacks*, VkCudaFunctionNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateCudaFunctionNV");
            return _vkCreateCudaFunctionNV_fnptr(device, pCreateInfo, pAllocator, pFunction);
        }
        public static delegate* unmanaged<VkDevice, VkCudaModuleNV, VkAllocationCallbacks*, void> _vkDestroyCudaModuleNV_fnptr = &vkDestroyCudaModuleNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyCudaModuleNV_Lazy(VkDevice device, VkCudaModuleNV module, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyCudaModuleNV_fnptr = (delegate* unmanaged<VkDevice, VkCudaModuleNV, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyCudaModuleNV");
            _vkDestroyCudaModuleNV_fnptr(device, module, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkCudaFunctionNV, VkAllocationCallbacks*, void> _vkDestroyCudaFunctionNV_fnptr = &vkDestroyCudaFunctionNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyCudaFunctionNV_Lazy(VkDevice device, VkCudaFunctionNV function, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyCudaFunctionNV_fnptr = (delegate* unmanaged<VkDevice, VkCudaFunctionNV, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyCudaFunctionNV");
            _vkDestroyCudaFunctionNV_fnptr(device, function, pAllocator);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCudaLaunchInfoNV*, void> _vkCmdCudaLaunchKernelNV_fnptr = &vkCmdCudaLaunchKernelNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCudaLaunchKernelNV_Lazy(VkCommandBuffer commandBuffer, VkCudaLaunchInfoNV* pLaunchInfo)
        {
            _vkCmdCudaLaunchKernelNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCudaLaunchInfoNV*, void>)VKLoader.GetInstanceProcAddress("vkCmdCudaLaunchKernelNV");
            _vkCmdCudaLaunchKernelNV_fnptr(commandBuffer, pLaunchInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkRenderingInfo*, void> _vkCmdBeginRendering_fnptr = &vkCmdBeginRendering_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBeginRendering_Lazy(VkCommandBuffer commandBuffer, VkRenderingInfo* pRenderingInfo)
        {
            _vkCmdBeginRendering_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderingInfo*, void>)VKLoader.GetInstanceProcAddress("vkCmdBeginRendering");
            _vkCmdBeginRendering_fnptr(commandBuffer, pRenderingInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, void> _vkCmdEndRendering_fnptr = &vkCmdEndRendering_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdEndRendering_Lazy(VkCommandBuffer commandBuffer)
        {
            _vkCmdEndRendering_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetInstanceProcAddress("vkCmdEndRendering");
            _vkCmdEndRendering_fnptr(commandBuffer);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorSetBindingReferenceVALVE*, VkDescriptorSetLayoutHostMappingInfoVALVE*, void> _vkGetDescriptorSetLayoutHostMappingInfoVALVE_fnptr = &vkGetDescriptorSetLayoutHostMappingInfoVALVE_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDescriptorSetLayoutHostMappingInfoVALVE_Lazy(VkDevice device, VkDescriptorSetBindingReferenceVALVE* pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
        {
            _vkGetDescriptorSetLayoutHostMappingInfoVALVE_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetBindingReferenceVALVE*, VkDescriptorSetLayoutHostMappingInfoVALVE*, void>)VKLoader.GetInstanceProcAddress("vkGetDescriptorSetLayoutHostMappingInfoVALVE");
            _vkGetDescriptorSetLayoutHostMappingInfoVALVE_fnptr(device, pBindingReference, pHostMapping);
        }
        public static delegate* unmanaged<VkDevice, VkDescriptorSet, void**, void> _vkGetDescriptorSetHostMappingVALVE_fnptr = &vkGetDescriptorSetHostMappingVALVE_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDescriptorSetHostMappingVALVE_Lazy(VkDevice device, VkDescriptorSet descriptorSet, void** ppData)
        {
            _vkGetDescriptorSetHostMappingVALVE_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSet, void**, void>)VKLoader.GetInstanceProcAddress("vkGetDescriptorSetHostMappingVALVE");
            _vkGetDescriptorSetHostMappingVALVE_fnptr(device, descriptorSet, ppData);
        }
        public static delegate* unmanaged<VkDevice, VkMicromapCreateInfoEXT*, VkAllocationCallbacks*, VkMicromapEXT*, VkResult> _vkCreateMicromapEXT_fnptr = &vkCreateMicromapEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateMicromapEXT_Lazy(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap)
        {
            _vkCreateMicromapEXT_fnptr = (delegate* unmanaged<VkDevice, VkMicromapCreateInfoEXT*, VkAllocationCallbacks*, VkMicromapEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateMicromapEXT");
            return _vkCreateMicromapEXT_fnptr(device, pCreateInfo, pAllocator, pMicromap);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkMicromapBuildInfoEXT*, void> _vkCmdBuildMicromapsEXT_fnptr = &vkCmdBuildMicromapsEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBuildMicromapsEXT_Lazy(VkCommandBuffer commandBuffer, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            _vkCmdBuildMicromapsEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkMicromapBuildInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdBuildMicromapsEXT");
            _vkCmdBuildMicromapsEXT_fnptr(commandBuffer, infoCount, pInfos);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult> _vkBuildMicromapsEXT_fnptr = &vkBuildMicromapsEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkBuildMicromapsEXT_Lazy(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            _vkBuildMicromapsEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkBuildMicromapsEXT");
            return _vkBuildMicromapsEXT_fnptr(device, deferredOperation, infoCount, pInfos);
        }
        public static delegate* unmanaged<VkDevice, VkMicromapEXT, VkAllocationCallbacks*, void> _vkDestroyMicromapEXT_fnptr = &vkDestroyMicromapEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyMicromapEXT_Lazy(VkDevice device, VkMicromapEXT micromap, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyMicromapEXT_fnptr = (delegate* unmanaged<VkDevice, VkMicromapEXT, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyMicromapEXT");
            _vkDestroyMicromapEXT_fnptr(device, micromap, pAllocator);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCopyMicromapInfoEXT*, void> _vkCmdCopyMicromapEXT_fnptr = &vkCmdCopyMicromapEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyMicromapEXT_Lazy(VkCommandBuffer commandBuffer, VkCopyMicromapInfoEXT* pInfo)
        {
            _vkCmdCopyMicromapEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyMicromapInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyMicromapEXT");
            _vkCmdCopyMicromapEXT_fnptr(commandBuffer, pInfo);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMicromapInfoEXT*, VkResult> _vkCopyMicromapEXT_fnptr = &vkCopyMicromapEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCopyMicromapEXT_Lazy(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapInfoEXT* pInfo)
        {
            _vkCopyMicromapEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMicromapInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkCopyMicromapEXT");
            return _vkCopyMicromapEXT_fnptr(device, deferredOperation, pInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCopyMicromapToMemoryInfoEXT*, void> _vkCmdCopyMicromapToMemoryEXT_fnptr = &vkCmdCopyMicromapToMemoryEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyMicromapToMemoryEXT_Lazy(VkCommandBuffer commandBuffer, VkCopyMicromapToMemoryInfoEXT* pInfo)
        {
            _vkCmdCopyMicromapToMemoryEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyMicromapToMemoryInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyMicromapToMemoryEXT");
            _vkCmdCopyMicromapToMemoryEXT_fnptr(commandBuffer, pInfo);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMicromapToMemoryInfoEXT*, VkResult> _vkCopyMicromapToMemoryEXT_fnptr = &vkCopyMicromapToMemoryEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCopyMicromapToMemoryEXT_Lazy(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapToMemoryInfoEXT* pInfo)
        {
            _vkCopyMicromapToMemoryEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMicromapToMemoryInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkCopyMicromapToMemoryEXT");
            return _vkCopyMicromapToMemoryEXT_fnptr(device, deferredOperation, pInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToMicromapInfoEXT*, void> _vkCmdCopyMemoryToMicromapEXT_fnptr = &vkCmdCopyMemoryToMicromapEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdCopyMemoryToMicromapEXT_Lazy(VkCommandBuffer commandBuffer, VkCopyMemoryToMicromapInfoEXT* pInfo)
        {
            _vkCmdCopyMemoryToMicromapEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToMicromapInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdCopyMemoryToMicromapEXT");
            _vkCmdCopyMemoryToMicromapEXT_fnptr(commandBuffer, pInfo);
        }
        public static delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToMicromapInfoEXT*, VkResult> _vkCopyMemoryToMicromapEXT_fnptr = &vkCopyMemoryToMicromapEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCopyMemoryToMicromapEXT_Lazy(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToMicromapInfoEXT* pInfo)
        {
            _vkCopyMemoryToMicromapEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToMicromapInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkCopyMemoryToMicromapEXT");
            return _vkCopyMemoryToMicromapEXT_fnptr(device, deferredOperation, pInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkMicromapEXT*, VkQueryType, VkQueryPool, uint, void> _vkCmdWriteMicromapsPropertiesEXT_fnptr = &vkCmdWriteMicromapsPropertiesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdWriteMicromapsPropertiesEXT_Lazy(VkCommandBuffer commandBuffer, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            _vkCmdWriteMicromapsPropertiesEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkMicromapEXT*, VkQueryType, VkQueryPool, uint, void>)VKLoader.GetInstanceProcAddress("vkCmdWriteMicromapsPropertiesEXT");
            _vkCmdWriteMicromapsPropertiesEXT_fnptr(commandBuffer, micromapCount, pMicromaps, queryType, queryPool, firstQuery);
        }
        public static delegate* unmanaged<VkDevice, uint, VkMicromapEXT*, VkQueryType, nuint, void*, nuint, VkResult> _vkWriteMicromapsPropertiesEXT_fnptr = &vkWriteMicromapsPropertiesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkWriteMicromapsPropertiesEXT_Lazy(VkDevice device, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, nuint dataSize, void* pData, nuint stride)
        {
            _vkWriteMicromapsPropertiesEXT_fnptr = (delegate* unmanaged<VkDevice, uint, VkMicromapEXT*, VkQueryType, nuint, void*, nuint, VkResult>)VKLoader.GetInstanceProcAddress("vkWriteMicromapsPropertiesEXT");
            return _vkWriteMicromapsPropertiesEXT_fnptr(device, micromapCount, pMicromaps, queryType, dataSize, pData, stride);
        }
        public static delegate* unmanaged<VkDevice, VkMicromapVersionInfoEXT*, VkAccelerationStructureCompatibilityKHR*, void> _vkGetDeviceMicromapCompatibilityEXT_fnptr = &vkGetDeviceMicromapCompatibilityEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDeviceMicromapCompatibilityEXT_Lazy(VkDevice device, VkMicromapVersionInfoEXT* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            _vkGetDeviceMicromapCompatibilityEXT_fnptr = (delegate* unmanaged<VkDevice, VkMicromapVersionInfoEXT*, VkAccelerationStructureCompatibilityKHR*, void>)VKLoader.GetInstanceProcAddress("vkGetDeviceMicromapCompatibilityEXT");
            _vkGetDeviceMicromapCompatibilityEXT_fnptr(device, pVersionInfo, pCompatibility);
        }
        public static delegate* unmanaged<VkDevice, VkAccelerationStructureBuildTypeKHR, VkMicromapBuildInfoEXT*, VkMicromapBuildSizesInfoEXT*, void> _vkGetMicromapBuildSizesEXT_fnptr = &vkGetMicromapBuildSizesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetMicromapBuildSizesEXT_Lazy(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkMicromapBuildInfoEXT* pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
        {
            _vkGetMicromapBuildSizesEXT_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureBuildTypeKHR, VkMicromapBuildInfoEXT*, VkMicromapBuildSizesInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkGetMicromapBuildSizesEXT");
            _vkGetMicromapBuildSizesEXT_fnptr(device, buildType, pBuildInfo, pSizeInfo);
        }
        public static delegate* unmanaged<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void> _vkGetShaderModuleIdentifierEXT_fnptr = &vkGetShaderModuleIdentifierEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetShaderModuleIdentifierEXT_Lazy(VkDevice device, VkShaderModule shaderModule, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            _vkGetShaderModuleIdentifierEXT_fnptr = (delegate* unmanaged<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void>)VKLoader.GetInstanceProcAddress("vkGetShaderModuleIdentifierEXT");
            _vkGetShaderModuleIdentifierEXT_fnptr(device, shaderModule, pIdentifier);
        }
        public static delegate* unmanaged<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void> _vkGetShaderModuleCreateInfoIdentifierEXT_fnptr = &vkGetShaderModuleCreateInfoIdentifierEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetShaderModuleCreateInfoIdentifierEXT_Lazy(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            _vkGetShaderModuleCreateInfoIdentifierEXT_fnptr = (delegate* unmanaged<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void>)VKLoader.GetInstanceProcAddress("vkGetShaderModuleCreateInfoIdentifierEXT");
            _vkGetShaderModuleCreateInfoIdentifierEXT_fnptr(device, pCreateInfo, pIdentifier);
        }
        public static delegate* unmanaged<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void> _vkGetImageSubresourceLayout2KHR_fnptr = &vkGetImageSubresourceLayout2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetImageSubresourceLayout2KHR_Lazy(VkDevice device, VkImage image, VkImageSubresource2KHR* pSubresource, VkSubresourceLayout2KHR* pLayout)
        {
            _vkGetImageSubresourceLayout2KHR_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void>)VKLoader.GetInstanceProcAddress("vkGetImageSubresourceLayout2KHR");
            _vkGetImageSubresourceLayout2KHR_fnptr(device, image, pSubresource, pLayout);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineInfoEXT*, VkBaseOutStructure*, VkResult> _vkGetPipelinePropertiesEXT_fnptr = &vkGetPipelinePropertiesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPipelinePropertiesEXT_Lazy(VkDevice device, VkPipelineInfoEXT* pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
        {
            _vkGetPipelinePropertiesEXT_fnptr = (delegate* unmanaged<VkDevice, VkPipelineInfoEXT*, VkBaseOutStructure*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPipelinePropertiesEXT");
            return _vkGetPipelinePropertiesEXT_fnptr(device, pPipelineInfo, pPipelineProperties);
        }
        public static delegate* unmanaged<VkDevice, VkExportMetalObjectsInfoEXT*, void> _vkExportMetalObjectsEXT_fnptr = &vkExportMetalObjectsEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkExportMetalObjectsEXT_Lazy(VkDevice device, VkExportMetalObjectsInfoEXT* pMetalObjectsInfo)
        {
            _vkExportMetalObjectsEXT_fnptr = (delegate* unmanaged<VkDevice, VkExportMetalObjectsInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkExportMetalObjectsEXT");
            _vkExportMetalObjectsEXT_fnptr(device, pMetalObjectsInfo);
        }
        public static delegate* unmanaged<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult> _vkGetFramebufferTilePropertiesQCOM_fnptr = &vkGetFramebufferTilePropertiesQCOM_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetFramebufferTilePropertiesQCOM_Lazy(VkDevice device, VkFramebuffer framebuffer, uint* pPropertiesCount, VkTilePropertiesQCOM* pProperties)
        {
            _vkGetFramebufferTilePropertiesQCOM_fnptr = (delegate* unmanaged<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetFramebufferTilePropertiesQCOM");
            return _vkGetFramebufferTilePropertiesQCOM_fnptr(device, framebuffer, pPropertiesCount, pProperties);
        }
        public static delegate* unmanaged<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult> _vkGetDynamicRenderingTilePropertiesQCOM_fnptr = &vkGetDynamicRenderingTilePropertiesQCOM_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDynamicRenderingTilePropertiesQCOM_Lazy(VkDevice device, VkRenderingInfo* pRenderingInfo, VkTilePropertiesQCOM* pProperties)
        {
            _vkGetDynamicRenderingTilePropertiesQCOM_fnptr = (delegate* unmanaged<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDynamicRenderingTilePropertiesQCOM");
            return _vkGetDynamicRenderingTilePropertiesQCOM_fnptr(device, pRenderingInfo, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, VkOpticalFlowImageFormatInfoNV*, uint*, VkOpticalFlowImageFormatPropertiesNV*, VkResult> _vkGetPhysicalDeviceOpticalFlowImageFormatsNV_fnptr = &vkGetPhysicalDeviceOpticalFlowImageFormatsNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV_Lazy(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            _vkGetPhysicalDeviceOpticalFlowImageFormatsNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkOpticalFlowImageFormatInfoNV*, uint*, VkOpticalFlowImageFormatPropertiesNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceOpticalFlowImageFormatsNV");
            return _vkGetPhysicalDeviceOpticalFlowImageFormatsNV_fnptr(physicalDevice, pOpticalFlowImageFormatInfo, pFormatCount, pImageFormatProperties);
        }
        public static delegate* unmanaged<VkDevice, VkOpticalFlowSessionCreateInfoNV*, VkAllocationCallbacks*, VkOpticalFlowSessionNV*, VkResult> _vkCreateOpticalFlowSessionNV_fnptr = &vkCreateOpticalFlowSessionNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateOpticalFlowSessionNV_Lazy(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            _vkCreateOpticalFlowSessionNV_fnptr = (delegate* unmanaged<VkDevice, VkOpticalFlowSessionCreateInfoNV*, VkAllocationCallbacks*, VkOpticalFlowSessionNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateOpticalFlowSessionNV");
            return _vkCreateOpticalFlowSessionNV_fnptr(device, pCreateInfo, pAllocator, pSession);
        }
        public static delegate* unmanaged<VkDevice, VkOpticalFlowSessionNV, VkAllocationCallbacks*, void> _vkDestroyOpticalFlowSessionNV_fnptr = &vkDestroyOpticalFlowSessionNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyOpticalFlowSessionNV_Lazy(VkDevice device, VkOpticalFlowSessionNV session, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyOpticalFlowSessionNV_fnptr = (delegate* unmanaged<VkDevice, VkOpticalFlowSessionNV, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyOpticalFlowSessionNV");
            _vkDestroyOpticalFlowSessionNV_fnptr(device, session, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkOpticalFlowSessionNV, VkOpticalFlowSessionBindingPointNV, VkImageView, VkImageLayout, VkResult> _vkBindOpticalFlowSessionImageNV_fnptr = &vkBindOpticalFlowSessionImageNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkBindOpticalFlowSessionImageNV_Lazy(VkDevice device, VkOpticalFlowSessionNV session, VkOpticalFlowSessionBindingPointNV bindingPoint, VkImageView view, VkImageLayout layout)
        {
            _vkBindOpticalFlowSessionImageNV_fnptr = (delegate* unmanaged<VkDevice, VkOpticalFlowSessionNV, VkOpticalFlowSessionBindingPointNV, VkImageView, VkImageLayout, VkResult>)VKLoader.GetInstanceProcAddress("vkBindOpticalFlowSessionImageNV");
            return _vkBindOpticalFlowSessionImageNV_fnptr(device, session, bindingPoint, view, layout);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkOpticalFlowSessionNV, VkOpticalFlowExecuteInfoNV*, void> _vkCmdOpticalFlowExecuteNV_fnptr = &vkCmdOpticalFlowExecuteNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdOpticalFlowExecuteNV_Lazy(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, VkOpticalFlowExecuteInfoNV* pExecuteInfo)
        {
            _vkCmdOpticalFlowExecuteNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkOpticalFlowSessionNV, VkOpticalFlowExecuteInfoNV*, void>)VKLoader.GetInstanceProcAddress("vkCmdOpticalFlowExecuteNV");
            _vkCmdOpticalFlowExecuteNV_fnptr(commandBuffer, session, pExecuteInfo);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult> _vkGetDeviceFaultInfoEXT_fnptr = &vkGetDeviceFaultInfoEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetDeviceFaultInfoEXT_Lazy(VkDevice device, VkDeviceFaultCountsEXT* pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
        {
            _vkGetDeviceFaultInfoEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetDeviceFaultInfoEXT");
            return _vkGetDeviceFaultInfoEXT_fnptr(device, pFaultCounts, pFaultInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkDepthBiasInfoEXT*, void> _vkCmdSetDepthBias2EXT_fnptr = &vkCmdSetDepthBias2EXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDepthBias2EXT_Lazy(VkCommandBuffer commandBuffer, VkDepthBiasInfoEXT* pDepthBiasInfo)
        {
            _vkCmdSetDepthBias2EXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDepthBiasInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDepthBias2EXT");
            _vkCmdSetDepthBias2EXT_fnptr(commandBuffer, pDepthBiasInfo);
        }
        public static delegate* unmanaged<VkDevice, VkReleaseSwapchainImagesInfoEXT*, VkResult> _vkReleaseSwapchainImagesEXT_fnptr = &vkReleaseSwapchainImagesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkReleaseSwapchainImagesEXT_Lazy(VkDevice device, VkReleaseSwapchainImagesInfoEXT* pReleaseInfo)
        {
            _vkReleaseSwapchainImagesEXT_fnptr = (delegate* unmanaged<VkDevice, VkReleaseSwapchainImagesInfoEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkReleaseSwapchainImagesEXT");
            return _vkReleaseSwapchainImagesEXT_fnptr(device, pReleaseInfo);
        }
        public static delegate* unmanaged<VkDevice, VkDeviceImageSubresourceInfoKHR*, VkSubresourceLayout2KHR*, void> _vkGetDeviceImageSubresourceLayoutKHR_fnptr = &vkGetDeviceImageSubresourceLayoutKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetDeviceImageSubresourceLayoutKHR_Lazy(VkDevice device, VkDeviceImageSubresourceInfoKHR* pInfo, VkSubresourceLayout2KHR* pLayout)
        {
            _vkGetDeviceImageSubresourceLayoutKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeviceImageSubresourceInfoKHR*, VkSubresourceLayout2KHR*, void>)VKLoader.GetInstanceProcAddress("vkGetDeviceImageSubresourceLayoutKHR");
            _vkGetDeviceImageSubresourceLayoutKHR_fnptr(device, pInfo, pLayout);
        }
        public static delegate* unmanaged<VkDevice, VkMemoryMapInfoKHR*, void**, VkResult> _vkMapMemory2KHR_fnptr = &vkMapMemory2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkMapMemory2KHR_Lazy(VkDevice device, VkMemoryMapInfoKHR* pMemoryMapInfo, void** ppData)
        {
            _vkMapMemory2KHR_fnptr = (delegate* unmanaged<VkDevice, VkMemoryMapInfoKHR*, void**, VkResult>)VKLoader.GetInstanceProcAddress("vkMapMemory2KHR");
            return _vkMapMemory2KHR_fnptr(device, pMemoryMapInfo, ppData);
        }
        public static delegate* unmanaged<VkDevice, VkMemoryUnmapInfoKHR*, VkResult> _vkUnmapMemory2KHR_fnptr = &vkUnmapMemory2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkUnmapMemory2KHR_Lazy(VkDevice device, VkMemoryUnmapInfoKHR* pMemoryUnmapInfo)
        {
            _vkUnmapMemory2KHR_fnptr = (delegate* unmanaged<VkDevice, VkMemoryUnmapInfoKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkUnmapMemory2KHR");
            return _vkUnmapMemory2KHR_fnptr(device, pMemoryUnmapInfo);
        }
        public static delegate* unmanaged<VkDevice, uint, VkShaderCreateInfoEXT*, VkAllocationCallbacks*, VkShaderEXT*, VkResult> _vkCreateShadersEXT_fnptr = &vkCreateShadersEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateShadersEXT_Lazy(VkDevice device, uint createInfoCount, VkShaderCreateInfoEXT* pCreateInfos, VkAllocationCallbacks* pAllocator, VkShaderEXT* pShaders)
        {
            _vkCreateShadersEXT_fnptr = (delegate* unmanaged<VkDevice, uint, VkShaderCreateInfoEXT*, VkAllocationCallbacks*, VkShaderEXT*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateShadersEXT");
            return _vkCreateShadersEXT_fnptr(device, createInfoCount, pCreateInfos, pAllocator, pShaders);
        }
        public static delegate* unmanaged<VkDevice, VkShaderEXT, VkAllocationCallbacks*, void> _vkDestroyShaderEXT_fnptr = &vkDestroyShaderEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkDestroyShaderEXT_Lazy(VkDevice device, VkShaderEXT shader, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyShaderEXT_fnptr = (delegate* unmanaged<VkDevice, VkShaderEXT, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress("vkDestroyShaderEXT");
            _vkDestroyShaderEXT_fnptr(device, shader, pAllocator);
        }
        public static delegate* unmanaged<VkDevice, VkShaderEXT, nuint*, void*, VkResult> _vkGetShaderBinaryDataEXT_fnptr = &vkGetShaderBinaryDataEXT_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetShaderBinaryDataEXT_Lazy(VkDevice device, VkShaderEXT shader, nuint* pDataSize, void* pData)
        {
            _vkGetShaderBinaryDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkShaderEXT, nuint*, void*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetShaderBinaryDataEXT");
            return _vkGetShaderBinaryDataEXT_fnptr(device, shader, pDataSize, pData);
        }
        public static delegate* unmanaged<VkCommandBuffer, uint, VkShaderStageFlagBits*, VkShaderEXT*, void> _vkCmdBindShadersEXT_fnptr = &vkCmdBindShadersEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindShadersEXT_Lazy(VkCommandBuffer commandBuffer, uint stageCount, VkShaderStageFlagBits* pStages, VkShaderEXT* pShaders)
        {
            _vkCmdBindShadersEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkShaderStageFlagBits*, VkShaderEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdBindShadersEXT");
            _vkCmdBindShadersEXT_fnptr(commandBuffer, stageCount, pStages, pShaders);
        }
        public static delegate* unmanaged<VkDevice, IntPtr*, VkScreenBufferPropertiesQNX*, VkResult> _vkGetScreenBufferPropertiesQNX_fnptr = &vkGetScreenBufferPropertiesQNX_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetScreenBufferPropertiesQNX_Lazy(VkDevice device, IntPtr* buffer, VkScreenBufferPropertiesQNX* pProperties)
        {
            _vkGetScreenBufferPropertiesQNX_fnptr = (delegate* unmanaged<VkDevice, IntPtr*, VkScreenBufferPropertiesQNX*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetScreenBufferPropertiesQNX");
            return _vkGetScreenBufferPropertiesQNX_fnptr(device, buffer, pProperties);
        }
        public static delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesKHR*, VkResult> _vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_fnptr = &vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_Lazy(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesKHR* pProperties)
        {
            _vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR");
            return _vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        public static delegate* unmanaged<VkDevice, VkPipeline, VkExecutionGraphPipelineScratchSizeAMDX*, VkResult> _vkGetExecutionGraphPipelineScratchSizeAMDX_fnptr = &vkGetExecutionGraphPipelineScratchSizeAMDX_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetExecutionGraphPipelineScratchSizeAMDX_Lazy(VkDevice device, VkPipeline executionGraph, VkExecutionGraphPipelineScratchSizeAMDX* pSizeInfo)
        {
            _vkGetExecutionGraphPipelineScratchSizeAMDX_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, VkExecutionGraphPipelineScratchSizeAMDX*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetExecutionGraphPipelineScratchSizeAMDX");
            return _vkGetExecutionGraphPipelineScratchSizeAMDX_fnptr(device, executionGraph, pSizeInfo);
        }
        public static delegate* unmanaged<VkDevice, VkPipeline, VkPipelineShaderStageNodeCreateInfoAMDX*, uint*, VkResult> _vkGetExecutionGraphPipelineNodeIndexAMDX_fnptr = &vkGetExecutionGraphPipelineNodeIndexAMDX_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkGetExecutionGraphPipelineNodeIndexAMDX_Lazy(VkDevice device, VkPipeline executionGraph, VkPipelineShaderStageNodeCreateInfoAMDX* pNodeInfo, uint* pNodeIndex)
        {
            _vkGetExecutionGraphPipelineNodeIndexAMDX_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, VkPipelineShaderStageNodeCreateInfoAMDX*, uint*, VkResult>)VKLoader.GetInstanceProcAddress("vkGetExecutionGraphPipelineNodeIndexAMDX");
            return _vkGetExecutionGraphPipelineNodeIndexAMDX_fnptr(device, executionGraph, pNodeInfo, pNodeIndex);
        }
        public static delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkExecutionGraphPipelineCreateInfoAMDX*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateExecutionGraphPipelinesAMDX_fnptr = &vkCreateExecutionGraphPipelinesAMDX_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkCreateExecutionGraphPipelinesAMDX_Lazy(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            _vkCreateExecutionGraphPipelinesAMDX_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkExecutionGraphPipelineCreateInfoAMDX*, VkAllocationCallbacks*, VkPipeline*, VkResult>)VKLoader.GetInstanceProcAddress("vkCreateExecutionGraphPipelinesAMDX");
            return _vkCreateExecutionGraphPipelinesAMDX_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        public static delegate* unmanaged<VkCommandBuffer, ulong, void> _vkCmdInitializeGraphScratchMemoryAMDX_fnptr = &vkCmdInitializeGraphScratchMemoryAMDX_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdInitializeGraphScratchMemoryAMDX_Lazy(VkCommandBuffer commandBuffer, ulong scratch)
        {
            _vkCmdInitializeGraphScratchMemoryAMDX_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, void>)VKLoader.GetInstanceProcAddress("vkCmdInitializeGraphScratchMemoryAMDX");
            _vkCmdInitializeGraphScratchMemoryAMDX_fnptr(commandBuffer, scratch);
        }
        public static delegate* unmanaged<VkCommandBuffer, ulong, VkDispatchGraphCountInfoAMDX*, void> _vkCmdDispatchGraphAMDX_fnptr = &vkCmdDispatchGraphAMDX_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDispatchGraphAMDX_Lazy(VkCommandBuffer commandBuffer, ulong scratch, VkDispatchGraphCountInfoAMDX* pCountInfo)
        {
            _vkCmdDispatchGraphAMDX_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, VkDispatchGraphCountInfoAMDX*, void>)VKLoader.GetInstanceProcAddress("vkCmdDispatchGraphAMDX");
            _vkCmdDispatchGraphAMDX_fnptr(commandBuffer, scratch, pCountInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, ulong, VkDispatchGraphCountInfoAMDX*, void> _vkCmdDispatchGraphIndirectAMDX_fnptr = &vkCmdDispatchGraphIndirectAMDX_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDispatchGraphIndirectAMDX_Lazy(VkCommandBuffer commandBuffer, ulong scratch, VkDispatchGraphCountInfoAMDX* pCountInfo)
        {
            _vkCmdDispatchGraphIndirectAMDX_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, VkDispatchGraphCountInfoAMDX*, void>)VKLoader.GetInstanceProcAddress("vkCmdDispatchGraphIndirectAMDX");
            _vkCmdDispatchGraphIndirectAMDX_fnptr(commandBuffer, scratch, pCountInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, ulong, ulong, void> _vkCmdDispatchGraphIndirectCountAMDX_fnptr = &vkCmdDispatchGraphIndirectCountAMDX_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdDispatchGraphIndirectCountAMDX_Lazy(VkCommandBuffer commandBuffer, ulong scratch, ulong countInfo)
        {
            _vkCmdDispatchGraphIndirectCountAMDX_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, ulong, void>)VKLoader.GetInstanceProcAddress("vkCmdDispatchGraphIndirectCountAMDX");
            _vkCmdDispatchGraphIndirectCountAMDX_fnptr(commandBuffer, scratch, countInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBindDescriptorSetsInfoKHR*, void> _vkCmdBindDescriptorSets2KHR_fnptr = &vkCmdBindDescriptorSets2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindDescriptorSets2KHR_Lazy(VkCommandBuffer commandBuffer, VkBindDescriptorSetsInfoKHR* pBindDescriptorSetsInfo)
        {
            _vkCmdBindDescriptorSets2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBindDescriptorSetsInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdBindDescriptorSets2KHR");
            _vkCmdBindDescriptorSets2KHR_fnptr(commandBuffer, pBindDescriptorSetsInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPushConstantsInfoKHR*, void> _vkCmdPushConstants2KHR_fnptr = &vkCmdPushConstants2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdPushConstants2KHR_Lazy(VkCommandBuffer commandBuffer, VkPushConstantsInfoKHR* pPushConstantsInfo)
        {
            _vkCmdPushConstants2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPushConstantsInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdPushConstants2KHR");
            _vkCmdPushConstants2KHR_fnptr(commandBuffer, pPushConstantsInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetInfoKHR*, void> _vkCmdPushDescriptorSet2KHR_fnptr = &vkCmdPushDescriptorSet2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdPushDescriptorSet2KHR_Lazy(VkCommandBuffer commandBuffer, VkPushDescriptorSetInfoKHR* pPushDescriptorSetInfo)
        {
            _vkCmdPushDescriptorSet2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdPushDescriptorSet2KHR");
            _vkCmdPushDescriptorSet2KHR_fnptr(commandBuffer, pPushDescriptorSetInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfoKHR*, void> _vkCmdPushDescriptorSetWithTemplate2KHR_fnptr = &vkCmdPushDescriptorSetWithTemplate2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdPushDescriptorSetWithTemplate2KHR_Lazy(VkCommandBuffer commandBuffer, VkPushDescriptorSetWithTemplateInfoKHR* pPushDescriptorSetWithTemplateInfo)
        {
            _vkCmdPushDescriptorSetWithTemplate2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdPushDescriptorSetWithTemplate2KHR");
            _vkCmdPushDescriptorSetWithTemplate2KHR_fnptr(commandBuffer, pPushDescriptorSetWithTemplateInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkSetDescriptorBufferOffsetsInfoEXT*, void> _vkCmdSetDescriptorBufferOffsets2EXT_fnptr = &vkCmdSetDescriptorBufferOffsets2EXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetDescriptorBufferOffsets2EXT_Lazy(VkCommandBuffer commandBuffer, VkSetDescriptorBufferOffsetsInfoEXT* pSetDescriptorBufferOffsetsInfo)
        {
            _vkCmdSetDescriptorBufferOffsets2EXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSetDescriptorBufferOffsetsInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetDescriptorBufferOffsets2EXT");
            _vkCmdSetDescriptorBufferOffsets2EXT_fnptr(commandBuffer, pSetDescriptorBufferOffsetsInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT*, void> _vkCmdBindDescriptorBufferEmbeddedSamplers2EXT_fnptr = &vkCmdBindDescriptorBufferEmbeddedSamplers2EXT_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdBindDescriptorBufferEmbeddedSamplers2EXT_Lazy(VkCommandBuffer commandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT* pBindDescriptorBufferEmbeddedSamplersInfo)
        {
            _vkCmdBindDescriptorBufferEmbeddedSamplers2EXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT*, void>)VKLoader.GetInstanceProcAddress("vkCmdBindDescriptorBufferEmbeddedSamplers2EXT");
            _vkCmdBindDescriptorBufferEmbeddedSamplers2EXT_fnptr(commandBuffer, pBindDescriptorBufferEmbeddedSamplersInfo);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkLatencySleepModeInfoNV*, VkResult> _vkSetLatencySleepModeNV_fnptr = &vkSetLatencySleepModeNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkSetLatencySleepModeNV_Lazy(VkDevice device, VkSwapchainKHR swapchain, VkLatencySleepModeInfoNV* pSleepModeInfo)
        {
            _vkSetLatencySleepModeNV_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkLatencySleepModeInfoNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkSetLatencySleepModeNV");
            return _vkSetLatencySleepModeNV_fnptr(device, swapchain, pSleepModeInfo);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkLatencySleepInfoNV*, VkResult> _vkLatencySleepNV_fnptr = &vkLatencySleepNV_Lazy;
        [UnmanagedCallersOnly]
        private static VkResult vkLatencySleepNV_Lazy(VkDevice device, VkSwapchainKHR swapchain, VkLatencySleepInfoNV* pSleepInfo)
        {
            _vkLatencySleepNV_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkLatencySleepInfoNV*, VkResult>)VKLoader.GetInstanceProcAddress("vkLatencySleepNV");
            return _vkLatencySleepNV_fnptr(device, swapchain, pSleepInfo);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSetLatencyMarkerInfoNV*, void> _vkSetLatencyMarkerNV_fnptr = &vkSetLatencyMarkerNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkSetLatencyMarkerNV_Lazy(VkDevice device, VkSwapchainKHR swapchain, VkSetLatencyMarkerInfoNV* pLatencyMarkerInfo)
        {
            _vkSetLatencyMarkerNV_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSetLatencyMarkerInfoNV*, void>)VKLoader.GetInstanceProcAddress("vkSetLatencyMarkerNV");
            _vkSetLatencyMarkerNV_fnptr(device, swapchain, pLatencyMarkerInfo);
        }
        public static delegate* unmanaged<VkDevice, VkSwapchainKHR, VkGetLatencyMarkerInfoNV*, void> _vkGetLatencyTimingsNV_fnptr = &vkGetLatencyTimingsNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkGetLatencyTimingsNV_Lazy(VkDevice device, VkSwapchainKHR swapchain, VkGetLatencyMarkerInfoNV* pLatencyMarkerInfo)
        {
            _vkGetLatencyTimingsNV_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkGetLatencyMarkerInfoNV*, void>)VKLoader.GetInstanceProcAddress("vkGetLatencyTimingsNV");
            _vkGetLatencyTimingsNV_fnptr(device, swapchain, pLatencyMarkerInfo);
        }
        public static delegate* unmanaged<VkQueue, VkOutOfBandQueueTypeInfoNV*, void> _vkQueueNotifyOutOfBandNV_fnptr = &vkQueueNotifyOutOfBandNV_Lazy;
        [UnmanagedCallersOnly]
        private static void vkQueueNotifyOutOfBandNV_Lazy(VkQueue queue, VkOutOfBandQueueTypeInfoNV* pQueueTypeInfo)
        {
            _vkQueueNotifyOutOfBandNV_fnptr = (delegate* unmanaged<VkQueue, VkOutOfBandQueueTypeInfoNV*, void>)VKLoader.GetInstanceProcAddress("vkQueueNotifyOutOfBandNV");
            _vkQueueNotifyOutOfBandNV_fnptr(queue, pQueueTypeInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkRenderingAttachmentLocationInfoKHR*, void> _vkCmdSetRenderingAttachmentLocationsKHR_fnptr = &vkCmdSetRenderingAttachmentLocationsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetRenderingAttachmentLocationsKHR_Lazy(VkCommandBuffer commandBuffer, VkRenderingAttachmentLocationInfoKHR* pLocationInfo)
        {
            _vkCmdSetRenderingAttachmentLocationsKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderingAttachmentLocationInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetRenderingAttachmentLocationsKHR");
            _vkCmdSetRenderingAttachmentLocationsKHR_fnptr(commandBuffer, pLocationInfo);
        }
        public static delegate* unmanaged<VkCommandBuffer, VkRenderingInputAttachmentIndexInfoKHR*, void> _vkCmdSetRenderingInputAttachmentIndicesKHR_fnptr = &vkCmdSetRenderingInputAttachmentIndicesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static void vkCmdSetRenderingInputAttachmentIndicesKHR_Lazy(VkCommandBuffer commandBuffer, VkRenderingInputAttachmentIndexInfoKHR* pInputAttachmentIndexInfo)
        {
            _vkCmdSetRenderingInputAttachmentIndicesKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderingInputAttachmentIndexInfoKHR*, void>)VKLoader.GetInstanceProcAddress("vkCmdSetRenderingInputAttachmentIndicesKHR");
            _vkCmdSetRenderingInputAttachmentIndicesKHR_fnptr(commandBuffer, pInputAttachmentIndexInfo);
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
