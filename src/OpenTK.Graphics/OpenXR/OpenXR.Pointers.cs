// This file is auto generated, do not edit.
using OpenTK.Mathematics;
using OpenTK.Graphics.Vulkan;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenXR
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CA2211 // Non-constant fields should not be visible
    public static unsafe partial class XrPointers
    {
        public static delegate* unmanaged<XrEnvironmentDepthProviderMETA, XrEnvironmentDepthImageAcquireInfoMETA*, XrEnvironmentDepthImageMETA*, XrResult> _xrAcquireEnvironmentDepthImageMETA_fnptr = &xrAcquireEnvironmentDepthImageMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrAcquireEnvironmentDepthImageMETA_Lazy(XrEnvironmentDepthProviderMETA environmentDepthProvider, XrEnvironmentDepthImageAcquireInfoMETA* acquireInfo, XrEnvironmentDepthImageMETA* environmentDepthImage)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrAcquireEnvironmentDepthImageMETA", out IntPtr temp);
            _xrAcquireEnvironmentDepthImageMETA_fnptr = (delegate* unmanaged<XrEnvironmentDepthProviderMETA, XrEnvironmentDepthImageAcquireInfoMETA*, XrEnvironmentDepthImageMETA*, XrResult>)temp;
            return _xrAcquireEnvironmentDepthImageMETA_fnptr(environmentDepthProvider, acquireInfo, environmentDepthImage);
        }
        public static delegate* unmanaged<XrSwapchain, XrSwapchainImageAcquireInfo*, uint*, XrResult> _xrAcquireSwapchainImage_fnptr = &xrAcquireSwapchainImage_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrAcquireSwapchainImage_Lazy(XrSwapchain swapchain, XrSwapchainImageAcquireInfo* acquireInfo, uint* index)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrAcquireSwapchainImage", out IntPtr temp);
            _xrAcquireSwapchainImage_fnptr = (delegate* unmanaged<XrSwapchain, XrSwapchainImageAcquireInfo*, uint*, XrResult>)temp;
            return _xrAcquireSwapchainImage_fnptr(swapchain, acquireInfo, index);
        }
        public static delegate* unmanaged<XrWorldMeshDetectorML, XrWorldMeshBufferSizeML*, XrWorldMeshBufferML*, XrResult> _xrAllocateWorldMeshBufferML_fnptr = &xrAllocateWorldMeshBufferML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrAllocateWorldMeshBufferML_Lazy(XrWorldMeshDetectorML detector, XrWorldMeshBufferSizeML* size, XrWorldMeshBufferML* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrAllocateWorldMeshBufferML", out IntPtr temp);
            _xrAllocateWorldMeshBufferML_fnptr = (delegate* unmanaged<XrWorldMeshDetectorML, XrWorldMeshBufferSizeML*, XrWorldMeshBufferML*, XrResult>)temp;
            return _xrAllocateWorldMeshBufferML_fnptr(detector, size, buffer);
        }
        public static delegate* unmanaged<XrHandTrackerEXT, XrForceFeedbackCurlApplyLocationsMNDX*, XrResult> _xrApplyForceFeedbackCurlMNDX_fnptr = &xrApplyForceFeedbackCurlMNDX_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrApplyForceFeedbackCurlMNDX_Lazy(XrHandTrackerEXT handTracker, XrForceFeedbackCurlApplyLocationsMNDX* locations)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrApplyForceFeedbackCurlMNDX", out IntPtr temp);
            _xrApplyForceFeedbackCurlMNDX_fnptr = (delegate* unmanaged<XrHandTrackerEXT, XrForceFeedbackCurlApplyLocationsMNDX*, XrResult>)temp;
            return _xrApplyForceFeedbackCurlMNDX_fnptr(handTracker, locations);
        }
        public static delegate* unmanaged<XrSession, XrFoveationApplyInfoHTC*, XrResult> _xrApplyFoveationHTC_fnptr = &xrApplyFoveationHTC_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrApplyFoveationHTC_Lazy(XrSession session, XrFoveationApplyInfoHTC* applyInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrApplyFoveationHTC", out IntPtr temp);
            _xrApplyFoveationHTC_fnptr = (delegate* unmanaged<XrSession, XrFoveationApplyInfoHTC*, XrResult>)temp;
            return _xrApplyFoveationHTC_fnptr(session, applyInfo);
        }
        public static delegate* unmanaged<XrSession, XrHapticActionInfo*, XrHapticBaseHeader*, XrResult> _xrApplyHapticFeedback_fnptr = &xrApplyHapticFeedback_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrApplyHapticFeedback_Lazy(XrSession session, XrHapticActionInfo* hapticActionInfo, XrHapticBaseHeader* hapticFeedback)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrApplyHapticFeedback", out IntPtr temp);
            _xrApplyHapticFeedback_fnptr = (delegate* unmanaged<XrSession, XrHapticActionInfo*, XrHapticBaseHeader*, XrResult>)temp;
            return _xrApplyHapticFeedback_fnptr(session, hapticActionInfo, hapticFeedback);
        }
        public static delegate* unmanaged<XrSession, XrSessionActionSetsAttachInfo*, XrResult> _xrAttachSessionActionSets_fnptr = &xrAttachSessionActionSets_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrAttachSessionActionSets_Lazy(XrSession session, XrSessionActionSetsAttachInfo* attachInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrAttachSessionActionSets", out IntPtr temp);
            _xrAttachSessionActionSets_fnptr = (delegate* unmanaged<XrSession, XrSessionActionSetsAttachInfo*, XrResult>)temp;
            return _xrAttachSessionActionSets_fnptr(session, attachInfo);
        }
        public static delegate* unmanaged<XrSession, XrFrameBeginInfo*, XrResult> _xrBeginFrame_fnptr = &xrBeginFrame_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrBeginFrame_Lazy(XrSession session, XrFrameBeginInfo* frameBeginInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrBeginFrame", out IntPtr temp);
            _xrBeginFrame_fnptr = (delegate* unmanaged<XrSession, XrFrameBeginInfo*, XrResult>)temp;
            return _xrBeginFrame_fnptr(session, frameBeginInfo);
        }
        public static delegate* unmanaged<XrPlaneDetectorEXT, XrPlaneDetectorBeginInfoEXT*, XrResult> _xrBeginPlaneDetectionEXT_fnptr = &xrBeginPlaneDetectionEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrBeginPlaneDetectionEXT_Lazy(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorBeginInfoEXT* beginInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrBeginPlaneDetectionEXT", out IntPtr temp);
            _xrBeginPlaneDetectionEXT_fnptr = (delegate* unmanaged<XrPlaneDetectorEXT, XrPlaneDetectorBeginInfoEXT*, XrResult>)temp;
            return _xrBeginPlaneDetectionEXT_fnptr(planeDetector, beginInfo);
        }
        public static delegate* unmanaged<XrSession, XrSessionBeginInfo*, XrResult> _xrBeginSession_fnptr = &xrBeginSession_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrBeginSession_Lazy(XrSession session, XrSessionBeginInfo* beginInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrBeginSession", out IntPtr temp);
            _xrBeginSession_fnptr = (delegate* unmanaged<XrSession, XrSessionBeginInfo*, XrResult>)temp;
            return _xrBeginSession_fnptr(session, beginInfo);
        }
        public static delegate* unmanaged<XrInstance, XrFutureCancelInfoEXT*, XrResult> _xrCancelFutureEXT_fnptr = &xrCancelFutureEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCancelFutureEXT_Lazy(XrInstance instance, XrFutureCancelInfoEXT* cancelInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCancelFutureEXT", out IntPtr temp);
            _xrCancelFutureEXT_fnptr = (delegate* unmanaged<XrInstance, XrFutureCancelInfoEXT*, XrResult>)temp;
            return _xrCancelFutureEXT_fnptr(instance, cancelInfo);
        }
        public static delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardTextContextChangeInfoMETA*, XrResult> _xrChangeVirtualKeyboardTextContextMETA_fnptr = &xrChangeVirtualKeyboardTextContextMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrChangeVirtualKeyboardTextContextMETA_Lazy(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardTextContextChangeInfoMETA* changeInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrChangeVirtualKeyboardTextContextMETA", out IntPtr temp);
            _xrChangeVirtualKeyboardTextContextMETA_fnptr = (delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardTextContextChangeInfoMETA*, XrResult>)temp;
            return _xrChangeVirtualKeyboardTextContextMETA_fnptr(keyboard, changeInfo);
        }
        public static delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrResult> _xrClearSpatialAnchorStoreMSFT_fnptr = &xrClearSpatialAnchorStoreMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrClearSpatialAnchorStoreMSFT_Lazy(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrClearSpatialAnchorStoreMSFT", out IntPtr temp);
            _xrClearSpatialAnchorStoreMSFT_fnptr = (delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrResult>)temp;
            return _xrClearSpatialAnchorStoreMSFT_fnptr(spatialAnchorStore);
        }
        public static delegate* unmanaged<XrSceneObserverMSFT, XrNewSceneComputeInfoMSFT*, XrResult> _xrComputeNewSceneMSFT_fnptr = &xrComputeNewSceneMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrComputeNewSceneMSFT_Lazy(XrSceneObserverMSFT sceneObserver, XrNewSceneComputeInfoMSFT* computeInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrComputeNewSceneMSFT", out IntPtr temp);
            _xrComputeNewSceneMSFT_fnptr = (delegate* unmanaged<XrSceneObserverMSFT, XrNewSceneComputeInfoMSFT*, XrResult>)temp;
            return _xrComputeNewSceneMSFT_fnptr(sceneObserver, computeInfo);
        }
        public static delegate* unmanaged<XrInstance, void*, long*, XrResult> _xrConvertTimespecTimeToTimeKHR_fnptr = &xrConvertTimespecTimeToTimeKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrConvertTimespecTimeToTimeKHR_Lazy(XrInstance instance, void* timespecTime, long* time)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrConvertTimespecTimeToTimeKHR", out IntPtr temp);
            _xrConvertTimespecTimeToTimeKHR_fnptr = (delegate* unmanaged<XrInstance, void*, long*, XrResult>)temp;
            return _xrConvertTimespecTimeToTimeKHR_fnptr(instance, timespecTime, time);
        }
        public static delegate* unmanaged<XrInstance, long, void*, XrResult> _xrConvertTimeToTimespecTimeKHR_fnptr = &xrConvertTimeToTimespecTimeKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrConvertTimeToTimespecTimeKHR_Lazy(XrInstance instance, long time, void* timespecTime)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrConvertTimeToTimespecTimeKHR", out IntPtr temp);
            _xrConvertTimeToTimespecTimeKHR_fnptr = (delegate* unmanaged<XrInstance, long, void*, XrResult>)temp;
            return _xrConvertTimeToTimespecTimeKHR_fnptr(instance, time, timespecTime);
        }
        public static delegate* unmanaged<XrInstance, long, long*, XrResult> _xrConvertTimeToWin32PerformanceCounterKHR_fnptr = &xrConvertTimeToWin32PerformanceCounterKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrConvertTimeToWin32PerformanceCounterKHR_Lazy(XrInstance instance, long time, long* performanceCounter)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrConvertTimeToWin32PerformanceCounterKHR", out IntPtr temp);
            _xrConvertTimeToWin32PerformanceCounterKHR_fnptr = (delegate* unmanaged<XrInstance, long, long*, XrResult>)temp;
            return _xrConvertTimeToWin32PerformanceCounterKHR_fnptr(instance, time, performanceCounter);
        }
        public static delegate* unmanaged<XrInstance, long*, long*, XrResult> _xrConvertWin32PerformanceCounterToTimeKHR_fnptr = &xrConvertWin32PerformanceCounterToTimeKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrConvertWin32PerformanceCounterToTimeKHR_Lazy(XrInstance instance, long* performanceCounter, long* time)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrConvertWin32PerformanceCounterToTimeKHR", out IntPtr temp);
            _xrConvertWin32PerformanceCounterToTimeKHR_fnptr = (delegate* unmanaged<XrInstance, long*, long*, XrResult>)temp;
            return _xrConvertWin32PerformanceCounterToTimeKHR_fnptr(instance, performanceCounter, time);
        }
        public static delegate* unmanaged<XrActionSet, XrActionCreateInfo*, XrAction*, XrResult> _xrCreateAction_fnptr = &xrCreateAction_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateAction_Lazy(XrActionSet actionSet, XrActionCreateInfo* createInfo, XrAction* action)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateAction", out IntPtr temp);
            _xrCreateAction_fnptr = (delegate* unmanaged<XrActionSet, XrActionCreateInfo*, XrAction*, XrResult>)temp;
            return _xrCreateAction_fnptr(actionSet, createInfo, action);
        }
        public static delegate* unmanaged<XrInstance, XrActionSetCreateInfo*, XrActionSet*, XrResult> _xrCreateActionSet_fnptr = &xrCreateActionSet_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateActionSet_Lazy(XrInstance instance, XrActionSetCreateInfo* createInfo, XrActionSet* actionSet)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateActionSet", out IntPtr temp);
            _xrCreateActionSet_fnptr = (delegate* unmanaged<XrInstance, XrActionSetCreateInfo*, XrActionSet*, XrResult>)temp;
            return _xrCreateActionSet_fnptr(instance, createInfo, actionSet);
        }
        public static delegate* unmanaged<XrSession, XrActionSpaceCreateInfo*, XrSpace*, XrResult> _xrCreateActionSpace_fnptr = &xrCreateActionSpace_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateActionSpace_Lazy(XrSession session, XrActionSpaceCreateInfo* createInfo, XrSpace* space)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateActionSpace", out IntPtr temp);
            _xrCreateActionSpace_fnptr = (delegate* unmanaged<XrSession, XrActionSpaceCreateInfo*, XrSpace*, XrResult>)temp;
            return _xrCreateActionSpace_fnptr(session, createInfo, space);
        }
        public static delegate* unmanaged<XrInstanceCreateInfo*, XrApiLayerCreateInfo*, XrInstance*, XrResult> _xrCreateApiLayerInstance_fnptr = &xrCreateApiLayerInstance_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateApiLayerInstance_Lazy(XrInstanceCreateInfo* info, XrApiLayerCreateInfo* layerInfo, XrInstance* instance)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateApiLayerInstance", out IntPtr temp);
            _xrCreateApiLayerInstance_fnptr = (delegate* unmanaged<XrInstanceCreateInfo*, XrApiLayerCreateInfo*, XrInstance*, XrResult>)temp;
            return _xrCreateApiLayerInstance_fnptr(info, layerInfo, instance);
        }
        public static delegate* unmanaged<XrSession, XrBodyTrackerCreateInfoBD*, XrBodyTrackerBD*, XrResult> _xrCreateBodyTrackerBD_fnptr = &xrCreateBodyTrackerBD_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateBodyTrackerBD_Lazy(XrSession session, XrBodyTrackerCreateInfoBD* createInfo, XrBodyTrackerBD* bodyTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateBodyTrackerBD", out IntPtr temp);
            _xrCreateBodyTrackerBD_fnptr = (delegate* unmanaged<XrSession, XrBodyTrackerCreateInfoBD*, XrBodyTrackerBD*, XrResult>)temp;
            return _xrCreateBodyTrackerBD_fnptr(session, createInfo, bodyTracker);
        }
        public static delegate* unmanaged<XrSession, XrBodyTrackerCreateInfoFB*, XrBodyTrackerFB*, XrResult> _xrCreateBodyTrackerFB_fnptr = &xrCreateBodyTrackerFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateBodyTrackerFB_Lazy(XrSession session, XrBodyTrackerCreateInfoFB* createInfo, XrBodyTrackerFB* bodyTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateBodyTrackerFB", out IntPtr temp);
            _xrCreateBodyTrackerFB_fnptr = (delegate* unmanaged<XrSession, XrBodyTrackerCreateInfoFB*, XrBodyTrackerFB*, XrResult>)temp;
            return _xrCreateBodyTrackerFB_fnptr(session, createInfo, bodyTracker);
        }
        public static delegate* unmanaged<XrSession, XrBodyTrackerCreateInfoHTC*, XrBodyTrackerHTC*, XrResult> _xrCreateBodyTrackerHTC_fnptr = &xrCreateBodyTrackerHTC_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateBodyTrackerHTC_Lazy(XrSession session, XrBodyTrackerCreateInfoHTC* createInfo, XrBodyTrackerHTC* bodyTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateBodyTrackerHTC", out IntPtr temp);
            _xrCreateBodyTrackerHTC_fnptr = (delegate* unmanaged<XrSession, XrBodyTrackerCreateInfoHTC*, XrBodyTrackerHTC*, XrResult>)temp;
            return _xrCreateBodyTrackerHTC_fnptr(session, createInfo, bodyTracker);
        }
        public static delegate* unmanaged<XrInstance, XrDebugUtilsMessengerCreateInfoEXT*, XrDebugUtilsMessengerEXT*, XrResult> _xrCreateDebugUtilsMessengerEXT_fnptr = &xrCreateDebugUtilsMessengerEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateDebugUtilsMessengerEXT_Lazy(XrInstance instance, XrDebugUtilsMessengerCreateInfoEXT* createInfo, XrDebugUtilsMessengerEXT* messenger)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateDebugUtilsMessengerEXT", out IntPtr temp);
            _xrCreateDebugUtilsMessengerEXT_fnptr = (delegate* unmanaged<XrInstance, XrDebugUtilsMessengerCreateInfoEXT*, XrDebugUtilsMessengerEXT*, XrResult>)temp;
            return _xrCreateDebugUtilsMessengerEXT_fnptr(instance, createInfo, messenger);
        }
        public static delegate* unmanaged<XrSession, XrEnvironmentDepthProviderCreateInfoMETA*, XrEnvironmentDepthProviderMETA*, XrResult> _xrCreateEnvironmentDepthProviderMETA_fnptr = &xrCreateEnvironmentDepthProviderMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateEnvironmentDepthProviderMETA_Lazy(XrSession session, XrEnvironmentDepthProviderCreateInfoMETA* createInfo, XrEnvironmentDepthProviderMETA* environmentDepthProvider)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateEnvironmentDepthProviderMETA", out IntPtr temp);
            _xrCreateEnvironmentDepthProviderMETA_fnptr = (delegate* unmanaged<XrSession, XrEnvironmentDepthProviderCreateInfoMETA*, XrEnvironmentDepthProviderMETA*, XrResult>)temp;
            return _xrCreateEnvironmentDepthProviderMETA_fnptr(session, createInfo, environmentDepthProvider);
        }
        public static delegate* unmanaged<XrEnvironmentDepthProviderMETA, XrEnvironmentDepthSwapchainCreateInfoMETA*, XrEnvironmentDepthSwapchainMETA*, XrResult> _xrCreateEnvironmentDepthSwapchainMETA_fnptr = &xrCreateEnvironmentDepthSwapchainMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateEnvironmentDepthSwapchainMETA_Lazy(XrEnvironmentDepthProviderMETA environmentDepthProvider, XrEnvironmentDepthSwapchainCreateInfoMETA* createInfo, XrEnvironmentDepthSwapchainMETA* swapchain)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateEnvironmentDepthSwapchainMETA", out IntPtr temp);
            _xrCreateEnvironmentDepthSwapchainMETA_fnptr = (delegate* unmanaged<XrEnvironmentDepthProviderMETA, XrEnvironmentDepthSwapchainCreateInfoMETA*, XrEnvironmentDepthSwapchainMETA*, XrResult>)temp;
            return _xrCreateEnvironmentDepthSwapchainMETA_fnptr(environmentDepthProvider, createInfo, swapchain);
        }
        public static delegate* unmanaged<XrSession, XrUuid*, XrExportedLocalizationMapML*, XrResult> _xrCreateExportedLocalizationMapML_fnptr = &xrCreateExportedLocalizationMapML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateExportedLocalizationMapML_Lazy(XrSession session, XrUuid* mapUuid, XrExportedLocalizationMapML* map)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateExportedLocalizationMapML", out IntPtr temp);
            _xrCreateExportedLocalizationMapML_fnptr = (delegate* unmanaged<XrSession, XrUuid*, XrExportedLocalizationMapML*, XrResult>)temp;
            return _xrCreateExportedLocalizationMapML_fnptr(session, mapUuid, map);
        }
        public static delegate* unmanaged<XrSession, XrEyeTrackerCreateInfoFB*, XrEyeTrackerFB*, XrResult> _xrCreateEyeTrackerFB_fnptr = &xrCreateEyeTrackerFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateEyeTrackerFB_Lazy(XrSession session, XrEyeTrackerCreateInfoFB* createInfo, XrEyeTrackerFB* eyeTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateEyeTrackerFB", out IntPtr temp);
            _xrCreateEyeTrackerFB_fnptr = (delegate* unmanaged<XrSession, XrEyeTrackerCreateInfoFB*, XrEyeTrackerFB*, XrResult>)temp;
            return _xrCreateEyeTrackerFB_fnptr(session, createInfo, eyeTracker);
        }
        public static delegate* unmanaged<XrSession, XrFaceTrackerCreateInfo2FB*, XrFaceTracker2FB*, XrResult> _xrCreateFaceTracker2FB_fnptr = &xrCreateFaceTracker2FB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateFaceTracker2FB_Lazy(XrSession session, XrFaceTrackerCreateInfo2FB* createInfo, XrFaceTracker2FB* faceTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateFaceTracker2FB", out IntPtr temp);
            _xrCreateFaceTracker2FB_fnptr = (delegate* unmanaged<XrSession, XrFaceTrackerCreateInfo2FB*, XrFaceTracker2FB*, XrResult>)temp;
            return _xrCreateFaceTracker2FB_fnptr(session, createInfo, faceTracker);
        }
        public static delegate* unmanaged<XrSession, XrFaceTrackerCreateInfoFB*, XrFaceTrackerFB*, XrResult> _xrCreateFaceTrackerFB_fnptr = &xrCreateFaceTrackerFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateFaceTrackerFB_Lazy(XrSession session, XrFaceTrackerCreateInfoFB* createInfo, XrFaceTrackerFB* faceTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateFaceTrackerFB", out IntPtr temp);
            _xrCreateFaceTrackerFB_fnptr = (delegate* unmanaged<XrSession, XrFaceTrackerCreateInfoFB*, XrFaceTrackerFB*, XrResult>)temp;
            return _xrCreateFaceTrackerFB_fnptr(session, createInfo, faceTracker);
        }
        public static delegate* unmanaged<XrSession, XrFacialExpressionClientCreateInfoML*, XrFacialExpressionClientML*, XrResult> _xrCreateFacialExpressionClientML_fnptr = &xrCreateFacialExpressionClientML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateFacialExpressionClientML_Lazy(XrSession session, XrFacialExpressionClientCreateInfoML* createInfo, XrFacialExpressionClientML* facialExpressionClient)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateFacialExpressionClientML", out IntPtr temp);
            _xrCreateFacialExpressionClientML_fnptr = (delegate* unmanaged<XrSession, XrFacialExpressionClientCreateInfoML*, XrFacialExpressionClientML*, XrResult>)temp;
            return _xrCreateFacialExpressionClientML_fnptr(session, createInfo, facialExpressionClient);
        }
        public static delegate* unmanaged<XrSession, XrFacialTrackerCreateInfoHTC*, XrFacialTrackerHTC*, XrResult> _xrCreateFacialTrackerHTC_fnptr = &xrCreateFacialTrackerHTC_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateFacialTrackerHTC_Lazy(XrSession session, XrFacialTrackerCreateInfoHTC* createInfo, XrFacialTrackerHTC* facialTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateFacialTrackerHTC", out IntPtr temp);
            _xrCreateFacialTrackerHTC_fnptr = (delegate* unmanaged<XrSession, XrFacialTrackerCreateInfoHTC*, XrFacialTrackerHTC*, XrResult>)temp;
            return _xrCreateFacialTrackerHTC_fnptr(session, createInfo, facialTracker);
        }
        public static delegate* unmanaged<XrSession, XrFoveationProfileCreateInfoFB*, XrFoveationProfileFB*, XrResult> _xrCreateFoveationProfileFB_fnptr = &xrCreateFoveationProfileFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateFoveationProfileFB_Lazy(XrSession session, XrFoveationProfileCreateInfoFB* createInfo, XrFoveationProfileFB* profile)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateFoveationProfileFB", out IntPtr temp);
            _xrCreateFoveationProfileFB_fnptr = (delegate* unmanaged<XrSession, XrFoveationProfileCreateInfoFB*, XrFoveationProfileFB*, XrResult>)temp;
            return _xrCreateFoveationProfileFB_fnptr(session, createInfo, profile);
        }
        public static delegate* unmanaged<XrSession, XrGeometryInstanceCreateInfoFB*, XrGeometryInstanceFB*, XrResult> _xrCreateGeometryInstanceFB_fnptr = &xrCreateGeometryInstanceFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateGeometryInstanceFB_Lazy(XrSession session, XrGeometryInstanceCreateInfoFB* createInfo, XrGeometryInstanceFB* outGeometryInstance)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateGeometryInstanceFB", out IntPtr temp);
            _xrCreateGeometryInstanceFB_fnptr = (delegate* unmanaged<XrSession, XrGeometryInstanceCreateInfoFB*, XrGeometryInstanceFB*, XrResult>)temp;
            return _xrCreateGeometryInstanceFB_fnptr(session, createInfo, outGeometryInstance);
        }
        public static delegate* unmanaged<XrHandTrackerEXT, XrHandMeshSpaceCreateInfoMSFT*, XrSpace*, XrResult> _xrCreateHandMeshSpaceMSFT_fnptr = &xrCreateHandMeshSpaceMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateHandMeshSpaceMSFT_Lazy(XrHandTrackerEXT handTracker, XrHandMeshSpaceCreateInfoMSFT* createInfo, XrSpace* space)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateHandMeshSpaceMSFT", out IntPtr temp);
            _xrCreateHandMeshSpaceMSFT_fnptr = (delegate* unmanaged<XrHandTrackerEXT, XrHandMeshSpaceCreateInfoMSFT*, XrSpace*, XrResult>)temp;
            return _xrCreateHandMeshSpaceMSFT_fnptr(handTracker, createInfo, space);
        }
        public static delegate* unmanaged<XrSession, XrHandTrackerCreateInfoEXT*, XrHandTrackerEXT*, XrResult> _xrCreateHandTrackerEXT_fnptr = &xrCreateHandTrackerEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateHandTrackerEXT_Lazy(XrSession session, XrHandTrackerCreateInfoEXT* createInfo, XrHandTrackerEXT* handTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateHandTrackerEXT", out IntPtr temp);
            _xrCreateHandTrackerEXT_fnptr = (delegate* unmanaged<XrSession, XrHandTrackerCreateInfoEXT*, XrHandTrackerEXT*, XrResult>)temp;
            return _xrCreateHandTrackerEXT_fnptr(session, createInfo, handTracker);
        }
        public static delegate* unmanaged<XrInstanceCreateInfo*, XrInstance*, XrResult> _xrCreateInstance_fnptr = &xrCreateInstance_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateInstance_Lazy(XrInstanceCreateInfo* createInfo, XrInstance* instance)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateInstance", out IntPtr temp);
            _xrCreateInstance_fnptr = (delegate* unmanaged<XrInstanceCreateInfo*, XrInstance*, XrResult>)temp;
            return _xrCreateInstance_fnptr(createInfo, instance);
        }
        public static delegate* unmanaged<XrSession, XrKeyboardSpaceCreateInfoFB*, XrSpace*, XrResult> _xrCreateKeyboardSpaceFB_fnptr = &xrCreateKeyboardSpaceFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateKeyboardSpaceFB_Lazy(XrSession session, XrKeyboardSpaceCreateInfoFB* createInfo, XrSpace* keyboardSpace)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateKeyboardSpaceFB", out IntPtr temp);
            _xrCreateKeyboardSpaceFB_fnptr = (delegate* unmanaged<XrSession, XrKeyboardSpaceCreateInfoFB*, XrSpace*, XrResult>)temp;
            return _xrCreateKeyboardSpaceFB_fnptr(session, createInfo, keyboardSpace);
        }
        public static delegate* unmanaged<XrSession, XrMarkerDetectorCreateInfoML*, XrMarkerDetectorML*, XrResult> _xrCreateMarkerDetectorML_fnptr = &xrCreateMarkerDetectorML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateMarkerDetectorML_Lazy(XrSession session, XrMarkerDetectorCreateInfoML* createInfo, XrMarkerDetectorML* markerDetector)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateMarkerDetectorML", out IntPtr temp);
            _xrCreateMarkerDetectorML_fnptr = (delegate* unmanaged<XrSession, XrMarkerDetectorCreateInfoML*, XrMarkerDetectorML*, XrResult>)temp;
            return _xrCreateMarkerDetectorML_fnptr(session, createInfo, markerDetector);
        }
        public static delegate* unmanaged<XrSession, XrMarkerSpaceCreateInfoML*, XrSpace*, XrResult> _xrCreateMarkerSpaceML_fnptr = &xrCreateMarkerSpaceML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateMarkerSpaceML_Lazy(XrSession session, XrMarkerSpaceCreateInfoML* createInfo, XrSpace* space)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateMarkerSpaceML", out IntPtr temp);
            _xrCreateMarkerSpaceML_fnptr = (delegate* unmanaged<XrSession, XrMarkerSpaceCreateInfoML*, XrSpace*, XrResult>)temp;
            return _xrCreateMarkerSpaceML_fnptr(session, createInfo, space);
        }
        public static delegate* unmanaged<XrSession, XrMarkerSpaceCreateInfoVARJO*, XrSpace*, XrResult> _xrCreateMarkerSpaceVARJO_fnptr = &xrCreateMarkerSpaceVARJO_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateMarkerSpaceVARJO_Lazy(XrSession session, XrMarkerSpaceCreateInfoVARJO* createInfo, XrSpace* space)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateMarkerSpaceVARJO", out IntPtr temp);
            _xrCreateMarkerSpaceVARJO_fnptr = (delegate* unmanaged<XrSession, XrMarkerSpaceCreateInfoVARJO*, XrSpace*, XrResult>)temp;
            return _xrCreateMarkerSpaceVARJO_fnptr(session, createInfo, space);
        }
        public static delegate* unmanaged<XrPassthroughFB, XrPassthroughColorLutCreateInfoMETA*, XrPassthroughColorLutMETA*, XrResult> _xrCreatePassthroughColorLutMETA_fnptr = &xrCreatePassthroughColorLutMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreatePassthroughColorLutMETA_Lazy(XrPassthroughFB passthrough, XrPassthroughColorLutCreateInfoMETA* createInfo, XrPassthroughColorLutMETA* colorLut)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreatePassthroughColorLutMETA", out IntPtr temp);
            _xrCreatePassthroughColorLutMETA_fnptr = (delegate* unmanaged<XrPassthroughFB, XrPassthroughColorLutCreateInfoMETA*, XrPassthroughColorLutMETA*, XrResult>)temp;
            return _xrCreatePassthroughColorLutMETA_fnptr(passthrough, createInfo, colorLut);
        }
        public static delegate* unmanaged<XrSession, XrPassthroughCreateInfoFB*, XrPassthroughFB*, XrResult> _xrCreatePassthroughFB_fnptr = &xrCreatePassthroughFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreatePassthroughFB_Lazy(XrSession session, XrPassthroughCreateInfoFB* createInfo, XrPassthroughFB* outPassthrough)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreatePassthroughFB", out IntPtr temp);
            _xrCreatePassthroughFB_fnptr = (delegate* unmanaged<XrSession, XrPassthroughCreateInfoFB*, XrPassthroughFB*, XrResult>)temp;
            return _xrCreatePassthroughFB_fnptr(session, createInfo, outPassthrough);
        }
        public static delegate* unmanaged<XrSession, XrPassthroughCreateInfoHTC*, XrPassthroughHTC*, XrResult> _xrCreatePassthroughHTC_fnptr = &xrCreatePassthroughHTC_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreatePassthroughHTC_Lazy(XrSession session, XrPassthroughCreateInfoHTC* createInfo, XrPassthroughHTC* passthrough)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreatePassthroughHTC", out IntPtr temp);
            _xrCreatePassthroughHTC_fnptr = (delegate* unmanaged<XrSession, XrPassthroughCreateInfoHTC*, XrPassthroughHTC*, XrResult>)temp;
            return _xrCreatePassthroughHTC_fnptr(session, createInfo, passthrough);
        }
        public static delegate* unmanaged<XrSession, XrPassthroughLayerCreateInfoFB*, XrPassthroughLayerFB*, XrResult> _xrCreatePassthroughLayerFB_fnptr = &xrCreatePassthroughLayerFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreatePassthroughLayerFB_Lazy(XrSession session, XrPassthroughLayerCreateInfoFB* createInfo, XrPassthroughLayerFB* outLayer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreatePassthroughLayerFB", out IntPtr temp);
            _xrCreatePassthroughLayerFB_fnptr = (delegate* unmanaged<XrSession, XrPassthroughLayerCreateInfoFB*, XrPassthroughLayerFB*, XrResult>)temp;
            return _xrCreatePassthroughLayerFB_fnptr(session, createInfo, outLayer);
        }
        public static delegate* unmanaged<XrSession, XrPlaneDetectorCreateInfoEXT*, XrPlaneDetectorEXT*, XrResult> _xrCreatePlaneDetectorEXT_fnptr = &xrCreatePlaneDetectorEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreatePlaneDetectorEXT_Lazy(XrSession session, XrPlaneDetectorCreateInfoEXT* createInfo, XrPlaneDetectorEXT* planeDetector)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreatePlaneDetectorEXT", out IntPtr temp);
            _xrCreatePlaneDetectorEXT_fnptr = (delegate* unmanaged<XrSession, XrPlaneDetectorCreateInfoEXT*, XrPlaneDetectorEXT*, XrResult>)temp;
            return _xrCreatePlaneDetectorEXT_fnptr(session, createInfo, planeDetector);
        }
        public static delegate* unmanaged<XrSession, XrReferenceSpaceCreateInfo*, XrSpace*, XrResult> _xrCreateReferenceSpace_fnptr = &xrCreateReferenceSpace_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateReferenceSpace_Lazy(XrSession session, XrReferenceSpaceCreateInfo* createInfo, XrSpace* space)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateReferenceSpace", out IntPtr temp);
            _xrCreateReferenceSpace_fnptr = (delegate* unmanaged<XrSession, XrReferenceSpaceCreateInfo*, XrSpace*, XrResult>)temp;
            return _xrCreateReferenceSpace_fnptr(session, createInfo, space);
        }
        public static delegate* unmanaged<XrSceneObserverMSFT, XrSceneCreateInfoMSFT*, XrSceneMSFT*, XrResult> _xrCreateSceneMSFT_fnptr = &xrCreateSceneMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSceneMSFT_Lazy(XrSceneObserverMSFT sceneObserver, XrSceneCreateInfoMSFT* createInfo, XrSceneMSFT* scene)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSceneMSFT", out IntPtr temp);
            _xrCreateSceneMSFT_fnptr = (delegate* unmanaged<XrSceneObserverMSFT, XrSceneCreateInfoMSFT*, XrSceneMSFT*, XrResult>)temp;
            return _xrCreateSceneMSFT_fnptr(sceneObserver, createInfo, scene);
        }
        public static delegate* unmanaged<XrSession, XrSceneObserverCreateInfoMSFT*, XrSceneObserverMSFT*, XrResult> _xrCreateSceneObserverMSFT_fnptr = &xrCreateSceneObserverMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSceneObserverMSFT_Lazy(XrSession session, XrSceneObserverCreateInfoMSFT* createInfo, XrSceneObserverMSFT* sceneObserver)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSceneObserverMSFT", out IntPtr temp);
            _xrCreateSceneObserverMSFT_fnptr = (delegate* unmanaged<XrSession, XrSceneObserverCreateInfoMSFT*, XrSceneObserverMSFT*, XrResult>)temp;
            return _xrCreateSceneObserverMSFT_fnptr(session, createInfo, sceneObserver);
        }
        public static delegate* unmanaged<XrInstance, XrSessionCreateInfo*, XrSession*, XrResult> _xrCreateSession_fnptr = &xrCreateSession_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSession_Lazy(XrInstance instance, XrSessionCreateInfo* createInfo, XrSession* session)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSession", out IntPtr temp);
            _xrCreateSession_fnptr = (delegate* unmanaged<XrInstance, XrSessionCreateInfo*, XrSession*, XrResult>)temp;
            return _xrCreateSession_fnptr(instance, createInfo, session);
        }
        public static delegate* unmanaged<XrSession, XrCoordinateSpaceCreateInfoML*, XrSpace*, XrResult> _xrCreateSpaceFromCoordinateFrameUIDML_fnptr = &xrCreateSpaceFromCoordinateFrameUIDML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpaceFromCoordinateFrameUIDML_Lazy(XrSession session, XrCoordinateSpaceCreateInfoML* createInfo, XrSpace* space)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpaceFromCoordinateFrameUIDML", out IntPtr temp);
            _xrCreateSpaceFromCoordinateFrameUIDML_fnptr = (delegate* unmanaged<XrSession, XrCoordinateSpaceCreateInfoML*, XrSpace*, XrResult>)temp;
            return _xrCreateSpaceFromCoordinateFrameUIDML_fnptr(session, createInfo, space);
        }
        public static delegate* unmanaged<XrSession, XrSpaceUserCreateInfoFB*, XrSpaceUserFB*, XrResult> _xrCreateSpaceUserFB_fnptr = &xrCreateSpaceUserFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpaceUserFB_Lazy(XrSession session, XrSpaceUserCreateInfoFB* info, XrSpaceUserFB* user)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpaceUserFB", out IntPtr temp);
            _xrCreateSpaceUserFB_fnptr = (delegate* unmanaged<XrSession, XrSpaceUserCreateInfoFB*, XrSpaceUserFB*, XrResult>)temp;
            return _xrCreateSpaceUserFB_fnptr(session, info, user);
        }
        public static delegate* unmanaged<XrSession, XrSpatialAnchorCreateInfoFB*, ulong*, XrResult> _xrCreateSpatialAnchorFB_fnptr = &xrCreateSpatialAnchorFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpatialAnchorFB_Lazy(XrSession session, XrSpatialAnchorCreateInfoFB* info, ulong* requestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpatialAnchorFB", out IntPtr temp);
            _xrCreateSpatialAnchorFB_fnptr = (delegate* unmanaged<XrSession, XrSpatialAnchorCreateInfoFB*, ulong*, XrResult>)temp;
            return _xrCreateSpatialAnchorFB_fnptr(session, info, requestId);
        }
        public static delegate* unmanaged<XrSession, IntPtr*, XrSpatialAnchorMSFT*, XrResult> _xrCreateSpatialAnchorFromPerceptionAnchorMSFT_fnptr = &xrCreateSpatialAnchorFromPerceptionAnchorMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpatialAnchorFromPerceptionAnchorMSFT_Lazy(XrSession session, IntPtr* perceptionAnchor, XrSpatialAnchorMSFT* anchor)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpatialAnchorFromPerceptionAnchorMSFT", out IntPtr temp);
            _xrCreateSpatialAnchorFromPerceptionAnchorMSFT_fnptr = (delegate* unmanaged<XrSession, IntPtr*, XrSpatialAnchorMSFT*, XrResult>)temp;
            return _xrCreateSpatialAnchorFromPerceptionAnchorMSFT_fnptr(session, perceptionAnchor, anchor);
        }
        public static delegate* unmanaged<XrSession, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT*, XrSpatialAnchorMSFT*, XrResult> _xrCreateSpatialAnchorFromPersistedNameMSFT_fnptr = &xrCreateSpatialAnchorFromPersistedNameMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpatialAnchorFromPersistedNameMSFT_Lazy(XrSession session, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT* spatialAnchorCreateInfo, XrSpatialAnchorMSFT* spatialAnchor)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpatialAnchorFromPersistedNameMSFT", out IntPtr temp);
            _xrCreateSpatialAnchorFromPersistedNameMSFT_fnptr = (delegate* unmanaged<XrSession, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT*, XrSpatialAnchorMSFT*, XrResult>)temp;
            return _xrCreateSpatialAnchorFromPersistedNameMSFT_fnptr(session, spatialAnchorCreateInfo, spatialAnchor);
        }
        public static delegate* unmanaged<XrSession, XrSpatialAnchorCreateInfoHTC*, XrSpace*, XrResult> _xrCreateSpatialAnchorHTC_fnptr = &xrCreateSpatialAnchorHTC_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpatialAnchorHTC_Lazy(XrSession session, XrSpatialAnchorCreateInfoHTC* createInfo, XrSpace* anchor)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpatialAnchorHTC", out IntPtr temp);
            _xrCreateSpatialAnchorHTC_fnptr = (delegate* unmanaged<XrSession, XrSpatialAnchorCreateInfoHTC*, XrSpace*, XrResult>)temp;
            return _xrCreateSpatialAnchorHTC_fnptr(session, createInfo, anchor);
        }
        public static delegate* unmanaged<XrSession, XrSpatialAnchorCreateInfoMSFT*, XrSpatialAnchorMSFT*, XrResult> _xrCreateSpatialAnchorMSFT_fnptr = &xrCreateSpatialAnchorMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpatialAnchorMSFT_Lazy(XrSession session, XrSpatialAnchorCreateInfoMSFT* createInfo, XrSpatialAnchorMSFT* anchor)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpatialAnchorMSFT", out IntPtr temp);
            _xrCreateSpatialAnchorMSFT_fnptr = (delegate* unmanaged<XrSession, XrSpatialAnchorCreateInfoMSFT*, XrSpatialAnchorMSFT*, XrResult>)temp;
            return _xrCreateSpatialAnchorMSFT_fnptr(session, createInfo, anchor);
        }
        public static delegate* unmanaged<XrSession, XrSpatialAnchorsCreateInfoBaseHeaderML*, ulong*, XrResult> _xrCreateSpatialAnchorsAsyncML_fnptr = &xrCreateSpatialAnchorsAsyncML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpatialAnchorsAsyncML_Lazy(XrSession session, XrSpatialAnchorsCreateInfoBaseHeaderML* createInfo, ulong* future)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpatialAnchorsAsyncML", out IntPtr temp);
            _xrCreateSpatialAnchorsAsyncML_fnptr = (delegate* unmanaged<XrSession, XrSpatialAnchorsCreateInfoBaseHeaderML*, ulong*, XrResult>)temp;
            return _xrCreateSpatialAnchorsAsyncML_fnptr(session, createInfo, future);
        }
        public static delegate* unmanaged<XrSession, ulong, XrCreateSpatialAnchorsCompletionML*, XrResult> _xrCreateSpatialAnchorsCompleteML_fnptr = &xrCreateSpatialAnchorsCompleteML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpatialAnchorsCompleteML_Lazy(XrSession session, ulong future, XrCreateSpatialAnchorsCompletionML* completion)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpatialAnchorsCompleteML", out IntPtr temp);
            _xrCreateSpatialAnchorsCompleteML_fnptr = (delegate* unmanaged<XrSession, ulong, XrCreateSpatialAnchorsCompletionML*, XrResult>)temp;
            return _xrCreateSpatialAnchorsCompleteML_fnptr(session, future, completion);
        }
        public static delegate* unmanaged<XrSession, XrSpatialAnchorSpaceCreateInfoMSFT*, XrSpace*, XrResult> _xrCreateSpatialAnchorSpaceMSFT_fnptr = &xrCreateSpatialAnchorSpaceMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpatialAnchorSpaceMSFT_Lazy(XrSession session, XrSpatialAnchorSpaceCreateInfoMSFT* createInfo, XrSpace* space)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpatialAnchorSpaceMSFT", out IntPtr temp);
            _xrCreateSpatialAnchorSpaceMSFT_fnptr = (delegate* unmanaged<XrSession, XrSpatialAnchorSpaceCreateInfoMSFT*, XrSpace*, XrResult>)temp;
            return _xrCreateSpatialAnchorSpaceMSFT_fnptr(session, createInfo, space);
        }
        public static delegate* unmanaged<XrSession, XrSpatialAnchorsCreateStorageInfoML*, XrSpatialAnchorsStorageML*, XrResult> _xrCreateSpatialAnchorsStorageML_fnptr = &xrCreateSpatialAnchorsStorageML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpatialAnchorsStorageML_Lazy(XrSession session, XrSpatialAnchorsCreateStorageInfoML* createInfo, XrSpatialAnchorsStorageML* storage)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpatialAnchorsStorageML", out IntPtr temp);
            _xrCreateSpatialAnchorsStorageML_fnptr = (delegate* unmanaged<XrSession, XrSpatialAnchorsCreateStorageInfoML*, XrSpatialAnchorsStorageML*, XrResult>)temp;
            return _xrCreateSpatialAnchorsStorageML_fnptr(session, createInfo, storage);
        }
        public static delegate* unmanaged<XrSession, XrSpatialAnchorStoreConnectionMSFT*, XrResult> _xrCreateSpatialAnchorStoreConnectionMSFT_fnptr = &xrCreateSpatialAnchorStoreConnectionMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpatialAnchorStoreConnectionMSFT_Lazy(XrSession session, XrSpatialAnchorStoreConnectionMSFT* spatialAnchorStore)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpatialAnchorStoreConnectionMSFT", out IntPtr temp);
            _xrCreateSpatialAnchorStoreConnectionMSFT_fnptr = (delegate* unmanaged<XrSession, XrSpatialAnchorStoreConnectionMSFT*, XrResult>)temp;
            return _xrCreateSpatialAnchorStoreConnectionMSFT_fnptr(session, spatialAnchorStore);
        }
        public static delegate* unmanaged<XrSession, XrSpatialGraphNodeSpaceCreateInfoMSFT*, XrSpace*, XrResult> _xrCreateSpatialGraphNodeSpaceMSFT_fnptr = &xrCreateSpatialGraphNodeSpaceMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSpatialGraphNodeSpaceMSFT_Lazy(XrSession session, XrSpatialGraphNodeSpaceCreateInfoMSFT* createInfo, XrSpace* space)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSpatialGraphNodeSpaceMSFT", out IntPtr temp);
            _xrCreateSpatialGraphNodeSpaceMSFT_fnptr = (delegate* unmanaged<XrSession, XrSpatialGraphNodeSpaceCreateInfoMSFT*, XrSpace*, XrResult>)temp;
            return _xrCreateSpatialGraphNodeSpaceMSFT_fnptr(session, createInfo, space);
        }
        public static delegate* unmanaged<XrSession, XrSwapchainCreateInfo*, XrSwapchain*, XrResult> _xrCreateSwapchain_fnptr = &xrCreateSwapchain_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSwapchain_Lazy(XrSession session, XrSwapchainCreateInfo* createInfo, XrSwapchain* swapchain)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSwapchain", out IntPtr temp);
            _xrCreateSwapchain_fnptr = (delegate* unmanaged<XrSession, XrSwapchainCreateInfo*, XrSwapchain*, XrResult>)temp;
            return _xrCreateSwapchain_fnptr(session, createInfo, swapchain);
        }
        public static delegate* unmanaged<XrSession, XrSwapchainCreateInfo*, XrSwapchain*, void*, XrResult> _xrCreateSwapchainAndroidSurfaceKHR_fnptr = &xrCreateSwapchainAndroidSurfaceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateSwapchainAndroidSurfaceKHR_Lazy(XrSession session, XrSwapchainCreateInfo* info, XrSwapchain* swapchain, void* surface)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateSwapchainAndroidSurfaceKHR", out IntPtr temp);
            _xrCreateSwapchainAndroidSurfaceKHR_fnptr = (delegate* unmanaged<XrSession, XrSwapchainCreateInfo*, XrSwapchain*, void*, XrResult>)temp;
            return _xrCreateSwapchainAndroidSurfaceKHR_fnptr(session, info, swapchain, surface);
        }
        public static delegate* unmanaged<XrSession, XrTriangleMeshCreateInfoFB*, XrTriangleMeshFB*, XrResult> _xrCreateTriangleMeshFB_fnptr = &xrCreateTriangleMeshFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateTriangleMeshFB_Lazy(XrSession session, XrTriangleMeshCreateInfoFB* createInfo, XrTriangleMeshFB* outTriangleMesh)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateTriangleMeshFB", out IntPtr temp);
            _xrCreateTriangleMeshFB_fnptr = (delegate* unmanaged<XrSession, XrTriangleMeshCreateInfoFB*, XrTriangleMeshFB*, XrResult>)temp;
            return _xrCreateTriangleMeshFB_fnptr(session, createInfo, outTriangleMesh);
        }
        public static delegate* unmanaged<XrSession, XrVirtualKeyboardCreateInfoMETA*, XrVirtualKeyboardMETA*, XrResult> _xrCreateVirtualKeyboardMETA_fnptr = &xrCreateVirtualKeyboardMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateVirtualKeyboardMETA_Lazy(XrSession session, XrVirtualKeyboardCreateInfoMETA* createInfo, XrVirtualKeyboardMETA* keyboard)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateVirtualKeyboardMETA", out IntPtr temp);
            _xrCreateVirtualKeyboardMETA_fnptr = (delegate* unmanaged<XrSession, XrVirtualKeyboardCreateInfoMETA*, XrVirtualKeyboardMETA*, XrResult>)temp;
            return _xrCreateVirtualKeyboardMETA_fnptr(session, createInfo, keyboard);
        }
        public static delegate* unmanaged<XrSession, XrVirtualKeyboardMETA, XrVirtualKeyboardSpaceCreateInfoMETA*, XrSpace*, XrResult> _xrCreateVirtualKeyboardSpaceMETA_fnptr = &xrCreateVirtualKeyboardSpaceMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateVirtualKeyboardSpaceMETA_Lazy(XrSession session, XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardSpaceCreateInfoMETA* createInfo, XrSpace* keyboardSpace)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateVirtualKeyboardSpaceMETA", out IntPtr temp);
            _xrCreateVirtualKeyboardSpaceMETA_fnptr = (delegate* unmanaged<XrSession, XrVirtualKeyboardMETA, XrVirtualKeyboardSpaceCreateInfoMETA*, XrSpace*, XrResult>)temp;
            return _xrCreateVirtualKeyboardSpaceMETA_fnptr(session, keyboard, createInfo, keyboardSpace);
        }
        public static delegate* unmanaged<XrInstance, XrVulkanDeviceCreateInfoKHR*, VkDevice*, VkResult*, XrResult> _xrCreateVulkanDeviceKHR_fnptr = &xrCreateVulkanDeviceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateVulkanDeviceKHR_Lazy(XrInstance instance, XrVulkanDeviceCreateInfoKHR* createInfo, VkDevice* vulkanDevice, VkResult* vulkanResult)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateVulkanDeviceKHR", out IntPtr temp);
            _xrCreateVulkanDeviceKHR_fnptr = (delegate* unmanaged<XrInstance, XrVulkanDeviceCreateInfoKHR*, VkDevice*, VkResult*, XrResult>)temp;
            return _xrCreateVulkanDeviceKHR_fnptr(instance, createInfo, vulkanDevice, vulkanResult);
        }
        public static delegate* unmanaged<XrInstance, XrVulkanInstanceCreateInfoKHR*, VkInstance*, VkResult*, XrResult> _xrCreateVulkanInstanceKHR_fnptr = &xrCreateVulkanInstanceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateVulkanInstanceKHR_Lazy(XrInstance instance, XrVulkanInstanceCreateInfoKHR* createInfo, VkInstance* vulkanInstance, VkResult* vulkanResult)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateVulkanInstanceKHR", out IntPtr temp);
            _xrCreateVulkanInstanceKHR_fnptr = (delegate* unmanaged<XrInstance, XrVulkanInstanceCreateInfoKHR*, VkInstance*, VkResult*, XrResult>)temp;
            return _xrCreateVulkanInstanceKHR_fnptr(instance, createInfo, vulkanInstance, vulkanResult);
        }
        public static delegate* unmanaged<XrSession, XrWorldMeshDetectorCreateInfoML*, XrWorldMeshDetectorML*, XrResult> _xrCreateWorldMeshDetectorML_fnptr = &xrCreateWorldMeshDetectorML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrCreateWorldMeshDetectorML_Lazy(XrSession session, XrWorldMeshDetectorCreateInfoML* createInfo, XrWorldMeshDetectorML* detector)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrCreateWorldMeshDetectorML", out IntPtr temp);
            _xrCreateWorldMeshDetectorML_fnptr = (delegate* unmanaged<XrSession, XrWorldMeshDetectorCreateInfoML*, XrWorldMeshDetectorML*, XrResult>)temp;
            return _xrCreateWorldMeshDetectorML_fnptr(session, createInfo, detector);
        }
        public static delegate* unmanaged<XrSpatialAnchorsStorageML, XrSpatialAnchorsDeleteInfoML*, ulong*, XrResult> _xrDeleteSpatialAnchorsAsyncML_fnptr = &xrDeleteSpatialAnchorsAsyncML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDeleteSpatialAnchorsAsyncML_Lazy(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsDeleteInfoML* deleteInfo, ulong* future)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDeleteSpatialAnchorsAsyncML", out IntPtr temp);
            _xrDeleteSpatialAnchorsAsyncML_fnptr = (delegate* unmanaged<XrSpatialAnchorsStorageML, XrSpatialAnchorsDeleteInfoML*, ulong*, XrResult>)temp;
            return _xrDeleteSpatialAnchorsAsyncML_fnptr(storage, deleteInfo, future);
        }
        public static delegate* unmanaged<XrSpatialAnchorsStorageML, ulong, XrSpatialAnchorsDeleteCompletionML*, XrResult> _xrDeleteSpatialAnchorsCompleteML_fnptr = &xrDeleteSpatialAnchorsCompleteML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDeleteSpatialAnchorsCompleteML_Lazy(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsDeleteCompletionML* completion)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDeleteSpatialAnchorsCompleteML", out IntPtr temp);
            _xrDeleteSpatialAnchorsCompleteML_fnptr = (delegate* unmanaged<XrSpatialAnchorsStorageML, ulong, XrSpatialAnchorsDeleteCompletionML*, XrResult>)temp;
            return _xrDeleteSpatialAnchorsCompleteML_fnptr(storage, future, completion);
        }
        public static delegate* unmanaged<XrSceneObserverMSFT, XrSceneDeserializeInfoMSFT*, XrResult> _xrDeserializeSceneMSFT_fnptr = &xrDeserializeSceneMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDeserializeSceneMSFT_Lazy(XrSceneObserverMSFT sceneObserver, XrSceneDeserializeInfoMSFT* deserializeInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDeserializeSceneMSFT", out IntPtr temp);
            _xrDeserializeSceneMSFT_fnptr = (delegate* unmanaged<XrSceneObserverMSFT, XrSceneDeserializeInfoMSFT*, XrResult>)temp;
            return _xrDeserializeSceneMSFT_fnptr(sceneObserver, deserializeInfo);
        }
        public static delegate* unmanaged<XrAction, XrResult> _xrDestroyAction_fnptr = &xrDestroyAction_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyAction_Lazy(XrAction action)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyAction", out IntPtr temp);
            _xrDestroyAction_fnptr = (delegate* unmanaged<XrAction, XrResult>)temp;
            return _xrDestroyAction_fnptr(action);
        }
        public static delegate* unmanaged<XrActionSet, XrResult> _xrDestroyActionSet_fnptr = &xrDestroyActionSet_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyActionSet_Lazy(XrActionSet actionSet)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyActionSet", out IntPtr temp);
            _xrDestroyActionSet_fnptr = (delegate* unmanaged<XrActionSet, XrResult>)temp;
            return _xrDestroyActionSet_fnptr(actionSet);
        }
        public static delegate* unmanaged<XrBodyTrackerBD, XrResult> _xrDestroyBodyTrackerBD_fnptr = &xrDestroyBodyTrackerBD_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyBodyTrackerBD_Lazy(XrBodyTrackerBD bodyTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyBodyTrackerBD", out IntPtr temp);
            _xrDestroyBodyTrackerBD_fnptr = (delegate* unmanaged<XrBodyTrackerBD, XrResult>)temp;
            return _xrDestroyBodyTrackerBD_fnptr(bodyTracker);
        }
        public static delegate* unmanaged<XrBodyTrackerFB, XrResult> _xrDestroyBodyTrackerFB_fnptr = &xrDestroyBodyTrackerFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyBodyTrackerFB_Lazy(XrBodyTrackerFB bodyTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyBodyTrackerFB", out IntPtr temp);
            _xrDestroyBodyTrackerFB_fnptr = (delegate* unmanaged<XrBodyTrackerFB, XrResult>)temp;
            return _xrDestroyBodyTrackerFB_fnptr(bodyTracker);
        }
        public static delegate* unmanaged<XrBodyTrackerHTC, XrResult> _xrDestroyBodyTrackerHTC_fnptr = &xrDestroyBodyTrackerHTC_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyBodyTrackerHTC_Lazy(XrBodyTrackerHTC bodyTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyBodyTrackerHTC", out IntPtr temp);
            _xrDestroyBodyTrackerHTC_fnptr = (delegate* unmanaged<XrBodyTrackerHTC, XrResult>)temp;
            return _xrDestroyBodyTrackerHTC_fnptr(bodyTracker);
        }
        public static delegate* unmanaged<XrDebugUtilsMessengerEXT, XrResult> _xrDestroyDebugUtilsMessengerEXT_fnptr = &xrDestroyDebugUtilsMessengerEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyDebugUtilsMessengerEXT_Lazy(XrDebugUtilsMessengerEXT messenger)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyDebugUtilsMessengerEXT", out IntPtr temp);
            _xrDestroyDebugUtilsMessengerEXT_fnptr = (delegate* unmanaged<XrDebugUtilsMessengerEXT, XrResult>)temp;
            return _xrDestroyDebugUtilsMessengerEXT_fnptr(messenger);
        }
        public static delegate* unmanaged<XrEnvironmentDepthProviderMETA, XrResult> _xrDestroyEnvironmentDepthProviderMETA_fnptr = &xrDestroyEnvironmentDepthProviderMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyEnvironmentDepthProviderMETA_Lazy(XrEnvironmentDepthProviderMETA environmentDepthProvider)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyEnvironmentDepthProviderMETA", out IntPtr temp);
            _xrDestroyEnvironmentDepthProviderMETA_fnptr = (delegate* unmanaged<XrEnvironmentDepthProviderMETA, XrResult>)temp;
            return _xrDestroyEnvironmentDepthProviderMETA_fnptr(environmentDepthProvider);
        }
        public static delegate* unmanaged<XrEnvironmentDepthSwapchainMETA, XrResult> _xrDestroyEnvironmentDepthSwapchainMETA_fnptr = &xrDestroyEnvironmentDepthSwapchainMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyEnvironmentDepthSwapchainMETA_Lazy(XrEnvironmentDepthSwapchainMETA swapchain)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyEnvironmentDepthSwapchainMETA", out IntPtr temp);
            _xrDestroyEnvironmentDepthSwapchainMETA_fnptr = (delegate* unmanaged<XrEnvironmentDepthSwapchainMETA, XrResult>)temp;
            return _xrDestroyEnvironmentDepthSwapchainMETA_fnptr(swapchain);
        }
        public static delegate* unmanaged<XrExportedLocalizationMapML, XrResult> _xrDestroyExportedLocalizationMapML_fnptr = &xrDestroyExportedLocalizationMapML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyExportedLocalizationMapML_Lazy(XrExportedLocalizationMapML map)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyExportedLocalizationMapML", out IntPtr temp);
            _xrDestroyExportedLocalizationMapML_fnptr = (delegate* unmanaged<XrExportedLocalizationMapML, XrResult>)temp;
            return _xrDestroyExportedLocalizationMapML_fnptr(map);
        }
        public static delegate* unmanaged<XrEyeTrackerFB, XrResult> _xrDestroyEyeTrackerFB_fnptr = &xrDestroyEyeTrackerFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyEyeTrackerFB_Lazy(XrEyeTrackerFB eyeTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyEyeTrackerFB", out IntPtr temp);
            _xrDestroyEyeTrackerFB_fnptr = (delegate* unmanaged<XrEyeTrackerFB, XrResult>)temp;
            return _xrDestroyEyeTrackerFB_fnptr(eyeTracker);
        }
        public static delegate* unmanaged<XrFaceTracker2FB, XrResult> _xrDestroyFaceTracker2FB_fnptr = &xrDestroyFaceTracker2FB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyFaceTracker2FB_Lazy(XrFaceTracker2FB faceTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyFaceTracker2FB", out IntPtr temp);
            _xrDestroyFaceTracker2FB_fnptr = (delegate* unmanaged<XrFaceTracker2FB, XrResult>)temp;
            return _xrDestroyFaceTracker2FB_fnptr(faceTracker);
        }
        public static delegate* unmanaged<XrFaceTrackerFB, XrResult> _xrDestroyFaceTrackerFB_fnptr = &xrDestroyFaceTrackerFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyFaceTrackerFB_Lazy(XrFaceTrackerFB faceTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyFaceTrackerFB", out IntPtr temp);
            _xrDestroyFaceTrackerFB_fnptr = (delegate* unmanaged<XrFaceTrackerFB, XrResult>)temp;
            return _xrDestroyFaceTrackerFB_fnptr(faceTracker);
        }
        public static delegate* unmanaged<XrFacialExpressionClientML, XrResult> _xrDestroyFacialExpressionClientML_fnptr = &xrDestroyFacialExpressionClientML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyFacialExpressionClientML_Lazy(XrFacialExpressionClientML facialExpressionClient)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyFacialExpressionClientML", out IntPtr temp);
            _xrDestroyFacialExpressionClientML_fnptr = (delegate* unmanaged<XrFacialExpressionClientML, XrResult>)temp;
            return _xrDestroyFacialExpressionClientML_fnptr(facialExpressionClient);
        }
        public static delegate* unmanaged<XrFacialTrackerHTC, XrResult> _xrDestroyFacialTrackerHTC_fnptr = &xrDestroyFacialTrackerHTC_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyFacialTrackerHTC_Lazy(XrFacialTrackerHTC facialTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyFacialTrackerHTC", out IntPtr temp);
            _xrDestroyFacialTrackerHTC_fnptr = (delegate* unmanaged<XrFacialTrackerHTC, XrResult>)temp;
            return _xrDestroyFacialTrackerHTC_fnptr(facialTracker);
        }
        public static delegate* unmanaged<XrFoveationProfileFB, XrResult> _xrDestroyFoveationProfileFB_fnptr = &xrDestroyFoveationProfileFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyFoveationProfileFB_Lazy(XrFoveationProfileFB profile)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyFoveationProfileFB", out IntPtr temp);
            _xrDestroyFoveationProfileFB_fnptr = (delegate* unmanaged<XrFoveationProfileFB, XrResult>)temp;
            return _xrDestroyFoveationProfileFB_fnptr(profile);
        }
        public static delegate* unmanaged<XrGeometryInstanceFB, XrResult> _xrDestroyGeometryInstanceFB_fnptr = &xrDestroyGeometryInstanceFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyGeometryInstanceFB_Lazy(XrGeometryInstanceFB instance)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyGeometryInstanceFB", out IntPtr temp);
            _xrDestroyGeometryInstanceFB_fnptr = (delegate* unmanaged<XrGeometryInstanceFB, XrResult>)temp;
            return _xrDestroyGeometryInstanceFB_fnptr(instance);
        }
        public static delegate* unmanaged<XrHandTrackerEXT, XrResult> _xrDestroyHandTrackerEXT_fnptr = &xrDestroyHandTrackerEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyHandTrackerEXT_Lazy(XrHandTrackerEXT handTracker)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyHandTrackerEXT", out IntPtr temp);
            _xrDestroyHandTrackerEXT_fnptr = (delegate* unmanaged<XrHandTrackerEXT, XrResult>)temp;
            return _xrDestroyHandTrackerEXT_fnptr(handTracker);
        }
        public static delegate* unmanaged<XrInstance, XrResult> _xrDestroyInstance_fnptr = &xrDestroyInstance_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyInstance_Lazy(XrInstance instance)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyInstance", out IntPtr temp);
            _xrDestroyInstance_fnptr = (delegate* unmanaged<XrInstance, XrResult>)temp;
            return _xrDestroyInstance_fnptr(instance);
        }
        public static delegate* unmanaged<XrMarkerDetectorML, XrResult> _xrDestroyMarkerDetectorML_fnptr = &xrDestroyMarkerDetectorML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyMarkerDetectorML_Lazy(XrMarkerDetectorML markerDetector)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyMarkerDetectorML", out IntPtr temp);
            _xrDestroyMarkerDetectorML_fnptr = (delegate* unmanaged<XrMarkerDetectorML, XrResult>)temp;
            return _xrDestroyMarkerDetectorML_fnptr(markerDetector);
        }
        public static delegate* unmanaged<XrPassthroughColorLutMETA, XrResult> _xrDestroyPassthroughColorLutMETA_fnptr = &xrDestroyPassthroughColorLutMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyPassthroughColorLutMETA_Lazy(XrPassthroughColorLutMETA colorLut)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyPassthroughColorLutMETA", out IntPtr temp);
            _xrDestroyPassthroughColorLutMETA_fnptr = (delegate* unmanaged<XrPassthroughColorLutMETA, XrResult>)temp;
            return _xrDestroyPassthroughColorLutMETA_fnptr(colorLut);
        }
        public static delegate* unmanaged<XrPassthroughFB, XrResult> _xrDestroyPassthroughFB_fnptr = &xrDestroyPassthroughFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyPassthroughFB_Lazy(XrPassthroughFB passthrough)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyPassthroughFB", out IntPtr temp);
            _xrDestroyPassthroughFB_fnptr = (delegate* unmanaged<XrPassthroughFB, XrResult>)temp;
            return _xrDestroyPassthroughFB_fnptr(passthrough);
        }
        public static delegate* unmanaged<XrPassthroughHTC, XrResult> _xrDestroyPassthroughHTC_fnptr = &xrDestroyPassthroughHTC_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyPassthroughHTC_Lazy(XrPassthroughHTC passthrough)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyPassthroughHTC", out IntPtr temp);
            _xrDestroyPassthroughHTC_fnptr = (delegate* unmanaged<XrPassthroughHTC, XrResult>)temp;
            return _xrDestroyPassthroughHTC_fnptr(passthrough);
        }
        public static delegate* unmanaged<XrPassthroughLayerFB, XrResult> _xrDestroyPassthroughLayerFB_fnptr = &xrDestroyPassthroughLayerFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyPassthroughLayerFB_Lazy(XrPassthroughLayerFB layer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyPassthroughLayerFB", out IntPtr temp);
            _xrDestroyPassthroughLayerFB_fnptr = (delegate* unmanaged<XrPassthroughLayerFB, XrResult>)temp;
            return _xrDestroyPassthroughLayerFB_fnptr(layer);
        }
        public static delegate* unmanaged<XrPlaneDetectorEXT, XrResult> _xrDestroyPlaneDetectorEXT_fnptr = &xrDestroyPlaneDetectorEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyPlaneDetectorEXT_Lazy(XrPlaneDetectorEXT planeDetector)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyPlaneDetectorEXT", out IntPtr temp);
            _xrDestroyPlaneDetectorEXT_fnptr = (delegate* unmanaged<XrPlaneDetectorEXT, XrResult>)temp;
            return _xrDestroyPlaneDetectorEXT_fnptr(planeDetector);
        }
        public static delegate* unmanaged<XrSceneMSFT, XrResult> _xrDestroySceneMSFT_fnptr = &xrDestroySceneMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroySceneMSFT_Lazy(XrSceneMSFT scene)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroySceneMSFT", out IntPtr temp);
            _xrDestroySceneMSFT_fnptr = (delegate* unmanaged<XrSceneMSFT, XrResult>)temp;
            return _xrDestroySceneMSFT_fnptr(scene);
        }
        public static delegate* unmanaged<XrSceneObserverMSFT, XrResult> _xrDestroySceneObserverMSFT_fnptr = &xrDestroySceneObserverMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroySceneObserverMSFT_Lazy(XrSceneObserverMSFT sceneObserver)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroySceneObserverMSFT", out IntPtr temp);
            _xrDestroySceneObserverMSFT_fnptr = (delegate* unmanaged<XrSceneObserverMSFT, XrResult>)temp;
            return _xrDestroySceneObserverMSFT_fnptr(sceneObserver);
        }
        public static delegate* unmanaged<XrSession, XrResult> _xrDestroySession_fnptr = &xrDestroySession_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroySession_Lazy(XrSession session)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroySession", out IntPtr temp);
            _xrDestroySession_fnptr = (delegate* unmanaged<XrSession, XrResult>)temp;
            return _xrDestroySession_fnptr(session);
        }
        public static delegate* unmanaged<XrSpace, XrResult> _xrDestroySpace_fnptr = &xrDestroySpace_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroySpace_Lazy(XrSpace space)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroySpace", out IntPtr temp);
            _xrDestroySpace_fnptr = (delegate* unmanaged<XrSpace, XrResult>)temp;
            return _xrDestroySpace_fnptr(space);
        }
        public static delegate* unmanaged<XrSpaceUserFB, XrResult> _xrDestroySpaceUserFB_fnptr = &xrDestroySpaceUserFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroySpaceUserFB_Lazy(XrSpaceUserFB user)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroySpaceUserFB", out IntPtr temp);
            _xrDestroySpaceUserFB_fnptr = (delegate* unmanaged<XrSpaceUserFB, XrResult>)temp;
            return _xrDestroySpaceUserFB_fnptr(user);
        }
        public static delegate* unmanaged<XrSpatialAnchorMSFT, XrResult> _xrDestroySpatialAnchorMSFT_fnptr = &xrDestroySpatialAnchorMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroySpatialAnchorMSFT_Lazy(XrSpatialAnchorMSFT anchor)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroySpatialAnchorMSFT", out IntPtr temp);
            _xrDestroySpatialAnchorMSFT_fnptr = (delegate* unmanaged<XrSpatialAnchorMSFT, XrResult>)temp;
            return _xrDestroySpatialAnchorMSFT_fnptr(anchor);
        }
        public static delegate* unmanaged<XrSpatialAnchorsStorageML, XrResult> _xrDestroySpatialAnchorsStorageML_fnptr = &xrDestroySpatialAnchorsStorageML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroySpatialAnchorsStorageML_Lazy(XrSpatialAnchorsStorageML storage)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroySpatialAnchorsStorageML", out IntPtr temp);
            _xrDestroySpatialAnchorsStorageML_fnptr = (delegate* unmanaged<XrSpatialAnchorsStorageML, XrResult>)temp;
            return _xrDestroySpatialAnchorsStorageML_fnptr(storage);
        }
        public static delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrResult> _xrDestroySpatialAnchorStoreConnectionMSFT_fnptr = &xrDestroySpatialAnchorStoreConnectionMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroySpatialAnchorStoreConnectionMSFT_Lazy(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroySpatialAnchorStoreConnectionMSFT", out IntPtr temp);
            _xrDestroySpatialAnchorStoreConnectionMSFT_fnptr = (delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrResult>)temp;
            return _xrDestroySpatialAnchorStoreConnectionMSFT_fnptr(spatialAnchorStore);
        }
        public static delegate* unmanaged<XrSpatialGraphNodeBindingMSFT, XrResult> _xrDestroySpatialGraphNodeBindingMSFT_fnptr = &xrDestroySpatialGraphNodeBindingMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroySpatialGraphNodeBindingMSFT_Lazy(XrSpatialGraphNodeBindingMSFT nodeBinding)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroySpatialGraphNodeBindingMSFT", out IntPtr temp);
            _xrDestroySpatialGraphNodeBindingMSFT_fnptr = (delegate* unmanaged<XrSpatialGraphNodeBindingMSFT, XrResult>)temp;
            return _xrDestroySpatialGraphNodeBindingMSFT_fnptr(nodeBinding);
        }
        public static delegate* unmanaged<XrSwapchain, XrResult> _xrDestroySwapchain_fnptr = &xrDestroySwapchain_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroySwapchain_Lazy(XrSwapchain swapchain)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroySwapchain", out IntPtr temp);
            _xrDestroySwapchain_fnptr = (delegate* unmanaged<XrSwapchain, XrResult>)temp;
            return _xrDestroySwapchain_fnptr(swapchain);
        }
        public static delegate* unmanaged<XrTriangleMeshFB, XrResult> _xrDestroyTriangleMeshFB_fnptr = &xrDestroyTriangleMeshFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyTriangleMeshFB_Lazy(XrTriangleMeshFB mesh)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyTriangleMeshFB", out IntPtr temp);
            _xrDestroyTriangleMeshFB_fnptr = (delegate* unmanaged<XrTriangleMeshFB, XrResult>)temp;
            return _xrDestroyTriangleMeshFB_fnptr(mesh);
        }
        public static delegate* unmanaged<XrVirtualKeyboardMETA, XrResult> _xrDestroyVirtualKeyboardMETA_fnptr = &xrDestroyVirtualKeyboardMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyVirtualKeyboardMETA_Lazy(XrVirtualKeyboardMETA keyboard)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyVirtualKeyboardMETA", out IntPtr temp);
            _xrDestroyVirtualKeyboardMETA_fnptr = (delegate* unmanaged<XrVirtualKeyboardMETA, XrResult>)temp;
            return _xrDestroyVirtualKeyboardMETA_fnptr(keyboard);
        }
        public static delegate* unmanaged<XrWorldMeshDetectorML, XrResult> _xrDestroyWorldMeshDetectorML_fnptr = &xrDestroyWorldMeshDetectorML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrDestroyWorldMeshDetectorML_Lazy(XrWorldMeshDetectorML detector)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrDestroyWorldMeshDetectorML", out IntPtr temp);
            _xrDestroyWorldMeshDetectorML_fnptr = (delegate* unmanaged<XrWorldMeshDetectorML, XrResult>)temp;
            return _xrDestroyWorldMeshDetectorML_fnptr(detector);
        }
        public static delegate* unmanaged<XrSession, XrLocalizationEnableEventsInfoML*, XrResult> _xrEnableLocalizationEventsML_fnptr = &xrEnableLocalizationEventsML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnableLocalizationEventsML_Lazy(XrSession session, XrLocalizationEnableEventsInfoML* info)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnableLocalizationEventsML", out IntPtr temp);
            _xrEnableLocalizationEventsML_fnptr = (delegate* unmanaged<XrSession, XrLocalizationEnableEventsInfoML*, XrResult>)temp;
            return _xrEnableLocalizationEventsML_fnptr(session, info);
        }
        public static delegate* unmanaged<XrInstance, XrUserCalibrationEnableEventsInfoML*, XrResult> _xrEnableUserCalibrationEventsML_fnptr = &xrEnableUserCalibrationEventsML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnableUserCalibrationEventsML_Lazy(XrInstance instance, XrUserCalibrationEnableEventsInfoML* enableInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnableUserCalibrationEventsML", out IntPtr temp);
            _xrEnableUserCalibrationEventsML_fnptr = (delegate* unmanaged<XrInstance, XrUserCalibrationEnableEventsInfoML*, XrResult>)temp;
            return _xrEnableUserCalibrationEventsML_fnptr(instance, enableInfo);
        }
        public static delegate* unmanaged<XrSession, XrFrameEndInfo*, XrResult> _xrEndFrame_fnptr = &xrEndFrame_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEndFrame_Lazy(XrSession session, XrFrameEndInfo* frameEndInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEndFrame", out IntPtr temp);
            _xrEndFrame_fnptr = (delegate* unmanaged<XrSession, XrFrameEndInfo*, XrResult>)temp;
            return _xrEndFrame_fnptr(session, frameEndInfo);
        }
        public static delegate* unmanaged<XrSession, XrResult> _xrEndSession_fnptr = &xrEndSession_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEndSession_Lazy(XrSession session)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEndSession", out IntPtr temp);
            _xrEndSession_fnptr = (delegate* unmanaged<XrSession, XrResult>)temp;
            return _xrEndSession_fnptr(session);
        }
        public static delegate* unmanaged<uint, uint*, XrApiLayerProperties*, XrResult> _xrEnumerateApiLayerProperties_fnptr = &xrEnumerateApiLayerProperties_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateApiLayerProperties_Lazy(uint propertyCapacityInput, uint* propertyCountOutput, XrApiLayerProperties* properties)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateApiLayerProperties", out IntPtr temp);
            _xrEnumerateApiLayerProperties_fnptr = (delegate* unmanaged<uint, uint*, XrApiLayerProperties*, XrResult>)temp;
            return _xrEnumerateApiLayerProperties_fnptr(propertyCapacityInput, propertyCountOutput, properties);
        }
        public static delegate* unmanaged<XrSession, XrBoundSourcesForActionEnumerateInfo*, uint, uint*, ulong*, XrResult> _xrEnumerateBoundSourcesForAction_fnptr = &xrEnumerateBoundSourcesForAction_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateBoundSourcesForAction_Lazy(XrSession session, XrBoundSourcesForActionEnumerateInfo* enumerateInfo, uint sourceCapacityInput, uint* sourceCountOutput, ulong* sources)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateBoundSourcesForAction", out IntPtr temp);
            _xrEnumerateBoundSourcesForAction_fnptr = (delegate* unmanaged<XrSession, XrBoundSourcesForActionEnumerateInfo*, uint, uint*, ulong*, XrResult>)temp;
            return _xrEnumerateBoundSourcesForAction_fnptr(session, enumerateInfo, sourceCapacityInput, sourceCountOutput, sources);
        }
        public static delegate* unmanaged<XrSession, uint, uint*, XrColorSpaceFB*, XrResult> _xrEnumerateColorSpacesFB_fnptr = &xrEnumerateColorSpacesFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateColorSpacesFB_Lazy(XrSession session, uint colorSpaceCapacityInput, uint* colorSpaceCountOutput, XrColorSpaceFB* colorSpaces)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateColorSpacesFB", out IntPtr temp);
            _xrEnumerateColorSpacesFB_fnptr = (delegate* unmanaged<XrSession, uint, uint*, XrColorSpaceFB*, XrResult>)temp;
            return _xrEnumerateColorSpacesFB_fnptr(session, colorSpaceCapacityInput, colorSpaceCountOutput, colorSpaces);
        }
        public static delegate* unmanaged<XrSession, uint, uint*, float*, XrResult> _xrEnumerateDisplayRefreshRatesFB_fnptr = &xrEnumerateDisplayRefreshRatesFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateDisplayRefreshRatesFB_Lazy(XrSession session, uint displayRefreshRateCapacityInput, uint* displayRefreshRateCountOutput, float* displayRefreshRates)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateDisplayRefreshRatesFB", out IntPtr temp);
            _xrEnumerateDisplayRefreshRatesFB_fnptr = (delegate* unmanaged<XrSession, uint, uint*, float*, XrResult>)temp;
            return _xrEnumerateDisplayRefreshRatesFB_fnptr(session, displayRefreshRateCapacityInput, displayRefreshRateCountOutput, displayRefreshRates);
        }
        public static delegate* unmanaged<XrInstance, ulong, XrViewConfigurationType, uint, uint*, XrEnvironmentBlendMode*, XrResult> _xrEnumerateEnvironmentBlendModes_fnptr = &xrEnumerateEnvironmentBlendModes_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateEnvironmentBlendModes_Lazy(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint environmentBlendModeCapacityInput, uint* environmentBlendModeCountOutput, XrEnvironmentBlendMode* environmentBlendModes)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateEnvironmentBlendModes", out IntPtr temp);
            _xrEnumerateEnvironmentBlendModes_fnptr = (delegate* unmanaged<XrInstance, ulong, XrViewConfigurationType, uint, uint*, XrEnvironmentBlendMode*, XrResult>)temp;
            return _xrEnumerateEnvironmentBlendModes_fnptr(instance, systemId, viewConfigurationType, environmentBlendModeCapacityInput, environmentBlendModeCountOutput, environmentBlendModes);
        }
        public static delegate* unmanaged<XrEnvironmentDepthSwapchainMETA, uint, uint*, XrSwapchainImageBaseHeader*, XrResult> _xrEnumerateEnvironmentDepthSwapchainImagesMETA_fnptr = &xrEnumerateEnvironmentDepthSwapchainImagesMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateEnvironmentDepthSwapchainImagesMETA_Lazy(XrEnvironmentDepthSwapchainMETA swapchain, uint imageCapacityInput, uint* imageCountOutput, XrSwapchainImageBaseHeader* images)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateEnvironmentDepthSwapchainImagesMETA", out IntPtr temp);
            _xrEnumerateEnvironmentDepthSwapchainImagesMETA_fnptr = (delegate* unmanaged<XrEnvironmentDepthSwapchainMETA, uint, uint*, XrSwapchainImageBaseHeader*, XrResult>)temp;
            return _xrEnumerateEnvironmentDepthSwapchainImagesMETA_fnptr(swapchain, imageCapacityInput, imageCountOutput, images);
        }
        public static delegate* unmanaged<XrSession, uint, uint*, XrExternalCameraOCULUS*, XrResult> _xrEnumerateExternalCamerasOCULUS_fnptr = &xrEnumerateExternalCamerasOCULUS_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateExternalCamerasOCULUS_Lazy(XrSession session, uint cameraCapacityInput, uint* cameraCountOutput, XrExternalCameraOCULUS* cameras)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateExternalCamerasOCULUS", out IntPtr temp);
            _xrEnumerateExternalCamerasOCULUS_fnptr = (delegate* unmanaged<XrSession, uint, uint*, XrExternalCameraOCULUS*, XrResult>)temp;
            return _xrEnumerateExternalCamerasOCULUS_fnptr(session, cameraCapacityInput, cameraCountOutput, cameras);
        }
        public static delegate* unmanaged<byte*, uint, uint*, XrExtensionProperties*, XrResult> _xrEnumerateInstanceExtensionProperties_fnptr = &xrEnumerateInstanceExtensionProperties_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateInstanceExtensionProperties_Lazy(byte* layerName, uint propertyCapacityInput, uint* propertyCountOutput, XrExtensionProperties* properties)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateInstanceExtensionProperties", out IntPtr temp);
            _xrEnumerateInstanceExtensionProperties_fnptr = (delegate* unmanaged<byte*, uint, uint*, XrExtensionProperties*, XrResult>)temp;
            return _xrEnumerateInstanceExtensionProperties_fnptr(layerName, propertyCapacityInput, propertyCountOutput, properties);
        }
        public static delegate* unmanaged<XrInstance, uint, uint*, ulong*, XrResult> _xrEnumeratePerformanceMetricsCounterPathsMETA_fnptr = &xrEnumeratePerformanceMetricsCounterPathsMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumeratePerformanceMetricsCounterPathsMETA_Lazy(XrInstance instance, uint counterPathCapacityInput, uint* counterPathCountOutput, ulong* counterPaths)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumeratePerformanceMetricsCounterPathsMETA", out IntPtr temp);
            _xrEnumeratePerformanceMetricsCounterPathsMETA_fnptr = (delegate* unmanaged<XrInstance, uint, uint*, ulong*, XrResult>)temp;
            return _xrEnumeratePerformanceMetricsCounterPathsMETA_fnptr(instance, counterPathCapacityInput, counterPathCountOutput, counterPaths);
        }
        public static delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, uint, uint*, XrSpatialAnchorPersistenceNameMSFT*, XrResult> _xrEnumeratePersistedSpatialAnchorNamesMSFT_fnptr = &xrEnumeratePersistedSpatialAnchorNamesMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumeratePersistedSpatialAnchorNamesMSFT_Lazy(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, uint spatialAnchorNameCapacityInput, uint* spatialAnchorNameCountOutput, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorNames)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumeratePersistedSpatialAnchorNamesMSFT", out IntPtr temp);
            _xrEnumeratePersistedSpatialAnchorNamesMSFT_fnptr = (delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, uint, uint*, XrSpatialAnchorPersistenceNameMSFT*, XrResult>)temp;
            return _xrEnumeratePersistedSpatialAnchorNamesMSFT_fnptr(spatialAnchorStore, spatialAnchorNameCapacityInput, spatialAnchorNameCountOutput, spatialAnchorNames);
        }
        public static delegate* unmanaged<XrSession, uint, uint*, XrReferenceSpaceType*, XrResult> _xrEnumerateReferenceSpaces_fnptr = &xrEnumerateReferenceSpaces_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateReferenceSpaces_Lazy(XrSession session, uint spaceCapacityInput, uint* spaceCountOutput, XrReferenceSpaceType* spaces)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateReferenceSpaces", out IntPtr temp);
            _xrEnumerateReferenceSpaces_fnptr = (delegate* unmanaged<XrSession, uint, uint*, XrReferenceSpaceType*, XrResult>)temp;
            return _xrEnumerateReferenceSpaces_fnptr(session, spaceCapacityInput, spaceCountOutput, spaces);
        }
        public static delegate* unmanaged<XrSession, uint, uint*, XrRenderModelPathInfoFB*, XrResult> _xrEnumerateRenderModelPathsFB_fnptr = &xrEnumerateRenderModelPathsFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateRenderModelPathsFB_Lazy(XrSession session, uint pathCapacityInput, uint* pathCountOutput, XrRenderModelPathInfoFB* paths)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateRenderModelPathsFB", out IntPtr temp);
            _xrEnumerateRenderModelPathsFB_fnptr = (delegate* unmanaged<XrSession, uint, uint*, XrRenderModelPathInfoFB*, XrResult>)temp;
            return _xrEnumerateRenderModelPathsFB_fnptr(session, pathCapacityInput, pathCountOutput, paths);
        }
        public static delegate* unmanaged<XrInstance, ulong, XrViewConfigurationType, uint, uint*, XrReprojectionModeMSFT*, XrResult> _xrEnumerateReprojectionModesMSFT_fnptr = &xrEnumerateReprojectionModesMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateReprojectionModesMSFT_Lazy(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint modeCapacityInput, uint* modeCountOutput, XrReprojectionModeMSFT* modes)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateReprojectionModesMSFT", out IntPtr temp);
            _xrEnumerateReprojectionModesMSFT_fnptr = (delegate* unmanaged<XrInstance, ulong, XrViewConfigurationType, uint, uint*, XrReprojectionModeMSFT*, XrResult>)temp;
            return _xrEnumerateReprojectionModesMSFT_fnptr(instance, systemId, viewConfigurationType, modeCapacityInput, modeCountOutput, modes);
        }
        public static delegate* unmanaged<XrInstance, ulong, uint, uint*, XrSceneComputeFeatureMSFT*, XrResult> _xrEnumerateSceneComputeFeaturesMSFT_fnptr = &xrEnumerateSceneComputeFeaturesMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateSceneComputeFeaturesMSFT_Lazy(XrInstance instance, ulong systemId, uint featureCapacityInput, uint* featureCountOutput, XrSceneComputeFeatureMSFT* features)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateSceneComputeFeaturesMSFT", out IntPtr temp);
            _xrEnumerateSceneComputeFeaturesMSFT_fnptr = (delegate* unmanaged<XrInstance, ulong, uint, uint*, XrSceneComputeFeatureMSFT*, XrResult>)temp;
            return _xrEnumerateSceneComputeFeaturesMSFT_fnptr(instance, systemId, featureCapacityInput, featureCountOutput, features);
        }
        public static delegate* unmanaged<XrSpace, uint, uint*, XrSpaceComponentTypeFB*, XrResult> _xrEnumerateSpaceSupportedComponentsFB_fnptr = &xrEnumerateSpaceSupportedComponentsFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateSpaceSupportedComponentsFB_Lazy(XrSpace space, uint componentTypeCapacityInput, uint* componentTypeCountOutput, XrSpaceComponentTypeFB* componentTypes)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateSpaceSupportedComponentsFB", out IntPtr temp);
            _xrEnumerateSpaceSupportedComponentsFB_fnptr = (delegate* unmanaged<XrSpace, uint, uint*, XrSpaceComponentTypeFB*, XrResult>)temp;
            return _xrEnumerateSpaceSupportedComponentsFB_fnptr(space, componentTypeCapacityInput, componentTypeCountOutput, componentTypes);
        }
        public static delegate* unmanaged<XrSession, uint, uint*, long*, XrResult> _xrEnumerateSwapchainFormats_fnptr = &xrEnumerateSwapchainFormats_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateSwapchainFormats_Lazy(XrSession session, uint formatCapacityInput, uint* formatCountOutput, long* formats)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateSwapchainFormats", out IntPtr temp);
            _xrEnumerateSwapchainFormats_fnptr = (delegate* unmanaged<XrSession, uint, uint*, long*, XrResult>)temp;
            return _xrEnumerateSwapchainFormats_fnptr(session, formatCapacityInput, formatCountOutput, formats);
        }
        public static delegate* unmanaged<XrSwapchain, uint, uint*, XrSwapchainImageBaseHeader*, XrResult> _xrEnumerateSwapchainImages_fnptr = &xrEnumerateSwapchainImages_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateSwapchainImages_Lazy(XrSwapchain swapchain, uint imageCapacityInput, uint* imageCountOutput, XrSwapchainImageBaseHeader* images)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateSwapchainImages", out IntPtr temp);
            _xrEnumerateSwapchainImages_fnptr = (delegate* unmanaged<XrSwapchain, uint, uint*, XrSwapchainImageBaseHeader*, XrResult>)temp;
            return _xrEnumerateSwapchainImages_fnptr(swapchain, imageCapacityInput, imageCountOutput, images);
        }
        public static delegate* unmanaged<XrInstance, ulong, uint, uint*, XrViewConfigurationType*, XrResult> _xrEnumerateViewConfigurations_fnptr = &xrEnumerateViewConfigurations_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateViewConfigurations_Lazy(XrInstance instance, ulong systemId, uint viewConfigurationTypeCapacityInput, uint* viewConfigurationTypeCountOutput, XrViewConfigurationType* viewConfigurationTypes)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateViewConfigurations", out IntPtr temp);
            _xrEnumerateViewConfigurations_fnptr = (delegate* unmanaged<XrInstance, ulong, uint, uint*, XrViewConfigurationType*, XrResult>)temp;
            return _xrEnumerateViewConfigurations_fnptr(instance, systemId, viewConfigurationTypeCapacityInput, viewConfigurationTypeCountOutput, viewConfigurationTypes);
        }
        public static delegate* unmanaged<XrInstance, ulong, XrViewConfigurationType, uint, uint*, XrViewConfigurationView*, XrResult> _xrEnumerateViewConfigurationViews_fnptr = &xrEnumerateViewConfigurationViews_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateViewConfigurationViews_Lazy(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint viewCapacityInput, uint* viewCountOutput, XrViewConfigurationView* views)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateViewConfigurationViews", out IntPtr temp);
            _xrEnumerateViewConfigurationViews_fnptr = (delegate* unmanaged<XrInstance, ulong, XrViewConfigurationType, uint, uint*, XrViewConfigurationView*, XrResult>)temp;
            return _xrEnumerateViewConfigurationViews_fnptr(instance, systemId, viewConfigurationType, viewCapacityInput, viewCountOutput, views);
        }
        public static delegate* unmanaged<XrInstance, uint, uint*, XrViveTrackerPathsHTCX*, XrResult> _xrEnumerateViveTrackerPathsHTCX_fnptr = &xrEnumerateViveTrackerPathsHTCX_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEnumerateViveTrackerPathsHTCX_Lazy(XrInstance instance, uint pathCapacityInput, uint* pathCountOutput, XrViveTrackerPathsHTCX* paths)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEnumerateViveTrackerPathsHTCX", out IntPtr temp);
            _xrEnumerateViveTrackerPathsHTCX_fnptr = (delegate* unmanaged<XrInstance, uint, uint*, XrViveTrackerPathsHTCX*, XrResult>)temp;
            return _xrEnumerateViveTrackerPathsHTCX_fnptr(instance, pathCapacityInput, pathCountOutput, paths);
        }
        public static delegate* unmanaged<XrSession, XrSpaceEraseInfoFB*, ulong*, XrResult> _xrEraseSpaceFB_fnptr = &xrEraseSpaceFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrEraseSpaceFB_Lazy(XrSession session, XrSpaceEraseInfoFB* info, ulong* requestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrEraseSpaceFB", out IntPtr temp);
            _xrEraseSpaceFB_fnptr = (delegate* unmanaged<XrSession, XrSpaceEraseInfoFB*, ulong*, XrResult>)temp;
            return _xrEraseSpaceFB_fnptr(session, info, requestId);
        }
        public static delegate* unmanaged<XrWorldMeshDetectorML, XrWorldMeshBufferML*, XrResult> _xrFreeWorldMeshBufferML_fnptr = &xrFreeWorldMeshBufferML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrFreeWorldMeshBufferML_Lazy(XrWorldMeshDetectorML detector, XrWorldMeshBufferML* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrFreeWorldMeshBufferML", out IntPtr temp);
            _xrFreeWorldMeshBufferML_fnptr = (delegate* unmanaged<XrWorldMeshDetectorML, XrWorldMeshBufferML*, XrResult>)temp;
            return _xrFreeWorldMeshBufferML_fnptr(detector, buffer);
        }
        public static delegate* unmanaged<XrGeometryInstanceFB, XrGeometryInstanceTransformFB*, XrResult> _xrGeometryInstanceSetTransformFB_fnptr = &xrGeometryInstanceSetTransformFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGeometryInstanceSetTransformFB_Lazy(XrGeometryInstanceFB instance, XrGeometryInstanceTransformFB* transformation)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGeometryInstanceSetTransformFB", out IntPtr temp);
            _xrGeometryInstanceSetTransformFB_fnptr = (delegate* unmanaged<XrGeometryInstanceFB, XrGeometryInstanceTransformFB*, XrResult>)temp;
            return _xrGeometryInstanceSetTransformFB_fnptr(instance, transformation);
        }
        public static delegate* unmanaged<XrSession, XrActionStateGetInfo*, XrActionStateBoolean*, XrResult> _xrGetActionStateBoolean_fnptr = &xrGetActionStateBoolean_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetActionStateBoolean_Lazy(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateBoolean* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetActionStateBoolean", out IntPtr temp);
            _xrGetActionStateBoolean_fnptr = (delegate* unmanaged<XrSession, XrActionStateGetInfo*, XrActionStateBoolean*, XrResult>)temp;
            return _xrGetActionStateBoolean_fnptr(session, getInfo, state);
        }
        public static delegate* unmanaged<XrSession, XrActionStateGetInfo*, XrActionStateFloat*, XrResult> _xrGetActionStateFloat_fnptr = &xrGetActionStateFloat_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetActionStateFloat_Lazy(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateFloat* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetActionStateFloat", out IntPtr temp);
            _xrGetActionStateFloat_fnptr = (delegate* unmanaged<XrSession, XrActionStateGetInfo*, XrActionStateFloat*, XrResult>)temp;
            return _xrGetActionStateFloat_fnptr(session, getInfo, state);
        }
        public static delegate* unmanaged<XrSession, XrActionStateGetInfo*, XrActionStatePose*, XrResult> _xrGetActionStatePose_fnptr = &xrGetActionStatePose_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetActionStatePose_Lazy(XrSession session, XrActionStateGetInfo* getInfo, XrActionStatePose* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetActionStatePose", out IntPtr temp);
            _xrGetActionStatePose_fnptr = (delegate* unmanaged<XrSession, XrActionStateGetInfo*, XrActionStatePose*, XrResult>)temp;
            return _xrGetActionStatePose_fnptr(session, getInfo, state);
        }
        public static delegate* unmanaged<XrSession, XrActionStateGetInfo*, XrActionStateVector2f*, XrResult> _xrGetActionStateVector2f_fnptr = &xrGetActionStateVector2f_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetActionStateVector2f_Lazy(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateVector2f* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetActionStateVector2f", out IntPtr temp);
            _xrGetActionStateVector2f_fnptr = (delegate* unmanaged<XrSession, XrActionStateGetInfo*, XrActionStateVector2f*, XrResult>)temp;
            return _xrGetActionStateVector2f_fnptr(session, getInfo, state);
        }
        public static delegate* unmanaged<XrInstance, char*, XrResult> _xrGetAudioInputDeviceGuidOculus_fnptr = &xrGetAudioInputDeviceGuidOculus_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetAudioInputDeviceGuidOculus_Lazy(XrInstance instance, char* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetAudioInputDeviceGuidOculus", out IntPtr temp);
            _xrGetAudioInputDeviceGuidOculus_fnptr = (delegate* unmanaged<XrInstance, char*, XrResult>)temp;
            return _xrGetAudioInputDeviceGuidOculus_fnptr(instance, buffer);
        }
        public static delegate* unmanaged<XrInstance, char*, XrResult> _xrGetAudioOutputDeviceGuidOculus_fnptr = &xrGetAudioOutputDeviceGuidOculus_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetAudioOutputDeviceGuidOculus_Lazy(XrInstance instance, char* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetAudioOutputDeviceGuidOculus", out IntPtr temp);
            _xrGetAudioOutputDeviceGuidOculus_fnptr = (delegate* unmanaged<XrInstance, char*, XrResult>)temp;
            return _xrGetAudioOutputDeviceGuidOculus_fnptr(instance, buffer);
        }
        public static delegate* unmanaged<XrBodyTrackerFB, XrBodySkeletonFB*, XrResult> _xrGetBodySkeletonFB_fnptr = &xrGetBodySkeletonFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetBodySkeletonFB_Lazy(XrBodyTrackerFB bodyTracker, XrBodySkeletonFB* skeleton)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetBodySkeletonFB", out IntPtr temp);
            _xrGetBodySkeletonFB_fnptr = (delegate* unmanaged<XrBodyTrackerFB, XrBodySkeletonFB*, XrResult>)temp;
            return _xrGetBodySkeletonFB_fnptr(bodyTracker, skeleton);
        }
        public static delegate* unmanaged<XrBodyTrackerHTC, XrSpace, uint, XrBodySkeletonHTC*, XrResult> _xrGetBodySkeletonHTC_fnptr = &xrGetBodySkeletonHTC_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetBodySkeletonHTC_Lazy(XrBodyTrackerHTC bodyTracker, XrSpace baseSpace, uint skeletonGenerationId, XrBodySkeletonHTC* skeleton)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetBodySkeletonHTC", out IntPtr temp);
            _xrGetBodySkeletonHTC_fnptr = (delegate* unmanaged<XrBodyTrackerHTC, XrSpace, uint, XrBodySkeletonHTC*, XrResult>)temp;
            return _xrGetBodySkeletonHTC_fnptr(bodyTracker, baseSpace, skeletonGenerationId, skeleton);
        }
        public static delegate* unmanaged<XrSession, ulong, XrControllerModelKeyStateMSFT*, XrResult> _xrGetControllerModelKeyMSFT_fnptr = &xrGetControllerModelKeyMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetControllerModelKeyMSFT_Lazy(XrSession session, ulong topLevelUserPath, XrControllerModelKeyStateMSFT* controllerModelKeyState)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetControllerModelKeyMSFT", out IntPtr temp);
            _xrGetControllerModelKeyMSFT_fnptr = (delegate* unmanaged<XrSession, ulong, XrControllerModelKeyStateMSFT*, XrResult>)temp;
            return _xrGetControllerModelKeyMSFT_fnptr(session, topLevelUserPath, controllerModelKeyState);
        }
        public static delegate* unmanaged<XrSession, ulong, XrControllerModelPropertiesMSFT*, XrResult> _xrGetControllerModelPropertiesMSFT_fnptr = &xrGetControllerModelPropertiesMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetControllerModelPropertiesMSFT_Lazy(XrSession session, ulong modelKey, XrControllerModelPropertiesMSFT* properties)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetControllerModelPropertiesMSFT", out IntPtr temp);
            _xrGetControllerModelPropertiesMSFT_fnptr = (delegate* unmanaged<XrSession, ulong, XrControllerModelPropertiesMSFT*, XrResult>)temp;
            return _xrGetControllerModelPropertiesMSFT_fnptr(session, modelKey, properties);
        }
        public static delegate* unmanaged<XrSession, ulong, XrControllerModelStateMSFT*, XrResult> _xrGetControllerModelStateMSFT_fnptr = &xrGetControllerModelStateMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetControllerModelStateMSFT_Lazy(XrSession session, ulong modelKey, XrControllerModelStateMSFT* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetControllerModelStateMSFT", out IntPtr temp);
            _xrGetControllerModelStateMSFT_fnptr = (delegate* unmanaged<XrSession, ulong, XrControllerModelStateMSFT*, XrResult>)temp;
            return _xrGetControllerModelStateMSFT_fnptr(session, modelKey, state);
        }
        public static delegate* unmanaged<XrSession, ulong, XrInteractionProfileState*, XrResult> _xrGetCurrentInteractionProfile_fnptr = &xrGetCurrentInteractionProfile_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetCurrentInteractionProfile_Lazy(XrSession session, ulong topLevelUserPath, XrInteractionProfileState* interactionProfile)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetCurrentInteractionProfile", out IntPtr temp);
            _xrGetCurrentInteractionProfile_fnptr = (delegate* unmanaged<XrSession, ulong, XrInteractionProfileState*, XrResult>)temp;
            return _xrGetCurrentInteractionProfile_fnptr(session, topLevelUserPath, interactionProfile);
        }
        public static delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsD3D11KHR*, XrResult> _xrGetD3D11GraphicsRequirementsKHR_fnptr = &xrGetD3D11GraphicsRequirementsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetD3D11GraphicsRequirementsKHR_Lazy(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D11KHR* graphicsRequirements)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetD3D11GraphicsRequirementsKHR", out IntPtr temp);
            _xrGetD3D11GraphicsRequirementsKHR_fnptr = (delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsD3D11KHR*, XrResult>)temp;
            return _xrGetD3D11GraphicsRequirementsKHR_fnptr(instance, systemId, graphicsRequirements);
        }
        public static delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsD3D12KHR*, XrResult> _xrGetD3D12GraphicsRequirementsKHR_fnptr = &xrGetD3D12GraphicsRequirementsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetD3D12GraphicsRequirementsKHR_Lazy(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D12KHR* graphicsRequirements)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetD3D12GraphicsRequirementsKHR", out IntPtr temp);
            _xrGetD3D12GraphicsRequirementsKHR_fnptr = (delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsD3D12KHR*, XrResult>)temp;
            return _xrGetD3D12GraphicsRequirementsKHR_fnptr(instance, systemId, graphicsRequirements);
        }
        public static delegate* unmanaged<XrSession, XrHapticActionInfo*, XrDevicePcmSampleRateStateFB*, XrResult> _xrGetDeviceSampleRateFB_fnptr = &xrGetDeviceSampleRateFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetDeviceSampleRateFB_Lazy(XrSession session, XrHapticActionInfo* hapticActionInfo, XrDevicePcmSampleRateStateFB* deviceSampleRate)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetDeviceSampleRateFB", out IntPtr temp);
            _xrGetDeviceSampleRateFB_fnptr = (delegate* unmanaged<XrSession, XrHapticActionInfo*, XrDevicePcmSampleRateStateFB*, XrResult>)temp;
            return _xrGetDeviceSampleRateFB_fnptr(session, hapticActionInfo, deviceSampleRate);
        }
        public static delegate* unmanaged<XrSession, float*, XrResult> _xrGetDisplayRefreshRateFB_fnptr = &xrGetDisplayRefreshRateFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetDisplayRefreshRateFB_Lazy(XrSession session, float* displayRefreshRate)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetDisplayRefreshRateFB", out IntPtr temp);
            _xrGetDisplayRefreshRateFB_fnptr = (delegate* unmanaged<XrSession, float*, XrResult>)temp;
            return _xrGetDisplayRefreshRateFB_fnptr(session, displayRefreshRate);
        }
        public static delegate* unmanaged<XrEnvironmentDepthSwapchainMETA, XrEnvironmentDepthSwapchainStateMETA*, XrResult> _xrGetEnvironmentDepthSwapchainStateMETA_fnptr = &xrGetEnvironmentDepthSwapchainStateMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetEnvironmentDepthSwapchainStateMETA_Lazy(XrEnvironmentDepthSwapchainMETA swapchain, XrEnvironmentDepthSwapchainStateMETA* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetEnvironmentDepthSwapchainStateMETA", out IntPtr temp);
            _xrGetEnvironmentDepthSwapchainStateMETA_fnptr = (delegate* unmanaged<XrEnvironmentDepthSwapchainMETA, XrEnvironmentDepthSwapchainStateMETA*, XrResult>)temp;
            return _xrGetEnvironmentDepthSwapchainStateMETA_fnptr(swapchain, state);
        }
        public static delegate* unmanaged<XrExportedLocalizationMapML, uint, uint*, byte*, XrResult> _xrGetExportedLocalizationMapDataML_fnptr = &xrGetExportedLocalizationMapDataML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetExportedLocalizationMapDataML_Lazy(XrExportedLocalizationMapML map, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetExportedLocalizationMapDataML", out IntPtr temp);
            _xrGetExportedLocalizationMapDataML_fnptr = (delegate* unmanaged<XrExportedLocalizationMapML, uint, uint*, byte*, XrResult>)temp;
            return _xrGetExportedLocalizationMapDataML_fnptr(map, bufferCapacityInput, bufferCountOutput, buffer);
        }
        public static delegate* unmanaged<XrEyeTrackerFB, XrEyeGazesInfoFB*, XrEyeGazesFB*, XrResult> _xrGetEyeGazesFB_fnptr = &xrGetEyeGazesFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetEyeGazesFB_Lazy(XrEyeTrackerFB eyeTracker, XrEyeGazesInfoFB* gazeInfo, XrEyeGazesFB* eyeGazes)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetEyeGazesFB", out IntPtr temp);
            _xrGetEyeGazesFB_fnptr = (delegate* unmanaged<XrEyeTrackerFB, XrEyeGazesInfoFB*, XrEyeGazesFB*, XrResult>)temp;
            return _xrGetEyeGazesFB_fnptr(eyeTracker, gazeInfo, eyeGazes);
        }
        public static delegate* unmanaged<XrFaceTracker2FB, XrFaceExpressionInfo2FB*, XrFaceExpressionWeights2FB*, XrResult> _xrGetFaceExpressionWeights2FB_fnptr = &xrGetFaceExpressionWeights2FB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetFaceExpressionWeights2FB_Lazy(XrFaceTracker2FB faceTracker, XrFaceExpressionInfo2FB* expressionInfo, XrFaceExpressionWeights2FB* expressionWeights)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetFaceExpressionWeights2FB", out IntPtr temp);
            _xrGetFaceExpressionWeights2FB_fnptr = (delegate* unmanaged<XrFaceTracker2FB, XrFaceExpressionInfo2FB*, XrFaceExpressionWeights2FB*, XrResult>)temp;
            return _xrGetFaceExpressionWeights2FB_fnptr(faceTracker, expressionInfo, expressionWeights);
        }
        public static delegate* unmanaged<XrFaceTrackerFB, XrFaceExpressionInfoFB*, XrFaceExpressionWeightsFB*, XrResult> _xrGetFaceExpressionWeightsFB_fnptr = &xrGetFaceExpressionWeightsFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetFaceExpressionWeightsFB_Lazy(XrFaceTrackerFB faceTracker, XrFaceExpressionInfoFB* expressionInfo, XrFaceExpressionWeightsFB* expressionWeights)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetFaceExpressionWeightsFB", out IntPtr temp);
            _xrGetFaceExpressionWeightsFB_fnptr = (delegate* unmanaged<XrFaceTrackerFB, XrFaceExpressionInfoFB*, XrFaceExpressionWeightsFB*, XrResult>)temp;
            return _xrGetFaceExpressionWeightsFB_fnptr(faceTracker, expressionInfo, expressionWeights);
        }
        public static delegate* unmanaged<XrFacialExpressionClientML, XrFacialExpressionBlendShapeGetInfoML*, uint, XrFacialExpressionBlendShapePropertiesML*, XrResult> _xrGetFacialExpressionBlendShapePropertiesML_fnptr = &xrGetFacialExpressionBlendShapePropertiesML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetFacialExpressionBlendShapePropertiesML_Lazy(XrFacialExpressionClientML facialExpressionClient, XrFacialExpressionBlendShapeGetInfoML* blendShapeGetInfo, uint blendShapeCount, XrFacialExpressionBlendShapePropertiesML* blendShapes)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetFacialExpressionBlendShapePropertiesML", out IntPtr temp);
            _xrGetFacialExpressionBlendShapePropertiesML_fnptr = (delegate* unmanaged<XrFacialExpressionClientML, XrFacialExpressionBlendShapeGetInfoML*, uint, XrFacialExpressionBlendShapePropertiesML*, XrResult>)temp;
            return _xrGetFacialExpressionBlendShapePropertiesML_fnptr(facialExpressionClient, blendShapeGetInfo, blendShapeCount, blendShapes);
        }
        public static delegate* unmanaged<XrFacialTrackerHTC, XrFacialExpressionsHTC*, XrResult> _xrGetFacialExpressionsHTC_fnptr = &xrGetFacialExpressionsHTC_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetFacialExpressionsHTC_Lazy(XrFacialTrackerHTC facialTracker, XrFacialExpressionsHTC* facialExpressions)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetFacialExpressionsHTC", out IntPtr temp);
            _xrGetFacialExpressionsHTC_fnptr = (delegate* unmanaged<XrFacialTrackerHTC, XrFacialExpressionsHTC*, XrResult>)temp;
            return _xrGetFacialExpressionsHTC_fnptr(facialTracker, facialExpressions);
        }
        public static delegate* unmanaged<XrSession, XrFoveationEyeTrackedStateMETA*, XrResult> _xrGetFoveationEyeTrackedStateMETA_fnptr = &xrGetFoveationEyeTrackedStateMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetFoveationEyeTrackedStateMETA_Lazy(XrSession session, XrFoveationEyeTrackedStateMETA* foveationState)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetFoveationEyeTrackedStateMETA", out IntPtr temp);
            _xrGetFoveationEyeTrackedStateMETA_fnptr = (delegate* unmanaged<XrSession, XrFoveationEyeTrackedStateMETA*, XrResult>)temp;
            return _xrGetFoveationEyeTrackedStateMETA_fnptr(session, foveationState);
        }
        public static delegate* unmanaged<XrHandTrackerEXT, XrHandTrackingMeshFB*, XrResult> _xrGetHandMeshFB_fnptr = &xrGetHandMeshFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetHandMeshFB_Lazy(XrHandTrackerEXT handTracker, XrHandTrackingMeshFB* mesh)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetHandMeshFB", out IntPtr temp);
            _xrGetHandMeshFB_fnptr = (delegate* unmanaged<XrHandTrackerEXT, XrHandTrackingMeshFB*, XrResult>)temp;
            return _xrGetHandMeshFB_fnptr(handTracker, mesh);
        }
        public static delegate* unmanaged<XrSession, XrInputSourceLocalizedNameGetInfo*, uint, uint*, byte*, XrResult> _xrGetInputSourceLocalizedName_fnptr = &xrGetInputSourceLocalizedName_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetInputSourceLocalizedName_Lazy(XrSession session, XrInputSourceLocalizedNameGetInfo* getInfo, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetInputSourceLocalizedName", out IntPtr temp);
            _xrGetInputSourceLocalizedName_fnptr = (delegate* unmanaged<XrSession, XrInputSourceLocalizedNameGetInfo*, uint, uint*, byte*, XrResult>)temp;
            return _xrGetInputSourceLocalizedName_fnptr(session, getInfo, bufferCapacityInput, bufferCountOutput, buffer);
        }
        public static delegate* unmanaged<XrInstance, byte*, delegate* unmanaged[Cdecl]<void>*, XrResult> _xrGetInstanceProcAddr_fnptr = &xrGetInstanceProcAddr_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetInstanceProcAddr_Lazy(XrInstance instance, byte* name, delegate* unmanaged[Cdecl]<void>* function)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetInstanceProcAddr", out IntPtr temp);
            _xrGetInstanceProcAddr_fnptr = (delegate* unmanaged<XrInstance, byte*, delegate* unmanaged[Cdecl]<void>*, XrResult>)temp;
            return _xrGetInstanceProcAddr_fnptr(instance, name, function);
        }
        public static delegate* unmanaged<XrInstance, XrInstanceProperties*, XrResult> _xrGetInstanceProperties_fnptr = &xrGetInstanceProperties_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetInstanceProperties_Lazy(XrInstance instance, XrInstanceProperties* instanceProperties)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetInstanceProperties", out IntPtr temp);
            _xrGetInstanceProperties_fnptr = (delegate* unmanaged<XrInstance, XrInstanceProperties*, XrResult>)temp;
            return _xrGetInstanceProperties_fnptr(instance, instanceProperties);
        }
        public static delegate* unmanaged<XrMarkerDetectorML, XrMarkerDetectorStateML*, XrResult> _xrGetMarkerDetectorStateML_fnptr = &xrGetMarkerDetectorStateML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetMarkerDetectorStateML_Lazy(XrMarkerDetectorML markerDetector, XrMarkerDetectorStateML* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetMarkerDetectorStateML", out IntPtr temp);
            _xrGetMarkerDetectorStateML_fnptr = (delegate* unmanaged<XrMarkerDetectorML, XrMarkerDetectorStateML*, XrResult>)temp;
            return _xrGetMarkerDetectorStateML_fnptr(markerDetector, state);
        }
        public static delegate* unmanaged<XrMarkerDetectorML, ulong, float*, XrResult> _xrGetMarkerLengthML_fnptr = &xrGetMarkerLengthML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetMarkerLengthML_Lazy(XrMarkerDetectorML markerDetector, ulong marker, float* meters)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetMarkerLengthML", out IntPtr temp);
            _xrGetMarkerLengthML_fnptr = (delegate* unmanaged<XrMarkerDetectorML, ulong, float*, XrResult>)temp;
            return _xrGetMarkerLengthML_fnptr(markerDetector, marker, meters);
        }
        public static delegate* unmanaged<XrMarkerDetectorML, ulong, ulong*, XrResult> _xrGetMarkerNumberML_fnptr = &xrGetMarkerNumberML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetMarkerNumberML_Lazy(XrMarkerDetectorML markerDetector, ulong marker, ulong* number)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetMarkerNumberML", out IntPtr temp);
            _xrGetMarkerNumberML_fnptr = (delegate* unmanaged<XrMarkerDetectorML, ulong, ulong*, XrResult>)temp;
            return _xrGetMarkerNumberML_fnptr(markerDetector, marker, number);
        }
        public static delegate* unmanaged<XrMarkerDetectorML, ulong, float*, XrResult> _xrGetMarkerReprojectionErrorML_fnptr = &xrGetMarkerReprojectionErrorML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetMarkerReprojectionErrorML_Lazy(XrMarkerDetectorML markerDetector, ulong marker, float* reprojectionErrorMeters)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetMarkerReprojectionErrorML", out IntPtr temp);
            _xrGetMarkerReprojectionErrorML_fnptr = (delegate* unmanaged<XrMarkerDetectorML, ulong, float*, XrResult>)temp;
            return _xrGetMarkerReprojectionErrorML_fnptr(markerDetector, marker, reprojectionErrorMeters);
        }
        public static delegate* unmanaged<XrSession, ulong, XrExtent2Df*, XrResult> _xrGetMarkerSizeVARJO_fnptr = &xrGetMarkerSizeVARJO_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetMarkerSizeVARJO_Lazy(XrSession session, ulong markerId, XrExtent2Df* size)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetMarkerSizeVARJO", out IntPtr temp);
            _xrGetMarkerSizeVARJO_fnptr = (delegate* unmanaged<XrSession, ulong, XrExtent2Df*, XrResult>)temp;
            return _xrGetMarkerSizeVARJO_fnptr(session, markerId, size);
        }
        public static delegate* unmanaged<XrMarkerDetectorML, uint, uint*, ulong*, XrResult> _xrGetMarkersML_fnptr = &xrGetMarkersML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetMarkersML_Lazy(XrMarkerDetectorML markerDetector, uint markerCapacityInput, uint* markerCountOutput, ulong* markers)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetMarkersML", out IntPtr temp);
            _xrGetMarkersML_fnptr = (delegate* unmanaged<XrMarkerDetectorML, uint, uint*, ulong*, XrResult>)temp;
            return _xrGetMarkersML_fnptr(markerDetector, markerCapacityInput, markerCountOutput, markers);
        }
        public static delegate* unmanaged<XrMarkerDetectorML, ulong, uint, uint*, byte*, XrResult> _xrGetMarkerStringML_fnptr = &xrGetMarkerStringML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetMarkerStringML_Lazy(XrMarkerDetectorML markerDetector, ulong marker, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetMarkerStringML", out IntPtr temp);
            _xrGetMarkerStringML_fnptr = (delegate* unmanaged<XrMarkerDetectorML, ulong, uint, uint*, byte*, XrResult>)temp;
            return _xrGetMarkerStringML_fnptr(markerDetector, marker, bufferCapacityInput, bufferCountOutput, buffer);
        }
        public static delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsMetalKHR*, XrResult> _xrGetMetalGraphicsRequirementsKHR_fnptr = &xrGetMetalGraphicsRequirementsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetMetalGraphicsRequirementsKHR_Lazy(XrInstance instance, ulong systemId, XrGraphicsRequirementsMetalKHR* graphicsRequirements)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetMetalGraphicsRequirementsKHR", out IntPtr temp);
            _xrGetMetalGraphicsRequirementsKHR_fnptr = (delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsMetalKHR*, XrResult>)temp;
            return _xrGetMetalGraphicsRequirementsKHR_fnptr(instance, systemId, graphicsRequirements);
        }
        public static delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsOpenGLESKHR*, XrResult> _xrGetOpenGLESGraphicsRequirementsKHR_fnptr = &xrGetOpenGLESGraphicsRequirementsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetOpenGLESGraphicsRequirementsKHR_Lazy(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLESKHR* graphicsRequirements)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetOpenGLESGraphicsRequirementsKHR", out IntPtr temp);
            _xrGetOpenGLESGraphicsRequirementsKHR_fnptr = (delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsOpenGLESKHR*, XrResult>)temp;
            return _xrGetOpenGLESGraphicsRequirementsKHR_fnptr(instance, systemId, graphicsRequirements);
        }
        public static delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsOpenGLKHR*, XrResult> _xrGetOpenGLGraphicsRequirementsKHR_fnptr = &xrGetOpenGLGraphicsRequirementsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetOpenGLGraphicsRequirementsKHR_Lazy(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLKHR* graphicsRequirements)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetOpenGLGraphicsRequirementsKHR", out IntPtr temp);
            _xrGetOpenGLGraphicsRequirementsKHR_fnptr = (delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsOpenGLKHR*, XrResult>)temp;
            return _xrGetOpenGLGraphicsRequirementsKHR_fnptr(instance, systemId, graphicsRequirements);
        }
        public static delegate* unmanaged<XrSession, XrPassthroughPreferencesMETA*, XrResult> _xrGetPassthroughPreferencesMETA_fnptr = &xrGetPassthroughPreferencesMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetPassthroughPreferencesMETA_Lazy(XrSession session, XrPassthroughPreferencesMETA* preferences)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetPassthroughPreferencesMETA", out IntPtr temp);
            _xrGetPassthroughPreferencesMETA_fnptr = (delegate* unmanaged<XrSession, XrPassthroughPreferencesMETA*, XrResult>)temp;
            return _xrGetPassthroughPreferencesMETA_fnptr(session, preferences);
        }
        public static delegate* unmanaged<XrSession, XrPerformanceMetricsStateMETA*, XrResult> _xrGetPerformanceMetricsStateMETA_fnptr = &xrGetPerformanceMetricsStateMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetPerformanceMetricsStateMETA_Lazy(XrSession session, XrPerformanceMetricsStateMETA* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetPerformanceMetricsStateMETA", out IntPtr temp);
            _xrGetPerformanceMetricsStateMETA_fnptr = (delegate* unmanaged<XrSession, XrPerformanceMetricsStateMETA*, XrResult>)temp;
            return _xrGetPerformanceMetricsStateMETA_fnptr(session, state);
        }
        public static delegate* unmanaged<XrPlaneDetectorEXT, XrPlaneDetectorGetInfoEXT*, XrPlaneDetectorLocationsEXT*, XrResult> _xrGetPlaneDetectionsEXT_fnptr = &xrGetPlaneDetectionsEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetPlaneDetectionsEXT_Lazy(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorGetInfoEXT* info, XrPlaneDetectorLocationsEXT* locations)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetPlaneDetectionsEXT", out IntPtr temp);
            _xrGetPlaneDetectionsEXT_fnptr = (delegate* unmanaged<XrPlaneDetectorEXT, XrPlaneDetectorGetInfoEXT*, XrPlaneDetectorLocationsEXT*, XrResult>)temp;
            return _xrGetPlaneDetectionsEXT_fnptr(planeDetector, info, locations);
        }
        public static delegate* unmanaged<XrPlaneDetectorEXT, XrPlaneDetectionStateEXT*, XrResult> _xrGetPlaneDetectionStateEXT_fnptr = &xrGetPlaneDetectionStateEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetPlaneDetectionStateEXT_Lazy(XrPlaneDetectorEXT planeDetector, XrPlaneDetectionStateEXT* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetPlaneDetectionStateEXT", out IntPtr temp);
            _xrGetPlaneDetectionStateEXT_fnptr = (delegate* unmanaged<XrPlaneDetectorEXT, XrPlaneDetectionStateEXT*, XrResult>)temp;
            return _xrGetPlaneDetectionStateEXT_fnptr(planeDetector, state);
        }
        public static delegate* unmanaged<XrPlaneDetectorEXT, ulong, uint, XrPlaneDetectorPolygonBufferEXT*, XrResult> _xrGetPlanePolygonBufferEXT_fnptr = &xrGetPlanePolygonBufferEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetPlanePolygonBufferEXT_Lazy(XrPlaneDetectorEXT planeDetector, ulong planeId, uint polygonBufferIndex, XrPlaneDetectorPolygonBufferEXT* polygonBuffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetPlanePolygonBufferEXT", out IntPtr temp);
            _xrGetPlanePolygonBufferEXT_fnptr = (delegate* unmanaged<XrPlaneDetectorEXT, ulong, uint, XrPlaneDetectorPolygonBufferEXT*, XrResult>)temp;
            return _xrGetPlanePolygonBufferEXT_fnptr(planeDetector, planeId, polygonBufferIndex, polygonBuffer);
        }
        public static delegate* unmanaged<XrSession, XrRecommendedLayerResolutionGetInfoMETA*, XrRecommendedLayerResolutionMETA*, XrResult> _xrGetRecommendedLayerResolutionMETA_fnptr = &xrGetRecommendedLayerResolutionMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetRecommendedLayerResolutionMETA_Lazy(XrSession session, XrRecommendedLayerResolutionGetInfoMETA* info, XrRecommendedLayerResolutionMETA* resolution)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetRecommendedLayerResolutionMETA", out IntPtr temp);
            _xrGetRecommendedLayerResolutionMETA_fnptr = (delegate* unmanaged<XrSession, XrRecommendedLayerResolutionGetInfoMETA*, XrRecommendedLayerResolutionMETA*, XrResult>)temp;
            return _xrGetRecommendedLayerResolutionMETA_fnptr(session, info, resolution);
        }
        public static delegate* unmanaged<XrSession, XrReferenceSpaceType, XrExtent2Df*, XrResult> _xrGetReferenceSpaceBoundsRect_fnptr = &xrGetReferenceSpaceBoundsRect_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetReferenceSpaceBoundsRect_Lazy(XrSession session, XrReferenceSpaceType referenceSpaceType, XrExtent2Df* bounds)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetReferenceSpaceBoundsRect", out IntPtr temp);
            _xrGetReferenceSpaceBoundsRect_fnptr = (delegate* unmanaged<XrSession, XrReferenceSpaceType, XrExtent2Df*, XrResult>)temp;
            return _xrGetReferenceSpaceBoundsRect_fnptr(session, referenceSpaceType, bounds);
        }
        public static delegate* unmanaged<XrSession, ulong, XrRenderModelPropertiesFB*, XrResult> _xrGetRenderModelPropertiesFB_fnptr = &xrGetRenderModelPropertiesFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetRenderModelPropertiesFB_Lazy(XrSession session, ulong path, XrRenderModelPropertiesFB* properties)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetRenderModelPropertiesFB", out IntPtr temp);
            _xrGetRenderModelPropertiesFB_fnptr = (delegate* unmanaged<XrSession, ulong, XrRenderModelPropertiesFB*, XrResult>)temp;
            return _xrGetRenderModelPropertiesFB_fnptr(session, path, properties);
        }
        public static delegate* unmanaged<XrSceneMSFT, XrSceneComponentsGetInfoMSFT*, XrSceneComponentsMSFT*, XrResult> _xrGetSceneComponentsMSFT_fnptr = &xrGetSceneComponentsMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSceneComponentsMSFT_Lazy(XrSceneMSFT scene, XrSceneComponentsGetInfoMSFT* getInfo, XrSceneComponentsMSFT* components)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSceneComponentsMSFT", out IntPtr temp);
            _xrGetSceneComponentsMSFT_fnptr = (delegate* unmanaged<XrSceneMSFT, XrSceneComponentsGetInfoMSFT*, XrSceneComponentsMSFT*, XrResult>)temp;
            return _xrGetSceneComponentsMSFT_fnptr(scene, getInfo, components);
        }
        public static delegate* unmanaged<XrSceneObserverMSFT, XrSceneComputeStateMSFT*, XrResult> _xrGetSceneComputeStateMSFT_fnptr = &xrGetSceneComputeStateMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSceneComputeStateMSFT_Lazy(XrSceneObserverMSFT sceneObserver, XrSceneComputeStateMSFT* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSceneComputeStateMSFT", out IntPtr temp);
            _xrGetSceneComputeStateMSFT_fnptr = (delegate* unmanaged<XrSceneObserverMSFT, XrSceneComputeStateMSFT*, XrResult>)temp;
            return _xrGetSceneComputeStateMSFT_fnptr(sceneObserver, state);
        }
        public static delegate* unmanaged<XrSceneMSFT, XrUuidMSFT*, uint, uint*, byte*, XrResult> _xrGetSceneMarkerDecodedStringMSFT_fnptr = &xrGetSceneMarkerDecodedStringMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSceneMarkerDecodedStringMSFT_Lazy(XrSceneMSFT scene, XrUuidMSFT* markerId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSceneMarkerDecodedStringMSFT", out IntPtr temp);
            _xrGetSceneMarkerDecodedStringMSFT_fnptr = (delegate* unmanaged<XrSceneMSFT, XrUuidMSFT*, uint, uint*, byte*, XrResult>)temp;
            return _xrGetSceneMarkerDecodedStringMSFT_fnptr(scene, markerId, bufferCapacityInput, bufferCountOutput, buffer);
        }
        public static delegate* unmanaged<XrSceneMSFT, XrUuidMSFT*, uint, uint*, byte*, XrResult> _xrGetSceneMarkerRawDataMSFT_fnptr = &xrGetSceneMarkerRawDataMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSceneMarkerRawDataMSFT_Lazy(XrSceneMSFT scene, XrUuidMSFT* markerId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSceneMarkerRawDataMSFT", out IntPtr temp);
            _xrGetSceneMarkerRawDataMSFT_fnptr = (delegate* unmanaged<XrSceneMSFT, XrUuidMSFT*, uint, uint*, byte*, XrResult>)temp;
            return _xrGetSceneMarkerRawDataMSFT_fnptr(scene, markerId, bufferCapacityInput, bufferCountOutput, buffer);
        }
        public static delegate* unmanaged<XrSceneMSFT, XrSceneMeshBuffersGetInfoMSFT*, XrSceneMeshBuffersMSFT*, XrResult> _xrGetSceneMeshBuffersMSFT_fnptr = &xrGetSceneMeshBuffersMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSceneMeshBuffersMSFT_Lazy(XrSceneMSFT scene, XrSceneMeshBuffersGetInfoMSFT* getInfo, XrSceneMeshBuffersMSFT* buffers)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSceneMeshBuffersMSFT", out IntPtr temp);
            _xrGetSceneMeshBuffersMSFT_fnptr = (delegate* unmanaged<XrSceneMSFT, XrSceneMeshBuffersGetInfoMSFT*, XrSceneMeshBuffersMSFT*, XrResult>)temp;
            return _xrGetSceneMeshBuffersMSFT_fnptr(scene, getInfo, buffers);
        }
        public static delegate* unmanaged<XrSceneMSFT, XrSerializedSceneFragmentDataGetInfoMSFT*, uint, uint*, byte*, XrResult> _xrGetSerializedSceneFragmentDataMSFT_fnptr = &xrGetSerializedSceneFragmentDataMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSerializedSceneFragmentDataMSFT_Lazy(XrSceneMSFT scene, XrSerializedSceneFragmentDataGetInfoMSFT* getInfo, uint countInput, uint* readOutput, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSerializedSceneFragmentDataMSFT", out IntPtr temp);
            _xrGetSerializedSceneFragmentDataMSFT_fnptr = (delegate* unmanaged<XrSceneMSFT, XrSerializedSceneFragmentDataGetInfoMSFT*, uint, uint*, byte*, XrResult>)temp;
            return _xrGetSerializedSceneFragmentDataMSFT_fnptr(scene, getInfo, countInput, readOutput, buffer);
        }
        public static delegate* unmanaged<XrSession, XrSpace, XrBoundary2DFB*, XrResult> _xrGetSpaceBoundary2DFB_fnptr = &xrGetSpaceBoundary2DFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpaceBoundary2DFB_Lazy(XrSession session, XrSpace space, XrBoundary2DFB* boundary2DOutput)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpaceBoundary2DFB", out IntPtr temp);
            _xrGetSpaceBoundary2DFB_fnptr = (delegate* unmanaged<XrSession, XrSpace, XrBoundary2DFB*, XrResult>)temp;
            return _xrGetSpaceBoundary2DFB_fnptr(session, space, boundary2DOutput);
        }
        public static delegate* unmanaged<XrSession, XrSpace, XrRect2Df*, XrResult> _xrGetSpaceBoundingBox2DFB_fnptr = &xrGetSpaceBoundingBox2DFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpaceBoundingBox2DFB_Lazy(XrSession session, XrSpace space, XrRect2Df* boundingBox2DOutput)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpaceBoundingBox2DFB", out IntPtr temp);
            _xrGetSpaceBoundingBox2DFB_fnptr = (delegate* unmanaged<XrSession, XrSpace, XrRect2Df*, XrResult>)temp;
            return _xrGetSpaceBoundingBox2DFB_fnptr(session, space, boundingBox2DOutput);
        }
        public static delegate* unmanaged<XrSession, XrSpace, XrRect3DfFB*, XrResult> _xrGetSpaceBoundingBox3DFB_fnptr = &xrGetSpaceBoundingBox3DFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpaceBoundingBox3DFB_Lazy(XrSession session, XrSpace space, XrRect3DfFB* boundingBox3DOutput)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpaceBoundingBox3DFB", out IntPtr temp);
            _xrGetSpaceBoundingBox3DFB_fnptr = (delegate* unmanaged<XrSession, XrSpace, XrRect3DfFB*, XrResult>)temp;
            return _xrGetSpaceBoundingBox3DFB_fnptr(session, space, boundingBox3DOutput);
        }
        public static delegate* unmanaged<XrSpace, XrSpaceComponentTypeFB, XrSpaceComponentStatusFB*, XrResult> _xrGetSpaceComponentStatusFB_fnptr = &xrGetSpaceComponentStatusFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpaceComponentStatusFB_Lazy(XrSpace space, XrSpaceComponentTypeFB componentType, XrSpaceComponentStatusFB* status)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpaceComponentStatusFB", out IntPtr temp);
            _xrGetSpaceComponentStatusFB_fnptr = (delegate* unmanaged<XrSpace, XrSpaceComponentTypeFB, XrSpaceComponentStatusFB*, XrResult>)temp;
            return _xrGetSpaceComponentStatusFB_fnptr(space, componentType, status);
        }
        public static delegate* unmanaged<XrSession, XrSpace, XrSpaceContainerFB*, XrResult> _xrGetSpaceContainerFB_fnptr = &xrGetSpaceContainerFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpaceContainerFB_Lazy(XrSession session, XrSpace space, XrSpaceContainerFB* spaceContainerOutput)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpaceContainerFB", out IntPtr temp);
            _xrGetSpaceContainerFB_fnptr = (delegate* unmanaged<XrSession, XrSpace, XrSpaceContainerFB*, XrResult>)temp;
            return _xrGetSpaceContainerFB_fnptr(session, space, spaceContainerOutput);
        }
        public static delegate* unmanaged<XrSession, XrSpace, XrRoomLayoutFB*, XrResult> _xrGetSpaceRoomLayoutFB_fnptr = &xrGetSpaceRoomLayoutFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpaceRoomLayoutFB_Lazy(XrSession session, XrSpace space, XrRoomLayoutFB* roomLayoutOutput)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpaceRoomLayoutFB", out IntPtr temp);
            _xrGetSpaceRoomLayoutFB_fnptr = (delegate* unmanaged<XrSession, XrSpace, XrRoomLayoutFB*, XrResult>)temp;
            return _xrGetSpaceRoomLayoutFB_fnptr(session, space, roomLayoutOutput);
        }
        public static delegate* unmanaged<XrSession, XrSpace, XrSemanticLabelsFB*, XrResult> _xrGetSpaceSemanticLabelsFB_fnptr = &xrGetSpaceSemanticLabelsFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpaceSemanticLabelsFB_Lazy(XrSession session, XrSpace space, XrSemanticLabelsFB* semanticLabelsOutput)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpaceSemanticLabelsFB", out IntPtr temp);
            _xrGetSpaceSemanticLabelsFB_fnptr = (delegate* unmanaged<XrSession, XrSpace, XrSemanticLabelsFB*, XrResult>)temp;
            return _xrGetSpaceSemanticLabelsFB_fnptr(session, space, semanticLabelsOutput);
        }
        public static delegate* unmanaged<XrSpace, XrSpaceTriangleMeshGetInfoMETA*, XrSpaceTriangleMeshMETA*, XrResult> _xrGetSpaceTriangleMeshMETA_fnptr = &xrGetSpaceTriangleMeshMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpaceTriangleMeshMETA_Lazy(XrSpace space, XrSpaceTriangleMeshGetInfoMETA* getInfo, XrSpaceTriangleMeshMETA* triangleMeshOutput)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpaceTriangleMeshMETA", out IntPtr temp);
            _xrGetSpaceTriangleMeshMETA_fnptr = (delegate* unmanaged<XrSpace, XrSpaceTriangleMeshGetInfoMETA*, XrSpaceTriangleMeshMETA*, XrResult>)temp;
            return _xrGetSpaceTriangleMeshMETA_fnptr(space, getInfo, triangleMeshOutput);
        }
        public static delegate* unmanaged<XrSpaceUserFB, ulong*, XrResult> _xrGetSpaceUserIdFB_fnptr = &xrGetSpaceUserIdFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpaceUserIdFB_Lazy(XrSpaceUserFB user, ulong* userId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpaceUserIdFB", out IntPtr temp);
            _xrGetSpaceUserIdFB_fnptr = (delegate* unmanaged<XrSpaceUserFB, ulong*, XrResult>)temp;
            return _xrGetSpaceUserIdFB_fnptr(user, userId);
        }
        public static delegate* unmanaged<XrSpace, XrUuid*, XrResult> _xrGetSpaceUuidFB_fnptr = &xrGetSpaceUuidFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpaceUuidFB_Lazy(XrSpace space, XrUuid* uuid)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpaceUuidFB", out IntPtr temp);
            _xrGetSpaceUuidFB_fnptr = (delegate* unmanaged<XrSpace, XrUuid*, XrResult>)temp;
            return _xrGetSpaceUuidFB_fnptr(space, uuid);
        }
        public static delegate* unmanaged<XrSpace, XrSpatialAnchorNameHTC*, XrResult> _xrGetSpatialAnchorNameHTC_fnptr = &xrGetSpatialAnchorNameHTC_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpatialAnchorNameHTC_Lazy(XrSpace anchor, XrSpatialAnchorNameHTC* name)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpatialAnchorNameHTC", out IntPtr temp);
            _xrGetSpatialAnchorNameHTC_fnptr = (delegate* unmanaged<XrSpace, XrSpatialAnchorNameHTC*, XrResult>)temp;
            return _xrGetSpatialAnchorNameHTC_fnptr(anchor, name);
        }
        public static delegate* unmanaged<XrSpace, XrSpatialAnchorStateML*, XrResult> _xrGetSpatialAnchorStateML_fnptr = &xrGetSpatialAnchorStateML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpatialAnchorStateML_Lazy(XrSpace anchor, XrSpatialAnchorStateML* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpatialAnchorStateML", out IntPtr temp);
            _xrGetSpatialAnchorStateML_fnptr = (delegate* unmanaged<XrSpace, XrSpatialAnchorStateML*, XrResult>)temp;
            return _xrGetSpatialAnchorStateML_fnptr(anchor, state);
        }
        public static delegate* unmanaged<XrSpatialGraphNodeBindingMSFT, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT*, XrSpatialGraphNodeBindingPropertiesMSFT*, XrResult> _xrGetSpatialGraphNodeBindingPropertiesMSFT_fnptr = &xrGetSpatialGraphNodeBindingPropertiesMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSpatialGraphNodeBindingPropertiesMSFT_Lazy(XrSpatialGraphNodeBindingMSFT nodeBinding, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT* getInfo, XrSpatialGraphNodeBindingPropertiesMSFT* properties)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSpatialGraphNodeBindingPropertiesMSFT", out IntPtr temp);
            _xrGetSpatialGraphNodeBindingPropertiesMSFT_fnptr = (delegate* unmanaged<XrSpatialGraphNodeBindingMSFT, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT*, XrSpatialGraphNodeBindingPropertiesMSFT*, XrResult>)temp;
            return _xrGetSpatialGraphNodeBindingPropertiesMSFT_fnptr(nodeBinding, getInfo, properties);
        }
        public static delegate* unmanaged<XrSwapchain, XrSwapchainStateBaseHeaderFB*, XrResult> _xrGetSwapchainStateFB_fnptr = &xrGetSwapchainStateFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSwapchainStateFB_Lazy(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSwapchainStateFB", out IntPtr temp);
            _xrGetSwapchainStateFB_fnptr = (delegate* unmanaged<XrSwapchain, XrSwapchainStateBaseHeaderFB*, XrResult>)temp;
            return _xrGetSwapchainStateFB_fnptr(swapchain, state);
        }
        public static delegate* unmanaged<XrInstance, XrSystemGetInfo*, ulong*, XrResult> _xrGetSystem_fnptr = &xrGetSystem_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSystem_Lazy(XrInstance instance, XrSystemGetInfo* getInfo, ulong* systemId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSystem", out IntPtr temp);
            _xrGetSystem_fnptr = (delegate* unmanaged<XrInstance, XrSystemGetInfo*, ulong*, XrResult>)temp;
            return _xrGetSystem_fnptr(instance, getInfo, systemId);
        }
        public static delegate* unmanaged<XrInstance, ulong, XrSystemProperties*, XrResult> _xrGetSystemProperties_fnptr = &xrGetSystemProperties_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetSystemProperties_Lazy(XrInstance instance, ulong systemId, XrSystemProperties* properties)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetSystemProperties", out IntPtr temp);
            _xrGetSystemProperties_fnptr = (delegate* unmanaged<XrInstance, ulong, XrSystemProperties*, XrResult>)temp;
            return _xrGetSystemProperties_fnptr(instance, systemId, properties);
        }
        public static delegate* unmanaged<XrInstance, ulong, XrViewConfigurationType, XrViewConfigurationProperties*, XrResult> _xrGetViewConfigurationProperties_fnptr = &xrGetViewConfigurationProperties_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetViewConfigurationProperties_Lazy(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, XrViewConfigurationProperties* configurationProperties)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetViewConfigurationProperties", out IntPtr temp);
            _xrGetViewConfigurationProperties_fnptr = (delegate* unmanaged<XrInstance, ulong, XrViewConfigurationType, XrViewConfigurationProperties*, XrResult>)temp;
            return _xrGetViewConfigurationProperties_fnptr(instance, systemId, viewConfigurationType, configurationProperties);
        }
        public static delegate* unmanaged<XrVirtualKeyboardMETA, uint, uint*, ulong*, XrResult> _xrGetVirtualKeyboardDirtyTexturesMETA_fnptr = &xrGetVirtualKeyboardDirtyTexturesMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetVirtualKeyboardDirtyTexturesMETA_Lazy(XrVirtualKeyboardMETA keyboard, uint textureIdCapacityInput, uint* textureIdCountOutput, ulong* textureIds)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetVirtualKeyboardDirtyTexturesMETA", out IntPtr temp);
            _xrGetVirtualKeyboardDirtyTexturesMETA_fnptr = (delegate* unmanaged<XrVirtualKeyboardMETA, uint, uint*, ulong*, XrResult>)temp;
            return _xrGetVirtualKeyboardDirtyTexturesMETA_fnptr(keyboard, textureIdCapacityInput, textureIdCountOutput, textureIds);
        }
        public static delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardModelAnimationStatesMETA*, XrResult> _xrGetVirtualKeyboardModelAnimationStatesMETA_fnptr = &xrGetVirtualKeyboardModelAnimationStatesMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetVirtualKeyboardModelAnimationStatesMETA_Lazy(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelAnimationStatesMETA* animationStates)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetVirtualKeyboardModelAnimationStatesMETA", out IntPtr temp);
            _xrGetVirtualKeyboardModelAnimationStatesMETA_fnptr = (delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardModelAnimationStatesMETA*, XrResult>)temp;
            return _xrGetVirtualKeyboardModelAnimationStatesMETA_fnptr(keyboard, animationStates);
        }
        public static delegate* unmanaged<XrVirtualKeyboardMETA, float*, XrResult> _xrGetVirtualKeyboardScaleMETA_fnptr = &xrGetVirtualKeyboardScaleMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetVirtualKeyboardScaleMETA_Lazy(XrVirtualKeyboardMETA keyboard, float* scale)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetVirtualKeyboardScaleMETA", out IntPtr temp);
            _xrGetVirtualKeyboardScaleMETA_fnptr = (delegate* unmanaged<XrVirtualKeyboardMETA, float*, XrResult>)temp;
            return _xrGetVirtualKeyboardScaleMETA_fnptr(keyboard, scale);
        }
        public static delegate* unmanaged<XrVirtualKeyboardMETA, ulong, XrVirtualKeyboardTextureDataMETA*, XrResult> _xrGetVirtualKeyboardTextureDataMETA_fnptr = &xrGetVirtualKeyboardTextureDataMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetVirtualKeyboardTextureDataMETA_Lazy(XrVirtualKeyboardMETA keyboard, ulong textureId, XrVirtualKeyboardTextureDataMETA* textureData)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetVirtualKeyboardTextureDataMETA", out IntPtr temp);
            _xrGetVirtualKeyboardTextureDataMETA_fnptr = (delegate* unmanaged<XrVirtualKeyboardMETA, ulong, XrVirtualKeyboardTextureDataMETA*, XrResult>)temp;
            return _xrGetVirtualKeyboardTextureDataMETA_fnptr(keyboard, textureId, textureData);
        }
        public static delegate* unmanaged<XrSession, XrViewConfigurationType, uint, XrVisibilityMaskTypeKHR, XrVisibilityMaskKHR*, XrResult> _xrGetVisibilityMaskKHR_fnptr = &xrGetVisibilityMaskKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetVisibilityMaskKHR_Lazy(XrSession session, XrViewConfigurationType viewConfigurationType, uint viewIndex, XrVisibilityMaskTypeKHR visibilityMaskType, XrVisibilityMaskKHR* visibilityMask)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetVisibilityMaskKHR", out IntPtr temp);
            _xrGetVisibilityMaskKHR_fnptr = (delegate* unmanaged<XrSession, XrViewConfigurationType, uint, XrVisibilityMaskTypeKHR, XrVisibilityMaskKHR*, XrResult>)temp;
            return _xrGetVisibilityMaskKHR_fnptr(session, viewConfigurationType, viewIndex, visibilityMaskType, visibilityMask);
        }
        public static delegate* unmanaged<XrInstance, ulong, uint, uint*, byte*, XrResult> _xrGetVulkanDeviceExtensionsKHR_fnptr = &xrGetVulkanDeviceExtensionsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetVulkanDeviceExtensionsKHR_Lazy(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetVulkanDeviceExtensionsKHR", out IntPtr temp);
            _xrGetVulkanDeviceExtensionsKHR_fnptr = (delegate* unmanaged<XrInstance, ulong, uint, uint*, byte*, XrResult>)temp;
            return _xrGetVulkanDeviceExtensionsKHR_fnptr(instance, systemId, bufferCapacityInput, bufferCountOutput, buffer);
        }
        public static delegate* unmanaged<XrInstance, XrVulkanGraphicsDeviceGetInfoKHR*, VkPhysicalDevice*, XrResult> _xrGetVulkanGraphicsDevice2KHR_fnptr = &xrGetVulkanGraphicsDevice2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetVulkanGraphicsDevice2KHR_Lazy(XrInstance instance, XrVulkanGraphicsDeviceGetInfoKHR* getInfo, VkPhysicalDevice* vulkanPhysicalDevice)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetVulkanGraphicsDevice2KHR", out IntPtr temp);
            _xrGetVulkanGraphicsDevice2KHR_fnptr = (delegate* unmanaged<XrInstance, XrVulkanGraphicsDeviceGetInfoKHR*, VkPhysicalDevice*, XrResult>)temp;
            return _xrGetVulkanGraphicsDevice2KHR_fnptr(instance, getInfo, vulkanPhysicalDevice);
        }
        public static delegate* unmanaged<XrInstance, ulong, VkInstance, VkPhysicalDevice*, XrResult> _xrGetVulkanGraphicsDeviceKHR_fnptr = &xrGetVulkanGraphicsDeviceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetVulkanGraphicsDeviceKHR_Lazy(XrInstance instance, ulong systemId, VkInstance vkInstance, VkPhysicalDevice* vkPhysicalDevice)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetVulkanGraphicsDeviceKHR", out IntPtr temp);
            _xrGetVulkanGraphicsDeviceKHR_fnptr = (delegate* unmanaged<XrInstance, ulong, VkInstance, VkPhysicalDevice*, XrResult>)temp;
            return _xrGetVulkanGraphicsDeviceKHR_fnptr(instance, systemId, vkInstance, vkPhysicalDevice);
        }
        public static delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsVulkanKHR*, XrResult> _xrGetVulkanGraphicsRequirements2KHR_fnptr = &xrGetVulkanGraphicsRequirements2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetVulkanGraphicsRequirements2KHR_Lazy(XrInstance instance, ulong systemId, XrGraphicsRequirementsVulkanKHR* graphicsRequirements)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetVulkanGraphicsRequirements2KHR", out IntPtr temp);
            _xrGetVulkanGraphicsRequirements2KHR_fnptr = (delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsVulkanKHR*, XrResult>)temp;
            return _xrGetVulkanGraphicsRequirements2KHR_fnptr(instance, systemId, graphicsRequirements);
        }
        public static delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsVulkanKHR*, XrResult> _xrGetVulkanGraphicsRequirementsKHR_fnptr = &xrGetVulkanGraphicsRequirementsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetVulkanGraphicsRequirementsKHR_Lazy(XrInstance instance, ulong systemId, XrGraphicsRequirementsVulkanKHR* graphicsRequirements)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetVulkanGraphicsRequirementsKHR", out IntPtr temp);
            _xrGetVulkanGraphicsRequirementsKHR_fnptr = (delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsVulkanKHR*, XrResult>)temp;
            return _xrGetVulkanGraphicsRequirementsKHR_fnptr(instance, systemId, graphicsRequirements);
        }
        public static delegate* unmanaged<XrInstance, ulong, uint, uint*, byte*, XrResult> _xrGetVulkanInstanceExtensionsKHR_fnptr = &xrGetVulkanInstanceExtensionsKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetVulkanInstanceExtensionsKHR_Lazy(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetVulkanInstanceExtensionsKHR", out IntPtr temp);
            _xrGetVulkanInstanceExtensionsKHR_fnptr = (delegate* unmanaged<XrInstance, ulong, uint, uint*, byte*, XrResult>)temp;
            return _xrGetVulkanInstanceExtensionsKHR_fnptr(instance, systemId, bufferCapacityInput, bufferCountOutput, buffer);
        }
        public static delegate* unmanaged<XrWorldMeshDetectorML, XrWorldMeshBufferRecommendedSizeInfoML*, XrWorldMeshBufferSizeML*, XrResult> _xrGetWorldMeshBufferRecommendSizeML_fnptr = &xrGetWorldMeshBufferRecommendSizeML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrGetWorldMeshBufferRecommendSizeML_Lazy(XrWorldMeshDetectorML detector, XrWorldMeshBufferRecommendedSizeInfoML* sizeInfo, XrWorldMeshBufferSizeML* size)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrGetWorldMeshBufferRecommendSizeML", out IntPtr temp);
            _xrGetWorldMeshBufferRecommendSizeML_fnptr = (delegate* unmanaged<XrWorldMeshDetectorML, XrWorldMeshBufferRecommendedSizeInfoML*, XrWorldMeshBufferSizeML*, XrResult>)temp;
            return _xrGetWorldMeshBufferRecommendSizeML_fnptr(detector, sizeInfo, size);
        }
        public static delegate* unmanaged<XrSession, XrLocalizationMapImportInfoML*, XrUuid*, XrResult> _xrImportLocalizationMapML_fnptr = &xrImportLocalizationMapML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrImportLocalizationMapML_Lazy(XrSession session, XrLocalizationMapImportInfoML* importInfo, XrUuid* mapUuid)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrImportLocalizationMapML", out IntPtr temp);
            _xrImportLocalizationMapML_fnptr = (delegate* unmanaged<XrSession, XrLocalizationMapImportInfoML*, XrUuid*, XrResult>)temp;
            return _xrImportLocalizationMapML_fnptr(session, importInfo, mapUuid);
        }
        public static delegate* unmanaged<XrLoaderInitInfoBaseHeaderKHR*, XrResult> _xrInitializeLoaderKHR_fnptr = &xrInitializeLoaderKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrInitializeLoaderKHR_Lazy(XrLoaderInitInfoBaseHeaderKHR* loaderInitInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrInitializeLoaderKHR", out IntPtr temp);
            _xrInitializeLoaderKHR_fnptr = (delegate* unmanaged<XrLoaderInitInfoBaseHeaderKHR*, XrResult>)temp;
            return _xrInitializeLoaderKHR_fnptr(loaderInitInfo);
        }
        public static delegate* unmanaged<XrSession, ulong, uint, uint*, byte*, XrResult> _xrLoadControllerModelMSFT_fnptr = &xrLoadControllerModelMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrLoadControllerModelMSFT_Lazy(XrSession session, ulong modelKey, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrLoadControllerModelMSFT", out IntPtr temp);
            _xrLoadControllerModelMSFT_fnptr = (delegate* unmanaged<XrSession, ulong, uint, uint*, byte*, XrResult>)temp;
            return _xrLoadControllerModelMSFT_fnptr(session, modelKey, bufferCapacityInput, bufferCountOutput, buffer);
        }
        public static delegate* unmanaged<XrSession, XrRenderModelLoadInfoFB*, XrRenderModelBufferFB*, XrResult> _xrLoadRenderModelFB_fnptr = &xrLoadRenderModelFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrLoadRenderModelFB_Lazy(XrSession session, XrRenderModelLoadInfoFB* info, XrRenderModelBufferFB* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrLoadRenderModelFB", out IntPtr temp);
            _xrLoadRenderModelFB_fnptr = (delegate* unmanaged<XrSession, XrRenderModelLoadInfoFB*, XrRenderModelBufferFB*, XrResult>)temp;
            return _xrLoadRenderModelFB_fnptr(session, info, buffer);
        }
        public static delegate* unmanaged<XrBodyTrackerBD, XrBodyJointsLocateInfoBD*, XrBodyJointLocationsBD*, XrResult> _xrLocateBodyJointsBD_fnptr = &xrLocateBodyJointsBD_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrLocateBodyJointsBD_Lazy(XrBodyTrackerBD bodyTracker, XrBodyJointsLocateInfoBD* locateInfo, XrBodyJointLocationsBD* locations)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrLocateBodyJointsBD", out IntPtr temp);
            _xrLocateBodyJointsBD_fnptr = (delegate* unmanaged<XrBodyTrackerBD, XrBodyJointsLocateInfoBD*, XrBodyJointLocationsBD*, XrResult>)temp;
            return _xrLocateBodyJointsBD_fnptr(bodyTracker, locateInfo, locations);
        }
        public static delegate* unmanaged<XrBodyTrackerFB, XrBodyJointsLocateInfoFB*, XrBodyJointLocationsFB*, XrResult> _xrLocateBodyJointsFB_fnptr = &xrLocateBodyJointsFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrLocateBodyJointsFB_Lazy(XrBodyTrackerFB bodyTracker, XrBodyJointsLocateInfoFB* locateInfo, XrBodyJointLocationsFB* locations)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrLocateBodyJointsFB", out IntPtr temp);
            _xrLocateBodyJointsFB_fnptr = (delegate* unmanaged<XrBodyTrackerFB, XrBodyJointsLocateInfoFB*, XrBodyJointLocationsFB*, XrResult>)temp;
            return _xrLocateBodyJointsFB_fnptr(bodyTracker, locateInfo, locations);
        }
        public static delegate* unmanaged<XrBodyTrackerHTC, XrBodyJointsLocateInfoHTC*, XrBodyJointLocationsHTC*, XrResult> _xrLocateBodyJointsHTC_fnptr = &xrLocateBodyJointsHTC_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrLocateBodyJointsHTC_Lazy(XrBodyTrackerHTC bodyTracker, XrBodyJointsLocateInfoHTC* locateInfo, XrBodyJointLocationsHTC* locations)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrLocateBodyJointsHTC", out IntPtr temp);
            _xrLocateBodyJointsHTC_fnptr = (delegate* unmanaged<XrBodyTrackerHTC, XrBodyJointsLocateInfoHTC*, XrBodyJointLocationsHTC*, XrResult>)temp;
            return _xrLocateBodyJointsHTC_fnptr(bodyTracker, locateInfo, locations);
        }
        public static delegate* unmanaged<XrHandTrackerEXT, XrHandJointsLocateInfoEXT*, XrHandJointLocationsEXT*, XrResult> _xrLocateHandJointsEXT_fnptr = &xrLocateHandJointsEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrLocateHandJointsEXT_Lazy(XrHandTrackerEXT handTracker, XrHandJointsLocateInfoEXT* locateInfo, XrHandJointLocationsEXT* locations)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrLocateHandJointsEXT", out IntPtr temp);
            _xrLocateHandJointsEXT_fnptr = (delegate* unmanaged<XrHandTrackerEXT, XrHandJointsLocateInfoEXT*, XrHandJointLocationsEXT*, XrResult>)temp;
            return _xrLocateHandJointsEXT_fnptr(handTracker, locateInfo, locations);
        }
        public static delegate* unmanaged<XrSceneMSFT, XrSceneComponentsLocateInfoMSFT*, XrSceneComponentLocationsMSFT*, XrResult> _xrLocateSceneComponentsMSFT_fnptr = &xrLocateSceneComponentsMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrLocateSceneComponentsMSFT_Lazy(XrSceneMSFT scene, XrSceneComponentsLocateInfoMSFT* locateInfo, XrSceneComponentLocationsMSFT* locations)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrLocateSceneComponentsMSFT", out IntPtr temp);
            _xrLocateSceneComponentsMSFT_fnptr = (delegate* unmanaged<XrSceneMSFT, XrSceneComponentsLocateInfoMSFT*, XrSceneComponentLocationsMSFT*, XrResult>)temp;
            return _xrLocateSceneComponentsMSFT_fnptr(scene, locateInfo, locations);
        }
        public static delegate* unmanaged<XrSpace, XrSpace, long, XrSpaceLocation*, XrResult> _xrLocateSpace_fnptr = &xrLocateSpace_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrLocateSpace_Lazy(XrSpace space, XrSpace baseSpace, long time, XrSpaceLocation* location)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrLocateSpace", out IntPtr temp);
            _xrLocateSpace_fnptr = (delegate* unmanaged<XrSpace, XrSpace, long, XrSpaceLocation*, XrResult>)temp;
            return _xrLocateSpace_fnptr(space, baseSpace, time, location);
        }
        public static delegate* unmanaged<XrSession, XrSpacesLocateInfo*, XrSpaceLocations*, XrResult> _xrLocateSpaces_fnptr = &xrLocateSpaces_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrLocateSpaces_Lazy(XrSession session, XrSpacesLocateInfo* locateInfo, XrSpaceLocations* spaceLocations)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrLocateSpaces", out IntPtr temp);
            _xrLocateSpaces_fnptr = (delegate* unmanaged<XrSession, XrSpacesLocateInfo*, XrSpaceLocations*, XrResult>)temp;
            return _xrLocateSpaces_fnptr(session, locateInfo, spaceLocations);
        }
        public static delegate* unmanaged<XrSession, XrSpacesLocateInfo*, XrSpaceLocations*, XrResult> _xrLocateSpacesKHR_fnptr = &xrLocateSpacesKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrLocateSpacesKHR_Lazy(XrSession session, XrSpacesLocateInfo* locateInfo, XrSpaceLocations* spaceLocations)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrLocateSpacesKHR", out IntPtr temp);
            _xrLocateSpacesKHR_fnptr = (delegate* unmanaged<XrSession, XrSpacesLocateInfo*, XrSpaceLocations*, XrResult>)temp;
            return _xrLocateSpacesKHR_fnptr(session, locateInfo, spaceLocations);
        }
        public static delegate* unmanaged<XrSession, XrViewLocateInfo*, XrViewState*, uint, uint*, XrView*, XrResult> _xrLocateViews_fnptr = &xrLocateViews_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrLocateViews_Lazy(XrSession session, XrViewLocateInfo* viewLocateInfo, XrViewState* viewState, uint viewCapacityInput, uint* viewCountOutput, XrView* views)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrLocateViews", out IntPtr temp);
            _xrLocateViews_fnptr = (delegate* unmanaged<XrSession, XrViewLocateInfo*, XrViewState*, uint, uint*, XrView*, XrResult>)temp;
            return _xrLocateViews_fnptr(session, viewLocateInfo, viewState, viewCapacityInput, viewCountOutput, views);
        }
        public static delegate* unmanaged<XrNegotiateLoaderInfo*, byte*, XrNegotiateApiLayerRequest*, XrResult> _xrNegotiateLoaderApiLayerInterface_fnptr = &xrNegotiateLoaderApiLayerInterface_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrNegotiateLoaderApiLayerInterface_Lazy(XrNegotiateLoaderInfo* loaderInfo, byte* layerName, XrNegotiateApiLayerRequest* apiLayerRequest)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrNegotiateLoaderApiLayerInterface", out IntPtr temp);
            _xrNegotiateLoaderApiLayerInterface_fnptr = (delegate* unmanaged<XrNegotiateLoaderInfo*, byte*, XrNegotiateApiLayerRequest*, XrResult>)temp;
            return _xrNegotiateLoaderApiLayerInterface_fnptr(loaderInfo, layerName, apiLayerRequest);
        }
        public static delegate* unmanaged<XrNegotiateLoaderInfo*, XrNegotiateRuntimeRequest*, XrResult> _xrNegotiateLoaderRuntimeInterface_fnptr = &xrNegotiateLoaderRuntimeInterface_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrNegotiateLoaderRuntimeInterface_Lazy(XrNegotiateLoaderInfo* loaderInfo, XrNegotiateRuntimeRequest* runtimeRequest)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrNegotiateLoaderRuntimeInterface", out IntPtr temp);
            _xrNegotiateLoaderRuntimeInterface_fnptr = (delegate* unmanaged<XrNegotiateLoaderInfo*, XrNegotiateRuntimeRequest*, XrResult>)temp;
            return _xrNegotiateLoaderRuntimeInterface_fnptr(loaderInfo, runtimeRequest);
        }
        public static delegate* unmanaged<XrPassthroughLayerFB, XrResult> _xrPassthroughLayerPauseFB_fnptr = &xrPassthroughLayerPauseFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPassthroughLayerPauseFB_Lazy(XrPassthroughLayerFB layer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPassthroughLayerPauseFB", out IntPtr temp);
            _xrPassthroughLayerPauseFB_fnptr = (delegate* unmanaged<XrPassthroughLayerFB, XrResult>)temp;
            return _xrPassthroughLayerPauseFB_fnptr(layer);
        }
        public static delegate* unmanaged<XrPassthroughLayerFB, XrResult> _xrPassthroughLayerResumeFB_fnptr = &xrPassthroughLayerResumeFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPassthroughLayerResumeFB_Lazy(XrPassthroughLayerFB layer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPassthroughLayerResumeFB", out IntPtr temp);
            _xrPassthroughLayerResumeFB_fnptr = (delegate* unmanaged<XrPassthroughLayerFB, XrResult>)temp;
            return _xrPassthroughLayerResumeFB_fnptr(layer);
        }
        public static delegate* unmanaged<XrPassthroughLayerFB, XrPassthroughKeyboardHandsIntensityFB*, XrResult> _xrPassthroughLayerSetKeyboardHandsIntensityFB_fnptr = &xrPassthroughLayerSetKeyboardHandsIntensityFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPassthroughLayerSetKeyboardHandsIntensityFB_Lazy(XrPassthroughLayerFB layer, XrPassthroughKeyboardHandsIntensityFB* intensity)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPassthroughLayerSetKeyboardHandsIntensityFB", out IntPtr temp);
            _xrPassthroughLayerSetKeyboardHandsIntensityFB_fnptr = (delegate* unmanaged<XrPassthroughLayerFB, XrPassthroughKeyboardHandsIntensityFB*, XrResult>)temp;
            return _xrPassthroughLayerSetKeyboardHandsIntensityFB_fnptr(layer, intensity);
        }
        public static delegate* unmanaged<XrPassthroughLayerFB, XrPassthroughStyleFB*, XrResult> _xrPassthroughLayerSetStyleFB_fnptr = &xrPassthroughLayerSetStyleFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPassthroughLayerSetStyleFB_Lazy(XrPassthroughLayerFB layer, XrPassthroughStyleFB* style)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPassthroughLayerSetStyleFB", out IntPtr temp);
            _xrPassthroughLayerSetStyleFB_fnptr = (delegate* unmanaged<XrPassthroughLayerFB, XrPassthroughStyleFB*, XrResult>)temp;
            return _xrPassthroughLayerSetStyleFB_fnptr(layer, style);
        }
        public static delegate* unmanaged<XrPassthroughFB, XrResult> _xrPassthroughPauseFB_fnptr = &xrPassthroughPauseFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPassthroughPauseFB_Lazy(XrPassthroughFB passthrough)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPassthroughPauseFB", out IntPtr temp);
            _xrPassthroughPauseFB_fnptr = (delegate* unmanaged<XrPassthroughFB, XrResult>)temp;
            return _xrPassthroughPauseFB_fnptr(passthrough);
        }
        public static delegate* unmanaged<XrPassthroughFB, XrResult> _xrPassthroughStartFB_fnptr = &xrPassthroughStartFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPassthroughStartFB_Lazy(XrPassthroughFB passthrough)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPassthroughStartFB", out IntPtr temp);
            _xrPassthroughStartFB_fnptr = (delegate* unmanaged<XrPassthroughFB, XrResult>)temp;
            return _xrPassthroughStartFB_fnptr(passthrough);
        }
        public static delegate* unmanaged<XrInstance, ulong, uint, uint*, byte*, XrResult> _xrPathToString_fnptr = &xrPathToString_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPathToString_Lazy(XrInstance instance, ulong path, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPathToString", out IntPtr temp);
            _xrPathToString_fnptr = (delegate* unmanaged<XrInstance, ulong, uint, uint*, byte*, XrResult>)temp;
            return _xrPathToString_fnptr(instance, path, bufferCapacityInput, bufferCountOutput, buffer);
        }
        public static delegate* unmanaged<XrSession, XrPerfSettingsDomainEXT, XrPerfSettingsLevelEXT, XrResult> _xrPerfSettingsSetPerformanceLevelEXT_fnptr = &xrPerfSettingsSetPerformanceLevelEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPerfSettingsSetPerformanceLevelEXT_Lazy(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsLevelEXT level)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPerfSettingsSetPerformanceLevelEXT", out IntPtr temp);
            _xrPerfSettingsSetPerformanceLevelEXT_fnptr = (delegate* unmanaged<XrSession, XrPerfSettingsDomainEXT, XrPerfSettingsLevelEXT, XrResult>)temp;
            return _xrPerfSettingsSetPerformanceLevelEXT_fnptr(session, domain, level);
        }
        public static delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrSpatialAnchorPersistenceInfoMSFT*, XrResult> _xrPersistSpatialAnchorMSFT_fnptr = &xrPersistSpatialAnchorMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPersistSpatialAnchorMSFT_Lazy(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceInfoMSFT* spatialAnchorPersistenceInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPersistSpatialAnchorMSFT", out IntPtr temp);
            _xrPersistSpatialAnchorMSFT_fnptr = (delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrSpatialAnchorPersistenceInfoMSFT*, XrResult>)temp;
            return _xrPersistSpatialAnchorMSFT_fnptr(spatialAnchorStore, spatialAnchorPersistenceInfo);
        }
        public static delegate* unmanaged<XrInstance, XrEventDataBuffer*, XrResult> _xrPollEvent_fnptr = &xrPollEvent_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPollEvent_Lazy(XrInstance instance, XrEventDataBuffer* eventData)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPollEvent", out IntPtr temp);
            _xrPollEvent_fnptr = (delegate* unmanaged<XrInstance, XrEventDataBuffer*, XrResult>)temp;
            return _xrPollEvent_fnptr(instance, eventData);
        }
        public static delegate* unmanaged<XrInstance, XrFuturePollInfoEXT*, XrFuturePollResultEXT*, XrResult> _xrPollFutureEXT_fnptr = &xrPollFutureEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPollFutureEXT_Lazy(XrInstance instance, XrFuturePollInfoEXT* pollInfo, XrFuturePollResultEXT* pollResult)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPollFutureEXT", out IntPtr temp);
            _xrPollFutureEXT_fnptr = (delegate* unmanaged<XrInstance, XrFuturePollInfoEXT*, XrFuturePollResultEXT*, XrResult>)temp;
            return _xrPollFutureEXT_fnptr(instance, pollInfo, pollResult);
        }
        public static delegate* unmanaged<XrSpatialAnchorsStorageML, XrSpatialAnchorsPublishInfoML*, ulong*, XrResult> _xrPublishSpatialAnchorsAsyncML_fnptr = &xrPublishSpatialAnchorsAsyncML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPublishSpatialAnchorsAsyncML_Lazy(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsPublishInfoML* publishInfo, ulong* future)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPublishSpatialAnchorsAsyncML", out IntPtr temp);
            _xrPublishSpatialAnchorsAsyncML_fnptr = (delegate* unmanaged<XrSpatialAnchorsStorageML, XrSpatialAnchorsPublishInfoML*, ulong*, XrResult>)temp;
            return _xrPublishSpatialAnchorsAsyncML_fnptr(storage, publishInfo, future);
        }
        public static delegate* unmanaged<XrSpatialAnchorsStorageML, ulong, XrSpatialAnchorsPublishCompletionML*, XrResult> _xrPublishSpatialAnchorsCompleteML_fnptr = &xrPublishSpatialAnchorsCompleteML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrPublishSpatialAnchorsCompleteML_Lazy(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsPublishCompletionML* completion)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrPublishSpatialAnchorsCompleteML", out IntPtr temp);
            _xrPublishSpatialAnchorsCompleteML_fnptr = (delegate* unmanaged<XrSpatialAnchorsStorageML, ulong, XrSpatialAnchorsPublishCompletionML*, XrResult>)temp;
            return _xrPublishSpatialAnchorsCompleteML_fnptr(storage, future, completion);
        }
        public static delegate* unmanaged<XrSession, XrLocalizationMapQueryInfoBaseHeaderML*, uint, uint*, XrLocalizationMapML*, XrResult> _xrQueryLocalizationMapsML_fnptr = &xrQueryLocalizationMapsML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrQueryLocalizationMapsML_Lazy(XrSession session, XrLocalizationMapQueryInfoBaseHeaderML* queryInfo, uint mapCapacityInput, uint* mapCountOutput, XrLocalizationMapML* maps)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrQueryLocalizationMapsML", out IntPtr temp);
            _xrQueryLocalizationMapsML_fnptr = (delegate* unmanaged<XrSession, XrLocalizationMapQueryInfoBaseHeaderML*, uint, uint*, XrLocalizationMapML*, XrResult>)temp;
            return _xrQueryLocalizationMapsML_fnptr(session, queryInfo, mapCapacityInput, mapCountOutput, maps);
        }
        public static delegate* unmanaged<XrSession, ulong, XrPerformanceMetricsCounterMETA*, XrResult> _xrQueryPerformanceMetricsCounterMETA_fnptr = &xrQueryPerformanceMetricsCounterMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrQueryPerformanceMetricsCounterMETA_Lazy(XrSession session, ulong counterPath, XrPerformanceMetricsCounterMETA* counter)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrQueryPerformanceMetricsCounterMETA", out IntPtr temp);
            _xrQueryPerformanceMetricsCounterMETA_fnptr = (delegate* unmanaged<XrSession, ulong, XrPerformanceMetricsCounterMETA*, XrResult>)temp;
            return _xrQueryPerformanceMetricsCounterMETA_fnptr(session, counterPath, counter);
        }
        public static delegate* unmanaged<XrSession, XrSpaceQueryInfoBaseHeaderFB*, ulong*, XrResult> _xrQuerySpacesFB_fnptr = &xrQuerySpacesFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrQuerySpacesFB_Lazy(XrSession session, XrSpaceQueryInfoBaseHeaderFB* info, ulong* requestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrQuerySpacesFB", out IntPtr temp);
            _xrQuerySpacesFB_fnptr = (delegate* unmanaged<XrSession, XrSpaceQueryInfoBaseHeaderFB*, ulong*, XrResult>)temp;
            return _xrQuerySpacesFB_fnptr(session, info, requestId);
        }
        public static delegate* unmanaged<XrSpatialAnchorsStorageML, XrSpatialAnchorsQueryInfoBaseHeaderML*, ulong*, XrResult> _xrQuerySpatialAnchorsAsyncML_fnptr = &xrQuerySpatialAnchorsAsyncML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrQuerySpatialAnchorsAsyncML_Lazy(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsQueryInfoBaseHeaderML* queryInfo, ulong* future)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrQuerySpatialAnchorsAsyncML", out IntPtr temp);
            _xrQuerySpatialAnchorsAsyncML_fnptr = (delegate* unmanaged<XrSpatialAnchorsStorageML, XrSpatialAnchorsQueryInfoBaseHeaderML*, ulong*, XrResult>)temp;
            return _xrQuerySpatialAnchorsAsyncML_fnptr(storage, queryInfo, future);
        }
        public static delegate* unmanaged<XrSpatialAnchorsStorageML, ulong, XrSpatialAnchorsQueryCompletionML*, XrResult> _xrQuerySpatialAnchorsCompleteML_fnptr = &xrQuerySpatialAnchorsCompleteML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrQuerySpatialAnchorsCompleteML_Lazy(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsQueryCompletionML* completion)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrQuerySpatialAnchorsCompleteML", out IntPtr temp);
            _xrQuerySpatialAnchorsCompleteML_fnptr = (delegate* unmanaged<XrSpatialAnchorsStorageML, ulong, XrSpatialAnchorsQueryCompletionML*, XrResult>)temp;
            return _xrQuerySpatialAnchorsCompleteML_fnptr(storage, future, completion);
        }
        public static delegate* unmanaged<XrSession, XrKeyboardTrackingQueryFB*, XrKeyboardTrackingDescriptionFB*, XrResult> _xrQuerySystemTrackedKeyboardFB_fnptr = &xrQuerySystemTrackedKeyboardFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrQuerySystemTrackedKeyboardFB_Lazy(XrSession session, XrKeyboardTrackingQueryFB* queryInfo, XrKeyboardTrackingDescriptionFB* keyboard)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrQuerySystemTrackedKeyboardFB", out IntPtr temp);
            _xrQuerySystemTrackedKeyboardFB_fnptr = (delegate* unmanaged<XrSession, XrKeyboardTrackingQueryFB*, XrKeyboardTrackingDescriptionFB*, XrResult>)temp;
            return _xrQuerySystemTrackedKeyboardFB_fnptr(session, queryInfo, keyboard);
        }
        public static delegate* unmanaged<XrSwapchain, XrSwapchainImageReleaseInfo*, XrResult> _xrReleaseSwapchainImage_fnptr = &xrReleaseSwapchainImage_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrReleaseSwapchainImage_Lazy(XrSwapchain swapchain, XrSwapchainImageReleaseInfo* releaseInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrReleaseSwapchainImage", out IntPtr temp);
            _xrReleaseSwapchainImage_fnptr = (delegate* unmanaged<XrSwapchain, XrSwapchainImageReleaseInfo*, XrResult>)temp;
            return _xrReleaseSwapchainImage_fnptr(swapchain, releaseInfo);
        }
        public static delegate* unmanaged<XrSession, float, XrResult> _xrRequestDisplayRefreshRateFB_fnptr = &xrRequestDisplayRefreshRateFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrRequestDisplayRefreshRateFB_Lazy(XrSession session, float displayRefreshRate)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrRequestDisplayRefreshRateFB", out IntPtr temp);
            _xrRequestDisplayRefreshRateFB_fnptr = (delegate* unmanaged<XrSession, float, XrResult>)temp;
            return _xrRequestDisplayRefreshRateFB_fnptr(session, displayRefreshRate);
        }
        public static delegate* unmanaged<XrSession, XrResult> _xrRequestExitSession_fnptr = &xrRequestExitSession_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrRequestExitSession_Lazy(XrSession session)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrRequestExitSession", out IntPtr temp);
            _xrRequestExitSession_fnptr = (delegate* unmanaged<XrSession, XrResult>)temp;
            return _xrRequestExitSession_fnptr(session);
        }
        public static delegate* unmanaged<XrSession, XrMapLocalizationRequestInfoML*, XrResult> _xrRequestMapLocalizationML_fnptr = &xrRequestMapLocalizationML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrRequestMapLocalizationML_Lazy(XrSession session, XrMapLocalizationRequestInfoML* requestInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrRequestMapLocalizationML", out IntPtr temp);
            _xrRequestMapLocalizationML_fnptr = (delegate* unmanaged<XrSession, XrMapLocalizationRequestInfoML*, XrResult>)temp;
            return _xrRequestMapLocalizationML_fnptr(session, requestInfo);
        }
        public static delegate* unmanaged<XrSession, XrSceneCaptureRequestInfoFB*, ulong*, XrResult> _xrRequestSceneCaptureFB_fnptr = &xrRequestSceneCaptureFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrRequestSceneCaptureFB_Lazy(XrSession session, XrSceneCaptureRequestInfoFB* info, ulong* requestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrRequestSceneCaptureFB", out IntPtr temp);
            _xrRequestSceneCaptureFB_fnptr = (delegate* unmanaged<XrSession, XrSceneCaptureRequestInfoFB*, ulong*, XrResult>)temp;
            return _xrRequestSceneCaptureFB_fnptr(session, info, requestId);
        }
        public static delegate* unmanaged<XrWorldMeshDetectorML, XrWorldMeshGetInfoML*, XrWorldMeshBufferML*, ulong*, XrResult> _xrRequestWorldMeshAsyncML_fnptr = &xrRequestWorldMeshAsyncML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrRequestWorldMeshAsyncML_Lazy(XrWorldMeshDetectorML detector, XrWorldMeshGetInfoML* getInfo, XrWorldMeshBufferML* buffer, ulong* future)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrRequestWorldMeshAsyncML", out IntPtr temp);
            _xrRequestWorldMeshAsyncML_fnptr = (delegate* unmanaged<XrWorldMeshDetectorML, XrWorldMeshGetInfoML*, XrWorldMeshBufferML*, ulong*, XrResult>)temp;
            return _xrRequestWorldMeshAsyncML_fnptr(detector, getInfo, buffer, future);
        }
        public static delegate* unmanaged<XrWorldMeshDetectorML, XrWorldMeshRequestCompletionInfoML*, ulong, XrWorldMeshRequestCompletionML*, XrResult> _xrRequestWorldMeshCompleteML_fnptr = &xrRequestWorldMeshCompleteML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrRequestWorldMeshCompleteML_Lazy(XrWorldMeshDetectorML detector, XrWorldMeshRequestCompletionInfoML* completionInfo, ulong future, XrWorldMeshRequestCompletionML* completion)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrRequestWorldMeshCompleteML", out IntPtr temp);
            _xrRequestWorldMeshCompleteML_fnptr = (delegate* unmanaged<XrWorldMeshDetectorML, XrWorldMeshRequestCompletionInfoML*, ulong, XrWorldMeshRequestCompletionML*, XrResult>)temp;
            return _xrRequestWorldMeshCompleteML_fnptr(detector, completionInfo, future, completion);
        }
        public static delegate* unmanaged<XrWorldMeshDetectorML, XrWorldMeshStateRequestInfoML*, ulong*, XrResult> _xrRequestWorldMeshStateAsyncML_fnptr = &xrRequestWorldMeshStateAsyncML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrRequestWorldMeshStateAsyncML_Lazy(XrWorldMeshDetectorML detector, XrWorldMeshStateRequestInfoML* stateRequest, ulong* future)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrRequestWorldMeshStateAsyncML", out IntPtr temp);
            _xrRequestWorldMeshStateAsyncML_fnptr = (delegate* unmanaged<XrWorldMeshDetectorML, XrWorldMeshStateRequestInfoML*, ulong*, XrResult>)temp;
            return _xrRequestWorldMeshStateAsyncML_fnptr(detector, stateRequest, future);
        }
        public static delegate* unmanaged<XrWorldMeshDetectorML, ulong, XrWorldMeshStateRequestCompletionML*, XrResult> _xrRequestWorldMeshStateCompleteML_fnptr = &xrRequestWorldMeshStateCompleteML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrRequestWorldMeshStateCompleteML_Lazy(XrWorldMeshDetectorML detector, ulong future, XrWorldMeshStateRequestCompletionML* completion)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrRequestWorldMeshStateCompleteML", out IntPtr temp);
            _xrRequestWorldMeshStateCompleteML_fnptr = (delegate* unmanaged<XrWorldMeshDetectorML, ulong, XrWorldMeshStateRequestCompletionML*, XrResult>)temp;
            return _xrRequestWorldMeshStateCompleteML_fnptr(detector, future, completion);
        }
        public static delegate* unmanaged<XrInstance, XrResult, byte*, XrResult> _xrResultToString_fnptr = &xrResultToString_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrResultToString_Lazy(XrInstance instance, XrResult value, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrResultToString", out IntPtr temp);
            _xrResultToString_fnptr = (delegate* unmanaged<XrInstance, XrResult, byte*, XrResult>)temp;
            return _xrResultToString_fnptr(instance, value, buffer);
        }
        public static delegate* unmanaged<XrSession, ulong, XrSpaceQueryResultsFB*, XrResult> _xrRetrieveSpaceQueryResultsFB_fnptr = &xrRetrieveSpaceQueryResultsFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrRetrieveSpaceQueryResultsFB_Lazy(XrSession session, ulong requestId, XrSpaceQueryResultsFB* results)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrRetrieveSpaceQueryResultsFB", out IntPtr temp);
            _xrRetrieveSpaceQueryResultsFB_fnptr = (delegate* unmanaged<XrSession, ulong, XrSpaceQueryResultsFB*, XrResult>)temp;
            return _xrRetrieveSpaceQueryResultsFB_fnptr(session, requestId, results);
        }
        public static delegate* unmanaged<XrSession, XrSpaceSaveInfoFB*, ulong*, XrResult> _xrSaveSpaceFB_fnptr = &xrSaveSpaceFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSaveSpaceFB_Lazy(XrSession session, XrSpaceSaveInfoFB* info, ulong* requestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSaveSpaceFB", out IntPtr temp);
            _xrSaveSpaceFB_fnptr = (delegate* unmanaged<XrSession, XrSpaceSaveInfoFB*, ulong*, XrResult>)temp;
            return _xrSaveSpaceFB_fnptr(session, info, requestId);
        }
        public static delegate* unmanaged<XrSession, XrSpaceListSaveInfoFB*, ulong*, XrResult> _xrSaveSpaceListFB_fnptr = &xrSaveSpaceListFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSaveSpaceListFB_Lazy(XrSession session, XrSpaceListSaveInfoFB* info, ulong* requestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSaveSpaceListFB", out IntPtr temp);
            _xrSaveSpaceListFB_fnptr = (delegate* unmanaged<XrSession, XrSpaceListSaveInfoFB*, ulong*, XrResult>)temp;
            return _xrSaveSpaceListFB_fnptr(session, info, requestId);
        }
        public static delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardInputInfoMETA*, XrPosef*, XrResult> _xrSendVirtualKeyboardInputMETA_fnptr = &xrSendVirtualKeyboardInputMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSendVirtualKeyboardInputMETA_Lazy(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardInputInfoMETA* info, XrPosef* interactorRootPose)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSendVirtualKeyboardInputMETA", out IntPtr temp);
            _xrSendVirtualKeyboardInputMETA_fnptr = (delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardInputInfoMETA*, XrPosef*, XrResult>)temp;
            return _xrSendVirtualKeyboardInputMETA_fnptr(keyboard, info, interactorRootPose);
        }
        public static delegate* unmanaged<XrSession, XrDebugUtilsLabelEXT*, XrResult> _xrSessionBeginDebugUtilsLabelRegionEXT_fnptr = &xrSessionBeginDebugUtilsLabelRegionEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSessionBeginDebugUtilsLabelRegionEXT_Lazy(XrSession session, XrDebugUtilsLabelEXT* labelInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSessionBeginDebugUtilsLabelRegionEXT", out IntPtr temp);
            _xrSessionBeginDebugUtilsLabelRegionEXT_fnptr = (delegate* unmanaged<XrSession, XrDebugUtilsLabelEXT*, XrResult>)temp;
            return _xrSessionBeginDebugUtilsLabelRegionEXT_fnptr(session, labelInfo);
        }
        public static delegate* unmanaged<XrSession, XrResult> _xrSessionEndDebugUtilsLabelRegionEXT_fnptr = &xrSessionEndDebugUtilsLabelRegionEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSessionEndDebugUtilsLabelRegionEXT_Lazy(XrSession session)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSessionEndDebugUtilsLabelRegionEXT", out IntPtr temp);
            _xrSessionEndDebugUtilsLabelRegionEXT_fnptr = (delegate* unmanaged<XrSession, XrResult>)temp;
            return _xrSessionEndDebugUtilsLabelRegionEXT_fnptr(session);
        }
        public static delegate* unmanaged<XrSession, XrDebugUtilsLabelEXT*, XrResult> _xrSessionInsertDebugUtilsLabelEXT_fnptr = &xrSessionInsertDebugUtilsLabelEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSessionInsertDebugUtilsLabelEXT_Lazy(XrSession session, XrDebugUtilsLabelEXT* labelInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSessionInsertDebugUtilsLabelEXT", out IntPtr temp);
            _xrSessionInsertDebugUtilsLabelEXT_fnptr = (delegate* unmanaged<XrSession, XrDebugUtilsLabelEXT*, XrResult>)temp;
            return _xrSessionInsertDebugUtilsLabelEXT_fnptr(session, labelInfo);
        }
        public static delegate* unmanaged<XrSession, XrAndroidThreadTypeKHR, uint, XrResult> _xrSetAndroidApplicationThreadKHR_fnptr = &xrSetAndroidApplicationThreadKHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetAndroidApplicationThreadKHR_Lazy(XrSession session, XrAndroidThreadTypeKHR threadType, uint threadId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetAndroidApplicationThreadKHR", out IntPtr temp);
            _xrSetAndroidApplicationThreadKHR_fnptr = (delegate* unmanaged<XrSession, XrAndroidThreadTypeKHR, uint, XrResult>)temp;
            return _xrSetAndroidApplicationThreadKHR_fnptr(session, threadType, threadId);
        }
        public static delegate* unmanaged<XrSession, XrColorSpaceFB, XrResult> _xrSetColorSpaceFB_fnptr = &xrSetColorSpaceFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetColorSpaceFB_Lazy(XrSession session, XrColorSpaceFB colorSpace)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetColorSpaceFB", out IntPtr temp);
            _xrSetColorSpaceFB_fnptr = (delegate* unmanaged<XrSession, XrColorSpaceFB, XrResult>)temp;
            return _xrSetColorSpaceFB_fnptr(session, colorSpace);
        }
        public static delegate* unmanaged<XrInstance, XrDebugUtilsObjectNameInfoEXT*, XrResult> _xrSetDebugUtilsObjectNameEXT_fnptr = &xrSetDebugUtilsObjectNameEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetDebugUtilsObjectNameEXT_Lazy(XrInstance instance, XrDebugUtilsObjectNameInfoEXT* nameInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetDebugUtilsObjectNameEXT", out IntPtr temp);
            _xrSetDebugUtilsObjectNameEXT_fnptr = (delegate* unmanaged<XrInstance, XrDebugUtilsObjectNameInfoEXT*, XrResult>)temp;
            return _xrSetDebugUtilsObjectNameEXT_fnptr(instance, nameInfo);
        }
        public static delegate* unmanaged<XrSession, XrDigitalLensControlALMALENCE*, XrResult> _xrSetDigitalLensControlALMALENCE_fnptr = &xrSetDigitalLensControlALMALENCE_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetDigitalLensControlALMALENCE_Lazy(XrSession session, XrDigitalLensControlALMALENCE* digitalLensControl)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetDigitalLensControlALMALENCE", out IntPtr temp);
            _xrSetDigitalLensControlALMALENCE_fnptr = (delegate* unmanaged<XrSession, XrDigitalLensControlALMALENCE*, XrResult>)temp;
            return _xrSetDigitalLensControlALMALENCE_fnptr(session, digitalLensControl);
        }
        public static delegate* unmanaged<XrSession, int, XrResult> _xrSetEnvironmentDepthEstimationVARJO_fnptr = &xrSetEnvironmentDepthEstimationVARJO_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetEnvironmentDepthEstimationVARJO_Lazy(XrSession session, int enabled)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetEnvironmentDepthEstimationVARJO", out IntPtr temp);
            _xrSetEnvironmentDepthEstimationVARJO_fnptr = (delegate* unmanaged<XrSession, int, XrResult>)temp;
            return _xrSetEnvironmentDepthEstimationVARJO_fnptr(session, enabled);
        }
        public static delegate* unmanaged<XrEnvironmentDepthProviderMETA, XrEnvironmentDepthHandRemovalSetInfoMETA*, XrResult> _xrSetEnvironmentDepthHandRemovalMETA_fnptr = &xrSetEnvironmentDepthHandRemovalMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetEnvironmentDepthHandRemovalMETA_Lazy(XrEnvironmentDepthProviderMETA environmentDepthProvider, XrEnvironmentDepthHandRemovalSetInfoMETA* setInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetEnvironmentDepthHandRemovalMETA", out IntPtr temp);
            _xrSetEnvironmentDepthHandRemovalMETA_fnptr = (delegate* unmanaged<XrEnvironmentDepthProviderMETA, XrEnvironmentDepthHandRemovalSetInfoMETA*, XrResult>)temp;
            return _xrSetEnvironmentDepthHandRemovalMETA_fnptr(environmentDepthProvider, setInfo);
        }
        public static delegate* unmanaged<XrSession, ulong, ulong, int, XrResult> _xrSetInputDeviceActiveEXT_fnptr = &xrSetInputDeviceActiveEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetInputDeviceActiveEXT_Lazy(XrSession session, ulong interactionProfile, ulong topLevelPath, int isActive)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetInputDeviceActiveEXT", out IntPtr temp);
            _xrSetInputDeviceActiveEXT_fnptr = (delegate* unmanaged<XrSession, ulong, ulong, int, XrResult>)temp;
            return _xrSetInputDeviceActiveEXT_fnptr(session, interactionProfile, topLevelPath, isActive);
        }
        public static delegate* unmanaged<XrSession, ulong, ulong, XrSpace, XrPosef, XrResult> _xrSetInputDeviceLocationEXT_fnptr = &xrSetInputDeviceLocationEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetInputDeviceLocationEXT_Lazy(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrSpace space, XrPosef pose)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetInputDeviceLocationEXT", out IntPtr temp);
            _xrSetInputDeviceLocationEXT_fnptr = (delegate* unmanaged<XrSession, ulong, ulong, XrSpace, XrPosef, XrResult>)temp;
            return _xrSetInputDeviceLocationEXT_fnptr(session, topLevelPath, inputSourcePath, space, pose);
        }
        public static delegate* unmanaged<XrSession, ulong, ulong, int, XrResult> _xrSetInputDeviceStateBoolEXT_fnptr = &xrSetInputDeviceStateBoolEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetInputDeviceStateBoolEXT_Lazy(XrSession session, ulong topLevelPath, ulong inputSourcePath, int state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetInputDeviceStateBoolEXT", out IntPtr temp);
            _xrSetInputDeviceStateBoolEXT_fnptr = (delegate* unmanaged<XrSession, ulong, ulong, int, XrResult>)temp;
            return _xrSetInputDeviceStateBoolEXT_fnptr(session, topLevelPath, inputSourcePath, state);
        }
        public static delegate* unmanaged<XrSession, ulong, ulong, float, XrResult> _xrSetInputDeviceStateFloatEXT_fnptr = &xrSetInputDeviceStateFloatEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetInputDeviceStateFloatEXT_Lazy(XrSession session, ulong topLevelPath, ulong inputSourcePath, float state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetInputDeviceStateFloatEXT", out IntPtr temp);
            _xrSetInputDeviceStateFloatEXT_fnptr = (delegate* unmanaged<XrSession, ulong, ulong, float, XrResult>)temp;
            return _xrSetInputDeviceStateFloatEXT_fnptr(session, topLevelPath, inputSourcePath, state);
        }
        public static delegate* unmanaged<XrSession, ulong, ulong, XrVector2f, XrResult> _xrSetInputDeviceStateVector2fEXT_fnptr = &xrSetInputDeviceStateVector2fEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetInputDeviceStateVector2fEXT_Lazy(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrVector2f state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetInputDeviceStateVector2fEXT", out IntPtr temp);
            _xrSetInputDeviceStateVector2fEXT_fnptr = (delegate* unmanaged<XrSession, ulong, ulong, XrVector2f, XrResult>)temp;
            return _xrSetInputDeviceStateVector2fEXT_fnptr(session, topLevelPath, inputSourcePath, state);
        }
        public static delegate* unmanaged<XrSession, ulong, int, XrResult> _xrSetMarkerTrackingPredictionVARJO_fnptr = &xrSetMarkerTrackingPredictionVARJO_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetMarkerTrackingPredictionVARJO_Lazy(XrSession session, ulong markerId, int enable)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetMarkerTrackingPredictionVARJO", out IntPtr temp);
            _xrSetMarkerTrackingPredictionVARJO_fnptr = (delegate* unmanaged<XrSession, ulong, int, XrResult>)temp;
            return _xrSetMarkerTrackingPredictionVARJO_fnptr(session, markerId, enable);
        }
        public static delegate* unmanaged<XrSession, ulong, long, XrResult> _xrSetMarkerTrackingTimeoutVARJO_fnptr = &xrSetMarkerTrackingTimeoutVARJO_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetMarkerTrackingTimeoutVARJO_Lazy(XrSession session, ulong markerId, long timeout)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetMarkerTrackingTimeoutVARJO", out IntPtr temp);
            _xrSetMarkerTrackingTimeoutVARJO_fnptr = (delegate* unmanaged<XrSession, ulong, long, XrResult>)temp;
            return _xrSetMarkerTrackingTimeoutVARJO_fnptr(session, markerId, timeout);
        }
        public static delegate* unmanaged<XrSession, int, XrResult> _xrSetMarkerTrackingVARJO_fnptr = &xrSetMarkerTrackingVARJO_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetMarkerTrackingVARJO_Lazy(XrSession session, int enabled)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetMarkerTrackingVARJO", out IntPtr temp);
            _xrSetMarkerTrackingVARJO_fnptr = (delegate* unmanaged<XrSession, int, XrResult>)temp;
            return _xrSetMarkerTrackingVARJO_fnptr(session, enabled);
        }
        public static delegate* unmanaged<XrSession, XrPerformanceMetricsStateMETA*, XrResult> _xrSetPerformanceMetricsStateMETA_fnptr = &xrSetPerformanceMetricsStateMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetPerformanceMetricsStateMETA_Lazy(XrSession session, XrPerformanceMetricsStateMETA* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetPerformanceMetricsStateMETA", out IntPtr temp);
            _xrSetPerformanceMetricsStateMETA_fnptr = (delegate* unmanaged<XrSession, XrPerformanceMetricsStateMETA*, XrResult>)temp;
            return _xrSetPerformanceMetricsStateMETA_fnptr(session, state);
        }
        public static delegate* unmanaged<XrSpace, XrSpaceComponentStatusSetInfoFB*, ulong*, XrResult> _xrSetSpaceComponentStatusFB_fnptr = &xrSetSpaceComponentStatusFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetSpaceComponentStatusFB_Lazy(XrSpace space, XrSpaceComponentStatusSetInfoFB* info, ulong* requestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetSpaceComponentStatusFB", out IntPtr temp);
            _xrSetSpaceComponentStatusFB_fnptr = (delegate* unmanaged<XrSpace, XrSpaceComponentStatusSetInfoFB*, ulong*, XrResult>)temp;
            return _xrSetSpaceComponentStatusFB_fnptr(space, info, requestId);
        }
        public static delegate* unmanaged<XrInstance, XrSystemNotificationsSetInfoML*, XrResult> _xrSetSystemNotificationsML_fnptr = &xrSetSystemNotificationsML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetSystemNotificationsML_Lazy(XrInstance instance, XrSystemNotificationsSetInfoML* info)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetSystemNotificationsML", out IntPtr temp);
            _xrSetSystemNotificationsML_fnptr = (delegate* unmanaged<XrInstance, XrSystemNotificationsSetInfoML*, XrResult>)temp;
            return _xrSetSystemNotificationsML_fnptr(instance, info);
        }
        public static delegate* unmanaged<XrSession, XrTrackingOptimizationSettingsDomainQCOM, XrTrackingOptimizationSettingsHintQCOM, XrResult> _xrSetTrackingOptimizationSettingsHintQCOM_fnptr = &xrSetTrackingOptimizationSettingsHintQCOM_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetTrackingOptimizationSettingsHintQCOM_Lazy(XrSession session, XrTrackingOptimizationSettingsDomainQCOM domain, XrTrackingOptimizationSettingsHintQCOM hint)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetTrackingOptimizationSettingsHintQCOM", out IntPtr temp);
            _xrSetTrackingOptimizationSettingsHintQCOM_fnptr = (delegate* unmanaged<XrSession, XrTrackingOptimizationSettingsDomainQCOM, XrTrackingOptimizationSettingsHintQCOM, XrResult>)temp;
            return _xrSetTrackingOptimizationSettingsHintQCOM_fnptr(session, domain, hint);
        }
        public static delegate* unmanaged<XrSession, float, XrResult> _xrSetViewOffsetVARJO_fnptr = &xrSetViewOffsetVARJO_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetViewOffsetVARJO_Lazy(XrSession session, float offset)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetViewOffsetVARJO", out IntPtr temp);
            _xrSetViewOffsetVARJO_fnptr = (delegate* unmanaged<XrSession, float, XrResult>)temp;
            return _xrSetViewOffsetVARJO_fnptr(session, offset);
        }
        public static delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardModelVisibilitySetInfoMETA*, XrResult> _xrSetVirtualKeyboardModelVisibilityMETA_fnptr = &xrSetVirtualKeyboardModelVisibilityMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSetVirtualKeyboardModelVisibilityMETA_Lazy(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelVisibilitySetInfoMETA* modelVisibility)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSetVirtualKeyboardModelVisibilityMETA", out IntPtr temp);
            _xrSetVirtualKeyboardModelVisibilityMETA_fnptr = (delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardModelVisibilitySetInfoMETA*, XrResult>)temp;
            return _xrSetVirtualKeyboardModelVisibilityMETA_fnptr(keyboard, modelVisibility);
        }
        public static delegate* unmanaged<XrSession, XrSpaceShareInfoFB*, ulong*, XrResult> _xrShareSpacesFB_fnptr = &xrShareSpacesFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrShareSpacesFB_Lazy(XrSession session, XrSpaceShareInfoFB* info, ulong* requestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrShareSpacesFB", out IntPtr temp);
            _xrShareSpacesFB_fnptr = (delegate* unmanaged<XrSession, XrSpaceShareInfoFB*, ulong*, XrResult>)temp;
            return _xrShareSpacesFB_fnptr(session, info, requestId);
        }
        public static delegate* unmanaged<XrSession, XrShareSpacesInfoMETA*, ulong*, XrResult> _xrShareSpacesMETA_fnptr = &xrShareSpacesMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrShareSpacesMETA_Lazy(XrSession session, XrShareSpacesInfoMETA* info, ulong* requestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrShareSpacesMETA", out IntPtr temp);
            _xrShareSpacesMETA_fnptr = (delegate* unmanaged<XrSession, XrShareSpacesInfoMETA*, ulong*, XrResult>)temp;
            return _xrShareSpacesMETA_fnptr(session, info, requestId);
        }
        public static delegate* unmanaged<XrMarkerDetectorML, XrMarkerDetectorSnapshotInfoML*, XrResult> _xrSnapshotMarkerDetectorML_fnptr = &xrSnapshotMarkerDetectorML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSnapshotMarkerDetectorML_Lazy(XrMarkerDetectorML markerDetector, XrMarkerDetectorSnapshotInfoML* snapshotInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSnapshotMarkerDetectorML", out IntPtr temp);
            _xrSnapshotMarkerDetectorML_fnptr = (delegate* unmanaged<XrMarkerDetectorML, XrMarkerDetectorSnapshotInfoML*, XrResult>)temp;
            return _xrSnapshotMarkerDetectorML_fnptr(markerDetector, snapshotInfo);
        }
        public static delegate* unmanaged<XrSession, XrColocationAdvertisementStartInfoMETA*, ulong*, XrResult> _xrStartColocationAdvertisementMETA_fnptr = &xrStartColocationAdvertisementMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrStartColocationAdvertisementMETA_Lazy(XrSession session, XrColocationAdvertisementStartInfoMETA* info, ulong* advertisementRequestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrStartColocationAdvertisementMETA", out IntPtr temp);
            _xrStartColocationAdvertisementMETA_fnptr = (delegate* unmanaged<XrSession, XrColocationAdvertisementStartInfoMETA*, ulong*, XrResult>)temp;
            return _xrStartColocationAdvertisementMETA_fnptr(session, info, advertisementRequestId);
        }
        public static delegate* unmanaged<XrSession, XrColocationDiscoveryStartInfoMETA*, ulong*, XrResult> _xrStartColocationDiscoveryMETA_fnptr = &xrStartColocationDiscoveryMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrStartColocationDiscoveryMETA_Lazy(XrSession session, XrColocationDiscoveryStartInfoMETA* info, ulong* discoveryRequestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrStartColocationDiscoveryMETA", out IntPtr temp);
            _xrStartColocationDiscoveryMETA_fnptr = (delegate* unmanaged<XrSession, XrColocationDiscoveryStartInfoMETA*, ulong*, XrResult>)temp;
            return _xrStartColocationDiscoveryMETA_fnptr(session, info, discoveryRequestId);
        }
        public static delegate* unmanaged<XrEnvironmentDepthProviderMETA, XrResult> _xrStartEnvironmentDepthProviderMETA_fnptr = &xrStartEnvironmentDepthProviderMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrStartEnvironmentDepthProviderMETA_Lazy(XrEnvironmentDepthProviderMETA environmentDepthProvider)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrStartEnvironmentDepthProviderMETA", out IntPtr temp);
            _xrStartEnvironmentDepthProviderMETA_fnptr = (delegate* unmanaged<XrEnvironmentDepthProviderMETA, XrResult>)temp;
            return _xrStartEnvironmentDepthProviderMETA_fnptr(environmentDepthProvider);
        }
        public static delegate* unmanaged<XrSession, XrColocationAdvertisementStopInfoMETA*, ulong*, XrResult> _xrStopColocationAdvertisementMETA_fnptr = &xrStopColocationAdvertisementMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrStopColocationAdvertisementMETA_Lazy(XrSession session, XrColocationAdvertisementStopInfoMETA* info, ulong* requestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrStopColocationAdvertisementMETA", out IntPtr temp);
            _xrStopColocationAdvertisementMETA_fnptr = (delegate* unmanaged<XrSession, XrColocationAdvertisementStopInfoMETA*, ulong*, XrResult>)temp;
            return _xrStopColocationAdvertisementMETA_fnptr(session, info, requestId);
        }
        public static delegate* unmanaged<XrSession, XrColocationDiscoveryStopInfoMETA*, ulong*, XrResult> _xrStopColocationDiscoveryMETA_fnptr = &xrStopColocationDiscoveryMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrStopColocationDiscoveryMETA_Lazy(XrSession session, XrColocationDiscoveryStopInfoMETA* info, ulong* requestId)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrStopColocationDiscoveryMETA", out IntPtr temp);
            _xrStopColocationDiscoveryMETA_fnptr = (delegate* unmanaged<XrSession, XrColocationDiscoveryStopInfoMETA*, ulong*, XrResult>)temp;
            return _xrStopColocationDiscoveryMETA_fnptr(session, info, requestId);
        }
        public static delegate* unmanaged<XrEnvironmentDepthProviderMETA, XrResult> _xrStopEnvironmentDepthProviderMETA_fnptr = &xrStopEnvironmentDepthProviderMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrStopEnvironmentDepthProviderMETA_Lazy(XrEnvironmentDepthProviderMETA environmentDepthProvider)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrStopEnvironmentDepthProviderMETA", out IntPtr temp);
            _xrStopEnvironmentDepthProviderMETA_fnptr = (delegate* unmanaged<XrEnvironmentDepthProviderMETA, XrResult>)temp;
            return _xrStopEnvironmentDepthProviderMETA_fnptr(environmentDepthProvider);
        }
        public static delegate* unmanaged<XrSession, XrHapticActionInfo*, XrResult> _xrStopHapticFeedback_fnptr = &xrStopHapticFeedback_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrStopHapticFeedback_Lazy(XrSession session, XrHapticActionInfo* hapticActionInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrStopHapticFeedback", out IntPtr temp);
            _xrStopHapticFeedback_fnptr = (delegate* unmanaged<XrSession, XrHapticActionInfo*, XrResult>)temp;
            return _xrStopHapticFeedback_fnptr(session, hapticActionInfo);
        }
        public static delegate* unmanaged<XrInstance, byte*, ulong*, XrResult> _xrStringToPath_fnptr = &xrStringToPath_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrStringToPath_Lazy(XrInstance instance, byte* pathString, ulong* path)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrStringToPath", out IntPtr temp);
            _xrStringToPath_fnptr = (delegate* unmanaged<XrInstance, byte*, ulong*, XrResult>)temp;
            return _xrStringToPath_fnptr(instance, pathString, path);
        }
        public static delegate* unmanaged<XrInstance, XrStructureType, byte*, XrResult> _xrStructureTypeToString_fnptr = &xrStructureTypeToString_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrStructureTypeToString_Lazy(XrInstance instance, XrStructureType value, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrStructureTypeToString", out IntPtr temp);
            _xrStructureTypeToString_fnptr = (delegate* unmanaged<XrInstance, XrStructureType, byte*, XrResult>)temp;
            return _xrStructureTypeToString_fnptr(instance, value, buffer);
        }
        public static delegate* unmanaged<XrInstance, XrStructureType, byte*, XrResult> _xrStructureTypeToString2KHR_fnptr = &xrStructureTypeToString2KHR_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrStructureTypeToString2KHR_Lazy(XrInstance instance, XrStructureType value, byte* buffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrStructureTypeToString2KHR", out IntPtr temp);
            _xrStructureTypeToString2KHR_fnptr = (delegate* unmanaged<XrInstance, XrStructureType, byte*, XrResult>)temp;
            return _xrStructureTypeToString2KHR_fnptr(instance, value, buffer);
        }
        public static delegate* unmanaged<XrInstance, XrDebugUtilsMessageSeverityFlagBitsEXT, XrDebugUtilsMessageTypeFlagBitsEXT, XrDebugUtilsMessengerCallbackDataEXT*, XrResult> _xrSubmitDebugUtilsMessageEXT_fnptr = &xrSubmitDebugUtilsMessageEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSubmitDebugUtilsMessageEXT_Lazy(XrInstance instance, XrDebugUtilsMessageSeverityFlagBitsEXT messageSeverity, XrDebugUtilsMessageTypeFlagBitsEXT messageTypes, XrDebugUtilsMessengerCallbackDataEXT* callbackData)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSubmitDebugUtilsMessageEXT", out IntPtr temp);
            _xrSubmitDebugUtilsMessageEXT_fnptr = (delegate* unmanaged<XrInstance, XrDebugUtilsMessageSeverityFlagBitsEXT, XrDebugUtilsMessageTypeFlagBitsEXT, XrDebugUtilsMessengerCallbackDataEXT*, XrResult>)temp;
            return _xrSubmitDebugUtilsMessageEXT_fnptr(instance, messageSeverity, messageTypes, callbackData);
        }
        public static delegate* unmanaged<XrInstance, XrInteractionProfileSuggestedBinding*, XrResult> _xrSuggestInteractionProfileBindings_fnptr = &xrSuggestInteractionProfileBindings_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSuggestInteractionProfileBindings_Lazy(XrInstance instance, XrInteractionProfileSuggestedBinding* suggestedBindings)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSuggestInteractionProfileBindings", out IntPtr temp);
            _xrSuggestInteractionProfileBindings_fnptr = (delegate* unmanaged<XrInstance, XrInteractionProfileSuggestedBinding*, XrResult>)temp;
            return _xrSuggestInteractionProfileBindings_fnptr(instance, suggestedBindings);
        }
        public static delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardLocationInfoMETA*, XrResult> _xrSuggestVirtualKeyboardLocationMETA_fnptr = &xrSuggestVirtualKeyboardLocationMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSuggestVirtualKeyboardLocationMETA_Lazy(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardLocationInfoMETA* locationInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSuggestVirtualKeyboardLocationMETA", out IntPtr temp);
            _xrSuggestVirtualKeyboardLocationMETA_fnptr = (delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardLocationInfoMETA*, XrResult>)temp;
            return _xrSuggestVirtualKeyboardLocationMETA_fnptr(keyboard, locationInfo);
        }
        public static delegate* unmanaged<XrSession, XrActionsSyncInfo*, XrResult> _xrSyncActions_fnptr = &xrSyncActions_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrSyncActions_Lazy(XrSession session, XrActionsSyncInfo* syncInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrSyncActions", out IntPtr temp);
            _xrSyncActions_fnptr = (delegate* unmanaged<XrSession, XrActionsSyncInfo*, XrResult>)temp;
            return _xrSyncActions_fnptr(session, syncInfo);
        }
        public static delegate* unmanaged<XrSession, XrPerfSettingsDomainEXT, XrPerfSettingsNotificationLevelEXT*, float*, float*, XrResult> _xrThermalGetTemperatureTrendEXT_fnptr = &xrThermalGetTemperatureTrendEXT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrThermalGetTemperatureTrendEXT_Lazy(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsNotificationLevelEXT* notificationLevel, float* tempHeadroom, float* tempSlope)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrThermalGetTemperatureTrendEXT", out IntPtr temp);
            _xrThermalGetTemperatureTrendEXT_fnptr = (delegate* unmanaged<XrSession, XrPerfSettingsDomainEXT, XrPerfSettingsNotificationLevelEXT*, float*, float*, XrResult>)temp;
            return _xrThermalGetTemperatureTrendEXT_fnptr(session, domain, notificationLevel, tempHeadroom, tempSlope);
        }
        public static delegate* unmanaged<XrTriangleMeshFB, XrResult> _xrTriangleMeshBeginUpdateFB_fnptr = &xrTriangleMeshBeginUpdateFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrTriangleMeshBeginUpdateFB_Lazy(XrTriangleMeshFB mesh)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrTriangleMeshBeginUpdateFB", out IntPtr temp);
            _xrTriangleMeshBeginUpdateFB_fnptr = (delegate* unmanaged<XrTriangleMeshFB, XrResult>)temp;
            return _xrTriangleMeshBeginUpdateFB_fnptr(mesh);
        }
        public static delegate* unmanaged<XrTriangleMeshFB, uint*, XrResult> _xrTriangleMeshBeginVertexBufferUpdateFB_fnptr = &xrTriangleMeshBeginVertexBufferUpdateFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrTriangleMeshBeginVertexBufferUpdateFB_Lazy(XrTriangleMeshFB mesh, uint* outVertexCount)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrTriangleMeshBeginVertexBufferUpdateFB", out IntPtr temp);
            _xrTriangleMeshBeginVertexBufferUpdateFB_fnptr = (delegate* unmanaged<XrTriangleMeshFB, uint*, XrResult>)temp;
            return _xrTriangleMeshBeginVertexBufferUpdateFB_fnptr(mesh, outVertexCount);
        }
        public static delegate* unmanaged<XrTriangleMeshFB, uint, uint, XrResult> _xrTriangleMeshEndUpdateFB_fnptr = &xrTriangleMeshEndUpdateFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrTriangleMeshEndUpdateFB_Lazy(XrTriangleMeshFB mesh, uint vertexCount, uint triangleCount)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrTriangleMeshEndUpdateFB", out IntPtr temp);
            _xrTriangleMeshEndUpdateFB_fnptr = (delegate* unmanaged<XrTriangleMeshFB, uint, uint, XrResult>)temp;
            return _xrTriangleMeshEndUpdateFB_fnptr(mesh, vertexCount, triangleCount);
        }
        public static delegate* unmanaged<XrTriangleMeshFB, XrResult> _xrTriangleMeshEndVertexBufferUpdateFB_fnptr = &xrTriangleMeshEndVertexBufferUpdateFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrTriangleMeshEndVertexBufferUpdateFB_Lazy(XrTriangleMeshFB mesh)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrTriangleMeshEndVertexBufferUpdateFB", out IntPtr temp);
            _xrTriangleMeshEndVertexBufferUpdateFB_fnptr = (delegate* unmanaged<XrTriangleMeshFB, XrResult>)temp;
            return _xrTriangleMeshEndVertexBufferUpdateFB_fnptr(mesh);
        }
        public static delegate* unmanaged<XrTriangleMeshFB, uint**, XrResult> _xrTriangleMeshGetIndexBufferFB_fnptr = &xrTriangleMeshGetIndexBufferFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrTriangleMeshGetIndexBufferFB_Lazy(XrTriangleMeshFB mesh, uint** outIndexBuffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrTriangleMeshGetIndexBufferFB", out IntPtr temp);
            _xrTriangleMeshGetIndexBufferFB_fnptr = (delegate* unmanaged<XrTriangleMeshFB, uint**, XrResult>)temp;
            return _xrTriangleMeshGetIndexBufferFB_fnptr(mesh, outIndexBuffer);
        }
        public static delegate* unmanaged<XrTriangleMeshFB, XrVector3f**, XrResult> _xrTriangleMeshGetVertexBufferFB_fnptr = &xrTriangleMeshGetVertexBufferFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrTriangleMeshGetVertexBufferFB_Lazy(XrTriangleMeshFB mesh, XrVector3f** outVertexBuffer)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrTriangleMeshGetVertexBufferFB", out IntPtr temp);
            _xrTriangleMeshGetVertexBufferFB_fnptr = (delegate* unmanaged<XrTriangleMeshFB, XrVector3f**, XrResult>)temp;
            return _xrTriangleMeshGetVertexBufferFB_fnptr(mesh, outVertexBuffer);
        }
        public static delegate* unmanaged<XrSession, XrSpatialGraphStaticNodeBindingCreateInfoMSFT*, XrSpatialGraphNodeBindingMSFT*, XrResult> _xrTryCreateSpatialGraphStaticNodeBindingMSFT_fnptr = &xrTryCreateSpatialGraphStaticNodeBindingMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrTryCreateSpatialGraphStaticNodeBindingMSFT_Lazy(XrSession session, XrSpatialGraphStaticNodeBindingCreateInfoMSFT* createInfo, XrSpatialGraphNodeBindingMSFT* nodeBinding)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrTryCreateSpatialGraphStaticNodeBindingMSFT", out IntPtr temp);
            _xrTryCreateSpatialGraphStaticNodeBindingMSFT_fnptr = (delegate* unmanaged<XrSession, XrSpatialGraphStaticNodeBindingCreateInfoMSFT*, XrSpatialGraphNodeBindingMSFT*, XrResult>)temp;
            return _xrTryCreateSpatialGraphStaticNodeBindingMSFT_fnptr(session, createInfo, nodeBinding);
        }
        public static delegate* unmanaged<XrSession, XrSpatialAnchorMSFT, IntPtr**, XrResult> _xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_fnptr = &xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_Lazy(XrSession session, XrSpatialAnchorMSFT anchor, IntPtr** perceptionAnchor)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrTryGetPerceptionAnchorFromSpatialAnchorMSFT", out IntPtr temp);
            _xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_fnptr = (delegate* unmanaged<XrSession, XrSpatialAnchorMSFT, IntPtr**, XrResult>)temp;
            return _xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_fnptr(session, anchor, perceptionAnchor);
        }
        public static delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrSpatialAnchorPersistenceNameMSFT*, XrResult> _xrUnpersistSpatialAnchorMSFT_fnptr = &xrUnpersistSpatialAnchorMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrUnpersistSpatialAnchorMSFT_Lazy(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorPersistenceName)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrUnpersistSpatialAnchorMSFT", out IntPtr temp);
            _xrUnpersistSpatialAnchorMSFT_fnptr = (delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrSpatialAnchorPersistenceNameMSFT*, XrResult>)temp;
            return _xrUnpersistSpatialAnchorMSFT_fnptr(spatialAnchorStore, spatialAnchorPersistenceName);
        }
        public static delegate* unmanaged<XrHandTrackerEXT, XrHandMeshUpdateInfoMSFT*, XrHandMeshMSFT*, XrResult> _xrUpdateHandMeshMSFT_fnptr = &xrUpdateHandMeshMSFT_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrUpdateHandMeshMSFT_Lazy(XrHandTrackerEXT handTracker, XrHandMeshUpdateInfoMSFT* updateInfo, XrHandMeshMSFT* handMesh)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrUpdateHandMeshMSFT", out IntPtr temp);
            _xrUpdateHandMeshMSFT_fnptr = (delegate* unmanaged<XrHandTrackerEXT, XrHandMeshUpdateInfoMSFT*, XrHandMeshMSFT*, XrResult>)temp;
            return _xrUpdateHandMeshMSFT_fnptr(handTracker, updateInfo, handMesh);
        }
        public static delegate* unmanaged<XrPassthroughColorLutMETA, XrPassthroughColorLutUpdateInfoMETA*, XrResult> _xrUpdatePassthroughColorLutMETA_fnptr = &xrUpdatePassthroughColorLutMETA_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrUpdatePassthroughColorLutMETA_Lazy(XrPassthroughColorLutMETA colorLut, XrPassthroughColorLutUpdateInfoMETA* updateInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrUpdatePassthroughColorLutMETA", out IntPtr temp);
            _xrUpdatePassthroughColorLutMETA_fnptr = (delegate* unmanaged<XrPassthroughColorLutMETA, XrPassthroughColorLutUpdateInfoMETA*, XrResult>)temp;
            return _xrUpdatePassthroughColorLutMETA_fnptr(colorLut, updateInfo);
        }
        public static delegate* unmanaged<XrSpatialAnchorsStorageML, XrSpatialAnchorsUpdateExpirationInfoML*, ulong*, XrResult> _xrUpdateSpatialAnchorsExpirationAsyncML_fnptr = &xrUpdateSpatialAnchorsExpirationAsyncML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrUpdateSpatialAnchorsExpirationAsyncML_Lazy(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsUpdateExpirationInfoML* updateInfo, ulong* future)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrUpdateSpatialAnchorsExpirationAsyncML", out IntPtr temp);
            _xrUpdateSpatialAnchorsExpirationAsyncML_fnptr = (delegate* unmanaged<XrSpatialAnchorsStorageML, XrSpatialAnchorsUpdateExpirationInfoML*, ulong*, XrResult>)temp;
            return _xrUpdateSpatialAnchorsExpirationAsyncML_fnptr(storage, updateInfo, future);
        }
        public static delegate* unmanaged<XrSpatialAnchorsStorageML, ulong, XrSpatialAnchorsUpdateExpirationCompletionML*, XrResult> _xrUpdateSpatialAnchorsExpirationCompleteML_fnptr = &xrUpdateSpatialAnchorsExpirationCompleteML_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrUpdateSpatialAnchorsExpirationCompleteML_Lazy(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsUpdateExpirationCompletionML* completion)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrUpdateSpatialAnchorsExpirationCompleteML", out IntPtr temp);
            _xrUpdateSpatialAnchorsExpirationCompleteML_fnptr = (delegate* unmanaged<XrSpatialAnchorsStorageML, ulong, XrSpatialAnchorsUpdateExpirationCompletionML*, XrResult>)temp;
            return _xrUpdateSpatialAnchorsExpirationCompleteML_fnptr(storage, future, completion);
        }
        public static delegate* unmanaged<XrSwapchain, XrSwapchainStateBaseHeaderFB*, XrResult> _xrUpdateSwapchainFB_fnptr = &xrUpdateSwapchainFB_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrUpdateSwapchainFB_Lazy(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrUpdateSwapchainFB", out IntPtr temp);
            _xrUpdateSwapchainFB_fnptr = (delegate* unmanaged<XrSwapchain, XrSwapchainStateBaseHeaderFB*, XrResult>)temp;
            return _xrUpdateSwapchainFB_fnptr(swapchain, state);
        }
        public static delegate* unmanaged<XrSession, XrFrameWaitInfo*, XrFrameState*, XrResult> _xrWaitFrame_fnptr = &xrWaitFrame_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrWaitFrame_Lazy(XrSession session, XrFrameWaitInfo* frameWaitInfo, XrFrameState* frameState)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrWaitFrame", out IntPtr temp);
            _xrWaitFrame_fnptr = (delegate* unmanaged<XrSession, XrFrameWaitInfo*, XrFrameState*, XrResult>)temp;
            return _xrWaitFrame_fnptr(session, frameWaitInfo, frameState);
        }
        public static delegate* unmanaged<XrSwapchain, XrSwapchainImageWaitInfo*, XrResult> _xrWaitSwapchainImage_fnptr = &xrWaitSwapchainImage_Lazy;
        [UnmanagedCallersOnly]
        private static XrResult xrWaitSwapchainImage_Lazy(XrSwapchain swapchain, XrSwapchainImageWaitInfo* waitInfo)
        {
            XrResult result = XRLoader.GetInstanceProcAddress("xrWaitSwapchainImage", out IntPtr temp);
            _xrWaitSwapchainImage_fnptr = (delegate* unmanaged<XrSwapchain, XrSwapchainImageWaitInfo*, XrResult>)temp;
            return _xrWaitSwapchainImage_fnptr(swapchain, waitInfo);
        }
    }
#pragma warning restore CA2211 // Non-constant fields should not be visible
#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
