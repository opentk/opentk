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
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public unsafe partial struct InstanceDispatchTable
    {
        ///<summary>The <see cref="VkInstance"/> used to load this dispatch table.</summary>
        public readonly VkInstance Instance;
        public InstanceDispatchTable(VkInstance instance)
        {
            Instance = instance;
            _vkAcquireDrmDisplayEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, int, VkDisplayKHR, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkAcquireDrmDisplayEXT");
            _vkAcquireWinrtDisplayNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkAcquireWinrtDisplayNV");
            _vkAcquireXlibDisplayEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, IntPtr, VkDisplayKHR, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkAcquireXlibDisplayEXT");
            _vkCreateAndroidSurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkAndroidSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateAndroidSurfaceKHR");
            _vkCreateDebugReportCallbackEXT_fnptr = (delegate* unmanaged<VkInstance, VkDebugReportCallbackCreateInfoEXT*, VkAllocationCallbacks*, VkDebugReportCallbackEXT*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateDebugReportCallbackEXT");
            _vkCreateDebugUtilsMessengerEXT_fnptr = (delegate* unmanaged<VkInstance, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, VkDebugUtilsMessengerEXT*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateDebugUtilsMessengerEXT");
            _vkCreateDevice_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDeviceCreateInfo*, VkAllocationCallbacks*, VkDevice*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateDevice");
            _vkCreateDirectFBSurfaceEXT_fnptr = (delegate* unmanaged<VkInstance, VkDirectFBSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateDirectFBSurfaceEXT");
            _vkCreateDisplayModeKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkDisplayModeCreateInfoKHR*, VkAllocationCallbacks*, VkDisplayModeKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateDisplayModeKHR");
            _vkCreateDisplayPlaneSurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkDisplaySurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateDisplayPlaneSurfaceKHR");
            _vkCreateHeadlessSurfaceEXT_fnptr = (delegate* unmanaged<VkInstance, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateHeadlessSurfaceEXT");
            _vkCreateImagePipeSurfaceFUCHSIA_fnptr = (delegate* unmanaged<VkInstance, VkImagePipeSurfaceCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateImagePipeSurfaceFUCHSIA");
            _vkCreateIOSSurfaceMVK_fnptr = (delegate* unmanaged<VkInstance, VkIOSSurfaceCreateInfoMVK*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateIOSSurfaceMVK");
            _vkCreateMacOSSurfaceMVK_fnptr = (delegate* unmanaged<VkInstance, VkMacOSSurfaceCreateInfoMVK*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateMacOSSurfaceMVK");
            _vkCreateMetalSurfaceEXT_fnptr = (delegate* unmanaged<VkInstance, VkMetalSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateMetalSurfaceEXT");
            _vkCreateScreenSurfaceQNX_fnptr = (delegate* unmanaged<VkInstance, VkScreenSurfaceCreateInfoQNX*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateScreenSurfaceQNX");
            _vkCreateStreamDescriptorSurfaceGGP_fnptr = (delegate* unmanaged<VkInstance, VkStreamDescriptorSurfaceCreateInfoGGP*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateStreamDescriptorSurfaceGGP");
            _vkCreateSurfaceOHOS_fnptr = (delegate* unmanaged<VkInstance, VkSurfaceCreateInfoOHOS*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateSurfaceOHOS");
            _vkCreateViSurfaceNN_fnptr = (delegate* unmanaged<VkInstance, VkViSurfaceCreateInfoNN*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateViSurfaceNN");
            _vkCreateWaylandSurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkWaylandSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateWaylandSurfaceKHR");
            _vkCreateWin32SurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkWin32SurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateWin32SurfaceKHR");
            _vkCreateXcbSurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkXcbSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateXcbSurfaceKHR");
            _vkCreateXlibSurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkXlibSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateXlibSurfaceKHR");
            _vkDebugReportMessageEXT_fnptr = (delegate* unmanaged<VkInstance, VkDebugReportFlagBitsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*, void>)VKLoader.GetInstanceProcAddress(instance, "vkDebugReportMessageEXT");
            _vkDestroyDebugReportCallbackEXT_fnptr = (delegate* unmanaged<VkInstance, VkDebugReportCallbackEXT, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress(instance, "vkDestroyDebugReportCallbackEXT");
            _vkDestroyDebugUtilsMessengerEXT_fnptr = (delegate* unmanaged<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress(instance, "vkDestroyDebugUtilsMessengerEXT");
            _vkDestroyInstance_fnptr = (delegate* unmanaged<VkInstance, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress(instance, "vkDestroyInstance");
            _vkDestroySurfaceKHR_fnptr = (delegate* unmanaged<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void>)VKLoader.GetInstanceProcAddress(instance, "vkDestroySurfaceKHR");
            _vkEnumerateDeviceExtensionProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, byte*, uint*, VkExtensionProperties*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkEnumerateDeviceExtensionProperties");
            _vkEnumerateDeviceLayerProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkLayerProperties*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkEnumerateDeviceLayerProperties");
            _vkEnumeratePhysicalDeviceGroups_fnptr = (delegate* unmanaged<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkEnumeratePhysicalDeviceGroups");
            _vkEnumeratePhysicalDeviceGroupsKHR_fnptr = (delegate* unmanaged<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkEnumeratePhysicalDeviceGroupsKHR");
            _vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkPerformanceCounterARM*, VkPerformanceCounterDescriptionARM*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM");
            _vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkPerformanceCounterKHR*, VkPerformanceCounterDescriptionKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR");
            _vkEnumeratePhysicalDevices_fnptr = (delegate* unmanaged<VkInstance, uint*, VkPhysicalDevice*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkEnumeratePhysicalDevices");
            _vkGetDisplayModeProperties2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModeProperties2KHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetDisplayModeProperties2KHR");
            _vkGetDisplayModePropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModePropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetDisplayModePropertiesKHR");
            _vkGetDisplayPlaneCapabilities2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayPlaneInfo2KHR*, VkDisplayPlaneCapabilities2KHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetDisplayPlaneCapabilities2KHR");
            _vkGetDisplayPlaneCapabilitiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayModeKHR, uint, VkDisplayPlaneCapabilitiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetDisplayPlaneCapabilitiesKHR");
            _vkGetDisplayPlaneSupportedDisplaysKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkDisplayKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetDisplayPlaneSupportedDisplaysKHR");
            _vkGetDrmDisplayEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, int, uint, VkDisplayKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetDrmDisplayEXT");
            _vkGetInstanceProcAddr_fnptr = (delegate* unmanaged<VkInstance, byte*, IntPtr>)VKLoader.GetInstanceProcAddress(instance, "vkGetInstanceProcAddr");
            _vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkTimeDomainKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT");
            _vkGetPhysicalDeviceCalibrateableTimeDomainsKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkTimeDomainKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceCalibrateableTimeDomainsKHR");
            _vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixFlexibleDimensionsPropertiesNV*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV");
            _vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR");
            _vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV");
            _vkGetPhysicalDeviceCooperativeVectorPropertiesNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeVectorPropertiesNV*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceCooperativeVectorPropertiesNV");
            _vkGetPhysicalDeviceDirectFBPresentationSupportEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, int>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceDirectFBPresentationSupportEXT");
            _vkGetPhysicalDeviceDisplayPlaneProperties2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPlaneProperties2KHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceDisplayPlaneProperties2KHR");
            _vkGetPhysicalDeviceDisplayPlanePropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPlanePropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceDisplayPlanePropertiesKHR");
            _vkGetPhysicalDeviceDisplayProperties2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayProperties2KHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceDisplayProperties2KHR");
            _vkGetPhysicalDeviceDisplayPropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceDisplayPropertiesKHR");
            _vkGetPhysicalDeviceExternalBufferProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceExternalBufferProperties");
            _vkGetPhysicalDeviceExternalBufferPropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceExternalBufferPropertiesKHR");
            _vkGetPhysicalDeviceExternalFenceProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceExternalFenceProperties");
            _vkGetPhysicalDeviceExternalFencePropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceExternalFencePropertiesKHR");
            _vkGetPhysicalDeviceExternalImageFormatPropertiesNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, VkExternalMemoryHandleTypeFlagBitsNV, VkExternalImageFormatPropertiesNV*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceExternalImageFormatPropertiesNV");
            _vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkExternalMemoryHandleTypeFlagBits, IntPtr, VkMemorySciBufPropertiesNV*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV");
            _vkGetPhysicalDeviceExternalSemaphoreProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceExternalSemaphoreProperties");
            _vkGetPhysicalDeviceExternalSemaphorePropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR");
            _vkGetPhysicalDeviceExternalTensorPropertiesARM_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalTensorInfoARM*, VkExternalTensorPropertiesARM*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceExternalTensorPropertiesARM");
            _vkGetPhysicalDeviceFeatures_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceFeatures*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceFeatures");
            _vkGetPhysicalDeviceFeatures2_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceFeatures2");
            _vkGetPhysicalDeviceFeatures2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceFeatures2KHR");
            _vkGetPhysicalDeviceFormatProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkFormat, VkFormatProperties*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceFormatProperties");
            _vkGetPhysicalDeviceFormatProperties2_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceFormatProperties2");
            _vkGetPhysicalDeviceFormatProperties2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceFormatProperties2KHR");
            _vkGetPhysicalDeviceFragmentShadingRatesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceFragmentShadingRatesKHR");
            _vkGetPhysicalDeviceImageFormatProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, VkImageFormatProperties*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceImageFormatProperties");
            _vkGetPhysicalDeviceImageFormatProperties2_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceImageFormatProperties2");
            _vkGetPhysicalDeviceImageFormatProperties2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceImageFormatProperties2KHR");
            _vkGetPhysicalDeviceMemoryProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceMemoryProperties");
            _vkGetPhysicalDeviceMemoryProperties2_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceMemoryProperties2");
            _vkGetPhysicalDeviceMemoryProperties2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceMemoryProperties2KHR");
            _vkGetPhysicalDeviceMultisamplePropertiesEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSampleCountFlagBits, VkMultisamplePropertiesEXT*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceMultisamplePropertiesEXT");
            _vkGetPhysicalDeviceOpticalFlowImageFormatsNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkOpticalFlowImageFormatInfoNV*, uint*, VkOpticalFlowImageFormatPropertiesNV*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceOpticalFlowImageFormatsNV");
            _vkGetPhysicalDevicePresentRectanglesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDevicePresentRectanglesKHR");
            _vkGetPhysicalDeviceProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceProperties");
            _vkGetPhysicalDeviceProperties2_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceProperties2");
            _vkGetPhysicalDeviceProperties2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceProperties2KHR");
            _vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM*, VkQueueFamilyDataGraphProcessingEnginePropertiesARM*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM");
            _vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkQueueFamilyDataGraphPropertiesARM*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM");
            _vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, uint*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR");
            _vkGetPhysicalDeviceQueueFamilyProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceQueueFamilyProperties");
            _vkGetPhysicalDeviceQueueFamilyProperties2_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceQueueFamilyProperties2");
            _vkGetPhysicalDeviceQueueFamilyProperties2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceQueueFamilyProperties2KHR");
            _vkGetPhysicalDeviceRefreshableObjectTypesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkObjectType*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceRefreshableObjectTypesKHR");
            _vkGetPhysicalDeviceSciBufAttributesNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, IntPtr, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSciBufAttributesNV");
            _vkGetPhysicalDeviceSciSyncAttributesNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSciSyncAttributesInfoNV*, IntPtr, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSciSyncAttributesNV");
            _vkGetPhysicalDeviceScreenPresentationSupportQNX_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, IntPtr*, int>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceScreenPresentationSupportQNX");
            _vkGetPhysicalDeviceSparseImageFormatProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlagBits, VkImageUsageFlagBits, VkImageTiling, uint*, VkSparseImageFormatProperties*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSparseImageFormatProperties");
            _vkGetPhysicalDeviceSparseImageFormatProperties2_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSparseImageFormatProperties2");
            _vkGetPhysicalDeviceSparseImageFormatProperties2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSparseImageFormatProperties2KHR");
            _vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV");
            _vkGetPhysicalDeviceSurfaceCapabilities2EXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSurfaceCapabilities2EXT");
            _vkGetPhysicalDeviceSurfaceCapabilities2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkSurfaceCapabilities2KHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSurfaceCapabilities2KHR");
            _vkGetPhysicalDeviceSurfaceCapabilitiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilitiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSurfaceCapabilitiesKHR");
            _vkGetPhysicalDeviceSurfaceFormats2KHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkSurfaceFormat2KHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSurfaceFormats2KHR");
            _vkGetPhysicalDeviceSurfaceFormatsKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkSurfaceFormatKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSurfaceFormatsKHR");
            _vkGetPhysicalDeviceSurfacePresentModes2EXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkPresentModeKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSurfacePresentModes2EXT");
            _vkGetPhysicalDeviceSurfacePresentModesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkPresentModeKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSurfacePresentModesKHR");
            _vkGetPhysicalDeviceSurfaceSupportKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, VkSurfaceKHR, int*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceSurfaceSupportKHR");
            _vkGetPhysicalDeviceToolProperties_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceToolProperties");
            _vkGetPhysicalDeviceToolPropertiesEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceToolPropertiesEXT");
            _vkGetPhysicalDeviceVideoCapabilitiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkVideoProfileInfoKHR*, VkVideoCapabilitiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceVideoCapabilitiesKHR");
            _vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR*, VkVideoEncodeQualityLevelPropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR");
            _vkGetPhysicalDeviceVideoFormatPropertiesKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceVideoFormatInfoKHR*, uint*, VkVideoFormatPropertiesKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceVideoFormatPropertiesKHR");
            _vkGetPhysicalDeviceWaylandPresentationSupportKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, int>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceWaylandPresentationSupportKHR");
            _vkGetPhysicalDeviceWin32PresentationSupportKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, int>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceWin32PresentationSupportKHR");
            _vkGetPhysicalDeviceXcbPresentationSupportKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, uint, int>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceXcbPresentationSupportKHR");
            _vkGetPhysicalDeviceXlibPresentationSupportKHR_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, nuint, int>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceXlibPresentationSupportKHR");
            _vkGetRandROutputDisplayEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, IntPtr, nuint, VkDisplayKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetRandROutputDisplayEXT");
            _vkGetWinrtDisplayNV_fnptr = (delegate* unmanaged<VkPhysicalDevice, uint, VkDisplayKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkGetWinrtDisplayNV");
            _vkReleaseDisplayEXT_fnptr = (delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkReleaseDisplayEXT");
            _vkSubmitDebugUtilsMessageEXT_fnptr = (delegate* unmanaged<VkInstance, VkDebugUtilsMessageSeverityFlagBitsEXT, VkDebugUtilsMessageTypeFlagBitsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void>)VKLoader.GetInstanceProcAddress(instance, "vkSubmitDebugUtilsMessageEXT");
        }
        /// <summary><b>[requires: VK_EXT_acquire_drm_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireDrmDisplayEXT.html" /></remarks>
        public VkResult AcquireDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, VkDisplayKHR display)
        {
            return _vkAcquireDrmDisplayEXT_fnptr(physicalDevice, drmFd, display);
        }
        /// <summary><b>[requires: VK_NV_acquire_winrt_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireWinrtDisplayNV.html" /></remarks>
        public VkResult AcquireWinrtDisplayNV(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
        {
            return _vkAcquireWinrtDisplayNV_fnptr(physicalDevice, display);
        }
        /// <summary><b>[requires: VK_EXT_acquire_xlib_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireXlibDisplayEXT.html" /></remarks>
        public VkResult AcquireXlibDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, VkDisplayKHR display)
        {
            return _vkAcquireXlibDisplayEXT_fnptr(physicalDevice, dpy, display);
        }
        /// <summary><b>[requires: VK_KHR_android_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateAndroidSurfaceKHR.html" /></remarks>
        public VkResult CreateAndroidSurfaceKHR(VkInstance instance, VkAndroidSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateAndroidSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_EXT_debug_report]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDebugReportCallbackEXT.html" /></remarks>
        public VkResult CreateDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugReportCallbackEXT* pCallback)
        {
            return _vkCreateDebugReportCallbackEXT_fnptr(instance, pCreateInfo, pAllocator, pCallback);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDebugUtilsMessengerEXT.html" /></remarks>
        public VkResult CreateDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDebugUtilsMessengerEXT* pMessenger)
        {
            return _vkCreateDebugUtilsMessengerEXT_fnptr(instance, pCreateInfo, pAllocator, pMessenger);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDevice.html" /></remarks>
        public VkResult CreateDevice(VkPhysicalDevice physicalDevice, VkDeviceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice)
        {
            return _vkCreateDevice_fnptr(physicalDevice, pCreateInfo, pAllocator, pDevice);
        }
        /// <summary><b>[requires: VK_EXT_directfb_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDirectFBSurfaceEXT.html" /></remarks>
        public VkResult CreateDirectFBSurfaceEXT(VkInstance instance, VkDirectFBSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateDirectFBSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDisplayModeKHR.html" /></remarks>
        public VkResult CreateDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, VkDisplayModeCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode)
        {
            return _vkCreateDisplayModeKHR_fnptr(physicalDevice, display, pCreateInfo, pAllocator, pMode);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDisplayPlaneSurfaceKHR.html" /></remarks>
        public VkResult CreateDisplayPlaneSurfaceKHR(VkInstance instance, VkDisplaySurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateDisplayPlaneSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_EXT_headless_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateHeadlessSurfaceEXT.html" /></remarks>
        public VkResult CreateHeadlessSurfaceEXT(VkInstance instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateHeadlessSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_FUCHSIA_imagepipe_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateImagePipeSurfaceFUCHSIA.html" /></remarks>
        public VkResult CreateImagePipeSurfaceFUCHSIA(VkInstance instance, VkImagePipeSurfaceCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateImagePipeSurfaceFUCHSIA_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_MVK_ios_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateIOSSurfaceMVK.html" /></remarks>
        public VkResult CreateIOSSurfaceMVK(VkInstance instance, VkIOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateIOSSurfaceMVK_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_MVK_macos_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateMacOSSurfaceMVK.html" /></remarks>
        public VkResult CreateMacOSSurfaceMVK(VkInstance instance, VkMacOSSurfaceCreateInfoMVK* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateMacOSSurfaceMVK_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_EXT_metal_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateMetalSurfaceEXT.html" /></remarks>
        public VkResult CreateMetalSurfaceEXT(VkInstance instance, VkMetalSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateMetalSurfaceEXT_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_QNX_screen_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateScreenSurfaceQNX.html" /></remarks>
        public VkResult CreateScreenSurfaceQNX(VkInstance instance, VkScreenSurfaceCreateInfoQNX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateScreenSurfaceQNX_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_GGP_stream_descriptor_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateStreamDescriptorSurfaceGGP.html" /></remarks>
        public VkResult CreateStreamDescriptorSurfaceGGP(VkInstance instance, VkStreamDescriptorSurfaceCreateInfoGGP* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateStreamDescriptorSurfaceGGP_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_OHOS_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSurfaceOHOS.html" /></remarks>
        public VkResult CreateSurfaceOHOS(VkInstance instance, VkSurfaceCreateInfoOHOS* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateSurfaceOHOS_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_NN_vi_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateViSurfaceNN.html" /></remarks>
        public VkResult CreateViSurfaceNN(VkInstance instance, VkViSurfaceCreateInfoNN* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateViSurfaceNN_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_KHR_wayland_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateWaylandSurfaceKHR.html" /></remarks>
        public VkResult CreateWaylandSurfaceKHR(VkInstance instance, VkWaylandSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateWaylandSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_KHR_win32_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateWin32SurfaceKHR.html" /></remarks>
        public VkResult CreateWin32SurfaceKHR(VkInstance instance, VkWin32SurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateWin32SurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_KHR_xcb_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateXcbSurfaceKHR.html" /></remarks>
        public VkResult CreateXcbSurfaceKHR(VkInstance instance, VkXcbSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateXcbSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_KHR_xlib_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateXlibSurfaceKHR.html" /></remarks>
        public VkResult CreateXlibSurfaceKHR(VkInstance instance, VkXlibSurfaceCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSurfaceKHR* pSurface)
        {
            return _vkCreateXlibSurfaceKHR_fnptr(instance, pCreateInfo, pAllocator, pSurface);
        }
        /// <summary><b>[requires: VK_EXT_debug_report]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDebugReportMessageEXT.html" /></remarks>
        public void DebugReportMessageEXT(VkInstance instance, VkDebugReportFlagBitsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong obj, nuint location, int messageCode, byte* pLayerPrefix, byte* pMessage)
        {
            _vkDebugReportMessageEXT_fnptr(instance, flags, objectType, obj, location, messageCode, pLayerPrefix, pMessage);
        }
        /// <summary><b>[requires: VK_EXT_debug_report]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDebugReportCallbackEXT.html" /></remarks>
        public void DestroyDebugReportCallbackEXT(VkInstance instance, VkDebugReportCallbackEXT callback, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDebugReportCallbackEXT_fnptr(instance, callback, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDebugUtilsMessengerEXT.html" /></remarks>
        public void DestroyDebugUtilsMessengerEXT(VkInstance instance, VkDebugUtilsMessengerEXT messenger, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDebugUtilsMessengerEXT_fnptr(instance, messenger, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyInstance.html" /></remarks>
        public void DestroyInstance(VkInstance instance, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyInstance_fnptr(instance, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySurfaceKHR.html" /></remarks>
        public void DestroySurfaceKHR(VkInstance instance, VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySurfaceKHR_fnptr(instance, surface, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumerateDeviceExtensionProperties.html" /></remarks>
        public VkResult EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
        {
            return _vkEnumerateDeviceExtensionProperties_fnptr(physicalDevice, pLayerName, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumerateDeviceLayerProperties.html" /></remarks>
        public VkResult EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkLayerProperties* pProperties)
        {
            return _vkEnumerateDeviceLayerProperties_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceGroups.html" /></remarks>
        public VkResult EnumeratePhysicalDeviceGroups(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
        {
            return _vkEnumeratePhysicalDeviceGroups_fnptr(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
        }
        /// <summary><b>[requires: VK_KHR_device_group_creation]</b> [instance command]  Alias of <see cref="EnumeratePhysicalDeviceGroups"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceGroupsKHR.html" /></remarks>
        public VkResult EnumeratePhysicalDeviceGroupsKHR(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
        {
            return _vkEnumeratePhysicalDeviceGroupsKHR_fnptr(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
        }
        /// <summary><b>[requires: VK_ARM_performance_counters_by_region]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM.html" /></remarks>
        public VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterARM* pCounters, VkPerformanceCounterDescriptionARM* pCounterDescriptions)
        {
            return _vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM_fnptr(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);
        }
        /// <summary><b>[requires: VK_KHR_performance_query]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR.html" /></remarks>
        public VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions)
        {
            return _vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_fnptr(physicalDevice, queueFamilyIndex, pCounterCount, pCounters, pCounterDescriptions);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDevices.html" /></remarks>
        public VkResult EnumeratePhysicalDevices(VkInstance instance, uint* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices)
        {
            return _vkEnumeratePhysicalDevices_fnptr(instance, pPhysicalDeviceCount, pPhysicalDevices);
        }
        /// <summary><b>[requires: VK_KHR_get_display_properties2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayModeProperties2KHR.html" /></remarks>
        public VkResult GetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
        {
            return _vkGetDisplayModeProperties2KHR_fnptr(physicalDevice, display, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayModePropertiesKHR.html" /></remarks>
        public VkResult GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
        {
            return _vkGetDisplayModePropertiesKHR_fnptr(physicalDevice, display, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_display_properties2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneCapabilities2KHR.html" /></remarks>
        public VkResult GetDisplayPlaneCapabilities2KHR(VkPhysicalDevice physicalDevice, VkDisplayPlaneInfo2KHR* pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities)
        {
            return _vkGetDisplayPlaneCapabilities2KHR_fnptr(physicalDevice, pDisplayPlaneInfo, pCapabilities);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneCapabilitiesKHR.html" /></remarks>
        public VkResult GetDisplayPlaneCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities)
        {
            return _vkGetDisplayPlaneCapabilitiesKHR_fnptr(physicalDevice, mode, planeIndex, pCapabilities);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneSupportedDisplaysKHR.html" /></remarks>
        public VkResult GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice, uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays)
        {
            return _vkGetDisplayPlaneSupportedDisplaysKHR_fnptr(physicalDevice, planeIndex, pDisplayCount, pDisplays);
        }
        /// <summary><b>[requires: VK_EXT_acquire_drm_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDrmDisplayEXT.html" /></remarks>
        public VkResult GetDrmDisplayEXT(VkPhysicalDevice physicalDevice, int drmFd, uint connectorId, VkDisplayKHR* display)
        {
            return _vkGetDrmDisplayEXT_fnptr(physicalDevice, drmFd, connectorId, display);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetInstanceProcAddr.html" /></remarks>
        public IntPtr GetInstanceProcAddr(VkInstance instance, byte* pName)
        {
            return _vkGetInstanceProcAddr_fnptr(instance, pName);
        }
        /// <summary><b>[requires: VK_EXT_calibrated_timestamps]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceCalibrateableTimeDomainsKHR"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCalibrateableTimeDomainsEXT.html" /></remarks>
        public VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXT(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainKHR* pTimeDomains)
        {
            return _vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_fnptr(physicalDevice, pTimeDomainCount, pTimeDomains);
        }
        /// <summary><b>[requires: VK_KHR_calibrated_timestamps]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCalibrateableTimeDomainsKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceCalibrateableTimeDomainsKHR(VkPhysicalDevice physicalDevice, uint* pTimeDomainCount, VkTimeDomainKHR* pTimeDomains)
        {
            return _vkGetPhysicalDeviceCalibrateableTimeDomainsKHR_fnptr(physicalDevice, pTimeDomainCount, pTimeDomains);
        }
        /// <summary><b>[requires: VK_NV_cooperative_matrix2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV.html" /></remarks>
        public VkResult GetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixFlexibleDimensionsPropertiesNV* pProperties)
        {
            return _vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_cooperative_matrix]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceCooperativeMatrixPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesKHR* pProperties)
        {
            return _vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_NV_cooperative_matrix]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeMatrixPropertiesNV.html" /></remarks>
        public VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
        {
            return _vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_NV_cooperative_vector]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeVectorPropertiesNV.html" /></remarks>
        public VkResult GetPhysicalDeviceCooperativeVectorPropertiesNV(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkCooperativeVectorPropertiesNV* pProperties)
        {
            return _vkGetPhysicalDeviceCooperativeVectorPropertiesNV_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_EXT_directfb_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDirectFBPresentationSupportEXT.html" /></remarks>
        public int GetPhysicalDeviceDirectFBPresentationSupportEXT(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dfb)
        {
            return _vkGetPhysicalDeviceDirectFBPresentationSupportEXT_fnptr(physicalDevice, queueFamilyIndex, dfb);
        }
        /// <summary><b>[requires: VK_KHR_get_display_properties2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPlaneProperties2KHR.html" /></remarks>
        public VkResult GetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
        {
            return _vkGetPhysicalDeviceDisplayPlaneProperties2KHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPlanePropertiesKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
        {
            return _vkGetPhysicalDeviceDisplayPlanePropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_display_properties2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayProperties2KHR.html" /></remarks>
        public VkResult GetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayProperties2KHR* pProperties)
        {
            return _vkGetPhysicalDeviceDisplayProperties2KHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPropertiesKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice, uint* pPropertyCount, VkDisplayPropertiesKHR* pProperties)
        {
            return _vkGetPhysicalDeviceDisplayPropertiesKHR_fnptr(physicalDevice, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalBufferProperties.html" /></remarks>
        public void GetPhysicalDeviceExternalBufferProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
        {
            _vkGetPhysicalDeviceExternalBufferProperties_fnptr(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
        }
        /// <summary><b>[requires: VK_KHR_external_memory_capabilities]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceExternalBufferProperties"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalBufferPropertiesKHR.html" /></remarks>
        public void GetPhysicalDeviceExternalBufferPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties)
        {
            _vkGetPhysicalDeviceExternalBufferPropertiesKHR_fnptr(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalFenceProperties.html" /></remarks>
        public void GetPhysicalDeviceExternalFenceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties)
        {
            _vkGetPhysicalDeviceExternalFenceProperties_fnptr(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
        }
        /// <summary><b>[requires: VK_KHR_external_fence_capabilities]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceExternalFenceProperties"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalFencePropertiesKHR.html" /></remarks>
        public void GetPhysicalDeviceExternalFencePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties)
        {
            _vkGetPhysicalDeviceExternalFencePropertiesKHR_fnptr(physicalDevice, pExternalFenceInfo, pExternalFenceProperties);
        }
        /// <summary><b>[requires: VK_NV_external_memory_capabilities]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalImageFormatPropertiesNV.html" /></remarks>
        public VkResult GetPhysicalDeviceExternalImageFormatPropertiesNV(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlagBits usage, VkImageCreateFlagBits flags, VkExternalMemoryHandleTypeFlagBitsNV externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties)
        {
            return _vkGetPhysicalDeviceExternalImageFormatPropertiesNV_fnptr(physicalDevice, format, type, tiling, usage, flags, externalHandleType, pExternalImageFormatProperties);
        }
        /// <summary><b>[requires: VK_NV_external_memory_sci_buf]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV.html" /></remarks>
        public VkResult GetPhysicalDeviceExternalMemorySciBufPropertiesNV(VkPhysicalDevice physicalDevice, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, VkMemorySciBufPropertiesNV* pMemorySciBufProperties)
        {
            return _vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_fnptr(physicalDevice, handleType, handle, pMemorySciBufProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalSemaphoreProperties.html" /></remarks>
        public void GetPhysicalDeviceExternalSemaphoreProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
        {
            _vkGetPhysicalDeviceExternalSemaphoreProperties_fnptr(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
        }
        /// <summary><b>[requires: VK_KHR_external_semaphore_capabilities]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceExternalSemaphoreProperties"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalSemaphorePropertiesKHR.html" /></remarks>
        public void GetPhysicalDeviceExternalSemaphorePropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties)
        {
            _vkGetPhysicalDeviceExternalSemaphorePropertiesKHR_fnptr(physicalDevice, pExternalSemaphoreInfo, pExternalSemaphoreProperties);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalTensorPropertiesARM.html" /></remarks>
        public void GetPhysicalDeviceExternalTensorPropertiesARM(VkPhysicalDevice physicalDevice, VkPhysicalDeviceExternalTensorInfoARM* pExternalTensorInfo, VkExternalTensorPropertiesARM* pExternalTensorProperties)
        {
            _vkGetPhysicalDeviceExternalTensorPropertiesARM_fnptr(physicalDevice, pExternalTensorInfo, pExternalTensorProperties);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures.html" /></remarks>
        public void GetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures)
        {
            _vkGetPhysicalDeviceFeatures_fnptr(physicalDevice, pFeatures);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures2.html" /></remarks>
        public void GetPhysicalDeviceFeatures2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures)
        {
            _vkGetPhysicalDeviceFeatures2_fnptr(physicalDevice, pFeatures);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceFeatures2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures2KHR.html" /></remarks>
        public void GetPhysicalDeviceFeatures2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures2* pFeatures)
        {
            _vkGetPhysicalDeviceFeatures2KHR_fnptr(physicalDevice, pFeatures);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties.html" /></remarks>
        public void GetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties)
        {
            _vkGetPhysicalDeviceFormatProperties_fnptr(physicalDevice, format, pFormatProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties2.html" /></remarks>
        public void GetPhysicalDeviceFormatProperties2(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties)
        {
            _vkGetPhysicalDeviceFormatProperties2_fnptr(physicalDevice, format, pFormatProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceFormatProperties2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties2KHR.html" /></remarks>
        public void GetPhysicalDeviceFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties2* pFormatProperties)
        {
            _vkGetPhysicalDeviceFormatProperties2KHR_fnptr(physicalDevice, format, pFormatProperties);
        }
        /// <summary><b>[requires: VK_KHR_fragment_shading_rate]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFragmentShadingRatesKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceFragmentShadingRatesKHR(VkPhysicalDevice physicalDevice, uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
        {
            return _vkGetPhysicalDeviceFragmentShadingRatesKHR_fnptr(physicalDevice, pFragmentShadingRateCount, pFragmentShadingRates);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties.html" /></remarks>
        public VkResult GetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlagBits usage, VkImageCreateFlagBits flags, VkImageFormatProperties* pImageFormatProperties)
        {
            return _vkGetPhysicalDeviceImageFormatProperties_fnptr(physicalDevice, format, type, tiling, usage, flags, pImageFormatProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties2.html" /></remarks>
        public VkResult GetPhysicalDeviceImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties)
        {
            return _vkGetPhysicalDeviceImageFormatProperties2_fnptr(physicalDevice, pImageFormatInfo, pImageFormatProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceImageFormatProperties2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties2KHR.html" /></remarks>
        public VkResult GetPhysicalDeviceImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties)
        {
            return _vkGetPhysicalDeviceImageFormatProperties2KHR_fnptr(physicalDevice, pImageFormatInfo, pImageFormatProperties);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties.html" /></remarks>
        public void GetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties)
        {
            _vkGetPhysicalDeviceMemoryProperties_fnptr(physicalDevice, pMemoryProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties2.html" /></remarks>
        public void GetPhysicalDeviceMemoryProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties)
        {
            _vkGetPhysicalDeviceMemoryProperties2_fnptr(physicalDevice, pMemoryProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceMemoryProperties2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties2KHR.html" /></remarks>
        public void GetPhysicalDeviceMemoryProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties2* pMemoryProperties)
        {
            _vkGetPhysicalDeviceMemoryProperties2KHR_fnptr(physicalDevice, pMemoryProperties);
        }
        /// <summary><b>[requires: VK_EXT_sample_locations]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMultisamplePropertiesEXT.html" /></remarks>
        public void GetPhysicalDeviceMultisamplePropertiesEXT(VkPhysicalDevice physicalDevice, VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT* pMultisampleProperties)
        {
            _vkGetPhysicalDeviceMultisamplePropertiesEXT_fnptr(physicalDevice, samples, pMultisampleProperties);
        }
        /// <summary><b>[requires: VK_NV_optical_flow]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceOpticalFlowImageFormatsNV.html" /></remarks>
        public VkResult GetPhysicalDeviceOpticalFlowImageFormatsNV(VkPhysicalDevice physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            return _vkGetPhysicalDeviceOpticalFlowImageFormatsNV_fnptr(physicalDevice, pOpticalFlowImageFormatInfo, pFormatCount, pImageFormatProperties);
        }
        /// <summary><b>[requires: VK_KHR_swapchain | VK_KHR_device_group]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDevicePresentRectanglesKHR.html" /></remarks>
        public VkResult GetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects)
        {
            return _vkGetPhysicalDevicePresentRectanglesKHR_fnptr(physicalDevice, surface, pRectCount, pRects);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties.html" /></remarks>
        public void GetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties)
        {
            _vkGetPhysicalDeviceProperties_fnptr(physicalDevice, pProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties2.html" /></remarks>
        public void GetPhysicalDeviceProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties)
        {
            _vkGetPhysicalDeviceProperties2_fnptr(physicalDevice, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceProperties2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties2KHR.html" /></remarks>
        public void GetPhysicalDeviceProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties2* pProperties)
        {
            _vkGetPhysicalDeviceProperties2KHR_fnptr(physicalDevice, pProperties);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM.html" /></remarks>
        public void GetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM(VkPhysicalDevice physicalDevice, VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM* pQueueFamilyDataGraphProcessingEngineInfo, VkQueueFamilyDataGraphProcessingEnginePropertiesARM* pQueueFamilyDataGraphProcessingEngineProperties)
        {
            _vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM_fnptr(physicalDevice, pQueueFamilyDataGraphProcessingEngineInfo, pQueueFamilyDataGraphProcessingEngineProperties);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM.html" /></remarks>
        public VkResult GetPhysicalDeviceQueueFamilyDataGraphPropertiesARM(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, uint* pQueueFamilyDataGraphPropertyCount, VkQueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties)
        {
            return _vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM_fnptr(physicalDevice, queueFamilyIndex, pQueueFamilyDataGraphPropertyCount, pQueueFamilyDataGraphProperties);
        }
        /// <summary><b>[requires: VK_KHR_performance_query]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR.html" /></remarks>
        public void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkPhysicalDevice physicalDevice, VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo, uint* pNumPasses)
        {
            _vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_fnptr(physicalDevice, pPerformanceQueryCreateInfo, pNumPasses);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties.html" /></remarks>
        public void GetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties)
        {
            _vkGetPhysicalDeviceQueueFamilyProperties_fnptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties2.html" /></remarks>
        public void GetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
        {
            _vkGetPhysicalDeviceQueueFamilyProperties2_fnptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceQueueFamilyProperties2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties2KHR.html" /></remarks>
        public void GetPhysicalDeviceQueueFamilyProperties2KHR(VkPhysicalDevice physicalDevice, uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
        {
            _vkGetPhysicalDeviceQueueFamilyProperties2KHR_fnptr(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        /// <summary><b>[requires: VK_KHR_object_refresh]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceRefreshableObjectTypesKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceRefreshableObjectTypesKHR(VkPhysicalDevice physicalDevice, uint* pRefreshableObjectTypeCount, VkObjectType* pRefreshableObjectTypes)
        {
            return _vkGetPhysicalDeviceRefreshableObjectTypesKHR_fnptr(physicalDevice, pRefreshableObjectTypeCount, pRefreshableObjectTypes);
        }
        /// <summary><b>[requires: VK_NV_external_memory_sci_buf]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSciBufAttributesNV.html" /></remarks>
        public VkResult GetPhysicalDeviceSciBufAttributesNV(VkPhysicalDevice physicalDevice, IntPtr pAttributes)
        {
            return _vkGetPhysicalDeviceSciBufAttributesNV_fnptr(physicalDevice, pAttributes);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync | VK_NV_external_sci_sync2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSciSyncAttributesNV.html" /></remarks>
        public VkResult GetPhysicalDeviceSciSyncAttributesNV(VkPhysicalDevice physicalDevice, VkSciSyncAttributesInfoNV* pSciSyncAttributesInfo, IntPtr pAttributes)
        {
            return _vkGetPhysicalDeviceSciSyncAttributesNV_fnptr(physicalDevice, pSciSyncAttributesInfo, pAttributes);
        }
        /// <summary><b>[requires: VK_QNX_screen_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceScreenPresentationSupportQNX.html" /></remarks>
        public int GetPhysicalDeviceScreenPresentationSupportQNX(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* window)
        {
            return _vkGetPhysicalDeviceScreenPresentationSupportQNX_fnptr(physicalDevice, queueFamilyIndex, window);
        }
        /// <summary><b>[requires: v1.0]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties.html" /></remarks>
        public void GetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlagBits usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties)
        {
            _vkGetPhysicalDeviceSparseImageFormatProperties_fnptr(physicalDevice, format, type, samples, usage, tiling, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: v1.1]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties2.html" /></remarks>
        public void GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
        {
            _vkGetPhysicalDeviceSparseImageFormatProperties2_fnptr(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_get_physical_device_properties2]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceSparseImageFormatProperties2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties2KHR.html" /></remarks>
        public void GetPhysicalDeviceSparseImageFormatProperties2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties)
        {
            _vkGetPhysicalDeviceSparseImageFormatProperties2KHR_fnptr(physicalDevice, pFormatInfo, pPropertyCount, pProperties);
        }
        /// <summary><b>[requires: VK_NV_coverage_reduction_mode]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV.html" /></remarks>
        public VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkPhysicalDevice physicalDevice, uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
        {
            return _vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_fnptr(physicalDevice, pCombinationCount, pCombinations);
        }
        /// <summary><b>[requires: VK_EXT_display_surface_counter]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilities2EXT.html" /></remarks>
        public VkResult GetPhysicalDeviceSurfaceCapabilities2EXT(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities)
        {
            return _vkGetPhysicalDeviceSurfaceCapabilities2EXT_fnptr(physicalDevice, surface, pSurfaceCapabilities);
        }
        /// <summary><b>[requires: VK_KHR_get_surface_capabilities2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilities2KHR.html" /></remarks>
        public VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities)
        {
            return _vkGetPhysicalDeviceSurfaceCapabilities2KHR_fnptr(physicalDevice, pSurfaceInfo, pSurfaceCapabilities);
        }
        /// <summary><b>[requires: VK_KHR_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilitiesKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceSurfaceCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities)
        {
            return _vkGetPhysicalDeviceSurfaceCapabilitiesKHR_fnptr(physicalDevice, surface, pSurfaceCapabilities);
        }
        /// <summary><b>[requires: VK_KHR_get_surface_capabilities2]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceFormats2KHR.html" /></remarks>
        public VkResult GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            return _vkGetPhysicalDeviceSurfaceFormats2KHR_fnptr(physicalDevice, pSurfaceInfo, pSurfaceFormatCount, pSurfaceFormats);
        }
        /// <summary><b>[requires: VK_KHR_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceFormatsKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
        {
            return _vkGetPhysicalDeviceSurfaceFormatsKHR_fnptr(physicalDevice, surface, pSurfaceFormatCount, pSurfaceFormats);
        }
        /// <summary><b>[requires: VK_EXT_full_screen_exclusive]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfacePresentModes2EXT.html" /></remarks>
        public VkResult GetPhysicalDeviceSurfacePresentModes2EXT(VkPhysicalDevice physicalDevice, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            return _vkGetPhysicalDeviceSurfacePresentModes2EXT_fnptr(physicalDevice, pSurfaceInfo, pPresentModeCount, pPresentModes);
        }
        /// <summary><b>[requires: VK_KHR_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfacePresentModesKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            return _vkGetPhysicalDeviceSurfacePresentModesKHR_fnptr(physicalDevice, surface, pPresentModeCount, pPresentModes);
        }
        /// <summary><b>[requires: VK_KHR_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceSupportKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceSurfaceSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, int* pSupported)
        {
            return _vkGetPhysicalDeviceSurfaceSupportKHR_fnptr(physicalDevice, queueFamilyIndex, surface, pSupported);
        }
        /// <summary><b>[requires: v1.3]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceToolProperties.html" /></remarks>
        public VkResult GetPhysicalDeviceToolProperties(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
        {
            return _vkGetPhysicalDeviceToolProperties_fnptr(physicalDevice, pToolCount, pToolProperties);
        }
        /// <summary><b>[requires: VK_EXT_tooling_info]</b> [instance command]  Alias of <see cref="GetPhysicalDeviceToolProperties"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceToolPropertiesEXT.html" /></remarks>
        public VkResult GetPhysicalDeviceToolPropertiesEXT(VkPhysicalDevice physicalDevice, uint* pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
        {
            return _vkGetPhysicalDeviceToolPropertiesEXT_fnptr(physicalDevice, pToolCount, pToolProperties);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoCapabilitiesKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceVideoCapabilitiesKHR(VkPhysicalDevice physicalDevice, VkVideoProfileInfoKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities)
        {
            return _vkGetPhysicalDeviceVideoCapabilitiesKHR_fnptr(physicalDevice, pVideoProfile, pCapabilities);
        }
        /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo, VkVideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties)
        {
            return _vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_fnptr(physicalDevice, pQualityLevelInfo, pQualityLevelProperties);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoFormatPropertiesKHR.html" /></remarks>
        public VkResult GetPhysicalDeviceVideoFormatPropertiesKHR(VkPhysicalDevice physicalDevice, VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            return _vkGetPhysicalDeviceVideoFormatPropertiesKHR_fnptr(physicalDevice, pVideoFormatInfo, pVideoFormatPropertyCount, pVideoFormatProperties);
        }
        /// <summary><b>[requires: VK_KHR_wayland_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceWaylandPresentationSupportKHR.html" /></remarks>
        public int GetPhysicalDeviceWaylandPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display)
        {
            return _vkGetPhysicalDeviceWaylandPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, display);
        }
        /// <summary><b>[requires: VK_KHR_win32_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceWin32PresentationSupportKHR.html" /></remarks>
        public int GetPhysicalDeviceWin32PresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex)
        {
            return _vkGetPhysicalDeviceWin32PresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex);
        }
        /// <summary><b>[requires: VK_KHR_xcb_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceXcbPresentationSupportKHR.html" /></remarks>
        public int GetPhysicalDeviceXcbPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, uint visual_id)
        {
            return _vkGetPhysicalDeviceXcbPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, connection, visual_id);
        }
        /// <summary><b>[requires: VK_KHR_xlib_surface]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceXlibPresentationSupportKHR.html" /></remarks>
        public int GetPhysicalDeviceXlibPresentationSupportKHR(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, nuint visualID)
        {
            return _vkGetPhysicalDeviceXlibPresentationSupportKHR_fnptr(physicalDevice, queueFamilyIndex, dpy, visualID);
        }
        /// <summary><b>[requires: VK_EXT_acquire_xlib_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRandROutputDisplayEXT.html" /></remarks>
        public VkResult GetRandROutputDisplayEXT(VkPhysicalDevice physicalDevice, IntPtr dpy, nuint rrOutput, VkDisplayKHR* pDisplay)
        {
            return _vkGetRandROutputDisplayEXT_fnptr(physicalDevice, dpy, rrOutput, pDisplay);
        }
        /// <summary><b>[requires: VK_NV_acquire_winrt_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetWinrtDisplayNV.html" /></remarks>
        public VkResult GetWinrtDisplayNV(VkPhysicalDevice physicalDevice, uint deviceRelativeId, VkDisplayKHR* pDisplay)
        {
            return _vkGetWinrtDisplayNV_fnptr(physicalDevice, deviceRelativeId, pDisplay);
        }
        /// <summary><b>[requires: VK_EXT_direct_mode_display]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseDisplayEXT.html" /></remarks>
        public VkResult ReleaseDisplayEXT(VkPhysicalDevice physicalDevice, VkDisplayKHR display)
        {
            return _vkReleaseDisplayEXT_fnptr(physicalDevice, display);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [instance command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSubmitDebugUtilsMessageEXT.html" /></remarks>
        public void SubmitDebugUtilsMessageEXT(VkInstance instance, VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, VkDebugUtilsMessageTypeFlagBitsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData)
        {
            _vkSubmitDebugUtilsMessageEXT_fnptr(instance, messageSeverity, messageTypes, pCallbackData);
        }
        public delegate* unmanaged<VkPhysicalDevice, int, VkDisplayKHR, VkResult> _vkAcquireDrmDisplayEXT_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult> _vkAcquireWinrtDisplayNV_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, IntPtr, VkDisplayKHR, VkResult> _vkAcquireXlibDisplayEXT_fnptr;
        public delegate* unmanaged<VkInstance, VkAndroidSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateAndroidSurfaceKHR_fnptr;
        public delegate* unmanaged<VkInstance, VkDebugReportCallbackCreateInfoEXT*, VkAllocationCallbacks*, VkDebugReportCallbackEXT*, VkResult> _vkCreateDebugReportCallbackEXT_fnptr;
        public delegate* unmanaged<VkInstance, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, VkDebugUtilsMessengerEXT*, VkResult> _vkCreateDebugUtilsMessengerEXT_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkDeviceCreateInfo*, VkAllocationCallbacks*, VkDevice*, VkResult> _vkCreateDevice_fnptr;
        public delegate* unmanaged<VkInstance, VkDirectFBSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateDirectFBSurfaceEXT_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkDisplayModeCreateInfoKHR*, VkAllocationCallbacks*, VkDisplayModeKHR*, VkResult> _vkCreateDisplayModeKHR_fnptr;
        public delegate* unmanaged<VkInstance, VkDisplaySurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateDisplayPlaneSurfaceKHR_fnptr;
        public delegate* unmanaged<VkInstance, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateHeadlessSurfaceEXT_fnptr;
        public delegate* unmanaged<VkInstance, VkImagePipeSurfaceCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateImagePipeSurfaceFUCHSIA_fnptr;
        public delegate* unmanaged<VkInstance, VkIOSSurfaceCreateInfoMVK*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateIOSSurfaceMVK_fnptr;
        public delegate* unmanaged<VkInstance, VkMacOSSurfaceCreateInfoMVK*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateMacOSSurfaceMVK_fnptr;
        public delegate* unmanaged<VkInstance, VkMetalSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateMetalSurfaceEXT_fnptr;
        public delegate* unmanaged<VkInstance, VkScreenSurfaceCreateInfoQNX*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateScreenSurfaceQNX_fnptr;
        public delegate* unmanaged<VkInstance, VkStreamDescriptorSurfaceCreateInfoGGP*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateStreamDescriptorSurfaceGGP_fnptr;
        public delegate* unmanaged<VkInstance, VkSurfaceCreateInfoOHOS*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateSurfaceOHOS_fnptr;
        public delegate* unmanaged<VkInstance, VkViSurfaceCreateInfoNN*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateViSurfaceNN_fnptr;
        public delegate* unmanaged<VkInstance, VkWaylandSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateWaylandSurfaceKHR_fnptr;
        public delegate* unmanaged<VkInstance, VkWin32SurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateWin32SurfaceKHR_fnptr;
        public delegate* unmanaged<VkInstance, VkXcbSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateXcbSurfaceKHR_fnptr;
        public delegate* unmanaged<VkInstance, VkXlibSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateXlibSurfaceKHR_fnptr;
        public delegate* unmanaged<VkInstance, VkDebugReportFlagBitsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*, void> _vkDebugReportMessageEXT_fnptr;
        public delegate* unmanaged<VkInstance, VkDebugReportCallbackEXT, VkAllocationCallbacks*, void> _vkDestroyDebugReportCallbackEXT_fnptr;
        public delegate* unmanaged<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void> _vkDestroyDebugUtilsMessengerEXT_fnptr;
        public delegate* unmanaged<VkInstance, VkAllocationCallbacks*, void> _vkDestroyInstance_fnptr;
        public delegate* unmanaged<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void> _vkDestroySurfaceKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, byte*, uint*, VkExtensionProperties*, VkResult> _vkEnumerateDeviceExtensionProperties_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkLayerProperties*, VkResult> _vkEnumerateDeviceLayerProperties_fnptr;
        public delegate* unmanaged<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult> _vkEnumeratePhysicalDeviceGroups_fnptr;
        public delegate* unmanaged<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult> _vkEnumeratePhysicalDeviceGroupsKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkPerformanceCounterARM*, VkPerformanceCounterDescriptionARM*, VkResult> _vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkPerformanceCounterKHR*, VkPerformanceCounterDescriptionKHR*, VkResult> _vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_fnptr;
        public delegate* unmanaged<VkInstance, uint*, VkPhysicalDevice*, VkResult> _vkEnumeratePhysicalDevices_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModeProperties2KHR*, VkResult> _vkGetDisplayModeProperties2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModePropertiesKHR*, VkResult> _vkGetDisplayModePropertiesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkDisplayPlaneInfo2KHR*, VkDisplayPlaneCapabilities2KHR*, VkResult> _vkGetDisplayPlaneCapabilities2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkDisplayModeKHR, uint, VkDisplayPlaneCapabilitiesKHR*, VkResult> _vkGetDisplayPlaneCapabilitiesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkDisplayKHR*, VkResult> _vkGetDisplayPlaneSupportedDisplaysKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, int, uint, VkDisplayKHR*, VkResult> _vkGetDrmDisplayEXT_fnptr;
        public delegate* unmanaged<VkInstance, byte*, IntPtr> _vkGetInstanceProcAddr_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkTimeDomainKHR*, VkResult> _vkGetPhysicalDeviceCalibrateableTimeDomainsEXT_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkTimeDomainKHR*, VkResult> _vkGetPhysicalDeviceCalibrateableTimeDomainsKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixFlexibleDimensionsPropertiesNV*, VkResult> _vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesKHR*, VkResult> _vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult> _vkGetPhysicalDeviceCooperativeMatrixPropertiesNV_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkCooperativeVectorPropertiesNV*, VkResult> _vkGetPhysicalDeviceCooperativeVectorPropertiesNV_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, int> _vkGetPhysicalDeviceDirectFBPresentationSupportEXT_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPlaneProperties2KHR*, VkResult> _vkGetPhysicalDeviceDisplayPlaneProperties2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPlanePropertiesKHR*, VkResult> _vkGetPhysicalDeviceDisplayPlanePropertiesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayProperties2KHR*, VkResult> _vkGetPhysicalDeviceDisplayProperties2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkDisplayPropertiesKHR*, VkResult> _vkGetPhysicalDeviceDisplayPropertiesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void> _vkGetPhysicalDeviceExternalBufferProperties_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void> _vkGetPhysicalDeviceExternalBufferPropertiesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void> _vkGetPhysicalDeviceExternalFenceProperties_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void> _vkGetPhysicalDeviceExternalFencePropertiesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, VkExternalMemoryHandleTypeFlagBitsNV, VkExternalImageFormatPropertiesNV*, VkResult> _vkGetPhysicalDeviceExternalImageFormatPropertiesNV_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkExternalMemoryHandleTypeFlagBits, IntPtr, VkMemorySciBufPropertiesNV*, VkResult> _vkGetPhysicalDeviceExternalMemorySciBufPropertiesNV_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void> _vkGetPhysicalDeviceExternalSemaphoreProperties_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void> _vkGetPhysicalDeviceExternalSemaphorePropertiesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceExternalTensorInfoARM*, VkExternalTensorPropertiesARM*, void> _vkGetPhysicalDeviceExternalTensorPropertiesARM_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceFeatures*, void> _vkGetPhysicalDeviceFeatures_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> _vkGetPhysicalDeviceFeatures2_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> _vkGetPhysicalDeviceFeatures2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkFormat, VkFormatProperties*, void> _vkGetPhysicalDeviceFormatProperties_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> _vkGetPhysicalDeviceFormatProperties2_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> _vkGetPhysicalDeviceFormatProperties2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult> _vkGetPhysicalDeviceFragmentShadingRatesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, VkImageFormatProperties*, VkResult> _vkGetPhysicalDeviceImageFormatProperties_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult> _vkGetPhysicalDeviceImageFormatProperties2_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult> _vkGetPhysicalDeviceImageFormatProperties2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties*, void> _vkGetPhysicalDeviceMemoryProperties_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> _vkGetPhysicalDeviceMemoryProperties2_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> _vkGetPhysicalDeviceMemoryProperties2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkSampleCountFlagBits, VkMultisamplePropertiesEXT*, void> _vkGetPhysicalDeviceMultisamplePropertiesEXT_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkOpticalFlowImageFormatInfoNV*, uint*, VkOpticalFlowImageFormatPropertiesNV*, VkResult> _vkGetPhysicalDeviceOpticalFlowImageFormatsNV_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult> _vkGetPhysicalDevicePresentRectanglesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties*, void> _vkGetPhysicalDeviceProperties_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> _vkGetPhysicalDeviceProperties2_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> _vkGetPhysicalDeviceProperties2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM*, VkQueueFamilyDataGraphProcessingEnginePropertiesARM*, void> _vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint, uint*, VkQueueFamilyDataGraphPropertiesARM*, VkResult> _vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, uint*, void> _vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties*, void> _vkGetPhysicalDeviceQueueFamilyProperties_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void> _vkGetPhysicalDeviceQueueFamilyProperties2_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void> _vkGetPhysicalDeviceQueueFamilyProperties2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkObjectType*, VkResult> _vkGetPhysicalDeviceRefreshableObjectTypesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, IntPtr, VkResult> _vkGetPhysicalDeviceSciBufAttributesNV_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkSciSyncAttributesInfoNV*, IntPtr, VkResult> _vkGetPhysicalDeviceSciSyncAttributesNV_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint, IntPtr*, int> _vkGetPhysicalDeviceScreenPresentationSupportQNX_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlagBits, VkImageUsageFlagBits, VkImageTiling, uint*, VkSparseImageFormatProperties*, void> _vkGetPhysicalDeviceSparseImageFormatProperties_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void> _vkGetPhysicalDeviceSparseImageFormatProperties2_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void> _vkGetPhysicalDeviceSparseImageFormatProperties2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult> _vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult> _vkGetPhysicalDeviceSurfaceCapabilities2EXT_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkSurfaceCapabilities2KHR*, VkResult> _vkGetPhysicalDeviceSurfaceCapabilities2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilitiesKHR*, VkResult> _vkGetPhysicalDeviceSurfaceCapabilitiesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkSurfaceFormat2KHR*, VkResult> _vkGetPhysicalDeviceSurfaceFormats2KHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkSurfaceFormatKHR*, VkResult> _vkGetPhysicalDeviceSurfaceFormatsKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkPresentModeKHR*, VkResult> _vkGetPhysicalDeviceSurfacePresentModes2EXT_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkSurfaceKHR, uint*, VkPresentModeKHR*, VkResult> _vkGetPhysicalDeviceSurfacePresentModesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint, VkSurfaceKHR, int*, VkResult> _vkGetPhysicalDeviceSurfaceSupportKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult> _vkGetPhysicalDeviceToolProperties_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult> _vkGetPhysicalDeviceToolPropertiesEXT_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkVideoProfileInfoKHR*, VkVideoCapabilitiesKHR*, VkResult> _vkGetPhysicalDeviceVideoCapabilitiesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR*, VkVideoEncodeQualityLevelPropertiesKHR*, VkResult> _vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkPhysicalDeviceVideoFormatInfoKHR*, uint*, VkVideoFormatPropertiesKHR*, VkResult> _vkGetPhysicalDeviceVideoFormatPropertiesKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, int> _vkGetPhysicalDeviceWaylandPresentationSupportKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint, int> _vkGetPhysicalDeviceWin32PresentationSupportKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, uint, int> _vkGetPhysicalDeviceXcbPresentationSupportKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint, IntPtr, nuint, int> _vkGetPhysicalDeviceXlibPresentationSupportKHR_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, IntPtr, nuint, VkDisplayKHR*, VkResult> _vkGetRandROutputDisplayEXT_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, uint, VkDisplayKHR*, VkResult> _vkGetWinrtDisplayNV_fnptr;
        public delegate* unmanaged<VkPhysicalDevice, VkDisplayKHR, VkResult> _vkReleaseDisplayEXT_fnptr;
        public delegate* unmanaged<VkInstance, VkDebugUtilsMessageSeverityFlagBitsEXT, VkDebugUtilsMessageTypeFlagBitsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void> _vkSubmitDebugUtilsMessageEXT_fnptr;
    }
    public unsafe partial struct DeviceDispatchTable
    {
        ///<summary>The <see cref="VkDevice"/> used to load this dispatch table.</summary>
        public readonly VkDevice Device;
        public DeviceDispatchTable(VkDevice device)
        {
            Device = device;
            _vkAcquireFullScreenExclusiveModeEXT_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkAcquireFullScreenExclusiveModeEXT");
            _vkAcquireImageANDROID_fnptr = (delegate* unmanaged<VkDevice, VkImage, int, VkSemaphore, VkFence, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkAcquireImageANDROID");
            _vkAcquireImageOHOS_fnptr = (delegate* unmanaged<VkDevice, VkImage, int, VkSemaphore, VkFence, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkAcquireImageOHOS");
            _vkAcquireNextImage2KHR_fnptr = (delegate* unmanaged<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkAcquireNextImage2KHR");
            _vkAcquireNextImageKHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, uint*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkAcquireNextImageKHR");
            _vkAcquirePerformanceConfigurationINTEL_fnptr = (delegate* unmanaged<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkAcquirePerformanceConfigurationINTEL");
            _vkAcquireProfilingLockKHR_fnptr = (delegate* unmanaged<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkAcquireProfilingLockKHR");
            _vkAllocateCommandBuffers_fnptr = (delegate* unmanaged<VkDevice, VkCommandBufferAllocateInfo*, VkCommandBuffer*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkAllocateCommandBuffers");
            _vkAllocateDescriptorSets_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetAllocateInfo*, VkDescriptorSet*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkAllocateDescriptorSets");
            _vkAllocateMemory_fnptr = (delegate* unmanaged<VkDevice, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkAllocateMemory");
            _vkAntiLagUpdateAMD_fnptr = (delegate* unmanaged<VkDevice, VkAntiLagDataAMD*, void>)VKLoader.GetDeviceProcAddr(device, "vkAntiLagUpdateAMD");
            _vkBeginCommandBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCommandBufferBeginInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBeginCommandBuffer");
            _vkBindAccelerationStructureMemoryNV_fnptr = (delegate* unmanaged<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBindAccelerationStructureMemoryNV");
            _vkBindBufferMemory_fnptr = (delegate* unmanaged<VkDevice, VkBuffer, VkDeviceMemory, ulong, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBindBufferMemory");
            _vkBindBufferMemory2_fnptr = (delegate* unmanaged<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBindBufferMemory2");
            _vkBindBufferMemory2KHR_fnptr = (delegate* unmanaged<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBindBufferMemory2KHR");
            _vkBindDataGraphPipelineSessionMemoryARM_fnptr = (delegate* unmanaged<VkDevice, uint, VkBindDataGraphPipelineSessionMemoryInfoARM*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBindDataGraphPipelineSessionMemoryARM");
            _vkBindImageMemory_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkDeviceMemory, ulong, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBindImageMemory");
            _vkBindImageMemory2_fnptr = (delegate* unmanaged<VkDevice, uint, VkBindImageMemoryInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBindImageMemory2");
            _vkBindImageMemory2KHR_fnptr = (delegate* unmanaged<VkDevice, uint, VkBindImageMemoryInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBindImageMemory2KHR");
            _vkBindOpticalFlowSessionImageNV_fnptr = (delegate* unmanaged<VkDevice, VkOpticalFlowSessionNV, VkOpticalFlowSessionBindingPointNV, VkImageView, VkImageLayout, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBindOpticalFlowSessionImageNV");
            _vkBindTensorMemoryARM_fnptr = (delegate* unmanaged<VkDevice, uint, VkBindTensorMemoryInfoARM*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBindTensorMemoryARM");
            _vkBindVideoSessionMemoryKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionKHR, uint, VkBindVideoSessionMemoryInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBindVideoSessionMemoryKHR");
            _vkBuildAccelerationStructuresKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBuildAccelerationStructuresKHR");
            _vkBuildMicromapsEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkBuildMicromapsEXT");
            _vkCmdBeginConditionalRenderingEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginConditionalRenderingEXT");
            _vkCmdBeginCustomResolveEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBeginCustomResolveInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginCustomResolveEXT");
            _vkCmdBeginDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginDebugUtilsLabelEXT");
            _vkCmdBeginPerTileExecutionQCOM_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPerTileBeginInfoQCOM*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginPerTileExecutionQCOM");
            _vkCmdBeginQuery_fnptr = (delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlagBits, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginQuery");
            _vkCmdBeginQueryIndexedEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlagBits, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginQueryIndexedEXT");
            _vkCmdBeginRendering_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderingInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginRendering");
            _vkCmdBeginRenderingKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderingInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginRenderingKHR");
            _vkCmdBeginRenderPass_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassContents, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginRenderPass");
            _vkCmdBeginRenderPass2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginRenderPass2");
            _vkCmdBeginRenderPass2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginRenderPass2KHR");
            _vkCmdBeginTransformFeedbackEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginTransformFeedbackEXT");
            _vkCmdBeginVideoCodingKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBeginVideoCodingKHR");
            _vkCmdBindDescriptorBufferEmbeddedSamplers2EXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindDescriptorBufferEmbeddedSamplers2EXT");
            _vkCmdBindDescriptorBufferEmbeddedSamplersEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindDescriptorBufferEmbeddedSamplersEXT");
            _vkCmdBindDescriptorBuffersEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkDescriptorBufferBindingInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindDescriptorBuffersEXT");
            _vkCmdBindDescriptorSets_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkDescriptorSet*, uint, uint*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindDescriptorSets");
            _vkCmdBindDescriptorSets2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBindDescriptorSetsInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindDescriptorSets2");
            _vkCmdBindDescriptorSets2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBindDescriptorSetsInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindDescriptorSets2KHR");
            _vkCmdBindIndexBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkIndexType, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindIndexBuffer");
            _vkCmdBindIndexBuffer2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, VkIndexType, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindIndexBuffer2");
            _vkCmdBindIndexBuffer2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, VkIndexType, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindIndexBuffer2KHR");
            _vkCmdBindInvocationMaskHUAWEI_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindInvocationMaskHUAWEI");
            _vkCmdBindPipeline_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindPipeline");
            _vkCmdBindPipelineShaderGroupNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindPipelineShaderGroupNV");
            _vkCmdBindShadersEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkShaderStageFlagBits*, VkShaderEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindShadersEXT");
            _vkCmdBindShadingRateImageNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindShadingRateImageNV");
            _vkCmdBindTileMemoryQCOM_fnptr = (delegate* unmanaged<VkCommandBuffer, VkTileMemoryBindInfoQCOM*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindTileMemoryQCOM");
            _vkCmdBindTransformFeedbackBuffersEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindTransformFeedbackBuffersEXT");
            _vkCmdBindVertexBuffers_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindVertexBuffers");
            _vkCmdBindVertexBuffers2_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, ulong*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindVertexBuffers2");
            _vkCmdBindVertexBuffers2EXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, ulong*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBindVertexBuffers2EXT");
            _vkCmdBlitImage_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageBlit*, VkFilter, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBlitImage");
            _vkCmdBlitImage2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBlitImageInfo2*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBlitImage2");
            _vkCmdBlitImage2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBlitImageInfo2*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBlitImage2KHR");
            _vkCmdBuildAccelerationStructureNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, ulong, int, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, ulong, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBuildAccelerationStructureNV");
            _vkCmdBuildAccelerationStructuresIndirectKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, ulong*, uint*, uint**, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBuildAccelerationStructuresIndirectKHR");
            _vkCmdBuildAccelerationStructuresKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBuildAccelerationStructuresKHR");
            _vkCmdBuildClusterAccelerationStructureIndirectNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkClusterAccelerationStructureCommandsInfoNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBuildClusterAccelerationStructureIndirectNV");
            _vkCmdBuildMicromapsEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkMicromapBuildInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBuildMicromapsEXT");
            _vkCmdBuildPartitionedAccelerationStructuresNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuildPartitionedAccelerationStructureInfoNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdBuildPartitionedAccelerationStructuresNV");
            _vkCmdClearAttachments_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkClearAttachment*, uint, VkClearRect*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdClearAttachments");
            _vkCmdClearColorImage_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkClearColorValue*, uint, VkImageSubresourceRange*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdClearColorImage");
            _vkCmdClearDepthStencilImage_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkClearDepthStencilValue*, uint, VkImageSubresourceRange*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdClearDepthStencilImage");
            _vkCmdControlVideoCodingKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdControlVideoCodingKHR");
            _vkCmdConvertCooperativeVectorMatrixNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkConvertCooperativeVectorMatrixInfoNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdConvertCooperativeVectorMatrixNV");
            _vkCmdCopyAccelerationStructureKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyAccelerationStructureKHR");
            _vkCmdCopyAccelerationStructureNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyAccelerationStructureNV");
            _vkCmdCopyAccelerationStructureToMemoryKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyAccelerationStructureToMemoryKHR");
            _vkCmdCopyBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyBuffer");
            _vkCmdCopyBuffer2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyBufferInfo2*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyBuffer2");
            _vkCmdCopyBuffer2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyBufferInfo2*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyBuffer2KHR");
            _vkCmdCopyBufferToImage_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, VkImage, VkImageLayout, uint, VkBufferImageCopy*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyBufferToImage");
            _vkCmdCopyBufferToImage2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyBufferToImageInfo2*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyBufferToImage2");
            _vkCmdCopyBufferToImage2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyBufferToImageInfo2*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyBufferToImage2KHR");
            _vkCmdCopyImage_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageCopy*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyImage");
            _vkCmdCopyImage2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyImageInfo2*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyImage2");
            _vkCmdCopyImage2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyImageInfo2*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyImage2KHR");
            _vkCmdCopyImageToBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyImageToBuffer");
            _vkCmdCopyImageToBuffer2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyImageToBufferInfo2*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyImageToBuffer2");
            _vkCmdCopyImageToBuffer2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyImageToBufferInfo2*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyImageToBuffer2KHR");
            _vkCmdCopyMemoryIndirectKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyMemoryIndirectInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyMemoryIndirectKHR");
            _vkCmdCopyMemoryIndirectNV_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyMemoryIndirectNV");
            _vkCmdCopyMemoryToAccelerationStructureKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyMemoryToAccelerationStructureKHR");
            _vkCmdCopyMemoryToImageIndirectKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToImageIndirectInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyMemoryToImageIndirectKHR");
            _vkCmdCopyMemoryToImageIndirectNV_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyMemoryToImageIndirectNV");
            _vkCmdCopyMemoryToMicromapEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToMicromapInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyMemoryToMicromapEXT");
            _vkCmdCopyMicromapEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyMicromapInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyMicromapEXT");
            _vkCmdCopyMicromapToMemoryEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyMicromapToMemoryInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyMicromapToMemoryEXT");
            _vkCmdCopyQueryPoolResults_fnptr = (delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, VkQueryResultFlagBits, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyQueryPoolResults");
            _vkCmdCopyTensorARM_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCopyTensorInfoARM*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCopyTensorARM");
            _vkCmdCudaLaunchKernelNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCudaLaunchInfoNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCudaLaunchKernelNV");
            _vkCmdCuLaunchKernelNVX_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCuLaunchInfoNVX*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdCuLaunchKernelNVX");
            _vkCmdDebugMarkerBeginEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDebugMarkerBeginEXT");
            _vkCmdDebugMarkerEndEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDebugMarkerEndEXT");
            _vkCmdDebugMarkerInsertEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDebugMarkerInsertEXT");
            _vkCmdDecodeVideoKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkVideoDecodeInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDecodeVideoKHR");
            _vkCmdDecompressMemoryEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDecompressMemoryInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDecompressMemoryEXT");
            _vkCmdDecompressMemoryIndirectCountEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkMemoryDecompressionMethodFlagBitsEXT, ulong, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDecompressMemoryIndirectCountEXT");
            _vkCmdDecompressMemoryIndirectCountNV_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, ulong, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDecompressMemoryIndirectCountNV");
            _vkCmdDecompressMemoryNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkDecompressMemoryRegionNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDecompressMemoryNV");
            _vkCmdDispatch_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDispatch");
            _vkCmdDispatchBase_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDispatchBase");
            _vkCmdDispatchBaseKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDispatchBaseKHR");
            _vkCmdDispatchDataGraphARM_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDataGraphPipelineSessionARM, VkDataGraphPipelineDispatchInfoARM*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDispatchDataGraphARM");
            _vkCmdDispatchGraphAMDX_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, ulong, VkDispatchGraphCountInfoAMDX*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDispatchGraphAMDX");
            _vkCmdDispatchGraphIndirectAMDX_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, ulong, VkDispatchGraphCountInfoAMDX*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDispatchGraphIndirectAMDX");
            _vkCmdDispatchGraphIndirectCountAMDX_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, ulong, ulong, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDispatchGraphIndirectCountAMDX");
            _vkCmdDispatchIndirect_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDispatchIndirect");
            _vkCmdDispatchTileQCOM_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDispatchTileInfoQCOM*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDispatchTileQCOM");
            _vkCmdDraw_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDraw");
            _vkCmdDrawClusterHUAWEI_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawClusterHUAWEI");
            _vkCmdDrawClusterIndirectHUAWEI_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawClusterIndirectHUAWEI");
            _vkCmdDrawIndexed_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, int, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawIndexed");
            _vkCmdDrawIndexedIndirect_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawIndexedIndirect");
            _vkCmdDrawIndexedIndirectCount_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawIndexedIndirectCount");
            _vkCmdDrawIndexedIndirectCountAMD_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawIndexedIndirectCountAMD");
            _vkCmdDrawIndexedIndirectCountKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawIndexedIndirectCountKHR");
            _vkCmdDrawIndirect_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawIndirect");
            _vkCmdDrawIndirectByteCountEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawIndirectByteCountEXT");
            _vkCmdDrawIndirectCount_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawIndirectCount");
            _vkCmdDrawIndirectCountAMD_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawIndirectCountAMD");
            _vkCmdDrawIndirectCountKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawIndirectCountKHR");
            _vkCmdDrawMeshTasksEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawMeshTasksEXT");
            _vkCmdDrawMeshTasksIndirectCountEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectCountEXT");
            _vkCmdDrawMeshTasksIndirectCountNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectCountNV");
            _vkCmdDrawMeshTasksIndirectEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectEXT");
            _vkCmdDrawMeshTasksIndirectNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawMeshTasksIndirectNV");
            _vkCmdDrawMeshTasksNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawMeshTasksNV");
            _vkCmdDrawMultiEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkMultiDrawInfoEXT*, uint, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawMultiEXT");
            _vkCmdDrawMultiIndexedEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkMultiDrawIndexedInfoEXT*, uint, uint, uint, int*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdDrawMultiIndexedEXT");
            _vkCmdEncodeVideoKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkVideoEncodeInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEncodeVideoKHR");
            _vkCmdEndConditionalRenderingEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndConditionalRenderingEXT");
            _vkCmdEndDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndDebugUtilsLabelEXT");
            _vkCmdEndPerTileExecutionQCOM_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPerTileEndInfoQCOM*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndPerTileExecutionQCOM");
            _vkCmdEndQuery_fnptr = (delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndQuery");
            _vkCmdEndQueryIndexedEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndQueryIndexedEXT");
            _vkCmdEndRendering_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndRendering");
            _vkCmdEndRendering2EXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderingEndInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndRendering2EXT");
            _vkCmdEndRendering2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderingEndInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndRendering2KHR");
            _vkCmdEndRenderingKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndRenderingKHR");
            _vkCmdEndRenderPass_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndRenderPass");
            _vkCmdEndRenderPass2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSubpassEndInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndRenderPass2");
            _vkCmdEndRenderPass2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSubpassEndInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndRenderPass2KHR");
            _vkCmdEndTransformFeedbackEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndTransformFeedbackEXT");
            _vkCmdEndVideoCodingKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdEndVideoCodingKHR");
            _vkCmdExecuteCommands_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkCommandBuffer*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdExecuteCommands");
            _vkCmdExecuteGeneratedCommandsEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, VkGeneratedCommandsInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdExecuteGeneratedCommandsEXT");
            _vkCmdExecuteGeneratedCommandsNV_fnptr = (delegate* unmanaged<VkCommandBuffer, int, VkGeneratedCommandsInfoNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdExecuteGeneratedCommandsNV");
            _vkCmdFillBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdFillBuffer");
            _vkCmdInitializeGraphScratchMemoryAMDX_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipeline, ulong, ulong, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdInitializeGraphScratchMemoryAMDX");
            _vkCmdInsertDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdInsertDebugUtilsLabelEXT");
            _vkCmdNextSubpass_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSubpassContents, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdNextSubpass");
            _vkCmdNextSubpass2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdNextSubpass2");
            _vkCmdNextSubpass2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdNextSubpass2KHR");
            _vkCmdOpticalFlowExecuteNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkOpticalFlowSessionNV, VkOpticalFlowExecuteInfoNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdOpticalFlowExecuteNV");
            _vkCmdPipelineBarrier_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits, VkPipelineStageFlagBits, VkDependencyFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPipelineBarrier");
            _vkCmdPipelineBarrier2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDependencyInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPipelineBarrier2");
            _vkCmdPipelineBarrier2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDependencyInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPipelineBarrier2KHR");
            _vkCmdPreprocessGeneratedCommandsEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkGeneratedCommandsInfoEXT*, VkCommandBuffer, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPreprocessGeneratedCommandsEXT");
            _vkCmdPreprocessGeneratedCommandsNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPreprocessGeneratedCommandsNV");
            _vkCmdPushConstants_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineLayout, VkShaderStageFlagBits, uint, uint, void*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPushConstants");
            _vkCmdPushConstants2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPushConstantsInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPushConstants2");
            _vkCmdPushConstants2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPushConstantsInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPushConstants2KHR");
            _vkCmdPushDescriptorSet_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPushDescriptorSet");
            _vkCmdPushDescriptorSet2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPushDescriptorSet2");
            _vkCmdPushDescriptorSet2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPushDescriptorSet2KHR");
            _vkCmdPushDescriptorSetKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPushDescriptorSetKHR");
            _vkCmdPushDescriptorSetWithTemplate_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPushDescriptorSetWithTemplate");
            _vkCmdPushDescriptorSetWithTemplate2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPushDescriptorSetWithTemplate2");
            _vkCmdPushDescriptorSetWithTemplate2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPushDescriptorSetWithTemplate2KHR");
            _vkCmdPushDescriptorSetWithTemplateKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdPushDescriptorSetWithTemplateKHR");
            _vkCmdRefreshObjectsKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRefreshObjectListKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdRefreshObjectsKHR");
            _vkCmdResetEvent_fnptr = (delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdResetEvent");
            _vkCmdResetEvent2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits2, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdResetEvent2");
            _vkCmdResetEvent2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits2, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdResetEvent2KHR");
            _vkCmdResetQueryPool_fnptr = (delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdResetQueryPool");
            _vkCmdResolveImage_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageResolve*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdResolveImage");
            _vkCmdResolveImage2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkResolveImageInfo2*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdResolveImage2");
            _vkCmdResolveImage2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkResolveImageInfo2*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdResolveImage2KHR");
            _vkCmdSetAlphaToCoverageEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetAlphaToCoverageEnableEXT");
            _vkCmdSetAlphaToOneEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetAlphaToOneEnableEXT");
            _vkCmdSetAttachmentFeedbackLoopEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkImageAspectFlagBits, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetAttachmentFeedbackLoopEnableEXT");
            _vkCmdSetBlendConstants_fnptr = (delegate* unmanaged<VkCommandBuffer, float*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetBlendConstants");
            _vkCmdSetCheckpointNV_fnptr = (delegate* unmanaged<VkCommandBuffer, void*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetCheckpointNV");
            _vkCmdSetCoarseSampleOrderNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetCoarseSampleOrderNV");
            _vkCmdSetColorBlendAdvancedEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorBlendAdvancedEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetColorBlendAdvancedEXT");
            _vkCmdSetColorBlendEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, int*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetColorBlendEnableEXT");
            _vkCmdSetColorBlendEquationEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorBlendEquationEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetColorBlendEquationEXT");
            _vkCmdSetColorWriteEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, int*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetColorWriteEnableEXT");
            _vkCmdSetColorWriteMaskEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorComponentFlagBits*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetColorWriteMaskEXT");
            _vkCmdSetConservativeRasterizationModeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkConservativeRasterizationModeEXT, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetConservativeRasterizationModeEXT");
            _vkCmdSetCoverageModulationModeNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCoverageModulationModeNV, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetCoverageModulationModeNV");
            _vkCmdSetCoverageModulationTableEnableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetCoverageModulationTableEnableNV");
            _vkCmdSetCoverageModulationTableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, float*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetCoverageModulationTableNV");
            _vkCmdSetCoverageReductionModeNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCoverageReductionModeNV, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetCoverageReductionModeNV");
            _vkCmdSetCoverageToColorEnableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetCoverageToColorEnableNV");
            _vkCmdSetCoverageToColorLocationNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetCoverageToColorLocationNV");
            _vkCmdSetCullMode_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCullModeFlagBits, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetCullMode");
            _vkCmdSetCullModeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCullModeFlagBits, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetCullModeEXT");
            _vkCmdSetDepthBias_fnptr = (delegate* unmanaged<VkCommandBuffer, float, float, float, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthBias");
            _vkCmdSetDepthBias2EXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDepthBiasInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthBias2EXT");
            _vkCmdSetDepthBiasEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthBiasEnable");
            _vkCmdSetDepthBiasEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthBiasEnableEXT");
            _vkCmdSetDepthBounds_fnptr = (delegate* unmanaged<VkCommandBuffer, float, float, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthBounds");
            _vkCmdSetDepthBoundsTestEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthBoundsTestEnable");
            _vkCmdSetDepthBoundsTestEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthBoundsTestEnableEXT");
            _vkCmdSetDepthClampEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthClampEnableEXT");
            _vkCmdSetDepthClampRangeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDepthClampModeEXT, VkDepthClampRangeEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthClampRangeEXT");
            _vkCmdSetDepthClipEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthClipEnableEXT");
            _vkCmdSetDepthClipNegativeOneToOneEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthClipNegativeOneToOneEXT");
            _vkCmdSetDepthCompareOp_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCompareOp, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthCompareOp");
            _vkCmdSetDepthCompareOpEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCompareOp, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthCompareOpEXT");
            _vkCmdSetDepthTestEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthTestEnable");
            _vkCmdSetDepthTestEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthTestEnableEXT");
            _vkCmdSetDepthWriteEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthWriteEnable");
            _vkCmdSetDepthWriteEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDepthWriteEnableEXT");
            _vkCmdSetDescriptorBufferOffsets2EXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSetDescriptorBufferOffsetsInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDescriptorBufferOffsets2EXT");
            _vkCmdSetDescriptorBufferOffsetsEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, uint*, ulong*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDescriptorBufferOffsetsEXT");
            _vkCmdSetDeviceMask_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDeviceMask");
            _vkCmdSetDeviceMaskKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDeviceMaskKHR");
            _vkCmdSetDiscardRectangleEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDiscardRectangleEnableEXT");
            _vkCmdSetDiscardRectangleEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDiscardRectangleEXT");
            _vkCmdSetDiscardRectangleModeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkDiscardRectangleModeEXT, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetDiscardRectangleModeEXT");
            _vkCmdSetEvent_fnptr = (delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetEvent");
            _vkCmdSetEvent2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkEvent, VkDependencyInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetEvent2");
            _vkCmdSetEvent2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkEvent, VkDependencyInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetEvent2KHR");
            _vkCmdSetExclusiveScissorEnableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, int*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetExclusiveScissorEnableNV");
            _vkCmdSetExclusiveScissorNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetExclusiveScissorNV");
            _vkCmdSetExtraPrimitiveOverestimationSizeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, float, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetExtraPrimitiveOverestimationSizeEXT");
            _vkCmdSetFragmentShadingRateEnumNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkFragmentShadingRateNV, VkFragmentShadingRateCombinerOpKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetFragmentShadingRateEnumNV");
            _vkCmdSetFragmentShadingRateKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkExtent2D*, VkFragmentShadingRateCombinerOpKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetFragmentShadingRateKHR");
            _vkCmdSetFrontFace_fnptr = (delegate* unmanaged<VkCommandBuffer, VkFrontFace, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetFrontFace");
            _vkCmdSetFrontFaceEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkFrontFace, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetFrontFaceEXT");
            _vkCmdSetLineRasterizationModeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkLineRasterizationMode, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetLineRasterizationModeEXT");
            _vkCmdSetLineStipple_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, ushort, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetLineStipple");
            _vkCmdSetLineStippleEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetLineStippleEnableEXT");
            _vkCmdSetLineStippleEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, ushort, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetLineStippleEXT");
            _vkCmdSetLineStippleKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, ushort, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetLineStippleKHR");
            _vkCmdSetLineWidth_fnptr = (delegate* unmanaged<VkCommandBuffer, float, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetLineWidth");
            _vkCmdSetLogicOpEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetLogicOpEnableEXT");
            _vkCmdSetLogicOpEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkLogicOp, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetLogicOpEXT");
            _vkCmdSetPatchControlPointsEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetPatchControlPointsEXT");
            _vkCmdSetPerformanceMarkerINTEL_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetPerformanceMarkerINTEL");
            _vkCmdSetPerformanceOverrideINTEL_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetPerformanceOverrideINTEL");
            _vkCmdSetPerformanceStreamMarkerINTEL_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetPerformanceStreamMarkerINTEL");
            _vkCmdSetPolygonModeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPolygonMode, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetPolygonModeEXT");
            _vkCmdSetPrimitiveRestartEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetPrimitiveRestartEnable");
            _vkCmdSetPrimitiveRestartEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetPrimitiveRestartEnableEXT");
            _vkCmdSetPrimitiveTopology_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPrimitiveTopology, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetPrimitiveTopology");
            _vkCmdSetPrimitiveTopologyEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPrimitiveTopology, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetPrimitiveTopologyEXT");
            _vkCmdSetProvokingVertexModeEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkProvokingVertexModeEXT, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetProvokingVertexModeEXT");
            _vkCmdSetRasterizationSamplesEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSampleCountFlagBits, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetRasterizationSamplesEXT");
            _vkCmdSetRasterizationStreamEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetRasterizationStreamEXT");
            _vkCmdSetRasterizerDiscardEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetRasterizerDiscardEnable");
            _vkCmdSetRasterizerDiscardEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetRasterizerDiscardEnableEXT");
            _vkCmdSetRayTracingPipelineStackSizeKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetRayTracingPipelineStackSizeKHR");
            _vkCmdSetRenderingAttachmentLocations_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderingAttachmentLocationInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetRenderingAttachmentLocations");
            _vkCmdSetRenderingAttachmentLocationsKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderingAttachmentLocationInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetRenderingAttachmentLocationsKHR");
            _vkCmdSetRenderingInputAttachmentIndices_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderingInputAttachmentIndexInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetRenderingInputAttachmentIndices");
            _vkCmdSetRenderingInputAttachmentIndicesKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkRenderingInputAttachmentIndexInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetRenderingInputAttachmentIndicesKHR");
            _vkCmdSetRepresentativeFragmentTestEnableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetRepresentativeFragmentTestEnableNV");
            _vkCmdSetSampleLocationsEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetSampleLocationsEnableEXT");
            _vkCmdSetSampleLocationsEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSampleLocationsInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetSampleLocationsEXT");
            _vkCmdSetSampleMaskEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkSampleCountFlagBits, uint*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetSampleMaskEXT");
            _vkCmdSetScissor_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetScissor");
            _vkCmdSetScissorWithCount_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkRect2D*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetScissorWithCount");
            _vkCmdSetScissorWithCountEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkRect2D*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetScissorWithCountEXT");
            _vkCmdSetShadingRateImageEnableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetShadingRateImageEnableNV");
            _vkCmdSetStencilCompareMask_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetStencilCompareMask");
            _vkCmdSetStencilOp_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetStencilOp");
            _vkCmdSetStencilOpEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetStencilOpEXT");
            _vkCmdSetStencilReference_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetStencilReference");
            _vkCmdSetStencilTestEnable_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetStencilTestEnable");
            _vkCmdSetStencilTestEnableEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetStencilTestEnableEXT");
            _vkCmdSetStencilWriteMask_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetStencilWriteMask");
            _vkCmdSetTessellationDomainOriginEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, VkTessellationDomainOrigin, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetTessellationDomainOriginEXT");
            _vkCmdSetVertexInputEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetVertexInputEXT");
            _vkCmdSetViewport_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewport*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetViewport");
            _vkCmdSetViewportShadingRatePaletteNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetViewportShadingRatePaletteNV");
            _vkCmdSetViewportSwizzleNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewportSwizzleNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetViewportSwizzleNV");
            _vkCmdSetViewportWithCount_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkViewport*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetViewportWithCount");
            _vkCmdSetViewportWithCountEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkViewport*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetViewportWithCountEXT");
            _vkCmdSetViewportWScalingEnableNV_fnptr = (delegate* unmanaged<VkCommandBuffer, int, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetViewportWScalingEnableNV");
            _vkCmdSetViewportWScalingNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewportWScalingNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSetViewportWScalingNV");
            _vkCmdSubpassShadingHUAWEI_fnptr = (delegate* unmanaged<VkCommandBuffer, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdSubpassShadingHUAWEI");
            _vkCmdTraceRaysIndirect2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, ulong, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdTraceRaysIndirect2KHR");
            _vkCmdTraceRaysIndirectKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, ulong, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdTraceRaysIndirectKHR");
            _vkCmdTraceRaysKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdTraceRaysKHR");
            _vkCmdTraceRaysNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, uint, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdTraceRaysNV");
            _vkCmdUpdateBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, void*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdUpdateBuffer");
            _vkCmdUpdatePipelineIndirectBufferNV_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdUpdatePipelineIndirectBufferNV");
            _vkCmdWaitEvents_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkPipelineStageFlagBits, VkPipelineStageFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdWaitEvents");
            _vkCmdWaitEvents2_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdWaitEvents2");
            _vkCmdWaitEvents2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdWaitEvents2KHR");
            _vkCmdWriteAccelerationStructuresPropertiesKHR_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdWriteAccelerationStructuresPropertiesKHR");
            _vkCmdWriteAccelerationStructuresPropertiesNV_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdWriteAccelerationStructuresPropertiesNV");
            _vkCmdWriteBufferMarker2AMD_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits2, VkBuffer, ulong, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdWriteBufferMarker2AMD");
            _vkCmdWriteBufferMarkerAMD_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits, VkBuffer, ulong, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdWriteBufferMarkerAMD");
            _vkCmdWriteMicromapsPropertiesEXT_fnptr = (delegate* unmanaged<VkCommandBuffer, uint, VkMicromapEXT*, VkQueryType, VkQueryPool, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdWriteMicromapsPropertiesEXT");
            _vkCmdWriteTimestamp_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits, VkQueryPool, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdWriteTimestamp");
            _vkCmdWriteTimestamp2_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits2, VkQueryPool, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdWriteTimestamp2");
            _vkCmdWriteTimestamp2KHR_fnptr = (delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits2, VkQueryPool, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkCmdWriteTimestamp2KHR");
            _vkCompileDeferredNV_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, uint, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCompileDeferredNV");
            _vkConvertCooperativeVectorMatrixNV_fnptr = (delegate* unmanaged<VkDevice, VkConvertCooperativeVectorMatrixInfoNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkConvertCooperativeVectorMatrixNV");
            _vkCopyAccelerationStructureKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCopyAccelerationStructureKHR");
            _vkCopyAccelerationStructureToMemoryKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureToMemoryInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCopyAccelerationStructureToMemoryKHR");
            _vkCopyImageToImage_fnptr = (delegate* unmanaged<VkDevice, VkCopyImageToImageInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCopyImageToImage");
            _vkCopyImageToImageEXT_fnptr = (delegate* unmanaged<VkDevice, VkCopyImageToImageInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCopyImageToImageEXT");
            _vkCopyImageToMemory_fnptr = (delegate* unmanaged<VkDevice, VkCopyImageToMemoryInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCopyImageToMemory");
            _vkCopyImageToMemoryEXT_fnptr = (delegate* unmanaged<VkDevice, VkCopyImageToMemoryInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCopyImageToMemoryEXT");
            _vkCopyMemoryToAccelerationStructureKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToAccelerationStructureInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCopyMemoryToAccelerationStructureKHR");
            _vkCopyMemoryToImage_fnptr = (delegate* unmanaged<VkDevice, VkCopyMemoryToImageInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCopyMemoryToImage");
            _vkCopyMemoryToImageEXT_fnptr = (delegate* unmanaged<VkDevice, VkCopyMemoryToImageInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCopyMemoryToImageEXT");
            _vkCopyMemoryToMicromapEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToMicromapInfoEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCopyMemoryToMicromapEXT");
            _vkCopyMicromapEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMicromapInfoEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCopyMicromapEXT");
            _vkCopyMicromapToMemoryEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMicromapToMemoryInfoEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCopyMicromapToMemoryEXT");
            _vkCreateAccelerationStructureKHR_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureCreateInfoKHR*, VkAllocationCallbacks*, VkAccelerationStructureKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateAccelerationStructureKHR");
            _vkCreateAccelerationStructureNV_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureCreateInfoNV*, VkAllocationCallbacks*, VkAccelerationStructureNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateAccelerationStructureNV");
            _vkCreateBuffer_fnptr = (delegate* unmanaged<VkDevice, VkBufferCreateInfo*, VkAllocationCallbacks*, VkBuffer*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateBuffer");
            _vkCreateBufferCollectionFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkBufferCollectionCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkBufferCollectionFUCHSIA*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateBufferCollectionFUCHSIA");
            _vkCreateBufferView_fnptr = (delegate* unmanaged<VkDevice, VkBufferViewCreateInfo*, VkAllocationCallbacks*, VkBufferView*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateBufferView");
            _vkCreateCommandPool_fnptr = (delegate* unmanaged<VkDevice, VkCommandPoolCreateInfo*, VkAllocationCallbacks*, VkCommandPool*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateCommandPool");
            _vkCreateComputePipelines_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateComputePipelines");
            _vkCreateCudaFunctionNV_fnptr = (delegate* unmanaged<VkDevice, VkCudaFunctionCreateInfoNV*, VkAllocationCallbacks*, VkCudaFunctionNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateCudaFunctionNV");
            _vkCreateCudaModuleNV_fnptr = (delegate* unmanaged<VkDevice, VkCudaModuleCreateInfoNV*, VkAllocationCallbacks*, VkCudaModuleNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateCudaModuleNV");
            _vkCreateCuFunctionNVX_fnptr = (delegate* unmanaged<VkDevice, VkCuFunctionCreateInfoNVX*, VkAllocationCallbacks*, VkCuFunctionNVX*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateCuFunctionNVX");
            _vkCreateCuModuleNVX_fnptr = (delegate* unmanaged<VkDevice, VkCuModuleCreateInfoNVX*, VkAllocationCallbacks*, VkCuModuleNVX*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateCuModuleNVX");
            _vkCreateDataGraphPipelinesARM_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkDataGraphPipelineCreateInfoARM*, VkAllocationCallbacks*, VkPipeline*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateDataGraphPipelinesARM");
            _vkCreateDataGraphPipelineSessionARM_fnptr = (delegate* unmanaged<VkDevice, VkDataGraphPipelineSessionCreateInfoARM*, VkAllocationCallbacks*, VkDataGraphPipelineSessionARM*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateDataGraphPipelineSessionARM");
            _vkCreateDeferredOperationKHR_fnptr = (delegate* unmanaged<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateDeferredOperationKHR");
            _vkCreateDescriptorPool_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorPoolCreateInfo*, VkAllocationCallbacks*, VkDescriptorPool*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateDescriptorPool");
            _vkCreateDescriptorSetLayout_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkAllocationCallbacks*, VkDescriptorSetLayout*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateDescriptorSetLayout");
            _vkCreateDescriptorUpdateTemplate_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateDescriptorUpdateTemplate");
            _vkCreateDescriptorUpdateTemplateKHR_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateDescriptorUpdateTemplateKHR");
            _vkCreateEvent_fnptr = (delegate* unmanaged<VkDevice, VkEventCreateInfo*, VkAllocationCallbacks*, VkEvent*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateEvent");
            _vkCreateExecutionGraphPipelinesAMDX_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkExecutionGraphPipelineCreateInfoAMDX*, VkAllocationCallbacks*, VkPipeline*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateExecutionGraphPipelinesAMDX");
            _vkCreateExternalComputeQueueNV_fnptr = (delegate* unmanaged<VkDevice, VkExternalComputeQueueCreateInfoNV*, VkAllocationCallbacks*, VkExternalComputeQueueNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateExternalComputeQueueNV");
            _vkCreateFence_fnptr = (delegate* unmanaged<VkDevice, VkFenceCreateInfo*, VkAllocationCallbacks*, VkFence*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateFence");
            _vkCreateFramebuffer_fnptr = (delegate* unmanaged<VkDevice, VkFramebufferCreateInfo*, VkAllocationCallbacks*, VkFramebuffer*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateFramebuffer");
            _vkCreateGraphicsPipelines_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkGraphicsPipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateGraphicsPipelines");
            _vkCreateImage_fnptr = (delegate* unmanaged<VkDevice, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateImage");
            _vkCreateImageView_fnptr = (delegate* unmanaged<VkDevice, VkImageViewCreateInfo*, VkAllocationCallbacks*, VkImageView*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateImageView");
            _vkCreateIndirectCommandsLayoutEXT_fnptr = (delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutCreateInfoEXT*, VkAllocationCallbacks*, VkIndirectCommandsLayoutEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateIndirectCommandsLayoutEXT");
            _vkCreateIndirectCommandsLayoutNV_fnptr = (delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutCreateInfoNV*, VkAllocationCallbacks*, VkIndirectCommandsLayoutNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateIndirectCommandsLayoutNV");
            _vkCreateIndirectExecutionSetEXT_fnptr = (delegate* unmanaged<VkDevice, VkIndirectExecutionSetCreateInfoEXT*, VkAllocationCallbacks*, VkIndirectExecutionSetEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateIndirectExecutionSetEXT");
            _vkCreateMicromapEXT_fnptr = (delegate* unmanaged<VkDevice, VkMicromapCreateInfoEXT*, VkAllocationCallbacks*, VkMicromapEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateMicromapEXT");
            _vkCreateOpticalFlowSessionNV_fnptr = (delegate* unmanaged<VkDevice, VkOpticalFlowSessionCreateInfoNV*, VkAllocationCallbacks*, VkOpticalFlowSessionNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateOpticalFlowSessionNV");
            _vkCreatePipelineBinariesKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineBinaryCreateInfoKHR*, VkAllocationCallbacks*, VkPipelineBinaryHandlesInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreatePipelineBinariesKHR");
            _vkCreatePipelineCache_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCacheCreateInfo*, VkAllocationCallbacks*, VkPipelineCache*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreatePipelineCache");
            _vkCreatePipelineLayout_fnptr = (delegate* unmanaged<VkDevice, VkPipelineLayoutCreateInfo*, VkAllocationCallbacks*, VkPipelineLayout*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreatePipelineLayout");
            _vkCreatePrivateDataSlot_fnptr = (delegate* unmanaged<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreatePrivateDataSlot");
            _vkCreatePrivateDataSlotEXT_fnptr = (delegate* unmanaged<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreatePrivateDataSlotEXT");
            _vkCreateQueryPool_fnptr = (delegate* unmanaged<VkDevice, VkQueryPoolCreateInfo*, VkAllocationCallbacks*, VkQueryPool*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateQueryPool");
            _vkCreateRayTracingPipelinesKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, VkAllocationCallbacks*, VkPipeline*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateRayTracingPipelinesKHR");
            _vkCreateRayTracingPipelinesNV_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, VkAllocationCallbacks*, VkPipeline*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateRayTracingPipelinesNV");
            _vkCreateRenderPass_fnptr = (delegate* unmanaged<VkDevice, VkRenderPassCreateInfo*, VkAllocationCallbacks*, VkRenderPass*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateRenderPass");
            _vkCreateRenderPass2_fnptr = (delegate* unmanaged<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateRenderPass2");
            _vkCreateRenderPass2KHR_fnptr = (delegate* unmanaged<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateRenderPass2KHR");
            _vkCreateSampler_fnptr = (delegate* unmanaged<VkDevice, VkSamplerCreateInfo*, VkAllocationCallbacks*, VkSampler*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateSampler");
            _vkCreateSamplerYcbcrConversion_fnptr = (delegate* unmanaged<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateSamplerYcbcrConversion");
            _vkCreateSamplerYcbcrConversionKHR_fnptr = (delegate* unmanaged<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateSamplerYcbcrConversionKHR");
            _vkCreateSemaphore_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreCreateInfo*, VkAllocationCallbacks*, VkSemaphore*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateSemaphore");
            _vkCreateSemaphoreSciSyncPoolNV_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreSciSyncPoolCreateInfoNV*, VkAllocationCallbacks*, VkSemaphoreSciSyncPoolNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateSemaphoreSciSyncPoolNV");
            _vkCreateShaderModule_fnptr = (delegate* unmanaged<VkDevice, VkShaderModuleCreateInfo*, VkAllocationCallbacks*, VkShaderModule*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateShaderModule");
            _vkCreateShadersEXT_fnptr = (delegate* unmanaged<VkDevice, uint, VkShaderCreateInfoEXT*, VkAllocationCallbacks*, VkShaderEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateShadersEXT");
            _vkCreateSharedSwapchainsKHR_fnptr = (delegate* unmanaged<VkDevice, uint, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateSharedSwapchainsKHR");
            _vkCreateSwapchainKHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateSwapchainKHR");
            _vkCreateTensorARM_fnptr = (delegate* unmanaged<VkDevice, VkTensorCreateInfoARM*, VkAllocationCallbacks*, VkTensorARM*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateTensorARM");
            _vkCreateTensorViewARM_fnptr = (delegate* unmanaged<VkDevice, VkTensorViewCreateInfoARM*, VkAllocationCallbacks*, VkTensorViewARM*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateTensorViewARM");
            _vkCreateValidationCacheEXT_fnptr = (delegate* unmanaged<VkDevice, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, VkValidationCacheEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateValidationCacheEXT");
            _vkCreateVideoSessionKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateVideoSessionKHR");
            _vkCreateVideoSessionParametersKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionParametersCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionParametersKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkCreateVideoSessionParametersKHR");
            _vkDebugMarkerSetObjectNameEXT_fnptr = (delegate* unmanaged<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkDebugMarkerSetObjectNameEXT");
            _vkDebugMarkerSetObjectTagEXT_fnptr = (delegate* unmanaged<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkDebugMarkerSetObjectTagEXT");
            _vkDeferredOperationJoinKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkDeferredOperationJoinKHR");
            _vkDestroyAccelerationStructureKHR_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyAccelerationStructureKHR");
            _vkDestroyAccelerationStructureNV_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyAccelerationStructureNV");
            _vkDestroyBuffer_fnptr = (delegate* unmanaged<VkDevice, VkBuffer, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyBuffer");
            _vkDestroyBufferCollectionFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyBufferCollectionFUCHSIA");
            _vkDestroyBufferView_fnptr = (delegate* unmanaged<VkDevice, VkBufferView, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyBufferView");
            _vkDestroyCommandPool_fnptr = (delegate* unmanaged<VkDevice, VkCommandPool, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyCommandPool");
            _vkDestroyCudaFunctionNV_fnptr = (delegate* unmanaged<VkDevice, VkCudaFunctionNV, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyCudaFunctionNV");
            _vkDestroyCudaModuleNV_fnptr = (delegate* unmanaged<VkDevice, VkCudaModuleNV, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyCudaModuleNV");
            _vkDestroyCuFunctionNVX_fnptr = (delegate* unmanaged<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyCuFunctionNVX");
            _vkDestroyCuModuleNVX_fnptr = (delegate* unmanaged<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyCuModuleNVX");
            _vkDestroyDataGraphPipelineSessionARM_fnptr = (delegate* unmanaged<VkDevice, VkDataGraphPipelineSessionARM, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyDataGraphPipelineSessionARM");
            _vkDestroyDeferredOperationKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyDeferredOperationKHR");
            _vkDestroyDescriptorPool_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyDescriptorPool");
            _vkDestroyDescriptorSetLayout_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyDescriptorSetLayout");
            _vkDestroyDescriptorUpdateTemplate_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyDescriptorUpdateTemplate");
            _vkDestroyDescriptorUpdateTemplateKHR_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyDescriptorUpdateTemplateKHR");
            _vkDestroyDevice_fnptr = (delegate* unmanaged<VkDevice, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyDevice");
            _vkDestroyEvent_fnptr = (delegate* unmanaged<VkDevice, VkEvent, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyEvent");
            _vkDestroyExternalComputeQueueNV_fnptr = (delegate* unmanaged<VkDevice, VkExternalComputeQueueNV, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyExternalComputeQueueNV");
            _vkDestroyFence_fnptr = (delegate* unmanaged<VkDevice, VkFence, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyFence");
            _vkDestroyFramebuffer_fnptr = (delegate* unmanaged<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyFramebuffer");
            _vkDestroyImage_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyImage");
            _vkDestroyImageView_fnptr = (delegate* unmanaged<VkDevice, VkImageView, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyImageView");
            _vkDestroyIndirectCommandsLayoutEXT_fnptr = (delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutEXT, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyIndirectCommandsLayoutEXT");
            _vkDestroyIndirectCommandsLayoutNV_fnptr = (delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyIndirectCommandsLayoutNV");
            _vkDestroyIndirectExecutionSetEXT_fnptr = (delegate* unmanaged<VkDevice, VkIndirectExecutionSetEXT, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyIndirectExecutionSetEXT");
            _vkDestroyMicromapEXT_fnptr = (delegate* unmanaged<VkDevice, VkMicromapEXT, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyMicromapEXT");
            _vkDestroyOpticalFlowSessionNV_fnptr = (delegate* unmanaged<VkDevice, VkOpticalFlowSessionNV, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyOpticalFlowSessionNV");
            _vkDestroyPipeline_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyPipeline");
            _vkDestroyPipelineBinaryKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineBinaryKHR, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyPipelineBinaryKHR");
            _vkDestroyPipelineCache_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyPipelineCache");
            _vkDestroyPipelineLayout_fnptr = (delegate* unmanaged<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyPipelineLayout");
            _vkDestroyPrivateDataSlot_fnptr = (delegate* unmanaged<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyPrivateDataSlot");
            _vkDestroyPrivateDataSlotEXT_fnptr = (delegate* unmanaged<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyPrivateDataSlotEXT");
            _vkDestroyQueryPool_fnptr = (delegate* unmanaged<VkDevice, VkQueryPool, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyQueryPool");
            _vkDestroyRenderPass_fnptr = (delegate* unmanaged<VkDevice, VkRenderPass, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyRenderPass");
            _vkDestroySampler_fnptr = (delegate* unmanaged<VkDevice, VkSampler, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroySampler");
            _vkDestroySamplerYcbcrConversion_fnptr = (delegate* unmanaged<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroySamplerYcbcrConversion");
            _vkDestroySamplerYcbcrConversionKHR_fnptr = (delegate* unmanaged<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroySamplerYcbcrConversionKHR");
            _vkDestroySemaphore_fnptr = (delegate* unmanaged<VkDevice, VkSemaphore, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroySemaphore");
            _vkDestroySemaphoreSciSyncPoolNV_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreSciSyncPoolNV, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroySemaphoreSciSyncPoolNV");
            _vkDestroyShaderEXT_fnptr = (delegate* unmanaged<VkDevice, VkShaderEXT, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyShaderEXT");
            _vkDestroyShaderModule_fnptr = (delegate* unmanaged<VkDevice, VkShaderModule, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyShaderModule");
            _vkDestroySwapchainKHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroySwapchainKHR");
            _vkDestroyTensorARM_fnptr = (delegate* unmanaged<VkDevice, VkTensorARM, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyTensorARM");
            _vkDestroyTensorViewARM_fnptr = (delegate* unmanaged<VkDevice, VkTensorViewARM, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyTensorViewARM");
            _vkDestroyValidationCacheEXT_fnptr = (delegate* unmanaged<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyValidationCacheEXT");
            _vkDestroyVideoSessionKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyVideoSessionKHR");
            _vkDestroyVideoSessionParametersKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkDestroyVideoSessionParametersKHR");
            _vkDeviceWaitIdle_fnptr = (delegate* unmanaged<VkDevice, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkDeviceWaitIdle");
            _vkDisplayPowerControlEXT_fnptr = (delegate* unmanaged<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkDisplayPowerControlEXT");
            _vkEndCommandBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkEndCommandBuffer");
            _vkExportMetalObjectsEXT_fnptr = (delegate* unmanaged<VkDevice, VkExportMetalObjectsInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkExportMetalObjectsEXT");
            _vkFlushMappedMemoryRanges_fnptr = (delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkFlushMappedMemoryRanges");
            _vkFreeCommandBuffers_fnptr = (delegate* unmanaged<VkDevice, VkCommandPool, uint, VkCommandBuffer*, void>)VKLoader.GetDeviceProcAddr(device, "vkFreeCommandBuffers");
            _vkFreeDescriptorSets_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorPool, uint, VkDescriptorSet*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkFreeDescriptorSets");
            _vkFreeMemory_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void>)VKLoader.GetDeviceProcAddr(device, "vkFreeMemory");
            _vkGetAccelerationStructureBuildSizesKHR_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureBuildTypeKHR, VkAccelerationStructureBuildGeometryInfoKHR*, uint*, VkAccelerationStructureBuildSizesInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetAccelerationStructureBuildSizesKHR");
            _vkGetAccelerationStructureDeviceAddressKHR_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, ulong>)VKLoader.GetDeviceProcAddr(device, "vkGetAccelerationStructureDeviceAddressKHR");
            _vkGetAccelerationStructureHandleNV_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetAccelerationStructureHandleNV");
            _vkGetAccelerationStructureMemoryRequirementsNV_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetAccelerationStructureMemoryRequirementsNV");
            _vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureCaptureDescriptorDataInfoEXT*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT");
            _vkGetAndroidHardwareBufferPropertiesANDROID_fnptr = (delegate* unmanaged<VkDevice, IntPtr, VkAndroidHardwareBufferPropertiesANDROID*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetAndroidHardwareBufferPropertiesANDROID");
            _vkGetBufferCollectionPropertiesFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkBufferCollectionPropertiesFUCHSIA*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetBufferCollectionPropertiesFUCHSIA");
            _vkGetBufferDeviceAddress_fnptr = (delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong>)VKLoader.GetDeviceProcAddr(device, "vkGetBufferDeviceAddress");
            _vkGetBufferDeviceAddressEXT_fnptr = (delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong>)VKLoader.GetDeviceProcAddr(device, "vkGetBufferDeviceAddressEXT");
            _vkGetBufferDeviceAddressKHR_fnptr = (delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong>)VKLoader.GetDeviceProcAddr(device, "vkGetBufferDeviceAddressKHR");
            _vkGetBufferMemoryRequirements_fnptr = (delegate* unmanaged<VkDevice, VkBuffer, VkMemoryRequirements*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetBufferMemoryRequirements");
            _vkGetBufferMemoryRequirements2_fnptr = (delegate* unmanaged<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetBufferMemoryRequirements2");
            _vkGetBufferMemoryRequirements2KHR_fnptr = (delegate* unmanaged<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetBufferMemoryRequirements2KHR");
            _vkGetBufferOpaqueCaptureAddress_fnptr = (delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong>)VKLoader.GetDeviceProcAddr(device, "vkGetBufferOpaqueCaptureAddress");
            _vkGetBufferOpaqueCaptureAddressKHR_fnptr = (delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong>)VKLoader.GetDeviceProcAddr(device, "vkGetBufferOpaqueCaptureAddressKHR");
            _vkGetBufferOpaqueCaptureDescriptorDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkBufferCaptureDescriptorDataInfoEXT*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetBufferOpaqueCaptureDescriptorDataEXT");
            _vkGetCalibratedTimestampsEXT_fnptr = (delegate* unmanaged<VkDevice, uint, VkCalibratedTimestampInfoKHR*, ulong*, ulong*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetCalibratedTimestampsEXT");
            _vkGetCalibratedTimestampsKHR_fnptr = (delegate* unmanaged<VkDevice, uint, VkCalibratedTimestampInfoKHR*, ulong*, ulong*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetCalibratedTimestampsKHR");
            _vkGetClusterAccelerationStructureBuildSizesNV_fnptr = (delegate* unmanaged<VkDevice, VkClusterAccelerationStructureInputInfoNV*, VkAccelerationStructureBuildSizesInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetClusterAccelerationStructureBuildSizesNV");
            _vkGetCommandPoolMemoryConsumption_fnptr = (delegate* unmanaged<VkDevice, VkCommandPool, VkCommandBuffer, VkCommandPoolMemoryConsumption*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetCommandPoolMemoryConsumption");
            _vkGetCudaModuleCacheNV_fnptr = (delegate* unmanaged<VkDevice, VkCudaModuleNV, nuint*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetCudaModuleCacheNV");
            _vkGetDataGraphPipelineAvailablePropertiesARM_fnptr = (delegate* unmanaged<VkDevice, VkDataGraphPipelineInfoARM*, uint*, VkDataGraphPipelinePropertyARM*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetDataGraphPipelineAvailablePropertiesARM");
            _vkGetDataGraphPipelinePropertiesARM_fnptr = (delegate* unmanaged<VkDevice, VkDataGraphPipelineInfoARM*, uint, VkDataGraphPipelinePropertyQueryResultARM*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetDataGraphPipelinePropertiesARM");
            _vkGetDataGraphPipelineSessionBindPointRequirementsARM_fnptr = (delegate* unmanaged<VkDevice, VkDataGraphPipelineSessionBindPointRequirementsInfoARM*, uint*, VkDataGraphPipelineSessionBindPointRequirementARM*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetDataGraphPipelineSessionBindPointRequirementsARM");
            _vkGetDataGraphPipelineSessionMemoryRequirementsARM_fnptr = (delegate* unmanaged<VkDevice, VkDataGraphPipelineSessionMemoryRequirementsInfoARM*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDataGraphPipelineSessionMemoryRequirementsARM");
            _vkGetDeferredOperationMaxConcurrencyKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint>)VKLoader.GetDeviceProcAddr(device, "vkGetDeferredOperationMaxConcurrencyKHR");
            _vkGetDeferredOperationResultKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetDeferredOperationResultKHR");
            _vkGetDescriptorEXT_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorGetInfoEXT*, nuint, void*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDescriptorEXT");
            _vkGetDescriptorSetHostMappingVALVE_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSet, void**, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDescriptorSetHostMappingVALVE");
            _vkGetDescriptorSetLayoutBindingOffsetEXT_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetLayout, uint, ulong*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDescriptorSetLayoutBindingOffsetEXT");
            _vkGetDescriptorSetLayoutHostMappingInfoVALVE_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetBindingReferenceVALVE*, VkDescriptorSetLayoutHostMappingInfoVALVE*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDescriptorSetLayoutHostMappingInfoVALVE");
            _vkGetDescriptorSetLayoutSizeEXT_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetLayout, ulong*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDescriptorSetLayoutSizeEXT");
            _vkGetDescriptorSetLayoutSupport_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDescriptorSetLayoutSupport");
            _vkGetDescriptorSetLayoutSupportKHR_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDescriptorSetLayoutSupportKHR");
            _vkGetDeviceAccelerationStructureCompatibilityKHR_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureVersionInfoKHR*, VkAccelerationStructureCompatibilityKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceAccelerationStructureCompatibilityKHR");
            _vkGetDeviceBufferMemoryRequirements_fnptr = (delegate* unmanaged<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceBufferMemoryRequirements");
            _vkGetDeviceBufferMemoryRequirementsKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceBufferMemoryRequirementsKHR");
            _vkGetDeviceFaultInfoEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceFaultInfoEXT");
            _vkGetDeviceGroupPeerMemoryFeatures_fnptr = (delegate* unmanaged<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlagBits*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceGroupPeerMemoryFeatures");
            _vkGetDeviceGroupPeerMemoryFeaturesKHR_fnptr = (delegate* unmanaged<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlagBits*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceGroupPeerMemoryFeaturesKHR");
            _vkGetDeviceGroupPresentCapabilitiesKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceGroupPresentCapabilitiesKHR");
            _vkGetDeviceGroupSurfacePresentModes2EXT_fnptr = (delegate* unmanaged<VkDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkDeviceGroupPresentModeFlagBitsKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceGroupSurfacePresentModes2EXT");
            _vkGetDeviceGroupSurfacePresentModesKHR_fnptr = (delegate* unmanaged<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagBitsKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceGroupSurfacePresentModesKHR");
            _vkGetDeviceImageMemoryRequirements_fnptr = (delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceImageMemoryRequirements");
            _vkGetDeviceImageMemoryRequirementsKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceImageMemoryRequirementsKHR");
            _vkGetDeviceImageSparseMemoryRequirements_fnptr = (delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceImageSparseMemoryRequirements");
            _vkGetDeviceImageSparseMemoryRequirementsKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceImageSparseMemoryRequirementsKHR");
            _vkGetDeviceImageSubresourceLayout_fnptr = (delegate* unmanaged<VkDevice, VkDeviceImageSubresourceInfo*, VkSubresourceLayout2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceImageSubresourceLayout");
            _vkGetDeviceImageSubresourceLayoutKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeviceImageSubresourceInfo*, VkSubresourceLayout2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceImageSubresourceLayoutKHR");
            _vkGetDeviceMemoryCommitment_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemory, ulong*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceMemoryCommitment");
            _vkGetDeviceMemoryOpaqueCaptureAddress_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceMemoryOpaqueCaptureAddress");
            _vkGetDeviceMemoryOpaqueCaptureAddressKHR_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceMemoryOpaqueCaptureAddressKHR");
            _vkGetDeviceMicromapCompatibilityEXT_fnptr = (delegate* unmanaged<VkDevice, VkMicromapVersionInfoEXT*, VkAccelerationStructureCompatibilityKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceMicromapCompatibilityEXT");
            _vkGetDeviceProcAddr_fnptr = (delegate* unmanaged<VkDevice, byte*, IntPtr>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceProcAddr");
            _vkGetDeviceQueue_fnptr = (delegate* unmanaged<VkDevice, uint, uint, VkQueue*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceQueue");
            _vkGetDeviceQueue2_fnptr = (delegate* unmanaged<VkDevice, VkDeviceQueueInfo2*, VkQueue*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceQueue2");
            _vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_fnptr = (delegate* unmanaged<VkDevice, VkRenderPass, VkExtent2D*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI");
            _vkGetDeviceTensorMemoryRequirementsARM_fnptr = (delegate* unmanaged<VkDevice, VkDeviceTensorMemoryRequirementsARM*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetDeviceTensorMemoryRequirementsARM");
            _vkGetDynamicRenderingTilePropertiesQCOM_fnptr = (delegate* unmanaged<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetDynamicRenderingTilePropertiesQCOM");
            _vkGetEncodedVideoSessionParametersKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoEncodeSessionParametersGetInfoKHR*, VkVideoEncodeSessionParametersFeedbackInfoKHR*, nuint*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetEncodedVideoSessionParametersKHR");
            _vkGetEventStatus_fnptr = (delegate* unmanaged<VkDevice, VkEvent, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetEventStatus");
            _vkGetExecutionGraphPipelineNodeIndexAMDX_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, VkPipelineShaderStageNodeCreateInfoAMDX*, uint*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetExecutionGraphPipelineNodeIndexAMDX");
            _vkGetExecutionGraphPipelineScratchSizeAMDX_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, VkExecutionGraphPipelineScratchSizeAMDX*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetExecutionGraphPipelineScratchSizeAMDX");
            _vkGetExternalComputeQueueDataNV_fnptr = (delegate* unmanaged<VkExternalComputeQueueNV, VkExternalComputeQueueDataParamsNV*, void*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetExternalComputeQueueDataNV");
            _vkGetFaultData_fnptr = (delegate* unmanaged<VkDevice, VkFaultQueryBehavior, int*, uint*, VkFaultData*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetFaultData");
            _vkGetFenceFdKHR_fnptr = (delegate* unmanaged<VkDevice, VkFenceGetFdInfoKHR*, int*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetFenceFdKHR");
            _vkGetFenceSciSyncFenceNV_fnptr = (delegate* unmanaged<VkDevice, VkFenceGetSciSyncInfoNV*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetFenceSciSyncFenceNV");
            _vkGetFenceSciSyncObjNV_fnptr = (delegate* unmanaged<VkDevice, VkFenceGetSciSyncInfoNV*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetFenceSciSyncObjNV");
            _vkGetFenceStatus_fnptr = (delegate* unmanaged<VkDevice, VkFence, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetFenceStatus");
            _vkGetFenceWin32HandleKHR_fnptr = (delegate* unmanaged<VkDevice, VkFenceGetWin32HandleInfoKHR*, IntPtr*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetFenceWin32HandleKHR");
            _vkGetFramebufferTilePropertiesQCOM_fnptr = (delegate* unmanaged<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetFramebufferTilePropertiesQCOM");
            _vkGetGeneratedCommandsMemoryRequirementsEXT_fnptr = (delegate* unmanaged<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoEXT*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetGeneratedCommandsMemoryRequirementsEXT");
            _vkGetGeneratedCommandsMemoryRequirementsNV_fnptr = (delegate* unmanaged<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetGeneratedCommandsMemoryRequirementsNV");
            _vkGetImageDrmFormatModifierPropertiesEXT_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetImageDrmFormatModifierPropertiesEXT");
            _vkGetImageMemoryRequirements_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkMemoryRequirements*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetImageMemoryRequirements");
            _vkGetImageMemoryRequirements2_fnptr = (delegate* unmanaged<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetImageMemoryRequirements2");
            _vkGetImageMemoryRequirements2KHR_fnptr = (delegate* unmanaged<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetImageMemoryRequirements2KHR");
            _vkGetImageOpaqueCaptureDescriptorDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkImageCaptureDescriptorDataInfoEXT*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetImageOpaqueCaptureDescriptorDataEXT");
            _vkGetImageSparseMemoryRequirements_fnptr = (delegate* unmanaged<VkDevice, VkImage, uint*, VkSparseImageMemoryRequirements*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetImageSparseMemoryRequirements");
            _vkGetImageSparseMemoryRequirements2_fnptr = (delegate* unmanaged<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetImageSparseMemoryRequirements2");
            _vkGetImageSparseMemoryRequirements2KHR_fnptr = (delegate* unmanaged<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetImageSparseMemoryRequirements2KHR");
            _vkGetImageSubresourceLayout_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkImageSubresource*, VkSubresourceLayout*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetImageSubresourceLayout");
            _vkGetImageSubresourceLayout2_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetImageSubresourceLayout2");
            _vkGetImageSubresourceLayout2EXT_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetImageSubresourceLayout2EXT");
            _vkGetImageSubresourceLayout2KHR_fnptr = (delegate* unmanaged<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetImageSubresourceLayout2KHR");
            _vkGetImageViewAddressNVX_fnptr = (delegate* unmanaged<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetImageViewAddressNVX");
            _vkGetImageViewHandle64NVX_fnptr = (delegate* unmanaged<VkDevice, VkImageViewHandleInfoNVX*, ulong>)VKLoader.GetDeviceProcAddr(device, "vkGetImageViewHandle64NVX");
            _vkGetImageViewHandleNVX_fnptr = (delegate* unmanaged<VkDevice, VkImageViewHandleInfoNVX*, uint>)VKLoader.GetDeviceProcAddr(device, "vkGetImageViewHandleNVX");
            _vkGetImageViewOpaqueCaptureDescriptorDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkImageViewCaptureDescriptorDataInfoEXT*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetImageViewOpaqueCaptureDescriptorDataEXT");
            _vkGetLatencyTimingsNV_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkGetLatencyMarkerInfoNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetLatencyTimingsNV");
            _vkGetMemoryAndroidHardwareBufferANDROID_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, IntPtr*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryAndroidHardwareBufferANDROID");
            _vkGetMemoryFdKHR_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetFdInfoKHR*, int*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryFdKHR");
            _vkGetMemoryFdPropertiesKHR_fnptr = (delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, int, VkMemoryFdPropertiesKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryFdPropertiesKHR");
            _vkGetMemoryHostPointerPropertiesEXT_fnptr = (delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, void*, VkMemoryHostPointerPropertiesEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryHostPointerPropertiesEXT");
            _vkGetMemoryMetalHandleEXT_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetMetalHandleInfoEXT*, void**, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryMetalHandleEXT");
            _vkGetMemoryMetalHandlePropertiesEXT_fnptr = (delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, void*, VkMemoryMetalHandlePropertiesEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryMetalHandlePropertiesEXT");
            _vkGetMemoryNativeBufferOHOS_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetNativeBufferInfoOHOS*, IntPtr*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryNativeBufferOHOS");
            _vkGetMemoryRemoteAddressNV_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetRemoteAddressInfoNV*, void**, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryRemoteAddressNV");
            _vkGetMemorySciBufNV_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetSciBufInfoNV*, IntPtr*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemorySciBufNV");
            _vkGetMemoryWin32HandleKHR_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetWin32HandleInfoKHR*, IntPtr*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryWin32HandleKHR");
            _vkGetMemoryWin32HandleNV_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemory, VkExternalMemoryHandleTypeFlagBitsNV, IntPtr*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryWin32HandleNV");
            _vkGetMemoryWin32HandlePropertiesKHR_fnptr = (delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, IntPtr, VkMemoryWin32HandlePropertiesKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryWin32HandlePropertiesKHR");
            _vkGetMemoryZirconHandleFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, int*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryZirconHandleFUCHSIA");
            _vkGetMemoryZirconHandlePropertiesFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, int, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetMemoryZirconHandlePropertiesFUCHSIA");
            _vkGetMicromapBuildSizesEXT_fnptr = (delegate* unmanaged<VkDevice, VkAccelerationStructureBuildTypeKHR, VkMicromapBuildInfoEXT*, VkMicromapBuildSizesInfoEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetMicromapBuildSizesEXT");
            _vkGetNativeBufferPropertiesOHOS_fnptr = (delegate* unmanaged<VkDevice, IntPtr, VkNativeBufferPropertiesOHOS*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetNativeBufferPropertiesOHOS");
            _vkGetPartitionedAccelerationStructuresBuildSizesNV_fnptr = (delegate* unmanaged<VkDevice, VkPartitionedAccelerationStructureInstancesInputNV*, VkAccelerationStructureBuildSizesInfoKHR*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetPartitionedAccelerationStructuresBuildSizesNV");
            _vkGetPastPresentationTimingEXT_fnptr = (delegate* unmanaged<VkDevice, VkPastPresentationTimingInfoEXT*, VkPastPresentationTimingPropertiesEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetPastPresentationTimingEXT");
            _vkGetPastPresentationTimingGOOGLE_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, uint*, VkPastPresentationTimingGOOGLE*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetPastPresentationTimingGOOGLE");
            _vkGetPerformanceParameterINTEL_fnptr = (delegate* unmanaged<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetPerformanceParameterINTEL");
            _vkGetPipelineBinaryDataKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineBinaryDataInfoKHR*, VkPipelineBinaryKeyKHR*, nuint*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetPipelineBinaryDataKHR");
            _vkGetPipelineCacheData_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, nuint*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetPipelineCacheData");
            _vkGetPipelineExecutableInternalRepresentationsKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableInternalRepresentationKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetPipelineExecutableInternalRepresentationsKHR");
            _vkGetPipelineExecutablePropertiesKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineInfoKHR*, uint*, VkPipelineExecutablePropertiesKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetPipelineExecutablePropertiesKHR");
            _vkGetPipelineExecutableStatisticsKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableStatisticKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetPipelineExecutableStatisticsKHR");
            _vkGetPipelineIndirectDeviceAddressNV_fnptr = (delegate* unmanaged<VkDevice, VkPipelineIndirectDeviceAddressInfoNV*, ulong>)VKLoader.GetDeviceProcAddr(device, "vkGetPipelineIndirectDeviceAddressNV");
            _vkGetPipelineIndirectMemoryRequirementsNV_fnptr = (delegate* unmanaged<VkDevice, VkComputePipelineCreateInfo*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetPipelineIndirectMemoryRequirementsNV");
            _vkGetPipelineKeyKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCreateInfoKHR*, VkPipelineBinaryKeyKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetPipelineKeyKHR");
            _vkGetPipelinePropertiesEXT_fnptr = (delegate* unmanaged<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetPipelinePropertiesEXT");
            _vkGetPrivateData_fnptr = (delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetPrivateData");
            _vkGetPrivateDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetPrivateDataEXT");
            _vkGetQueryPoolResults_fnptr = (delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, nuint, void*, ulong, VkQueryResultFlagBits, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetQueryPoolResults");
            _vkGetQueueCheckpointData2NV_fnptr = (delegate* unmanaged<VkQueue, uint*, VkCheckpointData2NV*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetQueueCheckpointData2NV");
            _vkGetQueueCheckpointDataNV_fnptr = (delegate* unmanaged<VkQueue, uint*, VkCheckpointDataNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetQueueCheckpointDataNV");
            _vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR");
            _vkGetRayTracingShaderGroupHandlesKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetRayTracingShaderGroupHandlesKHR");
            _vkGetRayTracingShaderGroupHandlesNV_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetRayTracingShaderGroupHandlesNV");
            _vkGetRayTracingShaderGroupStackSizeKHR_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, uint, VkShaderGroupShaderKHR, ulong>)VKLoader.GetDeviceProcAddr(device, "vkGetRayTracingShaderGroupStackSizeKHR");
            _vkGetRefreshCycleDurationGOOGLE_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetRefreshCycleDurationGOOGLE");
            _vkGetRenderAreaGranularity_fnptr = (delegate* unmanaged<VkDevice, VkRenderPass, VkExtent2D*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetRenderAreaGranularity");
            _vkGetRenderingAreaGranularity_fnptr = (delegate* unmanaged<VkDevice, VkRenderingAreaInfo*, VkExtent2D*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetRenderingAreaGranularity");
            _vkGetRenderingAreaGranularityKHR_fnptr = (delegate* unmanaged<VkDevice, VkRenderingAreaInfo*, VkExtent2D*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetRenderingAreaGranularityKHR");
            _vkGetSamplerOpaqueCaptureDescriptorDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkSamplerCaptureDescriptorDataInfoEXT*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSamplerOpaqueCaptureDescriptorDataEXT");
            _vkGetScreenBufferPropertiesQNX_fnptr = (delegate* unmanaged<VkDevice, IntPtr*, VkScreenBufferPropertiesQNX*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetScreenBufferPropertiesQNX");
            _vkGetSemaphoreCounterValue_fnptr = (delegate* unmanaged<VkDevice, VkSemaphore, ulong*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSemaphoreCounterValue");
            _vkGetSemaphoreCounterValueKHR_fnptr = (delegate* unmanaged<VkDevice, VkSemaphore, ulong*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSemaphoreCounterValueKHR");
            _vkGetSemaphoreFdKHR_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreGetFdInfoKHR*, int*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSemaphoreFdKHR");
            _vkGetSemaphoreSciSyncObjNV_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreGetSciSyncInfoNV*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSemaphoreSciSyncObjNV");
            _vkGetSemaphoreWin32HandleKHR_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, IntPtr*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSemaphoreWin32HandleKHR");
            _vkGetSemaphoreZirconHandleFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, int*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSemaphoreZirconHandleFUCHSIA");
            _vkGetShaderBinaryDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkShaderEXT, nuint*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetShaderBinaryDataEXT");
            _vkGetShaderInfoAMD_fnptr = (delegate* unmanaged<VkDevice, VkPipeline, VkShaderStageFlagBits, VkShaderInfoTypeAMD, nuint*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetShaderInfoAMD");
            _vkGetShaderModuleCreateInfoIdentifierEXT_fnptr = (delegate* unmanaged<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetShaderModuleCreateInfoIdentifierEXT");
            _vkGetShaderModuleIdentifierEXT_fnptr = (delegate* unmanaged<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetShaderModuleIdentifierEXT");
            _vkGetSwapchainCounterEXT_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagBitsEXT, ulong*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSwapchainCounterEXT");
            _vkGetSwapchainGrallocUsage2ANDROID_fnptr = (delegate* unmanaged<VkDevice, VkFormat, VkImageUsageFlagBits, VkSwapchainImageUsageFlagBitsANDROID, ulong*, ulong*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSwapchainGrallocUsage2ANDROID");
            _vkGetSwapchainGrallocUsageANDROID_fnptr = (delegate* unmanaged<VkDevice, VkFormat, VkImageUsageFlagBits, int*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSwapchainGrallocUsageANDROID");
            _vkGetSwapchainGrallocUsageOHOS_fnptr = (delegate* unmanaged<VkDevice, VkFormat, VkImageUsageFlagBits, ulong*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSwapchainGrallocUsageOHOS");
            _vkGetSwapchainImagesKHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, uint*, VkImage*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSwapchainImagesKHR");
            _vkGetSwapchainStatusKHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSwapchainStatusKHR");
            _vkGetSwapchainTimeDomainPropertiesEXT_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSwapchainTimeDomainPropertiesEXT*, ulong*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSwapchainTimeDomainPropertiesEXT");
            _vkGetSwapchainTimingPropertiesEXT_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSwapchainTimingPropertiesEXT*, ulong*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetSwapchainTimingPropertiesEXT");
            _vkGetTensorMemoryRequirementsARM_fnptr = (delegate* unmanaged<VkDevice, VkTensorMemoryRequirementsInfoARM*, VkMemoryRequirements2*, void>)VKLoader.GetDeviceProcAddr(device, "vkGetTensorMemoryRequirementsARM");
            _vkGetTensorOpaqueCaptureDescriptorDataARM_fnptr = (delegate* unmanaged<VkDevice, VkTensorCaptureDescriptorDataInfoARM*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetTensorOpaqueCaptureDescriptorDataARM");
            _vkGetTensorViewOpaqueCaptureDescriptorDataARM_fnptr = (delegate* unmanaged<VkDevice, VkTensorViewCaptureDescriptorDataInfoARM*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetTensorViewOpaqueCaptureDescriptorDataARM");
            _vkGetValidationCacheDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkValidationCacheEXT, nuint*, void*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetValidationCacheDataEXT");
            _vkGetVideoSessionMemoryRequirementsKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionKHR, uint*, VkVideoSessionMemoryRequirementsKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkGetVideoSessionMemoryRequirementsKHR");
            _vkImportFenceFdKHR_fnptr = (delegate* unmanaged<VkDevice, VkImportFenceFdInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkImportFenceFdKHR");
            _vkImportFenceSciSyncFenceNV_fnptr = (delegate* unmanaged<VkDevice, VkImportFenceSciSyncInfoNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkImportFenceSciSyncFenceNV");
            _vkImportFenceSciSyncObjNV_fnptr = (delegate* unmanaged<VkDevice, VkImportFenceSciSyncInfoNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkImportFenceSciSyncObjNV");
            _vkImportFenceWin32HandleKHR_fnptr = (delegate* unmanaged<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkImportFenceWin32HandleKHR");
            _vkImportSemaphoreFdKHR_fnptr = (delegate* unmanaged<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkImportSemaphoreFdKHR");
            _vkImportSemaphoreSciSyncObjNV_fnptr = (delegate* unmanaged<VkDevice, VkImportSemaphoreSciSyncInfoNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkImportSemaphoreSciSyncObjNV");
            _vkImportSemaphoreWin32HandleKHR_fnptr = (delegate* unmanaged<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkImportSemaphoreWin32HandleKHR");
            _vkImportSemaphoreZirconHandleFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkImportSemaphoreZirconHandleFUCHSIA");
            _vkInitializePerformanceApiINTEL_fnptr = (delegate* unmanaged<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkInitializePerformanceApiINTEL");
            _vkInvalidateMappedMemoryRanges_fnptr = (delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkInvalidateMappedMemoryRanges");
            _vkLatencySleepNV_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkLatencySleepInfoNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkLatencySleepNV");
            _vkMapMemory_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemory, ulong, ulong, VkMemoryMapFlagBits, void**, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkMapMemory");
            _vkMapMemory2_fnptr = (delegate* unmanaged<VkDevice, VkMemoryMapInfo*, void**, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkMapMemory2");
            _vkMapMemory2KHR_fnptr = (delegate* unmanaged<VkDevice, VkMemoryMapInfo*, void**, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkMapMemory2KHR");
            _vkMergePipelineCaches_fnptr = (delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkPipelineCache*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkMergePipelineCaches");
            _vkMergeValidationCachesEXT_fnptr = (delegate* unmanaged<VkDevice, VkValidationCacheEXT, uint, VkValidationCacheEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkMergeValidationCachesEXT");
            _vkQueueBeginDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<VkQueue, VkDebugUtilsLabelEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkQueueBeginDebugUtilsLabelEXT");
            _vkQueueBindSparse_fnptr = (delegate* unmanaged<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkQueueBindSparse");
            _vkQueueEndDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<VkQueue, void>)VKLoader.GetDeviceProcAddr(device, "vkQueueEndDebugUtilsLabelEXT");
            _vkQueueInsertDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<VkQueue, VkDebugUtilsLabelEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkQueueInsertDebugUtilsLabelEXT");
            _vkQueueNotifyOutOfBandNV_fnptr = (delegate* unmanaged<VkQueue, VkOutOfBandQueueTypeInfoNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkQueueNotifyOutOfBandNV");
            _vkQueuePresentKHR_fnptr = (delegate* unmanaged<VkQueue, VkPresentInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkQueuePresentKHR");
            _vkQueueSetPerformanceConfigurationINTEL_fnptr = (delegate* unmanaged<VkQueue, VkPerformanceConfigurationINTEL, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkQueueSetPerformanceConfigurationINTEL");
            _vkQueueSignalReleaseImageANDROID_fnptr = (delegate* unmanaged<VkQueue, uint, VkSemaphore*, VkImage, int*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkQueueSignalReleaseImageANDROID");
            _vkQueueSignalReleaseImageOHOS_fnptr = (delegate* unmanaged<VkQueue, uint, VkSemaphore*, VkImage, int*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkQueueSignalReleaseImageOHOS");
            _vkQueueSubmit_fnptr = (delegate* unmanaged<VkQueue, uint, VkSubmitInfo*, VkFence, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkQueueSubmit");
            _vkQueueSubmit2_fnptr = (delegate* unmanaged<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkQueueSubmit2");
            _vkQueueSubmit2KHR_fnptr = (delegate* unmanaged<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkQueueSubmit2KHR");
            _vkQueueWaitIdle_fnptr = (delegate* unmanaged<VkQueue, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkQueueWaitIdle");
            _vkRegisterDeviceEventEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkRegisterDeviceEventEXT");
            _vkRegisterDisplayEventEXT_fnptr = (delegate* unmanaged<VkDevice, VkDisplayKHR, VkDisplayEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkRegisterDisplayEventEXT");
            _vkReleaseCapturedPipelineDataKHR_fnptr = (delegate* unmanaged<VkDevice, VkReleaseCapturedPipelineDataInfoKHR*, VkAllocationCallbacks*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkReleaseCapturedPipelineDataKHR");
            _vkReleaseFullScreenExclusiveModeEXT_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkReleaseFullScreenExclusiveModeEXT");
            _vkReleasePerformanceConfigurationINTEL_fnptr = (delegate* unmanaged<VkDevice, VkPerformanceConfigurationINTEL, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkReleasePerformanceConfigurationINTEL");
            _vkReleaseProfilingLockKHR_fnptr = (delegate* unmanaged<VkDevice, void>)VKLoader.GetDeviceProcAddr(device, "vkReleaseProfilingLockKHR");
            _vkReleaseSwapchainImagesEXT_fnptr = (delegate* unmanaged<VkDevice, VkReleaseSwapchainImagesInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkReleaseSwapchainImagesEXT");
            _vkReleaseSwapchainImagesKHR_fnptr = (delegate* unmanaged<VkDevice, VkReleaseSwapchainImagesInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkReleaseSwapchainImagesKHR");
            _vkResetCommandBuffer_fnptr = (delegate* unmanaged<VkCommandBuffer, VkCommandBufferResetFlagBits, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkResetCommandBuffer");
            _vkResetCommandPool_fnptr = (delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolResetFlagBits, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkResetCommandPool");
            _vkResetDescriptorPool_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorPool, VkDescriptorPoolResetFlags, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkResetDescriptorPool");
            _vkResetEvent_fnptr = (delegate* unmanaged<VkDevice, VkEvent, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkResetEvent");
            _vkResetFences_fnptr = (delegate* unmanaged<VkDevice, uint, VkFence*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkResetFences");
            _vkResetQueryPool_fnptr = (delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkResetQueryPool");
            _vkResetQueryPoolEXT_fnptr = (delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, void>)VKLoader.GetDeviceProcAddr(device, "vkResetQueryPoolEXT");
            _vkSetBufferCollectionBufferConstraintsFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkBufferConstraintsInfoFUCHSIA*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkSetBufferCollectionBufferConstraintsFUCHSIA");
            _vkSetBufferCollectionImageConstraintsFUCHSIA_fnptr = (delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkImageConstraintsInfoFUCHSIA*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkSetBufferCollectionImageConstraintsFUCHSIA");
            _vkSetDebugUtilsObjectNameEXT_fnptr = (delegate* unmanaged<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkSetDebugUtilsObjectNameEXT");
            _vkSetDebugUtilsObjectTagEXT_fnptr = (delegate* unmanaged<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkSetDebugUtilsObjectTagEXT");
            _vkSetDeviceMemoryPriorityEXT_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemory, float, void>)VKLoader.GetDeviceProcAddr(device, "vkSetDeviceMemoryPriorityEXT");
            _vkSetEvent_fnptr = (delegate* unmanaged<VkDevice, VkEvent, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkSetEvent");
            _vkSetHdrMetadataEXT_fnptr = (delegate* unmanaged<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkSetHdrMetadataEXT");
            _vkSetLatencyMarkerNV_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSetLatencyMarkerInfoNV*, void>)VKLoader.GetDeviceProcAddr(device, "vkSetLatencyMarkerNV");
            _vkSetLatencySleepModeNV_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkLatencySleepModeInfoNV*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkSetLatencySleepModeNV");
            _vkSetLocalDimmingAMD_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, int, void>)VKLoader.GetDeviceProcAddr(device, "vkSetLocalDimmingAMD");
            _vkSetPrivateData_fnptr = (delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkSetPrivateData");
            _vkSetPrivateDataEXT_fnptr = (delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkSetPrivateDataEXT");
            _vkSetSwapchainPresentTimingQueueSizeEXT_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, uint, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkSetSwapchainPresentTimingQueueSizeEXT");
            _vkSignalSemaphore_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreSignalInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkSignalSemaphore");
            _vkSignalSemaphoreKHR_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreSignalInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkSignalSemaphoreKHR");
            _vkTransitionImageLayout_fnptr = (delegate* unmanaged<VkDevice, uint, VkHostImageLayoutTransitionInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkTransitionImageLayout");
            _vkTransitionImageLayoutEXT_fnptr = (delegate* unmanaged<VkDevice, uint, VkHostImageLayoutTransitionInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkTransitionImageLayoutEXT");
            _vkTrimCommandPool_fnptr = (delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void>)VKLoader.GetDeviceProcAddr(device, "vkTrimCommandPool");
            _vkTrimCommandPoolKHR_fnptr = (delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void>)VKLoader.GetDeviceProcAddr(device, "vkTrimCommandPoolKHR");
            _vkUninitializePerformanceApiINTEL_fnptr = (delegate* unmanaged<VkDevice, void>)VKLoader.GetDeviceProcAddr(device, "vkUninitializePerformanceApiINTEL");
            _vkUnmapMemory_fnptr = (delegate* unmanaged<VkDevice, VkDeviceMemory, void>)VKLoader.GetDeviceProcAddr(device, "vkUnmapMemory");
            _vkUnmapMemory2_fnptr = (delegate* unmanaged<VkDevice, VkMemoryUnmapInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkUnmapMemory2");
            _vkUnmapMemory2KHR_fnptr = (delegate* unmanaged<VkDevice, VkMemoryUnmapInfo*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkUnmapMemory2KHR");
            _vkUpdateDescriptorSets_fnptr = (delegate* unmanaged<VkDevice, uint, VkWriteDescriptorSet*, uint, VkCopyDescriptorSet*, void>)VKLoader.GetDeviceProcAddr(device, "vkUpdateDescriptorSets");
            _vkUpdateDescriptorSetWithTemplate_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void>)VKLoader.GetDeviceProcAddr(device, "vkUpdateDescriptorSetWithTemplate");
            _vkUpdateDescriptorSetWithTemplateKHR_fnptr = (delegate* unmanaged<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void>)VKLoader.GetDeviceProcAddr(device, "vkUpdateDescriptorSetWithTemplateKHR");
            _vkUpdateIndirectExecutionSetPipelineEXT_fnptr = (delegate* unmanaged<VkDevice, VkIndirectExecutionSetEXT, uint, VkWriteIndirectExecutionSetPipelineEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkUpdateIndirectExecutionSetPipelineEXT");
            _vkUpdateIndirectExecutionSetShaderEXT_fnptr = (delegate* unmanaged<VkDevice, VkIndirectExecutionSetEXT, uint, VkWriteIndirectExecutionSetShaderEXT*, void>)VKLoader.GetDeviceProcAddr(device, "vkUpdateIndirectExecutionSetShaderEXT");
            _vkUpdateVideoSessionParametersKHR_fnptr = (delegate* unmanaged<VkDevice, VkVideoSessionParametersKHR, VkVideoSessionParametersUpdateInfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkUpdateVideoSessionParametersKHR");
            _vkWaitForFences_fnptr = (delegate* unmanaged<VkDevice, uint, VkFence*, int, ulong, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkWaitForFences");
            _vkWaitForPresent2KHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, VkPresentWait2InfoKHR*, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkWaitForPresent2KHR");
            _vkWaitForPresentKHR_fnptr = (delegate* unmanaged<VkDevice, VkSwapchainKHR, ulong, ulong, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkWaitForPresentKHR");
            _vkWaitSemaphores_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkWaitSemaphores");
            _vkWaitSemaphoresKHR_fnptr = (delegate* unmanaged<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkWaitSemaphoresKHR");
            _vkWriteAccelerationStructuresPropertiesKHR_fnptr = (delegate* unmanaged<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, nuint, void*, nuint, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkWriteAccelerationStructuresPropertiesKHR");
            _vkWriteMicromapsPropertiesEXT_fnptr = (delegate* unmanaged<VkDevice, uint, VkMicromapEXT*, VkQueryType, nuint, void*, nuint, VkResult>)VKLoader.GetDeviceProcAddr(device, "vkWriteMicromapsPropertiesEXT");
        }
        /// <summary><b>[requires: VK_EXT_full_screen_exclusive]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireFullScreenExclusiveModeEXT.html" /></remarks>
        public VkResult AcquireFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
        {
            return _vkAcquireFullScreenExclusiveModeEXT_fnptr(device, swapchain);
        }
        /// <summary>[device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireImageANDROID.html" /></remarks>
        public VkResult AcquireImageANDROID(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence)
        {
            return _vkAcquireImageANDROID_fnptr(device, image, nativeFenceFd, semaphore, fence);
        }
        /// <summary><b>[requires: VK_OHOS_native_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireImageOHOS.html" /></remarks>
        public VkResult AcquireImageOHOS(VkDevice device, VkImage image, int nativeFenceFd, VkSemaphore semaphore, VkFence fence)
        {
            return _vkAcquireImageOHOS_fnptr(device, image, nativeFenceFd, semaphore, fence);
        }
        /// <summary><b>[requires: VK_KHR_swapchain | VK_KHR_device_group]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireNextImage2KHR.html" /></remarks>
        public VkResult AcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex)
        {
            return _vkAcquireNextImage2KHR_fnptr(device, pAcquireInfo, pImageIndex);
        }
        /// <summary><b>[requires: VK_KHR_swapchain]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireNextImageKHR.html" /></remarks>
        public VkResult AcquireNextImageKHR(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, uint* pImageIndex)
        {
            return _vkAcquireNextImageKHR_fnptr(device, swapchain, timeout, semaphore, fence, pImageIndex);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquirePerformanceConfigurationINTEL.html" /></remarks>
        public VkResult AcquirePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, VkPerformanceConfigurationINTEL* pConfiguration)
        {
            return _vkAcquirePerformanceConfigurationINTEL_fnptr(device, pAcquireInfo, pConfiguration);
        }
        /// <summary><b>[requires: VK_KHR_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireProfilingLockKHR.html" /></remarks>
        public VkResult AcquireProfilingLockKHR(VkDevice device, VkAcquireProfilingLockInfoKHR* pInfo)
        {
            return _vkAcquireProfilingLockKHR_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAllocateCommandBuffers.html" /></remarks>
        public VkResult AllocateCommandBuffers(VkDevice device, VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers)
        {
            return _vkAllocateCommandBuffers_fnptr(device, pAllocateInfo, pCommandBuffers);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAllocateDescriptorSets.html" /></remarks>
        public VkResult AllocateDescriptorSets(VkDevice device, VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets)
        {
            return _vkAllocateDescriptorSets_fnptr(device, pAllocateInfo, pDescriptorSets);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAllocateMemory.html" /></remarks>
        public VkResult AllocateMemory(VkDevice device, VkMemoryAllocateInfo* pAllocateInfo, VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory)
        {
            return _vkAllocateMemory_fnptr(device, pAllocateInfo, pAllocator, pMemory);
        }
        /// <summary><b>[requires: VK_AMD_anti_lag]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAntiLagUpdateAMD.html" /></remarks>
        public void AntiLagUpdateAMD(VkDevice device, VkAntiLagDataAMD* pData)
        {
            _vkAntiLagUpdateAMD_fnptr(device, pData);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBeginCommandBuffer.html" /></remarks>
        public VkResult BeginCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferBeginInfo* pBeginInfo)
        {
            return _vkBeginCommandBuffer_fnptr(commandBuffer, pBeginInfo);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindAccelerationStructureMemoryNV.html" /></remarks>
        public VkResult BindAccelerationStructureMemoryNV(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
        {
            return _vkBindAccelerationStructureMemoryNV_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindBufferMemory.html" /></remarks>
        public VkResult BindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset)
        {
            return _vkBindBufferMemory_fnptr(device, buffer, memory, memoryOffset);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindBufferMemory2.html" /></remarks>
        public VkResult BindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
        {
            return _vkBindBufferMemory2_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: VK_KHR_bind_memory2]</b> [device command]  Alias of <see cref="BindBufferMemory2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindBufferMemory2KHR.html" /></remarks>
        public VkResult BindBufferMemory2KHR(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
        {
            return _vkBindBufferMemory2KHR_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindDataGraphPipelineSessionMemoryARM.html" /></remarks>
        public VkResult BindDataGraphPipelineSessionMemoryARM(VkDevice device, uint bindInfoCount, VkBindDataGraphPipelineSessionMemoryInfoARM* pBindInfos)
        {
            return _vkBindDataGraphPipelineSessionMemoryARM_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory.html" /></remarks>
        public VkResult BindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset)
        {
            return _vkBindImageMemory_fnptr(device, image, memory, memoryOffset);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory2.html" /></remarks>
        public VkResult BindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
        {
            return _vkBindImageMemory2_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: VK_KHR_bind_memory2]</b> [device command]  Alias of <see cref="BindImageMemory2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindImageMemory2KHR.html" /></remarks>
        public VkResult BindImageMemory2KHR(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
        {
            return _vkBindImageMemory2KHR_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: VK_NV_optical_flow]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindOpticalFlowSessionImageNV.html" /></remarks>
        public VkResult BindOpticalFlowSessionImageNV(VkDevice device, VkOpticalFlowSessionNV session, VkOpticalFlowSessionBindingPointNV bindingPoint, VkImageView view, VkImageLayout layout)
        {
            return _vkBindOpticalFlowSessionImageNV_fnptr(device, session, bindingPoint, view, layout);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindTensorMemoryARM.html" /></remarks>
        public VkResult BindTensorMemoryARM(VkDevice device, uint bindInfoCount, VkBindTensorMemoryInfoARM* pBindInfos)
        {
            return _vkBindTensorMemoryARM_fnptr(device, bindInfoCount, pBindInfos);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBindVideoSessionMemoryKHR.html" /></remarks>
        public VkResult BindVideoSessionMemoryKHR(VkDevice device, VkVideoSessionKHR videoSession, uint bindSessionMemoryInfoCount, VkBindVideoSessionMemoryInfoKHR* pBindSessionMemoryInfos)
        {
            return _vkBindVideoSessionMemoryKHR_fnptr(device, videoSession, bindSessionMemoryInfoCount, pBindSessionMemoryInfos);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBuildAccelerationStructuresKHR.html" /></remarks>
        public VkResult BuildAccelerationStructuresKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            return _vkBuildAccelerationStructuresKHR_fnptr(device, deferredOperation, infoCount, pInfos, ppBuildRangeInfos);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkBuildMicromapsEXT.html" /></remarks>
        public VkResult BuildMicromapsEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            return _vkBuildMicromapsEXT_fnptr(device, deferredOperation, infoCount, pInfos);
        }
        /// <summary><b>[requires: VK_EXT_conditional_rendering]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginConditionalRenderingEXT.html" /></remarks>
        public void CmdBeginConditionalRenderingEXT(VkCommandBuffer commandBuffer, VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
        {
            _vkCmdBeginConditionalRenderingEXT_fnptr(commandBuffer, pConditionalRenderingBegin);
        }
        /// <summary><b>[requires: VK_EXT_custom_resolve]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginCustomResolveEXT.html" /></remarks>
        public void CmdBeginCustomResolveEXT(VkCommandBuffer commandBuffer, VkBeginCustomResolveInfoEXT* pBeginCustomResolveInfo)
        {
            _vkCmdBeginCustomResolveEXT_fnptr(commandBuffer, pBeginCustomResolveInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginDebugUtilsLabelEXT.html" /></remarks>
        public void CmdBeginDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            _vkCmdBeginDebugUtilsLabelEXT_fnptr(commandBuffer, pLabelInfo);
        }
        /// <summary><b>[requires: VK_QCOM_tile_shading]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginPerTileExecutionQCOM.html" /></remarks>
        public void CmdBeginPerTileExecutionQCOM(VkCommandBuffer commandBuffer, VkPerTileBeginInfoQCOM* pPerTileBeginInfo)
        {
            _vkCmdBeginPerTileExecutionQCOM_fnptr(commandBuffer, pPerTileBeginInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginQuery.html" /></remarks>
        public void CmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlagBits flags)
        {
            _vkCmdBeginQuery_fnptr(commandBuffer, queryPool, query, flags);
        }
        /// <summary><b>[requires: VK_EXT_transform_feedback]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginQueryIndexedEXT.html" /></remarks>
        public void CmdBeginQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlagBits flags, uint index)
        {
            _vkCmdBeginQueryIndexedEXT_fnptr(commandBuffer, queryPool, query, flags, index);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRendering.html" /></remarks>
        public void CmdBeginRendering(VkCommandBuffer commandBuffer, VkRenderingInfo* pRenderingInfo)
        {
            _vkCmdBeginRendering_fnptr(commandBuffer, pRenderingInfo);
        }
        /// <summary><b>[requires: VK_KHR_dynamic_rendering]</b> [device command]  Alias of <see cref="CmdBeginRendering"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderingKHR.html" /></remarks>
        public void CmdBeginRenderingKHR(VkCommandBuffer commandBuffer, VkRenderingInfo* pRenderingInfo)
        {
            _vkCmdBeginRenderingKHR_fnptr(commandBuffer, pRenderingInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderPass.html" /></remarks>
        public void CmdBeginRenderPass(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents)
        {
            _vkCmdBeginRenderPass_fnptr(commandBuffer, pRenderPassBegin, contents);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderPass2.html" /></remarks>
        public void CmdBeginRenderPass2(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo)
        {
            _vkCmdBeginRenderPass2_fnptr(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
        }
        /// <summary><b>[requires: VK_KHR_create_renderpass2]</b> [device command]  Alias of <see cref="CmdBeginRenderPass2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginRenderPass2KHR.html" /></remarks>
        public void CmdBeginRenderPass2KHR(VkCommandBuffer commandBuffer, VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassBeginInfo* pSubpassBeginInfo)
        {
            _vkCmdBeginRenderPass2KHR_fnptr(commandBuffer, pRenderPassBegin, pSubpassBeginInfo);
        }
        /// <summary><b>[requires: VK_EXT_transform_feedback]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginTransformFeedbackEXT.html" /></remarks>
        public void CmdBeginTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            _vkCmdBeginTransformFeedbackEXT_fnptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBeginVideoCodingKHR.html" /></remarks>
        public void CmdBeginVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoBeginCodingInfoKHR* pBeginInfo)
        {
            _vkCmdBeginVideoCodingKHR_fnptr(commandBuffer, pBeginInfo);
        }
        /// <summary><b>[requires: VK_KHR_maintenance6]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorBufferEmbeddedSamplers2EXT.html" /></remarks>
        public void CmdBindDescriptorBufferEmbeddedSamplers2EXT(VkCommandBuffer commandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT* pBindDescriptorBufferEmbeddedSamplersInfo)
        {
            _vkCmdBindDescriptorBufferEmbeddedSamplers2EXT_fnptr(commandBuffer, pBindDescriptorBufferEmbeddedSamplersInfo);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorBufferEmbeddedSamplersEXT.html" /></remarks>
        public void CmdBindDescriptorBufferEmbeddedSamplersEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set)
        {
            _vkCmdBindDescriptorBufferEmbeddedSamplersEXT_fnptr(commandBuffer, pipelineBindPoint, layout, set);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorBuffersEXT.html" /></remarks>
        public void CmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, VkDescriptorBufferBindingInfoEXT* pBindingInfos)
        {
            _vkCmdBindDescriptorBuffersEXT_fnptr(commandBuffer, bufferCount, pBindingInfos);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorSets.html" /></remarks>
        public void CmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
        {
            _vkCmdBindDescriptorSets_fnptr(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorSets2.html" /></remarks>
        public void CmdBindDescriptorSets2(VkCommandBuffer commandBuffer, VkBindDescriptorSetsInfo* pBindDescriptorSetsInfo)
        {
            _vkCmdBindDescriptorSets2_fnptr(commandBuffer, pBindDescriptorSetsInfo);
        }
        /// <summary><b>[requires: VK_KHR_maintenance6]</b> [device command]  Alias of <see cref="CmdBindDescriptorSets2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorSets2KHR.html" /></remarks>
        public void CmdBindDescriptorSets2KHR(VkCommandBuffer commandBuffer, VkBindDescriptorSetsInfo* pBindDescriptorSetsInfo)
        {
            _vkCmdBindDescriptorSets2KHR_fnptr(commandBuffer, pBindDescriptorSetsInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer.html" /></remarks>
        public void CmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType)
        {
            _vkCmdBindIndexBuffer_fnptr(commandBuffer, buffer, offset, indexType);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer2.html" /></remarks>
        public void CmdBindIndexBuffer2(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, ulong size, VkIndexType indexType)
        {
            _vkCmdBindIndexBuffer2_fnptr(commandBuffer, buffer, offset, size, indexType);
        }
        /// <summary><b>[requires: VK_KHR_maintenance5]</b> [device command]  Alias of <see cref="CmdBindIndexBuffer2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer2KHR.html" /></remarks>
        public void CmdBindIndexBuffer2KHR(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, ulong size, VkIndexType indexType)
        {
            _vkCmdBindIndexBuffer2KHR_fnptr(commandBuffer, buffer, offset, size, indexType);
        }
        /// <summary><b>[requires: VK_HUAWEI_invocation_mask]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindInvocationMaskHUAWEI.html" /></remarks>
        public void CmdBindInvocationMaskHUAWEI(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
        {
            _vkCmdBindInvocationMaskHUAWEI_fnptr(commandBuffer, imageView, imageLayout);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindPipeline.html" /></remarks>
        public void CmdBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
        {
            _vkCmdBindPipeline_fnptr(commandBuffer, pipelineBindPoint, pipeline);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindPipelineShaderGroupNV.html" /></remarks>
        public void CmdBindPipelineShaderGroupNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
        {
            _vkCmdBindPipelineShaderGroupNV_fnptr(commandBuffer, pipelineBindPoint, pipeline, groupIndex);
        }
        /// <summary><b>[requires: VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindShadersEXT.html" /></remarks>
        public void CmdBindShadersEXT(VkCommandBuffer commandBuffer, uint stageCount, VkShaderStageFlagBits* pStages, VkShaderEXT* pShaders)
        {
            _vkCmdBindShadersEXT_fnptr(commandBuffer, stageCount, pStages, pShaders);
        }
        /// <summary><b>[requires: VK_NV_shading_rate_image]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindShadingRateImageNV.html" /></remarks>
        public void CmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
        {
            _vkCmdBindShadingRateImageNV_fnptr(commandBuffer, imageView, imageLayout);
        }
        /// <summary><b>[requires: VK_QCOM_tile_memory_heap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindTileMemoryQCOM.html" /></remarks>
        public void CmdBindTileMemoryQCOM(VkCommandBuffer commandBuffer, VkTileMemoryBindInfoQCOM* pTileMemoryBindInfo)
        {
            _vkCmdBindTileMemoryQCOM_fnptr(commandBuffer, pTileMemoryBindInfo);
        }
        /// <summary><b>[requires: VK_EXT_transform_feedback]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindTransformFeedbackBuffersEXT.html" /></remarks>
        public void CmdBindTransformFeedbackBuffersEXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes)
        {
            _vkCmdBindTransformFeedbackBuffersEXT_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers.html" /></remarks>
        public void CmdBindVertexBuffers(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets)
        {
            _vkCmdBindVertexBuffers_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers2.html" /></remarks>
        public void CmdBindVertexBuffers2(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes, ulong* pStrides)
        {
            _vkCmdBindVertexBuffers2_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdBindVertexBuffers2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBindVertexBuffers2EXT.html" /></remarks>
        public void CmdBindVertexBuffers2EXT(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, ulong* pOffsets, ulong* pSizes, ulong* pStrides)
        {
            _vkCmdBindVertexBuffers2EXT_fnptr(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, pStrides);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage.html" /></remarks>
        public void CmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter)
        {
            _vkCmdBlitImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2.html" /></remarks>
        public void CmdBlitImage2(VkCommandBuffer commandBuffer, VkBlitImageInfo2* pBlitImageInfo)
        {
            _vkCmdBlitImage2_fnptr(commandBuffer, pBlitImageInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_commands2]</b> [device command]  Alias of <see cref="CmdBlitImage2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBlitImage2KHR.html" /></remarks>
        public void CmdBlitImage2KHR(VkCommandBuffer commandBuffer, VkBlitImageInfo2* pBlitImageInfo)
        {
            _vkCmdBlitImage2KHR_fnptr(commandBuffer, pBlitImageInfo);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructureNV.html" /></remarks>
        public void CmdBuildAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureInfoNV* pInfo, VkBuffer instanceData, ulong instanceOffset, int update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
        {
            _vkCmdBuildAccelerationStructureNV_fnptr(commandBuffer, pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructuresIndirectKHR.html" /></remarks>
        public void CmdBuildAccelerationStructuresIndirectKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, ulong* pIndirectDeviceAddresses, uint* pIndirectStrides, uint** ppMaxPrimitiveCounts)
        {
            _vkCmdBuildAccelerationStructuresIndirectKHR_fnptr(commandBuffer, infoCount, pInfos, pIndirectDeviceAddresses, pIndirectStrides, ppMaxPrimitiveCounts);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBuildAccelerationStructuresKHR.html" /></remarks>
        public void CmdBuildAccelerationStructuresKHR(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            _vkCmdBuildAccelerationStructuresKHR_fnptr(commandBuffer, infoCount, pInfos, ppBuildRangeInfos);
        }
        /// <summary><b>[requires: VK_NV_cluster_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBuildClusterAccelerationStructureIndirectNV.html" /></remarks>
        public void CmdBuildClusterAccelerationStructureIndirectNV(VkCommandBuffer commandBuffer, VkClusterAccelerationStructureCommandsInfoNV* pCommandInfos)
        {
            _vkCmdBuildClusterAccelerationStructureIndirectNV_fnptr(commandBuffer, pCommandInfos);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBuildMicromapsEXT.html" /></remarks>
        public void CmdBuildMicromapsEXT(VkCommandBuffer commandBuffer, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            _vkCmdBuildMicromapsEXT_fnptr(commandBuffer, infoCount, pInfos);
        }
        /// <summary><b>[requires: VK_NV_partitioned_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdBuildPartitionedAccelerationStructuresNV.html" /></remarks>
        public void CmdBuildPartitionedAccelerationStructuresNV(VkCommandBuffer commandBuffer, VkBuildPartitionedAccelerationStructureInfoNV* pBuildInfo)
        {
            _vkCmdBuildPartitionedAccelerationStructuresNV_fnptr(commandBuffer, pBuildInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdClearAttachments.html" /></remarks>
        public void CmdClearAttachments(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects)
        {
            _vkCmdClearAttachments_fnptr(commandBuffer, attachmentCount, pAttachments, rectCount, pRects);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdClearColorImage.html" /></remarks>
        public void CmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearColorValue* pColor, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            _vkCmdClearColorImage_fnptr(commandBuffer, image, imageLayout, pColor, rangeCount, pRanges);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdClearDepthStencilImage.html" /></remarks>
        public void CmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, VkClearDepthStencilValue* pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            _vkCmdClearDepthStencilImage_fnptr(commandBuffer, image, imageLayout, pDepthStencil, rangeCount, pRanges);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdControlVideoCodingKHR.html" /></remarks>
        public void CmdControlVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoCodingControlInfoKHR* pCodingControlInfo)
        {
            _vkCmdControlVideoCodingKHR_fnptr(commandBuffer, pCodingControlInfo);
        }
        /// <summary><b>[requires: VK_NV_cooperative_vector]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdConvertCooperativeVectorMatrixNV.html" /></remarks>
        public void CmdConvertCooperativeVectorMatrixNV(VkCommandBuffer commandBuffer, uint infoCount, VkConvertCooperativeVectorMatrixInfoNV* pInfos)
        {
            _vkCmdConvertCooperativeVectorMatrixNV_fnptr(commandBuffer, infoCount, pInfos);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureKHR.html" /></remarks>
        public void CmdCopyAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureInfoKHR* pInfo)
        {
            _vkCmdCopyAccelerationStructureKHR_fnptr(commandBuffer, pInfo);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureNV.html" /></remarks>
        public void CmdCopyAccelerationStructureNV(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode)
        {
            _vkCmdCopyAccelerationStructureNV_fnptr(commandBuffer, dst, src, mode);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyAccelerationStructureToMemoryKHR.html" /></remarks>
        public void CmdCopyAccelerationStructureToMemoryKHR(VkCommandBuffer commandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
        {
            _vkCmdCopyAccelerationStructureToMemoryKHR_fnptr(commandBuffer, pInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer.html" /></remarks>
        public void CmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions)
        {
            _vkCmdCopyBuffer_fnptr(commandBuffer, srcBuffer, dstBuffer, regionCount, pRegions);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer2.html" /></remarks>
        public void CmdCopyBuffer2(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* pCopyBufferInfo)
        {
            _vkCmdCopyBuffer2_fnptr(commandBuffer, pCopyBufferInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_commands2]</b> [device command]  Alias of <see cref="CmdCopyBuffer2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBuffer2KHR.html" /></remarks>
        public void CmdCopyBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyBufferInfo2* pCopyBufferInfo)
        {
            _vkCmdCopyBuffer2KHR_fnptr(commandBuffer, pCopyBufferInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBufferToImage.html" /></remarks>
        public void CmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions)
        {
            _vkCmdCopyBufferToImage_fnptr(commandBuffer, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBufferToImage2.html" /></remarks>
        public void CmdCopyBufferToImage2(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
        {
            _vkCmdCopyBufferToImage2_fnptr(commandBuffer, pCopyBufferToImageInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_commands2]</b> [device command]  Alias of <see cref="CmdCopyBufferToImage2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyBufferToImage2KHR.html" /></remarks>
        public void CmdCopyBufferToImage2KHR(VkCommandBuffer commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
        {
            _vkCmdCopyBufferToImage2KHR_fnptr(commandBuffer, pCopyBufferToImageInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImage.html" /></remarks>
        public void CmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions)
        {
            _vkCmdCopyImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImage2.html" /></remarks>
        public void CmdCopyImage2(VkCommandBuffer commandBuffer, VkCopyImageInfo2* pCopyImageInfo)
        {
            _vkCmdCopyImage2_fnptr(commandBuffer, pCopyImageInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_commands2]</b> [device command]  Alias of <see cref="CmdCopyImage2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImage2KHR.html" /></remarks>
        public void CmdCopyImage2KHR(VkCommandBuffer commandBuffer, VkCopyImageInfo2* pCopyImageInfo)
        {
            _vkCmdCopyImage2KHR_fnptr(commandBuffer, pCopyImageInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImageToBuffer.html" /></remarks>
        public void CmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
        {
            _vkCmdCopyImageToBuffer_fnptr(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImageToBuffer2.html" /></remarks>
        public void CmdCopyImageToBuffer2(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
        {
            _vkCmdCopyImageToBuffer2_fnptr(commandBuffer, pCopyImageToBufferInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_commands2]</b> [device command]  Alias of <see cref="CmdCopyImageToBuffer2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyImageToBuffer2KHR.html" /></remarks>
        public void CmdCopyImageToBuffer2KHR(VkCommandBuffer commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
        {
            _vkCmdCopyImageToBuffer2KHR_fnptr(commandBuffer, pCopyImageToBufferInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_memory_indirect]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryIndirectKHR.html" /></remarks>
        public void CmdCopyMemoryIndirectKHR(VkCommandBuffer commandBuffer, VkCopyMemoryIndirectInfoKHR* pCopyMemoryIndirectInfo)
        {
            _vkCmdCopyMemoryIndirectKHR_fnptr(commandBuffer, pCopyMemoryIndirectInfo);
        }
        /// <summary><b>[requires: VK_NV_copy_memory_indirect]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryIndirectNV.html" /></remarks>
        public void CmdCopyMemoryIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride)
        {
            _vkCmdCopyMemoryIndirectNV_fnptr(commandBuffer, copyBufferAddress, copyCount, stride);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToAccelerationStructureKHR.html" /></remarks>
        public void CmdCopyMemoryToAccelerationStructureKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
        {
            _vkCmdCopyMemoryToAccelerationStructureKHR_fnptr(commandBuffer, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_memory_indirect]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToImageIndirectKHR.html" /></remarks>
        public void CmdCopyMemoryToImageIndirectKHR(VkCommandBuffer commandBuffer, VkCopyMemoryToImageIndirectInfoKHR* pCopyMemoryToImageIndirectInfo)
        {
            _vkCmdCopyMemoryToImageIndirectKHR_fnptr(commandBuffer, pCopyMemoryToImageIndirectInfo);
        }
        /// <summary><b>[requires: VK_NV_copy_memory_indirect]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToImageIndirectNV.html" /></remarks>
        public void CmdCopyMemoryToImageIndirectNV(VkCommandBuffer commandBuffer, ulong copyBufferAddress, uint copyCount, uint stride, VkImage dstImage, VkImageLayout dstImageLayout, VkImageSubresourceLayers* pImageSubresources)
        {
            _vkCmdCopyMemoryToImageIndirectNV_fnptr(commandBuffer, copyBufferAddress, copyCount, stride, dstImage, dstImageLayout, pImageSubresources);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToMicromapEXT.html" /></remarks>
        public void CmdCopyMemoryToMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMemoryToMicromapInfoEXT* pInfo)
        {
            _vkCmdCopyMemoryToMicromapEXT_fnptr(commandBuffer, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMicromapEXT.html" /></remarks>
        public void CmdCopyMicromapEXT(VkCommandBuffer commandBuffer, VkCopyMicromapInfoEXT* pInfo)
        {
            _vkCmdCopyMicromapEXT_fnptr(commandBuffer, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMicromapToMemoryEXT.html" /></remarks>
        public void CmdCopyMicromapToMemoryEXT(VkCommandBuffer commandBuffer, VkCopyMicromapToMemoryInfoEXT* pInfo)
        {
            _vkCmdCopyMicromapToMemoryEXT_fnptr(commandBuffer, pInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyQueryPoolResults.html" /></remarks>
        public void CmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlagBits flags)
        {
            _vkCmdCopyQueryPoolResults_fnptr(commandBuffer, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCopyTensorARM.html" /></remarks>
        public void CmdCopyTensorARM(VkCommandBuffer commandBuffer, VkCopyTensorInfoARM* pCopyTensorInfo)
        {
            _vkCmdCopyTensorARM_fnptr(commandBuffer, pCopyTensorInfo);
        }
        /// <summary><b>[requires: VK_NV_cuda_kernel_launch]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCudaLaunchKernelNV.html" /></remarks>
        public void CmdCudaLaunchKernelNV(VkCommandBuffer commandBuffer, VkCudaLaunchInfoNV* pLaunchInfo)
        {
            _vkCmdCudaLaunchKernelNV_fnptr(commandBuffer, pLaunchInfo);
        }
        /// <summary><b>[requires: VK_NVX_binary_import]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdCuLaunchKernelNVX.html" /></remarks>
        public void CmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo)
        {
            _vkCmdCuLaunchKernelNVX_fnptr(commandBuffer, pLaunchInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDebugMarkerBeginEXT.html" /></remarks>
        public void CmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
        {
            _vkCmdDebugMarkerBeginEXT_fnptr(commandBuffer, pMarkerInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDebugMarkerEndEXT.html" /></remarks>
        public void CmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer)
        {
            _vkCmdDebugMarkerEndEXT_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: VK_EXT_debug_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDebugMarkerInsertEXT.html" /></remarks>
        public void CmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
        {
            _vkCmdDebugMarkerInsertEXT_fnptr(commandBuffer, pMarkerInfo);
        }
        /// <summary><b>[requires: VK_KHR_video_decode_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDecodeVideoKHR.html" /></remarks>
        public void CmdDecodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoDecodeInfoKHR* pDecodeInfo)
        {
            _vkCmdDecodeVideoKHR_fnptr(commandBuffer, pDecodeInfo);
        }
        /// <summary><b>[requires: VK_EXT_memory_decompression]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDecompressMemoryEXT.html" /></remarks>
        public void CmdDecompressMemoryEXT(VkCommandBuffer commandBuffer, VkDecompressMemoryInfoEXT* pDecompressMemoryInfoEXT)
        {
            _vkCmdDecompressMemoryEXT_fnptr(commandBuffer, pDecompressMemoryInfoEXT);
        }
        /// <summary><b>[requires: VK_EXT_memory_decompression]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDecompressMemoryIndirectCountEXT.html" /></remarks>
        public void CmdDecompressMemoryIndirectCountEXT(VkCommandBuffer commandBuffer, VkMemoryDecompressionMethodFlagBitsEXT decompressionMethod, ulong indirectCommandsAddress, ulong indirectCommandsCountAddress, uint maxDecompressionCount, uint stride)
        {
            _vkCmdDecompressMemoryIndirectCountEXT_fnptr(commandBuffer, decompressionMethod, indirectCommandsAddress, indirectCommandsCountAddress, maxDecompressionCount, stride);
        }
        /// <summary><b>[requires: VK_NV_memory_decompression]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDecompressMemoryIndirectCountNV.html" /></remarks>
        public void CmdDecompressMemoryIndirectCountNV(VkCommandBuffer commandBuffer, ulong indirectCommandsAddress, ulong indirectCommandsCountAddress, uint stride)
        {
            _vkCmdDecompressMemoryIndirectCountNV_fnptr(commandBuffer, indirectCommandsAddress, indirectCommandsCountAddress, stride);
        }
        /// <summary><b>[requires: VK_NV_memory_decompression]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDecompressMemoryNV.html" /></remarks>
        public void CmdDecompressMemoryNV(VkCommandBuffer commandBuffer, uint decompressRegionCount, VkDecompressMemoryRegionNV* pDecompressMemoryRegions)
        {
            _vkCmdDecompressMemoryNV_fnptr(commandBuffer, decompressRegionCount, pDecompressMemoryRegions);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatch.html" /></remarks>
        public void CmdDispatch(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            _vkCmdDispatch_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchBase.html" /></remarks>
        public void CmdDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            _vkCmdDispatchBase_fnptr(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
        }
        /// <summary><b>[requires: VK_KHR_device_group]</b> [device command]  Alias of <see cref="CmdDispatchBase"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchBaseKHR.html" /></remarks>
        public void CmdDispatchBaseKHR(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            _vkCmdDispatchBaseKHR_fnptr(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchDataGraphARM.html" /></remarks>
        public void CmdDispatchDataGraphARM(VkCommandBuffer commandBuffer, VkDataGraphPipelineSessionARM session, VkDataGraphPipelineDispatchInfoARM* pInfo)
        {
            _vkCmdDispatchDataGraphARM_fnptr(commandBuffer, session, pInfo);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchGraphAMDX.html" /></remarks>
        public void CmdDispatchGraphAMDX(VkCommandBuffer commandBuffer, ulong scratch, ulong scratchSize, VkDispatchGraphCountInfoAMDX* pCountInfo)
        {
            _vkCmdDispatchGraphAMDX_fnptr(commandBuffer, scratch, scratchSize, pCountInfo);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchGraphIndirectAMDX.html" /></remarks>
        public void CmdDispatchGraphIndirectAMDX(VkCommandBuffer commandBuffer, ulong scratch, ulong scratchSize, VkDispatchGraphCountInfoAMDX* pCountInfo)
        {
            _vkCmdDispatchGraphIndirectAMDX_fnptr(commandBuffer, scratch, scratchSize, pCountInfo);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchGraphIndirectCountAMDX.html" /></remarks>
        public void CmdDispatchGraphIndirectCountAMDX(VkCommandBuffer commandBuffer, ulong scratch, ulong scratchSize, ulong countInfo)
        {
            _vkCmdDispatchGraphIndirectCountAMDX_fnptr(commandBuffer, scratch, scratchSize, countInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchIndirect.html" /></remarks>
        public void CmdDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
        {
            _vkCmdDispatchIndirect_fnptr(commandBuffer, buffer, offset);
        }
        /// <summary><b>[requires: VK_QCOM_tile_shading]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchTileQCOM.html" /></remarks>
        public void CmdDispatchTileQCOM(VkCommandBuffer commandBuffer, VkDispatchTileInfoQCOM* pDispatchTileInfo)
        {
            _vkCmdDispatchTileQCOM_fnptr(commandBuffer, pDispatchTileInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDraw.html" /></remarks>
        public void CmdDraw(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            _vkCmdDraw_fnptr(commandBuffer, vertexCount, instanceCount, firstVertex, firstInstance);
        }
        /// <summary><b>[requires: VK_HUAWEI_cluster_culling_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawClusterHUAWEI.html" /></remarks>
        public void CmdDrawClusterHUAWEI(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            _vkCmdDrawClusterHUAWEI_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        /// <summary><b>[requires: VK_HUAWEI_cluster_culling_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawClusterIndirectHUAWEI.html" /></remarks>
        public void CmdDrawClusterIndirectHUAWEI(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset)
        {
            _vkCmdDrawClusterIndirectHUAWEI_fnptr(commandBuffer, buffer, offset);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexed.html" /></remarks>
        public void CmdDrawIndexed(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            _vkCmdDrawIndexed_fnptr(commandBuffer, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirect.html" /></remarks>
        public void CmdDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            _vkCmdDrawIndexedIndirect_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirectCount.html" /></remarks>
        public void CmdDrawIndexedIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            _vkCmdDrawIndexedIndirectCount_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_AMD_draw_indirect_count]</b> [device command]  Alias of <see cref="CmdDrawIndexedIndirectCount"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirectCountAMD.html" /></remarks>
        public void CmdDrawIndexedIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            _vkCmdDrawIndexedIndirectCountAMD_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_KHR_draw_indirect_count]</b> [device command]  Alias of <see cref="CmdDrawIndexedIndirectCount"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirectCountKHR.html" /></remarks>
        public void CmdDrawIndexedIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            _vkCmdDrawIndexedIndirectCountKHR_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirect.html" /></remarks>
        public void CmdDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            _vkCmdDrawIndirect_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        /// <summary><b>[requires: VK_EXT_transform_feedback]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectByteCountEXT.html" /></remarks>
        public void CmdDrawIndirectByteCountEXT(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
        {
            _vkCmdDrawIndirectByteCountEXT_fnptr(commandBuffer, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectCount.html" /></remarks>
        public void CmdDrawIndirectCount(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            _vkCmdDrawIndirectCount_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_AMD_draw_indirect_count]</b> [device command]  Alias of <see cref="CmdDrawIndirectCount"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectCountAMD.html" /></remarks>
        public void CmdDrawIndirectCountAMD(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            _vkCmdDrawIndirectCountAMD_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_KHR_draw_indirect_count]</b> [device command]  Alias of <see cref="CmdDrawIndirectCount"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectCountKHR.html" /></remarks>
        public void CmdDrawIndirectCountKHR(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            _vkCmdDrawIndirectCountKHR_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_EXT_mesh_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksEXT.html" /></remarks>
        public void CmdDrawMeshTasksEXT(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            _vkCmdDrawMeshTasksEXT_fnptr(commandBuffer, groupCountX, groupCountY, groupCountZ);
        }
        /// <summary><b>[requires: VK_EXT_mesh_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectCountEXT.html" /></remarks>
        public void CmdDrawMeshTasksIndirectCountEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            _vkCmdDrawMeshTasksIndirectCountEXT_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_NV_mesh_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectCountNV.html" /></remarks>
        public void CmdDrawMeshTasksIndirectCountNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            _vkCmdDrawMeshTasksIndirectCountNV_fnptr(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        /// <summary><b>[requires: VK_EXT_mesh_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectEXT.html" /></remarks>
        public void CmdDrawMeshTasksIndirectEXT(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            _vkCmdDrawMeshTasksIndirectEXT_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        /// <summary><b>[requires: VK_NV_mesh_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksIndirectNV.html" /></remarks>
        public void CmdDrawMeshTasksIndirectNV(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            _vkCmdDrawMeshTasksIndirectNV_fnptr(commandBuffer, buffer, offset, drawCount, stride);
        }
        /// <summary><b>[requires: VK_NV_mesh_shader]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMeshTasksNV.html" /></remarks>
        public void CmdDrawMeshTasksNV(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask)
        {
            _vkCmdDrawMeshTasksNV_fnptr(commandBuffer, taskCount, firstTask);
        }
        /// <summary><b>[requires: VK_EXT_multi_draw]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMultiEXT.html" /></remarks>
        public void CmdDrawMultiEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
        {
            _vkCmdDrawMultiEXT_fnptr(commandBuffer, drawCount, pVertexInfo, instanceCount, firstInstance, stride);
        }
        /// <summary><b>[requires: VK_EXT_multi_draw]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdDrawMultiIndexedEXT.html" /></remarks>
        public void CmdDrawMultiIndexedEXT(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, int* pVertexOffset)
        {
            _vkCmdDrawMultiIndexedEXT_fnptr(commandBuffer, drawCount, pIndexInfo, instanceCount, firstInstance, stride, pVertexOffset);
        }
        /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEncodeVideoKHR.html" /></remarks>
        public void CmdEncodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoEncodeInfoKHR* pEncodeInfo)
        {
            _vkCmdEncodeVideoKHR_fnptr(commandBuffer, pEncodeInfo);
        }
        /// <summary><b>[requires: VK_EXT_conditional_rendering]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndConditionalRenderingEXT.html" /></remarks>
        public void CmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer)
        {
            _vkCmdEndConditionalRenderingEXT_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndDebugUtilsLabelEXT.html" /></remarks>
        public void CmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer)
        {
            _vkCmdEndDebugUtilsLabelEXT_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: VK_QCOM_tile_shading]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndPerTileExecutionQCOM.html" /></remarks>
        public void CmdEndPerTileExecutionQCOM(VkCommandBuffer commandBuffer, VkPerTileEndInfoQCOM* pPerTileEndInfo)
        {
            _vkCmdEndPerTileExecutionQCOM_fnptr(commandBuffer, pPerTileEndInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndQuery.html" /></remarks>
        public void CmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query)
        {
            _vkCmdEndQuery_fnptr(commandBuffer, queryPool, query);
        }
        /// <summary><b>[requires: VK_EXT_transform_feedback]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndQueryIndexedEXT.html" /></remarks>
        public void CmdEndQueryIndexedEXT(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index)
        {
            _vkCmdEndQueryIndexedEXT_fnptr(commandBuffer, queryPool, query, index);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRendering.html" /></remarks>
        public void CmdEndRendering(VkCommandBuffer commandBuffer)
        {
            _vkCmdEndRendering_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: VK_EXT_fragment_density_map_offset]</b> [device command]  Alias of <see cref="CmdEndRendering2KHR"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRendering2EXT.html" /></remarks>
        public void CmdEndRendering2EXT(VkCommandBuffer commandBuffer, VkRenderingEndInfoKHR* pRenderingEndInfo)
        {
            _vkCmdEndRendering2EXT_fnptr(commandBuffer, pRenderingEndInfo);
        }
        /// <summary><b>[requires: VK_KHR_maintenance10]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRendering2KHR.html" /></remarks>
        public void CmdEndRendering2KHR(VkCommandBuffer commandBuffer, VkRenderingEndInfoKHR* pRenderingEndInfo)
        {
            _vkCmdEndRendering2KHR_fnptr(commandBuffer, pRenderingEndInfo);
        }
        /// <summary><b>[requires: VK_KHR_dynamic_rendering]</b> [device command]  Alias of <see cref="CmdEndRendering"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderingKHR.html" /></remarks>
        public void CmdEndRenderingKHR(VkCommandBuffer commandBuffer)
        {
            _vkCmdEndRenderingKHR_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass.html" /></remarks>
        public void CmdEndRenderPass(VkCommandBuffer commandBuffer)
        {
            _vkCmdEndRenderPass_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass2.html" /></remarks>
        public void CmdEndRenderPass2(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo)
        {
            _vkCmdEndRenderPass2_fnptr(commandBuffer, pSubpassEndInfo);
        }
        /// <summary><b>[requires: VK_KHR_create_renderpass2]</b> [device command]  Alias of <see cref="CmdEndRenderPass2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndRenderPass2KHR.html" /></remarks>
        public void CmdEndRenderPass2KHR(VkCommandBuffer commandBuffer, VkSubpassEndInfo* pSubpassEndInfo)
        {
            _vkCmdEndRenderPass2KHR_fnptr(commandBuffer, pSubpassEndInfo);
        }
        /// <summary><b>[requires: VK_EXT_transform_feedback]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndTransformFeedbackEXT.html" /></remarks>
        public void CmdEndTransformFeedbackEXT(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, ulong* pCounterBufferOffsets)
        {
            _vkCmdEndTransformFeedbackEXT_fnptr(commandBuffer, firstCounterBuffer, counterBufferCount, pCounterBuffers, pCounterBufferOffsets);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdEndVideoCodingKHR.html" /></remarks>
        public void CmdEndVideoCodingKHR(VkCommandBuffer commandBuffer, VkVideoEndCodingInfoKHR* pEndCodingInfo)
        {
            _vkCmdEndVideoCodingKHR_fnptr(commandBuffer, pEndCodingInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteCommands.html" /></remarks>
        public void CmdExecuteCommands(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
        {
            _vkCmdExecuteCommands_fnptr(commandBuffer, commandBufferCount, pCommandBuffers);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteGeneratedCommandsEXT.html" /></remarks>
        public void CmdExecuteGeneratedCommandsEXT(VkCommandBuffer commandBuffer, int isPreprocessed, VkGeneratedCommandsInfoEXT* pGeneratedCommandsInfo)
        {
            _vkCmdExecuteGeneratedCommandsEXT_fnptr(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdExecuteGeneratedCommandsNV.html" /></remarks>
        public void CmdExecuteGeneratedCommandsNV(VkCommandBuffer commandBuffer, int isPreprocessed, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
        {
            _vkCmdExecuteGeneratedCommandsNV_fnptr(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdFillBuffer.html" /></remarks>
        public void CmdFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data)
        {
            _vkCmdFillBuffer_fnptr(commandBuffer, dstBuffer, dstOffset, size, data);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdInitializeGraphScratchMemoryAMDX.html" /></remarks>
        public void CmdInitializeGraphScratchMemoryAMDX(VkCommandBuffer commandBuffer, VkPipeline executionGraph, ulong scratch, ulong scratchSize)
        {
            _vkCmdInitializeGraphScratchMemoryAMDX_fnptr(commandBuffer, executionGraph, scratch, scratchSize);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdInsertDebugUtilsLabelEXT.html" /></remarks>
        public void CmdInsertDebugUtilsLabelEXT(VkCommandBuffer commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            _vkCmdInsertDebugUtilsLabelEXT_fnptr(commandBuffer, pLabelInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass.html" /></remarks>
        public void CmdNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents)
        {
            _vkCmdNextSubpass_fnptr(commandBuffer, contents);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass2.html" /></remarks>
        public void CmdNextSubpass2(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo)
        {
            _vkCmdNextSubpass2_fnptr(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
        }
        /// <summary><b>[requires: VK_KHR_create_renderpass2]</b> [device command]  Alias of <see cref="CmdNextSubpass2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdNextSubpass2KHR.html" /></remarks>
        public void CmdNextSubpass2KHR(VkCommandBuffer commandBuffer, VkSubpassBeginInfo* pSubpassBeginInfo, VkSubpassEndInfo* pSubpassEndInfo)
        {
            _vkCmdNextSubpass2KHR_fnptr(commandBuffer, pSubpassBeginInfo, pSubpassEndInfo);
        }
        /// <summary><b>[requires: VK_NV_optical_flow]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdOpticalFlowExecuteNV.html" /></remarks>
        public void CmdOpticalFlowExecuteNV(VkCommandBuffer commandBuffer, VkOpticalFlowSessionNV session, VkOpticalFlowExecuteInfoNV* pExecuteInfo)
        {
            _vkCmdOpticalFlowExecuteNV_fnptr(commandBuffer, session, pExecuteInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPipelineBarrier.html" /></remarks>
        public void CmdPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits srcStageMask, VkPipelineStageFlagBits dstStageMask, VkDependencyFlagBits dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
        {
            _vkCmdPipelineBarrier_fnptr(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPipelineBarrier2.html" /></remarks>
        public void CmdPipelineBarrier2(VkCommandBuffer commandBuffer, VkDependencyInfo* pDependencyInfo)
        {
            _vkCmdPipelineBarrier2_fnptr(commandBuffer, pDependencyInfo);
        }
        /// <summary><b>[requires: VK_KHR_synchronization2]</b> [device command]  Alias of <see cref="CmdPipelineBarrier2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPipelineBarrier2KHR.html" /></remarks>
        public void CmdPipelineBarrier2KHR(VkCommandBuffer commandBuffer, VkDependencyInfo* pDependencyInfo)
        {
            _vkCmdPipelineBarrier2KHR_fnptr(commandBuffer, pDependencyInfo);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsEXT.html" /></remarks>
        public void CmdPreprocessGeneratedCommandsEXT(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoEXT* pGeneratedCommandsInfo, VkCommandBuffer stateCommandBuffer)
        {
            _vkCmdPreprocessGeneratedCommandsEXT_fnptr(commandBuffer, pGeneratedCommandsInfo, stateCommandBuffer);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPreprocessGeneratedCommandsNV.html" /></remarks>
        public void CmdPreprocessGeneratedCommandsNV(VkCommandBuffer commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
        {
            _vkCmdPreprocessGeneratedCommandsNV_fnptr(commandBuffer, pGeneratedCommandsInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushConstants.html" /></remarks>
        public void CmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlagBits stageFlags, uint offset, uint size, void* pValues)
        {
            _vkCmdPushConstants_fnptr(commandBuffer, layout, stageFlags, offset, size, pValues);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushConstants2.html" /></remarks>
        public void CmdPushConstants2(VkCommandBuffer commandBuffer, VkPushConstantsInfo* pPushConstantsInfo)
        {
            _vkCmdPushConstants2_fnptr(commandBuffer, pPushConstantsInfo);
        }
        /// <summary><b>[requires: VK_KHR_maintenance6]</b> [device command]  Alias of <see cref="CmdPushConstants2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushConstants2KHR.html" /></remarks>
        public void CmdPushConstants2KHR(VkCommandBuffer commandBuffer, VkPushConstantsInfo* pPushConstantsInfo)
        {
            _vkCmdPushConstants2KHR_fnptr(commandBuffer, pPushConstantsInfo);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSet.html" /></remarks>
        public void CmdPushDescriptorSet(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
        {
            _vkCmdPushDescriptorSet_fnptr(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSet2.html" /></remarks>
        public void CmdPushDescriptorSet2(VkCommandBuffer commandBuffer, VkPushDescriptorSetInfo* pPushDescriptorSetInfo)
        {
            _vkCmdPushDescriptorSet2_fnptr(commandBuffer, pPushDescriptorSetInfo);
        }
        /// <summary><b>[requires: VK_KHR_maintenance6]</b> [device command]  Alias of <see cref="CmdPushDescriptorSet2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSet2KHR.html" /></remarks>
        public void CmdPushDescriptorSet2KHR(VkCommandBuffer commandBuffer, VkPushDescriptorSetInfo* pPushDescriptorSetInfo)
        {
            _vkCmdPushDescriptorSet2KHR_fnptr(commandBuffer, pPushDescriptorSetInfo);
        }
        /// <summary><b>[requires: VK_KHR_push_descriptor]</b> [device command]  Alias of <see cref="CmdPushDescriptorSet"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetKHR.html" /></remarks>
        public void CmdPushDescriptorSetKHR(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
        {
            _vkCmdPushDescriptorSetKHR_fnptr(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetWithTemplate.html" /></remarks>
        public void CmdPushDescriptorSetWithTemplate(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
        {
            _vkCmdPushDescriptorSetWithTemplate_fnptr(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetWithTemplate2.html" /></remarks>
        public void CmdPushDescriptorSetWithTemplate2(VkCommandBuffer commandBuffer, VkPushDescriptorSetWithTemplateInfo* pPushDescriptorSetWithTemplateInfo)
        {
            _vkCmdPushDescriptorSetWithTemplate2_fnptr(commandBuffer, pPushDescriptorSetWithTemplateInfo);
        }
        /// <summary><b>[requires: VK_KHR_maintenance6]</b> [device command]  Alias of <see cref="CmdPushDescriptorSetWithTemplate2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetWithTemplate2KHR.html" /></remarks>
        public void CmdPushDescriptorSetWithTemplate2KHR(VkCommandBuffer commandBuffer, VkPushDescriptorSetWithTemplateInfo* pPushDescriptorSetWithTemplateInfo)
        {
            _vkCmdPushDescriptorSetWithTemplate2KHR_fnptr(commandBuffer, pPushDescriptorSetWithTemplateInfo);
        }
        /// <summary><b>[requires: VK_KHR_push_descriptor | VK_KHR_descriptor_update_template]</b> [device command]  Alias of <see cref="CmdPushDescriptorSetWithTemplate"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetWithTemplateKHR.html" /></remarks>
        public void CmdPushDescriptorSetWithTemplateKHR(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
        {
            _vkCmdPushDescriptorSetWithTemplateKHR_fnptr(commandBuffer, descriptorUpdateTemplate, layout, set, pData);
        }
        /// <summary><b>[requires: VK_KHR_object_refresh]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdRefreshObjectsKHR.html" /></remarks>
        public void CmdRefreshObjectsKHR(VkCommandBuffer commandBuffer, VkRefreshObjectListKHR* pRefreshObjects)
        {
            _vkCmdRefreshObjectsKHR_fnptr(commandBuffer, pRefreshObjects);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResetEvent.html" /></remarks>
        public void CmdResetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits stageMask)
        {
            _vkCmdResetEvent_fnptr(commandBuffer, @event, stageMask);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResetEvent2.html" /></remarks>
        public void CmdResetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits2 stageMask)
        {
            _vkCmdResetEvent2_fnptr(commandBuffer, @event, stageMask);
        }
        /// <summary><b>[requires: VK_KHR_synchronization2]</b> [device command]  Alias of <see cref="CmdResetEvent2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResetEvent2KHR.html" /></remarks>
        public void CmdResetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits2 stageMask)
        {
            _vkCmdResetEvent2KHR_fnptr(commandBuffer, @event, stageMask);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResetQueryPool.html" /></remarks>
        public void CmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            _vkCmdResetQueryPool_fnptr(commandBuffer, queryPool, firstQuery, queryCount);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage.html" /></remarks>
        public void CmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions)
        {
            _vkCmdResolveImage_fnptr(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage2.html" /></remarks>
        public void CmdResolveImage2(VkCommandBuffer commandBuffer, VkResolveImageInfo2* pResolveImageInfo)
        {
            _vkCmdResolveImage2_fnptr(commandBuffer, pResolveImageInfo);
        }
        /// <summary><b>[requires: VK_KHR_copy_commands2]</b> [device command]  Alias of <see cref="CmdResolveImage2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdResolveImage2KHR.html" /></remarks>
        public void CmdResolveImage2KHR(VkCommandBuffer commandBuffer, VkResolveImageInfo2* pResolveImageInfo)
        {
            _vkCmdResolveImage2KHR_fnptr(commandBuffer, pResolveImageInfo);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetAlphaToCoverageEnableEXT.html" /></remarks>
        public void CmdSetAlphaToCoverageEnableEXT(VkCommandBuffer commandBuffer, int alphaToCoverageEnable)
        {
            _vkCmdSetAlphaToCoverageEnableEXT_fnptr(commandBuffer, alphaToCoverageEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetAlphaToOneEnableEXT.html" /></remarks>
        public void CmdSetAlphaToOneEnableEXT(VkCommandBuffer commandBuffer, int alphaToOneEnable)
        {
            _vkCmdSetAlphaToOneEnableEXT_fnptr(commandBuffer, alphaToOneEnable);
        }
        /// <summary><b>[requires: VK_EXT_attachment_feedback_loop_dynamic_state]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetAttachmentFeedbackLoopEnableEXT.html" /></remarks>
        public void CmdSetAttachmentFeedbackLoopEnableEXT(VkCommandBuffer commandBuffer, VkImageAspectFlagBits aspectMask)
        {
            _vkCmdSetAttachmentFeedbackLoopEnableEXT_fnptr(commandBuffer, aspectMask);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetBlendConstants.html" /></remarks>
        public void CmdSetBlendConstants(VkCommandBuffer commandBuffer, float* blendConstants)
        {
            _vkCmdSetBlendConstants_fnptr(commandBuffer, blendConstants);
        }
        /// <summary><b>[requires: VK_NV_device_diagnostic_checkpoints]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCheckpointNV.html" /></remarks>
        public void CmdSetCheckpointNV(VkCommandBuffer commandBuffer, void* pCheckpointMarker)
        {
            _vkCmdSetCheckpointNV_fnptr(commandBuffer, pCheckpointMarker);
        }
        /// <summary><b>[requires: VK_NV_shading_rate_image]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoarseSampleOrderNV.html" /></remarks>
        public void CmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
        {
            _vkCmdSetCoarseSampleOrderNV_fnptr(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorBlendAdvancedEXT.html" /></remarks>
        public void CmdSetColorBlendAdvancedEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendAdvancedEXT* pColorBlendAdvanced)
        {
            _vkCmdSetColorBlendAdvancedEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendAdvanced);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorBlendEnableEXT.html" /></remarks>
        public void CmdSetColorBlendEnableEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, int* pColorBlendEnables)
        {
            _vkCmdSetColorBlendEnableEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEnables);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorBlendEquationEXT.html" /></remarks>
        public void CmdSetColorBlendEquationEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorBlendEquationEXT* pColorBlendEquations)
        {
            _vkCmdSetColorBlendEquationEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorBlendEquations);
        }
        /// <summary><b>[requires: VK_EXT_color_write_enable]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorWriteEnableEXT.html" /></remarks>
        public void CmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, int* pColorWriteEnables)
        {
            _vkCmdSetColorWriteEnableEXT_fnptr(commandBuffer, attachmentCount, pColorWriteEnables);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetColorWriteMaskEXT.html" /></remarks>
        public void CmdSetColorWriteMaskEXT(VkCommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, VkColorComponentFlagBits* pColorWriteMasks)
        {
            _vkCmdSetColorWriteMaskEXT_fnptr(commandBuffer, firstAttachment, attachmentCount, pColorWriteMasks);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetConservativeRasterizationModeEXT.html" /></remarks>
        public void CmdSetConservativeRasterizationModeEXT(VkCommandBuffer commandBuffer, VkConservativeRasterizationModeEXT conservativeRasterizationMode)
        {
            _vkCmdSetConservativeRasterizationModeEXT_fnptr(commandBuffer, conservativeRasterizationMode);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageModulationModeNV.html" /></remarks>
        public void CmdSetCoverageModulationModeNV(VkCommandBuffer commandBuffer, VkCoverageModulationModeNV coverageModulationMode)
        {
            _vkCmdSetCoverageModulationModeNV_fnptr(commandBuffer, coverageModulationMode);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageModulationTableEnableNV.html" /></remarks>
        public void CmdSetCoverageModulationTableEnableNV(VkCommandBuffer commandBuffer, int coverageModulationTableEnable)
        {
            _vkCmdSetCoverageModulationTableEnableNV_fnptr(commandBuffer, coverageModulationTableEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageModulationTableNV.html" /></remarks>
        public void CmdSetCoverageModulationTableNV(VkCommandBuffer commandBuffer, uint coverageModulationTableCount, float* pCoverageModulationTable)
        {
            _vkCmdSetCoverageModulationTableNV_fnptr(commandBuffer, coverageModulationTableCount, pCoverageModulationTable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageReductionModeNV.html" /></remarks>
        public void CmdSetCoverageReductionModeNV(VkCommandBuffer commandBuffer, VkCoverageReductionModeNV coverageReductionMode)
        {
            _vkCmdSetCoverageReductionModeNV_fnptr(commandBuffer, coverageReductionMode);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageToColorEnableNV.html" /></remarks>
        public void CmdSetCoverageToColorEnableNV(VkCommandBuffer commandBuffer, int coverageToColorEnable)
        {
            _vkCmdSetCoverageToColorEnableNV_fnptr(commandBuffer, coverageToColorEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoverageToColorLocationNV.html" /></remarks>
        public void CmdSetCoverageToColorLocationNV(VkCommandBuffer commandBuffer, uint coverageToColorLocation)
        {
            _vkCmdSetCoverageToColorLocationNV_fnptr(commandBuffer, coverageToColorLocation);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCullMode.html" /></remarks>
        public void CmdSetCullMode(VkCommandBuffer commandBuffer, VkCullModeFlagBits cullMode)
        {
            _vkCmdSetCullMode_fnptr(commandBuffer, cullMode);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetCullMode"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetCullModeEXT.html" /></remarks>
        public void CmdSetCullModeEXT(VkCommandBuffer commandBuffer, VkCullModeFlagBits cullMode)
        {
            _vkCmdSetCullModeEXT_fnptr(commandBuffer, cullMode);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBias.html" /></remarks>
        public void CmdSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            _vkCmdSetDepthBias_fnptr(commandBuffer, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
        }
        /// <summary><b>[requires: VK_EXT_depth_bias_control]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBias2EXT.html" /></remarks>
        public void CmdSetDepthBias2EXT(VkCommandBuffer commandBuffer, VkDepthBiasInfoEXT* pDepthBiasInfo)
        {
            _vkCmdSetDepthBias2EXT_fnptr(commandBuffer, pDepthBiasInfo);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBiasEnable.html" /></remarks>
        public void CmdSetDepthBiasEnable(VkCommandBuffer commandBuffer, int depthBiasEnable)
        {
            _vkCmdSetDepthBiasEnable_fnptr(commandBuffer, depthBiasEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state2 | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetDepthBiasEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBiasEnableEXT.html" /></remarks>
        public void CmdSetDepthBiasEnableEXT(VkCommandBuffer commandBuffer, int depthBiasEnable)
        {
            _vkCmdSetDepthBiasEnableEXT_fnptr(commandBuffer, depthBiasEnable);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBounds.html" /></remarks>
        public void CmdSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds)
        {
            _vkCmdSetDepthBounds_fnptr(commandBuffer, minDepthBounds, maxDepthBounds);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBoundsTestEnable.html" /></remarks>
        public void CmdSetDepthBoundsTestEnable(VkCommandBuffer commandBuffer, int depthBoundsTestEnable)
        {
            _vkCmdSetDepthBoundsTestEnable_fnptr(commandBuffer, depthBoundsTestEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetDepthBoundsTestEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBoundsTestEnableEXT.html" /></remarks>
        public void CmdSetDepthBoundsTestEnableEXT(VkCommandBuffer commandBuffer, int depthBoundsTestEnable)
        {
            _vkCmdSetDepthBoundsTestEnableEXT_fnptr(commandBuffer, depthBoundsTestEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClampEnableEXT.html" /></remarks>
        public void CmdSetDepthClampEnableEXT(VkCommandBuffer commandBuffer, int depthClampEnable)
        {
            _vkCmdSetDepthClampEnableEXT_fnptr(commandBuffer, depthClampEnable);
        }
        /// <summary><b>[requires: VK_EXT_shader_object | VK_EXT_depth_clamp_control]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClampRangeEXT.html" /></remarks>
        public void CmdSetDepthClampRangeEXT(VkCommandBuffer commandBuffer, VkDepthClampModeEXT depthClampMode, VkDepthClampRangeEXT* pDepthClampRange)
        {
            _vkCmdSetDepthClampRangeEXT_fnptr(commandBuffer, depthClampMode, pDepthClampRange);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClipEnableEXT.html" /></remarks>
        public void CmdSetDepthClipEnableEXT(VkCommandBuffer commandBuffer, int depthClipEnable)
        {
            _vkCmdSetDepthClipEnableEXT_fnptr(commandBuffer, depthClipEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClipNegativeOneToOneEXT.html" /></remarks>
        public void CmdSetDepthClipNegativeOneToOneEXT(VkCommandBuffer commandBuffer, int negativeOneToOne)
        {
            _vkCmdSetDepthClipNegativeOneToOneEXT_fnptr(commandBuffer, negativeOneToOne);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthCompareOp.html" /></remarks>
        public void CmdSetDepthCompareOp(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp)
        {
            _vkCmdSetDepthCompareOp_fnptr(commandBuffer, depthCompareOp);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetDepthCompareOp"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthCompareOpEXT.html" /></remarks>
        public void CmdSetDepthCompareOpEXT(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp)
        {
            _vkCmdSetDepthCompareOpEXT_fnptr(commandBuffer, depthCompareOp);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthTestEnable.html" /></remarks>
        public void CmdSetDepthTestEnable(VkCommandBuffer commandBuffer, int depthTestEnable)
        {
            _vkCmdSetDepthTestEnable_fnptr(commandBuffer, depthTestEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetDepthTestEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthTestEnableEXT.html" /></remarks>
        public void CmdSetDepthTestEnableEXT(VkCommandBuffer commandBuffer, int depthTestEnable)
        {
            _vkCmdSetDepthTestEnableEXT_fnptr(commandBuffer, depthTestEnable);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthWriteEnable.html" /></remarks>
        public void CmdSetDepthWriteEnable(VkCommandBuffer commandBuffer, int depthWriteEnable)
        {
            _vkCmdSetDepthWriteEnable_fnptr(commandBuffer, depthWriteEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetDepthWriteEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthWriteEnableEXT.html" /></remarks>
        public void CmdSetDepthWriteEnableEXT(VkCommandBuffer commandBuffer, int depthWriteEnable)
        {
            _vkCmdSetDepthWriteEnableEXT_fnptr(commandBuffer, depthWriteEnable);
        }
        /// <summary><b>[requires: VK_KHR_maintenance6]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDescriptorBufferOffsets2EXT.html" /></remarks>
        public void CmdSetDescriptorBufferOffsets2EXT(VkCommandBuffer commandBuffer, VkSetDescriptorBufferOffsetsInfoEXT* pSetDescriptorBufferOffsetsInfo)
        {
            _vkCmdSetDescriptorBufferOffsets2EXT_fnptr(commandBuffer, pSetDescriptorBufferOffsetsInfo);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDescriptorBufferOffsetsEXT.html" /></remarks>
        public void CmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, ulong* pOffsets)
        {
            _vkCmdSetDescriptorBufferOffsetsEXT_fnptr(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, pBufferIndices, pOffsets);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDeviceMask.html" /></remarks>
        public void CmdSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask)
        {
            _vkCmdSetDeviceMask_fnptr(commandBuffer, deviceMask);
        }
        /// <summary><b>[requires: VK_KHR_device_group]</b> [device command]  Alias of <see cref="CmdSetDeviceMask"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDeviceMaskKHR.html" /></remarks>
        public void CmdSetDeviceMaskKHR(VkCommandBuffer commandBuffer, uint deviceMask)
        {
            _vkCmdSetDeviceMaskKHR_fnptr(commandBuffer, deviceMask);
        }
        /// <summary><b>[requires: VK_EXT_discard_rectangles]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDiscardRectangleEnableEXT.html" /></remarks>
        public void CmdSetDiscardRectangleEnableEXT(VkCommandBuffer commandBuffer, int discardRectangleEnable)
        {
            _vkCmdSetDiscardRectangleEnableEXT_fnptr(commandBuffer, discardRectangleEnable);
        }
        /// <summary><b>[requires: VK_EXT_discard_rectangles]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDiscardRectangleEXT.html" /></remarks>
        public void CmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
        {
            _vkCmdSetDiscardRectangleEXT_fnptr(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);
        }
        /// <summary><b>[requires: VK_EXT_discard_rectangles]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetDiscardRectangleModeEXT.html" /></remarks>
        public void CmdSetDiscardRectangleModeEXT(VkCommandBuffer commandBuffer, VkDiscardRectangleModeEXT discardRectangleMode)
        {
            _vkCmdSetDiscardRectangleModeEXT_fnptr(commandBuffer, discardRectangleMode);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetEvent.html" /></remarks>
        public void CmdSetEvent(VkCommandBuffer commandBuffer, VkEvent @event, VkPipelineStageFlagBits stageMask)
        {
            _vkCmdSetEvent_fnptr(commandBuffer, @event, stageMask);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetEvent2.html" /></remarks>
        public void CmdSetEvent2(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfo* pDependencyInfo)
        {
            _vkCmdSetEvent2_fnptr(commandBuffer, @event, pDependencyInfo);
        }
        /// <summary><b>[requires: VK_KHR_synchronization2]</b> [device command]  Alias of <see cref="CmdSetEvent2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetEvent2KHR.html" /></remarks>
        public void CmdSetEvent2KHR(VkCommandBuffer commandBuffer, VkEvent @event, VkDependencyInfo* pDependencyInfo)
        {
            _vkCmdSetEvent2KHR_fnptr(commandBuffer, @event, pDependencyInfo);
        }
        /// <summary><b>[requires: VK_NV_scissor_exclusive]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetExclusiveScissorEnableNV.html" /></remarks>
        public void CmdSetExclusiveScissorEnableNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, int* pExclusiveScissorEnables)
        {
            _vkCmdSetExclusiveScissorEnableNV_fnptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissorEnables);
        }
        /// <summary><b>[requires: VK_NV_scissor_exclusive]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetExclusiveScissorNV.html" /></remarks>
        public void CmdSetExclusiveScissorNV(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
        {
            _vkCmdSetExclusiveScissorNV_fnptr(commandBuffer, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetExtraPrimitiveOverestimationSizeEXT.html" /></remarks>
        public void CmdSetExtraPrimitiveOverestimationSizeEXT(VkCommandBuffer commandBuffer, float extraPrimitiveOverestimationSize)
        {
            _vkCmdSetExtraPrimitiveOverestimationSizeEXT_fnptr(commandBuffer, extraPrimitiveOverestimationSize);
        }
        /// <summary><b>[requires: VK_NV_fragment_shading_rate_enums]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetFragmentShadingRateEnumNV.html" /></remarks>
        public void CmdSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR* combinerOps)
        {
            _vkCmdSetFragmentShadingRateEnumNV_fnptr(commandBuffer, shadingRate, combinerOps);
        }
        /// <summary><b>[requires: VK_KHR_fragment_shading_rate]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetFragmentShadingRateKHR.html" /></remarks>
        public void CmdSetFragmentShadingRateKHR(VkCommandBuffer commandBuffer, VkExtent2D* pFragmentSize, VkFragmentShadingRateCombinerOpKHR* combinerOps)
        {
            _vkCmdSetFragmentShadingRateKHR_fnptr(commandBuffer, pFragmentSize, combinerOps);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetFrontFace.html" /></remarks>
        public void CmdSetFrontFace(VkCommandBuffer commandBuffer, VkFrontFace frontFace)
        {
            _vkCmdSetFrontFace_fnptr(commandBuffer, frontFace);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetFrontFace"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetFrontFaceEXT.html" /></remarks>
        public void CmdSetFrontFaceEXT(VkCommandBuffer commandBuffer, VkFrontFace frontFace)
        {
            _vkCmdSetFrontFaceEXT_fnptr(commandBuffer, frontFace);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineRasterizationModeEXT.html" /></remarks>
        public void CmdSetLineRasterizationModeEXT(VkCommandBuffer commandBuffer, VkLineRasterizationMode lineRasterizationMode)
        {
            _vkCmdSetLineRasterizationModeEXT_fnptr(commandBuffer, lineRasterizationMode);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStipple.html" /></remarks>
        public void CmdSetLineStipple(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
        {
            _vkCmdSetLineStipple_fnptr(commandBuffer, lineStippleFactor, lineStipplePattern);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStippleEnableEXT.html" /></remarks>
        public void CmdSetLineStippleEnableEXT(VkCommandBuffer commandBuffer, int stippledLineEnable)
        {
            _vkCmdSetLineStippleEnableEXT_fnptr(commandBuffer, stippledLineEnable);
        }
        /// <summary><b>[requires: VK_EXT_line_rasterization]</b> [device command]  Alias of <see cref="CmdSetLineStipple"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStippleEXT.html" /></remarks>
        public void CmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
        {
            _vkCmdSetLineStippleEXT_fnptr(commandBuffer, lineStippleFactor, lineStipplePattern);
        }
        /// <summary><b>[requires: VK_KHR_line_rasterization]</b> [device command]  Alias of <see cref="CmdSetLineStipple"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineStippleKHR.html" /></remarks>
        public void CmdSetLineStippleKHR(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
        {
            _vkCmdSetLineStippleKHR_fnptr(commandBuffer, lineStippleFactor, lineStipplePattern);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLineWidth.html" /></remarks>
        public void CmdSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth)
        {
            _vkCmdSetLineWidth_fnptr(commandBuffer, lineWidth);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLogicOpEnableEXT.html" /></remarks>
        public void CmdSetLogicOpEnableEXT(VkCommandBuffer commandBuffer, int logicOpEnable)
        {
            _vkCmdSetLogicOpEnableEXT_fnptr(commandBuffer, logicOpEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state2 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetLogicOpEXT.html" /></remarks>
        public void CmdSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp)
        {
            _vkCmdSetLogicOpEXT_fnptr(commandBuffer, logicOp);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state2 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPatchControlPointsEXT.html" /></remarks>
        public void CmdSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, uint patchControlPoints)
        {
            _vkCmdSetPatchControlPointsEXT_fnptr(commandBuffer, patchControlPoints);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPerformanceMarkerINTEL.html" /></remarks>
        public VkResult CmdSetPerformanceMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceMarkerInfoINTEL* pMarkerInfo)
        {
            return _vkCmdSetPerformanceMarkerINTEL_fnptr(commandBuffer, pMarkerInfo);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPerformanceOverrideINTEL.html" /></remarks>
        public VkResult CmdSetPerformanceOverrideINTEL(VkCommandBuffer commandBuffer, VkPerformanceOverrideInfoINTEL* pOverrideInfo)
        {
            return _vkCmdSetPerformanceOverrideINTEL_fnptr(commandBuffer, pOverrideInfo);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPerformanceStreamMarkerINTEL.html" /></remarks>
        public VkResult CmdSetPerformanceStreamMarkerINTEL(VkCommandBuffer commandBuffer, VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo)
        {
            return _vkCmdSetPerformanceStreamMarkerINTEL_fnptr(commandBuffer, pMarkerInfo);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPolygonModeEXT.html" /></remarks>
        public void CmdSetPolygonModeEXT(VkCommandBuffer commandBuffer, VkPolygonMode polygonMode)
        {
            _vkCmdSetPolygonModeEXT_fnptr(commandBuffer, polygonMode);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveRestartEnable.html" /></remarks>
        public void CmdSetPrimitiveRestartEnable(VkCommandBuffer commandBuffer, int primitiveRestartEnable)
        {
            _vkCmdSetPrimitiveRestartEnable_fnptr(commandBuffer, primitiveRestartEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state2 | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetPrimitiveRestartEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveRestartEnableEXT.html" /></remarks>
        public void CmdSetPrimitiveRestartEnableEXT(VkCommandBuffer commandBuffer, int primitiveRestartEnable)
        {
            _vkCmdSetPrimitiveRestartEnableEXT_fnptr(commandBuffer, primitiveRestartEnable);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveTopology.html" /></remarks>
        public void CmdSetPrimitiveTopology(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology)
        {
            _vkCmdSetPrimitiveTopology_fnptr(commandBuffer, primitiveTopology);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetPrimitiveTopology"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetPrimitiveTopologyEXT.html" /></remarks>
        public void CmdSetPrimitiveTopologyEXT(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology)
        {
            _vkCmdSetPrimitiveTopologyEXT_fnptr(commandBuffer, primitiveTopology);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetProvokingVertexModeEXT.html" /></remarks>
        public void CmdSetProvokingVertexModeEXT(VkCommandBuffer commandBuffer, VkProvokingVertexModeEXT provokingVertexMode)
        {
            _vkCmdSetProvokingVertexModeEXT_fnptr(commandBuffer, provokingVertexMode);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizationSamplesEXT.html" /></remarks>
        public void CmdSetRasterizationSamplesEXT(VkCommandBuffer commandBuffer, VkSampleCountFlagBits rasterizationSamples)
        {
            _vkCmdSetRasterizationSamplesEXT_fnptr(commandBuffer, rasterizationSamples);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizationStreamEXT.html" /></remarks>
        public void CmdSetRasterizationStreamEXT(VkCommandBuffer commandBuffer, uint rasterizationStream)
        {
            _vkCmdSetRasterizationStreamEXT_fnptr(commandBuffer, rasterizationStream);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizerDiscardEnable.html" /></remarks>
        public void CmdSetRasterizerDiscardEnable(VkCommandBuffer commandBuffer, int rasterizerDiscardEnable)
        {
            _vkCmdSetRasterizerDiscardEnable_fnptr(commandBuffer, rasterizerDiscardEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state2 | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetRasterizerDiscardEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRasterizerDiscardEnableEXT.html" /></remarks>
        public void CmdSetRasterizerDiscardEnableEXT(VkCommandBuffer commandBuffer, int rasterizerDiscardEnable)
        {
            _vkCmdSetRasterizerDiscardEnableEXT_fnptr(commandBuffer, rasterizerDiscardEnable);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRayTracingPipelineStackSizeKHR.html" /></remarks>
        public void CmdSetRayTracingPipelineStackSizeKHR(VkCommandBuffer commandBuffer, uint pipelineStackSize)
        {
            _vkCmdSetRayTracingPipelineStackSizeKHR_fnptr(commandBuffer, pipelineStackSize);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingAttachmentLocations.html" /></remarks>
        public void CmdSetRenderingAttachmentLocations(VkCommandBuffer commandBuffer, VkRenderingAttachmentLocationInfo* pLocationInfo)
        {
            _vkCmdSetRenderingAttachmentLocations_fnptr(commandBuffer, pLocationInfo);
        }
        /// <summary><b>[requires: VK_KHR_dynamic_rendering_local_read]</b> [device command]  Alias of <see cref="CmdSetRenderingAttachmentLocations"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingAttachmentLocationsKHR.html" /></remarks>
        public void CmdSetRenderingAttachmentLocationsKHR(VkCommandBuffer commandBuffer, VkRenderingAttachmentLocationInfo* pLocationInfo)
        {
            _vkCmdSetRenderingAttachmentLocationsKHR_fnptr(commandBuffer, pLocationInfo);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingInputAttachmentIndices.html" /></remarks>
        public void CmdSetRenderingInputAttachmentIndices(VkCommandBuffer commandBuffer, VkRenderingInputAttachmentIndexInfo* pInputAttachmentIndexInfo)
        {
            _vkCmdSetRenderingInputAttachmentIndices_fnptr(commandBuffer, pInputAttachmentIndexInfo);
        }
        /// <summary><b>[requires: VK_KHR_dynamic_rendering_local_read]</b> [device command]  Alias of <see cref="CmdSetRenderingInputAttachmentIndices"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingInputAttachmentIndicesKHR.html" /></remarks>
        public void CmdSetRenderingInputAttachmentIndicesKHR(VkCommandBuffer commandBuffer, VkRenderingInputAttachmentIndexInfo* pInputAttachmentIndexInfo)
        {
            _vkCmdSetRenderingInputAttachmentIndicesKHR_fnptr(commandBuffer, pInputAttachmentIndexInfo);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetRepresentativeFragmentTestEnableNV.html" /></remarks>
        public void CmdSetRepresentativeFragmentTestEnableNV(VkCommandBuffer commandBuffer, int representativeFragmentTestEnable)
        {
            _vkCmdSetRepresentativeFragmentTestEnableNV_fnptr(commandBuffer, representativeFragmentTestEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleLocationsEnableEXT.html" /></remarks>
        public void CmdSetSampleLocationsEnableEXT(VkCommandBuffer commandBuffer, int sampleLocationsEnable)
        {
            _vkCmdSetSampleLocationsEnableEXT_fnptr(commandBuffer, sampleLocationsEnable);
        }
        /// <summary><b>[requires: VK_EXT_sample_locations]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleLocationsEXT.html" /></remarks>
        public void CmdSetSampleLocationsEXT(VkCommandBuffer commandBuffer, VkSampleLocationsInfoEXT* pSampleLocationsInfo)
        {
            _vkCmdSetSampleLocationsEXT_fnptr(commandBuffer, pSampleLocationsInfo);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetSampleMaskEXT.html" /></remarks>
        public void CmdSetSampleMaskEXT(VkCommandBuffer commandBuffer, VkSampleCountFlagBits samples, uint* pSampleMask)
        {
            _vkCmdSetSampleMaskEXT_fnptr(commandBuffer, samples, pSampleMask);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissor.html" /></remarks>
        public void CmdSetScissor(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors)
        {
            _vkCmdSetScissor_fnptr(commandBuffer, firstScissor, scissorCount, pScissors);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissorWithCount.html" /></remarks>
        public void CmdSetScissorWithCount(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors)
        {
            _vkCmdSetScissorWithCount_fnptr(commandBuffer, scissorCount, pScissors);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetScissorWithCount"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetScissorWithCountEXT.html" /></remarks>
        public void CmdSetScissorWithCountEXT(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors)
        {
            _vkCmdSetScissorWithCountEXT_fnptr(commandBuffer, scissorCount, pScissors);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetShadingRateImageEnableNV.html" /></remarks>
        public void CmdSetShadingRateImageEnableNV(VkCommandBuffer commandBuffer, int shadingRateImageEnable)
        {
            _vkCmdSetShadingRateImageEnableNV_fnptr(commandBuffer, shadingRateImageEnable);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilCompareMask.html" /></remarks>
        public void CmdSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, uint compareMask)
        {
            _vkCmdSetStencilCompareMask_fnptr(commandBuffer, faceMask, compareMask);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilOp.html" /></remarks>
        public void CmdSetStencilOp(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
        {
            _vkCmdSetStencilOp_fnptr(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetStencilOp"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilOpEXT.html" /></remarks>
        public void CmdSetStencilOpEXT(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
        {
            _vkCmdSetStencilOpEXT_fnptr(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilReference.html" /></remarks>
        public void CmdSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, uint reference)
        {
            _vkCmdSetStencilReference_fnptr(commandBuffer, faceMask, reference);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilTestEnable.html" /></remarks>
        public void CmdSetStencilTestEnable(VkCommandBuffer commandBuffer, int stencilTestEnable)
        {
            _vkCmdSetStencilTestEnable_fnptr(commandBuffer, stencilTestEnable);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetStencilTestEnable"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilTestEnableEXT.html" /></remarks>
        public void CmdSetStencilTestEnableEXT(VkCommandBuffer commandBuffer, int stencilTestEnable)
        {
            _vkCmdSetStencilTestEnableEXT_fnptr(commandBuffer, stencilTestEnable);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetStencilWriteMask.html" /></remarks>
        public void CmdSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlagBits faceMask, uint writeMask)
        {
            _vkCmdSetStencilWriteMask_fnptr(commandBuffer, faceMask, writeMask);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetTessellationDomainOriginEXT.html" /></remarks>
        public void CmdSetTessellationDomainOriginEXT(VkCommandBuffer commandBuffer, VkTessellationDomainOrigin domainOrigin)
        {
            _vkCmdSetTessellationDomainOriginEXT_fnptr(commandBuffer, domainOrigin);
        }
        /// <summary><b>[requires: VK_EXT_vertex_input_dynamic_state | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetVertexInputEXT.html" /></remarks>
        public void CmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
        {
            _vkCmdSetVertexInputEXT_fnptr(commandBuffer, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, pVertexAttributeDescriptions);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewport.html" /></remarks>
        public void CmdSetViewport(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports)
        {
            _vkCmdSetViewport_fnptr(commandBuffer, firstViewport, viewportCount, pViewports);
        }
        /// <summary><b>[requires: VK_NV_shading_rate_image]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportShadingRatePaletteNV.html" /></remarks>
        public void CmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
        {
            _vkCmdSetViewportShadingRatePaletteNV_fnptr(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportSwizzleNV.html" /></remarks>
        public void CmdSetViewportSwizzleNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportSwizzleNV* pViewportSwizzles)
        {
            _vkCmdSetViewportSwizzleNV_fnptr(commandBuffer, firstViewport, viewportCount, pViewportSwizzles);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWithCount.html" /></remarks>
        public void CmdSetViewportWithCount(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports)
        {
            _vkCmdSetViewportWithCount_fnptr(commandBuffer, viewportCount, pViewports);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state | VK_EXT_shader_object]</b> [device command]  Alias of <see cref="CmdSetViewportWithCount"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWithCountEXT.html" /></remarks>
        public void CmdSetViewportWithCountEXT(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports)
        {
            _vkCmdSetViewportWithCountEXT_fnptr(commandBuffer, viewportCount, pViewports);
        }
        /// <summary><b>[requires: VK_EXT_extended_dynamic_state3 | VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWScalingEnableNV.html" /></remarks>
        public void CmdSetViewportWScalingEnableNV(VkCommandBuffer commandBuffer, int viewportWScalingEnable)
        {
            _vkCmdSetViewportWScalingEnableNV_fnptr(commandBuffer, viewportWScalingEnable);
        }
        /// <summary><b>[requires: VK_NV_clip_space_w_scaling]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSetViewportWScalingNV.html" /></remarks>
        public void CmdSetViewportWScalingNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
        {
            _vkCmdSetViewportWScalingNV_fnptr(commandBuffer, firstViewport, viewportCount, pViewportWScalings);
        }
        /// <summary><b>[requires: VK_HUAWEI_subpass_shading]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdSubpassShadingHUAWEI.html" /></remarks>
        public void CmdSubpassShadingHUAWEI(VkCommandBuffer commandBuffer)
        {
            _vkCmdSubpassShadingHUAWEI_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_maintenance1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysIndirect2KHR.html" /></remarks>
        public void CmdTraceRaysIndirect2KHR(VkCommandBuffer commandBuffer, ulong indirectDeviceAddress)
        {
            _vkCmdTraceRaysIndirect2KHR_fnptr(commandBuffer, indirectDeviceAddress);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysIndirectKHR.html" /></remarks>
        public void CmdTraceRaysIndirectKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            _vkCmdTraceRaysIndirectKHR_fnptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysKHR.html" /></remarks>
        public void CmdTraceRaysKHR(VkCommandBuffer commandBuffer, VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            _vkCmdTraceRaysKHR_fnptr(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, width, height, depth);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdTraceRaysNV.html" /></remarks>
        public void CmdTraceRaysNV(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
        {
            _vkCmdTraceRaysNV_fnptr(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdUpdateBuffer.html" /></remarks>
        public void CmdUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData)
        {
            _vkCmdUpdateBuffer_fnptr(commandBuffer, dstBuffer, dstOffset, dataSize, pData);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands_compute]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdUpdatePipelineIndirectBufferNV.html" /></remarks>
        public void CmdUpdatePipelineIndirectBufferNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
        {
            _vkCmdUpdatePipelineIndirectBufferNV_fnptr(commandBuffer, pipelineBindPoint, pipeline);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWaitEvents.html" /></remarks>
        public void CmdWaitEvents(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlagBits srcStageMask, VkPipelineStageFlagBits dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
        {
            _vkCmdWaitEvents_fnptr(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWaitEvents2.html" /></remarks>
        public void CmdWaitEvents2(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfo* pDependencyInfos)
        {
            _vkCmdWaitEvents2_fnptr(commandBuffer, eventCount, pEvents, pDependencyInfos);
        }
        /// <summary><b>[requires: VK_KHR_synchronization2]</b> [device command]  Alias of <see cref="CmdWaitEvents2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWaitEvents2KHR.html" /></remarks>
        public void CmdWaitEvents2KHR(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkDependencyInfo* pDependencyInfos)
        {
            _vkCmdWaitEvents2KHR_fnptr(commandBuffer, eventCount, pEvents, pDependencyInfos);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesKHR.html" /></remarks>
        public void CmdWriteAccelerationStructuresPropertiesKHR(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            _vkCmdWriteAccelerationStructuresPropertiesKHR_fnptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesNV.html" /></remarks>
        public void CmdWriteAccelerationStructuresPropertiesNV(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            _vkCmdWriteAccelerationStructuresPropertiesNV_fnptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
        /// <summary><b>[requires: VK_AMD_buffer_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteBufferMarker2AMD.html" /></remarks>
        public void CmdWriteBufferMarker2AMD(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits2 stage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
        {
            _vkCmdWriteBufferMarker2AMD_fnptr(commandBuffer, stage, dstBuffer, dstOffset, marker);
        }
        /// <summary><b>[requires: VK_AMD_buffer_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteBufferMarkerAMD.html" /></remarks>
        public void CmdWriteBufferMarkerAMD(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
        {
            _vkCmdWriteBufferMarkerAMD_fnptr(commandBuffer, pipelineStage, dstBuffer, dstOffset, marker);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteMicromapsPropertiesEXT.html" /></remarks>
        public void CmdWriteMicromapsPropertiesEXT(VkCommandBuffer commandBuffer, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            _vkCmdWriteMicromapsPropertiesEXT_fnptr(commandBuffer, micromapCount, pMicromaps, queryType, queryPool, firstQuery);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp.html" /></remarks>
        public void CmdWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint query)
        {
            _vkCmdWriteTimestamp_fnptr(commandBuffer, pipelineStage, queryPool, query);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp2.html" /></remarks>
        public void CmdWriteTimestamp2(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits2 stage, VkQueryPool queryPool, uint query)
        {
            _vkCmdWriteTimestamp2_fnptr(commandBuffer, stage, queryPool, query);
        }
        /// <summary><b>[requires: VK_KHR_synchronization2]</b> [device command]  Alias of <see cref="CmdWriteTimestamp2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCmdWriteTimestamp2KHR.html" /></remarks>
        public void CmdWriteTimestamp2KHR(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits2 stage, VkQueryPool queryPool, uint query)
        {
            _vkCmdWriteTimestamp2KHR_fnptr(commandBuffer, stage, queryPool, query);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCompileDeferredNV.html" /></remarks>
        public VkResult CompileDeferredNV(VkDevice device, VkPipeline pipeline, uint shader)
        {
            return _vkCompileDeferredNV_fnptr(device, pipeline, shader);
        }
        /// <summary><b>[requires: VK_NV_cooperative_vector]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkConvertCooperativeVectorMatrixNV.html" /></remarks>
        public VkResult ConvertCooperativeVectorMatrixNV(VkDevice device, VkConvertCooperativeVectorMatrixInfoNV* pInfo)
        {
            return _vkConvertCooperativeVectorMatrixNV_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyAccelerationStructureKHR.html" /></remarks>
        public VkResult CopyAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureInfoKHR* pInfo)
        {
            return _vkCopyAccelerationStructureKHR_fnptr(device, deferredOperation, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyAccelerationStructureToMemoryKHR.html" /></remarks>
        public VkResult CopyAccelerationStructureToMemoryKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyAccelerationStructureToMemoryInfoKHR* pInfo)
        {
            return _vkCopyAccelerationStructureToMemoryKHR_fnptr(device, deferredOperation, pInfo);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyImageToImage.html" /></remarks>
        public VkResult CopyImageToImage(VkDevice device, VkCopyImageToImageInfo* pCopyImageToImageInfo)
        {
            return _vkCopyImageToImage_fnptr(device, pCopyImageToImageInfo);
        }
        /// <summary><b>[requires: VK_EXT_host_image_copy]</b> [device command]  Alias of <see cref="CopyImageToImage"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyImageToImageEXT.html" /></remarks>
        public VkResult CopyImageToImageEXT(VkDevice device, VkCopyImageToImageInfo* pCopyImageToImageInfo)
        {
            return _vkCopyImageToImageEXT_fnptr(device, pCopyImageToImageInfo);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyImageToMemory.html" /></remarks>
        public VkResult CopyImageToMemory(VkDevice device, VkCopyImageToMemoryInfo* pCopyImageToMemoryInfo)
        {
            return _vkCopyImageToMemory_fnptr(device, pCopyImageToMemoryInfo);
        }
        /// <summary><b>[requires: VK_EXT_host_image_copy]</b> [device command]  Alias of <see cref="CopyImageToMemory"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyImageToMemoryEXT.html" /></remarks>
        public VkResult CopyImageToMemoryEXT(VkDevice device, VkCopyImageToMemoryInfo* pCopyImageToMemoryInfo)
        {
            return _vkCopyImageToMemoryEXT_fnptr(device, pCopyImageToMemoryInfo);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToAccelerationStructureKHR.html" /></remarks>
        public VkResult CopyMemoryToAccelerationStructureKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToAccelerationStructureInfoKHR* pInfo)
        {
            return _vkCopyMemoryToAccelerationStructureKHR_fnptr(device, deferredOperation, pInfo);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToImage.html" /></remarks>
        public VkResult CopyMemoryToImage(VkDevice device, VkCopyMemoryToImageInfo* pCopyMemoryToImageInfo)
        {
            return _vkCopyMemoryToImage_fnptr(device, pCopyMemoryToImageInfo);
        }
        /// <summary><b>[requires: VK_EXT_host_image_copy]</b> [device command]  Alias of <see cref="CopyMemoryToImage"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToImageEXT.html" /></remarks>
        public VkResult CopyMemoryToImageEXT(VkDevice device, VkCopyMemoryToImageInfo* pCopyMemoryToImageInfo)
        {
            return _vkCopyMemoryToImageEXT_fnptr(device, pCopyMemoryToImageInfo);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyMemoryToMicromapEXT.html" /></remarks>
        public VkResult CopyMemoryToMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMemoryToMicromapInfoEXT* pInfo)
        {
            return _vkCopyMemoryToMicromapEXT_fnptr(device, deferredOperation, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyMicromapEXT.html" /></remarks>
        public VkResult CopyMicromapEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapInfoEXT* pInfo)
        {
            return _vkCopyMicromapEXT_fnptr(device, deferredOperation, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCopyMicromapToMemoryEXT.html" /></remarks>
        public VkResult CopyMicromapToMemoryEXT(VkDevice device, VkDeferredOperationKHR deferredOperation, VkCopyMicromapToMemoryInfoEXT* pInfo)
        {
            return _vkCopyMicromapToMemoryEXT_fnptr(device, deferredOperation, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateAccelerationStructureKHR.html" /></remarks>
        public VkResult CreateAccelerationStructureKHR(VkDevice device, VkAccelerationStructureCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureKHR* pAccelerationStructure)
        {
            return _vkCreateAccelerationStructureKHR_fnptr(device, pCreateInfo, pAllocator, pAccelerationStructure);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateAccelerationStructureNV.html" /></remarks>
        public VkResult CreateAccelerationStructureNV(VkDevice device, VkAccelerationStructureCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkAccelerationStructureNV* pAccelerationStructure)
        {
            return _vkCreateAccelerationStructureNV_fnptr(device, pCreateInfo, pAllocator, pAccelerationStructure);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateBuffer.html" /></remarks>
        public VkResult CreateBuffer(VkDevice device, VkBufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer)
        {
            return _vkCreateBuffer_fnptr(device, pCreateInfo, pAllocator, pBuffer);
        }
        /// <summary><b>[requires: VK_FUCHSIA_buffer_collection]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateBufferCollectionFUCHSIA.html" /></remarks>
        public VkResult CreateBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionCreateInfoFUCHSIA* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferCollectionFUCHSIA* pCollection)
        {
            return _vkCreateBufferCollectionFUCHSIA_fnptr(device, pCreateInfo, pAllocator, pCollection);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateBufferView.html" /></remarks>
        public VkResult CreateBufferView(VkDevice device, VkBufferViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkBufferView* pView)
        {
            return _vkCreateBufferView_fnptr(device, pCreateInfo, pAllocator, pView);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateCommandPool.html" /></remarks>
        public VkResult CreateCommandPool(VkDevice device, VkCommandPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool)
        {
            return _vkCreateCommandPool_fnptr(device, pCreateInfo, pAllocator, pCommandPool);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateComputePipelines.html" /></remarks>
        public VkResult CreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return _vkCreateComputePipelines_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        /// <summary><b>[requires: VK_NV_cuda_kernel_launch]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateCudaFunctionNV.html" /></remarks>
        public VkResult CreateCudaFunctionNV(VkDevice device, VkCudaFunctionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCudaFunctionNV* pFunction)
        {
            return _vkCreateCudaFunctionNV_fnptr(device, pCreateInfo, pAllocator, pFunction);
        }
        /// <summary><b>[requires: VK_NV_cuda_kernel_launch]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateCudaModuleNV.html" /></remarks>
        public VkResult CreateCudaModuleNV(VkDevice device, VkCudaModuleCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCudaModuleNV* pModule)
        {
            return _vkCreateCudaModuleNV_fnptr(device, pCreateInfo, pAllocator, pModule);
        }
        /// <summary><b>[requires: VK_NVX_binary_import]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateCuFunctionNVX.html" /></remarks>
        public VkResult CreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
        {
            return _vkCreateCuFunctionNVX_fnptr(device, pCreateInfo, pAllocator, pFunction);
        }
        /// <summary><b>[requires: VK_NVX_binary_import]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateCuModuleNVX.html" /></remarks>
        public VkResult CreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
        {
            return _vkCreateCuModuleNVX_fnptr(device, pCreateInfo, pAllocator, pModule);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDataGraphPipelinesARM.html" /></remarks>
        public VkResult CreateDataGraphPipelinesARM(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkDataGraphPipelineCreateInfoARM* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return _vkCreateDataGraphPipelinesARM_fnptr(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDataGraphPipelineSessionARM.html" /></remarks>
        public VkResult CreateDataGraphPipelineSessionARM(VkDevice device, VkDataGraphPipelineSessionCreateInfoARM* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDataGraphPipelineSessionARM* pSession)
        {
            return _vkCreateDataGraphPipelineSessionARM_fnptr(device, pCreateInfo, pAllocator, pSession);
        }
        /// <summary><b>[requires: VK_KHR_deferred_host_operations]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDeferredOperationKHR.html" /></remarks>
        public VkResult CreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation)
        {
            return _vkCreateDeferredOperationKHR_fnptr(device, pAllocator, pDeferredOperation);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorPool.html" /></remarks>
        public VkResult CreateDescriptorPool(VkDevice device, VkDescriptorPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool)
        {
            return _vkCreateDescriptorPool_fnptr(device, pCreateInfo, pAllocator, pDescriptorPool);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorSetLayout.html" /></remarks>
        public VkResult CreateDescriptorSetLayout(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout)
        {
            return _vkCreateDescriptorSetLayout_fnptr(device, pCreateInfo, pAllocator, pSetLayout);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorUpdateTemplate.html" /></remarks>
        public VkResult CreateDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate)
        {
            return _vkCreateDescriptorUpdateTemplate_fnptr(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
        }
        /// <summary><b>[requires: VK_KHR_descriptor_update_template]</b> [device command]  Alias of <see cref="CreateDescriptorUpdateTemplate"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorUpdateTemplateKHR.html" /></remarks>
        public VkResult CreateDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplateCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkDescriptorUpdateTemplate* pDescriptorUpdateTemplate)
        {
            return _vkCreateDescriptorUpdateTemplateKHR_fnptr(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateEvent.html" /></remarks>
        public VkResult CreateEvent(VkDevice device, VkEventCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkEvent* pEvent)
        {
            return _vkCreateEvent_fnptr(device, pCreateInfo, pAllocator, pEvent);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateExecutionGraphPipelinesAMDX.html" /></remarks>
        public VkResult CreateExecutionGraphPipelinesAMDX(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return _vkCreateExecutionGraphPipelinesAMDX_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        /// <summary><b>[requires: VK_NV_external_compute_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateExternalComputeQueueNV.html" /></remarks>
        public VkResult CreateExternalComputeQueueNV(VkDevice device, VkExternalComputeQueueCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkExternalComputeQueueNV* pExternalQueue)
        {
            return _vkCreateExternalComputeQueueNV_fnptr(device, pCreateInfo, pAllocator, pExternalQueue);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateFence.html" /></remarks>
        public VkResult CreateFence(VkDevice device, VkFenceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            return _vkCreateFence_fnptr(device, pCreateInfo, pAllocator, pFence);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateFramebuffer.html" /></remarks>
        public VkResult CreateFramebuffer(VkDevice device, VkFramebufferCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer)
        {
            return _vkCreateFramebuffer_fnptr(device, pCreateInfo, pAllocator, pFramebuffer);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateGraphicsPipelines.html" /></remarks>
        public VkResult CreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return _vkCreateGraphicsPipelines_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateImage.html" /></remarks>
        public VkResult CreateImage(VkDevice device, VkImageCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImage* pImage)
        {
            return _vkCreateImage_fnptr(device, pCreateInfo, pAllocator, pImage);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateImageView.html" /></remarks>
        public VkResult CreateImageView(VkDevice device, VkImageViewCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkImageView* pView)
        {
            return _vkCreateImageView_fnptr(device, pCreateInfo, pAllocator, pView);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateIndirectCommandsLayoutEXT.html" /></remarks>
        public VkResult CreateIndirectCommandsLayoutEXT(VkDevice device, VkIndirectCommandsLayoutCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutEXT* pIndirectCommandsLayout)
        {
            return _vkCreateIndirectCommandsLayoutEXT_fnptr(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateIndirectCommandsLayoutNV.html" /></remarks>
        public VkResult CreateIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectCommandsLayoutNV* pIndirectCommandsLayout)
        {
            return _vkCreateIndirectCommandsLayoutNV_fnptr(device, pCreateInfo, pAllocator, pIndirectCommandsLayout);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateIndirectExecutionSetEXT.html" /></remarks>
        public VkResult CreateIndirectExecutionSetEXT(VkDevice device, VkIndirectExecutionSetCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkIndirectExecutionSetEXT* pIndirectExecutionSet)
        {
            return _vkCreateIndirectExecutionSetEXT_fnptr(device, pCreateInfo, pAllocator, pIndirectExecutionSet);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateMicromapEXT.html" /></remarks>
        public VkResult CreateMicromapEXT(VkDevice device, VkMicromapCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkMicromapEXT* pMicromap)
        {
            return _vkCreateMicromapEXT_fnptr(device, pCreateInfo, pAllocator, pMicromap);
        }
        /// <summary><b>[requires: VK_NV_optical_flow]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateOpticalFlowSessionNV.html" /></remarks>
        public VkResult CreateOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkOpticalFlowSessionNV* pSession)
        {
            return _vkCreateOpticalFlowSessionNV_fnptr(device, pCreateInfo, pAllocator, pSession);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_binary]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineBinariesKHR.html" /></remarks>
        public VkResult CreatePipelineBinariesKHR(VkDevice device, VkPipelineBinaryCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineBinaryHandlesInfoKHR* pBinaries)
        {
            return _vkCreatePipelineBinariesKHR_fnptr(device, pCreateInfo, pAllocator, pBinaries);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineCache.html" /></remarks>
        public VkResult CreatePipelineCache(VkDevice device, VkPipelineCacheCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache)
        {
            return _vkCreatePipelineCache_fnptr(device, pCreateInfo, pAllocator, pPipelineCache);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreatePipelineLayout.html" /></remarks>
        public VkResult CreatePipelineLayout(VkDevice device, VkPipelineLayoutCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout)
        {
            return _vkCreatePipelineLayout_fnptr(device, pCreateInfo, pAllocator, pPipelineLayout);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreatePrivateDataSlot.html" /></remarks>
        public VkResult CreatePrivateDataSlot(VkDevice device, VkPrivateDataSlotCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlot* pPrivateDataSlot)
        {
            return _vkCreatePrivateDataSlot_fnptr(device, pCreateInfo, pAllocator, pPrivateDataSlot);
        }
        /// <summary><b>[requires: VK_EXT_private_data]</b> [device command]  Alias of <see cref="CreatePrivateDataSlot"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreatePrivateDataSlotEXT.html" /></remarks>
        public VkResult CreatePrivateDataSlotEXT(VkDevice device, VkPrivateDataSlotCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlot* pPrivateDataSlot)
        {
            return _vkCreatePrivateDataSlotEXT_fnptr(device, pCreateInfo, pAllocator, pPrivateDataSlot);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateQueryPool.html" /></remarks>
        public VkResult CreateQueryPool(VkDevice device, VkQueryPoolCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool)
        {
            return _vkCreateQueryPool_fnptr(device, pCreateInfo, pAllocator, pQueryPool);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateRayTracingPipelinesKHR.html" /></remarks>
        public VkResult CreateRayTracingPipelinesKHR(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return _vkCreateRayTracingPipelinesKHR_fnptr(device, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateRayTracingPipelinesNV.html" /></remarks>
        public VkResult CreateRayTracingPipelinesNV(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines)
        {
            return _vkCreateRayTracingPipelinesNV_fnptr(device, pipelineCache, createInfoCount, pCreateInfos, pAllocator, pPipelines);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateRenderPass.html" /></remarks>
        public VkResult CreateRenderPass(VkDevice device, VkRenderPassCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
        {
            return _vkCreateRenderPass_fnptr(device, pCreateInfo, pAllocator, pRenderPass);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateRenderPass2.html" /></remarks>
        public VkResult CreateRenderPass2(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
        {
            return _vkCreateRenderPass2_fnptr(device, pCreateInfo, pAllocator, pRenderPass);
        }
        /// <summary><b>[requires: VK_KHR_create_renderpass2]</b> [device command]  Alias of <see cref="CreateRenderPass2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateRenderPass2KHR.html" /></remarks>
        public VkResult CreateRenderPass2KHR(VkDevice device, VkRenderPassCreateInfo2* pCreateInfo, VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass)
        {
            return _vkCreateRenderPass2KHR_fnptr(device, pCreateInfo, pAllocator, pRenderPass);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSampler.html" /></remarks>
        public VkResult CreateSampler(VkDevice device, VkSamplerCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSampler* pSampler)
        {
            return _vkCreateSampler_fnptr(device, pCreateInfo, pAllocator, pSampler);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSamplerYcbcrConversion.html" /></remarks>
        public VkResult CreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion)
        {
            return _vkCreateSamplerYcbcrConversion_fnptr(device, pCreateInfo, pAllocator, pYcbcrConversion);
        }
        /// <summary><b>[requires: VK_KHR_sampler_ycbcr_conversion]</b> [device command]  Alias of <see cref="CreateSamplerYcbcrConversion"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSamplerYcbcrConversionKHR.html" /></remarks>
        public VkResult CreateSamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion)
        {
            return _vkCreateSamplerYcbcrConversionKHR_fnptr(device, pCreateInfo, pAllocator, pYcbcrConversion);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSemaphore.html" /></remarks>
        public VkResult CreateSemaphore(VkDevice device, VkSemaphoreCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore)
        {
            return _vkCreateSemaphore_fnptr(device, pCreateInfo, pAllocator, pSemaphore);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSemaphoreSciSyncPoolNV.html" /></remarks>
        public VkResult CreateSemaphoreSciSyncPoolNV(VkDevice device, VkSemaphoreSciSyncPoolCreateInfoNV* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSemaphoreSciSyncPoolNV* pSemaphorePool)
        {
            return _vkCreateSemaphoreSciSyncPoolNV_fnptr(device, pCreateInfo, pAllocator, pSemaphorePool);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateShaderModule.html" /></remarks>
        public VkResult CreateShaderModule(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule)
        {
            return _vkCreateShaderModule_fnptr(device, pCreateInfo, pAllocator, pShaderModule);
        }
        /// <summary><b>[requires: VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateShadersEXT.html" /></remarks>
        public VkResult CreateShadersEXT(VkDevice device, uint createInfoCount, VkShaderCreateInfoEXT* pCreateInfos, VkAllocationCallbacks* pAllocator, VkShaderEXT* pShaders)
        {
            return _vkCreateShadersEXT_fnptr(device, createInfoCount, pCreateInfos, pAllocator, pShaders);
        }
        /// <summary><b>[requires: VK_KHR_display_swapchain]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSharedSwapchainsKHR.html" /></remarks>
        public VkResult CreateSharedSwapchainsKHR(VkDevice device, uint swapchainCount, VkSwapchainCreateInfoKHR* pCreateInfos, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchains)
        {
            return _vkCreateSharedSwapchainsKHR_fnptr(device, swapchainCount, pCreateInfos, pAllocator, pSwapchains);
        }
        /// <summary><b>[requires: VK_KHR_swapchain]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateSwapchainKHR.html" /></remarks>
        public VkResult CreateSwapchainKHR(VkDevice device, VkSwapchainCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSwapchainKHR* pSwapchain)
        {
            return _vkCreateSwapchainKHR_fnptr(device, pCreateInfo, pAllocator, pSwapchain);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateTensorARM.html" /></remarks>
        public VkResult CreateTensorARM(VkDevice device, VkTensorCreateInfoARM* pCreateInfo, VkAllocationCallbacks* pAllocator, VkTensorARM* pTensor)
        {
            return _vkCreateTensorARM_fnptr(device, pCreateInfo, pAllocator, pTensor);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateTensorViewARM.html" /></remarks>
        public VkResult CreateTensorViewARM(VkDevice device, VkTensorViewCreateInfoARM* pCreateInfo, VkAllocationCallbacks* pAllocator, VkTensorViewARM* pView)
        {
            return _vkCreateTensorViewARM_fnptr(device, pCreateInfo, pAllocator, pView);
        }
        /// <summary><b>[requires: VK_EXT_validation_cache]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateValidationCacheEXT.html" /></remarks>
        public VkResult CreateValidationCacheEXT(VkDevice device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, VkValidationCacheEXT* pValidationCache)
        {
            return _vkCreateValidationCacheEXT_fnptr(device, pCreateInfo, pAllocator, pValidationCache);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateVideoSessionKHR.html" /></remarks>
        public VkResult CreateVideoSessionKHR(VkDevice device, VkVideoSessionCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionKHR* pVideoSession)
        {
            return _vkCreateVideoSessionKHR_fnptr(device, pCreateInfo, pAllocator, pVideoSession);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateVideoSessionParametersKHR.html" /></remarks>
        public VkResult CreateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersCreateInfoKHR* pCreateInfo, VkAllocationCallbacks* pAllocator, VkVideoSessionParametersKHR* pVideoSessionParameters)
        {
            return _vkCreateVideoSessionParametersKHR_fnptr(device, pCreateInfo, pAllocator, pVideoSessionParameters);
        }
        /// <summary><b>[requires: VK_EXT_debug_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDebugMarkerSetObjectNameEXT.html" /></remarks>
        public VkResult DebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)
        {
            return _vkDebugMarkerSetObjectNameEXT_fnptr(device, pNameInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_marker]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDebugMarkerSetObjectTagEXT.html" /></remarks>
        public VkResult DebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)
        {
            return _vkDebugMarkerSetObjectTagEXT_fnptr(device, pTagInfo);
        }
        /// <summary><b>[requires: VK_KHR_deferred_host_operations]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDeferredOperationJoinKHR.html" /></remarks>
        public VkResult DeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation)
        {
            return _vkDeferredOperationJoinKHR_fnptr(device, operation);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyAccelerationStructureKHR.html" /></remarks>
        public void DestroyAccelerationStructureKHR(VkDevice device, VkAccelerationStructureKHR accelerationStructure, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyAccelerationStructureKHR_fnptr(device, accelerationStructure, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyAccelerationStructureNV.html" /></remarks>
        public void DestroyAccelerationStructureNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyAccelerationStructureNV_fnptr(device, accelerationStructure, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyBuffer.html" /></remarks>
        public void DestroyBuffer(VkDevice device, VkBuffer buffer, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyBuffer_fnptr(device, buffer, pAllocator);
        }
        /// <summary><b>[requires: VK_FUCHSIA_buffer_collection]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyBufferCollectionFUCHSIA.html" /></remarks>
        public void DestroyBufferCollectionFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyBufferCollectionFUCHSIA_fnptr(device, collection, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyBufferView.html" /></remarks>
        public void DestroyBufferView(VkDevice device, VkBufferView bufferView, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyBufferView_fnptr(device, bufferView, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyCommandPool.html" /></remarks>
        public void DestroyCommandPool(VkDevice device, VkCommandPool commandPool, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyCommandPool_fnptr(device, commandPool, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_cuda_kernel_launch]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyCudaFunctionNV.html" /></remarks>
        public void DestroyCudaFunctionNV(VkDevice device, VkCudaFunctionNV function, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyCudaFunctionNV_fnptr(device, function, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_cuda_kernel_launch]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyCudaModuleNV.html" /></remarks>
        public void DestroyCudaModuleNV(VkDevice device, VkCudaModuleNV module, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyCudaModuleNV_fnptr(device, module, pAllocator);
        }
        /// <summary><b>[requires: VK_NVX_binary_import]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyCuFunctionNVX.html" /></remarks>
        public void DestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyCuFunctionNVX_fnptr(device, function, pAllocator);
        }
        /// <summary><b>[requires: VK_NVX_binary_import]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyCuModuleNVX.html" /></remarks>
        public void DestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyCuModuleNVX_fnptr(device, module, pAllocator);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDataGraphPipelineSessionARM.html" /></remarks>
        public void DestroyDataGraphPipelineSessionARM(VkDevice device, VkDataGraphPipelineSessionARM session, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDataGraphPipelineSessionARM_fnptr(device, session, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_deferred_host_operations]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDeferredOperationKHR.html" /></remarks>
        public void DestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDeferredOperationKHR_fnptr(device, operation, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorPool.html" /></remarks>
        public void DestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDescriptorPool_fnptr(device, descriptorPool, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorSetLayout.html" /></remarks>
        public void DestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDescriptorSetLayout_fnptr(device, descriptorSetLayout, pAllocator);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorUpdateTemplate.html" /></remarks>
        public void DestroyDescriptorUpdateTemplate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDescriptorUpdateTemplate_fnptr(device, descriptorUpdateTemplate, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_descriptor_update_template]</b> [device command]  Alias of <see cref="DestroyDescriptorUpdateTemplate"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorUpdateTemplateKHR.html" /></remarks>
        public void DestroyDescriptorUpdateTemplateKHR(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDescriptorUpdateTemplateKHR_fnptr(device, descriptorUpdateTemplate, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDevice.html" /></remarks>
        public void DestroyDevice(VkDevice device, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyDevice_fnptr(device, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyEvent.html" /></remarks>
        public void DestroyEvent(VkDevice device, VkEvent @event, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyEvent_fnptr(device, @event, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_external_compute_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyExternalComputeQueueNV.html" /></remarks>
        public void DestroyExternalComputeQueueNV(VkDevice device, VkExternalComputeQueueNV externalQueue, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyExternalComputeQueueNV_fnptr(device, externalQueue, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyFence.html" /></remarks>
        public void DestroyFence(VkDevice device, VkFence fence, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyFence_fnptr(device, fence, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyFramebuffer.html" /></remarks>
        public void DestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyFramebuffer_fnptr(device, framebuffer, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyImage.html" /></remarks>
        public void DestroyImage(VkDevice device, VkImage image, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyImage_fnptr(device, image, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyImageView.html" /></remarks>
        public void DestroyImageView(VkDevice device, VkImageView imageView, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyImageView_fnptr(device, imageView, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyIndirectCommandsLayoutEXT.html" /></remarks>
        public void DestroyIndirectCommandsLayoutEXT(VkDevice device, VkIndirectCommandsLayoutEXT indirectCommandsLayout, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyIndirectCommandsLayoutEXT_fnptr(device, indirectCommandsLayout, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyIndirectCommandsLayoutNV.html" /></remarks>
        public void DestroyIndirectCommandsLayoutNV(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyIndirectCommandsLayoutNV_fnptr(device, indirectCommandsLayout, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyIndirectExecutionSetEXT.html" /></remarks>
        public void DestroyIndirectExecutionSetEXT(VkDevice device, VkIndirectExecutionSetEXT indirectExecutionSet, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyIndirectExecutionSetEXT_fnptr(device, indirectExecutionSet, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyMicromapEXT.html" /></remarks>
        public void DestroyMicromapEXT(VkDevice device, VkMicromapEXT micromap, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyMicromapEXT_fnptr(device, micromap, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_optical_flow]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyOpticalFlowSessionNV.html" /></remarks>
        public void DestroyOpticalFlowSessionNV(VkDevice device, VkOpticalFlowSessionNV session, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyOpticalFlowSessionNV_fnptr(device, session, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyPipeline.html" /></remarks>
        public void DestroyPipeline(VkDevice device, VkPipeline pipeline, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyPipeline_fnptr(device, pipeline, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_binary]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyPipelineBinaryKHR.html" /></remarks>
        public void DestroyPipelineBinaryKHR(VkDevice device, VkPipelineBinaryKHR pipelineBinary, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyPipelineBinaryKHR_fnptr(device, pipelineBinary, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyPipelineCache.html" /></remarks>
        public void DestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyPipelineCache_fnptr(device, pipelineCache, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyPipelineLayout.html" /></remarks>
        public void DestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyPipelineLayout_fnptr(device, pipelineLayout, pAllocator);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyPrivateDataSlot.html" /></remarks>
        public void DestroyPrivateDataSlot(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyPrivateDataSlot_fnptr(device, privateDataSlot, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_private_data]</b> [device command]  Alias of <see cref="DestroyPrivateDataSlot"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyPrivateDataSlotEXT.html" /></remarks>
        public void DestroyPrivateDataSlotEXT(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyPrivateDataSlotEXT_fnptr(device, privateDataSlot, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyQueryPool.html" /></remarks>
        public void DestroyQueryPool(VkDevice device, VkQueryPool queryPool, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyQueryPool_fnptr(device, queryPool, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyRenderPass.html" /></remarks>
        public void DestroyRenderPass(VkDevice device, VkRenderPass renderPass, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyRenderPass_fnptr(device, renderPass, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySampler.html" /></remarks>
        public void DestroySampler(VkDevice device, VkSampler sampler, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySampler_fnptr(device, sampler, pAllocator);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySamplerYcbcrConversion.html" /></remarks>
        public void DestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySamplerYcbcrConversion_fnptr(device, ycbcrConversion, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_sampler_ycbcr_conversion]</b> [device command]  Alias of <see cref="DestroySamplerYcbcrConversion"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySamplerYcbcrConversionKHR.html" /></remarks>
        public void DestroySamplerYcbcrConversionKHR(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySamplerYcbcrConversionKHR_fnptr(device, ycbcrConversion, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySemaphore.html" /></remarks>
        public void DestroySemaphore(VkDevice device, VkSemaphore semaphore, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySemaphore_fnptr(device, semaphore, pAllocator);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySemaphoreSciSyncPoolNV.html" /></remarks>
        public void DestroySemaphoreSciSyncPoolNV(VkDevice device, VkSemaphoreSciSyncPoolNV semaphorePool, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySemaphoreSciSyncPoolNV_fnptr(device, semaphorePool, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyShaderEXT.html" /></remarks>
        public void DestroyShaderEXT(VkDevice device, VkShaderEXT shader, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyShaderEXT_fnptr(device, shader, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyShaderModule.html" /></remarks>
        public void DestroyShaderModule(VkDevice device, VkShaderModule shaderModule, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyShaderModule_fnptr(device, shaderModule, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_swapchain]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySwapchainKHR.html" /></remarks>
        public void DestroySwapchainKHR(VkDevice device, VkSwapchainKHR swapchain, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroySwapchainKHR_fnptr(device, swapchain, pAllocator);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyTensorARM.html" /></remarks>
        public void DestroyTensorARM(VkDevice device, VkTensorARM tensor, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyTensorARM_fnptr(device, tensor, pAllocator);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyTensorViewARM.html" /></remarks>
        public void DestroyTensorViewARM(VkDevice device, VkTensorViewARM tensorView, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyTensorViewARM_fnptr(device, tensorView, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_validation_cache]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyValidationCacheEXT.html" /></remarks>
        public void DestroyValidationCacheEXT(VkDevice device, VkValidationCacheEXT validationCache, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyValidationCacheEXT_fnptr(device, validationCache, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyVideoSessionKHR.html" /></remarks>
        public void DestroyVideoSessionKHR(VkDevice device, VkVideoSessionKHR videoSession, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyVideoSessionKHR_fnptr(device, videoSession, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyVideoSessionParametersKHR.html" /></remarks>
        public void DestroyVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkAllocationCallbacks* pAllocator)
        {
            _vkDestroyVideoSessionParametersKHR_fnptr(device, videoSessionParameters, pAllocator);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDeviceWaitIdle.html" /></remarks>
        public VkResult DeviceWaitIdle(VkDevice device)
        {
            return _vkDeviceWaitIdle_fnptr(device);
        }
        /// <summary><b>[requires: VK_EXT_display_control]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDisplayPowerControlEXT.html" /></remarks>
        public VkResult DisplayPowerControlEXT(VkDevice device, VkDisplayKHR display, VkDisplayPowerInfoEXT* pDisplayPowerInfo)
        {
            return _vkDisplayPowerControlEXT_fnptr(device, display, pDisplayPowerInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEndCommandBuffer.html" /></remarks>
        public VkResult EndCommandBuffer(VkCommandBuffer commandBuffer)
        {
            return _vkEndCommandBuffer_fnptr(commandBuffer);
        }
        /// <summary><b>[requires: VK_EXT_metal_objects]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkExportMetalObjectsEXT.html" /></remarks>
        public void ExportMetalObjectsEXT(VkDevice device, VkExportMetalObjectsInfoEXT* pMetalObjectsInfo)
        {
            _vkExportMetalObjectsEXT_fnptr(device, pMetalObjectsInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkFlushMappedMemoryRanges.html" /></remarks>
        public VkResult FlushMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
        {
            return _vkFlushMappedMemoryRanges_fnptr(device, memoryRangeCount, pMemoryRanges);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkFreeCommandBuffers.html" /></remarks>
        public void FreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
        {
            _vkFreeCommandBuffers_fnptr(device, commandPool, commandBufferCount, pCommandBuffers);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkFreeDescriptorSets.html" /></remarks>
        public VkResult FreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets)
        {
            return _vkFreeDescriptorSets_fnptr(device, descriptorPool, descriptorSetCount, pDescriptorSets);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkFreeMemory.html" /></remarks>
        public void FreeMemory(VkDevice device, VkDeviceMemory memory, VkAllocationCallbacks* pAllocator)
        {
            _vkFreeMemory_fnptr(device, memory, pAllocator);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureBuildSizesKHR.html" /></remarks>
        public void GetAccelerationStructureBuildSizesKHR(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            _vkGetAccelerationStructureBuildSizesKHR_fnptr(device, buildType, pBuildInfo, pMaxPrimitiveCounts, pSizeInfo);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureDeviceAddressKHR.html" /></remarks>
        public ulong GetAccelerationStructureDeviceAddressKHR(VkDevice device, VkAccelerationStructureDeviceAddressInfoKHR* pInfo)
        {
            return _vkGetAccelerationStructureDeviceAddressKHR_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureHandleNV.html" /></remarks>
        public VkResult GetAccelerationStructureHandleNV(VkDevice device, VkAccelerationStructureNV accelerationStructure, nuint dataSize, void* pData)
        {
            return _vkGetAccelerationStructureHandleNV_fnptr(device, accelerationStructure, dataSize, pData);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureMemoryRequirementsNV.html" /></remarks>
        public void GetAccelerationStructureMemoryRequirementsNV(VkDevice device, VkAccelerationStructureMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetAccelerationStructureMemoryRequirementsNV_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT.html" /></remarks>
        public VkResult GetAccelerationStructureOpaqueCaptureDescriptorDataEXT(VkDevice device, VkAccelerationStructureCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return _vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: VK_ANDROID_external_memory_android_hardware_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAndroidHardwareBufferPropertiesANDROID.html" /></remarks>
        public VkResult GetAndroidHardwareBufferPropertiesANDROID(VkDevice device, IntPtr buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
        {
            return _vkGetAndroidHardwareBufferPropertiesANDROID_fnptr(device, buffer, pProperties);
        }
        /// <summary><b>[requires: VK_FUCHSIA_buffer_collection]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferCollectionPropertiesFUCHSIA.html" /></remarks>
        public VkResult GetBufferCollectionPropertiesFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferCollectionPropertiesFUCHSIA* pProperties)
        {
            return _vkGetBufferCollectionPropertiesFUCHSIA_fnptr(device, collection, pProperties);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddress.html" /></remarks>
        public ulong GetBufferDeviceAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            return _vkGetBufferDeviceAddress_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_buffer_device_address]</b> [device command]  Alias of <see cref="GetBufferDeviceAddress"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddressEXT.html" /></remarks>
        public ulong GetBufferDeviceAddressEXT(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            return _vkGetBufferDeviceAddressEXT_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_buffer_device_address]</b> [device command]  Alias of <see cref="GetBufferDeviceAddress"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferDeviceAddressKHR.html" /></remarks>
        public ulong GetBufferDeviceAddressKHR(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            return _vkGetBufferDeviceAddressKHR_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferMemoryRequirements.html" /></remarks>
        public void GetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements)
        {
            _vkGetBufferMemoryRequirements_fnptr(device, buffer, pMemoryRequirements);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferMemoryRequirements2.html" /></remarks>
        public void GetBufferMemoryRequirements2(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetBufferMemoryRequirements2_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_get_memory_requirements2]</b> [device command]  Alias of <see cref="GetBufferMemoryRequirements2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferMemoryRequirements2KHR.html" /></remarks>
        public void GetBufferMemoryRequirements2KHR(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetBufferMemoryRequirements2KHR_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferOpaqueCaptureAddress.html" /></remarks>
        public ulong GetBufferOpaqueCaptureAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            return _vkGetBufferOpaqueCaptureAddress_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_buffer_device_address]</b> [device command]  Alias of <see cref="GetBufferOpaqueCaptureAddress"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferOpaqueCaptureAddressKHR.html" /></remarks>
        public ulong GetBufferOpaqueCaptureAddressKHR(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
        {
            return _vkGetBufferOpaqueCaptureAddressKHR_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetBufferOpaqueCaptureDescriptorDataEXT.html" /></remarks>
        public VkResult GetBufferOpaqueCaptureDescriptorDataEXT(VkDevice device, VkBufferCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return _vkGetBufferOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: VK_EXT_calibrated_timestamps]</b> [device command]  Alias of <see cref="GetCalibratedTimestampsKHR"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetCalibratedTimestampsEXT.html" /></remarks>
        public VkResult GetCalibratedTimestampsEXT(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoKHR* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
        {
            return _vkGetCalibratedTimestampsEXT_fnptr(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);
        }
        /// <summary><b>[requires: VK_KHR_calibrated_timestamps]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetCalibratedTimestampsKHR.html" /></remarks>
        public VkResult GetCalibratedTimestampsKHR(VkDevice device, uint timestampCount, VkCalibratedTimestampInfoKHR* pTimestampInfos, ulong* pTimestamps, ulong* pMaxDeviation)
        {
            return _vkGetCalibratedTimestampsKHR_fnptr(device, timestampCount, pTimestampInfos, pTimestamps, pMaxDeviation);
        }
        /// <summary><b>[requires: VK_NV_cluster_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetClusterAccelerationStructureBuildSizesNV.html" /></remarks>
        public void GetClusterAccelerationStructureBuildSizesNV(VkDevice device, VkClusterAccelerationStructureInputInfoNV* pInfo, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            _vkGetClusterAccelerationStructureBuildSizesNV_fnptr(device, pInfo, pSizeInfo);
        }
        /// <summary>[device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetCommandPoolMemoryConsumption.html" /></remarks>
        public void GetCommandPoolMemoryConsumption(VkDevice device, VkCommandPool commandPool, VkCommandBuffer commandBuffer, VkCommandPoolMemoryConsumption* pConsumption)
        {
            _vkGetCommandPoolMemoryConsumption_fnptr(device, commandPool, commandBuffer, pConsumption);
        }
        /// <summary><b>[requires: VK_NV_cuda_kernel_launch]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetCudaModuleCacheNV.html" /></remarks>
        public VkResult GetCudaModuleCacheNV(VkDevice device, VkCudaModuleNV module, nuint* pCacheSize, void* pCacheData)
        {
            return _vkGetCudaModuleCacheNV_fnptr(device, module, pCacheSize, pCacheData);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDataGraphPipelineAvailablePropertiesARM.html" /></remarks>
        public VkResult GetDataGraphPipelineAvailablePropertiesARM(VkDevice device, VkDataGraphPipelineInfoARM* pPipelineInfo, uint* pPropertiesCount, VkDataGraphPipelinePropertyARM* pProperties)
        {
            return _vkGetDataGraphPipelineAvailablePropertiesARM_fnptr(device, pPipelineInfo, pPropertiesCount, pProperties);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDataGraphPipelinePropertiesARM.html" /></remarks>
        public VkResult GetDataGraphPipelinePropertiesARM(VkDevice device, VkDataGraphPipelineInfoARM* pPipelineInfo, uint propertiesCount, VkDataGraphPipelinePropertyQueryResultARM* pProperties)
        {
            return _vkGetDataGraphPipelinePropertiesARM_fnptr(device, pPipelineInfo, propertiesCount, pProperties);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDataGraphPipelineSessionBindPointRequirementsARM.html" /></remarks>
        public VkResult GetDataGraphPipelineSessionBindPointRequirementsARM(VkDevice device, VkDataGraphPipelineSessionBindPointRequirementsInfoARM* pInfo, uint* pBindPointRequirementCount, VkDataGraphPipelineSessionBindPointRequirementARM* pBindPointRequirements)
        {
            return _vkGetDataGraphPipelineSessionBindPointRequirementsARM_fnptr(device, pInfo, pBindPointRequirementCount, pBindPointRequirements);
        }
        /// <summary><b>[requires: VK_ARM_data_graph]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDataGraphPipelineSessionMemoryRequirementsARM.html" /></remarks>
        public void GetDataGraphPipelineSessionMemoryRequirementsARM(VkDevice device, VkDataGraphPipelineSessionMemoryRequirementsInfoARM* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetDataGraphPipelineSessionMemoryRequirementsARM_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_deferred_host_operations]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeferredOperationMaxConcurrencyKHR.html" /></remarks>
        public uint GetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation)
        {
            return _vkGetDeferredOperationMaxConcurrencyKHR_fnptr(device, operation);
        }
        /// <summary><b>[requires: VK_KHR_deferred_host_operations]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeferredOperationResultKHR.html" /></remarks>
        public VkResult GetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation)
        {
            return _vkGetDeferredOperationResultKHR_fnptr(device, operation);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorEXT.html" /></remarks>
        public void GetDescriptorEXT(VkDevice device, VkDescriptorGetInfoEXT* pDescriptorInfo, nuint dataSize, void* pDescriptor)
        {
            _vkGetDescriptorEXT_fnptr(device, pDescriptorInfo, dataSize, pDescriptor);
        }
        /// <summary><b>[requires: VK_VALVE_descriptor_set_host_mapping]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetHostMappingVALVE.html" /></remarks>
        public void GetDescriptorSetHostMappingVALVE(VkDevice device, VkDescriptorSet descriptorSet, void** ppData)
        {
            _vkGetDescriptorSetHostMappingVALVE_fnptr(device, descriptorSet, ppData);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutBindingOffsetEXT.html" /></remarks>
        public void GetDescriptorSetLayoutBindingOffsetEXT(VkDevice device, VkDescriptorSetLayout layout, uint binding, ulong* pOffset)
        {
            _vkGetDescriptorSetLayoutBindingOffsetEXT_fnptr(device, layout, binding, pOffset);
        }
        /// <summary><b>[requires: VK_VALVE_descriptor_set_host_mapping]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutHostMappingInfoVALVE.html" /></remarks>
        public void GetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, VkDescriptorSetBindingReferenceVALVE* pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
        {
            _vkGetDescriptorSetLayoutHostMappingInfoVALVE_fnptr(device, pBindingReference, pHostMapping);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutSizeEXT.html" /></remarks>
        public void GetDescriptorSetLayoutSizeEXT(VkDevice device, VkDescriptorSetLayout layout, ulong* pLayoutSizeInBytes)
        {
            _vkGetDescriptorSetLayoutSizeEXT_fnptr(device, layout, pLayoutSizeInBytes);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutSupport.html" /></remarks>
        public void GetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
        {
            _vkGetDescriptorSetLayoutSupport_fnptr(device, pCreateInfo, pSupport);
        }
        /// <summary><b>[requires: VK_KHR_maintenance3]</b> [device command]  Alias of <see cref="GetDescriptorSetLayoutSupport"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDescriptorSetLayoutSupportKHR.html" /></remarks>
        public void GetDescriptorSetLayoutSupportKHR(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
        {
            _vkGetDescriptorSetLayoutSupportKHR_fnptr(device, pCreateInfo, pSupport);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceAccelerationStructureCompatibilityKHR.html" /></remarks>
        public void GetDeviceAccelerationStructureCompatibilityKHR(VkDevice device, VkAccelerationStructureVersionInfoKHR* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            _vkGetDeviceAccelerationStructureCompatibilityKHR_fnptr(device, pVersionInfo, pCompatibility);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceBufferMemoryRequirements.html" /></remarks>
        public void GetDeviceBufferMemoryRequirements(VkDevice device, VkDeviceBufferMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetDeviceBufferMemoryRequirements_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_maintenance4]</b> [device command]  Alias of <see cref="GetDeviceBufferMemoryRequirements"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceBufferMemoryRequirementsKHR.html" /></remarks>
        public void GetDeviceBufferMemoryRequirementsKHR(VkDevice device, VkDeviceBufferMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetDeviceBufferMemoryRequirementsKHR_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_EXT_device_fault]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceFaultInfoEXT.html" /></remarks>
        public VkResult GetDeviceFaultInfoEXT(VkDevice device, VkDeviceFaultCountsEXT* pFaultCounts, VkDeviceFaultInfoEXT* pFaultInfo)
        {
            return _vkGetDeviceFaultInfoEXT_fnptr(device, pFaultCounts, pFaultInfo);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPeerMemoryFeatures.html" /></remarks>
        public void GetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlagBits* pPeerMemoryFeatures)
        {
            _vkGetDeviceGroupPeerMemoryFeatures_fnptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
        }
        /// <summary><b>[requires: VK_KHR_device_group]</b> [device command]  Alias of <see cref="GetDeviceGroupPeerMemoryFeatures"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPeerMemoryFeaturesKHR.html" /></remarks>
        public void GetDeviceGroupPeerMemoryFeaturesKHR(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlagBits* pPeerMemoryFeatures)
        {
            _vkGetDeviceGroupPeerMemoryFeaturesKHR_fnptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
        }
        /// <summary><b>[requires: VK_KHR_swapchain | VK_KHR_device_group]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPresentCapabilitiesKHR.html" /></remarks>
        public VkResult GetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities)
        {
            return _vkGetDeviceGroupPresentCapabilitiesKHR_fnptr(device, pDeviceGroupPresentCapabilities);
        }
        /// <summary><b>[requires: VK_EXT_full_screen_exclusive]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupSurfacePresentModes2EXT.html" /></remarks>
        public VkResult GetDeviceGroupSurfacePresentModes2EXT(VkDevice device, VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagBitsKHR* pModes)
        {
            return _vkGetDeviceGroupSurfacePresentModes2EXT_fnptr(device, pSurfaceInfo, pModes);
        }
        /// <summary><b>[requires: VK_KHR_swapchain | VK_KHR_device_group]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupSurfacePresentModesKHR.html" /></remarks>
        public VkResult GetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagBitsKHR* pModes)
        {
            return _vkGetDeviceGroupSurfacePresentModesKHR_fnptr(device, surface, pModes);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageMemoryRequirements.html" /></remarks>
        public void GetDeviceImageMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetDeviceImageMemoryRequirements_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_maintenance4]</b> [device command]  Alias of <see cref="GetDeviceImageMemoryRequirements"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageMemoryRequirementsKHR.html" /></remarks>
        public void GetDeviceImageMemoryRequirementsKHR(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetDeviceImageMemoryRequirementsKHR_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSparseMemoryRequirements.html" /></remarks>
        public void GetDeviceImageSparseMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            _vkGetDeviceImageSparseMemoryRequirements_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_maintenance4]</b> [device command]  Alias of <see cref="GetDeviceImageSparseMemoryRequirements"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSparseMemoryRequirementsKHR.html" /></remarks>
        public void GetDeviceImageSparseMemoryRequirementsKHR(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            _vkGetDeviceImageSparseMemoryRequirementsKHR_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSubresourceLayout.html" /></remarks>
        public void GetDeviceImageSubresourceLayout(VkDevice device, VkDeviceImageSubresourceInfo* pInfo, VkSubresourceLayout2* pLayout)
        {
            _vkGetDeviceImageSubresourceLayout_fnptr(device, pInfo, pLayout);
        }
        /// <summary><b>[requires: VK_KHR_maintenance5]</b> [device command]  Alias of <see cref="GetDeviceImageSubresourceLayout"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSubresourceLayoutKHR.html" /></remarks>
        public void GetDeviceImageSubresourceLayoutKHR(VkDevice device, VkDeviceImageSubresourceInfo* pInfo, VkSubresourceLayout2* pLayout)
        {
            _vkGetDeviceImageSubresourceLayoutKHR_fnptr(device, pInfo, pLayout);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMemoryCommitment.html" /></remarks>
        public void GetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, ulong* pCommittedMemoryInBytes)
        {
            _vkGetDeviceMemoryCommitment_fnptr(device, memory, pCommittedMemoryInBytes);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMemoryOpaqueCaptureAddress.html" /></remarks>
        public ulong GetDeviceMemoryOpaqueCaptureAddress(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
        {
            return _vkGetDeviceMemoryOpaqueCaptureAddress_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_KHR_buffer_device_address]</b> [device command]  Alias of <see cref="GetDeviceMemoryOpaqueCaptureAddress"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMemoryOpaqueCaptureAddressKHR.html" /></remarks>
        public ulong GetDeviceMemoryOpaqueCaptureAddressKHR(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
        {
            return _vkGetDeviceMemoryOpaqueCaptureAddressKHR_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceMicromapCompatibilityEXT.html" /></remarks>
        public void GetDeviceMicromapCompatibilityEXT(VkDevice device, VkMicromapVersionInfoEXT* pVersionInfo, VkAccelerationStructureCompatibilityKHR* pCompatibility)
        {
            _vkGetDeviceMicromapCompatibilityEXT_fnptr(device, pVersionInfo, pCompatibility);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceProcAddr.html" /></remarks>
        public IntPtr GetDeviceProcAddr(VkDevice device, byte* pName)
        {
            return _vkGetDeviceProcAddr_fnptr(device, pName);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceQueue.html" /></remarks>
        public void GetDeviceQueue(VkDevice device, uint queueFamilyIndex, uint queueIndex, VkQueue* pQueue)
        {
            _vkGetDeviceQueue_fnptr(device, queueFamilyIndex, queueIndex, pQueue);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceQueue2.html" /></remarks>
        public void GetDeviceQueue2(VkDevice device, VkDeviceQueueInfo2* pQueueInfo, VkQueue* pQueue)
        {
            _vkGetDeviceQueue2_fnptr(device, pQueueInfo, pQueue);
        }
        /// <summary><b>[requires: VK_HUAWEI_subpass_shading]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI.html" /></remarks>
        public VkResult GetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize)
        {
            return _vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_fnptr(device, renderpass, pMaxWorkgroupSize);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceTensorMemoryRequirementsARM.html" /></remarks>
        public void GetDeviceTensorMemoryRequirementsARM(VkDevice device, VkDeviceTensorMemoryRequirementsARM* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetDeviceTensorMemoryRequirementsARM_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_QCOM_tile_properties]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDynamicRenderingTilePropertiesQCOM.html" /></remarks>
        public VkResult GetDynamicRenderingTilePropertiesQCOM(VkDevice device, VkRenderingInfo* pRenderingInfo, VkTilePropertiesQCOM* pProperties)
        {
            return _vkGetDynamicRenderingTilePropertiesQCOM_fnptr(device, pRenderingInfo, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_video_encode_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetEncodedVideoSessionParametersKHR.html" /></remarks>
        public VkResult GetEncodedVideoSessionParametersKHR(VkDevice device, VkVideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, VkVideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, nuint* pDataSize, void* pData)
        {
            return _vkGetEncodedVideoSessionParametersKHR_fnptr(device, pVideoSessionParametersInfo, pFeedbackInfo, pDataSize, pData);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetEventStatus.html" /></remarks>
        public VkResult GetEventStatus(VkDevice device, VkEvent @event)
        {
            return _vkGetEventStatus_fnptr(device, @event);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetExecutionGraphPipelineNodeIndexAMDX.html" /></remarks>
        public VkResult GetExecutionGraphPipelineNodeIndexAMDX(VkDevice device, VkPipeline executionGraph, VkPipelineShaderStageNodeCreateInfoAMDX* pNodeInfo, uint* pNodeIndex)
        {
            return _vkGetExecutionGraphPipelineNodeIndexAMDX_fnptr(device, executionGraph, pNodeInfo, pNodeIndex);
        }
        /// <summary><b>[requires: VK_AMDX_shader_enqueue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetExecutionGraphPipelineScratchSizeAMDX.html" /></remarks>
        public VkResult GetExecutionGraphPipelineScratchSizeAMDX(VkDevice device, VkPipeline executionGraph, VkExecutionGraphPipelineScratchSizeAMDX* pSizeInfo)
        {
            return _vkGetExecutionGraphPipelineScratchSizeAMDX_fnptr(device, executionGraph, pSizeInfo);
        }
        /// <summary><b>[requires: VK_NV_external_compute_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetExternalComputeQueueDataNV.html" /></remarks>
        public void GetExternalComputeQueueDataNV(VkExternalComputeQueueNV externalQueue, VkExternalComputeQueueDataParamsNV* parameters, void* pData)
        {
            _vkGetExternalComputeQueueDataNV_fnptr(externalQueue, parameters, pData);
        }
        /// <summary>[device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFaultData.html" /></remarks>
        public VkResult GetFaultData(VkDevice device, VkFaultQueryBehavior faultQueryBehavior, int* pUnrecordedFaults, uint* pFaultCount, VkFaultData* pFaults)
        {
            return _vkGetFaultData_fnptr(device, faultQueryBehavior, pUnrecordedFaults, pFaultCount, pFaults);
        }
        /// <summary><b>[requires: VK_KHR_external_fence_fd]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFenceFdKHR.html" /></remarks>
        public VkResult GetFenceFdKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            return _vkGetFenceFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync | VK_NV_external_sci_sync2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFenceSciSyncFenceNV.html" /></remarks>
        public VkResult GetFenceSciSyncFenceNV(VkDevice device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle)
        {
            return _vkGetFenceSciSyncFenceNV_fnptr(device, pGetSciSyncHandleInfo, pHandle);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync | VK_NV_external_sci_sync2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFenceSciSyncObjNV.html" /></remarks>
        public VkResult GetFenceSciSyncObjNV(VkDevice device, VkFenceGetSciSyncInfoNV* pGetSciSyncHandleInfo, void* pHandle)
        {
            return _vkGetFenceSciSyncObjNV_fnptr(device, pGetSciSyncHandleInfo, pHandle);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFenceStatus.html" /></remarks>
        public VkResult GetFenceStatus(VkDevice device, VkFence fence)
        {
            return _vkGetFenceStatus_fnptr(device, fence);
        }
        /// <summary><b>[requires: VK_KHR_external_fence_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFenceWin32HandleKHR.html" /></remarks>
        public VkResult GetFenceWin32HandleKHR(VkDevice device, VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            return _vkGetFenceWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        /// <summary><b>[requires: VK_QCOM_tile_properties]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFramebufferTilePropertiesQCOM.html" /></remarks>
        public VkResult GetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, uint* pPropertiesCount, VkTilePropertiesQCOM* pProperties)
        {
            return _vkGetFramebufferTilePropertiesQCOM_fnptr(device, framebuffer, pPropertiesCount, pProperties);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetGeneratedCommandsMemoryRequirementsEXT.html" /></remarks>
        public void GetGeneratedCommandsMemoryRequirementsEXT(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoEXT* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetGeneratedCommandsMemoryRequirementsEXT_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetGeneratedCommandsMemoryRequirementsNV.html" /></remarks>
        public void GetGeneratedCommandsMemoryRequirementsNV(VkDevice device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetGeneratedCommandsMemoryRequirementsNV_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_EXT_image_drm_format_modifier]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageDrmFormatModifierPropertiesEXT.html" /></remarks>
        public VkResult GetImageDrmFormatModifierPropertiesEXT(VkDevice device, VkImage image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
        {
            return _vkGetImageDrmFormatModifierPropertiesEXT_fnptr(device, image, pProperties);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageMemoryRequirements.html" /></remarks>
        public void GetImageMemoryRequirements(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements)
        {
            _vkGetImageMemoryRequirements_fnptr(device, image, pMemoryRequirements);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageMemoryRequirements2.html" /></remarks>
        public void GetImageMemoryRequirements2(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetImageMemoryRequirements2_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_get_memory_requirements2]</b> [device command]  Alias of <see cref="GetImageMemoryRequirements2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageMemoryRequirements2KHR.html" /></remarks>
        public void GetImageMemoryRequirements2KHR(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetImageMemoryRequirements2KHR_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageOpaqueCaptureDescriptorDataEXT.html" /></remarks>
        public VkResult GetImageOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return _vkGetImageOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSparseMemoryRequirements.html" /></remarks>
        public void GetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements)
        {
            _vkGetImageSparseMemoryRequirements_fnptr(device, image, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSparseMemoryRequirements2.html" /></remarks>
        public void GetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            _vkGetImageSparseMemoryRequirements2_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_get_memory_requirements2]</b> [device command]  Alias of <see cref="GetImageSparseMemoryRequirements2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSparseMemoryRequirements2KHR.html" /></remarks>
        public void GetImageSparseMemoryRequirements2KHR(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            _vkGetImageSparseMemoryRequirements2KHR_fnptr(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout.html" /></remarks>
        public void GetImageSubresourceLayout(VkDevice device, VkImage image, VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout)
        {
            _vkGetImageSubresourceLayout_fnptr(device, image, pSubresource, pLayout);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout2.html" /></remarks>
        public void GetImageSubresourceLayout2(VkDevice device, VkImage image, VkImageSubresource2* pSubresource, VkSubresourceLayout2* pLayout)
        {
            _vkGetImageSubresourceLayout2_fnptr(device, image, pSubresource, pLayout);
        }
        /// <summary><b>[requires: VK_EXT_host_image_copy | VK_EXT_image_compression_control]</b> [device command]  Alias of <see cref="GetImageSubresourceLayout2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout2EXT.html" /></remarks>
        public void GetImageSubresourceLayout2EXT(VkDevice device, VkImage image, VkImageSubresource2* pSubresource, VkSubresourceLayout2* pLayout)
        {
            _vkGetImageSubresourceLayout2EXT_fnptr(device, image, pSubresource, pLayout);
        }
        /// <summary><b>[requires: VK_KHR_maintenance5]</b> [device command]  Alias of <see cref="GetImageSubresourceLayout2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout2KHR.html" /></remarks>
        public void GetImageSubresourceLayout2KHR(VkDevice device, VkImage image, VkImageSubresource2* pSubresource, VkSubresourceLayout2* pLayout)
        {
            _vkGetImageSubresourceLayout2KHR_fnptr(device, image, pSubresource, pLayout);
        }
        /// <summary><b>[requires: VK_NVX_image_view_handle]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageViewAddressNVX.html" /></remarks>
        public VkResult GetImageViewAddressNVX(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties)
        {
            return _vkGetImageViewAddressNVX_fnptr(device, imageView, pProperties);
        }
        /// <summary><b>[requires: VK_NVX_image_view_handle]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageViewHandle64NVX.html" /></remarks>
        public ulong GetImageViewHandle64NVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
        {
            return _vkGetImageViewHandle64NVX_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_NVX_image_view_handle]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageViewHandleNVX.html" /></remarks>
        public uint GetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
        {
            return _vkGetImageViewHandleNVX_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetImageViewOpaqueCaptureDescriptorDataEXT.html" /></remarks>
        public VkResult GetImageViewOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageViewCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return _vkGetImageViewOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: VK_NV_low_latency2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetLatencyTimingsNV.html" /></remarks>
        public void GetLatencyTimingsNV(VkDevice device, VkSwapchainKHR swapchain, VkGetLatencyMarkerInfoNV* pLatencyMarkerInfo)
        {
            _vkGetLatencyTimingsNV_fnptr(device, swapchain, pLatencyMarkerInfo);
        }
        /// <summary><b>[requires: VK_ANDROID_external_memory_android_hardware_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryAndroidHardwareBufferANDROID.html" /></remarks>
        public VkResult GetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, IntPtr* pBuffer)
        {
            return _vkGetMemoryAndroidHardwareBufferANDROID_fnptr(device, pInfo, pBuffer);
        }
        /// <summary><b>[requires: VK_KHR_external_memory_fd]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryFdKHR.html" /></remarks>
        public VkResult GetMemoryFdKHR(VkDevice device, VkMemoryGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            return _vkGetMemoryFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        /// <summary><b>[requires: VK_KHR_external_memory_fd]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryFdPropertiesKHR.html" /></remarks>
        public VkResult GetMemoryFdPropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int fd, VkMemoryFdPropertiesKHR* pMemoryFdProperties)
        {
            return _vkGetMemoryFdPropertiesKHR_fnptr(device, handleType, fd, pMemoryFdProperties);
        }
        /// <summary><b>[requires: VK_EXT_external_memory_host]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryHostPointerPropertiesEXT.html" /></remarks>
        public VkResult GetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties)
        {
            return _vkGetMemoryHostPointerPropertiesEXT_fnptr(device, handleType, pHostPointer, pMemoryHostPointerProperties);
        }
        /// <summary><b>[requires: VK_EXT_external_memory_metal]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryMetalHandleEXT.html" /></remarks>
        public VkResult GetMemoryMetalHandleEXT(VkDevice device, VkMemoryGetMetalHandleInfoEXT* pGetMetalHandleInfo, void** pHandle)
        {
            return _vkGetMemoryMetalHandleEXT_fnptr(device, pGetMetalHandleInfo, pHandle);
        }
        /// <summary><b>[requires: VK_EXT_external_memory_metal]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryMetalHandlePropertiesEXT.html" /></remarks>
        public VkResult GetMemoryMetalHandlePropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, void* pHandle, VkMemoryMetalHandlePropertiesEXT* pMemoryMetalHandleProperties)
        {
            return _vkGetMemoryMetalHandlePropertiesEXT_fnptr(device, handleType, pHandle, pMemoryMetalHandleProperties);
        }
        /// <summary><b>[requires: VK_OHOS_external_memory]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryNativeBufferOHOS.html" /></remarks>
        public VkResult GetMemoryNativeBufferOHOS(VkDevice device, VkMemoryGetNativeBufferInfoOHOS* pInfo, IntPtr* pBuffer)
        {
            return _vkGetMemoryNativeBufferOHOS_fnptr(device, pInfo, pBuffer);
        }
        /// <summary><b>[requires: VK_NV_external_memory_rdma]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryRemoteAddressNV.html" /></remarks>
        public VkResult GetMemoryRemoteAddressNV(VkDevice device, VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, void** pAddress)
        {
            return _vkGetMemoryRemoteAddressNV_fnptr(device, pMemoryGetRemoteAddressInfo, pAddress);
        }
        /// <summary><b>[requires: VK_NV_external_memory_sci_buf]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemorySciBufNV.html" /></remarks>
        public VkResult GetMemorySciBufNV(VkDevice device, VkMemoryGetSciBufInfoNV* pGetSciBufInfo, IntPtr* pHandle)
        {
            return _vkGetMemorySciBufNV_fnptr(device, pGetSciBufInfo, pHandle);
        }
        /// <summary><b>[requires: VK_KHR_external_memory_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleKHR.html" /></remarks>
        public VkResult GetMemoryWin32HandleKHR(VkDevice device, VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            return _vkGetMemoryWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        /// <summary><b>[requires: VK_NV_external_memory_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleNV.html" /></remarks>
        public VkResult GetMemoryWin32HandleNV(VkDevice device, VkDeviceMemory memory, VkExternalMemoryHandleTypeFlagBitsNV handleType, IntPtr* pHandle)
        {
            return _vkGetMemoryWin32HandleNV_fnptr(device, memory, handleType, pHandle);
        }
        /// <summary><b>[requires: VK_KHR_external_memory_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandlePropertiesKHR.html" /></remarks>
        public VkResult GetMemoryWin32HandlePropertiesKHR(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, IntPtr handle, VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties)
        {
            return _vkGetMemoryWin32HandlePropertiesKHR_fnptr(device, handleType, handle, pMemoryWin32HandleProperties);
        }
        /// <summary><b>[requires: VK_FUCHSIA_external_memory]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryZirconHandleFUCHSIA.html" /></remarks>
        public VkResult GetMemoryZirconHandleFUCHSIA(VkDevice device, VkMemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, int* pZirconHandle)
        {
            return _vkGetMemoryZirconHandleFUCHSIA_fnptr(device, pGetZirconHandleInfo, pZirconHandle);
        }
        /// <summary><b>[requires: VK_FUCHSIA_external_memory]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryZirconHandlePropertiesFUCHSIA.html" /></remarks>
        public VkResult GetMemoryZirconHandlePropertiesFUCHSIA(VkDevice device, VkExternalMemoryHandleTypeFlagBits handleType, int zirconHandle, VkMemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties)
        {
            return _vkGetMemoryZirconHandlePropertiesFUCHSIA_fnptr(device, handleType, zirconHandle, pMemoryZirconHandleProperties);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMicromapBuildSizesEXT.html" /></remarks>
        public void GetMicromapBuildSizesEXT(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, VkMicromapBuildInfoEXT* pBuildInfo, VkMicromapBuildSizesInfoEXT* pSizeInfo)
        {
            _vkGetMicromapBuildSizesEXT_fnptr(device, buildType, pBuildInfo, pSizeInfo);
        }
        /// <summary><b>[requires: VK_OHOS_external_memory]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetNativeBufferPropertiesOHOS.html" /></remarks>
        public VkResult GetNativeBufferPropertiesOHOS(VkDevice device, IntPtr buffer, VkNativeBufferPropertiesOHOS* pProperties)
        {
            return _vkGetNativeBufferPropertiesOHOS_fnptr(device, buffer, pProperties);
        }
        /// <summary><b>[requires: VK_NV_partitioned_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPartitionedAccelerationStructuresBuildSizesNV.html" /></remarks>
        public void GetPartitionedAccelerationStructuresBuildSizesNV(VkDevice device, VkPartitionedAccelerationStructureInstancesInputNV* pInfo, VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
        {
            _vkGetPartitionedAccelerationStructuresBuildSizesNV_fnptr(device, pInfo, pSizeInfo);
        }
        /// <summary><b>[requires: VK_EXT_present_timing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPastPresentationTimingEXT.html" /></remarks>
        public VkResult GetPastPresentationTimingEXT(VkDevice device, VkPastPresentationTimingInfoEXT* pPastPresentationTimingInfo, VkPastPresentationTimingPropertiesEXT* pPastPresentationTimingProperties)
        {
            return _vkGetPastPresentationTimingEXT_fnptr(device, pPastPresentationTimingInfo, pPastPresentationTimingProperties);
        }
        /// <summary><b>[requires: VK_GOOGLE_display_timing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPastPresentationTimingGOOGLE.html" /></remarks>
        public VkResult GetPastPresentationTimingGOOGLE(VkDevice device, VkSwapchainKHR swapchain, uint* pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
        {
            return _vkGetPastPresentationTimingGOOGLE_fnptr(device, swapchain, pPresentationTimingCount, pPresentationTimings);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPerformanceParameterINTEL.html" /></remarks>
        public VkResult GetPerformanceParameterINTEL(VkDevice device, VkPerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
        {
            return _vkGetPerformanceParameterINTEL_fnptr(device, parameter, pValue);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_binary]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineBinaryDataKHR.html" /></remarks>
        public VkResult GetPipelineBinaryDataKHR(VkDevice device, VkPipelineBinaryDataInfoKHR* pInfo, VkPipelineBinaryKeyKHR* pPipelineBinaryKey, nuint* pPipelineBinaryDataSize, void* pPipelineBinaryData)
        {
            return _vkGetPipelineBinaryDataKHR_fnptr(device, pInfo, pPipelineBinaryKey, pPipelineBinaryDataSize, pPipelineBinaryData);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineCacheData.html" /></remarks>
        public VkResult GetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, nuint* pDataSize, void* pData)
        {
            return _vkGetPipelineCacheData_fnptr(device, pipelineCache, pDataSize, pData);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_executable_properties]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutableInternalRepresentationsKHR.html" /></remarks>
        public VkResult GetPipelineExecutableInternalRepresentationsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            return _vkGetPipelineExecutableInternalRepresentationsKHR_fnptr(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_executable_properties]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutablePropertiesKHR.html" /></remarks>
        public VkResult GetPipelineExecutablePropertiesKHR(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            return _vkGetPipelineExecutablePropertiesKHR_fnptr(device, pPipelineInfo, pExecutableCount, pProperties);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_executable_properties]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutableStatisticsKHR.html" /></remarks>
        public VkResult GetPipelineExecutableStatisticsKHR(VkDevice device, VkPipelineExecutableInfoKHR* pExecutableInfo, uint* pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            return _vkGetPipelineExecutableStatisticsKHR_fnptr(device, pExecutableInfo, pStatisticCount, pStatistics);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands_compute]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineIndirectDeviceAddressNV.html" /></remarks>
        public ulong GetPipelineIndirectDeviceAddressNV(VkDevice device, VkPipelineIndirectDeviceAddressInfoNV* pInfo)
        {
            return _vkGetPipelineIndirectDeviceAddressNV_fnptr(device, pInfo);
        }
        /// <summary><b>[requires: VK_NV_device_generated_commands_compute]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineIndirectMemoryRequirementsNV.html" /></remarks>
        public void GetPipelineIndirectMemoryRequirementsNV(VkDevice device, VkComputePipelineCreateInfo* pCreateInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetPipelineIndirectMemoryRequirementsNV_fnptr(device, pCreateInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_binary]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelineKeyKHR.html" /></remarks>
        public VkResult GetPipelineKeyKHR(VkDevice device, VkPipelineCreateInfoKHR* pPipelineCreateInfo, VkPipelineBinaryKeyKHR* pPipelineKey)
        {
            return _vkGetPipelineKeyKHR_fnptr(device, pPipelineCreateInfo, pPipelineKey);
        }
        /// <summary><b>[requires: VK_EXT_pipeline_properties]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPipelinePropertiesEXT.html" /></remarks>
        public VkResult GetPipelinePropertiesEXT(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
        {
            return _vkGetPipelinePropertiesEXT_fnptr(device, pPipelineInfo, pPipelineProperties);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPrivateData.html" /></remarks>
        public void GetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong* pData)
        {
            _vkGetPrivateData_fnptr(device, objectType, objectHandle, privateDataSlot, pData);
        }
        /// <summary><b>[requires: VK_EXT_private_data]</b> [device command]  Alias of <see cref="GetPrivateData"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPrivateDataEXT.html" /></remarks>
        public void GetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong* pData)
        {
            _vkGetPrivateDataEXT_fnptr(device, objectType, objectHandle, privateDataSlot, pData);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetQueryPoolResults.html" /></remarks>
        public VkResult GetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, nuint dataSize, void* pData, ulong stride, VkQueryResultFlagBits flags)
        {
            return _vkGetQueryPoolResults_fnptr(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);
        }
        /// <summary><b>[requires: VK_NV_device_diagnostic_checkpoints]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetQueueCheckpointData2NV.html" /></remarks>
        public void GetQueueCheckpointData2NV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
        {
            _vkGetQueueCheckpointData2NV_fnptr(queue, pCheckpointDataCount, pCheckpointData);
        }
        /// <summary><b>[requires: VK_NV_device_diagnostic_checkpoints]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetQueueCheckpointDataNV.html" /></remarks>
        public void GetQueueCheckpointDataNV(VkQueue queue, uint* pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
        {
            _vkGetQueueCheckpointDataNV_fnptr(queue, pCheckpointDataCount, pCheckpointData);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingCaptureReplayShaderGroupHandlesKHR.html" /></remarks>
        public VkResult GetRayTracingCaptureReplayShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
        {
            return _vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_fnptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingShaderGroupHandlesKHR.html" /></remarks>
        public VkResult GetRayTracingShaderGroupHandlesKHR(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
        {
            return _vkGetRayTracingShaderGroupHandlesKHR_fnptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        /// <summary><b>[requires: VK_NV_ray_tracing]</b> [device command]  Alias of <see cref="GetRayTracingShaderGroupHandlesKHR"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingShaderGroupHandlesNV.html" /></remarks>
        public VkResult GetRayTracingShaderGroupHandlesNV(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, nuint dataSize, void* pData)
        {
            return _vkGetRayTracingShaderGroupHandlesNV_fnptr(device, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        /// <summary><b>[requires: VK_KHR_ray_tracing_pipeline]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRayTracingShaderGroupStackSizeKHR.html" /></remarks>
        public ulong GetRayTracingShaderGroupStackSizeKHR(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader)
        {
            return _vkGetRayTracingShaderGroupStackSizeKHR_fnptr(device, pipeline, group, groupShader);
        }
        /// <summary><b>[requires: VK_GOOGLE_display_timing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRefreshCycleDurationGOOGLE.html" /></remarks>
        public VkResult GetRefreshCycleDurationGOOGLE(VkDevice device, VkSwapchainKHR swapchain, VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties)
        {
            return _vkGetRefreshCycleDurationGOOGLE_fnptr(device, swapchain, pDisplayTimingProperties);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRenderAreaGranularity.html" /></remarks>
        public void GetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity)
        {
            _vkGetRenderAreaGranularity_fnptr(device, renderPass, pGranularity);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRenderingAreaGranularity.html" /></remarks>
        public void GetRenderingAreaGranularity(VkDevice device, VkRenderingAreaInfo* pRenderingAreaInfo, VkExtent2D* pGranularity)
        {
            _vkGetRenderingAreaGranularity_fnptr(device, pRenderingAreaInfo, pGranularity);
        }
        /// <summary><b>[requires: VK_KHR_maintenance5]</b> [device command]  Alias of <see cref="GetRenderingAreaGranularity"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRenderingAreaGranularityKHR.html" /></remarks>
        public void GetRenderingAreaGranularityKHR(VkDevice device, VkRenderingAreaInfo* pRenderingAreaInfo, VkExtent2D* pGranularity)
        {
            _vkGetRenderingAreaGranularityKHR_fnptr(device, pRenderingAreaInfo, pGranularity);
        }
        /// <summary><b>[requires: VK_EXT_descriptor_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSamplerOpaqueCaptureDescriptorDataEXT.html" /></remarks>
        public VkResult GetSamplerOpaqueCaptureDescriptorDataEXT(VkDevice device, VkSamplerCaptureDescriptorDataInfoEXT* pInfo, void* pData)
        {
            return _vkGetSamplerOpaqueCaptureDescriptorDataEXT_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: VK_QNX_external_memory_screen_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetScreenBufferPropertiesQNX.html" /></remarks>
        public VkResult GetScreenBufferPropertiesQNX(VkDevice device, IntPtr* buffer, VkScreenBufferPropertiesQNX* pProperties)
        {
            return _vkGetScreenBufferPropertiesQNX_fnptr(device, buffer, pProperties);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreCounterValue.html" /></remarks>
        public VkResult GetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, ulong* pValue)
        {
            return _vkGetSemaphoreCounterValue_fnptr(device, semaphore, pValue);
        }
        /// <summary><b>[requires: VK_KHR_timeline_semaphore]</b> [device command]  Alias of <see cref="GetSemaphoreCounterValue"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreCounterValueKHR.html" /></remarks>
        public VkResult GetSemaphoreCounterValueKHR(VkDevice device, VkSemaphore semaphore, ulong* pValue)
        {
            return _vkGetSemaphoreCounterValueKHR_fnptr(device, semaphore, pValue);
        }
        /// <summary><b>[requires: VK_KHR_external_semaphore_fd]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreFdKHR.html" /></remarks>
        public VkResult GetSemaphoreFdKHR(VkDevice device, VkSemaphoreGetFdInfoKHR* pGetFdInfo, int* pFd)
        {
            return _vkGetSemaphoreFdKHR_fnptr(device, pGetFdInfo, pFd);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreSciSyncObjNV.html" /></remarks>
        public VkResult GetSemaphoreSciSyncObjNV(VkDevice device, VkSemaphoreGetSciSyncInfoNV* pGetSciSyncInfo, void* pHandle)
        {
            return _vkGetSemaphoreSciSyncObjNV_fnptr(device, pGetSciSyncInfo, pHandle);
        }
        /// <summary><b>[requires: VK_KHR_external_semaphore_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreWin32HandleKHR.html" /></remarks>
        public VkResult GetSemaphoreWin32HandleKHR(VkDevice device, VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr* pHandle)
        {
            return _vkGetSemaphoreWin32HandleKHR_fnptr(device, pGetWin32HandleInfo, pHandle);
        }
        /// <summary><b>[requires: VK_FUCHSIA_external_semaphore]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreZirconHandleFUCHSIA.html" /></remarks>
        public VkResult GetSemaphoreZirconHandleFUCHSIA(VkDevice device, VkSemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, int* pZirconHandle)
        {
            return _vkGetSemaphoreZirconHandleFUCHSIA_fnptr(device, pGetZirconHandleInfo, pZirconHandle);
        }
        /// <summary><b>[requires: VK_EXT_shader_object]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetShaderBinaryDataEXT.html" /></remarks>
        public VkResult GetShaderBinaryDataEXT(VkDevice device, VkShaderEXT shader, nuint* pDataSize, void* pData)
        {
            return _vkGetShaderBinaryDataEXT_fnptr(device, shader, pDataSize, pData);
        }
        /// <summary><b>[requires: VK_AMD_shader_info]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetShaderInfoAMD.html" /></remarks>
        public VkResult GetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlagBits shaderStage, VkShaderInfoTypeAMD infoType, nuint* pInfoSize, void* pInfo)
        {
            return _vkGetShaderInfoAMD_fnptr(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);
        }
        /// <summary><b>[requires: VK_EXT_shader_module_identifier]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetShaderModuleCreateInfoIdentifierEXT.html" /></remarks>
        public void GetShaderModuleCreateInfoIdentifierEXT(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            _vkGetShaderModuleCreateInfoIdentifierEXT_fnptr(device, pCreateInfo, pIdentifier);
        }
        /// <summary><b>[requires: VK_EXT_shader_module_identifier]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetShaderModuleIdentifierEXT.html" /></remarks>
        public void GetShaderModuleIdentifierEXT(VkDevice device, VkShaderModule shaderModule, VkShaderModuleIdentifierEXT* pIdentifier)
        {
            _vkGetShaderModuleIdentifierEXT_fnptr(device, shaderModule, pIdentifier);
        }
        /// <summary><b>[requires: VK_EXT_display_control]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainCounterEXT.html" /></remarks>
        public VkResult GetSwapchainCounterEXT(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagBitsEXT counter, ulong* pCounterValue)
        {
            return _vkGetSwapchainCounterEXT_fnptr(device, swapchain, counter, pCounterValue);
        }
        /// <summary>[device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainGrallocUsage2ANDROID.html" /></remarks>
        public VkResult GetSwapchainGrallocUsage2ANDROID(VkDevice device, VkFormat format, VkImageUsageFlagBits imageUsage, VkSwapchainImageUsageFlagBitsANDROID swapchainImageUsage, ulong* grallocConsumerUsage, ulong* grallocProducerUsage)
        {
            return _vkGetSwapchainGrallocUsage2ANDROID_fnptr(device, format, imageUsage, swapchainImageUsage, grallocConsumerUsage, grallocProducerUsage);
        }
        /// <summary>[device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainGrallocUsageANDROID.html" /></remarks>
        public VkResult GetSwapchainGrallocUsageANDROID(VkDevice device, VkFormat format, VkImageUsageFlagBits imageUsage, int* grallocUsage)
        {
            return _vkGetSwapchainGrallocUsageANDROID_fnptr(device, format, imageUsage, grallocUsage);
        }
        /// <summary><b>[requires: VK_OHOS_native_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainGrallocUsageOHOS.html" /></remarks>
        public VkResult GetSwapchainGrallocUsageOHOS(VkDevice device, VkFormat format, VkImageUsageFlagBits imageUsage, ulong* grallocUsage)
        {
            return _vkGetSwapchainGrallocUsageOHOS_fnptr(device, format, imageUsage, grallocUsage);
        }
        /// <summary><b>[requires: VK_KHR_swapchain]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainImagesKHR.html" /></remarks>
        public VkResult GetSwapchainImagesKHR(VkDevice device, VkSwapchainKHR swapchain, uint* pSwapchainImageCount, VkImage* pSwapchainImages)
        {
            return _vkGetSwapchainImagesKHR_fnptr(device, swapchain, pSwapchainImageCount, pSwapchainImages);
        }
        /// <summary><b>[requires: VK_KHR_shared_presentable_image]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainStatusKHR.html" /></remarks>
        public VkResult GetSwapchainStatusKHR(VkDevice device, VkSwapchainKHR swapchain)
        {
            return _vkGetSwapchainStatusKHR_fnptr(device, swapchain);
        }
        /// <summary><b>[requires: VK_EXT_present_timing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainTimeDomainPropertiesEXT.html" /></remarks>
        public VkResult GetSwapchainTimeDomainPropertiesEXT(VkDevice device, VkSwapchainKHR swapchain, VkSwapchainTimeDomainPropertiesEXT* pSwapchainTimeDomainProperties, ulong* pTimeDomainsCounter)
        {
            return _vkGetSwapchainTimeDomainPropertiesEXT_fnptr(device, swapchain, pSwapchainTimeDomainProperties, pTimeDomainsCounter);
        }
        /// <summary><b>[requires: VK_EXT_present_timing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainTimingPropertiesEXT.html" /></remarks>
        public VkResult GetSwapchainTimingPropertiesEXT(VkDevice device, VkSwapchainKHR swapchain, VkSwapchainTimingPropertiesEXT* pSwapchainTimingProperties, ulong* pSwapchainTimingPropertiesCounter)
        {
            return _vkGetSwapchainTimingPropertiesEXT_fnptr(device, swapchain, pSwapchainTimingProperties, pSwapchainTimingPropertiesCounter);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetTensorMemoryRequirementsARM.html" /></remarks>
        public void GetTensorMemoryRequirementsARM(VkDevice device, VkTensorMemoryRequirementsInfoARM* pInfo, VkMemoryRequirements2* pMemoryRequirements)
        {
            _vkGetTensorMemoryRequirementsARM_fnptr(device, pInfo, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetTensorOpaqueCaptureDescriptorDataARM.html" /></remarks>
        public VkResult GetTensorOpaqueCaptureDescriptorDataARM(VkDevice device, VkTensorCaptureDescriptorDataInfoARM* pInfo, void* pData)
        {
            return _vkGetTensorOpaqueCaptureDescriptorDataARM_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: VK_ARM_tensors]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetTensorViewOpaqueCaptureDescriptorDataARM.html" /></remarks>
        public VkResult GetTensorViewOpaqueCaptureDescriptorDataARM(VkDevice device, VkTensorViewCaptureDescriptorDataInfoARM* pInfo, void* pData)
        {
            return _vkGetTensorViewOpaqueCaptureDescriptorDataARM_fnptr(device, pInfo, pData);
        }
        /// <summary><b>[requires: VK_EXT_validation_cache]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetValidationCacheDataEXT.html" /></remarks>
        public VkResult GetValidationCacheDataEXT(VkDevice device, VkValidationCacheEXT validationCache, nuint* pDataSize, void* pData)
        {
            return _vkGetValidationCacheDataEXT_fnptr(device, validationCache, pDataSize, pData);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetVideoSessionMemoryRequirementsKHR.html" /></remarks>
        public VkResult GetVideoSessionMemoryRequirementsKHR(VkDevice device, VkVideoSessionKHR videoSession, uint* pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
        {
            return _vkGetVideoSessionMemoryRequirementsKHR_fnptr(device, videoSession, pMemoryRequirementsCount, pMemoryRequirements);
        }
        /// <summary><b>[requires: VK_KHR_external_fence_fd]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportFenceFdKHR.html" /></remarks>
        public VkResult ImportFenceFdKHR(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo)
        {
            return _vkImportFenceFdKHR_fnptr(device, pImportFenceFdInfo);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync | VK_NV_external_sci_sync2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportFenceSciSyncFenceNV.html" /></remarks>
        public VkResult ImportFenceSciSyncFenceNV(VkDevice device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo)
        {
            return _vkImportFenceSciSyncFenceNV_fnptr(device, pImportFenceSciSyncInfo);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync | VK_NV_external_sci_sync2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportFenceSciSyncObjNV.html" /></remarks>
        public VkResult ImportFenceSciSyncObjNV(VkDevice device, VkImportFenceSciSyncInfoNV* pImportFenceSciSyncInfo)
        {
            return _vkImportFenceSciSyncObjNV_fnptr(device, pImportFenceSciSyncInfo);
        }
        /// <summary><b>[requires: VK_KHR_external_fence_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportFenceWin32HandleKHR.html" /></remarks>
        public VkResult ImportFenceWin32HandleKHR(VkDevice device, VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
        {
            return _vkImportFenceWin32HandleKHR_fnptr(device, pImportFenceWin32HandleInfo);
        }
        /// <summary><b>[requires: VK_KHR_external_semaphore_fd]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreFdKHR.html" /></remarks>
        public VkResult ImportSemaphoreFdKHR(VkDevice device, VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo)
        {
            return _vkImportSemaphoreFdKHR_fnptr(device, pImportSemaphoreFdInfo);
        }
        /// <summary><b>[requires: VK_NV_external_sci_sync]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreSciSyncObjNV.html" /></remarks>
        public VkResult ImportSemaphoreSciSyncObjNV(VkDevice device, VkImportSemaphoreSciSyncInfoNV* pImportSemaphoreSciSyncInfo)
        {
            return _vkImportSemaphoreSciSyncObjNV_fnptr(device, pImportSemaphoreSciSyncInfo);
        }
        /// <summary><b>[requires: VK_KHR_external_semaphore_win32]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreWin32HandleKHR.html" /></remarks>
        public VkResult ImportSemaphoreWin32HandleKHR(VkDevice device, VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo)
        {
            return _vkImportSemaphoreWin32HandleKHR_fnptr(device, pImportSemaphoreWin32HandleInfo);
        }
        /// <summary><b>[requires: VK_FUCHSIA_external_semaphore]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreZirconHandleFUCHSIA.html" /></remarks>
        public VkResult ImportSemaphoreZirconHandleFUCHSIA(VkDevice device, VkImportSemaphoreZirconHandleInfoFUCHSIA* pImportSemaphoreZirconHandleInfo)
        {
            return _vkImportSemaphoreZirconHandleFUCHSIA_fnptr(device, pImportSemaphoreZirconHandleInfo);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkInitializePerformanceApiINTEL.html" /></remarks>
        public VkResult InitializePerformanceApiINTEL(VkDevice device, VkInitializePerformanceApiInfoINTEL* pInitializeInfo)
        {
            return _vkInitializePerformanceApiINTEL_fnptr(device, pInitializeInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkInvalidateMappedMemoryRanges.html" /></remarks>
        public VkResult InvalidateMappedMemoryRanges(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
        {
            return _vkInvalidateMappedMemoryRanges_fnptr(device, memoryRangeCount, pMemoryRanges);
        }
        /// <summary><b>[requires: VK_NV_low_latency2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkLatencySleepNV.html" /></remarks>
        public VkResult LatencySleepNV(VkDevice device, VkSwapchainKHR swapchain, VkLatencySleepInfoNV* pSleepInfo)
        {
            return _vkLatencySleepNV_fnptr(device, swapchain, pSleepInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkMapMemory.html" /></remarks>
        public VkResult MapMemory(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, VkMemoryMapFlagBits flags, void** ppData)
        {
            return _vkMapMemory_fnptr(device, memory, offset, size, flags, ppData);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkMapMemory2.html" /></remarks>
        public VkResult MapMemory2(VkDevice device, VkMemoryMapInfo* pMemoryMapInfo, void** ppData)
        {
            return _vkMapMemory2_fnptr(device, pMemoryMapInfo, ppData);
        }
        /// <summary><b>[requires: VK_KHR_map_memory2]</b> [device command]  Alias of <see cref="MapMemory2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkMapMemory2KHR.html" /></remarks>
        public VkResult MapMemory2KHR(VkDevice device, VkMemoryMapInfo* pMemoryMapInfo, void** ppData)
        {
            return _vkMapMemory2KHR_fnptr(device, pMemoryMapInfo, ppData);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkMergePipelineCaches.html" /></remarks>
        public VkResult MergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches)
        {
            return _vkMergePipelineCaches_fnptr(device, dstCache, srcCacheCount, pSrcCaches);
        }
        /// <summary><b>[requires: VK_EXT_validation_cache]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkMergeValidationCachesEXT.html" /></remarks>
        public VkResult MergeValidationCachesEXT(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches)
        {
            return _vkMergeValidationCachesEXT_fnptr(device, dstCache, srcCacheCount, pSrcCaches);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueBeginDebugUtilsLabelEXT.html" /></remarks>
        public void QueueBeginDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            _vkQueueBeginDebugUtilsLabelEXT_fnptr(queue, pLabelInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueBindSparse.html" /></remarks>
        public VkResult QueueBindSparse(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence)
        {
            return _vkQueueBindSparse_fnptr(queue, bindInfoCount, pBindInfo, fence);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueEndDebugUtilsLabelEXT.html" /></remarks>
        public void QueueEndDebugUtilsLabelEXT(VkQueue queue)
        {
            _vkQueueEndDebugUtilsLabelEXT_fnptr(queue);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueInsertDebugUtilsLabelEXT.html" /></remarks>
        public void QueueInsertDebugUtilsLabelEXT(VkQueue queue, VkDebugUtilsLabelEXT* pLabelInfo)
        {
            _vkQueueInsertDebugUtilsLabelEXT_fnptr(queue, pLabelInfo);
        }
        /// <summary><b>[requires: VK_NV_low_latency2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueNotifyOutOfBandNV.html" /></remarks>
        public void QueueNotifyOutOfBandNV(VkQueue queue, VkOutOfBandQueueTypeInfoNV* pQueueTypeInfo)
        {
            _vkQueueNotifyOutOfBandNV_fnptr(queue, pQueueTypeInfo);
        }
        /// <summary><b>[requires: VK_KHR_swapchain]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueuePresentKHR.html" /></remarks>
        public VkResult QueuePresentKHR(VkQueue queue, VkPresentInfoKHR* pPresentInfo)
        {
            return _vkQueuePresentKHR_fnptr(queue, pPresentInfo);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueSetPerformanceConfigurationINTEL.html" /></remarks>
        public VkResult QueueSetPerformanceConfigurationINTEL(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
        {
            return _vkQueueSetPerformanceConfigurationINTEL_fnptr(queue, configuration);
        }
        /// <summary>[device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueSignalReleaseImageANDROID.html" /></remarks>
        public VkResult QueueSignalReleaseImageANDROID(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, int* pNativeFenceFd)
        {
            return _vkQueueSignalReleaseImageANDROID_fnptr(queue, waitSemaphoreCount, pWaitSemaphores, image, pNativeFenceFd);
        }
        /// <summary><b>[requires: VK_OHOS_native_buffer]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueSignalReleaseImageOHOS.html" /></remarks>
        public VkResult QueueSignalReleaseImageOHOS(VkQueue queue, uint waitSemaphoreCount, VkSemaphore* pWaitSemaphores, VkImage image, int* pNativeFenceFd)
        {
            return _vkQueueSignalReleaseImageOHOS_fnptr(queue, waitSemaphoreCount, pWaitSemaphores, image, pNativeFenceFd);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueSubmit.html" /></remarks>
        public VkResult QueueSubmit(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence)
        {
            return _vkQueueSubmit_fnptr(queue, submitCount, pSubmits, fence);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueSubmit2.html" /></remarks>
        public VkResult QueueSubmit2(VkQueue queue, uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence)
        {
            return _vkQueueSubmit2_fnptr(queue, submitCount, pSubmits, fence);
        }
        /// <summary><b>[requires: VK_KHR_synchronization2]</b> [device command]  Alias of <see cref="QueueSubmit2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueSubmit2KHR.html" /></remarks>
        public VkResult QueueSubmit2KHR(VkQueue queue, uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence)
        {
            return _vkQueueSubmit2KHR_fnptr(queue, submitCount, pSubmits, fence);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkQueueWaitIdle.html" /></remarks>
        public VkResult QueueWaitIdle(VkQueue queue)
        {
            return _vkQueueWaitIdle_fnptr(queue);
        }
        /// <summary><b>[requires: VK_EXT_display_control]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkRegisterDeviceEventEXT.html" /></remarks>
        public VkResult RegisterDeviceEventEXT(VkDevice device, VkDeviceEventInfoEXT* pDeviceEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            return _vkRegisterDeviceEventEXT_fnptr(device, pDeviceEventInfo, pAllocator, pFence);
        }
        /// <summary><b>[requires: VK_EXT_display_control]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkRegisterDisplayEventEXT.html" /></remarks>
        public VkResult RegisterDisplayEventEXT(VkDevice device, VkDisplayKHR display, VkDisplayEventInfoEXT* pDisplayEventInfo, VkAllocationCallbacks* pAllocator, VkFence* pFence)
        {
            return _vkRegisterDisplayEventEXT_fnptr(device, display, pDisplayEventInfo, pAllocator, pFence);
        }
        /// <summary><b>[requires: VK_KHR_pipeline_binary]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseCapturedPipelineDataKHR.html" /></remarks>
        public VkResult ReleaseCapturedPipelineDataKHR(VkDevice device, VkReleaseCapturedPipelineDataInfoKHR* pInfo, VkAllocationCallbacks* pAllocator)
        {
            return _vkReleaseCapturedPipelineDataKHR_fnptr(device, pInfo, pAllocator);
        }
        /// <summary><b>[requires: VK_EXT_full_screen_exclusive]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseFullScreenExclusiveModeEXT.html" /></remarks>
        public VkResult ReleaseFullScreenExclusiveModeEXT(VkDevice device, VkSwapchainKHR swapchain)
        {
            return _vkReleaseFullScreenExclusiveModeEXT_fnptr(device, swapchain);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleasePerformanceConfigurationINTEL.html" /></remarks>
        public VkResult ReleasePerformanceConfigurationINTEL(VkDevice device, VkPerformanceConfigurationINTEL configuration)
        {
            return _vkReleasePerformanceConfigurationINTEL_fnptr(device, configuration);
        }
        /// <summary><b>[requires: VK_KHR_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseProfilingLockKHR.html" /></remarks>
        public void ReleaseProfilingLockKHR(VkDevice device)
        {
            _vkReleaseProfilingLockKHR_fnptr(device);
        }
        /// <summary><b>[requires: VK_EXT_swapchain_maintenance1]</b> [device command]  Alias of <see cref="ReleaseSwapchainImagesKHR"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseSwapchainImagesEXT.html" /></remarks>
        public VkResult ReleaseSwapchainImagesEXT(VkDevice device, VkReleaseSwapchainImagesInfoKHR* pReleaseInfo)
        {
            return _vkReleaseSwapchainImagesEXT_fnptr(device, pReleaseInfo);
        }
        /// <summary><b>[requires: VK_KHR_swapchain_maintenance1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseSwapchainImagesKHR.html" /></remarks>
        public VkResult ReleaseSwapchainImagesKHR(VkDevice device, VkReleaseSwapchainImagesInfoKHR* pReleaseInfo)
        {
            return _vkReleaseSwapchainImagesKHR_fnptr(device, pReleaseInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetCommandBuffer.html" /></remarks>
        public VkResult ResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlagBits flags)
        {
            return _vkResetCommandBuffer_fnptr(commandBuffer, flags);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetCommandPool.html" /></remarks>
        public VkResult ResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlagBits flags)
        {
            return _vkResetCommandPool_fnptr(device, commandPool, flags);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetDescriptorPool.html" /></remarks>
        public VkResult ResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags)
        {
            return _vkResetDescriptorPool_fnptr(device, descriptorPool, flags);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetEvent.html" /></remarks>
        public VkResult ResetEvent(VkDevice device, VkEvent @event)
        {
            return _vkResetEvent_fnptr(device, @event);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetFences.html" /></remarks>
        public VkResult ResetFences(VkDevice device, uint fenceCount, VkFence* pFences)
        {
            return _vkResetFences_fnptr(device, fenceCount, pFences);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetQueryPool.html" /></remarks>
        public void ResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            _vkResetQueryPool_fnptr(device, queryPool, firstQuery, queryCount);
        }
        /// <summary><b>[requires: VK_EXT_host_query_reset]</b> [device command]  Alias of <see cref="ResetQueryPool"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkResetQueryPoolEXT.html" /></remarks>
        public void ResetQueryPoolEXT(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            _vkResetQueryPoolEXT_fnptr(device, queryPool, firstQuery, queryCount);
        }
        /// <summary><b>[requires: VK_FUCHSIA_buffer_collection]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetBufferCollectionBufferConstraintsFUCHSIA.html" /></remarks>
        public VkResult SetBufferCollectionBufferConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkBufferConstraintsInfoFUCHSIA* pBufferConstraintsInfo)
        {
            return _vkSetBufferCollectionBufferConstraintsFUCHSIA_fnptr(device, collection, pBufferConstraintsInfo);
        }
        /// <summary><b>[requires: VK_FUCHSIA_buffer_collection]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetBufferCollectionImageConstraintsFUCHSIA.html" /></remarks>
        public VkResult SetBufferCollectionImageConstraintsFUCHSIA(VkDevice device, VkBufferCollectionFUCHSIA collection, VkImageConstraintsInfoFUCHSIA* pImageConstraintsInfo)
        {
            return _vkSetBufferCollectionImageConstraintsFUCHSIA_fnptr(device, collection, pImageConstraintsInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetDebugUtilsObjectNameEXT.html" /></remarks>
        public VkResult SetDebugUtilsObjectNameEXT(VkDevice device, VkDebugUtilsObjectNameInfoEXT* pNameInfo)
        {
            return _vkSetDebugUtilsObjectNameEXT_fnptr(device, pNameInfo);
        }
        /// <summary><b>[requires: VK_EXT_debug_utils]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetDebugUtilsObjectTagEXT.html" /></remarks>
        public VkResult SetDebugUtilsObjectTagEXT(VkDevice device, VkDebugUtilsObjectTagInfoEXT* pTagInfo)
        {
            return _vkSetDebugUtilsObjectTagEXT_fnptr(device, pTagInfo);
        }
        /// <summary><b>[requires: VK_EXT_pageable_device_local_memory]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetDeviceMemoryPriorityEXT.html" /></remarks>
        public void SetDeviceMemoryPriorityEXT(VkDevice device, VkDeviceMemory memory, float priority)
        {
            _vkSetDeviceMemoryPriorityEXT_fnptr(device, memory, priority);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetEvent.html" /></remarks>
        public VkResult SetEvent(VkDevice device, VkEvent @event)
        {
            return _vkSetEvent_fnptr(device, @event);
        }
        /// <summary><b>[requires: VK_EXT_hdr_metadata]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetHdrMetadataEXT.html" /></remarks>
        public void SetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata)
        {
            _vkSetHdrMetadataEXT_fnptr(device, swapchainCount, pSwapchains, pMetadata);
        }
        /// <summary><b>[requires: VK_NV_low_latency2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetLatencyMarkerNV.html" /></remarks>
        public void SetLatencyMarkerNV(VkDevice device, VkSwapchainKHR swapchain, VkSetLatencyMarkerInfoNV* pLatencyMarkerInfo)
        {
            _vkSetLatencyMarkerNV_fnptr(device, swapchain, pLatencyMarkerInfo);
        }
        /// <summary><b>[requires: VK_NV_low_latency2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetLatencySleepModeNV.html" /></remarks>
        public VkResult SetLatencySleepModeNV(VkDevice device, VkSwapchainKHR swapchain, VkLatencySleepModeInfoNV* pSleepModeInfo)
        {
            return _vkSetLatencySleepModeNV_fnptr(device, swapchain, pSleepModeInfo);
        }
        /// <summary><b>[requires: VK_AMD_display_native_hdr]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetLocalDimmingAMD.html" /></remarks>
        public void SetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, int localDimmingEnable)
        {
            _vkSetLocalDimmingAMD_fnptr(device, swapChain, localDimmingEnable);
        }
        /// <summary><b>[requires: v1.3]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetPrivateData.html" /></remarks>
        public VkResult SetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data)
        {
            return _vkSetPrivateData_fnptr(device, objectType, objectHandle, privateDataSlot, data);
        }
        /// <summary><b>[requires: VK_EXT_private_data]</b> [device command]  Alias of <see cref="SetPrivateData"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetPrivateDataEXT.html" /></remarks>
        public VkResult SetPrivateDataEXT(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data)
        {
            return _vkSetPrivateDataEXT_fnptr(device, objectType, objectHandle, privateDataSlot, data);
        }
        /// <summary><b>[requires: VK_EXT_present_timing]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSetSwapchainPresentTimingQueueSizeEXT.html" /></remarks>
        public VkResult SetSwapchainPresentTimingQueueSizeEXT(VkDevice device, VkSwapchainKHR swapchain, uint size)
        {
            return _vkSetSwapchainPresentTimingQueueSizeEXT_fnptr(device, swapchain, size);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSignalSemaphore.html" /></remarks>
        public VkResult SignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo)
        {
            return _vkSignalSemaphore_fnptr(device, pSignalInfo);
        }
        /// <summary><b>[requires: VK_KHR_timeline_semaphore]</b> [device command]  Alias of <see cref="SignalSemaphore"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSignalSemaphoreKHR.html" /></remarks>
        public VkResult SignalSemaphoreKHR(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo)
        {
            return _vkSignalSemaphoreKHR_fnptr(device, pSignalInfo);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkTransitionImageLayout.html" /></remarks>
        public VkResult TransitionImageLayout(VkDevice device, uint transitionCount, VkHostImageLayoutTransitionInfo* pTransitions)
        {
            return _vkTransitionImageLayout_fnptr(device, transitionCount, pTransitions);
        }
        /// <summary><b>[requires: VK_EXT_host_image_copy]</b> [device command]  Alias of <see cref="TransitionImageLayout"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkTransitionImageLayoutEXT.html" /></remarks>
        public VkResult TransitionImageLayoutEXT(VkDevice device, uint transitionCount, VkHostImageLayoutTransitionInfo* pTransitions)
        {
            return _vkTransitionImageLayoutEXT_fnptr(device, transitionCount, pTransitions);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkTrimCommandPool.html" /></remarks>
        public void TrimCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags)
        {
            _vkTrimCommandPool_fnptr(device, commandPool, flags);
        }
        /// <summary><b>[requires: VK_KHR_maintenance1]</b> [device command]  Alias of <see cref="TrimCommandPool"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkTrimCommandPoolKHR.html" /></remarks>
        public void TrimCommandPoolKHR(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags)
        {
            _vkTrimCommandPoolKHR_fnptr(device, commandPool, flags);
        }
        /// <summary><b>[requires: VK_INTEL_performance_query]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUninitializePerformanceApiINTEL.html" /></remarks>
        public void UninitializePerformanceApiINTEL(VkDevice device)
        {
            _vkUninitializePerformanceApiINTEL_fnptr(device);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUnmapMemory.html" /></remarks>
        public void UnmapMemory(VkDevice device, VkDeviceMemory memory)
        {
            _vkUnmapMemory_fnptr(device, memory);
        }
        /// <summary><b>[requires: v1.4]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUnmapMemory2.html" /></remarks>
        public VkResult UnmapMemory2(VkDevice device, VkMemoryUnmapInfo* pMemoryUnmapInfo)
        {
            return _vkUnmapMemory2_fnptr(device, pMemoryUnmapInfo);
        }
        /// <summary><b>[requires: VK_KHR_map_memory2]</b> [device command]  Alias of <see cref="UnmapMemory2"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUnmapMemory2KHR.html" /></remarks>
        public VkResult UnmapMemory2KHR(VkDevice device, VkMemoryUnmapInfo* pMemoryUnmapInfo)
        {
            return _vkUnmapMemory2KHR_fnptr(device, pMemoryUnmapInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSets.html" /></remarks>
        public void UpdateDescriptorSets(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies)
        {
            _vkUpdateDescriptorSets_fnptr(device, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);
        }
        /// <summary><b>[requires: v1.1]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplate.html" /></remarks>
        public void UpdateDescriptorSetWithTemplate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
        {
            _vkUpdateDescriptorSetWithTemplate_fnptr(device, descriptorSet, descriptorUpdateTemplate, pData);
        }
        /// <summary><b>[requires: VK_KHR_descriptor_update_template]</b> [device command]  Alias of <see cref="UpdateDescriptorSetWithTemplate"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplateKHR.html" /></remarks>
        public void UpdateDescriptorSetWithTemplateKHR(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
        {
            _vkUpdateDescriptorSetWithTemplateKHR_fnptr(device, descriptorSet, descriptorUpdateTemplate, pData);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUpdateIndirectExecutionSetPipelineEXT.html" /></remarks>
        public void UpdateIndirectExecutionSetPipelineEXT(VkDevice device, VkIndirectExecutionSetEXT indirectExecutionSet, uint executionSetWriteCount, VkWriteIndirectExecutionSetPipelineEXT* pExecutionSetWrites)
        {
            _vkUpdateIndirectExecutionSetPipelineEXT_fnptr(device, indirectExecutionSet, executionSetWriteCount, pExecutionSetWrites);
        }
        /// <summary><b>[requires: VK_EXT_device_generated_commands]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUpdateIndirectExecutionSetShaderEXT.html" /></remarks>
        public void UpdateIndirectExecutionSetShaderEXT(VkDevice device, VkIndirectExecutionSetEXT indirectExecutionSet, uint executionSetWriteCount, VkWriteIndirectExecutionSetShaderEXT* pExecutionSetWrites)
        {
            _vkUpdateIndirectExecutionSetShaderEXT_fnptr(device, indirectExecutionSet, executionSetWriteCount, pExecutionSetWrites);
        }
        /// <summary><b>[requires: VK_KHR_video_queue]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkUpdateVideoSessionParametersKHR.html" /></remarks>
        public VkResult UpdateVideoSessionParametersKHR(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo)
        {
            return _vkUpdateVideoSessionParametersKHR_fnptr(device, videoSessionParameters, pUpdateInfo);
        }
        /// <summary><b>[requires: v1.0]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWaitForFences.html" /></remarks>
        public VkResult WaitForFences(VkDevice device, uint fenceCount, VkFence* pFences, int waitAll, ulong timeout)
        {
            return _vkWaitForFences_fnptr(device, fenceCount, pFences, waitAll, timeout);
        }
        /// <summary><b>[requires: VK_KHR_present_wait2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWaitForPresent2KHR.html" /></remarks>
        public VkResult WaitForPresent2KHR(VkDevice device, VkSwapchainKHR swapchain, VkPresentWait2InfoKHR* pPresentWait2Info)
        {
            return _vkWaitForPresent2KHR_fnptr(device, swapchain, pPresentWait2Info);
        }
        /// <summary><b>[requires: VK_KHR_present_wait]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWaitForPresentKHR.html" /></remarks>
        public VkResult WaitForPresentKHR(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout)
        {
            return _vkWaitForPresentKHR_fnptr(device, swapchain, presentId, timeout);
        }
        /// <summary><b>[requires: v1.2]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWaitSemaphores.html" /></remarks>
        public VkResult WaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
        {
            return _vkWaitSemaphores_fnptr(device, pWaitInfo, timeout);
        }
        /// <summary><b>[requires: VK_KHR_timeline_semaphore]</b> [device command]  Alias of <see cref="WaitSemaphores"/></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWaitSemaphoresKHR.html" /></remarks>
        public VkResult WaitSemaphoresKHR(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
        {
            return _vkWaitSemaphoresKHR_fnptr(device, pWaitInfo, timeout);
        }
        /// <summary><b>[requires: VK_KHR_acceleration_structure]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWriteAccelerationStructuresPropertiesKHR.html" /></remarks>
        public VkResult WriteAccelerationStructuresPropertiesKHR(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, nuint dataSize, void* pData, nuint stride)
        {
            return _vkWriteAccelerationStructuresPropertiesKHR_fnptr(device, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);
        }
        /// <summary><b>[requires: VK_EXT_opacity_micromap]</b> [device command] </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkWriteMicromapsPropertiesEXT.html" /></remarks>
        public VkResult WriteMicromapsPropertiesEXT(VkDevice device, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, nuint dataSize, void* pData, nuint stride)
        {
            return _vkWriteMicromapsPropertiesEXT_fnptr(device, micromapCount, pMicromaps, queryType, dataSize, pData, stride);
        }
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult> _vkAcquireFullScreenExclusiveModeEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkImage, int, VkSemaphore, VkFence, VkResult> _vkAcquireImageANDROID_fnptr;
        public delegate* unmanaged<VkDevice, VkImage, int, VkSemaphore, VkFence, VkResult> _vkAcquireImageOHOS_fnptr;
        public delegate* unmanaged<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult> _vkAcquireNextImage2KHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, uint*, VkResult> _vkAcquireNextImageKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult> _vkAcquirePerformanceConfigurationINTEL_fnptr;
        public delegate* unmanaged<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult> _vkAcquireProfilingLockKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkCommandBufferAllocateInfo*, VkCommandBuffer*, VkResult> _vkAllocateCommandBuffers_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorSetAllocateInfo*, VkDescriptorSet*, VkResult> _vkAllocateDescriptorSets_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory*, VkResult> _vkAllocateMemory_fnptr;
        public delegate* unmanaged<VkDevice, VkAntiLagDataAMD*, void> _vkAntiLagUpdateAMD_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCommandBufferBeginInfo*, VkResult> _vkBeginCommandBuffer_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult> _vkBindAccelerationStructureMemoryNV_fnptr;
        public delegate* unmanaged<VkDevice, VkBuffer, VkDeviceMemory, ulong, VkResult> _vkBindBufferMemory_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> _vkBindBufferMemory2_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> _vkBindBufferMemory2KHR_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkBindDataGraphPipelineSessionMemoryInfoARM*, VkResult> _vkBindDataGraphPipelineSessionMemoryARM_fnptr;
        public delegate* unmanaged<VkDevice, VkImage, VkDeviceMemory, ulong, VkResult> _vkBindImageMemory_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> _vkBindImageMemory2_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> _vkBindImageMemory2KHR_fnptr;
        public delegate* unmanaged<VkDevice, VkOpticalFlowSessionNV, VkOpticalFlowSessionBindingPointNV, VkImageView, VkImageLayout, VkResult> _vkBindOpticalFlowSessionImageNV_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkBindTensorMemoryInfoARM*, VkResult> _vkBindTensorMemoryARM_fnptr;
        public delegate* unmanaged<VkDevice, VkVideoSessionKHR, uint, VkBindVideoSessionMemoryInfoKHR*, VkResult> _vkBindVideoSessionMemoryKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult> _vkBuildAccelerationStructuresKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult> _vkBuildMicromapsEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void> _vkCmdBeginConditionalRenderingEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBeginCustomResolveInfoEXT*, void> _vkCmdBeginCustomResolveEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> _vkCmdBeginDebugUtilsLabelEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPerTileBeginInfoQCOM*, void> _vkCmdBeginPerTileExecutionQCOM_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlagBits, void> _vkCmdBeginQuery_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlagBits, uint, void> _vkCmdBeginQueryIndexedEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkRenderingInfo*, void> _vkCmdBeginRendering_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkRenderingInfo*, void> _vkCmdBeginRenderingKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassContents, void> _vkCmdBeginRenderPass_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void> _vkCmdBeginRenderPass2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void> _vkCmdBeginRenderPass2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> _vkCmdBeginTransformFeedbackEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void> _vkCmdBeginVideoCodingKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT*, void> _vkCmdBindDescriptorBufferEmbeddedSamplers2EXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void> _vkCmdBindDescriptorBufferEmbeddedSamplersEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkDescriptorBufferBindingInfoEXT*, void> _vkCmdBindDescriptorBuffersEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkDescriptorSet*, uint, uint*, void> _vkCmdBindDescriptorSets_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBindDescriptorSetsInfo*, void> _vkCmdBindDescriptorSets2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBindDescriptorSetsInfo*, void> _vkCmdBindDescriptorSets2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkIndexType, void> _vkCmdBindIndexBuffer_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, VkIndexType, void> _vkCmdBindIndexBuffer2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, VkIndexType, void> _vkCmdBindIndexBuffer2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void> _vkCmdBindInvocationMaskHUAWEI_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> _vkCmdBindPipeline_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, uint, void> _vkCmdBindPipelineShaderGroupNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkShaderStageFlagBits*, VkShaderEXT*, void> _vkCmdBindShadersEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkImageView, VkImageLayout, void> _vkCmdBindShadingRateImageNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkTileMemoryBindInfoQCOM*, void> _vkCmdBindTileMemoryQCOM_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, void> _vkCmdBindTransformFeedbackBuffersEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> _vkCmdBindVertexBuffers_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, ulong*, void> _vkCmdBindVertexBuffers2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, ulong*, void> _vkCmdBindVertexBuffers2EXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageBlit*, VkFilter, void> _vkCmdBlitImage_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBlitImageInfo2*, void> _vkCmdBlitImage2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBlitImageInfo2*, void> _vkCmdBlitImage2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, ulong, int, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, ulong, void> _vkCmdBuildAccelerationStructureNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, ulong*, uint*, uint**, void> _vkCmdBuildAccelerationStructuresIndirectKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, void> _vkCmdBuildAccelerationStructuresKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkClusterAccelerationStructureCommandsInfoNV*, void> _vkCmdBuildClusterAccelerationStructureIndirectNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkMicromapBuildInfoEXT*, void> _vkCmdBuildMicromapsEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuildPartitionedAccelerationStructureInfoNV*, void> _vkCmdBuildPartitionedAccelerationStructuresNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkClearAttachment*, uint, VkClearRect*, void> _vkCmdClearAttachments_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkClearColorValue*, uint, VkImageSubresourceRange*, void> _vkCmdClearColorImage_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkClearDepthStencilValue*, uint, VkImageSubresourceRange*, void> _vkCmdClearDepthStencilImage_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void> _vkCmdControlVideoCodingKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkConvertCooperativeVectorMatrixInfoNV*, void> _vkCmdConvertCooperativeVectorMatrixNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void> _vkCmdCopyAccelerationStructureKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void> _vkCmdCopyAccelerationStructureNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void> _vkCmdCopyAccelerationStructureToMemoryKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void> _vkCmdCopyBuffer_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyBufferInfo2*, void> _vkCmdCopyBuffer2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyBufferInfo2*, void> _vkCmdCopyBuffer2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, VkImage, VkImageLayout, uint, VkBufferImageCopy*, void> _vkCmdCopyBufferToImage_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> _vkCmdCopyBufferToImage2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> _vkCmdCopyBufferToImage2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageCopy*, void> _vkCmdCopyImage_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyImageInfo2*, void> _vkCmdCopyImage2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyImageInfo2*, void> _vkCmdCopyImage2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void> _vkCmdCopyImageToBuffer_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> _vkCmdCopyImageToBuffer2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> _vkCmdCopyImageToBuffer2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyMemoryIndirectInfoKHR*, void> _vkCmdCopyMemoryIndirectKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, ulong, uint, uint, void> _vkCmdCopyMemoryIndirectNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void> _vkCmdCopyMemoryToAccelerationStructureKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToImageIndirectInfoKHR*, void> _vkCmdCopyMemoryToImageIndirectKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, ulong, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void> _vkCmdCopyMemoryToImageIndirectNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyMemoryToMicromapInfoEXT*, void> _vkCmdCopyMemoryToMicromapEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyMicromapInfoEXT*, void> _vkCmdCopyMicromapEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyMicromapToMemoryInfoEXT*, void> _vkCmdCopyMicromapToMemoryEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, VkQueryResultFlagBits, void> _vkCmdCopyQueryPoolResults_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCopyTensorInfoARM*, void> _vkCmdCopyTensorARM_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCudaLaunchInfoNV*, void> _vkCmdCudaLaunchKernelNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCuLaunchInfoNVX*, void> _vkCmdCuLaunchKernelNVX_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> _vkCmdDebugMarkerBeginEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, void> _vkCmdDebugMarkerEndEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> _vkCmdDebugMarkerInsertEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkVideoDecodeInfoKHR*, void> _vkCmdDecodeVideoKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDecompressMemoryInfoEXT*, void> _vkCmdDecompressMemoryEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkMemoryDecompressionMethodFlagBitsEXT, ulong, ulong, uint, uint, void> _vkCmdDecompressMemoryIndirectCountEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, ulong, ulong, uint, void> _vkCmdDecompressMemoryIndirectCountNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkDecompressMemoryRegionNV*, void> _vkCmdDecompressMemoryNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void> _vkCmdDispatch_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void> _vkCmdDispatchBase_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void> _vkCmdDispatchBaseKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDataGraphPipelineSessionARM, VkDataGraphPipelineDispatchInfoARM*, void> _vkCmdDispatchDataGraphARM_fnptr;
        public delegate* unmanaged<VkCommandBuffer, ulong, ulong, VkDispatchGraphCountInfoAMDX*, void> _vkCmdDispatchGraphAMDX_fnptr;
        public delegate* unmanaged<VkCommandBuffer, ulong, ulong, VkDispatchGraphCountInfoAMDX*, void> _vkCmdDispatchGraphIndirectAMDX_fnptr;
        public delegate* unmanaged<VkCommandBuffer, ulong, ulong, ulong, void> _vkCmdDispatchGraphIndirectCountAMDX_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, void> _vkCmdDispatchIndirect_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDispatchTileInfoQCOM*, void> _vkCmdDispatchTileQCOM_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, uint, uint, void> _vkCmdDraw_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void> _vkCmdDrawClusterHUAWEI_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, void> _vkCmdDrawClusterIndirectHUAWEI_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, uint, int, uint, void> _vkCmdDrawIndexed_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndexedIndirect_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndexedIndirectCount_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndexedIndirectCountAMD_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndexedIndirectCountKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndirect_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndirectByteCountEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndirectCount_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndirectCountAMD_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> _vkCmdDrawIndirectCountKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, uint, void> _vkCmdDrawMeshTasksEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> _vkCmdDrawMeshTasksIndirectCountEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> _vkCmdDrawMeshTasksIndirectCountNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> _vkCmdDrawMeshTasksIndirectEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> _vkCmdDrawMeshTasksIndirectNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, void> _vkCmdDrawMeshTasksNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkMultiDrawInfoEXT*, uint, uint, uint, void> _vkCmdDrawMultiEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkMultiDrawIndexedInfoEXT*, uint, uint, uint, int*, void> _vkCmdDrawMultiIndexedEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkVideoEncodeInfoKHR*, void> _vkCmdEncodeVideoKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, void> _vkCmdEndConditionalRenderingEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, void> _vkCmdEndDebugUtilsLabelEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPerTileEndInfoQCOM*, void> _vkCmdEndPerTileExecutionQCOM_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, void> _vkCmdEndQuery_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, void> _vkCmdEndQueryIndexedEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, void> _vkCmdEndRendering_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkRenderingEndInfoKHR*, void> _vkCmdEndRendering2EXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkRenderingEndInfoKHR*, void> _vkCmdEndRendering2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, void> _vkCmdEndRenderingKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, void> _vkCmdEndRenderPass_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkSubpassEndInfo*, void> _vkCmdEndRenderPass2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkSubpassEndInfo*, void> _vkCmdEndRenderPass2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> _vkCmdEndTransformFeedbackEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void> _vkCmdEndVideoCodingKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkCommandBuffer*, void> _vkCmdExecuteCommands_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, VkGeneratedCommandsInfoEXT*, void> _vkCmdExecuteGeneratedCommandsEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, VkGeneratedCommandsInfoNV*, void> _vkCmdExecuteGeneratedCommandsNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, uint, void> _vkCmdFillBuffer_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipeline, ulong, ulong, void> _vkCmdInitializeGraphScratchMemoryAMDX_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> _vkCmdInsertDebugUtilsLabelEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkSubpassContents, void> _vkCmdNextSubpass_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void> _vkCmdNextSubpass2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void> _vkCmdNextSubpass2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkOpticalFlowSessionNV, VkOpticalFlowExecuteInfoNV*, void> _vkCmdOpticalFlowExecuteNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits, VkPipelineStageFlagBits, VkDependencyFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void> _vkCmdPipelineBarrier_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDependencyInfo*, void> _vkCmdPipelineBarrier2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDependencyInfo*, void> _vkCmdPipelineBarrier2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkGeneratedCommandsInfoEXT*, VkCommandBuffer, void> _vkCmdPreprocessGeneratedCommandsEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void> _vkCmdPreprocessGeneratedCommandsNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineLayout, VkShaderStageFlagBits, uint, uint, void*, void> _vkCmdPushConstants_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPushConstantsInfo*, void> _vkCmdPushConstants2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPushConstantsInfo*, void> _vkCmdPushConstants2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void> _vkCmdPushDescriptorSet_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetInfo*, void> _vkCmdPushDescriptorSet2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetInfo*, void> _vkCmdPushDescriptorSet2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void> _vkCmdPushDescriptorSetKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> _vkCmdPushDescriptorSetWithTemplate_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfo*, void> _vkCmdPushDescriptorSetWithTemplate2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfo*, void> _vkCmdPushDescriptorSetWithTemplate2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> _vkCmdPushDescriptorSetWithTemplateKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkRefreshObjectListKHR*, void> _vkCmdRefreshObjectsKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits, void> _vkCmdResetEvent_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits2, void> _vkCmdResetEvent2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits2, void> _vkCmdResetEvent2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkQueryPool, uint, uint, void> _vkCmdResetQueryPool_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageResolve*, void> _vkCmdResolveImage_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkResolveImageInfo2*, void> _vkCmdResolveImage2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkResolveImageInfo2*, void> _vkCmdResolveImage2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetAlphaToCoverageEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetAlphaToOneEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkImageAspectFlagBits, void> _vkCmdSetAttachmentFeedbackLoopEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, float*, void> _vkCmdSetBlendConstants_fnptr;
        public delegate* unmanaged<VkCommandBuffer, void*, void> _vkCmdSetCheckpointNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void> _vkCmdSetCoarseSampleOrderNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorBlendAdvancedEXT*, void> _vkCmdSetColorBlendAdvancedEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, int*, void> _vkCmdSetColorBlendEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorBlendEquationEXT*, void> _vkCmdSetColorBlendEquationEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, int*, void> _vkCmdSetColorWriteEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkColorComponentFlagBits*, void> _vkCmdSetColorWriteMaskEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkConservativeRasterizationModeEXT, void> _vkCmdSetConservativeRasterizationModeEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCoverageModulationModeNV, void> _vkCmdSetCoverageModulationModeNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetCoverageModulationTableEnableNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, float*, void> _vkCmdSetCoverageModulationTableNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCoverageReductionModeNV, void> _vkCmdSetCoverageReductionModeNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetCoverageToColorEnableNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, void> _vkCmdSetCoverageToColorLocationNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCullModeFlagBits, void> _vkCmdSetCullMode_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCullModeFlagBits, void> _vkCmdSetCullModeEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, float, float, float, void> _vkCmdSetDepthBias_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDepthBiasInfoEXT*, void> _vkCmdSetDepthBias2EXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthBiasEnable_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthBiasEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, float, float, void> _vkCmdSetDepthBounds_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthBoundsTestEnable_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthBoundsTestEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthClampEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDepthClampModeEXT, VkDepthClampRangeEXT*, void> _vkCmdSetDepthClampRangeEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthClipEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthClipNegativeOneToOneEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCompareOp, void> _vkCmdSetDepthCompareOp_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCompareOp, void> _vkCmdSetDepthCompareOpEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthTestEnable_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthTestEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthWriteEnable_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDepthWriteEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkSetDescriptorBufferOffsetsInfoEXT*, void> _vkCmdSetDescriptorBufferOffsets2EXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, uint*, ulong*, void> _vkCmdSetDescriptorBufferOffsetsEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, void> _vkCmdSetDeviceMask_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, void> _vkCmdSetDeviceMaskKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetDiscardRectangleEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void> _vkCmdSetDiscardRectangleEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkDiscardRectangleModeEXT, void> _vkCmdSetDiscardRectangleModeEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkEvent, VkPipelineStageFlagBits, void> _vkCmdSetEvent_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> _vkCmdSetEvent2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> _vkCmdSetEvent2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, int*, void> _vkCmdSetExclusiveScissorEnableNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void> _vkCmdSetExclusiveScissorNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, float, void> _vkCmdSetExtraPrimitiveOverestimationSizeEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkFragmentShadingRateNV, VkFragmentShadingRateCombinerOpKHR*, void> _vkCmdSetFragmentShadingRateEnumNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkExtent2D*, VkFragmentShadingRateCombinerOpKHR*, void> _vkCmdSetFragmentShadingRateKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkFrontFace, void> _vkCmdSetFrontFace_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkFrontFace, void> _vkCmdSetFrontFaceEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkLineRasterizationMode, void> _vkCmdSetLineRasterizationModeEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, ushort, void> _vkCmdSetLineStipple_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetLineStippleEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, ushort, void> _vkCmdSetLineStippleEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, ushort, void> _vkCmdSetLineStippleKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, float, void> _vkCmdSetLineWidth_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetLogicOpEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkLogicOp, void> _vkCmdSetLogicOpEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, void> _vkCmdSetPatchControlPointsEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult> _vkCmdSetPerformanceMarkerINTEL_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult> _vkCmdSetPerformanceOverrideINTEL_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult> _vkCmdSetPerformanceStreamMarkerINTEL_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPolygonMode, void> _vkCmdSetPolygonModeEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetPrimitiveRestartEnable_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetPrimitiveRestartEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPrimitiveTopology, void> _vkCmdSetPrimitiveTopology_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPrimitiveTopology, void> _vkCmdSetPrimitiveTopologyEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkProvokingVertexModeEXT, void> _vkCmdSetProvokingVertexModeEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkSampleCountFlagBits, void> _vkCmdSetRasterizationSamplesEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, void> _vkCmdSetRasterizationStreamEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetRasterizerDiscardEnable_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetRasterizerDiscardEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, void> _vkCmdSetRayTracingPipelineStackSizeKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkRenderingAttachmentLocationInfo*, void> _vkCmdSetRenderingAttachmentLocations_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkRenderingAttachmentLocationInfo*, void> _vkCmdSetRenderingAttachmentLocationsKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkRenderingInputAttachmentIndexInfo*, void> _vkCmdSetRenderingInputAttachmentIndices_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkRenderingInputAttachmentIndexInfo*, void> _vkCmdSetRenderingInputAttachmentIndicesKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetRepresentativeFragmentTestEnableNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetSampleLocationsEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkSampleLocationsInfoEXT*, void> _vkCmdSetSampleLocationsEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkSampleCountFlagBits, uint*, void> _vkCmdSetSampleMaskEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkRect2D*, void> _vkCmdSetScissor_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkRect2D*, void> _vkCmdSetScissorWithCount_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkRect2D*, void> _vkCmdSetScissorWithCountEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetShadingRateImageEnableNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, uint, void> _vkCmdSetStencilCompareMask_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void> _vkCmdSetStencilOp_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void> _vkCmdSetStencilOpEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, uint, void> _vkCmdSetStencilReference_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetStencilTestEnable_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetStencilTestEnableEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkStencilFaceFlagBits, uint, void> _vkCmdSetStencilWriteMask_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkTessellationDomainOrigin, void> _vkCmdSetTessellationDomainOriginEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void> _vkCmdSetVertexInputEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewport*, void> _vkCmdSetViewport_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void> _vkCmdSetViewportShadingRatePaletteNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewportSwizzleNV*, void> _vkCmdSetViewportSwizzleNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkViewport*, void> _vkCmdSetViewportWithCount_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkViewport*, void> _vkCmdSetViewportWithCountEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, int, void> _vkCmdSetViewportWScalingEnableNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, uint, VkViewportWScalingNV*, void> _vkCmdSetViewportWScalingNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, void> _vkCmdSubpassShadingHUAWEI_fnptr;
        public delegate* unmanaged<VkCommandBuffer, ulong, void> _vkCmdTraceRaysIndirect2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, ulong, void> _vkCmdTraceRaysIndirectKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint, void> _vkCmdTraceRaysKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, uint, uint, uint, void> _vkCmdTraceRaysNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkBuffer, ulong, ulong, void*, void> _vkCmdUpdateBuffer_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> _vkCmdUpdatePipelineIndirectBufferNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkPipelineStageFlagBits, VkPipelineStageFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void> _vkCmdWaitEvents_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void> _vkCmdWaitEvents2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void> _vkCmdWaitEvents2KHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void> _vkCmdWriteAccelerationStructuresPropertiesKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void> _vkCmdWriteAccelerationStructuresPropertiesNV_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits2, VkBuffer, ulong, uint, void> _vkCmdWriteBufferMarker2AMD_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits, VkBuffer, ulong, uint, void> _vkCmdWriteBufferMarkerAMD_fnptr;
        public delegate* unmanaged<VkCommandBuffer, uint, VkMicromapEXT*, VkQueryType, VkQueryPool, uint, void> _vkCmdWriteMicromapsPropertiesEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits, VkQueryPool, uint, void> _vkCmdWriteTimestamp_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits2, VkQueryPool, uint, void> _vkCmdWriteTimestamp2_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkPipelineStageFlagBits2, VkQueryPool, uint, void> _vkCmdWriteTimestamp2KHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPipeline, uint, VkResult> _vkCompileDeferredNV_fnptr;
        public delegate* unmanaged<VkDevice, VkConvertCooperativeVectorMatrixInfoNV*, VkResult> _vkConvertCooperativeVectorMatrixNV_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureInfoKHR*, VkResult> _vkCopyAccelerationStructureKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureToMemoryInfoKHR*, VkResult> _vkCopyAccelerationStructureToMemoryKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkCopyImageToImageInfo*, VkResult> _vkCopyImageToImage_fnptr;
        public delegate* unmanaged<VkDevice, VkCopyImageToImageInfo*, VkResult> _vkCopyImageToImageEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkCopyImageToMemoryInfo*, VkResult> _vkCopyImageToMemory_fnptr;
        public delegate* unmanaged<VkDevice, VkCopyImageToMemoryInfo*, VkResult> _vkCopyImageToMemoryEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToAccelerationStructureInfoKHR*, VkResult> _vkCopyMemoryToAccelerationStructureKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkCopyMemoryToImageInfo*, VkResult> _vkCopyMemoryToImage_fnptr;
        public delegate* unmanaged<VkDevice, VkCopyMemoryToImageInfo*, VkResult> _vkCopyMemoryToImageEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToMicromapInfoEXT*, VkResult> _vkCopyMemoryToMicromapEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMicromapInfoEXT*, VkResult> _vkCopyMicromapEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkCopyMicromapToMemoryInfoEXT*, VkResult> _vkCopyMicromapToMemoryEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkAccelerationStructureCreateInfoKHR*, VkAllocationCallbacks*, VkAccelerationStructureKHR*, VkResult> _vkCreateAccelerationStructureKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkAccelerationStructureCreateInfoNV*, VkAllocationCallbacks*, VkAccelerationStructureNV*, VkResult> _vkCreateAccelerationStructureNV_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferCreateInfo*, VkAllocationCallbacks*, VkBuffer*, VkResult> _vkCreateBuffer_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferCollectionCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkBufferCollectionFUCHSIA*, VkResult> _vkCreateBufferCollectionFUCHSIA_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferViewCreateInfo*, VkAllocationCallbacks*, VkBufferView*, VkResult> _vkCreateBufferView_fnptr;
        public delegate* unmanaged<VkDevice, VkCommandPoolCreateInfo*, VkAllocationCallbacks*, VkCommandPool*, VkResult> _vkCreateCommandPool_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateComputePipelines_fnptr;
        public delegate* unmanaged<VkDevice, VkCudaFunctionCreateInfoNV*, VkAllocationCallbacks*, VkCudaFunctionNV*, VkResult> _vkCreateCudaFunctionNV_fnptr;
        public delegate* unmanaged<VkDevice, VkCudaModuleCreateInfoNV*, VkAllocationCallbacks*, VkCudaModuleNV*, VkResult> _vkCreateCudaModuleNV_fnptr;
        public delegate* unmanaged<VkDevice, VkCuFunctionCreateInfoNVX*, VkAllocationCallbacks*, VkCuFunctionNVX*, VkResult> _vkCreateCuFunctionNVX_fnptr;
        public delegate* unmanaged<VkDevice, VkCuModuleCreateInfoNVX*, VkAllocationCallbacks*, VkCuModuleNVX*, VkResult> _vkCreateCuModuleNVX_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkDataGraphPipelineCreateInfoARM*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateDataGraphPipelinesARM_fnptr;
        public delegate* unmanaged<VkDevice, VkDataGraphPipelineSessionCreateInfoARM*, VkAllocationCallbacks*, VkDataGraphPipelineSessionARM*, VkResult> _vkCreateDataGraphPipelineSessionARM_fnptr;
        public delegate* unmanaged<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult> _vkCreateDeferredOperationKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorPoolCreateInfo*, VkAllocationCallbacks*, VkDescriptorPool*, VkResult> _vkCreateDescriptorPool_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkAllocationCallbacks*, VkDescriptorSetLayout*, VkResult> _vkCreateDescriptorSetLayout_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult> _vkCreateDescriptorUpdateTemplate_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult> _vkCreateDescriptorUpdateTemplateKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkEventCreateInfo*, VkAllocationCallbacks*, VkEvent*, VkResult> _vkCreateEvent_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkExecutionGraphPipelineCreateInfoAMDX*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateExecutionGraphPipelinesAMDX_fnptr;
        public delegate* unmanaged<VkDevice, VkExternalComputeQueueCreateInfoNV*, VkAllocationCallbacks*, VkExternalComputeQueueNV*, VkResult> _vkCreateExternalComputeQueueNV_fnptr;
        public delegate* unmanaged<VkDevice, VkFenceCreateInfo*, VkAllocationCallbacks*, VkFence*, VkResult> _vkCreateFence_fnptr;
        public delegate* unmanaged<VkDevice, VkFramebufferCreateInfo*, VkAllocationCallbacks*, VkFramebuffer*, VkResult> _vkCreateFramebuffer_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkGraphicsPipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateGraphicsPipelines_fnptr;
        public delegate* unmanaged<VkDevice, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage*, VkResult> _vkCreateImage_fnptr;
        public delegate* unmanaged<VkDevice, VkImageViewCreateInfo*, VkAllocationCallbacks*, VkImageView*, VkResult> _vkCreateImageView_fnptr;
        public delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutCreateInfoEXT*, VkAllocationCallbacks*, VkIndirectCommandsLayoutEXT*, VkResult> _vkCreateIndirectCommandsLayoutEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutCreateInfoNV*, VkAllocationCallbacks*, VkIndirectCommandsLayoutNV*, VkResult> _vkCreateIndirectCommandsLayoutNV_fnptr;
        public delegate* unmanaged<VkDevice, VkIndirectExecutionSetCreateInfoEXT*, VkAllocationCallbacks*, VkIndirectExecutionSetEXT*, VkResult> _vkCreateIndirectExecutionSetEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkMicromapCreateInfoEXT*, VkAllocationCallbacks*, VkMicromapEXT*, VkResult> _vkCreateMicromapEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkOpticalFlowSessionCreateInfoNV*, VkAllocationCallbacks*, VkOpticalFlowSessionNV*, VkResult> _vkCreateOpticalFlowSessionNV_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineBinaryCreateInfoKHR*, VkAllocationCallbacks*, VkPipelineBinaryHandlesInfoKHR*, VkResult> _vkCreatePipelineBinariesKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineCacheCreateInfo*, VkAllocationCallbacks*, VkPipelineCache*, VkResult> _vkCreatePipelineCache_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineLayoutCreateInfo*, VkAllocationCallbacks*, VkPipelineLayout*, VkResult> _vkCreatePipelineLayout_fnptr;
        public delegate* unmanaged<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult> _vkCreatePrivateDataSlot_fnptr;
        public delegate* unmanaged<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult> _vkCreatePrivateDataSlotEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkQueryPoolCreateInfo*, VkAllocationCallbacks*, VkQueryPool*, VkResult> _vkCreateQueryPool_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateRayTracingPipelinesKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, VkAllocationCallbacks*, VkPipeline*, VkResult> _vkCreateRayTracingPipelinesNV_fnptr;
        public delegate* unmanaged<VkDevice, VkRenderPassCreateInfo*, VkAllocationCallbacks*, VkRenderPass*, VkResult> _vkCreateRenderPass_fnptr;
        public delegate* unmanaged<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult> _vkCreateRenderPass2_fnptr;
        public delegate* unmanaged<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult> _vkCreateRenderPass2KHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSamplerCreateInfo*, VkAllocationCallbacks*, VkSampler*, VkResult> _vkCreateSampler_fnptr;
        public delegate* unmanaged<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult> _vkCreateSamplerYcbcrConversion_fnptr;
        public delegate* unmanaged<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult> _vkCreateSamplerYcbcrConversionKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphoreCreateInfo*, VkAllocationCallbacks*, VkSemaphore*, VkResult> _vkCreateSemaphore_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphoreSciSyncPoolCreateInfoNV*, VkAllocationCallbacks*, VkSemaphoreSciSyncPoolNV*, VkResult> _vkCreateSemaphoreSciSyncPoolNV_fnptr;
        public delegate* unmanaged<VkDevice, VkShaderModuleCreateInfo*, VkAllocationCallbacks*, VkShaderModule*, VkResult> _vkCreateShaderModule_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkShaderCreateInfoEXT*, VkAllocationCallbacks*, VkShaderEXT*, VkResult> _vkCreateShadersEXT_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult> _vkCreateSharedSwapchainsKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainCreateInfoKHR*, VkAllocationCallbacks*, VkSwapchainKHR*, VkResult> _vkCreateSwapchainKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkTensorCreateInfoARM*, VkAllocationCallbacks*, VkTensorARM*, VkResult> _vkCreateTensorARM_fnptr;
        public delegate* unmanaged<VkDevice, VkTensorViewCreateInfoARM*, VkAllocationCallbacks*, VkTensorViewARM*, VkResult> _vkCreateTensorViewARM_fnptr;
        public delegate* unmanaged<VkDevice, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, VkValidationCacheEXT*, VkResult> _vkCreateValidationCacheEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkVideoSessionCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionKHR*, VkResult> _vkCreateVideoSessionKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkVideoSessionParametersCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionParametersKHR*, VkResult> _vkCreateVideoSessionParametersKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult> _vkDebugMarkerSetObjectNameEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult> _vkDebugMarkerSetObjectTagEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkResult> _vkDeferredOperationJoinKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void> _vkDestroyAccelerationStructureKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void> _vkDestroyAccelerationStructureNV_fnptr;
        public delegate* unmanaged<VkDevice, VkBuffer, VkAllocationCallbacks*, void> _vkDestroyBuffer_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkAllocationCallbacks*, void> _vkDestroyBufferCollectionFUCHSIA_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferView, VkAllocationCallbacks*, void> _vkDestroyBufferView_fnptr;
        public delegate* unmanaged<VkDevice, VkCommandPool, VkAllocationCallbacks*, void> _vkDestroyCommandPool_fnptr;
        public delegate* unmanaged<VkDevice, VkCudaFunctionNV, VkAllocationCallbacks*, void> _vkDestroyCudaFunctionNV_fnptr;
        public delegate* unmanaged<VkDevice, VkCudaModuleNV, VkAllocationCallbacks*, void> _vkDestroyCudaModuleNV_fnptr;
        public delegate* unmanaged<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void> _vkDestroyCuFunctionNVX_fnptr;
        public delegate* unmanaged<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void> _vkDestroyCuModuleNVX_fnptr;
        public delegate* unmanaged<VkDevice, VkDataGraphPipelineSessionARM, VkAllocationCallbacks*, void> _vkDestroyDataGraphPipelineSessionARM_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void> _vkDestroyDeferredOperationKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void> _vkDestroyDescriptorPool_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void> _vkDestroyDescriptorSetLayout_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> _vkDestroyDescriptorUpdateTemplate_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> _vkDestroyDescriptorUpdateTemplateKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkAllocationCallbacks*, void> _vkDestroyDevice_fnptr;
        public delegate* unmanaged<VkDevice, VkEvent, VkAllocationCallbacks*, void> _vkDestroyEvent_fnptr;
        public delegate* unmanaged<VkDevice, VkExternalComputeQueueNV, VkAllocationCallbacks*, void> _vkDestroyExternalComputeQueueNV_fnptr;
        public delegate* unmanaged<VkDevice, VkFence, VkAllocationCallbacks*, void> _vkDestroyFence_fnptr;
        public delegate* unmanaged<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void> _vkDestroyFramebuffer_fnptr;
        public delegate* unmanaged<VkDevice, VkImage, VkAllocationCallbacks*, void> _vkDestroyImage_fnptr;
        public delegate* unmanaged<VkDevice, VkImageView, VkAllocationCallbacks*, void> _vkDestroyImageView_fnptr;
        public delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutEXT, VkAllocationCallbacks*, void> _vkDestroyIndirectCommandsLayoutEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void> _vkDestroyIndirectCommandsLayoutNV_fnptr;
        public delegate* unmanaged<VkDevice, VkIndirectExecutionSetEXT, VkAllocationCallbacks*, void> _vkDestroyIndirectExecutionSetEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkMicromapEXT, VkAllocationCallbacks*, void> _vkDestroyMicromapEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkOpticalFlowSessionNV, VkAllocationCallbacks*, void> _vkDestroyOpticalFlowSessionNV_fnptr;
        public delegate* unmanaged<VkDevice, VkPipeline, VkAllocationCallbacks*, void> _vkDestroyPipeline_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineBinaryKHR, VkAllocationCallbacks*, void> _vkDestroyPipelineBinaryKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void> _vkDestroyPipelineCache_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void> _vkDestroyPipelineLayout_fnptr;
        public delegate* unmanaged<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> _vkDestroyPrivateDataSlot_fnptr;
        public delegate* unmanaged<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> _vkDestroyPrivateDataSlotEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkQueryPool, VkAllocationCallbacks*, void> _vkDestroyQueryPool_fnptr;
        public delegate* unmanaged<VkDevice, VkRenderPass, VkAllocationCallbacks*, void> _vkDestroyRenderPass_fnptr;
        public delegate* unmanaged<VkDevice, VkSampler, VkAllocationCallbacks*, void> _vkDestroySampler_fnptr;
        public delegate* unmanaged<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> _vkDestroySamplerYcbcrConversion_fnptr;
        public delegate* unmanaged<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> _vkDestroySamplerYcbcrConversionKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphore, VkAllocationCallbacks*, void> _vkDestroySemaphore_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphoreSciSyncPoolNV, VkAllocationCallbacks*, void> _vkDestroySemaphoreSciSyncPoolNV_fnptr;
        public delegate* unmanaged<VkDevice, VkShaderEXT, VkAllocationCallbacks*, void> _vkDestroyShaderEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkShaderModule, VkAllocationCallbacks*, void> _vkDestroyShaderModule_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void> _vkDestroySwapchainKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkTensorARM, VkAllocationCallbacks*, void> _vkDestroyTensorARM_fnptr;
        public delegate* unmanaged<VkDevice, VkTensorViewARM, VkAllocationCallbacks*, void> _vkDestroyTensorViewARM_fnptr;
        public delegate* unmanaged<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void> _vkDestroyValidationCacheEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void> _vkDestroyVideoSessionKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void> _vkDestroyVideoSessionParametersKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkResult> _vkDeviceWaitIdle_fnptr;
        public delegate* unmanaged<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult> _vkDisplayPowerControlEXT_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkResult> _vkEndCommandBuffer_fnptr;
        public delegate* unmanaged<VkDevice, VkExportMetalObjectsInfoEXT*, void> _vkExportMetalObjectsEXT_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult> _vkFlushMappedMemoryRanges_fnptr;
        public delegate* unmanaged<VkDevice, VkCommandPool, uint, VkCommandBuffer*, void> _vkFreeCommandBuffers_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorPool, uint, VkDescriptorSet*, VkResult> _vkFreeDescriptorSets_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void> _vkFreeMemory_fnptr;
        public delegate* unmanaged<VkDevice, VkAccelerationStructureBuildTypeKHR, VkAccelerationStructureBuildGeometryInfoKHR*, uint*, VkAccelerationStructureBuildSizesInfoKHR*, void> _vkGetAccelerationStructureBuildSizesKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, ulong> _vkGetAccelerationStructureDeviceAddressKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult> _vkGetAccelerationStructureHandleNV_fnptr;
        public delegate* unmanaged<VkDevice, VkAccelerationStructureMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> _vkGetAccelerationStructureMemoryRequirementsNV_fnptr;
        public delegate* unmanaged<VkDevice, VkAccelerationStructureCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT_fnptr;
        public delegate* unmanaged<VkDevice, IntPtr, VkAndroidHardwareBufferPropertiesANDROID*, VkResult> _vkGetAndroidHardwareBufferPropertiesANDROID_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkBufferCollectionPropertiesFUCHSIA*, VkResult> _vkGetBufferCollectionPropertiesFUCHSIA_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong> _vkGetBufferDeviceAddress_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong> _vkGetBufferDeviceAddressEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong> _vkGetBufferDeviceAddressKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkBuffer, VkMemoryRequirements*, void> _vkGetBufferMemoryRequirements_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> _vkGetBufferMemoryRequirements2_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> _vkGetBufferMemoryRequirements2KHR_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong> _vkGetBufferOpaqueCaptureAddress_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferDeviceAddressInfo*, ulong> _vkGetBufferOpaqueCaptureAddressKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetBufferOpaqueCaptureDescriptorDataEXT_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkCalibratedTimestampInfoKHR*, ulong*, ulong*, VkResult> _vkGetCalibratedTimestampsEXT_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkCalibratedTimestampInfoKHR*, ulong*, ulong*, VkResult> _vkGetCalibratedTimestampsKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkClusterAccelerationStructureInputInfoNV*, VkAccelerationStructureBuildSizesInfoKHR*, void> _vkGetClusterAccelerationStructureBuildSizesNV_fnptr;
        public delegate* unmanaged<VkDevice, VkCommandPool, VkCommandBuffer, VkCommandPoolMemoryConsumption*, void> _vkGetCommandPoolMemoryConsumption_fnptr;
        public delegate* unmanaged<VkDevice, VkCudaModuleNV, nuint*, void*, VkResult> _vkGetCudaModuleCacheNV_fnptr;
        public delegate* unmanaged<VkDevice, VkDataGraphPipelineInfoARM*, uint*, VkDataGraphPipelinePropertyARM*, VkResult> _vkGetDataGraphPipelineAvailablePropertiesARM_fnptr;
        public delegate* unmanaged<VkDevice, VkDataGraphPipelineInfoARM*, uint, VkDataGraphPipelinePropertyQueryResultARM*, VkResult> _vkGetDataGraphPipelinePropertiesARM_fnptr;
        public delegate* unmanaged<VkDevice, VkDataGraphPipelineSessionBindPointRequirementsInfoARM*, uint*, VkDataGraphPipelineSessionBindPointRequirementARM*, VkResult> _vkGetDataGraphPipelineSessionBindPointRequirementsARM_fnptr;
        public delegate* unmanaged<VkDevice, VkDataGraphPipelineSessionMemoryRequirementsInfoARM*, VkMemoryRequirements2*, void> _vkGetDataGraphPipelineSessionMemoryRequirementsARM_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, uint> _vkGetDeferredOperationMaxConcurrencyKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDeferredOperationKHR, VkResult> _vkGetDeferredOperationResultKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorGetInfoEXT*, nuint, void*, void> _vkGetDescriptorEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorSet, void**, void> _vkGetDescriptorSetHostMappingVALVE_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorSetLayout, uint, ulong*, void> _vkGetDescriptorSetLayoutBindingOffsetEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorSetBindingReferenceVALVE*, VkDescriptorSetLayoutHostMappingInfoVALVE*, void> _vkGetDescriptorSetLayoutHostMappingInfoVALVE_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorSetLayout, ulong*, void> _vkGetDescriptorSetLayoutSizeEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void> _vkGetDescriptorSetLayoutSupport_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void> _vkGetDescriptorSetLayoutSupportKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkAccelerationStructureVersionInfoKHR*, VkAccelerationStructureCompatibilityKHR*, void> _vkGetDeviceAccelerationStructureCompatibilityKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> _vkGetDeviceBufferMemoryRequirements_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> _vkGetDeviceBufferMemoryRequirementsKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult> _vkGetDeviceFaultInfoEXT_fnptr;
        public delegate* unmanaged<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlagBits*, void> _vkGetDeviceGroupPeerMemoryFeatures_fnptr;
        public delegate* unmanaged<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlagBits*, void> _vkGetDeviceGroupPeerMemoryFeaturesKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult> _vkGetDeviceGroupPresentCapabilitiesKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkDeviceGroupPresentModeFlagBitsKHR*, VkResult> _vkGetDeviceGroupSurfacePresentModes2EXT_fnptr;
        public delegate* unmanaged<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagBitsKHR*, VkResult> _vkGetDeviceGroupSurfacePresentModesKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> _vkGetDeviceImageMemoryRequirements_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> _vkGetDeviceImageMemoryRequirementsKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void> _vkGetDeviceImageSparseMemoryRequirements_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void> _vkGetDeviceImageSparseMemoryRequirementsKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceImageSubresourceInfo*, VkSubresourceLayout2*, void> _vkGetDeviceImageSubresourceLayout_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceImageSubresourceInfo*, VkSubresourceLayout2*, void> _vkGetDeviceImageSubresourceLayoutKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceMemory, ulong*, void> _vkGetDeviceMemoryCommitment_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong> _vkGetDeviceMemoryOpaqueCaptureAddress_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong> _vkGetDeviceMemoryOpaqueCaptureAddressKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkMicromapVersionInfoEXT*, VkAccelerationStructureCompatibilityKHR*, void> _vkGetDeviceMicromapCompatibilityEXT_fnptr;
        public delegate* unmanaged<VkDevice, byte*, IntPtr> _vkGetDeviceProcAddr_fnptr;
        public delegate* unmanaged<VkDevice, uint, uint, VkQueue*, void> _vkGetDeviceQueue_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceQueueInfo2*, VkQueue*, void> _vkGetDeviceQueue2_fnptr;
        public delegate* unmanaged<VkDevice, VkRenderPass, VkExtent2D*, VkResult> _vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceTensorMemoryRequirementsARM*, VkMemoryRequirements2*, void> _vkGetDeviceTensorMemoryRequirementsARM_fnptr;
        public delegate* unmanaged<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult> _vkGetDynamicRenderingTilePropertiesQCOM_fnptr;
        public delegate* unmanaged<VkDevice, VkVideoEncodeSessionParametersGetInfoKHR*, VkVideoEncodeSessionParametersFeedbackInfoKHR*, nuint*, void*, VkResult> _vkGetEncodedVideoSessionParametersKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkEvent, VkResult> _vkGetEventStatus_fnptr;
        public delegate* unmanaged<VkDevice, VkPipeline, VkPipelineShaderStageNodeCreateInfoAMDX*, uint*, VkResult> _vkGetExecutionGraphPipelineNodeIndexAMDX_fnptr;
        public delegate* unmanaged<VkDevice, VkPipeline, VkExecutionGraphPipelineScratchSizeAMDX*, VkResult> _vkGetExecutionGraphPipelineScratchSizeAMDX_fnptr;
        public delegate* unmanaged<VkExternalComputeQueueNV, VkExternalComputeQueueDataParamsNV*, void*, void> _vkGetExternalComputeQueueDataNV_fnptr;
        public delegate* unmanaged<VkDevice, VkFaultQueryBehavior, int*, uint*, VkFaultData*, VkResult> _vkGetFaultData_fnptr;
        public delegate* unmanaged<VkDevice, VkFenceGetFdInfoKHR*, int*, VkResult> _vkGetFenceFdKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkFenceGetSciSyncInfoNV*, void*, VkResult> _vkGetFenceSciSyncFenceNV_fnptr;
        public delegate* unmanaged<VkDevice, VkFenceGetSciSyncInfoNV*, void*, VkResult> _vkGetFenceSciSyncObjNV_fnptr;
        public delegate* unmanaged<VkDevice, VkFence, VkResult> _vkGetFenceStatus_fnptr;
        public delegate* unmanaged<VkDevice, VkFenceGetWin32HandleInfoKHR*, IntPtr*, VkResult> _vkGetFenceWin32HandleKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult> _vkGetFramebufferTilePropertiesQCOM_fnptr;
        public delegate* unmanaged<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoEXT*, VkMemoryRequirements2*, void> _vkGetGeneratedCommandsMemoryRequirementsEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> _vkGetGeneratedCommandsMemoryRequirementsNV_fnptr;
        public delegate* unmanaged<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult> _vkGetImageDrmFormatModifierPropertiesEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkImage, VkMemoryRequirements*, void> _vkGetImageMemoryRequirements_fnptr;
        public delegate* unmanaged<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> _vkGetImageMemoryRequirements2_fnptr;
        public delegate* unmanaged<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> _vkGetImageMemoryRequirements2KHR_fnptr;
        public delegate* unmanaged<VkDevice, VkImageCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetImageOpaqueCaptureDescriptorDataEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkImage, uint*, VkSparseImageMemoryRequirements*, void> _vkGetImageSparseMemoryRequirements_fnptr;
        public delegate* unmanaged<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void> _vkGetImageSparseMemoryRequirements2_fnptr;
        public delegate* unmanaged<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void> _vkGetImageSparseMemoryRequirements2KHR_fnptr;
        public delegate* unmanaged<VkDevice, VkImage, VkImageSubresource*, VkSubresourceLayout*, void> _vkGetImageSubresourceLayout_fnptr;
        public delegate* unmanaged<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void> _vkGetImageSubresourceLayout2_fnptr;
        public delegate* unmanaged<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void> _vkGetImageSubresourceLayout2EXT_fnptr;
        public delegate* unmanaged<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void> _vkGetImageSubresourceLayout2KHR_fnptr;
        public delegate* unmanaged<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult> _vkGetImageViewAddressNVX_fnptr;
        public delegate* unmanaged<VkDevice, VkImageViewHandleInfoNVX*, ulong> _vkGetImageViewHandle64NVX_fnptr;
        public delegate* unmanaged<VkDevice, VkImageViewHandleInfoNVX*, uint> _vkGetImageViewHandleNVX_fnptr;
        public delegate* unmanaged<VkDevice, VkImageViewCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetImageViewOpaqueCaptureDescriptorDataEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkGetLatencyMarkerInfoNV*, void> _vkGetLatencyTimingsNV_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, IntPtr*, VkResult> _vkGetMemoryAndroidHardwareBufferANDROID_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryGetFdInfoKHR*, int*, VkResult> _vkGetMemoryFdKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, int, VkMemoryFdPropertiesKHR*, VkResult> _vkGetMemoryFdPropertiesKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, void*, VkMemoryHostPointerPropertiesEXT*, VkResult> _vkGetMemoryHostPointerPropertiesEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryGetMetalHandleInfoEXT*, void**, VkResult> _vkGetMemoryMetalHandleEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, void*, VkMemoryMetalHandlePropertiesEXT*, VkResult> _vkGetMemoryMetalHandlePropertiesEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryGetNativeBufferInfoOHOS*, IntPtr*, VkResult> _vkGetMemoryNativeBufferOHOS_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryGetRemoteAddressInfoNV*, void**, VkResult> _vkGetMemoryRemoteAddressNV_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryGetSciBufInfoNV*, IntPtr*, VkResult> _vkGetMemorySciBufNV_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryGetWin32HandleInfoKHR*, IntPtr*, VkResult> _vkGetMemoryWin32HandleKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceMemory, VkExternalMemoryHandleTypeFlagBitsNV, IntPtr*, VkResult> _vkGetMemoryWin32HandleNV_fnptr;
        public delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, IntPtr, VkMemoryWin32HandlePropertiesKHR*, VkResult> _vkGetMemoryWin32HandlePropertiesKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, int*, VkResult> _vkGetMemoryZirconHandleFUCHSIA_fnptr;
        public delegate* unmanaged<VkDevice, VkExternalMemoryHandleTypeFlagBits, int, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult> _vkGetMemoryZirconHandlePropertiesFUCHSIA_fnptr;
        public delegate* unmanaged<VkDevice, VkAccelerationStructureBuildTypeKHR, VkMicromapBuildInfoEXT*, VkMicromapBuildSizesInfoEXT*, void> _vkGetMicromapBuildSizesEXT_fnptr;
        public delegate* unmanaged<VkDevice, IntPtr, VkNativeBufferPropertiesOHOS*, VkResult> _vkGetNativeBufferPropertiesOHOS_fnptr;
        public delegate* unmanaged<VkDevice, VkPartitionedAccelerationStructureInstancesInputNV*, VkAccelerationStructureBuildSizesInfoKHR*, void> _vkGetPartitionedAccelerationStructuresBuildSizesNV_fnptr;
        public delegate* unmanaged<VkDevice, VkPastPresentationTimingInfoEXT*, VkPastPresentationTimingPropertiesEXT*, VkResult> _vkGetPastPresentationTimingEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, uint*, VkPastPresentationTimingGOOGLE*, VkResult> _vkGetPastPresentationTimingGOOGLE_fnptr;
        public delegate* unmanaged<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult> _vkGetPerformanceParameterINTEL_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineBinaryDataInfoKHR*, VkPipelineBinaryKeyKHR*, nuint*, void*, VkResult> _vkGetPipelineBinaryDataKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineCache, nuint*, void*, VkResult> _vkGetPipelineCacheData_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableInternalRepresentationKHR*, VkResult> _vkGetPipelineExecutableInternalRepresentationsKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineInfoKHR*, uint*, VkPipelineExecutablePropertiesKHR*, VkResult> _vkGetPipelineExecutablePropertiesKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableStatisticKHR*, VkResult> _vkGetPipelineExecutableStatisticsKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineIndirectDeviceAddressInfoNV*, ulong> _vkGetPipelineIndirectDeviceAddressNV_fnptr;
        public delegate* unmanaged<VkDevice, VkComputePipelineCreateInfo*, VkMemoryRequirements2*, void> _vkGetPipelineIndirectMemoryRequirementsNV_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineCreateInfoKHR*, VkPipelineBinaryKeyKHR*, VkResult> _vkGetPipelineKeyKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult> _vkGetPipelinePropertiesEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void> _vkGetPrivateData_fnptr;
        public delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void> _vkGetPrivateDataEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, nuint, void*, ulong, VkQueryResultFlagBits, VkResult> _vkGetQueryPoolResults_fnptr;
        public delegate* unmanaged<VkQueue, uint*, VkCheckpointData2NV*, void> _vkGetQueueCheckpointData2NV_fnptr;
        public delegate* unmanaged<VkQueue, uint*, VkCheckpointDataNV*, void> _vkGetQueueCheckpointDataNV_fnptr;
        public delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> _vkGetRayTracingCaptureReplayShaderGroupHandlesKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> _vkGetRayTracingShaderGroupHandlesKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> _vkGetRayTracingShaderGroupHandlesNV_fnptr;
        public delegate* unmanaged<VkDevice, VkPipeline, uint, VkShaderGroupShaderKHR, ulong> _vkGetRayTracingShaderGroupStackSizeKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult> _vkGetRefreshCycleDurationGOOGLE_fnptr;
        public delegate* unmanaged<VkDevice, VkRenderPass, VkExtent2D*, void> _vkGetRenderAreaGranularity_fnptr;
        public delegate* unmanaged<VkDevice, VkRenderingAreaInfo*, VkExtent2D*, void> _vkGetRenderingAreaGranularity_fnptr;
        public delegate* unmanaged<VkDevice, VkRenderingAreaInfo*, VkExtent2D*, void> _vkGetRenderingAreaGranularityKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSamplerCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetSamplerOpaqueCaptureDescriptorDataEXT_fnptr;
        public delegate* unmanaged<VkDevice, IntPtr*, VkScreenBufferPropertiesQNX*, VkResult> _vkGetScreenBufferPropertiesQNX_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphore, ulong*, VkResult> _vkGetSemaphoreCounterValue_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphore, ulong*, VkResult> _vkGetSemaphoreCounterValueKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphoreGetFdInfoKHR*, int*, VkResult> _vkGetSemaphoreFdKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphoreGetSciSyncInfoNV*, void*, VkResult> _vkGetSemaphoreSciSyncObjNV_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, IntPtr*, VkResult> _vkGetSemaphoreWin32HandleKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, int*, VkResult> _vkGetSemaphoreZirconHandleFUCHSIA_fnptr;
        public delegate* unmanaged<VkDevice, VkShaderEXT, nuint*, void*, VkResult> _vkGetShaderBinaryDataEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkPipeline, VkShaderStageFlagBits, VkShaderInfoTypeAMD, nuint*, void*, VkResult> _vkGetShaderInfoAMD_fnptr;
        public delegate* unmanaged<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void> _vkGetShaderModuleCreateInfoIdentifierEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void> _vkGetShaderModuleIdentifierEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagBitsEXT, ulong*, VkResult> _vkGetSwapchainCounterEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkFormat, VkImageUsageFlagBits, VkSwapchainImageUsageFlagBitsANDROID, ulong*, ulong*, VkResult> _vkGetSwapchainGrallocUsage2ANDROID_fnptr;
        public delegate* unmanaged<VkDevice, VkFormat, VkImageUsageFlagBits, int*, VkResult> _vkGetSwapchainGrallocUsageANDROID_fnptr;
        public delegate* unmanaged<VkDevice, VkFormat, VkImageUsageFlagBits, ulong*, VkResult> _vkGetSwapchainGrallocUsageOHOS_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, uint*, VkImage*, VkResult> _vkGetSwapchainImagesKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult> _vkGetSwapchainStatusKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSwapchainTimeDomainPropertiesEXT*, ulong*, VkResult> _vkGetSwapchainTimeDomainPropertiesEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSwapchainTimingPropertiesEXT*, ulong*, VkResult> _vkGetSwapchainTimingPropertiesEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkTensorMemoryRequirementsInfoARM*, VkMemoryRequirements2*, void> _vkGetTensorMemoryRequirementsARM_fnptr;
        public delegate* unmanaged<VkDevice, VkTensorCaptureDescriptorDataInfoARM*, void*, VkResult> _vkGetTensorOpaqueCaptureDescriptorDataARM_fnptr;
        public delegate* unmanaged<VkDevice, VkTensorViewCaptureDescriptorDataInfoARM*, void*, VkResult> _vkGetTensorViewOpaqueCaptureDescriptorDataARM_fnptr;
        public delegate* unmanaged<VkDevice, VkValidationCacheEXT, nuint*, void*, VkResult> _vkGetValidationCacheDataEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkVideoSessionKHR, uint*, VkVideoSessionMemoryRequirementsKHR*, VkResult> _vkGetVideoSessionMemoryRequirementsKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkImportFenceFdInfoKHR*, VkResult> _vkImportFenceFdKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkImportFenceSciSyncInfoNV*, VkResult> _vkImportFenceSciSyncFenceNV_fnptr;
        public delegate* unmanaged<VkDevice, VkImportFenceSciSyncInfoNV*, VkResult> _vkImportFenceSciSyncObjNV_fnptr;
        public delegate* unmanaged<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult> _vkImportFenceWin32HandleKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult> _vkImportSemaphoreFdKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkImportSemaphoreSciSyncInfoNV*, VkResult> _vkImportSemaphoreSciSyncObjNV_fnptr;
        public delegate* unmanaged<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult> _vkImportSemaphoreWin32HandleKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult> _vkImportSemaphoreZirconHandleFUCHSIA_fnptr;
        public delegate* unmanaged<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult> _vkInitializePerformanceApiINTEL_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkMappedMemoryRange*, VkResult> _vkInvalidateMappedMemoryRanges_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkLatencySleepInfoNV*, VkResult> _vkLatencySleepNV_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceMemory, ulong, ulong, VkMemoryMapFlagBits, void**, VkResult> _vkMapMemory_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryMapInfo*, void**, VkResult> _vkMapMemory2_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryMapInfo*, void**, VkResult> _vkMapMemory2KHR_fnptr;
        public delegate* unmanaged<VkDevice, VkPipelineCache, uint, VkPipelineCache*, VkResult> _vkMergePipelineCaches_fnptr;
        public delegate* unmanaged<VkDevice, VkValidationCacheEXT, uint, VkValidationCacheEXT*, VkResult> _vkMergeValidationCachesEXT_fnptr;
        public delegate* unmanaged<VkQueue, VkDebugUtilsLabelEXT*, void> _vkQueueBeginDebugUtilsLabelEXT_fnptr;
        public delegate* unmanaged<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult> _vkQueueBindSparse_fnptr;
        public delegate* unmanaged<VkQueue, void> _vkQueueEndDebugUtilsLabelEXT_fnptr;
        public delegate* unmanaged<VkQueue, VkDebugUtilsLabelEXT*, void> _vkQueueInsertDebugUtilsLabelEXT_fnptr;
        public delegate* unmanaged<VkQueue, VkOutOfBandQueueTypeInfoNV*, void> _vkQueueNotifyOutOfBandNV_fnptr;
        public delegate* unmanaged<VkQueue, VkPresentInfoKHR*, VkResult> _vkQueuePresentKHR_fnptr;
        public delegate* unmanaged<VkQueue, VkPerformanceConfigurationINTEL, VkResult> _vkQueueSetPerformanceConfigurationINTEL_fnptr;
        public delegate* unmanaged<VkQueue, uint, VkSemaphore*, VkImage, int*, VkResult> _vkQueueSignalReleaseImageANDROID_fnptr;
        public delegate* unmanaged<VkQueue, uint, VkSemaphore*, VkImage, int*, VkResult> _vkQueueSignalReleaseImageOHOS_fnptr;
        public delegate* unmanaged<VkQueue, uint, VkSubmitInfo*, VkFence, VkResult> _vkQueueSubmit_fnptr;
        public delegate* unmanaged<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult> _vkQueueSubmit2_fnptr;
        public delegate* unmanaged<VkQueue, uint, VkSubmitInfo2*, VkFence, VkResult> _vkQueueSubmit2KHR_fnptr;
        public delegate* unmanaged<VkQueue, VkResult> _vkQueueWaitIdle_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> _vkRegisterDeviceEventEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkDisplayKHR, VkDisplayEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> _vkRegisterDisplayEventEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkReleaseCapturedPipelineDataInfoKHR*, VkAllocationCallbacks*, VkResult> _vkReleaseCapturedPipelineDataKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkResult> _vkReleaseFullScreenExclusiveModeEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkPerformanceConfigurationINTEL, VkResult> _vkReleasePerformanceConfigurationINTEL_fnptr;
        public delegate* unmanaged<VkDevice, void> _vkReleaseProfilingLockKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkReleaseSwapchainImagesInfoKHR*, VkResult> _vkReleaseSwapchainImagesEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkReleaseSwapchainImagesInfoKHR*, VkResult> _vkReleaseSwapchainImagesKHR_fnptr;
        public delegate* unmanaged<VkCommandBuffer, VkCommandBufferResetFlagBits, VkResult> _vkResetCommandBuffer_fnptr;
        public delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolResetFlagBits, VkResult> _vkResetCommandPool_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorPool, VkDescriptorPoolResetFlags, VkResult> _vkResetDescriptorPool_fnptr;
        public delegate* unmanaged<VkDevice, VkEvent, VkResult> _vkResetEvent_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkFence*, VkResult> _vkResetFences_fnptr;
        public delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, void> _vkResetQueryPool_fnptr;
        public delegate* unmanaged<VkDevice, VkQueryPool, uint, uint, void> _vkResetQueryPoolEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkBufferConstraintsInfoFUCHSIA*, VkResult> _vkSetBufferCollectionBufferConstraintsFUCHSIA_fnptr;
        public delegate* unmanaged<VkDevice, VkBufferCollectionFUCHSIA, VkImageConstraintsInfoFUCHSIA*, VkResult> _vkSetBufferCollectionImageConstraintsFUCHSIA_fnptr;
        public delegate* unmanaged<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult> _vkSetDebugUtilsObjectNameEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult> _vkSetDebugUtilsObjectTagEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceMemory, float, void> _vkSetDeviceMemoryPriorityEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkEvent, VkResult> _vkSetEvent_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void> _vkSetHdrMetadataEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkSetLatencyMarkerInfoNV*, void> _vkSetLatencyMarkerNV_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkLatencySleepModeInfoNV*, VkResult> _vkSetLatencySleepModeNV_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, int, void> _vkSetLocalDimmingAMD_fnptr;
        public delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult> _vkSetPrivateData_fnptr;
        public delegate* unmanaged<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult> _vkSetPrivateDataEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, uint, VkResult> _vkSetSwapchainPresentTimingQueueSizeEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphoreSignalInfo*, VkResult> _vkSignalSemaphore_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphoreSignalInfo*, VkResult> _vkSignalSemaphoreKHR_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkHostImageLayoutTransitionInfo*, VkResult> _vkTransitionImageLayout_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkHostImageLayoutTransitionInfo*, VkResult> _vkTransitionImageLayoutEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> _vkTrimCommandPool_fnptr;
        public delegate* unmanaged<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> _vkTrimCommandPoolKHR_fnptr;
        public delegate* unmanaged<VkDevice, void> _vkUninitializePerformanceApiINTEL_fnptr;
        public delegate* unmanaged<VkDevice, VkDeviceMemory, void> _vkUnmapMemory_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryUnmapInfo*, VkResult> _vkUnmapMemory2_fnptr;
        public delegate* unmanaged<VkDevice, VkMemoryUnmapInfo*, VkResult> _vkUnmapMemory2KHR_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkWriteDescriptorSet*, uint, VkCopyDescriptorSet*, void> _vkUpdateDescriptorSets_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> _vkUpdateDescriptorSetWithTemplate_fnptr;
        public delegate* unmanaged<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> _vkUpdateDescriptorSetWithTemplateKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkIndirectExecutionSetEXT, uint, VkWriteIndirectExecutionSetPipelineEXT*, void> _vkUpdateIndirectExecutionSetPipelineEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkIndirectExecutionSetEXT, uint, VkWriteIndirectExecutionSetShaderEXT*, void> _vkUpdateIndirectExecutionSetShaderEXT_fnptr;
        public delegate* unmanaged<VkDevice, VkVideoSessionParametersKHR, VkVideoSessionParametersUpdateInfoKHR*, VkResult> _vkUpdateVideoSessionParametersKHR_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkFence*, int, ulong, VkResult> _vkWaitForFences_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, VkPresentWait2InfoKHR*, VkResult> _vkWaitForPresent2KHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSwapchainKHR, ulong, ulong, VkResult> _vkWaitForPresentKHR_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult> _vkWaitSemaphores_fnptr;
        public delegate* unmanaged<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult> _vkWaitSemaphoresKHR_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, nuint, void*, nuint, VkResult> _vkWriteAccelerationStructuresPropertiesKHR_fnptr;
        public delegate* unmanaged<VkDevice, uint, VkMicromapEXT*, VkQueryType, nuint, void*, nuint, VkResult> _vkWriteMicromapsPropertiesEXT_fnptr;
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
